using AwesomeAssertions;
using Cisco.DnaCenter.Api;
using System;
using System.Net;
using System.Net.Http;
using System.Text;
using Xunit;

namespace Cisco.DnaCenter.Test;

/// <summary>
/// Tests for header redaction in diagnostic output.
///
/// <para>
/// <c>AuthenticatedHttpClientHandler</c> adds an X-Auth-Token header to every request and then
/// passes the whole <see cref="HttpRequestMessage"/> to the logger. Its <c>ToString()</c> renders
/// every header, so without redaction a usable session token is written wherever those messages end
/// up.
/// </para>
///
/// <para>
/// The account credentials are exposed by the same path. The token endpoint is called with an
/// Authorization header carrying Basic encoded username and password, and that request travels
/// through the same handler, so the password was logged too.
/// </para>
///
/// <para>
/// These are pure unit tests. They construct messages directly and require no credentials, no
/// configuration and no live appliance.
/// </para>
/// </summary>
public class HttpExtensionsTests
{
	private const string FakeToken = "eyJhbGciOiJSUzI1NiIsInR5cCI6IkpXVCJ9.not-a-real-token.signature";

	/// <summary>
	/// The headline case: the session token this client sets must not survive into the message.
	/// </summary>
	[Fact]
	public void ToRedactedString_XAuthToken_DoesNotLeakTheCredential()
	{
		using var request = new HttpRequestMessage(HttpMethod.Get, "https://dnac.example.com/dna/intent/api/v1/network-device");
		request.Headers.Add("X-Auth-Token", FakeToken);

		var rendered = request.ToRedactedString();

		rendered.Should().NotContain(FakeToken);
		rendered.Should().Contain($"X-Auth-Token: <redacted, length {FakeToken.Length}>");
	}

	/// <summary>
	/// The account password reaches the same logging path via the token endpoint, so it must go too.
	/// Built the way IAuthentication.Authenticate is documented to be called.
	/// </summary>
	[Fact]
	public void ToRedactedString_BasicCredentialOnTheTokenEndpoint_IsRedacted()
	{
		var basic = Convert.ToBase64String(Encoding.UTF8.GetBytes("admin:sup3r-s3cret-password"));
		using var request = new HttpRequestMessage(HttpMethod.Post, "https://dnac.example.com/dna/system/api/v1/auth/token");
		request.Headers.TryAddWithoutValidation("Authorization", $"Basic {basic}");

		var rendered = request.ToRedactedString();

		rendered.Should().NotContain(basic);
		rendered.Should().NotContain("sup3r-s3cret-password");
		rendered.Should().Contain($"Authorization: Basic <redacted, length {basic.Length}>");
	}

	/// <summary>
	/// Proves the defect being fixed: the framework rendering leaks, the replacement does not.
	/// </summary>
	[Fact]
	public void ToRedactedString_UnlikeToString_DoesNotContainTheToken()
	{
		using var request = new HttpRequestMessage(HttpMethod.Get, "https://dnac.example.com/");
		request.Headers.Add("X-Auth-Token", FakeToken);

		request.ToString().Should().Contain(FakeToken, "the framework rendering is what leaked");
		request.ToRedactedString().Should().NotContain(FakeToken);
	}

	/// <summary>
	/// The diagnostically useful parts of the message must survive intact.
	/// </summary>
	[Fact]
	public void ToRedactedString_KeepsMethodUriAndOtherHeaders()
	{
		using var request = new HttpRequestMessage(HttpMethod.Post, "https://dnac.example.com/dna/intent/api/v1/template-programmer");
		request.Headers.Add("X-Auth-Token", FakeToken);
		request.Headers.TryAddWithoutValidation("User-Agent", "Cisco.DnaCenter.Api");

		var rendered = request.ToRedactedString();

		rendered.Should().Contain("Method: POST");
		rendered.Should().Contain("https://dnac.example.com/dna/intent/api/v1/template-programmer");
		rendered.Should().Contain("User-Agent: Cisco.DnaCenter.Api");
		rendered.Should().NotContain(FakeToken);
	}

	/// <summary>
	/// Content headers are rendered too, so they must be redacted on the same terms.
	/// </summary>
	[Fact]
	public void ToRedactedString_RedactsContentHeaders()
	{
		using var request = new HttpRequestMessage(HttpMethod.Post, "https://dnac.example.com/")
		{
			Content = new StringContent("{}")
		};
		request.Content.Headers.TryAddWithoutValidation("X-Api-Key", "s3cr3t-content-header");

		var rendered = request.ToRedactedString();

		rendered.Should().NotContain("s3cr3t-content-header");
		rendered.Should().Contain("<redacted");
		rendered.Should().Contain("Content-Type: text/plain; charset=utf-8");
	}

	/// <summary>
	/// A request with no content must not fault the renderer, since the content headers are optional.
	/// </summary>
	[Fact]
	public void ToRedactedString_RequestWithoutContent_RendersWithoutError()
	{
		using var request = new HttpRequestMessage(HttpMethod.Get, "https://dnac.example.com/");
		request.Headers.Add("X-Auth-Token", FakeToken);

		var rendered = request.ToRedactedString();

		rendered.Should().Contain("Content: <null>");
		rendered.Should().NotContain(FakeToken);
	}

	/// <summary>
	/// A header added without validation keeps whatever casing the caller used.
	/// </summary>
	/// <param name="headerName">The header name casing under test.</param>
	[Theory]
	[InlineData("x-auth-token")]
	[InlineData("X-AUTH-TOKEN")]
	[InlineData("authorization")]
	[InlineData("AUTHORIZATION")]
	public void ToRedactedString_CredentialHeaders_AreRedactedWhateverTheCasing(string headerName)
	{
		using var request = new HttpRequestMessage(HttpMethod.Get, "https://dnac.example.com/");
		request.Headers.TryAddWithoutValidation(headerName, FakeToken);

		var rendered = request.ToRedactedString();

		rendered.Should().NotContain(FakeToken);
		rendered.Should().Contain("<redacted");
	}

	/// <summary>
	/// The other standard credential-bearing header names are redacted too.
	/// </summary>
	/// <param name="headerName">The credential-bearing header name under test.</param>
	[Theory]
	[InlineData("Proxy-Authorization")]
	[InlineData("Cookie")]
	[InlineData("X-API-Key")]
	[InlineData("Api-Key")]
	[InlineData("X-Api-Token")]
	public void ToRedactedString_OtherCredentialHeaders_AreRedacted(string headerName)
	{
		const string secret = "s3cr3t-value-that-must-not-be-logged";
		using var request = new HttpRequestMessage(HttpMethod.Get, "https://dnac.example.com/");
		request.Headers.TryAddWithoutValidation(headerName, secret);

		var rendered = request.ToRedactedString();

		rendered.Should().NotContain(secret);
		rendered.Should().Contain("<redacted");
	}

	/// <summary>
	/// A cookie value also contains a space, so treating the text before the first space as a scheme
	/// would preserve the very value being redacted. Only Authorization style headers keep a scheme.
	/// </summary>
	[Fact]
	public void ToRedactedString_CookieValueContainingASpace_IsRedactedWhole()
	{
		const string cookie = "session=abc123def456; HttpOnly";
		using var request = new HttpRequestMessage(HttpMethod.Get, "https://dnac.example.com/");
		request.Headers.TryAddWithoutValidation("Cookie", cookie);

		var rendered = request.ToRedactedString();

		rendered.Should().Contain($"Cookie: <redacted, length {cookie.Length}>");
		rendered.Should().NotContain("session=abc");
	}

	/// <summary>
	/// X-Auth-Token has no scheme prefix, so all of it goes rather than a leading fragment surviving.
	/// </summary>
	[Fact]
	public void ToRedactedString_TokenWithoutAScheme_IsRedactedEntirely()
	{
		using var request = new HttpRequestMessage(HttpMethod.Get, "https://dnac.example.com/");
		request.Headers.Add("X-Auth-Token", "abcdef123456");

		var rendered = request.ToRedactedString();

		rendered.Should().Contain("X-Auth-Token: <redacted, length 12>");
	}

	/// <summary>
	/// Response rendering goes through the same redaction, so Set-Cookie is covered.
	/// </summary>
	[Fact]
	public void ToRedactedString_ResponseSetCookie_IsRedacted()
	{
		using var response = new HttpResponseMessage(HttpStatusCode.Unauthorized);
		response.Headers.TryAddWithoutValidation("Set-Cookie", "session=abc123def456; HttpOnly");

		var rendered = response.ToRedactedString();

		rendered.Should().NotContain("abc123def456");
		rendered.Should().Contain("<redacted");
	}

	/// <summary>
	/// The response status is what a failure investigation starts from, so it must survive.
	/// </summary>
	[Fact]
	public void ToRedactedString_ResponseKeepsStatus()
	{
		using var response = new HttpResponseMessage(HttpStatusCode.Unauthorized);

		var rendered = response.ToRedactedString();

		rendered.Should().Contain("StatusCode: 401");
		rendered.Should().Contain("Unauthorized");
	}

	/// <summary>
	/// A request carrying no credential is rendered with nothing removed.
	/// </summary>
	[Fact]
	public void ToRedactedString_NoCredentialHeaders_RedactsNothing()
	{
		using var request = new HttpRequestMessage(HttpMethod.Get, "https://dnac.example.com/");
		request.Headers.TryAddWithoutValidation("User-Agent", "Cisco.DnaCenter.Api");

		var rendered = request.ToRedactedString();

		rendered.Should().Contain("User-Agent: Cisco.DnaCenter.Api");
		rendered.Should().NotContain("<redacted");
	}
}
