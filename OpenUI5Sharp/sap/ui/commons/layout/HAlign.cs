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
					/// Horizontal alignment, e.g. of a layout cell's content within the cell's borders. Note that some values depend on the current locale's writing direction while others do not.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.commons.layout.HAlign")]
					public enum HAlign
					{
						/// <summary>
						/// Aligned towards the beginning of a line, in the current locale's writing direction.
						/// </summary>
						Begin,
						/// <summary>
						/// Horizontally centered.
						/// </summary>
						Center,
						/// <summary>
						/// Aligned towards the end of a line, in the current locale's writing direction.
						/// </summary>
						End,
						/// <summary>
						/// Left aligned, regardless of the current locale's writing direction.
						/// </summary>
						Left,
						/// <summary>
						/// Right aligned, regardless of the current locale's writing direction.
						/// </summary>
						Right,
					}
				}
			}
		}
	}
}
