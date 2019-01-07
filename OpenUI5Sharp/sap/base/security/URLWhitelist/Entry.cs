using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public partial class sap
	{
		public static partial class @base
		{
			public static partial class security
			{
				public partial class URLWhitelist
				{
					/// <summary>
					/// Entry object of the URLWhitelist
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.base.security.URLWhitelist.Entry")]
					public partial class Entry
					{
						#region Fields

						/// <summary>
						/// The protocol of the URL
						/// </summary>
						public string protocol;

						/// <summary>
						/// The host of the URL
						/// </summary>
						public string host;

						/// <summary>
						/// The port of the URL
						/// </summary>
						public string port;

						/// <summary>
						/// the path of the URL
						/// </summary>
						public string path;

						#endregion

					}
				}
			}
		}
	}
}
