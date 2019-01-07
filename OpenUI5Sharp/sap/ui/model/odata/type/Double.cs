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
						/// This class represents the OData primitive type <a href="http://www.odata.org/documentation/odata-version-2-0/overview#AbstractTypeSystem"> <code>Edm.Double</code></a>.
						/// 
						/// In both {@link sap.ui.model.odata.v2.ODataModel} and {@link sap.ui.model.odata.v4.ODataModel} this type is represented as a <code>number</code>.
						/// </summary>
						[External]
						[Namespace(false)]
						[Name("sap.ui.model.odata.type.Double")]
						public partial class Double : sap.ui.model.odata.type.ODataType
						{
							#region Constructor

							/// <summary>
							/// Constructor for a primitive type <code>Edm.Double</code>.
							/// </summary>
							/// <param name="oFormatOptions">format options as defined in {@link sap.ui.core.format.NumberFormat}. In contrast to NumberFormat <code>groupingEnabled</code> defaults to <code>true</code>.</param>
							/// <param name="oConstraints">constraints; {@link #validateValue validateValue} throws an error if any constraint is violated</param>
							public extern Double(object oFormatOptions, sap.ui.model.odata.type.ConstraintsInfo oConstraints);

							/// <summary>
							/// Constructor for a primitive type <code>Edm.Double</code>.
							/// </summary>
							/// <param name="oFormatOptions">format options as defined in {@link sap.ui.core.format.NumberFormat}. In contrast to NumberFormat <code>groupingEnabled</code> defaults to <code>true</code>.</param>
							public extern Double(object oFormatOptions);

							/// <summary>
							/// Constructor for a primitive type <code>Edm.Double</code>.
							/// </summary>
							public extern Double();

							#endregion

							#region Methods

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.type.Double with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.odata.type.ODataType.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <param name="oClassInfo">Object literal with information about the class</param>
							/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.type.Double with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.odata.type.ODataType.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <param name="oClassInfo">Object literal with information about the class</param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName, object oClassInfo);

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.type.Double with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.odata.type.ODataType.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName);

							/// <summary>
							/// Formats the given value to the given target type. When formatting to "string", very large or very small values are formatted to the exponential format (e.g. "-3.14 E+15").
							/// </summary>
							/// <param name="vValue">the value to be formatted, which is represented as a number in the model</param>
							/// <param name="sTargetType">the target type; may be "any", "float", "int", "string", or a type with one of these types as its {@link sap.ui.base.DataType#getPrimitiveType primitive type}. See {@link sap.ui.model.odata.type} for more information.</param>
							/// <returns>the formatted output value in the target type; <code>undefined</code> or <code>null</code> are formatted to <code>null</code></returns>
							public extern virtual Union<int, string> formatValue(Union<int, string> vValue, string sTargetType);

							/// <summary>
							/// Returns a metadata object for class sap.ui.model.odata.type.Double.
							/// </summary>
							/// <returns>Metadata object describing this class</returns>
							[Name("getMetadata")]
							public extern static sap.ui.@base.Metadata getMetadataStatic();

							/// <summary>
							/// Returns the type's name.
							/// </summary>
							/// <returns>the type's name</returns>
							public extern override string getName();

							/// <summary>
							/// Parses the given value, which is expected to be of the given type, to an Edm.Double in <code>number</code> representation.
							/// </summary>
							/// <param name="vValue">the value to be parsed; the empty string and <code>null</code> are parsed to <code>null</code>; note that there is no way to enter <code>Infinity</code> or <code>NaN</code> values</param>
							/// <param name="sSourceType">the source type (the expected type of <code>vValue</code>); may be "float", "int", "string", or a type with one of these types as its {@link sap.ui.base.DataType#getPrimitiveType primitive type}. See {@link sap.ui.model.odata.type} for more information.</param>
							/// <returns>the parsed value</returns>
							public extern virtual int parseValue(Union<string, int> vValue, string sSourceType);

							/// <summary>
							/// Validates whether the given value in model representation is valid and meets the defined constraints.
							/// </summary>
							/// <param name="fValue">the value to be validated</param>
							public extern virtual void validateValue(int fValue);

							#endregion

						}
					}
				}
			}
		}
	}
}
