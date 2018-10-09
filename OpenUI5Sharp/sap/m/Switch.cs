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
			/// A switch is a user interface control on mobile devices that is used for change between binary states. The user can also drag the button handle or tap to change the state.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.Switch")]
			public partial class Switch : sap.ui.core.Control
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
					/// A boolean value indicating whether the switch is on or off.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> state;

					/// <summary>
					/// Custom text for the "ON" state.
					/// 
					/// "ON" translated to the current language is the default value. Beware that the given text will be cut off if available space is exceeded.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> customTextOn;

					/// <summary>
					/// Custom text for the "OFF" state.
					/// 
					/// "OFF" translated to the current language is the default value. Beware that the given text will be cut off if available space is exceeded.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> customTextOff;

					/// <summary>
					/// Whether the switch is enabled.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> enabled;

					/// <summary>
					/// The name to be used in the HTML code for the switch (e.g. for HTML forms that send data to the server via submit).
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> name;

					/// <summary>
					/// Type of a Switch. Possibles values "Default", "AcceptReject".
					/// </summary>
					public Union<sap.m.SwitchType, string, sap.ui.@base.ManagedObject.BindPropertyInfo> type;

					/// <summary>
					/// Association to controls / ids which label this control (see WAI-ARIA attribute aria-labelledby).
					/// </summary>
					public Union<sap.ui.core.Control, sap.ui.core.ID[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> ariaLabelledBy;

					/// <summary>
					/// Triggered when a switch changes the state.
					/// </summary>
					public sap.m.Switch.ChangeDelegate change;

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
					/// The new state of the switch.
					/// </summary>
					public bool state;

				}

				#endregion

				#region Delegates

				public delegate void ChangeDelegate(sap.ui.@base.Event<sap.m.Switch.ChangeInfo> oEvent, object oData);

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new Switch.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">id for the new control, generated automatically if no id is given</param>
				/// <param name="mSettings">initial settings for the new control</param>
				public extern Switch(string sId, sap.m.Switch.Settings mSettings);

				/// <summary>
				/// Constructor for a new Switch.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">id for the new control, generated automatically if no id is given</param>
				public extern Switch(string sId);

				/// <summary>
				/// Constructor for a new Switch.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern Switch();

				/// <summary>
				/// Constructor for a new Switch.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">initial settings for the new control</param>
				public extern Switch(sap.m.Switch.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property state

				/// <summary>
				/// Gets current value of property {@link #getState state}.
				/// 
				/// A boolean value indicating whether the switch is on or off.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>state</code></returns>
				public extern virtual bool getState();

				/// <summary>
				/// Change the switch state between on and off.
				/// </summary>
				/// <param name="bState">The new state - true for 'on' and false for 'off'</param>
				/// <returns><code>this</code> to allow method chaining.</returns>
				public extern virtual sap.m.Switch setState(bool bState);

				#endregion

				#region Methods for Property customTextOn

				/// <summary>
				/// Gets current value of property {@link #getCustomTextOn customTextOn}.
				/// 
				/// Custom text for the "ON" state.
				/// 
				/// "ON" translated to the current language is the default value. Beware that the given text will be cut off if available space is exceeded.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <returns>Value of property <code>customTextOn</code></returns>
				public extern virtual string getCustomTextOn();

				/// <summary>
				/// Sets a new value for property {@link #getCustomTextOn customTextOn}.
				/// 
				/// Custom text for the "ON" state.
				/// 
				/// "ON" translated to the current language is the default value. Beware that the given text will be cut off if available space is exceeded.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <param name="sCustomTextOn">New value for property <code>customTextOn</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Switch setCustomTextOn(string sCustomTextOn);

				#endregion

				#region Methods for Property customTextOff

				/// <summary>
				/// Gets current value of property {@link #getCustomTextOff customTextOff}.
				/// 
				/// Custom text for the "OFF" state.
				/// 
				/// "OFF" translated to the current language is the default value. Beware that the given text will be cut off if available space is exceeded.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <returns>Value of property <code>customTextOff</code></returns>
				public extern virtual string getCustomTextOff();

				/// <summary>
				/// Sets a new value for property {@link #getCustomTextOff customTextOff}.
				/// 
				/// Custom text for the "OFF" state.
				/// 
				/// "OFF" translated to the current language is the default value. Beware that the given text will be cut off if available space is exceeded.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <param name="sCustomTextOff">New value for property <code>customTextOff</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Switch setCustomTextOff(string sCustomTextOff);

				#endregion

				#region Methods for Property enabled

				/// <summary>
				/// Gets current value of property {@link #getEnabled enabled}.
				/// 
				/// Whether the switch is enabled.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>enabled</code></returns>
				public extern virtual bool getEnabled();

				/// <summary>
				/// Sets a new value for property {@link #getEnabled enabled}.
				/// 
				/// Whether the switch is enabled.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bEnabled">New value for property <code>enabled</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Switch setEnabled(bool bEnabled);

				#endregion

				#region Methods for Property name

				/// <summary>
				/// Gets current value of property {@link #getName name}.
				/// 
				/// The name to be used in the HTML code for the switch (e.g. for HTML forms that send data to the server via submit).
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <returns>Value of property <code>name</code></returns>
				public extern virtual string getName();

				/// <summary>
				/// Sets a new value for property {@link #getName name}.
				/// 
				/// The name to be used in the HTML code for the switch (e.g. for HTML forms that send data to the server via submit).
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <param name="sName">New value for property <code>name</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Switch setName(string sName);

				#endregion

				#region Methods for Property type

				/// <summary>
				/// Gets current value of property {@link #getType type}.
				/// 
				/// Type of a Switch. Possibles values "Default", "AcceptReject".
				/// 
				/// Default value is <code>Default</code>.
				/// </summary>
				/// <returns>Value of property <code>type</code></returns>
				public extern virtual sap.m.SwitchType getType();

				/// <summary>
				/// Sets a new value for property {@link #getType type}.
				/// 
				/// Type of a Switch. Possibles values "Default", "AcceptReject".
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Default</code>.
				/// </summary>
				/// <param name="sType">New value for property <code>type</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Switch setType(sap.m.SwitchType sType);

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
				public extern virtual sap.m.Switch addAriaLabelledBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaLabelledBy);

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
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:change change} event of this <code>sap.m.Switch</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Switch</code> itself.
				/// 
				/// Triggered when a switch changes the state.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.Switch</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Switch attachChange(object oData, sap.m.Switch.ChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:change change} event of this <code>sap.m.Switch</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Switch</code> itself.
				/// 
				/// Triggered when a switch changes the state.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Switch attachChange(object oData, sap.m.Switch.ChangeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:change change} event of this <code>sap.m.Switch</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Switch</code> itself.
				/// 
				/// Triggered when a switch changes the state.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Switch attachChange(sap.m.Switch.ChangeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:change change} event of this <code>sap.m.Switch</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Switch</code> itself.
				/// 
				/// Triggered when a switch changes the state.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.Switch</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Switch attachChange(sap.m.Switch.ChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:change change} event of this <code>sap.m.Switch</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Switch detachChange(sap.m.Switch.ChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:change change} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Switch fireChange(sap.m.Switch.ChangeInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:change change} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Switch fireChange();

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.Switch with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.Switch with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.Switch with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.Switch.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				#endregion

				#endregion

			}
		}
	}
}
