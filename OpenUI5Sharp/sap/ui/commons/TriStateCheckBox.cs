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
				/// TriStateCheckBox to reflect mixed state for checkboxes. The control can display three states, namely checked, unchecked and mixed. However, mixed state cannot be directly reached by user interaction on the particular control. It can be only set by the control's public toggle function, to make a behaviour possible which is e.g. required in checkbox trees.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.TriStateCheckBox")]
				[Obsolete("Deprecated since 1.38.")]
				public partial class TriStateCheckBox : sap.ui.core.Control
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
						/// Defines the states of the checkbox
						/// </summary>
						public Union<sap.ui.commons.TriStateCheckBoxState, string, sap.ui.@base.ManagedObject.BindPropertyInfo> selectionState;

						/// <summary>
						/// Defines the text displayed next to the check box
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> text;

						/// <summary>
						/// Using this property, the control could be disabled, if required.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> enabled;

						/// <summary>
						/// Specifies whether the user shall be allowed to flag the check box
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
						/// Event is triggered when the control status is changed by the user by flagging or unflagging the checkbox.
						/// </summary>
						public sap.ui.commons.TriStateCheckBox.ChangeDelegate change;

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
						public string selectionState;

					}

					#endregion

					#region Delegates

					public delegate void ChangeDelegate(sap.ui.@base.Event<sap.ui.commons.TriStateCheckBox.ChangeInfo> oEvent, object oData);

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new TriStateCheckBox.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern TriStateCheckBox(string sId, sap.ui.commons.TriStateCheckBox.Settings mSettings);

					/// <summary>
					/// Constructor for a new TriStateCheckBox.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern TriStateCheckBox(string sId);

					/// <summary>
					/// Constructor for a new TriStateCheckBox.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern TriStateCheckBox();

					/// <summary>
					/// Constructor for a new TriStateCheckBox.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern TriStateCheckBox(sap.ui.commons.TriStateCheckBox.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property selectionState

					/// <summary>
					/// Gets current value of property {@link #getSelectionState selectionState}.
					/// 
					/// Defines the states of the checkbox
					/// 
					/// Default value is <code>Unchecked</code>.
					/// </summary>
					/// <returns>Value of property <code>selectionState</code></returns>
					public extern virtual sap.ui.commons.TriStateCheckBoxState getSelectionState();

					/// <summary>
					/// Sets a new value for property {@link #getSelectionState selectionState}.
					/// 
					/// Defines the states of the checkbox
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>Unchecked</code>.
					/// </summary>
					/// <param name="sSelectionState">New value for property <code>selectionState</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TriStateCheckBox setSelectionState(sap.ui.commons.TriStateCheckBoxState sSelectionState);

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
					public extern virtual sap.ui.commons.TriStateCheckBox setText(string sText);

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
					public extern virtual sap.ui.commons.TriStateCheckBox setEnabled(bool bEnabled);

					#endregion

					#region Methods for Property editable

					/// <summary>
					/// Gets current value of property {@link #getEditable editable}.
					/// 
					/// Specifies whether the user shall be allowed to flag the check box
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>editable</code></returns>
					public extern virtual bool getEditable();

					/// <summary>
					/// Sets a new value for property {@link #getEditable editable}.
					/// 
					/// Specifies whether the user shall be allowed to flag the check box
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bEditable">New value for property <code>editable</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TriStateCheckBox setEditable(bool bEditable);

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
					public extern virtual sap.ui.commons.TriStateCheckBox setValueState(sap.ui.core.ValueState sValueState);

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
					public extern virtual sap.ui.commons.TriStateCheckBox setWidth(sap.ui.core.CSSSize sWidth);

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
					public extern virtual sap.ui.commons.TriStateCheckBox setTextDirection(sap.ui.core.TextDirection sTextDirection);

					#endregion

					#region Methods for Event change

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:change change} event of this <code>sap.ui.commons.TriStateCheckBox</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.TriStateCheckBox</code> itself.
					/// 
					/// Event is triggered when the control status is changed by the user by flagging or unflagging the checkbox.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.TriStateCheckBox</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TriStateCheckBox attachChange(object oData, sap.ui.commons.TriStateCheckBox.ChangeDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:change change} event of this <code>sap.ui.commons.TriStateCheckBox</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.TriStateCheckBox</code> itself.
					/// 
					/// Event is triggered when the control status is changed by the user by flagging or unflagging the checkbox.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TriStateCheckBox attachChange(object oData, sap.ui.commons.TriStateCheckBox.ChangeDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:change change} event of this <code>sap.ui.commons.TriStateCheckBox</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.TriStateCheckBox</code> itself.
					/// 
					/// Event is triggered when the control status is changed by the user by flagging or unflagging the checkbox.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TriStateCheckBox attachChange(sap.ui.commons.TriStateCheckBox.ChangeDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:change change} event of this <code>sap.ui.commons.TriStateCheckBox</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.TriStateCheckBox</code> itself.
					/// 
					/// Event is triggered when the control status is changed by the user by flagging or unflagging the checkbox.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.TriStateCheckBox</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TriStateCheckBox attachChange(sap.ui.commons.TriStateCheckBox.ChangeDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:change change} event of this <code>sap.ui.commons.TriStateCheckBox</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TriStateCheckBox detachChange(sap.ui.commons.TriStateCheckBox.ChangeDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:change change} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TriStateCheckBox fireChange(sap.ui.commons.TriStateCheckBox.ChangeInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:change change} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TriStateCheckBox fireChange();

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.TriStateCheckBox with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.TriStateCheckBox with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.TriStateCheckBox with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.commons.TriStateCheckBox.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					/// <summary>
					/// Method called whenever a user clicks on a tri-state checkbox
					/// </summary>
					/// <param name="destState">destined selection state of checkbox</param>
					public extern virtual void toggle(sap.ui.commons.TriStateCheckBoxState destState);

					#endregion

					#endregion

				}
			}
		}
	}
}
