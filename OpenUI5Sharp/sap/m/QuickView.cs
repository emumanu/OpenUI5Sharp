using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public static partial class sap
	{
		public static partial class m
		{
			/// <summary>
			/// A responsive popover that displays information on an object in a business-card format. <h3>Overview</h3> The quick view is used to show business information on either a person or an entity (e.g. a company). It uses a set of pre-defined controls. Objects can be linked together and you can navigate between several objects. An unlimited number of objects can be linked. <h3>Structure</h3> Each card is represented by a {@link sap.m.QuickViewPage} which holds all the information (icon, title, header, description) for the object. A single quick view can hold multiple objects, each showing information on a single entity. <h3>Usage</h3> <h4>When to use</h4> <ul> <li>You want to display a concise overview of an object (an employee or a company).</li> <li>Information on the object can be split into concrete groups.</li> </ul> <h4>When not to use</h4> <ul> <li>You want to display complex information about an object.</li> </ul> <h3>Responsive Behavior</h3> The quick view is displayed in a {@link sap.m.Popover popover} on desktop and a full-screen {@link sap.m.Dialog dialog} on mobile devices.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.QuickView")]
			public partial class QuickView : sap.m.QuickViewBase
			{
				#region Settings

				/// <summary>
				/// Settings class to create the object
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class Settings : sap.m.QuickViewBase.Settings
				{
					/// <summary>
					/// This property is reused from sap.m.Popover and only takes effect when running on desktop or tablet. Please refer the documentation of the placement property of sap.m.Popover.
					/// </summary>
					public Union<sap.m.PlacementType, string, sap.ui.@base.ManagedObject.BindPropertyInfo> placement;

					/// <summary>
					/// The width of the QuickView. The property takes effect only when running on desktop or tablet.
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> width;

					/// <summary>
					/// This event fires after the QuickView is opened.
					/// </summary>
					public sap.m.AfterOpenCloseBeforeDelegate afterOpen;

					/// <summary>
					/// This event fires after the QuickView is closed.
					/// </summary>
					public sap.m.CloseDelegate afterClose;

					/// <summary>
					/// This event fires before the QuickView is opened.
					/// </summary>
					public sap.m.AfterOpenCloseBeforeDelegate beforeOpen;

					/// <summary>
					/// This event fires before the QuickView is closed.
					/// </summary>
					public sap.m.CloseDelegate beforeClose;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new QuickView.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern QuickView(string sId, sap.m.QuickView.Settings mSettings);

				/// <summary>
				/// Constructor for a new QuickView.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern QuickView(string sId);

				/// <summary>
				/// Constructor for a new QuickView.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern QuickView();

				/// <summary>
				/// Constructor for a new QuickView.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern QuickView(sap.m.QuickView.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property placement

				/// <summary>
				/// Gets current value of property {@link #getPlacement placement}.
				/// 
				/// This property is reused from sap.m.Popover and only takes effect when running on desktop or tablet. Please refer the documentation of the placement property of sap.m.Popover.
				/// 
				/// Default value is <code>Right</code>.
				/// </summary>
				/// <returns>Value of property <code>placement</code></returns>
				public extern virtual sap.m.PlacementType getPlacement();

				/// <summary>
				/// The method sets placement position of the QuickView.
				/// </summary>
				/// <param name="sPlacement">The side from which the QuickView appears relative to the control that opens it.</param>
				/// <returns>Pointer to the control instance for chaining.</returns>
				public extern virtual sap.m.QuickView setPlacement(sap.m.PlacementType sPlacement);

				#endregion

				#region Methods for Property width

				/// <summary>
				/// Gets current value of property {@link #getWidth width}.
				/// 
				/// The width of the QuickView. The property takes effect only when running on desktop or tablet.
				/// 
				/// Default value is <code>320px</code>.
				/// </summary>
				/// <returns>Value of property <code>width</code></returns>
				public extern virtual sap.ui.core.CSSSize getWidth();

				/// <summary>
				/// The method sets the width of the QuickView. Works only on desktop or tablet.
				/// </summary>
				/// <param name="sWidth">The new width of the QuickView.</param>
				/// <returns>Pointer to the control instance for chaining</returns>
				public extern virtual sap.m.QuickView setWidth(sap.ui.core.CSSSize sWidth);

				#endregion

				#region Methods for Event afterOpen

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterOpen afterOpen} event of this <code>sap.m.QuickView</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.QuickView</code> itself.
				/// 
				/// This event fires after the QuickView is opened.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.QuickView</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.QuickView attachAfterOpen(object oData, sap.m.AfterOpenCloseBeforeDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterOpen afterOpen} event of this <code>sap.m.QuickView</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.QuickView</code> itself.
				/// 
				/// This event fires after the QuickView is opened.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.QuickView attachAfterOpen(object oData, sap.m.AfterOpenCloseBeforeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterOpen afterOpen} event of this <code>sap.m.QuickView</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.QuickView</code> itself.
				/// 
				/// This event fires after the QuickView is opened.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.QuickView attachAfterOpen(sap.m.AfterOpenCloseBeforeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterOpen afterOpen} event of this <code>sap.m.QuickView</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.QuickView</code> itself.
				/// 
				/// This event fires after the QuickView is opened.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.QuickView</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.QuickView attachAfterOpen(sap.m.AfterOpenCloseBeforeDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:afterOpen afterOpen} event of this <code>sap.m.QuickView</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.QuickView detachAfterOpen(sap.m.AfterOpenCloseBeforeDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:afterOpen afterOpen} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.QuickView fireAfterOpen(sap.m.AfterOpenCloseBeforeInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:afterOpen afterOpen} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.QuickView fireAfterOpen();

				#endregion

				#region Methods for Event afterClose

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterClose afterClose} event of this <code>sap.m.QuickView</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.QuickView</code> itself.
				/// 
				/// This event fires after the QuickView is closed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.QuickView</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.QuickView attachAfterClose(object oData, sap.m.CloseDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterClose afterClose} event of this <code>sap.m.QuickView</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.QuickView</code> itself.
				/// 
				/// This event fires after the QuickView is closed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.QuickView attachAfterClose(object oData, sap.m.CloseDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterClose afterClose} event of this <code>sap.m.QuickView</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.QuickView</code> itself.
				/// 
				/// This event fires after the QuickView is closed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.QuickView attachAfterClose(sap.m.CloseDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterClose afterClose} event of this <code>sap.m.QuickView</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.QuickView</code> itself.
				/// 
				/// This event fires after the QuickView is closed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.QuickView</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.QuickView attachAfterClose(sap.m.CloseDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:afterClose afterClose} event of this <code>sap.m.QuickView</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.QuickView detachAfterClose(sap.m.CloseDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:afterClose afterClose} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.QuickView fireAfterClose(sap.m.CloseInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:afterClose afterClose} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.QuickView fireAfterClose();

				#endregion

				#region Methods for Event beforeOpen

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeOpen beforeOpen} event of this <code>sap.m.QuickView</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.QuickView</code> itself.
				/// 
				/// This event fires before the QuickView is opened.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.QuickView</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.QuickView attachBeforeOpen(object oData, sap.m.AfterOpenCloseBeforeDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeOpen beforeOpen} event of this <code>sap.m.QuickView</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.QuickView</code> itself.
				/// 
				/// This event fires before the QuickView is opened.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.QuickView attachBeforeOpen(object oData, sap.m.AfterOpenCloseBeforeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeOpen beforeOpen} event of this <code>sap.m.QuickView</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.QuickView</code> itself.
				/// 
				/// This event fires before the QuickView is opened.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.QuickView attachBeforeOpen(sap.m.AfterOpenCloseBeforeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeOpen beforeOpen} event of this <code>sap.m.QuickView</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.QuickView</code> itself.
				/// 
				/// This event fires before the QuickView is opened.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.QuickView</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.QuickView attachBeforeOpen(sap.m.AfterOpenCloseBeforeDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:beforeOpen beforeOpen} event of this <code>sap.m.QuickView</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.QuickView detachBeforeOpen(sap.m.AfterOpenCloseBeforeDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:beforeOpen beforeOpen} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.QuickView fireBeforeOpen(sap.m.AfterOpenCloseBeforeInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:beforeOpen beforeOpen} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.QuickView fireBeforeOpen();

				#endregion

				#region Methods for Event beforeClose

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeClose beforeClose} event of this <code>sap.m.QuickView</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.QuickView</code> itself.
				/// 
				/// This event fires before the QuickView is closed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.QuickView</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.QuickView attachBeforeClose(object oData, sap.m.CloseDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeClose beforeClose} event of this <code>sap.m.QuickView</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.QuickView</code> itself.
				/// 
				/// This event fires before the QuickView is closed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.QuickView attachBeforeClose(object oData, sap.m.CloseDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeClose beforeClose} event of this <code>sap.m.QuickView</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.QuickView</code> itself.
				/// 
				/// This event fires before the QuickView is closed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.QuickView attachBeforeClose(sap.m.CloseDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeClose beforeClose} event of this <code>sap.m.QuickView</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.QuickView</code> itself.
				/// 
				/// This event fires before the QuickView is closed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.QuickView</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.QuickView attachBeforeClose(sap.m.CloseDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:beforeClose beforeClose} event of this <code>sap.m.QuickView</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.QuickView detachBeforeClose(sap.m.CloseDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:beforeClose beforeClose} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.QuickView fireBeforeClose(sap.m.CloseInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:beforeClose beforeClose} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.QuickView fireBeforeClose();

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.QuickView with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.QuickViewBase.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.QuickView with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.QuickViewBase.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.QuickView with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.QuickViewBase.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.QuickView.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				[Name("getMetadata")]
				public extern static sap.ui.@base.Metadata getMetadataStatic();

				/// <summary>
				/// Opens the QuickView.
				/// </summary>
				/// <param name="oControl">The control which opens the QuickView.</param>
				/// <returns>Pointer to the control instance for chaining</returns>
				public extern virtual sap.m.QuickView openBy(sap.ui.core.Control oControl);

				#endregion

				#endregion

			}
		}
	}
}
