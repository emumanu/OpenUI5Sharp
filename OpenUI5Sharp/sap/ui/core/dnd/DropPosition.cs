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
					/// Configuration options for drop positions.
					/// </summary>
					[External]
					[Namespace(false)]
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
