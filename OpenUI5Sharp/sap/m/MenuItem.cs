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
			/// The <code>MenuItem</code> control is used for creating items for the <code>sap.m.Menu</code>. It is derived from a core <code>sap.ui.core.Item</code>.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.MenuItem")]
			public partial class MenuItem : sap.ui.core.Item
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
					/// Defines the icon, which belongs to the item. This can be a URI to an image or an icon font URI.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> icon;

					/// <summary>
					/// Defines whether the item should be visible on the screen. If set to <code>false</code>, a placeholder is rendered instead of the real item.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> visible;

					/// <summary>
					/// Defines whether a visual separator should be rendered before the item. <b>Note:</b> If an item is invisible its separator is also not displayed.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> startsSection;

					/// <summary>
					/// Defines the sub-items contained within this element.
					/// </summary>
					public Union<sap.m.MenuItem[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> items;

					/// <summary>
					/// Fired after the item has been pressed.
					/// </summary>
					public sap.ui.@base.EventDelegate press;

					/// <summary>
					/// Fired when a property of the item changes.
					/// </summary>
					public sap.m.MenuItem.PropertyChangedDelegate propertyChanged;

					/// <summary>
					/// Fired when aggregation of the item changes.
					/// </summary>
					public sap.m.MenuItem.AggregationChangedDelegate aggregationChanged;

				}

				#endregion

				#region Typed Parameters

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class AggregationChangedInfo
				{
					/// <summary>
					/// The aggregation name of the changed aggregation.
					/// </summary>
					public string aggregationName;

					/// <summary>
					/// Which method changed the aggregation.
					/// </summary>
					public string methodName;

					/// <summary>
					/// What parameters were used to change the aggregation.
					/// </summary>
					public object methodParams;

				}

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class PropertyChangedInfo
				{
					/// <summary>
					/// The property name to be changed.
					/// </summary>
					public string propertyKey;

					/// <summary>
					/// The new property value.
					/// </summary>
					public object propertyValue;

				}

				#endregion

				#region Delegates

				public delegate void AggregationChangedDelegate(sap.ui.@base.Event<sap.m.MenuItem.AggregationChangedInfo> oEvent, object oData);

				public delegate void PropertyChangedDelegate(sap.ui.@base.Event<sap.m.MenuItem.PropertyChangedInfo> oEvent, object oData);

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new <code>MenuItem</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern MenuItem(string sId, sap.m.MenuItem.Settings mSettings);

				/// <summary>
				/// Constructor for a new <code>MenuItem</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern MenuItem(string sId);

				/// <summary>
				/// Constructor for a new <code>MenuItem</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern MenuItem();

				/// <summary>
				/// Constructor for a new <code>MenuItem</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern MenuItem(sap.m.MenuItem.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property icon

				/// <summary>
				/// Gets current value of property {@link #getIcon icon}.
				/// 
				/// Defines the icon, which belongs to the item. This can be a URI to an image or an icon font URI.
				/// </summary>
				/// <returns>Value of property <code>icon</code></returns>
				public extern virtual string getIcon();

				/// <summary>
				/// Sets a new value for property {@link #getIcon icon}.
				/// 
				/// Defines the icon, which belongs to the item. This can be a URI to an image or an icon font URI.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sIcon">New value for property <code>icon</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MenuItem setIcon(string sIcon);

				#endregion

				#region Methods for Property visible

				/// <summary>
				/// Gets current value of property {@link #getVisible visible}.
				/// 
				/// Defines whether the item should be visible on the screen. If set to <code>false</code>, a placeholder is rendered instead of the real item.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>visible</code></returns>
				public extern virtual bool getVisible();

				/// <summary>
				/// Sets a new value for property {@link #getVisible visible}.
				/// 
				/// Defines whether the item should be visible on the screen. If set to <code>false</code>, a placeholder is rendered instead of the real item.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bVisible">New value for property <code>visible</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MenuItem setVisible(bool bVisible);

				#endregion

				#region Methods for Property startsSection

				/// <summary>
				/// Gets current value of property {@link #getStartsSection startsSection}.
				/// 
				/// Defines whether a visual separator should be rendered before the item. <b>Note:</b> If an item is invisible its separator is also not displayed.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>startsSection</code></returns>
				public extern virtual bool getStartsSection();

				/// <summary>
				/// Sets a new value for property {@link #getStartsSection startsSection}.
				/// 
				/// Defines whether a visual separator should be rendered before the item. <b>Note:</b> If an item is invisible its separator is also not displayed.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bStartsSection">New value for property <code>startsSection</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MenuItem setStartsSection(bool bStartsSection);

				#endregion

				#region Methods for Aggregation items

				/// <summary>
				/// Gets content of aggregation {@link #getItems items}.
				/// 
				/// Defines the sub-items contained within this element.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.MenuItem[] getItems();

				/// <summary>
				/// Destroys all the items in the aggregation {@link #getItems items}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MenuItem destroyItems();

				/// <summary>
				/// Inserts a item into the aggregation {@link #getItems items}.
				/// </summary>
				/// <param name="oItem">The item to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the item should be inserted at; for a negative value of <code>iIndex</code>, the item is inserted at position 0; for a value greater than the current size of the aggregation, the item is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MenuItem insertItem(sap.m.MenuItem oItem, int iIndex);

				/// <summary>
				/// Adds some item to the aggregation {@link #getItems items}.
				/// </summary>
				/// <param name="oItem">The item to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MenuItem addItem(sap.m.MenuItem oItem);

				/// <summary>
				/// Removes a item from the aggregation {@link #getItems items}.
				/// </summary>
				/// <param name="vItem">The item to remove or its index or id</param>
				/// <returns>The removed item or <code>null</code></returns>
				public extern virtual sap.m.MenuItem removeItem(Union<int, string, sap.m.MenuItem> vItem);

				/// <summary>
				/// Checks for the provided <code>sap.m.MenuItem</code> in the aggregation {@link #getItems items}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oItem">The item whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfItem(sap.m.MenuItem oItem);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getItems items}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.m.MenuItem[] removeAllItems();

				/// <summary>
				/// Binds aggregation {@link #getItems items} to model data.
				/// 
				/// See {@link sap.ui.base.ManagedObject#bindAggregation ManagedObject.bindAggregation} for a detailed description of the possible properties of <code>oBindingInfo</code>.
				/// </summary>
				/// <param name="oBindingInfo">The binding information</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MenuItem bindItems(object oBindingInfo);

				/// <summary>
				/// Unbinds aggregation {@link #getItems items} from model data.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MenuItem unbindItems();

				#endregion

				#region Methods for Event press

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:press press} event of this <code>sap.m.MenuItem</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MenuItem</code> itself.
				/// 
				/// Fired after the item has been pressed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.MenuItem</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MenuItem attachPress(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:press press} event of this <code>sap.m.MenuItem</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MenuItem</code> itself.
				/// 
				/// Fired after the item has been pressed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MenuItem attachPress(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:press press} event of this <code>sap.m.MenuItem</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MenuItem</code> itself.
				/// 
				/// Fired after the item has been pressed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MenuItem attachPress(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:press press} event of this <code>sap.m.MenuItem</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MenuItem</code> itself.
				/// 
				/// Fired after the item has been pressed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.MenuItem</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MenuItem attachPress(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:press press} event of this <code>sap.m.MenuItem</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MenuItem detachPress(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:press press} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MenuItem firePress(object mParameters);

				/// <summary>
				/// Fires event {@link #event:press press} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MenuItem firePress();

				#endregion

				#region Methods for Event propertyChanged

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:propertyChanged propertyChanged} event of this <code>sap.m.MenuItem</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MenuItem</code> itself.
				/// 
				/// Fired when a property of the item changes.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.MenuItem</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MenuItem attachPropertyChanged(object oData, sap.m.MenuItem.PropertyChangedDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:propertyChanged propertyChanged} event of this <code>sap.m.MenuItem</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MenuItem</code> itself.
				/// 
				/// Fired when a property of the item changes.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MenuItem attachPropertyChanged(object oData, sap.m.MenuItem.PropertyChangedDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:propertyChanged propertyChanged} event of this <code>sap.m.MenuItem</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MenuItem</code> itself.
				/// 
				/// Fired when a property of the item changes.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MenuItem attachPropertyChanged(sap.m.MenuItem.PropertyChangedDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:propertyChanged propertyChanged} event of this <code>sap.m.MenuItem</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MenuItem</code> itself.
				/// 
				/// Fired when a property of the item changes.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.MenuItem</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MenuItem attachPropertyChanged(sap.m.MenuItem.PropertyChangedDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:propertyChanged propertyChanged} event of this <code>sap.m.MenuItem</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MenuItem detachPropertyChanged(sap.m.MenuItem.PropertyChangedDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:propertyChanged propertyChanged} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MenuItem firePropertyChanged(sap.m.MenuItem.PropertyChangedInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:propertyChanged propertyChanged} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MenuItem firePropertyChanged();

				#endregion

				#region Methods for Event aggregationChanged

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:aggregationChanged aggregationChanged} event of this <code>sap.m.MenuItem</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MenuItem</code> itself.
				/// 
				/// Fired when aggregation of the item changes.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.MenuItem</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MenuItem attachAggregationChanged(object oData, sap.m.MenuItem.AggregationChangedDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:aggregationChanged aggregationChanged} event of this <code>sap.m.MenuItem</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MenuItem</code> itself.
				/// 
				/// Fired when aggregation of the item changes.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MenuItem attachAggregationChanged(object oData, sap.m.MenuItem.AggregationChangedDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:aggregationChanged aggregationChanged} event of this <code>sap.m.MenuItem</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MenuItem</code> itself.
				/// 
				/// Fired when aggregation of the item changes.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MenuItem attachAggregationChanged(sap.m.MenuItem.AggregationChangedDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:aggregationChanged aggregationChanged} event of this <code>sap.m.MenuItem</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MenuItem</code> itself.
				/// 
				/// Fired when aggregation of the item changes.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.MenuItem</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MenuItem attachAggregationChanged(sap.m.MenuItem.AggregationChangedDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:aggregationChanged aggregationChanged} event of this <code>sap.m.MenuItem</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MenuItem detachAggregationChanged(sap.m.MenuItem.AggregationChangedDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:aggregationChanged aggregationChanged} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MenuItem fireAggregationChanged(sap.m.MenuItem.AggregationChangedInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:aggregationChanged aggregationChanged} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MenuItem fireAggregationChanged();

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.MenuItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Item.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.MenuItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Item.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.MenuItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Item.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.MenuItem.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				#endregion

				#endregion

			}
		}
	}
}
