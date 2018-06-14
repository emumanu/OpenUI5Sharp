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
			/// The rating indicator is used to display a specific number of icons that are used to rate an item. Additionally it is also used to display the average over all ratings. <h3>Structure</h3> <ul> <li>The rating indicator can use different icons (default: stars) which are defined as URIs in the properties <code>iconHovered</code>, <code>iconSelected</code> and <code>iconUnselected</code>.</li> <li>The rating indicator can display half-values ({@link sap.m.RatingIndicatorVisualMode visualMode} = Half) when it is used to show the average. Half-values can't be selected by the user.</li> </ul> <h3>Usage</h3> The preferred number of icons is between 5 (default) and 7. <h3>Responsive Behavior</h3> You can display icons in 4 recommended sizes: <ul> <li>large - 32px</li> <li>medium(default) - 22px</li> <li>small - 16px</li> <li>XS - 12px</li> </ul> <b>Note:</b> If no icon size is set, the rating indicator will set it according to the content density.</h4>
			/// </summary>
			[External]
			[Namespace(false)]
			public partial class RatingIndicator : sap.ui.core.Control, sap.ui.core.IFormContent
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
					/// Value "true" is required to let the user rate with this control. It is recommended to set this parameter to "false" for the "Small" size which is meant for indicating a value only
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> enabled;

					/// <summary>
					/// The number of displayed rating symbols
					/// </summary>
					public Union<int, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> maxValue;

					/// <summary>
					/// The indicated value of the rating
					/// </summary>
					public Union<float, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> value;

					/// <summary>
					/// The Size of the image or icon to be displayed. The default value depends on the theme. Please be sure that the size is corresponding to a full pixel value as some browsers don't support subpixel calculations. Recommended size is 1.375rem (22px) for normal, 1rem (16px) for small, and 2rem (32px) for large icons correspondingly.
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> iconSize;

					/// <summary>
					/// The URI to the icon font icon or image that will be displayed for selected rating symbols. A star icon will be used if the property is not set
					/// </summary>
					public Union<sap.ui.core.URI, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> iconSelected;

					/// <summary>
					/// The URI to the icon font icon or image that will be displayed for all unselected rating symbols. A star icon will be used if the property is not set
					/// </summary>
					public Union<sap.ui.core.URI, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> iconUnselected;

					/// <summary>
					/// The URI to the icon font icon or image that will be displayed for hovered rating symbols. A star icon will be used if the property is not set
					/// </summary>
					public Union<sap.ui.core.URI, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> iconHovered;

					/// <summary>
					/// Defines how float values are visualized: Full, Half (see enumeration RatingIndicatorVisualMode)
					/// </summary>
					public Union<sap.m.RatingIndicatorVisualMode, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> visualMode;

					/// <summary>
					/// The RatingIndicator in displayOnly mode is not interactive, not editable, not focusable, and not in the tab chain. This setting is used for forms in review mode.
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> displayOnly;

					/// <summary>
					/// Defines whether the user is allowed to edit the RatingIndicator. If editable is false the control is focusable, and in the tab chain but not interactive.
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> editable;

					/// <summary>
					/// Association to controls / ids which describe this control (see WAI-ARIA attribute aria-describedby).
					/// </summary>
					public Union<sap.ui.core.Control, sap.ui.core.ID[], string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> ariaDescribedBy;

					/// <summary>
					/// Association to controls / ids which label this control (see WAI-ARIA attribute aria-labelledby).
					/// </summary>
					public Union<sap.ui.core.Control, sap.ui.core.ID[], string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> ariaLabelledBy;

					/// <summary>
					/// The event is fired when the user has done a rating.
					/// </summary>
					public sap.m.RatingIndicator.ChangeDelegate change;

					/// <summary>
					/// This event is triggered during the dragging period, each time the rating value changes.
					/// </summary>
					public sap.m.SliderChangeDelegate liveChange;

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
					/// The rated value
					/// </summary>
					public int value;

				}

				#endregion

				#region Delegates

				public delegate void ChangeDelegate(sap.ui.@base.Event<sap.m.RatingIndicator.ChangeInfo> oEvent, object oData);

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new RatingIndicator.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control Enables users to rate an item on a numeric scale.</param>
				public extern RatingIndicator(string sId, sap.m.RatingIndicator.Settings mSettings);

				/// <summary>
				/// Constructor for a new RatingIndicator.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern RatingIndicator(string sId);

				/// <summary>
				/// Constructor for a new RatingIndicator.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern RatingIndicator();

				/// <summary>
				/// Constructor for a new RatingIndicator.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control Enables users to rate an item on a numeric scale.</param>
				public extern RatingIndicator(sap.m.RatingIndicator.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property enabled

				/// <summary>
				/// Gets current value of property {@link #getEnabled enabled}.
				/// 
				/// Value "true" is required to let the user rate with this control. It is recommended to set this parameter to "false" for the "Small" size which is meant for indicating a value only
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>enabled</code></returns>
				public extern virtual bool getEnabled();

				/// <summary>
				/// Sets a new value for property {@link #getEnabled enabled}.
				/// 
				/// Value "true" is required to let the user rate with this control. It is recommended to set this parameter to "false" for the "Small" size which is meant for indicating a value only
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bEnabled">New value for property <code>enabled</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.RatingIndicator setEnabled(bool bEnabled);

				#endregion

				#region Methods for Property maxValue

				/// <summary>
				/// Gets current value of property {@link #getMaxValue maxValue}.
				/// 
				/// The number of displayed rating symbols
				/// 
				/// Default value is <code>5</code>.
				/// </summary>
				/// <returns>Value of property <code>maxValue</code></returns>
				public extern virtual int getMaxValue();

				/// <summary>
				/// Sets a new value for property {@link #getMaxValue maxValue}.
				/// 
				/// The number of displayed rating symbols
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>5</code>.
				/// </summary>
				/// <param name="iMaxValue">New value for property <code>maxValue</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.RatingIndicator setMaxValue(int iMaxValue);

				#endregion

				#region Methods for Property value

				/// <summary>
				/// Gets current value of property {@link #getValue value}.
				/// 
				/// The indicated value of the rating
				/// 
				/// Default value is <code>0</code>.
				/// </summary>
				/// <returns>Value of property <code>value</code></returns>
				public extern virtual float getValue();

				/// <summary>
				/// Sets the rating value. The method is automatically checking whether the value is in the valid range of 0-{@link #getMaxValue maxValue} and if it is a valid number. Calling the setter with null or undefined will reset the value to it's default.
				/// </summary>
				/// <param name="fValue">The rating value to be set.</param>
				/// <returns>Returns <code>this</code> to facilitate method chaining.</returns>
				public extern virtual sap.m.RatingIndicator setValue(float fValue);

				/// <summary>
				/// Binds property {@link #getValue value} to model data.
				/// 
				/// See {@link sap.ui.base.ManagedObject#bindProperty ManagedObject.bindProperty} for a detailed description of the possible properties of <code>oBindingInfo</code>
				/// </summary>
				/// <param name="oBindingInfo">The binding information</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.RatingIndicator bindValue(object oBindingInfo);

				/// <summary>
				/// Unbinds property {@link #getValue value} from model data.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.RatingIndicator unbindValue();

				#endregion

				#region Methods for Property iconSize

				/// <summary>
				/// Gets current value of property {@link #getIconSize iconSize}.
				/// 
				/// The Size of the image or icon to be displayed. The default value depends on the theme. Please be sure that the size is corresponding to a full pixel value as some browsers don't support subpixel calculations. Recommended size is 1.375rem (22px) for normal, 1rem (16px) for small, and 2rem (32px) for large icons correspondingly.
				/// </summary>
				/// <returns>Value of property <code>iconSize</code></returns>
				public extern virtual sap.ui.core.CSSSize getIconSize();

				/// <summary>
				/// Sets the icon size value. The method automatically updates the UI components if the control has been rendered before.
				/// </summary>
				/// <param name="sIconSize">The size of the icon</param>
				/// <returns>Returns <code>this</code> to facilitate method chaining.</returns>
				public extern virtual sap.m.RatingIndicator setIconSize(sap.ui.core.CSSSize sIconSize);

				#endregion

				#region Methods for Property iconSelected

				/// <summary>
				/// Gets current value of property {@link #getIconSelected iconSelected}.
				/// 
				/// The URI to the icon font icon or image that will be displayed for selected rating symbols. A star icon will be used if the property is not set
				/// </summary>
				/// <returns>Value of property <code>iconSelected</code></returns>
				public extern virtual sap.ui.core.URI getIconSelected();

				/// <summary>
				/// Sets a new value for property {@link #getIconSelected iconSelected}.
				/// 
				/// The URI to the icon font icon or image that will be displayed for selected rating symbols. A star icon will be used if the property is not set
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sIconSelected">New value for property <code>iconSelected</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.RatingIndicator setIconSelected(sap.ui.core.URI sIconSelected);

				#endregion

				#region Methods for Property iconUnselected

				/// <summary>
				/// Gets current value of property {@link #getIconUnselected iconUnselected}.
				/// 
				/// The URI to the icon font icon or image that will be displayed for all unselected rating symbols. A star icon will be used if the property is not set
				/// </summary>
				/// <returns>Value of property <code>iconUnselected</code></returns>
				public extern virtual sap.ui.core.URI getIconUnselected();

				/// <summary>
				/// Sets a new value for property {@link #getIconUnselected iconUnselected}.
				/// 
				/// The URI to the icon font icon or image that will be displayed for all unselected rating symbols. A star icon will be used if the property is not set
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sIconUnselected">New value for property <code>iconUnselected</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.RatingIndicator setIconUnselected(sap.ui.core.URI sIconUnselected);

				#endregion

				#region Methods for Property iconHovered

				/// <summary>
				/// Gets current value of property {@link #getIconHovered iconHovered}.
				/// 
				/// The URI to the icon font icon or image that will be displayed for hovered rating symbols. A star icon will be used if the property is not set
				/// </summary>
				/// <returns>Value of property <code>iconHovered</code></returns>
				public extern virtual sap.ui.core.URI getIconHovered();

				/// <summary>
				/// Sets a new value for property {@link #getIconHovered iconHovered}.
				/// 
				/// The URI to the icon font icon or image that will be displayed for hovered rating symbols. A star icon will be used if the property is not set
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sIconHovered">New value for property <code>iconHovered</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.RatingIndicator setIconHovered(sap.ui.core.URI sIconHovered);

				#endregion

				#region Methods for Property visualMode

				/// <summary>
				/// Gets current value of property {@link #getVisualMode visualMode}.
				/// 
				/// Defines how float values are visualized: Full, Half (see enumeration RatingIndicatorVisualMode)
				/// 
				/// Default value is <code>Half</code>.
				/// </summary>
				/// <returns>Value of property <code>visualMode</code></returns>
				public extern virtual sap.m.RatingIndicatorVisualMode getVisualMode();

				/// <summary>
				/// Sets a new value for property {@link #getVisualMode visualMode}.
				/// 
				/// Defines how float values are visualized: Full, Half (see enumeration RatingIndicatorVisualMode)
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Half</code>.
				/// </summary>
				/// <param name="sVisualMode">New value for property <code>visualMode</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.RatingIndicator setVisualMode(sap.m.RatingIndicatorVisualMode sVisualMode);

				#endregion

				#region Methods for Property displayOnly

				/// <summary>
				/// Gets current value of property {@link #getDisplayOnly displayOnly}.
				/// 
				/// The RatingIndicator in displayOnly mode is not interactive, not editable, not focusable, and not in the tab chain. This setting is used for forms in review mode.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>displayOnly</code></returns>
				public extern virtual bool getDisplayOnly();

				/// <summary>
				/// Sets a new value for property {@link #getDisplayOnly displayOnly}.
				/// 
				/// The RatingIndicator in displayOnly mode is not interactive, not editable, not focusable, and not in the tab chain. This setting is used for forms in review mode.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bDisplayOnly">New value for property <code>displayOnly</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.RatingIndicator setDisplayOnly(bool bDisplayOnly);

				#endregion

				#region Methods for Property editable

				/// <summary>
				/// Gets current value of property {@link #getEditable editable}.
				/// 
				/// Defines whether the user is allowed to edit the RatingIndicator. If editable is false the control is focusable, and in the tab chain but not interactive.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>editable</code></returns>
				public extern virtual bool getEditable();

				/// <summary>
				/// Sets a new value for property {@link #getEditable editable}.
				/// 
				/// Defines whether the user is allowed to edit the RatingIndicator. If editable is false the control is focusable, and in the tab chain but not interactive.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bEditable">New value for property <code>editable</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.RatingIndicator setEditable(bool bEditable);

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
				public extern virtual sap.m.RatingIndicator addAriaDescribedBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaDescribedBy);

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
				public extern virtual sap.m.RatingIndicator addAriaLabelledBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaLabelledBy);

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
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:change change} event of this <code>sap.m.RatingIndicator</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.RatingIndicator</code> itself.
				/// 
				/// The event is fired when the user has done a rating.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.RatingIndicator</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.RatingIndicator attachChange(object oData, sap.m.RatingIndicator.ChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:change change} event of this <code>sap.m.RatingIndicator</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.RatingIndicator</code> itself.
				/// 
				/// The event is fired when the user has done a rating.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.RatingIndicator attachChange(object oData, sap.m.RatingIndicator.ChangeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:change change} event of this <code>sap.m.RatingIndicator</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.RatingIndicator</code> itself.
				/// 
				/// The event is fired when the user has done a rating.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.RatingIndicator attachChange(sap.m.RatingIndicator.ChangeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:change change} event of this <code>sap.m.RatingIndicator</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.RatingIndicator</code> itself.
				/// 
				/// The event is fired when the user has done a rating.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.RatingIndicator</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.RatingIndicator attachChange(sap.m.RatingIndicator.ChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:change change} event of this <code>sap.m.RatingIndicator</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.RatingIndicator detachChange(sap.m.RatingIndicator.ChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:change change} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.RatingIndicator fireChange(sap.m.RatingIndicator.ChangeInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:change change} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.RatingIndicator fireChange();

				#endregion

				#region Methods for Event liveChange

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:liveChange liveChange} event of this <code>sap.m.RatingIndicator</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.RatingIndicator</code> itself.
				/// 
				/// This event is triggered during the dragging period, each time the rating value changes.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.RatingIndicator</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.RatingIndicator attachLiveChange(object oData, sap.m.SliderChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:liveChange liveChange} event of this <code>sap.m.RatingIndicator</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.RatingIndicator</code> itself.
				/// 
				/// This event is triggered during the dragging period, each time the rating value changes.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.RatingIndicator attachLiveChange(object oData, sap.m.SliderChangeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:liveChange liveChange} event of this <code>sap.m.RatingIndicator</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.RatingIndicator</code> itself.
				/// 
				/// This event is triggered during the dragging period, each time the rating value changes.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.RatingIndicator attachLiveChange(sap.m.SliderChangeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:liveChange liveChange} event of this <code>sap.m.RatingIndicator</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.RatingIndicator</code> itself.
				/// 
				/// This event is triggered during the dragging period, each time the rating value changes.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.RatingIndicator</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.RatingIndicator attachLiveChange(sap.m.SliderChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:liveChange liveChange} event of this <code>sap.m.RatingIndicator</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.RatingIndicator detachLiveChange(sap.m.SliderChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:liveChange liveChange} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.RatingIndicator fireLiveChange(sap.m.SliderChangeInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:liveChange liveChange} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.RatingIndicator fireLiveChange();

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.RatingIndicator with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.RatingIndicator with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.RatingIndicator with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <returns>this instance for method chaining</returns>
				public extern virtual sap.m.RatingIndicator getAccessibilityInfo();

				/// <summary>
				/// Returns a metadata object for class sap.m.RatingIndicator.
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
