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
			/// A container that arranges same-size tiles nicely on carousel pages.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.TileContainer")]
			[Obsolete("Deprecated since 1.50. replaced by a container of your choice with {@link sap.m.GenericTile} instances")]
			public partial class TileContainer : sap.ui.core.Control
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
					/// Defines the width of the TileContainer in px.
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> width;

					/// <summary>
					/// Defines the height of the TileContainer in px.
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> height;

					/// <summary>
					/// Determines whether the TileContainer is editable so you can move, delete or add tiles.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> editable;

					/// <summary>
					/// Determines whether the user is allowed to add Tiles in Edit mode (editable = true).
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> allowAdd;

					/// <summary>
					/// The Tiles to be displayed by the TileContainer.
					/// </summary>
					public Union<sap.m.Tile[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> tiles;

					/// <summary>
					/// Fires if a Tile is moved.
					/// </summary>
					public sap.m.TileContainer.TileMoveDelegate tileMove;

					/// <summary>
					/// Fires if a Tile is deleted in Edit mode.
					/// </summary>
					public sap.m.TileContainer.TileDeleteDelegate tileDelete;

					/// <summary>
					/// Fires when a Tile is added.
					/// </summary>
					public sap.ui.@base.EventDelegate tileAdd;

				}

				#endregion

				#region Typed Parameters

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class TileDeleteInfo
				{
					/// <summary>
					/// The deleted Tile.
					/// </summary>
					public sap.m.Tile tile;

				}

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class TileMoveInfo
				{
					/// <summary>
					/// The Tile that has been moved.
					/// </summary>
					public sap.m.Tile tile;

					/// <summary>
					/// The new index of the Tile in the tiles aggregation.
					/// </summary>
					public int newIndex;

				}

				#endregion

				#region Delegates

				public delegate void TileDeleteDelegate(sap.ui.@base.Event<sap.m.TileContainer.TileDeleteInfo> oEvent, object oData);

				public delegate void TileMoveDelegate(sap.ui.@base.Event<sap.m.TileContainer.TileMoveInfo> oEvent, object oData);

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new TileContainer.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern TileContainer(string sId, sap.m.TileContainer.Settings mSettings);

				/// <summary>
				/// Constructor for a new TileContainer.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern TileContainer(string sId);

				/// <summary>
				/// Constructor for a new TileContainer.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern TileContainer();

				/// <summary>
				/// Constructor for a new TileContainer.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern TileContainer(sap.m.TileContainer.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property width

				/// <summary>
				/// Gets current value of property {@link #getWidth width}.
				/// 
				/// Defines the width of the TileContainer in px.
				/// 
				/// Default value is <code>100%</code>.
				/// </summary>
				/// <returns>Value of property <code>width</code></returns>
				public extern virtual sap.ui.core.CSSSize getWidth();

				/// <summary>
				/// Sets a new value for property {@link #getWidth width}.
				/// 
				/// Defines the width of the TileContainer in px.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>100%</code>.
				/// </summary>
				/// <param name="sWidth">New value for property <code>width</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TileContainer setWidth(sap.ui.core.CSSSize sWidth);

				#endregion

				#region Methods for Property height

				/// <summary>
				/// Gets current value of property {@link #getHeight height}.
				/// 
				/// Defines the height of the TileContainer in px.
				/// 
				/// Default value is <code>100%</code>.
				/// </summary>
				/// <returns>Value of property <code>height</code></returns>
				public extern virtual sap.ui.core.CSSSize getHeight();

				/// <summary>
				/// Sets a new value for property {@link #getHeight height}.
				/// 
				/// Defines the height of the TileContainer in px.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>100%</code>.
				/// </summary>
				/// <param name="sHeight">New value for property <code>height</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TileContainer setHeight(sap.ui.core.CSSSize sHeight);

				#endregion

				#region Methods for Property editable

				/// <summary>
				/// Gets current value of property {@link #getEditable editable}.
				/// 
				/// Determines whether the TileContainer is editable so you can move, delete or add tiles.
				/// </summary>
				/// <returns>Value of property <code>editable</code></returns>
				public extern virtual bool getEditable();

				/// <summary>
				/// Sets the editable property to the TileContainer, allowing to move icons. This is currently also set with a long tap.
				/// </summary>
				/// <param name="bValue">Whether the container is in edit mode or not</param>
				/// <returns>this pointer for chaining</returns>
				public extern virtual sap.m.TileContainer setEditable(bool bValue);

				#endregion

				#region Methods for Property allowAdd

				/// <summary>
				/// Gets current value of property {@link #getAllowAdd allowAdd}.
				/// 
				/// Determines whether the user is allowed to add Tiles in Edit mode (editable = true).
				/// </summary>
				/// <returns>Value of property <code>allowAdd</code></returns>
				public extern virtual bool getAllowAdd();

				/// <summary>
				/// Sets a new value for property {@link #getAllowAdd allowAdd}.
				/// 
				/// Determines whether the user is allowed to add Tiles in Edit mode (editable = true).
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="bAllowAdd">New value for property <code>allowAdd</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TileContainer setAllowAdd(bool bAllowAdd);

				#endregion

				#region Methods for Aggregation tiles

				/// <summary>
				/// Gets content of aggregation {@link #getTiles tiles}.
				/// 
				/// The Tiles to be displayed by the TileContainer.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.Tile[] getTiles();

				/// <summary>
				/// Destroys all the tiles in the aggregation {@link #getTiles tiles}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TileContainer destroyTiles();

				/// <summary>
				/// Inserts a Tile to the given index.
				/// </summary>
				/// <param name="oTile">The Tile to insert</param>
				/// <param name="iIndex">The new Tile position in the tiles aggregation</param>
				/// <returns>this pointer for chaining</returns>
				public extern virtual sap.m.TileContainer insertTile(sap.m.Tile oTile, int iIndex);

				/// <summary>
				/// Adds a Tile to the end of the tiles collection.
				/// </summary>
				/// <param name="oTile">The tile to add</param>
				/// <returns>this pointer for chaining</returns>
				public extern virtual sap.m.TileContainer addTile(sap.m.Tile oTile);

				/// <summary>
				/// Removes a tile from the aggregation {@link #getTiles tiles}.
				/// </summary>
				/// <param name="vTile">The tile to remove or its index or id</param>
				/// <returns>The removed tile or <code>null</code></returns>
				public extern virtual sap.m.Tile removeTile(Union<int, string, sap.m.Tile> vTile);

				/// <summary>
				/// Checks for the provided <code>sap.m.Tile</code> in the aggregation {@link #getTiles tiles}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oTile">The tile whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfTile(sap.m.Tile oTile);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getTiles tiles}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.m.Tile[] removeAllTiles();

				#endregion

				#region Methods for Event tileMove

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:tileMove tileMove} event of this <code>sap.m.TileContainer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.TileContainer</code> itself.
				/// 
				/// Fires if a Tile is moved.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.TileContainer</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TileContainer attachTileMove(object oData, sap.m.TileContainer.TileMoveDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:tileMove tileMove} event of this <code>sap.m.TileContainer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.TileContainer</code> itself.
				/// 
				/// Fires if a Tile is moved.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TileContainer attachTileMove(object oData, sap.m.TileContainer.TileMoveDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:tileMove tileMove} event of this <code>sap.m.TileContainer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.TileContainer</code> itself.
				/// 
				/// Fires if a Tile is moved.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TileContainer attachTileMove(sap.m.TileContainer.TileMoveDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:tileMove tileMove} event of this <code>sap.m.TileContainer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.TileContainer</code> itself.
				/// 
				/// Fires if a Tile is moved.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.TileContainer</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TileContainer attachTileMove(sap.m.TileContainer.TileMoveDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:tileMove tileMove} event of this <code>sap.m.TileContainer</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TileContainer detachTileMove(sap.m.TileContainer.TileMoveDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:tileMove tileMove} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TileContainer fireTileMove(sap.m.TileContainer.TileMoveInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:tileMove tileMove} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TileContainer fireTileMove();

				#endregion

				#region Methods for Event tileDelete

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:tileDelete tileDelete} event of this <code>sap.m.TileContainer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.TileContainer</code> itself.
				/// 
				/// Fires if a Tile is deleted in Edit mode.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.TileContainer</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TileContainer attachTileDelete(object oData, sap.m.TileContainer.TileDeleteDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:tileDelete tileDelete} event of this <code>sap.m.TileContainer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.TileContainer</code> itself.
				/// 
				/// Fires if a Tile is deleted in Edit mode.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TileContainer attachTileDelete(object oData, sap.m.TileContainer.TileDeleteDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:tileDelete tileDelete} event of this <code>sap.m.TileContainer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.TileContainer</code> itself.
				/// 
				/// Fires if a Tile is deleted in Edit mode.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TileContainer attachTileDelete(sap.m.TileContainer.TileDeleteDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:tileDelete tileDelete} event of this <code>sap.m.TileContainer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.TileContainer</code> itself.
				/// 
				/// Fires if a Tile is deleted in Edit mode.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.TileContainer</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TileContainer attachTileDelete(sap.m.TileContainer.TileDeleteDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:tileDelete tileDelete} event of this <code>sap.m.TileContainer</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TileContainer detachTileDelete(sap.m.TileContainer.TileDeleteDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:tileDelete tileDelete} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TileContainer fireTileDelete(sap.m.TileContainer.TileDeleteInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:tileDelete tileDelete} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TileContainer fireTileDelete();

				#endregion

				#region Methods for Event tileAdd

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:tileAdd tileAdd} event of this <code>sap.m.TileContainer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.TileContainer</code> itself.
				/// 
				/// Fires when a Tile is added.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.TileContainer</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TileContainer attachTileAdd(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:tileAdd tileAdd} event of this <code>sap.m.TileContainer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.TileContainer</code> itself.
				/// 
				/// Fires when a Tile is added.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TileContainer attachTileAdd(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:tileAdd tileAdd} event of this <code>sap.m.TileContainer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.TileContainer</code> itself.
				/// 
				/// Fires when a Tile is added.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TileContainer attachTileAdd(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:tileAdd tileAdd} event of this <code>sap.m.TileContainer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.TileContainer</code> itself.
				/// 
				/// Fires when a Tile is added.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.TileContainer</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TileContainer attachTileAdd(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:tileAdd tileAdd} event of this <code>sap.m.TileContainer</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TileContainer detachTileAdd(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:tileAdd tileAdd} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TileContainer fireTileAdd(object mParameters);

				/// <summary>
				/// Fires event {@link #event:tileAdd tileAdd} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TileContainer fireTileAdd();

				#endregion

				#region Other methods

				/// <summary>
				/// Deletes a Tile.
				/// </summary>
				/// <param name="oTile">The tile to move</param>
				/// <returns>this pointer for chaining</returns>
				public extern virtual sap.m.TileContainer deleteTile(sap.m.Tile oTile);

				/// <summary>
				/// Creates a new subclass of class sap.m.TileContainer with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.TileContainer with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.TileContainer with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.TileContainer.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				/// <summary>
				/// Returns the index of the first Tile visible in the current page.
				/// </summary>
				/// <returns>The index of the first Tile that is visible in the current page</returns>
				public extern virtual int getPageFirstTileIndex();

				/// <summary>
				/// Moves a given Tile to the given index.
				/// </summary>
				/// <param name="vTile">The tile to move</param>
				/// <param name="iNewIndex">The new Tile position in the tiles aggregation</param>
				/// <returns>this pointer for chaining</returns>
				public extern virtual sap.m.TileContainer moveTile(sap.m.Tile vTile, int iNewIndex);

				/// <summary>
				/// Scrolls to the page where the given Tile or tile index is included. Optionally this can be done animated or not. With IE9 the scroll is never animated.
				/// </summary>
				/// <param name="vTile">The Tile or tile index to be scrolled into view</param>
				/// <param name="bAnimated">Whether the scroll should be animated</param>
				/// <param name="aVisibleTiles">optional list of visible tiles in order to avoid filtering them again.</param>
				public extern virtual void scrollIntoView(Union<sap.m.Tile, int> vTile, bool bAnimated, sap.m.Tile[] aVisibleTiles);

				/// <summary>
				/// Scrolls to the page where the given Tile or tile index is included. Optionally this can be done animated or not. With IE9 the scroll is never animated.
				/// </summary>
				/// <param name="vTile">The Tile or tile index to be scrolled into view</param>
				/// <param name="bAnimated">Whether the scroll should be animated</param>
				public extern virtual void scrollIntoView(Union<sap.m.Tile, int> vTile, bool bAnimated);

				/// <summary>
				/// Scrolls one page to the left.
				/// </summary>
				public extern virtual void scrollLeft();

				/// <summary>
				/// Scrolls one page to the right.
				/// </summary>
				public extern virtual void scrollRight();

				#endregion

				#endregion

			}
		}
	}
}
