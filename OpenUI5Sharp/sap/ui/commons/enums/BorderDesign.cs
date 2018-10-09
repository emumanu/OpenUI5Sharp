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
					/// Value set for the border design of areas
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.commons.enums.BorderDesign")]
					public enum BorderDesign
					{
						/// <summary>
						/// Draws the border as a box around the area
						/// </summary>
						Box,
						/// <summary>
						/// Suppresses the border
						/// </summary>
						None,
					}
				}
			}
		}
	}
}
