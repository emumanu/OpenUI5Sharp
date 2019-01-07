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
				/// Allows end users to interact with dates. Entries can directly be written in, or selected from a calendar pad. Note: Dates can always be manually entered in the fix YYYYMMDD format, on top of the flexible "locale" format. If the value is provided via data binding, using a Date.type the formatter of the Date.type is used. Since version 1.22 the unified.Calendar is used inside the datePicker. So applications using the DatePicker should load the unified library. Otherwise it will be loaded the first time a DatePicker is opened.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.DatePicker")]
				[Obsolete("Deprecated since 1.38. replaced by {@link sap.m.DatePicker}")]
				public partial class DatePicker : sap.ui.commons.TextField
				{
					#region Settings

					/// <summary>
					/// Settings class to create the object
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class Settings : sap.ui.commons.TextField.Settings
					{
						/// <summary>
						/// Defines the locale (language and country), e.g. "en-US", whose translations and Date formatters should be used to render the DatePicker.If the value property is bound to a model using a Date type the locale will be ignored, because the locale information of the model are used.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> locale;

						/// <summary>
						/// Defines the date as a "yyyymmdd" string, independent from the format used. The inherited textField "value" attribute uses the date format as configured via the locale. The date is interpreted as gregorian date
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> yyyymmdd;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new DatePicker.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern DatePicker(string sId, sap.ui.commons.DatePicker.Settings mSettings);

					/// <summary>
					/// Constructor for a new DatePicker.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern DatePicker(string sId);

					/// <summary>
					/// Constructor for a new DatePicker.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern DatePicker();

					/// <summary>
					/// Constructor for a new DatePicker.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern DatePicker(sap.ui.commons.DatePicker.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property locale

					/// <summary>
					/// Gets current value of property {@link #getLocale locale}.
					/// 
					/// Defines the locale (language and country), e.g. "en-US", whose translations and Date formatters should be used to render the DatePicker.If the value property is bound to a model using a Date type the locale will be ignored, because the locale information of the model are used.
					/// </summary>
					/// <returns>Value of property <code>locale</code></returns>
					public extern virtual string getLocale();

					/// <summary>
					/// Sets a new value for property {@link #getLocale locale}.
					/// 
					/// Defines the locale (language and country), e.g. "en-US", whose translations and Date formatters should be used to render the DatePicker.If the value property is bound to a model using a Date type the locale will be ignored, because the locale information of the model are used.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sLocale">New value for property <code>locale</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.DatePicker setLocale(string sLocale);

					#endregion

					#region Methods for Property yyyymmdd

					/// <summary>
					/// Gets current value of property {@link #getYyyymmdd yyyymmdd}.
					/// 
					/// Defines the date as a "yyyymmdd" string, independent from the format used. The inherited textField "value" attribute uses the date format as configured via the locale. The date is interpreted as gregorian date
					/// </summary>
					/// <returns>Value of property <code>yyyymmdd</code></returns>
					public extern virtual string getYyyymmdd();

					/// <summary>
					/// Sets a new value for property {@link #getYyyymmdd yyyymmdd}.
					/// 
					/// Defines the date as a "yyyymmdd" string, independent from the format used. The inherited textField "value" attribute uses the date format as configured via the locale. The date is interpreted as gregorian date
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sYyyymmdd">New value for property <code>yyyymmdd</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.DatePicker setYyyymmdd(string sYyyymmdd);

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.DatePicker with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.commons.TextField.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.DatePicker with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.commons.TextField.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.DatePicker with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.commons.TextField.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Fire event change to attached listeners.
					/// 
					/// Provides the following event parameters: <ul> <li>'newValue' of type <code>string</code> The new / changed value of the DatePicker.</li> <li>'newYyyymmdd' of type <code>string</code> The new / changed Yyyymmdd of the DatePicker. </li> <li>'invalidValue' of type <code>boolean</code> The new / changed value of the DatePicker is not a valid date. </li> </ul>
					/// </summary>
					/// <param name="bInvalidValue">true is value is invalid</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.commons.DatePicker fireChange(bool bInvalidValue);

					/// <returns>Current accessibility state of the control</returns>
					public extern override object getAccessibilityInfo();

					/// <summary>
					/// Returns a metadata object for class sap.ui.commons.DatePicker.
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
