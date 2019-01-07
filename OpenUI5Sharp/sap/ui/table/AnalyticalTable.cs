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
			public static partial class table
			{
				/// <summary>
				/// Table which handles analytical OData backends. The AnalyticalTable only works with an AnalyticalBinding and correctly annotated OData services. Please check on the SAP Annotations for OData Version 2.0 documentation for further details.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.table.AnalyticalTable")]
				public partial class AnalyticalTable : sap.ui.table.Table
				{
					#region Settings

					/// <summary>
					/// Settings class to create the object
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class Settings : sap.ui.table.Table.Settings
					{
						/// <summary>
						/// Specifies if the total values should be displayed in the group headers or on bottom of the row. Does not affect the total sum.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> sumOnTop;

						/// <summary>
						/// Number of levels, which should be opened initially (on first load of data).
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> numberOfExpandedLevels;

						/// <summary>
						/// The kind of auto expansion algorithm, e.g. optimized filter conditions, per level requests, ... Must be a value of <code>sap.ui.table.TreeAutoExpandMode</code>.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> autoExpandMode;

						/// <summary>
						/// Functions which is used to sort the column visibility menu entries e.g.: function(ColumnA, ColumnB) { return 0 = equals, <0 lower, >0 greater }; Other values than functions will be ignored.
						/// </summary>
						public Union<object, string, sap.ui.@base.ManagedObject.BindPropertyInfo> columnVisibilityMenuSorter;

						/// <summary>
						/// Setting collapseRecursive to true means, that when collapsing a node all subsequent child nodes will also be collapsed.
						/// 
						/// Calling the setter of this property only has an effect when the tables <code>rows</code> aggregation is already bound and the binding supports this feature.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> collapseRecursive;

						/// <summary>
						/// If dirty the content of the Table will be overlayed.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> dirty;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new AnalyticalTable.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern AnalyticalTable(string sId, sap.ui.table.AnalyticalTable.Settings mSettings);

					/// <summary>
					/// Constructor for a new AnalyticalTable.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern AnalyticalTable(string sId);

					/// <summary>
					/// Constructor for a new AnalyticalTable.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern AnalyticalTable();

					/// <summary>
					/// Constructor for a new AnalyticalTable.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern AnalyticalTable(sap.ui.table.AnalyticalTable.Settings mSettings);

					#endregion

					#region Fields

					/// <summary>
					/// Collapses one or more rows.
					/// </summary>
					public object collapse;

					/// <summary>
					/// Collapses all nodes (and their child nodes if collapseRecursive is activated).
					/// </summary>
					public object collapseAll;

					/// <summary>
					/// Expands one or more rows.
					/// </summary>
					public object expand;

					/// <summary>
					/// Checks whether the row is expanded or collapsed.
					/// </summary>
					public object isExpanded;

					#endregion

					#region Methods

					#region Methods for Property sumOnTop

					/// <summary>
					/// Gets current value of property {@link #getSumOnTop sumOnTop}.
					/// 
					/// Specifies if the total values should be displayed in the group headers or on bottom of the row. Does not affect the total sum.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>sumOnTop</code></returns>
					[Obsolete("Deprecated since 1.44.0. please use the corresponding binding parameter <code>sumOnTop</code> instead.Example: <pre>  oTable.bindRows({     path: '...',     parameters: {        sumOnTop: true     }  });</pre>The value of the property is only taken into account if no parameter is given in the binding information. Changes to this property after the table is bound do not have any effect unless an explicit (re-)bind of the <code>rows</code> aggregation is done.")]
					public extern virtual bool getSumOnTop();

					/// <summary>
					/// Sets a new value for property {@link #getSumOnTop sumOnTop}.
					/// 
					/// Specifies if the total values should be displayed in the group headers or on bottom of the row. Does not affect the total sum.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bSumOnTop">New value for property <code>sumOnTop</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					[Obsolete("Deprecated since 1.44.0. please use the corresponding binding parameter <code>sumOnTop</code> instead.Example: <pre>  oTable.bindRows({     path: '...',     parameters: {        sumOnTop: true     }  });</pre>The value of the property is only taken into account if no parameter is given in the binding information. Changes to this property after the table is bound do not have any effect unless an explicit (re-)bind of the <code>rows</code> aggregation is done.")]
					public extern virtual sap.ui.table.AnalyticalTable setSumOnTop(bool bSumOnTop);

					#endregion

					#region Methods for Property numberOfExpandedLevels

					/// <summary>
					/// Gets current value of property {@link #getNumberOfExpandedLevels numberOfExpandedLevels}.
					/// 
					/// Number of levels, which should be opened initially (on first load of data).
					/// 
					/// Default value is <code>0</code>.
					/// </summary>
					/// <returns>Value of property <code>numberOfExpandedLevels</code></returns>
					[Obsolete("Deprecated since 1.44.0. please use the corresponding binding parameter <code>numberOfExpandedLevels</code> instead.Example: <pre>  oTable.bindRows({     path: '...',     parameters: {        numberOfExpandedLevels: 1     }  });</pre>The value of the property is only taken into account if no parameter is given in the binding information. Changes to this property after the table is bound do not have any effect unless an explicit (re-)bind of the <code>rows</code> aggregation is done.")]
					public extern virtual int getNumberOfExpandedLevels();

					/// <summary>
					/// Sets a new value for property {@link #getNumberOfExpandedLevels numberOfExpandedLevels}.
					/// 
					/// Number of levels, which should be opened initially (on first load of data).
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>0</code>.
					/// </summary>
					/// <param name="iNumberOfExpandedLevels">New value for property <code>numberOfExpandedLevels</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					[Obsolete("Deprecated since 1.44.0. please use the corresponding binding parameter <code>numberOfExpandedLevels</code> instead.Example: <pre>  oTable.bindRows({     path: '...',     parameters: {        numberOfExpandedLevels: 1     }  });</pre>The value of the property is only taken into account if no parameter is given in the binding information. Changes to this property after the table is bound do not have any effect unless an explicit (re-)bind of the <code>rows</code> aggregation is done.")]
					public extern virtual sap.ui.table.AnalyticalTable setNumberOfExpandedLevels(int iNumberOfExpandedLevels);

					#endregion

					#region Methods for Property autoExpandMode

					/// <summary>
					/// Gets current value of property {@link #getAutoExpandMode autoExpandMode}.
					/// 
					/// The kind of auto expansion algorithm, e.g. optimized filter conditions, per level requests, ... Must be a value of <code>sap.ui.table.TreeAutoExpandMode</code>.
					/// 
					/// Default value is <code>Bundled</code>.
					/// </summary>
					/// <returns>Value of property <code>autoExpandMode</code></returns>
					[Obsolete("Deprecated since 1.44.0. please use the corresponding binding parameter <code>autoExpandMode</code> instead.Example: <pre>  oTable.bindRows({     path: '...',     parameters: {        autoExpandMode: 'Bundled'     }  });</pre>The value of the property is only taken into account if no parameter is given in the binding information. Changes to this property after the table is bound do not have any effect unless an explicit (re-)bind of the <code>rows</code> aggregation is done.")]
					public extern virtual string getAutoExpandMode();

					/// <summary>
					/// Sets a new value for property {@link #getAutoExpandMode autoExpandMode}.
					/// 
					/// The kind of auto expansion algorithm, e.g. optimized filter conditions, per level requests, ... Must be a value of <code>sap.ui.table.TreeAutoExpandMode</code>.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>Bundled</code>.
					/// </summary>
					/// <param name="sAutoExpandMode">New value for property <code>autoExpandMode</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					[Obsolete("Deprecated since 1.44.0. please use the corresponding binding parameter <code>autoExpandMode</code> instead.Example: <pre>  oTable.bindRows({     path: '...',     parameters: {        autoExpandMode: 'Bundled'     }  });</pre>The value of the property is only taken into account if no parameter is given in the binding information. Changes to this property after the table is bound do not have any effect unless an explicit (re-)bind of the <code>rows</code> aggregation is done.")]
					public extern virtual sap.ui.table.AnalyticalTable setAutoExpandMode(string sAutoExpandMode);

					#endregion

					#region Methods for Property columnVisibilityMenuSorter

					/// <summary>
					/// Gets current value of property {@link #getColumnVisibilityMenuSorter columnVisibilityMenuSorter}.
					/// 
					/// Functions which is used to sort the column visibility menu entries e.g.: function(ColumnA, ColumnB) { return 0 = equals, <0 lower, >0 greater }; Other values than functions will be ignored.
					/// </summary>
					/// <returns>Value of property <code>columnVisibilityMenuSorter</code></returns>
					public extern virtual object getColumnVisibilityMenuSorter();

					/// <summary>
					/// Sets a new value for property {@link #getColumnVisibilityMenuSorter columnVisibilityMenuSorter}.
					/// 
					/// Functions which is used to sort the column visibility menu entries e.g.: function(ColumnA, ColumnB) { return 0 = equals, <0 lower, >0 greater }; Other values than functions will be ignored.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="oColumnVisibilityMenuSorter">New value for property <code>columnVisibilityMenuSorter</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.AnalyticalTable setColumnVisibilityMenuSorter(object oColumnVisibilityMenuSorter);

					#endregion

					#region Methods for Property collapseRecursive

					/// <summary>
					/// Gets current value of property {@link #getCollapseRecursive collapseRecursive}.
					/// 
					/// Setting collapseRecursive to true means, that when collapsing a node all subsequent child nodes will also be collapsed.
					/// 
					/// Calling the setter of this property only has an effect when the tables <code>rows</code> aggregation is already bound and the binding supports this feature.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>collapseRecursive</code></returns>
					public extern virtual bool getCollapseRecursive();

					/// <summary>
					/// Sets a new value for property {@link #getCollapseRecursive collapseRecursive}.
					/// 
					/// Setting collapseRecursive to true means, that when collapsing a node all subsequent child nodes will also be collapsed.
					/// 
					/// Calling the setter of this property only has an effect when the tables <code>rows</code> aggregation is already bound and the binding supports this feature.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bCollapseRecursive">New value for property <code>collapseRecursive</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.AnalyticalTable setCollapseRecursive(bool bCollapseRecursive);

					#endregion

					#region Methods for Property dirty

					/// <summary>
					/// Gets current value of property {@link #getDirty dirty}.
					/// 
					/// If dirty the content of the Table will be overlayed.
					/// </summary>
					/// <returns>Value of property <code>dirty</code></returns>
					[Obsolete("Deprecated since 1.21.2. replaced by {@link sap.ui.table.Table#setShowOverlay}")]
					public extern virtual bool getDirty();

					/// <summary>
					/// Sets a new value for property {@link #getDirty dirty}.
					/// 
					/// If dirty the content of the Table will be overlayed.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="bDirty">New value for property <code>dirty</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					[Obsolete("Deprecated since 1.21.2. replaced by {@link sap.ui.table.Table#setShowOverlay}")]
					public extern virtual sap.ui.table.AnalyticalTable setDirty(bool bDirty);

					#endregion

					#region Other methods

					/// <summary>
					/// Marks a range of tree nodes as selected, starting with iFromIndex going to iToIndex. The nodes are referenced via their absolute row index. Please be aware that the absolute row index only applies to the tree which is visualized by the <code>AnalyticalTable</code> control. Invisible nodes (collapsed child nodes) will not be taken into account.
					/// 
					/// Please also take notice of the fact, that "addSelectionInterval" does not change any other selection. To override the current selection, please use "setSelctionInterval" or for a single entry use "setSelectedIndex".
					/// </summary>
					/// <param name="iFromIndex">The starting index of the range which will be selected.</param>
					/// <param name="iToIndex">The starting index of the range which will be selected.</param>
					/// <returns>a reference to the <code>AnalyticalTable</code> control, can be used for chaining</returns>
					public extern virtual sap.ui.table.AnalyticalTable addSelectionInterval(int iFromIndex, int iToIndex);

					/// <summary>
					/// Clears the complete selection (all analytical table rows/nodes will be deselected).
					/// </summary>
					/// <returns>a reference to the <code>AnalyticalTable</code> control, can be used for chaining</returns>
					public extern virtual sap.ui.table.AnalyticalTable clearSelection();

					/// <summary>
					/// Creates a new subclass of class sap.ui.table.AnalyticalTable with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.table.Table.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.table.AnalyticalTable with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.table.Table.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.table.AnalyticalTable with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.table.Table.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns the context of a row by its index.
					/// </summary>
					/// <param name="iIndex">Index of the row to return the context from.</param>
					/// <returns>The context of a row by its index</returns>
					public extern override object getContextByIndex(int iIndex);

					/// <summary>
					/// The property <code>enableGrouping</code> is not supported by the <code>AnalyticalTable</code> control.
					/// </summary>
					[Obsolete("Deprecated since 1.28.")]
					public extern virtual void getEnableGrouping();

					/// <summary>
					/// The <code>groupBy</code> association is not supported by the <code>AnalyticalTable</code> control.
					/// </summary>
					[Obsolete("Deprecated since 1.28.")]
					public extern virtual void getGroupBy();

					/// <summary>
					/// Returns a metadata object for class sap.ui.table.AnalyticalTable.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					[Name("getMetadata")]
					public extern static sap.ui.@base.Metadata getMetadataStatic();

					/// <summary>
					/// Retrieves the lead selection index. The lead selection index is, among other things, used to determine the start/end of a selection range, when using Shift-Click to select multiple entries at once.
					/// </summary>
					/// <returns>an array containing all selected indices (ascending ordered integers)</returns>
					public extern virtual int[] getSelectedIndex();

					/// <summary>
					/// Returns an array containing the row indices of all selected tree nodes (in ascending order).
					/// 
					/// Please be aware of the following: Due to performance/network traffic reasons, the getSelectedIndices function returns only all indices of actually selected rows/tree nodes. Unknown rows/nodes (as in "not yet loaded" to the client), will not be returned.
					/// </summary>
					/// <returns>an array containing all selected indices</returns>
					public extern virtual int[] getSelectedIndices();

					/// <summary>
					/// Returns the total size of the data entries.
					/// </summary>
					/// <returns>The total size of the data entries</returns>
					public extern virtual int getTotalSize();

					/// <summary>
					/// Checks if the row at the given index is selected.
					/// </summary>
					/// <param name="iRowIndex">The row index for which the selection state should be retrieved</param>
					/// <returns>true if the index is selected, false otherwise</returns>
					public extern virtual bool isIndexSelected(int iRowIndex);

					/// <summary>
					/// All rows/tree nodes inside the range (including boundaries) will be deselected. The nodes are referenced with their absolute row index. Please be aware that the absolute row index only applies to the tree which is visualized by the <code>AnalyticalTable</code> control. Invisible nodes (collapsed child nodes) will not be taken into account.
					/// </summary>
					/// <param name="iFromIndex">The starting index of the range which will be deselected.</param>
					/// <param name="iToIndex">The starting index of the range which will be deselected.</param>
					/// <returns>a reference to the <code>AnalyticalTable</code> control, can be used for chaining</returns>
					public extern virtual sap.ui.table.AnalyticalTable removeSelectionInterval(int iFromIndex, int iToIndex);

					/// <summary>
					/// This function is used by some composite controls to force updating the AnalyticalInfo
					/// </summary>
					/// <param name="bSuppressRefresh">binding shall not refresh data</param>
					/// <param name="bForceChange">forces the binding to fire a change event</param>
					public extern virtual void resumeUpdateAnalyticalInfo(bool bSuppressRefresh, bool bForceChange);

					/// <summary>
					/// Selects all available nodes/rows.
					/// 
					/// Explanation of the SelectAll function and what to expect from its behavior: All rows/nodes stored locally on the client are selected. In addition all subsequent rows/tree nodes, which will be paged into view are also immediately selected. However, due to obvious performance/network traffic reasons, the SelectAll function will NOT retrieve any data from the backend.
					/// </summary>
					/// <returns>a reference to the <code>AnalyticalTable</code> control, can be used for chaining</returns>
					public extern virtual sap.ui.table.AnalyticalTable selectAll();

					/// <summary>
					/// The property <code>enableGrouping</code> is not supported by the <code>AnalyticalTable</code> control.
					/// </summary>
					/// <returns>Reference to this in order to allow method chaining</returns>
					[Obsolete("Deprecated since 1.28.")]
					public extern virtual sap.ui.table.AnalyticalTable setEnableGrouping();

					/// <summary>
					/// The <code>groupBy</code> association is not supported by the <code>AnalyticalTable</code> control.
					/// </summary>
					/// <returns>Reference to this in order to allow method chaining</returns>
					[Obsolete("Deprecated since 1.28.")]
					public extern virtual sap.ui.table.AnalyticalTable setGroupBy();

					/// <summary>
					/// In an <code>AnalyticalTable</code> control you can only select indices, which correspond to the currently visualized tree. Invisible nodes (e.g. collapsed child nodes) cannot be selected via Index, because they do not correspond to an <code>AnalyticalTable</code> row.
					/// </summary>
					/// <param name="iRowIndex">The row index which will be selected (in case it exists)</param>
					/// <returns>a reference to the <code>AnalyticalTable</code> control, can be used for chaining</returns>
					public extern virtual sap.ui.table.AnalyticalTable setSelectedIndex(int iRowIndex);

					/// <summary>
					/// Sets the selection of the <code>AnalyticalTable</code> control to the given range (including boundaries).
					/// 
					/// <b>Note:</b> The previous selection will be lost/overridden. If this is not the required behavior, please use <code>addSelectionInterval</code> and <code>removeSelectionIntervall</code>.
					/// </summary>
					/// <param name="iFromIndex">the start index of the selection range</param>
					/// <param name="iToIndex">the end index of the selection range</param>
					/// <returns>a reference to the <code>AnalyticalTable</code> control, can be used for chaining</returns>
					public extern virtual sap.ui.table.AnalyticalTable setSelectionInterval(int iFromIndex, int iToIndex);

					/// <summary>
					/// This function is used by some composite controls to avoid updating the AnalyticalInfo when several column are added to the table. In order to finally update the AnalyticalInfo and request data, resumeUpdateAnalyticalInfo must be called.
					/// </summary>
					public extern virtual void suspendUpdateAnalyticalInfo();

					#endregion

					#endregion

				}
			}
		}
	}
}
