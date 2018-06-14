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
				public static partial class mvc
				{
					/// <summary>
					/// A generic controller implementation for the UI5 Model-View-Controller concept.
					/// 
					/// Can either be used as a generic controller which is enriched on the fly with methods and properties (see {@link sap.ui.controller}) or as a base class for typed controllers.
					/// </summary>
					[External]
					[Namespace(false)]
					public partial class Controller : sap.ui.@base.EventProvider
					{
						#region Constructor

						/// <summary>
						/// Instantiates a (MVC-style) controller. Consumers should call the constructor only in the typed controller scenario. In the generic controller use case, they should use {@link sap.ui.controller} instead.
						/// </summary>
						/// <param name="sName">The name of the controller to instantiate. If a controller is defined as real sub-class,</param>
						public extern Controller(Union<string, object[]> sName);

						#endregion

						#region Methods

						/// <summary>
						/// Returns an Element of the connected view with the given local ID.
						/// 
						/// Views automatically prepend their own ID as a prefix to created Elements to make the IDs unique even in the case of multiple view instances. This method helps to find an element by its local ID only.
						/// 
						/// If no view is connected or if the view doesn't contain an element with the given local ID, undefined is returned.
						/// </summary>
						/// <param name="sId">View-local ID</param>
						/// <returns>Element by its (view local) ID</returns>
						public extern virtual sap.ui.core.Element byId(string sId);

						/// <summary>
						/// Converts a view local ID to a globally unique one by prepending the view ID.
						/// 
						/// If no view is connected, undefined is returned.
						/// </summary>
						/// <param name="sId">View-local ID</param>
						/// <returns>Prefixed ID</returns>
						public extern virtual string createId(string sId);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.mvc.Controller with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.EventProvider.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.mvc.Controller with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.EventProvider.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.mvc.Controller with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.EventProvider.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns a metadata object for class sap.ui.core.mvc.Controller.
						/// </summary>
						/// <returns>Metadata object describing this class</returns>
						public extern static sap.ui.@base.Metadata getMetadata();

						/// <summary>
						/// Gets the component of the controller's view
						/// 
						/// If there is no Component connected to the view or the view is not connected to the controller, undefined is returned.
						/// </summary>
						/// <returns>Component instance</returns>
						public extern virtual sap.ui.core.Component getOwnerComponent();

						/// <summary>
						/// Returns the view associated with this controller or undefined.
						/// </summary>
						/// <returns>View connected to this controller.</returns>
						public extern virtual sap.ui.core.mvc.View getView();

						/// <summary>
						/// This method is called every time the View is rendered, after the HTML is placed in the DOM-Tree. It can be used to apply additional changes to the DOM after the Renderer has finished. (Even though this method is declared as "abstract", it does not need to be defined in controllers, if the method does not exist, it will simply not be called.)
						/// </summary>
						/// <remarks>This method is abstract, so it should not be called from subclasses as it is not implemented.</remarks>
						public extern virtual void onAfterRendering();

						/// <summary>
						/// This method is called every time the View is rendered, before the Renderer is called and the HTML is placed in the DOM-Tree. It can be used to perform clean-up-tasks before re-rendering. (Even though this method is declared as "abstract", it does not need to be defined in controllers, if the method does not exist, it will simply not be called.)
						/// </summary>
						/// <remarks>This method is abstract, so it should not be called from subclasses as it is not implemented.</remarks>
						public extern virtual void onBeforeRendering();

						/// <summary>
						/// This method is called upon desctuction of the View. The controller should perform its internal destruction in this hook. It is only called once per View instance, unlike the onBeforeRendering and onAfterRendering hooks. (Even though this method is declared as "abstract", it does not need to be defined in controllers, if the method does not exist, it will simply not be called.)
						/// </summary>
						/// <remarks>This method is abstract, so it should not be called from subclasses as it is not implemented.</remarks>
						public extern virtual void onExit();

						/// <summary>
						/// This method is called upon initialization of the View. The controller can perform its internal setup in this hook. It is only called once per View instance, unlike the onBeforeRendering and onAfterRendering hooks. (Even though this method is declared as "abstract", it does not need to be defined in controllers, if the method does not exist, it will simply not be called.)
						/// 
						/// <b>Note:</b> In component-based apps <code>this.getOwnerComponent().getModel()</code> should be used inside <code>onInit()</code> to get a model assigned to the component instead of using <code>this.getView().getModel()</code>. The latter call might return <code>undefined</code> because the view might not have been attached to a parent yet (i.e. the component), and thus the view can't inherit a model from that parent. You could also attach to the <code>modelContextChange</code> event. The event is fired when either the context or the model changes for the control.
						/// </summary>
						/// <remarks>This method is abstract, so it should not be called from subclasses as it is not implemented.</remarks>
						public extern virtual void onInit();

						/// <summary>
						/// Registers a callback module, which provides code enhancements for the lifecycle and event handler functions of a specific controller. The code enhancements are returned either in sync or async mode.
						/// 
						/// The extension provider module provides the <code>getControllerExtensions</code> function which returns either directly an array of objects or a Promise that returns an array of objects when it resolves. These objects are object literals defining the methods and properties of the controller in a similar way as {@link sap.ui.controller}.
						/// 
						/// <b>Example for a callback module definition (sync):</b> <pre>
						/// sap.ui.define("my/custom/sync/ExtensionProvider", ['jquery.sap.global'], function(jQuery) {
						///   var ExtensionProvider = function() {};
						///   ExtensionProvider.prototype.getControllerExtensions = function(sControllerName, sComponentId, bAsync) {
						///     if (!bAsync && sControllerName == "my.own.Controller") {
						///       // IMPORTANT: only return extensions for a specific controller
						///       return [{
						///         onInit: function() {
						///           // Do something here...
						///         },
						///         onAfterRendering: function() {
						///           // Do something here...
						///         },
						///         onButtonClick: function(oEvent) {
						///           // Handle the button click event
						///         }
						///       }
						///     }];
						///   };
						///   return ExtensionProvider;
						/// }, true);
						/// </pre>
						/// 
						/// <b>Example for a callback module definition (async):</b> <pre>
						/// sap.ui.define("my/custom/async/ExtensionProvider", ['jquery.sap.global'], function(jQuery) {
						///   var ExtensionProvider = function() {};
						///   ExtensionProvider.prototype.getControllerExtensions = function(sControllerName, sComponentId, bAsync) {
						///     if (bAsync && sControllerName == "my.own.Controller") {
						///       // IMPORTANT:
						///       // only return a Promise for a specific controller since it
						///       // requires the View/Controller and its parents to run in async
						///       // mode!
						///       return new Promise(function(fnResolve, fnReject) {
						///         fnResolve([{
						///           onInit: function() {
						///             // Do something here...
						///           },
						///           onAfterRendering: function() {
						///             // Do something here...
						///           },
						///           onButtonClick: function(oEvent) {
						///             // Handle the button click event
						///           }
						///         }]);
						///       }
						///     };
						///   };
						///   return ExtensionProvider;
						/// }, true);
						/// </pre>
						/// 
						/// The lifecycle functions <code>onInit</code>, <code>onExit</code>, <code>onBeforeRendering</code> and <code>onAfterRendering</code> are added before or after the lifecycle functions of the original controller. The event handler functions, such as <code>onButtonClick</code>, are replacing the original controller's function.
						/// 
						/// When using an async extension provider you need to ensure that the view is loaded in async mode.
						/// 
						/// In both cases, return <code>undefined</code> if no controller extension shall be applied.
						/// </summary>
						/// <param name="sExtensionProvider">the module name of the extension provider
						/// 
						/// See {@link sap.ui.controller} for an overview of the available functions for controllers.</param>
						public extern static void registerExtensionProvider(string sExtensionProvider);

						#endregion

					}
				}
			}
		}
	}
}
