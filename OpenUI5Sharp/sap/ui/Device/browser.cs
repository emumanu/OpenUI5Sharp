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
				/// Contains information about the used browser.
				/// </summary>
				[External]
				[Namespace(false)]
				public static partial class browser
				{
					#region Fields

					/// <summary>
					/// If this flag is set to <code>true</code>, a browser featuring a Blink rendering engine is used.
					/// </summary>
					public static bool blink;

					/// <summary>
					/// If this flag is set to <code>true</code>, the Google Chrome browser is used.
					/// </summary>
					public static bool chrome;

					/// <summary>
					/// If this flag is set to <code>true</code>, the Microsoft Edge browser is used.
					/// </summary>
					public static bool edge;

					/// <summary>
					/// If this flag is set to <code>true</code>, the Mozilla Firefox browser is used.
					/// </summary>
					public static bool firefox;

					/// <summary>
					/// If this flag is set to <code>true</code>, the Safari browser runs in standalone fullscreen mode on iOS.
					/// 
					/// <b>Note:</b> This flag is only available if the Safari browser was detected. Furthermore, if this mode is detected, technically not a standard Safari is used. There might be slight differences in behavior and detection, e.g. the availability of {@link sap.ui.Device.browser.version}.
					/// </summary>
					public static bool fullscreen;

					/// <summary>
					/// If this flag is set to <code>true</code>, the Microsoft Internet Explorer browser is used.
					/// </summary>
					public static bool internet_explorer;

					/// <summary>
					/// If this flag is set to <code>true</code>, the mobile variant of the browser is used or a tablet or phone device is detected.
					/// 
					/// <b>Note:</b> This information might not be available for all browsers.
					/// </summary>
					public static bool mobile;

					/// <summary>
					/// If this flag is set to <code>true</code>, a browser featuring a Mozilla engine is used.
					/// </summary>
					public static bool mozilla;

					/// <summary>
					/// If this flag is set to <code>true</code>, the Microsoft Internet Explorer browser is used.
					/// </summary>
					public static bool msie;

					/// <summary>
					/// The name of the browser.
					/// </summary>
					public static string name;

					/// <summary>
					/// If this flag is set to <code>true</code>, the Apple Safari browser is used.
					/// 
					/// <b>Note:</b> This flag is also <code>true</code> when the standalone (fullscreen) mode or webview is used on iOS devices. Please also note the flags {@link sap.ui.Device.browser.fullscreen} and {@link sap.ui.Device.browser.webview}.
					/// </summary>
					public static bool safari;

					/// <summary>
					/// The version of the browser as <code>float</code>.
					/// 
					/// Might be <code>-1</code> if no version can be determined.
					/// </summary>
					public static float version;

					/// <summary>
					/// The version of the browser as <code>string</code>.
					/// 
					/// Might be empty if no version can be determined.
					/// </summary>
					public static string versionStr;

					/// <summary>
					/// If this flag is set to <code>true</code>, a browser featuring a Webkit engine is used.
					/// 
					/// <b>Note:</b> This flag is also <code>true</code> when the used browser was based on the Webkit engine, but uses another rendering engine in the meantime. For example the Chrome browser started from version 28 and above uses the Blink rendering engine.
					/// </summary>
					public static bool webkit;

					/// <summary>
					/// If this flag is set to <code>true</code>, the Safari browser runs in webview mode on iOS.
					/// 
					/// <b>Note:</b> This flag is only available if the Safari browser was detected. Furthermore, if this mode is detected, technically not a standard Safari is used. There might be slight differences in behavior and detection, e.g. the availability of {@link sap.ui.Device.browser.version}.
					/// </summary>
					public static bool webview;

					#endregion

				}
			}
		}
	}
}
