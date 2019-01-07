using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public partial class sap
	{
		public static partial class @base
		{
			public static partial class i18n
			{
				/// <summary>
				/// Contains locale-specific texts.
				/// 
				/// If you need a locale-specific text within your application, you can use the resource bundle to load the locale-specific file from the server and access the texts of it.
				/// 
				/// Use {@link module:sap/base/i18n/ResourceBundle.create} to create an instance of sap/base/i18n/ResourceBundle (.properties without any locale information, e.g. "mybundle.properties"), and optionally a locale. The locale is defined as a string of the language and an optional country code separated by underscore (e.g. "en_GB" or "fr"). If no locale is passed, the default locale is "en" if the SAPUI5 framework is not available. Otherwise the default locale is taken from the SAPUI5 configuration.
				/// 
				/// With the getText() method of the resource bundle, a locale-specific string value for a given key will be returned.
				/// 
				/// With the given locale, the resource bundle requests the locale-specific properties file (e.g. "mybundle_fr_FR.properties"). If no file is found for the requested locale or if the file does not contain a text for the given key, a sequence of fall back locales is tried one by one. First, if the locale contains a region information (fr_FR), then the locale without the region is tried (fr). If that also can't be found or doesn't contain the requested text, the English file is used (en - assuming that most development projects contain at least English texts). If that also fails, the file without locale (base URL of the bundle) is tried.
				/// 
				/// If none of the requested files can be found or none of them contains a text for the given key, then the key itself is returned as text.
				/// 
				/// Exception: Fallback for "zh_HK" is "zh_TW" before zh.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.base.i18n.ResourceBundle")]
				public partial class ResourceBundle
				{
					#region Methods

					/// <summary>
					/// Determine sequence of fallback locales, starting from the given locale and optionally taking the list of supported locales into account.
					/// 
					/// Callers can use the result to limit requests to a set of existing locales.
					/// </summary>
					/// <param name="sLocale">Locale to start the fallback sequence with, should be a BCP47 language tag</param>
					/// <param name="aSupportedLocales">List of supported locales (in JDK legacy syntax, e.g. zh_CN, iw)</param>
					/// <returns>Sequence of fallback locales in JDK legacy syntax, decreasing priority</returns>
					private extern static string[] _getFallbackLocales(string sLocale, string[] aSupportedLocales);

					/// <summary>
					/// Determine sequence of fallback locales, starting from the given locale and optionally taking the list of supported locales into account.
					/// 
					/// Callers can use the result to limit requests to a set of existing locales.
					/// </summary>
					/// <param name="sLocale">Locale to start the fallback sequence with, should be a BCP47 language tag</param>
					/// <param name="aSupportedLocales">List of supported locales (in JDK legacy syntax, e.g. zh_CN, iw)</param>
					/// <returns>Sequence of fallback locales in JDK legacy syntax, decreasing priority</returns>
					private extern static string[] _getFallbackLocales(string sLocale, object[] aSupportedLocales);

					/// <summary>
					/// Determine sequence of fallback locales, starting from the given locale and optionally taking the list of supported locales into account.
					/// 
					/// Callers can use the result to limit requests to a set of existing locales.
					/// </summary>
					/// <param name="sLocale">Locale to start the fallback sequence with, should be a BCP47 language tag</param>
					/// <returns>Sequence of fallback locales in JDK legacy syntax, decreasing priority</returns>
					private extern static string[] _getFallbackLocales(string sLocale);

					/// <summary>
					/// Creates and returns a new instance of {@link module:sap/base/i18n/ResourceBundle} using the given URL and locale to determine what to load.
					/// </summary>
					/// <param name="mParams">Parameters used to initialize the resource bundle</param>
					/// <returns>A new resource bundle or a Promise on that bundle (in asynchronous case)</returns>
					public extern static Union<sap.@base.i18n.ResourceBundle, es5.Promise<object>> create(jQuery.Info2 mParams);

					/// <summary>
					/// Creates and returns a new instance of {@link module:sap/base/i18n/ResourceBundle} using the given URL and locale to determine what to load.
					/// </summary>
					/// <returns>A new resource bundle or a Promise on that bundle (in asynchronous case)</returns>
					public extern static Union<sap.@base.i18n.ResourceBundle, es5.Promise<object>> create();

					/// <summary>
					/// Returns a locale-specific string value for the given key sKey.
					/// 
					/// The text is searched in this resource bundle according to the fallback chain described in {@link module:sap/base/i18n/ResourceBundle}. If no text could be found, the key itself is used as text.
					/// 
					/// If the second parameter<code>aArgs</code> is given, then any placeholder of the form "{<i>n</i>}" (with <i>n</i> being an integer) is replaced by the corresponding value from <code>aArgs</code> with index <i>n</i>. Note: This replacement is applied to the key if no text could be found. For more details on the replacement mechanism refer to {@link module:sap/ui/formatMessage}.
					/// </summary>
					/// <param name="sKey">Key to retrieve the text for</param>
					/// <param name="aArgs">List of parameter values which should replace the placeholders "{<i>n</i>}" (<i>n</i> is the index) in the found locale-specific string value. Note that the replacement is done whenever <code>aArgs</code> is given, no matter whether the text contains placeholders or not and no matter whether <code>aArgs</code> contains a value for <i>n</i> or not.</param>
					/// <param name="bIgnoreKeyFallback">If set, <code>undefined</code> is returned when the key is not found in any bundle or fallback bundle, instead of the key string.</param>
					/// <returns>The value belonging to the key, if found; Otherwise the key itself or <code>undefined</code> depending on bIgnoreKeyFallback.</returns>
					public extern virtual string getText(string sKey, string[] aArgs, bool bIgnoreKeyFallback);

					/// <summary>
					/// Returns a locale-specific string value for the given key sKey.
					/// 
					/// The text is searched in this resource bundle according to the fallback chain described in {@link module:sap/base/i18n/ResourceBundle}. If no text could be found, the key itself is used as text.
					/// 
					/// If the second parameter<code>aArgs</code> is given, then any placeholder of the form "{<i>n</i>}" (with <i>n</i> being an integer) is replaced by the corresponding value from <code>aArgs</code> with index <i>n</i>. Note: This replacement is applied to the key if no text could be found. For more details on the replacement mechanism refer to {@link module:sap/ui/formatMessage}.
					/// </summary>
					/// <param name="sKey">Key to retrieve the text for</param>
					/// <param name="aArgs">List of parameter values which should replace the placeholders "{<i>n</i>}" (<i>n</i> is the index) in the found locale-specific string value. Note that the replacement is done whenever <code>aArgs</code> is given, no matter whether the text contains placeholders or not and no matter whether <code>aArgs</code> contains a value for <i>n</i> or not.</param>
					/// <param name="bIgnoreKeyFallback">If set, <code>undefined</code> is returned when the key is not found in any bundle or fallback bundle, instead of the key string.</param>
					/// <returns>The value belonging to the key, if found; Otherwise the key itself or <code>undefined</code> depending on bIgnoreKeyFallback.</returns>
					public extern virtual string getText(string sKey, object[] aArgs, bool bIgnoreKeyFallback);

					/// <summary>
					/// Checks whether a text for the given key can be found in the first loaded resource bundle or not. Neither the custom resource bundles nor the fallback chain will be processed.
					/// 
					/// This method allows to check for the existence of a text without triggering requests for the fallback locales.
					/// 
					/// When requesting the resource bundle asynchronously this check must only be used after the resource bundle has been loaded.
					/// </summary>
					/// <param name="sKey">Key to check</param>
					/// <returns>true if the text has been found in the concrete bundle</returns>
					public extern virtual bool hasText(string sKey);

					#endregion

				}
			}
		}
	}
}
