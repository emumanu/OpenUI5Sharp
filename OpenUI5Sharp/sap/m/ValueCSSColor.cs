using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public static partial class sap
	{
		public static partial class m
		{
			/// <summary>
			/// A string type that represents CSS color values, sap.m.ValueColor or less parameter values.
			/// 
			/// Allowed values are {@link sap.ui.core.CSSColor}, {@link sap.m.ValueColor} or a less parameter name (string). In case the less parameter color cannot be determined, the validation fails. You need to check if less parameters are supported on control level. An empty string is also allowed and has the same effect as setting no color.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.ValueCSSColor")]
			public partial class ValueCSSColor
			{
				public static extern implicit operator string(ValueCSSColor ts);
				public static extern implicit operator ValueCSSColor(string val);
			}
		}
	}
}
