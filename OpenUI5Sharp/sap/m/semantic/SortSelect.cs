using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace OpenUI5Sharp
{
	public static partial class sap
	{
		public static partial class m
		{
			public static partial class semantic
			{
				/// <summary>
				/// A SortSelect is a {@link sap.m.Select} control enhanced with styling according to the semantics of a common "Sort" acton.
				/// 
				/// A SortSelect cannot be used independently but only as aggregation content of a {@link sap.m.semantic.SemanticPage}.
				/// 
				/// The sorting options should be added to the <code>items</code> aggregation of {@link sap.m.semantic.SortSelect} and will be displayed as a pop-up list with support for single-item selection. If this simple popup list is not sufficient for your use case, you can implement your own custom dialog by using {@link sap.m.semantic.SortAction} to trigger the dialog opening.
				/// </summary>
				[External]
				[Namespace(false)]
				public partial class SortSelect : sap.m.semantic.SemanticSelect, sap.m.semantic.ISort
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
					/// Constructor for a new SortSelect.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					/// <param name="mSettings">Custom initial settings for the new control</param>
					public extern SortSelect(string sId, sap.m.semantic.SortSelect.Settings mSettings);

					/// <summary>
					/// Constructor for a new SortSelect.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					public extern SortSelect(string sId);

					/// <summary>
					/// Constructor for a new SortSelect.
					/// </summary>
					public extern SortSelect();

					/// <summary>
					/// Constructor for a new SortSelect.
					/// </summary>
					/// <param name="mSettings">Custom initial settings for the new control</param>
					public extern SortSelect(sap.m.semantic.SortSelect.Settings mSettings);

					#endregion

					#region Methods

					/// <summary>
					/// Creates a new subclass of class sap.m.semantic.SortSelect with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.semantic.SemanticSelect.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.m.semantic.SortSelect with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.semantic.SemanticSelect.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.m.semantic.SortSelect with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.semantic.SemanticSelect.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.m.semantic.SortSelect.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					#endregion

				}
			}
		}
	}
}
