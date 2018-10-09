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
			/// Shows the progress of a process in a graphical way. To indicate the progress, the inside of the ProgressIndicator is filled with a color. Additionally, a user-defined string can be displayed on the ProgressIndicator.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.ProgressIndicator")]
			public partial class ProgressIndicator : sap.ui.core.Control, sap.ui.core.IFormContent
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
					/// Switches enabled state of the control. Disabled fields have different colors, and cannot be focused.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> enabled;

					/// <summary>
					/// Specifies the state of the bar. Enumeration sap.ui.core.ValueState provides Error (red), Warning (yellow), Success (green), None (blue) (default value).
					/// </summary>
					public Union<sap.ui.core.ValueState, string, sap.ui.@base.ManagedObject.BindPropertyInfo> state;

					/// <summary>
					/// Specifies the text value to be displayed in the bar.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> displayValue;

					/// <summary>
					/// Specifies the numerical value in percent for the length of the progress bar.
					/// 
					/// <b>Note:</b> If a value greater than 100 is provided, the <code>percentValue</code> is set to 100. In other cases of invalid value, <code>percentValue</code> is set to its default of 0.
					/// </summary>
					public Union<float, string, sap.ui.@base.ManagedObject.BindPropertyInfo> percentValue;

					/// <summary>
					/// Indicates whether the displayValue should be shown in the ProgressIndicator.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showValue;

					/// <summary>
					/// Specifies the width of the control.
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> width;

					/// <summary>
					/// Specifies the height of the control. The default value depends on the theme. Suggested size for normal use is 2.5rem (40px). Suggested size for small size (like for use in ObjectHeader) is 1.375rem (22px).
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> height;

					/// <summary>
					/// Specifies the element's text directionality with enumerated options (RTL or LTR). By default, the control inherits text direction from the DOM.
					/// </summary>
					public Union<sap.ui.core.TextDirection, string, sap.ui.@base.ManagedObject.BindPropertyInfo> textDirection;

					/// <summary>
					/// Determines whether the control is in display-only state where the control has different visualization and cannot be focused.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> displayOnly;

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
				public extern ProgressIndicator(string sId, sap.m.ProgressIndicator.Settings mSettings);

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
				public extern ProgressIndicator(sap.m.ProgressIndicator.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property enabled

				/// <summary>
				/// Gets current value of property {@link #getEnabled enabled}.
				/// 
				/// Switches enabled state of the control. Disabled fields have different colors, and cannot be focused.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>enabled</code></returns>
				public extern virtual bool getEnabled();

				/// <summary>
				/// Sets a new value for property {@link #getEnabled enabled}.
				/// 
				/// Switches enabled state of the control. Disabled fields have different colors, and cannot be focused.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bEnabled">New value for property <code>enabled</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ProgressIndicator setEnabled(bool bEnabled);

				#endregion

				#region Methods for Property state

				/// <summary>
				/// Gets current value of property {@link #getState state}.
				/// 
				/// Specifies the state of the bar. Enumeration sap.ui.core.ValueState provides Error (red), Warning (yellow), Success (green), None (blue) (default value).
				/// 
				/// Default value is <code>None</code>.
				/// </summary>
				/// <returns>Value of property <code>state</code></returns>
				public extern virtual sap.ui.core.ValueState getState();

				/// <summary>
				/// Sets a new value for property {@link #getState state}.
				/// 
				/// Specifies the state of the bar. Enumeration sap.ui.core.ValueState provides Error (red), Warning (yellow), Success (green), None (blue) (default value).
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>None</code>.
				/// </summary>
				/// <param name="sState">New value for property <code>state</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ProgressIndicator setState(sap.ui.core.ValueState sState);

				#endregion

				#region Methods for Property displayValue

				/// <summary>
				/// Gets current value of property {@link #getDisplayValue displayValue}.
				/// 
				/// Specifies the text value to be displayed in the bar.
				/// </summary>
				/// <returns>Value of property <code>displayValue</code></returns>
				public extern virtual string getDisplayValue();

				/// <summary>
				/// Sets a new value for property {@link #getDisplayValue displayValue}.
				/// 
				/// Specifies the text value to be displayed in the bar.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sDisplayValue">New value for property <code>displayValue</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ProgressIndicator setDisplayValue(string sDisplayValue);

				#endregion

				#region Methods for Property percentValue

				/// <summary>
				/// Gets current value of property {@link #getPercentValue percentValue}.
				/// 
				/// Specifies the numerical value in percent for the length of the progress bar.
				/// 
				/// <b>Note:</b> If a value greater than 100 is provided, the <code>percentValue</code> is set to 100. In other cases of invalid value, <code>percentValue</code> is set to its default of 0.
				/// 
				/// Default value is <code>0</code>.
				/// </summary>
				/// <returns>Value of property <code>percentValue</code></returns>
				public extern virtual float getPercentValue();

				/// <summary>
				/// Sets a new value for property {@link #getPercentValue percentValue}.
				/// 
				/// Specifies the numerical value in percent for the length of the progress bar.
				/// 
				/// <b>Note:</b> If a value greater than 100 is provided, the <code>percentValue</code> is set to 100. In other cases of invalid value, <code>percentValue</code> is set to its default of 0.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>0</code>.
				/// </summary>
				/// <param name="fPercentValue">New value for property <code>percentValue</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ProgressIndicator setPercentValue(float fPercentValue);

				#endregion

				#region Methods for Property showValue

				/// <summary>
				/// Gets current value of property {@link #getShowValue showValue}.
				/// 
				/// Indicates whether the displayValue should be shown in the ProgressIndicator.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>showValue</code></returns>
				public extern virtual bool getShowValue();

				/// <summary>
				/// Sets a new value for property {@link #getShowValue showValue}.
				/// 
				/// Indicates whether the displayValue should be shown in the ProgressIndicator.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bShowValue">New value for property <code>showValue</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ProgressIndicator setShowValue(bool bShowValue);

				#endregion

				#region Methods for Property width

				/// <summary>
				/// Gets current value of property {@link #getWidth width}.
				/// 
				/// Specifies the width of the control.
				/// 
				/// Default value is <code>100%</code>.
				/// </summary>
				/// <returns>Value of property <code>width</code></returns>
				public extern virtual sap.ui.core.CSSSize getWidth();

				/// <summary>
				/// Sets a new value for property {@link #getWidth width}.
				/// 
				/// Specifies the width of the control.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>100%</code>.
				/// </summary>
				/// <param name="sWidth">New value for property <code>width</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ProgressIndicator setWidth(sap.ui.core.CSSSize sWidth);

				#endregion

				#region Methods for Property height

				/// <summary>
				/// Gets current value of property {@link #getHeight height}.
				/// 
				/// Specifies the height of the control. The default value depends on the theme. Suggested size for normal use is 2.5rem (40px). Suggested size for small size (like for use in ObjectHeader) is 1.375rem (22px).
				/// </summary>
				/// <returns>Value of property <code>height</code></returns>
				public extern virtual sap.ui.core.CSSSize getHeight();

				/// <summary>
				/// Sets a new value for property {@link #getHeight height}.
				/// 
				/// Specifies the height of the control. The default value depends on the theme. Suggested size for normal use is 2.5rem (40px). Suggested size for small size (like for use in ObjectHeader) is 1.375rem (22px).
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sHeight">New value for property <code>height</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ProgressIndicator setHeight(sap.ui.core.CSSSize sHeight);

				#endregion

				#region Methods for Property textDirection

				/// <summary>
				/// Gets current value of property {@link #getTextDirection textDirection}.
				/// 
				/// Specifies the element's text directionality with enumerated options (RTL or LTR). By default, the control inherits text direction from the DOM.
				/// 
				/// Default value is <code>Inherit</code>.
				/// </summary>
				/// <returns>Value of property <code>textDirection</code></returns>
				public extern virtual sap.ui.core.TextDirection getTextDirection();

				/// <summary>
				/// Sets a new value for property {@link #getTextDirection textDirection}.
				/// 
				/// Specifies the element's text directionality with enumerated options (RTL or LTR). By default, the control inherits text direction from the DOM.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Inherit</code>.
				/// </summary>
				/// <param name="sTextDirection">New value for property <code>textDirection</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ProgressIndicator setTextDirection(sap.ui.core.TextDirection sTextDirection);

				#endregion

				#region Methods for Property displayOnly

				/// <summary>
				/// Gets current value of property {@link #getDisplayOnly displayOnly}.
				/// 
				/// Determines whether the control is in display-only state where the control has different visualization and cannot be focused.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>displayOnly</code></returns>
				public extern virtual bool getDisplayOnly();

				/// <summary>
				/// Sets a new value for property {@link #getDisplayOnly displayOnly}.
				/// 
				/// Determines whether the control is in display-only state where the control has different visualization and cannot be focused.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bDisplayOnly">New value for property <code>displayOnly</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ProgressIndicator setDisplayOnly(bool bDisplayOnly);

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.ProgressIndicator with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.ProgressIndicator with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.ProgressIndicator with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns the <code>sap.m.ProgressIndicator</code> accessibility information.
				/// </summary>
				/// <returns>The <code>sap.m.ProgressIndicator</code> accessibility information</returns>
				public extern override object getAccessibilityInfo();

				/// <summary>
				/// Returns a metadata object for class sap.m.ProgressIndicator.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				#endregion

				#region Methods of sap.ui.core.IFormContent Interface

				/// <summary>
				/// In the <code>Form</code> control all content controls are positioned on a grid cell base. By default the controls use the full width of the used grid cell. But for some controls (like image controls), this is not the desired behavior. In this case the control must keep its original width.
				/// </summary>
				/// <returns>true if the <code>Form</code> is not allowed to adjust the width of the control to use the cell's width</returns>
				public extern static bool getFormDoNotAdjustWidth();

				#endregion

				#endregion

			}
		}
	}
}
