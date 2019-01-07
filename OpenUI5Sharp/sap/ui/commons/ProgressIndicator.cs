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
				/// Shows the progress of a process in a graphical way. The indicator can be displayed with or without numerical values. The filling can be displayed in color only, or additionally with the percentage rate. The indicator status can be interactive.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.ProgressIndicator")]
				[Obsolete("Deprecated since 1.38. Instead, use the <code>sap.m.ProgressIndicator</code> control.")]
				public partial class ProgressIndicator : sap.ui.core.Control
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
						/// Determines whether the control is enabled or not. Disabled controls have different colors, and can not be focused.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> enabled;

						/// <summary>
						/// Determines the color of the bar which visualizes the progress. Possible values defined in the sap.ui.core.BarColor enumeration are the following: CRITICAL (yellow), NEGATIVE (red), POSITIVE (green), NEUTRAL (blue) (default value).
						/// </summary>
						public Union<sap.ui.core.BarColor, string, sap.ui.@base.ManagedObject.BindPropertyInfo> barColor;

						/// <summary>
						/// Determines the text value that will be displayed in the bar.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> displayValue;

						/// <summary>
						/// Determines the numerical value for the displayed length of the progress bar.
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> percentValue;

						/// <summary>
						/// Determines whether the percent value shall be rendered inside the bar.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showValue;

						/// <summary>
						/// Determines the width of the control.
						/// </summary>
						public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> width;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new ProgressIndicator.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern ProgressIndicator(string sId, sap.ui.commons.ProgressIndicator.Settings mSettings);

					/// <summary>
					/// Constructor for a new ProgressIndicator.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					public extern ProgressIndicator(string sId);

					/// <summary>
					/// Constructor for a new ProgressIndicator.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern ProgressIndicator();

					/// <summary>
					/// Constructor for a new ProgressIndicator.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern ProgressIndicator(sap.ui.commons.ProgressIndicator.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property enabled

					/// <summary>
					/// Gets current value of property {@link #getEnabled enabled}.
					/// 
					/// Determines whether the control is enabled or not. Disabled controls have different colors, and can not be focused.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>enabled</code></returns>
					public extern virtual bool getEnabled();

					/// <summary>
					/// Sets a new value for property {@link #getEnabled enabled}.
					/// 
					/// Determines whether the control is enabled or not. Disabled controls have different colors, and can not be focused.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bEnabled">New value for property <code>enabled</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ProgressIndicator setEnabled(bool bEnabled);

					#endregion

					#region Methods for Property barColor

					/// <summary>
					/// Gets current value of property {@link #getBarColor barColor}.
					/// 
					/// Determines the color of the bar which visualizes the progress. Possible values defined in the sap.ui.core.BarColor enumeration are the following: CRITICAL (yellow), NEGATIVE (red), POSITIVE (green), NEUTRAL (blue) (default value).
					/// 
					/// Default value is <code>NEUTRAL</code>.
					/// </summary>
					/// <returns>Value of property <code>barColor</code></returns>
					public extern virtual sap.ui.core.BarColor getBarColor();

					/// <summary>
					/// Sets a new value for property {@link #getBarColor barColor}.
					/// 
					/// Determines the color of the bar which visualizes the progress. Possible values defined in the sap.ui.core.BarColor enumeration are the following: CRITICAL (yellow), NEGATIVE (red), POSITIVE (green), NEUTRAL (blue) (default value).
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>NEUTRAL</code>.
					/// </summary>
					/// <param name="sBarColor">New value for property <code>barColor</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ProgressIndicator setBarColor(sap.ui.core.BarColor sBarColor);

					#endregion

					#region Methods for Property displayValue

					/// <summary>
					/// Gets current value of property {@link #getDisplayValue displayValue}.
					/// 
					/// Determines the text value that will be displayed in the bar.
					/// 
					/// Default value is <code>0%</code>.
					/// </summary>
					/// <returns>Value of property <code>displayValue</code></returns>
					public extern virtual string getDisplayValue();

					/// <summary>
					/// Sets a new value for property {@link #getDisplayValue displayValue}.
					/// 
					/// Determines the text value that will be displayed in the bar.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>0%</code>.
					/// </summary>
					/// <param name="sDisplayValue">New value for property <code>displayValue</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ProgressIndicator setDisplayValue(string sDisplayValue);

					#endregion

					#region Methods for Property percentValue

					/// <summary>
					/// Gets current value of property {@link #getPercentValue percentValue}.
					/// 
					/// Determines the numerical value for the displayed length of the progress bar.
					/// 
					/// Default value is <code>0</code>.
					/// </summary>
					/// <returns>Value of property <code>percentValue</code></returns>
					public extern virtual int getPercentValue();

					/// <summary>
					/// Sets the new percent value which the ProgressIndicator should display. A new rendering is not necessary, only the bar has to be moved.
					/// </summary>
					/// <param name="iPercentValue">The new percent value of the ProgressIndicator.</param>
					/// <returns><code>this</code> to allow method chaining.</returns>
					public extern virtual sap.ui.commons.ProgressIndicator setPercentValue(int iPercentValue);

					#endregion

					#region Methods for Property showValue

					/// <summary>
					/// Gets current value of property {@link #getShowValue showValue}.
					/// 
					/// Determines whether the percent value shall be rendered inside the bar.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>showValue</code></returns>
					public extern virtual bool getShowValue();

					/// <summary>
					/// Sets a new value for property {@link #getShowValue showValue}.
					/// 
					/// Determines whether the percent value shall be rendered inside the bar.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bShowValue">New value for property <code>showValue</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ProgressIndicator setShowValue(bool bShowValue);

					#endregion

					#region Methods for Property width

					/// <summary>
					/// Gets current value of property {@link #getWidth width}.
					/// 
					/// Determines the width of the control.
					/// 
					/// Default value is <code>100%</code>.
					/// </summary>
					/// <returns>Value of property <code>width</code></returns>
					public extern virtual sap.ui.core.CSSSize getWidth();

					/// <summary>
					/// Sets a new value for property {@link #getWidth width}.
					/// 
					/// Determines the width of the control.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>100%</code>.
					/// </summary>
					/// <param name="sWidth">New value for property <code>width</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ProgressIndicator setWidth(sap.ui.core.CSSSize sWidth);

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.ProgressIndicator with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.ProgressIndicator with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.ProgressIndicator with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					public extern virtual void getAccessibilityInfo();

					/// <summary>
					/// Returns a metadata object for class sap.ui.commons.ProgressIndicator.
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
