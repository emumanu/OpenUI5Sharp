using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public partial class sap
	{
		public static partial class ui
		{
			public static partial class performance
			{
				[External]
				[Namespace(false)]
				[Name("sap.ui.performance.Measurement")]
				public partial class Measurement
				{
					#region Methods

					/// <summary>
					/// Gets all performance measurements where a provided filter function returns a truthy value.
					/// 
					/// If neither a filter function nor a category is provided an empty array is returned. To filter for certain properties of measurements a fnFilter can be implemented like this <code> function(oMeasurement) { return oMeasurement.duration > 50; }</code>
					/// </summary>
					/// <param name="fnFilter">a filter function that returns true if the passed measurement should be added to the result</param>
					/// <param name="bCompleted">Optional parameter to determine if either completed or incomplete measurements should be returned (both if not set or undefined)</param>
					/// <param name="aCategories">The function returns only measurements which match these specified categories</param>
					/// <returns>filtered array with measurements containing id, info and start-timestamp, end-timestamp, time, duration, categories (false if error)</returns>
					public extern virtual sap.ui.performance.Measurement.Entry[] filterMeasurements(object fnFilter, bool? bCompleted, string[] aCategories);

					/// <summary>
					/// Gets all performance measurements where a provided filter function returns a truthy value.
					/// 
					/// If neither a filter function nor a category is provided an empty array is returned. To filter for certain properties of measurements a fnFilter can be implemented like this <code> function(oMeasurement) { return oMeasurement.duration > 50; }</code>
					/// </summary>
					/// <param name="fnFilter">a filter function that returns true if the passed measurement should be added to the result</param>
					/// <param name="bCompleted">Optional parameter to determine if either completed or incomplete measurements should be returned (both if not set or undefined)</param>
					/// <param name="aCategories">The function returns only measurements which match these specified categories</param>
					/// <returns>filtered array with measurements containing id, info and start-timestamp, end-timestamp, time, duration, categories (false if error)</returns>
					public extern virtual sap.ui.performance.Measurement.Entry[] filterMeasurements(object fnFilter, bool? bCompleted, object[] aCategories);

					/// <summary>
					/// Gets all performance measurements where a provided filter function returns a truthy value.
					/// 
					/// If neither a filter function nor a category is provided an empty array is returned. To filter for certain properties of measurements a fnFilter can be implemented like this <code> function(oMeasurement) { return oMeasurement.duration > 50; }</code>
					/// </summary>
					/// <param name="fnFilter">a filter function that returns true if the passed measurement should be added to the result</param>
					/// <param name="bCompleted">Optional parameter to determine if either completed or incomplete measurements should be returned (both if not set or undefined)</param>
					/// <returns>filtered array with measurements containing id, info and start-timestamp, end-timestamp, time, duration, categories (false if error)</returns>
					public extern virtual sap.ui.performance.Measurement.Entry[] filterMeasurements(object fnFilter, bool? bCompleted);

					/// <summary>
					/// Gets all performance measurements where a provided filter function returns a truthy value.
					/// 
					/// If neither a filter function nor a category is provided an empty array is returned. To filter for certain properties of measurements a fnFilter can be implemented like this <code> function(oMeasurement) { return oMeasurement.duration > 50; }</code>
					/// </summary>
					/// <param name="fnFilter">a filter function that returns true if the passed measurement should be added to the result</param>
					/// <returns>filtered array with measurements containing id, info and start-timestamp, end-timestamp, time, duration, categories (false if error)</returns>
					public extern virtual sap.ui.performance.Measurement.Entry[] filterMeasurements(object fnFilter);

					/// <summary>
					/// Gets all performance measurements where a provided filter function returns a truthy value.
					/// 
					/// If neither a filter function nor a category is provided an empty array is returned. To filter for certain properties of measurements a fnFilter can be implemented like this <code> function(oMeasurement) { return oMeasurement.duration > 50; }</code>
					/// </summary>
					/// <returns>filtered array with measurements containing id, info and start-timestamp, end-timestamp, time, duration, categories (false if error)</returns>
					public extern virtual sap.ui.performance.Measurement.Entry[] filterMeasurements();

					/// <summary>
					/// Gets all performance measurements where a provided filter function returns a truthy value.
					/// 
					/// If neither a filter function nor a category is provided an empty array is returned. To filter for certain properties of measurements a fnFilter can be implemented like this <code> function(oMeasurement) { return oMeasurement.duration > 50; }</code>
					/// </summary>
					/// <param name="bCompleted">Optional parameter to determine if either completed or incomplete measurements should be returned (both if not set or undefined)</param>
					/// <returns>filtered array with measurements containing id, info and start-timestamp, end-timestamp, time, duration, categories (false if error)</returns>
					public extern virtual sap.ui.performance.Measurement.Entry[] filterMeasurements(bool? bCompleted);

					/// <summary>
					/// Gets all performance measurements where a provided filter function returns a truthy value.
					/// 
					/// If neither a filter function nor a category is provided an empty array is returned. To filter for certain properties of measurements a fnFilter can be implemented like this <code> function(oMeasurement) { return oMeasurement.duration > 50; }</code>
					/// </summary>
					/// <param name="bCompleted">Optional parameter to determine if either completed or incomplete measurements should be returned (both if not set or undefined)</param>
					/// <param name="aCategories">The function returns only measurements which match these specified categories</param>
					/// <returns>filtered array with measurements containing id, info and start-timestamp, end-timestamp, time, duration, categories (false if error)</returns>
					public extern virtual sap.ui.performance.Measurement.Entry[] filterMeasurements(bool? bCompleted, string[] aCategories);

					/// <summary>
					/// Gets all performance measurements where a provided filter function returns a truthy value.
					/// 
					/// If neither a filter function nor a category is provided an empty array is returned. To filter for certain properties of measurements a fnFilter can be implemented like this <code> function(oMeasurement) { return oMeasurement.duration > 50; }</code>
					/// </summary>
					/// <param name="bCompleted">Optional parameter to determine if either completed or incomplete measurements should be returned (both if not set or undefined)</param>
					/// <param name="aCategories">The function returns only measurements which match these specified categories</param>
					/// <returns>filtered array with measurements containing id, info and start-timestamp, end-timestamp, time, duration, categories (false if error)</returns>
					public extern virtual sap.ui.performance.Measurement.Entry[] filterMeasurements(bool? bCompleted, object[] aCategories);

					/// <summary>
					/// Gets all performance measurements where a provided filter function returns a truthy value.
					/// 
					/// If neither a filter function nor a category is provided an empty array is returned. To filter for certain properties of measurements a fnFilter can be implemented like this <code> function(oMeasurement) { return oMeasurement.duration > 50; }</code>
					/// </summary>
					/// <param name="aCategories">The function returns only measurements which match these specified categories</param>
					/// <returns>filtered array with measurements containing id, info and start-timestamp, end-timestamp, time, duration, categories (false if error)</returns>
					public extern virtual sap.ui.performance.Measurement.Entry[] filterMeasurements(string[] aCategories);

					/// <summary>
					/// Gets all performance measurements where a provided filter function returns a truthy value.
					/// 
					/// If neither a filter function nor a category is provided an empty array is returned. To filter for certain properties of measurements a fnFilter can be implemented like this <code> function(oMeasurement) { return oMeasurement.duration > 50; }</code>
					/// </summary>
					/// <param name="aCategories">The function returns only measurements which match these specified categories</param>
					/// <returns>filtered array with measurements containing id, info and start-timestamp, end-timestamp, time, duration, categories (false if error)</returns>
					public extern virtual sap.ui.performance.Measurement.Entry[] filterMeasurements(object[] aCategories);

					/// <summary>
					/// Gets the current state of the performance measurement functionality.
					/// </summary>
					/// <returns>current state of the performance measurement functionality</returns>
					public extern virtual bool getActive();

					/// <summary>
					/// Gets all performance measurements.
					/// </summary>
					/// <param name="bCompleted">Whether only completed measurements should be returned, if explicitly set to false only incomplete measurements are returned</param>
					/// <returns>current array with measurements containing id, info and start-timestamp, end-timestamp, time, duration, categories</returns>
					public extern virtual sap.ui.performance.Measurement.Entry getAllMeasurements(bool bCompleted);

					/// <summary>
					/// Gets all performance measurements.
					/// </summary>
					/// <returns>current array with measurements containing id, info and start-timestamp, end-timestamp, time, duration, categories</returns>
					public extern virtual sap.ui.performance.Measurement.Entry getAllMeasurements();

					/// <summary>
					/// Gets a performance measure.
					/// </summary>
					/// <param name="sId">ID of the measurement</param>
					/// <returns>current measurement containing id, info and start-timestamp, end-timestamp, time, duration (false if error)</returns>
					public extern virtual sap.ui.performance.Measurement.Entry getMeasurement(string sId);

					/// <summary>
					/// Registers an average measurement for a given objects method.
					/// </summary>
					/// <param name="sId">the id of the measurement</param>
					/// <param name="oObject">the object of the method</param>
					/// <param name="sMethod">the name of the method</param>
					/// <param name="aCategories">An optional categories list for the measurement</param>
					/// <returns>true if the registration was successful</returns>
					public extern virtual bool registerMethod(string sId, object oObject, string sMethod, string[] aCategories);

					/// <summary>
					/// Registers an average measurement for a given objects method.
					/// </summary>
					/// <param name="sId">the id of the measurement</param>
					/// <param name="oObject">the object of the method</param>
					/// <param name="sMethod">the name of the method</param>
					/// <param name="aCategories">An optional categories list for the measurement</param>
					/// <returns>true if the registration was successful</returns>
					public extern virtual bool registerMethod(string sId, object oObject, string sMethod, object[] aCategories);

					/// <summary>
					/// Registers an average measurement for a given objects method.
					/// </summary>
					/// <param name="sId">the id of the measurement</param>
					/// <param name="oObject">the object of the method</param>
					/// <param name="sMethod">the name of the method</param>
					/// <returns>true if the registration was successful</returns>
					public extern virtual bool registerMethod(string sId, object oObject, string sMethod);

					/// <summary>
					/// Activates or deactivates the performance measure functionality.
					/// 
					/// Optionally a category or list of categories can be passed to restrict measurements to certain categories like "javascript", "require", "xmlhttprequest", "render"
					/// </summary>
					/// <param name="bOn">state of the performance measurement functionality to set</param>
					/// <param name="aCategories">An optional list of categories that should be measured</param>
					/// <returns>current state of the performance measurement functionality</returns>
					public extern virtual bool setActive(bool bOn, Union<string, string[]> aCategories);

					/// <summary>
					/// Unregisters all average measurements.
					/// </summary>
					public extern virtual void unregisterAllMethods();

					/// <summary>
					/// Unregisters an average measurement for a given objects method.
					/// </summary>
					/// <param name="sId">the id of the measurement</param>
					/// <param name="oObject">the object of the method</param>
					/// <param name="sMethod">the name of the method</param>
					/// <returns>true if the unregistration was successful</returns>
					public extern virtual bool unregisterMethod(string sId, object oObject, string sMethod);

					#endregion

				}
			}
		}
	}
}
