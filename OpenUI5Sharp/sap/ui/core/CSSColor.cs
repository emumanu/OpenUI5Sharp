using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public partial class sap
	{
		public static partial class ui
		{
			public static partial class core
			{
				/// <summary>
				/// A string type that represents CSS color values.
				/// 
				/// Allowed values are CSS hex colors like "#666666" or "#fff", RGB/HSL values like "rgb(0,0,0)" or "hsla(50%,10%,30%,0.5)" as well as CSS color names like "green" and "darkblue" and special values like "inherit" and "transparent".
				/// 
				/// The empty string is also allowed and has the same effect as setting no color.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.core.CSSColor")]
				public partial class CSSColor
				{
					public static extern implicit operator string(CSSColor ts);
					public static extern implicit operator CSSColor(string val);
				}
			}
		}
	}
}
