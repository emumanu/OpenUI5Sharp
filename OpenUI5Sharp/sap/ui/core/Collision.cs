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
				/// <summary>
				/// Collision behavior: horizontal/vertical.
				/// 
				/// Defines how the position of an element should be adjusted in case it overflows the window in some direction. For both directions this can be "flip", "fit" or "none". If only one behavior is provided it is applied to both directions. Examples: "flip", "fit none".
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.core.Collision")]
				public partial class Collision
				{
					public static extern implicit operator string(Collision ts);
					public static extern implicit operator Collision(string val);
				}
			}
		}
	}
}
