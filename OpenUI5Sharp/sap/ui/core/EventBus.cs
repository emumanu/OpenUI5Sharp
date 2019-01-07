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
				/// Provides eventing capabilities for applications like firing events and attaching or detaching event handlers for events which are notified when events are fired.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.core.EventBus")]
				public partial class EventBus : sap.ui.@base.Object
				{
					#region Constructor

					/// <summary>
					/// Creates an instance of EventBus.
					/// </summary>
					public extern EventBus();

					#endregion

					#region Methods

					/// <summary>
					/// Cleans up the internal structures and removes all event handlers.
					/// 
					/// The object must not be used anymore after destroy was called.
					/// </summary>
					public extern override void destroy();

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.EventBus with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.EventBus with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.EventBus with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.core.EventBus.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					[Name("getMetadata")]
					public extern static sap.ui.@base.Metadata getMetadataStatic();

					/// <summary>
					/// Fires an event using the specified settings and notifies all attached event handlers.
					/// </summary>
					/// <param name="sChannelId">The channel of the event to fire. If not given, the default channel is used. The channel <code>"sap.ui"</code> is reserved by the UI5 framework. An application might listen to events on this channel but is not allowed to publish its own events there.</param>
					/// <param name="sEventId">The identifier of the event to fire</param>
					/// <param name="oData">The parameters which should be carried by the event</param>
					public extern virtual void publish(string sChannelId, string sEventId, object oData);

					/// <summary>
					/// Fires an event using the specified settings and notifies all attached event handlers.
					/// </summary>
					/// <param name="sChannelId">The channel of the event to fire. If not given, the default channel is used. The channel <code>"sap.ui"</code> is reserved by the UI5 framework. An application might listen to events on this channel but is not allowed to publish its own events there.</param>
					/// <param name="sEventId">The identifier of the event to fire</param>
					public extern virtual void publish(string sChannelId, string sEventId);

					/// <summary>
					/// Fires an event using the specified settings and notifies all attached event handlers.
					/// </summary>
					/// <param name="sEventId">The identifier of the event to fire</param>
					public extern virtual void publish(string sEventId);

					/// <summary>
					/// Fires an event using the specified settings and notifies all attached event handlers.
					/// </summary>
					/// <param name="sEventId">The identifier of the event to fire</param>
					/// <param name="oData">The parameters which should be carried by the event</param>
					public extern virtual void publish(string sEventId, object oData);

					/// <summary>
					/// Attaches an event handler to the event with the given identifier on the given event channel.
					/// </summary>
					/// <param name="sChannelId">The channel of the event to subscribe to. If not given, the default channel is used. The channel <code>"sap.ui"</code> is reserved by the UI5 framework. An application might listen to events on this channel but is not allowed to publish its own events there.</param>
					/// <param name="sEventId">The identifier of the event to listen for</param>
					/// <param name="fnFunction">The handler function to call when the event occurs. This function will be called in the context of the <code>oListener</code> instance (if present) or on the event bus instance. The channel is provided as first argument of the handler, and the event identifier is provided as the second argument. The parameter map carried by the event is provided as the third argument (if present). Handlers must not change the content of this map.</param>
					/// <param name="oListener">The object that wants to be notified when the event occurs (<code>this</code> context within the handler function). If it is not specified, the handler function is called in the context of the event bus.</param>
					/// <returns>Returns <code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.EventBus subscribe(string sChannelId, string sEventId, object fnFunction, object oListener);

					/// <summary>
					/// Attaches an event handler to the event with the given identifier on the given event channel.
					/// </summary>
					/// <param name="sChannelId">The channel of the event to subscribe to. If not given, the default channel is used. The channel <code>"sap.ui"</code> is reserved by the UI5 framework. An application might listen to events on this channel but is not allowed to publish its own events there.</param>
					/// <param name="sEventId">The identifier of the event to listen for</param>
					/// <param name="fnFunction">The handler function to call when the event occurs. This function will be called in the context of the <code>oListener</code> instance (if present) or on the event bus instance. The channel is provided as first argument of the handler, and the event identifier is provided as the second argument. The parameter map carried by the event is provided as the third argument (if present). Handlers must not change the content of this map.</param>
					/// <returns>Returns <code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.EventBus subscribe(string sChannelId, string sEventId, object fnFunction);

					/// <summary>
					/// Attaches an event handler to the event with the given identifier on the given event channel.
					/// </summary>
					/// <param name="sEventId">The identifier of the event to listen for</param>
					/// <param name="fnFunction">The handler function to call when the event occurs. This function will be called in the context of the <code>oListener</code> instance (if present) or on the event bus instance. The channel is provided as first argument of the handler, and the event identifier is provided as the second argument. The parameter map carried by the event is provided as the third argument (if present). Handlers must not change the content of this map.</param>
					/// <returns>Returns <code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.EventBus subscribe(string sEventId, object fnFunction);

					/// <summary>
					/// Attaches an event handler to the event with the given identifier on the given event channel.
					/// </summary>
					/// <param name="sEventId">The identifier of the event to listen for</param>
					/// <param name="fnFunction">The handler function to call when the event occurs. This function will be called in the context of the <code>oListener</code> instance (if present) or on the event bus instance. The channel is provided as first argument of the handler, and the event identifier is provided as the second argument. The parameter map carried by the event is provided as the third argument (if present). Handlers must not change the content of this map.</param>
					/// <param name="oListener">The object that wants to be notified when the event occurs (<code>this</code> context within the handler function). If it is not specified, the handler function is called in the context of the event bus.</param>
					/// <returns>Returns <code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.EventBus subscribe(string sEventId, object fnFunction, object oListener);

					/// <summary>
					/// Attaches an event handler, called one time only, to the event with the given identifier on the given event channel.
					/// 
					/// When the event occurs, the handler function is called and the handler registration is automatically removed afterwards.
					/// </summary>
					/// <param name="sChannelId">The channel of the event to subscribe to. If not given, the default channel is used. The channel <code>"sap.ui"</code> is reserved by the UI5 framework. An application might listen to events on this channel but is not allowed to publish its own events there.</param>
					/// <param name="sEventId">The identifier of the event to listen for</param>
					/// <param name="fnFunction">The handler function to call when the event occurs. This function will be called in the context of the <code>oListener</code> instance (if present) or on the event bus instance. The channel is provided as first argument of the handler, and the event identifier is provided as the second argument. The parameter map carried by the event is provided as the third argument (if present). Handlers must not change the content of this map.</param>
					/// <param name="oListener">The object that wants to be notified when the event occurs (<code>this</code> context within the handler function). If it is not specified, the handler function is called in the context of the event bus.</param>
					/// <returns>Returns <code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.EventBus subscribeOnce(string sChannelId, string sEventId, object fnFunction, object oListener);

					/// <summary>
					/// Attaches an event handler, called one time only, to the event with the given identifier on the given event channel.
					/// 
					/// When the event occurs, the handler function is called and the handler registration is automatically removed afterwards.
					/// </summary>
					/// <param name="sChannelId">The channel of the event to subscribe to. If not given, the default channel is used. The channel <code>"sap.ui"</code> is reserved by the UI5 framework. An application might listen to events on this channel but is not allowed to publish its own events there.</param>
					/// <param name="sEventId">The identifier of the event to listen for</param>
					/// <param name="fnFunction">The handler function to call when the event occurs. This function will be called in the context of the <code>oListener</code> instance (if present) or on the event bus instance. The channel is provided as first argument of the handler, and the event identifier is provided as the second argument. The parameter map carried by the event is provided as the third argument (if present). Handlers must not change the content of this map.</param>
					/// <returns>Returns <code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.EventBus subscribeOnce(string sChannelId, string sEventId, object fnFunction);

					/// <summary>
					/// Attaches an event handler, called one time only, to the event with the given identifier on the given event channel.
					/// 
					/// When the event occurs, the handler function is called and the handler registration is automatically removed afterwards.
					/// </summary>
					/// <param name="sEventId">The identifier of the event to listen for</param>
					/// <param name="fnFunction">The handler function to call when the event occurs. This function will be called in the context of the <code>oListener</code> instance (if present) or on the event bus instance. The channel is provided as first argument of the handler, and the event identifier is provided as the second argument. The parameter map carried by the event is provided as the third argument (if present). Handlers must not change the content of this map.</param>
					/// <returns>Returns <code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.EventBus subscribeOnce(string sEventId, object fnFunction);

					/// <summary>
					/// Attaches an event handler, called one time only, to the event with the given identifier on the given event channel.
					/// 
					/// When the event occurs, the handler function is called and the handler registration is automatically removed afterwards.
					/// </summary>
					/// <param name="sEventId">The identifier of the event to listen for</param>
					/// <param name="fnFunction">The handler function to call when the event occurs. This function will be called in the context of the <code>oListener</code> instance (if present) or on the event bus instance. The channel is provided as first argument of the handler, and the event identifier is provided as the second argument. The parameter map carried by the event is provided as the third argument (if present). Handlers must not change the content of this map.</param>
					/// <param name="oListener">The object that wants to be notified when the event occurs (<code>this</code> context within the handler function). If it is not specified, the handler function is called in the context of the event bus.</param>
					/// <returns>Returns <code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.EventBus subscribeOnce(string sEventId, object fnFunction, object oListener);

					/// <summary>
					/// Removes a previously subscribed event handler from the event with the given identifier on the given event channel.
					/// 
					/// The passed parameters must match those used for registration with {@link #subscribe } beforehand!
					/// </summary>
					/// <param name="sChannelId">The channel of the event to unsubscribe from. If not given, the default channel is used.</param>
					/// <param name="sEventId">The identifier of the event to unsubscribe from</param>
					/// <param name="fnFunction">The handler function to unsubscribe from the event</param>
					/// <param name="oListener">The object that wanted to be notified when the event occurred</param>
					/// <returns>Returns <code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.EventBus unsubscribe(string sChannelId, string sEventId, object fnFunction, object oListener);

					/// <summary>
					/// Removes a previously subscribed event handler from the event with the given identifier on the given event channel.
					/// 
					/// The passed parameters must match those used for registration with {@link #subscribe } beforehand!
					/// </summary>
					/// <param name="sChannelId">The channel of the event to unsubscribe from. If not given, the default channel is used.</param>
					/// <param name="sEventId">The identifier of the event to unsubscribe from</param>
					/// <param name="fnFunction">The handler function to unsubscribe from the event</param>
					/// <returns>Returns <code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.EventBus unsubscribe(string sChannelId, string sEventId, object fnFunction);

					/// <summary>
					/// Removes a previously subscribed event handler from the event with the given identifier on the given event channel.
					/// 
					/// The passed parameters must match those used for registration with {@link #subscribe } beforehand!
					/// </summary>
					/// <param name="sEventId">The identifier of the event to unsubscribe from</param>
					/// <param name="fnFunction">The handler function to unsubscribe from the event</param>
					/// <returns>Returns <code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.EventBus unsubscribe(string sEventId, object fnFunction);

					/// <summary>
					/// Removes a previously subscribed event handler from the event with the given identifier on the given event channel.
					/// 
					/// The passed parameters must match those used for registration with {@link #subscribe } beforehand!
					/// </summary>
					/// <param name="sEventId">The identifier of the event to unsubscribe from</param>
					/// <param name="fnFunction">The handler function to unsubscribe from the event</param>
					/// <param name="oListener">The object that wanted to be notified when the event occurred</param>
					/// <returns>Returns <code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.EventBus unsubscribe(string sEventId, object fnFunction, object oListener);

					#endregion

				}
			}
		}
	}
}
