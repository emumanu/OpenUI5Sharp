using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public abstract partial class jQuery
	{
		public static partial class sap
		{
			/// <summary>
			/// Namespace for the jQuery performance measurement plug-in provided by SAP SE.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("jQuery.sap.measure")]
			public static partial class measure
			{
				#region Methods

				/// <summary>
				/// Adds a performance measurement with all data This is useful to add external measurements (e.g. from a backend) to the common measurement UI
				/// </summary>
				/// <param name="sId">ID of the measurement</param>
				/// <param name="sInfo">Info for the measurement</param>
				/// <param name="iStart">start timestamp</param>
				/// <param name="iEnd">end timestamp</param>
				/// <param name="iTime">time in milliseconds</param>
				/// <param name="iDuration">effective time in milliseconds</param>
				/// <param name="aCategories">An optional list of categories for the measure</param>
				/// <returns>[] current measurement containing id, info and start-timestamp, end-timestamp, time, duration, categories (false if error)</returns>
				public extern static object add(string sId, string sInfo, int iStart, int iEnd, int iTime, int iDuration, Union<string, string[]> aCategories);

				/// <summary>
				/// Adds a performance measurement with all data This is useful to add external measurements (e.g. from a backend) to the common measurement UI
				/// </summary>
				/// <param name="sId">ID of the measurement</param>
				/// <param name="sInfo">Info for the measurement</param>
				/// <param name="iStart">start timestamp</param>
				/// <param name="iEnd">end timestamp</param>
				/// <param name="iTime">time in milliseconds</param>
				/// <param name="iDuration">effective time in milliseconds</param>
				/// <returns>[] current measurement containing id, info and start-timestamp, end-timestamp, time, duration, categories (false if error)</returns>
				public extern static object add(string sId, string sInfo, int iStart, int iEnd, int iTime, int iDuration);

				/// <summary>
				/// Starts an average performance measure. The duration of this measure is an avarage of durations measured for each call. Optionally a category or list of categories can be passed to allow filtering of measurements.
				/// </summary>
				/// <param name="sId">ID of the measurement</param>
				/// <param name="sInfo">Info for the measurement</param>
				/// <param name="aCategories">An optional list of categories for the measure</param>
				/// <returns>current measurement containing id, info and start-timestamp (false if error)</returns>
				public extern static object average(string sId, string sInfo, Union<string, string[]> aCategories);

				/// <summary>
				/// Starts an average performance measure. The duration of this measure is an avarage of durations measured for each call. Optionally a category or list of categories can be passed to allow filtering of measurements.
				/// </summary>
				/// <param name="sId">ID of the measurement</param>
				/// <param name="sInfo">Info for the measurement</param>
				/// <returns>current measurement containing id, info and start-timestamp (false if error)</returns>
				public extern static object average(string sId, string sInfo);

				/// <summary>
				/// Clears all performance measurements
				/// </summary>
				public extern static void clear();

				/// <summary>
				/// Clears all interaction measurements
				/// </summary>
				public extern static void clearInteractionMeasurements();

				/// <summary>
				/// Clears all request timings safely.
				/// </summary>
				public extern static void clearRequestTimings();

				/// <summary>
				/// Ends a performance measure
				/// </summary>
				/// <param name="sId">ID of the measurement</param>
				/// <returns>current measurement containing id, info and start-timestamp, end-timestamp, time, duration (false if error)</returns>
				public extern static object end(string sId);

				/// <summary>
				/// End an interaction measurements
				/// </summary>
				/// <param name="bForce">forces end of interaction now and ignores further re-renderings</param>
				public extern static void endInteraction(bool bForce);

				/// <summary>
				/// Gets all interaction measurements for which a provided filter function returns a truthy value. To filter for certain categories of measurements a fnFilter can be implemented like this <code> function(InteractionMeasurement) { return InteractionMeasurement.duration > 0 }</code>
				/// </summary>
				/// <param name="fnFilter">a filter function that returns true if the passed measurement should be added to the result</param>
				/// <returns>all interaction measurements passing the filter function successfully</returns>
				public extern static object[] filterInteractionMeasurements(object fnFilter);

				/// <summary>
				/// Gets all performance measurements where a provided filter function returns a truthy value. If neither a filter function nor a category is provided an empty array is returned. To filter for certain properties of measurements a fnFilter can be implemented like this <code> function(oMeasurement) { return oMeasurement.duration > 50; }</code>
				/// </summary>
				/// <param name="fnFilter">a filter function that returns true if the passed measurement should be added to the result</param>
				/// <param name="bCompleted">Optional parameter to determine if either completed or incomplete measurements should be returned (both if not set or undefined)</param>
				/// <param name="aCategories">The function returns only measurements which match these specified categories</param>
				/// <returns>[] filtered array with measurements containing id, info and start-timestamp, end-timestamp, time, duration, categories (false if error)</returns>
				public extern static object filterMeasurements(object fnFilter, bool? bCompleted, string[] aCategories);

				/// <summary>
				/// Gets all performance measurements where a provided filter function returns a truthy value. If neither a filter function nor a category is provided an empty array is returned. To filter for certain properties of measurements a fnFilter can be implemented like this <code> function(oMeasurement) { return oMeasurement.duration > 50; }</code>
				/// </summary>
				/// <param name="fnFilter">a filter function that returns true if the passed measurement should be added to the result</param>
				/// <param name="bCompleted">Optional parameter to determine if either completed or incomplete measurements should be returned (both if not set or undefined)</param>
				/// <param name="aCategories">The function returns only measurements which match these specified categories</param>
				/// <returns>[] filtered array with measurements containing id, info and start-timestamp, end-timestamp, time, duration, categories (false if error)</returns>
				public extern static object filterMeasurements(object fnFilter, bool? bCompleted, object[] aCategories);

				/// <summary>
				/// Gets all performance measurements where a provided filter function returns a truthy value. If neither a filter function nor a category is provided an empty array is returned. To filter for certain properties of measurements a fnFilter can be implemented like this <code> function(oMeasurement) { return oMeasurement.duration > 50; }</code>
				/// </summary>
				/// <param name="fnFilter">a filter function that returns true if the passed measurement should be added to the result</param>
				/// <param name="bCompleted">Optional parameter to determine if either completed or incomplete measurements should be returned (both if not set or undefined)</param>
				/// <returns>[] filtered array with measurements containing id, info and start-timestamp, end-timestamp, time, duration, categories (false if error)</returns>
				public extern static object filterMeasurements(object fnFilter, bool? bCompleted);

				/// <summary>
				/// Gets all performance measurements where a provided filter function returns a truthy value. If neither a filter function nor a category is provided an empty array is returned. To filter for certain properties of measurements a fnFilter can be implemented like this <code> function(oMeasurement) { return oMeasurement.duration > 50; }</code>
				/// </summary>
				/// <param name="fnFilter">a filter function that returns true if the passed measurement should be added to the result</param>
				/// <returns>[] filtered array with measurements containing id, info and start-timestamp, end-timestamp, time, duration, categories (false if error)</returns>
				public extern static object filterMeasurements(object fnFilter);

				/// <summary>
				/// Gets all performance measurements where a provided filter function returns a truthy value. If neither a filter function nor a category is provided an empty array is returned. To filter for certain properties of measurements a fnFilter can be implemented like this <code> function(oMeasurement) { return oMeasurement.duration > 50; }</code>
				/// </summary>
				/// <returns>[] filtered array with measurements containing id, info and start-timestamp, end-timestamp, time, duration, categories (false if error)</returns>
				public extern static object filterMeasurements();

				/// <summary>
				/// Gets all performance measurements where a provided filter function returns a truthy value. If neither a filter function nor a category is provided an empty array is returned. To filter for certain properties of measurements a fnFilter can be implemented like this <code> function(oMeasurement) { return oMeasurement.duration > 50; }</code>
				/// </summary>
				/// <param name="bCompleted">Optional parameter to determine if either completed or incomplete measurements should be returned (both if not set or undefined)</param>
				/// <returns>[] filtered array with measurements containing id, info and start-timestamp, end-timestamp, time, duration, categories (false if error)</returns>
				public extern static object filterMeasurements(bool? bCompleted);

				/// <summary>
				/// Gets all performance measurements where a provided filter function returns a truthy value. If neither a filter function nor a category is provided an empty array is returned. To filter for certain properties of measurements a fnFilter can be implemented like this <code> function(oMeasurement) { return oMeasurement.duration > 50; }</code>
				/// </summary>
				/// <param name="bCompleted">Optional parameter to determine if either completed or incomplete measurements should be returned (both if not set or undefined)</param>
				/// <param name="aCategories">The function returns only measurements which match these specified categories</param>
				/// <returns>[] filtered array with measurements containing id, info and start-timestamp, end-timestamp, time, duration, categories (false if error)</returns>
				public extern static object filterMeasurements(bool? bCompleted, string[] aCategories);

				/// <summary>
				/// Gets all performance measurements where a provided filter function returns a truthy value. If neither a filter function nor a category is provided an empty array is returned. To filter for certain properties of measurements a fnFilter can be implemented like this <code> function(oMeasurement) { return oMeasurement.duration > 50; }</code>
				/// </summary>
				/// <param name="bCompleted">Optional parameter to determine if either completed or incomplete measurements should be returned (both if not set or undefined)</param>
				/// <param name="aCategories">The function returns only measurements which match these specified categories</param>
				/// <returns>[] filtered array with measurements containing id, info and start-timestamp, end-timestamp, time, duration, categories (false if error)</returns>
				public extern static object filterMeasurements(bool? bCompleted, object[] aCategories);

				/// <summary>
				/// Gets all performance measurements where a provided filter function returns a truthy value. If neither a filter function nor a category is provided an empty array is returned. To filter for certain properties of measurements a fnFilter can be implemented like this <code> function(oMeasurement) { return oMeasurement.duration > 50; }</code>
				/// </summary>
				/// <param name="aCategories">The function returns only measurements which match these specified categories</param>
				/// <returns>[] filtered array with measurements containing id, info and start-timestamp, end-timestamp, time, duration, categories (false if error)</returns>
				public extern static object filterMeasurements(string[] aCategories);

				/// <summary>
				/// Gets all performance measurements where a provided filter function returns a truthy value. If neither a filter function nor a category is provided an empty array is returned. To filter for certain properties of measurements a fnFilter can be implemented like this <code> function(oMeasurement) { return oMeasurement.duration > 50; }</code>
				/// </summary>
				/// <param name="aCategories">The function returns only measurements which match these specified categories</param>
				/// <returns>[] filtered array with measurements containing id, info and start-timestamp, end-timestamp, time, duration, categories (false if error)</returns>
				public extern static object filterMeasurements(object[] aCategories);

				/// <summary>
				/// Gets the current state of the performance measurement functionality
				/// </summary>
				/// <returns>current state of the performance measurement functionality</returns>
				public extern static bool getActive();

				/// <summary>
				/// Gets all interaction measurements
				/// </summary>
				/// <param name="bFinalize">finalize the current pending interaction so that it is contained in the returned array</param>
				/// <returns>all interaction measurements</returns>
				public extern static object[] getAllInteractionMeasurements(bool bFinalize);

				/// <summary>
				/// Gets all performance measurements
				/// </summary>
				/// <param name="bCompleted">Whether only completed measurements should be returned, if explicitly set to false only incomplete measurements are returned</param>
				/// <returns>current array with measurements containing id, info and start-timestamp, end-timestamp, time, duration, categories</returns>
				public extern static object[] getAllMeasurements(bool bCompleted);

				/// <summary>
				/// Gets all performance measurements
				/// </summary>
				/// <returns>current array with measurements containing id, info and start-timestamp, end-timestamp, time, duration, categories</returns>
				public extern static object[] getAllMeasurements();

				/// <summary>
				/// Gets a performance measure
				/// </summary>
				/// <param name="sId">ID of the measurement</param>
				/// <returns>current measurement containing id, info and start-timestamp, end-timestamp, time, duration (false if error)</returns>
				public extern static object getMeasurement(string sId);

				/// <summary>
				/// Gets the current request timings array for type 'resource' safely
				/// </summary>
				/// <returns>array of performance timing objects</returns>
				public extern static object[] getRequestTimings();

				/// <summary>
				/// Pauses a performance measure
				/// </summary>
				/// <param name="sId">ID of the measurement</param>
				/// <returns>current measurement containing id, info and start-timestamp, pause-timestamp (false if error)</returns>
				public extern static object pause(string sId);

				/// <summary>
				/// Registers an average measurement for a given objects method
				/// </summary>
				/// <param name="sId">the id of the measurement</param>
				/// <param name="oObject">the object of the method</param>
				/// <param name="sMethod">the name of the method</param>
				/// <param name="aCategories">An optional categories list for the measurement</param>
				/// <returns>true if the registration was successful</returns>
				public extern static bool registerMethod(string sId, object oObject, string sMethod, string[] aCategories);

				/// <summary>
				/// Registers an average measurement for a given objects method
				/// </summary>
				/// <param name="sId">the id of the measurement</param>
				/// <param name="oObject">the object of the method</param>
				/// <param name="sMethod">the name of the method</param>
				/// <param name="aCategories">An optional categories list for the measurement</param>
				/// <returns>true if the registration was successful</returns>
				public extern static bool registerMethod(string sId, object oObject, string sMethod, object[] aCategories);

				/// <summary>
				/// Registers an average measurement for a given objects method
				/// </summary>
				/// <param name="sId">the id of the measurement</param>
				/// <param name="oObject">the object of the method</param>
				/// <param name="sMethod">the name of the method</param>
				/// <returns>true if the registration was successful</returns>
				public extern static bool registerMethod(string sId, object oObject, string sMethod);

				/// <summary>
				/// Removes a performance measure
				/// </summary>
				/// <param name="sId">ID of the measurement</param>
				public extern static void remove(string sId);

				/// <summary>
				/// Resumes a performance measure
				/// </summary>
				/// <param name="sId">ID of the measurement</param>
				/// <returns>current measurement containing id, info and start-timestamp, resume-timestamp (false if error)</returns>
				public extern static object resume(string sId);

				/// <summary>
				/// Activates or deactivates the performance measure functionality Optionally a category or list of categories can be passed to restrict measurements to certain categories like "javascript", "require", "xmlhttprequest", "render"
				/// </summary>
				/// <param name="bOn">state of the performance measurement functionality to set</param>
				/// <param name="aCategories">An optional list of categories that should be measured</param>
				/// <returns>current state of the performance measurement functionality</returns>
				public extern static bool setActive(bool bOn, Union<string, string[]> aCategories);

				/// <summary>
				/// Sets the request buffer size for the measurement safely.
				/// </summary>
				/// <param name="iSize">size of the buffer</param>
				public extern static void setRequestBufferSize(int iSize);

				/// <summary>
				/// Starts a performance measure. Optionally a category or list of categories can be passed to allow filtering of measurements.
				/// </summary>
				/// <param name="sId">ID of the measurement</param>
				/// <param name="sInfo">Info for the measurement</param>
				/// <param name="aCategories">An optional list of categories for the measure</param>
				/// <returns>current measurement containing id, info and start-timestamp (false if error)</returns>
				public extern static object start(string sId, string sInfo, Union<string, string[]> aCategories);

				/// <summary>
				/// Starts a performance measure. Optionally a category or list of categories can be passed to allow filtering of measurements.
				/// </summary>
				/// <param name="sId">ID of the measurement</param>
				/// <param name="sInfo">Info for the measurement</param>
				/// <returns>current measurement containing id, info and start-timestamp (false if error)</returns>
				public extern static object start(string sId, string sInfo);

				/// <summary>
				/// Start an interaction measurements
				/// </summary>
				/// <param name="sType">type of the event which triggered the interaction</param>
				/// <param name="oSrcElement">the control on which the interaction was triggered</param>
				public extern static void startInteraction(string sType, object oSrcElement);

				/// <summary>
				/// Unregisters all average measurements
				/// </summary>
				public extern static void unregisterAllMethods();

				/// <summary>
				/// Unregisters an average measurement for a given objects method
				/// </summary>
				/// <param name="sId">the id of the measurement</param>
				/// <param name="oObject">the object of the method</param>
				/// <param name="sMethod">the name of the method</param>
				/// <returns>true if the unregistration was successful</returns>
				public extern static bool unregisterMethod(string sId, object oObject, string sMethod);

				#endregion

			}
		}
	}
}
