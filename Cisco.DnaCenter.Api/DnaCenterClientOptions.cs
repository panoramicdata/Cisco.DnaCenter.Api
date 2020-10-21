using Cisco.DnaCenter.Api.Exceptions;
using System;
using System.Net.Http;
using System.Text;

namespace Cisco.DnaCenter.Api
{
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

		public void Validate()
		{
			// If an HttpClient is provided, Username, Password, Token and Uri should NOT be
			if (HttpClient != null)
			{
				if (Token != null)
				{
					throw new ConfigurationException($"If {nameof(HttpClient)} is provided, {nameof(Token)} should not be.");
				}
				if (Username != null)
				{
					throw new ConfigurationException($"If {nameof(HttpClient)} is provided, {nameof(Username)} should not be.");
				}
				if (Password != null)
				{
					throw new ConfigurationException($"If {nameof(HttpClient)} is provided, {nameof(Password)} should not be.");
				}
			}
			else
			{
				// If an HttpClient is not provided, Uri must be
				if (Uri is null)
				{
					throw new ConfigurationException($"If {nameof(HttpClient)} is not provided, {nameof(Uri)} must be.");
				}

				// Is the Token provided?
				if (Token is null)
				{
					// No - Username and password must be
					if (Username is null)
					{
						throw new ConfigurationException($"If {nameof(HttpClient)} and {nameof(Token)} are not provided, {nameof(Username)} must be.");
					}
					if (Password is null)
					{
						throw new ConfigurationException($"If {nameof(HttpClient)} and {nameof(Token)} are not provided, {nameof(Password)} must be.");
					}
				}
				else
				{
					// Yes - Username and password must not be
					if (Username != null)
					{
						throw new ConfigurationException($"If {nameof(HttpClient)} is not provided and {nameof(Token)} is provided, {nameof(Username)} must not be.");
					}
					if (Password != null)
					{
						throw new ConfigurationException($"If {nameof(HttpClient)} is not provided and {nameof(Token)} is provided, {nameof(Password)} must not be.");
					}
				}
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
}