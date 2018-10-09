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
				/// <summary>
				/// A string type that represents Grid's indent values for large, medium and small screens. Allowed values are separated by space Letters L, M or S followed by number of columns from 1 to 11 that the container has to take, for example: "L2 M4 S6", "M11", "s10" or "l4 m4". Note that the parameters have to be provided in the order large medium small.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.layout.GridIndent")]
				public partial class GridIndent
				{
					public static extern implicit operator string(GridIndent ts);
					public static extern implicit operator GridIndent(string val);
				}
			}
		}
	}
}
