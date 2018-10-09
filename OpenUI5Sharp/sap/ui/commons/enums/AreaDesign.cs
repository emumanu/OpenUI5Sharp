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
					/// Value set for the background design of areas
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.commons.enums.AreaDesign")]
					public enum AreaDesign
					{
						/// <summary>
						/// Shows the label in a filled look
						/// </summary>
						Fill,
						/// <summary>
						/// Shows the area in a plain look
						/// </summary>
						Plain,
						/// <summary>
						/// Shows the background as transparent
						/// </summary>
						Transparent,
					}
				}
			}
		}
	}
}
