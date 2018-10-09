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
				/// This element can be docked to a notification bar to show notification items
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.ux3.Notifier")]
				[Obsolete("Deprecated since 1.38.")]
				public partial class Notifier : sap.ui.core.Element
				{
					#region Settings

					/// <summary>
					/// Settings class to create the object
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class Settings : sap.ui.core.Element.Settings
					{
						/// <summary>
						/// Icon of the control that should be displayed within the corresponding bar
						/// </summary>
						public Union<sap.ui.core.URI, string, sap.ui.@base.ManagedObject.BindPropertyInfo> icon;

						/// <summary>
						/// Defines the title that should be displayed within the opening popup
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> title;

						/// <summary>
						/// Messages of this notifier.
						/// </summary>
						public Union<sap.ui.core.Message[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> messages;

						/// <summary>
						/// Event is fired when a message of the notifiers was selected.
						/// </summary>
						public sap.ui.ux3.Notifier.MessageSelectedDelegate messageSelected;

					}

					#endregion

					#region Typed Parameters

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class MessageSelectedInfo
					{
						/// <summary>
						/// The message that was selected
						/// </summary>
						public sap.ui.core.Message message;

						/// <summary>
						/// The notifier that contains the selected message
						/// </summary>
						public sap.ui.ux3.Notifier notifier;

					}

					#endregion

					#region Delegates

					public delegate void MessageSelectedDelegate(sap.ui.@base.Event<sap.ui.ux3.Notifier.MessageSelectedInfo> oEvent, object oData);

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new Notifier.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern Notifier(string sId, sap.ui.ux3.Notifier.Settings mSettings);

					/// <summary>
					/// Constructor for a new Notifier.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern Notifier(string sId);

					/// <summary>
					/// Constructor for a new Notifier.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern Notifier();

					/// <summary>
					/// Constructor for a new Notifier.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern Notifier(sap.ui.ux3.Notifier.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property icon

					/// <summary>
					/// Gets current value of property {@link #getIcon icon}.
					/// 
					/// Icon of the control that should be displayed within the corresponding bar
					/// </summary>
					/// <returns>Value of property <code>icon</code></returns>
					public extern virtual sap.ui.core.URI getIcon();

					/// <summary>
					/// Sets a new value for property {@link #getIcon icon}.
					/// 
					/// Icon of the control that should be displayed within the corresponding bar
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sIcon">New value for property <code>icon</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Notifier setIcon(sap.ui.core.URI sIcon);

					#endregion

					#region Methods for Property title

					/// <summary>
					/// Gets current value of property {@link #getTitle title}.
					/// 
					/// Defines the title that should be displayed within the opening popup
					/// </summary>
					/// <returns>Value of property <code>title</code></returns>
					public extern virtual string getTitle();

					/// <summary>
					/// Sets a new value for property {@link #getTitle title}.
					/// 
					/// Defines the title that should be displayed within the opening popup
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sTitle">New value for property <code>title</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Notifier setTitle(string sTitle);

					#endregion

					#region Methods for Aggregation messages

					/// <summary>
					/// Gets content of aggregation {@link #getMessages messages}.
					/// 
					/// Messages of this notifier.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.Message[] getMessages();

					/// <summary>
					/// Destroys all the messages in the aggregation {@link #getMessages messages}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Notifier destroyMessages();

					/// <summary>
					/// Inserts a message into the aggregation {@link #getMessages messages}.
					/// </summary>
					/// <param name="oMessage">The message to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the message should be inserted at; for a negative value of <code>iIndex</code>, the message is inserted at position 0; for a value greater than the current size of the aggregation, the message is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Notifier insertMessage(sap.ui.core.Message oMessage, int iIndex);

					/// <summary>
					/// Adds some message to the aggregation {@link #getMessages messages}.
					/// </summary>
					/// <param name="oMessage">The message to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Notifier addMessage(sap.ui.core.Message oMessage);

					/// <summary>
					/// Removes a message from the aggregation {@link #getMessages messages}.
					/// </summary>
					/// <param name="vMessage">The message to remove or its index or id</param>
					/// <returns>The removed message or <code>null</code></returns>
					public extern virtual sap.ui.core.Message removeMessage(Union<int, string, sap.ui.core.Message> vMessage);

					/// <summary>
					/// Checks for the provided <code>sap.ui.core.Message</code> in the aggregation {@link #getMessages messages}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oMessage">The message whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfMessage(sap.ui.core.Message oMessage);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getMessages messages}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.core.Message[] removeAllMessages();

					#endregion

					#region Methods for Aggregation views

					#endregion

					#region Methods for Event messageSelected

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:messageSelected messageSelected} event of this <code>sap.ui.ux3.Notifier</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.Notifier</code> itself.
					/// 
					/// Event is fired when a message of the notifiers was selected.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.Notifier</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Notifier attachMessageSelected(object oData, sap.ui.ux3.Notifier.MessageSelectedDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:messageSelected messageSelected} event of this <code>sap.ui.ux3.Notifier</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.Notifier</code> itself.
					/// 
					/// Event is fired when a message of the notifiers was selected.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Notifier attachMessageSelected(object oData, sap.ui.ux3.Notifier.MessageSelectedDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:messageSelected messageSelected} event of this <code>sap.ui.ux3.Notifier</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.Notifier</code> itself.
					/// 
					/// Event is fired when a message of the notifiers was selected.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Notifier attachMessageSelected(sap.ui.ux3.Notifier.MessageSelectedDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:messageSelected messageSelected} event of this <code>sap.ui.ux3.Notifier</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.Notifier</code> itself.
					/// 
					/// Event is fired when a message of the notifiers was selected.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.Notifier</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Notifier attachMessageSelected(sap.ui.ux3.Notifier.MessageSelectedDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:messageSelected messageSelected} event of this <code>sap.ui.ux3.Notifier</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Notifier detachMessageSelected(sap.ui.ux3.Notifier.MessageSelectedDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:messageSelected messageSelected} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Notifier fireMessageSelected(sap.ui.ux3.Notifier.MessageSelectedInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:messageSelected messageSelected} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Notifier fireMessageSelected();

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.ux3.Notifier with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.ux3.Notifier with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.ux3.Notifier with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.ux3.Notifier.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					/// <summary>
					/// This method checks if the notifier has any items.
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
