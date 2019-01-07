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
						/// This class represents the OData primitive type <a href="http://www.odata.org/documentation/odata-version-2-0/overview#AbstractTypeSystem"> <code>Edm.DateTimeOffset</code></a>.
						/// 
						/// In {@link sap.ui.model.odata.v2.ODataModel} this type is represented as a <code>Date</code> instance in local time. In {@link sap.ui.model.odata.v4.ODataModel} this type is represented as a <code>string</code> like "1970-12-31T23:59:58Z". See parameter <code>oConstraints.V4</code> for more information.
						/// </summary>
						[External]
						[Namespace(false)]
						[Name("sap.ui.model.odata.type.DateTimeOffset")]
						public partial class DateTimeOffset : sap.ui.model.odata.type.DateTimeBase
						{
							#region Typed Parameters

							/// <summary>
							/// Parameter to be used as Object Literal
							/// </summary>
							[External]
							[ObjectLiteral]
							public partial class DateTimeOffsetInfo
							{
								/// <summary>
								/// If <code>true</code>, the value <code>null</code> is accepted
								/// </summary>
								public Union<bool, string> nullable;

								/// <summary>
								/// The number of decimal places allowed in the seconds portion of a valid string value (OData V4 only); only integer values between 0 and 12 are valid (since 1.37.0)
								/// </summary>
								public int precision;

								/// <summary>
								/// Whether OData V4 semantics apply and the model representation is expected to be a <code>string</code> like "1970-12-31T23:59:58Z" (see {@link #parseValue} and {@link #validateValue}); this type automatically adapts itself whenever it is used within an OData V4 model via {@link sap.ui.model.odata.v4.ODataPropertyBinding#setType}.
								/// </summary>
								public bool V4;

							}

							#endregion

							#region Constructor

							/// <summary>
							/// Constructor for a primitive type <code>Edm.DateTimeOffset</code>.
							/// </summary>
							/// <param name="oFormatOptions">Format options as defined in {@link sap.ui.core.format.DateFormat}</param>
							/// <param name="oConstraints">Constraints; {@link sap.ui.model.odata.type.DateTimeBase#validateValue validateValue} throws an error if any constraint is violated</param>
							public extern DateTimeOffset(sap.ui.core.format.DateFormat.FormatOptions oFormatOptions, sap.ui.model.odata.type.DateTimeOffset.DateTimeOffsetInfo oConstraints);

							/// <summary>
							/// Constructor for a primitive type <code>Edm.DateTimeOffset</code>.
							/// </summary>
							/// <param name="oFormatOptions">Format options as defined in {@link sap.ui.core.format.DateFormat}</param>
							public extern DateTimeOffset(sap.ui.core.format.DateFormat.FormatOptions oFormatOptions);

							/// <summary>
							/// Constructor for a primitive type <code>Edm.DateTimeOffset</code>.
							/// </summary>
							public extern DateTimeOffset();

							/// <summary>
							/// Constructor for a primitive type <code>Edm.DateTimeOffset</code>.
							/// </summary>
							/// <param name="oConstraints">Constraints; {@link sap.ui.model.odata.type.DateTimeBase#validateValue validateValue} throws an error if any constraint is violated</param>
							public extern DateTimeOffset(sap.ui.model.odata.type.DateTimeOffset.DateTimeOffsetInfo oConstraints);

							#endregion

							#region Methods

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.type.DateTimeOffset with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.odata.type.DateTimeBase.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <param name="oClassInfo">Object literal with information about the class</param>
							/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.type.DateTimeOffset with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.odata.type.DateTimeBase.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <param name="oClassInfo">Object literal with information about the class</param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName, object oClassInfo);

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.type.DateTimeOffset with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.odata.type.DateTimeBase.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName);

							/// <summary>
							/// Formats the given value to the given target type.
							/// </summary>
							/// <param name="vValue">The value to be formatted, which is represented in the model as a <code>Date</code> instance (OData V2) or as a string like "1970-12-31T23:59:58Z" (OData V4); both representations are accepted independent of the model's OData version</param>
							/// <param name="sTargetType">The target type, may be "any", "string", or a type with one of these types as its {@link sap.ui.base.DataType#getPrimitiveType primitive type}. See {@link sap.ui.model.odata.type} for more information.</param>
							/// <returns>The formatted output value in the target type; <code>undefined</code> or <code>null</code> are formatted to <code>null</code></returns>
							public extern virtual Union<DateTime, string> formatValue(Union<DateTime, string> vValue, string sTargetType);

							/// <summary>
							/// Returns a metadata object for class sap.ui.model.odata.type.DateTimeOffset.
							/// </summary>
							/// <returns>Metadata object describing this class</returns>
							[Name("getMetadata")]
							public extern static sap.ui.@base.Metadata getMetadataStatic();

							/// <summary>
							/// Returns the type's name.
							/// </summary>
							/// <returns>The type's name</returns>
							public extern override string getName();

							/// <summary>
							/// Parses the given value to a <code>Date</code> instance (OData V2) or a string like "1970-12-31T23:59:58Z" (OData V4), depending on the model's OData version.
							/// </summary>
							/// <param name="sValue">The value to be parsed; the empty string and <code>null</code> are parsed to <code>null</code></param>
							/// <param name="sSourceType">The source type (the expected type of <code>sValue</code>), must be "string", or a type with "string" as its {@link sap.ui.base.DataType#getPrimitiveType primitive type}. See {@link sap.ui.model.odata.type} for more information.</param>
							/// <returns>The parsed value</returns>
							public extern virtual Union<DateTime, string> parseValue(string sValue, string sSourceType);

							/// <summary>
							/// Validates whether the given value in model representation is valid and meets the defined constraints, depending on the model's OData version.
							/// </summary>
							/// <param name="vValue">The value to be validated</param>
							public extern virtual void validateValue(object vValue);

							#endregion

						}
					}
				}
			}
		}
	}
}
