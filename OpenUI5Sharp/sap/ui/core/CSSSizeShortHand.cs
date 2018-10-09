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
				/// This type checks the short hand form of a margin or padding definition.
				/// 
				/// E.g. "1px 1px" or up to four CSSSize values are allowed or tHe special keyword <code>inherit</code>.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.core.CSSSizeShortHand")]
				public partial class CSSSizeShortHand
				{
					public static extern implicit operator string(CSSSizeShortHand ts);
					public static extern implicit operator CSSSizeShortHand(string val);
				}
			}
		}
	}
}
