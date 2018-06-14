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
			/// Base type for <code>items</code> aggregation in <code>P13nPanel</code> control.
			/// </summary>
			[External]
			[Namespace(false)]
			public partial class P13nItem : sap.ui.core.Element
			{
				#region Settings

				/// <summary>
				/// Settings class to create the object
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class Settings : sap.ui.core.Element.Settings
				{
					/// <summary>
					/// Can be used as input for subsequent actions.
					/// </summary>
					public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> columnKey;

					/// <summary>
					/// The text to be displayed for the item.
					/// </summary>
					public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> text;

					/// <summary>
					/// Defines visibility of column
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> visible;

					/// <summary>
					/// data type of the column (text, numeric or date is supported)
					/// </summary>
					public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> type;

					/// <summary>
					/// if type==numeric the precision will be used to format the entered value (maxIntegerDigits of the used Formatter)
					/// </summary>
					public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> precision;

					/// <summary>
					/// A JSON object containing the formatSettings which will be used to pass additional type/format settings for the entered value. if type==time or date or datetime the object will be used for the DateFormatter, TimeFormatter or DateTimeFormatter
					/// 
					/// <i>Below you can find a brief example</i>
					/// 
					/// <pre><code>
					/// {
					/// 		UTC: false,
					/// 		style: "medium" //"short" or "long"
					/// }
					/// </code></pre>
					/// </summary>
					public Union<object, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> formatSettings;

					/// <summary>
					/// if type==numeric the scale will be used to format the entered value (maxFractionDigits of the used Formatter)
					/// </summary>
					public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> scale;

					/// <summary>
					/// specifies the number of characters which can be entered in the value fields of the condition panel
					/// </summary>
					public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> maxLength;

					/// <summary>
					/// Defines column width
					/// </summary>
					public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> width;

					/// <summary>
					/// the column with isDefault==true will be used as the selected column item on the conditionPanel
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> isDefault;

					/// <summary>
					/// the array of values for type bool. e.g. ["", "Off", "On"]. The first entry can be empty (used to blank the value field). Next value represent the false value, last entry the true value.
					/// </summary>
					public Union<string[], string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> values;

					/// <summary>
					/// Defines role. The role is reflected in the manner how the dimension will influence the chart layout.
					/// </summary>
					public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> role;

					/// <summary>
					/// Defines aggregation role
					/// </summary>
					public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> aggregationRole;

					/// <summary>
					/// Defines href of a link.
					/// </summary>
					public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> href;

					/// <summary>
					/// Defines target of a link.
					/// </summary>
					public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> target;

					/// <summary>
					/// Defines press handler of a link.
					/// </summary>
					public Union<object, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> press;

					/// <summary>
					/// Defines additional information of the link.
					/// </summary>
					public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> description;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new P13nItem.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">initial settings for the new control</param>
				public extern P13nItem(string sId, sap.m.P13nItem.Settings mSettings);

				/// <summary>
				/// Constructor for a new P13nItem.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern P13nItem(string sId);

				/// <summary>
				/// Constructor for a new P13nItem.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern P13nItem();

				/// <summary>
				/// Constructor for a new P13nItem.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">initial settings for the new control</param>
				public extern P13nItem(sap.m.P13nItem.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property columnKey

				/// <summary>
				/// Gets current value of property {@link #getColumnKey columnKey}.
				/// 
				/// Can be used as input for subsequent actions.
				/// </summary>
				/// <returns>Value of property <code>columnKey</code></returns>
				public extern virtual string getColumnKey();

				/// <summary>
				/// Sets a new value for property {@link #getColumnKey columnKey}.
				/// 
				/// Can be used as input for subsequent actions.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sColumnKey">New value for property <code>columnKey</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nItem setColumnKey(string sColumnKey);

				#endregion

				#region Methods for Property text

				/// <summary>
				/// Gets current value of property {@link #getText text}.
				/// 
				/// The text to be displayed for the item.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <returns>Value of property <code>text</code></returns>
				public extern virtual string getText();

				/// <summary>
				/// Sets a new value for property {@link #getText text}.
				/// 
				/// The text to be displayed for the item.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <param name="sText">New value for property <code>text</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nItem setText(string sText);

				#endregion

				#region Methods for Property visible

				/// <summary>
				/// Gets current value of property {@link #getVisible visible}.
				/// 
				/// Defines visibility of column
				/// </summary>
				/// <returns>Value of property <code>visible</code></returns>
				public extern virtual bool getVisible();

				/// <summary>
				/// Sets a new value for property {@link #getVisible visible}.
				/// 
				/// Defines visibility of column
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="bVisible">New value for property <code>visible</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nItem setVisible(bool bVisible);

				#endregion

				#region Methods for Property type

				/// <summary>
				/// Gets current value of property {@link #getType type}.
				/// 
				/// data type of the column (text, numeric or date is supported)
				/// 
				/// Default value is <code>text</code>.
				/// </summary>
				/// <returns>Value of property <code>type</code></returns>
				public extern virtual string getType();

				/// <summary>
				/// Sets a new value for property {@link #getType type}.
				/// 
				/// data type of the column (text, numeric or date is supported)
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>text</code>.
				/// </summary>
				/// <param name="sType">New value for property <code>type</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nItem setType(string sType);

				#endregion

				#region Methods for Property precision

				/// <summary>
				/// Gets current value of property {@link #getPrecision precision}.
				/// 
				/// if type==numeric the precision will be used to format the entered value (maxIntegerDigits of the used Formatter)
				/// </summary>
				/// <returns>Value of property <code>precision</code></returns>
				public extern virtual string getPrecision();

				/// <summary>
				/// Sets a new value for property {@link #getPrecision precision}.
				/// 
				/// if type==numeric the precision will be used to format the entered value (maxIntegerDigits of the used Formatter)
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sPrecision">New value for property <code>precision</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nItem setPrecision(string sPrecision);

				#endregion

				#region Methods for Property formatSettings

				/// <summary>
				/// Gets current value of property {@link #getFormatSettings formatSettings}.
				/// 
				/// A JSON object containing the formatSettings which will be used to pass additional type/format settings for the entered value. if type==time or date or datetime the object will be used for the DateFormatter, TimeFormatter or DateTimeFormatter
				/// 
				/// <i>Below you can find a brief example</i>
				/// 
				/// <pre><code>
				/// {
				/// 		UTC: false,
				/// 		style: "medium" //"short" or "long"
				/// }
				/// </code></pre>
				/// </summary>
				/// <returns>Value of property <code>formatSettings</code></returns>
				public extern virtual object getFormatSettings();

				/// <summary>
				/// Sets a new value for property {@link #getFormatSettings formatSettings}.
				/// 
				/// A JSON object containing the formatSettings which will be used to pass additional type/format settings for the entered value. if type==time or date or datetime the object will be used for the DateFormatter, TimeFormatter or DateTimeFormatter
				/// 
				/// <i>Below you can find a brief example</i>
				/// 
				/// <pre><code>
				/// {
				/// 		UTC: false,
				/// 		style: "medium" //"short" or "long"
				/// }
				/// </code></pre>
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="oFormatSettings">New value for property <code>formatSettings</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nItem setFormatSettings(object oFormatSettings);

				#endregion

				#region Methods for Property scale

				/// <summary>
				/// Gets current value of property {@link #getScale scale}.
				/// 
				/// if type==numeric the scale will be used to format the entered value (maxFractionDigits of the used Formatter)
				/// </summary>
				/// <returns>Value of property <code>scale</code></returns>
				public extern virtual string getScale();

				/// <summary>
				/// Sets a new value for property {@link #getScale scale}.
				/// 
				/// if type==numeric the scale will be used to format the entered value (maxFractionDigits of the used Formatter)
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sScale">New value for property <code>scale</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nItem setScale(string sScale);

				#endregion

				#region Methods for Property maxLength

				/// <summary>
				/// Gets current value of property {@link #getMaxLength maxLength}.
				/// 
				/// specifies the number of characters which can be entered in the value fields of the condition panel
				/// </summary>
				/// <returns>Value of property <code>maxLength</code></returns>
				public extern virtual string getMaxLength();

				/// <summary>
				/// Sets a new value for property {@link #getMaxLength maxLength}.
				/// 
				/// specifies the number of characters which can be entered in the value fields of the condition panel
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sMaxLength">New value for property <code>maxLength</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nItem setMaxLength(string sMaxLength);

				#endregion

				#region Methods for Property width

				/// <summary>
				/// Gets current value of property {@link #getWidth width}.
				/// 
				/// Defines column width
				/// </summary>
				/// <returns>Value of property <code>width</code></returns>
				public extern virtual string getWidth();

				/// <summary>
				/// Sets a new value for property {@link #getWidth width}.
				/// 
				/// Defines column width
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sWidth">New value for property <code>width</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nItem setWidth(string sWidth);

				#endregion

				#region Methods for Property isDefault

				/// <summary>
				/// Gets current value of property {@link #getIsDefault isDefault}.
				/// 
				/// the column with isDefault==true will be used as the selected column item on the conditionPanel
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>isDefault</code></returns>
				public extern virtual bool getIsDefault();

				/// <summary>
				/// Sets a new value for property {@link #getIsDefault isDefault}.
				/// 
				/// the column with isDefault==true will be used as the selected column item on the conditionPanel
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bIsDefault">New value for property <code>isDefault</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nItem setIsDefault(bool bIsDefault);

				#endregion

				#region Methods for Property values

				/// <summary>
				/// Gets current value of property {@link #getValues values}.
				/// 
				/// the array of values for type bool. e.g. ["", "Off", "On"]. The first entry can be empty (used to blank the value field). Next value represent the false value, last entry the true value.
				/// </summary>
				/// <returns>Value of property <code>values</code></returns>
				public extern virtual string[] getValues();

				/// <summary>
				/// Sets a new value for property {@link #getValues values}.
				/// 
				/// the array of values for type bool. e.g. ["", "Off", "On"]. The first entry can be empty (used to blank the value field). Next value represent the false value, last entry the true value.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sValues">New value for property <code>values</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nItem setValues(string[] sValues);

				/// <summary>
				/// Sets a new value for property {@link #getValues values}.
				/// 
				/// the array of values for type bool. e.g. ["", "Off", "On"]. The first entry can be empty (used to blank the value field). Next value represent the false value, last entry the true value.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sValues">New value for property <code>values</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nItem setValues(object[] sValues);

				#endregion

				#region Methods for Property role

				/// <summary>
				/// Gets current value of property {@link #getRole role}.
				/// 
				/// Defines role. The role is reflected in the manner how the dimension will influence the chart layout.
				/// </summary>
				/// <returns>Value of property <code>role</code></returns>
				public extern virtual string getRole();

				/// <summary>
				/// Sets a new value for property {@link #getRole role}.
				/// 
				/// Defines role. The role is reflected in the manner how the dimension will influence the chart layout.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sRole">New value for property <code>role</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nItem setRole(string sRole);

				#endregion

				#region Methods for Property aggregationRole

				/// <summary>
				/// Gets current value of property {@link #getAggregationRole aggregationRole}.
				/// 
				/// Defines aggregation role
				/// </summary>
				/// <returns>Value of property <code>aggregationRole</code></returns>
				public extern virtual string getAggregationRole();

				/// <summary>
				/// Sets a new value for property {@link #getAggregationRole aggregationRole}.
				/// 
				/// Defines aggregation role
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sAggregationRole">New value for property <code>aggregationRole</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nItem setAggregationRole(string sAggregationRole);

				#endregion

				#region Methods for Property href

				/// <summary>
				/// Gets current value of property {@link #getHref href}.
				/// 
				/// Defines href of a link.
				/// </summary>
				/// <returns>Value of property <code>href</code></returns>
				public extern virtual string getHref();

				/// <summary>
				/// Sets a new value for property {@link #getHref href}.
				/// 
				/// Defines href of a link.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sHref">New value for property <code>href</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nItem setHref(string sHref);

				#endregion

				#region Methods for Property target

				/// <summary>
				/// Gets current value of property {@link #getTarget target}.
				/// 
				/// Defines target of a link.
				/// </summary>
				/// <returns>Value of property <code>target</code></returns>
				public extern virtual string getTarget();

				/// <summary>
				/// Sets a new value for property {@link #getTarget target}.
				/// 
				/// Defines target of a link.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sTarget">New value for property <code>target</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nItem setTarget(string sTarget);

				#endregion

				#region Methods for Property press

				/// <summary>
				/// Gets current value of property {@link #getPress press}.
				/// 
				/// Defines press handler of a link.
				/// </summary>
				/// <returns>Value of property <code>press</code></returns>
				public extern virtual object getPress();

				/// <summary>
				/// Sets a new value for property {@link #getPress press}.
				/// 
				/// Defines press handler of a link.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="oPress">New value for property <code>press</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nItem setPress(object oPress);

				#endregion

				#region Methods for Property description

				/// <summary>
				/// Gets current value of property {@link #getDescription description}.
				/// 
				/// Defines additional information of the link.
				/// </summary>
				/// <returns>Value of property <code>description</code></returns>
				public extern virtual string getDescription();

				/// <summary>
				/// Sets a new value for property {@link #getDescription description}.
				/// 
				/// Defines additional information of the link.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sDescription">New value for property <code>description</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nItem setDescription(string sDescription);

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.P13nItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.P13nItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.P13nItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.P13nItem.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				#endregion

				#endregion

			}
		}
	}
}
