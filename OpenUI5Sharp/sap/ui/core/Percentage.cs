using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace OpenUI5Sharp
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
				public partial class Percentage
				{
					public static extern implicit operator string(Percentage ts);
					public static extern implicit operator Percentage(string val);
				}
			}
		}
	}
}
