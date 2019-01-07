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
			public static partial class ux3
			{
				/// <summary>
				/// A NotificationBar is a "toolbar" that can be added to a page to show messages and notifications from the application. Its position, height and width is inherited from the element that the notification bar is added to. The NotificationBar uses position: fixed; to always stay at the bottom of the screen. This CSS may sometimes cause issues when nested deeply inside other controls. To have a proper behavior of the NotificationBar use it as high in the control hierarchy as possible.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.ux3.NotificationBar")]
				[Obsolete("Deprecated since 1.38. Instead, use the <code>sap.m.MessagePopover</code> control.")]
				public partial class NotificationBar : sap.ui.core.Control
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
						/// This property displays the bar corresponding to given status
						/// </summary>
						public Union<sap.ui.ux3.NotificationBarStatus, string, sap.ui.@base.ManagedObject.BindPropertyInfo> visibleStatus;

						/// <summary>
						/// This property enables the bar to be resized by the user.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> resizeEnabled;

						/// <summary>
						/// This property defines if the toggler should be displayed the whole time when the NotificationBar is shown.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> alwaysShowToggler;

						/// <summary>
						/// Notifier that shows messages
						/// </summary>
						public Union<sap.ui.core.Element, string, sap.ui.@base.ManagedObject.BindAggregationInfo> messageNotifier;

						/// <summary>
						/// Notifiers that monitor something within the application and display the corresponding notifications.
						/// </summary>
						public Union<sap.ui.core.Element[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> notifiers;

						/// <summary>
						/// Event is fired when the bar wants to be displayed depending on given flag. This allows the application to decide what to do.
						/// </summary>
						public sap.ui.ux3.NotificationBar.DisplayDelegate display;

						/// <summary>
						/// This event is thrown when the bar was resized (to the different valid states: Min, Max, Default, None). The event itself can be used from SAPUI5-version 1.12.2 since there was a bug in the previous versions firing this event.
						/// </summary>
						public sap.ui.ux3.NotificationBar.ResizeDelegate resize;

					}

					#endregion

					#region Typed Parameters

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class DisplayInfo
					{
						/// <summary>
						/// Indicates if the bar wants to be shown or hidden
						/// </summary>
						public bool show;

					}

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class ResizeInfo
					{
						/// <summary>
						/// The corresponding status to which the bar was resized. The corresponding heights can be taken for the bar's CSS file.
						/// </summary>
						public sap.ui.ux3.NotificationBarStatus status;

					}

					#endregion

					#region Delegates

					public delegate void DisplayDelegate(sap.ui.@base.Event<sap.ui.ux3.NotificationBar.DisplayInfo> oEvent, object oData);

					public delegate void ResizeDelegate(sap.ui.@base.Event<sap.ui.ux3.NotificationBar.ResizeInfo> oEvent, object oData);

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new NotificationBar.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern NotificationBar(string sId, sap.ui.ux3.NotificationBar.Settings mSettings);

					/// <summary>
					/// Constructor for a new NotificationBar.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern NotificationBar(string sId);

					/// <summary>
					/// Constructor for a new NotificationBar.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern NotificationBar();

					/// <summary>
					/// Constructor for a new NotificationBar.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern NotificationBar(sap.ui.ux3.NotificationBar.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property visibleStatus

					/// <summary>
					/// Gets current value of property {@link #getVisibleStatus visibleStatus}.
					/// 
					/// This property displays the bar corresponding to given status
					/// 
					/// Default value is <code>Default</code>.
					/// </summary>
					/// <returns>Value of property <code>visibleStatus</code></returns>
					public extern virtual sap.ui.ux3.NotificationBarStatus getVisibleStatus();

					/// <summary>
					/// Sets a new value for property {@link #getVisibleStatus visibleStatus}.
					/// 
					/// This property displays the bar corresponding to given status
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>Default</code>.
					/// </summary>
					/// <param name="sVisibleStatus">New value for property <code>visibleStatus</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.NotificationBar setVisibleStatus(sap.ui.ux3.NotificationBarStatus sVisibleStatus);

					#endregion

					#region Methods for Property resizeEnabled

					/// <summary>
					/// Gets current value of property {@link #getResizeEnabled resizeEnabled}.
					/// 
					/// This property enables the bar to be resized by the user.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>resizeEnabled</code></returns>
					public extern virtual bool getResizeEnabled();

					/// <summary>
					/// Sets a new value for property {@link #getResizeEnabled resizeEnabled}.
					/// 
					/// This property enables the bar to be resized by the user.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bResizeEnabled">New value for property <code>resizeEnabled</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.NotificationBar setResizeEnabled(bool bResizeEnabled);

					#endregion

					#region Methods for Property alwaysShowToggler

					/// <summary>
					/// Gets current value of property {@link #getAlwaysShowToggler alwaysShowToggler}.
					/// 
					/// This property defines if the toggler should be displayed the whole time when the NotificationBar is shown.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>alwaysShowToggler</code></returns>
					public extern virtual bool getAlwaysShowToggler();

					/// <param name="bAlwaysShow">if the toggler should be visible all the time set this parameter to <b>true</b></param>
					public extern virtual void setAlwaysShowToggler(bool bAlwaysShow);

					#endregion

					#region Methods for Aggregation messageNotifier

					/// <summary>
					/// Gets content of aggregation {@link #getMessageNotifier messageNotifier}.
					/// 
					/// Notifier that shows messages
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.Element getMessageNotifier();

					/// <summary>
					/// Destroys the messageNotifier in the aggregation {@link #getMessageNotifier messageNotifier}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.NotificationBar destroyMessageNotifier();

					/// <summary>
					/// Sets the aggregated {@link #getMessageNotifier messageNotifier}.
					/// </summary>
					/// <param name="oMessageNotifier">The messageNotifier to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.NotificationBar setMessageNotifier(sap.ui.core.Element oMessageNotifier);

					#endregion

					#region Methods for Aggregation notifiers

					/// <summary>
					/// Gets content of aggregation {@link #getNotifiers notifiers}.
					/// 
					/// Notifiers that monitor something within the application and display the corresponding notifications.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.Element[] getNotifiers();

					/// <summary>
					/// Destroys all the notifiers in the aggregation {@link #getNotifiers notifiers}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.NotificationBar destroyNotifiers();

					/// <summary>
					/// Inserts a notifier into the aggregation {@link #getNotifiers notifiers}.
					/// </summary>
					/// <param name="oNotifier">The notifier to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the notifier should be inserted at; for a negative value of <code>iIndex</code>, the notifier is inserted at position 0; for a value greater than the current size of the aggregation, the notifier is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.NotificationBar insertNotifier(sap.ui.core.Element oNotifier, int iIndex);

					/// <summary>
					/// Adds some notifier to the aggregation {@link #getNotifiers notifiers}.
					/// </summary>
					/// <param name="oNotifier">The notifier to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.NotificationBar addNotifier(sap.ui.core.Element oNotifier);

					/// <summary>
					/// Removes a notifier from the aggregation {@link #getNotifiers notifiers}.
					/// </summary>
					/// <param name="vNotifier">The notifier to remove or its index or id</param>
					/// <returns>The removed notifier or <code>null</code></returns>
					public extern virtual sap.ui.core.Element removeNotifier(Union<int, string, sap.ui.core.Element> vNotifier);

					/// <summary>
					/// Checks for the provided <code>sap.ui.core.Element</code> in the aggregation {@link #getNotifiers notifiers}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oNotifier">The notifier whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfNotifier(sap.ui.core.Element oNotifier);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getNotifiers notifiers}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.core.Element[] removeAllNotifiers();

					#endregion

					#region Methods for Event display

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:display display} event of this <code>sap.ui.ux3.NotificationBar</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.NotificationBar</code> itself.
					/// 
					/// Event is fired when the bar wants to be displayed depending on given flag. This allows the application to decide what to do.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.NotificationBar</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.NotificationBar attachDisplay(object oData, sap.ui.ux3.NotificationBar.DisplayDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:display display} event of this <code>sap.ui.ux3.NotificationBar</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.NotificationBar</code> itself.
					/// 
					/// Event is fired when the bar wants to be displayed depending on given flag. This allows the application to decide what to do.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.NotificationBar attachDisplay(object oData, sap.ui.ux3.NotificationBar.DisplayDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:display display} event of this <code>sap.ui.ux3.NotificationBar</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.NotificationBar</code> itself.
					/// 
					/// Event is fired when the bar wants to be displayed depending on given flag. This allows the application to decide what to do.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.NotificationBar attachDisplay(sap.ui.ux3.NotificationBar.DisplayDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:display display} event of this <code>sap.ui.ux3.NotificationBar</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.NotificationBar</code> itself.
					/// 
					/// Event is fired when the bar wants to be displayed depending on given flag. This allows the application to decide what to do.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.NotificationBar</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.NotificationBar attachDisplay(sap.ui.ux3.NotificationBar.DisplayDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:display display} event of this <code>sap.ui.ux3.NotificationBar</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.NotificationBar detachDisplay(sap.ui.ux3.NotificationBar.DisplayDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:display display} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.NotificationBar fireDisplay(sap.ui.ux3.NotificationBar.DisplayInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:display display} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.NotificationBar fireDisplay();

					#endregion

					#region Methods for Event resize

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:resize resize} event of this <code>sap.ui.ux3.NotificationBar</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.NotificationBar</code> itself.
					/// 
					/// This event is thrown when the bar was resized (to the different valid states: Min, Max, Default, None). The event itself can be used from SAPUI5-version 1.12.2 since there was a bug in the previous versions firing this event.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.NotificationBar</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.NotificationBar attachResize(object oData, sap.ui.ux3.NotificationBar.ResizeDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:resize resize} event of this <code>sap.ui.ux3.NotificationBar</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.NotificationBar</code> itself.
					/// 
					/// This event is thrown when the bar was resized (to the different valid states: Min, Max, Default, None). The event itself can be used from SAPUI5-version 1.12.2 since there was a bug in the previous versions firing this event.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.NotificationBar attachResize(object oData, sap.ui.ux3.NotificationBar.ResizeDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:resize resize} event of this <code>sap.ui.ux3.NotificationBar</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.NotificationBar</code> itself.
					/// 
					/// This event is thrown when the bar was resized (to the different valid states: Min, Max, Default, None). The event itself can be used from SAPUI5-version 1.12.2 since there was a bug in the previous versions firing this event.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.NotificationBar attachResize(sap.ui.ux3.NotificationBar.ResizeDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:resize resize} event of this <code>sap.ui.ux3.NotificationBar</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.NotificationBar</code> itself.
					/// 
					/// This event is thrown when the bar was resized (to the different valid states: Min, Max, Default, None). The event itself can be used from SAPUI5-version 1.12.2 since there was a bug in the previous versions firing this event.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.NotificationBar</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.NotificationBar attachResize(sap.ui.ux3.NotificationBar.ResizeDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:resize resize} event of this <code>sap.ui.ux3.NotificationBar</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.NotificationBar detachResize(sap.ui.ux3.NotificationBar.ResizeDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:resize resize} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.NotificationBar fireResize(sap.ui.ux3.NotificationBar.ResizeInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:resize resize} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.NotificationBar fireResize();

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.ux3.NotificationBar with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.ux3.NotificationBar with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.ux3.NotificationBar with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.ux3.NotificationBar.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					[Name("getMetadata")]
					public extern static sap.ui.@base.Metadata getMetadataStatic();

					/// <summary>
					/// This method checks if the NotificationBar has any items (notifications or messages) to show and returns true if there are any items to show. So the application should decide if the bar should be displayed.
					/// </summary>
					/// <returns></returns>
					public extern virtual bool hasItems();

					#endregion

					#endregion

				}
			}
		}
	}
}
