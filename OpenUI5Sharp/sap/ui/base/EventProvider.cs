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
			public static partial class @base
			{
				/// <summary>
				/// Provides eventing capabilities for objects like attaching or detaching event handlers for events which are notified when events are fired.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.base.EventProvider")]
				public abstract partial class EventProvider : sap.ui.@base.Object
				{
					#region Constructor

					/// <summary>
					/// Creates an instance of EventProvider.
					/// </summary>
					public extern EventProvider();

					#endregion

					#region Methods

					/// <summary>
					/// Attaches an event handler to the event with the given identifier.
					/// </summary>
					/// <param name="sEventId">The identifier of the event to listen for</param>
					/// <param name="oData">An object that will be passed to the handler along with the event object when the event is fired</param>
					/// <param name="fnFunction">The handler function to call when the event occurs. This function will be called in the context of the <code>oListener</code> instance (if present) or on the event provider instance. The event object ({@link sap.ui.base.Event}) is provided as first argument of the handler. Handlers must not change the content of the event. The second argument is the specified <code>oData</code> instance (if present).</param>
					/// <param name="oListener">The object that wants to be notified when the event occurs (<code>this</code> context within the handler function). If it is not specified, the handler function is called in the context of the event provider.</param>
					/// <returns>Returns <code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.@base.EventProvider attachEvent(string sEventId, object oData, object fnFunction, object oListener);

					/// <summary>
					/// Attaches an event handler to the event with the given identifier.
					/// </summary>
					/// <param name="sEventId">The identifier of the event to listen for</param>
					/// <param name="oData">An object that will be passed to the handler along with the event object when the event is fired</param>
					/// <param name="fnFunction">The handler function to call when the event occurs. This function will be called in the context of the <code>oListener</code> instance (if present) or on the event provider instance. The event object ({@link sap.ui.base.Event}) is provided as first argument of the handler. Handlers must not change the content of the event. The second argument is the specified <code>oData</code> instance (if present).</param>
					/// <returns>Returns <code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.@base.EventProvider attachEvent(string sEventId, object oData, object fnFunction);

					/// <summary>
					/// Attaches an event handler, called one time only, to the event with the given identifier.
					/// 
					/// When the event occurs, the handler function is called and the handler registration is automatically removed afterwards.
					/// </summary>
					/// <param name="sEventId">The identifier of the event to listen for</param>
					/// <param name="oData">An object that will be passed to the handler along with the event object when the event is fired</param>
					/// <param name="fnFunction">The handler function to call when the event occurs. This function will be called in the context of the <code>oListener</code> instance (if present) or on the event provider instance. The event object ({@link sap.ui.base.Event}) is provided as first argument of the handler. Handlers must not change the content of the event. The second argument is the specified <code>oData</code> instance (if present).</param>
					/// <param name="oListener">The object that wants to be notified when the event occurs (<code>this</code> context within the handler function). If it is not specified, the handler function is called in the context of the event provider.</param>
					/// <returns>Returns <code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.@base.EventProvider attachEventOnce(string sEventId, object oData, object fnFunction, object oListener);

					/// <summary>
					/// Attaches an event handler, called one time only, to the event with the given identifier.
					/// 
					/// When the event occurs, the handler function is called and the handler registration is automatically removed afterwards.
					/// </summary>
					/// <param name="sEventId">The identifier of the event to listen for</param>
					/// <param name="oData">An object that will be passed to the handler along with the event object when the event is fired</param>
					/// <param name="fnFunction">The handler function to call when the event occurs. This function will be called in the context of the <code>oListener</code> instance (if present) or on the event provider instance. The event object ({@link sap.ui.base.Event}) is provided as first argument of the handler. Handlers must not change the content of the event. The second argument is the specified <code>oData</code> instance (if present).</param>
					/// <returns>Returns <code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.@base.EventProvider attachEventOnce(string sEventId, object oData, object fnFunction);

					/// <summary>
					/// Cleans up the internal structures and removes all event handlers.
					/// 
					/// The object must not be used anymore after destroy was called.
					/// </summary>
					public extern override void destroy();

					/// <summary>
					/// Removes a previously attached event handler from the event with the given identifier.
					/// 
					/// The passed parameters must match those used for registration with {@link #attachEvent} beforehand.
					/// </summary>
					/// <param name="sEventId">The identifier of the event to detach from</param>
					/// <param name="fnFunction">The handler function to detach from the event</param>
					/// <param name="oListener">The object that wanted to be notified when the event occurred</param>
					/// <returns>Returns <code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.@base.EventProvider detachEvent(string sEventId, object fnFunction, object oListener);

					/// <summary>
					/// Removes a previously attached event handler from the event with the given identifier.
					/// 
					/// The passed parameters must match those used for registration with {@link #attachEvent} beforehand.
					/// </summary>
					/// <param name="sEventId">The identifier of the event to detach from</param>
					/// <param name="fnFunction">The handler function to detach from the event</param>
					/// <returns>Returns <code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.@base.EventProvider detachEvent(string sEventId, object fnFunction);

					/// <summary>
					/// Creates a new subclass of class sap.ui.base.EventProvider with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.base.EventProvider with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.base.EventProvider with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Fires an {@link sap.ui.base.Event event} with the given settings and notifies all attached event handlers.
					/// </summary>
					/// <param name="sEventId">The identifier of the event to fire</param>
					/// <param name="mParameters">The parameters which should be carried by the event</param>
					/// <param name="bAllowPreventDefault">Defines whether function <code>preventDefault</code> is supported on the fired event</param>
					/// <param name="bEnableEventBubbling">Defines whether event bubbling is enabled on the fired event. Set to <code>true</code> the event is also forwarded to the parent(s) of the event provider ({@link #getEventingParent}) until the bubbling of the event is stopped or no parent is available anymore.</param>
					/// <returns>Returns <code>this</code> to allow method chaining. When <code>preventDefault</code> is supported on the fired event the function returns <code>true</code> if the default action should be executed, <code>false</code> otherwise.</returns>
					public extern virtual Union<sap.ui.@base.EventProvider, bool> fireEvent(string sEventId, object mParameters, bool bAllowPreventDefault, bool bEnableEventBubbling);

					/// <summary>
					/// Fires an {@link sap.ui.base.Event event} with the given settings and notifies all attached event handlers.
					/// </summary>
					/// <param name="sEventId">The identifier of the event to fire</param>
					/// <param name="mParameters">The parameters which should be carried by the event</param>
					/// <param name="bAllowPreventDefault">Defines whether function <code>preventDefault</code> is supported on the fired event</param>
					/// <returns>Returns <code>this</code> to allow method chaining. When <code>preventDefault</code> is supported on the fired event the function returns <code>true</code> if the default action should be executed, <code>false</code> otherwise.</returns>
					public extern virtual Union<sap.ui.@base.EventProvider, bool> fireEvent(string sEventId, object mParameters, bool bAllowPreventDefault);

					/// <summary>
					/// Fires an {@link sap.ui.base.Event event} with the given settings and notifies all attached event handlers.
					/// </summary>
					/// <param name="sEventId">The identifier of the event to fire</param>
					/// <param name="mParameters">The parameters which should be carried by the event</param>
					/// <returns>Returns <code>this</code> to allow method chaining. When <code>preventDefault</code> is supported on the fired event the function returns <code>true</code> if the default action should be executed, <code>false</code> otherwise.</returns>
					public extern virtual Union<sap.ui.@base.EventProvider, bool> fireEvent(string sEventId, object mParameters);

					/// <summary>
					/// Fires an {@link sap.ui.base.Event event} with the given settings and notifies all attached event handlers.
					/// </summary>
					/// <param name="sEventId">The identifier of the event to fire</param>
					/// <returns>Returns <code>this</code> to allow method chaining. When <code>preventDefault</code> is supported on the fired event the function returns <code>true</code> if the default action should be executed, <code>false</code> otherwise.</returns>
					public extern virtual Union<sap.ui.@base.EventProvider, bool> fireEvent(string sEventId);

					/// <summary>
					/// Returns the parent in the eventing hierarchy of this object.
					/// 
					/// Per default this returns null, but if eventing is used in objects, which are hierarchically structured, this can be overwritten to make the object hierarchy visible to the eventing and enables the use of event bubbling within this object hierarchy.
					/// </summary>
					/// <returns>The parent event provider</returns>
					public extern virtual sap.ui.@base.EventProvider getEventingParent();

					/// <summary>
					/// Returns a metadata object for class sap.ui.base.EventProvider.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					[Name("getMetadata")]
					public extern static sap.ui.@base.Metadata getMetadataStatic();

					/// <summary>
					/// Checks whether the given event provider has the given listener registered for the given event.
					/// 
					/// Returns true if function and listener object both match the corresponding parameters of at least one listener registered for the named event.
					/// </summary>
					/// <param name="oEventProvider">The event provider to get the registered events for</param>
					/// <param name="sEventId">The identifier of the event to check listeners for</param>
					/// <param name="fnFunction">The handler function to check for</param>
					/// <param name="oListener">The listener object to check for</param>
					/// <returns>Returns whether a listener with the same parameters exists</returns>
					private extern static bool hasListener(sap.ui.@base.EventProvider oEventProvider, string sEventId, object fnFunction, object oListener);

					/// <summary>
					/// Checks whether the given event provider has the given listener registered for the given event.
					/// 
					/// Returns true if function and listener object both match the corresponding parameters of at least one listener registered for the named event.
					/// </summary>
					/// <param name="oEventProvider">The event provider to get the registered events for</param>
					/// <param name="sEventId">The identifier of the event to check listeners for</param>
					/// <param name="fnFunction">The handler function to check for</param>
					/// <returns>Returns whether a listener with the same parameters exists</returns>
					private extern static bool hasListener(sap.ui.@base.EventProvider oEventProvider, string sEventId, object fnFunction);

					/// <summary>
					/// Returns whether there are any registered event handlers for the event with the given identifier.
					/// </summary>
					/// <param name="sEventId">The identifier of the event</param>
					/// <returns>Whether there are any registered event handlers</returns>
					public extern virtual bool hasListeners(string sEventId);

					/// <summary>
					/// Returns a string representation of this object.
					/// 
					/// In case there is no class or id information, a simple static string is returned. Subclasses should override this method.
					/// </summary>
					/// <returns>A string description of this event provider</returns>
					public extern virtual string toString();

					#endregion

				}
			}
		}
	}
}
