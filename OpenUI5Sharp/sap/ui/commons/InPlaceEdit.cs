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
				/// The InPlaceEdit is a functionality to have text in display mode that can be changed in place.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.InPlaceEdit")]
				[Obsolete("Deprecated since 1.38. replaced by {@link sap.m.Input}")]
				public partial class InPlaceEdit : sap.ui.core.Control
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
						/// Visualizes warnings or errors related to the InPlaceEdit. Possible values: Warning, Error, Success. If the content control has an own valueState property this will be used.
						/// </summary>
						public Union<sap.ui.core.ValueState, string, sap.ui.@base.ManagedObject.BindPropertyInfo> valueState;

						/// <summary>
						/// If undo is enabled after changing the text an undo button appears.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> undoEnabled;

						/// <summary>
						/// Defines the visual appearance of the control. Currently this is not supported for Labels.
						/// </summary>
						public Union<sap.ui.commons.TextViewDesign, string, sap.ui.@base.ManagedObject.BindPropertyInfo> design;

						/// <summary>
						/// Content control of the InPlaceEdit. The following controls are allowed: TextField, ComboBox, DropdownBox and Link
						/// </summary>
						public Union<sap.ui.core.Control, string, sap.ui.@base.ManagedObject.BindAggregationInfo> content;

						/// <summary>
						/// Event is fired when the text in the field has changed AND the focus leaves the InPlaceEdit or the Enter key is pressed.
						/// </summary>
						public sap.ui.ux3.ChangeDelegate change;

						/// <summary>
						/// This event if fired during typing into the InPlaceEdit and returns the currently entered value. This is not the content of the value property. The value property is only updated by ENTER and by leaving the control.
						/// </summary>
						public sap.ui.commons.LiveChangeDelegate liveChange;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new InPlaceEdit.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern InPlaceEdit(string sId, sap.ui.commons.InPlaceEdit.Settings mSettings);

					/// <summary>
					/// Constructor for a new InPlaceEdit.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern InPlaceEdit(string sId);

					/// <summary>
					/// Constructor for a new InPlaceEdit.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern InPlaceEdit();

					/// <summary>
					/// Constructor for a new InPlaceEdit.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern InPlaceEdit(sap.ui.commons.InPlaceEdit.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property valueState

					/// <summary>
					/// Gets current value of property {@link #getValueState valueState}.
					/// 
					/// Visualizes warnings or errors related to the InPlaceEdit. Possible values: Warning, Error, Success. If the content control has an own valueState property this will be used.
					/// 
					/// Default value is <code>None</code>.
					/// </summary>
					/// <returns>Value of property <code>valueState</code></returns>
					public extern virtual sap.ui.core.ValueState getValueState();

					/// <summary>
					/// Sets a new value for property {@link #getValueState valueState}.
					/// 
					/// Visualizes warnings or errors related to the InPlaceEdit. Possible values: Warning, Error, Success. If the content control has an own valueState property this will be used.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>None</code>.
					/// </summary>
					/// <param name="sValueState">New value for property <code>valueState</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.InPlaceEdit setValueState(sap.ui.core.ValueState sValueState);

					#endregion

					#region Methods for Property undoEnabled

					/// <summary>
					/// Gets current value of property {@link #getUndoEnabled undoEnabled}.
					/// 
					/// If undo is enabled after changing the text an undo button appears.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>undoEnabled</code></returns>
					public extern virtual bool getUndoEnabled();

					/// <summary>
					/// Sets a new value for property {@link #getUndoEnabled undoEnabled}.
					/// 
					/// If undo is enabled after changing the text an undo button appears.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bUndoEnabled">New value for property <code>undoEnabled</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.InPlaceEdit setUndoEnabled(bool bUndoEnabled);

					#endregion

					#region Methods for Property design

					/// <summary>
					/// Gets current value of property {@link #getDesign design}.
					/// 
					/// Defines the visual appearance of the control. Currently this is not supported for Labels.
					/// 
					/// Default value is <code>Standard</code>.
					/// </summary>
					/// <returns>Value of property <code>design</code></returns>
					public extern virtual sap.ui.commons.TextViewDesign getDesign();

					/// <summary>
					/// Sets a new value for property {@link #getDesign design}.
					/// 
					/// Defines the visual appearance of the control. Currently this is not supported for Labels.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>Standard</code>.
					/// </summary>
					/// <param name="sDesign">New value for property <code>design</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.InPlaceEdit setDesign(sap.ui.commons.TextViewDesign sDesign);

					#endregion

					#region Methods for Aggregation content

					/// <summary>
					/// Gets content of aggregation {@link #getContent content}.
					/// 
					/// Content control of the InPlaceEdit. The following controls are allowed: TextField, ComboBox, DropdownBox and Link
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.Control getContent();

					/// <summary>
					/// Destroys the content in the aggregation {@link #getContent content}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.InPlaceEdit destroyContent();

					/// <summary>
					/// Sets the aggregated {@link #getContent content}.
					/// </summary>
					/// <param name="oContent">The content to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.InPlaceEdit setContent(sap.ui.core.Control oContent);

					#endregion

					#region Methods for Event change

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:change change} event of this <code>sap.ui.commons.InPlaceEdit</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.InPlaceEdit</code> itself.
					/// 
					/// Event is fired when the text in the field has changed AND the focus leaves the InPlaceEdit or the Enter key is pressed.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.InPlaceEdit</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.InPlaceEdit attachChange(object oData, sap.ui.ux3.ChangeDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:change change} event of this <code>sap.ui.commons.InPlaceEdit</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.InPlaceEdit</code> itself.
					/// 
					/// Event is fired when the text in the field has changed AND the focus leaves the InPlaceEdit or the Enter key is pressed.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.InPlaceEdit attachChange(object oData, sap.ui.ux3.ChangeDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:change change} event of this <code>sap.ui.commons.InPlaceEdit</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.InPlaceEdit</code> itself.
					/// 
					/// Event is fired when the text in the field has changed AND the focus leaves the InPlaceEdit or the Enter key is pressed.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.InPlaceEdit attachChange(sap.ui.ux3.ChangeDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:change change} event of this <code>sap.ui.commons.InPlaceEdit</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.InPlaceEdit</code> itself.
					/// 
					/// Event is fired when the text in the field has changed AND the focus leaves the InPlaceEdit or the Enter key is pressed.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.InPlaceEdit</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.InPlaceEdit attachChange(sap.ui.ux3.ChangeDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:change change} event of this <code>sap.ui.commons.InPlaceEdit</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.InPlaceEdit detachChange(sap.ui.ux3.ChangeDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:change change} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.InPlaceEdit fireChange(sap.ui.ux3.ChangeInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:change change} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.InPlaceEdit fireChange();

					#endregion

					#region Methods for Event liveChange

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:liveChange liveChange} event of this <code>sap.ui.commons.InPlaceEdit</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.InPlaceEdit</code> itself.
					/// 
					/// This event if fired during typing into the InPlaceEdit and returns the currently entered value. This is not the content of the value property. The value property is only updated by ENTER and by leaving the control.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.InPlaceEdit</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.InPlaceEdit attachLiveChange(object oData, sap.ui.commons.LiveChangeDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:liveChange liveChange} event of this <code>sap.ui.commons.InPlaceEdit</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.InPlaceEdit</code> itself.
					/// 
					/// This event if fired during typing into the InPlaceEdit and returns the currently entered value. This is not the content of the value property. The value property is only updated by ENTER and by leaving the control.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.InPlaceEdit attachLiveChange(object oData, sap.ui.commons.LiveChangeDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:liveChange liveChange} event of this <code>sap.ui.commons.InPlaceEdit</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.InPlaceEdit</code> itself.
					/// 
					/// This event if fired during typing into the InPlaceEdit and returns the currently entered value. This is not the content of the value property. The value property is only updated by ENTER and by leaving the control.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.InPlaceEdit attachLiveChange(sap.ui.commons.LiveChangeDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:liveChange liveChange} event of this <code>sap.ui.commons.InPlaceEdit</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.InPlaceEdit</code> itself.
					/// 
					/// This event if fired during typing into the InPlaceEdit and returns the currently entered value. This is not the content of the value property. The value property is only updated by ENTER and by leaving the control.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.InPlaceEdit</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.InPlaceEdit attachLiveChange(sap.ui.commons.LiveChangeDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:liveChange liveChange} event of this <code>sap.ui.commons.InPlaceEdit</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.InPlaceEdit detachLiveChange(sap.ui.commons.LiveChangeDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:liveChange liveChange} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.InPlaceEdit fireLiveChange(sap.ui.commons.LiveChangeInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:liveChange liveChange} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.InPlaceEdit fireLiveChange();

					#endregion

					#region Other methods

					/// <summary>
					/// Clear the old text after a change to disable the undo functionality. If undoEnabled is false this has no effect.
					/// </summary>
					public extern virtual void clearOldText();

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.InPlaceEdit with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.InPlaceEdit with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.InPlaceEdit with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <returns>Current accessibility state of the control.</returns>
					public extern virtual object getAccessibilityInfo();

					/// <summary>
					/// Returns a metadata object for class sap.ui.commons.InPlaceEdit.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					[Name("getMetadata")]
					public extern static sap.ui.@base.Metadata getMetadataStatic();

					/// <summary>
					/// Returns the tooltip for this InPlaceEdit if any or an undefined value. The tooltip can either be a simple string or a subclass of {@link sap.ui.core.TooltipBase}.
					/// 
					/// Callers that are only interested in tooltips of type string (e.g. to render them as a <code>title</code> attribute), should call the convenience method {@link #getTooltip_AsString} instead. If they want to get a tooltip text no matter where it comes from (be it a string tooltip or the text from a TooltipBase instance) then they could call {@link #getTooltip_Text} instead.
					/// 
					/// If a content control is assigned to the InPlaceEdit the tooltip of this control is used. A directly set tooltip to the InPlaceEdit is ignored in this case.
					/// </summary>
					/// <returns>The tooltip for this Element.</returns>
					public extern override Union<string, sap.ui.core.TooltipBase> getTooltip();

					/// <summary>
					/// Sets a new tooltip for this InPlaceEdit. The tooltip can either be a simple string (which in most cases will be rendered as the <code>title</code> attribute of this Element) or an instance of {@link sap.ui.core.TooltipBase}.
					/// 
					/// If a new tooltip is set, any previously set tooltip is deactivated.
					/// 
					/// If a content control is assigned to the InPlaceEdit the tooltip of this control is used. A directly set tooltip to the InPlaceEdit is ignored in this case.
					/// </summary>
					/// <param name="oTooltip">Tooltip as string or RichTooltip.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.commons.InPlaceEdit setTooltip(Union<string, sap.ui.core.TooltipBase> oTooltip);

					#endregion

					#endregion

				}
			}
		}
	}
}
