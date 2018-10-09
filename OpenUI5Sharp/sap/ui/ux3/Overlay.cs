using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public static partial class sap
	{
		public static partial class ui
		{
			public static partial class ux3
			{
				/// <summary>
				/// Overlay Control
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.ux3.Overlay")]
				[Obsolete("Deprecated since 1.38.")]
				public partial class Overlay : sap.ui.core.Control, sap.ui.core.PopupInterface
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
						/// Defines whether the 'Open' button shall be visible.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> openButtonVisible;

						/// <summary>
						/// Defines whether the 'Close' button shall be visible.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> closeButtonVisible;

						/// <summary>
						/// Event is fired when the Overlay starts closing.
						/// </summary>
						public sap.ui.ux3.Delegate close;

						/// <summary>
						/// Event is fired when the Overlay is closed.
						/// </summary>
						public sap.ui.ux3.Delegate closed;

						/// <summary>
						/// Event is fired when the 'Open' button of the Overlay is clicked.
						/// </summary>
						public sap.ui.ux3.Delegate openNew;

						/// <summary>
						/// Event is fired when the Overlay is opened.
						/// </summary>
						public sap.ui.ux3.Delegate open;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new Overlay.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern Overlay(string sId, sap.ui.ux3.Overlay.Settings mSettings);

					/// <summary>
					/// Constructor for a new Overlay.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					public extern Overlay(string sId);

					/// <summary>
					/// Constructor for a new Overlay.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern Overlay();

					/// <summary>
					/// Constructor for a new Overlay.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern Overlay(sap.ui.ux3.Overlay.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property openButtonVisible

					/// <summary>
					/// Gets current value of property {@link #getOpenButtonVisible openButtonVisible}.
					/// 
					/// Defines whether the 'Open' button shall be visible.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>openButtonVisible</code></returns>
					public extern virtual bool getOpenButtonVisible();

					/// <summary>
					/// Sets a new value for property {@link #getOpenButtonVisible openButtonVisible}.
					/// 
					/// Defines whether the 'Open' button shall be visible.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bOpenButtonVisible">New value for property <code>openButtonVisible</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Overlay setOpenButtonVisible(bool bOpenButtonVisible);

					#endregion

					#region Methods for Property closeButtonVisible

					/// <summary>
					/// Gets current value of property {@link #getCloseButtonVisible closeButtonVisible}.
					/// 
					/// Defines whether the 'Close' button shall be visible.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>closeButtonVisible</code></returns>
					public extern virtual bool getCloseButtonVisible();

					/// <summary>
					/// Sets a new value for property {@link #getCloseButtonVisible closeButtonVisible}.
					/// 
					/// Defines whether the 'Close' button shall be visible.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bCloseButtonVisible">New value for property <code>closeButtonVisible</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Overlay setCloseButtonVisible(bool bCloseButtonVisible);

					#endregion

					#region Methods for Event close

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:close close} event of this <code>sap.ui.ux3.Overlay</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.Overlay</code> itself.
					/// 
					/// Event is fired when the Overlay starts closing.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.Overlay</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Overlay attachClose(object oData, sap.ui.ux3.Delegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:close close} event of this <code>sap.ui.ux3.Overlay</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.Overlay</code> itself.
					/// 
					/// Event is fired when the Overlay starts closing.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Overlay attachClose(object oData, sap.ui.ux3.Delegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:close close} event of this <code>sap.ui.ux3.Overlay</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.Overlay</code> itself.
					/// 
					/// Event is fired when the Overlay starts closing.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Overlay attachClose(sap.ui.ux3.Delegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:close close} event of this <code>sap.ui.ux3.Overlay</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.Overlay</code> itself.
					/// 
					/// Event is fired when the Overlay starts closing.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.Overlay</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Overlay attachClose(sap.ui.ux3.Delegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:close close} event of this <code>sap.ui.ux3.Overlay</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Overlay detachClose(sap.ui.ux3.Delegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:close close} to attached listeners.
					/// 
					/// Listeners may prevent the default action of this event by using the <code>preventDefault</code>-method on the event object.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Whether or not to prevent the default action</returns>
					public extern virtual bool fireClose(sap.ui.ux3.Info mParameters);

					/// <summary>
					/// Fires event {@link #event:close close} to attached listeners.
					/// 
					/// Listeners may prevent the default action of this event by using the <code>preventDefault</code>-method on the event object.
					/// </summary>
					/// <returns>Whether or not to prevent the default action</returns>
					public extern virtual bool fireClose();

					#endregion

					#region Methods for Event closed

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:closed closed} event of this <code>sap.ui.ux3.Overlay</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.Overlay</code> itself.
					/// 
					/// Event is fired when the Overlay is closed.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.Overlay</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Overlay attachClosed(object oData, sap.ui.ux3.Delegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:closed closed} event of this <code>sap.ui.ux3.Overlay</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.Overlay</code> itself.
					/// 
					/// Event is fired when the Overlay is closed.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Overlay attachClosed(object oData, sap.ui.ux3.Delegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:closed closed} event of this <code>sap.ui.ux3.Overlay</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.Overlay</code> itself.
					/// 
					/// Event is fired when the Overlay is closed.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Overlay attachClosed(sap.ui.ux3.Delegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:closed closed} event of this <code>sap.ui.ux3.Overlay</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.Overlay</code> itself.
					/// 
					/// Event is fired when the Overlay is closed.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.Overlay</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Overlay attachClosed(sap.ui.ux3.Delegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:closed closed} event of this <code>sap.ui.ux3.Overlay</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Overlay detachClosed(sap.ui.ux3.Delegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:closed closed} to attached listeners.
					/// 
					/// Listeners may prevent the default action of this event by using the <code>preventDefault</code>-method on the event object.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Whether or not to prevent the default action</returns>
					public extern virtual bool fireClosed(sap.ui.ux3.Info mParameters);

					/// <summary>
					/// Fires event {@link #event:closed closed} to attached listeners.
					/// 
					/// Listeners may prevent the default action of this event by using the <code>preventDefault</code>-method on the event object.
					/// </summary>
					/// <returns>Whether or not to prevent the default action</returns>
					public extern virtual bool fireClosed();

					#endregion

					#region Methods for Event openNew

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:openNew openNew} event of this <code>sap.ui.ux3.Overlay</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.Overlay</code> itself.
					/// 
					/// Event is fired when the 'Open' button of the Overlay is clicked.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.Overlay</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Overlay attachOpenNew(object oData, sap.ui.ux3.Delegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:openNew openNew} event of this <code>sap.ui.ux3.Overlay</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.Overlay</code> itself.
					/// 
					/// Event is fired when the 'Open' button of the Overlay is clicked.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Overlay attachOpenNew(object oData, sap.ui.ux3.Delegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:openNew openNew} event of this <code>sap.ui.ux3.Overlay</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.Overlay</code> itself.
					/// 
					/// Event is fired when the 'Open' button of the Overlay is clicked.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Overlay attachOpenNew(sap.ui.ux3.Delegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:openNew openNew} event of this <code>sap.ui.ux3.Overlay</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.Overlay</code> itself.
					/// 
					/// Event is fired when the 'Open' button of the Overlay is clicked.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.Overlay</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Overlay attachOpenNew(sap.ui.ux3.Delegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:openNew openNew} event of this <code>sap.ui.ux3.Overlay</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Overlay detachOpenNew(sap.ui.ux3.Delegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:openNew openNew} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Overlay fireOpenNew(sap.ui.ux3.Info mParameters);

					/// <summary>
					/// Fires event {@link #event:openNew openNew} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Overlay fireOpenNew();

					#endregion

					#region Methods for Event open

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:open open} event of this <code>sap.ui.ux3.Overlay</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.Overlay</code> itself.
					/// 
					/// Event is fired when the Overlay is opened.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.Overlay</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Overlay attachOpen(object oData, sap.ui.ux3.Delegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:open open} event of this <code>sap.ui.ux3.Overlay</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.Overlay</code> itself.
					/// 
					/// Event is fired when the Overlay is opened.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Overlay attachOpen(object oData, sap.ui.ux3.Delegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:open open} event of this <code>sap.ui.ux3.Overlay</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.Overlay</code> itself.
					/// 
					/// Event is fired when the Overlay is opened.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Overlay attachOpen(sap.ui.ux3.Delegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:open open} event of this <code>sap.ui.ux3.Overlay</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.Overlay</code> itself.
					/// 
					/// Event is fired when the Overlay is opened.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.Overlay</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Overlay attachOpen(sap.ui.ux3.Delegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:open open} event of this <code>sap.ui.ux3.Overlay</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Overlay detachOpen(sap.ui.ux3.Delegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:open open} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Overlay fireOpen(sap.ui.ux3.Info mParameters);

					/// <summary>
					/// Fires event {@link #event:open open} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Overlay fireOpen();

					#endregion

					#region Other methods

					/// <summary>
					/// Closes the Overlay.
					/// </summary>
					public extern virtual void close();

					/// <summary>
					/// Creates a new subclass of class sap.ui.ux3.Overlay with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.ux3.Overlay with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.ux3.Overlay with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.ux3.Overlay.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					/// <summary>
					/// Checks whether Overlay is open.
					/// </summary>
					/// <returns></returns>
					public extern virtual bool isOpen();

					/// <summary>
					/// Opens the Overlay.
					/// </summary>
					/// <param name="initialFocusId">ID of the control that gets focused when the overlay is openend</param>
					public extern virtual void open(string initialFocusId);

					#endregion

					#endregion

				}
			}
		}
	}
}
