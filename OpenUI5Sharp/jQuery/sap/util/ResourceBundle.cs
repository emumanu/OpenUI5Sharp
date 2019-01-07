using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public abstract partial class jQuery
	{
		public static partial class sap
		{
			public static partial class util
			{
				/// <summary>
				/// Contains locale-specific texts.
				/// 
				/// If you need a locale-specific text within your application, you can use the resource bundle to load the locale-specific file from the server and access the texts of it.
				/// 
				/// Use {@link jQuery.sap.resources} to create an instance of jQuery.sap.util.ResourceBundle. There you have to specify the URL to the base .properties file of a bundle (.properties without any locale information, e.g. "mybundle.properties"), and optionally a locale. The locale is defined as a string of the language and an optional country code separated by underscore (e.g. "en_GB" or "fr"). If no locale is passed, the default locale is "en" if the SAPUI5 framework is not available. Otherwise the default locale is taken from the SAPUI5 configuration.
				/// 
				/// With the getText() method of the resource bundle, a locale-specific string value for a given key will be returned.
				/// 
				/// With the given locale, the ResourceBundle requests the locale-specific properties file (e.g. "mybundle_fr_FR.properties"). If no file is found for the requested locale or if the file does not contain a text for the given key, a sequence of fall back locales is tried one by one. First, if the locale contains a region information (fr_FR), then the locale without the region is tried (fr). If that also can't be found or doesn't contain the requested text, the English file is used (en - assuming that most development projects contain at least English texts). If that also fails, the file without locale (base URL of the bundle) is tried.
				/// 
				/// If none of the requested files can be found or none of them contains a text for the given key, then the key itself is returned as text.
				/// 
				/// Exception: Fallback for "zh_HK" is "zh_TW" before zh.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("jQuery.sap.util.ResourceBundle")]
				[Obsolete("Deprecated since 1.58. use {@link module:sap/base/i18n/ResourceBundle} instead")]
				public partial interface ResourceBundle
				{
					#region Methods

					/// <summary>
					/// Returns a locale-specific string value for the given key sKey.
					/// 
					/// The text is searched in this resource bundle according to the fallback chain described in {@link jQuery.sap.util.ResourceBundle}. If no text could be found, the key itself is used as text.
					/// 
					/// If the second parameter<code>aArgs</code> is given, then any placeholder of the form "{<i>n</i>}" (with <i>n</i> being an integer) is replaced by the corresponding value from <code>aArgs</code> with index <i>n</i>. Note: This replacement is applied to the key if no text could be found. For more details on the replacement mechanism refer to {@link jQuery.sap.formatMessage}.
					/// </summary>
					/// <param name="sKey">Key to retrieve the text for</param>
					/// <param name="aArgs">List of parameter values which should replace the placeholders "{<i>n</i>}" (<i>n</i> is the index) in the found locale-specific string value. Note that the replacement is done whenever <code>aArgs</code> is given, no matter whether the text contains placeholders or not and no matter whether <code>aArgs</code> contains a value for <i>n</i> or not.</param>
					/// <returns>The value belonging to the key, if found; otherwise the key itself.</returns>
					string getText(string sKey, string[] aArgs);

					/// <summary>
					/// Returns a locale-specific string value for the given key sKey.
					/// 
					/// The text is searched in this resource bundle according to the fallback chain described in {@link jQuery.sap.util.ResourceBundle}. If no text could be found, the key itself is used as text.
					/// 
					/// If the second parameter<code>aArgs</code> is given, then any placeholder of the form "{<i>n</i>}" (with <i>n</i> being an integer) is replaced by the corresponding value from <code>aArgs</code> with index <i>n</i>. Note: This replacement is applied to the key if no text could be found. For more details on the replacement mechanism refer to {@link jQuery.sap.formatMessage}.
					/// </summary>
					/// <param name="sKey">Key to retrieve the text for</param>
					/// <param name="aArgs">List of parameter values which should replace the placeholders "{<i>n</i>}" (<i>n</i> is the index) in the found locale-specific string value. Note that the replacement is done whenever <code>aArgs</code> is given, no matter whether the text contains placeholders or not and no matter whether <code>aArgs</code> contains a value for <i>n</i> or not.</param>
					/// <returns>The value belonging to the key, if found; otherwise the key itself.</returns>
					string getText(string sKey, object[] aArgs);

					/// <summary>
					/// Returns a locale-specific string value for the given key sKey.
					/// 
					/// The text is searched in this resource bundle according to the fallback chain described in {@link jQuery.sap.util.ResourceBundle}. If no text could be found, the key itself is used as text.
					/// 
					/// If the second parameter<code>aArgs</code> is given, then any placeholder of the form "{<i>n</i>}" (with <i>n</i> being an integer) is replaced by the corresponding value from <code>aArgs</code> with index <i>n</i>. Note: This replacement is applied to the key if no text could be found. For more details on the replacement mechanism refer to {@link jQuery.sap.formatMessage}.
					/// </summary>
					/// <param name="sKey">Key to retrieve the text for</param>
					/// <returns>The value belonging to the key, if found; otherwise the key itself.</returns>
					string getText(string sKey);

					/// <summary>
					/// Checks whether a text for the given key can be found in the first loaded resource bundle or not. Neither the custom resource bundles nor the fallback chain will be processed.
					/// 
					/// This method allows to check for the existence of a text without triggering requests for the fallback locales.
					/// 
					/// When requesting the resource bundle asynchronously this check must only be used after the resource bundle has been loaded.
					/// </summary>
					/// <param name="sKey">Key to check</param>
					/// <returns>true if the text has been found in the concrete bundle</returns>
					bool hasText(string sKey);

					#endregion

				}
			}
		}
	}
}
