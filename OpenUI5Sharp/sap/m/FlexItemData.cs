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
			/// Holds layout data for a FlexBox / HBox / VBox.
			/// </summary>
			[External]
			[Namespace(false)]
			public partial class FlexItemData : sap.ui.core.LayoutData
			{
				#region Settings

				/// <summary>
				/// Settings class to create the object
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class Settings : sap.ui.core.LayoutData.Settings
				{
					/// <summary>
					/// Determines cross-axis alignment of individual element (not currently supported in Internet Explorer).
					/// </summary>
					public Union<sap.m.FlexAlignSelf, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> alignSelf;

					/// <summary>
					/// Determines the display order of flex items independent of their source code order.
					/// </summary>
					public Union<int, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> order;

					/// <summary>
					/// Determines the flexibility of the flex item when allocatable space is remaining.
					/// </summary>
					public Union<float, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> growFactor;

					/// <summary>
					/// The shrink factor determines how much the flex item will shrink relative to the rest of the flex items in the flex container when negative free space is distributed.
					/// </summary>
					public Union<float, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> shrinkFactor;

					/// <summary>
					/// The base size is the initial main size of the item for the flex algorithm. If set to "auto", this will be the computed size of the item.
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> baseSize;

					/// <summary>
					/// The minimum height of the flex item.
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> minHeight;

					/// <summary>
					/// The maximum height of the flex item.
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> maxHeight;

					/// <summary>
					/// The minimum height of the flex item.
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> minWidth;

					/// <summary>
					/// The maximum height of the flex item.
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> maxWidth;

					/// <summary>
					/// The style class will be applied to the flex item and can be used for CSS selectors.
					/// </summary>
					public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> styleClass;

					/// <summary>
					/// Defines the background style of the flex item.
					/// </summary>
					public Union<sap.m.BackgroundDesign, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> backgroundDesign;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new <code>sap.m.FlexItemData</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new element, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new element.</param>
				public extern FlexItemData(string sId, sap.m.FlexItemData.Settings mSettings);

				/// <summary>
				/// Constructor for a new <code>sap.m.FlexItemData</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new element, generated automatically if no ID is given</param>
				public extern FlexItemData(string sId);

				/// <summary>
				/// Constructor for a new <code>sap.m.FlexItemData</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern FlexItemData();

				/// <summary>
				/// Constructor for a new <code>sap.m.FlexItemData</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new element.</param>
				public extern FlexItemData(sap.m.FlexItemData.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property alignSelf

				/// <summary>
				/// Gets current value of property {@link #getAlignSelf alignSelf}.
				/// 
				/// Determines cross-axis alignment of individual element (not currently supported in Internet Explorer).
				/// 
				/// Default value is <code>Auto</code>.
				/// </summary>
				/// <returns>Value of property <code>alignSelf</code></returns>
				public extern virtual sap.m.FlexAlignSelf getAlignSelf();

				/// <summary>
				/// Sets the <code>alignSelf</code> property.
				/// </summary>
				/// <param name="sValue">Align option.</param>
				/// <returns><code>this</code> FlexItemData reference for chaining.</returns>
				public extern virtual sap.m.FlexItemData setAlignSelf(string sValue);

				#endregion

				#region Methods for Property order

				/// <summary>
				/// Gets current value of property {@link #getOrder order}.
				/// 
				/// Determines the display order of flex items independent of their source code order.
				/// 
				/// Default value is <code>0</code>.
				/// </summary>
				/// <returns>Value of property <code>order</code></returns>
				public extern virtual int getOrder();

				/// <summary>
				/// Sets the order.
				/// </summary>
				/// <param name="sValue">Order in string format.</param>
				/// <returns><code>this</code> FlexItemData reference for chaining.</returns>
				public extern virtual sap.m.FlexItemData setOrder(string sValue);

				#endregion

				#region Methods for Property growFactor

				/// <summary>
				/// Gets current value of property {@link #getGrowFactor growFactor}.
				/// 
				/// Determines the flexibility of the flex item when allocatable space is remaining.
				/// 
				/// Default value is <code>0</code>.
				/// </summary>
				/// <returns>Value of property <code>growFactor</code></returns>
				public extern virtual float getGrowFactor();

				/// <summary>
				/// Sets the <code>growFactor</code> property.
				/// </summary>
				/// <param name="sValue">Grow factor in string format.</param>
				/// <returns>this FlexItemData reference for chaining.</returns>
				public extern virtual sap.m.FlexItemData setGrowFactor(string sValue);

				#endregion

				#region Methods for Property shrinkFactor

				/// <summary>
				/// Gets current value of property {@link #getShrinkFactor shrinkFactor}.
				/// 
				/// The shrink factor determines how much the flex item will shrink relative to the rest of the flex items in the flex container when negative free space is distributed.
				/// 
				/// Default value is <code>1</code>.
				/// </summary>
				/// <returns>Value of property <code>shrinkFactor</code></returns>
				public extern virtual float getShrinkFactor();

				/// <summary>
				/// Sets the <code>shrinkFactor</code> property.
				/// </summary>
				/// <param name="sValue">Shrink factor in string format.</param>
				/// <returns><code>this</code> FlexItemData reference for chaining.</returns>
				public extern virtual sap.m.FlexItemData setShrinkFactor(string sValue);

				#endregion

				#region Methods for Property baseSize

				/// <summary>
				/// Gets current value of property {@link #getBaseSize baseSize}.
				/// 
				/// The base size is the initial main size of the item for the flex algorithm. If set to "auto", this will be the computed size of the item.
				/// 
				/// Default value is <code>auto</code>.
				/// </summary>
				/// <returns>Value of property <code>baseSize</code></returns>
				public extern virtual sap.ui.core.CSSSize getBaseSize();

				/// <summary>
				/// Sets the base size for flex items.
				/// </summary>
				/// <param name="sValue">Base size in string format.</param>
				/// <returns><code>this</code> FlexItemData reference for chaining.</returns>
				public extern virtual sap.m.FlexItemData setBaseSize(string sValue);

				#endregion

				#region Methods for Property minHeight

				/// <summary>
				/// Gets current value of property {@link #getMinHeight minHeight}.
				/// 
				/// The minimum height of the flex item.
				/// 
				/// Default value is <code>auto</code>.
				/// </summary>
				/// <returns>Value of property <code>minHeight</code></returns>
				public extern virtual sap.ui.core.CSSSize getMinHeight();

				/// <summary>
				/// Sets minimum height.
				/// </summary>
				/// <param name="sValue">Minimum height in string format.</param>
				/// <returns><code>this</code> FlexItemData reference for chaining.</returns>
				public extern virtual sap.m.FlexItemData setMinHeight(string sValue);

				#endregion

				#region Methods for Property maxHeight

				/// <summary>
				/// Gets current value of property {@link #getMaxHeight maxHeight}.
				/// 
				/// The maximum height of the flex item.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <returns>Value of property <code>maxHeight</code></returns>
				public extern virtual sap.ui.core.CSSSize getMaxHeight();

				/// <summary>
				/// Sets maximum height.
				/// </summary>
				/// <param name="sValue">Maximum height in string format.</param>
				/// <returns><code>this</code> FlexItemData reference for chaining.</returns>
				public extern virtual sap.m.FlexItemData setMaxHeight(string sValue);

				#endregion

				#region Methods for Property minWidth

				/// <summary>
				/// Gets current value of property {@link #getMinWidth minWidth}.
				/// 
				/// The minimum height of the flex item.
				/// 
				/// Default value is <code>auto</code>.
				/// </summary>
				/// <returns>Value of property <code>minWidth</code></returns>
				public extern virtual sap.ui.core.CSSSize getMinWidth();

				/// <summary>
				/// Sets minimum width.
				/// </summary>
				/// <param name="sValue">Minimum width in string format.</param>
				/// <returns><code>this</code> FlexItemData reference for chaining.</returns>
				public extern virtual sap.m.FlexItemData setMinWidth(string sValue);

				#endregion

				#region Methods for Property maxWidth

				/// <summary>
				/// Gets current value of property {@link #getMaxWidth maxWidth}.
				/// 
				/// The maximum height of the flex item.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <returns>Value of property <code>maxWidth</code></returns>
				public extern virtual sap.ui.core.CSSSize getMaxWidth();

				/// <summary>
				/// Sets maximum width.
				/// </summary>
				/// <param name="sValue">Maximum width in string format.</param>
				/// <returns><code>this</code> FlexItemData reference for chaining.</returns>
				public extern virtual sap.m.FlexItemData setMaxWidth(string sValue);

				#endregion

				#region Methods for Property styleClass

				/// <summary>
				/// Gets current value of property {@link #getStyleClass styleClass}.
				/// 
				/// The style class will be applied to the flex item and can be used for CSS selectors.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <returns>Value of property <code>styleClass</code></returns>
				public extern virtual string getStyleClass();

				/// <summary>
				/// Sets style class.
				/// </summary>
				/// <param name="sValue">Style class.</param>
				/// <returns><code>this</code> FlexItemData reference for chaining.</returns>
				public extern virtual sap.m.FlexItemData setStyleClass(string sValue);

				#endregion

				#region Methods for Property backgroundDesign

				/// <summary>
				/// Gets current value of property {@link #getBackgroundDesign backgroundDesign}.
				/// 
				/// Defines the background style of the flex item.
				/// 
				/// Default value is <code>Transparent</code>.
				/// </summary>
				/// <returns>Value of property <code>backgroundDesign</code></returns>
				public extern virtual sap.m.BackgroundDesign getBackgroundDesign();

				/// <summary>
				/// Sets background design for flex items.
				/// </summary>
				/// <param name="sValue">Background design in string format.</param>
				/// <returns><code>this</code> FlexItemData reference for chaining.</returns>
				public extern virtual sap.m.FlexItemData setBackgroundDesign(string sValue);

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.FlexItemData with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.LayoutData.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.FlexItemData with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.LayoutData.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.FlexItemData with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.LayoutData.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.FlexItemData.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				#endregion

				#endregion

			}
		}
	}
}
