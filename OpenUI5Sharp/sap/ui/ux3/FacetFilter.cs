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
				/// FacetFilter Control.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.ux3.FacetFilter")]
				[Obsolete("Deprecated since 1.38. replaced by {@link sap.m.FacetFilter}")]
				public partial class FacetFilter : sap.ui.core.Control
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
						/// If the value is "Auto" - the Facet Filter takes the whole available height. If "Fixed" , then the default number of Facet Filter Items (5) is visible.
						/// </summary>
						public Union<sap.ui.ux3.VisibleItemCountMode, string, sap.ui.@base.ManagedObject.BindPropertyInfo> visibleItemCountMode;

						/// <summary>
						/// Facet Filter list represents the list of the filter values and the title of this list.
						/// </summary>
						public Union<sap.ui.ux3.FacetFilterList[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> lists;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new FacetFilter.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern FacetFilter(string sId, sap.ui.ux3.FacetFilter.Settings mSettings);

					/// <summary>
					/// Constructor for a new FacetFilter.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern FacetFilter(string sId);

					/// <summary>
					/// Constructor for a new FacetFilter.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern FacetFilter();

					/// <summary>
					/// Constructor for a new FacetFilter.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern FacetFilter(sap.ui.ux3.FacetFilter.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property visibleItemCountMode

					/// <summary>
					/// Gets current value of property {@link #getVisibleItemCountMode visibleItemCountMode}.
					/// 
					/// If the value is "Auto" - the Facet Filter takes the whole available height. If "Fixed" , then the default number of Facet Filter Items (5) is visible.
					/// 
					/// Default value is <code>Fixed</code>.
					/// </summary>
					/// <returns>Value of property <code>visibleItemCountMode</code></returns>
					public extern virtual sap.ui.ux3.VisibleItemCountMode getVisibleItemCountMode();

					/// <summary>
					/// Sets a new value for property {@link #getVisibleItemCountMode visibleItemCountMode}.
					/// 
					/// If the value is "Auto" - the Facet Filter takes the whole available height. If "Fixed" , then the default number of Facet Filter Items (5) is visible.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>Fixed</code>.
					/// </summary>
					/// <param name="sVisibleItemCountMode">New value for property <code>visibleItemCountMode</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FacetFilter setVisibleItemCountMode(sap.ui.ux3.VisibleItemCountMode sVisibleItemCountMode);

					#endregion

					#region Methods for Aggregation lists

					/// <summary>
					/// Gets content of aggregation {@link #getLists lists}.
					/// 
					/// Facet Filter list represents the list of the filter values and the title of this list.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.ux3.FacetFilterList[] getLists();

					/// <summary>
					/// Destroys all the lists in the aggregation {@link #getLists lists}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FacetFilter destroyLists();

					/// <summary>
					/// Inserts a list into the aggregation {@link #getLists lists}.
					/// </summary>
					/// <param name="oList">The list to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the list should be inserted at; for a negative value of <code>iIndex</code>, the list is inserted at position 0; for a value greater than the current size of the aggregation, the list is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FacetFilter insertList(sap.ui.ux3.FacetFilterList oList, int iIndex);

					/// <summary>
					/// Adds some list to the aggregation {@link #getLists lists}.
					/// </summary>
					/// <param name="oList">The list to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.FacetFilter addList(sap.ui.ux3.FacetFilterList oList);

					/// <summary>
					/// Removes a list from the aggregation {@link #getLists lists}.
					/// </summary>
					/// <param name="vList">The list to remove or its index or id</param>
					/// <returns>The removed list or <code>null</code></returns>
					public extern virtual sap.ui.ux3.FacetFilterList removeList(Union<int, string, sap.ui.ux3.FacetFilterList> vList);

					/// <summary>
					/// Checks for the provided <code>sap.ui.ux3.FacetFilterList</code> in the aggregation {@link #getLists lists}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oList">The list whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfList(sap.ui.ux3.FacetFilterList oList);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getLists lists}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.ux3.FacetFilterList[] removeAllLists();

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.ux3.FacetFilter with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.ux3.FacetFilter with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.ux3.FacetFilter with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.ux3.FacetFilter.
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
}
