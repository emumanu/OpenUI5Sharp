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
			/// <strong><i>Overview</i></strong>
			/// 
			/// A {@link sap.m.Slider} control represents a numerical range and a handle. The purpose of the control is to enable visual selection of a value in a continuous numerical range by moving an adjustable handle.
			/// 
			/// <strong>Notes:</strong> <ul><li>Only horizontal sliders are possible. </li> <li>The handle can be moved in steps of predefined size. This is done with the <code>step</code> property. </li> <li>Setting the property <code>showAdvancedTooltips</code> shows an input field above the handle</li> <li>Setting the property <code>inputsAsTooltips</code> enables the user to enter a specific value in the handle's tooltip. </li> </ul> <strong><i>Structure</i></strong>
			/// 
			/// The most important properties of the Slider are: <ul> <li> min - The minimum value of the slider range </li> <li> max - The maximum value of the slider range </li> <li> value - The current value of the slider</li> <li> progress - Determines if a progress bar will be shown on the slider range</li> <li> step - Determines the increments in which the slider will move</li> </ul> These properties determine the visualization of the tooltips: <ul> <li> showAdvancedTooltips - Determines if a tooltip should be displayed above the handle</li> <li> inputsAsTooltips - Determines if the tooltip displayed above the slider's handle should include an input field</li> </ul> <strong><i>Usage</i></strong>
			/// 
			/// The most common usecase is to select values on a continuous numerical scale (e.g. temperature, volume, etc. ).
			/// 
			/// <strong><i>Responsive Behavior</i></strong>
			/// 
			/// The <code>sap.m.Slider</code> control adjusts to the size of its parent container by recalculating and resizing the width of the control. You can move the slider handle in several different ways: <ul> <li> Drag and drop to the desired value</li> <li> Click/tap on the range bar to move the handle to that location </li> <li> Enter the desired value in the input field (if available) </li> <li> Keyboard (Arrow keys, "+" and "-") </li> </ul>
			/// </summary>
			[External]
			[Namespace(false)]
			public partial class Slider : sap.ui.core.Control, sap.ui.core.IFormContent
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
					/// Defines the width of the control.
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> width;

					/// <summary>
					/// Indicates whether the user can change the value.
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> enabled;

					/// <summary>
					/// The name property to be used in the HTML code for the slider (e.g. for HTML forms that send data to the server via submit).
					/// </summary>
					public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> name;

					/// <summary>
					/// The minimum value.
					/// </summary>
					public Union<float, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> min;

					/// <summary>
					/// The maximum value.
					/// </summary>
					public Union<float, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> max;

					/// <summary>
					/// Define the amount of units to change the slider when adjusting by drag and drop.
					/// 
					/// Defines the size of the slider's selection intervals. (e.g. min = 0, max = 10, step = 5 would result in possible selection of the values 0, 5, 10).
					/// 
					/// The step must be positive, if a negative number is provided, the default value will be used instead. If the width of the slider converted to pixels is less than the range (max - min), the value will be rounded to multiples of the step size.
					/// </summary>
					public Union<float, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> step;

					/// <summary>
					/// Indicate whether a progress bar indicator is shown.
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> progress;

					/// <summary>
					/// Define the value.
					/// 
					/// If the value is lower/higher than the allowed minimum/maximum, the value of the properties <code>min</code>/<code>max</code> are used instead.
					/// </summary>
					public Union<float, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> value;

					/// <summary>
					/// Indicate whether the handle tooltip is shown.
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> showHandleTooltip;

					/// <summary>
					/// Indicate whether the handle's advanced tooltip is shown. <b>Note:</b> Setting this option to <code>true</code> will ignore the value set in <code>showHandleTooltips</code>. This will cause only the advanced tooltip to be shown.
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> showAdvancedTooltip;

					/// <summary>
					/// Indicates whether input fields should be used as tooltips for the handles. <b>Note:</b> Setting this option to <code>true</code> will only work if <code>showAdvancedTooltips</code> is set to <code>true</code>.
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> inputsAsTooltips;

					/// <summary>
					/// Enables tickmarks visualisation
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> enableTickmarks;

					/// <summary>
					/// Scale for visualisation of tickmarks and labels
					/// </summary>
					public Union<sap.m.IScale, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> scale;

					/// <summary>
					/// Aggregation for user-defined tooltips. <b>Note:</b> In case of Slider, only the first tooltip of the aggregation is used. In the RangeSlider case - the first two. If no custom tooltips are provided, the default are used
					/// </summary>
					public Union<sap.m.SliderTooltipBase[], string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> customTooltips;

					/// <summary>
					/// Association to controls / IDs which label this control (see WAI-ARIA attribute <code>aria-labelledby</code>).
					/// </summary>
					public Union<sap.ui.core.Control, sap.ui.core.ID[], string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> ariaLabelledBy;

					/// <summary>
					/// This event is triggered after the end user finishes interacting, if there is any change.
					/// </summary>
					public sap.m.SliderChangeDelegate change;

					/// <summary>
					/// This event is triggered during the dragging period, each time the slider value changes.
					/// </summary>
					public sap.m.SliderChangeDelegate liveChange;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new <code>Slider</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern Slider(string sId, sap.m.Slider.Settings mSettings);

				/// <summary>
				/// Constructor for a new <code>Slider</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern Slider(string sId);

				/// <summary>
				/// Constructor for a new <code>Slider</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern Slider();

				/// <summary>
				/// Constructor for a new <code>Slider</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern Slider(sap.m.Slider.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property width

				/// <summary>
				/// Gets current value of property {@link #getWidth width}.
				/// 
				/// Defines the width of the control.
				/// 
				/// Default value is <code>100%</code>.
				/// </summary>
				/// <returns>Value of property <code>width</code></returns>
				public extern virtual sap.ui.core.CSSSize getWidth();

				/// <summary>
				/// Sets a new value for property {@link #getWidth width}.
				/// 
				/// Defines the width of the control.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>100%</code>.
				/// </summary>
				/// <param name="sWidth">New value for property <code>width</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Slider setWidth(sap.ui.core.CSSSize sWidth);

				#endregion

				#region Methods for Property enabled

				/// <summary>
				/// Gets current value of property {@link #getEnabled enabled}.
				/// 
				/// Indicates whether the user can change the value.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>enabled</code></returns>
				public extern virtual bool getEnabled();

				/// <summary>
				/// Sets a new value for property {@link #getEnabled enabled}.
				/// 
				/// Indicates whether the user can change the value.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bEnabled">New value for property <code>enabled</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Slider setEnabled(bool bEnabled);

				#endregion

				#region Methods for Property name

				/// <summary>
				/// Gets current value of property {@link #getName name}.
				/// 
				/// The name property to be used in the HTML code for the slider (e.g. for HTML forms that send data to the server via submit).
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <returns>Value of property <code>name</code></returns>
				public extern virtual string getName();

				/// <summary>
				/// Sets a new value for property {@link #getName name}.
				/// 
				/// The name property to be used in the HTML code for the slider (e.g. for HTML forms that send data to the server via submit).
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <param name="sName">New value for property <code>name</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Slider setName(string sName);

				#endregion

				#region Methods for Property min

				/// <summary>
				/// Gets current value of property {@link #getMin min}.
				/// 
				/// The minimum value.
				/// 
				/// Default value is <code>0</code>.
				/// </summary>
				/// <returns>Value of property <code>min</code></returns>
				public extern virtual float getMin();

				/// <summary>
				/// Sets a new value for property {@link #getMin min}.
				/// 
				/// The minimum value.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>0</code>.
				/// </summary>
				/// <param name="fMin">New value for property <code>min</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Slider setMin(float fMin);

				#endregion

				#region Methods for Property max

				/// <summary>
				/// Gets current value of property {@link #getMax max}.
				/// 
				/// The maximum value.
				/// 
				/// Default value is <code>100</code>.
				/// </summary>
				/// <returns>Value of property <code>max</code></returns>
				public extern virtual float getMax();

				/// <summary>
				/// Sets a new value for property {@link #getMax max}.
				/// 
				/// The maximum value.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>100</code>.
				/// </summary>
				/// <param name="fMax">New value for property <code>max</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Slider setMax(float fMax);

				#endregion

				#region Methods for Property step

				/// <summary>
				/// Gets current value of property {@link #getStep step}.
				/// 
				/// Define the amount of units to change the slider when adjusting by drag and drop.
				/// 
				/// Defines the size of the slider's selection intervals. (e.g. min = 0, max = 10, step = 5 would result in possible selection of the values 0, 5, 10).
				/// 
				/// The step must be positive, if a negative number is provided, the default value will be used instead. If the width of the slider converted to pixels is less than the range (max - min), the value will be rounded to multiples of the step size.
				/// 
				/// Default value is <code>1</code>.
				/// </summary>
				/// <returns>Value of property <code>step</code></returns>
				public extern virtual float getStep();

				/// <summary>
				/// Sets a new value for property {@link #getStep step}.
				/// 
				/// Define the amount of units to change the slider when adjusting by drag and drop.
				/// 
				/// Defines the size of the slider's selection intervals. (e.g. min = 0, max = 10, step = 5 would result in possible selection of the values 0, 5, 10).
				/// 
				/// The step must be positive, if a negative number is provided, the default value will be used instead. If the width of the slider converted to pixels is less than the range (max - min), the value will be rounded to multiples of the step size.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>1</code>.
				/// </summary>
				/// <param name="fStep">New value for property <code>step</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Slider setStep(float fStep);

				#endregion

				#region Methods for Property progress

				/// <summary>
				/// Gets current value of property {@link #getProgress progress}.
				/// 
				/// Indicate whether a progress bar indicator is shown.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>progress</code></returns>
				public extern virtual bool getProgress();

				/// <summary>
				/// Sets a new value for property {@link #getProgress progress}.
				/// 
				/// Indicate whether a progress bar indicator is shown.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bProgress">New value for property <code>progress</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Slider setProgress(bool bProgress);

				#endregion

				#region Methods for Property value

				/// <summary>
				/// Gets current value of property {@link #getValue value}.
				/// 
				/// Define the value.
				/// 
				/// If the value is lower/higher than the allowed minimum/maximum, the value of the properties <code>min</code>/<code>max</code> are used instead.
				/// 
				/// Default value is <code>0</code>.
				/// </summary>
				/// <returns>Value of property <code>value</code></returns>
				public extern virtual float getValue();

				/// <summary>
				/// Sets the property <code>value</code>.
				/// 
				/// Default value is <code>0</code>.
				/// </summary>
				/// <param name="fNewValue">new value for property <code>value</code>.</param>
				/// <param name="mOptions">The options object</param>
				/// <returns><code>this</code> to allow method chaining.</returns>
				public extern virtual sap.m.Slider setValue(float fNewValue, object mOptions);

				#endregion

				#region Methods for Property showHandleTooltip

				/// <summary>
				/// Gets current value of property {@link #getShowHandleTooltip showHandleTooltip}.
				/// 
				/// Indicate whether the handle tooltip is shown.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>showHandleTooltip</code></returns>
				public extern virtual bool getShowHandleTooltip();

				/// <summary>
				/// Sets a new value for property {@link #getShowHandleTooltip showHandleTooltip}.
				/// 
				/// Indicate whether the handle tooltip is shown.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bShowHandleTooltip">New value for property <code>showHandleTooltip</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Slider setShowHandleTooltip(bool bShowHandleTooltip);

				#endregion

				#region Methods for Property showAdvancedTooltip

				/// <summary>
				/// Gets current value of property {@link #getShowAdvancedTooltip showAdvancedTooltip}.
				/// 
				/// Indicate whether the handle's advanced tooltip is shown. <b>Note:</b> Setting this option to <code>true</code> will ignore the value set in <code>showHandleTooltips</code>. This will cause only the advanced tooltip to be shown.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>showAdvancedTooltip</code></returns>
				public extern virtual bool getShowAdvancedTooltip();

				/// <summary>
				/// Sets a new value for property {@link #getShowAdvancedTooltip showAdvancedTooltip}.
				/// 
				/// Indicate whether the handle's advanced tooltip is shown. <b>Note:</b> Setting this option to <code>true</code> will ignore the value set in <code>showHandleTooltips</code>. This will cause only the advanced tooltip to be shown.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bShowAdvancedTooltip">New value for property <code>showAdvancedTooltip</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Slider setShowAdvancedTooltip(bool bShowAdvancedTooltip);

				#endregion

				#region Methods for Property inputsAsTooltips

				/// <summary>
				/// Gets current value of property {@link #getInputsAsTooltips inputsAsTooltips}.
				/// 
				/// Indicates whether input fields should be used as tooltips for the handles. <b>Note:</b> Setting this option to <code>true</code> will only work if <code>showAdvancedTooltips</code> is set to <code>true</code>.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>inputsAsTooltips</code></returns>
				public extern virtual bool getInputsAsTooltips();

				/// <summary>
				/// Sets a new value for property {@link #getInputsAsTooltips inputsAsTooltips}.
				/// 
				/// Indicates whether input fields should be used as tooltips for the handles. <b>Note:</b> Setting this option to <code>true</code> will only work if <code>showAdvancedTooltips</code> is set to <code>true</code>.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bInputsAsTooltips">New value for property <code>inputsAsTooltips</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Slider setInputsAsTooltips(bool bInputsAsTooltips);

				#endregion

				#region Methods for Property enableTickmarks

				/// <summary>
				/// Gets current value of property {@link #getEnableTickmarks enableTickmarks}.
				/// 
				/// Enables tickmarks visualisation
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>enableTickmarks</code></returns>
				public extern virtual bool getEnableTickmarks();

				/// <summary>
				/// Sets a new value for property {@link #getEnableTickmarks enableTickmarks}.
				/// 
				/// Enables tickmarks visualisation
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bEnableTickmarks">New value for property <code>enableTickmarks</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Slider setEnableTickmarks(bool bEnableTickmarks);

				#endregion

				#region Methods for Aggregation _tooltipContainer

				#endregion

				#region Methods for Aggregation scale

				/// <summary>
				/// Gets content of aggregation {@link #getScale scale}.
				/// 
				/// Scale for visualisation of tickmarks and labels
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.IScale getScale();

				/// <summary>
				/// Destroys the scale in the aggregation {@link #getScale scale}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Slider destroyScale();

				/// <summary>
				/// Sets the aggregated {@link #getScale scale}.
				/// </summary>
				/// <param name="oScale">The scale to set</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Slider setScale(sap.m.IScale oScale);

				#endregion

				#region Methods for Aggregation _defaultScale

				#endregion

				#region Methods for Aggregation _defaultTooltips

				#endregion

				#region Methods for Aggregation customTooltips

				/// <summary>
				/// Gets content of aggregation {@link #getCustomTooltips customTooltips}.
				/// 
				/// Aggregation for user-defined tooltips. <b>Note:</b> In case of Slider, only the first tooltip of the aggregation is used. In the RangeSlider case - the first two. If no custom tooltips are provided, the default are used
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.SliderTooltipBase[] getCustomTooltips();

				/// <summary>
				/// Destroys all the customTooltips in the aggregation {@link #getCustomTooltips customTooltips}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Slider destroyCustomTooltips();

				/// <summary>
				/// Inserts a customTooltip into the aggregation {@link #getCustomTooltips customTooltips}.
				/// </summary>
				/// <param name="oCustomTooltip">The customTooltip to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the customTooltip should be inserted at; for a negative value of <code>iIndex</code>, the customTooltip is inserted at position 0; for a value greater than the current size of the aggregation, the customTooltip is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Slider insertCustomTooltip(sap.m.SliderTooltipBase oCustomTooltip, int iIndex);

				/// <summary>
				/// Adds some customTooltip to the aggregation {@link #getCustomTooltips customTooltips}.
				/// </summary>
				/// <param name="oCustomTooltip">The customTooltip to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Slider addCustomTooltip(sap.m.SliderTooltipBase oCustomTooltip);

				/// <summary>
				/// Removes a customTooltip from the aggregation {@link #getCustomTooltips customTooltips}.
				/// </summary>
				/// <param name="vCustomTooltip">The customTooltip to remove or its index or id</param>
				/// <returns>The removed customTooltip or <code>null</code></returns>
				public extern virtual sap.m.SliderTooltipBase removeCustomTooltip(Union<int, string, sap.m.SliderTooltipBase> vCustomTooltip);

				/// <summary>
				/// Checks for the provided <code>sap.m.SliderTooltipBase</code> in the aggregation {@link #getCustomTooltips customTooltips}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oCustomTooltip">The customTooltip whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfCustomTooltip(sap.m.SliderTooltipBase oCustomTooltip);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getCustomTooltips customTooltips}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.m.SliderTooltipBase[] removeAllCustomTooltips();

				#endregion

				#region Methods for Aggregation _handlesLabels

				#endregion

				#region Methods for Association ariaLabelledBy

				/// <summary>
				/// Returns array of IDs of the elements which are the current targets of the association {@link #getAriaLabelledBy ariaLabelledBy}.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.ID[] getAriaLabelledBy();

				/// <summary>
				/// Adds some ariaLabelledBy into the association {@link #getAriaLabelledBy ariaLabelledBy}.
				/// </summary>
				/// <param name="vAriaLabelledBy">The ariaLabelledBy to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Slider addAriaLabelledBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaLabelledBy);

				/// <summary>
				/// Removes an ariaLabelledBy from the association named {@link #getAriaLabelledBy ariaLabelledBy}.
				/// </summary>
				/// <param name="vAriaLabelledBy">The ariaLabelledBy to be removed or its index or ID</param>
				/// <returns>The removed ariaLabelledBy or <code>null</code></returns>
				public extern virtual sap.ui.core.ID removeAriaLabelledBy(Union<int, sap.ui.core.ID, sap.ui.core.Control> vAriaLabelledBy);

				/// <summary>
				/// Removes all the controls in the association named {@link #getAriaLabelledBy ariaLabelledBy}.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.ui.core.ID[] removeAllAriaLabelledBy();

				#endregion

				#region Methods for Event change

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:change change} event of this <code>sap.m.Slider</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Slider</code> itself.
				/// 
				/// This event is triggered after the end user finishes interacting, if there is any change.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.Slider</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Slider attachChange(object oData, sap.m.SliderChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:change change} event of this <code>sap.m.Slider</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Slider</code> itself.
				/// 
				/// This event is triggered after the end user finishes interacting, if there is any change.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Slider attachChange(object oData, sap.m.SliderChangeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:change change} event of this <code>sap.m.Slider</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Slider</code> itself.
				/// 
				/// This event is triggered after the end user finishes interacting, if there is any change.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Slider attachChange(sap.m.SliderChangeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:change change} event of this <code>sap.m.Slider</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Slider</code> itself.
				/// 
				/// This event is triggered after the end user finishes interacting, if there is any change.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.Slider</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Slider attachChange(sap.m.SliderChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:change change} event of this <code>sap.m.Slider</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Slider detachChange(sap.m.SliderChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:change change} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Slider fireChange(sap.m.SliderChangeInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:change change} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Slider fireChange();

				#endregion

				#region Methods for Event liveChange

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:liveChange liveChange} event of this <code>sap.m.Slider</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Slider</code> itself.
				/// 
				/// This event is triggered during the dragging period, each time the slider value changes.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.Slider</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Slider attachLiveChange(object oData, sap.m.SliderChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:liveChange liveChange} event of this <code>sap.m.Slider</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Slider</code> itself.
				/// 
				/// This event is triggered during the dragging period, each time the slider value changes.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Slider attachLiveChange(object oData, sap.m.SliderChangeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:liveChange liveChange} event of this <code>sap.m.Slider</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Slider</code> itself.
				/// 
				/// This event is triggered during the dragging period, each time the slider value changes.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Slider attachLiveChange(sap.m.SliderChangeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:liveChange liveChange} event of this <code>sap.m.Slider</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Slider</code> itself.
				/// 
				/// This event is triggered during the dragging period, each time the slider value changes.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.Slider</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Slider attachLiveChange(sap.m.SliderChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:liveChange liveChange} event of this <code>sap.m.Slider</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Slider detachLiveChange(sap.m.SliderChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:liveChange liveChange} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Slider fireLiveChange(sap.m.SliderChangeInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:liveChange liveChange} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Slider fireLiveChange();

				#endregion

				#region Other methods

				/// <summary>
				/// Creates default tooltips, if needed, and forwards properties to them
				/// </summary>
				/// <param name="aTooltipIds">Array of strings for ID generation</param>
				public extern virtual void assignDefaultTooltips(object[] aTooltipIds);

				/// <summary>
				/// Creates default tooltips, if needed, and forwards properties to them
				/// </summary>
				public extern virtual void assignDefaultTooltips();

				/// <summary>
				/// Creates custom tooltips, if needed, and forwards properties to them
				/// </summary>
				/// <param name="iTooltipCount">Count of the tooltips</param>
				public extern virtual void associateCustomTooltips(int iTooltipCount);

				/// <summary>
				/// Creates custom tooltips, if needed, and forwards properties to them
				/// </summary>
				public extern virtual void associateCustomTooltips();

				/// <summary>
				/// Creates a new subclass of class sap.m.Slider with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.Slider with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.Slider with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Forwards properties to a given control
				/// </summary>
				/// <param name="aProperties">Array of properties to forward</param>
				/// <param name="oControl">Control to which should be forward</param>
				public extern virtual void forwardProperties(object[] aProperties, sap.ui.core.Element oControl);

				/// <summary>
				/// Forwards properties to a given control
				/// </summary>
				/// <param name="aProperties">Array of properties to forward</param>
				public extern virtual void forwardProperties(object[] aProperties);

				/// <summary>
				/// Forwards properties to a given control
				/// </summary>
				public extern virtual void forwardProperties();

				/// <summary>
				/// Forwards properties to a given control
				/// </summary>
				/// <param name="oControl">Control to which should be forward</param>
				public extern virtual void forwardProperties(sap.ui.core.Element oControl);

				/// <summary>
				/// Forwards properties to default tooltips
				/// </summary>
				/// <param name="iTooltipCount">Count of the tooltips</param>
				public extern virtual void forwardPropertiesToDefaultTooltips(int iTooltipCount);

				/// <summary>
				/// Forwards properties to default tooltips
				/// </summary>
				public extern virtual void forwardPropertiesToDefaultTooltips();

				/// <summary>
				/// Returns a metadata object for class sap.m.Slider.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				/// <summary>
				/// Gets the tooltips that should be shown. Returns custom tooltips if provided. Otherwise - default tooltips
				/// </summary>
				/// <returns>SliderTooltipBase instances.</returns>
				public extern virtual sap.m.SliderTooltipBase[] getUsedTooltips();

				/// <summary>
				/// Handles change of Tooltip's inputs.
				/// </summary>
				/// <param name="oEvent"></param>
				public extern virtual void handleTooltipChange(jQuery.Event oEvent);

				/// <summary>
				/// Assigns tooltips and forwards properties to them
				/// </summary>
				/// <param name="aTooltipIds">Array of strings for ID generation</param>
				public extern virtual void initAndSyncTooltips(object[] aTooltipIds);

				/// <summary>
				/// Assigns tooltips and forwards properties to them
				/// </summary>
				public extern virtual void initAndSyncTooltips();

				/// <summary>
				/// Creates a default SliderTooltip instance and adds it as an aggregation
				/// </summary>
				/// <param name="sId">The tooltip ID</param>
				public extern virtual void initDefaultTooltip(string sId);

				/// <summary>
				/// Creates a default SliderTooltip instance and adds it as an aggregation
				/// </summary>
				public extern virtual void initDefaultTooltip();

				/// <summary>
				/// Creates a SliderTooltipContainer
				/// </summary>
				public extern virtual void initTooltipContainer();

				/// <summary>
				/// Decrements the value by multiplying the step the <code>step</code> with the given parameter.
				/// </summary>
				/// <param name="iStep">The number of steps the slider goes down.</param>
				/// <returns><code>this</code> to allow method chaining.</returns>
				public extern virtual sap.m.Slider stepDown(int iStep = 1);

				/// <summary>
				/// Increments the value by multiplying the <code>step</code> with the given parameter.
				/// </summary>
				/// <param name="iStep">The number of steps the slider goes up.</param>
				/// <returns><code>this</code> to allow method chaining.</returns>
				public extern virtual sap.m.Slider stepUp(int iStep = 1);

				/// <summary>
				/// Updates value of the advanced tooltip.
				/// </summary>
				/// <param name="sNewValue">The new value</param>
				public extern virtual void updateAdvancedTooltipDom(string sNewValue);

				#endregion

				#region Methods of sap.ui.core.IFormContent Interface

				/// <summary>
				/// In the <code>Form</code> control all content controls are positioned on a grid cell base. By default the controls use the full width of the used grid cell. But for some controls (like image controls), this is not the desired behavior. In this case the control must keep its original width.
				/// </summary>
				/// <returns>true if the <code>Form</code> is not allowed to adjust the width of the control to use the cell's width</returns>
				public extern static bool getFormDoNotAdjustWidth();

				#endregion

				#endregion

			}
		}
	}
}
