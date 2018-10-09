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
				/// Collects and stores the configuration of the current environment.
				/// 
				/// The Configuration is initialized once when the {@link sap.ui.core.Core} is created. There are different ways to set the environment configuration (in ascending priority): <ol> <li>System defined defaults</li> <li>Server wide defaults, read from /sap-ui-config.json</li> <li>Properties of the global configuration object window["sap-ui-config"]</li> <li>A configuration string in the data-sap-ui-config attribute of the bootstrap tag.</li> <li>Individual data-sap-ui-<i>xyz</i> attributes of the bootstrap tag</li> <li>Using URL parameters</li> <li>Setters in this Configuration object (only for some parameters)</li> </ol>
				/// 
				/// That is, attributes of the DOM reference override the system defaults, URL parameters override the DOM attributes (where empty URL parameters set the parameter back to its system default). Calling setters at runtime will override any previous settings calculated during object creation.
				/// 
				/// The naming convention for parameters is: <ul> <li>in the URL : sap-ui-<i>PARAMETER-NAME</i>="value"</li> <li>in the DOM : data-sap-ui-<i>PARAMETER-NAME</i>="value"</li> </ul> where <i>PARAMETER-NAME</i> is the name of the parameter in lower case.
				/// 
				/// Values of boolean parameters are case insensitive where "true" and "x" are interpreted as true.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.core.Configuration")]
				public partial class Configuration : sap.ui.@base.Object
				{
					#region Constructor

					/// <summary>
					/// Creates a new Configuration object.
					/// </summary>
					public extern Configuration();

					#endregion

					#region Methods

					/// <summary>
					/// Applies multiple changes to the configuration at once.
					/// 
					/// If the changed settings contain localization related settings like <code>language</code> or <ode>calendarType</code>, then only a single <code>localizationChanged</code> event will be fired. As the framework has to inform all existing components, elements, models etc. about localization changes, using <code>applySettings</code> can significantly reduce the overhead for multiple changes, esp. when they occur after the UI has been created already.
					/// 
					/// The <code>mSettings</code> can contain any property <code><i>xyz</i></code> for which a setter method <code>set<i>XYZ</i></code> exists in the API of this class. Similarly, values for the {@link sap.ui.core.Configuration.FormatSettings format settings} API can be provided in a nested object with name <code>formatSettings</code>.
					/// </summary>
					/// <param name="mSettings">Configuration options to apply</param>
					/// <returns>Returns <code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.Configuration applySettings(object mSettings);

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.Configuration with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.Configuration with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.Configuration with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns whether the accessibility mode is used or not.
					/// </summary>
					/// <returns>whether the accessibility mode is used or not</returns>
					public extern virtual bool getAccessibility();

					/// <summary>
					/// Returns whether the animations are globally used.
					/// </summary>
					/// <returns>whether the animations are globally used</returns>
					[Obsolete("Deprecated since 1.50.0. replaced by {@link sap.ui.core.Configuration#getAnimationMode}")]
					public extern virtual bool getAnimation();

					/// <summary>
					/// Returns the current animation mode.
					/// </summary>
					/// <returns>The current animationMode</returns>
					public extern virtual sap.ui.core.Configuration.AnimationMode getAnimationMode();

					/// <summary>
					/// Base URLs to AppCacheBuster ETag-Index files.
					/// </summary>
					/// <returns>array of base URLs</returns>
					public extern virtual string[] getAppCacheBuster();

					/// <summary>
					/// Object defining the callback hooks for the AppCacheBuster like e.g. <code>handleURL</code>, <code>onIndexLoad</code> or <code>onIndexLoaded</code>.
					/// </summary>
					/// <returns>object containing the callback functions for the AppCacheBuster</returns>
					private extern object getAppCacheBusterHooks();

					/// <summary>
					/// The loading mode (sync|async|batch) of the AppCacheBuster (sync is default)
					/// </summary>
					/// <returns>"sync" | "async"</returns>
					public extern virtual string getAppCacheBusterMode();

					/// <summary>
					/// The name of the application to start or empty.
					/// </summary>
					/// <returns>name of the application</returns>
					[Obsolete("Deprecated since 1.15.1. Please use the rootComponent configuration option {@link sap.ui.core.Configuration#getRootComponent}.")]
					public extern virtual string getApplication();

					/// <summary>
					/// Returns whether the framework automatically adds automatically the ARIA role 'application' to the HTML body or not.
					/// </summary>
					/// <returns></returns>
					public extern virtual bool getAutoAriaBodyRole();

					/// <summary>
					/// Returns the used compatibility version for the given feature.
					/// </summary>
					/// <param name="sFeature">the key of desired feature</param>
					/// <returns>the used compatibility version</returns>
					public extern virtual jQuery.sap.Version getCompatibilityVersion(string sFeature);

					/// <summary>
					/// Return whether the controller code is deactivated. During design mode the.
					/// </summary>
					/// <returns>whether the activation of the controller code is suppressed or not</returns>
					private extern bool getControllerCodeDeactivated();

					/// <summary>
					/// Returns whether the page runs in debug mode.
					/// </summary>
					/// <returns>whether the page runs in debug mode</returns>
					public extern virtual bool getDebug();

					/// <summary>
					/// Return whether the design mode is active or not.
					/// </summary>
					/// <returns>whether the design mode is active or not.</returns>
					private extern bool getDesignMode();

					/// <summary>
					/// Flag, whether the customizing is disabled or not.
					/// </summary>
					/// <returns>true if customizing is disabled</returns>
					private extern bool getDisableCustomizing();

					/// <summary>
					/// Returns whether the Fiori2Adaptation is on.
					/// </summary>
					/// <returns>false - no adaptation, true - full adaptation, comma-separated list - partial adaptation Possible values: style, collapse, title, back, hierarchy</returns>
					public extern virtual Union<bool, string> getFiori2Adaptation();

					/// <summary>
					/// Returns the format locale string with language and region code. Falls back to language configuration, in case it has not been explicitly defined.
					/// </summary>
					/// <returns>the format locale string with language and country code</returns>
					public extern virtual string getFormatLocale();

					/// <summary>
					/// Returns a configuration object that bundles the format settings of UI5.
					/// </summary>
					/// <returns>A FormatSettings object.</returns>
					public extern virtual sap.ui.core.Configuration.FormatSettings getFormatSettings();

					/// <summary>
					/// frameOptions mode (allow/deny/trusted).
					/// </summary>
					/// <returns>frameOptions mode</returns>
					public extern virtual string getFrameOptions();

					/// <summary>
					/// Returns whether the UI5 control inspector is displayed. Has only an effect when the sap-ui-debug module has been loaded
					/// </summary>
					/// <returns>whether the UI5 control inspector is displayed</returns>
					public extern virtual bool getInspect();

					/// <summary>
					/// Returns a string that identifies the current language.
					/// 
					/// The value returned by this methods in most cases corresponds to the exact value that has been configured by the user or application or that has been determined from the user agent settings. It has not been normalized, but has been validated against a relaxed version of {@link http://www.ietf.org/rfc/bcp/bcp47.txt BCP47}, allowing underscores ('_') instead of the suggested dashes ('-') and not taking the case of letters into account.
					/// 
					/// The exceptions mentioned above affect languages that have been specified via the URL parameter <code>sap-language</code>. That parameter by definition represents an SAP logon language code ('ABAP language'). Most but not all of these language codes are valid ISO639 two-letter languages and as such are valid BCP47 language tags. For better BCP47 compliance, the framework maps the following non-BCP47 SAP logon codes to a BCP47 substitute: <pre>
					///    "ZH"  -->  "zh-Hans"         // script 'Hans' added to distinguish it from zh-Hant
					///    "ZF"  -->  "zh-Hant"         // ZF is not a valid ISO639 code, use the compliant language + script 'Hant'
					/// 		 "    "1Q"  -->  "en-US-x-saptrc"  // special language code for supportability (tracing),
					///                                    represented as en-US with a private extension
					///    "2Q"  -->  "en-US-x-sappsd"  // special language code for supportability (pseudo translation),
					///                                    represented as en-US with a private extension
					/// </pre>
					/// 
					/// For a normalized BCP47 tag, call {@link #getLanguageTag} or call {@link #getLocale} to get a {@link sap.ui.core.Locale Locale} object matching the language.
					/// </summary>
					/// <returns>Language string as configured</returns>
					public extern virtual string getLanguage();

					/// <summary>
					/// Returns a BCP47-compliant language tag for the current language.
					/// 
					/// The return value of this method is especially useful for an HTTP <code>Accept</code> header.
					/// </summary>
					/// <returns>The language tag for the current language, conforming to BCP47</returns>
					public extern virtual string getLanguageTag();

					/// <summary>
					/// Returns a Locale object for the current language.
					/// 
					/// The Locale is derived from the {@link #getLanguage language} property.
					/// </summary>
					/// <returns>The locale</returns>
					public extern virtual sap.ui.core.Locale getLocale();

					/// <summary>
					/// Flag whether a Component should load the manifest first.
					/// </summary>
					/// <returns>true if a Component should load the manifest first</returns>
					public extern virtual bool getManifestFirst();

					/// <summary>
					/// Returns a metadata object for class sap.ui.core.Configuration.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					/// <summary>
					/// Returns whether there should be an exception on any duplicate element IDs.
					/// </summary>
					/// <returns>whether there should be an exception on any duplicate element IDs</returns>
					public extern virtual bool getNoDuplicateIds();

					/// <summary>
					/// Returns whether the text origin information is collected.
					/// </summary>
					/// <returns>whether the text info is collected</returns>
					public extern virtual bool getOriginInfo();

					/// <summary>
					/// The name of the root component to start or empty.
					/// </summary>
					/// <returns>name of the root component</returns>
					public extern virtual string getRootComponent();

					/// <summary>
					/// Returns whether the page uses the RTL text direction.
					/// 
					/// If no mode has been explicitly set (neither <code>true</code> nor <code>false</code>), the mode is derived from the current language setting.
					/// </summary>
					/// <returns>whether the page uses the RTL text direction</returns>
					public extern virtual bool getRTL();

					/// <summary>
					/// Returns an SAP logon language for the current language.
					/// </summary>
					/// <returns>The SAP logon language code for the current language</returns>
					public extern virtual string getSAPLogonLanguage();

					/// <summary>
					/// Return whether the activation of the controller code is suppressed.
					/// </summary>
					/// <returns>whether the activation of the controller code is suppressed or not</returns>
					private extern bool getSuppressDeactivationOfControllerCode();

					/// <summary>
					/// Returns the theme name
					/// </summary>
					/// <returns>the theme name</returns>
					public extern virtual string getTheme();

					/// <summary>
					/// Prefix to be used for automatically generated control IDs. Default is a double underscore "__".
					/// </summary>
					/// <returns>the prefix to be used</returns>
					public extern virtual string getUIDPrefix();

					/// <summary>
					/// Returns the version of the framework.
					/// 
					/// Similar to <code>sap.ui.version</code>.
					/// </summary>
					/// <returns>the version</returns>
					public extern virtual jQuery.sap.Version getVersion();

					/// <summary>
					/// URL of the whitelist service.
					/// </summary>
					/// <returns>whitelist service URL</returns>
					public extern virtual string getWhitelistService();

					/// <summary>
					/// The mode for async XMLView processing. Potential values are: <code>sequential</code> Turned OFF by default
					/// </summary>
					/// <returns>Asynchronous XML Processing mode</returns>
					public extern virtual string getXMLProcessingMode();

					/// <summary>
					/// Sets the current animation mode.
					/// 
					/// Expects an animation mode as string and validates it. If a wrong animation mode was set, an error is thrown. If the mode is valid it is set, then the attributes <code>data-sap-ui-animation</code> and <code>data-sap-ui-animation-mode</code> of the HTML document root element are also updated. If the <code>animationMode</code> is <code>Configuration.AnimationMode.none</code> the old <code>animation</code> property is set to <code>false</code>, otherwise it is set to <code>true</code>.
					/// </summary>
					/// <param name="sAnimationMode">A valid animation mode</param>
					public extern virtual void setAnimationMode(sap.ui.core.Configuration.AnimationMode sAnimationMode);

					/// <summary>
					/// Sets the new calendar type to be used from now on in locale dependent functionality (for example, formatting, translation texts, etc.).
					/// </summary>
					/// <param name="sCalendarType">the new calendar type. Set it with null to clear the calendar type and the calendar type is calculated based on the format settings and current locale.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.Configuration setCalendarType(sap.ui.core.CalendarType sCalendarType);

					/// <summary>
					/// Sets a new format locale to be used from now on for retrieving locale specific formatters. Modifying this setting does not have an impact on the retrieval of translated texts!
					/// 
					/// Can either be set to a concrete value (a BCP47 or Java locale compliant language tag) or to <code>null</code>. When set to <code>null</code> (default value) then locale specific formatters are retrieved for the current language.
					/// 
					/// After changing the format locale, the framework tries to update localization specific parts of the UI. See the documentation of {@link #setLanguage} for details and restrictions.
					/// 
					/// <b>Note</b>: When a format locale is set, it has higher priority than a number, date or time format defined with a call to <code>setLegacyNumberFormat</code>, <code>setLegacyDateFormat</code> or <code>setLegacyTimeFormat</code>.
					/// 
					/// <b>Note</b>: See documentation of {@link #setLanguage} for restrictions.
					/// </summary>
					/// <param name="sFormatLocale">the new format locale as a BCP47 compliant language tag; case doesn't matter and underscores can be used instead of dashes to separate components (compatibility with Java Locale IDs)</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.Configuration setFormatLocale(string sFormatLocale);

					/// <summary>
					/// Sets a new language to be used from now on for language/region dependent functionality (e.g. formatting, data types, translated texts, ...).
					/// 
					/// When the language can't be interpreted as a BCP47 language (using the relaxed syntax described in {@link #getLanguage}, an error will be thrown.
					/// 
					/// When the language has changed, the Core will fire its {@link sap.ui.core.Core#event:localizationChanged localizationChanged} event.
					/// 
					/// <h3>Restrictions</h3>
					/// 
					/// The framework <strong>does not</strong> guarantee that already created, language dependent objects will be updated by this call. It therefore remains best practice for applications to switch the language early, e.g. before any language dependent objects are created. Applications that need to support more dynamic changes of the language should listen to the <code>localizationChanged</code> event and adapt all language dependent objects that they use (e.g. by rebuilding their UI).
					/// 
					/// Currently, the framework notifies the following objects about a change of the localization settings before it fires the <code>localizationChanged</code> event:
					/// 
					/// <ul> <li>date and number data types that are used in property bindings or composite bindings in existing Elements, Controls, UIAreas or Components</li> <li>ResourceModels currently assigned to the Core, a UIArea, Component, Element or Control</li> <li>Elements or Controls that implement the <code>onlocalizationChanged</code> hook (note the lowercase 'l' in onlocalizationChanged)</li> </ul>
					/// 
					/// It furthermore derives the RTL mode from the new language, if no explicit RTL mode has been set. If the RTL mode changes, the following additional actions will be taken:
					/// 
					/// <ul> <li>the URLs of already loaded library theme files will be changed</li> <li>the <code>dir</code> attribute of the page will be changed to reflect the new mode.</li> <li>all UIAreas will be invalidated (which results in a rendering of the whole UI5 UI)</li> </ul>
					/// 
					/// This method does not accept SAP language codes for <code>sLanguage</code>. Instead, a second parameter <code>sSAPLogonLanguage</code> can be provided with an SAP language code corresponding to the given language. A given value will be returned by the {@link #getSAPLogonLanguage} method. It is up to the caller to provide a consistent pair of BCP47 language and SAP language code. The SAP language code is only checked to be of length 2 and must consist of letters or digits only.
					/// 
					/// <b>Note</b>: When using this method please take note of and respect the above mentioned restrictions.
					/// </summary>
					/// <param name="sLanguage">the new language as a BCP47 compliant language tag; case doesn't matter and underscores can be used instead of dashes to separate components (compatibility with Java Locale IDs)</param>
					/// <param name="sSAPLogonLanguage">SAP language code that corresponds to the <code>sLanguage</code>; if a value is specified, future calls to <code>getSAPLogonLanguage</code> will return that value; if no value is specified, the framework will use the ISO639 language part of <code>sLanguage</code> as SAP Logon language.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.Configuration setLanguage(string sLanguage, string sSAPLogonLanguage);

					/// <summary>
					/// Sets a new language to be used from now on for language/region dependent functionality (e.g. formatting, data types, translated texts, ...).
					/// 
					/// When the language can't be interpreted as a BCP47 language (using the relaxed syntax described in {@link #getLanguage}, an error will be thrown.
					/// 
					/// When the language has changed, the Core will fire its {@link sap.ui.core.Core#event:localizationChanged localizationChanged} event.
					/// 
					/// <h3>Restrictions</h3>
					/// 
					/// The framework <strong>does not</strong> guarantee that already created, language dependent objects will be updated by this call. It therefore remains best practice for applications to switch the language early, e.g. before any language dependent objects are created. Applications that need to support more dynamic changes of the language should listen to the <code>localizationChanged</code> event and adapt all language dependent objects that they use (e.g. by rebuilding their UI).
					/// 
					/// Currently, the framework notifies the following objects about a change of the localization settings before it fires the <code>localizationChanged</code> event:
					/// 
					/// <ul> <li>date and number data types that are used in property bindings or composite bindings in existing Elements, Controls, UIAreas or Components</li> <li>ResourceModels currently assigned to the Core, a UIArea, Component, Element or Control</li> <li>Elements or Controls that implement the <code>onlocalizationChanged</code> hook (note the lowercase 'l' in onlocalizationChanged)</li> </ul>
					/// 
					/// It furthermore derives the RTL mode from the new language, if no explicit RTL mode has been set. If the RTL mode changes, the following additional actions will be taken:
					/// 
					/// <ul> <li>the URLs of already loaded library theme files will be changed</li> <li>the <code>dir</code> attribute of the page will be changed to reflect the new mode.</li> <li>all UIAreas will be invalidated (which results in a rendering of the whole UI5 UI)</li> </ul>
					/// 
					/// This method does not accept SAP language codes for <code>sLanguage</code>. Instead, a second parameter <code>sSAPLogonLanguage</code> can be provided with an SAP language code corresponding to the given language. A given value will be returned by the {@link #getSAPLogonLanguage} method. It is up to the caller to provide a consistent pair of BCP47 language and SAP language code. The SAP language code is only checked to be of length 2 and must consist of letters or digits only.
					/// 
					/// <b>Note</b>: When using this method please take note of and respect the above mentioned restrictions.
					/// </summary>
					/// <param name="sLanguage">the new language as a BCP47 compliant language tag; case doesn't matter and underscores can be used instead of dashes to separate components (compatibility with Java Locale IDs)</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.Configuration setLanguage(string sLanguage);

					/// <summary>
					/// Sets the character orientation mode to be used from now on.
					/// 
					/// Can either be set to a concrete value (true meaning right-to-left, false meaning left-to-right) or to <code>null</code> which means that the character orientation mode should be derived from the current language (incl. region) setting.
					/// 
					/// After changing the character orientation mode, the framework tries to update localization specific parts of the UI. See the documentation of {@link #setLanguage} for details and restrictions.
					/// 
					/// <b>Note</b>: See documentation of {@link #setLanguage} for restrictions.
					/// </summary>
					/// <param name="bRTL">new character orientation mode or <code>null</code></param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.Configuration setRTL(bool? bRTL);

					#endregion

					/// <summary>
					/// Enumerable list with available animation modes.
					/// 
					/// This enumerable is used to validate the animation mode. Animation modes allow to specify different animation scenarios or levels. The implementation of the Control (JavaScript or CSS) has to be done differently for each animation mode.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.core.Configuration.AnimationMode")]
					public enum AnimationMode
					{
						/// <summary>
						/// <code>basic</code> can be used for a reduced, more light-weight set of animations.
						/// </summary>
						basic,
						/// <summary>
						/// <code>full</code> represents a mode with unrestricted animation capabilities.
						/// </summary>
						full,
						/// <summary>
						/// <code>minimal</code> includes animations of fundamental functionality.
						/// </summary>
						minimal,
						/// <summary>
						/// <code>none</code> deactivates the animation completely.
						/// </summary>
						none,
					}
				}
			}
		}
	}
}
