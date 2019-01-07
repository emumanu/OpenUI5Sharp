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
				/// RadioButton is a control similar to CheckBox, but it allows the user to choose only one of the predefined set of options.
				/// 
				/// Usually, RadioButton is used in a group with other RadioButtons (with the groupName property or by using sap.ui.commons.RadioButtonGroup), thus providing a limited choice for the user. An event is triggered when the user makes a change of the selection.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.RadioButton")]
				[Obsolete("Deprecated since 1.38. Instead, use the <code>sap.m.RadioButton</code> control.")]
				public partial class RadioButton : sap.ui.core.Control, sap.ui.core.IFormContent
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
						/// Defines the text displayed next to the RadioButton.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> text;

						/// <summary>
						/// Displays the disabled controls in another color, depending on the customer settings.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> enabled;

						/// <summary>
						/// Specifies whether the user can select the RadioButton.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> editable;

						/// <summary>
						/// Specifies the select state of the RadioButton.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> selected;

						/// <summary>
						/// Enumeration sap.ui.core.ValueState provides state values Error, Success, Warning and None.
						/// </summary>
						public Union<sap.ui.core.ValueState, string, sap.ui.@base.ManagedObject.BindPropertyInfo> valueState;

						/// <summary>
						/// Determines the control width. By default, it depends on the text length. Alternatively, CSS sizes in % or px can be set.
						/// </summary>
						public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> width;

						/// <summary>
						/// Defines the text direction - options are left-to-right (LTR) and right-to-left (RTL). Alternatively, the control can inherit the text direction from its parent container.
						/// </summary>
						public Union<sap.ui.core.TextDirection, string, sap.ui.@base.ManagedObject.BindPropertyInfo> textDirection;

						/// <summary>
						/// Defines the name of the RadioButtonGroup, in which the current RadioButton belongs to. You can define a new name for the group. If no new name is specified, the default is sapUiRbDefaultGroup. By default, when one of the RadioButtons in a group is selected, all others are unselected.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> groupName;

						/// <summary>
						/// Can be used for subsequent actions.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> key;

						/// <summary>
						/// Association to controls / IDs, which describe this control (see WAI-ARIA attribute aria-describedby).
						/// </summary>
						public Union<sap.ui.core.Control, sap.ui.core.ID[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> ariaDescribedBy;

						/// <summary>
						/// Association to controls / IDs, which label this control (see WAI-ARIA attribute aria-labelledby).
						/// </summary>
						public Union<sap.ui.core.Control, sap.ui.core.ID[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> ariaLabelledBy;

						/// <summary>
						/// Triggers when the user makes a change on the RadioButton.
						/// </summary>
						public sap.ui.@base.EventDelegate select;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new RadioButton.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern RadioButton(string sId, sap.ui.commons.RadioButton.Settings mSettings);

					/// <summary>
					/// Constructor for a new RadioButton.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					public extern RadioButton(string sId);

					/// <summary>
					/// Constructor for a new RadioButton.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern RadioButton();

					/// <summary>
					/// Constructor for a new RadioButton.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern RadioButton(sap.ui.commons.RadioButton.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property text

					/// <summary>
					/// Gets current value of property {@link #getText text}.
					/// 
					/// Defines the text displayed next to the RadioButton.
					/// </summary>
					/// <returns>Value of property <code>text</code></returns>
					public extern virtual string getText();

					/// <summary>
					/// Sets a new value for property {@link #getText text}.
					/// 
					/// Defines the text displayed next to the RadioButton.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sText">New value for property <code>text</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RadioButton setText(string sText);

					#endregion

					#region Methods for Property enabled

					/// <summary>
					/// Gets current value of property {@link #getEnabled enabled}.
					/// 
					/// Displays the disabled controls in another color, depending on the customer settings.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>enabled</code></returns>
					public extern virtual bool getEnabled();

					/// <summary>
					/// Sets a new value for property {@link #getEnabled enabled}.
					/// 
					/// Displays the disabled controls in another color, depending on the customer settings.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bEnabled">New value for property <code>enabled</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RadioButton setEnabled(bool bEnabled);

					#endregion

					#region Methods for Property editable

					/// <summary>
					/// Gets current value of property {@link #getEditable editable}.
					/// 
					/// Specifies whether the user can select the RadioButton.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>editable</code></returns>
					public extern virtual bool getEditable();

					/// <summary>
					/// Sets a new value for property {@link #getEditable editable}.
					/// 
					/// Specifies whether the user can select the RadioButton.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bEditable">New value for property <code>editable</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RadioButton setEditable(bool bEditable);

					#endregion

					#region Methods for Property selected

					/// <summary>
					/// Gets current value of property {@link #getSelected selected}.
					/// 
					/// Specifies the select state of the RadioButton.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>selected</code></returns>
					public extern virtual bool getSelected();

					/// <summary>
					/// Sets a new value for property {@link #getSelected selected}.
					/// 
					/// Specifies the select state of the RadioButton.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bSelected">New value for property <code>selected</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RadioButton setSelected(bool bSelected);

					#endregion

					#region Methods for Property valueState

					/// <summary>
					/// Gets current value of property {@link #getValueState valueState}.
					/// 
					/// Enumeration sap.ui.core.ValueState provides state values Error, Success, Warning and None.
					/// 
					/// Default value is <code>None</code>.
					/// </summary>
					/// <returns>Value of property <code>valueState</code></returns>
					public extern virtual sap.ui.core.ValueState getValueState();

					/// <summary>
					/// Sets a new value for property {@link #getValueState valueState}.
					/// 
					/// Enumeration sap.ui.core.ValueState provides state values Error, Success, Warning and None.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>None</code>.
					/// </summary>
					/// <param name="sValueState">New value for property <code>valueState</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RadioButton setValueState(sap.ui.core.ValueState sValueState);

					#endregion

					#region Methods for Property width

					/// <summary>
					/// Gets current value of property {@link #getWidth width}.
					/// 
					/// Determines the control width. By default, it depends on the text length. Alternatively, CSS sizes in % or px can be set.
					/// </summary>
					/// <returns>Value of property <code>width</code></returns>
					public extern virtual sap.ui.core.CSSSize getWidth();

					/// <summary>
					/// Sets a new value for property {@link #getWidth width}.
					/// 
					/// Determines the control width. By default, it depends on the text length. Alternatively, CSS sizes in % or px can be set.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sWidth">New value for property <code>width</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RadioButton setWidth(sap.ui.core.CSSSize sWidth);

					#endregion

					#region Methods for Property textDirection

					/// <summary>
					/// Gets current value of property {@link #getTextDirection textDirection}.
					/// 
					/// Defines the text direction - options are left-to-right (LTR) and right-to-left (RTL). Alternatively, the control can inherit the text direction from its parent container.
					/// 
					/// Default value is <code>Inherit</code>.
					/// </summary>
					/// <returns>Value of property <code>textDirection</code></returns>
					public extern virtual sap.ui.core.TextDirection getTextDirection();

					/// <summary>
					/// Sets a new value for property {@link #getTextDirection textDirection}.
					/// 
					/// Defines the text direction - options are left-to-right (LTR) and right-to-left (RTL). Alternatively, the control can inherit the text direction from its parent container.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>Inherit</code>.
					/// </summary>
					/// <param name="sTextDirection">New value for property <code>textDirection</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RadioButton setTextDirection(sap.ui.core.TextDirection sTextDirection);

					#endregion

					#region Methods for Property groupName

					/// <summary>
					/// Gets current value of property {@link #getGroupName groupName}.
					/// 
					/// Defines the name of the RadioButtonGroup, in which the current RadioButton belongs to. You can define a new name for the group. If no new name is specified, the default is sapUiRbDefaultGroup. By default, when one of the RadioButtons in a group is selected, all others are unselected.
					/// 
					/// Default value is <code>sapUiRbDefaultGroup</code>.
					/// </summary>
					/// <returns>Value of property <code>groupName</code></returns>
					public extern virtual string getGroupName();

					/// <summary>
					/// Sets a new value for property {@link #getGroupName groupName}.
					/// 
					/// Defines the name of the RadioButtonGroup, in which the current RadioButton belongs to. You can define a new name for the group. If no new name is specified, the default is sapUiRbDefaultGroup. By default, when one of the RadioButtons in a group is selected, all others are unselected.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>sapUiRbDefaultGroup</code>.
					/// </summary>
					/// <param name="sGroupName">New value for property <code>groupName</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RadioButton setGroupName(string sGroupName);

					#endregion

					#region Methods for Property key

					/// <summary>
					/// Gets current value of property {@link #getKey key}.
					/// 
					/// Can be used for subsequent actions.
					/// </summary>
					/// <returns>Value of property <code>key</code></returns>
					public extern virtual string getKey();

					/// <summary>
					/// Sets a new value for property {@link #getKey key}.
					/// 
					/// Can be used for subsequent actions.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sKey">New value for property <code>key</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RadioButton setKey(string sKey);

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
					public extern virtual sap.ui.commons.RadioButton addAriaDescribedBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaDescribedBy);

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
					public extern virtual sap.ui.commons.RadioButton addAriaLabelledBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaLabelledBy);

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
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.ui.commons.RadioButton</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.RadioButton</code> itself.
					/// 
					/// Triggers when the user makes a change on the RadioButton.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.RadioButton</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RadioButton attachSelect(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.ui.commons.RadioButton</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.RadioButton</code> itself.
					/// 
					/// Triggers when the user makes a change on the RadioButton.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RadioButton attachSelect(object oData, sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.ui.commons.RadioButton</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.RadioButton</code> itself.
					/// 
					/// Triggers when the user makes a change on the RadioButton.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RadioButton attachSelect(sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.ui.commons.RadioButton</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.RadioButton</code> itself.
					/// 
					/// Triggers when the user makes a change on the RadioButton.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.RadioButton</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RadioButton attachSelect(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:select select} event of this <code>sap.ui.commons.RadioButton</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RadioButton detachSelect(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:select select} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RadioButton fireSelect(object mParameters);

					/// <summary>
					/// Fires event {@link #event:select select} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RadioButton fireSelect();

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.RadioButton with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.RadioButton with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.RadioButton with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.commons.RadioButton.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					[Name("getMetadata")]
					public extern static sap.ui.@base.Metadata getMetadataStatic();

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
