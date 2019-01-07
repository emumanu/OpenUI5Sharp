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
				/// The control provides a field that allows end users to either enter some text, or to choose an entry out of a list of pre-defined items. The choosable items can be provided in the form of a complete <code>ListBox</code>, single <code>ListItems</code>.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.ComboBox")]
				[Obsolete("Deprecated since 1.38. replaced by {@link sap.m.ComboBox}")]
				public partial class ComboBox : sap.ui.commons.TextField, sap.ui.commons.ToolbarItem
				{
					#region Settings

					/// <summary>
					/// Settings class to create the object
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class Settings : sap.ui.commons.TextField.Settings
					{
						/// <summary>
						/// Defines the number of items that shall be displayed at once. If the overall number of items is higher than this setting, a scrollbar is provided.
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> maxPopupItems;

						/// <summary>
						/// Indicates whether the <code>additionalText</code> property that is available for <code>sap.ui.core.ListItem</code> shall be displayed in the list.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> displaySecondaryValues;

						/// <summary>
						/// Key of the selected item.
						/// 
						/// If the value has no corresponding item the key is empty.
						/// 
						/// If duplicate keys exists the first item matching the key is used.
						/// 
						/// If the key is set to a not existing value it will not be changed.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> selectedKey;

						/// <summary>
						/// Id of the selected item. If the value has no corresponding item, the <code>selectedItemId</code> is empty.
						/// 
						/// If the <code>selectedItemId</code> is set to a not existing item, it will not be changed.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> selectedItemId;

						/// <summary>
						/// <code>ListItems</code> (see <code>sap.ui.core.ListBox</code>) that shall be displayed in the list.
						/// </summary>
						public Union<sap.ui.core.ListItem[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> items;

						/// <summary>
						/// Using this method, you provide a <code>ListBox</code> control. This allows reuse of item lists in different controls. Either a control id can be used as new target, or a control instance.
						/// 
						/// <b>Note:</b> The ListBox must not be rendered somewhere in the UI. But if you want to bind the <code>ListBox</code> items to a model it must be in the control tree. So we suggest to add it as dependent somewhere (e.g. to the view or the first used <code>ComboBox</code>). If it is not set as child or dependant to an other control it will be automatically set as dependent to the first ComboBox where it is assigned.
						/// </summary>
						public Union<sap.ui.commons.ListBox, sap.ui.core.ID, string, sap.ui.@base.ManagedObject.BindPropertyInfo> listBox;

					}

					#endregion

					#region Typed Parameters

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class ChangeInfo
					{
						/// <summary>
						/// The new / changed value of the ComboBox.
						/// </summary>
						public string newValue;

						/// <summary>
						/// The new / changed item of the ComboBox.
						/// </summary>
						public sap.ui.core.ListItem selectedItem;

					}

					#endregion

					#region Delegates

					public delegate void ChangeDelegate(sap.ui.@base.Event<sap.ui.commons.ComboBox.ChangeInfo> oEvent, object oData);

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new ComboBox.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">Id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern ComboBox(string sId, sap.ui.commons.ComboBox.Settings mSettings);

					/// <summary>
					/// Constructor for a new ComboBox.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">Id for the new control, generated automatically if no id is given</param>
					public extern ComboBox(string sId);

					/// <summary>
					/// Constructor for a new ComboBox.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern ComboBox();

					/// <summary>
					/// Constructor for a new ComboBox.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern ComboBox(sap.ui.commons.ComboBox.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property maxPopupItems

					/// <summary>
					/// Gets current value of property {@link #getMaxPopupItems maxPopupItems}.
					/// 
					/// Defines the number of items that shall be displayed at once. If the overall number of items is higher than this setting, a scrollbar is provided.
					/// 
					/// Default value is <code>10</code>.
					/// </summary>
					/// <returns>Value of property <code>maxPopupItems</code></returns>
					public extern virtual int getMaxPopupItems();

					/// <summary>
					/// Sets a new value for property {@link #getMaxPopupItems maxPopupItems}.
					/// 
					/// Defines the number of items that shall be displayed at once. If the overall number of items is higher than this setting, a scrollbar is provided.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>10</code>.
					/// </summary>
					/// <param name="iMaxPopupItems">New value for property <code>maxPopupItems</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ComboBox setMaxPopupItems(int iMaxPopupItems);

					#endregion

					#region Methods for Property displaySecondaryValues

					/// <summary>
					/// Gets current value of property {@link #getDisplaySecondaryValues displaySecondaryValues}.
					/// 
					/// Indicates whether the <code>additionalText</code> property that is available for <code>sap.ui.core.ListItem</code> shall be displayed in the list.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>displaySecondaryValues</code></returns>
					public extern virtual bool getDisplaySecondaryValues();

					/// <summary>
					/// Sets a new value for property {@link #getDisplaySecondaryValues displaySecondaryValues}.
					/// 
					/// Indicates whether the <code>additionalText</code> property that is available for <code>sap.ui.core.ListItem</code> shall be displayed in the list.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bDisplaySecondaryValues">New value for property <code>displaySecondaryValues</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ComboBox setDisplaySecondaryValues(bool bDisplaySecondaryValues);

					#endregion

					#region Methods for Property selectedKey

					/// <summary>
					/// Gets current value of property {@link #getSelectedKey selectedKey}.
					/// 
					/// Key of the selected item.
					/// 
					/// If the value has no corresponding item the key is empty.
					/// 
					/// If duplicate keys exists the first item matching the key is used.
					/// 
					/// If the key is set to a not existing value it will not be changed.
					/// </summary>
					/// <returns>Value of property <code>selectedKey</code></returns>
					public extern virtual string getSelectedKey();

					/// <summary>
					/// Sets a new value for property {@link #getSelectedKey selectedKey}.
					/// 
					/// Key of the selected item.
					/// 
					/// If the value has no corresponding item the key is empty.
					/// 
					/// If duplicate keys exists the first item matching the key is used.
					/// 
					/// If the key is set to a not existing value it will not be changed.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sSelectedKey">New value for property <code>selectedKey</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ComboBox setSelectedKey(string sSelectedKey);

					#endregion

					#region Methods for Property selectedItemId

					/// <summary>
					/// Gets current value of property {@link #getSelectedItemId selectedItemId}.
					/// 
					/// Id of the selected item. If the value has no corresponding item, the <code>selectedItemId</code> is empty.
					/// 
					/// If the <code>selectedItemId</code> is set to a not existing item, it will not be changed.
					/// </summary>
					/// <returns>Value of property <code>selectedItemId</code></returns>
					public extern virtual string getSelectedItemId();

					/// <summary>
					/// Sets a new value for property {@link #getSelectedItemId selectedItemId}.
					/// 
					/// Id of the selected item. If the value has no corresponding item, the <code>selectedItemId</code> is empty.
					/// 
					/// If the <code>selectedItemId</code> is set to a not existing item, it will not be changed.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sSelectedItemId">New value for property <code>selectedItemId</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ComboBox setSelectedItemId(string sSelectedItemId);

					#endregion

					#region Methods for Aggregation items

					/// <summary>
					/// Gets content of aggregation {@link #getItems items}.
					/// 
					/// <code>ListItems</code> (see <code>sap.ui.core.ListBox</code>) that shall be displayed in the list.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.ListItem[] getItems();

					/// <summary>
					/// Destroys all the items in the aggregation {@link #getItems items}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ComboBox destroyItems();

					/// <summary>
					/// Inserts a item into the aggregation {@link #getItems items}.
					/// </summary>
					/// <param name="oItem">The item to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the item should be inserted at; for a negative value of <code>iIndex</code>, the item is inserted at position 0; for a value greater than the current size of the aggregation, the item is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ComboBox insertItem(sap.ui.core.ListItem oItem, int iIndex);

					/// <summary>
					/// Adds some item to the aggregation {@link #getItems items}.
					/// </summary>
					/// <param name="oItem">The item to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ComboBox addItem(sap.ui.core.ListItem oItem);

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

					/// <summary>
					/// Binds aggregation {@link #getItems items} to model data.
					/// 
					/// See {@link sap.ui.base.ManagedObject#bindAggregation ManagedObject.bindAggregation} for a detailed description of the possible properties of <code>oBindingInfo</code>.
					/// </summary>
					/// <param name="oBindingInfo">The binding information</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ComboBox bindItems(sap.ui.@base.ManagedObject.BindAggregationInfo oBindingInfo);

					/// <summary>
					/// Unbinds aggregation {@link #getItems items} from model data.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ComboBox unbindItems();

					#endregion

					#region Methods for Aggregation myListBox

					#endregion

					#region Methods for Association listBox

					/// <summary>
					/// ID of the element which is the current target of the association {@link #getListBox listBox}, or <code>null</code>.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.ID getListBox();

					/// <summary>
					/// Sets the associated {@link #getListBox listBox}.
					/// </summary>
					/// <param name="oListBox">ID of an element which becomes the new target of this listBox association; alternatively, an element instance may be given</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ComboBox setListBox(Union<sap.ui.core.ID, sap.ui.commons.ListBox> oListBox);

					#endregion

					#region Methods for event change

					/// <summary>
					/// Fire event change to attached listeners.
					/// 
					/// Expects following event parameters: <ul> <li>'newValue' of type <code>string</code> The new / changed value of the textfield.</li> <li>'selectedItem' of type <code>sap.ui.core.ListItem</code> selected item </li> </ul>
					/// </summary>
					/// <param name="mArguments">the arguments to pass along with the event.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.commons.ComboBox fireChange(Map mArguments);

					/// <summary>
					/// Fire event change to attached listeners.
					/// 
					/// Expects following event parameters: <ul> <li>'newValue' of type <code>string</code> The new / changed value of the textfield.</li> <li>'selectedItem' of type <code>sap.ui.core.ListItem</code> selected item </li> </ul>
					/// </summary>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.commons.ComboBox fireChange();

					#endregion

					#region Other methods

					/// <summary>
					/// Compares the previous value with the current value and fires the "Change" event if the ComboBox is editable and the value has changed or whether the value has been changed e.g. via up/down or auto-complete feature
					/// </summary>
					/// <param name="oEvent">The event object.</param>
					/// <param name="bImmediate">indicate whether the check should happen immediately or delayed (e.g. to avoid focusout / click double event processing)</param>
					public extern virtual void _checkChange(jquery.JQuery.Event oEvent, bool bImmediate);

					/// <summary>
					/// Compares the previous value with the current value and fires the "Change" event if the ComboBox is editable and the value has changed or whether the value has been changed e.g. via up/down or auto-complete feature
					/// </summary>
					/// <param name="oEvent">The event object.</param>
					public extern virtual void _checkChange(jquery.JQuery.Event oEvent);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.ComboBox with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.commons.TextField.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.ComboBox with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.commons.TextField.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.ComboBox with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.commons.TextField.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					public extern virtual void getAccessibilityInfo();

					/// <summary>
					/// Returns the DomRef which represents the icon for value help. Could be overwritten in child-classes
					/// </summary>
					/// <returns>The F4-element's DOM reference or null</returns>
					public extern virtual Retyped.dom.HTMLElement getF4ButtonDomRef();

					/// <summary>
					/// Returns a metadata object for class sap.ui.commons.ComboBox.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					[Name("getMetadata")]
					public extern static sap.ui.@base.Metadata getMetadataStatic();

					/// <summary>
					/// Handle sapenter pseudo events on the control
					/// </summary>
					/// <param name="oEvent">The event object.</param>
					public extern override void onsapenter(jquery.JQuery.Event oEvent);

					/// <summary>
					/// Handle sapescape pseudo events on the control
					/// </summary>
					/// <param name="oEvent">The event object.</param>
					public extern virtual void onsapescape(jquery.JQuery.Event oEvent);

					/// <summary>
					/// Handle saphide pseudo events on the control
					/// </summary>
					/// <param name="oEvent">The event object.</param>
					public extern virtual void onsaphide(jquery.JQuery.Event oEvent);

					/// <summary>
					/// Handle sapnextmodifiers pseudo events on the control if in toolbar prevent item navigation if popup is opened.
					/// </summary>
					/// <param name="oEvent">The event object.</param>
					public extern virtual void onsapnextmodifiers(jquery.JQuery.Event oEvent);

					/// <summary>
					/// Handle sapshow pseudo events on the control
					/// </summary>
					/// <param name="oEvent">The event object.</param>
					public extern virtual void onsapshow(jquery.JQuery.Event oEvent);

					#endregion

					#endregion

				}
			}
		}
	}
}
