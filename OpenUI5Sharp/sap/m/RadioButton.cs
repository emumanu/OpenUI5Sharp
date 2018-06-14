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
			/// RadioButton is a control similar to a {@link sap.m.CheckBox checkbox}, but it allows you to choose only one of the predefined set of options. Multiple radio buttons have to belong to the same group (have the same value for <code>groupName</code>) in order to be mutually exclusive. A wrapper control {@link sap.m.RadioButtonGroup RadioButtonGroup} can be used instead of individual radio buttons. <h3>Structure</h3> <ul> <li>Radio buttons can have a value state like Error or Warning.</li> <li>Radio buttons can be arranged vertically by setting the <code>column</code> to a number higher than 1.</li> <li>Radio button options need to have a {@link sap.m.Label label}.</li> </ul> <h3>Usage</h3> <h4>When to use:</h4> <ul> <li>You quickly need to choose between at least two alternatives.</li> <li>You need to place other controls between the radio button options.</li> </ul> <h4>When not to use:</h4> <ul> <li>You want to select multiple values for the same option. Use {@link sap.m.CheckBox checkboxes} instead.</li> <li>When the default value is recommended for most users in most situations. Use a {@link sap.m.Select drop-down} instead as is saves space by not showing all the alternatives.</li> <li>You want have more than 8 options. Use a {@link sap.m.Select drop-down} instead.</li> <li>When the options are mutually exclusive e.g. ON/OFF. Use a {@link sap.m.Switch switch} instead.</li> <li>Avoid using horizontally aligned radio buttons as they will be cut off on phones.</li> </ul>
			/// 
			/// <b>Note:</b> The order in which the RadioButtons will be selected one after another is determined upon instantiation of the control. This order is consistent with the ARIA attributes for position, which the same button will receive when added to specific group.
			/// 
			/// <b>Example:</b> If three buttons are created (<code>button1, button2, button3</code>) in consecutive order, initially they will have the same positions and TAB order. However if after that <code>button1</code> and <code>button3</code> are moved to a new group and then <code>button2</code> is added to the same group, their TAB order and position in this group will be <code>button1, button3, button2</code>.
			/// </summary>
			[External]
			[Namespace(false)]
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
					/// Specifies if the radio button is disabled.
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> enabled;

					/// <summary>
					/// Specifies the select state of the radio button
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> selected;

					/// <summary>
					/// Name of the radio button group the current radio button belongs to. You can define a new name for the group. If no new name is specified, this radio button belongs to the sapMRbDefaultGroup per default. Default behavior of a radio button in a group is that when one of the radio buttons in a group is selected, all others are unselected.
					/// </summary>
					public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> groupName;

					/// <summary>
					/// Specifies the text displayed next to the RadioButton
					/// </summary>
					public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> text;

					/// <summary>
					/// Options for the text direction are RTL and LTR. Alternatively, the control can inherit the text direction from its parent container.
					/// </summary>
					public Union<sap.ui.core.TextDirection, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> textDirection;

					/// <summary>
					/// Width of the RadioButton or it's label depending on the useEntireWidth property. By Default width is set only for the label.
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> width;

					/// <summary>
					/// Indicates if the given width will be applied for the whole RadioButton or only it's label. By Default width is set only for the label.
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> useEntireWidth;

					/// <summary>
					/// This is a flag to switch on activeHandling. When it is switched off, there will not be visual changes on active state. Default value is 'true'
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> activeHandling;

					/// <summary>
					/// Specifies whether the user can select the radio button.
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> editable;

					/// <summary>
					/// Enumeration sap.ui.core.ValueState provides state values Error, Success, Warning, None
					/// </summary>
					public Union<sap.ui.core.ValueState, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> valueState;

					/// <summary>
					/// Specifies the alignment of the radio button. Available alignment settings are "Begin", "Center", "End", "Left", and "Right".
					/// </summary>
					public Union<sap.ui.core.TextAlign, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> textAlign;

					/// <summary>
					/// Association to controls / IDs which describe this control (see WAI-ARIA attribute aria-describedby).
					/// </summary>
					public Union<sap.ui.core.Control, sap.ui.core.ID[], string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> ariaDescribedBy;

					/// <summary>
					/// Association to controls / IDs which label this control (see WAI-ARIA attribute aria-labelledby).
					/// </summary>
					public Union<sap.ui.core.Control, sap.ui.core.ID[], string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> ariaLabelledBy;

					/// <summary>
					/// Event is triggered when the user makes a change on the radio button (selecting or unselecting it).
					/// </summary>
					public sap.m.SelectDelegate select;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new RadioButton.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control Enables users to select a single option from a set of options.</param>
				public extern RadioButton(string sId, sap.m.RadioButton.Settings mSettings);

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
				/// <param name="mSettings">Initial settings for the new control Enables users to select a single option from a set of options.</param>
				public extern RadioButton(sap.m.RadioButton.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property enabled

				/// <summary>
				/// Gets current value of property {@link #getEnabled enabled}.
				/// 
				/// Specifies if the radio button is disabled.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>enabled</code></returns>
				public extern virtual bool getEnabled();

				/// <summary>
				/// Sets a new value for property {@link #getEnabled enabled}.
				/// 
				/// Specifies if the radio button is disabled.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bEnabled">New value for property <code>enabled</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.RadioButton setEnabled(bool bEnabled);

				#endregion

				#region Methods for Property selected

				/// <summary>
				/// Gets current value of property {@link #getSelected selected}.
				/// 
				/// Specifies the select state of the radio button
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>selected</code></returns>
				public extern virtual bool getSelected();

				/// <summary>
				/// Sets the state of the RadioButton to selected.
				/// </summary>
				/// <param name="bSelected">defines if the radio button is selected</param>
				/// <returns>Reference to the control instance for chaining</returns>
				public extern virtual sap.m.RadioButton setSelected(bool bSelected);

				#endregion

				#region Methods for Property groupName

				/// <summary>
				/// Gets current value of property {@link #getGroupName groupName}.
				/// 
				/// Name of the radio button group the current radio button belongs to. You can define a new name for the group. If no new name is specified, this radio button belongs to the sapMRbDefaultGroup per default. Default behavior of a radio button in a group is that when one of the radio buttons in a group is selected, all others are unselected.
				/// 
				/// Default value is <code>sapMRbDefaultGroup</code>.
				/// </summary>
				/// <returns>Value of property <code>groupName</code></returns>
				public extern virtual string getGroupName();

				/// <summary>
				/// Sets RadioButton's groupName. Only one radioButton from the same group can be selected
				/// </summary>
				/// <param name="sGroupName">Name of the group to which the RadioButton will belong.</param>
				/// <returns>Reference to the control instance for chaining</returns>
				public extern virtual sap.m.RadioButton setGroupName(string sGroupName);

				#endregion

				#region Methods for Property text

				/// <summary>
				/// Gets current value of property {@link #getText text}.
				/// 
				/// Specifies the text displayed next to the RadioButton
				/// </summary>
				/// <returns>Value of property <code>text</code></returns>
				public extern virtual string getText();

				/// <summary>
				/// Sets the text for the RadioButton's label.
				/// </summary>
				/// <param name="sText">The text to be set</param>
				/// <returns>Reference to the control instance for chaining</returns>
				public extern virtual sap.m.RadioButton setText(string sText);

				#endregion

				#region Methods for Property textDirection

				/// <summary>
				/// Gets current value of property {@link #getTextDirection textDirection}.
				/// 
				/// Options for the text direction are RTL and LTR. Alternatively, the control can inherit the text direction from its parent container.
				/// 
				/// Default value is <code>Inherit</code>.
				/// </summary>
				/// <returns>Value of property <code>textDirection</code></returns>
				public extern virtual sap.ui.core.TextDirection getTextDirection();

				/// <summary>
				/// Sets the text direction for the RadioButton's label.
				/// </summary>
				/// <param name="sDirection">Text direction to be set to RadioButton's label</param>
				/// <returns>Reference to the control instance for chaining</returns>
				public extern virtual sap.m.RadioButton setTextDirection(string sDirection);

				#endregion

				#region Methods for Property width

				/// <summary>
				/// Gets current value of property {@link #getWidth width}.
				/// 
				/// Width of the RadioButton or it's label depending on the useEntireWidth property. By Default width is set only for the label.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <returns>Value of property <code>width</code></returns>
				public extern virtual sap.ui.core.CSSSize getWidth();

				/// <summary>
				/// Sets a new value for property {@link #getWidth width}.
				/// 
				/// Width of the RadioButton or it's label depending on the useEntireWidth property. By Default width is set only for the label.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <param name="sWidth">New value for property <code>width</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.RadioButton setWidth(sap.ui.core.CSSSize sWidth);

				#endregion

				#region Methods for Property useEntireWidth

				/// <summary>
				/// Gets current value of property {@link #getUseEntireWidth useEntireWidth}.
				/// 
				/// Indicates if the given width will be applied for the whole RadioButton or only it's label. By Default width is set only for the label.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>useEntireWidth</code></returns>
				public extern virtual bool getUseEntireWidth();

				/// <summary>
				/// Sets a new value for property {@link #getUseEntireWidth useEntireWidth}.
				/// 
				/// Indicates if the given width will be applied for the whole RadioButton or only it's label. By Default width is set only for the label.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bUseEntireWidth">New value for property <code>useEntireWidth</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.RadioButton setUseEntireWidth(bool bUseEntireWidth);

				#endregion

				#region Methods for Property activeHandling

				/// <summary>
				/// Gets current value of property {@link #getActiveHandling activeHandling}.
				/// 
				/// This is a flag to switch on activeHandling. When it is switched off, there will not be visual changes on active state. Default value is 'true'
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>activeHandling</code></returns>
				public extern virtual bool getActiveHandling();

				/// <summary>
				/// Sets a new value for property {@link #getActiveHandling activeHandling}.
				/// 
				/// This is a flag to switch on activeHandling. When it is switched off, there will not be visual changes on active state. Default value is 'true'
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bActiveHandling">New value for property <code>activeHandling</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.RadioButton setActiveHandling(bool bActiveHandling);

				#endregion

				#region Methods for Property editable

				/// <summary>
				/// Gets current value of property {@link #getEditable editable}.
				/// 
				/// Specifies whether the user can select the radio button.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>editable</code></returns>
				public extern virtual bool getEditable();

				/// <summary>
				/// Sets a new value for property {@link #getEditable editable}.
				/// 
				/// Specifies whether the user can select the radio button.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bEditable">New value for property <code>editable</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.RadioButton setEditable(bool bEditable);

				#endregion

				#region Methods for Property valueState

				/// <summary>
				/// Gets current value of property {@link #getValueState valueState}.
				/// 
				/// Enumeration sap.ui.core.ValueState provides state values Error, Success, Warning, None
				/// 
				/// Default value is <code>None</code>.
				/// </summary>
				/// <returns>Value of property <code>valueState</code></returns>
				public extern virtual sap.ui.core.ValueState getValueState();

				/// <summary>
				/// Sets a new value for property {@link #getValueState valueState}.
				/// 
				/// Enumeration sap.ui.core.ValueState provides state values Error, Success, Warning, None
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>None</code>.
				/// </summary>
				/// <param name="sValueState">New value for property <code>valueState</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.RadioButton setValueState(sap.ui.core.ValueState sValueState);

				#endregion

				#region Methods for Property textAlign

				/// <summary>
				/// Gets current value of property {@link #getTextAlign textAlign}.
				/// 
				/// Specifies the alignment of the radio button. Available alignment settings are "Begin", "Center", "End", "Left", and "Right".
				/// 
				/// Default value is <code>Begin</code>.
				/// </summary>
				/// <returns>Value of property <code>textAlign</code></returns>
				public extern virtual sap.ui.core.TextAlign getTextAlign();

				/// <summary>
				/// Sets a new value for property {@link #getTextAlign textAlign}.
				/// 
				/// Specifies the alignment of the radio button. Available alignment settings are "Begin", "Center", "End", "Left", and "Right".
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Begin</code>.
				/// </summary>
				/// <param name="sTextAlign">New value for property <code>textAlign</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.RadioButton setTextAlign(sap.ui.core.TextAlign sTextAlign);

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
				public extern virtual sap.m.RadioButton addAriaDescribedBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaDescribedBy);

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
				public extern virtual sap.m.RadioButton addAriaLabelledBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaLabelledBy);

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
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.m.RadioButton</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.RadioButton</code> itself.
				/// 
				/// Event is triggered when the user makes a change on the radio button (selecting or unselecting it).
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.RadioButton</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.RadioButton attachSelect(object oData, sap.m.SelectDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.m.RadioButton</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.RadioButton</code> itself.
				/// 
				/// Event is triggered when the user makes a change on the radio button (selecting or unselecting it).
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.RadioButton attachSelect(object oData, sap.m.SelectDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.m.RadioButton</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.RadioButton</code> itself.
				/// 
				/// Event is triggered when the user makes a change on the radio button (selecting or unselecting it).
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.RadioButton attachSelect(sap.m.SelectDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.m.RadioButton</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.RadioButton</code> itself.
				/// 
				/// Event is triggered when the user makes a change on the radio button (selecting or unselecting it).
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.RadioButton</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.RadioButton attachSelect(sap.m.SelectDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:select select} event of this <code>sap.m.RadioButton</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.RadioButton detachSelect(sap.m.SelectDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:select select} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.RadioButton fireSelect(sap.m.SelectInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:select select} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.RadioButton fireSelect();

				#endregion

				#region Other methods

				/// <summary>
				/// Destroys all related objects to the RadioButton
				/// </summary>
				public extern override void exit();

				/// <summary>
				/// Creates a new subclass of class sap.m.RadioButton with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.RadioButton with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.RadioButton with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <returns>The <code>sap.m.RadioButton</code> accessibility information</returns>
				public extern virtual object getAccessibilityInfo();

				/// <summary>
				/// Returns a metadata object for class sap.m.RadioButton.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				/// <summary>
				/// Pseudo event for pseudo 'select' event... space, enter, ... without modifiers (Ctrl, Alt or Shift)
				/// </summary>
				/// <param name="oEvent">provides information for the event</param>
				public extern virtual void onsapselect(object oEvent);

				/// <summary>
				/// Method to set a RadioButton's state to active or inactive.
				/// </summary>
				/// <param name="bActive">Sets the active state to true or false</param>
				public extern virtual void setActiveState(bool bActive);

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
