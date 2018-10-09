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
			public static partial class semantic
			{
				/// <summary>
				/// A DetailPage is a {@link sap.m.semantic.ShareMenuPage} that supports semantic content of the following types:
				/// 
				/// <ul> <li>{@link sap.m.semantic.AddAction}</li> <li>{@link sap.m.semantic.MainAction}</li> <li>{@link sap.m.semantic.PositiveAction}</li> <li>{@link sap.m.semantic.NegativeAction}</li> <li>{@link sap.m.semantic.ForwardAction}</li> <li>{@link sap.m.semantic.EditAction}</li> <li>{@link sap.m.semantic.SaveAction}</li> <li>{@link sap.m.semantic.DeleteAction}</li> <li>{@link sap.m.semantic.CancelAction}</li> <li>{@link sap.m.semantic.FlagAction}</li> <li>{@link sap.m.semantic.FavoriteAction}</li> <li>{@link sap.m.semantic.OpenInAction}</li> <li>{@link sap.m.semantic.DiscussInJamAction}</li> <li>{@link sap.m.semantic.ShareInJamAction}</li> <li>{@link sap.m.semantic.SendEmailAction}</li> <li>{@link sap.m.semantic.SendMessageAction}</li> <li>{@link sap.m.semantic.PrintAction}</li> <li>{@link sap.m.semantic.MessagesIndicator}</li> <li>{@link sap.m.DraftIndicator}</li> </ul>
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.m.semantic.DetailPage")]
				public partial class DetailPage : sap.m.semantic.ShareMenuPage
				{
					#region Settings

					/// <summary>
					/// Settings class to create the object
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class Settings : sap.m.semantic.ShareMenuPage.Settings
					{
						/// <summary>
						/// Add action
						/// </summary>
						public Union<sap.m.semantic.AddAction, string, sap.ui.@base.ManagedObject.BindAggregationInfo> addAction;

						/// <summary>
						/// Main action
						/// </summary>
						public Union<sap.m.semantic.MainAction, string, sap.ui.@base.ManagedObject.BindAggregationInfo> mainAction;

						/// <summary>
						/// Positive action
						/// </summary>
						public Union<sap.m.semantic.PositiveAction, string, sap.ui.@base.ManagedObject.BindAggregationInfo> positiveAction;

						/// <summary>
						/// Negative action
						/// </summary>
						public Union<sap.m.semantic.NegativeAction, string, sap.ui.@base.ManagedObject.BindAggregationInfo> negativeAction;

						/// <summary>
						/// Negative action
						/// </summary>
						public Union<sap.m.semantic.ForwardAction, string, sap.ui.@base.ManagedObject.BindAggregationInfo> forwardAction;

						/// <summary>
						/// Edit action
						/// </summary>
						public Union<sap.m.semantic.EditAction, string, sap.ui.@base.ManagedObject.BindAggregationInfo> editAction;

						/// <summary>
						/// Save action
						/// </summary>
						public Union<sap.m.semantic.SaveAction, string, sap.ui.@base.ManagedObject.BindAggregationInfo> saveAction;

						/// <summary>
						/// Delete action
						/// </summary>
						public Union<sap.m.semantic.DeleteAction, string, sap.ui.@base.ManagedObject.BindAggregationInfo> deleteAction;

						/// <summary>
						/// Cancel action
						/// </summary>
						public Union<sap.m.semantic.CancelAction, string, sap.ui.@base.ManagedObject.BindAggregationInfo> cancelAction;

						/// <summary>
						/// Flag action
						/// </summary>
						public Union<sap.m.semantic.FlagAction, string, sap.ui.@base.ManagedObject.BindAggregationInfo> flagAction;

						/// <summary>
						/// Favorite action
						/// </summary>
						public Union<sap.m.semantic.FavoriteAction, string, sap.ui.@base.ManagedObject.BindAggregationInfo> favoriteAction;

						/// <summary>
						/// OpenIn action
						/// </summary>
						public Union<sap.m.semantic.OpenInAction, string, sap.ui.@base.ManagedObject.BindAggregationInfo> openInAction;

						/// <summary>
						/// DiscussInJam action
						/// </summary>
						public Union<sap.m.semantic.DiscussInJamAction, string, sap.ui.@base.ManagedObject.BindAggregationInfo> discussInJamAction;

						/// <summary>
						/// ShareInJam action
						/// </summary>
						public Union<sap.m.semantic.ShareInJamAction, string, sap.ui.@base.ManagedObject.BindAggregationInfo> shareInJamAction;

						/// <summary>
						/// SendEmail action
						/// </summary>
						public Union<sap.m.semantic.SendEmailAction, string, sap.ui.@base.ManagedObject.BindAggregationInfo> sendEmailAction;

						/// <summary>
						/// SendMessage action
						/// </summary>
						public Union<sap.m.semantic.SendMessageAction, string, sap.ui.@base.ManagedObject.BindAggregationInfo> sendMessageAction;

						/// <summary>
						/// Print action
						/// </summary>
						public Union<sap.m.semantic.PrintAction, string, sap.ui.@base.ManagedObject.BindAggregationInfo> printAction;

						/// <summary>
						/// MessagesIndicator
						/// </summary>
						public Union<sap.m.semantic.MessagesIndicator, string, sap.ui.@base.ManagedObject.BindAggregationInfo> messagesIndicator;

						/// <summary>
						/// SaveAsTile button
						/// </summary>
						public Union<sap.m.Button, string, sap.ui.@base.ManagedObject.BindAggregationInfo> saveAsTileAction;

						/// <summary>
						/// Paging action
						/// </summary>
						public Union<sap.m.PagingButton, string, sap.ui.@base.ManagedObject.BindAggregationInfo> pagingAction;

						/// <summary>
						/// DraftIndicator
						/// </summary>
						public Union<sap.m.DraftIndicator, string, sap.ui.@base.ManagedObject.BindAggregationInfo> draftIndicator;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new DetailPage
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern DetailPage(string sId, sap.m.semantic.DetailPage.Settings mSettings);

					/// <summary>
					/// Constructor for a new DetailPage
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					public extern DetailPage(string sId);

					/// <summary>
					/// Constructor for a new DetailPage
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern DetailPage();

					/// <summary>
					/// Constructor for a new DetailPage
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern DetailPage(sap.m.semantic.DetailPage.Settings mSettings);

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
					public extern virtual sap.m.semantic.DetailPage destroyAddAction();

					/// <summary>
					/// Sets the aggregated {@link #getAddAction addAction}.
					/// </summary>
					/// <param name="oAddAction">The addAction to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.DetailPage setAddAction(sap.m.semantic.AddAction oAddAction);

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
					public extern virtual sap.m.semantic.DetailPage destroyMainAction();

					/// <summary>
					/// Sets the aggregated {@link #getMainAction mainAction}.
					/// </summary>
					/// <param name="oMainAction">The mainAction to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.DetailPage setMainAction(sap.m.semantic.MainAction oMainAction);

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
					public extern virtual sap.m.semantic.DetailPage destroyPositiveAction();

					/// <summary>
					/// Sets the aggregated {@link #getPositiveAction positiveAction}.
					/// </summary>
					/// <param name="oPositiveAction">The positiveAction to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.DetailPage setPositiveAction(sap.m.semantic.PositiveAction oPositiveAction);

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
					public extern virtual sap.m.semantic.DetailPage destroyNegativeAction();

					/// <summary>
					/// Sets the aggregated {@link #getNegativeAction negativeAction}.
					/// </summary>
					/// <param name="oNegativeAction">The negativeAction to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.DetailPage setNegativeAction(sap.m.semantic.NegativeAction oNegativeAction);

					#endregion

					#region Methods for Aggregation forwardAction

					/// <summary>
					/// Gets content of aggregation {@link #getForwardAction forwardAction}.
					/// 
					/// Negative action
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.m.semantic.ForwardAction getForwardAction();

					/// <summary>
					/// Destroys the forwardAction in the aggregation {@link #getForwardAction forwardAction}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.DetailPage destroyForwardAction();

					/// <summary>
					/// Sets the aggregated {@link #getForwardAction forwardAction}.
					/// </summary>
					/// <param name="oForwardAction">The forwardAction to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.DetailPage setForwardAction(sap.m.semantic.ForwardAction oForwardAction);

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
					public extern virtual sap.m.semantic.DetailPage destroyEditAction();

					/// <summary>
					/// Sets the aggregated {@link #getEditAction editAction}.
					/// </summary>
					/// <param name="oEditAction">The editAction to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.DetailPage setEditAction(sap.m.semantic.EditAction oEditAction);

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
					public extern virtual sap.m.semantic.DetailPage destroySaveAction();

					/// <summary>
					/// Sets the aggregated {@link #getSaveAction saveAction}.
					/// </summary>
					/// <param name="oSaveAction">The saveAction to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.DetailPage setSaveAction(sap.m.semantic.SaveAction oSaveAction);

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
					public extern virtual sap.m.semantic.DetailPage destroyDeleteAction();

					/// <summary>
					/// Sets the aggregated {@link #getDeleteAction deleteAction}.
					/// </summary>
					/// <param name="oDeleteAction">The deleteAction to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.DetailPage setDeleteAction(sap.m.semantic.DeleteAction oDeleteAction);

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
					public extern virtual sap.m.semantic.DetailPage destroyCancelAction();

					/// <summary>
					/// Sets the aggregated {@link #getCancelAction cancelAction}.
					/// </summary>
					/// <param name="oCancelAction">The cancelAction to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.DetailPage setCancelAction(sap.m.semantic.CancelAction oCancelAction);

					#endregion

					#region Methods for Aggregation flagAction

					/// <summary>
					/// Gets content of aggregation {@link #getFlagAction flagAction}.
					/// 
					/// Flag action
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.m.semantic.FlagAction getFlagAction();

					/// <summary>
					/// Destroys the flagAction in the aggregation {@link #getFlagAction flagAction}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.DetailPage destroyFlagAction();

					/// <summary>
					/// Sets the aggregated {@link #getFlagAction flagAction}.
					/// </summary>
					/// <param name="oFlagAction">The flagAction to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.DetailPage setFlagAction(sap.m.semantic.FlagAction oFlagAction);

					#endregion

					#region Methods for Aggregation favoriteAction

					/// <summary>
					/// Gets content of aggregation {@link #getFavoriteAction favoriteAction}.
					/// 
					/// Favorite action
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.m.semantic.FavoriteAction getFavoriteAction();

					/// <summary>
					/// Destroys the favoriteAction in the aggregation {@link #getFavoriteAction favoriteAction}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.DetailPage destroyFavoriteAction();

					/// <summary>
					/// Sets the aggregated {@link #getFavoriteAction favoriteAction}.
					/// </summary>
					/// <param name="oFavoriteAction">The favoriteAction to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.DetailPage setFavoriteAction(sap.m.semantic.FavoriteAction oFavoriteAction);

					#endregion

					#region Methods for Aggregation openInAction

					/// <summary>
					/// Gets content of aggregation {@link #getOpenInAction openInAction}.
					/// 
					/// OpenIn action
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.m.semantic.OpenInAction getOpenInAction();

					/// <summary>
					/// Destroys the openInAction in the aggregation {@link #getOpenInAction openInAction}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.DetailPage destroyOpenInAction();

					/// <summary>
					/// Sets the aggregated {@link #getOpenInAction openInAction}.
					/// </summary>
					/// <param name="oOpenInAction">The openInAction to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.DetailPage setOpenInAction(sap.m.semantic.OpenInAction oOpenInAction);

					#endregion

					#region Methods for Aggregation discussInJamAction

					/// <summary>
					/// Gets content of aggregation {@link #getDiscussInJamAction discussInJamAction}.
					/// 
					/// DiscussInJam action
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.m.semantic.DiscussInJamAction getDiscussInJamAction();

					/// <summary>
					/// Destroys the discussInJamAction in the aggregation {@link #getDiscussInJamAction discussInJamAction}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.DetailPage destroyDiscussInJamAction();

					/// <summary>
					/// Sets the aggregated {@link #getDiscussInJamAction discussInJamAction}.
					/// </summary>
					/// <param name="oDiscussInJamAction">The discussInJamAction to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.DetailPage setDiscussInJamAction(sap.m.semantic.DiscussInJamAction oDiscussInJamAction);

					#endregion

					#region Methods for Aggregation shareInJamAction

					/// <summary>
					/// Gets content of aggregation {@link #getShareInJamAction shareInJamAction}.
					/// 
					/// ShareInJam action
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.m.semantic.ShareInJamAction getShareInJamAction();

					/// <summary>
					/// Destroys the shareInJamAction in the aggregation {@link #getShareInJamAction shareInJamAction}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.DetailPage destroyShareInJamAction();

					/// <summary>
					/// Sets the aggregated {@link #getShareInJamAction shareInJamAction}.
					/// </summary>
					/// <param name="oShareInJamAction">The shareInJamAction to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.DetailPage setShareInJamAction(sap.m.semantic.ShareInJamAction oShareInJamAction);

					#endregion

					#region Methods for Aggregation sendEmailAction

					/// <summary>
					/// Gets content of aggregation {@link #getSendEmailAction sendEmailAction}.
					/// 
					/// SendEmail action
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.m.semantic.SendEmailAction getSendEmailAction();

					/// <summary>
					/// Destroys the sendEmailAction in the aggregation {@link #getSendEmailAction sendEmailAction}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.DetailPage destroySendEmailAction();

					/// <summary>
					/// Sets the aggregated {@link #getSendEmailAction sendEmailAction}.
					/// </summary>
					/// <param name="oSendEmailAction">The sendEmailAction to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.DetailPage setSendEmailAction(sap.m.semantic.SendEmailAction oSendEmailAction);

					#endregion

					#region Methods for Aggregation sendMessageAction

					/// <summary>
					/// Gets content of aggregation {@link #getSendMessageAction sendMessageAction}.
					/// 
					/// SendMessage action
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.m.semantic.SendMessageAction getSendMessageAction();

					/// <summary>
					/// Destroys the sendMessageAction in the aggregation {@link #getSendMessageAction sendMessageAction}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.DetailPage destroySendMessageAction();

					/// <summary>
					/// Sets the aggregated {@link #getSendMessageAction sendMessageAction}.
					/// </summary>
					/// <param name="oSendMessageAction">The sendMessageAction to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.DetailPage setSendMessageAction(sap.m.semantic.SendMessageAction oSendMessageAction);

					#endregion

					#region Methods for Aggregation printAction

					/// <summary>
					/// Gets content of aggregation {@link #getPrintAction printAction}.
					/// 
					/// Print action
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.m.semantic.PrintAction getPrintAction();

					/// <summary>
					/// Destroys the printAction in the aggregation {@link #getPrintAction printAction}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.DetailPage destroyPrintAction();

					/// <summary>
					/// Sets the aggregated {@link #getPrintAction printAction}.
					/// </summary>
					/// <param name="oPrintAction">The printAction to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.DetailPage setPrintAction(sap.m.semantic.PrintAction oPrintAction);

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
					public extern virtual sap.m.semantic.DetailPage destroyMessagesIndicator();

					/// <summary>
					/// Sets the aggregated {@link #getMessagesIndicator messagesIndicator}.
					/// </summary>
					/// <param name="oMessagesIndicator">The messagesIndicator to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.DetailPage setMessagesIndicator(sap.m.semantic.MessagesIndicator oMessagesIndicator);

					#endregion

					#region Methods for Aggregation saveAsTileAction

					/// <summary>
					/// Gets content of aggregation {@link #getSaveAsTileAction saveAsTileAction}.
					/// 
					/// SaveAsTile button
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.m.Button getSaveAsTileAction();

					/// <summary>
					/// Destroys the saveAsTileAction in the aggregation {@link #getSaveAsTileAction saveAsTileAction}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.DetailPage destroySaveAsTileAction();

					/// <summary>
					/// Sets the aggregated {@link #getSaveAsTileAction saveAsTileAction}.
					/// </summary>
					/// <param name="oSaveAsTileAction">The saveAsTileAction to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.DetailPage setSaveAsTileAction(sap.m.Button oSaveAsTileAction);

					#endregion

					#region Methods for Aggregation pagingAction

					/// <summary>
					/// Gets content of aggregation {@link #getPagingAction pagingAction}.
					/// 
					/// Paging action
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.m.PagingButton getPagingAction();

					/// <summary>
					/// Destroys the pagingAction in the aggregation {@link #getPagingAction pagingAction}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.DetailPage destroyPagingAction();

					/// <summary>
					/// Sets the aggregated {@link #getPagingAction pagingAction}.
					/// </summary>
					/// <param name="oPagingAction">The pagingAction to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.DetailPage setPagingAction(sap.m.PagingButton oPagingAction);

					#endregion

					#region Methods for Aggregation draftIndicator

					/// <summary>
					/// Gets content of aggregation {@link #getDraftIndicator draftIndicator}.
					/// 
					/// DraftIndicator
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.m.DraftIndicator getDraftIndicator();

					/// <summary>
					/// Destroys the draftIndicator in the aggregation {@link #getDraftIndicator draftIndicator}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.DetailPage destroyDraftIndicator();

					/// <summary>
					/// Sets the aggregated {@link #getDraftIndicator draftIndicator}.
					/// </summary>
					/// <param name="oDraftIndicator">The draftIndicator to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.DetailPage setDraftIndicator(sap.m.DraftIndicator oDraftIndicator);

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.m.semantic.DetailPage with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.semantic.ShareMenuPage.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.m.semantic.DetailPage with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.semantic.ShareMenuPage.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.m.semantic.DetailPage with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.semantic.ShareMenuPage.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.m.semantic.DetailPage.
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
