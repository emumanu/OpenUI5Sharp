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
				public static partial class routing
				{
					/// <summary>
					/// Enumaration for different HistoryDirections
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.core.routing.HistoryDirection")]
					public enum HistoryDirection
					{
						/// <summary>
						/// The page has already been navigated to and it was the precessor of the previous page
						/// </summary>
						Backwards,
						/// <summary>
						/// The page has already been navigated to and it was the successor of the previous page
						/// </summary>
						Forwards,
						/// <summary>
						/// A new Entry is added to the history
						/// </summary>
						NewEntry,
						/// <summary>
						/// A Navigation took place, but it could be any of the other three states
						/// </summary>
						Unknown,
					}
				}
			}
		}
	}
}
