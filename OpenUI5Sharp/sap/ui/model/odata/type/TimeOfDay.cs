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
						/// This class represents the OData V4 primitive type {@link http://docs.oasis-open.org/odata/odata/v4.0/errata02/os/complete/part3-csdl/odata-v4.0-errata02-os-part3-csdl-complete.html#_The_edm:Documentation_Element <code>Edm.TimeOfDay</code>}. In {@link sap.ui.model.odata.v4.ODataModel} this type is represented as a <code>string</code>.
						/// </summary>
						[External]
						[Namespace(false)]
						[Name("sap.ui.model.odata.type.TimeOfDay")]
						public partial class TimeOfDay : sap.ui.model.odata.type.ODataType
						{
							#region Typed Parameters

							/// <summary>
							/// Parameter to be used as Object Literal
							/// </summary>
							[External]
							[ObjectLiteral]
							public partial class TimeOfDayInfo
							{
								/// <summary>
								/// If <code>true</code>, the value <code>null</code> is accepted
								/// </summary>
								public bool nullable;

								/// <summary>
								/// The number of decimal places allowed in the seconds portion of a valid value; must be an integer between 0 and 12, otherwise the default value 0 is used.
								/// </summary>
								public int precision;

							}

							#endregion

							#region Constructor

							/// <summary>
							/// Constructor for an OData primitive type <code>Edm.TimeOfDay</code>.
							/// </summary>
							/// <param name="oFormatOptions">Format options as defined in {@link sap.ui.core.format.DateFormat}</param>
							/// <param name="oConstraints">Constraints; {@link #validateValue validateValue} throws an error if any constraint is violated</param>
							public extern TimeOfDay(object oFormatOptions, sap.ui.model.odata.type.TimeOfDay.TimeOfDayInfo oConstraints);

							/// <summary>
							/// Constructor for an OData primitive type <code>Edm.TimeOfDay</code>.
							/// </summary>
							/// <param name="oFormatOptions">Format options as defined in {@link sap.ui.core.format.DateFormat}</param>
							public extern TimeOfDay(object oFormatOptions);

							/// <summary>
							/// Constructor for an OData primitive type <code>Edm.TimeOfDay</code>.
							/// </summary>
							public extern TimeOfDay();

							#endregion

							#region Methods

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.type.TimeOfDay with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.odata.type.ODataType.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <param name="oClassInfo">Object literal with information about the class</param>
							/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.type.TimeOfDay with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.odata.type.ODataType.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <param name="oClassInfo">Object literal with information about the class</param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName, object oClassInfo);

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.type.TimeOfDay with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.odata.type.ODataType.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName);

							/// <summary>
							/// Formats the given value to the given target type.
							/// </summary>
							/// <param name="sValue">The value to be formatted, which is represented as a string in the model</param>
							/// <param name="sTargetType">The target type, may be "any", "string", or a type with one of these types as its {@link sap.ui.base.DataType#getPrimitiveType primitive type}. See {@link sap.ui.model.odata.type} for more information</param>
							/// <returns>The formatted output value in the target type; <code>undefined</code> or <code>null</code> are formatted to <code>null</code></returns>
							public extern virtual string formatValue(string sValue, string sTargetType);

							/// <summary>
							/// Returns a metadata object for class sap.ui.model.odata.type.TimeOfDay.
							/// </summary>
							/// <returns>Metadata object describing this class</returns>
							public extern static sap.ui.@base.Metadata getMetadata();

							/// <summary>
							/// Returns the type's name.
							/// </summary>
							/// <returns>The type's name</returns>
							public extern override string getName();

							/// <summary>
							/// Parses the given value, which is expected to be of the given type, to a string with an OData V4 Edm.TimeOfDay value.
							/// </summary>
							/// <param name="sValue">The value to be parsed, maps <code>""</code> to <code>null</code></param>
							/// <param name="sSourceType">The source type (the expected type of <code>sValue</code>), must be "string", or a type with "string" as its {@link sap.ui.base.DataType#getPrimitiveType primitive type}. See {@link sap.ui.model.odata.type} for more information.</param>
							/// <returns>The parsed value</returns>
							public extern virtual string parseValue(string sValue, string sSourceType);

							/// <summary>
							/// Validates the given value in model representation and meets the type's constraints.
							/// </summary>
							/// <param name="sValue">The value to be validated</param>
							public extern virtual void validateValue(string sValue);

							#endregion

						}
					}
				}
			}
		}
	}
}
