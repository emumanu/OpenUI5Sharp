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
						/// This class represents the OData primitive type <a href="http://www.odata.org/documentation/odata-version-2-0/overview#AbstractTypeSystem"> <code>Edm.Decimal</code></a>.
						/// 
						/// In both {@link sap.ui.model.odata.v2.ODataModel} and {@link sap.ui.model.odata.v4.ODataModel} this type is represented as a <code>string</code>. It never uses exponential format ("1e-5").
						/// </summary>
						[External]
						[Namespace(false)]
						[Name("sap.ui.model.odata.type.Decimal")]
						public partial class Decimal : sap.ui.model.odata.type.ODataType
						{
							#region Typed Parameters

							/// <summary>
							/// Parameter to be used as Object Literal
							/// </summary>
							[External]
							[ObjectLiteral]
							public partial class DecimalInfo
							{
								/// <summary>
								/// the maximum value allowed
								/// </summary>
								public string maximum;

								/// <summary>
								/// if <code>true</code>, the maximum value itself is not allowed
								/// </summary>
								public bool maximumExclusive;

								/// <summary>
								/// the minimum value allowed
								/// </summary>
								public string minimum;

								/// <summary>
								/// if <code>true</code>, the minimum value itself is not allowed
								/// </summary>
								public bool minimumExclusive;

								/// <summary>
								/// if <code>true</code>, the value <code>null</code> is accepted
								/// </summary>
								public Union<bool, string> nullable;

								/// <summary>
								/// the maximum number of digits allowed
								/// </summary>
								public Union<int, string> precision;

								/// <summary>
								/// the maximum number of digits allowed to the right of the decimal point; the number must be less than <code>precision</code> (if given). As a special case, "variable" is supported.
								/// 
								/// The number of digits to the right of the decimal point may vary from zero to <code>scale</code>, and the number of digits to the left of the decimal point may vary from one to <code>precision</code> minus <code>scale</code>.
								/// 
								/// The number is always displayed with exactly <code>scale</code> digits to the right of the decimal point (unless <code>scale</code> is "variable").
								/// </summary>
								public Union<int, string> scale;

							}

							#endregion

							#region Constructor

							/// <summary>
							/// Constructor for a primitive type <code>Edm.Decimal</code>.
							/// </summary>
							/// <param name="oFormatOptions">format options as defined in {@link sap.ui.core.format.NumberFormat}. In contrast to NumberFormat <code>groupingEnabled</code> defaults to <code>true</code>. Note that <code>maxFractionDigits</code> and <code>minFractionDigits</code> are set to the value of the constraint <code>scale</code> unless it is "variable". They can however be overwritten.</param>
							/// <param name="oConstraints">constraints; {@link #validateValue validateValue} throws an error if any constraint is violated</param>
							public extern Decimal(object oFormatOptions, sap.ui.model.odata.type.Decimal.DecimalInfo oConstraints);

							/// <summary>
							/// Constructor for a primitive type <code>Edm.Decimal</code>.
							/// </summary>
							/// <param name="oFormatOptions">format options as defined in {@link sap.ui.core.format.NumberFormat}. In contrast to NumberFormat <code>groupingEnabled</code> defaults to <code>true</code>. Note that <code>maxFractionDigits</code> and <code>minFractionDigits</code> are set to the value of the constraint <code>scale</code> unless it is "variable". They can however be overwritten.</param>
							public extern Decimal(object oFormatOptions);

							/// <summary>
							/// Constructor for a primitive type <code>Edm.Decimal</code>.
							/// </summary>
							public extern Decimal();

							#endregion

							#region Methods

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.type.Decimal with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.odata.type.ODataType.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <param name="oClassInfo">Object literal with information about the class</param>
							/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.type.Decimal with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.odata.type.ODataType.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <param name="oClassInfo">Object literal with information about the class</param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName, object oClassInfo);

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.type.Decimal with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.odata.type.ODataType.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName);

							/// <summary>
							/// Formats the given value to the given target type. When formatting to "string" the type's constraint <code>scale</code> is taken into account.
							/// </summary>
							/// <param name="sValue">the value to be formatted, which is represented as a string in the model</param>
							/// <param name="sTargetType">the target type; may be "any", "float", "int", "string", or a type with one of these types as its {@link sap.ui.base.DataType#getPrimitiveType primitive type}. See {@link sap.ui.model.odata.type} for more information.</param>
							/// <returns>the formatted output value in the target type; <code>undefined</code> or <code>null</code> are formatted to <code>null</code></returns>
							public extern virtual Union<int, string> formatValue(string sValue, string sTargetType);

							/// <summary>
							/// Returns a metadata object for class sap.ui.model.odata.type.Decimal.
							/// </summary>
							/// <returns>Metadata object describing this class</returns>
							public extern static sap.ui.@base.Metadata getMetadata();

							/// <summary>
							/// Returns the type's name.
							/// </summary>
							/// <returns>the type's name</returns>
							public extern override string getName();

							/// <summary>
							/// Parses the given value, which is expected to be of the given type, to a decimal in <code>string</code> representation.
							/// </summary>
							/// <param name="vValue">the value to be parsed; the empty string and <code>null</code> are parsed to <code>null</code></param>
							/// <param name="sSourceType">the source type (the expected type of <code>vValue</code>); may be "float", "int", "string", or a type with one of these types as its {@link sap.ui.base.DataType#getPrimitiveType primitive type}. See {@link sap.ui.model.odata.type} for more information.</param>
							/// <returns>the parsed value</returns>
							public extern virtual string parseValue(Union<string, int> vValue, string sSourceType);

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
