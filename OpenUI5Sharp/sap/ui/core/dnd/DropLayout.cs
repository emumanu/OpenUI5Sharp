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
			public static partial class core
			{
				public static partial class dnd
				{
					/// <summary>
					/// Configuration options for the layout of the droppable controls.
					/// </summary>
					[External]
					[Namespace(false)]
					public enum DropLayout
					{
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
