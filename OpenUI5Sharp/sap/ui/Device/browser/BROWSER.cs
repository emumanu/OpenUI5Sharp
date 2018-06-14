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
				public static partial class browser
				{
					/// <summary>
					/// Enumeration containing the names of known browsers.
					/// </summary>
					[External]
					[Namespace(false)]
					public static partial class BROWSER
					{
						#region Fields

						/// <summary>
						/// Android stock browser name.
						/// </summary>
						public static object ANDROID;

						/// <summary>
						/// Chrome browser name.
						/// </summary>
						public static object CHROME;

						/// <summary>
						/// Edge browser name.
						/// </summary>
						public static object EDGE;

						/// <summary>
						/// Firefox browser name.
						/// </summary>
						public static object FIREFOX;

						/// <summary>
						/// Internet Explorer browser name.
						/// </summary>
						public static object INTERNET_EXPLORER;

						/// <summary>
						/// Safari browser name.
						/// </summary>
						public static object SAFARI;

						#endregion

					}
				}
			}
		}
	}
}
