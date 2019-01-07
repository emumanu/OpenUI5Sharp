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
							/// Parameters of the <code>error</code> event
							/// </summary>
							[External]
							[Namespace(false)]
							[Name("sap.ui.model.odata.v2.ODataAnnotations.errorParameters")]
							public partial class errorParameters
							{
								#region Fields

								/// <summary>
								/// The error that occurred. Also contains the properties from sap.ui.model.odata.v2.ODataAnnotations.Source that could be filled up to that point
								/// </summary>
								public Error result;

								#endregion

							}
						}
					}
				}
			}
		}
	}
}
