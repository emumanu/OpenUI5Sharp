using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace OpenUI5Sharp
{
	public partial class jQuery
	{
		public static partial class sap
		{
			public static partial class util
			{
				/// <summary>
				/// Encapsulates all URI parameters of the current windows location (URL).
				/// 
				/// Use {@link jQuery.sap.getUriParameters} to create an instance of jQuery.sap.util.UriParameters.
				/// </summary>
				[External]
				[Namespace(false)]
				public partial interface UriParameters
				{
					#region Methods

					/// <summary>
					/// Returns the value(s) of the URI parameter with the given name sName.
					/// 
					/// If the boolean parameter bAll is <code>true</code>, an array of string values of all occurrences of the URI parameter with the given name is returned. This array is empty if the URI parameter is not contained in the windows URL.
					/// 
					/// If the boolean parameter bAll is <code>false</code> or is not specified, the value of the first occurrence of the URI parameter with the given name is returned. Might be <code>null</code> if the URI parameter is not contained in the windows URL.
					/// </summary>
					/// <param name="sUri">The name of the URI parameter.</param>
					/// <returns>The value(s) of the URI parameter with the given name</returns>
					Union<string, object[]> get(string sUri);

					#endregion

				}
			}
		}
	}
}
