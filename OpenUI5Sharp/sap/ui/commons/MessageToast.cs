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
				/// Responsible for displaying the new incoming messages, one at the time, on top of the MessageBar.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.MessageToast")]
				[Obsolete("Deprecated since 1.4.0. Instead, use the <code>sap.m.MessageToast</code> control.")]
				public partial class MessageToast : sap.ui.core.Control
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
						/// ID of the anchor on top of which the MessageToast is to render.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> anchorId;

						/// <summary>
						/// Fired once the <code>toast()</code> method is over, so that the MessageBar can "toast" another message if needed.
						/// </summary>
						public sap.ui.@base.EventDelegate next;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new MessageToast.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern MessageToast(string sId, sap.ui.commons.MessageToast.Settings mSettings);

					/// <summary>
					/// Constructor for a new MessageToast.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					public extern MessageToast(string sId);

					/// <summary>
					/// Constructor for a new MessageToast.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern MessageToast();

					/// <summary>
					/// Constructor for a new MessageToast.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern MessageToast(sap.ui.commons.MessageToast.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property anchorId

					/// <summary>
					/// Gets current value of property {@link #getAnchorId anchorId}.
					/// 
					/// ID of the anchor on top of which the MessageToast is to render.
					/// </summary>
					/// <returns>Value of property <code>anchorId</code></returns>
					public extern virtual string getAnchorId();

					/// <summary>
					/// Sets a new value for property {@link #getAnchorId anchorId}.
					/// 
					/// ID of the anchor on top of which the MessageToast is to render.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sAnchorId">New value for property <code>anchorId</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.MessageToast setAnchorId(string sAnchorId);

					#endregion

					#region Methods for Event next

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:next next} event of this <code>sap.ui.commons.MessageToast</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.MessageToast</code> itself.
					/// 
					/// Fired once the <code>toast()</code> method is over, so that the MessageBar can "toast" another message if needed.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.MessageToast</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.MessageToast attachNext(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:next next} event of this <code>sap.ui.commons.MessageToast</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.MessageToast</code> itself.
					/// 
					/// Fired once the <code>toast()</code> method is over, so that the MessageBar can "toast" another message if needed.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.MessageToast attachNext(object oData, sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:next next} event of this <code>sap.ui.commons.MessageToast</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.MessageToast</code> itself.
					/// 
					/// Fired once the <code>toast()</code> method is over, so that the MessageBar can "toast" another message if needed.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.MessageToast attachNext(sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:next next} event of this <code>sap.ui.commons.MessageToast</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.MessageToast</code> itself.
					/// 
					/// Fired once the <code>toast()</code> method is over, so that the MessageBar can "toast" another message if needed.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.MessageToast</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.MessageToast attachNext(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:next next} event of this <code>sap.ui.commons.MessageToast</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.MessageToast detachNext(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:next next} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.MessageToast fireNext(object mParameters);

					/// <summary>
					/// Fires event {@link #event:next next} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.MessageToast fireNext();

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.MessageToast with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.MessageToast with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.MessageToast with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.commons.MessageToast.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					/// <summary>
					/// Returns the idle state of the control. Returns true if no message is being toasted.
					/// </summary>
					/// <returns></returns>
					public extern virtual bool isIdle();

					/// <summary>
					/// Triggers the toasting of a message, on top of the MessageBar. If no message is supplied, displays the "Multiple new messages..." message.
					/// 
					/// Receives the list of Messages to be displayed, and re-renders this Control if it is visible.
					/// </summary>
					/// <param name="oMessage">The Message to be toasted.</param>
					/// <param name="sAnchorId">DOM ID of the anchor against which the Toast Arrow should align for a given Toast.</param>
					public extern virtual void toast(sap.ui.commons.Message oMessage, string sAnchorId);

					#endregion

					#endregion

				}
			}
		}
	}
}
