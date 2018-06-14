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
			/// Shows numeric values used for example in tiles colored according to their meaning and displays deviations.
			/// </summary>
			[External]
			[Namespace(false)]
			public partial class NumericContent : sap.ui.core.Control
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
					/// If set to true, the change of the value will be animated.
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> animateTextChange;

					/// <summary>
					/// If set to true, the value parameter contains a numeric value and scale. If set to false (default), the value parameter contains a numeric value only.
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> formatterValue;

					/// <summary>
					/// The icon to be displayed as a graphical element within the control. This can be an image or an icon from the icon font.
					/// </summary>
					public Union<sap.ui.core.URI, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> icon;

					/// <summary>
					/// Description of an icon that is used in the tooltip.
					/// </summary>
					public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> iconDescription;

					/// <summary>
					/// The indicator arrow that shows value deviation.
					/// </summary>
					public Union<sap.m.DeviationIndicator, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> indicator;

					/// <summary>
					/// If set to true, the omitted value property is set to 0.
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> nullifyValue;

					/// <summary>
					/// The scaling prefix. Financial characters can be used for currencies and counters. The SI prefixes can be used for units. If the scaling prefix contains more than three characters, only the first three characters are displayed.
					/// </summary>
					public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> scale;

					/// <summary>
					/// Updates the size of the control. If not set, then the default size is applied based on the device tile.
					/// </summary>
					public Union<sap.m.Size, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> size;

					/// <summary>
					/// The number of characters of the <code>value</code> property to display.
					/// </summary>
					public Union<int, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> truncateValueTo;

					/// <summary>
					/// The actual value.
					/// </summary>
					public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> value;

					/// <summary>
					/// The semantic color of the value.
					/// </summary>
					public Union<sap.m.ValueColor, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> valueColor;

					/// <summary>
					/// The width of the control. If it is not set, the size of the control is defined by the 'size' property.
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> width;

					/// <summary>
					/// If the value is set to false, the content is adjusted to the whole size of the control.
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> withMargin;

					/// <summary>
					/// Indicates the load status.
					/// </summary>
					public Union<sap.m.LoadState, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> state;

					/// <summary>
					/// The event is fired when the user chooses the numeric content.
					/// </summary>
					public sap.ui.@base.EventDelegate press;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new sap.m.GenericTile control.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">id for the new control, generated automatically if no id is given</param>
				/// <param name="mSettings">initial settings for the new control</param>
				public extern NumericContent(string sId, sap.m.NumericContent.Settings mSettings);

				/// <summary>
				/// Constructor for a new sap.m.GenericTile control.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">id for the new control, generated automatically if no id is given</param>
				public extern NumericContent(string sId);

				/// <summary>
				/// Constructor for a new sap.m.GenericTile control.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern NumericContent();

				/// <summary>
				/// Constructor for a new sap.m.GenericTile control.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">initial settings for the new control</param>
				public extern NumericContent(sap.m.NumericContent.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property animateTextChange

				/// <summary>
				/// Gets current value of property {@link #getAnimateTextChange animateTextChange}.
				/// 
				/// If set to true, the change of the value will be animated.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>animateTextChange</code></returns>
				public extern virtual bool getAnimateTextChange();

				/// <summary>
				/// Sets a new value for property {@link #getAnimateTextChange animateTextChange}.
				/// 
				/// If set to true, the change of the value will be animated.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bAnimateTextChange">New value for property <code>animateTextChange</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.NumericContent setAnimateTextChange(bool bAnimateTextChange);

				#endregion

				#region Methods for Property formatterValue

				/// <summary>
				/// Gets current value of property {@link #getFormatterValue formatterValue}.
				/// 
				/// If set to true, the value parameter contains a numeric value and scale. If set to false (default), the value parameter contains a numeric value only.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>formatterValue</code></returns>
				public extern virtual bool getFormatterValue();

				/// <summary>
				/// Sets a new value for property {@link #getFormatterValue formatterValue}.
				/// 
				/// If set to true, the value parameter contains a numeric value and scale. If set to false (default), the value parameter contains a numeric value only.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bFormatterValue">New value for property <code>formatterValue</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.NumericContent setFormatterValue(bool bFormatterValue);

				#endregion

				#region Methods for Property icon

				/// <summary>
				/// Gets current value of property {@link #getIcon icon}.
				/// 
				/// The icon to be displayed as a graphical element within the control. This can be an image or an icon from the icon font.
				/// </summary>
				/// <returns>Value of property <code>icon</code></returns>
				public extern virtual sap.ui.core.URI getIcon();

				/// <summary>
				/// Sets a new value for property {@link #getIcon icon}.
				/// 
				/// The icon to be displayed as a graphical element within the control. This can be an image or an icon from the icon font.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sIcon">New value for property <code>icon</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.NumericContent setIcon(sap.ui.core.URI sIcon);

				#endregion

				#region Methods for Property iconDescription

				/// <summary>
				/// Gets current value of property {@link #getIconDescription iconDescription}.
				/// 
				/// Description of an icon that is used in the tooltip.
				/// </summary>
				/// <returns>Value of property <code>iconDescription</code></returns>
				public extern virtual string getIconDescription();

				/// <summary>
				/// Sets a new value for property {@link #getIconDescription iconDescription}.
				/// 
				/// Description of an icon that is used in the tooltip.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sIconDescription">New value for property <code>iconDescription</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.NumericContent setIconDescription(string sIconDescription);

				#endregion

				#region Methods for Property indicator

				/// <summary>
				/// Gets current value of property {@link #getIndicator indicator}.
				/// 
				/// The indicator arrow that shows value deviation.
				/// 
				/// Default value is <code>None</code>.
				/// </summary>
				/// <returns>Value of property <code>indicator</code></returns>
				public extern virtual sap.m.DeviationIndicator getIndicator();

				/// <summary>
				/// Sets a new value for property {@link #getIndicator indicator}.
				/// 
				/// The indicator arrow that shows value deviation.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>None</code>.
				/// </summary>
				/// <param name="sIndicator">New value for property <code>indicator</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.NumericContent setIndicator(sap.m.DeviationIndicator sIndicator);

				#endregion

				#region Methods for Property nullifyValue

				/// <summary>
				/// Gets current value of property {@link #getNullifyValue nullifyValue}.
				/// 
				/// If set to true, the omitted value property is set to 0.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>nullifyValue</code></returns>
				public extern virtual bool getNullifyValue();

				/// <summary>
				/// Sets a new value for property {@link #getNullifyValue nullifyValue}.
				/// 
				/// If set to true, the omitted value property is set to 0.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bNullifyValue">New value for property <code>nullifyValue</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.NumericContent setNullifyValue(bool bNullifyValue);

				#endregion

				#region Methods for Property scale

				/// <summary>
				/// Gets current value of property {@link #getScale scale}.
				/// 
				/// The scaling prefix. Financial characters can be used for currencies and counters. The SI prefixes can be used for units. If the scaling prefix contains more than three characters, only the first three characters are displayed.
				/// </summary>
				/// <returns>Value of property <code>scale</code></returns>
				public extern virtual string getScale();

				/// <summary>
				/// Sets a new value for property {@link #getScale scale}.
				/// 
				/// The scaling prefix. Financial characters can be used for currencies and counters. The SI prefixes can be used for units. If the scaling prefix contains more than three characters, only the first three characters are displayed.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sScale">New value for property <code>scale</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.NumericContent setScale(string sScale);

				#endregion

				#region Methods for Property size

				/// <summary>
				/// Gets current value of property {@link #getSize size}.
				/// 
				/// Updates the size of the control. If not set, then the default size is applied based on the device tile.
				/// 
				/// Default value is <code>Auto</code>.
				/// </summary>
				[Obsolete("Deprecated since 1.38.0. The NumericContent control has now a fixed size, depending on the used media (desktop, tablet or phone).")]
				/// <returns>Value of property <code>size</code></returns>
				public extern virtual sap.m.Size getSize();

				/// <summary>
				/// Sets a new value for property {@link #getSize size}.
				/// 
				/// Updates the size of the control. If not set, then the default size is applied based on the device tile.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Auto</code>.
				/// </summary>
				[Obsolete("Deprecated since 1.38.0. The NumericContent control has now a fixed size, depending on the used media (desktop, tablet or phone).")]
				/// <param name="sSize">New value for property <code>size</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.NumericContent setSize(sap.m.Size sSize);

				#endregion

				#region Methods for Property truncateValueTo

				/// <summary>
				/// Gets current value of property {@link #getTruncateValueTo truncateValueTo}.
				/// 
				/// The number of characters of the <code>value</code> property to display.
				/// 
				/// Default value is <code>4</code>.
				/// </summary>
				/// <returns>Value of property <code>truncateValueTo</code></returns>
				public extern virtual int getTruncateValueTo();

				/// <summary>
				/// Sets a new value for property {@link #getTruncateValueTo truncateValueTo}.
				/// 
				/// The number of characters of the <code>value</code> property to display.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>4</code>.
				/// </summary>
				/// <param name="iTruncateValueTo">New value for property <code>truncateValueTo</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.NumericContent setTruncateValueTo(int iTruncateValueTo);

				#endregion

				#region Methods for Property value

				/// <summary>
				/// Gets current value of property {@link #getValue value}.
				/// 
				/// The actual value.
				/// </summary>
				/// <returns>Value of property <code>value</code></returns>
				public extern virtual string getValue();

				/// <summary>
				/// Sets a new value for property {@link #getValue value}.
				/// 
				/// The actual value.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sValue">New value for property <code>value</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.NumericContent setValue(string sValue);

				#endregion

				#region Methods for Property valueColor

				/// <summary>
				/// Gets current value of property {@link #getValueColor valueColor}.
				/// 
				/// The semantic color of the value.
				/// 
				/// Default value is <code>Neutral</code>.
				/// </summary>
				/// <returns>Value of property <code>valueColor</code></returns>
				public extern virtual sap.m.ValueColor getValueColor();

				/// <summary>
				/// Sets a new value for property {@link #getValueColor valueColor}.
				/// 
				/// The semantic color of the value.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Neutral</code>.
				/// </summary>
				/// <param name="sValueColor">New value for property <code>valueColor</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.NumericContent setValueColor(sap.m.ValueColor sValueColor);

				#endregion

				#region Methods for Property width

				/// <summary>
				/// Gets current value of property {@link #getWidth width}.
				/// 
				/// The width of the control. If it is not set, the size of the control is defined by the 'size' property.
				/// </summary>
				/// <returns>Value of property <code>width</code></returns>
				public extern virtual sap.ui.core.CSSSize getWidth();

				/// <summary>
				/// Sets a new value for property {@link #getWidth width}.
				/// 
				/// The width of the control. If it is not set, the size of the control is defined by the 'size' property.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sWidth">New value for property <code>width</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.NumericContent setWidth(sap.ui.core.CSSSize sWidth);

				#endregion

				#region Methods for Property withMargin

				/// <summary>
				/// Gets current value of property {@link #getWithMargin withMargin}.
				/// 
				/// If the value is set to false, the content is adjusted to the whole size of the control.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>withMargin</code></returns>
				public extern virtual bool getWithMargin();

				/// <summary>
				/// Sets a new value for property {@link #getWithMargin withMargin}.
				/// 
				/// If the value is set to false, the content is adjusted to the whole size of the control.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bWithMargin">New value for property <code>withMargin</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.NumericContent setWithMargin(bool bWithMargin);

				#endregion

				#region Methods for Property state

				/// <summary>
				/// Gets current value of property {@link #getState state}.
				/// 
				/// Indicates the load status.
				/// 
				/// Default value is <code>Loaded</code>.
				/// </summary>
				/// <returns>Value of property <code>state</code></returns>
				public extern virtual sap.m.LoadState getState();

				/// <summary>
				/// Sets a new value for property {@link #getState state}.
				/// 
				/// Indicates the load status.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Loaded</code>.
				/// </summary>
				/// <param name="sState">New value for property <code>state</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.NumericContent setState(sap.m.LoadState sState);

				#endregion

				#region Methods for Event press

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:press press} event of this <code>sap.m.NumericContent</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.NumericContent</code> itself.
				/// 
				/// The event is fired when the user chooses the numeric content.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.NumericContent</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.NumericContent attachPress(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:press press} event of this <code>sap.m.NumericContent</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.NumericContent</code> itself.
				/// 
				/// The event is fired when the user chooses the numeric content.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.NumericContent attachPress(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:press press} event of this <code>sap.m.NumericContent</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.NumericContent</code> itself.
				/// 
				/// The event is fired when the user chooses the numeric content.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.NumericContent attachPress(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:press press} event of this <code>sap.m.NumericContent</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.NumericContent</code> itself.
				/// 
				/// The event is fired when the user chooses the numeric content.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.NumericContent</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.NumericContent attachPress(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:press press} event of this <code>sap.m.NumericContent</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.NumericContent detachPress(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:press press} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.NumericContent firePress(object mParameters);

				/// <summary>
				/// Fires event {@link #event:press press} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.NumericContent firePress();

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.NumericContent with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.NumericContent with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.NumericContent with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.NumericContent.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				#endregion

				#endregion

			}
		}
	}
}
