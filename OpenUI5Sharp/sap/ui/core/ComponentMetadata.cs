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
				[External]
				[Namespace(false)]
				[Name("sap.ui.core.ComponentMetadata")]
				public partial class ComponentMetadata
				{
					#region Constructor

					/// <summary>
					/// Creates a new metadata object for a Component subclass.
					/// </summary>
					/// <param name="sClassName">Fully qualified name of the class that is described by this metadata object</param>
					/// <param name="oStaticInfo">Static info to construct the metadata from</param>
					public extern ComponentMetadata(string sClassName, object oStaticInfo);

					#endregion

					#region Methods

					/// <summary>
					/// Applies the given manifest json to the ComponentMetadata instance if there isn't already a manifest.
					/// 
					/// This method is called from - {@link #applySettings} in case there is a manifest object given from the metadata - {@link #getManifestObject} after lazy loading the manifest (sync request) - {@link sap.ui.component} / {@link sap.ui.component.load} with an existing manifest to prevent the sync request
					/// </summary>
					/// <param name="oManifestJson">manifest object (will be modified internally!)</param>
					private extern void _applyManifest(object oManifestJson);

					/// <summary>
					/// Returns the name of the Component (which is the namespace only with the module name)
					/// </summary>
					/// <returns>Component name</returns>
					public extern virtual string getComponentName();

					/// <summary>
					/// Returns array of components specified in the metadata of the Component. If not specified or the array is empty, the return value is null. <p> <b>Important:</b></br> If a Component is loaded using the manifest URL (or according the "manifest first" strategy), this function ignores the entries of the manifest file! It returns only the entries which have been defined in the Component metadata or in the proper Component manifest.
					/// </summary>
					/// <returns>Required Components.</returns>
					[Obsolete("Deprecated since 1.27.1. Please use {@link sap.ui.core.Component#getManifestEntry}('/sap.ui5/dependencies/components')")]
					public extern virtual string[] getComponents();

					/// <summary>
					/// Returns a copy of the configuration property to disallow modifications. If no key is specified it returns the complete configuration property
					/// </summary>
					/// <param name="sKey">Key of the configuration property</param>
					/// <param name="bDoNotMerge">If set to <code>true</code>, only the local configuration is returned</param>
					/// <returns>the value of the configuration property</returns>
					[Obsolete("Deprecated since 1.27.1. Please use {@link sap.ui.core.Component#getManifestEntry}('/sap.ui5/config')")]
					public extern virtual object getConfig(string sKey, bool bDoNotMerge);

					/// <summary>
					/// Returns a copy of the configuration property to disallow modifications. If no key is specified it returns the complete configuration property
					/// </summary>
					/// <param name="sKey">Key of the configuration property</param>
					/// <returns>the value of the configuration property</returns>
					[Obsolete("Deprecated since 1.27.1. Please use {@link sap.ui.core.Component#getManifestEntry}('/sap.ui5/config')")]
					public extern virtual object getConfig(string sKey);

					/// <summary>
					/// Returns a copy of the configuration property to disallow modifications. If no key is specified it returns the complete configuration property
					/// </summary>
					/// <returns>the value of the configuration property</returns>
					[Obsolete("Deprecated since 1.27.1. Please use {@link sap.ui.core.Component#getManifestEntry}('/sap.ui5/config')")]
					public extern virtual object getConfig();

					/// <summary>
					/// Returns a copy of the configuration property to disallow modifications. If no key is specified it returns the complete configuration property
					/// </summary>
					/// <param name="bDoNotMerge">If set to <code>true</code>, only the local configuration is returned</param>
					/// <returns>the value of the configuration property</returns>
					[Obsolete("Deprecated since 1.27.1. Please use {@link sap.ui.core.Component#getManifestEntry}('/sap.ui5/config')")]
					public extern virtual object getConfig(bool bDoNotMerge);

					/// <summary>
					/// Returns the custom Component configuration entry with the specified key (this must be a JSON object). If no key is specified, the return value is null.
					/// 
					/// Example: <code> sap.ui.core.Component.extend("sample.Component", { metadata: { "my.custom.config" : { "property1" : true, "property2" : "Something else" } } }); </code>
					/// 
					/// The configuration above can be accessed via <code>sample.Component.getMetadata().getCustomEntry("my.custom.config")</code>.
					/// </summary>
					/// <param name="sKey">Key of the custom configuration (must be prefixed with a namespace)</param>
					/// <param name="bMerged">Indicates whether the custom configuration is merged with the parent custom configuration of the Component.</param>
					/// <returns>custom Component configuration with the specified key.</returns>
					[Obsolete("Deprecated since 1.27.1. Please use the sap.ui.core.ComponentMetadata#getManifestEntry")]
					public extern virtual object getCustomEntry(string sKey, bool bMerged);

					/// <summary>
					/// Returns the dependencies defined in the metadata of the Component. If not specified, the return value is null. <p> <b>Important:</b></br> If a Component is loaded using the manifest URL (or according the "manifest first" strategy), this function ignores the entries of the manifest file! It returns only the entries which have been defined in the Component metadata or in the proper Component manifest.
					/// </summary>
					/// <returns>Component dependencies.</returns>
					[Obsolete("Deprecated since 1.27.1. Please use {@link sap.ui.core.Component#getManifestEntry}('/sap.ui5/dependencies')")]
					public extern virtual object getDependencies();

					/// <summary>
					/// Returns the array of the included files that the Component requires such as CSS and JavaScript. If not specified or the array is empty, the return value is null. <p> <b>Important:</b></br> If a Component is loaded using the manifest URL (or according the "manifest first" strategy), this function ignores the entries of the manifest file! It returns only the entries which have been defined in the Component metadata or in the proper Component manifest.
					/// </summary>
					/// <returns>Included files.</returns>
					[Obsolete("Deprecated since 1.27.1. Please use {@link sap.ui.core.Component#getManifestEntry}('/sap.ui5/resources')")]
					public extern virtual string[] getIncludes();

					/// <summary>
					/// Returns array of libraries specified in metadata of the Component, that are automatically loaded when an instance of the component is created. If not specified or the array is empty, the return value is null. <p> <b>Important:</b></br> If a Component is loaded using the manifest URL (or according the "manifest first" strategy), this function ignores the entries of the manifest file! It returns only the entries which have been defined in the Component metadata or in the proper Component manifest.
					/// </summary>
					/// <returns>Required libraries.</returns>
					[Obsolete("Deprecated since 1.27.1. Please use {@link sap.ui.core.Component#getManifestEntry}('/sap.ui5/dependencies/libs')")]
					public extern virtual string[] getLibs();

					/// <summary>
					/// Returns the manifest defined in the metadata of the Component. If not specified, the return value is null.
					/// </summary>
					/// <returns>manifest.</returns>
					[Obsolete("Deprecated since 1.33.0. Please use the sap.ui.core.Component#getManifest")]
					public extern virtual object getManifest();

					/// <summary>
					/// Returns the configuration of a manifest section or the value for a specific path. If no section or key is specified, the return value is null.
					/// 
					/// Example: <code> { "sap.ui5": { "dependencies": { "libs": { "sap.m": {} }, "components": { "my.component.a": {} } } }); </code>
					/// 
					/// The configuration above can be accessed in the following ways: <ul> <li><b>By section/namespace</b>: <code>oComponent.getMetadata().getManifestEntry("sap.ui5")</code></li> <li><b>By path</b>: <code>oComponent.getMetadata().getManifestEntry("/sap.ui5/dependencies/libs")</code></li> </ul>
					/// 
					/// By section/namespace returns the configuration for the specified manifest section and by path allows to specify a concrete path to a dedicated entry inside the manifest. The path syntax always starts with a slash (/).
					/// </summary>
					/// <param name="sKey">Either the manifest section name (namespace) or a concrete path</param>
					/// <param name="bMerged">Indicates whether the custom configuration is merged with the parent custom configuration of the Component.</param>
					/// <returns>Value of the manifest section or the key (could be any kind of value)</returns>
					[Obsolete("Deprecated since 1.33.0. Please use the sap.ui.core.Component#getManifest")]
					public extern virtual object getManifestEntry(string sKey, bool bMerged);

					/// <summary>
					/// Returns the configuration of a manifest section or the value for a specific path. If no section or key is specified, the return value is null.
					/// 
					/// Example: <code> { "sap.ui5": { "dependencies": { "libs": { "sap.m": {} }, "components": { "my.component.a": {} } } }); </code>
					/// 
					/// The configuration above can be accessed in the following ways: <ul> <li><b>By section/namespace</b>: <code>oComponent.getMetadata().getManifestEntry("sap.ui5")</code></li> <li><b>By path</b>: <code>oComponent.getMetadata().getManifestEntry("/sap.ui5/dependencies/libs")</code></li> </ul>
					/// 
					/// By section/namespace returns the configuration for the specified manifest section and by path allows to specify a concrete path to a dedicated entry inside the manifest. The path syntax always starts with a slash (/).
					/// </summary>
					/// <param name="sKey">Either the manifest section name (namespace) or a concrete path</param>
					/// <returns>Value of the manifest section or the key (could be any kind of value)</returns>
					[Obsolete("Deprecated since 1.33.0. Please use the sap.ui.core.Component#getManifest")]
					public extern virtual object getManifestEntry(string sKey);

					/// <summary>
					/// Returns the manifest object.
					/// </summary>
					/// <returns>manifest.</returns>
					public extern virtual sap.ui.core.Manifest getManifestObject();

					/// <summary>
					/// Returns the version of the metadata which could be 1 or 2. 1 is for legacy metadata whereas 2 is for the manifest.
					/// </summary>
					/// <returns>metadata version (1: legacy metadata, 2: manifest)</returns>
					public extern virtual int getMetadataVersion();

					/// <summary>
					/// Returns the raw manifest defined in the metadata of the Component. If not specified, the return value is null.
					/// </summary>
					/// <returns>manifest</returns>
					[Obsolete("Deprecated since 1.33.0. Please use the sap.ui.core.Component#getManifest")]
					public extern virtual object getRawManifest();

					/// <summary>
					/// Returns the required version of SAPUI5 defined in the metadata of the Component. If returned value is null, then no special UI5 version is required. <p> <b>Important:</b></br> If a Component is loaded using the manifest URL (or according the "manifest first" strategy), this function ignores the entries of the manifest file! It returns only the entries which have been defined in the Component metadata or in the proper Component manifest.
					/// </summary>
					/// <returns>Required version of UI5 or if not specified then null.</returns>
					[Obsolete("Deprecated since 1.27.1. Please use {@link sap.ui.core.Component#getManifestEntry}('/sap.ui5/dependencies/minUI5Version')")]
					public extern virtual string getUI5Version();

					/// <summary>
					/// Returns the version of the component. If not specified, the return value is null. <p> <b>Important:</b></br> If a Component is loaded using the manifest URL (or according the "manifest first" strategy), this function ignores the entries of the manifest file! It returns only the entries which have been defined in the Component metadata or in the proper Component manifest.
					/// </summary>
					/// <returns>The version of the component.</returns>
					[Obsolete("Deprecated since 1.34.2. Please use {@link sap.ui.core.Component#getManifestEntry}('/sap.app/applicationVersion/version')")]
					public extern virtual string getVersion();

					/// <summary>
					/// Returns whether the class of this metadata is a component base class or not.
					/// </summary>
					/// <returns>true if it is sap.ui.core.Component or sap.ui.core.UIComponent</returns>
					public extern virtual bool isBaseClass();

					#endregion

				}
			}
		}
	}
}
