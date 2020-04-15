using Cisco.DnaCenter.Api.Exceptions;
using System;
using System.Net.Http;

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
		/// The authentication scheme to use
		/// TODO - Remove
		/// </summary>
		public string? Scheme { get; set; }

		/// <summary>
		/// The authenitcation token
		/// </summary>
		public string? Token { get; set; }

		/// <summary>
		///  The DNA centert's Uri
		/// </summary>
		public Uri? Uri { get; set; }

		public void Validate()
		{
			// If an HttpClient is provided, Scheme, Token and Uri should NOT be
			if (HttpClient != null)
			{
				if (Scheme != null)
				{
					throw new ConfigurationException($"If {nameof(HttpClient)} is provided, {nameof(Scheme)} should not be.");
				}
				if (Token != null)
				{
					throw new ConfigurationException($"If {nameof(HttpClient)} is provided, {nameof(Token)} should not be.");
				}
				if (Uri != null)
				{
					throw new ConfigurationException($"If {nameof(HttpClient)} is provided, {nameof(Token)} should not be.");
				}
			}
			else
			{
				if (Scheme is null)
				{
					throw new ConfigurationException($"If {nameof(HttpClient)} is not provided, {nameof(Scheme)} must be.");
				}
				if (Token is null)
				{
					throw new ConfigurationException($"If {nameof(HttpClient)} is not provided, {nameof(Token)} must be.");
				}
				if (Uri is null)
				{
					throw new ConfigurationException($"If {nameof(HttpClient)} is not provided, {nameof(Token)} must be.");
				}
			}
		}
	}
}