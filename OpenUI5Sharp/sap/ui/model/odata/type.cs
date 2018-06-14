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
			public static partial class model
			{
				public static partial class odata
				{
					/// <summary>
					/// The types in this namespace are {@link sap.ui.model.SimpleType simple types} corresponding to OData primitive types for both {@link http://www.odata.org/documentation/odata-version-2-0/overview#AbstractTypeSystem OData V2} and {@link http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part3-csdl.html OData V4} (see "4.4 Primitive Types").
					/// 
					/// They can be used in any place where simple types are allowed (and the model representation matches), but they are of course most valuable when used in bindings to a {@link sap.ui.model.odata.v2.ODataModel} or {@link sap.ui.model.odata.v4.ODataModel}.
					/// 
					/// <b>Example:</b> <pre>
					///   &lt;Label text="ID"/>
					///   &lt;Input value="{path : 'id', type : 'sap.ui.model.odata.type.String',
					///       constraints : {nullable : false, maxLength : 10}}"/>
					///   &lt;Label text="valid through"/>
					///   &lt;Input value="{path : 'validThrough', type : 'sap.ui.model.odata.type.DateTime',
					///       constraints : {displayFormat : 'Date'}}"/>
					/// </pre>
					/// 
					/// All types support formatting from the representation used in ODataModel ("model format") to various representations used by UI elements ("target type") and vice versa. Additionally they support validating a given value against the type's constraints.
					/// 
					/// The following target types may be supported: <table> <tr><th>Type</th><th>Description</th></tr> <tr><td><code>string</code></td><td>The value is converted to a <code>string</code>, so that it can be displayed in an input field. Supported by all types.</td></tr> <tr><td><code>boolean</code></td><td>The value is converted to a <code>Boolean</code>, so that it can be displayed in a checkbox. Only supported by {@link sap.ui.model.odata.type.Boolean}.</td></tr> <tr><td><code>int</code></td><td>The value is converted to an integer (as <code>number</code>). May cause truncation of decimals and overruns. Supported by all numeric types.</td></tr> <tr><td><code>float</code></td><td>The value is converted to a <code>number</code>. Supported by all numeric types.</td></tr> <tr><td><code>any</code></td><td>A technical format. The value is simply passed through. Only supported by <code>format</code>, not by <code>parse</code>. Supported by all types.</td></tr> </table>
					/// 
					/// All constraints relevant for OData V2 may be given as strings besides their natural types (e.g. <code>nullable : "false"</code> or <code>maxLength : "10"</code>). This makes the life of template processors easier, but is not needed for OData V4.
					/// 
					/// <b>Handling of <code>null</code></b>:
					/// 
					/// All types handle <code>null</code> in the same way. When formatting to <code>string</code>, it is simply passed through (and <code>undefined</code> becomes <code>null</code>, too). When parsing from <code>string</code>, it is also passed through. Additionally, {@link sap.ui.model.odata.type.String String} and {@link sap.ui.model.odata.type.Guid Guid} convert the empty string to <code>null</code> when parsing. <code>validate</code> decides based on the constraint <code>nullable</code>: If <code>false</code>, <code>null</code> is not accepted and leads to a (locale-dependent) <code>ParseException</code>.
					/// 
					/// This ensures that the user cannot clear an input field bound to an attribute with non-nullable type. However it does not ensure that the user really entered something if the field was empty before.
					/// </summary>
					[External]
					[Namespace(false)]
					public static partial class type
					{
						#region Typed Parameters

						/// <summary>
						/// Parameter to be used as Object Literal
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class ConstraintsInfo
						{
							/// <summary>
							/// if <code>true</code>, the value <code>null</code> is accepted
							/// </summary>
							public Union<bool, string> nullable;

						}

						#endregion

					}
				}
			}
		}
	}
}
