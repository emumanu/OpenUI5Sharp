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
			/// This control is used as a wrapper for a group of {@link sap.m.RadioButton} controls, which can be used as a single UI element. You can select only one of the grouped radio buttons at a time. <h3>Structure</h3> <ul> <li>The radio buttons are stored in the <code>buttons</code> aggregation.</li> <li>By setting the <code>columns</code> property, you can create layouts like a 'matrix', 'vertical' or 'horizontal'.</li> <li><b>Note:</b>For proper display on all devices, we recommend creating radio button groups with only one row or only one column.</li> </ul> <h3>Usage</h3> <h4>When to use:</h4> <ul> <li>You want to attach a single event handler on a group of buttons, rather than on each individual button.</li> </ul> <h4>When not to use:</h4> <ul> <li>Do not put two radio button groups right next to each other as it is difficult to determine which buttons belong to which group.</li> </ul>
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.RadioButtonGroup")]
			public partial class RadioButtonGroup : sap.ui.core.Control, sap.ui.core.IFormContent
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
					/// Specifies the width of the RadioButtonGroup.
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> width;

					/// <summary>
					/// Specifies the maximum number of radio buttons displayed in one line.
					/// </summary>
					public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> columns;

					/// <summary>
					/// Specifies whether the user can change the selected value of the RadioButtonGroup. When the property is set to false, the control obtains visual styles different from its visual styles for the normal and the disabled state. Additionally, the control is no longer interactive, but can receive focus.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> editable;

					/// <summary>
					/// The value state to be displayed for the radio button. Possible values are: sap.ui.core.ValueState.Error, sap.ui.core.ValueState.Warning, sap.ui.core.ValueState.Success and sap.ui.core.ValueState.None. Note: Setting this attribute to sap.ui.core.ValueState.Error when the accessibility feature is enabled, sets the value of the invalid property for the whole RadioButtonGroup to "true".
					/// </summary>
					public Union<sap.ui.core.ValueState, string, sap.ui.@base.ManagedObject.BindPropertyInfo> valueState;

					/// <summary>
					/// Determines the index of the selected/checked RadioButton. Default is 0. If no radio button is selected, the selectedIndex property will return -1.
					/// </summary>
					public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> selectedIndex;

					/// <summary>
					/// Switches the enabled state of the control. All Radio Buttons inside a disabled group are disabled. Default value is "true".
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> enabled;

					/// <summary>
					/// This property specifies the element's text directionality with enumerated options. By default, the control inherits text direction from the DOM.
					/// </summary>
					public Union<sap.ui.core.TextDirection, string, sap.ui.@base.ManagedObject.BindPropertyInfo> textDirection;

					/// <summary>
					/// Returns a list of the RadioButtons in a RadioButtonGroup
					/// </summary>
					public Union<sap.m.RadioButton[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> buttons;

					/// <summary>
					/// Association to controls / IDs which describe this control (see WAI-ARIA attribute aria-describedby).
					/// </summary>
					public Union<sap.ui.core.Control, sap.ui.core.ID[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> ariaDescribedBy;

					/// <summary>
					/// Association to controls / IDs which label this control (see WAI-ARIA attribute aria-labelledby).
					/// </summary>
					public Union<sap.ui.core.Control, sap.ui.core.ID[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> ariaLabelledBy;

					/// <summary>
					/// Fires when selection is changed by user interaction.
					/// </summary>
					public sap.m.RadioButtonGroupDelegate select;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new RadioButtonGroup.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control A wrapper control for a group of radio buttons.</param>
				public extern RadioButtonGroup(string sId, sap.m.RadioButtonGroup.Settings mSettings);

				/// <summary>
				/// Constructor for a new RadioButtonGroup.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern RadioButtonGroup(string sId);

				/// <summary>
				/// Constructor for a new RadioButtonGroup.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern RadioButtonGroup();

				/// <summary>
				/// Constructor for a new RadioButtonGroup.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control A wrapper control for a group of radio buttons.</param>
				public extern RadioButtonGroup(sap.m.RadioButtonGroup.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property width

				/// <summary>
				/// Gets current value of property {@link #getWidth width}.
				/// 
				/// Specifies the width of the RadioButtonGroup.
				/// </summary>
				/// <returns>Value of property <code>width</code></returns>
				public extern virtual sap.ui.core.CSSSize getWidth();

				/// <summary>
				/// Sets a new value for property {@link #getWidth width}.
				/// 
				/// Specifies the width of the RadioButtonGroup.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sWidth">New value for property <code>width</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.RadioButtonGroup setWidth(sap.ui.core.CSSSize sWidth);

				#endregion

				#region Methods for Property columns

				/// <summary>
				/// Gets current value of property {@link #getColumns columns}.
				/// 
				/// Specifies the maximum number of radio buttons displayed in one line.
				/// 
				/// Default value is <code>1</code>.
				/// </summary>
				/// <returns>Value of property <code>columns</code></returns>
				public extern virtual int getColumns();

				/// <summary>
				/// Sets a new value for property {@link #getColumns columns}.
				/// 
				/// Specifies the maximum number of radio buttons displayed in one line.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>1</code>.
				/// </summary>
				/// <param name="iColumns">New value for property <code>columns</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.RadioButtonGroup setColumns(int iColumns);

				#endregion

				#region Methods for Property editable

				/// <summary>
				/// Gets current value of property {@link #getEditable editable}.
				/// 
				/// Specifies whether the user can change the selected value of the RadioButtonGroup. When the property is set to false, the control obtains visual styles different from its visual styles for the normal and the disabled state. Additionally, the control is no longer interactive, but can receive focus.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>editable</code></returns>
				public extern virtual bool getEditable();

				/// <summary>
				/// Sets the editable property of the RadioButtonGroup. Single buttons preserve the value of their editable property. If the group is set to editable=false the buttons are also displayed and function as read only. Non editable radio buttons can still obtain focus.
				/// </summary>
				/// <param name="bEditable">Defines whether the radio buttons should be interactive.</param>
				/// <returns>Pointer to the control instance for chaining.</returns>
				public extern virtual sap.m.RadioButtonGroup setEditable(bool bEditable);

				#endregion

				#region Methods for Property valueState

				/// <summary>
				/// Gets current value of property {@link #getValueState valueState}.
				/// 
				/// The value state to be displayed for the radio button. Possible values are: sap.ui.core.ValueState.Error, sap.ui.core.ValueState.Warning, sap.ui.core.ValueState.Success and sap.ui.core.ValueState.None. Note: Setting this attribute to sap.ui.core.ValueState.Error when the accessibility feature is enabled, sets the value of the invalid property for the whole RadioButtonGroup to "true".
				/// 
				/// Default value is <code>None</code>.
				/// </summary>
				/// <returns>Value of property <code>valueState</code></returns>
				public extern virtual sap.ui.core.ValueState getValueState();

				/// <summary>
				/// Sets ValueState of all radio buttons in the group.
				/// </summary>
				/// <param name="sValueState">The value state of the radio group - none, success, warning, error.</param>
				/// <returns>Pointer to the control instance for chaining.</returns>
				public extern virtual sap.m.RadioButtonGroup setValueState(string sValueState);

				#endregion

				#region Methods for Property selectedIndex

				/// <summary>
				/// Gets current value of property {@link #getSelectedIndex selectedIndex}.
				/// 
				/// Determines the index of the selected/checked RadioButton. Default is 0. If no radio button is selected, the selectedIndex property will return -1.
				/// 
				/// Default value is <code>0</code>.
				/// </summary>
				/// <returns>Value of property <code>selectedIndex</code></returns>
				public extern virtual int getSelectedIndex();

				/// <summary>
				/// Sets the selected sap.m.RadioButton using index.
				/// </summary>
				/// <param name="iSelectedIndex">The index of the radio button which has to be selected.</param>
				/// <returns>Pointer to the control instance for chaining.</returns>
				public extern virtual sap.m.RadioButtonGroup setSelectedIndex(int iSelectedIndex);

				#endregion

				#region Methods for Property enabled

				/// <summary>
				/// Gets current value of property {@link #getEnabled enabled}.
				/// 
				/// Switches the enabled state of the control. All Radio Buttons inside a disabled group are disabled. Default value is "true".
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>enabled</code></returns>
				public extern virtual bool getEnabled();

				/// <summary>
				/// Sets the enabled property of the RadioButtonGroup. Single buttons preserve internally the value of their enabled property. If the group is set to enabled=false the buttons are also displayed as disabled and getEnabled returns false.
				/// </summary>
				/// <param name="bEnabled">Defines whether the radio buttons should be interactive.</param>
				/// <returns>Pointer to the control instance for chaining.</returns>
				public extern virtual sap.m.RadioButtonGroup setEnabled(bool bEnabled);

				#endregion

				#region Methods for Property textDirection

				/// <summary>
				/// Gets current value of property {@link #getTextDirection textDirection}.
				/// 
				/// This property specifies the element's text directionality with enumerated options. By default, the control inherits text direction from the DOM.
				/// 
				/// Default value is <code>Inherit</code>.
				/// </summary>
				/// <returns>Value of property <code>textDirection</code></returns>
				public extern virtual sap.ui.core.TextDirection getTextDirection();

				/// <summary>
				/// Sets a new value for property {@link #getTextDirection textDirection}.
				/// 
				/// This property specifies the element's text directionality with enumerated options. By default, the control inherits text direction from the DOM.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Inherit</code>.
				/// </summary>
				/// <param name="sTextDirection">New value for property <code>textDirection</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.RadioButtonGroup setTextDirection(sap.ui.core.TextDirection sTextDirection);

				#endregion

				#region Methods for Aggregation buttons

				/// <summary>
				/// Gets content of aggregation {@link #getButtons buttons}.
				/// 
				/// Returns a list of the RadioButtons in a RadioButtonGroup
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.RadioButton[] getButtons();

				/// <summary>
				/// Destroys all radio buttons.
				/// </summary>
				/// <returns>Pointer to the control instance for chaining.</returns>
				public extern virtual sap.m.RadioButtonGroup destroyButtons();

				/// <summary>
				/// Adds a new radio button to the group at a specified index.
				/// </summary>
				/// <param name="oButton">The radio button which will be added to the group.</param>
				/// <param name="iIndex">The index, at which the radio button will be added.</param>
				/// <returns>Pointer to the control instance for chaining.</returns>
				public extern virtual sap.m.RadioButtonGroup insertButton(sap.m.RadioButton oButton, int iIndex);

				/// <summary>
				/// Adds a new radio button to the group.
				/// </summary>
				/// <param name="oButton">The button which will be added to the group.</param>
				/// <returns>Pointer to the control instance for chaining.</returns>
				public extern virtual sap.m.RadioButtonGroup addButton(sap.m.RadioButton oButton);

				/// <summary>
				/// Removes a radio button from the group.
				/// </summary>
				/// <returns>vElement The removed radio button.</returns>
				public extern virtual sap.m.RadioButton removeButton();

				/// <summary>
				/// Checks for the provided <code>sap.m.RadioButton</code> in the aggregation {@link #getButtons buttons}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oButton">The button whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfButton(sap.m.RadioButton oButton);

				/// <summary>
				/// Removes all radio buttons.
				/// </summary>
				/// <returns>Array of removed buttons or null.</returns>
				public extern virtual object[] removeAllButtons();

				/// <summary>
				/// Binds aggregation {@link #getButtons buttons} to model data.
				/// 
				/// See {@link sap.ui.base.ManagedObject#bindAggregation ManagedObject.bindAggregation} for a detailed description of the possible properties of <code>oBindingInfo</code>.
				/// </summary>
				/// <param name="oBindingInfo">The binding information</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.RadioButtonGroup bindButtons(object oBindingInfo);

				/// <summary>
				/// Unbinds aggregation {@link #getButtons buttons} from model data.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.RadioButtonGroup unbindButtons();

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
				public extern virtual sap.m.RadioButtonGroup addAriaDescribedBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaDescribedBy);

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
				public extern virtual sap.m.RadioButtonGroup addAriaLabelledBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaLabelledBy);

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

				#region Methods for Event select

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.m.RadioButtonGroup</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.RadioButtonGroup</code> itself.
				/// 
				/// Fires when selection is changed by user interaction.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.RadioButtonGroup</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.RadioButtonGroup attachSelect(object oData, sap.m.RadioButtonGroupDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.m.RadioButtonGroup</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.RadioButtonGroup</code> itself.
				/// 
				/// Fires when selection is changed by user interaction.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.RadioButtonGroup attachSelect(object oData, sap.m.RadioButtonGroupDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.m.RadioButtonGroup</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.RadioButtonGroup</code> itself.
				/// 
				/// Fires when selection is changed by user interaction.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.RadioButtonGroup attachSelect(sap.m.RadioButtonGroupDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.m.RadioButtonGroup</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.RadioButtonGroup</code> itself.
				/// 
				/// Fires when selection is changed by user interaction.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.RadioButtonGroup</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.RadioButtonGroup attachSelect(sap.m.RadioButtonGroupDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:select select} event of this <code>sap.m.RadioButtonGroup</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.RadioButtonGroup detachSelect(sap.m.RadioButtonGroupDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:select select} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.RadioButtonGroup fireSelect(sap.m.RadioButtonGroupInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:select select} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.RadioButtonGroup fireSelect();

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new instance of RadioButtonGroup, with the same settings as the RadioButtonGroup on which the method is called. Event handlers are not cloned.
				/// </summary>
				/// <returns>New instance of RadioButtonGroup</returns>
				public extern virtual sap.m.RadioButtonGroup clone();

				/// <summary>
				/// Exits the radio button group.
				/// </summary>
				public extern override void exit();

				/// <summary>
				/// Creates a new subclass of class sap.m.RadioButtonGroup with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.RadioButtonGroup with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.RadioButtonGroup with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.RadioButtonGroup.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				/// <summary>
				/// Returns the selected radio button.
				/// </summary>
				/// <returns>The selected radio button.</returns>
				public extern virtual sap.m.RadioButton getSelectedButton();

				/// <summary>
				/// Overwrites the onAfterRendering
				/// </summary>
				public extern override void onAfterRendering();

				/// <summary>
				/// Overwrites the onBeforeRendering method.
				/// </summary>
				public extern override void onBeforeRendering();

				/// <summary>
				/// Sets the selected sap.m.RadioButton using sap.m.RadioButton.
				/// </summary>
				/// <param name="oSelectedButton">The item to be selected.</param>
				/// <returns>Pointer to the control instance for chaining.</returns>
				public extern virtual sap.m.RadioButtonGroup setSelectedButton(sap.m.RadioButton oSelectedButton);

				/// <summary>
				/// Updates the buttons in the group.
				/// </summary>
				public extern virtual void updateButtons();

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
