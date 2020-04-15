using Microsoft.Extensions.Logging;
using Xunit.Abstractions;

namespace Cisco.DnaCenter.Test
{
	public class Tests
	{
		protected ILogger Logger;

		public Tests(ITestOutputHelper testOutputHelper)
		{
			Logger = testOutputHelper.BuildLogger();
		}
	}
}