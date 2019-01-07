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
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.enums")]
				[Obsolete("Deprecated since 1.38.")]
				public static partial class enums
				{
					/// <summary>
					/// Value set for the background design of areas
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.commons.enums.AreaDesign")]
					[Obsolete("Deprecated since 1.38.")]
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
					/// <summary>
					/// Orientation of a UI element
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.commons.enums.Orientation")]
					[Obsolete("Deprecated since 1.38.")]
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
					/// <summary>
					/// Value set for the border design of areas
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.commons.enums.BorderDesign")]
					[Obsolete("Deprecated since 1.38.")]
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
