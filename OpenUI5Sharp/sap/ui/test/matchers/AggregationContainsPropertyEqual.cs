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
					/// AggregationContainsPropertyEqual - checks if an aggregation contains at least one item that has a Property set to a certain value
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.test.matchers.AggregationContainsPropertyEqual")]
					public partial class AggregationContainsPropertyEqual : sap.ui.test.matchers.Matcher
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
							/// The Name of the aggregation that is used for matching.
							/// </summary>
							public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> aggregationName;

							/// <summary>
							/// The Name of the property that is used for matching.
							/// </summary>
							public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> propertyName;

							/// <summary>
							/// The value of the Property that is used for matching.
							/// </summary>
							public Union<object, string, sap.ui.@base.ManagedObject.BindPropertyInfo> propertyValue;

						}

						#endregion

						#region Constructor

						/// <summary>
						/// AggregationContainsPropertyEqual - checks if an aggregation contains at least one item that has a Property set to a certain value.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="mSettings">optional map/JSON-object with initial settings for the new AggregationContainsPropertyEqualMatcher</param>
						public extern AggregationContainsPropertyEqual(sap.ui.test.matchers.AggregationContainsPropertyEqual.Settings mSettings);

						/// <summary>
						/// AggregationContainsPropertyEqual - checks if an aggregation contains at least one item that has a Property set to a certain value.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						public extern AggregationContainsPropertyEqual();

						#endregion

						#region Methods

						#region Methods for Property aggregationName

						/// <summary>
						/// Gets current value of property {@link #getAggregationName aggregationName}.
						/// 
						/// The Name of the aggregation that is used for matching.
						/// </summary>
						/// <returns>Value of property <code>aggregationName</code></returns>
						public extern virtual string getAggregationName();

						/// <summary>
						/// Sets a new value for property {@link #getAggregationName aggregationName}.
						/// 
						/// The Name of the aggregation that is used for matching.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// </summary>
						/// <param name="sAggregationName">New value for property <code>aggregationName</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.test.matchers.AggregationContainsPropertyEqual setAggregationName(string sAggregationName);

						#endregion

						#region Methods for Property propertyName

						/// <summary>
						/// Gets current value of property {@link #getPropertyName propertyName}.
						/// 
						/// The Name of the property that is used for matching.
						/// </summary>
						/// <returns>Value of property <code>propertyName</code></returns>
						public extern virtual string getPropertyName();

						/// <summary>
						/// Sets a new value for property {@link #getPropertyName propertyName}.
						/// 
						/// The Name of the property that is used for matching.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// </summary>
						/// <param name="sPropertyName">New value for property <code>propertyName</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.test.matchers.AggregationContainsPropertyEqual setPropertyName(string sPropertyName);

						#endregion

						#region Methods for Property propertyValue

						/// <summary>
						/// Gets current value of property {@link #getPropertyValue propertyValue}.
						/// 
						/// The value of the Property that is used for matching.
						/// </summary>
						/// <returns>Value of property <code>propertyValue</code></returns>
						public extern virtual object getPropertyValue();

						/// <summary>
						/// Sets a new value for property {@link #getPropertyValue propertyValue}.
						/// 
						/// The value of the Property that is used for matching.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// </summary>
						/// <param name="oPropertyValue">New value for property <code>propertyValue</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.test.matchers.AggregationContainsPropertyEqual setPropertyValue(object oPropertyValue);

						#endregion

						#region Other methods

						/// <summary>
						/// Creates a new subclass of class sap.ui.test.matchers.AggregationContainsPropertyEqual with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.test.matchers.Matcher.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.test.matchers.AggregationContainsPropertyEqual with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.test.matchers.Matcher.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.test.matchers.AggregationContainsPropertyEqual with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.test.matchers.Matcher.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns a metadata object for class sap.ui.test.matchers.AggregationContainsPropertyEqual.
						/// </summary>
						/// <returns>Metadata object describing this class</returns>
						public extern static sap.ui.@base.Metadata getMetadata();

						/// <summary>
						/// Checks if the control has a filled aggregation with at least one control that have a property equaling propertyName/Value.
						/// </summary>
						/// <param name="oControl">the control that is checked by the matcher</param>
						/// <returns>true if the Aggregation set in the property aggregationName is filled, false if it is not.</returns>
						public extern override bool isMatching(sap.ui.core.Control oControl);

						#endregion

						#endregion

					}
				}
			}
		}
	}
}
