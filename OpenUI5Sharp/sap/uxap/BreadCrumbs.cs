using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public static partial class sap
	{
		public static partial class uxap
		{
			/// <summary>
			/// Represents the navigation steps up to the current location in the app.
			/// 
			/// <h3>Overview</h3>
			/// 
			/// The <code>BreadCrumbs</code> control allows the users to quickly navigate to a previous location on the path that got them to the current location by choosing the displayed navigation steps.
			/// 
			/// It has two main modes of operation: <ul> <li>A trail of links followed by separators, when there's enough space for the control to fit on one line.</li> <li>A dropdown list with the links, when the trail of links wouldn't fit on one line.</li> </ul>
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.uxap.BreadCrumbs")]
			public partial class BreadCrumbs : sap.ui.core.Control
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
					/// Sets the visibility of the current/last element in the BreadCrumbs path.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showCurrentLocation;

					/// <summary>
					/// A list of all the active link elements in the BreadCrumbs control.
					/// </summary>
					public Union<sap.m.Link[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> links;

					/// <summary>
					/// The current/last element in the BreadCrumbs path.
					/// </summary>
					public Union<sap.m.Text, string, sap.ui.@base.ManagedObject.BindAggregationInfo> currentLocation;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new <code>BreadCrumbs</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern BreadCrumbs(string sId, sap.uxap.BreadCrumbs.Settings mSettings);

				/// <summary>
				/// Constructor for a new <code>BreadCrumbs</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern BreadCrumbs(string sId);

				/// <summary>
				/// Constructor for a new <code>BreadCrumbs</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern BreadCrumbs();

				/// <summary>
				/// Constructor for a new <code>BreadCrumbs</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern BreadCrumbs(sap.uxap.BreadCrumbs.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property showCurrentLocation

				/// <summary>
				/// Gets current value of property {@link #getShowCurrentLocation showCurrentLocation}.
				/// 
				/// Sets the visibility of the current/last element in the BreadCrumbs path.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>showCurrentLocation</code></returns>
				public extern virtual bool getShowCurrentLocation();

				/// <summary>
				/// Sets a new value for property {@link #getShowCurrentLocation showCurrentLocation}.
				/// 
				/// Sets the visibility of the current/last element in the BreadCrumbs path.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bShowCurrentLocation">New value for property <code>showCurrentLocation</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.BreadCrumbs setShowCurrentLocation(bool bShowCurrentLocation);

				#endregion

				#region Methods for Aggregation links

				/// <summary>
				/// Gets content of aggregation {@link #getLinks links}.
				/// 
				/// A list of all the active link elements in the BreadCrumbs control.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.Link[] getLinks();

				/// <summary>
				/// Destroys all the links in the aggregation {@link #getLinks links}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.BreadCrumbs destroyLinks();

				/// <summary>
				/// Inserts a link into the aggregation {@link #getLinks links}.
				/// </summary>
				/// <param name="oLink">The link to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the link should be inserted at; for a negative value of <code>iIndex</code>, the link is inserted at position 0; for a value greater than the current size of the aggregation, the link is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.BreadCrumbs insertLink(sap.m.Link oLink, int iIndex);

				/// <summary>
				/// Adds some link to the aggregation {@link #getLinks links}.
				/// </summary>
				/// <param name="oLink">The link to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.BreadCrumbs addLink(sap.m.Link oLink);

				/// <summary>
				/// Removes a link from the aggregation {@link #getLinks links}.
				/// </summary>
				/// <param name="vLink">The link to remove or its index or id</param>
				/// <returns>The removed link or <code>null</code></returns>
				public extern virtual sap.m.Link removeLink(Union<int, string, sap.m.Link> vLink);

				/// <summary>
				/// Checks for the provided <code>sap.m.Link</code> in the aggregation {@link #getLinks links}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oLink">The link whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfLink(sap.m.Link oLink);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getLinks links}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.m.Link[] removeAllLinks();

				#endregion

				#region Methods for Aggregation currentLocation

				/// <summary>
				/// Gets content of aggregation {@link #getCurrentLocation currentLocation}.
				/// 
				/// The current/last element in the BreadCrumbs path.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.Text getCurrentLocation();

				/// <summary>
				/// Destroys the currentLocation in the aggregation {@link #getCurrentLocation currentLocation}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.BreadCrumbs destroyCurrentLocation();

				/// <summary>
				/// Sets the aggregated {@link #getCurrentLocation currentLocation}.
				/// </summary>
				/// <param name="oCurrentLocation">The currentLocation to set</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.BreadCrumbs setCurrentLocation(sap.m.Text oCurrentLocation);

				#endregion

				#region Methods for Aggregation _tubeIcon

				#endregion

				#region Methods for Aggregation _overflowSelect

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.uxap.BreadCrumbs with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.uxap.BreadCrumbs with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.uxap.BreadCrumbs with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.uxap.BreadCrumbs.
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
