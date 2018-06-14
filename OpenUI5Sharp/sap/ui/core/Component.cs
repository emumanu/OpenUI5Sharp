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
				/// <summary>
				/// Base Class for Component.
				/// </summary>
				[External]
				[Namespace(false)]
				public abstract partial class Component : sap.ui.@base.ManagedObject
				{
					#region Settings

					/// <summary>
					/// Settings class to create the object
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class Settings : sap.ui.@base.ManagedObject.Settings
					{
						public Union<object, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> componentData;

					}

					#endregion

					#region Typed Parameters

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class CreateComponentInfo
					{
						/// <summary>
						/// ID of component usage
						/// </summary>
						public string usage;

						/// <summary>
						/// ID of the nested component that is prefixed with <code>autoPrefixId</code>
						/// </summary>
						public string id;

						/// <summary>
						/// Indicates whether the component creation is done asynchronously (You should use synchronous creation only if really necessary, because this has a negative impact on performance.)
						/// </summary>
						public bool async;

						/// <summary>
						/// Settings for the nested component like for {#link sap.ui.component} or the component constructor
						/// </summary>
						public object settings;

						/// <summary>
						/// Initial data of the component (@see sap.ui.core.Component#getComponentData)
						/// </summary>
						public object componentData;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Creates and initializes a new Component with the given <code>sId</code> and settings.
					/// 
					/// The set of allowed entries in the <code>mSettings</code> object depends on the concrete subclass and is described there. See {@link sap.ui.core.Component} for a general description of this argument.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// 
					/// This class does not have its own settings, but all settings applicable to the base type {@link sap.ui.base.ManagedObject#constructor sap.ui.base.ManagedObject} can be used.
					/// </summary>
					/// <param name="sId">Optional ID for the new control; generated automatically if no non-empty ID is given. Note: this can be omitted, no matter whether <code>mSettings</code> are given or not!</param>
					/// <param name="mSettings">Optional object with initial settings for the new Component instance</param>
					public extern Component(string sId, sap.ui.core.Component.Settings mSettings);

					/// <summary>
					/// Creates and initializes a new Component with the given <code>sId</code> and settings.
					/// 
					/// The set of allowed entries in the <code>mSettings</code> object depends on the concrete subclass and is described there. See {@link sap.ui.core.Component} for a general description of this argument.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// 
					/// This class does not have its own settings, but all settings applicable to the base type {@link sap.ui.base.ManagedObject#constructor sap.ui.base.ManagedObject} can be used.
					/// </summary>
					/// <param name="sId">Optional ID for the new control; generated automatically if no non-empty ID is given. Note: this can be omitted, no matter whether <code>mSettings</code> are given or not!</param>
					public extern Component(string sId);

					/// <summary>
					/// Creates and initializes a new Component with the given <code>sId</code> and settings.
					/// 
					/// The set of allowed entries in the <code>mSettings</code> object depends on the concrete subclass and is described there. See {@link sap.ui.core.Component} for a general description of this argument.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// 
					/// This class does not have its own settings, but all settings applicable to the base type {@link sap.ui.base.ManagedObject#constructor sap.ui.base.ManagedObject} can be used.
					/// </summary>
					public extern Component();

					/// <summary>
					/// Creates and initializes a new Component with the given <code>sId</code> and settings.
					/// 
					/// The set of allowed entries in the <code>mSettings</code> object depends on the concrete subclass and is described there. See {@link sap.ui.core.Component} for a general description of this argument.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// 
					/// This class does not have its own settings, but all settings applicable to the base type {@link sap.ui.base.ManagedObject#constructor sap.ui.base.ManagedObject} can be used.
					/// </summary>
					/// <param name="mSettings">Optional object with initial settings for the new Component instance</param>
					public extern Component(sap.ui.core.Component.Settings mSettings);

					#endregion

					#region Fields

					#endregion

					#region Methods

					/// <summary>
					/// Creates a nested component that is declared in the <code>sap.ui5/componentUsages</code> section of the descriptor (manifest.json). The following snippet shows the declaration: <pre>
					/// {
					///   [...]
					///   "sap.ui5": {
					///     "componentUsages": {
					///       "myUsage": {
					///         "name": "my.useful.Component"
					///       }
					///     }
					///   }
					///   [...]
					/// }
					/// </pre> The syntax of the configuration object of the component usage matches the configuration object of the {#link sap.ui.component} factory function.
					/// 
					/// This is an example of how the <code>createComponent</code> function can be used for asynchronous scenarios: <pre>
					/// oComponent.createComponent("myUsage").then(function(oComponent) {
					///   oComponent.doSomething();
					/// }).catch(function(oError) {
					///   jQuery.sap.log.error(oError);
					/// });
					/// </pre>
					/// 
					/// The following example shows how <code>createComponent</code> can be used to create a nested component by providing specific properties like <code>id</code>, <code>async</code>, <code>settings</code>, or <code>componentData</code>: <pre>
					/// var oComponent = oComponent.createComponent({
					///   usage: "myUsage",
					///   id: "myId",
					///   settings: { ... },
					///   componentData: { ... }
					/// });
					/// </pre> The allowed list of properties are defined in the parameter documentation of this function.
					/// 
					/// The properties can also be defined in the descriptor. These properties can be overwritten by the local properties of that function.
					/// </summary>
					/// <param name="vUsage">ID of the component usage or the configuration object that creates the component</param>
					/// <returns>Component instance or Promise which will be resolved with the component instance (defaults to Promise / asynchronous behavior)</returns>
					public extern virtual Union<sap.ui.core.Component, jquery.JQueryPromise<object>> createComponent(Union<string, sap.ui.core.Component.CreateComponentInfo> vUsage);

					/// <summary>
					/// Cleans up the Component instance before destruction.
					/// 
					/// Applications must not call this hook method directly, it is called by the framework when the element is {@link #destroy destroyed}.
					/// 
					/// Subclasses of Component should override this hook to implement any necessary cleanup.
					/// </summary>
					public extern virtual void exit();

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.Component with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.ManagedObject.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.Component with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.ManagedObject.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.Component with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.ManagedObject.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns user specific data object
					/// </summary>
					/// <returns>componentData</returns>
					public extern virtual object getComponentData();

					/// <summary>
					/// Returns the event bus of this component.
					/// </summary>
					/// <returns>the event bus</returns>
					public extern virtual sap.ui.core.EventBus getEventBus();

					public extern virtual void getInterface();

					/// <summary>
					/// Returns the manifest defined in the metadata of the component. If not specified, the return value is null.
					/// </summary>
					/// <returns>manifest.</returns>
					public extern virtual object getManifest();

					/// <summary>
					/// Returns the configuration of a manifest section or the value for a specific path. If no section or key is specified, the return value is null.
					/// 
					/// Example: <code> { "sap.ui5": { "dependencies": { "libs": { "sap.m": {} }, "components": { "my.component.a": {} } } }); </code>
					/// 
					/// The configuration above can be accessed in the following ways: <ul> <li><b>By section/namespace</b>: <code>oComponent.getManifestEntry("sap.ui5")</code></li> <li><b>By path</b>: <code>oComponent.getManifestEntry("/sap.ui5/dependencies/libs")</code></li> </ul>
					/// 
					/// By section/namespace returns the configuration for the specified manifest section and by path allows to specify a concrete path to a dedicated entry inside the manifest. The path syntax always starts with a slash (/).
					/// </summary>
					/// <param name="sKey">Either the manifest section name (namespace) or a concrete path</param>
					/// <returns>Value of the manifest section or the key (could be any kind of value)</returns>
					public extern virtual object getManifestEntry(string sKey);

					/// <summary>
					/// Returns the manifest object.
					/// </summary>
					/// <returns>manifest.</returns>
					public extern virtual sap.ui.core.Manifest getManifestObject();

					/// <summary>
					/// Returns the metadata for the specific class of the current instance.
					/// </summary>
					/// <returns>Metadata for the specific class of the current instance.</returns>
					public extern virtual sap.ui.core.ComponentMetadata getMetadata();

					/// <summary>
					/// Returns the Component instance in whose "context" the given ManagedObject has been created or <code>undefined</code>.
					/// 
					/// This is a convenience wrapper around {@link sap.ui.core.Component.getOwnerIdFor Component.getOwnerIdFor}. If the owner ID cannot be determined for reasons documented on <code>getOwnerForId</code> or when the Component for the determined ID no longer exists, <code>undefined</code> will be returned.
					/// </summary>
					/// <param name="oObject">Object to retrieve the owner Component for</param>
					/// <returns>the owner Component or <code>undefined</code>.</returns>
					public extern static sap.ui.core.Component getOwnerComponentFor(sap.ui.@base.ManagedObject oObject);

					/// <summary>
					/// Returns the ID of the object in whose "context" the given ManagedObject has been created.
					/// 
					/// For objects that are not ManagedObjects or for which the owner is unknown, <code>undefined</code> will be returned as owner ID.
					/// 
					/// <strong>Note</strong>: Ownership for objects is only checked by the framework at the time when they are created. It is not checked or updated afterwards. And it can only be detected while the {@link sap.ui.core.Component#runAsOwner Component.runAsOwner} function is executing. Without further action, this is only the case while the content of a UIComponent is {@link sap.ui.core.UIComponent#createContent constructed} or when a {@link sap.ui.core.routing.Router Router} creates a new View and its content.
					/// 
					/// <strong>Note</strong>: This method does not guarantee that the returned owner ID belongs to a Component. Currently, it always does. But future versions of UI5 might introduce a more fine grained ownership concept, e.g. taking Views into account. Callers that want to deal only with components as owners, should use the following method: {@link sap.ui.core.Component.getOwnerComponentFor Component.getOwnerComponentFor}. It guarantees that the returned object (if any) will be a Component.
					/// 
					/// <strong>Further note</strong> that only the ID of the owner is recorded. In rare cases, when the lifecycle of a ManagedObject is not bound to the lifecycle of its owner, (e.g. by the means of aggregations), then the owner might have been destroyed already whereas the ManagedObject is still alive. So even the existence of an owner ID is not a guarantee for the existence of the corresponding owner.
					/// </summary>
					/// <param name="oObject">Object to retrieve the owner ID for</param>
					/// <returns>ID of the owner or <code>undefined</code></returns>
					public extern static string getOwnerIdFor(sap.ui.@base.ManagedObject oObject);

					/// <summary>
					/// Returns a service interface for the {@link sap.ui.core.service.Service Service} declared in the descriptor for components (manifest.json). The declaration needs to be done in the <code>sap.ui5/services</code> section as follows: <pre>
					/// {
					///   [...]
					///   "sap.ui5": {
					///     "services": {
					///       "myLocalServiceAlias": {
					///         "factoryName": "my.ServiceFactory",
					///         ["optional": true]
					///       }
					///     }
					///   }
					///   [...]
					/// }
					/// </pre> The service declaration is used to define a mapping between the local alias for the service that can be used in the Component and the name of the service factory which will be used to create a service instance.
					/// 
					/// The <code>getService</code> function will look up the service factory and will create a new instance by using the service factory function {@link sap.ui.core.service.ServiceFactory#createInstance createInstance} The optional property defines that the service is not mandatory and the usage will not depend on the availability of this service. When requesting an optional service the <code>getService</code> function will reject but there will be no error logged in the console.
					/// 
					/// When creating a new instance of the service the Component context will be passed as <code>oServiceContext</code> as follows: <pre>
					/// {
					///   "scopeObject": this,     // the Component instance
					///   "scopeType": "component" // the stereotype of the scopeObject
					/// }
					/// </pre>
					/// 
					/// The service will be created only once per Component and reused in future calls to the <code>getService</code> function. <p> This function will return a <code>Promise</code> which provides the service interface when resolved. If the <code>factoryName</code> could not be found in the {@link sap.ui.core.service.ServiceFactoryRegistry Service Factory Registry} or the service declaration in the descriptor for components (manifest.json) is missing the Promise will reject.
					/// 
					/// This is an example of how the <code>getService</code> function can be used: <pre>
					/// oComponent.getService("myLocalServiceAlias").then(function(oService) {
					///   oService.doSomething();
					/// }).catch(function(oError) {
					///   jQuery.sap.log.error(oError);
					/// });
					/// </pre>
					/// </summary>
					/// <param name="sLocalServiceAlias">Local service alias as defined in the manifest.json</param>
					/// <returns>Promise which will be resolved with the Service interface</returns>
					public extern virtual jquery.JQueryPromise<object> getService(string sLocalServiceAlias);

					/// <summary>
					/// Initializes the Component instance after creation.
					/// 
					/// Applications must not call this hook method directly, it is called by the framework while the constructor of a Component is executed.
					/// 
					/// Subclasses of Component should override this hook to implement any necessary initialization.
					/// </summary>
					public extern virtual void init();

					/// <summary>
					/// The hook which gets called when the static configuration of the component has been changed by some configuration extension.
					/// </summary>
					/// <param name="sConfigKey">Error message.</param>
					public extern virtual void onConfigChange(string sConfigKey);

					/// <summary>
					/// The window before unload hook. Override this method in your Component class implementation, to handle cleanup before the real unload or to prompt a question to the user, if the component should be exited.
					/// </summary>
					/// <returns>a string if a prompt should be displayed to the user confirming closing the Component (e.g. when the Component is not yet saved).</returns>
					public extern virtual string onWindowBeforeUnload();

					/// <summary>
					/// The window error hook. Override this method in your Component class implementation to listen to unhandled errors.
					/// </summary>
					/// <param name="sMessage">The error message.</param>
					/// <param name="sFile">File where the error occurred</param>
					/// <param name="iLine">Line number of the error</param>
					public extern virtual void onWindowError(string sMessage, string sFile, int iLine);

					/// <summary>
					/// The window unload hook. Override this method in your Component class implementation, to handle cleanup of the component once the window will be unloaded (e.g. closed).
					/// </summary>
					public extern virtual void onWindowUnload();

					/// <summary>
					/// Calls the function <code>fn</code> once and marks all ManagedObjects created during that call as "owned" by this Component.
					/// 
					/// Nested calls of this method are supported (e.g. inside a newly created, nested component). The currently active owner Component will be remembered before executing <code>fn</code> and restored afterwards.
					/// </summary>
					/// <param name="fn">Function to execute</param>
					/// <returns>result of function <code>fn</code></returns>
					public extern virtual object runAsOwner(object fn);

					#endregion

				}
			}
		}
	}
}
