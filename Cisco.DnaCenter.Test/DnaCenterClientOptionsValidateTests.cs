using AwesomeAssertions;
using Cisco.DnaCenter.Api;
using Cisco.DnaCenter.Api.Exceptions;
using System;
using Xunit;

namespace Cisco.DnaCenter.Test;

/// <summary>
/// Tests for <see cref="DnaCenterClientOptions.Validate" />.
/// </summary>
public class DnaCenterClientOptionsValidateTests
{
	private static readonly Uri SomeUri = new("https://dna.example.com/");

	private static void AssertValid(DnaCenterClientOptions options)
		=> options.Invoking(o => o.Validate()).Should().NotThrow();

	private static void AssertInvalid(DnaCenterClientOptions options, string messagePart)
		=> options.Invoking(o => o.Validate()).Should().Throw<ConfigurationException>().WithMessage($"*{messagePart}*");

	[Fact]
	public void UsernameAndPassword_WithUri_IsValid()
		=> AssertValid(new DnaCenterClientOptions { Uri = SomeUri, Username = "u", Password = "p" });

	[Fact]
	public void Token_WithUri_IsValid()
		=> AssertValid(new DnaCenterClientOptions { Uri = SomeUri, Token = "t" });

	[Fact]
	public void HttpClientAlone_IsValid()
		=> AssertValid(new DnaCenterClientOptions { HttpClient = new System.Net.Http.HttpClient() });

	[Fact]
	public void MaxBackOffDelaySecondsBelowOne_Throws()
		=> AssertInvalid(new DnaCenterClientOptions { Uri = SomeUri, Token = "t", MaxBackOffDelaySeconds = 0 }, "MaxBackOffDelaySeconds");

	[Fact]
	public void BackOffDelayFactorBelowOne_Throws()
		=> AssertInvalid(new DnaCenterClientOptions { Uri = SomeUri, Token = "t", BackOffDelayFactor = 0.5 }, "BackOffDelayFactor");

	[Fact]
	public void MaxAttemptCountBelowOne_Throws()
		=> AssertInvalid(new DnaCenterClientOptions { Uri = SomeUri, Token = "t", MaxAttemptCount = 0 }, "MaxAttemptCount");

	[Fact]
	public void MissingUri_Throws()
		=> AssertInvalid(new DnaCenterClientOptions { Token = "t" }, "Uri");

	[Fact]
	public void NoTokenAndNoUsername_Throws()
		=> AssertInvalid(new DnaCenterClientOptions { Uri = SomeUri, Password = "p" }, "Username");

	[Fact]
	public void NoTokenAndNoPassword_Throws()
		=> AssertInvalid(new DnaCenterClientOptions { Uri = SomeUri, Username = "u" }, "Password");

	[Theory]
	[InlineData("Username")]
	[InlineData("Password")]
	public void TokenWithCredentials_Throws(string which)
	{
		var options = new DnaCenterClientOptions { Uri = SomeUri, Token = "t" };
		SetCredential(options, which);

		AssertInvalid(options, which);
	}

	[Theory]
	[InlineData("Token")]
	[InlineData("Username")]
	[InlineData("Password")]
	public void HttpClientWithCredentials_Throws(string which)
	{
		var options = new DnaCenterClientOptions { HttpClient = new System.Net.Http.HttpClient() };
		SetCredential(options, which);

		AssertInvalid(options, which);
	}

	private static void SetCredential(DnaCenterClientOptions options, string which)
	{
		if (which == "Username")
		{
			options.Username = "u";
		}
		else if (which == "Password")
		{
			options.Password = "p";
		}
		else
		{
			options.Token = "t";
		}
	}
}