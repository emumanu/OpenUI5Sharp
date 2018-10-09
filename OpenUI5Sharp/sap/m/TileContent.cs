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
			/// This control is used within the GenericTile control.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.TileContent")]
			public partial class TileContent : sap.ui.core.Control
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
					/// The footer text of the tile.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> footer;

					/// <summary>
					/// The semantic color of the footer.
					/// </summary>
					public Union<sap.m.ValueColor, string, sap.ui.@base.ManagedObject.BindPropertyInfo> footerColor;

					/// <summary>
					/// Updates the size of the tile. If it is not set, then the default size is applied based on the device tile.
					/// </summary>
					public Union<sap.m.Size, string, sap.ui.@base.ManagedObject.BindPropertyInfo> size;

					/// <summary>
					/// The percent sign, the currency symbol, or the unit of measure.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> unit;

					/// <summary>
					/// Disables control if true.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> disabled;

					/// <summary>
					/// Frame types: 1x1, 2x1, and auto.
					/// </summary>
					public Union<sap.m.FrameType, string, sap.ui.@base.ManagedObject.BindPropertyInfo> frameType;

					/// <summary>
					/// The switchable view that depends on the tile type.
					/// </summary>
					public Union<sap.ui.core.Control, string, sap.ui.@base.ManagedObject.BindAggregationInfo> content;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new sap.m.TileContent control.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">id for the new control, generated automatically if no id is given</param>
				/// <param name="mSettings">initial settings for the new control</param>
				public extern TileContent(string sId, sap.m.TileContent.Settings mSettings);

				/// <summary>
				/// Constructor for a new sap.m.TileContent control.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">id for the new control, generated automatically if no id is given</param>
				public extern TileContent(string sId);

				/// <summary>
				/// Constructor for a new sap.m.TileContent control.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern TileContent();

				/// <summary>
				/// Constructor for a new sap.m.TileContent control.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">initial settings for the new control</param>
				public extern TileContent(sap.m.TileContent.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property footer

				/// <summary>
				/// Gets current value of property {@link #getFooter footer}.
				/// 
				/// The footer text of the tile.
				/// </summary>
				/// <returns>Value of property <code>footer</code></returns>
				public extern virtual string getFooter();

				/// <summary>
				/// Sets a new value for property {@link #getFooter footer}.
				/// 
				/// The footer text of the tile.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sFooter">New value for property <code>footer</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TileContent setFooter(string sFooter);

				#endregion

				#region Methods for Property footerColor

				/// <summary>
				/// Gets current value of property {@link #getFooterColor footerColor}.
				/// 
				/// The semantic color of the footer.
				/// 
				/// Default value is <code>Neutral</code>.
				/// </summary>
				/// <returns>Value of property <code>footerColor</code></returns>
				public extern virtual sap.m.ValueColor getFooterColor();

				/// <summary>
				/// Sets a new value for property {@link #getFooterColor footerColor}.
				/// 
				/// The semantic color of the footer.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Neutral</code>.
				/// </summary>
				/// <param name="sFooterColor">New value for property <code>footerColor</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TileContent setFooterColor(sap.m.ValueColor sFooterColor);

				#endregion

				#region Methods for Property size

				/// <summary>
				/// Gets current value of property {@link #getSize size}.
				/// 
				/// Updates the size of the tile. If it is not set, then the default size is applied based on the device tile.
				/// 
				/// Default value is <code>Auto</code>.
				/// </summary>
				/// <returns>Value of property <code>size</code></returns>
				[Obsolete("Deprecated since 1.38.0. The TileContent control has now a fixed size, depending on the used media (desktop, tablet or phone).")]
				public extern virtual sap.m.Size getSize();

				/// <summary>
				/// Sets a new value for property {@link #getSize size}.
				/// 
				/// Updates the size of the tile. If it is not set, then the default size is applied based on the device tile.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Auto</code>.
				/// </summary>
				/// <param name="sSize">New value for property <code>size</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.38.0. The TileContent control has now a fixed size, depending on the used media (desktop, tablet or phone).")]
				public extern virtual sap.m.TileContent setSize(sap.m.Size sSize);

				#endregion

				#region Methods for Property unit

				/// <summary>
				/// Gets current value of property {@link #getUnit unit}.
				/// 
				/// The percent sign, the currency symbol, or the unit of measure.
				/// </summary>
				/// <returns>Value of property <code>unit</code></returns>
				public extern virtual string getUnit();

				/// <summary>
				/// Sets a new value for property {@link #getUnit unit}.
				/// 
				/// The percent sign, the currency symbol, or the unit of measure.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sUnit">New value for property <code>unit</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TileContent setUnit(string sUnit);

				#endregion

				#region Methods for Property disabled

				/// <summary>
				/// Gets current value of property {@link #getDisabled disabled}.
				/// 
				/// Disables control if true.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>disabled</code></returns>
				public extern virtual bool getDisabled();

				/// <summary>
				/// Sets a new value for property {@link #getDisabled disabled}.
				/// 
				/// Disables control if true.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bDisabled">New value for property <code>disabled</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TileContent setDisabled(bool bDisabled);

				#endregion

				#region Methods for Property frameType

				/// <summary>
				/// Gets current value of property {@link #getFrameType frameType}.
				/// 
				/// Frame types: 1x1, 2x1, and auto.
				/// 
				/// Default value is <code>Auto</code>.
				/// </summary>
				/// <returns>Value of property <code>frameType</code></returns>
				public extern virtual sap.m.FrameType getFrameType();

				/// <summary>
				/// Sets a new value for property {@link #getFrameType frameType}.
				/// 
				/// Frame types: 1x1, 2x1, and auto.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Auto</code>.
				/// </summary>
				/// <param name="sFrameType">New value for property <code>frameType</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TileContent setFrameType(sap.m.FrameType sFrameType);

				#endregion

				#region Methods for Aggregation content

				/// <summary>
				/// Gets content of aggregation {@link #getContent content}.
				/// 
				/// The switchable view that depends on the tile type.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.Control getContent();

				/// <summary>
				/// Destroys the content in the aggregation {@link #getContent content}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TileContent destroyContent();

				/// <summary>
				/// Sets the aggregated {@link #getContent content}.
				/// </summary>
				/// <param name="oContent">The content to set</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TileContent setContent(sap.ui.core.Control oContent);

				/// <summary>
				/// Binds aggregation {@link #getContent content} to model data.
				/// 
				/// See {@link sap.ui.base.ManagedObject#bindAggregation ManagedObject.bindAggregation} for a detailed description of the possible properties of <code>oBindingInfo</code>.
				/// </summary>
				/// <param name="oBindingInfo">The binding information</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TileContent bindContent(object oBindingInfo);

				/// <summary>
				/// Unbinds aggregation {@link #getContent content} from model data.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TileContent unbindContent();

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.TileContent with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.TileContent with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.TileContent with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.TileContent.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				/// <summary>
				/// Setter for protected property to enable or disable content rendering. This function does not invalidate the control.
				/// </summary>
				/// <param name="value">Determines whether the control's content is rendered or not</param>
				/// <returns>this To allow method chaining</returns>
				public extern virtual sap.m.TileContent setRenderContent(bool value);

				/// <summary>
				/// Setter for protected property to enable or disable footer rendering. This function does not invalidate the control.
				/// </summary>
				/// <param name="value">Determines whether the control's footer is rendered or not</param>
				/// <returns>this to allow method chaining</returns>
				public extern virtual sap.m.TileContent setRenderFooter(bool value);

				#endregion

				#endregion

			}
		}
	}
}
