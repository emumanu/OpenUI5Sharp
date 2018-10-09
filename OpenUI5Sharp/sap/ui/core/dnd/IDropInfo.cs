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
					/// Marker interface for drop configuration providing information about the target of the drop operation.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.core.dnd.IDropInfo")]
					public partial interface IDropInfo
					{
					}
				}
			}
		}
	}
}
