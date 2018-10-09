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
			public static partial class core
			{
				/// <summary>
				/// Fragments support the definition of light-weight stand-alone UI control trees. This class acts as factory which returns the UI control tree defined inside the Fragments. When used within declarative Views, the Fragment content is imported and seamlessly integrated into the View.
				/// 
				/// Fragments are used similar as sap.ui.core.mvc.Views, but Fragments do not have a Controller on their own (they may know one, though), they are not a Control, they are not part of the UI tree and they have no representation in HTML. By default, in contrast to declarative Views, they do not do anything to guarantee ID uniqueness.
				/// 
				/// But like Views they can be defined in several Formats (XML, declarative HTML, JavaScript; support for other types can be plugged in), the declaration syntax is the same as in declarative Views and the name and location of the Fragment files is similar to Views. Controller methods can also be referenced in the declarations, but as Fragments do not have their own controllers, this requires the Fragments to be used within a View which does have a controller. That controller is used, then.
				/// 
				/// Do not call the Fragment constructor directly!
				/// 
				/// Use-cases for Fragments are e.g.: - Modularization of UIs without fragmenting the controller structure - Re-use of UI parts - 100%-declarative definition of Views
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.core.Fragment")]
				public partial class Fragment : sap.ui.@base.ManagedObject
				{
					#region Settings

					/// <summary>
					/// Settings class to create the object
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class Settings : sap.ui.@base.ManagedObject.Settings
					{
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> fragmentName;

						public Union<object, string, sap.ui.@base.ManagedObject.BindPropertyInfo> fragmentContent;

						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> type;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern Fragment();

					#endregion

					#region Methods

					#region Methods for Property type

					/// <summary>
					/// Gets current value of property {@link #getType type}.
					/// </summary>
					/// <returns>Value of property <code>type</code></returns>
					public extern virtual string getType();

					/// <summary>
					/// Sets a new value for property {@link #getType type}.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sType">New value for property <code>type</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.Fragment setType(string sType);

					#endregion

					#region Other methods

					/// <summary>
					/// Returns an Element/Control by its ID in the context of the Fragment with the given ID
					/// </summary>
					/// <param name="sFragmentId"></param>
					/// <param name="sId"></param>
					/// <returns>Element by its ID and Fragment ID</returns>
					public extern static void byId(string sFragmentId, string sId);

					/// <summary>
					/// Returns the ID which a Control with the given ID in the context of the Fragment with the given ID would have
					/// </summary>
					/// <param name="sFragmentId"></param>
					/// <param name="sId"></param>
					/// <returns>the prefixed ID</returns>
					public extern static void createId(string sFragmentId, string sId);

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.Fragment with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.ManagedObject.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.Fragment with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.ManagedObject.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.Fragment with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.ManagedObject.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.core.Fragment.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					/// <summary>
					/// Registers a new Fragment type
					/// </summary>
					/// <param name="sType">the Fragment type. Types "XML", "HTML" and JS" are built-in and always available.</param>
					/// <param name="oFragmentImpl">an object having a property "init" of type "function" which is called on Fragment instantiation with the settings map as argument</param>
					public extern static void registerType(string sType, object oFragmentImpl);

					#endregion

					#endregion

				}
			}
		}
	}
}
