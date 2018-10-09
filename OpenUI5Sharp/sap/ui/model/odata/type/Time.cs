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
			public static partial class model
			{
				public static partial class odata
				{
					public static partial class type
					{
						/// <summary>
						/// This class represents the OData V2 primitive type <a href="http://www.odata.org/documentation/odata-version-2-0/overview#AbstractTypeSystem"> <code>Edm.Time</code></a>.
						/// 
						/// In {@link sap.ui.model.odata.v2.ODataModel ODataModel} this type is represented as an object with two properties: <ul> <li><code>__edmType</code> with the value "Edm.Time" <li><code>ms</code> with the number of milliseconds since midnight </ul>
						/// </summary>
						[External]
						[Namespace(false)]
						[Name("sap.ui.model.odata.type.Time")]
						public partial class Time : sap.ui.model.odata.type.ODataType
						{
							#region Typed Parameters

							/// <summary>
							/// Parameter to be used as Object Literal
							/// </summary>
							[External]
							[ObjectLiteral]
							public partial class FormatValueInfo
							{
								/// <summary>
								/// the type has to be "Edm.Time"
								/// </summary>
								public string __edmType;

								/// <summary>
								/// the time in milliseconds
								/// </summary>
								public int ms;

							}

							#endregion

							#region Constructor

							/// <summary>
							/// Constructor for an OData primitive type <code>Edm.Time</code>.
							/// </summary>
							/// <param name="oFormatOptions">format options as defined in {@link sap.ui.core.format.DateFormat}</param>
							/// <param name="oConstraints">constraints; {@link #validateValue validateValue} throws an error if any constraint is violated</param>
							public extern Time(object oFormatOptions, sap.ui.model.odata.type.ConstraintsInfo oConstraints);

							/// <summary>
							/// Constructor for an OData primitive type <code>Edm.Time</code>.
							/// </summary>
							/// <param name="oFormatOptions">format options as defined in {@link sap.ui.core.format.DateFormat}</param>
							public extern Time(object oFormatOptions);

							/// <summary>
							/// Constructor for an OData primitive type <code>Edm.Time</code>.
							/// </summary>
							public extern Time();

							#endregion

							#region Methods

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.type.Time with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.odata.type.ODataType.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <param name="oClassInfo">Object literal with information about the class</param>
							/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.type.Time with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.odata.type.ODataType.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <param name="oClassInfo">Object literal with information about the class</param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName, object oClassInfo);

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.type.Time with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.odata.type.ODataType.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName);

							/// <summary>
							/// Formats the given value to the given target type
							/// </summary>
							/// <param name="oValue">the value in model representation to be formatted.</param>
							/// <param name="sTargetType">the target type; may be "any", "string", or a type with one of these types as its {@link sap.ui.base.DataType#getPrimitiveType primitive type}. See {@link sap.ui.model.odata.type} for more information.</param>
							/// <returns>the formatted output value in the target type; <code>undefined</code> or <code>null</code> are formatted to <code>null</code></returns>
							public extern virtual string formatValue(sap.ui.model.odata.type.Time.FormatValueInfo oValue, string sTargetType);

							/// <summary>
							/// Returns a metadata object for class sap.ui.model.odata.type.Time.
							/// </summary>
							/// <returns>Metadata object describing this class</returns>
							public extern static sap.ui.@base.Metadata getMetadata();

							/// <summary>
							/// Returns the type's name.
							/// </summary>
							/// <returns>the type's name</returns>
							public extern override string getName();

							/// <summary>
							/// Parses the given value, which is expected to be of the given type, to a time object.
							/// </summary>
							/// <param name="sValue">the value to be parsed, maps <code>""</code> to <code>null</code></param>
							/// <param name="sSourceType">the source type (the expected type of <code>sValue</code>); must be "string", or a type with "string" as its {@link sap.ui.base.DataType#getPrimitiveType primitive type}. See {@link sap.ui.model.odata.type} for more information.</param>
							/// <returns>the parsed value as described in {@link #formatValue formatValue}</returns>
							public extern virtual object parseValue(string sValue, string sSourceType);

							/// <summary>
							/// Validates whether the given value in model representation is valid and meets the defined constraints.
							/// </summary>
							/// <param name="oValue">the value to be validated</param>
							public extern virtual void validateValue(object oValue);

							#endregion

						}
					}
				}
			}
		}
	}
}
