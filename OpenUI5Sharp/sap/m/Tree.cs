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
			/// The <code>Tree</code> control provides a tree structure for displaying data in a hierarchy. <b>Note:</b> Growing feature is not supported by <code>Tree</code>.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.Tree")]
			public partial class Tree : sap.m.ListBase
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
					/// Fired when an item has been expanded or collapsed by user interaction.
					/// </summary>
					public sap.m.Tree.ToggleOpenStateDelegate toggleOpenState;

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
					/// Index of the expanded/collapsed item
					/// </summary>
					public int itemIndex;

					/// <summary>
					/// Binding context of the item
					/// </summary>
					public object itemContext;

					/// <summary>
					/// Flag that indicates whether the item has been expanded or collapsed
					/// </summary>
					public bool expanded;

				}

				#endregion

				#region Delegates

				public delegate void ToggleOpenStateDelegate(sap.ui.@base.Event<sap.m.Tree.ToggleOpenStateInfo> oEvent, object oData);

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new Tree.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no id is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern Tree(string sId, sap.m.Tree.Settings mSettings);

				/// <summary>
				/// Constructor for a new Tree.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no id is given</param>
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
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern Tree(sap.m.Tree.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Event toggleOpenState

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:toggleOpenState toggleOpenState} event of this <code>sap.m.Tree</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Tree</code> itself.
				/// 
				/// Fired when an item has been expanded or collapsed by user interaction.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.Tree</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Tree attachToggleOpenState(object oData, sap.m.Tree.ToggleOpenStateDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:toggleOpenState toggleOpenState} event of this <code>sap.m.Tree</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Tree</code> itself.
				/// 
				/// Fired when an item has been expanded or collapsed by user interaction.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Tree attachToggleOpenState(object oData, sap.m.Tree.ToggleOpenStateDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:toggleOpenState toggleOpenState} event of this <code>sap.m.Tree</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Tree</code> itself.
				/// 
				/// Fired when an item has been expanded or collapsed by user interaction.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Tree attachToggleOpenState(sap.m.Tree.ToggleOpenStateDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:toggleOpenState toggleOpenState} event of this <code>sap.m.Tree</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Tree</code> itself.
				/// 
				/// Fired when an item has been expanded or collapsed by user interaction.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.Tree</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Tree attachToggleOpenState(sap.m.Tree.ToggleOpenStateDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:toggleOpenState toggleOpenState} event of this <code>sap.m.Tree</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Tree detachToggleOpenState(sap.m.Tree.ToggleOpenStateDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:toggleOpenState toggleOpenState} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Tree fireToggleOpenState(sap.m.Tree.ToggleOpenStateInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:toggleOpenState toggleOpenState} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Tree fireToggleOpenState();

				#endregion

				#region Other methods

				/// <summary>
				/// Collapses one or multiple items.
				/// </summary>
				/// <param name="vParam">The index or indices of the tree items to be collapsed</param>
				/// <returns>A reference to the Tree control</returns>
				public extern virtual sap.m.Tree collapse(Union<int, int[]> vParam);

				/// <summary>
				/// Collapses all nodes.
				/// </summary>
				/// <returns>A reference to the Tree control</returns>
				public extern virtual sap.m.Tree collapseAll();

				/// <summary>
				/// Expands one or multiple items.
				/// </summary>
				/// <param name="vParam">The index or indices of the item to be expanded</param>
				/// <returns>A reference to the Tree control</returns>
				public extern virtual sap.m.Tree expand(Union<int, int[]> vParam);

				/// <summary>
				/// Defines the level to which the tree is expanded. The function can be used to define the initial expanding state. An alternative way to define the initial expanding state is to set the parameter <code>numberOfExpandedLevels</code> of the binding.
				/// 
				/// Example: <pre>
				///   oTree.bindItems({
				///      path: "...",
				///      parameters: {
				///         numberOfExpandedLevels: 1
				///      }
				///   });
				/// </pre>
				/// </summary>
				/// <param name="iLevel">The level to which the data is expanded</param>
				/// <returns>A reference to the Tree control</returns>
				public extern virtual sap.m.Tree expandToLevel(int iLevel);

				/// <summary>
				/// Creates a new subclass of class sap.m.Tree with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.ListBase.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.Tree with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.ListBase.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.Tree with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.ListBase.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.Tree.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				[Name("getMetadata")]
				public extern static sap.ui.@base.Metadata getMetadataStatic();

				/// <summary>
				/// The <code>growing</code> property is not supported for control <code>Tree</code>.
				/// </summary>
				[Obsolete("Deprecated since 1.46.")]
				public extern virtual void setGrowing();

				/// <summary>
				/// The <code>growingDirection</code> property is not supported for control <code>Tree</code>.
				/// </summary>
				[Obsolete("Deprecated since 1.46.")]
				public extern virtual void setGrowingDirection();

				/// <summary>
				/// The <code>growingScrollToLoad</code> property is not supported for control <code>Tree</code>.
				/// </summary>
				[Obsolete("Deprecated since 1.46.")]
				public extern virtual void setGrowingScrollToLoad();

				/// <summary>
				/// The <code>growingThreshold</code> property is not supported for control <code>Tree</code>.
				/// </summary>
				[Obsolete("Deprecated since 1.46.")]
				public extern virtual void setGrowingThreshold();

				/// <summary>
				/// The <code>growingTriggerText</code> property is not supported for control <code>Tree</code>.
				/// </summary>
				[Obsolete("Deprecated since 1.46.")]
				public extern virtual void setGrowingTriggerText();

				#endregion

				#endregion

			}
		}
	}
}
