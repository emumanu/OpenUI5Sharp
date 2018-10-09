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
				/// The TreeTable control provides a comprehensive set of features to display hierarchical data.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.table.TreeTable")]
				public partial class TreeTable : sap.ui.table.Table
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
						/// Specifies whether the first level is expanded.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> expandFirstLevel;

						/// <summary>
						/// If group mode is enabled nodes with subitems are rendered as if they were group headers. This can be used to do the grouping for an OData service on the backend and visualize this in a table.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> useGroupMode;

						/// <summary>
						/// The property name of the rows data which will be displayed as a group header if the group mode is enabled
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> groupHeaderProperty;

						/// <summary>
						/// Setting collapseRecursive to true means, that when collapsing a node all subsequent child nodes will also be collapsed. This property is only supported with sap.ui.model.odata.v2.ODataModel. <b>Note:</b> collapseRecursive is currently <b>not</b> supported if your OData service exposes the hierarchy annotation <code>hierarchy-descendant-count-for</code>. In this case the value of the collapseRecursive property is ignored. For more information about the OData hierarchy annotations, please see the <b>SAP Annotations for OData Version 2.0</b> specification.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> collapseRecursive;

						/// <summary>
						/// The root level is the level of the topmost tree nodes, which will be used as an entry point for OData services. This property is only supported when the TreeTable uses an underlying odata services with hierarchy annotations. This property is only supported with sap.ui.model.odata.v2.ODataModel The hierarchy annotations may also be provided locally as a parameter for the ODataTreeBinding.
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> rootLevel;

						/// <summary>
						/// Fired when a row has been expanded or collapsed by user interaction. Only available in hierarchical mode.
						/// </summary>
						public sap.ui.table.TreeTable.ToggleOpenStateDelegate toggleOpenState;

					}

					#endregion

					#region Typed Parameters

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class ToggleOpenStateInfo
					{
						/// <summary>
						/// Index of the expanded/collapsed row
						/// </summary>
						public int rowIndex;

						/// <summary>
						/// Binding context of the expanded/collapsed row
						/// </summary>
						public object rowContext;

						/// <summary>
						/// Flag that indicates whether the row has been expanded or collapsed
						/// </summary>
						public bool expanded;

					}

					#endregion

					#region Delegates

					public delegate void ToggleOpenStateDelegate(sap.ui.@base.Event<sap.ui.table.TreeTable.ToggleOpenStateInfo> oEvent, object oData);

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new TreeTable.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern TreeTable(string sId, sap.ui.table.TreeTable.Settings mSettings);

					/// <summary>
					/// Constructor for a new TreeTable.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern TreeTable(string sId);

					/// <summary>
					/// Constructor for a new TreeTable.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern TreeTable();

					/// <summary>
					/// Constructor for a new TreeTable.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern TreeTable(sap.ui.table.TreeTable.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property expandFirstLevel

					/// <summary>
					/// Gets current value of property {@link #getExpandFirstLevel expandFirstLevel}.
					/// 
					/// Specifies whether the first level is expanded.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>expandFirstLevel</code></returns>
					[Obsolete("Deprecated since 1.46.3. replaced by the corresponding binding parameter <code>numberOfExpandedLevels</code>.Example: <pre>  oTable.bindRows({     path: '...',     parameters: {        numberOfExpandedLevels: 1     }  });</pre>The value of the property is only taken into account if no parameter <code>numberOfExpandedLevels</code> is given in the binding information. Changes to this property after the table is bound do not have any effect unless an explicit (re-)bind of the <code>rows</code> aggregation is done.")]
					public extern virtual bool getExpandFirstLevel();

					/// <summary>
					/// Sets a new value for property {@link #getExpandFirstLevel expandFirstLevel}.
					/// 
					/// Specifies whether the first level is expanded.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bExpandFirstLevel">New value for property <code>expandFirstLevel</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					[Obsolete("Deprecated since 1.46.3. replaced by the corresponding binding parameter <code>numberOfExpandedLevels</code>.Example: <pre>  oTable.bindRows({     path: '...',     parameters: {        numberOfExpandedLevels: 1     }  });</pre>The value of the property is only taken into account if no parameter <code>numberOfExpandedLevels</code> is given in the binding information. Changes to this property after the table is bound do not have any effect unless an explicit (re-)bind of the <code>rows</code> aggregation is done.")]
					public extern virtual sap.ui.table.TreeTable setExpandFirstLevel(bool bExpandFirstLevel);

					#endregion

					#region Methods for Property useGroupMode

					/// <summary>
					/// Gets current value of property {@link #getUseGroupMode useGroupMode}.
					/// 
					/// If group mode is enabled nodes with subitems are rendered as if they were group headers. This can be used to do the grouping for an OData service on the backend and visualize this in a table.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>useGroupMode</code></returns>
					public extern virtual bool getUseGroupMode();

					/// <summary>
					/// Sets a new value for property {@link #getUseGroupMode useGroupMode}.
					/// 
					/// If group mode is enabled nodes with subitems are rendered as if they were group headers. This can be used to do the grouping for an OData service on the backend and visualize this in a table.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bUseGroupMode">New value for property <code>useGroupMode</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.TreeTable setUseGroupMode(bool bUseGroupMode);

					#endregion

					#region Methods for Property groupHeaderProperty

					/// <summary>
					/// Gets current value of property {@link #getGroupHeaderProperty groupHeaderProperty}.
					/// 
					/// The property name of the rows data which will be displayed as a group header if the group mode is enabled
					/// </summary>
					/// <returns>Value of property <code>groupHeaderProperty</code></returns>
					public extern virtual string getGroupHeaderProperty();

					/// <summary>
					/// Sets a new value for property {@link #getGroupHeaderProperty groupHeaderProperty}.
					/// 
					/// The property name of the rows data which will be displayed as a group header if the group mode is enabled
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sGroupHeaderProperty">New value for property <code>groupHeaderProperty</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.TreeTable setGroupHeaderProperty(string sGroupHeaderProperty);

					#endregion

					#region Methods for Property collapseRecursive

					/// <summary>
					/// Gets current value of property {@link #getCollapseRecursive collapseRecursive}.
					/// 
					/// Setting collapseRecursive to true means, that when collapsing a node all subsequent child nodes will also be collapsed. This property is only supported with sap.ui.model.odata.v2.ODataModel. <b>Note:</b> collapseRecursive is currently <b>not</b> supported if your OData service exposes the hierarchy annotation <code>hierarchy-descendant-count-for</code>. In this case the value of the collapseRecursive property is ignored. For more information about the OData hierarchy annotations, please see the <b>SAP Annotations for OData Version 2.0</b> specification.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>collapseRecursive</code></returns>
					public extern virtual bool getCollapseRecursive();

					/// <summary>
					/// Sets a new value for property {@link #getCollapseRecursive collapseRecursive}.
					/// 
					/// Setting collapseRecursive to true means, that when collapsing a node all subsequent child nodes will also be collapsed. This property is only supported with sap.ui.model.odata.v2.ODataModel. <b>Note:</b> collapseRecursive is currently <b>not</b> supported if your OData service exposes the hierarchy annotation <code>hierarchy-descendant-count-for</code>. In this case the value of the collapseRecursive property is ignored. For more information about the OData hierarchy annotations, please see the <b>SAP Annotations for OData Version 2.0</b> specification.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bCollapseRecursive">New value for property <code>collapseRecursive</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.TreeTable setCollapseRecursive(bool bCollapseRecursive);

					#endregion

					#region Methods for Property rootLevel

					/// <summary>
					/// Gets current value of property {@link #getRootLevel rootLevel}.
					/// 
					/// The root level is the level of the topmost tree nodes, which will be used as an entry point for OData services. This property is only supported when the TreeTable uses an underlying odata services with hierarchy annotations. This property is only supported with sap.ui.model.odata.v2.ODataModel The hierarchy annotations may also be provided locally as a parameter for the ODataTreeBinding.
					/// 
					/// Default value is <code>0</code>.
					/// </summary>
					/// <returns>Value of property <code>rootLevel</code></returns>
					public extern virtual int getRootLevel();

					/// <summary>
					/// Sets a new value for property {@link #getRootLevel rootLevel}.
					/// 
					/// The root level is the level of the topmost tree nodes, which will be used as an entry point for OData services. This property is only supported when the TreeTable uses an underlying odata services with hierarchy annotations. This property is only supported with sap.ui.model.odata.v2.ODataModel The hierarchy annotations may also be provided locally as a parameter for the ODataTreeBinding.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>0</code>.
					/// </summary>
					/// <param name="iRootLevel">New value for property <code>rootLevel</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.TreeTable setRootLevel(int iRootLevel);

					#endregion

					#region Methods for Event toggleOpenState

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:toggleOpenState toggleOpenState} event of this <code>sap.ui.table.TreeTable</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.table.TreeTable</code> itself.
					/// 
					/// Fired when a row has been expanded or collapsed by user interaction. Only available in hierarchical mode.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.table.TreeTable</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.TreeTable attachToggleOpenState(object oData, sap.ui.table.TreeTable.ToggleOpenStateDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:toggleOpenState toggleOpenState} event of this <code>sap.ui.table.TreeTable</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.table.TreeTable</code> itself.
					/// 
					/// Fired when a row has been expanded or collapsed by user interaction. Only available in hierarchical mode.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.TreeTable attachToggleOpenState(object oData, sap.ui.table.TreeTable.ToggleOpenStateDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:toggleOpenState toggleOpenState} event of this <code>sap.ui.table.TreeTable</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.table.TreeTable</code> itself.
					/// 
					/// Fired when a row has been expanded or collapsed by user interaction. Only available in hierarchical mode.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.TreeTable attachToggleOpenState(sap.ui.table.TreeTable.ToggleOpenStateDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:toggleOpenState toggleOpenState} event of this <code>sap.ui.table.TreeTable</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.table.TreeTable</code> itself.
					/// 
					/// Fired when a row has been expanded or collapsed by user interaction. Only available in hierarchical mode.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.table.TreeTable</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.TreeTable attachToggleOpenState(sap.ui.table.TreeTable.ToggleOpenStateDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:toggleOpenState toggleOpenState} event of this <code>sap.ui.table.TreeTable</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.TreeTable detachToggleOpenState(sap.ui.table.TreeTable.ToggleOpenStateDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:toggleOpenState toggleOpenState} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.TreeTable fireToggleOpenState(sap.ui.table.TreeTable.ToggleOpenStateInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:toggleOpenState toggleOpenState} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.TreeTable fireToggleOpenState();

					#endregion

					#region Other methods

					/// <summary>
					/// Marks a range of tree nodes as selected, starting with iFromIndex going to iToIndex. The TreeNodes are referenced via their absolute row index. Please be aware, that the absolute row index only applies to the tree which is visualized by the TreeTable. Invisible nodes (collapsed child nodes) will not be regarded.
					/// 
					/// Please also take notice of the fact, that "addSelectionInterval" does not change any other selection. To override the current selection, please use "setSelctionInterval" or for a single entry use "setSelectedIndex".
					/// </summary>
					/// <param name="iFromIndex">The starting index of the range which will be selected.</param>
					/// <param name="iToIndex">The starting index of the range which will be selected.</param>
					/// <returns>a reference on the TreeTable control, can be used for chaining</returns>
					public extern virtual sap.ui.table.TreeTable addSelectionInterval(int iFromIndex, int iToIndex);

					/// <summary>
					/// Clears the complete selection (all tree table rows/nodes will lose their selection)
					/// </summary>
					/// <returns>a reference on the TreeTable control, can be used for chaining</returns>
					public extern virtual sap.ui.table.TreeTable clearSelection();

					/// <summary>
					/// Collapses one or more rows.
					/// </summary>
					/// <param name="vRowIndex">A single index or an array of indices of the rows to be collapsed</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.table.TreeTable collapse(Union<int, int[]> vRowIndex);

					/// <summary>
					/// Collapses all nodes (and lower if collapseRecursive is activated)
					/// </summary>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.table.TreeTable collapseAll();

					/// <summary>
					/// Expands one or more rows.
					/// </summary>
					/// <param name="vRowIndex">A single index or an array of indices of the rows to be expanded</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.table.TreeTable expand(Union<int, int[]> vRowIndex);

					/// <summary>
					/// Expands all nodes starting from the root level to the given level 'iLevel'.
					/// 
					/// Only supported with ODataModel v2, when running in OperationMode.Client or OperationMode.Auto. Fully supported for <code>sap.ui.model.ClientTreeBinding</code>, e.g. if you are using a <code>sap.ui.model.json.JSONModel</code>.
					/// 
					/// Please also see <code>sap.ui.model.odata.OperationMode</code>.
					/// </summary>
					/// <param name="iLevel">the level to which the trees shall be expanded</param>
					/// <returns>a reference on the TreeTable control, can be used for chaining</returns>
					public extern virtual sap.ui.table.TreeTable expandToLevel(int iLevel);

					/// <summary>
					/// Creates a new subclass of class sap.ui.table.TreeTable with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.table.Table.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.table.TreeTable with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.table.Table.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.table.TreeTable with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.table.Table.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// The property <code>enableGrouping</code> is not supported by the <code>TreeTable</code> control.
					/// </summary>
					[Obsolete("Deprecated since 1.28.")]
					public extern virtual void getEnableGrouping();

					/// <summary>
					/// The <code>groupBy</code> association is not supported by the <code>TreeTable</code> control.
					/// </summary>
					[Obsolete("Deprecated since 1.28.")]
					public extern virtual void getGroupBy();

					/// <summary>
					/// Returns a metadata object for class sap.ui.table.TreeTable.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					/// <summary>
					/// Retrieves the lead selection index. The lead selection index is, among other things, used to determine the start/end of a selection range, when using Shift-Click to select multiple entries at once.
					/// </summary>
					/// <returns>index of lead selected row</returns>
					public extern override int getSelectedIndex();

					/// <summary>
					/// Returns an array containing the row indices of all selected tree nodes (ordered ascending).
					/// 
					/// Please be aware of the following: Due to performance/network traffic reasons, the getSelectedIndices function returns only all indices of actually selected rows/tree nodes. Unknown rows/nodes (as in "not yet loaded" to the client), will not be returned.
					/// </summary>
					/// <returns>an array containing all selected indices</returns>
					public extern virtual int[] getSelectedIndices();

					/// <summary>
					/// Checks whether the row is expanded or collapsed.
					/// </summary>
					/// <param name="iRowIndex">The index of the row to be checked</param>
					/// <returns><code>true</code> if the row is expanded, <code>false</code> if it is collapsed</returns>
					public extern virtual bool isExpanded(int iRowIndex);

					/// <summary>
					/// Checks if the row at the given index is selected.
					/// </summary>
					/// <param name="iRowIndex">The row index for which the selection state should be retrieved</param>
					/// <returns>true if the index is selected, false otherwise</returns>
					public extern virtual bool isIndexSelected(int iRowIndex);

					/// <summary>
					/// All rows/tree nodes inside the range (including boundaries) will be deselected. Tree nodes are referenced with theit absolute row index inside the tree- Please be aware, that the absolute row index only applies to the tree which is visualized by the TreeTable. Invisible nodes (collapsed child nodes) will not be regarded.
					/// </summary>
					/// <param name="iFromIndex">The starting index of the range which will be deselected.</param>
					/// <param name="iToIndex">The starting index of the range which will be deselected.</param>
					/// <returns>a reference on the TreeTable control, can be used for chaining</returns>
					public extern virtual sap.ui.table.TreeTable removeSelectionInterval(int iFromIndex, int iToIndex);

					/// <summary>
					/// Selects all available nodes/rows.
					/// 
					/// All rows/tree nodes that are locally stored on the client and that are part of the currently visible tree are selected. Additional rows or tree nodes that come into view through scrolling or paging are also selected immediately as soon as they get visible. However, <code>SelectAll</code> does not retrieve any data from the back end in order to improve performance and reduce the network traffic.
					/// </summary>
					/// <returns>a reference on the TreeTable control, can be used for chaining</returns>
					public extern virtual sap.ui.table.TreeTable selectAll();

					/// <summary>
					/// The property <code>enableGrouping</code> is not supported by the <code>TreeTable</code> control.
					/// </summary>
					/// <returns>Reference to this in order to allow method chaining</returns>
					[Obsolete("Deprecated since 1.28. To get a group-like visualization the <code>useGroupMode</code> property can be used.")]
					public extern virtual sap.ui.table.TreeTable setEnableGrouping();

					/// <summary>
					/// Setter for property <code>fixedRowCount</code>.
					/// 
					/// <b>This property is not supportd for the TreeTable and will be ignored!</b>
					/// 
					/// Default value is <code>0</code>
					/// </summary>
					/// <param name="iFixedRowCount">new value for property <code>fixedRowCount</code></param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.table.TreeTable setFixedRowCount(int iFixedRowCount);

					/// <summary>
					/// The <code>groupBy</code> association is not supported by the <code>TreeTable</code> control.
					/// </summary>
					/// <returns>Reference to this in order to allow method chaining</returns>
					[Obsolete("Deprecated since 1.28.")]
					public extern virtual sap.ui.table.TreeTable setGroupBy();

					/// <summary>
					/// Overridden from Table.js base class. In a TreeTable you can only select indices, which correspond to the currently visualized tree. Invisible tree nodes (e.g. collapsed child nodes) can not be selected via Index, because they do not correspond to a TreeTable row.
					/// </summary>
					/// <param name="iRowIndex">The row index which will be selected (if existing)</param>
					/// <returns>a reference on the TreeTable control, can be used for chaining</returns>
					public extern virtual sap.ui.table.TreeTable setSelectedIndex(int iRowIndex);

					/// <summary>
					/// Sets the selection of the TreeTable to the given range (including boundaries). Beware: The previous selection will be lost/overriden. If this is not wanted, please use "addSelectionInterval" and "removeSelectionIntervall".
					/// </summary>
					/// <param name="iFromIndex">the start index of the selection range</param>
					/// <param name="iToIndex">the end index of the selection range</param>
					/// <returns>a reference on the TreeTable control, can be used for chaining</returns>
					public extern virtual sap.ui.table.TreeTable setSelectionInterval(int iFromIndex, int iToIndex);

					/// <summary>
					/// Allows to hide the tree structure (tree icons, indentation) in tree mode (property <code>useGroupMode</code> is set to <code>false</code>).
					/// 
					/// This option might be useful in some scenarios when actually a tree table must be used but under certain conditions the data is not hierarchical, because it contains leafs only.
					/// 
					/// <b>Note:</b> In flat mode the user of the table cannot expand or collapse certain nodes and the hierarchy is not visible to the user. The caller of this function has to ensure to use this option only with non-hierarchical data.
					/// </summary>
					/// <param name="bFlat">If set to <code>true</code>, the flat mode is enabled</param>
					/// <returns>Reference to this in order to allow method chaining</returns>
					public extern virtual sap.ui.table.TreeTable setUseFlatMode(bool bFlat);

					#endregion

					#endregion

				}
			}
		}
	}
}
