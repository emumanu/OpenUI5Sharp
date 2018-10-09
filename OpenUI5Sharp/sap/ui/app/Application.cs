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
			public static partial class app
			{
				/// <summary>
				/// Base class for application classes
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.app.Application")]
				[Obsolete("Deprecated since 1.15.1. The Component class is enhanced to take care about the Application code.")]
				public abstract partial class Application : sap.ui.core.Component
				{
					#region Settings

					/// <summary>
					/// Settings class to create the object
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class Settings : sap.ui.core.Component.Settings
					{
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> root;

						public Union<object, string, sap.ui.@base.ManagedObject.BindPropertyInfo> config;

						public Union<sap.ui.core.UIComponent, string, sap.ui.@base.ManagedObject.BindAggregationInfo> rootComponent;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Abstract application class. Extend this class to create a central application class.
					/// 
					/// Only one instance is allowed.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">optional id for the application; generated automatically if no non-empty id is given Note: this can be omitted, no matter whether <code>mSettings</code> will be given or not!</param>
					/// <param name="mSettings">optional map/JSON-object with initial settings for the new application instance</param>
					public extern Application(string sId, sap.ui.app.Application.Settings mSettings);

					/// <summary>
					/// Abstract application class. Extend this class to create a central application class.
					/// 
					/// Only one instance is allowed.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">optional id for the application; generated automatically if no non-empty id is given Note: this can be omitted, no matter whether <code>mSettings</code> will be given or not!</param>
					public extern Application(string sId);

					/// <summary>
					/// Abstract application class. Extend this class to create a central application class.
					/// 
					/// Only one instance is allowed.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern Application();

					/// <summary>
					/// Abstract application class. Extend this class to create a central application class.
					/// 
					/// Only one instance is allowed.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">optional map/JSON-object with initial settings for the new application instance</param>
					public extern Application(sap.ui.app.Application.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property root

					/// <summary>
					/// Gets current value of property {@link #getRoot root}.
					/// </summary>
					/// <returns>Value of property <code>root</code></returns>
					public extern virtual string getRoot();

					/// <summary>
					/// Sets a new value for property {@link #getRoot root}.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sRoot">New value for property <code>root</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.app.Application setRoot(string sRoot);

					#endregion

					#region Methods for Property config

					/// <summary>
					/// Gets current value of property {@link #getConfig config}.
					/// </summary>
					/// <returns>Value of property <code>config</code></returns>
					public extern virtual object getConfig();

					/// <summary>
					/// Sets the configuration model.
					/// </summary>
					/// <param name="vConfig">the configuration model, the configuration object or a URI string to load a JSON configuration file.</param>
					public extern virtual void setConfig(Union<string, object, sap.ui.model.Model> vConfig);

					#endregion

					#region Methods for Aggregation rootComponent

					/// <summary>
					/// Gets content of aggregation {@link #getRootComponent rootComponent}.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.UIComponent getRootComponent();

					/// <summary>
					/// Destroys the rootComponent in the aggregation {@link #getRootComponent rootComponent}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.app.Application destroyRootComponent();

					/// <summary>
					/// Sets the aggregated {@link #getRootComponent rootComponent}.
					/// </summary>
					/// <param name="oRootComponent">The rootComponent to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.app.Application setRootComponent(sap.ui.core.UIComponent oRootComponent);

					#endregion

					#region Other methods

					/// <summary>
					/// Creates and returns the root component. Override this method in your application implementation, if you want to override the default creation by metadata.
					/// </summary>
					/// <returns>the root component</returns>
					public extern virtual sap.ui.core.UIComponent createRootComponent();

					public extern override void destroy();

					/// <summary>
					/// Creates a new subclass of class sap.ui.app.Application with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Component.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.app.Application with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Component.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.app.Application with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Component.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.app.Application.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					/// <summary>
					/// Returns the application root component.
					/// </summary>
					/// <returns>The root component</returns>
					public extern virtual sap.ui.core.Control getView();

					/// <summary>
					/// The main method is called when the DOM and UI5 is completely loaded. Override this method in your Application class implementation to execute code which relies on a loaded DOM / UI5.
					/// </summary>
					public extern virtual void main();

					/// <summary>
					/// On before exit application hook. Override this method in your Application class implementation, to handle cleanup before the real exit or to prompt a question to the user, if the application should be exited.
					/// </summary>
					/// <returns>return a string if a prompt should be displayed to the user confirming closing the application (e.g. when the application is not yet saved).</returns>
					public extern virtual string onBeforeExit();

					/// <summary>
					/// On error hook. Override this method in your Application class implementation to listen to unhandled errors.
					/// </summary>
					/// <param name="sMessage">The error message.</param>
					/// <param name="sFile">The file where the error occurred</param>
					/// <param name="iLine">The line number of the error</param>
					public extern virtual void onError(string sMessage, string sFile, int iLine);

					/// <summary>
					/// On exit application hook. Override this method in your Application class implementation, to handle cleanup of the application.
					/// </summary>
					public extern virtual void onExit();

					#endregion

					#endregion

				}
			}
		}
	}
}
