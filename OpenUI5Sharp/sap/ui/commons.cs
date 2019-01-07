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
			/// <summary>
			/// Common basic controls, mainly intended for desktop scenarios
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.ui.commons")]
			[Obsolete("Deprecated since 1.38.")]
			public static partial class commons
			{
				#region Typed Parameters

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class LiveChangeInfo
				{
					/// <summary>
					/// Current value of the Textfield.
					/// </summary>
					public string liveValue;

				}

				#endregion

				#region Delegates

				public delegate void LiveChangeDelegate(sap.ui.@base.Event<sap.ui.commons.LiveChangeInfo> oEvent, object oData);

				#endregion

				#region Fields

				/// <summary>
				/// Level of a title.
				/// </summary>
				public static object TitleLevel;

				#endregion

				/// <summary>
				/// different styles for a button.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.ButtonStyle")]
				[Obsolete("Deprecated since 1.38.")]
				public enum ButtonStyle
				{
					/// <summary>
					/// Accept button (normally green).
					/// </summary>
					Accept,
					/// <summary>
					/// default style (no special styling).
					/// </summary>
					Default,
					/// <summary>
					/// Button is emphasized.
					/// </summary>
					Emph,
					/// <summary>
					/// Reject button (normally red).
					/// </summary>
					Reject,
				}
				/// <summary>
				/// Available label display modes.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.LabelDesign")]
				[Obsolete("Deprecated since 1.38.")]
				public enum LabelDesign
				{
					/// <summary>
					/// Displays the label in bold.
					/// </summary>
					Bold,
					/// <summary>
					/// Displays the label in normal mode.
					/// </summary>
					Standard,
				}
				/// <summary>
				/// [Enter description for MessageType]
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.MessageType")]
				[Obsolete("Deprecated since 1.38.")]
				public enum MessageType
				{
					/// <summary>
					/// Error message
					/// </summary>
					Error,
					/// <summary>
					/// Successful message
					/// </summary>
					Success,
					/// <summary>
					/// Warning message
					/// </summary>
					Warning,
				}
				/// <summary>
				/// Marker interface for common controls which are suitable for use within a toolbar. The most prominent example of a toolbar item is a button which is mostly used with an icon instead of a text caption.
				/// 
				/// Toolbar items must have a fixed height compatible with the toolbar being a single horizontal row. They can refer to the toolbar's marker class "sapUiTb" to adjust their own theming when used inside a toolbar.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.ToolbarItem")]
				[Obsolete("Deprecated since 1.38.")]
				public partial interface ToolbarItem
				{
				}
				/// <summary>
				/// Determines the visual design of a MenuBar. The feature might be not supported by all themes.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.MenuBarDesign")]
				[Obsolete("Deprecated since 1.38.")]
				public enum MenuBarDesign
				{
					/// <summary>
					/// The MenuBar appears in header design.
					/// </summary>
					Header,
					/// <summary>
					/// The MenuBar appears in standard design.
					/// </summary>
					Standard,
				}
				/// <summary>
				/// Semantic Colors of a text.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.TextViewColor")]
				[Obsolete("Deprecated since 1.38.")]
				public enum TextViewColor
				{
					/// <summary>
					/// Critical color
					/// </summary>
					Critical,
					/// <summary>
					/// Default color
					/// </summary>
					Default,
					/// <summary>
					/// Negative color
					/// </summary>
					Negative,
					/// <summary>
					/// Positive color
					/// </summary>
					Positive,
				}
				/// <summary>
				/// Determines the visual design of a Toolbar.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.ToolbarDesign")]
				[Obsolete("Deprecated since 1.38.")]
				public enum ToolbarDesign
				{
					/// <summary>
					/// The included controls have a very light appearance. The feature might be not supported by all themes.
					/// </summary>
					Flat,
					/// <summary>
					/// The toolbar elements such as buttons for example have their normal visual design, and the toolbar appears solid. The feature might be not supported by all themes.
					/// </summary>
					Standard,
					/// <summary>
					/// The controls included in the toolbar have a normal visual design where the toolbar appears transparent. The feature might be not supported by all themes.
					/// </summary>
					Transparent,
				}
				/// <summary>
				/// Distinct paginator event types
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.PaginatorEvent")]
				[Obsolete("Deprecated since 1.38.")]
				public enum PaginatorEvent
				{
					/// <summary>
					/// First page event
					/// </summary>
					First,
					/// <summary>
					/// Go to page event
					/// </summary>
					Goto,
					/// <summary>
					/// Last page event
					/// </summary>
					Last,
					/// <summary>
					/// Next page event
					/// </summary>
					Next,
					/// <summary>
					/// Previous page event
					/// </summary>
					Previous,
				}
				/// <summary>
				/// Designs for TextView.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.TextViewDesign")]
				[Obsolete("Deprecated since 1.38.")]
				public enum TextViewDesign
				{
					/// <summary>
					/// Displays the text in bold letters
					/// </summary>
					Bold,
					/// <summary>
					/// Displays the text in header 1 letters.
					/// </summary>
					H1,
					/// <summary>
					/// Displays the text in header 2 letters.
					/// </summary>
					H2,
					/// <summary>
					/// Displays the text in header 3 letters.
					/// </summary>
					H3,
					/// <summary>
					/// Displays the text in header 4 letters.
					/// </summary>
					H4,
					/// <summary>
					/// Displays the text in header 5 letters.
					/// </summary>
					H5,
					/// <summary>
					/// Displays the text in header 6 letters.
					/// </summary>
					H6,
					/// <summary>
					/// Displays the text in italic letters
					/// </summary>
					Italic,
					/// <summary>
					/// Displays the text in monospace letters.
					/// </summary>
					Monospace,
					/// <summary>
					/// Displays the text in smaller letters.
					/// </summary>
					Small,
					/// <summary>
					/// Displays the text in standard letters.
					/// </summary>
					Standard,
					/// <summary>
					/// underlined Text
					/// </summary>
					Underline,
				}
				/// <summary>
				/// different styles for a ColorPicker.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.ColorPickerMode")]
				[Obsolete("Deprecated since 1.48.0. Moved to sap.ui.unified library. Please use this one.")]
				public enum ColorPickerMode
				{
				}
				/// <summary>
				/// Determines the visual design of a RowRepeater.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.RowRepeaterDesign")]
				[Obsolete("Deprecated since 1.38.")]
				public enum RowRepeaterDesign
				{
					/// <summary>
					/// The RowRepeater will be displayed without header, toolbar or footer. Background will be transparent.
					/// </summary>
					BareShell,
					/// <summary>
					/// The RowRepeater header and footer elements, as well as the row container background, appear solid.
					/// </summary>
					Standard,
					/// <summary>
					/// The RowRepeater header and footer elements, as well as the row container background, appear transparent.
					/// </summary>
					Transparent,
				}
				/// <summary>
				/// Selection mode of the tree
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.TreeSelectionMode")]
				[Obsolete("Deprecated since 1.38.")]
				public enum TreeSelectionMode
				{
					/// <summary>
					/// Behavior of the former Tree. It is possible to select a plurality of nodes via the API.
					/// </summary>
					Legacy,
					/// <summary>
					/// Select multiple rows at a time.
					/// </summary>
					Multi,
					/// <summary>
					/// No rows can be selected.
					/// </summary>
					None,
					/// <summary>
					/// Select one row at a time.
					/// </summary>
					Single,
				}
				/// <summary>
				/// Enumeration of possible HorizontalDivider types.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.HorizontalDividerType")]
				[Obsolete("Deprecated since 1.38.")]
				public enum HorizontalDividerType
				{
					/// <summary>
					/// Type Area
					/// </summary>
					Area,
					/// <summary>
					/// Type Page
					/// </summary>
					Page,
				}
				/// <summary>
				/// States for TriStateCheckBox
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.TriStateCheckBoxState")]
				[Obsolete("Deprecated since 1.38.")]
				public enum TriStateCheckBoxState
				{
					/// <summary>
					/// checked value for tri-state checkbox
					/// </summary>
					Checked,
					/// <summary>
					/// mixed state for tri-state checkbox
					/// </summary>
					Mixed,
					/// <summary>
					/// unchecked, default value for tri-state checkbox
					/// </summary>
					Unchecked,
				}
				/// <summary>
				/// Design of the Toolbar Separator.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.ToolbarSeparatorDesign")]
				[Obsolete("Deprecated since 1.38.")]
				public enum ToolbarSeparatorDesign
				{
					/// <summary>
					/// 100% height Separator before and after specific controls
					/// </summary>
					FullHeight,
					/// <summary>
					/// Standard Separator between controls
					/// </summary>
					Standard,
				}
				/// <summary>
				/// Enumeration of possible HorizontalDivider height settings.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.HorizontalDividerHeight")]
				[Obsolete("Deprecated since 1.38.")]
				public enum HorizontalDividerHeight
				{
					/// <summary>
					/// Divider gets a large top and bottom margin.
					/// </summary>
					Large,
					/// <summary>
					/// Divider gets a medium top and bottom margin.
					/// </summary>
					Medium,
					/// <summary>
					/// Divider gets no top and bottom margin.
					/// </summary>
					Ruleheight,
					/// <summary>
					/// Divider gets a small top and bottom margin.
					/// </summary>
					Small,
				}
				/// <summary>
				/// Marker interface for common controls which are suitable for use within a FormattedTextView.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.FormattedTextViewControl")]
				[Obsolete("Deprecated since 1.38.")]
				public partial interface FormattedTextViewControl
				{
				}
				/// <summary>
				/// Possible values for the visualization of float values in the RatingIndicator Control.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.RatingIndicatorVisualMode")]
				[Obsolete("Deprecated since 1.38.")]
				public enum RatingIndicatorVisualMode
				{
					/// <summary>
					/// Values are not rounded.
					/// </summary>
					Continuous,
					/// <summary>
					/// Values are rounded to the nearest integer value (e.g. 1.7 -> 2).
					/// </summary>
					Full,
					/// <summary>
					/// Values are rounded to the nearest half value (e.g. 1.7 -> 1.5).
					/// </summary>
					Half,
				}
			}
		}
	}
}
