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
				public static partial class type
				{
					/// <summary>
					/// This class represents the Date interval composite type.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.model.type.DateInterval")]
					public partial class DateInterval : sap.ui.model.CompositeType
					{
						#region Constructor

						/// <summary>
						/// Constructor for a Date interval type.
						/// </summary>
						/// <param name="oFormatOptions">Formatting options. For a list of all available options, see {@link sap.ui.core.format.DateFormat.getDateInstance DateFormat}.</param>
						/// <param name="oConstraints">Value constraints</param>
						public extern DateInterval(sap.ui.model.FormatOptions oFormatOptions, sap.ui.model.TypeIntervalInfo oConstraints);

						/// <summary>
						/// Constructor for a Date interval type.
						/// </summary>
						/// <param name="oFormatOptions">Formatting options. For a list of all available options, see {@link sap.ui.core.format.DateFormat.getDateInstance DateFormat}.</param>
						public extern DateInterval(sap.ui.model.FormatOptions oFormatOptions);

						/// <summary>
						/// Constructor for a Date interval type.
						/// </summary>
						public extern DateInterval();

						#endregion

						#region Methods

						/// <summary>
						/// Creates a new subclass of class sap.ui.model.type.DateInterval with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.CompositeType.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.model.type.DateInterval with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.CompositeType.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.model.type.DateInterval with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.CompositeType.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Format the given array containing two values to an output value of type string. Other internal types than 'string' and 'any' are not supported by the date interval type. If a source format has been defined for this type, the formatValue does also accept an array with string values as input. This will be parsed into an array of Dates using the source format.
						/// 
						/// If <code>aValues</code> isn't an array, a format exception is thrown. If one of the elements in <code>aValues</code> is not defined or null, empty string will be returned.
						/// </summary>
						/// <param name="aValues">The array of values</param>
						/// <param name="sInternalType">The target type</param>
						/// <returns>The formatted output value</returns>
						public extern override object formatValue(object[] aValues, string sInternalType);

						/// <summary>
						/// Returns a metadata object for class sap.ui.model.type.DateInterval.
						/// </summary>
						/// <returns>Metadata object describing this class</returns>
						[Name("getMetadata")]
						public extern static sap.ui.@base.Metadata getMetadataStatic();

						/// <summary>
						/// Parse a string value to an array containing two values. Parsing of other internal types than 'string' is not supported by the DateInterval type. In case a source format has been defined, the two values are formatted using the source format after parsing the inteval string and an array which contains two string values is returned.
						/// </summary>
						/// <param name="sValue">The value to be parsed</param>
						/// <param name="sInternalType">The source type</param>
						/// <param name="aCurrentValues">The current values of all binding parts</param>
						/// <returns>The parsed result array</returns>
						public extern virtual object[] parseValue(object sValue, string sInternalType, object[] aCurrentValues);

						#endregion

					}
				}
			}
		}
	}
}
