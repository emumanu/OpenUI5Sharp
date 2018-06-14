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
			/// The P13nSortPanel control is used to define settings for sorting in table personalization.
			/// </summary>
			[External]
			[Namespace(false)]
			public partial class P13nSortPanel : sap.m.P13nPanel
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
					/// defines if the mediaQuery or a ContainerResize will be used for layout update. When the ConditionPanel is used on a dialog the property should be set to true!
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> containerQuery;

					/// <summary>
					/// can be used to control the layout behavior. Default is "" which will automatically change the layout. With "Desktop", "Table" or "Phone" you can set a fixed layout.
					/// </summary>
					public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> layoutMode;

					/// <summary>
					/// defined Sort Items
					/// </summary>
					public Union<sap.m.P13nSortItem[], string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> sortItems;

					/// <summary>
					/// event raised when a SortItem was added
					/// </summary>
					public sap.ui.@base.EventDelegate addSortItem;

					/// <summary>
					/// event raised when a SortItem was removed
					/// </summary>
					public sap.ui.@base.EventDelegate removeSortItem;

					/// <summary>
					/// event raised when a SortItem was updated
					/// </summary>
					public sap.ui.@base.EventDelegate updateSortItem;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new P13nSortPanel.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">initial settings for the new control</param>
				public extern P13nSortPanel(string sId, sap.m.P13nSortPanel.Settings mSettings);

				/// <summary>
				/// Constructor for a new P13nSortPanel.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern P13nSortPanel(string sId);

				/// <summary>
				/// Constructor for a new P13nSortPanel.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern P13nSortPanel();

				/// <summary>
				/// Constructor for a new P13nSortPanel.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">initial settings for the new control</param>
				public extern P13nSortPanel(sap.m.P13nSortPanel.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property containerQuery

				/// <summary>
				/// Gets current value of property {@link #getContainerQuery containerQuery}.
				/// 
				/// defines if the mediaQuery or a ContainerResize will be used for layout update. When the ConditionPanel is used on a dialog the property should be set to true!
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>containerQuery</code></returns>
				public extern virtual bool getContainerQuery();

				/// <summary>
				/// Sets a new value for property {@link #getContainerQuery containerQuery}.
				/// 
				/// defines if the mediaQuery or a ContainerResize will be used for layout update. When the ConditionPanel is used on a dialog the property should be set to true!
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bContainerQuery">New value for property <code>containerQuery</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nSortPanel setContainerQuery(bool bContainerQuery);

				#endregion

				#region Methods for Property layoutMode

				/// <summary>
				/// Gets current value of property {@link #getLayoutMode layoutMode}.
				/// 
				/// can be used to control the layout behavior. Default is "" which will automatically change the layout. With "Desktop", "Table" or "Phone" you can set a fixed layout.
				/// </summary>
				/// <returns>Value of property <code>layoutMode</code></returns>
				public extern virtual string getLayoutMode();

				/// <summary>
				/// Sets a new value for property {@link #getLayoutMode layoutMode}.
				/// 
				/// can be used to control the layout behavior. Default is "" which will automatically change the layout. With "Desktop", "Table" or "Phone" you can set a fixed layout.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sLayoutMode">New value for property <code>layoutMode</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nSortPanel setLayoutMode(string sLayoutMode);

				#endregion

				#region Methods for Aggregation content

				#endregion

				#region Methods for Aggregation sortItems

				/// <summary>
				/// Gets content of aggregation {@link #getSortItems sortItems}.
				/// 
				/// defined Sort Items
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.P13nSortItem[] getSortItems();

				/// <summary>
				/// Destroys all the sortItems in the aggregation {@link #getSortItems sortItems}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nSortPanel destroySortItems();

				/// <summary>
				/// Inserts a sortItem into the aggregation {@link #getSortItems sortItems}.
				/// </summary>
				/// <param name="oSortItem">The sortItem to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the sortItem should be inserted at; for a negative value of <code>iIndex</code>, the sortItem is inserted at position 0; for a value greater than the current size of the aggregation, the sortItem is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nSortPanel insertSortItem(sap.m.P13nSortItem oSortItem, int iIndex);

				/// <summary>
				/// Adds some sortItem to the aggregation {@link #getSortItems sortItems}.
				/// </summary>
				/// <param name="oSortItem">The sortItem to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nSortPanel addSortItem(sap.m.P13nSortItem oSortItem);

				/// <summary>
				/// Removes a sortItem from the aggregation {@link #getSortItems sortItems}.
				/// </summary>
				/// <param name="vSortItem">The sortItem to remove or its index or id</param>
				/// <returns>The removed sortItem or <code>null</code></returns>
				public extern virtual sap.m.P13nSortItem removeSortItem(Union<int, string, sap.m.P13nSortItem> vSortItem);

				/// <summary>
				/// Checks for the provided <code>sap.m.P13nSortItem</code> in the aggregation {@link #getSortItems sortItems}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oSortItem">The sortItem whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfSortItem(sap.m.P13nSortItem oSortItem);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getSortItems sortItems}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.m.P13nSortItem[] removeAllSortItems();

				/// <summary>
				/// Binds aggregation {@link #getSortItems sortItems} to model data.
				/// 
				/// See {@link sap.ui.base.ManagedObject#bindAggregation ManagedObject.bindAggregation} for a detailed description of the possible properties of <code>oBindingInfo</code>.
				/// </summary>
				/// <param name="oBindingInfo">The binding information</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nSortPanel bindSortItems(object oBindingInfo);

				/// <summary>
				/// Unbinds aggregation {@link #getSortItems sortItems} from model data.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nSortPanel unbindSortItems();

				#endregion

				#region Methods for Event addSortItem

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:addSortItem addSortItem} event of this <code>sap.m.P13nSortPanel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nSortPanel</code> itself.
				/// 
				/// event raised when a SortItem was added
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.P13nSortPanel</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nSortPanel attachAddSortItem(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:addSortItem addSortItem} event of this <code>sap.m.P13nSortPanel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nSortPanel</code> itself.
				/// 
				/// event raised when a SortItem was added
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nSortPanel attachAddSortItem(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:addSortItem addSortItem} event of this <code>sap.m.P13nSortPanel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nSortPanel</code> itself.
				/// 
				/// event raised when a SortItem was added
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nSortPanel attachAddSortItem(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:addSortItem addSortItem} event of this <code>sap.m.P13nSortPanel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nSortPanel</code> itself.
				/// 
				/// event raised when a SortItem was added
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.P13nSortPanel</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nSortPanel attachAddSortItem(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:addSortItem addSortItem} event of this <code>sap.m.P13nSortPanel</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nSortPanel detachAddSortItem(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:addSortItem addSortItem} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nSortPanel fireAddSortItem(object mParameters);

				/// <summary>
				/// Fires event {@link #event:addSortItem addSortItem} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nSortPanel fireAddSortItem();

				#endregion

				#region Methods for Event removeSortItem

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:removeSortItem removeSortItem} event of this <code>sap.m.P13nSortPanel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nSortPanel</code> itself.
				/// 
				/// event raised when a SortItem was removed
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.P13nSortPanel</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nSortPanel attachRemoveSortItem(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:removeSortItem removeSortItem} event of this <code>sap.m.P13nSortPanel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nSortPanel</code> itself.
				/// 
				/// event raised when a SortItem was removed
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nSortPanel attachRemoveSortItem(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:removeSortItem removeSortItem} event of this <code>sap.m.P13nSortPanel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nSortPanel</code> itself.
				/// 
				/// event raised when a SortItem was removed
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nSortPanel attachRemoveSortItem(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:removeSortItem removeSortItem} event of this <code>sap.m.P13nSortPanel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nSortPanel</code> itself.
				/// 
				/// event raised when a SortItem was removed
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.P13nSortPanel</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nSortPanel attachRemoveSortItem(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:removeSortItem removeSortItem} event of this <code>sap.m.P13nSortPanel</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nSortPanel detachRemoveSortItem(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:removeSortItem removeSortItem} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nSortPanel fireRemoveSortItem(object mParameters);

				/// <summary>
				/// Fires event {@link #event:removeSortItem removeSortItem} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nSortPanel fireRemoveSortItem();

				#endregion

				#region Methods for Event updateSortItem

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:updateSortItem updateSortItem} event of this <code>sap.m.P13nSortPanel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nSortPanel</code> itself.
				/// 
				/// event raised when a SortItem was updated
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.P13nSortPanel</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nSortPanel attachUpdateSortItem(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:updateSortItem updateSortItem} event of this <code>sap.m.P13nSortPanel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nSortPanel</code> itself.
				/// 
				/// event raised when a SortItem was updated
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nSortPanel attachUpdateSortItem(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:updateSortItem updateSortItem} event of this <code>sap.m.P13nSortPanel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nSortPanel</code> itself.
				/// 
				/// event raised when a SortItem was updated
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nSortPanel attachUpdateSortItem(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:updateSortItem updateSortItem} event of this <code>sap.m.P13nSortPanel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nSortPanel</code> itself.
				/// 
				/// event raised when a SortItem was updated
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.P13nSortPanel</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nSortPanel attachUpdateSortItem(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:updateSortItem updateSortItem} event of this <code>sap.m.P13nSortPanel</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nSortPanel detachUpdateSortItem(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:updateSortItem updateSortItem} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nSortPanel fireUpdateSortItem(object mParameters);

				/// <summary>
				/// Fires event {@link #event:updateSortItem updateSortItem} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nSortPanel fireUpdateSortItem();

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.P13nSortPanel with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.P13nPanel.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.P13nSortPanel with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.P13nPanel.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.P13nSortPanel with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.P13nPanel.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.P13nSortPanel.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				/// <summary>
				/// removes all invalid sort conditions.
				/// </summary>
				public extern virtual void removeInvalidConditions();

				/// <summary>
				/// removes all errors/warning states from of all sort conditions.
				/// </summary>
				public extern virtual void removeValidationErrors();

				/// <summary>
				/// setter for the supported operations array
				/// </summary>
				/// <param name="aOperations">array of operations <code>[sap.m.P13nConditionOperation.BT, sap.m.P13nConditionOperation.EQ]</code></param>
				/// <returns>this for chaining</returns>
				public extern virtual sap.m.P13nSortPanel setOperations(object[] aOperations);

				/// <summary>
				/// check if the entered/modified conditions are correct, marks invalid fields yellow (Warning state) and opens a popup message dialog to give the user the feedback that some values are wrong or missing.
				/// </summary>
				/// <returns><code>True</code> if all conditions are valid, <code>false</code> otherwise.</returns>
				public extern virtual bool validateConditions();

				#endregion

				#endregion

			}
		}
	}
}
