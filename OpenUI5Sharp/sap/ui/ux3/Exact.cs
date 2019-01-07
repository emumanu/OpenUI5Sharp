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
				/// A comprehensive UI design approach with graphical and functional elements for searching data, exploring data, and acting on the data ("Explore and Act (Exact) Pattern").
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.ux3.Exact")]
				[Obsolete("Deprecated since 1.38.")]
				public partial class Exact : sap.ui.core.Control
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
						/// A title text which is displayed above the result section
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> resultText;

						/// <summary>
						/// Defines the 'Settings' button in the browse section tool bar
						/// </summary>
						public Union<sap.ui.commons.Menu, string, sap.ui.@base.ManagedObject.BindAggregationInfo> settingsMenu;

						/// <summary>
						/// The attributes which shall be available to refine the search
						/// </summary>
						public Union<sap.ui.ux3.ExactAttribute[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> attributes;

						/// <summary>
						/// Event is fired when the search button is clicked
						/// </summary>
						public sap.ui.SearchDelegate search;

						/// <summary>
						/// Event which is fired when an attribute is selected or unselected.
						/// </summary>
						public sap.ui.ux3.Exact.RefineSearchDelegate refineSearch;

					}

					#endregion

					#region Typed Parameters

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class RefineSearchInfo
					{
						/// <summary>
						/// The query string which was entered in the search field
						/// </summary>
						public string query;

						/// <summary>
						/// The attribute which was selected or unselected recently
						/// </summary>
						public sap.ui.ux3.ExactAttribute changedAttribute;

						/// <summary>
						/// Array of all selected ExcatAttribute.
						/// </summary>
						public object allSelectedAttributes;

					}

					#endregion

					#region Delegates

					public delegate void RefineSearchDelegate(sap.ui.@base.Event<sap.ui.ux3.Exact.RefineSearchInfo> oEvent, object oData);

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new Exact.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern Exact(string sId, sap.ui.ux3.Exact.Settings mSettings);

					/// <summary>
					/// Constructor for a new Exact.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern Exact(string sId);

					/// <summary>
					/// Constructor for a new Exact.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern Exact();

					/// <summary>
					/// Constructor for a new Exact.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern Exact(sap.ui.ux3.Exact.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property resultText

					/// <summary>
					/// Gets current value of property {@link #getResultText resultText}.
					/// 
					/// A title text which is displayed above the result section
					/// </summary>
					/// <returns>Value of property <code>resultText</code></returns>
					public extern virtual string getResultText();

					/// <summary>
					/// Sets a new value for property {@link #getResultText resultText}.
					/// 
					/// A title text which is displayed above the result section
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sResultText">New value for property <code>resultText</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Exact setResultText(string sResultText);

					#endregion

					#region Methods for Aggregation settingsMenu

					/// <summary>
					/// Gets content of aggregation {@link #getSettingsMenu settingsMenu}.
					/// 
					/// Defines the 'Settings' button in the browse section tool bar
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.commons.Menu getSettingsMenu();

					/// <summary>
					/// Destroys the settingsMenu in the aggregation {@link #getSettingsMenu settingsMenu}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Exact destroySettingsMenu();

					/// <summary>
					/// Sets the aggregated {@link #getSettingsMenu settingsMenu}.
					/// </summary>
					/// <param name="oSettingsMenu">The settingsMenu to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Exact setSettingsMenu(sap.ui.commons.Menu oSettingsMenu);

					#endregion

					#region Methods for Aggregation attributes

					/// <summary>
					/// Gets content of aggregation {@link #getAttributes attributes}.
					/// 
					/// The attributes which shall be available to refine the search
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.ux3.ExactAttribute[] getAttributes();

					/// <summary>
					/// Destroys all the attributes in the aggregation {@link #getAttributes attributes}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Exact destroyAttributes();

					/// <summary>
					/// Inserts a attribute into the aggregation {@link #getAttributes attributes}.
					/// </summary>
					/// <param name="oAttribute">The attribute to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the attribute should be inserted at; for a negative value of <code>iIndex</code>, the attribute is inserted at position 0; for a value greater than the current size of the aggregation, the attribute is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Exact insertAttribute(sap.ui.ux3.ExactAttribute oAttribute, int iIndex);

					/// <summary>
					/// Adds some attribute to the aggregation {@link #getAttributes attributes}.
					/// </summary>
					/// <param name="oAttribute">The attribute to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Exact addAttribute(sap.ui.ux3.ExactAttribute oAttribute);

					/// <summary>
					/// Removes a attribute from the aggregation {@link #getAttributes attributes}.
					/// </summary>
					/// <param name="vAttribute">The attribute to remove or its index or id</param>
					/// <returns>The removed attribute or <code>null</code></returns>
					public extern virtual sap.ui.ux3.ExactAttribute removeAttribute(Union<int, string, sap.ui.ux3.ExactAttribute> vAttribute);

					/// <summary>
					/// Checks for the provided <code>sap.ui.ux3.ExactAttribute</code> in the aggregation {@link #getAttributes attributes}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oAttribute">The attribute whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfAttribute(sap.ui.ux3.ExactAttribute oAttribute);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getAttributes attributes}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.ux3.ExactAttribute[] removeAllAttributes();

					#endregion

					#region Methods for Aggregation controls

					#endregion

					#region Methods for Event search

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:search search} event of this <code>sap.ui.ux3.Exact</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.Exact</code> itself.
					/// 
					/// Event is fired when the search button is clicked
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.Exact</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Exact attachSearch(object oData, sap.ui.SearchDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:search search} event of this <code>sap.ui.ux3.Exact</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.Exact</code> itself.
					/// 
					/// Event is fired when the search button is clicked
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Exact attachSearch(object oData, sap.ui.SearchDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:search search} event of this <code>sap.ui.ux3.Exact</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.Exact</code> itself.
					/// 
					/// Event is fired when the search button is clicked
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Exact attachSearch(sap.ui.SearchDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:search search} event of this <code>sap.ui.ux3.Exact</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.Exact</code> itself.
					/// 
					/// Event is fired when the search button is clicked
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.Exact</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Exact attachSearch(sap.ui.SearchDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:search search} event of this <code>sap.ui.ux3.Exact</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Exact detachSearch(sap.ui.SearchDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:search search} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Exact fireSearch(sap.ui.SearchInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:search search} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Exact fireSearch();

					#endregion

					#region Methods for Event refineSearch

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:refineSearch refineSearch} event of this <code>sap.ui.ux3.Exact</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.Exact</code> itself.
					/// 
					/// Event which is fired when an attribute is selected or unselected.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.Exact</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Exact attachRefineSearch(object oData, sap.ui.ux3.Exact.RefineSearchDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:refineSearch refineSearch} event of this <code>sap.ui.ux3.Exact</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.Exact</code> itself.
					/// 
					/// Event which is fired when an attribute is selected or unselected.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Exact attachRefineSearch(object oData, sap.ui.ux3.Exact.RefineSearchDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:refineSearch refineSearch} event of this <code>sap.ui.ux3.Exact</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.Exact</code> itself.
					/// 
					/// Event which is fired when an attribute is selected or unselected.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Exact attachRefineSearch(sap.ui.ux3.Exact.RefineSearchDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:refineSearch refineSearch} event of this <code>sap.ui.ux3.Exact</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.Exact</code> itself.
					/// 
					/// Event which is fired when an attribute is selected or unselected.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.Exact</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Exact attachRefineSearch(sap.ui.ux3.Exact.RefineSearchDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:refineSearch refineSearch} event of this <code>sap.ui.ux3.Exact</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Exact detachRefineSearch(sap.ui.ux3.Exact.RefineSearchDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:refineSearch refineSearch} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Exact fireRefineSearch(sap.ui.ux3.Exact.RefineSearchInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:refineSearch refineSearch} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Exact fireRefineSearch();

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.ux3.Exact with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.ux3.Exact with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.ux3.Exact with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.ux3.Exact.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					[Name("getMetadata")]
					public extern static sap.ui.@base.Metadata getMetadataStatic();

					/// <summary>
					/// Returns the ExactArea representing the result section. Arbitrary content can be added here.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.ux3.ExactArea getResultArea();

					/// <summary>
					/// Returns the SearchField control which is used by the Exact control.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.commons.SearchField getSearchField();

					#endregion

					#endregion

				}
			}
		}
	}
}
