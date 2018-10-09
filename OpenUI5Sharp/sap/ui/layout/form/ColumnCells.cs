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
					/// An <code>int</code> type that defines how many cells a control inside of a column of a <code>Form</code> control using the <code>ColumnLayout</code> control as layout can use.
					/// 
					/// Allowed values are numbers from 1 to 12.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.layout.form.ColumnCells")]
					public partial class ColumnCells
					{
						public static extern implicit operator int?(ColumnCells ts);
						public static extern implicit operator ColumnCells(int? val);
					}
				}
			}
		}
	}
}
