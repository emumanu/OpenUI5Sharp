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
				/// Tree node element
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.TreeNode")]
				[Obsolete("Deprecated since 1.38. replaced by {@link sap.m.Tree}")]
				public partial class TreeNode : sap.ui.core.Element
				{
					#region Settings

					/// <summary>
					/// Settings class to create the object
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class Settings : sap.ui.core.Element.Settings
					{
						/// <summary>
						/// Node text
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> text;

						/// <summary>
						/// Node is expanded
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> expanded;

						/// <summary>
						/// Should the node has an expander.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> hasExpander;

						/// <summary>
						/// Icon to display in front of the node
						/// </summary>
						public Union<sap.ui.core.URI, string, sap.ui.@base.ManagedObject.BindPropertyInfo> icon;

						/// <summary>
						/// Node is selected
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> isSelected;

						/// <summary>
						/// The node is selectable. If true, clicking on the node text triggers "selected" event
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> selectable;

						/// <summary>
						/// Subnodes for the current node
						/// </summary>
						public Union<sap.ui.commons.TreeNode[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> nodes;

						/// <summary>
						/// Association to controls / ids which describe this control (see WAI-ARIA attribute aria-describedby).
						/// </summary>
						public Union<sap.ui.core.Control, sap.ui.core.ID[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> ariaDescribedBy;

						/// <summary>
						/// Association to controls / ids which label this control (see WAI-ARIA attribute aria-labelledby).
						/// </summary>
						public Union<sap.ui.core.Control, sap.ui.core.ID[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> ariaLabelledBy;

						/// <summary>
						/// Node state has changed.
						/// </summary>
						public sap.ui.commons.TreeNode.ToggleOpenStateDelegate toggleOpenState;

						/// <summary>
						/// Node is selected
						/// </summary>
						public sap.ui.@base.EventDelegate selected;

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
						/// Node has been opened if true
						/// </summary>
						public bool opened;

					}

					#endregion

					#region Delegates

					public delegate void ToggleOpenStateDelegate(sap.ui.@base.Event<sap.ui.commons.TreeNode.ToggleOpenStateInfo> oEvent, object oData);

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new TreeNode.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern TreeNode(string sId, sap.ui.commons.TreeNode.Settings mSettings);

					/// <summary>
					/// Constructor for a new TreeNode.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern TreeNode(string sId);

					/// <summary>
					/// Constructor for a new TreeNode.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern TreeNode();

					/// <summary>
					/// Constructor for a new TreeNode.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern TreeNode(sap.ui.commons.TreeNode.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property text

					/// <summary>
					/// Gets current value of property {@link #getText text}.
					/// 
					/// Node text
					/// </summary>
					/// <returns>Value of property <code>text</code></returns>
					public extern virtual string getText();

					/// <summary>
					/// Sets a new value for property {@link #getText text}.
					/// 
					/// Node text
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sText">New value for property <code>text</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TreeNode setText(string sText);

					#endregion

					#region Methods for Property expanded

					/// <summary>
					/// Gets current value of property {@link #getExpanded expanded}.
					/// 
					/// Node is expanded
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>expanded</code></returns>
					public extern virtual bool getExpanded();

					/// <summary>
					/// Sets a new value for property {@link #getExpanded expanded}.
					/// 
					/// Node is expanded
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bExpanded">New value for property <code>expanded</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TreeNode setExpanded(bool bExpanded);

					#endregion

					#region Methods for Property hasExpander

					/// <summary>
					/// Gets current value of property {@link #getHasExpander hasExpander}.
					/// 
					/// Should the node has an expander.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>hasExpander</code></returns>
					public extern virtual bool getHasExpander();

					/// <summary>
					/// Sets a new value for property {@link #getHasExpander hasExpander}.
					/// 
					/// Should the node has an expander.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bHasExpander">New value for property <code>hasExpander</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TreeNode setHasExpander(bool bHasExpander);

					#endregion

					#region Methods for Property icon

					/// <summary>
					/// Gets current value of property {@link #getIcon icon}.
					/// 
					/// Icon to display in front of the node
					/// </summary>
					/// <returns>Value of property <code>icon</code></returns>
					public extern virtual sap.ui.core.URI getIcon();

					/// <summary>
					/// Sets a new value for property {@link #getIcon icon}.
					/// 
					/// Icon to display in front of the node
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sIcon">New value for property <code>icon</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TreeNode setIcon(sap.ui.core.URI sIcon);

					#endregion

					#region Methods for Property isSelected

					/// <summary>
					/// Gets current value of property {@link #getIsSelected isSelected}.
					/// 
					/// Node is selected
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>isSelected</code></returns>
					public extern virtual bool getIsSelected();

					/// <summary>
					/// Redefinition of Setter for property <code>isSelected</code> for validation purpose
					/// 
					/// Default value is empty/<code>undefined</code>
					/// </summary>
					/// <param name="bIsSelected">new value for property <code>isSelected</code></param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.commons.TreeNode setIsSelected(bool bIsSelected);

					#endregion

					#region Methods for Property selectable

					/// <summary>
					/// Gets current value of property {@link #getSelectable selectable}.
					/// 
					/// The node is selectable. If true, clicking on the node text triggers "selected" event
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>selectable</code></returns>
					public extern virtual bool getSelectable();

					/// <summary>
					/// Redefinition of Setter for property <code>selectable</code> for validation purpose.
					/// 
					/// Default value is <code>true</code>
					/// </summary>
					/// <param name="bSelectable">new value for property <code>selectable</code></param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.commons.TreeNode setSelectable(bool bSelectable);

					#endregion

					#region Methods for Aggregation nodes

					/// <summary>
					/// Gets content of aggregation {@link #getNodes nodes}.
					/// 
					/// Subnodes for the current node
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.commons.TreeNode[] getNodes();

					/// <summary>
					/// Destroys all the nodes in the aggregation {@link #getNodes nodes}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TreeNode destroyNodes();

					/// <summary>
					/// Inserts a node into the aggregation {@link #getNodes nodes}.
					/// </summary>
					/// <param name="oNode">The node to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the node should be inserted at; for a negative value of <code>iIndex</code>, the node is inserted at position 0; for a value greater than the current size of the aggregation, the node is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TreeNode insertNode(sap.ui.commons.TreeNode oNode, int iIndex);

					/// <summary>
					/// Adds some node to the aggregation {@link #getNodes nodes}.
					/// </summary>
					/// <param name="oNode">The node to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TreeNode addNode(sap.ui.commons.TreeNode oNode);

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

					#endregion

					#region Methods for Association selectedForNodes

					#endregion

					#region Methods for Association ariaDescribedBy

					/// <summary>
					/// Returns array of IDs of the elements which are the current targets of the association {@link #getAriaDescribedBy ariaDescribedBy}.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.ID[] getAriaDescribedBy();

					/// <summary>
					/// Adds some ariaDescribedBy into the association {@link #getAriaDescribedBy ariaDescribedBy}.
					/// </summary>
					/// <param name="vAriaDescribedBy">The ariaDescribedBy to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TreeNode addAriaDescribedBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaDescribedBy);

					/// <summary>
					/// Removes an ariaDescribedBy from the association named {@link #getAriaDescribedBy ariaDescribedBy}.
					/// </summary>
					/// <param name="vAriaDescribedBy">The ariaDescribedBy to be removed or its index or ID</param>
					/// <returns>The removed ariaDescribedBy or <code>null</code></returns>
					public extern virtual sap.ui.core.ID removeAriaDescribedBy(Union<int, sap.ui.core.ID, sap.ui.core.Control> vAriaDescribedBy);

					/// <summary>
					/// Removes all the controls in the association named {@link #getAriaDescribedBy ariaDescribedBy}.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.core.ID[] removeAllAriaDescribedBy();

					#endregion

					#region Methods for Association ariaLabelledBy

					/// <summary>
					/// Returns array of IDs of the elements which are the current targets of the association {@link #getAriaLabelledBy ariaLabelledBy}.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.ID[] getAriaLabelledBy();

					/// <summary>
					/// Adds some ariaLabelledBy into the association {@link #getAriaLabelledBy ariaLabelledBy}.
					/// </summary>
					/// <param name="vAriaLabelledBy">The ariaLabelledBy to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TreeNode addAriaLabelledBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaLabelledBy);

					/// <summary>
					/// Removes an ariaLabelledBy from the association named {@link #getAriaLabelledBy ariaLabelledBy}.
					/// </summary>
					/// <param name="vAriaLabelledBy">The ariaLabelledBy to be removed or its index or ID</param>
					/// <returns>The removed ariaLabelledBy or <code>null</code></returns>
					public extern virtual sap.ui.core.ID removeAriaLabelledBy(Union<int, sap.ui.core.ID, sap.ui.core.Control> vAriaLabelledBy);

					/// <summary>
					/// Removes all the controls in the association named {@link #getAriaLabelledBy ariaLabelledBy}.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.core.ID[] removeAllAriaLabelledBy();

					#endregion

					#region Methods for Event toggleOpenState

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:toggleOpenState toggleOpenState} event of this <code>sap.ui.commons.TreeNode</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.TreeNode</code> itself.
					/// 
					/// Node state has changed.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.TreeNode</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TreeNode attachToggleOpenState(object oData, sap.ui.commons.TreeNode.ToggleOpenStateDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:toggleOpenState toggleOpenState} event of this <code>sap.ui.commons.TreeNode</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.TreeNode</code> itself.
					/// 
					/// Node state has changed.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TreeNode attachToggleOpenState(object oData, sap.ui.commons.TreeNode.ToggleOpenStateDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:toggleOpenState toggleOpenState} event of this <code>sap.ui.commons.TreeNode</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.TreeNode</code> itself.
					/// 
					/// Node state has changed.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TreeNode attachToggleOpenState(sap.ui.commons.TreeNode.ToggleOpenStateDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:toggleOpenState toggleOpenState} event of this <code>sap.ui.commons.TreeNode</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.TreeNode</code> itself.
					/// 
					/// Node state has changed.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.TreeNode</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TreeNode attachToggleOpenState(sap.ui.commons.TreeNode.ToggleOpenStateDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:toggleOpenState toggleOpenState} event of this <code>sap.ui.commons.TreeNode</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TreeNode detachToggleOpenState(sap.ui.commons.TreeNode.ToggleOpenStateDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:toggleOpenState toggleOpenState} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TreeNode fireToggleOpenState(sap.ui.commons.TreeNode.ToggleOpenStateInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:toggleOpenState toggleOpenState} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TreeNode fireToggleOpenState();

					#endregion

					#region Methods for Event selected

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:selected selected} event of this <code>sap.ui.commons.TreeNode</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.TreeNode</code> itself.
					/// 
					/// Node is selected
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.TreeNode</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TreeNode attachSelected(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:selected selected} event of this <code>sap.ui.commons.TreeNode</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.TreeNode</code> itself.
					/// 
					/// Node is selected
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TreeNode attachSelected(object oData, sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:selected selected} event of this <code>sap.ui.commons.TreeNode</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.TreeNode</code> itself.
					/// 
					/// Node is selected
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TreeNode attachSelected(sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:selected selected} event of this <code>sap.ui.commons.TreeNode</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.TreeNode</code> itself.
					/// 
					/// Node is selected
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.TreeNode</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TreeNode attachSelected(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:selected selected} event of this <code>sap.ui.commons.TreeNode</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TreeNode detachSelected(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:selected selected} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TreeNode fireSelected(object mParameters);

					/// <summary>
					/// Fires event {@link #event:selected selected} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TreeNode fireSelected();

					#endregion

					#region Other methods

					/// <summary>
					/// Collapses the node.
					/// </summary>
					/// <param name="bCollapseChildren">Propagates collapse to node's children</param>
					/// <param name="bDisableCollapseFinishedHandler">Disables the collapse finished handler</param>
					public extern virtual void collapse(bool bCollapseChildren, bool bDisableCollapseFinishedHandler);

					/// <summary>
					/// Expands the node.
					/// </summary>
					/// <param name="bExpandChildren">Propagates expand to node's children</param>
					/// <param name="bDisableExpandFinishedHandler">Disables the expand finished handler</param>
					public extern virtual void expand(bool bExpandChildren, bool bDisableExpandFinishedHandler);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.TreeNode with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.TreeNode with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.TreeNode with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.commons.TreeNode.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					[Name("getMetadata")]
					public extern static sap.ui.@base.Metadata getMetadataStatic();

					/// <summary>
					/// Select the node, and if any, deselects the previously selected node
					/// </summary>
					/// <param name="bSuppressEvent"></param>
					public extern virtual void select(bool bSuppressEvent);

					#endregion

					#endregion

				}
			}
		}
	}
}
