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
			[External]
			[Namespace(false)]
			[Name("sap.ui.VersionInfo")]
			public static partial class VersionInfo
			{
				#region Typed Parameters

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class LoadOptions
				{
					/// <summary>
					/// name of the library (e.g. "sap.ui.core")
					/// </summary>
					public string library;

				}

				#endregion

				#region Methods

				/// <summary>
				/// Loads the version info file (resources/sap-ui-version.json) asynchronously and returns a Promise. The returned Promise resolves with the version info files content.
				/// 
				/// If a library name is specified then the version info of the individual library will be retrieved.
				/// 
				/// In case of the version info file is not available an error will occur when calling this function.
				/// </summary>
				/// <param name="mOptions">an object map (see below)</param>
				/// <returns>a Promise which resolves with one of these values: the full version info, the library specific one, undefined if library is not listed or there was an error during loading.</returns>
				public extern static es5.Promise<object> load(sap.ui.VersionInfo.LoadOptions mOptions);

				#endregion

			}
		}
	}
}
