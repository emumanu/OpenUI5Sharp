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
			public static partial class commons
			{
				/// <summary>
				/// Allows to split the screen into two areas. Make sure that the container for the splitter has an absolute height or set an absolute height for the splitter using the height property. Otherwise the height of the splitter is calculated by the height of its contents.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.Splitter")]
				[Obsolete("Deprecated since 1.38. Instead, use the <code>sap.ui.layout.Splitter</code> control.")]
				public partial class Splitter : sap.ui.core.Control
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
						/// The splitter can have horizontal or vertical orientation.
						/// </summary>
						public Union<sap.ui.core.Orientation, string, sap.ui.@base.ManagedObject.BindPropertyInfo> splitterOrientation;

						/// <summary>
						/// Position of splitter bar in percentage. The default value means that the splitter is positioned in the middle of the area that is available for the splitter.
						/// </summary>
						public Union<sap.ui.core.Percentage, string, sap.ui.@base.ManagedObject.BindPropertyInfo> splitterPosition;

						/// <summary>
						/// The minimum size (width for vertical splitter or height for horizontal splitter) of the first Pane
						/// </summary>
						public Union<sap.ui.core.Percentage, string, sap.ui.@base.ManagedObject.BindPropertyInfo> minSizeFirstPane;

						/// <summary>
						/// The minimum size (width for vertical splitter or height for horizontal splitter) of the second Pane
						/// </summary>
						public Union<sap.ui.core.Percentage, string, sap.ui.@base.ManagedObject.BindPropertyInfo> minSizeSecondPane;

						/// <summary>
						/// The width of the split area in px or in %
						/// </summary>
						public Union<sap.ui.commons.SplitterSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> width;

						/// <summary>
						/// The height of the split area in px or in %
						/// </summary>
						public Union<sap.ui.commons.SplitterSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> height;

						/// <summary>
						/// Specifies if the browser should display scroll bars or simply cut the content of a splitter pane when the content does not fit into its pane.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showScrollBars;

						/// <summary>
						/// set the splitter bar to be visible or not.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> splitterBarVisible;

						/// <summary>
						/// Controls inside the first pane. These are the left ones in case of defining a vertical splitter, and the top ones in case of using the horizontal splitter.
						/// </summary>
						public Union<sap.ui.core.Control[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> firstPaneContent;

						/// <summary>
						/// Controls inside the second pane. These are the right ones in case of defining a vertical splitter, and the bottom ones in case of using the horizontal splitter.
						/// </summary>
						public Union<sap.ui.core.Control[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> secondPaneContent;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new Splitter.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern Splitter(string sId, sap.ui.commons.Splitter.Settings mSettings);

					/// <summary>
					/// Constructor for a new Splitter.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern Splitter(string sId);

					/// <summary>
					/// Constructor for a new Splitter.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern Splitter();

					/// <summary>
					/// Constructor for a new Splitter.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern Splitter(sap.ui.commons.Splitter.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property splitterOrientation

					/// <summary>
					/// Gets current value of property {@link #getSplitterOrientation splitterOrientation}.
					/// 
					/// The splitter can have horizontal or vertical orientation.
					/// 
					/// Default value is <code>Vertical</code>.
					/// </summary>
					/// <returns>Value of property <code>splitterOrientation</code></returns>
					public extern virtual sap.ui.core.Orientation getSplitterOrientation();

					/// <summary>
					/// Sets a new value for property {@link #getSplitterOrientation splitterOrientation}.
					/// 
					/// The splitter can have horizontal or vertical orientation.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>Vertical</code>.
					/// </summary>
					/// <param name="sSplitterOrientation">New value for property <code>splitterOrientation</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Splitter setSplitterOrientation(sap.ui.core.Orientation sSplitterOrientation);

					#endregion

					#region Methods for Property splitterPosition

					/// <summary>
					/// Gets current value of property {@link #getSplitterPosition splitterPosition}.
					/// 
					/// Position of splitter bar in percentage. The default value means that the splitter is positioned in the middle of the area that is available for the splitter.
					/// 
					/// Default value is <code>50%</code>.
					/// </summary>
					/// <returns>Value of property <code>splitterPosition</code></returns>
					public extern virtual sap.ui.core.Percentage getSplitterPosition();

					/// <summary>
					/// Sets a new value for property {@link #getSplitterPosition splitterPosition}.
					/// 
					/// Position of splitter bar in percentage. The default value means that the splitter is positioned in the middle of the area that is available for the splitter.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>50%</code>.
					/// </summary>
					/// <param name="sSplitterPosition">New value for property <code>splitterPosition</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Splitter setSplitterPosition(sap.ui.core.Percentage sSplitterPosition);

					#endregion

					#region Methods for Property minSizeFirstPane

					/// <summary>
					/// Gets current value of property {@link #getMinSizeFirstPane minSizeFirstPane}.
					/// 
					/// The minimum size (width for vertical splitter or height for horizontal splitter) of the first Pane
					/// 
					/// Default value is <code>0%</code>.
					/// </summary>
					/// <returns>Value of property <code>minSizeFirstPane</code></returns>
					public extern virtual sap.ui.core.Percentage getMinSizeFirstPane();

					/// <summary>
					/// Sets a new value for property {@link #getMinSizeFirstPane minSizeFirstPane}.
					/// 
					/// The minimum size (width for vertical splitter or height for horizontal splitter) of the first Pane
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>0%</code>.
					/// </summary>
					/// <param name="sMinSizeFirstPane">New value for property <code>minSizeFirstPane</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Splitter setMinSizeFirstPane(sap.ui.core.Percentage sMinSizeFirstPane);

					#endregion

					#region Methods for Property minSizeSecondPane

					/// <summary>
					/// Gets current value of property {@link #getMinSizeSecondPane minSizeSecondPane}.
					/// 
					/// The minimum size (width for vertical splitter or height for horizontal splitter) of the second Pane
					/// 
					/// Default value is <code>0%</code>.
					/// </summary>
					/// <returns>Value of property <code>minSizeSecondPane</code></returns>
					public extern virtual sap.ui.core.Percentage getMinSizeSecondPane();

					/// <summary>
					/// Sets a new value for property {@link #getMinSizeSecondPane minSizeSecondPane}.
					/// 
					/// The minimum size (width for vertical splitter or height for horizontal splitter) of the second Pane
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>0%</code>.
					/// </summary>
					/// <param name="sMinSizeSecondPane">New value for property <code>minSizeSecondPane</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Splitter setMinSizeSecondPane(sap.ui.core.Percentage sMinSizeSecondPane);

					#endregion

					#region Methods for Property width

					/// <summary>
					/// Gets current value of property {@link #getWidth width}.
					/// 
					/// The width of the split area in px or in %
					/// 
					/// Default value is <code>100%</code>.
					/// </summary>
					/// <returns>Value of property <code>width</code></returns>
					public extern virtual sap.ui.commons.SplitterSize getWidth();

					/// <summary>
					/// Sets a new value for property {@link #getWidth width}.
					/// 
					/// The width of the split area in px or in %
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>100%</code>.
					/// </summary>
					/// <param name="sWidth">New value for property <code>width</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Splitter setWidth(sap.ui.commons.SplitterSize sWidth);

					#endregion

					#region Methods for Property height

					/// <summary>
					/// Gets current value of property {@link #getHeight height}.
					/// 
					/// The height of the split area in px or in %
					/// 
					/// Default value is <code>100%</code>.
					/// </summary>
					/// <returns>Value of property <code>height</code></returns>
					public extern virtual sap.ui.commons.SplitterSize getHeight();

					/// <summary>
					/// Sets a new value for property {@link #getHeight height}.
					/// 
					/// The height of the split area in px or in %
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>100%</code>.
					/// </summary>
					/// <param name="sHeight">New value for property <code>height</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Splitter setHeight(sap.ui.commons.SplitterSize sHeight);

					#endregion

					#region Methods for Property showScrollBars

					/// <summary>
					/// Gets current value of property {@link #getShowScrollBars showScrollBars}.
					/// 
					/// Specifies if the browser should display scroll bars or simply cut the content of a splitter pane when the content does not fit into its pane.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>showScrollBars</code></returns>
					public extern virtual bool getShowScrollBars();

					/// <summary>
					/// Sets a new value for property {@link #getShowScrollBars showScrollBars}.
					/// 
					/// Specifies if the browser should display scroll bars or simply cut the content of a splitter pane when the content does not fit into its pane.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bShowScrollBars">New value for property <code>showScrollBars</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Splitter setShowScrollBars(bool bShowScrollBars);

					#endregion

					#region Methods for Property splitterBarVisible

					/// <summary>
					/// Gets current value of property {@link #getSplitterBarVisible splitterBarVisible}.
					/// 
					/// set the splitter bar to be visible or not.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>splitterBarVisible</code></returns>
					public extern virtual bool getSplitterBarVisible();

					/// <summary>
					/// Sets a new value for property {@link #getSplitterBarVisible splitterBarVisible}.
					/// 
					/// set the splitter bar to be visible or not.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bSplitterBarVisible">New value for property <code>splitterBarVisible</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Splitter setSplitterBarVisible(bool bSplitterBarVisible);

					#endregion

					#region Methods for Aggregation firstPaneContent

					/// <summary>
					/// Gets content of aggregation {@link #getFirstPaneContent firstPaneContent}.
					/// 
					/// Controls inside the first pane. These are the left ones in case of defining a vertical splitter, and the top ones in case of using the horizontal splitter.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.Control[] getFirstPaneContent();

					/// <summary>
					/// Destroys all the firstPaneContent in the aggregation {@link #getFirstPaneContent firstPaneContent}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Splitter destroyFirstPaneContent();

					/// <summary>
					/// Inserts a firstPaneContent into the aggregation {@link #getFirstPaneContent firstPaneContent}.
					/// </summary>
					/// <param name="oFirstPaneContent">The firstPaneContent to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the firstPaneContent should be inserted at; for a negative value of <code>iIndex</code>, the firstPaneContent is inserted at position 0; for a value greater than the current size of the aggregation, the firstPaneContent is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Splitter insertFirstPaneContent(sap.ui.core.Control oFirstPaneContent, int iIndex);

					/// <summary>
					/// Adds some firstPaneContent to the aggregation {@link #getFirstPaneContent firstPaneContent}.
					/// </summary>
					/// <param name="oFirstPaneContent">The firstPaneContent to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Splitter addFirstPaneContent(sap.ui.core.Control oFirstPaneContent);

					/// <summary>
					/// Removes a firstPaneContent from the aggregation {@link #getFirstPaneContent firstPaneContent}.
					/// </summary>
					/// <param name="vFirstPaneContent">The firstPaneContent to remove or its index or id</param>
					/// <returns>The removed firstPaneContent or <code>null</code></returns>
					public extern virtual sap.ui.core.Control removeFirstPaneContent(Union<int, string, sap.ui.core.Control> vFirstPaneContent);

					/// <summary>
					/// Checks for the provided <code>sap.ui.core.Control</code> in the aggregation {@link #getFirstPaneContent firstPaneContent}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oFirstPaneContent">The firstPaneContent whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfFirstPaneContent(sap.ui.core.Control oFirstPaneContent);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getFirstPaneContent firstPaneContent}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.core.Control[] removeAllFirstPaneContent();

					#endregion

					#region Methods for Aggregation secondPaneContent

					/// <summary>
					/// Gets content of aggregation {@link #getSecondPaneContent secondPaneContent}.
					/// 
					/// Controls inside the second pane. These are the right ones in case of defining a vertical splitter, and the bottom ones in case of using the horizontal splitter.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.Control[] getSecondPaneContent();

					/// <summary>
					/// Destroys all the secondPaneContent in the aggregation {@link #getSecondPaneContent secondPaneContent}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Splitter destroySecondPaneContent();

					/// <summary>
					/// Inserts a secondPaneContent into the aggregation {@link #getSecondPaneContent secondPaneContent}.
					/// </summary>
					/// <param name="oSecondPaneContent">The secondPaneContent to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the secondPaneContent should be inserted at; for a negative value of <code>iIndex</code>, the secondPaneContent is inserted at position 0; for a value greater than the current size of the aggregation, the secondPaneContent is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Splitter insertSecondPaneContent(sap.ui.core.Control oSecondPaneContent, int iIndex);

					/// <summary>
					/// Adds some secondPaneContent to the aggregation {@link #getSecondPaneContent secondPaneContent}.
					/// </summary>
					/// <param name="oSecondPaneContent">The secondPaneContent to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Splitter addSecondPaneContent(sap.ui.core.Control oSecondPaneContent);

					/// <summary>
					/// Removes a secondPaneContent from the aggregation {@link #getSecondPaneContent secondPaneContent}.
					/// </summary>
					/// <param name="vSecondPaneContent">The secondPaneContent to remove or its index or id</param>
					/// <returns>The removed secondPaneContent or <code>null</code></returns>
					public extern virtual sap.ui.core.Control removeSecondPaneContent(Union<int, string, sap.ui.core.Control> vSecondPaneContent);

					/// <summary>
					/// Checks for the provided <code>sap.ui.core.Control</code> in the aggregation {@link #getSecondPaneContent secondPaneContent}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oSecondPaneContent">The secondPaneContent whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfSecondPaneContent(sap.ui.core.Control oSecondPaneContent);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getSecondPaneContent secondPaneContent}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.core.Control[] removeAllSecondPaneContent();

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.Splitter with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.Splitter with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.Splitter with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.commons.Splitter.
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
