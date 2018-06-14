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
				/// Metadata for a class.
				/// </summary>
				[External]
				[Namespace(false)]
				public partial class Metadata
				{
					#region Constructor

					/// <summary>
					/// Creates a new metadata object from the given static infos.
					/// 
					/// Note: throughout this class documentation, the described subclass of Object is referenced as <i>the described class</i>.
					/// </summary>
					/// <param name="sClassName">fully qualified name of the described class</param>
					/// <param name="oClassInfo">info to construct the class and its metadata from</param>
					public extern Metadata(string sClassName, object oClassInfo);

					#endregion

					#region Methods

					/// <summary>
					/// Returns an array with the names of all public methods declared by the described class and its ancestors.
					/// </summary>
					/// <returns>array with names of all public methods provided by the described class and its ancestors</returns>
					public extern virtual string[] getAllPublicMethods();

					/// <summary>
					/// Returns the (constructor of the) described class
					/// </summary>
					/// <returns>class described by this metadata</returns>
					public extern virtual object getClass();

					/// <summary>
					/// Returns the fully qualified name of the described class
					/// </summary>
					/// <returns>name of the described class</returns>
					public extern virtual string getName();

					/// <summary>
					/// Returns the metadata object of the base class of the described class or null if the class has no (documented) base class.
					/// </summary>
					/// <returns>metadata of the base class</returns>
					public extern virtual sap.ui.@base.Metadata getParent();

					/// <summary>
					/// Returns an array with the names of the public methods declared by the described class.
					/// </summary>
					/// <returns>array with names of public methods declared by the described class</returns>
					public extern virtual string[] getPublicMethods();

					/// <summary>
					/// Checks whether the class described by this metadata object is of the named type.
					/// 
					/// This check is solely based on the type names as declared in the class metadata. It compares the given <code>vTypeName</code> with the name of this class, with the names of any base class of this class and with the names of all interfaces implemented by any of the aforementioned classes.
					/// 
					/// Instead of a single type name, an array of type names can be given and the method will check if this class is of any of the listed types (logical or).
					/// 
					/// Should the UI5 class system in future implement additional means of associating classes with type names (e.g. by introducing mixins), then this method might detect matches for those names as well.
					/// </summary>
					/// <param name="vTypeName">Type or types to check for</param>
					/// <returns>Whether this class is of the given type or of any of the given types</returns>
					public extern virtual bool isA(Union<string, string[]> vTypeName);

					/// <summary>
					/// Returns whether the described class is abstract
					/// </summary>
					/// <returns>whether the class is abstract</returns>
					public extern virtual bool isAbstract();

					/// <summary>
					/// Whether the described class is deprecated and should not be used any more
					/// </summary>
					/// <returns>whether the class is considered deprecated</returns>
					public extern virtual bool isDeprecated();

					/// <summary>
					/// Returns whether the described class is final
					/// </summary>
					/// <returns>whether the class is final</returns>
					public extern virtual bool isFinal();

					/// <summary>
					/// Checks whether the described class or one of its ancestor classes implements the given interface.
					/// </summary>
					/// <param name="sInterface">name of the interface to test for (in dot notation)</param>
					/// <returns>whether this class implements the interface</returns>
					public extern virtual bool isInstanceOf(string sInterface);

					#endregion

				}
			}
		}
	}
}
