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
				/// The Manifest class.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.core.Manifest")]
				public partial class Manifest : sap.ui.@base.Object
				{
					#region Typed Parameters

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class ManifestOptions
					{
						/// <summary>
						/// (optional) the name of the component
						/// </summary>
						public string componentName;

						/// <summary>
						/// (optional) the base URL which is used to resolve relative URLs against
						/// </summary>
						public string baseUrl;

						/// <summary>
						/// (optional) Flag whether the manifest object should be processed or not which means that the placeholders will be replaced with resource bundle values
						/// </summary>
						public bool process;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Creates and initializes a manifest wrapper which provides API access to the content of the manifest.
					/// </summary>
					/// <param name="oManifest">the manifest object</param>
					/// <param name="mOptions">(optional) the configuration options</param>
					public extern Manifest(object oManifest, sap.ui.core.Manifest.ManifestOptions mOptions);

					/// <summary>
					/// Creates and initializes a manifest wrapper which provides API access to the content of the manifest.
					/// </summary>
					/// <param name="oManifest">the manifest object</param>
					public extern Manifest(object oManifest);

					#endregion

					#region Methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.Manifest with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.Manifest with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.Manifest with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns the Component name which is defined in the manifest as <code>sap.ui5/componentName</code> or <code>sap.app/id</code>
					/// </summary>
					/// <returns>the component name</returns>
					public extern virtual string getComponentName();

					/// <summary>
					/// Returns the configuration of a manifest section or the value for a specific path. If no key is specified, the return value is null.
					/// 
					/// Example: <code> { "sap.ui5": { "dependencies": { "libs": { "sap.m": {} }, "components": { "my.component.a": {} } } }); </code>
					/// 
					/// The configuration above can be accessed in the following ways: <ul> <li><b>By section/namespace</b>: <code>oManifest.getEntry("sap.ui5")</code></li> <li><b>By path</b>: <code>oManifest.getEntry("/sap.ui5/dependencies/libs")</code></li> </ul>
					/// 
					/// By section/namespace returns the configuration for the specified manifest section and by path allows to specify a concrete path to a dedicated entry inside the manifest. The path syntax always starts with a slash (/).
					/// </summary>
					/// <param name="sKey">Either the manifest section name (namespace) or a concrete path</param>
					/// <returns>Value of the key (could be any kind of value)</returns>
					public extern virtual object getEntry(string sKey);

					/// <summary>
					/// Returns the manifest defined in the metadata of the component. If not specified, the return value is null.
					/// </summary>
					/// <returns>manifest.</returns>
					public extern virtual object getJson();

					/// <summary>
					/// Returns a metadata object for class sap.ui.core.Manifest.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					[Name("getMetadata")]
					public extern static sap.ui.@base.Metadata getMetadataStatic();

					/// <summary>
					/// Returns the raw manifest defined in the metadata of the component. If not specified, the return value is null.
					/// </summary>
					/// <returns>manifest</returns>
					public extern virtual object getRawJson();

					/// <summary>
					/// Function to load the manifest by URL
					/// </summary>
					/// <param name="mOptions">the configuration options</param>
					/// <returns>Manifest object or for asynchronous calls an ECMA Script 6 Promise object will be returned.</returns>
					public extern static Union<sap.ui.core.Manifest, es5.Promise<object>> load(object mOptions);

					#endregion

				}
			}
		}
	}
}
