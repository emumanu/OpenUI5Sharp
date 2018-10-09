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
			public static partial class commons
			{
				/// <summary>
				/// The interactive control is displayed either as a horizontal or a vertical line with a pointer and units of measurement. Users can move the pointer along the line to change values with graphical support.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.Slider")]
				[Obsolete("Deprecated since 1.38. replaced by {@link sap.m.Slider}")]
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
						/// Width of the horizontal slider.
						/// </summary>
						public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> width;

						/// <summary>
						/// Minimal value of the slider.
						/// 
						/// <b>Note:</b> If <code>min</code> is larger than <code>max</code> both values will be switched
						/// </summary>
						public Union<float, string, sap.ui.@base.ManagedObject.BindPropertyInfo> min;

						/// <summary>
						/// Maximal value of the slider
						/// 
						/// <b>Note:</b> If <code>min</code> is larger than <code>max</code> both values will be switched
						/// </summary>
						public Union<float, string, sap.ui.@base.ManagedObject.BindPropertyInfo> max;

						/// <summary>
						/// Current value of the slider. (Position of the grip.)
						/// 
						/// <b>Note:</b> If the value is not in the valid range (between <code>min</code> and <code>max</code>) it will be changed to be in the valid range.
						/// </summary>
						public Union<float, string, sap.ui.@base.ManagedObject.BindPropertyInfo> value;

						/// <summary>
						/// The grip can only be moved in steps of this width.
						/// </summary>
						public Union<float, string, sap.ui.@base.ManagedObject.BindPropertyInfo> smallStepWidth;

						/// <summary>
						/// Number of units that are displayed by ticks. The PageUp and PageDown keys navigate according to these units.
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> totalUnits;

						/// <summary>
						/// Display step numbers for the ticks on the slider.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> stepLabels;

						/// <summary>
						/// Using the slider interactively requires value "true".
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> editable;

						/// <summary>
						/// Switches enabled state of the control. Disabled fields have different colors, and can not be focused.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> enabled;

						/// <summary>
						/// Labels to be displayed instead of numbers. Attribute totalUnits and label count should be the same
						/// 
						/// <b>Note:</b> To show the labels <code>stepLabels</code> must be activated.
						/// </summary>
						public Union<string[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> labels;

						/// <summary>
						/// Orientation of slider
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> vertical;

						/// <summary>
						/// Height of the vertical slider.
						/// </summary>
						public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> height;

						/// <summary>
						/// Association to controls / IDs which describe this control (see WAI-ARIA attribute aria-describedby).
						/// </summary>
						public Union<sap.ui.core.Control, sap.ui.core.ID[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> ariaDescribedBy;

						/// <summary>
						/// Association to controls / IDs which label this control (see WAI-ARIA attribute aria-labelledby).
						/// </summary>
						public Union<sap.ui.core.Control, sap.ui.core.ID[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> ariaLabelledBy;

						/// <summary>
						/// Value was changed. This event is fired if the value has changed by a user action.
						/// </summary>
						public sap.m.SubmitOrChangeDelegate change;

						/// <summary>
						/// Value was changed. This event is fired during the mouse move. The normal change event is only fired by mouseup.
						/// </summary>
						public sap.m.SubmitOrChangeDelegate liveChange;

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
					public extern Slider(string sId, sap.ui.commons.Slider.Settings mSettings);

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
					public extern Slider(sap.ui.commons.Slider.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property width

					/// <summary>
					/// Gets current value of property {@link #getWidth width}.
					/// 
					/// Width of the horizontal slider.
					/// 
					/// Default value is <code>100%</code>.
					/// </summary>
					/// <returns>Value of property <code>width</code></returns>
					public extern virtual sap.ui.core.CSSSize getWidth();

					/// <summary>
					/// Sets a new value for property {@link #getWidth width}.
					/// 
					/// Width of the horizontal slider.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>100%</code>.
					/// </summary>
					/// <param name="sWidth">New value for property <code>width</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Slider setWidth(sap.ui.core.CSSSize sWidth);

					#endregion

					#region Methods for Property min

					/// <summary>
					/// Gets current value of property {@link #getMin min}.
					/// 
					/// Minimal value of the slider.
					/// 
					/// <b>Note:</b> If <code>min</code> is larger than <code>max</code> both values will be switched
					/// 
					/// Default value is <code>0</code>.
					/// </summary>
					/// <returns>Value of property <code>min</code></returns>
					public extern virtual float getMin();

					/// <summary>
					/// Sets a new value for property {@link #getMin min}.
					/// 
					/// Minimal value of the slider.
					/// 
					/// <b>Note:</b> If <code>min</code> is larger than <code>max</code> both values will be switched
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>0</code>.
					/// </summary>
					/// <param name="fMin">New value for property <code>min</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Slider setMin(float fMin);

					#endregion

					#region Methods for Property max

					/// <summary>
					/// Gets current value of property {@link #getMax max}.
					/// 
					/// Maximal value of the slider
					/// 
					/// <b>Note:</b> If <code>min</code> is larger than <code>max</code> both values will be switched
					/// 
					/// Default value is <code>100</code>.
					/// </summary>
					/// <returns>Value of property <code>max</code></returns>
					public extern virtual float getMax();

					/// <summary>
					/// Sets a new value for property {@link #getMax max}.
					/// 
					/// Maximal value of the slider
					/// 
					/// <b>Note:</b> If <code>min</code> is larger than <code>max</code> both values will be switched
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>100</code>.
					/// </summary>
					/// <param name="fMax">New value for property <code>max</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Slider setMax(float fMax);

					#endregion

					#region Methods for Property value

					/// <summary>
					/// Gets current value of property {@link #getValue value}.
					/// 
					/// Current value of the slider. (Position of the grip.)
					/// 
					/// <b>Note:</b> If the value is not in the valid range (between <code>min</code> and <code>max</code>) it will be changed to be in the valid range.
					/// 
					/// Default value is <code>50</code>.
					/// </summary>
					/// <returns>Value of property <code>value</code></returns>
					public extern virtual float getValue();

					/// <summary>
					/// Sets a new value for property {@link #getValue value}.
					/// 
					/// Current value of the slider. (Position of the grip.)
					/// 
					/// <b>Note:</b> If the value is not in the valid range (between <code>min</code> and <code>max</code>) it will be changed to be in the valid range.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>50</code>.
					/// </summary>
					/// <param name="fValue">New value for property <code>value</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Slider setValue(float fValue);

					#endregion

					#region Methods for Property smallStepWidth

					/// <summary>
					/// Gets current value of property {@link #getSmallStepWidth smallStepWidth}.
					/// 
					/// The grip can only be moved in steps of this width.
					/// </summary>
					/// <returns>Value of property <code>smallStepWidth</code></returns>
					public extern virtual float getSmallStepWidth();

					/// <summary>
					/// Sets a new value for property {@link #getSmallStepWidth smallStepWidth}.
					/// 
					/// The grip can only be moved in steps of this width.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="fSmallStepWidth">New value for property <code>smallStepWidth</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Slider setSmallStepWidth(float fSmallStepWidth);

					#endregion

					#region Methods for Property totalUnits

					/// <summary>
					/// Gets current value of property {@link #getTotalUnits totalUnits}.
					/// 
					/// Number of units that are displayed by ticks. The PageUp and PageDown keys navigate according to these units.
					/// </summary>
					/// <returns>Value of property <code>totalUnits</code></returns>
					public extern virtual int getTotalUnits();

					/// <summary>
					/// Sets a new value for property {@link #getTotalUnits totalUnits}.
					/// 
					/// Number of units that are displayed by ticks. The PageUp and PageDown keys navigate according to these units.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="iTotalUnits">New value for property <code>totalUnits</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Slider setTotalUnits(int iTotalUnits);

					#endregion

					#region Methods for Property stepLabels

					/// <summary>
					/// Gets current value of property {@link #getStepLabels stepLabels}.
					/// 
					/// Display step numbers for the ticks on the slider.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>stepLabels</code></returns>
					public extern virtual bool getStepLabels();

					/// <summary>
					/// Sets a new value for property {@link #getStepLabels stepLabels}.
					/// 
					/// Display step numbers for the ticks on the slider.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bStepLabels">New value for property <code>stepLabels</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Slider setStepLabels(bool bStepLabels);

					#endregion

					#region Methods for Property editable

					/// <summary>
					/// Gets current value of property {@link #getEditable editable}.
					/// 
					/// Using the slider interactively requires value "true".
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>editable</code></returns>
					public extern virtual bool getEditable();

					/// <summary>
					/// Sets a new value for property {@link #getEditable editable}.
					/// 
					/// Using the slider interactively requires value "true".
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bEditable">New value for property <code>editable</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Slider setEditable(bool bEditable);

					#endregion

					#region Methods for Property enabled

					/// <summary>
					/// Gets current value of property {@link #getEnabled enabled}.
					/// 
					/// Switches enabled state of the control. Disabled fields have different colors, and can not be focused.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>enabled</code></returns>
					public extern virtual bool getEnabled();

					/// <summary>
					/// Sets a new value for property {@link #getEnabled enabled}.
					/// 
					/// Switches enabled state of the control. Disabled fields have different colors, and can not be focused.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bEnabled">New value for property <code>enabled</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Slider setEnabled(bool bEnabled);

					#endregion

					#region Methods for Property labels

					/// <summary>
					/// Gets current value of property {@link #getLabels labels}.
					/// 
					/// Labels to be displayed instead of numbers. Attribute totalUnits and label count should be the same
					/// 
					/// <b>Note:</b> To show the labels <code>stepLabels</code> must be activated.
					/// </summary>
					/// <returns>Value of property <code>labels</code></returns>
					public extern virtual string[] getLabels();

					/// <summary>
					/// Sets a new value for property {@link #getLabels labels}.
					/// 
					/// Labels to be displayed instead of numbers. Attribute totalUnits and label count should be the same
					/// 
					/// <b>Note:</b> To show the labels <code>stepLabels</code> must be activated.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sLabels">New value for property <code>labels</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Slider setLabels(string[] sLabels);

					/// <summary>
					/// Sets a new value for property {@link #getLabels labels}.
					/// 
					/// Labels to be displayed instead of numbers. Attribute totalUnits and label count should be the same
					/// 
					/// <b>Note:</b> To show the labels <code>stepLabels</code> must be activated.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sLabels">New value for property <code>labels</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Slider setLabels(object[] sLabels);

					#endregion

					#region Methods for Property vertical

					/// <summary>
					/// Gets current value of property {@link #getVertical vertical}.
					/// 
					/// Orientation of slider
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>vertical</code></returns>
					public extern virtual bool getVertical();

					/// <summary>
					/// Sets a new value for property {@link #getVertical vertical}.
					/// 
					/// Orientation of slider
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bVertical">New value for property <code>vertical</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Slider setVertical(bool bVertical);

					#endregion

					#region Methods for Property height

					/// <summary>
					/// Gets current value of property {@link #getHeight height}.
					/// 
					/// Height of the vertical slider.
					/// 
					/// Default value is <code>100%</code>.
					/// </summary>
					/// <returns>Value of property <code>height</code></returns>
					public extern virtual sap.ui.core.CSSSize getHeight();

					/// <summary>
					/// Sets a new value for property {@link #getHeight height}.
					/// 
					/// Height of the vertical slider.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>100%</code>.
					/// </summary>
					/// <param name="sHeight">New value for property <code>height</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Slider setHeight(sap.ui.core.CSSSize sHeight);

					#endregion

					#region Methods for Association ariaDescribedBy

					/// <summary>
					/// Returns array of IDs of the elements which are the current targets of the association {@link #getAriaDescribedBy ariaDescribedBy}.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.ID[] getAriaDescribedBy();

					/// <summary>
					/// Adds some ariaDescribedBy into the association {@link #getAriaDescribedBy ariaDescribedBy}.
					/// </summary>
					/// <param name="vAriaDescribedBy">The ariaDescribedBy to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Slider addAriaDescribedBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaDescribedBy);

					/// <summary>
					/// Removes an ariaDescribedBy from the association named {@link #getAriaDescribedBy ariaDescribedBy}.
					/// </summary>
					/// <param name="vAriaDescribedBy">The ariaDescribedBy to be removed or its index or ID</param>
					/// <returns>The removed ariaDescribedBy or <code>null</code></returns>
					public extern virtual sap.ui.core.ID removeAriaDescribedBy(Union<int, sap.ui.core.ID, sap.ui.core.Control> vAriaDescribedBy);

					/// <summary>
					/// Removes all the controls in the association named {@link #getAriaDescribedBy ariaDescribedBy}.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.core.ID[] removeAllAriaDescribedBy();

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
					public extern virtual sap.ui.commons.Slider addAriaLabelledBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaLabelledBy);

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
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:change change} event of this <code>sap.ui.commons.Slider</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.Slider</code> itself.
					/// 
					/// Value was changed. This event is fired if the value has changed by a user action.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.Slider</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Slider attachChange(object oData, sap.m.SubmitOrChangeDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:change change} event of this <code>sap.ui.commons.Slider</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.Slider</code> itself.
					/// 
					/// Value was changed. This event is fired if the value has changed by a user action.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Slider attachChange(object oData, sap.m.SubmitOrChangeDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:change change} event of this <code>sap.ui.commons.Slider</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.Slider</code> itself.
					/// 
					/// Value was changed. This event is fired if the value has changed by a user action.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Slider attachChange(sap.m.SubmitOrChangeDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:change change} event of this <code>sap.ui.commons.Slider</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.Slider</code> itself.
					/// 
					/// Value was changed. This event is fired if the value has changed by a user action.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.Slider</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Slider attachChange(sap.m.SubmitOrChangeDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:change change} event of this <code>sap.ui.commons.Slider</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Slider detachChange(sap.m.SubmitOrChangeDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:change change} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Slider fireChange(sap.m.SubmitOrChangeInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:change change} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Slider fireChange();

					#endregion

					#region Methods for Event liveChange

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:liveChange liveChange} event of this <code>sap.ui.commons.Slider</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.Slider</code> itself.
					/// 
					/// Value was changed. This event is fired during the mouse move. The normal change event is only fired by mouseup.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.Slider</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Slider attachLiveChange(object oData, sap.m.SubmitOrChangeDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:liveChange liveChange} event of this <code>sap.ui.commons.Slider</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.Slider</code> itself.
					/// 
					/// Value was changed. This event is fired during the mouse move. The normal change event is only fired by mouseup.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Slider attachLiveChange(object oData, sap.m.SubmitOrChangeDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:liveChange liveChange} event of this <code>sap.ui.commons.Slider</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.Slider</code> itself.
					/// 
					/// Value was changed. This event is fired during the mouse move. The normal change event is only fired by mouseup.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Slider attachLiveChange(sap.m.SubmitOrChangeDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:liveChange liveChange} event of this <code>sap.ui.commons.Slider</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.Slider</code> itself.
					/// 
					/// Value was changed. This event is fired during the mouse move. The normal change event is only fired by mouseup.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.Slider</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Slider attachLiveChange(sap.m.SubmitOrChangeDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:liveChange liveChange} event of this <code>sap.ui.commons.Slider</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Slider detachLiveChange(sap.m.SubmitOrChangeDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:liveChange liveChange} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Slider fireLiveChange(sap.m.SubmitOrChangeInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:liveChange liveChange} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Slider fireLiveChange();

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.Slider with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.Slider with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.Slider with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.commons.Slider.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

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
}
