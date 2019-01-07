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
				/// <summary>
				/// An interactive window appearing on request displaying information to the user. The API supports features such as popups with fixed sizes, popups with unlimited width, scrolling bars for large windows, and control nesting (for example, a drop-down list can be included in the window).
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.Dialog")]
				[Obsolete("Deprecated since 1.38. Instead, use the <code>sap.m.Dialog</code> control.")]
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
						/// Outer width of dialog window. When not set and not constrained by one of the width parameters (minWidth/maxWidth), the window size is automatically adapted to the content.
						/// </summary>
						public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> width;

						/// <summary>
						/// Outer height of dialog window. When not set and not constrained by one of the height parameters (minHeight/maxHeight), the window size is automatically adapted to the content.
						/// </summary>
						public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> height;

						/// <summary>
						/// Scroll position from left to right. "0" means leftmost position.
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> scrollLeft;

						/// <summary>
						/// Scroll position from top to bottom. "0" means topmost position.
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> scrollTop;

						/// <summary>
						/// Dialog title displayed in the header.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> title;

						/// <summary>
						/// Padding is theme-dependent. When set to "false", the content extends to the dialog borders.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> applyContentPadding;

						/// <summary>
						/// Displays a close button in the title bar.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showCloseButton;

						/// <summary>
						/// Specifies whether the dialog window can be resized by the user. The dialog frame contains the visual symbol.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> resizable;

						/// <summary>
						/// Minimum outer width of the dialog window. When set, neither the user nor some layout settings can make the window smaller.
						/// </summary>
						public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> minWidth;

						/// <summary>
						/// Minimum outer height of the dialog window. When set, neither the user nor some layout settings can make the window smaller.
						/// </summary>
						public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> minHeight;

						/// <summary>
						/// Maximum outer width of the dialog window. If set, neither the user nor some layout settings can make the window larger.
						/// </summary>
						public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> maxWidth;

						/// <summary>
						/// Maximum outer height of the dialog window. If set, neither the user nor some layout settings can make the window larger.
						/// </summary>
						public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> maxHeight;

						/// <summary>
						/// Specifies the border design. Border design is theme dependent.
						/// </summary>
						public Union<sap.ui.commons.enums.BorderDesign, string, sap.ui.@base.ManagedObject.BindPropertyInfo> contentBorderDesign;

						/// <summary>
						/// Specifies whether the dialog should be modal, or not. In case of <code>true</code> the focus is kept inside the dialog.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> modal;

						/// <summary>
						/// The ARIA role for the control. E.g. for alert-style Dialogs this can be set to "AlertDialog".
						/// </summary>
						public Union<sap.ui.core.AccessibleRole, string, sap.ui.@base.ManagedObject.BindPropertyInfo> accessibleRole;

						/// <summary>
						/// Specifies whether Dialog movement should be restricted to the visible area of the window. This only affects drag&drop movements by the user. This doesn't affect modal dialogs -> modal dialogs always stay in the window.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> keepInWindow;

						/// <summary>
						/// If this property is set to true the Dialog will close if the Dialog loses its focus
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> autoClose;

						/// <summary>
						/// Aggregation of the buttons to display at the bottom of the dialog, for example OK and Cancel. Association defaultButton can be used for one of the defined buttons.
						/// </summary>
						public Union<sap.ui.core.Control[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> buttons;

						/// <summary>
						/// Aggregation of the content of the dialog (one or more controls).
						/// 
						/// Warning: when content is added with width given as a percentage, the Dialog itself should have a width set.
						/// </summary>
						public Union<sap.ui.core.Control[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> content;

						/// <summary>
						/// Defines one of the buttons that have been provided via button aggregation to be the default button. This default button is initially selected, if no control is set via the initialFocus association explicitly. The default button is activated when Enter is pressed in the context of the dialog and when the currently selected element does not handle the Enter event itself.
						/// </summary>
						public Union<sap.ui.commons.Button, sap.ui.core.ID, string, sap.ui.@base.ManagedObject.BindPropertyInfo> defaultButton;

						/// <summary>
						/// Defines the control that shall get the focus when the dialog is opened.
						/// </summary>
						public Union<sap.ui.core.Control, sap.ui.core.ID, string, sap.ui.@base.ManagedObject.BindPropertyInfo> initialFocus;

						/// <summary>
						/// Event is fired when the dialog has been closed (after closing-animation etc.). Event parameters provide information about last position and last size.
						/// </summary>
						public sap.ui.commons.Dialog.ClosedDelegate closed;

					}

					#endregion

					#region Typed Parameters

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class ClosedInfo
					{
						/// <summary>
						/// The width of the dialog when closed
						/// </summary>
						public int width;

						/// <summary>
						/// The height of the dialog when closed
						/// </summary>
						public int height;

						/// <summary>
						/// The top position of the dialog when closed
						/// </summary>
						public int top;

						/// <summary>
						/// The left position of the dialog when closed
						/// </summary>
						public int left;

					}

					#endregion

					#region Delegates

					public delegate void ClosedDelegate(sap.ui.@base.Event<sap.ui.commons.Dialog.ClosedInfo> oEvent, object oData);

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new Dialog.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern Dialog(string sId, sap.ui.commons.Dialog.Settings mSettings);

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
					public extern Dialog(sap.ui.commons.Dialog.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property width

					/// <summary>
					/// Gets current value of property {@link #getWidth width}.
					/// 
					/// Outer width of dialog window. When not set and not constrained by one of the width parameters (minWidth/maxWidth), the window size is automatically adapted to the content.
					/// </summary>
					/// <returns>Value of property <code>width</code></returns>
					public extern virtual sap.ui.core.CSSSize getWidth();

					/// <summary>
					/// Sets a new value for property {@link #getWidth width}.
					/// 
					/// Outer width of dialog window. When not set and not constrained by one of the width parameters (minWidth/maxWidth), the window size is automatically adapted to the content.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sWidth">New value for property <code>width</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Dialog setWidth(sap.ui.core.CSSSize sWidth);

					#endregion

					#region Methods for Property height

					/// <summary>
					/// Gets current value of property {@link #getHeight height}.
					/// 
					/// Outer height of dialog window. When not set and not constrained by one of the height parameters (minHeight/maxHeight), the window size is automatically adapted to the content.
					/// </summary>
					/// <returns>Value of property <code>height</code></returns>
					public extern virtual sap.ui.core.CSSSize getHeight();

					/// <summary>
					/// Sets a new value for property {@link #getHeight height}.
					/// 
					/// Outer height of dialog window. When not set and not constrained by one of the height parameters (minHeight/maxHeight), the window size is automatically adapted to the content.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sHeight">New value for property <code>height</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Dialog setHeight(sap.ui.core.CSSSize sHeight);

					#endregion

					#region Methods for Property scrollLeft

					/// <summary>
					/// Gets current value of property {@link #getScrollLeft scrollLeft}.
					/// 
					/// Scroll position from left to right. "0" means leftmost position.
					/// 
					/// Default value is <code>0</code>.
					/// </summary>
					/// <returns>Value of property <code>scrollLeft</code></returns>
					public extern virtual int getScrollLeft();

					/// <summary>
					/// Sets a new value for property {@link #getScrollLeft scrollLeft}.
					/// 
					/// Scroll position from left to right. "0" means leftmost position.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>0</code>.
					/// </summary>
					/// <param name="iScrollLeft">New value for property <code>scrollLeft</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Dialog setScrollLeft(int iScrollLeft);

					#endregion

					#region Methods for Property scrollTop

					/// <summary>
					/// Gets current value of property {@link #getScrollTop scrollTop}.
					/// 
					/// Scroll position from top to bottom. "0" means topmost position.
					/// 
					/// Default value is <code>0</code>.
					/// </summary>
					/// <returns>Value of property <code>scrollTop</code></returns>
					public extern virtual int getScrollTop();

					/// <summary>
					/// Sets a new value for property {@link #getScrollTop scrollTop}.
					/// 
					/// Scroll position from top to bottom. "0" means topmost position.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>0</code>.
					/// </summary>
					/// <param name="iScrollTop">New value for property <code>scrollTop</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Dialog setScrollTop(int iScrollTop);

					#endregion

					#region Methods for Property title

					/// <summary>
					/// Gets current value of property {@link #getTitle title}.
					/// 
					/// Dialog title displayed in the header.
					/// 
					/// Default value is <code>empty string</code>.
					/// </summary>
					/// <returns>Value of property <code>title</code></returns>
					public extern virtual string getTitle();

					/// <summary>
					/// Sets a new value for property {@link #getTitle title}.
					/// 
					/// Dialog title displayed in the header.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>empty string</code>.
					/// </summary>
					/// <param name="sTitle">New value for property <code>title</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Dialog setTitle(string sTitle);

					#endregion

					#region Methods for Property applyContentPadding

					/// <summary>
					/// Gets current value of property {@link #getApplyContentPadding applyContentPadding}.
					/// 
					/// Padding is theme-dependent. When set to "false", the content extends to the dialog borders.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>applyContentPadding</code></returns>
					public extern virtual bool getApplyContentPadding();

					/// <summary>
					/// Sets a new value for property {@link #getApplyContentPadding applyContentPadding}.
					/// 
					/// Padding is theme-dependent. When set to "false", the content extends to the dialog borders.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bApplyContentPadding">New value for property <code>applyContentPadding</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Dialog setApplyContentPadding(bool bApplyContentPadding);

					#endregion

					#region Methods for Property showCloseButton

					/// <summary>
					/// Gets current value of property {@link #getShowCloseButton showCloseButton}.
					/// 
					/// Displays a close button in the title bar.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>showCloseButton</code></returns>
					public extern virtual bool getShowCloseButton();

					/// <summary>
					/// Sets a new value for property {@link #getShowCloseButton showCloseButton}.
					/// 
					/// Displays a close button in the title bar.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bShowCloseButton">New value for property <code>showCloseButton</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Dialog setShowCloseButton(bool bShowCloseButton);

					#endregion

					#region Methods for Property resizable

					/// <summary>
					/// Gets current value of property {@link #getResizable resizable}.
					/// 
					/// Specifies whether the dialog window can be resized by the user. The dialog frame contains the visual symbol.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>resizable</code></returns>
					public extern virtual bool getResizable();

					/// <summary>
					/// Sets a new value for property {@link #getResizable resizable}.
					/// 
					/// Specifies whether the dialog window can be resized by the user. The dialog frame contains the visual symbol.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bResizable">New value for property <code>resizable</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Dialog setResizable(bool bResizable);

					#endregion

					#region Methods for Property minWidth

					/// <summary>
					/// Gets current value of property {@link #getMinWidth minWidth}.
					/// 
					/// Minimum outer width of the dialog window. When set, neither the user nor some layout settings can make the window smaller.
					/// </summary>
					/// <returns>Value of property <code>minWidth</code></returns>
					public extern virtual sap.ui.core.CSSSize getMinWidth();

					/// <summary>
					/// Sets a new value for property {@link #getMinWidth minWidth}.
					/// 
					/// Minimum outer width of the dialog window. When set, neither the user nor some layout settings can make the window smaller.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sMinWidth">New value for property <code>minWidth</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Dialog setMinWidth(sap.ui.core.CSSSize sMinWidth);

					#endregion

					#region Methods for Property minHeight

					/// <summary>
					/// Gets current value of property {@link #getMinHeight minHeight}.
					/// 
					/// Minimum outer height of the dialog window. When set, neither the user nor some layout settings can make the window smaller.
					/// </summary>
					/// <returns>Value of property <code>minHeight</code></returns>
					public extern virtual sap.ui.core.CSSSize getMinHeight();

					/// <summary>
					/// Sets a new value for property {@link #getMinHeight minHeight}.
					/// 
					/// Minimum outer height of the dialog window. When set, neither the user nor some layout settings can make the window smaller.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sMinHeight">New value for property <code>minHeight</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Dialog setMinHeight(sap.ui.core.CSSSize sMinHeight);

					#endregion

					#region Methods for Property maxWidth

					/// <summary>
					/// Gets current value of property {@link #getMaxWidth maxWidth}.
					/// 
					/// Maximum outer width of the dialog window. If set, neither the user nor some layout settings can make the window larger.
					/// </summary>
					/// <returns>Value of property <code>maxWidth</code></returns>
					public extern virtual sap.ui.core.CSSSize getMaxWidth();

					/// <summary>
					/// Sets a new value for property {@link #getMaxWidth maxWidth}.
					/// 
					/// Maximum outer width of the dialog window. If set, neither the user nor some layout settings can make the window larger.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sMaxWidth">New value for property <code>maxWidth</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Dialog setMaxWidth(sap.ui.core.CSSSize sMaxWidth);

					#endregion

					#region Methods for Property maxHeight

					/// <summary>
					/// Gets current value of property {@link #getMaxHeight maxHeight}.
					/// 
					/// Maximum outer height of the dialog window. If set, neither the user nor some layout settings can make the window larger.
					/// </summary>
					/// <returns>Value of property <code>maxHeight</code></returns>
					public extern virtual sap.ui.core.CSSSize getMaxHeight();

					/// <summary>
					/// Sets a new value for property {@link #getMaxHeight maxHeight}.
					/// 
					/// Maximum outer height of the dialog window. If set, neither the user nor some layout settings can make the window larger.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sMaxHeight">New value for property <code>maxHeight</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Dialog setMaxHeight(sap.ui.core.CSSSize sMaxHeight);

					#endregion

					#region Methods for Property contentBorderDesign

					/// <summary>
					/// Gets current value of property {@link #getContentBorderDesign contentBorderDesign}.
					/// 
					/// Specifies the border design. Border design is theme dependent.
					/// 
					/// Default value is <code>None</code>.
					/// </summary>
					/// <returns>Value of property <code>contentBorderDesign</code></returns>
					public extern virtual sap.ui.commons.enums.BorderDesign getContentBorderDesign();

					/// <summary>
					/// Sets a new value for property {@link #getContentBorderDesign contentBorderDesign}.
					/// 
					/// Specifies the border design. Border design is theme dependent.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>None</code>.
					/// </summary>
					/// <param name="sContentBorderDesign">New value for property <code>contentBorderDesign</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Dialog setContentBorderDesign(sap.ui.commons.enums.BorderDesign sContentBorderDesign);

					#endregion

					#region Methods for Property modal

					/// <summary>
					/// Gets current value of property {@link #getModal modal}.
					/// 
					/// Specifies whether the dialog should be modal, or not. In case of <code>true</code> the focus is kept inside the dialog.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>modal</code></returns>
					public extern virtual bool getModal();

					/// <summary>
					/// Sets a new value for property {@link #getModal modal}.
					/// 
					/// Specifies whether the dialog should be modal, or not. In case of <code>true</code> the focus is kept inside the dialog.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bModal">New value for property <code>modal</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Dialog setModal(bool bModal);

					#endregion

					#region Methods for Property accessibleRole

					/// <summary>
					/// Gets current value of property {@link #getAccessibleRole accessibleRole}.
					/// 
					/// The ARIA role for the control. E.g. for alert-style Dialogs this can be set to "AlertDialog".
					/// 
					/// Default value is <code>Dialog</code>.
					/// </summary>
					/// <returns>Value of property <code>accessibleRole</code></returns>
					public extern virtual sap.ui.core.AccessibleRole getAccessibleRole();

					/// <summary>
					/// Sets a new value for property {@link #getAccessibleRole accessibleRole}.
					/// 
					/// The ARIA role for the control. E.g. for alert-style Dialogs this can be set to "AlertDialog".
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>Dialog</code>.
					/// </summary>
					/// <param name="sAccessibleRole">New value for property <code>accessibleRole</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Dialog setAccessibleRole(sap.ui.core.AccessibleRole sAccessibleRole);

					#endregion

					#region Methods for Property keepInWindow

					/// <summary>
					/// Gets current value of property {@link #getKeepInWindow keepInWindow}.
					/// 
					/// Specifies whether Dialog movement should be restricted to the visible area of the window. This only affects drag&drop movements by the user. This doesn't affect modal dialogs -> modal dialogs always stay in the window.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>keepInWindow</code></returns>
					public extern virtual bool getKeepInWindow();

					/// <summary>
					/// Sets a new value for property {@link #getKeepInWindow keepInWindow}.
					/// 
					/// Specifies whether Dialog movement should be restricted to the visible area of the window. This only affects drag&drop movements by the user. This doesn't affect modal dialogs -> modal dialogs always stay in the window.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bKeepInWindow">New value for property <code>keepInWindow</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Dialog setKeepInWindow(bool bKeepInWindow);

					#endregion

					#region Methods for Property autoClose

					/// <summary>
					/// Gets current value of property {@link #getAutoClose autoClose}.
					/// 
					/// If this property is set to true the Dialog will close if the Dialog loses its focus
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>autoClose</code></returns>
					public extern virtual bool getAutoClose();

					/// <summary>
					/// Sets a new value for property {@link #getAutoClose autoClose}.
					/// 
					/// If this property is set to true the Dialog will close if the Dialog loses its focus
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bAutoClose">New value for property <code>autoClose</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Dialog setAutoClose(bool bAutoClose);

					#endregion

					#region Methods for Aggregation buttons

					/// <summary>
					/// Gets content of aggregation {@link #getButtons buttons}.
					/// 
					/// Aggregation of the buttons to display at the bottom of the dialog, for example OK and Cancel. Association defaultButton can be used for one of the defined buttons.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.Control[] getButtons();

					/// <summary>
					/// Destroys all the buttons in the aggregation {@link #getButtons buttons}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Dialog destroyButtons();

					/// <summary>
					/// Inserts a button into the aggregation {@link #getButtons buttons}.
					/// </summary>
					/// <param name="oButton">The button to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the button should be inserted at; for a negative value of <code>iIndex</code>, the button is inserted at position 0; for a value greater than the current size of the aggregation, the button is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Dialog insertButton(sap.ui.core.Control oButton, int iIndex);

					/// <summary>
					/// Adds some button to the aggregation {@link #getButtons buttons}.
					/// </summary>
					/// <param name="oButton">The button to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Dialog addButton(sap.ui.core.Control oButton);

					/// <summary>
					/// Removes a button from the aggregation {@link #getButtons buttons}.
					/// </summary>
					/// <param name="vButton">The button to remove or its index or id</param>
					/// <returns>The removed button or <code>null</code></returns>
					public extern virtual sap.ui.core.Control removeButton(Union<int, string, sap.ui.core.Control> vButton);

					/// <summary>
					/// Checks for the provided <code>sap.ui.core.Control</code> in the aggregation {@link #getButtons buttons}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oButton">The button whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfButton(sap.ui.core.Control oButton);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getButtons buttons}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.core.Control[] removeAllButtons();

					#endregion

					#region Methods for Aggregation content

					/// <summary>
					/// Gets content of aggregation {@link #getContent content}.
					/// 
					/// Aggregation of the content of the dialog (one or more controls).
					/// 
					/// Warning: when content is added with width given as a percentage, the Dialog itself should have a width set.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.Control[] getContent();

					/// <summary>
					/// Destroys all the content in the aggregation {@link #getContent content}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Dialog destroyContent();

					/// <summary>
					/// Inserts a content into the aggregation {@link #getContent content}.
					/// </summary>
					/// <param name="oContent">The content to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the content should be inserted at; for a negative value of <code>iIndex</code>, the content is inserted at position 0; for a value greater than the current size of the aggregation, the content is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Dialog insertContent(sap.ui.core.Control oContent, int iIndex);

					/// <summary>
					/// Adds some content to the aggregation {@link #getContent content}.
					/// </summary>
					/// <param name="oContent">The content to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Dialog addContent(sap.ui.core.Control oContent);

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

					#region Methods for Association defaultButton

					/// <summary>
					/// ID of the element which is the current target of the association {@link #getDefaultButton defaultButton}, or <code>null</code>.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.ID getDefaultButton();

					/// <summary>
					/// Sets the associated {@link #getDefaultButton defaultButton}.
					/// </summary>
					/// <param name="oDefaultButton">ID of an element which becomes the new target of this defaultButton association; alternatively, an element instance may be given</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Dialog setDefaultButton(Union<sap.ui.core.ID, sap.ui.commons.Button> oDefaultButton);

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
					public extern virtual sap.ui.commons.Dialog setInitialFocus(Union<sap.ui.core.ID, sap.ui.core.Control> oInitialFocus);

					#endregion

					#region Methods for Event closed

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:closed closed} event of this <code>sap.ui.commons.Dialog</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.Dialog</code> itself.
					/// 
					/// Event is fired when the dialog has been closed (after closing-animation etc.). Event parameters provide information about last position and last size.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.Dialog</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Dialog attachClosed(object oData, sap.ui.commons.Dialog.ClosedDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:closed closed} event of this <code>sap.ui.commons.Dialog</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.Dialog</code> itself.
					/// 
					/// Event is fired when the dialog has been closed (after closing-animation etc.). Event parameters provide information about last position and last size.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Dialog attachClosed(object oData, sap.ui.commons.Dialog.ClosedDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:closed closed} event of this <code>sap.ui.commons.Dialog</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.Dialog</code> itself.
					/// 
					/// Event is fired when the dialog has been closed (after closing-animation etc.). Event parameters provide information about last position and last size.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Dialog attachClosed(sap.ui.commons.Dialog.ClosedDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:closed closed} event of this <code>sap.ui.commons.Dialog</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.Dialog</code> itself.
					/// 
					/// Event is fired when the dialog has been closed (after closing-animation etc.). Event parameters provide information about last position and last size.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.Dialog</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Dialog attachClosed(sap.ui.commons.Dialog.ClosedDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:closed closed} event of this <code>sap.ui.commons.Dialog</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Dialog detachClosed(sap.ui.commons.Dialog.ClosedDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:closed closed} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Dialog fireClosed(sap.ui.commons.Dialog.ClosedInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:closed closed} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Dialog fireClosed();

					#endregion

					#region Other methods

					/// <summary>
					/// Closes the dialog control instance.
					/// </summary>
					public extern virtual void close();

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.Dialog with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.Dialog with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.Dialog with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Determines whether the dialog is currently enabled or not.
					/// 
					/// Applications can't control the enabled state via a property. A dialog is implicitly enabled depending on its <code>openState</code>. Descendant controls that honor the enabled state of their ancestors will appear disabled after the dialog is closed.
					/// </summary>
					/// <returns>indicates whether the dialog is currently enabled or not.</returns>
					public extern virtual bool getEnabled();

					/// <summary>
					/// Returns a metadata object for class sap.ui.commons.Dialog.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					[Name("getMetadata")]
					public extern static sap.ui.@base.Metadata getMetadataStatic();

					/// <summary>
					/// Indicates whether the Dialog is currently open, closed, or transitioning between these states.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.OpenState getOpenState();

					/// <summary>
					/// Indicates whether the Dialog is open (this includes opening and closing animations). For more detailed information about the current state check Dialog.getOpenState().
					/// </summary>
					/// <returns></returns>
					public extern virtual bool isOpen();

					/// <summary>
					/// Opens the dialog control instance.
					/// </summary>
					public extern virtual void open();

					#endregion

					#endregion

				}
			}
		}
	}
}
