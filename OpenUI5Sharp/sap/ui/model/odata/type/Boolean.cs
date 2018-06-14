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
						/// This class represents the OData primitive type <a href="http://www.odata.org/documentation/odata-version-2-0/overview#AbstractTypeSystem"> <code>Edm.Boolean</code></a>.
						/// 
						/// In both {@link sap.ui.model.odata.v2.ODataModel} and {@link sap.ui.model.odata.v4.ODataModel} this type is represented as a <code>boolean</code>.
						/// </summary>
						[External]
						[Namespace(false)]
						public partial class Boolean : sap.ui.model.odata.type.ODataType
						{
							#region Constructor

							/// <summary>
							/// Constructor for an OData primitive type <code>Edm.Boolean</code>.
							/// </summary>
							/// <param name="oFormatOptions">format options as defined in the interface of {@link sap.ui.model.SimpleType}; this type ignores them since it does not support any format options</param>
							/// <param name="oConstraints">constraints; {@link #validateValue validateValue} throws an error if any constraint is violated</param>
							public extern Boolean(object oFormatOptions, sap.ui.model.odata.type.ConstraintsInfo oConstraints);

							/// <summary>
							/// Constructor for an OData primitive type <code>Edm.Boolean</code>.
							/// </summary>
							/// <param name="oFormatOptions">format options as defined in the interface of {@link sap.ui.model.SimpleType}; this type ignores them since it does not support any format options</param>
							public extern Boolean(object oFormatOptions);

							/// <summary>
							/// Constructor for an OData primitive type <code>Edm.Boolean</code>.
							/// </summary>
							public extern Boolean();

							#endregion

							#region Methods

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.type.Boolean with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.odata.type.ODataType.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <param name="oClassInfo">Object literal with information about the class</param>
							/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.type.Boolean with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.odata.type.ODataType.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <param name="oClassInfo">Object literal with information about the class</param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName, object oClassInfo);

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.type.Boolean with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.odata.type.ODataType.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName);

							/// <summary>
							/// Formats the given boolean value to the given target type.
							/// </summary>
							/// <param name="bValue">the value to be formatted</param>
							/// <param name="sTargetType">the target type; may be "any", "boolean", "string", or a type with one of these types as its {@link sap.ui.base.DataType#getPrimitiveType primitive type}. If the target type (or its primitive type) is "string", the result is "Yes" or "No" in the current {@link sap.ui.core.Configuration#getLanguage language}. See {@link sap.ui.model.odata.type} for more information.</param>
							/// <returns>the formatted output value in the target type; <code>undefined</code> or <code>null</code> are formatted to <code>null</code></returns>
							public extern virtual Union<bool, string> formatValue(bool bValue, string sTargetType);

							/// <summary>
							/// Returns a metadata object for class sap.ui.model.odata.type.Boolean.
							/// </summary>
							/// <returns>Metadata object describing this class</returns>
							public extern static sap.ui.@base.Metadata getMetadata();

							/// <summary>
							/// Returns the type's name.
							/// </summary>
							/// <returns>the type's name</returns>
							public extern override string getName();

							/// <summary>
							/// Parses the given value from the given type to a boolean.
							/// </summary>
							/// <param name="vValue">the value to be parsed; the empty string and <code>null</code> are parsed to <code>null</code></param>
							/// <param name="sSourceType">the source type (the expected type of <code>vValue</code>); may be "boolean", "string", or a type with one of these types as its {@link sap.ui.base.DataType#getPrimitiveType primitive type}. See {@link sap.ui.model.odata.type} for more information.</param>
							/// <returns>the parsed value</returns>
							public extern virtual bool parseValue(Union<bool, string> vValue, string sSourceType);

							/// <summary>
							/// Validates whether the given value in model representation is valid and meets the given constraints.
							/// </summary>
							/// <param name="bValue">the value to be validated</param>
							public extern virtual void validateValue(bool bValue);

							#endregion

						}
					}
				}
			}
		}
	}
}
