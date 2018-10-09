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
			/// The <code>P13nColumnsPanel</code> control is used to define column-specific settings for table personalization.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.P13nColumnsPanel")]
			public partial class P13nColumnsPanel : sap.m.P13nPanel
			{
				#region Settings

				/// <summary>
				/// Settings class to create the object
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class Settings : sap.m.P13nPanel.Settings
				{
					/// <summary>
					/// Specifies a threshold of visible items. If the end user makes a lot of columns visible, this might cause performance to slow down. When this happens, the user can receive a corresponding warning triggered by the <code>visibleItemsThreshold</code> property. The property needs to be activated and set to the required value by the consuming application to ensure that the warning message is shown when the threshold has been exceeded. In the following example the message will be shown if more than 100 visible columns are selected:
					/// 
					/// <pre>
					/// customData&gt;
					/// core:CustomData key=&quot;p13nDialogSettings&quot;
					/// value='\{&quot;columns&quot;:\{&quot;visible&quot;: true, &quot;payload&quot;: \{&quot;visibleItemsThreshold&quot;: 3\}\}\}' /&gt;
					/// /customData&gt;
					/// </pre>
					/// </summary>
					public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> visibleItemsThreshold;

					/// <summary>
					/// List of columns that has been changed.
					/// </summary>
					public Union<sap.m.P13nColumnsItem[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> columnsItems;

					/// <summary>
					/// Event raised when a <code>columnsItem</code> is added.
					/// </summary>
					public sap.m.P13nColumnsPanel.AddColumnsItemDelegate addColumnsItem;

					/// <summary>
					/// Event raised if <code>columnsItems</code> is changed or new one needs to be created in the model.
					/// </summary>
					public sap.m.P13nColumnsPanel.ChangeColumnsItemsDelegate changeColumnsItems;

					/// <summary>
					/// Event raised if <code>setData</code> is called in model. The event serves the purpose of minimizing such calls since they can take up a lot of performance.
					/// </summary>
					public sap.ui.@base.EventDelegate setData;

				}

				#endregion

				#region Typed Parameters

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class AddColumnsItemInfo
				{
					/// <summary>
					/// <code>columnsItem</code> that needs to be added in the model.
					/// </summary>
					public sap.m.P13nColumnsItem newItem;

				}

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class ChangeColumnsItemsInfo
				{
					/// <summary>
					/// Contains <code>columnsItems</code> that needs to be created in the model. Deprecated as of version 1.50, replaced by new parameter <code>items</code>.
					/// </summary>
					public sap.m.P13nColumnsItem[] newItems;

					/// <summary>
					/// Contains <code>columnsItems</code> that needs to be changed in the model. Deprecated as of version 1.50, replaced by new parameter <code>items</code>.
					/// </summary>
					public sap.m.P13nColumnsItem[] existingItems;

					/// <summary>
					/// Array contains an object for each item in <code>items</code> aggregation enriched with index and visibility information. The item order reflects the current order of columns in the panel.
					/// </summary>
					public object[] items;

				}

				#endregion

				#region Delegates

				public delegate void AddColumnsItemDelegate(sap.ui.@base.Event<sap.m.P13nColumnsPanel.AddColumnsItemInfo> oEvent, object oData);

				public delegate void ChangeColumnsItemsDelegate(sap.ui.@base.Event<sap.m.P13nColumnsPanel.ChangeColumnsItemsInfo> oEvent, object oData);

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new P13nColumnsPanel.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">initial settings for the new control</param>
				public extern P13nColumnsPanel(string sId, sap.m.P13nColumnsPanel.Settings mSettings);

				/// <summary>
				/// Constructor for a new P13nColumnsPanel.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern P13nColumnsPanel(string sId);

				/// <summary>
				/// Constructor for a new P13nColumnsPanel.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern P13nColumnsPanel();

				/// <summary>
				/// Constructor for a new P13nColumnsPanel.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">initial settings for the new control</param>
				public extern P13nColumnsPanel(sap.m.P13nColumnsPanel.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property visibleItemsThreshold

				/// <summary>
				/// Gets current value of property {@link #getVisibleItemsThreshold visibleItemsThreshold}.
				/// 
				/// Specifies a threshold of visible items. If the end user makes a lot of columns visible, this might cause performance to slow down. When this happens, the user can receive a corresponding warning triggered by the <code>visibleItemsThreshold</code> property. The property needs to be activated and set to the required value by the consuming application to ensure that the warning message is shown when the threshold has been exceeded. In the following example the message will be shown if more than 100 visible columns are selected:
				/// 
				/// <pre>
				/// customData&gt;
				/// core:CustomData key=&quot;p13nDialogSettings&quot;
				/// value='\{&quot;columns&quot;:\{&quot;visible&quot;: true, &quot;payload&quot;: \{&quot;visibleItemsThreshold&quot;: 3\}\}\}' /&gt;
				/// /customData&gt;
				/// </pre>
				/// 
				/// Default value is <code>-1</code>.
				/// </summary>
				/// <returns>Value of property <code>visibleItemsThreshold</code></returns>
				public extern virtual int getVisibleItemsThreshold();

				/// <summary>
				/// Sets a new value for property {@link #getVisibleItemsThreshold visibleItemsThreshold}.
				/// 
				/// Specifies a threshold of visible items. If the end user makes a lot of columns visible, this might cause performance to slow down. When this happens, the user can receive a corresponding warning triggered by the <code>visibleItemsThreshold</code> property. The property needs to be activated and set to the required value by the consuming application to ensure that the warning message is shown when the threshold has been exceeded. In the following example the message will be shown if more than 100 visible columns are selected:
				/// 
				/// <pre>
				/// customData&gt;
				/// core:CustomData key=&quot;p13nDialogSettings&quot;
				/// value='\{&quot;columns&quot;:\{&quot;visible&quot;: true, &quot;payload&quot;: \{&quot;visibleItemsThreshold&quot;: 3\}\}\}' /&gt;
				/// /customData&gt;
				/// </pre>
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>-1</code>.
				/// </summary>
				/// <param name="iVisibleItemsThreshold">New value for property <code>visibleItemsThreshold</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nColumnsPanel setVisibleItemsThreshold(int iVisibleItemsThreshold);

				#endregion

				#region Methods for Aggregation columnsItems

				/// <summary>
				/// Gets content of aggregation {@link #getColumnsItems columnsItems}.
				/// 
				/// List of columns that has been changed.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.P13nColumnsItem[] getColumnsItems();

				/// <summary>
				/// Destroys all the columnsItems in the aggregation {@link #getColumnsItems columnsItems}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nColumnsPanel destroyColumnsItems();

				/// <summary>
				/// Inserts a columnsItem into the aggregation {@link #getColumnsItems columnsItems}.
				/// </summary>
				/// <param name="oColumnsItem">The columnsItem to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the columnsItem should be inserted at; for a negative value of <code>iIndex</code>, the columnsItem is inserted at position 0; for a value greater than the current size of the aggregation, the columnsItem is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nColumnsPanel insertColumnsItem(sap.m.P13nColumnsItem oColumnsItem, int iIndex);

				/// <summary>
				/// Adds some columnsItem to the aggregation {@link #getColumnsItems columnsItems}.
				/// </summary>
				/// <param name="oColumnsItem">The columnsItem to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nColumnsPanel addColumnsItem(sap.m.P13nColumnsItem oColumnsItem);

				/// <summary>
				/// Removes a columnsItem from the aggregation {@link #getColumnsItems columnsItems}.
				/// </summary>
				/// <param name="vColumnsItem">The columnsItem to remove or its index or id</param>
				/// <returns>The removed columnsItem or <code>null</code></returns>
				public extern virtual sap.m.P13nColumnsItem removeColumnsItem(Union<int, string, sap.m.P13nColumnsItem> vColumnsItem);

				/// <summary>
				/// Checks for the provided <code>sap.m.P13nColumnsItem</code> in the aggregation {@link #getColumnsItems columnsItems}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oColumnsItem">The columnsItem whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfColumnsItem(sap.m.P13nColumnsItem oColumnsItem);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getColumnsItems columnsItems}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.m.P13nColumnsItem[] removeAllColumnsItems();

				/// <summary>
				/// Binds aggregation {@link #getColumnsItems columnsItems} to model data.
				/// 
				/// See {@link sap.ui.base.ManagedObject#bindAggregation ManagedObject.bindAggregation} for a detailed description of the possible properties of <code>oBindingInfo</code>.
				/// </summary>
				/// <param name="oBindingInfo">The binding information</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nColumnsPanel bindColumnsItems(object oBindingInfo);

				/// <summary>
				/// Unbinds aggregation {@link #getColumnsItems columnsItems} from model data.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nColumnsPanel unbindColumnsItems();

				#endregion

				#region Methods for Aggregation content

				#endregion

				#region Methods for Event addColumnsItem

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:addColumnsItem addColumnsItem} event of this <code>sap.m.P13nColumnsPanel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nColumnsPanel</code> itself.
				/// 
				/// Event raised when a <code>columnsItem</code> is added.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.P13nColumnsPanel</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.50. replaced by extended event {@link sap.m.P13nColumnsPanel.html#changeColumnsItems}")]
				public extern virtual sap.m.P13nColumnsPanel attachAddColumnsItem(object oData, sap.m.P13nColumnsPanel.AddColumnsItemDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:addColumnsItem addColumnsItem} event of this <code>sap.m.P13nColumnsPanel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nColumnsPanel</code> itself.
				/// 
				/// Event raised when a <code>columnsItem</code> is added.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.50. replaced by extended event {@link sap.m.P13nColumnsPanel.html#changeColumnsItems}")]
				public extern virtual sap.m.P13nColumnsPanel attachAddColumnsItem(object oData, sap.m.P13nColumnsPanel.AddColumnsItemDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:addColumnsItem addColumnsItem} event of this <code>sap.m.P13nColumnsPanel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nColumnsPanel</code> itself.
				/// 
				/// Event raised when a <code>columnsItem</code> is added.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.50. replaced by extended event {@link sap.m.P13nColumnsPanel.html#changeColumnsItems}")]
				public extern virtual sap.m.P13nColumnsPanel attachAddColumnsItem(sap.m.P13nColumnsPanel.AddColumnsItemDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:addColumnsItem addColumnsItem} event of this <code>sap.m.P13nColumnsPanel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nColumnsPanel</code> itself.
				/// 
				/// Event raised when a <code>columnsItem</code> is added.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.P13nColumnsPanel</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.50. replaced by extended event {@link sap.m.P13nColumnsPanel.html#changeColumnsItems}")]
				public extern virtual sap.m.P13nColumnsPanel attachAddColumnsItem(sap.m.P13nColumnsPanel.AddColumnsItemDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:addColumnsItem addColumnsItem} event of this <code>sap.m.P13nColumnsPanel</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.50. replaced by extended event {@link sap.m.P13nColumnsPanel.html#changeColumnsItems}")]
				public extern virtual sap.m.P13nColumnsPanel detachAddColumnsItem(sap.m.P13nColumnsPanel.AddColumnsItemDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:addColumnsItem addColumnsItem} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.50. replaced by extended event {@link sap.m.P13nColumnsPanel.html#changeColumnsItems}")]
				public extern virtual sap.m.P13nColumnsPanel fireAddColumnsItem(sap.m.P13nColumnsPanel.AddColumnsItemInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:addColumnsItem addColumnsItem} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.50. replaced by extended event {@link sap.m.P13nColumnsPanel.html#changeColumnsItems}")]
				public extern virtual sap.m.P13nColumnsPanel fireAddColumnsItem();

				#endregion

				#region Methods for Event changeColumnsItems

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:changeColumnsItems changeColumnsItems} event of this <code>sap.m.P13nColumnsPanel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nColumnsPanel</code> itself.
				/// 
				/// Event raised if <code>columnsItems</code> is changed or new one needs to be created in the model.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.P13nColumnsPanel</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nColumnsPanel attachChangeColumnsItems(object oData, sap.m.P13nColumnsPanel.ChangeColumnsItemsDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:changeColumnsItems changeColumnsItems} event of this <code>sap.m.P13nColumnsPanel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nColumnsPanel</code> itself.
				/// 
				/// Event raised if <code>columnsItems</code> is changed or new one needs to be created in the model.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nColumnsPanel attachChangeColumnsItems(object oData, sap.m.P13nColumnsPanel.ChangeColumnsItemsDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:changeColumnsItems changeColumnsItems} event of this <code>sap.m.P13nColumnsPanel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nColumnsPanel</code> itself.
				/// 
				/// Event raised if <code>columnsItems</code> is changed or new one needs to be created in the model.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nColumnsPanel attachChangeColumnsItems(sap.m.P13nColumnsPanel.ChangeColumnsItemsDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:changeColumnsItems changeColumnsItems} event of this <code>sap.m.P13nColumnsPanel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nColumnsPanel</code> itself.
				/// 
				/// Event raised if <code>columnsItems</code> is changed or new one needs to be created in the model.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.P13nColumnsPanel</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nColumnsPanel attachChangeColumnsItems(sap.m.P13nColumnsPanel.ChangeColumnsItemsDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:changeColumnsItems changeColumnsItems} event of this <code>sap.m.P13nColumnsPanel</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nColumnsPanel detachChangeColumnsItems(sap.m.P13nColumnsPanel.ChangeColumnsItemsDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:changeColumnsItems changeColumnsItems} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nColumnsPanel fireChangeColumnsItems(sap.m.P13nColumnsPanel.ChangeColumnsItemsInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:changeColumnsItems changeColumnsItems} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nColumnsPanel fireChangeColumnsItems();

				#endregion

				#region Methods for Event setData

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:setData setData} event of this <code>sap.m.P13nColumnsPanel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nColumnsPanel</code> itself.
				/// 
				/// Event raised if <code>setData</code> is called in model. The event serves the purpose of minimizing such calls since they can take up a lot of performance.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.P13nColumnsPanel</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.50. the event <code>setData</code> is obsolete.")]
				public extern virtual sap.m.P13nColumnsPanel attachSetData(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:setData setData} event of this <code>sap.m.P13nColumnsPanel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nColumnsPanel</code> itself.
				/// 
				/// Event raised if <code>setData</code> is called in model. The event serves the purpose of minimizing such calls since they can take up a lot of performance.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.50. the event <code>setData</code> is obsolete.")]
				public extern virtual sap.m.P13nColumnsPanel attachSetData(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:setData setData} event of this <code>sap.m.P13nColumnsPanel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nColumnsPanel</code> itself.
				/// 
				/// Event raised if <code>setData</code> is called in model. The event serves the purpose of minimizing such calls since they can take up a lot of performance.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.50. the event <code>setData</code> is obsolete.")]
				public extern virtual sap.m.P13nColumnsPanel attachSetData(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:setData setData} event of this <code>sap.m.P13nColumnsPanel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nColumnsPanel</code> itself.
				/// 
				/// Event raised if <code>setData</code> is called in model. The event serves the purpose of minimizing such calls since they can take up a lot of performance.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.P13nColumnsPanel</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.50. the event <code>setData</code> is obsolete.")]
				public extern virtual sap.m.P13nColumnsPanel attachSetData(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:setData setData} event of this <code>sap.m.P13nColumnsPanel</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.50. the event <code>setData</code> is obsolete.")]
				public extern virtual sap.m.P13nColumnsPanel detachSetData(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:setData setData} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.50. the event <code>setData</code> is obsolete.")]
				public extern virtual sap.m.P13nColumnsPanel fireSetData(object mParameters);

				/// <summary>
				/// Fires event {@link #event:setData setData} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.50. the event <code>setData</code> is obsolete.")]
				public extern virtual sap.m.P13nColumnsPanel fireSetData();

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.P13nColumnsPanel with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.P13nPanel.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.P13nColumnsPanel with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.P13nPanel.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.P13nColumnsPanel with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.P13nPanel.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.P13nColumnsPanel.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				/// <summary>
				/// Delivers a payload for columnsPanel that can be used at consumer side
				/// </summary>
				/// <returns>oPayload, which contains useful information</returns>
				public extern override object getOkPayload();

				/// <summary>
				/// Delivers a payload for columnsPanel that can be used at consumer side
				/// </summary>
				/// <returns>oPayload, which contains useful information</returns>
				public extern virtual object getResetPayload();

				/// <summary>
				/// This method does a re-initialization of the panel
				/// </summary>
				public extern virtual void reInitialize();

				#endregion

				#endregion

			}
		}
	}
}
