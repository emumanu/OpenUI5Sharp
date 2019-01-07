using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public static partial class sap
	{
		public static partial class m
		{
			public static partial class semantic
			{
				/// <summary>
				/// A FilterSelect is a {@link sap.m.Select} control enhanced with styling according to the semantics of a common "Filter" acton.
				/// 
				/// A FilterSelect cannot be used independently but only as aggregation content of a {@link sap.m.semantic.SemanticPage}.
				/// 
				/// The filtering options should be added to the <code>items</code> aggregation of {@link sap.m.semantic.FilterSelect} and will be displayed as a pop-up list with support for single-item selection. If this simple popup list is not sufficient for your use case, you can implement your own custom dialog by using {@link sap.m.semantic.FilterAction} to trigger the dialog opening.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.m.semantic.FilterSelect")]
				public partial class FilterSelect : sap.m.semantic.SemanticSelect, sap.m.semantic.IFilter
				{
					#region Settings

					/// <summary>
					/// Settings class to create the object
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class Settings : sap.m.semantic.SemanticSelect.Settings
					{
					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new FilterSelect.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					/// <param name="mSettings">Custom initial settings for the new control</param>
					public extern FilterSelect(string sId, sap.m.semantic.FilterSelect.Settings mSettings);

					/// <summary>
					/// Constructor for a new FilterSelect.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					public extern FilterSelect(string sId);

					/// <summary>
					/// Constructor for a new FilterSelect.
					/// </summary>
					public extern FilterSelect();

					/// <summary>
					/// Constructor for a new FilterSelect.
					/// </summary>
					/// <param name="mSettings">Custom initial settings for the new control</param>
					public extern FilterSelect(sap.m.semantic.FilterSelect.Settings mSettings);

					#endregion

					#region Methods

					/// <summary>
					/// Creates a new subclass of class sap.m.semantic.FilterSelect with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.semantic.SemanticSelect.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.m.semantic.FilterSelect with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.semantic.SemanticSelect.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.m.semantic.FilterSelect with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.semantic.SemanticSelect.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.m.semantic.FilterSelect.
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
