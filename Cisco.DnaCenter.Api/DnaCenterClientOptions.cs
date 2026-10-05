using Cisco.DnaCenter.Api.Exceptions;
using System;
using System.Net.Http;
using System.Text;

namespace Cisco.DnaCenter.Api;

/// <summary>
/// Options for a DNA Center Client
/// </summary>
public class DnaCenterClientOptions
{
	/// <summary>
	/// An HttpClient - if provided, it must implement header security by overriding the HttpClientHandler's SendAsync() method.
	/// </summary>
	public HttpClient? HttpClient { get; set; }

	/// <summary>
	/// The authenitcation token
	/// </summary>
	public string? Token { get; set; }

	/// <summary>
	///  The DNA center's Uri
	/// </summary>
	public Uri? Uri { get; set; }

	/// <summary>
	/// The username
	/// </summary>
	public string? Username { get; set; }

	/// <summary>
	/// The password
	/// </summary>
	public string? Password { get; set; }

	/// <summary>
	/// Whether to use username/password to authenticate.
	/// </summary>
	public bool IsUsernamePasswordAuthenticated => Username != null && Password != null;

	/// <summary>
	/// Whether to ignore SSL certificate errors
	/// </summary>
	public bool IgnoreSslCertificateErrors { get; set; }

	/// <summary>
	/// An optional User-Agent string to attach to outgoing requests.
	/// </summary>
	public string? UserAgent { get; set; }

	/// <summary>
	/// Maximum backoff delay in seconds for retries.
	/// </summary>
	public int MaxBackOffDelaySeconds { get; set; } = 32;

	/// <summary>
	/// Backoff delay factor (exponential).
	/// </summary>
	public double BackOffDelayFactor { get; set; } = 2.0;

	/// <summary>
	/// Maximum number of retry attempts.
	/// </summary>
	public int MaxAttemptCount { get; set; } = 5;

	/// <summary>
	/// Throws if these options are not a usable configuration.
	/// </summary>
	/// <exception cref="ConfigurationException">The options are not usable.</exception>
	public void Validate()
	{
		if (MaxBackOffDelaySeconds < 1)
		{
			throw new ConfigurationException($"{nameof(MaxBackOffDelaySeconds)} must be at least 1.");
		}

		if (BackOffDelayFactor < 1.0)
		{
			throw new ConfigurationException($"{nameof(BackOffDelayFactor)} must be at least 1.0.");
		}

		if (MaxAttemptCount < 1)
		{
			throw new ConfigurationException($"{nameof(MaxAttemptCount)} must be at least 1.");
		}

		if (HttpClient != null)
		{
			ValidateWithHttpClient();
		}
		else
		{
			ValidateWithoutHttpClient();
		}
	}

	// If an HttpClient is provided, Username, Password and Token should NOT be
	private void ValidateWithHttpClient()
	{
		ThrowIfSet(Token, nameof(Token));
		ThrowIfSet(Username, nameof(Username));
		ThrowIfSet(Password, nameof(Password));

		static void ThrowIfSet(object? value, string name)
		{
			if (value != null)
			{
				throw new ConfigurationException($"If {nameof(HttpClient)} is provided, {name} should not be.");
			}
		}
	}

	private void ValidateWithoutHttpClient()
	{
		// If an HttpClient is not provided, Uri must be
		if (Uri is null)
		{
			throw new ConfigurationException($"If {nameof(HttpClient)} is not provided, {nameof(Uri)} must be.");
		}

		if (Token is null)
		{
			// No token - Username and password must be provided
			if (Username is null)
			{
				throw new ConfigurationException($"If {nameof(HttpClient)} and {nameof(Token)} are not provided, {nameof(Username)} must be.");
			}
			if (Password is null)
			{
				throw new ConfigurationException($"If {nameof(HttpClient)} and {nameof(Token)} are not provided, {nameof(Password)} must be.");
			}

			return;
		}

		// Token provided - Username and password must not be
		if (Username != null)
		{
			throw new ConfigurationException($"If {nameof(HttpClient)} is not provided and {nameof(Token)} is provided, {nameof(Username)} must not be.");
		}
		if (Password != null)
		{
			throw new ConfigurationException($"If {nameof(HttpClient)} is not provided and {nameof(Token)} is provided, {nameof(Password)} must not be.");
		}
	}

	internal string GetBase64UsernamePassword()
	{
		if (Username is null || Password is null)
		{
			throw new InvalidOperationException($"Cannot get base 64 - {nameof(Username)} and/or {nameof(Password)} is null.");
		}
		return Convert.ToBase64String(Encoding.ASCII.GetBytes($"{Username}:{Password}"));
	}
}