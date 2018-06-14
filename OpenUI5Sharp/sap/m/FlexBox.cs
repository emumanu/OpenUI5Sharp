using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace OpenUI5Sharp
{
	public static partial class sap
	{
		public static partial class m
		{
			/// <summary>
			/// The <code>sap.m.FlexBox</code> control builds the container for a flexible box layout.<br> <br> <b>Note:</b> Be sure to check the <code>renderType</code> setting to avoid issues due to browser inconsistencies.
			/// </summary>
			[External]
			[Namespace(false)]
			public partial class FlexBox : sap.ui.core.Control
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
					/// The height of the <code>sap.m.FlexBox</code>. Note that when a percentage is given, for the height to work as expected, the height of the surrounding container must be defined.
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> height;

					/// <summary>
					/// The width of the <code>sap.m.FlexBox</code>. Note that when a percentage is given, for the width to work as expected, the width of the surrounding container must be defined.
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> width;

					/// <summary>
					/// Determines whether the <code>sap.m.FlexBox</code> is in block or inline mode.
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> displayInline;

					/// <summary>
					/// Determines the direction of the layout of child elements.
					/// </summary>
					public Union<sap.m.FlexDirection, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> direction;

					/// <summary>
					/// Determines whether the <code>sap.m.FlexBox</code> will be sized to completely fill its container. If the <code>sap.m.FlexBox</code> is inserted into a Page, the property 'enableScrolling' of the Page needs to be set to 'false' for the FlexBox to fit the entire viewport.
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> fitContainer;

					/// <summary>
					/// Determines whether the layout is rendered as a series of divs or as an unordered list (ul).<br> <br> We recommend to use <code>Bare</code> in most cases to avoid layout issues due to browser inconsistencies.
					/// </summary>
					public Union<sap.m.FlexRendertype, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> renderType;

					/// <summary>
					/// Determines the layout behavior along the main axis.
					/// </summary>
					public Union<sap.m.FlexJustifyContent, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> justifyContent;

					/// <summary>
					/// Determines the layout behavior of items along the cross-axis. "Baseline" is not supported in Internet Explorer 10.
					/// </summary>
					public Union<sap.m.FlexAlignItems, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> alignItems;

					/// <summary>
					/// Determines the wrapping behavior of the flex container. This property has no effect in older browsers, e.g. Android Native 4.3 and below.
					/// </summary>
					public Union<sap.m.FlexWrap, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> wrap;

					/// <summary>
					/// Determines the layout behavior of container lines when there's extra space along the cross-axis. This property has no effect in Internet Explorer 10.
					/// </summary>
					public Union<sap.m.FlexAlignContent, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> alignContent;

					/// <summary>
					/// Defines the background style of the <code>sap.m.FlexBox</code>.
					/// </summary>
					public Union<sap.m.BackgroundDesign, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> backgroundDesign;

					/// <summary>
					/// Flex items within the flexible box layout
					/// </summary>
					public Union<sap.ui.core.Control[], string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> items;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new <code>sap.m.FlexBox</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">id for the new control, generated automatically if no id is given</param>
				/// <param name="mSettings">initial settings for the new control</param>
				public extern FlexBox(string sId, sap.m.FlexBox.Settings mSettings);

				/// <summary>
				/// Constructor for a new <code>sap.m.FlexBox</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">id for the new control, generated automatically if no id is given</param>
				public extern FlexBox(string sId);

				/// <summary>
				/// Constructor for a new <code>sap.m.FlexBox</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern FlexBox();

				/// <summary>
				/// Constructor for a new <code>sap.m.FlexBox</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">initial settings for the new control</param>
				public extern FlexBox(sap.m.FlexBox.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property height

				/// <summary>
				/// Gets current value of property {@link #getHeight height}.
				/// 
				/// The height of the <code>sap.m.FlexBox</code>. Note that when a percentage is given, for the height to work as expected, the height of the surrounding container must be defined.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <returns>Value of property <code>height</code></returns>
				public extern virtual sap.ui.core.CSSSize getHeight();

				/// <summary>
				/// Sets the FlexBox height.
				/// </summary>
				/// <param name="sValue">Height in string format.</param>
				/// <returns>this FlexBox reference for chaining.</returns>
				public extern virtual sap.m.FlexBox setHeight(string sValue);

				#endregion

				#region Methods for Property width

				/// <summary>
				/// Gets current value of property {@link #getWidth width}.
				/// 
				/// The width of the <code>sap.m.FlexBox</code>. Note that when a percentage is given, for the width to work as expected, the width of the surrounding container must be defined.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <returns>Value of property <code>width</code></returns>
				public extern virtual sap.ui.core.CSSSize getWidth();

				/// <summary>
				/// Sets the FlexBox width.
				/// </summary>
				/// <param name="sValue">Width in string format.</param>
				/// <returns>this FlexBox reference for chaining.</returns>
				public extern virtual sap.m.FlexBox setWidth(string sValue);

				#endregion

				#region Methods for Property displayInline

				/// <summary>
				/// Gets current value of property {@link #getDisplayInline displayInline}.
				/// 
				/// Determines whether the <code>sap.m.FlexBox</code> is in block or inline mode.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>displayInline</code></returns>
				public extern virtual bool getDisplayInline();

				/// <summary>
				/// Sets display inline for nested or contained FlexBox.
				/// </summary>
				/// <param name="bInline">Indication for display inline.</param>
				/// <returns><code>this</code> FlexBox reference for chaining.</returns>
				public extern virtual sap.m.FlexBox setDisplayInline(bool bInline);

				#endregion

				#region Methods for Property direction

				/// <summary>
				/// Gets current value of property {@link #getDirection direction}.
				/// 
				/// Determines the direction of the layout of child elements.
				/// 
				/// Default value is <code>Row</code>.
				/// </summary>
				/// <returns>Value of property <code>direction</code></returns>
				public extern virtual sap.m.FlexDirection getDirection();

				/// <summary>
				/// Sets direction for the FlexBox. It could be row, row-reverse, column or column-reverse.
				/// </summary>
				/// <param name="sValue">FlexBox direction in string format.</param>
				/// <returns><code>this</code> FlexBox reference for chaining.</returns>
				public extern virtual sap.m.FlexBox setDirection(string sValue);

				#endregion

				#region Methods for Property fitContainer

				/// <summary>
				/// Gets current value of property {@link #getFitContainer fitContainer}.
				/// 
				/// Determines whether the <code>sap.m.FlexBox</code> will be sized to completely fill its container. If the <code>sap.m.FlexBox</code> is inserted into a Page, the property 'enableScrolling' of the Page needs to be set to 'false' for the FlexBox to fit the entire viewport.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>fitContainer</code></returns>
				public extern virtual bool getFitContainer();

				/// <summary>
				/// Sets <code>fitContainer</code> so you can have nested FlexBox containers in columns or rows.
				/// </summary>
				/// <param name="sValue">Fit container in string format.</param>
				/// <returns><code>this</code> FlexBox reference for chaining.</returns>
				public extern virtual sap.m.FlexBox setFitContainer(string sValue);

				#endregion

				#region Methods for Property renderType

				/// <summary>
				/// Gets current value of property {@link #getRenderType renderType}.
				/// 
				/// Determines whether the layout is rendered as a series of divs or as an unordered list (ul).<br> <br> We recommend to use <code>Bare</code> in most cases to avoid layout issues due to browser inconsistencies.
				/// 
				/// Default value is <code>Div</code>.
				/// </summary>
				/// <returns>Value of property <code>renderType</code></returns>
				public extern virtual sap.m.FlexRendertype getRenderType();

				/// <summary>
				/// Sets the render type of the FlexBox.
				/// </summary>
				/// <param name="sValue">Render type in string format.</param>
				/// <returns><code>this</code> FlexBox reference for chaining.</returns>
				public extern virtual sap.m.FlexBox setRenderType(string sValue);

				#endregion

				#region Methods for Property justifyContent

				/// <summary>
				/// Gets current value of property {@link #getJustifyContent justifyContent}.
				/// 
				/// Determines the layout behavior along the main axis.
				/// 
				/// Default value is <code>Start</code>.
				/// </summary>
				/// <returns>Value of property <code>justifyContent</code></returns>
				public extern virtual sap.m.FlexJustifyContent getJustifyContent();

				/// <summary>
				/// Sets the <code>justifyContent</code> - it can be flex-start, flex-end, center, space-between, space-around, space-evenly.
				/// </summary>
				/// <param name="sValue">Justify content;</param>
				/// <returns>this FlexBox reference for chaining.</returns>
				public extern virtual sap.m.FlexBox setJustifyContent(string sValue);

				#endregion

				#region Methods for Property alignItems

				/// <summary>
				/// Gets current value of property {@link #getAlignItems alignItems}.
				/// 
				/// Determines the layout behavior of items along the cross-axis. "Baseline" is not supported in Internet Explorer 10.
				/// 
				/// Default value is <code>Stretch</code>.
				/// </summary>
				/// <returns>Value of property <code>alignItems</code></returns>
				public extern virtual sap.m.FlexAlignItems getAlignItems();

				/// <summary>
				/// Sets the alignment of items in the FlexBox.
				/// </summary>
				/// <param name="sValue">Align items.</param>
				/// <returns>this FlexBox reference for chaining.</returns>
				public extern virtual sap.m.FlexBox setAlignItems(string sValue);

				#endregion

				#region Methods for Property wrap

				/// <summary>
				/// Gets current value of property {@link #getWrap wrap}.
				/// 
				/// Determines the wrapping behavior of the flex container. This property has no effect in older browsers, e.g. Android Native 4.3 and below.
				/// 
				/// Default value is <code>NoWrap</code>.
				/// </summary>
				/// <returns>Value of property <code>wrap</code></returns>
				public extern virtual sap.m.FlexWrap getWrap();

				/// <summary>
				/// Sets the wrapping.
				/// </summary>
				/// <param name="sValue">Wrapping in the flexbox.</param>
				/// <returns><code>this</code> FlexBox reference for chaining.</returns>
				public extern virtual sap.m.FlexBox setWrap(string sValue);

				#endregion

				#region Methods for Property alignContent

				/// <summary>
				/// Gets current value of property {@link #getAlignContent alignContent}.
				/// 
				/// Determines the layout behavior of container lines when there's extra space along the cross-axis. This property has no effect in Internet Explorer 10.
				/// 
				/// Default value is <code>Stretch</code>.
				/// </summary>
				/// <returns>Value of property <code>alignContent</code></returns>
				public extern virtual sap.m.FlexAlignContent getAlignContent();

				/// <summary>
				/// Sets the alignment of content in the FlexBox.
				/// </summary>
				/// <param name="sValue">Align content.</param>
				/// <returns>this FlexBox reference for chaining.</returns>
				public extern virtual sap.m.FlexBox setAlignContent(string sValue);

				#endregion

				#region Methods for Property backgroundDesign

				/// <summary>
				/// Gets current value of property {@link #getBackgroundDesign backgroundDesign}.
				/// 
				/// Defines the background style of the <code>sap.m.FlexBox</code>.
				/// 
				/// Default value is <code>Transparent</code>.
				/// </summary>
				/// <returns>Value of property <code>backgroundDesign</code></returns>
				public extern virtual sap.m.BackgroundDesign getBackgroundDesign();

				/// <summary>
				/// Sets the background design.
				/// </summary>
				/// <param name="sValue">Background design in string format.</param>
				/// <returns>this FlexBox for reference chaining.</returns>
				public extern virtual sap.m.FlexBox setBackgroundDesign(string sValue);

				#endregion

				#region Methods for Aggregation items

				/// <summary>
				/// Gets content of aggregation {@link #getItems items}.
				/// 
				/// Flex items within the flexible box layout
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.Control[] getItems();

				/// <summary>
				/// Destroys all the items in the aggregation {@link #getItems items}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FlexBox destroyItems();

				/// <summary>
				/// Inserts single item.
				/// </summary>
				/// <param name="oItem">Inserted item.</param>
				/// <param name="iIndex">Index of the inserted item.</param>
				/// <returns><code>this</code> FlexBox reference for chaining.</returns>
				public extern virtual sap.m.FlexBox insertItem(object oItem, int iIndex);

				/// <summary>
				/// Adds item in the FlexBox.
				/// </summary>
				/// <param name="oItem">Added item.</param>
				/// <returns><code>this</code> FlexBox reference for chaining.</returns>
				public extern virtual sap.m.FlexBox addItem(object oItem);

				/// <summary>
				/// Removes single item.
				/// </summary>
				/// <param name="vItem">Item to be removed.</param>
				/// <returns>The removed item.</returns>
				public extern virtual object removeItem(object vItem);

				/// <summary>
				/// Checks for the provided <code>sap.ui.core.Control</code> in the aggregation {@link #getItems items}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oItem">The item whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfItem(sap.ui.core.Control oItem);

				/// <summary>
				/// Removes all items.
				/// </summary>
				/// <returns>The removed items from flexbox.</returns>
				public extern virtual object removeAllItems();

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.FlexBox with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.FlexBox with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.FlexBox with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Gets the accessibility information.
				/// </summary>
				/// <returns>The accessibility information.</returns>
				public extern override object getAccessibilityInfo();

				/// <summary>
				/// Returns a metadata object for class sap.m.FlexBox.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				/// <summary>
				/// Initializes the control.
				/// </summary>
				public extern override void init();

				#endregion

				#endregion

			}
		}
	}
}
