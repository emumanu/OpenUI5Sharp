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
				/// The SegmentedButton provides a group of multiple buttons. Only one button can be active. The behaviour is more ore less like a radio button group.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.SegmentedButton")]
				[Obsolete("Deprecated since 1.38. replaced by {@link sap.m.SegmentedButton}")]
				public partial class SegmentedButton : sap.ui.core.Control, sap.ui.commons.ToolbarItem, sap.ui.core.IFormContent
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
						/// enabled
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> enabled;

						/// <summary>
						/// Buttons
						/// </summary>
						public Union<sap.ui.commons.Button[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> buttons;

						/// <summary>
						/// Selected Button
						/// </summary>
						public Union<sap.ui.commons.Button, sap.ui.core.ID, string, sap.ui.@base.ManagedObject.BindPropertyInfo> selectedButton;

						/// <summary>
						/// Event fired when button selected
						/// </summary>
						public sap.ui.commons.SegmentedButton.SelectDelegate select;

					}

					#endregion

					#region Typed Parameters

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class SelectInfo
					{
						/// <summary>
						/// Id of selected ToggleButton
						/// </summary>
						public string selectedButtonId;

					}

					#endregion

					#region Delegates

					public delegate void SelectDelegate(sap.ui.@base.Event<sap.ui.commons.SegmentedButton.SelectInfo> oEvent, object oData);

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new SegmentedButton.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern SegmentedButton(string sId, sap.ui.commons.SegmentedButton.Settings mSettings);

					/// <summary>
					/// Constructor for a new SegmentedButton.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern SegmentedButton(string sId);

					/// <summary>
					/// Constructor for a new SegmentedButton.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern SegmentedButton();

					/// <summary>
					/// Constructor for a new SegmentedButton.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern SegmentedButton(sap.ui.commons.SegmentedButton.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property enabled

					/// <summary>
					/// Gets current value of property {@link #getEnabled enabled}.
					/// 
					/// enabled
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>enabled</code></returns>
					public extern virtual bool getEnabled();

					/// <summary>
					/// Sets a new value for property {@link #getEnabled enabled}.
					/// 
					/// enabled
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bEnabled">New value for property <code>enabled</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.SegmentedButton setEnabled(bool bEnabled);

					#endregion

					#region Methods for Aggregation buttons

					/// <summary>
					/// Gets content of aggregation {@link #getButtons buttons}.
					/// 
					/// Buttons
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.commons.Button[] getButtons();

					/// <summary>
					/// Destroys all the buttons in the aggregation {@link #getButtons buttons}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.SegmentedButton destroyButtons();

					/// <summary>
					/// Inserts a button into the aggregation {@link #getButtons buttons}.
					/// </summary>
					/// <param name="oButton">The button to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the button should be inserted at; for a negative value of <code>iIndex</code>, the button is inserted at position 0; for a value greater than the current size of the aggregation, the button is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.SegmentedButton insertButton(sap.ui.commons.Button oButton, int iIndex);

					/// <summary>
					/// Adds some button to the aggregation {@link #getButtons buttons}.
					/// </summary>
					/// <param name="oButton">The button to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.SegmentedButton addButton(sap.ui.commons.Button oButton);

					/// <summary>
					/// Removes a button from the aggregation {@link #getButtons buttons}.
					/// </summary>
					/// <param name="vButton">The button to remove or its index or id</param>
					/// <returns>The removed button or <code>null</code></returns>
					public extern virtual sap.ui.commons.Button removeButton(Union<int, string, sap.ui.commons.Button> vButton);

					/// <summary>
					/// Checks for the provided <code>sap.ui.commons.Button</code> in the aggregation {@link #getButtons buttons}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oButton">The button whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfButton(sap.ui.commons.Button oButton);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getButtons buttons}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.commons.Button[] removeAllButtons();

					#endregion

					#region Methods for Association selectedButton

					/// <summary>
					/// ID of the element which is the current target of the association {@link #getSelectedButton selectedButton}, or <code>null</code>.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.ID getSelectedButton();

					/// <summary>
					/// Sets the associated {@link #getSelectedButton selectedButton}.
					/// </summary>
					/// <param name="oSelectedButton">ID of an element which becomes the new target of this selectedButton association; alternatively, an element instance may be given</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.SegmentedButton setSelectedButton(Union<sap.ui.core.ID, sap.ui.commons.Button> oSelectedButton);

					#endregion

					#region Methods for Event select

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.ui.commons.SegmentedButton</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.SegmentedButton</code> itself.
					/// 
					/// Event fired when button selected
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.SegmentedButton</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.SegmentedButton attachSelect(object oData, sap.ui.commons.SegmentedButton.SelectDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.ui.commons.SegmentedButton</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.SegmentedButton</code> itself.
					/// 
					/// Event fired when button selected
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.SegmentedButton attachSelect(object oData, sap.ui.commons.SegmentedButton.SelectDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.ui.commons.SegmentedButton</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.SegmentedButton</code> itself.
					/// 
					/// Event fired when button selected
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.SegmentedButton attachSelect(sap.ui.commons.SegmentedButton.SelectDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.ui.commons.SegmentedButton</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.SegmentedButton</code> itself.
					/// 
					/// Event fired when button selected
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.SegmentedButton</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.SegmentedButton attachSelect(sap.ui.commons.SegmentedButton.SelectDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:select select} event of this <code>sap.ui.commons.SegmentedButton</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.SegmentedButton detachSelect(sap.ui.commons.SegmentedButton.SelectDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:select select} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.SegmentedButton fireSelect(sap.ui.commons.SegmentedButton.SelectInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:select select} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.SegmentedButton fireSelect();

					#endregion

					#region Other methods

					/// <summary>
					/// Rerendering of the Buttons
					/// </summary>
					public extern virtual void _rerenderButtons();

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.SegmentedButton with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.SegmentedButton with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.SegmentedButton with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.commons.SegmentedButton.
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
}
