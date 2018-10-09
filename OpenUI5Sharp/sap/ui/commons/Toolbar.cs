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
				/// A horizontal row of items where in many cases the single toolbar items are buttons containing icons. Note that all controls with the sap.ui.commons.ToolbarItem interface can be used as item: Button, ComboBox, TextField.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.Toolbar")]
				[Obsolete("Deprecated since 1.38. replaced by {@link sap.m.Toolbar}")]
				public partial class Toolbar : sap.ui.core.Control, sap.ui.core.Toolbar
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
						/// When there is not enough space for the toolbar to display all items, the rightmost items are overflowing into a drop-down menu.
						/// </summary>
						public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> width;

						/// <summary>
						/// Design settings are theme-dependent.
						/// </summary>
						public Union<sap.ui.commons.ToolbarDesign, string, sap.ui.@base.ManagedObject.BindPropertyInfo> design;

						/// <summary>
						/// Per default, tool bars have the stand alone status. Alternatively, they can be nested in other controls and then inherit the design from their parent control.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> standalone;

						/// <summary>
						/// Aggregating the tool bar items.
						/// </summary>
						public Union<sap.ui.commons.ToolbarItem[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> items;

						/// <summary>
						/// Aggregating the right side tool bar items.
						/// </summary>
						public Union<sap.ui.commons.ToolbarItem[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> rightItems;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new Toolbar.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern Toolbar(string sId, sap.ui.commons.Toolbar.Settings mSettings);

					/// <summary>
					/// Constructor for a new Toolbar.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern Toolbar(string sId);

					/// <summary>
					/// Constructor for a new Toolbar.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern Toolbar();

					/// <summary>
					/// Constructor for a new Toolbar.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern Toolbar(sap.ui.commons.Toolbar.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property width

					/// <summary>
					/// Gets current value of property {@link #getWidth width}.
					/// 
					/// When there is not enough space for the toolbar to display all items, the rightmost items are overflowing into a drop-down menu.
					/// 
					/// Default value is <code>auto</code>.
					/// </summary>
					/// <returns>Value of property <code>width</code></returns>
					public extern virtual sap.ui.core.CSSSize getWidth();

					/// <summary>
					/// Sets a new value for property {@link #getWidth width}.
					/// 
					/// When there is not enough space for the toolbar to display all items, the rightmost items are overflowing into a drop-down menu.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>auto</code>.
					/// </summary>
					/// <param name="sWidth">New value for property <code>width</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Toolbar setWidth(sap.ui.core.CSSSize sWidth);

					#endregion

					#region Methods for Property design

					/// <summary>
					/// Gets current value of property {@link #getDesign design}.
					/// 
					/// Design settings are theme-dependent.
					/// 
					/// Default value is <code>Flat</code>.
					/// </summary>
					/// <returns>Value of property <code>design</code></returns>
					public extern virtual sap.ui.commons.ToolbarDesign getDesign();

					/// <summary>
					/// Sets a new value for property {@link #getDesign design}.
					/// 
					/// Design settings are theme-dependent.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>Flat</code>.
					/// </summary>
					/// <param name="sDesign">New value for property <code>design</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Toolbar setDesign(sap.ui.commons.ToolbarDesign sDesign);

					#endregion

					#region Methods for Property standalone

					/// <summary>
					/// Gets current value of property {@link #getStandalone standalone}.
					/// 
					/// Per default, tool bars have the stand alone status. Alternatively, they can be nested in other controls and then inherit the design from their parent control.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>standalone</code></returns>
					public extern virtual bool getStandalone();

					/// <summary>
					/// Sets a new value for property {@link #getStandalone standalone}.
					/// 
					/// Per default, tool bars have the stand alone status. Alternatively, they can be nested in other controls and then inherit the design from their parent control.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bStandalone">New value for property <code>standalone</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Toolbar setStandalone(bool bStandalone);

					#endregion

					#region Methods for Aggregation items

					/// <summary>
					/// Gets content of aggregation {@link #getItems items}.
					/// 
					/// Aggregating the tool bar items.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.commons.ToolbarItem[] getItems();

					/// <summary>
					/// Destroys all the items in the aggregation {@link #getItems items}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Toolbar destroyItems();

					/// <summary>
					/// Inserts a item into the aggregation {@link #getItems items}.
					/// </summary>
					/// <param name="oItem">The item to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the item should be inserted at; for a negative value of <code>iIndex</code>, the item is inserted at position 0; for a value greater than the current size of the aggregation, the item is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Toolbar insertItem(sap.ui.commons.ToolbarItem oItem, int iIndex);

					/// <summary>
					/// Adds some item to the aggregation {@link #getItems items}.
					/// </summary>
					/// <param name="oItem">The item to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Toolbar addItem(sap.ui.commons.ToolbarItem oItem);

					/// <summary>
					/// Removes a item from the aggregation {@link #getItems items}.
					/// </summary>
					/// <param name="vItem">The item to remove or its index or id</param>
					/// <returns>The removed item or <code>null</code></returns>
					public extern virtual sap.ui.commons.ToolbarItem removeItem(Union<int, string, sap.ui.commons.ToolbarItem> vItem);

					/// <summary>
					/// Checks for the provided <code>sap.ui.commons.ToolbarItem</code> in the aggregation {@link #getItems items}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oItem">The item whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfItem(sap.ui.commons.ToolbarItem oItem);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getItems items}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.commons.ToolbarItem[] removeAllItems();

					#endregion

					#region Methods for Aggregation rightItems

					/// <summary>
					/// Gets content of aggregation {@link #getRightItems rightItems}.
					/// 
					/// Aggregating the right side tool bar items.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.commons.ToolbarItem[] getRightItems();

					/// <summary>
					/// Destroys all the rightItems in the aggregation {@link #getRightItems rightItems}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Toolbar destroyRightItems();

					/// <summary>
					/// Inserts a rightItem into the aggregation {@link #getRightItems rightItems}.
					/// </summary>
					/// <param name="oRightItem">The rightItem to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the rightItem should be inserted at; for a negative value of <code>iIndex</code>, the rightItem is inserted at position 0; for a value greater than the current size of the aggregation, the rightItem is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Toolbar insertRightItem(sap.ui.commons.ToolbarItem oRightItem, int iIndex);

					/// <summary>
					/// Adds some rightItem to the aggregation {@link #getRightItems rightItems}.
					/// </summary>
					/// <param name="oRightItem">The rightItem to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Toolbar addRightItem(sap.ui.commons.ToolbarItem oRightItem);

					/// <summary>
					/// Removes a rightItem from the aggregation {@link #getRightItems rightItems}.
					/// </summary>
					/// <param name="vRightItem">The rightItem to remove or its index or id</param>
					/// <returns>The removed rightItem or <code>null</code></returns>
					public extern virtual sap.ui.commons.ToolbarItem removeRightItem(Union<int, string, sap.ui.commons.ToolbarItem> vRightItem);

					/// <summary>
					/// Checks for the provided <code>sap.ui.commons.ToolbarItem</code> in the aggregation {@link #getRightItems rightItems}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oRightItem">The rightItem whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfRightItem(sap.ui.commons.ToolbarItem oRightItem);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getRightItems rightItems}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.commons.ToolbarItem[] removeAllRightItems();

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.Toolbar with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.Toolbar with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.Toolbar with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.commons.Toolbar.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					#endregion

					#endregion

				}
			}
		}
	}
}
