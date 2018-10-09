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
			/// <summary>
			/// Controls that implement the SAP User Experience (UX) Guidelines 3.0
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.ui.ux3")]
			public static partial class ux3
			{
				#region Typed Parameters

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class ChangeInfo
				{
					/// <summary>
					/// Current search string.
					/// </summary>
					public string newValue;

				}

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class ActionSelectedInfo
				{
					/// <summary>
					/// Id of selected ThingAction
					/// </summary>
					public string id;

					/// <summary>
					/// Selected ThingAction
					/// </summary>
					public sap.ui.ux3.ThingAction action;

					/// <summary>
					/// New State of the selected action.Only filled if the respective action maintains a state property, for example 'FollowUp' or 'Favorite'
					/// </summary>
					public string newState;

				}

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class SubmitInfo
				{
					/// <summary>
					/// Feed text
					/// </summary>
					public string text;

				}

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class Info
				{
					/// <summary>
					/// The ID of the Overlay instance.
					/// </summary>
					public string id;

				}

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class SelectedInfo
				{
					/// <summary>
					/// The id of the workset item that has been newly selected by the user. If a top-level item has been clicked which has sub-items, the ID of the currently active sub-item (/leaf) is given.
					/// </summary>
					public string id;

					/// <summary>
					/// The selected NavigationItem
					/// </summary>
					public sap.ui.ux3.NavigationItem item;

					/// <summary>
					/// The key of the selected NavigationItem (or null if there is no key)
					/// </summary>
					public string key;

				}

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class ThingSelectInfo
				{
					/// <summary>
					/// Id of selected action
					/// </summary>
					public string id;

					/// <summary>
					/// Selected Thing Action
					/// </summary>
					public sap.ui.ux3.ThingAction action;

				}

				#endregion

				#region Delegates

				public delegate void ChangeDelegate(sap.ui.@base.Event<sap.ui.ux3.ChangeInfo> oEvent, object oData);

				public delegate void ActionSelectedDelegate(sap.ui.@base.Event<sap.ui.ux3.ActionSelectedInfo> oEvent, object oData);

				public delegate void SubmitDelegate(sap.ui.@base.Event<sap.ui.ux3.SubmitInfo> oEvent, object oData);

				public delegate void Delegate(sap.ui.@base.Event<sap.ui.ux3.Info> oEvent, object oData);

				public delegate void SelectedDelegate(sap.ui.@base.Event<sap.ui.ux3.SelectedInfo> oEvent, object oData);

				public delegate void ThingSelectDelegate(sap.ui.@base.Event<sap.ui.ux3.ThingSelectInfo> oEvent, object oData);

				#endregion

				#region Fields

				/// <summary>
				/// Experimental implementation of visual Ux3 Shell personalization / branding.
				/// 
				/// DO NOT USE PRODUCTIVELY!!!
				/// 
				/// Being completely non-generic as of now, this is supposed to facilitate discussions with Ux about the personalization capabilities. Once that concept is more final, we can go for a cleaner implementation, considering the number of configurable properties etc.
				/// </summary>
				public static object ShellPersonalization;

				#endregion

				/// <summary>
				/// Defines the order of the sub lists of a list in the ExactBrowser.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.ux3.ExactOrder")]
				public enum ExactOrder
				{
					/// <summary>
					/// The order of the sub lists is defined by order of the defined sub attributes.
					/// </summary>
					Fixed,
					/// <summary>
					/// The order of the sub lists is defined by the selection order of the user.
					/// </summary>
					Select,
				}
				/// <summary>
				/// Type of a Feeder.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.ux3.FeederType")]
				public enum FeederType
				{
					/// <summary>
					/// comment feeder (small)
					/// </summary>
					Comment,
					/// <summary>
					/// large Feeder
					/// </summary>
					Large,
					/// <summary>
					/// medium feeder
					/// </summary>
					Medium,
				}
				/// <summary>
				/// Marker interface for controls which are suitable as view rendering for a DataSet.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.ux3.DataSetView")]
				public partial interface DataSetView
				{
				}
				/// <summary>
				/// Available shell design types.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.ux3.ShellDesignType")]
				public enum ShellDesignType
				{
					/// <summary>
					/// An even lighter design. It borrows most of its properties from the Light design and just changes a few details like the header colors in order to have a blue design within gold reflection.
					/// </summary>
					Crystal,
					/// <summary>
					/// A lighter design. Should be used in combination with the Standard header type.
					/// </summary>
					Light,
					/// <summary>
					/// The standard Shell design (dark).
					/// </summary>
					Standard,
				}
				/// <summary>
				/// Available shell header display types.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.ux3.ShellHeaderType")]
				public enum ShellHeaderType
				{
					/// <summary>
					/// Only the branding area is visible. Top-level navigation bar, header items, title and icon are not shown.
					/// </summary>
					BrandOnly,
					/// <summary>
					/// Like the Standard Area but without top-level navigation bar.
					/// </summary>
					NoNavigation,
					/// <summary>
					/// Like the Standard Area but with a leaner top-level navigation bar.
					/// </summary>
					SlimNavigation,
					/// <summary>
					/// The standard Shell header.
					/// </summary>
					Standard,
				}
				/// <summary>
				/// Defines the states of the follow action
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.ux3.FollowActionState")]
				public enum FollowActionState
				{
					/// <summary>
					/// default state
					/// </summary>
					Default,
					/// <summary>
					/// follow state
					/// </summary>
					Follow,
					/// <summary>
					/// hold state
					/// </summary>
					Hold,
				}
				/// <summary>
				/// VisibleItemCountMode of the FacetFilter defines if the FacetFilter takes the whole available height (Auto) in the surrounding container, or is so high as needed to show 5 Items ("Fixed " - default).
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.ux3.VisibleItemCountMode")]
				public enum VisibleItemCountMode
				{
					/// <summary>
					/// The FacetFilter automatically fills the height of the surrounding container. The visibleItemCount property is automatically changed accordingly.
					/// </summary>
					Auto,
					/// <summary>
					/// The FacetFilter always has as many items in the FacetFilterList as defined in the visibleItemCount property.
					/// </summary>
					Fixed,
				}
				/// <summary>
				/// This entries are used to set the visibility status of a NotificationBar
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.ux3.NotificationBarStatus")]
				public enum NotificationBarStatus
				{
					/// <summary>
					/// Default height for the bar
					/// </summary>
					Default,
					/// <summary>
					/// Bar should be maximized
					/// </summary>
					Max,
					/// <summary>
					/// Bar should be minimized
					/// </summary>
					Min,
					/// <summary>
					/// Bar should not be visible
					/// </summary>
					None,
				}
				/// <summary>
				/// Available ThingViewer header display types.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.ux3.ThingViewerHeaderType")]
				public enum ThingViewerHeaderType
				{
					/// <summary>
					/// The header content is displayed horizontally above the facet content
					/// </summary>
					Horizontal,
					/// <summary>
					/// The standard ThingViewer header.
					/// </summary>
					Standard,
				}
				/// <summary>
				/// Enumeration of available standard actions for 'sap.ui.ux3.ActionBar'. To be used as parameters for function 'sap.ui.ux3.ActionBar.getSocialAction'.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.ux3.ActionBarSocialActions")]
				public enum ActionBarSocialActions
				{
					/// <summary>
					/// Standards action 'Mark as Favorite'
					/// </summary>
					Favorite,
					/// <summary>
					/// Standard action 'Mark for Follow up'
					/// </summary>
					Flag,
					/// <summary>
					/// Standard action 'Follow/Unfollow'
					/// </summary>
					Follow,
					/// <summary>
					/// Standard action 'Open Thing Inspector'
					/// </summary>
					Open,
					/// <summary>
					/// Standard action 'Create an update' (Feed)
					/// </summary>
					Update,
				}
			}
		}
	}
}
