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
				/// Base class for all SAPUI5 Objects
				/// </summary>
				[External]
				[Namespace(false)]
				public abstract partial class Object
				{
					#region Typed Parameters

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class DefineClassInfo
					{
						/// <summary>
						/// qualified name of a base class
						/// </summary>
						public string baseType;

						/// <summary>
						/// array of names of public methods
						/// </summary>
						public string[] publicMethods;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for an sap.ui.base.Object.
					/// </summary>
					public extern Object();

					#endregion

					#region Methods

					/// <summary>
					/// Creates metadata for a given class and attaches it to the constructor and prototype of that class.
					/// 
					/// After creation, metadata can be retrieved with getMetadata().
					/// 
					/// The static info can at least contain the following entries: <ul> <li>baseType: {string} fully qualified name of a base class or empty</li> <li>publicMethods: {string} an array of method names that will be visible in the interface proxy returned by {@link #getInterface}</li> </ul>
					/// </summary>
					[Obsolete("Deprecated since 1.3.1. Use the static <code>extend</code> method of the desired base class (e.g. {@link sap.ui.base.Object.extend})")]
					/// <param name="sClassName">name of an (already declared) constructor function</param>
					/// <param name="oStaticInfo">static info used to create the metadata object</param>
					/// <param name="FNMetaImpl">constructor function for the metadata object. If not given, it defaults to sap.ui.base.Metadata.</param>
					/// <returns>the created metadata object</returns>
					public extern static sap.ui.@base.Metadata defineClass(string sClassName, sap.ui.@base.Object.DefineClassInfo oStaticInfo, object FNMetaImpl);

					/// <summary>
					/// Creates metadata for a given class and attaches it to the constructor and prototype of that class.
					/// 
					/// After creation, metadata can be retrieved with getMetadata().
					/// 
					/// The static info can at least contain the following entries: <ul> <li>baseType: {string} fully qualified name of a base class or empty</li> <li>publicMethods: {string} an array of method names that will be visible in the interface proxy returned by {@link #getInterface}</li> </ul>
					/// </summary>
					[Obsolete("Deprecated since 1.3.1. Use the static <code>extend</code> method of the desired base class (e.g. {@link sap.ui.base.Object.extend})")]
					/// <param name="sClassName">name of an (already declared) constructor function</param>
					/// <param name="oStaticInfo">static info used to create the metadata object</param>
					/// <returns>the created metadata object</returns>
					public extern static sap.ui.@base.Metadata defineClass(string sClassName, sap.ui.@base.Object.DefineClassInfo oStaticInfo);

					/// <summary>
					/// Destructor method for objects
					/// </summary>
					public extern virtual void destroy();

					/// <summary>
					/// Creates a subclass of class sap.ui.base.Object with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain three kinds of information: <ul> <li><code>metadata:</code> an (optional) object literal with metadata about the class. The information in the object literal will be wrapped by an instance of {@link sap.ui.base.Metadata Metadata} and might contain the following information <ul> <li><code>interfaces:</code> {string[]} (optional) set of names of implemented interfaces (defaults to no interfaces)</li> <li><code>publicMethods:</code> {string[]} (optional) list of methods that should be part of the public facade of the class</li> <li><code>abstract:</code> {boolean} (optional) flag that marks the class as abstract (purely informational, defaults to false)</li> <li><code>final:</code> {boolean} (optional) flag that marks the class as final (defaults to false)</li> </ul> Subclasses of sap.ui.base.Object can enrich the set of supported metadata (e.g. see {@link sap.ui.core.Element.extend}). </li>
					/// 
					/// <li><code>constructor:</code> a function that serves as a constructor function for the new class. If no constructor function is given, the framework creates a default implementation that delegates all its arguments to the constructor function of the base class. </li>
					/// 
					/// <li><i>any-other-name:</i> any other property in the <code>oClassInfo</code> is copied into the prototype object of the newly created class. Callers can thereby add methods or properties to all instances of the class. But be aware that the given values are shared between all instances of the class. Usually, it doesn't make sense to use primitive values here other than to declare public constants. </li>
					/// 
					/// </ul>
					/// 
					/// The prototype object of the newly created class uses the same prototype as instances of the base class (prototype chaining).
					/// 
					/// A metadata object is always created, even if there is no <code>metadata</code> entry in the <code>oClassInfo</code> object. A getter for the metadata is always attached to the prototype and to the class (constructor function) itself.
					/// 
					/// Last but not least, with the third argument <code>FNMetaImpl</code> the constructor of a metadata class can be specified. Instances of that class will be used to represent metadata for the newly created class and for any subclass created from it. Typically, only frameworks will use this parameter to enrich the metadata for a new class hierarchy they introduce (e.g. {@link sap.ui.core.Element.extend Element}).
					/// </summary>
					/// <param name="sClassName">name of the class to be created</param>
					/// <param name="oClassInfo">structured object with information about the class</param>
					/// <param name="FNMetaImpl">constructor function for the metadata object. If not given, it defaults to sap.ui.base.Metadata.</param>
					/// <returns>the created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a subclass of class sap.ui.base.Object with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain three kinds of information: <ul> <li><code>metadata:</code> an (optional) object literal with metadata about the class. The information in the object literal will be wrapped by an instance of {@link sap.ui.base.Metadata Metadata} and might contain the following information <ul> <li><code>interfaces:</code> {string[]} (optional) set of names of implemented interfaces (defaults to no interfaces)</li> <li><code>publicMethods:</code> {string[]} (optional) list of methods that should be part of the public facade of the class</li> <li><code>abstract:</code> {boolean} (optional) flag that marks the class as abstract (purely informational, defaults to false)</li> <li><code>final:</code> {boolean} (optional) flag that marks the class as final (defaults to false)</li> </ul> Subclasses of sap.ui.base.Object can enrich the set of supported metadata (e.g. see {@link sap.ui.core.Element.extend}). </li>
					/// 
					/// <li><code>constructor:</code> a function that serves as a constructor function for the new class. If no constructor function is given, the framework creates a default implementation that delegates all its arguments to the constructor function of the base class. </li>
					/// 
					/// <li><i>any-other-name:</i> any other property in the <code>oClassInfo</code> is copied into the prototype object of the newly created class. Callers can thereby add methods or properties to all instances of the class. But be aware that the given values are shared between all instances of the class. Usually, it doesn't make sense to use primitive values here other than to declare public constants. </li>
					/// 
					/// </ul>
					/// 
					/// The prototype object of the newly created class uses the same prototype as instances of the base class (prototype chaining).
					/// 
					/// A metadata object is always created, even if there is no <code>metadata</code> entry in the <code>oClassInfo</code> object. A getter for the metadata is always attached to the prototype and to the class (constructor function) itself.
					/// 
					/// Last but not least, with the third argument <code>FNMetaImpl</code> the constructor of a metadata class can be specified. Instances of that class will be used to represent metadata for the newly created class and for any subclass created from it. Typically, only frameworks will use this parameter to enrich the metadata for a new class hierarchy they introduce (e.g. {@link sap.ui.core.Element.extend Element}).
					/// </summary>
					/// <param name="sClassName">name of the class to be created</param>
					/// <param name="oClassInfo">structured object with information about the class</param>
					/// <returns>the created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a subclass of class sap.ui.base.Object with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain three kinds of information: <ul> <li><code>metadata:</code> an (optional) object literal with metadata about the class. The information in the object literal will be wrapped by an instance of {@link sap.ui.base.Metadata Metadata} and might contain the following information <ul> <li><code>interfaces:</code> {string[]} (optional) set of names of implemented interfaces (defaults to no interfaces)</li> <li><code>publicMethods:</code> {string[]} (optional) list of methods that should be part of the public facade of the class</li> <li><code>abstract:</code> {boolean} (optional) flag that marks the class as abstract (purely informational, defaults to false)</li> <li><code>final:</code> {boolean} (optional) flag that marks the class as final (defaults to false)</li> </ul> Subclasses of sap.ui.base.Object can enrich the set of supported metadata (e.g. see {@link sap.ui.core.Element.extend}). </li>
					/// 
					/// <li><code>constructor:</code> a function that serves as a constructor function for the new class. If no constructor function is given, the framework creates a default implementation that delegates all its arguments to the constructor function of the base class. </li>
					/// 
					/// <li><i>any-other-name:</i> any other property in the <code>oClassInfo</code> is copied into the prototype object of the newly created class. Callers can thereby add methods or properties to all instances of the class. But be aware that the given values are shared between all instances of the class. Usually, it doesn't make sense to use primitive values here other than to declare public constants. </li>
					/// 
					/// </ul>
					/// 
					/// The prototype object of the newly created class uses the same prototype as instances of the base class (prototype chaining).
					/// 
					/// A metadata object is always created, even if there is no <code>metadata</code> entry in the <code>oClassInfo</code> object. A getter for the metadata is always attached to the prototype and to the class (constructor function) itself.
					/// 
					/// Last but not least, with the third argument <code>FNMetaImpl</code> the constructor of a metadata class can be specified. Instances of that class will be used to represent metadata for the newly created class and for any subclass created from it. Typically, only frameworks will use this parameter to enrich the metadata for a new class hierarchy they introduce (e.g. {@link sap.ui.core.Element.extend Element}).
					/// </summary>
					/// <param name="sClassName">name of the class to be created</param>
					/// <returns>the created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns the public interface of the object.
					/// </summary>
					/// <returns>the public interface of the object</returns>
					public extern virtual sap.ui.@base.Interface getInterface();

					/// <summary>
					/// Returns the metadata for the class that this object belongs to.
					/// 
					/// This method is only defined when metadata has been declared by using {@link sap.ui.base.Object.defineClass} or {@link sap.ui.base.Object.extend}.
					/// </summary>
					/// <returns>metadata for the class of the object</returns>
					public extern virtual sap.ui.@base.Metadata getMetadata();

					/// <summary>
					/// Checks whether this object is an instance of the named type.
					/// 
					/// This check is solely based on the type names as declared in the class metadata. It compares the given <code>vTypeName</code> with the name of the class of this object, with the names of any base class of that class and with the names of all interfaces implemented by any of the aforementioned classes.
					/// 
					/// Instead of a single type name, an array of type names can be given and the method will check if this object is an instance of any of the listed types (logical or).
					/// 
					/// Should the UI5 class system in future implement additional means of associating classes with type names (e.g. by introducing mixins), then this method might detect matches for those names as well.
					/// </summary>
					/// <param name="vTypeName">Type or types to check for</param>
					/// <returns>Whether this object is an instance of the given type or of any of the given types</returns>
					public extern virtual bool isA(Union<string, string[]> vTypeName);

					/// <summary>
					/// Checks whether the given object is an instance of the named type. This function is a short-hand convenience for {@link sap.ui.base.Object#isA}.
					/// 
					/// Please see the API documentation of {@link sap.ui.base.Object#isA} for more details.
					/// </summary>
					/// <param name="oObject">Object which will be checked whether it is an instance of the given type</param>
					/// <param name="vTypeName">Type or types to check for</param>
					/// <returns>Whether the given object is an instance of the given type or of any of the given types</returns>
					public extern static bool isA(object oObject, Union<string, string[]> vTypeName);

					#endregion

				}
			}
		}
	}
}
