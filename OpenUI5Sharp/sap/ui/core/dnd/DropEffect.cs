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
					/// Configuration options for visual drop effects that are given during a drag and drop operation.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.core.dnd.DropEffect")]
					public enum DropEffect
					{
						/// <summary>
						/// A copy of the source item is made at the new location.
						/// </summary>
						Copy,
						/// <summary>
						/// A link is established to the source at the new location.
						/// </summary>
						Link,
						/// <summary>
						/// An item is moved to a new location.
						/// </summary>
						Move,
						/// <summary>
						/// The item cannot be dropped.
						/// </summary>
						None,
					}
				}
			}
		}
	}
}
