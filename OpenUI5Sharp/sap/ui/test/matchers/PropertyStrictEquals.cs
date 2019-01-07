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
					/// PropertyStrictEquals - checks if a property has the exact same value
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.test.matchers.PropertyStrictEquals")]
					public partial class PropertyStrictEquals : sap.ui.test.matchers.Matcher
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
							/// The Name of the property that is used for matching.
							/// </summary>
							public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> name;

							/// <summary>
							/// The value of the property that is used for matching.
							/// </summary>
							public Union<object, string, sap.ui.@base.ManagedObject.BindPropertyInfo> value;

						}

						#endregion

						#region Constructor

						/// <summary>
						/// PropertyStrictEquals - checks if a property has the exact same value.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="mSettings">optional map/JSON-object with initial settings for the new PropertyStrictEquals</param>
						public extern PropertyStrictEquals(sap.ui.test.matchers.PropertyStrictEquals.Settings mSettings);

						/// <summary>
						/// PropertyStrictEquals - checks if a property has the exact same value.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						public extern PropertyStrictEquals();

						#endregion

						#region Methods

						#region Methods for Property name

						/// <summary>
						/// Gets current value of property {@link #getName name}.
						/// 
						/// The Name of the property that is used for matching.
						/// </summary>
						/// <returns>Value of property <code>name</code></returns>
						public extern virtual string getName();

						/// <summary>
						/// Sets a new value for property {@link #getName name}.
						/// 
						/// The Name of the property that is used for matching.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// </summary>
						/// <param name="sName">New value for property <code>name</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.test.matchers.PropertyStrictEquals setName(string sName);

						#endregion

						#region Methods for Property value

						/// <summary>
						/// Gets current value of property {@link #getValue value}.
						/// 
						/// The value of the property that is used for matching.
						/// </summary>
						/// <returns>Value of property <code>value</code></returns>
						public extern virtual object getValue();

						/// <summary>
						/// Sets a new value for property {@link #getValue value}.
						/// 
						/// The value of the property that is used for matching.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// </summary>
						/// <param name="oValue">New value for property <code>value</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.test.matchers.PropertyStrictEquals setValue(object oValue);

						#endregion

						#region Other methods

						/// <summary>
						/// Creates a new subclass of class sap.ui.test.matchers.PropertyStrictEquals with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.test.matchers.Matcher.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.test.matchers.PropertyStrictEquals with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.test.matchers.Matcher.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.test.matchers.PropertyStrictEquals with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.test.matchers.Matcher.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns a metadata object for class sap.ui.test.matchers.PropertyStrictEquals.
						/// </summary>
						/// <returns>Metadata object describing this class</returns>
						[Name("getMetadata")]
						public extern static sap.ui.@base.Metadata getMetadataStatic();

						/// <summary>
						/// Checks if the control has a property that matches the value
						/// </summary>
						/// <param name="oControl">the control that is checked by the matcher</param>
						/// <returns>true if the property has a strictly matching value.</returns>
						public extern override bool isMatching(sap.ui.core.Control oControl);

						#endregion

						#endregion

					}
				}
			}
		}
	}
}
