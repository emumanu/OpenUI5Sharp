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
			/// <summary>
			/// Title of the {@link sap.f.DynamicPage}.
			/// 
			/// <h3>Overview</h3>
			/// 
			/// The <code>DynamicPageTitle</code> control is part of the {@link sap.f.DynamicPage} family and is used to serve as title of the {@link sap.f.DynamicPage DynamicPage}.
			/// 
			/// <h3>Usage</h3>
			/// 
			/// The <code>DynamicPageTitle</code> can hold any control and displays the most important information regarding the object that will always remain visible while scrolling.
			/// 
			/// <b>Note:</b> The <code>actions</code> aggregation accepts any UI5 control, but it`s recommended to use controls, suitable for {@link sap.m.Toolbar} and {@link sap.m.OverflowToolbar}.
			/// 
			/// If the <code>toggleHeaderOnTitleClick</code> property of the {@link sap.f.DynamicPage DynamicPage} is set to <code>true</code>, the user can switch between the expanded/collapsed states of the {@link sap.f.DynamicPageHeader DynamicPageHeader} by clicking on the <code>DynamicPageTitle</code> or by using the expand/collapse visual indicators, positioned at the bottom of the <code>DynamicPageTitle</code> and the <code>DynamicPageHeader</code>.
			/// 
			/// If set to <code>false</code>, the <code>DynamicPageTitle</code> is not clickable, the visual indicators are not available, and the app must provide other means for expanding/collapsing the <code>DynamicPageHeader</code>, if necessary.
			/// 
			/// <h3>Responsive Behavior</h3>
			/// 
			/// The responsive behavior of the <code>DynamicPageTitle</code> depends on the behavior of the content that is displayed.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.f.DynamicPageTitle")]
			public partial class DynamicPageTitle : sap.ui.core.Control
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
					/// Determines which of the <code>DynamicPageTitle</code> areas (Begin, Middle) is primary.
					/// 
					/// <b>Note:</b> The primary area is shrinking at lower rate, remaining visible as much as it can.
					/// </summary>
					public Union<sap.f.DynamicPageTitleArea, string, sap.ui.@base.ManagedObject.BindPropertyInfo> primaryArea;

					/// <summary>
					/// Assigns shrinking ratio to the <code>DynamicPageTitle</code> areas (Heading, Content, Actions). The greater value a section has the faster it shrinks when the screen size is being reduced.
					/// 
					/// The value must be set in <code>Heading:Content:Actions</code> format where Title, Content and Actions are numbers greater than or equal to 0. If set to 0, the respective area will not shrink.
					/// 
					/// For example, if <code>2:7:1</code> is set, the Content area will shrink seven times faster than the Actions area. So, when all three areas have width of 500px and the available space is reduced by 100px the Title area will reduced by 20px, the Content area - by 70px and the Actions area - by 10px.
					/// 
					/// If all the areas have assigned values greater than 1, the numbers are scaled so that at least one of them is equal to 1. For example, value of <code>2:4:8</code> is equal to <code>1:2:4</code>.
					/// 
					/// <Note:> When this property is set the <code>primaryArea</code> property has no effect.
					/// </summary>
					public Union<sap.f.DynamicPageTitleShrinkRatio, string, sap.ui.@base.ManagedObject.BindPropertyInfo> areaShrinkRatio;

					/// <summary>
					/// The <code>heading</code> is positioned in the <code>DynamicPageTitle</code> left area and is displayed in both expanded and collapsed (snapped) states of the header. Use this aggregation to display a title (or any other UI5 control that serves as a heading) that has to be present in both expanded and collapsed states of the header.
					/// 
					/// <b>Note:</b> <code>heading</code> is mutually exclusive with <code>snappedHeading</code> and <code>expandedHeading</code>. If <code>heading</code> is provided, both <code>snappedHeading</code> and <code>expandedHeading</code> are ignored. <code>heading</code> is useful when the content of <code>snappedHeading</code> and <code>expandedHeading</code> needs to be the same as it replaces them both.
					/// </summary>
					public Union<sap.ui.core.Control, string, sap.ui.@base.ManagedObject.BindAggregationInfo> heading;

					/// <summary>
					/// The <code>snappedHeading</code> is positioned in the <code>DynamicPageTitle</code> left area and is displayed when the header is in collapsed (snapped) state only. Use this aggregation to display a title (or any other UI5 control that serves as a heading) that has to be present in collapsed state only.
					/// 
					/// <b>Note:</b> In order for <code>snappedHeading</code> to be taken into account, <code>heading</code> has to be empty. Combine <code>snappedHeading</code> with <code>expandedHeading</code> to switch content when the header switches state.
					/// </summary>
					public Union<sap.ui.core.Control, string, sap.ui.@base.ManagedObject.BindAggregationInfo> snappedHeading;

					/// <summary>
					/// The <code>expandedHeading</code> is positioned in the <code>DynamicPageTitle</code> left area and is displayed when the header is in expanded state only. Use this aggregation to display a title (or any other UI5 control that serves as a heading) that has to be present in expanded state only.
					/// 
					/// <b>Note:</b> In order for <code>expandedHeading</code> to be taken into account, <code>heading</code> has to be empty. Combine <code>expandedHeading</code> with <code>snappedHeading</code> to switch content when the header switches state.
					/// </summary>
					public Union<sap.ui.core.Control, string, sap.ui.@base.ManagedObject.BindAggregationInfo> expandedHeading;

					/// <summary>
					/// The <code>DynamicPageTitle</code> actions. <br><b>Note:</b> The <code>actions</code> aggregation accepts any UI5 control, but it`s recommended to use controls, suitable for {@link sap.m.Toolbar} and {@link sap.m.OverflowToolbar}.
					/// </summary>
					public Union<sap.ui.core.Control[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> actions;

					/// <summary>
					/// The <code>DynamicPageTitle</code> navigation actions.
					/// 
					/// <b>Note:</b> The <code>navigationActions</code> position depends on the control size. If the control size is 1280px or bigger, they are rendered right next to the <code>actions</code>. Otherwise, they are rendered in the top-right area, above the <code>actions</code>. If a large number of elements(buttons) are used, there could be visual degradations as the space for the <code>navigationActions</code> is limited.
					/// </summary>
					public Union<sap.m.Button[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> navigationActions;

					/// <summary>
					/// The content is positioned in the <code>DynamicPageTitle</code> middle area and displayed in both expanded and collapsed (snapped) states.
					/// </summary>
					public Union<sap.ui.core.Control[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> content;

					/// <summary>
					/// The content that is displayed in the <code>DynamicPageTitle</code> in collapsed (snapped) state.
					/// </summary>
					public Union<sap.ui.core.Control[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> snappedContent;

					/// <summary>
					/// The content that is displayed in the <code>DynamicPageTitle</code> in expanded state.
					/// </summary>
					public Union<sap.ui.core.Control[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> expandedContent;

					/// <summary>
					/// The breadcrumbs displayed in the <code>DynamicPageTitle</code> top-left area.
					/// </summary>
					public Union<sap.m.IBreadcrumbs, string, sap.ui.@base.ManagedObject.BindAggregationInfo> breadcrumbs;

					/// <summary>
					/// Fired when the title state (expanded/collapsed) is toggled by user interaction. For example, scrolling, title clicking/tapping, using expand/collapse button.
					/// 
					/// Also fired when the developer toggles the title state by programmatically changing the scroll position of the scrollbar of <code>DynamicPage</code>.
					/// </summary>
					public sap.f.DynamicPageTitle.StateChangeDelegate stateChange;

				}

				#endregion

				#region Typed Parameters

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class StateChangeInfo
				{
					/// <summary>
					/// Whether the title was expanded (true) or collapsed (false).
					/// </summary>
					public bool isExpanded;

				}

				#endregion

				#region Delegates

				public delegate void StateChangeDelegate(sap.ui.@base.Event<sap.f.DynamicPageTitle.StateChangeInfo> oEvent, object oData);

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new <code>DynamicPageTitle</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern DynamicPageTitle(string sId, sap.f.DynamicPageTitle.Settings mSettings);

				/// <summary>
				/// Constructor for a new <code>DynamicPageTitle</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern DynamicPageTitle(string sId);

				/// <summary>
				/// Constructor for a new <code>DynamicPageTitle</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern DynamicPageTitle();

				/// <summary>
				/// Constructor for a new <code>DynamicPageTitle</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern DynamicPageTitle(sap.f.DynamicPageTitle.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property primaryArea

				/// <summary>
				/// Gets current value of property {@link #getPrimaryArea primaryArea}.
				/// 
				/// Determines which of the <code>DynamicPageTitle</code> areas (Begin, Middle) is primary.
				/// 
				/// <b>Note:</b> The primary area is shrinking at lower rate, remaining visible as much as it can.
				/// 
				/// Default value is <code>Begin</code>.
				/// </summary>
				/// <returns>Value of property <code>primaryArea</code></returns>
				[Obsolete("Deprecated since 1.54. Please use the <code>areaShrinkRatio</code> property instead. The value of <code>areaShrinkRatio</code> must be set in <code>Heading:Content:Actions</code> format where Heading, Content and Actions are numbers greater than or equal to 0. The greater value a section has the faster it shrinks when the screen size is being reduced.<code>primaryArea=Begin</code> can be achieved by setting a low number for the Heading area to <code>areaShrinkRatio</code>, for example <code>1:1.6:1.6</code>.<code>primaryArea=Middle</code> can be achieved by setting a low number for the Content area to <code>areaShrinkRatio</code>, for example <code>1.6:1:1.6</code>.")]
				public extern virtual sap.f.DynamicPageTitleArea getPrimaryArea();

				/// <summary>
				/// Sets a new value for property {@link #getPrimaryArea primaryArea}.
				/// 
				/// Determines which of the <code>DynamicPageTitle</code> areas (Begin, Middle) is primary.
				/// 
				/// <b>Note:</b> The primary area is shrinking at lower rate, remaining visible as much as it can.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Begin</code>.
				/// </summary>
				/// <param name="sPrimaryArea">New value for property <code>primaryArea</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.54. Please use the <code>areaShrinkRatio</code> property instead. The value of <code>areaShrinkRatio</code> must be set in <code>Heading:Content:Actions</code> format where Heading, Content and Actions are numbers greater than or equal to 0. The greater value a section has the faster it shrinks when the screen size is being reduced.<code>primaryArea=Begin</code> can be achieved by setting a low number for the Heading area to <code>areaShrinkRatio</code>, for example <code>1:1.6:1.6</code>.<code>primaryArea=Middle</code> can be achieved by setting a low number for the Content area to <code>areaShrinkRatio</code>, for example <code>1.6:1:1.6</code>.")]
				public extern virtual sap.f.DynamicPageTitle setPrimaryArea(sap.f.DynamicPageTitleArea sPrimaryArea);

				#endregion

				#region Methods for Property areaShrinkRatio

				/// <summary>
				/// Gets current value of property {@link #getAreaShrinkRatio areaShrinkRatio}.
				/// 
				/// Assigns shrinking ratio to the <code>DynamicPageTitle</code> areas (Heading, Content, Actions). The greater value a section has the faster it shrinks when the screen size is being reduced.
				/// 
				/// The value must be set in <code>Heading:Content:Actions</code> format where Title, Content and Actions are numbers greater than or equal to 0. If set to 0, the respective area will not shrink.
				/// 
				/// For example, if <code>2:7:1</code> is set, the Content area will shrink seven times faster than the Actions area. So, when all three areas have width of 500px and the available space is reduced by 100px the Title area will reduced by 20px, the Content area - by 70px and the Actions area - by 10px.
				/// 
				/// If all the areas have assigned values greater than 1, the numbers are scaled so that at least one of them is equal to 1. For example, value of <code>2:4:8</code> is equal to <code>1:2:4</code>.
				/// 
				/// <Note:> When this property is set the <code>primaryArea</code> property has no effect.
				/// 
				/// Default value is <code>1:1.6:1.6</code>.
				/// </summary>
				/// <returns>Value of property <code>areaShrinkRatio</code></returns>
				public extern virtual sap.f.DynamicPageTitleShrinkRatio getAreaShrinkRatio();

				/// <summary>
				/// Sets the value of the <code>areaShrinkRatio</code> property.
				/// </summary>
				/// <param name="sAreaShrinkRatio">new value of the <code>areaShrinkRatio</code></param>
				/// <returns><code>this</code> to allow method chaining</returns>
				public extern virtual sap.f.DynamicPageTitle setAreaShrinkRatio(sap.f.DynamicPageTitleShrinkRatio sAreaShrinkRatio);

				#endregion

				#region Methods for Aggregation heading

				/// <summary>
				/// Gets content of aggregation {@link #getHeading heading}.
				/// 
				/// The <code>heading</code> is positioned in the <code>DynamicPageTitle</code> left area and is displayed in both expanded and collapsed (snapped) states of the header. Use this aggregation to display a title (or any other UI5 control that serves as a heading) that has to be present in both expanded and collapsed states of the header.
				/// 
				/// <b>Note:</b> <code>heading</code> is mutually exclusive with <code>snappedHeading</code> and <code>expandedHeading</code>. If <code>heading</code> is provided, both <code>snappedHeading</code> and <code>expandedHeading</code> are ignored. <code>heading</code> is useful when the content of <code>snappedHeading</code> and <code>expandedHeading</code> needs to be the same as it replaces them both.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.Control getHeading();

				/// <summary>
				/// Destroys the heading in the aggregation {@link #getHeading heading}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.DynamicPageTitle destroyHeading();

				/// <summary>
				/// Sets the aggregated {@link #getHeading heading}.
				/// </summary>
				/// <param name="oHeading">The heading to set</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.DynamicPageTitle setHeading(sap.ui.core.Control oHeading);

				#endregion

				#region Methods for Aggregation snappedHeading

				/// <summary>
				/// Gets content of aggregation {@link #getSnappedHeading snappedHeading}.
				/// 
				/// The <code>snappedHeading</code> is positioned in the <code>DynamicPageTitle</code> left area and is displayed when the header is in collapsed (snapped) state only. Use this aggregation to display a title (or any other UI5 control that serves as a heading) that has to be present in collapsed state only.
				/// 
				/// <b>Note:</b> In order for <code>snappedHeading</code> to be taken into account, <code>heading</code> has to be empty. Combine <code>snappedHeading</code> with <code>expandedHeading</code> to switch content when the header switches state.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.Control getSnappedHeading();

				/// <summary>
				/// Destroys the snappedHeading in the aggregation {@link #getSnappedHeading snappedHeading}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.DynamicPageTitle destroySnappedHeading();

				/// <summary>
				/// Sets the aggregated {@link #getSnappedHeading snappedHeading}.
				/// </summary>
				/// <param name="oSnappedHeading">The snappedHeading to set</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.DynamicPageTitle setSnappedHeading(sap.ui.core.Control oSnappedHeading);

				#endregion

				#region Methods for Aggregation expandedHeading

				/// <summary>
				/// Gets content of aggregation {@link #getExpandedHeading expandedHeading}.
				/// 
				/// The <code>expandedHeading</code> is positioned in the <code>DynamicPageTitle</code> left area and is displayed when the header is in expanded state only. Use this aggregation to display a title (or any other UI5 control that serves as a heading) that has to be present in expanded state only.
				/// 
				/// <b>Note:</b> In order for <code>expandedHeading</code> to be taken into account, <code>heading</code> has to be empty. Combine <code>expandedHeading</code> with <code>snappedHeading</code> to switch content when the header switches state.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.Control getExpandedHeading();

				/// <summary>
				/// Destroys the expandedHeading in the aggregation {@link #getExpandedHeading expandedHeading}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.DynamicPageTitle destroyExpandedHeading();

				/// <summary>
				/// Sets the aggregated {@link #getExpandedHeading expandedHeading}.
				/// </summary>
				/// <param name="oExpandedHeading">The expandedHeading to set</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.DynamicPageTitle setExpandedHeading(sap.ui.core.Control oExpandedHeading);

				#endregion

				#region Methods for Aggregation actions

				/// <summary>
				/// Gets content of aggregation {@link #getActions actions}.
				/// 
				/// The <code>DynamicPageTitle</code> actions. <br><b>Note:</b> The <code>actions</code> aggregation accepts any UI5 control, but it`s recommended to use controls, suitable for {@link sap.m.Toolbar} and {@link sap.m.OverflowToolbar}.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.Control[] getActions();

				/// <summary>
				/// Destroys all the actions in the aggregation {@link #getActions actions}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.DynamicPageTitle destroyActions();

				/// <summary>
				/// Inserts a action into the aggregation {@link #getActions actions}.
				/// </summary>
				/// <param name="oAction">The action to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the action should be inserted at; for a negative value of <code>iIndex</code>, the action is inserted at position 0; for a value greater than the current size of the aggregation, the action is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.DynamicPageTitle insertAction(sap.ui.core.Control oAction, int iIndex);

				/// <summary>
				/// Adds some action to the aggregation {@link #getActions actions}.
				/// </summary>
				/// <param name="oAction">The action to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.DynamicPageTitle addAction(sap.ui.core.Control oAction);

				/// <summary>
				/// Removes a action from the aggregation {@link #getActions actions}.
				/// </summary>
				/// <param name="vAction">The action to remove or its index or id</param>
				/// <returns>The removed action or <code>null</code></returns>
				public extern virtual sap.ui.core.Control removeAction(Union<int, string, sap.ui.core.Control> vAction);

				/// <summary>
				/// Checks for the provided <code>sap.ui.core.Control</code> in the aggregation {@link #getActions actions}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oAction">The action whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfAction(sap.ui.core.Control oAction);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getActions actions}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.ui.core.Control[] removeAllActions();

				#endregion

				#region Methods for Aggregation navigationActions

				/// <summary>
				/// Gets content of aggregation {@link #getNavigationActions navigationActions}.
				/// 
				/// The <code>DynamicPageTitle</code> navigation actions.
				/// 
				/// <b>Note:</b> The <code>navigationActions</code> position depends on the control size. If the control size is 1280px or bigger, they are rendered right next to the <code>actions</code>. Otherwise, they are rendered in the top-right area, above the <code>actions</code>. If a large number of elements(buttons) are used, there could be visual degradations as the space for the <code>navigationActions</code> is limited.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.Button[] getNavigationActions();

				/// <summary>
				/// Destroys all the navigationActions in the aggregation {@link #getNavigationActions navigationActions}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.DynamicPageTitle destroyNavigationActions();

				/// <summary>
				/// Inserts a navigationAction into the aggregation {@link #getNavigationActions navigationActions}.
				/// </summary>
				/// <param name="oNavigationAction">The navigationAction to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the navigationAction should be inserted at; for a negative value of <code>iIndex</code>, the navigationAction is inserted at position 0; for a value greater than the current size of the aggregation, the navigationAction is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.DynamicPageTitle insertNavigationAction(sap.m.Button oNavigationAction, int iIndex);

				/// <summary>
				/// Adds some navigationAction to the aggregation {@link #getNavigationActions navigationActions}.
				/// </summary>
				/// <param name="oNavigationAction">The navigationAction to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.DynamicPageTitle addNavigationAction(sap.m.Button oNavigationAction);

				/// <summary>
				/// Removes a navigationAction from the aggregation {@link #getNavigationActions navigationActions}.
				/// </summary>
				/// <param name="vNavigationAction">The navigationAction to remove or its index or id</param>
				/// <returns>The removed navigationAction or <code>null</code></returns>
				public extern virtual sap.m.Button removeNavigationAction(Union<int, string, sap.m.Button> vNavigationAction);

				/// <summary>
				/// Checks for the provided <code>sap.m.Button</code> in the aggregation {@link #getNavigationActions navigationActions}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oNavigationAction">The navigationAction whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfNavigationAction(sap.m.Button oNavigationAction);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getNavigationActions navigationActions}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.m.Button[] removeAllNavigationActions();

				#endregion

				#region Methods for Aggregation content

				/// <summary>
				/// Gets content of aggregation {@link #getContent content}.
				/// 
				/// The content is positioned in the <code>DynamicPageTitle</code> middle area and displayed in both expanded and collapsed (snapped) states.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.Control[] getContent();

				/// <summary>
				/// Destroys all the content in the aggregation {@link #getContent content}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.DynamicPageTitle destroyContent();

				/// <summary>
				/// Inserts a content into the aggregation {@link #getContent content}.
				/// </summary>
				/// <param name="oContent">The content to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the content should be inserted at; for a negative value of <code>iIndex</code>, the content is inserted at position 0; for a value greater than the current size of the aggregation, the content is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.DynamicPageTitle insertContent(sap.ui.core.Control oContent, int iIndex);

				/// <summary>
				/// Adds some content to the aggregation {@link #getContent content}.
				/// </summary>
				/// <param name="oContent">The content to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.DynamicPageTitle addContent(sap.ui.core.Control oContent);

				/// <summary>
				/// Removes a content from the aggregation {@link #getContent content}.
				/// </summary>
				/// <param name="vContent">The content to remove or its index or id</param>
				/// <returns>The removed content or <code>null</code></returns>
				public extern virtual sap.ui.core.Control removeContent(Union<int, string, sap.ui.core.Control> vContent);

				/// <summary>
				/// Checks for the provided <code>sap.ui.core.Control</code> in the aggregation {@link #getContent content}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oContent">The content whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfContent(sap.ui.core.Control oContent);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getContent content}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.ui.core.Control[] removeAllContent();

				#endregion

				#region Methods for Aggregation snappedContent

				/// <summary>
				/// Gets content of aggregation {@link #getSnappedContent snappedContent}.
				/// 
				/// The content that is displayed in the <code>DynamicPageTitle</code> in collapsed (snapped) state.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.Control[] getSnappedContent();

				/// <summary>
				/// Destroys all the snappedContent in the aggregation {@link #getSnappedContent snappedContent}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.DynamicPageTitle destroySnappedContent();

				/// <summary>
				/// Inserts a snappedContent into the aggregation {@link #getSnappedContent snappedContent}.
				/// </summary>
				/// <param name="oSnappedContent">The snappedContent to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the snappedContent should be inserted at; for a negative value of <code>iIndex</code>, the snappedContent is inserted at position 0; for a value greater than the current size of the aggregation, the snappedContent is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.DynamicPageTitle insertSnappedContent(sap.ui.core.Control oSnappedContent, int iIndex);

				/// <summary>
				/// Adds some snappedContent to the aggregation {@link #getSnappedContent snappedContent}.
				/// </summary>
				/// <param name="oSnappedContent">The snappedContent to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.DynamicPageTitle addSnappedContent(sap.ui.core.Control oSnappedContent);

				/// <summary>
				/// Removes a snappedContent from the aggregation {@link #getSnappedContent snappedContent}.
				/// </summary>
				/// <param name="vSnappedContent">The snappedContent to remove or its index or id</param>
				/// <returns>The removed snappedContent or <code>null</code></returns>
				public extern virtual sap.ui.core.Control removeSnappedContent(Union<int, string, sap.ui.core.Control> vSnappedContent);

				/// <summary>
				/// Checks for the provided <code>sap.ui.core.Control</code> in the aggregation {@link #getSnappedContent snappedContent}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oSnappedContent">The snappedContent whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfSnappedContent(sap.ui.core.Control oSnappedContent);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getSnappedContent snappedContent}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.ui.core.Control[] removeAllSnappedContent();

				#endregion

				#region Methods for Aggregation expandedContent

				/// <summary>
				/// Gets content of aggregation {@link #getExpandedContent expandedContent}.
				/// 
				/// The content that is displayed in the <code>DynamicPageTitle</code> in expanded state.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.Control[] getExpandedContent();

				/// <summary>
				/// Destroys all the expandedContent in the aggregation {@link #getExpandedContent expandedContent}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.DynamicPageTitle destroyExpandedContent();

				/// <summary>
				/// Inserts a expandedContent into the aggregation {@link #getExpandedContent expandedContent}.
				/// </summary>
				/// <param name="oExpandedContent">The expandedContent to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the expandedContent should be inserted at; for a negative value of <code>iIndex</code>, the expandedContent is inserted at position 0; for a value greater than the current size of the aggregation, the expandedContent is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.DynamicPageTitle insertExpandedContent(sap.ui.core.Control oExpandedContent, int iIndex);

				/// <summary>
				/// Adds some expandedContent to the aggregation {@link #getExpandedContent expandedContent}.
				/// </summary>
				/// <param name="oExpandedContent">The expandedContent to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.DynamicPageTitle addExpandedContent(sap.ui.core.Control oExpandedContent);

				/// <summary>
				/// Removes a expandedContent from the aggregation {@link #getExpandedContent expandedContent}.
				/// </summary>
				/// <param name="vExpandedContent">The expandedContent to remove or its index or id</param>
				/// <returns>The removed expandedContent or <code>null</code></returns>
				public extern virtual sap.ui.core.Control removeExpandedContent(Union<int, string, sap.ui.core.Control> vExpandedContent);

				/// <summary>
				/// Checks for the provided <code>sap.ui.core.Control</code> in the aggregation {@link #getExpandedContent expandedContent}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oExpandedContent">The expandedContent whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfExpandedContent(sap.ui.core.Control oExpandedContent);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getExpandedContent expandedContent}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.ui.core.Control[] removeAllExpandedContent();

				#endregion

				#region Methods for Aggregation breadcrumbs

				/// <summary>
				/// Gets content of aggregation {@link #getBreadcrumbs breadcrumbs}.
				/// 
				/// The breadcrumbs displayed in the <code>DynamicPageTitle</code> top-left area.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.IBreadcrumbs getBreadcrumbs();

				/// <summary>
				/// Destroys the breadcrumbs in the aggregation {@link #getBreadcrumbs breadcrumbs}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.DynamicPageTitle destroyBreadcrumbs();

				/// <summary>
				/// Sets the aggregated {@link #getBreadcrumbs breadcrumbs}.
				/// </summary>
				/// <param name="oBreadcrumbs">The breadcrumbs to set</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.DynamicPageTitle setBreadcrumbs(sap.m.IBreadcrumbs oBreadcrumbs);

				#endregion

				#region Methods for Aggregation _actionsToolbar

				#endregion

				#region Methods for Aggregation _navActionsToolbar

				#endregion

				#region Methods for Aggregation _navActionsToolbarSeparator

				#endregion

				#region Methods for Aggregation _expandButton

				#endregion

				#region Methods for Event stateChange

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:stateChange stateChange} event of this <code>sap.f.DynamicPageTitle</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.f.DynamicPageTitle</code> itself.
				/// 
				/// Fired when the title state (expanded/collapsed) is toggled by user interaction. For example, scrolling, title clicking/tapping, using expand/collapse button.
				/// 
				/// Also fired when the developer toggles the title state by programmatically changing the scroll position of the scrollbar of <code>DynamicPage</code>.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.f.DynamicPageTitle</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.DynamicPageTitle attachStateChange(object oData, sap.f.DynamicPageTitle.StateChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:stateChange stateChange} event of this <code>sap.f.DynamicPageTitle</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.f.DynamicPageTitle</code> itself.
				/// 
				/// Fired when the title state (expanded/collapsed) is toggled by user interaction. For example, scrolling, title clicking/tapping, using expand/collapse button.
				/// 
				/// Also fired when the developer toggles the title state by programmatically changing the scroll position of the scrollbar of <code>DynamicPage</code>.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.DynamicPageTitle attachStateChange(object oData, sap.f.DynamicPageTitle.StateChangeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:stateChange stateChange} event of this <code>sap.f.DynamicPageTitle</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.f.DynamicPageTitle</code> itself.
				/// 
				/// Fired when the title state (expanded/collapsed) is toggled by user interaction. For example, scrolling, title clicking/tapping, using expand/collapse button.
				/// 
				/// Also fired when the developer toggles the title state by programmatically changing the scroll position of the scrollbar of <code>DynamicPage</code>.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.DynamicPageTitle attachStateChange(sap.f.DynamicPageTitle.StateChangeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:stateChange stateChange} event of this <code>sap.f.DynamicPageTitle</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.f.DynamicPageTitle</code> itself.
				/// 
				/// Fired when the title state (expanded/collapsed) is toggled by user interaction. For example, scrolling, title clicking/tapping, using expand/collapse button.
				/// 
				/// Also fired when the developer toggles the title state by programmatically changing the scroll position of the scrollbar of <code>DynamicPage</code>.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.f.DynamicPageTitle</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.DynamicPageTitle attachStateChange(sap.f.DynamicPageTitle.StateChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:stateChange stateChange} event of this <code>sap.f.DynamicPageTitle</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.DynamicPageTitle detachStateChange(sap.f.DynamicPageTitle.StateChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:stateChange stateChange} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.DynamicPageTitle fireStateChange(sap.f.DynamicPageTitle.StateChangeInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:stateChange stateChange} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.DynamicPageTitle fireStateChange();

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.f.DynamicPageTitle with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.f.DynamicPageTitle with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.f.DynamicPageTitle with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.f.DynamicPageTitle.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				#endregion

				#endregion

			}
		}
	}
}
