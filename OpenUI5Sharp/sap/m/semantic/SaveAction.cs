﻿using System;
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
				/// A SaveAction button has default semantic-specific properties and is eligible for aggregation content of a {@link sap.m.semantic.SemanticPage}.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.m.semantic.SaveAction")]
				public partial class SaveAction : sap.m.semantic.SemanticButton
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
					/// Constructor for a new SaveAction.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					/// <param name="mSettings">Custom initial settings for the new control</param>
					public extern SaveAction(string sId, sap.m.semantic.SaveAction.Settings mSettings);

					/// <summary>
					/// Constructor for a new SaveAction.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					public extern SaveAction(string sId);

					/// <summary>
					/// Constructor for a new SaveAction.
					/// </summary>
					public extern SaveAction();

					/// <summary>
					/// Constructor for a new SaveAction.
					/// </summary>
					/// <param name="mSettings">Custom initial settings for the new control</param>
					public extern SaveAction(sap.m.semantic.SaveAction.Settings mSettings);

					#endregion

					#region Methods

					/// <summary>
					/// Creates a new subclass of class sap.m.semantic.SaveAction with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.semantic.SemanticButton.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.m.semantic.SaveAction with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.semantic.SemanticButton.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.m.semantic.SaveAction with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.semantic.SemanticButton.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.m.semantic.SaveAction.
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
