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
			/// MessageStrip is a control that enables the embedding of application-related messages in the application. <h3>Overview</h3> The message strip displays 4 types of messages, each with a corresponding semantic color and icon: Information, Success, Warning and Error.
			/// 
			/// Each message can have a close button, so that it can be removed from the UI if needed.
			/// 
			/// With version 1.50 you can use a limited set of formatting tags for the message text by setting <code>enableFormattedText</code>. The allowed tags are: <ul> <li>&lt;a&gt;</li> <li>&lt;em&gt;</li> <li>&lt;strong&gt;</li> <li>&lt;u&gt;</li> </ul> <h3>Usage</h3> <h4>When to use</h4> <ul> <li>You want to provide information or status update within the detail area of an object</li> </ul> <h4>When not to use</h4> <ul> <li>You want to display information within the object page header, within a control, in the master list, or above the page header.</li> </ul>
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.MessageStrip")]
			public partial class MessageStrip : sap.ui.core.Control
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
					/// Determines the text of the message.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> text;

					/// <summary>
					/// Determines the type of messages that are displayed in the MessageStrip. Possible values are: Information (default), Success, Warning, Error. If None is passed, the value is set to Information and a warning is displayed in the console.
					/// </summary>
					public Union<sap.ui.core.MessageType, string, sap.ui.@base.ManagedObject.BindPropertyInfo> type;

					/// <summary>
					/// Determines a custom icon which is displayed. If none is set, the default icon for this message type is used.
					/// </summary>
					public Union<sap.ui.core.URI, string, sap.ui.@base.ManagedObject.BindPropertyInfo> customIcon;

					/// <summary>
					/// Determines if an icon is displayed for the message.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showIcon;

					/// <summary>
					/// Determines if the message has a close button in the upper right corner.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showCloseButton;

					/// <summary>
					/// Determines the limited collection of HTML elements passed to the <code>text</code> property should be evaluated.
					/// 
					/// <b>Note:</b> If this property is set to true the string passed to <code>text</code> property can evaluate the following list of limited HTML elements. All other HTML elements and their nested content will not be rendered by the control: <ul> <li><code>a</code></li> <li><code>em</code></li> <li><code>strong</code></li> <li><code>u</code></li> </ul>
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> enableFormattedText;

					/// <summary>
					/// Adds an sap.m.Link control which will be displayed at the end of the message.
					/// </summary>
					public Union<sap.m.Link, string, sap.ui.@base.ManagedObject.BindAggregationInfo> link;

					/// <summary>
					/// This event will be fired after the container is closed.
					/// </summary>
					public sap.ui.@base.EventDelegate close;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new MessageStrip.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern MessageStrip(string sId, sap.m.MessageStrip.Settings mSettings);

				/// <summary>
				/// Constructor for a new MessageStrip.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern MessageStrip(string sId);

				/// <summary>
				/// Constructor for a new MessageStrip.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern MessageStrip();

				/// <summary>
				/// Constructor for a new MessageStrip.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern MessageStrip(sap.m.MessageStrip.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property text

				/// <summary>
				/// Gets current value of property {@link #getText text}.
				/// 
				/// Determines the text of the message.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <returns>Value of property <code>text</code></returns>
				public extern virtual string getText();

				/// <summary>
				/// Setter for property text. Default value is empty/undefined
				/// </summary>
				/// <param name="sText">new value for property text</param>
				/// <returns>this to allow method chaining</returns>
				public extern virtual sap.m.MessageStrip setText(string sText);

				#endregion

				#region Methods for Property type

				/// <summary>
				/// Gets current value of property {@link #getType type}.
				/// 
				/// Determines the type of messages that are displayed in the MessageStrip. Possible values are: Information (default), Success, Warning, Error. If None is passed, the value is set to Information and a warning is displayed in the console.
				/// 
				/// Default value is <code>Information</code>.
				/// </summary>
				/// <returns>Value of property <code>type</code></returns>
				public extern virtual sap.ui.core.MessageType getType();

				/// <summary>
				/// Setter for property type. Default value is sap.ui.core.MessageType.Information
				/// </summary>
				/// <param name="sType">The Message type</param>
				/// <returns>this to allow method chaining</returns>
				public extern virtual sap.m.MessageStrip setType(sap.ui.core.MessageType sType);

				#endregion

				#region Methods for Property customIcon

				/// <summary>
				/// Gets current value of property {@link #getCustomIcon customIcon}.
				/// 
				/// Determines a custom icon which is displayed. If none is set, the default icon for this message type is used.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <returns>Value of property <code>customIcon</code></returns>
				public extern virtual sap.ui.core.URI getCustomIcon();

				/// <summary>
				/// Sets a new value for property {@link #getCustomIcon customIcon}.
				/// 
				/// Determines a custom icon which is displayed. If none is set, the default icon for this message type is used.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <param name="sCustomIcon">New value for property <code>customIcon</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessageStrip setCustomIcon(sap.ui.core.URI sCustomIcon);

				#endregion

				#region Methods for Property showIcon

				/// <summary>
				/// Gets current value of property {@link #getShowIcon showIcon}.
				/// 
				/// Determines if an icon is displayed for the message.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>showIcon</code></returns>
				public extern virtual bool getShowIcon();

				/// <summary>
				/// Sets a new value for property {@link #getShowIcon showIcon}.
				/// 
				/// Determines if an icon is displayed for the message.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bShowIcon">New value for property <code>showIcon</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessageStrip setShowIcon(bool bShowIcon);

				#endregion

				#region Methods for Property showCloseButton

				/// <summary>
				/// Gets current value of property {@link #getShowCloseButton showCloseButton}.
				/// 
				/// Determines if the message has a close button in the upper right corner.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>showCloseButton</code></returns>
				public extern virtual bool getShowCloseButton();

				/// <summary>
				/// Sets a new value for property {@link #getShowCloseButton showCloseButton}.
				/// 
				/// Determines if the message has a close button in the upper right corner.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bShowCloseButton">New value for property <code>showCloseButton</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessageStrip setShowCloseButton(bool bShowCloseButton);

				#endregion

				#region Methods for Property enableFormattedText

				/// <summary>
				/// Gets current value of property {@link #getEnableFormattedText enableFormattedText}.
				/// 
				/// Determines the limited collection of HTML elements passed to the <code>text</code> property should be evaluated.
				/// 
				/// <b>Note:</b> If this property is set to true the string passed to <code>text</code> property can evaluate the following list of limited HTML elements. All other HTML elements and their nested content will not be rendered by the control: <ul> <li><code>a</code></li> <li><code>em</code></li> <li><code>strong</code></li> <li><code>u</code></li> </ul>
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>enableFormattedText</code></returns>
				public extern virtual bool getEnableFormattedText();

				/// <summary>
				/// Sets a new value for property {@link #getEnableFormattedText enableFormattedText}.
				/// 
				/// Determines the limited collection of HTML elements passed to the <code>text</code> property should be evaluated.
				/// 
				/// <b>Note:</b> If this property is set to true the string passed to <code>text</code> property can evaluate the following list of limited HTML elements. All other HTML elements and their nested content will not be rendered by the control: <ul> <li><code>a</code></li> <li><code>em</code></li> <li><code>strong</code></li> <li><code>u</code></li> </ul>
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bEnableFormattedText">New value for property <code>enableFormattedText</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessageStrip setEnableFormattedText(bool bEnableFormattedText);

				#endregion

				#region Methods for Aggregation link

				/// <summary>
				/// Gets content of aggregation {@link #getLink link}.
				/// 
				/// Adds an sap.m.Link control which will be displayed at the end of the message.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.Link getLink();

				/// <summary>
				/// Destroys the link in the aggregation {@link #getLink link}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessageStrip destroyLink();

				/// <summary>
				/// Sets the aggregated {@link #getLink link}.
				/// </summary>
				/// <param name="oLink">The link to set</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessageStrip setLink(sap.m.Link oLink);

				#endregion

				#region Methods for Aggregation _formattedText

				#endregion

				#region Methods for Aggregation _text

				#endregion

				#region Methods for Event close

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:close close} event of this <code>sap.m.MessageStrip</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MessageStrip</code> itself.
				/// 
				/// This event will be fired after the container is closed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.MessageStrip</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessageStrip attachClose(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:close close} event of this <code>sap.m.MessageStrip</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MessageStrip</code> itself.
				/// 
				/// This event will be fired after the container is closed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessageStrip attachClose(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:close close} event of this <code>sap.m.MessageStrip</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MessageStrip</code> itself.
				/// 
				/// This event will be fired after the container is closed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessageStrip attachClose(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:close close} event of this <code>sap.m.MessageStrip</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MessageStrip</code> itself.
				/// 
				/// This event will be fired after the container is closed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.MessageStrip</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessageStrip attachClose(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:close close} event of this <code>sap.m.MessageStrip</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessageStrip detachClose(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:close close} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessageStrip fireClose(object mParameters);

				/// <summary>
				/// Fires event {@link #event:close close} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MessageStrip fireClose();

				#endregion

				#region Other methods

				/// <summary>
				/// Closes the MessageStrip. This method sets the visible property of the MessageStrip to false. The MessageStrip can be shown again by setting the visible property to true.
				/// </summary>
				public extern virtual void close();

				/// <summary>
				/// Creates a new subclass of class sap.m.MessageStrip with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.MessageStrip with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.MessageStrip with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.MessageStrip.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				[Name("getMetadata")]
				public extern static sap.ui.@base.Metadata getMetadataStatic();

				#endregion

				#endregion

			}
		}
	}
}
