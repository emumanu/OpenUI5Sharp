using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public static partial class sap
	{
		public static partial class tnt
		{
			/// <summary>
			/// The ToolPage is a layout control, used to create a basic tools app that has a header, side navigation and contents area. <h4>Overview</h4> The control has three main areas - a header on top, navigation to the side and a content are that can hold any control. The header and side navigation use custom controls - {@link sap.tnt.ToolHeader} and {@link sap.tnt.SideNavigation}. <h4>Usage</h4> The main usage for the asp.tnt controls is for scenarios in the tooling or administration space.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.tnt.ToolPage")]
			public partial class ToolPage : sap.ui.core.Control
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
					/// Indicates if the side area is expanded. Overrides the expanded property of the sideContent aggregation.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> sideExpanded;

					/// <summary>
					/// The control to appear in the header area.
					/// </summary>
					public Union<sap.tnt.ToolHeader, string, sap.ui.@base.ManagedObject.BindAggregationInfo> header;

					/// <summary>
					/// The side menu of the layout.
					/// </summary>
					public Union<sap.tnt.SideNavigation, string, sap.ui.@base.ManagedObject.BindAggregationInfo> sideContent;

					/// <summary>
					/// The content section.
					/// </summary>
					public Union<sap.ui.core.Control[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> mainContents;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new ToolPage.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no id is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern ToolPage(string sId, sap.tnt.ToolPage.Settings mSettings);

				/// <summary>
				/// Constructor for a new ToolPage.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no id is given</param>
				public extern ToolPage(string sId);

				/// <summary>
				/// Constructor for a new ToolPage.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern ToolPage();

				/// <summary>
				/// Constructor for a new ToolPage.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern ToolPage(sap.tnt.ToolPage.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property sideExpanded

				/// <summary>
				/// Gets current value of property {@link #getSideExpanded sideExpanded}.
				/// 
				/// Indicates if the side area is expanded. Overrides the expanded property of the sideContent aggregation.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>sideExpanded</code></returns>
				public extern virtual bool getSideExpanded();

				/// <summary>
				/// Sets the expand/collapse state of the SideContent.
				/// </summary>
				/// <param name="isSideExpanded">defines whether the SideNavigation is expanded.</param>
				/// <returns>Pointer to the control instance for chaining</returns>
				public extern virtual sap.tnt.ToolPage setSideExpanded(bool isSideExpanded);

				#endregion

				#region Methods for Aggregation header

				/// <summary>
				/// Gets content of aggregation {@link #getHeader header}.
				/// 
				/// The control to appear in the header area.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.tnt.ToolHeader getHeader();

				/// <summary>
				/// Destroys the header in the aggregation {@link #getHeader header}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.tnt.ToolPage destroyHeader();

				/// <summary>
				/// Sets the aggregated {@link #getHeader header}.
				/// </summary>
				/// <param name="oHeader">The header to set</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.tnt.ToolPage setHeader(sap.tnt.ToolHeader oHeader);

				#endregion

				#region Methods for Aggregation sideContent

				/// <summary>
				/// Gets content of aggregation {@link #getSideContent sideContent}.
				/// 
				/// The side menu of the layout.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.tnt.SideNavigation getSideContent();

				/// <summary>
				/// Destroys the sideContent in the aggregation {@link #getSideContent sideContent}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.tnt.ToolPage destroySideContent();

				/// <summary>
				/// Sets the aggregated {@link #getSideContent sideContent}.
				/// </summary>
				/// <param name="oSideContent">The sideContent to set</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.tnt.ToolPage setSideContent(sap.tnt.SideNavigation oSideContent);

				#endregion

				#region Methods for Aggregation mainContents

				/// <summary>
				/// Gets content of aggregation {@link #getMainContents mainContents}.
				/// 
				/// The content section.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.Control[] getMainContents();

				/// <summary>
				/// Destroys all the mainContents in the aggregation {@link #getMainContents mainContents}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.tnt.ToolPage destroyMainContents();

				/// <summary>
				/// Inserts a mainContent into the aggregation {@link #getMainContents mainContents}.
				/// </summary>
				/// <param name="oMainContent">The mainContent to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the mainContent should be inserted at; for a negative value of <code>iIndex</code>, the mainContent is inserted at position 0; for a value greater than the current size of the aggregation, the mainContent is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.tnt.ToolPage insertMainContent(sap.ui.core.Control oMainContent, int iIndex);

				/// <summary>
				/// Adds some mainContent to the aggregation {@link #getMainContents mainContents}.
				/// </summary>
				/// <param name="oMainContent">The mainContent to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.tnt.ToolPage addMainContent(sap.ui.core.Control oMainContent);

				/// <summary>
				/// Removes a mainContent from the aggregation {@link #getMainContents mainContents}.
				/// </summary>
				/// <param name="vMainContent">The mainContent to remove or its index or id</param>
				/// <returns>The removed mainContent or <code>null</code></returns>
				public extern virtual sap.ui.core.Control removeMainContent(Union<int, string, sap.ui.core.Control> vMainContent);

				/// <summary>
				/// Checks for the provided <code>sap.ui.core.Control</code> in the aggregation {@link #getMainContents mainContents}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oMainContent">The mainContent whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfMainContent(sap.ui.core.Control oMainContent);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getMainContents mainContents}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.ui.core.Control[] removeAllMainContents();

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.tnt.ToolPage with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.tnt.ToolPage with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.tnt.ToolPage with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.tnt.ToolPage.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				/// <summary>
				/// Toggles the expand/collapse state of the SideContent.
				/// </summary>
				/// <returns>Pointer to the control instance for chaining.</returns>
				public extern virtual sap.tnt.ToolPage toggleSideContentMode();

				#endregion

				#endregion

			}
		}
	}
}
