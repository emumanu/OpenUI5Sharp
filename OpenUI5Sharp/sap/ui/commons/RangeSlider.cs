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
				/// The interactive control is displayed either as a horizontal or a vertical line with two pointers and units of measurement. Users can move the pointers along the line to change a range with graphical support.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.RangeSlider")]
				[Obsolete("Deprecated since 1.38. replaced by {@link sap.m.RangeSlider}")]
				public partial class RangeSlider : sap.ui.commons.Slider
				{
					#region Settings

					/// <summary>
					/// Settings class to create the object
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class Settings : sap.ui.commons.Slider.Settings
					{
						/// <summary>
						/// Current second value of the slider. (Position of the second grip.)
						/// 
						/// <b>Note:</b> If the value is not in the valid range (between <code>min</code> and <code>max</code>) it will be changed to be in the valid range. If it is smaller than <code>value</code> it will be set to the same value.
						/// </summary>
						public Union<float, string, sap.ui.@base.ManagedObject.BindPropertyInfo> value2;

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
					public extern RangeSlider(string sId, sap.ui.commons.RangeSlider.Settings mSettings);

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
					public extern RangeSlider(sap.ui.commons.RangeSlider.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property value2

					/// <summary>
					/// Gets current value of property {@link #getValue2 value2}.
					/// 
					/// Current second value of the slider. (Position of the second grip.)
					/// 
					/// <b>Note:</b> If the value is not in the valid range (between <code>min</code> and <code>max</code>) it will be changed to be in the valid range. If it is smaller than <code>value</code> it will be set to the same value.
					/// 
					/// Default value is <code>80</code>.
					/// </summary>
					/// <returns>Value of property <code>value2</code></returns>
					public extern virtual float getValue2();

					/// <summary>
					/// Sets a new value for property {@link #getValue2 value2}.
					/// 
					/// Current second value of the slider. (Position of the second grip.)
					/// 
					/// <b>Note:</b> If the value is not in the valid range (between <code>min</code> and <code>max</code>) it will be changed to be in the valid range. If it is smaller than <code>value</code> it will be set to the same value.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>80</code>.
					/// </summary>
					/// <param name="fValue2">New value for property <code>value2</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RangeSlider setValue2(float fValue2);

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.RangeSlider with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.commons.Slider.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.RangeSlider with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.commons.Slider.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.RangeSlider with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.commons.Slider.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.commons.RangeSlider.
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
