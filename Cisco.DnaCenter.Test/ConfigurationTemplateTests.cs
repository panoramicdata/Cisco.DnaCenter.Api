﻿using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace Cisco.DnaCenter.Test
{
	public class ConfigurationTemplateTests : Tests
	{
		public ConfigurationTemplateTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
		{
		}

		[Fact]
		public async void GetProjectsAsync_Succeeds()
		{
			var projects = await Client
				.ConfigurationTemplates
				.GetProjectsAsync()
				.ConfigureAwait(false);

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
		public async void GetConfigurationTemplatesAsync_Succeeds()
		{
			var configurationTemplates = await Client
				.ConfigurationTemplates
				.GetAvailableTemplatesAsync()
				.ConfigureAwait(false);

			configurationTemplates.Should().NotBeNull();
			configurationTemplates.Should().NotBeEmpty();
			foreach (var item in configurationTemplates)
			{
				item.TemplateId.Should().NotBeNullOrEmpty();
				item.Name.Should().NotBeNullOrEmpty();
			}
		}
	}
}
