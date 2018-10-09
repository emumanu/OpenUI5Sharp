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
							/// Handle to an already instantiated SAPUI5 OData model.
							/// </summary>
							[External]
							[Namespace(false)]
							[Name("sap.ui.model.analytics.odata4analytics.Model.ReferenceByModel")]
							public partial class ReferenceByModel
							{
								#region Constructor

								/// <summary>
								/// Create a reference to an OData model already loaded elsewhere with the help of SAPUI5.
								/// </summary>
								/// <param name="oModel">holding the OData model.</param>
								public extern ReferenceByModel(object oModel);

								#endregion

							}
						}
					}
				}
			}
		}
	}
}
