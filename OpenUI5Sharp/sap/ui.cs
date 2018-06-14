using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace OpenUI5Sharp
{
	public partial class sap
	{
		/// <summary>
		/// The <code>sap.ui</code> namespace is the central OpenAjax compliant entry point for UI related JavaScript functionality provided by SAP.
		/// </summary>
		[External]
		[Namespace(false)]
		public static partial class ui
		{
			#region Typed Parameters

			/// <summary>
			/// Parameter to be used as Object Literal
			/// </summary>
			[External]
			[ObjectLiteral]
			public partial class ComponentConfig
			{
				/// <summary>
				/// Name of the Component to load, as a dot-separated name; Even when an alternate location is specified from which the manifest should be loaded (e.g. <code>vConfig.manifest</code> is set to a non-empty string), then the name specified in that manifest will be ignored and this name will be used instead to determine the module to be loaded.
				/// </summary>
				public string name;

				/// <summary>
				/// Alternate location from where to load the Component. If a <code>manifestUrl</code> is given, this URL specifies the location of the final component defined via that manifest, otherwise it specifies the location of the component defined via its name <code>vConfig.name</code>.
				/// </summary>
				public string url;

				/// <summary>
				/// Initial data of the Component (@see sap.ui.core.Component#getComponentData)
				/// </summary>
				public object componentData;

				/// <summary>
				/// sId of the new Component
				/// </summary>
				public string id;

				/// <summary>
				/// Settings of the new Component
				/// </summary>
				public object settings;

				/// <summary>
				/// Indicates whether the Component creation should be done asynchronously; defaults to true when using the manifest property with a truthy value otherwise the default is false (experimental setting)
				/// </summary>
				public bool async;

				/// <summary>
				/// Hints for the asynchronous loading (experimental setting)
				/// </summary>
				public sap.ui.ComponentAsyncHintsInfo asyncHints;

				/// <summary>
				/// @since 1.49.0 Controls when and from where to load the manifest for the Component. When set to any truthy value, the manifest will be loaded asynchronously by default and evaluated before the Component controller, if it is set to a falsy value other than <code>undefined</code>, the manifest will be loaded after the controller. A non-empty string value will be interpreted as the URL location from where to load the manifest. A non-null object value will be interpreted as manifest content. Setting this property to a value other than <code>undefined</code>, completely deactivates the properties <code>manifestUrl</code> and <code>manifestFirst</code>, no matter what their values are.
				/// </summary>
				public Union<bool, string, object> manifest;

				/// <summary>
				/// @since 1.33.0 Specifies the URL from where the manifest should be loaded from Using this property implies <code>vConfig.manifestFirst=true</code>. <br/><b>DEPRECATED since 1.49.0, use <code>vConfig.manifest=url</code> instead!</b>. Note that this property is ignored when <code>vConfig.manifest</code> has a value other than <code>undefined</code>.
				/// </summary>
				public string manifestUrl;

				/// <summary>
				/// @since 1.33.0 defines whether the manifest is loaded before or after the Component controller. Defaults to <code>sap.ui.getCore().getConfiguration().getManifestFirst()</code> <br/><b>DEPRECATED since 1.49.0, use <code>vConfig.manifest=true|false</code> instead!</b> Note that this property is ignored when <code>vConfig.manifest</code> has a value other than <code>undefined</code>.
				/// </summary>
				public bool manifestFirst;

				/// <summary>
				/// If set to <code>true</code> validation of the component is handled by the <code>MessageManager</code>
				/// </summary>
				public string handleValidation;

			}

			/// <summary>
			/// Parameter to be used as Object Literal
			/// </summary>
			[External]
			[ObjectLiteral]
			public partial class ComponentAsyncHintsInfo
			{
				/// <summary>
				/// Libraries that should be (pre-)loaded before the Component (experimental setting)
				/// </summary>
				public string[] libs;

				/// <summary>
				/// Components that should be (pre-)loaded before the Component (experimental setting)
				/// </summary>
				public string[] components;

				/// <summary>
				/// @since 1.37.0 a <code>Promise</code> or and array of <code>Promise</code>s for which the Component instantiation should wait (experimental setting)
				/// </summary>
				public Union<jquery.JQueryPromise<object>, jquery.JQueryPromise<object>[]> waitFor;

			}

			/// <summary>
			/// Parameter to be used as Object Literal
			/// </summary>
			[External]
			[ObjectLiteral]
			public partial class GetVersionInfoOptions
			{
				/// <summary>
				/// name of the library (e.g. "sap.ui.core")
				/// </summary>
				public bool library;

				/// <summary>
				/// whether "sap-ui-version.json" should be loaded asynchronously
				/// </summary>
				public bool async;

				/// <summary>
				/// whether to propagate load errors or not (not relevant for async loading)
				/// </summary>
				public bool failOnError;

			}

			/// <summary>
			/// Parameter to be used as Object Literal
			/// </summary>
			[External]
			[ObjectLiteral]
			public partial class ViewInfo
			{
				/// <summary>
				/// Name of the view resource in module name notation (without suffix)
				/// </summary>
				public string viewName;

				/// <summary>
				/// string, XML document or object literal that defines the view
				/// </summary>
				public Union<string, dom.HTMLDocument, object> viewContent;

				/// <summary>
				/// Defines how the view source is loaded and rendered later on
				/// </summary>
				public bool async;

				/// <summary>
				/// Cache configuration, only for <code>async</code> views; caching gets active when this object is provided with vView.cache.keys array; keys are used to store data in the cache and for invalidation of the cache
				/// </summary>
				public sap.ui.ViewCacheInfo cache;

				/// <summary>
				/// Preprocessors configuration, see {@link sap.ui.core.mvc.View}
				/// </summary>
				public object preprocessors;

				/// <summary>
				/// Controller instance to be used for this view
				/// </summary>
				public sap.ui.core.mvc.Controller controller;

				/// <summary>
				/// specifies an ID for the View instance. If no ID is given, an ID will be generated.
				/// </summary>
				public sap.ui.core.ID id;

				/// <summary>
				/// The type can be JSON, JS, XML or HTML. All possible types are declared in the enumeration sap.ui.core.mvc.ViewType
				/// </summary>
				public sap.ui.core.mvc.ViewType type;

				/// <summary>
				/// This property contains user-specific data that is available during the whole lifecycle of the view and the controller
				/// </summary>
				public object viewData;

			}

			/// <summary>
			/// Parameter to be used as Object Literal
			/// </summary>
			[External]
			[ObjectLiteral]
			public partial class ViewCacheInfo
			{
				/// <summary>
				/// Array with strings or Promises resolving with strings
				/// </summary>
				public Union<string, jquery.JQueryPromise<object>>[] keys;

			}

			/// <summary>
			/// Parameter to be used as Object Literal
			/// </summary>
			[External]
			[ObjectLiteral]
			public partial class TemplateInfo
			{
				/// <summary>
				/// the ID of the Template / the ID of the DOM element containing the source of the Template</li>
				/// </summary>
				public string id;

				/// <summary>
				/// the DOM element containing the source of the Template</li>
				/// </summary>
				public dom.HTMLElement domref;

				/// <summary>
				/// the type of the Template</li>
				/// </summary>
				public string type;

				/// <summary>
				/// the URL to lookup the template</li> (<i>experimental!</i>)
				/// </summary>
				public string src;

				/// <summary>
				/// the fully qualified name of the control to declare</li> (<i>experimental!</i>)
				/// </summary>
				public string control;

			}

			#endregion

			#region Methods

			/// <summary>
			/// Creates a new instance of a <code>Component</code> or returns the instance of an existing <code>Component</code>.
			/// 
			/// If you want to look up an existing <code>Component</code> you can call this function with a Component ID as parameter: <pre>
			///   var oComponent = sap.ui.component(sComponentId);
			/// </pre>
			/// 
			/// To create a new instance of a component you pass a component configuration object into this function: <pre>
			///   var oComponent = sap.ui.component({
			///     name: "my.Component",
			///     url: "my/component/location",
			///     id: "myCompId1"
			///   });
			/// </pre>
			/// </summary>
			/// <param name="vConfig">ID of an existing Component or the configuration object to create the Component</param>
			/// <returns>the Component instance or a Promise in case of asynchronous loading</returns>
			public extern static Union<sap.ui.core.Component, jquery.JQueryPromise<object>> component(Union<string, sap.ui.ComponentConfig> vConfig);

			/// <summary>
			/// Defines a controller class or creates an instance of an already defined controller class.
			/// 
			/// When a name and a controller implementation object is given, a new controller class of the given name is created. The members of the implementation object will be copied into each new instance of that controller class (shallow copy). <b>Note</b>: as the members are shallow copied, controller instances will share all object values. This might or might not be what applications expect.
			/// 
			/// If only a name is given, a new instance of the named controller class is returned.
			/// </summary>
			/// <param name="sName">The controller name</param>
			/// <param name="oControllerImpl">An object literal defining the methods and properties of the controller</param>
			/// <param name="bAsync">Decides whether the controller gets loaded asynchronously or not</param>
			/// <returns>void, the new controller instance or a Promise resolving with the controller in async case</returns>
			public extern static Union<sap.ui.core.mvc.Controller, jquery.JQueryPromise<object>> controller(string sName, object oControllerImpl, bool bAsync);

			/// <summary>
			/// Creates 0..n UI5 controls from an ExtensionPoint. One control if the ExtensionPoint is e.g. filled with a View, zero for ExtensionPoints without configured extension and n controls for multi-root Fragments as extension.
			/// 
			/// In JSViews, this function allows both JSON notation in aggregation content as well as adding an extension point to an aggregation after the target control has already been instantiated. In the latter case the optional parameters oTargetControls and oTargetAggregation need to be specified.
			/// </summary>
			/// <param name="oContainer">The view or fragment containing the extension point</param>
			/// <param name="sExtName">The extensionName used to identify the extension point in the customizing</param>
			/// <param name="fnCreateDefaultContent">Optional callback function creating default content, returning an Array of controls. It is executed when there's no customizing, if not provided, no default content will be rendered.</param>
			/// <param name="oTargetControl">Optional - use this parameter to attach the extension point to a particular aggregation</param>
			/// <param name="sAggregationName">Optional - if provided along with oTargetControl, the extension point content is added to this particular aggregation at oTargetControl, if not given, but an oTargetControl is still present, the function will attempt to add the extension point to the default aggregation of oTargetControl. If no oTargetControl is provided, sAggregationName will also be ignored.</param>
			/// <returns>An array with 0..n controls created from an ExtensionPoint or if fnCreateDefaultContent is called and returns a Promise, a Promise with the controls is returned instead</returns>
			public extern static Union<sap.ui.core.Control[], jquery.JQueryPromise<object>> extensionpoint(Union<sap.ui.core.mvc.View, sap.ui.core.Fragment> oContainer, string sExtName, object fnCreateDefaultContent, sap.ui.core.Control oTargetControl, string sAggregationName);

			/// <summary>
			/// Creates 0..n UI5 controls from an ExtensionPoint. One control if the ExtensionPoint is e.g. filled with a View, zero for ExtensionPoints without configured extension and n controls for multi-root Fragments as extension.
			/// 
			/// In JSViews, this function allows both JSON notation in aggregation content as well as adding an extension point to an aggregation after the target control has already been instantiated. In the latter case the optional parameters oTargetControls and oTargetAggregation need to be specified.
			/// </summary>
			/// <param name="oContainer">The view or fragment containing the extension point</param>
			/// <param name="sExtName">The extensionName used to identify the extension point in the customizing</param>
			/// <param name="fnCreateDefaultContent">Optional callback function creating default content, returning an Array of controls. It is executed when there's no customizing, if not provided, no default content will be rendered.</param>
			/// <param name="oTargetControl">Optional - use this parameter to attach the extension point to a particular aggregation</param>
			/// <returns>An array with 0..n controls created from an ExtensionPoint or if fnCreateDefaultContent is called and returns a Promise, a Promise with the controls is returned instead</returns>
			public extern static Union<sap.ui.core.Control[], jquery.JQueryPromise<object>> extensionpoint(Union<sap.ui.core.mvc.View, sap.ui.core.Fragment> oContainer, string sExtName, object fnCreateDefaultContent, sap.ui.core.Control oTargetControl);

			/// <summary>
			/// Creates 0..n UI5 controls from an ExtensionPoint. One control if the ExtensionPoint is e.g. filled with a View, zero for ExtensionPoints without configured extension and n controls for multi-root Fragments as extension.
			/// 
			/// In JSViews, this function allows both JSON notation in aggregation content as well as adding an extension point to an aggregation after the target control has already been instantiated. In the latter case the optional parameters oTargetControls and oTargetAggregation need to be specified.
			/// </summary>
			/// <param name="oContainer">The view or fragment containing the extension point</param>
			/// <param name="sExtName">The extensionName used to identify the extension point in the customizing</param>
			/// <param name="fnCreateDefaultContent">Optional callback function creating default content, returning an Array of controls. It is executed when there's no customizing, if not provided, no default content will be rendered.</param>
			/// <returns>An array with 0..n controls created from an ExtensionPoint or if fnCreateDefaultContent is called and returns a Promise, a Promise with the controls is returned instead</returns>
			public extern static Union<sap.ui.core.Control[], jquery.JQueryPromise<object>> extensionpoint(Union<sap.ui.core.mvc.View, sap.ui.core.Fragment> oContainer, string sExtName, object fnCreateDefaultContent);

			/// <summary>
			/// Creates 0..n UI5 controls from an ExtensionPoint. One control if the ExtensionPoint is e.g. filled with a View, zero for ExtensionPoints without configured extension and n controls for multi-root Fragments as extension.
			/// 
			/// In JSViews, this function allows both JSON notation in aggregation content as well as adding an extension point to an aggregation after the target control has already been instantiated. In the latter case the optional parameters oTargetControls and oTargetAggregation need to be specified.
			/// </summary>
			/// <param name="oContainer">The view or fragment containing the extension point</param>
			/// <param name="sExtName">The extensionName used to identify the extension point in the customizing</param>
			/// <returns>An array with 0..n controls created from an ExtensionPoint or if fnCreateDefaultContent is called and returns a Promise, a Promise with the controls is returned instead</returns>
			public extern static Union<sap.ui.core.Control[], jquery.JQueryPromise<object>> extensionpoint(Union<sap.ui.core.mvc.View, sap.ui.core.Fragment> oContainer, string sExtName);

			/// <summary>
			/// Instantiate a Fragment - this method loads the Fragment content, instantiates it, and returns this content. The Fragment object itself is not an entity which has further significance beyond this constructor.
			/// 
			/// To instantiate an existing Fragment, call this method as: sap.ui.fragment(sName, sType, [oController]); The sName must correspond to an XML Fragment which can be loaded via the module system (fragmentName + suffix ".fragment.[typeextension]") and which defines the Fragment content. If oController is given, the (event handler) methods referenced in the Fragment will be called on this controller. Note that Fragments may require a Controller to be given and certain methods to be available.
			/// 
			/// The Fragment types "XML", "JS" and "HTML" are available by default; additional Fragment types can be implemented and added using the sap.ui.core.Fragment.registerType() function.
			/// 
			/// Advanced usage: To instantiate a Fragment and give further configuration options, call this method as: sap.ui.fragment(oFragmentConfig, [oController]); The oFragmentConfig object can have the following properties: - "fragmentName": the name of the Fragment, as above - "fragmentContent": the definition of the Fragment content itself. When this property is given, any given name is ignored. The type of this property depends on the Fragment type, e.g. it could be a string for XML Fragments. - "type": the type of the Fragment, as above (mandatory) - "id": the ID of the Fragment (optional) Further properties may be supported by future or custom Fragment types. Any given properties will be forwarded to the Fragment implementation.
			/// 
			/// If you want to give a fixed ID for the Fragment, please use the advanced version of this method call with the configuration object or use the typed factories like sap.ui.xmlfragment(...) or sap.ui.jsfragment(...). Otherwise the Fragment ID is generated. In any case, the Fragment ID will be used as prefix for the ID of all contained controls.
			/// </summary>
			/// <param name="sName">the Fragment name</param>
			/// <param name="sType">the Fragment type, e.g. "XML", "JS", or "HTML"</param>
			/// <param name="oController">the Controller which should be used by the controls in the Fragment. Note that some Fragments may not need a Controller and other may need one - and even rely on certain methods implemented in the Controller.</param>
			/// <returns>the root Control(s) of the Fragment content</returns>
			public extern static Union<sap.ui.core.Control, sap.ui.core.Control[]> fragment(string sName, string sType, sap.ui.core.mvc.Controller oController);

			/// <summary>
			/// Instantiate a Fragment - this method loads the Fragment content, instantiates it, and returns this content. The Fragment object itself is not an entity which has further significance beyond this constructor.
			/// 
			/// To instantiate an existing Fragment, call this method as: sap.ui.fragment(sName, sType, [oController]); The sName must correspond to an XML Fragment which can be loaded via the module system (fragmentName + suffix ".fragment.[typeextension]") and which defines the Fragment content. If oController is given, the (event handler) methods referenced in the Fragment will be called on this controller. Note that Fragments may require a Controller to be given and certain methods to be available.
			/// 
			/// The Fragment types "XML", "JS" and "HTML" are available by default; additional Fragment types can be implemented and added using the sap.ui.core.Fragment.registerType() function.
			/// 
			/// Advanced usage: To instantiate a Fragment and give further configuration options, call this method as: sap.ui.fragment(oFragmentConfig, [oController]); The oFragmentConfig object can have the following properties: - "fragmentName": the name of the Fragment, as above - "fragmentContent": the definition of the Fragment content itself. When this property is given, any given name is ignored. The type of this property depends on the Fragment type, e.g. it could be a string for XML Fragments. - "type": the type of the Fragment, as above (mandatory) - "id": the ID of the Fragment (optional) Further properties may be supported by future or custom Fragment types. Any given properties will be forwarded to the Fragment implementation.
			/// 
			/// If you want to give a fixed ID for the Fragment, please use the advanced version of this method call with the configuration object or use the typed factories like sap.ui.xmlfragment(...) or sap.ui.jsfragment(...). Otherwise the Fragment ID is generated. In any case, the Fragment ID will be used as prefix for the ID of all contained controls.
			/// </summary>
			/// <param name="sName">the Fragment name</param>
			/// <param name="sType">the Fragment type, e.g. "XML", "JS", or "HTML"</param>
			/// <returns>the root Control(s) of the Fragment content</returns>
			public extern static Union<sap.ui.core.Control, sap.ui.core.Control[]> fragment(string sName, string sType);

			/// <summary>
			/// Retrieve the {@link sap.ui.core.Core SAPUI5 Core} instance for the current window.
			/// </summary>
			/// <returns>the API of the current SAPUI5 Core instance.</returns>
			public extern static sap.ui.core.Core getCore();

			/// <summary>
			/// Loads the version info file (resources/sap-ui-version.json) and returns it or if a library name is specified then the version info of the individual library will be returned.
			/// 
			/// In case of the version info file is not available an error will occur when calling this function.
			/// </summary>
			/// <param name="mOptions">name of the library (e.g. "sap.ui.core") or an object map (see below)</param>
			/// <returns>the full version info, the library specific one, undefined (if library is not listed or there was an error and "failOnError" is set to "false") or a Promise which resolves with one of them</returns>
			public extern static Union<object, jquery.JQueryPromise<object>> getVersionInfo(Union<string, sap.ui.GetVersionInfoOptions> mOptions);

			/// <summary>
			/// Loads the version info file (resources/sap-ui-version.json) and returns it or if a library name is specified then the version info of the individual library will be returned.
			/// 
			/// In case of the version info file is not available an error will occur when calling this function.
			/// </summary>
			/// <returns>the full version info, the library specific one, undefined (if library is not listed or there was an error and "failOnError" is set to "false") or a Promise which resolves with one of them</returns>
			public extern static Union<object, jquery.JQueryPromise<object>> getVersionInfo();

			/// <summary>
			/// Instantiates an HTML-based Fragment.
			/// 
			/// To instantiate a Fragment, call this method as: sap.ui.htmlfragment([sId], sFragmentName, [oController]); The Fragment instance ID is optional and will be used as prefix for the ID of all contained controls. If no ID is passed, controls will not be prefixed. The sFragmentName must correspond to an HTML Fragment which can be loaded via the module system (fragmentName + ".fragment.html") and which defines the Fragment. If oController is given, the methods referenced in the Fragment will be called on this controller. Note that Fragments may require a Controller to be given and certain methods to be available.
			/// 
			/// Advanced usage: To instantiate a Fragment and optionally directly give the HTML definition instead of loading it from a file, call this method as: sap.ui.htmlfragment(oFragmentConfig, [oController]); The oFragmentConfig object can either have a "fragmentName" or a "fragmentContent" property. fragmentContent is optional and can hold the Fragment definition as XML string; if not given, fragmentName must be given and the Fragment content definition is loaded by the module system. Again, if oController is given, the methods referenced in the Fragment will be called on this controller.
			/// </summary>
			/// <param name="sId">id of the newly created Fragment</param>
			/// <param name="vFragment">name of the Fragment (or Fragment configuration as described above, in this case no sId may be given. Instead give the id inside the config object, if desired.)</param>
			/// <param name="oController">a Controller to be used for event handlers in the Fragment</param>
			/// <returns>the root Control(s) of the created Fragment instance</returns>
			public extern static Union<sap.ui.core.Control, sap.ui.core.Control[]> htmlfragment(string sId, Union<string, object> vFragment, sap.ui.core.mvc.Controller oController);

			/// <summary>
			/// Instantiates an HTML-based Fragment.
			/// 
			/// To instantiate a Fragment, call this method as: sap.ui.htmlfragment([sId], sFragmentName, [oController]); The Fragment instance ID is optional and will be used as prefix for the ID of all contained controls. If no ID is passed, controls will not be prefixed. The sFragmentName must correspond to an HTML Fragment which can be loaded via the module system (fragmentName + ".fragment.html") and which defines the Fragment. If oController is given, the methods referenced in the Fragment will be called on this controller. Note that Fragments may require a Controller to be given and certain methods to be available.
			/// 
			/// Advanced usage: To instantiate a Fragment and optionally directly give the HTML definition instead of loading it from a file, call this method as: sap.ui.htmlfragment(oFragmentConfig, [oController]); The oFragmentConfig object can either have a "fragmentName" or a "fragmentContent" property. fragmentContent is optional and can hold the Fragment definition as XML string; if not given, fragmentName must be given and the Fragment content definition is loaded by the module system. Again, if oController is given, the methods referenced in the Fragment will be called on this controller.
			/// </summary>
			/// <param name="sId">id of the newly created Fragment</param>
			/// <param name="vFragment">name of the Fragment (or Fragment configuration as described above, in this case no sId may be given. Instead give the id inside the config object, if desired.)</param>
			/// <returns>the root Control(s) of the created Fragment instance</returns>
			public extern static Union<sap.ui.core.Control, sap.ui.core.Control[]> htmlfragment(string sId, Union<string, object> vFragment);

			/// <summary>
			/// Instantiates an HTML-based Fragment.
			/// 
			/// To instantiate a Fragment, call this method as: sap.ui.htmlfragment([sId], sFragmentName, [oController]); The Fragment instance ID is optional and will be used as prefix for the ID of all contained controls. If no ID is passed, controls will not be prefixed. The sFragmentName must correspond to an HTML Fragment which can be loaded via the module system (fragmentName + ".fragment.html") and which defines the Fragment. If oController is given, the methods referenced in the Fragment will be called on this controller. Note that Fragments may require a Controller to be given and certain methods to be available.
			/// 
			/// Advanced usage: To instantiate a Fragment and optionally directly give the HTML definition instead of loading it from a file, call this method as: sap.ui.htmlfragment(oFragmentConfig, [oController]); The oFragmentConfig object can either have a "fragmentName" or a "fragmentContent" property. fragmentContent is optional and can hold the Fragment definition as XML string; if not given, fragmentName must be given and the Fragment content definition is loaded by the module system. Again, if oController is given, the methods referenced in the Fragment will be called on this controller.
			/// </summary>
			/// <param name="vFragment">name of the Fragment (or Fragment configuration as described above, in this case no sId may be given. Instead give the id inside the config object, if desired.)</param>
			/// <returns>the root Control(s) of the created Fragment instance</returns>
			public extern static Union<sap.ui.core.Control, sap.ui.core.Control[]> htmlfragment(Union<string, object> vFragment);

			/// <summary>
			/// Instantiates an HTML-based Fragment.
			/// 
			/// To instantiate a Fragment, call this method as: sap.ui.htmlfragment([sId], sFragmentName, [oController]); The Fragment instance ID is optional and will be used as prefix for the ID of all contained controls. If no ID is passed, controls will not be prefixed. The sFragmentName must correspond to an HTML Fragment which can be loaded via the module system (fragmentName + ".fragment.html") and which defines the Fragment. If oController is given, the methods referenced in the Fragment will be called on this controller. Note that Fragments may require a Controller to be given and certain methods to be available.
			/// 
			/// Advanced usage: To instantiate a Fragment and optionally directly give the HTML definition instead of loading it from a file, call this method as: sap.ui.htmlfragment(oFragmentConfig, [oController]); The oFragmentConfig object can either have a "fragmentName" or a "fragmentContent" property. fragmentContent is optional and can hold the Fragment definition as XML string; if not given, fragmentName must be given and the Fragment content definition is loaded by the module system. Again, if oController is given, the methods referenced in the Fragment will be called on this controller.
			/// </summary>
			/// <param name="vFragment">name of the Fragment (or Fragment configuration as described above, in this case no sId may be given. Instead give the id inside the config object, if desired.)</param>
			/// <param name="oController">a Controller to be used for event handlers in the Fragment</param>
			/// <returns>the root Control(s) of the created Fragment instance</returns>
			public extern static Union<sap.ui.core.Control, sap.ui.core.Control[]> htmlfragment(Union<string, object> vFragment, sap.ui.core.mvc.Controller oController);

			/// <summary>
			/// Defines or creates an instance of a declarative HTML view.
			/// 
			/// The behavior of this method depends on the signature of the call and on the current context.
			/// 
			/// <ul> <li>View Definition <code>sap.ui.htmlview(sId, vView)</code>: Defines a view of the given name with the given implementation. sId must be the views name, vView must be an object and can contain implementations for any of the hooks provided by HTMLView</li> <li>View Instantiation <code>sap.ui.htmlview(sId?, vView)</code>: Creates an instance of the view with the given name (and id)</li>. </ul>
			/// 
			/// Any other call signature will lead to a runtime error. If the id is omitted in the second variant, an id will be created automatically.
			/// </summary>
			/// <param name="sId">id of the newly created view, only allowed for instance creation</param>
			/// <param name="vView">Name of the view or a view configuration object as described above</param>
			/// <returns>the created HTMLView instance in the creation case, otherwise undefined</returns>
			public extern static sap.ui.core.mvc.HTMLView htmlview(string sId, Union<string, sap.ui.ViewInfo> vView);

			/// <summary>
			/// Defines or creates an instance of a declarative HTML view.
			/// 
			/// The behavior of this method depends on the signature of the call and on the current context.
			/// 
			/// <ul> <li>View Definition <code>sap.ui.htmlview(sId, vView)</code>: Defines a view of the given name with the given implementation. sId must be the views name, vView must be an object and can contain implementations for any of the hooks provided by HTMLView</li> <li>View Instantiation <code>sap.ui.htmlview(sId?, vView)</code>: Creates an instance of the view with the given name (and id)</li>. </ul>
			/// 
			/// Any other call signature will lead to a runtime error. If the id is omitted in the second variant, an id will be created automatically.
			/// </summary>
			/// <param name="vView">Name of the view or a view configuration object as described above</param>
			/// <returns>the created HTMLView instance in the creation case, otherwise undefined</returns>
			public extern static sap.ui.core.mvc.HTMLView htmlview(Union<string, sap.ui.ViewInfo> vView);

			/// <summary>
			/// Defines OR instantiates an HTML-based Fragment.
			/// 
			/// To define a JS Fragment, call this method as: sap.ui.jsfragment(sName, oFragmentDefinition) Where: - "sName" is the name by which this fragment can be found and instantiated. If defined in its own file, in order to be found by the module loading system, the file location and name must correspond to sName (path + file name must be: fragmentName + ".fragment.js"). - "oFragmentDefinition" is an object at least holding the "createContent(oController)" method which defines the Fragment content. If given during instantiation, the createContent method receives a Controller instance (otherwise oController is undefined) and the return value must be one sap.ui.core.Control (which could have any number of children).
			/// 
			/// To instantiate a JS Fragment, call this method as: sap.ui.jsfragment([sId], sFragmentName, [oController]); The Fragment ID is optional (generated if not given) and the Fragment implementation CAN use it to make contained controls unique (this depends on the implementation: some JS Fragments may choose not to support multiple instances within one application and not use the ID prefixing). The sFragmentName must correspond to a JS Fragment which can be loaded via the module system (fragmentName + ".fragment.js") and which defines the Fragment. If oController is given, the methods referenced in the Fragment will be called on this controller. Note that Fragments may require a Controller to be given and certain methods to be available.
			/// </summary>
			/// <param name="sId">id of the newly created Fragment</param>
			/// <param name="sFragmentName">name of the Fragment (or Fragment configuration as described above, in this case no sId may be given. Instead give the id inside the config object, if desired)</param>
			/// <param name="oController">a Controller to be used for event handlers in the Fragment</param>
			/// <returns>the root Control(s) of the created Fragment instance</returns>
			public extern static Union<sap.ui.core.Control, sap.ui.core.Control[]> jsfragment(string sId, Union<string, object> sFragmentName, sap.ui.core.mvc.Controller oController);

			/// <summary>
			/// Defines OR instantiates an HTML-based Fragment.
			/// 
			/// To define a JS Fragment, call this method as: sap.ui.jsfragment(sName, oFragmentDefinition) Where: - "sName" is the name by which this fragment can be found and instantiated. If defined in its own file, in order to be found by the module loading system, the file location and name must correspond to sName (path + file name must be: fragmentName + ".fragment.js"). - "oFragmentDefinition" is an object at least holding the "createContent(oController)" method which defines the Fragment content. If given during instantiation, the createContent method receives a Controller instance (otherwise oController is undefined) and the return value must be one sap.ui.core.Control (which could have any number of children).
			/// 
			/// To instantiate a JS Fragment, call this method as: sap.ui.jsfragment([sId], sFragmentName, [oController]); The Fragment ID is optional (generated if not given) and the Fragment implementation CAN use it to make contained controls unique (this depends on the implementation: some JS Fragments may choose not to support multiple instances within one application and not use the ID prefixing). The sFragmentName must correspond to a JS Fragment which can be loaded via the module system (fragmentName + ".fragment.js") and which defines the Fragment. If oController is given, the methods referenced in the Fragment will be called on this controller. Note that Fragments may require a Controller to be given and certain methods to be available.
			/// </summary>
			/// <param name="sId">id of the newly created Fragment</param>
			/// <param name="sFragmentName">name of the Fragment (or Fragment configuration as described above, in this case no sId may be given. Instead give the id inside the config object, if desired)</param>
			/// <returns>the root Control(s) of the created Fragment instance</returns>
			public extern static Union<sap.ui.core.Control, sap.ui.core.Control[]> jsfragment(string sId, Union<string, object> sFragmentName);

			/// <summary>
			/// Defines OR instantiates an HTML-based Fragment.
			/// 
			/// To define a JS Fragment, call this method as: sap.ui.jsfragment(sName, oFragmentDefinition) Where: - "sName" is the name by which this fragment can be found and instantiated. If defined in its own file, in order to be found by the module loading system, the file location and name must correspond to sName (path + file name must be: fragmentName + ".fragment.js"). - "oFragmentDefinition" is an object at least holding the "createContent(oController)" method which defines the Fragment content. If given during instantiation, the createContent method receives a Controller instance (otherwise oController is undefined) and the return value must be one sap.ui.core.Control (which could have any number of children).
			/// 
			/// To instantiate a JS Fragment, call this method as: sap.ui.jsfragment([sId], sFragmentName, [oController]); The Fragment ID is optional (generated if not given) and the Fragment implementation CAN use it to make contained controls unique (this depends on the implementation: some JS Fragments may choose not to support multiple instances within one application and not use the ID prefixing). The sFragmentName must correspond to a JS Fragment which can be loaded via the module system (fragmentName + ".fragment.js") and which defines the Fragment. If oController is given, the methods referenced in the Fragment will be called on this controller. Note that Fragments may require a Controller to be given and certain methods to be available.
			/// </summary>
			/// <param name="sFragmentName">name of the Fragment (or Fragment configuration as described above, in this case no sId may be given. Instead give the id inside the config object, if desired)</param>
			/// <returns>the root Control(s) of the created Fragment instance</returns>
			public extern static Union<sap.ui.core.Control, sap.ui.core.Control[]> jsfragment(Union<string, object> sFragmentName);

			/// <summary>
			/// Defines OR instantiates an HTML-based Fragment.
			/// 
			/// To define a JS Fragment, call this method as: sap.ui.jsfragment(sName, oFragmentDefinition) Where: - "sName" is the name by which this fragment can be found and instantiated. If defined in its own file, in order to be found by the module loading system, the file location and name must correspond to sName (path + file name must be: fragmentName + ".fragment.js"). - "oFragmentDefinition" is an object at least holding the "createContent(oController)" method which defines the Fragment content. If given during instantiation, the createContent method receives a Controller instance (otherwise oController is undefined) and the return value must be one sap.ui.core.Control (which could have any number of children).
			/// 
			/// To instantiate a JS Fragment, call this method as: sap.ui.jsfragment([sId], sFragmentName, [oController]); The Fragment ID is optional (generated if not given) and the Fragment implementation CAN use it to make contained controls unique (this depends on the implementation: some JS Fragments may choose not to support multiple instances within one application and not use the ID prefixing). The sFragmentName must correspond to a JS Fragment which can be loaded via the module system (fragmentName + ".fragment.js") and which defines the Fragment. If oController is given, the methods referenced in the Fragment will be called on this controller. Note that Fragments may require a Controller to be given and certain methods to be available.
			/// </summary>
			/// <param name="sFragmentName">name of the Fragment (or Fragment configuration as described above, in this case no sId may be given. Instead give the id inside the config object, if desired)</param>
			/// <param name="oController">a Controller to be used for event handlers in the Fragment</param>
			/// <returns>the root Control(s) of the created Fragment instance</returns>
			public extern static Union<sap.ui.core.Control, sap.ui.core.Control[]> jsfragment(Union<string, object> sFragmentName, sap.ui.core.mvc.Controller oController);

			/// <summary>
			/// Creates a JSON view of the given name and id.
			/// 
			/// The <code>viewName</code> must either correspond to a JSON module that can be loaded via the module system (viewName + suffix ".view.json") and which defines the view or it must be a configuration object for a view. The configuration object can have a viewName, viewContent and a controller property. The viewName behaves as described above, viewContent can hold the view description as JSON string or as object literal.
			/// 
			/// <strong>Note</strong>: when an object literal is given, it might be modified during view construction.
			/// 
			/// The controller property can hold a controller instance. If a controller instance is given, it overrides the controller defined in the view.
			/// 
			/// Like with any other control, an id is optional and will be created when missing.
			/// </summary>
			/// <param name="sId">id of the newly created view</param>
			/// <param name="vView">Name of the view or a view configuration object as described above</param>
			/// <returns>the created JSONView instance</returns>
			public extern static sap.ui.core.mvc.JSONView jsonview(string sId, Union<string, sap.ui.ViewInfo> vView);

			/// <summary>
			/// Creates a JSON view of the given name and id.
			/// 
			/// The <code>viewName</code> must either correspond to a JSON module that can be loaded via the module system (viewName + suffix ".view.json") and which defines the view or it must be a configuration object for a view. The configuration object can have a viewName, viewContent and a controller property. The viewName behaves as described above, viewContent can hold the view description as JSON string or as object literal.
			/// 
			/// <strong>Note</strong>: when an object literal is given, it might be modified during view construction.
			/// 
			/// The controller property can hold a controller instance. If a controller instance is given, it overrides the controller defined in the view.
			/// 
			/// Like with any other control, an id is optional and will be created when missing.
			/// </summary>
			/// <param name="vView">Name of the view or a view configuration object as described above</param>
			/// <returns>the created JSONView instance</returns>
			public extern static sap.ui.core.mvc.JSONView jsonview(Union<string, sap.ui.ViewInfo> vView);

			/// <summary>
			/// Defines or creates an instance of a JavaScript view.
			/// 
			/// The behavior of this method depends on the signature of the call and on the current context.
			/// 
			/// <h3>View Definition</h3> <pre>
			///   sap.ui.jsview(sId, vView);
			/// </pre> Defines a view of the given name with the given implementation. <code>sId</code> must be the view's name, <code>vView</code> must be an object and can contain implementations for any of the hooks provided by JSView.
			/// 
			/// <h3>View Instantiation</h3> <pre>
			///   var oView = sap.ui.jsview(vView);
			///   var oView = sap.ui.jsview(vView, bASync);
			///   var oView = sap.ui.jsview(sId, vView);
			///   var oView = sap.ui.jsview(sId, vView, bAsync);
			/// </pre> Creates an instance of the view with the given name (and id). If no view implementation has been defined for that view name, a JavaScript module with the same qualified name and with suffix <code>.view.js</code> will be loaded (required) and executed. The module should register a view definition on execution (1st. variant above).
			/// 
			/// If <code>sId</code> is omitted, an ID will be created automatically.
			/// 
			/// When <code>bAsync</code> has a truthy value, the view definition will be read asynchronously, if needed, but the (incomplete) view instance will be returned immediately.
			/// 
			/// <b>Note:</b> Any other call signature will lead to a runtime error.
			/// </summary>
			/// <param name="sId">id of the newly created view, only allowed for instance creation</param>
			/// <param name="vView">Name of the view or a view configuration object as described above</param>
			/// <param name="bAsync">defines how the view source is loaded and rendered later on (only relevant for instantiation, ignored for everything else)</param>
			/// <returns>the created JSView instance in the creation case, otherwise undefined</returns>
			public extern static sap.ui.core.mvc.JSView jsview(string sId, Union<string, sap.ui.ViewInfo> vView, bool bAsync);

			/// <summary>
			/// Defines or creates an instance of a JavaScript view.
			/// 
			/// The behavior of this method depends on the signature of the call and on the current context.
			/// 
			/// <h3>View Definition</h3> <pre>
			///   sap.ui.jsview(sId, vView);
			/// </pre> Defines a view of the given name with the given implementation. <code>sId</code> must be the view's name, <code>vView</code> must be an object and can contain implementations for any of the hooks provided by JSView.
			/// 
			/// <h3>View Instantiation</h3> <pre>
			///   var oView = sap.ui.jsview(vView);
			///   var oView = sap.ui.jsview(vView, bASync);
			///   var oView = sap.ui.jsview(sId, vView);
			///   var oView = sap.ui.jsview(sId, vView, bAsync);
			/// </pre> Creates an instance of the view with the given name (and id). If no view implementation has been defined for that view name, a JavaScript module with the same qualified name and with suffix <code>.view.js</code> will be loaded (required) and executed. The module should register a view definition on execution (1st. variant above).
			/// 
			/// If <code>sId</code> is omitted, an ID will be created automatically.
			/// 
			/// When <code>bAsync</code> has a truthy value, the view definition will be read asynchronously, if needed, but the (incomplete) view instance will be returned immediately.
			/// 
			/// <b>Note:</b> Any other call signature will lead to a runtime error.
			/// </summary>
			/// <param name="sId">id of the newly created view, only allowed for instance creation</param>
			/// <param name="vView">Name of the view or a view configuration object as described above</param>
			/// <returns>the created JSView instance in the creation case, otherwise undefined</returns>
			public extern static sap.ui.core.mvc.JSView jsview(string sId, Union<string, sap.ui.ViewInfo> vView);

			/// <summary>
			/// Defines or creates an instance of a JavaScript view.
			/// 
			/// The behavior of this method depends on the signature of the call and on the current context.
			/// 
			/// <h3>View Definition</h3> <pre>
			///   sap.ui.jsview(sId, vView);
			/// </pre> Defines a view of the given name with the given implementation. <code>sId</code> must be the view's name, <code>vView</code> must be an object and can contain implementations for any of the hooks provided by JSView.
			/// 
			/// <h3>View Instantiation</h3> <pre>
			///   var oView = sap.ui.jsview(vView);
			///   var oView = sap.ui.jsview(vView, bASync);
			///   var oView = sap.ui.jsview(sId, vView);
			///   var oView = sap.ui.jsview(sId, vView, bAsync);
			/// </pre> Creates an instance of the view with the given name (and id). If no view implementation has been defined for that view name, a JavaScript module with the same qualified name and with suffix <code>.view.js</code> will be loaded (required) and executed. The module should register a view definition on execution (1st. variant above).
			/// 
			/// If <code>sId</code> is omitted, an ID will be created automatically.
			/// 
			/// When <code>bAsync</code> has a truthy value, the view definition will be read asynchronously, if needed, but the (incomplete) view instance will be returned immediately.
			/// 
			/// <b>Note:</b> Any other call signature will lead to a runtime error.
			/// </summary>
			/// <param name="vView">Name of the view or a view configuration object as described above</param>
			/// <returns>the created JSView instance in the creation case, otherwise undefined</returns>
			public extern static sap.ui.core.mvc.JSView jsview(Union<string, sap.ui.ViewInfo> vView);

			/// <summary>
			/// Defines or creates an instance of a JavaScript view.
			/// 
			/// The behavior of this method depends on the signature of the call and on the current context.
			/// 
			/// <h3>View Definition</h3> <pre>
			///   sap.ui.jsview(sId, vView);
			/// </pre> Defines a view of the given name with the given implementation. <code>sId</code> must be the view's name, <code>vView</code> must be an object and can contain implementations for any of the hooks provided by JSView.
			/// 
			/// <h3>View Instantiation</h3> <pre>
			///   var oView = sap.ui.jsview(vView);
			///   var oView = sap.ui.jsview(vView, bASync);
			///   var oView = sap.ui.jsview(sId, vView);
			///   var oView = sap.ui.jsview(sId, vView, bAsync);
			/// </pre> Creates an instance of the view with the given name (and id). If no view implementation has been defined for that view name, a JavaScript module with the same qualified name and with suffix <code>.view.js</code> will be loaded (required) and executed. The module should register a view definition on execution (1st. variant above).
			/// 
			/// If <code>sId</code> is omitted, an ID will be created automatically.
			/// 
			/// When <code>bAsync</code> has a truthy value, the view definition will be read asynchronously, if needed, but the (incomplete) view instance will be returned immediately.
			/// 
			/// <b>Note:</b> Any other call signature will lead to a runtime error.
			/// </summary>
			/// <param name="vView">Name of the view or a view configuration object as described above</param>
			/// <param name="bAsync">defines how the view source is loaded and rendered later on (only relevant for instantiation, ignored for everything else)</param>
			/// <returns>the created JSView instance in the creation case, otherwise undefined</returns>
			public extern static sap.ui.core.mvc.JSView jsview(Union<string, sap.ui.ViewInfo> vView, bool bAsync);

			/// <summary>
			/// Creates a lazy loading stub for a given class <code>sClassName</code>.
			/// 
			/// If the class has been loaded already, nothing is done. Otherwise a stub object or constructor and - optionally - a set of stub methods are created. All created stubs will load the corresponding module on execution and then delegate to their counterpart in the loaded module.
			/// 
			/// When no methods are given or when the list of methods contains the special name "new" (which is an operator can't be used as method name in JavaScript), then a stub <b>constructor</b> for class <code>sClassName</code> is created. Otherwise, a plain object is created.
			/// 
			/// <b>Note</b>: Accessing any stub as a plain object without executing it (no matter whether it is a function or an object) won't load the module and therefore most like won't work as expected. This is a fundamental restriction of the lazy loader approach. It could only be fixed with JavaScript 1.5 features that are not available in all UI5 target browsers (e.g. not in IE8).
			/// 
			/// <b>Note</b>: As a side effect of this method, the namespace containing the given class is created <b>immediately</b>.
			/// </summary>
			/// <param name="sClassName">Fully qualified name (dot notation) of the class that should be prepared</param>
			/// <param name="sMethods">space separated list of additional (static) methods that should be created as stubs</param>
			/// <param name="sModuleName">name of the module to load, defaults to the class name</param>
			public extern static void lazyRequire(string sClassName, string sMethods, string sModuleName);

			/// <summary>
			/// Creates a lazy loading stub for a given class <code>sClassName</code>.
			/// 
			/// If the class has been loaded already, nothing is done. Otherwise a stub object or constructor and - optionally - a set of stub methods are created. All created stubs will load the corresponding module on execution and then delegate to their counterpart in the loaded module.
			/// 
			/// When no methods are given or when the list of methods contains the special name "new" (which is an operator can't be used as method name in JavaScript), then a stub <b>constructor</b> for class <code>sClassName</code> is created. Otherwise, a plain object is created.
			/// 
			/// <b>Note</b>: Accessing any stub as a plain object without executing it (no matter whether it is a function or an object) won't load the module and therefore most like won't work as expected. This is a fundamental restriction of the lazy loader approach. It could only be fixed with JavaScript 1.5 features that are not available in all UI5 target browsers (e.g. not in IE8).
			/// 
			/// <b>Note</b>: As a side effect of this method, the namespace containing the given class is created <b>immediately</b>.
			/// </summary>
			/// <param name="sClassName">Fully qualified name (dot notation) of the class that should be prepared</param>
			/// <param name="sMethods">space separated list of additional (static) methods that should be created as stubs</param>
			public extern static void lazyRequire(string sClassName, string sMethods = "new");

			/// <summary>
			/// Redirects access to resources that are part of the given namespace to a location relative to the assumed <b>application root folder</b>.
			/// 
			/// Any UI5 managed resource (view, controller, control, JavaScript module, CSS file, etc.) whose resource name starts with <code>sNamespace</code>, will be loaded from an equally named subfolder of the <b>application root folder</b>. If the resource name consists of multiple segments (separated by a dot), each segment is assumed to represent an individual folder. In other words: when a resource name is converted to a URL, any dots ('.') are converted to slashes ('/').
			/// 
			/// <b>Limitation:</b> For the time being, the <b>application root folder</b> is assumed to be the same as the folder where the current page resides in.
			/// 
			/// Usage sample: <pre>
			///   // Let UI5 know that resources, whose name starts with "com.mycompany.myapp"
			///   // should be loaded from the URL location "./com/mycompany/myapp"
			///   sap.ui.localResources("com.mycompany.myapp");
			/// 
			///   // The following call implicitly will use the mapping done by the previous line
			///   // It will load a view from ./com/mycompany/myapp/views/Main.view.xml
			///   sap.ui.view({ view : "com.mycompany.myapp.views.Main", type : sap.ui.core.mvc.ViewType.XML});
			/// </pre>
			/// 
			/// When applications need a more flexible mapping between resource names and their location, they can use {@link jQuery.sap.registerModulePath}.
			/// 
			/// It is intended to make this configuration obsolete in future releases, but for the time being, applications must call this method when they want to store resources relative to the assumed application root folder.
			/// </summary>
			/// <param name="sNamespace">Namespace prefix for which to load resources relative to the application root folder</param>
			public extern static void localResources(string sNamespace);

			/// <summary>
			/// Ensures that a given a namespace or hierarchy of nested namespaces exists in the current <code>window</code>.
			/// </summary>
			[Obsolete("Deprecated since 1.1. see {@link topic:c78c07c094e04ccfaab659378a1707c7 Creating Control and Class Modules}.")]
			/// <param name="sNamespace"></param>
			/// <returns>the innermost namespace of the hierarchy</returns>
			public extern static object @namespace(string sNamespace);

			/// <summary>
			/// Returns the URL of a resource that belongs to the given library and has the given relative location within the library. This is mainly meant for static resources like images that are inside the library. It is NOT meant for access to JavaScript modules or anything for which a different URL has been registered with jQuery.sap.registerModulePath(). For these cases use jQuery.sap.getModulePath(). It DOES work, however, when the given sResourcePath starts with "themes/" (= when it is a theme-dependent resource). Even when for this theme a different location outside the normal library location is configured.
			/// </summary>
			/// <param name="sLibraryName">the name of a library, like "sap.ui.commons"</param>
			/// <param name="sResourcePath">the relative path of a resource inside this library, like "img/mypic.png" or "themes/my_theme/img/mypic.png"</param>
			/// <returns>the URL of the requested resource</returns>
			public extern static string resource(string sLibraryName, string sResourcePath);

			/// <summary>
			/// Displays the control tree with the given root inside the area of the given DOM reference (or inside the DOM node with the given ID) or in the given Control.
			/// 
			/// Example: <pre>
			///   &lt;div id="SAPUI5UiArea">&lt;/div>
			///   &lt;script>
			///     var oRoot = new sap.ui.commons.Label();
			///     oRoot.setText("Hello world!");
			///     sap.ui.setRoot("SAPUI5UiArea", oRoot);
			///   &lt;/script>
			/// </pre> <p>
			/// 
			/// This is a shortcut for <code>sap.ui.getCore().setRoot()</code>.
			/// 
			/// Internally, if a string is given that does not identify a UIArea or a control then implicitly a new <code>UIArea</code> is created for the given DOM reference and the given control is added.
			/// </summary>
			[Obsolete("Deprecated since 1.1. use {@link sap.ui.core.Control#placeAt Control#placeAt} instead.")]
			/// <param name="oDomRef">a DOM Element or Id String of the UIArea</param>
			/// <param name="oControl">the Control that should be added to the <code>UIArea</code>.</param>
			public extern static void setRoot(Union<string, dom.HTMLElement, sap.ui.core.Control> oDomRef, Union<sap.ui.@base.Interface, sap.ui.core.Control> oControl);

			/// <summary>
			/// Creates a Template for the given ID, DOM reference or a configuration object.
			/// 
			/// If no parameter is defined, this function makes a lookup of DOM elements which are specifying a type attribute. If the value of this type attribute matches a registered type then the content of this DOM element will be used to create a new <code>Template</code> instance.
			/// 
			/// If you want to lookup all kind of existing and known templates and parse them directly you can simply call: <pre>
			///   sap.ui.template();
			/// </pre>
			/// 
			/// To parse a concrete DOM element you can do so by using this function in the following way: <pre>
			///   sap.ui.template("theTemplateId");
			/// </pre>
			/// 
			/// Or you can pass the reference to a DOM element and use this DOM element as a source for the template: <pre>
			///   sap.ui.template(oDomRef);
			/// </pre>
			/// 
			/// The last option to use this function is to pass the information via a configuration object. This configuration object can be used to pass a context for the templating framework when compiling the template: <pre>
			///   var oTemplateById = sap.ui.template({
			///     id: "theTemplateId",
			///     context: { ... }
			///   });
			/// 
			///   var oTemplateByDomRef = sap.ui.template({
			///     domref: oDomRef,
			///     context: { ... }
			///   });
			/// </pre>
			/// 
			/// It can also be used to load a template from another file: <pre>
			///   var oTemplate = sap.ui.template({
			///     id: "myTemplate",
			///     src: "myTemplate.tmpl"
			///   });
			/// 
			///   var oTemplateWithContext = sap.ui.template({
			///     id: "myTemplate",
			///     src: "myTemplate.tmpl",
			///     context: { ... }
			///   });
			/// </pre>
			/// </summary>
			/// <param name="oTemplate">the ID or the DOM reference to the template to lookup or a configuration object containing the src, type and eventually the ID of the Template.</param>
			/// <returns>the created Template instance or in case of usage without parameters any array of templates is returned</returns>
			public extern static Union<sap.ui.core.tmpl.Template, sap.ui.core.tmpl.Template[]> template(Union<string, dom.HTMLElement, sap.ui.TemplateInfo> oTemplate);

			/// <summary>
			/// Creates a Template for the given ID, DOM reference or a configuration object.
			/// 
			/// If no parameter is defined, this function makes a lookup of DOM elements which are specifying a type attribute. If the value of this type attribute matches a registered type then the content of this DOM element will be used to create a new <code>Template</code> instance.
			/// 
			/// If you want to lookup all kind of existing and known templates and parse them directly you can simply call: <pre>
			///   sap.ui.template();
			/// </pre>
			/// 
			/// To parse a concrete DOM element you can do so by using this function in the following way: <pre>
			///   sap.ui.template("theTemplateId");
			/// </pre>
			/// 
			/// Or you can pass the reference to a DOM element and use this DOM element as a source for the template: <pre>
			///   sap.ui.template(oDomRef);
			/// </pre>
			/// 
			/// The last option to use this function is to pass the information via a configuration object. This configuration object can be used to pass a context for the templating framework when compiling the template: <pre>
			///   var oTemplateById = sap.ui.template({
			///     id: "theTemplateId",
			///     context: { ... }
			///   });
			/// 
			///   var oTemplateByDomRef = sap.ui.template({
			///     domref: oDomRef,
			///     context: { ... }
			///   });
			/// </pre>
			/// 
			/// It can also be used to load a template from another file: <pre>
			///   var oTemplate = sap.ui.template({
			///     id: "myTemplate",
			///     src: "myTemplate.tmpl"
			///   });
			/// 
			///   var oTemplateWithContext = sap.ui.template({
			///     id: "myTemplate",
			///     src: "myTemplate.tmpl",
			///     context: { ... }
			///   });
			/// </pre>
			/// </summary>
			/// <returns>the created Template instance or in case of usage without parameters any array of templates is returned</returns>
			public extern static Union<sap.ui.core.tmpl.Template, sap.ui.core.tmpl.Template[]> template();

			/// <summary>
			/// Defines or creates an instance of a template view.
			/// 
			/// The behavior of this method depends on the signature of the call and on the current context.
			/// 
			/// <ul> <li>View Definition <code>sap.ui.templateview(sId, vView)</code>: Defines a view of the given name with the given implementation. sId must be the views name, vView must be an object and can contain implementations for any of the hooks provided by templateview</li> <li>View Instantiation <code>sap.ui.templateview(sId?, vView)</code>: Creates an instance of the view with the given name (and id)</li>. </ul>
			/// 
			/// Any other call signature will lead to a runtime error. If the id is omitted in the second variant, an id will be created automatically.
			/// </summary>
			/// <param name="sId">id of the newly created view, only allowed for instance creation</param>
			/// <param name="vView">name or implementation of the view.</param>
			/// <returns>the created TemplateView instance in the creation case, otherwise undefined</returns>
			public extern static sap.ui.core.mvc.TemplateView templateview(string sId, Union<string, object> vView);

			/// <summary>
			/// Defines or creates an instance of a template view.
			/// 
			/// The behavior of this method depends on the signature of the call and on the current context.
			/// 
			/// <ul> <li>View Definition <code>sap.ui.templateview(sId, vView)</code>: Defines a view of the given name with the given implementation. sId must be the views name, vView must be an object and can contain implementations for any of the hooks provided by templateview</li> <li>View Instantiation <code>sap.ui.templateview(sId?, vView)</code>: Creates an instance of the view with the given name (and id)</li>. </ul>
			/// 
			/// Any other call signature will lead to a runtime error. If the id is omitted in the second variant, an id will be created automatically.
			/// </summary>
			/// <param name="vView">name or implementation of the view.</param>
			/// <returns>the created TemplateView instance in the creation case, otherwise undefined</returns>
			public extern static sap.ui.core.mvc.TemplateView templateview(Union<string, object> vView);

			/// <summary>
			/// Creates a view of the given type, name and with the given id.
			/// 
			/// The <code>vView</code> configuration object can have the following properties for the view instantiation: <ul> <li>The ID <code>vView.id</code> specifies an ID for the View instance. If no ID is given, an ID will be generated.</li> <li>The view name <code>vView.viewName</code> corresponds to an XML module that can be loaded via the module system (vView.viewName + suffix ".view.xml")</li> <li>The controller instance <code>vView.controller</code> must be a valid controller implementation. The given controller instance overrides the controller defined in the view definition</li> <li>The view type <code>vView.type</code> specifies what kind of view will be instantiated. All valid view types are listed in the enumeration sap.ui.core.mvc.ViewType.</li> <li>The view data <code>vView.viewData</code> can hold user specific data. This data is available during the whole lifecycle of the view and the controller</li> <li>The view loading mode <code>vView.async</code> must be a boolean and defines if the view source is loaded synchronously or asynchronously. In async mode, the view is rendered empty initially, and re-rendered with the loaded view content.</li> <li><code>vView.preprocessors</code></li> can hold a map from the specified preprocessor type (e.g. "xml") to an array of preprocessor configurations; each configuration consists of a <code>preprocessor</code> property (optional when registered as on-demand preprocessor) and may contain further preprocessor-specific settings. The preprocessor can be either a module name as string implementation of {@link sap.ui.core.mvc.View.Preprocessor} or a function according to {@link sap.ui.core.mvc.View.Preprocessor.process}. Do not set properties starting with underscore like <code>_sProperty</code> property, these are reserved for internal purposes. When several preprocessors are provided for one hook, it has to be made sure that they do not conflict when being processed serially.
			/// 
			/// <strong>Note</strong>: These preprocessors are only available to this instance. For global or on-demand availability use {@link sap.ui.core.mvc.XMLView.registerPreprocessor}.
			/// 
			/// <strong>Note</strong>: Please note that preprocessors in general are currently only available to XMLViews.
			/// 
			/// <strong>Note</strong>: Preprocessors only work in async views and will be ignored when the view is instantiated in sync mode by default, as this could have unexpected side effects. You may override this behaviour by setting the bSyncSupport flag of the preprocessor to true.
			/// </summary>
			/// <param name="sId">id of the newly created view, only allowed for instance creation</param>
			/// <param name="vView">Name of the view or a view configuration object as described above</param>
			/// <returns>the created View instance</returns>
			public extern static sap.ui.core.mvc.View view(string sId, Union<string, sap.ui.ViewInfo> vView);

			/// <summary>
			/// Instantiates an XML-based Fragment.
			/// 
			/// To instantiate a Fragment, call this method as: sap.ui.xmlfragment([sId], sFragmentName, [oController]); The Fragment instance ID is optional and will be used as prefix for the ID of all contained controls. If no ID is passed, controls will not be prefixed. The sFragmentName must correspond to an XML Fragment which can be loaded via the module system (fragmentName + ".fragment.xml") and which defines the Fragment. If oController is given, the methods referenced in the Fragment will be called on this controller. Note that Fragments may require a Controller to be given and certain methods to be available.
			/// 
			/// Advanced usage: To instantiate a Fragment and optionally directly give the XML definition instead of loading it from a file, call this method as: sap.ui.xmlfragment(oFragmentConfig, [oController]); The oFragmentConfig object can either have a "fragmentName" or a "fragmentContent" property. fragmentContent is optional and can hold the Fragment definition as XML string; if not given, fragmentName must be given and the Fragment content definition is loaded by the module system. Again, if oController is given, the methods referenced in the Fragment will be called on this controller.
			/// </summary>
			/// <param name="sId">id of the newly created Fragment</param>
			/// <param name="vFragment">name of the Fragment (or Fragment configuration as described above, in this case no sId may be given. Instead give the id inside the config object, if desired)</param>
			/// <param name="oController">a Controller to be used for event handlers in the Fragment</param>
			/// <returns>the root Control(s) of the created Fragment instance</returns>
			public extern static Union<sap.ui.core.Control, sap.ui.core.Control[]> xmlfragment(string sId, Union<string, object> vFragment, sap.ui.core.mvc.Controller oController);

			/// <summary>
			/// Instantiates an XML-based Fragment.
			/// 
			/// To instantiate a Fragment, call this method as: sap.ui.xmlfragment([sId], sFragmentName, [oController]); The Fragment instance ID is optional and will be used as prefix for the ID of all contained controls. If no ID is passed, controls will not be prefixed. The sFragmentName must correspond to an XML Fragment which can be loaded via the module system (fragmentName + ".fragment.xml") and which defines the Fragment. If oController is given, the methods referenced in the Fragment will be called on this controller. Note that Fragments may require a Controller to be given and certain methods to be available.
			/// 
			/// Advanced usage: To instantiate a Fragment and optionally directly give the XML definition instead of loading it from a file, call this method as: sap.ui.xmlfragment(oFragmentConfig, [oController]); The oFragmentConfig object can either have a "fragmentName" or a "fragmentContent" property. fragmentContent is optional and can hold the Fragment definition as XML string; if not given, fragmentName must be given and the Fragment content definition is loaded by the module system. Again, if oController is given, the methods referenced in the Fragment will be called on this controller.
			/// </summary>
			/// <param name="sId">id of the newly created Fragment</param>
			/// <param name="vFragment">name of the Fragment (or Fragment configuration as described above, in this case no sId may be given. Instead give the id inside the config object, if desired)</param>
			/// <returns>the root Control(s) of the created Fragment instance</returns>
			public extern static Union<sap.ui.core.Control, sap.ui.core.Control[]> xmlfragment(string sId, Union<string, object> vFragment);

			/// <summary>
			/// Instantiates an XML-based Fragment.
			/// 
			/// To instantiate a Fragment, call this method as: sap.ui.xmlfragment([sId], sFragmentName, [oController]); The Fragment instance ID is optional and will be used as prefix for the ID of all contained controls. If no ID is passed, controls will not be prefixed. The sFragmentName must correspond to an XML Fragment which can be loaded via the module system (fragmentName + ".fragment.xml") and which defines the Fragment. If oController is given, the methods referenced in the Fragment will be called on this controller. Note that Fragments may require a Controller to be given and certain methods to be available.
			/// 
			/// Advanced usage: To instantiate a Fragment and optionally directly give the XML definition instead of loading it from a file, call this method as: sap.ui.xmlfragment(oFragmentConfig, [oController]); The oFragmentConfig object can either have a "fragmentName" or a "fragmentContent" property. fragmentContent is optional and can hold the Fragment definition as XML string; if not given, fragmentName must be given and the Fragment content definition is loaded by the module system. Again, if oController is given, the methods referenced in the Fragment will be called on this controller.
			/// </summary>
			/// <param name="vFragment">name of the Fragment (or Fragment configuration as described above, in this case no sId may be given. Instead give the id inside the config object, if desired)</param>
			/// <returns>the root Control(s) of the created Fragment instance</returns>
			public extern static Union<sap.ui.core.Control, sap.ui.core.Control[]> xmlfragment(Union<string, object> vFragment);

			/// <summary>
			/// Instantiates an XML-based Fragment.
			/// 
			/// To instantiate a Fragment, call this method as: sap.ui.xmlfragment([sId], sFragmentName, [oController]); The Fragment instance ID is optional and will be used as prefix for the ID of all contained controls. If no ID is passed, controls will not be prefixed. The sFragmentName must correspond to an XML Fragment which can be loaded via the module system (fragmentName + ".fragment.xml") and which defines the Fragment. If oController is given, the methods referenced in the Fragment will be called on this controller. Note that Fragments may require a Controller to be given and certain methods to be available.
			/// 
			/// Advanced usage: To instantiate a Fragment and optionally directly give the XML definition instead of loading it from a file, call this method as: sap.ui.xmlfragment(oFragmentConfig, [oController]); The oFragmentConfig object can either have a "fragmentName" or a "fragmentContent" property. fragmentContent is optional and can hold the Fragment definition as XML string; if not given, fragmentName must be given and the Fragment content definition is loaded by the module system. Again, if oController is given, the methods referenced in the Fragment will be called on this controller.
			/// </summary>
			/// <param name="vFragment">name of the Fragment (or Fragment configuration as described above, in this case no sId may be given. Instead give the id inside the config object, if desired)</param>
			/// <param name="oController">a Controller to be used for event handlers in the Fragment</param>
			/// <returns>the root Control(s) of the created Fragment instance</returns>
			public extern static Union<sap.ui.core.Control, sap.ui.core.Control[]> xmlfragment(Union<string, object> vFragment, sap.ui.core.mvc.Controller oController);

			/// <summary>
			/// Instantiates an XMLView of the given name and with the given ID.
			/// 
			/// The <code>viewName</code> must either correspond to an XML module that can be loaded via the module system (viewName + suffix ".view.xml") and which defines the view, or it must be a configuration object for a view. The configuration object can have a <code>viewName</code>, <code>viewContent</code> and a <code>controller </code> property. The <code>viewName</code> behaves as described above. <code>viewContent</code> is optional and can hold a view description as XML string or as already parsed XML Document. If not given, the view content definition is loaded by the module system.
			/// 
			/// <strong>Note</strong>: if a <code>Document</code> is given, it might be modified during view construction.
			/// 
			/// <strong>Note:</strong><br> On root level, you can only define content for the default aggregation, e.g. without adding the <code>&lt;content&gt;</code> tag. If you want to specify content for another aggregation of a view like <code>dependents</code>, place it in a child control's dependents aggregation or add it by using {@link sap.ui.core.mvc.XMLView#addDependent}.
			/// 
			/// <strong>Note</strong>: if you enable caching, you need to take care of the invalidation via keys. Automatic invalidation takes only place if the UI5 version or the component descriptor (manifest.json) change. This is still an experimental feature and may experience slight changes of the invalidation parameters or the cache key format.
			/// 
			/// The controller property can hold a controller instance. If a controller instance is given, it overrides the controller defined in the view.
			/// 
			/// Like with any other control, ID is optional and one will be created automatically.
			/// </summary>
			/// <param name="sId">ID of the newly created view</param>
			/// <param name="vView">Name of the view or a view configuration object as described above</param>
			/// <returns>the created XMLView instance</returns>
			public extern static sap.ui.core.mvc.XMLView xmlview(string sId, Union<string, sap.ui.ViewInfo> vView);

			/// <summary>
			/// Instantiates an XMLView of the given name and with the given ID.
			/// 
			/// The <code>viewName</code> must either correspond to an XML module that can be loaded via the module system (viewName + suffix ".view.xml") and which defines the view, or it must be a configuration object for a view. The configuration object can have a <code>viewName</code>, <code>viewContent</code> and a <code>controller </code> property. The <code>viewName</code> behaves as described above. <code>viewContent</code> is optional and can hold a view description as XML string or as already parsed XML Document. If not given, the view content definition is loaded by the module system.
			/// 
			/// <strong>Note</strong>: if a <code>Document</code> is given, it might be modified during view construction.
			/// 
			/// <strong>Note:</strong><br> On root level, you can only define content for the default aggregation, e.g. without adding the <code>&lt;content&gt;</code> tag. If you want to specify content for another aggregation of a view like <code>dependents</code>, place it in a child control's dependents aggregation or add it by using {@link sap.ui.core.mvc.XMLView#addDependent}.
			/// 
			/// <strong>Note</strong>: if you enable caching, you need to take care of the invalidation via keys. Automatic invalidation takes only place if the UI5 version or the component descriptor (manifest.json) change. This is still an experimental feature and may experience slight changes of the invalidation parameters or the cache key format.
			/// 
			/// The controller property can hold a controller instance. If a controller instance is given, it overrides the controller defined in the view.
			/// 
			/// Like with any other control, ID is optional and one will be created automatically.
			/// </summary>
			/// <param name="vView">Name of the view or a view configuration object as described above</param>
			/// <returns>the created XMLView instance</returns>
			public extern static sap.ui.core.mvc.XMLView xmlview(Union<string, sap.ui.ViewInfo> vView);

			/// <summary>
			/// Defines a Javascript module with its name, its dependencies and a module value or factory.
			/// 
			/// The typical and only suggested usage of this method is to have one single, top level call to <code>sap.ui.define</code> in one Javascript resource (file). When a module is requested by its name for the first time, the corresponding resource is determined from the name and the current {@link jQuery.sap.registerResourcePath configuration}. The resource will be loaded and executed which in turn will execute the top level <code>sap.ui.define</code> call.
			/// 
			/// If the module name was omitted from that call, it will be substituted by the name that was used to request the module. As a preparation step, the dependencies as well as their transitive dependencies, will be loaded. Then, the module value will be determined: if a static value (object, literal) was given as <code>vFactory</code>, that value will be the module value. If a function was given, that function will be called (providing the module values of the declared dependencies as parameters to the function) and its return value will be used as module value. The framework internally associates the resulting value with the module name and provides it to the original requester of the module. Whenever the module is requested again, the same value will be returned (modules are executed only once).
			/// 
			/// <i>Example:</i><br> The following example defines a module "SomeClass", but doesn't hard code the module name. If stored in a file 'sap/mylib/SomeClass.js', it can be requested as 'sap/mylib/SomeClass'. <pre>
			///   sap.ui.define(['./Helper', 'sap/m/Bar'], function(Helper,Bar) {
			/// 
			///     // create a new class
			///     var SomeClass = function() {};
			/// 
			///     // add methods to its prototype
			///     SomeClass.prototype.foo = function() {
			/// 
			///         // use a function from the dependency 'Helper' in the same package (e.g. 'sap/mylib/Helper' )
			///         var mSettings = Helper.foo();
			/// 
			///         // create and return an sap.m.Bar (using its local name 'Bar')
			///         return new Bar(mSettings);
			/// 
			///     }
			/// 
			///     // return the class as module value
			///     return SomeClass;
			/// 
			///   });
			/// </pre>
			/// 
			/// In another module or in an application HTML page, the {@link sap.ui.require} API can be used to load the Something module and to work with it:
			/// 
			/// <pre>
			/// sap.ui.require(['sap/mylib/Something'], function(Something) {
			/// 
			///   // instantiate a Something and call foo() on it
			///   new Something().foo();
			/// 
			/// });
			/// </pre>
			/// 
			/// <h3>Module Name Syntax</h3>
			/// 
			/// <code>sap.ui.define</code> uses a simplified variant of the {@link jQuery.sap.getResourcePath unified resource name} syntax for the module's own name as well as for its dependencies. The only difference to that syntax is, that for <code>sap.ui.define</code> and <code>sap.ui.require</code>, the extension (which always would be '.js') has to be omitted. Both methods always add this extension internally.
			/// 
			/// As a convenience, the name of a dependency can start with the segment './' which will be replaced by the name of the package that contains the currently defined module (relative name).
			/// 
			/// It is best practice to omit the name of the defined module (first parameter) and to use relative names for the dependencies whenever possible. This reduces the necessary configuration, simplifies renaming of packages and allows to map them to a different namespace.
			/// 
			/// <h3>Dependency to Modules</h3>
			/// 
			/// If a dependencies array is given, each entry represents the name of another module that the currently defined module depends on. All dependency modules are loaded before the value of the currently defined module is determined. The module value of each dependency module will be provided as a parameter to a factory function, the order of the parameters will match the order of the modules in the dependencies array.
			/// 
			/// <b>Note:</b> the order in which the dependency modules are <i>executed</i> is <b>not</b> defined by the order in the dependencies array! The execution order is affected by dependencies <i>between</i> the dependency modules as well as by their current state (whether a module already has been loaded or not). Neither module implementations nor dependents that require a module set must make any assumption about the execution order (other than expressed by their dependencies). There is, however, one exception with regard to third party libraries, see the list of limitations further down below.
			/// 
			/// <b>Note:</b>a static module value (a literal provided to <code>sap.ui.define</code>) cannot depend on the module values of the dependency modules. Instead, modules can use a factory function, calculate the static value in that function, potentially based on the dependencies, and return the result as module value. The same approach must be taken when the module value is supposed to be a function.
			/// 
			/// <h3>Asynchronous Contract</h3> <code>sap.ui.define</code> is designed to support real Asynchronous Module Definitions (AMD) in future, although it internally still uses the old synchronous module loading of UI5. Callers of <code>sap.ui.define</code> therefore must not rely on any synchronous behavior that they might observe with the current implementation.
			/// 
			/// For example, callers of <code>sap.ui.define</code> must not use the module value immediately after invoking <code>sap.ui.define</code>:
			/// 
			/// <pre>
			///   // COUNTER EXAMPLE HOW __NOT__ TO DO IT
			/// 
			///   // define a class Something as AMD module
			///   sap.ui.define('Something', [], function() {
			///     var Something = function() {};
			///     return Something;
			///   });
			/// 
			///   // DON'T DO THAT!
			///   // accessing the class _synchronously_ after sap.ui.define was called
			///   new Something();
			/// </pre>
			/// 
			/// Applications that need to ensure synchronous module definition or synchronous loading of dependencies <b>MUST</b> use the old {@link jQuery.sap.declare} and {@link jQuery.sap.require} APIs.
			/// 
			/// <h3>(No) Global References</h3>
			/// 
			/// To be in line with AMD best practices, modules defined with <code>sap.ui.define</code> should not make any use of global variables if those variables are also available as module values. Instead, they should add dependencies to those modules and use the corresponding parameter of the factory function to access the module value.
			/// 
			/// As the current programming model and the documentation of UI5 heavily rely on global names, there will be a transition phase where UI5 enables AMD modules and local references to module values in parallel to the old global names. The fourth parameter of <code>sap.ui.define</code> has been added to support that transition phase. When this parameter is set to true, the framework provides two additional functionalities
			/// 
			/// <ol> <li>Before the factory function is called, the existence of the global parent namespace for the current module is ensured</li> <li>The module value will be automatically exported under a global name which is derived from the name of the module</li> </ol>
			/// 
			/// The parameter lets the framework know whether any of those two operations is needed or not. In future versions of UI5, a central configuration option is planned to suppress those 'exports'.
			/// 
			/// <h3>Third Party Modules</h3> Although third party modules don't use UI5 APIs, they still can be listed as dependencies in a <code>sap.ui.define</code> call. They will be requested and executed like UI5 modules, but their module value will be <code>undefined</code>.
			/// 
			/// If the currently defined module needs to access the module value of such a third party module, it can access the value via its global name (if the module supports such a usage).
			/// 
			/// Note that UI5 temporarily deactivates an existing AMD loader while it executes third party modules known to support AMD. This sounds contradictorily at a first glance as UI5 wants to support AMD, but for now it is necessary to fully support UI5 applications that rely on global names for such modules.
			/// 
			/// Example: <pre>
			///   // module 'Something' wants to use third party library 'URI.js'
			///   // It is packaged by UI5 as non-UI5-module 'sap/ui/thirdparty/URI'
			/// 
			///   sap.ui.define('Something', ['sap/ui/thirdparty/URI'], function(URIModuleValue) {
			/// 
			///     new URIModuleValue(); // fails as module value is undefined
			/// 
			///     //global URI // (optional) declare usage of global name so that static code checks don't complain
			///     new URI(); // access to global name 'URI' works
			/// 
			///     ...
			///   });
			/// </pre>
			/// 
			/// <h3>Differences to Standard AMD</h3>
			/// 
			/// The current implementation of <code>sap.ui.define</code> differs from the AMD specification (https://github.com/amdjs/amdjs-api) or from concrete AMD loaders like <code>requireJS</code> in several aspects: <ul> <li>The name <code>sap.ui.define</code> is different from the plain <code>define</code>. This has two reasons: first, it avoids the impression that <code>sap.ui.define</code> is an exact implementation of an AMD loader. And second, it allows the coexistence of an AMD loader (e.g. requireJS) and <code>sap.ui.define</code> in one application as long as UI5 or applications using UI5 are not fully prepared to run with an AMD loader. Note that the difference of the API names also implies that the UI5 loader can't be used to load 'real' AMD modules as they expect methods <code>define</code> and <code>require</code> to be available. Modules that use Unified Module Definition (UMD) syntax, can be loaded, but only when no AMD loader is present or when they expose their export also to the global namespace, even when an AMD loader is present (as e.g. jQuery does)</li> <li><code>sap.ui.define</code> currently loads modules with synchronous XHR calls. This is basically a tribute to the synchronous history of UI5. <b>BUT:</b> synchronous dependency loading and factory execution explicitly it not part of contract of <code>sap.ui.define</code>. To the contrary, it is already clear and planned that asynchronous loading will be implemented, at least as an alternative if not as the only implementation. Also check section <b>Asynchronous Contract</b> above.<br> Applications that need to ensure synchronous loading of dependencies <b>MUST</b> use the old {@link jQuery.sap.require} API.</li> <li><code>sap.ui.define</code> does not support plugins to use other file types, formats or protocols. It is not planned to support this in future</li> <li><code>sap.ui.define</code> does not support absolute URLs as module names (dependencies) nor does it allow module names that start with a slash. To refer to a module at an absolute URL, a resource root can be registered that points to that URL (or to a prefix of it).</li> <li><code>sap.ui.define</code> does <b>not</b> support the 'sugar' of requireJS where CommonJS style dependency declarations using <code>sap.ui.require("something")</code> are automagically converted into <code>sap.ui.define</code> dependencies before executing the factory function.</li> </ul>
			/// 
			/// <h3>Limitations, Design Considerations</h3> <ul> <li><b>Limitation</b>: as dependency management is not supported for Non-UI5 modules, the only way to ensure proper execution order for such modules currently is to rely on the order in the dependency array. Obviously, this only works as long as <code>sap.ui.define</code> uses synchronous loading. It will be enhanced when asynchronous loading is implemented.</li> <li>It was discussed to enforce asynchronous execution of the module factory function (e.g. with a timeout of 0). But this would have invalidated the current migration scenario where a sync <code>jQuery.sap.require</code> call can load a <code>sap.ui.define</code>'ed module. If the module definition would not execute synchronously, the synchronous contract of the require call would be broken (default behavior in existing UI5 applications)</li> <li>A single file must not contain multiple calls to <code>sap.ui.define</code>. Multiple calls currently are only supported in the so called 'preload' files that the UI5 merge tooling produces. The exact details of how this works might be changed in future implementations and are not yet part of the API contract</li> </ul>
			/// </summary>
			/// <param name="sModuleName">name of the module in simplified resource name syntax. When omitted, the loader determines the name from the request.</param>
			/// <param name="aDependencies">list of dependencies of the module</param>
			/// <param name="vFactory">the module value or a function that calculates the value</param>
			/// <param name="bExport">whether an export to global names is required - should be used by SAP-owned code only</param>
			public extern static void define(string sModuleName, string[] aDependencies, object vFactory, bool bExport);

			/// <summary>
			/// Defines a Javascript module with its name, its dependencies and a module value or factory.
			/// 
			/// The typical and only suggested usage of this method is to have one single, top level call to <code>sap.ui.define</code> in one Javascript resource (file). When a module is requested by its name for the first time, the corresponding resource is determined from the name and the current {@link jQuery.sap.registerResourcePath configuration}. The resource will be loaded and executed which in turn will execute the top level <code>sap.ui.define</code> call.
			/// 
			/// If the module name was omitted from that call, it will be substituted by the name that was used to request the module. As a preparation step, the dependencies as well as their transitive dependencies, will be loaded. Then, the module value will be determined: if a static value (object, literal) was given as <code>vFactory</code>, that value will be the module value. If a function was given, that function will be called (providing the module values of the declared dependencies as parameters to the function) and its return value will be used as module value. The framework internally associates the resulting value with the module name and provides it to the original requester of the module. Whenever the module is requested again, the same value will be returned (modules are executed only once).
			/// 
			/// <i>Example:</i><br> The following example defines a module "SomeClass", but doesn't hard code the module name. If stored in a file 'sap/mylib/SomeClass.js', it can be requested as 'sap/mylib/SomeClass'. <pre>
			///   sap.ui.define(['./Helper', 'sap/m/Bar'], function(Helper,Bar) {
			/// 
			///     // create a new class
			///     var SomeClass = function() {};
			/// 
			///     // add methods to its prototype
			///     SomeClass.prototype.foo = function() {
			/// 
			///         // use a function from the dependency 'Helper' in the same package (e.g. 'sap/mylib/Helper' )
			///         var mSettings = Helper.foo();
			/// 
			///         // create and return an sap.m.Bar (using its local name 'Bar')
			///         return new Bar(mSettings);
			/// 
			///     }
			/// 
			///     // return the class as module value
			///     return SomeClass;
			/// 
			///   });
			/// </pre>
			/// 
			/// In another module or in an application HTML page, the {@link sap.ui.require} API can be used to load the Something module and to work with it:
			/// 
			/// <pre>
			/// sap.ui.require(['sap/mylib/Something'], function(Something) {
			/// 
			///   // instantiate a Something and call foo() on it
			///   new Something().foo();
			/// 
			/// });
			/// </pre>
			/// 
			/// <h3>Module Name Syntax</h3>
			/// 
			/// <code>sap.ui.define</code> uses a simplified variant of the {@link jQuery.sap.getResourcePath unified resource name} syntax for the module's own name as well as for its dependencies. The only difference to that syntax is, that for <code>sap.ui.define</code> and <code>sap.ui.require</code>, the extension (which always would be '.js') has to be omitted. Both methods always add this extension internally.
			/// 
			/// As a convenience, the name of a dependency can start with the segment './' which will be replaced by the name of the package that contains the currently defined module (relative name).
			/// 
			/// It is best practice to omit the name of the defined module (first parameter) and to use relative names for the dependencies whenever possible. This reduces the necessary configuration, simplifies renaming of packages and allows to map them to a different namespace.
			/// 
			/// <h3>Dependency to Modules</h3>
			/// 
			/// If a dependencies array is given, each entry represents the name of another module that the currently defined module depends on. All dependency modules are loaded before the value of the currently defined module is determined. The module value of each dependency module will be provided as a parameter to a factory function, the order of the parameters will match the order of the modules in the dependencies array.
			/// 
			/// <b>Note:</b> the order in which the dependency modules are <i>executed</i> is <b>not</b> defined by the order in the dependencies array! The execution order is affected by dependencies <i>between</i> the dependency modules as well as by their current state (whether a module already has been loaded or not). Neither module implementations nor dependents that require a module set must make any assumption about the execution order (other than expressed by their dependencies). There is, however, one exception with regard to third party libraries, see the list of limitations further down below.
			/// 
			/// <b>Note:</b>a static module value (a literal provided to <code>sap.ui.define</code>) cannot depend on the module values of the dependency modules. Instead, modules can use a factory function, calculate the static value in that function, potentially based on the dependencies, and return the result as module value. The same approach must be taken when the module value is supposed to be a function.
			/// 
			/// <h3>Asynchronous Contract</h3> <code>sap.ui.define</code> is designed to support real Asynchronous Module Definitions (AMD) in future, although it internally still uses the old synchronous module loading of UI5. Callers of <code>sap.ui.define</code> therefore must not rely on any synchronous behavior that they might observe with the current implementation.
			/// 
			/// For example, callers of <code>sap.ui.define</code> must not use the module value immediately after invoking <code>sap.ui.define</code>:
			/// 
			/// <pre>
			///   // COUNTER EXAMPLE HOW __NOT__ TO DO IT
			/// 
			///   // define a class Something as AMD module
			///   sap.ui.define('Something', [], function() {
			///     var Something = function() {};
			///     return Something;
			///   });
			/// 
			///   // DON'T DO THAT!
			///   // accessing the class _synchronously_ after sap.ui.define was called
			///   new Something();
			/// </pre>
			/// 
			/// Applications that need to ensure synchronous module definition or synchronous loading of dependencies <b>MUST</b> use the old {@link jQuery.sap.declare} and {@link jQuery.sap.require} APIs.
			/// 
			/// <h3>(No) Global References</h3>
			/// 
			/// To be in line with AMD best practices, modules defined with <code>sap.ui.define</code> should not make any use of global variables if those variables are also available as module values. Instead, they should add dependencies to those modules and use the corresponding parameter of the factory function to access the module value.
			/// 
			/// As the current programming model and the documentation of UI5 heavily rely on global names, there will be a transition phase where UI5 enables AMD modules and local references to module values in parallel to the old global names. The fourth parameter of <code>sap.ui.define</code> has been added to support that transition phase. When this parameter is set to true, the framework provides two additional functionalities
			/// 
			/// <ol> <li>Before the factory function is called, the existence of the global parent namespace for the current module is ensured</li> <li>The module value will be automatically exported under a global name which is derived from the name of the module</li> </ol>
			/// 
			/// The parameter lets the framework know whether any of those two operations is needed or not. In future versions of UI5, a central configuration option is planned to suppress those 'exports'.
			/// 
			/// <h3>Third Party Modules</h3> Although third party modules don't use UI5 APIs, they still can be listed as dependencies in a <code>sap.ui.define</code> call. They will be requested and executed like UI5 modules, but their module value will be <code>undefined</code>.
			/// 
			/// If the currently defined module needs to access the module value of such a third party module, it can access the value via its global name (if the module supports such a usage).
			/// 
			/// Note that UI5 temporarily deactivates an existing AMD loader while it executes third party modules known to support AMD. This sounds contradictorily at a first glance as UI5 wants to support AMD, but for now it is necessary to fully support UI5 applications that rely on global names for such modules.
			/// 
			/// Example: <pre>
			///   // module 'Something' wants to use third party library 'URI.js'
			///   // It is packaged by UI5 as non-UI5-module 'sap/ui/thirdparty/URI'
			/// 
			///   sap.ui.define('Something', ['sap/ui/thirdparty/URI'], function(URIModuleValue) {
			/// 
			///     new URIModuleValue(); // fails as module value is undefined
			/// 
			///     //global URI // (optional) declare usage of global name so that static code checks don't complain
			///     new URI(); // access to global name 'URI' works
			/// 
			///     ...
			///   });
			/// </pre>
			/// 
			/// <h3>Differences to Standard AMD</h3>
			/// 
			/// The current implementation of <code>sap.ui.define</code> differs from the AMD specification (https://github.com/amdjs/amdjs-api) or from concrete AMD loaders like <code>requireJS</code> in several aspects: <ul> <li>The name <code>sap.ui.define</code> is different from the plain <code>define</code>. This has two reasons: first, it avoids the impression that <code>sap.ui.define</code> is an exact implementation of an AMD loader. And second, it allows the coexistence of an AMD loader (e.g. requireJS) and <code>sap.ui.define</code> in one application as long as UI5 or applications using UI5 are not fully prepared to run with an AMD loader. Note that the difference of the API names also implies that the UI5 loader can't be used to load 'real' AMD modules as they expect methods <code>define</code> and <code>require</code> to be available. Modules that use Unified Module Definition (UMD) syntax, can be loaded, but only when no AMD loader is present or when they expose their export also to the global namespace, even when an AMD loader is present (as e.g. jQuery does)</li> <li><code>sap.ui.define</code> currently loads modules with synchronous XHR calls. This is basically a tribute to the synchronous history of UI5. <b>BUT:</b> synchronous dependency loading and factory execution explicitly it not part of contract of <code>sap.ui.define</code>. To the contrary, it is already clear and planned that asynchronous loading will be implemented, at least as an alternative if not as the only implementation. Also check section <b>Asynchronous Contract</b> above.<br> Applications that need to ensure synchronous loading of dependencies <b>MUST</b> use the old {@link jQuery.sap.require} API.</li> <li><code>sap.ui.define</code> does not support plugins to use other file types, formats or protocols. It is not planned to support this in future</li> <li><code>sap.ui.define</code> does not support absolute URLs as module names (dependencies) nor does it allow module names that start with a slash. To refer to a module at an absolute URL, a resource root can be registered that points to that URL (or to a prefix of it).</li> <li><code>sap.ui.define</code> does <b>not</b> support the 'sugar' of requireJS where CommonJS style dependency declarations using <code>sap.ui.require("something")</code> are automagically converted into <code>sap.ui.define</code> dependencies before executing the factory function.</li> </ul>
			/// 
			/// <h3>Limitations, Design Considerations</h3> <ul> <li><b>Limitation</b>: as dependency management is not supported for Non-UI5 modules, the only way to ensure proper execution order for such modules currently is to rely on the order in the dependency array. Obviously, this only works as long as <code>sap.ui.define</code> uses synchronous loading. It will be enhanced when asynchronous loading is implemented.</li> <li>It was discussed to enforce asynchronous execution of the module factory function (e.g. with a timeout of 0). But this would have invalidated the current migration scenario where a sync <code>jQuery.sap.require</code> call can load a <code>sap.ui.define</code>'ed module. If the module definition would not execute synchronously, the synchronous contract of the require call would be broken (default behavior in existing UI5 applications)</li> <li>A single file must not contain multiple calls to <code>sap.ui.define</code>. Multiple calls currently are only supported in the so called 'preload' files that the UI5 merge tooling produces. The exact details of how this works might be changed in future implementations and are not yet part of the API contract</li> </ul>
			/// </summary>
			/// <param name="sModuleName">name of the module in simplified resource name syntax. When omitted, the loader determines the name from the request.</param>
			/// <param name="aDependencies">list of dependencies of the module</param>
			/// <param name="vFactory">the module value or a function that calculates the value</param>
			/// <param name="bExport">whether an export to global names is required - should be used by SAP-owned code only</param>
			public extern static void define(string sModuleName, object[] aDependencies, object vFactory, bool bExport);

			/// <summary>
			/// Defines a Javascript module with its name, its dependencies and a module value or factory.
			/// 
			/// The typical and only suggested usage of this method is to have one single, top level call to <code>sap.ui.define</code> in one Javascript resource (file). When a module is requested by its name for the first time, the corresponding resource is determined from the name and the current {@link jQuery.sap.registerResourcePath configuration}. The resource will be loaded and executed which in turn will execute the top level <code>sap.ui.define</code> call.
			/// 
			/// If the module name was omitted from that call, it will be substituted by the name that was used to request the module. As a preparation step, the dependencies as well as their transitive dependencies, will be loaded. Then, the module value will be determined: if a static value (object, literal) was given as <code>vFactory</code>, that value will be the module value. If a function was given, that function will be called (providing the module values of the declared dependencies as parameters to the function) and its return value will be used as module value. The framework internally associates the resulting value with the module name and provides it to the original requester of the module. Whenever the module is requested again, the same value will be returned (modules are executed only once).
			/// 
			/// <i>Example:</i><br> The following example defines a module "SomeClass", but doesn't hard code the module name. If stored in a file 'sap/mylib/SomeClass.js', it can be requested as 'sap/mylib/SomeClass'. <pre>
			///   sap.ui.define(['./Helper', 'sap/m/Bar'], function(Helper,Bar) {
			/// 
			///     // create a new class
			///     var SomeClass = function() {};
			/// 
			///     // add methods to its prototype
			///     SomeClass.prototype.foo = function() {
			/// 
			///         // use a function from the dependency 'Helper' in the same package (e.g. 'sap/mylib/Helper' )
			///         var mSettings = Helper.foo();
			/// 
			///         // create and return an sap.m.Bar (using its local name 'Bar')
			///         return new Bar(mSettings);
			/// 
			///     }
			/// 
			///     // return the class as module value
			///     return SomeClass;
			/// 
			///   });
			/// </pre>
			/// 
			/// In another module or in an application HTML page, the {@link sap.ui.require} API can be used to load the Something module and to work with it:
			/// 
			/// <pre>
			/// sap.ui.require(['sap/mylib/Something'], function(Something) {
			/// 
			///   // instantiate a Something and call foo() on it
			///   new Something().foo();
			/// 
			/// });
			/// </pre>
			/// 
			/// <h3>Module Name Syntax</h3>
			/// 
			/// <code>sap.ui.define</code> uses a simplified variant of the {@link jQuery.sap.getResourcePath unified resource name} syntax for the module's own name as well as for its dependencies. The only difference to that syntax is, that for <code>sap.ui.define</code> and <code>sap.ui.require</code>, the extension (which always would be '.js') has to be omitted. Both methods always add this extension internally.
			/// 
			/// As a convenience, the name of a dependency can start with the segment './' which will be replaced by the name of the package that contains the currently defined module (relative name).
			/// 
			/// It is best practice to omit the name of the defined module (first parameter) and to use relative names for the dependencies whenever possible. This reduces the necessary configuration, simplifies renaming of packages and allows to map them to a different namespace.
			/// 
			/// <h3>Dependency to Modules</h3>
			/// 
			/// If a dependencies array is given, each entry represents the name of another module that the currently defined module depends on. All dependency modules are loaded before the value of the currently defined module is determined. The module value of each dependency module will be provided as a parameter to a factory function, the order of the parameters will match the order of the modules in the dependencies array.
			/// 
			/// <b>Note:</b> the order in which the dependency modules are <i>executed</i> is <b>not</b> defined by the order in the dependencies array! The execution order is affected by dependencies <i>between</i> the dependency modules as well as by their current state (whether a module already has been loaded or not). Neither module implementations nor dependents that require a module set must make any assumption about the execution order (other than expressed by their dependencies). There is, however, one exception with regard to third party libraries, see the list of limitations further down below.
			/// 
			/// <b>Note:</b>a static module value (a literal provided to <code>sap.ui.define</code>) cannot depend on the module values of the dependency modules. Instead, modules can use a factory function, calculate the static value in that function, potentially based on the dependencies, and return the result as module value. The same approach must be taken when the module value is supposed to be a function.
			/// 
			/// <h3>Asynchronous Contract</h3> <code>sap.ui.define</code> is designed to support real Asynchronous Module Definitions (AMD) in future, although it internally still uses the old synchronous module loading of UI5. Callers of <code>sap.ui.define</code> therefore must not rely on any synchronous behavior that they might observe with the current implementation.
			/// 
			/// For example, callers of <code>sap.ui.define</code> must not use the module value immediately after invoking <code>sap.ui.define</code>:
			/// 
			/// <pre>
			///   // COUNTER EXAMPLE HOW __NOT__ TO DO IT
			/// 
			///   // define a class Something as AMD module
			///   sap.ui.define('Something', [], function() {
			///     var Something = function() {};
			///     return Something;
			///   });
			/// 
			///   // DON'T DO THAT!
			///   // accessing the class _synchronously_ after sap.ui.define was called
			///   new Something();
			/// </pre>
			/// 
			/// Applications that need to ensure synchronous module definition or synchronous loading of dependencies <b>MUST</b> use the old {@link jQuery.sap.declare} and {@link jQuery.sap.require} APIs.
			/// 
			/// <h3>(No) Global References</h3>
			/// 
			/// To be in line with AMD best practices, modules defined with <code>sap.ui.define</code> should not make any use of global variables if those variables are also available as module values. Instead, they should add dependencies to those modules and use the corresponding parameter of the factory function to access the module value.
			/// 
			/// As the current programming model and the documentation of UI5 heavily rely on global names, there will be a transition phase where UI5 enables AMD modules and local references to module values in parallel to the old global names. The fourth parameter of <code>sap.ui.define</code> has been added to support that transition phase. When this parameter is set to true, the framework provides two additional functionalities
			/// 
			/// <ol> <li>Before the factory function is called, the existence of the global parent namespace for the current module is ensured</li> <li>The module value will be automatically exported under a global name which is derived from the name of the module</li> </ol>
			/// 
			/// The parameter lets the framework know whether any of those two operations is needed or not. In future versions of UI5, a central configuration option is planned to suppress those 'exports'.
			/// 
			/// <h3>Third Party Modules</h3> Although third party modules don't use UI5 APIs, they still can be listed as dependencies in a <code>sap.ui.define</code> call. They will be requested and executed like UI5 modules, but their module value will be <code>undefined</code>.
			/// 
			/// If the currently defined module needs to access the module value of such a third party module, it can access the value via its global name (if the module supports such a usage).
			/// 
			/// Note that UI5 temporarily deactivates an existing AMD loader while it executes third party modules known to support AMD. This sounds contradictorily at a first glance as UI5 wants to support AMD, but for now it is necessary to fully support UI5 applications that rely on global names for such modules.
			/// 
			/// Example: <pre>
			///   // module 'Something' wants to use third party library 'URI.js'
			///   // It is packaged by UI5 as non-UI5-module 'sap/ui/thirdparty/URI'
			/// 
			///   sap.ui.define('Something', ['sap/ui/thirdparty/URI'], function(URIModuleValue) {
			/// 
			///     new URIModuleValue(); // fails as module value is undefined
			/// 
			///     //global URI // (optional) declare usage of global name so that static code checks don't complain
			///     new URI(); // access to global name 'URI' works
			/// 
			///     ...
			///   });
			/// </pre>
			/// 
			/// <h3>Differences to Standard AMD</h3>
			/// 
			/// The current implementation of <code>sap.ui.define</code> differs from the AMD specification (https://github.com/amdjs/amdjs-api) or from concrete AMD loaders like <code>requireJS</code> in several aspects: <ul> <li>The name <code>sap.ui.define</code> is different from the plain <code>define</code>. This has two reasons: first, it avoids the impression that <code>sap.ui.define</code> is an exact implementation of an AMD loader. And second, it allows the coexistence of an AMD loader (e.g. requireJS) and <code>sap.ui.define</code> in one application as long as UI5 or applications using UI5 are not fully prepared to run with an AMD loader. Note that the difference of the API names also implies that the UI5 loader can't be used to load 'real' AMD modules as they expect methods <code>define</code> and <code>require</code> to be available. Modules that use Unified Module Definition (UMD) syntax, can be loaded, but only when no AMD loader is present or when they expose their export also to the global namespace, even when an AMD loader is present (as e.g. jQuery does)</li> <li><code>sap.ui.define</code> currently loads modules with synchronous XHR calls. This is basically a tribute to the synchronous history of UI5. <b>BUT:</b> synchronous dependency loading and factory execution explicitly it not part of contract of <code>sap.ui.define</code>. To the contrary, it is already clear and planned that asynchronous loading will be implemented, at least as an alternative if not as the only implementation. Also check section <b>Asynchronous Contract</b> above.<br> Applications that need to ensure synchronous loading of dependencies <b>MUST</b> use the old {@link jQuery.sap.require} API.</li> <li><code>sap.ui.define</code> does not support plugins to use other file types, formats or protocols. It is not planned to support this in future</li> <li><code>sap.ui.define</code> does not support absolute URLs as module names (dependencies) nor does it allow module names that start with a slash. To refer to a module at an absolute URL, a resource root can be registered that points to that URL (or to a prefix of it).</li> <li><code>sap.ui.define</code> does <b>not</b> support the 'sugar' of requireJS where CommonJS style dependency declarations using <code>sap.ui.require("something")</code> are automagically converted into <code>sap.ui.define</code> dependencies before executing the factory function.</li> </ul>
			/// 
			/// <h3>Limitations, Design Considerations</h3> <ul> <li><b>Limitation</b>: as dependency management is not supported for Non-UI5 modules, the only way to ensure proper execution order for such modules currently is to rely on the order in the dependency array. Obviously, this only works as long as <code>sap.ui.define</code> uses synchronous loading. It will be enhanced when asynchronous loading is implemented.</li> <li>It was discussed to enforce asynchronous execution of the module factory function (e.g. with a timeout of 0). But this would have invalidated the current migration scenario where a sync <code>jQuery.sap.require</code> call can load a <code>sap.ui.define</code>'ed module. If the module definition would not execute synchronously, the synchronous contract of the require call would be broken (default behavior in existing UI5 applications)</li> <li>A single file must not contain multiple calls to <code>sap.ui.define</code>. Multiple calls currently are only supported in the so called 'preload' files that the UI5 merge tooling produces. The exact details of how this works might be changed in future implementations and are not yet part of the API contract</li> </ul>
			/// </summary>
			/// <param name="sModuleName">name of the module in simplified resource name syntax. When omitted, the loader determines the name from the request.</param>
			/// <param name="aDependencies">list of dependencies of the module</param>
			/// <param name="vFactory">the module value or a function that calculates the value</param>
			public extern static void define(string sModuleName, string[] aDependencies, object vFactory);

			/// <summary>
			/// Defines a Javascript module with its name, its dependencies and a module value or factory.
			/// 
			/// The typical and only suggested usage of this method is to have one single, top level call to <code>sap.ui.define</code> in one Javascript resource (file). When a module is requested by its name for the first time, the corresponding resource is determined from the name and the current {@link jQuery.sap.registerResourcePath configuration}. The resource will be loaded and executed which in turn will execute the top level <code>sap.ui.define</code> call.
			/// 
			/// If the module name was omitted from that call, it will be substituted by the name that was used to request the module. As a preparation step, the dependencies as well as their transitive dependencies, will be loaded. Then, the module value will be determined: if a static value (object, literal) was given as <code>vFactory</code>, that value will be the module value. If a function was given, that function will be called (providing the module values of the declared dependencies as parameters to the function) and its return value will be used as module value. The framework internally associates the resulting value with the module name and provides it to the original requester of the module. Whenever the module is requested again, the same value will be returned (modules are executed only once).
			/// 
			/// <i>Example:</i><br> The following example defines a module "SomeClass", but doesn't hard code the module name. If stored in a file 'sap/mylib/SomeClass.js', it can be requested as 'sap/mylib/SomeClass'. <pre>
			///   sap.ui.define(['./Helper', 'sap/m/Bar'], function(Helper,Bar) {
			/// 
			///     // create a new class
			///     var SomeClass = function() {};
			/// 
			///     // add methods to its prototype
			///     SomeClass.prototype.foo = function() {
			/// 
			///         // use a function from the dependency 'Helper' in the same package (e.g. 'sap/mylib/Helper' )
			///         var mSettings = Helper.foo();
			/// 
			///         // create and return an sap.m.Bar (using its local name 'Bar')
			///         return new Bar(mSettings);
			/// 
			///     }
			/// 
			///     // return the class as module value
			///     return SomeClass;
			/// 
			///   });
			/// </pre>
			/// 
			/// In another module or in an application HTML page, the {@link sap.ui.require} API can be used to load the Something module and to work with it:
			/// 
			/// <pre>
			/// sap.ui.require(['sap/mylib/Something'], function(Something) {
			/// 
			///   // instantiate a Something and call foo() on it
			///   new Something().foo();
			/// 
			/// });
			/// </pre>
			/// 
			/// <h3>Module Name Syntax</h3>
			/// 
			/// <code>sap.ui.define</code> uses a simplified variant of the {@link jQuery.sap.getResourcePath unified resource name} syntax for the module's own name as well as for its dependencies. The only difference to that syntax is, that for <code>sap.ui.define</code> and <code>sap.ui.require</code>, the extension (which always would be '.js') has to be omitted. Both methods always add this extension internally.
			/// 
			/// As a convenience, the name of a dependency can start with the segment './' which will be replaced by the name of the package that contains the currently defined module (relative name).
			/// 
			/// It is best practice to omit the name of the defined module (first parameter) and to use relative names for the dependencies whenever possible. This reduces the necessary configuration, simplifies renaming of packages and allows to map them to a different namespace.
			/// 
			/// <h3>Dependency to Modules</h3>
			/// 
			/// If a dependencies array is given, each entry represents the name of another module that the currently defined module depends on. All dependency modules are loaded before the value of the currently defined module is determined. The module value of each dependency module will be provided as a parameter to a factory function, the order of the parameters will match the order of the modules in the dependencies array.
			/// 
			/// <b>Note:</b> the order in which the dependency modules are <i>executed</i> is <b>not</b> defined by the order in the dependencies array! The execution order is affected by dependencies <i>between</i> the dependency modules as well as by their current state (whether a module already has been loaded or not). Neither module implementations nor dependents that require a module set must make any assumption about the execution order (other than expressed by their dependencies). There is, however, one exception with regard to third party libraries, see the list of limitations further down below.
			/// 
			/// <b>Note:</b>a static module value (a literal provided to <code>sap.ui.define</code>) cannot depend on the module values of the dependency modules. Instead, modules can use a factory function, calculate the static value in that function, potentially based on the dependencies, and return the result as module value. The same approach must be taken when the module value is supposed to be a function.
			/// 
			/// <h3>Asynchronous Contract</h3> <code>sap.ui.define</code> is designed to support real Asynchronous Module Definitions (AMD) in future, although it internally still uses the old synchronous module loading of UI5. Callers of <code>sap.ui.define</code> therefore must not rely on any synchronous behavior that they might observe with the current implementation.
			/// 
			/// For example, callers of <code>sap.ui.define</code> must not use the module value immediately after invoking <code>sap.ui.define</code>:
			/// 
			/// <pre>
			///   // COUNTER EXAMPLE HOW __NOT__ TO DO IT
			/// 
			///   // define a class Something as AMD module
			///   sap.ui.define('Something', [], function() {
			///     var Something = function() {};
			///     return Something;
			///   });
			/// 
			///   // DON'T DO THAT!
			///   // accessing the class _synchronously_ after sap.ui.define was called
			///   new Something();
			/// </pre>
			/// 
			/// Applications that need to ensure synchronous module definition or synchronous loading of dependencies <b>MUST</b> use the old {@link jQuery.sap.declare} and {@link jQuery.sap.require} APIs.
			/// 
			/// <h3>(No) Global References</h3>
			/// 
			/// To be in line with AMD best practices, modules defined with <code>sap.ui.define</code> should not make any use of global variables if those variables are also available as module values. Instead, they should add dependencies to those modules and use the corresponding parameter of the factory function to access the module value.
			/// 
			/// As the current programming model and the documentation of UI5 heavily rely on global names, there will be a transition phase where UI5 enables AMD modules and local references to module values in parallel to the old global names. The fourth parameter of <code>sap.ui.define</code> has been added to support that transition phase. When this parameter is set to true, the framework provides two additional functionalities
			/// 
			/// <ol> <li>Before the factory function is called, the existence of the global parent namespace for the current module is ensured</li> <li>The module value will be automatically exported under a global name which is derived from the name of the module</li> </ol>
			/// 
			/// The parameter lets the framework know whether any of those two operations is needed or not. In future versions of UI5, a central configuration option is planned to suppress those 'exports'.
			/// 
			/// <h3>Third Party Modules</h3> Although third party modules don't use UI5 APIs, they still can be listed as dependencies in a <code>sap.ui.define</code> call. They will be requested and executed like UI5 modules, but their module value will be <code>undefined</code>.
			/// 
			/// If the currently defined module needs to access the module value of such a third party module, it can access the value via its global name (if the module supports such a usage).
			/// 
			/// Note that UI5 temporarily deactivates an existing AMD loader while it executes third party modules known to support AMD. This sounds contradictorily at a first glance as UI5 wants to support AMD, but for now it is necessary to fully support UI5 applications that rely on global names for such modules.
			/// 
			/// Example: <pre>
			///   // module 'Something' wants to use third party library 'URI.js'
			///   // It is packaged by UI5 as non-UI5-module 'sap/ui/thirdparty/URI'
			/// 
			///   sap.ui.define('Something', ['sap/ui/thirdparty/URI'], function(URIModuleValue) {
			/// 
			///     new URIModuleValue(); // fails as module value is undefined
			/// 
			///     //global URI // (optional) declare usage of global name so that static code checks don't complain
			///     new URI(); // access to global name 'URI' works
			/// 
			///     ...
			///   });
			/// </pre>
			/// 
			/// <h3>Differences to Standard AMD</h3>
			/// 
			/// The current implementation of <code>sap.ui.define</code> differs from the AMD specification (https://github.com/amdjs/amdjs-api) or from concrete AMD loaders like <code>requireJS</code> in several aspects: <ul> <li>The name <code>sap.ui.define</code> is different from the plain <code>define</code>. This has two reasons: first, it avoids the impression that <code>sap.ui.define</code> is an exact implementation of an AMD loader. And second, it allows the coexistence of an AMD loader (e.g. requireJS) and <code>sap.ui.define</code> in one application as long as UI5 or applications using UI5 are not fully prepared to run with an AMD loader. Note that the difference of the API names also implies that the UI5 loader can't be used to load 'real' AMD modules as they expect methods <code>define</code> and <code>require</code> to be available. Modules that use Unified Module Definition (UMD) syntax, can be loaded, but only when no AMD loader is present or when they expose their export also to the global namespace, even when an AMD loader is present (as e.g. jQuery does)</li> <li><code>sap.ui.define</code> currently loads modules with synchronous XHR calls. This is basically a tribute to the synchronous history of UI5. <b>BUT:</b> synchronous dependency loading and factory execution explicitly it not part of contract of <code>sap.ui.define</code>. To the contrary, it is already clear and planned that asynchronous loading will be implemented, at least as an alternative if not as the only implementation. Also check section <b>Asynchronous Contract</b> above.<br> Applications that need to ensure synchronous loading of dependencies <b>MUST</b> use the old {@link jQuery.sap.require} API.</li> <li><code>sap.ui.define</code> does not support plugins to use other file types, formats or protocols. It is not planned to support this in future</li> <li><code>sap.ui.define</code> does not support absolute URLs as module names (dependencies) nor does it allow module names that start with a slash. To refer to a module at an absolute URL, a resource root can be registered that points to that URL (or to a prefix of it).</li> <li><code>sap.ui.define</code> does <b>not</b> support the 'sugar' of requireJS where CommonJS style dependency declarations using <code>sap.ui.require("something")</code> are automagically converted into <code>sap.ui.define</code> dependencies before executing the factory function.</li> </ul>
			/// 
			/// <h3>Limitations, Design Considerations</h3> <ul> <li><b>Limitation</b>: as dependency management is not supported for Non-UI5 modules, the only way to ensure proper execution order for such modules currently is to rely on the order in the dependency array. Obviously, this only works as long as <code>sap.ui.define</code> uses synchronous loading. It will be enhanced when asynchronous loading is implemented.</li> <li>It was discussed to enforce asynchronous execution of the module factory function (e.g. with a timeout of 0). But this would have invalidated the current migration scenario where a sync <code>jQuery.sap.require</code> call can load a <code>sap.ui.define</code>'ed module. If the module definition would not execute synchronously, the synchronous contract of the require call would be broken (default behavior in existing UI5 applications)</li> <li>A single file must not contain multiple calls to <code>sap.ui.define</code>. Multiple calls currently are only supported in the so called 'preload' files that the UI5 merge tooling produces. The exact details of how this works might be changed in future implementations and are not yet part of the API contract</li> </ul>
			/// </summary>
			/// <param name="sModuleName">name of the module in simplified resource name syntax. When omitted, the loader determines the name from the request.</param>
			/// <param name="aDependencies">list of dependencies of the module</param>
			/// <param name="vFactory">the module value or a function that calculates the value</param>
			public extern static void define(string sModuleName, object[] aDependencies, object vFactory);

			/// <summary>
			/// Defines a Javascript module with its name, its dependencies and a module value or factory.
			/// 
			/// The typical and only suggested usage of this method is to have one single, top level call to <code>sap.ui.define</code> in one Javascript resource (file). When a module is requested by its name for the first time, the corresponding resource is determined from the name and the current {@link jQuery.sap.registerResourcePath configuration}. The resource will be loaded and executed which in turn will execute the top level <code>sap.ui.define</code> call.
			/// 
			/// If the module name was omitted from that call, it will be substituted by the name that was used to request the module. As a preparation step, the dependencies as well as their transitive dependencies, will be loaded. Then, the module value will be determined: if a static value (object, literal) was given as <code>vFactory</code>, that value will be the module value. If a function was given, that function will be called (providing the module values of the declared dependencies as parameters to the function) and its return value will be used as module value. The framework internally associates the resulting value with the module name and provides it to the original requester of the module. Whenever the module is requested again, the same value will be returned (modules are executed only once).
			/// 
			/// <i>Example:</i><br> The following example defines a module "SomeClass", but doesn't hard code the module name. If stored in a file 'sap/mylib/SomeClass.js', it can be requested as 'sap/mylib/SomeClass'. <pre>
			///   sap.ui.define(['./Helper', 'sap/m/Bar'], function(Helper,Bar) {
			/// 
			///     // create a new class
			///     var SomeClass = function() {};
			/// 
			///     // add methods to its prototype
			///     SomeClass.prototype.foo = function() {
			/// 
			///         // use a function from the dependency 'Helper' in the same package (e.g. 'sap/mylib/Helper' )
			///         var mSettings = Helper.foo();
			/// 
			///         // create and return an sap.m.Bar (using its local name 'Bar')
			///         return new Bar(mSettings);
			/// 
			///     }
			/// 
			///     // return the class as module value
			///     return SomeClass;
			/// 
			///   });
			/// </pre>
			/// 
			/// In another module or in an application HTML page, the {@link sap.ui.require} API can be used to load the Something module and to work with it:
			/// 
			/// <pre>
			/// sap.ui.require(['sap/mylib/Something'], function(Something) {
			/// 
			///   // instantiate a Something and call foo() on it
			///   new Something().foo();
			/// 
			/// });
			/// </pre>
			/// 
			/// <h3>Module Name Syntax</h3>
			/// 
			/// <code>sap.ui.define</code> uses a simplified variant of the {@link jQuery.sap.getResourcePath unified resource name} syntax for the module's own name as well as for its dependencies. The only difference to that syntax is, that for <code>sap.ui.define</code> and <code>sap.ui.require</code>, the extension (which always would be '.js') has to be omitted. Both methods always add this extension internally.
			/// 
			/// As a convenience, the name of a dependency can start with the segment './' which will be replaced by the name of the package that contains the currently defined module (relative name).
			/// 
			/// It is best practice to omit the name of the defined module (first parameter) and to use relative names for the dependencies whenever possible. This reduces the necessary configuration, simplifies renaming of packages and allows to map them to a different namespace.
			/// 
			/// <h3>Dependency to Modules</h3>
			/// 
			/// If a dependencies array is given, each entry represents the name of another module that the currently defined module depends on. All dependency modules are loaded before the value of the currently defined module is determined. The module value of each dependency module will be provided as a parameter to a factory function, the order of the parameters will match the order of the modules in the dependencies array.
			/// 
			/// <b>Note:</b> the order in which the dependency modules are <i>executed</i> is <b>not</b> defined by the order in the dependencies array! The execution order is affected by dependencies <i>between</i> the dependency modules as well as by their current state (whether a module already has been loaded or not). Neither module implementations nor dependents that require a module set must make any assumption about the execution order (other than expressed by their dependencies). There is, however, one exception with regard to third party libraries, see the list of limitations further down below.
			/// 
			/// <b>Note:</b>a static module value (a literal provided to <code>sap.ui.define</code>) cannot depend on the module values of the dependency modules. Instead, modules can use a factory function, calculate the static value in that function, potentially based on the dependencies, and return the result as module value. The same approach must be taken when the module value is supposed to be a function.
			/// 
			/// <h3>Asynchronous Contract</h3> <code>sap.ui.define</code> is designed to support real Asynchronous Module Definitions (AMD) in future, although it internally still uses the old synchronous module loading of UI5. Callers of <code>sap.ui.define</code> therefore must not rely on any synchronous behavior that they might observe with the current implementation.
			/// 
			/// For example, callers of <code>sap.ui.define</code> must not use the module value immediately after invoking <code>sap.ui.define</code>:
			/// 
			/// <pre>
			///   // COUNTER EXAMPLE HOW __NOT__ TO DO IT
			/// 
			///   // define a class Something as AMD module
			///   sap.ui.define('Something', [], function() {
			///     var Something = function() {};
			///     return Something;
			///   });
			/// 
			///   // DON'T DO THAT!
			///   // accessing the class _synchronously_ after sap.ui.define was called
			///   new Something();
			/// </pre>
			/// 
			/// Applications that need to ensure synchronous module definition or synchronous loading of dependencies <b>MUST</b> use the old {@link jQuery.sap.declare} and {@link jQuery.sap.require} APIs.
			/// 
			/// <h3>(No) Global References</h3>
			/// 
			/// To be in line with AMD best practices, modules defined with <code>sap.ui.define</code> should not make any use of global variables if those variables are also available as module values. Instead, they should add dependencies to those modules and use the corresponding parameter of the factory function to access the module value.
			/// 
			/// As the current programming model and the documentation of UI5 heavily rely on global names, there will be a transition phase where UI5 enables AMD modules and local references to module values in parallel to the old global names. The fourth parameter of <code>sap.ui.define</code> has been added to support that transition phase. When this parameter is set to true, the framework provides two additional functionalities
			/// 
			/// <ol> <li>Before the factory function is called, the existence of the global parent namespace for the current module is ensured</li> <li>The module value will be automatically exported under a global name which is derived from the name of the module</li> </ol>
			/// 
			/// The parameter lets the framework know whether any of those two operations is needed or not. In future versions of UI5, a central configuration option is planned to suppress those 'exports'.
			/// 
			/// <h3>Third Party Modules</h3> Although third party modules don't use UI5 APIs, they still can be listed as dependencies in a <code>sap.ui.define</code> call. They will be requested and executed like UI5 modules, but their module value will be <code>undefined</code>.
			/// 
			/// If the currently defined module needs to access the module value of such a third party module, it can access the value via its global name (if the module supports such a usage).
			/// 
			/// Note that UI5 temporarily deactivates an existing AMD loader while it executes third party modules known to support AMD. This sounds contradictorily at a first glance as UI5 wants to support AMD, but for now it is necessary to fully support UI5 applications that rely on global names for such modules.
			/// 
			/// Example: <pre>
			///   // module 'Something' wants to use third party library 'URI.js'
			///   // It is packaged by UI5 as non-UI5-module 'sap/ui/thirdparty/URI'
			/// 
			///   sap.ui.define('Something', ['sap/ui/thirdparty/URI'], function(URIModuleValue) {
			/// 
			///     new URIModuleValue(); // fails as module value is undefined
			/// 
			///     //global URI // (optional) declare usage of global name so that static code checks don't complain
			///     new URI(); // access to global name 'URI' works
			/// 
			///     ...
			///   });
			/// </pre>
			/// 
			/// <h3>Differences to Standard AMD</h3>
			/// 
			/// The current implementation of <code>sap.ui.define</code> differs from the AMD specification (https://github.com/amdjs/amdjs-api) or from concrete AMD loaders like <code>requireJS</code> in several aspects: <ul> <li>The name <code>sap.ui.define</code> is different from the plain <code>define</code>. This has two reasons: first, it avoids the impression that <code>sap.ui.define</code> is an exact implementation of an AMD loader. And second, it allows the coexistence of an AMD loader (e.g. requireJS) and <code>sap.ui.define</code> in one application as long as UI5 or applications using UI5 are not fully prepared to run with an AMD loader. Note that the difference of the API names also implies that the UI5 loader can't be used to load 'real' AMD modules as they expect methods <code>define</code> and <code>require</code> to be available. Modules that use Unified Module Definition (UMD) syntax, can be loaded, but only when no AMD loader is present or when they expose their export also to the global namespace, even when an AMD loader is present (as e.g. jQuery does)</li> <li><code>sap.ui.define</code> currently loads modules with synchronous XHR calls. This is basically a tribute to the synchronous history of UI5. <b>BUT:</b> synchronous dependency loading and factory execution explicitly it not part of contract of <code>sap.ui.define</code>. To the contrary, it is already clear and planned that asynchronous loading will be implemented, at least as an alternative if not as the only implementation. Also check section <b>Asynchronous Contract</b> above.<br> Applications that need to ensure synchronous loading of dependencies <b>MUST</b> use the old {@link jQuery.sap.require} API.</li> <li><code>sap.ui.define</code> does not support plugins to use other file types, formats or protocols. It is not planned to support this in future</li> <li><code>sap.ui.define</code> does not support absolute URLs as module names (dependencies) nor does it allow module names that start with a slash. To refer to a module at an absolute URL, a resource root can be registered that points to that URL (or to a prefix of it).</li> <li><code>sap.ui.define</code> does <b>not</b> support the 'sugar' of requireJS where CommonJS style dependency declarations using <code>sap.ui.require("something")</code> are automagically converted into <code>sap.ui.define</code> dependencies before executing the factory function.</li> </ul>
			/// 
			/// <h3>Limitations, Design Considerations</h3> <ul> <li><b>Limitation</b>: as dependency management is not supported for Non-UI5 modules, the only way to ensure proper execution order for such modules currently is to rely on the order in the dependency array. Obviously, this only works as long as <code>sap.ui.define</code> uses synchronous loading. It will be enhanced when asynchronous loading is implemented.</li> <li>It was discussed to enforce asynchronous execution of the module factory function (e.g. with a timeout of 0). But this would have invalidated the current migration scenario where a sync <code>jQuery.sap.require</code> call can load a <code>sap.ui.define</code>'ed module. If the module definition would not execute synchronously, the synchronous contract of the require call would be broken (default behavior in existing UI5 applications)</li> <li>A single file must not contain multiple calls to <code>sap.ui.define</code>. Multiple calls currently are only supported in the so called 'preload' files that the UI5 merge tooling produces. The exact details of how this works might be changed in future implementations and are not yet part of the API contract</li> </ul>
			/// </summary>
			/// <param name="aDependencies">list of dependencies of the module</param>
			/// <param name="vFactory">the module value or a function that calculates the value</param>
			public extern static void define(string[] aDependencies, object vFactory);

			/// <summary>
			/// Defines a Javascript module with its name, its dependencies and a module value or factory.
			/// 
			/// The typical and only suggested usage of this method is to have one single, top level call to <code>sap.ui.define</code> in one Javascript resource (file). When a module is requested by its name for the first time, the corresponding resource is determined from the name and the current {@link jQuery.sap.registerResourcePath configuration}. The resource will be loaded and executed which in turn will execute the top level <code>sap.ui.define</code> call.
			/// 
			/// If the module name was omitted from that call, it will be substituted by the name that was used to request the module. As a preparation step, the dependencies as well as their transitive dependencies, will be loaded. Then, the module value will be determined: if a static value (object, literal) was given as <code>vFactory</code>, that value will be the module value. If a function was given, that function will be called (providing the module values of the declared dependencies as parameters to the function) and its return value will be used as module value. The framework internally associates the resulting value with the module name and provides it to the original requester of the module. Whenever the module is requested again, the same value will be returned (modules are executed only once).
			/// 
			/// <i>Example:</i><br> The following example defines a module "SomeClass", but doesn't hard code the module name. If stored in a file 'sap/mylib/SomeClass.js', it can be requested as 'sap/mylib/SomeClass'. <pre>
			///   sap.ui.define(['./Helper', 'sap/m/Bar'], function(Helper,Bar) {
			/// 
			///     // create a new class
			///     var SomeClass = function() {};
			/// 
			///     // add methods to its prototype
			///     SomeClass.prototype.foo = function() {
			/// 
			///         // use a function from the dependency 'Helper' in the same package (e.g. 'sap/mylib/Helper' )
			///         var mSettings = Helper.foo();
			/// 
			///         // create and return an sap.m.Bar (using its local name 'Bar')
			///         return new Bar(mSettings);
			/// 
			///     }
			/// 
			///     // return the class as module value
			///     return SomeClass;
			/// 
			///   });
			/// </pre>
			/// 
			/// In another module or in an application HTML page, the {@link sap.ui.require} API can be used to load the Something module and to work with it:
			/// 
			/// <pre>
			/// sap.ui.require(['sap/mylib/Something'], function(Something) {
			/// 
			///   // instantiate a Something and call foo() on it
			///   new Something().foo();
			/// 
			/// });
			/// </pre>
			/// 
			/// <h3>Module Name Syntax</h3>
			/// 
			/// <code>sap.ui.define</code> uses a simplified variant of the {@link jQuery.sap.getResourcePath unified resource name} syntax for the module's own name as well as for its dependencies. The only difference to that syntax is, that for <code>sap.ui.define</code> and <code>sap.ui.require</code>, the extension (which always would be '.js') has to be omitted. Both methods always add this extension internally.
			/// 
			/// As a convenience, the name of a dependency can start with the segment './' which will be replaced by the name of the package that contains the currently defined module (relative name).
			/// 
			/// It is best practice to omit the name of the defined module (first parameter) and to use relative names for the dependencies whenever possible. This reduces the necessary configuration, simplifies renaming of packages and allows to map them to a different namespace.
			/// 
			/// <h3>Dependency to Modules</h3>
			/// 
			/// If a dependencies array is given, each entry represents the name of another module that the currently defined module depends on. All dependency modules are loaded before the value of the currently defined module is determined. The module value of each dependency module will be provided as a parameter to a factory function, the order of the parameters will match the order of the modules in the dependencies array.
			/// 
			/// <b>Note:</b> the order in which the dependency modules are <i>executed</i> is <b>not</b> defined by the order in the dependencies array! The execution order is affected by dependencies <i>between</i> the dependency modules as well as by their current state (whether a module already has been loaded or not). Neither module implementations nor dependents that require a module set must make any assumption about the execution order (other than expressed by their dependencies). There is, however, one exception with regard to third party libraries, see the list of limitations further down below.
			/// 
			/// <b>Note:</b>a static module value (a literal provided to <code>sap.ui.define</code>) cannot depend on the module values of the dependency modules. Instead, modules can use a factory function, calculate the static value in that function, potentially based on the dependencies, and return the result as module value. The same approach must be taken when the module value is supposed to be a function.
			/// 
			/// <h3>Asynchronous Contract</h3> <code>sap.ui.define</code> is designed to support real Asynchronous Module Definitions (AMD) in future, although it internally still uses the old synchronous module loading of UI5. Callers of <code>sap.ui.define</code> therefore must not rely on any synchronous behavior that they might observe with the current implementation.
			/// 
			/// For example, callers of <code>sap.ui.define</code> must not use the module value immediately after invoking <code>sap.ui.define</code>:
			/// 
			/// <pre>
			///   // COUNTER EXAMPLE HOW __NOT__ TO DO IT
			/// 
			///   // define a class Something as AMD module
			///   sap.ui.define('Something', [], function() {
			///     var Something = function() {};
			///     return Something;
			///   });
			/// 
			///   // DON'T DO THAT!
			///   // accessing the class _synchronously_ after sap.ui.define was called
			///   new Something();
			/// </pre>
			/// 
			/// Applications that need to ensure synchronous module definition or synchronous loading of dependencies <b>MUST</b> use the old {@link jQuery.sap.declare} and {@link jQuery.sap.require} APIs.
			/// 
			/// <h3>(No) Global References</h3>
			/// 
			/// To be in line with AMD best practices, modules defined with <code>sap.ui.define</code> should not make any use of global variables if those variables are also available as module values. Instead, they should add dependencies to those modules and use the corresponding parameter of the factory function to access the module value.
			/// 
			/// As the current programming model and the documentation of UI5 heavily rely on global names, there will be a transition phase where UI5 enables AMD modules and local references to module values in parallel to the old global names. The fourth parameter of <code>sap.ui.define</code> has been added to support that transition phase. When this parameter is set to true, the framework provides two additional functionalities
			/// 
			/// <ol> <li>Before the factory function is called, the existence of the global parent namespace for the current module is ensured</li> <li>The module value will be automatically exported under a global name which is derived from the name of the module</li> </ol>
			/// 
			/// The parameter lets the framework know whether any of those two operations is needed or not. In future versions of UI5, a central configuration option is planned to suppress those 'exports'.
			/// 
			/// <h3>Third Party Modules</h3> Although third party modules don't use UI5 APIs, they still can be listed as dependencies in a <code>sap.ui.define</code> call. They will be requested and executed like UI5 modules, but their module value will be <code>undefined</code>.
			/// 
			/// If the currently defined module needs to access the module value of such a third party module, it can access the value via its global name (if the module supports such a usage).
			/// 
			/// Note that UI5 temporarily deactivates an existing AMD loader while it executes third party modules known to support AMD. This sounds contradictorily at a first glance as UI5 wants to support AMD, but for now it is necessary to fully support UI5 applications that rely on global names for such modules.
			/// 
			/// Example: <pre>
			///   // module 'Something' wants to use third party library 'URI.js'
			///   // It is packaged by UI5 as non-UI5-module 'sap/ui/thirdparty/URI'
			/// 
			///   sap.ui.define('Something', ['sap/ui/thirdparty/URI'], function(URIModuleValue) {
			/// 
			///     new URIModuleValue(); // fails as module value is undefined
			/// 
			///     //global URI // (optional) declare usage of global name so that static code checks don't complain
			///     new URI(); // access to global name 'URI' works
			/// 
			///     ...
			///   });
			/// </pre>
			/// 
			/// <h3>Differences to Standard AMD</h3>
			/// 
			/// The current implementation of <code>sap.ui.define</code> differs from the AMD specification (https://github.com/amdjs/amdjs-api) or from concrete AMD loaders like <code>requireJS</code> in several aspects: <ul> <li>The name <code>sap.ui.define</code> is different from the plain <code>define</code>. This has two reasons: first, it avoids the impression that <code>sap.ui.define</code> is an exact implementation of an AMD loader. And second, it allows the coexistence of an AMD loader (e.g. requireJS) and <code>sap.ui.define</code> in one application as long as UI5 or applications using UI5 are not fully prepared to run with an AMD loader. Note that the difference of the API names also implies that the UI5 loader can't be used to load 'real' AMD modules as they expect methods <code>define</code> and <code>require</code> to be available. Modules that use Unified Module Definition (UMD) syntax, can be loaded, but only when no AMD loader is present or when they expose their export also to the global namespace, even when an AMD loader is present (as e.g. jQuery does)</li> <li><code>sap.ui.define</code> currently loads modules with synchronous XHR calls. This is basically a tribute to the synchronous history of UI5. <b>BUT:</b> synchronous dependency loading and factory execution explicitly it not part of contract of <code>sap.ui.define</code>. To the contrary, it is already clear and planned that asynchronous loading will be implemented, at least as an alternative if not as the only implementation. Also check section <b>Asynchronous Contract</b> above.<br> Applications that need to ensure synchronous loading of dependencies <b>MUST</b> use the old {@link jQuery.sap.require} API.</li> <li><code>sap.ui.define</code> does not support plugins to use other file types, formats or protocols. It is not planned to support this in future</li> <li><code>sap.ui.define</code> does not support absolute URLs as module names (dependencies) nor does it allow module names that start with a slash. To refer to a module at an absolute URL, a resource root can be registered that points to that URL (or to a prefix of it).</li> <li><code>sap.ui.define</code> does <b>not</b> support the 'sugar' of requireJS where CommonJS style dependency declarations using <code>sap.ui.require("something")</code> are automagically converted into <code>sap.ui.define</code> dependencies before executing the factory function.</li> </ul>
			/// 
			/// <h3>Limitations, Design Considerations</h3> <ul> <li><b>Limitation</b>: as dependency management is not supported for Non-UI5 modules, the only way to ensure proper execution order for such modules currently is to rely on the order in the dependency array. Obviously, this only works as long as <code>sap.ui.define</code> uses synchronous loading. It will be enhanced when asynchronous loading is implemented.</li> <li>It was discussed to enforce asynchronous execution of the module factory function (e.g. with a timeout of 0). But this would have invalidated the current migration scenario where a sync <code>jQuery.sap.require</code> call can load a <code>sap.ui.define</code>'ed module. If the module definition would not execute synchronously, the synchronous contract of the require call would be broken (default behavior in existing UI5 applications)</li> <li>A single file must not contain multiple calls to <code>sap.ui.define</code>. Multiple calls currently are only supported in the so called 'preload' files that the UI5 merge tooling produces. The exact details of how this works might be changed in future implementations and are not yet part of the API contract</li> </ul>
			/// </summary>
			/// <param name="aDependencies">list of dependencies of the module</param>
			/// <param name="vFactory">the module value or a function that calculates the value</param>
			public extern static void define(object[] aDependencies, object vFactory);

			/// <summary>
			/// Defines a Javascript module with its name, its dependencies and a module value or factory.
			/// 
			/// The typical and only suggested usage of this method is to have one single, top level call to <code>sap.ui.define</code> in one Javascript resource (file). When a module is requested by its name for the first time, the corresponding resource is determined from the name and the current {@link jQuery.sap.registerResourcePath configuration}. The resource will be loaded and executed which in turn will execute the top level <code>sap.ui.define</code> call.
			/// 
			/// If the module name was omitted from that call, it will be substituted by the name that was used to request the module. As a preparation step, the dependencies as well as their transitive dependencies, will be loaded. Then, the module value will be determined: if a static value (object, literal) was given as <code>vFactory</code>, that value will be the module value. If a function was given, that function will be called (providing the module values of the declared dependencies as parameters to the function) and its return value will be used as module value. The framework internally associates the resulting value with the module name and provides it to the original requester of the module. Whenever the module is requested again, the same value will be returned (modules are executed only once).
			/// 
			/// <i>Example:</i><br> The following example defines a module "SomeClass", but doesn't hard code the module name. If stored in a file 'sap/mylib/SomeClass.js', it can be requested as 'sap/mylib/SomeClass'. <pre>
			///   sap.ui.define(['./Helper', 'sap/m/Bar'], function(Helper,Bar) {
			/// 
			///     // create a new class
			///     var SomeClass = function() {};
			/// 
			///     // add methods to its prototype
			///     SomeClass.prototype.foo = function() {
			/// 
			///         // use a function from the dependency 'Helper' in the same package (e.g. 'sap/mylib/Helper' )
			///         var mSettings = Helper.foo();
			/// 
			///         // create and return an sap.m.Bar (using its local name 'Bar')
			///         return new Bar(mSettings);
			/// 
			///     }
			/// 
			///     // return the class as module value
			///     return SomeClass;
			/// 
			///   });
			/// </pre>
			/// 
			/// In another module or in an application HTML page, the {@link sap.ui.require} API can be used to load the Something module and to work with it:
			/// 
			/// <pre>
			/// sap.ui.require(['sap/mylib/Something'], function(Something) {
			/// 
			///   // instantiate a Something and call foo() on it
			///   new Something().foo();
			/// 
			/// });
			/// </pre>
			/// 
			/// <h3>Module Name Syntax</h3>
			/// 
			/// <code>sap.ui.define</code> uses a simplified variant of the {@link jQuery.sap.getResourcePath unified resource name} syntax for the module's own name as well as for its dependencies. The only difference to that syntax is, that for <code>sap.ui.define</code> and <code>sap.ui.require</code>, the extension (which always would be '.js') has to be omitted. Both methods always add this extension internally.
			/// 
			/// As a convenience, the name of a dependency can start with the segment './' which will be replaced by the name of the package that contains the currently defined module (relative name).
			/// 
			/// It is best practice to omit the name of the defined module (first parameter) and to use relative names for the dependencies whenever possible. This reduces the necessary configuration, simplifies renaming of packages and allows to map them to a different namespace.
			/// 
			/// <h3>Dependency to Modules</h3>
			/// 
			/// If a dependencies array is given, each entry represents the name of another module that the currently defined module depends on. All dependency modules are loaded before the value of the currently defined module is determined. The module value of each dependency module will be provided as a parameter to a factory function, the order of the parameters will match the order of the modules in the dependencies array.
			/// 
			/// <b>Note:</b> the order in which the dependency modules are <i>executed</i> is <b>not</b> defined by the order in the dependencies array! The execution order is affected by dependencies <i>between</i> the dependency modules as well as by their current state (whether a module already has been loaded or not). Neither module implementations nor dependents that require a module set must make any assumption about the execution order (other than expressed by their dependencies). There is, however, one exception with regard to third party libraries, see the list of limitations further down below.
			/// 
			/// <b>Note:</b>a static module value (a literal provided to <code>sap.ui.define</code>) cannot depend on the module values of the dependency modules. Instead, modules can use a factory function, calculate the static value in that function, potentially based on the dependencies, and return the result as module value. The same approach must be taken when the module value is supposed to be a function.
			/// 
			/// <h3>Asynchronous Contract</h3> <code>sap.ui.define</code> is designed to support real Asynchronous Module Definitions (AMD) in future, although it internally still uses the old synchronous module loading of UI5. Callers of <code>sap.ui.define</code> therefore must not rely on any synchronous behavior that they might observe with the current implementation.
			/// 
			/// For example, callers of <code>sap.ui.define</code> must not use the module value immediately after invoking <code>sap.ui.define</code>:
			/// 
			/// <pre>
			///   // COUNTER EXAMPLE HOW __NOT__ TO DO IT
			/// 
			///   // define a class Something as AMD module
			///   sap.ui.define('Something', [], function() {
			///     var Something = function() {};
			///     return Something;
			///   });
			/// 
			///   // DON'T DO THAT!
			///   // accessing the class _synchronously_ after sap.ui.define was called
			///   new Something();
			/// </pre>
			/// 
			/// Applications that need to ensure synchronous module definition or synchronous loading of dependencies <b>MUST</b> use the old {@link jQuery.sap.declare} and {@link jQuery.sap.require} APIs.
			/// 
			/// <h3>(No) Global References</h3>
			/// 
			/// To be in line with AMD best practices, modules defined with <code>sap.ui.define</code> should not make any use of global variables if those variables are also available as module values. Instead, they should add dependencies to those modules and use the corresponding parameter of the factory function to access the module value.
			/// 
			/// As the current programming model and the documentation of UI5 heavily rely on global names, there will be a transition phase where UI5 enables AMD modules and local references to module values in parallel to the old global names. The fourth parameter of <code>sap.ui.define</code> has been added to support that transition phase. When this parameter is set to true, the framework provides two additional functionalities
			/// 
			/// <ol> <li>Before the factory function is called, the existence of the global parent namespace for the current module is ensured</li> <li>The module value will be automatically exported under a global name which is derived from the name of the module</li> </ol>
			/// 
			/// The parameter lets the framework know whether any of those two operations is needed or not. In future versions of UI5, a central configuration option is planned to suppress those 'exports'.
			/// 
			/// <h3>Third Party Modules</h3> Although third party modules don't use UI5 APIs, they still can be listed as dependencies in a <code>sap.ui.define</code> call. They will be requested and executed like UI5 modules, but their module value will be <code>undefined</code>.
			/// 
			/// If the currently defined module needs to access the module value of such a third party module, it can access the value via its global name (if the module supports such a usage).
			/// 
			/// Note that UI5 temporarily deactivates an existing AMD loader while it executes third party modules known to support AMD. This sounds contradictorily at a first glance as UI5 wants to support AMD, but for now it is necessary to fully support UI5 applications that rely on global names for such modules.
			/// 
			/// Example: <pre>
			///   // module 'Something' wants to use third party library 'URI.js'
			///   // It is packaged by UI5 as non-UI5-module 'sap/ui/thirdparty/URI'
			/// 
			///   sap.ui.define('Something', ['sap/ui/thirdparty/URI'], function(URIModuleValue) {
			/// 
			///     new URIModuleValue(); // fails as module value is undefined
			/// 
			///     //global URI // (optional) declare usage of global name so that static code checks don't complain
			///     new URI(); // access to global name 'URI' works
			/// 
			///     ...
			///   });
			/// </pre>
			/// 
			/// <h3>Differences to Standard AMD</h3>
			/// 
			/// The current implementation of <code>sap.ui.define</code> differs from the AMD specification (https://github.com/amdjs/amdjs-api) or from concrete AMD loaders like <code>requireJS</code> in several aspects: <ul> <li>The name <code>sap.ui.define</code> is different from the plain <code>define</code>. This has two reasons: first, it avoids the impression that <code>sap.ui.define</code> is an exact implementation of an AMD loader. And second, it allows the coexistence of an AMD loader (e.g. requireJS) and <code>sap.ui.define</code> in one application as long as UI5 or applications using UI5 are not fully prepared to run with an AMD loader. Note that the difference of the API names also implies that the UI5 loader can't be used to load 'real' AMD modules as they expect methods <code>define</code> and <code>require</code> to be available. Modules that use Unified Module Definition (UMD) syntax, can be loaded, but only when no AMD loader is present or when they expose their export also to the global namespace, even when an AMD loader is present (as e.g. jQuery does)</li> <li><code>sap.ui.define</code> currently loads modules with synchronous XHR calls. This is basically a tribute to the synchronous history of UI5. <b>BUT:</b> synchronous dependency loading and factory execution explicitly it not part of contract of <code>sap.ui.define</code>. To the contrary, it is already clear and planned that asynchronous loading will be implemented, at least as an alternative if not as the only implementation. Also check section <b>Asynchronous Contract</b> above.<br> Applications that need to ensure synchronous loading of dependencies <b>MUST</b> use the old {@link jQuery.sap.require} API.</li> <li><code>sap.ui.define</code> does not support plugins to use other file types, formats or protocols. It is not planned to support this in future</li> <li><code>sap.ui.define</code> does not support absolute URLs as module names (dependencies) nor does it allow module names that start with a slash. To refer to a module at an absolute URL, a resource root can be registered that points to that URL (or to a prefix of it).</li> <li><code>sap.ui.define</code> does <b>not</b> support the 'sugar' of requireJS where CommonJS style dependency declarations using <code>sap.ui.require("something")</code> are automagically converted into <code>sap.ui.define</code> dependencies before executing the factory function.</li> </ul>
			/// 
			/// <h3>Limitations, Design Considerations</h3> <ul> <li><b>Limitation</b>: as dependency management is not supported for Non-UI5 modules, the only way to ensure proper execution order for such modules currently is to rely on the order in the dependency array. Obviously, this only works as long as <code>sap.ui.define</code> uses synchronous loading. It will be enhanced when asynchronous loading is implemented.</li> <li>It was discussed to enforce asynchronous execution of the module factory function (e.g. with a timeout of 0). But this would have invalidated the current migration scenario where a sync <code>jQuery.sap.require</code> call can load a <code>sap.ui.define</code>'ed module. If the module definition would not execute synchronously, the synchronous contract of the require call would be broken (default behavior in existing UI5 applications)</li> <li>A single file must not contain multiple calls to <code>sap.ui.define</code>. Multiple calls currently are only supported in the so called 'preload' files that the UI5 merge tooling produces. The exact details of how this works might be changed in future implementations and are not yet part of the API contract</li> </ul>
			/// </summary>
			/// <param name="vFactory">the module value or a function that calculates the value</param>
			public extern static void define(object vFactory);

			/// <summary>
			/// Defines a Javascript module with its name, its dependencies and a module value or factory.
			/// 
			/// The typical and only suggested usage of this method is to have one single, top level call to <code>sap.ui.define</code> in one Javascript resource (file). When a module is requested by its name for the first time, the corresponding resource is determined from the name and the current {@link jQuery.sap.registerResourcePath configuration}. The resource will be loaded and executed which in turn will execute the top level <code>sap.ui.define</code> call.
			/// 
			/// If the module name was omitted from that call, it will be substituted by the name that was used to request the module. As a preparation step, the dependencies as well as their transitive dependencies, will be loaded. Then, the module value will be determined: if a static value (object, literal) was given as <code>vFactory</code>, that value will be the module value. If a function was given, that function will be called (providing the module values of the declared dependencies as parameters to the function) and its return value will be used as module value. The framework internally associates the resulting value with the module name and provides it to the original requester of the module. Whenever the module is requested again, the same value will be returned (modules are executed only once).
			/// 
			/// <i>Example:</i><br> The following example defines a module "SomeClass", but doesn't hard code the module name. If stored in a file 'sap/mylib/SomeClass.js', it can be requested as 'sap/mylib/SomeClass'. <pre>
			///   sap.ui.define(['./Helper', 'sap/m/Bar'], function(Helper,Bar) {
			/// 
			///     // create a new class
			///     var SomeClass = function() {};
			/// 
			///     // add methods to its prototype
			///     SomeClass.prototype.foo = function() {
			/// 
			///         // use a function from the dependency 'Helper' in the same package (e.g. 'sap/mylib/Helper' )
			///         var mSettings = Helper.foo();
			/// 
			///         // create and return an sap.m.Bar (using its local name 'Bar')
			///         return new Bar(mSettings);
			/// 
			///     }
			/// 
			///     // return the class as module value
			///     return SomeClass;
			/// 
			///   });
			/// </pre>
			/// 
			/// In another module or in an application HTML page, the {@link sap.ui.require} API can be used to load the Something module and to work with it:
			/// 
			/// <pre>
			/// sap.ui.require(['sap/mylib/Something'], function(Something) {
			/// 
			///   // instantiate a Something and call foo() on it
			///   new Something().foo();
			/// 
			/// });
			/// </pre>
			/// 
			/// <h3>Module Name Syntax</h3>
			/// 
			/// <code>sap.ui.define</code> uses a simplified variant of the {@link jQuery.sap.getResourcePath unified resource name} syntax for the module's own name as well as for its dependencies. The only difference to that syntax is, that for <code>sap.ui.define</code> and <code>sap.ui.require</code>, the extension (which always would be '.js') has to be omitted. Both methods always add this extension internally.
			/// 
			/// As a convenience, the name of a dependency can start with the segment './' which will be replaced by the name of the package that contains the currently defined module (relative name).
			/// 
			/// It is best practice to omit the name of the defined module (first parameter) and to use relative names for the dependencies whenever possible. This reduces the necessary configuration, simplifies renaming of packages and allows to map them to a different namespace.
			/// 
			/// <h3>Dependency to Modules</h3>
			/// 
			/// If a dependencies array is given, each entry represents the name of another module that the currently defined module depends on. All dependency modules are loaded before the value of the currently defined module is determined. The module value of each dependency module will be provided as a parameter to a factory function, the order of the parameters will match the order of the modules in the dependencies array.
			/// 
			/// <b>Note:</b> the order in which the dependency modules are <i>executed</i> is <b>not</b> defined by the order in the dependencies array! The execution order is affected by dependencies <i>between</i> the dependency modules as well as by their current state (whether a module already has been loaded or not). Neither module implementations nor dependents that require a module set must make any assumption about the execution order (other than expressed by their dependencies). There is, however, one exception with regard to third party libraries, see the list of limitations further down below.
			/// 
			/// <b>Note:</b>a static module value (a literal provided to <code>sap.ui.define</code>) cannot depend on the module values of the dependency modules. Instead, modules can use a factory function, calculate the static value in that function, potentially based on the dependencies, and return the result as module value. The same approach must be taken when the module value is supposed to be a function.
			/// 
			/// <h3>Asynchronous Contract</h3> <code>sap.ui.define</code> is designed to support real Asynchronous Module Definitions (AMD) in future, although it internally still uses the old synchronous module loading of UI5. Callers of <code>sap.ui.define</code> therefore must not rely on any synchronous behavior that they might observe with the current implementation.
			/// 
			/// For example, callers of <code>sap.ui.define</code> must not use the module value immediately after invoking <code>sap.ui.define</code>:
			/// 
			/// <pre>
			///   // COUNTER EXAMPLE HOW __NOT__ TO DO IT
			/// 
			///   // define a class Something as AMD module
			///   sap.ui.define('Something', [], function() {
			///     var Something = function() {};
			///     return Something;
			///   });
			/// 
			///   // DON'T DO THAT!
			///   // accessing the class _synchronously_ after sap.ui.define was called
			///   new Something();
			/// </pre>
			/// 
			/// Applications that need to ensure synchronous module definition or synchronous loading of dependencies <b>MUST</b> use the old {@link jQuery.sap.declare} and {@link jQuery.sap.require} APIs.
			/// 
			/// <h3>(No) Global References</h3>
			/// 
			/// To be in line with AMD best practices, modules defined with <code>sap.ui.define</code> should not make any use of global variables if those variables are also available as module values. Instead, they should add dependencies to those modules and use the corresponding parameter of the factory function to access the module value.
			/// 
			/// As the current programming model and the documentation of UI5 heavily rely on global names, there will be a transition phase where UI5 enables AMD modules and local references to module values in parallel to the old global names. The fourth parameter of <code>sap.ui.define</code> has been added to support that transition phase. When this parameter is set to true, the framework provides two additional functionalities
			/// 
			/// <ol> <li>Before the factory function is called, the existence of the global parent namespace for the current module is ensured</li> <li>The module value will be automatically exported under a global name which is derived from the name of the module</li> </ol>
			/// 
			/// The parameter lets the framework know whether any of those two operations is needed or not. In future versions of UI5, a central configuration option is planned to suppress those 'exports'.
			/// 
			/// <h3>Third Party Modules</h3> Although third party modules don't use UI5 APIs, they still can be listed as dependencies in a <code>sap.ui.define</code> call. They will be requested and executed like UI5 modules, but their module value will be <code>undefined</code>.
			/// 
			/// If the currently defined module needs to access the module value of such a third party module, it can access the value via its global name (if the module supports such a usage).
			/// 
			/// Note that UI5 temporarily deactivates an existing AMD loader while it executes third party modules known to support AMD. This sounds contradictorily at a first glance as UI5 wants to support AMD, but for now it is necessary to fully support UI5 applications that rely on global names for such modules.
			/// 
			/// Example: <pre>
			///   // module 'Something' wants to use third party library 'URI.js'
			///   // It is packaged by UI5 as non-UI5-module 'sap/ui/thirdparty/URI'
			/// 
			///   sap.ui.define('Something', ['sap/ui/thirdparty/URI'], function(URIModuleValue) {
			/// 
			///     new URIModuleValue(); // fails as module value is undefined
			/// 
			///     //global URI // (optional) declare usage of global name so that static code checks don't complain
			///     new URI(); // access to global name 'URI' works
			/// 
			///     ...
			///   });
			/// </pre>
			/// 
			/// <h3>Differences to Standard AMD</h3>
			/// 
			/// The current implementation of <code>sap.ui.define</code> differs from the AMD specification (https://github.com/amdjs/amdjs-api) or from concrete AMD loaders like <code>requireJS</code> in several aspects: <ul> <li>The name <code>sap.ui.define</code> is different from the plain <code>define</code>. This has two reasons: first, it avoids the impression that <code>sap.ui.define</code> is an exact implementation of an AMD loader. And second, it allows the coexistence of an AMD loader (e.g. requireJS) and <code>sap.ui.define</code> in one application as long as UI5 or applications using UI5 are not fully prepared to run with an AMD loader. Note that the difference of the API names also implies that the UI5 loader can't be used to load 'real' AMD modules as they expect methods <code>define</code> and <code>require</code> to be available. Modules that use Unified Module Definition (UMD) syntax, can be loaded, but only when no AMD loader is present or when they expose their export also to the global namespace, even when an AMD loader is present (as e.g. jQuery does)</li> <li><code>sap.ui.define</code> currently loads modules with synchronous XHR calls. This is basically a tribute to the synchronous history of UI5. <b>BUT:</b> synchronous dependency loading and factory execution explicitly it not part of contract of <code>sap.ui.define</code>. To the contrary, it is already clear and planned that asynchronous loading will be implemented, at least as an alternative if not as the only implementation. Also check section <b>Asynchronous Contract</b> above.<br> Applications that need to ensure synchronous loading of dependencies <b>MUST</b> use the old {@link jQuery.sap.require} API.</li> <li><code>sap.ui.define</code> does not support plugins to use other file types, formats or protocols. It is not planned to support this in future</li> <li><code>sap.ui.define</code> does not support absolute URLs as module names (dependencies) nor does it allow module names that start with a slash. To refer to a module at an absolute URL, a resource root can be registered that points to that URL (or to a prefix of it).</li> <li><code>sap.ui.define</code> does <b>not</b> support the 'sugar' of requireJS where CommonJS style dependency declarations using <code>sap.ui.require("something")</code> are automagically converted into <code>sap.ui.define</code> dependencies before executing the factory function.</li> </ul>
			/// 
			/// <h3>Limitations, Design Considerations</h3> <ul> <li><b>Limitation</b>: as dependency management is not supported for Non-UI5 modules, the only way to ensure proper execution order for such modules currently is to rely on the order in the dependency array. Obviously, this only works as long as <code>sap.ui.define</code> uses synchronous loading. It will be enhanced when asynchronous loading is implemented.</li> <li>It was discussed to enforce asynchronous execution of the module factory function (e.g. with a timeout of 0). But this would have invalidated the current migration scenario where a sync <code>jQuery.sap.require</code> call can load a <code>sap.ui.define</code>'ed module. If the module definition would not execute synchronously, the synchronous contract of the require call would be broken (default behavior in existing UI5 applications)</li> <li>A single file must not contain multiple calls to <code>sap.ui.define</code>. Multiple calls currently are only supported in the so called 'preload' files that the UI5 merge tooling produces. The exact details of how this works might be changed in future implementations and are not yet part of the API contract</li> </ul>
			/// </summary>
			/// <param name="aDependencies">list of dependencies of the module</param>
			/// <param name="vFactory">the module value or a function that calculates the value</param>
			/// <param name="bExport">whether an export to global names is required - should be used by SAP-owned code only</param>
			public extern static void define(string[] aDependencies, object vFactory, bool bExport);

			/// <summary>
			/// Defines a Javascript module with its name, its dependencies and a module value or factory.
			/// 
			/// The typical and only suggested usage of this method is to have one single, top level call to <code>sap.ui.define</code> in one Javascript resource (file). When a module is requested by its name for the first time, the corresponding resource is determined from the name and the current {@link jQuery.sap.registerResourcePath configuration}. The resource will be loaded and executed which in turn will execute the top level <code>sap.ui.define</code> call.
			/// 
			/// If the module name was omitted from that call, it will be substituted by the name that was used to request the module. As a preparation step, the dependencies as well as their transitive dependencies, will be loaded. Then, the module value will be determined: if a static value (object, literal) was given as <code>vFactory</code>, that value will be the module value. If a function was given, that function will be called (providing the module values of the declared dependencies as parameters to the function) and its return value will be used as module value. The framework internally associates the resulting value with the module name and provides it to the original requester of the module. Whenever the module is requested again, the same value will be returned (modules are executed only once).
			/// 
			/// <i>Example:</i><br> The following example defines a module "SomeClass", but doesn't hard code the module name. If stored in a file 'sap/mylib/SomeClass.js', it can be requested as 'sap/mylib/SomeClass'. <pre>
			///   sap.ui.define(['./Helper', 'sap/m/Bar'], function(Helper,Bar) {
			/// 
			///     // create a new class
			///     var SomeClass = function() {};
			/// 
			///     // add methods to its prototype
			///     SomeClass.prototype.foo = function() {
			/// 
			///         // use a function from the dependency 'Helper' in the same package (e.g. 'sap/mylib/Helper' )
			///         var mSettings = Helper.foo();
			/// 
			///         // create and return an sap.m.Bar (using its local name 'Bar')
			///         return new Bar(mSettings);
			/// 
			///     }
			/// 
			///     // return the class as module value
			///     return SomeClass;
			/// 
			///   });
			/// </pre>
			/// 
			/// In another module or in an application HTML page, the {@link sap.ui.require} API can be used to load the Something module and to work with it:
			/// 
			/// <pre>
			/// sap.ui.require(['sap/mylib/Something'], function(Something) {
			/// 
			///   // instantiate a Something and call foo() on it
			///   new Something().foo();
			/// 
			/// });
			/// </pre>
			/// 
			/// <h3>Module Name Syntax</h3>
			/// 
			/// <code>sap.ui.define</code> uses a simplified variant of the {@link jQuery.sap.getResourcePath unified resource name} syntax for the module's own name as well as for its dependencies. The only difference to that syntax is, that for <code>sap.ui.define</code> and <code>sap.ui.require</code>, the extension (which always would be '.js') has to be omitted. Both methods always add this extension internally.
			/// 
			/// As a convenience, the name of a dependency can start with the segment './' which will be replaced by the name of the package that contains the currently defined module (relative name).
			/// 
			/// It is best practice to omit the name of the defined module (first parameter) and to use relative names for the dependencies whenever possible. This reduces the necessary configuration, simplifies renaming of packages and allows to map them to a different namespace.
			/// 
			/// <h3>Dependency to Modules</h3>
			/// 
			/// If a dependencies array is given, each entry represents the name of another module that the currently defined module depends on. All dependency modules are loaded before the value of the currently defined module is determined. The module value of each dependency module will be provided as a parameter to a factory function, the order of the parameters will match the order of the modules in the dependencies array.
			/// 
			/// <b>Note:</b> the order in which the dependency modules are <i>executed</i> is <b>not</b> defined by the order in the dependencies array! The execution order is affected by dependencies <i>between</i> the dependency modules as well as by their current state (whether a module already has been loaded or not). Neither module implementations nor dependents that require a module set must make any assumption about the execution order (other than expressed by their dependencies). There is, however, one exception with regard to third party libraries, see the list of limitations further down below.
			/// 
			/// <b>Note:</b>a static module value (a literal provided to <code>sap.ui.define</code>) cannot depend on the module values of the dependency modules. Instead, modules can use a factory function, calculate the static value in that function, potentially based on the dependencies, and return the result as module value. The same approach must be taken when the module value is supposed to be a function.
			/// 
			/// <h3>Asynchronous Contract</h3> <code>sap.ui.define</code> is designed to support real Asynchronous Module Definitions (AMD) in future, although it internally still uses the old synchronous module loading of UI5. Callers of <code>sap.ui.define</code> therefore must not rely on any synchronous behavior that they might observe with the current implementation.
			/// 
			/// For example, callers of <code>sap.ui.define</code> must not use the module value immediately after invoking <code>sap.ui.define</code>:
			/// 
			/// <pre>
			///   // COUNTER EXAMPLE HOW __NOT__ TO DO IT
			/// 
			///   // define a class Something as AMD module
			///   sap.ui.define('Something', [], function() {
			///     var Something = function() {};
			///     return Something;
			///   });
			/// 
			///   // DON'T DO THAT!
			///   // accessing the class _synchronously_ after sap.ui.define was called
			///   new Something();
			/// </pre>
			/// 
			/// Applications that need to ensure synchronous module definition or synchronous loading of dependencies <b>MUST</b> use the old {@link jQuery.sap.declare} and {@link jQuery.sap.require} APIs.
			/// 
			/// <h3>(No) Global References</h3>
			/// 
			/// To be in line with AMD best practices, modules defined with <code>sap.ui.define</code> should not make any use of global variables if those variables are also available as module values. Instead, they should add dependencies to those modules and use the corresponding parameter of the factory function to access the module value.
			/// 
			/// As the current programming model and the documentation of UI5 heavily rely on global names, there will be a transition phase where UI5 enables AMD modules and local references to module values in parallel to the old global names. The fourth parameter of <code>sap.ui.define</code> has been added to support that transition phase. When this parameter is set to true, the framework provides two additional functionalities
			/// 
			/// <ol> <li>Before the factory function is called, the existence of the global parent namespace for the current module is ensured</li> <li>The module value will be automatically exported under a global name which is derived from the name of the module</li> </ol>
			/// 
			/// The parameter lets the framework know whether any of those two operations is needed or not. In future versions of UI5, a central configuration option is planned to suppress those 'exports'.
			/// 
			/// <h3>Third Party Modules</h3> Although third party modules don't use UI5 APIs, they still can be listed as dependencies in a <code>sap.ui.define</code> call. They will be requested and executed like UI5 modules, but their module value will be <code>undefined</code>.
			/// 
			/// If the currently defined module needs to access the module value of such a third party module, it can access the value via its global name (if the module supports such a usage).
			/// 
			/// Note that UI5 temporarily deactivates an existing AMD loader while it executes third party modules known to support AMD. This sounds contradictorily at a first glance as UI5 wants to support AMD, but for now it is necessary to fully support UI5 applications that rely on global names for such modules.
			/// 
			/// Example: <pre>
			///   // module 'Something' wants to use third party library 'URI.js'
			///   // It is packaged by UI5 as non-UI5-module 'sap/ui/thirdparty/URI'
			/// 
			///   sap.ui.define('Something', ['sap/ui/thirdparty/URI'], function(URIModuleValue) {
			/// 
			///     new URIModuleValue(); // fails as module value is undefined
			/// 
			///     //global URI // (optional) declare usage of global name so that static code checks don't complain
			///     new URI(); // access to global name 'URI' works
			/// 
			///     ...
			///   });
			/// </pre>
			/// 
			/// <h3>Differences to Standard AMD</h3>
			/// 
			/// The current implementation of <code>sap.ui.define</code> differs from the AMD specification (https://github.com/amdjs/amdjs-api) or from concrete AMD loaders like <code>requireJS</code> in several aspects: <ul> <li>The name <code>sap.ui.define</code> is different from the plain <code>define</code>. This has two reasons: first, it avoids the impression that <code>sap.ui.define</code> is an exact implementation of an AMD loader. And second, it allows the coexistence of an AMD loader (e.g. requireJS) and <code>sap.ui.define</code> in one application as long as UI5 or applications using UI5 are not fully prepared to run with an AMD loader. Note that the difference of the API names also implies that the UI5 loader can't be used to load 'real' AMD modules as they expect methods <code>define</code> and <code>require</code> to be available. Modules that use Unified Module Definition (UMD) syntax, can be loaded, but only when no AMD loader is present or when they expose their export also to the global namespace, even when an AMD loader is present (as e.g. jQuery does)</li> <li><code>sap.ui.define</code> currently loads modules with synchronous XHR calls. This is basically a tribute to the synchronous history of UI5. <b>BUT:</b> synchronous dependency loading and factory execution explicitly it not part of contract of <code>sap.ui.define</code>. To the contrary, it is already clear and planned that asynchronous loading will be implemented, at least as an alternative if not as the only implementation. Also check section <b>Asynchronous Contract</b> above.<br> Applications that need to ensure synchronous loading of dependencies <b>MUST</b> use the old {@link jQuery.sap.require} API.</li> <li><code>sap.ui.define</code> does not support plugins to use other file types, formats or protocols. It is not planned to support this in future</li> <li><code>sap.ui.define</code> does not support absolute URLs as module names (dependencies) nor does it allow module names that start with a slash. To refer to a module at an absolute URL, a resource root can be registered that points to that URL (or to a prefix of it).</li> <li><code>sap.ui.define</code> does <b>not</b> support the 'sugar' of requireJS where CommonJS style dependency declarations using <code>sap.ui.require("something")</code> are automagically converted into <code>sap.ui.define</code> dependencies before executing the factory function.</li> </ul>
			/// 
			/// <h3>Limitations, Design Considerations</h3> <ul> <li><b>Limitation</b>: as dependency management is not supported for Non-UI5 modules, the only way to ensure proper execution order for such modules currently is to rely on the order in the dependency array. Obviously, this only works as long as <code>sap.ui.define</code> uses synchronous loading. It will be enhanced when asynchronous loading is implemented.</li> <li>It was discussed to enforce asynchronous execution of the module factory function (e.g. with a timeout of 0). But this would have invalidated the current migration scenario where a sync <code>jQuery.sap.require</code> call can load a <code>sap.ui.define</code>'ed module. If the module definition would not execute synchronously, the synchronous contract of the require call would be broken (default behavior in existing UI5 applications)</li> <li>A single file must not contain multiple calls to <code>sap.ui.define</code>. Multiple calls currently are only supported in the so called 'preload' files that the UI5 merge tooling produces. The exact details of how this works might be changed in future implementations and are not yet part of the API contract</li> </ul>
			/// </summary>
			/// <param name="aDependencies">list of dependencies of the module</param>
			/// <param name="vFactory">the module value or a function that calculates the value</param>
			/// <param name="bExport">whether an export to global names is required - should be used by SAP-owned code only</param>
			public extern static void define(object[] aDependencies, object vFactory, bool bExport);

			/// <summary>
			/// Defines a Javascript module with its name, its dependencies and a module value or factory.
			/// 
			/// The typical and only suggested usage of this method is to have one single, top level call to <code>sap.ui.define</code> in one Javascript resource (file). When a module is requested by its name for the first time, the corresponding resource is determined from the name and the current {@link jQuery.sap.registerResourcePath configuration}. The resource will be loaded and executed which in turn will execute the top level <code>sap.ui.define</code> call.
			/// 
			/// If the module name was omitted from that call, it will be substituted by the name that was used to request the module. As a preparation step, the dependencies as well as their transitive dependencies, will be loaded. Then, the module value will be determined: if a static value (object, literal) was given as <code>vFactory</code>, that value will be the module value. If a function was given, that function will be called (providing the module values of the declared dependencies as parameters to the function) and its return value will be used as module value. The framework internally associates the resulting value with the module name and provides it to the original requester of the module. Whenever the module is requested again, the same value will be returned (modules are executed only once).
			/// 
			/// <i>Example:</i><br> The following example defines a module "SomeClass", but doesn't hard code the module name. If stored in a file 'sap/mylib/SomeClass.js', it can be requested as 'sap/mylib/SomeClass'. <pre>
			///   sap.ui.define(['./Helper', 'sap/m/Bar'], function(Helper,Bar) {
			/// 
			///     // create a new class
			///     var SomeClass = function() {};
			/// 
			///     // add methods to its prototype
			///     SomeClass.prototype.foo = function() {
			/// 
			///         // use a function from the dependency 'Helper' in the same package (e.g. 'sap/mylib/Helper' )
			///         var mSettings = Helper.foo();
			/// 
			///         // create and return an sap.m.Bar (using its local name 'Bar')
			///         return new Bar(mSettings);
			/// 
			///     }
			/// 
			///     // return the class as module value
			///     return SomeClass;
			/// 
			///   });
			/// </pre>
			/// 
			/// In another module or in an application HTML page, the {@link sap.ui.require} API can be used to load the Something module and to work with it:
			/// 
			/// <pre>
			/// sap.ui.require(['sap/mylib/Something'], function(Something) {
			/// 
			///   // instantiate a Something and call foo() on it
			///   new Something().foo();
			/// 
			/// });
			/// </pre>
			/// 
			/// <h3>Module Name Syntax</h3>
			/// 
			/// <code>sap.ui.define</code> uses a simplified variant of the {@link jQuery.sap.getResourcePath unified resource name} syntax for the module's own name as well as for its dependencies. The only difference to that syntax is, that for <code>sap.ui.define</code> and <code>sap.ui.require</code>, the extension (which always would be '.js') has to be omitted. Both methods always add this extension internally.
			/// 
			/// As a convenience, the name of a dependency can start with the segment './' which will be replaced by the name of the package that contains the currently defined module (relative name).
			/// 
			/// It is best practice to omit the name of the defined module (first parameter) and to use relative names for the dependencies whenever possible. This reduces the necessary configuration, simplifies renaming of packages and allows to map them to a different namespace.
			/// 
			/// <h3>Dependency to Modules</h3>
			/// 
			/// If a dependencies array is given, each entry represents the name of another module that the currently defined module depends on. All dependency modules are loaded before the value of the currently defined module is determined. The module value of each dependency module will be provided as a parameter to a factory function, the order of the parameters will match the order of the modules in the dependencies array.
			/// 
			/// <b>Note:</b> the order in which the dependency modules are <i>executed</i> is <b>not</b> defined by the order in the dependencies array! The execution order is affected by dependencies <i>between</i> the dependency modules as well as by their current state (whether a module already has been loaded or not). Neither module implementations nor dependents that require a module set must make any assumption about the execution order (other than expressed by their dependencies). There is, however, one exception with regard to third party libraries, see the list of limitations further down below.
			/// 
			/// <b>Note:</b>a static module value (a literal provided to <code>sap.ui.define</code>) cannot depend on the module values of the dependency modules. Instead, modules can use a factory function, calculate the static value in that function, potentially based on the dependencies, and return the result as module value. The same approach must be taken when the module value is supposed to be a function.
			/// 
			/// <h3>Asynchronous Contract</h3> <code>sap.ui.define</code> is designed to support real Asynchronous Module Definitions (AMD) in future, although it internally still uses the old synchronous module loading of UI5. Callers of <code>sap.ui.define</code> therefore must not rely on any synchronous behavior that they might observe with the current implementation.
			/// 
			/// For example, callers of <code>sap.ui.define</code> must not use the module value immediately after invoking <code>sap.ui.define</code>:
			/// 
			/// <pre>
			///   // COUNTER EXAMPLE HOW __NOT__ TO DO IT
			/// 
			///   // define a class Something as AMD module
			///   sap.ui.define('Something', [], function() {
			///     var Something = function() {};
			///     return Something;
			///   });
			/// 
			///   // DON'T DO THAT!
			///   // accessing the class _synchronously_ after sap.ui.define was called
			///   new Something();
			/// </pre>
			/// 
			/// Applications that need to ensure synchronous module definition or synchronous loading of dependencies <b>MUST</b> use the old {@link jQuery.sap.declare} and {@link jQuery.sap.require} APIs.
			/// 
			/// <h3>(No) Global References</h3>
			/// 
			/// To be in line with AMD best practices, modules defined with <code>sap.ui.define</code> should not make any use of global variables if those variables are also available as module values. Instead, they should add dependencies to those modules and use the corresponding parameter of the factory function to access the module value.
			/// 
			/// As the current programming model and the documentation of UI5 heavily rely on global names, there will be a transition phase where UI5 enables AMD modules and local references to module values in parallel to the old global names. The fourth parameter of <code>sap.ui.define</code> has been added to support that transition phase. When this parameter is set to true, the framework provides two additional functionalities
			/// 
			/// <ol> <li>Before the factory function is called, the existence of the global parent namespace for the current module is ensured</li> <li>The module value will be automatically exported under a global name which is derived from the name of the module</li> </ol>
			/// 
			/// The parameter lets the framework know whether any of those two operations is needed or not. In future versions of UI5, a central configuration option is planned to suppress those 'exports'.
			/// 
			/// <h3>Third Party Modules</h3> Although third party modules don't use UI5 APIs, they still can be listed as dependencies in a <code>sap.ui.define</code> call. They will be requested and executed like UI5 modules, but their module value will be <code>undefined</code>.
			/// 
			/// If the currently defined module needs to access the module value of such a third party module, it can access the value via its global name (if the module supports such a usage).
			/// 
			/// Note that UI5 temporarily deactivates an existing AMD loader while it executes third party modules known to support AMD. This sounds contradictorily at a first glance as UI5 wants to support AMD, but for now it is necessary to fully support UI5 applications that rely on global names for such modules.
			/// 
			/// Example: <pre>
			///   // module 'Something' wants to use third party library 'URI.js'
			///   // It is packaged by UI5 as non-UI5-module 'sap/ui/thirdparty/URI'
			/// 
			///   sap.ui.define('Something', ['sap/ui/thirdparty/URI'], function(URIModuleValue) {
			/// 
			///     new URIModuleValue(); // fails as module value is undefined
			/// 
			///     //global URI // (optional) declare usage of global name so that static code checks don't complain
			///     new URI(); // access to global name 'URI' works
			/// 
			///     ...
			///   });
			/// </pre>
			/// 
			/// <h3>Differences to Standard AMD</h3>
			/// 
			/// The current implementation of <code>sap.ui.define</code> differs from the AMD specification (https://github.com/amdjs/amdjs-api) or from concrete AMD loaders like <code>requireJS</code> in several aspects: <ul> <li>The name <code>sap.ui.define</code> is different from the plain <code>define</code>. This has two reasons: first, it avoids the impression that <code>sap.ui.define</code> is an exact implementation of an AMD loader. And second, it allows the coexistence of an AMD loader (e.g. requireJS) and <code>sap.ui.define</code> in one application as long as UI5 or applications using UI5 are not fully prepared to run with an AMD loader. Note that the difference of the API names also implies that the UI5 loader can't be used to load 'real' AMD modules as they expect methods <code>define</code> and <code>require</code> to be available. Modules that use Unified Module Definition (UMD) syntax, can be loaded, but only when no AMD loader is present or when they expose their export also to the global namespace, even when an AMD loader is present (as e.g. jQuery does)</li> <li><code>sap.ui.define</code> currently loads modules with synchronous XHR calls. This is basically a tribute to the synchronous history of UI5. <b>BUT:</b> synchronous dependency loading and factory execution explicitly it not part of contract of <code>sap.ui.define</code>. To the contrary, it is already clear and planned that asynchronous loading will be implemented, at least as an alternative if not as the only implementation. Also check section <b>Asynchronous Contract</b> above.<br> Applications that need to ensure synchronous loading of dependencies <b>MUST</b> use the old {@link jQuery.sap.require} API.</li> <li><code>sap.ui.define</code> does not support plugins to use other file types, formats or protocols. It is not planned to support this in future</li> <li><code>sap.ui.define</code> does not support absolute URLs as module names (dependencies) nor does it allow module names that start with a slash. To refer to a module at an absolute URL, a resource root can be registered that points to that URL (or to a prefix of it).</li> <li><code>sap.ui.define</code> does <b>not</b> support the 'sugar' of requireJS where CommonJS style dependency declarations using <code>sap.ui.require("something")</code> are automagically converted into <code>sap.ui.define</code> dependencies before executing the factory function.</li> </ul>
			/// 
			/// <h3>Limitations, Design Considerations</h3> <ul> <li><b>Limitation</b>: as dependency management is not supported for Non-UI5 modules, the only way to ensure proper execution order for such modules currently is to rely on the order in the dependency array. Obviously, this only works as long as <code>sap.ui.define</code> uses synchronous loading. It will be enhanced when asynchronous loading is implemented.</li> <li>It was discussed to enforce asynchronous execution of the module factory function (e.g. with a timeout of 0). But this would have invalidated the current migration scenario where a sync <code>jQuery.sap.require</code> call can load a <code>sap.ui.define</code>'ed module. If the module definition would not execute synchronously, the synchronous contract of the require call would be broken (default behavior in existing UI5 applications)</li> <li>A single file must not contain multiple calls to <code>sap.ui.define</code>. Multiple calls currently are only supported in the so called 'preload' files that the UI5 merge tooling produces. The exact details of how this works might be changed in future implementations and are not yet part of the API contract</li> </ul>
			/// </summary>
			/// <param name="vFactory">the module value or a function that calculates the value</param>
			/// <param name="bExport">whether an export to global names is required - should be used by SAP-owned code only</param>
			public extern static void define(object vFactory, bool bExport);

			/// <summary>
			/// Resolves one or more module dependencies.
			/// 
			/// <b>Synchronous Retrieval of a Single Module Value</b>
			/// 
			/// When called with a single string, that string is assumed to be the name of an already loaded module and the value of that module is returned. If the module has not been loaded yet, or if it is a Non-UI5 module (e.g. third party module), <code>undefined</code> is returned. This signature variant allows synchronous access to module values without initiating module loading.
			/// 
			/// Sample: <pre>
			///   var JSONModel = sap.ui.require("sap/ui/model/json/JSONModel");
			/// </pre>
			/// 
			/// For modules that are known to be UI5 modules, this signature variant can be used to check whether the module has been loaded.
			/// 
			/// <b>Asynchronous Loading of Multiple Modules</b>
			/// 
			/// If an array of strings is given and (optionally) a callback function, then the strings are interpreted as module names and the corresponding modules (and their transitive dependencies) are loaded. Then the callback function will be called asynchronously. The module values of the specified modules will be provided as parameters to the callback function in the same order in which they appeared in the dependencies array.
			/// 
			/// The return value for the asynchronous use case is <code>undefined</code>.
			/// 
			/// <pre>
			///   sap.ui.require(['sap/ui/model/json/JSONModel', 'sap/ui/core/UIComponent'], function(JSONModel,UIComponent) {
			/// 
			///     var MyComponent = UIComponent.extend('MyComponent', {
			///       ...
			///     });
			///     ...
			/// 
			///   });
			/// </pre>
			/// 
			/// This method uses the same variation of the {@link jQuery.sap.getResourcePath unified resource name} syntax that {@link sap.ui.define} uses: module names are specified without the implicit extension '.js'. Relative module names are not supported.
			/// </summary>
			/// <param name="vDependencies">dependency (dependencies) to resolve</param>
			/// <param name="fnCallback">callback function to execute after resolving an array of dependencies</param>
			/// <returns>a single module value or undefined</returns>
			public extern static object require(Union<string, string[]> vDependencies, object fnCallback);

			/// <summary>
			/// Resolves one or more module dependencies.
			/// 
			/// <b>Synchronous Retrieval of a Single Module Value</b>
			/// 
			/// When called with a single string, that string is assumed to be the name of an already loaded module and the value of that module is returned. If the module has not been loaded yet, or if it is a Non-UI5 module (e.g. third party module), <code>undefined</code> is returned. This signature variant allows synchronous access to module values without initiating module loading.
			/// 
			/// Sample: <pre>
			///   var JSONModel = sap.ui.require("sap/ui/model/json/JSONModel");
			/// </pre>
			/// 
			/// For modules that are known to be UI5 modules, this signature variant can be used to check whether the module has been loaded.
			/// 
			/// <b>Asynchronous Loading of Multiple Modules</b>
			/// 
			/// If an array of strings is given and (optionally) a callback function, then the strings are interpreted as module names and the corresponding modules (and their transitive dependencies) are loaded. Then the callback function will be called asynchronously. The module values of the specified modules will be provided as parameters to the callback function in the same order in which they appeared in the dependencies array.
			/// 
			/// The return value for the asynchronous use case is <code>undefined</code>.
			/// 
			/// <pre>
			///   sap.ui.require(['sap/ui/model/json/JSONModel', 'sap/ui/core/UIComponent'], function(JSONModel,UIComponent) {
			/// 
			///     var MyComponent = UIComponent.extend('MyComponent', {
			///       ...
			///     });
			///     ...
			/// 
			///   });
			/// </pre>
			/// 
			/// This method uses the same variation of the {@link jQuery.sap.getResourcePath unified resource name} syntax that {@link sap.ui.define} uses: module names are specified without the implicit extension '.js'. Relative module names are not supported.
			/// </summary>
			/// <param name="vDependencies">dependency (dependencies) to resolve</param>
			/// <returns>a single module value or undefined</returns>
			public extern static object require(Union<string, string[]> vDependencies);

			#endregion

		}
	}
}
