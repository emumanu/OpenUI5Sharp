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
			/// A ViewSettingsFilterItem control is used for modelling filter behaviour in the ViewSettingsDialog. It is derived from a core Item, but does not support the base class properties like textDirection and enabled. Setting these properties will not have any effects.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.ViewSettingsFilterItem")]
			public partial class ViewSettingsFilterItem : sap.m.ViewSettingsItem
			{
				#region Settings

				/// <summary>
				/// Settings class to create the object
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class Settings : sap.m.ViewSettingsItem.Settings
				{
					/// <summary>
					/// If set to (true), multi selection will be allowed for the items aggregation.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> multiSelect;

					/// <summary>
					/// Items with key and value that are logically grouped under this filter item. They are used to display filter details in the ViewSettingsDialog.
					/// </summary>
					public Union<sap.m.ViewSettingsItem[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> items;

					/// <summary>
					/// Let the outside world know that the filter detail aggregation was changed.
					/// </summary>
					public sap.ui.@base.EventDelegate filterDetailItemsAggregationChange;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new ViewSettingsFilterItem.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern ViewSettingsFilterItem(string sId, sap.m.ViewSettingsFilterItem.Settings mSettings);

				/// <summary>
				/// Constructor for a new ViewSettingsFilterItem.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern ViewSettingsFilterItem(string sId);

				/// <summary>
				/// Constructor for a new ViewSettingsFilterItem.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern ViewSettingsFilterItem();

				/// <summary>
				/// Constructor for a new ViewSettingsFilterItem.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern ViewSettingsFilterItem(sap.m.ViewSettingsFilterItem.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property multiSelect

				/// <summary>
				/// Gets current value of property {@link #getMultiSelect multiSelect}.
				/// 
				/// If set to (true), multi selection will be allowed for the items aggregation.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>multiSelect</code></returns>
				public extern virtual bool getMultiSelect();

				/// <summary>
				/// Sets a new value for property {@link #getMultiSelect multiSelect}.
				/// 
				/// If set to (true), multi selection will be allowed for the items aggregation.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bMultiSelect">New value for property <code>multiSelect</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ViewSettingsFilterItem setMultiSelect(bool bMultiSelect);

				#endregion

				#region Methods for Aggregation items

				/// <summary>
				/// Gets content of aggregation {@link #getItems items}.
				/// 
				/// Items with key and value that are logically grouped under this filter item. They are used to display filter details in the ViewSettingsDialog.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.ViewSettingsItem[] getItems();

				/// <summary>
				/// Destroys all the items in the aggregation {@link #getItems items}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ViewSettingsFilterItem destroyItems();

				/// <summary>
				/// Inserts a item into the aggregation {@link #getItems items}.
				/// </summary>
				/// <param name="oItem">The item to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the item should be inserted at; for a negative value of <code>iIndex</code>, the item is inserted at position 0; for a value greater than the current size of the aggregation, the item is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ViewSettingsFilterItem insertItem(sap.m.ViewSettingsItem oItem, int iIndex);

				/// <summary>
				/// Adds some item to the aggregation {@link #getItems items}.
				/// </summary>
				/// <param name="oItem">The item to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ViewSettingsFilterItem addItem(sap.m.ViewSettingsItem oItem);

				/// <summary>
				/// Removes a item from the aggregation {@link #getItems items}.
				/// </summary>
				/// <param name="vItem">The item to remove or its index or id</param>
				/// <returns>The removed item or <code>null</code></returns>
				public extern virtual sap.m.ViewSettingsItem removeItem(Union<int, string, sap.m.ViewSettingsItem> vItem);

				/// <summary>
				/// Checks for the provided <code>sap.m.ViewSettingsItem</code> in the aggregation {@link #getItems items}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oItem">The item whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfItem(sap.m.ViewSettingsItem oItem);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getItems items}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.m.ViewSettingsItem[] removeAllItems();

				/// <summary>
				/// Binds aggregation {@link #getItems items} to model data.
				/// 
				/// See {@link sap.ui.base.ManagedObject#bindAggregation ManagedObject.bindAggregation} for a detailed description of the possible properties of <code>oBindingInfo</code>.
				/// </summary>
				/// <param name="oBindingInfo">The binding information</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ViewSettingsFilterItem bindItems(sap.ui.@base.ManagedObject.BindAggregationInfo oBindingInfo);

				/// <summary>
				/// Unbinds aggregation {@link #getItems items} from model data.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ViewSettingsFilterItem unbindItems();

				#endregion

				#region Methods for Event filterDetailItemsAggregationChange

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:filterDetailItemsAggregationChange filterDetailItemsAggregationChange} event of this <code>sap.m.ViewSettingsFilterItem</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ViewSettingsFilterItem</code> itself.
				/// 
				/// Let the outside world know that the filter detail aggregation was changed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ViewSettingsFilterItem</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ViewSettingsFilterItem attachFilterDetailItemsAggregationChange(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:filterDetailItemsAggregationChange filterDetailItemsAggregationChange} event of this <code>sap.m.ViewSettingsFilterItem</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ViewSettingsFilterItem</code> itself.
				/// 
				/// Let the outside world know that the filter detail aggregation was changed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ViewSettingsFilterItem attachFilterDetailItemsAggregationChange(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:filterDetailItemsAggregationChange filterDetailItemsAggregationChange} event of this <code>sap.m.ViewSettingsFilterItem</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ViewSettingsFilterItem</code> itself.
				/// 
				/// Let the outside world know that the filter detail aggregation was changed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ViewSettingsFilterItem attachFilterDetailItemsAggregationChange(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:filterDetailItemsAggregationChange filterDetailItemsAggregationChange} event of this <code>sap.m.ViewSettingsFilterItem</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ViewSettingsFilterItem</code> itself.
				/// 
				/// Let the outside world know that the filter detail aggregation was changed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ViewSettingsFilterItem</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ViewSettingsFilterItem attachFilterDetailItemsAggregationChange(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:filterDetailItemsAggregationChange filterDetailItemsAggregationChange} event of this <code>sap.m.ViewSettingsFilterItem</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ViewSettingsFilterItem detachFilterDetailItemsAggregationChange(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:filterDetailItemsAggregationChange filterDetailItemsAggregationChange} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ViewSettingsFilterItem fireFilterDetailItemsAggregationChange(object mParameters);

				/// <summary>
				/// Fires event {@link #event:filterDetailItemsAggregationChange filterDetailItemsAggregationChange} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ViewSettingsFilterItem fireFilterDetailItemsAggregationChange();

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.ViewSettingsFilterItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.ViewSettingsItem.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.ViewSettingsFilterItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.ViewSettingsItem.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.ViewSettingsFilterItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.ViewSettingsItem.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.ViewSettingsFilterItem.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				[Name("getMetadata")]
				public extern static sap.ui.@base.Metadata getMetadataStatic();

				#endregion

				#endregion

			}
		}
	}
}
