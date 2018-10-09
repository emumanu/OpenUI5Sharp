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
				/// A FilterAction is a {@link sap.m.Button} control enhanced with styling according to the semantics of a common "Filter" action.
				/// 
				/// A FilterAction cannot be used independently but only as aggregation content of a {@link sap.m.semantic.SemanticPage}.
				/// 
				/// Your app should listen to the <code>press</code> event of {@link sap.m.semantic.FilterAction} in order to trigger the display of the filtering options.
				/// 
				/// If your filtering options are a simple list of items and require single choice only, then you can consider using a {@link sap.m.semantic.FilterSelect} instead.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.m.semantic.FilterAction")]
				public partial class FilterAction : sap.m.semantic.SemanticButton, sap.m.semantic.IFilter
				{
					#region Settings

					/// <summary>
					/// Settings class to create the object
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class Settings : sap.m.semantic.SemanticButton.Settings
					{
					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new FilterAction.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					/// <param name="mSettings">Custom initial settings for the new control</param>
					public extern FilterAction(string sId, sap.m.semantic.FilterAction.Settings mSettings);

					/// <summary>
					/// Constructor for a new FilterAction.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					public extern FilterAction(string sId);

					/// <summary>
					/// Constructor for a new FilterAction.
					/// </summary>
					public extern FilterAction();

					/// <summary>
					/// Constructor for a new FilterAction.
					/// </summary>
					/// <param name="mSettings">Custom initial settings for the new control</param>
					public extern FilterAction(sap.m.semantic.FilterAction.Settings mSettings);

					#endregion

					#region Methods

					/// <summary>
					/// Creates a new subclass of class sap.m.semantic.FilterAction with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.semantic.SemanticButton.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.m.semantic.FilterAction with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.semantic.SemanticButton.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.m.semantic.FilterAction with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.semantic.SemanticButton.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.m.semantic.FilterAction.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					#endregion

				}
			}
		}
	}
}
