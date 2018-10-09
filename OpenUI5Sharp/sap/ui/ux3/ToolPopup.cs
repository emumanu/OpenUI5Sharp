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
			public static partial class ux3
			{
				/// <summary>
				/// A popup which the user can open from the Shell's tool pane. Generally, the starting point would be an icon. For this pop up, buttons can be defined with any text; therefore, it has the same purpose and similar look like any common dialog box. A ToolPopup can have any content. Depending on the application type and design, the structure of the texts and input fields can be for example form-like.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.ux3.ToolPopup")]
				[Obsolete("Deprecated since 1.38. Instead, use the <code>sap.m.Popup</code> control.")]
				public partial class ToolPopup : sap.ui.core.Control, sap.ui.core.PopupInterface
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
						/// Determines the title displayed in the pop up window
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> title;

						/// <summary>
						/// This property is relevant for Shell use: The URL to the icon displayed in the tool area which is used to open the ToolPopup. The recommended size is 32x32px, including some transparent border. Therefore, the content will cover about 20x20px.
						/// </summary>
						public Union<sap.ui.core.URI, string, sap.ui.@base.ManagedObject.BindPropertyInfo> icon;

						/// <summary>
						/// This property is relevant for Shell use: The URL to the icon in hover state, displayed in the tool area which is used to open the popup.
						/// </summary>
						public Union<sap.ui.core.URI, string, sap.ui.@base.ManagedObject.BindPropertyInfo> iconHover;

						/// <summary>
						/// This property is relevant for Shell use: The URL to the icon in selected state displayed in the tool area which is used to open the popup. If no selected icon is given, the hover icon is used.
						/// </summary>
						public Union<sap.ui.core.URI, string, sap.ui.@base.ManagedObject.BindPropertyInfo> iconSelected;

						/// <summary>
						/// Specifies whether the popup is modal and blocks any user-interaction with controls in the background. Changing this property while the ToolPopup is open will not have any effect. Please don't use "modal" and "autoclose" at the same time. In this case a warning will be prompted to the console and "autoclose" won't be used.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> modal;

						/// <summary>
						/// Specifies whether the ToolPopup has a dark or bright background. If set to true the background and borders will be dark. If false they will be bright. This property only has an effect for the GoldReflection-theme.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> inverted;

						/// <summary>
						/// Determines whether the ToolPopup will auto close when it loses focus. If the user e.g. clicks outside of the ToolPopup it will be closed. Please don't use "modal" and "autoclose" at the same time. In this case a warning will be prompted to the console and "autoclose" won't be used.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> autoClose;

						/// <summary>
						/// Forces a maximum height of the ToolPopup in pixels. If the ToolPopup content is higher than the ToolPopup, the content will be scrollable.
						/// </summary>
						public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> maxHeight;

						/// <summary>
						/// Forces a maximum width of the ToolPopup in pixels.
						/// </summary>
						public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> maxWidth;

						/// <summary>
						/// Time in milliseconds for the open animation.
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> openDuration;

						/// <summary>
						/// Time in milliseconds for the close animation.
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> closeDuration;

						/// <summary>
						/// Defines the buttons to appear in the popup
						/// </summary>
						public Union<sap.ui.core.Control[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> buttons;

						/// <summary>
						/// Defines the content of the popup
						/// </summary>
						public Union<sap.ui.core.Control[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> content;

						/// <summary>
						/// Defines the control that will get the focus when the ToolPopup is opened.
						/// </summary>
						public Union<sap.ui.core.Control, sap.ui.core.ID, string, sap.ui.@base.ManagedObject.BindPropertyInfo> initialFocus;

						/// <summary>
						/// This property is relevant for stand-alone use: This association needs to be set if the ToolPopup should not be opened by/with the Shell. This association contains the instance of the control that assigns the ToolPopup's position.
						/// </summary>
						public Union<sap.ui.core.Control, sap.ui.core.ID, string, sap.ui.@base.ManagedObject.BindPropertyInfo> opener;

						/// <summary>
						/// Defines one of the buttons that have been provided via button aggregation to be the default button. This default button is initially selected, if no control is set via the initialFocus association explicitly. The default button is activated when Enter is pressed in the context of the dialog and when the currently selected element does not handle the Enter event itself.
						/// </summary>
						public Union<sap.ui.core.Control, sap.ui.core.ID, string, sap.ui.@base.ManagedObject.BindPropertyInfo> defaultButton;

						/// <summary>
						/// Event is fired when the popup opens
						/// </summary>
						public sap.ui.@base.EventDelegate open;

						/// <summary>
						/// Event is fired when the popup closes because the user pressed Escape or the ToolPopup Button in the Shell. This is called before the closing animation.
						/// </summary>
						public sap.ui.@base.EventDelegate close;

						/// <summary>
						/// Event is fired whenever the user clicks the Enter or the Enter key inside the pop up
						/// </summary>
						public sap.ui.ux3.ToolPopup.EnterDelegate enter;

						/// <summary>
						/// Event is fired when one of the icon properties is modified (Note: The icon is not rendered by the ToolPopup). To be used by other controls which want to update the icon in their UI.
						/// </summary>
						public sap.ui.@base.EventDelegate iconChanged;

						/// <summary>
						/// This event is fired after the ToolPopup has finished its closing animation. It is called for EVERY close, regardless of whether the user has triggered the close or whether the ToolPopup was closed via API call.
						/// </summary>
						public sap.ui.@base.EventDelegate closed;

						/// <summary>
						/// Event is being fired after the ToolPopup has been opened.
						/// </summary>
						public sap.ui.@base.EventDelegate opened;

					}

					#endregion

					#region Typed Parameters

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class EnterInfo
					{
						/// <summary>
						/// The onsapenter event, received by the pop up
						/// </summary>
						public object originalEvent;

						/// <summary>
						/// The control that was focused when the user pressed the Enter key (may be null)
						/// </summary>
						public sap.ui.core.Control originalSrcControl;

					}

					#endregion

					#region Delegates

					public delegate void EnterDelegate(sap.ui.@base.Event<sap.ui.ux3.ToolPopup.EnterInfo> oEvent, object oData);

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new ToolPopup.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern ToolPopup(string sId, sap.ui.ux3.ToolPopup.Settings mSettings);

					/// <summary>
					/// Constructor for a new ToolPopup.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					public extern ToolPopup(string sId);

					/// <summary>
					/// Constructor for a new ToolPopup.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern ToolPopup();

					/// <summary>
					/// Constructor for a new ToolPopup.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern ToolPopup(sap.ui.ux3.ToolPopup.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property title

					/// <summary>
					/// Gets current value of property {@link #getTitle title}.
					/// 
					/// Determines the title displayed in the pop up window
					/// </summary>
					/// <returns>Value of property <code>title</code></returns>
					public extern virtual string getTitle();

					/// <summary>
					/// Sets a new value for property {@link #getTitle title}.
					/// 
					/// Determines the title displayed in the pop up window
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sTitle">New value for property <code>title</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ToolPopup setTitle(string sTitle);

					#endregion

					#region Methods for Property icon

					/// <summary>
					/// Gets current value of property {@link #getIcon icon}.
					/// 
					/// This property is relevant for Shell use: The URL to the icon displayed in the tool area which is used to open the ToolPopup. The recommended size is 32x32px, including some transparent border. Therefore, the content will cover about 20x20px.
					/// </summary>
					/// <returns>Value of property <code>icon</code></returns>
					public extern virtual sap.ui.core.URI getIcon();

					#endregion

					#region Methods for Property iconHover

					/// <summary>
					/// Gets current value of property {@link #getIconHover iconHover}.
					/// 
					/// This property is relevant for Shell use: The URL to the icon in hover state, displayed in the tool area which is used to open the popup.
					/// </summary>
					/// <returns>Value of property <code>iconHover</code></returns>
					public extern virtual sap.ui.core.URI getIconHover();

					#endregion

					#region Methods for Property iconSelected

					#endregion

					#region Methods for Property modal

					/// <summary>
					/// Gets current value of property {@link #getModal modal}.
					/// 
					/// Specifies whether the popup is modal and blocks any user-interaction with controls in the background. Changing this property while the ToolPopup is open will not have any effect. Please don't use "modal" and "autoclose" at the same time. In this case a warning will be prompted to the console and "autoclose" won't be used.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>modal</code></returns>
					public extern virtual bool getModal();

					/// <summary>
					/// Sets a new value for property {@link #getModal modal}.
					/// 
					/// Specifies whether the popup is modal and blocks any user-interaction with controls in the background. Changing this property while the ToolPopup is open will not have any effect. Please don't use "modal" and "autoclose" at the same time. In this case a warning will be prompted to the console and "autoclose" won't be used.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bModal">New value for property <code>modal</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ToolPopup setModal(bool bModal);

					#endregion

					#region Methods for Property inverted

					/// <summary>
					/// Gets current value of property {@link #getInverted inverted}.
					/// 
					/// Specifies whether the ToolPopup has a dark or bright background. If set to true the background and borders will be dark. If false they will be bright. This property only has an effect for the GoldReflection-theme.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>inverted</code></returns>
					public extern virtual bool getInverted();

					/// <summary>
					/// Sets a new value for property {@link #getInverted inverted}.
					/// 
					/// Specifies whether the ToolPopup has a dark or bright background. If set to true the background and borders will be dark. If false they will be bright. This property only has an effect for the GoldReflection-theme.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bInverted">New value for property <code>inverted</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ToolPopup setInverted(bool bInverted);

					#endregion

					#region Methods for Property autoClose

					/// <summary>
					/// Gets current value of property {@link #getAutoClose autoClose}.
					/// 
					/// Determines whether the ToolPopup will auto close when it loses focus. If the user e.g. clicks outside of the ToolPopup it will be closed. Please don't use "modal" and "autoclose" at the same time. In this case a warning will be prompted to the console and "autoclose" won't be used.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>autoClose</code></returns>
					public extern virtual bool getAutoClose();

					/// <summary>
					/// Sets a new value for property {@link #getAutoClose autoClose}.
					/// 
					/// Determines whether the ToolPopup will auto close when it loses focus. If the user e.g. clicks outside of the ToolPopup it will be closed. Please don't use "modal" and "autoclose" at the same time. In this case a warning will be prompted to the console and "autoclose" won't be used.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bAutoClose">New value for property <code>autoClose</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ToolPopup setAutoClose(bool bAutoClose);

					#endregion

					#region Methods for Property maxHeight

					/// <summary>
					/// Gets current value of property {@link #getMaxHeight maxHeight}.
					/// 
					/// Forces a maximum height of the ToolPopup in pixels. If the ToolPopup content is higher than the ToolPopup, the content will be scrollable.
					/// </summary>
					/// <returns>Value of property <code>maxHeight</code></returns>
					public extern virtual sap.ui.core.CSSSize getMaxHeight();

					/// <summary>
					/// Sets a new value for property {@link #getMaxHeight maxHeight}.
					/// 
					/// Forces a maximum height of the ToolPopup in pixels. If the ToolPopup content is higher than the ToolPopup, the content will be scrollable.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sMaxHeight">New value for property <code>maxHeight</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ToolPopup setMaxHeight(sap.ui.core.CSSSize sMaxHeight);

					#endregion

					#region Methods for Property maxWidth

					/// <summary>
					/// Gets current value of property {@link #getMaxWidth maxWidth}.
					/// 
					/// Forces a maximum width of the ToolPopup in pixels.
					/// </summary>
					/// <returns>Value of property <code>maxWidth</code></returns>
					public extern virtual sap.ui.core.CSSSize getMaxWidth();

					#endregion

					#region Methods for Property openDuration

					/// <summary>
					/// Gets current value of property {@link #getOpenDuration openDuration}.
					/// 
					/// Time in milliseconds for the open animation.
					/// 
					/// Default value is <code>400</code>.
					/// </summary>
					/// <returns>Value of property <code>openDuration</code></returns>
					public extern virtual int getOpenDuration();

					/// <summary>
					/// Sets a new value for property {@link #getOpenDuration openDuration}.
					/// 
					/// Time in milliseconds for the open animation.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>400</code>.
					/// </summary>
					/// <param name="iOpenDuration">New value for property <code>openDuration</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ToolPopup setOpenDuration(int iOpenDuration);

					#endregion

					#region Methods for Property closeDuration

					/// <summary>
					/// Gets current value of property {@link #getCloseDuration closeDuration}.
					/// 
					/// Time in milliseconds for the close animation.
					/// 
					/// Default value is <code>400</code>.
					/// </summary>
					/// <returns>Value of property <code>closeDuration</code></returns>
					public extern virtual int getCloseDuration();

					/// <summary>
					/// Sets a new value for property {@link #getCloseDuration closeDuration}.
					/// 
					/// Time in milliseconds for the close animation.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>400</code>.
					/// </summary>
					/// <param name="iCloseDuration">New value for property <code>closeDuration</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ToolPopup setCloseDuration(int iCloseDuration);

					#endregion

					#region Methods for Aggregation buttons

					/// <summary>
					/// Gets content of aggregation {@link #getButtons buttons}.
					/// 
					/// Defines the buttons to appear in the popup
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.Control[] getButtons();

					/// <summary>
					/// Destroys all the buttons in the aggregation {@link #getButtons buttons}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ToolPopup destroyButtons();

					/// <summary>
					/// Inserts a button into the aggregation {@link #getButtons buttons}.
					/// </summary>
					/// <param name="oButton">The button to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the button should be inserted at; for a negative value of <code>iIndex</code>, the button is inserted at position 0; for a value greater than the current size of the aggregation, the button is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ToolPopup insertButton(sap.ui.core.Control oButton, int iIndex);

					/// <summary>
					/// Adds some button to the aggregation {@link #getButtons buttons}.
					/// </summary>
					/// <param name="oButton">The button to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ToolPopup addButton(sap.ui.core.Control oButton);

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
					/// Defines the content of the popup
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.Control[] getContent();

					/// <summary>
					/// Destroys all the content in the aggregation {@link #getContent content}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ToolPopup destroyContent();

					/// <summary>
					/// Inserts a content into the aggregation {@link #getContent content}.
					/// </summary>
					/// <param name="oContent">The content to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the content should be inserted at; for a negative value of <code>iIndex</code>, the content is inserted at position 0; for a value greater than the current size of the aggregation, the content is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ToolPopup insertContent(sap.ui.core.Control oContent, int iIndex);

					/// <summary>
					/// Adds some content to the aggregation {@link #getContent content}.
					/// </summary>
					/// <param name="oContent">The content to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ToolPopup addContent(sap.ui.core.Control oContent);

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
					public extern virtual sap.ui.ux3.ToolPopup setInitialFocus(Union<sap.ui.core.ID, sap.ui.core.Control> oInitialFocus);

					#endregion

					#region Methods for Association opener

					/// <summary>
					/// ID of the element which is the current target of the association {@link #getOpener opener}, or <code>null</code>.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.ID getOpener();

					/// <summary>
					/// Sets the associated {@link #getOpener opener}.
					/// </summary>
					/// <param name="oOpener">ID of an element which becomes the new target of this opener association; alternatively, an element instance may be given</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ToolPopup setOpener(Union<sap.ui.core.ID, sap.ui.core.Control> oOpener);

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
					public extern virtual sap.ui.ux3.ToolPopup setDefaultButton(Union<sap.ui.core.ID, sap.ui.core.Control> oDefaultButton);

					#endregion

					#region Methods for Event open

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:open open} event of this <code>sap.ui.ux3.ToolPopup</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.ToolPopup</code> itself.
					/// 
					/// Event is fired when the popup opens
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.ToolPopup</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ToolPopup attachOpen(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:open open} event of this <code>sap.ui.ux3.ToolPopup</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.ToolPopup</code> itself.
					/// 
					/// Event is fired when the popup opens
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ToolPopup attachOpen(object oData, sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:open open} event of this <code>sap.ui.ux3.ToolPopup</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.ToolPopup</code> itself.
					/// 
					/// Event is fired when the popup opens
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ToolPopup attachOpen(sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:open open} event of this <code>sap.ui.ux3.ToolPopup</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.ToolPopup</code> itself.
					/// 
					/// Event is fired when the popup opens
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.ToolPopup</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ToolPopup attachOpen(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:open open} event of this <code>sap.ui.ux3.ToolPopup</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ToolPopup detachOpen(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:open open} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ToolPopup fireOpen(object mParameters);

					/// <summary>
					/// Fires event {@link #event:open open} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ToolPopup fireOpen();

					#endregion

					#region Methods for Event close

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:close close} event of this <code>sap.ui.ux3.ToolPopup</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.ToolPopup</code> itself.
					/// 
					/// Event is fired when the popup closes because the user pressed Escape or the ToolPopup Button in the Shell. This is called before the closing animation.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.ToolPopup</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ToolPopup attachClose(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:close close} event of this <code>sap.ui.ux3.ToolPopup</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.ToolPopup</code> itself.
					/// 
					/// Event is fired when the popup closes because the user pressed Escape or the ToolPopup Button in the Shell. This is called before the closing animation.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ToolPopup attachClose(object oData, sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:close close} event of this <code>sap.ui.ux3.ToolPopup</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.ToolPopup</code> itself.
					/// 
					/// Event is fired when the popup closes because the user pressed Escape or the ToolPopup Button in the Shell. This is called before the closing animation.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ToolPopup attachClose(sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:close close} event of this <code>sap.ui.ux3.ToolPopup</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.ToolPopup</code> itself.
					/// 
					/// Event is fired when the popup closes because the user pressed Escape or the ToolPopup Button in the Shell. This is called before the closing animation.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.ToolPopup</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ToolPopup attachClose(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:close close} event of this <code>sap.ui.ux3.ToolPopup</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ToolPopup detachClose(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:close close} to attached listeners.
					/// 
					/// Listeners may prevent the default action of this event by using the <code>preventDefault</code>-method on the event object.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Whether or not to prevent the default action</returns>
					public extern virtual bool fireClose(object mParameters);

					/// <summary>
					/// Fires event {@link #event:close close} to attached listeners.
					/// 
					/// Listeners may prevent the default action of this event by using the <code>preventDefault</code>-method on the event object.
					/// </summary>
					/// <returns>Whether or not to prevent the default action</returns>
					public extern virtual bool fireClose();

					#endregion

					#region Methods for Event enter

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:enter enter} event of this <code>sap.ui.ux3.ToolPopup</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.ToolPopup</code> itself.
					/// 
					/// Event is fired whenever the user clicks the Enter or the Enter key inside the pop up
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.ToolPopup</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ToolPopup attachEnter(object oData, sap.ui.ux3.ToolPopup.EnterDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:enter enter} event of this <code>sap.ui.ux3.ToolPopup</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.ToolPopup</code> itself.
					/// 
					/// Event is fired whenever the user clicks the Enter or the Enter key inside the pop up
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ToolPopup attachEnter(object oData, sap.ui.ux3.ToolPopup.EnterDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:enter enter} event of this <code>sap.ui.ux3.ToolPopup</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.ToolPopup</code> itself.
					/// 
					/// Event is fired whenever the user clicks the Enter or the Enter key inside the pop up
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ToolPopup attachEnter(sap.ui.ux3.ToolPopup.EnterDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:enter enter} event of this <code>sap.ui.ux3.ToolPopup</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.ToolPopup</code> itself.
					/// 
					/// Event is fired whenever the user clicks the Enter or the Enter key inside the pop up
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.ToolPopup</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ToolPopup attachEnter(sap.ui.ux3.ToolPopup.EnterDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:enter enter} event of this <code>sap.ui.ux3.ToolPopup</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ToolPopup detachEnter(sap.ui.ux3.ToolPopup.EnterDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:enter enter} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ToolPopup fireEnter(sap.ui.ux3.ToolPopup.EnterInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:enter enter} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ToolPopup fireEnter();

					#endregion

					#region Methods for Event iconChanged

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:iconChanged iconChanged} event of this <code>sap.ui.ux3.ToolPopup</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.ToolPopup</code> itself.
					/// 
					/// Event is fired when one of the icon properties is modified (Note: The icon is not rendered by the ToolPopup). To be used by other controls which want to update the icon in their UI.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.ToolPopup</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ToolPopup attachIconChanged(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:iconChanged iconChanged} event of this <code>sap.ui.ux3.ToolPopup</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.ToolPopup</code> itself.
					/// 
					/// Event is fired when one of the icon properties is modified (Note: The icon is not rendered by the ToolPopup). To be used by other controls which want to update the icon in their UI.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ToolPopup attachIconChanged(object oData, sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:iconChanged iconChanged} event of this <code>sap.ui.ux3.ToolPopup</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.ToolPopup</code> itself.
					/// 
					/// Event is fired when one of the icon properties is modified (Note: The icon is not rendered by the ToolPopup). To be used by other controls which want to update the icon in their UI.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ToolPopup attachIconChanged(sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:iconChanged iconChanged} event of this <code>sap.ui.ux3.ToolPopup</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.ToolPopup</code> itself.
					/// 
					/// Event is fired when one of the icon properties is modified (Note: The icon is not rendered by the ToolPopup). To be used by other controls which want to update the icon in their UI.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.ToolPopup</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ToolPopup attachIconChanged(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:iconChanged iconChanged} event of this <code>sap.ui.ux3.ToolPopup</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ToolPopup detachIconChanged(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:iconChanged iconChanged} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ToolPopup fireIconChanged(object mParameters);

					/// <summary>
					/// Fires event {@link #event:iconChanged iconChanged} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ToolPopup fireIconChanged();

					#endregion

					#region Methods for Event closed

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:closed closed} event of this <code>sap.ui.ux3.ToolPopup</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.ToolPopup</code> itself.
					/// 
					/// This event is fired after the ToolPopup has finished its closing animation. It is called for EVERY close, regardless of whether the user has triggered the close or whether the ToolPopup was closed via API call.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.ToolPopup</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ToolPopup attachClosed(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:closed closed} event of this <code>sap.ui.ux3.ToolPopup</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.ToolPopup</code> itself.
					/// 
					/// This event is fired after the ToolPopup has finished its closing animation. It is called for EVERY close, regardless of whether the user has triggered the close or whether the ToolPopup was closed via API call.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ToolPopup attachClosed(object oData, sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:closed closed} event of this <code>sap.ui.ux3.ToolPopup</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.ToolPopup</code> itself.
					/// 
					/// This event is fired after the ToolPopup has finished its closing animation. It is called for EVERY close, regardless of whether the user has triggered the close or whether the ToolPopup was closed via API call.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ToolPopup attachClosed(sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:closed closed} event of this <code>sap.ui.ux3.ToolPopup</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.ToolPopup</code> itself.
					/// 
					/// This event is fired after the ToolPopup has finished its closing animation. It is called for EVERY close, regardless of whether the user has triggered the close or whether the ToolPopup was closed via API call.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.ToolPopup</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ToolPopup attachClosed(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:closed closed} event of this <code>sap.ui.ux3.ToolPopup</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ToolPopup detachClosed(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:closed closed} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ToolPopup fireClosed(object mParameters);

					/// <summary>
					/// Fires event {@link #event:closed closed} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ToolPopup fireClosed();

					#endregion

					#region Methods for Event opened

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:opened opened} event of this <code>sap.ui.ux3.ToolPopup</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.ToolPopup</code> itself.
					/// 
					/// Event is being fired after the ToolPopup has been opened.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.ToolPopup</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ToolPopup attachOpened(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:opened opened} event of this <code>sap.ui.ux3.ToolPopup</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.ToolPopup</code> itself.
					/// 
					/// Event is being fired after the ToolPopup has been opened.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ToolPopup attachOpened(object oData, sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:opened opened} event of this <code>sap.ui.ux3.ToolPopup</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.ToolPopup</code> itself.
					/// 
					/// Event is being fired after the ToolPopup has been opened.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ToolPopup attachOpened(sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:opened opened} event of this <code>sap.ui.ux3.ToolPopup</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.ToolPopup</code> itself.
					/// 
					/// Event is being fired after the ToolPopup has been opened.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.ToolPopup</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ToolPopup attachOpened(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:opened opened} event of this <code>sap.ui.ux3.ToolPopup</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ToolPopup detachOpened(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:opened opened} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ToolPopup fireOpened(object mParameters);

					/// <summary>
					/// Fires event {@link #event:opened opened} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ToolPopup fireOpened();

					#endregion

					#region Other methods

					/// <summary>
					/// Adds an ID to the Popup that should be focusable as well when using <code>autoclose</code>. Chaining is only possible if a valid type (string) is given.
					/// </summary>
					/// <param name="sID">ID of the corresponding element that should be focusable as well</param>
					public extern virtual void addFocusableArea(string sID);

					/// <summary>
					/// Adds an ID to the Popup that should be focusable as well when using <code>autoclose</code>. Chaining is only possible if a valid type (string) is given.
					/// </summary>
					public extern virtual void addFocusableArea();

					/// <summary>
					/// Closes the pop up. Can be called by the Shell when the pop up's button is clicked again; or by the application when the interaction in the pop up has been completed or canceled.
					/// </summary>
					/// <param name="bPreventRestoreFocus">If set, the focus is NOT restored to the element that had the focus before the ToolPopup was opened. This makes sense when the ToolPopup is closed programmatically from a different area of the application (outside the ToolPopup) and the focus should not move aways from that place.</param>
					/// <returns></returns>
					public extern virtual sap.ui.ux3.ToolPopup close(bool bPreventRestoreFocus);

					/// <summary>
					/// Creates a new subclass of class sap.ui.ux3.ToolPopup with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.ux3.ToolPopup with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.ux3.ToolPopup with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Indicates whether the ToolPopup is currently enabled or not.
					/// 
					/// Applications can't control the enabled state via a property. A ToolPopup is implicitly enabled depending on its <code>openState</code>. Descendant controls that honor the enabled state of their ancestors will appear disabled after the ToolPopup is closed.
					/// 
					/// Since 1.13.1. Whether a dialog is regarded as "enabled" during the state transitions (OPENING, CLOSING) is not fully decided. Currently, it is enabled during the OPENING phase and disabled during the CLOSING phase. The only potential change would be to treat the OPENING phase as disabled as well. Applications should be prepared to receive events from "enabled" controls after they called open() on the dialog until close() is called on it. If the mentioned potential change should happen, the dialog will become enabled only after the transition to OPEN. Events from "enabled" children then can still only arrive between open() and close(), so applications that obey the previous rule should continue to work. Only end users or code that explicitly triggers pseudo user events would notice a difference. <br> A second aspect that might change is the visual behavior of the content: during the CLOSING phase it 'looks' enabled but in fact it is already disabled. This avoids unnecessary redraws for content that becomes hidden soon. Should this show to be confusing for end users, it might be changed.
					/// </summary>
					/// <returns></returns>
					public extern virtual bool getEnabled();

					/// <summary>
					/// Returns a metadata object for class sap.ui.ux3.ToolPopup.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					/// <summary>
					/// Indicates whether the pop up is currently open
					/// </summary>
					/// <returns></returns>
					public extern virtual bool isOpen();

					/// <summary>
					/// Opens the ToolPopup. It is checked which control wants to open the ToolPopup. The Shell was previously set as parent so the corresponding parent element is used to set the correct position of the ToolPopup. If another control (i.e. a button) opens the ToolPopup, the control must be previously set as <code>opener</code> via <code>setOpener</code> to the ToolPopup. Corresponding to this opener the position of the ToolPopup will be set. It's also possible to set the position above, below or left from the opener. This can be done via the possible parameters <code>my</code> and <code>at</code>. These parameters refers to work the same way as they do of sap.ui.core.Popup.open.
					/// </summary>
					/// <param name="my">The ToolPopup's content reference position for docking</param>
					/// <param name="at">The "of" element's reference point for docking to</param>
					/// <returns></returns>
					public extern virtual sap.ui.ux3.ToolPopup open(sap.ui.core.Popup.Dock my = sap.ui.core.Popup.Dock.CenterCenter, sap.ui.core.Popup.Dock at = sap.ui.core.Popup.Dock.CenterCenter);

					/// <summary>
					/// Removes an ID to the Popup that should be focusable as well when using <code>autoclose</code>. Chaining is only possible if a valid type (string) is given.
					/// </summary>
					/// <param name="sID">ID of the corresponding element</param>
					public extern virtual void removeFocusableArea(string sID);

					/// <summary>
					/// Removes an ID to the Popup that should be focusable as well when using <code>autoclose</code>. Chaining is only possible if a valid type (string) is given.
					/// </summary>
					public extern virtual void removeFocusableArea();

					/// <summary>
					/// This is just a forward to the Popup's function (sap.ui.core.Popup.setAutoCloseAreas) with the same functionality.
					/// </summary>
					/// <param name="aAutoCloseAreas"></param>
					public extern virtual void setAutoCloseAreas(dom.HTMLElement[] aAutoCloseAreas);

					/// <summary>
					/// Sets the position of the pop up, the same parameters as for sap.ui.core.Popup can be used.
					/// </summary>
					public extern virtual void setPosition();

					#endregion

					#endregion

				}
			}
		}
	}
}
