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
				public static partial class tmpl
				{
					/// <summary>
					/// This is the base class for all template controls. Template controls are declared based on templates.
					/// </summary>
					[External]
					[Namespace(false)]
					public partial class TemplateControl : sap.ui.core.Control
					{
						#region Settings

						/// <summary>
						/// Settings class to create the object
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class Settings : sap.ui.core.Control.Settings
						{
							/// <summary>
							/// The context is a data object. It can be used for default template expressions. A change of the context object leads to a re-rendering whereas a change of a nested property of the context object doesn't. By default the context is an empty object.
							/// </summary>
							public Union<object, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> context;

							/// <summary>
							/// The template on which the template control is based on.
							/// </summary>
							public Union<sap.ui.core.tmpl.Template, sap.ui.core.ID, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> template;

							/// <summary>
							/// Fired when the Template Control has been (re-)rendered and its HTML is present in the DOM.
							/// </summary>
							public sap.ui.@base.EventDelegate afterRendering;

							/// <summary>
							/// Fired before this Template Control is re-rendered. Use to unbind event handlers from HTML elements etc.
							/// </summary>
							public sap.ui.@base.EventDelegate beforeRendering;

						}

						#endregion

						#region Constructor

						/// <summary>
						/// Constructor for a new tmpl/TemplateControl.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">id for the new control, generated automatically if no id is given</param>
						/// <param name="mSettings">initial settings for the new control</param>
						public extern TemplateControl(string sId, sap.ui.core.tmpl.TemplateControl.Settings mSettings);

						/// <summary>
						/// Constructor for a new tmpl/TemplateControl.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">id for the new control, generated automatically if no id is given</param>
						public extern TemplateControl(string sId);

						/// <summary>
						/// Constructor for a new tmpl/TemplateControl.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						public extern TemplateControl();

						/// <summary>
						/// Constructor for a new tmpl/TemplateControl.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="mSettings">initial settings for the new control</param>
						public extern TemplateControl(sap.ui.core.tmpl.TemplateControl.Settings mSettings);

						#endregion

						#region Methods

						#region Methods for Property context

						/// <summary>
						/// Gets current value of property {@link #getContext context}.
						/// 
						/// The context is a data object. It can be used for default template expressions. A change of the context object leads to a re-rendering whereas a change of a nested property of the context object doesn't. By default the context is an empty object.
						/// </summary>
						/// <returns>Value of property <code>context</code></returns>
						public extern virtual object getContext();

						/// <summary>
						/// Sets a new value for property {@link #getContext context}.
						/// 
						/// The context is a data object. It can be used for default template expressions. A change of the context object leads to a re-rendering whereas a change of a nested property of the context object doesn't. By default the context is an empty object.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// </summary>
						/// <param name="oContext">New value for property <code>context</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.tmpl.TemplateControl setContext(object oContext);

						#endregion

						#region Methods for Aggregation controls

						#endregion

						#region Methods for Association template

						/// <summary>
						/// ID of the element which is the current target of the association {@link #getTemplate template}, or <code>null</code>.
						/// </summary>
						/// <returns></returns>
						public extern virtual sap.ui.core.ID getTemplate();

						/// <summary>
						/// Sets the associated {@link #getTemplate template}.
						/// </summary>
						/// <param name="oTemplate">ID of an element which becomes the new target of this template association; alternatively, an element instance may be given</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.tmpl.TemplateControl setTemplate(Union<sap.ui.core.ID, sap.ui.core.tmpl.Template> oTemplate);

						#endregion

						#region Methods for Event afterRendering

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterRendering afterRendering} event of this <code>sap.ui.core.tmpl.TemplateControl</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.core.tmpl.TemplateControl</code> itself.
						/// 
						/// Fired when the Template Control has been (re-)rendered and its HTML is present in the DOM.
						/// </summary>
						/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.core.tmpl.TemplateControl</code> itself</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.tmpl.TemplateControl attachAfterRendering(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterRendering afterRendering} event of this <code>sap.ui.core.tmpl.TemplateControl</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.core.tmpl.TemplateControl</code> itself.
						/// 
						/// Fired when the Template Control has been (re-)rendered and its HTML is present in the DOM.
						/// </summary>
						/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.tmpl.TemplateControl attachAfterRendering(object oData, sap.ui.@base.EventDelegate fnFunction);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterRendering afterRendering} event of this <code>sap.ui.core.tmpl.TemplateControl</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.core.tmpl.TemplateControl</code> itself.
						/// 
						/// Fired when the Template Control has been (re-)rendered and its HTML is present in the DOM.
						/// </summary>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.tmpl.TemplateControl attachAfterRendering(sap.ui.@base.EventDelegate fnFunction);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterRendering afterRendering} event of this <code>sap.ui.core.tmpl.TemplateControl</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.core.tmpl.TemplateControl</code> itself.
						/// 
						/// Fired when the Template Control has been (re-)rendered and its HTML is present in the DOM.
						/// </summary>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.core.tmpl.TemplateControl</code> itself</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.tmpl.TemplateControl attachAfterRendering(sap.ui.@base.EventDelegate fnFunction, object oListener);

						/// <summary>
						/// Detaches event handler <code>fnFunction</code> from the {@link #event:afterRendering afterRendering} event of this <code>sap.ui.core.tmpl.TemplateControl</code>.
						/// 
						/// The passed function and listener object must match the ones used for event registration.
						/// </summary>
						/// <param name="fnFunction">The function to be called, when the event occurs</param>
						/// <param name="oListener">Context object on which the given function had to be called</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.tmpl.TemplateControl detachAfterRendering(sap.ui.@base.EventDelegate fnFunction, object oListener);

						/// <summary>
						/// Fires event {@link #event:afterRendering afterRendering} to attached listeners.
						/// </summary>
						/// <param name="mParameters">Parameters to pass along with the event</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.tmpl.TemplateControl fireAfterRendering(object mParameters);

						/// <summary>
						/// Fires event {@link #event:afterRendering afterRendering} to attached listeners.
						/// </summary>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.tmpl.TemplateControl fireAfterRendering();

						#endregion

						#region Methods for Event beforeRendering

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeRendering beforeRendering} event of this <code>sap.ui.core.tmpl.TemplateControl</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.core.tmpl.TemplateControl</code> itself.
						/// 
						/// Fired before this Template Control is re-rendered. Use to unbind event handlers from HTML elements etc.
						/// </summary>
						/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.core.tmpl.TemplateControl</code> itself</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.tmpl.TemplateControl attachBeforeRendering(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeRendering beforeRendering} event of this <code>sap.ui.core.tmpl.TemplateControl</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.core.tmpl.TemplateControl</code> itself.
						/// 
						/// Fired before this Template Control is re-rendered. Use to unbind event handlers from HTML elements etc.
						/// </summary>
						/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.tmpl.TemplateControl attachBeforeRendering(object oData, sap.ui.@base.EventDelegate fnFunction);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeRendering beforeRendering} event of this <code>sap.ui.core.tmpl.TemplateControl</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.core.tmpl.TemplateControl</code> itself.
						/// 
						/// Fired before this Template Control is re-rendered. Use to unbind event handlers from HTML elements etc.
						/// </summary>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.tmpl.TemplateControl attachBeforeRendering(sap.ui.@base.EventDelegate fnFunction);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeRendering beforeRendering} event of this <code>sap.ui.core.tmpl.TemplateControl</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.core.tmpl.TemplateControl</code> itself.
						/// 
						/// Fired before this Template Control is re-rendered. Use to unbind event handlers from HTML elements etc.
						/// </summary>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.core.tmpl.TemplateControl</code> itself</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.tmpl.TemplateControl attachBeforeRendering(sap.ui.@base.EventDelegate fnFunction, object oListener);

						/// <summary>
						/// Detaches event handler <code>fnFunction</code> from the {@link #event:beforeRendering beforeRendering} event of this <code>sap.ui.core.tmpl.TemplateControl</code>.
						/// 
						/// The passed function and listener object must match the ones used for event registration.
						/// </summary>
						/// <param name="fnFunction">The function to be called, when the event occurs</param>
						/// <param name="oListener">Context object on which the given function had to be called</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.tmpl.TemplateControl detachBeforeRendering(sap.ui.@base.EventDelegate fnFunction, object oListener);

						/// <summary>
						/// Fires event {@link #event:beforeRendering beforeRendering} to attached listeners.
						/// </summary>
						/// <param name="mParameters">Parameters to pass along with the event</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.tmpl.TemplateControl fireBeforeRendering(object mParameters);

						/// <summary>
						/// Fires event {@link #event:beforeRendering beforeRendering} to attached listeners.
						/// </summary>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.tmpl.TemplateControl fireBeforeRendering();

						#endregion

						#region Other methods

						/// <summary>
						/// Creates a pseudo binding for an aggregation to get notified once the property changes to invalidate the control and trigger a re-rendering.
						/// </summary>
						/// <param name="sPath">the binding path</param>
						/// <returns>the value of the path</returns>
						public extern virtual object bindList(string sPath);

						/// <summary>
						/// Creates a pseudo binding for a property to get notified once the property changes to invalidate the control and trigger a re-rendering.
						/// </summary>
						/// <param name="sPath">the binding path</param>
						/// <returns>the value of the path</returns>
						public extern virtual object bindProp(string sPath);

						/// <summary>
						/// compiles (creates and registers) a new control
						/// </summary>
						/// <param name="mSettings">the settings for the new control</param>
						/// <param name="sParentPath">the parent path for the control</param>
						/// <param name="bDoNotAdd">if true, then the control will not be added to the _controls aggregation</param>
						/// <param name="oView"></param>
						/// <returns>new control instance</returns>
						public extern virtual sap.ui.core.Control createControl(object mSettings, string sParentPath, bool bDoNotAdd, sap.ui.core.mvc.View oView);

						/// <summary>
						/// compiles (creates and registers) a new DOM element
						/// </summary>
						/// <param name="mSettings">the settings for the new DOM element</param>
						/// <param name="sParentPath">the parent path for the DOM element</param>
						/// <param name="bDoNotAdd">if true, then the control will not be added to the _controls aggregation</param>
						/// <returns>new DOM element instance</returns>
						public extern virtual sap.ui.core.Control createDOMElement(object mSettings, string sParentPath, bool bDoNotAdd);

						/// <summary>
						/// compiles (creates and registers) a new DOM element
						/// </summary>
						/// <param name="mSettings">the settings for the new DOM element</param>
						/// <param name="sParentPath">the parent path for the DOM element</param>
						/// <returns>new DOM element instance</returns>
						public extern virtual sap.ui.core.Control createDOMElement(object mSettings, string sParentPath);

						/// <summary>
						/// compiles (creates and registers) a new DOM element
						/// </summary>
						/// <param name="mSettings">the settings for the new DOM element</param>
						/// <returns>new DOM element instance</returns>
						public extern virtual sap.ui.core.Control createDOMElement(object mSettings);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.tmpl.TemplateControl with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.tmpl.TemplateControl with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.tmpl.TemplateControl with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns a metadata object for class sap.ui.core.tmpl.TemplateControl.
						/// </summary>
						/// <returns>Metadata object describing this class</returns>
						public extern static sap.ui.@base.Metadata getMetadata();

						/// <summary>
						/// Returns the instance specific renderer for an anonymous template control.
						/// </summary>
						/// <returns>the instance specific renderer function</returns>
						public extern virtual object getTemplateRenderer();

						/// <summary>
						/// checks whether the control is inline or not
						/// </summary>
						/// <returns>flag, whether to control is inline or not</returns>
						public extern virtual bool isInline();

						/// <summary>
						/// Sets the instance specific renderer for an anonymous template control.
						/// </summary>
						/// <param name="fnRenderer">the instance specific renderer function</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.tmpl.Template setTemplateRenderer(object fnRenderer);

						#endregion

						#endregion

					}
				}
			}
		}
	}
}
