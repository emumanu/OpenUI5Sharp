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
			/// The control that displays multiple GenericTile controls as changing slides.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.SlideTile")]
			public partial class SlideTile : sap.ui.core.Control
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
					/// The time of the slide display in milliseconds.
					/// </summary>
					public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> displayTime;

					/// <summary>
					/// The time of the slide changing in milliseconds.
					/// </summary>
					public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> transitionTime;

					/// <summary>
					/// Changes the visualization in order to enable additional actions with the SlideTile control.
					/// </summary>
					public Union<sap.m.GenericTileScope, string, sap.ui.@base.ManagedObject.BindPropertyInfo> scope;

					/// <summary>
					/// If set to <code>TileSizeBehavior.Small</code>, the tile size is the same as it would be on a small-screened phone (374px wide and lower), regardless of the screen size of the actual device being used. If set to <code>TileSizeBehavior.Responsive</code>, the tile size adapts to the size of the screen. This property has to be set consistently for the <code>SlideTile</code> along with all its inner <code>GenericTile</code> elements, so that they match one another visually.
					/// </summary>
					public Union<sap.m.TileSizeBehavior, string, sap.ui.@base.ManagedObject.BindPropertyInfo> sizeBehavior;

					/// <summary>
					/// The set of Generic Tiles to be shown in the control.
					/// </summary>
					public Union<sap.m.GenericTile[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> tiles;

					/// <summary>
					/// The event is fired when the user chooses the tile. The event is available only in Actions scope.
					/// </summary>
					public sap.m.TilePressDelegate press;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new sap.m.SlideTile control.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">id for the new control, generated automatically if no id is given</param>
				/// <param name="mSettings">initial settings for the new control</param>
				public extern SlideTile(string sId, sap.m.SlideTile.Settings mSettings);

				/// <summary>
				/// Constructor for a new sap.m.SlideTile control.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">id for the new control, generated automatically if no id is given</param>
				public extern SlideTile(string sId);

				/// <summary>
				/// Constructor for a new sap.m.SlideTile control.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern SlideTile();

				/// <summary>
				/// Constructor for a new sap.m.SlideTile control.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">initial settings for the new control</param>
				public extern SlideTile(sap.m.SlideTile.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property displayTime

				/// <summary>
				/// Gets current value of property {@link #getDisplayTime displayTime}.
				/// 
				/// The time of the slide display in milliseconds.
				/// 
				/// Default value is <code>5000</code>.
				/// </summary>
				/// <returns>Value of property <code>displayTime</code></returns>
				public extern virtual int getDisplayTime();

				/// <summary>
				/// Sets a new value for property {@link #getDisplayTime displayTime}.
				/// 
				/// The time of the slide display in milliseconds.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>5000</code>.
				/// </summary>
				/// <param name="iDisplayTime">New value for property <code>displayTime</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SlideTile setDisplayTime(int iDisplayTime);

				#endregion

				#region Methods for Property transitionTime

				/// <summary>
				/// Gets current value of property {@link #getTransitionTime transitionTime}.
				/// 
				/// The time of the slide changing in milliseconds.
				/// 
				/// Default value is <code>500</code>.
				/// </summary>
				/// <returns>Value of property <code>transitionTime</code></returns>
				public extern virtual int getTransitionTime();

				/// <summary>
				/// Sets a new value for property {@link #getTransitionTime transitionTime}.
				/// 
				/// The time of the slide changing in milliseconds.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>500</code>.
				/// </summary>
				/// <param name="iTransitionTime">New value for property <code>transitionTime</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SlideTile setTransitionTime(int iTransitionTime);

				#endregion

				#region Methods for Property scope

				/// <summary>
				/// Gets current value of property {@link #getScope scope}.
				/// 
				/// Changes the visualization in order to enable additional actions with the SlideTile control.
				/// 
				/// Default value is <code>Display</code>.
				/// </summary>
				/// <returns>Value of property <code>scope</code></returns>
				public extern virtual sap.m.GenericTileScope getScope();

				/// <summary>
				/// Sets a new value for property {@link #getScope scope}.
				/// 
				/// Changes the visualization in order to enable additional actions with the SlideTile control.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Display</code>.
				/// </summary>
				/// <param name="sScope">New value for property <code>scope</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SlideTile setScope(sap.m.GenericTileScope sScope);

				#endregion

				#region Methods for Property sizeBehavior

				/// <summary>
				/// Gets current value of property {@link #getSizeBehavior sizeBehavior}.
				/// 
				/// If set to <code>TileSizeBehavior.Small</code>, the tile size is the same as it would be on a small-screened phone (374px wide and lower), regardless of the screen size of the actual device being used. If set to <code>TileSizeBehavior.Responsive</code>, the tile size adapts to the size of the screen. This property has to be set consistently for the <code>SlideTile</code> along with all its inner <code>GenericTile</code> elements, so that they match one another visually.
				/// 
				/// Default value is <code>Responsive</code>.
				/// </summary>
				/// <returns>Value of property <code>sizeBehavior</code></returns>
				public extern virtual sap.m.TileSizeBehavior getSizeBehavior();

				/// <summary>
				/// Sets a new value for property {@link #getSizeBehavior sizeBehavior}.
				/// 
				/// If set to <code>TileSizeBehavior.Small</code>, the tile size is the same as it would be on a small-screened phone (374px wide and lower), regardless of the screen size of the actual device being used. If set to <code>TileSizeBehavior.Responsive</code>, the tile size adapts to the size of the screen. This property has to be set consistently for the <code>SlideTile</code> along with all its inner <code>GenericTile</code> elements, so that they match one another visually.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Responsive</code>.
				/// </summary>
				/// <param name="sSizeBehavior">New value for property <code>sizeBehavior</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SlideTile setSizeBehavior(sap.m.TileSizeBehavior sSizeBehavior);

				#endregion

				#region Methods for Aggregation tiles

				/// <summary>
				/// Gets content of aggregation {@link #getTiles tiles}.
				/// 
				/// The set of Generic Tiles to be shown in the control.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.GenericTile[] getTiles();

				/// <summary>
				/// Destroys all the tiles in the aggregation {@link #getTiles tiles}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SlideTile destroyTiles();

				/// <summary>
				/// Inserts a tile into the aggregation {@link #getTiles tiles}.
				/// </summary>
				/// <param name="oTile">The tile to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the tile should be inserted at; for a negative value of <code>iIndex</code>, the tile is inserted at position 0; for a value greater than the current size of the aggregation, the tile is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SlideTile insertTile(sap.m.GenericTile oTile, int iIndex);

				/// <summary>
				/// Adds some tile to the aggregation {@link #getTiles tiles}.
				/// </summary>
				/// <param name="oTile">The tile to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SlideTile addTile(sap.m.GenericTile oTile);

				/// <summary>
				/// Removes a tile from the aggregation {@link #getTiles tiles}.
				/// </summary>
				/// <param name="vTile">The tile to remove or its index or id</param>
				/// <returns>The removed tile or <code>null</code></returns>
				public extern virtual sap.m.GenericTile removeTile(Union<int, string, sap.m.GenericTile> vTile);

				/// <summary>
				/// Checks for the provided <code>sap.m.GenericTile</code> in the aggregation {@link #getTiles tiles}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oTile">The tile whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfTile(sap.m.GenericTile oTile);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getTiles tiles}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.m.GenericTile[] removeAllTiles();

				/// <summary>
				/// Binds aggregation {@link #getTiles tiles} to model data.
				/// 
				/// See {@link sap.ui.base.ManagedObject#bindAggregation ManagedObject.bindAggregation} for a detailed description of the possible properties of <code>oBindingInfo</code>.
				/// </summary>
				/// <param name="oBindingInfo">The binding information</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SlideTile bindTiles(sap.ui.@base.ManagedObject.BindAggregationInfo oBindingInfo);

				/// <summary>
				/// Unbinds aggregation {@link #getTiles tiles} from model data.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SlideTile unbindTiles();

				#endregion

				#region Methods for Aggregation _pausePlayIcon

				#endregion

				#region Methods for Event press

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:press press} event of this <code>sap.m.SlideTile</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SlideTile</code> itself.
				/// 
				/// The event is fired when the user chooses the tile. The event is available only in Actions scope.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.SlideTile</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SlideTile attachPress(object oData, sap.m.TilePressDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:press press} event of this <code>sap.m.SlideTile</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SlideTile</code> itself.
				/// 
				/// The event is fired when the user chooses the tile. The event is available only in Actions scope.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SlideTile attachPress(object oData, sap.m.TilePressDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:press press} event of this <code>sap.m.SlideTile</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SlideTile</code> itself.
				/// 
				/// The event is fired when the user chooses the tile. The event is available only in Actions scope.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SlideTile attachPress(sap.m.TilePressDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:press press} event of this <code>sap.m.SlideTile</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SlideTile</code> itself.
				/// 
				/// The event is fired when the user chooses the tile. The event is available only in Actions scope.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.SlideTile</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SlideTile attachPress(sap.m.TilePressDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:press press} event of this <code>sap.m.SlideTile</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SlideTile detachPress(sap.m.TilePressDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:press press} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SlideTile firePress(sap.m.TilePressInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:press press} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SlideTile firePress();

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.SlideTile with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.SlideTile with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.SlideTile with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.SlideTile.
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
