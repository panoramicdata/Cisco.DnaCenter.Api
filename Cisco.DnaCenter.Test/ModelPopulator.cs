using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Cisco.DnaCenter.Test;

/// <summary>
/// Builds populated instances of generated model types by reflection.
/// </summary>
internal static class ModelPopulator
{
	private const int MaxDepth = 2;

	internal static IEnumerable<PropertyInfo> SettableProperties(Type type)
		=> type.GetProperties(BindingFlags.Public | BindingFlags.Instance)
			.Where(p => p.CanWrite && p.GetIndexParameters().Length == 0 && p.SetMethod!.IsPublic);

	internal static object CreateWithDefaults(Type type)
	{
		var constructor = type.GetConstructors().OrderBy(c => c.GetParameters().Length).First();
		var arguments = constructor.GetParameters()
			.Select(p => p.HasDefaultValue && p.DefaultValue is not DBNull ? p.DefaultValue : DefaultOf(p.ParameterType))
			.ToArray();
		return constructor.Invoke(arguments);
	}

	internal static object? DefaultOf(Type type)
		=> type.IsValueType ? Activator.CreateInstance(type) : null;

	private static readonly Dictionary<Type, object> Scalars = new()
	{
		[typeof(string)] = "value",
		[typeof(object)] = "value",
		[typeof(bool)] = true,
		[typeof(DateTime)] = new DateTime(2026, 1, 2, 3, 4, 5, DateTimeKind.Utc),
		[typeof(DateTimeOffset)] = new DateTimeOffset(2026, 1, 2, 3, 4, 5, TimeSpan.Zero),
		[typeof(Guid)] = Guid.Parse("11111111-2222-3333-4444-555555555555"),
	};

	internal static object? Build(Type type, int depth)
	{
		var underlying = Nullable.GetUnderlyingType(type) ?? type;

		if (Scalars.TryGetValue(underlying, out var scalar))
		{
			return scalar;
		}

		if (underlying.IsEnum)
		{
			return Enum.GetValues(underlying).GetValue(0);
		}

		if (underlying.IsPrimitive || underlying == typeof(decimal))
		{
			return Convert.ChangeType(1, underlying, System.Globalization.CultureInfo.InvariantCulture);
		}

		return BuildCollection(underlying, depth) ?? BuildObject(underlying, depth);
	}

	private static object? BuildCollection(Type type, int depth)
	{
		if (type.IsArray)
		{
			var array = Array.CreateInstance(type.GetElementType()!, 1);
			array.SetValue(Build(type.GetElementType()!, depth + 1), 0);
			return array;
		}

		var arguments = type.IsGenericType && typeof(IEnumerable).IsAssignableFrom(type) ? type.GetGenericArguments() : [];
		return arguments.Length switch
		{
			1 => BuildList(arguments[0], depth),
			2 => BuildDictionary(arguments, depth),
			_ => null,
		};
	}

	private static IList BuildList(Type element, int depth)
	{
		var list = (IList)Activator.CreateInstance(typeof(List<>).MakeGenericType(element))!;
		list.Add(Build(element, depth + 1));
		return list;
	}

	private static IDictionary BuildDictionary(Type[] arguments, int depth)
	{
		var dictionary = (IDictionary)Activator.CreateInstance(typeof(Dictionary<,>).MakeGenericType(arguments))!;
		dictionary.Add(Build(arguments[0], depth + 1)!, Build(arguments[1], depth + 1));
		return dictionary;
	}

	private static object? BuildObject(Type type, int depth)
	{
		if (depth >= MaxDepth || type.IsAbstract || type.IsInterface || type.GetConstructors().Length == 0)
		{
			return null;
		}

		var instance = CreateWithDefaults(type);
		foreach (var property in SettableProperties(type))
		{
			property.SetValue(instance, Build(property.PropertyType, depth + 1));
		}

		return instance;
	}
}