using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public partial class sap
	{
		public static partial class ui
		{
			public static partial class core
			{
				/// <summary>
				/// An area in a page that hosts a tree of UI elements.
				/// 
				/// Provides means for event-handling, rerendering, etc.
				/// 
				/// Special aggregation "dependents" is connected to the lifecycle management and databinding, but not rendered automatically and can be used for popups or other dependent controls. This allows definition of popup controls in declarative views and enables propagation of model and context information to them.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.core.UIArea")]
				public partial class UIArea : sap.ui.@base.ManagedObject
				{
					#region Settings

					/// <summary>
					/// Settings class to create the object
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class Settings : sap.ui.@base.ManagedObject.Settings
					{
						/// <summary>
						/// Content that is displayed in the UIArea.
						/// </summary>
						public Union<sap.ui.core.Control[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> content;

						/// <summary>
						/// Dependent objects whose lifecycle is bound to the UIarea but which are not automatically rendered by the UIArea.
						/// </summary>
						public Union<sap.ui.core.Control[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> dependents;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="oCore">internal API of the <core>Core</code> that manages this UIArea</param>
					/// <param name="oRootNode">reference to the Dom Node that should be 'hosting' the UI Area.</param>
					public extern UIArea(sap.ui.core.Core oCore, object oRootNode);

					/// <summary>
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="oCore">internal API of the <core>Core</code> that manages this UIArea</param>
					public extern UIArea(sap.ui.core.Core oCore);

					#endregion

					#region Methods

					#region Methods for Aggregation content

					/// <summary>
					/// Gets content of aggregation {@link #getContent content}.
					/// 
					/// Content that is displayed in the UIArea.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.Control[] getContent();

					/// <summary>
					/// Destroys all the content in the aggregation {@link #getContent content}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.UIArea destroyContent();

					/// <summary>
					/// Inserts a content into the aggregation {@link #getContent content}.
					/// </summary>
					/// <param name="oContent">The content to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the content should be inserted at; for a negative value of <code>iIndex</code>, the content is inserted at position 0; for a value greater than the current size of the aggregation, the content is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.UIArea insertContent(sap.ui.core.Control oContent, int iIndex);

					/// <summary>
					/// Adds some content to the aggregation {@link #getContent content}.
					/// </summary>
					/// <param name="oContent">The content to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.UIArea addContent(sap.ui.core.Control oContent);

					/// <summary>
					/// Removes a content from the aggregation {@link #getContent content}.
					/// </summary>
					/// <param name="vContent">The content to remove or its index or id</param>
					/// <returns>The removed content or <code>null</code></returns>
					public extern virtual sap.ui.core.Control removeContent(Union<int, string, sap.ui.core.Control> vContent);

					/// <summary>
					/// Checks for the provided <code>sap.ui.core.Control</code> in the aggregation {@link #getContent content}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oContent">The content whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfContent(sap.ui.core.Control oContent);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getContent content}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.core.Control[] removeAllContent();

					#endregion

					#region Methods for Aggregation dependents

					/// <summary>
					/// Gets content of aggregation {@link #getDependents dependents}.
					/// 
					/// Dependent objects whose lifecycle is bound to the UIarea but which are not automatically rendered by the UIArea.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.Control[] getDependents();

					/// <summary>
					/// Destroys all the dependents in the aggregation {@link #getDependents dependents}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.UIArea destroyDependents();

					/// <summary>
					/// Inserts a dependent into the aggregation {@link #getDependents dependents}.
					/// </summary>
					/// <param name="oDependent">The dependent to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the dependent should be inserted at; for a negative value of <code>iIndex</code>, the dependent is inserted at position 0; for a value greater than the current size of the aggregation, the dependent is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.UIArea insertDependent(sap.ui.core.Control oDependent, int iIndex);

					/// <summary>
					/// Adds some dependent to the aggregation {@link #getDependents dependents}.
					/// </summary>
					/// <param name="oDependent">The dependent to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.UIArea addDependent(sap.ui.core.Control oDependent);

					/// <summary>
					/// Removes a dependent from the aggregation {@link #getDependents dependents}.
					/// </summary>
					/// <param name="vDependent">The dependent to remove or its index or id</param>
					/// <returns>The removed dependent or <code>null</code></returns>
					public extern virtual sap.ui.core.Control removeDependent(Union<int, string, sap.ui.core.Control> vDependent);

					/// <summary>
					/// Checks for the provided <code>sap.ui.core.Control</code> in the aggregation {@link #getDependents dependents}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oDependent">The dependent whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfDependent(sap.ui.core.Control oDependent);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getDependents dependents}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.core.Control[] removeAllDependents();

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.UIArea with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.ManagedObject.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.UIArea with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.ManagedObject.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.UIArea with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.ManagedObject.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Provide getBindingContext, as UIArea can be parent of an element.
					/// </summary>
					/// <returns>Always returns null.</returns>
					public extern virtual object getBindingContext();

					/// <summary>
					/// Returns the Core's event provider as new eventing parent to enable control event bubbling to the core to ensure compatibility with the core validation events.
					/// </summary>
					/// <returns>the parent event provider</returns>
					public extern override sap.ui.@base.EventProvider getEventingParent();

					/// <summary>
					/// Returns this <code>UIArea</code>'s id (as determined from provided RootNode).
					/// </summary>
					/// <returns>id of this UIArea</returns>
					public extern virtual string getId();

					/// <summary>
					/// Returns a metadata object for class sap.ui.core.UIArea.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					/// <summary>
					/// Returns the content control of this <code>UIArea</code> at the specified index. If no index is given the first content control is returned.
					/// </summary>
					/// <param name="idx">index of the control in the content of this <code>UIArea</code></param>
					/// <returns>the content control of this <code>UIArea</code> at the specified index.</returns>
					[Obsolete("Deprecated since 1.1. use function {@link #getContent} instead")]
					public extern virtual sap.ui.core.Control getRootControl(int idx);

					/// <summary>
					/// Returns the Root Node hosting this instance of <code>UIArea</code>.
					/// </summary>
					/// <returns>the Root Node hosting this instance of <code>UIArea</code>.</returns>
					public extern virtual dom.HTMLElement getRootNode();

					/// <summary>
					/// Returns this UI area. Needed to stop recursive calls from an element to its parent.
					/// </summary>
					/// <returns>this</returns>
					public extern virtual sap.ui.core.UIArea getUIArea();

					/// <summary>
					/// Will be used as end-point for invalidate-bubbling from controls up their hierarchy.<br/> Triggers re-rendering of the UIAreas content.
					/// </summary>
					public extern override void invalidate();

					/// <summary>
					/// Checks whether the control is still valid (is in the DOM)
					/// </summary>
					/// <returns>True if the control is still in the active DOM</returns>
					public extern virtual bool isActive();

					/// <summary>
					/// Returns whether rerendering is currently suppressed on this UIArea
					/// </summary>
					/// <returns>boolean</returns>
					public extern override void isInvalidateSuppressed();

					/// <summary>
					/// Returns the locked state of the <code>sap.ui.core.UIArea</code>
					/// </summary>
					/// <returns>locked state</returns>
					public extern virtual bool isLocked();

					/// <summary>
					/// Locks this instance of UIArea.
					/// 
					/// Rerendering and eventing will not be active as long as no {@link #unlock} is called.
					/// </summary>
					public extern virtual void @lock();

					/// <summary>
					/// Sets the root control to be displayed in this UIArea.
					/// 
					/// First, all old content controls (if any) will be detached from this UIArea (e.g. their parent relationship to this UIArea will be cut off). Then the parent relationship for the new content control (if not empty) will be set to this UIArea and finally, the UIArea will be marked for re-rendering.
					/// 
					/// The real re-rendering happens whenever the re-rendering is called. Either implicitly at the end of any control event or by calling sap.ui.getCore().applyChanges().
					/// </summary>
					/// <param name="oRootControl">the Control that should be the Root for this <code>UIArea</code>.</param>
					[Obsolete("Deprecated since 1.1. use {@link #removeAllContent} and {@link #addContent} instead")]
					public extern virtual void setRootControl(Union<sap.ui.@base.Interface, sap.ui.core.Control> oRootControl);

					/// <summary>
					/// Allows setting the Root Node hosting this instance of <code>UIArea</code>.<br/> The Dom Ref must have an Id that will be used as Id for this instance of <code>UIArea</code>.
					/// </summary>
					/// <param name="oRootNode">the hosting Dom Ref for this instance of <code>UIArea</code>.</param>
					public extern virtual void setRootNode(object oRootNode);

					/// <summary>
					/// Un-Locks this instance of UIArea.
					/// 
					/// Rerendering and eventing will now be enabled again.
					/// </summary>
					public extern virtual void unlock();

					#endregion

					#endregion

				}
			}
		}
	}
}
