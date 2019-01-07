using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public static partial class sap
	{
		public static partial class uxap
		{
			/// <summary>
			/// A select that displays items on a hierarchy of 2 levels.
			/// 
			/// If a provided item has a custom data named <code>secondLevel</code>, then it will be displayed as a second level, otherwise it would be displayed as a first level.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.uxap.HierarchicalSelect")]
			public partial class HierarchicalSelect : sap.m.Select
			{
				#region Settings

				/// <summary>
				/// Settings class to create the object
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class Settings : sap.m.Select.Settings
				{
					/// <summary>
					/// Determines whether the HierarchicalSelect items are displayed in upper case.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> upperCase;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new <code>HierarchicalSelect</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern HierarchicalSelect(string sId, sap.uxap.HierarchicalSelect.Settings mSettings);

				/// <summary>
				/// Constructor for a new <code>HierarchicalSelect</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern HierarchicalSelect(string sId);

				/// <summary>
				/// Constructor for a new <code>HierarchicalSelect</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern HierarchicalSelect();

				/// <summary>
				/// Constructor for a new <code>HierarchicalSelect</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern HierarchicalSelect(sap.uxap.HierarchicalSelect.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property upperCase

				/// <summary>
				/// Gets current value of property {@link #getUpperCase upperCase}.
				/// 
				/// Determines whether the HierarchicalSelect items are displayed in upper case.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>upperCase</code></returns>
				public extern virtual bool getUpperCase();

				/// <summary>
				/// Sets a new value for property {@link #getUpperCase upperCase}.
				/// 
				/// Determines whether the HierarchicalSelect items are displayed in upper case.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bUpperCase">New value for property <code>upperCase</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.HierarchicalSelect setUpperCase(bool bUpperCase);

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.uxap.HierarchicalSelect with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.Select.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.uxap.HierarchicalSelect with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.Select.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.uxap.HierarchicalSelect with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.Select.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.uxap.HierarchicalSelect.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				[Name("getMetadata")]
				public extern static sap.ui.@base.Metadata getMetadataStatic();

				#endregion

				#endregion

			}
		}
	}
}
