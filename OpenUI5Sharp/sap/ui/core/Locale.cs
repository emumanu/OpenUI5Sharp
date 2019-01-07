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
				/// <summary>
				/// Locale represents a locale setting, consisting of a language, script, region, variants, extensions and private use section.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.core.Locale")]
				public partial class Locale : sap.ui.@base.Object
				{
					#region Constructor

					/// <summary>
					/// Creates an instance of the Locale.
					/// </summary>
					/// <param name="sLocaleId">the locale identifier, in format en-US or en_US.</param>
					public extern Locale(string sLocaleId);

					#endregion

					#region Methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.Locale with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.Locale with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.Locale with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Get the locale extension as a single string or <code>null</code>.
					/// 
					/// The extension always consists of a singleton character (not 'x'), a dash '-' and one or more extension token, each separated again with a dash.
					/// 
					/// Use {@link #getExtensions} to get the individual extension tokens as an array.
					/// </summary>
					/// <returns>the extension</returns>
					public extern virtual string getExtension();

					/// <summary>
					/// Get the locale extensions as an array of tokens.
					/// 
					/// The leading singleton and the separating dashes are not part of the result. If there is no extensions section in the locale tag, an empty array is returned.
					/// </summary>
					/// <returns>the individual extension sections</returns>
					public extern virtual string[] getExtensionSubtags();

					/// <summary>
					/// Get the locale language.
					/// 
					/// Note that the case might differ from the original script tag (Lower case is enforced as recommended by BCP47/ISO639).
					/// </summary>
					/// <returns>the language code</returns>
					public extern virtual string getLanguage();

					/// <summary>
					/// Returns a metadata object for class sap.ui.core.Locale.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					[Name("getMetadata")]
					public extern static sap.ui.@base.Metadata getMetadataStatic();

					/// <summary>
					/// Get the locale private use section or <code>null</code>.
					/// </summary>
					/// <returns>the private use section</returns>
					public extern virtual string getPrivateUse();

					/// <summary>
					/// Get the locale private use section as an array of tokens.
					/// 
					/// The leading singleton and the separating dashes are not part of the result. If there is no private use section in the locale tag, an empty array is returned.
					/// </summary>
					/// <returns>the tokens of the private use section</returns>
					public extern virtual string[] getPrivateUseSubtags();

					/// <summary>
					/// Get the locale region or <code>null</code> if none was specified.
					/// 
					/// Note that the case might differ from the original script tag (Upper case is enforced as recommended by BCP47/ISO3166-1).
					/// </summary>
					/// <returns>the ISO3166-1 region code (2-letter or 3-digits)</returns>
					public extern virtual string getRegion();

					/// <summary>
					/// Best guess to get a proper SAP Logon Language for this locale.
					/// 
					/// Conversions taken into account: <ul> <li>use the language part only</li> <li>convert old ISO639 codes to newer ones (e.g. 'iw' to 'he')</li> <li>for Chinese, map 'Traditional Chinese' to SAP proprietary code 'zf'</li> <li>map private extensions x-sap1q and x-sap2q to SAP pseudo languages '1Q' and '2Q'</li> <li>remove ext. language sub tags</li> <li>convert to uppercase</li> </ul>
					/// 
					/// Note that the conversion also returns a result for languages that are not supported by the default set of SAP languages. This method has no knowledge about the concrete languages of any given backend system.
					/// </summary>
					/// <returns>a language code that should</returns>
					[Obsolete("Deprecated since 1.44. use {@link sap.ui.core.Configuration#getSAPLogonLanguage} instead as that class allows to configure an SAP Logon language.")]
					public extern virtual string getSAPLogonLanguage();

					/// <summary>
					/// Get the locale script or <code>null</code> if none was specified.
					/// 
					/// Note that the case might differ from the original language tag (Upper case first letter and lower case reminder enforced as recommended by BCP47/ISO15924)
					/// </summary>
					/// <returns>the script code or null</returns>
					public extern virtual string getScript();

					/// <summary>
					/// Get the locale variants as a single string or <code>null</code>.
					/// 
					/// Multiple variants are separated by a dash '-'.
					/// </summary>
					/// <returns>the variant or null</returns>
					public extern virtual string getVariant();

					/// <summary>
					/// Get the locale variants as an array of individual variants.
					/// 
					/// The separating dashes are not part of the result. If there is no variant section in the locale tag, an empty array is returned.
					/// </summary>
					/// <returns>the individual variant sections</returns>
					public extern virtual string[] getVariantSubtags();

					#endregion

				}
			}
		}
	}
}
