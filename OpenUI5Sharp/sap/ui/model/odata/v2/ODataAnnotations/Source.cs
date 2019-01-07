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
			public static partial class model
			{
				public static partial class odata
				{
					public static partial class v2
					{
						public partial class ODataAnnotations
						{
							/// <summary>
							/// An annotation source, containing either a URL to be loaded or an XML string to be parsed.
							/// </summary>
							[External]
							[Namespace(false)]
							[Name("sap.ui.model.odata.v2.ODataAnnotations.Source")]
							public partial class Source
							{
								#region Fields

								/// <summary>
								/// The source type. Either "url" or "xml".
								/// </summary>
								public string type;

								/// <summary>
								/// Either the data or a Promise that resolves with the data string as argument. In case the type is set to "url" the data must be a URL, in case it is set to "xml" the data must be an XML string.
								/// </summary>
								public Union<string, es5.Promise<object>> data;

								/// <summary>
								/// (Set internally, available in event-callback) The XML string of the annotation source
								/// </summary>
								public string xml;

								/// <summary>
								/// (Set internally, available in event-callback) The parsed XML document of the annotation source
								/// </summary>
								public Retyped.dom.HTMLDocument document;

								/// <summary>
								/// (Set internally, available in event-callback) The parsed Annotations object of the annotation source
								/// </summary>
								public Map annotations;

								#endregion

							}
						}
					}
				}
			}
		}
	}
}
