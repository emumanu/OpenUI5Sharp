using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace OpenUI5Sharp
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
					/// BindingPath - checks if a control has a binding context with the exact same binding path
					/// </summary>
					[External]
					[Namespace(false)]
					public partial class BindingPath : sap.ui.test.matchers.Matcher
					{
						#region Settings

						/// <summary>
						/// Settings class to create the object
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class Settings : sap.ui.test.matchers.Matcher.Settings
						{
							/// <summary>
							/// The value of the binding path that is used for matching.
							/// </summary>
							public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> path;

							/// <summary>
							/// The name of the binding model that is used for matching.
							/// </summary>
							public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> modelName;

						}

						#endregion

						#region Constructor

						/// <summary>
						/// BindingPath - checks if a control has a binding context with the exact same binding path.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="mSettings">Map/JSON-object with initial settings for the new BindingPath.</param>
						public extern BindingPath(sap.ui.test.matchers.BindingPath.Settings mSettings);

						/// <summary>
						/// BindingPath - checks if a control has a binding context with the exact same binding path.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						public extern BindingPath();

						#endregion

						#region Methods

						#region Methods for Property path

						/// <summary>
						/// Gets current value of property {@link #getPath path}.
						/// 
						/// The value of the binding path that is used for matching.
						/// </summary>
						/// <returns>Value of property <code>path</code></returns>
						public extern virtual string getPath();

						/// <summary>
						/// Sets a new value for property {@link #getPath path}.
						/// 
						/// The value of the binding path that is used for matching.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// </summary>
						/// <param name="sPath">New value for property <code>path</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.test.matchers.BindingPath setPath(string sPath);

						#endregion

						#region Methods for Property modelName

						/// <summary>
						/// Gets current value of property {@link #getModelName modelName}.
						/// 
						/// The name of the binding model that is used for matching.
						/// </summary>
						/// <returns>Value of property <code>modelName</code></returns>
						public extern virtual string getModelName();

						/// <summary>
						/// Sets a new value for property {@link #getModelName modelName}.
						/// 
						/// The name of the binding model that is used for matching.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// </summary>
						/// <param name="sModelName">New value for property <code>modelName</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.test.matchers.BindingPath setModelName(string sModelName);

						#endregion

						#region Other methods

						/// <summary>
						/// Creates a new subclass of class sap.ui.test.matchers.BindingPath with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.test.matchers.Matcher.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.test.matchers.BindingPath with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.test.matchers.Matcher.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.test.matchers.BindingPath with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.test.matchers.Matcher.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns a metadata object for class sap.ui.test.matchers.BindingPath.
						/// </summary>
						/// <returns>Metadata object describing this class</returns>
						public extern static sap.ui.@base.Metadata getMetadata();

						/// <summary>
						/// Checks if the control has a binding context that matches the path
						/// </summary>
						/// <param name="oControl">the control that is checked by the matcher</param>
						/// <returns>true if the binding path has a strictly matching value.</returns>
						public extern override bool isMatching(sap.ui.core.Control oControl);

						#endregion

						#endregion

					}
				}
			}
		}
	}
}
