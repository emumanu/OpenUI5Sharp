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
				/// Date range for use in DatePicker
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.unified.DateRange")]
				public partial class DateRange : sap.ui.core.Element
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
						/// Start date for a date range. This must be a JavaScript date object.
						/// </summary>
						public Union<object, string, sap.ui.@base.ManagedObject.BindPropertyInfo> startDate;

						/// <summary>
						/// End date for a date range. If empty only a single date is presented by this DateRange element. This must be a JavaScript date object.
						/// </summary>
						public Union<object, string, sap.ui.@base.ManagedObject.BindPropertyInfo> endDate;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new DateRange.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern DateRange(string sId, sap.ui.unified.DateRange.Settings mSettings);

					/// <summary>
					/// Constructor for a new DateRange.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern DateRange(string sId);

					/// <summary>
					/// Constructor for a new DateRange.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern DateRange();

					/// <summary>
					/// Constructor for a new DateRange.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern DateRange(sap.ui.unified.DateRange.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property startDate

					/// <summary>
					/// Gets current value of property {@link #getStartDate startDate}.
					/// 
					/// Start date for a date range. This must be a JavaScript date object.
					/// </summary>
					/// <returns>Value of property <code>startDate</code></returns>
					public extern virtual object getStartDate();

					/// <summary>
					/// Sets a new value for property {@link #getStartDate startDate}.
					/// 
					/// Start date for a date range. This must be a JavaScript date object.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="oStartDate">New value for property <code>startDate</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.DateRange setStartDate(object oStartDate);

					#endregion

					#region Methods for Property endDate

					/// <summary>
					/// Gets current value of property {@link #getEndDate endDate}.
					/// 
					/// End date for a date range. If empty only a single date is presented by this DateRange element. This must be a JavaScript date object.
					/// </summary>
					/// <returns>Value of property <code>endDate</code></returns>
					public extern virtual object getEndDate();

					/// <summary>
					/// Sets a new value for property {@link #getEndDate endDate}.
					/// 
					/// End date for a date range. If empty only a single date is presented by this DateRange element. This must be a JavaScript date object.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="oEndDate">New value for property <code>endDate</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.DateRange setEndDate(object oEndDate);

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.unified.DateRange with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.unified.DateRange with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.unified.DateRange with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.unified.DateRange.
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
