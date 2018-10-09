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
				public static partial class util
				{
					/// <summary>
					/// The XML pre-processor for template instructions in XML views.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.core.util.XMLPreprocessor")]
					public static partial class XMLPreprocessor
					{
						/// <summary>
						/// Context interface provided by XML template processing as an additional first argument to any formatter function which opts in to this mechanism. Candidates for such formatter functions are all those used in binding expressions which are evaluated during XML template processing, including those used inside template instructions like <code>&lt;template:if></code>. The formatter function needs to be marked with a property <code>requiresIContext = true</code> to express that it requires this extended signature (compared to ordinary formatter functions). The usual arguments are provided after the first one (currently: the raw value from the model).
						/// 
						/// This interface provides callback functions to access the model and path which are needed to process OData V4 annotations. It initially offers a subset of methods from {@link sap.ui.model.Context} so that formatters might also be called with a context object for convenience, e.g. outside of XML template processing (see below for an exception to this rule).
						/// 
						/// <b>Example:</b> Suppose you have a formatter function called "foo" like below and it is used within an XML template like <code>&lt;template:if test="{path: '...', formatter: 'foo'}"></code>. In this case <code>foo</code> is called with arguments <code>oInterface, vRawValue</code> such that <code>oInterface.getModel().getObject(oInterface.getPath()) === vRawValue</code> holds. <pre>
						/// window.foo = function (oInterface, vRawValue) {
						///     //TODO ...
						/// };
						/// window.foo.requiresIContext = true;
						/// </pre>
						/// 
						/// <b>Composite Binding Examples:</b> Suppose you have the same formatter function and it is used in a composite binding like <code>&lt;Text text="{path: 'Label', formatter: 'foo'}: {path: 'Value', formatter: 'foo'}"/></code>. In this case <code>oInterface.getPath()</code> refers to ".../Label" in the 1st call and ".../Value" in the 2nd call. This means each formatter call knows which part of the composite binding it belongs to and behaves just as if it was an ordinary binding.
						/// 
						/// Suppose your formatter is not used within a part of the composite binding, but at the root of the composite binding in order to aggregate all parts like <code> &lt;Text text="{parts: [{path: 'Label'}, {path: 'Value'}], formatter: 'foo'}"/> </code>. In this case <code>oInterface.getPath(0)</code> refers to ".../Label" and <code>oInterface.getPath(1)</code> refers to ".../Value". This means, the root formatter can access the ith part of the composite binding at will (since 1.31.0); see also {@link #.getInterface getInterface}. The function <code>foo</code> is called with arguments such that <code> oInterface.getModel(i).getObject(oInterface.getPath(i)) === arguments[i + 1]</code> holds. This use is not supported within an expression binding, that is, <code>&lt;Text text="{= ${parts: [{path: 'Label'}, {path: 'Value'}], formatter: 'foo'} }"/></code> does not work as expected because the property <code>requiresIContext = true</code> is ignored.
						/// 
						/// To distinguish those two use cases, just check whether <code>oInterface.getModel() === undefined</code>, in which case the formatter is called on root level of a composite binding. To find out the number of parts, probe for the smallest non-negative integer where <code>oInterface.getModel(i) === undefined</code>. This additional functionality is, of course, not available from {@link sap.ui.model.Context}, i.e. such formatters MUST be called with an instance of this context interface.
						/// </summary>
						[External]
						[Namespace(false)]
						[Name("sap.ui.core.util.XMLPreprocessor.IContext")]
						public partial interface IContext
						{
							#region Methods

							#endregion

						}
					}
				}
			}
		}
	}
}
