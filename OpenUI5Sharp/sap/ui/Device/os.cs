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
				/// Contains information about the operating system of the device.
				/// </summary>
				[External]
				[Namespace(false)]
				public static partial class os
				{
					#region Fields

					/// <summary>
					/// If this flag is set to <code>true</code>, an Android operating system is used.
					/// </summary>
					public static bool android;

					/// <summary>
					/// If this flag is set to <code>true</code>, a Blackberry operating system is used.
					/// </summary>
					public static bool blackberry;

					/// <summary>
					/// If this flag is set to <code>true</code>, an iOS operating system is used.
					/// </summary>
					public static bool ios;

					/// <summary>
					/// If this flag is set to <code>true</code>, a Linux operating system is used.
					/// </summary>
					public static bool linux;

					/// <summary>
					/// If this flag is set to <code>true</code>, a Mac operating system is used.
					/// </summary>
					public static bool macintosh;

					/// <summary>
					/// The name of the operating system.
					/// </summary>
					public static string name;

					/// <summary>
					/// The version of the operating system as <code>float</code>.
					/// 
					/// Might be <code>-1</code> if no version can be determined.
					/// </summary>
					public static float version;

					/// <summary>
					/// The version of the operating system as <code>string</code>.
					/// 
					/// Might be empty if no version can be determined.
					/// </summary>
					public static string versionStr;

					/// <summary>
					/// If this flag is set to <code>true</code>, a Windows operating system is used.
					/// </summary>
					public static bool windows;

					/// <summary>
					/// If this flag is set to <code>true</code>, a Windows Phone operating system is used.
					/// </summary>
					public static bool windows_phone;

					#endregion

				}
			}
		}
	}
}
