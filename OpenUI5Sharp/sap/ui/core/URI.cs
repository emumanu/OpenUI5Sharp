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
				/// A string type that represents an RFC 3986 conformant URI.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.core.URI")]
				public partial class URI
				{
					public static extern implicit operator string(URI ts);
					public static extern implicit operator URI(string val);
				}
			}
		}
	}
}
