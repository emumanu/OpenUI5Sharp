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
				/// The RadioButtonGroup is a basic control that is used to provide area for making interactive choice out of a set of options. It represents a list with items where exactly one item can be selected in a session. For the representation of the single group entries, the RadioButton items are created automatically. For the RadioButton choice, mouse and keyboard navigation usage is supported.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.RadioButtonGroup")]
				[Obsolete("Deprecated since 1.38. Instead, use the <code>sap.m.RadioButtonGroup</code> control.")]
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
						/// Defines the width of the RadioButtonGroup.
						/// </summary>
						public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> width;

						/// <summary>
						/// Determines the maximum number of RadioButtons displayed in one line.
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> columns;

						/// <summary>
						/// Specifies whether the user can change the selected value of the RadioButtonGroup. When the property is set to false, the control obtains visual styles different from its visual styles for the normal and the disabled state. Additionally the control is no longer interactive, but can receive focus.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> editable;

						/// <summary>
						/// Тhe value state to be displayed for the RadioButton. Possible values are: sap.ui.core.ValueState.Error, sap.ui.core.ValueState.Warning, sap.ui.core.ValueState.Success and sap.ui.core.ValueState.None. Note: Setting this attribute to sap.ui.core.ValueState.Error when the accessibility feature is enabled, sets the value of the invalid property for the whole RadioButtonGroup to true.
						/// </summary>
						public Union<sap.ui.core.ValueState, string, sap.ui.@base.ManagedObject.BindPropertyInfo> valueState;

						/// <summary>
						/// The index of the selected/checked RadioButton.
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> selectedIndex;

						/// <summary>
						/// Enables/disables the RadioButtonGroup. If it is disabled all RadioButtons will be displayed as disabled. The enabled property of the Item will not be used in this case. If the RadioButtonGroup is enabled, the enabled property of the Item will define if a RadioButton is enabled or not.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> enabled;

						/// <summary>
						/// The RadioButtons of this RadioButtonGroup.
						/// </summary>
						public Union<sap.ui.core.Item[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> items;

						/// <summary>
						/// Association to controls / IDs, which describe this control (see WAI-ARIA attribute aria-describedby).
						/// </summary>
						public Union<sap.ui.core.Control, sap.ui.core.ID[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> ariaDescribedBy;

						/// <summary>
						/// Association to controls / IDs, which label this control (see WAI-ARIA attribute aria-labelledby).
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
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern RadioButtonGroup(string sId, sap.ui.commons.RadioButtonGroup.Settings mSettings);

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
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern RadioButtonGroup(sap.ui.commons.RadioButtonGroup.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property width

					/// <summary>
					/// Gets current value of property {@link #getWidth width}.
					/// 
					/// Defines the width of the RadioButtonGroup.
					/// </summary>
					/// <returns>Value of property <code>width</code></returns>
					public extern virtual sap.ui.core.CSSSize getWidth();

					/// <summary>
					/// Sets a new value for property {@link #getWidth width}.
					/// 
					/// Defines the width of the RadioButtonGroup.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sWidth">New value for property <code>width</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RadioButtonGroup setWidth(sap.ui.core.CSSSize sWidth);

					#endregion

					#region Methods for Property columns

					/// <summary>
					/// Gets current value of property {@link #getColumns columns}.
					/// 
					/// Determines the maximum number of RadioButtons displayed in one line.
					/// 
					/// Default value is <code>1</code>.
					/// </summary>
					/// <returns>Value of property <code>columns</code></returns>
					public extern virtual int getColumns();

					/// <summary>
					/// Sets a new value for property {@link #getColumns columns}.
					/// 
					/// Determines the maximum number of RadioButtons displayed in one line.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>1</code>.
					/// </summary>
					/// <param name="iColumns">New value for property <code>columns</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RadioButtonGroup setColumns(int iColumns);

					#endregion

					#region Methods for Property editable

					/// <summary>
					/// Gets current value of property {@link #getEditable editable}.
					/// 
					/// Specifies whether the user can change the selected value of the RadioButtonGroup. When the property is set to false, the control obtains visual styles different from its visual styles for the normal and the disabled state. Additionally the control is no longer interactive, but can receive focus.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>editable</code></returns>
					public extern virtual bool getEditable();

					/// <summary>
					/// Sets a new value for property {@link #getEditable editable}.
					/// 
					/// Specifies whether the user can change the selected value of the RadioButtonGroup. When the property is set to false, the control obtains visual styles different from its visual styles for the normal and the disabled state. Additionally the control is no longer interactive, but can receive focus.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bEditable">New value for property <code>editable</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RadioButtonGroup setEditable(bool bEditable);

					#endregion

					#region Methods for Property valueState

					/// <summary>
					/// Gets current value of property {@link #getValueState valueState}.
					/// 
					/// Тhe value state to be displayed for the RadioButton. Possible values are: sap.ui.core.ValueState.Error, sap.ui.core.ValueState.Warning, sap.ui.core.ValueState.Success and sap.ui.core.ValueState.None. Note: Setting this attribute to sap.ui.core.ValueState.Error when the accessibility feature is enabled, sets the value of the invalid property for the whole RadioButtonGroup to true.
					/// 
					/// Default value is <code>None</code>.
					/// </summary>
					/// <returns>Value of property <code>valueState</code></returns>
					public extern virtual sap.ui.core.ValueState getValueState();

					/// <summary>
					/// Sets a new value for property {@link #getValueState valueState}.
					/// 
					/// Тhe value state to be displayed for the RadioButton. Possible values are: sap.ui.core.ValueState.Error, sap.ui.core.ValueState.Warning, sap.ui.core.ValueState.Success and sap.ui.core.ValueState.None. Note: Setting this attribute to sap.ui.core.ValueState.Error when the accessibility feature is enabled, sets the value of the invalid property for the whole RadioButtonGroup to true.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>None</code>.
					/// </summary>
					/// <param name="sValueState">New value for property <code>valueState</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RadioButtonGroup setValueState(sap.ui.core.ValueState sValueState);

					#endregion

					#region Methods for Property selectedIndex

					/// <summary>
					/// Gets current value of property {@link #getSelectedIndex selectedIndex}.
					/// 
					/// The index of the selected/checked RadioButton.
					/// 
					/// Default value is <code>0</code>.
					/// </summary>
					/// <returns>Value of property <code>selectedIndex</code></returns>
					public extern virtual int getSelectedIndex();

					/// <summary>
					/// Sets a new value for property {@link #getSelectedIndex selectedIndex}.
					/// 
					/// The index of the selected/checked RadioButton.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>0</code>.
					/// </summary>
					/// <param name="iSelectedIndex">New value for property <code>selectedIndex</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RadioButtonGroup setSelectedIndex(int iSelectedIndex);

					#endregion

					#region Methods for Property enabled

					/// <summary>
					/// Gets current value of property {@link #getEnabled enabled}.
					/// 
					/// Enables/disables the RadioButtonGroup. If it is disabled all RadioButtons will be displayed as disabled. The enabled property of the Item will not be used in this case. If the RadioButtonGroup is enabled, the enabled property of the Item will define if a RadioButton is enabled or not.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>enabled</code></returns>
					public extern virtual bool getEnabled();

					/// <summary>
					/// Sets a new value for property {@link #getEnabled enabled}.
					/// 
					/// Enables/disables the RadioButtonGroup. If it is disabled all RadioButtons will be displayed as disabled. The enabled property of the Item will not be used in this case. If the RadioButtonGroup is enabled, the enabled property of the Item will define if a RadioButton is enabled or not.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bEnabled">New value for property <code>enabled</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RadioButtonGroup setEnabled(bool bEnabled);

					#endregion

					#region Methods for Aggregation items

					/// <summary>
					/// Gets content of aggregation {@link #getItems items}.
					/// 
					/// The RadioButtons of this RadioButtonGroup.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.Item[] getItems();

					/// <summary>
					/// Destroys all the items in the aggregation {@link #getItems items}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RadioButtonGroup destroyItems();

					/// <summary>
					/// Inserts a item into the aggregation {@link #getItems items}.
					/// </summary>
					/// <param name="oItem">The item to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the item should be inserted at; for a negative value of <code>iIndex</code>, the item is inserted at position 0; for a value greater than the current size of the aggregation, the item is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RadioButtonGroup insertItem(sap.ui.core.Item oItem, int iIndex);

					/// <summary>
					/// Adds some item to the aggregation {@link #getItems items}.
					/// </summary>
					/// <param name="oItem">The item to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RadioButtonGroup addItem(sap.ui.core.Item oItem);

					/// <summary>
					/// Removes a item from the aggregation {@link #getItems items}.
					/// </summary>
					/// <param name="vItem">The item to remove or its index or id</param>
					/// <returns>The removed item or <code>null</code></returns>
					public extern virtual sap.ui.core.Item removeItem(Union<int, string, sap.ui.core.Item> vItem);

					/// <summary>
					/// Checks for the provided <code>sap.ui.core.Item</code> in the aggregation {@link #getItems items}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oItem">The item whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfItem(sap.ui.core.Item oItem);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getItems items}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.core.Item[] removeAllItems();

					/// <summary>
					/// Binds aggregation {@link #getItems items} to model data.
					/// 
					/// See {@link sap.ui.base.ManagedObject#bindAggregation ManagedObject.bindAggregation} for a detailed description of the possible properties of <code>oBindingInfo</code>.
					/// </summary>
					/// <param name="oBindingInfo">The binding information</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RadioButtonGroup bindItems(sap.ui.@base.ManagedObject.BindAggregationInfo oBindingInfo);

					/// <summary>
					/// Unbinds aggregation {@link #getItems items} from model data.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RadioButtonGroup unbindItems();

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
					public extern virtual sap.ui.commons.RadioButtonGroup addAriaDescribedBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaDescribedBy);

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
					public extern virtual sap.ui.commons.RadioButtonGroup addAriaLabelledBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaLabelledBy);

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
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.ui.commons.RadioButtonGroup</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.RadioButtonGroup</code> itself.
					/// 
					/// Fires when selection is changed by user interaction.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.RadioButtonGroup</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RadioButtonGroup attachSelect(object oData, sap.m.RadioButtonGroupDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.ui.commons.RadioButtonGroup</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.RadioButtonGroup</code> itself.
					/// 
					/// Fires when selection is changed by user interaction.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RadioButtonGroup attachSelect(object oData, sap.m.RadioButtonGroupDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.ui.commons.RadioButtonGroup</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.RadioButtonGroup</code> itself.
					/// 
					/// Fires when selection is changed by user interaction.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RadioButtonGroup attachSelect(sap.m.RadioButtonGroupDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.ui.commons.RadioButtonGroup</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.RadioButtonGroup</code> itself.
					/// 
					/// Fires when selection is changed by user interaction.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.RadioButtonGroup</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RadioButtonGroup attachSelect(sap.m.RadioButtonGroupDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:select select} event of this <code>sap.ui.commons.RadioButtonGroup</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RadioButtonGroup detachSelect(sap.m.RadioButtonGroupDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:select select} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RadioButtonGroup fireSelect(sap.m.RadioButtonGroupInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:select select} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RadioButtonGroup fireSelect();

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new instance of RadioButtonGroup, with the same settings as the RadioButtonGroup on which the method is called. Event handlers are not cloned.
					/// </summary>
					/// <returns>New instance of RadioButtonGroup</returns>
					public extern virtual sap.ui.commons.RadioButtonGroup clone();

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.RadioButtonGroup with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.RadioButtonGroup with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.RadioButtonGroup with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.commons.RadioButtonGroup.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					[Name("getMetadata")]
					public extern static sap.ui.@base.Metadata getMetadataStatic();

					/// <summary>
					/// When no item is selected, "null" is returned.
					/// </summary>
					/// <returns>Selected Item</returns>
					public extern virtual sap.ui.core.Item getSelectedItem();

					/// <summary>
					/// Sets the Item as selected and removes the selection from the previous one.
					/// </summary>
					/// <param name="oSelectedItem">Selected item</param>
					public extern virtual void setSelectedItem(sap.ui.core.Item oSelectedItem);

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
