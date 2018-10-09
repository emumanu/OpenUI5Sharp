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
				/// <summary>
				/// A string type that represents subset of CSS size values. For the Splitter only px and % are allowed.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.SplitterSize")]
				public partial class SplitterSize
				{
					public static extern implicit operator string(SplitterSize ts);
					public static extern implicit operator SplitterSize(string val);
				}
			}
		}
	}
}
