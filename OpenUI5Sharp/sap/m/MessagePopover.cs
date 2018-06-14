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
			/// A summarized list of different types of messages. <h3>Overview</h3> A message popover is used to display a summarized list of different types of messages (errors, warnings, success and information). It provides a handy and systemized way to navigate and explore details for every message. <h4>Notes:</h4> <ul> <li> Messages can have descriptions pre-formatted with HTML markup. In this case, the <code>markupDescription</code> has to be set to <code>true</code>.</li> <li> If the message cannot be fully displayed or includes a long description, the message popover provides navigation to the detailed description.</li> </ul> <h3>Structure</h3> The message popover stores all messages in an aggregation of type {@link sap.m.MessageItem} named <code>items</code>.
			/// 
			/// A set of properties determines how the items are rendered: <ul> <li> counter - An integer that is used to indicate the number of errors for each type </li> <li> type - The type of message </li> <li> title/subtitle - The title and subtitle of the message</li> <li> description - The long text description of the message</li> </ul> <h3>Usage</h3> With the message concept, MessagePopover provides a way to centrally manage messages and show them to the user without additional work for the developer. The message popover is triggered from a messaging button in the footer toolbar. If an error has occurred at any validation point, the total number of messages should be incremented, but the user's work shouldn't be interrupted. <h3>Responsive Behavior</h3> On mobile phones, the message popover is automatically shown in full screen mode.<br> On desktop and tablet, the message popover opens in a popover.<br> On desktop the opened popover is resizable if it is placed in a {@link sap.m.Toolbar}, {@link sap.m.Bar} or used in {@link sap.f.semantic.SemanticPage}
			/// </summary>
			[External]
			[Namespace(false)]
			public partial class MessagePopover : sap.ui.core.Control
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
					/// Callback function for resolving a promise after description has been asynchronously loaded inside this function
					/// </summary>
					public Union<object, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> asyncDescriptionHandler;

					/// <summary>
					/// Callback function for resolving a promise after a link has been asynchronously validated inside this function
					/// </summary>
					public Union<object, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> asyncURLHandler;

					/// <summary>
					/// Determines the position, where the control will appear on the screen. Possible values are: sap.m.VerticalPlacementType.Top, sap.m.VerticalPlacementType.Bottom and sap.m.VerticalPlacementType.Vertical. The default value is sap.m.VerticalPlacementType.Vertical. Setting this property while the control is open, will not cause any re-rendering and changing of the position. Changes will only be applied with the next interaction.
					/// </summary>
					public Union<sap.m.VerticalPlacementType, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> placement;

					/// <summary>
					/// Sets the initial state of the control - expanded or collapsed. By default the control opens as expanded.
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> initiallyExpanded;

					/// <summary>
					/// A list with message items
					/// </summary>
					public Union<sap.m.MessageItem[], string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> items;

					/// <summary>
					/// A custom header button
					/// </summary>
					public Union<sap.m.Button, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> headerButton;

					/// <summary>
					/// This event will be fired after the popover is opened
					/// </summary>
					public sap.m.AfterOpenCloseBeforeDelegate afterOpen;

					/// <summary>
					/// This event will be fired after the popover is closed
					/// </summary>
					public sap.m.AfterOpenCloseBeforeDelegate afterClose;

					/// <summary>
					/// This event will be fired before the popover is opened
					/// </summary>
					public sap.m.AfterOpenCloseBeforeDelegate beforeOpen;

					/// <summary>
					/// This event will be fired before the popover is closed
					/// </summary>
					public sap.m.AfterOpenCloseBeforeDelegate beforeClose;

					/// <summary>
					/// This event will be fired when description is shown
					/// </summary>
					public sap.m.MessagePopover.ItemSelectDelegate itemSelect;

					/// <summary>
					/// This event will be fired when one of the lists is shown when (not) filtered by type
					/// </summary>
					public sap.m.MessageListSelectDelegate listSelect;

					/// <summary>
					/// This event will be fired when the long text description data from a remote URL is loaded
					/// </summary>
					public sap.ui.@base.EventDelegate longtextLoaded;

					/// <summary>
					/// This event will be fired when a validation of a URL from long text description is ready
					/// </summary>
					public sap.ui.@base.EventDelegate urlValidated;

				}

				#endregion

				#region Typed Parameters

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class ItemSelectInfo
				{
					/// <summary>
					/// Refers to the message popover item that is being presented
					/// </summary>
					public sap.m.MessagePopoverItem item;

					/// <summary>
					/// Refers to the type of messages being shown See sap.ui.core.MessageType values for types
					/// </summary>
					public sap.ui.core.MessageType messageTypeFilter;

				}

				#endregion

				#region Delegates

				public delegate void ItemSelectDelegate(sap.ui.@base.Event<sap.m.MessagePopover.ItemSelectInfo> oEvent, object oData);

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new MessagePopover.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern MessagePopover(string sId, sap.m.MessagePopover.Settings mSettings);

				/// <summary>
				/// Constructor for a new MessagePopover.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern MessagePopover(string sId);

				/// <summary>
				/// Constructor for a new MessagePopover.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern MessagePopover();

				/// <summary>
				/// Constructor for a new MessagePopover.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern MessagePopover(sap.m.MessagePopover.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property asyncDescriptionHandler

				/// <summary>
				/// Gets current value of property {@link #getAsyncDescriptionHandler asyncDescriptionHandler}.
				/// 
				/// Callback function for resolving a promise after description has been asynchronously loaded inside this function
				/// </summary>
				/// <returns>Value of property <code>asyncDescriptionHandler</code></returns>
				public extern virtual object getAsyncDescriptionHandler();

				/// <summary>
				/// Sets a new value for property {@link #getAsyncDescriptionHandler asyncDescriptionHandler}.
				/// 
				/// Callback function for resolving a promise after description has been asynchronously loaded inside this function
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="oAsyncDescriptionHandler">New value for property <code>asyncDescriptionHandler</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePopover setAsyncDescriptionHandler(object oAsyncDescriptionHandler);

				#endregion

				#region Methods for Property asyncURLHandler

				/// <summary>
				/// Gets current value of property {@link #getAsyncURLHandler asyncURLHandler}.
				/// 
				/// Callback function for resolving a promise after a link has been asynchronously validated inside this function
				/// </summary>
				/// <returns>Value of property <code>asyncURLHandler</code></returns>
				public extern virtual object getAsyncURLHandler();

				/// <summary>
				/// Sets a new value for property {@link #getAsyncURLHandler asyncURLHandler}.
				/// 
				/// Callback function for resolving a promise after a link has been asynchronously validated inside this function
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="oAsyncURLHandler">New value for property <code>asyncURLHandler</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePopover setAsyncURLHandler(object oAsyncURLHandler);

				#endregion

				#region Methods for Property placement

				/// <summary>
				/// Gets current value of property {@link #getPlacement placement}.
				/// 
				/// Determines the position, where the control will appear on the screen. Possible values are: sap.m.VerticalPlacementType.Top, sap.m.VerticalPlacementType.Bottom and sap.m.VerticalPlacementType.Vertical. The default value is sap.m.VerticalPlacementType.Vertical. Setting this property while the control is open, will not cause any re-rendering and changing of the position. Changes will only be applied with the next interaction.
				/// 
				/// Default value is <code>Vertical</code>.
				/// </summary>
				/// <returns>Value of property <code>placement</code></returns>
				public extern virtual sap.m.VerticalPlacementType getPlacement();

				/// <summary>
				/// The method sets the placement position of the MessagePopover. Only accepted Values are: sap.m.PlacementType.Top, sap.m.PlacementType.Bottom and sap.m.PlacementType.Vertical
				/// </summary>
				/// <param name="sPlacement">Placement type</param>
				/// <returns>Reference to the 'this' for chaining purposes</returns>
				public extern virtual sap.m.MessagePopover setPlacement(sap.m.PlacementType sPlacement);

				#endregion

				#region Methods for Property initiallyExpanded

				/// <summary>
				/// Gets current value of property {@link #getInitiallyExpanded initiallyExpanded}.
				/// 
				/// Sets the initial state of the control - expanded or collapsed. By default the control opens as expanded.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>initiallyExpanded</code></returns>
				public extern virtual bool getInitiallyExpanded();

				/// <summary>
				/// Sets a new value for property {@link #getInitiallyExpanded initiallyExpanded}.
				/// 
				/// Sets the initial state of the control - expanded or collapsed. By default the control opens as expanded.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bInitiallyExpanded">New value for property <code>initiallyExpanded</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePopover setInitiallyExpanded(bool bInitiallyExpanded);

				#endregion

				#region Methods for Aggregation items

				/// <summary>
				/// Gets content of aggregation {@link #getItems items}.
				/// 
				/// A list with message items
				/// </summary>
				/// <returns></returns>
				public extern virtual Union<sap.m.MessageItem, sap.m.MessagePopoverItem>[] getItems();

				/// <summary>
				/// Destroys all the items in the aggregation {@link #getItems items}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePopover destroyItems();

				/// <summary>
				/// Inserts a item into the aggregation {@link #getItems items}.
				/// </summary>
				/// <param name="vItem">The item to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the item should be inserted at; for a negative value of <code>iIndex</code>, the item is inserted at position 0; for a value greater than the current size of the aggregation, the item is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePopover insertItem(Union<sap.m.MessageItem, sap.m.MessagePopoverItem> vItem, int iIndex);

				/// <summary>
				/// Adds some item to the aggregation {@link #getItems items}.
				/// </summary>
				/// <param name="vItem">The item to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePopover addItem(Union<sap.m.MessageItem, sap.m.MessagePopoverItem> vItem);

				/// <summary>
				/// Removes a item from the aggregation {@link #getItems items}.
				/// </summary>
				/// <param name="vItem">The item to remove or its index or id</param>
				/// <returns>The removed item or <code>null</code></returns>
				public extern virtual Union<sap.m.MessageItem, sap.m.MessagePopoverItem> removeItem(Union<int, string, sap.m.MessageItem, sap.m.MessagePopoverItem> vItem);

				/// <summary>
				/// Checks for the provided <code>sap.m.MessageItem</code> in the aggregation {@link #getItems items}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="vItem">The item whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfItem(Union<sap.m.MessageItem, sap.m.MessagePopoverItem> vItem);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getItems items}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual Union<sap.m.MessageItem, sap.m.MessagePopoverItem>[] removeAllItems();

				#endregion

				#region Methods for Aggregation headerButton

				/// <summary>
				/// Gets content of aggregation {@link #getHeaderButton headerButton}.
				/// 
				/// A custom header button
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.Button getHeaderButton();

				/// <summary>
				/// Destroys the headerButton in the aggregation {@link #getHeaderButton headerButton}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePopover destroyHeaderButton();

				/// <summary>
				/// Sets the aggregated {@link #getHeaderButton headerButton}.
				/// </summary>
				/// <param name="oHeaderButton">The headerButton to set</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePopover setHeaderButton(sap.m.Button oHeaderButton);

				#endregion

				#region Methods for Event afterOpen

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterOpen afterOpen} event of this <code>sap.m.MessagePopover</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MessagePopover</code> itself.
				/// 
				/// This event will be fired after the popover is opened
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.MessagePopover</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePopover attachAfterOpen(object oData, sap.m.AfterOpenCloseBeforeDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterOpen afterOpen} event of this <code>sap.m.MessagePopover</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MessagePopover</code> itself.
				/// 
				/// This event will be fired after the popover is opened
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePopover attachAfterOpen(object oData, sap.m.AfterOpenCloseBeforeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterOpen afterOpen} event of this <code>sap.m.MessagePopover</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MessagePopover</code> itself.
				/// 
				/// This event will be fired after the popover is opened
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePopover attachAfterOpen(sap.m.AfterOpenCloseBeforeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterOpen afterOpen} event of this <code>sap.m.MessagePopover</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MessagePopover</code> itself.
				/// 
				/// This event will be fired after the popover is opened
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.MessagePopover</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePopover attachAfterOpen(sap.m.AfterOpenCloseBeforeDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:afterOpen afterOpen} event of this <code>sap.m.MessagePopover</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePopover detachAfterOpen(sap.m.AfterOpenCloseBeforeDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:afterOpen afterOpen} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePopover fireAfterOpen(sap.m.AfterOpenCloseBeforeInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:afterOpen afterOpen} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePopover fireAfterOpen();

				#endregion

				#region Methods for Event afterClose

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterClose afterClose} event of this <code>sap.m.MessagePopover</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MessagePopover</code> itself.
				/// 
				/// This event will be fired after the popover is closed
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.MessagePopover</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePopover attachAfterClose(object oData, sap.m.AfterOpenCloseBeforeDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterClose afterClose} event of this <code>sap.m.MessagePopover</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MessagePopover</code> itself.
				/// 
				/// This event will be fired after the popover is closed
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePopover attachAfterClose(object oData, sap.m.AfterOpenCloseBeforeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterClose afterClose} event of this <code>sap.m.MessagePopover</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MessagePopover</code> itself.
				/// 
				/// This event will be fired after the popover is closed
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePopover attachAfterClose(sap.m.AfterOpenCloseBeforeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterClose afterClose} event of this <code>sap.m.MessagePopover</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MessagePopover</code> itself.
				/// 
				/// This event will be fired after the popover is closed
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.MessagePopover</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePopover attachAfterClose(sap.m.AfterOpenCloseBeforeDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:afterClose afterClose} event of this <code>sap.m.MessagePopover</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePopover detachAfterClose(sap.m.AfterOpenCloseBeforeDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:afterClose afterClose} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePopover fireAfterClose(sap.m.AfterOpenCloseBeforeInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:afterClose afterClose} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePopover fireAfterClose();

				#endregion

				#region Methods for Event beforeOpen

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeOpen beforeOpen} event of this <code>sap.m.MessagePopover</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MessagePopover</code> itself.
				/// 
				/// This event will be fired before the popover is opened
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.MessagePopover</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePopover attachBeforeOpen(object oData, sap.m.AfterOpenCloseBeforeDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeOpen beforeOpen} event of this <code>sap.m.MessagePopover</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MessagePopover</code> itself.
				/// 
				/// This event will be fired before the popover is opened
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePopover attachBeforeOpen(object oData, sap.m.AfterOpenCloseBeforeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeOpen beforeOpen} event of this <code>sap.m.MessagePopover</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MessagePopover</code> itself.
				/// 
				/// This event will be fired before the popover is opened
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePopover attachBeforeOpen(sap.m.AfterOpenCloseBeforeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeOpen beforeOpen} event of this <code>sap.m.MessagePopover</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MessagePopover</code> itself.
				/// 
				/// This event will be fired before the popover is opened
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.MessagePopover</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePopover attachBeforeOpen(sap.m.AfterOpenCloseBeforeDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:beforeOpen beforeOpen} event of this <code>sap.m.MessagePopover</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePopover detachBeforeOpen(sap.m.AfterOpenCloseBeforeDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:beforeOpen beforeOpen} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePopover fireBeforeOpen(sap.m.AfterOpenCloseBeforeInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:beforeOpen beforeOpen} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePopover fireBeforeOpen();

				#endregion

				#region Methods for Event beforeClose

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeClose beforeClose} event of this <code>sap.m.MessagePopover</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MessagePopover</code> itself.
				/// 
				/// This event will be fired before the popover is closed
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.MessagePopover</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePopover attachBeforeClose(object oData, sap.m.AfterOpenCloseBeforeDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeClose beforeClose} event of this <code>sap.m.MessagePopover</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MessagePopover</code> itself.
				/// 
				/// This event will be fired before the popover is closed
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePopover attachBeforeClose(object oData, sap.m.AfterOpenCloseBeforeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeClose beforeClose} event of this <code>sap.m.MessagePopover</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MessagePopover</code> itself.
				/// 
				/// This event will be fired before the popover is closed
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePopover attachBeforeClose(sap.m.AfterOpenCloseBeforeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeClose beforeClose} event of this <code>sap.m.MessagePopover</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MessagePopover</code> itself.
				/// 
				/// This event will be fired before the popover is closed
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.MessagePopover</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePopover attachBeforeClose(sap.m.AfterOpenCloseBeforeDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:beforeClose beforeClose} event of this <code>sap.m.MessagePopover</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePopover detachBeforeClose(sap.m.AfterOpenCloseBeforeDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:beforeClose beforeClose} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePopover fireBeforeClose(sap.m.AfterOpenCloseBeforeInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:beforeClose beforeClose} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePopover fireBeforeClose();

				#endregion

				#region Methods for Event itemSelect

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:itemSelect itemSelect} event of this <code>sap.m.MessagePopover</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MessagePopover</code> itself.
				/// 
				/// This event will be fired when description is shown
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.MessagePopover</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePopover attachItemSelect(object oData, sap.m.MessagePopover.ItemSelectDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:itemSelect itemSelect} event of this <code>sap.m.MessagePopover</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MessagePopover</code> itself.
				/// 
				/// This event will be fired when description is shown
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePopover attachItemSelect(object oData, sap.m.MessagePopover.ItemSelectDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:itemSelect itemSelect} event of this <code>sap.m.MessagePopover</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MessagePopover</code> itself.
				/// 
				/// This event will be fired when description is shown
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePopover attachItemSelect(sap.m.MessagePopover.ItemSelectDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:itemSelect itemSelect} event of this <code>sap.m.MessagePopover</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MessagePopover</code> itself.
				/// 
				/// This event will be fired when description is shown
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.MessagePopover</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePopover attachItemSelect(sap.m.MessagePopover.ItemSelectDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:itemSelect itemSelect} event of this <code>sap.m.MessagePopover</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePopover detachItemSelect(sap.m.MessagePopover.ItemSelectDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:itemSelect itemSelect} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePopover fireItemSelect(sap.m.MessagePopover.ItemSelectInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:itemSelect itemSelect} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePopover fireItemSelect();

				#endregion

				#region Methods for Event listSelect

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:listSelect listSelect} event of this <code>sap.m.MessagePopover</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MessagePopover</code> itself.
				/// 
				/// This event will be fired when one of the lists is shown when (not) filtered by type
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.MessagePopover</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePopover attachListSelect(object oData, sap.m.MessageListSelectDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:listSelect listSelect} event of this <code>sap.m.MessagePopover</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MessagePopover</code> itself.
				/// 
				/// This event will be fired when one of the lists is shown when (not) filtered by type
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePopover attachListSelect(object oData, sap.m.MessageListSelectDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:listSelect listSelect} event of this <code>sap.m.MessagePopover</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MessagePopover</code> itself.
				/// 
				/// This event will be fired when one of the lists is shown when (not) filtered by type
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePopover attachListSelect(sap.m.MessageListSelectDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:listSelect listSelect} event of this <code>sap.m.MessagePopover</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MessagePopover</code> itself.
				/// 
				/// This event will be fired when one of the lists is shown when (not) filtered by type
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.MessagePopover</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePopover attachListSelect(sap.m.MessageListSelectDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:listSelect listSelect} event of this <code>sap.m.MessagePopover</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePopover detachListSelect(sap.m.MessageListSelectDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:listSelect listSelect} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePopover fireListSelect(sap.m.MessageListSelectInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:listSelect listSelect} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePopover fireListSelect();

				#endregion

				#region Methods for Event longtextLoaded

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:longtextLoaded longtextLoaded} event of this <code>sap.m.MessagePopover</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MessagePopover</code> itself.
				/// 
				/// This event will be fired when the long text description data from a remote URL is loaded
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.MessagePopover</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePopover attachLongtextLoaded(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:longtextLoaded longtextLoaded} event of this <code>sap.m.MessagePopover</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MessagePopover</code> itself.
				/// 
				/// This event will be fired when the long text description data from a remote URL is loaded
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePopover attachLongtextLoaded(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:longtextLoaded longtextLoaded} event of this <code>sap.m.MessagePopover</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MessagePopover</code> itself.
				/// 
				/// This event will be fired when the long text description data from a remote URL is loaded
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePopover attachLongtextLoaded(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:longtextLoaded longtextLoaded} event of this <code>sap.m.MessagePopover</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MessagePopover</code> itself.
				/// 
				/// This event will be fired when the long text description data from a remote URL is loaded
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.MessagePopover</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePopover attachLongtextLoaded(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:longtextLoaded longtextLoaded} event of this <code>sap.m.MessagePopover</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePopover detachLongtextLoaded(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:longtextLoaded longtextLoaded} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePopover fireLongtextLoaded(object mParameters);

				/// <summary>
				/// Fires event {@link #event:longtextLoaded longtextLoaded} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePopover fireLongtextLoaded();

				#endregion

				#region Methods for Event urlValidated

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:urlValidated urlValidated} event of this <code>sap.m.MessagePopover</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MessagePopover</code> itself.
				/// 
				/// This event will be fired when a validation of a URL from long text description is ready
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.MessagePopover</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePopover attachUrlValidated(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:urlValidated urlValidated} event of this <code>sap.m.MessagePopover</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MessagePopover</code> itself.
				/// 
				/// This event will be fired when a validation of a URL from long text description is ready
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePopover attachUrlValidated(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:urlValidated urlValidated} event of this <code>sap.m.MessagePopover</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MessagePopover</code> itself.
				/// 
				/// This event will be fired when a validation of a URL from long text description is ready
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePopover attachUrlValidated(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:urlValidated urlValidated} event of this <code>sap.m.MessagePopover</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MessagePopover</code> itself.
				/// 
				/// This event will be fired when a validation of a URL from long text description is ready
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.MessagePopover</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePopover attachUrlValidated(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:urlValidated urlValidated} event of this <code>sap.m.MessagePopover</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePopover detachUrlValidated(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:urlValidated urlValidated} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePopover fireUrlValidated(object mParameters);

				/// <summary>
				/// Fires event {@link #event:urlValidated urlValidated} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessagePopover fireUrlValidated();

				#endregion

				#region Other methods

				/// <summary>
				/// Closes the MessagePopover
				/// </summary>
				/// <returns>Reference to the 'this' for chaining purposes</returns>
				public extern virtual sap.m.MessagePopover close();

				/// <summary>
				/// Creates a new subclass of class sap.m.MessagePopover with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.MessagePopover with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.MessagePopover with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.MessagePopover.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				/// <summary>
				/// The method checks if the MessagePopover is open. It returns true when the MessagePopover is currently open (this includes opening and closing animations), otherwise it returns false
				/// </summary>
				/// <returns>Whether the MessagePopover is open</returns>
				public extern virtual bool isOpen();

				/// <summary>
				/// Opens the MessagePopover
				/// </summary>
				/// <param name="oControl">Control which opens the MessagePopover</param>
				/// <returns>Reference to the 'this' for chaining purposes</returns>
				public extern virtual sap.m.MessagePopover openBy(sap.ui.core.Control oControl);

				/// <summary>
				/// Setter for default description and URL validation callbacks across all instances of MessagePopover
				/// </summary>
				/// <param name="mDefaultHandlers">An object setting default callbacks</param>
				public extern static void setDefaultHandlers(object mDefaultHandlers);

				/// <summary>
				/// This method toggles between open and closed state of the MessagePopover instance. oControl parameter is mandatory in the same way as in 'openBy' method
				/// </summary>
				/// <param name="oControl">Control which opens the MessagePopover</param>
				/// <returns>Reference to the 'this' for chaining purposes</returns>
				public extern virtual sap.m.MessagePopover toggle(sap.ui.core.Control oControl);

				#endregion

				#endregion

			}
		}
	}
}
