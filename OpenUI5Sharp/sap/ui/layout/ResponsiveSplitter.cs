using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace OpenUI5Sharp
{
	public static partial class sap
	{
		public static partial class ui
		{
			public static partial class layout
			{
				/// <summary>
				/// A responsive splitter which divides the application into several areas. <h3>Overview</h3> The responsive splitter layout structures complex applications into defined areas. These areas may be resizable and are either distributed across one or multiple screen areas, some of which may also be off-canvas.
				/// 
				/// The control is intended for developing administrative tools and applications. <h3>Structure</h3> The responsive splitter holds the following hierarchy of containers and controls: <ul> <li>{@link sap.ui.layout.PaneContainer Pane Container} - holds one or more Split Panes and determines the pane orientation. The pane which is stored in <code>rootPaneContainer</code> holds all other pane containers and split panes.</li> <li>{@link sap.ui.layout.SplitPane Split Pane} - independent containers that may interact with one another. Each pane can hold only one control.</li> </ul> <h3>Usage</h3> <h4>When to use</h4> <ul> <li>The application has to display several areas side by side that must be resizable.</li> <li>The application must work on a range of different devices in a responsive manner.</li> </ul> <h3>Responsive Behavior</h3> <ul> <li>As soon as views are in the off-canvas mode, the pagination bar at the bottom of the application allows the user to switch between them.</li> <li>On touch-enabled devices, the splitters show explicit handles with larger touch areas.</li> <li>Double-clicking on a splitter will collapse or expand it back to its original position.</li> </ul>
				/// 
				/// <b>Note:</b> We don't recommend dynamically inserting/removing panes into/from the PaneContainer since this might lead to inconsistent layout. If it is necessary, you need to ensure the sum of all sizes of the SplitPanes doesn't exceed the width of the PaneContainer.
				/// </summary>
				[External]
				[Namespace(false)]
				public partial class ResponsiveSplitter : sap.ui.core.Control
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
						/// The width of the control
						/// </summary>
						public Union<sap.ui.core.CSSSize, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> width;

						/// <summary>
						/// The height of the control
						/// </summary>
						public Union<sap.ui.core.CSSSize, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> height;

						/// <summary>
						/// The root PaneContainer of the ResponsiveSplitter
						/// </summary>
						public Union<sap.ui.layout.PaneContainer, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> rootPaneContainer;

						/// <summary>
						/// The default pane that will remain always visible If no defaultPane is specified, the ResponsiveSplitter sets the first SplitPane that is added to a PaneContainer in it as a default.
						/// </summary>
						public Union<sap.ui.layout.SplitPane, sap.ui.core.ID, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> defaultPane;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new ResponsiveSplitter.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern ResponsiveSplitter(string sId, sap.ui.layout.ResponsiveSplitter.Settings mSettings);

					/// <summary>
					/// Constructor for a new ResponsiveSplitter.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					public extern ResponsiveSplitter(string sId);

					/// <summary>
					/// Constructor for a new ResponsiveSplitter.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern ResponsiveSplitter();

					/// <summary>
					/// Constructor for a new ResponsiveSplitter.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern ResponsiveSplitter(sap.ui.layout.ResponsiveSplitter.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property width

					/// <summary>
					/// Gets current value of property {@link #getWidth width}.
					/// 
					/// The width of the control
					/// 
					/// Default value is <code>100%</code>.
					/// </summary>
					/// <returns>Value of property <code>width</code></returns>
					public extern virtual sap.ui.core.CSSSize getWidth();

					/// <summary>
					/// Sets a new value for property {@link #getWidth width}.
					/// 
					/// The width of the control
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>100%</code>.
					/// </summary>
					/// <param name="sWidth">New value for property <code>width</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.ResponsiveSplitter setWidth(sap.ui.core.CSSSize sWidth);

					#endregion

					#region Methods for Property height

					/// <summary>
					/// Gets current value of property {@link #getHeight height}.
					/// 
					/// The height of the control
					/// 
					/// Default value is <code>100%</code>.
					/// </summary>
					/// <returns>Value of property <code>height</code></returns>
					public extern virtual sap.ui.core.CSSSize getHeight();

					/// <summary>
					/// Sets a new value for property {@link #getHeight height}.
					/// 
					/// The height of the control
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>100%</code>.
					/// </summary>
					/// <param name="sHeight">New value for property <code>height</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.ResponsiveSplitter setHeight(sap.ui.core.CSSSize sHeight);

					#endregion

					#region Methods for Aggregation rootPaneContainer

					/// <summary>
					/// Gets content of aggregation {@link #getRootPaneContainer rootPaneContainer}.
					/// 
					/// The root PaneContainer of the ResponsiveSplitter
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.layout.PaneContainer getRootPaneContainer();

					/// <summary>
					/// Destroys the rootPaneContainer in the aggregation {@link #getRootPaneContainer rootPaneContainer}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.ResponsiveSplitter destroyRootPaneContainer();

					/// <summary>
					/// Sets the aggregated {@link #getRootPaneContainer rootPaneContainer}.
					/// </summary>
					/// <param name="oRootPaneContainer">The rootPaneContainer to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.ResponsiveSplitter setRootPaneContainer(sap.ui.layout.PaneContainer oRootPaneContainer);

					#endregion

					#region Methods for Aggregation _pages

					#endregion

					#region Methods for Association defaultPane

					/// <summary>
					/// ID of the element which is the current target of the association {@link #getDefaultPane defaultPane}, or <code>null</code>.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.ID getDefaultPane();

					/// <summary>
					/// Sets the associated {@link #getDefaultPane defaultPane}.
					/// </summary>
					/// <param name="oDefaultPane">ID of an element which becomes the new target of this defaultPane association; alternatively, an element instance may be given</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.ResponsiveSplitter setDefaultPane(Union<sap.ui.core.ID, sap.ui.layout.SplitPane> oDefaultPane);

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.layout.ResponsiveSplitter with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.layout.ResponsiveSplitter with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.layout.ResponsiveSplitter with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.layout.ResponsiveSplitter.
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
