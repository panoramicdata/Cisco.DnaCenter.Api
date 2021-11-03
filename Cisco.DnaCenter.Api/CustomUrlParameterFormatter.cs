using Refit;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Cisco.DnaCenter.Api
{
	internal class CustomUrlParameterFormatter : DefaultUrlParameterFormatter
	{
		public override string? Format(object parameterValue, ICustomAttributeProvider attributeProvider, Type type)
		{
			if (parameterValue is null)
			{
				return null;
			}

			if (typeof(IEnumerable<string>).IsAssignableFrom(type))
			{
				return string.Join(",", (IEnumerable<string>)parameterValue);
			}

			return base.Format(parameterValue, attributeProvider, type);
		}
	}
}