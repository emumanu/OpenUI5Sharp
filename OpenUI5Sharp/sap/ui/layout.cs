using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace OpenUI5Sharp
{
	public static partial class sap
	{
		public static partial class ui
		{
			/// <summary>
			/// SAPUI5 library with layout controls.
			/// </summary>
			[External]
			[Namespace(false)]
			public static partial class layout
			{
				/// <summary>
				/// The position of the Grid. Can be "Left", "Center" or "Right". "Left" is default.
				/// </summary>
				[External]
				[Namespace(false)]
				public enum GridPosition
				{
						/// <summary>
						/// Grid is centered on the screen.
						/// </summary>
						Center,
						/// <summary>
						/// Grid is aligned left.
						/// </summary>
						Left,
						/// <summary>
						/// Grid is aligned to the right.
						/// </summary>
						Right,
				}
				/// <summary>
				/// Available Background Design.
				/// </summary>
				[External]
				[Namespace(false)]
				public enum BackgroundDesign
				{
						/// <summary>
						/// A solid background color dependent on the theme.
						/// </summary>
						Solid,
						/// <summary>
						/// A translucent background depending on the opacity value of the theme.
						/// </summary>
						Translucent,
						/// <summary>
						/// Transparent background.
						/// </summary>
						Transparent,
				}
				/// <summary>
				/// A string type that is used inside the BlockLayoutRow to set predefined set of colors the cells inside the control. Color sets depend on sap.ui.layout.BlockBackgroundType
				/// </summary>
				[External]
				[Namespace(false)]
				public enum BlockRowColorSets
				{
						/// <summary>
						/// sap.ui.layout.BlockBackgroundType.Default: N/A sap.ui.layout.BlockBackgroundType.Light: Color Set 1 sap.ui.layout.BlockBackgroundType.Mixed: Color Set 1 sap.ui.layout.BlockBackgroundType.Accent: Color Set 1 sap.ui.layout.BlockBackgroundType.Dashboard: N/A
						/// </summary>
						ColorSet1,
						/// <summary>
						/// sap.ui.layout.BlockBackgroundType.Default: N/A sap.ui.layout.BlockBackgroundType.Light: Color Set 2 sap.ui.layout.BlockBackgroundType.Mixed: Color Set 2 sap.ui.layout.BlockBackgroundType.Accent: Color Set 2 sap.ui.layout.BlockBackgroundType.Dashboard: N/A
						/// </summary>
						ColorSet2,
						/// <summary>
						/// sap.ui.layout.BlockBackgroundType.Default: N/A sap.ui.layout.BlockBackgroundType.Light: Color Set 1 sap.ui.layout.BlockBackgroundType.Mixed: Color Set 1 sap.ui.layout.BlockBackgroundType.Accent: Color Set 3 sap.ui.layout.BlockBackgroundType.Dashboard: N/A
						/// </summary>
						ColorSet3,
						/// <summary>
						/// sap.ui.layout.BlockBackgroundType.Default: N/A sap.ui.layout.BlockBackgroundType.Light: Color Set 2 sap.ui.layout.BlockBackgroundType.Mixed: Color Set 2 sap.ui.layout.BlockBackgroundType.Accent: Color Set 4 sap.ui.layout.BlockBackgroundType.Dashboard: N/A
						/// </summary>
						ColorSet4,
				}
				/// <summary>
				/// A string type that is used inside the BlockLayout to set predefined background color to the cells inside the control.
				/// </summary>
				[External]
				[Namespace(false)]
				public enum BlockBackgroundType
				{
						/// <summary>
						/// Background with pre-defined accent colors
						/// </summary>
						Accent,
						/// <summary>
						/// For applications that want to make use of e.g. charts in the Blocks, this layout type has spacings around the Blocks
						/// </summary>
						Dashboard,
						/// <summary>
						/// Background is transparent
						/// </summary>
						Default,
						/// <summary>
						/// Background is with predefined light colors
						/// </summary>
						Light,
						/// <summary>
						/// Background with bright and dark background colors
						/// </summary>
						Mixed,
				}
				/// <summary>
				/// Types of the DynamicSideContent FallDown options
				/// </summary>
				[External]
				[Namespace(false)]
				public enum SideContentFallDown
				{
						/// <summary>
						/// Side content falls down on breakpoints below L
						/// </summary>
						BelowL,
						/// <summary>
						/// Side content falls down on breakpoints below M
						/// </summary>
						BelowM,
						/// <summary>
						/// Side content falls down on breakpoints below XL
						/// </summary>
						BelowXL,
						/// <summary>
						/// Side content falls down on breakpoint M and the minimum width for the side content
						/// </summary>
						OnMinimumWidth,
				}
				/// <summary>
				/// The position of the side content - End (default) and Begin.
				/// </summary>
				[External]
				[Namespace(false)]
				public enum SideContentPosition
				{
						/// <summary>
						/// The side content is on the left side of the main container in left-to-right mode and on the right side in right-to-left mode.
						/// </summary>
						Begin,
						/// <summary>
						/// The side content is on the right side of the main container in left-to-right mode and on the left side in right-to-left mode.
						/// </summary>
						End,
				}
				/// <summary>
				/// Types of the DynamicSideContent Visibility options
				/// </summary>
				[External]
				[Namespace(false)]
				public enum SideContentVisibility
				{
						/// <summary>
						/// Show the side content on any breakpoint
						/// </summary>
						AlwaysShow,
						/// <summary>
						/// Don't show the side content on any breakpoints
						/// </summary>
						NeverShow,
						/// <summary>
						/// Show the side content on XL breakpoint
						/// </summary>
						ShowAboveL,
						/// <summary>
						/// Show the side content on L and XL breakpoints
						/// </summary>
						ShowAboveM,
						/// <summary>
						/// Show the side content on M, L and XL breakpoints
						/// </summary>
						ShowAboveS,
				}
				/// <summary>
				/// A string type that is used inside the BlockLayoutCell to set a predefined set of colors for the cells.
				/// </summary>
				[External]
				[Namespace(false)]
				public enum BlockLayoutCellColorSet
				{
						/// <summary>
						/// Color Set 1
						/// </summary>
						ColorSet1,
						/// <summary>
						/// Color Set 10
						/// </summary>
						ColorSet10,
						/// <summary>
						/// Color Set 11
						/// </summary>
						ColorSet11,
						/// <summary>
						/// Color Set 2
						/// </summary>
						ColorSet2,
						/// <summary>
						/// Color Set 3
						/// </summary>
						ColorSet3,
						/// <summary>
						/// Color Set 4
						/// </summary>
						ColorSet4,
						/// <summary>
						/// Color Set 5
						/// </summary>
						ColorSet5,
						/// <summary>
						/// Color Set 6
						/// </summary>
						ColorSet6,
						/// <summary>
						/// Color Set 7
						/// </summary>
						ColorSet7,
						/// <summary>
						/// Color Set 8
						/// </summary>
						ColorSet8,
						/// <summary>
						/// Color Set 9
						/// </summary>
						ColorSet9,
				}
				/// <summary>
				/// A string type that is used inside the BlockLayoutCell to set a predefined set of color shades for the cells. The colors are defined with sap.ui.layout.BlockLayoutCellColorSet. And this is for the shades only.
				/// </summary>
				[External]
				[Namespace(false)]
				public enum BlockLayoutCellColorShade
				{
						/// <summary>
						/// Shade A
						/// </summary>
						ShadeA,
						/// <summary>
						/// Shade B
						/// </summary>
						ShadeB,
						/// <summary>
						/// Shade C
						/// </summary>
						ShadeC,
						/// <summary>
						/// Shade D
						/// </summary>
						ShadeD,
				}
			}
		}
	}
}
