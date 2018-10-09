using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public static partial class sap
	{
		public static partial class f
		{
			public static partial class semantic
			{
				/// <summary>
				/// An enhanced {@link sap.f.DynamicPage}, that contains controls with semantic-specific meaning.
				/// 
				/// <h3>Overview</h3>
				/// 
				/// Content specified in the <code>sap.f.semantic.SemanticPage</code> aggregations is automatically positioned in dedicated sections of the title or the footer of the page, depending on the control's semantics.
				/// 
				/// The actions in the <code>SemanticPage</code> title are grouped to text actions or icon actions. When an aggregation is set, the actions appear in the following predefined order (from left to right):
				/// 
				/// <ul>Text actions: <li>The main semantic text action - <code>titleMainAction</code></li> <li>Any custom text actions - <code>titleCustomTextActions</code></li> <li>The semantic text actions - <code>editAction</code>, <code>deleteAction</code>, <code>copyAction</code> and <code>addAction</code></li></ul>
				/// 
				/// <ul>Icon actions: <li>Any custom icon actions - <code>titleCustomIconActions</code></li> <li>The simple semantic icon actions - <code>favoriteAction</code> and <code>flagAction</code></li> <li>The share menu semantic icon actions as a drop-down list with the following order: <ul><li><code>sendEmailAction</code></li> <li><code>discussInJamAction</code></li> <li><code>shareInJamAction</code></li> <li><code>sendMessageAction</code></li> <li><code>printAction</code></li> <li>Any <code>customShareActions</code></li></ul></li> <li>The navigation semantic actions - <code>fullScreenAction</code>, <code>exitFullScreenAction</code>, and <code>closeAction</li></code></ul>
				/// 
				/// The actions in the <code>SemanticPage</code> footer are positioned either on its left or right area and have the following predefined order:
				/// 
				/// <ul>Footer left area: <li>The semantic text action - <code>messagesIndicator</code></li> <li>The semantic label - <code>draftIndicator</code></li></ul>
				/// 
				/// <ul>Footer right area: <li>The main semantic text action - <code>footerMainAction</code></li> <li>The semantic text actions - <code>positiveAction</code> and <code>negativeAction</code></li> <li>Any custom text actions - <code>footerCustomActions</code></li></ul>
				/// 
				/// <h3>Usage</h3>
				/// 
				/// Using the <code>SemanticPage</code> facilitates the implementation of the SAP Fiori 2.0 design guidelines.
				/// 
				/// <h3>Responsive behavior</h3>
				/// 
				/// The responsive behavior of the <code>SemanticPage</code> depends on the behavior of the content that is displayed.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.f.semantic.SemanticPage")]
				public partial class SemanticPage : sap.ui.core.Control
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
						/// Determines whether the header is expanded.
						/// 
						/// The header can be also expanded/collapsed by user interaction, which requires the property to be internally mutated by the control to reflect the changed state.
						/// 
						/// <b>Note:</b> Please be aware, that initially collapsed header state is not supported, so <code>headerExpanded</code> should not be set to <code>false</code> when initializing the control.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> headerExpanded;

						/// <summary>
						/// Determines whether the header is pinnable.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> headerPinnable;

						/// <summary>
						/// Preserves the current header state when scrolling.
						/// 
						/// For example, if the user expands the header by clicking on the title and then scrolls down the page, the header will remain expanded.
						/// 
						/// <b>Note:</b> Based on internal rules, the value of the property is not always taken into account - for example, when the control is rendered on tablet or mobile and the title and the header are with height larger than a given threshold.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> preserveHeaderStateOnScroll;

						/// <summary>
						/// Determines whether the user can switch between the expanded/collapsed states of the header by clicking on the title.
						/// 
						/// If set to <code>false</code>, the title is not clickable and the application must provide other means for expanding/collapsing the header, if necessary.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> toggleHeaderOnTitleClick;

						/// <summary>
						/// Determines whether the footer is visible.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showFooter;

						/// <summary>
						/// Determines which of the title areas (Begin, Middle) is primary.
						/// 
						/// <b>Note:</b> The primary area is shrinking at a lower rate, remaining visible as long as it can.
						/// </summary>
						public Union<sap.f.DynamicPageTitleArea, string, sap.ui.@base.ManagedObject.BindPropertyInfo> titlePrimaryArea;

						/// <summary>
						/// The <code>SemanticPage</code> heading.
						/// 
						/// A typical usage is the <code>sap.m.Title</code> or any other UI5 control, that serves as a heading for an object.
						/// 
						/// <b>Note:</b> The control will be placed in the title`s leftmost area.
						/// </summary>
						public Union<sap.ui.core.Control, string, sap.ui.@base.ManagedObject.BindAggregationInfo> titleHeading;

						/// <summary>
						/// The <code>SemanticPage</code> breadcrumbs.
						/// 
						/// A typical usage is the <code>sap.m.Breadcrumbs</code> control or any other UI5 control, that implements the <code>sap.m.IBreadcrumbs</code> interface.
						/// 
						/// <b>Note:</b> The control will be placed in the title`s top-left area.
						/// </summary>
						public Union<sap.m.IBreadcrumbs, string, sap.ui.@base.ManagedObject.BindAggregationInfo> titleBreadcrumbs;

						/// <summary>
						/// The content, displayed in the title, when the header is in collapsed state.
						/// 
						/// <b>Note:</b> The controls will be placed in the title`s left area, under the <code>titleHeading</code> aggregation.
						/// </summary>
						public Union<sap.ui.core.Control[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> titleSnappedContent;

						/// <summary>
						/// The content,displayed in the title, when the header is in expanded state.
						/// 
						/// <b>Note:</b> The controls will be placed in the title`s left area, under the <code>titleHeading</code> aggregation.
						/// </summary>
						public Union<sap.ui.core.Control[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> titleExpandedContent;

						/// <summary>
						/// The content, displayed in the title.
						/// 
						/// <b>Note:</b> The controls will be placed in the middle area.
						/// </summary>
						public Union<sap.ui.core.Control[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> titleContent;

						/// <summary>
						/// A semantic-specific button which is placed in the <code>SemanticPage</code> title as first action.
						/// </summary>
						public Union<sap.f.semantic.TitleMainAction, string, sap.ui.@base.ManagedObject.BindAggregationInfo> titleMainAction;

						/// <summary>
						/// A semantic-specific button which is placed in the <code>TextActions</code> area of the <code>SemanticPage</code> title.
						/// </summary>
						public Union<sap.f.semantic.EditAction, string, sap.ui.@base.ManagedObject.BindAggregationInfo> editAction;

						/// <summary>
						/// A semantic-specific button which is placed in the <code>TextActions</code> area of the <code>SemanticPage</code> title.
						/// </summary>
						public Union<sap.f.semantic.DeleteAction, string, sap.ui.@base.ManagedObject.BindAggregationInfo> deleteAction;

						/// <summary>
						/// A semantic-specific button which is placed in the <code>TextActions</code> area of the <code>SemanticPage</code> title.
						/// </summary>
						public Union<sap.f.semantic.CopyAction, string, sap.ui.@base.ManagedObject.BindAggregationInfo> copyAction;

						/// <summary>
						/// A semantic-specific button which is placed in the <code>TextActions</code> area of the <code>SemanticPage</code> title.
						/// </summary>
						public Union<sap.f.semantic.AddAction, string, sap.ui.@base.ManagedObject.BindAggregationInfo> addAction;

						/// <summary>
						/// A semantic-specific button which is placed in the <code>IconActions</code> area of the <code>SemanticPage</code> title.
						/// </summary>
						public Union<sap.f.semantic.FlagAction, string, sap.ui.@base.ManagedObject.BindAggregationInfo> flagAction;

						/// <summary>
						/// A semantic-specific button which is placed in the <code>IconActions</code> area of the <code>SemanticPage</code> title.
						/// </summary>
						public Union<sap.f.semantic.FavoriteAction, string, sap.ui.@base.ManagedObject.BindAggregationInfo> favoriteAction;

						/// <summary>
						/// A semantic-specific button which is placed in the <code>IconActions</code> area of the <code>SemanticPage</code> title.
						/// </summary>
						public Union<sap.f.semantic.FullScreenAction, string, sap.ui.@base.ManagedObject.BindAggregationInfo> fullScreenAction;

						/// <summary>
						/// A semantic-specific button which is placed in the <code>IconActions</code> area of the <code>SemanticPage</code> title.
						/// </summary>
						public Union<sap.f.semantic.ExitFullScreenAction, string, sap.ui.@base.ManagedObject.BindAggregationInfo> exitFullScreenAction;

						/// <summary>
						/// A semantic-specific button which is placed in the <code>IconActions</code> area of the <code>SemanticPage</code> title.
						/// </summary>
						public Union<sap.f.semantic.CloseAction, string, sap.ui.@base.ManagedObject.BindAggregationInfo> closeAction;

						/// <summary>
						/// The <code>titleCustomTextActions</code> are placed in the <code>TextActions</code> area of the <code>SemanticPage</code> title, right before the semantic text action.
						/// </summary>
						public Union<sap.m.Button[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> titleCustomTextActions;

						/// <summary>
						/// The <code>titleCustomIconActions</code> are placed in the <code>IconActions</code> area of the <code>SemanticPage</code> title, right before the semantic icon action.
						/// </summary>
						public Union<sap.m.OverflowToolbarButton[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> titleCustomIconActions;

						/// <summary>
						/// The header content.
						/// </summary>
						public Union<sap.ui.core.Control[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> headerContent;

						/// <summary>
						/// The <code>SemanticPage</code> content.
						/// </summary>
						public Union<sap.ui.core.Control, string, sap.ui.@base.ManagedObject.BindAggregationInfo> content;

						/// <summary>
						/// A semantic-specific button which is placed in the <code>FooterRight</code> area of the <code>SemanticPage</code> footer with default text value set to <code>Save</code>.
						/// </summary>
						public Union<sap.f.semantic.FooterMainAction, string, sap.ui.@base.ManagedObject.BindAggregationInfo> footerMainAction;

						/// <summary>
						/// A semantic-specific button which is placed in the <code>FooterLeft</code> area of the <code>SemanticPage</code> footer as a first action.
						/// </summary>
						public Union<sap.f.semantic.MessagesIndicator, string, sap.ui.@base.ManagedObject.BindAggregationInfo> messagesIndicator;

						/// <summary>
						/// A semantic-specific button which is placed in the <code>FooterLeft</code> area of the <code>SemanticPage</code> footer as a second action.
						/// </summary>
						public Union<sap.m.DraftIndicator, string, sap.ui.@base.ManagedObject.BindAggregationInfo> draftIndicator;

						/// <summary>
						/// A semantic-specific button which is placed in the <code>FooterRight</code> area of the <code>SemanticPage</code> footer with default text value set to <code>Accept</code>.
						/// </summary>
						public Union<sap.f.semantic.PositiveAction, string, sap.ui.@base.ManagedObject.BindAggregationInfo> positiveAction;

						/// <summary>
						/// A semantic-specific button which is placed in the <code>FooterRight</code> area of the <code>SemanticPage</code> footer with default text value set to <code>Reject</code>.
						/// </summary>
						public Union<sap.f.semantic.NegativeAction, string, sap.ui.@base.ManagedObject.BindAggregationInfo> negativeAction;

						/// <summary>
						/// The <code>footerCustomActions</code> are placed in the <code>FooterRight</code> area of the <code>SemanticPage</code> footer, right after the semantic footer actions.
						/// </summary>
						public Union<sap.m.Button[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> footerCustomActions;

						/// <summary>
						/// A semantic-specific button which is placed in the <code>ShareMenu</code> area of the <code>SemanticPage</code> title.
						/// </summary>
						public Union<sap.f.semantic.DiscussInJamAction, string, sap.ui.@base.ManagedObject.BindAggregationInfo> discussInJamAction;

						/// <summary>
						/// A button which is placed in the <code>ShareMenu</code> area of the <code>SemanticPage</code> title.
						/// </summary>
						public Union<sap.m.Button, string, sap.ui.@base.ManagedObject.BindAggregationInfo> saveAsTileAction;

						/// <summary>
						/// A semantic-specific button which is placed in the <code>ShareMenu</code> area of the <code>SemanticPage</code> title.
						/// </summary>
						public Union<sap.f.semantic.ShareInJamAction, string, sap.ui.@base.ManagedObject.BindAggregationInfo> shareInJamAction;

						/// <summary>
						/// A semantic-specific button which is placed in the <code>ShareMenu</code> area of the <code>SemanticPage</code> title.
						/// </summary>
						public Union<sap.f.semantic.SendMessageAction, string, sap.ui.@base.ManagedObject.BindAggregationInfo> sendMessageAction;

						/// <summary>
						/// A semantic-specific button which is placed in the <code>ShareMenu</code> area of the <code>SemanticPage</code> title.
						/// </summary>
						public Union<sap.f.semantic.SendEmailAction, string, sap.ui.@base.ManagedObject.BindAggregationInfo> sendEmailAction;

						/// <summary>
						/// A semantic-specific button which is placed in the <code>ShareMenu</code> area of the <code>SemanticPage</code> title.
						/// </summary>
						public Union<sap.f.semantic.PrintAction, string, sap.ui.@base.ManagedObject.BindAggregationInfo> printAction;

						/// <summary>
						/// The <code>customShareActions</code> are placed in the <code>ShareMenu</code> area of the <code>SemanticPage</code> title, right after the semantic actions.
						/// </summary>
						public Union<sap.m.Button[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> customShareActions;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new <code>SemanticPage</code>.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern SemanticPage(string sId, sap.f.semantic.SemanticPage.Settings mSettings);

					/// <summary>
					/// Constructor for a new <code>SemanticPage</code>.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					public extern SemanticPage(string sId);

					/// <summary>
					/// Constructor for a new <code>SemanticPage</code>.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern SemanticPage();

					/// <summary>
					/// Constructor for a new <code>SemanticPage</code>.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern SemanticPage(sap.f.semantic.SemanticPage.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property headerExpanded

					/// <summary>
					/// Gets current value of property {@link #getHeaderExpanded headerExpanded}.
					/// 
					/// Determines whether the header is expanded.
					/// 
					/// The header can be also expanded/collapsed by user interaction, which requires the property to be internally mutated by the control to reflect the changed state.
					/// 
					/// <b>Note:</b> Please be aware, that initially collapsed header state is not supported, so <code>headerExpanded</code> should not be set to <code>false</code> when initializing the control.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>headerExpanded</code></returns>
					public extern virtual bool getHeaderExpanded();

					/// <summary>
					/// Sets a new value for property {@link #getHeaderExpanded headerExpanded}.
					/// 
					/// Determines whether the header is expanded.
					/// 
					/// The header can be also expanded/collapsed by user interaction, which requires the property to be internally mutated by the control to reflect the changed state.
					/// 
					/// <b>Note:</b> Please be aware, that initially collapsed header state is not supported, so <code>headerExpanded</code> should not be set to <code>false</code> when initializing the control.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bHeaderExpanded">New value for property <code>headerExpanded</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage setHeaderExpanded(bool bHeaderExpanded);

					#endregion

					#region Methods for Property headerPinnable

					/// <summary>
					/// Gets current value of property {@link #getHeaderPinnable headerPinnable}.
					/// 
					/// Determines whether the header is pinnable.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>headerPinnable</code></returns>
					public extern virtual bool getHeaderPinnable();

					/// <summary>
					/// Sets a new value for property {@link #getHeaderPinnable headerPinnable}.
					/// 
					/// Determines whether the header is pinnable.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bHeaderPinnable">New value for property <code>headerPinnable</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage setHeaderPinnable(bool bHeaderPinnable);

					#endregion

					#region Methods for Property preserveHeaderStateOnScroll

					/// <summary>
					/// Gets current value of property {@link #getPreserveHeaderStateOnScroll preserveHeaderStateOnScroll}.
					/// 
					/// Preserves the current header state when scrolling.
					/// 
					/// For example, if the user expands the header by clicking on the title and then scrolls down the page, the header will remain expanded.
					/// 
					/// <b>Note:</b> Based on internal rules, the value of the property is not always taken into account - for example, when the control is rendered on tablet or mobile and the title and the header are with height larger than a given threshold.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>preserveHeaderStateOnScroll</code></returns>
					public extern virtual bool getPreserveHeaderStateOnScroll();

					/// <summary>
					/// Sets a new value for property {@link #getPreserveHeaderStateOnScroll preserveHeaderStateOnScroll}.
					/// 
					/// Preserves the current header state when scrolling.
					/// 
					/// For example, if the user expands the header by clicking on the title and then scrolls down the page, the header will remain expanded.
					/// 
					/// <b>Note:</b> Based on internal rules, the value of the property is not always taken into account - for example, when the control is rendered on tablet or mobile and the title and the header are with height larger than a given threshold.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bPreserveHeaderStateOnScroll">New value for property <code>preserveHeaderStateOnScroll</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage setPreserveHeaderStateOnScroll(bool bPreserveHeaderStateOnScroll);

					#endregion

					#region Methods for Property toggleHeaderOnTitleClick

					/// <summary>
					/// Gets current value of property {@link #getToggleHeaderOnTitleClick toggleHeaderOnTitleClick}.
					/// 
					/// Determines whether the user can switch between the expanded/collapsed states of the header by clicking on the title.
					/// 
					/// If set to <code>false</code>, the title is not clickable and the application must provide other means for expanding/collapsing the header, if necessary.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>toggleHeaderOnTitleClick</code></returns>
					public extern virtual bool getToggleHeaderOnTitleClick();

					/// <summary>
					/// Sets a new value for property {@link #getToggleHeaderOnTitleClick toggleHeaderOnTitleClick}.
					/// 
					/// Determines whether the user can switch between the expanded/collapsed states of the header by clicking on the title.
					/// 
					/// If set to <code>false</code>, the title is not clickable and the application must provide other means for expanding/collapsing the header, if necessary.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bToggleHeaderOnTitleClick">New value for property <code>toggleHeaderOnTitleClick</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage setToggleHeaderOnTitleClick(bool bToggleHeaderOnTitleClick);

					#endregion

					#region Methods for Property showFooter

					/// <summary>
					/// Gets current value of property {@link #getShowFooter showFooter}.
					/// 
					/// Determines whether the footer is visible.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>showFooter</code></returns>
					public extern virtual bool getShowFooter();

					/// <summary>
					/// Sets a new value for property {@link #getShowFooter showFooter}.
					/// 
					/// Determines whether the footer is visible.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bShowFooter">New value for property <code>showFooter</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage setShowFooter(bool bShowFooter);

					#endregion

					#region Methods for Property titlePrimaryArea

					/// <summary>
					/// Gets current value of property {@link #getTitlePrimaryArea titlePrimaryArea}.
					/// 
					/// Determines which of the title areas (Begin, Middle) is primary.
					/// 
					/// <b>Note:</b> The primary area is shrinking at a lower rate, remaining visible as long as it can.
					/// 
					/// Default value is <code>Begin</code>.
					/// </summary>
					/// <returns>Value of property <code>titlePrimaryArea</code></returns>
					public extern virtual sap.f.DynamicPageTitleArea getTitlePrimaryArea();

					/// <summary>
					/// Sets a new value for property {@link #getTitlePrimaryArea titlePrimaryArea}.
					/// 
					/// Determines which of the title areas (Begin, Middle) is primary.
					/// 
					/// <b>Note:</b> The primary area is shrinking at a lower rate, remaining visible as long as it can.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>Begin</code>.
					/// </summary>
					/// <param name="sTitlePrimaryArea">New value for property <code>titlePrimaryArea</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage setTitlePrimaryArea(sap.f.DynamicPageTitleArea sTitlePrimaryArea);

					#endregion

					#region Methods for Aggregation titleHeading

					/// <summary>
					/// Gets content of aggregation {@link #getTitleHeading titleHeading}.
					/// 
					/// The <code>SemanticPage</code> heading.
					/// 
					/// A typical usage is the <code>sap.m.Title</code> or any other UI5 control, that serves as a heading for an object.
					/// 
					/// <b>Note:</b> The control will be placed in the title`s leftmost area.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.Control getTitleHeading();

					/// <summary>
					/// Destroys the titleHeading in the aggregation {@link #getTitleHeading titleHeading}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage destroyTitleHeading();

					/// <summary>
					/// Sets the aggregated {@link #getTitleHeading titleHeading}.
					/// </summary>
					/// <param name="oTitleHeading">The titleHeading to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage setTitleHeading(sap.ui.core.Control oTitleHeading);

					#endregion

					#region Methods for Aggregation titleBreadcrumbs

					/// <summary>
					/// Gets content of aggregation {@link #getTitleBreadcrumbs titleBreadcrumbs}.
					/// 
					/// The <code>SemanticPage</code> breadcrumbs.
					/// 
					/// A typical usage is the <code>sap.m.Breadcrumbs</code> control or any other UI5 control, that implements the <code>sap.m.IBreadcrumbs</code> interface.
					/// 
					/// <b>Note:</b> The control will be placed in the title`s top-left area.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.m.IBreadcrumbs getTitleBreadcrumbs();

					/// <summary>
					/// Destroys the titleBreadcrumbs in the aggregation {@link #getTitleBreadcrumbs titleBreadcrumbs}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage destroyTitleBreadcrumbs();

					/// <summary>
					/// Sets the aggregated {@link #getTitleBreadcrumbs titleBreadcrumbs}.
					/// </summary>
					/// <param name="oTitleBreadcrumbs">The titleBreadcrumbs to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage setTitleBreadcrumbs(sap.m.IBreadcrumbs oTitleBreadcrumbs);

					#endregion

					#region Methods for Aggregation titleSnappedContent

					/// <summary>
					/// Gets content of aggregation {@link #getTitleSnappedContent titleSnappedContent}.
					/// 
					/// The content, displayed in the title, when the header is in collapsed state.
					/// 
					/// <b>Note:</b> The controls will be placed in the title`s left area, under the <code>titleHeading</code> aggregation.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.Control[] getTitleSnappedContent();

					/// <summary>
					/// Destroys all the titleSnappedContent in the aggregation {@link #getTitleSnappedContent titleSnappedContent}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage destroyTitleSnappedContent();

					/// <summary>
					/// Inserts a titleSnappedContent into the aggregation {@link #getTitleSnappedContent titleSnappedContent}.
					/// </summary>
					/// <param name="oTitleSnappedContent">The titleSnappedContent to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the titleSnappedContent should be inserted at; for a negative value of <code>iIndex</code>, the titleSnappedContent is inserted at position 0; for a value greater than the current size of the aggregation, the titleSnappedContent is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage insertTitleSnappedContent(sap.ui.core.Control oTitleSnappedContent, int iIndex);

					/// <summary>
					/// Adds some titleSnappedContent to the aggregation {@link #getTitleSnappedContent titleSnappedContent}.
					/// </summary>
					/// <param name="oTitleSnappedContent">The titleSnappedContent to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage addTitleSnappedContent(sap.ui.core.Control oTitleSnappedContent);

					/// <summary>
					/// Removes a titleSnappedContent from the aggregation {@link #getTitleSnappedContent titleSnappedContent}.
					/// </summary>
					/// <param name="vTitleSnappedContent">The titleSnappedContent to remove or its index or id</param>
					/// <returns>The removed titleSnappedContent or <code>null</code></returns>
					public extern virtual sap.ui.core.Control removeTitleSnappedContent(Union<int, string, sap.ui.core.Control> vTitleSnappedContent);

					/// <summary>
					/// Checks for the provided <code>sap.ui.core.Control</code> in the aggregation {@link #getTitleSnappedContent titleSnappedContent}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oTitleSnappedContent">The titleSnappedContent whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfTitleSnappedContent(sap.ui.core.Control oTitleSnappedContent);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getTitleSnappedContent titleSnappedContent}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.core.Control[] removeAllTitleSnappedContent();

					#endregion

					#region Methods for Aggregation titleExpandedContent

					/// <summary>
					/// Gets content of aggregation {@link #getTitleExpandedContent titleExpandedContent}.
					/// 
					/// The content,displayed in the title, when the header is in expanded state.
					/// 
					/// <b>Note:</b> The controls will be placed in the title`s left area, under the <code>titleHeading</code> aggregation.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.Control[] getTitleExpandedContent();

					/// <summary>
					/// Destroys all the titleExpandedContent in the aggregation {@link #getTitleExpandedContent titleExpandedContent}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage destroyTitleExpandedContent();

					/// <summary>
					/// Inserts a titleExpandedContent into the aggregation {@link #getTitleExpandedContent titleExpandedContent}.
					/// </summary>
					/// <param name="oTitleExpandedContent">The titleExpandedContent to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the titleExpandedContent should be inserted at; for a negative value of <code>iIndex</code>, the titleExpandedContent is inserted at position 0; for a value greater than the current size of the aggregation, the titleExpandedContent is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage insertTitleExpandedContent(sap.ui.core.Control oTitleExpandedContent, int iIndex);

					/// <summary>
					/// Adds some titleExpandedContent to the aggregation {@link #getTitleExpandedContent titleExpandedContent}.
					/// </summary>
					/// <param name="oTitleExpandedContent">The titleExpandedContent to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage addTitleExpandedContent(sap.ui.core.Control oTitleExpandedContent);

					/// <summary>
					/// Removes a titleExpandedContent from the aggregation {@link #getTitleExpandedContent titleExpandedContent}.
					/// </summary>
					/// <param name="vTitleExpandedContent">The titleExpandedContent to remove or its index or id</param>
					/// <returns>The removed titleExpandedContent or <code>null</code></returns>
					public extern virtual sap.ui.core.Control removeTitleExpandedContent(Union<int, string, sap.ui.core.Control> vTitleExpandedContent);

					/// <summary>
					/// Checks for the provided <code>sap.ui.core.Control</code> in the aggregation {@link #getTitleExpandedContent titleExpandedContent}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oTitleExpandedContent">The titleExpandedContent whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfTitleExpandedContent(sap.ui.core.Control oTitleExpandedContent);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getTitleExpandedContent titleExpandedContent}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.core.Control[] removeAllTitleExpandedContent();

					#endregion

					#region Methods for Aggregation titleContent

					/// <summary>
					/// Gets content of aggregation {@link #getTitleContent titleContent}.
					/// 
					/// The content, displayed in the title.
					/// 
					/// <b>Note:</b> The controls will be placed in the middle area.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.Control[] getTitleContent();

					/// <summary>
					/// Destroys all the titleContent in the aggregation {@link #getTitleContent titleContent}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage destroyTitleContent();

					/// <summary>
					/// Inserts a titleContent into the aggregation {@link #getTitleContent titleContent}.
					/// </summary>
					/// <param name="oTitleContent">The titleContent to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the titleContent should be inserted at; for a negative value of <code>iIndex</code>, the titleContent is inserted at position 0; for a value greater than the current size of the aggregation, the titleContent is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage insertTitleContent(sap.ui.core.Control oTitleContent, int iIndex);

					/// <summary>
					/// Adds some titleContent to the aggregation {@link #getTitleContent titleContent}.
					/// </summary>
					/// <param name="oTitleContent">The titleContent to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage addTitleContent(sap.ui.core.Control oTitleContent);

					/// <summary>
					/// Removes a titleContent from the aggregation {@link #getTitleContent titleContent}.
					/// </summary>
					/// <param name="vTitleContent">The titleContent to remove or its index or id</param>
					/// <returns>The removed titleContent or <code>null</code></returns>
					public extern virtual sap.ui.core.Control removeTitleContent(Union<int, string, sap.ui.core.Control> vTitleContent);

					/// <summary>
					/// Checks for the provided <code>sap.ui.core.Control</code> in the aggregation {@link #getTitleContent titleContent}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oTitleContent">The titleContent whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfTitleContent(sap.ui.core.Control oTitleContent);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getTitleContent titleContent}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.core.Control[] removeAllTitleContent();

					#endregion

					#region Methods for Aggregation titleMainAction

					/// <summary>
					/// Gets content of aggregation {@link #getTitleMainAction titleMainAction}.
					/// 
					/// A semantic-specific button which is placed in the <code>SemanticPage</code> title as first action.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.f.semantic.TitleMainAction getTitleMainAction();

					/// <summary>
					/// Destroys the titleMainAction in the aggregation {@link #getTitleMainAction titleMainAction}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage destroyTitleMainAction();

					/// <summary>
					/// Sets the aggregated {@link #getTitleMainAction titleMainAction}.
					/// </summary>
					/// <param name="oTitleMainAction">The titleMainAction to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage setTitleMainAction(sap.f.semantic.TitleMainAction oTitleMainAction);

					#endregion

					#region Methods for Aggregation editAction

					/// <summary>
					/// Gets content of aggregation {@link #getEditAction editAction}.
					/// 
					/// A semantic-specific button which is placed in the <code>TextActions</code> area of the <code>SemanticPage</code> title.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.f.semantic.EditAction getEditAction();

					/// <summary>
					/// Destroys the editAction in the aggregation {@link #getEditAction editAction}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage destroyEditAction();

					/// <summary>
					/// Sets the aggregated {@link #getEditAction editAction}.
					/// </summary>
					/// <param name="oEditAction">The editAction to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage setEditAction(sap.f.semantic.EditAction oEditAction);

					#endregion

					#region Methods for Aggregation deleteAction

					/// <summary>
					/// Gets content of aggregation {@link #getDeleteAction deleteAction}.
					/// 
					/// A semantic-specific button which is placed in the <code>TextActions</code> area of the <code>SemanticPage</code> title.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.f.semantic.DeleteAction getDeleteAction();

					/// <summary>
					/// Destroys the deleteAction in the aggregation {@link #getDeleteAction deleteAction}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage destroyDeleteAction();

					/// <summary>
					/// Sets the aggregated {@link #getDeleteAction deleteAction}.
					/// </summary>
					/// <param name="oDeleteAction">The deleteAction to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage setDeleteAction(sap.f.semantic.DeleteAction oDeleteAction);

					#endregion

					#region Methods for Aggregation copyAction

					/// <summary>
					/// Gets content of aggregation {@link #getCopyAction copyAction}.
					/// 
					/// A semantic-specific button which is placed in the <code>TextActions</code> area of the <code>SemanticPage</code> title.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.f.semantic.CopyAction getCopyAction();

					/// <summary>
					/// Destroys the copyAction in the aggregation {@link #getCopyAction copyAction}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage destroyCopyAction();

					/// <summary>
					/// Sets the aggregated {@link #getCopyAction copyAction}.
					/// </summary>
					/// <param name="oCopyAction">The copyAction to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage setCopyAction(sap.f.semantic.CopyAction oCopyAction);

					#endregion

					#region Methods for Aggregation addAction

					/// <summary>
					/// Gets content of aggregation {@link #getAddAction addAction}.
					/// 
					/// A semantic-specific button which is placed in the <code>TextActions</code> area of the <code>SemanticPage</code> title.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.f.semantic.AddAction getAddAction();

					/// <summary>
					/// Destroys the addAction in the aggregation {@link #getAddAction addAction}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage destroyAddAction();

					/// <summary>
					/// Sets the aggregated {@link #getAddAction addAction}.
					/// </summary>
					/// <param name="oAddAction">The addAction to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage setAddAction(sap.f.semantic.AddAction oAddAction);

					#endregion

					#region Methods for Aggregation flagAction

					/// <summary>
					/// Gets content of aggregation {@link #getFlagAction flagAction}.
					/// 
					/// A semantic-specific button which is placed in the <code>IconActions</code> area of the <code>SemanticPage</code> title.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.f.semantic.FlagAction getFlagAction();

					/// <summary>
					/// Destroys the flagAction in the aggregation {@link #getFlagAction flagAction}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage destroyFlagAction();

					/// <summary>
					/// Sets the aggregated {@link #getFlagAction flagAction}.
					/// </summary>
					/// <param name="oFlagAction">The flagAction to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage setFlagAction(sap.f.semantic.FlagAction oFlagAction);

					#endregion

					#region Methods for Aggregation favoriteAction

					/// <summary>
					/// Gets content of aggregation {@link #getFavoriteAction favoriteAction}.
					/// 
					/// A semantic-specific button which is placed in the <code>IconActions</code> area of the <code>SemanticPage</code> title.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.f.semantic.FavoriteAction getFavoriteAction();

					/// <summary>
					/// Destroys the favoriteAction in the aggregation {@link #getFavoriteAction favoriteAction}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage destroyFavoriteAction();

					/// <summary>
					/// Sets the aggregated {@link #getFavoriteAction favoriteAction}.
					/// </summary>
					/// <param name="oFavoriteAction">The favoriteAction to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage setFavoriteAction(sap.f.semantic.FavoriteAction oFavoriteAction);

					#endregion

					#region Methods for Aggregation fullScreenAction

					/// <summary>
					/// Gets content of aggregation {@link #getFullScreenAction fullScreenAction}.
					/// 
					/// A semantic-specific button which is placed in the <code>IconActions</code> area of the <code>SemanticPage</code> title.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.f.semantic.FullScreenAction getFullScreenAction();

					/// <summary>
					/// Destroys the fullScreenAction in the aggregation {@link #getFullScreenAction fullScreenAction}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage destroyFullScreenAction();

					/// <summary>
					/// Sets the aggregated {@link #getFullScreenAction fullScreenAction}.
					/// </summary>
					/// <param name="oFullScreenAction">The fullScreenAction to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage setFullScreenAction(sap.f.semantic.FullScreenAction oFullScreenAction);

					#endregion

					#region Methods for Aggregation exitFullScreenAction

					/// <summary>
					/// Gets content of aggregation {@link #getExitFullScreenAction exitFullScreenAction}.
					/// 
					/// A semantic-specific button which is placed in the <code>IconActions</code> area of the <code>SemanticPage</code> title.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.f.semantic.ExitFullScreenAction getExitFullScreenAction();

					/// <summary>
					/// Destroys the exitFullScreenAction in the aggregation {@link #getExitFullScreenAction exitFullScreenAction}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage destroyExitFullScreenAction();

					/// <summary>
					/// Sets the aggregated {@link #getExitFullScreenAction exitFullScreenAction}.
					/// </summary>
					/// <param name="oExitFullScreenAction">The exitFullScreenAction to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage setExitFullScreenAction(sap.f.semantic.ExitFullScreenAction oExitFullScreenAction);

					#endregion

					#region Methods for Aggregation closeAction

					/// <summary>
					/// Gets content of aggregation {@link #getCloseAction closeAction}.
					/// 
					/// A semantic-specific button which is placed in the <code>IconActions</code> area of the <code>SemanticPage</code> title.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.f.semantic.CloseAction getCloseAction();

					/// <summary>
					/// Destroys the closeAction in the aggregation {@link #getCloseAction closeAction}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage destroyCloseAction();

					/// <summary>
					/// Sets the aggregated {@link #getCloseAction closeAction}.
					/// </summary>
					/// <param name="oCloseAction">The closeAction to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage setCloseAction(sap.f.semantic.CloseAction oCloseAction);

					#endregion

					#region Methods for Aggregation titleCustomTextActions

					/// <summary>
					/// Gets content of aggregation {@link #getTitleCustomTextActions titleCustomTextActions}.
					/// 
					/// The <code>titleCustomTextActions</code> are placed in the <code>TextActions</code> area of the <code>SemanticPage</code> title, right before the semantic text action.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.m.Button[] getTitleCustomTextActions();

					/// <summary>
					/// Destroys all the titleCustomTextActions in the aggregation {@link #getTitleCustomTextActions titleCustomTextActions}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage destroyTitleCustomTextActions();

					/// <summary>
					/// Inserts a titleCustomTextAction into the aggregation {@link #getTitleCustomTextActions titleCustomTextActions}.
					/// </summary>
					/// <param name="oTitleCustomTextAction">The titleCustomTextAction to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the titleCustomTextAction should be inserted at; for a negative value of <code>iIndex</code>, the titleCustomTextAction is inserted at position 0; for a value greater than the current size of the aggregation, the titleCustomTextAction is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage insertTitleCustomTextAction(sap.m.Button oTitleCustomTextAction, int iIndex);

					/// <summary>
					/// Adds some titleCustomTextAction to the aggregation {@link #getTitleCustomTextActions titleCustomTextActions}.
					/// </summary>
					/// <param name="oTitleCustomTextAction">The titleCustomTextAction to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage addTitleCustomTextAction(sap.m.Button oTitleCustomTextAction);

					/// <summary>
					/// Removes a titleCustomTextAction from the aggregation {@link #getTitleCustomTextActions titleCustomTextActions}.
					/// </summary>
					/// <param name="vTitleCustomTextAction">The titleCustomTextAction to remove or its index or id</param>
					/// <returns>The removed titleCustomTextAction or <code>null</code></returns>
					public extern virtual sap.m.Button removeTitleCustomTextAction(Union<int, string, sap.m.Button> vTitleCustomTextAction);

					/// <summary>
					/// Checks for the provided <code>sap.m.Button</code> in the aggregation {@link #getTitleCustomTextActions titleCustomTextActions}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oTitleCustomTextAction">The titleCustomTextAction whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfTitleCustomTextAction(sap.m.Button oTitleCustomTextAction);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getTitleCustomTextActions titleCustomTextActions}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.m.Button[] removeAllTitleCustomTextActions();

					#endregion

					#region Methods for Aggregation titleCustomIconActions

					/// <summary>
					/// Gets content of aggregation {@link #getTitleCustomIconActions titleCustomIconActions}.
					/// 
					/// The <code>titleCustomIconActions</code> are placed in the <code>IconActions</code> area of the <code>SemanticPage</code> title, right before the semantic icon action.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.m.OverflowToolbarButton[] getTitleCustomIconActions();

					/// <summary>
					/// Destroys all the titleCustomIconActions in the aggregation {@link #getTitleCustomIconActions titleCustomIconActions}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage destroyTitleCustomIconActions();

					/// <summary>
					/// Inserts a titleCustomIconAction into the aggregation {@link #getTitleCustomIconActions titleCustomIconActions}.
					/// </summary>
					/// <param name="oTitleCustomIconAction">The titleCustomIconAction to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the titleCustomIconAction should be inserted at; for a negative value of <code>iIndex</code>, the titleCustomIconAction is inserted at position 0; for a value greater than the current size of the aggregation, the titleCustomIconAction is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage insertTitleCustomIconAction(sap.m.OverflowToolbarButton oTitleCustomIconAction, int iIndex);

					/// <summary>
					/// Adds some titleCustomIconAction to the aggregation {@link #getTitleCustomIconActions titleCustomIconActions}.
					/// </summary>
					/// <param name="oTitleCustomIconAction">The titleCustomIconAction to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage addTitleCustomIconAction(sap.m.OverflowToolbarButton oTitleCustomIconAction);

					/// <summary>
					/// Removes a titleCustomIconAction from the aggregation {@link #getTitleCustomIconActions titleCustomIconActions}.
					/// </summary>
					/// <param name="vTitleCustomIconAction">The titleCustomIconAction to remove or its index or id</param>
					/// <returns>The removed titleCustomIconAction or <code>null</code></returns>
					public extern virtual sap.m.OverflowToolbarButton removeTitleCustomIconAction(Union<int, string, sap.m.OverflowToolbarButton> vTitleCustomIconAction);

					/// <summary>
					/// Checks for the provided <code>sap.m.OverflowToolbarButton</code> in the aggregation {@link #getTitleCustomIconActions titleCustomIconActions}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oTitleCustomIconAction">The titleCustomIconAction whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfTitleCustomIconAction(sap.m.OverflowToolbarButton oTitleCustomIconAction);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getTitleCustomIconActions titleCustomIconActions}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.m.OverflowToolbarButton[] removeAllTitleCustomIconActions();

					#endregion

					#region Methods for Aggregation headerContent

					/// <summary>
					/// Gets content of aggregation {@link #getHeaderContent headerContent}.
					/// 
					/// The header content.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.Control[] getHeaderContent();

					/// <summary>
					/// Destroys all the headerContent in the aggregation {@link #getHeaderContent headerContent}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage destroyHeaderContent();

					/// <summary>
					/// Inserts a headerContent into the aggregation {@link #getHeaderContent headerContent}.
					/// </summary>
					/// <param name="oHeaderContent">The headerContent to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the headerContent should be inserted at; for a negative value of <code>iIndex</code>, the headerContent is inserted at position 0; for a value greater than the current size of the aggregation, the headerContent is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage insertHeaderContent(sap.ui.core.Control oHeaderContent, int iIndex);

					/// <summary>
					/// Adds some headerContent to the aggregation {@link #getHeaderContent headerContent}.
					/// </summary>
					/// <param name="oHeaderContent">The headerContent to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage addHeaderContent(sap.ui.core.Control oHeaderContent);

					/// <summary>
					/// Removes a headerContent from the aggregation {@link #getHeaderContent headerContent}.
					/// </summary>
					/// <param name="vHeaderContent">The headerContent to remove or its index or id</param>
					/// <returns>The removed headerContent or <code>null</code></returns>
					public extern virtual sap.ui.core.Control removeHeaderContent(Union<int, string, sap.ui.core.Control> vHeaderContent);

					/// <summary>
					/// Checks for the provided <code>sap.ui.core.Control</code> in the aggregation {@link #getHeaderContent headerContent}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oHeaderContent">The headerContent whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfHeaderContent(sap.ui.core.Control oHeaderContent);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getHeaderContent headerContent}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.core.Control[] removeAllHeaderContent();

					#endregion

					#region Methods for Aggregation content

					/// <summary>
					/// Gets content of aggregation {@link #getContent content}.
					/// 
					/// The <code>SemanticPage</code> content.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.Control getContent();

					/// <summary>
					/// Destroys the content in the aggregation {@link #getContent content}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage destroyContent();

					/// <summary>
					/// Sets the aggregated {@link #getContent content}.
					/// </summary>
					/// <param name="oContent">The content to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage setContent(sap.ui.core.Control oContent);

					#endregion

					#region Methods for Aggregation footerMainAction

					/// <summary>
					/// Gets content of aggregation {@link #getFooterMainAction footerMainAction}.
					/// 
					/// A semantic-specific button which is placed in the <code>FooterRight</code> area of the <code>SemanticPage</code> footer with default text value set to <code>Save</code>.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.f.semantic.FooterMainAction getFooterMainAction();

					/// <summary>
					/// Destroys the footerMainAction in the aggregation {@link #getFooterMainAction footerMainAction}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage destroyFooterMainAction();

					/// <summary>
					/// Sets the aggregated {@link #getFooterMainAction footerMainAction}.
					/// </summary>
					/// <param name="oFooterMainAction">The footerMainAction to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage setFooterMainAction(sap.f.semantic.FooterMainAction oFooterMainAction);

					#endregion

					#region Methods for Aggregation messagesIndicator

					/// <summary>
					/// Gets content of aggregation {@link #getMessagesIndicator messagesIndicator}.
					/// 
					/// A semantic-specific button which is placed in the <code>FooterLeft</code> area of the <code>SemanticPage</code> footer as a first action.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.f.semantic.MessagesIndicator getMessagesIndicator();

					/// <summary>
					/// Destroys the messagesIndicator in the aggregation {@link #getMessagesIndicator messagesIndicator}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage destroyMessagesIndicator();

					/// <summary>
					/// Sets the aggregated {@link #getMessagesIndicator messagesIndicator}.
					/// </summary>
					/// <param name="oMessagesIndicator">The messagesIndicator to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage setMessagesIndicator(sap.f.semantic.MessagesIndicator oMessagesIndicator);

					#endregion

					#region Methods for Aggregation draftIndicator

					/// <summary>
					/// Gets content of aggregation {@link #getDraftIndicator draftIndicator}.
					/// 
					/// A semantic-specific button which is placed in the <code>FooterLeft</code> area of the <code>SemanticPage</code> footer as a second action.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.m.DraftIndicator getDraftIndicator();

					/// <summary>
					/// Destroys the draftIndicator in the aggregation {@link #getDraftIndicator draftIndicator}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage destroyDraftIndicator();

					/// <summary>
					/// Sets the aggregated {@link #getDraftIndicator draftIndicator}.
					/// </summary>
					/// <param name="oDraftIndicator">The draftIndicator to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage setDraftIndicator(sap.m.DraftIndicator oDraftIndicator);

					#endregion

					#region Methods for Aggregation positiveAction

					/// <summary>
					/// Gets content of aggregation {@link #getPositiveAction positiveAction}.
					/// 
					/// A semantic-specific button which is placed in the <code>FooterRight</code> area of the <code>SemanticPage</code> footer with default text value set to <code>Accept</code>.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.f.semantic.PositiveAction getPositiveAction();

					/// <summary>
					/// Destroys the positiveAction in the aggregation {@link #getPositiveAction positiveAction}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage destroyPositiveAction();

					/// <summary>
					/// Sets the aggregated {@link #getPositiveAction positiveAction}.
					/// </summary>
					/// <param name="oPositiveAction">The positiveAction to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage setPositiveAction(sap.f.semantic.PositiveAction oPositiveAction);

					#endregion

					#region Methods for Aggregation negativeAction

					/// <summary>
					/// Gets content of aggregation {@link #getNegativeAction negativeAction}.
					/// 
					/// A semantic-specific button which is placed in the <code>FooterRight</code> area of the <code>SemanticPage</code> footer with default text value set to <code>Reject</code>.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.f.semantic.NegativeAction getNegativeAction();

					/// <summary>
					/// Destroys the negativeAction in the aggregation {@link #getNegativeAction negativeAction}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage destroyNegativeAction();

					/// <summary>
					/// Sets the aggregated {@link #getNegativeAction negativeAction}.
					/// </summary>
					/// <param name="oNegativeAction">The negativeAction to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage setNegativeAction(sap.f.semantic.NegativeAction oNegativeAction);

					#endregion

					#region Methods for Aggregation footerCustomActions

					/// <summary>
					/// Gets content of aggregation {@link #getFooterCustomActions footerCustomActions}.
					/// 
					/// The <code>footerCustomActions</code> are placed in the <code>FooterRight</code> area of the <code>SemanticPage</code> footer, right after the semantic footer actions.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.m.Button[] getFooterCustomActions();

					/// <summary>
					/// Destroys all the footerCustomActions in the aggregation {@link #getFooterCustomActions footerCustomActions}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage destroyFooterCustomActions();

					/// <summary>
					/// Inserts a footerCustomAction into the aggregation {@link #getFooterCustomActions footerCustomActions}.
					/// </summary>
					/// <param name="oFooterCustomAction">The footerCustomAction to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the footerCustomAction should be inserted at; for a negative value of <code>iIndex</code>, the footerCustomAction is inserted at position 0; for a value greater than the current size of the aggregation, the footerCustomAction is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage insertFooterCustomAction(sap.m.Button oFooterCustomAction, int iIndex);

					/// <summary>
					/// Adds some footerCustomAction to the aggregation {@link #getFooterCustomActions footerCustomActions}.
					/// </summary>
					/// <param name="oFooterCustomAction">The footerCustomAction to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage addFooterCustomAction(sap.m.Button oFooterCustomAction);

					/// <summary>
					/// Removes a footerCustomAction from the aggregation {@link #getFooterCustomActions footerCustomActions}.
					/// </summary>
					/// <param name="vFooterCustomAction">The footerCustomAction to remove or its index or id</param>
					/// <returns>The removed footerCustomAction or <code>null</code></returns>
					public extern virtual sap.m.Button removeFooterCustomAction(Union<int, string, sap.m.Button> vFooterCustomAction);

					/// <summary>
					/// Checks for the provided <code>sap.m.Button</code> in the aggregation {@link #getFooterCustomActions footerCustomActions}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oFooterCustomAction">The footerCustomAction whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfFooterCustomAction(sap.m.Button oFooterCustomAction);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getFooterCustomActions footerCustomActions}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.m.Button[] removeAllFooterCustomActions();

					#endregion

					#region Methods for Aggregation discussInJamAction

					/// <summary>
					/// Gets content of aggregation {@link #getDiscussInJamAction discussInJamAction}.
					/// 
					/// A semantic-specific button which is placed in the <code>ShareMenu</code> area of the <code>SemanticPage</code> title.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.f.semantic.DiscussInJamAction getDiscussInJamAction();

					/// <summary>
					/// Destroys the discussInJamAction in the aggregation {@link #getDiscussInJamAction discussInJamAction}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage destroyDiscussInJamAction();

					/// <summary>
					/// Sets the aggregated {@link #getDiscussInJamAction discussInJamAction}.
					/// </summary>
					/// <param name="oDiscussInJamAction">The discussInJamAction to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage setDiscussInJamAction(sap.f.semantic.DiscussInJamAction oDiscussInJamAction);

					#endregion

					#region Methods for Aggregation saveAsTileAction

					/// <summary>
					/// Gets content of aggregation {@link #getSaveAsTileAction saveAsTileAction}.
					/// 
					/// A button which is placed in the <code>ShareMenu</code> area of the <code>SemanticPage</code> title.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.m.Button getSaveAsTileAction();

					/// <summary>
					/// Destroys the saveAsTileAction in the aggregation {@link #getSaveAsTileAction saveAsTileAction}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage destroySaveAsTileAction();

					/// <summary>
					/// Sets the aggregated {@link #getSaveAsTileAction saveAsTileAction}.
					/// </summary>
					/// <param name="oSaveAsTileAction">The saveAsTileAction to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage setSaveAsTileAction(sap.m.Button oSaveAsTileAction);

					#endregion

					#region Methods for Aggregation shareInJamAction

					/// <summary>
					/// Gets content of aggregation {@link #getShareInJamAction shareInJamAction}.
					/// 
					/// A semantic-specific button which is placed in the <code>ShareMenu</code> area of the <code>SemanticPage</code> title.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.f.semantic.ShareInJamAction getShareInJamAction();

					/// <summary>
					/// Destroys the shareInJamAction in the aggregation {@link #getShareInJamAction shareInJamAction}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage destroyShareInJamAction();

					/// <summary>
					/// Sets the aggregated {@link #getShareInJamAction shareInJamAction}.
					/// </summary>
					/// <param name="oShareInJamAction">The shareInJamAction to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage setShareInJamAction(sap.f.semantic.ShareInJamAction oShareInJamAction);

					#endregion

					#region Methods for Aggregation sendMessageAction

					/// <summary>
					/// Gets content of aggregation {@link #getSendMessageAction sendMessageAction}.
					/// 
					/// A semantic-specific button which is placed in the <code>ShareMenu</code> area of the <code>SemanticPage</code> title.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.f.semantic.SendMessageAction getSendMessageAction();

					/// <summary>
					/// Destroys the sendMessageAction in the aggregation {@link #getSendMessageAction sendMessageAction}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage destroySendMessageAction();

					/// <summary>
					/// Sets the aggregated {@link #getSendMessageAction sendMessageAction}.
					/// </summary>
					/// <param name="oSendMessageAction">The sendMessageAction to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage setSendMessageAction(sap.f.semantic.SendMessageAction oSendMessageAction);

					#endregion

					#region Methods for Aggregation sendEmailAction

					/// <summary>
					/// Gets content of aggregation {@link #getSendEmailAction sendEmailAction}.
					/// 
					/// A semantic-specific button which is placed in the <code>ShareMenu</code> area of the <code>SemanticPage</code> title.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.f.semantic.SendEmailAction getSendEmailAction();

					/// <summary>
					/// Destroys the sendEmailAction in the aggregation {@link #getSendEmailAction sendEmailAction}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage destroySendEmailAction();

					/// <summary>
					/// Sets the aggregated {@link #getSendEmailAction sendEmailAction}.
					/// </summary>
					/// <param name="oSendEmailAction">The sendEmailAction to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage setSendEmailAction(sap.f.semantic.SendEmailAction oSendEmailAction);

					#endregion

					#region Methods for Aggregation printAction

					/// <summary>
					/// Gets content of aggregation {@link #getPrintAction printAction}.
					/// 
					/// A semantic-specific button which is placed in the <code>ShareMenu</code> area of the <code>SemanticPage</code> title.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.f.semantic.PrintAction getPrintAction();

					/// <summary>
					/// Destroys the printAction in the aggregation {@link #getPrintAction printAction}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage destroyPrintAction();

					/// <summary>
					/// Sets the aggregated {@link #getPrintAction printAction}.
					/// </summary>
					/// <param name="oPrintAction">The printAction to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage setPrintAction(sap.f.semantic.PrintAction oPrintAction);

					#endregion

					#region Methods for Aggregation customShareActions

					/// <summary>
					/// Gets content of aggregation {@link #getCustomShareActions customShareActions}.
					/// 
					/// The <code>customShareActions</code> are placed in the <code>ShareMenu</code> area of the <code>SemanticPage</code> title, right after the semantic actions.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.m.Button[] getCustomShareActions();

					/// <summary>
					/// Destroys all the customShareActions in the aggregation {@link #getCustomShareActions customShareActions}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage destroyCustomShareActions();

					/// <summary>
					/// Inserts a customShareAction into the aggregation {@link #getCustomShareActions customShareActions}.
					/// </summary>
					/// <param name="oCustomShareAction">The customShareAction to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the customShareAction should be inserted at; for a negative value of <code>iIndex</code>, the customShareAction is inserted at position 0; for a value greater than the current size of the aggregation, the customShareAction is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage insertCustomShareAction(sap.m.Button oCustomShareAction, int iIndex);

					/// <summary>
					/// Adds some customShareAction to the aggregation {@link #getCustomShareActions customShareActions}.
					/// </summary>
					/// <param name="oCustomShareAction">The customShareAction to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticPage addCustomShareAction(sap.m.Button oCustomShareAction);

					/// <summary>
					/// Removes a customShareAction from the aggregation {@link #getCustomShareActions customShareActions}.
					/// </summary>
					/// <param name="vCustomShareAction">The customShareAction to remove or its index or id</param>
					/// <returns>The removed customShareAction or <code>null</code></returns>
					public extern virtual sap.m.Button removeCustomShareAction(Union<int, string, sap.m.Button> vCustomShareAction);

					/// <summary>
					/// Checks for the provided <code>sap.m.Button</code> in the aggregation {@link #getCustomShareActions customShareActions}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oCustomShareAction">The customShareAction whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfCustomShareAction(sap.m.Button oCustomShareAction);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getCustomShareActions customShareActions}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.m.Button[] removeAllCustomShareActions();

					#endregion

					#region Methods for Aggregation _dynamicPage

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.f.semantic.SemanticPage with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.f.semantic.SemanticPage with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.f.semantic.SemanticPage with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.f.semantic.SemanticPage.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					#endregion

					#endregion

				}
			}
		}
	}
}
