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
			/// <summary>
			/// Device and Feature Detection API: Provides information about the used browser / device and cross platform support for certain events like media queries, orientation change or resizing.
			/// 
			/// This API is independent from any other part of the UI5 framework. This allows it to be loaded beforehand, if it is needed, to create the UI5 bootstrap dynamically depending on the capabilities of the browser or device.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.ui.Device")]
			public partial class Device
			{
				#region Fields

				/// <summary>
				/// Contains information about the used browser.
				/// </summary>
				public sap.ui.Device.Browser browser;

				/// <summary>
				/// Event API for screen width changes.
				/// 
				/// This API is based on media queries but can also be used if media queries are not natively supported by the used browser. In this case, the behavior of media queries is simulated by this API.
				/// 
				/// There are several predefined {@link sap.ui.Device.media.RANGESETS range sets} available. Each of them defines a set of intervals for the screen width (from small to large). Whenever the screen width changes and the current screen width is in a different interval to the one before the change, the registered event handlers for the range set are called.
				/// 
				/// If needed, it is also possible to define a custom set of intervals.
				/// 
				/// The following example shows a typical use case: <pre>
				/// function sizeChanged(mParams) {
				///     switch(mParams.name) {
				///         case "Phone":
				///             // Do what is needed for a little screen
				///             break;
				///         case "Tablet":
				///             // Do what is needed for a medium sized screen
				///             break;
				///         case "Desktop":
				///             // Do what is needed for a large screen
				///     }
				/// }
				/// 
				/// // Register an event handler to changes of the screen size
				/// sap.ui.Device.media.attachHandler(sizeChanged, null, sap.ui.Device.media.RANGESETS.SAP_STANDARD);
				/// // Do some initialization work based on the current size
				/// sizeChanged(sap.ui.Device.media.getCurrentRange(sap.ui.Device.media.RANGESETS.SAP_STANDARD));
				/// </pre>
				/// </summary>
				public sap.ui.Device.Media media;

				/// <summary>
				/// Common API for orientation change notifications across all platforms.
				/// 
				/// For browsers or devices that do not provide native support for orientation change events the API simulates them based on the ratio of the document's width and height.
				/// </summary>
				public sap.ui.Device.Orientation orientation;

				/// <summary>
				/// Contains information about the operating system of the device.
				/// </summary>
				public sap.ui.Device.Os os;

				/// <summary>
				/// Common API for document window size change notifications across all platforms.
				/// </summary>
				public sap.ui.Device.Resize resize;

				/// <summary>
				/// Contains information about detected capabilities of the used browser or device.
				/// </summary>
				public sap.ui.Device.Support support;

				/// <summary>
				/// Provides a basic categorization of the used device based on various indicators.
				/// 
				/// These indicators are for example the support of touch events, the screen size, the used operation system or the user agent of the browser.
				/// 
				/// <b>Note:</b> Depending on the capabilities of the device it is also possible that multiple flags are set to <code>true</code>.
				/// </summary>
				public sap.ui.Device.System system;

				#endregion

			}
		}
	}
}
