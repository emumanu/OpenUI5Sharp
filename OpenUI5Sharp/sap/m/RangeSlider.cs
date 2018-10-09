using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public static partial class sap
	{
		public static partial class m
		{
			/// <summary>
			/// Represents a numerical interval and two handles to select a sub-range within it. <h3>Overview</h3> The purpose of the control is to enable visual selection of sub-ranges within a given interval. <h4>Notes:<h4> <ul> <li>The RangeSlider extends the functionality of the {@link sap.m.Slider Slider}</li> <li>The right and left handle can be moved individually and their positions could therefore switch.</li> <li>The entire range can be moved along the interval.</li> <li>The right and left handle can select the same value</li> </ul>
			/// 
			/// <h3>Usage</h3> The most common usecase is to select and move sub-ranges on a continuous numerical scale.
			/// 
			/// <h3>Responsive Behavior</h3> You can move the currently selected range by clicking on it and dragging it along the interval.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.RangeSlider")]
			public partial class RangeSlider : sap.m.Slider
			{
				#region Settings

				/// <summary>
				/// Settings class to create the object
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class Settings : sap.m.Slider.Settings
				{
					/// <summary>
					/// Current second value of the slider. (Position of the second handle.)
					/// 
					/// <b>Note:</b> If the value is not in the valid range (between <code>min</code> and <code>max</code>) it will be changed to be in the valid range. If it is smaller than <code>value</code> it will be set to the same value.
					/// </summary>
					public Union<float, string, sap.ui.@base.ManagedObject.BindPropertyInfo> value2;

					/// <summary>
					/// Determines the currently selected range on the slider.
					/// 
					/// If the value is lower/higher than the allowed minimum/maximum, a warning message will be output to the console.
					/// </summary>
					public Union<float[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> range;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new <code>RangeSlider</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern RangeSlider(string sId, sap.m.RangeSlider.Settings mSettings);

				/// <summary>
				/// Constructor for a new <code>RangeSlider</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern RangeSlider(string sId);

				/// <summary>
				/// Constructor for a new <code>RangeSlider</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern RangeSlider();

				/// <summary>
				/// Constructor for a new <code>RangeSlider</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern RangeSlider(sap.m.RangeSlider.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property value2

				/// <summary>
				/// Gets current value of property {@link #getValue2 value2}.
				/// 
				/// Current second value of the slider. (Position of the second handle.)
				/// 
				/// <b>Note:</b> If the value is not in the valid range (between <code>min</code> and <code>max</code>) it will be changed to be in the valid range. If it is smaller than <code>value</code> it will be set to the same value.
				/// 
				/// Default value is <code>100</code>.
				/// </summary>
				/// <returns>Value of property <code>value2</code></returns>
				public extern virtual float getValue2();

				/// <summary>
				/// Sets a new value for property {@link #getValue2 value2}.
				/// 
				/// Current second value of the slider. (Position of the second handle.)
				/// 
				/// <b>Note:</b> If the value is not in the valid range (between <code>min</code> and <code>max</code>) it will be changed to be in the valid range. If it is smaller than <code>value</code> it will be set to the same value.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>100</code>.
				/// </summary>
				/// <param name="fValue2">New value for property <code>value2</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.RangeSlider setValue2(float fValue2);

				#endregion

				#region Methods for Property range

				/// <summary>
				/// Gets current value of property {@link #getRange range}.
				/// 
				/// Determines the currently selected range on the slider.
				/// 
				/// If the value is lower/higher than the allowed minimum/maximum, a warning message will be output to the console.
				/// 
				/// Default value is <code>0,100</code>.
				/// </summary>
				/// <returns>Value of property <code>range</code></returns>
				public extern virtual float[] getRange();

				/// <summary>
				/// Sets a new value for property {@link #getRange range}.
				/// 
				/// Determines the currently selected range on the slider.
				/// 
				/// If the value is lower/higher than the allowed minimum/maximum, a warning message will be output to the console.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>0,100</code>.
				/// </summary>
				/// <param name="sRange">New value for property <code>range</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.RangeSlider setRange(float[] sRange);

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.RangeSlider with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.Slider.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.RangeSlider with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.Slider.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.RangeSlider with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.Slider.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.RangeSlider.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				/// <summary>
				/// Updates values of the advanced tooltips.
				/// </summary>
				/// <param name="sNewValue">The new value</param>
				public extern override void updateAdvancedTooltipDom(string sNewValue);

				#endregion

				#endregion

			}
		}
	}
}
