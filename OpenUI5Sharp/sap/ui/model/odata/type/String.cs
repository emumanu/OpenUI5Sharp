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
						/// This class represents the OData primitive type <a href="http://www.odata.org/documentation/odata-version-2-0/overview#AbstractTypeSystem"> <code>Edm.String</code></a>.
						/// 
						/// In both {@link sap.ui.model.odata.v2.ODataModel} and {@link sap.ui.model.odata.v4.ODataModel} this type is represented as a <code>string</code>.
						/// </summary>
						[External]
						[Namespace(false)]
						[Name("sap.ui.model.odata.type.String")]
						public partial class String : sap.ui.model.odata.type.ODataType
						{
							#region Typed Parameters

							/// <summary>
							/// Parameter to be used as Object Literal
							/// </summary>
							[External]
							[ObjectLiteral]
							public partial class StringInfo
							{
								/// <summary>
								/// if <code>true</code>, the value is handled as a sequence of digits; while formatting leading zeros are removed from the value and while parsing the value is enhanced with leading zeros (if a maxLength constraint is given) or leading zeros are removed from the value (if no maxLength constraint is given); this constraint is supported since 1.35.0. To make this type behave as ABAP type NUMC, use <code>oConstraints.isDigitSequence=true</code> together with <code>oConstraints.maxLength</code>.
								/// </summary>
								public Union<bool, string> isDigitSequence;

								/// <summary>
								/// the maximal allowed length of the string; unlimited if not defined
								/// </summary>
								public Union<int, string> maxLength;

								/// <summary>
								/// if <code>true</code>, the value <code>null</code> is accepted. The constraint <code>nullable=false</code> is interpreted as "input is mandatory"; empty user input is rejected then.
								/// </summary>
								public Union<bool, string> nullable;

							}

							#endregion

							#region Constructor

							/// <summary>
							/// Constructor for an OData primitive type <code>Edm.String</code>.
							/// </summary>
							/// <param name="oFormatOptions">format options as defined in the interface of {@link sap.ui.model.SimpleType}; this type ignores them since it does not support any format options</param>
							/// <param name="oConstraints">constraints; {@link #validateValue validateValue} throws an error if any constraint is violated</param>
							public extern String(object oFormatOptions, sap.ui.model.odata.type.String.StringInfo oConstraints);

							/// <summary>
							/// Constructor for an OData primitive type <code>Edm.String</code>.
							/// </summary>
							/// <param name="oFormatOptions">format options as defined in the interface of {@link sap.ui.model.SimpleType}; this type ignores them since it does not support any format options</param>
							public extern String(object oFormatOptions);

							/// <summary>
							/// Constructor for an OData primitive type <code>Edm.String</code>.
							/// </summary>
							public extern String();

							#endregion

							#region Methods

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.type.String with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.odata.type.ODataType.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <param name="oClassInfo">Object literal with information about the class</param>
							/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.type.String with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.odata.type.ODataType.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <param name="oClassInfo">Object literal with information about the class</param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName, object oClassInfo);

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.type.String with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.odata.type.ODataType.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName);

							/// <summary>
							/// Formats the given value to the given target type. If <code>isDigitSequence</code> constraint of this type is set to <code>true</code> and the target type is any or string and the given value contains only digits, the leading zeros are truncated.
							/// </summary>
							/// <param name="sValue">the value to be formatted</param>
							/// <param name="sTargetType">the target type; may be "any", "boolean", "float", "int" or "string". See {@link sap.ui.model.odata.type} for more information.</param>
							/// <returns>the formatted output value in the target type; <code>undefined</code> is always formatted to <code>null</code>; <code>null</code> is formatted to "" if the target type is "string".</returns>
							public extern virtual Union<string, int, bool> formatValue(string sValue, string sTargetType);

							/// <summary>
							/// Returns a metadata object for class sap.ui.model.odata.type.String.
							/// </summary>
							/// <returns>Metadata object describing this class</returns>
							public extern static sap.ui.@base.Metadata getMetadata();

							/// <summary>
							/// Returns the type's name.
							/// </summary>
							/// <returns>the type's name</returns>
							public extern override string getName();

							/// <summary>
							/// Parses the given value which is expected to be of the given type to a string. If <code>isDigitSequence</code> constraint of this type is set to <code>true</code> and the parsed string is a sequence of digits, then the parsed string is either enhanced with leading zeros, if <code>maxLength</code> constraint is given, or leading zeros are removed from parsed string.
							/// 
							/// Note: An empty input string (<code>""</code>) is parsed to <code>null</code>. This value will be rejected with a {@link sap.ui.model.ValidateException ValidateException} by {@link #validateValue} if the constraint <code>nullable</code> is <code>false</code>.
							/// </summary>
							/// <param name="vValue">the value to be parsed</param>
							/// <param name="sSourceType">the source type (the expected type of <code>vValue</code>). See {@link sap.ui.model.odata.type} for more information.</param>
							/// <returns>the parsed value or <code>null</code> if <code>vValue</code> is <code>""</code></returns>
							public extern virtual string parseValue(Union<string, int, bool> vValue, string sSourceType);

							/// <summary>
							/// Validates whether the given value in model representation is valid and meets the defined constraints.
							/// </summary>
							/// <param name="sValue">the value to be validated</param>
							public extern virtual void validateValue(string sValue);

							#endregion

						}
					}
				}
			}
		}
	}
}
