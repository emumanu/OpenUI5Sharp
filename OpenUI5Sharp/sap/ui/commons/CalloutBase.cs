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
			public static partial class commons
			{
				/// <summary>
				/// CalloutBase is a building block for Callout. Do not use it directly. Use the Callout control instead
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.CalloutBase")]
				[Obsolete("Deprecated since 1.38.")]
				public partial class CalloutBase : sap.ui.core.TooltipBase
				{
					#region Settings

					/// <summary>
					/// Settings class to create the object
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class Settings : sap.ui.core.TooltipBase.Settings
					{
						/// <summary>
						/// The event is fired when the popup is opened.
						/// </summary>
						public sap.ui.commons.CalloutBase.OpenDelegate open;

						/// <summary>
						/// Event is fired when the Callout window is closed.
						/// </summary>
						public sap.ui.@base.EventDelegate close;

						/// <summary>
						/// Event is fired before a Callout is displayed. Call the preventDefault method of the event object to postpone opening. Application may use this event to start asynchronous Ajax call to load the Callout content
						/// </summary>
						public sap.ui.commons.CalloutBase.OpenDelegate beforeOpen;

						/// <summary>
						/// Is fired when the Callout has been opened
						/// </summary>
						public sap.ui.@base.EventDelegate opened;

					}

					#endregion

					#region Typed Parameters

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class OpenInfo
					{
						/// <summary>
						/// Parent control that has this Callout as a tooltip
						/// </summary>
						public sap.ui.core.Control parent;

					}

					#endregion

					#region Delegates

					public delegate void OpenDelegate(sap.ui.@base.Event<sap.ui.commons.CalloutBase.OpenInfo> oEvent, object oData);

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new CalloutBase.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern CalloutBase(string sId, sap.ui.commons.CalloutBase.Settings mSettings);

					/// <summary>
					/// Constructor for a new CalloutBase.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern CalloutBase(string sId);

					/// <summary>
					/// Constructor for a new CalloutBase.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern CalloutBase();

					/// <summary>
					/// Constructor for a new CalloutBase.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern CalloutBase(sap.ui.commons.CalloutBase.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Event open

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:open open} event of this <code>sap.ui.commons.CalloutBase</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.CalloutBase</code> itself.
					/// 
					/// The event is fired when the popup is opened.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.CalloutBase</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.CalloutBase attachOpen(object oData, sap.ui.commons.CalloutBase.OpenDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:open open} event of this <code>sap.ui.commons.CalloutBase</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.CalloutBase</code> itself.
					/// 
					/// The event is fired when the popup is opened.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.CalloutBase attachOpen(object oData, sap.ui.commons.CalloutBase.OpenDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:open open} event of this <code>sap.ui.commons.CalloutBase</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.CalloutBase</code> itself.
					/// 
					/// The event is fired when the popup is opened.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.CalloutBase attachOpen(sap.ui.commons.CalloutBase.OpenDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:open open} event of this <code>sap.ui.commons.CalloutBase</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.CalloutBase</code> itself.
					/// 
					/// The event is fired when the popup is opened.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.CalloutBase</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.CalloutBase attachOpen(sap.ui.commons.CalloutBase.OpenDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:open open} event of this <code>sap.ui.commons.CalloutBase</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.CalloutBase detachOpen(sap.ui.commons.CalloutBase.OpenDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:open open} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.CalloutBase fireOpen(sap.ui.commons.CalloutBase.OpenInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:open open} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.CalloutBase fireOpen();

					#endregion

					#region Methods for Event close

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:close close} event of this <code>sap.ui.commons.CalloutBase</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.CalloutBase</code> itself.
					/// 
					/// Event is fired when the Callout window is closed.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.CalloutBase</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.CalloutBase attachClose(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:close close} event of this <code>sap.ui.commons.CalloutBase</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.CalloutBase</code> itself.
					/// 
					/// Event is fired when the Callout window is closed.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.CalloutBase attachClose(object oData, sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:close close} event of this <code>sap.ui.commons.CalloutBase</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.CalloutBase</code> itself.
					/// 
					/// Event is fired when the Callout window is closed.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.CalloutBase attachClose(sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:close close} event of this <code>sap.ui.commons.CalloutBase</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.CalloutBase</code> itself.
					/// 
					/// Event is fired when the Callout window is closed.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.CalloutBase</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.CalloutBase attachClose(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:close close} event of this <code>sap.ui.commons.CalloutBase</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.CalloutBase detachClose(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:close close} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.CalloutBase fireClose(object mParameters);

					/// <summary>
					/// Fires event {@link #event:close close} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.CalloutBase fireClose();

					#endregion

					#region Methods for Event beforeOpen

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeOpen beforeOpen} event of this <code>sap.ui.commons.CalloutBase</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.CalloutBase</code> itself.
					/// 
					/// Event is fired before a Callout is displayed. Call the preventDefault method of the event object to postpone opening. Application may use this event to start asynchronous Ajax call to load the Callout content
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.CalloutBase</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.CalloutBase attachBeforeOpen(object oData, sap.ui.commons.CalloutBase.OpenDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeOpen beforeOpen} event of this <code>sap.ui.commons.CalloutBase</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.CalloutBase</code> itself.
					/// 
					/// Event is fired before a Callout is displayed. Call the preventDefault method of the event object to postpone opening. Application may use this event to start asynchronous Ajax call to load the Callout content
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.CalloutBase attachBeforeOpen(object oData, sap.ui.commons.CalloutBase.OpenDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeOpen beforeOpen} event of this <code>sap.ui.commons.CalloutBase</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.CalloutBase</code> itself.
					/// 
					/// Event is fired before a Callout is displayed. Call the preventDefault method of the event object to postpone opening. Application may use this event to start asynchronous Ajax call to load the Callout content
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.CalloutBase attachBeforeOpen(sap.ui.commons.CalloutBase.OpenDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeOpen beforeOpen} event of this <code>sap.ui.commons.CalloutBase</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.CalloutBase</code> itself.
					/// 
					/// Event is fired before a Callout is displayed. Call the preventDefault method of the event object to postpone opening. Application may use this event to start asynchronous Ajax call to load the Callout content
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.CalloutBase</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.CalloutBase attachBeforeOpen(sap.ui.commons.CalloutBase.OpenDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:beforeOpen beforeOpen} event of this <code>sap.ui.commons.CalloutBase</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.CalloutBase detachBeforeOpen(sap.ui.commons.CalloutBase.OpenDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:beforeOpen beforeOpen} to attached listeners.
					/// 
					/// Listeners may prevent the default action of this event by using the <code>preventDefault</code>-method on the event object.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Whether or not to prevent the default action</returns>
					public extern virtual bool fireBeforeOpen(sap.ui.commons.CalloutBase.OpenInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:beforeOpen beforeOpen} to attached listeners.
					/// 
					/// Listeners may prevent the default action of this event by using the <code>preventDefault</code>-method on the event object.
					/// </summary>
					/// <returns>Whether or not to prevent the default action</returns>
					public extern virtual bool fireBeforeOpen();

					#endregion

					#region Methods for Event opened

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:opened opened} event of this <code>sap.ui.commons.CalloutBase</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.CalloutBase</code> itself.
					/// 
					/// Is fired when the Callout has been opened
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.CalloutBase</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.CalloutBase attachOpened(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:opened opened} event of this <code>sap.ui.commons.CalloutBase</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.CalloutBase</code> itself.
					/// 
					/// Is fired when the Callout has been opened
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.CalloutBase attachOpened(object oData, sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:opened opened} event of this <code>sap.ui.commons.CalloutBase</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.CalloutBase</code> itself.
					/// 
					/// Is fired when the Callout has been opened
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.CalloutBase attachOpened(sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:opened opened} event of this <code>sap.ui.commons.CalloutBase</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.CalloutBase</code> itself.
					/// 
					/// Is fired when the Callout has been opened
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.CalloutBase</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.CalloutBase attachOpened(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:opened opened} event of this <code>sap.ui.commons.CalloutBase</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.CalloutBase detachOpened(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:opened opened} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.CalloutBase fireOpened(object mParameters);

					/// <summary>
					/// Fires event {@link #event:opened opened} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.CalloutBase fireOpened();

					#endregion

					#region Other methods

					/// <summary>
					/// Adjust position of the already opened Callout window. Call this method each time when the size of the opened Callout window may be changed due to new or changed contents.
					/// </summary>
					public extern virtual void adjustPosition();

					/// <summary>
					/// Closes Callout
					/// </summary>
					public extern virtual void close();

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.CalloutBase with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.TooltipBase.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.CalloutBase with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.TooltipBase.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.CalloutBase with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.TooltipBase.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.commons.CalloutBase.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					[Name("getMetadata")]
					public extern static sap.ui.@base.Metadata getMetadataStatic();

					/// <summary>
					/// Set position of the Callout window relative to the parent control. This function automatically calculates and sets the correct offset, use it instead of <code>setMyPosition/setAtPosition</code>.
					/// </summary>
					/// <param name="myPosition">docking position of the Callout</param>
					/// <param name="atPosition">docking position of the parent control</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.commons.CalloutBase setPosition(sap.ui.core.Dock myPosition, sap.ui.core.Dock atPosition);

					#endregion

					#endregion

				}
			}
		}
	}
}
