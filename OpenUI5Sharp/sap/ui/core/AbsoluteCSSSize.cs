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
				/// A string type that represents non-relative CSS size values.
				/// 
				/// This is a subtype of the <code>'&lt;length&gt; type'</code> defined in the CSS specifications. Allowed values are only absolute CSS sizes like &quot;1px&quot; or &quot;2em&quot;. Percentage sizes like &quot;50%&quot; and the special values &quot;auto&quot; and &quot;inherit&quot; are NOT allowed. Mathematical expressions using the CSS3 <code>calc(<i>expression</i>)</code> operator are allowed as long as they do not use percentage sizes.
				/// 
				/// Note that CSS might not allow all these values for every CSS property representing a size. So even if a value is accepted by <code>sap.ui.core.AbsoluteCSSSize</code>, it still might have no effect in a specific context. In other words: UI5 controls usually don't extend the range of allowed values in CSS.
				/// 
				/// <b>Units</b>
				/// 
				/// Valid font-relative units are <code>em, ex</code> and <code>rem</code>. Supported absolute units are <code>cm, mm, in, pc, pt</code> and <code>px</code>. Other units are not supported.
				/// 
				/// <b>Mathematical Expressions</b>
				/// 
				/// Expressions inside the <code>calc()</code> operator are only roughly checked for validity. Not every value that this type accepts is a valid expression in the sense of the CSS spec. But vice versa, any expression that is valid according to the spec should be accepted by this type. The current implementation is based on the {@link http://dev.w3.org/csswg/css-values-3/#calc-syntax CSS3 Draft specification from 22 April 2015}.
				/// 
				/// Noteworthy details: <ul> <li>whitespace is mandatory around a '-' or '+' operator and optional otherwise</li> <li>parentheses are accepted but not checked for being balanced (a limitation of regexp based checks)</li> <li>semantic constraints like type restrictions are not checked</li> </ul>
				/// 
				/// Future versions of UI5 might check <code>calc()</code> expressions in more detail, so applications should not assume that a value, that is invalid according to the CSS spec but currently accepted by this type still will be accepted by future versions of this type.
				/// </summary>
				[External]
				[Namespace(false)]
				public partial class AbsoluteCSSSize
				{
					public static extern implicit operator string(AbsoluteCSSSize ts);
					public static extern implicit operator AbsoluteCSSSize(string val);
				}
			}
		}
	}
}
