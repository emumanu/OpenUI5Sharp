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
			public static partial class layout
			{
				/// <summary>
				/// PaneContainer is an abstraction of Splitter.
				/// 
				/// Could be used as an aggregation of ResponsiveSplitter or other PaneContainers.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.layout.PaneContainer")]
				public partial class PaneContainer : sap.ui.core.Element
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
						/// The orientation of the Splitter
						/// </summary>
						public Union<sap.ui.core.Orientation, string, sap.ui.@base.ManagedObject.BindPropertyInfo> orientation;

						/// <summary>
						/// The Pane that will be shown when there is no suitable pane for ResponsiveSplitter's current width.
						/// </summary>
						public Union<sap.ui.core.Element[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> panes;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new PaneContainer.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern PaneContainer(string sId, sap.ui.layout.PaneContainer.Settings mSettings);

					/// <summary>
					/// Constructor for a new PaneContainer.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					public extern PaneContainer(string sId);

					/// <summary>
					/// Constructor for a new PaneContainer.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern PaneContainer();

					/// <summary>
					/// Constructor for a new PaneContainer.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern PaneContainer(sap.ui.layout.PaneContainer.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property orientation

					/// <summary>
					/// Gets current value of property {@link #getOrientation orientation}.
					/// 
					/// The orientation of the Splitter
					/// 
					/// Default value is <code>Horizontal</code>.
					/// </summary>
					/// <returns>Value of property <code>orientation</code></returns>
					public extern virtual sap.ui.core.Orientation getOrientation();

					/// <summary>
					/// Setter for property orientation. Default value is sap.ui.core.Orientation.Horizontal
					/// </summary>
					/// <param name="sOrientation">The Orientation type.</param>
					/// <returns>this to allow method chaining.</returns>
					public extern virtual sap.ui.layout.PaneContainer setOrientation(sap.ui.core.Orientation sOrientation);

					#endregion

					#region Methods for Aggregation panes

					/// <summary>
					/// Gets content of aggregation {@link #getPanes panes}.
					/// 
					/// The Pane that will be shown when there is no suitable pane for ResponsiveSplitter's current width.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.Element[] getPanes();

					/// <summary>
					/// Destroys all the panes in the aggregation {@link #getPanes panes}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.PaneContainer destroyPanes();

					/// <summary>
					/// Pane insertion
					/// </summary>
					/// <param name="oObject"></param>
					/// <param name="iIndex"></param>
					/// <returns></returns>
					public extern virtual sap.ui.@base.ManagedObject insertPane(object oObject, object iIndex);

					/// <summary>
					/// Adds some pane to the aggregation {@link #getPanes panes}.
					/// </summary>
					/// <param name="oPane">The pane to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.PaneContainer addPane(sap.ui.core.Element oPane);

					/// <summary>
					/// Pane removal
					/// </summary>
					/// <param name="oObject"></param>
					/// <returns></returns>
					public extern virtual sap.ui.@base.ManagedObject removePane(object oObject);

					/// <summary>
					/// Checks for the provided <code>sap.ui.core.Element</code> in the aggregation {@link #getPanes panes}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oPane">The pane whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfPane(sap.ui.core.Element oPane);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getPanes panes}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.core.Element[] removeAllPanes();

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.layout.PaneContainer with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.layout.PaneContainer with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.layout.PaneContainer with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.layout.PaneContainer.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					/// <summary>
					/// Setter for property layoutData.
					/// </summary>
					/// <param name="oLayoutData">The LayoutData object.</param>
					/// <returns>this to allow method chaining.</returns>
					public extern virtual sap.ui.layout.PaneContainer setLayoutData(sap.ui.core.LayoutData oLayoutData);

					#endregion

					#endregion

				}
			}
		}
	}
}
