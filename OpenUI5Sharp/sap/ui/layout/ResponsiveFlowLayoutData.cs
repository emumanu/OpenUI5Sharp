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
				/// This is a LayoutData element that can be added to a control if this control is used within a ResponsiveFlowLayout.
				/// </summary>
				[External]
				[Namespace(false)]
				public partial class ResponsiveFlowLayoutData : sap.ui.core.LayoutData
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
						/// Defines the minimal size in px of a ResponsiveFlowLayout element. The element will be shrunk down to this value.
						/// </summary>
						public Union<int, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> minWidth;

						/// <summary>
						/// Defines the weight of the element, that influences the resulting width. If there are several elements within a row of the ResponsiveFlowLayout, each element could have another weight. The bigger the weight of a single element, the wider it will be stretched, i.e. a bigger weight results in a larger width.
						/// </summary>
						public Union<int, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> weight;

						/// <summary>
						/// If this property is set, the control in which the LayoutData is added, will always cause a line break within the ResponsiveFlowLayout.
						/// </summary>
						public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> linebreak;

						/// <summary>
						/// Prevents any margin of the element if set to false.
						/// </summary>
						public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> margin;

						/// <summary>
						/// Shows if an element can be wrapped into a new row. If this value is set to false, the min-width will be set to 0 and the wrapping is up to the previous element.
						/// </summary>
						public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> linebreakable;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new ResponsiveFlowLayoutData.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern ResponsiveFlowLayoutData(string sId, sap.ui.layout.ResponsiveFlowLayoutData.Settings mSettings);

					/// <summary>
					/// Constructor for a new ResponsiveFlowLayoutData.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					public extern ResponsiveFlowLayoutData(string sId);

					/// <summary>
					/// Constructor for a new ResponsiveFlowLayoutData.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern ResponsiveFlowLayoutData();

					/// <summary>
					/// Constructor for a new ResponsiveFlowLayoutData.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern ResponsiveFlowLayoutData(sap.ui.layout.ResponsiveFlowLayoutData.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property minWidth

					/// <summary>
					/// Gets current value of property {@link #getMinWidth minWidth}.
					/// 
					/// Defines the minimal size in px of a ResponsiveFlowLayout element. The element will be shrunk down to this value.
					/// 
					/// Default value is <code>100</code>.
					/// </summary>
					/// <returns>Value of property <code>minWidth</code></returns>
					public extern virtual int getMinWidth();

					/// <summary>
					/// Sets a new value for property {@link #getMinWidth minWidth}.
					/// 
					/// Defines the minimal size in px of a ResponsiveFlowLayout element. The element will be shrunk down to this value.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>100</code>.
					/// </summary>
					/// <param name="iMinWidth">New value for property <code>minWidth</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.ResponsiveFlowLayoutData setMinWidth(int iMinWidth);

					#endregion

					#region Methods for Property weight

					/// <summary>
					/// Gets current value of property {@link #getWeight weight}.
					/// 
					/// Defines the weight of the element, that influences the resulting width. If there are several elements within a row of the ResponsiveFlowLayout, each element could have another weight. The bigger the weight of a single element, the wider it will be stretched, i.e. a bigger weight results in a larger width.
					/// 
					/// Default value is <code>1</code>.
					/// </summary>
					/// <returns>Value of property <code>weight</code></returns>
					public extern virtual int getWeight();

					/// <summary>
					/// Sets a new value for property {@link #getWeight weight}.
					/// 
					/// Defines the weight of the element, that influences the resulting width. If there are several elements within a row of the ResponsiveFlowLayout, each element could have another weight. The bigger the weight of a single element, the wider it will be stretched, i.e. a bigger weight results in a larger width.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>1</code>.
					/// </summary>
					/// <param name="iWeight">New value for property <code>weight</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.ResponsiveFlowLayoutData setWeight(int iWeight);

					#endregion

					#region Methods for Property linebreak

					/// <summary>
					/// Gets current value of property {@link #getLinebreak linebreak}.
					/// 
					/// If this property is set, the control in which the LayoutData is added, will always cause a line break within the ResponsiveFlowLayout.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>linebreak</code></returns>
					public extern virtual bool getLinebreak();

					/// <summary>
					/// Sets a new value for property {@link #getLinebreak linebreak}.
					/// 
					/// If this property is set, the control in which the LayoutData is added, will always cause a line break within the ResponsiveFlowLayout.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bLinebreak">New value for property <code>linebreak</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.ResponsiveFlowLayoutData setLinebreak(bool bLinebreak);

					#endregion

					#region Methods for Property margin

					/// <summary>
					/// Gets current value of property {@link #getMargin margin}.
					/// 
					/// Prevents any margin of the element if set to false.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>margin</code></returns>
					public extern virtual bool getMargin();

					/// <summary>
					/// Sets a new value for property {@link #getMargin margin}.
					/// 
					/// Prevents any margin of the element if set to false.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bMargin">New value for property <code>margin</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.ResponsiveFlowLayoutData setMargin(bool bMargin);

					#endregion

					#region Methods for Property linebreakable

					/// <summary>
					/// Gets current value of property {@link #getLinebreakable linebreakable}.
					/// 
					/// Shows if an element can be wrapped into a new row. If this value is set to false, the min-width will be set to 0 and the wrapping is up to the previous element.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>linebreakable</code></returns>
					public extern virtual bool getLinebreakable();

					/// <summary>
					/// Sets a new value for property {@link #getLinebreakable linebreakable}.
					/// 
					/// Shows if an element can be wrapped into a new row. If this value is set to false, the min-width will be set to 0 and the wrapping is up to the previous element.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bLinebreakable">New value for property <code>linebreakable</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.ResponsiveFlowLayoutData setLinebreakable(bool bLinebreakable);

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.layout.ResponsiveFlowLayoutData with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.LayoutData.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.layout.ResponsiveFlowLayoutData with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.LayoutData.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.layout.ResponsiveFlowLayoutData with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.LayoutData.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.layout.ResponsiveFlowLayoutData.
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
