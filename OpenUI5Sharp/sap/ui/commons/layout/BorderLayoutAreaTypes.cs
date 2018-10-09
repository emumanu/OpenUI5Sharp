using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public static partial class sap
	{
		public static partial class ui
		{
			public static partial class commons
			{
				public static partial class layout
				{
					/// <summary>
					/// The type (=position) of a BorderLayoutArea
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.commons.layout.BorderLayoutAreaTypes")]
					public enum BorderLayoutAreaTypes
					{
						/// <summary>
						/// Value to identify the begin area.
						/// </summary>
						begin,
						/// <summary>
						/// Value to identify the bottom area.
						/// </summary>
						bottom,
						/// <summary>
						/// Value to identify the center area.
						/// </summary>
						center,
						/// <summary>
						/// Value to identify the end area.
						/// </summary>
						end,
						/// <summary>
						/// Value to identify the top area.
						/// </summary>
						top,
					}
				}
			}
		}
	}
}
