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
				/// Thing Inspector
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.ux3.ThingInspector")]
				[Obsolete("Deprecated since 1.38. There is not an exact replacement.")]
				public partial class ThingInspector : sap.ui.ux3.Overlay
				{
					#region Settings

					/// <summary>
					/// Settings class to create the object
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class Settings : sap.ui.ux3.Overlay.Settings
					{
						/// <summary>
						/// First Line of the Thing Inspector Title
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> firstTitle;

						/// <summary>
						/// Thing type
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> type;

						/// <summary>
						/// Thing Icon Url
						/// </summary>
						public Union<sap.ui.core.URI, string, sap.ui.@base.ManagedObject.BindPropertyInfo> icon;

						/// <summary>
						/// Second Line of the Thing Inspector Title
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> secondTitle;

						/// <summary>
						/// Follow State of a Thing
						/// </summary>
						public Union<sap.ui.ux3.FollowActionState, string, sap.ui.@base.ManagedObject.BindPropertyInfo> followState;

						/// <summary>
						/// State of Flag Action
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> flagState;

						/// <summary>
						/// State Of favorite Action
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> favoriteState;

						/// <summary>
						/// Favorite action enabled/disabled. If disabled the action will be invisible.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> favoriteActionEnabled;

						/// <summary>
						/// Update action enabled/disabled. If disabled the action will be invisible.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> updateActionEnabled;

						/// <summary>
						/// Follow action enabled/disabled. If disabled the action will be invisible.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> followActionEnabled;

						/// <summary>
						/// Flag action enabled/disabled. If disabled the action will be invisible.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> flagActionEnabled;

						/// <summary>
						/// Defines which header type should be used.
						/// </summary>
						public Union<sap.ui.ux3.ThingViewerHeaderType, string, sap.ui.@base.ManagedObject.BindPropertyInfo> headerType;

						/// <summary>
						/// Actions of a Thing
						/// </summary>
						public Union<sap.ui.ux3.ThingAction[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> actions;

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
						/// ActionBar. If no actionBar is set a default ActionBar will be created.
						/// </summary>
						public Union<sap.ui.ux3.ActionBar, string, sap.ui.@base.ManagedObject.BindAggregationInfo> actionBar;

						/// <summary>
						/// The Facet that is currently selected.
						/// </summary>
						public Union<sap.ui.ux3.NavigationItem, sap.ui.core.ID, string, sap.ui.@base.ManagedObject.BindPropertyInfo> selectedFacet;

						/// <summary>
						/// Further thing related Action selected
						/// </summary>
						public sap.ui.ux3.ThingSelectDelegate actionSelected;

						/// <summary>
						/// Event for facet selection. The application is responsible for displaying the correct content for the selected one. The ThingInspector will currently always mark the first facet as selected.
						/// </summary>
						public sap.ui.ux3.SelectedDelegate facetSelected;

						/// <summary>
						/// Fired when a new feed entry is submitted.
						/// </summary>
						public sap.ui.ux3.SubmitDelegate feedSubmit;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new ThingInspector.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern ThingInspector(string sId, sap.ui.ux3.ThingInspector.Settings mSettings);

					/// <summary>
					/// Constructor for a new ThingInspector.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern ThingInspector(string sId);

					/// <summary>
					/// Constructor for a new ThingInspector.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern ThingInspector();

					/// <summary>
					/// Constructor for a new ThingInspector.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern ThingInspector(sap.ui.ux3.ThingInspector.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property firstTitle

					/// <summary>
					/// Gets current value of property {@link #getFirstTitle firstTitle}.
					/// 
					/// First Line of the Thing Inspector Title
					/// </summary>
					/// <returns>Value of property <code>firstTitle</code></returns>
					public extern virtual string getFirstTitle();

					/// <summary>
					/// Sets a new value for property {@link #getFirstTitle firstTitle}.
					/// 
					/// First Line of the Thing Inspector Title
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sFirstTitle">New value for property <code>firstTitle</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ThingInspector setFirstTitle(string sFirstTitle);

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
					public extern virtual sap.ui.ux3.ThingInspector setType(string sType);

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
					public extern virtual sap.ui.ux3.ThingInspector setIcon(sap.ui.core.URI sIcon);

					#endregion

					#region Methods for Property secondTitle

					/// <summary>
					/// Gets current value of property {@link #getSecondTitle secondTitle}.
					/// 
					/// Second Line of the Thing Inspector Title
					/// </summary>
					/// <returns>Value of property <code>secondTitle</code></returns>
					public extern virtual string getSecondTitle();

					/// <summary>
					/// Sets a new value for property {@link #getSecondTitle secondTitle}.
					/// 
					/// Second Line of the Thing Inspector Title
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sSecondTitle">New value for property <code>secondTitle</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ThingInspector setSecondTitle(string sSecondTitle);

					#endregion

					#region Methods for Property followState

					/// <summary>
					/// Gets current value of property {@link #getFollowState followState}.
					/// 
					/// Follow State of a Thing
					/// 
					/// Default value is <code>Default</code>.
					/// </summary>
					/// <returns>Value of property <code>followState</code></returns>
					public extern virtual sap.ui.ux3.FollowActionState getFollowState();

					/// <summary>
					/// Sets a new value for property {@link #getFollowState followState}.
					/// 
					/// Follow State of a Thing
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>Default</code>.
					/// </summary>
					/// <param name="sFollowState">New value for property <code>followState</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ThingInspector setFollowState(sap.ui.ux3.FollowActionState sFollowState);

					#endregion

					#region Methods for Property flagState

					/// <summary>
					/// Gets current value of property {@link #getFlagState flagState}.
					/// 
					/// State of Flag Action
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>flagState</code></returns>
					public extern virtual bool getFlagState();

					/// <summary>
					/// Sets a new value for property {@link #getFlagState flagState}.
					/// 
					/// State of Flag Action
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bFlagState">New value for property <code>flagState</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ThingInspector setFlagState(bool bFlagState);

					#endregion

					#region Methods for Property favoriteState

					/// <summary>
					/// Gets current value of property {@link #getFavoriteState favoriteState}.
					/// 
					/// State Of favorite Action
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>favoriteState</code></returns>
					public extern virtual bool getFavoriteState();

					/// <summary>
					/// Sets a new value for property {@link #getFavoriteState favoriteState}.
					/// 
					/// State Of favorite Action
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bFavoriteState">New value for property <code>favoriteState</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ThingInspector setFavoriteState(bool bFavoriteState);

					#endregion

					#region Methods for Property favoriteActionEnabled

					/// <summary>
					/// Gets current value of property {@link #getFavoriteActionEnabled favoriteActionEnabled}.
					/// 
					/// Favorite action enabled/disabled. If disabled the action will be invisible.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>favoriteActionEnabled</code></returns>
					public extern virtual bool getFavoriteActionEnabled();

					/// <summary>
					/// Sets a new value for property {@link #getFavoriteActionEnabled favoriteActionEnabled}.
					/// 
					/// Favorite action enabled/disabled. If disabled the action will be invisible.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bFavoriteActionEnabled">New value for property <code>favoriteActionEnabled</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ThingInspector setFavoriteActionEnabled(bool bFavoriteActionEnabled);

					#endregion

					#region Methods for Property updateActionEnabled

					/// <summary>
					/// Gets current value of property {@link #getUpdateActionEnabled updateActionEnabled}.
					/// 
					/// Update action enabled/disabled. If disabled the action will be invisible.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>updateActionEnabled</code></returns>
					public extern virtual bool getUpdateActionEnabled();

					/// <summary>
					/// Sets a new value for property {@link #getUpdateActionEnabled updateActionEnabled}.
					/// 
					/// Update action enabled/disabled. If disabled the action will be invisible.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bUpdateActionEnabled">New value for property <code>updateActionEnabled</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ThingInspector setUpdateActionEnabled(bool bUpdateActionEnabled);

					#endregion

					#region Methods for Property followActionEnabled

					/// <summary>
					/// Gets current value of property {@link #getFollowActionEnabled followActionEnabled}.
					/// 
					/// Follow action enabled/disabled. If disabled the action will be invisible.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>followActionEnabled</code></returns>
					public extern virtual bool getFollowActionEnabled();

					/// <summary>
					/// Sets a new value for property {@link #getFollowActionEnabled followActionEnabled}.
					/// 
					/// Follow action enabled/disabled. If disabled the action will be invisible.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bFollowActionEnabled">New value for property <code>followActionEnabled</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ThingInspector setFollowActionEnabled(bool bFollowActionEnabled);

					#endregion

					#region Methods for Property flagActionEnabled

					/// <summary>
					/// Gets current value of property {@link #getFlagActionEnabled flagActionEnabled}.
					/// 
					/// Flag action enabled/disabled. If disabled the action will be invisible.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>flagActionEnabled</code></returns>
					public extern virtual bool getFlagActionEnabled();

					/// <summary>
					/// Sets a new value for property {@link #getFlagActionEnabled flagActionEnabled}.
					/// 
					/// Flag action enabled/disabled. If disabled the action will be invisible.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bFlagActionEnabled">New value for property <code>flagActionEnabled</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ThingInspector setFlagActionEnabled(bool bFlagActionEnabled);

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
					public extern virtual sap.ui.ux3.ThingInspector setHeaderType(sap.ui.ux3.ThingViewerHeaderType sHeaderType);

					#endregion

					#region Methods for Aggregation actions

					/// <summary>
					/// Gets content of aggregation {@link #getActions actions}.
					/// 
					/// Actions of a Thing
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.ux3.ThingAction[] getActions();

					/// <summary>
					/// Destroys all the actions in the aggregation {@link #getActions actions}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ThingInspector destroyActions();

					/// <summary>
					/// Inserts a action into the aggregation {@link #getActions actions}.
					/// </summary>
					/// <param name="oAction">The action to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the action should be inserted at; for a negative value of <code>iIndex</code>, the action is inserted at position 0; for a value greater than the current size of the aggregation, the action is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ThingInspector insertAction(sap.ui.ux3.ThingAction oAction, int iIndex);

					/// <summary>
					/// Adds some action to the aggregation {@link #getActions actions}.
					/// </summary>
					/// <param name="oAction">The action to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ThingInspector addAction(sap.ui.ux3.ThingAction oAction);

					/// <summary>
					/// Removes a action from the aggregation {@link #getActions actions}.
					/// </summary>
					/// <param name="vAction">The action to remove or its index or id</param>
					/// <returns>The removed action or <code>null</code></returns>
					public extern virtual sap.ui.ux3.ThingAction removeAction(Union<int, string, sap.ui.ux3.ThingAction> vAction);

					/// <summary>
					/// Checks for the provided <code>sap.ui.ux3.ThingAction</code> in the aggregation {@link #getActions actions}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oAction">The action whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfAction(sap.ui.ux3.ThingAction oAction);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getActions actions}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.ux3.ThingAction[] removeAllActions();

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
					public extern virtual sap.ui.ux3.ThingInspector destroyHeaderContent();

					/// <summary>
					/// Inserts a headerContent into the aggregation {@link #getHeaderContent headerContent}.
					/// </summary>
					/// <param name="oHeaderContent">The headerContent to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the headerContent should be inserted at; for a negative value of <code>iIndex</code>, the headerContent is inserted at position 0; for a value greater than the current size of the aggregation, the headerContent is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ThingInspector insertHeaderContent(sap.ui.ux3.ThingGroup oHeaderContent, int iIndex);

					/// <summary>
					/// Adds some headerContent to the aggregation {@link #getHeaderContent headerContent}.
					/// </summary>
					/// <param name="oHeaderContent">The headerContent to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ThingInspector addHeaderContent(sap.ui.ux3.ThingGroup oHeaderContent);

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
					public extern virtual sap.ui.ux3.ThingInspector destroyFacets();

					/// <summary>
					/// Inserts a facet into the aggregation {@link #getFacets facets}.
					/// </summary>
					/// <param name="oFacet">The facet to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the facet should be inserted at; for a negative value of <code>iIndex</code>, the facet is inserted at position 0; for a value greater than the current size of the aggregation, the facet is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ThingInspector insertFacet(sap.ui.ux3.NavigationItem oFacet, int iIndex);

					/// <summary>
					/// Adds some facet to the aggregation {@link #getFacets facets}.
					/// </summary>
					/// <param name="oFacet">The facet to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ThingInspector addFacet(sap.ui.ux3.NavigationItem oFacet);

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
					public extern virtual sap.ui.ux3.ThingInspector destroyFacetContent();

					/// <summary>
					/// Inserts a facetContent into the aggregation {@link #getFacetContent facetContent}.
					/// </summary>
					/// <param name="oFacetContent">The facetContent to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the facetContent should be inserted at; for a negative value of <code>iIndex</code>, the facetContent is inserted at position 0; for a value greater than the current size of the aggregation, the facetContent is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ThingInspector insertFacetContent(sap.ui.ux3.ThingGroup oFacetContent, int iIndex);

					/// <summary>
					/// Adds some facetContent to the aggregation {@link #getFacetContent facetContent}.
					/// </summary>
					/// <param name="oFacetContent">The facetContent to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ThingInspector addFacetContent(sap.ui.ux3.ThingGroup oFacetContent);

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
					/// ActionBar. If no actionBar is set a default ActionBar will be created.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.ux3.ActionBar getActionBar();

					/// <summary>
					/// Destroys the actionBar in the aggregation {@link #getActionBar actionBar}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ThingInspector destroyActionBar();

					/// <summary>
					/// Sets the aggregated {@link #getActionBar actionBar}.
					/// </summary>
					/// <param name="oActionBar">The actionBar to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ThingInspector setActionBar(sap.ui.ux3.ActionBar oActionBar);

					#endregion

					#region Methods for Aggregation thingViewer

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
					public extern virtual sap.ui.ux3.ThingInspector setSelectedFacet(Union<sap.ui.core.ID, sap.ui.ux3.NavigationItem> oSelectedFacet);

					#endregion

					#region Methods for Event actionSelected

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:actionSelected actionSelected} event of this <code>sap.ui.ux3.ThingInspector</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.ThingInspector</code> itself.
					/// 
					/// Further thing related Action selected
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.ThingInspector</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ThingInspector attachActionSelected(object oData, sap.ui.ux3.ThingSelectDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:actionSelected actionSelected} event of this <code>sap.ui.ux3.ThingInspector</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.ThingInspector</code> itself.
					/// 
					/// Further thing related Action selected
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ThingInspector attachActionSelected(object oData, sap.ui.ux3.ThingSelectDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:actionSelected actionSelected} event of this <code>sap.ui.ux3.ThingInspector</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.ThingInspector</code> itself.
					/// 
					/// Further thing related Action selected
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ThingInspector attachActionSelected(sap.ui.ux3.ThingSelectDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:actionSelected actionSelected} event of this <code>sap.ui.ux3.ThingInspector</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.ThingInspector</code> itself.
					/// 
					/// Further thing related Action selected
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.ThingInspector</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ThingInspector attachActionSelected(sap.ui.ux3.ThingSelectDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:actionSelected actionSelected} event of this <code>sap.ui.ux3.ThingInspector</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ThingInspector detachActionSelected(sap.ui.ux3.ThingSelectDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:actionSelected actionSelected} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ThingInspector fireActionSelected(sap.ui.ux3.ThingSelectInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:actionSelected actionSelected} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ThingInspector fireActionSelected();

					#endregion

					#region Methods for Event facetSelected

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:facetSelected facetSelected} event of this <code>sap.ui.ux3.ThingInspector</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.ThingInspector</code> itself.
					/// 
					/// Event for facet selection. The application is responsible for displaying the correct content for the selected one. The ThingInspector will currently always mark the first facet as selected.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.ThingInspector</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ThingInspector attachFacetSelected(object oData, sap.ui.ux3.SelectedDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:facetSelected facetSelected} event of this <code>sap.ui.ux3.ThingInspector</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.ThingInspector</code> itself.
					/// 
					/// Event for facet selection. The application is responsible for displaying the correct content for the selected one. The ThingInspector will currently always mark the first facet as selected.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ThingInspector attachFacetSelected(object oData, sap.ui.ux3.SelectedDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:facetSelected facetSelected} event of this <code>sap.ui.ux3.ThingInspector</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.ThingInspector</code> itself.
					/// 
					/// Event for facet selection. The application is responsible for displaying the correct content for the selected one. The ThingInspector will currently always mark the first facet as selected.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ThingInspector attachFacetSelected(sap.ui.ux3.SelectedDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:facetSelected facetSelected} event of this <code>sap.ui.ux3.ThingInspector</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.ThingInspector</code> itself.
					/// 
					/// Event for facet selection. The application is responsible for displaying the correct content for the selected one. The ThingInspector will currently always mark the first facet as selected.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.ThingInspector</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ThingInspector attachFacetSelected(sap.ui.ux3.SelectedDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:facetSelected facetSelected} event of this <code>sap.ui.ux3.ThingInspector</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ThingInspector detachFacetSelected(sap.ui.ux3.SelectedDelegate fnFunction, object oListener);

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

					#region Methods for Event feedSubmit

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:feedSubmit feedSubmit} event of this <code>sap.ui.ux3.ThingInspector</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.ThingInspector</code> itself.
					/// 
					/// Fired when a new feed entry is submitted.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.ThingInspector</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ThingInspector attachFeedSubmit(object oData, sap.ui.ux3.SubmitDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:feedSubmit feedSubmit} event of this <code>sap.ui.ux3.ThingInspector</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.ThingInspector</code> itself.
					/// 
					/// Fired when a new feed entry is submitted.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ThingInspector attachFeedSubmit(object oData, sap.ui.ux3.SubmitDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:feedSubmit feedSubmit} event of this <code>sap.ui.ux3.ThingInspector</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.ThingInspector</code> itself.
					/// 
					/// Fired when a new feed entry is submitted.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ThingInspector attachFeedSubmit(sap.ui.ux3.SubmitDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:feedSubmit feedSubmit} event of this <code>sap.ui.ux3.ThingInspector</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.ThingInspector</code> itself.
					/// 
					/// Fired when a new feed entry is submitted.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.ThingInspector</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ThingInspector attachFeedSubmit(sap.ui.ux3.SubmitDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:feedSubmit feedSubmit} event of this <code>sap.ui.ux3.ThingInspector</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ThingInspector detachFeedSubmit(sap.ui.ux3.SubmitDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:feedSubmit feedSubmit} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ThingInspector fireFeedSubmit(sap.ui.ux3.SubmitInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:feedSubmit feedSubmit} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ThingInspector fireFeedSubmit();

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.ux3.ThingInspector with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.ux3.Overlay.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.ux3.ThingInspector with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.ux3.Overlay.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.ux3.ThingInspector with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.ux3.Overlay.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.ux3.ThingInspector.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					/// <summary>
					/// Opens this instance of ThingIspector
					/// </summary>
					/// <param name="initialFocusId"></param>
					public extern virtual void open(string initialFocusId);

					/// <summary>
					/// Opens this instance of ThingIspector
					/// </summary>
					public extern virtual void open();

					#endregion

					#endregion

				}
			}
		}
	}
}
