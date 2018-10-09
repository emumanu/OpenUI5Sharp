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
					/// Separation, e.g. of a layout cell from its neighbor, via a vertical gutter of defined width, with or without a vertical line in its middle.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.commons.layout.Separation")]
					public enum Separation
					{
						/// <summary>
						/// A large (63px) vertical gutter without a vertical line.
						/// </summary>
						Large,
						/// <summary>
						/// A large (63px) vertical gutter with a vertical line in its middle.
						/// </summary>
						LargeWithLine,
						/// <summary>
						/// A medium (31px) vertical gutter without a vertical line.
						/// </summary>
						Medium,
						/// <summary>
						/// A medium (31px) vertical gutter with a vertical line in its middle.
						/// </summary>
						MediumWithLine,
						/// <summary>
						/// No gutter at all (0px), and without a vertical line, of course.
						/// </summary>
						None,
						/// <summary>
						/// A small (17px) vertical gutter without a vertical line.
						/// </summary>
						Small,
						/// <summary>
						/// A small (17px) vertical gutter with a vertical line in its middle.
						/// </summary>
						SmallWithLine,
					}
				}
			}
		}
	}
}
