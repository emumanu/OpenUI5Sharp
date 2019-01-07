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
			public static partial class model
			{
				public static partial class type
				{
					/// <summary>
					/// This class represents file size simple types.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.model.type.FileSize")]
					public partial class FileSize : sap.ui.model.SimpleType
					{
						#region Constructor

						/// <summary>
						/// Constructor for a FileSize type.
						/// </summary>
						/// <param name="oFormatOptions">formatting options. Supports the same options as {@link sap.ui.core.format.FileSizeFormat.getInstance FileSizeFormat.getInstance}</param>
						/// <param name="oConstraints">value constraints.</param>
						public extern FileSize(sap.ui.model.FormatOptions oFormatOptions, sap.ui.model.TypeInfo oConstraints);

						/// <summary>
						/// Constructor for a FileSize type.
						/// </summary>
						/// <param name="oFormatOptions">formatting options. Supports the same options as {@link sap.ui.core.format.FileSizeFormat.getInstance FileSizeFormat.getInstance}</param>
						public extern FileSize(sap.ui.model.FormatOptions oFormatOptions);

						/// <summary>
						/// Constructor for a FileSize type.
						/// </summary>
						public extern FileSize();

						#endregion

						#region Methods

						/// <summary>
						/// Creates a new subclass of class sap.ui.model.type.FileSize with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.SimpleType.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.model.type.FileSize with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.SimpleType.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.model.type.FileSize with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.SimpleType.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns a metadata object for class sap.ui.model.type.FileSize.
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
}
