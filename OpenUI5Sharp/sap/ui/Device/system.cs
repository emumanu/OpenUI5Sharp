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
				/// Provides a basic categorization of the used device based on various indicators.
				/// 
				/// These indicators are for example the support of touch events, the screen size, the used operation system or the user agent of the browser.
				/// 
				/// <b>Note:</b> Depending on the capabilities of the device it is also possible that multiple flags are set to <code>true</code>.
				/// </summary>
				[External]
				[Namespace(false)]
				public static partial class system
				{
					#region Fields

					/// <summary>
					/// If this flag is set to <code>true</code>, the device is recognized as a combination of a desktop system and tablet.
					/// 
					/// Furthermore, a CSS class <code>sap-combi</code> is added to the document root element.
					/// 
					/// <b>Note:</b> This property is mainly for Microsoft Windows 8 (and following) devices where the mouse and touch event may be supported natively by the browser being used. This property is set to <code>true</code> only when both mouse and touch event are natively supported.
					/// </summary>
					public static bool combi;

					/// <summary>
					/// If this flag is set to <code>true</code>, the device is recognized as a desktop system.
					/// 
					/// Furthermore, a CSS class <code>sap-desktop</code> is added to the document root element.
					/// </summary>
					public static bool desktop;

					/// <summary>
					/// If this flag is set to <code>true</code>, the device is recognized as a phone.
					/// 
					/// Furthermore, a CSS class <code>sap-phone</code> is added to the document root element.
					/// </summary>
					public static bool phone;

					/// <summary>
					/// If this flag is set to <code>true</code>, the device is recognized as a tablet.
					/// 
					/// Furthermore, a CSS class <code>sap-tablet</code> is added to the document root element.
					/// 
					/// <b>Note:</b> This flag is also true for some browsers on desktop devices running on Windows 8 or higher. Also see the documentation for {@link sap.ui.Device.system.combi} devices. You can use the following logic to ensure that the current device is a tablet device:
					/// 
					/// <pre>
					/// if(sap.ui.Device.system.tablet && !sap.ui.Device.system.desktop){
					/// 	...tablet related commands...
					/// }
					/// </pre>
					/// </summary>
					public static bool tablet;

					#endregion

				}
			}
		}
	}
}
