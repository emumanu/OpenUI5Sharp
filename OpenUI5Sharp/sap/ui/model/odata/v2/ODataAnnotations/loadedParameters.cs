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
							/// Parameters of the <code>loaded</code> event
							/// </summary>
							[External]
							[Namespace(false)]
							[Name("sap.ui.model.odata.v2.ODataAnnotations.loadedParameters")]
							public partial class loadedParameters
							{
								#region Fields

								/// <summary>
								/// An array of results and Errors (@see sap.ui.model.v2.ODataAnnotations#success and @see sap.ui.model.v2.ODataAnnotations#error) that occurred while loading a group of annotations
								/// </summary>
								public Union<sap.ui.model.odata.v2.ODataAnnotations.Source[], Error[], object> result;

								#endregion

							}
						}
					}
				}
			}
		}
	}
}
