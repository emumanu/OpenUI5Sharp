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
							[Name("sap.ui.model.analytics.odata4analytics.Model.ReferenceWithWorkaround")]
							public partial class ReferenceWithWorkaround
							{
								#region Constructor

								/// <summary>
								/// Create a reference to an OData model having certain workarounds activated. A workaround is an implementation that changes the standard behavior of the API to overcome some gap or limitation in the OData provider. The workaround implementation can be conditionally activated by passing the identifier in the constructor.
								/// 
								/// Known workaround identifiers are:
								/// 
								/// <li>"CreateLabelsFromTechnicalNames" - If a property has no label text, it gets generated from the property name.</li>
								/// 
								/// <li>"IdentifyTextPropertiesByName" -If a dimension property has no text and another property with the same name and an appended "Name", "Text" etc. exists, they are linked via annotation.</li>
								/// </summary>
								/// <param name="oModel">holding a reference to the OData model, obtained by odata4analytics.Model.ReferenceByModel or by sap.odata4analytics.Model.ReferenceByURI.</param>
								/// <param name="aWorkaroundID">listing all workarounds to be applied.</param>
								public extern ReferenceWithWorkaround(object oModel, string[] aWorkaroundID);

								#endregion

							}
						}
					}
				}
			}
		}
	}
}
