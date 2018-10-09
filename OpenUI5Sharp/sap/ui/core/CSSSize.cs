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
				/// A string type that represents CSS size values.
				/// 
				/// The CSS specifications calls this the <code>'&lt;length&gt; type'</code>. Allowed values are CSS sizes like "1px" or "2em" or "50%". The special values <code>auto</code> and <code>inherit</code> are also accepted as well as mathematical expressions using the CSS3 <code>calc(<i>expression</i>)</code> operator.
				/// 
				/// Note that CSS does not allow all these values for every CSS property representing a size. E.g. <code>padding-left</code> doesn't allow the value <code>auto</code>. So even if a value is accepted by <code>sap.ui.core.CSSSize</code>, it still might have no effect in a specific context. In other words: UI5 controls usually don't extend the range of allowed values in CSS.
				/// 
				/// <b>Units</b>
				/// 
				/// Valid font-relative units are <code>em, ex</code> and <code>rem</code>. Supported absolute units are <code>cm, mm, in, pc, pt</code> and <code>px</code>. Other units are not supported yet.
				/// 
				/// <b>Mathematical Expressions</b>
				/// 
				/// Expressions inside the <code>calc()</code> operator are only roughly checked for validity. Not every value that this type accepts might be a valid expression in the sense of the CSS spec. But vice versa, any expression that is valid according to the spec should be accepted by this type. The current implementation is based on the {@link http://dev.w3.org/csswg/css-values-3/#calc-syntax CSS3 Draft specification from 22 April 2015}.
				/// 
				/// Noteworthy details: <ul> <li>whitespace is mandatory around a '-' or '+' operator and optional otherwise</li> <li>parentheses are accepted but not checked for being balanced (a limitation of regexp based checks)</li> <li>semantic constraints like type restrictions are not checked</li> </ul>
				/// 
				/// Future versions of UI5 might check <code>calc()</code> expressions in more detail, so applications should not assume that a value, that is invalid according to the CSS spec but currently accepted by this type still will be accepted by future versions of this type.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.core.CSSSize")]
				public partial class CSSSize
				{
					public static extern implicit operator string(CSSSize ts);
					public static extern implicit operator CSSSize(string val);
				}
			}
		}
	}
}
