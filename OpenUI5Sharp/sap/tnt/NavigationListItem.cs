using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public static partial class sap
	{
		public static partial class tnt
		{
			/// <summary>
			/// The NavigationListItem control represents an action, which can be selected by the user. It can provide sub items.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.tnt.NavigationListItem")]
			public partial class NavigationListItem : sap.ui.core.Item
			{
				#region Settings

				/// <summary>
				/// Settings class to create the object
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class Settings : sap.ui.core.Item.Settings
				{
					/// <summary>
					/// Specifies the icon for the item.
					/// </summary>
					public Union<sap.ui.core.URI, string, sap.ui.@base.ManagedObject.BindPropertyInfo> icon;

					/// <summary>
					/// Specifies if the item is expanded.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> expanded;

					/// <summary>
					/// Specifies if the item has an expander.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> hasExpander;

					/// <summary>
					/// Specifies if the item should be shown.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> visible;

					/// <summary>
					/// The sub items.
					/// </summary>
					public Union<sap.tnt.NavigationListItem[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> items;

					/// <summary>
					/// Fired when this item is selected.
					/// </summary>
					public sap.m.ItemSelectDelegate select;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new NavigationListItem.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern NavigationListItem(string sId, sap.tnt.NavigationListItem.Settings mSettings);

				/// <summary>
				/// Constructor for a new NavigationListItem.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern NavigationListItem(string sId);

				/// <summary>
				/// Constructor for a new NavigationListItem.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern NavigationListItem();

				/// <summary>
				/// Constructor for a new NavigationListItem.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern NavigationListItem(sap.tnt.NavigationListItem.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property icon

				/// <summary>
				/// Gets current value of property {@link #getIcon icon}.
				/// 
				/// Specifies the icon for the item.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <returns>Value of property <code>icon</code></returns>
				public extern virtual sap.ui.core.URI getIcon();

				/// <summary>
				/// Sets a new value for property {@link #getIcon icon}.
				/// 
				/// Specifies the icon for the item.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <param name="sIcon">New value for property <code>icon</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.tnt.NavigationListItem setIcon(sap.ui.core.URI sIcon);

				#endregion

				#region Methods for Property expanded

				/// <summary>
				/// Gets current value of property {@link #getExpanded expanded}.
				/// 
				/// Specifies if the item is expanded.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>expanded</code></returns>
				public extern virtual bool getExpanded();

				/// <summary>
				/// Sets a new value for property {@link #getExpanded expanded}.
				/// 
				/// Specifies if the item is expanded.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bExpanded">New value for property <code>expanded</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.tnt.NavigationListItem setExpanded(bool bExpanded);

				#endregion

				#region Methods for Property hasExpander

				/// <summary>
				/// Gets current value of property {@link #getHasExpander hasExpander}.
				/// 
				/// Specifies if the item has an expander.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>hasExpander</code></returns>
				public extern virtual bool getHasExpander();

				/// <summary>
				/// Sets a new value for property {@link #getHasExpander hasExpander}.
				/// 
				/// Specifies if the item has an expander.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bHasExpander">New value for property <code>hasExpander</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.tnt.NavigationListItem setHasExpander(bool bHasExpander);

				#endregion

				#region Methods for Property visible

				/// <summary>
				/// Gets current value of property {@link #getVisible visible}.
				/// 
				/// Specifies if the item should be shown.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>visible</code></returns>
				public extern virtual bool getVisible();

				/// <summary>
				/// Sets a new value for property {@link #getVisible visible}.
				/// 
				/// Specifies if the item should be shown.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bVisible">New value for property <code>visible</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.tnt.NavigationListItem setVisible(bool bVisible);

				#endregion

				#region Methods for Aggregation items

				/// <summary>
				/// Gets content of aggregation {@link #getItems items}.
				/// 
				/// The sub items.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.tnt.NavigationListItem[] getItems();

				/// <summary>
				/// Destroys all the items in the aggregation {@link #getItems items}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.tnt.NavigationListItem destroyItems();

				/// <summary>
				/// Inserts a item into the aggregation {@link #getItems items}.
				/// </summary>
				/// <param name="oItem">The item to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the item should be inserted at; for a negative value of <code>iIndex</code>, the item is inserted at position 0; for a value greater than the current size of the aggregation, the item is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.tnt.NavigationListItem insertItem(sap.tnt.NavigationListItem oItem, int iIndex);

				/// <summary>
				/// Adds some item to the aggregation {@link #getItems items}.
				/// </summary>
				/// <param name="oItem">The item to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.tnt.NavigationListItem addItem(sap.tnt.NavigationListItem oItem);

				/// <summary>
				/// Removes a item from the aggregation {@link #getItems items}.
				/// </summary>
				/// <param name="vItem">The item to remove or its index or id</param>
				/// <returns>The removed item or <code>null</code></returns>
				public extern virtual sap.tnt.NavigationListItem removeItem(Union<int, string, sap.tnt.NavigationListItem> vItem);

				/// <summary>
				/// Checks for the provided <code>sap.tnt.NavigationListItem</code> in the aggregation {@link #getItems items}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oItem">The item whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfItem(sap.tnt.NavigationListItem oItem);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getItems items}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.tnt.NavigationListItem[] removeAllItems();

				#endregion

				#region Methods for Aggregation _expandIconControl

				#endregion

				#region Methods for Event select

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.tnt.NavigationListItem</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.tnt.NavigationListItem</code> itself.
				/// 
				/// Fired when this item is selected.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.tnt.NavigationListItem</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.tnt.NavigationListItem attachSelect(object oData, sap.m.ItemSelectDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.tnt.NavigationListItem</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.tnt.NavigationListItem</code> itself.
				/// 
				/// Fired when this item is selected.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.tnt.NavigationListItem attachSelect(object oData, sap.m.ItemSelectDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.tnt.NavigationListItem</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.tnt.NavigationListItem</code> itself.
				/// 
				/// Fired when this item is selected.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.tnt.NavigationListItem attachSelect(sap.m.ItemSelectDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.tnt.NavigationListItem</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.tnt.NavigationListItem</code> itself.
				/// 
				/// Fired when this item is selected.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.tnt.NavigationListItem</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.tnt.NavigationListItem attachSelect(sap.m.ItemSelectDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:select select} event of this <code>sap.tnt.NavigationListItem</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.tnt.NavigationListItem detachSelect(sap.m.ItemSelectDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:select select} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.tnt.NavigationListItem fireSelect(sap.m.ItemSelectInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:select select} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.tnt.NavigationListItem fireSelect();

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.tnt.NavigationListItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Item.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.tnt.NavigationListItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Item.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.tnt.NavigationListItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Item.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.tnt.NavigationListItem.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				/// <summary>
				/// Expands the child items(works only on first-level items).
				/// </summary>
				/// <param name="duration">animation duration in milliseconds; default is the jQuery preset 'fast'.For duration == 0 the opening happens synchronously without animation.</param>
				/// <returns></returns>
				public extern virtual void expand(int duration);

				/// <summary>
				/// Expands the child items(works only on first-level items).
				/// </summary>
				/// <returns></returns>
				public extern virtual void expand();

				/// <summary>
				/// Collapses the child items(works only on first-level items).
				/// </summary>
				/// <param name="duration">animation duration in milliseconds; default is the jQuery preset 'fast'.For duration == 0 the closing happens synchronously without animation.</param>
				/// <returns></returns>
				public extern virtual void collapse(int duration);

				/// <summary>
				/// Collapses the child items(works only on first-level items).
				/// </summary>
				/// <returns></returns>
				public extern virtual void collapse();

				#endregion

				#endregion

			}
		}
	}
}
