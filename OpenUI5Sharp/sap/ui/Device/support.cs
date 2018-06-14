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
			public static partial class Device
			{
				/// <summary>
				/// Contains information about detected capabilities of the used browser or device.
				/// </summary>
				[External]
				[Namespace(false)]
				public static partial class support
				{
					#region Fields

					/// <summary>
					/// If this flag is set to <code>true</code>, the used browser natively supports media queries via JavaScript.
					/// 
					/// <b>Note:</b> The {@link sap.ui.Device.media media queries API} of the device API can also be used when there is no native support.
					/// </summary>
					public static bool matchmedia;

					/// <summary>
					/// If this flag is set to <code>true</code>, the used browser natively supports events of media queries via JavaScript.
					/// 
					/// <b>Note:</b> The {@link sap.ui.Device.media media queries API} of the device API can also be used when there is no native support.
					/// </summary>
					public static bool matchmedialistener;

					/// <summary>
					/// If this flag is set to <code>true</code>, the used browser natively supports the <code>orientationchange</code> event.
					/// 
					/// <b>Note:</b> The {@link sap.ui.Device.orientation orientation event} of the device API can also be used when there is no native support.
					/// </summary>
					public static bool orientation;

					/// <summary>
					/// If this flag is set to <code>true</code>, the used browser supports pointer events.
					/// </summary>
					public static bool pointer;

					/// <summary>
					/// If this flag is set to <code>true</code>, the device has a display with a high resolution.
					/// </summary>
					public static bool retina;

					/// <summary>
					/// If this flag is set to <code>true</code>, the used browser supports touch events.
					/// 
					/// <b>Note:</b> This flag indicates whether the used browser supports touch events or not. This does not necessarily mean that the used device has a touchable screen.
					/// </summary>
					public static bool touch;

					/// <summary>
					/// If this flag is set to <code>true</code>, the used browser supports web sockets.
					/// </summary>
					public static bool websocket;

					#endregion

				}
			}
		}
	}
}
