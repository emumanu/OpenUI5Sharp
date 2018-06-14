using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace OpenUI5Sharp
{
	public partial class jQuery
	{
		public static partial class device
		{
			/// <summary>
			/// Holds information about the current device and its state
			/// </summary>
			[External]
			[Namespace(false)]
			[Obsolete("Deprecated since 1.20. use the respective functions of {@link sap.ui.Device} instead")]
			public static partial class @is
			{
				#region Fields

				/// <summary>
				/// Whether the application runs on an Android phone - based not on screen size but user-agent (so this is not guaranteed to be equal to jQuery.device.is.phone on Android) https://developers.google.com/chrome/mobile/docs/user-agent Some device vendors however do not follow this rule
				/// </summary>
				public static bool android_phone;

				/// <summary>
				/// Whether the application runs on an Android tablet - based not on screen size but user-agent (so this is not guaranteed to be equal to jQuery.device.is.tablet on Android) https://developers.google.com/chrome/mobile/docs/user-agent Some device vendors however do not follow this rule
				/// </summary>
				public static bool android_tablet;

				/// <summary>
				/// Whether the running device is a desktop browser. If a desktop browser runs in mobile device simulation mode (with URL parameter sap-ui-xx-fakeOS or sap-ui-xx-test-mobile), this property will be false.
				/// </summary>
				public static bool desktop;

				/// <summary>
				/// Whether the application runs on an iPad
				/// </summary>
				public static bool ipad;

				/// <summary>
				/// Whether the application runs on an iPhone
				/// </summary>
				public static bool iphone;

				/// <summary>
				/// Whether the device is in "landscape" orientation (also "true" when the device does not know about the orientation)
				/// </summary>
				public static bool landscape;

				/// <summary>
				/// Whether the running device is a phone. If a desktop browser runs in mobile device simulation mode (with URL parameter sap-ui-xx-fakeOS or sap-ui-xx-test-mobile), this property will also be set according to the simulated platform. This property will be false when runs in desktop browser.
				/// </summary>
				public static bool phone;

				/// <summary>
				/// Whether the device is in portrait orientation
				/// </summary>
				public static bool portrait;

				/// <summary>
				/// Whether the application runs in standalone mode without browser UI (launched from the iOS home screen)
				/// </summary>
				public static bool standalone;

				/// <summary>
				/// Whether the running device is a tablet. If a desktop browser runs in mobile device simulation mode (with URL parameter sap-ui-xx-fakeOS or sap-ui-xx-test-mobile), this property will also be set according to the simulated platform. This property will be false when runs in desktop browser.
				/// </summary>
				public static bool tablet;

				#endregion

			}
		}
	}
}
