﻿using System;
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
					/// AggregationLengthEquals - checks if an aggregation contains a specified number of entries.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.test.matchers.AggregationLengthEquals")]
					public partial class AggregationLengthEquals : sap.ui.test.matchers.Matcher
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
							/// The name of the aggregation that is used for matching.
							/// </summary>
							public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> name;

							/// <summary>
							/// The length that aggregation <code>name</code> should have.
							/// </summary>
							public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> length;

						}

						#endregion

						#region Constructor

						/// <summary>
						/// AggregationLengthEquals - checks if an aggregation contains a specified number of entries.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="mSettings">optional map/JSON-object with initial settings for the new AggregationLengthEqualsMatcher</param>
						public extern AggregationLengthEquals(sap.ui.test.matchers.AggregationLengthEquals.Settings mSettings);

						/// <summary>
						/// AggregationLengthEquals - checks if an aggregation contains a specified number of entries.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						public extern AggregationLengthEquals();

						#endregion

						#region Methods

						#region Methods for Property name

						/// <summary>
						/// Gets current value of property {@link #getName name}.
						/// 
						/// The name of the aggregation that is used for matching.
						/// </summary>
						/// <returns>Value of property <code>name</code></returns>
						public extern virtual string getName();

						/// <summary>
						/// Sets a new value for property {@link #getName name}.
						/// 
						/// The name of the aggregation that is used for matching.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// </summary>
						/// <param name="sName">New value for property <code>name</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.test.matchers.AggregationLengthEquals setName(string sName);

						#endregion

						#region Methods for Property length

						/// <summary>
						/// Gets current value of property {@link #getLength length}.
						/// 
						/// The length that aggregation <code>name</code> should have.
						/// </summary>
						/// <returns>Value of property <code>length</code></returns>
						public extern virtual int getLength();

						/// <summary>
						/// Sets a new value for property {@link #getLength length}.
						/// 
						/// The length that aggregation <code>name</code> should have.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// </summary>
						/// <param name="iLength">New value for property <code>length</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.test.matchers.AggregationLengthEquals setLength(int iLength);

						#endregion

						#region Other methods

						/// <summary>
						/// Creates a new subclass of class sap.ui.test.matchers.AggregationLengthEquals with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.test.matchers.Matcher.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.test.matchers.AggregationLengthEquals with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.test.matchers.Matcher.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.test.matchers.AggregationLengthEquals with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.test.matchers.Matcher.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns a metadata object for class sap.ui.test.matchers.AggregationLengthEquals.
						/// </summary>
						/// <returns>Metadata object describing this class</returns>
						[Name("getMetadata")]
						public extern static sap.ui.@base.Metadata getMetadataStatic();

						/// <summary>
						/// Checks if the control's aggregation <code>name</code> has length <code>length</code>.
						/// </summary>
						/// <param name="oControl">the control that is checked by the matcher</param>
						/// <returns>true if the length of aggregation <code>name</code> is the same as <code>length</code>, false if it is not.</returns>
						public extern override bool isMatching(sap.ui.core.Control oControl);

						#endregion

						#endregion

					}
				}
			}
		}
	}
}
