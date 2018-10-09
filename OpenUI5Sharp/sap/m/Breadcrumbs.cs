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
			/// Enables users to navigate between items by providing a list of links to previous steps in the user's navigation path. The last three steps can be accessed as links directly, while the remaining links prior to them are available in a drop-down menu.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.Breadcrumbs")]
			public partial class Breadcrumbs : sap.ui.core.Control, sap.m.IBreadcrumbs
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
					/// Determines the text of current/last element in the Breadcrumbs path.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> currentLocationText;

					/// <summary>
					/// A list of all the active link elements in the Breadcrumbs control. <b>Note:</b> Enabling the property <code>wrapping</code> of the link will not work since it's incompatible with the concept of the control. The other properties will work, but their effect may be undesirable.
					/// </summary>
					public Union<sap.m.Link[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> links;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new <code>Breadcrumbs</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern Breadcrumbs(string sId, sap.m.Breadcrumbs.Settings mSettings);

				/// <summary>
				/// Constructor for a new <code>Breadcrumbs</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern Breadcrumbs(string sId);

				/// <summary>
				/// Constructor for a new <code>Breadcrumbs</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern Breadcrumbs();

				/// <summary>
				/// Constructor for a new <code>Breadcrumbs</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern Breadcrumbs(sap.m.Breadcrumbs.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property currentLocationText

				/// <summary>
				/// Gets current value of property {@link #getCurrentLocationText currentLocationText}.
				/// 
				/// Determines the text of current/last element in the Breadcrumbs path.
				/// </summary>
				/// <returns>Value of property <code>currentLocationText</code></returns>
				public extern virtual string getCurrentLocationText();

				/// <summary>
				/// Sets a new value for property {@link #getCurrentLocationText currentLocationText}.
				/// 
				/// Determines the text of current/last element in the Breadcrumbs path.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sCurrentLocationText">New value for property <code>currentLocationText</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Breadcrumbs setCurrentLocationText(string sCurrentLocationText);

				#endregion

				#region Methods for Aggregation links

				/// <summary>
				/// Gets content of aggregation {@link #getLinks links}.
				/// 
				/// A list of all the active link elements in the Breadcrumbs control. <b>Note:</b> Enabling the property <code>wrapping</code> of the link will not work since it's incompatible with the concept of the control. The other properties will work, but their effect may be undesirable.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.Link[] getLinks();

				/// <summary>
				/// Destroys all the links in the aggregation {@link #getLinks links}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Breadcrumbs destroyLinks();

				/// <summary>
				/// Inserts a link into the aggregation {@link #getLinks links}.
				/// </summary>
				/// <param name="oLink">The link to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the link should be inserted at; for a negative value of <code>iIndex</code>, the link is inserted at position 0; for a value greater than the current size of the aggregation, the link is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Breadcrumbs insertLink(sap.m.Link oLink, int iIndex);

				/// <summary>
				/// Adds some link to the aggregation {@link #getLinks links}.
				/// </summary>
				/// <param name="oLink">The link to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Breadcrumbs addLink(sap.m.Link oLink);

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

				#region Methods for Aggregation _currentLocation

				#endregion

				#region Methods for Aggregation _select

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.Breadcrumbs with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.Breadcrumbs with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.Breadcrumbs with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.Breadcrumbs.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				#endregion

				#endregion

			}
		}
	}
}
