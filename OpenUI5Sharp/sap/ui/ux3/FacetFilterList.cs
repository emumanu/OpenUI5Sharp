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
				/// List to be used with the FacetFilter control. The control is not intended to be used stand alone.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.ux3.FacetFilterList")]
				[Obsolete("Deprecated since 1.38. replaced by {@link sap.m.FacetFilter}")]
				public partial class FacetFilterList : sap.ui.core.Control
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
						/// The title of this list.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> title;

						/// <summary>
						/// Specifies whether multiple or single selection is used.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> multiSelect;

						/// <summary>
						/// Specifies whether the text values from the additionalText property (see sap.ui.core.ListItems) shall be displayed.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> displaySecondaryValues;

						/// <summary>
						/// Array of type string containing the selected keys.
						/// </summary>
						public Union<string[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> selectedKeys;

						/// <summary>
						/// Specifies whether the counter for all entries is shown.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showCounter;

						/// <summary>
						/// The filter values that are presented as a list.
						/// </summary>
						public Union<sap.ui.core.ListItem[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> items;

						/// <summary>
						/// On Select event.
						/// </summary>
						public sap.ui.ux3.FacetFilterList.SelectDelegate select;

					}

					#endregion

					#region Typed Parameters

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class SelectInfo
					{
						/// <summary>
						/// Id of the FacetFilterList taht fires the event.
						/// </summary>
						public string id;

						/// <summary>
						/// Array of selected Indices.
						/// </summary>
						public int[] selectedIndices;

						/// <summary>
						/// Array of selected Items.
						/// </summary>
						public sap.ui.core.ListItem[] selectedItems;

						/// <summary>
						/// If it is true, then Item All is selected. That means all items in the list are selected - no filter is set.
						/// </summary>
						public bool all;

					}

					#endregion

					#region Delegates

					public delegate void SelectDelegate(sap.ui.@base.Event<sap.ui.ux3.FacetFilterList.SelectInfo> oEvent, object oData);

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new FacetFilterList.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern FacetFilterList(string sId, sap.ui.ux3.FacetFilterList.Settings mSettings);

					/// <summary>
					/// Constructor for a new FacetFilterList.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern FacetFilterList(string sId);

					/// <summary>
					/// Constructor for a new FacetFilterList.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern FacetFilterList();

					/// <summary>
					/// Constructor for a new FacetFilterList.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern FacetFilterList(sap.ui.ux3.FacetFilterList.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property title

					/// <summary>
					/// Gets current value of property {@link #getTitle title}.
					/// 
					/// The title of this list.
					/// </summary>
					/// <returns>Value of property <code>title</code></returns>
					public extern virtual string getTitle();

					/// <summary>
					/// Sets a new value for property {@link #getTitle title}.
					/// 
					/// The title of this list.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sTitle">New value for property <code>title</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FacetFilterList setTitle(string sTitle);

					#endregion

					#region Methods for Property multiSelect

					/// <summary>
					/// Gets current value of property {@link #getMultiSelect multiSelect}.
					/// 
					/// Specifies whether multiple or single selection is used.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>multiSelect</code></returns>
					public extern virtual bool getMultiSelect();

					/// <summary>
					/// Sets a new value for property {@link #getMultiSelect multiSelect}.
					/// 
					/// Specifies whether multiple or single selection is used.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bMultiSelect">New value for property <code>multiSelect</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FacetFilterList setMultiSelect(bool bMultiSelect);

					#endregion

					#region Methods for Property displaySecondaryValues

					/// <summary>
					/// Gets current value of property {@link #getDisplaySecondaryValues displaySecondaryValues}.
					/// 
					/// Specifies whether the text values from the additionalText property (see sap.ui.core.ListItems) shall be displayed.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>displaySecondaryValues</code></returns>
					public extern virtual bool getDisplaySecondaryValues();

					/// <summary>
					/// Sets a new value for property {@link #getDisplaySecondaryValues displaySecondaryValues}.
					/// 
					/// Specifies whether the text values from the additionalText property (see sap.ui.core.ListItems) shall be displayed.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bDisplaySecondaryValues">New value for property <code>displaySecondaryValues</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FacetFilterList setDisplaySecondaryValues(bool bDisplaySecondaryValues);

					#endregion

					#region Methods for Property selectedKeys

					/// <summary>
					/// Gets current value of property {@link #getSelectedKeys selectedKeys}.
					/// 
					/// Array of type string containing the selected keys.
					/// </summary>
					/// <returns>Value of property <code>selectedKeys</code></returns>
					public extern virtual string[] getSelectedKeys();

					/// <summary>
					/// Sets a new value for property {@link #getSelectedKeys selectedKeys}.
					/// 
					/// Array of type string containing the selected keys.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sSelectedKeys">New value for property <code>selectedKeys</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FacetFilterList setSelectedKeys(string[] sSelectedKeys);

					/// <summary>
					/// Sets a new value for property {@link #getSelectedKeys selectedKeys}.
					/// 
					/// Array of type string containing the selected keys.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sSelectedKeys">New value for property <code>selectedKeys</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FacetFilterList setSelectedKeys(object[] sSelectedKeys);

					#endregion

					#region Methods for Property showCounter

					/// <summary>
					/// Gets current value of property {@link #getShowCounter showCounter}.
					/// 
					/// Specifies whether the counter for all entries is shown.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>showCounter</code></returns>
					public extern virtual bool getShowCounter();

					/// <summary>
					/// Sets a new value for property {@link #getShowCounter showCounter}.
					/// 
					/// Specifies whether the counter for all entries is shown.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bShowCounter">New value for property <code>showCounter</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FacetFilterList setShowCounter(bool bShowCounter);

					#endregion

					#region Methods for Aggregation items

					/// <summary>
					/// Gets content of aggregation {@link #getItems items}.
					/// 
					/// The filter values that are presented as a list.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.ListItem[] getItems();

					/// <summary>
					/// Destroys all the items in the aggregation {@link #getItems items}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FacetFilterList destroyItems();

					/// <summary>
					/// Inserts a item into the aggregation {@link #getItems items}.
					/// </summary>
					/// <param name="oItem">The item to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the item should be inserted at; for a negative value of <code>iIndex</code>, the item is inserted at position 0; for a value greater than the current size of the aggregation, the item is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FacetFilterList insertItem(sap.ui.core.ListItem oItem, int iIndex);

					/// <summary>
					/// Adds some item to the aggregation {@link #getItems items}.
					/// </summary>
					/// <param name="oItem">The item to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FacetFilterList addItem(sap.ui.core.ListItem oItem);

					/// <summary>
					/// Removes a item from the aggregation {@link #getItems items}.
					/// </summary>
					/// <param name="vItem">The item to remove or its index or id</param>
					/// <returns>The removed item or <code>null</code></returns>
					public extern virtual sap.ui.core.ListItem removeItem(Union<int, string, sap.ui.core.ListItem> vItem);

					/// <summary>
					/// Checks for the provided <code>sap.ui.core.ListItem</code> in the aggregation {@link #getItems items}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oItem">The item whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfItem(sap.ui.core.ListItem oItem);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getItems items}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.core.ListItem[] removeAllItems();

					#endregion

					#region Methods for Aggregation controls

					#endregion

					#region Methods for Event select

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.ui.ux3.FacetFilterList</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.FacetFilterList</code> itself.
					/// 
					/// On Select event.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.FacetFilterList</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FacetFilterList attachSelect(object oData, sap.ui.ux3.FacetFilterList.SelectDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.ui.ux3.FacetFilterList</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.FacetFilterList</code> itself.
					/// 
					/// On Select event.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FacetFilterList attachSelect(object oData, sap.ui.ux3.FacetFilterList.SelectDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.ui.ux3.FacetFilterList</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.FacetFilterList</code> itself.
					/// 
					/// On Select event.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FacetFilterList attachSelect(sap.ui.ux3.FacetFilterList.SelectDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.ui.ux3.FacetFilterList</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.FacetFilterList</code> itself.
					/// 
					/// On Select event.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.FacetFilterList</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FacetFilterList attachSelect(sap.ui.ux3.FacetFilterList.SelectDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:select select} event of this <code>sap.ui.ux3.FacetFilterList</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FacetFilterList detachSelect(sap.ui.ux3.FacetFilterList.SelectDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:select select} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FacetFilterList fireSelect(sap.ui.ux3.FacetFilterList.SelectInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:select select} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FacetFilterList fireSelect();

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.ux3.FacetFilterList with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.ux3.FacetFilterList with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.ux3.FacetFilterList with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.ux3.FacetFilterList.
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
}
