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
			public static partial class model
			{
				public static partial class resource
				{
					/// <summary>
					/// Model implementation for resource bundles
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.model.resource.ResourceModel")]
					public partial class ResourceModel : sap.ui.model.Model
					{
						#region Typed Parameters

						/// <summary>
						/// Parameter to be used as Object Literal
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class ResourceModelInfo
						{
							/// <summary>
							/// the URL to the base .properties file of a bundle (.properties file without any locale information, e.g. "mybundle.properties")
							/// </summary>
							public string bundleUrl;

							/// <summary>
							/// the UI5 module name of the .properties file; this name will be resolved to a path like the paths of normal UI5 modules and ".properties" will then be appended (e.g. a name like "myBundle" can be given)
							/// </summary>
							public string bundleName;

							/// <summary>
							/// an optional locale; when not given, the default is the active locale from the UI5 configuration
							/// </summary>
							public string bundleLocale;

							/// <summary>
							/// an optional resource bundle; when given, the ResourceModel uses this bundle instead of creating another bundle using the provided bundleUrl, bundleName and bundleLocale. To support reloading the bundle when the locale changes it is required to also provide the corresponding bundleName or bundleUrl. Otherwise the bundle isn't updated if only the bundle option is given.
							/// </summary>
							public string bundle;

							/// <summary>
							/// whether the language bundle should be loaded asynchronously
							/// </summary>
							public bool async;

							/// <summary>
							/// optional parameter to provide a list of additional resource bundle configurations to enhance the ResourceModel with
							/// </summary>
							public object[] enhanceWith;

						}

						/// <summary>
						/// Parameter to be used as Object Literal
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class EnhanceInfo
						{
							/// <summary>
							/// the URL to the base .properties file of a bundle (.properties file without any locale information, e.g. "mybundle.properties")
							/// </summary>
							public string bundleUrl;

							/// <summary>
							/// the UI5 module name of the .properties file; this name will be resolved to a path like the paths of normal UI5 modules and ".properties" will then be appended (e.g. a name like "myBundle" can be given)
							/// </summary>
							public string bundleName;

							/// <summary>
							/// an optional locale; when not given, the default is the active locale from the UI5 configuration
							/// </summary>
							public string bundleLocale;

						}

						#endregion

						#region Constructor

						/// <summary>
						/// Constructor for a new ResourceModel.
						/// </summary>
						/// <param name="oData">parameters used to initialize the ResourceModel; at least either bundle, bundleName or bundleUrl must be set on this object; if more than one is set, they will be used in the mentioned order</param>
						public extern ResourceModel(sap.ui.model.resource.ResourceModel.ResourceModelInfo oData);

						#endregion

						#region Methods

						/// <summary>
						/// Enhances the resource model with a custom resource bundle. The resource model can be enhanced with multiple resource bundles. The last enhanced resource bundle wins against the previous ones and the original ones. This function can be called several times.
						/// </summary>
						/// <param name="oData">parameters used to initialize the ResourceModel; at least either bundleUrl or bundleName must be set on this object; if both are set, bundleName wins - or an instance of an existing {@link jQuery.sap.util.ResourceBundle}</param>
						/// <returns>Promise in async case (async ResourceModel) which is resolved when the enhancement is finished</returns>
						public extern virtual es5.Promise<object> enhance(Union<sap.ui.model.resource.ResourceModel.EnhanceInfo, jQuery.sap.util.ResourceBundle> oData);

						/// <summary>
						/// Creates a new subclass of class sap.ui.model.resource.ResourceModel with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.Model.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.model.resource.ResourceModel with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.Model.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.model.resource.ResourceModel with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.Model.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns a metadata object for class sap.ui.model.resource.ResourceModel.
						/// </summary>
						/// <returns>Metadata object describing this class</returns>
						[Name("getMetadata")]
						public extern static sap.ui.@base.Metadata getMetadataStatic();

						/// <summary>
						/// Returns the value for the property with the given <code>sPropertyName</code>
						/// </summary>
						/// <param name="sPath">the path to the property</param>
						/// <returns>the value of the property</returns>
						public extern virtual string getProperty(string sPath);

						/// <summary>
						/// Returns the resource bundle of this model
						/// </summary>
						/// <returns>loaded resource bundle or ECMA Script 6 Promise in asynchronous case</returns>
						public extern virtual Union<jQuery.sap.util.ResourceBundle, es5.Promise<object>> getResourceBundle();

						#endregion

					}
				}
			}
		}
	}
}
