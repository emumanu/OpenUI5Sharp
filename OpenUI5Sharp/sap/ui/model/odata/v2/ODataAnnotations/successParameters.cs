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
							/// Parameters of the <code>success</code> event
							/// </summary>
							[External]
							[Namespace(false)]
							[Name("sap.ui.model.odata.v2.ODataAnnotations.successParameters")]
							public partial class successParameters
							{
								#region Fields

								/// <summary>
								/// The source type. Either "url" or "xml".
								/// </summary>
								public sap.ui.model.odata.v2.ODataAnnotations.Source result;

								#endregion

							}
						}
					}
				}
			}
		}
	}
}
