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
				public partial class Configuration : sap.ui.@base.Object
				{
					/// <summary>
					/// Encapsulates configuration settings that are related to data formatting/parsing.
					/// 
					/// <b>Note:</b> When format configuration settings are modified through this class, UI5 only ensures that formatter objects created after that point in time will honor the modifications. To be on the safe side, applications should do any modifications early in their lifecycle or recreate any model/UI that is locale dependent.
					/// </summary>
					[External]
					[Namespace(false)]
					public partial class FormatSettings : sap.ui.@base.Object
					{
						#region Constructor

						public extern FormatSettings();

						#endregion

						#region Methods

						/// <summary>
						/// Adds custom currencies to the existing entries. E.g. <code> { "KWD": {"digits": 3}, "TND" : {"digits": 3} } </code>
						/// </summary>
						/// <param name="mCurrencies">adds to the currency map</param>
						/// <returns></returns>
						public extern virtual sap.ui.core.Configuration.FormatSettings addCustomCurrencies(object mCurrencies);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.Configuration.FormatSettings with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.Configuration.FormatSettings with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.Configuration.FormatSettings with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Retrieves the custom currencies. E.g. <code> { "KWD": {"digits": 3}, "TND" : {"digits": 3} } </code>
						/// </summary>
						/// <returns>the mapping between custom currencies and its digits</returns>
						public extern virtual object getCustomCurrencies();

						/// <summary>
						/// Returns the currently set date pattern or undefined if no pattern has been defined.
						/// </summary>
						public extern virtual void getDatePattern();

						/// <summary>
						/// Returns the locale to be used for formatting.
						/// 
						/// If no such locale has been defined, this method falls back to the language, see {@link sap.ui.core.Configuration#getLanguage Configuration.getLanguage()}.
						/// 
						/// If any user preferences for date, time or number formatting have been set, and if no format locale has been specified, then a special private use subtag is added to the locale, indicating to the framework that these user preferences should be applied.
						/// </summary>
						/// <returns>the format locale</returns>
						public extern virtual sap.ui.core.Locale getFormatLocale();

						/// <summary>
						/// Returns the currently set customizing data for Islamic calendar support
						/// </summary>
						/// <returns>Returns an array contains the customizing data. Each element in the array has properties: dateFormat, islamicMonthStart, gregDate. For details, please see {@link #setLegacyDateCalendarCustomizing}</returns>
						public extern virtual object[] getLegacyDateCalendarCustomizing();

						/// <summary>
						/// Returns the currently set legacy ABAP date format (its id) or undefined if none has been set.
						/// </summary>
						public extern virtual void getLegacyDateFormat();

						/// <summary>
						/// Returns the currently set legacy ABAP number format (its id) or undefined if none has been set.
						/// </summary>
						public extern virtual void getLegacyNumberFormat();

						/// <summary>
						/// Returns the currently set legacy ABAP time format (its id) or undefined if none has been set.
						/// </summary>
						public extern virtual void getLegacyTimeFormat();

						/// <summary>
						/// Returns a metadata object for class sap.ui.core.Configuration.FormatSettings.
						/// </summary>
						/// <returns>Metadata object describing this class</returns>
						public extern static sap.ui.@base.Metadata getMetadata();

						/// <summary>
						/// Returns the currently set number symbol of the given type or undefined if no symbol has been defined.
						/// </summary>
						public extern virtual void getNumberSymbol();

						/// <summary>
						/// Returns the currently set time pattern or undefined if no pattern has been defined.
						/// </summary>
						public extern virtual void getTimePattern();

						/// <summary>
						/// Sets custom currencies and replaces existing entries. E.g. <code> { "KWD": {"digits": 3}, "TND" : {"digits": 3} } </code> Note: To unset the custom currencies: call with <code>undefined</code>
						/// </summary>
						/// <param name="mCurrencies">currency map which is set</param>
						/// <returns></returns>
						public extern virtual sap.ui.core.Configuration.FormatSettings setCustomCurrencies(object mCurrencies);

						/// <summary>
						/// Defines the preferred format pattern for the given date format style.
						/// 
						/// Calling this method with a null or undefined pattern removes a previously set pattern.
						/// 
						/// If a pattern is defined, it will be preferred over patterns derived from the current locale.
						/// 
						/// See class {@link sap.ui.core.format.DateFormat} for details about the pattern syntax.
						/// 
						/// After changing the date pattern, the framework tries to update localization specific parts of the UI. See the documentation of {@link sap.ui.core.Configuration#setLanguage} for details and restrictions.
						/// </summary>
						/// <param name="sStyle">must be one of short, medium, long or full.</param>
						/// <param name="sPattern">the format pattern to be used in LDML syntax.</param>
						/// <returns>Returns <code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.Configuration.FormatSettings setDatePattern(string sStyle, string sPattern);

						/// <summary>
						/// Defines the day used as the first day of the week.
						/// 
						/// The day is set as an integer value between 0 (Sunday) and 6 (Saturday). Calling this method with a null or undefined symbol removes a previously set value.
						/// 
						/// If a value is defined, it will be preferred over values derived from the current locale.
						/// 
						/// Usually in the US the week starts on Sunday while in most European countries on Monday. There are special cases where you want to have the first day of week set independent of the user locale.
						/// 
						/// After changing the first day of week, the framework tries to update localization specific parts of the UI. See the documentation of {@link sap.ui.core.Configuration#setLanguage} for details and restrictions.
						/// </summary>
						/// <param name="iValue">must be an integer value between 0 and 6</param>
						/// <returns>Returns <code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.Configuration.FormatSettings setFirstDayOfWeek(int iValue);

						/// <summary>
						/// Allows to specify the customizing data for Islamic calendar support
						/// </summary>
						/// <param name="aMappings">contains the customizing data for the support of Islamic calendar.</param>
						/// <returns>Returns <code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.Configuration.FormatSettings setLegacyDateCalendarCustomizing(object[] aMappings);

						/// <summary>
						/// Allows to specify one of the legacy ABAP date formats.
						/// 
						/// This method modifies the date patterns for 'short' and 'medium' style with the corresponding ABAP format. When called with a null or undefined format id, any previously applied format will be removed.
						/// 
						/// After changing the legacy date format, the framework tries to update localization specific parts of the UI. See the documentation of {@link sap.ui.core.Configuration#setLanguage} for details and restrictions.
						/// </summary>
						/// <param name="sFormatId">id of the ABAP data format (one of '1','2','3','4','5','6','7','8','9','A','B','C')</param>
						/// <returns>Returns <code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.Configuration.FormatSettings setLegacyDateFormat(string sFormatId);

						/// <summary>
						/// Allows to specify one of the legacy ABAP number format.
						/// 
						/// This method will modify the 'group' and 'decimal' symbols. When called with a null or undefined format id, any previously applied format will be removed.
						/// 
						/// After changing the legacy number format, the framework tries to update localization specific parts of the UI. See the documentation of {@link sap.ui.core.Configuration#setLanguage} for details and restrictions.
						/// </summary>
						/// <param name="sFormatId">id of the ABAP number format set (one of ' ','X','Y')</param>
						/// <returns>Returns <code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.Configuration.FormatSettings setLegacyNumberFormat(string sFormatId);

						/// <summary>
						/// Allows to specify one of the legacy ABAP time formats.
						/// 
						/// This method sets the time patterns for 'short' and 'medium' style to the corresponding ABAP formats and sets the day period texts to "AM"/"PM" or "am"/"pm" respectively. When called with a null or undefined format id, any previously applied format will be removed.
						/// 
						/// After changing the legacy time format, the framework tries to update localization specific parts of the UI. See the documentation of {@link sap.ui.core.Configuration#setLanguage} for details and restrictions.
						/// </summary>
						/// <param name="sFormatId">id of the ABAP time format (one of '0','1','2','3','4')</param>
						/// <returns>Returns <code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.Configuration.FormatSettings setLegacyTimeFormat(string sFormatId);

						/// <summary>
						/// Defines the string to be used for the given number symbol.
						/// 
						/// Calling this method with a null or undefined symbol removes a previously set symbol string. Note that an empty string is explicitly allowed.
						/// 
						/// If a symbol is defined, it will be preferred over symbols derived from the current locale.
						/// 
						/// See class {@link sap.ui.core.format.NumberFormat} for details about the symbols.
						/// 
						/// After changing the number symbol, the framework tries to update localization specific parts of the UI. See the documentation of {@link sap.ui.core.Configuration#setLanguage} for details and restrictions.
						/// </summary>
						/// <param name="sStyle">must be one of decimal, group, plusSign, minusSign.</param>
						/// <param name="sSymbol">will be used to represent the given symbol type</param>
						/// <returns>Returns <code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.Configuration.FormatSettings setNumberSymbol(string sStyle, string sSymbol);

						/// <summary>
						/// Defines the preferred format pattern for the given time format style.
						/// 
						/// Calling this method with a null or undefined pattern removes a previously set pattern.
						/// 
						/// If a pattern is defined, it will be preferred over patterns derived from the current locale.
						/// 
						/// See class {@link sap.ui.core.format.DateFormat} for details about the pattern syntax.
						/// 
						/// After changing the time pattern, the framework tries to update localization specific parts of the UI. See the documentation of {@link sap.ui.core.Configuration#setLanguage} for details and restrictions.
						/// </summary>
						/// <param name="sStyle">must be one of short, medium, long or full.</param>
						/// <param name="sPattern">the format pattern to be used in LDML syntax.</param>
						/// <returns>Returns <code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.Configuration.FormatSettings setTimePattern(string sStyle, string sPattern);

						#endregion

					}
				}
			}
		}
	}
}
