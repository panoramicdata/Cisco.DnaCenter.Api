using AwesomeAssertions;
using Xunit;

namespace Cisco.DnaCenter.Test;

public class ConfigurationTemplateTests : Tests
{
	public ConfigurationTemplateTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
	{
	}

	[Fact]
	public async Task GetProjectsAsync_Succeeds()
	{
		var projects = await Client
			.ConfigurationTemplates
			.GetProjectsAsync(cancellationToken: TestContext.Current.CancellationToken);

		projects.Should().NotBeNull();
		projects.Should().NotBeEmpty();
		foreach (var project in projects)
		{
			project.Id.Should().NotBeNullOrWhiteSpace();
			project.Name.Should().NotBeNullOrEmpty();
			project.Templates.Should().NotBeNull();
			foreach (var template in project.Templates)
			{
				template.Id.Should().NotBeNullOrWhiteSpace();
				template.Name.Should().NotBeNullOrWhiteSpace();
			}
		}
	}

	[Fact]
	public async Task GetConfigurationTemplatesAndDetailsAsync_Succeeds()
	{
		var configurationTemplates = await Client
			.ConfigurationTemplates
			.GetAvailableTemplatesAsync(cancellationToken: TestContext.Current.CancellationToken);

		configurationTemplates.Should().NotBeNull();
		configurationTemplates.Should().NotBeEmpty();
		foreach (var item in configurationTemplates)
		{
			item.TemplateId.Should().NotBeNullOrEmpty();
			item.Name.Should().NotBeNullOrEmpty();

			var templateDetails = await Client
				.ConfigurationTemplates
				.GetTemplateDetailsAsync(item.TemplateId!, cancellationToken: TestContext.Current.CancellationToken);
			templateDetails.Should().NotBeNull();
		}
	}
}
