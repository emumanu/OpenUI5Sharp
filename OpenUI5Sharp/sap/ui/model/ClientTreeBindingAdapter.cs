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
				[External]
				[Namespace(false)]
				[Name("sap.ui.model.ClientTreeBindingAdapter")]
				public partial class ClientTreeBindingAdapter
				{
					#region Constructor

					/// <summary>
					/// Adapter for TreeBindings to add the ListBinding functionality and use the tree structure in list based controls.
					/// </summary>
					public extern ClientTreeBindingAdapter();

					#endregion

				}
			}
		}
	}
}
