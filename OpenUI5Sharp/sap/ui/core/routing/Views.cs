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
				public static partial class routing
				{
					[External]
					[Namespace(false)]
					[Name("sap.ui.core.routing.Views")]
					public partial class Views : sap.ui.@base.EventProvider
					{
						#region Typed Parameters

						/// <summary>
						/// Parameter to be used as Object Literal
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class CreatedInfo
						{
							/// <summary>
							/// the instance of the created view.
							/// </summary>
							public sap.ui.core.mvc.View view;

							/// <summary>
							/// The view options passed to {@link sap.ui.view}
							/// </summary>
							public object viewOptions;

						}

						/// <summary>
						/// Parameter to be used as Object Literal
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class ViewsOptions
						{
							/// <summary>
							/// the owner of all the views that will be created by this Instance.
							/// </summary>
							public sap.ui.core.UIComponent component;

							/// <summary>
							/// @since 1.34 Whether the views which are created through this Views are loaded asyncly. This option can be set only when the Views is used standalone without the involvement of a Router. Otherwise the async option is inherited from the Router.
							/// </summary>
							public bool async;

						}

						/// <summary>
						/// Parameter to be used as Object Literal
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class GetViewOptions
						{
							/// <summary>
							/// If you do not use setView please see {@link sap.ui.view} for the documentation. This is used as a key in the cache of the Views instance. If you want to retrieve a view that has been given an alternative name in {@link #setView} you need to provide the same name here and you can skip all the other viewOptions.
							/// </summary>
							public string viewName;

						}

						#endregion

						#region Delegates

						public delegate void CreatedDelegate(sap.ui.@base.Event<sap.ui.core.routing.Views.CreatedInfo> oEvent, object oData);

						#endregion

						#region Constructor

						/// <summary>
						/// Instantiates a view repository that creates and caches views. If it is destroyed, all the Views it created are destroyed. Usually you do not have to create instances of this class, it is used by the {@link sap.ui.core.routing.Router}. If you are using {@link sap.ui.core.routing.Targets} without using a {@link sap.ui.core.UIComponent} you have to create an instance of this class. They will create an instance on their own, or if they are used with a {@link sap.ui.core.UIComponent} they will share the same instance of Views.
						/// </summary>
						/// <param name="oOptions"></param>
						public extern Views(sap.ui.core.routing.Views.ViewsOptions oOptions);

						/// <summary>
						/// Instantiates a view repository that creates and caches views. If it is destroyed, all the Views it created are destroyed. Usually you do not have to create instances of this class, it is used by the {@link sap.ui.core.routing.Router}. If you are using {@link sap.ui.core.routing.Targets} without using a {@link sap.ui.core.UIComponent} you have to create an instance of this class. They will create an instance on their own, or if they are used with a {@link sap.ui.core.UIComponent} they will share the same instance of Views.
						/// </summary>
						public extern Views();

						#endregion

						#region Methods

						#region Methods for event created

						/// <summary>
						/// Fire event created to attached listeners.
						/// </summary>
						/// <param name="mArguments">the arguments to pass along with the event.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.routing.Views fireCreated(sap.ui.core.routing.Views.CreatedInfo mArguments);

						/// <summary>
						/// Fire event created to attached listeners.
						/// </summary>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.routing.Views fireCreated();

						#endregion

						#region Other methods

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.routing.Views with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.EventProvider.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.routing.Views with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.EventProvider.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.routing.Views with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.EventProvider.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns a metadata object for class sap.ui.core.routing.Views.
						/// </summary>
						/// <returns>Metadata object describing this class</returns>
						[Name("getMetadata")]
						public extern static sap.ui.@base.Metadata getMetadataStatic();

						/// <summary>
						/// Returns a cached view, for a given name. If it does not exist yet, it will create the view with the provided options. If you provide a viewId, it will be prefixed with the viewId of the component.
						/// </summary>
						/// <param name="oOptions">see {@link sap.ui.view} for the documentation. The viewId you pass into the options will be prefixed with the id of the component you pass into the constructor. So you can retrieve the view later by calling the {@link sap.ui.core.UIComponent#byId} function of the UIComponent.</param>
						/// <returns>A promise that is resolved when the view is loaded {@link sap.ui.core.mvc.View#loaded}. The view instance will be passed to the promise.</returns>
						public extern virtual es5.Promise<object> getView(sap.ui.core.routing.Views.GetViewOptions oOptions);

						/// <summary>
						/// Adds or overwrites a view in the cache of the Views instance. The viewName serves as a key for caching.
						/// 
						/// If the second parameter is set to null or undefined, the previous cache view under the same name isn't managed by the Views instance. The lifecycle (for example the destroy of the view) of the view instance should be maintained by additional code.
						/// </summary>
						/// <param name="sViewName">Name of the view, may differ from the actual viewName of the oView parameter provided, since you can retrieve this view per {@link #.getView}.</param>
						/// <param name="oView">the view instance</param>
						/// <returns>this for chaining.</returns>
						public extern virtual sap.ui.core.routing.Views setView(string sViewName, sap.ui.core.mvc.View oView);

						#endregion

						#endregion

					}
				}
			}
		}
	}
}
