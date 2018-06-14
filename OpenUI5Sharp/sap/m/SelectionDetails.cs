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
			/// The protected control provides a popover that displays the details of the items selected in the chart. This control should only be used in the toolbars of sap.suite.ui.commons.ChartContainer and sap.ui.comp.smartchart.SmartChart controls. Initially, the control is rendered as a button that opens the popup after clicking on it. <b><i>Note:</i></b>It is protected and should only be used within the framework itself.
			/// </summary>
			[External]
			[Namespace(false)]
			public partial class SelectionDetails : sap.ui.core.Control
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
					/// Contains {@link sap.m.SelectionDetailsItem items} that are displayed on the first page.
					/// </summary>
					public Union<sap.m.SelectionDetailsItem[], string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> items;

					/// <summary>
					/// Contains custom actions shown in the responsive toolbar below items on the first page.
					/// </summary>
					public Union<sap.ui.core.Item[], string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> actions;

					/// <summary>
					/// Contains actions that are rendered as a dedicated {@link sap.m.StandardListItem item}. In case an action group is pressed, a navigation should be triggered via <code>navTo</code> method. A maximum of 5 actionGroups is displayed inside the popover, though more can be added to the aggregation.
					/// </summary>
					public Union<sap.ui.core.Item[], string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> actionGroups;

					/// <summary>
					/// Event is triggered before the popover is open.
					/// </summary>
					public sap.ui.@base.EventDelegate beforeOpen;

					/// <summary>
					/// Event is triggered before the popover is closed.
					/// </summary>
					public sap.ui.@base.EventDelegate beforeClose;

					/// <summary>
					/// Event is triggered after a list item of {@link sap.m.SelectionDetailsItem} is pressed.
					/// </summary>
					public sap.m.SelectionDetails.NavigateDelegate navigate;

					/// <summary>
					/// Event is triggered when a custom action is pressed.
					/// </summary>
					public sap.m.SelectionDetails.ActionPressDelegate actionPress;

				}

				#endregion

				#region Typed Parameters

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class ActionPressInfo
				{
					/// <summary>
					/// The action that has to be processed once the action has been pressed
					/// </summary>
					public sap.ui.core.Item action;

					/// <summary>
					/// If the action is pressed on one of the {@link sap.m.SelectionDetailsItem items}, the parameter contains a reference to the pressed {@link sap.m.SelectionDetailsItem item}. If a custom action or action group of the SelectionDetails popover is pressed, this parameter refers to all {@link sap.m.SelectionDetailsItem items}
					/// </summary>
					public sap.m.SelectionDetailsItem items;

					/// <summary>
					/// The action level of action buttons. The available levels are Item, List and Group
					/// </summary>
					public sap.m.SelectionDetailsActionLevel level;

				}

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class NavigateInfo
				{
					/// <summary>
					/// The item on which the action has been pressed. Can be null in case a navigation was done without item context, e.g. action press.
					/// </summary>
					public sap.m.SelectionDetailsItem item;

					/// <summary>
					/// Direction of the triggered navigation, possible values are "to" and "back".
					/// </summary>
					public string direction;

					/// <summary>
					/// The content of the currently viewed page that was previously added via {@link sap.m.SelectionDetailsFacade#navTo}. This contains the content of the page before the navigation was triggered. Can be null in case of first event triggering.
					/// </summary>
					public sap.ui.core.Control content;

				}

				#endregion

				#region Delegates

				public delegate void ActionPressDelegate(sap.ui.@base.Event<sap.m.SelectionDetails.ActionPressInfo> oEvent, object oData);

				public delegate void NavigateDelegate(sap.ui.@base.Event<sap.m.SelectionDetails.NavigateInfo> oEvent, object oData);

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new SelectionDetails.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">id for the new control, generated automatically if no id is given</param>
				/// <param name="mSettings">initial settings for the new control</param>
				public extern SelectionDetails(string sId, sap.m.SelectionDetails.Settings mSettings);

				/// <summary>
				/// Constructor for a new SelectionDetails.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">id for the new control, generated automatically if no id is given</param>
				public extern SelectionDetails(string sId);

				/// <summary>
				/// Constructor for a new SelectionDetails.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern SelectionDetails();

				/// <summary>
				/// Constructor for a new SelectionDetails.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">initial settings for the new control</param>
				public extern SelectionDetails(sap.m.SelectionDetails.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Aggregation items

				/// <summary>
				/// Gets content of aggregation {@link #getItems items}.
				/// 
				/// Contains {@link sap.m.SelectionDetailsItem items} that are displayed on the first page.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.SelectionDetailsItem[] getItems();

				/// <summary>
				/// Destroys all the items in the aggregation {@link #getItems items}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectionDetails destroyItems();

				/// <summary>
				/// Inserts a item into the aggregation {@link #getItems items}.
				/// </summary>
				/// <param name="oItem">The item to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the item should be inserted at; for a negative value of <code>iIndex</code>, the item is inserted at position 0; for a value greater than the current size of the aggregation, the item is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectionDetails insertItem(sap.m.SelectionDetailsItem oItem, int iIndex);

				/// <summary>
				/// Adds some item to the aggregation {@link #getItems items}.
				/// </summary>
				/// <param name="oItem">The item to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectionDetails addItem(sap.m.SelectionDetailsItem oItem);

				/// <summary>
				/// Removes a item from the aggregation {@link #getItems items}.
				/// </summary>
				/// <param name="vItem">The item to remove or its index or id</param>
				/// <returns>The removed item or <code>null</code></returns>
				public extern virtual sap.m.SelectionDetailsItem removeItem(Union<int, string, sap.m.SelectionDetailsItem> vItem);

				/// <summary>
				/// Checks for the provided <code>sap.m.SelectionDetailsItem</code> in the aggregation {@link #getItems items}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oItem">The item whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfItem(sap.m.SelectionDetailsItem oItem);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getItems items}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.m.SelectionDetailsItem[] removeAllItems();

				/// <summary>
				/// Binds aggregation {@link #getItems items} to model data.
				/// 
				/// See {@link sap.ui.base.ManagedObject#bindAggregation ManagedObject.bindAggregation} for a detailed description of the possible properties of <code>oBindingInfo</code>.
				/// </summary>
				/// <param name="oBindingInfo">The binding information</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectionDetails bindItems(object oBindingInfo);

				/// <summary>
				/// Unbinds aggregation {@link #getItems items} from model data.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectionDetails unbindItems();

				#endregion

				#region Methods for Aggregation actions

				/// <summary>
				/// Gets content of aggregation {@link #getActions actions}.
				/// 
				/// Contains custom actions shown in the responsive toolbar below items on the first page.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.Item[] getActions();

				/// <summary>
				/// Destroys all the actions in the aggregation {@link #getActions actions}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectionDetails destroyActions();

				/// <summary>
				/// Inserts a action into the aggregation {@link #getActions actions}.
				/// </summary>
				/// <param name="oAction">The action to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the action should be inserted at; for a negative value of <code>iIndex</code>, the action is inserted at position 0; for a value greater than the current size of the aggregation, the action is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectionDetails insertAction(sap.ui.core.Item oAction, int iIndex);

				/// <summary>
				/// Adds some action to the aggregation {@link #getActions actions}.
				/// </summary>
				/// <param name="oAction">The action to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectionDetails addAction(sap.ui.core.Item oAction);

				/// <summary>
				/// Removes a action from the aggregation {@link #getActions actions}.
				/// </summary>
				/// <param name="vAction">The action to remove or its index or id</param>
				/// <returns>The removed action or <code>null</code></returns>
				public extern virtual sap.ui.core.Item removeAction(Union<int, string, sap.ui.core.Item> vAction);

				/// <summary>
				/// Checks for the provided <code>sap.ui.core.Item</code> in the aggregation {@link #getActions actions}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oAction">The action whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfAction(sap.ui.core.Item oAction);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getActions actions}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.ui.core.Item[] removeAllActions();

				#endregion

				#region Methods for Aggregation actionGroups

				/// <summary>
				/// Gets content of aggregation {@link #getActionGroups actionGroups}.
				/// 
				/// Contains actions that are rendered as a dedicated {@link sap.m.StandardListItem item}. In case an action group is pressed, a navigation should be triggered via <code>navTo</code> method. A maximum of 5 actionGroups is displayed inside the popover, though more can be added to the aggregation.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.Item[] getActionGroups();

				/// <summary>
				/// Destroys all the actionGroups in the aggregation {@link #getActionGroups actionGroups}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectionDetails destroyActionGroups();

				/// <summary>
				/// Inserts a actionGroup into the aggregation {@link #getActionGroups actionGroups}.
				/// </summary>
				/// <param name="oActionGroup">The actionGroup to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the actionGroup should be inserted at; for a negative value of <code>iIndex</code>, the actionGroup is inserted at position 0; for a value greater than the current size of the aggregation, the actionGroup is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectionDetails insertActionGroup(sap.ui.core.Item oActionGroup, int iIndex);

				/// <summary>
				/// Adds some actionGroup to the aggregation {@link #getActionGroups actionGroups}.
				/// </summary>
				/// <param name="oActionGroup">The actionGroup to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectionDetails addActionGroup(sap.ui.core.Item oActionGroup);

				/// <summary>
				/// Removes a actionGroup from the aggregation {@link #getActionGroups actionGroups}.
				/// </summary>
				/// <param name="vActionGroup">The actionGroup to remove or its index or id</param>
				/// <returns>The removed actionGroup or <code>null</code></returns>
				public extern virtual sap.ui.core.Item removeActionGroup(Union<int, string, sap.ui.core.Item> vActionGroup);

				/// <summary>
				/// Checks for the provided <code>sap.ui.core.Item</code> in the aggregation {@link #getActionGroups actionGroups}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oActionGroup">The actionGroup whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfActionGroup(sap.ui.core.Item oActionGroup);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getActionGroups actionGroups}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.ui.core.Item[] removeAllActionGroups();

				#endregion

				#region Methods for Aggregation _popover

				#endregion

				#region Methods for Aggregation _button

				#endregion

				#region Methods for Event beforeOpen

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeOpen beforeOpen} event of this <code>sap.m.SelectionDetails</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SelectionDetails</code> itself.
				/// 
				/// Event is triggered before the popover is open.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.SelectionDetails</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectionDetails attachBeforeOpen(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeOpen beforeOpen} event of this <code>sap.m.SelectionDetails</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SelectionDetails</code> itself.
				/// 
				/// Event is triggered before the popover is open.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectionDetails attachBeforeOpen(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeOpen beforeOpen} event of this <code>sap.m.SelectionDetails</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SelectionDetails</code> itself.
				/// 
				/// Event is triggered before the popover is open.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectionDetails attachBeforeOpen(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeOpen beforeOpen} event of this <code>sap.m.SelectionDetails</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SelectionDetails</code> itself.
				/// 
				/// Event is triggered before the popover is open.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.SelectionDetails</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectionDetails attachBeforeOpen(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:beforeOpen beforeOpen} event of this <code>sap.m.SelectionDetails</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectionDetails detachBeforeOpen(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:beforeOpen beforeOpen} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectionDetails fireBeforeOpen(object mParameters);

				/// <summary>
				/// Fires event {@link #event:beforeOpen beforeOpen} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectionDetails fireBeforeOpen();

				#endregion

				#region Methods for Event beforeClose

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeClose beforeClose} event of this <code>sap.m.SelectionDetails</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SelectionDetails</code> itself.
				/// 
				/// Event is triggered before the popover is closed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.SelectionDetails</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectionDetails attachBeforeClose(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeClose beforeClose} event of this <code>sap.m.SelectionDetails</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SelectionDetails</code> itself.
				/// 
				/// Event is triggered before the popover is closed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectionDetails attachBeforeClose(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeClose beforeClose} event of this <code>sap.m.SelectionDetails</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SelectionDetails</code> itself.
				/// 
				/// Event is triggered before the popover is closed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectionDetails attachBeforeClose(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeClose beforeClose} event of this <code>sap.m.SelectionDetails</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SelectionDetails</code> itself.
				/// 
				/// Event is triggered before the popover is closed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.SelectionDetails</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectionDetails attachBeforeClose(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:beforeClose beforeClose} event of this <code>sap.m.SelectionDetails</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectionDetails detachBeforeClose(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:beforeClose beforeClose} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectionDetails fireBeforeClose(object mParameters);

				/// <summary>
				/// Fires event {@link #event:beforeClose beforeClose} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectionDetails fireBeforeClose();

				#endregion

				#region Methods for Event navigate

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:navigate navigate} event of this <code>sap.m.SelectionDetails</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SelectionDetails</code> itself.
				/// 
				/// Event is triggered after a list item of {@link sap.m.SelectionDetailsItem} is pressed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.SelectionDetails</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectionDetails attachNavigate(object oData, sap.m.SelectionDetails.NavigateDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:navigate navigate} event of this <code>sap.m.SelectionDetails</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SelectionDetails</code> itself.
				/// 
				/// Event is triggered after a list item of {@link sap.m.SelectionDetailsItem} is pressed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectionDetails attachNavigate(object oData, sap.m.SelectionDetails.NavigateDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:navigate navigate} event of this <code>sap.m.SelectionDetails</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SelectionDetails</code> itself.
				/// 
				/// Event is triggered after a list item of {@link sap.m.SelectionDetailsItem} is pressed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectionDetails attachNavigate(sap.m.SelectionDetails.NavigateDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:navigate navigate} event of this <code>sap.m.SelectionDetails</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SelectionDetails</code> itself.
				/// 
				/// Event is triggered after a list item of {@link sap.m.SelectionDetailsItem} is pressed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.SelectionDetails</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectionDetails attachNavigate(sap.m.SelectionDetails.NavigateDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:navigate navigate} event of this <code>sap.m.SelectionDetails</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectionDetails detachNavigate(sap.m.SelectionDetails.NavigateDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:navigate navigate} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectionDetails fireNavigate(sap.m.SelectionDetails.NavigateInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:navigate navigate} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectionDetails fireNavigate();

				#endregion

				#region Methods for Event actionPress

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:actionPress actionPress} event of this <code>sap.m.SelectionDetails</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SelectionDetails</code> itself.
				/// 
				/// Event is triggered when a custom action is pressed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.SelectionDetails</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectionDetails attachActionPress(object oData, sap.m.SelectionDetails.ActionPressDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:actionPress actionPress} event of this <code>sap.m.SelectionDetails</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SelectionDetails</code> itself.
				/// 
				/// Event is triggered when a custom action is pressed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectionDetails attachActionPress(object oData, sap.m.SelectionDetails.ActionPressDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:actionPress actionPress} event of this <code>sap.m.SelectionDetails</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SelectionDetails</code> itself.
				/// 
				/// Event is triggered when a custom action is pressed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectionDetails attachActionPress(sap.m.SelectionDetails.ActionPressDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:actionPress actionPress} event of this <code>sap.m.SelectionDetails</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SelectionDetails</code> itself.
				/// 
				/// Event is triggered when a custom action is pressed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.SelectionDetails</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectionDetails attachActionPress(sap.m.SelectionDetails.ActionPressDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:actionPress actionPress} event of this <code>sap.m.SelectionDetails</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectionDetails detachActionPress(sap.m.SelectionDetails.ActionPressDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:actionPress actionPress} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectionDetails fireActionPress(sap.m.SelectionDetails.ActionPressInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:actionPress actionPress} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectionDetails fireActionPress();

				#endregion

				#region Other methods

				/// <summary>
				/// Attaches an event handler to the given listener to react to user selection interaction.
				/// </summary>
				/// <param name="eventId">The identifier of the event to listen for</param>
				/// <param name="listener">The object which triggers the event to register on</param>
				/// <returns>this to allow method chaining</returns>
				public extern virtual sap.m.SelectionDetails attachSelectionHandler(string eventId, object listener);

				/// <summary>
				/// Detaches the event which was attached by <code>attachSelectionHandler</code>.
				/// </summary>
				/// <returns>this to allow method chaining</returns>
				public extern virtual sap.m.SelectionDetails detachSelectionHandler();

				/// <summary>
				/// Creates a new subclass of class sap.m.SelectionDetails with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.SelectionDetails with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.SelectionDetails with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns the public facade of the SelectionDetails control for non inner framework usages.
				/// </summary>
				/// <returns>The reduced facade for outer framework usages.</returns>
				public extern virtual sap.ui.@base.Interface getFacade();

				/// <summary>
				/// Returns a metadata object for class sap.m.SelectionDetails.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				/// <summary>
				/// Method to register the factory function that creates the SelectionDetailsItems. The factory function is called for every selected entry separately with three parameters. First parameter is the display data array for each item out of the selection. Second parameter is the data array for each item out of the selection. Third parameter is the binding context for each item in the selection. This is undefined if no binding is used. Fourth parameter is <code>oData</code>. Can be undefined.
				/// </summary>
				/// <param name="data">Data to be passed to the factory function</param>
				/// <param name="factory">The item factory function that returns SelectionDetailsItems</param>
				/// <returns>this to allow method chaining</returns>
				public extern virtual sap.m.SelectionDetails registerSelectionDetailsItemFactory(object data, object factory);

				/// <summary>
				/// Sets the popover to modal or non-modal based on the given parameter. This only takes effect on desktop or tablet. Please see the documentation {@link sap.m.ResponsivePopover#modal}.
				/// </summary>
				/// <param name="modal">New value for property modal of the internally used popover.</param>
				/// <returns>To ensure method chaining, return the SelectionDetails.</returns>
				public extern virtual sap.m.SelectionDetails setPopoverModal(bool modal);

				#endregion

				#endregion

			}
		}
	}
}
