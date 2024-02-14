using Cisco.DnaCenter.Api;
using Cisco.DnaCenter.Api.Exceptions;
using Cisco.DnaCenter.Test.Config;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.IO;
using Xunit.Abstractions;

namespace Cisco.DnaCenter.Test;

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

			_client = new DnaCenterClient(Configuration.Options, Logger);
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

	protected Configuration Configuration
	{
		get
		{
			// Have we already created this?
			if (_configuration != null)
			{
				// Yes - return that one
				return _configuration;
			}
			// No - we need to create one

			// Load config from file
			var fileInfo = new FileInfo("../../../appsettings.json");

			// Does the config file exist?
			if (!fileInfo.Exists)
			{
				// No - hint to the user what to do
				throw new ConfigurationException("Missing appsettings.json.  Please copy the appsettings.example.json in the project root folder and set the various values appropriately.");
			}
			// Yes

			// Load in the config
			_configuration = JsonConvert.DeserializeObject<Configuration>(File.ReadAllText(fileInfo.FullName));
			_configuration.Validate();
			return _configuration;
		}
	}
}