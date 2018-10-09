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
				public static partial class ws
				{
					/// <summary>
					/// Basic WebSocket class
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.core.ws.WebSocket")]
					public partial class WebSocket : sap.ui.@base.EventProvider
					{
						#region Typed Parameters

						/// <summary>
						/// Parameter to be used as Object Literal
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class CloseInfo
						{
							/// <summary>
							/// Close code provided by the server.
							/// </summary>
							public string code;

							/// <summary>
							/// Reason from server for closing the connection.
							/// </summary>
							public string reason;

							/// <summary>
							/// Indicates whether the connection was cleanly closed or not.
							/// </summary>
							public string wasClean;

						}

						/// <summary>
						/// Parameter to be used as Object Literal
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class MessageInfo
						{
							/// <summary>
							/// Received data from the server.
							/// </summary>
							public string data;

						}

						#endregion

						#region Delegates

						public delegate void CloseDelegate(sap.ui.@base.Event<sap.ui.core.ws.WebSocket.CloseInfo> oEvent, object oData);

						public delegate void MessageDelegate(sap.ui.@base.Event<sap.ui.core.ws.WebSocket.MessageInfo> oEvent, object oData);

						#endregion

						#region Constructor

						/// <summary>
						/// Creates a new WebSocket connection.
						/// </summary>
						/// <param name="sUrl">relative or absolute URL for WebSocket connection.</param>
						/// <param name="aProtocols">array of protocols as strings, a single protocol as a string</param>
						public extern WebSocket(string sUrl, object[] aProtocols);

						/// <summary>
						/// Creates a new WebSocket connection.
						/// </summary>
						/// <param name="sUrl">relative or absolute URL for WebSocket connection.</param>
						public extern WebSocket(string sUrl);

						#endregion

						#region Methods

						#region Methods for event close

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'close' event of this <code>sap.ui.core.ws.WebSocket</code>.<br>
						/// </summary>
						/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <param name="oListener">Object on which to call the given function. If empty, this WebSocket is used.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.ws.WebSocket attachClose(object oData, sap.ui.core.ws.WebSocket.CloseDelegate fnFunction, object oListener);

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'close' event of this <code>sap.ui.core.ws.WebSocket</code>.<br>
						/// </summary>
						/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.ws.WebSocket attachClose(object oData, sap.ui.core.ws.WebSocket.CloseDelegate fnFunction);

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'close' event of this <code>sap.ui.core.ws.WebSocket</code>.<br>
						/// </summary>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.ws.WebSocket attachClose(sap.ui.core.ws.WebSocket.CloseDelegate fnFunction);

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'close' event of this <code>sap.ui.core.ws.WebSocket</code>.<br>
						/// </summary>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <param name="oListener">Object on which to call the given function. If empty, this WebSocket is used.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.ws.WebSocket attachClose(sap.ui.core.ws.WebSocket.CloseDelegate fnFunction, object oListener);

						/// <summary>
						/// Detach event-handler <code>fnFunction</code> from the 'close' event of this <code>sap.ui.core.ws.WebSocket</code>.<br>
						/// 
						/// The passed function and listener object must match the ones previously used for event registration.
						/// </summary>
						/// <param name="fnFunction">The function to call, when the event occurs.</param>
						/// <param name="oListener">Object on which the given function had to be called.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.ws.WebSocket detachClose(sap.ui.core.ws.WebSocket.CloseDelegate fnFunction, object oListener);

						/// <summary>
						/// Fire event 'close' to attached listeners.
						/// </summary>
						/// <param name="mArguments">the arguments to pass along with the event.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.ws.WebSocket fireClose(sap.ui.core.ws.WebSocket.CloseInfo mArguments);

						/// <summary>
						/// Fire event 'close' to attached listeners.
						/// </summary>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.ws.WebSocket fireClose();

						#endregion

						#region Methods for event error

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'error' event of this <code>sap.ui.core.ws.WebSocket</code>.<br>
						/// </summary>
						/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <param name="oListener">Object on which to call the given function. If empty, this WebSocket is used.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.ws.WebSocket attachError(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'error' event of this <code>sap.ui.core.ws.WebSocket</code>.<br>
						/// </summary>
						/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.ws.WebSocket attachError(object oData, sap.ui.@base.EventDelegate fnFunction);

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'error' event of this <code>sap.ui.core.ws.WebSocket</code>.<br>
						/// </summary>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.ws.WebSocket attachError(sap.ui.@base.EventDelegate fnFunction);

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'error' event of this <code>sap.ui.core.ws.WebSocket</code>.<br>
						/// </summary>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <param name="oListener">Object on which to call the given function. If empty, this WebSocket is used.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.ws.WebSocket attachError(sap.ui.@base.EventDelegate fnFunction, object oListener);

						/// <summary>
						/// Detach event-handler <code>fnFunction</code> from the 'error' event of this <code>sap.ui.core.ws.WebSocket</code>.<br>
						/// 
						/// The passed function and listener object must match the ones previously used for event registration.
						/// </summary>
						/// <param name="fnFunction">The function to call, when the event occurs.</param>
						/// <param name="oListener">Object on which the given function had to be called.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.ws.WebSocket detachError(sap.ui.@base.EventDelegate fnFunction, object oListener);

						/// <summary>
						/// Fire event 'error' to attached listeners.
						/// </summary>
						/// <param name="mArguments">the arguments to pass along with the event.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.ws.WebSocket fireError(object mArguments);

						/// <summary>
						/// Fire event 'error' to attached listeners.
						/// </summary>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.ws.WebSocket fireError();

						#endregion

						#region Methods for event message

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'message' event of this <code>sap.ui.core.ws.WebSocket</code>.<br>
						/// </summary>
						/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <param name="oListener">Object on which to call the given function. If empty, this WebSocket is used.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.ws.WebSocket attachMessage(object oData, sap.ui.core.ws.WebSocket.MessageDelegate fnFunction, object oListener);

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'message' event of this <code>sap.ui.core.ws.WebSocket</code>.<br>
						/// </summary>
						/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.ws.WebSocket attachMessage(object oData, sap.ui.core.ws.WebSocket.MessageDelegate fnFunction);

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'message' event of this <code>sap.ui.core.ws.WebSocket</code>.<br>
						/// </summary>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.ws.WebSocket attachMessage(sap.ui.core.ws.WebSocket.MessageDelegate fnFunction);

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'message' event of this <code>sap.ui.core.ws.WebSocket</code>.<br>
						/// </summary>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <param name="oListener">Object on which to call the given function. If empty, this WebSocket is used.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.ws.WebSocket attachMessage(sap.ui.core.ws.WebSocket.MessageDelegate fnFunction, object oListener);

						/// <summary>
						/// Detach event-handler <code>fnFunction</code> from the 'message' event of this <code>sap.ui.core.ws.WebSocket</code>.<br>
						/// 
						/// The passed function and listener object must match the ones previously used for event registration.
						/// </summary>
						/// <param name="fnFunction">The function to call, when the event occurs.</param>
						/// <param name="oListener">Object on which the given function had to be called.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.ws.WebSocket detachMessage(sap.ui.core.ws.WebSocket.MessageDelegate fnFunction, object oListener);

						/// <summary>
						/// Fire event 'message' to attached listeners.
						/// </summary>
						/// <param name="mArguments">the arguments to pass along with the event.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.ws.WebSocket fireMessage(sap.ui.core.ws.WebSocket.MessageInfo mArguments);

						/// <summary>
						/// Fire event 'message' to attached listeners.
						/// </summary>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.ws.WebSocket fireMessage();

						#endregion

						#region Methods for event open

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'open' event of this <code>sap.ui.core.ws.WebSocket</code>.<br>
						/// </summary>
						/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <param name="oListener">Object on which to call the given function. If empty, this WebSocket is used.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.ws.WebSocket attachOpen(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'open' event of this <code>sap.ui.core.ws.WebSocket</code>.<br>
						/// </summary>
						/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.ws.WebSocket attachOpen(object oData, sap.ui.@base.EventDelegate fnFunction);

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'open' event of this <code>sap.ui.core.ws.WebSocket</code>.<br>
						/// </summary>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.ws.WebSocket attachOpen(sap.ui.@base.EventDelegate fnFunction);

						/// <summary>
						/// Attach event-handler <code>fnFunction</code> to the 'open' event of this <code>sap.ui.core.ws.WebSocket</code>.<br>
						/// </summary>
						/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
						/// <param name="oListener">Object on which to call the given function. If empty, this WebSocket is used.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.ws.WebSocket attachOpen(sap.ui.@base.EventDelegate fnFunction, object oListener);

						/// <summary>
						/// Detach event-handler <code>fnFunction</code> from the 'open' event of this <code>sap.ui.core.ws.WebSocket</code>.<br>
						/// 
						/// The passed function and listener object must match the ones previously used for event registration.
						/// </summary>
						/// <param name="fnFunction">The function to call, when the event occurs.</param>
						/// <param name="oListener">Object on which the given function had to be called.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.ws.WebSocket detachOpen(sap.ui.@base.EventDelegate fnFunction, object oListener);

						/// <summary>
						/// Fire event 'open' to attached listeners.
						/// </summary>
						/// <param name="mArguments">the arguments to pass along with the event.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.ws.WebSocket fireOpen(object mArguments);

						/// <summary>
						/// Fire event 'open' to attached listeners.
						/// </summary>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.ws.WebSocket fireOpen();

						#endregion

						#region Other methods

						/// <summary>
						/// Closes the connection.
						/// </summary>
						/// <param name="iCode">Status code that explains why the connection is closed. Must be either 1000, or between 3000 and 4999 (default 1000)</param>
						/// <param name="sReason">Closing reason as a string</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.ws.WebSocket close(int iCode, string sReason);

						/// <summary>
						/// Closes the connection.
						/// </summary>
						/// <param name="iCode">Status code that explains why the connection is closed. Must be either 1000, or between 3000 and 4999 (default 1000)</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.ws.WebSocket close(int iCode);

						/// <summary>
						/// Closes the connection.
						/// </summary>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.ws.WebSocket close();

						/// <summary>
						/// Closes the connection.
						/// </summary>
						/// <param name="sReason">Closing reason as a string</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.ws.WebSocket close(string sReason);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.ws.WebSocket with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.EventProvider.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.ws.WebSocket with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.EventProvider.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.ws.WebSocket with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.EventProvider.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						public extern virtual void getInterface();

						/// <summary>
						/// Returns a metadata object for class sap.ui.core.ws.WebSocket.
						/// </summary>
						/// <returns>Metadata object describing this class</returns>
						public extern static sap.ui.@base.Metadata getMetadata();

						/// <summary>
						/// Getter for the protocol selected by the server once the connection is open.
						/// </summary>
						/// <returns>protocol</returns>
						public extern virtual string getProtocol();

						/// <summary>
						/// Getter for WebSocket readyState.
						/// </summary>
						/// <returns>readyState</returns>
						public extern virtual sap.ui.core.ws.ReadyState getReadyState();

						/// <summary>
						/// Sends a message.<br> <br> If the connection is not yet opened, the message will be queued and sent when the connection is established.
						/// </summary>
						/// <param name="sMessage">Message to send</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.ws.WebSocket send(string sMessage);

						#endregion

						#endregion

					}
				}
			}
		}
	}
}
