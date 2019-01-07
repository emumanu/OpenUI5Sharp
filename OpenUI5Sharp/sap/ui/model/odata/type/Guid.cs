﻿using System;
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
						/// This class represents the OData primitive type <a href="http://www.odata.org/documentation/odata-version-2-0/overview#AbstractTypeSystem"> <code>Edm.Guid</code></a>.
						/// 
						/// In both {@link sap.ui.model.odata.v2.ODataModel} and {@link sap.ui.model.odata.v4.ODataModel} this type is represented as a <code>string</code>.
						/// </summary>
						[External]
						[Namespace(false)]
						[Name("sap.ui.model.odata.type.Guid")]
						public partial class Guid : sap.ui.model.odata.type.ODataType
						{
							#region Constructor

							/// <summary>
							/// Constructor for an OData primitive type <code>Edm.Guid</code>.
							/// </summary>
							/// <param name="oFormatOptions">format options as defined in the interface of {@link sap.ui.model.SimpleType}; this type ignores them since it does not support any format options</param>
							/// <param name="oConstraints">constraints; {@link #validateValue validateValue} throws an error if any constraint is violated</param>
							public extern Guid(object oFormatOptions, sap.ui.model.odata.type.ConstraintsInfo oConstraints);

							/// <summary>
							/// Constructor for an OData primitive type <code>Edm.Guid</code>.
							/// </summary>
							/// <param name="oFormatOptions">format options as defined in the interface of {@link sap.ui.model.SimpleType}; this type ignores them since it does not support any format options</param>
							public extern Guid(object oFormatOptions);

							/// <summary>
							/// Constructor for an OData primitive type <code>Edm.Guid</code>.
							/// </summary>
							public extern Guid();

							#endregion

							#region Methods

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.type.Guid with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.odata.type.ODataType.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <param name="oClassInfo">Object literal with information about the class</param>
							/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.type.Guid with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.odata.type.ODataType.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <param name="oClassInfo">Object literal with information about the class</param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName, object oClassInfo);

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.type.Guid with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.odata.type.ODataType.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName);

							/// <summary>
							/// Formats the given value to the given target type.
							/// </summary>
							/// <param name="sValue">the value to be formatted</param>
							/// <param name="sTargetType">the target type; may be "any", "string", or a type with one of these types as its {@link sap.ui.base.DataType#getPrimitiveType primitive type}. See {@link sap.ui.model.odata.type} for more information.</param>
							/// <returns>the formatted output value in the target type; <code>undefined</code> or <code>null</code> are formatted to <code>null</code></returns>
							public extern virtual string formatValue(string sValue, string sTargetType);

							/// <summary>
							/// Returns a metadata object for class sap.ui.model.odata.type.Guid.
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
							/// Parses the given value to a GUID.
							/// </summary>
							/// <param name="sValue">the value to be parsed, maps <code>""</code> to <code>null</code></param>
							/// <param name="sSourceType">the source type (the expected type of <code>sValue</code>); must be "string", or a type with "string" as its {@link sap.ui.base.DataType#getPrimitiveType primitive type}. See {@link sap.ui.model.odata.type} for more information.</param>
							/// <returns>the parsed value</returns>
							public extern virtual string parseValue(string sValue, string sSourceType);

							/// <summary>
							/// Validates whether the given value in model representation is valid and meets the given constraints.
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
