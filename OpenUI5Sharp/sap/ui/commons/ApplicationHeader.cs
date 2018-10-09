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
				/// The application header control stands on the top of any application page. It consists of 4 areas: Logo area, Function area provided by application, Search area, Logout area.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.ApplicationHeader")]
				[Obsolete("Deprecated since 1.38. Instead, use the <code>sap.tnt.ToolHeader</code> control.")]
				public partial class ApplicationHeader : sap.ui.core.Control
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
						/// Path (src) to the logo icon to be displayed in the application header.
						/// </summary>
						public Union<sap.ui.core.URI, string, sap.ui.@base.ManagedObject.BindPropertyInfo> logoSrc;

						/// <summary>
						/// The text that will be displayed beside the logo in the application header. This property is optional.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> logoText;

						/// <summary>
						/// Determines if the logoff area will be displayed at the right hand side of the application header.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> displayLogoff;

						/// <summary>
						/// User name that will be displayed beside the welcome text
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> userName;

						/// <summary>
						/// Determines if the welcome text is displayed
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> displayWelcome;

						/// <summary>
						/// Fires an event to log off the user from the application. No parameters.
						/// </summary>
						public sap.ui.@base.EventDelegate logoff;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new ApplicationHeader.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern ApplicationHeader(string sId, sap.ui.commons.ApplicationHeader.Settings mSettings);

					/// <summary>
					/// Constructor for a new ApplicationHeader.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					public extern ApplicationHeader(string sId);

					/// <summary>
					/// Constructor for a new ApplicationHeader.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern ApplicationHeader();

					/// <summary>
					/// Constructor for a new ApplicationHeader.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern ApplicationHeader(sap.ui.commons.ApplicationHeader.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property logoSrc

					/// <summary>
					/// Gets current value of property {@link #getLogoSrc logoSrc}.
					/// 
					/// Path (src) to the logo icon to be displayed in the application header.
					/// </summary>
					/// <returns>Value of property <code>logoSrc</code></returns>
					public extern virtual sap.ui.core.URI getLogoSrc();

					/// <summary>
					/// Sets a new value for property {@link #getLogoSrc logoSrc}.
					/// 
					/// Path (src) to the logo icon to be displayed in the application header.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sLogoSrc">New value for property <code>logoSrc</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ApplicationHeader setLogoSrc(sap.ui.core.URI sLogoSrc);

					#endregion

					#region Methods for Property logoText

					/// <summary>
					/// Gets current value of property {@link #getLogoText logoText}.
					/// 
					/// The text that will be displayed beside the logo in the application header. This property is optional.
					/// </summary>
					/// <returns>Value of property <code>logoText</code></returns>
					public extern virtual string getLogoText();

					/// <summary>
					/// Sets a new value for property {@link #getLogoText logoText}.
					/// 
					/// The text that will be displayed beside the logo in the application header. This property is optional.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sLogoText">New value for property <code>logoText</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ApplicationHeader setLogoText(string sLogoText);

					#endregion

					#region Methods for Property displayLogoff

					/// <summary>
					/// Gets current value of property {@link #getDisplayLogoff displayLogoff}.
					/// 
					/// Determines if the logoff area will be displayed at the right hand side of the application header.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>displayLogoff</code></returns>
					public extern virtual bool getDisplayLogoff();

					/// <summary>
					/// Sets a new value for property {@link #getDisplayLogoff displayLogoff}.
					/// 
					/// Determines if the logoff area will be displayed at the right hand side of the application header.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bDisplayLogoff">New value for property <code>displayLogoff</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ApplicationHeader setDisplayLogoff(bool bDisplayLogoff);

					#endregion

					#region Methods for Property userName

					/// <summary>
					/// Gets current value of property {@link #getUserName userName}.
					/// 
					/// User name that will be displayed beside the welcome text
					/// </summary>
					/// <returns>Value of property <code>userName</code></returns>
					public extern virtual string getUserName();

					/// <summary>
					/// Sets a new value for property {@link #getUserName userName}.
					/// 
					/// User name that will be displayed beside the welcome text
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sUserName">New value for property <code>userName</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ApplicationHeader setUserName(string sUserName);

					#endregion

					#region Methods for Property displayWelcome

					/// <summary>
					/// Gets current value of property {@link #getDisplayWelcome displayWelcome}.
					/// 
					/// Determines if the welcome text is displayed
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>displayWelcome</code></returns>
					public extern virtual bool getDisplayWelcome();

					/// <summary>
					/// Sets a new value for property {@link #getDisplayWelcome displayWelcome}.
					/// 
					/// Determines if the welcome text is displayed
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bDisplayWelcome">New value for property <code>displayWelcome</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ApplicationHeader setDisplayWelcome(bool bDisplayWelcome);

					#endregion

					#region Methods for Event logoff

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:logoff logoff} event of this <code>sap.ui.commons.ApplicationHeader</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.ApplicationHeader</code> itself.
					/// 
					/// Fires an event to log off the user from the application. No parameters.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.ApplicationHeader</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ApplicationHeader attachLogoff(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:logoff logoff} event of this <code>sap.ui.commons.ApplicationHeader</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.ApplicationHeader</code> itself.
					/// 
					/// Fires an event to log off the user from the application. No parameters.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ApplicationHeader attachLogoff(object oData, sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:logoff logoff} event of this <code>sap.ui.commons.ApplicationHeader</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.ApplicationHeader</code> itself.
					/// 
					/// Fires an event to log off the user from the application. No parameters.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ApplicationHeader attachLogoff(sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:logoff logoff} event of this <code>sap.ui.commons.ApplicationHeader</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.ApplicationHeader</code> itself.
					/// 
					/// Fires an event to log off the user from the application. No parameters.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.ApplicationHeader</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ApplicationHeader attachLogoff(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:logoff logoff} event of this <code>sap.ui.commons.ApplicationHeader</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ApplicationHeader detachLogoff(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:logoff logoff} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ApplicationHeader fireLogoff(object mParameters);

					/// <summary>
					/// Fires event {@link #event:logoff logoff} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ApplicationHeader fireLogoff();

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.ApplicationHeader with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.ApplicationHeader with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.ApplicationHeader with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.commons.ApplicationHeader.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					#endregion

					#endregion

				}
			}
		}
	}
}
