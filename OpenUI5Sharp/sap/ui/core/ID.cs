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
				/// A string type representing an Id or a name.
				/// 
				/// Allowed is a sequence of characters (capital/lowercase), digits, underscores, dashes, points and/or colons. It may start with a character or underscore only.
				/// </summary>
				[External]
				[Namespace(false)]
				public partial class ID
				{
					public static extern implicit operator string(ID ts);
					public static extern implicit operator ID(string val);
				}
			}
		}
	}
}
