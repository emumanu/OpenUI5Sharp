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
				/// A container control representing a full feed page, including feeder and updates.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.ux3.Feed")]
				[Obsolete("Deprecated since 1.38. Instead, use <b>any</b> <code>sap.ui.layout</code> container control.")]
				public partial class Feed : sap.ui.core.Control
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
						/// The path to the thumbnail image used for the feeder
						/// </summary>
						public Union<sap.ui.core.URI, string, sap.ui.@base.ManagedObject.BindPropertyInfo> feederThumbnailSrc;

						/// <summary>
						/// The sender of the feeder
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> feederSender;

						/// <summary>
						/// Specifies whether the feed shall be in live mode
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> live;

						/// <summary>
						/// Title text of the Feed. If no text is entered "FEED" is displayed.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> title;

						/// <summary>
						/// Items of the filter
						/// </summary>
						public Union<sap.ui.core.ListItem[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> filterItems;

						/// <summary>
						/// The chunks
						/// </summary>
						public Union<sap.ui.ux3.FeedChunk[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> chunks;

						/// <summary>
						/// MenuItems to open when the tool button is clicked by the user
						/// </summary>
						public Union<sap.ui.commons.MenuItem[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> toolsMenuItems;

						/// <summary>
						/// Event is fired when the filter is changed
						/// </summary>
						public sap.ui.ux3.ChangeDelegate filterChange;

						/// <summary>
						/// Event is fired when the search function on SearchField is triggered
						/// </summary>
						public sap.ui.SearchDelegate search;

						/// <summary>
						/// Event is fired when a new chunk is added
						/// </summary>
						public sap.ui.ux3.Feed.ChunkAddedDelegate chunkAdded;

						/// <summary>
						/// Event is fired when an item from the tools MenuButton was selected
						/// </summary>
						public sap.ui.ItemSelectedDelegate toolsItemSelected;

						/// <summary>
						/// Event is fired when the live mode has changed
						/// </summary>
						public sap.ui.ux3.Feed.ToggleLiveDelegate toggleLive;

					}

					#endregion

					#region Typed Parameters

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class ChunkAddedInfo
					{
						/// <summary>
						/// New chunk
						/// </summary>
						public sap.ui.ux3.FeedChunk chunk;

					}

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class ToggleLiveInfo
					{
						/// <summary>
						/// Current live indicator
						/// </summary>
						public bool live;

					}

					#endregion

					#region Delegates

					public delegate void ChunkAddedDelegate(sap.ui.@base.Event<sap.ui.ux3.Feed.ChunkAddedInfo> oEvent, object oData);

					public delegate void ToggleLiveDelegate(sap.ui.@base.Event<sap.ui.ux3.Feed.ToggleLiveInfo> oEvent, object oData);

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new Feed.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern Feed(string sId, sap.ui.ux3.Feed.Settings mSettings);

					/// <summary>
					/// Constructor for a new Feed.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern Feed(string sId);

					/// <summary>
					/// Constructor for a new Feed.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern Feed();

					/// <summary>
					/// Constructor for a new Feed.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern Feed(sap.ui.ux3.Feed.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property feederThumbnailSrc

					/// <summary>
					/// Gets current value of property {@link #getFeederThumbnailSrc feederThumbnailSrc}.
					/// 
					/// The path to the thumbnail image used for the feeder
					/// </summary>
					/// <returns>Value of property <code>feederThumbnailSrc</code></returns>
					public extern virtual sap.ui.core.URI getFeederThumbnailSrc();

					/// <summary>
					/// Sets a new value for property {@link #getFeederThumbnailSrc feederThumbnailSrc}.
					/// 
					/// The path to the thumbnail image used for the feeder
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sFeederThumbnailSrc">New value for property <code>feederThumbnailSrc</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Feed setFeederThumbnailSrc(sap.ui.core.URI sFeederThumbnailSrc);

					#endregion

					#region Methods for Property feederSender

					/// <summary>
					/// Gets current value of property {@link #getFeederSender feederSender}.
					/// 
					/// The sender of the feeder
					/// </summary>
					/// <returns>Value of property <code>feederSender</code></returns>
					public extern virtual string getFeederSender();

					/// <summary>
					/// Sets a new value for property {@link #getFeederSender feederSender}.
					/// 
					/// The sender of the feeder
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sFeederSender">New value for property <code>feederSender</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Feed setFeederSender(string sFeederSender);

					#endregion

					#region Methods for Property live

					/// <summary>
					/// Gets current value of property {@link #getLive live}.
					/// 
					/// Specifies whether the feed shall be in live mode
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>live</code></returns>
					public extern virtual bool getLive();

					/// <summary>
					/// Sets a new value for property {@link #getLive live}.
					/// 
					/// Specifies whether the feed shall be in live mode
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bLive">New value for property <code>live</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Feed setLive(bool bLive);

					#endregion

					#region Methods for Property title

					/// <summary>
					/// Gets current value of property {@link #getTitle title}.
					/// 
					/// Title text of the Feed. If no text is entered "FEED" is displayed.
					/// </summary>
					/// <returns>Value of property <code>title</code></returns>
					public extern virtual string getTitle();

					/// <summary>
					/// Sets a new value for property {@link #getTitle title}.
					/// 
					/// Title text of the Feed. If no text is entered "FEED" is displayed.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sTitle">New value for property <code>title</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Feed setTitle(string sTitle);

					#endregion

					#region Methods for Aggregation filterItems

					/// <summary>
					/// Gets content of aggregation {@link #getFilterItems filterItems}.
					/// 
					/// Items of the filter
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.ListItem[] getFilterItems();

					/// <summary>
					/// Destroys all the filterItems in the aggregation {@link #getFilterItems filterItems}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Feed destroyFilterItems();

					/// <summary>
					/// Inserts a filterItem into the aggregation {@link #getFilterItems filterItems}.
					/// </summary>
					/// <param name="oFilterItem">The filterItem to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the filterItem should be inserted at; for a negative value of <code>iIndex</code>, the filterItem is inserted at position 0; for a value greater than the current size of the aggregation, the filterItem is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Feed insertFilterItem(sap.ui.core.ListItem oFilterItem, int iIndex);

					/// <summary>
					/// Adds some filterItem to the aggregation {@link #getFilterItems filterItems}.
					/// </summary>
					/// <param name="oFilterItem">The filterItem to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Feed addFilterItem(sap.ui.core.ListItem oFilterItem);

					/// <summary>
					/// Removes a filterItem from the aggregation {@link #getFilterItems filterItems}.
					/// </summary>
					/// <param name="vFilterItem">The filterItem to remove or its index or id</param>
					/// <returns>The removed filterItem or <code>null</code></returns>
					public extern virtual sap.ui.core.ListItem removeFilterItem(Union<int, string, sap.ui.core.ListItem> vFilterItem);

					/// <summary>
					/// Checks for the provided <code>sap.ui.core.ListItem</code> in the aggregation {@link #getFilterItems filterItems}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oFilterItem">The filterItem whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfFilterItem(sap.ui.core.ListItem oFilterItem);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getFilterItems filterItems}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.core.ListItem[] removeAllFilterItems();

					/// <summary>
					/// Binds aggregation {@link #getFilterItems filterItems} to model data.
					/// 
					/// See {@link sap.ui.base.ManagedObject#bindAggregation ManagedObject.bindAggregation} for a detailed description of the possible properties of <code>oBindingInfo</code>.
					/// </summary>
					/// <param name="oBindingInfo">The binding information</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Feed bindFilterItems(object oBindingInfo);

					/// <summary>
					/// Unbinds aggregation {@link #getFilterItems filterItems} from model data.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Feed unbindFilterItems();

					#endregion

					#region Methods for Aggregation chunks

					/// <summary>
					/// Gets content of aggregation {@link #getChunks chunks}.
					/// 
					/// The chunks
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.ux3.FeedChunk[] getChunks();

					/// <summary>
					/// Destroys all the chunks in the aggregation {@link #getChunks chunks}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Feed destroyChunks();

					/// <summary>
					/// Inserts a chunk into the aggregation {@link #getChunks chunks}.
					/// </summary>
					/// <param name="oChunk">The chunk to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the chunk should be inserted at; for a negative value of <code>iIndex</code>, the chunk is inserted at position 0; for a value greater than the current size of the aggregation, the chunk is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Feed insertChunk(sap.ui.ux3.FeedChunk oChunk, int iIndex);

					/// <summary>
					/// Adds some chunk to the aggregation {@link #getChunks chunks}.
					/// </summary>
					/// <param name="oChunk">The chunk to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Feed addChunk(sap.ui.ux3.FeedChunk oChunk);

					/// <summary>
					/// Removes a chunk from the aggregation {@link #getChunks chunks}.
					/// </summary>
					/// <param name="vChunk">The chunk to remove or its index or id</param>
					/// <returns>The removed chunk or <code>null</code></returns>
					public extern virtual sap.ui.ux3.FeedChunk removeChunk(Union<int, string, sap.ui.ux3.FeedChunk> vChunk);

					/// <summary>
					/// Checks for the provided <code>sap.ui.ux3.FeedChunk</code> in the aggregation {@link #getChunks chunks}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oChunk">The chunk whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfChunk(sap.ui.ux3.FeedChunk oChunk);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getChunks chunks}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.ux3.FeedChunk[] removeAllChunks();

					/// <summary>
					/// Binds aggregation {@link #getChunks chunks} to model data.
					/// 
					/// See {@link sap.ui.base.ManagedObject#bindAggregation ManagedObject.bindAggregation} for a detailed description of the possible properties of <code>oBindingInfo</code>.
					/// </summary>
					/// <param name="oBindingInfo">The binding information</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Feed bindChunks(object oBindingInfo);

					/// <summary>
					/// Unbinds aggregation {@link #getChunks chunks} from model data.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Feed unbindChunks();

					#endregion

					#region Methods for Aggregation toolsMenuItems

					/// <summary>
					/// Gets content of aggregation {@link #getToolsMenuItems toolsMenuItems}.
					/// 
					/// MenuItems to open when the tool button is clicked by the user
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.commons.MenuItem[] getToolsMenuItems();

					/// <summary>
					/// Destroys all the toolsMenuItems in the aggregation {@link #getToolsMenuItems toolsMenuItems}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Feed destroyToolsMenuItems();

					/// <summary>
					/// Inserts a toolsMenuItem into the aggregation {@link #getToolsMenuItems toolsMenuItems}.
					/// </summary>
					/// <param name="oToolsMenuItem">The toolsMenuItem to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the toolsMenuItem should be inserted at; for a negative value of <code>iIndex</code>, the toolsMenuItem is inserted at position 0; for a value greater than the current size of the aggregation, the toolsMenuItem is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Feed insertToolsMenuItem(sap.ui.commons.MenuItem oToolsMenuItem, int iIndex);

					/// <summary>
					/// Adds some toolsMenuItem to the aggregation {@link #getToolsMenuItems toolsMenuItems}.
					/// </summary>
					/// <param name="oToolsMenuItem">The toolsMenuItem to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Feed addToolsMenuItem(sap.ui.commons.MenuItem oToolsMenuItem);

					/// <summary>
					/// Removes a toolsMenuItem from the aggregation {@link #getToolsMenuItems toolsMenuItems}.
					/// </summary>
					/// <param name="vToolsMenuItem">The toolsMenuItem to remove or its index or id</param>
					/// <returns>The removed toolsMenuItem or <code>null</code></returns>
					public extern virtual sap.ui.commons.MenuItem removeToolsMenuItem(Union<int, string, sap.ui.commons.MenuItem> vToolsMenuItem);

					/// <summary>
					/// Checks for the provided <code>sap.ui.commons.MenuItem</code> in the aggregation {@link #getToolsMenuItems toolsMenuItems}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oToolsMenuItem">The toolsMenuItem whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfToolsMenuItem(sap.ui.commons.MenuItem oToolsMenuItem);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getToolsMenuItems toolsMenuItems}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.commons.MenuItem[] removeAllToolsMenuItems();

					/// <summary>
					/// Binds aggregation {@link #getToolsMenuItems toolsMenuItems} to model data.
					/// 
					/// See {@link sap.ui.base.ManagedObject#bindAggregation ManagedObject.bindAggregation} for a detailed description of the possible properties of <code>oBindingInfo</code>.
					/// </summary>
					/// <param name="oBindingInfo">The binding information</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Feed bindToolsMenuItems(object oBindingInfo);

					/// <summary>
					/// Unbinds aggregation {@link #getToolsMenuItems toolsMenuItems} from model data.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Feed unbindToolsMenuItems();

					#endregion

					#region Methods for Event filterChange

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:filterChange filterChange} event of this <code>sap.ui.ux3.Feed</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.Feed</code> itself.
					/// 
					/// Event is fired when the filter is changed
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.Feed</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Feed attachFilterChange(object oData, sap.ui.ux3.ChangeDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:filterChange filterChange} event of this <code>sap.ui.ux3.Feed</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.Feed</code> itself.
					/// 
					/// Event is fired when the filter is changed
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Feed attachFilterChange(object oData, sap.ui.ux3.ChangeDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:filterChange filterChange} event of this <code>sap.ui.ux3.Feed</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.Feed</code> itself.
					/// 
					/// Event is fired when the filter is changed
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Feed attachFilterChange(sap.ui.ux3.ChangeDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:filterChange filterChange} event of this <code>sap.ui.ux3.Feed</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.Feed</code> itself.
					/// 
					/// Event is fired when the filter is changed
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.Feed</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Feed attachFilterChange(sap.ui.ux3.ChangeDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:filterChange filterChange} event of this <code>sap.ui.ux3.Feed</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Feed detachFilterChange(sap.ui.ux3.ChangeDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:filterChange filterChange} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Feed fireFilterChange(sap.ui.ux3.ChangeInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:filterChange filterChange} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Feed fireFilterChange();

					#endregion

					#region Methods for Event search

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:search search} event of this <code>sap.ui.ux3.Feed</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.Feed</code> itself.
					/// 
					/// Event is fired when the search function on SearchField is triggered
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.Feed</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Feed attachSearch(object oData, sap.ui.SearchDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:search search} event of this <code>sap.ui.ux3.Feed</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.Feed</code> itself.
					/// 
					/// Event is fired when the search function on SearchField is triggered
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Feed attachSearch(object oData, sap.ui.SearchDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:search search} event of this <code>sap.ui.ux3.Feed</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.Feed</code> itself.
					/// 
					/// Event is fired when the search function on SearchField is triggered
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Feed attachSearch(sap.ui.SearchDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:search search} event of this <code>sap.ui.ux3.Feed</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.Feed</code> itself.
					/// 
					/// Event is fired when the search function on SearchField is triggered
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.Feed</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Feed attachSearch(sap.ui.SearchDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:search search} event of this <code>sap.ui.ux3.Feed</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Feed detachSearch(sap.ui.SearchDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:search search} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Feed fireSearch(sap.ui.SearchInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:search search} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Feed fireSearch();

					#endregion

					#region Methods for Event chunkAdded

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:chunkAdded chunkAdded} event of this <code>sap.ui.ux3.Feed</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.Feed</code> itself.
					/// 
					/// Event is fired when a new chunk is added
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.Feed</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Feed attachChunkAdded(object oData, sap.ui.ux3.Feed.ChunkAddedDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:chunkAdded chunkAdded} event of this <code>sap.ui.ux3.Feed</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.Feed</code> itself.
					/// 
					/// Event is fired when a new chunk is added
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Feed attachChunkAdded(object oData, sap.ui.ux3.Feed.ChunkAddedDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:chunkAdded chunkAdded} event of this <code>sap.ui.ux3.Feed</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.Feed</code> itself.
					/// 
					/// Event is fired when a new chunk is added
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Feed attachChunkAdded(sap.ui.ux3.Feed.ChunkAddedDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:chunkAdded chunkAdded} event of this <code>sap.ui.ux3.Feed</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.Feed</code> itself.
					/// 
					/// Event is fired when a new chunk is added
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.Feed</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Feed attachChunkAdded(sap.ui.ux3.Feed.ChunkAddedDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:chunkAdded chunkAdded} event of this <code>sap.ui.ux3.Feed</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Feed detachChunkAdded(sap.ui.ux3.Feed.ChunkAddedDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:chunkAdded chunkAdded} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Feed fireChunkAdded(sap.ui.ux3.Feed.ChunkAddedInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:chunkAdded chunkAdded} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Feed fireChunkAdded();

					#endregion

					#region Methods for Event toolsItemSelected

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:toolsItemSelected toolsItemSelected} event of this <code>sap.ui.ux3.Feed</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.Feed</code> itself.
					/// 
					/// Event is fired when an item from the tools MenuButton was selected
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.Feed</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Feed attachToolsItemSelected(object oData, sap.ui.ItemSelectedDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:toolsItemSelected toolsItemSelected} event of this <code>sap.ui.ux3.Feed</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.Feed</code> itself.
					/// 
					/// Event is fired when an item from the tools MenuButton was selected
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Feed attachToolsItemSelected(object oData, sap.ui.ItemSelectedDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:toolsItemSelected toolsItemSelected} event of this <code>sap.ui.ux3.Feed</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.Feed</code> itself.
					/// 
					/// Event is fired when an item from the tools MenuButton was selected
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Feed attachToolsItemSelected(sap.ui.ItemSelectedDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:toolsItemSelected toolsItemSelected} event of this <code>sap.ui.ux3.Feed</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.Feed</code> itself.
					/// 
					/// Event is fired when an item from the tools MenuButton was selected
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.Feed</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Feed attachToolsItemSelected(sap.ui.ItemSelectedDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:toolsItemSelected toolsItemSelected} event of this <code>sap.ui.ux3.Feed</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Feed detachToolsItemSelected(sap.ui.ItemSelectedDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:toolsItemSelected toolsItemSelected} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Feed fireToolsItemSelected(sap.ui.ItemSelectedInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:toolsItemSelected toolsItemSelected} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Feed fireToolsItemSelected();

					#endregion

					#region Methods for Event toggleLive

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:toggleLive toggleLive} event of this <code>sap.ui.ux3.Feed</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.Feed</code> itself.
					/// 
					/// Event is fired when the live mode has changed
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.Feed</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Feed attachToggleLive(object oData, sap.ui.ux3.Feed.ToggleLiveDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:toggleLive toggleLive} event of this <code>sap.ui.ux3.Feed</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.Feed</code> itself.
					/// 
					/// Event is fired when the live mode has changed
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Feed attachToggleLive(object oData, sap.ui.ux3.Feed.ToggleLiveDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:toggleLive toggleLive} event of this <code>sap.ui.ux3.Feed</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.Feed</code> itself.
					/// 
					/// Event is fired when the live mode has changed
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Feed attachToggleLive(sap.ui.ux3.Feed.ToggleLiveDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:toggleLive toggleLive} event of this <code>sap.ui.ux3.Feed</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.Feed</code> itself.
					/// 
					/// Event is fired when the live mode has changed
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.Feed</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Feed attachToggleLive(sap.ui.ux3.Feed.ToggleLiveDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:toggleLive toggleLive} event of this <code>sap.ui.ux3.Feed</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Feed detachToggleLive(sap.ui.ux3.Feed.ToggleLiveDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:toggleLive toggleLive} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Feed fireToggleLive(sap.ui.ux3.Feed.ToggleLiveInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:toggleLive toggleLive} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Feed fireToggleLive();

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.ux3.Feed with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.ux3.Feed with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.ux3.Feed with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.ux3.Feed.
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
