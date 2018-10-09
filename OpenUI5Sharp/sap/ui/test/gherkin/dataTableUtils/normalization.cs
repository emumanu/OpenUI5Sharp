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
			public static partial class test
			{
				public static partial class gherkin
				{
					public static partial class dataTableUtils
					{
						/// <summary>
						/// A simple object containing a series of normalization functions that change a string according to a particular strategy. All strategies do the following normalization as a minimum:
						/// 
						/// <ul> <li>Trim spaces off the string on both sides. For example: <code>" hello "</code> becomes <code>"hello"</code>.</li> <li>Assume that dashes and underscores are analogs for a space. For example: <code>"sold-to party"</code> and <code>"sold to party"</code> are equivalent, and would both convert to the camelCase <code>"soldToParty"</code>.</li> <li>Trim multiple spaces between words. For example: <code>"hello____world"</code> becomes <code>"hello world"</code>.</li> <li>Remove any characters that are not alphanumeric or whitespace. For example: <code>"(hello)"</code> becomes <code>"hello"</code>.</li> </ul>
						/// </summary>
						[External]
						[Namespace(false)]
						[Name("sap.ui.test.gherkin.dataTableUtils.normalization")]
						public static partial class normalization
						{
							#region Methods

							/// <summary>
							/// For example: "First Name" -> "firstName"
							/// </summary>
							/// <param name="sString">the string to normalize</param>
							/// <returns>the normalized input string with all words after the first capitalized and all spaces removed</returns>
							public extern static string camelCase(string sString);

							/// <summary>
							/// For example: "First Name" -> "first-name"
							/// </summary>
							/// <param name="sString">the string to normalize</param>
							/// <returns>the normalized input string changed to lower case and with space between words replaced by a hyphen ("-")</returns>
							public extern static string hyphenated(string sString);

							/// <summary>
							/// For example: "First Name" -> "First Name"
							/// </summary>
							/// <param name="sString">the string to normalize</param>
							/// <returns>the original unchanged input string</returns>
							public extern static string none(string sString);

							/// <summary>
							/// For example: "first name" -> "FirstName"
							/// </summary>
							/// <param name="sString">the string to normalize</param>
							/// <returns>the normalized input string with all words capitalized and all spaces removed</returns>
							public extern static string pascalCase(string sString);

							/// <summary>
							/// For example: "first name" -> "First Name"
							/// </summary>
							/// <param name="sString">the string to normalize</param>
							/// <returns>the normalized input string with all words capitalized</returns>
							public extern static string titleCase(string sString);

							#endregion

						}
					}
				}
			}
		}
	}
}
