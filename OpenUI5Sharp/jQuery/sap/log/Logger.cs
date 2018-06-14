using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace OpenUI5Sharp
{
	public partial class jQuery
	{
		public static partial class sap
		{
			public static partial class log
			{
				/// <summary>
				/// A Logger class
				/// </summary>
				[External]
				[Namespace(false)]
				public partial class Logger
				{
					#region Constructor

					/// <summary>
					/// Creates a new Logger instance which will use the given component string for all logged messages without a specific component.
					/// </summary>
					/// <param name="sDefaultComponent">The component to use</param>
					public extern Logger(string sDefaultComponent);

					#endregion

					#region Methods

					/// <summary>
					/// Creates a new debug-level entry in the log with the given message, details and calling component.
					/// </summary>
					/// <param name="sMessage">Message text to display</param>
					/// <param name="sDetails">Details about the message, might be omitted</param>
					/// <param name="sComponent">Name of the component that produced the log entry</param>
					/// <param name="fnSupportInfo">Callback that returns an additional support object to be logged in support mode. This function is only called if support info mode is turned on with <code>logSupportInfo(true)</code>. To avoid negative effects regarding execution times and memory consumption, the returned object should be a simple immutable JSON object with mostly static and stable content.</param>
					/// <returns>The log instance</returns>
					public extern virtual jQuery.sap.log.Logger debug(string sMessage, string sDetails, string sComponent, object fnSupportInfo);

					/// <summary>
					/// Creates a new debug-level entry in the log with the given message, details and calling component.
					/// </summary>
					/// <param name="sMessage">Message text to display</param>
					/// <param name="sDetails">Details about the message, might be omitted</param>
					/// <param name="sComponent">Name of the component that produced the log entry</param>
					/// <returns>The log instance</returns>
					public extern virtual jQuery.sap.log.Logger debug(string sMessage, string sDetails = "", string sComponent = "");

					/// <summary>
					/// Creates a new error-level entry in the log with the given message, details and calling component.
					/// </summary>
					/// <param name="sMessage">Message text to display</param>
					/// <param name="sDetails">Details about the message, might be omitted</param>
					/// <param name="sComponent">Name of the component that produced the log entry</param>
					/// <param name="fnSupportInfo">Callback that returns an additional support object to be logged in support mode. This function is only called if support info mode is turned on with <code>logSupportInfo(true)</code>. To avoid negative effects regarding execution times and memory consumption, the returned object should be a simple immutable JSON object with mostly static and stable content.</param>
					/// <returns>The log instance</returns>
					public extern virtual jQuery.sap.log.Logger error(string sMessage, string sDetails, string sComponent, object fnSupportInfo);

					/// <summary>
					/// Creates a new error-level entry in the log with the given message, details and calling component.
					/// </summary>
					/// <param name="sMessage">Message text to display</param>
					/// <param name="sDetails">Details about the message, might be omitted</param>
					/// <param name="sComponent">Name of the component that produced the log entry</param>
					/// <returns>The log instance</returns>
					public extern virtual jQuery.sap.log.Logger error(string sMessage, string sDetails = "", string sComponent = "");

					/// <summary>
					/// Creates a new fatal-level entry in the log with the given message, details and calling component.
					/// </summary>
					/// <param name="sMessage">Message text to display</param>
					/// <param name="sDetails">Details about the message, might be omitted</param>
					/// <param name="sComponent">Name of the component that produced the log entry</param>
					/// <param name="fnSupportInfo">Callback that returns an additional support object to be logged in support mode. This function is only called if support info mode is turned on with <code>logSupportInfo(true)</code>. To avoid negative effects regarding execution times and memory consumption, the returned object should be a simple immutable JSON object with mostly static and stable content.</param>
					/// <returns>The log instance for method chaining</returns>
					public extern virtual jQuery.sap.log.Logger fatal(string sMessage, string sDetails, string sComponent, object fnSupportInfo);

					/// <summary>
					/// Creates a new fatal-level entry in the log with the given message, details and calling component.
					/// </summary>
					/// <param name="sMessage">Message text to display</param>
					/// <param name="sDetails">Details about the message, might be omitted</param>
					/// <param name="sComponent">Name of the component that produced the log entry</param>
					/// <returns>The log instance for method chaining</returns>
					public extern virtual jQuery.sap.log.Logger fatal(string sMessage, string sDetails = "", string sComponent = "");

					/// <summary>
					/// Returns the log level currently effective for the given component. If no component is given or when no level has been configured for a given component, the log level for the default component of this logger is returned.
					/// </summary>
					/// <param name="sComponent">Name of the component to retrieve the log level for</param>
					/// <returns>The log level for the given component or the default log level</returns>
					public extern virtual int getLevel(string sComponent);

					/// <summary>
					/// Returns the log level currently effective for the given component. If no component is given or when no level has been configured for a given component, the log level for the default component of this logger is returned.
					/// </summary>
					/// <returns>The log level for the given component or the default log level</returns>
					public extern virtual int getLevel();

					/// <summary>
					/// Creates a new info-level entry in the log with the given message, details and calling component.
					/// </summary>
					/// <param name="sMessage">Message text to display</param>
					/// <param name="sDetails">Details about the message, might be omitted</param>
					/// <param name="sComponent">Name of the component that produced the log entry</param>
					/// <param name="fnSupportInfo">Callback that returns an additional support object to be logged in support mode. This function is only called if support info mode is turned on with <code>logSupportInfo(true)</code>. To avoid negative effects regarding execution times and memory consumption, the returned object should be a simple immutable JSON object with mostly static and stable content.</param>
					/// <returns>The log instance</returns>
					public extern virtual jQuery.sap.log.Logger info(string sMessage, string sDetails, string sComponent, object fnSupportInfo);

					/// <summary>
					/// Creates a new info-level entry in the log with the given message, details and calling component.
					/// </summary>
					/// <param name="sMessage">Message text to display</param>
					/// <param name="sDetails">Details about the message, might be omitted</param>
					/// <param name="sComponent">Name of the component that produced the log entry</param>
					/// <returns>The log instance</returns>
					public extern virtual jQuery.sap.log.Logger info(string sMessage, string sDetails = "", string sComponent = "");

					/// <summary>
					/// Checks whether logging is enabled for the given log level, depending on the currently effective log level for the given component.
					/// 
					/// If no component is given, the default component of this logger will be taken into account.
					/// </summary>
					/// <param name="iLevel">The log level in question</param>
					/// <param name="sComponent">Name of the component to check the log level for</param>
					/// <returns>Whether logging is enabled or not</returns>
					public extern virtual bool isLoggable(int iLevel, string sComponent);

					/// <summary>
					/// Checks whether logging is enabled for the given log level, depending on the currently effective log level for the given component.
					/// 
					/// If no component is given, the default component of this logger will be taken into account.
					/// </summary>
					/// <param name="iLevel">The log level in question</param>
					/// <returns>Whether logging is enabled or not</returns>
					public extern virtual bool isLoggable(int iLevel);

					/// <summary>
					/// Checks whether logging is enabled for the given log level, depending on the currently effective log level for the given component.
					/// 
					/// If no component is given, the default component of this logger will be taken into account.
					/// </summary>
					/// <returns>Whether logging is enabled or not</returns>
					public extern virtual bool isLoggable();

					/// <summary>
					/// Checks whether logging is enabled for the given log level, depending on the currently effective log level for the given component.
					/// 
					/// If no component is given, the default component of this logger will be taken into account.
					/// </summary>
					/// <param name="sComponent">Name of the component to check the log level for</param>
					/// <returns>Whether logging is enabled or not</returns>
					public extern virtual bool isLoggable(string sComponent);

					/// <summary>
					/// Defines the maximum <code>jQuery.sap.log.Level</code> of log entries that will be recorded. Log entries with a higher (less important) log level will be omitted from the log. When a component name is given, the log level will be configured for that component only, otherwise the log level for the default component of this logger is set. For the global logger, the global default level is set.
					/// 
					/// <b>Note</b>: Setting a global default log level has no impact on already defined component log levels. They always override the global default log level.
					/// </summary>
					/// <param name="iLogLevel">The new log level</param>
					/// <param name="sComponent">The log component to set the log level for</param>
					/// <returns>This logger object to allow method chaining</returns>
					public extern virtual jQuery.sap.log.Logger setLevel(jQuery.sap.log.Level iLogLevel, string sComponent);

					/// <summary>
					/// Defines the maximum <code>jQuery.sap.log.Level</code> of log entries that will be recorded. Log entries with a higher (less important) log level will be omitted from the log. When a component name is given, the log level will be configured for that component only, otherwise the log level for the default component of this logger is set. For the global logger, the global default level is set.
					/// 
					/// <b>Note</b>: Setting a global default log level has no impact on already defined component log levels. They always override the global default log level.
					/// </summary>
					/// <param name="iLogLevel">The new log level</param>
					/// <returns>This logger object to allow method chaining</returns>
					public extern virtual jQuery.sap.log.Logger setLevel(jQuery.sap.log.Level iLogLevel);

					/// <summary>
					/// Creates a new trace-level entry in the log with the given message, details and calling component.
					/// </summary>
					/// <param name="sMessage">Message text to display</param>
					/// <param name="sDetails">Details about the message, might be omitted</param>
					/// <param name="sComponent">Name of the component that produced the log entry</param>
					/// <param name="fnSupportInfo">Callback that returns an additional support object to be logged in support mode. This function is only called if support info mode is turned on with <code>logSupportInfo(true)</code>. To avoid negative effects regarding execution times and memory consumption, the returned object should be a simple immutable JSON object with mostly static and stable content.</param>
					/// <returns>The log-instance</returns>
					public extern virtual jQuery.sap.log.Logger trace(string sMessage, string sDetails, string sComponent, object fnSupportInfo);

					/// <summary>
					/// Creates a new trace-level entry in the log with the given message, details and calling component.
					/// </summary>
					/// <param name="sMessage">Message text to display</param>
					/// <param name="sDetails">Details about the message, might be omitted</param>
					/// <param name="sComponent">Name of the component that produced the log entry</param>
					/// <returns>The log-instance</returns>
					public extern virtual jQuery.sap.log.Logger trace(string sMessage, string sDetails = "", string sComponent = "");

					/// <summary>
					/// Creates a new warning-level entry in the log with the given message, details and calling component.
					/// </summary>
					/// <param name="sMessage">Message text to display</param>
					/// <param name="sDetails">Details about the message, might be omitted</param>
					/// <param name="sComponent">Name of the component that produced the log entry</param>
					/// <param name="fnSupportInfo">Callback that returns an additional support object to be logged in support mode. This function is only called if support info mode is turned on with <code>logSupportInfo(true)</code>. To avoid negative effects regarding execution times and memory consumption, the returned object should be a simple immutable JSON object with mostly static and stable content.</param>
					/// <returns>The log instance</returns>
					public extern virtual jQuery.sap.log.Logger warning(string sMessage, string sDetails, string sComponent, object fnSupportInfo);

					/// <summary>
					/// Creates a new warning-level entry in the log with the given message, details and calling component.
					/// </summary>
					/// <param name="sMessage">Message text to display</param>
					/// <param name="sDetails">Details about the message, might be omitted</param>
					/// <param name="sComponent">Name of the component that produced the log entry</param>
					/// <returns>The log instance</returns>
					public extern virtual jQuery.sap.log.Logger warning(string sMessage, string sDetails = "", string sComponent = "");

					#endregion

				}
			}
		}
	}
}
