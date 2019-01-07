using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public partial class sap
	{
		public static partial class @base
		{
			/// <summary>
			/// A Logging API for JavaScript.
			/// 
			/// Provides methods to manage a client-side log and to create entries in it. Each of the logging methods {@link module:sap/base/Log.debug}, {@link module:sap/base/Log.info}, {@link module:sap/base/Log.warning}, {@link module:sap/base/Log.error} and {@link module:sap/base/Log.fatal} creates and records a log entry, containing a timestamp, a log level, a message with details and a component info. The log level will be one of {@link module:sap/base/Log.Level} and equals the name of the concrete logging method.
			/// 
			/// By using the {@link module:sap/base/Log.setLevel} method, consumers can determine the least important log level which should be recorded. Less important entries will be filtered out. (Note that higher numeric values represent less important levels). The initially set level depends on the mode that UI5 is running in. When the optimized sources are executed, the default level will be {@link module:sap/base/Log.Level.ERROR}. For normal (debug sources), the default level is {@link module:sap/base/Log.Level.DEBUG}.
			/// 
			/// All logging methods allow to specify a <b>component</b>. These components are simple strings and don't have a special meaning to the UI5 framework. However they can be used to semantically group log entries that belong to the same software component (or feature). There are two APIs that help to manage logging for such a component. With {@link module:sap/base/Log.getLogger}, one can retrieve a logger that automatically adds the given <code>sComponent</code> as component parameter to each log entry, if no other component is specified. Typically, JavaScript code will retrieve such a logger once during startup and reuse it for the rest of its lifecycle. Second, the {@link module:sap/base/Log.Logger#setLevel}(iLevel, sComponent) method allows to set the log level for a specific component only. This allows a more fine granular control about the created logging entries. {@link module:sap/base/Log.Logger#getLevel} allows to retrieve the currently effective log level for a given component.
			/// 
			/// {@link module:sap/base/Log.getLogEntries} returns an array of the currently collected log entries.
			/// 
			/// Furthermore, a listener can be registered to the log. It will be notified whenever a new entry is added to the log. The listener can be used for displaying log entries in a separate page area, or for sending it to some external target (server).
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.base.Log")]
			public partial class Log
			{
				#region Methods

				/// <summary>
				/// Allows to add a new LogListener that will be notified for new log entries.
				/// 
				/// The given object must provide method <code>onLogEntry</code> and can also be informed about <code>onDetachFromLog</code> and <code>onAttachToLog</code>
				/// </summary>
				/// <param name="oListener">The new listener object that should be informed</param>
				public extern static void addLogListener(object oListener);

				/// <summary>
				/// Creates a new debug-level entry in the log with the given message, details and calling component.
				/// </summary>
				/// <param name="sMessage">Message text to display</param>
				/// <param name="sDetails">Details about the message, might be omitted</param>
				/// <param name="sComponent">Name of the component that produced the log entry</param>
				/// <param name="fnSupportInfo">Callback that returns an additional support object to be logged in support mode. This function is only called if support info mode is turned on with <code>logSupportInfo(true)</code>. To avoid negative effects regarding execution times and memory consumption, the returned object should be a simple immutable JSON object with mostly static and stable content.</param>
				public extern static void debug(string sMessage, string sDetails, string sComponent, object fnSupportInfo);

				/// <summary>
				/// Creates a new debug-level entry in the log with the given message, details and calling component.
				/// </summary>
				/// <param name="sMessage">Message text to display</param>
				/// <param name="sDetails">Details about the message, might be omitted</param>
				/// <param name="sComponent">Name of the component that produced the log entry</param>
				public extern static void debug(string sMessage, string sDetails = "", string sComponent = "");

				/// <summary>
				/// Creates a new error-level entry in the log with the given message, details and calling component.
				/// </summary>
				/// <param name="sMessage">Message text to display</param>
				/// <param name="sDetails">Details about the message, might be omitted</param>
				/// <param name="sComponent">Name of the component that produced the log entry</param>
				/// <param name="fnSupportInfo">Callback that returns an additional support object to be logged in support mode. This function is only called if support info mode is turned on with <code>logSupportInfo(true)</code>. To avoid negative effects regarding execution times and memory consumption, the returned object should be a simple immutable JSON object with mostly static and stable content.</param>
				public extern static void error(string sMessage, string sDetails, string sComponent, object fnSupportInfo);

				/// <summary>
				/// Creates a new error-level entry in the log with the given message, details and calling component.
				/// </summary>
				/// <param name="sMessage">Message text to display</param>
				/// <param name="sDetails">Details about the message, might be omitted</param>
				/// <param name="sComponent">Name of the component that produced the log entry</param>
				public extern static void error(string sMessage, string sDetails = "", string sComponent = "");

				/// <summary>
				/// Creates a new fatal-level entry in the log with the given message, details and calling component.
				/// </summary>
				/// <param name="sMessage">Message text to display</param>
				/// <param name="sDetails">Details about the message, might be omitted</param>
				/// <param name="sComponent">Name of the component that produced the log entry</param>
				/// <param name="fnSupportInfo">Callback that returns an additional support object to be logged in support mode. This function is only called if support info mode is turned on with <code>logSupportInfo(true)</code>. To avoid negative effects regarding execution times and memory consumption, the returned object should be a simple immutable JSON object with mostly static and stable content.</param>
				public extern static void fatal(string sMessage, string sDetails, string sComponent, object fnSupportInfo);

				/// <summary>
				/// Creates a new fatal-level entry in the log with the given message, details and calling component.
				/// </summary>
				/// <param name="sMessage">Message text to display</param>
				/// <param name="sDetails">Details about the message, might be omitted</param>
				/// <param name="sComponent">Name of the component that produced the log entry</param>
				public extern static void fatal(string sMessage, string sDetails = "", string sComponent = "");

				/// <summary>
				/// Returns the log level currently effective for the given component. If no component is given or when no level has been configured for a given component, the log level for the default component of this logger is returned.
				/// </summary>
				/// <param name="sComponent">Name of the component to retrieve the log level for</param>
				/// <returns>The log level for the given component or the default log level</returns>
				public extern static sap.@base.Log.Level getLevel(string sComponent);

				/// <summary>
				/// Returns the log level currently effective for the given component. If no component is given or when no level has been configured for a given component, the log level for the default component of this logger is returned.
				/// </summary>
				/// <returns>The log level for the given component or the default log level</returns>
				public extern static sap.@base.Log.Level getLevel();

				/// <summary>
				/// Returns the logged entries recorded so far as an array.
				/// 
				/// Log entries are plain JavaScript objects with the following properties <ul> <li>timestamp {number} point in time when the entry was created <li>level {module:sap/base/Log.Level} LogLevel level of the entry <li>message {string} message text of the entry </ul>
				/// </summary>
				/// <returns>an array containing the recorded log entries</returns>
				public extern static object[] getLogEntries();

				/// <summary>
				/// Returns a dedicated logger for a component
				/// 
				/// The logger comes with the same API as the Logger module: <ul> <li><code>#fatal</code> - see: {@link sap/base/Log.fatal} <li><code>#error</code> - see: {@link sap/base/Log.error} <li><code>#warning</code> - see: {@link sap/base/Log.warning} <li><code>#info</code> - see: {@link sap/base/Log.info} <li><code>#debug</code> - see: {@link sap/base/Log.debug} <li><code>#trace</code> - see: {@link sap/base/Log.trace} <li><code>#setLevel</code> - see: {@link sap/base/Log.setLevel} <li><code>#getLevel</code> - see: {@link sap/base/Log.getLevel} <li><code>#isLoggable</code> - see: {@link sap/base/Log.isLoggable} </ul>
				/// </summary>
				/// <param name="sComponent">Name of the component which should be logged</param>
				/// <param name="iLogLevel">The default log level</param>
				/// <returns>A logger with a specified component</returns>
				public extern static object getLogger(string sComponent, sap.@base.Log.Level iLogLevel);

				/// <summary>
				/// Returns a dedicated logger for a component
				/// 
				/// The logger comes with the same API as the Logger module: <ul> <li><code>#fatal</code> - see: {@link sap/base/Log.fatal} <li><code>#error</code> - see: {@link sap/base/Log.error} <li><code>#warning</code> - see: {@link sap/base/Log.warning} <li><code>#info</code> - see: {@link sap/base/Log.info} <li><code>#debug</code> - see: {@link sap/base/Log.debug} <li><code>#trace</code> - see: {@link sap/base/Log.trace} <li><code>#setLevel</code> - see: {@link sap/base/Log.setLevel} <li><code>#getLevel</code> - see: {@link sap/base/Log.getLevel} <li><code>#isLoggable</code> - see: {@link sap/base/Log.isLoggable} </ul>
				/// </summary>
				/// <param name="sComponent">Name of the component which should be logged</param>
				/// <returns>A logger with a specified component</returns>
				public extern static object getLogger(string sComponent);

				/// <summary>
				/// Creates a new info-level entry in the log with the given message, details and calling component.
				/// </summary>
				/// <param name="sMessage">Message text to display</param>
				/// <param name="sDetails">Details about the message, might be omitted</param>
				/// <param name="sComponent">Name of the component that produced the log entry</param>
				/// <param name="fnSupportInfo">Callback that returns an additional support object to be logged in support mode. This function is only called if support info mode is turned on with <code>logSupportInfo(true)</code>. To avoid negative effects regarding execution times and memory consumption, the returned object should be a simple immutable JSON object with mostly static and stable content.</param>
				public extern static void info(string sMessage, string sDetails, string sComponent, object fnSupportInfo);

				/// <summary>
				/// Creates a new info-level entry in the log with the given message, details and calling component.
				/// </summary>
				/// <param name="sMessage">Message text to display</param>
				/// <param name="sDetails">Details about the message, might be omitted</param>
				/// <param name="sComponent">Name of the component that produced the log entry</param>
				public extern static void info(string sMessage, string sDetails = "", string sComponent = "");

				/// <summary>
				/// Checks whether logging is enabled for the given log level, depending on the currently effective log level for the given component.
				/// 
				/// If no component is given, the default component of this logger will be taken into account.
				/// </summary>
				/// <param name="iLevel">The log level in question</param>
				/// <param name="sComponent">Name of the component to check the log level for</param>
				/// <returns>Whether logging is enabled or not</returns>
				public extern static bool isLoggable(sap.@base.Log.Level iLevel, string sComponent);

				/// <summary>
				/// Checks whether logging is enabled for the given log level, depending on the currently effective log level for the given component.
				/// 
				/// If no component is given, the default component of this logger will be taken into account.
				/// </summary>
				/// <param name="iLevel">The log level in question</param>
				/// <returns>Whether logging is enabled or not</returns>
				public extern static bool isLoggable(sap.@base.Log.Level iLevel);

				/// <summary>
				/// Checks whether logging is enabled for the given log level, depending on the currently effective log level for the given component.
				/// 
				/// If no component is given, the default component of this logger will be taken into account.
				/// </summary>
				/// <returns>Whether logging is enabled or not</returns>
				public extern static bool isLoggable();

				/// <summary>
				/// Checks whether logging is enabled for the given log level, depending on the currently effective log level for the given component.
				/// 
				/// If no component is given, the default component of this logger will be taken into account.
				/// </summary>
				/// <param name="sComponent">Name of the component to check the log level for</param>
				/// <returns>Whether logging is enabled or not</returns>
				public extern static bool isLoggable(string sComponent);

				/// <summary>
				/// Enables or disables whether additional support information is logged in a trace. If enabled, logging methods like error, warning, info and debug are calling the additional optional callback parameter fnSupportInfo and store the returned object in the log entry property supportInfo.
				/// </summary>
				/// <param name="bEnabled">true if the support information should be logged</param>
				private extern static void logSupportInfo(bool bEnabled);

				/// <summary>
				/// Allows to remove a registered LogListener.
				/// </summary>
				/// <param name="oListener">The new listener object that should be removed</param>
				public extern static void removeLogListener(object oListener);

				/// <summary>
				/// Defines the maximum <code>sap.base.log.Level</code> of log entries that will be recorded. Log entries with a higher (less important) log level will be omitted from the log. When a component name is given, the log level will be configured for that component only, otherwise the log level for the default component of this logger is set. For the global logger, the global default level is set.
				/// 
				/// <b>Note</b>: Setting a global default log level has no impact on already defined component log levels. They always override the global default log level.
				/// </summary>
				/// <param name="iLogLevel">The new log level</param>
				/// <param name="sComponent">The log component to set the log level for</param>
				public extern static void setLevel(sap.@base.Log.Level iLogLevel, string sComponent);

				/// <summary>
				/// Defines the maximum <code>sap.base.log.Level</code> of log entries that will be recorded. Log entries with a higher (less important) log level will be omitted from the log. When a component name is given, the log level will be configured for that component only, otherwise the log level for the default component of this logger is set. For the global logger, the global default level is set.
				/// 
				/// <b>Note</b>: Setting a global default log level has no impact on already defined component log levels. They always override the global default log level.
				/// </summary>
				/// <param name="iLogLevel">The new log level</param>
				public extern static void setLevel(sap.@base.Log.Level iLogLevel);

				/// <summary>
				/// Creates a new trace-level entry in the log with the given message, details and calling component.
				/// </summary>
				/// <param name="sMessage">Message text to display</param>
				/// <param name="sDetails">Details about the message, might be omitted</param>
				/// <param name="sComponent">Name of the component that produced the log entry</param>
				/// <param name="fnSupportInfo">Callback that returns an additional support object to be logged in support mode. This function is only called if support info mode is turned on with <code>logSupportInfo(true)</code>. To avoid negative effects regarding execution times and memory consumption, the returned object should be a simple immutable JSON object with mostly static and stable content.</param>
				public extern static void trace(string sMessage, string sDetails, string sComponent, object fnSupportInfo);

				/// <summary>
				/// Creates a new trace-level entry in the log with the given message, details and calling component.
				/// </summary>
				/// <param name="sMessage">Message text to display</param>
				/// <param name="sDetails">Details about the message, might be omitted</param>
				/// <param name="sComponent">Name of the component that produced the log entry</param>
				public extern static void trace(string sMessage, string sDetails = "", string sComponent = "");

				/// <summary>
				/// Creates a new warning-level entry in the log with the given message, details and calling component.
				/// </summary>
				/// <param name="sMessage">Message text to display</param>
				/// <param name="sDetails">Details about the message, might be omitted</param>
				/// <param name="sComponent">Name of the component that produced the log entry</param>
				/// <param name="fnSupportInfo">Callback that returns an additional support object to be logged in support mode. This function is only called if support info mode is turned on with <code>logSupportInfo(true)</code>. To avoid negative effects regarding execution times and memory consumption, the returned object should be a simple immutable JSON object with mostly static and stable content.</param>
				public extern static void warning(string sMessage, string sDetails, string sComponent, object fnSupportInfo);

				/// <summary>
				/// Creates a new warning-level entry in the log with the given message, details and calling component.
				/// </summary>
				/// <param name="sMessage">Message text to display</param>
				/// <param name="sDetails">Details about the message, might be omitted</param>
				/// <param name="sComponent">Name of the component that produced the log entry</param>
				public extern static void warning(string sMessage, string sDetails = "", string sComponent = "");

				#endregion

				/// <summary>
				/// Enumeration of the configurable log levels that a Logger should persist to the log.
				/// 
				/// Only if the current LogLevel is higher than the level {@link module:sap/base/Log.Level} of the currently added log entry, then this very entry is permanently added to the log. Otherwise it is ignored.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.base.Log.Level")]
				public enum Level
				{
					/// <summary>
					/// Trace level to log everything.
					/// </summary>
					ALL,
					/// <summary>
					/// Debug level. Use this for logging information necessary for debugging
					/// </summary>
					DEBUG,
					/// <summary>
					/// Error level. Use this for logging of erroneous but still recoverable situations
					/// </summary>
					ERROR,
					/// <summary>
					/// Fatal level. Use this for logging unrecoverable situations
					/// </summary>
					FATAL,
					/// <summary>
					/// Info level. Use this for logging information of purely informative nature
					/// </summary>
					INFO,
					/// <summary>
					/// Do not log anything
					/// </summary>
					NONE,
					/// <summary>
					/// Trace level. Use this for tracing the program flow.
					/// </summary>
					TRACE,
					/// <summary>
					/// Warning level. Use this for logging unwanted but foreseen situations
					/// </summary>
					WARNING,
				}
			}
		}
	}
}
