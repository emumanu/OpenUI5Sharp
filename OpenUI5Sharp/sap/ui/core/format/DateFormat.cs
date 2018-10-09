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
					/// The DateFormat is a static class for formatting and parsing single date and time values or date and time intervals according to a set of format options.
					/// 
					/// Supported format options are pattern based on Unicode LDML Date Format notation. Please note that only a subset of the LDML date symbols is supported. If no pattern is specified a default pattern according to the locale settings is used.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.core.format.DateFormat")]
					public partial class DateFormat
					{
						#region Typed Parameters

						/// <summary>
						/// Parameter to be used as Object Literal
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class InstanceOptions
						{
							/// <summary>
							/// @since 1.34.0 contains pattern symbols (e.g. "yMMMd" or "Hms") which will be converted into the pattern in the used locale, which matches the wanted symbols best. The symbols must be in canonical order, that is: Era (G), Year (y/Y), Quarter (q/Q), Month (M/L), Week (w/W), Day-Of-Week (E/e/c), Day (d/D), Hour (h/H/k/K/j/J), Minute (m), Second (s), Timezone (z/Z/v/V/O/X/x) See http://unicode.org/reports/tr35/tr35-dates.html#availableFormats_appendItems
							/// </summary>
							public string format;

							/// <summary>
							/// a data pattern in LDML format. It is not verified whether the pattern represents only a date.
							/// </summary>
							public string pattern;

							/// <summary>
							/// can be either 'short, 'medium', 'long' or 'full'. If no pattern is given, a locale dependent default date pattern of that style is used from the LocaleData class.
							/// </summary>
							public string style;

							/// <summary>
							/// if true, by parsing it is checked if the value is a valid date
							/// </summary>
							public bool strictParsing;

							/// <summary>
							/// if true, the date is formatted relatively to todays date if it is within the given day range, e.g. "today", "yesterday", "in 5 days"
							/// </summary>
							public bool relative;

							/// <summary>
							/// the day range used for relative formatting. If oFormatOptions.relatvieScale is set to default value 'day', the relativeRange is by default [-6, 6], which means only the last 6 days, today and the next 6 days are formatted relatively. Otherwise when oFormatOptions.relativeScale is set to 'auto', all dates are formatted relatively.
							/// </summary>
							public int[] relativeRange;

							/// <summary>
							/// if 'auto' is set, new relative time format is switched on for all Date/Time Instances. The relative scale is chosen depending on the difference between the given date and now.
							/// </summary>
							public string relativeScale;

							/// <summary>
							/// @since 1.32.10, 1.34.4 the style of the relative format. The valid values are "wide", "short", "narrow"
							/// </summary>
							public string relativeStyle;

							/// <summary>
							/// @since 1.48.0 if true, the [format]{@link sap.ui.core.format.DateFormat#format} method expects an array with two dates as the first argument and formats them as interval. Further interval "Jan 10, 2008 - Jan 12, 2008" will be formatted as "Jan 10-12, 2008" if the 'format' option is set with necessary symbols. Otherwise the two given dates are formatted separately and concatenated with local dependent pattern.
							/// </summary>
							public bool interval;

							/// <summary>
							/// if true, the date is formatted and parsed as UTC instead of the local timezone
							/// </summary>
							public bool UTC;

							/// <summary>
							/// The calender type which is used to format and parse the date. This value is by default either set in configuration or calculated based on current locale.
							/// </summary>
							public sap.ui.core.CalendarType calendarType;

						}

						#endregion

						#region Methods

						/// <summary>
						/// Format a date according to the given format options.
						/// </summary>
						/// <param name="vJSDate">the value to format</param>
						/// <param name="bUTC">whether to use UTC</param>
						/// <returns>the formatted output value. If an invalid date is given, an empty string is returned.</returns>
						public extern virtual string format(Union<System.DateTime, System.DateTime[]> vJSDate, bool bUTC);

						/// <summary>
						/// Get a date instance of the DateFormat, which can be used for formatting.
						/// </summary>
						/// <param name="oFormatOptions">Object which defines the format options</param>
						/// <param name="oLocale">Locale to ask for locale specific texts/settings</param>
						/// <returns>date instance of the DateFormat</returns>
						public extern static sap.ui.core.format.DateFormat getDateInstance(sap.ui.core.format.DateFormat.InstanceOptions oFormatOptions, sap.ui.core.Locale oLocale);

						/// <summary>
						/// Get a date instance of the DateFormat, which can be used for formatting.
						/// </summary>
						/// <param name="oFormatOptions">Object which defines the format options</param>
						/// <returns>date instance of the DateFormat</returns>
						public extern static sap.ui.core.format.DateFormat getDateInstance(sap.ui.core.format.DateFormat.InstanceOptions oFormatOptions);

						/// <summary>
						/// Get a date instance of the DateFormat, which can be used for formatting.
						/// </summary>
						/// <returns>date instance of the DateFormat</returns>
						public extern static sap.ui.core.format.DateFormat getDateInstance();

						/// <summary>
						/// Get a date instance of the DateFormat, which can be used for formatting.
						/// </summary>
						/// <param name="oLocale">Locale to ask for locale specific texts/settings</param>
						/// <returns>date instance of the DateFormat</returns>
						public extern static sap.ui.core.format.DateFormat getDateInstance(sap.ui.core.Locale oLocale);

						/// <summary>
						/// Get a datetime instance of the DateFormat, which can be used for formatting.
						/// </summary>
						/// <param name="oFormatOptions">Object which defines the format options</param>
						/// <param name="oLocale">Locale to ask for locale specific texts/settings</param>
						/// <returns>datetime instance of the DateFormat</returns>
						public extern static sap.ui.core.format.DateFormat getDateTimeInstance(sap.ui.core.format.DateFormat.InstanceOptions oFormatOptions, sap.ui.core.Locale oLocale);

						/// <summary>
						/// Get a datetime instance of the DateFormat, which can be used for formatting.
						/// </summary>
						/// <param name="oFormatOptions">Object which defines the format options</param>
						/// <returns>datetime instance of the DateFormat</returns>
						public extern static sap.ui.core.format.DateFormat getDateTimeInstance(sap.ui.core.format.DateFormat.InstanceOptions oFormatOptions);

						/// <summary>
						/// Get a datetime instance of the DateFormat, which can be used for formatting.
						/// </summary>
						/// <returns>datetime instance of the DateFormat</returns>
						public extern static sap.ui.core.format.DateFormat getDateTimeInstance();

						/// <summary>
						/// Get a datetime instance of the DateFormat, which can be used for formatting.
						/// </summary>
						/// <param name="oLocale">Locale to ask for locale specific texts/settings</param>
						/// <returns>datetime instance of the DateFormat</returns>
						public extern static sap.ui.core.format.DateFormat getDateTimeInstance(sap.ui.core.Locale oLocale);

						/// <summary>
						/// Get a time instance of the DateFormat, which can be used for formatting.
						/// </summary>
						/// <param name="oFormatOptions">Object which defines the format options</param>
						/// <param name="oLocale">Locale to ask for locale specific texts/settings</param>
						/// <returns>time instance of the DateFormat</returns>
						public extern static sap.ui.core.format.DateFormat getTimeInstance(sap.ui.core.format.DateFormat.InstanceOptions oFormatOptions, sap.ui.core.Locale oLocale);

						/// <summary>
						/// Get a time instance of the DateFormat, which can be used for formatting.
						/// </summary>
						/// <param name="oFormatOptions">Object which defines the format options</param>
						/// <returns>time instance of the DateFormat</returns>
						public extern static sap.ui.core.format.DateFormat getTimeInstance(sap.ui.core.format.DateFormat.InstanceOptions oFormatOptions);

						/// <summary>
						/// Get a time instance of the DateFormat, which can be used for formatting.
						/// </summary>
						/// <returns>time instance of the DateFormat</returns>
						public extern static sap.ui.core.format.DateFormat getTimeInstance();

						/// <summary>
						/// Get a time instance of the DateFormat, which can be used for formatting.
						/// </summary>
						/// <param name="oLocale">Locale to ask for locale specific texts/settings</param>
						/// <returns>time instance of the DateFormat</returns>
						public extern static sap.ui.core.format.DateFormat getTimeInstance(sap.ui.core.Locale oLocale);

						/// <summary>
						/// Parse a string which is formatted according to the given format options.
						/// </summary>
						/// <param name="sValue">the string containing a formatted date/time value</param>
						/// <param name="bUTC">whether to use UTC, if no timezone is contained</param>
						/// <param name="bStrict">to use strict value check</param>
						/// <returns>the parsed value(s)</returns>
						public extern virtual Union<System.DateTime, System.DateTime[]> parse(string sValue, bool bUTC, bool bStrict);

						#endregion

					}
				}
			}
		}
	}
}
