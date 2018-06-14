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
			public static partial class core
			{
				/// <summary>
				/// Provides access to locale-specific data, like date formats, number formats, currencies, etc.
				/// </summary>
				[External]
				[Namespace(false)]
				public partial class LocaleData : sap.ui.@base.Object
				{
					#region Constructor

					/// <summary>
					/// Creates an instance of LocaleData for the given locale.
					/// </summary>
					/// <param name="oLocale">the locale</param>
					public extern LocaleData(sap.ui.core.Locale oLocale);

					#endregion

					#region Methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.LocaleData with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.LocaleData with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.LocaleData with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns the defined pattern for representing the calendar week number.
					/// </summary>
					/// <param name="sStyle">the style of the pattern. It can only be either "wide" or "narrow".</param>
					/// <param name="iWeekNumber">the week number</param>
					/// <returns>the week number string</returns>
					public extern virtual string getCalendarWeek(string sStyle, int iWeekNumber);

					/// <summary>
					/// Get combined datetime pattern with given date and and time style.
					/// </summary>
					/// <param name="sDateStyle">the required style for the date part</param>
					/// <param name="sTimeStyle">the required style for the time part</param>
					/// <param name="sCalendarType">the type of calendar. If it's not set, it falls back to the calendar type either set in configuration or calculated from locale.</param>
					/// <returns>the combined datetime pattern</returns>
					public extern virtual string getCombinedDateTimePattern(string sDateStyle, string sTimeStyle, sap.ui.core.CalendarType sCalendarType);

					/// <summary>
					/// Get combined datetime pattern with given date and and time style.
					/// </summary>
					/// <param name="sDateStyle">the required style for the date part</param>
					/// <param name="sTimeStyle">the required style for the time part</param>
					/// <returns>the combined datetime pattern</returns>
					public extern virtual string getCombinedDateTimePattern(string sDateStyle, string sTimeStyle);

					/// <summary>
					/// Get combined interval pattern using a given pattern and the fallback interval pattern.
					/// 
					/// If a skeleton based pattern is not available or not wanted, this method can be used to create an interval pattern based on a given pattern, using the fallback interval pattern.
					/// </summary>
					/// <param name="sPattern">the single date pattern to use within the interval pattern</param>
					/// <param name="sCalendarType">the type of calendar. If it's not set, it falls back to the calendar type either set in configuration or calculated from locale.</param>
					/// <returns>the calculated interval pattern</returns>
					public extern virtual string getCombinedIntervalPattern(string sPattern, sap.ui.core.CalendarType sCalendarType);

					/// <summary>
					/// Get combined interval pattern using a given pattern and the fallback interval pattern.
					/// 
					/// If a skeleton based pattern is not available or not wanted, this method can be used to create an interval pattern based on a given pattern, using the fallback interval pattern.
					/// </summary>
					/// <param name="sPattern">the single date pattern to use within the interval pattern</param>
					/// <returns>the calculated interval pattern</returns>
					public extern virtual string getCombinedIntervalPattern(string sPattern);

					/// <summary>
					/// Returns the currency code which is corresponded with the given currency symbol.
					/// </summary>
					/// <param name="sCurrencySymbol">The currency symbol which needs to be converted to currency code</param>
					/// <returns>The corresponded currency code defined for the given currency symbol. The given currency symbol is returned if no currency code can be found by using the given currency symbol.</returns>
					public extern virtual string getCurrencyCodeBySymbol(string sCurrencySymbol);

					/// <summary>
					/// Returns the number of digits of the specified currency.
					/// </summary>
					/// <param name="sCurrency">ISO 4217 currency code</param>
					/// <returns>digits of the currency</returns>
					public extern virtual int getCurrencyDigits(string sCurrency);

					/// <summary>
					/// Returns the short currency formats (like 1K USD, 1M USD....).
					/// </summary>
					/// <param name="sStyle">short</param>
					/// <param name="sNumber">1000, 10000 ...</param>
					/// <param name="sPlural">one or other (if not exists other is used)</param>
					/// <returns>decimal format</returns>
					public extern virtual string getCurrencyFormat(string sStyle, string sNumber, string sPlural);

					/// <summary>
					/// Get currency format pattern.
					/// </summary>
					/// <param name="sContext">the context of the currency pattern (standard or accounting)</param>
					/// <returns>The pattern</returns>
					public extern virtual string getCurrencyPattern(string sContext);

					/// <summary>
					/// Returns the currency symbol for the specified currency, if no symbol is found the ISO 4217 currency code is returned.
					/// </summary>
					/// <param name="sCurrency">ISO 4217 currency code</param>
					/// <returns>the currency symbol</returns>
					public extern virtual string getCurrencySymbol(string sCurrency);

					/// <summary>
					/// Get custom datetime pattern for a given skeleton format.
					/// 
					/// The format string does contain pattern symbols (e.g. "yMMMd" or "Hms") and will be converted into the pattern in the used locale, which matches the wanted symbols best. The symbols must be in canonical order, that is: Era (G), Year (y/Y), Quarter (q/Q), Month (M/L), Week (w/W), Day-Of-Week (E/e/c), Day (d/D), Hour (h/H/k/K/), Minute (m), Second (s), Timezone (z/Z/v/V/O/X/x)
					/// 
					/// See http://unicode.org/reports/tr35/tr35-dates.html#availableFormats_appendItems
					/// </summary>
					/// <param name="sSkeleton">the wanted skeleton format for the datetime pattern</param>
					/// <param name="sCalendarType">the type of calendar. If it's not set, it falls back to the calendar type either set in configuration or calculated from locale.</param>
					/// <returns>the best matching datetime pattern</returns>
					public extern virtual string getCustomDateTimePattern(string sSkeleton, sap.ui.core.CalendarType sCalendarType);

					/// <summary>
					/// Get custom datetime pattern for a given skeleton format.
					/// 
					/// The format string does contain pattern symbols (e.g. "yMMMd" or "Hms") and will be converted into the pattern in the used locale, which matches the wanted symbols best. The symbols must be in canonical order, that is: Era (G), Year (y/Y), Quarter (q/Q), Month (M/L), Week (w/W), Day-Of-Week (E/e/c), Day (d/D), Hour (h/H/k/K/), Minute (m), Second (s), Timezone (z/Z/v/V/O/X/x)
					/// 
					/// See http://unicode.org/reports/tr35/tr35-dates.html#availableFormats_appendItems
					/// </summary>
					/// <param name="sSkeleton">the wanted skeleton format for the datetime pattern</param>
					/// <returns>the best matching datetime pattern</returns>
					public extern virtual string getCustomDateTimePattern(string sSkeleton);

					/// <summary>
					/// Get interval pattern for a given skeleton format.
					/// 
					/// The format string does contain pattern symbols (e.g. "yMMMd" or "Hms") and will be converted into the pattern in the used locale, which matches the wanted symbols best. The symbols must be in canonical order, that is: Era (G), Year (y/Y), Quarter (q/Q), Month (M/L), Week (w/W), Day-Of-Week (E/e/c), Day (d/D), Hour (h/H/k/K/), Minute (m), Second (s), Timezone (z/Z/v/V/O/X/x)
					/// 
					/// See http://unicode.org/reports/tr35/tr35-dates.html#availableFormats_appendItems
					/// </summary>
					/// <param name="sSkeleton">the wanted skeleton format for the datetime pattern</param>
					/// <param name="vGreatestDiff">is either a string which represents the symbol matching the greatest difference in the two dates to format or an object which contains key-value pairs. The value is always true. The key is one of the date field symbol groups whose value are different between the two dates. The key can only be set with 'Year', 'Quarter', 'Month', 'Week', 'Day', 'DayPeriod', 'Hour', 'Minute', or 'Second'.</param>
					/// <param name="sCalendarType">the type of calendar. If it's not set, it falls back to the calendar type either set in configuration or calculated from locale.</param>
					/// <returns>the best matching interval pattern if interval difference is given otherwise an array with all possible interval patterns which match the given skeleton format</returns>
					public extern virtual Union<string, string[]> getCustomIntervalPattern(string sSkeleton, Union<object, string> vGreatestDiff, sap.ui.core.CalendarType sCalendarType);

					/// <summary>
					/// Get interval pattern for a given skeleton format.
					/// 
					/// The format string does contain pattern symbols (e.g. "yMMMd" or "Hms") and will be converted into the pattern in the used locale, which matches the wanted symbols best. The symbols must be in canonical order, that is: Era (G), Year (y/Y), Quarter (q/Q), Month (M/L), Week (w/W), Day-Of-Week (E/e/c), Day (d/D), Hour (h/H/k/K/), Minute (m), Second (s), Timezone (z/Z/v/V/O/X/x)
					/// 
					/// See http://unicode.org/reports/tr35/tr35-dates.html#availableFormats_appendItems
					/// </summary>
					/// <param name="sSkeleton">the wanted skeleton format for the datetime pattern</param>
					/// <param name="vGreatestDiff">is either a string which represents the symbol matching the greatest difference in the two dates to format or an object which contains key-value pairs. The value is always true. The key is one of the date field symbol groups whose value are different between the two dates. The key can only be set with 'Year', 'Quarter', 'Month', 'Week', 'Day', 'DayPeriod', 'Hour', 'Minute', or 'Second'.</param>
					/// <returns>the best matching interval pattern if interval difference is given otherwise an array with all possible interval patterns which match the given skeleton format</returns>
					public extern virtual Union<string, string[]> getCustomIntervalPattern(string sSkeleton, Union<object, string> vGreatestDiff);

					/// <summary>
					/// Get date pattern in format "short", "medium", "long" or "full".
					/// </summary>
					/// <param name="sStyle">the required style for the date pattern</param>
					/// <param name="sCalendarType">the type of calendar. If it's not set, it falls back to the calendar type either set in configuration or calculated from locale.</param>
					/// <returns>the selected date pattern</returns>
					public extern virtual string getDatePattern(string sStyle, sap.ui.core.CalendarType sCalendarType);

					/// <summary>
					/// Get date pattern in format "short", "medium", "long" or "full".
					/// </summary>
					/// <param name="sStyle">the required style for the date pattern</param>
					/// <returns>the selected date pattern</returns>
					public extern virtual string getDatePattern(string sStyle);

					/// <summary>
					/// Get datetime pattern in style "short", "medium", "long" or "full".
					/// </summary>
					/// <param name="sStyle">the required style for the datetime pattern</param>
					/// <param name="sCalendarType">the type of calendar. If it's not set, it falls back to the calendar type either set in configuration or calculated from locale.</param>
					/// <returns>the selected datetime pattern</returns>
					public extern virtual string getDateTimePattern(string sStyle, sap.ui.core.CalendarType sCalendarType);

					/// <summary>
					/// Get datetime pattern in style "short", "medium", "long" or "full".
					/// </summary>
					/// <param name="sStyle">the required style for the datetime pattern</param>
					/// <returns>the selected datetime pattern</returns>
					public extern virtual string getDateTimePattern(string sStyle);

					/// <summary>
					/// Get day periods in width "narrow", "abbreviated" or "wide".
					/// </summary>
					/// <param name="sWidth">the required width for the day period names</param>
					/// <param name="sCalendarType">the type of calendar. If it's not set, it falls back to the calendar type either set in configuration or calculated from locale.</param>
					/// <returns>array of day periods (AM, PM)</returns>
					public extern virtual object[] getDayPeriods(string sWidth, sap.ui.core.CalendarType sCalendarType);

					/// <summary>
					/// Get day periods in width "narrow", "abbreviated" or "wide".
					/// </summary>
					/// <param name="sWidth">the required width for the day period names</param>
					/// <returns>array of day periods (AM, PM)</returns>
					public extern virtual object[] getDayPeriods(string sWidth);

					/// <summary>
					/// Get standalone day periods in width "narrow", "abbreviated" or "wide".
					/// </summary>
					/// <param name="sWidth">the required width for the day period names</param>
					/// <param name="sCalendarType">the type of calendar. If it's not set, it falls back to the calendar type either set in configuration or calculated from locale.</param>
					/// <returns>array of day periods (AM, PM)</returns>
					public extern virtual object[] getDayPeriodsStandAlone(string sWidth, sap.ui.core.CalendarType sCalendarType);

					/// <summary>
					/// Get standalone day periods in width "narrow", "abbreviated" or "wide".
					/// </summary>
					/// <param name="sWidth">the required width for the day period names</param>
					/// <returns>array of day periods (AM, PM)</returns>
					public extern virtual object[] getDayPeriodsStandAlone(string sWidth);

					/// <summary>
					/// Get day names in width "narrow", "abbreviated" or "wide".
					/// </summary>
					/// <param name="sWidth">the required width for the day names</param>
					/// <param name="sCalendarType">the type of calendar. If it's not set, it falls back to the calendar type either set in configuration or calculated from locale.</param>
					/// <returns>array of day names (starting with Sunday)</returns>
					public extern virtual object[] getDays(string sWidth, sap.ui.core.CalendarType sCalendarType);

					/// <summary>
					/// Get day names in width "narrow", "abbreviated" or "wide".
					/// </summary>
					/// <param name="sWidth">the required width for the day names</param>
					/// <returns>array of day names (starting with Sunday)</returns>
					public extern virtual object[] getDays(string sWidth);

					/// <summary>
					/// Get stand alone day names in width "narrow", "abbreviated" or "wide".
					/// </summary>
					/// <param name="sWidth">the required width for the day names</param>
					/// <param name="sCalendarType">the type of calendar. If it's not set, it falls back to the calendar type either set in configuration or calculated from locale.</param>
					/// <returns>array of day names (starting with Sunday)</returns>
					public extern virtual object[] getDaysStandAlone(string sWidth, sap.ui.core.CalendarType sCalendarType);

					/// <summary>
					/// Get stand alone day names in width "narrow", "abbreviated" or "wide".
					/// </summary>
					/// <param name="sWidth">the required width for the day names</param>
					/// <returns>array of day names (starting with Sunday)</returns>
					public extern virtual object[] getDaysStandAlone(string sWidth);

					/// <summary>
					/// Returns the short decimal formats (like 1K, 1M....).
					/// </summary>
					/// <param name="sStyle">short or long</param>
					/// <param name="sNumber">1000, 10000 ...</param>
					/// <param name="sPlural">one or other (if not exists other is used)</param>
					/// <returns>decimal format</returns>
					public extern virtual string getDecimalFormat(string sStyle, string sNumber, string sPlural);

					/// <summary>
					/// Get decimal format pattern.
					/// </summary>
					/// <returns>The pattern</returns>
					public extern virtual string getDecimalPattern();

					/// <summary>
					/// Returns the display name for a time unit (second, minute, hour, day, week, month, year).
					/// </summary>
					/// <param name="sType">Type (second, minute, hour, day, week, month, year)</param>
					/// <param name="sStyle">@since 1.32.10, 1.34.4 the style of the pattern. The valid values are "wide", "short" and "narrow" returns {string} display name</param>
					public extern virtual void getDisplayName(string sType, string sStyle = "wide");

					/// <summary>
					/// Returns the map of era IDs to era dates.
					/// </summary>
					/// <param name="sCalendarType">the type of calendar</param>
					/// <returns>the array of eras containing objects with either an _end or _start property with a date</returns>
					public extern virtual object[] getEraDates(sap.ui.core.CalendarType sCalendarType);

					/// <summary>
					/// Returns the map of era IDs to era dates.
					/// </summary>
					/// <returns>the array of eras containing objects with either an _end or _start property with a date</returns>
					public extern virtual object[] getEraDates();

					/// <summary>
					/// Returns array of eras.
					/// </summary>
					/// <param name="sWidth">the style of the era name. It can be 'wide', 'abbreviated' or 'narrow'</param>
					/// <param name="sCalendarType">the type of calendar</param>
					/// <returns>the array of eras</returns>
					public extern virtual object[] getEras(string sWidth, sap.ui.core.CalendarType sCalendarType);

					/// <summary>
					/// Returns array of eras.
					/// </summary>
					/// <param name="sWidth">the style of the era name. It can be 'wide', 'abbreviated' or 'narrow'</param>
					/// <returns>the array of eras</returns>
					public extern virtual object[] getEras(string sWidth);

					/// <summary>
					/// Returns the day that usually is regarded as the first day of a week in the current locale.
					/// 
					/// Days are encoded as integer where Sunday=0, Monday=1 etc.
					/// 
					/// All week data information in the CLDR is provided for territories (countries). If the locale of this LocaleData doesn't contain country information (e.g. if it contains only a language), then the "likelySubtag" information of the CLDR is taken into account to guess the "most likely" territory for the locale.
					/// </summary>
					/// <returns>first day of week</returns>
					public extern virtual int getFirstDayOfWeek();

					/// <summary>
					/// Returns the interval format with the given Id (see CLDR documentation for valid Ids) or the fallback format if no interval format with that Id is known.
					/// 
					/// The empty Id ("") might be used to retrieve the interval format fallback.
					/// </summary>
					/// <param name="sId">Id of the interval format, e.g. "d-d"</param>
					/// <param name="sCalendarType">the type of calendar. If it's not set, it falls back to the calendar type either set in configuration or calculated from locale.</param>
					/// <returns>interval format string with placeholders {0} and {1}</returns>
					public extern virtual string getIntervalPattern(string sId, sap.ui.core.CalendarType sCalendarType);

					/// <summary>
					/// Returns the interval format with the given Id (see CLDR documentation for valid Ids) or the fallback format if no interval format with that Id is known.
					/// 
					/// The empty Id ("") might be used to retrieve the interval format fallback.
					/// </summary>
					/// <param name="sId">Id of the interval format, e.g. "d-d"</param>
					/// <returns>interval format string with placeholders {0} and {1}</returns>
					public extern virtual string getIntervalPattern(string sId);

					/// <summary>
					/// Get locale specific language names.
					/// </summary>
					/// <returns>map of locale specific language names</returns>
					public extern virtual object getLanguages();

					/// <summary>
					/// Returns a metadata object for class sap.ui.core.LocaleData.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					/// <summary>
					/// Returns the required minimal number of days for the first week of a year.
					/// 
					/// This is the minimal number of days of the week which must be contained in the new year for the week to become the first week of the year. Depending on the country, this is just a single day (in the US) or at least 4 days (in most of Europe).
					/// 
					/// All week data information in the CLDR is provided for territories (countries). If the locale of this LocaleData doesn't contain country information (e.g. if it contains only a language), then the "likelySubtag" information of the CLDR is taken into account to guess the "most likely" territory for the locale.
					/// </summary>
					/// <returns>minimal number of days</returns>
					public extern virtual int getMinimalDaysInFirstWeek();

					/// <summary>
					/// Get month names in width "narrow", "abbreviated" or "wide".
					/// </summary>
					/// <param name="sWidth">the required width for the month names</param>
					/// <param name="sCalendarType">the type of calendar. If it's not set, it falls back to the calendar type either set in configuration or calculated from locale.</param>
					/// <returns>array of month names (starting with January)</returns>
					public extern virtual object[] getMonths(string sWidth, sap.ui.core.CalendarType sCalendarType);

					/// <summary>
					/// Get month names in width "narrow", "abbreviated" or "wide".
					/// </summary>
					/// <param name="sWidth">the required width for the month names</param>
					/// <returns>array of month names (starting with January)</returns>
					public extern virtual object[] getMonths(string sWidth);

					/// <summary>
					/// Get stand alone month names in width "narrow", "abbreviated" or "wide".
					/// </summary>
					/// <param name="sWidth">the required width for the month names</param>
					/// <param name="sCalendarType">the type of calendar. If it's not set, it falls back to the calendar type either set in configuration or calculated from locale.</param>
					/// <returns>array of month names (starting with January)</returns>
					public extern virtual object[] getMonthsStandAlone(string sWidth, sap.ui.core.CalendarType sCalendarType);

					/// <summary>
					/// Get stand alone month names in width "narrow", "abbreviated" or "wide".
					/// </summary>
					/// <param name="sWidth">the required width for the month names</param>
					/// <returns>array of month names (starting with January)</returns>
					public extern virtual object[] getMonthsStandAlone(string sWidth);

					/// <summary>
					/// Get number symbol "decimal", "group", "plusSign", "minusSign", "percentSign".
					/// </summary>
					/// <param name="sType">the required type of symbol</param>
					/// <returns>the selected number symbol</returns>
					public extern virtual string getNumberSymbol(string sType);

					/// <summary>
					/// Get orientation (left-to-right or right-to-left).
					/// </summary>
					/// <returns>character orientation for this locale</returns>
					public extern virtual string getOrientation();

					/// <summary>
					/// Get percent format pattern.
					/// </summary>
					/// <returns>The pattern</returns>
					public extern virtual string getPercentPattern();

					/// <summary>
					/// Returns an array of all plural categories available in this language.
					/// </summary>
					/// <returns>The array of plural categories</returns>
					public extern virtual object[] getPluralCategories();

					/// <summary>
					/// Returns the plural category (zero, one, two, few, many or other) for the given number value. The number should be passed as a string with dot as decimal separator and the number of decimal/fraction digits as used in the final output. This is needed in order to preserve trailing zeros which are relevant to determine the right plural category.
					/// </summary>
					/// <param name="sNumber">The number to find the plural category for</param>
					/// <returns>The plural category</returns>
					public extern virtual string getPluralCategory(Union<string, int> sNumber);

					/// <summary>
					/// Returns the preferred calendar type for the current locale which exists in {@link sap.ui.core.CalendarType}
					/// </summary>
					/// <returns>the preferred calendar type</returns>
					public extern virtual sap.ui.core.CalendarType getPreferredCalendarType();

					/// <summary>
					/// Returns the preferred hour pattern symbol (h for 12, H for 24 hours) for the current locale.
					/// </summary>
					/// <returns>the preferred hour symbol</returns>
					public extern virtual string getPreferredHourSymbol();

					/// <summary>
					/// Get quarter names in width "narrow", "abbreviated" or "wide".
					/// </summary>
					/// <param name="sWidth">the required width for the quarter names</param>
					/// <param name="sCalendarType">the type of calendar. If it's not set, it falls back to the calendar type either set in configuration or calculated from locale.</param>
					/// <returns>array of quarters</returns>
					public extern virtual object[] getQuarters(string sWidth, sap.ui.core.CalendarType sCalendarType);

					/// <summary>
					/// Get quarter names in width "narrow", "abbreviated" or "wide".
					/// </summary>
					/// <param name="sWidth">the required width for the quarter names</param>
					/// <returns>array of quarters</returns>
					public extern virtual object[] getQuarters(string sWidth);

					/// <summary>
					/// Get stand alone quarter names in width "narrow", "abbreviated" or "wide".
					/// </summary>
					/// <param name="sWidth">the required width for the quarter names</param>
					/// <param name="sCalendarType">the type of calendar. If it's not set, it falls back to the calendar type either set in configuration or calculated from locale.</param>
					/// <returns>array of quarters</returns>
					public extern virtual object[] getQuartersStandAlone(string sWidth, sap.ui.core.CalendarType sCalendarType);

					/// <summary>
					/// Get stand alone quarter names in width "narrow", "abbreviated" or "wide".
					/// </summary>
					/// <param name="sWidth">the required width for the quarter names</param>
					/// <returns>array of quarters</returns>
					public extern virtual object[] getQuartersStandAlone(string sWidth);

					/// <summary>
					/// Returns the relative day resource pattern (like "Today", "Yesterday", "{0} days ago") based on the given difference of days (0 means today, 1 means tommorrow, -1 means yesterday, ...).
					/// </summary>
					/// <param name="iDiff">the difference in days</param>
					/// <param name="sStyle">@since 1.32.10, 1.34.4 the style of the pattern. The valid values are "wide", "short" and "narrow"</param>
					/// <returns>the relative day resource pattern</returns>
					public extern virtual string getRelativeDay(int iDiff, string sStyle = "wide");

					/// <summary>
					/// Returns the relative resource pattern with unit 'hour' (like "in {0} hour(s)", "{0} hour(s) ago" under locale 'en') based on the given difference value (positive value means in the future and negative value means in the past).
					/// 
					/// There's no pattern defined for 0 difference and the function returns null if 0 is given. In the 0 difference case, you can use the getRelativeMinute or getRelativeSecond function to format the difference using unit 'minute' or 'second'.
					/// </summary>
					/// <param name="iDiff">the difference in hours</param>
					/// <param name="sStyle">@since 1.32.10, 1.34.4 the style of the pattern. The valid values are "wide", "short" and "narrow"</param>
					/// <returns>the relative resource pattern in unit 'hour'. The method returns null if 0 is given as parameter.</returns>
					public extern virtual string getRelativeHour(int iDiff, string sStyle = "wide");

					/// <summary>
					/// Returns the relative resource pattern with unit 'minute' (like "in {0} minute(s)", "{0} minute(s) ago" under locale 'en') based on the given difference value (positive value means in the future and negative value means in the past).
					/// 
					/// There's no pattern defined for 0 difference and the function returns null if 0 is given. In the 0 difference case, you can use the getRelativeSecond function to format the difference using unit 'second'.
					/// </summary>
					/// <param name="iDiff">the difference in minutes</param>
					/// <param name="sStyle">@since 1.32.10, 1.34.4 the style of the pattern. The valid values are "wide", "short" and "narrow"</param>
					/// <returns>the relative resource pattern in unit 'minute'. The method returns null if 0 is given as parameter.</returns>
					public extern virtual string getRelativeMinute(int iDiff, string sStyle = "wide");

					/// <summary>
					/// Returns the relative month resource pattern (like "This month", "Last month", "{0} months ago") based on the given difference of months (0 means this month, 1 means next month, -1 means last month, ...).
					/// </summary>
					/// <param name="iDiff">the difference in months</param>
					/// <param name="sStyle">@since 1.32.10, 1.34.4 the style of the pattern. The valid values are "wide", "short" and "narrow"</param>
					/// <returns>the relative month resource pattern</returns>
					public extern virtual string getRelativeMonth(int iDiff, string sStyle = "wide");

					/// <summary>
					/// Returns the relative format pattern with given scale (year, month, week, ...) and difference value.
					/// </summary>
					/// <param name="sScale">the scale the relative pattern is needed for</param>
					/// <param name="iDiff">the difference in the given scale unit</param>
					/// <param name="bFuture">whether a future or past pattern should be used</param>
					/// <param name="sStyle">@since 1.32.10, 1.34.4 the style of the pattern. The valid values are "wide", "short" and "narrow"</param>
					/// <returns>the relative format pattern</returns>
					public extern virtual string getRelativePattern(string sScale, int iDiff, bool bFuture, string sStyle = "wide");

					/// <summary>
					/// Returns the relative format pattern with given scale (year, month, week, ...) and difference value.
					/// </summary>
					/// <param name="sScale">the scale the relative pattern is needed for</param>
					/// <param name="iDiff">the difference in the given scale unit</param>
					/// <param name="bFuture">whether a future or past pattern should be used</param>
					/// <returns>the relative format pattern</returns>
					public extern virtual string getRelativePattern(string sScale, int iDiff, bool bFuture);

					/// <summary>
					/// Returns the relative format pattern with given scale (year, month, week, ...) and difference value.
					/// </summary>
					/// <param name="sScale">the scale the relative pattern is needed for</param>
					/// <param name="iDiff">the difference in the given scale unit</param>
					/// <returns>the relative format pattern</returns>
					public extern virtual string getRelativePattern(string sScale, int iDiff);

					/// <summary>
					/// Returns relative time patterns for the given scales as an array of objects containing scale, value and pattern.
					/// 
					/// The array may contain the following values: "year", "month", "week", "day", "hour", "minute" and "second". If no scales are given, patterns for all available scales will be returned.
					/// 
					/// The return array will contain objects looking like: <pre>
					/// {
					///     scale: "minute",
					///     sign: 1,
					///     pattern: "in {0} minutes"
					/// }
					/// </pre>
					/// </summary>
					/// <param name="aScales">The scales for which the available patterns should be returned</param>
					/// <param name="sStyle">@since 1.32.10, 1.34.4 The style of the scale patterns. The valid values are "wide", "short" and "narrow".</param>
					/// <returns>An array of all relative time patterns</returns>
					public extern virtual object[] getRelativePatterns(string[] aScales, string sStyle = "wide");

					/// <summary>
					/// Returns relative time patterns for the given scales as an array of objects containing scale, value and pattern.
					/// 
					/// The array may contain the following values: "year", "month", "week", "day", "hour", "minute" and "second". If no scales are given, patterns for all available scales will be returned.
					/// 
					/// The return array will contain objects looking like: <pre>
					/// {
					///     scale: "minute",
					///     sign: 1,
					///     pattern: "in {0} minutes"
					/// }
					/// </pre>
					/// </summary>
					/// <param name="aScales">The scales for which the available patterns should be returned</param>
					/// <param name="sStyle">@since 1.32.10, 1.34.4 The style of the scale patterns. The valid values are "wide", "short" and "narrow".</param>
					/// <returns>An array of all relative time patterns</returns>
					public extern virtual object[] getRelativePatterns(object[] aScales, string sStyle = "wide");

					/// <summary>
					/// Returns the relative resource pattern with unit 'second' (like now, "in {0} seconds", "{0} seconds ago" under locale 'en') based on the given difference value (0 means now, positive value means in the future and negative value means in the past).
					/// </summary>
					/// <param name="iDiff">the difference in seconds</param>
					/// <param name="sStyle">@since 1.32.10, 1.34.4 the style of the pattern. The valid values are "wide", "short" and "narrow"</param>
					/// <returns>the relative resource pattern in unit 'second'</returns>
					public extern virtual string getRelativeSecond(int iDiff, string sStyle = "wide");

					/// <summary>
					/// Returns the relative week resource pattern (like "This week", "Last week", "{0} weeks ago") based on the given difference of weeks (0 means this week, 1 means next week, -1 means last week, ...).
					/// </summary>
					/// <param name="iDiff">the difference in weeks</param>
					/// <param name="sStyle">@since 1.32.10, 1.34.4 the style of the pattern. The valid values are "wide", "short" and "narrow"</param>
					/// <returns>the relative week resource pattern</returns>
					public extern virtual string getRelativeWeek(int iDiff, string sStyle = "wide");

					/// <summary>
					/// Returns the relative year resource pattern (like "This year", "Last year", "{0} year ago") based on the given difference of years (0 means this year, 1 means next year, -1 means last year, ...).
					/// </summary>
					/// <param name="iDiff">the difference in years</param>
					/// <param name="sStyle">@since 1.32.10, 1.34.4 the style of the pattern. The valid values are "wide", "short" and "narrow"</param>
					/// <returns>the relative year resource pattern</returns>
					public extern virtual string getRelativeYear(int iDiff, string sStyle = "wide");

					/// <summary>
					/// Retrieves the unit format pattern for a specific unit name considering the unit mappings.
					/// </summary>
					/// <param name="sUnit">unit name, e.g. "duration-hour" or "my"</param>
					/// <returns>The unit format configuration for the given unit name</returns>
					public extern virtual object getResolvedUnitFormat(string sUnit);

					/// <summary>
					/// Get locale specific script names.
					/// </summary>
					/// <returns>map of locale specific script names</returns>
					public extern virtual object getScripts();

					/// <summary>
					/// Get locale specific territory names.
					/// </summary>
					/// <returns>map of locale specific territory names</returns>
					public extern virtual object getTerritories();

					/// <summary>
					/// Get time pattern in style "short", "medium", "long" or "full".
					/// </summary>
					/// <param name="sStyle">the required style for the date pattern</param>
					/// <param name="sCalendarType">the type of calendar. If it's not set, it falls back to the calendar type either set in configuration or calculated from locale.</param>
					/// <returns>the selected time pattern</returns>
					public extern virtual string getTimePattern(string sStyle, sap.ui.core.CalendarType sCalendarType);

					/// <summary>
					/// Get time pattern in style "short", "medium", "long" or "full".
					/// </summary>
					/// <param name="sStyle">the required style for the date pattern</param>
					/// <returns>the selected time pattern</returns>
					public extern virtual string getTimePattern(string sStyle);

					/// <summary>
					/// Retrieves the localized display name of a unit by sUnit, e.g. "duration-hour".
					/// </summary>
					/// <param name="sUnit">the unit key, e.g. "duration-hour"</param>
					/// <returns>The localized display name for the requested unit, e.g. <code>"Hour"</code>. Return empty string <code>""</code> if not found</returns>
					public extern virtual string getUnitDisplayName(string sUnit);

					/// <summary>
					/// Retrieves the unit format pattern for a specific unit name.
					/// 
					/// Note: Does not take unit mapping into consideration.
					/// </summary>
					/// <param name="sUnit">unit name, e.g. "duration-hour"</param>
					/// <returns>The unit format configuration for the given unit name</returns>
					public extern virtual object getUnitFormat(string sUnit);

					/// <summary>
					/// Retrieves all unit format patterns merged.
					/// 
					/// Note: Does not take unit mapping into consideration.
					/// </summary>
					/// <returns>The unit format patterns</returns>
					public extern virtual object getUnitFormats();

					/// <summary>
					/// Looks up the unit from defined unit mapping. E.g. for defined unit mapping <code> { "my": "my-custom-unit", "cm": "length-centimeter" } </code>
					/// 
					/// Call: <code>getUnitFromMapping("my")</code> would result in <code>"my-custom-unit"</code>
					/// </summary>
					/// <returns>unit from the mapping</returns>
					public extern virtual string getUnitFromMapping();

					/// <summary>
					/// Returns the last day of a weekend for the given locale.
					/// 
					/// Days are encoded in the same way as for {@link #getFirstDayOfWeek}.
					/// 
					/// All week data information in the CLDR is provided for territories (countries). If the locale of this LocaleData doesn't contain country information (e.g. if it contains only a language), then the "likelySubtag" information of the CLDR is taken into account to guess the "most likely" territory for the locale.
					/// </summary>
					/// <returns>last day of weekend</returns>
					public extern virtual int getWeekendEnd();

					/// <summary>
					/// Returns the first day of a weekend for the given locale.
					/// 
					/// Days are encoded in the same way as for {@link #getFirstDayOfWeek}.
					/// 
					/// All week data information in the CLDR is provided for territories (countries). If the locale of this LocaleData doesn't contain country information (e.g. if it contains only a language), then the "likelySubtag" information of the CLDR is taken into account to guess the "most likely" territory for the locale.
					/// </summary>
					/// <returns>first day of weekend</returns>
					public extern virtual int getWeekendStart();

					#endregion

				}
			}
		}
	}
}
