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
				/// The unit that is embedded - single-wise or in a multiple way - into a Feed control. The control provides a set of properties for text, sender information, time stamp, comments, and functions such as flagging the entry to be favorite, shared, or flagged.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.ux3.FeedChunk")]
				[Obsolete("Deprecated since 1.38. Instead, use the <code>sap.m.FeedListItem</code> control.")]
				public partial class FeedChunk : sap.ui.core.Control
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
						/// URL to the thumbnail image.
						/// </summary>
						public Union<sap.ui.core.URI, string, sap.ui.@base.ManagedObject.BindPropertyInfo> thumbnailSrc;

						/// <summary>
						/// The FeedChunk text. @References are supported.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> text;

						/// <summary>
						/// Sender of the chunk
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> sender;

						/// <summary>
						/// Format is ISO 8601 YYYY-MM-DDThh:mm:ss.sZ, Z meaning the time is in UTC time zone
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> timestamp;

						/// <summary>
						/// Flag if the deletion of the chunk shall be allowed
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> deletionAllowed;

						/// <summary>
						/// This flag changes a FeedChunk into a CommentChunk. In this case, it can not have own comments, furthermore it must be assigned to a FeedChunk.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> commentChunk;

						/// <summary>
						/// URL to the thumbnail image for the comment feeder. This property is optional if the chunk is a sub-control of a feed control. In this case the value of the feed control is used if it's not set. So it must be only set once on the feed control.
						/// </summary>
						public Union<sap.ui.core.URI, string, sap.ui.@base.ManagedObject.BindPropertyInfo> feederThumbnailSrc;

						/// <summary>
						/// Sender for the comment feeder This property is optional if the chunk is a sub-control of a feed control. In this case the value of the feed control is used if it's not set. So it must be only set once on the feed control.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> feederSender;

						/// <summary>
						/// Defines whether the entry is flagged. This property is not supported for comment chunks.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> flagged;

						/// <summary>
						/// Defines whether the entry shall be displayed as favorite. This property is not supported for comment chunks.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> favorite;

						/// <summary>
						/// Defines whether the entry shall be shared. This property is not supported for comment chunks.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> shared;

						/// <summary>
						/// If true the flag action is enabled.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> enableFlag;

						/// <summary>
						/// If true the share action is enabled.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> enableShare;

						/// <summary>
						/// If true the comment action is enabled.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> enableComment;

						/// <summary>
						/// If true the inspect action is enabled.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> enableInspect;

						/// <summary>
						/// If true the favorite action is enabled.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> enableFavorite;

						/// <summary>
						/// Comments on this chunk
						/// </summary>
						public Union<sap.ui.ux3.FeedChunk[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> comments;

						/// <summary>
						/// MenuItems to open when there is a click on the action menu button
						/// </summary>
						public Union<sap.ui.commons.MenuItem[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> actionMenuItems;

						/// <summary>
						/// Event is fired when the deletion button is pressed.
						/// </summary>
						public sap.ui.@base.EventDelegate deleted;

						/// <summary>
						/// Event is raised when a comment is added to the entry. This event is not supported for comment chunks.
						/// </summary>
						public sap.ui.ux3.FeedChunk.CommentAddedDelegate commentAdded;

						/// <summary>
						/// Event is raised when the user clicks to flag the entry. This event is not supported for comment chunks.
						/// </summary>
						public sap.ui.ux3.FeedChunk.ToggleFlaggedDelegate toggleFlagged;

						/// <summary>
						/// Event is fired when the thumbnail or the name of the sender is clicked.
						/// </summary>
						public sap.ui.@base.EventDelegate senderClicked;

						/// <summary>
						/// Click on a @-reference
						/// </summary>
						public sap.ui.ux3.SubmitDelegate referenceClicked;

						/// <summary>
						/// Event is raised when the user clicks to set the entry as favorite. This event is not supported for comment chunks.
						/// </summary>
						public sap.ui.ux3.FeedChunk.ToggleFavoriteDelegate toggleFavorite;

						/// <summary>
						/// Event is fired when the inspect button was pressed
						/// </summary>
						public sap.ui.@base.EventDelegate inspect;

						/// <summary>
						/// Event is raised when the user clicks to share the entry. This event is not supported for comment chunks.
						/// </summary>
						public sap.ui.ux3.FeedChunk.ToggleSharedDelegate toggleShared;

						/// <summary>
						/// Event is fired when an item from the action menu button was selected.
						/// </summary>
						public sap.ui.ItemSelectedDelegate actionItemSelected;

					}

					#endregion

					#region Typed Parameters

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class CommentAddedInfo
					{
						/// <summary>
						/// New comment chunk
						/// </summary>
						public sap.ui.ux3.FeedChunk comment;

					}

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class ToggleFavoriteInfo
					{
						/// <summary>
						/// Current favorite state
						/// </summary>
						public bool favorite;

					}

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class ToggleFlaggedInfo
					{
						/// <summary>
						/// Current flagged state
						/// </summary>
						public bool flagged;

					}

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class ToggleSharedInfo
					{
						/// <summary>
						/// Current shared state
						/// </summary>
						public bool shareed;

					}

					#endregion

					#region Delegates

					public delegate void CommentAddedDelegate(sap.ui.@base.Event<sap.ui.ux3.FeedChunk.CommentAddedInfo> oEvent, object oData);

					public delegate void ToggleFavoriteDelegate(sap.ui.@base.Event<sap.ui.ux3.FeedChunk.ToggleFavoriteInfo> oEvent, object oData);

					public delegate void ToggleFlaggedDelegate(sap.ui.@base.Event<sap.ui.ux3.FeedChunk.ToggleFlaggedInfo> oEvent, object oData);

					public delegate void ToggleSharedDelegate(sap.ui.@base.Event<sap.ui.ux3.FeedChunk.ToggleSharedInfo> oEvent, object oData);

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new FeedChunk.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern FeedChunk(string sId, sap.ui.ux3.FeedChunk.Settings mSettings);

					/// <summary>
					/// Constructor for a new FeedChunk.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern FeedChunk(string sId);

					/// <summary>
					/// Constructor for a new FeedChunk.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern FeedChunk();

					/// <summary>
					/// Constructor for a new FeedChunk.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern FeedChunk(sap.ui.ux3.FeedChunk.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property thumbnailSrc

					/// <summary>
					/// Gets current value of property {@link #getThumbnailSrc thumbnailSrc}.
					/// 
					/// URL to the thumbnail image.
					/// </summary>
					/// <returns>Value of property <code>thumbnailSrc</code></returns>
					public extern virtual sap.ui.core.URI getThumbnailSrc();

					/// <summary>
					/// Sets a new value for property {@link #getThumbnailSrc thumbnailSrc}.
					/// 
					/// URL to the thumbnail image.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sThumbnailSrc">New value for property <code>thumbnailSrc</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk setThumbnailSrc(sap.ui.core.URI sThumbnailSrc);

					#endregion

					#region Methods for Property text

					/// <summary>
					/// Gets current value of property {@link #getText text}.
					/// 
					/// The FeedChunk text. @References are supported.
					/// </summary>
					/// <returns>Value of property <code>text</code></returns>
					public extern virtual string getText();

					/// <summary>
					/// Sets a new value for property {@link #getText text}.
					/// 
					/// The FeedChunk text. @References are supported.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sText">New value for property <code>text</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk setText(string sText);

					#endregion

					#region Methods for Property sender

					/// <summary>
					/// Gets current value of property {@link #getSender sender}.
					/// 
					/// Sender of the chunk
					/// </summary>
					/// <returns>Value of property <code>sender</code></returns>
					public extern virtual string getSender();

					/// <summary>
					/// Sets a new value for property {@link #getSender sender}.
					/// 
					/// Sender of the chunk
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sSender">New value for property <code>sender</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk setSender(string sSender);

					#endregion

					#region Methods for Property timestamp

					/// <summary>
					/// Gets current value of property {@link #getTimestamp timestamp}.
					/// 
					/// Format is ISO 8601 YYYY-MM-DDThh:mm:ss.sZ, Z meaning the time is in UTC time zone
					/// </summary>
					/// <returns>Value of property <code>timestamp</code></returns>
					public extern virtual string getTimestamp();

					/// <summary>
					/// Sets a new value for property {@link #getTimestamp timestamp}.
					/// 
					/// Format is ISO 8601 YYYY-MM-DDThh:mm:ss.sZ, Z meaning the time is in UTC time zone
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sTimestamp">New value for property <code>timestamp</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk setTimestamp(string sTimestamp);

					#endregion

					#region Methods for Property deletionAllowed

					/// <summary>
					/// Gets current value of property {@link #getDeletionAllowed deletionAllowed}.
					/// 
					/// Flag if the deletion of the chunk shall be allowed
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>deletionAllowed</code></returns>
					public extern virtual bool getDeletionAllowed();

					/// <summary>
					/// Sets a new value for property {@link #getDeletionAllowed deletionAllowed}.
					/// 
					/// Flag if the deletion of the chunk shall be allowed
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bDeletionAllowed">New value for property <code>deletionAllowed</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk setDeletionAllowed(bool bDeletionAllowed);

					#endregion

					#region Methods for Property commentChunk

					/// <summary>
					/// Gets current value of property {@link #getCommentChunk commentChunk}.
					/// 
					/// This flag changes a FeedChunk into a CommentChunk. In this case, it can not have own comments, furthermore it must be assigned to a FeedChunk.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>commentChunk</code></returns>
					[Obsolete("Deprecated since 1.4.0. Not longer used. If a chunk is a comment is determined from hierarchy. If the parent is a chunk it's automatically a comment.")]
					public extern virtual bool getCommentChunk();

					/// <summary>
					/// Sets a new value for property {@link #getCommentChunk commentChunk}.
					/// 
					/// This flag changes a FeedChunk into a CommentChunk. In this case, it can not have own comments, furthermore it must be assigned to a FeedChunk.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bCommentChunk">New value for property <code>commentChunk</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					[Obsolete("Deprecated since 1.4.0. Not longer used. If a chunk is a comment is determined from hierarchy. If the parent is a chunk it's automatically a comment.")]
					public extern virtual sap.ui.ux3.FeedChunk setCommentChunk(bool bCommentChunk);

					#endregion

					#region Methods for Property feederThumbnailSrc

					/// <summary>
					/// Gets current value of property {@link #getFeederThumbnailSrc feederThumbnailSrc}.
					/// 
					/// URL to the thumbnail image for the comment feeder. This property is optional if the chunk is a sub-control of a feed control. In this case the value of the feed control is used if it's not set. So it must be only set once on the feed control.
					/// </summary>
					/// <returns>Value of property <code>feederThumbnailSrc</code></returns>
					public extern virtual sap.ui.core.URI getFeederThumbnailSrc();

					/// <summary>
					/// Sets a new value for property {@link #getFeederThumbnailSrc feederThumbnailSrc}.
					/// 
					/// URL to the thumbnail image for the comment feeder. This property is optional if the chunk is a sub-control of a feed control. In this case the value of the feed control is used if it's not set. So it must be only set once on the feed control.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sFeederThumbnailSrc">New value for property <code>feederThumbnailSrc</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk setFeederThumbnailSrc(sap.ui.core.URI sFeederThumbnailSrc);

					#endregion

					#region Methods for Property feederSender

					/// <summary>
					/// Gets current value of property {@link #getFeederSender feederSender}.
					/// 
					/// Sender for the comment feeder This property is optional if the chunk is a sub-control of a feed control. In this case the value of the feed control is used if it's not set. So it must be only set once on the feed control.
					/// </summary>
					/// <returns>Value of property <code>feederSender</code></returns>
					public extern virtual string getFeederSender();

					/// <summary>
					/// Sets a new value for property {@link #getFeederSender feederSender}.
					/// 
					/// Sender for the comment feeder This property is optional if the chunk is a sub-control of a feed control. In this case the value of the feed control is used if it's not set. So it must be only set once on the feed control.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sFeederSender">New value for property <code>feederSender</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk setFeederSender(string sFeederSender);

					#endregion

					#region Methods for Property flagged

					/// <summary>
					/// Gets current value of property {@link #getFlagged flagged}.
					/// 
					/// Defines whether the entry is flagged. This property is not supported for comment chunks.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>flagged</code></returns>
					public extern virtual bool getFlagged();

					/// <summary>
					/// Sets a new value for property {@link #getFlagged flagged}.
					/// 
					/// Defines whether the entry is flagged. This property is not supported for comment chunks.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bFlagged">New value for property <code>flagged</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk setFlagged(bool bFlagged);

					#endregion

					#region Methods for Property favorite

					/// <summary>
					/// Gets current value of property {@link #getFavorite favorite}.
					/// 
					/// Defines whether the entry shall be displayed as favorite. This property is not supported for comment chunks.
					/// </summary>
					/// <returns>Value of property <code>favorite</code></returns>
					public extern virtual bool getFavorite();

					/// <summary>
					/// Sets a new value for property {@link #getFavorite favorite}.
					/// 
					/// Defines whether the entry shall be displayed as favorite. This property is not supported for comment chunks.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="bFavorite">New value for property <code>favorite</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk setFavorite(bool bFavorite);

					#endregion

					#region Methods for Property shared

					/// <summary>
					/// Gets current value of property {@link #getShared shared}.
					/// 
					/// Defines whether the entry shall be shared. This property is not supported for comment chunks.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>shared</code></returns>
					public extern virtual bool getShared();

					/// <summary>
					/// Sets a new value for property {@link #getShared shared}.
					/// 
					/// Defines whether the entry shall be shared. This property is not supported for comment chunks.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bShared">New value for property <code>shared</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk setShared(bool bShared);

					#endregion

					#region Methods for Property enableFlag

					/// <summary>
					/// Gets current value of property {@link #getEnableFlag enableFlag}.
					/// 
					/// If true the flag action is enabled.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>enableFlag</code></returns>
					public extern virtual bool getEnableFlag();

					/// <summary>
					/// Sets a new value for property {@link #getEnableFlag enableFlag}.
					/// 
					/// If true the flag action is enabled.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bEnableFlag">New value for property <code>enableFlag</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk setEnableFlag(bool bEnableFlag);

					#endregion

					#region Methods for Property enableShare

					/// <summary>
					/// Gets current value of property {@link #getEnableShare enableShare}.
					/// 
					/// If true the share action is enabled.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>enableShare</code></returns>
					public extern virtual bool getEnableShare();

					/// <summary>
					/// Sets a new value for property {@link #getEnableShare enableShare}.
					/// 
					/// If true the share action is enabled.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bEnableShare">New value for property <code>enableShare</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk setEnableShare(bool bEnableShare);

					#endregion

					#region Methods for Property enableComment

					/// <summary>
					/// Gets current value of property {@link #getEnableComment enableComment}.
					/// 
					/// If true the comment action is enabled.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>enableComment</code></returns>
					public extern virtual bool getEnableComment();

					/// <summary>
					/// Sets a new value for property {@link #getEnableComment enableComment}.
					/// 
					/// If true the comment action is enabled.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bEnableComment">New value for property <code>enableComment</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk setEnableComment(bool bEnableComment);

					#endregion

					#region Methods for Property enableInspect

					/// <summary>
					/// Gets current value of property {@link #getEnableInspect enableInspect}.
					/// 
					/// If true the inspect action is enabled.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>enableInspect</code></returns>
					public extern virtual bool getEnableInspect();

					/// <summary>
					/// Sets a new value for property {@link #getEnableInspect enableInspect}.
					/// 
					/// If true the inspect action is enabled.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bEnableInspect">New value for property <code>enableInspect</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk setEnableInspect(bool bEnableInspect);

					#endregion

					#region Methods for Property enableFavorite

					/// <summary>
					/// Gets current value of property {@link #getEnableFavorite enableFavorite}.
					/// 
					/// If true the favorite action is enabled.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>enableFavorite</code></returns>
					public extern virtual bool getEnableFavorite();

					/// <summary>
					/// Sets a new value for property {@link #getEnableFavorite enableFavorite}.
					/// 
					/// If true the favorite action is enabled.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bEnableFavorite">New value for property <code>enableFavorite</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk setEnableFavorite(bool bEnableFavorite);

					#endregion

					#region Methods for Aggregation comments

					/// <summary>
					/// Gets content of aggregation {@link #getComments comments}.
					/// 
					/// Comments on this chunk
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.ux3.FeedChunk[] getComments();

					/// <summary>
					/// Destroys all the comments in the aggregation {@link #getComments comments}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk destroyComments();

					/// <summary>
					/// Inserts a comment into the aggregation {@link #getComments comments}.
					/// </summary>
					/// <param name="oComment">The comment to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the comment should be inserted at; for a negative value of <code>iIndex</code>, the comment is inserted at position 0; for a value greater than the current size of the aggregation, the comment is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk insertComment(sap.ui.ux3.FeedChunk oComment, int iIndex);

					/// <summary>
					/// Adds some comment to the aggregation {@link #getComments comments}.
					/// </summary>
					/// <param name="oComment">The comment to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk addComment(sap.ui.ux3.FeedChunk oComment);

					/// <summary>
					/// Removes a comment from the aggregation {@link #getComments comments}.
					/// </summary>
					/// <param name="vComment">The comment to remove or its index or id</param>
					/// <returns>The removed comment or <code>null</code></returns>
					public extern virtual sap.ui.ux3.FeedChunk removeComment(Union<int, string, sap.ui.ux3.FeedChunk> vComment);

					/// <summary>
					/// Checks for the provided <code>sap.ui.ux3.FeedChunk</code> in the aggregation {@link #getComments comments}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oComment">The comment whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfComment(sap.ui.ux3.FeedChunk oComment);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getComments comments}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.ux3.FeedChunk[] removeAllComments();

					/// <summary>
					/// Binds aggregation {@link #getComments comments} to model data.
					/// 
					/// See {@link sap.ui.base.ManagedObject#bindAggregation ManagedObject.bindAggregation} for a detailed description of the possible properties of <code>oBindingInfo</code>.
					/// </summary>
					/// <param name="oBindingInfo">The binding information</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk bindComments(sap.ui.@base.ManagedObject.BindAggregationInfo oBindingInfo);

					/// <summary>
					/// Unbinds aggregation {@link #getComments comments} from model data.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk unbindComments();

					#endregion

					#region Methods for Aggregation actionMenuItems

					/// <summary>
					/// Gets content of aggregation {@link #getActionMenuItems actionMenuItems}.
					/// 
					/// MenuItems to open when there is a click on the action menu button
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.commons.MenuItem[] getActionMenuItems();

					/// <summary>
					/// Destroys all the actionMenuItems in the aggregation {@link #getActionMenuItems actionMenuItems}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk destroyActionMenuItems();

					/// <summary>
					/// Inserts a actionMenuItem into the aggregation {@link #getActionMenuItems actionMenuItems}.
					/// </summary>
					/// <param name="oActionMenuItem">The actionMenuItem to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the actionMenuItem should be inserted at; for a negative value of <code>iIndex</code>, the actionMenuItem is inserted at position 0; for a value greater than the current size of the aggregation, the actionMenuItem is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk insertActionMenuItem(sap.ui.commons.MenuItem oActionMenuItem, int iIndex);

					/// <summary>
					/// Adds some actionMenuItem to the aggregation {@link #getActionMenuItems actionMenuItems}.
					/// </summary>
					/// <param name="oActionMenuItem">The actionMenuItem to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk addActionMenuItem(sap.ui.commons.MenuItem oActionMenuItem);

					/// <summary>
					/// Removes a actionMenuItem from the aggregation {@link #getActionMenuItems actionMenuItems}.
					/// </summary>
					/// <param name="vActionMenuItem">The actionMenuItem to remove or its index or id</param>
					/// <returns>The removed actionMenuItem or <code>null</code></returns>
					public extern virtual sap.ui.commons.MenuItem removeActionMenuItem(Union<int, string, sap.ui.commons.MenuItem> vActionMenuItem);

					/// <summary>
					/// Checks for the provided <code>sap.ui.commons.MenuItem</code> in the aggregation {@link #getActionMenuItems actionMenuItems}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oActionMenuItem">The actionMenuItem whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfActionMenuItem(sap.ui.commons.MenuItem oActionMenuItem);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getActionMenuItems actionMenuItems}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.commons.MenuItem[] removeAllActionMenuItems();

					/// <summary>
					/// Binds aggregation {@link #getActionMenuItems actionMenuItems} to model data.
					/// 
					/// See {@link sap.ui.base.ManagedObject#bindAggregation ManagedObject.bindAggregation} for a detailed description of the possible properties of <code>oBindingInfo</code>.
					/// </summary>
					/// <param name="oBindingInfo">The binding information</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk bindActionMenuItems(sap.ui.@base.ManagedObject.BindAggregationInfo oBindingInfo);

					/// <summary>
					/// Unbinds aggregation {@link #getActionMenuItems actionMenuItems} from model data.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk unbindActionMenuItems();

					#endregion

					#region Methods for Event deleted

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:deleted deleted} event of this <code>sap.ui.ux3.FeedChunk</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.FeedChunk</code> itself.
					/// 
					/// Event is fired when the deletion button is pressed.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.FeedChunk</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk attachDeleted(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:deleted deleted} event of this <code>sap.ui.ux3.FeedChunk</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.FeedChunk</code> itself.
					/// 
					/// Event is fired when the deletion button is pressed.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk attachDeleted(object oData, sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:deleted deleted} event of this <code>sap.ui.ux3.FeedChunk</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.FeedChunk</code> itself.
					/// 
					/// Event is fired when the deletion button is pressed.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk attachDeleted(sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:deleted deleted} event of this <code>sap.ui.ux3.FeedChunk</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.FeedChunk</code> itself.
					/// 
					/// Event is fired when the deletion button is pressed.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.FeedChunk</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk attachDeleted(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:deleted deleted} event of this <code>sap.ui.ux3.FeedChunk</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk detachDeleted(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:deleted deleted} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk fireDeleted(object mParameters);

					/// <summary>
					/// Fires event {@link #event:deleted deleted} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk fireDeleted();

					#endregion

					#region Methods for Event commentAdded

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:commentAdded commentAdded} event of this <code>sap.ui.ux3.FeedChunk</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.FeedChunk</code> itself.
					/// 
					/// Event is raised when a comment is added to the entry. This event is not supported for comment chunks.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.FeedChunk</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk attachCommentAdded(object oData, sap.ui.ux3.FeedChunk.CommentAddedDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:commentAdded commentAdded} event of this <code>sap.ui.ux3.FeedChunk</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.FeedChunk</code> itself.
					/// 
					/// Event is raised when a comment is added to the entry. This event is not supported for comment chunks.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk attachCommentAdded(object oData, sap.ui.ux3.FeedChunk.CommentAddedDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:commentAdded commentAdded} event of this <code>sap.ui.ux3.FeedChunk</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.FeedChunk</code> itself.
					/// 
					/// Event is raised when a comment is added to the entry. This event is not supported for comment chunks.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk attachCommentAdded(sap.ui.ux3.FeedChunk.CommentAddedDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:commentAdded commentAdded} event of this <code>sap.ui.ux3.FeedChunk</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.FeedChunk</code> itself.
					/// 
					/// Event is raised when a comment is added to the entry. This event is not supported for comment chunks.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.FeedChunk</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk attachCommentAdded(sap.ui.ux3.FeedChunk.CommentAddedDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:commentAdded commentAdded} event of this <code>sap.ui.ux3.FeedChunk</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk detachCommentAdded(sap.ui.ux3.FeedChunk.CommentAddedDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:commentAdded commentAdded} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk fireCommentAdded(sap.ui.ux3.FeedChunk.CommentAddedInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:commentAdded commentAdded} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk fireCommentAdded();

					#endregion

					#region Methods for Event toggleFlagged

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:toggleFlagged toggleFlagged} event of this <code>sap.ui.ux3.FeedChunk</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.FeedChunk</code> itself.
					/// 
					/// Event is raised when the user clicks to flag the entry. This event is not supported for comment chunks.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.FeedChunk</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk attachToggleFlagged(object oData, sap.ui.ux3.FeedChunk.ToggleFlaggedDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:toggleFlagged toggleFlagged} event of this <code>sap.ui.ux3.FeedChunk</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.FeedChunk</code> itself.
					/// 
					/// Event is raised when the user clicks to flag the entry. This event is not supported for comment chunks.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk attachToggleFlagged(object oData, sap.ui.ux3.FeedChunk.ToggleFlaggedDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:toggleFlagged toggleFlagged} event of this <code>sap.ui.ux3.FeedChunk</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.FeedChunk</code> itself.
					/// 
					/// Event is raised when the user clicks to flag the entry. This event is not supported for comment chunks.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk attachToggleFlagged(sap.ui.ux3.FeedChunk.ToggleFlaggedDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:toggleFlagged toggleFlagged} event of this <code>sap.ui.ux3.FeedChunk</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.FeedChunk</code> itself.
					/// 
					/// Event is raised when the user clicks to flag the entry. This event is not supported for comment chunks.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.FeedChunk</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk attachToggleFlagged(sap.ui.ux3.FeedChunk.ToggleFlaggedDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:toggleFlagged toggleFlagged} event of this <code>sap.ui.ux3.FeedChunk</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk detachToggleFlagged(sap.ui.ux3.FeedChunk.ToggleFlaggedDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:toggleFlagged toggleFlagged} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk fireToggleFlagged(sap.ui.ux3.FeedChunk.ToggleFlaggedInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:toggleFlagged toggleFlagged} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk fireToggleFlagged();

					#endregion

					#region Methods for Event senderClicked

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:senderClicked senderClicked} event of this <code>sap.ui.ux3.FeedChunk</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.FeedChunk</code> itself.
					/// 
					/// Event is fired when the thumbnail or the name of the sender is clicked.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.FeedChunk</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk attachSenderClicked(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:senderClicked senderClicked} event of this <code>sap.ui.ux3.FeedChunk</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.FeedChunk</code> itself.
					/// 
					/// Event is fired when the thumbnail or the name of the sender is clicked.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk attachSenderClicked(object oData, sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:senderClicked senderClicked} event of this <code>sap.ui.ux3.FeedChunk</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.FeedChunk</code> itself.
					/// 
					/// Event is fired when the thumbnail or the name of the sender is clicked.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk attachSenderClicked(sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:senderClicked senderClicked} event of this <code>sap.ui.ux3.FeedChunk</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.FeedChunk</code> itself.
					/// 
					/// Event is fired when the thumbnail or the name of the sender is clicked.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.FeedChunk</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk attachSenderClicked(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:senderClicked senderClicked} event of this <code>sap.ui.ux3.FeedChunk</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk detachSenderClicked(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:senderClicked senderClicked} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk fireSenderClicked(object mParameters);

					/// <summary>
					/// Fires event {@link #event:senderClicked senderClicked} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk fireSenderClicked();

					#endregion

					#region Methods for Event referenceClicked

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:referenceClicked referenceClicked} event of this <code>sap.ui.ux3.FeedChunk</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.FeedChunk</code> itself.
					/// 
					/// Click on a @-reference
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.FeedChunk</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk attachReferenceClicked(object oData, sap.ui.ux3.SubmitDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:referenceClicked referenceClicked} event of this <code>sap.ui.ux3.FeedChunk</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.FeedChunk</code> itself.
					/// 
					/// Click on a @-reference
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk attachReferenceClicked(object oData, sap.ui.ux3.SubmitDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:referenceClicked referenceClicked} event of this <code>sap.ui.ux3.FeedChunk</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.FeedChunk</code> itself.
					/// 
					/// Click on a @-reference
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk attachReferenceClicked(sap.ui.ux3.SubmitDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:referenceClicked referenceClicked} event of this <code>sap.ui.ux3.FeedChunk</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.FeedChunk</code> itself.
					/// 
					/// Click on a @-reference
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.FeedChunk</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk attachReferenceClicked(sap.ui.ux3.SubmitDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:referenceClicked referenceClicked} event of this <code>sap.ui.ux3.FeedChunk</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk detachReferenceClicked(sap.ui.ux3.SubmitDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:referenceClicked referenceClicked} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk fireReferenceClicked(sap.ui.ux3.SubmitInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:referenceClicked referenceClicked} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk fireReferenceClicked();

					#endregion

					#region Methods for Event toggleFavorite

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:toggleFavorite toggleFavorite} event of this <code>sap.ui.ux3.FeedChunk</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.FeedChunk</code> itself.
					/// 
					/// Event is raised when the user clicks to set the entry as favorite. This event is not supported for comment chunks.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.FeedChunk</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk attachToggleFavorite(object oData, sap.ui.ux3.FeedChunk.ToggleFavoriteDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:toggleFavorite toggleFavorite} event of this <code>sap.ui.ux3.FeedChunk</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.FeedChunk</code> itself.
					/// 
					/// Event is raised when the user clicks to set the entry as favorite. This event is not supported for comment chunks.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk attachToggleFavorite(object oData, sap.ui.ux3.FeedChunk.ToggleFavoriteDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:toggleFavorite toggleFavorite} event of this <code>sap.ui.ux3.FeedChunk</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.FeedChunk</code> itself.
					/// 
					/// Event is raised when the user clicks to set the entry as favorite. This event is not supported for comment chunks.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk attachToggleFavorite(sap.ui.ux3.FeedChunk.ToggleFavoriteDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:toggleFavorite toggleFavorite} event of this <code>sap.ui.ux3.FeedChunk</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.FeedChunk</code> itself.
					/// 
					/// Event is raised when the user clicks to set the entry as favorite. This event is not supported for comment chunks.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.FeedChunk</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk attachToggleFavorite(sap.ui.ux3.FeedChunk.ToggleFavoriteDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:toggleFavorite toggleFavorite} event of this <code>sap.ui.ux3.FeedChunk</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk detachToggleFavorite(sap.ui.ux3.FeedChunk.ToggleFavoriteDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:toggleFavorite toggleFavorite} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk fireToggleFavorite(sap.ui.ux3.FeedChunk.ToggleFavoriteInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:toggleFavorite toggleFavorite} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk fireToggleFavorite();

					#endregion

					#region Methods for Event inspect

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:inspect inspect} event of this <code>sap.ui.ux3.FeedChunk</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.FeedChunk</code> itself.
					/// 
					/// Event is fired when the inspect button was pressed
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.FeedChunk</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk attachInspect(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:inspect inspect} event of this <code>sap.ui.ux3.FeedChunk</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.FeedChunk</code> itself.
					/// 
					/// Event is fired when the inspect button was pressed
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk attachInspect(object oData, sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:inspect inspect} event of this <code>sap.ui.ux3.FeedChunk</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.FeedChunk</code> itself.
					/// 
					/// Event is fired when the inspect button was pressed
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk attachInspect(sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:inspect inspect} event of this <code>sap.ui.ux3.FeedChunk</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.FeedChunk</code> itself.
					/// 
					/// Event is fired when the inspect button was pressed
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.FeedChunk</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk attachInspect(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:inspect inspect} event of this <code>sap.ui.ux3.FeedChunk</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk detachInspect(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:inspect inspect} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk fireInspect(object mParameters);

					/// <summary>
					/// Fires event {@link #event:inspect inspect} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk fireInspect();

					#endregion

					#region Methods for Event toggleShared

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:toggleShared toggleShared} event of this <code>sap.ui.ux3.FeedChunk</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.FeedChunk</code> itself.
					/// 
					/// Event is raised when the user clicks to share the entry. This event is not supported for comment chunks.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.FeedChunk</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk attachToggleShared(object oData, sap.ui.ux3.FeedChunk.ToggleSharedDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:toggleShared toggleShared} event of this <code>sap.ui.ux3.FeedChunk</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.FeedChunk</code> itself.
					/// 
					/// Event is raised when the user clicks to share the entry. This event is not supported for comment chunks.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk attachToggleShared(object oData, sap.ui.ux3.FeedChunk.ToggleSharedDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:toggleShared toggleShared} event of this <code>sap.ui.ux3.FeedChunk</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.FeedChunk</code> itself.
					/// 
					/// Event is raised when the user clicks to share the entry. This event is not supported for comment chunks.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk attachToggleShared(sap.ui.ux3.FeedChunk.ToggleSharedDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:toggleShared toggleShared} event of this <code>sap.ui.ux3.FeedChunk</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.FeedChunk</code> itself.
					/// 
					/// Event is raised when the user clicks to share the entry. This event is not supported for comment chunks.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.FeedChunk</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk attachToggleShared(sap.ui.ux3.FeedChunk.ToggleSharedDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:toggleShared toggleShared} event of this <code>sap.ui.ux3.FeedChunk</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk detachToggleShared(sap.ui.ux3.FeedChunk.ToggleSharedDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:toggleShared toggleShared} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk fireToggleShared(sap.ui.ux3.FeedChunk.ToggleSharedInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:toggleShared toggleShared} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk fireToggleShared();

					#endregion

					#region Methods for Event actionItemSelected

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:actionItemSelected actionItemSelected} event of this <code>sap.ui.ux3.FeedChunk</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.FeedChunk</code> itself.
					/// 
					/// Event is fired when an item from the action menu button was selected.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.FeedChunk</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk attachActionItemSelected(object oData, sap.ui.ItemSelectedDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:actionItemSelected actionItemSelected} event of this <code>sap.ui.ux3.FeedChunk</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.FeedChunk</code> itself.
					/// 
					/// Event is fired when an item from the action menu button was selected.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk attachActionItemSelected(object oData, sap.ui.ItemSelectedDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:actionItemSelected actionItemSelected} event of this <code>sap.ui.ux3.FeedChunk</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.FeedChunk</code> itself.
					/// 
					/// Event is fired when an item from the action menu button was selected.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk attachActionItemSelected(sap.ui.ItemSelectedDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:actionItemSelected actionItemSelected} event of this <code>sap.ui.ux3.FeedChunk</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.FeedChunk</code> itself.
					/// 
					/// Event is fired when an item from the action menu button was selected.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.FeedChunk</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk attachActionItemSelected(sap.ui.ItemSelectedDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:actionItemSelected actionItemSelected} event of this <code>sap.ui.ux3.FeedChunk</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk detachActionItemSelected(sap.ui.ItemSelectedDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:actionItemSelected actionItemSelected} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk fireActionItemSelected(sap.ui.ItemSelectedInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:actionItemSelected actionItemSelected} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FeedChunk fireActionItemSelected();

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.ux3.FeedChunk with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.ux3.FeedChunk with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.ux3.FeedChunk with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.ux3.FeedChunk.
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
