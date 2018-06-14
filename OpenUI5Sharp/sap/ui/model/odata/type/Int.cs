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
					public static partial class type
					{
						/// <summary>
						/// This is an abstract base class for integer-based <a href="http://www.odata.org/documentation/odata-version-2-0/overview#AbstractTypeSystem"> OData primitive types</a> like <code>Edm.Int16</code> or <code>Edm.Int32</code>.
						/// </summary>
						[External]
						[Namespace(false)]
						public abstract partial class Int : sap.ui.model.odata.type.ODataType
						{
							#region Constructor

							/// <summary>
							/// Constructor for a new <code>Int</code>.
							/// </summary>
							/// <param name="oFormatOptions">type-specific format options; see subtypes</param>
							/// <param name="oConstraints">constraints; {@link #validateValue validateValue} throws an error if any constraint is violated</param>
							public extern Int(object oFormatOptions, sap.ui.model.odata.type.ConstraintsInfo oConstraints);

							/// <summary>
							/// Constructor for a new <code>Int</code>.
							/// </summary>
							/// <param name="oFormatOptions">type-specific format options; see subtypes</param>
							public extern Int(object oFormatOptions);

							/// <summary>
							/// Constructor for a new <code>Int</code>.
							/// </summary>
							public extern Int();

							#endregion

							#region Methods

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.type.Int with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.odata.type.ODataType.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <param name="oClassInfo">Object literal with information about the class</param>
							/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.type.Int with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.odata.type.ODataType.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <param name="oClassInfo">Object literal with information about the class</param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName, object oClassInfo);

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.type.Int with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.odata.type.ODataType.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName);

							/// <summary>
							/// Formats the given value to the given target type. When formatting to <code>string</code> the format options are used.
							/// </summary>
							/// <param name="iValue">the value in model representation to be formatted</param>
							/// <param name="sTargetType">the target type; may be "any", "int", "float", "string", or a type with one of these types as its {@link sap.ui.base.DataType#getPrimitiveType primitive type}. See {@link sap.ui.model.odata.type} for more information.</param>
							/// <returns>the formatted output value in the target type; <code>undefined</code> or <code>null</code> are formatted to <code>null</code></returns>
							public extern virtual Union<int, string> formatValue(int iValue, string sTargetType);

							/// <summary>
							/// Returns a metadata object for class sap.ui.model.odata.type.Int.
							/// </summary>
							/// <returns>Metadata object describing this class</returns>
							public extern static sap.ui.@base.Metadata getMetadata();

							/// <summary>
							/// Parses the given value, which is expected to be of the given source type, to an Int in number representation.
							/// </summary>
							/// <param name="vValue">the value to be parsed. The empty string and <code>null</code> are parsed to <code>null</code>.</param>
							/// <param name="sSourceType">the source type (the expected type of <code>vValue</code>); may be "float", "int", "string", or a type with one of these types as its {@link sap.ui.base.DataType#getPrimitiveType primitive type}. See {@link sap.ui.model.odata.type} for more information.</param>
							/// <returns>the parsed value</returns>
							public extern virtual int parseValue(Union<int, string> vValue, string sSourceType);

							/// <summary>
							/// Validates whether the given value in model representation is valid and meets the defined constraints.
							/// </summary>
							/// <param name="iValue">the value to be validated</param>
							public extern virtual void validateValue(int iValue);

							#endregion

						}
					}
				}
			}
		}
	}
}
