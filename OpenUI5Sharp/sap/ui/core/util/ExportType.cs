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
				public static partial class util
				{
					/// <summary>
					/// Base export type. Subclasses can be used for {@link sap.ui.core.util.Export Export}.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.core.util.ExportType")]
					public partial class ExportType : sap.ui.@base.ManagedObject
					{
						#region Settings

						/// <summary>
						/// Settings class to create the object
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class Settings : sap.ui.@base.ManagedObject.Settings
						{
							/// <summary>
							/// File extension.
							/// </summary>
							public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> fileExtension;

							/// <summary>
							/// MIME type.
							/// </summary>
							public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> mimeType;

							/// <summary>
							/// Charset.
							/// </summary>
							public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> charset;

							/// <summary>
							/// Whether to prepend an unicode byte order mark when saving as a file (only applies for utf-8 charset).
							/// </summary>
							public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> byteOrderMark;

						}

						#endregion

						#region Constructor

						/// <summary>
						/// Constructor for a new ExportType.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">id for the new control, generated automatically if no id is given</param>
						/// <param name="mSettings">initial settings for the new control</param>
						public extern ExportType(string sId, sap.ui.core.util.ExportType.Settings mSettings);

						/// <summary>
						/// Constructor for a new ExportType.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">id for the new control, generated automatically if no id is given</param>
						public extern ExportType(string sId);

						/// <summary>
						/// Constructor for a new ExportType.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						public extern ExportType();

						/// <summary>
						/// Constructor for a new ExportType.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="mSettings">initial settings for the new control</param>
						public extern ExportType(sap.ui.core.util.ExportType.Settings mSettings);

						#endregion

						#region Methods

						#region Methods for Property fileExtension

						/// <summary>
						/// Gets current value of property {@link #getFileExtension fileExtension}.
						/// 
						/// File extension.
						/// </summary>
						/// <returns>Value of property <code>fileExtension</code></returns>
						public extern virtual string getFileExtension();

						/// <summary>
						/// Sets a new value for property {@link #getFileExtension fileExtension}.
						/// 
						/// File extension.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// </summary>
						/// <param name="sFileExtension">New value for property <code>fileExtension</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.util.ExportType setFileExtension(string sFileExtension);

						#endregion

						#region Methods for Property mimeType

						/// <summary>
						/// Gets current value of property {@link #getMimeType mimeType}.
						/// 
						/// MIME type.
						/// </summary>
						/// <returns>Value of property <code>mimeType</code></returns>
						public extern virtual string getMimeType();

						/// <summary>
						/// Sets a new value for property {@link #getMimeType mimeType}.
						/// 
						/// MIME type.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// </summary>
						/// <param name="sMimeType">New value for property <code>mimeType</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.util.ExportType setMimeType(string sMimeType);

						#endregion

						#region Methods for Property charset

						/// <summary>
						/// Gets current value of property {@link #getCharset charset}.
						/// 
						/// Charset.
						/// </summary>
						/// <returns>Value of property <code>charset</code></returns>
						public extern virtual string getCharset();

						/// <summary>
						/// Sets a new value for property {@link #getCharset charset}.
						/// 
						/// Charset.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// </summary>
						/// <param name="sCharset">New value for property <code>charset</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.util.ExportType setCharset(string sCharset);

						#endregion

						#region Methods for Property byteOrderMark

						/// <summary>
						/// Gets current value of property {@link #getByteOrderMark byteOrderMark}.
						/// 
						/// Whether to prepend an unicode byte order mark when saving as a file (only applies for utf-8 charset).
						/// 
						/// Default value is <code>undefined</code>.
						/// </summary>
						/// <returns>Value of property <code>byteOrderMark</code></returns>
						public extern virtual bool getByteOrderMark();

						/// <summary>
						/// Sets a new value for property {@link #getByteOrderMark byteOrderMark}.
						/// 
						/// Whether to prepend an unicode byte order mark when saving as a file (only applies for utf-8 charset).
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>undefined</code>.
						/// </summary>
						/// <param name="bByteOrderMark">New value for property <code>byteOrderMark</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.util.ExportType setByteOrderMark(bool bByteOrderMark);

						#endregion

						#region Other methods

						/// <summary>
						/// Handles the generation process of the file.<br>
						/// </summary>
						/// <param name="oExport">export instance</param>
						/// <returns>content</returns>
						public extern virtual string _generate(sap.ui.core.util.Export oExport);

						/// <summary>
						/// Creates a cell "generator" (inspired by ES6 Generators)
						/// </summary>
						/// <returns>generator</returns>
						public extern virtual object cellGenerator();

						/// <summary>
						/// Creates a column "generator" (inspired by ES6 Generators)
						/// </summary>
						/// <returns>generator</returns>
						public extern virtual object columnGenerator();

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.util.ExportType with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.ManagedObject.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.util.ExportType with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.ManagedObject.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.util.ExportType with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.ManagedObject.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Generates the file content.<br> Should be implemented by the individual types!
						/// </summary>
						/// <returns>content</returns>
						public extern virtual string generate();

						/// <summary>
						/// Returns the number of columns.
						/// </summary>
						/// <returns>count</returns>
						public extern virtual int getColumnCount();

						/// <summary>
						/// Returns a metadata object for class sap.ui.core.util.ExportType.
						/// </summary>
						/// <returns>Metadata object describing this class</returns>
						[Name("getMetadata")]
						public extern static sap.ui.@base.Metadata getMetadataStatic();

						/// <summary>
						/// Returns the number of rows.
						/// </summary>
						/// <returns>count</returns>
						public extern virtual int getRowCount();

						/// <summary>
						/// Creates a row "generator" (inspired by ES6 Generators)
						/// </summary>
						/// <returns>generator</returns>
						public extern virtual object rowGenerator();

						#endregion

						#endregion

					}
				}
			}
		}
	}
}
