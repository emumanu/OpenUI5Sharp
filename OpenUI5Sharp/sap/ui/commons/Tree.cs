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
				/// Simple tree to display item in a hierarchical way
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.Tree")]
				[Obsolete("Deprecated since 1.38. replaced by {@link sap.m.Tree}")]
				public partial class Tree : sap.ui.core.Control
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
						/// Tree title
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> title;

						/// <summary>
						/// Tree width
						/// </summary>
						public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> width;

						/// <summary>
						/// Tree height
						/// </summary>
						public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> height;

						/// <summary>
						/// Tree Header is display. If false, the tree will be in a transparent mode
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showHeader;

						/// <summary>
						/// Show Header icons (e.g. Expand/Collapse all). Only consider if showHeader is true
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showHeaderIcons;

						/// <summary>
						/// Display horizontal scrollbar. If false, the overflow content will be hidden
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showHorizontalScrollbar;

						/// <summary>
						/// Minimal width for the Tree. Can be useful when, for example, the width is specified in percentage, to avoid the tree to become too narrow when container is resize
						/// </summary>
						public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> minWidth;

						/// <summary>
						/// Selection mode of the Tree.
						/// </summary>
						public Union<sap.ui.commons.TreeSelectionMode, string, sap.ui.@base.ManagedObject.BindPropertyInfo> selectionMode;

						/// <summary>
						/// First level nodes
						/// </summary>
						public Union<sap.ui.commons.TreeNode[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> nodes;

						/// <summary>
						/// Event is fired when a tree node is selected.
						/// </summary>
						public sap.ui.commons.Tree.SelectDelegate select;

						/// <summary>
						/// fired when the selection of the tree has been changed
						/// </summary>
						public sap.ui.commons.Tree.SelectionChangeDelegate selectionChange;

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
						/// The node which has been selected.
						/// </summary>
						public sap.ui.commons.TreeNode node;

						/// <summary>
						/// The binding context of the selected node.
						/// </summary>
						public object nodeContext;

					}

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class SelectionChangeInfo
					{
						/// <summary>
						/// The nodes which has been selected.
						/// </summary>
						public sap.ui.commons.TreeNode[] nodes;

						/// <summary>
						/// The binding context of the selected nodes.
						/// </summary>
						public object[] nodeContexts;

					}

					#endregion

					#region Delegates

					public delegate void SelectDelegate(sap.ui.@base.Event<sap.ui.commons.Tree.SelectInfo> oEvent, object oData);

					public delegate void SelectionChangeDelegate(sap.ui.@base.Event<sap.ui.commons.Tree.SelectionChangeInfo> oEvent, object oData);

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new Tree.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern Tree(string sId, sap.ui.commons.Tree.Settings mSettings);

					/// <summary>
					/// Constructor for a new Tree.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern Tree(string sId);

					/// <summary>
					/// Constructor for a new Tree.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern Tree();

					/// <summary>
					/// Constructor for a new Tree.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern Tree(sap.ui.commons.Tree.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property title

					/// <summary>
					/// Gets current value of property {@link #getTitle title}.
					/// 
					/// Tree title
					/// </summary>
					/// <returns>Value of property <code>title</code></returns>
					public extern virtual string getTitle();

					/// <summary>
					/// Sets a new value for property {@link #getTitle title}.
					/// 
					/// Tree title
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sTitle">New value for property <code>title</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Tree setTitle(string sTitle);

					#endregion

					#region Methods for Property width

					/// <summary>
					/// Gets current value of property {@link #getWidth width}.
					/// 
					/// Tree width
					/// 
					/// Default value is <code>auto</code>.
					/// </summary>
					/// <returns>Value of property <code>width</code></returns>
					public extern virtual sap.ui.core.CSSSize getWidth();

					/// <summary>
					/// Sets a new value for property {@link #getWidth width}.
					/// 
					/// Tree width
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>auto</code>.
					/// </summary>
					/// <param name="sWidth">New value for property <code>width</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Tree setWidth(sap.ui.core.CSSSize sWidth);

					#endregion

					#region Methods for Property height

					/// <summary>
					/// Gets current value of property {@link #getHeight height}.
					/// 
					/// Tree height
					/// 
					/// Default value is <code>auto</code>.
					/// </summary>
					/// <returns>Value of property <code>height</code></returns>
					public extern virtual sap.ui.core.CSSSize getHeight();

					/// <summary>
					/// Sets a new value for property {@link #getHeight height}.
					/// 
					/// Tree height
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>auto</code>.
					/// </summary>
					/// <param name="sHeight">New value for property <code>height</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Tree setHeight(sap.ui.core.CSSSize sHeight);

					#endregion

					#region Methods for Property showHeader

					/// <summary>
					/// Gets current value of property {@link #getShowHeader showHeader}.
					/// 
					/// Tree Header is display. If false, the tree will be in a transparent mode
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>showHeader</code></returns>
					public extern virtual bool getShowHeader();

					/// <summary>
					/// Sets a new value for property {@link #getShowHeader showHeader}.
					/// 
					/// Tree Header is display. If false, the tree will be in a transparent mode
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bShowHeader">New value for property <code>showHeader</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Tree setShowHeader(bool bShowHeader);

					#endregion

					#region Methods for Property showHeaderIcons

					/// <summary>
					/// Gets current value of property {@link #getShowHeaderIcons showHeaderIcons}.
					/// 
					/// Show Header icons (e.g. Expand/Collapse all). Only consider if showHeader is true
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>showHeaderIcons</code></returns>
					public extern virtual bool getShowHeaderIcons();

					/// <summary>
					/// Sets a new value for property {@link #getShowHeaderIcons showHeaderIcons}.
					/// 
					/// Show Header icons (e.g. Expand/Collapse all). Only consider if showHeader is true
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bShowHeaderIcons">New value for property <code>showHeaderIcons</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Tree setShowHeaderIcons(bool bShowHeaderIcons);

					#endregion

					#region Methods for Property showHorizontalScrollbar

					/// <summary>
					/// Gets current value of property {@link #getShowHorizontalScrollbar showHorizontalScrollbar}.
					/// 
					/// Display horizontal scrollbar. If false, the overflow content will be hidden
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>showHorizontalScrollbar</code></returns>
					public extern virtual bool getShowHorizontalScrollbar();

					/// <summary>
					/// Sets a new value for property {@link #getShowHorizontalScrollbar showHorizontalScrollbar}.
					/// 
					/// Display horizontal scrollbar. If false, the overflow content will be hidden
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bShowHorizontalScrollbar">New value for property <code>showHorizontalScrollbar</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Tree setShowHorizontalScrollbar(bool bShowHorizontalScrollbar);

					#endregion

					#region Methods for Property minWidth

					/// <summary>
					/// Gets current value of property {@link #getMinWidth minWidth}.
					/// 
					/// Minimal width for the Tree. Can be useful when, for example, the width is specified in percentage, to avoid the tree to become too narrow when container is resize
					/// </summary>
					/// <returns>Value of property <code>minWidth</code></returns>
					public extern virtual sap.ui.core.CSSSize getMinWidth();

					/// <summary>
					/// Sets a new value for property {@link #getMinWidth minWidth}.
					/// 
					/// Minimal width for the Tree. Can be useful when, for example, the width is specified in percentage, to avoid the tree to become too narrow when container is resize
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sMinWidth">New value for property <code>minWidth</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Tree setMinWidth(sap.ui.core.CSSSize sMinWidth);

					#endregion

					#region Methods for Property selectionMode

					/// <summary>
					/// Gets current value of property {@link #getSelectionMode selectionMode}.
					/// 
					/// Selection mode of the Tree.
					/// 
					/// Default value is <code>Legacy</code>.
					/// </summary>
					/// <returns>Value of property <code>selectionMode</code></returns>
					public extern virtual sap.ui.commons.TreeSelectionMode getSelectionMode();

					/// <summary>
					/// Sets a new value for property {@link #getSelectionMode selectionMode}.
					/// 
					/// Selection mode of the Tree.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>Legacy</code>.
					/// </summary>
					/// <param name="sSelectionMode">New value for property <code>selectionMode</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Tree setSelectionMode(sap.ui.commons.TreeSelectionMode sSelectionMode);

					#endregion

					#region Methods for Aggregation nodes

					/// <summary>
					/// Gets content of aggregation {@link #getNodes nodes}.
					/// 
					/// First level nodes
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.commons.TreeNode[] getNodes();

					/// <summary>
					/// Destroys all the nodes in the aggregation {@link #getNodes nodes}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Tree destroyNodes();

					/// <summary>
					/// Inserts a node into the aggregation {@link #getNodes nodes}.
					/// </summary>
					/// <param name="oNode">The node to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the node should be inserted at; for a negative value of <code>iIndex</code>, the node is inserted at position 0; for a value greater than the current size of the aggregation, the node is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Tree insertNode(sap.ui.commons.TreeNode oNode, int iIndex);

					/// <summary>
					/// Adds some node to the aggregation {@link #getNodes nodes}.
					/// </summary>
					/// <param name="oNode">The node to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Tree addNode(sap.ui.commons.TreeNode oNode);

					/// <summary>
					/// Removes a node from the aggregation {@link #getNodes nodes}.
					/// </summary>
					/// <param name="vNode">The node to remove or its index or id</param>
					/// <returns>The removed node or <code>null</code></returns>
					public extern virtual sap.ui.commons.TreeNode removeNode(Union<int, string, sap.ui.commons.TreeNode> vNode);

					/// <summary>
					/// Checks for the provided <code>sap.ui.commons.TreeNode</code> in the aggregation {@link #getNodes nodes}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oNode">The node whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfNode(sap.ui.commons.TreeNode oNode);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getNodes nodes}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.commons.TreeNode[] removeAllNodes();

					/// <summary>
					/// Binds aggregation {@link #getNodes nodes} to model data.
					/// 
					/// See {@link sap.ui.base.ManagedObject#bindAggregation ManagedObject.bindAggregation} for a detailed description of the possible properties of <code>oBindingInfo</code>.
					/// </summary>
					/// <param name="oBindingInfo">The binding information</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Tree bindNodes(object oBindingInfo);

					/// <summary>
					/// Unbinds aggregation {@link #getNodes nodes} from model data.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Tree unbindNodes();

					#endregion

					#region Methods for Event select

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.ui.commons.Tree</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.Tree</code> itself.
					/// 
					/// Event is fired when a tree node is selected.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.Tree</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Tree attachSelect(object oData, sap.ui.commons.Tree.SelectDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.ui.commons.Tree</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.Tree</code> itself.
					/// 
					/// Event is fired when a tree node is selected.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Tree attachSelect(object oData, sap.ui.commons.Tree.SelectDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.ui.commons.Tree</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.Tree</code> itself.
					/// 
					/// Event is fired when a tree node is selected.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Tree attachSelect(sap.ui.commons.Tree.SelectDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.ui.commons.Tree</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.Tree</code> itself.
					/// 
					/// Event is fired when a tree node is selected.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.Tree</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Tree attachSelect(sap.ui.commons.Tree.SelectDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:select select} event of this <code>sap.ui.commons.Tree</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Tree detachSelect(sap.ui.commons.Tree.SelectDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:select select} to attached listeners.
					/// 
					/// Listeners may prevent the default action of this event by using the <code>preventDefault</code>-method on the event object.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Whether or not to prevent the default action</returns>
					public extern virtual bool fireSelect(sap.ui.commons.Tree.SelectInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:select select} to attached listeners.
					/// 
					/// Listeners may prevent the default action of this event by using the <code>preventDefault</code>-method on the event object.
					/// </summary>
					/// <returns>Whether or not to prevent the default action</returns>
					public extern virtual bool fireSelect();

					#endregion

					#region Methods for Event selectionChange

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:selectionChange selectionChange} event of this <code>sap.ui.commons.Tree</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.Tree</code> itself.
					/// 
					/// fired when the selection of the tree has been changed
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.Tree</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Tree attachSelectionChange(object oData, sap.ui.commons.Tree.SelectionChangeDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:selectionChange selectionChange} event of this <code>sap.ui.commons.Tree</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.Tree</code> itself.
					/// 
					/// fired when the selection of the tree has been changed
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Tree attachSelectionChange(object oData, sap.ui.commons.Tree.SelectionChangeDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:selectionChange selectionChange} event of this <code>sap.ui.commons.Tree</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.Tree</code> itself.
					/// 
					/// fired when the selection of the tree has been changed
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Tree attachSelectionChange(sap.ui.commons.Tree.SelectionChangeDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:selectionChange selectionChange} event of this <code>sap.ui.commons.Tree</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.Tree</code> itself.
					/// 
					/// fired when the selection of the tree has been changed
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.Tree</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Tree attachSelectionChange(sap.ui.commons.Tree.SelectionChangeDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:selectionChange selectionChange} event of this <code>sap.ui.commons.Tree</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Tree detachSelectionChange(sap.ui.commons.Tree.SelectionChangeDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:selectionChange selectionChange} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Tree fireSelectionChange(sap.ui.commons.Tree.SelectionChangeInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:selectionChange selectionChange} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Tree fireSelectionChange();

					#endregion

					#region Other methods

					/// <summary>
					/// Collapses all nodes in the tree.
					/// </summary>
					public extern virtual void collapseAll();

					/// <summary>
					/// Expands all nodes in the tree.
					/// </summary>
					public extern virtual void expandAll();

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.Tree with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.Tree with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.Tree with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.commons.Tree.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					/// <summary>
					/// Returns the node with the given context, or null if no such node currently exists.
					/// </summary>
					/// <param name="oContext">The context of the node to be retrieved</param>
					/// <returns>The found tree node</returns>
					public extern virtual sap.ui.commons.TreeNode getNodeByContext(sap.ui.model.Context oContext);

					#endregion

					#endregion

				}
			}
		}
	}
}
