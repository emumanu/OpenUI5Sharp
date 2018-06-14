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
			/// Allows the user to set a binary value, such as true/false or yes/no for an item.
			/// 
			/// <h3>Overview</h3>
			/// 
			/// The <code>CheckBox</code> control consists of a box and a label that describes its purpose. If it's checked, an indicator is displayed inside the box.
			/// 
			/// To select/deselect the <code>CheckBox</code>, the user has to click or tap the square box or its label. Clicking or tapping toggles the <code>CheckBox</code> between checked and unchecked state. The <code>CheckBox</code> control only has 2 states - checked and unchecked. There is no third state for partially selected.
			/// 
			/// <h3>Usage</h3>
			/// 
			/// You can set the width of the element containing the box and the label manually with the use of the <code>width</code> property. If the text exceeds the available width, it is truncated.
			/// 
			/// <b>Note:</b> When <code>useEntireWidth</code> property is set to <code>true</code>, the value of the <code>width</code> property is applied to the control as a whole (box and label). If <code>useEntireWidth</code> is set to <code>false</code>, the <code>width</code> is applied to the label only.
			/// 
			/// The touchable area for toggling the <code>CheckBox</code> ends where the text ends.
			/// 
			/// If the width allows more space than the text requires, white space is added. The text can be positioned manually in this space using the <code>textAlign</code> property.
			/// 
			/// <b>Note:</b> Keep in mind that setting the <code>textAlign</code> property to <code>Right</code> can result in a large amount of white space between the box and the text.
			/// 
			/// You can disable the <code>CheckBox</code> by setting the <code>enabled</code> property to <code>false</code>, or use the <code>CheckBox</code> in read-only mode by setting the <code>editable</code> property to false.
			/// 
			/// <b>Note:</b> Disabled and read-only states shouldn't be used together.
			/// </summary>
			[External]
			[Namespace(false)]
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
					/// Stores the state of the checkbox whether it is selected or not.
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> selected;

					/// <summary>
					/// Disables the Checkbox. Disabled controls are not interactive and are rendered differently according to the theme.
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> enabled;

					/// <summary>
					/// The 'name' property to be used in the HTML code, for example for HTML forms that send data to the server via submit.
					/// </summary>
					public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> name;

					/// <summary>
					/// Defines the text displayed next to the checkbox
					/// </summary>
					public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> text;

					/// <summary>
					/// Options for the text direction are RTL and LTR. Alternatively, the control can inherit the text direction from its parent container.
					/// </summary>
					public Union<sap.ui.core.TextDirection, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> textDirection;

					/// <summary>
					/// Aligns the text of the checkbox. Available alignment settings are "Begin", "Center", "End", "Left", and "Right".
					/// </summary>
					public Union<sap.ui.core.TextAlign, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> textAlign;

					/// <summary>
					/// Determines the total width of the control or the width of its label only, depending on the value of <code>useEntireWidth</code>.
					/// 
					/// <b>Note:</b> When <code>useEntireWidth</code> is set to <code>true</code>, <code>width</code> is applied to the control as a whole (checkbox and label). Otherwise, <code>width</code> is applied to the label only.
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> width;

					/// <summary>
					/// Indicates if the given width will be applied to the control as a whole or to its label only.
					/// 
					/// <b>Note:</b> by default the width is set to the label
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> useEntireWidth;

					/// <summary>
					/// Flag to switch on activeHandling, when it is switched off, there will be no visual changes on active state. Default value is 'true'
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> activeHandling;

					/// <summary>
					/// Specifies whether the user shall be allowed to edit the state of the checkbox
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> editable;

					/// <summary>
					/// Accepts the core enumeration ValueState.type that supports 'None', 'Error', 'Warning' and 'Success'.
					/// </summary>
					public Union<sap.ui.core.ValueState, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> valueState;

					/// <summary>
					/// Determines whether the <code>CheckBox</code> is in display only state.
					/// 
					/// When set to <code>true</code>, the <code>CheckBox</code> is not interactive, not editable, not focusable and not in the tab chain. This setting is used for forms in review mode.
					/// 
					/// <Note:> When the property <code>enabled</code> is set to <code>false</code> this property has no effect.
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> displayOnly;

					/// <summary>
					/// Determines whether the label's text is wrapped.
					/// 
					/// When set to <code>false</code> (default), the label's text is truncated with ellipsis at the end.
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> wrapping;

					/// <summary>
					/// Association to controls / IDs which describe this control (see WAI-ARIA attribute aria-describedby).
					/// </summary>
					public Union<sap.ui.core.Control, sap.ui.core.ID[], string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> ariaDescribedBy;

					/// <summary>
					/// Association to controls / IDs which label this control (see WAI-ARIA attribute aria-labelledby).
					/// </summary>
					public Union<sap.ui.core.Control, sap.ui.core.ID[], string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> ariaLabelledBy;

					/// <summary>
					/// Event is triggered when the control status is changed by the user by selecting or deselecting the checkbox.
					/// </summary>
					public sap.m.SelectDelegate select;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new <code>CheckBox</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">The ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">The Initial settings for the new control</param>
				public extern CheckBox(string sId, sap.m.CheckBox.Settings mSettings);

				/// <summary>
				/// Constructor for a new <code>CheckBox</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">The ID for the new control, generated automatically if no ID is given</param>
				public extern CheckBox(string sId);

				/// <summary>
				/// Constructor for a new <code>CheckBox</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern CheckBox();

				/// <summary>
				/// Constructor for a new <code>CheckBox</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">The Initial settings for the new control</param>
				public extern CheckBox(sap.m.CheckBox.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property selected

				/// <summary>
				/// Gets current value of property {@link #getSelected selected}.
				/// 
				/// Stores the state of the checkbox whether it is selected or not.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>selected</code></returns>
				public extern virtual bool getSelected();

				/// <summary>
				/// Sets a new value for property {@link #getSelected selected}.
				/// 
				/// Stores the state of the checkbox whether it is selected or not.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bSelected">New value for property <code>selected</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.CheckBox setSelected(bool bSelected);

				#endregion

				#region Methods for Property enabled

				/// <summary>
				/// Gets current value of property {@link #getEnabled enabled}.
				/// 
				/// Disables the Checkbox. Disabled controls are not interactive and are rendered differently according to the theme.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>enabled</code></returns>
				public extern virtual bool getEnabled();

				/// <summary>
				/// Sets a new value for property {@link #getEnabled enabled}.
				/// 
				/// Disables the Checkbox. Disabled controls are not interactive and are rendered differently according to the theme.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bEnabled">New value for property <code>enabled</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.CheckBox setEnabled(bool bEnabled);

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
				public extern virtual sap.m.CheckBox setName(string sName);

				#endregion

				#region Methods for Property text

				/// <summary>
				/// Gets current value of property {@link #getText text}.
				/// 
				/// Defines the text displayed next to the checkbox
				/// </summary>
				/// <returns>Value of property <code>text</code></returns>
				public extern virtual string getText();

				/// <summary>
				/// Sets a new value for property {@link #getText text}.
				/// 
				/// Defines the text displayed next to the checkbox
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sText">New value for property <code>text</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.CheckBox setText(string sText);

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
				/// Sets a new value for property {@link #getTextDirection textDirection}.
				/// 
				/// Options for the text direction are RTL and LTR. Alternatively, the control can inherit the text direction from its parent container.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Inherit</code>.
				/// </summary>
				/// <param name="sTextDirection">New value for property <code>textDirection</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.CheckBox setTextDirection(sap.ui.core.TextDirection sTextDirection);

				#endregion

				#region Methods for Property textAlign

				/// <summary>
				/// Gets current value of property {@link #getTextAlign textAlign}.
				/// 
				/// Aligns the text of the checkbox. Available alignment settings are "Begin", "Center", "End", "Left", and "Right".
				/// 
				/// Default value is <code>Begin</code>.
				/// </summary>
				/// <returns>Value of property <code>textAlign</code></returns>
				public extern virtual sap.ui.core.TextAlign getTextAlign();

				/// <summary>
				/// Sets a new value for property {@link #getTextAlign textAlign}.
				/// 
				/// Aligns the text of the checkbox. Available alignment settings are "Begin", "Center", "End", "Left", and "Right".
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Begin</code>.
				/// </summary>
				/// <param name="sTextAlign">New value for property <code>textAlign</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.CheckBox setTextAlign(sap.ui.core.TextAlign sTextAlign);

				#endregion

				#region Methods for Property width

				/// <summary>
				/// Gets current value of property {@link #getWidth width}.
				/// 
				/// Determines the total width of the control or the width of its label only, depending on the value of <code>useEntireWidth</code>.
				/// 
				/// <b>Note:</b> When <code>useEntireWidth</code> is set to <code>true</code>, <code>width</code> is applied to the control as a whole (checkbox and label). Otherwise, <code>width</code> is applied to the label only.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <returns>Value of property <code>width</code></returns>
				public extern virtual sap.ui.core.CSSSize getWidth();

				/// <summary>
				/// Sets a new value for property {@link #getWidth width}.
				/// 
				/// Determines the total width of the control or the width of its label only, depending on the value of <code>useEntireWidth</code>.
				/// 
				/// <b>Note:</b> When <code>useEntireWidth</code> is set to <code>true</code>, <code>width</code> is applied to the control as a whole (checkbox and label). Otherwise, <code>width</code> is applied to the label only.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <param name="sWidth">New value for property <code>width</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.CheckBox setWidth(sap.ui.core.CSSSize sWidth);

				#endregion

				#region Methods for Property useEntireWidth

				/// <summary>
				/// Gets current value of property {@link #getUseEntireWidth useEntireWidth}.
				/// 
				/// Indicates if the given width will be applied to the control as a whole or to its label only.
				/// 
				/// <b>Note:</b> by default the width is set to the label
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>useEntireWidth</code></returns>
				public extern virtual bool getUseEntireWidth();

				/// <summary>
				/// Sets a new value for property {@link #getUseEntireWidth useEntireWidth}.
				/// 
				/// Indicates if the given width will be applied to the control as a whole or to its label only.
				/// 
				/// <b>Note:</b> by default the width is set to the label
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bUseEntireWidth">New value for property <code>useEntireWidth</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.CheckBox setUseEntireWidth(bool bUseEntireWidth);

				#endregion

				#region Methods for Property activeHandling

				/// <summary>
				/// Gets current value of property {@link #getActiveHandling activeHandling}.
				/// 
				/// Flag to switch on activeHandling, when it is switched off, there will be no visual changes on active state. Default value is 'true'
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>activeHandling</code></returns>
				public extern virtual bool getActiveHandling();

				/// <summary>
				/// Sets a new value for property {@link #getActiveHandling activeHandling}.
				/// 
				/// Flag to switch on activeHandling, when it is switched off, there will be no visual changes on active state. Default value is 'true'
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bActiveHandling">New value for property <code>activeHandling</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.CheckBox setActiveHandling(bool bActiveHandling);

				#endregion

				#region Methods for Property editable

				/// <summary>
				/// Gets current value of property {@link #getEditable editable}.
				/// 
				/// Specifies whether the user shall be allowed to edit the state of the checkbox
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>editable</code></returns>
				public extern virtual bool getEditable();

				/// <summary>
				/// Sets a new value for property {@link #getEditable editable}.
				/// 
				/// Specifies whether the user shall be allowed to edit the state of the checkbox
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bEditable">New value for property <code>editable</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.CheckBox setEditable(bool bEditable);

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
				public extern virtual sap.m.CheckBox setValueState(sap.ui.core.ValueState sValueState);

				#endregion

				#region Methods for Property displayOnly

				/// <summary>
				/// Gets current value of property {@link #getDisplayOnly displayOnly}.
				/// 
				/// Determines whether the <code>CheckBox</code> is in display only state.
				/// 
				/// When set to <code>true</code>, the <code>CheckBox</code> is not interactive, not editable, not focusable and not in the tab chain. This setting is used for forms in review mode.
				/// 
				/// <Note:> When the property <code>enabled</code> is set to <code>false</code> this property has no effect.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>displayOnly</code></returns>
				public extern virtual bool getDisplayOnly();

				/// <summary>
				/// Sets a new value for property {@link #getDisplayOnly displayOnly}.
				/// 
				/// Determines whether the <code>CheckBox</code> is in display only state.
				/// 
				/// When set to <code>true</code>, the <code>CheckBox</code> is not interactive, not editable, not focusable and not in the tab chain. This setting is used for forms in review mode.
				/// 
				/// <Note:> When the property <code>enabled</code> is set to <code>false</code> this property has no effect.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bDisplayOnly">New value for property <code>displayOnly</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.CheckBox setDisplayOnly(bool bDisplayOnly);

				#endregion

				#region Methods for Property wrapping

				/// <summary>
				/// Gets current value of property {@link #getWrapping wrapping}.
				/// 
				/// Determines whether the label's text is wrapped.
				/// 
				/// When set to <code>false</code> (default), the label's text is truncated with ellipsis at the end.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>wrapping</code></returns>
				public extern virtual bool getWrapping();

				/// <summary>
				/// Sets a new value for property {@link #getWrapping wrapping}.
				/// 
				/// Determines whether the label's text is wrapped.
				/// 
				/// When set to <code>false</code> (default), the label's text is truncated with ellipsis at the end.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bWrapping">New value for property <code>wrapping</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.CheckBox setWrapping(bool bWrapping);

				#endregion

				#region Methods for Aggregation _label

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
				public extern virtual sap.m.CheckBox addAriaDescribedBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaDescribedBy);

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
				public extern virtual sap.m.CheckBox addAriaLabelledBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaLabelledBy);

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
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.m.CheckBox</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.CheckBox</code> itself.
				/// 
				/// Event is triggered when the control status is changed by the user by selecting or deselecting the checkbox.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.CheckBox</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.CheckBox attachSelect(object oData, sap.m.SelectDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.m.CheckBox</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.CheckBox</code> itself.
				/// 
				/// Event is triggered when the control status is changed by the user by selecting or deselecting the checkbox.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.CheckBox attachSelect(object oData, sap.m.SelectDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.m.CheckBox</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.CheckBox</code> itself.
				/// 
				/// Event is triggered when the control status is changed by the user by selecting or deselecting the checkbox.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.CheckBox attachSelect(sap.m.SelectDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.m.CheckBox</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.CheckBox</code> itself.
				/// 
				/// Event is triggered when the control status is changed by the user by selecting or deselecting the checkbox.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.CheckBox</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.CheckBox attachSelect(sap.m.SelectDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:select select} event of this <code>sap.m.CheckBox</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.CheckBox detachSelect(sap.m.SelectDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:select select} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.CheckBox fireSelect(sap.m.SelectInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:select select} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.CheckBox fireSelect();

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.CheckBox with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.CheckBox with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.CheckBox with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <returns>The <code>sap.m.CheckBox</code> accessibility information</returns>
				public extern virtual object getAccessibilityInfo();

				/// <summary>
				/// Returns a metadata object for class sap.m.CheckBox.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				/// <summary>
				/// Returns the CheckBox`s tab index.
				/// </summary>
				/// <returns>iTabIndex for Checkbox</returns>
				public extern virtual int getTabIndex();

				/// <summary>
				/// Sets the tab index of the control
				/// </summary>
				/// <param name="iTabIndex">The tab index should be greater than or equal -1</param>
				/// <returns>The <code>sap.m.CheckBox</code> instance</returns>
				public extern virtual sap.m.CheckBox setTabIndex(int iTabIndex);

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
