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
			public static partial class commons
			{
				/// <summary>
				/// Represents a parameter for the FileUploader which is rendered as a hidden inputfield.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.FileUploaderParameter")]
				[Obsolete("Deprecated since 1.21.0. Please use the element sap.ui.unified.FileUploaderParameter of the library sap.ui.unified instead.")]
				public partial class FileUploaderParameter : sap.ui.unified.FileUploaderParameter
				{
					#region Settings

					/// <summary>
					/// Settings class to create the object
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class Settings : sap.ui.unified.FileUploaderParameter.Settings
					{
					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new FileUploaderParameter.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern FileUploaderParameter(string sId, sap.ui.commons.FileUploaderParameter.Settings mSettings);

					/// <summary>
					/// Constructor for a new FileUploaderParameter.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern FileUploaderParameter(string sId);

					/// <summary>
					/// Constructor for a new FileUploaderParameter.
					/// </summary>
					public extern FileUploaderParameter();

					/// <summary>
					/// Constructor for a new FileUploaderParameter.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern FileUploaderParameter(sap.ui.commons.FileUploaderParameter.Settings mSettings);

					#endregion

					#region Methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.FileUploaderParameter with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.unified.FileUploaderParameter.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.FileUploaderParameter with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.unified.FileUploaderParameter.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.FileUploaderParameter with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.unified.FileUploaderParameter.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.commons.FileUploaderParameter.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					[Name("getMetadata")]
					public extern static sap.ui.@base.Metadata getMetadataStatic();

					#endregion

				}
			}
		}
	}
}
