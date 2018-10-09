using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public static partial class sap
	{
		public static partial class f
		{
			/// <summary>
			/// A string type that represents the shrink ratios of the areas within the <code>sap.f.DynamicPageTitle</code>.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.f.DynamicPageTitleShrinkRatio")]
			public partial class DynamicPageTitleShrinkRatio
			{
				public static extern implicit operator string(DynamicPageTitleShrinkRatio ts);
				public static extern implicit operator DynamicPageTitleShrinkRatio(string val);
			}
		}
	}
}
