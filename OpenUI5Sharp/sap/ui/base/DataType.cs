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
			public static partial class @base
			{
				/// <summary>
				/// Represents the type of properties in a <code>ManagedObject</code> class.
				/// 
				/// Each type provides some metadata like its {@link #getName qualified name} or its {@link #getBaseType base type} in case of a derived type. Array types provide information about the allowed {@link #getComponentType type of components} in an array, enumeration types inform about the set of their allowed {@link #getEnumValues keys and values}.
				/// 
				/// Each type has a method to {@link #isValid check whether a value is valid} for a property of that type.
				/// 
				/// Already defined types can be looked up by calling {@link #.getType DataType.getType}, new types can only be created by calling the factory method {@link #.createType DataType.createType}, calling the constructor will throw an error.
				/// </summary>
				[External]
				[Namespace(false)]
				public partial class DataType
				{
					#region Typed Parameters

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class CreateTypeInfo
					{
						/// <summary>
						/// Default value for the type (inherited if not given)
						/// </summary>
						public object defaultValue;

						/// <summary>
						/// Additional validity check function for values of the type (inherited if not given)
						/// </summary>
						public object isValid;

						/// <summary>
						/// Parse function that converts a locale independent string into a value of the type (inherited if not given)
						/// </summary>
						public object parseValue;

					}

					#endregion

					#region Methods

					/// <summary>
					/// Derives a new type from a given base type.
					/// 
					/// Example:<br> <pre>
					/// 
					///   var fooType = DataType.createType('foo', {
					///       isValid : function(vValue) {
					///           return /^(foo(bar)?)$/.test(vValue);
					///       }
					///   }, DataType.getType('string'));
					/// 
					///   fooType.isValid('foo'); // true
					///   fooType.isValid('foobar'); // true
					///   fooType.isValid('==foobar=='); // false
					/// 
					/// </pre>
					/// 
					/// If <code>mSettings</code> contains an implementation for <code>isValid</code>, then the validity check of the newly created type will first execute the check of the base type and then call the given <code>isValid</code> function.
					/// 
					/// Array types and enumeration types cannot be created with this method. They're created on-the-fly by {@link #.getType DataType.getType} when such a type is looked up.
					/// 
					/// <b>Note:</b> The creation of new primitive types is not supported. When a type is created without a base type, it is automatically derived from the primitive type <code>any</code>.
					/// 
					/// <b>Note:</b> If a type has to be used in classes tagged with <code>@ui5-metamodel</code>, then the implementation of <code>isValid</code> must exactly have the structure shown in the example above (single return statement, regular expression literal of the form <code>/^(...)$/</code>, calling <code>/regex/.test()</code> on the given value). Only the inner part of the regular expression literal can be different.
					/// </summary>
					/// <param name="sName">Unique qualified name of the new type</param>
					/// <param name="mSettings">Settings for the new type</param>
					/// <param name="@base">Base type for the new type</param>
					/// <returns>The newly created type object</returns>
					public extern static sap.ui.@base.DataType createType(string sName, sap.ui.@base.DataType.CreateTypeInfo mSettings, Union<sap.ui.@base.DataType, string> @base);

					/// <summary>
					/// Derives a new type from a given base type.
					/// 
					/// Example:<br> <pre>
					/// 
					///   var fooType = DataType.createType('foo', {
					///       isValid : function(vValue) {
					///           return /^(foo(bar)?)$/.test(vValue);
					///       }
					///   }, DataType.getType('string'));
					/// 
					///   fooType.isValid('foo'); // true
					///   fooType.isValid('foobar'); // true
					///   fooType.isValid('==foobar=='); // false
					/// 
					/// </pre>
					/// 
					/// If <code>mSettings</code> contains an implementation for <code>isValid</code>, then the validity check of the newly created type will first execute the check of the base type and then call the given <code>isValid</code> function.
					/// 
					/// Array types and enumeration types cannot be created with this method. They're created on-the-fly by {@link #.getType DataType.getType} when such a type is looked up.
					/// 
					/// <b>Note:</b> The creation of new primitive types is not supported. When a type is created without a base type, it is automatically derived from the primitive type <code>any</code>.
					/// 
					/// <b>Note:</b> If a type has to be used in classes tagged with <code>@ui5-metamodel</code>, then the implementation of <code>isValid</code> must exactly have the structure shown in the example above (single return statement, regular expression literal of the form <code>/^(...)$/</code>, calling <code>/regex/.test()</code> on the given value). Only the inner part of the regular expression literal can be different.
					/// </summary>
					/// <param name="sName">Unique qualified name of the new type</param>
					/// <param name="mSettings">Settings for the new type</param>
					/// <returns>The newly created type object</returns>
					public extern static sap.ui.@base.DataType createType(string sName, sap.ui.@base.DataType.CreateTypeInfo mSettings);

					/// <summary>
					/// Derives a new type from a given base type.
					/// 
					/// Example:<br> <pre>
					/// 
					///   var fooType = DataType.createType('foo', {
					///       isValid : function(vValue) {
					///           return /^(foo(bar)?)$/.test(vValue);
					///       }
					///   }, DataType.getType('string'));
					/// 
					///   fooType.isValid('foo'); // true
					///   fooType.isValid('foobar'); // true
					///   fooType.isValid('==foobar=='); // false
					/// 
					/// </pre>
					/// 
					/// If <code>mSettings</code> contains an implementation for <code>isValid</code>, then the validity check of the newly created type will first execute the check of the base type and then call the given <code>isValid</code> function.
					/// 
					/// Array types and enumeration types cannot be created with this method. They're created on-the-fly by {@link #.getType DataType.getType} when such a type is looked up.
					/// 
					/// <b>Note:</b> The creation of new primitive types is not supported. When a type is created without a base type, it is automatically derived from the primitive type <code>any</code>.
					/// 
					/// <b>Note:</b> If a type has to be used in classes tagged with <code>@ui5-metamodel</code>, then the implementation of <code>isValid</code> must exactly have the structure shown in the example above (single return statement, regular expression literal of the form <code>/^(...)$/</code>, calling <code>/regex/.test()</code> on the given value). Only the inner part of the regular expression literal can be different.
					/// </summary>
					/// <param name="sName">Unique qualified name of the new type</param>
					/// <returns>The newly created type object</returns>
					public extern static sap.ui.@base.DataType createType(string sName);

					/// <summary>
					/// The base type of this type or undefined if this is a primitive type.
					/// </summary>
					/// <returns>Base type or <code>undefined</code></returns>
					public extern virtual sap.ui.@base.DataType getBaseType();

					/// <summary>
					/// Returns the component type of this type or <code>undefined</code> if this is not an array type.
					/// </summary>
					/// <returns>Component type or <code>undefined</code></returns>
					public extern virtual sap.ui.@base.DataType getComponentType();

					/// <summary>
					/// The default value for this type. Each type must define a default value.
					/// </summary>
					/// <returns>Default value of the data type. The type of the returned value must match the JavaScript type of the data type (a string for string types etc.)</returns>
					public extern virtual object getDefaultValue();

					/// <summary>
					/// Returns the object with keys and values from which this enum type was created or <code>undefined</code> if this is not an enum type.
					/// </summary>
					/// <returns>Object with enum keys and values or <code>undefined</code></returns>
					public extern virtual object getEnumValues();

					/// <summary>
					/// The qualified name of the data type.
					/// </summary>
					/// <returns>Name of the data type</returns>
					public extern virtual string getName();

					/// <summary>
					/// Returns the most basic (primitive) type that this type has been derived from.
					/// 
					/// If the type is a primitive type by itself, <code>this</code> is returned.
					/// </summary>
					/// <returns>Primitive type of this type</returns>
					public extern virtual sap.ui.@base.DataType getPrimitiveType();

					/// <summary>
					/// Looks up the type with the given name and returns it.
					/// 
					/// See {@link topic:ac56d92162ed47ff858fdf1ce26c18c4 Defining Control Properties} for a list of the built-in primitive types and their semantics.
					/// 
					/// The lookup consists of the following steps: <ul> <li>When a type with the given name is already known, it will be returned</li> <li>When the name ends with a pair of brackets (<code>[]</code>), a type with the name in front of the brackets (<code>name.slice(0,-2)</code>) will be looked up and an array type will be created with the looked-up type as its component type. If the component type is <code>undefined</code>, <code>undefined</code> will be returned</li> <li>When a global property exists with the same name as the type and when the value of that property is an instance of <code>DataType</code>, that instance will be returned</li> <li>When a global property exists with the same name as the type and when the value of that property is a plain object (its prototype is <code>Object</code>), then an enum type will be created, based on the keys and values in that object. The <code>parseValue</code> method of the type will accept any of the keys in the plain object and convert them to the corresponding value; <code>isValid</code> will accept any of the values from the plain object's keys. The <code>defaultValue</code> will be the value of the first key found in the plain object</li> <li>When a global property exist with any other, non-falsy value, a warning is logged and the primitive type 'any' is returned</li> <li>If no such global property exist, an error is logged and <code>undefined</code> is returned</li> </ul>
					/// 
					/// <b<Note:</b> UI Libraries and even components can introduce additional types. This method only checks for types that either have been defined already, or that describe arrays of values of an already defined type or types whose name matches the global name of a plain object (containing enum keys and values). This method doesn't try to load modules that might contain type definitions. So before being able to lookup and use a specific type, the module containing its definition has to be loaded. For that reason it is suggested that controls (or <code>ManagedObject</code> classes in general) declare a dependency to all modules (typically <code>some/lib/library.js</code> modules) that contain the type definitions needed by the specific control or class definition.
					/// </summary>
					/// <param name="sTypeName">Qualified name of the type to retrieve</param>
					/// <returns>Type object or <code>undefined</code> when no such type has been defined yet</returns>
					public extern static sap.ui.@base.DataType getType(string sTypeName);

					/// <summary>
					/// Whether this type is an array type.
					/// </summary>
					/// <returns>Whether this type is an array type</returns>
					public extern virtual bool isArrayType();

					/// <summary>
					/// Whether this type is an enumeration type.
					/// </summary>
					/// <returns>Whether this type is an enum type</returns>
					public extern virtual bool isEnumType();

					/// <param name="sType">name of type to check</param>
					/// <returns>whether the given type is known to be an interface type</returns>
					private extern static bool isInterfaceType(string sType);

					/// <summary>
					/// Checks whether the given value is valid for this type.
					/// 
					/// To be implemented by concrete types.
					/// </summary>
					/// <param name="vValue">Value to be checked</param>
					/// <returns>Whether the given value is valid for this data type (without conversion)</returns>
					public extern virtual bool isValid(object vValue);

					/// <summary>
					/// Normalizes the given value using the specified normalizer for this data type.
					/// 
					/// If no normalizer has been set, the original value is returned.
					/// </summary>
					/// <param name="oValue">Value to be normalized</param>
					/// <returns>Normalized value</returns>
					public extern virtual object normalize(object oValue);

					/// <summary>
					/// Parses the given string value and converts it into the specific data type.
					/// </summary>
					/// <param name="sValue">String representation for a value of this type</param>
					/// <returns>Value in the correct internal format</returns>
					public extern virtual object parseValue(string sValue);

					/// <summary>
					/// Registers the given array of type names as known interface types. Only purpose is to enable the {@link #isInterfaceType} check.
					/// </summary>
					/// <param name="aTypes">interface types to be registered</param>
					private extern static void registerInterfaceTypes(string[] aTypes);

					/// <summary>
					/// Registers the given array of type names as known interface types. Only purpose is to enable the {@link #isInterfaceType} check.
					/// </summary>
					/// <param name="aTypes">interface types to be registered</param>
					private extern static void registerInterfaceTypes(object[] aTypes);

					/// <summary>
					/// Set or unset a normalizer function to be used for values of this data type.
					/// 
					/// When a normalizer function has been set, it will be applied to values of this type whenever {@link #normalize} is called. <code>ManagedObject.prototype.setProperty</code> calls the <code>normalize</code> method before setting a new value to a property (normalization is applied on-write, not on-read).
					/// 
					/// The <code>fnNormalize</code> function has the signature <pre>
					///   fnNormalize(value:any) : any
					/// </pre> It will be called with a value for this type and should return a normalized value (which also must be valid for the this type). There's no mean to reject a value. The <code>this</code> context of the function will be this type.
					/// 
					/// This method allows applications or application frameworks to plug-in a generic value normalization for a type, e.g. to convert all URLs in some app-specific way before they are applied to controls. It is not intended to break-out of the value range defined by a type.
					/// </summary>
					/// <param name="fnNormalizer">Function to apply for normalizing</param>
					public extern virtual void setNormalizer(object fnNormalizer);

					#endregion

				}
			}
		}
	}
}
