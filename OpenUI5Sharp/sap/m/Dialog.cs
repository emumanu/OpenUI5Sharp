﻿using System;
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
			/// A popup that interrupts the current processing and prompts the user for an action or an input in a modal mode. <h3>Overview</h3> The Dialog control is used to prompt the user for an action or a confirmation. It interrupts the current app processing as it is the only focused UI element and the main screen is dimmed/blocked. The content of the Dialog is fully customizable. <h3>Structure</h3> A Dialog consists of a title, optional subtitle, content area and a footer for action buttons. The Dialog is usually displayed at the center of the screen. Its size and position can be changed by the user. To enable this, you need to set the properties <code>resizable</code> and <code>draggable</code> accordingly.
			/// 
			/// There are other specialized types of dialogs: <ul> <li>{@link sap.m.P13nDialog Personalization Dialog} - used for personalizing sorting, filtering and grouping in tables</li> <li>{@link sap.m.SelectDialog Select Dialog} - used to select one or more items from a comprehensive list</li> <li>{@link sap.m.TableSelectDialog Table Select Dialog} - used to make a selection from a comprehensive table containing multiple attributes or values</li> <li>{@link sap.ui.comp.valuehelpdialog.ValueHelpDialog Value Help Dialog} - used to help the user find and select single and multiple values</li> <li>{@link sap.m.ViewSettingsDialog View Settings Dialog} - used to sort, filter, or group data within a (master) list or a table</li> <li>{@link sap.m.BusyDialog Busy Dialog} - used to block the screen and inform the user about an ongoing operation</li> </ul> <h3>Usage</h3> <h4>When to use:</h4> <ul> <li>You want to display a system message.</li> <li>You want to interrupt the user’s action.</li> <li>You want to show a message with a short and a long description.</li> </ul> <h4>When not to use:</h4> <ul> <li>You just want to confirm a successful action.</li> </ul> <h3>Responsive Behavior</h3> <ul> <li>If the <code>stretch</code> property is set to <code>true</code>, the Dialog displays on full screen.</li> <li>If the <code>contentWidth</code> and/or <code>contentHeight</code> properties are set, the Dialog will try to fill those sizes.</li> <li>If there is no specific sizing, the Dialog will try to adjust its size to its content.</li> </ul> <h4>Smartphones</h4> If the Dialog has one or two actions, they will cover the entire footer. If there are more actions, they will overflow. <h4>Tablets</h4> The action buttons in the toolbar are <b>right-aligned</b>. Use <b>cozy</b> mode on tablet devices. <h4>Desktop</h4> The action buttons in the toolbar are <b>right-aligned</b>. Use <b>compact</b> mode on desktop.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.Dialog")]
			public partial class Dialog : sap.ui.core.Control, sap.ui.core.PopupInterface
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
					/// Icon displayed in the Dialog header. This <code>icon</code> is invisible on the iOS platform and it is density-aware. You can use the density convention (@2, @1.5, etc.) to provide higher resolution image for higher density screen.
					/// </summary>
					public Union<sap.ui.core.URI, string, sap.ui.@base.ManagedObject.BindPropertyInfo> icon;

					/// <summary>
					/// Title text appears in the Dialog header.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> title;

					/// <summary>
					/// Determines whether the header is shown inside the Dialog. If this property is set to <code>true</code>, the <code>text</code> and <code>icon</code> properties are ignored. This property has a default value <code>true</code>.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showHeader;

					/// <summary>
					/// The <code>type</code> of the Dialog. In some themes, the type Message will limit the Dialog width within 480px on tablet and desktop.
					/// </summary>
					public Union<sap.m.DialogType, string, sap.ui.@base.ManagedObject.BindPropertyInfo> type;

					/// <summary>
					/// Affects the <code>icon</code> and the <code>title</code> color. If other than <code>none</code> is set, a predefined icon will be added to the Dialog. Setting the <code>icon</code> property will overwrite the predefined icon. The default value is <code>none</code> which doesn't add any icon to the Dialog control. This property is by now only supported by the blue crystal theme.
					/// </summary>
					public Union<sap.ui.core.ValueState, string, sap.ui.@base.ManagedObject.BindPropertyInfo> state;

					/// <summary>
					/// Determines whether the Dialog will be displayed on full screen on a phone.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> stretchOnPhone;

					/// <summary>
					/// Determines if the Dialog will be stretched to full screen on mobile. On desktop, the Dialog will be stretched to 93% of the viewport. This property is only applicable to a Standard Dialog. Message-type Dialog ignores it.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> stretch;

					/// <summary>
					/// Preferred width of the content in the Dialog. This property affects the width of the Dialog on a phone in landscape mode, a tablet or a desktop, because the Dialog has a fixed width on a phone in portrait mode. If the preferred width is less than the minimum width of the Dialog or more than the available width of the screen, it will be overwritten by the min or max value. The current mininum value of the Dialog width on tablet is 400px.
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> contentWidth;

					/// <summary>
					/// Preferred height of the content in the Dialog. If the preferred height is bigger than the available space on a screen, it will be overwritten by the maximum available height on a screen in order to make sure that the Dialog isn't cut off.
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> contentHeight;

					/// <summary>
					/// Indicates if the user can scroll horizontally inside the Dialog when the content is bigger than the content area. The Dialog detects if there's <code>sap.m.NavContainer</code>, <code>sap.m.Page</code>, <code>sap.m.ScrollContainer</code> or <code>sap.m.SplitContainer</code> as a direct child added to the Dialog. If there is, the Dialog will turn off <code>scrolling</code> by setting this property to <code>false</code>, automatically ignoring the existing value of the property.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> horizontalScrolling;

					/// <summary>
					/// Indicates if the user can scroll vertically inside the Dialog when the content is bigger than the content area. The Dialog detects if there's <code>sap.m.NavContainer</code>, <code>sap.m.Page</code>, <code>sap.m.ScrollContainer</code> or <code>sap.m.SplitContainer</code> as a direct child added to the Dialog. If there is, the Dialog will turn off <code>scrolling</code> by setting this property to <code>false</code>, automatically ignoring the existing value of this property.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> verticalScrolling;

					/// <summary>
					/// Indicates whether the Dialog is resizable. If this property is set to <code>true</code>, the Dialog will have a resize handler in its bottom right corner. This property has a default value <code>false</code>. The Dialog can be resizable only in desktop mode.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> resizable;

					/// <summary>
					/// Indicates whether the Dialog is draggable. If this property is set to <code>true</code>, the Dialog will be draggable by its header. This property has a default value <code>false</code>. The Dialog can be draggable only in desktop mode.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> draggable;

					/// <summary>
					/// This property expects a function with one parameter of type Promise. In the function, you should call either <code>resolve()</code> or <code>reject()</code> on the Promise object.<br/> The function allows you to define custom behavior which will be executed when the Escape key is pressed. By default, when the Escape key is pressed, the Dialog is immediately closed.
					/// </summary>
					public Union<object, string, sap.ui.@base.ManagedObject.BindPropertyInfo> escapeHandler;

					/// <summary>
					/// The content inside the Dialog.<br/><b>Note:</b> When the content of the Dialog is comprised of controls that use <code>position: absolute</code>, such as <code>SplitContainer</code>, the Dialog has to have either <code>stretch: true</code> or <code>contentHeight</code> set.
					/// </summary>
					public Union<sap.ui.core.Control[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> content;

					/// <summary>
					/// When a <code>subHeader</code> is assigned to the Dialog, it's rendered directly after the main header in the Dialog. The <code>subHeader</code> is out of the content area and won't be scrolled when the content size is bigger than the content area size.
					/// </summary>
					public Union<sap.m.IBar, string, sap.ui.@base.ManagedObject.BindAggregationInfo> subHeader;

					/// <summary>
					/// When it is set, the <code>icon</code>, <code>title</code> and <code>showHeader</code> properties are ignored. Only the <code>customHeader</code> is shown as the header of the Dialog.
					/// </summary>
					public Union<sap.m.IBar, string, sap.ui.@base.ManagedObject.BindAggregationInfo> customHeader;

					/// <summary>
					/// The button which is rendered to the left side (right side in RTL mode) of the <code>endButton</code> in the footer area inside the Dialog. As of version 1.21.1, there's a new aggregation <code>buttons</code> created with which more than 2 buttons can be added to the footer area of the Dialog. If the new <code>buttons</code> aggregation is set, any change made to this aggregation has no effect anymore. When running on a phone, this <code>button</code> (and the <code>endButton</code> together when set) is (are) rendered at the center of the footer area. When running on other platforms, this <code>button</code> (and the <code>endButton</code> together when set) is (are) rendered at the right side (left side in RTL mode) of the footer area.
					/// </summary>
					public Union<sap.m.Button, string, sap.ui.@base.ManagedObject.BindAggregationInfo> beginButton;

					/// <summary>
					/// The button which is rendered to the right side (left side in RTL mode) of the <code>beginButton</code> in the footer area inside the Dialog. As of version 1.21.1, there's a new aggregation <code>buttons<code> created with which more than 2 buttons can be added to the footer area of Dialog. If the new <code>buttons</code> aggregation is set, any change made to this aggregation has no effect anymore. When running on a phone, this <code>button</code> (and the <code>beginButton</code> together when set) is (are) rendered at the center of the footer area. When running on other platforms, this <code>button</code> (and the <code>beginButton</code> together when set) is (are) rendered at the right side (left side in RTL mode) of the footer area.
					/// </summary>
					public Union<sap.m.Button, string, sap.ui.@base.ManagedObject.BindAggregationInfo> endButton;

					/// <summary>
					/// Buttons can be added to the footer area of the Dialog through this aggregation. When this aggregation is set, any change to the <code>beginButton</code> and <code>endButton</code> has no effect anymore. Buttons which are inside this aggregation are aligned at the right side (left side in RTL mode) of the footer instead of in the middle of the footer.
					/// </summary>
					public Union<sap.m.Button[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> buttons;

					/// <summary>
					/// <code>LeftButton</code> is shown at the left edge of the bar in iOS, and at the right side of the bar for the other platforms. Please set this to <code>null</code> if you want to remove the Left button from the bar. And the button is only removed from the bar, not destroyed. When <code>showHeader</code> is set to <code>false</code>, this property will be ignored. Setting <code>leftButton</code> will also set the <code>beginButton</code> internally.
					/// </summary>
					public Union<sap.m.Button, sap.ui.core.ID, string, sap.ui.@base.ManagedObject.BindPropertyInfo> leftButton;

					/// <summary>
					/// <code>RightButton</code> is always shown at the right edge of the bar. Please set this to null if you want to remove the Right button from the bar. And the button is only removed from the bar, not destroyed. When <code>showHeader</code> is set to false, this property will be ignored. Setting <code>rightButton</code> will also set the <code>endButton</code> internally.
					/// </summary>
					public Union<sap.m.Button, sap.ui.core.ID, string, sap.ui.@base.ManagedObject.BindPropertyInfo> rightButton;

					/// <summary>
					/// In the Dialog focus is set first on the <code>leftButton</code> and then on <code>rightButton</code>, when available. If another control needs to get the focus, set the <code>initialFocus</code> with the control which should be focused on. Setting <code>initialFocus</code> to input controls doesn't open the On-Screen keyboard on mobile device as, due to browser limitation, the On-Screen keyboard can't be opened with JavaScript code. The opening of On-Screen keyboard must be triggered by real user action.
					/// </summary>
					public Union<sap.ui.core.Control, sap.ui.core.ID, string, sap.ui.@base.ManagedObject.BindPropertyInfo> initialFocus;

					/// <summary>
					/// Association to controls/IDs which describe this control (see WAI-ARIA attribute aria-describedby).
					/// </summary>
					public Union<sap.ui.core.Control, sap.ui.core.ID[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> ariaDescribedBy;

					/// <summary>
					/// Association to controls/IDs which label this control (see WAI-ARIA attribute aria-labelledby).
					/// </summary>
					public Union<sap.ui.core.Control, sap.ui.core.ID[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> ariaLabelledBy;

					/// <summary>
					/// This event will be fired before the Dialog is opened.
					/// </summary>
					public sap.ui.@base.EventDelegate beforeOpen;

					/// <summary>
					/// This event will be fired after the Dialog is opened.
					/// </summary>
					public sap.ui.@base.EventDelegate afterOpen;

					/// <summary>
					/// This event will be fired before the Dialog is closed.
					/// </summary>
					public sap.m.Dialog.CloseDelegate beforeClose;

					/// <summary>
					/// This event will be fired after the Dialog is closed.
					/// </summary>
					public sap.m.Dialog.CloseDelegate afterClose;

				}

				#endregion

				#region Typed Parameters

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class CloseInfo
				{
					/// <summary>
					/// This indicates the trigger of closing the Dialog. If the Dialog is closed by either the <code>leftButton</code> or the <code>rightButton</code>, the button that closes the Dialog is set to this parameter. Otherwise, the parameter is set to <code>null</code>.
					/// </summary>
					public sap.m.Button origin;

				}

				#endregion

				#region Delegates

				public delegate void CloseDelegate(sap.ui.@base.Event<sap.m.Dialog.CloseInfo> oEvent, object oData);

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new Dialog.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern Dialog(string sId, sap.m.Dialog.Settings mSettings);

				/// <summary>
				/// Constructor for a new Dialog.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern Dialog(string sId);

				/// <summary>
				/// Constructor for a new Dialog.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern Dialog();

				/// <summary>
				/// Constructor for a new Dialog.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern Dialog(sap.m.Dialog.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property icon

				/// <summary>
				/// Gets current value of property {@link #getIcon icon}.
				/// 
				/// Icon displayed in the Dialog header. This <code>icon</code> is invisible on the iOS platform and it is density-aware. You can use the density convention (@2, @1.5, etc.) to provide higher resolution image for higher density screen.
				/// </summary>
				/// <returns>Value of property <code>icon</code></returns>
				public extern virtual sap.ui.core.URI getIcon();

				/// <summary>
				/// Sets a new value for property {@link #getIcon icon}.
				/// 
				/// Icon displayed in the Dialog header. This <code>icon</code> is invisible on the iOS platform and it is density-aware. You can use the density convention (@2, @1.5, etc.) to provide higher resolution image for higher density screen.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sIcon">New value for property <code>icon</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Dialog setIcon(sap.ui.core.URI sIcon);

				#endregion

				#region Methods for Property title

				/// <summary>
				/// Gets current value of property {@link #getTitle title}.
				/// 
				/// Title text appears in the Dialog header.
				/// </summary>
				/// <returns>Value of property <code>title</code></returns>
				public extern virtual string getTitle();

				/// <summary>
				/// Sets a new value for property {@link #getTitle title}.
				/// 
				/// Title text appears in the Dialog header.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sTitle">New value for property <code>title</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Dialog setTitle(string sTitle);

				#endregion

				#region Methods for Property showHeader

				/// <summary>
				/// Gets current value of property {@link #getShowHeader showHeader}.
				/// 
				/// Determines whether the header is shown inside the Dialog. If this property is set to <code>true</code>, the <code>text</code> and <code>icon</code> properties are ignored. This property has a default value <code>true</code>.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>showHeader</code></returns>
				public extern virtual bool getShowHeader();

				/// <summary>
				/// Sets a new value for property {@link #getShowHeader showHeader}.
				/// 
				/// Determines whether the header is shown inside the Dialog. If this property is set to <code>true</code>, the <code>text</code> and <code>icon</code> properties are ignored. This property has a default value <code>true</code>.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bShowHeader">New value for property <code>showHeader</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Dialog setShowHeader(bool bShowHeader);

				#endregion

				#region Methods for Property type

				/// <summary>
				/// Gets current value of property {@link #getType type}.
				/// 
				/// The <code>type</code> of the Dialog. In some themes, the type Message will limit the Dialog width within 480px on tablet and desktop.
				/// 
				/// Default value is <code>Standard</code>.
				/// </summary>
				/// <returns>Value of property <code>type</code></returns>
				public extern virtual sap.m.DialogType getType();

				/// <summary>
				/// Sets a new value for property {@link #getType type}.
				/// 
				/// The <code>type</code> of the Dialog. In some themes, the type Message will limit the Dialog width within 480px on tablet and desktop.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Standard</code>.
				/// </summary>
				/// <param name="sType">New value for property <code>type</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Dialog setType(sap.m.DialogType sType);

				#endregion

				#region Methods for Property state

				/// <summary>
				/// Gets current value of property {@link #getState state}.
				/// 
				/// Affects the <code>icon</code> and the <code>title</code> color. If other than <code>none</code> is set, a predefined icon will be added to the Dialog. Setting the <code>icon</code> property will overwrite the predefined icon. The default value is <code>none</code> which doesn't add any icon to the Dialog control. This property is by now only supported by the blue crystal theme.
				/// 
				/// Default value is <code>None</code>.
				/// </summary>
				/// <returns>Value of property <code>state</code></returns>
				public extern virtual sap.ui.core.ValueState getState();

				/// <summary>
				/// Sets a new value for property {@link #getState state}.
				/// 
				/// Affects the <code>icon</code> and the <code>title</code> color. If other than <code>none</code> is set, a predefined icon will be added to the Dialog. Setting the <code>icon</code> property will overwrite the predefined icon. The default value is <code>none</code> which doesn't add any icon to the Dialog control. This property is by now only supported by the blue crystal theme.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>None</code>.
				/// </summary>
				/// <param name="sState">New value for property <code>state</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Dialog setState(sap.ui.core.ValueState sState);

				#endregion

				#region Methods for Property stretchOnPhone

				/// <summary>
				/// Gets current value of property {@link #getStretchOnPhone stretchOnPhone}.
				/// 
				/// Determines whether the Dialog will be displayed on full screen on a phone.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>stretchOnPhone</code></returns>
				[Obsolete("Deprecated since 1.13.1. Please use the new stretch property instead. This enables a stretched Dialog even on tablet and desktop. If you want to achieve the same effect as <code>stretchOnPhone</code>, please set the stretch with jQuery.device.is.phone, then the Dialog is only stretched when it runs on a phone.")]
				public extern virtual bool getStretchOnPhone();

				/// <summary>
				/// Sets a new value for property {@link #getStretchOnPhone stretchOnPhone}.
				/// 
				/// Determines whether the Dialog will be displayed on full screen on a phone.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bStretchOnPhone">New value for property <code>stretchOnPhone</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.13.1. Please use the new stretch property instead. This enables a stretched Dialog even on tablet and desktop. If you want to achieve the same effect as <code>stretchOnPhone</code>, please set the stretch with jQuery.device.is.phone, then the Dialog is only stretched when it runs on a phone.")]
				public extern virtual sap.m.Dialog setStretchOnPhone(bool bStretchOnPhone);

				#endregion

				#region Methods for Property stretch

				/// <summary>
				/// Gets current value of property {@link #getStretch stretch}.
				/// 
				/// Determines if the Dialog will be stretched to full screen on mobile. On desktop, the Dialog will be stretched to 93% of the viewport. This property is only applicable to a Standard Dialog. Message-type Dialog ignores it.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>stretch</code></returns>
				public extern virtual bool getStretch();

				/// <summary>
				/// Sets a new value for property {@link #getStretch stretch}.
				/// 
				/// Determines if the Dialog will be stretched to full screen on mobile. On desktop, the Dialog will be stretched to 93% of the viewport. This property is only applicable to a Standard Dialog. Message-type Dialog ignores it.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bStretch">New value for property <code>stretch</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Dialog setStretch(bool bStretch);

				#endregion

				#region Methods for Property contentWidth

				/// <summary>
				/// Gets current value of property {@link #getContentWidth contentWidth}.
				/// 
				/// Preferred width of the content in the Dialog. This property affects the width of the Dialog on a phone in landscape mode, a tablet or a desktop, because the Dialog has a fixed width on a phone in portrait mode. If the preferred width is less than the minimum width of the Dialog or more than the available width of the screen, it will be overwritten by the min or max value. The current mininum value of the Dialog width on tablet is 400px.
				/// </summary>
				/// <returns>Value of property <code>contentWidth</code></returns>
				public extern virtual sap.ui.core.CSSSize getContentWidth();

				/// <summary>
				/// Sets a new value for property {@link #getContentWidth contentWidth}.
				/// 
				/// Preferred width of the content in the Dialog. This property affects the width of the Dialog on a phone in landscape mode, a tablet or a desktop, because the Dialog has a fixed width on a phone in portrait mode. If the preferred width is less than the minimum width of the Dialog or more than the available width of the screen, it will be overwritten by the min or max value. The current mininum value of the Dialog width on tablet is 400px.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sContentWidth">New value for property <code>contentWidth</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Dialog setContentWidth(sap.ui.core.CSSSize sContentWidth);

				#endregion

				#region Methods for Property contentHeight

				/// <summary>
				/// Gets current value of property {@link #getContentHeight contentHeight}.
				/// 
				/// Preferred height of the content in the Dialog. If the preferred height is bigger than the available space on a screen, it will be overwritten by the maximum available height on a screen in order to make sure that the Dialog isn't cut off.
				/// </summary>
				/// <returns>Value of property <code>contentHeight</code></returns>
				public extern virtual sap.ui.core.CSSSize getContentHeight();

				/// <summary>
				/// Sets a new value for property {@link #getContentHeight contentHeight}.
				/// 
				/// Preferred height of the content in the Dialog. If the preferred height is bigger than the available space on a screen, it will be overwritten by the maximum available height on a screen in order to make sure that the Dialog isn't cut off.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sContentHeight">New value for property <code>contentHeight</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Dialog setContentHeight(sap.ui.core.CSSSize sContentHeight);

				#endregion

				#region Methods for Property horizontalScrolling

				/// <summary>
				/// Gets current value of property {@link #getHorizontalScrolling horizontalScrolling}.
				/// 
				/// Indicates if the user can scroll horizontally inside the Dialog when the content is bigger than the content area. The Dialog detects if there's <code>sap.m.NavContainer</code>, <code>sap.m.Page</code>, <code>sap.m.ScrollContainer</code> or <code>sap.m.SplitContainer</code> as a direct child added to the Dialog. If there is, the Dialog will turn off <code>scrolling</code> by setting this property to <code>false</code>, automatically ignoring the existing value of the property.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>horizontalScrolling</code></returns>
				public extern virtual bool getHorizontalScrolling();

				/// <summary>
				/// Sets a new value for property {@link #getHorizontalScrolling horizontalScrolling}.
				/// 
				/// Indicates if the user can scroll horizontally inside the Dialog when the content is bigger than the content area. The Dialog detects if there's <code>sap.m.NavContainer</code>, <code>sap.m.Page</code>, <code>sap.m.ScrollContainer</code> or <code>sap.m.SplitContainer</code> as a direct child added to the Dialog. If there is, the Dialog will turn off <code>scrolling</code> by setting this property to <code>false</code>, automatically ignoring the existing value of the property.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bHorizontalScrolling">New value for property <code>horizontalScrolling</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Dialog setHorizontalScrolling(bool bHorizontalScrolling);

				#endregion

				#region Methods for Property verticalScrolling

				/// <summary>
				/// Gets current value of property {@link #getVerticalScrolling verticalScrolling}.
				/// 
				/// Indicates if the user can scroll vertically inside the Dialog when the content is bigger than the content area. The Dialog detects if there's <code>sap.m.NavContainer</code>, <code>sap.m.Page</code>, <code>sap.m.ScrollContainer</code> or <code>sap.m.SplitContainer</code> as a direct child added to the Dialog. If there is, the Dialog will turn off <code>scrolling</code> by setting this property to <code>false</code>, automatically ignoring the existing value of this property.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>verticalScrolling</code></returns>
				public extern virtual bool getVerticalScrolling();

				/// <summary>
				/// Sets a new value for property {@link #getVerticalScrolling verticalScrolling}.
				/// 
				/// Indicates if the user can scroll vertically inside the Dialog when the content is bigger than the content area. The Dialog detects if there's <code>sap.m.NavContainer</code>, <code>sap.m.Page</code>, <code>sap.m.ScrollContainer</code> or <code>sap.m.SplitContainer</code> as a direct child added to the Dialog. If there is, the Dialog will turn off <code>scrolling</code> by setting this property to <code>false</code>, automatically ignoring the existing value of this property.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bVerticalScrolling">New value for property <code>verticalScrolling</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Dialog setVerticalScrolling(bool bVerticalScrolling);

				#endregion

				#region Methods for Property resizable

				/// <summary>
				/// Gets current value of property {@link #getResizable resizable}.
				/// 
				/// Indicates whether the Dialog is resizable. If this property is set to <code>true</code>, the Dialog will have a resize handler in its bottom right corner. This property has a default value <code>false</code>. The Dialog can be resizable only in desktop mode.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>resizable</code></returns>
				public extern virtual bool getResizable();

				/// <summary>
				/// Sets a new value for property {@link #getResizable resizable}.
				/// 
				/// Indicates whether the Dialog is resizable. If this property is set to <code>true</code>, the Dialog will have a resize handler in its bottom right corner. This property has a default value <code>false</code>. The Dialog can be resizable only in desktop mode.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bResizable">New value for property <code>resizable</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Dialog setResizable(bool bResizable);

				#endregion

				#region Methods for Property draggable

				/// <summary>
				/// Gets current value of property {@link #getDraggable draggable}.
				/// 
				/// Indicates whether the Dialog is draggable. If this property is set to <code>true</code>, the Dialog will be draggable by its header. This property has a default value <code>false</code>. The Dialog can be draggable only in desktop mode.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>draggable</code></returns>
				public extern virtual bool getDraggable();

				/// <summary>
				/// Sets a new value for property {@link #getDraggable draggable}.
				/// 
				/// Indicates whether the Dialog is draggable. If this property is set to <code>true</code>, the Dialog will be draggable by its header. This property has a default value <code>false</code>. The Dialog can be draggable only in desktop mode.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bDraggable">New value for property <code>draggable</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Dialog setDraggable(bool bDraggable);

				#endregion

				#region Methods for Property escapeHandler

				/// <summary>
				/// Gets current value of property {@link #getEscapeHandler escapeHandler}.
				/// 
				/// This property expects a function with one parameter of type Promise. In the function, you should call either <code>resolve()</code> or <code>reject()</code> on the Promise object.<br/> The function allows you to define custom behavior which will be executed when the Escape key is pressed. By default, when the Escape key is pressed, the Dialog is immediately closed.
				/// </summary>
				/// <returns>Value of property <code>escapeHandler</code></returns>
				public extern virtual object getEscapeHandler();

				/// <summary>
				/// Sets a new value for property {@link #getEscapeHandler escapeHandler}.
				/// 
				/// This property expects a function with one parameter of type Promise. In the function, you should call either <code>resolve()</code> or <code>reject()</code> on the Promise object.<br/> The function allows you to define custom behavior which will be executed when the Escape key is pressed. By default, when the Escape key is pressed, the Dialog is immediately closed.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="oEscapeHandler">New value for property <code>escapeHandler</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Dialog setEscapeHandler(object oEscapeHandler);

				#endregion

				#region Methods for Aggregation content

				/// <summary>
				/// Gets content of aggregation {@link #getContent content}.
				/// 
				/// The content inside the Dialog.<br/><b>Note:</b> When the content of the Dialog is comprised of controls that use <code>position: absolute</code>, such as <code>SplitContainer</code>, the Dialog has to have either <code>stretch: true</code> or <code>contentHeight</code> set.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.Control[] getContent();

				/// <summary>
				/// Destroys all the content in the aggregation {@link #getContent content}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Dialog destroyContent();

				/// <summary>
				/// Inserts a content into the aggregation {@link #getContent content}.
				/// </summary>
				/// <param name="oContent">The content to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the content should be inserted at; for a negative value of <code>iIndex</code>, the content is inserted at position 0; for a value greater than the current size of the aggregation, the content is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Dialog insertContent(sap.ui.core.Control oContent, int iIndex);

				/// <summary>
				/// Adds some content to the aggregation {@link #getContent content}.
				/// </summary>
				/// <param name="oContent">The content to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Dialog addContent(sap.ui.core.Control oContent);

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

				#region Methods for Aggregation subHeader

				/// <summary>
				/// Gets content of aggregation {@link #getSubHeader subHeader}.
				/// 
				/// When a <code>subHeader</code> is assigned to the Dialog, it's rendered directly after the main header in the Dialog. The <code>subHeader</code> is out of the content area and won't be scrolled when the content size is bigger than the content area size.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.IBar getSubHeader();

				/// <summary>
				/// Destroys the subHeader in the aggregation {@link #getSubHeader subHeader}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Dialog destroySubHeader();

				/// <summary>
				/// Sets the aggregated {@link #getSubHeader subHeader}.
				/// </summary>
				/// <param name="oSubHeader">The subHeader to set</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Dialog setSubHeader(sap.m.IBar oSubHeader);

				#endregion

				#region Methods for Aggregation customHeader

				/// <summary>
				/// Gets content of aggregation {@link #getCustomHeader customHeader}.
				/// 
				/// When it is set, the <code>icon</code>, <code>title</code> and <code>showHeader</code> properties are ignored. Only the <code>customHeader</code> is shown as the header of the Dialog.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.IBar getCustomHeader();

				/// <summary>
				/// Destroys the customHeader in the aggregation {@link #getCustomHeader customHeader}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Dialog destroyCustomHeader();

				/// <summary>
				/// Sets the aggregated {@link #getCustomHeader customHeader}.
				/// </summary>
				/// <param name="oCustomHeader">The customHeader to set</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Dialog setCustomHeader(sap.m.IBar oCustomHeader);

				#endregion

				#region Methods for Aggregation beginButton

				/// <summary>
				/// Gets content of aggregation {@link #getBeginButton beginButton}.
				/// 
				/// The button which is rendered to the left side (right side in RTL mode) of the <code>endButton</code> in the footer area inside the Dialog. As of version 1.21.1, there's a new aggregation <code>buttons</code> created with which more than 2 buttons can be added to the footer area of the Dialog. If the new <code>buttons</code> aggregation is set, any change made to this aggregation has no effect anymore. When running on a phone, this <code>button</code> (and the <code>endButton</code> together when set) is (are) rendered at the center of the footer area. When running on other platforms, this <code>button</code> (and the <code>endButton</code> together when set) is (are) rendered at the right side (left side in RTL mode) of the footer area.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.Button getBeginButton();

				/// <summary>
				/// Destroys the beginButton in the aggregation {@link #getBeginButton beginButton}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Dialog destroyBeginButton();

				/// <summary>
				/// Sets the aggregated {@link #getBeginButton beginButton}.
				/// </summary>
				/// <param name="oBeginButton">The beginButton to set</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Dialog setBeginButton(sap.m.Button oBeginButton);

				#endregion

				#region Methods for Aggregation endButton

				/// <summary>
				/// Gets content of aggregation {@link #getEndButton endButton}.
				/// 
				/// The button which is rendered to the right side (left side in RTL mode) of the <code>beginButton</code> in the footer area inside the Dialog. As of version 1.21.1, there's a new aggregation <code>buttons<code> created with which more than 2 buttons can be added to the footer area of Dialog. If the new <code>buttons</code> aggregation is set, any change made to this aggregation has no effect anymore. When running on a phone, this <code>button</code> (and the <code>beginButton</code> together when set) is (are) rendered at the center of the footer area. When running on other platforms, this <code>button</code> (and the <code>beginButton</code> together when set) is (are) rendered at the right side (left side in RTL mode) of the footer area.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.Button getEndButton();

				/// <summary>
				/// Destroys the endButton in the aggregation {@link #getEndButton endButton}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Dialog destroyEndButton();

				/// <summary>
				/// Sets the aggregated {@link #getEndButton endButton}.
				/// </summary>
				/// <param name="oEndButton">The endButton to set</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Dialog setEndButton(sap.m.Button oEndButton);

				#endregion

				#region Methods for Aggregation buttons

				/// <summary>
				/// Gets content of aggregation {@link #getButtons buttons}.
				/// 
				/// Buttons can be added to the footer area of the Dialog through this aggregation. When this aggregation is set, any change to the <code>beginButton</code> and <code>endButton</code> has no effect anymore. Buttons which are inside this aggregation are aligned at the right side (left side in RTL mode) of the footer instead of in the middle of the footer.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.Button[] getButtons();

				/// <summary>
				/// Destroys all the buttons in the aggregation {@link #getButtons buttons}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Dialog destroyButtons();

				/// <summary>
				/// Inserts a button into the aggregation {@link #getButtons buttons}.
				/// </summary>
				/// <param name="oButton">The button to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the button should be inserted at; for a negative value of <code>iIndex</code>, the button is inserted at position 0; for a value greater than the current size of the aggregation, the button is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Dialog insertButton(sap.m.Button oButton, int iIndex);

				/// <summary>
				/// Adds some button to the aggregation {@link #getButtons buttons}.
				/// </summary>
				/// <param name="oButton">The button to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Dialog addButton(sap.m.Button oButton);

				/// <summary>
				/// Removes a button from the aggregation {@link #getButtons buttons}.
				/// </summary>
				/// <param name="vButton">The button to remove or its index or id</param>
				/// <returns>The removed button or <code>null</code></returns>
				public extern virtual sap.m.Button removeButton(Union<int, string, sap.m.Button> vButton);

				/// <summary>
				/// Checks for the provided <code>sap.m.Button</code> in the aggregation {@link #getButtons buttons}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oButton">The button whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfButton(sap.m.Button oButton);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getButtons buttons}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.m.Button[] removeAllButtons();

				#endregion

				#region Methods for Aggregation _header

				#endregion

				#region Methods for Aggregation _title

				#endregion

				#region Methods for Aggregation _icon

				#endregion

				#region Methods for Aggregation _toolbar

				#endregion

				#region Methods for Aggregation _valueState

				#endregion

				#region Methods for Association leftButton

				/// <summary>
				/// ID of the element which is the current target of the association {@link #getLeftButton leftButton}, or <code>null</code>.
				/// </summary>
				/// <returns></returns>
				[Obsolete("Deprecated since 1.15.1. <code>LeftButton</code> has been deprecated since 1.15.1. Please use the <code>beginButton</code> instead which is more RTL friendly.")]
				public extern virtual sap.ui.core.ID getLeftButton();

				/// <summary>
				/// Sets the associated {@link #getLeftButton leftButton}.
				/// </summary>
				/// <param name="oLeftButton">ID of an element which becomes the new target of this leftButton association; alternatively, an element instance may be given</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.15.1. <code>LeftButton</code> has been deprecated since 1.15.1. Please use the <code>beginButton</code> instead which is more RTL friendly.")]
				public extern virtual sap.m.Dialog setLeftButton(Union<sap.ui.core.ID, sap.m.Button> oLeftButton);

				#endregion

				#region Methods for Association rightButton

				/// <summary>
				/// ID of the element which is the current target of the association {@link #getRightButton rightButton}, or <code>null</code>.
				/// </summary>
				/// <returns></returns>
				[Obsolete("Deprecated since 1.15.1. <code>RightButton</code> has been deprecated since 1.15.1. Please use the <code>endButton</code> instead which is more RTL friendly.")]
				public extern virtual sap.ui.core.ID getRightButton();

				/// <summary>
				/// Sets the associated {@link #getRightButton rightButton}.
				/// </summary>
				/// <param name="oRightButton">ID of an element which becomes the new target of this rightButton association; alternatively, an element instance may be given</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.15.1. <code>RightButton</code> has been deprecated since 1.15.1. Please use the <code>endButton</code> instead which is more RTL friendly.")]
				public extern virtual sap.m.Dialog setRightButton(Union<sap.ui.core.ID, sap.m.Button> oRightButton);

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
				public extern virtual sap.m.Dialog setInitialFocus(Union<sap.ui.core.ID, sap.ui.core.Control> oInitialFocus);

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
				public extern virtual sap.m.Dialog addAriaDescribedBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaDescribedBy);

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
				public extern virtual sap.m.Dialog addAriaLabelledBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaLabelledBy);

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

				#region Methods for Event beforeOpen

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeOpen beforeOpen} event of this <code>sap.m.Dialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Dialog</code> itself.
				/// 
				/// This event will be fired before the Dialog is opened.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.Dialog</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Dialog attachBeforeOpen(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeOpen beforeOpen} event of this <code>sap.m.Dialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Dialog</code> itself.
				/// 
				/// This event will be fired before the Dialog is opened.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Dialog attachBeforeOpen(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeOpen beforeOpen} event of this <code>sap.m.Dialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Dialog</code> itself.
				/// 
				/// This event will be fired before the Dialog is opened.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Dialog attachBeforeOpen(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeOpen beforeOpen} event of this <code>sap.m.Dialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Dialog</code> itself.
				/// 
				/// This event will be fired before the Dialog is opened.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.Dialog</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Dialog attachBeforeOpen(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:beforeOpen beforeOpen} event of this <code>sap.m.Dialog</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Dialog detachBeforeOpen(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:beforeOpen beforeOpen} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Dialog fireBeforeOpen(object mParameters);

				/// <summary>
				/// Fires event {@link #event:beforeOpen beforeOpen} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Dialog fireBeforeOpen();

				#endregion

				#region Methods for Event afterOpen

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterOpen afterOpen} event of this <code>sap.m.Dialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Dialog</code> itself.
				/// 
				/// This event will be fired after the Dialog is opened.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.Dialog</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Dialog attachAfterOpen(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterOpen afterOpen} event of this <code>sap.m.Dialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Dialog</code> itself.
				/// 
				/// This event will be fired after the Dialog is opened.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Dialog attachAfterOpen(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterOpen afterOpen} event of this <code>sap.m.Dialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Dialog</code> itself.
				/// 
				/// This event will be fired after the Dialog is opened.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Dialog attachAfterOpen(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterOpen afterOpen} event of this <code>sap.m.Dialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Dialog</code> itself.
				/// 
				/// This event will be fired after the Dialog is opened.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.Dialog</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Dialog attachAfterOpen(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:afterOpen afterOpen} event of this <code>sap.m.Dialog</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Dialog detachAfterOpen(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:afterOpen afterOpen} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Dialog fireAfterOpen(object mParameters);

				/// <summary>
				/// Fires event {@link #event:afterOpen afterOpen} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Dialog fireAfterOpen();

				#endregion

				#region Methods for Event beforeClose

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeClose beforeClose} event of this <code>sap.m.Dialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Dialog</code> itself.
				/// 
				/// This event will be fired before the Dialog is closed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.Dialog</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Dialog attachBeforeClose(object oData, sap.m.Dialog.CloseDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeClose beforeClose} event of this <code>sap.m.Dialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Dialog</code> itself.
				/// 
				/// This event will be fired before the Dialog is closed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Dialog attachBeforeClose(object oData, sap.m.Dialog.CloseDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeClose beforeClose} event of this <code>sap.m.Dialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Dialog</code> itself.
				/// 
				/// This event will be fired before the Dialog is closed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Dialog attachBeforeClose(sap.m.Dialog.CloseDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeClose beforeClose} event of this <code>sap.m.Dialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Dialog</code> itself.
				/// 
				/// This event will be fired before the Dialog is closed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.Dialog</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Dialog attachBeforeClose(sap.m.Dialog.CloseDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:beforeClose beforeClose} event of this <code>sap.m.Dialog</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Dialog detachBeforeClose(sap.m.Dialog.CloseDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:beforeClose beforeClose} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Dialog fireBeforeClose(sap.m.Dialog.CloseInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:beforeClose beforeClose} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Dialog fireBeforeClose();

				#endregion

				#region Methods for Event afterClose

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterClose afterClose} event of this <code>sap.m.Dialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Dialog</code> itself.
				/// 
				/// This event will be fired after the Dialog is closed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.Dialog</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Dialog attachAfterClose(object oData, sap.m.Dialog.CloseDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterClose afterClose} event of this <code>sap.m.Dialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Dialog</code> itself.
				/// 
				/// This event will be fired after the Dialog is closed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Dialog attachAfterClose(object oData, sap.m.Dialog.CloseDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterClose afterClose} event of this <code>sap.m.Dialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Dialog</code> itself.
				/// 
				/// This event will be fired after the Dialog is closed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Dialog attachAfterClose(sap.m.Dialog.CloseDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterClose afterClose} event of this <code>sap.m.Dialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Dialog</code> itself.
				/// 
				/// This event will be fired after the Dialog is closed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.Dialog</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Dialog attachAfterClose(sap.m.Dialog.CloseDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:afterClose afterClose} event of this <code>sap.m.Dialog</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Dialog detachAfterClose(sap.m.Dialog.CloseDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:afterClose afterClose} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Dialog fireAfterClose(sap.m.Dialog.CloseInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:afterClose afterClose} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Dialog fireAfterClose();

				#endregion

				#region Other methods

				/// <summary>
				/// Returns the custom header instance when the <code>customHeader</code> aggregation is set. Otherwise, it returns the internal managed header instance. This method can be called within composite controls which use <code>sap.m.Dialog<code> inside.
				/// </summary>
				public extern virtual void _getAnyHeader();

				/// <summary>
				/// Close the dialog.
				/// </summary>
				public extern virtual void close();

				/// <summary>
				/// Creates a new subclass of class sap.m.Dialog with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.Dialog with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.Dialog with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.Dialog.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				[Name("getMetadata")]
				public extern static sap.ui.@base.Metadata getMetadataStatic();

				/// <summary>
				/// The method checks if the Dialog is open. It returns <code>true</code> when the Dialog is currently open (this includes opening and closing animations), otherwise it returns <code>false</code>.
				/// </summary>
				/// <returns>boolean</returns>
				public extern virtual bool isOpen();

				/// <summary>
				/// Open the dialog.
				/// </summary>
				public extern virtual void open();

				#endregion

				#endregion

			}
		}
	}
}
