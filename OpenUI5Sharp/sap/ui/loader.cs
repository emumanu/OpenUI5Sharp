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
			/// <summary>
			/// Provides access to UI5 loader configuration.
			/// 
			/// The configuration is used by {@link sap.ui.require} and {@link sap.ui.define}.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.ui.loader")]
			public static partial class loader
			{
				#region Typed Parameters

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class ConfigInfo
				{
					/// <summary>
					/// Default location to load modules from. If none of the configured <code>paths</code> prefixes matches a module ID, the module will be loaded from the concatenation of the <code>baseUrl</code> and the module ID.
					/// 
					/// If the <code>baseUrl</code> itself is a relative URL, it is evaluated relative to <code>document.baseURI</code>.
					/// </summary>
					public string baseUrl;

					/// <summary>
					/// A map of resource locations keyed by a corresponding module ID prefix. When a module is to be loaded, the longest key in <code>paths</code> is searched that is a prefix of the module ID. The module will be loaded from the concatenation of the corresponding value in <code>paths</code> and the remainder of the module ID (after the prefix). If no entry in <code>paths</code> matches, then the module will be loaded from the <code>baseUrl</code>.
					/// 
					/// The prefixes (keys) must not contain relative segments (./ or ../), a trailing slash will be removed, and only full name segment matches are considered a match (prefix 'sap/m' does not match a module ID 'sap/main').
					/// 
					/// <b>Note</b>: In contrast to the "Common Config" of the AMD spec, the paths (values in the map) are interpreted relative to <code>document.baseURI</code>, not relative to <code>cfg.baseUrl</code>.
					/// </summary>
					public Map<string> paths;

					/// <summary>
					/// A map of maps that defines how to map module IDs to other module IDs (inner maps) in the context of a specific set of modules (keys of outer map).
					/// 
					/// Each key of the outer map represents a module ID prefix that describes the context for which its value (inner map) has to be used. The special key <code>*</code> describes the default context which applies for any module. Only the most specific matching context will be taken into account.
					/// 
					/// Each inner map maps a module ID or module ID prefix to another module ID or module ID prefix. Again, only the most specific match is taken into account and only one mapping is evaluated (the evaluation of the mappings is not done recursively).
					/// 
					/// Matches are always complete matches, a prefix 'a/b/c' does not match the module ID 'a/b/com'.
					/// </summary>
					public Map<Map<string>> map;

					/// <summary>
					/// Defines additional metadata for modules for which the normal behavior of the AMD APIs is not sufficient.
					/// 
					/// A typical example are scripts that don't use <code>define</code> or <code>sap.ui.define</code>, but export to a global name. With the <code>exports</code> property, one or more export names can be specified, and the loader can retrieve the exported value after executing the corresponding module. If such a module has dependencies, they can be specified in the <code>deps</code> array and are loaded and executed before executing the module.
					/// 
					/// The <code>amd</code> flag of a shim is a ui5loader-specific extension of the standard AMD shims. If set, the ui5loader hides a currently active AMD loader before executing the module and restores it afterwards. Otherwise, it might miss the export of third party modules that check for an AMD loader and register with it instead of exporting to a global name. A future version of the ui5loader might ignore this flag when it acts as an AMD loader by itself.
					/// 
					/// <b>Note:</b> The ui5loader does not support the <code>init</code> option described by the "Common Config" section of the AMD spec.
					/// </summary>
					public Map<object> shim;

					/// <summary>
					/// When set to true, <code>sap.ui.require</code> loads modules asynchronously via script tags and <code>sap.ui.define</code> executes asynchronously.
					/// 
					/// <b>Note:</b> Switching back from async to sync is not supported and trying to do so will throw an <code>Error</code>
					/// </summary>
					public bool async;

					/// <summary>
					/// When set to true, the ui5loader will overwrite the global properties <code>define</code> and <code>require</code> with its own implementations. Any previously active AMD loader will be remembered internally and can be restored by setting <code>amd</code> to false again.
					/// 
					/// <b>Note:</b> Switching to the <code>amd</code> mode, the ui5loader will set <code>async</code> to true implicitly for activating asynchronous loading. Once the loading behaviour has been defined to be asynchronous, it can not be changed to synchronous behaviour again, also not via setting <code>amd</code> to false.
					/// </summary>
					public bool amd;

				}

				#endregion

				#region Methods

				/// <summary>
				/// Sets the configuration for the UI5 loader. The configuration can be updated multiple times. Later changes do not impact modules that have been loaded before.
				/// 
				/// If no parameter is given, a partial copy of UI5 loader configuration in use is returned.
				/// 
				/// The configuration options are aligned with the "Common Config" draft of the AMD spec (https://github.com/amdjs/amdjs-api/blob/master/CommonConfig.md).
				/// 
				/// The following code shows an example of what a UI5 loader configuration might look like: <pre>
				/// 
				///   sap.ui.loader.config({
				/// 
				///     // location from where to load all modules by default
				///     baseUrl: '../../resources/',
				/// 
				///     paths: {
				///       // load modules whose ID equals to or starts with 'my/module' from example.com
				///       'my/module': 'https://example.com/resources/my/module'
				///     },
				/// 
				///     map: {
				///       // if any module requires 'sinon', load module 'sap/ui/thirdparty/sinon-4'
				///       '*': {
				///         'sinon': 'sap/ui/thirdparty/sinon-4'
				///       },
				///       // but if a module whose ID equals to or starts with 'app' requires 'sinon'
				///       // then load a legacy version instead
				///       "app": {
				///         'sinon': 'sap/ui/legacy/sinon'
				///       }
				///     },
				/// 
				///     // activate real async loading and module definitions
				///     async: true,
				/// 
				///     // provide dependency and export metadata for non-UI5 modules
				///     shim: {
				///       'sap/ui/thirdparty/blanket': {
				///         amd: true,
				///         exports: 'blanket'
				///       }
				///     }
				/// 
				///   });
				/// 
				/// </pre>
				/// </summary>
				/// <param name="cfg">The provided configuration gets merged with the UI5 loader configuration in use. If <code>cfg</code> is omitted or <code>undefined</code>, a copy of the current configuration gets returned, containing at least the properties <code>amd</code> and <code>async</code>.</param>
				/// <returns>UI5 loader configuration in use.</returns>
				public extern static object config(sap.ui.loader.ConfigInfo cfg);

				/// <summary>
				/// Sets the configuration for the UI5 loader. The configuration can be updated multiple times. Later changes do not impact modules that have been loaded before.
				/// 
				/// If no parameter is given, a partial copy of UI5 loader configuration in use is returned.
				/// 
				/// The configuration options are aligned with the "Common Config" draft of the AMD spec (https://github.com/amdjs/amdjs-api/blob/master/CommonConfig.md).
				/// 
				/// The following code shows an example of what a UI5 loader configuration might look like: <pre>
				/// 
				///   sap.ui.loader.config({
				/// 
				///     // location from where to load all modules by default
				///     baseUrl: '../../resources/',
				/// 
				///     paths: {
				///       // load modules whose ID equals to or starts with 'my/module' from example.com
				///       'my/module': 'https://example.com/resources/my/module'
				///     },
				/// 
				///     map: {
				///       // if any module requires 'sinon', load module 'sap/ui/thirdparty/sinon-4'
				///       '*': {
				///         'sinon': 'sap/ui/thirdparty/sinon-4'
				///       },
				///       // but if a module whose ID equals to or starts with 'app' requires 'sinon'
				///       // then load a legacy version instead
				///       "app": {
				///         'sinon': 'sap/ui/legacy/sinon'
				///       }
				///     },
				/// 
				///     // activate real async loading and module definitions
				///     async: true,
				/// 
				///     // provide dependency and export metadata for non-UI5 modules
				///     shim: {
				///       'sap/ui/thirdparty/blanket': {
				///         amd: true,
				///         exports: 'blanket'
				///       }
				///     }
				/// 
				///   });
				/// 
				/// </pre>
				/// </summary>
				/// <returns>UI5 loader configuration in use.</returns>
				public extern static object config();

				#endregion

			}
		}
	}
}
