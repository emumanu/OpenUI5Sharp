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
				/// QuickView is a small popup with a short overview of a Thing. QuickView is shown when a user holds the mouse pointer over a related screen element.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.ux3.QuickView")]
				[Obsolete("Deprecated since 1.38. Instead, use the <code>sap.m.QuickView</code> control.")]
				public partial class QuickView : sap.ui.commons.CalloutBase
				{
					#region Settings

					/// <summary>
					/// Settings class to create the object
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class Settings : sap.ui.commons.CalloutBase.Settings
					{
						/// <summary>
						/// Thing type (mandatory) like Account, Material, Employee etc. is displayed in a header at the top part of the QuickView.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> type;

						/// <summary>
						/// Thing name shown in the header of the QuickView
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> firstTitle;

						/// <summary>
						/// URI to Thing Inspector
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> firstTitleHref;

						/// <summary>
						/// Optional short text shown under the firstTitle
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> secondTitle;

						/// <summary>
						/// URI of the Thing icon image (mandatory). The image is scaled down to the maximal size of 32 pixel (vertical or horizontal).
						/// </summary>
						public Union<sap.ui.core.URI, string, sap.ui.@base.ManagedObject.BindPropertyInfo> icon;

						/// <summary>
						/// Control width as common CSS-size (px or % as unit, for example).
						/// </summary>
						public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> width;

						/// <summary>
						/// Show Action Bar
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showActionBar;

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
						/// Open Thing action enabled/disabled. If disabled the action will be invisible.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> openActionEnabled;

						/// <summary>
						/// Body content of the QuickView
						/// </summary>
						public Union<sap.ui.core.Element[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> content;

						/// <summary>
						/// Actions of a Thing
						/// </summary>
						public Union<sap.ui.ux3.ThingAction[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> actions;

						/// <summary>
						/// ActionBar. If no actionBar is set a default ActionBar will be created. In any case, ActionBar is displayed only when the showActionBar property is set to true.
						/// </summary>
						public Union<sap.ui.ux3.ActionBar, string, sap.ui.@base.ManagedObject.BindAggregationInfo> actionBar;

						/// <summary>
						/// Action is selected in Action Bar
						/// </summary>
						public sap.ui.ux3.ActionSelectedDelegate actionSelected;

						/// <summary>
						/// Fired when a new feed entry is submitted.
						/// </summary>
						public sap.ui.ux3.SubmitDelegate feedSubmit;

						/// <summary>
						/// Event is fired when a user clicks on the firstTitle link. Call the preventDefault method of the event object to cancel browser navigation.
						/// </summary>
						public sap.ui.ux3.QuickView.NavigateDelegate navigate;

					}

					#endregion

					#region Typed Parameters

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class NavigateInfo
					{
						/// <summary>
						/// URI of the Thing Inspector application.
						/// </summary>
						public string href;

					}

					#endregion

					#region Delegates

					public delegate void NavigateDelegate(sap.ui.@base.Event<sap.ui.ux3.QuickView.NavigateInfo> oEvent, object oData);

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new QuickView.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern QuickView(string sId, sap.ui.ux3.QuickView.Settings mSettings);

					/// <summary>
					/// Constructor for a new QuickView.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern QuickView(string sId);

					/// <summary>
					/// Constructor for a new QuickView.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern QuickView();

					/// <summary>
					/// Constructor for a new QuickView.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern QuickView(sap.ui.ux3.QuickView.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property type

					/// <summary>
					/// Gets current value of property {@link #getType type}.
					/// 
					/// Thing type (mandatory) like Account, Material, Employee etc. is displayed in a header at the top part of the QuickView.
					/// </summary>
					/// <returns>Value of property <code>type</code></returns>
					public extern virtual string getType();

					/// <summary>
					/// Sets a new value for property {@link #getType type}.
					/// 
					/// Thing type (mandatory) like Account, Material, Employee etc. is displayed in a header at the top part of the QuickView.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sType">New value for property <code>type</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.QuickView setType(string sType);

					#endregion

					#region Methods for Property firstTitle

					/// <summary>
					/// Gets current value of property {@link #getFirstTitle firstTitle}.
					/// 
					/// Thing name shown in the header of the QuickView
					/// </summary>
					/// <returns>Value of property <code>firstTitle</code></returns>
					public extern virtual string getFirstTitle();

					/// <summary>
					/// Sets a new value for property {@link #getFirstTitle firstTitle}.
					/// 
					/// Thing name shown in the header of the QuickView
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sFirstTitle">New value for property <code>firstTitle</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.QuickView setFirstTitle(string sFirstTitle);

					#endregion

					#region Methods for Property firstTitleHref

					/// <summary>
					/// Gets current value of property {@link #getFirstTitleHref firstTitleHref}.
					/// 
					/// URI to Thing Inspector
					/// </summary>
					/// <returns>Value of property <code>firstTitleHref</code></returns>
					public extern virtual string getFirstTitleHref();

					/// <summary>
					/// Sets a new value for property {@link #getFirstTitleHref firstTitleHref}.
					/// 
					/// URI to Thing Inspector
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sFirstTitleHref">New value for property <code>firstTitleHref</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.QuickView setFirstTitleHref(string sFirstTitleHref);

					#endregion

					#region Methods for Property secondTitle

					/// <summary>
					/// Gets current value of property {@link #getSecondTitle secondTitle}.
					/// 
					/// Optional short text shown under the firstTitle
					/// </summary>
					/// <returns>Value of property <code>secondTitle</code></returns>
					public extern virtual string getSecondTitle();

					/// <summary>
					/// Sets a new value for property {@link #getSecondTitle secondTitle}.
					/// 
					/// Optional short text shown under the firstTitle
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sSecondTitle">New value for property <code>secondTitle</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.QuickView setSecondTitle(string sSecondTitle);

					#endregion

					#region Methods for Property icon

					/// <summary>
					/// Gets current value of property {@link #getIcon icon}.
					/// 
					/// URI of the Thing icon image (mandatory). The image is scaled down to the maximal size of 32 pixel (vertical or horizontal).
					/// </summary>
					/// <returns>Value of property <code>icon</code></returns>
					public extern virtual sap.ui.core.URI getIcon();

					/// <summary>
					/// Sets a new value for property {@link #getIcon icon}.
					/// 
					/// URI of the Thing icon image (mandatory). The image is scaled down to the maximal size of 32 pixel (vertical or horizontal).
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sIcon">New value for property <code>icon</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.QuickView setIcon(sap.ui.core.URI sIcon);

					#endregion

					#region Methods for Property width

					/// <summary>
					/// Gets current value of property {@link #getWidth width}.
					/// 
					/// Control width as common CSS-size (px or % as unit, for example).
					/// </summary>
					/// <returns>Value of property <code>width</code></returns>
					public extern virtual sap.ui.core.CSSSize getWidth();

					/// <summary>
					/// Sets a new value for property {@link #getWidth width}.
					/// 
					/// Control width as common CSS-size (px or % as unit, for example).
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sWidth">New value for property <code>width</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.QuickView setWidth(sap.ui.core.CSSSize sWidth);

					#endregion

					#region Methods for Property showActionBar

					/// <summary>
					/// Gets current value of property {@link #getShowActionBar showActionBar}.
					/// 
					/// Show Action Bar
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>showActionBar</code></returns>
					public extern virtual bool getShowActionBar();

					/// <summary>
					/// Sets a new value for property {@link #getShowActionBar showActionBar}.
					/// 
					/// Show Action Bar
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bShowActionBar">New value for property <code>showActionBar</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.QuickView setShowActionBar(bool bShowActionBar);

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
					public extern virtual sap.ui.ux3.QuickView setFollowState(sap.ui.ux3.FollowActionState sFollowState);

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
					public extern virtual sap.ui.ux3.QuickView setFlagState(bool bFlagState);

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
					public extern virtual sap.ui.ux3.QuickView setFavoriteState(bool bFavoriteState);

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
					public extern virtual sap.ui.ux3.QuickView setFavoriteActionEnabled(bool bFavoriteActionEnabled);

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
					public extern virtual sap.ui.ux3.QuickView setUpdateActionEnabled(bool bUpdateActionEnabled);

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
					public extern virtual sap.ui.ux3.QuickView setFollowActionEnabled(bool bFollowActionEnabled);

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
					public extern virtual sap.ui.ux3.QuickView setFlagActionEnabled(bool bFlagActionEnabled);

					#endregion

					#region Methods for Property openActionEnabled

					/// <summary>
					/// Gets current value of property {@link #getOpenActionEnabled openActionEnabled}.
					/// 
					/// Open Thing action enabled/disabled. If disabled the action will be invisible.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>openActionEnabled</code></returns>
					public extern virtual bool getOpenActionEnabled();

					/// <summary>
					/// Sets a new value for property {@link #getOpenActionEnabled openActionEnabled}.
					/// 
					/// Open Thing action enabled/disabled. If disabled the action will be invisible.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bOpenActionEnabled">New value for property <code>openActionEnabled</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.QuickView setOpenActionEnabled(bool bOpenActionEnabled);

					#endregion

					#region Methods for Aggregation content

					/// <summary>
					/// Gets content of aggregation {@link #getContent content}.
					/// 
					/// Body content of the QuickView
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.Element[] getContent();

					/// <summary>
					/// Destroys all the content in the aggregation {@link #getContent content}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.QuickView destroyContent();

					/// <summary>
					/// Inserts a content into the aggregation {@link #getContent content}.
					/// </summary>
					/// <param name="oContent">The content to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the content should be inserted at; for a negative value of <code>iIndex</code>, the content is inserted at position 0; for a value greater than the current size of the aggregation, the content is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.QuickView insertContent(sap.ui.core.Element oContent, int iIndex);

					/// <summary>
					/// Adds some content to the aggregation {@link #getContent content}.
					/// </summary>
					/// <param name="oContent">The content to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.QuickView addContent(sap.ui.core.Element oContent);

					/// <summary>
					/// Removes a content from the aggregation {@link #getContent content}.
					/// </summary>
					/// <param name="vContent">The content to remove or its index or id</param>
					/// <returns>The removed content or <code>null</code></returns>
					public extern virtual sap.ui.core.Element removeContent(Union<int, string, sap.ui.core.Element> vContent);

					/// <summary>
					/// Checks for the provided <code>sap.ui.core.Element</code> in the aggregation {@link #getContent content}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oContent">The content whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfContent(sap.ui.core.Element oContent);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getContent content}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.core.Element[] removeAllContent();

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
					public extern virtual sap.ui.ux3.QuickView destroyActions();

					/// <summary>
					/// Inserts a action into the aggregation {@link #getActions actions}.
					/// </summary>
					/// <param name="oAction">The action to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the action should be inserted at; for a negative value of <code>iIndex</code>, the action is inserted at position 0; for a value greater than the current size of the aggregation, the action is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.QuickView insertAction(sap.ui.ux3.ThingAction oAction, int iIndex);

					/// <summary>
					/// Adds some action to the aggregation {@link #getActions actions}.
					/// </summary>
					/// <param name="oAction">The action to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.QuickView addAction(sap.ui.ux3.ThingAction oAction);

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

					#region Methods for Aggregation actionBar

					/// <summary>
					/// Gets content of aggregation {@link #getActionBar actionBar}.
					/// 
					/// ActionBar. If no actionBar is set a default ActionBar will be created. In any case, ActionBar is displayed only when the showActionBar property is set to true.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.ux3.ActionBar getActionBar();

					/// <summary>
					/// Destroys the actionBar in the aggregation {@link #getActionBar actionBar}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.QuickView destroyActionBar();

					/// <summary>
					/// Sets the aggregated {@link #getActionBar actionBar}.
					/// </summary>
					/// <param name="oActionBar">The actionBar to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.QuickView setActionBar(sap.ui.ux3.ActionBar oActionBar);

					#endregion

					#region Methods for Event actionSelected

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:actionSelected actionSelected} event of this <code>sap.ui.ux3.QuickView</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.QuickView</code> itself.
					/// 
					/// Action is selected in Action Bar
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.QuickView</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.QuickView attachActionSelected(object oData, sap.ui.ux3.ActionSelectedDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:actionSelected actionSelected} event of this <code>sap.ui.ux3.QuickView</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.QuickView</code> itself.
					/// 
					/// Action is selected in Action Bar
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.QuickView attachActionSelected(object oData, sap.ui.ux3.ActionSelectedDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:actionSelected actionSelected} event of this <code>sap.ui.ux3.QuickView</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.QuickView</code> itself.
					/// 
					/// Action is selected in Action Bar
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.QuickView attachActionSelected(sap.ui.ux3.ActionSelectedDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:actionSelected actionSelected} event of this <code>sap.ui.ux3.QuickView</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.QuickView</code> itself.
					/// 
					/// Action is selected in Action Bar
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.QuickView</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.QuickView attachActionSelected(sap.ui.ux3.ActionSelectedDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:actionSelected actionSelected} event of this <code>sap.ui.ux3.QuickView</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.QuickView detachActionSelected(sap.ui.ux3.ActionSelectedDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:actionSelected actionSelected} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.QuickView fireActionSelected(sap.ui.ux3.ActionSelectedInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:actionSelected actionSelected} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.QuickView fireActionSelected();

					#endregion

					#region Methods for Event feedSubmit

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:feedSubmit feedSubmit} event of this <code>sap.ui.ux3.QuickView</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.QuickView</code> itself.
					/// 
					/// Fired when a new feed entry is submitted.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.QuickView</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.QuickView attachFeedSubmit(object oData, sap.ui.ux3.SubmitDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:feedSubmit feedSubmit} event of this <code>sap.ui.ux3.QuickView</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.QuickView</code> itself.
					/// 
					/// Fired when a new feed entry is submitted.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.QuickView attachFeedSubmit(object oData, sap.ui.ux3.SubmitDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:feedSubmit feedSubmit} event of this <code>sap.ui.ux3.QuickView</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.QuickView</code> itself.
					/// 
					/// Fired when a new feed entry is submitted.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.QuickView attachFeedSubmit(sap.ui.ux3.SubmitDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:feedSubmit feedSubmit} event of this <code>sap.ui.ux3.QuickView</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.QuickView</code> itself.
					/// 
					/// Fired when a new feed entry is submitted.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.QuickView</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.QuickView attachFeedSubmit(sap.ui.ux3.SubmitDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:feedSubmit feedSubmit} event of this <code>sap.ui.ux3.QuickView</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.QuickView detachFeedSubmit(sap.ui.ux3.SubmitDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:feedSubmit feedSubmit} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.QuickView fireFeedSubmit(sap.ui.ux3.SubmitInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:feedSubmit feedSubmit} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.QuickView fireFeedSubmit();

					#endregion

					#region Methods for Event navigate

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:navigate navigate} event of this <code>sap.ui.ux3.QuickView</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.QuickView</code> itself.
					/// 
					/// Event is fired when a user clicks on the firstTitle link. Call the preventDefault method of the event object to cancel browser navigation.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.QuickView</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.QuickView attachNavigate(object oData, sap.ui.ux3.QuickView.NavigateDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:navigate navigate} event of this <code>sap.ui.ux3.QuickView</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.QuickView</code> itself.
					/// 
					/// Event is fired when a user clicks on the firstTitle link. Call the preventDefault method of the event object to cancel browser navigation.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.QuickView attachNavigate(object oData, sap.ui.ux3.QuickView.NavigateDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:navigate navigate} event of this <code>sap.ui.ux3.QuickView</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.QuickView</code> itself.
					/// 
					/// Event is fired when a user clicks on the firstTitle link. Call the preventDefault method of the event object to cancel browser navigation.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.QuickView attachNavigate(sap.ui.ux3.QuickView.NavigateDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:navigate navigate} event of this <code>sap.ui.ux3.QuickView</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.QuickView</code> itself.
					/// 
					/// Event is fired when a user clicks on the firstTitle link. Call the preventDefault method of the event object to cancel browser navigation.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.QuickView</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.QuickView attachNavigate(sap.ui.ux3.QuickView.NavigateDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:navigate navigate} event of this <code>sap.ui.ux3.QuickView</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.QuickView detachNavigate(sap.ui.ux3.QuickView.NavigateDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:navigate navigate} to attached listeners.
					/// 
					/// Listeners may prevent the default action of this event by using the <code>preventDefault</code>-method on the event object.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Whether or not to prevent the default action</returns>
					public extern virtual bool fireNavigate(sap.ui.ux3.QuickView.NavigateInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:navigate navigate} to attached listeners.
					/// 
					/// Listeners may prevent the default action of this event by using the <code>preventDefault</code>-method on the event object.
					/// </summary>
					/// <returns>Whether or not to prevent the default action</returns>
					public extern virtual bool fireNavigate();

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.ux3.QuickView with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.commons.CalloutBase.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.ux3.QuickView with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.commons.CalloutBase.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.ux3.QuickView with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.commons.CalloutBase.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.ux3.QuickView.
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
