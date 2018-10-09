using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public partial class sap
	{
		public static partial class ui
		{
			public static partial class core
			{
				/// <summary>
				/// A string type that represents a percentage value.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.core.Percentage")]
				public partial class Percentage
				{
					public static extern implicit operator string(Percentage ts);
					public static extern implicit operator Percentage(string val);
				}
			}
		}
	}
}
