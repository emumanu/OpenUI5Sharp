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
			public partial class Device
			{
				/// <summary>
				/// Contains information about the operating system of the device.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.Device.os")]
				public partial class Os
				{
					#region Fields

					/// <summary>
					/// If this flag is set to <code>true</code>, an Android operating system is used.
					/// </summary>
					public bool android;

					/// <summary>
					/// If this flag is set to <code>true</code>, a Blackberry operating system is used.
					/// </summary>
					public bool blackberry;

					/// <summary>
					/// If this flag is set to <code>true</code>, an iOS operating system is used.
					/// </summary>
					public bool ios;

					/// <summary>
					/// If this flag is set to <code>true</code>, a Linux operating system is used.
					/// </summary>
					public bool linux;

					/// <summary>
					/// If this flag is set to <code>true</code>, a Mac operating system is used.
					/// </summary>
					public bool macintosh;

					/// <summary>
					/// The name of the operating system.
					/// </summary>
					public string name;

					/// <summary>
					/// The version of the operating system as <code>float</code>.
					/// 
					/// Might be <code>-1</code> if no version can be determined.
					/// </summary>
					public float version;

					/// <summary>
					/// The version of the operating system as <code>string</code>.
					/// 
					/// Might be empty if no version can be determined.
					/// </summary>
					public string versionStr;

					/// <summary>
					/// If this flag is set to <code>true</code>, a Windows operating system is used.
					/// </summary>
					public bool windows;

					/// <summary>
					/// If this flag is set to <code>true</code>, a Windows Phone operating system is used.
					/// </summary>
					public bool windows_phone;

					#endregion

					/// <summary>
					/// Enumeration containing the names of known operating systems.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.Device.os.OS")]
					public enum OS
					{
						/// <summary>
						/// Android operating system name.
						/// </summary>
						ANDROID,
						/// <summary>
						/// Blackberry operating system name.
						/// </summary>
						BLACKBERRY,
						/// <summary>
						/// iOS operating system name.
						/// </summary>
						IOS,
						/// <summary>
						/// Linux operating system name.
						/// </summary>
						LINUX,
						/// <summary>
						/// MAC operating system name.
						/// </summary>
						MACINTOSH,
						/// <summary>
						/// Windows operating system name.
						/// </summary>
						WINDOWS,
						/// <summary>
						/// Windows Phone operating system name.
						/// </summary>
						WINDOWS_PHONE,
					}
				}
			}
		}
	}
}
