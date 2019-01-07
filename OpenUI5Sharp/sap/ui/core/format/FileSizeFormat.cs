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
			public static partial class core
			{
				public static partial class format
				{
					/// <summary>
					/// The FileSizeFormat is a static class for formatting and parsing numeric file size values according to a set of format options.
					/// 
					/// Supports the same options as {@link sap.ui.core.format.NumberFormat.getFloatInstance NumberFormat.getFloatInstance} For format options which are not specified default values according to the type and locale settings are used.
					/// 
					/// Supported format options (additional to NumberFormat): <ul> <li>binaryFilesize: if true, base 2 is used: 1 Kibibyte = 1024 Byte, ... , otherwise base 10 is used: 1 Kilobyte = 1000 Byte (Default is false)</li> </ul>
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.core.format.FileSizeFormat")]
					public partial class FileSizeFormat : sap.ui.@base.Object
					{
						#region Methods

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.format.FileSizeFormat with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.format.FileSizeFormat with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.format.FileSizeFormat with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Format a filesize (in bytes) according to the given format options.
						/// </summary>
						/// <param name="oValue">the number (or hex string) to format</param>
						/// <returns>the formatted output value</returns>
						public extern virtual string format(Union<int, string> oValue);

						/// <summary>
						/// Get an instance of the FileSizeFormat, which can be used for formatting.
						/// 
						/// If no locale is given, the currently configured {@link sap.ui.core.Configuration.FormatSettings#getFormatLocale formatLocale} will be used.
						/// </summary>
						/// <param name="oFormatOptions">Object which defines the format options</param>
						/// <param name="oLocale">Locale to get the formatter for</param>
						/// <returns>instance of the FileSizeFormat</returns>
						public extern static sap.ui.core.format.FileSizeFormat getInstance(object oFormatOptions, sap.ui.core.Locale oLocale);

						/// <summary>
						/// Get an instance of the FileSizeFormat, which can be used for formatting.
						/// 
						/// If no locale is given, the currently configured {@link sap.ui.core.Configuration.FormatSettings#getFormatLocale formatLocale} will be used.
						/// </summary>
						/// <param name="oFormatOptions">Object which defines the format options</param>
						/// <returns>instance of the FileSizeFormat</returns>
						public extern static sap.ui.core.format.FileSizeFormat getInstance(object oFormatOptions);

						/// <summary>
						/// Get an instance of the FileSizeFormat, which can be used for formatting.
						/// 
						/// If no locale is given, the currently configured {@link sap.ui.core.Configuration.FormatSettings#getFormatLocale formatLocale} will be used.
						/// </summary>
						/// <returns>instance of the FileSizeFormat</returns>
						public extern static sap.ui.core.format.FileSizeFormat getInstance();

						/// <summary>
						/// Get an instance of the FileSizeFormat, which can be used for formatting.
						/// 
						/// If no locale is given, the currently configured {@link sap.ui.core.Configuration.FormatSettings#getFormatLocale formatLocale} will be used.
						/// </summary>
						/// <param name="oLocale">Locale to get the formatter for</param>
						/// <returns>instance of the FileSizeFormat</returns>
						public extern static sap.ui.core.format.FileSizeFormat getInstance(sap.ui.core.Locale oLocale);

						/// <summary>
						/// Returns a metadata object for class sap.ui.core.format.FileSizeFormat.
						/// </summary>
						/// <returns>Metadata object describing this class</returns>
						[Name("getMetadata")]
						public extern static sap.ui.@base.Metadata getMetadataStatic();

						/// <summary>
						/// Parse a string which is formatted according to the given format options.
						/// </summary>
						/// <param name="sValue">the string containing a formatted filesize value</param>
						/// <returns>the parsed value in bytes</returns>
						public extern virtual int parse(string sValue);

						#endregion

					}
				}
			}
		}
	}
}
