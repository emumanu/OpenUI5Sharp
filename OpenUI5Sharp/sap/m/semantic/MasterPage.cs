using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace OpenUI5Sharp
{
	public static partial class sap
	{
		public static partial class m
		{
			public static partial class semantic
			{
				/// <summary>
				/// A MasterPage is a {@link sap.m.semantic.SemanticPage} that supports semantic content of the following types:
				/// 
				/// <ul> <li>{@link sap.m.semantic.AddAction}</li> <li>{@link sap.m.semantic.MainAction}</li> <li>{@link sap.m.semantic.PositiveAction}</li> <li>{@link sap.m.semantic.NegativeAction}</li> <li>{@link sap.m.semantic.ForwardAction}</li> <li>{@link sap.m.semantic.EditAction}</li> <li>{@link sap.m.semantic.SaveAction}</li> <li>{@link sap.m.semantic.DeleteAction}</li> <li>{@link sap.m.semantic.CancelAction}</li> <li>{@link sap.m.semantic.MultiSelectAction}</li> <li>{@link sap.m.semantic.FlagAction}</li> <li>{@link sap.m.semantic.FavoriteAction}</li> <li>{@link sap.m.semantic.SortAction}</li> <li>{@link sap.m.semantic.SortSelect}</li> <li>{@link sap.m.semantic.FilterAction}</li> <li>{@link sap.m.semantic.FilterSelect}</li> <li>{@link sap.m.semantic.GroupAction}</li> <li>{@link sap.m.semantic.GroupSelect}</li> <li>{@link sap.m.semantic.MessagesIndicator}</li> </ul>
				/// </summary>
				[External]
				[Namespace(false)]
				public partial class MasterPage : sap.m.semantic.SemanticPage
				{
					#region Settings

					/// <summary>
					/// Settings class to create the object
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class Settings : sap.m.semantic.SemanticPage.Settings
					{
						/// <summary>
						/// Add action
						/// </summary>
						public Union<sap.m.semantic.AddAction, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> addAction;

						/// <summary>
						/// Main action
						/// </summary>
						public Union<sap.m.semantic.MainAction, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> mainAction;

						/// <summary>
						/// Positive action
						/// </summary>
						public Union<sap.m.semantic.PositiveAction, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> positiveAction;

						/// <summary>
						/// Negative action
						/// </summary>
						public Union<sap.m.semantic.NegativeAction, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> negativeAction;

						/// <summary>
						/// MultiSelect action
						/// </summary>
						public Union<sap.m.semantic.MultiSelectAction, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> multiSelectAction;

						/// <summary>
						/// Forward action
						/// </summary>
						public Union<sap.m.semantic.ForwardAction, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> forwardAction;

						/// <summary>
						/// Edit action
						/// </summary>
						public Union<sap.m.semantic.EditAction, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> editAction;

						/// <summary>
						/// Save action
						/// </summary>
						public Union<sap.m.semantic.SaveAction, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> saveAction;

						/// <summary>
						/// Delete action
						/// </summary>
						public Union<sap.m.semantic.DeleteAction, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> deleteAction;

						/// <summary>
						/// Cancel action
						/// </summary>
						public Union<sap.m.semantic.CancelAction, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> cancelAction;

						/// <summary>
						/// Sort action
						/// </summary>
						public Union<sap.m.semantic.ISort, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> sort;

						/// <summary>
						/// Filter action
						/// </summary>
						public Union<sap.m.semantic.IFilter, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> filter;

						/// <summary>
						/// Group action
						/// </summary>
						public Union<sap.m.semantic.IGroup, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> group;

						/// <summary>
						/// MessagesIndicator
						/// </summary>
						public Union<sap.m.semantic.MessagesIndicator, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> messagesIndicator;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new MasterPage
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern MasterPage(string sId, sap.m.semantic.MasterPage.Settings mSettings);

					/// <summary>
					/// Constructor for a new MasterPage
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					public extern MasterPage(string sId);

					/// <summary>
					/// Constructor for a new MasterPage
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern MasterPage();

					/// <summary>
					/// Constructor for a new MasterPage
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern MasterPage(sap.m.semantic.MasterPage.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Aggregation addAction

					/// <summary>
					/// Gets content of aggregation {@link #getAddAction addAction}.
					/// 
					/// Add action
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.m.semantic.AddAction getAddAction();

					/// <summary>
					/// Destroys the addAction in the aggregation {@link #getAddAction addAction}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.MasterPage destroyAddAction();

					/// <summary>
					/// Sets the aggregated {@link #getAddAction addAction}.
					/// </summary>
					/// <param name="oAddAction">The addAction to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.MasterPage setAddAction(sap.m.semantic.AddAction oAddAction);

					#endregion

					#region Methods for Aggregation mainAction

					/// <summary>
					/// Gets content of aggregation {@link #getMainAction mainAction}.
					/// 
					/// Main action
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.m.semantic.MainAction getMainAction();

					/// <summary>
					/// Destroys the mainAction in the aggregation {@link #getMainAction mainAction}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.MasterPage destroyMainAction();

					/// <summary>
					/// Sets the aggregated {@link #getMainAction mainAction}.
					/// </summary>
					/// <param name="oMainAction">The mainAction to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.MasterPage setMainAction(sap.m.semantic.MainAction oMainAction);

					#endregion

					#region Methods for Aggregation positiveAction

					/// <summary>
					/// Gets content of aggregation {@link #getPositiveAction positiveAction}.
					/// 
					/// Positive action
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.m.semantic.PositiveAction getPositiveAction();

					/// <summary>
					/// Destroys the positiveAction in the aggregation {@link #getPositiveAction positiveAction}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.MasterPage destroyPositiveAction();

					/// <summary>
					/// Sets the aggregated {@link #getPositiveAction positiveAction}.
					/// </summary>
					/// <param name="oPositiveAction">The positiveAction to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.MasterPage setPositiveAction(sap.m.semantic.PositiveAction oPositiveAction);

					#endregion

					#region Methods for Aggregation negativeAction

					/// <summary>
					/// Gets content of aggregation {@link #getNegativeAction negativeAction}.
					/// 
					/// Negative action
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.m.semantic.NegativeAction getNegativeAction();

					/// <summary>
					/// Destroys the negativeAction in the aggregation {@link #getNegativeAction negativeAction}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.MasterPage destroyNegativeAction();

					/// <summary>
					/// Sets the aggregated {@link #getNegativeAction negativeAction}.
					/// </summary>
					/// <param name="oNegativeAction">The negativeAction to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.MasterPage setNegativeAction(sap.m.semantic.NegativeAction oNegativeAction);

					#endregion

					#region Methods for Aggregation multiSelectAction

					/// <summary>
					/// Gets content of aggregation {@link #getMultiSelectAction multiSelectAction}.
					/// 
					/// MultiSelect action
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.m.semantic.MultiSelectAction getMultiSelectAction();

					/// <summary>
					/// Destroys the multiSelectAction in the aggregation {@link #getMultiSelectAction multiSelectAction}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.MasterPage destroyMultiSelectAction();

					/// <summary>
					/// Sets the aggregated {@link #getMultiSelectAction multiSelectAction}.
					/// </summary>
					/// <param name="oMultiSelectAction">The multiSelectAction to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.MasterPage setMultiSelectAction(sap.m.semantic.MultiSelectAction oMultiSelectAction);

					#endregion

					#region Methods for Aggregation forwardAction

					/// <summary>
					/// Gets content of aggregation {@link #getForwardAction forwardAction}.
					/// 
					/// Forward action
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.m.semantic.ForwardAction getForwardAction();

					/// <summary>
					/// Destroys the forwardAction in the aggregation {@link #getForwardAction forwardAction}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.MasterPage destroyForwardAction();

					/// <summary>
					/// Sets the aggregated {@link #getForwardAction forwardAction}.
					/// </summary>
					/// <param name="oForwardAction">The forwardAction to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.MasterPage setForwardAction(sap.m.semantic.ForwardAction oForwardAction);

					#endregion

					#region Methods for Aggregation editAction

					/// <summary>
					/// Gets content of aggregation {@link #getEditAction editAction}.
					/// 
					/// Edit action
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.m.semantic.EditAction getEditAction();

					/// <summary>
					/// Destroys the editAction in the aggregation {@link #getEditAction editAction}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.MasterPage destroyEditAction();

					/// <summary>
					/// Sets the aggregated {@link #getEditAction editAction}.
					/// </summary>
					/// <param name="oEditAction">The editAction to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.MasterPage setEditAction(sap.m.semantic.EditAction oEditAction);

					#endregion

					#region Methods for Aggregation saveAction

					/// <summary>
					/// Gets content of aggregation {@link #getSaveAction saveAction}.
					/// 
					/// Save action
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.m.semantic.SaveAction getSaveAction();

					/// <summary>
					/// Destroys the saveAction in the aggregation {@link #getSaveAction saveAction}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.MasterPage destroySaveAction();

					/// <summary>
					/// Sets the aggregated {@link #getSaveAction saveAction}.
					/// </summary>
					/// <param name="oSaveAction">The saveAction to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.MasterPage setSaveAction(sap.m.semantic.SaveAction oSaveAction);

					#endregion

					#region Methods for Aggregation deleteAction

					/// <summary>
					/// Gets content of aggregation {@link #getDeleteAction deleteAction}.
					/// 
					/// Delete action
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.m.semantic.DeleteAction getDeleteAction();

					/// <summary>
					/// Destroys the deleteAction in the aggregation {@link #getDeleteAction deleteAction}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.MasterPage destroyDeleteAction();

					/// <summary>
					/// Sets the aggregated {@link #getDeleteAction deleteAction}.
					/// </summary>
					/// <param name="oDeleteAction">The deleteAction to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.MasterPage setDeleteAction(sap.m.semantic.DeleteAction oDeleteAction);

					#endregion

					#region Methods for Aggregation cancelAction

					/// <summary>
					/// Gets content of aggregation {@link #getCancelAction cancelAction}.
					/// 
					/// Cancel action
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.m.semantic.CancelAction getCancelAction();

					/// <summary>
					/// Destroys the cancelAction in the aggregation {@link #getCancelAction cancelAction}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.MasterPage destroyCancelAction();

					/// <summary>
					/// Sets the aggregated {@link #getCancelAction cancelAction}.
					/// </summary>
					/// <param name="oCancelAction">The cancelAction to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.MasterPage setCancelAction(sap.m.semantic.CancelAction oCancelAction);

					#endregion

					#region Methods for Aggregation sort

					/// <summary>
					/// Gets content of aggregation {@link #getSort sort}.
					/// 
					/// Sort action
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.m.semantic.ISort getSort();

					/// <summary>
					/// Destroys the sort in the aggregation {@link #getSort sort}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.MasterPage destroySort();

					/// <summary>
					/// Sets the aggregated {@link #getSort sort}.
					/// </summary>
					/// <param name="oSort">The sort to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.MasterPage setSort(sap.m.semantic.ISort oSort);

					#endregion

					#region Methods for Aggregation filter

					/// <summary>
					/// Gets content of aggregation {@link #getFilter filter}.
					/// 
					/// Filter action
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.m.semantic.IFilter getFilter();

					/// <summary>
					/// Destroys the filter in the aggregation {@link #getFilter filter}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.MasterPage destroyFilter();

					/// <summary>
					/// Sets the aggregated {@link #getFilter filter}.
					/// </summary>
					/// <param name="oFilter">The filter to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.MasterPage setFilter(sap.m.semantic.IFilter oFilter);

					#endregion

					#region Methods for Aggregation group

					/// <summary>
					/// Gets content of aggregation {@link #getGroup group}.
					/// 
					/// Group action
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.m.semantic.IGroup getGroup();

					/// <summary>
					/// Destroys the group in the aggregation {@link #getGroup group}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.MasterPage destroyGroup();

					/// <summary>
					/// Sets the aggregated {@link #getGroup group}.
					/// </summary>
					/// <param name="oGroup">The group to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.MasterPage setGroup(sap.m.semantic.IGroup oGroup);

					#endregion

					#region Methods for Aggregation messagesIndicator

					/// <summary>
					/// Gets content of aggregation {@link #getMessagesIndicator messagesIndicator}.
					/// 
					/// MessagesIndicator
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.m.semantic.MessagesIndicator getMessagesIndicator();

					/// <summary>
					/// Destroys the messagesIndicator in the aggregation {@link #getMessagesIndicator messagesIndicator}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.MasterPage destroyMessagesIndicator();

					/// <summary>
					/// Sets the aggregated {@link #getMessagesIndicator messagesIndicator}.
					/// </summary>
					/// <param name="oMessagesIndicator">The messagesIndicator to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.MasterPage setMessagesIndicator(sap.m.semantic.MessagesIndicator oMessagesIndicator);

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.m.semantic.MasterPage with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.semantic.SemanticPage.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.m.semantic.MasterPage with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.semantic.SemanticPage.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.m.semantic.MasterPage with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.semantic.SemanticPage.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.m.semantic.MasterPage.
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
