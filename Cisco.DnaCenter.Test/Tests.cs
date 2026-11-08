using Cisco.DnaCenter.Api;
using Cisco.DnaCenter.Api.Exceptions;
using Cisco.DnaCenter.Test.Config;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.IO;
using Xunit;

namespace Cisco.DnaCenter.Test;

// Every test deriving from this class needs a live DNA Center and the credentials in
// appsettings.json, which CI does not have. CI excludes them with --filter "Category!=Integration".
[Trait("Category", "Integration")]
public class Tests
{
	protected ILogger Logger;
	private Configuration? _configuration;
	private DnaCenterClient? _client;
	private readonly bool _autoConnectClient;


	public Tests(ITestOutputHelper testOutputHelper)
		: this(testOutputHelper, true)
	{
	}

	public Tests(ITestOutputHelper testOutputHelper, bool autoConnectClient)
	{
		Logger = testOutputHelper.BuildLogger();
		_autoConnectClient = autoConnectClient;
	}

	protected DnaCenterClient Client
	{
		get
		{
			if (_client != null)
			{
				return _client;
			}

			_client = new DnaCenterClient(GetConfiguration().Options, Logger);
			if (_autoConnectClient)
			{
				_client
					.ConnectAsync()
					.GetAwaiter()
					.GetResult();
			}
			return _client;
		}
	}

	private Configuration GetConfiguration()
	{
		if (_configuration != null)
		{
			return _configuration;
		}

		var fileInfo = new FileInfo("../../../appsettings.json");
		if (!fileInfo.Exists)
		{
			throw new ConfigurationException("Missing appsettings.json.  Please copy the appsettings.example.json in the project root folder and set the various values appropriately.");
		}

		_configuration = JsonConvert.DeserializeObject<Configuration>(File.ReadAllText(fileInfo.FullName))
			?? throw new ConfigurationException("appsettings.json did not deserialize to a Configuration.");
		_configuration.Validate();
		return _configuration;
	}
}