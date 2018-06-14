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
				public static partial class ws
				{
					/// <summary>
					/// WebSocket class implementing the pcp-protocol
					/// </summary>
					[External]
					[Namespace(false)]
					public partial class SapPcpWebSocket : sap.ui.core.ws.WebSocket
					{
						#region Typed Parameters

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

							/// <summary>
							/// Received pcpFields as a key-value map.
							/// </summary>
							public string pcpFields;

						}

						#endregion

						#region Delegates

						public delegate void MessageDelegate(sap.ui.@base.Event<sap.ui.core.ws.SapPcpWebSocket.MessageInfo> oEvent, object oData);

						#endregion

						#region Constructor

						/// <summary>
						/// Creates a new WebSocket connection and uses the pcp-protocol for communication.
						/// </summary>
						/// <param name="sUrl">relative or absolute URL for WebSocket connection.</param>
						/// <param name="aProtocols">array of protocols as strings, a single protocol as a string. Protocol(s) should be selected from {@link sap.ui.core.ws.SapPcpWebSocket.SUPPORTED_PROTOCOLS}.</param>
						public extern SapPcpWebSocket(string sUrl, object[] aProtocols);

						/// <summary>
						/// Creates a new WebSocket connection and uses the pcp-protocol for communication.
						/// </summary>
						/// <param name="sUrl">relative or absolute URL for WebSocket connection.</param>
						public extern SapPcpWebSocket(string sUrl);

						#endregion

						#region Methods

						#region Methods for event message

						/// <summary>
						/// Fire event 'message' to attached listeners.
						/// </summary>
						/// <param name="mArguments">the arguments to pass along with the event.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.ws.SapPcpWebSocket fireMessage(sap.ui.core.ws.SapPcpWebSocket.MessageInfo mArguments);

						/// <summary>
						/// Fire event 'message' to attached listeners.
						/// </summary>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.ws.SapPcpWebSocket fireMessage();

						#endregion

						#region Other methods

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.ws.SapPcpWebSocket with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.ws.WebSocket.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.ws.SapPcpWebSocket with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.ws.WebSocket.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.ws.SapPcpWebSocket with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.ws.WebSocket.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns a metadata object for class sap.ui.core.ws.SapPcpWebSocket.
						/// </summary>
						/// <returns>Metadata object describing this class</returns>
						public extern static sap.ui.@base.Metadata getMetadata();

						/// <summary>
						/// Sends a message and optional pcp-header-fields using the pcp-protocol.<br> <br> If the connection is not yet opened, the message will be queued and sent when the connection is established.
						/// </summary>
						/// <param name="message">message to send</param>
						/// <param name="oPcpFields">additional pcp-fields as key-value map</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.ws.SapPcpWebSocket send(Union<string, dom.Blob, es5.ArrayBuffer> message, object oPcpFields);

						/// <summary>
						/// Sends a message and optional pcp-header-fields using the pcp-protocol.<br> <br> If the connection is not yet opened, the message will be queued and sent when the connection is established.
						/// </summary>
						/// <param name="message">message to send</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.ws.SapPcpWebSocket send(Union<string, dom.Blob, es5.ArrayBuffer> message);

						#endregion

						#endregion

						/// <summary>
						/// Protocol versions.
						/// 
						/// One (or more) of these have to be selected to create an SapPcpWebSocket connection (or no protocol at all).
						/// </summary>
						[External]
						[Namespace(false)]
						public enum SUPPORTED_PROTOCOLS
						{
								v10,
						}
					}
				}
			}
		}
	}
}
