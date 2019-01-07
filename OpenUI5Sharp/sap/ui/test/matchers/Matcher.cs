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
			public static partial class test
			{
				public static partial class matchers
				{
					/// <summary>
					/// Matchers for Opa5 - needs to implement an isMatching function that returns a boolean and will get a control instance as parameter
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.test.matchers.Matcher")]
					public abstract partial class Matcher : sap.ui.@base.ManagedObject
					{
						#region Settings

						/// <summary>
						/// Settings class to create the object
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class Settings : sap.ui.@base.ManagedObject.Settings
						{
						}

						#endregion

						#region Constructor

						/// <summary>
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// 
						/// This class does not have its own settings, but all settings applicable to the base type {@link sap.ui.base.ManagedObject#constructor sap.ui.base.ManagedObject} can be used.
						/// </summary>
						public extern Matcher();

						#endregion

						#region Methods

						/// <summary>
						/// Creates a new subclass of class sap.ui.test.matchers.Matcher with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.ManagedObject.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.test.matchers.Matcher with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.ManagedObject.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.test.matchers.Matcher with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.ManagedObject.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns a metadata object for class sap.ui.test.matchers.Matcher.
						/// </summary>
						/// <returns>Metadata object describing this class</returns>
						[Name("getMetadata")]
						public extern static sap.ui.@base.Metadata getMetadataStatic();

						/// <summary>
						/// Checks if the matcher is matching - will get an instance of sap.ui.core.Control as parameter.
						/// 
						/// Should be overwritten by subclasses
						/// </summary>
						/// <param name="oControl">the control that is checked by the matcher</param>
						/// <returns>true if the Control is matching the condition of the matcher</returns>
						public extern virtual bool isMatching(sap.ui.core.Control oControl);

						#endregion

					}
				}
			}
		}
	}
}
