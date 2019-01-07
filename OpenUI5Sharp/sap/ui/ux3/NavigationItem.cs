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
				/// Is the item to be used within the NavigationBar
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.ux3.NavigationItem")]
				[Obsolete("Deprecated since 1.38. Instead, use the <code>sap.m.IconTabBar</code>, <code>sap.m.TabContainer</code> or <code>sap.uxap.ObjectPageLayout</code> control.")]
				public partial class NavigationItem : sap.ui.core.Item
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
						/// Whether the NavigationItem is currently visible. When making NavigationItems invisible at runtime it is the application's responsibility to make sure it is not the currently selected one - or to select another one in this case.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> visible;

						/// <summary>
						/// Defines the link target URL. This property is optional and should only be set when required! The use of the href property is to not only allow users to navigate in-place by left-clicking NavigationItems, but also to allow right-click and then "open in new tab" or "open in new window". As long as href is not set, an empty window will open and stay blank. But when href is set, the new window/tab will load this URL and it is the application's responsibility to display what the user expects (e.g. the Shell, with the respective NavigationItem being selected).
						/// </summary>
						public Union<sap.ui.core.URI, string, sap.ui.@base.ManagedObject.BindPropertyInfo> href;

						/// <summary>
						/// Any NavigationItems on the next hierarchy level connected to this NavigationItem
						/// </summary>
						public Union<sap.ui.ux3.NavigationItem[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> subItems;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new NavigationItem.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern NavigationItem(string sId, sap.ui.ux3.NavigationItem.Settings mSettings);

					/// <summary>
					/// Constructor for a new NavigationItem.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern NavigationItem(string sId);

					/// <summary>
					/// Constructor for a new NavigationItem.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern NavigationItem();

					/// <summary>
					/// Constructor for a new NavigationItem.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern NavigationItem(sap.ui.ux3.NavigationItem.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property visible

					/// <summary>
					/// Gets current value of property {@link #getVisible visible}.
					/// 
					/// Whether the NavigationItem is currently visible. When making NavigationItems invisible at runtime it is the application's responsibility to make sure it is not the currently selected one - or to select another one in this case.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>visible</code></returns>
					public extern virtual bool getVisible();

					/// <summary>
					/// Sets a new value for property {@link #getVisible visible}.
					/// 
					/// Whether the NavigationItem is currently visible. When making NavigationItems invisible at runtime it is the application's responsibility to make sure it is not the currently selected one - or to select another one in this case.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bVisible">New value for property <code>visible</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.NavigationItem setVisible(bool bVisible);

					#endregion

					#region Methods for Property href

					/// <summary>
					/// Gets current value of property {@link #getHref href}.
					/// 
					/// Defines the link target URL. This property is optional and should only be set when required! The use of the href property is to not only allow users to navigate in-place by left-clicking NavigationItems, but also to allow right-click and then "open in new tab" or "open in new window". As long as href is not set, an empty window will open and stay blank. But when href is set, the new window/tab will load this URL and it is the application's responsibility to display what the user expects (e.g. the Shell, with the respective NavigationItem being selected).
					/// </summary>
					/// <returns>Value of property <code>href</code></returns>
					public extern virtual sap.ui.core.URI getHref();

					/// <summary>
					/// Sets a new value for property {@link #getHref href}.
					/// 
					/// Defines the link target URL. This property is optional and should only be set when required! The use of the href property is to not only allow users to navigate in-place by left-clicking NavigationItems, but also to allow right-click and then "open in new tab" or "open in new window". As long as href is not set, an empty window will open and stay blank. But when href is set, the new window/tab will load this URL and it is the application's responsibility to display what the user expects (e.g. the Shell, with the respective NavigationItem being selected).
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sHref">New value for property <code>href</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.NavigationItem setHref(sap.ui.core.URI sHref);

					#endregion

					#region Methods for Aggregation subItems

					/// <summary>
					/// Gets content of aggregation {@link #getSubItems subItems}.
					/// 
					/// Any NavigationItems on the next hierarchy level connected to this NavigationItem
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.ux3.NavigationItem[] getSubItems();

					/// <summary>
					/// Destroys all the subItems in the aggregation {@link #getSubItems subItems}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.NavigationItem destroySubItems();

					/// <summary>
					/// Inserts a subItem into the aggregation {@link #getSubItems subItems}.
					/// </summary>
					/// <param name="oSubItem">The subItem to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the subItem should be inserted at; for a negative value of <code>iIndex</code>, the subItem is inserted at position 0; for a value greater than the current size of the aggregation, the subItem is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.NavigationItem insertSubItem(sap.ui.ux3.NavigationItem oSubItem, int iIndex);

					/// <summary>
					/// Adds some subItem to the aggregation {@link #getSubItems subItems}.
					/// </summary>
					/// <param name="oSubItem">The subItem to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.NavigationItem addSubItem(sap.ui.ux3.NavigationItem oSubItem);

					/// <summary>
					/// Removes a subItem from the aggregation {@link #getSubItems subItems}.
					/// </summary>
					/// <param name="vSubItem">The subItem to remove or its index or id</param>
					/// <returns>The removed subItem or <code>null</code></returns>
					public extern virtual sap.ui.ux3.NavigationItem removeSubItem(Union<int, string, sap.ui.ux3.NavigationItem> vSubItem);

					/// <summary>
					/// Checks for the provided <code>sap.ui.ux3.NavigationItem</code> in the aggregation {@link #getSubItems subItems}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oSubItem">The subItem whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfSubItem(sap.ui.ux3.NavigationItem oSubItem);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getSubItems subItems}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.ux3.NavigationItem[] removeAllSubItems();

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.ux3.NavigationItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Item.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.ux3.NavigationItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Item.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.ux3.NavigationItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Item.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.ux3.NavigationItem.
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
