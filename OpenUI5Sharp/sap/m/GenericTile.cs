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
			/// <summary>
			/// Displays header, subheader, and a customizable main area in a tile format. Since 1.44, also an in-line format which contains only header and subheader is supported.
			/// </summary>
			[External]
			[Namespace(false)]
			public partial class GenericTile : sap.ui.core.Control
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
					/// The mode of the GenericTile.
					/// </summary>
					public Union<sap.m.GenericTileMode, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> mode;

					/// <summary>
					/// The header of the tile.
					/// </summary>
					public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> header;

					/// <summary>
					/// The subheader of the tile.
					/// </summary>
					public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> subheader;

					/// <summary>
					/// The message that appears when the control is in the Failed state.
					/// </summary>
					public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> failedText;

					/// <summary>
					/// The size of the tile. If not set, then the default size is applied based on the device.
					/// </summary>
					public Union<sap.m.Size, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> size;

					/// <summary>
					/// The frame type: OneByOne or TwoByOne. Set to OneByOne as default if no property is defined or set to Auto by the app.
					/// </summary>
					public Union<sap.m.FrameType, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> frameType;

					/// <summary>
					/// The URI of the background image.
					/// </summary>
					public Union<sap.ui.core.URI, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> backgroundImage;

					/// <summary>
					/// The image to be displayed as a graphical element within the header. This can be an image or an icon from the icon font.
					/// </summary>
					public Union<sap.ui.core.URI, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> headerImage;

					/// <summary>
					/// The load status.
					/// </summary>
					public Union<sap.m.LoadState, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> state;

					/// <summary>
					/// Description of a header image that is used in the tooltip.
					/// </summary>
					public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> imageDescription;

					/// <summary>
					/// Changes the visualization in order to enable additional actions with the Generic Tile.
					/// </summary>
					public Union<sap.m.GenericTileScope, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> scope;

					/// <summary>
					/// If set to <code>TileSizeBehavior.Small</code>, the tile size is the same as it would be on a small-screened phone (374px wide and lower), regardless of the screen size of the actual device being used. If set to <code>TileSizeBehavior.Responsive</code>, the tile size adapts to the size of the screen.
					/// </summary>
					public Union<sap.m.TileSizeBehavior, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> sizeBehavior;

					/// <summary>
					/// Additional description for aria-label. The aria-label is rendered before the standard aria-label.
					/// </summary>
					public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> ariaLabel;

					/// <summary>
					/// The content of the tile.
					/// </summary>
					public Union<sap.m.TileContent[], string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> tileContent;

					/// <summary>
					/// An icon or image to be displayed in the control. This aggregation is deprecated since version 1.36.0, to display an icon or image use sap.m.ImageContent control instead.
					/// </summary>
					public Union<sap.ui.core.Control, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> icon;

					/// <summary>
					/// The event is triggered when the user presses the tile.
					/// </summary>
					public sap.m.TilePressDelegate press;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new sap.m.GenericTile control.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">initial settings for the new control</param>
				public extern GenericTile(string sId, sap.m.GenericTile.Settings mSettings);

				/// <summary>
				/// Constructor for a new sap.m.GenericTile control.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern GenericTile(string sId);

				/// <summary>
				/// Constructor for a new sap.m.GenericTile control.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern GenericTile();

				/// <summary>
				/// Constructor for a new sap.m.GenericTile control.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">initial settings for the new control</param>
				public extern GenericTile(sap.m.GenericTile.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property mode

				/// <summary>
				/// Gets current value of property {@link #getMode mode}.
				/// 
				/// The mode of the GenericTile.
				/// 
				/// Default value is <code>ContentMode</code>.
				/// </summary>
				/// <returns>Value of property <code>mode</code></returns>
				public extern virtual sap.m.GenericTileMode getMode();

				/// <summary>
				/// Sets a new value for property {@link #getMode mode}.
				/// 
				/// The mode of the GenericTile.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>ContentMode</code>.
				/// </summary>
				/// <param name="sMode">New value for property <code>mode</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.GenericTile setMode(sap.m.GenericTileMode sMode);

				#endregion

				#region Methods for Property header

				/// <summary>
				/// Gets current value of property {@link #getHeader header}.
				/// 
				/// The header of the tile.
				/// </summary>
				/// <returns>Value of property <code>header</code></returns>
				public extern virtual string getHeader();

				/// <summary>
				/// Sets a new value for property {@link #getHeader header}.
				/// 
				/// The header of the tile.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sHeader">New value for property <code>header</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.GenericTile setHeader(string sHeader);

				#endregion

				#region Methods for Property subheader

				/// <summary>
				/// Gets current value of property {@link #getSubheader subheader}.
				/// 
				/// The subheader of the tile.
				/// </summary>
				/// <returns>Value of property <code>subheader</code></returns>
				public extern virtual string getSubheader();

				/// <summary>
				/// Sets a new value for property {@link #getSubheader subheader}.
				/// 
				/// The subheader of the tile.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sSubheader">New value for property <code>subheader</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.GenericTile setSubheader(string sSubheader);

				#endregion

				#region Methods for Property failedText

				/// <summary>
				/// Gets current value of property {@link #getFailedText failedText}.
				/// 
				/// The message that appears when the control is in the Failed state.
				/// </summary>
				/// <returns>Value of property <code>failedText</code></returns>
				public extern virtual string getFailedText();

				/// <summary>
				/// Sets a new value for property {@link #getFailedText failedText}.
				/// 
				/// The message that appears when the control is in the Failed state.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sFailedText">New value for property <code>failedText</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.GenericTile setFailedText(string sFailedText);

				#endregion

				#region Methods for Property size

				/// <summary>
				/// Gets current value of property {@link #getSize size}.
				/// 
				/// The size of the tile. If not set, then the default size is applied based on the device.
				/// 
				/// Default value is <code>Auto</code>.
				/// </summary>
				[Obsolete("Deprecated since 1.38.0. The GenericTile control has now a fixed size, depending on the used media (desktop, tablet or phone).")]
				/// <returns>Value of property <code>size</code></returns>
				public extern virtual sap.m.Size getSize();

				/// <summary>
				/// Sets a new value for property {@link #getSize size}.
				/// 
				/// The size of the tile. If not set, then the default size is applied based on the device.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Auto</code>.
				/// </summary>
				[Obsolete("Deprecated since 1.38.0. The GenericTile control has now a fixed size, depending on the used media (desktop, tablet or phone).")]
				/// <param name="sSize">New value for property <code>size</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.GenericTile setSize(sap.m.Size sSize);

				#endregion

				#region Methods for Property frameType

				/// <summary>
				/// Gets current value of property {@link #getFrameType frameType}.
				/// 
				/// The frame type: OneByOne or TwoByOne. Set to OneByOne as default if no property is defined or set to Auto by the app.
				/// 
				/// Default value is <code>OneByOne</code>.
				/// </summary>
				/// <returns>Value of property <code>frameType</code></returns>
				public extern virtual sap.m.FrameType getFrameType();

				/// <summary>
				/// Sets a new value for property {@link #getFrameType frameType}.
				/// 
				/// The frame type: OneByOne or TwoByOne. Set to OneByOne as default if no property is defined or set to Auto by the app.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>OneByOne</code>.
				/// </summary>
				/// <param name="sFrameType">New value for property <code>frameType</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.GenericTile setFrameType(sap.m.FrameType sFrameType);

				#endregion

				#region Methods for Property backgroundImage

				/// <summary>
				/// Gets current value of property {@link #getBackgroundImage backgroundImage}.
				/// 
				/// The URI of the background image.
				/// </summary>
				/// <returns>Value of property <code>backgroundImage</code></returns>
				public extern virtual sap.ui.core.URI getBackgroundImage();

				/// <summary>
				/// Sets a new value for property {@link #getBackgroundImage backgroundImage}.
				/// 
				/// The URI of the background image.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sBackgroundImage">New value for property <code>backgroundImage</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.GenericTile setBackgroundImage(sap.ui.core.URI sBackgroundImage);

				#endregion

				#region Methods for Property headerImage

				/// <summary>
				/// Gets current value of property {@link #getHeaderImage headerImage}.
				/// 
				/// The image to be displayed as a graphical element within the header. This can be an image or an icon from the icon font.
				/// </summary>
				/// <returns>Value of property <code>headerImage</code></returns>
				public extern virtual sap.ui.core.URI getHeaderImage();

				/// <summary>
				/// Sets a new value for property {@link #getHeaderImage headerImage}.
				/// 
				/// The image to be displayed as a graphical element within the header. This can be an image or an icon from the icon font.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sHeaderImage">New value for property <code>headerImage</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.GenericTile setHeaderImage(sap.ui.core.URI sHeaderImage);

				#endregion

				#region Methods for Property state

				/// <summary>
				/// Gets current value of property {@link #getState state}.
				/// 
				/// The load status.
				/// 
				/// Default value is <code>Loaded</code>.
				/// </summary>
				/// <returns>Value of property <code>state</code></returns>
				public extern virtual sap.m.LoadState getState();

				/// <summary>
				/// Sets a new value for property {@link #getState state}.
				/// 
				/// The load status.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Loaded</code>.
				/// </summary>
				/// <param name="sState">New value for property <code>state</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.GenericTile setState(sap.m.LoadState sState);

				#endregion

				#region Methods for Property imageDescription

				/// <summary>
				/// Gets current value of property {@link #getImageDescription imageDescription}.
				/// 
				/// Description of a header image that is used in the tooltip.
				/// </summary>
				/// <returns>Value of property <code>imageDescription</code></returns>
				public extern virtual string getImageDescription();

				/// <summary>
				/// Sets a new value for property {@link #getImageDescription imageDescription}.
				/// 
				/// Description of a header image that is used in the tooltip.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sImageDescription">New value for property <code>imageDescription</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.GenericTile setImageDescription(string sImageDescription);

				#endregion

				#region Methods for Property scope

				/// <summary>
				/// Gets current value of property {@link #getScope scope}.
				/// 
				/// Changes the visualization in order to enable additional actions with the Generic Tile.
				/// 
				/// Default value is <code>Display</code>.
				/// </summary>
				/// <returns>Value of property <code>scope</code></returns>
				public extern virtual sap.m.GenericTileScope getScope();

				/// <summary>
				/// Sets a new value for property {@link #getScope scope}.
				/// 
				/// Changes the visualization in order to enable additional actions with the Generic Tile.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Display</code>.
				/// </summary>
				/// <param name="sScope">New value for property <code>scope</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.GenericTile setScope(sap.m.GenericTileScope sScope);

				#endregion

				#region Methods for Property sizeBehavior

				/// <summary>
				/// Gets current value of property {@link #getSizeBehavior sizeBehavior}.
				/// 
				/// If set to <code>TileSizeBehavior.Small</code>, the tile size is the same as it would be on a small-screened phone (374px wide and lower), regardless of the screen size of the actual device being used. If set to <code>TileSizeBehavior.Responsive</code>, the tile size adapts to the size of the screen.
				/// 
				/// Default value is <code>Responsive</code>.
				/// </summary>
				/// <returns>Value of property <code>sizeBehavior</code></returns>
				public extern virtual sap.m.TileSizeBehavior getSizeBehavior();

				/// <summary>
				/// Sets a new value for property {@link #getSizeBehavior sizeBehavior}.
				/// 
				/// If set to <code>TileSizeBehavior.Small</code>, the tile size is the same as it would be on a small-screened phone (374px wide and lower), regardless of the screen size of the actual device being used. If set to <code>TileSizeBehavior.Responsive</code>, the tile size adapts to the size of the screen.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Responsive</code>.
				/// </summary>
				/// <param name="sSizeBehavior">New value for property <code>sizeBehavior</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.GenericTile setSizeBehavior(sap.m.TileSizeBehavior sSizeBehavior);

				#endregion

				#region Methods for Property ariaLabel

				/// <summary>
				/// Gets current value of property {@link #getAriaLabel ariaLabel}.
				/// 
				/// Additional description for aria-label. The aria-label is rendered before the standard aria-label.
				/// </summary>
				/// <returns>Value of property <code>ariaLabel</code></returns>
				public extern virtual string getAriaLabel();

				/// <summary>
				/// Sets a new value for property {@link #getAriaLabel ariaLabel}.
				/// 
				/// Additional description for aria-label. The aria-label is rendered before the standard aria-label.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sAriaLabel">New value for property <code>ariaLabel</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.GenericTile setAriaLabel(string sAriaLabel);

				#endregion

				#region Methods for Aggregation tileContent

				/// <summary>
				/// Gets content of aggregation {@link #getTileContent tileContent}.
				/// 
				/// The content of the tile.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.TileContent[] getTileContent();

				/// <summary>
				/// Destroys all the tileContent in the aggregation {@link #getTileContent tileContent}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.GenericTile destroyTileContent();

				/// <summary>
				/// Inserts a tileContent into the aggregation {@link #getTileContent tileContent}.
				/// </summary>
				/// <param name="oTileContent">The tileContent to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the tileContent should be inserted at; for a negative value of <code>iIndex</code>, the tileContent is inserted at position 0; for a value greater than the current size of the aggregation, the tileContent is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.GenericTile insertTileContent(sap.m.TileContent oTileContent, int iIndex);

				/// <summary>
				/// Adds some tileContent to the aggregation {@link #getTileContent tileContent}.
				/// </summary>
				/// <param name="oTileContent">The tileContent to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.GenericTile addTileContent(sap.m.TileContent oTileContent);

				/// <summary>
				/// Removes a tileContent from the aggregation {@link #getTileContent tileContent}.
				/// </summary>
				/// <param name="vTileContent">The tileContent to remove or its index or id</param>
				/// <returns>The removed tileContent or <code>null</code></returns>
				public extern virtual sap.m.TileContent removeTileContent(Union<int, string, sap.m.TileContent> vTileContent);

				/// <summary>
				/// Checks for the provided <code>sap.m.TileContent</code> in the aggregation {@link #getTileContent tileContent}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oTileContent">The tileContent whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfTileContent(sap.m.TileContent oTileContent);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getTileContent tileContent}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.m.TileContent[] removeAllTileContent();

				/// <summary>
				/// Binds aggregation {@link #getTileContent tileContent} to model data.
				/// 
				/// See {@link sap.ui.base.ManagedObject#bindAggregation ManagedObject.bindAggregation} for a detailed description of the possible properties of <code>oBindingInfo</code>.
				/// </summary>
				/// <param name="oBindingInfo">The binding information</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.GenericTile bindTileContent(object oBindingInfo);

				/// <summary>
				/// Unbinds aggregation {@link #getTileContent tileContent} from model data.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.GenericTile unbindTileContent();

				#endregion

				#region Methods for Aggregation icon

				/// <summary>
				/// Gets content of aggregation {@link #getIcon icon}.
				/// 
				/// An icon or image to be displayed in the control. This aggregation is deprecated since version 1.36.0, to display an icon or image use sap.m.ImageContent control instead.
				/// </summary>
				[Obsolete("Deprecated since 1.36.0. This aggregation is deprecated, use sap.m.ImageContent control to display an icon instead.")]
				/// <returns></returns>
				public extern virtual sap.ui.core.Control getIcon();

				/// <summary>
				/// Destroys the icon in the aggregation {@link #getIcon icon}.
				/// </summary>
				[Obsolete("Deprecated since 1.36.0. This aggregation is deprecated, use sap.m.ImageContent control to display an icon instead.")]
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.GenericTile destroyIcon();

				/// <summary>
				/// Sets the aggregated {@link #getIcon icon}.
				/// </summary>
				[Obsolete("Deprecated since 1.36.0. This aggregation is deprecated, use sap.m.ImageContent control to display an icon instead.")]
				/// <param name="oIcon">The icon to set</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.GenericTile setIcon(sap.ui.core.Control oIcon);

				#endregion

				#region Methods for Aggregation _titleText

				#endregion

				#region Methods for Aggregation _failedMessageText

				#endregion

				#region Methods for Event press

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:press press} event of this <code>sap.m.GenericTile</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.GenericTile</code> itself.
				/// 
				/// The event is triggered when the user presses the tile.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.GenericTile</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.GenericTile attachPress(object oData, sap.m.TilePressDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:press press} event of this <code>sap.m.GenericTile</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.GenericTile</code> itself.
				/// 
				/// The event is triggered when the user presses the tile.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.GenericTile attachPress(object oData, sap.m.TilePressDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:press press} event of this <code>sap.m.GenericTile</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.GenericTile</code> itself.
				/// 
				/// The event is triggered when the user presses the tile.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.GenericTile attachPress(sap.m.TilePressDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:press press} event of this <code>sap.m.GenericTile</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.GenericTile</code> itself.
				/// 
				/// The event is triggered when the user presses the tile.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.GenericTile</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.GenericTile attachPress(sap.m.TilePressDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:press press} event of this <code>sap.m.GenericTile</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.GenericTile detachPress(sap.m.TilePressDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:press press} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.GenericTile firePress(sap.m.TilePressInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:press press} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.GenericTile firePress();

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.GenericTile with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.GenericTile with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.GenericTile with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Provides an interface to the tile's layout information consistent in all modes and content densities.
				/// </summary>
				/// <returns>An array containing all of the tile's bounding rectangles</returns>
				public extern virtual object[] getBoundingRects();

				/// <summary>
				/// Returns a metadata object for class sap.m.GenericTile.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				/// <summary>
				/// Provides an interface to switch on or off the tile's press event. Used in SlideTile for Actions scope.
				/// </summary>
				/// <param name="value">If set to true, the press event of the tile is active.</param>
				public extern virtual void setPressEnabled(bool value);

				/// <summary>
				/// Shows the actions scope view of GenericTile without changing the scope. Used in SlideTile for Actions scope.
				/// </summary>
				/// <param name="value">If set to true, actions view is showed.</param>
				public extern virtual void showActionsView(bool value);

				#endregion

				#endregion

			}
		}
	}
}
