using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace OpenUI5Sharp
{
	public partial class jQuery
	{
		/// <summary>
		/// Holds information about the current operating system
		/// </summary>
		[External]
		[Namespace(false)]
		[Obsolete("Deprecated since 1.20. use {@link sap.ui.Device.os} instead")]
		public static partial class os
		{
			#region Fields

			/// <summary>
			/// Whether the current operating system is Android
			/// </summary>
			public static bool android;

			/// <summary>
			/// Whether the current operating system is BlackBerry
			/// </summary>
			public static bool blackberry;

			/// <summary>
			/// The version of the operating system parsed as a float (major and first minor version)
			/// </summary>
			public static float fVersion;

			/// <summary>
			/// Whether the current operating system is Apple iOS
			/// </summary>
			public static bool ios;

			/// <summary>
			/// The name of the operating system; currently supported are: "ios", "android", "blackberry"
			/// </summary>
			public static string os_;

			/// <summary>
			/// The version of the operating system as a string (including minor versions)
			/// </summary>
			public static string version;

			/// <summary>
			/// Whether the current operating system is Windows Phone
			/// </summary>
			public static bool winphone;

			#endregion

		}
	}
}
