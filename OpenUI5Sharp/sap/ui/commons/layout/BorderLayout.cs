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
				public static partial class layout
				{
					/// <summary>
					/// Based upon the border layout as it comes with the Java standard. Using this layout, you are able to divide your available UI space into five areas whose sizes can be defined. These areas are: Top: Header; Bottom: Footer; Begin: Left/right-hand side panel; Center: Content area in the middle; End: Right/left-hand side panel.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.commons.layout.BorderLayout")]
					[Obsolete("Deprecated since 1.38. replaced by {@link sap.m.Page}")]
					public partial class BorderLayout : sap.ui.core.Control
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
							/// The RTL setting swaps the areas Begin and End.
							/// </summary>
							public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> rtl;

							/// <summary>
							/// Defines the overall width of the layout
							/// </summary>
							public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> width;

							/// <summary>
							/// Defines the overall height of the layout
							/// </summary>
							public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> height;

							/// <summary>
							/// Represents the Top area
							/// </summary>
							public Union<sap.ui.commons.layout.BorderLayoutArea, string, sap.ui.@base.ManagedObject.BindAggregationInfo> top;

							/// <summary>
							/// Represents the Begin area
							/// </summary>
							public Union<sap.ui.commons.layout.BorderLayoutArea, string, sap.ui.@base.ManagedObject.BindAggregationInfo> begin;

							/// <summary>
							/// Represents the Center area
							/// </summary>
							public Union<sap.ui.commons.layout.BorderLayoutArea, string, sap.ui.@base.ManagedObject.BindAggregationInfo> center;

							/// <summary>
							/// Represents the End area
							/// </summary>
							public Union<sap.ui.commons.layout.BorderLayoutArea, string, sap.ui.@base.ManagedObject.BindAggregationInfo> end;

							/// <summary>
							/// Represents the Bottom area
							/// </summary>
							public Union<sap.ui.commons.layout.BorderLayoutArea, string, sap.ui.@base.ManagedObject.BindAggregationInfo> bottom;

						}

						#endregion

						#region Constructor

						/// <summary>
						/// Constructor for a new layout/BorderLayout.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">id for the new control, generated automatically if no id is given</param>
						/// <param name="mSettings">initial settings for the new control</param>
						public extern BorderLayout(string sId, sap.ui.commons.layout.BorderLayout.Settings mSettings);

						/// <summary>
						/// Constructor for a new layout/BorderLayout.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">id for the new control, generated automatically if no id is given</param>
						public extern BorderLayout(string sId);

						/// <summary>
						/// Constructor for a new layout/BorderLayout.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						public extern BorderLayout();

						/// <summary>
						/// Constructor for a new layout/BorderLayout.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="mSettings">initial settings for the new control</param>
						public extern BorderLayout(sap.ui.commons.layout.BorderLayout.Settings mSettings);

						#endregion

						#region Methods

						#region Methods for Property rtl

						/// <summary>
						/// Gets current value of property {@link #getRtl rtl}.
						/// 
						/// The RTL setting swaps the areas Begin and End.
						/// 
						/// Default value is <code>false</code>.
						/// </summary>
						/// <returns>Value of property <code>rtl</code></returns>
						[Obsolete("Deprecated since 1.5.2. replaced by the global configuration for the page")]
						public extern virtual bool getRtl();

						/// <summary>
						/// Sets a new value for property {@link #getRtl rtl}.
						/// 
						/// The RTL setting swaps the areas Begin and End.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>false</code>.
						/// </summary>
						/// <param name="bRtl">New value for property <code>rtl</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						[Obsolete("Deprecated since 1.5.2. replaced by the global configuration for the page")]
						public extern virtual sap.ui.commons.layout.BorderLayout setRtl(bool bRtl);

						#endregion

						#region Methods for Property width

						/// <summary>
						/// Gets current value of property {@link #getWidth width}.
						/// 
						/// Defines the overall width of the layout
						/// 
						/// Default value is <code>100%</code>.
						/// </summary>
						/// <returns>Value of property <code>width</code></returns>
						public extern virtual sap.ui.core.CSSSize getWidth();

						/// <summary>
						/// Sets a new value for property {@link #getWidth width}.
						/// 
						/// Defines the overall width of the layout
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>100%</code>.
						/// </summary>
						/// <param name="sWidth">New value for property <code>width</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.commons.layout.BorderLayout setWidth(sap.ui.core.CSSSize sWidth);

						#endregion

						#region Methods for Property height

						/// <summary>
						/// Gets current value of property {@link #getHeight height}.
						/// 
						/// Defines the overall height of the layout
						/// 
						/// Default value is <code>100%</code>.
						/// </summary>
						/// <returns>Value of property <code>height</code></returns>
						public extern virtual sap.ui.core.CSSSize getHeight();

						/// <summary>
						/// Sets a new value for property {@link #getHeight height}.
						/// 
						/// Defines the overall height of the layout
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>100%</code>.
						/// </summary>
						/// <param name="sHeight">New value for property <code>height</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.commons.layout.BorderLayout setHeight(sap.ui.core.CSSSize sHeight);

						#endregion

						#region Methods for Aggregation top

						/// <summary>
						/// Gets content of aggregation {@link #getTop top}.
						/// 
						/// Represents the Top area
						/// </summary>
						/// <returns></returns>
						public extern virtual sap.ui.commons.layout.BorderLayoutArea getTop();

						/// <summary>
						/// Destroys the top in the aggregation {@link #getTop top}.
						/// </summary>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.commons.layout.BorderLayout destroyTop();

						/// <summary>
						/// Sets the aggregated {@link #getTop top}.
						/// </summary>
						/// <param name="oTop">The top to set</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.commons.layout.BorderLayout setTop(sap.ui.commons.layout.BorderLayoutArea oTop);

						#endregion

						#region Methods for Aggregation begin

						/// <summary>
						/// Gets content of aggregation {@link #getBegin begin}.
						/// 
						/// Represents the Begin area
						/// </summary>
						/// <returns></returns>
						public extern virtual sap.ui.commons.layout.BorderLayoutArea getBegin();

						/// <summary>
						/// Destroys the begin in the aggregation {@link #getBegin begin}.
						/// </summary>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.commons.layout.BorderLayout destroyBegin();

						/// <summary>
						/// Sets the aggregated {@link #getBegin begin}.
						/// </summary>
						/// <param name="oBegin">The begin to set</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.commons.layout.BorderLayout setBegin(sap.ui.commons.layout.BorderLayoutArea oBegin);

						#endregion

						#region Methods for Aggregation center

						/// <summary>
						/// Gets content of aggregation {@link #getCenter center}.
						/// 
						/// Represents the Center area
						/// </summary>
						/// <returns></returns>
						public extern virtual sap.ui.commons.layout.BorderLayoutArea getCenter();

						/// <summary>
						/// Destroys the center in the aggregation {@link #getCenter center}.
						/// </summary>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.commons.layout.BorderLayout destroyCenter();

						/// <summary>
						/// Sets the aggregated {@link #getCenter center}.
						/// </summary>
						/// <param name="oCenter">The center to set</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.commons.layout.BorderLayout setCenter(sap.ui.commons.layout.BorderLayoutArea oCenter);

						#endregion

						#region Methods for Aggregation end

						/// <summary>
						/// Gets content of aggregation {@link #getEnd end}.
						/// 
						/// Represents the End area
						/// </summary>
						/// <returns></returns>
						public extern virtual sap.ui.commons.layout.BorderLayoutArea getEnd();

						/// <summary>
						/// Destroys the end in the aggregation {@link #getEnd end}.
						/// </summary>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.commons.layout.BorderLayout destroyEnd();

						/// <summary>
						/// Sets the aggregated {@link #getEnd end}.
						/// </summary>
						/// <param name="oEnd">The end to set</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.commons.layout.BorderLayout setEnd(sap.ui.commons.layout.BorderLayoutArea oEnd);

						#endregion

						#region Methods for Aggregation bottom

						/// <summary>
						/// Gets content of aggregation {@link #getBottom bottom}.
						/// 
						/// Represents the Bottom area
						/// </summary>
						/// <returns></returns>
						public extern virtual sap.ui.commons.layout.BorderLayoutArea getBottom();

						/// <summary>
						/// Destroys the bottom in the aggregation {@link #getBottom bottom}.
						/// </summary>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.commons.layout.BorderLayout destroyBottom();

						/// <summary>
						/// Sets the aggregated {@link #getBottom bottom}.
						/// </summary>
						/// <param name="oBottom">The bottom to set</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.commons.layout.BorderLayout setBottom(sap.ui.commons.layout.BorderLayoutArea oBottom);

						#endregion

						#region Other methods

						/// <summary>
						/// Adds controls to the specified area.
						/// </summary>
						/// <param name="sAreaId">Specifies the area where controls will be added</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.commons.layout.BorderLayout addContent(sap.ui.commons.layout.BorderLayoutAreaTypes sAreaId);

						/// <summary>
						/// Creates the specified area and adds the given controls to it. Returns the created area.
						/// </summary>
						/// <param name="sAreaId">Specifies which area will be created. If the area is already available, the method call is ignored.</param>
						/// <param name="oContent">Any number of controls can be submitted to be added to the newly created area; where each control is submitted as one argument.</param>
						/// <returns>The created aria</returns>
						public extern virtual sap.ui.commons.layout.BorderLayoutArea createArea(sap.ui.commons.layout.BorderLayoutAreaTypes sAreaId, sap.ui.core.Control oContent);

						/// <summary>
						/// Destroys the content of the specified area.
						/// </summary>
						/// <param name="sAreaId">Specifies the area whose content will be destroyed</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.commons.layout.BorderLayout destroyContent(sap.ui.commons.layout.BorderLayoutAreaTypes sAreaId);

						/// <summary>
						/// Creates a new subclass of class sap.ui.commons.layout.BorderLayout with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.commons.layout.BorderLayout with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.commons.layout.BorderLayout with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns the area of the given type. If the area does not exist, it will be created when create is set to true.
						/// </summary>
						/// <param name="sAreaId">The aria ID</param>
						/// <param name="bCreate">Whether the aria must be created</param>
						/// <returns>The aria</returns>
						public extern virtual sap.ui.commons.layout.BorderLayoutArea getArea(sap.ui.commons.layout.BorderLayoutAreaTypes sAreaId, bool bCreate);

						/// <summary>
						/// Returns the object of the specified area. If the area does not exist, the area will be created and returned.
						/// </summary>
						/// <param name="sAreaId">Specifies the area whose object will be returned.</param>
						/// <returns>The aria</returns>
						public extern virtual sap.ui.commons.layout.BorderLayoutArea getAreaById(sap.ui.commons.layout.BorderLayoutAreaTypes sAreaId);

						/// <summary>
						/// Returns a JSON-like object that contains all property values of the requested area.
						/// </summary>
						/// <param name="sAreaId">Specifies the area whose data will be returned</param>
						/// <returns>The aria data</returns>
						public extern virtual object getAreaData(sap.ui.commons.layout.BorderLayoutAreaTypes sAreaId);

						/// <summary>
						/// Returns all controls inside the specified area inside an array.
						/// </summary>
						/// <param name="sAreaId">Specifies the area whose content controls shall be returned.</param>
						/// <returns>The array with the content</returns>
						public extern virtual sap.ui.core.Control[] getContent(sap.ui.commons.layout.BorderLayoutAreaTypes sAreaId);

						/// <summary>
						/// Returns a metadata object for class sap.ui.commons.layout.BorderLayout.
						/// </summary>
						/// <returns>Metadata object describing this class</returns>
						public extern static sap.ui.@base.Metadata getMetadata();

						/// <summary>
						/// Determines the index of a given content control.
						/// </summary>
						/// <param name="sAreaId">Specifies the area that will be searched</param>
						/// <param name="oContent">Specifies the control whose index will be searched</param>
						/// <returns>The index of the content</returns>
						public extern virtual int indexOfContent(sap.ui.commons.layout.BorderLayoutAreaTypes sAreaId, sap.ui.core.Control oContent);

						/// <summary>
						/// Inserts controls to an area at a given index.
						/// </summary>
						/// <param name="sAreaId">Specifies the area where the controls shall be inserted.</param>
						/// <param name="iIndex">Specifies the index where the controls shall be added. For a negative value of iIndex, the content is inserted at position '0'; for a value greater than the current size of the aggregation, the content is inserted at the last position.</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.commons.layout.BorderLayout insertContent(sap.ui.commons.layout.BorderLayoutAreaTypes sAreaId, int iIndex);

						/// <summary>
						/// Removes all content from an area.
						/// </summary>
						/// <param name="sAreaId">Specifies the area whose content shall be removed</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.commons.layout.BorderLayout removeAllContent(sap.ui.commons.layout.BorderLayoutAreaTypes sAreaId);

						/// <summary>
						/// Removes the content with the given index from an area.
						/// </summary>
						/// <param name="oAreaId">Specifies the area whose content shall be removed</param>
						/// <param name="vElement">The content to be removed Specifies the control that shall be removed</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.commons.layout.BorderLayout removeContent(sap.ui.commons.layout.BorderLayoutAreaTypes oAreaId, object vElement);

						/// <summary>
						/// Sets the properties of the specified area with the given values.
						/// </summary>
						/// <param name="sAreaId">Specifies the area whose properties will be set</param>
						/// <param name="oData">JSON-like object that contains the values to be set</param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.commons.layout.BorderLayout setAreaData(sap.ui.commons.layout.BorderLayoutAreaTypes sAreaId, object oData);

						#endregion

						#endregion

					}
				}
			}
		}
	}
}
