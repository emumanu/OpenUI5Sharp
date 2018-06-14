using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace OpenUI5Sharp
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
					/// An <code>int</code> type that defines how many columns a <code>Form</code> control using the <code>ColumnLayout</code> as layout can have if it has large size
					/// 
					/// Allowed values are numbers from 1 to 3.
					/// </summary>
					[External]
					[Namespace(false)]
					public partial class ColumnsL
					{
						public static extern implicit operator int?(ColumnsL ts);
						public static extern implicit operator ColumnsL(int? val);
					}
				}
			}
		}
	}
}
