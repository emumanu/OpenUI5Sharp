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
				/// Base Class for UIComponent.
				/// 
				/// If you are extending a UIComponent make sure you read the {@link #.extend} documentation since the metadata is special.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.core.UIComponent")]
				public abstract partial class UIComponent : sap.ui.core.Component
				{
					#region Settings

					/// <summary>
					/// Settings class to create the object
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class Settings : sap.ui.core.Component.Settings
					{
					}

					#endregion

					#region Constructor

					/// <summary>
					/// Creates and initializes a new UIComponent with the given <code>sId</code> and settings.
					/// 
					/// The set of allowed entries in the <code>mSettings</code> object depends on the concrete subclass and is described there. See {@link sap.ui.core.Component} for a general description of this argument.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">Optional ID for the new control; generated automatically if no non-empty ID is given; Note: this can be omitted, no matter whether <code>mSettings</code> will be given or not</param>
					/// <param name="mSettings">Optional map/JSON-object with initial settings for the new component instance</param>
					public extern UIComponent(string sId, sap.ui.core.UIComponent.Settings mSettings);

					/// <summary>
					/// Creates and initializes a new UIComponent with the given <code>sId</code> and settings.
					/// 
					/// The set of allowed entries in the <code>mSettings</code> object depends on the concrete subclass and is described there. See {@link sap.ui.core.Component} for a general description of this argument.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">Optional ID for the new control; generated automatically if no non-empty ID is given; Note: this can be omitted, no matter whether <code>mSettings</code> will be given or not</param>
					public extern UIComponent(string sId);

					/// <summary>
					/// Creates and initializes a new UIComponent with the given <code>sId</code> and settings.
					/// 
					/// The set of allowed entries in the <code>mSettings</code> object depends on the concrete subclass and is described there. See {@link sap.ui.core.Component} for a general description of this argument.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern UIComponent();

					/// <summary>
					/// Creates and initializes a new UIComponent with the given <code>sId</code> and settings.
					/// 
					/// The set of allowed entries in the <code>mSettings</code> object depends on the concrete subclass and is described there. See {@link sap.ui.core.Component} for a general description of this argument.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">Optional map/JSON-object with initial settings for the new component instance</param>
					public extern UIComponent(sap.ui.core.UIComponent.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Aggregation rootControl

					/// <summary>
					/// Returns the content of {@link sap.ui.core.UIComponent#createContent}. If you specified a <code>rootView</code> in your metadata or in the descriptor file (manifest.json), you will get the instance of the root view. This getter will only return something if the {@link sap.ui.core.UIComponent#init} function was invoked. If <code>createContent</code> is not implemented, and there is no root view, it will return <code>null</code>. Here is an example: <code> <pre>
					///          var MyExtension = UIComponent.extend("my.Component", {
					///               metadata: {
					///                    rootView: "my.View"
					///               },
					///               init: function () {
					///                    this.getRootControl(); // returns null
					///                    UIComponent.prototype.init.apply(this, arguments);
					///                    this.getRootControl(); // returns the view "my.View"
					///               }
					///          });
					///     </pre> </code>
					/// </summary>
					/// <returns>the control created by {@link sap.ui.core.UIComponent#createContent}</returns>
					public extern virtual sap.ui.core.Control getRootControl();

					#endregion

					#region Other methods

					/// <summary>
					/// Returns an element by its ID in the context of the component.
					/// </summary>
					/// <param name="sId">Component local ID of the element</param>
					/// <returns>element by its ID or <code>undefined</code></returns>
					public extern virtual sap.ui.core.Element byId(string sId);

					/// <summary>
					/// Hook method to create the content (UI Control Tree) of this component.
					/// 
					/// The default implementation in this class reads the name (and optionally type) of a root view from the descriptor for this component (path <code>/sap.ui5/rootView</code>) or, for backward compatibility, just the name from static component metadata (property <code>rootView</code>). When no type is specified, it defaults to XML. The method then calls the {@link sap.ui.view view factory} to instantiate the root view and returns the result.
					/// 
					/// When there is no root view configuration, <code>null</code> will be returned.
					/// 
					/// This method can be overwritten by subclasses if the default implementation doesn't fit their needs. Subclasses are not limited to views as return type but may return any control, but only a single control (can be the root of a larger control tree, however).
					/// </summary>
					/// <returns>Root control of the UI tree or <code>null</code> if none is configured</returns>
					public extern virtual Union<sap.ui.core.mvc.View, sap.ui.core.Control> createContent();

					/// <summary>
					/// Convert the given component local element ID to a globally unique ID by prefixing it with the component ID.
					/// </summary>
					/// <param name="sId">Component local ID of the element</param>
					/// <returns>prefixed id</returns>
					public extern virtual string createId(string sId);

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.UIComponent with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Component.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.UIComponent with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Component.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.UIComponent with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Component.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// A method to be implemented by UIComponents, returning the flag whether to prefix the IDs of controls automatically or not if the controls are created inside the {@link sap.ui.core.UIComponent#createContent} function. By default this feature is not activated.
					/// 
					/// You can overwrite this function and return <code>true</code> to activate the automatic prefixing. In addition the default behavior can be configured in the manifest by specifying the entry <code>sap.ui5/autoPrefixId</code>.
					/// </summary>
					/// <returns>true, if the Controls IDs should be prefixed automatically</returns>
					public extern virtual bool getAutoPrefixId();

					public extern virtual void getEventingParent();

					/// <summary>
					/// Returns the local ID of an element by removing the component ID prefix or <code>null</code> if the ID does not contain a prefix.
					/// </summary>
					/// <param name="sId">Prefixed ID</param>
					/// <returns>ID without prefix or <code>null</code></returns>
					public extern virtual string getLocalId(string sId);

					/// <summary>
					/// Returns a metadata object for class sap.ui.core.UIComponent.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					/// <summary>
					/// Returns the reference to the router instance which has been created by the UIComponent once the routes in the routing metadata has been defined.
					/// </summary>
					/// <returns>the router instance</returns>
					public extern virtual sap.ui.core.routing.Router getRouter();

					/// <summary>
					/// Returns the reference to the router instance. The passed controller or view has to be created in the context of a UIComponent to return the router instance. Otherwise this function will return undefined. You may define the routerClass property in the config section of the routing to make the Component create your router extension. Example: routing: { config: { routerClass : myAppNamespace.MyRouterClass ... } ...
					/// </summary>
					/// <param name="oControllerOrView">either a view or controller</param>
					/// <returns>the router instance</returns>
					public extern static sap.ui.core.routing.Router getRouterFor(Union<sap.ui.core.mvc.View, sap.ui.core.mvc.Controller> oControllerOrView);

					/// <summary>
					/// Returns the reference to the Targets instance which has been created by the UIComponent once the targets in the routing metadata has been defined. If routes have been defined, it will be the Targets instance created and used by the router.
					/// </summary>
					/// <returns>the targets instance</returns>
					public extern virtual sap.ui.core.routing.Targets getTargets();

					/// <summary>
					/// Returns the reference to the UIArea of the container.
					/// </summary>
					/// <returns>reference to the UIArea of the container</returns>
					public extern virtual sap.ui.core.UIArea getUIArea();

					/// <summary>
					/// Initializes the Component instance after creation.
					/// 
					/// Applications must not call this hook method directly, it is called by the framework while the constructor of a Component is executed.
					/// 
					/// Subclasses of Component should override this hook to implement any necessary initialization. <b>When overriding this function make sure to invoke the init function of the UIComponent as well!</b>
					/// </summary>
					public extern override void init();

					/// <summary>
					/// Function is called when the rendering of the ComponentContainer is completed.
					/// 
					/// Applications must not call this hook method directly, it is called from ComponentContainer.
					/// 
					/// Subclasses of UIComponent override this hook to implement any necessary actions after the rendering.
					/// </summary>
					public extern virtual void onAfterRendering();

					/// <summary>
					/// Function is called when the rendering of the ComponentContainer is started.
					/// 
					/// Applications must not call this hook method directly, it is called from ComponentContainer.
					/// 
					/// Subclasses of UIComponent override this hook to implement any necessary actions before the rendering.
					/// </summary>
					public extern virtual void onBeforeRendering();

					/// <summary>
					/// Renders the root control of the UIComponent.
					/// </summary>
					/// <param name="oRenderManager">a RenderManager instance</param>
					public extern virtual void render(sap.ui.core.RenderManager oRenderManager);

					/// <summary>
					/// Sets the reference to the ComponentContainer - later required for the determination of the UIArea for the UIComponent.
					/// </summary>
					/// <param name="oContainer">reference to a ComponentContainer</param>
					/// <returns>reference to this instance to allow method chaining</returns>
					public extern virtual sap.ui.core.UIComponent setContainer(sap.ui.core.ComponentContainer oContainer);

					#endregion

					#endregion

				}
			}
		}
	}
}
