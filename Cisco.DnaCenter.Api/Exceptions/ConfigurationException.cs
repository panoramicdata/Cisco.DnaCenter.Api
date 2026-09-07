using System;

namespace Cisco.DnaCenter.Api.Exceptions;

/// <summary>
/// Thrown when the supplied client configuration is not usable.
/// </summary>
public class ConfigurationException : Exception
{
	/// <summary>
	/// Initializes a new instance of the <see cref="ConfigurationException" /> class.
	/// </summary>
	public ConfigurationException()
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="ConfigurationException" /> class.
	/// </summary>
	/// <param name="message">A message describing the configuration problem.</param>
	public ConfigurationException(string? message)
		: base(message)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="ConfigurationException" /> class.
	/// </summary>
	/// <param name="message">A message describing the configuration problem.</param>
	/// <param name="innerException">The exception that caused this one.</param>
	public ConfigurationException(string? message, Exception? innerException)
		: base(message, innerException)
	{
	}
}
