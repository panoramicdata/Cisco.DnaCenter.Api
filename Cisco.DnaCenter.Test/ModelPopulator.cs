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

	internal static object? Build(Type type, int depth)
	{
		var underlying = Nullable.GetUnderlyingType(type) ?? type;

		if (underlying == typeof(string) || underlying == typeof(object))
		{
			return "value";
		}

		if (underlying == typeof(bool))
		{
			return true;
		}

		if (underlying.IsEnum)
		{
			return Enum.GetValues(underlying).GetValue(0);
		}

		if (underlying == typeof(DateTime))
		{
			return new DateTime(2026, 1, 2, 3, 4, 5, DateTimeKind.Utc);
		}

		if (underlying == typeof(DateTimeOffset))
		{
			return new DateTimeOffset(2026, 1, 2, 3, 4, 5, TimeSpan.Zero);
		}

		if (underlying == typeof(Guid))
		{
			return Guid.Parse("11111111-2222-3333-4444-555555555555");
		}

		if (underlying.IsPrimitive || underlying == typeof(decimal))
		{
			return Convert.ChangeType(1, underlying, System.Globalization.CultureInfo.InvariantCulture);
		}

		return BuildComposite(underlying, depth);
	}

	internal static object? BuildComposite(Type type, int depth)
	{
		if (type.IsArray)
		{
			var array = Array.CreateInstance(type.GetElementType()!, 1);
			array.SetValue(Build(type.GetElementType()!, depth + 1), 0);
			return array;
		}

		if (type.IsGenericType)
		{
			var arguments = type.GetGenericArguments();
			if (arguments.Length == 1 && typeof(IEnumerable).IsAssignableFrom(type))
			{
				var list = (IList)Activator.CreateInstance(typeof(List<>).MakeGenericType(arguments[0]))!;
				list.Add(Build(arguments[0], depth + 1));
				return list;
			}

			if (arguments.Length == 2 && typeof(IEnumerable).IsAssignableFrom(type))
			{
				var dictionary = (IDictionary)Activator.CreateInstance(typeof(Dictionary<,>).MakeGenericType(arguments))!;
				dictionary.Add(Build(arguments[0], depth + 1)!, Build(arguments[1], depth + 1));
				return dictionary;
			}
		}

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
