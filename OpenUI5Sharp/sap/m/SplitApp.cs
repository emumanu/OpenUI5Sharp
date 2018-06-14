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
			/// SplitApp is another possible root element of an SAPUI5 mobile application besides {@link sap.m.App}. It contains two NavContainers if running on tablet or desktop, and one on phone. The display of master NavContainer depends on the portrait/landscape mode of the device and the mode of SplitApp. <h3>Structure</h3> The SplitApp divides the screen into two areas: <ul> <li>Master area - contains a list of available items where the user can search and filter.</li> <li>Details area - contains a control which shows further details on the item(s) selected from the master view.</li> </ul> Both areas have separate headers and footer bars with navigation and actions. <h3>Usage</h3> <h4>When to use</h4> <ul> <li>You need to review and process different items quickly with minimal navigation.</li> </ul> <h4>When not to use</h4> <ul> <li>You need to offer complex filters for the list of items.</li> <li>You need to see different attributes for each item in the list, and compare these values across items.</li> <li>You want to display a single object. Do not use the master list to display different facets of the same object.</li> </ul> <h3>Responsive Behavior</h3> On narrow screens for phones (or tablet devices in portrait mode), the master list and the details are split into two separate pages.
			/// 
			/// The user can navigate between the list and details, and see all the available information for each area.
			/// </summary>
			[External]
			[Namespace(false)]
			public partial class SplitApp : sap.m.SplitContainer
			{
				#region Settings

				/// <summary>
				/// Settings class to create the object
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class Settings : sap.m.SplitContainer.Settings
				{
					/// <summary>
					/// Represents the icon to be displayed on the home screen of iOS devices after the user does "add to home screen". Note that only the first attempt to set the homeIcon is executed, subsequent settings are ignored. The icon must be in PNG format. The property can either store the URL of one single icon or an object holding icon URLs for the different required sizes. Note that if single icon is used for all devices, when scaled, its quality can regress. A desktop icon (used for bookmarks and overriding the favicon) can also be configured. This requires an object to be given and the "icon" property of this object then defines the desktop bookmark icon. For this icon, PNG is not supported by Internet Explorer. The ICO format is supported by all browsers. ICO is also preferred for this desktop icon setting as the file can contain different images for different resolutions.
					/// 
					/// One example is:
					/// 
					/// app.setHomeIcon({ 'phone':'phone-icon.png', 'phone@2':'phone-retina.png', 'tablet':'tablet-icon.png', 'tablet@2':'tablet-retina.png', 'icon':'desktop.ico' });
					/// 
					/// The image size is 57/114 px for the phone and 72/144 px for the tablet. If an object is given but one of the sizes is not given, the largest given icon will be used for this size.
					/// 
					/// On Android, these icons may or may not be used by the device. Chances can be improved by adding glare effect, rounded corners, setting the file name to end with "-precomposed.png", and setting the homeIconPrecomposed property to true.
					/// </summary>
					public Union<object, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> homeIcon;

					/// <summary>
					/// Fires when orientation (portrait/landscape) is changed.
					/// </summary>
					public sap.m.App.AppOrientationChangeDelegate orientationChange;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new SplitApp.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control A container control that is used to display a master-detail view in an application.</param>
				public extern SplitApp(string sId, sap.m.SplitApp.Settings mSettings);

				/// <summary>
				/// Constructor for a new SplitApp.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern SplitApp(string sId);

				/// <summary>
				/// Constructor for a new SplitApp.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern SplitApp();

				/// <summary>
				/// Constructor for a new SplitApp.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control A container control that is used to display a master-detail view in an application.</param>
				public extern SplitApp(sap.m.SplitApp.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property homeIcon

				/// <summary>
				/// Gets current value of property {@link #getHomeIcon homeIcon}.
				/// 
				/// Represents the icon to be displayed on the home screen of iOS devices after the user does "add to home screen". Note that only the first attempt to set the homeIcon is executed, subsequent settings are ignored. The icon must be in PNG format. The property can either store the URL of one single icon or an object holding icon URLs for the different required sizes. Note that if single icon is used for all devices, when scaled, its quality can regress. A desktop icon (used for bookmarks and overriding the favicon) can also be configured. This requires an object to be given and the "icon" property of this object then defines the desktop bookmark icon. For this icon, PNG is not supported by Internet Explorer. The ICO format is supported by all browsers. ICO is also preferred for this desktop icon setting as the file can contain different images for different resolutions.
				/// 
				/// One example is:
				/// 
				/// app.setHomeIcon({ 'phone':'phone-icon.png', 'phone@2':'phone-retina.png', 'tablet':'tablet-icon.png', 'tablet@2':'tablet-retina.png', 'icon':'desktop.ico' });
				/// 
				/// The image size is 57/114 px for the phone and 72/144 px for the tablet. If an object is given but one of the sizes is not given, the largest given icon will be used for this size.
				/// 
				/// On Android, these icons may or may not be used by the device. Chances can be improved by adding glare effect, rounded corners, setting the file name to end with "-precomposed.png", and setting the homeIconPrecomposed property to true.
				/// </summary>
				/// <returns>Value of property <code>homeIcon</code></returns>
				public extern virtual object getHomeIcon();

				/// <summary>
				/// Sets a new value for property {@link #getHomeIcon homeIcon}.
				/// 
				/// Represents the icon to be displayed on the home screen of iOS devices after the user does "add to home screen". Note that only the first attempt to set the homeIcon is executed, subsequent settings are ignored. The icon must be in PNG format. The property can either store the URL of one single icon or an object holding icon URLs for the different required sizes. Note that if single icon is used for all devices, when scaled, its quality can regress. A desktop icon (used for bookmarks and overriding the favicon) can also be configured. This requires an object to be given and the "icon" property of this object then defines the desktop bookmark icon. For this icon, PNG is not supported by Internet Explorer. The ICO format is supported by all browsers. ICO is also preferred for this desktop icon setting as the file can contain different images for different resolutions.
				/// 
				/// One example is:
				/// 
				/// app.setHomeIcon({ 'phone':'phone-icon.png', 'phone@2':'phone-retina.png', 'tablet':'tablet-icon.png', 'tablet@2':'tablet-retina.png', 'icon':'desktop.ico' });
				/// 
				/// The image size is 57/114 px for the phone and 72/144 px for the tablet. If an object is given but one of the sizes is not given, the largest given icon will be used for this size.
				/// 
				/// On Android, these icons may or may not be used by the device. Chances can be improved by adding glare effect, rounded corners, setting the file name to end with "-precomposed.png", and setting the homeIconPrecomposed property to true.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="oHomeIcon">New value for property <code>homeIcon</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitApp setHomeIcon(object oHomeIcon);

				#endregion

				#region Methods for Event orientationChange

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:orientationChange orientationChange} event of this <code>sap.m.SplitApp</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SplitApp</code> itself.
				/// 
				/// Fires when orientation (portrait/landscape) is changed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.SplitApp</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitApp attachOrientationChange(object oData, sap.m.App.AppOrientationChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:orientationChange orientationChange} event of this <code>sap.m.SplitApp</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SplitApp</code> itself.
				/// 
				/// Fires when orientation (portrait/landscape) is changed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitApp attachOrientationChange(object oData, sap.m.App.AppOrientationChangeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:orientationChange orientationChange} event of this <code>sap.m.SplitApp</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SplitApp</code> itself.
				/// 
				/// Fires when orientation (portrait/landscape) is changed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitApp attachOrientationChange(sap.m.App.AppOrientationChangeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:orientationChange orientationChange} event of this <code>sap.m.SplitApp</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.SplitApp</code> itself.
				/// 
				/// Fires when orientation (portrait/landscape) is changed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.SplitApp</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitApp attachOrientationChange(sap.m.App.AppOrientationChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:orientationChange orientationChange} event of this <code>sap.m.SplitApp</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitApp detachOrientationChange(sap.m.App.AppOrientationChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:orientationChange orientationChange} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitApp fireOrientationChange(sap.m.App.AppOrientationChangeInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:orientationChange orientationChange} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SplitApp fireOrientationChange();

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.SplitApp with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.SplitContainer.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.SplitApp with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.SplitContainer.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.SplitApp with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.SplitContainer.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.SplitApp.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				#endregion

				#endregion

			}
		}
	}
}
