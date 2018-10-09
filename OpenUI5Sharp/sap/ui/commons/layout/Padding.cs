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
					/// Padding, e.g. of a layout cell's content within the cell's borders. Note that all options except "None" include a padding of 2px at the top and bottom, and differ only in the presence of a 4px padding towards the beginning or end of a line, in the current locale's writing direction.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.commons.layout.Padding")]
					public enum Padding
					{
						/// <summary>
						/// Top and bottom padding of 2px. Padding of 4px towards the beginning of a line, in the current locale's writing direction, but none towards its end.
						/// </summary>
						Begin,
						/// <summary>
						/// Top and bottom padding of 2px. Padding of 4px towards both the beginning and end of a line.
						/// </summary>
						Both,
						/// <summary>
						/// Top and bottom padding of 2px. Padding of 4px towards the end of a line, in the current locale's writing direction, but none towards its beginning.
						/// </summary>
						End,
						/// <summary>
						/// Top and bottom padding of 2px. No padding towards neither the beginning nor end of a line.
						/// </summary>
						Neither,
						/// <summary>
						/// No padding at all.
						/// </summary>
						None,
					}
				}
			}
		}
	}
}
