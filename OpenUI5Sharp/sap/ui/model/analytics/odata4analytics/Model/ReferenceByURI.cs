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
				public static partial class analytics
				{
					public static partial class odata4analytics
					{
						public partial class Model
						{
							/// <summary>
							/// Handle to an OData model by the URI pointing to it.
							/// </summary>
							[External]
							[Namespace(false)]
							[Name("sap.ui.model.analytics.odata4analytics.Model.ReferenceByURI")]
							public partial class ReferenceByURI
							{
								#region Constructor

								/// <summary>
								/// Create a reference to an OData model by the URI of the related OData service.
								/// </summary>
								/// <param name="sURI">holding the URI.</param>
								public extern ReferenceByURI(string sURI);

								#endregion

							}
						}
					}
				}
			}
		}
	}
}
