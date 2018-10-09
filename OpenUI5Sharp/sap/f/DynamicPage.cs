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
			/// A layout control, representing a web page, consisting of a title, header with dynamic behavior, a content area, and an optional floating footer.
			/// 
			/// <h3>Overview</h3>
			/// 
			/// The control consist of several components:
			/// 
			/// <ul><li>{@link sap.f.DynamicPageTitle DynamicPageTitle} - consists of a heading on the left side, content in the middle, and actions on the right. The displayed content changes based on the current mode of the {@link sap.f.DynamicPageHeader DynamicPageHeader}.</li> <li>{@link sap.f.DynamicPageHeader DynamicPageHeader} - a generic container, which can contain a single layout control and does not care about the content alignment and responsiveness. The header works in two modes - expanded and snapped and its behavior can be adjusted with the help of different properties.</li> <li>Content area - a generic container, which can have a single UI5 layout control and does not care about the content alignment and responsiveness.</li> <li>Footer - positioned at the bottom with a small offset and used for additional actions, the footer floats above the content. It can be any {@link sap.m.IBar} control.</li></ul>
			/// 
			/// <h3>Usage</h3>
			/// 
			/// Use the <code>DynamicPage</code> if you need to have a title, that is always visible and a header, that has configurable Expanding/Snapping functionality. If you don't need the Expanding/Snapping functionality it is better to use the {@link sap.m.Page} as a lighter control.
			/// 
			/// <ul><b>Notes:</b> <li>If you're displaying a {@link sap.m.FlexBox} with non-adaptive content (doesn't stretch to fill the available space), it is recommended to set the <code>fitContainer</code> property of the {@link sap.m.FlexBox FlexBox} to <code>false</code>.</li> <li>If you are displaying a {@link sap.ui.table.Table}, keep in mind that it is non-adaptive and may cause unpredicted behavior for the <code>DynamicPage</code> on smaller screen sizes, such as mobile.</li> <li>Snapping of the {@link sap.f.DynamicPageTitle DynamicPageTitle} is not supported in the following case: When the <code>DynamicPage</code> has a scroll bar, the control usually scrolls to the snapping point - the point, where the {@link sap.f.DynamicPageHeader DynamicPageHeader} is scrolled out completely. However, when there is a scroll bar, but not enough content to reach the snapping point, the snapping is not possible using scrolling.</li> <li>When using {@link sap.ui.layout.form.Form}, {@link sap.m.Panel}, {@link sap.m.Table} and {@link sap.m.List} controls in the content of <code>DynamicPage</code>, you need to adjust their left text offset if you want to achieve vertical alignment between the <code>sap.f.DynamicPageHeader</code>`s content and <code>DynamicPage</code>`s content. For more information, see the documentation for the <code>content</code> aggregation.</li></ul>
			/// 
			/// <h3>Responsive Behavior</h3>
			/// 
			/// The responsive behavior of the <code>DynamicPage</code> depends on the behavior of the content that is displayed.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.f.DynamicPage")]
			public partial class DynamicPage : sap.ui.core.Control
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
					/// Preserves the current header state when scrolling. For example, if the user expands the header by clicking on the title and then scrolls down the page, the header will remain expanded.
					/// 
					/// <b>Note:</b> Based on internal rules, the value of the property is not always taken into account - for example, when the control is rendered on tablet or mobile and the control`s title and header are with height larger than the given threshold.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> preserveHeaderStateOnScroll;

					/// <summary>
					/// Determines whether the header is expanded.
					/// 
					/// The header can be also expanded/collapsed by user interaction, which requires the property to be internally mutated by the control to reflect the changed state.
					/// 
					/// <b>Note:</b> As of version 1.48, you can initialize the control in collapsed header state by setting this property to <code>false</code>.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> headerExpanded;

					/// <summary>
					/// Determines whether the user can switch between the expanded/collapsed states of the <code>DynamicPageHeader</code> by clicking on the <code>DynamicPageTitle</code> or by using the expand/collapse visual indicators, positioned at the bottom of the <code>DynamicPageTitle</code> and the <code>DynamicPageHeader</code>. If set to <code>false</code>, the <code>DynamicPageTitle</code> is not clickable, the visual indicators are not available and the application must provide other means for expanding/collapsing the <code>DynamicPageHeader</code>, if necessary.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> toggleHeaderOnTitleClick;

					/// <summary>
					/// Determines whether the footer is visible.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showFooter;

					/// <summary>
					/// Optimizes <code>DynamicPage</code> responsiveness on small screens and behavior when expanding/collapsing the <code>DynamicPageHeader</code>.
					/// 
					/// <b>Note:</b> It is recommended to use this property when displaying content of adaptive controls that stretch to fill the available space. Such controls may be {@link sap.ui.table.Table} and {@link sap.ui.table.AnalyticalTable} depending on their settings.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> fitContent;

					/// <summary>
					/// <code>DynamicPage</code> title.
					/// </summary>
					public Union<sap.f.DynamicPageTitle, string, sap.ui.@base.ManagedObject.BindAggregationInfo> title;

					/// <summary>
					/// <code>DynamicPage</code> header.
					/// </summary>
					public Union<sap.f.DynamicPageHeader, string, sap.ui.@base.ManagedObject.BindAggregationInfo> header;

					/// <summary>
					/// <code>DynamicPage</code> content.
					/// 
					/// <b>Note:</b> The SAP Fiori Design guidelines require that the <code>DynamicPageHeader</code>'s content and the <code>DynamicPage</code>'s content are aligned vertically. When using {@link sap.ui.layout.form.Form}, {@link sap.m.Panel}, {@link sap.m.Table} and {@link sap.m.List} in the content area of <code>DynamicPage</code>, you need to adjust their left text offset to achieve the vertical alignment. To do this, apply the <code>sapFDynamicPageAlignContent</code> CSS class to them and set their <code>width</code> property to <code>auto</code> (if not set by default).
					/// 
					/// Example:
					/// 
					/// <pre>
					/// <code> &lt;Panel class=“sapFDynamicPageAlignContent” width=“auto”&gt;&lt;/Panel&gt; </code>
					/// </pre>
					/// 
					/// Please keep in mind that the alignment is not possible when the controls are placed in a {@link sap.ui.layout.Grid} or in other layout controls that use <code>overflow:hidden</code> CSS property.
					/// </summary>
					public Union<sap.ui.core.Control, string, sap.ui.@base.ManagedObject.BindAggregationInfo> content;

					/// <summary>
					/// <code>DynamicPage</code> floating footer.
					/// </summary>
					public Union<sap.m.IBar, string, sap.ui.@base.ManagedObject.BindAggregationInfo> footer;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new <code>DynamicPage</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern DynamicPage(string sId, sap.f.DynamicPage.Settings mSettings);

				/// <summary>
				/// Constructor for a new <code>DynamicPage</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern DynamicPage(string sId);

				/// <summary>
				/// Constructor for a new <code>DynamicPage</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern DynamicPage();

				/// <summary>
				/// Constructor for a new <code>DynamicPage</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern DynamicPage(sap.f.DynamicPage.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property preserveHeaderStateOnScroll

				/// <summary>
				/// Gets current value of property {@link #getPreserveHeaderStateOnScroll preserveHeaderStateOnScroll}.
				/// 
				/// Preserves the current header state when scrolling. For example, if the user expands the header by clicking on the title and then scrolls down the page, the header will remain expanded.
				/// 
				/// <b>Note:</b> Based on internal rules, the value of the property is not always taken into account - for example, when the control is rendered on tablet or mobile and the control`s title and header are with height larger than the given threshold.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>preserveHeaderStateOnScroll</code></returns>
				public extern virtual bool getPreserveHeaderStateOnScroll();

				/// <summary>
				/// Sets a new value for property {@link #getPreserveHeaderStateOnScroll preserveHeaderStateOnScroll}.
				/// 
				/// Preserves the current header state when scrolling. For example, if the user expands the header by clicking on the title and then scrolls down the page, the header will remain expanded.
				/// 
				/// <b>Note:</b> Based on internal rules, the value of the property is not always taken into account - for example, when the control is rendered on tablet or mobile and the control`s title and header are with height larger than the given threshold.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bPreserveHeaderStateOnScroll">New value for property <code>preserveHeaderStateOnScroll</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.DynamicPage setPreserveHeaderStateOnScroll(bool bPreserveHeaderStateOnScroll);

				#endregion

				#region Methods for Property headerExpanded

				/// <summary>
				/// Gets current value of property {@link #getHeaderExpanded headerExpanded}.
				/// 
				/// Determines whether the header is expanded.
				/// 
				/// The header can be also expanded/collapsed by user interaction, which requires the property to be internally mutated by the control to reflect the changed state.
				/// 
				/// <b>Note:</b> As of version 1.48, you can initialize the control in collapsed header state by setting this property to <code>false</code>.
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
				/// <b>Note:</b> As of version 1.48, you can initialize the control in collapsed header state by setting this property to <code>false</code>.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bHeaderExpanded">New value for property <code>headerExpanded</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.DynamicPage setHeaderExpanded(bool bHeaderExpanded);

				#endregion

				#region Methods for Property toggleHeaderOnTitleClick

				/// <summary>
				/// Gets current value of property {@link #getToggleHeaderOnTitleClick toggleHeaderOnTitleClick}.
				/// 
				/// Determines whether the user can switch between the expanded/collapsed states of the <code>DynamicPageHeader</code> by clicking on the <code>DynamicPageTitle</code> or by using the expand/collapse visual indicators, positioned at the bottom of the <code>DynamicPageTitle</code> and the <code>DynamicPageHeader</code>. If set to <code>false</code>, the <code>DynamicPageTitle</code> is not clickable, the visual indicators are not available and the application must provide other means for expanding/collapsing the <code>DynamicPageHeader</code>, if necessary.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>toggleHeaderOnTitleClick</code></returns>
				public extern virtual bool getToggleHeaderOnTitleClick();

				/// <summary>
				/// Sets a new value for property {@link #getToggleHeaderOnTitleClick toggleHeaderOnTitleClick}.
				/// 
				/// Determines whether the user can switch between the expanded/collapsed states of the <code>DynamicPageHeader</code> by clicking on the <code>DynamicPageTitle</code> or by using the expand/collapse visual indicators, positioned at the bottom of the <code>DynamicPageTitle</code> and the <code>DynamicPageHeader</code>. If set to <code>false</code>, the <code>DynamicPageTitle</code> is not clickable, the visual indicators are not available and the application must provide other means for expanding/collapsing the <code>DynamicPageHeader</code>, if necessary.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bToggleHeaderOnTitleClick">New value for property <code>toggleHeaderOnTitleClick</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.DynamicPage setToggleHeaderOnTitleClick(bool bToggleHeaderOnTitleClick);

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
				public extern virtual sap.f.DynamicPage setShowFooter(bool bShowFooter);

				#endregion

				#region Methods for Property fitContent

				/// <summary>
				/// Gets current value of property {@link #getFitContent fitContent}.
				/// 
				/// Optimizes <code>DynamicPage</code> responsiveness on small screens and behavior when expanding/collapsing the <code>DynamicPageHeader</code>.
				/// 
				/// <b>Note:</b> It is recommended to use this property when displaying content of adaptive controls that stretch to fill the available space. Such controls may be {@link sap.ui.table.Table} and {@link sap.ui.table.AnalyticalTable} depending on their settings.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>fitContent</code></returns>
				public extern virtual bool getFitContent();

				/// <summary>
				/// Sets a new value for property {@link #getFitContent fitContent}.
				/// 
				/// Optimizes <code>DynamicPage</code> responsiveness on small screens and behavior when expanding/collapsing the <code>DynamicPageHeader</code>.
				/// 
				/// <b>Note:</b> It is recommended to use this property when displaying content of adaptive controls that stretch to fill the available space. Such controls may be {@link sap.ui.table.Table} and {@link sap.ui.table.AnalyticalTable} depending on their settings.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bFitContent">New value for property <code>fitContent</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.DynamicPage setFitContent(bool bFitContent);

				#endregion

				#region Methods for Aggregation title

				/// <summary>
				/// Gets content of aggregation {@link #getTitle title}.
				/// 
				/// <code>DynamicPage</code> title.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.f.DynamicPageTitle getTitle();

				/// <summary>
				/// Destroys the title in the aggregation {@link #getTitle title}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.DynamicPage destroyTitle();

				/// <summary>
				/// Sets the aggregated {@link #getTitle title}.
				/// </summary>
				/// <param name="oTitle">The title to set</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.DynamicPage setTitle(sap.f.DynamicPageTitle oTitle);

				#endregion

				#region Methods for Aggregation header

				/// <summary>
				/// Gets content of aggregation {@link #getHeader header}.
				/// 
				/// <code>DynamicPage</code> header.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.f.DynamicPageHeader getHeader();

				/// <summary>
				/// Destroys the header in the aggregation {@link #getHeader header}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.DynamicPage destroyHeader();

				/// <summary>
				/// Sets the aggregated {@link #getHeader header}.
				/// </summary>
				/// <param name="oHeader">The header to set</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.DynamicPage setHeader(sap.f.DynamicPageHeader oHeader);

				#endregion

				#region Methods for Aggregation content

				/// <summary>
				/// Gets content of aggregation {@link #getContent content}.
				/// 
				/// <code>DynamicPage</code> content.
				/// 
				/// <b>Note:</b> The SAP Fiori Design guidelines require that the <code>DynamicPageHeader</code>'s content and the <code>DynamicPage</code>'s content are aligned vertically. When using {@link sap.ui.layout.form.Form}, {@link sap.m.Panel}, {@link sap.m.Table} and {@link sap.m.List} in the content area of <code>DynamicPage</code>, you need to adjust their left text offset to achieve the vertical alignment. To do this, apply the <code>sapFDynamicPageAlignContent</code> CSS class to them and set their <code>width</code> property to <code>auto</code> (if not set by default).
				/// 
				/// Example:
				/// 
				/// <pre>
				/// <code> &lt;Panel class=“sapFDynamicPageAlignContent” width=“auto”&gt;&lt;/Panel&gt; </code>
				/// </pre>
				/// 
				/// Please keep in mind that the alignment is not possible when the controls are placed in a {@link sap.ui.layout.Grid} or in other layout controls that use <code>overflow:hidden</code> CSS property.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.Control getContent();

				/// <summary>
				/// Destroys the content in the aggregation {@link #getContent content}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.DynamicPage destroyContent();

				/// <summary>
				/// Sets the aggregated {@link #getContent content}.
				/// </summary>
				/// <param name="oContent">The content to set</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.DynamicPage setContent(sap.ui.core.Control oContent);

				#endregion

				#region Methods for Aggregation footer

				/// <summary>
				/// Gets content of aggregation {@link #getFooter footer}.
				/// 
				/// <code>DynamicPage</code> floating footer.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.IBar getFooter();

				/// <summary>
				/// Destroys the footer in the aggregation {@link #getFooter footer}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.DynamicPage destroyFooter();

				/// <summary>
				/// Sets the aggregated {@link #getFooter footer}.
				/// </summary>
				/// <param name="oFooter">The footer to set</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.f.DynamicPage setFooter(sap.m.IBar oFooter);

				#endregion

				#region Methods for Aggregation _scrollBar

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.f.DynamicPage with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.f.DynamicPage with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.f.DynamicPage with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.f.DynamicPage.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				#endregion

				#endregion

			}
		}
	}
}
