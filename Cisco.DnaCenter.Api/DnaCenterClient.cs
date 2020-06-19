using Cisco.DnaCenter.Api.Data;
using Cisco.DnaCenter.Api.Interfaces;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Refit;
using System;
using System.Data;
using System.Diagnostics;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Cisco.DnaCenter.Api
{
	/// <summary>
	/// API client is mainly responsible for making the HTTP call to the API backend.
	/// </summary>
	public class DnaCenterClient : IDisposable
	{
		private HttpClient? _httpClient;
		private readonly ILogger _logger;
		private readonly DnaCenterClientOptions _options;

		public bool IsConnected { get; private set; }

		public DnaCenterClient(DnaCenterClientOptions options, ILogger? logger = null)
		{
			_logger = logger ?? NullLogger.Instance;

			if (options is null)
			{
				throw new ArgumentNullException(nameof(options));
			}
			options.Validate();
			// Options are valid

			_options = options;

			if (_options.HttpClient != null)
			{
				// An HttpClient was provided to us.
				_httpClient = _options.HttpClient;
			}
			else
			{
				// We are creating an HttpClient (one was not provided), so set _httpClient so that we know to dispose of it later.
				_authenticatedHttpClientHandler = new AuthenticatedHttpClientHandler(this, _options.Token, _logger);
				_httpClient = new HttpClient(_authenticatedHttpClientHandler)
				{
					BaseAddress = _options.Uri
				};
				_shouldDisposeHttpClient = true;
			}

			ApplicationPolicies = RestService.For<IApplicationPolicies>(_httpClient);
			Authentication = RestService.For<IAuthentication>(_httpClient);
			Business = RestService.For<IBusiness>(_httpClient);
			Clients = RestService.For<IClients>(_httpClient);
			CommandRunner = RestService.For<ICommandRunner>(_httpClient);
			ConfigurationTemplates = RestService.For<IConfigurationTemplates>(_httpClient);
			DeviceOnboardingPnp = RestService.For<IDeviceOnboardingPnp>(_httpClient);
			Devices = RestService.For<IDevices>(_httpClient);
			EventManagement = RestService.For<IEventManagement>(_httpClient);
			Files = RestService.For<IFiles>(_httpClient);
			Issues = RestService.For<IIssues>(_httpClient);
			Maps = RestService.For<IMaps>(_httpClient);
			NetworkDiscovery = RestService.For<INetworkDiscovery>(_httpClient);
			NetworkSettings = RestService.For<INetworkSettings>(_httpClient);
			NonFabricWireless = RestService.For<INonFabricWireless>(_httpClient);
			PathTrace = RestService.For<IPathTrace>(_httpClient);
			Sda = RestService.For<ISda>(_httpClient);
			SiteDesign = RestService.For<ISiteDesign>(_httpClient);
			Sites = RestService.For<ISites>(_httpClient);
			SoftwareImages = RestService.For<ISoftwareImages>(_httpClient);
			Tags = RestService.For<ITags>(_httpClient);
			Tasks = RestService.For<ITasks>(_httpClient);
			Topologies = RestService.For<ITopologies>(_httpClient);
			Users = RestService.For<IUsers>(_httpClient);
		}

		public async Task ConnectAsync(CancellationToken cancellationToken = default)
		{
			if (!_options.IsUsernamePasswordAuthenticated)
			{
				throw new InvalidOperationException("There is no need to connect.  An HttpClient or Token were already provided.");
			}

			if (IsConnected)
			{
				throw new InvalidOperationException("Already connected.");
			}

			if (_authenticatedHttpClientHandler is null)
			{
				throw new InvalidOperationException("The _authenticatedHttpClientHandler is null.  This should not happen.");
			}

			AuthenticationResponse authenticationResponse;
			try
			{
				var base64UsernameAndPassword = _options.GetBase64UsernamePassword();
				authenticationResponse = await Authentication
					.Authenticate($"Basic: {base64UsernameAndPassword}", cancellationToken)
					.ConfigureAwait(false);
			}
			catch (Exception e)
			{
				_logger.LogError(e.Message, e);
				throw;
			}
			_authenticatedHttpClientHandler.Token = authenticationResponse.Token ?? throw new DataException("Api returned null Token.");
			IsConnected = true;
		}

		/// <inheritdoc />
		public IApplicationPolicies ApplicationPolicies { get; }

		/// <inheritdoc />
		public IAuthentication Authentication { get; }

		/// <inheritdoc />
		public IBusiness Business { get; }

		/// <inheritdoc />
		public IClients Clients { get; }

		/// <inheritdoc />
		public ICommandRunner CommandRunner { get; }

		/// <inheritdoc />
		public IConfigurationTemplates ConfigurationTemplates { get; }

		/// <inheritdoc />
		public IDeviceOnboardingPnp DeviceOnboardingPnp { get; }

		/// <inheritdoc />
		public IDevices Devices { get; }

		/// <inheritdoc />
		public IEventManagement EventManagement { get; }

		/// <inheritdoc />
		public IFiles Files { get; }

		/// <inheritdoc />
		public IIssues Issues { get; }

		/// <inheritdoc />
		public IMaps Maps { get; }

		/// <inheritdoc />
		public INetworkDiscovery NetworkDiscovery { get; }

		/// <inheritdoc />
		public INetworkSettings NetworkSettings { get; }

		/// <inheritdoc />
		public INonFabricWireless NonFabricWireless { get; }

		/// <inheritdoc />
		public IPathTrace PathTrace { get; }

		/// <inheritdoc />
		public ISda Sda { get; }

		/// <inheritdoc />
		public ISiteDesign SiteDesign { get; }

		/// <inheritdoc />
		public ISites Sites { get; }

		/// <inheritdoc />
		public ISoftwareImages SoftwareImages { get; }

		/// <inheritdoc />
		public ITags Tags { get; }

		/// <inheritdoc />
		public ITasks Tasks { get; }

		/// <inheritdoc />
		public ITopologies Topologies { get; }

		/// <inheritdoc />
		public IUsers Users { get; }

		public async Task<ExecutionStatus> GetFinalExecutionStatusAsync(
			string executionId,
			TimeSpan? timeout = null,
			TimeSpan? pollingDelay = null,
			TimeSpan? initialDelay = null,
			CancellationToken cancellationToken = default
			)
		{
			if (executionId is null)
			{
				throw new ArgumentNullException(nameof(executionId));
			}

			var timeoutStopwatch = Stopwatch.StartNew();
			pollingDelay ??= TimeSpan.FromMilliseconds(500);
			timeout ??= TimeSpan.MaxValue;

			// The user may have some knowledge that there is a minimum delay before it is worth polling.
			if (initialDelay != null)
			{
				await Task.Delay(initialDelay.Value, cancellationToken).ConfigureAwait(false);
			}

			while (true)
			{
				if (cancellationToken.IsCancellationRequested)
				{
					cancellationToken.ThrowIfCancellationRequested();
				}

				var executionStatus = await Business
					.GetExecutionStatusAsync(executionId, cancellationToken)
					.ConfigureAwait(false);

				switch (executionStatus.Status)
				{
					case ExecutionStatusStatus.Success:
					case ExecutionStatusStatus.Failure:
						return executionStatus;
					case ExecutionStatusStatus.InProgress:
						if (timeoutStopwatch.Elapsed > timeout)
						{
							return executionStatus;
						}
						break;
				}

				await Task.Delay(pollingDelay.Value, cancellationToken).ConfigureAwait(false);
			}
		}

		#region IDisposable Support
		private bool _disposedValue = false; // To detect redundant calls

		// Only set if an HttpsClient was NOT provided in the options.
		private readonly bool _shouldDisposeHttpClient;
		private readonly AuthenticatedHttpClientHandler? _authenticatedHttpClientHandler;

		protected virtual void Dispose(bool disposing)
		{
			if (!_disposedValue)
			{
				if (disposing)
				{
					// Dispose managed state (managed objects).
					if (_shouldDisposeHttpClient)
					{
						_httpClient?.Dispose();
						_httpClient = null;
					}
				}

				// TODO: set large fields to null.

				_disposedValue = true;
			}
		}

		// This code added to correctly implement the disposable pattern.
		public void Dispose() =>
			// Do not change this code. Put cleanup code in Dispose(bool disposing) above.
			Dispose(true);// TODO: uncomment the following line if the finalizer is overridden above.// GC.SuppressFinalize(this);
		#endregion
	}
}