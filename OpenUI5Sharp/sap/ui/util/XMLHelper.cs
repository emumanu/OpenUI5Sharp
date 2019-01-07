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
			public static partial class util
			{
				/// <summary>
				/// Provides functionality for parsing XML formatted strings and serializing XML documents.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.util.XMLHelper")]
				public partial class XMLHelper
				{
					#region Methods

					/// <summary>
					/// Extracts parse error information from the specified document (if any).
					/// 
					/// If an error was found the returned object has the following error information parameters: errorCode, url, reason, srcText, line, linepos, filepos
					/// </summary>
					/// <param name="oDocument">the parsed XML document</param>
					/// <returns>oParseError if errors were found, or an object with an errorCode of 0 only</returns>
					public extern static object getParseError(string oDocument);

					/// <summary>
					/// Parses the specified XML formatted string text using native parsing function of the browser and returns a valid XML document. If an error occurred during parsing a parse error xobject is returned as property (parseError) of the returned XML document object. The parse error object has the following error information parameters: errorCode, url, reason, srcText, line, linepos, filepos
					/// </summary>
					/// <param name="sXMLText">the XML data as string</param>
					/// <returns>the parsed XML document with a parseError property as described in getParseError. An error occurred if the errorCode property of the parseError is != 0.</returns>
					public extern static object parse(string sXMLText);

					/// <summary>
					/// Serializes the specified XML document into a string representation.
					/// </summary>
					/// <param name="oXMLDocument">the XML document object to be serialized as string</param>
					/// <returns>the serialized XML string</returns>
					public extern static object serialize(string oXMLDocument);

					#endregion

				}
			}
		}
	}
}
