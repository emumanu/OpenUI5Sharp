using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace OpenUI5Sharp
{
	public static partial class sap
	{
		public static partial class m
		{
			/// <summary>
			/// Displays additional information for an object in a compact way.
			/// 
			/// <h3>Overview</h3> The popover displays additional information for an object in a compact way and without leaving the page. The popover can contain various UI elements such as fields, tables, images, and charts. It can also include actions in the footer. <h3>Structure</h3> The popover has three main areas: <ul> <li>Header (optional) - with a back button and a title</li> <li>Content - holds all the controls</li> <li>Footer (optional) - with additional action buttons</li> </ul> <h4>Guidelines</h4> <ul> <li>Do not overlap popovers.</li> <li>You can determine the {@link sap.m.PlacementType placement} of the popover relative to the control that opens it.</li> <li>Ensure that the content has a basic design and shows only the most important information.</li> </ul> <h3>Usage</h3> <h4>When to use:</h4> <ul> <li>You need to define your own structure of controls within the popover.</li> </ul> <h4>When not to use:</h4> <ul> <li>The {@link sap.m.QuickView QuickView} is more appropriate for your use case.</li> </ul> <h3>Responsive Behavior</h3> The popover is closed when the user clicks or taps outside the popover or selects an action within the popover. You can prevent this with the <code>modal</code> property. The popover can be resized when the <code>resizable</code> property is enabled.
			/// 
			/// <ul> <li>{@link sap.m.Popover} is <u>not</u> responsive on mobile devices - it will always be rendered as a popover and you have to take care of its size and position.</li> <li>{@link sap.m.ResponsivePopover} is adaptive and responsive. It renders as a dialog with a close button in the header on phones, and as a popover on tablets.</li> </ul>
			/// </summary>
			[External]
			[Namespace(false)]
			public partial class Popover : sap.ui.core.Control, sap.ui.core.PopupInterface
			{
				#region Settings

				/// <summary>
				/// Settings class to create the object
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class Settings : sap.ui.core.Control.Settings
				{
					/// <summary>
					/// This is the information about on which side will the popover be placed at. Possible values are sap.m.PlacementType.Left, sap.m.PlacementType.Right, sap.m.PlacementType.Top, sap.m.PlacementType.Bottom, sap.m.PlacementType.Horizontal, sap.m.PlacementType.HorizontalPreferredLeft, sap.m.PlacementType.HorizontalPreferredRight, sap.m.PlacementType.Vertical, sap.m.PlacementType.VerticalPreferredTop, sap.m.PlacementType.VerticalPreferredBottom, sap.m.PlacementType.Auto. The default value is sap.m.PlacementType.Right. Setting this property while popover is open won't cause any rerendering of the popover, but it will take effect when it's opened again.
					/// </summary>
					public Union<sap.m.PlacementType, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> placement;

					/// <summary>
					/// If a header should be shown at the top of the popover.
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> showHeader;

					/// <summary>
					/// Title text appears in the header. This property will be ignored when showHeader is set to false.
					/// </summary>
					public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> title;

					/// <summary>
					/// If the popover will not be closed when tapping outside the popover. It also blocks any interaction with the background. The default value is false.
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> modal;

					/// <summary>
					/// The offset for the popover placement in the x axis. It's with unit pixel.
					/// </summary>
					public Union<int, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> offsetX;

					/// <summary>
					/// The offset for the popover placement in the y axis. It's with unit pixel.
					/// </summary>
					public Union<int, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> offsetY;

					/// <summary>
					/// Whether Popover arrow should be visible
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> showArrow;

					/// <summary>
					/// Set the width of the content area inside Popover. When controls which adapt their size to the parent control are added directly into Popover, for example sap.m.Page control, a size needs to be specified to the content area of the Popover. Otherwise, Popover control isn't able to display the content in the right way. This values isn't necessary for controls added to Popover directly which can decide their size by themselves, for exmaple sap.m.List, sap.m.Image etc., only needed for controls that adapt their size to the parent control.
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> contentWidth;

					/// <summary>
					/// Sets the minimum width of the content area inside popover.
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> contentMinWidth;

					/// <summary>
					/// Set the height of the content area inside Popover. When controls which adapt their size to the parent control are added directly into Popover, for example sap.m.Page control, a size needs to be specified to the content area of the Popover. Otherwise, Popover control isn't able to display the content in the right way. This values isn't necessary for controls added to Popover directly which can decide their size by themselves, for exmaple sap.m.List, sap.m.Image etc., only needed for controls that adapt their size to the parent control.
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> contentHeight;

					/// <summary>
					/// This property is deprecated. Please use properties verticalScrolling and horizontalScrolling instead. If you still use this property it will be mapped on the new properties verticalScrolling and horizontalScrolling.
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> enableScrolling;

					/// <summary>
					/// This property indicates if user can scroll vertically inside popover when the content is bigger than the content area. However, when scrollable control (sap.m.ScrollContainer, sap.m.Page) is in the popover, this property needs to be set to false to disable the scrolling in popover in order to make the scrolling in the child control work properly. Popover detects if there's sap.m.NavContainer, sap.m.Page, or sap.m.ScrollContainer as direct child added to Popover. If there is, Popover will turn off scrolling by setting this property to false automatically ignoring the existing value of this property.
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> verticalScrolling;

					/// <summary>
					/// This property indicates if user can scroll horizontally inside popover when the content is bigger than the content area. However, when scrollable control (sap.m.ScrollContainer, sap.m.Page) is in the popover, this property needs to be set to false to disable the scrolling in popover in order to make the scrolling in the child control work properly. Popover detects if there's sap.m.NavContainer, sap.m.Page, or sap.m.ScrollContainer as direct child added to Popover. If there is, Popover will turn off scrolling by setting this property to false automatically ignoring the existing value of this property.
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> horizontalScrolling;

					/// <summary>
					/// Whether bouncing is enabled.
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> bounce;

					/// <summary>
					/// Whether resize option is enabled.
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> resizable;

					/// <summary>
					/// The content inside the popover.
					/// </summary>
					public Union<sap.ui.core.Control[], string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> content;

					/// <summary>
					/// Any control that needed to be displayed in the header area. When this is set, the showHeader property is ignored, and only this customHeader is shown on the top of popover.
					/// </summary>
					public Union<sap.ui.core.Control, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> customHeader;

					/// <summary>
					/// When subHeader is assigned to Popover, it's rendered directly after the main header if there is, or at the beginning of Popover when there's no main header. SubHeader is out of the content area and won't be scrolled when content's size is bigger than the content area's size.
					/// </summary>
					public Union<sap.ui.core.Control, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> subHeader;

					/// <summary>
					/// This is optional footer which is shown on the bottom of the popover.
					/// </summary>
					public Union<sap.ui.core.Control, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> footer;

					/// <summary>
					/// BeginButton is shown at the left side (right side in RTL mode) inside the header. When showHeader is set to false, the property is ignored.
					/// </summary>
					public Union<sap.ui.core.Control, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> beginButton;

					/// <summary>
					/// EndButton is always shown at the right side (left side in RTL mode) inside the header. When showHeader is set to false, the property is ignored.
					/// </summary>
					public Union<sap.ui.core.Control, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> endButton;

					/// <summary>
					/// LeftButton is shown at the left edge of the bar in iOS, and at the right side of the bar for the other platforms. Please set this to null if you want to remove the left button from the bar. And the button is only removed from the bar, not destroyed. When showHeader is set to false, this property will be ignored.
					/// </summary>
					public Union<sap.m.Button, sap.ui.core.ID, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> leftButton;

					/// <summary>
					/// RightButton is always shown at the right edge of the bar. Please set this to null if you want to remove the right button from the bar. And the button is only removed from the bar, not destroyed. When showHeader is set to false, this property will be ignored.
					/// </summary>
					public Union<sap.m.Button, sap.ui.core.ID, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> rightButton;

					/// <summary>
					/// Focus is set to the popover in the sequence of leftButton and rightButton when available. But if some other control neends to get the focus other than one of those two buttons, set the initialFocus with the control which should be focused on.
					/// </summary>
					public Union<sap.ui.core.Control, sap.ui.core.ID, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> initialFocus;

					/// <summary>
					/// Association to controls / ids which label this control (see WAI-ARIA attribute aria-labelledby).
					/// </summary>
					public Union<sap.ui.core.Control, sap.ui.core.ID[], string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> ariaLabelledBy;

					/// <summary>
					/// Association to controls / ids which describe this control (see WAI-ARIA attribute aria-describedby).
					/// </summary>
					public Union<sap.ui.core.Control, sap.ui.core.ID[], string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> ariaDescribedBy;

					/// <summary>
					/// This event will be fired after the popover is opened.
					/// </summary>
					public sap.m.AfterOpenCloseBeforeDelegate afterOpen;

					/// <summary>
					/// This event will be fired after the popover is closed.
					/// </summary>
					public sap.m.AfterOpenCloseBeforeDelegate afterClose;

					/// <summary>
					/// This event will be fired before the popover is opened.
					/// </summary>
					public sap.m.AfterOpenCloseBeforeDelegate beforeOpen;

					/// <summary>
					/// This event will be fired before the popover is closed.
					/// </summary>
					public sap.m.AfterOpenCloseBeforeDelegate beforeClose;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new Popover.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern Popover(string sId, sap.m.Popover.Settings mSettings);

				/// <summary>
				/// Constructor for a new Popover.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern Popover(string sId);

				/// <summary>
				/// Constructor for a new Popover.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern Popover();

				/// <summary>
				/// Constructor for a new Popover.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern Popover(sap.m.Popover.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property placement

				/// <summary>
				/// Gets current value of property {@link #getPlacement placement}.
				/// 
				/// This is the information about on which side will the popover be placed at. Possible values are sap.m.PlacementType.Left, sap.m.PlacementType.Right, sap.m.PlacementType.Top, sap.m.PlacementType.Bottom, sap.m.PlacementType.Horizontal, sap.m.PlacementType.HorizontalPreferredLeft, sap.m.PlacementType.HorizontalPreferredRight, sap.m.PlacementType.Vertical, sap.m.PlacementType.VerticalPreferredTop, sap.m.PlacementType.VerticalPreferredBottom, sap.m.PlacementType.Auto. The default value is sap.m.PlacementType.Right. Setting this property while popover is open won't cause any rerendering of the popover, but it will take effect when it's opened again.
				/// 
				/// Default value is <code>Right</code>.
				/// </summary>
				/// <returns>Value of property <code>placement</code></returns>
				public extern virtual sap.m.PlacementType getPlacement();

				/// <summary>
				/// Set the placement of the Popover.
				/// </summary>
				/// <param name="sPlacement">The position of the Popover</param>
				/// <returns>Reference to the control instance for chaining</returns>
				public extern virtual sap.m.Popover setPlacement(sap.m.PlacementType sPlacement);

				#endregion

				#region Methods for Property showHeader

				/// <summary>
				/// Gets current value of property {@link #getShowHeader showHeader}.
				/// 
				/// If a header should be shown at the top of the popover.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>showHeader</code></returns>
				public extern virtual bool getShowHeader();

				/// <summary>
				/// Sets a new value for property {@link #getShowHeader showHeader}.
				/// 
				/// If a header should be shown at the top of the popover.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bShowHeader">New value for property <code>showHeader</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Popover setShowHeader(bool bShowHeader);

				#endregion

				#region Methods for Property title

				/// <summary>
				/// Gets current value of property {@link #getTitle title}.
				/// 
				/// Title text appears in the header. This property will be ignored when showHeader is set to false.
				/// </summary>
				/// <returns>Value of property <code>title</code></returns>
				public extern virtual string getTitle();

				/// <summary>
				/// The setter of the title property.
				/// 
				/// If you want to show a header in the popover, don't forget to set the {@link #setShowHeader showHeader} property to true.
				/// </summary>
				/// <param name="sTitle">The title to be set</param>
				/// <returns>Reference to the control instance for chaining</returns>
				public extern virtual sap.m.Popover setTitle(string sTitle);

				#endregion

				#region Methods for Property modal

				/// <summary>
				/// Gets current value of property {@link #getModal modal}.
				/// 
				/// If the popover will not be closed when tapping outside the popover. It also blocks any interaction with the background. The default value is false.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>modal</code></returns>
				public extern virtual bool getModal();

				/// <summary>
				/// Setter for property <code>modal</code>. This overwrites the default setter of the property <code>modal</code> to avoid rerendering the whole popover control.
				/// 
				/// Default value is <code>false</code>
				/// </summary>
				/// <param name="bModal">New value for property <code>modal</code>.</param>
				/// <param name="sModalCSSClass">A CSS class (or space-separated list of classes) that should be added to the block layer.</param>
				/// <returns>Reference to the control instance for chaining</returns>
				public extern virtual sap.m.Popover setModal(bool bModal, string sModalCSSClass);

				/// <summary>
				/// Setter for property <code>modal</code>. This overwrites the default setter of the property <code>modal</code> to avoid rerendering the whole popover control.
				/// 
				/// Default value is <code>false</code>
				/// </summary>
				/// <param name="bModal">New value for property <code>modal</code>.</param>
				/// <returns>Reference to the control instance for chaining</returns>
				public extern virtual sap.m.Popover setModal(bool bModal);

				#endregion

				#region Methods for Property offsetX

				/// <summary>
				/// Gets current value of property {@link #getOffsetX offsetX}.
				/// 
				/// The offset for the popover placement in the x axis. It's with unit pixel.
				/// 
				/// Default value is <code>0</code>.
				/// </summary>
				/// <returns>Value of property <code>offsetX</code></returns>
				public extern virtual int getOffsetX();

				/// <summary>
				/// Sets a new value for property {@link #getOffsetX offsetX}.
				/// 
				/// The offset for the popover placement in the x axis. It's with unit pixel.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>0</code>.
				/// </summary>
				/// <param name="iOffsetX">New value for property <code>offsetX</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Popover setOffsetX(int iOffsetX);

				#endregion

				#region Methods for Property offsetY

				/// <summary>
				/// Gets current value of property {@link #getOffsetY offsetY}.
				/// 
				/// The offset for the popover placement in the y axis. It's with unit pixel.
				/// 
				/// Default value is <code>0</code>.
				/// </summary>
				/// <returns>Value of property <code>offsetY</code></returns>
				public extern virtual int getOffsetY();

				/// <summary>
				/// Sets a new value for property {@link #getOffsetY offsetY}.
				/// 
				/// The offset for the popover placement in the y axis. It's with unit pixel.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>0</code>.
				/// </summary>
				/// <param name="iOffsetY">New value for property <code>offsetY</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Popover setOffsetY(int iOffsetY);

				#endregion

				#region Methods for Property showArrow

				/// <summary>
				/// Gets current value of property {@link #getShowArrow showArrow}.
				/// 
				/// Whether Popover arrow should be visible
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>showArrow</code></returns>
				public extern virtual bool getShowArrow();

				/// <summary>
				/// Sets a new value for property {@link #getShowArrow showArrow}.
				/// 
				/// Whether Popover arrow should be visible
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bShowArrow">New value for property <code>showArrow</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Popover setShowArrow(bool bShowArrow);

				#endregion

				#region Methods for Property contentWidth

				/// <summary>
				/// Gets current value of property {@link #getContentWidth contentWidth}.
				/// 
				/// Set the width of the content area inside Popover. When controls which adapt their size to the parent control are added directly into Popover, for example sap.m.Page control, a size needs to be specified to the content area of the Popover. Otherwise, Popover control isn't able to display the content in the right way. This values isn't necessary for controls added to Popover directly which can decide their size by themselves, for exmaple sap.m.List, sap.m.Image etc., only needed for controls that adapt their size to the parent control.
				/// </summary>
				/// <returns>Value of property <code>contentWidth</code></returns>
				public extern virtual sap.ui.core.CSSSize getContentWidth();

				/// <summary>
				/// Sets a new value for property {@link #getContentWidth contentWidth}.
				/// 
				/// Set the width of the content area inside Popover. When controls which adapt their size to the parent control are added directly into Popover, for example sap.m.Page control, a size needs to be specified to the content area of the Popover. Otherwise, Popover control isn't able to display the content in the right way. This values isn't necessary for controls added to Popover directly which can decide their size by themselves, for exmaple sap.m.List, sap.m.Image etc., only needed for controls that adapt their size to the parent control.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sContentWidth">New value for property <code>contentWidth</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Popover setContentWidth(sap.ui.core.CSSSize sContentWidth);

				#endregion

				#region Methods for Property contentMinWidth

				/// <summary>
				/// Gets current value of property {@link #getContentMinWidth contentMinWidth}.
				/// 
				/// Sets the minimum width of the content area inside popover.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <returns>Value of property <code>contentMinWidth</code></returns>
				public extern virtual sap.ui.core.CSSSize getContentMinWidth();

				/// <summary>
				/// Sets a new value for property {@link #getContentMinWidth contentMinWidth}.
				/// 
				/// Sets the minimum width of the content area inside popover.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <param name="sContentMinWidth">New value for property <code>contentMinWidth</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Popover setContentMinWidth(sap.ui.core.CSSSize sContentMinWidth);

				#endregion

				#region Methods for Property contentHeight

				/// <summary>
				/// Gets current value of property {@link #getContentHeight contentHeight}.
				/// 
				/// Set the height of the content area inside Popover. When controls which adapt their size to the parent control are added directly into Popover, for example sap.m.Page control, a size needs to be specified to the content area of the Popover. Otherwise, Popover control isn't able to display the content in the right way. This values isn't necessary for controls added to Popover directly which can decide their size by themselves, for exmaple sap.m.List, sap.m.Image etc., only needed for controls that adapt their size to the parent control.
				/// </summary>
				/// <returns>Value of property <code>contentHeight</code></returns>
				public extern virtual sap.ui.core.CSSSize getContentHeight();

				/// <summary>
				/// Sets a new value for property {@link #getContentHeight contentHeight}.
				/// 
				/// Set the height of the content area inside Popover. When controls which adapt their size to the parent control are added directly into Popover, for example sap.m.Page control, a size needs to be specified to the content area of the Popover. Otherwise, Popover control isn't able to display the content in the right way. This values isn't necessary for controls added to Popover directly which can decide their size by themselves, for exmaple sap.m.List, sap.m.Image etc., only needed for controls that adapt their size to the parent control.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sContentHeight">New value for property <code>contentHeight</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Popover setContentHeight(sap.ui.core.CSSSize sContentHeight);

				#endregion

				#region Methods for Property enableScrolling

				/// <summary>
				/// Gets current value of property {@link #getEnableScrolling enableScrolling}.
				/// 
				/// This property is deprecated. Please use properties verticalScrolling and horizontalScrolling instead. If you still use this property it will be mapped on the new properties verticalScrolling and horizontalScrolling.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				[Obsolete("Deprecated since 1.15.0. This property is deprecated. Please use properties verticalScrolling and horizontalScrolling instead. If you still use this property it will be mapped on the new properties verticalScrolling and horizontalScrolling.")]
				/// <returns>Value of property <code>enableScrolling</code></returns>
				public extern virtual bool getEnableScrolling();

				/// <summary>
				/// Sets a new value for property {@link #getEnableScrolling enableScrolling}.
				/// 
				/// This property is deprecated. Please use properties verticalScrolling and horizontalScrolling instead. If you still use this property it will be mapped on the new properties verticalScrolling and horizontalScrolling.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				[Obsolete("Deprecated since 1.15.0. This property is deprecated. Please use properties verticalScrolling and horizontalScrolling instead. If you still use this property it will be mapped on the new properties verticalScrolling and horizontalScrolling.")]
				/// <param name="bEnableScrolling">New value for property <code>enableScrolling</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Popover setEnableScrolling(bool bEnableScrolling);

				#endregion

				#region Methods for Property verticalScrolling

				/// <summary>
				/// Gets current value of property {@link #getVerticalScrolling verticalScrolling}.
				/// 
				/// This property indicates if user can scroll vertically inside popover when the content is bigger than the content area. However, when scrollable control (sap.m.ScrollContainer, sap.m.Page) is in the popover, this property needs to be set to false to disable the scrolling in popover in order to make the scrolling in the child control work properly. Popover detects if there's sap.m.NavContainer, sap.m.Page, or sap.m.ScrollContainer as direct child added to Popover. If there is, Popover will turn off scrolling by setting this property to false automatically ignoring the existing value of this property.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>verticalScrolling</code></returns>
				public extern virtual bool getVerticalScrolling();

				/// <summary>
				/// Sets a new value for property {@link #getVerticalScrolling verticalScrolling}.
				/// 
				/// This property indicates if user can scroll vertically inside popover when the content is bigger than the content area. However, when scrollable control (sap.m.ScrollContainer, sap.m.Page) is in the popover, this property needs to be set to false to disable the scrolling in popover in order to make the scrolling in the child control work properly. Popover detects if there's sap.m.NavContainer, sap.m.Page, or sap.m.ScrollContainer as direct child added to Popover. If there is, Popover will turn off scrolling by setting this property to false automatically ignoring the existing value of this property.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bVerticalScrolling">New value for property <code>verticalScrolling</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Popover setVerticalScrolling(bool bVerticalScrolling);

				#endregion

				#region Methods for Property horizontalScrolling

				/// <summary>
				/// Gets current value of property {@link #getHorizontalScrolling horizontalScrolling}.
				/// 
				/// This property indicates if user can scroll horizontally inside popover when the content is bigger than the content area. However, when scrollable control (sap.m.ScrollContainer, sap.m.Page) is in the popover, this property needs to be set to false to disable the scrolling in popover in order to make the scrolling in the child control work properly. Popover detects if there's sap.m.NavContainer, sap.m.Page, or sap.m.ScrollContainer as direct child added to Popover. If there is, Popover will turn off scrolling by setting this property to false automatically ignoring the existing value of this property.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>horizontalScrolling</code></returns>
				public extern virtual bool getHorizontalScrolling();

				/// <summary>
				/// Sets a new value for property {@link #getHorizontalScrolling horizontalScrolling}.
				/// 
				/// This property indicates if user can scroll horizontally inside popover when the content is bigger than the content area. However, when scrollable control (sap.m.ScrollContainer, sap.m.Page) is in the popover, this property needs to be set to false to disable the scrolling in popover in order to make the scrolling in the child control work properly. Popover detects if there's sap.m.NavContainer, sap.m.Page, or sap.m.ScrollContainer as direct child added to Popover. If there is, Popover will turn off scrolling by setting this property to false automatically ignoring the existing value of this property.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bHorizontalScrolling">New value for property <code>horizontalScrolling</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Popover setHorizontalScrolling(bool bHorizontalScrolling);

				#endregion

				#region Methods for Property bounce

				/// <summary>
				/// Setter for property <code>bounce</code>.
				/// 
				/// Default value is empty
				/// </summary>
				/// <param name="bBounce">New value for property <code>bounce</code></param>
				/// <returns>Reference to the control instance for chaining</returns>
				public extern virtual sap.m.Popover setBounce(bool bBounce);

				#endregion

				#region Methods for Property resizable

				/// <summary>
				/// Gets current value of property {@link #getResizable resizable}.
				/// 
				/// Whether resize option is enabled.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>resizable</code></returns>
				public extern virtual bool getResizable();

				/// <summary>
				/// Sets a new value for property {@link #getResizable resizable}.
				/// 
				/// Whether resize option is enabled.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bResizable">New value for property <code>resizable</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Popover setResizable(bool bResizable);

				#endregion

				#region Methods for Aggregation content

				/// <summary>
				/// Gets content of aggregation {@link #getContent content}.
				/// 
				/// The content inside the popover.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.Control[] getContent();

				/// <summary>
				/// Destroys all the content in the aggregation {@link #getContent content}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Popover destroyContent();

				/// <summary>
				/// Inserts a content into the aggregation {@link #getContent content}.
				/// </summary>
				/// <param name="oContent">The content to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the content should be inserted at; for a negative value of <code>iIndex</code>, the content is inserted at position 0; for a value greater than the current size of the aggregation, the content is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Popover insertContent(sap.ui.core.Control oContent, int iIndex);

				/// <summary>
				/// Adds some content to the aggregation {@link #getContent content}.
				/// </summary>
				/// <param name="oContent">The content to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Popover addContent(sap.ui.core.Control oContent);

				/// <summary>
				/// Removes a content from the aggregation {@link #getContent content}.
				/// </summary>
				/// <param name="vContent">The content to remove or its index or id</param>
				/// <returns>The removed content or <code>null</code></returns>
				public extern virtual sap.ui.core.Control removeContent(Union<int, string, sap.ui.core.Control> vContent);

				/// <summary>
				/// Checks for the provided <code>sap.ui.core.Control</code> in the aggregation {@link #getContent content}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oContent">The content whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfContent(sap.ui.core.Control oContent);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getContent content}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.ui.core.Control[] removeAllContent();

				#endregion

				#region Methods for Aggregation customHeader

				/// <summary>
				/// Gets content of aggregation {@link #getCustomHeader customHeader}.
				/// 
				/// Any control that needed to be displayed in the header area. When this is set, the showHeader property is ignored, and only this customHeader is shown on the top of popover.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.Control getCustomHeader();

				/// <summary>
				/// Destroys the customHeader in the aggregation {@link #getCustomHeader customHeader}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Popover destroyCustomHeader();

				/// <summary>
				/// Sets the aggregated {@link #getCustomHeader customHeader}.
				/// </summary>
				/// <param name="oCustomHeader">The customHeader to set</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Popover setCustomHeader(sap.ui.core.Control oCustomHeader);

				#endregion

				#region Methods for Aggregation subHeader

				/// <summary>
				/// Gets content of aggregation {@link #getSubHeader subHeader}.
				/// 
				/// When subHeader is assigned to Popover, it's rendered directly after the main header if there is, or at the beginning of Popover when there's no main header. SubHeader is out of the content area and won't be scrolled when content's size is bigger than the content area's size.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.Control getSubHeader();

				/// <summary>
				/// Destroys the subHeader in the aggregation {@link #getSubHeader subHeader}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Popover destroySubHeader();

				/// <summary>
				/// Sets the aggregated {@link #getSubHeader subHeader}.
				/// </summary>
				/// <param name="oSubHeader">The subHeader to set</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Popover setSubHeader(sap.ui.core.Control oSubHeader);

				#endregion

				#region Methods for Aggregation footer

				/// <summary>
				/// Gets content of aggregation {@link #getFooter footer}.
				/// 
				/// This is optional footer which is shown on the bottom of the popover.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.Control getFooter();

				/// <summary>
				/// Destroys the footer in the aggregation {@link #getFooter footer}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Popover destroyFooter();

				/// <summary>
				/// Sets the aggregated {@link #getFooter footer}.
				/// </summary>
				/// <param name="oFooter">The footer to set</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Popover setFooter(sap.ui.core.Control oFooter);

				#endregion

				#region Methods for Aggregation _internalHeader

				#endregion

				#region Methods for Aggregation beginButton

				/// <summary>
				/// Gets content of aggregation {@link #getBeginButton beginButton}.
				/// 
				/// BeginButton is shown at the left side (right side in RTL mode) inside the header. When showHeader is set to false, the property is ignored.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.Control getBeginButton();

				/// <summary>
				/// Destroys the beginButton in the aggregation {@link #getBeginButton beginButton}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Popover destroyBeginButton();

				/// <summary>
				/// Sets the aggregated {@link #getBeginButton beginButton}.
				/// </summary>
				/// <param name="oBeginButton">The beginButton to set</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Popover setBeginButton(sap.ui.core.Control oBeginButton);

				#endregion

				#region Methods for Aggregation endButton

				/// <summary>
				/// Gets content of aggregation {@link #getEndButton endButton}.
				/// 
				/// EndButton is always shown at the right side (left side in RTL mode) inside the header. When showHeader is set to false, the property is ignored.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.Control getEndButton();

				/// <summary>
				/// Destroys the endButton in the aggregation {@link #getEndButton endButton}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Popover destroyEndButton();

				/// <summary>
				/// Sets the aggregated {@link #getEndButton endButton}.
				/// </summary>
				/// <param name="oEndButton">The endButton to set</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Popover setEndButton(sap.ui.core.Control oEndButton);

				#endregion

				#region Methods for Association leftButton

				/// <summary>
				/// ID of the element which is the current target of the association {@link #getLeftButton leftButton}, or <code>null</code>.
				/// </summary>
				[Obsolete("Deprecated since 1.15.1. This property has been deprecated since 1.15.1. Please use the beginButton instead.")]
				/// <returns></returns>
				public extern virtual sap.ui.core.ID getLeftButton();

				/// <summary>
				/// Sets the associated {@link #getLeftButton leftButton}.
				/// </summary>
				[Obsolete("Deprecated since 1.15.1. This property has been deprecated since 1.15.1. Please use the beginButton instead.")]
				/// <param name="oLeftButton">ID of an element which becomes the new target of this leftButton association; alternatively, an element instance may be given</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Popover setLeftButton(Union<sap.ui.core.ID, sap.m.Button> oLeftButton);

				#endregion

				#region Methods for Association rightButton

				/// <summary>
				/// ID of the element which is the current target of the association {@link #getRightButton rightButton}, or <code>null</code>.
				/// </summary>
				[Obsolete("Deprecated since 1.15.1. This property has been deprecated since 1.15.1. Please use the endButton instead.")]
				/// <returns></returns>
				public extern virtual sap.ui.core.ID getRightButton();

				/// <summary>
				/// Sets the associated {@link #getRightButton rightButton}.
				/// </summary>
				[Obsolete("Deprecated since 1.15.1. This property has been deprecated since 1.15.1. Please use the endButton instead.")]
				/// <param name="oRightButton">ID of an element which becomes the new target of this rightButton association; alternatively, an element instance may be given</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Popover setRightButton(Union<sap.ui.core.ID, sap.m.Button> oRightButton);

				#endregion

				#region Methods for Association initialFocus

				/// <summary>
				/// ID of the element which is the current target of the association {@link #getInitialFocus initialFocus}, or <code>null</code>.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.ID getInitialFocus();

				/// <summary>
				/// Sets the associated {@link #getInitialFocus initialFocus}.
				/// </summary>
				/// <param name="oInitialFocus">ID of an element which becomes the new target of this initialFocus association; alternatively, an element instance may be given</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Popover setInitialFocus(Union<sap.ui.core.ID, sap.ui.core.Control> oInitialFocus);

				#endregion

				#region Methods for Association ariaLabelledBy

				/// <summary>
				/// Returns array of IDs of the elements which are the current targets of the association {@link #getAriaLabelledBy ariaLabelledBy}.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.ID[] getAriaLabelledBy();

				/// <summary>
				/// Adds some ariaLabelledBy into the association {@link #getAriaLabelledBy ariaLabelledBy}.
				/// </summary>
				/// <param name="vAriaLabelledBy">The ariaLabelledBy to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Popover addAriaLabelledBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaLabelledBy);

				/// <summary>
				/// Removes an ariaLabelledBy from the association named {@link #getAriaLabelledBy ariaLabelledBy}.
				/// </summary>
				/// <param name="vAriaLabelledBy">The ariaLabelledBy to be removed or its index or ID</param>
				/// <returns>The removed ariaLabelledBy or <code>null</code></returns>
				public extern virtual sap.ui.core.ID removeAriaLabelledBy(Union<int, sap.ui.core.ID, sap.ui.core.Control> vAriaLabelledBy);

				/// <summary>
				/// Removes all the controls in the association named {@link #getAriaLabelledBy ariaLabelledBy}.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.ui.core.ID[] removeAllAriaLabelledBy();

				#endregion

				#region Methods for Association ariaDescribedBy

				/// <summary>
				/// Returns array of IDs of the elements which are the current targets of the association {@link #getAriaDescribedBy ariaDescribedBy}.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.ID[] getAriaDescribedBy();

				/// <summary>
				/// Adds some ariaDescribedBy into the association {@link #getAriaDescribedBy ariaDescribedBy}.
				/// </summary>
				/// <param name="vAriaDescribedBy">The ariaDescribedBy to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Popover addAriaDescribedBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaDescribedBy);

				/// <summary>
				/// Removes an ariaDescribedBy from the association named {@link #getAriaDescribedBy ariaDescribedBy}.
				/// </summary>
				/// <param name="vAriaDescribedBy">The ariaDescribedBy to be removed or its index or ID</param>
				/// <returns>The removed ariaDescribedBy or <code>null</code></returns>
				public extern virtual sap.ui.core.ID removeAriaDescribedBy(Union<int, sap.ui.core.ID, sap.ui.core.Control> vAriaDescribedBy);

				/// <summary>
				/// Removes all the controls in the association named {@link #getAriaDescribedBy ariaDescribedBy}.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.ui.core.ID[] removeAllAriaDescribedBy();

				#endregion

				#region Methods for Event afterOpen

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterOpen afterOpen} event of this <code>sap.m.Popover</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Popover</code> itself.
				/// 
				/// This event will be fired after the popover is opened.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.Popover</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Popover attachAfterOpen(object oData, sap.m.AfterOpenCloseBeforeDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterOpen afterOpen} event of this <code>sap.m.Popover</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Popover</code> itself.
				/// 
				/// This event will be fired after the popover is opened.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Popover attachAfterOpen(object oData, sap.m.AfterOpenCloseBeforeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterOpen afterOpen} event of this <code>sap.m.Popover</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Popover</code> itself.
				/// 
				/// This event will be fired after the popover is opened.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Popover attachAfterOpen(sap.m.AfterOpenCloseBeforeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterOpen afterOpen} event of this <code>sap.m.Popover</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Popover</code> itself.
				/// 
				/// This event will be fired after the popover is opened.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.Popover</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Popover attachAfterOpen(sap.m.AfterOpenCloseBeforeDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:afterOpen afterOpen} event of this <code>sap.m.Popover</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Popover detachAfterOpen(sap.m.AfterOpenCloseBeforeDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:afterOpen afterOpen} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Popover fireAfterOpen(sap.m.AfterOpenCloseBeforeInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:afterOpen afterOpen} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Popover fireAfterOpen();

				#endregion

				#region Methods for Event afterClose

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterClose afterClose} event of this <code>sap.m.Popover</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Popover</code> itself.
				/// 
				/// This event will be fired after the popover is closed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.Popover</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Popover attachAfterClose(object oData, sap.m.AfterOpenCloseBeforeDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterClose afterClose} event of this <code>sap.m.Popover</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Popover</code> itself.
				/// 
				/// This event will be fired after the popover is closed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Popover attachAfterClose(object oData, sap.m.AfterOpenCloseBeforeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterClose afterClose} event of this <code>sap.m.Popover</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Popover</code> itself.
				/// 
				/// This event will be fired after the popover is closed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Popover attachAfterClose(sap.m.AfterOpenCloseBeforeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterClose afterClose} event of this <code>sap.m.Popover</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Popover</code> itself.
				/// 
				/// This event will be fired after the popover is closed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.Popover</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Popover attachAfterClose(sap.m.AfterOpenCloseBeforeDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:afterClose afterClose} event of this <code>sap.m.Popover</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Popover detachAfterClose(sap.m.AfterOpenCloseBeforeDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:afterClose afterClose} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Popover fireAfterClose(sap.m.AfterOpenCloseBeforeInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:afterClose afterClose} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Popover fireAfterClose();

				#endregion

				#region Methods for Event beforeOpen

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeOpen beforeOpen} event of this <code>sap.m.Popover</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Popover</code> itself.
				/// 
				/// This event will be fired before the popover is opened.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.Popover</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Popover attachBeforeOpen(object oData, sap.m.AfterOpenCloseBeforeDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeOpen beforeOpen} event of this <code>sap.m.Popover</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Popover</code> itself.
				/// 
				/// This event will be fired before the popover is opened.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Popover attachBeforeOpen(object oData, sap.m.AfterOpenCloseBeforeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeOpen beforeOpen} event of this <code>sap.m.Popover</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Popover</code> itself.
				/// 
				/// This event will be fired before the popover is opened.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Popover attachBeforeOpen(sap.m.AfterOpenCloseBeforeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeOpen beforeOpen} event of this <code>sap.m.Popover</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Popover</code> itself.
				/// 
				/// This event will be fired before the popover is opened.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.Popover</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Popover attachBeforeOpen(sap.m.AfterOpenCloseBeforeDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:beforeOpen beforeOpen} event of this <code>sap.m.Popover</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Popover detachBeforeOpen(sap.m.AfterOpenCloseBeforeDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:beforeOpen beforeOpen} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Popover fireBeforeOpen(sap.m.AfterOpenCloseBeforeInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:beforeOpen beforeOpen} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Popover fireBeforeOpen();

				#endregion

				#region Methods for Event beforeClose

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeClose beforeClose} event of this <code>sap.m.Popover</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Popover</code> itself.
				/// 
				/// This event will be fired before the popover is closed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.Popover</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Popover attachBeforeClose(object oData, sap.m.AfterOpenCloseBeforeDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeClose beforeClose} event of this <code>sap.m.Popover</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Popover</code> itself.
				/// 
				/// This event will be fired before the popover is closed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Popover attachBeforeClose(object oData, sap.m.AfterOpenCloseBeforeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeClose beforeClose} event of this <code>sap.m.Popover</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Popover</code> itself.
				/// 
				/// This event will be fired before the popover is closed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Popover attachBeforeClose(sap.m.AfterOpenCloseBeforeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeClose beforeClose} event of this <code>sap.m.Popover</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Popover</code> itself.
				/// 
				/// This event will be fired before the popover is closed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.Popover</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Popover attachBeforeClose(sap.m.AfterOpenCloseBeforeDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:beforeClose beforeClose} event of this <code>sap.m.Popover</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Popover detachBeforeClose(sap.m.AfterOpenCloseBeforeDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:beforeClose beforeClose} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Popover fireBeforeClose(sap.m.AfterOpenCloseBeforeInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:beforeClose beforeClose} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Popover fireBeforeClose();

				#endregion

				#region Other methods

				/// <summary>
				/// Hook called after adjusment of the Popover position.
				/// </summary>
				public extern virtual void _afterAdjustPositionAndArrowHook();

				/// <summary>
				/// If customHeader is set, this will return the customHeaer. Otherwise it creates a header and put the title and buttons if needed inside, and finally return this newly create header.
				/// </summary>
				/// <returns>The created header</returns>
				public extern virtual object _getAnyHeader();

				/// <summary>
				/// Closes the popover when it's already opened.
				/// </summary>
				/// <returns>Reference to the control instance for chaining</returns>
				public extern virtual sap.m.Popover close();

				/// <summary>
				/// Creates a new subclass of class sap.m.Popover with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.Popover with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.Popover with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.Popover.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				/// <summary>
				/// The method checks if the Popover is open. It returns true when the Popover is currently open (this includes opening and closing animations), otherwise it returns false.
				/// </summary>
				/// <returns>whether the Popover is currently opened</returns>
				public extern virtual bool isOpen();

				/// <summary>
				/// Opens the Popover and sets the Popover position according to the {@link #getPlacement() placement} property around the <code>oControl</code> parameter.
				/// </summary>
				/// <param name="oControl">This is the control to which the Popover will be placed. It can be not only a UI5 control, but also an existing DOM reference. The side of the placement depends on the placement property set in the Popover.</param>
				/// <param name="bSkipInstanceManager">Indicates whether popover should be managed by InstanceManager or not</param>
				/// <returns>Reference to the control instance for chaining</returns>
				public extern virtual sap.m.Popover openBy(object oControl, bool bSkipInstanceManager);

				/// <summary>
				/// Calculate outerHeight of the element; used as hook for SVG elements
				/// </summary>
				/// <param name="oElement">An Element for which outerHeight will be calculated.</param>
				/// <param name="bIncludeMargin">Determines if the margins should be included in the calculated outerHeight. Default value is false. * @returns {number} The outer height of the element</param>
				public extern static void outerHeight(dom.HTMLElement oElement, bool bIncludeMargin);

				/// <summary>
				/// Calculate outerWidth of the element; used as hook for SVG elements
				/// </summary>
				/// <param name="oElement">An Element for which outerWidth will be calculated.</param>
				/// <param name="bIncludeMargin">Determines if the margins should be included in the calculated outerWidth. Default value is false.</param>
				/// <returns>The outer width of the element</returns>
				public extern static int outerWidth(dom.HTMLElement oElement, bool bIncludeMargin);

				/// <summary>
				/// The followOf feature closes the Popover when the position of the control that opened the Popover changes by at least 32 pixels (on desktop browsers). This may lead to unwanted closing of the Popover.
				/// 
				/// This function is for enabling/disabling the followOf feature.
				/// </summary>
				/// <param name="bValue">Enables the followOf feature</param>
				/// <returns>Reference to the control instance for chaining</returns>
				public extern virtual sap.m.Popover setFollowOf(bool bValue);

				#endregion

				#endregion

			}
		}
	}
}
