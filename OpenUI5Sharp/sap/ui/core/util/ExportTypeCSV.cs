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
					/// CSV export type. Can be used for {@link sap.ui.core.util.Export Export}.
					/// 
					/// Please note that there could be an issue with the separator char depending on the user's system language in some programs such as Microsoft Excel. To prevent those issues use the data-import functionality which enables the possibility to explicitly set the separator char that should be used. This way the content will be displayed correctly.
					/// 
					/// Potential formulas (cell data starts with one of = + - @) will be escaped by prepending a single quote. As the export functionality is intended to be used with actual (user) data there is no reason to allow formulas.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.core.util.ExportTypeCSV")]
					public partial class ExportTypeCSV : sap.ui.core.util.ExportType
					{
						#region Settings

						/// <summary>
						/// Settings class to create the object
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class Settings : sap.ui.core.util.ExportType.Settings
						{
							/// <summary>
							/// Separator char.
							/// 
							/// Value needs to be exactly one character or empty for default.
							/// </summary>
							public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> separatorChar;

						}

						#endregion

						#region Constructor

						/// <summary>
						/// Constructor for a new ExportTypeCSV.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">id for the new control, generated automatically if no id is given</param>
						/// <param name="mSettings">initial settings for the new control</param>
						public extern ExportTypeCSV(string sId, sap.ui.core.util.ExportTypeCSV.Settings mSettings);

						/// <summary>
						/// Constructor for a new ExportTypeCSV.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">id for the new control, generated automatically if no id is given</param>
						public extern ExportTypeCSV(string sId);

						/// <summary>
						/// Constructor for a new ExportTypeCSV.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						public extern ExportTypeCSV();

						/// <summary>
						/// Constructor for a new ExportTypeCSV.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="mSettings">initial settings for the new control</param>
						public extern ExportTypeCSV(sap.ui.core.util.ExportTypeCSV.Settings mSettings);

						#endregion

						#region Methods

						#region Methods for Property separatorChar

						/// <summary>
						/// Gets current value of property {@link #getSeparatorChar separatorChar}.
						/// 
						/// Separator char.
						/// 
						/// Value needs to be exactly one character or empty for default.
						/// 
						/// Default value is <code>,</code>.
						/// </summary>
						/// <returns>Value of property <code>separatorChar</code></returns>
						public extern virtual string getSeparatorChar();

						/// <summary>
						/// Setter for property <code>separatorChar</code>.
						/// 
						/// Value needs to be exactly one character or empty for default. Default value is ','.
						/// </summary>
						/// <param name="sSeparatorChar">new value for property <code>separatorChar</code></param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern virtual sap.ui.core.util.ExportTypeCSV setSeparatorChar(string sSeparatorChar);

						#endregion

						#region Other methods

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.util.ExportTypeCSV with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.util.ExportType.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.util.ExportTypeCSV with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.util.ExportType.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.util.ExportTypeCSV with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.util.ExportType.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Generates the file content.
						/// </summary>
						/// <returns>content</returns>
						public extern override string generate();

						/// <summary>
						/// Returns a metadata object for class sap.ui.core.util.ExportTypeCSV.
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
}
