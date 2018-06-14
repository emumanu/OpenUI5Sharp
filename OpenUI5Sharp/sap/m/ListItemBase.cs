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
			/// ListItemBase contains the base features of all specific list items. <b>Note:</b> If not mentioned otherwise in the individual subclasses, list items must only be used in the <code>items</code> aggregation of <code>sap.m.ListBase</code> controls.
			/// </summary>
			[External]
			[Namespace(false)]
			public partial class ListItemBase : sap.ui.core.Control
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
					/// Defines the visual indication and behavior of the list items, e.g. <code>Active</code>, <code>Navigation</code>, <code>Detail</code>.
					/// </summary>
					public Union<sap.m.ListType, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> type;

					/// <summary>
					/// Whether the control should be visible on the screen. If set to false, a placeholder is rendered instead of the real control.
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> visible;

					/// <summary>
					/// Activates the unread indicator for the list item, if set to <code>true</code>. <b>Note:</b> This flag is ignored when the <code>showUnread</code> property of the parent is set to <code>false</code>.
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> unread;

					/// <summary>
					/// Defines the selected state of the list items. <b>Note:</b> Binding the <code>selected</code> property in single selection modes may cause unwanted results if you have more than one selected items in your binding.
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> selected;

					/// <summary>
					/// Defines the counter value of the list items.
					/// </summary>
					public Union<int, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> counter;

					/// <summary>
					/// Defines the highlight state of the list items.
					/// </summary>
					public Union<sap.ui.core.MessageType, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> highlight;

					/// <summary>
					/// Association to controls / ids which label this control (see WAI-ARIA attribute aria-labelledby).
					/// </summary>
					public Union<sap.ui.core.Control, sap.ui.core.ID[], string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> ariaLabelledBy;

					/// <summary>
					/// Fires when the user taps on the control.
					/// </summary>
					public sap.ui.@base.EventDelegate tap;

					/// <summary>
					/// Fires when the user taps on the detail button of the control.
					/// </summary>
					public sap.ui.@base.EventDelegate detailTap;

					/// <summary>
					/// Fires when the user clicks on the control. <b>Note:</b> This event is not fired when the parent <code>mode</code> is <code>SingleSelectMaster</code> or when the <code>includeItemInSelection</code> property is set to <code>true</code>. If there is an interactive element that handles its own <code>press</code> event then the list item's <code>press</code> event is not fired. Also see {@link sap.m.ListBase#attachItemPress}.
					/// </summary>
					public sap.ui.@base.EventDelegate press;

					/// <summary>
					/// Fires when the user clicks on the detail button of the control.
					/// </summary>
					public sap.ui.@base.EventDelegate detailPress;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new ListItemBase.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">Id for the new control, generated automatically if no id is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern ListItemBase(string sId, sap.m.ListItemBase.Settings mSettings);

				/// <summary>
				/// Constructor for a new ListItemBase.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">Id for the new control, generated automatically if no id is given</param>
				public extern ListItemBase(string sId);

				/// <summary>
				/// Constructor for a new ListItemBase.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern ListItemBase();

				/// <summary>
				/// Constructor for a new ListItemBase.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern ListItemBase(sap.m.ListItemBase.Settings mSettings);

				#endregion

				#region Fields

				/// <summary>
				/// Returns the state of the item selection as a boolean
				/// </summary>
				public object isSelected;

				#endregion

				#region Methods

				#region Methods for Property type

				/// <summary>
				/// Gets current value of property {@link #getType type}.
				/// 
				/// Defines the visual indication and behavior of the list items, e.g. <code>Active</code>, <code>Navigation</code>, <code>Detail</code>.
				/// 
				/// Default value is <code>Inactive</code>.
				/// </summary>
				/// <returns>Value of property <code>type</code></returns>
				public extern virtual sap.m.ListType getType();

				/// <summary>
				/// Sets a new value for property {@link #getType type}.
				/// 
				/// Defines the visual indication and behavior of the list items, e.g. <code>Active</code>, <code>Navigation</code>, <code>Detail</code>.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Inactive</code>.
				/// </summary>
				/// <param name="sType">New value for property <code>type</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListItemBase setType(sap.m.ListType sType);

				#endregion

				#region Methods for Property visible

				/// <summary>
				/// Gets current value of property {@link #getVisible visible}.
				/// 
				/// Whether the control should be visible on the screen. If set to false, a placeholder is rendered instead of the real control.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>visible</code></returns>
				public extern override bool getVisible();

				/// <summary>
				/// Sets a new value for property {@link #getVisible visible}.
				/// 
				/// Whether the control should be visible on the screen. If set to false, a placeholder is rendered instead of the real control.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bVisible">New value for property <code>visible</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListItemBase setVisible(bool bVisible);

				#endregion

				#region Methods for Property unread

				/// <summary>
				/// Gets current value of property {@link #getUnread unread}.
				/// 
				/// Activates the unread indicator for the list item, if set to <code>true</code>. <b>Note:</b> This flag is ignored when the <code>showUnread</code> property of the parent is set to <code>false</code>.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>unread</code></returns>
				public extern virtual bool getUnread();

				/// <summary>
				/// Sets a new value for property {@link #getUnread unread}.
				/// 
				/// Activates the unread indicator for the list item, if set to <code>true</code>. <b>Note:</b> This flag is ignored when the <code>showUnread</code> property of the parent is set to <code>false</code>.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bUnread">New value for property <code>unread</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListItemBase setUnread(bool bUnread);

				#endregion

				#region Methods for Property selected

				/// <summary>
				/// Gets current value of property {@link #getSelected selected}.
				/// 
				/// Defines the selected state of the list items. <b>Note:</b> Binding the <code>selected</code> property in single selection modes may cause unwanted results if you have more than one selected items in your binding.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>selected</code></returns>
				public extern virtual bool getSelected();

				/// <summary>
				/// Sets a new value for property {@link #getSelected selected}.
				/// 
				/// Defines the selected state of the list items. <b>Note:</b> Binding the <code>selected</code> property in single selection modes may cause unwanted results if you have more than one selected items in your binding.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bSelected">New value for property <code>selected</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListItemBase setSelected(bool bSelected);

				#endregion

				#region Methods for Property counter

				/// <summary>
				/// Gets current value of property {@link #getCounter counter}.
				/// 
				/// Defines the counter value of the list items.
				/// </summary>
				/// <returns>Value of property <code>counter</code></returns>
				public extern virtual int getCounter();

				/// <summary>
				/// Sets a new value for property {@link #getCounter counter}.
				/// 
				/// Defines the counter value of the list items.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="iCounter">New value for property <code>counter</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListItemBase setCounter(int iCounter);

				#endregion

				#region Methods for Property highlight

				/// <summary>
				/// Gets current value of property {@link #getHighlight highlight}.
				/// 
				/// Defines the highlight state of the list items.
				/// 
				/// Default value is <code>None</code>.
				/// </summary>
				/// <returns>Value of property <code>highlight</code></returns>
				public extern virtual sap.ui.core.MessageType getHighlight();

				/// <summary>
				/// Sets a new value for property {@link #getHighlight highlight}.
				/// 
				/// Defines the highlight state of the list items.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>None</code>.
				/// </summary>
				/// <param name="sHighlight">New value for property <code>highlight</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListItemBase setHighlight(sap.ui.core.MessageType sHighlight);

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
				public extern virtual sap.m.ListItemBase addAriaLabelledBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaLabelledBy);

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

				#region Methods for Event tap

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:tap tap} event of this <code>sap.m.ListItemBase</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ListItemBase</code> itself.
				/// 
				/// Fires when the user taps on the control.
				/// </summary>
				[Obsolete("Deprecated since 1.20.0. Instead, use <code>press</code> event.")]
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ListItemBase</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListItemBase attachTap(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:tap tap} event of this <code>sap.m.ListItemBase</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ListItemBase</code> itself.
				/// 
				/// Fires when the user taps on the control.
				/// </summary>
				[Obsolete("Deprecated since 1.20.0. Instead, use <code>press</code> event.")]
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListItemBase attachTap(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:tap tap} event of this <code>sap.m.ListItemBase</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ListItemBase</code> itself.
				/// 
				/// Fires when the user taps on the control.
				/// </summary>
				[Obsolete("Deprecated since 1.20.0. Instead, use <code>press</code> event.")]
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListItemBase attachTap(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:tap tap} event of this <code>sap.m.ListItemBase</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ListItemBase</code> itself.
				/// 
				/// Fires when the user taps on the control.
				/// </summary>
				[Obsolete("Deprecated since 1.20.0. Instead, use <code>press</code> event.")]
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ListItemBase</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListItemBase attachTap(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:tap tap} event of this <code>sap.m.ListItemBase</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				[Obsolete("Deprecated since 1.20.0. Instead, use <code>press</code> event.")]
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListItemBase detachTap(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:tap tap} to attached listeners.
				/// </summary>
				[Obsolete("Deprecated since 1.20.0. Instead, use <code>press</code> event.")]
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListItemBase fireTap(object mParameters);

				/// <summary>
				/// Fires event {@link #event:tap tap} to attached listeners.
				/// </summary>
				[Obsolete("Deprecated since 1.20.0. Instead, use <code>press</code> event.")]
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListItemBase fireTap();

				#endregion

				#region Methods for Event detailTap

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:detailTap detailTap} event of this <code>sap.m.ListItemBase</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ListItemBase</code> itself.
				/// 
				/// Fires when the user taps on the detail button of the control.
				/// </summary>
				[Obsolete("Deprecated since 1.20.0. Instead, use <code>detailPress</code> event.")]
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ListItemBase</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListItemBase attachDetailTap(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:detailTap detailTap} event of this <code>sap.m.ListItemBase</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ListItemBase</code> itself.
				/// 
				/// Fires when the user taps on the detail button of the control.
				/// </summary>
				[Obsolete("Deprecated since 1.20.0. Instead, use <code>detailPress</code> event.")]
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListItemBase attachDetailTap(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:detailTap detailTap} event of this <code>sap.m.ListItemBase</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ListItemBase</code> itself.
				/// 
				/// Fires when the user taps on the detail button of the control.
				/// </summary>
				[Obsolete("Deprecated since 1.20.0. Instead, use <code>detailPress</code> event.")]
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListItemBase attachDetailTap(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:detailTap detailTap} event of this <code>sap.m.ListItemBase</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ListItemBase</code> itself.
				/// 
				/// Fires when the user taps on the detail button of the control.
				/// </summary>
				[Obsolete("Deprecated since 1.20.0. Instead, use <code>detailPress</code> event.")]
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ListItemBase</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListItemBase attachDetailTap(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:detailTap detailTap} event of this <code>sap.m.ListItemBase</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				[Obsolete("Deprecated since 1.20.0. Instead, use <code>detailPress</code> event.")]
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListItemBase detachDetailTap(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:detailTap detailTap} to attached listeners.
				/// </summary>
				[Obsolete("Deprecated since 1.20.0. Instead, use <code>detailPress</code> event.")]
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListItemBase fireDetailTap(object mParameters);

				/// <summary>
				/// Fires event {@link #event:detailTap detailTap} to attached listeners.
				/// </summary>
				[Obsolete("Deprecated since 1.20.0. Instead, use <code>detailPress</code> event.")]
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListItemBase fireDetailTap();

				#endregion

				#region Methods for Event press

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:press press} event of this <code>sap.m.ListItemBase</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ListItemBase</code> itself.
				/// 
				/// Fires when the user clicks on the control. <b>Note:</b> This event is not fired when the parent <code>mode</code> is <code>SingleSelectMaster</code> or when the <code>includeItemInSelection</code> property is set to <code>true</code>. If there is an interactive element that handles its own <code>press</code> event then the list item's <code>press</code> event is not fired. Also see {@link sap.m.ListBase#attachItemPress}.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ListItemBase</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListItemBase attachPress(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:press press} event of this <code>sap.m.ListItemBase</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ListItemBase</code> itself.
				/// 
				/// Fires when the user clicks on the control. <b>Note:</b> This event is not fired when the parent <code>mode</code> is <code>SingleSelectMaster</code> or when the <code>includeItemInSelection</code> property is set to <code>true</code>. If there is an interactive element that handles its own <code>press</code> event then the list item's <code>press</code> event is not fired. Also see {@link sap.m.ListBase#attachItemPress}.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListItemBase attachPress(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:press press} event of this <code>sap.m.ListItemBase</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ListItemBase</code> itself.
				/// 
				/// Fires when the user clicks on the control. <b>Note:</b> This event is not fired when the parent <code>mode</code> is <code>SingleSelectMaster</code> or when the <code>includeItemInSelection</code> property is set to <code>true</code>. If there is an interactive element that handles its own <code>press</code> event then the list item's <code>press</code> event is not fired. Also see {@link sap.m.ListBase#attachItemPress}.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListItemBase attachPress(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:press press} event of this <code>sap.m.ListItemBase</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ListItemBase</code> itself.
				/// 
				/// Fires when the user clicks on the control. <b>Note:</b> This event is not fired when the parent <code>mode</code> is <code>SingleSelectMaster</code> or when the <code>includeItemInSelection</code> property is set to <code>true</code>. If there is an interactive element that handles its own <code>press</code> event then the list item's <code>press</code> event is not fired. Also see {@link sap.m.ListBase#attachItemPress}.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ListItemBase</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListItemBase attachPress(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:press press} event of this <code>sap.m.ListItemBase</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListItemBase detachPress(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:press press} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListItemBase firePress(object mParameters);

				/// <summary>
				/// Fires event {@link #event:press press} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListItemBase firePress();

				#endregion

				#region Methods for Event detailPress

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:detailPress detailPress} event of this <code>sap.m.ListItemBase</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ListItemBase</code> itself.
				/// 
				/// Fires when the user clicks on the detail button of the control.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ListItemBase</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListItemBase attachDetailPress(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:detailPress detailPress} event of this <code>sap.m.ListItemBase</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ListItemBase</code> itself.
				/// 
				/// Fires when the user clicks on the detail button of the control.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListItemBase attachDetailPress(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:detailPress detailPress} event of this <code>sap.m.ListItemBase</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ListItemBase</code> itself.
				/// 
				/// Fires when the user clicks on the detail button of the control.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListItemBase attachDetailPress(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:detailPress detailPress} event of this <code>sap.m.ListItemBase</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ListItemBase</code> itself.
				/// 
				/// Fires when the user clicks on the detail button of the control.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ListItemBase</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListItemBase attachDetailPress(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:detailPress detailPress} event of this <code>sap.m.ListItemBase</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListItemBase detachDetailPress(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:detailPress detailPress} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListItemBase fireDetailPress(object mParameters);

				/// <summary>
				/// Fires event {@link #event:detailPress detailPress} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ListItemBase fireDetailPress();

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.ListItemBase with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.ListItemBase with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.ListItemBase with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns the accessibility announcement for the content.
				/// 
				/// Hook for the subclasses.
				/// </summary>
				/// <returns></returns>
				public extern virtual string getContentAnnouncement();

				/// <summary>
				/// Returns a metadata object for class sap.m.ListItemBase.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				/// <summary>
				/// Returns the tabbable DOM elements as a jQuery collection
				/// </summary>
				/// <returns>jQuery object</returns>
				public extern virtual jquery.JQuery<object> getTabbables();

				#endregion

				#endregion

			}
		}
	}
}
