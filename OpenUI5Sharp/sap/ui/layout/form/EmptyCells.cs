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
					/// An <code>int</code> type that defines how many cells beside the controls inside of a column of a <code>Form</code> control using the <code>ColumnLayout</code> control as layout are empty.
					/// 
					/// Allowed values are numbers from 0 to 11.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.layout.form.EmptyCells")]
					public partial class EmptyCells
					{
						public static extern implicit operator int?(EmptyCells ts);
						public static extern implicit operator EmptyCells(int? val);
					}
				}
			}
		}
	}
}
