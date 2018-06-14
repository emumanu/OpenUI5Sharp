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
				/// SplitPane is a container of a single control in a responsive splitter. Could be used as an aggregation of a {@link sap.ui.layout.PaneContainer PaneContainer}.
				/// 
				/// The behavior of the Split Panes is handled by the following properties: <ul> <li><code>requiredParentWidth</code> - determines the minimum width of the parent container (in pixels). When it is reached, the pane will be hidden from the screen.</li> <li><code>demandPane</code> - determines if the pane is reachable via the pagination bar after it has been hidden from the screen.</li> </ul
				/// </summary>
				[External]
				[Namespace(false)]
				public partial class SplitPane : sap.ui.core.Element
				{
					#region Settings

					/// <summary>
					/// Settings class to create the object
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class Settings : sap.ui.core.Element.Settings
					{
						/// <summary>
						/// Determines whether the pane will be moved to the pagination
						/// </summary>
						public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> demandPane;

						/// <summary>
						/// Determines the minimum width of the ResponsiveSplitter(in pixels). When it is reached the pane will be hidden from the screen.
						/// </summary>
						public Union<int, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> requiredParentWidth;

						/// <summary>
						/// Content of the SplitPane
						/// </summary>
						public Union<sap.ui.core.Control, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> content;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new SplitPane.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern SplitPane(string sId, sap.ui.layout.SplitPane.Settings mSettings);

					/// <summary>
					/// Constructor for a new SplitPane.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					public extern SplitPane(string sId);

					/// <summary>
					/// Constructor for a new SplitPane.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern SplitPane();

					/// <summary>
					/// Constructor for a new SplitPane.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern SplitPane(sap.ui.layout.SplitPane.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property demandPane

					/// <summary>
					/// Gets current value of property {@link #getDemandPane demandPane}.
					/// 
					/// Determines whether the pane will be moved to the pagination
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>demandPane</code></returns>
					public extern virtual bool getDemandPane();

					/// <summary>
					/// Sets a new value for property {@link #getDemandPane demandPane}.
					/// 
					/// Determines whether the pane will be moved to the pagination
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bDemandPane">New value for property <code>demandPane</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.SplitPane setDemandPane(bool bDemandPane);

					#endregion

					#region Methods for Property requiredParentWidth

					/// <summary>
					/// Gets current value of property {@link #getRequiredParentWidth requiredParentWidth}.
					/// 
					/// Determines the minimum width of the ResponsiveSplitter(in pixels). When it is reached the pane will be hidden from the screen.
					/// 
					/// Default value is <code>800</code>.
					/// </summary>
					/// <returns>Value of property <code>requiredParentWidth</code></returns>
					public extern virtual int getRequiredParentWidth();

					/// <summary>
					/// Sets a new value for property {@link #getRequiredParentWidth requiredParentWidth}.
					/// 
					/// Determines the minimum width of the ResponsiveSplitter(in pixels). When it is reached the pane will be hidden from the screen.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>800</code>.
					/// </summary>
					/// <param name="iRequiredParentWidth">New value for property <code>requiredParentWidth</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.SplitPane setRequiredParentWidth(int iRequiredParentWidth);

					#endregion

					#region Methods for Aggregation content

					/// <summary>
					/// Gets content of aggregation {@link #getContent content}.
					/// 
					/// Content of the SplitPane
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.Control getContent();

					/// <summary>
					/// Destroys the content in the aggregation {@link #getContent content}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.SplitPane destroyContent();

					/// <summary>
					/// Sets the aggregated {@link #getContent content}.
					/// </summary>
					/// <param name="oContent">The content to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.SplitPane setContent(sap.ui.core.Control oContent);

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.layout.SplitPane with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.layout.SplitPane with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.layout.SplitPane with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.layout.SplitPane.
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
