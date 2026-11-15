using AwesomeAssertions;
using Cisco.DnaCenter.Api;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Xunit;

namespace Cisco.DnaCenter.Test;

/// <summary>
/// Offline checks that every generated model in the Data namespace constructs, populates and
/// survives a JSON round trip.
/// </summary>
public class ModelRoundTripTests
{
	private const string DataNamespace = "Cisco.DnaCenter.Api.Data";

	private static readonly Type[] ModelTypes = [.. typeof(DnaCenterClient).Assembly
		.GetTypes()
		.Where(t => t.IsClass && t.IsPublic && !t.IsAbstract && !t.IsGenericTypeDefinition && t.Namespace == DataNamespace)
		.OrderBy(t => t.FullName, StringComparer.Ordinal)];

	public static TheoryData<string> ModelNames => [.. ModelTypes.Select(t => t.Name)];

	[Fact]
	public void ModelTypes_AreDiscovered()
		=> ModelTypes.Length.Should().BeGreaterThan(100);

	[Theory]
	[MemberData(nameof(ModelNames))]
	public void Model_DefaultInstance_RoundTripsThroughJson(string name)
	{
		var instance = ModelPopulator.CreateWithDefaults(Find(name));

		AssertRoundTrips(instance);
	}

	[Theory]
	[MemberData(nameof(ModelNames))]
	public void Model_PopulatedInstance_RoundTripsThroughJson(string name)
	{
		var type = Find(name);
		var instance = ModelPopulator.CreateWithDefaults(type);
		foreach (var property in ModelPopulator.SettableProperties(type))
		{
			property.SetValue(instance, ModelPopulator.Build(property.PropertyType, 0));
		}

		AssertRoundTrips(instance);
		var text = instance.ToString() ?? string.Empty;
		(text.StartsWith("class ", StringComparison.Ordinal) || text == type.FullName).Should().BeTrue();
	}

	[Theory]
	[MemberData(nameof(ModelNames))]
	public void Model_ConstructorArguments_AreExposedAsProperties(string name)
	{
		var type = Find(name);
		var constructor = type.GetConstructors().OrderByDescending(c => c.GetParameters().Length).First();
		var properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);

		var arguments = constructor.GetParameters()
			.Select(p => ModelPopulator.Build(p.ParameterType, 0))
			.ToArray();
		var instance = constructor.Invoke(arguments);

		var matched = 0;
		for (var i = 0; i < arguments.Length; i++)
		{
			var parameterName = constructor.GetParameters()[i].Name!;
			var property = properties.FirstOrDefault(p => string.Equals(p.Name, parameterName, StringComparison.OrdinalIgnoreCase));
			if (property is null || !property.PropertyType.IsAssignableFrom(constructor.GetParameters()[i].ParameterType))
			{
				continue;
			}

			matched++;
			Equals(property.GetValue(instance), arguments[i]).Should().BeTrue();
		}

		if (arguments.Length > 0)
		{
			matched.Should().BeGreaterThan(0);
		}
		JsonConvert.SerializeObject(instance).Should().NotBeNullOrEmpty();
	}

	[Fact]
	public void StringEnums_SerializeAsTheirDeclaredNames()
	{
		var enums = typeof(DnaCenterClient).Assembly
			.GetTypes()
			.Where(t => t.IsEnum && t.IsPublic)
			.ToList();

		foreach (var enumType in enums)
		{
			foreach (var value in Enum.GetValues(enumType))
			{
				var json = JsonConvert.SerializeObject(value, new Newtonsoft.Json.Converters.StringEnumConverter());
				var copy = JsonConvert.DeserializeObject(json, enumType, new Newtonsoft.Json.Converters.StringEnumConverter());

				copy.Should().Be(value, "enum {0} value {1} should round trip", enumType.Name, value);
			}
		}

		enums.Should().NotBeEmpty();
	}

	private static void AssertRoundTrips(object instance)
	{
		var json = JsonConvert.SerializeObject(instance);
		var copy = JsonConvert.DeserializeObject(json, instance.GetType());

		copy.Should().NotBeNull();
		JToken.DeepEquals(JToken.Parse(JsonConvert.SerializeObject(copy)), JToken.Parse(json)).Should().BeTrue();
	}

	private static Type Find(string name)
		=> ModelTypes.Single(t => t.Name == name);
}
