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
			/// <summary>
			/// The SAPUI5 Core Runtime.
			/// 
			/// Contains the UI5 jQuery plugins (jQuery.sap.*), the Core and all its components, base classes for Controls, Components and the Model View Controller classes.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.ui.core")]
			public static partial class core
			{
				#region Fields

				#endregion

				#region Methods

				/// <summary>
				/// Applies the support for custom style classes on the prototype of a <code>sap.ui.core.Element</code>.
				/// 
				/// All controls (subclasses of <code>sap.ui.core.Control</code>) provide the support custom style classes. The control API provides functions to the application which allow it to add, remove or change style classes for the control. In general, this option is not available for elements because elements do not necessarily have a representation in the DOM.
				/// 
				/// This function can be used by a control developer to explicitly enrich the API of his/her element implementation with the API functions for the custom style class support. It must be called on the prototype of the element.
				/// 
				/// <b>Usage Example:</b> <pre>
				/// sap.ui.define(['sap/ui/core/Element', 'sap/ui/core/CustomStyleClassSupport'], function(Element, CustomStyleClassSupport) {
				///    "use strict";
				///    var MyElement = Element.extend("my.MyElement", {
				///       metadata : {
				///          //...
				///       }
				///       //...
				///    });
				/// 
				///    CustomStyleClassSupport.apply(MyElement.prototype);
				/// 
				///    return MyElement;
				/// }, true);
				/// </pre>
				/// 
				/// Furthermore, the function <code>oRenderManager.writeClasses(oElement);</code> ({@link sap.ui.core.RenderManager#writeClasses}) must be called within the renderer of the control to which the element belongs, when writing the root tag of the element. This ensures the classes are written to the HTML.
				/// 
				/// This function adds the following functions to the elements prototype: <ul> <li><code>addStyleClass</code>: {@link sap.ui.core.Control#addStyleClass}</li> <li><code>removeStyleClass</code>: {@link sap.ui.core.Control#removeStyleClass}</li> <li><code>toggleStyleClass</code>: {@link sap.ui.core.Control#toggleStyleClass}</li> <li><code>hasStyleClass</code>: {@link sap.ui.core.Control#hasStyleClass}</li> </ul> In addition the clone function of the element is extended to ensure that the custom style classes are also available on the cloned element.
				/// 
				/// <b>Note:</b> This function can only be used <i>within</i> control development. An application cannot add style class support on existing elements by calling this function.
				/// </summary>
				public extern static void CustomStyleClassSupport();

				#endregion

				/// <summary>
				/// Marker interface for controls which are suitable for use as label.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.core.Label")]
				public partial interface Label
				{
				}
				/// <summary>
				/// Font design for texts
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.core.Design")]
				public enum Design
				{
					/// <summary>
					/// Mono space font
					/// </summary>
					Monospace,
					/// <summary>
					/// Standard font
					/// </summary>
					Standard,
				}
				/// <summary>
				/// State of the Input Method Editor (IME) for the control.
				/// 
				/// Depending on its value, it allows users to enter and edit for example Chinese characters.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.core.ImeMode")]
				public enum ImeMode
				{
					/// <summary>
					/// IME is used for entering characters.
					/// </summary>
					Active,
					/// <summary>
					/// The value is automatically computed by the user agent.
					/// </summary>
					Auto,
					/// <summary>
					/// IME is disabled.
					/// </summary>
					Disabled,
					/// <summary>
					/// IME is not used for entering characters.
					/// </summary>
					Inactive,
				}
				/// <summary>
				/// Marker interface for toolbar controls.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.core.Toolbar")]
				public partial interface Toolbar
				{
				}
				[External]
				[Namespace(false)]
				[Name("sap.ui.core.IDScope")]
				public partial interface IDScope
				{
				}
				/// <summary>
				/// Configuration options for the colors of a progress bar
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.core.BarColor")]
				public enum BarColor
				{
					/// <summary>
					/// Color: yellow (#faf2b0)
					/// </summary>
					CRITICAL,
					/// <summary>
					/// Color: red (#ff9a90)
					/// </summary>
					NEGATIVE,
					/// <summary>
					/// Color: blue (#b8d0e8)
					/// </summary>
					NEUTRAL,
					/// <summary>
					/// Color: green (#b5e7a8)
					/// </summary>
					POSITIVE,
				}
				/// <summary>
				/// Priorities for general use.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.core.Priority")]
				public enum Priority
				{
					/// <summary>
					/// High priority
					/// </summary>
					High,
					/// <summary>
					/// Low priority
					/// </summary>
					Low,
					/// <summary>
					/// Medium priority
					/// </summary>
					Medium,
					/// <summary>
					/// Default, none priority
					/// </summary>
					None,
				}
				/// <summary>
				/// Configuration options for text wrapping.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.core.Wrapping")]
				public enum Wrapping
				{
					/// <summary>
					/// Inserts actual line breaks in the text at the wrap point.
					/// </summary>
					Hard,
					/// <summary>
					/// The standard browser behavior is considered for wrapping.
					/// </summary>
					None,
					/// <summary>
					/// Wrapping shall not be allowed.
					/// </summary>
					Off,
					/// <summary>
					/// The text is actually on the same line but displayed within several lines.
					/// </summary>
					Soft,
				}
				/// <summary>
				/// Semantic Colors of an icon.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.core.IconColor")]
				public enum IconColor
				{
					/// <summary>
					/// Critical color
					/// </summary>
					Critical,
					/// <summary>
					/// Default color (brand color)
					/// </summary>
					Default,
					/// <summary>
					/// Negative color
					/// </summary>
					Negative,
					/// <summary>
					/// Neutral color.
					/// </summary>
					Neutral,
					/// <summary>
					/// Positive color
					/// </summary>
					Positive,
				}
				/// <summary>
				/// Defines the different possible states of an element that can be open or closed and does not only toggle between these states, but also spends some time in between (e.g. because of an animation).
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.core.OpenState")]
				public enum OpenState
				{
					/// <summary>
					/// Closed and currently not changing states.
					/// </summary>
					CLOSED,
					/// <summary>
					/// Still open, but in the process of going to the CLOSED state.
					/// </summary>
					CLOSING,
					/// <summary>
					/// Open and currently not changing states.
					/// </summary>
					OPEN,
					/// <summary>
					/// Already left the CLOSED state, is not OPEN yet, but in the process of getting OPEN.
					/// </summary>
					OPENING,
				}
				/// <summary>
				/// Defines the possible values for horizontal and vertical scrolling behavior.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.core.Scrolling")]
				public enum Scrolling
				{
					/// <summary>
					/// A scroll bar is shown if the content requires more space than the given space (rectangle) provides.
					/// </summary>
					Auto,
					/// <summary>
					/// No scroll bar is shown, and the content stays in the given rectangle.
					/// </summary>
					Hidden,
					/// <summary>
					/// No scroll bar provided even if the content is larger than the available space.
					/// </summary>
					None,
					/// <summary>
					/// A scroll bar is always shown even if the space is large enough for the current content.
					/// </summary>
					Scroll,
				}
				/// <summary>
				/// Configuration options for text alignments.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.core.TextAlign")]
				public enum TextAlign
				{
					/// <summary>
					/// Locale-specific positioning at the beginning of the line.
					/// </summary>
					Begin,
					/// <summary>
					/// Centered text alignment.
					/// </summary>
					Center,
					/// <summary>
					/// Locale-specific positioning at the end of the line.
					/// </summary>
					End,
					/// <summary>
					/// Sets no text align, so the browser default is used.
					/// </summary>
					Initial,
					/// <summary>
					/// Hard option for left alignment.
					/// </summary>
					Left,
					/// <summary>
					/// Hard option for right alignment.
					/// </summary>
					Right,
				}
				/// <summary>
				/// Level of a title.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.core.TitleLevel")]
				public enum TitleLevel
				{
					/// <summary>
					/// The level of the title is choosen by the control rendering the title.
					/// </summary>
					Auto,
					/// <summary>
					/// The Title is of level 1.
					/// </summary>
					H1,
					/// <summary>
					/// The Title is of level 2
					/// </summary>
					H2,
					/// <summary>
					/// The Title is of level 3
					/// </summary>
					H3,
					/// <summary>
					/// The Title is of level 4
					/// </summary>
					H4,
					/// <summary>
					/// The Title is of level 5
					/// </summary>
					H5,
					/// <summary>
					/// The Title is of level 6
					/// </summary>
					H6,
				}
				/// <summary>
				/// Marker for the correctness of the current value.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.core.ValueState")]
				public enum ValueState
				{
					/// <summary>
					/// State is not valid.
					/// </summary>
					Error,
					/// <summary>
					/// State is not specified.
					/// </summary>
					None,
					/// <summary>
					/// State is valid.
					/// </summary>
					Success,
					/// <summary>
					/// State is valid but with a warning.
					/// </summary>
					Warning,
				}
				/// <summary>
				/// Interface for the controls which are suitable to shrink.
				/// 
				/// This means the control should still look fine when it gets smaller than its normal size, e.g. Text controls which can show ellipsis in case of shrink.
				/// 
				/// Note: This marker interface can be implemented by controls to give a hint to the container. The control itself does not need to implement anything. A parent control that respects this interface will apply the "flex-shrink" as a CSS property which determines how much the item will shrink relative to the rest of the items in the container when negative free space is distributed.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.core.IShrinkable")]
				public partial interface IShrinkable
				{
				}
				/// <summary>
				/// Defines the different message types of a message
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.core.MessageType")]
				public enum MessageType
				{
					/// <summary>
					/// Message is an error
					/// </summary>
					Error,
					/// <summary>
					/// Message should be just an information
					/// </summary>
					Information,
					/// <summary>
					/// Message has no specific level
					/// </summary>
					None,
					/// <summary>
					/// Message is a success message
					/// </summary>
					Success,
					/// <summary>
					/// Message is a warning
					/// </summary>
					Warning,
				}
				/// <summary>
				/// Orientation of a UI element
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.core.Orientation")]
				public enum Orientation
				{
					/// <summary>
					/// Arrange Horizontally
					/// </summary>
					Horizontal,
					/// <summary>
					/// Arrange Vertically
					/// </summary>
					Vertical,
				}
				/// <summary>
				/// The types of Calendar
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.core.CalendarType")]
				public enum CalendarType
				{
					/// <summary>
					/// The Gregorian calendar
					/// </summary>
					Gregorian,
					/// <summary>
					/// The Islamic calendar
					/// </summary>
					Islamic,
					/// <summary>
					/// The Japanese emperor calendar
					/// </summary>
					Japanese,
					/// <summary>
					/// The Persian Jalali calendar
					/// </summary>
					Persian,
				}
				/// <summary>
				/// Marker interface for controls that can serve as a context menu. Implementation of this interface should implement <li><code>openAsContextMenu</code></li> method.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.core.IContextMenu")]
				public partial interface IContextMenu
				{
				}
				/// <summary>
				/// Marker interface for controls that can be used as content of <code>sap.ui.layout.form.Form</code> or <code>sap.ui.layout.form.SimpleForm</code>.
				/// 
				/// If the control's width must not be adjusted by the <code>Form</code> control to meet the cell's width, the control must implement the <code>getFormDoNotAdjustWidth</code> function and return <code>true</code>.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.core.IFormContent")]
				public partial interface IFormContent
				{
					#region Methods

					#endregion

				}
				/// <summary>
				/// Configuration options for the direction of texts.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.core.TextDirection")]
				public enum TextDirection
				{
					/// <summary>
					/// Inherits the direction from its parent control/container.
					/// </summary>
					Inherit,
					/// <summary>
					/// Specifies left-to-right text direction.
					/// </summary>
					LTR,
					/// <summary>
					/// Specifies right-to-left text direction.
					/// </summary>
					RTL,
				}
				/// <summary>
				/// Configuration options for vertical alignments, for example of a layout cell content within the borders.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.core.VerticalAlign")]
				public enum VerticalAlign
				{
					/// <summary>
					/// Content is aligned at the bottom.
					/// </summary>
					Bottom,
					/// <summary>
					/// Content respect the parent's vertical alignment.
					/// </summary>
					Inherit,
					/// <summary>
					/// Content is centered vertically .
					/// </summary>
					Middle,
					/// <summary>
					/// Content is aligned at the top.
					/// </summary>
					Top,
				}
				/// <summary>
				/// Defines the accessible roles for ARIA support. This enumeration is used with the AccessibleRole control property. For more information, goto "Roles for Accessible Rich Internet Applications (WAI-ARIA Roles)" at the www.w3.org homepage.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.core.AccessibleRole")]
				public enum AccessibleRole
				{
					/// <summary>
					/// A message with an alert or error information.
					/// </summary>
					Alert,
					/// <summary>
					/// A separate window with an alert or error information.
					/// </summary>
					AlertDialog,
					/// <summary>
					/// A software unit executing a set of tasks for the user.
					/// </summary>
					Application,
					/// <summary>
					/// Usually defined as the advertisement at the top of a web page. The banner content typically contains the site or company logo, or other key advertisements.
					/// </summary>
					Banner,
					/// <summary>
					/// Allows user-triggered actions.
					/// </summary>
					Button,
					/// <summary>
					/// A control that has three possible values: true, false, mixed.
					/// </summary>
					Checkbox,
					/// <summary>
					/// A table cell containing header information for a column.
					/// </summary>
					ColumnHeader,
					/// <summary>
					/// Allows selecting an item from a list, or to enter data directly in the input field.
					/// </summary>
					Combobox,
					/// <summary>
					/// Information about the content on the page. Examples are footnotes, copyrights, or links to privacy statements.
					/// </summary>
					ContentInfo,
					/// <summary>
					/// The content of the associated element represents a definition. If there is a definition element within the content, this one represents the term being defined.
					/// </summary>
					Definition,
					/// <summary>
					/// Descriptive content for a page element.
					/// </summary>
					Description,
					/// <summary>
					/// A small window that is designed to interrupt the current application processing in order to inform the user and to get some response.
					/// </summary>
					Dialog,
					/// <summary>
					/// A list of references to members of a single group.
					/// </summary>
					Directory,
					/// <summary>
					/// Content that contains related information, such as a book.
					/// </summary>
					Document,
					/// <summary>
					/// Contains cells of tabular data arranged in rows and columns, for example in a table.
					/// </summary>
					Grid,
					/// <summary>
					/// A table cell in a grid where the cells can be active, editable, and selectable. Cells may have functional relationships to controls, for example.
					/// </summary>
					GridCell,
					/// <summary>
					/// A section of user interface objects.
					/// </summary>
					Group,
					/// <summary>
					/// A heading for a section of the page.
					/// </summary>
					Heading,
					/// <summary>
					/// A container for a collection of elements that form an image.
					/// </summary>
					Img,
					/// <summary>
					/// An interactive reference to a resource.
					/// </summary>
					Link,
					/// <summary>
					/// A container for non-interactive list items which are the children of the list.
					/// </summary>
					List,
					/// <summary>
					/// A widget that allows the user to select one or more items from a list. The items within the list are static and can contain images.
					/// </summary>
					Listbox,
					/// <summary>
					/// A single item in a list.
					/// </summary>
					ListItem,
					/// <summary>
					/// An area where new information is added, or old information disappears. Information types are chat logs, messaging, or error logs, for example. The log contains a sequence: New information is always added to the end of the log.
					/// </summary>
					Log,
					/// <summary>
					/// Defines the main content of a document.
					/// </summary>
					Main,
					/// <summary>
					/// Is used to scroll text across the page.
					/// </summary>
					Marquee,
					/// <summary>
					/// Offers a list of choices to the user.
					/// </summary>
					Menu,
					/// <summary>
					/// A container for menu items where each item may activate a submenu.
					/// </summary>
					Menubar,
					/// <summary>
					/// A child in a menu.
					/// </summary>
					MenuItem,
					/// <summary>
					/// A checkable menu item (tri-state).
					/// </summary>
					MenuItemCheckbox,
					/// <summary>
					/// A menu item which is part of a group of menuitemradio roles.
					/// </summary>
					MenuItemRadio,
					/// <summary>
					/// A collection of links suitable for use when navigating the document or related documents.
					/// </summary>
					Navigation,
					/// <summary>
					/// The content is parenthetic or ancillary to the main content of the resource.
					/// </summary>
					Note,
					/// <summary>
					/// A selectable item in a list represented by a select.
					/// </summary>
					Option,
					/// <summary>
					/// An element whose role is presentational does not need to be mapped to the accessibility API.
					/// </summary>
					Presentation,
					/// <summary>
					/// Shows the execution progress in applications providing functions that take a long time.
					/// </summary>
					ProgressBar,
					/// <summary>
					/// An option in single-select list. Only one radio control in a radiogroup can be selected at the same time.
					/// </summary>
					Radio,
					/// <summary>
					/// A group of radio controls.
					/// </summary>
					RadioGroup,
					/// <summary>
					/// A large section on the web page.
					/// </summary>
					Region,
					/// <summary>
					/// A row of table cells.
					/// </summary>
					Row,
					/// <summary>
					/// A table cell containing header information for a row.
					/// </summary>
					RowHeader,
					/// <summary>
					/// A search section of a web document. In many cases, this is a form used to submit search requests about the site, or a more general Internet wide search service.
					/// </summary>
					Search,
					/// <summary>
					/// A unique section of the document. In the case of a portal, this may include time display, weather forecast, or stock price.
					/// </summary>
					Secondary,
					/// <summary>
					/// Indicates that the element contains content that is related to the main content of the page.
					/// </summary>
					SeeAlso,
					/// <summary>
					/// A line or bar that separates sections of content.
					/// </summary>
					Separator,
					/// <summary>
					/// A user input where the user selects an input in a given range. This form of range expects an analogous keyboard interface.
					/// </summary>
					Slider,
					/// <summary>
					/// Allows users to select a value from a list of given entries where exactly one value is displayed at runtime, and the other ones can be displayed by scrolling using the arrow up and arrow down key.
					/// </summary>
					SpinButton,
					/// <summary>
					/// A container for processing advisory information.
					/// </summary>
					Status,
					/// <summary>
					/// A header for a tab panel.
					/// </summary>
					Tab,
					/// <summary>
					/// A list of tabs which are references to tab panels.
					/// </summary>
					Tablist,
					/// <summary>
					/// A container for the resources associated with a tab.
					/// </summary>
					Tabpanel,
					/// <summary>
					/// Inputs that allow free-form text as their value.
					/// </summary>
					Textbox,
					/// <summary>
					/// A numerical counter which indicates an amount of elapsed time from a start point, or of the time remaining until a certain end point.
					/// </summary>
					Timer,
					/// <summary>
					/// A collection of commonly used functions represented in compact visual form.
					/// </summary>
					Toolbar,
					/// <summary>
					/// A popup that displays a description for an element when the user passes over or rests on that element. Supplement to the normal tooltip processing of the user agent.
					/// </summary>
					Tooltip,
					/// <summary>
					/// A form of a list (tree) having groups (subtrees) inside groups (subtrees), where the sub trees can be collapsed and expanded.
					/// </summary>
					Tree,
					/// <summary>
					/// A grid whose rows are expandable and collapsable in the same manner as the ones of trees.
					/// </summary>
					TreeGrid,
					/// <summary>
					/// A tree node
					/// </summary>
					TreeItem,
				}
				/// <summary>
				/// Marker interface for controls that are not rendered "embedded" into other controls but need to be opened/closed.
				/// 
				/// Such controls are handled differently during rendering.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.core.PopupInterface")]
				public partial interface PopupInterface
				{
				}
				/// <summary>
				/// Configuration options for horizontal alignments of controls
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.core.HorizontalAlign")]
				public enum HorizontalAlign
				{
					/// <summary>
					/// Locale-specific positioning at the beginning of the line
					/// </summary>
					Begin,
					/// <summary>
					/// Centered alignment of text
					/// </summary>
					Center,
					/// <summary>
					/// Locale-specific positioning at the end of the line
					/// </summary>
					End,
					/// <summary>
					/// Hard option for left alignment
					/// </summary>
					Left,
					/// <summary>
					/// Hard option for right alignment
					/// </summary>
					Right,
				}
				/// <summary>
				/// Actions are: Click on track, button, drag of thumb, or mouse wheel click
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.core.ScrollBarAction")]
				public enum ScrollBarAction
				{
					/// <summary>
					/// Scrolling done by dragging the scroll bar's paint thumb
					/// </summary>
					Drag,
					/// <summary>
					/// Scrolling done by mouse wheel
					/// </summary>
					MouseWheel,
					/// <summary>
					/// Range scrolling caused by clicking track area or using page up or page down key.
					/// </summary>
					Page,
					/// <summary>
					/// Single step scrolling caused by clicking an arrow button or arrow key.
					/// </summary>
					Step,
				}
				/// <summary>
				/// Configuration options for the BusyIndicator size
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.core.BusyIndicatorSize")]
				public enum BusyIndicatorSize
				{
					/// <summary>
					/// Type: automatic size detection
					/// </summary>
					Auto,
					/// <summary>
					/// Type: Large size
					/// </summary>
					Large,
					/// <summary>
					/// Type: Medium size
					/// </summary>
					Medium,
					/// <summary>
					/// Type: small size
					/// </summary>
					Small,
				}
				/// <summary>
				/// Enumeration for different lifecycle behaviors of Components created by the ComponentContainer.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.core.ComponentLifecycle")]
				public enum ComponentLifecycle
				{
					/// <summary>
					/// Application managed lifecycle means that the Application takes care to destroy the Components associated with the ComponentContainer.
					/// </summary>
					Application,
					/// <summary>
					/// Container managed lifecycle means that the ComponentContainer takes care to destroy the Components associated with the ComponentContainer once the ComponentContainer is destroyed or a new Component is associated.
					/// </summary>
					Container,
					/// <summary>
					/// Legacy lifecycle means that the ComponentContainer takes care to destroy the Component which is associated with the ComponentContainer once the ComponentContainer is destroyed but not when a new Component is associated.
					/// </summary>
					Legacy,
				}
				/// <summary>
				/// Defines the accessible landmark roles for ARIA support. This enumeration is used with the AccessibleRole control property. For more information, goto "Roles for Accessible Rich Internet Applications (WAI-ARIA Roles)" at the www.w3.org homepage.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.core.AccessibleLandmarkRole")]
				public enum AccessibleLandmarkRole
				{
					/// <summary>
					/// Represents the ARIA role <code>banner</code>.
					/// 
					/// A banner usually appears at the top of the page and typically spans the full width.
					/// </summary>
					Banner,
					/// <summary>
					/// Represents the ARIA role <code>complementary</code>.
					/// 
					/// A section of the page, designed to be complementary to the main content at a similar level in the DOM hierarchy.
					/// </summary>
					Complementary,
					/// <summary>
					/// Represents the ARIA role <code>main</code>.
					/// 
					/// The main content of a page.
					/// </summary>
					Main,
					/// <summary>
					/// Represents the ARIA role <code>navigation</code>.
					/// 
					/// A region that contains a collection of items and objects that, as a whole, combine to create a navigation facility.
					/// </summary>
					Navigation,
					/// <summary>
					/// No explicit role is applicable.
					/// 
					/// The interpretation of this value depends on the control / element which defines a property with this type. Normally this value means that no accessible landmark should be written.
					/// </summary>
					None,
					/// <summary>
					/// Represents the ARIA role <code>region</code>.
					/// 
					/// A section of a page, that is important enough to be included in a page summary or table of contents.
					/// </summary>
					Region,
					/// <summary>
					/// Represents the ARIA role <code>search</code>.
					/// 
					/// A region that contains a collection of items and objects that, as a whole, combine to create a search facility.
					/// </summary>
					Search,
				}
			}
		}
	}
}
