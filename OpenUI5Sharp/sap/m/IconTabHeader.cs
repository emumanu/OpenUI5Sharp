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
			/// This control displays a number of IconTabFilters and IconTabSeparators. If the available horizontal space is exceeded, a horizontal scrolling appears.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.IconTabHeader")]
			public partial class IconTabHeader : sap.ui.core.Control
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
					/// Defines whether the current selection is visualized.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showSelection;

					/// <summary>
					/// Key of the selected item.
					/// 
					/// If the key has no corresponding aggregated item, no changes will apply. If duplicate keys exists the first item matching, the key is used.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> selectedKey;

					/// <summary>
					/// Specifies whether the control is rendered.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> visible;

					/// <summary>
					/// Specifies the header mode. <b>Note:</b> The Inline mode works only if no icons are set.
					/// </summary>
					public Union<sap.m.IconTabHeaderMode, string, sap.ui.@base.ManagedObject.BindPropertyInfo> mode;

					/// <summary>
					/// Specifies if the overflow select list is displayed.
					/// 
					/// The overflow select list represents a list, where all tab filters are displayed, so the user can select specific tab filter easier.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showOverflowSelectList;

					/// <summary>
					/// Specifies the background color of the header.
					/// 
					/// Depending on the theme, you can change the state of the background color to "Solid", "Translucent", or "Transparent". Default is "Solid".
					/// </summary>
					public Union<sap.m.BackgroundDesign, string, sap.ui.@base.ManagedObject.BindPropertyInfo> backgroundDesign;

					/// <summary>
					/// Specifies whether tab reordering is enabled. Relevant only for desktop devices. The {@link sap.m.IconTabSeparator sap.m.IconTabSeparator} cannot be dragged and dropped Items can be moved around {@link sap.m.IconTabSeparator sap.m.IconTabSeparator}
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> enableTabReordering;

					/// <summary>
					/// Specifies the visual density mode of the tabs.
					/// 
					/// The values that can be applied are <code>Cozy</code>, <code>Compact</code> and <code>Inherit</code>. <code>Cozy</code> and <code>Compact</code> render the control in one of these modes independent of the global density settings. The <code>Inherit</code> value follows the global density settings which are applied. For compatibility reasons, the default value is <code>Cozy</code>.
					/// </summary>
					public Union<sap.m.IconTabDensityMode, string, sap.ui.@base.ManagedObject.BindPropertyInfo> tabDensityMode;

					/// <summary>
					/// The items displayed in the IconTabHeader.
					/// </summary>
					public Union<sap.m.IconTab[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> items;

					/// <summary>
					/// Fires when an item is selected.
					/// </summary>
					public sap.m.IconTabHeader.SelectDelegate select;

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
					/// The selected item
					/// </summary>
					public sap.m.IconTabFilter item;

					/// <summary>
					/// The key of the selected item
					/// </summary>
					public string key;

				}

				#endregion

				#region Delegates

				public delegate void SelectDelegate(sap.ui.@base.Event<sap.m.IconTabHeader.SelectInfo> oEvent, object oData);

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new IconTabHeader.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern IconTabHeader(string sId, sap.m.IconTabHeader.Settings mSettings);

				/// <summary>
				/// Constructor for a new IconTabHeader.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern IconTabHeader(string sId);

				/// <summary>
				/// Constructor for a new IconTabHeader.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern IconTabHeader();

				/// <summary>
				/// Constructor for a new IconTabHeader.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern IconTabHeader(sap.m.IconTabHeader.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property showSelection

				/// <summary>
				/// Gets current value of property {@link #getShowSelection showSelection}.
				/// 
				/// Defines whether the current selection is visualized.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>showSelection</code></returns>
				[Obsolete("Deprecated since 1.15.0. Regarding to changes of this control this property is not needed anymore.")]
				public extern virtual bool getShowSelection();

				/// <summary>
				/// Sets a new value for property {@link #getShowSelection showSelection}.
				/// 
				/// Defines whether the current selection is visualized.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bShowSelection">New value for property <code>showSelection</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.15.0. Regarding to changes of this control this property is not needed anymore.")]
				public extern virtual sap.m.IconTabHeader setShowSelection(bool bShowSelection);

				#endregion

				#region Methods for Property selectedKey

				/// <summary>
				/// Gets current value of property {@link #getSelectedKey selectedKey}.
				/// 
				/// Key of the selected item.
				/// 
				/// If the key has no corresponding aggregated item, no changes will apply. If duplicate keys exists the first item matching, the key is used.
				/// </summary>
				/// <returns>Value of property <code>selectedKey</code></returns>
				public extern virtual string getSelectedKey();

				/// <summary>
				/// Sets the selected item based on key.
				/// </summary>
				/// <param name="sKey">The key of the item to be selected</param>
				/// <returns>this pointer for chaining</returns>
				public extern virtual sap.m.IconTabHeader setSelectedKey(string sKey);

				#endregion

				#region Methods for Property visible

				/// <summary>
				/// Gets current value of property {@link #getVisible visible}.
				/// 
				/// Specifies whether the control is rendered.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>visible</code></returns>
				public extern override bool getVisible();

				/// <summary>
				/// Sets a new value for property {@link #getVisible visible}.
				/// 
				/// Specifies whether the control is rendered.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bVisible">New value for property <code>visible</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.IconTabHeader setVisible(bool bVisible);

				#endregion

				#region Methods for Property mode

				/// <summary>
				/// Gets current value of property {@link #getMode mode}.
				/// 
				/// Specifies the header mode. <b>Note:</b> The Inline mode works only if no icons are set.
				/// 
				/// Default value is <code>Standard</code>.
				/// </summary>
				/// <returns>Value of property <code>mode</code></returns>
				public extern virtual sap.m.IconTabHeaderMode getMode();

				/// <summary>
				/// Sets a new value for property {@link #getMode mode}.
				/// 
				/// Specifies the header mode. <b>Note:</b> The Inline mode works only if no icons are set.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Standard</code>.
				/// </summary>
				/// <param name="sMode">New value for property <code>mode</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.IconTabHeader setMode(sap.m.IconTabHeaderMode sMode);

				#endregion

				#region Methods for Property showOverflowSelectList

				/// <summary>
				/// Gets current value of property {@link #getShowOverflowSelectList showOverflowSelectList}.
				/// 
				/// Specifies if the overflow select list is displayed.
				/// 
				/// The overflow select list represents a list, where all tab filters are displayed, so the user can select specific tab filter easier.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>showOverflowSelectList</code></returns>
				public extern virtual bool getShowOverflowSelectList();

				/// <summary>
				/// Sets a new value for property {@link #getShowOverflowSelectList showOverflowSelectList}.
				/// 
				/// Specifies if the overflow select list is displayed.
				/// 
				/// The overflow select list represents a list, where all tab filters are displayed, so the user can select specific tab filter easier.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bShowOverflowSelectList">New value for property <code>showOverflowSelectList</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.IconTabHeader setShowOverflowSelectList(bool bShowOverflowSelectList);

				#endregion

				#region Methods for Property backgroundDesign

				/// <summary>
				/// Gets current value of property {@link #getBackgroundDesign backgroundDesign}.
				/// 
				/// Specifies the background color of the header.
				/// 
				/// Depending on the theme, you can change the state of the background color to "Solid", "Translucent", or "Transparent". Default is "Solid".
				/// 
				/// Default value is <code>Solid</code>.
				/// </summary>
				/// <returns>Value of property <code>backgroundDesign</code></returns>
				public extern virtual sap.m.BackgroundDesign getBackgroundDesign();

				/// <summary>
				/// Sets a new value for property {@link #getBackgroundDesign backgroundDesign}.
				/// 
				/// Specifies the background color of the header.
				/// 
				/// Depending on the theme, you can change the state of the background color to "Solid", "Translucent", or "Transparent". Default is "Solid".
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Solid</code>.
				/// </summary>
				/// <param name="sBackgroundDesign">New value for property <code>backgroundDesign</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.IconTabHeader setBackgroundDesign(sap.m.BackgroundDesign sBackgroundDesign);

				#endregion

				#region Methods for Property enableTabReordering

				/// <summary>
				/// Gets current value of property {@link #getEnableTabReordering enableTabReordering}.
				/// 
				/// Specifies whether tab reordering is enabled. Relevant only for desktop devices. The {@link sap.m.IconTabSeparator sap.m.IconTabSeparator} cannot be dragged and dropped Items can be moved around {@link sap.m.IconTabSeparator sap.m.IconTabSeparator}
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>enableTabReordering</code></returns>
				public extern virtual bool getEnableTabReordering();

				/// <summary>
				/// Sets a new value for property {@link #getEnableTabReordering enableTabReordering}.
				/// 
				/// Specifies whether tab reordering is enabled. Relevant only for desktop devices. The {@link sap.m.IconTabSeparator sap.m.IconTabSeparator} cannot be dragged and dropped Items can be moved around {@link sap.m.IconTabSeparator sap.m.IconTabSeparator}
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bEnableTabReordering">New value for property <code>enableTabReordering</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.IconTabHeader setEnableTabReordering(bool bEnableTabReordering);

				#endregion

				#region Methods for Property tabDensityMode

				/// <summary>
				/// Gets current value of property {@link #getTabDensityMode tabDensityMode}.
				/// 
				/// Specifies the visual density mode of the tabs.
				/// 
				/// The values that can be applied are <code>Cozy</code>, <code>Compact</code> and <code>Inherit</code>. <code>Cozy</code> and <code>Compact</code> render the control in one of these modes independent of the global density settings. The <code>Inherit</code> value follows the global density settings which are applied. For compatibility reasons, the default value is <code>Cozy</code>.
				/// 
				/// Default value is <code>Cozy</code>.
				/// </summary>
				/// <returns>Value of property <code>tabDensityMode</code></returns>
				public extern virtual sap.m.IconTabDensityMode getTabDensityMode();

				/// <summary>
				/// Sets a new value for property {@link #getTabDensityMode tabDensityMode}.
				/// 
				/// Specifies the visual density mode of the tabs.
				/// 
				/// The values that can be applied are <code>Cozy</code>, <code>Compact</code> and <code>Inherit</code>. <code>Cozy</code> and <code>Compact</code> render the control in one of these modes independent of the global density settings. The <code>Inherit</code> value follows the global density settings which are applied. For compatibility reasons, the default value is <code>Cozy</code>.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Cozy</code>.
				/// </summary>
				/// <param name="sTabDensityMode">New value for property <code>tabDensityMode</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.IconTabHeader setTabDensityMode(sap.m.IconTabDensityMode sTabDensityMode);

				#endregion

				#region Methods for Aggregation items

				/// <summary>
				/// Gets content of aggregation {@link #getItems items}.
				/// 
				/// The items displayed in the IconTabHeader.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.IconTab[] getItems();

				/// <summary>
				/// Destroys all the items in the aggregation {@link #getItems items}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.IconTabHeader destroyItems();

				/// <summary>
				/// Inserts a item into the aggregation {@link #getItems items}.
				/// </summary>
				/// <param name="oItem">The item to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the item should be inserted at; for a negative value of <code>iIndex</code>, the item is inserted at position 0; for a value greater than the current size of the aggregation, the item is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.IconTabHeader insertItem(sap.m.IconTab oItem, int iIndex);

				/// <summary>
				/// Adds some item to the aggregation {@link #getItems items}.
				/// </summary>
				/// <param name="oItem">The item to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.IconTabHeader addItem(sap.m.IconTab oItem);

				/// <summary>
				/// Removes a item from the aggregation {@link #getItems items}.
				/// </summary>
				/// <param name="vItem">The item to remove or its index or id</param>
				/// <returns>The removed item or <code>null</code></returns>
				public extern virtual sap.m.IconTab removeItem(Union<int, string, sap.m.IconTab> vItem);

				/// <summary>
				/// Checks for the provided <code>sap.m.IconTab</code> in the aggregation {@link #getItems items}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oItem">The item whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfItem(sap.m.IconTab oItem);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getItems items}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.m.IconTab[] removeAllItems();

				#endregion

				#region Methods for Aggregation _overflowButton

				#endregion

				#region Methods for Event select

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.m.IconTabHeader</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.IconTabHeader</code> itself.
				/// 
				/// Fires when an item is selected.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.IconTabHeader</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.IconTabHeader attachSelect(object oData, sap.m.IconTabHeader.SelectDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.m.IconTabHeader</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.IconTabHeader</code> itself.
				/// 
				/// Fires when an item is selected.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.IconTabHeader attachSelect(object oData, sap.m.IconTabHeader.SelectDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.m.IconTabHeader</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.IconTabHeader</code> itself.
				/// 
				/// Fires when an item is selected.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.IconTabHeader attachSelect(sap.m.IconTabHeader.SelectDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.m.IconTabHeader</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.IconTabHeader</code> itself.
				/// 
				/// Fires when an item is selected.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.IconTabHeader</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.IconTabHeader attachSelect(sap.m.IconTabHeader.SelectDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:select select} event of this <code>sap.m.IconTabHeader</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.IconTabHeader detachSelect(sap.m.IconTabHeader.SelectDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:select select} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.IconTabHeader fireSelect(sap.m.IconTabHeader.SelectInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:select select} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.IconTabHeader fireSelect();

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.IconTabHeader with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.IconTabHeader with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.IconTabHeader with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.IconTabHeader.
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
