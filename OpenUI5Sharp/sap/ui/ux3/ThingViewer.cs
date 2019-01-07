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
				/// ThingViewer: Same as ThingInspector but decoupled from the Overlay and the ActionBar. The control can be added to a Parent container that has a defined width. The ThingViewer fill the whole container. If the parent container has no width defined the control will not work properly.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.ux3.ThingViewer")]
				[Obsolete("Deprecated since 1.38. There is not an exact replacement.")]
				public partial class ThingViewer : sap.ui.core.Control
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
						/// Title of the Thing Inspector
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> title;

						/// <summary>
						/// Thing type
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> type;

						/// <summary>
						/// Thing Icon Url
						/// </summary>
						public Union<sap.ui.core.URI, string, sap.ui.@base.ManagedObject.BindPropertyInfo> icon;

						/// <summary>
						/// Subtitle of the Thing Inspector
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> subtitle;

						/// <summary>
						/// Width of the ThingViewer
						/// </summary>
						public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> width;

						/// <summary>
						/// Height of the ThingViewer
						/// </summary>
						public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> height;

						/// <summary>
						/// Defines which header type should be used.
						/// </summary>
						public Union<sap.ui.ux3.ThingViewerHeaderType, string, sap.ui.@base.ManagedObject.BindPropertyInfo> headerType;

						/// <summary>
						/// ThingGroups for the header content
						/// </summary>
						public Union<sap.ui.ux3.ThingGroup[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> headerContent;

						/// <summary>
						/// Thing Inspector facets
						/// </summary>
						public Union<sap.ui.ux3.NavigationItem[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> facets;

						/// <summary>
						/// ThingGroups for content of the selected facet
						/// </summary>
						public Union<sap.ui.ux3.ThingGroup[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> facetContent;

						/// <summary>
						/// An ActionBar can be given
						/// </summary>
						public Union<sap.ui.ux3.ActionBar, string, sap.ui.@base.ManagedObject.BindAggregationInfo> actionBar;

						/// <summary>
						/// The Facet that is currently selected.
						/// </summary>
						public Union<sap.ui.ux3.NavigationItem, sap.ui.core.ID, string, sap.ui.@base.ManagedObject.BindPropertyInfo> selectedFacet;

						/// <summary>
						/// Event for facet selection. The application is responsible for displaying the correct content for the selected one. The ThingInspector will currently always mark the first facet as selected.
						/// </summary>
						public sap.ui.ux3.SelectedDelegate facetSelected;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new ThingViewer.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern ThingViewer(string sId, sap.ui.ux3.ThingViewer.Settings mSettings);

					/// <summary>
					/// Constructor for a new ThingViewer.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern ThingViewer(string sId);

					/// <summary>
					/// Constructor for a new ThingViewer.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern ThingViewer();

					/// <summary>
					/// Constructor for a new ThingViewer.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern ThingViewer(sap.ui.ux3.ThingViewer.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property title

					/// <summary>
					/// Gets current value of property {@link #getTitle title}.
					/// 
					/// Title of the Thing Inspector
					/// </summary>
					/// <returns>Value of property <code>title</code></returns>
					public extern virtual string getTitle();

					/// <summary>
					/// Sets a new value for property {@link #getTitle title}.
					/// 
					/// Title of the Thing Inspector
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sTitle">New value for property <code>title</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ThingViewer setTitle(string sTitle);

					#endregion

					#region Methods for Property type

					/// <summary>
					/// Gets current value of property {@link #getType type}.
					/// 
					/// Thing type
					/// </summary>
					/// <returns>Value of property <code>type</code></returns>
					public extern virtual string getType();

					/// <summary>
					/// Sets a new value for property {@link #getType type}.
					/// 
					/// Thing type
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sType">New value for property <code>type</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ThingViewer setType(string sType);

					#endregion

					#region Methods for Property icon

					/// <summary>
					/// Gets current value of property {@link #getIcon icon}.
					/// 
					/// Thing Icon Url
					/// </summary>
					/// <returns>Value of property <code>icon</code></returns>
					public extern virtual sap.ui.core.URI getIcon();

					/// <summary>
					/// Sets a new value for property {@link #getIcon icon}.
					/// 
					/// Thing Icon Url
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sIcon">New value for property <code>icon</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ThingViewer setIcon(sap.ui.core.URI sIcon);

					#endregion

					#region Methods for Property subtitle

					/// <summary>
					/// Gets current value of property {@link #getSubtitle subtitle}.
					/// 
					/// Subtitle of the Thing Inspector
					/// </summary>
					/// <returns>Value of property <code>subtitle</code></returns>
					public extern virtual string getSubtitle();

					/// <summary>
					/// Sets a new value for property {@link #getSubtitle subtitle}.
					/// 
					/// Subtitle of the Thing Inspector
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sSubtitle">New value for property <code>subtitle</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ThingViewer setSubtitle(string sSubtitle);

					#endregion

					#region Methods for Property width

					/// <summary>
					/// Gets current value of property {@link #getWidth width}.
					/// 
					/// Width of the ThingViewer
					/// 
					/// Default value is <code>100%</code>.
					/// </summary>
					/// <returns>Value of property <code>width</code></returns>
					public extern virtual sap.ui.core.CSSSize getWidth();

					/// <summary>
					/// Sets a new value for property {@link #getWidth width}.
					/// 
					/// Width of the ThingViewer
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>100%</code>.
					/// </summary>
					/// <param name="sWidth">New value for property <code>width</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ThingViewer setWidth(sap.ui.core.CSSSize sWidth);

					#endregion

					#region Methods for Property height

					/// <summary>
					/// Gets current value of property {@link #getHeight height}.
					/// 
					/// Height of the ThingViewer
					/// 
					/// Default value is <code>100%</code>.
					/// </summary>
					/// <returns>Value of property <code>height</code></returns>
					public extern virtual sap.ui.core.CSSSize getHeight();

					/// <summary>
					/// Sets a new value for property {@link #getHeight height}.
					/// 
					/// Height of the ThingViewer
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>100%</code>.
					/// </summary>
					/// <param name="sHeight">New value for property <code>height</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ThingViewer setHeight(sap.ui.core.CSSSize sHeight);

					#endregion

					#region Methods for Property headerType

					/// <summary>
					/// Gets current value of property {@link #getHeaderType headerType}.
					/// 
					/// Defines which header type should be used.
					/// 
					/// Default value is <code>Standard</code>.
					/// </summary>
					/// <returns>Value of property <code>headerType</code></returns>
					public extern virtual sap.ui.ux3.ThingViewerHeaderType getHeaderType();

					/// <summary>
					/// Sets a new value for property {@link #getHeaderType headerType}.
					/// 
					/// Defines which header type should be used.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>Standard</code>.
					/// </summary>
					/// <param name="sHeaderType">New value for property <code>headerType</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ThingViewer setHeaderType(sap.ui.ux3.ThingViewerHeaderType sHeaderType);

					#endregion

					#region Methods for Aggregation headerContent

					/// <summary>
					/// Gets content of aggregation {@link #getHeaderContent headerContent}.
					/// 
					/// ThingGroups for the header content
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.ux3.ThingGroup[] getHeaderContent();

					/// <summary>
					/// Destroys all the headerContent in the aggregation {@link #getHeaderContent headerContent}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ThingViewer destroyHeaderContent();

					/// <summary>
					/// Inserts a headerContent into the aggregation {@link #getHeaderContent headerContent}.
					/// </summary>
					/// <param name="oHeaderContent">The headerContent to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the headerContent should be inserted at; for a negative value of <code>iIndex</code>, the headerContent is inserted at position 0; for a value greater than the current size of the aggregation, the headerContent is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ThingViewer insertHeaderContent(sap.ui.ux3.ThingGroup oHeaderContent, int iIndex);

					/// <summary>
					/// Adds some headerContent to the aggregation {@link #getHeaderContent headerContent}.
					/// </summary>
					/// <param name="oHeaderContent">The headerContent to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ThingViewer addHeaderContent(sap.ui.ux3.ThingGroup oHeaderContent);

					/// <summary>
					/// Removes a headerContent from the aggregation {@link #getHeaderContent headerContent}.
					/// </summary>
					/// <param name="vHeaderContent">The headerContent to remove or its index or id</param>
					/// <returns>The removed headerContent or <code>null</code></returns>
					public extern virtual sap.ui.ux3.ThingGroup removeHeaderContent(Union<int, string, sap.ui.ux3.ThingGroup> vHeaderContent);

					/// <summary>
					/// Checks for the provided <code>sap.ui.ux3.ThingGroup</code> in the aggregation {@link #getHeaderContent headerContent}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oHeaderContent">The headerContent whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfHeaderContent(sap.ui.ux3.ThingGroup oHeaderContent);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getHeaderContent headerContent}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.ux3.ThingGroup[] removeAllHeaderContent();

					#endregion

					#region Methods for Aggregation facets

					/// <summary>
					/// Gets content of aggregation {@link #getFacets facets}.
					/// 
					/// Thing Inspector facets
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.ux3.NavigationItem[] getFacets();

					/// <summary>
					/// Destroys all the facets in the aggregation {@link #getFacets facets}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ThingViewer destroyFacets();

					/// <summary>
					/// Inserts a facet into the aggregation {@link #getFacets facets}.
					/// </summary>
					/// <param name="oFacet">The facet to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the facet should be inserted at; for a negative value of <code>iIndex</code>, the facet is inserted at position 0; for a value greater than the current size of the aggregation, the facet is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ThingViewer insertFacet(sap.ui.ux3.NavigationItem oFacet, int iIndex);

					/// <summary>
					/// Adds some facet to the aggregation {@link #getFacets facets}.
					/// </summary>
					/// <param name="oFacet">The facet to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ThingViewer addFacet(sap.ui.ux3.NavigationItem oFacet);

					/// <summary>
					/// Removes a facet from the aggregation {@link #getFacets facets}.
					/// </summary>
					/// <param name="vFacet">The facet to remove or its index or id</param>
					/// <returns>The removed facet or <code>null</code></returns>
					public extern virtual sap.ui.ux3.NavigationItem removeFacet(Union<int, string, sap.ui.ux3.NavigationItem> vFacet);

					/// <summary>
					/// Checks for the provided <code>sap.ui.ux3.NavigationItem</code> in the aggregation {@link #getFacets facets}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oFacet">The facet whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfFacet(sap.ui.ux3.NavigationItem oFacet);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getFacets facets}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.ux3.NavigationItem[] removeAllFacets();

					#endregion

					#region Methods for Aggregation facetContent

					/// <summary>
					/// Gets content of aggregation {@link #getFacetContent facetContent}.
					/// 
					/// ThingGroups for content of the selected facet
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.ux3.ThingGroup[] getFacetContent();

					/// <summary>
					/// Destroys all the facetContent in the aggregation {@link #getFacetContent facetContent}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ThingViewer destroyFacetContent();

					/// <summary>
					/// Inserts a facetContent into the aggregation {@link #getFacetContent facetContent}.
					/// </summary>
					/// <param name="oFacetContent">The facetContent to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the facetContent should be inserted at; for a negative value of <code>iIndex</code>, the facetContent is inserted at position 0; for a value greater than the current size of the aggregation, the facetContent is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ThingViewer insertFacetContent(sap.ui.ux3.ThingGroup oFacetContent, int iIndex);

					/// <summary>
					/// Adds some facetContent to the aggregation {@link #getFacetContent facetContent}.
					/// </summary>
					/// <param name="oFacetContent">The facetContent to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ThingViewer addFacetContent(sap.ui.ux3.ThingGroup oFacetContent);

					/// <summary>
					/// Removes a facetContent from the aggregation {@link #getFacetContent facetContent}.
					/// </summary>
					/// <param name="vFacetContent">The facetContent to remove or its index or id</param>
					/// <returns>The removed facetContent or <code>null</code></returns>
					public extern virtual sap.ui.ux3.ThingGroup removeFacetContent(Union<int, string, sap.ui.ux3.ThingGroup> vFacetContent);

					/// <summary>
					/// Checks for the provided <code>sap.ui.ux3.ThingGroup</code> in the aggregation {@link #getFacetContent facetContent}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oFacetContent">The facetContent whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfFacetContent(sap.ui.ux3.ThingGroup oFacetContent);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getFacetContent facetContent}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.ux3.ThingGroup[] removeAllFacetContent();

					#endregion

					#region Methods for Aggregation actionBar

					/// <summary>
					/// Gets content of aggregation {@link #getActionBar actionBar}.
					/// 
					/// An ActionBar can be given
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.ux3.ActionBar getActionBar();

					/// <summary>
					/// Destroys the actionBar in the aggregation {@link #getActionBar actionBar}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ThingViewer destroyActionBar();

					/// <summary>
					/// Sets the aggregated {@link #getActionBar actionBar}.
					/// </summary>
					/// <param name="oActionBar">The actionBar to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ThingViewer setActionBar(sap.ui.ux3.ActionBar oActionBar);

					#endregion

					#region Methods for Aggregation navBar

					#endregion

					#region Methods for Association selectedFacet

					/// <summary>
					/// ID of the element which is the current target of the association {@link #getSelectedFacet selectedFacet}, or <code>null</code>.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.ID getSelectedFacet();

					/// <summary>
					/// Sets the associated {@link #getSelectedFacet selectedFacet}.
					/// </summary>
					/// <param name="oSelectedFacet">ID of an element which becomes the new target of this selectedFacet association; alternatively, an element instance may be given</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ThingViewer setSelectedFacet(Union<sap.ui.core.ID, sap.ui.ux3.NavigationItem> oSelectedFacet);

					#endregion

					#region Methods for Event facetSelected

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:facetSelected facetSelected} event of this <code>sap.ui.ux3.ThingViewer</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.ThingViewer</code> itself.
					/// 
					/// Event for facet selection. The application is responsible for displaying the correct content for the selected one. The ThingInspector will currently always mark the first facet as selected.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.ThingViewer</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ThingViewer attachFacetSelected(object oData, sap.ui.ux3.SelectedDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:facetSelected facetSelected} event of this <code>sap.ui.ux3.ThingViewer</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.ThingViewer</code> itself.
					/// 
					/// Event for facet selection. The application is responsible for displaying the correct content for the selected one. The ThingInspector will currently always mark the first facet as selected.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ThingViewer attachFacetSelected(object oData, sap.ui.ux3.SelectedDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:facetSelected facetSelected} event of this <code>sap.ui.ux3.ThingViewer</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.ThingViewer</code> itself.
					/// 
					/// Event for facet selection. The application is responsible for displaying the correct content for the selected one. The ThingInspector will currently always mark the first facet as selected.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ThingViewer attachFacetSelected(sap.ui.ux3.SelectedDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:facetSelected facetSelected} event of this <code>sap.ui.ux3.ThingViewer</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.ThingViewer</code> itself.
					/// 
					/// Event for facet selection. The application is responsible for displaying the correct content for the selected one. The ThingInspector will currently always mark the first facet as selected.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.ThingViewer</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ThingViewer attachFacetSelected(sap.ui.ux3.SelectedDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:facetSelected facetSelected} event of this <code>sap.ui.ux3.ThingViewer</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ThingViewer detachFacetSelected(sap.ui.ux3.SelectedDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:facetSelected facetSelected} to attached listeners.
					/// 
					/// Listeners may prevent the default action of this event by using the <code>preventDefault</code>-method on the event object.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Whether or not to prevent the default action</returns>
					public extern virtual bool fireFacetSelected(sap.ui.ux3.SelectedInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:facetSelected facetSelected} to attached listeners.
					/// 
					/// Listeners may prevent the default action of this event by using the <code>preventDefault</code>-method on the event object.
					/// </summary>
					/// <returns>Whether or not to prevent the default action</returns>
					public extern virtual bool fireFacetSelected();

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.ux3.ThingViewer with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.ux3.ThingViewer with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.ux3.ThingViewer with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.ux3.ThingViewer.
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
