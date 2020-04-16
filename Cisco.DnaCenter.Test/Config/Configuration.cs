using Cisco.DnaCenter.Api;
using Cisco.DnaCenter.Api.Exceptions;

namespace Cisco.DnaCenter.Test.Config
{
	public class Configuration
	{
		public DnaCenterClientOptions Options { get; set; } = null!;

		internal void Validate()
		{
			if (Options is null)
			{
				throw new ConfigurationException("Missing options in appsettings.json.");
			}

			Options.Validate();
		}
	}
}
