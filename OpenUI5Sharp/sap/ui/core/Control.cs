using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace OpenUI5Sharp
{
	public partial class sap
	{
		public static partial class ui
		{
			public static partial class core
			{
				/// <summary>
				/// Base Class for Controls.
				/// 
				/// Controls provide the following features: <ul> <li><b>Rendering</b>: the <code>RenderManager</code> only expects instances of class <code>Control</code> in its {@link sap.ui.core.RenderManager#renderControl renderControl} method. By convention, each control class has an associated static class that takes care of rendering the control (its 'Renderer').</li> <li><b>show / hide</b>: a control can be hidden, although it is still part of the control tree, see property {@link #getVisible visible}</li> <li><b>local busy indicator</b>: marks a control visually as 'busy', see properties {@link #getBusy busy} and {@link #getBusyIndicatorDelay busyIndicatorDelay}</li> <li><b>field groups</b>: by assigning the same group ID to a set of editable controls, they form a group which can be validated together. See property {@link #getFieldGroupIds fieldGroupIds} and event {@link #event:validateFieldGroup validateFieldGroup}. The term <i>field</i> was chosen as most often this feature will be used to group editable fields in a form.</li> <li><b>custom style classes</b>: all controls allow to add custom CSS classes to their rendered DOM without modifying their renderer code. See methods {@link #addStyleClass addStyleClass}, {@link #removeStyleClass removeStyleClass}, {@link #toggleStyleClass toggleStyleClass} and {@link #hasStyleClass hasStyleClass}.</br> The necessary implementation is encapsulated in {@link sap.ui.core.CustomStyleClassSupport CustomStyleClassSupport} and can be applied to selected element classes as well.</li> <li><b>browser events</b>: by calling the methods {@link #attachBrowserEvent attachBrowserEvent} and {@link #detachBrowserEvent detachBrowserEvent}, consumers can let the control class take care of registering / de-registering a given set of event listeners to the control's root DOM node. The framework will adapt the registration whenever the DOM node changes (e.g. before or after rendering or when the control is destroyed).</li> </ul>
				/// 
				/// See section "{@link topic:91f1703b6f4d1014b6dd926db0e91070 Developing OpenUI5/SAPUI5 Controls}" in the documentation for an introduction to control development.
				/// </summary>
				[External]
				[Namespace(false)]
				public abstract partial class Control : sap.ui.core.Element
				{
					#region Settings

					/// <summary>
					/// Settings class to create the object
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class Settings : sap.ui.core.Element.Settings
					{
						/// <summary>
						/// Whether the control is currently in blocked state.
						/// </summary>
						public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> blocked;

						/// <summary>
						/// Whether the control is currently in busy state.
						/// </summary>
						public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> busy;

						/// <summary>
						/// The delay in milliseconds, after which the busy indicator will show up for this control.
						/// </summary>
						public Union<int, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> busyIndicatorDelay;

						/// <summary>
						/// The size of the BusyIndicator. For controls with a width smaller 3rem a <code>sap.ui.core.BusyIndicatorSize.Small</code> should be used. If the size could vary in width and the width could get smaller than 3rem, the <code>sap.ui.core.BusyIndicatorSize.Auto</code> option could be used. The default is set to <code>sap.ui.core.BusyIndicatorSize.Medium</code> For a full screen BusyIndicator use <code>sap.ui.core.BusyIndicatorSize.Large</code>.
						/// </summary>
						public Union<sap.ui.core.BusyIndicatorSize, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> busyIndicatorSize;

						/// <summary>
						/// Whether the control should be visible on the screen.
						/// 
						/// If set to false, a placeholder will be rendered to mark the location of the invisible control in the DOM of the current page. The placeholder will be hidden and have zero dimensions (<code>display: none</code>).
						/// 
						/// See {@link sap.ui.core.RenderManager#writeInvisiblePlaceholderData RenderManager#writeInvisiblePlaceholderData} for details.
						/// </summary>
						public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> visible;

						/// <summary>
						/// The IDs of a logical field group that this control belongs to.
						/// 
						/// All fields in a logical field group should share the same <code>fieldGroupId</code>. Once a logical field group is left, the <code>validateFieldGroup</code> event is raised.
						/// 
						/// See {@link sap.ui.core.Control#attachValidateFieldGroup}.
						/// </summary>
						public Union<string[], string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> fieldGroupIds;

						/// <summary>
						/// Event is fired if a logical field group defined by <code>fieldGroupIds</code> of a control was left or the user explicitly pressed a key combination that triggers validation.
						/// 
						/// Listen to this event to validate data of the controls belonging to a field group. See {@link sap.ui.core.Control#setFieldGroupIds}.
						/// </summary>
						public sap.ui.core.Control.ValidateFieldGroupDelegate validateFieldGroup;

					}

					#endregion

					#region Typed Parameters

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class ValidateFieldGroupInfo
					{
						/// <summary>
						/// field group IDs of the logical field groups to validate
						/// </summary>
						public string[] fieldGroupIds;

					}

					#endregion

					#region Delegates

					public delegate void ValidateFieldGroupDelegate(sap.ui.@base.Event<sap.ui.core.Control.ValidateFieldGroupInfo> oEvent, object oData);

					#endregion

					#region Constructor

					/// <summary>
					/// Creates and initializes a new control with the given <code>sId</code> and settings.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">Optional ID for the new control; generated automatically if no non-empty ID is given Note: this can be omitted, no matter whether <code>mSettings</code> will be given or not!</param>
					/// <param name="mSettings">Object with initial settings for the new control</param>
					public extern Control(string sId, sap.ui.core.Control.Settings mSettings);

					/// <summary>
					/// Creates and initializes a new control with the given <code>sId</code> and settings.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">Optional ID for the new control; generated automatically if no non-empty ID is given Note: this can be omitted, no matter whether <code>mSettings</code> will be given or not!</param>
					public extern Control(string sId);

					/// <summary>
					/// Creates and initializes a new control with the given <code>sId</code> and settings.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern Control();

					/// <summary>
					/// Creates and initializes a new control with the given <code>sId</code> and settings.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">Object with initial settings for the new control</param>
					public extern Control(sap.ui.core.Control.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property blocked

					/// <summary>
					/// Gets current value of property {@link #getBlocked blocked}.
					/// 
					/// Whether the control is currently in blocked state.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>blocked</code></returns>
					public extern virtual bool getBlocked();

					#endregion

					#region Methods for Property busy

					/// <summary>
					/// Gets current value of property {@link #getBusy busy}.
					/// 
					/// Whether the control is currently in busy state.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>busy</code></returns>
					public extern virtual bool getBusy();

					/// <summary>
					/// Set the controls busy state.
					/// </summary>
					/// <param name="bBusy">The new busy state to be set</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.Control setBusy(bool bBusy);

					#endregion

					#region Methods for Property busyIndicatorDelay

					/// <summary>
					/// Gets current value of property {@link #getBusyIndicatorDelay busyIndicatorDelay}.
					/// 
					/// The delay in milliseconds, after which the busy indicator will show up for this control.
					/// 
					/// Default value is <code>1000</code>.
					/// </summary>
					/// <returns>Value of property <code>busyIndicatorDelay</code></returns>
					public extern virtual int getBusyIndicatorDelay();

					/// <summary>
					/// Define the delay, after which the busy indicator will show up.
					/// </summary>
					/// <param name="iDelay">The delay in ms</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.Control setBusyIndicatorDelay(int iDelay);

					#endregion

					#region Methods for Property busyIndicatorSize

					/// <summary>
					/// Gets current value of property {@link #getBusyIndicatorSize busyIndicatorSize}.
					/// 
					/// The size of the BusyIndicator. For controls with a width smaller 3rem a <code>sap.ui.core.BusyIndicatorSize.Small</code> should be used. If the size could vary in width and the width could get smaller than 3rem, the <code>sap.ui.core.BusyIndicatorSize.Auto</code> option could be used. The default is set to <code>sap.ui.core.BusyIndicatorSize.Medium</code> For a full screen BusyIndicator use <code>sap.ui.core.BusyIndicatorSize.Large</code>.
					/// 
					/// Default value is <code>Medium</code>.
					/// </summary>
					/// <returns>Value of property <code>busyIndicatorSize</code></returns>
					public extern virtual sap.ui.core.BusyIndicatorSize getBusyIndicatorSize();

					/// <summary>
					/// Sets a new value for property {@link #getBusyIndicatorSize busyIndicatorSize}.
					/// 
					/// The size of the BusyIndicator. For controls with a width smaller 3rem a <code>sap.ui.core.BusyIndicatorSize.Small</code> should be used. If the size could vary in width and the width could get smaller than 3rem, the <code>sap.ui.core.BusyIndicatorSize.Auto</code> option could be used. The default is set to <code>sap.ui.core.BusyIndicatorSize.Medium</code> For a full screen BusyIndicator use <code>sap.ui.core.BusyIndicatorSize.Large</code>.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>Medium</code>.
					/// </summary>
					/// <param name="sBusyIndicatorSize">New value for property <code>busyIndicatorSize</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.Control setBusyIndicatorSize(sap.ui.core.BusyIndicatorSize sBusyIndicatorSize);

					#endregion

					#region Methods for Property visible

					/// <summary>
					/// Gets current value of property {@link #getVisible visible}.
					/// 
					/// Whether the control should be visible on the screen.
					/// 
					/// If set to false, a placeholder will be rendered to mark the location of the invisible control in the DOM of the current page. The placeholder will be hidden and have zero dimensions (<code>display: none</code>).
					/// 
					/// See {@link sap.ui.core.RenderManager#writeInvisiblePlaceholderData RenderManager#writeInvisiblePlaceholderData} for details.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>visible</code></returns>
					public extern virtual bool getVisible();

					/// <summary>
					/// Sets a new value for property {@link #getVisible visible}.
					/// 
					/// Whether the control should be visible on the screen.
					/// 
					/// If set to false, a placeholder will be rendered to mark the location of the invisible control in the DOM of the current page. The placeholder will be hidden and have zero dimensions (<code>display: none</code>).
					/// 
					/// See {@link sap.ui.core.RenderManager#writeInvisiblePlaceholderData RenderManager#writeInvisiblePlaceholderData} for details.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bVisible">New value for property <code>visible</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.Control setVisible(bool bVisible);

					#endregion

					#region Methods for Property fieldGroupIds

					/// <summary>
					/// Returns a copy of the field group IDs array. Modification of the field group IDs need to call {@link #setFieldGroupIds setFieldGroupIds} to apply the changes.
					/// </summary>
					/// <returns>copy of the field group IDs</returns>
					public extern virtual string[] getFieldGroupIds();

					/// <summary>
					/// Sets a new value for property {@link #getFieldGroupIds fieldGroupIds}.
					/// 
					/// The IDs of a logical field group that this control belongs to.
					/// 
					/// All fields in a logical field group should share the same <code>fieldGroupId</code>. Once a logical field group is left, the <code>validateFieldGroup</code> event is raised.
					/// 
					/// See {@link sap.ui.core.Control#attachValidateFieldGroup}.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>[]</code>.
					/// </summary>
					/// <param name="sFieldGroupIds">New value for property <code>fieldGroupIds</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.Control setFieldGroupIds(string[] sFieldGroupIds);

					/// <summary>
					/// Sets a new value for property {@link #getFieldGroupIds fieldGroupIds}.
					/// 
					/// The IDs of a logical field group that this control belongs to.
					/// 
					/// All fields in a logical field group should share the same <code>fieldGroupId</code>. Once a logical field group is left, the <code>validateFieldGroup</code> event is raised.
					/// 
					/// See {@link sap.ui.core.Control#attachValidateFieldGroup}.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>[]</code>.
					/// </summary>
					/// <param name="sFieldGroupIds">New value for property <code>fieldGroupIds</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.Control setFieldGroupIds(object[] sFieldGroupIds);

					#endregion

					#region Methods for Event validateFieldGroup

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:validateFieldGroup validateFieldGroup} event of this <code>sap.ui.core.Control</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.core.Control</code> itself.
					/// 
					/// Event is fired if a logical field group defined by <code>fieldGroupIds</code> of a control was left or the user explicitly pressed a key combination that triggers validation.
					/// 
					/// Listen to this event to validate data of the controls belonging to a field group. See {@link sap.ui.core.Control#setFieldGroupIds}.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.core.Control</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.Control attachValidateFieldGroup(object oData, sap.ui.core.Control.ValidateFieldGroupDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:validateFieldGroup validateFieldGroup} event of this <code>sap.ui.core.Control</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.core.Control</code> itself.
					/// 
					/// Event is fired if a logical field group defined by <code>fieldGroupIds</code> of a control was left or the user explicitly pressed a key combination that triggers validation.
					/// 
					/// Listen to this event to validate data of the controls belonging to a field group. See {@link sap.ui.core.Control#setFieldGroupIds}.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.Control attachValidateFieldGroup(object oData, sap.ui.core.Control.ValidateFieldGroupDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:validateFieldGroup validateFieldGroup} event of this <code>sap.ui.core.Control</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.core.Control</code> itself.
					/// 
					/// Event is fired if a logical field group defined by <code>fieldGroupIds</code> of a control was left or the user explicitly pressed a key combination that triggers validation.
					/// 
					/// Listen to this event to validate data of the controls belonging to a field group. See {@link sap.ui.core.Control#setFieldGroupIds}.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.Control attachValidateFieldGroup(sap.ui.core.Control.ValidateFieldGroupDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:validateFieldGroup validateFieldGroup} event of this <code>sap.ui.core.Control</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.core.Control</code> itself.
					/// 
					/// Event is fired if a logical field group defined by <code>fieldGroupIds</code> of a control was left or the user explicitly pressed a key combination that triggers validation.
					/// 
					/// Listen to this event to validate data of the controls belonging to a field group. See {@link sap.ui.core.Control#setFieldGroupIds}.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.core.Control</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.Control attachValidateFieldGroup(sap.ui.core.Control.ValidateFieldGroupDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:validateFieldGroup validateFieldGroup} event of this <code>sap.ui.core.Control</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.Control detachValidateFieldGroup(sap.ui.core.Control.ValidateFieldGroupDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:validateFieldGroup validateFieldGroup} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.Control fireValidateFieldGroup(sap.ui.core.Control.ValidateFieldGroupInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:validateFieldGroup validateFieldGroup} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.Control fireValidateFieldGroup();

					#endregion

					#region Other methods

					/// <summary>
					/// The string given as "sStyleClass" will be added to the "class" attribute of this control's root HTML element.
					/// 
					/// This method is intended to be used to mark controls as being of a special type for which special styling can be provided using CSS selectors that reference this style class name.
					/// 
					/// <pre>
					/// Example:
					///    myButton.addStyleClass("myRedTextButton"); // add a CSS class to one button instance
					/// 
					/// ...and in CSS:
					///    .myRedTextButton {
					///       color: red;
					///    }
					/// </pre>
					/// 
					/// This will add the CSS class "myRedTextButton" to the Button HTML and the CSS code above will then make the text in this particular button red.
					/// 
					/// Only characters allowed inside HTML attributes are allowed. Quotes are not allowed and this method will ignore any strings containing quotes. Strings containing spaces are interpreted as multiple custom style classes which are split by space and can be removed individually later by calling removeStyleClass. Multiple calls with the same sStyleClass will have no different effect than calling once. If sStyleClass is null, empty string or it contains quotes, the call is ignored.
					/// </summary>
					/// <param name="sStyleClass">the CSS class name to be added</param>
					/// <returns>Returns <code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.Control addStyleClass(string sStyleClass);

					/// <summary>
					/// Defines whether the user can select text inside this control. Defaults to <code>true</code> as long as this method has not been called.
					/// 
					/// <b>Note:</b>This only works in IE and Safari; for Firefox the element's style must be set to: <pre>
					///   -moz-user-select: none;
					/// </pre> in order to prevent text selection.
					/// </summary>
					/// <param name="bAllow">whether to allow text selection or not</param>
					/// <returns>Returns <code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.Control allowTextSelection(bool bAllow);

					/// <summary>
					/// Allows binding handlers for any native browser event to the root HTML element of this Control. This internally handles DOM element replacements caused by re-rendering.
					/// 
					/// <b>IMPORTANT:</b></br> This should be only used as FALLBACK when the Control events do not cover a specific use-case! Always try using SAPUI5 control events, as e.g. accessibility-related functionality is then provided automatically. E.g. when working with a <code>sap.ui.commons.Button</code>, always use the Button's "press" event, not the native "click" event, because "press" is also guaranteed to be fired when certain keyboard activity is supposed to trigger the Button.
					/// 
					/// In the event handler, <code>this</code> refers to the Control - not to the root DOM element like in jQuery. While the DOM element can be used and modified, the general caveats for working with SAPUI5 control DOM elements apply. In particular the DOM element may be destroyed and replaced by a new one at any time, so modifications that are required to have permanent effect may not be done. E.g. use {@link sap.ui.core.Control.prototype.addStyleClass} instead if the modification is of visual nature.
					/// 
					/// Use {@link #detachBrowserEvent} to remove the event handler(s) again.
					/// </summary>
					/// <param name="sEventType">A string containing one or more JavaScript event types, such as "click" or "blur".</param>
					/// <param name="fnHandler">A function to execute each time the event is triggered.</param>
					/// <param name="oListener">The object, that wants to be notified, when the event occurs</param>
					/// <returns>Returns <code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.Control attachBrowserEvent(string sEventType, object fnHandler, object oListener);

					/// <summary>
					/// Allows binding handlers for any native browser event to the root HTML element of this Control. This internally handles DOM element replacements caused by re-rendering.
					/// 
					/// <b>IMPORTANT:</b></br> This should be only used as FALLBACK when the Control events do not cover a specific use-case! Always try using SAPUI5 control events, as e.g. accessibility-related functionality is then provided automatically. E.g. when working with a <code>sap.ui.commons.Button</code>, always use the Button's "press" event, not the native "click" event, because "press" is also guaranteed to be fired when certain keyboard activity is supposed to trigger the Button.
					/// 
					/// In the event handler, <code>this</code> refers to the Control - not to the root DOM element like in jQuery. While the DOM element can be used and modified, the general caveats for working with SAPUI5 control DOM elements apply. In particular the DOM element may be destroyed and replaced by a new one at any time, so modifications that are required to have permanent effect may not be done. E.g. use {@link sap.ui.core.Control.prototype.addStyleClass} instead if the modification is of visual nature.
					/// 
					/// Use {@link #detachBrowserEvent} to remove the event handler(s) again.
					/// </summary>
					/// <param name="sEventType">A string containing one or more JavaScript event types, such as "click" or "blur".</param>
					/// <param name="fnHandler">A function to execute each time the event is triggered.</param>
					/// <returns>Returns <code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.Control attachBrowserEvent(string sEventType, object fnHandler);

					/// <summary>
					/// Allows binding handlers for any native browser event to the root HTML element of this Control. This internally handles DOM element replacements caused by re-rendering.
					/// 
					/// <b>IMPORTANT:</b></br> This should be only used as FALLBACK when the Control events do not cover a specific use-case! Always try using SAPUI5 control events, as e.g. accessibility-related functionality is then provided automatically. E.g. when working with a <code>sap.ui.commons.Button</code>, always use the Button's "press" event, not the native "click" event, because "press" is also guaranteed to be fired when certain keyboard activity is supposed to trigger the Button.
					/// 
					/// In the event handler, <code>this</code> refers to the Control - not to the root DOM element like in jQuery. While the DOM element can be used and modified, the general caveats for working with SAPUI5 control DOM elements apply. In particular the DOM element may be destroyed and replaced by a new one at any time, so modifications that are required to have permanent effect may not be done. E.g. use {@link sap.ui.core.Control.prototype.addStyleClass} instead if the modification is of visual nature.
					/// 
					/// Use {@link #detachBrowserEvent} to remove the event handler(s) again.
					/// </summary>
					/// <param name="sEventType">A string containing one or more JavaScript event types, such as "click" or "blur".</param>
					/// <returns>Returns <code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.Control attachBrowserEvent(string sEventType);

					/// <summary>
					/// Allows binding handlers for any native browser event to the root HTML element of this Control. This internally handles DOM element replacements caused by re-rendering.
					/// 
					/// <b>IMPORTANT:</b></br> This should be only used as FALLBACK when the Control events do not cover a specific use-case! Always try using SAPUI5 control events, as e.g. accessibility-related functionality is then provided automatically. E.g. when working with a <code>sap.ui.commons.Button</code>, always use the Button's "press" event, not the native "click" event, because "press" is also guaranteed to be fired when certain keyboard activity is supposed to trigger the Button.
					/// 
					/// In the event handler, <code>this</code> refers to the Control - not to the root DOM element like in jQuery. While the DOM element can be used and modified, the general caveats for working with SAPUI5 control DOM elements apply. In particular the DOM element may be destroyed and replaced by a new one at any time, so modifications that are required to have permanent effect may not be done. E.g. use {@link sap.ui.core.Control.prototype.addStyleClass} instead if the modification is of visual nature.
					/// 
					/// Use {@link #detachBrowserEvent} to remove the event handler(s) again.
					/// </summary>
					/// <returns>Returns <code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.Control attachBrowserEvent();

					/// <summary>
					/// Allows binding handlers for any native browser event to the root HTML element of this Control. This internally handles DOM element replacements caused by re-rendering.
					/// 
					/// <b>IMPORTANT:</b></br> This should be only used as FALLBACK when the Control events do not cover a specific use-case! Always try using SAPUI5 control events, as e.g. accessibility-related functionality is then provided automatically. E.g. when working with a <code>sap.ui.commons.Button</code>, always use the Button's "press" event, not the native "click" event, because "press" is also guaranteed to be fired when certain keyboard activity is supposed to trigger the Button.
					/// 
					/// In the event handler, <code>this</code> refers to the Control - not to the root DOM element like in jQuery. While the DOM element can be used and modified, the general caveats for working with SAPUI5 control DOM elements apply. In particular the DOM element may be destroyed and replaced by a new one at any time, so modifications that are required to have permanent effect may not be done. E.g. use {@link sap.ui.core.Control.prototype.addStyleClass} instead if the modification is of visual nature.
					/// 
					/// Use {@link #detachBrowserEvent} to remove the event handler(s) again.
					/// </summary>
					/// <param name="fnHandler">A function to execute each time the event is triggered.</param>
					/// <returns>Returns <code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.Control attachBrowserEvent(object fnHandler);

					/// <summary>
					/// Allows binding handlers for any native browser event to the root HTML element of this Control. This internally handles DOM element replacements caused by re-rendering.
					/// 
					/// <b>IMPORTANT:</b></br> This should be only used as FALLBACK when the Control events do not cover a specific use-case! Always try using SAPUI5 control events, as e.g. accessibility-related functionality is then provided automatically. E.g. when working with a <code>sap.ui.commons.Button</code>, always use the Button's "press" event, not the native "click" event, because "press" is also guaranteed to be fired when certain keyboard activity is supposed to trigger the Button.
					/// 
					/// In the event handler, <code>this</code> refers to the Control - not to the root DOM element like in jQuery. While the DOM element can be used and modified, the general caveats for working with SAPUI5 control DOM elements apply. In particular the DOM element may be destroyed and replaced by a new one at any time, so modifications that are required to have permanent effect may not be done. E.g. use {@link sap.ui.core.Control.prototype.addStyleClass} instead if the modification is of visual nature.
					/// 
					/// Use {@link #detachBrowserEvent} to remove the event handler(s) again.
					/// </summary>
					/// <param name="fnHandler">A function to execute each time the event is triggered.</param>
					/// <param name="oListener">The object, that wants to be notified, when the event occurs</param>
					/// <returns>Returns <code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.Control attachBrowserEvent(object fnHandler, object oListener);

					/// <summary>
					/// Returns whether the control has a given field group. If <code>vFieldGroupIds</code> is not given it checks whether at least one field group ID is given for this control. If <code>vFieldGroupIds</code> is an empty array or empty string, true is returned if there is no field group ID set for this control. If <code>vFieldGroupIds</code> is a string array or a string all expected field group IDs are checked and true is returned if all are contained for given for this control. The comma delimiter can be used to separate multiple field group IDs in one string.
					/// </summary>
					/// <param name="vFieldGroupIds">ID of the field group or an array of field group IDs to match</param>
					/// <returns>true if a field group ID matches</returns>
					public extern virtual bool checkFieldGroupIds(Union<string, string[]> vFieldGroupIds);

					/// <summary>
					/// Returns whether the control has a given field group. If <code>vFieldGroupIds</code> is not given it checks whether at least one field group ID is given for this control. If <code>vFieldGroupIds</code> is an empty array or empty string, true is returned if there is no field group ID set for this control. If <code>vFieldGroupIds</code> is a string array or a string all expected field group IDs are checked and true is returned if all are contained for given for this control. The comma delimiter can be used to separate multiple field group IDs in one string.
					/// </summary>
					/// <returns>true if a field group ID matches</returns>
					public extern virtual bool checkFieldGroupIds();

					/// <summary>
					/// Overrides {@link sap.ui.core.Element#clone Element.clone} to clone additional internal state.
					/// 
					/// The additionally cloned information contains: <ul> <li>browser event handlers attached with {@link #attachBrowserEvent}</li> <li>text selection behavior</li> <li>style classes added with {@link #addStyleClass}</li> </ul>
					/// </summary>
					/// <param name="sIdSuffix">a suffix to be appended to the cloned element id</param>
					/// <param name="aLocalIds">an array of local IDs within the cloned hierarchy (internally used)</param>
					/// <returns>reference to the newly created clone</returns>
					public extern override sap.ui.core.Element clone(string sIdSuffix, string[] aLocalIds);

					/// <summary>
					/// Overrides {@link sap.ui.core.Element#clone Element.clone} to clone additional internal state.
					/// 
					/// The additionally cloned information contains: <ul> <li>browser event handlers attached with {@link #attachBrowserEvent}</li> <li>text selection behavior</li> <li>style classes added with {@link #addStyleClass}</li> </ul>
					/// </summary>
					/// <param name="sIdSuffix">a suffix to be appended to the cloned element id</param>
					/// <param name="aLocalIds">an array of local IDs within the cloned hierarchy (internally used)</param>
					/// <returns>reference to the newly created clone</returns>
					public extern override sap.ui.core.Element clone(string sIdSuffix, object[] aLocalIds);

					/// <summary>
					/// Overrides {@link sap.ui.core.Element#clone Element.clone} to clone additional internal state.
					/// 
					/// The additionally cloned information contains: <ul> <li>browser event handlers attached with {@link #attachBrowserEvent}</li> <li>text selection behavior</li> <li>style classes added with {@link #addStyleClass}</li> </ul>
					/// </summary>
					/// <param name="sIdSuffix">a suffix to be appended to the cloned element id</param>
					/// <returns>reference to the newly created clone</returns>
					public extern override sap.ui.core.Element clone(string sIdSuffix);

					/// <summary>
					/// Overrides {@link sap.ui.core.Element#clone Element.clone} to clone additional internal state.
					/// 
					/// The additionally cloned information contains: <ul> <li>browser event handlers attached with {@link #attachBrowserEvent}</li> <li>text selection behavior</li> <li>style classes added with {@link #addStyleClass}</li> </ul>
					/// </summary>
					/// <returns>reference to the newly created clone</returns>
					public extern override sap.ui.core.Element clone();

					/// <summary>
					/// Overrides {@link sap.ui.core.Element#clone Element.clone} to clone additional internal state.
					/// 
					/// The additionally cloned information contains: <ul> <li>browser event handlers attached with {@link #attachBrowserEvent}</li> <li>text selection behavior</li> <li>style classes added with {@link #addStyleClass}</li> </ul>
					/// </summary>
					/// <param name="aLocalIds">an array of local IDs within the cloned hierarchy (internally used)</param>
					/// <returns>reference to the newly created clone</returns>
					public extern override sap.ui.core.Element clone(string[] aLocalIds);

					/// <summary>
					/// Overrides {@link sap.ui.core.Element#clone Element.clone} to clone additional internal state.
					/// 
					/// The additionally cloned information contains: <ul> <li>browser event handlers attached with {@link #attachBrowserEvent}</li> <li>text selection behavior</li> <li>style classes added with {@link #addStyleClass}</li> </ul>
					/// </summary>
					/// <param name="aLocalIds">an array of local IDs within the cloned hierarchy (internally used)</param>
					/// <returns>reference to the newly created clone</returns>
					public extern override sap.ui.core.Element clone(object[] aLocalIds);

					/// <summary>
					/// Removes event handlers which have been previously attached using {@link #attachBrowserEvent}.
					/// 
					/// Note: listeners are only removed, if the same combination of event type, callback function and context object is given as in the call to <code>attachBrowserEvent</code>.
					/// </summary>
					/// <param name="sEventType">A string containing one or more JavaScript event types, such as "click" or "blur".</param>
					/// <param name="fnHandler">The function that is to be no longer executed.</param>
					/// <param name="oListener">The context object that was given in the call to <code>attachBrowserEvent</code>.</param>
					public extern virtual void detachBrowserEvent(string sEventType, object fnHandler, object oListener);

					/// <summary>
					/// Removes event handlers which have been previously attached using {@link #attachBrowserEvent}.
					/// 
					/// Note: listeners are only removed, if the same combination of event type, callback function and context object is given as in the call to <code>attachBrowserEvent</code>.
					/// </summary>
					/// <param name="sEventType">A string containing one or more JavaScript event types, such as "click" or "blur".</param>
					/// <param name="fnHandler">The function that is to be no longer executed.</param>
					public extern virtual void detachBrowserEvent(string sEventType, object fnHandler);

					/// <summary>
					/// Removes event handlers which have been previously attached using {@link #attachBrowserEvent}.
					/// 
					/// Note: listeners are only removed, if the same combination of event type, callback function and context object is given as in the call to <code>attachBrowserEvent</code>.
					/// </summary>
					/// <param name="sEventType">A string containing one or more JavaScript event types, such as "click" or "blur".</param>
					public extern virtual void detachBrowserEvent(string sEventType);

					/// <summary>
					/// Removes event handlers which have been previously attached using {@link #attachBrowserEvent}.
					/// 
					/// Note: listeners are only removed, if the same combination of event type, callback function and context object is given as in the call to <code>attachBrowserEvent</code>.
					/// </summary>
					public extern virtual void detachBrowserEvent();

					/// <summary>
					/// Removes event handlers which have been previously attached using {@link #attachBrowserEvent}.
					/// 
					/// Note: listeners are only removed, if the same combination of event type, callback function and context object is given as in the call to <code>attachBrowserEvent</code>.
					/// </summary>
					/// <param name="fnHandler">The function that is to be no longer executed.</param>
					public extern virtual void detachBrowserEvent(object fnHandler);

					/// <summary>
					/// Removes event handlers which have been previously attached using {@link #attachBrowserEvent}.
					/// 
					/// Note: listeners are only removed, if the same combination of event type, callback function and context object is given as in the call to <code>attachBrowserEvent</code>.
					/// </summary>
					/// <param name="fnHandler">The function that is to be no longer executed.</param>
					/// <param name="oListener">The context object that was given in the call to <code>attachBrowserEvent</code>.</param>
					public extern virtual void detachBrowserEvent(object fnHandler, object oListener);

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.Control with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.Control with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.Control with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// This function (if available on the concrete control) provides the current accessibility state of the control.
					/// 
					/// Applications must not call this hook method directly, it is called by the framework.
					/// 
					/// Subclasses of Control should implement this hook to provide any necessary accessibility information:
					/// 
					/// <pre>
					/// MyControl.prototype.getAccessibilityInfo = function() {
					///    return {
					///      role: "textbox",      // String which represents the WAI-ARIA role which is implemented by the control.
					///      type: "date input",   // String which represents the control type (Must be a translated text). Might correlate with
					///                            // the role.
					///      description: "value", // String which describes the most relevant control state (e.g. the inputs value). Must be a
					///                            // translated text.
					///                            // Note: The type and the enabled/editable state must not be handled here.
					///      focusable: true,      // Boolean which describes whether the control can get the focus.
					///      enabled: true,        // Boolean which describes whether the control is enabled. If not relevant it must not be set or
					///                            // <code>null</code> can be provided.
					///      editable: true,       // Boolean which describes whether the control is editable. If not relevant it must not be set or
					///                            // <code>null</code> can be provided.
					///      children: []          // Aggregations of the given control (e.g. when the control is a layout). Primitive aggregations will be ignored.
					///                            // Note: Children should only be provided when it is helpful to understand the accessibility context
					///                            //       (e.g. a form control must not provide details of its internals (fields, labels, ...) but a
					///                            //       layout should).
					///    };
					/// };
					/// </pre>
					/// 
					/// Note: The returned object provides the accessibility state of the control at the point in time when this function is called.
					/// </summary>
					/// <returns>Current accessibility state of the control.</returns>
					public extern virtual object getAccessibilityInfo();

					/// <summary>
					/// Returns a list of all child controls with a field group ID. See {@link #checkFieldGroupIds checkFieldGroupIds} for a description of the <code>vFieldGroupIds</code> parameter. Associated controls are not taken into account.
					/// </summary>
					/// <param name="vFieldGroupIds">ID of the field group or an array of field group IDs to match</param>
					/// <returns>The list of controls with a field group ID</returns>
					public extern virtual sap.ui.core.Control[] getControlsByFieldGroupId(Union<string, string[]> vFieldGroupIds);

					/// <summary>
					/// Returns a list of all child controls with a field group ID. See {@link #checkFieldGroupIds checkFieldGroupIds} for a description of the <code>vFieldGroupIds</code> parameter. Associated controls are not taken into account.
					/// </summary>
					/// <returns>The list of controls with a field group ID</returns>
					public extern virtual sap.ui.core.Control[] getControlsByFieldGroupId();

					/// <summary>
					/// Returns the DOMNode Id to be used for the "labelFor" attribute of the label.
					/// 
					/// By default, this is the Id of the control itself.
					/// </summary>
					/// <returns>Id to be used for the <code>labelFor</code></returns>
					public extern virtual string getIdForLabel();

					/// <summary>
					/// Returns a metadata object for class sap.ui.core.Control.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					/// <summary>
					/// Returns a renderer for this control instance.
					/// 
					/// It is retrieved using the RenderManager as done during rendering.
					/// </summary>
					/// <returns>a Renderer suitable for this Control instance.</returns>
					public extern virtual object getRenderer();

					/// <summary>
					/// Returns true if the given style class or all multiple style classes which are generated by splitting the given string with space are already set on the control via previous call(s) to addStyleClass().
					/// </summary>
					/// <param name="sStyleClass">the style to check for</param>
					/// <returns></returns>
					public extern virtual bool hasStyleClass(string sStyleClass);

					/// <summary>
					/// Triggers rerendering of this element and its children.
					/// 
					/// As <code>sap.ui.core.Element</code> "bubbles up" the invalidate, changes to children potentially result in rerendering of the whole sub tree.
					/// 
					/// The <code>oOrigin</code> parameter was introduced to allow parent controls to limit their rerendering to certain areas that have been invalidated by their children. As there is no strong guideline for control developers to provide the parameter, it is not a reliable source of information. It is therefore not recommended in general to use it, only in scenarios where a control and its descendants know each other very well (e.g. complex controls where parent and children have the same code owner).
					/// </summary>
					/// <param name="oOrigin">Child control for which the method was called</param>
					public extern virtual void invalidate(sap.ui.@base.ManagedObject oOrigin);

					/// <summary>
					/// Triggers rerendering of this element and its children.
					/// 
					/// As <code>sap.ui.core.Element</code> "bubbles up" the invalidate, changes to children potentially result in rerendering of the whole sub tree.
					/// 
					/// The <code>oOrigin</code> parameter was introduced to allow parent controls to limit their rerendering to certain areas that have been invalidated by their children. As there is no strong guideline for control developers to provide the parameter, it is not a reliable source of information. It is therefore not recommended in general to use it, only in scenarios where a control and its descendants know each other very well (e.g. complex controls where parent and children have the same code owner).
					/// </summary>
					public extern virtual void invalidate();

					/// <summary>
					/// Check if the control is currently in busy state.
					/// </summary>
					[Obsolete("Deprecated since 1.15. use {@link #getBusy} instead")]
					/// <returns>boolean</returns>
					public extern virtual void isBusy();

					/// <summary>
					/// Function is called when the rendering of the control is completed.
					/// 
					/// Applications must not call this hook method directly, it is called by the framework.
					/// 
					/// Subclasses of Control should override this hook to implement any necessary actions after the rendering.
					/// </summary>
					public extern virtual void onAfterRendering();

					/// <summary>
					/// Function is called before the rendering of the control is started.
					/// 
					/// Applications must not call this hook method directly, it is called by the framework.
					/// 
					/// Subclasses of Control should override this hook to implement any necessary actions before the rendering.
					/// </summary>
					public extern virtual void onBeforeRendering();

					/// <summary>
					/// Puts <code>this</code> control into the specified container (<code>oRef</code>) at the given position (<code>oPosition</code>).
					/// 
					/// First it is checked whether <code>oRef</code> is a container element / control (has a multiple aggregation with type <code>sap.ui.core.Control</code> and name 'content') or is an Id String of such a container. If this is not the case <code>oRef</code> can either be a Dom Reference or Id String of the UIArea (if it does not yet exist implicitly a new UIArea is created),
					/// 
					/// The <code>oPosition</code> can be one of the following:
					/// 
					/// <ul> <li>"first": The control is added as the first element to the container.</li> <li>"last": The control is added as the last element to the container (default).</li> <li>"only": All existing children of the container are removed (not destroyed!) and the control is added as new child.</li> <li><i>index</i>: The control is added at the specified <i>index</i> to the container.</li> </ul>
					/// </summary>
					/// <param name="oRef">container into which the control should be put</param>
					/// <param name="vPosition">Describes the position where the control should be put into the container</param>
					/// <returns>Returns <code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.Control placeAt(Union<string, dom.HTMLElement, sap.ui.core.Control> oRef, Union<string, int> vPosition);

					/// <summary>
					/// Puts <code>this</code> control into the specified container (<code>oRef</code>) at the given position (<code>oPosition</code>).
					/// 
					/// First it is checked whether <code>oRef</code> is a container element / control (has a multiple aggregation with type <code>sap.ui.core.Control</code> and name 'content') or is an Id String of such a container. If this is not the case <code>oRef</code> can either be a Dom Reference or Id String of the UIArea (if it does not yet exist implicitly a new UIArea is created),
					/// 
					/// The <code>oPosition</code> can be one of the following:
					/// 
					/// <ul> <li>"first": The control is added as the first element to the container.</li> <li>"last": The control is added as the last element to the container (default).</li> <li>"only": All existing children of the container are removed (not destroyed!) and the control is added as new child.</li> <li><i>index</i>: The control is added at the specified <i>index</i> to the container.</li> </ul>
					/// </summary>
					/// <param name="oRef">container into which the control should be put</param>
					/// <returns>Returns <code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.Control placeAt(Union<string, dom.HTMLElement, sap.ui.core.Control> oRef);

					/// <summary>
					/// Removes the given string from the list of custom style classes that have been set previously. Regular style classes like "sapUiBtn" cannot be removed.
					/// </summary>
					/// <param name="sStyleClass">the style to be removed</param>
					/// <returns>Returns <code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.Control removeStyleClass(string sStyleClass);

					/// <summary>
					/// Tries to replace its DOM reference by re-rendering.
					/// </summary>
					public extern override void rerender();

					/// <summary>
					/// The string given as "sStyleClass" will be be either added to or removed from the "class" attribute of this control's root HTML element, depending on the value of "bAdd": if bAdd is true, sStyleClass will be added. If bAdd is not given, sStyleClass will be removed if it is currently present and will be added if not present. If sStyleClass is null or empty string, the call is ignored.
					/// 
					/// See addStyleClass and removeStyleClass for further documentation.
					/// </summary>
					/// <param name="sStyleClass">the CSS class name to be added or removed</param>
					/// <param name="bAdd">whether sStyleClass should be added (or removed); when this parameter is not given, sStyleClass will be toggled (removed, if present, and added if not present)</param>
					/// <returns>Returns <code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.Control toggleStyleClass(string sStyleClass, bool bAdd);

					/// <summary>
					/// Triggers the <code>validateFieldGroup</code> event for this control.
					/// 
					/// Called by <code>sap.ui.core.UIArea</code> if a field group should be validated after it lost the focus or when the key combination was pressed that was configured to trigger validation (defined in the UI area member <code>UIArea._oFieldGroupValidationKey</code>).
					/// 
					/// See {@link #attachValidateFieldGroup}.
					/// </summary>
					public extern virtual void triggerValidateFieldGroup();

					#endregion

					#endregion

				}
			}
		}
	}
}
