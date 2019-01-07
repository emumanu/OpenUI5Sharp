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
			/// <code>sap.m.Table</code> control provides a set of sophisticated and convenience functions for responsive table design. To render the <code>sap.m.Table</code> properly, the order of the <code>columns</code> aggregation should match with the order of the items <code>cells</code> aggregation (<code>sap.m.ColumnListItem</code>). Also <code>sap.m.Table</code> requires at least one visible <code>sap.m.Column</code> in <code>columns</code> aggregation. For mobile devices, the recommended limit of table rows is 100 (based on 4 columns) to assure proper performance. To improve initial rendering on large tables, use the <code>growing</code> feature.
			/// 
			/// See section "{@link topic:5eb6f63e0cc547d0bdc934d3652fdc9b Creating Tables}" and "{@link topic:38855e06486f4910bfa6f4485f7c2bac Configuring Responsive Behavior of a Table}" in the documentation for an introduction to <code>sap.m.Table</code> control.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.Table")]
			public partial class Table : sap.m.ListBase
			{
				#region Settings

				/// <summary>
				/// Settings class to create the object
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class Settings : sap.m.ListBase.Settings
				{
					/// <summary>
					/// Sets the background style of the table. Depending on the theme, you can change the state of the background from <code>Solid</code> to <code>Translucent</code> or to <code>Transparent</code>.
					/// </summary>
					public Union<sap.m.BackgroundDesign, string, sap.ui.@base.ManagedObject.BindPropertyInfo> backgroundDesign;

					/// <summary>
					/// Defines the algorithm to be used to layout the table cells, rows, and columns. By default, a table is rendered with fixed layout algorithm. This means the horizontal layout only depends on the table's width and the width of the columns, not the contents of the cells. Cells in subsequent rows do not affect column widths. This allows a browser to layout the table faster than the auto table layout since the browser can begin to display the table once the first row has been analyzed.
					/// 
					/// When this property is set to <code>false</code>, <code>sap.m.Table</code> is rendered with auto layout algorithm. This means, the width of the table and its cells depends on the contents of the cells. The column width is set by the widest unbreakable content inside the cells. This can make the rendering slow, since the browser needs to read through all the content in the table before determining the final layout. <b>Note:</b> Since <code>sap.m.Table</code> does not have its own scrollbars, setting <code>fixedLayout</code> to false can force the table to overflow, which may cause visual problems. It is suggested to use this property when a table has a few columns in wide screens or within the horizontal scroll container (e.g <code>sap.m.Dialog</code>) to handle overflow. In auto layout mode the <code>width</code> property of <code>sap.m.Column</code> is taken into account as a minimum width.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> fixedLayout;

					/// <summary>
					/// Setting this property to <code>true</code> will show an overlay on top of the table content and prevents the user interaction with it.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showOverlay;

					/// <summary>
					/// Enables alternating table row colors. <b>Note:</b> This property can only be used with the Belize and Belize Deep themes. Alternate row coloring is not available for the High Contrast Black/White themes.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> alternateRowColors;

					/// <summary>
					/// Defines the layout in which the table pop-in rows are rendered. <b>Note:</b> The <code>demandPopin</code> and <code>minScreenWidth</code> properties of the <code>Column</code> control must be configured appropriately.
					/// </summary>
					public Union<sap.m.PopinLayout, string, sap.ui.@base.ManagedObject.BindPropertyInfo> popinLayout;

					/// <summary>
					/// Defines the columns of the table.
					/// </summary>
					public Union<sap.m.Column[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> columns;

					/// <summary>
					/// Fired when the context menu is opened. When the context menu is opened, the binding context of the item is set to the given <code>contextMenu</code>.
					/// </summary>
					public sap.m.Table.BeforeOpenContextMenuDelegate beforeOpenContextMenu;

				}

				#endregion

				#region Typed Parameters

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class BeforeOpenContextMenuInfo
				{
					/// <summary>
					/// Item in which the context menu was opened.
					/// </summary>
					public sap.m.ColumnListItem listItem;

					/// <summary>
					/// Column in which the context menu was opened. <b>Note:</b> This parameter might be undefined for the items that are not part of a column definition.
					/// </summary>
					public sap.m.Column column;

				}

				#endregion

				#region Delegates

				public delegate void BeforeOpenContextMenuDelegate(sap.ui.@base.Event<sap.m.Table.BeforeOpenContextMenuInfo> oEvent, object oData);

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new Table.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">Id for the new control, generated automatically if no id is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern Table(string sId, sap.m.Table.Settings mSettings);

				/// <summary>
				/// Constructor for a new Table.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">Id for the new control, generated automatically if no id is given</param>
				public extern Table(string sId);

				/// <summary>
				/// Constructor for a new Table.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern Table();

				/// <summary>
				/// Constructor for a new Table.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern Table(sap.m.Table.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property backgroundDesign

				/// <summary>
				/// Gets current value of property {@link #getBackgroundDesign backgroundDesign}.
				/// 
				/// Sets the background style of the table. Depending on the theme, you can change the state of the background from <code>Solid</code> to <code>Translucent</code> or to <code>Transparent</code>.
				/// 
				/// Default value is <code>Translucent</code>.
				/// </summary>
				/// <returns>Value of property <code>backgroundDesign</code></returns>
				public extern virtual sap.m.BackgroundDesign getBackgroundDesign();

				/// <summary>
				/// Sets a new value for property {@link #getBackgroundDesign backgroundDesign}.
				/// 
				/// Sets the background style of the table. Depending on the theme, you can change the state of the background from <code>Solid</code> to <code>Translucent</code> or to <code>Transparent</code>.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Translucent</code>.
				/// </summary>
				/// <param name="sBackgroundDesign">New value for property <code>backgroundDesign</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Table setBackgroundDesign(sap.m.BackgroundDesign sBackgroundDesign);

				#endregion

				#region Methods for Property fixedLayout

				/// <summary>
				/// Gets current value of property {@link #getFixedLayout fixedLayout}.
				/// 
				/// Defines the algorithm to be used to layout the table cells, rows, and columns. By default, a table is rendered with fixed layout algorithm. This means the horizontal layout only depends on the table's width and the width of the columns, not the contents of the cells. Cells in subsequent rows do not affect column widths. This allows a browser to layout the table faster than the auto table layout since the browser can begin to display the table once the first row has been analyzed.
				/// 
				/// When this property is set to <code>false</code>, <code>sap.m.Table</code> is rendered with auto layout algorithm. This means, the width of the table and its cells depends on the contents of the cells. The column width is set by the widest unbreakable content inside the cells. This can make the rendering slow, since the browser needs to read through all the content in the table before determining the final layout. <b>Note:</b> Since <code>sap.m.Table</code> does not have its own scrollbars, setting <code>fixedLayout</code> to false can force the table to overflow, which may cause visual problems. It is suggested to use this property when a table has a few columns in wide screens or within the horizontal scroll container (e.g <code>sap.m.Dialog</code>) to handle overflow. In auto layout mode the <code>width</code> property of <code>sap.m.Column</code> is taken into account as a minimum width.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>fixedLayout</code></returns>
				public extern virtual bool getFixedLayout();

				/// <summary>
				/// Sets a new value for property {@link #getFixedLayout fixedLayout}.
				/// 
				/// Defines the algorithm to be used to layout the table cells, rows, and columns. By default, a table is rendered with fixed layout algorithm. This means the horizontal layout only depends on the table's width and the width of the columns, not the contents of the cells. Cells in subsequent rows do not affect column widths. This allows a browser to layout the table faster than the auto table layout since the browser can begin to display the table once the first row has been analyzed.
				/// 
				/// When this property is set to <code>false</code>, <code>sap.m.Table</code> is rendered with auto layout algorithm. This means, the width of the table and its cells depends on the contents of the cells. The column width is set by the widest unbreakable content inside the cells. This can make the rendering slow, since the browser needs to read through all the content in the table before determining the final layout. <b>Note:</b> Since <code>sap.m.Table</code> does not have its own scrollbars, setting <code>fixedLayout</code> to false can force the table to overflow, which may cause visual problems. It is suggested to use this property when a table has a few columns in wide screens or within the horizontal scroll container (e.g <code>sap.m.Dialog</code>) to handle overflow. In auto layout mode the <code>width</code> property of <code>sap.m.Column</code> is taken into account as a minimum width.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bFixedLayout">New value for property <code>fixedLayout</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Table setFixedLayout(bool bFixedLayout);

				#endregion

				#region Methods for Property showOverlay

				/// <summary>
				/// Gets current value of property {@link #getShowOverlay showOverlay}.
				/// 
				/// Setting this property to <code>true</code> will show an overlay on top of the table content and prevents the user interaction with it.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>showOverlay</code></returns>
				public extern virtual bool getShowOverlay();

				/// <summary>
				/// Sets a new value for property {@link #getShowOverlay showOverlay}.
				/// 
				/// Setting this property to <code>true</code> will show an overlay on top of the table content and prevents the user interaction with it.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bShowOverlay">New value for property <code>showOverlay</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Table setShowOverlay(bool bShowOverlay);

				#endregion

				#region Methods for Property alternateRowColors

				/// <summary>
				/// Gets current value of property {@link #getAlternateRowColors alternateRowColors}.
				/// 
				/// Enables alternating table row colors. <b>Note:</b> This property can only be used with the Belize and Belize Deep themes. Alternate row coloring is not available for the High Contrast Black/White themes.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>alternateRowColors</code></returns>
				public extern virtual bool getAlternateRowColors();

				/// <summary>
				/// Sets a new value for property {@link #getAlternateRowColors alternateRowColors}.
				/// 
				/// Enables alternating table row colors. <b>Note:</b> This property can only be used with the Belize and Belize Deep themes. Alternate row coloring is not available for the High Contrast Black/White themes.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bAlternateRowColors">New value for property <code>alternateRowColors</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Table setAlternateRowColors(bool bAlternateRowColors);

				#endregion

				#region Methods for Property popinLayout

				/// <summary>
				/// Gets current value of property {@link #getPopinLayout popinLayout}.
				/// 
				/// Defines the layout in which the table pop-in rows are rendered. <b>Note:</b> The <code>demandPopin</code> and <code>minScreenWidth</code> properties of the <code>Column</code> control must be configured appropriately.
				/// 
				/// Default value is <code>Block</code>.
				/// </summary>
				/// <returns>Value of property <code>popinLayout</code></returns>
				public extern virtual sap.m.PopinLayout getPopinLayout();

				/// <summary>
				/// Sets a new value for property {@link #getPopinLayout popinLayout}.
				/// 
				/// Defines the layout in which the table pop-in rows are rendered. <b>Note:</b> The <code>demandPopin</code> and <code>minScreenWidth</code> properties of the <code>Column</code> control must be configured appropriately.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Block</code>.
				/// </summary>
				/// <param name="sPopinLayout">New value for property <code>popinLayout</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Table setPopinLayout(sap.m.PopinLayout sPopinLayout);

				#endregion

				#region Methods for Aggregation columns

				/// <summary>
				/// Getter for aggregation columns.
				/// </summary>
				/// <param name="bSort">set true to get the columns in an order that respects personalization settings</param>
				/// <returns>columns of the Table</returns>
				public extern virtual sap.m.Column[] getColumns(bool bSort);

				/// <summary>
				/// Getter for aggregation columns.
				/// </summary>
				/// <returns>columns of the Table</returns>
				public extern virtual sap.m.Column[] getColumns();

				/// <summary>
				/// Destroys all the columns in the aggregation {@link #getColumns columns}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Table destroyColumns();

				/// <summary>
				/// Inserts a column into the aggregation {@link #getColumns columns}.
				/// </summary>
				/// <param name="oColumn">The column to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the column should be inserted at; for a negative value of <code>iIndex</code>, the column is inserted at position 0; for a value greater than the current size of the aggregation, the column is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Table insertColumn(sap.m.Column oColumn, int iIndex);

				/// <summary>
				/// Adds some column to the aggregation {@link #getColumns columns}.
				/// </summary>
				/// <param name="oColumn">The column to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Table addColumn(sap.m.Column oColumn);

				/// <summary>
				/// Removes a column from the aggregation {@link #getColumns columns}.
				/// </summary>
				/// <param name="vColumn">The column to remove or its index or id</param>
				/// <returns>The removed column or <code>null</code></returns>
				public extern virtual sap.m.Column removeColumn(Union<int, string, sap.m.Column> vColumn);

				/// <summary>
				/// Checks for the provided <code>sap.m.Column</code> in the aggregation {@link #getColumns columns}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oColumn">The column whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfColumn(sap.m.Column oColumn);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getColumns columns}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.m.Column[] removeAllColumns();

				#endregion

				#region Methods for Event beforeOpenContextMenu

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeOpenContextMenu beforeOpenContextMenu} event of this <code>sap.m.Table</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Table</code> itself.
				/// 
				/// Fired when the context menu is opened. When the context menu is opened, the binding context of the item is set to the given <code>contextMenu</code>.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.Table</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Table attachBeforeOpenContextMenu(object oData, sap.m.Table.BeforeOpenContextMenuDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeOpenContextMenu beforeOpenContextMenu} event of this <code>sap.m.Table</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Table</code> itself.
				/// 
				/// Fired when the context menu is opened. When the context menu is opened, the binding context of the item is set to the given <code>contextMenu</code>.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Table attachBeforeOpenContextMenu(object oData, sap.m.Table.BeforeOpenContextMenuDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeOpenContextMenu beforeOpenContextMenu} event of this <code>sap.m.Table</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Table</code> itself.
				/// 
				/// Fired when the context menu is opened. When the context menu is opened, the binding context of the item is set to the given <code>contextMenu</code>.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Table attachBeforeOpenContextMenu(sap.m.Table.BeforeOpenContextMenuDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeOpenContextMenu beforeOpenContextMenu} event of this <code>sap.m.Table</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Table</code> itself.
				/// 
				/// Fired when the context menu is opened. When the context menu is opened, the binding context of the item is set to the given <code>contextMenu</code>.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.Table</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Table attachBeforeOpenContextMenu(sap.m.Table.BeforeOpenContextMenuDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:beforeOpenContextMenu beforeOpenContextMenu} event of this <code>sap.m.Table</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Table detachBeforeOpenContextMenu(sap.m.Table.BeforeOpenContextMenuDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:beforeOpenContextMenu beforeOpenContextMenu} to attached listeners.
				/// 
				/// Listeners may prevent the default action of this event by using the <code>preventDefault</code>-method on the event object.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Whether or not to prevent the default action</returns>
				public extern virtual bool fireBeforeOpenContextMenu(sap.m.Table.BeforeOpenContextMenuInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:beforeOpenContextMenu beforeOpenContextMenu} to attached listeners.
				/// 
				/// Listeners may prevent the default action of this event by using the <code>preventDefault</code>-method on the event object.
				/// </summary>
				/// <returns>Whether or not to prevent the default action</returns>
				public extern virtual bool fireBeforeOpenContextMenu();

				#endregion

				#region Other methods

				/// <summary>
				/// This method is a hook for the RenderManager that gets called during the rendering of child Controls. It allows to add, remove and update existing accessibility attributes (ARIA) of those controls.
				/// </summary>
				/// <param name="oElement">The Control that gets rendered by the RenderManager</param>
				/// <param name="mAriaProps">The mapping of "aria-" prefixed attributes</param>
				public extern virtual void enhanceAccessibilityState(sap.ui.core.Control oElement, object mAriaProps);

				/// <summary>
				/// Creates a new subclass of class sap.m.Table with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.ListBase.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.Table with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.ListBase.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.Table with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.ListBase.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.Table.
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
