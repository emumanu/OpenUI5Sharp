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
				/// RatingIndicator is used to let the user do some rating on a given topic. The amount of rating symbols can be specified, as well as the URIs to the image icons which shall be used as rating symbols. When the user performs a rating, an event is fired.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.RatingIndicator")]
				[Obsolete("Deprecated since 1.38. Instead, use the <code>sap.m.RatingIndicator</code> control.")]
				public partial class RatingIndicator : sap.ui.core.Control
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
						/// Determines if the rating symbols can be edited.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> editable;

						/// <summary>
						/// Determines the number of displayed rating symbols
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> maxValue;

						/// <summary>
						/// Determines the currently selected value. If value is set to sap.ui.commons.RatingIndicator.NoValue, the averageValue is shown.
						/// </summary>
						public Union<float, string, sap.ui.@base.ManagedObject.BindPropertyInfo> value;

						/// <summary>
						/// Determines the average value. This value is shown if no value is set. This can be used to display an average Value before the user votes.
						/// </summary>
						public Union<float, string, sap.ui.@base.ManagedObject.BindPropertyInfo> averageValue;

						/// <summary>
						/// The URI to the image which shall be displayed for all selected rating symbols. Note that when this attribute is used, also the other icon attributes need to be set.
						/// </summary>
						public Union<sap.ui.core.URI, string, sap.ui.@base.ManagedObject.BindPropertyInfo> iconSelected;

						/// <summary>
						/// The URI to the image which shall be displayed for all unselected rating symbols. If this attribute is used, a requirement is that all custom icons need to have the same size. Note that when this attribute is used also the other icon attributes need to be set.
						/// </summary>
						public Union<sap.ui.core.URI, string, sap.ui.@base.ManagedObject.BindPropertyInfo> iconUnselected;

						/// <summary>
						/// The URI to the image which is displayed when the mouse hovers onto a rating symbol. If used, a requirement is that all custom icons need to have the same size. Note that when this attribute is used also the other icon attributes need to be set.
						/// </summary>
						public Union<sap.ui.core.URI, string, sap.ui.@base.ManagedObject.BindPropertyInfo> iconHovered;

						/// <summary>
						/// Defines how float values are visualized: Full, Half, Continuous (see enumeration RatingIndicatorVisualMode)
						/// </summary>
						public Union<sap.ui.commons.RatingIndicatorVisualMode, string, sap.ui.@base.ManagedObject.BindPropertyInfo> visualMode;

						/// <summary>
						/// Association to controls / ids which describe this control (see WAI-ARIA attribute aria-describedby).
						/// </summary>
						public Union<sap.ui.core.Control, sap.ui.core.ID[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> ariaDescribedBy;

						/// <summary>
						/// Association to controls / ids which label this control (see WAI-ARIA attribute aria-labelledby).
						/// </summary>
						public Union<sap.ui.core.Control, sap.ui.core.ID[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> ariaLabelledBy;

						/// <summary>
						/// The event is fired when the user has done a rating.
						/// </summary>
						public sap.m.RatingIndicatorDelegate change;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new RatingIndicator.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern RatingIndicator(string sId, sap.ui.commons.RatingIndicator.Settings mSettings);

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
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern RatingIndicator(sap.ui.commons.RatingIndicator.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property editable

					/// <summary>
					/// Gets current value of property {@link #getEditable editable}.
					/// 
					/// Determines if the rating symbols can be edited.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>editable</code></returns>
					public extern virtual bool getEditable();

					/// <summary>
					/// Sets a new value for property {@link #getEditable editable}.
					/// 
					/// Determines if the rating symbols can be edited.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bEditable">New value for property <code>editable</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RatingIndicator setEditable(bool bEditable);

					#endregion

					#region Methods for Property maxValue

					/// <summary>
					/// Gets current value of property {@link #getMaxValue maxValue}.
					/// 
					/// Determines the number of displayed rating symbols
					/// 
					/// Default value is <code>5</code>.
					/// </summary>
					/// <returns>Value of property <code>maxValue</code></returns>
					public extern virtual int getMaxValue();

					/// <summary>
					/// Setter for property <code>maxValue</code>.
					/// 
					/// Default value is <code>5</code> Minimum value is <code>1</code>
					/// </summary>
					/// <param name="iMaxValue">new value for property <code>maxValue</code></param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.commons.RatingIndicator setMaxValue(int iMaxValue);

					#endregion

					#region Methods for Property value

					/// <summary>
					/// Gets current value of property {@link #getValue value}.
					/// 
					/// Determines the currently selected value. If value is set to sap.ui.commons.RatingIndicator.NoValue, the averageValue is shown.
					/// 
					/// Default value is <code>0</code>.
					/// </summary>
					/// <returns>Value of property <code>value</code></returns>
					public extern virtual float getValue();

					/// <summary>
					/// Sets a new value for property {@link #getValue value}.
					/// 
					/// Determines the currently selected value. If value is set to sap.ui.commons.RatingIndicator.NoValue, the averageValue is shown.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>0</code>.
					/// </summary>
					/// <param name="fValue">New value for property <code>value</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RatingIndicator setValue(float fValue);

					/// <summary>
					/// Binds property {@link #getValue value} to model data.
					/// 
					/// See {@link sap.ui.base.ManagedObject#bindProperty ManagedObject.bindProperty} for a detailed description of the possible properties of <code>oBindingInfo</code>
					/// </summary>
					/// <param name="oBindingInfo">The binding information</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RatingIndicator bindValue(object oBindingInfo);

					/// <summary>
					/// Unbinds property {@link #getValue value} from model data.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RatingIndicator unbindValue();

					#endregion

					#region Methods for Property averageValue

					/// <summary>
					/// Gets current value of property {@link #getAverageValue averageValue}.
					/// 
					/// Determines the average value. This value is shown if no value is set. This can be used to display an average Value before the user votes.
					/// 
					/// Default value is <code>0</code>.
					/// </summary>
					/// <returns>Value of property <code>averageValue</code></returns>
					public extern virtual float getAverageValue();

					/// <summary>
					/// Sets a new value for property {@link #getAverageValue averageValue}.
					/// 
					/// Determines the average value. This value is shown if no value is set. This can be used to display an average Value before the user votes.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>0</code>.
					/// </summary>
					/// <param name="fAverageValue">New value for property <code>averageValue</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RatingIndicator setAverageValue(float fAverageValue);

					#endregion

					#region Methods for Property iconSelected

					/// <summary>
					/// Gets current value of property {@link #getIconSelected iconSelected}.
					/// 
					/// The URI to the image which shall be displayed for all selected rating symbols. Note that when this attribute is used, also the other icon attributes need to be set.
					/// </summary>
					/// <returns>Value of property <code>iconSelected</code></returns>
					public extern virtual sap.ui.core.URI getIconSelected();

					/// <summary>
					/// Sets a new value for property {@link #getIconSelected iconSelected}.
					/// 
					/// The URI to the image which shall be displayed for all selected rating symbols. Note that when this attribute is used, also the other icon attributes need to be set.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sIconSelected">New value for property <code>iconSelected</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RatingIndicator setIconSelected(sap.ui.core.URI sIconSelected);

					#endregion

					#region Methods for Property iconUnselected

					/// <summary>
					/// Gets current value of property {@link #getIconUnselected iconUnselected}.
					/// 
					/// The URI to the image which shall be displayed for all unselected rating symbols. If this attribute is used, a requirement is that all custom icons need to have the same size. Note that when this attribute is used also the other icon attributes need to be set.
					/// </summary>
					/// <returns>Value of property <code>iconUnselected</code></returns>
					public extern virtual sap.ui.core.URI getIconUnselected();

					/// <summary>
					/// Sets a new value for property {@link #getIconUnselected iconUnselected}.
					/// 
					/// The URI to the image which shall be displayed for all unselected rating symbols. If this attribute is used, a requirement is that all custom icons need to have the same size. Note that when this attribute is used also the other icon attributes need to be set.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sIconUnselected">New value for property <code>iconUnselected</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RatingIndicator setIconUnselected(sap.ui.core.URI sIconUnselected);

					#endregion

					#region Methods for Property iconHovered

					/// <summary>
					/// Gets current value of property {@link #getIconHovered iconHovered}.
					/// 
					/// The URI to the image which is displayed when the mouse hovers onto a rating symbol. If used, a requirement is that all custom icons need to have the same size. Note that when this attribute is used also the other icon attributes need to be set.
					/// </summary>
					/// <returns>Value of property <code>iconHovered</code></returns>
					public extern virtual sap.ui.core.URI getIconHovered();

					/// <summary>
					/// Sets a new value for property {@link #getIconHovered iconHovered}.
					/// 
					/// The URI to the image which is displayed when the mouse hovers onto a rating symbol. If used, a requirement is that all custom icons need to have the same size. Note that when this attribute is used also the other icon attributes need to be set.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sIconHovered">New value for property <code>iconHovered</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RatingIndicator setIconHovered(sap.ui.core.URI sIconHovered);

					#endregion

					#region Methods for Property visualMode

					/// <summary>
					/// Gets current value of property {@link #getVisualMode visualMode}.
					/// 
					/// Defines how float values are visualized: Full, Half, Continuous (see enumeration RatingIndicatorVisualMode)
					/// 
					/// Default value is <code>Half</code>.
					/// </summary>
					/// <returns>Value of property <code>visualMode</code></returns>
					public extern virtual sap.ui.commons.RatingIndicatorVisualMode getVisualMode();

					/// <summary>
					/// Sets a new value for property {@link #getVisualMode visualMode}.
					/// 
					/// Defines how float values are visualized: Full, Half, Continuous (see enumeration RatingIndicatorVisualMode)
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>Half</code>.
					/// </summary>
					/// <param name="sVisualMode">New value for property <code>visualMode</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RatingIndicator setVisualMode(sap.ui.commons.RatingIndicatorVisualMode sVisualMode);

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
					public extern virtual sap.ui.commons.RatingIndicator addAriaDescribedBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaDescribedBy);

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
					public extern virtual sap.ui.commons.RatingIndicator addAriaLabelledBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaLabelledBy);

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
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:change change} event of this <code>sap.ui.commons.RatingIndicator</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.RatingIndicator</code> itself.
					/// 
					/// The event is fired when the user has done a rating.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.RatingIndicator</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RatingIndicator attachChange(object oData, sap.m.RatingIndicatorDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:change change} event of this <code>sap.ui.commons.RatingIndicator</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.RatingIndicator</code> itself.
					/// 
					/// The event is fired when the user has done a rating.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RatingIndicator attachChange(object oData, sap.m.RatingIndicatorDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:change change} event of this <code>sap.ui.commons.RatingIndicator</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.RatingIndicator</code> itself.
					/// 
					/// The event is fired when the user has done a rating.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RatingIndicator attachChange(sap.m.RatingIndicatorDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:change change} event of this <code>sap.ui.commons.RatingIndicator</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.RatingIndicator</code> itself.
					/// 
					/// The event is fired when the user has done a rating.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.RatingIndicator</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RatingIndicator attachChange(sap.m.RatingIndicatorDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:change change} event of this <code>sap.ui.commons.RatingIndicator</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RatingIndicator detachChange(sap.m.RatingIndicatorDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:change change} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RatingIndicator fireChange(sap.m.RatingIndicatorInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:change change} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RatingIndicator fireChange();

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.RatingIndicator with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.RatingIndicator with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.RatingIndicator with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					public extern virtual void getAccessibilityInfo();

					/// <summary>
					/// Returns a metadata object for class sap.ui.commons.RatingIndicator.
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
