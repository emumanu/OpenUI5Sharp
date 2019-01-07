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
			/// PullToRefresh control. Put it as the first control in contents of a scroll container or a scrollable page. Do not place it into a page with disabled scrolling. On touch devices it gets hidden by default and when the user pulls down the page far enough, it gets visible and triggers the "refresh" event. In non-touch browsers where scrollbars are used for scrolling, it is always visible and triggers the "refresh" event when clicked.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.PullToRefresh")]
			public partial class PullToRefresh : sap.ui.core.Control
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
					/// Optional description. May be used to inform a user, for example, when the list has been updated last time.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> description;

					/// <summary>
					/// Set to true to display an icon/logo. Icon must be set either in the customIcon property or in the CSS theme for the PullToRefresh control.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showIcon;

					/// <summary>
					/// Provide a URI to a custom icon image to replace the SAP logo. Large images are scaled down to max 50px height.
					/// </summary>
					public Union<sap.ui.core.URI, string, sap.ui.@base.ManagedObject.BindPropertyInfo> customIcon;

					/// <summary>
					/// By default, this is set to true but then one or more requests are sent trying to get the density perfect version of image if this version of image doesn't exist on the server.
					/// 
					/// If bandwidth is the key for the application, set this value to false.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> iconDensityAware;

					/// <summary>
					/// Event indicates that the user has requested new data
					/// </summary>
					public sap.ui.@base.EventDelegate refresh;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new PullToRefresh.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">id for the new control, generated automatically if no id is given</param>
				/// <param name="mSettings">initial settings for the new control</param>
				public extern PullToRefresh(string sId, sap.m.PullToRefresh.Settings mSettings);

				/// <summary>
				/// Constructor for a new PullToRefresh.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">id for the new control, generated automatically if no id is given</param>
				public extern PullToRefresh(string sId);

				/// <summary>
				/// Constructor for a new PullToRefresh.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern PullToRefresh();

				/// <summary>
				/// Constructor for a new PullToRefresh.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">initial settings for the new control</param>
				public extern PullToRefresh(sap.m.PullToRefresh.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property description

				/// <summary>
				/// Gets current value of property {@link #getDescription description}.
				/// 
				/// Optional description. May be used to inform a user, for example, when the list has been updated last time.
				/// </summary>
				/// <returns>Value of property <code>description</code></returns>
				public extern virtual string getDescription();

				/// <summary>
				/// Sets a new value for property {@link #getDescription description}.
				/// 
				/// Optional description. May be used to inform a user, for example, when the list has been updated last time.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sDescription">New value for property <code>description</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PullToRefresh setDescription(string sDescription);

				#endregion

				#region Methods for Property showIcon

				/// <summary>
				/// Gets current value of property {@link #getShowIcon showIcon}.
				/// 
				/// Set to true to display an icon/logo. Icon must be set either in the customIcon property or in the CSS theme for the PullToRefresh control.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>showIcon</code></returns>
				public extern virtual bool getShowIcon();

				/// <summary>
				/// Sets a new value for property {@link #getShowIcon showIcon}.
				/// 
				/// Set to true to display an icon/logo. Icon must be set either in the customIcon property or in the CSS theme for the PullToRefresh control.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bShowIcon">New value for property <code>showIcon</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PullToRefresh setShowIcon(bool bShowIcon);

				#endregion

				#region Methods for Property customIcon

				/// <summary>
				/// Gets current value of property {@link #getCustomIcon customIcon}.
				/// 
				/// Provide a URI to a custom icon image to replace the SAP logo. Large images are scaled down to max 50px height.
				/// </summary>
				/// <returns>Value of property <code>customIcon</code></returns>
				public extern virtual sap.ui.core.URI getCustomIcon();

				/// <summary>
				/// Sets a new value for property {@link #getCustomIcon customIcon}.
				/// 
				/// Provide a URI to a custom icon image to replace the SAP logo. Large images are scaled down to max 50px height.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sCustomIcon">New value for property <code>customIcon</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PullToRefresh setCustomIcon(sap.ui.core.URI sCustomIcon);

				#endregion

				#region Methods for Property iconDensityAware

				/// <summary>
				/// Gets current value of property {@link #getIconDensityAware iconDensityAware}.
				/// 
				/// By default, this is set to true but then one or more requests are sent trying to get the density perfect version of image if this version of image doesn't exist on the server.
				/// 
				/// If bandwidth is the key for the application, set this value to false.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>iconDensityAware</code></returns>
				public extern virtual bool getIconDensityAware();

				/// <summary>
				/// Sets a new value for property {@link #getIconDensityAware iconDensityAware}.
				/// 
				/// By default, this is set to true but then one or more requests are sent trying to get the density perfect version of image if this version of image doesn't exist on the server.
				/// 
				/// If bandwidth is the key for the application, set this value to false.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bIconDensityAware">New value for property <code>iconDensityAware</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PullToRefresh setIconDensityAware(bool bIconDensityAware);

				#endregion

				#region Methods for Event refresh

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:refresh refresh} event of this <code>sap.m.PullToRefresh</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.PullToRefresh</code> itself.
				/// 
				/// Event indicates that the user has requested new data
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.PullToRefresh</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PullToRefresh attachRefresh(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:refresh refresh} event of this <code>sap.m.PullToRefresh</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.PullToRefresh</code> itself.
				/// 
				/// Event indicates that the user has requested new data
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PullToRefresh attachRefresh(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:refresh refresh} event of this <code>sap.m.PullToRefresh</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.PullToRefresh</code> itself.
				/// 
				/// Event indicates that the user has requested new data
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PullToRefresh attachRefresh(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:refresh refresh} event of this <code>sap.m.PullToRefresh</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.PullToRefresh</code> itself.
				/// 
				/// Event indicates that the user has requested new data
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.PullToRefresh</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PullToRefresh attachRefresh(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:refresh refresh} event of this <code>sap.m.PullToRefresh</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PullToRefresh detachRefresh(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:refresh refresh} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PullToRefresh fireRefresh(object mParameters);

				/// <summary>
				/// Fires event {@link #event:refresh refresh} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PullToRefresh fireRefresh();

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.PullToRefresh with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.PullToRefresh with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.PullToRefresh with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.PullToRefresh.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				[Name("getMetadata")]
				public extern static sap.ui.@base.Metadata getMetadataStatic();

				/// <summary>
				/// Hides the control and resets it to the normal state. In non-touch environments the control is not hidden.
				/// </summary>
				public extern virtual void hide();

				#endregion

				#endregion

			}
		}
	}
}
