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
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.layout")]
				[Obsolete("Deprecated since 1.38.")]
				public static partial class layout
				{
					/// <summary>
					/// Horizontal alignment, e.g. of a layout cell's content within the cell's borders. Note that some values depend on the current locale's writing direction while others do not.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.commons.layout.HAlign")]
					[Obsolete("Deprecated since 1.38.")]
					public enum HAlign
					{
						/// <summary>
						/// Aligned towards the beginning of a line, in the current locale's writing direction.
						/// </summary>
						Begin,
						/// <summary>
						/// Horizontally centered.
						/// </summary>
						Center,
						/// <summary>
						/// Aligned towards the end of a line, in the current locale's writing direction.
						/// </summary>
						End,
						/// <summary>
						/// Left aligned, regardless of the current locale's writing direction.
						/// </summary>
						Left,
						/// <summary>
						/// Right aligned, regardless of the current locale's writing direction.
						/// </summary>
						Right,
					}
					/// <summary>
					/// Vertical alignment, e.g. of a layout cell's content within the cell's borders.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.commons.layout.VAlign")]
					[Obsolete("Deprecated since 1.38.")]
					public enum VAlign
					{
						/// <summary>
						/// Aligned at the bottom.
						/// </summary>
						Bottom,
						/// <summary>
						/// Vertically centered.
						/// </summary>
						Middle,
						/// <summary>
						/// Aligned at the top.
						/// </summary>
						Top,
					}
					/// <summary>
					/// Padding, e.g. of a layout cell's content within the cell's borders. Note that all options except "None" include a padding of 2px at the top and bottom, and differ only in the presence of a 4px padding towards the beginning or end of a line, in the current locale's writing direction.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.commons.layout.Padding")]
					[Obsolete("Deprecated since 1.38.")]
					public enum Padding
					{
						/// <summary>
						/// Top and bottom padding of 2px. Padding of 4px towards the beginning of a line, in the current locale's writing direction, but none towards its end.
						/// </summary>
						Begin,
						/// <summary>
						/// Top and bottom padding of 2px. Padding of 4px towards both the beginning and end of a line.
						/// </summary>
						Both,
						/// <summary>
						/// Top and bottom padding of 2px. Padding of 4px towards the end of a line, in the current locale's writing direction, but none towards its beginning.
						/// </summary>
						End,
						/// <summary>
						/// Top and bottom padding of 2px. No padding towards neither the beginning nor end of a line.
						/// </summary>
						Neither,
						/// <summary>
						/// No padding at all.
						/// </summary>
						None,
					}
					/// <summary>
					/// Separation, e.g. of a layout cell from its neighbor, via a vertical gutter of defined width, with or without a vertical line in its middle.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.commons.layout.Separation")]
					[Obsolete("Deprecated since 1.38.")]
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
					/// <summary>
					/// Background design (i.e. color), e.g. of a layout cell.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.commons.layout.BackgroundDesign")]
					[Obsolete("Deprecated since 1.38.")]
					public enum BackgroundDesign
					{
						/// <summary>
						/// A background design suitable for borders.
						/// </summary>
						Border,
						/// <summary>
						/// An opaque background design that looks dark filled.
						/// </summary>
						Fill1,
						/// <summary>
						/// An opaque background design that looks medium filled.
						/// </summary>
						Fill2,
						/// <summary>
						/// An opaque background design that looks light filled.
						/// </summary>
						Fill3,
						/// <summary>
						/// A background design suitable for headers.
						/// </summary>
						Header,
						/// <summary>
						/// A plain but opaque background design.
						/// </summary>
						Plain,
						/// <summary>
						/// A transparent background.
						/// </summary>
						Transparent,
					}
					/// <summary>
					/// The type (=position) of a BorderLayoutArea
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.commons.layout.BorderLayoutAreaTypes")]
					[Obsolete("Deprecated since 1.38.")]
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
