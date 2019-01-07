using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public static partial class sap
	{
		public static partial class m
		{
			/// <summary>
			/// <h3>Overview</h3> The responsive popover acts as a {@link sap.m.Popover popover} on desktop and tablet, while on phone it acts as a {@link sap.m.Dialog dialog} with <code>stretch</code> set to true.
			/// 
			/// <b>Note:</b> It is recommended that <code>ResponsivePopover</code> is used in fragments otherwise there might be some implications on the user experience. For example, on desktop, open or close functions of the <code>Popover</code> might not be called.
			/// 
			/// <h3>Usage</h3> When you want to make sure that all content is visible on any device.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.ResponsivePopover")]
			public partial class ResponsivePopover : sap.ui.core.Control
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
					/// This property only takes effect on desktop or tablet. Please see the documentation sap.m.Popover#placement.
					/// </summary>
					public Union<sap.m.PlacementType, string, sap.ui.@base.ManagedObject.BindPropertyInfo> placement;

					/// <summary>
					/// This property is supported by both variants. Please see the documentation on sap.m.Popover#showHeader and sap.m.Dialog#showHeader
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showHeader;

					/// <summary>
					/// This property is supported by both variants. Please see the documentation on sap.m.Popover#title and sap.m.Dialog#title
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> title;

					/// <summary>
					/// This property only takes effect on phone. Please see the documentation sap.m.Dialog#icon.
					/// </summary>
					public Union<sap.ui.core.URI, string, sap.ui.@base.ManagedObject.BindPropertyInfo> icon;

					/// <summary>
					/// This property only takes effect on desktop or tablet. Please see the documentation sap.m.Popover#modal.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> modal;

					/// <summary>
					/// This property only takes effect on desktop or tablet. Please see the documentation sap.m.Popover#offsetX.
					/// </summary>
					public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> offsetX;

					/// <summary>
					/// This property only takes effect on desktop or tablet. Please see the documentation sap.m.Popover#offsetY.
					/// </summary>
					public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> offsetY;

					/// <summary>
					/// This property only takes effect on desktop or tablet. Please see the documentation sap.m.Popover#showArrow.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showArrow;

					/// <summary>
					/// This property is supported by both variants. Please see the documentation on sap.m.Popover#contentWidth and sap.m.Dialog#contentWidth
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> contentWidth;

					/// <summary>
					/// This property is supported by both variants. Please see the documentation on sap.m.Popover#contentHeight and sap.m.Dialog#contentHeight
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> contentHeight;

					/// <summary>
					/// This property is supported by both variants. Please see the documentation on sap.m.Popover#horizontalScrolling and sap.m.Dialog#horizontalScrolling
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> horizontalScrolling;

					/// <summary>
					/// This property is supported by both variants. Please see the documentation on sap.m.Popover#verticalScrolling and sap.m.Dialog#verticalScrolling
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> verticalScrolling;

					/// <summary>
					/// Determines if a close button should be inserted into the dialog's header dynamically to close the dialog. This property only takes effect on phone. <b>Note:</b> The close button could be placed only in a sap.m.Bar if a sap.m.Toolbar is passed as a header - the property will not take effect.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showCloseButton;

					/// <summary>
					/// Whether resize option is enabled.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> resizable;

					/// <summary>
					/// Content is supported by both variants. Please see the documentation on sap.m.Popover#content and sap.m.Dialog#content
					/// </summary>
					public Union<sap.ui.core.Control[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> content;

					/// <summary>
					/// CustomHeader is supported by both variants. Please see the documentation on sap.m.Popover#customHeader and sap.m.Dialog#customHeader
					/// </summary>
					public Union<sap.m.IBar, string, sap.ui.@base.ManagedObject.BindAggregationInfo> customHeader;

					/// <summary>
					/// SubHeader is supported by both variants. Please see the documentation on sap.m.Popover#subHeader and sap.m.Dialog#subHeader
					/// </summary>
					public Union<sap.m.IBar, string, sap.ui.@base.ManagedObject.BindAggregationInfo> subHeader;

					/// <summary>
					/// BeginButton is supported by both variants. It is always show in the left part (right part in RTL mode) of the footer which is located at the bottom of the ResponsivePopover. If buttons need to be displayed in header, please use customHeader instead.
					/// </summary>
					public Union<sap.m.Button, string, sap.ui.@base.ManagedObject.BindAggregationInfo> beginButton;

					/// <summary>
					/// EndButton is supported by both variants. It is always show in the right part (left part in RTL mode) of the footer which is located at the bottom of the ResponsivePopover. If buttons need to be displayed in header, please use customHeader instead.
					/// </summary>
					public Union<sap.m.Button, string, sap.ui.@base.ManagedObject.BindAggregationInfo> endButton;

					/// <summary>
					/// InitialFocus is supported by both variants. Please see the documentation on sap.m.Popover#initialFocus and sap.m.Dialog#initialFocus
					/// </summary>
					public Union<sap.ui.core.Control, sap.ui.core.ID, string, sap.ui.@base.ManagedObject.BindPropertyInfo> initialFocus;

					/// <summary>
					/// Association to controls / ids which label this control (see WAI-ARIA attribute aria-labelledby).
					/// </summary>
					public Union<sap.ui.core.Control, sap.ui.core.ID[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> ariaLabelledBy;

					/// <summary>
					/// Association to controls / IDs which describe this control (see WAI-ARIA attribute aria-describedby).
					/// </summary>
					public Union<sap.ui.core.Control, sap.ui.core.ID[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> ariaDescribedBy;

					/// <summary>
					/// Event is fired before popover or dialog is open.
					/// </summary>
					public sap.m.AfterOpenCloseBeforeDelegate beforeOpen;

					/// <summary>
					/// Event is fired after popover or dialog is open.
					/// </summary>
					public sap.m.AfterOpenCloseBeforeDelegate afterOpen;

					/// <summary>
					/// Event is fired before popover or dialog is closed.
					/// </summary>
					public sap.m.CloseDelegate beforeClose;

					/// <summary>
					/// Event is fired after popover or dialog is closed.
					/// </summary>
					public sap.m.CloseDelegate afterClose;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new ResponsivePopover.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control A popover-based control that behaves differently according to the device it is on.</param>
				public extern ResponsivePopover(string sId, sap.m.ResponsivePopover.Settings mSettings);

				/// <summary>
				/// Constructor for a new ResponsivePopover.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern ResponsivePopover(string sId);

				/// <summary>
				/// Constructor for a new ResponsivePopover.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern ResponsivePopover();

				/// <summary>
				/// Constructor for a new ResponsivePopover.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control A popover-based control that behaves differently according to the device it is on.</param>
				public extern ResponsivePopover(sap.m.ResponsivePopover.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property placement

				/// <summary>
				/// Gets current value of property {@link #getPlacement placement}.
				/// 
				/// This property only takes effect on desktop or tablet. Please see the documentation sap.m.Popover#placement.
				/// 
				/// Default value is <code>Right</code>.
				/// </summary>
				/// <returns>Value of property <code>placement</code></returns>
				public extern virtual sap.m.PlacementType getPlacement();

				/// <summary>
				/// Sets a new value for property {@link #getPlacement placement}.
				/// 
				/// This property only takes effect on desktop or tablet. Please see the documentation sap.m.Popover#placement.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Right</code>.
				/// </summary>
				/// <param name="sPlacement">New value for property <code>placement</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ResponsivePopover setPlacement(sap.m.PlacementType sPlacement);

				#endregion

				#region Methods for Property showHeader

				/// <summary>
				/// Gets current value of property {@link #getShowHeader showHeader}.
				/// 
				/// This property is supported by both variants. Please see the documentation on sap.m.Popover#showHeader and sap.m.Dialog#showHeader
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>showHeader</code></returns>
				public extern virtual bool getShowHeader();

				/// <summary>
				/// Sets a new value for property {@link #getShowHeader showHeader}.
				/// 
				/// This property is supported by both variants. Please see the documentation on sap.m.Popover#showHeader and sap.m.Dialog#showHeader
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bShowHeader">New value for property <code>showHeader</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ResponsivePopover setShowHeader(bool bShowHeader);

				#endregion

				#region Methods for Property title

				/// <summary>
				/// Gets current value of property {@link #getTitle title}.
				/// 
				/// This property is supported by both variants. Please see the documentation on sap.m.Popover#title and sap.m.Dialog#title
				/// </summary>
				/// <returns>Value of property <code>title</code></returns>
				public extern virtual string getTitle();

				/// <summary>
				/// Sets a new value for property {@link #getTitle title}.
				/// 
				/// This property is supported by both variants. Please see the documentation on sap.m.Popover#title and sap.m.Dialog#title
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sTitle">New value for property <code>title</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ResponsivePopover setTitle(string sTitle);

				#endregion

				#region Methods for Property icon

				/// <summary>
				/// Gets current value of property {@link #getIcon icon}.
				/// 
				/// This property only takes effect on phone. Please see the documentation sap.m.Dialog#icon.
				/// </summary>
				/// <returns>Value of property <code>icon</code></returns>
				public extern virtual sap.ui.core.URI getIcon();

				/// <summary>
				/// Sets a new value for property {@link #getIcon icon}.
				/// 
				/// This property only takes effect on phone. Please see the documentation sap.m.Dialog#icon.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sIcon">New value for property <code>icon</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ResponsivePopover setIcon(sap.ui.core.URI sIcon);

				#endregion

				#region Methods for Property modal

				/// <summary>
				/// Gets current value of property {@link #getModal modal}.
				/// 
				/// This property only takes effect on desktop or tablet. Please see the documentation sap.m.Popover#modal.
				/// </summary>
				/// <returns>Value of property <code>modal</code></returns>
				public extern virtual bool getModal();

				/// <summary>
				/// Sets a new value for property {@link #getModal modal}.
				/// 
				/// This property only takes effect on desktop or tablet. Please see the documentation sap.m.Popover#modal.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="bModal">New value for property <code>modal</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ResponsivePopover setModal(bool bModal);

				#endregion

				#region Methods for Property offsetX

				/// <summary>
				/// Gets current value of property {@link #getOffsetX offsetX}.
				/// 
				/// This property only takes effect on desktop or tablet. Please see the documentation sap.m.Popover#offsetX.
				/// </summary>
				/// <returns>Value of property <code>offsetX</code></returns>
				public extern virtual int getOffsetX();

				/// <summary>
				/// Sets a new value for property {@link #getOffsetX offsetX}.
				/// 
				/// This property only takes effect on desktop or tablet. Please see the documentation sap.m.Popover#offsetX.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="iOffsetX">New value for property <code>offsetX</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ResponsivePopover setOffsetX(int iOffsetX);

				#endregion

				#region Methods for Property offsetY

				/// <summary>
				/// Gets current value of property {@link #getOffsetY offsetY}.
				/// 
				/// This property only takes effect on desktop or tablet. Please see the documentation sap.m.Popover#offsetY.
				/// </summary>
				/// <returns>Value of property <code>offsetY</code></returns>
				public extern virtual int getOffsetY();

				/// <summary>
				/// Sets a new value for property {@link #getOffsetY offsetY}.
				/// 
				/// This property only takes effect on desktop or tablet. Please see the documentation sap.m.Popover#offsetY.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="iOffsetY">New value for property <code>offsetY</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ResponsivePopover setOffsetY(int iOffsetY);

				#endregion

				#region Methods for Property showArrow

				/// <summary>
				/// Gets current value of property {@link #getShowArrow showArrow}.
				/// 
				/// This property only takes effect on desktop or tablet. Please see the documentation sap.m.Popover#showArrow.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>showArrow</code></returns>
				public extern virtual bool getShowArrow();

				/// <summary>
				/// Sets a new value for property {@link #getShowArrow showArrow}.
				/// 
				/// This property only takes effect on desktop or tablet. Please see the documentation sap.m.Popover#showArrow.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bShowArrow">New value for property <code>showArrow</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ResponsivePopover setShowArrow(bool bShowArrow);

				#endregion

				#region Methods for Property contentWidth

				/// <summary>
				/// Gets current value of property {@link #getContentWidth contentWidth}.
				/// 
				/// This property is supported by both variants. Please see the documentation on sap.m.Popover#contentWidth and sap.m.Dialog#contentWidth
				/// </summary>
				/// <returns>Value of property <code>contentWidth</code></returns>
				public extern virtual sap.ui.core.CSSSize getContentWidth();

				/// <summary>
				/// Sets a new value for property {@link #getContentWidth contentWidth}.
				/// 
				/// This property is supported by both variants. Please see the documentation on sap.m.Popover#contentWidth and sap.m.Dialog#contentWidth
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sContentWidth">New value for property <code>contentWidth</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ResponsivePopover setContentWidth(sap.ui.core.CSSSize sContentWidth);

				#endregion

				#region Methods for Property contentHeight

				/// <summary>
				/// Gets current value of property {@link #getContentHeight contentHeight}.
				/// 
				/// This property is supported by both variants. Please see the documentation on sap.m.Popover#contentHeight and sap.m.Dialog#contentHeight
				/// </summary>
				/// <returns>Value of property <code>contentHeight</code></returns>
				public extern virtual sap.ui.core.CSSSize getContentHeight();

				/// <summary>
				/// Sets a new value for property {@link #getContentHeight contentHeight}.
				/// 
				/// This property is supported by both variants. Please see the documentation on sap.m.Popover#contentHeight and sap.m.Dialog#contentHeight
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sContentHeight">New value for property <code>contentHeight</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ResponsivePopover setContentHeight(sap.ui.core.CSSSize sContentHeight);

				#endregion

				#region Methods for Property horizontalScrolling

				/// <summary>
				/// Gets current value of property {@link #getHorizontalScrolling horizontalScrolling}.
				/// 
				/// This property is supported by both variants. Please see the documentation on sap.m.Popover#horizontalScrolling and sap.m.Dialog#horizontalScrolling
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>horizontalScrolling</code></returns>
				public extern virtual bool getHorizontalScrolling();

				/// <summary>
				/// Sets a new value for property {@link #getHorizontalScrolling horizontalScrolling}.
				/// 
				/// This property is supported by both variants. Please see the documentation on sap.m.Popover#horizontalScrolling and sap.m.Dialog#horizontalScrolling
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bHorizontalScrolling">New value for property <code>horizontalScrolling</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ResponsivePopover setHorizontalScrolling(bool bHorizontalScrolling);

				#endregion

				#region Methods for Property verticalScrolling

				/// <summary>
				/// Gets current value of property {@link #getVerticalScrolling verticalScrolling}.
				/// 
				/// This property is supported by both variants. Please see the documentation on sap.m.Popover#verticalScrolling and sap.m.Dialog#verticalScrolling
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>verticalScrolling</code></returns>
				public extern virtual bool getVerticalScrolling();

				/// <summary>
				/// Sets a new value for property {@link #getVerticalScrolling verticalScrolling}.
				/// 
				/// This property is supported by both variants. Please see the documentation on sap.m.Popover#verticalScrolling and sap.m.Dialog#verticalScrolling
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bVerticalScrolling">New value for property <code>verticalScrolling</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ResponsivePopover setVerticalScrolling(bool bVerticalScrolling);

				#endregion

				#region Methods for Property showCloseButton

				/// <summary>
				/// Gets current value of property {@link #getShowCloseButton showCloseButton}.
				/// 
				/// Determines if a close button should be inserted into the dialog's header dynamically to close the dialog. This property only takes effect on phone. <b>Note:</b> The close button could be placed only in a sap.m.Bar if a sap.m.Toolbar is passed as a header - the property will not take effect.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>showCloseButton</code></returns>
				public extern virtual bool getShowCloseButton();

				/// <summary>
				/// Determines if the close button to the ResponsivePopover is shown or not. Works only when ResponsivePopover is used as a dialog
				/// </summary>
				/// <param name="bShowCloseButton">Defines whether the close button is shown</param>
				/// <returns>Pointer to the control instance for chaining</returns>
				public extern virtual sap.m.ResponsivePopover setShowCloseButton(bool bShowCloseButton);

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
				public extern virtual sap.m.ResponsivePopover setResizable(bool bResizable);

				#endregion

				#region Methods for Aggregation content

				/// <summary>
				/// Gets content of aggregation {@link #getContent content}.
				/// 
				/// Content is supported by both variants. Please see the documentation on sap.m.Popover#content and sap.m.Dialog#content
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.Control[] getContent();

				/// <summary>
				/// Destroys all the content in the aggregation {@link #getContent content}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ResponsivePopover destroyContent();

				/// <summary>
				/// Inserts a content into the aggregation {@link #getContent content}.
				/// </summary>
				/// <param name="oContent">The content to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the content should be inserted at; for a negative value of <code>iIndex</code>, the content is inserted at position 0; for a value greater than the current size of the aggregation, the content is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ResponsivePopover insertContent(sap.ui.core.Control oContent, int iIndex);

				/// <summary>
				/// Adds content to the ResponsivePopover
				/// </summary>
				/// <param name="oControl">The control to be added to the content</param>
				public extern virtual void addContent(sap.ui.core.Control oControl);

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
				/// CustomHeader is supported by both variants. Please see the documentation on sap.m.Popover#customHeader and sap.m.Dialog#customHeader
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.IBar getCustomHeader();

				/// <summary>
				/// Destroys the customHeader in the aggregation {@link #getCustomHeader customHeader}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ResponsivePopover destroyCustomHeader();

				/// <summary>
				/// Sets the aggregated {@link #getCustomHeader customHeader}.
				/// </summary>
				/// <param name="oCustomHeader">The customHeader to set</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ResponsivePopover setCustomHeader(sap.m.IBar oCustomHeader);

				#endregion

				#region Methods for Aggregation subHeader

				/// <summary>
				/// Gets content of aggregation {@link #getSubHeader subHeader}.
				/// 
				/// SubHeader is supported by both variants. Please see the documentation on sap.m.Popover#subHeader and sap.m.Dialog#subHeader
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.IBar getSubHeader();

				/// <summary>
				/// Destroys the subHeader in the aggregation {@link #getSubHeader subHeader}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ResponsivePopover destroySubHeader();

				/// <summary>
				/// Sets the aggregated {@link #getSubHeader subHeader}.
				/// </summary>
				/// <param name="oSubHeader">The subHeader to set</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ResponsivePopover setSubHeader(sap.m.IBar oSubHeader);

				#endregion

				#region Methods for Aggregation beginButton

				/// <summary>
				/// Getter for beginButton aggregation
				/// </summary>
				/// <returns>The button that is set as a beginButton aggregation</returns>
				public extern virtual sap.m.Button getBeginButton();

				/// <summary>
				/// Destroys the beginButton in the aggregation {@link #getBeginButton beginButton}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ResponsivePopover destroyBeginButton();

				/// <summary>
				/// Setter for beginButton aggregation
				/// </summary>
				/// <param name="oButton">The button that will be set as an aggregation</param>
				/// <returns>Pointer to the control instance for chaining</returns>
				public extern virtual sap.m.ResponsivePopover setBeginButton(sap.m.Button oButton);

				#endregion

				#region Methods for Aggregation endButton

				/// <summary>
				/// Getter for endButton aggregation
				/// </summary>
				/// <returns>The button that is set as an endButton aggregation</returns>
				public extern virtual sap.m.Button getEndButton();

				/// <summary>
				/// Destroys the endButton in the aggregation {@link #getEndButton endButton}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ResponsivePopover destroyEndButton();

				/// <summary>
				/// Setter for endButton aggregation
				/// </summary>
				/// <param name="oButton">The button that will be set as an aggregation</param>
				/// <returns>Pointer to the control instance for chaining</returns>
				public extern virtual sap.m.ResponsivePopover setEndButton(sap.m.Button oButton);

				#endregion

				#region Methods for Aggregation _popup

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
				public extern virtual sap.m.ResponsivePopover setInitialFocus(Union<sap.ui.core.ID, sap.ui.core.Control> oInitialFocus);

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
				public extern virtual sap.m.ResponsivePopover addAriaLabelledBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaLabelledBy);

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
				public extern virtual sap.m.ResponsivePopover addAriaDescribedBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaDescribedBy);

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

				#region Methods for Event beforeOpen

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeOpen beforeOpen} event of this <code>sap.m.ResponsivePopover</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ResponsivePopover</code> itself.
				/// 
				/// Event is fired before popover or dialog is open.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ResponsivePopover</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ResponsivePopover attachBeforeOpen(object oData, sap.m.AfterOpenCloseBeforeDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeOpen beforeOpen} event of this <code>sap.m.ResponsivePopover</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ResponsivePopover</code> itself.
				/// 
				/// Event is fired before popover or dialog is open.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ResponsivePopover attachBeforeOpen(object oData, sap.m.AfterOpenCloseBeforeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeOpen beforeOpen} event of this <code>sap.m.ResponsivePopover</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ResponsivePopover</code> itself.
				/// 
				/// Event is fired before popover or dialog is open.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ResponsivePopover attachBeforeOpen(sap.m.AfterOpenCloseBeforeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeOpen beforeOpen} event of this <code>sap.m.ResponsivePopover</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ResponsivePopover</code> itself.
				/// 
				/// Event is fired before popover or dialog is open.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ResponsivePopover</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ResponsivePopover attachBeforeOpen(sap.m.AfterOpenCloseBeforeDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:beforeOpen beforeOpen} event of this <code>sap.m.ResponsivePopover</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ResponsivePopover detachBeforeOpen(sap.m.AfterOpenCloseBeforeDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:beforeOpen beforeOpen} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ResponsivePopover fireBeforeOpen(sap.m.AfterOpenCloseBeforeInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:beforeOpen beforeOpen} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ResponsivePopover fireBeforeOpen();

				#endregion

				#region Methods for Event afterOpen

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterOpen afterOpen} event of this <code>sap.m.ResponsivePopover</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ResponsivePopover</code> itself.
				/// 
				/// Event is fired after popover or dialog is open.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ResponsivePopover</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ResponsivePopover attachAfterOpen(object oData, sap.m.AfterOpenCloseBeforeDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterOpen afterOpen} event of this <code>sap.m.ResponsivePopover</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ResponsivePopover</code> itself.
				/// 
				/// Event is fired after popover or dialog is open.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ResponsivePopover attachAfterOpen(object oData, sap.m.AfterOpenCloseBeforeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterOpen afterOpen} event of this <code>sap.m.ResponsivePopover</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ResponsivePopover</code> itself.
				/// 
				/// Event is fired after popover or dialog is open.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ResponsivePopover attachAfterOpen(sap.m.AfterOpenCloseBeforeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterOpen afterOpen} event of this <code>sap.m.ResponsivePopover</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ResponsivePopover</code> itself.
				/// 
				/// Event is fired after popover or dialog is open.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ResponsivePopover</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ResponsivePopover attachAfterOpen(sap.m.AfterOpenCloseBeforeDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:afterOpen afterOpen} event of this <code>sap.m.ResponsivePopover</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ResponsivePopover detachAfterOpen(sap.m.AfterOpenCloseBeforeDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:afterOpen afterOpen} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ResponsivePopover fireAfterOpen(sap.m.AfterOpenCloseBeforeInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:afterOpen afterOpen} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ResponsivePopover fireAfterOpen();

				#endregion

				#region Methods for Event beforeClose

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeClose beforeClose} event of this <code>sap.m.ResponsivePopover</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ResponsivePopover</code> itself.
				/// 
				/// Event is fired before popover or dialog is closed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ResponsivePopover</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ResponsivePopover attachBeforeClose(object oData, sap.m.CloseDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeClose beforeClose} event of this <code>sap.m.ResponsivePopover</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ResponsivePopover</code> itself.
				/// 
				/// Event is fired before popover or dialog is closed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ResponsivePopover attachBeforeClose(object oData, sap.m.CloseDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeClose beforeClose} event of this <code>sap.m.ResponsivePopover</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ResponsivePopover</code> itself.
				/// 
				/// Event is fired before popover or dialog is closed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ResponsivePopover attachBeforeClose(sap.m.CloseDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeClose beforeClose} event of this <code>sap.m.ResponsivePopover</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ResponsivePopover</code> itself.
				/// 
				/// Event is fired before popover or dialog is closed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ResponsivePopover</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ResponsivePopover attachBeforeClose(sap.m.CloseDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:beforeClose beforeClose} event of this <code>sap.m.ResponsivePopover</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ResponsivePopover detachBeforeClose(sap.m.CloseDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:beforeClose beforeClose} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ResponsivePopover fireBeforeClose(sap.m.CloseInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:beforeClose beforeClose} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ResponsivePopover fireBeforeClose();

				#endregion

				#region Methods for Event afterClose

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterClose afterClose} event of this <code>sap.m.ResponsivePopover</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ResponsivePopover</code> itself.
				/// 
				/// Event is fired after popover or dialog is closed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ResponsivePopover</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ResponsivePopover attachAfterClose(object oData, sap.m.CloseDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterClose afterClose} event of this <code>sap.m.ResponsivePopover</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ResponsivePopover</code> itself.
				/// 
				/// Event is fired after popover or dialog is closed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ResponsivePopover attachAfterClose(object oData, sap.m.CloseDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterClose afterClose} event of this <code>sap.m.ResponsivePopover</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ResponsivePopover</code> itself.
				/// 
				/// Event is fired after popover or dialog is closed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ResponsivePopover attachAfterClose(sap.m.CloseDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterClose afterClose} event of this <code>sap.m.ResponsivePopover</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ResponsivePopover</code> itself.
				/// 
				/// Event is fired after popover or dialog is closed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ResponsivePopover</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ResponsivePopover attachAfterClose(sap.m.CloseDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:afterClose afterClose} event of this <code>sap.m.ResponsivePopover</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ResponsivePopover detachAfterClose(sap.m.CloseDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:afterClose afterClose} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ResponsivePopover fireAfterClose(sap.m.CloseInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:afterClose afterClose} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ResponsivePopover fireAfterClose();

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new instance of ResponsivePopover with the same settings as the ResponsivePopover on which the method is called
				/// </summary>
				/// <returns>New instance of ResponsivePopover</returns>
				public extern virtual sap.m.ResponsivePopover clone();

				/// <summary>
				/// Closes the ResponsivePopover.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.Control close();

				/// <summary>
				/// Creates a new subclass of class sap.m.ResponsivePopover with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.ResponsivePopover with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.ResponsivePopover with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.ResponsivePopover.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				[Name("getMetadata")]
				public extern static sap.ui.@base.Metadata getMetadataStatic();

				/// <summary>
				/// Checks whether the ResponsivePopover is currently open.
				/// </summary>
				/// <returns></returns>
				public extern virtual bool isOpen();

				/// <summary>
				/// Opens the ResponsivePopover. The ResponsivePopover is positioned relatively to the control parameter on tablet or desktop and is full screen on phone. Therefore the control parameter is only used on tablet or desktop and is ignored on phone.
				/// </summary>
				/// <param name="oParent">When this control is displayed on tablet or desktop, the ResponsivePopover is positioned relative to this control.</param>
				/// <returns>Reference to the opening control</returns>
				public extern virtual object openBy(object oParent);

				#endregion

				#endregion

			}
		}
	}
}
