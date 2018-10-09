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
					/// Configuration options for drop positions.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.core.dnd.DropPosition")]
					public enum DropPosition
					{
						/// <summary>
						/// Drop between the controls.
						/// </summary>
						Between,
						/// <summary>
						/// Drop on the control.
						/// </summary>
						On,
						/// <summary>
						/// Drop on the control or between the controls.
						/// </summary>
						OnOrBetween,
					}
				}
			}
		}
	}
}
