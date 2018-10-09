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
			public static partial class layout
			{
				public static partial class form
				{
					/// <summary>
					/// A string that defines the number of used cells in a <code>GridLayout</code>. This can be a number from 1 to 16, "auto" or "full". If set to "auto" the size is determined by the number of fields and the available cells. For labels the auto size is 3 cells. If set to "full" only one field is allowed within the <code>FormElement</code>. It gets the full width of the row and the label is displayed above. <b>Note:</b> For labels full size has no effect.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.layout.form.GridElementCells")]
					public partial class GridElementCells
					{
						public static extern implicit operator string(GridElementCells ts);
						public static extern implicit operator GridElementCells(string val);
					}
				}
			}
		}
	}
}
