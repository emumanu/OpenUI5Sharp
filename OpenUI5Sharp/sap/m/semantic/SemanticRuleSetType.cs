using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public static partial class sap
	{
		public static partial class m
		{
			public static partial class semantic
			{
				/// <summary>
				/// Declares the type of semantic ruleset that will govern the styling and positioning of semantic content.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.m.semantic.SemanticRuleSetType")]
				public enum SemanticRuleSetType
				{
					/// <summary>
					/// The default ruleset type, for which the Share Menu is always in the footer of the page.
					/// </summary>
					Classic,
					/// <summary>
					/// Offers an optimized user experience, with displaying the Share Menu in the header, rather than the footer, for Fullscreen mode.
					/// </summary>
					Optimized,
				}
			}
		}
	}
}
