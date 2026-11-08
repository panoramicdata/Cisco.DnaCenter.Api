using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Cisco.DnaCenter.Test;

internal sealed record ReceivedRequest(string Path, string? AuthToken);

/// <summary>
/// A scripted HTTP server on the loopback interface, so client tests need no DNA Center or credentials.
/// </summary>
internal sealed class ScriptedServer : IDisposable
{
	private readonly HttpListener _listener = new();
	private readonly Dictionary<string, Queue<(int Status, string Body)>> _script = new();
	private readonly ConcurrentQueue<ReceivedRequest> _received = new();
	private readonly (int Status, string Body) _defaultResponse;

	public Uri BaseUri { get; }

	public IReadOnlyList<ReceivedRequest> Received => _received.ToList();

	public ScriptedServer()
		: this((404, string.Empty))
	{
	}

	public ScriptedServer((int Status, string Body) defaultResponse)
	{
		_defaultResponse = defaultResponse;

		var probe = new TcpListener(IPAddress.Loopback, 0);
		probe.Start();
		var port = ((IPEndPoint)probe.LocalEndpoint).Port;
		probe.Stop();

		BaseUri = new Uri($"http://127.0.0.1:{port}/");
		_listener.Prefixes.Add(BaseUri.AbsoluteUri);
		_listener.Start();
		_ = Task.Run(ServeAsync);
	}

	// The last scripted response for a path repeats once the queue is down to one entry.
	public ScriptedServer On(string path, params (int Status, string Body)[] responses)
	{
		_script[path] = new Queue<(int, string)>(responses);
		return this;
	}

	private async Task ServeAsync()
	{
		while (_listener.IsListening)
		{
			HttpListenerContext context;
			try
			{
				context = await _listener.GetContextAsync().ConfigureAwait(false);
			}
			catch (Exception e) when (e is HttpListenerException or ObjectDisposedException or InvalidOperationException)
			{
				return;
			}

			var path = context.Request.Url!.AbsolutePath;
			_received.Enqueue(new ReceivedRequest(path, context.Request.Headers["X-Auth-Token"]));

			var (status, body) = NextResponse(path);
			var bytes = Encoding.UTF8.GetBytes(body);
			context.Response.StatusCode = status;
			context.Response.ContentType = "application/json";
			context.Response.ContentLength64 = bytes.Length;
			await context.Response.OutputStream.WriteAsync(bytes).ConfigureAwait(false);
			context.Response.Close();
		}
	}

	private (int Status, string Body) NextResponse(string path)
	{
		if (!_script.TryGetValue(path, out var queue))
		{
			return _defaultResponse;
		}

		lock (queue)
		{
			return queue.Count > 1 ? queue.Dequeue() : queue.Peek();
		}
	}

	public void Dispose() => _listener.Close();
}