using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public static partial class sap
	{
		public static partial class tnt
		{
			/// <summary>
			/// The ToolHeaderUtilitySeparator control is used in the sap.tnt.ToolHeader control to specify where the overflow button is placed.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.tnt.ToolHeaderUtilitySeparator")]
			public partial class ToolHeaderUtilitySeparator : sap.ui.core.Control
			{
				#region Settings

				/// <summary>
				/// Settings class to create the object
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class Settings : sap.ui.core.Control.Settings
				{
				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new ToolHeaderUtilitySeparator.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// 
				/// This class does not have its own settings, but all settings applicable to the base type {@link sap.ui.core.Control#constructor sap.ui.core.Control} can be used.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern ToolHeaderUtilitySeparator(string sId, sap.tnt.ToolHeaderUtilitySeparator.Settings mSettings);

				/// <summary>
				/// Constructor for a new ToolHeaderUtilitySeparator.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// 
				/// This class does not have its own settings, but all settings applicable to the base type {@link sap.ui.core.Control#constructor sap.ui.core.Control} can be used.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern ToolHeaderUtilitySeparator(string sId);

				/// <summary>
				/// Constructor for a new ToolHeaderUtilitySeparator.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// 
				/// This class does not have its own settings, but all settings applicable to the base type {@link sap.ui.core.Control#constructor sap.ui.core.Control} can be used.
				/// </summary>
				public extern ToolHeaderUtilitySeparator();

				/// <summary>
				/// Constructor for a new ToolHeaderUtilitySeparator.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// 
				/// This class does not have its own settings, but all settings applicable to the base type {@link sap.ui.core.Control#constructor sap.ui.core.Control} can be used.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern ToolHeaderUtilitySeparator(sap.tnt.ToolHeaderUtilitySeparator.Settings mSettings);

				#endregion

				#region Methods

				/// <summary>
				/// Creates a new subclass of class sap.tnt.ToolHeaderUtilitySeparator with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.tnt.ToolHeaderUtilitySeparator with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.tnt.ToolHeaderUtilitySeparator with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.tnt.ToolHeaderUtilitySeparator.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				#endregion

			}
		}
	}
}
