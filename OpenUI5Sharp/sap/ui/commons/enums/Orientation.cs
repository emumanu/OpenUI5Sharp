using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public static partial class sap
	{
		public static partial class ui
		{
			public static partial class commons
			{
				public static partial class enums
				{
					/// <summary>
					/// Orientation of a UI element
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.commons.enums.Orientation")]
					public enum Orientation
					{
						/// <summary>
						/// Horizontal orientation
						/// </summary>
						horizontal,
						/// <summary>
						/// Vertical orientation
						/// </summary>
						vertical,
					}
				}
			}
		}
	}
}
