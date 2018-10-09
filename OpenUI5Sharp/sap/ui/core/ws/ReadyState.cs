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
					/// Defines the different ready states for a WebSocket connection.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.core.ws.ReadyState")]
					public enum ReadyState
					{
						/// <summary>
						/// The connection has been closed or could not be opened.
						/// </summary>
						CLOSED,
						/// <summary>
						/// The connection is going through the closing handshake.
						/// </summary>
						CLOSING,
						/// <summary>
						/// The connection has not yet been established.
						/// </summary>
						CONNECTING,
						/// <summary>
						/// The WebSocket connection is established and communication is possible.
						/// </summary>
						OPEN,
					}
				}
			}
		}
	}
}
