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
			public static partial class core
			{
				public static partial class dnd
				{
					/// <summary>
					/// Configuration options for the layout of the droppable controls.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.core.dnd.DropLayout")]
					public enum DropLayout
					{
						/// <summary>
						/// Default {@link sap.ui.core.Element.extend layout} definition of the aggregations.
						/// </summary>
						Default,
						/// <summary>
						/// Droppable controls are arranged horizontally.
						/// </summary>
						Horizontal,
						/// <summary>
						/// Droppable controls are arranged vertically.
						/// </summary>
						Vertical,
					}
				}
			}
		}
	}
}
