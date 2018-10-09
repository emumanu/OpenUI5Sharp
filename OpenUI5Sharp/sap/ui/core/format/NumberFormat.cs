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
			public static partial class core
			{
				public static partial class format
				{
					/// <summary>
					/// The NumberFormat is a static class for formatting and parsing numeric values according to a set of format options.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.core.format.NumberFormat")]
					public partial class NumberFormat : sap.ui.@base.Object
					{
						#region Methods

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.format.NumberFormat with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.format.NumberFormat with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.format.NumberFormat with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Format a number according to the given format options.
						/// </summary>
						/// <param name="vValue">the number to format or an array which contains the number to format and the sMeasure parameter</param>
						/// <param name="sMeasure">an optional unit which has an impact on formatting currencies and units</param>
						/// <returns>the formatted output value</returns>
						public extern virtual string format(Union<int, object[]> vValue, string sMeasure);

						/// <summary>
						/// Format a number according to the given format options.
						/// </summary>
						/// <param name="vValue">the number to format or an array which contains the number to format and the sMeasure parameter</param>
						/// <returns>the formatted output value</returns>
						public extern virtual string format(Union<int, object[]> vValue);

						/// <summary>
						/// Get a currency instance of the NumberFormat, which can be used for formatting.
						/// 
						/// If no locale is given, the currently configured {@link sap.ui.core.Configuration.FormatSettings#getFormatLocale formatLocale} will be used.
						/// 
						/// <p> This instance has HALF_AWAY_FROM_ZERO set as default rounding mode. Please set the roundingMode property in oFormatOptions to change the default value. </p>
						/// </summary>
						/// <param name="oFormatOptions">Object which defines the format options</param>
						/// <param name="oLocale">Locale to get the formatter for</param>
						/// <returns>integer instance of the NumberFormat</returns>
						public extern static sap.ui.core.format.NumberFormat getCurrencyInstance(object oFormatOptions, sap.ui.core.Locale oLocale);

						/// <summary>
						/// Get a currency instance of the NumberFormat, which can be used for formatting.
						/// 
						/// If no locale is given, the currently configured {@link sap.ui.core.Configuration.FormatSettings#getFormatLocale formatLocale} will be used.
						/// 
						/// <p> This instance has HALF_AWAY_FROM_ZERO set as default rounding mode. Please set the roundingMode property in oFormatOptions to change the default value. </p>
						/// </summary>
						/// <param name="oFormatOptions">Object which defines the format options</param>
						/// <returns>integer instance of the NumberFormat</returns>
						public extern static sap.ui.core.format.NumberFormat getCurrencyInstance(object oFormatOptions);

						/// <summary>
						/// Get a currency instance of the NumberFormat, which can be used for formatting.
						/// 
						/// If no locale is given, the currently configured {@link sap.ui.core.Configuration.FormatSettings#getFormatLocale formatLocale} will be used.
						/// 
						/// <p> This instance has HALF_AWAY_FROM_ZERO set as default rounding mode. Please set the roundingMode property in oFormatOptions to change the default value. </p>
						/// </summary>
						/// <returns>integer instance of the NumberFormat</returns>
						public extern static sap.ui.core.format.NumberFormat getCurrencyInstance();

						/// <summary>
						/// Get a currency instance of the NumberFormat, which can be used for formatting.
						/// 
						/// If no locale is given, the currently configured {@link sap.ui.core.Configuration.FormatSettings#getFormatLocale formatLocale} will be used.
						/// 
						/// <p> This instance has HALF_AWAY_FROM_ZERO set as default rounding mode. Please set the roundingMode property in oFormatOptions to change the default value. </p>
						/// </summary>
						/// <param name="oLocale">Locale to get the formatter for</param>
						/// <returns>integer instance of the NumberFormat</returns>
						public extern static sap.ui.core.format.NumberFormat getCurrencyInstance(sap.ui.core.Locale oLocale);

						/// <summary>
						/// Get a float instance of the NumberFormat, which can be used for formatting.
						/// 
						/// If no locale is given, the currently configured {@link sap.ui.core.Configuration.FormatSettings#getFormatLocale formatLocale} will be used.
						/// 
						/// <p> This instance has HALF_AWAY_FROM_ZERO set as default rounding mode. Please set the roundingMode property in oFormatOptions to change the default value. </p>
						/// </summary>
						/// <param name="oFormatOptions">Object which defines the format options</param>
						/// <param name="oLocale">Locale to get the formatter for</param>
						/// <returns>float instance of the NumberFormat</returns>
						public extern static sap.ui.core.format.NumberFormat getFloatInstance(object oFormatOptions, sap.ui.core.Locale oLocale);

						/// <summary>
						/// Get a float instance of the NumberFormat, which can be used for formatting.
						/// 
						/// If no locale is given, the currently configured {@link sap.ui.core.Configuration.FormatSettings#getFormatLocale formatLocale} will be used.
						/// 
						/// <p> This instance has HALF_AWAY_FROM_ZERO set as default rounding mode. Please set the roundingMode property in oFormatOptions to change the default value. </p>
						/// </summary>
						/// <param name="oFormatOptions">Object which defines the format options</param>
						/// <returns>float instance of the NumberFormat</returns>
						public extern static sap.ui.core.format.NumberFormat getFloatInstance(object oFormatOptions);

						/// <summary>
						/// Get a float instance of the NumberFormat, which can be used for formatting.
						/// 
						/// If no locale is given, the currently configured {@link sap.ui.core.Configuration.FormatSettings#getFormatLocale formatLocale} will be used.
						/// 
						/// <p> This instance has HALF_AWAY_FROM_ZERO set as default rounding mode. Please set the roundingMode property in oFormatOptions to change the default value. </p>
						/// </summary>
						/// <returns>float instance of the NumberFormat</returns>
						public extern static sap.ui.core.format.NumberFormat getFloatInstance();

						/// <summary>
						/// Get a float instance of the NumberFormat, which can be used for formatting.
						/// 
						/// If no locale is given, the currently configured {@link sap.ui.core.Configuration.FormatSettings#getFormatLocale formatLocale} will be used.
						/// 
						/// <p> This instance has HALF_AWAY_FROM_ZERO set as default rounding mode. Please set the roundingMode property in oFormatOptions to change the default value. </p>
						/// </summary>
						/// <param name="oLocale">Locale to get the formatter for</param>
						/// <returns>float instance of the NumberFormat</returns>
						public extern static sap.ui.core.format.NumberFormat getFloatInstance(sap.ui.core.Locale oLocale);

						/// <summary>
						/// Get an integer instance of the NumberFormat, which can be used for formatting.
						/// 
						/// If no locale is given, the currently configured {@link sap.ui.core.Configuration.FormatSettings#getFormatLocale formatLocale} will be used.
						/// 
						/// <p> This instance has TOWARDS_ZERO set as default rounding mode. Please set the roundingMode property in oFormatOptions to change the default value. </p>
						/// </summary>
						/// <param name="oFormatOptions">Object which defines the format options</param>
						/// <param name="oLocale">Locale to get the formatter for</param>
						/// <returns>integer instance of the NumberFormat</returns>
						public extern static sap.ui.core.format.NumberFormat getIntegerInstance(object oFormatOptions, sap.ui.core.Locale oLocale);

						/// <summary>
						/// Get an integer instance of the NumberFormat, which can be used for formatting.
						/// 
						/// If no locale is given, the currently configured {@link sap.ui.core.Configuration.FormatSettings#getFormatLocale formatLocale} will be used.
						/// 
						/// <p> This instance has TOWARDS_ZERO set as default rounding mode. Please set the roundingMode property in oFormatOptions to change the default value. </p>
						/// </summary>
						/// <param name="oFormatOptions">Object which defines the format options</param>
						/// <returns>integer instance of the NumberFormat</returns>
						public extern static sap.ui.core.format.NumberFormat getIntegerInstance(object oFormatOptions);

						/// <summary>
						/// Get an integer instance of the NumberFormat, which can be used for formatting.
						/// 
						/// If no locale is given, the currently configured {@link sap.ui.core.Configuration.FormatSettings#getFormatLocale formatLocale} will be used.
						/// 
						/// <p> This instance has TOWARDS_ZERO set as default rounding mode. Please set the roundingMode property in oFormatOptions to change the default value. </p>
						/// </summary>
						/// <returns>integer instance of the NumberFormat</returns>
						public extern static sap.ui.core.format.NumberFormat getIntegerInstance();

						/// <summary>
						/// Get an integer instance of the NumberFormat, which can be used for formatting.
						/// 
						/// If no locale is given, the currently configured {@link sap.ui.core.Configuration.FormatSettings#getFormatLocale formatLocale} will be used.
						/// 
						/// <p> This instance has TOWARDS_ZERO set as default rounding mode. Please set the roundingMode property in oFormatOptions to change the default value. </p>
						/// </summary>
						/// <param name="oLocale">Locale to get the formatter for</param>
						/// <returns>integer instance of the NumberFormat</returns>
						public extern static sap.ui.core.format.NumberFormat getIntegerInstance(sap.ui.core.Locale oLocale);

						/// <summary>
						/// Returns a metadata object for class sap.ui.core.format.NumberFormat.
						/// </summary>
						/// <returns>Metadata object describing this class</returns>
						public extern static sap.ui.@base.Metadata getMetadata();

						/// <summary>
						/// Get a percent instance of the NumberFormat, which can be used for formatting.
						/// 
						/// If no locale is given, the currently configured {@link sap.ui.core.Configuration.FormatSettings#getFormatLocale formatLocale} will be used.
						/// 
						/// <p> This instance has HALF_AWAY_FROM_ZERO set as default rounding mode. Please set the roundingMode property in oFormatOptions to change the default value. </p>
						/// </summary>
						/// <param name="oFormatOptions">Object which defines the format options</param>
						/// <param name="oLocale">Locale to get the formatter for</param>
						/// <returns>integer instance of the NumberFormat</returns>
						public extern static sap.ui.core.format.NumberFormat getPercentInstance(object oFormatOptions, sap.ui.core.Locale oLocale);

						/// <summary>
						/// Get a percent instance of the NumberFormat, which can be used for formatting.
						/// 
						/// If no locale is given, the currently configured {@link sap.ui.core.Configuration.FormatSettings#getFormatLocale formatLocale} will be used.
						/// 
						/// <p> This instance has HALF_AWAY_FROM_ZERO set as default rounding mode. Please set the roundingMode property in oFormatOptions to change the default value. </p>
						/// </summary>
						/// <param name="oFormatOptions">Object which defines the format options</param>
						/// <returns>integer instance of the NumberFormat</returns>
						public extern static sap.ui.core.format.NumberFormat getPercentInstance(object oFormatOptions);

						/// <summary>
						/// Get a percent instance of the NumberFormat, which can be used for formatting.
						/// 
						/// If no locale is given, the currently configured {@link sap.ui.core.Configuration.FormatSettings#getFormatLocale formatLocale} will be used.
						/// 
						/// <p> This instance has HALF_AWAY_FROM_ZERO set as default rounding mode. Please set the roundingMode property in oFormatOptions to change the default value. </p>
						/// </summary>
						/// <returns>integer instance of the NumberFormat</returns>
						public extern static sap.ui.core.format.NumberFormat getPercentInstance();

						/// <summary>
						/// Get a percent instance of the NumberFormat, which can be used for formatting.
						/// 
						/// If no locale is given, the currently configured {@link sap.ui.core.Configuration.FormatSettings#getFormatLocale formatLocale} will be used.
						/// 
						/// <p> This instance has HALF_AWAY_FROM_ZERO set as default rounding mode. Please set the roundingMode property in oFormatOptions to change the default value. </p>
						/// </summary>
						/// <param name="oLocale">Locale to get the formatter for</param>
						/// <returns>integer instance of the NumberFormat</returns>
						public extern static sap.ui.core.format.NumberFormat getPercentInstance(sap.ui.core.Locale oLocale);

						/// <summary>
						/// Get a unit instance of the NumberFormat, which can be used for formatting units.
						/// 
						/// If no locale is given, the currently configured {@link sap.ui.core.Configuration.FormatSettings#getFormatLocale formatLocale} will be used.
						/// 
						/// <p> This instance has HALF_AWAY_FROM_ZERO set as default rounding mode. Please set the roundingMode property in oFormatOptions to change the default value. </p>
						/// </summary>
						/// <param name="oFormatOptions">Object which defines the format options</param>
						/// <param name="oLocale">Locale to get the formatter for</param>
						/// <returns>unit instance of the NumberFormat</returns>
						public extern static sap.ui.core.format.NumberFormat getUnitInstance(object oFormatOptions, sap.ui.core.Locale oLocale);

						/// <summary>
						/// Get a unit instance of the NumberFormat, which can be used for formatting units.
						/// 
						/// If no locale is given, the currently configured {@link sap.ui.core.Configuration.FormatSettings#getFormatLocale formatLocale} will be used.
						/// 
						/// <p> This instance has HALF_AWAY_FROM_ZERO set as default rounding mode. Please set the roundingMode property in oFormatOptions to change the default value. </p>
						/// </summary>
						/// <param name="oFormatOptions">Object which defines the format options</param>
						/// <returns>unit instance of the NumberFormat</returns>
						public extern static sap.ui.core.format.NumberFormat getUnitInstance(object oFormatOptions);

						/// <summary>
						/// Get a unit instance of the NumberFormat, which can be used for formatting units.
						/// 
						/// If no locale is given, the currently configured {@link sap.ui.core.Configuration.FormatSettings#getFormatLocale formatLocale} will be used.
						/// 
						/// <p> This instance has HALF_AWAY_FROM_ZERO set as default rounding mode. Please set the roundingMode property in oFormatOptions to change the default value. </p>
						/// </summary>
						/// <returns>unit instance of the NumberFormat</returns>
						public extern static sap.ui.core.format.NumberFormat getUnitInstance();

						/// <summary>
						/// Get a unit instance of the NumberFormat, which can be used for formatting units.
						/// 
						/// If no locale is given, the currently configured {@link sap.ui.core.Configuration.FormatSettings#getFormatLocale formatLocale} will be used.
						/// 
						/// <p> This instance has HALF_AWAY_FROM_ZERO set as default rounding mode. Please set the roundingMode property in oFormatOptions to change the default value. </p>
						/// </summary>
						/// <param name="oLocale">Locale to get the formatter for</param>
						/// <returns>unit instance of the NumberFormat</returns>
						public extern static sap.ui.core.format.NumberFormat getUnitInstance(sap.ui.core.Locale oLocale);

						/// <summary>
						/// Parse a string which is formatted according to the given format options.
						/// </summary>
						/// <param name="sValue">the string containing a formatted numeric value</param>
						/// <returns>the parsed value or an array which contains the parsed value and the currency code (symbol) when the NumberFormat is a currency instance</returns>
						public extern virtual Union<int, object[]> parse(string sValue);

						#endregion

						/// <summary>
						/// Specifies a rounding behavior for numerical operations capable of discarding precision. Each rounding mode in this object indicates how the least significant returned digits of rounded result is to be calculated.
						/// </summary>
						[External]
						[Namespace(false)]
						[Name("sap.ui.core.format.NumberFormat.RoundingMode")]
						public enum RoundingMode
						{
							/// <summary>
							/// Rounding mode to round away from zero
							/// </summary>
							AWAY_FROM_ZERO,
							/// <summary>
							/// Rounding mode to round towards positive infinity
							/// </summary>
							CEILING,
							/// <summary>
							/// Rounding mode to round towards negative infinity
							/// </summary>
							FLOOR,
							/// <summary>
							/// Rounding mode to round towards the nearest neighbor unless both neighbors are equidistant, in which case round away from zero.
							/// </summary>
							HALF_AWAY_FROM_ZERO,
							/// <summary>
							/// Rounding mode to round towards the nearest neighbor unless both neighbors are equidistant, in which case round towards positive infinity.
							/// </summary>
							HALF_CEILING,
							/// <summary>
							/// Rounding mode to round towards the nearest neighbor unless both neighbors are equidistant, in which case round towards negative infinity.
							/// </summary>
							HALF_FLOOR,
							/// <summary>
							/// Rounding mode to round towards the nearest neighbor unless both neighbors are equidistant, in which case round towards zero.
							/// </summary>
							HALF_TOWARDS_ZERO,
							/// <summary>
							/// Rounding mode to round towards zero
							/// </summary>
							TOWARDS_ZERO,
						}
					}
				}
			}
		}
	}
}
