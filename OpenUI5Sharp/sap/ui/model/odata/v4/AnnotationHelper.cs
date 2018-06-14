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
					public static partial class v4
					{
						/// <summary>
						/// A collection of methods which help to consume <a href="http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part3-csdl.html"> OData V4 annotations</a> in XML template views. Every context argument must belong to a {@link sap.ui.model.odata.v4.ODataMetaModel} instance.
						/// </summary>
						[External]
						[Namespace(false)]
						public static partial class AnnotationHelper
						{
							#region Typed Parameters

							/// <summary>
							/// Parameter to be used as Object Literal
							/// </summary>
							[External]
							[ObjectLiteral]
							public partial class ContextAndSchemaInfo
							{
								/// <summary>
								/// Points to the given path, that is <code>oDetails.context.getProperty("") === vRawValue</code>
								/// </summary>
								public sap.ui.model.Context context;

								/// <summary>
								/// The qualified name of the schema child where the computed annotation has been found, for example "name.space.EntityType"
								/// </summary>
								public string schemaChildName;

							}

							/// <summary>
							/// Parameter to be used as Object Literal
							/// </summary>
							[External]
							[ObjectLiteral]
							public partial class ContextInfo
							{
								/// <summary>
								/// Points to the given raw value, that is <code>oDetails.context.getProperty("") === vRawValue</code>
								/// </summary>
								public sap.ui.model.Context context;

							}

							#endregion

							#region Methods

							/// <summary>
							/// Returns a data binding according to the result of {@link #getNavigationPath}.
							/// </summary>
							/// <param name="sPath">The path value from the meta model, for example "ToSupplier/@com.sap.vocabularies.Communication.v1.Address" or "@com.sap.vocabularies.UI.v1.FieldGroup#Dimensions"</param>
							/// <returns>A data binding according to the result of {@link #getNavigationPath}, for example "{ToSupplier}" or ""</returns>
							public extern static string getNavigationBinding(string sPath);

							/// <summary>
							/// A function that helps to interpret OData V4 annotations. It knows about the syntax of the path value used by the following dynamic expressions: <ul> <li>"14.5.2 Expression edm:AnnotationPath"</li> <li>"14.5.11 Expression edm:NavigationPropertyPath"</li> <li>"14.5.12 Expression edm:Path"</li> <li>"14.5.13 Expression edm:PropertyPath"</li> </ul> It returns the path of structural and navigation properties from the given path value, but removes "$count", types casts, term casts, and annotations of navigation properties.
							/// </summary>
							/// <param name="sPath">The path value from the meta model, for example "ToSupplier/@com.sap.vocabularies.Communication.v1.Address" or "@com.sap.vocabularies.UI.v1.FieldGroup#Dimensions"</param>
							/// <returns>The path of structural and navigation properties, for example "ToSupplier" or ""</returns>
							public extern static string getNavigationPath(string sPath);

							/// <summary>
							/// Determines which type of value list exists for the given property.
							/// </summary>
							/// <param name="vRawValue">The raw value from the meta model; must be either a property or a path pointing to a property (relative to <code>oDetails.schemaChildName</code>)</param>
							/// <param name="oDetails">The details object</param>
							/// <returns>The type of the value list</returns>
							public extern static sap.ui.model.odata.v4.ValueListType getValueListType(object vRawValue, sap.ui.model.odata.v4.AnnotationHelper.ContextAndSchemaInfo oDetails);

							/// <summary>
							/// A function that helps to interpret OData V4 annotations. It knows about the syntax of the path value used by the following dynamic expressions: <ul> <li>"14.5.2 Expression edm:AnnotationPath"</li> <li>"14.5.11 Expression edm:NavigationPropertyPath"</li> <li>"14.5.12 Expression edm:Path"</li> <li>"14.5.13 Expression edm:PropertyPath"</li> </ul> It returns the information whether the given path ends with "$count" or with a multi-valued structural or navigation property. Term casts and annotations of navigation properties are ignored.
							/// 
							/// Examples: <pre>
							/// &lt;template:if test="{facet>Target/$AnnotationPath@@sap.ui.model.odata.v4.AnnotationHelper.isMultiple}">
							/// </pre>
							/// </summary>
							/// <param name="sPath">The path value from the meta model, for example "ToSupplier/@com.sap.vocabularies.Communication.v1.Address" or "@com.sap.vocabularies.UI.v1.FieldGroup#Dimensions"</param>
							/// <param name="oDetails">The details object</param>
							/// <returns><code>true</code> if the given path ends with "$count" or with a multi-valued structural or navigation property, <code>false</code> otherwise</returns>
							public extern static bool isMultiple(string sPath, sap.ui.model.odata.v4.AnnotationHelper.ContextAndSchemaInfo oDetails);

							/// <summary>
							/// Returns the value for the label of a <code>com.sap.vocabularies.UI.v1.DataFieldAbstract</code> from the meta model. If no <code>Label</code> property is available, but the data field has a <code>Value</code> property with an <code>edm:Path</code> expression as value, the label will be taken from the <code>com.sap.vocabularies.Common.v1.Label</code> annotation of the path's target property.
							/// 
							/// Example: <pre>
							/// &lt;Label text="{meta>@@sap.ui.model.odata.v4.AnnotationHelper.label}" />
							/// </pre>
							/// </summary>
							/// <param name="vRawValue">The raw value from the meta model</param>
							/// <param name="oDetails">The details object</param>
							/// <returns>A data binding or a fixed text or a sequence thereof or <code>undefined</code></returns>
							public extern static string label(object vRawValue, sap.ui.model.odata.v4.AnnotationHelper.ContextInfo oDetails);

							/// <summary>
							/// A function that helps to interpret OData V4 annotations. It knows about <ul> <li> the "14.4 Constant Expressions" for "edm:Bool", "edm:Date", "edm:DateTimeOffset", "edm:Decimal", "edm:Float", "edm:Guid", "edm:Int", "edm:TimeOfDay". <li> the constant "14.4.11 Expression edm:String": This is turned into a fixed text (e.g. <code>"Width"</code>). String constants that contain a simple binding <code>"{@i18n>...}"</code> to the hard-coded model name "@i18n" with arbitrary path are not turned into a fixed text, but kept as a data binding expression; this allows local annotation files to refer to a resource bundle for internationalization. <li> the dynamic "14.5.1 Comparison and Logical Operators": These are turned into expression bindings to perform the operations at run-time. <li> the dynamic "14.5.3 Expression edm:Apply": <ul> <li> "14.5.3.1.1 Function odata.concat": This is turned into a data binding expression. <li> "14.5.3.1.2 Function odata.fillUriTemplate": This is turned into an expression binding to fill the template at run-time. <li> "14.5.3.1.3 Function odata.uriEncode": This is turned into an expression binding to encode the parameter at run-time. <li> Apply functions may be nested arbitrarily. </ul> <li> the dynamic "14.5.6 Expression edm:If": This is turned into an expression binding to be evaluated at run-time. The expression is a conditional expression like <code>"{=condition ? expression1 : expression2}"</code>. <li> the dynamic "14.5.10 Expression edm:Null": This is turned into a <code>null</code> value. In <code>odata.concat</code> it is ignored. <li> the dynamic "14.5.12 Expression edm:Path" and "14.5.13 Expression edm:PropertyPath": This is turned into a simple data binding, e.g. <code>"{Name}"</code>. </ul> Unsupported or incorrect values are turned into a string nevertheless, but indicated as such. An error describing the problem is logged to the console in such a case.
							/// 
							/// Example: <pre>
							/// &lt;Text text="{meta>Value/@@sap.ui.model.odata.v4.AnnotationHelper.value}" />
							/// </pre>
							/// </summary>
							/// <param name="vRawValue">The raw value from the meta model</param>
							/// <param name="oDetails">The details object</param>
							/// <returns>A data binding or a fixed text or a sequence thereof</returns>
							public extern static string value(object vRawValue, sap.ui.model.odata.v4.AnnotationHelper.ContextInfo oDetails);

							#endregion

						}
					}
				}
			}
		}
	}
}
