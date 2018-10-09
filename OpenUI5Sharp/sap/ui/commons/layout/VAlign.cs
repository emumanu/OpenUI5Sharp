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
				public static partial class layout
				{
					/// <summary>
					/// Vertical alignment, e.g. of a layout cell's content within the cell's borders.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.commons.layout.VAlign")]
					public enum VAlign
					{
						/// <summary>
						/// Aligned at the bottom.
						/// </summary>
						Bottom,
						/// <summary>
						/// Vertically centered.
						/// </summary>
						Middle,
						/// <summary>
						/// Aligned at the top.
						/// </summary>
						Top,
					}
				}
			}
		}
	}
}
