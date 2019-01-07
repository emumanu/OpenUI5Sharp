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
			/// The <code>sap.m.DateTimeField</code> control provides a basic functionality for date/time input controls.
			/// 
			/// To be extended by date and time picker controls. For internal use only.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.DateTimeField")]
			public abstract partial class DateTimeField : sap.m.InputBase
			{
				#region Settings

				/// <summary>
				/// Settings class to create the object
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class Settings : sap.m.InputBase.Settings
				{
					/// <summary>
					/// Determines the format, displayed in the input field.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> displayFormat;

					/// <summary>
					/// Determines the format of the value property.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> valueFormat;

					/// <summary>
					/// Holds a reference to a JavaScript Date Object. The <code>value</code> (string) property will be set according to it. Alternatively, if the <code>value</code> and <code>valueFormat</code> pair properties are supplied instead, the <code>dateValue</code> will be instantiated according to the parsed <code>value</code>. Use <code>dateValue</code> as a helper property to easily obtain the day, month, year, hours, minutes and seconds of the chosen date and time. Although possible to bind it, the recommendation is not to do it. When binding is needed, use <code>value</code> property instead.
					/// </summary>
					public Union<object, string, sap.ui.@base.ManagedObject.BindPropertyInfo> dateValue;

					/// <summary>
					/// Holds a reference to a JavaScript Date Object to define the initially focused date/time when the picker popup is opened.
					/// 
					/// <b>Notes:</b> <ul> <li>Setting this property does not change the <code>value</code> property.</li> <li>Depending on the context this property is used in ({@link sap.m.TimePicker}, {@link sap.m.DatePicker} or {@link sap.m.DateTimePicker}), it takes into account only the time part, only the date part or both parts of the JavaScript Date Object.</li> </ul>
					/// </summary>
					public Union<object, string, sap.ui.@base.ManagedObject.BindPropertyInfo> initialFocusedDateValue;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new <code>sap.m.DateTimeField</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern DateTimeField(string sId, sap.m.DateTimeField.Settings mSettings);

				/// <summary>
				/// Constructor for a new <code>sap.m.DateTimeField</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern DateTimeField(string sId);

				/// <summary>
				/// Constructor for a new <code>sap.m.DateTimeField</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern DateTimeField();

				/// <summary>
				/// Constructor for a new <code>sap.m.DateTimeField</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern DateTimeField(sap.m.DateTimeField.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property displayFormat

				/// <summary>
				/// Gets current value of property {@link #getDisplayFormat displayFormat}.
				/// 
				/// Determines the format, displayed in the input field.
				/// </summary>
				/// <returns>Value of property <code>displayFormat</code></returns>
				public extern virtual string getDisplayFormat();

				/// <summary>
				/// Sets a new value for property {@link #getDisplayFormat displayFormat}.
				/// 
				/// Determines the format, displayed in the input field.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sDisplayFormat">New value for property <code>displayFormat</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.DateTimeField setDisplayFormat(string sDisplayFormat);

				#endregion

				#region Methods for Property valueFormat

				/// <summary>
				/// Gets current value of property {@link #getValueFormat valueFormat}.
				/// 
				/// Determines the format of the value property.
				/// </summary>
				/// <returns>Value of property <code>valueFormat</code></returns>
				public extern virtual string getValueFormat();

				/// <summary>
				/// Sets a new value for property {@link #getValueFormat valueFormat}.
				/// 
				/// Determines the format of the value property.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sValueFormat">New value for property <code>valueFormat</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.DateTimeField setValueFormat(string sValueFormat);

				#endregion

				#region Methods for Property dateValue

				/// <summary>
				/// Gets current value of property {@link #getDateValue dateValue}.
				/// 
				/// Holds a reference to a JavaScript Date Object. The <code>value</code> (string) property will be set according to it. Alternatively, if the <code>value</code> and <code>valueFormat</code> pair properties are supplied instead, the <code>dateValue</code> will be instantiated according to the parsed <code>value</code>. Use <code>dateValue</code> as a helper property to easily obtain the day, month, year, hours, minutes and seconds of the chosen date and time. Although possible to bind it, the recommendation is not to do it. When binding is needed, use <code>value</code> property instead.
				/// </summary>
				/// <returns>Value of property <code>dateValue</code></returns>
				public extern virtual object getDateValue();

				/// <summary>
				/// Sets a new value for property {@link #getDateValue dateValue}.
				/// 
				/// Holds a reference to a JavaScript Date Object. The <code>value</code> (string) property will be set according to it. Alternatively, if the <code>value</code> and <code>valueFormat</code> pair properties are supplied instead, the <code>dateValue</code> will be instantiated according to the parsed <code>value</code>. Use <code>dateValue</code> as a helper property to easily obtain the day, month, year, hours, minutes and seconds of the chosen date and time. Although possible to bind it, the recommendation is not to do it. When binding is needed, use <code>value</code> property instead.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="oDateValue">New value for property <code>dateValue</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.DateTimeField setDateValue(object oDateValue);

				#endregion

				#region Methods for Property initialFocusedDateValue

				/// <summary>
				/// Gets current value of property {@link #getInitialFocusedDateValue initialFocusedDateValue}.
				/// 
				/// Holds a reference to a JavaScript Date Object to define the initially focused date/time when the picker popup is opened.
				/// 
				/// <b>Notes:</b> <ul> <li>Setting this property does not change the <code>value</code> property.</li> <li>Depending on the context this property is used in ({@link sap.m.TimePicker}, {@link sap.m.DatePicker} or {@link sap.m.DateTimePicker}), it takes into account only the time part, only the date part or both parts of the JavaScript Date Object.</li> </ul>
				/// </summary>
				/// <returns>Value of property <code>initialFocusedDateValue</code></returns>
				public extern virtual object getInitialFocusedDateValue();

				/// <summary>
				/// Sets a new value for property {@link #getInitialFocusedDateValue initialFocusedDateValue}.
				/// 
				/// Holds a reference to a JavaScript Date Object to define the initially focused date/time when the picker popup is opened.
				/// 
				/// <b>Notes:</b> <ul> <li>Setting this property does not change the <code>value</code> property.</li> <li>Depending on the context this property is used in ({@link sap.m.TimePicker}, {@link sap.m.DatePicker} or {@link sap.m.DateTimePicker}), it takes into account only the time part, only the date part or both parts of the JavaScript Date Object.</li> </ul>
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="oInitialFocusedDateValue">New value for property <code>initialFocusedDateValue</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.DateTimeField setInitialFocusedDateValue(object oInitialFocusedDateValue);

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.DateTimeField with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.InputBase.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.DateTimeField with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.InputBase.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.DateTimeField with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.InputBase.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.DateTimeField.
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
