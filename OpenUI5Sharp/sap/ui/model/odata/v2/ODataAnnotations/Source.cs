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
			public static partial class model
			{
				public static partial class odata
				{
					public static partial class v2
					{
						public partial class ODataAnnotations : sap.ui.@base.EventProvider
						{
							/// <summary>
							/// An annotation source, containing either a URL to be loaded or an XML string to be parsed.
							/// </summary>
							[External]
							[Namespace(false)]
							public partial class Source
							{
							}
						}
					}
				}
			}
		}
	}
}
