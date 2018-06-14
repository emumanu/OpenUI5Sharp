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
			/// A horizontal control made of multiple buttons, which can display a title or an image.
			/// 
			/// <h3>Overview</h3>
			/// 
			/// The <code>SegmentedButton</code> shows a group of buttons. When the user clicks or taps one of the buttons, it stays in a pressed state. It automatically resizes the buttons to fit proportionally within the control. When no width is set, the control uses the available width.
			/// </summary>
			[External]
			[Namespace(false)]
			public partial class SegmentedButton : sap.ui.core.Control, sap.ui.core.IFormContent
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
					/// Defines the width of the SegmentedButton control. If not set, it uses the minimum required width to make all buttons inside of the same size (based on the biggest button).
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> width;

					/// <summary>
					/// Disables all the buttons in the SegmentedButton control. When disabled all the buttons look grey and you cannot focus or click on them.
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> enabled;

					/// <summary>
					/// Key of the selected item. If no item to this key is found in the items aggregation, no changes will apply. Only the items aggregation is affected. If duplicate keys exist, the first item matching the key is used.
					/// </summary>
					public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> selectedKey;

					/// <summary>
					/// The buttons of the SegmentedButton control. The items set in this aggregation are used as an interface for the buttons displayed by the control. Only the properties ID, icon, text, enabled and textDirections of the Button control are evaluated. Setting other properties of the button will have no effect. Alternatively, you can use the createButton method to add buttons.
					/// </summary>
					public Union<sap.m.Button[], string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> buttons;

					/// <summary>
					/// Aggregation of items to be displayed. The items set in this aggregation are used as an interface for the buttons displayed by the control. The "items" and "buttons" aggregations should NOT be used simultaneously as it causes the control to work incorrectly.
					/// </summary>
					public Union<sap.m.SegmentedButtonItem[], string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> items;

					/// <summary>
					/// A reference to the currently selected button control. By default or if the association is set to false (null, undefined, "", false), the first button will be selected. If the association is set to an invalid value (for example, an ID of a button that does not exist) the selection on the SegmentedButton will be removed.
					/// </summary>
					public Union<sap.m.Button, sap.ui.core.ID, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> selectedButton;

					/// <summary>
					/// A reference to the currently selected item control.
					/// </summary>
					public Union<sap.m.SegmentedButtonItem, sap.ui.core.ID, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> selectedItem;

					/// <summary>
					/// Association to controls / IDs, which describe this control (see WAI-ARIA attribute aria-describedby).
					/// </summary>
					public Union<sap.ui.core.Control, sap.ui.core.ID[], string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> ariaDescribedBy;

					/// <summary>
					/// Association to controls / IDs, which label this control (see WAI-ARIA attribute aria-labelledby).
					/// </summary>
					public Union<sap.ui.core.Control, sap.ui.core.ID[], string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> ariaLabelledBy;

					/// <summary>
					/// Fires when the user selects a button, which returns the ID and button object.
					/// </summary>
					public sap.m.SegmentedButton.SelectDelegate select;

					/// <summary>
					/// Fires when the user selects an item, which returns the item object.
					/// </summary>
					public sap.m.SegmentedButton.SelectionChangeDelegate selectionChange;

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
					/// Reference to the button, that has been selected.
					/// </summary>
					public sap.m.Button button;

					/// <summary>
					/// ID of the button, which has been selected.
					/// </summary>
					public string id;

					/// <summary>
					/// Key of the button, which has been selected. This property is only filled when the control is initiated with the items aggregation.
					/// </summary>
					public string key;

				}

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class SelectionChangeInfo
				{
					/// <summary>
					/// Reference to the item, that has been selected.
					/// </summary>
					public sap.m.SegmentedButtonItem item;

				}

				#endregion

				#region Delegates

				public delegate void SelectDelegate(sap.ui.@base.Event<sap.m.SegmentedButton.SelectInfo> oEvent, object oData);

				public delegate void SelectionChangeDelegate(sap.ui.@base.Event<sap.m.SegmentedButton.SelectionChangeInfo> oEvent, object oData);

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new <code>SegmentedButton</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern SegmentedButton(string sId, sap.m.SegmentedButton.Settings mSettings);

				/// <summary>
				/// Constructor for a new <code>SegmentedButton</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern SegmentedButton(string sId);

				/// <summary>
				/// Constructor for a new <code>SegmentedButton</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern SegmentedButton();

				/// <summary>
				/// Constructor for a new <code>SegmentedButton</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern SegmentedButton(sap.m.SegmentedButton.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property width

				/// <summary>
				/// Gets current value of property {@link #getWidth width}.
				/// 
				/// Defines the width of the SegmentedButton control. If not set, it uses the minimum required width to make all buttons inside of the same size (based on the biggest button).
				/// </summary>
				/// <returns>Value of property <code>width</code></returns>
				public extern virtual sap.ui.core.CSSSize getWidth();

				/// <summary>
				/// Sets a new value for property {@link #getWidth width}.
				/// 
				/// Defines the width of the SegmentedButton control. If not set, it uses the minimum required width to make all buttons inside of the same size (based on the biggest button).
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sWidth">New value for property <code>width</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SegmentedButton setWidth(sap.ui.core.CSSSize sWidth);

				#endregion

				#region Methods for Property enabled

				/// <summary>
				/// Gets current value of property {@link #getEnabled enabled}.
				/// 
				/// Disables all the buttons in the SegmentedButton control. When disabled all the buttons look grey and you cannot focus or click on them.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>enabled</code></returns>
				public extern virtual bool getEnabled();

				/// <summary>
				/// Sets a new value for property {@link #getEnabled enabled}.
				/// 
				/// Disables all the buttons in the SegmentedButton control. When disabled all the buttons look grey and you cannot focus or click on them.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bEnabled">New value for property <code>enabled</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SegmentedButton setEnabled(bool bEnabled);

				#endregion

				#region Methods for Property selectedKey

				/// <summary>
				/// Gets the <code>selectedKey</code> and is usable only when the control is initiated with the <code>items</code> aggregation.
				/// </summary>
				/// <returns>Current selected key</returns>
				public extern virtual string getSelectedKey();

				/// <summary>
				/// Sets the <code>selectedKey</code> and is usable only when the control is initiated with the <code>items</code> aggregation.
				/// </summary>
				/// <param name="sKey">The key of the button to be selected</param>
				/// <returns><code>this</code> pointer for chaining</returns>
				public extern virtual sap.m.SegmentedButton setSelectedKey(string sKey);

				/// <summary>
				/// Binds property {@link #getSelectedKey selectedKey} to model data.
				/// 
				/// See {@link sap.ui.base.ManagedObject#bindProperty ManagedObject.bindProperty} for a detailed description of the possible properties of <code>oBindingInfo</code>
				/// </summary>
				/// <param name="oBindingInfo">The binding information</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SegmentedButton bindSelectedKey(object oBindingInfo);

				/// <summary>
				/// Unbinds property {@link #getSelectedKey selectedKey} from model data.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SegmentedButton unbindSelectedKey();

				#endregion

				#region Methods for Aggregation buttons

				/// <summary>
				/// Gets content of aggregation {@link #getButtons buttons}.
				/// 
				/// The buttons of the SegmentedButton control. The items set in this aggregation are used as an interface for the buttons displayed by the control. Only the properties ID, icon, text, enabled and textDirections of the Button control are evaluated. Setting other properties of the button will have no effect. Alternatively, you can use the createButton method to add buttons.
				/// </summary>
				[Obsolete("Deprecated since 1.28.0. replaced by <code>items</code> aggregation")]
				/// <returns></returns>
				public extern virtual sap.m.Button[] getButtons();

				/// <summary>
				/// Destroys all the buttons in the aggregation {@link #getButtons buttons}.
				/// </summary>
				[Obsolete("Deprecated since 1.28.0. replaced by <code>items</code> aggregation")]
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SegmentedButton destroyButtons();

				/// <summary>
				/// Inserts a button into the aggregation {@link #getButtons buttons}.
				/// </summary>
				[Obsolete("Deprecated since 1.28.0. replaced by <code>items</code> aggregation")]
				/// <param name="oButton">The button to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the button should be inserted at; for a negative value of <code>iIndex</code>, the button is inserted at position 0; for a value greater than the current size of the aggregation, the button is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SegmentedButton insertButton(sap.m.Button oButton, int iIndex);

				/// <summary>
				/// Adds some button to the aggregation {@link #getButtons buttons}.
				/// </summary>
				[Obsolete("Deprecated since 1.28.0. replaced by <code>items</code> aggregation")]
				/// <param name="oButton">The button to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SegmentedButton addButton(sap.m.Button oButton);

				/// <summary>
				/// Removes a button from the aggregation {@link #getButtons buttons}.
				/// </summary>
				[Obsolete("Deprecated since 1.28.0. replaced by <code>items</code> aggregation")]
				/// <param name="vButton">The button to remove or its index or id</param>
				/// <returns>The removed button or <code>null</code></returns>
				public extern virtual sap.m.Button removeButton(Union<int, string, sap.m.Button> vButton);

				/// <summary>
				/// Checks for the provided <code>sap.m.Button</code> in the aggregation {@link #getButtons buttons}. and returns its index if found or -1 otherwise.
				/// </summary>
				[Obsolete("Deprecated since 1.28.0. replaced by <code>items</code> aggregation")]
				/// <param name="oButton">The button whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfButton(sap.m.Button oButton);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getButtons buttons}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				[Obsolete("Deprecated since 1.28.0. replaced by <code>items</code> aggregation")]
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.m.Button[] removeAllButtons();

				#endregion

				#region Methods for Aggregation items

				/// <summary>
				/// Gets content of aggregation {@link #getItems items}.
				/// 
				/// Aggregation of items to be displayed. The items set in this aggregation are used as an interface for the buttons displayed by the control. The "items" and "buttons" aggregations should NOT be used simultaneously as it causes the control to work incorrectly.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.SegmentedButtonItem[] getItems();

				/// <summary>
				/// Destroys all the items in the aggregation {@link #getItems items}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SegmentedButton destroyItems();

				/// <summary>
				/// Inserts item into <code>items</code> aggregation.
				/// </summary>
				/// <param name="oItem">The item to be inserted</param>
				/// <param name="iIndex">index the item should be inserted at</param>
				/// <returns><code>this</code> pointer for chaining</returns>
				public extern virtual sap.m.SegmentedButton insertItem(sap.m.SegmentedButtonItem oItem, int iIndex);

				/// <summary>
				/// Adds item to <code>items</code> aggregation.
				/// </summary>
				/// <param name="oItem">The item to be added</param>
				/// <returns><code>this</code> pointer for chaining</returns>
				public extern virtual sap.m.SegmentedButton addItem(sap.m.SegmentedButtonItem oItem);

				/// <summary>
				/// Removes an item from <code>items</code> aggregation.
				/// </summary>
				/// <param name="oItem">The item to be removed</param>
				public extern virtual void removeItem(sap.m.SegmentedButtonItem oItem);

				/// <summary>
				/// Checks for the provided <code>sap.m.SegmentedButtonItem</code> in the aggregation {@link #getItems items}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oItem">The item whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfItem(sap.m.SegmentedButtonItem oItem);

				/// <summary>
				/// Removes all items from <code>items</code> aggregation
				/// </summary>
				/// <param name="bSuppressInvalidate">If <code>true</code> the control invalidation will be suppressed</param>
				public extern virtual void removeAllItems(bool bSuppressInvalidate = false);

				/// <summary>
				/// Binds aggregation {@link #getItems items} to model data.
				/// 
				/// See {@link sap.ui.base.ManagedObject#bindAggregation ManagedObject.bindAggregation} for a detailed description of the possible properties of <code>oBindingInfo</code>.
				/// </summary>
				/// <param name="oBindingInfo">The binding information</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SegmentedButton bindItems(object oBindingInfo);

				/// <summary>
				/// Unbinds aggregation {@link #getItems items} from model data.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SegmentedButton unbindItems();

				#endregion

				#region Methods for Aggregation _select

				#endregion

				#region Methods for Association selectedButton

				/// <summary>
				/// ID of the element which is the current target of the association {@link #getSelectedButton selectedButton}, or <code>null</code>.
				/// </summary>
				[Obsolete("Deprecated since 1.52. replaced by <code>selectedItem</code> association")]
				/// <returns></returns>
				public extern virtual sap.ui.core.ID getSelectedButton();

				/// <summary>
				/// Setter for association <code>selectedButton</code>.
				/// </summary>
				/// <param name="vButton">New value for association <code>setSelectedButton</code> An sap.m.Button instance which becomes the new target of this <code>selectedButton</code> association. Alternatively, the ID of an sap.m.Button instance may be given as a string. If the value of null, undefined, or an empty string is provided the first item will be selected.</param>
				/// <returns><code>this</code> this pointer for chaining</returns>
				public extern virtual sap.m.SegmentedButton setSelectedButton(Union<string, sap.m.Button> vButton);

				#endregion

				#region Methods for Association selectedItem

				/// <summary>
				/// ID of the element which is the current target of the association {@link #getSelectedItem selectedItem}, or <code>null</code>.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.ID getSelectedItem();

				/// <summary>
				/// Setter for association <code>selectedItem</code>.
				/// </summary>
				/// <param name="vItem">New value for association <code>setSelectedItem</code> An sap.m.SegmentedButtonItem instance which becomes the new target of this <code>selectedItem</code> association. Alternatively, the ID of an <code>sap.m.SegmentedButtonItem</code> instance may be given as a string. If the value of null, undefined, or an empty string is provided, the first item will be selected.</param>
				/// <returns><code>this</code> pointer for chaining</returns>
				public extern virtual sap.m.SegmentedButton setSelectedItem(Union<string, sap.m.SegmentedButtonItem> vItem);

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
				public extern virtual sap.m.SegmentedButton addAriaDescribedBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaDescribedBy);

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
				public extern virtual sap.m.SegmentedButton addAriaLabelledBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaLabelledBy);

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
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.m.SegmentedButton</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SegmentedButton</code> itself.
				/// 
				/// Fires when the user selects a button, which returns the ID and button object.
				/// </summary>
				[Obsolete("Deprecated since 1.52. replaced by <code>selectionChange</code> event")]
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.SegmentedButton</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SegmentedButton attachSelect(object oData, sap.m.SegmentedButton.SelectDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.m.SegmentedButton</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SegmentedButton</code> itself.
				/// 
				/// Fires when the user selects a button, which returns the ID and button object.
				/// </summary>
				[Obsolete("Deprecated since 1.52. replaced by <code>selectionChange</code> event")]
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SegmentedButton attachSelect(object oData, sap.m.SegmentedButton.SelectDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.m.SegmentedButton</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SegmentedButton</code> itself.
				/// 
				/// Fires when the user selects a button, which returns the ID and button object.
				/// </summary>
				[Obsolete("Deprecated since 1.52. replaced by <code>selectionChange</code> event")]
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SegmentedButton attachSelect(sap.m.SegmentedButton.SelectDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.m.SegmentedButton</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SegmentedButton</code> itself.
				/// 
				/// Fires when the user selects a button, which returns the ID and button object.
				/// </summary>
				[Obsolete("Deprecated since 1.52. replaced by <code>selectionChange</code> event")]
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.SegmentedButton</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SegmentedButton attachSelect(sap.m.SegmentedButton.SelectDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:select select} event of this <code>sap.m.SegmentedButton</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				[Obsolete("Deprecated since 1.52. replaced by <code>selectionChange</code> event")]
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SegmentedButton detachSelect(sap.m.SegmentedButton.SelectDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:select select} to attached listeners.
				/// </summary>
				[Obsolete("Deprecated since 1.52. replaced by <code>selectionChange</code> event")]
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SegmentedButton fireSelect(sap.m.SegmentedButton.SelectInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:select select} to attached listeners.
				/// </summary>
				[Obsolete("Deprecated since 1.52. replaced by <code>selectionChange</code> event")]
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SegmentedButton fireSelect();

				#endregion

				#region Methods for Event selectionChange

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:selectionChange selectionChange} event of this <code>sap.m.SegmentedButton</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SegmentedButton</code> itself.
				/// 
				/// Fires when the user selects an item, which returns the item object.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.SegmentedButton</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SegmentedButton attachSelectionChange(object oData, sap.m.SegmentedButton.SelectionChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:selectionChange selectionChange} event of this <code>sap.m.SegmentedButton</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SegmentedButton</code> itself.
				/// 
				/// Fires when the user selects an item, which returns the item object.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SegmentedButton attachSelectionChange(object oData, sap.m.SegmentedButton.SelectionChangeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:selectionChange selectionChange} event of this <code>sap.m.SegmentedButton</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SegmentedButton</code> itself.
				/// 
				/// Fires when the user selects an item, which returns the item object.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SegmentedButton attachSelectionChange(sap.m.SegmentedButton.SelectionChangeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:selectionChange selectionChange} event of this <code>sap.m.SegmentedButton</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SegmentedButton</code> itself.
				/// 
				/// Fires when the user selects an item, which returns the item object.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.SegmentedButton</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SegmentedButton attachSelectionChange(sap.m.SegmentedButton.SelectionChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:selectionChange selectionChange} event of this <code>sap.m.SegmentedButton</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SegmentedButton detachSelectionChange(sap.m.SegmentedButton.SelectionChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:selectionChange selectionChange} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SegmentedButton fireSelectionChange(sap.m.SegmentedButton.SelectionChangeInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:selectionChange selectionChange} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SegmentedButton fireSelectionChange();

				#endregion

				#region Other methods

				/// <summary>
				/// Adds a Button with a text as title, a URI for an icon, enabled and textDirection. Only one is allowed.
				/// </summary>
				/// <param name="sText">Defines the title text of the newly created Button</param>
				/// <param name="sURI">Icon to be displayed as graphical element within the Button. Density related image will be loaded if image with density awareness name in format [imageName]@[densityValue].[extension] is provided.</param>
				/// <param name="bEnabled">Enables the control (default is true). Buttons that are disabled have other colors than enabled ones, depending on custom settings.</param>
				/// <param name="sTextDirection">Element's text directionality with enumerated options</param>
				/// <returns>The created Button</returns>
				public extern virtual sap.m.Button createButton(string sText, sap.ui.core.URI sURI, bool bEnabled, sap.ui.core.TextDirection sTextDirection);

				/// <summary>
				/// Adds a Button with a text as title, a URI for an icon, enabled and textDirection. Only one is allowed.
				/// </summary>
				/// <param name="sText">Defines the title text of the newly created Button</param>
				/// <param name="sURI">Icon to be displayed as graphical element within the Button. Density related image will be loaded if image with density awareness name in format [imageName]@[densityValue].[extension] is provided.</param>
				/// <param name="bEnabled">Enables the control (default is true). Buttons that are disabled have other colors than enabled ones, depending on custom settings.</param>
				/// <returns>The created Button</returns>
				public extern virtual sap.m.Button createButton(string sText, sap.ui.core.URI sURI, bool bEnabled);

				/// <summary>
				/// Creates a new subclass of class sap.m.SegmentedButton with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.SegmentedButton with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.SegmentedButton with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.SegmentedButton.
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
