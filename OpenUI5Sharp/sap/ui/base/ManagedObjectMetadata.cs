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
			public static partial class @base
			{
				/// <summary>
				/// <strong>Note about Info Objects</strong>
				/// 
				/// Several methods in this class return info objects that describe a property, aggregation, association or event of the class described by this metadata object. The type, structure and behavior of these info objects is not yet documented and not part of the stable, public API.
				/// 
				/// Code using such methods and the returned info objects therefore needs to be aware of the following restrictions:
				/// 
				/// <ul> <li>the set of properties exposed by each info object, their type and value might change as well as the class of the info object itself.
				/// 
				/// Properties that represent settings provided during class definition (in the oClassInfo parameter of the 'extend' call, e.g. 'type', 'multiple' of an aggregation) are more likely to stay the same than additional, derived properties like '_iKind'.</li>
				/// 
				/// <li>info objects must not be modified / enriched although they technically could.</li>
				/// 
				/// <li>the period of validity of info objects is not defined. They should be referenced only for a short time and not be kept as members of long living objects or closures.</li>
				/// 
				/// </ul>
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.base.ManagedObjectMetadata")]
				public partial class ManagedObjectMetadata
				{
					#region Constructor

					/// <summary>
					/// Creates a new metadata object that describes a subclass of ManagedObject.
					/// 
					/// <b>Note:</b> Code outside the <code>sap.ui.base</code> namespace must not call this constructor directly. Instances will be created automatically when a new class is defined with one of the {@link sap.ui.base.ManagedObject.extend <i>SomeClass</i>.extend} methods.
					/// 
					/// <b>Note</b>: throughout this class documentation, the described subclass of ManagedObject is referenced as <i>the described class</i>.
					/// </summary>
					/// <param name="sClassName">fully qualified name of the described class</param>
					/// <param name="oClassInfo">static info to construct the metadata from</param>
					public extern ManagedObjectMetadata(string sClassName, object oClassInfo);

					#endregion

					#region Methods

					/// <summary>
					/// Adds information to the given oAggregatedObject about its original API parent (or a subsequent API parent in case of multiple forwarding).
					/// </summary>
					/// <param name="oAggregatedObject">Object to which the new API parent info should be added</param>
					/// <param name="oParent">Object that is a new API parent</param>
					/// <param name="sAggregationName">the name of the aggregation under which oAggregatedObject is aggregated by the API parent</param>
					public extern static void addAPIParentInfo(sap.ui.@base.ManagedObject oAggregatedObject, sap.ui.@base.ManagedObject oParent, string sAggregationName);

					/// <summary>
					/// Defines that an aggregation <code>sForwardedSourceAggregation</code> of the ManagedObject described by this metadata should be "forwarded" to an aggregation of an internal element within the composite.
					/// 
					/// This means that all adding, removal, or other operations happening on the source aggregation are actually called on the target instance. All elements added to the source aggregation will be located at the target aggregation (this means the target instance is their parent). Both, source and target element will return the added elements when asked for the content of the respective aggregation. If present, the named (non-generic) aggregation methods will be called for the target aggregation.
					/// 
					/// When the source aggregation is bound, the binding will by default take place there and the add/remove operations will be forwarded to the target. However, optionally the binding can also be forwarded. The result is similar - all added/bound items will reside at the target - but when the binding is forwarded, the updateAggregation method is called on the target element and the add/remove methods are only called on the target element as well.
					/// 
					/// Aggregations can only be forwarded to other aggregations of the same multiplicity (single/multiple). The target aggregation must also be "compatible" to the source aggregation in the sense that any items given to the source aggregation must also be valid in the target aggregation (otherwise the target element will throw a validation error).
					/// 
					/// If the forwarded elements use data binding, the target element must be properly aggregated by the source element to make sure all models are available there as well (this is anyway important to avoid issues).
					/// 
					/// The aggregation target must remain the same instance across the entire lifetime of the source control.
					/// 
					/// Aggregation forwarding must be set up before any instances of the control are created (recommended: within the class definition) to avoid situations where forwarding is not yet set up when the first aggregated item is added.
					/// 
					/// Aggregation forwarding will behave unexpectedly when the content in the target aggregation is modified by other actors (e.g. by the target element or by another forwarding from a different source aggregation). Hence, this is not allowed.
					/// 
					/// For any given source aggregation this method may only be called once. Calling it again overrides the previous forwarding, but leaves any already forwarded elements at their previous target.
					/// </summary>
					/// <param name="sForwardedSourceAggregation">The name of the aggregation to be forwarded</param>
					/// <param name="mOptions">The forwarding target as well as additional options</param>
					private extern void forwardAggregation(string sForwardedSourceAggregation, object mOptions);

					/// <summary>
					/// Returns an info object for the named public aggregation of the described class no matter whether the aggregation was defined by the class itself or by one of its ancestor classes.
					/// 
					/// If neither the class nor its ancestor classes define a public aggregation with the given name, <code>undefined</code> is returned.
					/// 
					/// If the name is not given (or has a falsy value), then it is substituted by the name of the default aggregation of the 'described class' (if any).
					/// 
					/// <b>Warning:</b> Type, structure and behavior of the returned info objects is not documented and therefore not part of the API. See the {@link #constructor Notes about Info objects} in the constructor documentation of this class.
					/// </summary>
					/// <param name="sName">name of the aggregation or empty</param>
					/// <returns>An info object describing the aggregation or <code>undefined</code></returns>
					public extern virtual object getAggregation(string sName);

					/// <summary>
					/// Returns an info object for the named public aggregation of the described class no matter whether the aggregation was defined by the class itself or by one of its ancestor classes.
					/// 
					/// If neither the class nor its ancestor classes define a public aggregation with the given name, <code>undefined</code> is returned.
					/// 
					/// If the name is not given (or has a falsy value), then it is substituted by the name of the default aggregation of the 'described class' (if any).
					/// 
					/// <b>Warning:</b> Type, structure and behavior of the returned info objects is not documented and therefore not part of the API. See the {@link #constructor Notes about Info objects} in the constructor documentation of this class.
					/// </summary>
					/// <returns>An info object describing the aggregation or <code>undefined</code></returns>
					public extern virtual object getAggregation();

					/// <summary>
					/// Returns a map of info objects for the public aggregations of the described class. Aggregations declared by ancestor classes are not included.
					/// 
					/// The returned map keys the aggregation info objects by their name. In case of 0..1 aggregations this is the singular name, otherwise it is the plural name.
					/// 
					/// <b>Warning:</b> Type, structure and behavior of the returned info objects is not documented and therefore not part of the API. See the {@link #constructor Notes about Info objects} in the constructor documentation of this class.
					/// </summary>
					/// <returns>Map of aggregation info objects keyed by aggregation names</returns>
					public extern virtual Map getAggregations();

					/// <summary>
					/// Returns a map of info objects for all public aggregations of the described class, including public aggregations form the ancestor classes.
					/// 
					/// The returned map keys the aggregation info objects by their name. In case of 0..1 aggregations this is the singular name, otherwise it is the plural name.
					/// 
					/// <b>Warning:</b> Type, structure and behavior of the returned info objects is not documented and therefore not part of the API. See the {@link #constructor Notes about Info objects} in the constructor documentation of this class.
					/// </summary>
					/// <returns>Map of aggregation info objects keyed by aggregation names</returns>
					public extern virtual Map getAllAggregations();

					/// <summary>
					/// Returns a map of info objects for all public associations of the described class, including public associations form the ancestor classes.
					/// 
					/// The returned map keys the association info objects by their name. In case of 0..1 associations this is the singular name, otherwise it is the plural name.
					/// 
					/// <b>Warning:</b> Type, structure and behavior of the returned info objects is not documented and therefore not part of the API. See the {@link #constructor Notes about Info objects} in the constructor documentation of this class.
					/// </summary>
					/// <returns>Map of association info objects keyed by association names</returns>
					public extern virtual Map getAllAssociations();

					/// <summary>
					/// Returns a map of info objects for all public events of the described class, including public events form the ancestor classes.
					/// 
					/// The returned map keys the event info objects by their name.
					/// 
					/// <b>Warning:</b> Type, structure and behavior of the returned info objects is not documented and therefore not part of the API. See the {@link #constructor Notes about Info objects} in the constructor documentation of this class.
					/// </summary>
					/// <returns>Map of event info objects keyed by event names</returns>
					public extern virtual Map getAllEvents();

					/// <summary>
					/// Returns a map of info objects for all private (hidden) aggregations of the described class, including private aggregations from the ancestor classes.
					/// 
					/// The returned map contains aggregation info objects keyed by the aggregation name. In case of 0..1 aggregations this is the singular name, otherwise it is the plural name.
					/// 
					/// <b>Warning:</b> Type, structure and behavior of the returned info objects is not documented and therefore not part of the API. See the {@link #constructor Notes about Info objects} in the constructor documentation of this class.
					/// </summary>
					/// <returns>Map of aggregation infos keyed by aggregation names</returns>
					public extern virtual Map getAllPrivateAggregations();

					/// <summary>
					/// Returns a map of info objects for all public properties of the described class, including public properties from the ancestor classes.
					/// 
					/// The returned map keys the property info objects by their name.
					/// 
					/// <b>Warning:</b> Type, structure and behavior of the returned info objects is not documented and therefore not part of the API. See the {@link #constructor Notes about Info objects} in the constructor documentation of this class.
					/// </summary>
					/// <returns>Map of property info objects keyed by the property names</returns>
					public extern virtual Map getAllProperties();

					/// <summary>
					/// Returns an info object for the named public association of the described class, no matter whether the association was defined by the class itself or by one of its ancestor classes.
					/// 
					/// If neither the described class nor its ancestor classes define an association with the given name, <code>undefined</code> is returned.
					/// 
					/// <b>Warning:</b> Type, structure and behavior of the returned info objects is not documented and therefore not part of the API. See the {@link #constructor Notes about Info objects} in the constructor documentation of this class.
					/// </summary>
					/// <param name="sName">name of the association</param>
					/// <returns>An info object describing the association or <code>undefined</code></returns>
					public extern virtual object getAssociation(string sName);

					/// <summary>
					/// Returns a map of info objects for all public associations of the described class. Associations declared by ancestor classes are not included.
					/// 
					/// The returned map keys the association info objects by their name. In case of 0..1 associations this is the singular name, otherwise it is the plural name.
					/// 
					/// <b>Warning:</b> Type, structure and behavior of the returned info objects is not documented and therefore not part of the API. See the {@link #constructor Notes about Info objects} in the constructor documentation of this class.
					/// </summary>
					/// <returns>Map of association info objects keyed by association names</returns>
					public extern virtual Map getAssociations();

					/// <summary>
					/// Returns an info object for the named public event of the described class, no matter whether the event was defined by the class itself or by one of its ancestor classes.
					/// 
					/// If neither the described class nor its ancestor classes define an event with the given name, <code>undefined</code> is returned.
					/// 
					/// <b>Warning:</b> Type, structure and behavior of the returned info objects is not documented and therefore not part of the API. See the {@link #constructor Notes about Info objects} in the constructor documentation of this class.
					/// </summary>
					/// <param name="sName">name of the event</param>
					/// <returns>An info object describing the event or <code>undefined</code></returns>
					public extern virtual object getEvent(string sName);

					/// <summary>
					/// Returns a map of info objects for the public events of the described class. Events declared by ancestor classes are not included.
					/// 
					/// The returned map keys the event info objects by their name.
					/// 
					/// <b>Warning:</b> Type, structure and behavior of the returned info objects is not documented and therefore not part of the API. See the {@link #constructor Notes about Info objects} in the constructor documentation of this class.
					/// </summary>
					/// <returns>Map of event info objects keyed by event names</returns>
					public extern virtual Map getEvents();

					/// <summary>
					/// Returns the name of the library that contains the described UIElement.
					/// </summary>
					/// <returns>the name of the library</returns>
					public extern virtual string getLibraryName();

					/// <summary>
					/// Returns the info object for the named public or private aggregation declared by the described class or by any of its ancestors.
					/// 
					/// If the name is not given (or has a falsy value), then it is substituted by the name of the default aggregation of the described class (if it is defined).
					/// 
					/// <b>Warning:</b> Type, structure and behavior of the returned info objects is not documented and therefore not part of the API. See the {@link #constructor Notes about Info objects} in the constructor documentation of this class.
					/// </summary>
					/// <param name="sAggregationName">name of the aggregation to be retrieved or empty</param>
					/// <returns>aggregation info object or undefined</returns>
					public extern virtual object getManagedAggregation(string sAggregationName);

					/// <summary>
					/// Returns a map of info objects for the public properties of the described class. Properties declared by ancestor classes are not included.
					/// 
					/// The returned map keys the property info objects by their name.
					/// 
					/// <b>Warning:</b> Type, structure and behavior of the returned info objects is not documented and therefore not part of the API. See the {@link #constructor Notes about Info objects} in the constructor documentation of this class.
					/// </summary>
					/// <returns>Map of property info objects keyed by the property names</returns>
					public extern virtual Map getProperties();

					/// <summary>
					/// Returns an info object for the named public property of the described class, no matter whether the property was defined by the class itself or by one of its ancestor classes.
					/// 
					/// If neither the described class nor its ancestor classes define a property with the given name, <code>undefined</code> is returned.
					/// 
					/// <b>Warning:</b> Type, structure and behavior of the returned info objects is not documented and therefore not part of the API. See the {@link #constructor Notes about Info objects} in the constructor documentation of this class.
					/// </summary>
					/// <param name="sName">name of the property</param>
					/// <returns>An info object describing the property or <code>undefined</code></returns>
					public extern virtual object getProperty(string sName);

					/// <summary>
					/// Returns a map of default values for all properties declared by the described class and its ancestors, keyed by the property name.
					/// </summary>
					/// <returns>Map of default values keyed by property names</returns>
					public extern virtual Map getPropertyDefaults();

					/// <summary>
					/// Returns an info object for a public setting with the given name that either is a managed property or a managed aggregation of cardinality 0..1 and with at least one simple alternative type. The setting can be defined by the class itself or by one of its ancestor classes.
					/// 
					/// If neither the described class nor its ancestor classes define a suitable setting with the given name, <code>undefined</code> is returned.
					/// 
					/// <b>Warning:</b> Type, structure and behavior of the returned info objects is not documented and therefore not part of the API. See the {@link #constructor Notes about Info objects} in the constructor documentation of this class.
					/// </summary>
					/// <param name="sName">name of the property like setting</param>
					/// <returns>An info object describing the property or aggregation or <code>undefined</code></returns>
					public extern virtual object getPropertyLikeSetting(string sName);

					/// <summary>
					/// Checks the existence of the given aggregation by its name.
					/// </summary>
					/// <param name="sName">name of the aggregation</param>
					/// <returns>true, if the aggregation exists</returns>
					public extern virtual bool hasAggregation(string sName);

					/// <summary>
					/// Checks the existence of the given association by its name
					/// </summary>
					/// <param name="sName">name of the association</param>
					/// <returns>true, if the association exists</returns>
					public extern virtual bool hasAssociation(string sName);

					/// <summary>
					/// Checks the existence of the given event by its name
					/// </summary>
					/// <param name="sName">name of the event</param>
					/// <returns>true, if the event exists</returns>
					public extern virtual bool hasEvent(string sName);

					/// <summary>
					/// Checks the existence of the given property by its name
					/// </summary>
					/// <param name="sName">name of the property</param>
					/// <returns>true, if the property exists</returns>
					public extern virtual bool hasProperty(string sName);

					/// <summary>
					/// Test whether a given ID looks like it was automatically generated.
					/// 
					/// Examples: <pre>
					/// True for:
					///   "foo--__bar04--baz"
					///   "foo--__bar04"
					///   "__bar04--baz"
					///   "__bar04"
					///   "__bar04--"
					///   "__bar04--foo"
					/// False for:
					///   "foo__bar04"
					///   "foo__bar04--baz"
					/// </pre>
					/// 
					/// See {@link sap.ui.base.ManagedObjectMetadata.prototype.uid} for details on ID generation.
					/// </summary>
					/// <param name="sId">the ID that should be tested</param>
					/// <returns>whether the ID is likely to be generated</returns>
					public extern static bool isGeneratedId(string sId);

					/// <summary>
					/// Load and returns the design time metadata asynchronously. It inherits/merges parent design time metadata and if provided merges also instance specific design time metadata that was provided via the dt namespace.
					/// 
					/// Be aware that ManagedObjects do not ensure to have unique IDs. This may lead to issues if you would like to persist DesignTime based information. In that case you need to take care of identification yourself.
					/// </summary>
					/// <param name="oManagedObject">instance that could have instance specific design time metadata</param>
					/// <param name="sScopeKey">scope name for which metadata will be resolved, see sap.ui.base.ManagedObjectMetadataScope</param>
					/// <returns>A promise which will return the loaded design time metadata</returns>
					private extern jquery.JQueryPromise<object> loadDesignTime(sap.ui.@base.ManagedObject oManagedObject, string sScopeKey);

					/// <summary>
					/// Load and returns the design time metadata asynchronously. It inherits/merges parent design time metadata and if provided merges also instance specific design time metadata that was provided via the dt namespace.
					/// 
					/// Be aware that ManagedObjects do not ensure to have unique IDs. This may lead to issues if you would like to persist DesignTime based information. In that case you need to take care of identification yourself.
					/// </summary>
					/// <param name="oManagedObject">instance that could have instance specific design time metadata</param>
					/// <returns>A promise which will return the loaded design time metadata</returns>
					private extern jquery.JQueryPromise<object> loadDesignTime(sap.ui.@base.ManagedObject oManagedObject);

					/// <summary>
					/// Load and returns the design time metadata asynchronously. It inherits/merges parent design time metadata and if provided merges also instance specific design time metadata that was provided via the dt namespace.
					/// 
					/// Be aware that ManagedObjects do not ensure to have unique IDs. This may lead to issues if you would like to persist DesignTime based information. In that case you need to take care of identification yourself.
					/// </summary>
					/// <returns>A promise which will return the loaded design time metadata</returns>
					private extern jquery.JQueryPromise<object> loadDesignTime();

					/// <summary>
					/// Load and returns the design time metadata asynchronously. It inherits/merges parent design time metadata and if provided merges also instance specific design time metadata that was provided via the dt namespace.
					/// 
					/// Be aware that ManagedObjects do not ensure to have unique IDs. This may lead to issues if you would like to persist DesignTime based information. In that case you need to take care of identification yourself.
					/// </summary>
					/// <param name="sScopeKey">scope name for which metadata will be resolved, see sap.ui.base.ManagedObjectMetadataScope</param>
					/// <returns>A promise which will return the loaded design time metadata</returns>
					private extern jquery.JQueryPromise<object> loadDesignTime(string sScopeKey);

					/// <summary>
					/// Calculates a new ID for an instance of this class.
					/// 
					/// Note that the calculated short name part is usually not unique across all classes, but doesn't have to be. It might even be empty when the class name consists of invalid characters only.
					/// </summary>
					/// <returns>A (hopefully unique) control ID</returns>
					public extern virtual string uid();

					/// <summary>
					/// Calculates a new ID based on a prefix.
					/// 
					/// To guarantee uniqueness of the generated IDs across all ID prefixes, prefixes must not end with digits.
					/// </summary>
					/// <param name="sIdPrefix">prefix for the new ID</param>
					/// <returns>A (hopefully unique) control id</returns>
					public extern static string uid(string sIdPrefix);

					#endregion

				}
			}
		}
	}
}
