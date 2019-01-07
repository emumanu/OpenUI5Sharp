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
				public static partial class actions
				{
					/// <summary>
					/// Actions for Opa5 - needs to implement an executeOn function that should simulate a user interaction on a control
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.test.actions.Action")]
					public abstract partial class Action : sap.ui.@base.ManagedObject
					{
						#region Settings

						/// <summary>
						/// Settings class to create the object
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class Settings : sap.ui.@base.ManagedObject.Settings
						{
							public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> idSuffix;

						}

						#endregion

						#region Constructor

						/// <summary>
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						public extern Action();

						#endregion

						#region Methods

						#region Methods for Property idSuffix

						/// <summary>
						/// Gets current value of property {@link #getIdSuffix idSuffix}.
						/// </summary>
						/// <returns>Value of property <code>idSuffix</code></returns>
						public extern virtual string getIdSuffix();

						/// <summary>
						/// Sets a new value for property {@link #getIdSuffix idSuffix}.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// </summary>
						/// <param name="sIdSuffix">New value for property <code>idSuffix</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.test.actions.Action setIdSuffix(string sIdSuffix);

						#endregion

						#region Other methods

						/// <summary>
						/// Checks if the matcher is matching - will get an instance of sap.ui.core.Control as parameter Should be overwritten by subclasses
						/// </summary>
						/// <param name="element">the {@link sap.ui.core.Element} or a control (extends element) the action will be executed on</param>
						public extern virtual void executeOn(sap.ui.core.Control element);

						/// <summary>
						/// Creates a new subclass of class sap.ui.test.actions.Action with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.ManagedObject.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.test.actions.Action with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.ManagedObject.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.test.actions.Action with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.ManagedObject.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns a metadata object for class sap.ui.test.actions.Action.
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
	}
}
