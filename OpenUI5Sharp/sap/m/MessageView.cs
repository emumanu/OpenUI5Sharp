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
			/// <strong><i>Overview</i></strong> <br><br> A {@link sap.m.MessageView} is used to display a summarized list of different types of messages (errors, warnings, success and information). It provides a handy and systemized way to navigate and explore details for every message. It is meant to be embedded into container controls. If the MessageView contains only one item, which has either description, markupDescription or longTextUrl, its details page will be displayed initially. <br><br> <strong>Notes:</strong> <ul> <li> Messages can have descriptions pre-formatted with HTML markup. In this case, the <code>markupDescription</code> has to be set to <code>true</code>. </li> <li> If the message cannot be fully displayed or includes a long description, the MessageView provides navigation to the detailed description. </li> </ul> <strong><i>Structure</i></strong> <br><br> The MessageView stores all messages in an association of type {@link sap.m.MessageItem} named <code>items</code>. <br> A set of properties determines how the items are rendered: <ul> <li> counter - An integer that is used to indicate the number of errors for each type </li> <li> type - The type of message </li> <li> title/subtitle - The title and subtitle of the message</li> <li> description - The long text description of the message</li> </ul> <strong><i>Usage</i></strong> <br><br> As part of the messaging concept, MessageView provides a way to centrally manage messages and show them to the user without additional work for the developer. <br><br>
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.MessageView")]
			public partial class MessageView : sap.ui.core.Control
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
					public Union<object, string, sap.ui.@base.ManagedObject.BindPropertyInfo> asyncDescriptionHandler;

					/// <summary>
					/// Callback function for resolving a promise after a link has been asynchronously validated inside this function
					/// </summary>
					public Union<object, string, sap.ui.@base.ManagedObject.BindPropertyInfo> asyncURLHandler;

					/// <summary>
					/// Defines whether the MessageItems are grouped or not
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> groupItems;

					/// <summary>
					/// Defines whether the header of details page will be shown
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showDetailsPageHeader;

					/// <summary>
					/// A list with message items. If only one item is provided, the initial page will be the details page for the item.
					/// </summary>
					public Union<sap.m.MessageItem[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> items;

					/// <summary>
					/// A custom header button
					/// </summary>
					public Union<sap.m.Button, string, sap.ui.@base.ManagedObject.BindAggregationInfo> headerButton;

					/// <summary>
					/// This event will be fired after the popover is opened
					/// </summary>
					public sap.m.AfterOpenCloseBeforeDelegate afterOpen;

					/// <summary>
					/// This event will be fired when description is shown
					/// </summary>
					public sap.m.MessageView.ItemSelectDelegate itemSelect;

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
					/// Refers to the message item that is being presented
					/// </summary>
					public sap.m.MessageItem item;

					/// <summary>
					/// Refers to the type of messages being shown See sap.ui.core.MessageType values for types
					/// </summary>
					public sap.ui.core.MessageType messageTypeFilter;

				}

				#endregion

				#region Delegates

				public delegate void ItemSelectDelegate(sap.ui.@base.Event<sap.m.MessageView.ItemSelectInfo> oEvent, object oData);

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new MessageView
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern MessageView(string sId, sap.m.MessageView.Settings mSettings);

				/// <summary>
				/// Constructor for a new MessageView
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern MessageView(string sId);

				/// <summary>
				/// Constructor for a new MessageView
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern MessageView();

				/// <summary>
				/// Constructor for a new MessageView
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern MessageView(sap.m.MessageView.Settings mSettings);

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
				public extern virtual sap.m.MessageView setAsyncDescriptionHandler(object oAsyncDescriptionHandler);

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
				public extern virtual sap.m.MessageView setAsyncURLHandler(object oAsyncURLHandler);

				#endregion

				#region Methods for Property groupItems

				/// <summary>
				/// Gets current value of property {@link #getGroupItems groupItems}.
				/// 
				/// Defines whether the MessageItems are grouped or not
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>groupItems</code></returns>
				public extern virtual bool getGroupItems();

				/// <summary>
				/// Sets a new value for property {@link #getGroupItems groupItems}.
				/// 
				/// Defines whether the MessageItems are grouped or not
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bGroupItems">New value for property <code>groupItems</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessageView setGroupItems(bool bGroupItems);

				#endregion

				#region Methods for Property showDetailsPageHeader

				/// <summary>
				/// Gets current value of property {@link #getShowDetailsPageHeader showDetailsPageHeader}.
				/// 
				/// Defines whether the header of details page will be shown
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>showDetailsPageHeader</code></returns>
				public extern virtual bool getShowDetailsPageHeader();

				/// <summary>
				/// Sets a new value for property {@link #getShowDetailsPageHeader showDetailsPageHeader}.
				/// 
				/// Defines whether the header of details page will be shown
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bShowDetailsPageHeader">New value for property <code>showDetailsPageHeader</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessageView setShowDetailsPageHeader(bool bShowDetailsPageHeader);

				#endregion

				#region Methods for Aggregation items

				/// <summary>
				/// Gets content of aggregation {@link #getItems items}.
				/// 
				/// A list with message items. If only one item is provided, the initial page will be the details page for the item.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.MessageItem[] getItems();

				/// <summary>
				/// Destroys all the items in the aggregation {@link #getItems items}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessageView destroyItems();

				/// <summary>
				/// Inserts a item into the aggregation {@link #getItems items}.
				/// </summary>
				/// <param name="oItem">The item to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the item should be inserted at; for a negative value of <code>iIndex</code>, the item is inserted at position 0; for a value greater than the current size of the aggregation, the item is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessageView insertItem(sap.m.MessageItem oItem, int iIndex);

				/// <summary>
				/// Adds some item to the aggregation {@link #getItems items}.
				/// </summary>
				/// <param name="oItem">The item to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessageView addItem(sap.m.MessageItem oItem);

				/// <summary>
				/// Removes a item from the aggregation {@link #getItems items}.
				/// </summary>
				/// <param name="vItem">The item to remove or its index or id</param>
				/// <returns>The removed item or <code>null</code></returns>
				public extern virtual sap.m.MessageItem removeItem(Union<int, string, sap.m.MessageItem> vItem);

				/// <summary>
				/// Checks for the provided <code>sap.m.MessageItem</code> in the aggregation {@link #getItems items}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oItem">The item whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfItem(sap.m.MessageItem oItem);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getItems items}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.m.MessageItem[] removeAllItems();

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
				public extern virtual sap.m.MessageView destroyHeaderButton();

				/// <summary>
				/// Sets the aggregated {@link #getHeaderButton headerButton}.
				/// </summary>
				/// <param name="oHeaderButton">The headerButton to set</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessageView setHeaderButton(sap.m.Button oHeaderButton);

				#endregion

				#region Methods for Aggregation _navContainer

				#endregion

				#region Methods for Event afterOpen

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterOpen afterOpen} event of this <code>sap.m.MessageView</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MessageView</code> itself.
				/// 
				/// This event will be fired after the popover is opened
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.MessageView</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessageView attachAfterOpen(object oData, sap.m.AfterOpenCloseBeforeDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterOpen afterOpen} event of this <code>sap.m.MessageView</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MessageView</code> itself.
				/// 
				/// This event will be fired after the popover is opened
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessageView attachAfterOpen(object oData, sap.m.AfterOpenCloseBeforeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterOpen afterOpen} event of this <code>sap.m.MessageView</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MessageView</code> itself.
				/// 
				/// This event will be fired after the popover is opened
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessageView attachAfterOpen(sap.m.AfterOpenCloseBeforeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterOpen afterOpen} event of this <code>sap.m.MessageView</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MessageView</code> itself.
				/// 
				/// This event will be fired after the popover is opened
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.MessageView</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessageView attachAfterOpen(sap.m.AfterOpenCloseBeforeDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:afterOpen afterOpen} event of this <code>sap.m.MessageView</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessageView detachAfterOpen(sap.m.AfterOpenCloseBeforeDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:afterOpen afterOpen} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessageView fireAfterOpen(sap.m.AfterOpenCloseBeforeInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:afterOpen afterOpen} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessageView fireAfterOpen();

				#endregion

				#region Methods for Event itemSelect

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:itemSelect itemSelect} event of this <code>sap.m.MessageView</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MessageView</code> itself.
				/// 
				/// This event will be fired when description is shown
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.MessageView</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessageView attachItemSelect(object oData, sap.m.MessageView.ItemSelectDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:itemSelect itemSelect} event of this <code>sap.m.MessageView</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MessageView</code> itself.
				/// 
				/// This event will be fired when description is shown
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessageView attachItemSelect(object oData, sap.m.MessageView.ItemSelectDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:itemSelect itemSelect} event of this <code>sap.m.MessageView</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MessageView</code> itself.
				/// 
				/// This event will be fired when description is shown
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessageView attachItemSelect(sap.m.MessageView.ItemSelectDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:itemSelect itemSelect} event of this <code>sap.m.MessageView</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MessageView</code> itself.
				/// 
				/// This event will be fired when description is shown
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.MessageView</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessageView attachItemSelect(sap.m.MessageView.ItemSelectDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:itemSelect itemSelect} event of this <code>sap.m.MessageView</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessageView detachItemSelect(sap.m.MessageView.ItemSelectDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:itemSelect itemSelect} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessageView fireItemSelect(sap.m.MessageView.ItemSelectInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:itemSelect itemSelect} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessageView fireItemSelect();

				#endregion

				#region Methods for Event listSelect

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:listSelect listSelect} event of this <code>sap.m.MessageView</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MessageView</code> itself.
				/// 
				/// This event will be fired when one of the lists is shown when (not) filtered by type
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.MessageView</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessageView attachListSelect(object oData, sap.m.MessageListSelectDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:listSelect listSelect} event of this <code>sap.m.MessageView</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MessageView</code> itself.
				/// 
				/// This event will be fired when one of the lists is shown when (not) filtered by type
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessageView attachListSelect(object oData, sap.m.MessageListSelectDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:listSelect listSelect} event of this <code>sap.m.MessageView</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MessageView</code> itself.
				/// 
				/// This event will be fired when one of the lists is shown when (not) filtered by type
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessageView attachListSelect(sap.m.MessageListSelectDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:listSelect listSelect} event of this <code>sap.m.MessageView</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MessageView</code> itself.
				/// 
				/// This event will be fired when one of the lists is shown when (not) filtered by type
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.MessageView</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessageView attachListSelect(sap.m.MessageListSelectDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:listSelect listSelect} event of this <code>sap.m.MessageView</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessageView detachListSelect(sap.m.MessageListSelectDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:listSelect listSelect} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessageView fireListSelect(sap.m.MessageListSelectInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:listSelect listSelect} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessageView fireListSelect();

				#endregion

				#region Methods for Event longtextLoaded

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:longtextLoaded longtextLoaded} event of this <code>sap.m.MessageView</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MessageView</code> itself.
				/// 
				/// This event will be fired when the long text description data from a remote URL is loaded
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.MessageView</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessageView attachLongtextLoaded(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:longtextLoaded longtextLoaded} event of this <code>sap.m.MessageView</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MessageView</code> itself.
				/// 
				/// This event will be fired when the long text description data from a remote URL is loaded
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessageView attachLongtextLoaded(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:longtextLoaded longtextLoaded} event of this <code>sap.m.MessageView</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MessageView</code> itself.
				/// 
				/// This event will be fired when the long text description data from a remote URL is loaded
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessageView attachLongtextLoaded(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:longtextLoaded longtextLoaded} event of this <code>sap.m.MessageView</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MessageView</code> itself.
				/// 
				/// This event will be fired when the long text description data from a remote URL is loaded
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.MessageView</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessageView attachLongtextLoaded(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:longtextLoaded longtextLoaded} event of this <code>sap.m.MessageView</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessageView detachLongtextLoaded(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:longtextLoaded longtextLoaded} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessageView fireLongtextLoaded(object mParameters);

				/// <summary>
				/// Fires event {@link #event:longtextLoaded longtextLoaded} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessageView fireLongtextLoaded();

				#endregion

				#region Methods for Event urlValidated

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:urlValidated urlValidated} event of this <code>sap.m.MessageView</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MessageView</code> itself.
				/// 
				/// This event will be fired when a validation of a URL from long text description is ready
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.MessageView</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessageView attachUrlValidated(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:urlValidated urlValidated} event of this <code>sap.m.MessageView</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MessageView</code> itself.
				/// 
				/// This event will be fired when a validation of a URL from long text description is ready
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessageView attachUrlValidated(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:urlValidated urlValidated} event of this <code>sap.m.MessageView</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MessageView</code> itself.
				/// 
				/// This event will be fired when a validation of a URL from long text description is ready
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessageView attachUrlValidated(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:urlValidated urlValidated} event of this <code>sap.m.MessageView</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MessageView</code> itself.
				/// 
				/// This event will be fired when a validation of a URL from long text description is ready
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.MessageView</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessageView attachUrlValidated(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:urlValidated urlValidated} event of this <code>sap.m.MessageView</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessageView detachUrlValidated(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:urlValidated urlValidated} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessageView fireUrlValidated(object mParameters);

				/// <summary>
				/// Fires event {@link #event:urlValidated urlValidated} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessageView fireUrlValidated();

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.MessageView with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.MessageView with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.MessageView with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.MessageView.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				/// <summary>
				/// Navigates back to the list page
				/// </summary>
				public extern virtual void navigateBack();

				/// <summary>
				/// Setter for default description and URL validation callbacks across all instances of MessageView
				/// </summary>
				/// <param name="mDefaultHandlers">An object setting default callbacks</param>
				public extern static void setDefaultHandlers(object mDefaultHandlers);

				#endregion

				#endregion

			}
		}
	}
}
