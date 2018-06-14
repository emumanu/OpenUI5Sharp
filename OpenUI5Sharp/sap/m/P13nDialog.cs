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
			/// The P13nDialog control provides a dialog that contains one or more panels. On each of the panels, one or more changes with regards to a table can be processed. For example, a panel to set a column to invisible, change the order of the columns or a panel to sort or filter tables.
			/// </summary>
			[External]
			[Namespace(false)]
			public partial class P13nDialog : sap.m.Dialog
			{
				#region Settings

				/// <summary>
				/// Settings class to create the object
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class Settings : sap.m.Dialog.Settings
				{
					/// <summary>
					/// This property determines which panel is initially shown when dialog is opened. Due to extensibility reason the type should be <code>string</code>. So it is feasible to add a custom panel without expanding the type.
					/// </summary>
					public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> initialVisiblePanelType;

					/// <summary>
					/// This property determines whether the 'Restore' button is shown inside the dialog. If this property is set to true, clicking the 'Reset' button will trigger the <code>reset</code> event sending a notification that model data must be reset.
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> showReset;

					/// <summary>
					/// This property determines whether the 'Restore' button is enabled and is taken into account only if <code>showReset</code> is set to <code>true</code>.
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> showResetEnabled;

					/// <summary>
					/// Calls the validation listener once all panel-relevant validation checks have been done. This callback function is called in order to perform cross-model validation checks.
					/// </summary>
					public Union<object, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> validationExecutor;

					/// <summary>
					/// The dialog panels displayed in the dialog.
					/// </summary>
					public Union<sap.m.P13nPanel[], string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> panels;

					/// <summary>
					/// Event fired if the 'ok' button in <code>P13nDialog</code> is clicked.
					/// </summary>
					public sap.ui.@base.EventDelegate ok;

					/// <summary>
					/// Event fired if the 'cancel' button in <code>P13nDialog</code> is clicked.
					/// </summary>
					public sap.ui.@base.EventDelegate cancel;

					/// <summary>
					/// Event fired if the 'reset' button in <code>P13nDialog</code> is clicked.
					/// </summary>
					public sap.ui.@base.EventDelegate reset;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new P13nDialog.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">initial settings for the new control</param>
				public extern P13nDialog(string sId, sap.m.P13nDialog.Settings mSettings);

				/// <summary>
				/// Constructor for a new P13nDialog.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern P13nDialog(string sId);

				/// <summary>
				/// Constructor for a new P13nDialog.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern P13nDialog();

				/// <summary>
				/// Constructor for a new P13nDialog.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">initial settings for the new control</param>
				public extern P13nDialog(sap.m.P13nDialog.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property initialVisiblePanelType

				/// <summary>
				/// Gets current value of property {@link #getInitialVisiblePanelType initialVisiblePanelType}.
				/// 
				/// This property determines which panel is initially shown when dialog is opened. Due to extensibility reason the type should be <code>string</code>. So it is feasible to add a custom panel without expanding the type.
				/// </summary>
				/// <returns>Value of property <code>initialVisiblePanelType</code></returns>
				public extern virtual string getInitialVisiblePanelType();

				/// <summary>
				/// Sets a new value for property {@link #getInitialVisiblePanelType initialVisiblePanelType}.
				/// 
				/// This property determines which panel is initially shown when dialog is opened. Due to extensibility reason the type should be <code>string</code>. So it is feasible to add a custom panel without expanding the type.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sInitialVisiblePanelType">New value for property <code>initialVisiblePanelType</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nDialog setInitialVisiblePanelType(string sInitialVisiblePanelType);

				#endregion

				#region Methods for Property showReset

				/// <summary>
				/// Gets current value of property {@link #getShowReset showReset}.
				/// 
				/// This property determines whether the 'Restore' button is shown inside the dialog. If this property is set to true, clicking the 'Reset' button will trigger the <code>reset</code> event sending a notification that model data must be reset.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>showReset</code></returns>
				public extern virtual bool getShowReset();

				/// <summary>
				/// Sets a new value for property {@link #getShowReset showReset}.
				/// 
				/// This property determines whether the 'Restore' button is shown inside the dialog. If this property is set to true, clicking the 'Reset' button will trigger the <code>reset</code> event sending a notification that model data must be reset.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bShowReset">New value for property <code>showReset</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nDialog setShowReset(bool bShowReset);

				#endregion

				#region Methods for Property showResetEnabled

				/// <summary>
				/// Gets current value of property {@link #getShowResetEnabled showResetEnabled}.
				/// 
				/// This property determines whether the 'Restore' button is enabled and is taken into account only if <code>showReset</code> is set to <code>true</code>.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>showResetEnabled</code></returns>
				public extern virtual bool getShowResetEnabled();

				/// <summary>
				/// Sets a new value for property {@link #getShowResetEnabled showResetEnabled}.
				/// 
				/// This property determines whether the 'Restore' button is enabled and is taken into account only if <code>showReset</code> is set to <code>true</code>.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bShowResetEnabled">New value for property <code>showResetEnabled</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nDialog setShowResetEnabled(bool bShowResetEnabled);

				#endregion

				#region Methods for Property validationExecutor

				/// <summary>
				/// Gets current value of property {@link #getValidationExecutor validationExecutor}.
				/// 
				/// Calls the validation listener once all panel-relevant validation checks have been done. This callback function is called in order to perform cross-model validation checks.
				/// </summary>
				/// <returns>Value of property <code>validationExecutor</code></returns>
				public extern virtual object getValidationExecutor();

				/// <summary>
				/// Sets a new value for property {@link #getValidationExecutor validationExecutor}.
				/// 
				/// Calls the validation listener once all panel-relevant validation checks have been done. This callback function is called in order to perform cross-model validation checks.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="oValidationExecutor">New value for property <code>validationExecutor</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nDialog setValidationExecutor(object oValidationExecutor);

				#endregion

				#region Methods for Aggregation panels

				/// <summary>
				/// Gets content of aggregation {@link #getPanels panels}.
				/// 
				/// The dialog panels displayed in the dialog.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.P13nPanel[] getPanels();

				/// <summary>
				/// Destroys all the panels in the aggregation {@link #getPanels panels}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nDialog destroyPanels();

				/// <summary>
				/// Inserts a panel into the aggregation {@link #getPanels panels}.
				/// </summary>
				/// <param name="oPanel">The panel to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the panel should be inserted at; for a negative value of <code>iIndex</code>, the panel is inserted at position 0; for a value greater than the current size of the aggregation, the panel is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nDialog insertPanel(sap.m.P13nPanel oPanel, int iIndex);

				/// <summary>
				/// Adds some panel to the aggregation {@link #getPanels panels}.
				/// </summary>
				/// <param name="oPanel">The panel to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nDialog addPanel(sap.m.P13nPanel oPanel);

				/// <summary>
				/// Removes a panel from the aggregation {@link #getPanels panels}.
				/// </summary>
				/// <param name="vPanel">The panel to remove or its index or id</param>
				/// <returns>The removed panel or <code>null</code></returns>
				public extern virtual sap.m.P13nPanel removePanel(Union<int, string, sap.m.P13nPanel> vPanel);

				/// <summary>
				/// Checks for the provided <code>sap.m.P13nPanel</code> in the aggregation {@link #getPanels panels}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oPanel">The panel whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfPanel(sap.m.P13nPanel oPanel);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getPanels panels}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.m.P13nPanel[] removeAllPanels();

				/// <summary>
				/// Binds aggregation {@link #getPanels panels} to model data.
				/// 
				/// See {@link sap.ui.base.ManagedObject#bindAggregation ManagedObject.bindAggregation} for a detailed description of the possible properties of <code>oBindingInfo</code>.
				/// </summary>
				/// <param name="oBindingInfo">The binding information</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nDialog bindPanels(object oBindingInfo);

				/// <summary>
				/// Unbinds aggregation {@link #getPanels panels} from model data.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nDialog unbindPanels();

				#endregion

				#region Methods for Event ok

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:ok ok} event of this <code>sap.m.P13nDialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nDialog</code> itself.
				/// 
				/// Event fired if the 'ok' button in <code>P13nDialog</code> is clicked.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.P13nDialog</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nDialog attachOk(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:ok ok} event of this <code>sap.m.P13nDialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nDialog</code> itself.
				/// 
				/// Event fired if the 'ok' button in <code>P13nDialog</code> is clicked.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nDialog attachOk(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:ok ok} event of this <code>sap.m.P13nDialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nDialog</code> itself.
				/// 
				/// Event fired if the 'ok' button in <code>P13nDialog</code> is clicked.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nDialog attachOk(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:ok ok} event of this <code>sap.m.P13nDialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nDialog</code> itself.
				/// 
				/// Event fired if the 'ok' button in <code>P13nDialog</code> is clicked.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.P13nDialog</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nDialog attachOk(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:ok ok} event of this <code>sap.m.P13nDialog</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nDialog detachOk(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:ok ok} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nDialog fireOk(object mParameters);

				/// <summary>
				/// Fires event {@link #event:ok ok} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nDialog fireOk();

				#endregion

				#region Methods for Event cancel

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:cancel cancel} event of this <code>sap.m.P13nDialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nDialog</code> itself.
				/// 
				/// Event fired if the 'cancel' button in <code>P13nDialog</code> is clicked.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.P13nDialog</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nDialog attachCancel(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:cancel cancel} event of this <code>sap.m.P13nDialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nDialog</code> itself.
				/// 
				/// Event fired if the 'cancel' button in <code>P13nDialog</code> is clicked.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nDialog attachCancel(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:cancel cancel} event of this <code>sap.m.P13nDialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nDialog</code> itself.
				/// 
				/// Event fired if the 'cancel' button in <code>P13nDialog</code> is clicked.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nDialog attachCancel(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:cancel cancel} event of this <code>sap.m.P13nDialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nDialog</code> itself.
				/// 
				/// Event fired if the 'cancel' button in <code>P13nDialog</code> is clicked.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.P13nDialog</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nDialog attachCancel(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:cancel cancel} event of this <code>sap.m.P13nDialog</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nDialog detachCancel(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:cancel cancel} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nDialog fireCancel(object mParameters);

				/// <summary>
				/// Fires event {@link #event:cancel cancel} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nDialog fireCancel();

				#endregion

				#region Methods for Event reset

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:reset reset} event of this <code>sap.m.P13nDialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nDialog</code> itself.
				/// 
				/// Event fired if the 'reset' button in <code>P13nDialog</code> is clicked.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.P13nDialog</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nDialog attachReset(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:reset reset} event of this <code>sap.m.P13nDialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nDialog</code> itself.
				/// 
				/// Event fired if the 'reset' button in <code>P13nDialog</code> is clicked.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nDialog attachReset(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:reset reset} event of this <code>sap.m.P13nDialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nDialog</code> itself.
				/// 
				/// Event fired if the 'reset' button in <code>P13nDialog</code> is clicked.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nDialog attachReset(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:reset reset} event of this <code>sap.m.P13nDialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nDialog</code> itself.
				/// 
				/// Event fired if the 'reset' button in <code>P13nDialog</code> is clicked.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.P13nDialog</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nDialog attachReset(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:reset reset} event of this <code>sap.m.P13nDialog</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nDialog detachReset(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:reset reset} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nDialog fireReset(object mParameters);

				/// <summary>
				/// Fires event {@link #event:reset reset} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nDialog fireReset();

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.P13nDialog with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.Dialog.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.P13nDialog with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.Dialog.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.P13nDialog with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.Dialog.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.P13nDialog.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				/// <summary>
				/// Returns visible panel.
				/// </summary>
				/// <returns>panel</returns>
				public extern virtual sap.m.P13nPanel getVisiblePanel();

				#endregion

				#endregion

			}
		}
	}
}
