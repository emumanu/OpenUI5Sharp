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
			/// A Logging API for JavaScript.
			/// 
			/// Provides methods to manage a client-side log and to create entries in it. Each of the logging methods {@link jQuery.sap.log.debug}, {@link jQuery.sap.log.info}, {@link jQuery.sap.log.warning}, {@link jQuery.sap.log.error} and {@link jQuery.sap.log.fatal} creates and records a log entry, containing a timestamp, a log level, a message with details and a component info. The log level will be one of {@link jQuery.sap.log.Level} and equals the name of the concrete logging method.
			/// 
			/// By using the {@link jQuery.sap.log.setLevel} method, consumers can determine the least important log level which should be recorded. Less important entries will be filtered out. (Note that higher numeric values represent less important levels). The initially set level depends on the mode that UI5 is running in. When the optimized sources are executed, the default level will be {@link jQuery.sap.log.Level.ERROR}. For normal (debug sources), the default level is {@link jQuery.sap.log.Level.DEBUG}.
			/// 
			/// All logging methods allow to specify a <b>component</b>. These components are simple strings and don't have a special meaning to the UI5 framework. However they can be used to semantically group log entries that belong to the same software component (or feature). There are two APIs that help to manage logging for such a component. With <code>{@link jQuery.sap.log.getLogger}(sComponent)</code>, one can retrieve a logger that automatically adds the given <code>sComponent</code> as component parameter to each log entry, if no other component is specified. Typically, JavaScript code will retrieve such a logger once during startup and reuse it for the rest of its lifecycle. Second, the {@link jQuery.sap.log.Logger#setLevel}(iLevel, sComponent) method allows to set the log level for a specific component only. This allows a more fine granular control about the created logging entries. {@link jQuery.sap.log.Logger#getLevel} allows to retrieve the currently effective log level for a given component.
			/// 
			/// {@link jQuery.sap.log.getLogEntries} returns an array of the currently collected log entries.
			/// 
			/// Furthermore, a listener can be registered to the log. It will be notified whenever a new entry is added to the log. The listener can be used for displaying log entries in a separate page area, or for sending it to some external target (server).
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("jQuery.sap.log")]
			[Obsolete("Deprecated since 1.58. use {@link module:sap/base/Log} instead")]
			public static partial class log
			{
				#region Methods

				/// <summary>
				/// Allows to add a new LogListener that will be notified for new log entries.
				/// 
				/// The given object must provide method <code>onLogEntry</code> and can also be informed about <code>onDetachFromLog</code> and <code>onAttachToLog</code>
				/// </summary>
				/// <param name="oListener">The new listener object that should be informed</param>
				/// <returns>The global logger</returns>
				public extern static object addLogListener(object oListener);

				/// <summary>
				/// Creates a new debug-level entry in the log with the given message, details and calling component.
				/// </summary>
				/// <param name="sMessage">Message text to display</param>
				/// <param name="sDetails">Details about the message, might be omitted</param>
				/// <param name="sComponent">Name of the component that produced the log entry</param>
				/// <param name="fnSupportInfo">Callback that returns an additional support object to be logged in support mode. This function is only called if support info mode is turned on with <code>logSupportInfo(true)</code>. To avoid negative effects regarding execution times and memory consumption, the returned object should be a simple immutable JSON object with mostly static and stable content.</param>
				/// <returns>The log instance</returns>
				public extern static jQuery.sap.log.Logger debug(string sMessage, string sDetails, string sComponent, object fnSupportInfo);

				/// <summary>
				/// Creates a new debug-level entry in the log with the given message, details and calling component.
				/// </summary>
				/// <param name="sMessage">Message text to display</param>
				/// <param name="sDetails">Details about the message, might be omitted</param>
				/// <param name="sComponent">Name of the component that produced the log entry</param>
				/// <returns>The log instance</returns>
				public extern static jQuery.sap.log.Logger debug(string sMessage, string sDetails = "", string sComponent = "");

				/// <summary>
				/// Creates a new error-level entry in the log with the given message, details and calling component.
				/// </summary>
				/// <param name="sMessage">Message text to display</param>
				/// <param name="sDetails">Details about the message, might be omitted</param>
				/// <param name="sComponent">Name of the component that produced the log entry</param>
				/// <param name="fnSupportInfo">Callback that returns an additional support object to be logged in support mode. This function is only called if support info mode is turned on with <code>logSupportInfo(true)</code>. To avoid negative effects regarding execution times and memory consumption, the returned object should be a simple immutable JSON object with mostly static and stable content.</param>
				/// <returns>The log instance</returns>
				public extern static jQuery.sap.log.Logger error(string sMessage, string sDetails, string sComponent, object fnSupportInfo);

				/// <summary>
				/// Creates a new error-level entry in the log with the given message, details and calling component.
				/// </summary>
				/// <param name="sMessage">Message text to display</param>
				/// <param name="sDetails">Details about the message, might be omitted</param>
				/// <param name="sComponent">Name of the component that produced the log entry</param>
				/// <returns>The log instance</returns>
				public extern static jQuery.sap.log.Logger error(string sMessage, string sDetails = "", string sComponent = "");

				/// <summary>
				/// Creates a new fatal-level entry in the log with the given message, details and calling component.
				/// </summary>
				/// <param name="sMessage">Message text to display</param>
				/// <param name="sDetails">Details about the message, might be omitted</param>
				/// <param name="sComponent">Name of the component that produced the log entry</param>
				/// <param name="fnSupportInfo">Callback that returns an additional support object to be logged in support mode. This function is only called if support info mode is turned on with <code>logSupportInfo(true)</code>. To avoid negative effects regarding execution times and memory consumption, the returned object should be a simple immutable JSON object with mostly static and stable content.</param>
				/// <returns>The log instance for method chaining</returns>
				public extern static jQuery.sap.log.Logger fatal(string sMessage, string sDetails, string sComponent, object fnSupportInfo);

				/// <summary>
				/// Creates a new fatal-level entry in the log with the given message, details and calling component.
				/// </summary>
				/// <param name="sMessage">Message text to display</param>
				/// <param name="sDetails">Details about the message, might be omitted</param>
				/// <param name="sComponent">Name of the component that produced the log entry</param>
				/// <returns>The log instance for method chaining</returns>
				public extern static jQuery.sap.log.Logger fatal(string sMessage, string sDetails = "", string sComponent = "");

				/// <summary>
				/// Returns the log level currently effective for the given component. If no component is given or when no level has been configured for a given component, the log level for the default component of this logger is returned.
				/// </summary>
				/// <param name="sComponent">Name of the component to retrieve the log level for</param>
				/// <returns>The log level for the given component or the default log level</returns>
				public extern static int getLevel(string sComponent);

				/// <summary>
				/// Returns the log level currently effective for the given component. If no component is given or when no level has been configured for a given component, the log level for the default component of this logger is returned.
				/// </summary>
				/// <returns>The log level for the given component or the default log level</returns>
				public extern static int getLevel();

				/// <summary>
				/// Retrieves the currently recorded log entries.
				/// </summary>
				[Obsolete("Deprecated since 1.1.2. To avoid confusion with getLogger, this method has been renamed to {@link jQuery.sap.log.getLogEntries}.")]
				public extern static void getLog();

				/// <summary>
				/// Returns the logged entries recorded so far as an array.
				/// 
				/// Log entries are plain JavaScript objects with the following properties <ul> <li>timestamp {number} point in time when the entry was created</li> <li>level {int} LogLevel level of the entry</li> <li>message {string} message text of the entry</li> </ul>
				/// </summary>
				/// <returns>an array containing the recorded log entries</returns>
				public extern static object[] getLogEntries();

				/// <summary>
				/// Returns a {@link jQuery.sap.log.Logger} for the given component.
				/// 
				/// The method might or might not return the same logger object across multiple calls. While loggers are assumed to be light weight objects, consumers should try to avoid redundant calls and instead keep references to already retrieved loggers.
				/// 
				/// The optional second parameter <code>iDefaultLogLevel</code> allows to specify a default log level for the component. It is only applied when no log level has been defined so far for that component (ignoring inherited log levels). If this method is called multiple times for the same component but with different log levels, only the first call one might be taken into account.
				/// </summary>
				/// <param name="sComponent">Component to create the logger for</param>
				/// <param name="iDefaultLogLevel">a default log level to be used for the component, if no log level has been defined for it so far.</param>
				/// <returns>A logger for the component.</returns>
				public extern static jQuery.sap.log.Logger getLogger(string sComponent, int iDefaultLogLevel);

				/// <summary>
				/// Returns a {@link jQuery.sap.log.Logger} for the given component.
				/// 
				/// The method might or might not return the same logger object across multiple calls. While loggers are assumed to be light weight objects, consumers should try to avoid redundant calls and instead keep references to already retrieved loggers.
				/// 
				/// The optional second parameter <code>iDefaultLogLevel</code> allows to specify a default log level for the component. It is only applied when no log level has been defined so far for that component (ignoring inherited log levels). If this method is called multiple times for the same component but with different log levels, only the first call one might be taken into account.
				/// </summary>
				/// <param name="sComponent">Component to create the logger for</param>
				/// <returns>A logger for the component.</returns>
				public extern static jQuery.sap.log.Logger getLogger(string sComponent);

				/// <summary>
				/// Creates a new info-level entry in the log with the given message, details and calling component.
				/// </summary>
				/// <param name="sMessage">Message text to display</param>
				/// <param name="sDetails">Details about the message, might be omitted</param>
				/// <param name="sComponent">Name of the component that produced the log entry</param>
				/// <param name="fnSupportInfo">Callback that returns an additional support object to be logged in support mode. This function is only called if support info mode is turned on with <code>logSupportInfo(true)</code>. To avoid negative effects regarding execution times and memory consumption, the returned object should be a simple immutable JSON object with mostly static and stable content.</param>
				/// <returns>The log instance</returns>
				public extern static jQuery.sap.log.Logger info(string sMessage, string sDetails, string sComponent, object fnSupportInfo);

				/// <summary>
				/// Creates a new info-level entry in the log with the given message, details and calling component.
				/// </summary>
				/// <param name="sMessage">Message text to display</param>
				/// <param name="sDetails">Details about the message, might be omitted</param>
				/// <param name="sComponent">Name of the component that produced the log entry</param>
				/// <returns>The log instance</returns>
				public extern static jQuery.sap.log.Logger info(string sMessage, string sDetails = "", string sComponent = "");

				/// <summary>
				/// Checks whether logging is enabled for the given log level, depending on the currently effective log level for the given component.
				/// 
				/// If no component is given, the default component of this logger will be taken into account.
				/// </summary>
				/// <param name="iLevel">The log level in question</param>
				/// <param name="sComponent">Name of the component to check the log level for</param>
				/// <returns>Whether logging is enabled or not</returns>
				public extern static bool isLoggable(int iLevel, string sComponent);

				/// <summary>
				/// Checks whether logging is enabled for the given log level, depending on the currently effective log level for the given component.
				/// 
				/// If no component is given, the default component of this logger will be taken into account.
				/// </summary>
				/// <param name="iLevel">The log level in question</param>
				/// <returns>Whether logging is enabled or not</returns>
				public extern static bool isLoggable(int iLevel);

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
				/// Allows to remove a registered LogListener.
				/// </summary>
				/// <param name="oListener">The new listener object that should be removed</param>
				/// <returns>The global logger</returns>
				public extern static object removeLogListener(object oListener);

				/// <summary>
				/// Defines the maximum <code>jQuery.sap.log.Level</code> of log entries that will be recorded. Log entries with a higher (less important) log level will be omitted from the log. When a component name is given, the log level will be configured for that component only, otherwise the log level for the default component of this logger is set. For the global logger, the global default level is set.
				/// 
				/// <b>Note</b>: Setting a global default log level has no impact on already defined component log levels. They always override the global default log level.
				/// </summary>
				/// <param name="iLogLevel">The new log level</param>
				/// <param name="sComponent">The log component to set the log level for</param>
				/// <returns>This logger object to allow method chaining</returns>
				public extern static jQuery.sap.log.Logger setLevel(jQuery.sap.log.Level iLogLevel, string sComponent);

				/// <summary>
				/// Defines the maximum <code>jQuery.sap.log.Level</code> of log entries that will be recorded. Log entries with a higher (less important) log level will be omitted from the log. When a component name is given, the log level will be configured for that component only, otherwise the log level for the default component of this logger is set. For the global logger, the global default level is set.
				/// 
				/// <b>Note</b>: Setting a global default log level has no impact on already defined component log levels. They always override the global default log level.
				/// </summary>
				/// <param name="iLogLevel">The new log level</param>
				/// <returns>This logger object to allow method chaining</returns>
				public extern static jQuery.sap.log.Logger setLevel(jQuery.sap.log.Level iLogLevel);

				/// <summary>
				/// Creates a new trace-level entry in the log with the given message, details and calling component.
				/// </summary>
				/// <param name="sMessage">Message text to display</param>
				/// <param name="sDetails">Details about the message, might be omitted</param>
				/// <param name="sComponent">Name of the component that produced the log entry</param>
				/// <param name="fnSupportInfo">Callback that returns an additional support object to be logged in support mode. This function is only called if support info mode is turned on with <code>logSupportInfo(true)</code>. To avoid negative effects regarding execution times and memory consumption, the returned object should be a simple immutable JSON object with mostly static and stable content.</param>
				/// <returns>The log-instance</returns>
				public extern static jQuery.sap.log.Logger trace(string sMessage, string sDetails, string sComponent, object fnSupportInfo);

				/// <summary>
				/// Creates a new trace-level entry in the log with the given message, details and calling component.
				/// </summary>
				/// <param name="sMessage">Message text to display</param>
				/// <param name="sDetails">Details about the message, might be omitted</param>
				/// <param name="sComponent">Name of the component that produced the log entry</param>
				/// <returns>The log-instance</returns>
				public extern static jQuery.sap.log.Logger trace(string sMessage, string sDetails = "", string sComponent = "");

				/// <summary>
				/// Creates a new warning-level entry in the log with the given message, details and calling component.
				/// </summary>
				/// <param name="sMessage">Message text to display</param>
				/// <param name="sDetails">Details about the message, might be omitted</param>
				/// <param name="sComponent">Name of the component that produced the log entry</param>
				/// <param name="fnSupportInfo">Callback that returns an additional support object to be logged in support mode. This function is only called if support info mode is turned on with <code>logSupportInfo(true)</code>. To avoid negative effects regarding execution times and memory consumption, the returned object should be a simple immutable JSON object with mostly static and stable content.</param>
				/// <returns>The log instance</returns>
				public extern static jQuery.sap.log.Logger warning(string sMessage, string sDetails, string sComponent, object fnSupportInfo);

				/// <summary>
				/// Creates a new warning-level entry in the log with the given message, details and calling component.
				/// </summary>
				/// <param name="sMessage">Message text to display</param>
				/// <param name="sDetails">Details about the message, might be omitted</param>
				/// <param name="sComponent">Name of the component that produced the log entry</param>
				/// <returns>The log instance</returns>
				public extern static jQuery.sap.log.Logger warning(string sMessage, string sDetails = "", string sComponent = "");

				#endregion

				/// <summary>
				/// Enumeration of the configurable log levels that a Logger should persist to the log.
				/// 
				/// Only if the current LogLevel is higher than the level {@link jQuery.sap.log.Level} of the currently added log entry, then this very entry is permanently added to the log. Otherwise it is ignored.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("jQuery.sap.log.Level")]
				[Obsolete("Deprecated since 1.58. use {@link module:sap/base/Log.Level} instead")]
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
				/// <summary>
				/// Enumeration of levels that can be used in a call to {@link jQuery.sap.log.Logger#setLevel}(iLevel, sComponent).
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("jQuery.sap.log.LogLevel")]
				[Obsolete("Deprecated since 1.1.2. To streamline the Logging API a bit, the separation between Level and LogLevel has been given up. Use the (enriched) enumeration {@link jQuery.sap.log.Level} instead.")]
				public enum LogLevel
				{
				}
			}
		}
	}
}
