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
			public static partial class unified
			{
				/// <summary>
				/// An appointment for use in a <code>PlanningCalendar</code> or similar. The rendering must be done in the Row collecting the appointments. (Because there are different visualizations possible.)
				/// 
				/// Applications could inherit from this element to add own fields.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.unified.CalendarAppointment")]
				public partial class CalendarAppointment : sap.ui.unified.DateTypeRange
				{
					#region Settings

					/// <summary>
					/// Settings class to create the object
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class Settings : sap.ui.unified.DateTypeRange.Settings
					{
						/// <summary>
						/// Title of the appointment.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> title;

						/// <summary>
						/// Text of the appointment.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> text;

						/// <summary>
						/// Icon of the Appointment. (e.g. picture of the person)
						/// 
						/// URI of an image or an icon registered in sap.ui.core.IconPool.
						/// </summary>
						public Union<sap.ui.core.URI, string, sap.ui.@base.ManagedObject.BindPropertyInfo> icon;

						/// <summary>
						/// Indicates if the icon is tentative.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> tentative;

						/// <summary>
						/// Indicates if the icon is selected.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> selected;

						/// <summary>
						/// Can be used as identifier of the appointment
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> key;

						/// <summary>
						/// Overrides the color derived from the <code>type</code> property. This property will work only with full hex color with pound symbol, e.g.: #FF0000.
						/// </summary>
						public Union<sap.ui.core.CSSColor, string, sap.ui.@base.ManagedObject.BindPropertyInfo> color;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new <code>CalendarAppointment</code>.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern CalendarAppointment(string sId, sap.ui.unified.CalendarAppointment.Settings mSettings);

					/// <summary>
					/// Constructor for a new <code>CalendarAppointment</code>.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					public extern CalendarAppointment(string sId);

					/// <summary>
					/// Constructor for a new <code>CalendarAppointment</code>.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern CalendarAppointment();

					/// <summary>
					/// Constructor for a new <code>CalendarAppointment</code>.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern CalendarAppointment(sap.ui.unified.CalendarAppointment.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property title

					/// <summary>
					/// Gets current value of property {@link #getTitle title}.
					/// 
					/// Title of the appointment.
					/// </summary>
					/// <returns>Value of property <code>title</code></returns>
					public extern virtual string getTitle();

					/// <summary>
					/// Sets a new value for property {@link #getTitle title}.
					/// 
					/// Title of the appointment.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sTitle">New value for property <code>title</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarAppointment setTitle(string sTitle);

					#endregion

					#region Methods for Property text

					/// <summary>
					/// Gets current value of property {@link #getText text}.
					/// 
					/// Text of the appointment.
					/// </summary>
					/// <returns>Value of property <code>text</code></returns>
					public extern virtual string getText();

					/// <summary>
					/// Sets a new value for property {@link #getText text}.
					/// 
					/// Text of the appointment.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sText">New value for property <code>text</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarAppointment setText(string sText);

					#endregion

					#region Methods for Property icon

					/// <summary>
					/// Gets current value of property {@link #getIcon icon}.
					/// 
					/// Icon of the Appointment. (e.g. picture of the person)
					/// 
					/// URI of an image or an icon registered in sap.ui.core.IconPool.
					/// </summary>
					/// <returns>Value of property <code>icon</code></returns>
					public extern virtual sap.ui.core.URI getIcon();

					/// <summary>
					/// Sets a new value for property {@link #getIcon icon}.
					/// 
					/// Icon of the Appointment. (e.g. picture of the person)
					/// 
					/// URI of an image or an icon registered in sap.ui.core.IconPool.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sIcon">New value for property <code>icon</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarAppointment setIcon(sap.ui.core.URI sIcon);

					#endregion

					#region Methods for Property tentative

					/// <summary>
					/// Gets current value of property {@link #getTentative tentative}.
					/// 
					/// Indicates if the icon is tentative.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>tentative</code></returns>
					public extern virtual bool getTentative();

					/// <summary>
					/// Sets a new value for property {@link #getTentative tentative}.
					/// 
					/// Indicates if the icon is tentative.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bTentative">New value for property <code>tentative</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarAppointment setTentative(bool bTentative);

					#endregion

					#region Methods for Property selected

					/// <summary>
					/// Gets current value of property {@link #getSelected selected}.
					/// 
					/// Indicates if the icon is selected.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>selected</code></returns>
					public extern virtual bool getSelected();

					/// <summary>
					/// Sets a new value for property {@link #getSelected selected}.
					/// 
					/// Indicates if the icon is selected.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bSelected">New value for property <code>selected</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarAppointment setSelected(bool bSelected);

					#endregion

					#region Methods for Property key

					/// <summary>
					/// Gets current value of property {@link #getKey key}.
					/// 
					/// Can be used as identifier of the appointment
					/// </summary>
					/// <returns>Value of property <code>key</code></returns>
					public extern virtual string getKey();

					/// <summary>
					/// Sets a new value for property {@link #getKey key}.
					/// 
					/// Can be used as identifier of the appointment
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sKey">New value for property <code>key</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarAppointment setKey(string sKey);

					#endregion

					#region Methods for Property color

					/// <summary>
					/// Gets current value of property {@link #getColor color}.
					/// 
					/// Overrides the color derived from the <code>type</code> property. This property will work only with full hex color with pound symbol, e.g.: #FF0000.
					/// </summary>
					/// <returns>Value of property <code>color</code></returns>
					public extern virtual sap.ui.core.CSSColor getColor();

					/// <summary>
					/// Sets a new value for property {@link #getColor color}.
					/// 
					/// Overrides the color derived from the <code>type</code> property. This property will work only with full hex color with pound symbol, e.g.: #FF0000.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sColor">New value for property <code>color</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.CalendarAppointment setColor(sap.ui.core.CSSColor sColor);

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.unified.CalendarAppointment with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.unified.DateTypeRange.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.unified.CalendarAppointment with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.unified.DateTypeRange.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.unified.CalendarAppointment with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.unified.DateTypeRange.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.unified.CalendarAppointment.
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
