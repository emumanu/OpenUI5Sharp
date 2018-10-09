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
				public static partial class mvc
				{
					/// <summary>
					/// A base class for Views.
					/// 
					/// Introduces the relationship to a Controller, some basic visual appearance settings like width and height, and provides lifecycle events.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.core.mvc.View")]
					public partial class View : sap.ui.core.Control, sap.ui.core.IDScope
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
							/// Controller instance to use for this view.
							/// </summary>
							public Union<sap.ui.core.mvc.Controller, string, sap.ui.@base.ManagedObject.BindPropertyInfo> controller;

							/// <summary>
							/// Name of the controller class to use for this view. If given, it overrides the same information in the view definition (XML, HTML).
							/// </summary>
							public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> controllerName;

							/// <summary>
							/// Preprocessors that the view can use before constructing the view.
							/// </summary>
							public Union<object, string, sap.ui.@base.ManagedObject.BindPropertyInfo> preprocessors;

							/// <summary>
							/// (module) Name of a resource bundle that should be loaded for this view
							/// </summary>
							public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> resourceBundleName;

							/// <summary>
							/// URL of a resource bundle that should be loaded for this view
							/// </summary>
							public Union<sap.ui.core.URI, string, sap.ui.@base.ManagedObject.BindPropertyInfo> resourceBundleUrl;

							/// <summary>
							/// Locale that should be used to load a resource bundle for this view
							/// </summary>
							public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> resourceBundleLocale;

							/// <summary>
							/// Model name under which the resource bundle should be stored.
							/// </summary>
							public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> resourceBundleAlias;

							/// <summary>
							/// Type of the view
							/// </summary>
							public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> type;

							/// <summary>
							/// A view definition
							/// </summary>
							public Union<object, string, sap.ui.@base.ManagedObject.BindPropertyInfo> definition;

							/// <summary>
							/// Deprecated as of 1.56: Use <code>definition</code> instead.
							/// </summary>
							public Union<object, string, sap.ui.@base.ManagedObject.BindPropertyInfo> viewContent;

							/// <summary>
							/// Additional configuration data that should be given to the view at construction time and which will be available early, even before model data or other constructor settings are applied.
							/// </summary>
							public Union<object, string, sap.ui.@base.ManagedObject.BindPropertyInfo> viewData;

							/// <summary>
							/// Determines initialization mode of the view
							/// </summary>
							public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> async;

							/// <summary>
							/// The width
							/// </summary>
							public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> width;

							/// <summary>
							/// The height
							/// </summary>
							public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> height;

							/// <summary>
							/// Name of the View
							/// </summary>
							public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> viewName;

							/// <summary>
							/// Whether the CSS display should be set to "block". Set this to "true" if the default display "inline-block" causes a vertical scrollbar with Views that are set to 100% height. Do not set this to "true" if you want to display other content in the same HTML parent on either side of the View (setting to "true" may push that other content to the next/previous line).
							/// </summary>
							public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> displayBlock;

							/// <summary>
							/// Child Controls of the view
							/// </summary>
							public Union<sap.ui.core.Control[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> content;

							/// <summary>
							/// Fired when the View has parsed the UI description and instantiated the contained controls (/control tree).
							/// </summary>
							public sap.ui.@base.EventDelegate afterInit;

							/// <summary>
							/// Fired when the view has received the request to destroy itself, but before it has destroyed anything.
							/// </summary>
							public sap.ui.@base.EventDelegate beforeExit;

							/// <summary>
							/// Fired when the View has been (re-)rendered and its HTML is present in the DOM.
							/// </summary>
							public sap.ui.@base.EventDelegate afterRendering;

							/// <summary>
							/// Fired before this View is re-rendered. Use to unbind event handlers from HTML elements etc.
							/// </summary>
							public sap.ui.@base.EventDelegate beforeRendering;

						}

						#endregion

						#region Typed Parameters

						/// <summary>
						/// Parameter to be used as Object Literal
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class CreateOptions
						{
							/// <summary>
							/// Specifies an ID for the View instance. If no ID is given, an ID will be generated.
							/// </summary>
							public string id;

							/// <summary>
							/// Name of the view resource in module name notation (without suffix)
							/// </summary>
							public string viewName;

							/// <summary>
							/// Specifies what kind of view will be instantiated. All valid view types are listed in the enumeration {@link sap.ui.core.mvc.ViewType}.
							/// </summary>
							public sap.ui.core.mvc.ViewType type;

							/// <summary>
							/// The view data can hold user specific data. This data is available during the whole lifecycle of the view and the controller
							/// </summary>
							public object viewData;

							/// <summary>
							/// Can hold a map from the specified preprocessor type (e.g. "xml") to an array of preprocessor configurations; each configuration consists of a <code>preprocessor</code> property (optional when registered as on-demand preprocessor) and may contain further preprocessor-specific settings. The preprocessor can be either a module name as string implementation of {@link sap.ui.core.mvc.View.Preprocessor} or a function according to {@link sap.ui.core.mvc.View.Preprocessor.process}. Do not set properties starting with underscore like <code>_sProperty</code> property, these are reserved for internal purposes. When several preprocessors are provided for one hook, it has to be made sure that they do not conflict when being processed serially. <strong>Note</strong>: These preprocessors are only available to this instance. For global or on-demand availability use {@link sap.ui.core.mvc.XMLView.registerPreprocessor}. <strong>Note</strong>: Please note that preprocessors in general are currently only available to XMLViews
							/// </summary>
							public object preprocessors;

							/// <summary>
							/// Controller instance to be used for this view. The given controller instance overrides the controller defined in the view definition. Sharing a controller instance between multiple views is not supported.
							/// </summary>
							public sap.ui.core.mvc.Controller controller;

						}

						#endregion

						#region Constructor

						/// <summary>
						/// Constructor for a new View.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
						/// <param name="mSettings">Initial settings for the new control</param>
						public extern View(string sId, sap.ui.core.mvc.View.Settings mSettings);

						/// <summary>
						/// Constructor for a new View.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
						public extern View(string sId);

						/// <summary>
						/// Constructor for a new View.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						public extern View();

						/// <summary>
						/// Constructor for a new View.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="mSettings">Initial settings for the new control</param>
						public extern View(sap.ui.core.mvc.View.Settings mSettings);

						#endregion

						#region Methods

						#region Methods for Property width

						/// <summary>
						/// Gets current value of property {@link #getWidth width}.
						/// 
						/// The width
						/// 
						/// Default value is <code>100%</code>.
						/// </summary>
						/// <returns>Value of property <code>width</code></returns>
						public extern virtual sap.ui.core.CSSSize getWidth();

						/// <summary>
						/// Sets a new value for property {@link #getWidth width}.
						/// 
						/// The width
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>100%</code>.
						/// </summary>
						/// <param name="sWidth">New value for property <code>width</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.mvc.View setWidth(sap.ui.core.CSSSize sWidth);

						#endregion

						#region Methods for Property height

						/// <summary>
						/// Gets current value of property {@link #getHeight height}.
						/// 
						/// The height
						/// </summary>
						/// <returns>Value of property <code>height</code></returns>
						public extern virtual sap.ui.core.CSSSize getHeight();

						/// <summary>
						/// Sets a new value for property {@link #getHeight height}.
						/// 
						/// The height
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// </summary>
						/// <param name="sHeight">New value for property <code>height</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.mvc.View setHeight(sap.ui.core.CSSSize sHeight);

						#endregion

						#region Methods for Property viewName

						/// <summary>
						/// Gets current value of property {@link #getViewName viewName}.
						/// 
						/// Name of the View
						/// </summary>
						/// <returns>Value of property <code>viewName</code></returns>
						public extern virtual string getViewName();

						/// <summary>
						/// Sets a new value for property {@link #getViewName viewName}.
						/// 
						/// Name of the View
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// </summary>
						/// <param name="sViewName">New value for property <code>viewName</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.mvc.View setViewName(string sViewName);

						#endregion

						#region Methods for Property displayBlock

						/// <summary>
						/// Gets current value of property {@link #getDisplayBlock displayBlock}.
						/// 
						/// Whether the CSS display should be set to "block". Set this to "true" if the default display "inline-block" causes a vertical scrollbar with Views that are set to 100% height. Do not set this to "true" if you want to display other content in the same HTML parent on either side of the View (setting to "true" may push that other content to the next/previous line).
						/// 
						/// Default value is <code>false</code>.
						/// </summary>
						/// <returns>Value of property <code>displayBlock</code></returns>
						public extern virtual bool getDisplayBlock();

						/// <summary>
						/// Sets a new value for property {@link #getDisplayBlock displayBlock}.
						/// 
						/// Whether the CSS display should be set to "block". Set this to "true" if the default display "inline-block" causes a vertical scrollbar with Views that are set to 100% height. Do not set this to "true" if you want to display other content in the same HTML parent on either side of the View (setting to "true" may push that other content to the next/previous line).
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>false</code>.
						/// </summary>
						/// <param name="bDisplayBlock">New value for property <code>displayBlock</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.mvc.View setDisplayBlock(bool bDisplayBlock);

						#endregion

						#region Methods for Aggregation content

						/// <summary>
						/// Gets content of aggregation {@link #getContent content}.
						/// 
						/// Child Controls of the view
						/// </summary>
						/// <returns></returns>
						public extern virtual sap.ui.core.Control[] getContent();

						/// <summary>
						/// Destroys all the content in the aggregation {@link #getContent content}.
						/// </summary>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.mvc.View destroyContent();

						/// <summary>
						/// Inserts a content into the aggregation {@link #getContent content}.
						/// </summary>
						/// <param name="oContent">The content to insert; if empty, nothing is inserted</param>
						/// <param name="iIndex">The <code>0</code>-based index the content should be inserted at; for a negative value of <code>iIndex</code>, the content is inserted at position 0; for a value greater than the current size of the aggregation, the content is inserted at the last position</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.mvc.View insertContent(sap.ui.core.Control oContent, int iIndex);

						/// <summary>
						/// Adds some content to the aggregation {@link #getContent content}.
						/// </summary>
						/// <param name="oContent">The content to add; if empty, nothing is inserted</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.mvc.View addContent(sap.ui.core.Control oContent);

						/// <summary>
						/// Removes a content from the aggregation {@link #getContent content}.
						/// </summary>
						/// <param name="vContent">The content to remove or its index or id</param>
						/// <returns>The removed content or <code>null</code></returns>
						public extern virtual sap.ui.core.Control removeContent(Union<int, string, sap.ui.core.Control> vContent);

						/// <summary>
						/// Checks for the provided <code>sap.ui.core.Control</code> in the aggregation {@link #getContent content}. and returns its index if found or -1 otherwise.
						/// </summary>
						/// <param name="oContent">The content whose index is looked for</param>
						/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
						public extern virtual int indexOfContent(sap.ui.core.Control oContent);

						/// <summary>
						/// Removes all the controls from the aggregation {@link #getContent content}.
						/// 
						/// Additionally, it unregisters them from the hosting UIArea.
						/// </summary>
						/// <returns>An array of the removed elements (might be empty)</returns>
						public extern virtual sap.ui.core.Control[] removeAllContent();

						#endregion

						#region Methods for Event afterInit

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterInit afterInit} event of this <code>sap.ui.core.mvc.View</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.core.mvc.View</code> itself.
						/// 
						/// Fired when the View has parsed the UI description and instantiated the contained controls (/control tree).
						/// </summary>
						/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.core.mvc.View</code> itself</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.mvc.View attachAfterInit(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterInit afterInit} event of this <code>sap.ui.core.mvc.View</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.core.mvc.View</code> itself.
						/// 
						/// Fired when the View has parsed the UI description and instantiated the contained controls (/control tree).
						/// </summary>
						/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.mvc.View attachAfterInit(object oData, sap.ui.@base.EventDelegate fnFunction);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterInit afterInit} event of this <code>sap.ui.core.mvc.View</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.core.mvc.View</code> itself.
						/// 
						/// Fired when the View has parsed the UI description and instantiated the contained controls (/control tree).
						/// </summary>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.mvc.View attachAfterInit(sap.ui.@base.EventDelegate fnFunction);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterInit afterInit} event of this <code>sap.ui.core.mvc.View</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.core.mvc.View</code> itself.
						/// 
						/// Fired when the View has parsed the UI description and instantiated the contained controls (/control tree).
						/// </summary>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.core.mvc.View</code> itself</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.mvc.View attachAfterInit(sap.ui.@base.EventDelegate fnFunction, object oListener);

						/// <summary>
						/// Detaches event handler <code>fnFunction</code> from the {@link #event:afterInit afterInit} event of this <code>sap.ui.core.mvc.View</code>.
						/// 
						/// The passed function and listener object must match the ones used for event registration.
						/// </summary>
						/// <param name="fnFunction">The function to be called, when the event occurs</param>
						/// <param name="oListener">Context object on which the given function had to be called</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.mvc.View detachAfterInit(sap.ui.@base.EventDelegate fnFunction, object oListener);

						/// <summary>
						/// Fires event {@link #event:afterInit afterInit} to attached listeners.
						/// </summary>
						/// <param name="mParameters">Parameters to pass along with the event</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.mvc.View fireAfterInit(object mParameters);

						/// <summary>
						/// Fires event {@link #event:afterInit afterInit} to attached listeners.
						/// </summary>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.mvc.View fireAfterInit();

						#endregion

						#region Methods for Event beforeExit

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeExit beforeExit} event of this <code>sap.ui.core.mvc.View</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.core.mvc.View</code> itself.
						/// 
						/// Fired when the view has received the request to destroy itself, but before it has destroyed anything.
						/// </summary>
						/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.core.mvc.View</code> itself</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.mvc.View attachBeforeExit(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeExit beforeExit} event of this <code>sap.ui.core.mvc.View</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.core.mvc.View</code> itself.
						/// 
						/// Fired when the view has received the request to destroy itself, but before it has destroyed anything.
						/// </summary>
						/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.mvc.View attachBeforeExit(object oData, sap.ui.@base.EventDelegate fnFunction);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeExit beforeExit} event of this <code>sap.ui.core.mvc.View</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.core.mvc.View</code> itself.
						/// 
						/// Fired when the view has received the request to destroy itself, but before it has destroyed anything.
						/// </summary>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.mvc.View attachBeforeExit(sap.ui.@base.EventDelegate fnFunction);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeExit beforeExit} event of this <code>sap.ui.core.mvc.View</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.core.mvc.View</code> itself.
						/// 
						/// Fired when the view has received the request to destroy itself, but before it has destroyed anything.
						/// </summary>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.core.mvc.View</code> itself</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.mvc.View attachBeforeExit(sap.ui.@base.EventDelegate fnFunction, object oListener);

						/// <summary>
						/// Detaches event handler <code>fnFunction</code> from the {@link #event:beforeExit beforeExit} event of this <code>sap.ui.core.mvc.View</code>.
						/// 
						/// The passed function and listener object must match the ones used for event registration.
						/// </summary>
						/// <param name="fnFunction">The function to be called, when the event occurs</param>
						/// <param name="oListener">Context object on which the given function had to be called</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.mvc.View detachBeforeExit(sap.ui.@base.EventDelegate fnFunction, object oListener);

						/// <summary>
						/// Fires event {@link #event:beforeExit beforeExit} to attached listeners.
						/// </summary>
						/// <param name="mParameters">Parameters to pass along with the event</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.mvc.View fireBeforeExit(object mParameters);

						/// <summary>
						/// Fires event {@link #event:beforeExit beforeExit} to attached listeners.
						/// </summary>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.mvc.View fireBeforeExit();

						#endregion

						#region Methods for Event afterRendering

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterRendering afterRendering} event of this <code>sap.ui.core.mvc.View</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.core.mvc.View</code> itself.
						/// 
						/// Fired when the View has been (re-)rendered and its HTML is present in the DOM.
						/// </summary>
						/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.core.mvc.View</code> itself</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.mvc.View attachAfterRendering(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterRendering afterRendering} event of this <code>sap.ui.core.mvc.View</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.core.mvc.View</code> itself.
						/// 
						/// Fired when the View has been (re-)rendered and its HTML is present in the DOM.
						/// </summary>
						/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.mvc.View attachAfterRendering(object oData, sap.ui.@base.EventDelegate fnFunction);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterRendering afterRendering} event of this <code>sap.ui.core.mvc.View</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.core.mvc.View</code> itself.
						/// 
						/// Fired when the View has been (re-)rendered and its HTML is present in the DOM.
						/// </summary>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.mvc.View attachAfterRendering(sap.ui.@base.EventDelegate fnFunction);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterRendering afterRendering} event of this <code>sap.ui.core.mvc.View</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.core.mvc.View</code> itself.
						/// 
						/// Fired when the View has been (re-)rendered and its HTML is present in the DOM.
						/// </summary>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.core.mvc.View</code> itself</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.mvc.View attachAfterRendering(sap.ui.@base.EventDelegate fnFunction, object oListener);

						/// <summary>
						/// Detaches event handler <code>fnFunction</code> from the {@link #event:afterRendering afterRendering} event of this <code>sap.ui.core.mvc.View</code>.
						/// 
						/// The passed function and listener object must match the ones used for event registration.
						/// </summary>
						/// <param name="fnFunction">The function to be called, when the event occurs</param>
						/// <param name="oListener">Context object on which the given function had to be called</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.mvc.View detachAfterRendering(sap.ui.@base.EventDelegate fnFunction, object oListener);

						/// <summary>
						/// Fires event {@link #event:afterRendering afterRendering} to attached listeners.
						/// </summary>
						/// <param name="mParameters">Parameters to pass along with the event</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.mvc.View fireAfterRendering(object mParameters);

						/// <summary>
						/// Fires event {@link #event:afterRendering afterRendering} to attached listeners.
						/// </summary>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.mvc.View fireAfterRendering();

						#endregion

						#region Methods for Event beforeRendering

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeRendering beforeRendering} event of this <code>sap.ui.core.mvc.View</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.core.mvc.View</code> itself.
						/// 
						/// Fired before this View is re-rendered. Use to unbind event handlers from HTML elements etc.
						/// </summary>
						/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.core.mvc.View</code> itself</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.mvc.View attachBeforeRendering(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeRendering beforeRendering} event of this <code>sap.ui.core.mvc.View</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.core.mvc.View</code> itself.
						/// 
						/// Fired before this View is re-rendered. Use to unbind event handlers from HTML elements etc.
						/// </summary>
						/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.mvc.View attachBeforeRendering(object oData, sap.ui.@base.EventDelegate fnFunction);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeRendering beforeRendering} event of this <code>sap.ui.core.mvc.View</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.core.mvc.View</code> itself.
						/// 
						/// Fired before this View is re-rendered. Use to unbind event handlers from HTML elements etc.
						/// </summary>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.mvc.View attachBeforeRendering(sap.ui.@base.EventDelegate fnFunction);

						/// <summary>
						/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeRendering beforeRendering} event of this <code>sap.ui.core.mvc.View</code>.
						/// 
						/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.core.mvc.View</code> itself.
						/// 
						/// Fired before this View is re-rendered. Use to unbind event handlers from HTML elements etc.
						/// </summary>
						/// <param name="fnFunction">The function to be called when the event occurs</param>
						/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.core.mvc.View</code> itself</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.mvc.View attachBeforeRendering(sap.ui.@base.EventDelegate fnFunction, object oListener);

						/// <summary>
						/// Detaches event handler <code>fnFunction</code> from the {@link #event:beforeRendering beforeRendering} event of this <code>sap.ui.core.mvc.View</code>.
						/// 
						/// The passed function and listener object must match the ones used for event registration.
						/// </summary>
						/// <param name="fnFunction">The function to be called, when the event occurs</param>
						/// <param name="oListener">Context object on which the given function had to be called</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.mvc.View detachBeforeRendering(sap.ui.@base.EventDelegate fnFunction, object oListener);

						/// <summary>
						/// Fires event {@link #event:beforeRendering beforeRendering} to attached listeners.
						/// </summary>
						/// <param name="mParameters">Parameters to pass along with the event</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.mvc.View fireBeforeRendering(object mParameters);

						/// <summary>
						/// Fires event {@link #event:beforeRendering beforeRendering} to attached listeners.
						/// </summary>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.mvc.View fireBeforeRendering();

						#endregion

						#region Other methods

						/// <summary>
						/// Returns an element by its ID in the context of the view.
						/// </summary>
						/// <param name="sId">View local ID of the element</param>
						/// <returns>element by its ID or <code>undefined</code></returns>
						public extern virtual sap.ui.core.Element byId(string sId);

						/// <summary>
						/// Override clone method to avoid conflict between generic cloning of content and content creation as defined by the UI5 Model View Controller lifecycle.
						/// 
						/// For more details see the development guide section about Model View Controller in UI5.
						/// </summary>
						/// <param name="sIdSuffix">a suffix to be appended to the cloned element id</param>
						/// <param name="aLocalIds">an array of local IDs within the cloned hierarchy (internally used)</param>
						/// <returns>reference to the newly created clone</returns>
						public extern override sap.ui.core.Element clone(string sIdSuffix, string[] aLocalIds);

						/// <summary>
						/// Override clone method to avoid conflict between generic cloning of content and content creation as defined by the UI5 Model View Controller lifecycle.
						/// 
						/// For more details see the development guide section about Model View Controller in UI5.
						/// </summary>
						/// <param name="sIdSuffix">a suffix to be appended to the cloned element id</param>
						/// <param name="aLocalIds">an array of local IDs within the cloned hierarchy (internally used)</param>
						/// <returns>reference to the newly created clone</returns>
						public extern override sap.ui.core.Element clone(string sIdSuffix, object[] aLocalIds);

						/// <summary>
						/// Override clone method to avoid conflict between generic cloning of content and content creation as defined by the UI5 Model View Controller lifecycle.
						/// 
						/// For more details see the development guide section about Model View Controller in UI5.
						/// </summary>
						/// <param name="sIdSuffix">a suffix to be appended to the cloned element id</param>
						/// <returns>reference to the newly created clone</returns>
						public extern override sap.ui.core.Element clone(string sIdSuffix);

						/// <summary>
						/// Override clone method to avoid conflict between generic cloning of content and content creation as defined by the UI5 Model View Controller lifecycle.
						/// 
						/// For more details see the development guide section about Model View Controller in UI5.
						/// </summary>
						/// <returns>reference to the newly created clone</returns>
						public extern override sap.ui.core.Element clone();

						/// <summary>
						/// Override clone method to avoid conflict between generic cloning of content and content creation as defined by the UI5 Model View Controller lifecycle.
						/// 
						/// For more details see the development guide section about Model View Controller in UI5.
						/// </summary>
						/// <param name="aLocalIds">an array of local IDs within the cloned hierarchy (internally used)</param>
						/// <returns>reference to the newly created clone</returns>
						public extern override sap.ui.core.Element clone(string[] aLocalIds);

						/// <summary>
						/// Override clone method to avoid conflict between generic cloning of content and content creation as defined by the UI5 Model View Controller lifecycle.
						/// 
						/// For more details see the development guide section about Model View Controller in UI5.
						/// </summary>
						/// <param name="aLocalIds">an array of local IDs within the cloned hierarchy (internally used)</param>
						/// <returns>reference to the newly created clone</returns>
						public extern override sap.ui.core.Element clone(object[] aLocalIds);

						/// <summary>
						/// Creates a view of the given type, name and with the given id.
						/// </summary>
						/// <param name="mOptions">A parameter map for the view instantiation. Specialized view types could bring in additional parameter.</param>
						/// <returns>a Promise which resolves with the created View instance</returns>
						public extern static jquery.JQueryPromise<object> create(sap.ui.core.mvc.View.CreateOptions mOptions);

						/// <summary>
						/// Convert the given view local element ID to a globally unique ID by prefixing it with the view ID.
						/// </summary>
						/// <param name="sId">View local ID of the element</param>
						/// <returns>prefixed id</returns>
						public extern virtual string createId(string sId);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.mvc.View with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.mvc.View with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.mvc.View with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns the view's Controller instance or null for a controller-less View.
						/// </summary>
						/// <returns>Controller of this view.</returns>
						public extern virtual object getController();

						/// <summary>
						/// An (optional) method to be implemented by Views. When no controller instance is given at View instantiation time AND this method exists and returns the (package and class) name of a controller, the View tries to load and instantiate the controller and to connect it to itself.
						/// </summary>
						/// <returns>the name of the controller</returns>
						public extern virtual string getControllerName();

						/// <summary>
						/// Returns the local ID of an element by removing the view ID prefix or <code>null</code> if the ID does not contain a prefix.
						/// </summary>
						/// <param name="sId">Prefixed ID</param>
						/// <returns>ID without prefix or <code>null</code></returns>
						public extern virtual string getLocalId(string sId);

						/// <summary>
						/// Returns a metadata object for class sap.ui.core.mvc.View.
						/// </summary>
						/// <returns>Metadata object describing this class</returns>
						public extern static sap.ui.@base.Metadata getMetadata();

						/// <summary>
						/// Returns the info object which is also passed to the preprocessors
						/// </summary>
						/// <param name="bSync">Describes the view execution, true if sync</param>
						/// <returns>Info object for the view</returns>
						public extern virtual object getPreprocessorInfo(bool bSync);

						/// <summary>
						/// Returns user specific data object
						/// </summary>
						/// <returns>viewData</returns>
						public extern virtual object getViewData();

						/// <summary>
						/// Checks if any preprocessors are active for the specified type
						/// </summary>
						/// <param name="sType">Type of the preprocessor, e.g. "raw", "xml" or "controls"</param>
						/// <returns><code>true</code> if a preprocessor is active</returns>
						public extern virtual bool hasPreprocessor(string sType);

						/// <summary>
						/// Creates a Promise representing the state of the view initialization.
						/// 
						/// For views that are loading asynchronously (by setting async=true) this Promise is created by view initialization. Synchronously loading views get wrapped in an immediately resolving Promise.
						/// </summary>
						/// <returns>resolves with the complete view instance, reject with any thrown error</returns>
						public extern virtual jquery.JQueryPromise<object> loaded();

						/// <summary>
						/// Register a preprocessor for all views of a specific type.
						/// 
						/// The preprocessor can be registered for several stages of view initialization, which are dependent on the view type, e.g. "raw", "xml" or already initialized "controls". If there is a preprocessor passed to or activated at the view instance already, that one is used. When several preprocessors are registered for one hook, it has to be made sure that they do not conflict when being processed serially.
						/// 
						/// It can be either a module name as string of an implementation of {@link sap.ui.core.mvc.View.Preprocessor} or a function with a signature according to {@link sap.ui.core.mvc.View.Preprocessor.process}.
						/// 
						/// <strong>Note</strong>: Preprocessors only work in async views and will be ignored when the view is instantiated in sync mode by default, as this could have unexpected side effects. You may override this behaviour by setting the <code>bSyncSupport</code> flag to <code>true</code>.
						/// </summary>
						/// <param name="sType">the type of content to be processed</param>
						/// <param name="vPreprocessor">module path of the preprocessor implementation or a preprocessor function</param>
						/// <param name="sViewType">type of the calling view, e.g. <code>XML</code></param>
						/// <param name="bSyncSupport">declares if the vPreprocessor ensures safe sync processing. This means the preprocessor will be executed also for sync views. Please be aware that any kind of async processing (like Promises, XHR, etc) may break the view initialization and lead to unexpected results.</param>
						/// <param name="bOnDemand">on-demand preprocessor which enables developers to quickly activate the preprocessor for a view, by setting <code>preprocessors : { xml }</code>, for example. This should be false except for very special cases. There can only be one on-demand preprocessor per content type.</param>
						/// <param name="mSettings">optional configuration for preprocessor</param>
						public extern static void registerPreprocessor(string sType, Union<string, object> vPreprocessor, string sViewType, bool bSyncSupport, bool bOnDemand, object mSettings);

						/// <summary>
						/// Register a preprocessor for all views of a specific type.
						/// 
						/// The preprocessor can be registered for several stages of view initialization, which are dependent on the view type, e.g. "raw", "xml" or already initialized "controls". If there is a preprocessor passed to or activated at the view instance already, that one is used. When several preprocessors are registered for one hook, it has to be made sure that they do not conflict when being processed serially.
						/// 
						/// It can be either a module name as string of an implementation of {@link sap.ui.core.mvc.View.Preprocessor} or a function with a signature according to {@link sap.ui.core.mvc.View.Preprocessor.process}.
						/// 
						/// <strong>Note</strong>: Preprocessors only work in async views and will be ignored when the view is instantiated in sync mode by default, as this could have unexpected side effects. You may override this behaviour by setting the <code>bSyncSupport</code> flag to <code>true</code>.
						/// </summary>
						/// <param name="sType">the type of content to be processed</param>
						/// <param name="vPreprocessor">module path of the preprocessor implementation or a preprocessor function</param>
						/// <param name="sViewType">type of the calling view, e.g. <code>XML</code></param>
						/// <param name="bSyncSupport">declares if the vPreprocessor ensures safe sync processing. This means the preprocessor will be executed also for sync views. Please be aware that any kind of async processing (like Promises, XHR, etc) may break the view initialization and lead to unexpected results.</param>
						/// <param name="bOnDemand">on-demand preprocessor which enables developers to quickly activate the preprocessor for a view, by setting <code>preprocessors : { xml }</code>, for example. This should be false except for very special cases. There can only be one on-demand preprocessor per content type.</param>
						public extern static void registerPreprocessor(string sType, Union<string, object> vPreprocessor, string sViewType, bool bSyncSupport, bool bOnDemand);

						/// <summary>
						/// Register a preprocessor for all views of a specific type.
						/// 
						/// The preprocessor can be registered for several stages of view initialization, which are dependent on the view type, e.g. "raw", "xml" or already initialized "controls". If there is a preprocessor passed to or activated at the view instance already, that one is used. When several preprocessors are registered for one hook, it has to be made sure that they do not conflict when being processed serially.
						/// 
						/// It can be either a module name as string of an implementation of {@link sap.ui.core.mvc.View.Preprocessor} or a function with a signature according to {@link sap.ui.core.mvc.View.Preprocessor.process}.
						/// 
						/// <strong>Note</strong>: Preprocessors only work in async views and will be ignored when the view is instantiated in sync mode by default, as this could have unexpected side effects. You may override this behaviour by setting the <code>bSyncSupport</code> flag to <code>true</code>.
						/// </summary>
						/// <param name="sType">the type of content to be processed</param>
						/// <param name="vPreprocessor">module path of the preprocessor implementation or a preprocessor function</param>
						/// <param name="sViewType">type of the calling view, e.g. <code>XML</code></param>
						/// <param name="bSyncSupport">declares if the vPreprocessor ensures safe sync processing. This means the preprocessor will be executed also for sync views. Please be aware that any kind of async processing (like Promises, XHR, etc) may break the view initialization and lead to unexpected results.</param>
						public extern static void registerPreprocessor(string sType, Union<string, object> vPreprocessor, string sViewType, bool bSyncSupport);

						/// <summary>
						/// Executes preprocessors for a type of source
						/// </summary>
						/// <param name="sType">the type of preprocessor, e.g. "raw", "xml" or "controls"</param>
						/// <param name="vSource">the view source as a JSON object, a raw text, an XML document element or a Promise resolving with those</param>
						/// <param name="bSync">describes the view execution, true if sync</param>
						/// <returns>a promise resolving with the processed source or an error | the source when bSync=true</returns>
						public extern virtual Union<jquery.JQueryPromise<object>, object, string, dom.HTMLElement> runPreprocessor(string sType, Union<object, string, dom.HTMLElement> vSource, bool bSync);

						/// <summary>
						/// Executes preprocessors for a type of source
						/// </summary>
						/// <param name="sType">the type of preprocessor, e.g. "raw", "xml" or "controls"</param>
						/// <param name="vSource">the view source as a JSON object, a raw text, an XML document element or a Promise resolving with those</param>
						/// <returns>a promise resolving with the processed source or an error | the source when bSync=true</returns>
						public extern virtual Union<jquery.JQueryPromise<object>, object, string, dom.HTMLElement> runPreprocessor(string sType, Union<object, string, dom.HTMLElement> vSource);

						#endregion

						#endregion

						/// <summary>
						/// Interface for Preprocessor implementations that can be hooked in the view life cycle.
						/// 
						/// There are two possibilities to use the preprocessor. It can be either passed to the view via the mSettings.preprocessors object where it is the executed only for this instance, or by the registerPreprocessor method of the view type. Currently this is available only for XMLViews (as of version 1.30).
						/// </summary>
						[External]
						[Namespace(false)]
						[Name("sap.ui.core.mvc.View.Preprocessor")]
						public partial interface Preprocessor
						{
							#region Methods

							#endregion

						}
					}
				}
			}
		}
	}
}
