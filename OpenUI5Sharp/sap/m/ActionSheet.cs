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
			/// The action sheet holds a list of options from which the user can select to complete an action. <h3>Overview</h3> The options of the action sheet are represented as {@link sap.m.Button buttons} with icons. Elements in the action sheet are left-aligned. Actions should be arranged in order of importance, from top to bottom. <h3>Guidelines</h3> <ul> <li>Always display text or text and icons for the actions. Do not use icons only.</li> <li>Always provide a Cancel button on mobile phones.</li> <li>Avoid scrolling on action sheets.</li> </ul> <h3>Responsive Behavior</h3> On mobile phones the action sheet is displayed in a {@link sap.m.Dialog dialog}.
			/// 
			/// On tablets and desktop the action sheet is displayed in a {@link sap.m.Popover popover}.
			/// 
			/// When an action is triggered, the action sheet closes and you can display a confirmation as a {@link sap.m.MessageToast message toast}.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.ActionSheet")]
			public partial class ActionSheet : sap.ui.core.Control
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
					/// The ActionSheet behaves as an sap.m.Popover in iPad and this property is the information about on which side will the popover be placed at. Possible values are sap.m.PlacementType.Left, sap.m.PlacementType.Right, sap.m.PlacementType.Top, sap.m.PlacementType.Bottom, sap.m.PlacementType.Horizontal, sap.m.PlacementType.HorizontalPreferedLeft, sap.m.PlacementType.HorizontalPreferedRight, sap.m.PlacementType.Vertical, sap.m.PlacementType.VerticalPreferedTop, sap.m.PlacementType.VerticalPreferedBottom. The default value is sap.m.PlacementType.Bottom.
					/// </summary>
					public Union<sap.m.PlacementType, string, sap.ui.@base.ManagedObject.BindPropertyInfo> placement;

					/// <summary>
					/// If this is set to true, there will be a cancel button shown below the action buttons. There won't be any cancel button shown in iPad regardless of this property. The default value is set to true.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showCancelButton;

					/// <summary>
					/// This is the text displayed in the cancelButton. Default value is "Cancel", and it's translated according to the current locale setting. This property will be ignored when running either in iPad or showCancelButton is set to false.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> cancelButtonText;

					/// <summary>
					/// Title will be shown in the header area in iPhone and every Android devices. This property will be ignored in tablets and desktop browser.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> title;

					/// <summary>
					/// These buttons are added to the content area in ActionSheet control. When button is tapped, the ActionSheet is closed before the tap event listener is called.
					/// </summary>
					public Union<sap.m.Button[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> buttons;

					/// <summary>
					/// This event is fired when the cancelButton is tapped. For iPad, this event is also fired when showCancelButton is set to true, and Popover is closed by tapping outside.
					/// </summary>
					public sap.ui.@base.EventDelegate cancelButtonTap;

					/// <summary>
					/// This event will be fired before the ActionSheet is opened.
					/// </summary>
					public sap.ui.@base.EventDelegate beforeOpen;

					/// <summary>
					/// This event will be fired after the ActionSheet is opened.
					/// </summary>
					public sap.ui.@base.EventDelegate afterOpen;

					/// <summary>
					/// This event will be fired before the ActionSheet is closed.
					/// </summary>
					public sap.ui.@base.EventDelegate beforeClose;

					/// <summary>
					/// This event will be fired after the ActionSheet is closed.
					/// </summary>
					public sap.ui.@base.EventDelegate afterClose;

					/// <summary>
					/// This event is fired when the cancelButton is clicked. For iPad, this event is also fired when showCancelButton is set to true, and Popover is closed by clicking outside.
					/// </summary>
					public sap.ui.@base.EventDelegate cancelButtonPress;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new ActionSheet.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern ActionSheet(string sId, sap.m.ActionSheet.Settings mSettings);

				/// <summary>
				/// Constructor for a new ActionSheet.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern ActionSheet(string sId);

				/// <summary>
				/// Constructor for a new ActionSheet.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern ActionSheet();

				/// <summary>
				/// Constructor for a new ActionSheet.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern ActionSheet(sap.m.ActionSheet.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property placement

				/// <summary>
				/// Gets current value of property {@link #getPlacement placement}.
				/// 
				/// The ActionSheet behaves as an sap.m.Popover in iPad and this property is the information about on which side will the popover be placed at. Possible values are sap.m.PlacementType.Left, sap.m.PlacementType.Right, sap.m.PlacementType.Top, sap.m.PlacementType.Bottom, sap.m.PlacementType.Horizontal, sap.m.PlacementType.HorizontalPreferedLeft, sap.m.PlacementType.HorizontalPreferedRight, sap.m.PlacementType.Vertical, sap.m.PlacementType.VerticalPreferedTop, sap.m.PlacementType.VerticalPreferedBottom. The default value is sap.m.PlacementType.Bottom.
				/// 
				/// Default value is <code>Bottom</code>.
				/// </summary>
				/// <returns>Value of property <code>placement</code></returns>
				public extern virtual sap.m.PlacementType getPlacement();

				/// <summary>
				/// Sets a new value for property {@link #getPlacement placement}.
				/// 
				/// The ActionSheet behaves as an sap.m.Popover in iPad and this property is the information about on which side will the popover be placed at. Possible values are sap.m.PlacementType.Left, sap.m.PlacementType.Right, sap.m.PlacementType.Top, sap.m.PlacementType.Bottom, sap.m.PlacementType.Horizontal, sap.m.PlacementType.HorizontalPreferedLeft, sap.m.PlacementType.HorizontalPreferedRight, sap.m.PlacementType.Vertical, sap.m.PlacementType.VerticalPreferedTop, sap.m.PlacementType.VerticalPreferedBottom. The default value is sap.m.PlacementType.Bottom.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Bottom</code>.
				/// </summary>
				/// <param name="sPlacement">New value for property <code>placement</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ActionSheet setPlacement(sap.m.PlacementType sPlacement);

				#endregion

				#region Methods for Property showCancelButton

				/// <summary>
				/// Gets current value of property {@link #getShowCancelButton showCancelButton}.
				/// 
				/// If this is set to true, there will be a cancel button shown below the action buttons. There won't be any cancel button shown in iPad regardless of this property. The default value is set to true.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>showCancelButton</code></returns>
				public extern virtual bool getShowCancelButton();

				/// <summary>
				/// Sets a new value for property {@link #getShowCancelButton showCancelButton}.
				/// 
				/// If this is set to true, there will be a cancel button shown below the action buttons. There won't be any cancel button shown in iPad regardless of this property. The default value is set to true.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bShowCancelButton">New value for property <code>showCancelButton</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ActionSheet setShowCancelButton(bool bShowCancelButton);

				#endregion

				#region Methods for Property cancelButtonText

				/// <summary>
				/// Gets current value of property {@link #getCancelButtonText cancelButtonText}.
				/// 
				/// This is the text displayed in the cancelButton. Default value is "Cancel", and it's translated according to the current locale setting. This property will be ignored when running either in iPad or showCancelButton is set to false.
				/// </summary>
				/// <returns>Value of property <code>cancelButtonText</code></returns>
				public extern virtual string getCancelButtonText();

				/// <summary>
				/// Sets a new value for property {@link #getCancelButtonText cancelButtonText}.
				/// 
				/// This is the text displayed in the cancelButton. Default value is "Cancel", and it's translated according to the current locale setting. This property will be ignored when running either in iPad or showCancelButton is set to false.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sCancelButtonText">New value for property <code>cancelButtonText</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ActionSheet setCancelButtonText(string sCancelButtonText);

				#endregion

				#region Methods for Property title

				/// <summary>
				/// Gets current value of property {@link #getTitle title}.
				/// 
				/// Title will be shown in the header area in iPhone and every Android devices. This property will be ignored in tablets and desktop browser.
				/// </summary>
				/// <returns>Value of property <code>title</code></returns>
				public extern virtual string getTitle();

				/// <summary>
				/// Sets a new value for property {@link #getTitle title}.
				/// 
				/// Title will be shown in the header area in iPhone and every Android devices. This property will be ignored in tablets and desktop browser.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sTitle">New value for property <code>title</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ActionSheet setTitle(string sTitle);

				#endregion

				#region Methods for Aggregation buttons

				/// <summary>
				/// Gets content of aggregation {@link #getButtons buttons}.
				/// 
				/// These buttons are added to the content area in ActionSheet control. When button is tapped, the ActionSheet is closed before the tap event listener is called.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.Button[] getButtons();

				/// <summary>
				/// Destroys all the buttons in the aggregation {@link #getButtons buttons}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ActionSheet destroyButtons();

				/// <summary>
				/// Inserts a button into the aggregation {@link #getButtons buttons}.
				/// </summary>
				/// <param name="oButton">The button to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the button should be inserted at; for a negative value of <code>iIndex</code>, the button is inserted at position 0; for a value greater than the current size of the aggregation, the button is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ActionSheet insertButton(sap.m.Button oButton, int iIndex);

				/// <summary>
				/// Adds some button to the aggregation {@link #getButtons buttons}.
				/// </summary>
				/// <param name="oButton">The button to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ActionSheet addButton(sap.m.Button oButton);

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

				#region Methods for Aggregation _cancelButton

				#endregion

				#region Methods for Aggregation _invisibleAriaTexts

				#endregion

				#region Methods for Event cancelButtonTap

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:cancelButtonTap cancelButtonTap} event of this <code>sap.m.ActionSheet</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ActionSheet</code> itself.
				/// 
				/// This event is fired when the cancelButton is tapped. For iPad, this event is also fired when showCancelButton is set to true, and Popover is closed by tapping outside.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ActionSheet</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.20.0. This event is deprecated, use the cancelButtonPress event instead.")]
				public extern virtual sap.m.ActionSheet attachCancelButtonTap(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:cancelButtonTap cancelButtonTap} event of this <code>sap.m.ActionSheet</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ActionSheet</code> itself.
				/// 
				/// This event is fired when the cancelButton is tapped. For iPad, this event is also fired when showCancelButton is set to true, and Popover is closed by tapping outside.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.20.0. This event is deprecated, use the cancelButtonPress event instead.")]
				public extern virtual sap.m.ActionSheet attachCancelButtonTap(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:cancelButtonTap cancelButtonTap} event of this <code>sap.m.ActionSheet</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ActionSheet</code> itself.
				/// 
				/// This event is fired when the cancelButton is tapped. For iPad, this event is also fired when showCancelButton is set to true, and Popover is closed by tapping outside.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.20.0. This event is deprecated, use the cancelButtonPress event instead.")]
				public extern virtual sap.m.ActionSheet attachCancelButtonTap(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:cancelButtonTap cancelButtonTap} event of this <code>sap.m.ActionSheet</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ActionSheet</code> itself.
				/// 
				/// This event is fired when the cancelButton is tapped. For iPad, this event is also fired when showCancelButton is set to true, and Popover is closed by tapping outside.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ActionSheet</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.20.0. This event is deprecated, use the cancelButtonPress event instead.")]
				public extern virtual sap.m.ActionSheet attachCancelButtonTap(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:cancelButtonTap cancelButtonTap} event of this <code>sap.m.ActionSheet</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.20.0. This event is deprecated, use the cancelButtonPress event instead.")]
				public extern virtual sap.m.ActionSheet detachCancelButtonTap(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:cancelButtonTap cancelButtonTap} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.20.0. This event is deprecated, use the cancelButtonPress event instead.")]
				public extern virtual sap.m.ActionSheet fireCancelButtonTap(object mParameters);

				/// <summary>
				/// Fires event {@link #event:cancelButtonTap cancelButtonTap} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.20.0. This event is deprecated, use the cancelButtonPress event instead.")]
				public extern virtual sap.m.ActionSheet fireCancelButtonTap();

				#endregion

				#region Methods for Event beforeOpen

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeOpen beforeOpen} event of this <code>sap.m.ActionSheet</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ActionSheet</code> itself.
				/// 
				/// This event will be fired before the ActionSheet is opened.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ActionSheet</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ActionSheet attachBeforeOpen(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeOpen beforeOpen} event of this <code>sap.m.ActionSheet</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ActionSheet</code> itself.
				/// 
				/// This event will be fired before the ActionSheet is opened.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ActionSheet attachBeforeOpen(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeOpen beforeOpen} event of this <code>sap.m.ActionSheet</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ActionSheet</code> itself.
				/// 
				/// This event will be fired before the ActionSheet is opened.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ActionSheet attachBeforeOpen(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeOpen beforeOpen} event of this <code>sap.m.ActionSheet</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ActionSheet</code> itself.
				/// 
				/// This event will be fired before the ActionSheet is opened.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ActionSheet</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ActionSheet attachBeforeOpen(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:beforeOpen beforeOpen} event of this <code>sap.m.ActionSheet</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ActionSheet detachBeforeOpen(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:beforeOpen beforeOpen} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ActionSheet fireBeforeOpen(object mParameters);

				/// <summary>
				/// Fires event {@link #event:beforeOpen beforeOpen} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ActionSheet fireBeforeOpen();

				#endregion

				#region Methods for Event afterOpen

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterOpen afterOpen} event of this <code>sap.m.ActionSheet</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ActionSheet</code> itself.
				/// 
				/// This event will be fired after the ActionSheet is opened.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ActionSheet</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ActionSheet attachAfterOpen(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterOpen afterOpen} event of this <code>sap.m.ActionSheet</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ActionSheet</code> itself.
				/// 
				/// This event will be fired after the ActionSheet is opened.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ActionSheet attachAfterOpen(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterOpen afterOpen} event of this <code>sap.m.ActionSheet</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ActionSheet</code> itself.
				/// 
				/// This event will be fired after the ActionSheet is opened.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ActionSheet attachAfterOpen(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterOpen afterOpen} event of this <code>sap.m.ActionSheet</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ActionSheet</code> itself.
				/// 
				/// This event will be fired after the ActionSheet is opened.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ActionSheet</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ActionSheet attachAfterOpen(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:afterOpen afterOpen} event of this <code>sap.m.ActionSheet</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ActionSheet detachAfterOpen(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:afterOpen afterOpen} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ActionSheet fireAfterOpen(object mParameters);

				/// <summary>
				/// Fires event {@link #event:afterOpen afterOpen} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ActionSheet fireAfterOpen();

				#endregion

				#region Methods for Event beforeClose

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeClose beforeClose} event of this <code>sap.m.ActionSheet</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ActionSheet</code> itself.
				/// 
				/// This event will be fired before the ActionSheet is closed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ActionSheet</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ActionSheet attachBeforeClose(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeClose beforeClose} event of this <code>sap.m.ActionSheet</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ActionSheet</code> itself.
				/// 
				/// This event will be fired before the ActionSheet is closed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ActionSheet attachBeforeClose(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeClose beforeClose} event of this <code>sap.m.ActionSheet</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ActionSheet</code> itself.
				/// 
				/// This event will be fired before the ActionSheet is closed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ActionSheet attachBeforeClose(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeClose beforeClose} event of this <code>sap.m.ActionSheet</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ActionSheet</code> itself.
				/// 
				/// This event will be fired before the ActionSheet is closed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ActionSheet</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ActionSheet attachBeforeClose(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:beforeClose beforeClose} event of this <code>sap.m.ActionSheet</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ActionSheet detachBeforeClose(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:beforeClose beforeClose} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ActionSheet fireBeforeClose(object mParameters);

				/// <summary>
				/// Fires event {@link #event:beforeClose beforeClose} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ActionSheet fireBeforeClose();

				#endregion

				#region Methods for Event afterClose

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterClose afterClose} event of this <code>sap.m.ActionSheet</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ActionSheet</code> itself.
				/// 
				/// This event will be fired after the ActionSheet is closed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ActionSheet</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ActionSheet attachAfterClose(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterClose afterClose} event of this <code>sap.m.ActionSheet</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ActionSheet</code> itself.
				/// 
				/// This event will be fired after the ActionSheet is closed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ActionSheet attachAfterClose(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterClose afterClose} event of this <code>sap.m.ActionSheet</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ActionSheet</code> itself.
				/// 
				/// This event will be fired after the ActionSheet is closed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ActionSheet attachAfterClose(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterClose afterClose} event of this <code>sap.m.ActionSheet</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ActionSheet</code> itself.
				/// 
				/// This event will be fired after the ActionSheet is closed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ActionSheet</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ActionSheet attachAfterClose(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:afterClose afterClose} event of this <code>sap.m.ActionSheet</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ActionSheet detachAfterClose(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:afterClose afterClose} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ActionSheet fireAfterClose(object mParameters);

				/// <summary>
				/// Fires event {@link #event:afterClose afterClose} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ActionSheet fireAfterClose();

				#endregion

				#region Methods for Event cancelButtonPress

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:cancelButtonPress cancelButtonPress} event of this <code>sap.m.ActionSheet</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ActionSheet</code> itself.
				/// 
				/// This event is fired when the cancelButton is clicked. For iPad, this event is also fired when showCancelButton is set to true, and Popover is closed by clicking outside.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ActionSheet</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ActionSheet attachCancelButtonPress(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:cancelButtonPress cancelButtonPress} event of this <code>sap.m.ActionSheet</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ActionSheet</code> itself.
				/// 
				/// This event is fired when the cancelButton is clicked. For iPad, this event is also fired when showCancelButton is set to true, and Popover is closed by clicking outside.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ActionSheet attachCancelButtonPress(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:cancelButtonPress cancelButtonPress} event of this <code>sap.m.ActionSheet</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ActionSheet</code> itself.
				/// 
				/// This event is fired when the cancelButton is clicked. For iPad, this event is also fired when showCancelButton is set to true, and Popover is closed by clicking outside.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ActionSheet attachCancelButtonPress(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:cancelButtonPress cancelButtonPress} event of this <code>sap.m.ActionSheet</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ActionSheet</code> itself.
				/// 
				/// This event is fired when the cancelButton is clicked. For iPad, this event is also fired when showCancelButton is set to true, and Popover is closed by clicking outside.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ActionSheet</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ActionSheet attachCancelButtonPress(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:cancelButtonPress cancelButtonPress} event of this <code>sap.m.ActionSheet</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ActionSheet detachCancelButtonPress(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:cancelButtonPress cancelButtonPress} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ActionSheet fireCancelButtonPress(object mParameters);

				/// <summary>
				/// Fires event {@link #event:cancelButtonPress cancelButtonPress} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ActionSheet fireCancelButtonPress();

				#endregion

				#region Other methods

				/// <summary>
				/// Calling this method will make the ActionSheet disappear from the screen.
				/// </summary>
				/// <param name="oControl">The control to close</param>
				public extern virtual void close(object oControl);

				/// <summary>
				/// Creates a new subclass of class sap.m.ActionSheet with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.ActionSheet with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.ActionSheet with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.ActionSheet.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				/// <summary>
				/// Gets the ID of the hidden label
				/// </summary>
				/// <returns>ID of hidden text</returns>
				public extern virtual string getPopupHiddenLabelId();

				/// <summary>
				/// The method checks if the ActionSheet is open. It returns true when the ActionSheet is currently open (this includes opening and closing animations), otherwise it returns false.
				/// </summary>
				/// <param name="oControl">The control in question</param>
				/// <returns>Whether the ActionSheet is open.</returns>
				public extern virtual bool isOpen(object oControl);

				/// <summary>
				/// Calling this method will make the ActionSheet visible on the screen. The control parameter is the object to which the ActionSheet will be placed. It can be not only a UI5 control, but also an existing DOM reference. The side of the placement depends on the <code>placement</code> property set in the Popover (on tablet and desktop). On other platforms, ActionSheet behaves as a standard dialog and this parameter is ignored because dialog is aligned to the screen.
				/// </summary>
				/// <param name="oControl">The control to which the ActionSheet is opened</param>
				public extern virtual void openBy(object oControl);

				#endregion

				#endregion

			}
		}
	}
}
