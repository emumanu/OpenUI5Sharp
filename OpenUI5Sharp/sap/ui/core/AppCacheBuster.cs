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
			public static partial class core
			{
				/// <summary>
				/// The AppCacheBuster is used to hook into URL relevant functions in jQuery and SAPUI5 and rewrite the URLs with a timestamp segment. The timestamp information is fetched from the server and used later on for the URL rewriting.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.core.AppCacheBuster")]
				public static partial class AppCacheBuster
				{
					#region Methods

					/// <summary>
					/// Converts the given URL if it matches a URL in the cachebuster index. If not then the same URL will be returned. To prevent URLs from being modified by the application cachebuster you can implement the function <code>sap.ui.core.AppCacheBuster.handleURL</code>.
					/// </summary>
					/// <param name="sUrl">any URL</param>
					/// <returns>modified URL when matching the index or unmodified when not</returns>
					public extern static string convertURL(string sUrl);

					/// <summary>
					/// Callback function which can be overwritten to programmatically decide whether to rewrite the given URL or not.
					/// </summary>
					/// <param name="sUrl">any URL</param>
					/// <returns><code>true</code> to rewrite or <code>false</code> to ignore</returns>
					public extern static bool handleURL(string sUrl);

					/// <summary>
					/// Normalizes the given URL and make it absolute.
					/// </summary>
					/// <param name="sUrl">any URL</param>
					/// <returns>normalized URL</returns>
					public extern static string normalizeURL(string sUrl);

					/// <summary>
					/// Registers an application. Loads the cachebuster index file from this locations. All registered files will be considered by the cachebuster and the URLs will be prefixed with the timestamp of the index file.
					/// </summary>
					/// <param name="base">URL of an application providing a cachebuster index file</param>
					public extern static void register(string @base);

					#endregion

				}
			}
		}
	}
}
