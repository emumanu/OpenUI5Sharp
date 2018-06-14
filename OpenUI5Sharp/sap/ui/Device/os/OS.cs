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
				public static partial class os
				{
					/// <summary>
					/// Enumeration containing the names of known operating systems.
					/// </summary>
					[External]
					[Namespace(false)]
					public static partial class OS
					{
						#region Fields

						/// <summary>
						/// Android operating system name.
						/// </summary>
						public static object ANDROID;

						/// <summary>
						/// Blackberry operating system name.
						/// </summary>
						public static object BLACKBERRY;

						/// <summary>
						/// iOS operating system name.
						/// </summary>
						public static object IOS;

						/// <summary>
						/// Linux operating system name.
						/// </summary>
						public static object LINUX;

						/// <summary>
						/// MAC operating system name.
						/// </summary>
						public static object MACINTOSH;

						/// <summary>
						/// Windows operating system name.
						/// </summary>
						public static object WINDOWS;

						/// <summary>
						/// Windows Phone operating system name.
						/// </summary>
						public static object WINDOWS_PHONE;

						#endregion

					}
				}
			}
		}
	}
}
