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
				/// Provides a box which can be flagged, the box has a label. A check box can either stand alone, or in a group with other check boxes. As an option, the boxes can initially be set to status 'Not Editable'.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.CheckBox")]
				[Obsolete("Deprecated since 1.38. Instead, use the <code>sap.m.CheckBox</code> control.")]
				public partial class CheckBox : sap.ui.core.Control, sap.ui.core.IFormContent
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
						/// Contains the state of the control whether it is flagged with a check mark, or not
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> @checked;

						/// <summary>
						/// Defines the text displayed next to the check box
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> text;

						/// <summary>
						/// Using this property, the control could be disabled, if required.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> enabled;

						/// <summary>
						/// Specifies whether the user shall be allowed to select the check box.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> editable;

						/// <summary>
						/// Accepts the core enumeration ValueState.type that supports 'None', 'Error', 'Warning' and 'Success'.
						/// </summary>
						public Union<sap.ui.core.ValueState, string, sap.ui.@base.ManagedObject.BindPropertyInfo> valueState;

						/// <summary>
						/// The width can be set to an absolute value. If no value is set, the control width results from the text length.
						/// </summary>
						public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> width;

						/// <summary>
						/// The value can be set to LTR or RTL. Otherwise, the control inherits the text direction from its parent control.
						/// </summary>
						public Union<sap.ui.core.TextDirection, string, sap.ui.@base.ManagedObject.BindPropertyInfo> textDirection;

						/// <summary>
						/// The 'name' property to be used in the HTML code, for example for HTML forms that send data to the server via submit.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> name;

						/// <summary>
						/// Association to controls / ids which describe this control (see WAI-ARIA attribute aria-describedby).
						/// </summary>
						public Union<sap.ui.core.Control, sap.ui.core.ID[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> ariaDescribedBy;

						/// <summary>
						/// Association to controls / ids which label this control (see WAI-ARIA attribute aria-labelledby).
						/// </summary>
						public Union<sap.ui.core.Control, sap.ui.core.ID[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> ariaLabelledBy;

						/// <summary>
						/// Event is triggered when the control status is changed by the user by flagging or unflagging the checkbox.
						/// </summary>
						public sap.ui.commons.CheckBox.ChangeDelegate change;

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
						/// Checks whether the box is flagged or not flagged.
						/// </summary>
						public bool @checked;

					}

					#endregion

					#region Delegates

					public delegate void ChangeDelegate(sap.ui.@base.Event<sap.ui.commons.CheckBox.ChangeInfo> oEvent, object oData);

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new CheckBox.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern CheckBox(string sId, sap.ui.commons.CheckBox.Settings mSettings);

					/// <summary>
					/// Constructor for a new CheckBox.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern CheckBox(string sId);

					/// <summary>
					/// Constructor for a new CheckBox.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern CheckBox();

					/// <summary>
					/// Constructor for a new CheckBox.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern CheckBox(sap.ui.commons.CheckBox.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property checked

					/// <summary>
					/// Gets current value of property {@link #getChecked checked}.
					/// 
					/// Contains the state of the control whether it is flagged with a check mark, or not
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>checked</code></returns>
					public extern virtual bool getChecked();

					/// <summary>
					/// Sets a new value for property {@link #getChecked checked}.
					/// 
					/// Contains the state of the control whether it is flagged with a check mark, or not
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bChecked">New value for property <code>checked</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.CheckBox setChecked(bool bChecked);

					/// <summary>
					/// Binds property {@link #getChecked checked} to model data.
					/// 
					/// See {@link sap.ui.base.ManagedObject#bindProperty ManagedObject.bindProperty} for a detailed description of the possible properties of <code>oBindingInfo</code>
					/// </summary>
					/// <param name="oBindingInfo">The binding information</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.CheckBox bindChecked(sap.ui.@base.ManagedObject.BindPropertyInfo oBindingInfo);

					/// <summary>
					/// Unbinds property {@link #getChecked checked} from model data.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.CheckBox unbindChecked();

					#endregion

					#region Methods for Property text

					/// <summary>
					/// Gets current value of property {@link #getText text}.
					/// 
					/// Defines the text displayed next to the check box
					/// </summary>
					/// <returns>Value of property <code>text</code></returns>
					public extern virtual string getText();

					/// <summary>
					/// Sets a new value for property {@link #getText text}.
					/// 
					/// Defines the text displayed next to the check box
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sText">New value for property <code>text</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.CheckBox setText(string sText);

					#endregion

					#region Methods for Property enabled

					/// <summary>
					/// Gets current value of property {@link #getEnabled enabled}.
					/// 
					/// Using this property, the control could be disabled, if required.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>enabled</code></returns>
					public extern virtual bool getEnabled();

					/// <summary>
					/// Sets a new value for property {@link #getEnabled enabled}.
					/// 
					/// Using this property, the control could be disabled, if required.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bEnabled">New value for property <code>enabled</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.CheckBox setEnabled(bool bEnabled);

					#endregion

					#region Methods for Property editable

					/// <summary>
					/// Gets current value of property {@link #getEditable editable}.
					/// 
					/// Specifies whether the user shall be allowed to select the check box.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>editable</code></returns>
					public extern virtual bool getEditable();

					/// <summary>
					/// Sets a new value for property {@link #getEditable editable}.
					/// 
					/// Specifies whether the user shall be allowed to select the check box.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bEditable">New value for property <code>editable</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.CheckBox setEditable(bool bEditable);

					#endregion

					#region Methods for Property valueState

					/// <summary>
					/// Gets current value of property {@link #getValueState valueState}.
					/// 
					/// Accepts the core enumeration ValueState.type that supports 'None', 'Error', 'Warning' and 'Success'.
					/// 
					/// Default value is <code>None</code>.
					/// </summary>
					/// <returns>Value of property <code>valueState</code></returns>
					public extern virtual sap.ui.core.ValueState getValueState();

					/// <summary>
					/// Sets a new value for property {@link #getValueState valueState}.
					/// 
					/// Accepts the core enumeration ValueState.type that supports 'None', 'Error', 'Warning' and 'Success'.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>None</code>.
					/// </summary>
					/// <param name="sValueState">New value for property <code>valueState</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.CheckBox setValueState(sap.ui.core.ValueState sValueState);

					#endregion

					#region Methods for Property width

					/// <summary>
					/// Gets current value of property {@link #getWidth width}.
					/// 
					/// The width can be set to an absolute value. If no value is set, the control width results from the text length.
					/// </summary>
					/// <returns>Value of property <code>width</code></returns>
					public extern virtual sap.ui.core.CSSSize getWidth();

					/// <summary>
					/// Sets a new value for property {@link #getWidth width}.
					/// 
					/// The width can be set to an absolute value. If no value is set, the control width results from the text length.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sWidth">New value for property <code>width</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.CheckBox setWidth(sap.ui.core.CSSSize sWidth);

					#endregion

					#region Methods for Property textDirection

					/// <summary>
					/// Gets current value of property {@link #getTextDirection textDirection}.
					/// 
					/// The value can be set to LTR or RTL. Otherwise, the control inherits the text direction from its parent control.
					/// 
					/// Default value is <code>Inherit</code>.
					/// </summary>
					/// <returns>Value of property <code>textDirection</code></returns>
					public extern virtual sap.ui.core.TextDirection getTextDirection();

					/// <summary>
					/// Sets a new value for property {@link #getTextDirection textDirection}.
					/// 
					/// The value can be set to LTR or RTL. Otherwise, the control inherits the text direction from its parent control.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>Inherit</code>.
					/// </summary>
					/// <param name="sTextDirection">New value for property <code>textDirection</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.CheckBox setTextDirection(sap.ui.core.TextDirection sTextDirection);

					#endregion

					#region Methods for Property name

					/// <summary>
					/// Gets current value of property {@link #getName name}.
					/// 
					/// The 'name' property to be used in the HTML code, for example for HTML forms that send data to the server via submit.
					/// </summary>
					/// <returns>Value of property <code>name</code></returns>
					public extern virtual string getName();

					/// <summary>
					/// Sets a new value for property {@link #getName name}.
					/// 
					/// The 'name' property to be used in the HTML code, for example for HTML forms that send data to the server via submit.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sName">New value for property <code>name</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.CheckBox setName(string sName);

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
					public extern virtual sap.ui.commons.CheckBox addAriaDescribedBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaDescribedBy);

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
					public extern virtual sap.ui.commons.CheckBox addAriaLabelledBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaLabelledBy);

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
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:change change} event of this <code>sap.ui.commons.CheckBox</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.CheckBox</code> itself.
					/// 
					/// Event is triggered when the control status is changed by the user by flagging or unflagging the checkbox.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.CheckBox</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.CheckBox attachChange(object oData, sap.ui.commons.CheckBox.ChangeDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:change change} event of this <code>sap.ui.commons.CheckBox</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.CheckBox</code> itself.
					/// 
					/// Event is triggered when the control status is changed by the user by flagging or unflagging the checkbox.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.CheckBox attachChange(object oData, sap.ui.commons.CheckBox.ChangeDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:change change} event of this <code>sap.ui.commons.CheckBox</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.CheckBox</code> itself.
					/// 
					/// Event is triggered when the control status is changed by the user by flagging or unflagging the checkbox.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.CheckBox attachChange(sap.ui.commons.CheckBox.ChangeDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:change change} event of this <code>sap.ui.commons.CheckBox</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.CheckBox</code> itself.
					/// 
					/// Event is triggered when the control status is changed by the user by flagging or unflagging the checkbox.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.CheckBox</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.CheckBox attachChange(sap.ui.commons.CheckBox.ChangeDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:change change} event of this <code>sap.ui.commons.CheckBox</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.CheckBox detachChange(sap.ui.commons.CheckBox.ChangeDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:change change} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.CheckBox fireChange(sap.ui.commons.CheckBox.ChangeInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:change change} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.CheckBox fireChange();

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.CheckBox with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.CheckBox with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.CheckBox with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					public extern virtual void getAccessibilityInfo();

					/// <summary>
					/// Returns a metadata object for class sap.ui.commons.CheckBox.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					[Name("getMetadata")]
					public extern static sap.ui.@base.Metadata getMetadataStatic();

					/// <summary>
					/// Inverts the current value of the control.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.commons.CheckBox toggle();

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
