using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public static partial class sap
	{
		public static partial class tnt
		{
			/// <summary>
			/// The <code>InfoLabel</code> is a small non-interactive control which contains text information and non-semantic color chosen from a list of predefined color schemes. It serves the purpose to attract the user attention to some piece of information (state, quantity, condition, etc.).
			/// 
			/// <h3>Overview</h3>
			/// 
			/// The control visualizes text information without user interaction. The text inside the control is always in upper case. It can have smaller or larger side paddings which can be specified by the <code>renderMode</code> property. The text-background color pair can be changed by setting a digit between 1 and 9 that corresponds to the 9 predefined color combinations of the <code>colorScheme</code> property. The control is designed to be vertically aligned with UI5 Input and Button control families. When using <code>InfoLabel</code> in non-editable <code>Forms</code>, <code>Tables</code>, etc., set <code>displayOnly=true</code> for best visual results.
			/// 
			/// <h3>Limitations</h3> <ul> <li>If the text is longer than the width of the control, it doesn’t wrap. Instead, it’s represented as ellipsis. </li> <li>When truncated, the full text in the control is not visible. Therefore, it’s recommended to make more space for longer items to be fully displayed.</li> <li>Colors are not semantic and have no visual representation in sap_belize_hcb and sap_belize_hcw themes.</li> <li>The control shows plain text only, formatting is not visualized.</li> </ul>
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.tnt.InfoLabel")]
			public partial class InfoLabel : sap.ui.core.Control, sap.ui.core.IFormContent
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
					/// Specifies the text inside the <code>InfoLabel</code> control.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> text;

					/// <summary>
					/// Specifies the type of the <code>InfoLabel</code> paddings - loose or narrow. <b>Note:</b> By default the padding is loose. It is recommended to use narrow (smaller) paddings for numeric texts.
					/// </summary>
					public Union<sap.tnt.RenderMode, string, sap.ui.@base.ManagedObject.BindPropertyInfo> renderMode;

					/// <summary>
					/// Specifies the fill and text color of the control. Accepts a digit as a value. You can choose from 9 predefined background and text color combinations. The color schemes are non-semantic, you can select them according to your own preferences. The default <code>colorScheme</code> is 7.
					/// </summary>
					public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> colorScheme;

					/// <summary>
					/// Specifies the width of the <code>InfoLabel</code> control. By default, the <code>InfoLabel</code> control has the width of the content. Set this property to restrict the width to a custom value.
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> width;

					/// <summary>
					/// Determines if the <code>InfoLabel</code> is in <code>displayOnly</code> mode. When set to <code>true</code> the control size adjusts to fit other controls, for example non-editable <code>Forms</code>.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> displayOnly;

					/// <summary>
					/// Available options for the text direction are LTR and RTL. By default the control inherits the text direction from its parent control.
					/// </summary>
					public Union<sap.ui.core.TextDirection, string, sap.ui.@base.ManagedObject.BindPropertyInfo> textDirection;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new <code>InfoLabel</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern InfoLabel(string sId, sap.tnt.InfoLabel.Settings mSettings);

				/// <summary>
				/// Constructor for a new <code>InfoLabel</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern InfoLabel(string sId);

				/// <summary>
				/// Constructor for a new <code>InfoLabel</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern InfoLabel();

				/// <summary>
				/// Constructor for a new <code>InfoLabel</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern InfoLabel(sap.tnt.InfoLabel.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property text

				/// <summary>
				/// Gets current value of property {@link #getText text}.
				/// 
				/// Specifies the text inside the <code>InfoLabel</code> control.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <returns>Value of property <code>text</code></returns>
				public extern virtual string getText();

				/// <summary>
				/// Sets a new value for property {@link #getText text}.
				/// 
				/// Specifies the text inside the <code>InfoLabel</code> control.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <param name="sText">New value for property <code>text</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.tnt.InfoLabel setText(string sText);

				/// <summary>
				/// Binds property {@link #getText text} to model data.
				/// 
				/// See {@link sap.ui.base.ManagedObject#bindProperty ManagedObject.bindProperty} for a detailed description of the possible properties of <code>oBindingInfo</code>
				/// </summary>
				/// <param name="oBindingInfo">The binding information</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.tnt.InfoLabel bindText(object oBindingInfo);

				/// <summary>
				/// Unbinds property {@link #getText text} from model data.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.tnt.InfoLabel unbindText();

				#endregion

				#region Methods for Property renderMode

				/// <summary>
				/// Gets current value of property {@link #getRenderMode renderMode}.
				/// 
				/// Specifies the type of the <code>InfoLabel</code> paddings - loose or narrow. <b>Note:</b> By default the padding is loose. It is recommended to use narrow (smaller) paddings for numeric texts.
				/// 
				/// Default value is <code>Loose</code>.
				/// </summary>
				/// <returns>Value of property <code>renderMode</code></returns>
				public extern virtual sap.tnt.RenderMode getRenderMode();

				/// <summary>
				/// Sets a new value for property {@link #getRenderMode renderMode}.
				/// 
				/// Specifies the type of the <code>InfoLabel</code> paddings - loose or narrow. <b>Note:</b> By default the padding is loose. It is recommended to use narrow (smaller) paddings for numeric texts.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Loose</code>.
				/// </summary>
				/// <param name="sRenderMode">New value for property <code>renderMode</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.tnt.InfoLabel setRenderMode(sap.tnt.RenderMode sRenderMode);

				#endregion

				#region Methods for Property colorScheme

				/// <summary>
				/// Gets current value of property {@link #getColorScheme colorScheme}.
				/// 
				/// Specifies the fill and text color of the control. Accepts a digit as a value. You can choose from 9 predefined background and text color combinations. The color schemes are non-semantic, you can select them according to your own preferences. The default <code>colorScheme</code> is 7.
				/// 
				/// Default value is <code>7</code>.
				/// </summary>
				/// <returns>Value of property <code>colorScheme</code></returns>
				public extern virtual int getColorScheme();

				/// <summary>
				/// Sets a new value for property {@link #getColorScheme colorScheme}.
				/// 
				/// Specifies the fill and text color of the control. Accepts a digit as a value. You can choose from 9 predefined background and text color combinations. The color schemes are non-semantic, you can select them according to your own preferences. The default <code>colorScheme</code> is 7.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>7</code>.
				/// </summary>
				/// <param name="iColorScheme">New value for property <code>colorScheme</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.tnt.InfoLabel setColorScheme(int iColorScheme);

				#endregion

				#region Methods for Property width

				/// <summary>
				/// Gets current value of property {@link #getWidth width}.
				/// 
				/// Specifies the width of the <code>InfoLabel</code> control. By default, the <code>InfoLabel</code> control has the width of the content. Set this property to restrict the width to a custom value.
				/// </summary>
				/// <returns>Value of property <code>width</code></returns>
				public extern virtual sap.ui.core.CSSSize getWidth();

				/// <summary>
				/// Sets a new value for property {@link #getWidth width}.
				/// 
				/// Specifies the width of the <code>InfoLabel</code> control. By default, the <code>InfoLabel</code> control has the width of the content. Set this property to restrict the width to a custom value.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sWidth">New value for property <code>width</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.tnt.InfoLabel setWidth(sap.ui.core.CSSSize sWidth);

				#endregion

				#region Methods for Property displayOnly

				/// <summary>
				/// Gets current value of property {@link #getDisplayOnly displayOnly}.
				/// 
				/// Determines if the <code>InfoLabel</code> is in <code>displayOnly</code> mode. When set to <code>true</code> the control size adjusts to fit other controls, for example non-editable <code>Forms</code>.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>displayOnly</code></returns>
				public extern virtual bool getDisplayOnly();

				/// <summary>
				/// Sets a new value for property {@link #getDisplayOnly displayOnly}.
				/// 
				/// Determines if the <code>InfoLabel</code> is in <code>displayOnly</code> mode. When set to <code>true</code> the control size adjusts to fit other controls, for example non-editable <code>Forms</code>.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bDisplayOnly">New value for property <code>displayOnly</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.tnt.InfoLabel setDisplayOnly(bool bDisplayOnly);

				#endregion

				#region Methods for Property textDirection

				/// <summary>
				/// Gets current value of property {@link #getTextDirection textDirection}.
				/// 
				/// Available options for the text direction are LTR and RTL. By default the control inherits the text direction from its parent control.
				/// 
				/// Default value is <code>Inherit</code>.
				/// </summary>
				/// <returns>Value of property <code>textDirection</code></returns>
				public extern virtual sap.ui.core.TextDirection getTextDirection();

				/// <summary>
				/// Sets a new value for property {@link #getTextDirection textDirection}.
				/// 
				/// Available options for the text direction are LTR and RTL. By default the control inherits the text direction from its parent control.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Inherit</code>.
				/// </summary>
				/// <param name="sTextDirection">New value for property <code>textDirection</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.tnt.InfoLabel setTextDirection(sap.ui.core.TextDirection sTextDirection);

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.tnt.InfoLabel with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.tnt.InfoLabel with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.tnt.InfoLabel with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.tnt.InfoLabel.
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
