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
			/// <summary>
			/// Device and Feature Detection API: Provides information about the used browser / device and cross platform support for certain events like media queries, orientation change or resizing.
			/// 
			/// This API is independent from any other part of the UI5 framework. This allows it to be loaded beforehand, if it is needed, to create the UI5 bootstrap dynamically depending on the capabilities of the browser or device.
			/// </summary>
			[External]
			[Namespace(false)]
			public static partial class Device
			{
			}
		}
	}
}
