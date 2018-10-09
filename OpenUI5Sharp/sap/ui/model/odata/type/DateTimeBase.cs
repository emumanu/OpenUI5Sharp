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
						/// This is an abstract base class for the OData primitive types <code>Edm.DateTime</code> and <code>Edm.DateTimeOffset</code>.
						/// </summary>
						[External]
						[Namespace(false)]
						[Name("sap.ui.model.odata.type.DateTimeBase")]
						public abstract partial class DateTimeBase : sap.ui.model.odata.type.ODataType
						{
							#region Typed Parameters

							/// <summary>
							/// Parameter to be used as Object Literal
							/// </summary>
							[External]
							[ObjectLiteral]
							public partial class DateTimeBaseInfo
							{
								/// <summary>
								/// If <code>true</code>, only the date part is used, the time part is always 00:00:00 and the time zone is UTC to avoid time-zone-related problems
								/// </summary>
								public bool isDateOnly;

								/// <summary>
								/// If <code>true</code>, the value <code>null</code> is accepted
								/// </summary>
								public Union<bool, string> nullable;

								/// <summary>
								/// The number of decimal places allowed in the seconds portion of a valid string value (OData V4 only); only integer values between 0 and 12 are valid (since 1.37.0)
								/// </summary>
								public bool precision;

							}

							#endregion

							#region Constructor

							/// <summary>
							/// Base constructor for the primitive types <code>Edm.DateTime</code> and <code>Edm.DateTimeOffset</code>.
							/// </summary>
							/// <param name="oFormatOptions">Type-specific format options; see subtypes</param>
							/// <param name="oConstraints">Constraints; {@link #validateValue validateValue} throws an error if any constraint is violated</param>
							public extern DateTimeBase(object oFormatOptions, sap.ui.model.odata.type.DateTimeBase.DateTimeBaseInfo oConstraints);

							/// <summary>
							/// Base constructor for the primitive types <code>Edm.DateTime</code> and <code>Edm.DateTimeOffset</code>.
							/// </summary>
							/// <param name="oFormatOptions">Type-specific format options; see subtypes</param>
							public extern DateTimeBase(object oFormatOptions);

							/// <summary>
							/// Base constructor for the primitive types <code>Edm.DateTime</code> and <code>Edm.DateTimeOffset</code>.
							/// </summary>
							public extern DateTimeBase();

							#endregion

							#region Methods

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.type.DateTimeBase with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.odata.type.ODataType.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <param name="oClassInfo">Object literal with information about the class</param>
							/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.type.DateTimeBase with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.odata.type.ODataType.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <param name="oClassInfo">Object literal with information about the class</param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName, object oClassInfo);

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.type.DateTimeBase with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.odata.type.ODataType.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName);

							/// <summary>
							/// Formats the given value to the given target type.
							/// </summary>
							/// <param name="oValue">The value to be formatted, which is represented in the model as a <code>Date</code> instance (OData V2)</param>
							/// <param name="sTargetType">The target type, may be "any", "string", or a type with one of these types as its {@link sap.ui.base.DataType#getPrimitiveType primitive type}. See {@link sap.ui.model.odata.type} for more information.</param>
							/// <returns>The formatted output value in the target type; <code>undefined</code> or <code>null</code> are formatted to <code>null</code></returns>
							public extern virtual Union<System.DateTime, string> formatValue(System.DateTime oValue, string sTargetType);

							/// <summary>
							/// Returns a metadata object for class sap.ui.model.odata.type.DateTimeBase.
							/// </summary>
							/// <returns>Metadata object describing this class</returns>
							public extern static sap.ui.@base.Metadata getMetadata();

							/// <summary>
							/// Parses the given value to a <code>Date</code> instance (OData V2).
							/// </summary>
							/// <param name="sValue">The value to be parsed; the empty string and <code>null</code> are parsed to <code>null</code></param>
							/// <param name="sSourceType">The source type (the expected type of <code>sValue</code>), must be "string", or a type with "string" as its {@link sap.ui.base.DataType#getPrimitiveType primitive type}. See {@link sap.ui.model.odata.type} for more information.</param>
							/// <returns>The parsed value</returns>
							public extern virtual System.DateTime parseValue(string sValue, string sSourceType);

							/// <summary>
							/// Validates whether the given value in model representation is valid and meets the defined constraints.
							/// </summary>
							/// <param name="oValue">The value to be validated</param>
							public extern virtual void validateValue(System.DateTime oValue);

							#endregion

						}
					}
				}
			}
		}
	}
}
