using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public static partial class sap
	{
		/// <summary>
		/// SAPUI5 library with controls specialized for SAP Fiori apps.
		/// </summary>
		[External]
		[Namespace(false)]
		[Name("sap.f")]
		public static partial class f
		{
			/// <summary>
			/// Predefined sizes for the {@link sap.f.Avatar} control.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.f.AvatarSize")]
			public enum AvatarSize
			{
				/// <summary>
				/// Custom size
				/// </summary>
				Custom,
				/// <summary>
				/// Control size - 5rem Font size - 2rem
				/// </summary>
				L,
				/// <summary>
				/// Control size - 4rem Font size - 1.625rem
				/// </summary>
				M,
				/// <summary>
				/// Control size - 3rem Font size - 1.125rem
				/// </summary>
				S,
				/// <summary>
				/// Control size - 7rem Font size - 2.75rem
				/// </summary>
				XL,
				/// <summary>
				/// Control size - 2rem Font size - 0.75rem
				/// </summary>
				XS,
			}
			/// <summary>
			/// Types of {@link sap.f.Avatar} based on the displayed content.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.f.AvatarType")]
			public enum AvatarType
			{
				/// <summary>
				/// The displayed content is an icon.
				/// </summary>
				Icon,
				/// <summary>
				/// The displayed content is an image.
				/// </summary>
				Image,
				/// <summary>
				/// The displayed content is initials.
				/// </summary>
				Initials,
			}
			/// <summary>
			/// Layouts, representing the number of columns to be displayed and their relative widths for a {@link sap.f.FlexibleColumnLayout} control.
			/// 
			/// Each layout has a predefined ratio for the three columns, depending on device size. Based on the device and layout, some columns are hidden. For more information, refer to the ratios (in %) for each value, listed below: (dash "-" means non-accessible columns).
			/// 
			/// <b>Note:</b> Please note that on a phone device, due to the limited screen size, only one column can be displayed at a time. For all two-column layouts, this column is the <code>Mid</code> column, and for all three-column layouts - the <code>End</code> column, even though the respective column may be hidden on desktop and tablet for that particular layout. Therefore some of the names (such as <code>ThreeColumnsMidExpandedEndHidden</code> for example) are representative of the desktop scenario only.
			/// 
			/// For more information, see {@link topic:3b9f760da5b64adf8db7f95247879086 Types of Layout} in the documentation.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.f.LayoutType")]
			public enum LayoutType
			{
				/// <summary>
				/// Desktop: -/-/100 only the End column is displayed
				/// 
				/// Tablet: -/-/100 only the End column is displayed
				/// 
				/// Phone: -/-/100 only the End column is displayed
				/// 
				/// Use to display a detail-detail page only, when the user should focus entirely on it.
				/// </summary>
				EndColumnFullScreen,
				/// <summary>
				/// Desktop: -/100/- only the Mid column is displayed
				/// 
				/// Tablet: -/100/- only the Mid column is displayed
				/// 
				/// Phone: -/100/- only the Mid column is displayed
				/// 
				/// Use to display a detail page only, when the user should focus entirely on it.
				/// </summary>
				MidColumnFullScreen,
				/// <summary>
				/// Desktop: 100/-/- only the Begin column is displayed
				/// 
				/// Tablet: 100/-/- only the Begin column is displayed
				/// 
				/// Phone: 100/-/- only the Begin column is displayed
				/// 
				/// Use to start with a master page.
				/// </summary>
				OneColumn,
				/// <summary>
				/// Desktop: 67/33/0 Begin (expanded) and Mid columns are displayed, End is accessible by layout arrows
				/// 
				/// Tablet: 67/33/0 Begin (expanded) and Mid columns are displayed, End is accessible by layout arrows
				/// 
				/// Phone: -/-/100 only the End column is displayed
				/// 
				/// Use to display the master and detail pages when the user should focus on the master. The detail-detail is still loaded and easily accessible with layout arrows.
				/// </summary>
				ThreeColumnsBeginExpandedEndHidden,
				/// <summary>
				/// Desktop: 25/25/50 Begin, Mid and End (expanded) columns are displayed
				/// 
				/// Tablet: 0/33/67 Mid and End (expanded) columns are displayed, Begin is accessible by layout arrows
				/// 
				/// Phone: -/-/100 (only the End column is displayed)
				/// 
				/// Use to display all three pages (master, detail, detail-detail) when the user should focus on the detail-detail.
				/// </summary>
				ThreeColumnsEndExpanded,
				/// <summary>
				/// Desktop: 25/50/25 Begin, Mid (expanded) and End columns are displayed
				/// 
				/// Tablet: 0/67/33 Mid (expanded) and End columns are displayed, Begin is accessible by a layout arrow
				/// 
				/// Phone: -/-/100 only the End column is displayed
				/// 
				/// Use to display all three pages (master, detail, detail-detail) when the user should focus on the detail.
				/// </summary>
				ThreeColumnsMidExpanded,
				/// <summary>
				/// Desktop: 33/67/0 Begin and Mid (expanded) columns are displayed, End is accessible by a layout arrow
				/// 
				/// Tablet: 33/67/0 Begin and Mid (expanded) columns are displayed, End is accessible by a layout arrow
				/// 
				/// Phone: -/-/100 only the End column is displayed
				/// 
				/// Use to display the master and detail pages when the user should focus on the detail. The detail-detail is still loaded and easily accessible with a layout arrow.
				/// </summary>
				ThreeColumnsMidExpandedEndHidden,
				/// <summary>
				/// Desktop: 67/33/- Begin (expanded) and Mid columns are displayed
				/// 
				/// Tablet: 67/33/- Begin (expanded) and Mid columns are displayed
				/// 
				/// Phone: -/100/- only the Mid column is displayed
				/// 
				/// Use to display both a master and a detail page when the user should focus on the master page.
				/// </summary>
				TwoColumnsBeginExpanded,
				/// <summary>
				/// Desktop: 33/67/- Begin and Mid (expanded) columns are displayed
				/// 
				/// Tablet: 33/67/- Begin and Mid (expanded) columns are displayed
				/// 
				/// Phone: -/100/- only the Mid column is displayed
				/// 
				/// Use to display both a master and a detail page when the user should focus on the detail page.
				/// </summary>
				TwoColumnsMidExpanded,
			}
			/// <summary>
			/// Types of shape for the {@link sap.f.Avatar} control.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.f.AvatarShape")]
			public enum AvatarShape
			{
				/// <summary>
				/// Circular shape.
				/// </summary>
				Circle,
				/// <summary>
				/// Square shape.
				/// </summary>
				Square,
			}
			/// <summary>
			/// Types of image size and position that determine how an image fits in the {@link sap.f.Avatar} control area.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.f.AvatarImageFitType")]
			public enum AvatarImageFitType
			{
				/// <summary>
				/// The image is scaled to the largest size so that both its width and height can fit in the control area.
				/// </summary>
				Contain,
				/// <summary>
				/// The image is scaled to be large enough so that the control area is completely covered.
				/// </summary>
				Cover,
			}
			/// <summary>
			/// Defines the areas within the <code>sap.f.DynamicPageTitle</code>.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.f.DynamicPageTitleArea")]
			[Obsolete("Deprecated since 1.54.")]
			public enum DynamicPageTitleArea
			{
				/// <summary>
				/// The area includes the <code>heading</code>, <code>expandedContent</code> and <code>snappedContent</code> aggregations, positioned in the beginning area of the {@link sap.f.DynamicPageTitle}.
				/// </summary>
				Begin,
				/// <summary>
				/// The area includes the <code>content</code> aggregation, positioned in the middle part of the {@link sap.f.DynamicPageTitle}.
				/// </summary>
				Middle,
			}
		}
	}
}
