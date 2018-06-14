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
			/// The NotificationListBase is the abstract base class for {@link sap.m.NotificationListItem} and {@link sap.m.NotificationListGroup}.
			/// 
			/// The NotificationList controls are designed for the SAP Fiori notification center. <h4>Overview</h4> NotificationListBase defines the general structure of a notification item. Most of the behavioral logic is defined for the single items or groups. <h4>Structure</h4> The base holds properties for the following elements: <ul> <li>Author name</li> <li>Author picture</li> <li>Time stamp</li> <li>Priority</li> <li>Title</li> </ul> Additionally, by setting these properties you can determine if buttons are shown: <ul> <li><code>showButtons</code> - action buttons visibility</li> <li><code>showCloseButton</code> - close button visibility</li> </ul>
			/// </summary>
			[External]
			[Namespace(false)]
			public partial class NotificationListBase : sap.m.ListItemBase
			{
				#region Settings

				/// <summary>
				/// Settings class to create the object
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class Settings : sap.m.ListItemBase.Settings
				{
					/// <summary>
					/// Determines the priority of the Notification.
					/// </summary>
					public Union<sap.ui.core.Priority, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> priority;

					/// <summary>
					/// Determines the title of the NotificationListBase item.
					/// </summary>
					public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> title;

					/// <summary>
					/// Determines the due date of the NotificationListItem.
					/// </summary>
					public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> datetime;

					/// <summary>
					/// Determines the action buttons visibility.
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> showButtons;

					/// <summary>
					/// Determines the visibility of the close button.
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> showCloseButton;

					/// <summary>
					/// Determines the notification group's author name.
					/// </summary>
					public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> authorName;

					/// <summary>
					/// Determines the URL of the notification group's author picture.
					/// </summary>
					public Union<sap.ui.core.URI, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> authorPicture;

					/// <summary>
					/// Action buttons.
					/// </summary>
					public Union<sap.m.Button[], string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> buttons;

					/// <summary>
					/// Fired when the close button of the notification is pressed.<br><b>Note:</b> Pressing the close button doesn't destroy the notification automatically.
					/// </summary>
					public sap.ui.@base.EventDelegate close;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new NotificationListBase.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern NotificationListBase(string sId, sap.m.NotificationListBase.Settings mSettings);

				/// <summary>
				/// Constructor for a new NotificationListBase.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern NotificationListBase(string sId);

				/// <summary>
				/// Constructor for a new NotificationListBase.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern NotificationListBase();

				/// <summary>
				/// Constructor for a new NotificationListBase.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern NotificationListBase(sap.m.NotificationListBase.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property priority

				/// <summary>
				/// Gets current value of property {@link #getPriority priority}.
				/// 
				/// Determines the priority of the Notification.
				/// 
				/// Default value is <code>None</code>.
				/// </summary>
				/// <returns>Value of property <code>priority</code></returns>
				public extern virtual sap.ui.core.Priority getPriority();

				/// <summary>
				/// Sets a new value for property {@link #getPriority priority}.
				/// 
				/// Determines the priority of the Notification.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>None</code>.
				/// </summary>
				/// <param name="sPriority">New value for property <code>priority</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.NotificationListBase setPriority(sap.ui.core.Priority sPriority);

				#endregion

				#region Methods for Property title

				/// <summary>
				/// Gets current value of property {@link #getTitle title}.
				/// 
				/// Determines the title of the NotificationListBase item.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <returns>Value of property <code>title</code></returns>
				public extern virtual string getTitle();

				/// <summary>
				/// Overwrites the setter of the title property.
				/// </summary>
				/// <param name="title">Title.</param>
				/// <returns>NotificationListBase reference for chaining.</returns>
				public extern virtual sap.m.NotificationListBase setTitle(string title);

				#endregion

				#region Methods for Property datetime

				/// <summary>
				/// Gets current value of property {@link #getDatetime datetime}.
				/// 
				/// Determines the due date of the NotificationListItem.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <returns>Value of property <code>datetime</code></returns>
				public extern virtual string getDatetime();

				/// <summary>
				/// Overwrites the setter for the datetime property.
				/// </summary>
				/// <param name="dateTime">The datetime in string format.</param>
				/// <returns>The set datetime value.</returns>
				public extern virtual string setDatetime(string dateTime);

				#endregion

				#region Methods for Property showButtons

				/// <summary>
				/// Gets current value of property {@link #getShowButtons showButtons}.
				/// 
				/// Determines the action buttons visibility.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>showButtons</code></returns>
				public extern virtual bool getShowButtons();

				/// <summary>
				/// Sets a new value for property {@link #getShowButtons showButtons}.
				/// 
				/// Determines the action buttons visibility.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bShowButtons">New value for property <code>showButtons</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.NotificationListBase setShowButtons(bool bShowButtons);

				#endregion

				#region Methods for Property showCloseButton

				/// <summary>
				/// Gets current value of property {@link #getShowCloseButton showCloseButton}.
				/// 
				/// Determines the visibility of the close button.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>showCloseButton</code></returns>
				public extern virtual bool getShowCloseButton();

				/// <summary>
				/// Sets a new value for property {@link #getShowCloseButton showCloseButton}.
				/// 
				/// Determines the visibility of the close button.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bShowCloseButton">New value for property <code>showCloseButton</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.NotificationListBase setShowCloseButton(bool bShowCloseButton);

				#endregion

				#region Methods for Property authorName

				/// <summary>
				/// Gets current value of property {@link #getAuthorName authorName}.
				/// 
				/// Determines the notification group's author name.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <returns>Value of property <code>authorName</code></returns>
				public extern virtual string getAuthorName();

				/// <summary>
				/// Overwrites the authorName property.
				/// </summary>
				/// <param name="authorName">The author name in string format.</param>
				/// <returns>The set author name.</returns>
				public extern virtual string setAuthorName(string authorName);

				#endregion

				#region Methods for Property authorPicture

				/// <summary>
				/// Gets current value of property {@link #getAuthorPicture authorPicture}.
				/// 
				/// Determines the URL of the notification group's author picture.
				/// </summary>
				/// <returns>Value of property <code>authorPicture</code></returns>
				public extern virtual sap.ui.core.URI getAuthorPicture();

				/// <summary>
				/// Sets a new value for property {@link #getAuthorPicture authorPicture}.
				/// 
				/// Determines the URL of the notification group's author picture.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sAuthorPicture">New value for property <code>authorPicture</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.NotificationListBase setAuthorPicture(sap.ui.core.URI sAuthorPicture);

				#endregion

				#region Methods for Aggregation buttons

				/// <summary>
				/// Gets content of aggregation {@link #getButtons buttons}.
				/// 
				/// Action buttons.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.Button[] getButtons();

				/// <summary>
				/// Destroys all the buttons in the aggregation {@link #getButtons buttons}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.NotificationListBase destroyButtons();

				/// <summary>
				/// Inserts a button into the aggregation {@link #getButtons buttons}.
				/// </summary>
				/// <param name="oButton">The button to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the button should be inserted at; for a negative value of <code>iIndex</code>, the button is inserted at position 0; for a value greater than the current size of the aggregation, the button is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.NotificationListBase insertButton(sap.m.Button oButton, int iIndex);

				/// <summary>
				/// Adds some button to the aggregation {@link #getButtons buttons}.
				/// </summary>
				/// <param name="oButton">The button to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.NotificationListBase addButton(sap.m.Button oButton);

				/// <summary>
				/// Removes a button from the aggregation {@link #getButtons buttons}.
				/// </summary>
				/// <param name="vButton">The button to remove or its index or id</param>
				/// <returns>The removed button or <code>null</code></returns>
				public extern virtual sap.m.Button removeButton(Union<int, string, sap.m.Button> vButton);

				/// <summary>
				/// Checks for the provided <code>sap.m.Button</code> in the aggregation {@link #getButtons buttons}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oButton">The button whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfButton(sap.m.Button oButton);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getButtons buttons}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.m.Button[] removeAllButtons();

				#endregion

				#region Methods for Aggregation _headerTitle

				#endregion

				#region Methods for Aggregation _dateTime

				#endregion

				#region Methods for Aggregation _authorName

				#endregion

				#region Methods for Aggregation _authorImage

				#endregion

				#region Methods for Aggregation _overflowToolbar

				#endregion

				#region Methods for Aggregation _closeButton

				#endregion

				#region Methods for Aggregation _collapseButton

				#endregion

				#region Methods for Event close

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:close close} event of this <code>sap.m.NotificationListBase</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.NotificationListBase</code> itself.
				/// 
				/// Fired when the close button of the notification is pressed.<br><b>Note:</b> Pressing the close button doesn't destroy the notification automatically.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.NotificationListBase</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.NotificationListBase attachClose(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:close close} event of this <code>sap.m.NotificationListBase</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.NotificationListBase</code> itself.
				/// 
				/// Fired when the close button of the notification is pressed.<br><b>Note:</b> Pressing the close button doesn't destroy the notification automatically.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.NotificationListBase attachClose(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:close close} event of this <code>sap.m.NotificationListBase</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.NotificationListBase</code> itself.
				/// 
				/// Fired when the close button of the notification is pressed.<br><b>Note:</b> Pressing the close button doesn't destroy the notification automatically.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.NotificationListBase attachClose(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:close close} event of this <code>sap.m.NotificationListBase</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.NotificationListBase</code> itself.
				/// 
				/// Fired when the close button of the notification is pressed.<br><b>Note:</b> Pressing the close button doesn't destroy the notification automatically.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.NotificationListBase</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.NotificationListBase attachClose(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:close close} event of this <code>sap.m.NotificationListBase</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.NotificationListBase detachClose(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:close close} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.NotificationListBase fireClose(object mParameters);

				/// <summary>
				/// Fires event {@link #event:close close} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.NotificationListBase fireClose();

				#endregion

				#region Other methods

				/// <summary>
				/// Returns the sap.m.Image or the sap.ui.core.Control used in the NotificationListBase's author picture.
				/// </summary>
				/// <returns>The notification author picture text.</returns>
				public extern virtual Union<sap.m.Image, sap.ui.core.Control> _getAuthorImage();

				/// <summary>
				/// Returns the sap.m.Text control used in the NotificationListBase's author name.
				/// </summary>
				/// <returns>The notification author name text.</returns>
				public extern virtual sap.m.Text _getAuthorName();

				/// <summary>
				/// Returns the sap.m.Text control used in the NotificationListBase's header title.
				/// </summary>
				/// <returns>The datetime control inside the NotificationListBase control.</returns>
				public extern virtual sap.m.Text _getDateTimeText();

				/// <summary>
				/// Returns the sap.m.Text control used in the NotificationListBase's header title.
				/// </summary>
				/// <returns>The title control inside the NotificationListBase control.</returns>
				public extern virtual sap.m.Text _getHeaderTitle();

				/// <summary>
				/// Returns the sap.m.OverflowToolbar control used in the NotificationListBase.
				/// </summary>
				/// <returns>The footer toolbar.</returns>
				public extern virtual sap.m.OverflowToolbar _getToolbar();

				/// <summary>
				/// Clones the NotificationListBase.
				/// </summary>
				/// <returns>The cloned NotificationListBase.</returns>
				public extern virtual sap.m.NotificationListBase clone();

				/// <summary>
				/// Closes the NotificationListBase.
				/// </summary>
				public extern virtual void close();

				/// <summary>
				/// Creates a new subclass of class sap.m.NotificationListBase with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.ListItemBase.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.NotificationListBase with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.ListItemBase.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.NotificationListBase with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.ListItemBase.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.NotificationListBase.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				/// <summary>
				/// Sets initial values of the control.
				/// </summary>
				public extern override void init();

				#endregion

				#endregion

			}
		}
	}
}
