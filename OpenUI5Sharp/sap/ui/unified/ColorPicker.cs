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
			public static partial class unified
			{
				/// <summary>
				/// Enables the user to select a color. The color can be defined using HEX, RGB, or HSV values or a CSS color name.
				/// 
				/// <b>Note:</b> Keep in mind that this control needs either <code>sap.m</code> or <code>sap.ui.commons</code> library to be loaded in order to work as it depends on controls available in one or the other library.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.unified.ColorPicker")]
				public partial class ColorPicker : sap.ui.core.Control
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
						/// Determines the input parameter that can be a string of type HEX, RGB, HSV, or a CSS color name: <ul> <li>HEX - #FFFFFF</li> <li>RGB - rgb(255,255,255)</li> <li>HSV - hsv(360,100,100)</li> <li>CSS - red</li> </ul> <b>Note:</b> The output parameter is an RGB string of the current color.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> colorString;

						/// <summary>
						/// Determines the color mode of the <code>ColorPicker</code>.
						/// </summary>
						public Union<sap.ui.unified.ColorPickerMode, string, sap.ui.@base.ManagedObject.BindPropertyInfo> mode;

						/// <summary>
						/// Determines the display mode of the <code>ColorPicker</code> among three types - Default, Large and Simplified
						/// </summary>
						public Union<sap.ui.unified.ColorPickerDisplayMode, string, sap.ui.@base.ManagedObject.BindPropertyInfo> displayMode;

						/// <summary>
						/// Fired when the value is changed by user action.
						/// 
						/// <b>Note:</b> When the user action is mouse dragging, the <code>change</code> event fires on the mouseup event.
						/// </summary>
						public sap.ui.unified.ColorPicker.ChangeDelegate change;

						/// <summary>
						/// Fired when the value is changed during the mouse move.
						/// 
						/// <b>Note:</b> When the user action is mouse move, the <code>liveChange</code> event is fired during the mousedown event.
						/// </summary>
						public sap.ui.unified.ColorPicker.ChangeDelegate liveChange;

					}

					#endregion

					#region Typed Parameters

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class ChangeInfo
					{
						/// <summary>
						/// Parameter containing the RED value (0-255).
						/// </summary>
						public int r;

						/// <summary>
						/// Parameter containing the GREEN value (0-255).
						/// </summary>
						public int g;

						/// <summary>
						/// Parameter containing the BLUE value (0-255).
						/// </summary>
						public int b;

						/// <summary>
						/// Parameter containing the HUE value (0-360).
						/// </summary>
						public int h;

						/// <summary>
						/// Parameter containing the SATURATION value (0-100).
						/// </summary>
						public int s;

						/// <summary>
						/// Parameter containing the VALUE value (0-100).
						/// </summary>
						public int v;

						/// <summary>
						/// Parameter containing the LIGHTNESS value (0-100).
						/// </summary>
						public int l;

						/// <summary>
						/// Parameter containing the Hexadecimal string (#FFFFFF).
						/// </summary>
						public string hex;

						/// <summary>
						/// Parameter containing the alpha value (transparency).
						/// </summary>
						public string alpha;

					}

					#endregion

					#region Delegates

					public delegate void ChangeDelegate(sap.ui.@base.Event<sap.ui.unified.ColorPicker.ChangeInfo> oEvent, object oData);

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new <code>ColorPicker</code>.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern ColorPicker(string sId, sap.ui.unified.ColorPicker.Settings mSettings);

					/// <summary>
					/// Constructor for a new <code>ColorPicker</code>.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					public extern ColorPicker(string sId);

					/// <summary>
					/// Constructor for a new <code>ColorPicker</code>.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern ColorPicker();

					/// <summary>
					/// Constructor for a new <code>ColorPicker</code>.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern ColorPicker(sap.ui.unified.ColorPicker.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property colorString

					/// <summary>
					/// Gets current value of property {@link #getColorString colorString}.
					/// 
					/// Determines the input parameter that can be a string of type HEX, RGB, HSV, or a CSS color name: <ul> <li>HEX - #FFFFFF</li> <li>RGB - rgb(255,255,255)</li> <li>HSV - hsv(360,100,100)</li> <li>CSS - red</li> </ul> <b>Note:</b> The output parameter is an RGB string of the current color.
					/// </summary>
					/// <returns>Value of property <code>colorString</code></returns>
					public extern virtual string getColorString();

					/// <summary>
					/// Sets a new value for property {@link #getColorString colorString}.
					/// 
					/// Determines the input parameter that can be a string of type HEX, RGB, HSV, or a CSS color name: <ul> <li>HEX - #FFFFFF</li> <li>RGB - rgb(255,255,255)</li> <li>HSV - hsv(360,100,100)</li> <li>CSS - red</li> </ul> <b>Note:</b> The output parameter is an RGB string of the current color.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sColorString">New value for property <code>colorString</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.ColorPicker setColorString(string sColorString);

					#endregion

					#region Methods for Property mode

					/// <summary>
					/// Gets current value of property {@link #getMode mode}.
					/// 
					/// Determines the color mode of the <code>ColorPicker</code>.
					/// 
					/// Default value is <code>HSV</code>.
					/// </summary>
					/// <returns>Value of property <code>mode</code></returns>
					public extern virtual sap.ui.unified.ColorPickerMode getMode();

					/// <summary>
					/// Setter for <code>mode</code> property.
					/// </summary>
					/// <param name="sMode">control mode enum</param>
					/// <param name="bSuppressInvalidate">should control invalidation be suppressed</param>
					public extern virtual void setMode(sap.ui.unified.ColorPickerMode sMode, bool bSuppressInvalidate);

					#endregion

					#region Methods for Property displayMode

					/// <summary>
					/// Gets current value of property {@link #getDisplayMode displayMode}.
					/// 
					/// Determines the display mode of the <code>ColorPicker</code> among three types - Default, Large and Simplified
					/// 
					/// Default value is <code>Default</code>.
					/// </summary>
					/// <returns>Value of property <code>displayMode</code></returns>
					public extern virtual sap.ui.unified.ColorPickerDisplayMode getDisplayMode();

					/// <summary>
					/// Setter for <code>displayMode</code> property.
					/// </summary>
					/// <param name="sDisplayMode">control displayMode enum</param>
					public extern virtual void setDisplayMode(sap.ui.unified.ColorPickerDisplayMode sDisplayMode);

					#endregion

					#region Methods for Aggregation _grid

					#endregion

					#region Methods for Aggregation _invisibleTexts

					#endregion

					#region Methods for Event change

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:change change} event of this <code>sap.ui.unified.ColorPicker</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.ColorPicker</code> itself.
					/// 
					/// Fired when the value is changed by user action.
					/// 
					/// <b>Note:</b> When the user action is mouse dragging, the <code>change</code> event fires on the mouseup event.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.ColorPicker</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.ColorPicker attachChange(object oData, sap.ui.unified.ColorPicker.ChangeDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:change change} event of this <code>sap.ui.unified.ColorPicker</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.ColorPicker</code> itself.
					/// 
					/// Fired when the value is changed by user action.
					/// 
					/// <b>Note:</b> When the user action is mouse dragging, the <code>change</code> event fires on the mouseup event.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.ColorPicker attachChange(object oData, sap.ui.unified.ColorPicker.ChangeDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:change change} event of this <code>sap.ui.unified.ColorPicker</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.ColorPicker</code> itself.
					/// 
					/// Fired when the value is changed by user action.
					/// 
					/// <b>Note:</b> When the user action is mouse dragging, the <code>change</code> event fires on the mouseup event.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.ColorPicker attachChange(sap.ui.unified.ColorPicker.ChangeDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:change change} event of this <code>sap.ui.unified.ColorPicker</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.ColorPicker</code> itself.
					/// 
					/// Fired when the value is changed by user action.
					/// 
					/// <b>Note:</b> When the user action is mouse dragging, the <code>change</code> event fires on the mouseup event.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.ColorPicker</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.ColorPicker attachChange(sap.ui.unified.ColorPicker.ChangeDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:change change} event of this <code>sap.ui.unified.ColorPicker</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.ColorPicker detachChange(sap.ui.unified.ColorPicker.ChangeDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:change change} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.ColorPicker fireChange(sap.ui.unified.ColorPicker.ChangeInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:change change} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.ColorPicker fireChange();

					#endregion

					#region Methods for Event liveChange

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:liveChange liveChange} event of this <code>sap.ui.unified.ColorPicker</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.ColorPicker</code> itself.
					/// 
					/// Fired when the value is changed during the mouse move.
					/// 
					/// <b>Note:</b> When the user action is mouse move, the <code>liveChange</code> event is fired during the mousedown event.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.ColorPicker</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.ColorPicker attachLiveChange(object oData, sap.ui.unified.ColorPicker.ChangeDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:liveChange liveChange} event of this <code>sap.ui.unified.ColorPicker</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.ColorPicker</code> itself.
					/// 
					/// Fired when the value is changed during the mouse move.
					/// 
					/// <b>Note:</b> When the user action is mouse move, the <code>liveChange</code> event is fired during the mousedown event.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.ColorPicker attachLiveChange(object oData, sap.ui.unified.ColorPicker.ChangeDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:liveChange liveChange} event of this <code>sap.ui.unified.ColorPicker</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.ColorPicker</code> itself.
					/// 
					/// Fired when the value is changed during the mouse move.
					/// 
					/// <b>Note:</b> When the user action is mouse move, the <code>liveChange</code> event is fired during the mousedown event.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.ColorPicker attachLiveChange(sap.ui.unified.ColorPicker.ChangeDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:liveChange liveChange} event of this <code>sap.ui.unified.ColorPicker</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.ColorPicker</code> itself.
					/// 
					/// Fired when the value is changed during the mouse move.
					/// 
					/// <b>Note:</b> When the user action is mouse move, the <code>liveChange</code> event is fired during the mousedown event.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.ColorPicker</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.ColorPicker attachLiveChange(sap.ui.unified.ColorPicker.ChangeDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:liveChange liveChange} event of this <code>sap.ui.unified.ColorPicker</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.ColorPicker detachLiveChange(sap.ui.unified.ColorPicker.ChangeDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:liveChange liveChange} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.ColorPicker fireLiveChange(sap.ui.unified.ColorPicker.ChangeInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:liveChange liveChange} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.ColorPicker fireLiveChange();

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.unified.ColorPicker with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.unified.ColorPicker with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.unified.ColorPicker with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.unified.ColorPicker.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					[Name("getMetadata")]
					public extern static sap.ui.@base.Metadata getMetadataStatic();

					/// <summary>
					/// Gets current RGB values.
					/// </summary>
					/// <returns>Containing current RGB values</returns>
					public extern virtual object getRGB();

					/// <summary>
					/// Checks the validity of the CSS color string.
					/// </summary>
					/// <param name="sColorString">CSS color string to be validated</param>
					/// <returns>If the passed string is a valid CSS color string</returns>
					public extern virtual bool isColor(string sColorString);

					#endregion

					#endregion

				}
			}
		}
	}
}
