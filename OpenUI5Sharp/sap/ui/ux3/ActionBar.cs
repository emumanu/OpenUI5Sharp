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
				/// A special toolbar with predefined social actions which can be shown as needed. These are: Create an update (Feed), Follow, Mark for Follow Up, Mark as Favorite and Open Thing.
				/// 
				/// In addition business actions (ThingAction instances) can be added which are either displayed as MenuItems of the 'More' menu button or as individual tool bar buttons.
				/// 
				/// When using this control, please be aware that it fulfills rather specific requirements: it has been designed for and is used within composite controls QuickView and ThingInspector.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.ux3.ActionBar")]
				[Obsolete("Deprecated since 1.38. Instead, use the <code>sap.m.Toolbar</code> or <code>sap.m.OverflowToolbar</code> control.")]
				public partial class ActionBar : sap.ui.core.Control
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
						/// Keeps track of the actionBars Follow/Unfollow button’s state. Its value is one of - FollowActionState.Default - FollowActionState.Follow - FollowActionState.Hold
						/// </summary>
						public Union<sap.ui.ux3.FollowActionState, string, sap.ui.@base.ManagedObject.BindPropertyInfo> followState;

						/// <summary>
						/// Indicates whether “Mark for Follow Up” is active
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> flagState;

						/// <summary>
						/// Indicates whether “Favorite” is active
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> favoriteState;

						/// <summary>
						/// Indicates whether “Update” is active
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> updateState;

						/// <summary>
						/// The thing icon uri. Icon will be displayed in Feeder
						/// </summary>
						public Union<sap.ui.core.URI, string, sap.ui.@base.ManagedObject.BindPropertyInfo> thingIconURI;

						/// <summary>
						/// If true, business actions are rendered as menu items of the 'More' menu button. Otherwise, 'More' menu button is only displayed for overflow and business actions are rendered as inidividual buttons.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> alwaysShowMoreMenu;

						/// <summary>
						/// Indicates whether social action “Update” is shown, default is ‘true’
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showUpdate;

						/// <summary>
						/// Indicates whether social action “Follow” is shown, default is ‘true’
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showFollow;

						/// <summary>
						/// Indicates whether social action “Mark for Follow Up” is shown, default is ‘true’
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showFlag;

						/// <summary>
						/// Indicates whether social action “Favorite” is shown, default is ‘true’
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showFavorite;

						/// <summary>
						/// Indicates whether social action “Open” is shown, default is ‘true’
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showOpen;

						/// <summary>
						/// The minimum width of ActionBar's the social actions part: business action controls have to be rendered outside this area
						/// </summary>
						public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> dividerWidth;

						/// <summary>
						/// Displayed on the actionBar's right hand-side, either as menu item under 'More' or as individual buttons
						/// </summary>
						public Union<sap.ui.ux3.ThingAction[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> businessActions;

						/// <summary>
						/// Fired when any of the social action’s toolbar buttons except ‘Update’ or any of the business action’s menu items resp. buttons is pressed. The selected action can be identified by its id and newState (the latter if applicable only) ‘Follow’ button + menu: id: follow, newState: Follow/Hold/Default ‘Mark for follow up’ button: id: flag, newState: true/false ‘Favorite’ button: id: favorite, newState: true/false ‘Open Thing Inspector’ button id: open Business Actions: id: the ThingAction id
						/// 
						/// For ‘Update’, please refer to event ‘feedSubmit’
						/// </summary>
						public sap.ui.ux3.ActionSelectedDelegate actionSelected;

						/// <summary>
						/// Fired when a new feed entry is submitted.
						/// </summary>
						public sap.ui.ux3.SubmitDelegate feedSubmit;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new ActionBar.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern ActionBar(string sId, sap.ui.ux3.ActionBar.Settings mSettings);

					/// <summary>
					/// Constructor for a new ActionBar.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern ActionBar(string sId);

					/// <summary>
					/// Constructor for a new ActionBar.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern ActionBar();

					/// <summary>
					/// Constructor for a new ActionBar.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern ActionBar(sap.ui.ux3.ActionBar.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property followState

					/// <summary>
					/// Gets current value of property {@link #getFollowState followState}.
					/// 
					/// Keeps track of the actionBars Follow/Unfollow button’s state. Its value is one of - FollowActionState.Default - FollowActionState.Follow - FollowActionState.Hold
					/// 
					/// Default value is <code>Default</code>.
					/// </summary>
					/// <returns>Value of property <code>followState</code></returns>
					public extern virtual sap.ui.ux3.FollowActionState getFollowState();

					/// <summary>
					/// Sets a new value for property {@link #getFollowState followState}.
					/// 
					/// Keeps track of the actionBars Follow/Unfollow button’s state. Its value is one of - FollowActionState.Default - FollowActionState.Follow - FollowActionState.Hold
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>Default</code>.
					/// </summary>
					/// <param name="sFollowState">New value for property <code>followState</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ActionBar setFollowState(sap.ui.ux3.FollowActionState sFollowState);

					#endregion

					#region Methods for Property flagState

					/// <summary>
					/// Gets current value of property {@link #getFlagState flagState}.
					/// 
					/// Indicates whether “Mark for Follow Up” is active
					/// </summary>
					/// <returns>Value of property <code>flagState</code></returns>
					public extern virtual bool getFlagState();

					/// <summary>
					/// Sets a new value for property {@link #getFlagState flagState}.
					/// 
					/// Indicates whether “Mark for Follow Up” is active
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="bFlagState">New value for property <code>flagState</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ActionBar setFlagState(bool bFlagState);

					#endregion

					#region Methods for Property favoriteState

					/// <summary>
					/// Gets current value of property {@link #getFavoriteState favoriteState}.
					/// 
					/// Indicates whether “Favorite” is active
					/// </summary>
					/// <returns>Value of property <code>favoriteState</code></returns>
					public extern virtual bool getFavoriteState();

					/// <summary>
					/// Sets a new value for property {@link #getFavoriteState favoriteState}.
					/// 
					/// Indicates whether “Favorite” is active
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="bFavoriteState">New value for property <code>favoriteState</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ActionBar setFavoriteState(bool bFavoriteState);

					#endregion

					#region Methods for Property updateState

					/// <summary>
					/// Gets current value of property {@link #getUpdateState updateState}.
					/// 
					/// Indicates whether “Update” is active
					/// </summary>
					/// <returns>Value of property <code>updateState</code></returns>
					public extern virtual bool getUpdateState();

					/// <summary>
					/// Sets a new value for property {@link #getUpdateState updateState}.
					/// 
					/// Indicates whether “Update” is active
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="bUpdateState">New value for property <code>updateState</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ActionBar setUpdateState(bool bUpdateState);

					#endregion

					#region Methods for Property thingIconURI

					/// <summary>
					/// Gets current value of property {@link #getThingIconURI thingIconURI}.
					/// 
					/// The thing icon uri. Icon will be displayed in Feeder
					/// </summary>
					/// <returns>Value of property <code>thingIconURI</code></returns>
					public extern virtual sap.ui.core.URI getThingIconURI();

					/// <summary>
					/// Sets a new value for property {@link #getThingIconURI thingIconURI}.
					/// 
					/// The thing icon uri. Icon will be displayed in Feeder
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sThingIconURI">New value for property <code>thingIconURI</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ActionBar setThingIconURI(sap.ui.core.URI sThingIconURI);

					#endregion

					#region Methods for Property alwaysShowMoreMenu

					/// <summary>
					/// Gets current value of property {@link #getAlwaysShowMoreMenu alwaysShowMoreMenu}.
					/// 
					/// If true, business actions are rendered as menu items of the 'More' menu button. Otherwise, 'More' menu button is only displayed for overflow and business actions are rendered as inidividual buttons.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>alwaysShowMoreMenu</code></returns>
					public extern virtual bool getAlwaysShowMoreMenu();

					/// <summary>
					/// Sets a new value for property {@link #getAlwaysShowMoreMenu alwaysShowMoreMenu}.
					/// 
					/// If true, business actions are rendered as menu items of the 'More' menu button. Otherwise, 'More' menu button is only displayed for overflow and business actions are rendered as inidividual buttons.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bAlwaysShowMoreMenu">New value for property <code>alwaysShowMoreMenu</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ActionBar setAlwaysShowMoreMenu(bool bAlwaysShowMoreMenu);

					#endregion

					#region Methods for Property showUpdate

					/// <summary>
					/// Gets current value of property {@link #getShowUpdate showUpdate}.
					/// 
					/// Indicates whether social action “Update” is shown, default is ‘true’
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>showUpdate</code></returns>
					public extern virtual bool getShowUpdate();

					/// <summary>
					/// Sets a new value for property {@link #getShowUpdate showUpdate}.
					/// 
					/// Indicates whether social action “Update” is shown, default is ‘true’
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bShowUpdate">New value for property <code>showUpdate</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ActionBar setShowUpdate(bool bShowUpdate);

					#endregion

					#region Methods for Property showFollow

					/// <summary>
					/// Gets current value of property {@link #getShowFollow showFollow}.
					/// 
					/// Indicates whether social action “Follow” is shown, default is ‘true’
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>showFollow</code></returns>
					public extern virtual bool getShowFollow();

					/// <summary>
					/// Sets a new value for property {@link #getShowFollow showFollow}.
					/// 
					/// Indicates whether social action “Follow” is shown, default is ‘true’
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bShowFollow">New value for property <code>showFollow</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ActionBar setShowFollow(bool bShowFollow);

					#endregion

					#region Methods for Property showFlag

					/// <summary>
					/// Gets current value of property {@link #getShowFlag showFlag}.
					/// 
					/// Indicates whether social action “Mark for Follow Up” is shown, default is ‘true’
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>showFlag</code></returns>
					public extern virtual bool getShowFlag();

					/// <summary>
					/// Sets a new value for property {@link #getShowFlag showFlag}.
					/// 
					/// Indicates whether social action “Mark for Follow Up” is shown, default is ‘true’
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bShowFlag">New value for property <code>showFlag</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ActionBar setShowFlag(bool bShowFlag);

					#endregion

					#region Methods for Property showFavorite

					/// <summary>
					/// Gets current value of property {@link #getShowFavorite showFavorite}.
					/// 
					/// Indicates whether social action “Favorite” is shown, default is ‘true’
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>showFavorite</code></returns>
					public extern virtual bool getShowFavorite();

					/// <summary>
					/// Sets a new value for property {@link #getShowFavorite showFavorite}.
					/// 
					/// Indicates whether social action “Favorite” is shown, default is ‘true’
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bShowFavorite">New value for property <code>showFavorite</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ActionBar setShowFavorite(bool bShowFavorite);

					#endregion

					#region Methods for Property showOpen

					/// <summary>
					/// Gets current value of property {@link #getShowOpen showOpen}.
					/// 
					/// Indicates whether social action “Open” is shown, default is ‘true’
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>showOpen</code></returns>
					public extern virtual bool getShowOpen();

					/// <summary>
					/// Sets a new value for property {@link #getShowOpen showOpen}.
					/// 
					/// Indicates whether social action “Open” is shown, default is ‘true’
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bShowOpen">New value for property <code>showOpen</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ActionBar setShowOpen(bool bShowOpen);

					#endregion

					#region Methods for Property dividerWidth

					/// <summary>
					/// Gets current value of property {@link #getDividerWidth dividerWidth}.
					/// 
					/// The minimum width of ActionBar's the social actions part: business action controls have to be rendered outside this area
					/// </summary>
					/// <returns>Value of property <code>dividerWidth</code></returns>
					public extern virtual sap.ui.core.CSSSize getDividerWidth();

					/// <summary>
					/// Sets a new value for property {@link #getDividerWidth dividerWidth}.
					/// 
					/// The minimum width of ActionBar's the social actions part: business action controls have to be rendered outside this area
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sDividerWidth">New value for property <code>dividerWidth</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ActionBar setDividerWidth(sap.ui.core.CSSSize sDividerWidth);

					#endregion

					#region Methods for Aggregation businessActions

					/// <summary>
					/// Gets content of aggregation {@link #getBusinessActions businessActions}.
					/// 
					/// Displayed on the actionBar's right hand-side, either as menu item under 'More' or as individual buttons
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.ux3.ThingAction[] getBusinessActions();

					/// <summary>
					/// Checks for the provided <code>sap.ui.ux3.ThingAction</code> in the aggregation {@link #getBusinessActions businessActions}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oBusinessAction">The businessAction whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfBusinessAction(sap.ui.ux3.ThingAction oBusinessAction);

					#endregion

					#region Methods for Aggregation _businessActionButtons

					#endregion

					#region Methods for Aggregation _socialActions

					#endregion

					#region Methods for Event actionSelected

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:actionSelected actionSelected} event of this <code>sap.ui.ux3.ActionBar</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.ActionBar</code> itself.
					/// 
					/// Fired when any of the social action’s toolbar buttons except ‘Update’ or any of the business action’s menu items resp. buttons is pressed. The selected action can be identified by its id and newState (the latter if applicable only) ‘Follow’ button + menu: id: follow, newState: Follow/Hold/Default ‘Mark for follow up’ button: id: flag, newState: true/false ‘Favorite’ button: id: favorite, newState: true/false ‘Open Thing Inspector’ button id: open Business Actions: id: the ThingAction id
					/// 
					/// For ‘Update’, please refer to event ‘feedSubmit’
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.ActionBar</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ActionBar attachActionSelected(object oData, sap.ui.ux3.ActionSelectedDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:actionSelected actionSelected} event of this <code>sap.ui.ux3.ActionBar</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.ActionBar</code> itself.
					/// 
					/// Fired when any of the social action’s toolbar buttons except ‘Update’ or any of the business action’s menu items resp. buttons is pressed. The selected action can be identified by its id and newState (the latter if applicable only) ‘Follow’ button + menu: id: follow, newState: Follow/Hold/Default ‘Mark for follow up’ button: id: flag, newState: true/false ‘Favorite’ button: id: favorite, newState: true/false ‘Open Thing Inspector’ button id: open Business Actions: id: the ThingAction id
					/// 
					/// For ‘Update’, please refer to event ‘feedSubmit’
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ActionBar attachActionSelected(object oData, sap.ui.ux3.ActionSelectedDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:actionSelected actionSelected} event of this <code>sap.ui.ux3.ActionBar</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.ActionBar</code> itself.
					/// 
					/// Fired when any of the social action’s toolbar buttons except ‘Update’ or any of the business action’s menu items resp. buttons is pressed. The selected action can be identified by its id and newState (the latter if applicable only) ‘Follow’ button + menu: id: follow, newState: Follow/Hold/Default ‘Mark for follow up’ button: id: flag, newState: true/false ‘Favorite’ button: id: favorite, newState: true/false ‘Open Thing Inspector’ button id: open Business Actions: id: the ThingAction id
					/// 
					/// For ‘Update’, please refer to event ‘feedSubmit’
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ActionBar attachActionSelected(sap.ui.ux3.ActionSelectedDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:actionSelected actionSelected} event of this <code>sap.ui.ux3.ActionBar</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.ActionBar</code> itself.
					/// 
					/// Fired when any of the social action’s toolbar buttons except ‘Update’ or any of the business action’s menu items resp. buttons is pressed. The selected action can be identified by its id and newState (the latter if applicable only) ‘Follow’ button + menu: id: follow, newState: Follow/Hold/Default ‘Mark for follow up’ button: id: flag, newState: true/false ‘Favorite’ button: id: favorite, newState: true/false ‘Open Thing Inspector’ button id: open Business Actions: id: the ThingAction id
					/// 
					/// For ‘Update’, please refer to event ‘feedSubmit’
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.ActionBar</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ActionBar attachActionSelected(sap.ui.ux3.ActionSelectedDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:actionSelected actionSelected} event of this <code>sap.ui.ux3.ActionBar</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ActionBar detachActionSelected(sap.ui.ux3.ActionSelectedDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:actionSelected actionSelected} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ActionBar fireActionSelected(sap.ui.ux3.ActionSelectedInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:actionSelected actionSelected} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ActionBar fireActionSelected();

					#endregion

					#region Methods for Event feedSubmit

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:feedSubmit feedSubmit} event of this <code>sap.ui.ux3.ActionBar</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.ActionBar</code> itself.
					/// 
					/// Fired when a new feed entry is submitted.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.ActionBar</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ActionBar attachFeedSubmit(object oData, sap.ui.ux3.SubmitDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:feedSubmit feedSubmit} event of this <code>sap.ui.ux3.ActionBar</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.ActionBar</code> itself.
					/// 
					/// Fired when a new feed entry is submitted.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ActionBar attachFeedSubmit(object oData, sap.ui.ux3.SubmitDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:feedSubmit feedSubmit} event of this <code>sap.ui.ux3.ActionBar</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.ActionBar</code> itself.
					/// 
					/// Fired when a new feed entry is submitted.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ActionBar attachFeedSubmit(sap.ui.ux3.SubmitDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:feedSubmit feedSubmit} event of this <code>sap.ui.ux3.ActionBar</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.ActionBar</code> itself.
					/// 
					/// Fired when a new feed entry is submitted.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.ActionBar</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ActionBar attachFeedSubmit(sap.ui.ux3.SubmitDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:feedSubmit feedSubmit} event of this <code>sap.ui.ux3.ActionBar</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ActionBar detachFeedSubmit(sap.ui.ux3.SubmitDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:feedSubmit feedSubmit} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ActionBar fireFeedSubmit(sap.ui.ux3.SubmitInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:feedSubmit feedSubmit} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ActionBar fireFeedSubmit();

					#endregion

					#region Other methods

					/// <summary>
					/// Closes all popups which might be opened as ActionBar children These are the more- and follow menu and the feeder popup
					/// </summary>
					public extern virtual void closePopups();

					/// <summary>
					/// Creates a new subclass of class sap.ui.ux3.ActionBar with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.ux3.ActionBar with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.ux3.ActionBar with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.ux3.ActionBar.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					/// <summary>
					/// Checks whether the control is still valid (is in the DOM). ActionBar instance is rendered if and only if 'isActive' returns 'true'. This check is called implicitely by the rendere, MUST not be removed.
					/// </summary>
					/// <returns>True if the control is still in the active DOM</returns>
					public extern virtual bool isActive();

					#endregion

					#endregion

				}
			}
		}
	}
}
