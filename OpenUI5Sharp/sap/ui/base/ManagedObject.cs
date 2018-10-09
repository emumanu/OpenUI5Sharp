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
				/// Base Class that introduces some basic concepts like state management or databinding.
				/// 
				/// New subclasses of ManagedObject are created with a call to {@link #.extend ManagedObject.extend} and can make use of the following managed features:
				/// 
				/// <h3>Properties</h3> Managed properties represent the state of a ManagedObject. They can store a single value of a simple data type (like 'string' or 'int'). They have a <i>name</i> (e.g. 'size') and methods to get the current value (<code>getSize</code>), or to set a new value (<code>setSize</code>). When a property is modified, the ManagedObject is marked as invalidated. A managed property can be bound against a property in a {@link sap.ui.model.Model} by using the {@link #bindProperty} method. Updates to the model property will be automatically reflected in the managed property and - if TwoWay databinding is active, changes to the managed property will be reflected in the model. An existing binding can be removed by calling {@link #unbindProperty}.
				/// 
				/// If a ManagedObject is cloned, the clone will have the same values for its managed properties as the source of the clone - if the property wasn't bound. If it is bound, the property in the clone will be bound to the same model property as in the source.
				/// 
				/// Details about the declaration of a managed property, the metadata that describes it and the set of methods that are automatically generated to access it, can be found in the documentation of the {@link sap.ui.base.ManagedObject.extend extend } method.
				/// 
				/// <h3>Aggregations</h3> Managed aggregations can store one or more references to other ManagedObjects. They are a mean to control the lifecycle of the aggregated objects: one ManagedObject can be aggregated by at most one parent ManagedObject at any time. When a ManagedObject is destroyed, all aggregated objects are destroyed as well and the object itself is removed from its parent. That is, aggregations won't contain destroyed objects or null/undefined.
				/// 
				/// Aggregations have a <i>name</i> ('e.g 'header' or 'items'), a <i>cardinality</i> ('0..1' or '0..n') and are of a specific <i>type</i> (which must be a subclass of ManagedObject as well or a UI5 interface). A ManagedObject will provide methods to set or get the aggregated object for a specific aggregation of cardinality 0..1 (e.g. <code>setHeader</code>, <code>getHeader</code> for an aggregation named 'header'). For an aggregation of cardinality 0..n, there are methods to get all aggregated objects (<code>getItems</code>), to locate an object in the aggregation (e.g. <code>indexOfItem</code>), to add, insert or remove a single aggregated object (<code>addItem</code>, <code>insertItem</code>, <code>removeItem</code>) or to remove or destroy all objects from an aggregation (<code>removeAllItems</code>, <code>destroyItems</code>).
				/// 
				/// Details about the declaration of a managed aggregation, the metadata that describes the aggregation, and the set of methods that are automatically generated to access it, can be found in the documentation of the {@link sap.ui.base.ManagedObject.extend extend} method.
				/// 
				/// Aggregations of cardinality 0..n can be bound to a collection in a model by using {@link #bindAggregation} (and unbound again using {@link #unbindAggregation}). For each context in the model collection, a corresponding object will be created in the managed aggregation, either by cloning a template object or by calling a factory function.
				/// 
				/// Aggregations also control the databinding context of bound objects: by default, aggregated objects inherit all models and binding contexts from their parent object.
				/// 
				/// When a ManagedObject is cloned, all aggregated objects will be cloned as well - but only if they haven't been added by databinding. In that case, the aggregation in the clone will be bound to the same model collection.
				/// 
				/// <h3>Associations</h3> Managed associations also form a relationship between objects, but they don't define a lifecycle for the associated objects. They even can 'break' in the sense that an associated object might have been destroyed already although it is still referenced in an association. For the same reason, the internal storage for associations are not direct object references but only the IDs of the associated target objects.
				/// 
				/// Associations have a <i>name</i> ('e.g 'initialFocus'), a <i>cardinality</i> ('0..1' or '0..n') and are of a specific <i>type</i> (which must be a subclass of ManagedObject as well or a UI5 interface). A ManagedObject will provide methods to set or get the associated object for a specific association of cardinality 0..1 (e.g. <code>setInitialFocus</code>, <code>getInitialFocus</code>). For an association of cardinality 0..n, there are methods to get all associated objects (<code>getRefItems</code>), to add, insert or remove a single associated object (<code>addRefItem</code>, <code>insertRefItem</code>, <code>removeRefItem</code>) or to remove all objects from an association (<code>removeAllRefItems</code>).
				/// 
				/// Details about the declaration of a managed association, the metadata that describes it and the set of methods that are automatically generated to access it, can be found in the documentation of the {@link sap.ui.base.ManagedObject.extend extend} method.
				/// 
				/// Associations can't be bound to the model.
				/// 
				/// When a ManagedObject is cloned, the result for an association depends on the relationship between the associated target object and the root of the clone operation. If the associated object is part of the to-be-cloned object tree (reachable via aggregations from the root of the clone operation), then the cloned association will reference the clone of the associated object. Otherwise the association will reference the same object as in the original tree. When a ManagedObject is destroyed, other objects that are only associated, are not affected by the destroy operation.
				/// 
				/// <h3>Events</h3> Managed events provide a mean for communicating important state changes to an arbitrary number of 'interested' listeners. Events have a <i>name</i> and (optionally) a set of <i>parameters</i>. For each event there will be methods to add or remove an event listener as well as a method to fire the event. (e.g. <code>attachChange</code>, <code>detachChange</code>, <code>fireChange</code> for an event named 'change').
				/// 
				/// Details about the declaration of managed events, the metadata that describes the event, and the set of methods that are automatically generated to access it, can be found in the documentation of the {@link sap.ui.base.ManagedObject.extend extend} method.
				/// 
				/// When a ManagedObject is cloned, all listeners registered for any event in the clone source are also registered to the clone. Later changes are not reflected in any direction (neither from source to clone, nor vice versa).
				/// 
				/// <a name="lowlevelapi"><h3>Low Level APIs:</h3></a> The prototype of ManagedObject provides several generic, low level APIs to manage properties, aggregations, associations, and events. These generic methods are solely intended for implementing higher level, non-generic methods that manage a single managed property etc. (e.g. a function <code>setSize(value)</code> that sets a new value for property 'size'). {@link sap.ui.base.ManagedObject.extend} creates default implementations of those higher level APIs for all managed aspects. The implementation of a subclass then can override those default implementations with a more specific implementation, e.g. to implement a side effect when a specific property is set or retrieved. It is therefore important to understand that the generic low-level methods ARE NOT SUITABLE FOR GENERIC ACCESS to the state of a managed object, as that would bypass the overriding higher level methods and their side effects.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.base.ManagedObject")]
				public abstract partial class ManagedObject : sap.ui.@base.EventProvider
				{
					#region Settings

					/// <summary>
					/// Settings class to create the object
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class Settings
					{
						/// <summary>
						/// Unique ID of this instance. If not given, a so called autoID will be generated by the framework. AutoIDs use a unique prefix that must not be used for Ids that the application (or other code) creates. It can be configured option 'autoIDPrefix', see {@link sap.ui.core.Configuration}.
						/// </summary>
						public Union<sap.ui.core.ID, string, sap.ui.@base.ManagedObject.BindPropertyInfo> id;

						/// <summary>
						/// A map of model instances to which the object should be attached. The models are keyed by their model name. For the default model, String(undefined) is expected.
						/// </summary>
						public Union<object, string, sap.ui.@base.ManagedObject.BindPropertyInfo> models;

						/// <summary>
						/// A map of model instances to which the object should be attached. The models are keyed by their model name. For the default model, String(undefined) is expected.
						/// </summary>
						public Union<object, string, sap.ui.@base.ManagedObject.BindPropertyInfo> bindingContexts;

						/// <summary>
						/// A map of model instances to which the object should be attached. The models are keyed by their model name. For the default model, String(undefined) is expected.
						/// </summary>
						public Union<object, string, sap.ui.@base.ManagedObject.BindPropertyInfo> objectBindings;

						/// <summary>
						/// A map of model instances to which the object should be attached. The models are keyed by their model name. For the default model, String(undefined) is expected. The special setting is only for internal use.
						/// </summary>
						public Union<object, string, sap.ui.@base.ManagedObject.BindPropertyInfo> metadataContexts;

						/// <summary>
						/// Fired after a new value for a bound property has been propagated to the model. Only fired, when the binding uses a data type.
						/// </summary>
						public sap.ui.@base.ManagedObject.ValidationDelegate validationSuccess;

						/// <summary>
						/// Fired when a new value for a bound property should have been propagated to the model, but validating the value failed with an exception.
						/// </summary>
						public sap.ui.@base.ManagedObject.ErrorDelegate validationError;

						/// <summary>
						/// Fired when a new value for a bound property should have been propagated to the model, but parsing the value failed with an exception.
						/// </summary>
						public sap.ui.@base.ManagedObject.ErrorDelegate parseError;

						/// <summary>
						/// Fired when a new value for a bound property should have been propagated from the model, but formatting the value failed with an exception.
						/// </summary>
						public sap.ui.@base.ManagedObject.ErrorDelegate formatError;

						/// <summary>
						/// Fired when models or contexts are changed on this object (either by calling setModel/setBindingContext or due to propagation)
						/// </summary>
						public sap.ui.@base.EventDelegate modelContextChange;

					}

					#endregion

					#region Typed Parameters

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class ValidationInfo
					{
						/// <summary>
						/// ManagedObject instance whose property should have received the model update.
						/// </summary>
						public sap.ui.@base.ManagedObject element;

						/// <summary>
						/// Name of the property for which the binding should have been updated.
						/// </summary>
						public string property;

						/// <summary>
						/// Data type used in the binding (if any).
						/// </summary>
						public sap.ui.model.Type type;

						/// <summary>
						/// New value (model representation) as propagated from the model.
						/// </summary>
						public object newValue;

						/// <summary>
						/// Old value (external representation) as previously stored in the ManagedObject.
						/// </summary>
						public object oldValue;

					}

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class ErrorInfo
					{
						/// <summary>
						/// ManagedObject instance whose property initiated the model update.
						/// </summary>
						public sap.ui.@base.ManagedObject element;

						/// <summary>
						/// Name of the property for which the bound model property should have been been updated.
						/// </summary>
						public string property;

						/// <summary>
						/// Data type used in the binding.
						/// </summary>
						public sap.ui.model.Type type;

						/// <summary>
						/// New value (external representation) as parsed by the binding.
						/// </summary>
						public object newValue;

						/// <summary>
						/// Old value (external representation) as previously stored in the ManagedObject.
						/// </summary>
						public object oldValue;

						/// <summary>
						/// Localized message describing the parse error
						/// </summary>
						public string message;

					}

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class BindAggregationInfo
					{
						/// <summary>
						/// the binding path
						/// </summary>
						public string path;

						/// <summary>
						/// the template to clone for each item in the aggregation
						/// </summary>
						public sap.ui.@base.ManagedObject template;

						/// <summary>
						/// Whether the binding should be suspended
						/// </summary>
						public bool suspended;

						/// <summary>
						/// option to enable that the template will be shared which means that it won't be destroyed or cloned automatically
						/// </summary>
						public bool templateShareable;

						/// <summary>
						/// the factory function
						/// </summary>
						public sap.ui.@base.ManagedObject.FactoryDelegate factory;

						/// <summary>
						/// the first entry of the list to be created
						/// </summary>
						public int startIndex;

						/// <summary>
						/// the amount of entries to be created (may exceed the size limit of the model)
						/// </summary>
						public int length;

						/// <summary>
						/// the initial sort order (optional)
						/// </summary>
						public Union<sap.ui.model.Sorter, sap.ui.model.Sorter[]> sorter;

						/// <summary>
						/// the predefined filters for this aggregation (optional)
						/// </summary>
						public sap.ui.model.Filter[] filters;

						/// <summary>
						/// the name of the key property or a function getting the context as only parameter to calculate a key for entries. This can be used to improve update behaviour in models, where a key is not already available.
						/// </summary>
						public Union<string, object> key;

						/// <summary>
						/// a map of parameters which is passed to the binding. The supported parameters are listed in the corresponding model-specific implementation of <code>sap.ui.model.ListBinding</code> or <code>sap.ui.model.TreeBinding</code>.
						/// </summary>
						public object parameters;

						/// <summary>
						/// a factory function to generate custom group visualization (optional)
						/// </summary>
						public sap.ui.@base.ManagedObject.GroupHeaderFactoryDelegate groupHeaderFactory;

					}

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class BindObjectInfo
					{
						/// <summary>
						/// the binding path
						/// </summary>
						public string path;

						/// <summary>
						/// map of additional parameters for this binding The supported parameters are listed in the corresponding model-specific implementation of <code>sap.ui.model.ContextBinding</code>.
						/// </summary>
						public object parameters;

						/// <summary>
						/// name of the model
						/// </summary>
						public string model;

						/// <summary>
						/// Whether the binding should be suspended
						/// </summary>
						public bool suspended;

						/// <summary>
						/// map of event listeners for the binding events
						/// </summary>
						public object events;

					}

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class BindPropertyInfo
					{
						/// <summary>
						/// Path in the model to bind to, either an absolute path or relative to the binding context for the corresponding model
						/// </summary>
						public string path;

						/// <summary>
						/// Name of the model to bind against or <code>undefined</code> for the default model
						/// </summary>
						public string model;

						/// <summary>
						/// Whether the binding should be suspended
						/// </summary>
						public bool suspended;

						/// <summary>
						/// Function to convert model data into a property value
						/// </summary>
						public object formatter;

						/// <summary>
						/// Whether the parameters to the formatter function should be passed as raw values. In this case the specified types for the binding parts are not used and the values are not formatted.
						/// 
						/// <b>Note</b>: use this flag only when using multiple bindings. If you use only one binding and want raw values then simply don't specify a type for that binding.
						/// </summary>
						public bool useRawValues;

						/// <summary>
						/// Whether the parameters to the formatter function should be passed as the related JavaScript primitive values. In this case the values of the model are parsed by the {@link sap.ui.model.SimpleType#getModelFormat model format} of the specified types from the binding parts.
						/// 
						/// <b>Note</b>: use this flag only when using multiple bindings.
						/// </summary>
						public bool useInternalValues;

						/// <summary>
						/// A type object or the name of a type class to create such a type object; the type will be used for converting model data to a property value (aka "formatting") and vice versa (in binding mode <code>TwoWay</code>, aka "parsing")
						/// </summary>
						public Union<sap.ui.model.Type, string> type;

						/// <summary>
						/// Target type to be used by the type when formatting model data, for example "boolean" or "string" or "any"; defaults to the property's type
						/// </summary>
						public string targetType;

						/// <summary>
						/// Format options to be used for the type; only taken into account when the type is specified by its name - a given type object won't be modified
						/// </summary>
						public object formatOptions;

						/// <summary>
						/// Additional constraints to be used when constructing a type object from a type name, ignored when a type object is given
						/// </summary>
						public object constraints;

						/// <summary>
						/// Binding mode to be used for this property binding (e.g. one way)
						/// </summary>
						public sap.ui.model.BindingMode mode;

						/// <summary>
						/// Map of parameters which is passed to the binding; the supported parameters are listed in the corresponding model-specific implementation of <code>sap.ui.model.PropertyBinding</code>.
						/// </summary>
						public object parameters;

						/// <summary>
						/// Array of binding info objects for the parts of a composite binding; the structure of each binding info is the same as described for the <code>oBindingInfo</code> as a whole.
						/// 
						/// <b>Note</b>: recursive composite bindings are currently not supported
						/// </summary>
						public sap.ui.@base.ManagedObject.BindPropertyInfo[] parts;

					}

					#endregion

					#region Delegates

					public delegate void ValidationDelegate(sap.ui.@base.Event<sap.ui.@base.ManagedObject.ValidationInfo> oEvent, object oData);

					public delegate void ErrorDelegate(sap.ui.@base.Event<sap.ui.@base.ManagedObject.ErrorInfo> oEvent, object oData);

					#endregion

					#region Constructor

					/// <summary>
					/// Constructs and initializes a managed object with the given <code>sId</code> and settings.
					/// 
					/// If the optional <code>mSettings</code> are given, they must be a simple object that defines values for properties, aggregations, associations or events keyed by their name.
					/// 
					/// <b>Valid Names and Value Ranges:</b>
					/// 
					/// The property (key) names supported in the object literal are exactly the (case sensitive) names documented in the JSDoc for the properties, aggregations, associations and events of the current class and its base classes. Note that for 0..n aggregations and associations this name usually is the plural name, whereas it is the singular name in case of 0..1 relations.
					/// 
					/// If a key name is ambiguous for a specific managed object class (e.g. a property has the same name as an event), then this method prefers property, aggregation, association and event in that order. To resolve such ambiguities, the keys can be prefixed with <code>aggregation:</code>, <code>association:</code> or <code>event:</code> (such keys containing a colon (':') must be quoted to be valid Javascript).
					/// 
					/// The possible values for a setting depend on its kind: <ul> <li>for simple properties, the value has to match the documented type of the property (no type conversion occurs)</li> <li>for 0..1 aggregations, the value has to be an instance of the aggregated type</li> <li>for 0..n aggregations, the value has to be an array of instances of the aggregated type or a single instance</li> <li>for 0..1 associations, an instance of the associated type or an id (string) is accepted</li> <li>for 0..n associations, an array of instances of the associated type or of IDs is accepted</li> <li>for events either a function (event handler) is accepted or an array of length 2 where the first element is a function and the 2nd element is an object to invoke the method on.</li> </ul>
					/// 
					/// Each subclass should document the name and type of its supported settings in its constructor documentation.
					/// 
					/// Example usage: <pre>
					/// new Dialog({
					///    title: "Some title text",            // property of type "string"
					///    showHeader: true,                    // property of type "boolean"
					///    endButton: new Button(...),          // 0..1 aggregation
					///    content: [                           // 0..n aggregation
					///       new Input(...),
					///       new Input(...)
					///    ],
					///    afterClose: function(oEvent) { ... } // event handler function
					/// });
					/// </pre>
					/// 
					/// Instead of static values and object instances, data binding expressions can be used, either embedded in a string or as a binding info object as described in {@link #bindProperty} or {@link #bindAggregation}.
					/// 
					/// Example usage: <pre>
					/// new Dialog({
					///    title: "{/title}",       // embedded binding expression, points to a string property in the data model
					///    ...
					///    content: {               // binding info object
					///       path : "/inputItems", // points to a collection in the data model
					///       template : new Input(...)
					///    }
					/// });
					/// </pre>
					/// 
					/// Note that when setting string values, any curly braces in those values need to be escaped, so they are not interpreted as binding expressions. Use {@link #escapeSettingsValue} to do so.
					/// 
					/// Besides the settings documented below, ManagedObject itself supports the following special settings: <ul> <li><code>id : <i>sap.ui.core.ID</i></code> an ID for the new instance. Some subclasses (Element, Component) require the id to be unique in a specific scope (e.g. an Element Id must be unique across all Elements, a Component id must be unique across all Components). <li><code>models : <i>object</i></code> a map of {@link sap.ui.model.Model} instances keyed by their model name (alias). Each entry with key <i>k</i> in this object has the same effect as a call <code>this.setModel(models[k], k);</code>.</li> <li><code>bindingContexts : <i>object</i></code> a map of {@link sap.ui.model.Context} instances keyed by their model name. Each entry with key <i>k</i> in this object has the same effect as a call <code>this.setBindingContext(bindingContexts[k], k);</code></li> <li><code>objectBindings : <i>object</i></code> a map of binding paths keyed by the corresponding model name. Each entry with key <i>k</i> in this object has the same effect as a call <code>this.bindObject(objectBindings[k], k);</code></li> <li><code>metadataContexts : <i>object</i></code> an array of single binding contexts keyed by the corresponding model or context name. The purpose of the <code>metadataContexts</code> special setting is to deduce as much information as possible from the binding context of the control in order to be able to predefine certain standard properties like e.g. <i>visible, enabled, tooltip,...</i>
					/// 
					/// The structure is an array of single contexts, where a single context is a map containing the following keys: <ul> <li><code>path: <i>string (mandatory)</i></code> The path to the corresponding model property or object, e.g. '/Customers/Name'. A path can also be relative, e.g. 'Name'</li> <li><code>model: <i>string (optional)</i></code> The name of the model, in case there is no name then the undefined model is taken</li> <li><code>name: <i>string (optional)</i></code> A name for the context to used in templating phase</li> <li><code>kind: <i>string (optional)</i></code> The kind of the adapter, either <code>field</code> for single properties or <code>object</code> for structured contexts. <li><code>adapter: <i>string (optional)</i></code> The path to an interpretion class that dilivers control relevant data depending on the context, e.g. enabled, visible. If not supplied the OData meta data is interpreted.</li> </ul> The syntax for providing the <code>metadataContexts</code> is as follows: <code>{SINGLE_CONTEXT1},...,{SINGLE_CONTEXTn}</code> or for simplicity in case there is only one context <code>{SINGLE_CONTEXT}</code>.
					/// 
					/// Examples for such metadataContexts are: <ul> <li><code>{/Customers/Name}</code> a single part with an absolute path to the property <i>Name</i> of the <i>Customers</i> entity set in the default model</li> <li><code>{path: 'Customers/Name', model:'json'}</code> a single part with an absolute path to the property <i>Name</i> of the <i>Customers</i> entity set in a named model</li> <li><code>{parts: [{path: 'Customers/Name'},{path: 'editable', model: 'viewModel'}]}</code> a combination of single binding contexts, one context from the default model and one from the viewModel</li> </ul></li> </ul>
					/// </summary>
					/// <param name="sId">ID for the new managed object; generated automatically if no non-empty ID is given <b>Note:</b> this can be omitted, no matter whether <code>mSettings</code> will be given or not!</param>
					/// <param name="mSettings">Optional map/JSON-object with initial property values, aggregated objects etc. for the new object</param>
					/// <param name="oScope">Scope object for resolving string based type and formatter references in bindings. When a scope object is given, <code>mSettings</code> cannot be omitted, at least <code>null</code> or an empty object literal must be given.</param>
					public extern ManagedObject(string sId, sap.ui.@base.ManagedObject.Settings mSettings, object oScope);

					/// <summary>
					/// Constructs and initializes a managed object with the given <code>sId</code> and settings.
					/// 
					/// If the optional <code>mSettings</code> are given, they must be a simple object that defines values for properties, aggregations, associations or events keyed by their name.
					/// 
					/// <b>Valid Names and Value Ranges:</b>
					/// 
					/// The property (key) names supported in the object literal are exactly the (case sensitive) names documented in the JSDoc for the properties, aggregations, associations and events of the current class and its base classes. Note that for 0..n aggregations and associations this name usually is the plural name, whereas it is the singular name in case of 0..1 relations.
					/// 
					/// If a key name is ambiguous for a specific managed object class (e.g. a property has the same name as an event), then this method prefers property, aggregation, association and event in that order. To resolve such ambiguities, the keys can be prefixed with <code>aggregation:</code>, <code>association:</code> or <code>event:</code> (such keys containing a colon (':') must be quoted to be valid Javascript).
					/// 
					/// The possible values for a setting depend on its kind: <ul> <li>for simple properties, the value has to match the documented type of the property (no type conversion occurs)</li> <li>for 0..1 aggregations, the value has to be an instance of the aggregated type</li> <li>for 0..n aggregations, the value has to be an array of instances of the aggregated type or a single instance</li> <li>for 0..1 associations, an instance of the associated type or an id (string) is accepted</li> <li>for 0..n associations, an array of instances of the associated type or of IDs is accepted</li> <li>for events either a function (event handler) is accepted or an array of length 2 where the first element is a function and the 2nd element is an object to invoke the method on.</li> </ul>
					/// 
					/// Each subclass should document the name and type of its supported settings in its constructor documentation.
					/// 
					/// Example usage: <pre>
					/// new Dialog({
					///    title: "Some title text",            // property of type "string"
					///    showHeader: true,                    // property of type "boolean"
					///    endButton: new Button(...),          // 0..1 aggregation
					///    content: [                           // 0..n aggregation
					///       new Input(...),
					///       new Input(...)
					///    ],
					///    afterClose: function(oEvent) { ... } // event handler function
					/// });
					/// </pre>
					/// 
					/// Instead of static values and object instances, data binding expressions can be used, either embedded in a string or as a binding info object as described in {@link #bindProperty} or {@link #bindAggregation}.
					/// 
					/// Example usage: <pre>
					/// new Dialog({
					///    title: "{/title}",       // embedded binding expression, points to a string property in the data model
					///    ...
					///    content: {               // binding info object
					///       path : "/inputItems", // points to a collection in the data model
					///       template : new Input(...)
					///    }
					/// });
					/// </pre>
					/// 
					/// Note that when setting string values, any curly braces in those values need to be escaped, so they are not interpreted as binding expressions. Use {@link #escapeSettingsValue} to do so.
					/// 
					/// Besides the settings documented below, ManagedObject itself supports the following special settings: <ul> <li><code>id : <i>sap.ui.core.ID</i></code> an ID for the new instance. Some subclasses (Element, Component) require the id to be unique in a specific scope (e.g. an Element Id must be unique across all Elements, a Component id must be unique across all Components). <li><code>models : <i>object</i></code> a map of {@link sap.ui.model.Model} instances keyed by their model name (alias). Each entry with key <i>k</i> in this object has the same effect as a call <code>this.setModel(models[k], k);</code>.</li> <li><code>bindingContexts : <i>object</i></code> a map of {@link sap.ui.model.Context} instances keyed by their model name. Each entry with key <i>k</i> in this object has the same effect as a call <code>this.setBindingContext(bindingContexts[k], k);</code></li> <li><code>objectBindings : <i>object</i></code> a map of binding paths keyed by the corresponding model name. Each entry with key <i>k</i> in this object has the same effect as a call <code>this.bindObject(objectBindings[k], k);</code></li> <li><code>metadataContexts : <i>object</i></code> an array of single binding contexts keyed by the corresponding model or context name. The purpose of the <code>metadataContexts</code> special setting is to deduce as much information as possible from the binding context of the control in order to be able to predefine certain standard properties like e.g. <i>visible, enabled, tooltip,...</i>
					/// 
					/// The structure is an array of single contexts, where a single context is a map containing the following keys: <ul> <li><code>path: <i>string (mandatory)</i></code> The path to the corresponding model property or object, e.g. '/Customers/Name'. A path can also be relative, e.g. 'Name'</li> <li><code>model: <i>string (optional)</i></code> The name of the model, in case there is no name then the undefined model is taken</li> <li><code>name: <i>string (optional)</i></code> A name for the context to used in templating phase</li> <li><code>kind: <i>string (optional)</i></code> The kind of the adapter, either <code>field</code> for single properties or <code>object</code> for structured contexts. <li><code>adapter: <i>string (optional)</i></code> The path to an interpretion class that dilivers control relevant data depending on the context, e.g. enabled, visible. If not supplied the OData meta data is interpreted.</li> </ul> The syntax for providing the <code>metadataContexts</code> is as follows: <code>{SINGLE_CONTEXT1},...,{SINGLE_CONTEXTn}</code> or for simplicity in case there is only one context <code>{SINGLE_CONTEXT}</code>.
					/// 
					/// Examples for such metadataContexts are: <ul> <li><code>{/Customers/Name}</code> a single part with an absolute path to the property <i>Name</i> of the <i>Customers</i> entity set in the default model</li> <li><code>{path: 'Customers/Name', model:'json'}</code> a single part with an absolute path to the property <i>Name</i> of the <i>Customers</i> entity set in a named model</li> <li><code>{parts: [{path: 'Customers/Name'},{path: 'editable', model: 'viewModel'}]}</code> a combination of single binding contexts, one context from the default model and one from the viewModel</li> </ul></li> </ul>
					/// </summary>
					/// <param name="sId">ID for the new managed object; generated automatically if no non-empty ID is given <b>Note:</b> this can be omitted, no matter whether <code>mSettings</code> will be given or not!</param>
					/// <param name="mSettings">Optional map/JSON-object with initial property values, aggregated objects etc. for the new object</param>
					public extern ManagedObject(string sId, sap.ui.@base.ManagedObject.Settings mSettings);

					/// <summary>
					/// Constructs and initializes a managed object with the given <code>sId</code> and settings.
					/// 
					/// If the optional <code>mSettings</code> are given, they must be a simple object that defines values for properties, aggregations, associations or events keyed by their name.
					/// 
					/// <b>Valid Names and Value Ranges:</b>
					/// 
					/// The property (key) names supported in the object literal are exactly the (case sensitive) names documented in the JSDoc for the properties, aggregations, associations and events of the current class and its base classes. Note that for 0..n aggregations and associations this name usually is the plural name, whereas it is the singular name in case of 0..1 relations.
					/// 
					/// If a key name is ambiguous for a specific managed object class (e.g. a property has the same name as an event), then this method prefers property, aggregation, association and event in that order. To resolve such ambiguities, the keys can be prefixed with <code>aggregation:</code>, <code>association:</code> or <code>event:</code> (such keys containing a colon (':') must be quoted to be valid Javascript).
					/// 
					/// The possible values for a setting depend on its kind: <ul> <li>for simple properties, the value has to match the documented type of the property (no type conversion occurs)</li> <li>for 0..1 aggregations, the value has to be an instance of the aggregated type</li> <li>for 0..n aggregations, the value has to be an array of instances of the aggregated type or a single instance</li> <li>for 0..1 associations, an instance of the associated type or an id (string) is accepted</li> <li>for 0..n associations, an array of instances of the associated type or of IDs is accepted</li> <li>for events either a function (event handler) is accepted or an array of length 2 where the first element is a function and the 2nd element is an object to invoke the method on.</li> </ul>
					/// 
					/// Each subclass should document the name and type of its supported settings in its constructor documentation.
					/// 
					/// Example usage: <pre>
					/// new Dialog({
					///    title: "Some title text",            // property of type "string"
					///    showHeader: true,                    // property of type "boolean"
					///    endButton: new Button(...),          // 0..1 aggregation
					///    content: [                           // 0..n aggregation
					///       new Input(...),
					///       new Input(...)
					///    ],
					///    afterClose: function(oEvent) { ... } // event handler function
					/// });
					/// </pre>
					/// 
					/// Instead of static values and object instances, data binding expressions can be used, either embedded in a string or as a binding info object as described in {@link #bindProperty} or {@link #bindAggregation}.
					/// 
					/// Example usage: <pre>
					/// new Dialog({
					///    title: "{/title}",       // embedded binding expression, points to a string property in the data model
					///    ...
					///    content: {               // binding info object
					///       path : "/inputItems", // points to a collection in the data model
					///       template : new Input(...)
					///    }
					/// });
					/// </pre>
					/// 
					/// Note that when setting string values, any curly braces in those values need to be escaped, so they are not interpreted as binding expressions. Use {@link #escapeSettingsValue} to do so.
					/// 
					/// Besides the settings documented below, ManagedObject itself supports the following special settings: <ul> <li><code>id : <i>sap.ui.core.ID</i></code> an ID for the new instance. Some subclasses (Element, Component) require the id to be unique in a specific scope (e.g. an Element Id must be unique across all Elements, a Component id must be unique across all Components). <li><code>models : <i>object</i></code> a map of {@link sap.ui.model.Model} instances keyed by their model name (alias). Each entry with key <i>k</i> in this object has the same effect as a call <code>this.setModel(models[k], k);</code>.</li> <li><code>bindingContexts : <i>object</i></code> a map of {@link sap.ui.model.Context} instances keyed by their model name. Each entry with key <i>k</i> in this object has the same effect as a call <code>this.setBindingContext(bindingContexts[k], k);</code></li> <li><code>objectBindings : <i>object</i></code> a map of binding paths keyed by the corresponding model name. Each entry with key <i>k</i> in this object has the same effect as a call <code>this.bindObject(objectBindings[k], k);</code></li> <li><code>metadataContexts : <i>object</i></code> an array of single binding contexts keyed by the corresponding model or context name. The purpose of the <code>metadataContexts</code> special setting is to deduce as much information as possible from the binding context of the control in order to be able to predefine certain standard properties like e.g. <i>visible, enabled, tooltip,...</i>
					/// 
					/// The structure is an array of single contexts, where a single context is a map containing the following keys: <ul> <li><code>path: <i>string (mandatory)</i></code> The path to the corresponding model property or object, e.g. '/Customers/Name'. A path can also be relative, e.g. 'Name'</li> <li><code>model: <i>string (optional)</i></code> The name of the model, in case there is no name then the undefined model is taken</li> <li><code>name: <i>string (optional)</i></code> A name for the context to used in templating phase</li> <li><code>kind: <i>string (optional)</i></code> The kind of the adapter, either <code>field</code> for single properties or <code>object</code> for structured contexts. <li><code>adapter: <i>string (optional)</i></code> The path to an interpretion class that dilivers control relevant data depending on the context, e.g. enabled, visible. If not supplied the OData meta data is interpreted.</li> </ul> The syntax for providing the <code>metadataContexts</code> is as follows: <code>{SINGLE_CONTEXT1},...,{SINGLE_CONTEXTn}</code> or for simplicity in case there is only one context <code>{SINGLE_CONTEXT}</code>.
					/// 
					/// Examples for such metadataContexts are: <ul> <li><code>{/Customers/Name}</code> a single part with an absolute path to the property <i>Name</i> of the <i>Customers</i> entity set in the default model</li> <li><code>{path: 'Customers/Name', model:'json'}</code> a single part with an absolute path to the property <i>Name</i> of the <i>Customers</i> entity set in a named model</li> <li><code>{parts: [{path: 'Customers/Name'},{path: 'editable', model: 'viewModel'}]}</code> a combination of single binding contexts, one context from the default model and one from the viewModel</li> </ul></li> </ul>
					/// </summary>
					/// <param name="sId">ID for the new managed object; generated automatically if no non-empty ID is given <b>Note:</b> this can be omitted, no matter whether <code>mSettings</code> will be given or not!</param>
					public extern ManagedObject(string sId);

					/// <summary>
					/// Constructs and initializes a managed object with the given <code>sId</code> and settings.
					/// 
					/// If the optional <code>mSettings</code> are given, they must be a simple object that defines values for properties, aggregations, associations or events keyed by their name.
					/// 
					/// <b>Valid Names and Value Ranges:</b>
					/// 
					/// The property (key) names supported in the object literal are exactly the (case sensitive) names documented in the JSDoc for the properties, aggregations, associations and events of the current class and its base classes. Note that for 0..n aggregations and associations this name usually is the plural name, whereas it is the singular name in case of 0..1 relations.
					/// 
					/// If a key name is ambiguous for a specific managed object class (e.g. a property has the same name as an event), then this method prefers property, aggregation, association and event in that order. To resolve such ambiguities, the keys can be prefixed with <code>aggregation:</code>, <code>association:</code> or <code>event:</code> (such keys containing a colon (':') must be quoted to be valid Javascript).
					/// 
					/// The possible values for a setting depend on its kind: <ul> <li>for simple properties, the value has to match the documented type of the property (no type conversion occurs)</li> <li>for 0..1 aggregations, the value has to be an instance of the aggregated type</li> <li>for 0..n aggregations, the value has to be an array of instances of the aggregated type or a single instance</li> <li>for 0..1 associations, an instance of the associated type or an id (string) is accepted</li> <li>for 0..n associations, an array of instances of the associated type or of IDs is accepted</li> <li>for events either a function (event handler) is accepted or an array of length 2 where the first element is a function and the 2nd element is an object to invoke the method on.</li> </ul>
					/// 
					/// Each subclass should document the name and type of its supported settings in its constructor documentation.
					/// 
					/// Example usage: <pre>
					/// new Dialog({
					///    title: "Some title text",            // property of type "string"
					///    showHeader: true,                    // property of type "boolean"
					///    endButton: new Button(...),          // 0..1 aggregation
					///    content: [                           // 0..n aggregation
					///       new Input(...),
					///       new Input(...)
					///    ],
					///    afterClose: function(oEvent) { ... } // event handler function
					/// });
					/// </pre>
					/// 
					/// Instead of static values and object instances, data binding expressions can be used, either embedded in a string or as a binding info object as described in {@link #bindProperty} or {@link #bindAggregation}.
					/// 
					/// Example usage: <pre>
					/// new Dialog({
					///    title: "{/title}",       // embedded binding expression, points to a string property in the data model
					///    ...
					///    content: {               // binding info object
					///       path : "/inputItems", // points to a collection in the data model
					///       template : new Input(...)
					///    }
					/// });
					/// </pre>
					/// 
					/// Note that when setting string values, any curly braces in those values need to be escaped, so they are not interpreted as binding expressions. Use {@link #escapeSettingsValue} to do so.
					/// 
					/// Besides the settings documented below, ManagedObject itself supports the following special settings: <ul> <li><code>id : <i>sap.ui.core.ID</i></code> an ID for the new instance. Some subclasses (Element, Component) require the id to be unique in a specific scope (e.g. an Element Id must be unique across all Elements, a Component id must be unique across all Components). <li><code>models : <i>object</i></code> a map of {@link sap.ui.model.Model} instances keyed by their model name (alias). Each entry with key <i>k</i> in this object has the same effect as a call <code>this.setModel(models[k], k);</code>.</li> <li><code>bindingContexts : <i>object</i></code> a map of {@link sap.ui.model.Context} instances keyed by their model name. Each entry with key <i>k</i> in this object has the same effect as a call <code>this.setBindingContext(bindingContexts[k], k);</code></li> <li><code>objectBindings : <i>object</i></code> a map of binding paths keyed by the corresponding model name. Each entry with key <i>k</i> in this object has the same effect as a call <code>this.bindObject(objectBindings[k], k);</code></li> <li><code>metadataContexts : <i>object</i></code> an array of single binding contexts keyed by the corresponding model or context name. The purpose of the <code>metadataContexts</code> special setting is to deduce as much information as possible from the binding context of the control in order to be able to predefine certain standard properties like e.g. <i>visible, enabled, tooltip,...</i>
					/// 
					/// The structure is an array of single contexts, where a single context is a map containing the following keys: <ul> <li><code>path: <i>string (mandatory)</i></code> The path to the corresponding model property or object, e.g. '/Customers/Name'. A path can also be relative, e.g. 'Name'</li> <li><code>model: <i>string (optional)</i></code> The name of the model, in case there is no name then the undefined model is taken</li> <li><code>name: <i>string (optional)</i></code> A name for the context to used in templating phase</li> <li><code>kind: <i>string (optional)</i></code> The kind of the adapter, either <code>field</code> for single properties or <code>object</code> for structured contexts. <li><code>adapter: <i>string (optional)</i></code> The path to an interpretion class that dilivers control relevant data depending on the context, e.g. enabled, visible. If not supplied the OData meta data is interpreted.</li> </ul> The syntax for providing the <code>metadataContexts</code> is as follows: <code>{SINGLE_CONTEXT1},...,{SINGLE_CONTEXTn}</code> or for simplicity in case there is only one context <code>{SINGLE_CONTEXT}</code>.
					/// 
					/// Examples for such metadataContexts are: <ul> <li><code>{/Customers/Name}</code> a single part with an absolute path to the property <i>Name</i> of the <i>Customers</i> entity set in the default model</li> <li><code>{path: 'Customers/Name', model:'json'}</code> a single part with an absolute path to the property <i>Name</i> of the <i>Customers</i> entity set in a named model</li> <li><code>{parts: [{path: 'Customers/Name'},{path: 'editable', model: 'viewModel'}]}</code> a combination of single binding contexts, one context from the default model and one from the viewModel</li> </ul></li> </ul>
					/// </summary>
					public extern ManagedObject();

					/// <summary>
					/// Constructs and initializes a managed object with the given <code>sId</code> and settings.
					/// 
					/// If the optional <code>mSettings</code> are given, they must be a simple object that defines values for properties, aggregations, associations or events keyed by their name.
					/// 
					/// <b>Valid Names and Value Ranges:</b>
					/// 
					/// The property (key) names supported in the object literal are exactly the (case sensitive) names documented in the JSDoc for the properties, aggregations, associations and events of the current class and its base classes. Note that for 0..n aggregations and associations this name usually is the plural name, whereas it is the singular name in case of 0..1 relations.
					/// 
					/// If a key name is ambiguous for a specific managed object class (e.g. a property has the same name as an event), then this method prefers property, aggregation, association and event in that order. To resolve such ambiguities, the keys can be prefixed with <code>aggregation:</code>, <code>association:</code> or <code>event:</code> (such keys containing a colon (':') must be quoted to be valid Javascript).
					/// 
					/// The possible values for a setting depend on its kind: <ul> <li>for simple properties, the value has to match the documented type of the property (no type conversion occurs)</li> <li>for 0..1 aggregations, the value has to be an instance of the aggregated type</li> <li>for 0..n aggregations, the value has to be an array of instances of the aggregated type or a single instance</li> <li>for 0..1 associations, an instance of the associated type or an id (string) is accepted</li> <li>for 0..n associations, an array of instances of the associated type or of IDs is accepted</li> <li>for events either a function (event handler) is accepted or an array of length 2 where the first element is a function and the 2nd element is an object to invoke the method on.</li> </ul>
					/// 
					/// Each subclass should document the name and type of its supported settings in its constructor documentation.
					/// 
					/// Example usage: <pre>
					/// new Dialog({
					///    title: "Some title text",            // property of type "string"
					///    showHeader: true,                    // property of type "boolean"
					///    endButton: new Button(...),          // 0..1 aggregation
					///    content: [                           // 0..n aggregation
					///       new Input(...),
					///       new Input(...)
					///    ],
					///    afterClose: function(oEvent) { ... } // event handler function
					/// });
					/// </pre>
					/// 
					/// Instead of static values and object instances, data binding expressions can be used, either embedded in a string or as a binding info object as described in {@link #bindProperty} or {@link #bindAggregation}.
					/// 
					/// Example usage: <pre>
					/// new Dialog({
					///    title: "{/title}",       // embedded binding expression, points to a string property in the data model
					///    ...
					///    content: {               // binding info object
					///       path : "/inputItems", // points to a collection in the data model
					///       template : new Input(...)
					///    }
					/// });
					/// </pre>
					/// 
					/// Note that when setting string values, any curly braces in those values need to be escaped, so they are not interpreted as binding expressions. Use {@link #escapeSettingsValue} to do so.
					/// 
					/// Besides the settings documented below, ManagedObject itself supports the following special settings: <ul> <li><code>id : <i>sap.ui.core.ID</i></code> an ID for the new instance. Some subclasses (Element, Component) require the id to be unique in a specific scope (e.g. an Element Id must be unique across all Elements, a Component id must be unique across all Components). <li><code>models : <i>object</i></code> a map of {@link sap.ui.model.Model} instances keyed by their model name (alias). Each entry with key <i>k</i> in this object has the same effect as a call <code>this.setModel(models[k], k);</code>.</li> <li><code>bindingContexts : <i>object</i></code> a map of {@link sap.ui.model.Context} instances keyed by their model name. Each entry with key <i>k</i> in this object has the same effect as a call <code>this.setBindingContext(bindingContexts[k], k);</code></li> <li><code>objectBindings : <i>object</i></code> a map of binding paths keyed by the corresponding model name. Each entry with key <i>k</i> in this object has the same effect as a call <code>this.bindObject(objectBindings[k], k);</code></li> <li><code>metadataContexts : <i>object</i></code> an array of single binding contexts keyed by the corresponding model or context name. The purpose of the <code>metadataContexts</code> special setting is to deduce as much information as possible from the binding context of the control in order to be able to predefine certain standard properties like e.g. <i>visible, enabled, tooltip,...</i>
					/// 
					/// The structure is an array of single contexts, where a single context is a map containing the following keys: <ul> <li><code>path: <i>string (mandatory)</i></code> The path to the corresponding model property or object, e.g. '/Customers/Name'. A path can also be relative, e.g. 'Name'</li> <li><code>model: <i>string (optional)</i></code> The name of the model, in case there is no name then the undefined model is taken</li> <li><code>name: <i>string (optional)</i></code> A name for the context to used in templating phase</li> <li><code>kind: <i>string (optional)</i></code> The kind of the adapter, either <code>field</code> for single properties or <code>object</code> for structured contexts. <li><code>adapter: <i>string (optional)</i></code> The path to an interpretion class that dilivers control relevant data depending on the context, e.g. enabled, visible. If not supplied the OData meta data is interpreted.</li> </ul> The syntax for providing the <code>metadataContexts</code> is as follows: <code>{SINGLE_CONTEXT1},...,{SINGLE_CONTEXTn}</code> or for simplicity in case there is only one context <code>{SINGLE_CONTEXT}</code>.
					/// 
					/// Examples for such metadataContexts are: <ul> <li><code>{/Customers/Name}</code> a single part with an absolute path to the property <i>Name</i> of the <i>Customers</i> entity set in the default model</li> <li><code>{path: 'Customers/Name', model:'json'}</code> a single part with an absolute path to the property <i>Name</i> of the <i>Customers</i> entity set in a named model</li> <li><code>{parts: [{path: 'Customers/Name'},{path: 'editable', model: 'viewModel'}]}</code> a combination of single binding contexts, one context from the default model and one from the viewModel</li> </ul></li> </ul>
					/// </summary>
					/// <param name="mSettings">Optional map/JSON-object with initial property values, aggregated objects etc. for the new object</param>
					public extern ManagedObject(sap.ui.@base.ManagedObject.Settings mSettings);

					/// <summary>
					/// Constructs and initializes a managed object with the given <code>sId</code> and settings.
					/// 
					/// If the optional <code>mSettings</code> are given, they must be a simple object that defines values for properties, aggregations, associations or events keyed by their name.
					/// 
					/// <b>Valid Names and Value Ranges:</b>
					/// 
					/// The property (key) names supported in the object literal are exactly the (case sensitive) names documented in the JSDoc for the properties, aggregations, associations and events of the current class and its base classes. Note that for 0..n aggregations and associations this name usually is the plural name, whereas it is the singular name in case of 0..1 relations.
					/// 
					/// If a key name is ambiguous for a specific managed object class (e.g. a property has the same name as an event), then this method prefers property, aggregation, association and event in that order. To resolve such ambiguities, the keys can be prefixed with <code>aggregation:</code>, <code>association:</code> or <code>event:</code> (such keys containing a colon (':') must be quoted to be valid Javascript).
					/// 
					/// The possible values for a setting depend on its kind: <ul> <li>for simple properties, the value has to match the documented type of the property (no type conversion occurs)</li> <li>for 0..1 aggregations, the value has to be an instance of the aggregated type</li> <li>for 0..n aggregations, the value has to be an array of instances of the aggregated type or a single instance</li> <li>for 0..1 associations, an instance of the associated type or an id (string) is accepted</li> <li>for 0..n associations, an array of instances of the associated type or of IDs is accepted</li> <li>for events either a function (event handler) is accepted or an array of length 2 where the first element is a function and the 2nd element is an object to invoke the method on.</li> </ul>
					/// 
					/// Each subclass should document the name and type of its supported settings in its constructor documentation.
					/// 
					/// Example usage: <pre>
					/// new Dialog({
					///    title: "Some title text",            // property of type "string"
					///    showHeader: true,                    // property of type "boolean"
					///    endButton: new Button(...),          // 0..1 aggregation
					///    content: [                           // 0..n aggregation
					///       new Input(...),
					///       new Input(...)
					///    ],
					///    afterClose: function(oEvent) { ... } // event handler function
					/// });
					/// </pre>
					/// 
					/// Instead of static values and object instances, data binding expressions can be used, either embedded in a string or as a binding info object as described in {@link #bindProperty} or {@link #bindAggregation}.
					/// 
					/// Example usage: <pre>
					/// new Dialog({
					///    title: "{/title}",       // embedded binding expression, points to a string property in the data model
					///    ...
					///    content: {               // binding info object
					///       path : "/inputItems", // points to a collection in the data model
					///       template : new Input(...)
					///    }
					/// });
					/// </pre>
					/// 
					/// Note that when setting string values, any curly braces in those values need to be escaped, so they are not interpreted as binding expressions. Use {@link #escapeSettingsValue} to do so.
					/// 
					/// Besides the settings documented below, ManagedObject itself supports the following special settings: <ul> <li><code>id : <i>sap.ui.core.ID</i></code> an ID for the new instance. Some subclasses (Element, Component) require the id to be unique in a specific scope (e.g. an Element Id must be unique across all Elements, a Component id must be unique across all Components). <li><code>models : <i>object</i></code> a map of {@link sap.ui.model.Model} instances keyed by their model name (alias). Each entry with key <i>k</i> in this object has the same effect as a call <code>this.setModel(models[k], k);</code>.</li> <li><code>bindingContexts : <i>object</i></code> a map of {@link sap.ui.model.Context} instances keyed by their model name. Each entry with key <i>k</i> in this object has the same effect as a call <code>this.setBindingContext(bindingContexts[k], k);</code></li> <li><code>objectBindings : <i>object</i></code> a map of binding paths keyed by the corresponding model name. Each entry with key <i>k</i> in this object has the same effect as a call <code>this.bindObject(objectBindings[k], k);</code></li> <li><code>metadataContexts : <i>object</i></code> an array of single binding contexts keyed by the corresponding model or context name. The purpose of the <code>metadataContexts</code> special setting is to deduce as much information as possible from the binding context of the control in order to be able to predefine certain standard properties like e.g. <i>visible, enabled, tooltip,...</i>
					/// 
					/// The structure is an array of single contexts, where a single context is a map containing the following keys: <ul> <li><code>path: <i>string (mandatory)</i></code> The path to the corresponding model property or object, e.g. '/Customers/Name'. A path can also be relative, e.g. 'Name'</li> <li><code>model: <i>string (optional)</i></code> The name of the model, in case there is no name then the undefined model is taken</li> <li><code>name: <i>string (optional)</i></code> A name for the context to used in templating phase</li> <li><code>kind: <i>string (optional)</i></code> The kind of the adapter, either <code>field</code> for single properties or <code>object</code> for structured contexts. <li><code>adapter: <i>string (optional)</i></code> The path to an interpretion class that dilivers control relevant data depending on the context, e.g. enabled, visible. If not supplied the OData meta data is interpreted.</li> </ul> The syntax for providing the <code>metadataContexts</code> is as follows: <code>{SINGLE_CONTEXT1},...,{SINGLE_CONTEXTn}</code> or for simplicity in case there is only one context <code>{SINGLE_CONTEXT}</code>.
					/// 
					/// Examples for such metadataContexts are: <ul> <li><code>{/Customers/Name}</code> a single part with an absolute path to the property <i>Name</i> of the <i>Customers</i> entity set in the default model</li> <li><code>{path: 'Customers/Name', model:'json'}</code> a single part with an absolute path to the property <i>Name</i> of the <i>Customers</i> entity set in a named model</li> <li><code>{parts: [{path: 'Customers/Name'},{path: 'editable', model: 'viewModel'}]}</code> a combination of single binding contexts, one context from the default model and one from the viewModel</li> </ul></li> </ul>
					/// </summary>
					/// <param name="mSettings">Optional map/JSON-object with initial property values, aggregated objects etc. for the new object</param>
					/// <param name="oScope">Scope object for resolving string based type and formatter references in bindings. When a scope object is given, <code>mSettings</code> cannot be omitted, at least <code>null</code> or an empty object literal must be given.</param>
					public extern ManagedObject(sap.ui.@base.ManagedObject.Settings mSettings, object oScope);

					/// <summary>
					/// Constructs and initializes a managed object with the given <code>sId</code> and settings.
					/// 
					/// If the optional <code>mSettings</code> are given, they must be a simple object that defines values for properties, aggregations, associations or events keyed by their name.
					/// 
					/// <b>Valid Names and Value Ranges:</b>
					/// 
					/// The property (key) names supported in the object literal are exactly the (case sensitive) names documented in the JSDoc for the properties, aggregations, associations and events of the current class and its base classes. Note that for 0..n aggregations and associations this name usually is the plural name, whereas it is the singular name in case of 0..1 relations.
					/// 
					/// If a key name is ambiguous for a specific managed object class (e.g. a property has the same name as an event), then this method prefers property, aggregation, association and event in that order. To resolve such ambiguities, the keys can be prefixed with <code>aggregation:</code>, <code>association:</code> or <code>event:</code> (such keys containing a colon (':') must be quoted to be valid Javascript).
					/// 
					/// The possible values for a setting depend on its kind: <ul> <li>for simple properties, the value has to match the documented type of the property (no type conversion occurs)</li> <li>for 0..1 aggregations, the value has to be an instance of the aggregated type</li> <li>for 0..n aggregations, the value has to be an array of instances of the aggregated type or a single instance</li> <li>for 0..1 associations, an instance of the associated type or an id (string) is accepted</li> <li>for 0..n associations, an array of instances of the associated type or of IDs is accepted</li> <li>for events either a function (event handler) is accepted or an array of length 2 where the first element is a function and the 2nd element is an object to invoke the method on.</li> </ul>
					/// 
					/// Each subclass should document the name and type of its supported settings in its constructor documentation.
					/// 
					/// Example usage: <pre>
					/// new Dialog({
					///    title: "Some title text",            // property of type "string"
					///    showHeader: true,                    // property of type "boolean"
					///    endButton: new Button(...),          // 0..1 aggregation
					///    content: [                           // 0..n aggregation
					///       new Input(...),
					///       new Input(...)
					///    ],
					///    afterClose: function(oEvent) { ... } // event handler function
					/// });
					/// </pre>
					/// 
					/// Instead of static values and object instances, data binding expressions can be used, either embedded in a string or as a binding info object as described in {@link #bindProperty} or {@link #bindAggregation}.
					/// 
					/// Example usage: <pre>
					/// new Dialog({
					///    title: "{/title}",       // embedded binding expression, points to a string property in the data model
					///    ...
					///    content: {               // binding info object
					///       path : "/inputItems", // points to a collection in the data model
					///       template : new Input(...)
					///    }
					/// });
					/// </pre>
					/// 
					/// Note that when setting string values, any curly braces in those values need to be escaped, so they are not interpreted as binding expressions. Use {@link #escapeSettingsValue} to do so.
					/// 
					/// Besides the settings documented below, ManagedObject itself supports the following special settings: <ul> <li><code>id : <i>sap.ui.core.ID</i></code> an ID for the new instance. Some subclasses (Element, Component) require the id to be unique in a specific scope (e.g. an Element Id must be unique across all Elements, a Component id must be unique across all Components). <li><code>models : <i>object</i></code> a map of {@link sap.ui.model.Model} instances keyed by their model name (alias). Each entry with key <i>k</i> in this object has the same effect as a call <code>this.setModel(models[k], k);</code>.</li> <li><code>bindingContexts : <i>object</i></code> a map of {@link sap.ui.model.Context} instances keyed by their model name. Each entry with key <i>k</i> in this object has the same effect as a call <code>this.setBindingContext(bindingContexts[k], k);</code></li> <li><code>objectBindings : <i>object</i></code> a map of binding paths keyed by the corresponding model name. Each entry with key <i>k</i> in this object has the same effect as a call <code>this.bindObject(objectBindings[k], k);</code></li> <li><code>metadataContexts : <i>object</i></code> an array of single binding contexts keyed by the corresponding model or context name. The purpose of the <code>metadataContexts</code> special setting is to deduce as much information as possible from the binding context of the control in order to be able to predefine certain standard properties like e.g. <i>visible, enabled, tooltip,...</i>
					/// 
					/// The structure is an array of single contexts, where a single context is a map containing the following keys: <ul> <li><code>path: <i>string (mandatory)</i></code> The path to the corresponding model property or object, e.g. '/Customers/Name'. A path can also be relative, e.g. 'Name'</li> <li><code>model: <i>string (optional)</i></code> The name of the model, in case there is no name then the undefined model is taken</li> <li><code>name: <i>string (optional)</i></code> A name for the context to used in templating phase</li> <li><code>kind: <i>string (optional)</i></code> The kind of the adapter, either <code>field</code> for single properties or <code>object</code> for structured contexts. <li><code>adapter: <i>string (optional)</i></code> The path to an interpretion class that dilivers control relevant data depending on the context, e.g. enabled, visible. If not supplied the OData meta data is interpreted.</li> </ul> The syntax for providing the <code>metadataContexts</code> is as follows: <code>{SINGLE_CONTEXT1},...,{SINGLE_CONTEXTn}</code> or for simplicity in case there is only one context <code>{SINGLE_CONTEXT}</code>.
					/// 
					/// Examples for such metadataContexts are: <ul> <li><code>{/Customers/Name}</code> a single part with an absolute path to the property <i>Name</i> of the <i>Customers</i> entity set in the default model</li> <li><code>{path: 'Customers/Name', model:'json'}</code> a single part with an absolute path to the property <i>Name</i> of the <i>Customers</i> entity set in a named model</li> <li><code>{parts: [{path: 'Customers/Name'},{path: 'editable', model: 'viewModel'}]}</code> a combination of single binding contexts, one context from the default model and one from the viewModel</li> </ul></li> </ul>
					/// </summary>
					/// <param name="oScope">Scope object for resolving string based type and formatter references in bindings. When a scope object is given, <code>mSettings</code> cannot be omitted, at least <code>null</code> or an empty object literal must be given.</param>
					public extern ManagedObject(object oScope);

					#endregion

					#region Methods

					#region Methods for Event validationSuccess

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:validationSuccess validationSuccess} event of this <code>sap.ui.base.ManagedObject</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.base.ManagedObject</code> itself.
					/// 
					/// Fired after a new value for a bound property has been propagated to the model. Only fired, when the binding uses a data type.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.base.ManagedObject</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.@base.ManagedObject attachValidationSuccess(object oData, sap.ui.@base.ManagedObject.ValidationDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:validationSuccess validationSuccess} event of this <code>sap.ui.base.ManagedObject</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.base.ManagedObject</code> itself.
					/// 
					/// Fired after a new value for a bound property has been propagated to the model. Only fired, when the binding uses a data type.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.@base.ManagedObject attachValidationSuccess(object oData, sap.ui.@base.ManagedObject.ValidationDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:validationSuccess validationSuccess} event of this <code>sap.ui.base.ManagedObject</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.base.ManagedObject</code> itself.
					/// 
					/// Fired after a new value for a bound property has been propagated to the model. Only fired, when the binding uses a data type.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.@base.ManagedObject attachValidationSuccess(sap.ui.@base.ManagedObject.ValidationDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:validationSuccess validationSuccess} event of this <code>sap.ui.base.ManagedObject</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.base.ManagedObject</code> itself.
					/// 
					/// Fired after a new value for a bound property has been propagated to the model. Only fired, when the binding uses a data type.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.base.ManagedObject</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.@base.ManagedObject attachValidationSuccess(sap.ui.@base.ManagedObject.ValidationDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:validationSuccess validationSuccess} event of this <code>sap.ui.base.ManagedObject</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.@base.ManagedObject detachValidationSuccess(sap.ui.@base.ManagedObject.ValidationDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:validationSuccess validationSuccess} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.@base.ManagedObject fireValidationSuccess(sap.ui.@base.ManagedObject.ValidationInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:validationSuccess validationSuccess} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.@base.ManagedObject fireValidationSuccess();

					#endregion

					#region Methods for Event validationError

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:validationError validationError} event of this <code>sap.ui.base.ManagedObject</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.base.ManagedObject</code> itself.
					/// 
					/// Fired when a new value for a bound property should have been propagated to the model, but validating the value failed with an exception.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.base.ManagedObject</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.@base.ManagedObject attachValidationError(object oData, sap.ui.@base.ManagedObject.ErrorDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:validationError validationError} event of this <code>sap.ui.base.ManagedObject</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.base.ManagedObject</code> itself.
					/// 
					/// Fired when a new value for a bound property should have been propagated to the model, but validating the value failed with an exception.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.@base.ManagedObject attachValidationError(object oData, sap.ui.@base.ManagedObject.ErrorDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:validationError validationError} event of this <code>sap.ui.base.ManagedObject</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.base.ManagedObject</code> itself.
					/// 
					/// Fired when a new value for a bound property should have been propagated to the model, but validating the value failed with an exception.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.@base.ManagedObject attachValidationError(sap.ui.@base.ManagedObject.ErrorDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:validationError validationError} event of this <code>sap.ui.base.ManagedObject</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.base.ManagedObject</code> itself.
					/// 
					/// Fired when a new value for a bound property should have been propagated to the model, but validating the value failed with an exception.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.base.ManagedObject</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.@base.ManagedObject attachValidationError(sap.ui.@base.ManagedObject.ErrorDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:validationError validationError} event of this <code>sap.ui.base.ManagedObject</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.@base.ManagedObject detachValidationError(sap.ui.@base.ManagedObject.ErrorDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:validationError validationError} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.@base.ManagedObject fireValidationError(sap.ui.@base.ManagedObject.ErrorInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:validationError validationError} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.@base.ManagedObject fireValidationError();

					#endregion

					#region Methods for Event parseError

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:parseError parseError} event of this <code>sap.ui.base.ManagedObject</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.base.ManagedObject</code> itself.
					/// 
					/// Fired when a new value for a bound property should have been propagated to the model, but parsing the value failed with an exception.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.base.ManagedObject</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.@base.ManagedObject attachParseError(object oData, sap.ui.@base.ManagedObject.ErrorDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:parseError parseError} event of this <code>sap.ui.base.ManagedObject</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.base.ManagedObject</code> itself.
					/// 
					/// Fired when a new value for a bound property should have been propagated to the model, but parsing the value failed with an exception.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.@base.ManagedObject attachParseError(object oData, sap.ui.@base.ManagedObject.ErrorDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:parseError parseError} event of this <code>sap.ui.base.ManagedObject</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.base.ManagedObject</code> itself.
					/// 
					/// Fired when a new value for a bound property should have been propagated to the model, but parsing the value failed with an exception.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.@base.ManagedObject attachParseError(sap.ui.@base.ManagedObject.ErrorDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:parseError parseError} event of this <code>sap.ui.base.ManagedObject</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.base.ManagedObject</code> itself.
					/// 
					/// Fired when a new value for a bound property should have been propagated to the model, but parsing the value failed with an exception.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.base.ManagedObject</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.@base.ManagedObject attachParseError(sap.ui.@base.ManagedObject.ErrorDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:parseError parseError} event of this <code>sap.ui.base.ManagedObject</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.@base.ManagedObject detachParseError(sap.ui.@base.ManagedObject.ErrorDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:parseError parseError} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.@base.ManagedObject fireParseError(sap.ui.@base.ManagedObject.ErrorInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:parseError parseError} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.@base.ManagedObject fireParseError();

					#endregion

					#region Methods for Event formatError

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:formatError formatError} event of this <code>sap.ui.base.ManagedObject</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.base.ManagedObject</code> itself.
					/// 
					/// Fired when a new value for a bound property should have been propagated from the model, but formatting the value failed with an exception.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.base.ManagedObject</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.@base.ManagedObject attachFormatError(object oData, sap.ui.@base.ManagedObject.ErrorDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:formatError formatError} event of this <code>sap.ui.base.ManagedObject</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.base.ManagedObject</code> itself.
					/// 
					/// Fired when a new value for a bound property should have been propagated from the model, but formatting the value failed with an exception.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.@base.ManagedObject attachFormatError(object oData, sap.ui.@base.ManagedObject.ErrorDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:formatError formatError} event of this <code>sap.ui.base.ManagedObject</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.base.ManagedObject</code> itself.
					/// 
					/// Fired when a new value for a bound property should have been propagated from the model, but formatting the value failed with an exception.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.@base.ManagedObject attachFormatError(sap.ui.@base.ManagedObject.ErrorDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:formatError formatError} event of this <code>sap.ui.base.ManagedObject</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.base.ManagedObject</code> itself.
					/// 
					/// Fired when a new value for a bound property should have been propagated from the model, but formatting the value failed with an exception.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.base.ManagedObject</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.@base.ManagedObject attachFormatError(sap.ui.@base.ManagedObject.ErrorDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:formatError formatError} event of this <code>sap.ui.base.ManagedObject</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.@base.ManagedObject detachFormatError(sap.ui.@base.ManagedObject.ErrorDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:formatError formatError} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.@base.ManagedObject fireFormatError(sap.ui.@base.ManagedObject.ErrorInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:formatError formatError} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.@base.ManagedObject fireFormatError();

					#endregion

					#region Methods for Event modelContextChange

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:modelContextChange modelContextChange} event of this <code>sap.ui.base.ManagedObject</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.base.ManagedObject</code> itself.
					/// 
					/// Fired when models or contexts are changed on this object (either by calling setModel/setBindingContext or due to propagation)
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.base.ManagedObject</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.@base.ManagedObject attachModelContextChange(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:modelContextChange modelContextChange} event of this <code>sap.ui.base.ManagedObject</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.base.ManagedObject</code> itself.
					/// 
					/// Fired when models or contexts are changed on this object (either by calling setModel/setBindingContext or due to propagation)
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.@base.ManagedObject attachModelContextChange(object oData, sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:modelContextChange modelContextChange} event of this <code>sap.ui.base.ManagedObject</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.base.ManagedObject</code> itself.
					/// 
					/// Fired when models or contexts are changed on this object (either by calling setModel/setBindingContext or due to propagation)
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.@base.ManagedObject attachModelContextChange(sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:modelContextChange modelContextChange} event of this <code>sap.ui.base.ManagedObject</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.base.ManagedObject</code> itself.
					/// 
					/// Fired when models or contexts are changed on this object (either by calling setModel/setBindingContext or due to propagation)
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.base.ManagedObject</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.@base.ManagedObject attachModelContextChange(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:modelContextChange modelContextChange} event of this <code>sap.ui.base.ManagedObject</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.@base.ManagedObject detachModelContextChange(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:modelContextChange modelContextChange} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.@base.ManagedObject fireModelContextChange(object mParameters);

					/// <summary>
					/// Fires event {@link #event:modelContextChange modelContextChange} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.@base.ManagedObject fireModelContextChange();

					#endregion

					#region Other methods

					/// <summary>
					/// Hook method to let descendants of ManagedObject know when propagated contextual settings have changed
					/// </summary>
					private extern void _onContextualSettingsChanged();

					/// <summary>
					/// Adds some entity <code>oObject</code> to the aggregation identified by <code>sAggregationName</code>.
					/// 
					/// If the given object is not valid with regard to the aggregation (if it is not an instance of the type specified for that aggregation) or when the method is called for an aggregation of cardinality 0..1, then an Error is thrown (see {@link #validateAggregation}.
					/// 
					/// If the aggregation already has content, the new object will be added after the current content. If the new object was already contained in the aggregation, it will be moved to the end.
					/// 
					/// <b>Note:</b> This method is a low-level API as described in <a href="#lowlevelapi">the class documentation</a>. Applications or frameworks must not use this method to generically add an object to an aggregation. Use the concrete method add<i>XYZ</i> for aggregation 'XYZ' or the generic {@link #applySettings} instead.
					/// </summary>
					/// <param name="sAggregationName">the string identifying the aggregation that <code>oObject</code> should be added to.</param>
					/// <param name="oObject">the object to add; if empty, nothing is added</param>
					/// <param name="bSuppressInvalidate">if true, this ManagedObject as well as the added child are not marked as changed</param>
					/// <returns>Returns <code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.@base.ManagedObject addAggregation(string sAggregationName, sap.ui.@base.ManagedObject oObject, bool bSuppressInvalidate);

					/// <summary>
					/// Adds some entity <code>oObject</code> to the aggregation identified by <code>sAggregationName</code>.
					/// 
					/// If the given object is not valid with regard to the aggregation (if it is not an instance of the type specified for that aggregation) or when the method is called for an aggregation of cardinality 0..1, then an Error is thrown (see {@link #validateAggregation}.
					/// 
					/// If the aggregation already has content, the new object will be added after the current content. If the new object was already contained in the aggregation, it will be moved to the end.
					/// 
					/// <b>Note:</b> This method is a low-level API as described in <a href="#lowlevelapi">the class documentation</a>. Applications or frameworks must not use this method to generically add an object to an aggregation. Use the concrete method add<i>XYZ</i> for aggregation 'XYZ' or the generic {@link #applySettings} instead.
					/// </summary>
					/// <param name="sAggregationName">the string identifying the aggregation that <code>oObject</code> should be added to.</param>
					/// <param name="oObject">the object to add; if empty, nothing is added</param>
					/// <returns>Returns <code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.@base.ManagedObject addAggregation(string sAggregationName, sap.ui.@base.ManagedObject oObject);

					/// <summary>
					/// Adds some object with the ID <code>sId</code> to the association identified by <code>sAssociationName</code> and marks this ManagedObject as changed.
					/// 
					/// This method does not avoid duplicates.
					/// 
					/// <b>Note:</b> This method is a low-level API as described in <a href="#lowlevelapi">the class documentation</a>. Applications or frameworks must not use this method to generically add an object to an association. Use the concrete method add<i>XYZ</i> for association 'XYZ' or the generic {@link #applySettings} instead.
					/// </summary>
					/// <param name="sAssociationName">the string identifying the association the object should be added to.</param>
					/// <param name="sId">the ID of the ManagedObject object to add; if empty, nothing is added; if a <code>sap.ui.base.ManagedObject</code> is given, its ID is added</param>
					/// <param name="bSuppressInvalidate">if true, this managed object as well as the newly associated object are not marked as changed</param>
					/// <returns>Returns <code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.@base.ManagedObject addAssociation(string sAssociationName, Union<string, sap.ui.@base.ManagedObject> sId, bool bSuppressInvalidate);

					/// <summary>
					/// Adds some object with the ID <code>sId</code> to the association identified by <code>sAssociationName</code> and marks this ManagedObject as changed.
					/// 
					/// This method does not avoid duplicates.
					/// 
					/// <b>Note:</b> This method is a low-level API as described in <a href="#lowlevelapi">the class documentation</a>. Applications or frameworks must not use this method to generically add an object to an association. Use the concrete method add<i>XYZ</i> for association 'XYZ' or the generic {@link #applySettings} instead.
					/// </summary>
					/// <param name="sAssociationName">the string identifying the association the object should be added to.</param>
					/// <param name="sId">the ID of the ManagedObject object to add; if empty, nothing is added; if a <code>sap.ui.base.ManagedObject</code> is given, its ID is added</param>
					/// <returns>Returns <code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.@base.ManagedObject addAssociation(string sAssociationName, Union<string, sap.ui.@base.ManagedObject> sId);

					/// <summary>
					/// Adds a listener function that will be called during each propagation step on every control
					/// </summary>
					/// <param name="listener">function</param>
					/// <returns>Returns <code>this</code> to allow method chaining</returns>
					private extern sap.ui.@base.ManagedObject addPropagationListener(object listener);

					/// <summary>
					/// Sets all the properties, aggregations, associations and event handlers as given in the object literal <code>mSettings</code>. If a property, aggregation, etc. is not listed in <code>mSettings</code>, then its value is not changed by this method.
					/// 
					/// For properties and 0..1 aggregations/associations, any given setting overwrites the current value. For 0..n aggregations, the given values are appended; event listeners are registered in addition to existing ones.
					/// 
					/// For the possible keys and values in <code>mSettings</code> see the general documentation in {@link sap.ui.base.ManagedObject} or the specific documentation of the constructor of the concrete managed object class.
					/// </summary>
					/// <param name="mSettings">the settings to apply to this managed object</param>
					/// <param name="oScope">Scope object to resolve types and formatters</param>
					/// <returns>Returns <code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.@base.ManagedObject applySettings(object mSettings, object oScope);

					/// <summary>
					/// Sets all the properties, aggregations, associations and event handlers as given in the object literal <code>mSettings</code>. If a property, aggregation, etc. is not listed in <code>mSettings</code>, then its value is not changed by this method.
					/// 
					/// For properties and 0..1 aggregations/associations, any given setting overwrites the current value. For 0..n aggregations, the given values are appended; event listeners are registered in addition to existing ones.
					/// 
					/// For the possible keys and values in <code>mSettings</code> see the general documentation in {@link sap.ui.base.ManagedObject} or the specific documentation of the constructor of the concrete managed object class.
					/// </summary>
					/// <param name="mSettings">the settings to apply to this managed object</param>
					/// <returns>Returns <code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.@base.ManagedObject applySettings(object mSettings);

					/// <summary>
					/// Bind an aggregation to the model.
					/// 
					/// The bound aggregation will use the given template, clone it for each item which exists in the bound list and set the appropriate binding context. This is a generic method which can be used to bind any aggregation to the model. A managed object may flag aggregations in the metamodel with bindable="bindable" to get typed bind<i>Something</i> methods for those aggregations. For more information on the <code>oBindingInfo.key</code> property and its usage, see {@link topic:7cdff73f308b4b10bdf7d83b7aba72e7 Extended Change Detection}
					/// </summary>
					/// <param name="sName">the aggregation to bind</param>
					/// <param name="oBindingInfo">the binding info</param>
					/// <returns>reference to the instance itself</returns>
					public extern virtual sap.ui.@base.ManagedObject bindAggregation(string sName, sap.ui.@base.ManagedObject.BindAggregationInfo oBindingInfo);

					/// <summary>
					/// Bind the object to the referenced entity in the model, which is used as the binding context to resolve bound properties or aggregations of the object itself and all of its children relatively to the given path.
					/// </summary>
					/// <param name="sPath">the binding path</param>
					/// <returns>reference to the instance itself</returns>
					[Obsolete("Deprecated since 1.11.1. please use bindElement instead.")]
					public extern virtual sap.ui.@base.ManagedObject bindContext(string sPath);

					/// <summary>
					/// Bind the object to the referenced entity in the model, which is used as the binding context to resolve bound properties or aggregations of the object itself and all of its children relatively to the given path. If a relative binding path is used, this will be applied whenever the parent context changes. There is no difference between {@link sap.ui.core.Element#bindElement} and {@link sap.ui.base.ManagedObject#bindObject}.
					/// </summary>
					/// <param name="oBindingInfo">the binding info object</param>
					/// <returns>reference to the instance itself</returns>
					public extern virtual sap.ui.@base.ManagedObject bindObject(sap.ui.@base.ManagedObject.BindObjectInfo oBindingInfo);

					/// <summary>
					/// Binds a property to the model.
					/// 
					/// The Setter for the given property will be called with the value retrieved from the data model. When the binding mode is <code>OneTime</code>, the property will be set only once. When it is <code>OneWay</code>, the property will be updated whenever the corresponding data in the model changes. In mode <code>TwoWay</code>, changes to the property (not originating in the model) will be reported back to the model (typical use case: user interaction changes the value of a control).
					/// 
					/// This is a generic method which can be used to bind any property to the model. A managed object may flag any property in its metadata with <code>bindable="bindable"</code> to additionally provide named methods to bind and unbind the corresponding property.
					/// 
					/// <b>Composite Binding</b><br> A composite property binding which combines data from multiple model paths can be declared using the <code>parts</code> parameter instead of <code>path</code>. The <code>formatter</code> function or a {@link sap.ui.model.CompositeType composite type} then can be used to combine the parts, Properties with a composite binding are also known as "calculated fields".
					/// 
					/// Example: <pre>
					///   oTxt.bindValue({
					///     parts: [
					///       {path: "/firstName", type: "sap.ui.model.type.String"},
					///       {path: "myModel2>/lastName"}
					///     ]
					///   });
					/// </pre>
					/// 
					/// Note that a composite binding will be forced into mode <code>OneWay</code> when one of the binding parts is not in mode <code>TwoWay</code>.
					/// 
					/// <b>Formatter Functions</b><br> When a formatter function is specified for the binding or for a binding part, it will be called with the value of the bound model property. After setting the initial property value, the formatter function will only be called again when the bound model property changes (simple property binding) or when at least one of the bound model properties changes (formatter function of a composite binding). Note that a binding only monitors the bound model data for changes. Dependencies of the formatter implementation to other model data is not known to the binding and changes won't be detected.
					/// 
					/// When the formatter for a property binding (simple or composite) is called, the managed object will be given as <code>this</code> context. For formatters of binding parts in a composite binding, this is not the case.
					/// </summary>
					/// <param name="sName">Name of the property to bind</param>
					/// <param name="oBindingInfo">Binding information</param>
					/// <returns>reference to the instance itself</returns>
					public extern virtual sap.ui.@base.ManagedObject bindProperty(string sName, sap.ui.@base.ManagedObject.BindPropertyInfo oBindingInfo);

					/// <summary>
					/// Clones a tree of objects starting with the object on which clone is called first (root object).
					/// 
					/// The IDs within the newly created clone tree are derived from the original IDs by appending the given <code>sIdSuffix</code> (if no suffix is given, one will be created; it will be unique across multiple clone calls).
					/// 
					/// The <code>oOptions</code> configuration object can have the following properties: <ul> <li>The boolean value <code>cloneChildren</code> specifies whether associations/aggregations will be cloned</li> <li>The boolean value <code>cloneBindings</code> specifies if bindings will be cloned</li> </ul>
					/// 
					/// For each cloned object the following settings are cloned based on the metadata of the object and the defined options: <ul> <li>all properties that are not bound. If <code>cloneBinding</code> is <code>false</code>, even these properties will be cloned; the values are used by reference, they are not cloned</li> <li>all aggregated objects that are not bound. If <code>cloneBinding</code> is <code>false</code>, even the ones that are bound will be cloned; they are all cloned recursively using the same <code>sIdSuffix</code></li> <li>all associated controls; when an association points to an object inside the cloned object tree, then the cloned association will be modified to that it points to the clone of the target object. When the association points to a managed object outside of the cloned object tree, then its target won't be changed.</li> <li>all models set via <code>setModel()</code>; used by reference </li> <li>all property and aggregation bindings (if <code>cloneBindings</code> is <code>true</code>); the pure binding information (path, model name) is cloned, but all other information like template control or factory function, data type or formatter function are copied by reference. The bindings themselves are created anew as they are specific for the combination (object, property, model). As a result, any later changes to a binding of the original object are not reflected in the clone, but changes to e.g the type or template etc. are.</li> </ul>
					/// 
					/// Each clone is created by first collecting the above mentioned settings and then creating a new instance with the normal constructor function. As a result, any side effects of mutator methods (<code>setProperty</code> etc.) or init hooks are repeated during clone creation. There is no need to override <code>clone()</code> just to reproduce these internal settings!
					/// 
					/// Custom controls however can override <code>clone()</code> to implement additional clone steps. They usually will first call <code>clone()</code> on the super class and then modify the returned clone accordingly.
					/// 
					/// Applications <b>must never provide</b> the second parameter <code>aLocaleIds</code>. It is determined automatically for the root object (and its non-existence also serves as an indicator for the root object). Specifying it will break the implementation of <code>clone()</code>.
					/// </summary>
					/// <param name="sIdSuffix">a suffix to be appended to the cloned object ID</param>
					/// <param name="aLocalIds">an array of local IDs within the cloned hierarchy (internally used)</param>
					/// <param name="oOptions">configuration object</param>
					/// <param name="cloneChildren">Whether associations and aggregations will be cloned</param>
					/// <param name="cloneBindings">Whether bindings will be cloned</param>
					/// <returns>Reference to the newly created clone</returns>
					public extern virtual sap.ui.@base.ManagedObject clone(string sIdSuffix, string[] aLocalIds, object oOptions, bool cloneChildren = true, bool cloneBindings = true);

					/// <summary>
					/// Clones a tree of objects starting with the object on which clone is called first (root object).
					/// 
					/// The IDs within the newly created clone tree are derived from the original IDs by appending the given <code>sIdSuffix</code> (if no suffix is given, one will be created; it will be unique across multiple clone calls).
					/// 
					/// The <code>oOptions</code> configuration object can have the following properties: <ul> <li>The boolean value <code>cloneChildren</code> specifies whether associations/aggregations will be cloned</li> <li>The boolean value <code>cloneBindings</code> specifies if bindings will be cloned</li> </ul>
					/// 
					/// For each cloned object the following settings are cloned based on the metadata of the object and the defined options: <ul> <li>all properties that are not bound. If <code>cloneBinding</code> is <code>false</code>, even these properties will be cloned; the values are used by reference, they are not cloned</li> <li>all aggregated objects that are not bound. If <code>cloneBinding</code> is <code>false</code>, even the ones that are bound will be cloned; they are all cloned recursively using the same <code>sIdSuffix</code></li> <li>all associated controls; when an association points to an object inside the cloned object tree, then the cloned association will be modified to that it points to the clone of the target object. When the association points to a managed object outside of the cloned object tree, then its target won't be changed.</li> <li>all models set via <code>setModel()</code>; used by reference </li> <li>all property and aggregation bindings (if <code>cloneBindings</code> is <code>true</code>); the pure binding information (path, model name) is cloned, but all other information like template control or factory function, data type or formatter function are copied by reference. The bindings themselves are created anew as they are specific for the combination (object, property, model). As a result, any later changes to a binding of the original object are not reflected in the clone, but changes to e.g the type or template etc. are.</li> </ul>
					/// 
					/// Each clone is created by first collecting the above mentioned settings and then creating a new instance with the normal constructor function. As a result, any side effects of mutator methods (<code>setProperty</code> etc.) or init hooks are repeated during clone creation. There is no need to override <code>clone()</code> just to reproduce these internal settings!
					/// 
					/// Custom controls however can override <code>clone()</code> to implement additional clone steps. They usually will first call <code>clone()</code> on the super class and then modify the returned clone accordingly.
					/// 
					/// Applications <b>must never provide</b> the second parameter <code>aLocaleIds</code>. It is determined automatically for the root object (and its non-existence also serves as an indicator for the root object). Specifying it will break the implementation of <code>clone()</code>.
					/// </summary>
					/// <param name="sIdSuffix">a suffix to be appended to the cloned object ID</param>
					/// <param name="aLocalIds">an array of local IDs within the cloned hierarchy (internally used)</param>
					/// <param name="oOptions">configuration object</param>
					/// <param name="cloneChildren">Whether associations and aggregations will be cloned</param>
					/// <param name="cloneBindings">Whether bindings will be cloned</param>
					/// <returns>Reference to the newly created clone</returns>
					public extern virtual sap.ui.@base.ManagedObject clone(string sIdSuffix, object[] aLocalIds, object oOptions, bool cloneChildren = true, bool cloneBindings = true);

					/// <summary>
					/// Clones a tree of objects starting with the object on which clone is called first (root object).
					/// 
					/// The IDs within the newly created clone tree are derived from the original IDs by appending the given <code>sIdSuffix</code> (if no suffix is given, one will be created; it will be unique across multiple clone calls).
					/// 
					/// The <code>oOptions</code> configuration object can have the following properties: <ul> <li>The boolean value <code>cloneChildren</code> specifies whether associations/aggregations will be cloned</li> <li>The boolean value <code>cloneBindings</code> specifies if bindings will be cloned</li> </ul>
					/// 
					/// For each cloned object the following settings are cloned based on the metadata of the object and the defined options: <ul> <li>all properties that are not bound. If <code>cloneBinding</code> is <code>false</code>, even these properties will be cloned; the values are used by reference, they are not cloned</li> <li>all aggregated objects that are not bound. If <code>cloneBinding</code> is <code>false</code>, even the ones that are bound will be cloned; they are all cloned recursively using the same <code>sIdSuffix</code></li> <li>all associated controls; when an association points to an object inside the cloned object tree, then the cloned association will be modified to that it points to the clone of the target object. When the association points to a managed object outside of the cloned object tree, then its target won't be changed.</li> <li>all models set via <code>setModel()</code>; used by reference </li> <li>all property and aggregation bindings (if <code>cloneBindings</code> is <code>true</code>); the pure binding information (path, model name) is cloned, but all other information like template control or factory function, data type or formatter function are copied by reference. The bindings themselves are created anew as they are specific for the combination (object, property, model). As a result, any later changes to a binding of the original object are not reflected in the clone, but changes to e.g the type or template etc. are.</li> </ul>
					/// 
					/// Each clone is created by first collecting the above mentioned settings and then creating a new instance with the normal constructor function. As a result, any side effects of mutator methods (<code>setProperty</code> etc.) or init hooks are repeated during clone creation. There is no need to override <code>clone()</code> just to reproduce these internal settings!
					/// 
					/// Custom controls however can override <code>clone()</code> to implement additional clone steps. They usually will first call <code>clone()</code> on the super class and then modify the returned clone accordingly.
					/// 
					/// Applications <b>must never provide</b> the second parameter <code>aLocaleIds</code>. It is determined automatically for the root object (and its non-existence also serves as an indicator for the root object). Specifying it will break the implementation of <code>clone()</code>.
					/// </summary>
					/// <param name="sIdSuffix">a suffix to be appended to the cloned object ID</param>
					/// <param name="aLocalIds">an array of local IDs within the cloned hierarchy (internally used)</param>
					/// <param name="oOptions">configuration object</param>
					/// <returns>Reference to the newly created clone</returns>
					public extern virtual sap.ui.@base.ManagedObject clone(string sIdSuffix, string[] aLocalIds, object oOptions);

					/// <summary>
					/// Clones a tree of objects starting with the object on which clone is called first (root object).
					/// 
					/// The IDs within the newly created clone tree are derived from the original IDs by appending the given <code>sIdSuffix</code> (if no suffix is given, one will be created; it will be unique across multiple clone calls).
					/// 
					/// The <code>oOptions</code> configuration object can have the following properties: <ul> <li>The boolean value <code>cloneChildren</code> specifies whether associations/aggregations will be cloned</li> <li>The boolean value <code>cloneBindings</code> specifies if bindings will be cloned</li> </ul>
					/// 
					/// For each cloned object the following settings are cloned based on the metadata of the object and the defined options: <ul> <li>all properties that are not bound. If <code>cloneBinding</code> is <code>false</code>, even these properties will be cloned; the values are used by reference, they are not cloned</li> <li>all aggregated objects that are not bound. If <code>cloneBinding</code> is <code>false</code>, even the ones that are bound will be cloned; they are all cloned recursively using the same <code>sIdSuffix</code></li> <li>all associated controls; when an association points to an object inside the cloned object tree, then the cloned association will be modified to that it points to the clone of the target object. When the association points to a managed object outside of the cloned object tree, then its target won't be changed.</li> <li>all models set via <code>setModel()</code>; used by reference </li> <li>all property and aggregation bindings (if <code>cloneBindings</code> is <code>true</code>); the pure binding information (path, model name) is cloned, but all other information like template control or factory function, data type or formatter function are copied by reference. The bindings themselves are created anew as they are specific for the combination (object, property, model). As a result, any later changes to a binding of the original object are not reflected in the clone, but changes to e.g the type or template etc. are.</li> </ul>
					/// 
					/// Each clone is created by first collecting the above mentioned settings and then creating a new instance with the normal constructor function. As a result, any side effects of mutator methods (<code>setProperty</code> etc.) or init hooks are repeated during clone creation. There is no need to override <code>clone()</code> just to reproduce these internal settings!
					/// 
					/// Custom controls however can override <code>clone()</code> to implement additional clone steps. They usually will first call <code>clone()</code> on the super class and then modify the returned clone accordingly.
					/// 
					/// Applications <b>must never provide</b> the second parameter <code>aLocaleIds</code>. It is determined automatically for the root object (and its non-existence also serves as an indicator for the root object). Specifying it will break the implementation of <code>clone()</code>.
					/// </summary>
					/// <param name="sIdSuffix">a suffix to be appended to the cloned object ID</param>
					/// <param name="aLocalIds">an array of local IDs within the cloned hierarchy (internally used)</param>
					/// <param name="oOptions">configuration object</param>
					/// <returns>Reference to the newly created clone</returns>
					public extern virtual sap.ui.@base.ManagedObject clone(string sIdSuffix, object[] aLocalIds, object oOptions);

					/// <summary>
					/// Clones a tree of objects starting with the object on which clone is called first (root object).
					/// 
					/// The IDs within the newly created clone tree are derived from the original IDs by appending the given <code>sIdSuffix</code> (if no suffix is given, one will be created; it will be unique across multiple clone calls).
					/// 
					/// The <code>oOptions</code> configuration object can have the following properties: <ul> <li>The boolean value <code>cloneChildren</code> specifies whether associations/aggregations will be cloned</li> <li>The boolean value <code>cloneBindings</code> specifies if bindings will be cloned</li> </ul>
					/// 
					/// For each cloned object the following settings are cloned based on the metadata of the object and the defined options: <ul> <li>all properties that are not bound. If <code>cloneBinding</code> is <code>false</code>, even these properties will be cloned; the values are used by reference, they are not cloned</li> <li>all aggregated objects that are not bound. If <code>cloneBinding</code> is <code>false</code>, even the ones that are bound will be cloned; they are all cloned recursively using the same <code>sIdSuffix</code></li> <li>all associated controls; when an association points to an object inside the cloned object tree, then the cloned association will be modified to that it points to the clone of the target object. When the association points to a managed object outside of the cloned object tree, then its target won't be changed.</li> <li>all models set via <code>setModel()</code>; used by reference </li> <li>all property and aggregation bindings (if <code>cloneBindings</code> is <code>true</code>); the pure binding information (path, model name) is cloned, but all other information like template control or factory function, data type or formatter function are copied by reference. The bindings themselves are created anew as they are specific for the combination (object, property, model). As a result, any later changes to a binding of the original object are not reflected in the clone, but changes to e.g the type or template etc. are.</li> </ul>
					/// 
					/// Each clone is created by first collecting the above mentioned settings and then creating a new instance with the normal constructor function. As a result, any side effects of mutator methods (<code>setProperty</code> etc.) or init hooks are repeated during clone creation. There is no need to override <code>clone()</code> just to reproduce these internal settings!
					/// 
					/// Custom controls however can override <code>clone()</code> to implement additional clone steps. They usually will first call <code>clone()</code> on the super class and then modify the returned clone accordingly.
					/// 
					/// Applications <b>must never provide</b> the second parameter <code>aLocaleIds</code>. It is determined automatically for the root object (and its non-existence also serves as an indicator for the root object). Specifying it will break the implementation of <code>clone()</code>.
					/// </summary>
					/// <param name="sIdSuffix">a suffix to be appended to the cloned object ID</param>
					/// <param name="aLocalIds">an array of local IDs within the cloned hierarchy (internally used)</param>
					/// <returns>Reference to the newly created clone</returns>
					public extern virtual sap.ui.@base.ManagedObject clone(string sIdSuffix, string[] aLocalIds);

					/// <summary>
					/// Clones a tree of objects starting with the object on which clone is called first (root object).
					/// 
					/// The IDs within the newly created clone tree are derived from the original IDs by appending the given <code>sIdSuffix</code> (if no suffix is given, one will be created; it will be unique across multiple clone calls).
					/// 
					/// The <code>oOptions</code> configuration object can have the following properties: <ul> <li>The boolean value <code>cloneChildren</code> specifies whether associations/aggregations will be cloned</li> <li>The boolean value <code>cloneBindings</code> specifies if bindings will be cloned</li> </ul>
					/// 
					/// For each cloned object the following settings are cloned based on the metadata of the object and the defined options: <ul> <li>all properties that are not bound. If <code>cloneBinding</code> is <code>false</code>, even these properties will be cloned; the values are used by reference, they are not cloned</li> <li>all aggregated objects that are not bound. If <code>cloneBinding</code> is <code>false</code>, even the ones that are bound will be cloned; they are all cloned recursively using the same <code>sIdSuffix</code></li> <li>all associated controls; when an association points to an object inside the cloned object tree, then the cloned association will be modified to that it points to the clone of the target object. When the association points to a managed object outside of the cloned object tree, then its target won't be changed.</li> <li>all models set via <code>setModel()</code>; used by reference </li> <li>all property and aggregation bindings (if <code>cloneBindings</code> is <code>true</code>); the pure binding information (path, model name) is cloned, but all other information like template control or factory function, data type or formatter function are copied by reference. The bindings themselves are created anew as they are specific for the combination (object, property, model). As a result, any later changes to a binding of the original object are not reflected in the clone, but changes to e.g the type or template etc. are.</li> </ul>
					/// 
					/// Each clone is created by first collecting the above mentioned settings and then creating a new instance with the normal constructor function. As a result, any side effects of mutator methods (<code>setProperty</code> etc.) or init hooks are repeated during clone creation. There is no need to override <code>clone()</code> just to reproduce these internal settings!
					/// 
					/// Custom controls however can override <code>clone()</code> to implement additional clone steps. They usually will first call <code>clone()</code> on the super class and then modify the returned clone accordingly.
					/// 
					/// Applications <b>must never provide</b> the second parameter <code>aLocaleIds</code>. It is determined automatically for the root object (and its non-existence also serves as an indicator for the root object). Specifying it will break the implementation of <code>clone()</code>.
					/// </summary>
					/// <param name="sIdSuffix">a suffix to be appended to the cloned object ID</param>
					/// <param name="aLocalIds">an array of local IDs within the cloned hierarchy (internally used)</param>
					/// <returns>Reference to the newly created clone</returns>
					public extern virtual sap.ui.@base.ManagedObject clone(string sIdSuffix, object[] aLocalIds);

					/// <summary>
					/// Clones a tree of objects starting with the object on which clone is called first (root object).
					/// 
					/// The IDs within the newly created clone tree are derived from the original IDs by appending the given <code>sIdSuffix</code> (if no suffix is given, one will be created; it will be unique across multiple clone calls).
					/// 
					/// The <code>oOptions</code> configuration object can have the following properties: <ul> <li>The boolean value <code>cloneChildren</code> specifies whether associations/aggregations will be cloned</li> <li>The boolean value <code>cloneBindings</code> specifies if bindings will be cloned</li> </ul>
					/// 
					/// For each cloned object the following settings are cloned based on the metadata of the object and the defined options: <ul> <li>all properties that are not bound. If <code>cloneBinding</code> is <code>false</code>, even these properties will be cloned; the values are used by reference, they are not cloned</li> <li>all aggregated objects that are not bound. If <code>cloneBinding</code> is <code>false</code>, even the ones that are bound will be cloned; they are all cloned recursively using the same <code>sIdSuffix</code></li> <li>all associated controls; when an association points to an object inside the cloned object tree, then the cloned association will be modified to that it points to the clone of the target object. When the association points to a managed object outside of the cloned object tree, then its target won't be changed.</li> <li>all models set via <code>setModel()</code>; used by reference </li> <li>all property and aggregation bindings (if <code>cloneBindings</code> is <code>true</code>); the pure binding information (path, model name) is cloned, but all other information like template control or factory function, data type or formatter function are copied by reference. The bindings themselves are created anew as they are specific for the combination (object, property, model). As a result, any later changes to a binding of the original object are not reflected in the clone, but changes to e.g the type or template etc. are.</li> </ul>
					/// 
					/// Each clone is created by first collecting the above mentioned settings and then creating a new instance with the normal constructor function. As a result, any side effects of mutator methods (<code>setProperty</code> etc.) or init hooks are repeated during clone creation. There is no need to override <code>clone()</code> just to reproduce these internal settings!
					/// 
					/// Custom controls however can override <code>clone()</code> to implement additional clone steps. They usually will first call <code>clone()</code> on the super class and then modify the returned clone accordingly.
					/// 
					/// Applications <b>must never provide</b> the second parameter <code>aLocaleIds</code>. It is determined automatically for the root object (and its non-existence also serves as an indicator for the root object). Specifying it will break the implementation of <code>clone()</code>.
					/// </summary>
					/// <param name="sIdSuffix">a suffix to be appended to the cloned object ID</param>
					/// <returns>Reference to the newly created clone</returns>
					public extern virtual sap.ui.@base.ManagedObject clone(string sIdSuffix);

					/// <summary>
					/// Clones a tree of objects starting with the object on which clone is called first (root object).
					/// 
					/// The IDs within the newly created clone tree are derived from the original IDs by appending the given <code>sIdSuffix</code> (if no suffix is given, one will be created; it will be unique across multiple clone calls).
					/// 
					/// The <code>oOptions</code> configuration object can have the following properties: <ul> <li>The boolean value <code>cloneChildren</code> specifies whether associations/aggregations will be cloned</li> <li>The boolean value <code>cloneBindings</code> specifies if bindings will be cloned</li> </ul>
					/// 
					/// For each cloned object the following settings are cloned based on the metadata of the object and the defined options: <ul> <li>all properties that are not bound. If <code>cloneBinding</code> is <code>false</code>, even these properties will be cloned; the values are used by reference, they are not cloned</li> <li>all aggregated objects that are not bound. If <code>cloneBinding</code> is <code>false</code>, even the ones that are bound will be cloned; they are all cloned recursively using the same <code>sIdSuffix</code></li> <li>all associated controls; when an association points to an object inside the cloned object tree, then the cloned association will be modified to that it points to the clone of the target object. When the association points to a managed object outside of the cloned object tree, then its target won't be changed.</li> <li>all models set via <code>setModel()</code>; used by reference </li> <li>all property and aggregation bindings (if <code>cloneBindings</code> is <code>true</code>); the pure binding information (path, model name) is cloned, but all other information like template control or factory function, data type or formatter function are copied by reference. The bindings themselves are created anew as they are specific for the combination (object, property, model). As a result, any later changes to a binding of the original object are not reflected in the clone, but changes to e.g the type or template etc. are.</li> </ul>
					/// 
					/// Each clone is created by first collecting the above mentioned settings and then creating a new instance with the normal constructor function. As a result, any side effects of mutator methods (<code>setProperty</code> etc.) or init hooks are repeated during clone creation. There is no need to override <code>clone()</code> just to reproduce these internal settings!
					/// 
					/// Custom controls however can override <code>clone()</code> to implement additional clone steps. They usually will first call <code>clone()</code> on the super class and then modify the returned clone accordingly.
					/// 
					/// Applications <b>must never provide</b> the second parameter <code>aLocaleIds</code>. It is determined automatically for the root object (and its non-existence also serves as an indicator for the root object). Specifying it will break the implementation of <code>clone()</code>.
					/// </summary>
					/// <returns>Reference to the newly created clone</returns>
					public extern virtual sap.ui.@base.ManagedObject clone();

					/// <summary>
					/// Clones a tree of objects starting with the object on which clone is called first (root object).
					/// 
					/// The IDs within the newly created clone tree are derived from the original IDs by appending the given <code>sIdSuffix</code> (if no suffix is given, one will be created; it will be unique across multiple clone calls).
					/// 
					/// The <code>oOptions</code> configuration object can have the following properties: <ul> <li>The boolean value <code>cloneChildren</code> specifies whether associations/aggregations will be cloned</li> <li>The boolean value <code>cloneBindings</code> specifies if bindings will be cloned</li> </ul>
					/// 
					/// For each cloned object the following settings are cloned based on the metadata of the object and the defined options: <ul> <li>all properties that are not bound. If <code>cloneBinding</code> is <code>false</code>, even these properties will be cloned; the values are used by reference, they are not cloned</li> <li>all aggregated objects that are not bound. If <code>cloneBinding</code> is <code>false</code>, even the ones that are bound will be cloned; they are all cloned recursively using the same <code>sIdSuffix</code></li> <li>all associated controls; when an association points to an object inside the cloned object tree, then the cloned association will be modified to that it points to the clone of the target object. When the association points to a managed object outside of the cloned object tree, then its target won't be changed.</li> <li>all models set via <code>setModel()</code>; used by reference </li> <li>all property and aggregation bindings (if <code>cloneBindings</code> is <code>true</code>); the pure binding information (path, model name) is cloned, but all other information like template control or factory function, data type or formatter function are copied by reference. The bindings themselves are created anew as they are specific for the combination (object, property, model). As a result, any later changes to a binding of the original object are not reflected in the clone, but changes to e.g the type or template etc. are.</li> </ul>
					/// 
					/// Each clone is created by first collecting the above mentioned settings and then creating a new instance with the normal constructor function. As a result, any side effects of mutator methods (<code>setProperty</code> etc.) or init hooks are repeated during clone creation. There is no need to override <code>clone()</code> just to reproduce these internal settings!
					/// 
					/// Custom controls however can override <code>clone()</code> to implement additional clone steps. They usually will first call <code>clone()</code> on the super class and then modify the returned clone accordingly.
					/// 
					/// Applications <b>must never provide</b> the second parameter <code>aLocaleIds</code>. It is determined automatically for the root object (and its non-existence also serves as an indicator for the root object). Specifying it will break the implementation of <code>clone()</code>.
					/// </summary>
					/// <param name="aLocalIds">an array of local IDs within the cloned hierarchy (internally used)</param>
					/// <returns>Reference to the newly created clone</returns>
					public extern virtual sap.ui.@base.ManagedObject clone(string[] aLocalIds);

					/// <summary>
					/// Clones a tree of objects starting with the object on which clone is called first (root object).
					/// 
					/// The IDs within the newly created clone tree are derived from the original IDs by appending the given <code>sIdSuffix</code> (if no suffix is given, one will be created; it will be unique across multiple clone calls).
					/// 
					/// The <code>oOptions</code> configuration object can have the following properties: <ul> <li>The boolean value <code>cloneChildren</code> specifies whether associations/aggregations will be cloned</li> <li>The boolean value <code>cloneBindings</code> specifies if bindings will be cloned</li> </ul>
					/// 
					/// For each cloned object the following settings are cloned based on the metadata of the object and the defined options: <ul> <li>all properties that are not bound. If <code>cloneBinding</code> is <code>false</code>, even these properties will be cloned; the values are used by reference, they are not cloned</li> <li>all aggregated objects that are not bound. If <code>cloneBinding</code> is <code>false</code>, even the ones that are bound will be cloned; they are all cloned recursively using the same <code>sIdSuffix</code></li> <li>all associated controls; when an association points to an object inside the cloned object tree, then the cloned association will be modified to that it points to the clone of the target object. When the association points to a managed object outside of the cloned object tree, then its target won't be changed.</li> <li>all models set via <code>setModel()</code>; used by reference </li> <li>all property and aggregation bindings (if <code>cloneBindings</code> is <code>true</code>); the pure binding information (path, model name) is cloned, but all other information like template control or factory function, data type or formatter function are copied by reference. The bindings themselves are created anew as they are specific for the combination (object, property, model). As a result, any later changes to a binding of the original object are not reflected in the clone, but changes to e.g the type or template etc. are.</li> </ul>
					/// 
					/// Each clone is created by first collecting the above mentioned settings and then creating a new instance with the normal constructor function. As a result, any side effects of mutator methods (<code>setProperty</code> etc.) or init hooks are repeated during clone creation. There is no need to override <code>clone()</code> just to reproduce these internal settings!
					/// 
					/// Custom controls however can override <code>clone()</code> to implement additional clone steps. They usually will first call <code>clone()</code> on the super class and then modify the returned clone accordingly.
					/// 
					/// Applications <b>must never provide</b> the second parameter <code>aLocaleIds</code>. It is determined automatically for the root object (and its non-existence also serves as an indicator for the root object). Specifying it will break the implementation of <code>clone()</code>.
					/// </summary>
					/// <param name="aLocalIds">an array of local IDs within the cloned hierarchy (internally used)</param>
					/// <returns>Reference to the newly created clone</returns>
					public extern virtual sap.ui.@base.ManagedObject clone(object[] aLocalIds);

					/// <summary>
					/// Clones a tree of objects starting with the object on which clone is called first (root object).
					/// 
					/// The IDs within the newly created clone tree are derived from the original IDs by appending the given <code>sIdSuffix</code> (if no suffix is given, one will be created; it will be unique across multiple clone calls).
					/// 
					/// The <code>oOptions</code> configuration object can have the following properties: <ul> <li>The boolean value <code>cloneChildren</code> specifies whether associations/aggregations will be cloned</li> <li>The boolean value <code>cloneBindings</code> specifies if bindings will be cloned</li> </ul>
					/// 
					/// For each cloned object the following settings are cloned based on the metadata of the object and the defined options: <ul> <li>all properties that are not bound. If <code>cloneBinding</code> is <code>false</code>, even these properties will be cloned; the values are used by reference, they are not cloned</li> <li>all aggregated objects that are not bound. If <code>cloneBinding</code> is <code>false</code>, even the ones that are bound will be cloned; they are all cloned recursively using the same <code>sIdSuffix</code></li> <li>all associated controls; when an association points to an object inside the cloned object tree, then the cloned association will be modified to that it points to the clone of the target object. When the association points to a managed object outside of the cloned object tree, then its target won't be changed.</li> <li>all models set via <code>setModel()</code>; used by reference </li> <li>all property and aggregation bindings (if <code>cloneBindings</code> is <code>true</code>); the pure binding information (path, model name) is cloned, but all other information like template control or factory function, data type or formatter function are copied by reference. The bindings themselves are created anew as they are specific for the combination (object, property, model). As a result, any later changes to a binding of the original object are not reflected in the clone, but changes to e.g the type or template etc. are.</li> </ul>
					/// 
					/// Each clone is created by first collecting the above mentioned settings and then creating a new instance with the normal constructor function. As a result, any side effects of mutator methods (<code>setProperty</code> etc.) or init hooks are repeated during clone creation. There is no need to override <code>clone()</code> just to reproduce these internal settings!
					/// 
					/// Custom controls however can override <code>clone()</code> to implement additional clone steps. They usually will first call <code>clone()</code> on the super class and then modify the returned clone accordingly.
					/// 
					/// Applications <b>must never provide</b> the second parameter <code>aLocaleIds</code>. It is determined automatically for the root object (and its non-existence also serves as an indicator for the root object). Specifying it will break the implementation of <code>clone()</code>.
					/// </summary>
					/// <param name="aLocalIds">an array of local IDs within the cloned hierarchy (internally used)</param>
					/// <param name="oOptions">configuration object</param>
					/// <returns>Reference to the newly created clone</returns>
					public extern virtual sap.ui.@base.ManagedObject clone(string[] aLocalIds, object oOptions);

					/// <summary>
					/// Clones a tree of objects starting with the object on which clone is called first (root object).
					/// 
					/// The IDs within the newly created clone tree are derived from the original IDs by appending the given <code>sIdSuffix</code> (if no suffix is given, one will be created; it will be unique across multiple clone calls).
					/// 
					/// The <code>oOptions</code> configuration object can have the following properties: <ul> <li>The boolean value <code>cloneChildren</code> specifies whether associations/aggregations will be cloned</li> <li>The boolean value <code>cloneBindings</code> specifies if bindings will be cloned</li> </ul>
					/// 
					/// For each cloned object the following settings are cloned based on the metadata of the object and the defined options: <ul> <li>all properties that are not bound. If <code>cloneBinding</code> is <code>false</code>, even these properties will be cloned; the values are used by reference, they are not cloned</li> <li>all aggregated objects that are not bound. If <code>cloneBinding</code> is <code>false</code>, even the ones that are bound will be cloned; they are all cloned recursively using the same <code>sIdSuffix</code></li> <li>all associated controls; when an association points to an object inside the cloned object tree, then the cloned association will be modified to that it points to the clone of the target object. When the association points to a managed object outside of the cloned object tree, then its target won't be changed.</li> <li>all models set via <code>setModel()</code>; used by reference </li> <li>all property and aggregation bindings (if <code>cloneBindings</code> is <code>true</code>); the pure binding information (path, model name) is cloned, but all other information like template control or factory function, data type or formatter function are copied by reference. The bindings themselves are created anew as they are specific for the combination (object, property, model). As a result, any later changes to a binding of the original object are not reflected in the clone, but changes to e.g the type or template etc. are.</li> </ul>
					/// 
					/// Each clone is created by first collecting the above mentioned settings and then creating a new instance with the normal constructor function. As a result, any side effects of mutator methods (<code>setProperty</code> etc.) or init hooks are repeated during clone creation. There is no need to override <code>clone()</code> just to reproduce these internal settings!
					/// 
					/// Custom controls however can override <code>clone()</code> to implement additional clone steps. They usually will first call <code>clone()</code> on the super class and then modify the returned clone accordingly.
					/// 
					/// Applications <b>must never provide</b> the second parameter <code>aLocaleIds</code>. It is determined automatically for the root object (and its non-existence also serves as an indicator for the root object). Specifying it will break the implementation of <code>clone()</code>.
					/// </summary>
					/// <param name="aLocalIds">an array of local IDs within the cloned hierarchy (internally used)</param>
					/// <param name="oOptions">configuration object</param>
					/// <returns>Reference to the newly created clone</returns>
					public extern virtual sap.ui.@base.ManagedObject clone(object[] aLocalIds, object oOptions);

					/// <summary>
					/// Clones a tree of objects starting with the object on which clone is called first (root object).
					/// 
					/// The IDs within the newly created clone tree are derived from the original IDs by appending the given <code>sIdSuffix</code> (if no suffix is given, one will be created; it will be unique across multiple clone calls).
					/// 
					/// The <code>oOptions</code> configuration object can have the following properties: <ul> <li>The boolean value <code>cloneChildren</code> specifies whether associations/aggregations will be cloned</li> <li>The boolean value <code>cloneBindings</code> specifies if bindings will be cloned</li> </ul>
					/// 
					/// For each cloned object the following settings are cloned based on the metadata of the object and the defined options: <ul> <li>all properties that are not bound. If <code>cloneBinding</code> is <code>false</code>, even these properties will be cloned; the values are used by reference, they are not cloned</li> <li>all aggregated objects that are not bound. If <code>cloneBinding</code> is <code>false</code>, even the ones that are bound will be cloned; they are all cloned recursively using the same <code>sIdSuffix</code></li> <li>all associated controls; when an association points to an object inside the cloned object tree, then the cloned association will be modified to that it points to the clone of the target object. When the association points to a managed object outside of the cloned object tree, then its target won't be changed.</li> <li>all models set via <code>setModel()</code>; used by reference </li> <li>all property and aggregation bindings (if <code>cloneBindings</code> is <code>true</code>); the pure binding information (path, model name) is cloned, but all other information like template control or factory function, data type or formatter function are copied by reference. The bindings themselves are created anew as they are specific for the combination (object, property, model). As a result, any later changes to a binding of the original object are not reflected in the clone, but changes to e.g the type or template etc. are.</li> </ul>
					/// 
					/// Each clone is created by first collecting the above mentioned settings and then creating a new instance with the normal constructor function. As a result, any side effects of mutator methods (<code>setProperty</code> etc.) or init hooks are repeated during clone creation. There is no need to override <code>clone()</code> just to reproduce these internal settings!
					/// 
					/// Custom controls however can override <code>clone()</code> to implement additional clone steps. They usually will first call <code>clone()</code> on the super class and then modify the returned clone accordingly.
					/// 
					/// Applications <b>must never provide</b> the second parameter <code>aLocaleIds</code>. It is determined automatically for the root object (and its non-existence also serves as an indicator for the root object). Specifying it will break the implementation of <code>clone()</code>.
					/// </summary>
					/// <param name="oOptions">configuration object</param>
					/// <returns>Reference to the newly created clone</returns>
					public extern virtual sap.ui.@base.ManagedObject clone(object oOptions);

					/// <summary>
					/// Clones a tree of objects starting with the object on which clone is called first (root object).
					/// 
					/// The IDs within the newly created clone tree are derived from the original IDs by appending the given <code>sIdSuffix</code> (if no suffix is given, one will be created; it will be unique across multiple clone calls).
					/// 
					/// The <code>oOptions</code> configuration object can have the following properties: <ul> <li>The boolean value <code>cloneChildren</code> specifies whether associations/aggregations will be cloned</li> <li>The boolean value <code>cloneBindings</code> specifies if bindings will be cloned</li> </ul>
					/// 
					/// For each cloned object the following settings are cloned based on the metadata of the object and the defined options: <ul> <li>all properties that are not bound. If <code>cloneBinding</code> is <code>false</code>, even these properties will be cloned; the values are used by reference, they are not cloned</li> <li>all aggregated objects that are not bound. If <code>cloneBinding</code> is <code>false</code>, even the ones that are bound will be cloned; they are all cloned recursively using the same <code>sIdSuffix</code></li> <li>all associated controls; when an association points to an object inside the cloned object tree, then the cloned association will be modified to that it points to the clone of the target object. When the association points to a managed object outside of the cloned object tree, then its target won't be changed.</li> <li>all models set via <code>setModel()</code>; used by reference </li> <li>all property and aggregation bindings (if <code>cloneBindings</code> is <code>true</code>); the pure binding information (path, model name) is cloned, but all other information like template control or factory function, data type or formatter function are copied by reference. The bindings themselves are created anew as they are specific for the combination (object, property, model). As a result, any later changes to a binding of the original object are not reflected in the clone, but changes to e.g the type or template etc. are.</li> </ul>
					/// 
					/// Each clone is created by first collecting the above mentioned settings and then creating a new instance with the normal constructor function. As a result, any side effects of mutator methods (<code>setProperty</code> etc.) or init hooks are repeated during clone creation. There is no need to override <code>clone()</code> just to reproduce these internal settings!
					/// 
					/// Custom controls however can override <code>clone()</code> to implement additional clone steps. They usually will first call <code>clone()</code> on the super class and then modify the returned clone accordingly.
					/// 
					/// Applications <b>must never provide</b> the second parameter <code>aLocaleIds</code>. It is determined automatically for the root object (and its non-existence also serves as an indicator for the root object). Specifying it will break the implementation of <code>clone()</code>.
					/// </summary>
					/// <param name="aLocalIds">an array of local IDs within the cloned hierarchy (internally used)</param>
					/// <param name="oOptions">configuration object</param>
					/// <param name="cloneChildren">Whether associations and aggregations will be cloned</param>
					/// <param name="cloneBindings">Whether bindings will be cloned</param>
					/// <returns>Reference to the newly created clone</returns>
					public extern virtual sap.ui.@base.ManagedObject clone(string[] aLocalIds, object oOptions, bool cloneChildren = true, bool cloneBindings = true);

					/// <summary>
					/// Clones a tree of objects starting with the object on which clone is called first (root object).
					/// 
					/// The IDs within the newly created clone tree are derived from the original IDs by appending the given <code>sIdSuffix</code> (if no suffix is given, one will be created; it will be unique across multiple clone calls).
					/// 
					/// The <code>oOptions</code> configuration object can have the following properties: <ul> <li>The boolean value <code>cloneChildren</code> specifies whether associations/aggregations will be cloned</li> <li>The boolean value <code>cloneBindings</code> specifies if bindings will be cloned</li> </ul>
					/// 
					/// For each cloned object the following settings are cloned based on the metadata of the object and the defined options: <ul> <li>all properties that are not bound. If <code>cloneBinding</code> is <code>false</code>, even these properties will be cloned; the values are used by reference, they are not cloned</li> <li>all aggregated objects that are not bound. If <code>cloneBinding</code> is <code>false</code>, even the ones that are bound will be cloned; they are all cloned recursively using the same <code>sIdSuffix</code></li> <li>all associated controls; when an association points to an object inside the cloned object tree, then the cloned association will be modified to that it points to the clone of the target object. When the association points to a managed object outside of the cloned object tree, then its target won't be changed.</li> <li>all models set via <code>setModel()</code>; used by reference </li> <li>all property and aggregation bindings (if <code>cloneBindings</code> is <code>true</code>); the pure binding information (path, model name) is cloned, but all other information like template control or factory function, data type or formatter function are copied by reference. The bindings themselves are created anew as they are specific for the combination (object, property, model). As a result, any later changes to a binding of the original object are not reflected in the clone, but changes to e.g the type or template etc. are.</li> </ul>
					/// 
					/// Each clone is created by first collecting the above mentioned settings and then creating a new instance with the normal constructor function. As a result, any side effects of mutator methods (<code>setProperty</code> etc.) or init hooks are repeated during clone creation. There is no need to override <code>clone()</code> just to reproduce these internal settings!
					/// 
					/// Custom controls however can override <code>clone()</code> to implement additional clone steps. They usually will first call <code>clone()</code> on the super class and then modify the returned clone accordingly.
					/// 
					/// Applications <b>must never provide</b> the second parameter <code>aLocaleIds</code>. It is determined automatically for the root object (and its non-existence also serves as an indicator for the root object). Specifying it will break the implementation of <code>clone()</code>.
					/// </summary>
					/// <param name="aLocalIds">an array of local IDs within the cloned hierarchy (internally used)</param>
					/// <param name="oOptions">configuration object</param>
					/// <param name="cloneChildren">Whether associations and aggregations will be cloned</param>
					/// <param name="cloneBindings">Whether bindings will be cloned</param>
					/// <returns>Reference to the newly created clone</returns>
					public extern virtual sap.ui.@base.ManagedObject clone(object[] aLocalIds, object oOptions, bool cloneChildren = true, bool cloneBindings = true);

					/// <summary>
					/// Clones a tree of objects starting with the object on which clone is called first (root object).
					/// 
					/// The IDs within the newly created clone tree are derived from the original IDs by appending the given <code>sIdSuffix</code> (if no suffix is given, one will be created; it will be unique across multiple clone calls).
					/// 
					/// The <code>oOptions</code> configuration object can have the following properties: <ul> <li>The boolean value <code>cloneChildren</code> specifies whether associations/aggregations will be cloned</li> <li>The boolean value <code>cloneBindings</code> specifies if bindings will be cloned</li> </ul>
					/// 
					/// For each cloned object the following settings are cloned based on the metadata of the object and the defined options: <ul> <li>all properties that are not bound. If <code>cloneBinding</code> is <code>false</code>, even these properties will be cloned; the values are used by reference, they are not cloned</li> <li>all aggregated objects that are not bound. If <code>cloneBinding</code> is <code>false</code>, even the ones that are bound will be cloned; they are all cloned recursively using the same <code>sIdSuffix</code></li> <li>all associated controls; when an association points to an object inside the cloned object tree, then the cloned association will be modified to that it points to the clone of the target object. When the association points to a managed object outside of the cloned object tree, then its target won't be changed.</li> <li>all models set via <code>setModel()</code>; used by reference </li> <li>all property and aggregation bindings (if <code>cloneBindings</code> is <code>true</code>); the pure binding information (path, model name) is cloned, but all other information like template control or factory function, data type or formatter function are copied by reference. The bindings themselves are created anew as they are specific for the combination (object, property, model). As a result, any later changes to a binding of the original object are not reflected in the clone, but changes to e.g the type or template etc. are.</li> </ul>
					/// 
					/// Each clone is created by first collecting the above mentioned settings and then creating a new instance with the normal constructor function. As a result, any side effects of mutator methods (<code>setProperty</code> etc.) or init hooks are repeated during clone creation. There is no need to override <code>clone()</code> just to reproduce these internal settings!
					/// 
					/// Custom controls however can override <code>clone()</code> to implement additional clone steps. They usually will first call <code>clone()</code> on the super class and then modify the returned clone accordingly.
					/// 
					/// Applications <b>must never provide</b> the second parameter <code>aLocaleIds</code>. It is determined automatically for the root object (and its non-existence also serves as an indicator for the root object). Specifying it will break the implementation of <code>clone()</code>.
					/// </summary>
					/// <param name="oOptions">configuration object</param>
					/// <param name="cloneChildren">Whether associations and aggregations will be cloned</param>
					/// <param name="cloneBindings">Whether bindings will be cloned</param>
					/// <returns>Reference to the newly created clone</returns>
					public extern virtual sap.ui.@base.ManagedObject clone(object oOptions, bool cloneChildren = true, bool cloneBindings = true);

					/// <summary>
					/// Clones a tree of objects starting with the object on which clone is called first (root object).
					/// 
					/// The IDs within the newly created clone tree are derived from the original IDs by appending the given <code>sIdSuffix</code> (if no suffix is given, one will be created; it will be unique across multiple clone calls).
					/// 
					/// The <code>oOptions</code> configuration object can have the following properties: <ul> <li>The boolean value <code>cloneChildren</code> specifies whether associations/aggregations will be cloned</li> <li>The boolean value <code>cloneBindings</code> specifies if bindings will be cloned</li> </ul>
					/// 
					/// For each cloned object the following settings are cloned based on the metadata of the object and the defined options: <ul> <li>all properties that are not bound. If <code>cloneBinding</code> is <code>false</code>, even these properties will be cloned; the values are used by reference, they are not cloned</li> <li>all aggregated objects that are not bound. If <code>cloneBinding</code> is <code>false</code>, even the ones that are bound will be cloned; they are all cloned recursively using the same <code>sIdSuffix</code></li> <li>all associated controls; when an association points to an object inside the cloned object tree, then the cloned association will be modified to that it points to the clone of the target object. When the association points to a managed object outside of the cloned object tree, then its target won't be changed.</li> <li>all models set via <code>setModel()</code>; used by reference </li> <li>all property and aggregation bindings (if <code>cloneBindings</code> is <code>true</code>); the pure binding information (path, model name) is cloned, but all other information like template control or factory function, data type or formatter function are copied by reference. The bindings themselves are created anew as they are specific for the combination (object, property, model). As a result, any later changes to a binding of the original object are not reflected in the clone, but changes to e.g the type or template etc. are.</li> </ul>
					/// 
					/// Each clone is created by first collecting the above mentioned settings and then creating a new instance with the normal constructor function. As a result, any side effects of mutator methods (<code>setProperty</code> etc.) or init hooks are repeated during clone creation. There is no need to override <code>clone()</code> just to reproduce these internal settings!
					/// 
					/// Custom controls however can override <code>clone()</code> to implement additional clone steps. They usually will first call <code>clone()</code> on the super class and then modify the returned clone accordingly.
					/// 
					/// Applications <b>must never provide</b> the second parameter <code>aLocaleIds</code>. It is determined automatically for the root object (and its non-existence also serves as an indicator for the root object). Specifying it will break the implementation of <code>clone()</code>.
					/// </summary>
					/// <param name="cloneChildren">Whether associations and aggregations will be cloned</param>
					/// <param name="cloneBindings">Whether bindings will be cloned</param>
					/// <returns>Reference to the newly created clone</returns>
					public extern virtual sap.ui.@base.ManagedObject clone(bool cloneChildren = true, bool cloneBindings = true);

					/// <summary>
					/// Creates a new ManagedObject from the given data.
					/// 
					/// If <code>vData</code> is a managed object already, that object is returned. If <code>vData</code> is an object (literal), then a new object is created with <code>vData</code> as settings. The type of the object is either determined by a property of name <code>Type</code> (capital 'T') in the <code>vData</code> or by a property <code>type</code> (lower case 't') in the <code>oKeyInfo</code> object. In both cases, the type can be specified by name (dot separated name of the class) or by the constructor function of the class.
					/// </summary>
					/// <param name="vData">the data to create the object from</param>
					/// <param name="oKeyInfo"></param>
					/// <param name="oScope">Scope object to resolve types and formatters in bindings</param>
					public extern static void create(Union<sap.ui.@base.ManagedObject, object> vData, object oKeyInfo, object oScope);

					/// <summary>
					/// Creates a new ManagedObject from the given data.
					/// 
					/// If <code>vData</code> is a managed object already, that object is returned. If <code>vData</code> is an object (literal), then a new object is created with <code>vData</code> as settings. The type of the object is either determined by a property of name <code>Type</code> (capital 'T') in the <code>vData</code> or by a property <code>type</code> (lower case 't') in the <code>oKeyInfo</code> object. In both cases, the type can be specified by name (dot separated name of the class) or by the constructor function of the class.
					/// </summary>
					/// <param name="vData">the data to create the object from</param>
					/// <param name="oKeyInfo"></param>
					public extern static void create(Union<sap.ui.@base.ManagedObject, object> vData, object oKeyInfo);

					/// <summary>
					/// Creates a new ManagedObject from the given data.
					/// 
					/// If <code>vData</code> is a managed object already, that object is returned. If <code>vData</code> is an object (literal), then a new object is created with <code>vData</code> as settings. The type of the object is either determined by a property of name <code>Type</code> (capital 'T') in the <code>vData</code> or by a property <code>type</code> (lower case 't') in the <code>oKeyInfo</code> object. In both cases, the type can be specified by name (dot separated name of the class) or by the constructor function of the class.
					/// </summary>
					/// <param name="vData">the data to create the object from</param>
					public extern static void create(Union<sap.ui.@base.ManagedObject, object> vData);

					/// <summary>
					/// Cleans up the resources associated with this object and all its aggregated children.
					/// 
					/// After an object has been destroyed, it can no longer be used in!
					/// 
					/// Applications should call this method if they don't need the object any longer.
					/// </summary>
					/// <param name="bSuppressInvalidate">if true, this ManagedObject is not marked as changed</param>
					public extern virtual void destroy(bool bSuppressInvalidate);

					/// <summary>
					/// Cleans up the resources associated with this object and all its aggregated children.
					/// 
					/// After an object has been destroyed, it can no longer be used in!
					/// 
					/// Applications should call this method if they don't need the object any longer.
					/// </summary>
					public extern virtual void destroy();

					/// <summary>
					/// Destroys (all) the managed object(s) in the aggregation named <code>sAggregationName</code> and empties the aggregation. If the aggregation did contain any object, this ManagedObject is marked as changed.
					/// 
					/// <b>Note:</b> This method is a low-level API as described in <a href="#lowlevelapi">the class documentation</a>. Applications or frameworks must not use this method to generically destroy all objects in an aggregation. Use the concrete method destroy<i>XYZ</i> for aggregation 'XYZ' instead.
					/// </summary>
					/// <param name="sAggregationName">the name of the aggregation</param>
					/// <param name="bSuppressInvalidate">if true, this ManagedObject is not marked as changed</param>
					/// <returns>Returns <code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.@base.ManagedObject destroyAggregation(string sAggregationName, bool bSuppressInvalidate);

					/// <summary>
					/// Destroys (all) the managed object(s) in the aggregation named <code>sAggregationName</code> and empties the aggregation. If the aggregation did contain any object, this ManagedObject is marked as changed.
					/// 
					/// <b>Note:</b> This method is a low-level API as described in <a href="#lowlevelapi">the class documentation</a>. Applications or frameworks must not use this method to generically destroy all objects in an aggregation. Use the concrete method destroy<i>XYZ</i> for aggregation 'XYZ' instead.
					/// </summary>
					/// <param name="sAggregationName">the name of the aggregation</param>
					/// <returns>Returns <code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.@base.ManagedObject destroyAggregation(string sAggregationName);

					/// <summary>
					/// Escapes the given value so it can be used in the constructor's settings object. Should be used when property values are initialized with static string values which could contain binding characters (curly braces).
					/// </summary>
					/// <param name="vValue">Value to escape; only needs to be done for string values, but the call will work for all types</param>
					/// <returns>The given value, escaped for usage as static property value in the constructor's settings object (or unchanged, if not of type string)</returns>
					public extern static object escapeSettingsValue(object vValue);

					/// <summary>
					/// Defines a new subclass of ManagedObject with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> can contain the same information that {@link sap.ui.base.Object.extend} already accepts, plus the following new properties in the 'metadata' object literal:
					/// 
					/// <ul> <li><code>library : <i>string</i></code></li> <li><code>properties : <i>object</i></code></li> <li><code>defaultProperty : <i>string</i></code></li> <li><code>aggregations : <i>object</i></code></li> <li><code>defaultAggregation : <i>string</i></code></li> <li><code>associations : <i>object</i></code></li> <li><code>events : <i>object</i></code></li> <li><code>specialSettings : <i>object</i></code>// this one is still experimental and not for public usage!</li> </ul>
					/// 
					/// Each of these properties is explained in more detail lateron.
					/// 
					/// Example: <pre>
					/// ManagedObect.extend('sap.mylib.MyClass', {
					///   metadata : {
					///     library: 'sap.mylib',
					///     properties : {
					///       value: 'string',
					///       width: 'sap.ui.core.CSSSize',
					///       height: { type: 'sap.ui.core.CSSSize', defaultValue: '100%'}
					///       description: { type: 'string', defaultValue: '', selector: '#{id}-desc'}
					///     },
					///     defaultProperty : 'value',
					///     aggregations : {
					///       header : { type: 'sap.mylib.FancyHeader', multiple : false }
					///       items : 'sap.ui.core.Control',
					///       buttons: { type: 'sap.mylib.Button', multiple : true, selector: '#{id} > .sapMLButtonsSection'}
					///     },
					///     defaultAggregation : 'items',
					///     associations : {
					///       initiallyFocused : { type: 'sap.ui.core.Control' }
					///     },
					///     events: {
					///       beforeOpen : {
					///         parameters : {
					///           opener : { type: 'sap.ui.core.Control' }
					///         }
					///       }
					///     },
					///   },
					/// 
					///   init: function() {
					///   }
					/// 
					/// }); // end of 'extend' call
					/// </pre>
					/// 
					/// Detailed explanation of properties<br>
					/// 
					/// <b>'library'</b> : <i>string</i><br> Name of the library that the new subclass should belong to. If the subclass is a control or element, it will automatically register with that library so that authoring tools can discover it. By convention, the name of the subclass should have the library name as a prefix, e.g. 'sap.ui.commons.Panel' belongs to library 'sap.ui.commons'.
					/// 
					/// <b>'properties'</b> : <i>object</i><br> An object literal whose properties each define a new managed property in the ManagedObject subclass. The value can either be a simple string which then will be assumed to be the type of the new property or it can be an object literal with the following properties <ul> <li><code>type: <i>string</i></code> type of the new property. Must either be one of the built-in types 'string', 'boolean', 'int', 'float', 'object' or 'any', or a type created and registered with {@link sap.ui.base.DataType.createType} or an array type based on one of the previous types.</li> <li><code>group:<i>string</i></code> a semantic grouping of the properties, intended to be used in design time tools. Allowed values are (case sensitive): Accessibility, Appearance, Behavior, Data, Designtime, Dimension, Identification, Misc</li> <li><code>defaultValue: <i>any</i></code> the default value for the property or null if there is no defaultValue.</li> <li><code>bindable: <i>boolean|string</i></code> (either can be omitted or set to the boolean value <code>true</code> or the magic string 'bindable') If set to <code>true</code> or 'bindable', additional named methods <code>bind<i>Name</i></code> and <code>unbind<i>Name</i></code> are generated as convenience. Despite its name, setting this flag is not mandatory to make the managed property bindable. The generic methods {@link #bindProperty} and {@link #unbindProperty} can always be used. </li> <li><code>selector: <i>string</i></code> either can be omitted or set to a valid selector string as defined by the {@link https://developer.mozilla.org/en-US/docs/Web/API/Element/querySelector Element.prototype.querySelector} method should locate the DOM element that rendered this property's value. It should only be set for properties that have a visual text representation in the DOM.
					/// 
					/// In addition to the CSS selector syntax, the selector string can contain the placeholder <code>{id}</code> (multiple times). Before evaluating the selector in the context of an Element or Control, all occurrences of the placeholder have to be replaced by the (potentially escaped) ID of that Element or Control. In fact, any selector should start with <code>#{id}</code> to ensure that the query result is limited to the desired Element or Control.
					/// 
					/// <b>Note</b>: there is a convenience method {@link sap.ui.core.Element#getDomRefForSetting} that evaluates the selector in the context of a concrete Element or Control instance. It also handles the placeholder <code>{id}</code>. Only selected framework features may use that private method, it is not yet a public API and might be changed or removed in future versions of UI5. However, instead of maintaining the <code>selector</code> in the metadata, Element and Control classes can overwrite <code>getDomRefForSetting</code> and determine the DOM Element dynamically.</li> </ul> Property names should use camelCase notation, start with a lowercase letter and only use characters from the set [a-zA-Z0-9_$]. If an aggregation in the literal is preceded by a JSDoc comment (doclet) and if the UI5 plugin and template are used for JSDoc3 generation, the doclet will be used as generic documentation of the aggregation.
					/// 
					/// For each public property 'foo', the following methods will be created by the "extend" method and will be added to the prototype of the subclass: <ul> <li>getFoo() - returns the current value of property 'foo'. Internally calls {@link #getProperty}</li> <li>setFoo(v) - sets 'v' as the new value of property 'foo'. Internally calls {@link #setProperty}</li> <li>bindFoo(c) - (only if property was defined to be 'bindable'): convenience function that wraps {@link #bindProperty}</li> <li>unbindFoo() - (only if property was defined to be 'bindable'): convenience function that wraps {@link #unbindProperty}</li> </ul>
					/// 
					/// <b>'defaultProperty'</b> : <i>string</i><br> When specified, the default property must match the name of one of the properties defined for the new subclass (either own or inherited). The named property can be used to identify the main property to be used for bound data. E.g. the value property of a field control.
					/// 
					/// <b>'aggregations'</b> : <i>object</i><br> An object literal whose properties each define a new aggregation in the ManagedObject subclass. The value can either be a simple string which then will be assumed to be the type of the new aggregation or it can be an object literal with the following properties <ul> <li><code>type: <i>string</i></code> type of the new aggregation. must be the full global name of a ManagedObject subclass (in dot notation, e.g. 'sap.m.Button')</li> <li><code>[multiple]: <i>boolean</i></code> whether the aggregation is a 0..1 (false) or a 0..n aggregation (true), defaults to true </li> <li><code>[singularName]: <i>string</i></code>. Singular name for 0..n aggregations. For 0..n aggregations the name by convention should be the plural name. Methods affecting multiple objects in an aggregation will use the plural name (e.g. getItems(), whereas methods that deal with a single object will use the singular name (e.g. addItem). The framework knows a set of common rules for building plural form of English nouns and uses these rules to determine a singular name on its own. if that name is wrong, a singluarName can be specified with this property. </li> <li><code>[visibility]: <i>string</i></code> either 'hidden' or 'public', defaults to 'public'. Aggregations that belong to the API of a class must be 'public' whereas 'hidden' aggregations typically are used for the implementation of composite classes (e.g. composite controls) </li> <li><code>bindable: <i>boolean|string</i></code> (either can be omitted or set to the boolean value <code>true</code> or the magic string 'bindable') If set to <code>true</code> or 'bindable', additional named methods <code>bind<i>Name</i></code> and <code>unbind<i>Name</i></code> are generated as convenience. Despite its name, setting this flag is not mandatory to make the managed aggregation bindable. The generic methods {@link #bindAggregation} and {@link #unbindAggregation} can always be used. </li> <li><code>forwarding: <i>object</i></code> If set, this defines a forwarding of objects added to this aggregation into an aggregation of another ManagedObject - typically to an inner control within a composite control. This means that all adding, removal, or other operations happening on the source aggregation are actually called on the target instance. All elements added to the source aggregation will be located at the target aggregation (this means the target instance is their parent). Both, source and target element will return the added elements when asked for the content of the respective aggregation. If present, the named (non-generic) aggregation methods will be called for the target aggregation. Aggregations can only be forwarded to non-hidden aggregations of the same multiplicity (single/multiple). The target aggregation must also be "compatible" to the source aggregation in the sense that any items given to the source aggregation must also be valid in the target aggregation (otherwise the target element will throw a validation error). If the forwarded elements use data binding, the target element must be properly aggregated by the source element to make sure all models are available there as well. The aggregation target must remain the same instance across the entire lifetime of the source control. Aggregation forwarding will behave unexpectedly when the content in the target aggregation is modified by other actors (e.g. by the target element or by another forwarding from a different source aggregation). Hence, this is not allowed. The forwarding configuration object defines the target of the forwarding. The available settings are: <ul> <li><code>idSuffix: <i>string</i></code>A string which is appended to the ID of <i>this</i> ManagedObject to construct the ID of the target ManagedObject. This is one of the two options to specify the target. This option requires the target instance to be created in the init() method of this ManagedObject and to be always available.</li> <li><code>getter: <i>string</i></code>The name of the function on instances of this ManagedObject which returns the target instance. This second option to specify the target can be used for lazy instantiation of the target. Note that either idSuffix or getter must be given. Also note that the target instance returned by the getter must remain the same over the entire lifetime of this ManagedObject and the implementation assumes that all instances return the same type of object (at least the target aggregation must always be defined in the same class).</li> <li><code>aggregation: <i>string</i></code>The name of the aggregation on the target into which the objects shall be forwarded. The multiplicity of the target aggregation must be the same as the one of the source aggregation for which forwarding is defined.</li> <li><code>[forwardBinding]: <i>boolean</i></code>Whether any binding should happen on the forwarding target or not. Default if omitted is <code>false</code>, which means any bindings happen on the outer ManagedObject. When the binding is forwarded, all binding methods like updateAggregation, getBindingInfo, refreshAggregation etc. are called on the target element of the forwarding instead of being called on this element. The basic aggregation mutator methods (add/remove etc.) are only called on the forwarding target element. Without forwardBinding, they are called on this element, but forwarded to the forwarding target, where they actually modify the aggregation. </li> </ul> </li> <li><code>selector: <i>string</i></code> either can be omitted or set to a valid selector string as defined by the {@link https://developer.mozilla.org/en-US/docs/Web/API/Element/querySelector Element.prototype.querySelector} method. The selector should locate the DOM element that surrounds the aggregation's content. It should only be set for aggregations that have a visual representation in the DOM. A DOM element surrounding the aggregation's rendered content should be available in the DOM, even if the aggregation is empty or not rendered for some reason. In cases where this is not possible or not intended, <code>getDomRefForSetting</code> can be overridden, see below.
					/// 
					/// In addition to the CSS selector syntax, the selector string can contain the magic token <code>{id}</code> (multiple times). Before evaluating the selector in the context of an Element or Control, all occurrences of the token have to be replaced by the (potentially escaped) ID of that Element or Control. In fact, any selector should start with <code>#{id}</code> to ensure that the query result is limited to the desired Element or Control.
					/// 
					/// <b>Note</b>: there is a convenience method {@link sap.ui.core.Element#getDomRefForSetting} that evaluates the selector in the context of a concrete Element or Control instance. It also handles the placeholder <code>{id}</code>. Only selected framework features may use that private method, it is not yet a public API and might be changed or removed in future versions of UI5. However, instead of maintaining the <code>selector</code> in the metadata, Element and Control classes can overwrite <code>getDomRefForSetting</code> to calculate or add the appropriate DOM Element dynamically.</li> </li> </ul> Aggregation names should use camelCase notation, start with a lowercase letter and only use characters from the set [a-zA-Z0-9_$]. The name for a hidden aggregations might start with an underscore. If an aggregation in the literal is preceded by a JSDoc comment (doclet) and if the UI5 plugin and template are used for JSDoc3 generation, the doclet will be used as generic documentation of the aggregation.
					/// 
					/// For each public aggregation 'item' of cardinality 0..1, the following methods will be created by the "extend" method and will be added to the prototype of the subclass: <ul> <li>getItem() - returns the current value of aggregation 'item'. Internally calls {@link #getAggregation} with a default value of <code>undefined</code></li> <li>setItem(o) - sets 'o' as the new aggregated object in aggregation 'item'. Internally calls {@link #setAggregation}</li> <li>destroyItem(o) - destroy a currently aggregated object in aggregation 'item' and clears the aggregation. Internally calls {@link #destroyAggregation}</li> <li>bindItem(c) - (only if aggregation was defined to be 'bindable'): convenience function that wraps {@link #bindAggregation}</li> <li>unbindItem() - (only if aggregation was defined to be 'bindable'): convenience function that wraps {@link #unbindAggregation}</li> </ul> For a public aggregation 'items' of cardinality 0..n, the following methods will be created: <ul> <li>getItems() - returns an array with the objects contained in aggregation 'items'. Internally calls {@link #getAggregation} with a default value of <code>[]</code></li> <li>addItem(o) - adds an object as last element in the aggregation 'items'. Internally calls {@link #addAggregation}</li> <li>insertItem(o,p) - inserts an object into the aggregation 'items'. Internally calls {@link #insertAggregation}</li> <li>indexOfItem(o) - returns the position of the given object within the aggregation 'items'. Internally calls {@link #indexOfAggregation}</li> <li>removeItem(v) - removes an object from the aggregation 'items'. Internally calls {@link #removeAggregation}</li> <li>removeItems() - removes all objects from the aggregation 'items'. Internally calls {@link #removeAllAggregation}</li> <li>destroyItems() - destroy all currently aggregated objects in aggregation 'items' and clears the aggregation. Internally calls {@link #destroyAggregation}</li> <li>bindItems(c) - (only if aggregation was defined to be 'bindable'): convenience function that wraps {@link #bindAggregation}</li> <li>unbindItems() - (only if aggregation was defined to be 'bindable'): convenience function that wraps {@link #unbindAggregation}</li> </ul> For private or hidden aggregations, no methods are generated.
					/// 
					/// <b>'defaultAggregation'</b> : <i>string</i><br> When specified, the default aggregation must match the name of one of the aggregations defined for the new subclass (either own or inherited). The named aggregation will be used in contexts where no aggregation is specified. E,g. when an object in an XMLView embeds other objects without naming an aggregation, as in the following example: <pre>
					///  &lt;!-- assuming the defaultAggregation for Dialog is 'content' -->
					///  &lt;Dialog>
					///    &lt;Text/>
					///    &lt;Button/>
					///  &lt;/Dialog>
					/// </pre>
					/// 
					/// <b>'associations'</b> : <i>object</i><br> An object literal whose properties each define a new association of the ManagedObject subclass. The value can either be a simple string which then will be assumed to be the type of the new association or it can be an object literal with the following properties <ul> <li><code>type: <i>string</i></code> type of the new association</li> <li><code>multiple: <i>boolean</i></code> whether the association is a 0..1 (false) or a 0..n association (true), defaults to false(1) for associations</li> <li><code>[singularName]: <i>string</i></code>. Singular name for 0..n associations. For 0..n associations the name by convention should be the plural name. Methods affecting multiple objects in an association will use the plural name (e.g. getItems(), whereas methods that deal with a single object will use the singular name (e.g. addItem). The framework knows a set of common rules for building plural form of English nouns and uses these rules to determine a singular name on its own. if that name is wrong, a singluarName can be specified with this property.</li> </ul> Association names should use camelCase notation, start with a lowercase letter and only use characters from the set [a-zA-Z0-9_$]. If an association in the literal is preceded by a JSDoc comment (doclet) and if the UI5 plugin and template are used for JSDoc3 generation, the doclet will be used as generic documentation of the association.
					/// 
					/// For each association 'ref' of cardinality 0..1, the following methods will be created by the "extend" method and will be added to the prototype of the subclass: <ul> <li>getRef() - returns the current value of association 'item'. Internally calls {@link #getAssociation} with a default value of <code>undefined</code></li> <li>setRef(o) - sets 'o' as the new associated object in association 'item'. Internally calls {@link #setAssociation}</li> </ul> For a public association 'refs' of cardinality 0..n, the following methods will be created: <ul> <li>getRefs() - returns an array with the objects contained in association 'items'. Internally calls {@link #getAssociation} with a default value of <code>[]</code></li> <li>addRef(o) - adds an object as last element in the association 'items'. Internally calls {@link #addAssociation}</li> <li>removeRef(v) - removes an object from the association 'items'. Internally calls {@link #removeAssociation}</li> <li>removeAllRefs() - removes all objects from the association 'items'. Internally calls {@link #removeAllAssociation}</li> </ul>
					/// 
					/// <b>'events'</b> : <i>object</i><br> An object literal whose properties each define a new event of the ManagedObject subclass. The value can either be a simple string which then will be assumed to be the type of the new association or it can be an object literal with the following properties <ul> <li><code>allowPreventDefault: <i>boolean</i></code> whether the event allows to prevented the default behavior of the event source</li> <li><code>parameters: <i>object</i></code> an object literal that describes the parameters of this event. </li> </ul> Event names should use camelCase notation, start with a lowercase letter and only use characters from the set [a-zA-Z0-9_$]. If an event in the literal is preceded by a JSDoc comment (doclet) and if the UI5 plugin and template are used for JSDoc3 generation, the doclet will be used as generic documentation of the event.
					/// 
					/// For each event 'Some' the following methods will be created by the "extend" method and will be added to the prototype of the subclass: <ul> <li>attachSome(fn,o) - registers a listener for the event. Internally calls {@link #attachEvent}</li> <li>detachSome(fn,o) - deregisters a listener for the event. Internally calls {@link #detachEvent}</li> <li>fireSome() - fire the event. Internally calls {@link #fireEvent}</li> </ul>
					/// 
					/// <b>'specialSettings'</b> : <i>object</i><br> Special settings are an experimental feature and MUST NOT BE USED by controls or applications outside of the sap.ui.core project.
					/// </summary>
					/// <param name="sClassName">name of the class to be created</param>
					/// <param name="oClassInfo">object literal with information about the class</param>
					/// <param name="FNMetaImpl">constructor function for the metadata object. If not given, it defaults to <code>sap.ui.base.ManagedObjectMetadata</code>.</param>
					/// <returns>the created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Defines a new subclass of ManagedObject with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> can contain the same information that {@link sap.ui.base.Object.extend} already accepts, plus the following new properties in the 'metadata' object literal:
					/// 
					/// <ul> <li><code>library : <i>string</i></code></li> <li><code>properties : <i>object</i></code></li> <li><code>defaultProperty : <i>string</i></code></li> <li><code>aggregations : <i>object</i></code></li> <li><code>defaultAggregation : <i>string</i></code></li> <li><code>associations : <i>object</i></code></li> <li><code>events : <i>object</i></code></li> <li><code>specialSettings : <i>object</i></code>// this one is still experimental and not for public usage!</li> </ul>
					/// 
					/// Each of these properties is explained in more detail lateron.
					/// 
					/// Example: <pre>
					/// ManagedObect.extend('sap.mylib.MyClass', {
					///   metadata : {
					///     library: 'sap.mylib',
					///     properties : {
					///       value: 'string',
					///       width: 'sap.ui.core.CSSSize',
					///       height: { type: 'sap.ui.core.CSSSize', defaultValue: '100%'}
					///       description: { type: 'string', defaultValue: '', selector: '#{id}-desc'}
					///     },
					///     defaultProperty : 'value',
					///     aggregations : {
					///       header : { type: 'sap.mylib.FancyHeader', multiple : false }
					///       items : 'sap.ui.core.Control',
					///       buttons: { type: 'sap.mylib.Button', multiple : true, selector: '#{id} > .sapMLButtonsSection'}
					///     },
					///     defaultAggregation : 'items',
					///     associations : {
					///       initiallyFocused : { type: 'sap.ui.core.Control' }
					///     },
					///     events: {
					///       beforeOpen : {
					///         parameters : {
					///           opener : { type: 'sap.ui.core.Control' }
					///         }
					///       }
					///     },
					///   },
					/// 
					///   init: function() {
					///   }
					/// 
					/// }); // end of 'extend' call
					/// </pre>
					/// 
					/// Detailed explanation of properties<br>
					/// 
					/// <b>'library'</b> : <i>string</i><br> Name of the library that the new subclass should belong to. If the subclass is a control or element, it will automatically register with that library so that authoring tools can discover it. By convention, the name of the subclass should have the library name as a prefix, e.g. 'sap.ui.commons.Panel' belongs to library 'sap.ui.commons'.
					/// 
					/// <b>'properties'</b> : <i>object</i><br> An object literal whose properties each define a new managed property in the ManagedObject subclass. The value can either be a simple string which then will be assumed to be the type of the new property or it can be an object literal with the following properties <ul> <li><code>type: <i>string</i></code> type of the new property. Must either be one of the built-in types 'string', 'boolean', 'int', 'float', 'object' or 'any', or a type created and registered with {@link sap.ui.base.DataType.createType} or an array type based on one of the previous types.</li> <li><code>group:<i>string</i></code> a semantic grouping of the properties, intended to be used in design time tools. Allowed values are (case sensitive): Accessibility, Appearance, Behavior, Data, Designtime, Dimension, Identification, Misc</li> <li><code>defaultValue: <i>any</i></code> the default value for the property or null if there is no defaultValue.</li> <li><code>bindable: <i>boolean|string</i></code> (either can be omitted or set to the boolean value <code>true</code> or the magic string 'bindable') If set to <code>true</code> or 'bindable', additional named methods <code>bind<i>Name</i></code> and <code>unbind<i>Name</i></code> are generated as convenience. Despite its name, setting this flag is not mandatory to make the managed property bindable. The generic methods {@link #bindProperty} and {@link #unbindProperty} can always be used. </li> <li><code>selector: <i>string</i></code> either can be omitted or set to a valid selector string as defined by the {@link https://developer.mozilla.org/en-US/docs/Web/API/Element/querySelector Element.prototype.querySelector} method should locate the DOM element that rendered this property's value. It should only be set for properties that have a visual text representation in the DOM.
					/// 
					/// In addition to the CSS selector syntax, the selector string can contain the placeholder <code>{id}</code> (multiple times). Before evaluating the selector in the context of an Element or Control, all occurrences of the placeholder have to be replaced by the (potentially escaped) ID of that Element or Control. In fact, any selector should start with <code>#{id}</code> to ensure that the query result is limited to the desired Element or Control.
					/// 
					/// <b>Note</b>: there is a convenience method {@link sap.ui.core.Element#getDomRefForSetting} that evaluates the selector in the context of a concrete Element or Control instance. It also handles the placeholder <code>{id}</code>. Only selected framework features may use that private method, it is not yet a public API and might be changed or removed in future versions of UI5. However, instead of maintaining the <code>selector</code> in the metadata, Element and Control classes can overwrite <code>getDomRefForSetting</code> and determine the DOM Element dynamically.</li> </ul> Property names should use camelCase notation, start with a lowercase letter and only use characters from the set [a-zA-Z0-9_$]. If an aggregation in the literal is preceded by a JSDoc comment (doclet) and if the UI5 plugin and template are used for JSDoc3 generation, the doclet will be used as generic documentation of the aggregation.
					/// 
					/// For each public property 'foo', the following methods will be created by the "extend" method and will be added to the prototype of the subclass: <ul> <li>getFoo() - returns the current value of property 'foo'. Internally calls {@link #getProperty}</li> <li>setFoo(v) - sets 'v' as the new value of property 'foo'. Internally calls {@link #setProperty}</li> <li>bindFoo(c) - (only if property was defined to be 'bindable'): convenience function that wraps {@link #bindProperty}</li> <li>unbindFoo() - (only if property was defined to be 'bindable'): convenience function that wraps {@link #unbindProperty}</li> </ul>
					/// 
					/// <b>'defaultProperty'</b> : <i>string</i><br> When specified, the default property must match the name of one of the properties defined for the new subclass (either own or inherited). The named property can be used to identify the main property to be used for bound data. E.g. the value property of a field control.
					/// 
					/// <b>'aggregations'</b> : <i>object</i><br> An object literal whose properties each define a new aggregation in the ManagedObject subclass. The value can either be a simple string which then will be assumed to be the type of the new aggregation or it can be an object literal with the following properties <ul> <li><code>type: <i>string</i></code> type of the new aggregation. must be the full global name of a ManagedObject subclass (in dot notation, e.g. 'sap.m.Button')</li> <li><code>[multiple]: <i>boolean</i></code> whether the aggregation is a 0..1 (false) or a 0..n aggregation (true), defaults to true </li> <li><code>[singularName]: <i>string</i></code>. Singular name for 0..n aggregations. For 0..n aggregations the name by convention should be the plural name. Methods affecting multiple objects in an aggregation will use the plural name (e.g. getItems(), whereas methods that deal with a single object will use the singular name (e.g. addItem). The framework knows a set of common rules for building plural form of English nouns and uses these rules to determine a singular name on its own. if that name is wrong, a singluarName can be specified with this property. </li> <li><code>[visibility]: <i>string</i></code> either 'hidden' or 'public', defaults to 'public'. Aggregations that belong to the API of a class must be 'public' whereas 'hidden' aggregations typically are used for the implementation of composite classes (e.g. composite controls) </li> <li><code>bindable: <i>boolean|string</i></code> (either can be omitted or set to the boolean value <code>true</code> or the magic string 'bindable') If set to <code>true</code> or 'bindable', additional named methods <code>bind<i>Name</i></code> and <code>unbind<i>Name</i></code> are generated as convenience. Despite its name, setting this flag is not mandatory to make the managed aggregation bindable. The generic methods {@link #bindAggregation} and {@link #unbindAggregation} can always be used. </li> <li><code>forwarding: <i>object</i></code> If set, this defines a forwarding of objects added to this aggregation into an aggregation of another ManagedObject - typically to an inner control within a composite control. This means that all adding, removal, or other operations happening on the source aggregation are actually called on the target instance. All elements added to the source aggregation will be located at the target aggregation (this means the target instance is their parent). Both, source and target element will return the added elements when asked for the content of the respective aggregation. If present, the named (non-generic) aggregation methods will be called for the target aggregation. Aggregations can only be forwarded to non-hidden aggregations of the same multiplicity (single/multiple). The target aggregation must also be "compatible" to the source aggregation in the sense that any items given to the source aggregation must also be valid in the target aggregation (otherwise the target element will throw a validation error). If the forwarded elements use data binding, the target element must be properly aggregated by the source element to make sure all models are available there as well. The aggregation target must remain the same instance across the entire lifetime of the source control. Aggregation forwarding will behave unexpectedly when the content in the target aggregation is modified by other actors (e.g. by the target element or by another forwarding from a different source aggregation). Hence, this is not allowed. The forwarding configuration object defines the target of the forwarding. The available settings are: <ul> <li><code>idSuffix: <i>string</i></code>A string which is appended to the ID of <i>this</i> ManagedObject to construct the ID of the target ManagedObject. This is one of the two options to specify the target. This option requires the target instance to be created in the init() method of this ManagedObject and to be always available.</li> <li><code>getter: <i>string</i></code>The name of the function on instances of this ManagedObject which returns the target instance. This second option to specify the target can be used for lazy instantiation of the target. Note that either idSuffix or getter must be given. Also note that the target instance returned by the getter must remain the same over the entire lifetime of this ManagedObject and the implementation assumes that all instances return the same type of object (at least the target aggregation must always be defined in the same class).</li> <li><code>aggregation: <i>string</i></code>The name of the aggregation on the target into which the objects shall be forwarded. The multiplicity of the target aggregation must be the same as the one of the source aggregation for which forwarding is defined.</li> <li><code>[forwardBinding]: <i>boolean</i></code>Whether any binding should happen on the forwarding target or not. Default if omitted is <code>false</code>, which means any bindings happen on the outer ManagedObject. When the binding is forwarded, all binding methods like updateAggregation, getBindingInfo, refreshAggregation etc. are called on the target element of the forwarding instead of being called on this element. The basic aggregation mutator methods (add/remove etc.) are only called on the forwarding target element. Without forwardBinding, they are called on this element, but forwarded to the forwarding target, where they actually modify the aggregation. </li> </ul> </li> <li><code>selector: <i>string</i></code> either can be omitted or set to a valid selector string as defined by the {@link https://developer.mozilla.org/en-US/docs/Web/API/Element/querySelector Element.prototype.querySelector} method. The selector should locate the DOM element that surrounds the aggregation's content. It should only be set for aggregations that have a visual representation in the DOM. A DOM element surrounding the aggregation's rendered content should be available in the DOM, even if the aggregation is empty or not rendered for some reason. In cases where this is not possible or not intended, <code>getDomRefForSetting</code> can be overridden, see below.
					/// 
					/// In addition to the CSS selector syntax, the selector string can contain the magic token <code>{id}</code> (multiple times). Before evaluating the selector in the context of an Element or Control, all occurrences of the token have to be replaced by the (potentially escaped) ID of that Element or Control. In fact, any selector should start with <code>#{id}</code> to ensure that the query result is limited to the desired Element or Control.
					/// 
					/// <b>Note</b>: there is a convenience method {@link sap.ui.core.Element#getDomRefForSetting} that evaluates the selector in the context of a concrete Element or Control instance. It also handles the placeholder <code>{id}</code>. Only selected framework features may use that private method, it is not yet a public API and might be changed or removed in future versions of UI5. However, instead of maintaining the <code>selector</code> in the metadata, Element and Control classes can overwrite <code>getDomRefForSetting</code> to calculate or add the appropriate DOM Element dynamically.</li> </li> </ul> Aggregation names should use camelCase notation, start with a lowercase letter and only use characters from the set [a-zA-Z0-9_$]. The name for a hidden aggregations might start with an underscore. If an aggregation in the literal is preceded by a JSDoc comment (doclet) and if the UI5 plugin and template are used for JSDoc3 generation, the doclet will be used as generic documentation of the aggregation.
					/// 
					/// For each public aggregation 'item' of cardinality 0..1, the following methods will be created by the "extend" method and will be added to the prototype of the subclass: <ul> <li>getItem() - returns the current value of aggregation 'item'. Internally calls {@link #getAggregation} with a default value of <code>undefined</code></li> <li>setItem(o) - sets 'o' as the new aggregated object in aggregation 'item'. Internally calls {@link #setAggregation}</li> <li>destroyItem(o) - destroy a currently aggregated object in aggregation 'item' and clears the aggregation. Internally calls {@link #destroyAggregation}</li> <li>bindItem(c) - (only if aggregation was defined to be 'bindable'): convenience function that wraps {@link #bindAggregation}</li> <li>unbindItem() - (only if aggregation was defined to be 'bindable'): convenience function that wraps {@link #unbindAggregation}</li> </ul> For a public aggregation 'items' of cardinality 0..n, the following methods will be created: <ul> <li>getItems() - returns an array with the objects contained in aggregation 'items'. Internally calls {@link #getAggregation} with a default value of <code>[]</code></li> <li>addItem(o) - adds an object as last element in the aggregation 'items'. Internally calls {@link #addAggregation}</li> <li>insertItem(o,p) - inserts an object into the aggregation 'items'. Internally calls {@link #insertAggregation}</li> <li>indexOfItem(o) - returns the position of the given object within the aggregation 'items'. Internally calls {@link #indexOfAggregation}</li> <li>removeItem(v) - removes an object from the aggregation 'items'. Internally calls {@link #removeAggregation}</li> <li>removeItems() - removes all objects from the aggregation 'items'. Internally calls {@link #removeAllAggregation}</li> <li>destroyItems() - destroy all currently aggregated objects in aggregation 'items' and clears the aggregation. Internally calls {@link #destroyAggregation}</li> <li>bindItems(c) - (only if aggregation was defined to be 'bindable'): convenience function that wraps {@link #bindAggregation}</li> <li>unbindItems() - (only if aggregation was defined to be 'bindable'): convenience function that wraps {@link #unbindAggregation}</li> </ul> For private or hidden aggregations, no methods are generated.
					/// 
					/// <b>'defaultAggregation'</b> : <i>string</i><br> When specified, the default aggregation must match the name of one of the aggregations defined for the new subclass (either own or inherited). The named aggregation will be used in contexts where no aggregation is specified. E,g. when an object in an XMLView embeds other objects without naming an aggregation, as in the following example: <pre>
					///  &lt;!-- assuming the defaultAggregation for Dialog is 'content' -->
					///  &lt;Dialog>
					///    &lt;Text/>
					///    &lt;Button/>
					///  &lt;/Dialog>
					/// </pre>
					/// 
					/// <b>'associations'</b> : <i>object</i><br> An object literal whose properties each define a new association of the ManagedObject subclass. The value can either be a simple string which then will be assumed to be the type of the new association or it can be an object literal with the following properties <ul> <li><code>type: <i>string</i></code> type of the new association</li> <li><code>multiple: <i>boolean</i></code> whether the association is a 0..1 (false) or a 0..n association (true), defaults to false(1) for associations</li> <li><code>[singularName]: <i>string</i></code>. Singular name for 0..n associations. For 0..n associations the name by convention should be the plural name. Methods affecting multiple objects in an association will use the plural name (e.g. getItems(), whereas methods that deal with a single object will use the singular name (e.g. addItem). The framework knows a set of common rules for building plural form of English nouns and uses these rules to determine a singular name on its own. if that name is wrong, a singluarName can be specified with this property.</li> </ul> Association names should use camelCase notation, start with a lowercase letter and only use characters from the set [a-zA-Z0-9_$]. If an association in the literal is preceded by a JSDoc comment (doclet) and if the UI5 plugin and template are used for JSDoc3 generation, the doclet will be used as generic documentation of the association.
					/// 
					/// For each association 'ref' of cardinality 0..1, the following methods will be created by the "extend" method and will be added to the prototype of the subclass: <ul> <li>getRef() - returns the current value of association 'item'. Internally calls {@link #getAssociation} with a default value of <code>undefined</code></li> <li>setRef(o) - sets 'o' as the new associated object in association 'item'. Internally calls {@link #setAssociation}</li> </ul> For a public association 'refs' of cardinality 0..n, the following methods will be created: <ul> <li>getRefs() - returns an array with the objects contained in association 'items'. Internally calls {@link #getAssociation} with a default value of <code>[]</code></li> <li>addRef(o) - adds an object as last element in the association 'items'. Internally calls {@link #addAssociation}</li> <li>removeRef(v) - removes an object from the association 'items'. Internally calls {@link #removeAssociation}</li> <li>removeAllRefs() - removes all objects from the association 'items'. Internally calls {@link #removeAllAssociation}</li> </ul>
					/// 
					/// <b>'events'</b> : <i>object</i><br> An object literal whose properties each define a new event of the ManagedObject subclass. The value can either be a simple string which then will be assumed to be the type of the new association or it can be an object literal with the following properties <ul> <li><code>allowPreventDefault: <i>boolean</i></code> whether the event allows to prevented the default behavior of the event source</li> <li><code>parameters: <i>object</i></code> an object literal that describes the parameters of this event. </li> </ul> Event names should use camelCase notation, start with a lowercase letter and only use characters from the set [a-zA-Z0-9_$]. If an event in the literal is preceded by a JSDoc comment (doclet) and if the UI5 plugin and template are used for JSDoc3 generation, the doclet will be used as generic documentation of the event.
					/// 
					/// For each event 'Some' the following methods will be created by the "extend" method and will be added to the prototype of the subclass: <ul> <li>attachSome(fn,o) - registers a listener for the event. Internally calls {@link #attachEvent}</li> <li>detachSome(fn,o) - deregisters a listener for the event. Internally calls {@link #detachEvent}</li> <li>fireSome() - fire the event. Internally calls {@link #fireEvent}</li> </ul>
					/// 
					/// <b>'specialSettings'</b> : <i>object</i><br> Special settings are an experimental feature and MUST NOT BE USED by controls or applications outside of the sap.ui.core project.
					/// </summary>
					/// <param name="sClassName">name of the class to be created</param>
					/// <param name="oClassInfo">object literal with information about the class</param>
					/// <returns>the created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Defines a new subclass of ManagedObject with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> can contain the same information that {@link sap.ui.base.Object.extend} already accepts, plus the following new properties in the 'metadata' object literal:
					/// 
					/// <ul> <li><code>library : <i>string</i></code></li> <li><code>properties : <i>object</i></code></li> <li><code>defaultProperty : <i>string</i></code></li> <li><code>aggregations : <i>object</i></code></li> <li><code>defaultAggregation : <i>string</i></code></li> <li><code>associations : <i>object</i></code></li> <li><code>events : <i>object</i></code></li> <li><code>specialSettings : <i>object</i></code>// this one is still experimental and not for public usage!</li> </ul>
					/// 
					/// Each of these properties is explained in more detail lateron.
					/// 
					/// Example: <pre>
					/// ManagedObect.extend('sap.mylib.MyClass', {
					///   metadata : {
					///     library: 'sap.mylib',
					///     properties : {
					///       value: 'string',
					///       width: 'sap.ui.core.CSSSize',
					///       height: { type: 'sap.ui.core.CSSSize', defaultValue: '100%'}
					///       description: { type: 'string', defaultValue: '', selector: '#{id}-desc'}
					///     },
					///     defaultProperty : 'value',
					///     aggregations : {
					///       header : { type: 'sap.mylib.FancyHeader', multiple : false }
					///       items : 'sap.ui.core.Control',
					///       buttons: { type: 'sap.mylib.Button', multiple : true, selector: '#{id} > .sapMLButtonsSection'}
					///     },
					///     defaultAggregation : 'items',
					///     associations : {
					///       initiallyFocused : { type: 'sap.ui.core.Control' }
					///     },
					///     events: {
					///       beforeOpen : {
					///         parameters : {
					///           opener : { type: 'sap.ui.core.Control' }
					///         }
					///       }
					///     },
					///   },
					/// 
					///   init: function() {
					///   }
					/// 
					/// }); // end of 'extend' call
					/// </pre>
					/// 
					/// Detailed explanation of properties<br>
					/// 
					/// <b>'library'</b> : <i>string</i><br> Name of the library that the new subclass should belong to. If the subclass is a control or element, it will automatically register with that library so that authoring tools can discover it. By convention, the name of the subclass should have the library name as a prefix, e.g. 'sap.ui.commons.Panel' belongs to library 'sap.ui.commons'.
					/// 
					/// <b>'properties'</b> : <i>object</i><br> An object literal whose properties each define a new managed property in the ManagedObject subclass. The value can either be a simple string which then will be assumed to be the type of the new property or it can be an object literal with the following properties <ul> <li><code>type: <i>string</i></code> type of the new property. Must either be one of the built-in types 'string', 'boolean', 'int', 'float', 'object' or 'any', or a type created and registered with {@link sap.ui.base.DataType.createType} or an array type based on one of the previous types.</li> <li><code>group:<i>string</i></code> a semantic grouping of the properties, intended to be used in design time tools. Allowed values are (case sensitive): Accessibility, Appearance, Behavior, Data, Designtime, Dimension, Identification, Misc</li> <li><code>defaultValue: <i>any</i></code> the default value for the property or null if there is no defaultValue.</li> <li><code>bindable: <i>boolean|string</i></code> (either can be omitted or set to the boolean value <code>true</code> or the magic string 'bindable') If set to <code>true</code> or 'bindable', additional named methods <code>bind<i>Name</i></code> and <code>unbind<i>Name</i></code> are generated as convenience. Despite its name, setting this flag is not mandatory to make the managed property bindable. The generic methods {@link #bindProperty} and {@link #unbindProperty} can always be used. </li> <li><code>selector: <i>string</i></code> either can be omitted or set to a valid selector string as defined by the {@link https://developer.mozilla.org/en-US/docs/Web/API/Element/querySelector Element.prototype.querySelector} method should locate the DOM element that rendered this property's value. It should only be set for properties that have a visual text representation in the DOM.
					/// 
					/// In addition to the CSS selector syntax, the selector string can contain the placeholder <code>{id}</code> (multiple times). Before evaluating the selector in the context of an Element or Control, all occurrences of the placeholder have to be replaced by the (potentially escaped) ID of that Element or Control. In fact, any selector should start with <code>#{id}</code> to ensure that the query result is limited to the desired Element or Control.
					/// 
					/// <b>Note</b>: there is a convenience method {@link sap.ui.core.Element#getDomRefForSetting} that evaluates the selector in the context of a concrete Element or Control instance. It also handles the placeholder <code>{id}</code>. Only selected framework features may use that private method, it is not yet a public API and might be changed or removed in future versions of UI5. However, instead of maintaining the <code>selector</code> in the metadata, Element and Control classes can overwrite <code>getDomRefForSetting</code> and determine the DOM Element dynamically.</li> </ul> Property names should use camelCase notation, start with a lowercase letter and only use characters from the set [a-zA-Z0-9_$]. If an aggregation in the literal is preceded by a JSDoc comment (doclet) and if the UI5 plugin and template are used for JSDoc3 generation, the doclet will be used as generic documentation of the aggregation.
					/// 
					/// For each public property 'foo', the following methods will be created by the "extend" method and will be added to the prototype of the subclass: <ul> <li>getFoo() - returns the current value of property 'foo'. Internally calls {@link #getProperty}</li> <li>setFoo(v) - sets 'v' as the new value of property 'foo'. Internally calls {@link #setProperty}</li> <li>bindFoo(c) - (only if property was defined to be 'bindable'): convenience function that wraps {@link #bindProperty}</li> <li>unbindFoo() - (only if property was defined to be 'bindable'): convenience function that wraps {@link #unbindProperty}</li> </ul>
					/// 
					/// <b>'defaultProperty'</b> : <i>string</i><br> When specified, the default property must match the name of one of the properties defined for the new subclass (either own or inherited). The named property can be used to identify the main property to be used for bound data. E.g. the value property of a field control.
					/// 
					/// <b>'aggregations'</b> : <i>object</i><br> An object literal whose properties each define a new aggregation in the ManagedObject subclass. The value can either be a simple string which then will be assumed to be the type of the new aggregation or it can be an object literal with the following properties <ul> <li><code>type: <i>string</i></code> type of the new aggregation. must be the full global name of a ManagedObject subclass (in dot notation, e.g. 'sap.m.Button')</li> <li><code>[multiple]: <i>boolean</i></code> whether the aggregation is a 0..1 (false) or a 0..n aggregation (true), defaults to true </li> <li><code>[singularName]: <i>string</i></code>. Singular name for 0..n aggregations. For 0..n aggregations the name by convention should be the plural name. Methods affecting multiple objects in an aggregation will use the plural name (e.g. getItems(), whereas methods that deal with a single object will use the singular name (e.g. addItem). The framework knows a set of common rules for building plural form of English nouns and uses these rules to determine a singular name on its own. if that name is wrong, a singluarName can be specified with this property. </li> <li><code>[visibility]: <i>string</i></code> either 'hidden' or 'public', defaults to 'public'. Aggregations that belong to the API of a class must be 'public' whereas 'hidden' aggregations typically are used for the implementation of composite classes (e.g. composite controls) </li> <li><code>bindable: <i>boolean|string</i></code> (either can be omitted or set to the boolean value <code>true</code> or the magic string 'bindable') If set to <code>true</code> or 'bindable', additional named methods <code>bind<i>Name</i></code> and <code>unbind<i>Name</i></code> are generated as convenience. Despite its name, setting this flag is not mandatory to make the managed aggregation bindable. The generic methods {@link #bindAggregation} and {@link #unbindAggregation} can always be used. </li> <li><code>forwarding: <i>object</i></code> If set, this defines a forwarding of objects added to this aggregation into an aggregation of another ManagedObject - typically to an inner control within a composite control. This means that all adding, removal, or other operations happening on the source aggregation are actually called on the target instance. All elements added to the source aggregation will be located at the target aggregation (this means the target instance is their parent). Both, source and target element will return the added elements when asked for the content of the respective aggregation. If present, the named (non-generic) aggregation methods will be called for the target aggregation. Aggregations can only be forwarded to non-hidden aggregations of the same multiplicity (single/multiple). The target aggregation must also be "compatible" to the source aggregation in the sense that any items given to the source aggregation must also be valid in the target aggregation (otherwise the target element will throw a validation error). If the forwarded elements use data binding, the target element must be properly aggregated by the source element to make sure all models are available there as well. The aggregation target must remain the same instance across the entire lifetime of the source control. Aggregation forwarding will behave unexpectedly when the content in the target aggregation is modified by other actors (e.g. by the target element or by another forwarding from a different source aggregation). Hence, this is not allowed. The forwarding configuration object defines the target of the forwarding. The available settings are: <ul> <li><code>idSuffix: <i>string</i></code>A string which is appended to the ID of <i>this</i> ManagedObject to construct the ID of the target ManagedObject. This is one of the two options to specify the target. This option requires the target instance to be created in the init() method of this ManagedObject and to be always available.</li> <li><code>getter: <i>string</i></code>The name of the function on instances of this ManagedObject which returns the target instance. This second option to specify the target can be used for lazy instantiation of the target. Note that either idSuffix or getter must be given. Also note that the target instance returned by the getter must remain the same over the entire lifetime of this ManagedObject and the implementation assumes that all instances return the same type of object (at least the target aggregation must always be defined in the same class).</li> <li><code>aggregation: <i>string</i></code>The name of the aggregation on the target into which the objects shall be forwarded. The multiplicity of the target aggregation must be the same as the one of the source aggregation for which forwarding is defined.</li> <li><code>[forwardBinding]: <i>boolean</i></code>Whether any binding should happen on the forwarding target or not. Default if omitted is <code>false</code>, which means any bindings happen on the outer ManagedObject. When the binding is forwarded, all binding methods like updateAggregation, getBindingInfo, refreshAggregation etc. are called on the target element of the forwarding instead of being called on this element. The basic aggregation mutator methods (add/remove etc.) are only called on the forwarding target element. Without forwardBinding, they are called on this element, but forwarded to the forwarding target, where they actually modify the aggregation. </li> </ul> </li> <li><code>selector: <i>string</i></code> either can be omitted or set to a valid selector string as defined by the {@link https://developer.mozilla.org/en-US/docs/Web/API/Element/querySelector Element.prototype.querySelector} method. The selector should locate the DOM element that surrounds the aggregation's content. It should only be set for aggregations that have a visual representation in the DOM. A DOM element surrounding the aggregation's rendered content should be available in the DOM, even if the aggregation is empty or not rendered for some reason. In cases where this is not possible or not intended, <code>getDomRefForSetting</code> can be overridden, see below.
					/// 
					/// In addition to the CSS selector syntax, the selector string can contain the magic token <code>{id}</code> (multiple times). Before evaluating the selector in the context of an Element or Control, all occurrences of the token have to be replaced by the (potentially escaped) ID of that Element or Control. In fact, any selector should start with <code>#{id}</code> to ensure that the query result is limited to the desired Element or Control.
					/// 
					/// <b>Note</b>: there is a convenience method {@link sap.ui.core.Element#getDomRefForSetting} that evaluates the selector in the context of a concrete Element or Control instance. It also handles the placeholder <code>{id}</code>. Only selected framework features may use that private method, it is not yet a public API and might be changed or removed in future versions of UI5. However, instead of maintaining the <code>selector</code> in the metadata, Element and Control classes can overwrite <code>getDomRefForSetting</code> to calculate or add the appropriate DOM Element dynamically.</li> </li> </ul> Aggregation names should use camelCase notation, start with a lowercase letter and only use characters from the set [a-zA-Z0-9_$]. The name for a hidden aggregations might start with an underscore. If an aggregation in the literal is preceded by a JSDoc comment (doclet) and if the UI5 plugin and template are used for JSDoc3 generation, the doclet will be used as generic documentation of the aggregation.
					/// 
					/// For each public aggregation 'item' of cardinality 0..1, the following methods will be created by the "extend" method and will be added to the prototype of the subclass: <ul> <li>getItem() - returns the current value of aggregation 'item'. Internally calls {@link #getAggregation} with a default value of <code>undefined</code></li> <li>setItem(o) - sets 'o' as the new aggregated object in aggregation 'item'. Internally calls {@link #setAggregation}</li> <li>destroyItem(o) - destroy a currently aggregated object in aggregation 'item' and clears the aggregation. Internally calls {@link #destroyAggregation}</li> <li>bindItem(c) - (only if aggregation was defined to be 'bindable'): convenience function that wraps {@link #bindAggregation}</li> <li>unbindItem() - (only if aggregation was defined to be 'bindable'): convenience function that wraps {@link #unbindAggregation}</li> </ul> For a public aggregation 'items' of cardinality 0..n, the following methods will be created: <ul> <li>getItems() - returns an array with the objects contained in aggregation 'items'. Internally calls {@link #getAggregation} with a default value of <code>[]</code></li> <li>addItem(o) - adds an object as last element in the aggregation 'items'. Internally calls {@link #addAggregation}</li> <li>insertItem(o,p) - inserts an object into the aggregation 'items'. Internally calls {@link #insertAggregation}</li> <li>indexOfItem(o) - returns the position of the given object within the aggregation 'items'. Internally calls {@link #indexOfAggregation}</li> <li>removeItem(v) - removes an object from the aggregation 'items'. Internally calls {@link #removeAggregation}</li> <li>removeItems() - removes all objects from the aggregation 'items'. Internally calls {@link #removeAllAggregation}</li> <li>destroyItems() - destroy all currently aggregated objects in aggregation 'items' and clears the aggregation. Internally calls {@link #destroyAggregation}</li> <li>bindItems(c) - (only if aggregation was defined to be 'bindable'): convenience function that wraps {@link #bindAggregation}</li> <li>unbindItems() - (only if aggregation was defined to be 'bindable'): convenience function that wraps {@link #unbindAggregation}</li> </ul> For private or hidden aggregations, no methods are generated.
					/// 
					/// <b>'defaultAggregation'</b> : <i>string</i><br> When specified, the default aggregation must match the name of one of the aggregations defined for the new subclass (either own or inherited). The named aggregation will be used in contexts where no aggregation is specified. E,g. when an object in an XMLView embeds other objects without naming an aggregation, as in the following example: <pre>
					///  &lt;!-- assuming the defaultAggregation for Dialog is 'content' -->
					///  &lt;Dialog>
					///    &lt;Text/>
					///    &lt;Button/>
					///  &lt;/Dialog>
					/// </pre>
					/// 
					/// <b>'associations'</b> : <i>object</i><br> An object literal whose properties each define a new association of the ManagedObject subclass. The value can either be a simple string which then will be assumed to be the type of the new association or it can be an object literal with the following properties <ul> <li><code>type: <i>string</i></code> type of the new association</li> <li><code>multiple: <i>boolean</i></code> whether the association is a 0..1 (false) or a 0..n association (true), defaults to false(1) for associations</li> <li><code>[singularName]: <i>string</i></code>. Singular name for 0..n associations. For 0..n associations the name by convention should be the plural name. Methods affecting multiple objects in an association will use the plural name (e.g. getItems(), whereas methods that deal with a single object will use the singular name (e.g. addItem). The framework knows a set of common rules for building plural form of English nouns and uses these rules to determine a singular name on its own. if that name is wrong, a singluarName can be specified with this property.</li> </ul> Association names should use camelCase notation, start with a lowercase letter and only use characters from the set [a-zA-Z0-9_$]. If an association in the literal is preceded by a JSDoc comment (doclet) and if the UI5 plugin and template are used for JSDoc3 generation, the doclet will be used as generic documentation of the association.
					/// 
					/// For each association 'ref' of cardinality 0..1, the following methods will be created by the "extend" method and will be added to the prototype of the subclass: <ul> <li>getRef() - returns the current value of association 'item'. Internally calls {@link #getAssociation} with a default value of <code>undefined</code></li> <li>setRef(o) - sets 'o' as the new associated object in association 'item'. Internally calls {@link #setAssociation}</li> </ul> For a public association 'refs' of cardinality 0..n, the following methods will be created: <ul> <li>getRefs() - returns an array with the objects contained in association 'items'. Internally calls {@link #getAssociation} with a default value of <code>[]</code></li> <li>addRef(o) - adds an object as last element in the association 'items'. Internally calls {@link #addAssociation}</li> <li>removeRef(v) - removes an object from the association 'items'. Internally calls {@link #removeAssociation}</li> <li>removeAllRefs() - removes all objects from the association 'items'. Internally calls {@link #removeAllAssociation}</li> </ul>
					/// 
					/// <b>'events'</b> : <i>object</i><br> An object literal whose properties each define a new event of the ManagedObject subclass. The value can either be a simple string which then will be assumed to be the type of the new association or it can be an object literal with the following properties <ul> <li><code>allowPreventDefault: <i>boolean</i></code> whether the event allows to prevented the default behavior of the event source</li> <li><code>parameters: <i>object</i></code> an object literal that describes the parameters of this event. </li> </ul> Event names should use camelCase notation, start with a lowercase letter and only use characters from the set [a-zA-Z0-9_$]. If an event in the literal is preceded by a JSDoc comment (doclet) and if the UI5 plugin and template are used for JSDoc3 generation, the doclet will be used as generic documentation of the event.
					/// 
					/// For each event 'Some' the following methods will be created by the "extend" method and will be added to the prototype of the subclass: <ul> <li>attachSome(fn,o) - registers a listener for the event. Internally calls {@link #attachEvent}</li> <li>detachSome(fn,o) - deregisters a listener for the event. Internally calls {@link #detachEvent}</li> <li>fireSome() - fire the event. Internally calls {@link #fireEvent}</li> </ul>
					/// 
					/// <b>'specialSettings'</b> : <i>object</i><br> Special settings are an experimental feature and MUST NOT BE USED by controls or applications outside of the sap.ui.core project.
					/// </summary>
					/// <param name="sClassName">name of the class to be created</param>
					/// <returns>the created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Searches and returns all aggregated objects that pass the given check function.
					/// 
					/// When the search is done recursively (<code>bRecursive === true</code>), it will be executed depth-first and ancestors will be added to the result array before their descendants.
					/// 
					/// If no check function is given, all aggregated objects will pass the check and be added to the result array.
					/// 
					/// <b>Take care: this operation might be expensive.</b>
					/// </summary>
					/// <param name="bRecursive">Whether the whole aggregation tree should be searched</param>
					/// <param name="fnCondition">Objects for which this function returns a falsy value will not be added to the result array</param>
					/// <returns>Array of aggregated objects that passed the check</returns>
					public extern virtual sap.ui.@base.ManagedObject[] findAggregatedObjects(bool bRecursive, bool fnCondition);

					/// <summary>
					/// Searches and returns all aggregated objects that pass the given check function.
					/// 
					/// When the search is done recursively (<code>bRecursive === true</code>), it will be executed depth-first and ancestors will be added to the result array before their descendants.
					/// 
					/// If no check function is given, all aggregated objects will pass the check and be added to the result array.
					/// 
					/// <b>Take care: this operation might be expensive.</b>
					/// </summary>
					/// <param name="bRecursive">Whether the whole aggregation tree should be searched</param>
					/// <returns>Array of aggregated objects that passed the check</returns>
					public extern virtual sap.ui.@base.ManagedObject[] findAggregatedObjects(bool bRecursive);

					/// <summary>
					/// Returns the aggregated object(s) for the named aggregation of this ManagedObject.
					/// 
					/// If the aggregation does not contain any objects(s), the given <code>oDefaultForCreation</code> (or <code>null</code>) is set as new value of the aggregation and returned to the caller.
					/// 
					/// <b>Note:</b> the need to specify a default value and the fact that it is stored as new value of a so far empty aggregation is recognized as a shortcoming of this API but can no longer be changed for compatibility reasons.
					/// 
					/// <b>Note:</b> This method is a low-level API as described in <a href="#lowlevelapi">the class documentation</a>. Applications or frameworks must not use this method to generically read the content of an aggregation. Use the concrete method get<i>XYZ</i> for aggregation 'XYZ' instead.
					/// </summary>
					/// <param name="sAggregationName">the name of the aggregation</param>
					/// <param name="oDefaultForCreation">the object that is used in case the current aggregation is empty</param>
					/// <returns>the aggregation array in case of 0..n-aggregations or the managed object or null in case of 0..1-aggregations</returns>
					public extern virtual Union<sap.ui.@base.ManagedObject, object[]> getAggregation(string sAggregationName, Union<sap.ui.@base.ManagedObject, object[]> oDefaultForCreation);

					/// <summary>
					/// Returns the aggregated object(s) for the named aggregation of this ManagedObject.
					/// 
					/// If the aggregation does not contain any objects(s), the given <code>oDefaultForCreation</code> (or <code>null</code>) is set as new value of the aggregation and returned to the caller.
					/// 
					/// <b>Note:</b> the need to specify a default value and the fact that it is stored as new value of a so far empty aggregation is recognized as a shortcoming of this API but can no longer be changed for compatibility reasons.
					/// 
					/// <b>Note:</b> This method is a low-level API as described in <a href="#lowlevelapi">the class documentation</a>. Applications or frameworks must not use this method to generically read the content of an aggregation. Use the concrete method get<i>XYZ</i> for aggregation 'XYZ' instead.
					/// </summary>
					/// <param name="sAggregationName">the name of the aggregation</param>
					/// <returns>the aggregation array in case of 0..n-aggregations or the managed object or null in case of 0..1-aggregations</returns>
					public extern virtual Union<sap.ui.@base.ManagedObject, object[]> getAggregation(string sAggregationName);

					/// <summary>
					/// Returns the content of the association with the given name.
					/// 
					/// For associations of cardinality 0..1, a single string with the ID of an associated object is returned (if any). For cardinality 0..n, an array with the IDs of the associated objects is returned.
					/// 
					/// If the association does not contain any objects(s), the given <code>oDefaultForCreation</code> is set as new value of the association and returned to the caller. The only supported values for <code>oDefaultForCreation</code> are <code>null</code> and <code>undefined</code> in the case of cardinality 0..1 and <code>null</code>, <code>undefined</code> or an empty array (<code>[]</code>) in case of cardinality 0..n. If the argument is omitted, <code>null</code> is used independently from the cardinality.
					/// 
					/// <b>Note:</b> the need to specify a default value and the fact that it is stored as new value of a so far empty association is recognized as a shortcoming of this API but can no longer be changed for compatibility reasons.
					/// 
					/// <b>Note:</b> This method is a low-level API as described in <a href="#lowlevelapi">the class documentation</a>. Applications or frameworks must not use this method to generically retrieve the content of an association. Use the concrete method get<i>XYZ</i> for association 'XYZ' instead.
					/// </summary>
					/// <param name="sAssociationName">the name of the association</param>
					/// <param name="oDefaultForCreation">the object that is used in case the current aggregation is empty (only null or empty array allowed)</param>
					/// <returns>the ID of the associated managed object or an array of such IDs; may be null if the association has not been populated</returns>
					public extern virtual Union<string, string[]> getAssociation(string sAssociationName, object oDefaultForCreation);

					/// <summary>
					/// Returns the content of the association with the given name.
					/// 
					/// For associations of cardinality 0..1, a single string with the ID of an associated object is returned (if any). For cardinality 0..n, an array with the IDs of the associated objects is returned.
					/// 
					/// If the association does not contain any objects(s), the given <code>oDefaultForCreation</code> is set as new value of the association and returned to the caller. The only supported values for <code>oDefaultForCreation</code> are <code>null</code> and <code>undefined</code> in the case of cardinality 0..1 and <code>null</code>, <code>undefined</code> or an empty array (<code>[]</code>) in case of cardinality 0..n. If the argument is omitted, <code>null</code> is used independently from the cardinality.
					/// 
					/// <b>Note:</b> the need to specify a default value and the fact that it is stored as new value of a so far empty association is recognized as a shortcoming of this API but can no longer be changed for compatibility reasons.
					/// 
					/// <b>Note:</b> This method is a low-level API as described in <a href="#lowlevelapi">the class documentation</a>. Applications or frameworks must not use this method to generically retrieve the content of an association. Use the concrete method get<i>XYZ</i> for association 'XYZ' instead.
					/// </summary>
					/// <param name="sAssociationName">the name of the association</param>
					/// <returns>the ID of the associated managed object or an array of such IDs; may be null if the association has not been populated</returns>
					public extern virtual Union<string, string[]> getAssociation(string sAssociationName);

					/// <summary>
					/// Get the binding object for a specific aggregation/property
					/// </summary>
					/// <param name="sName">the name of the property or aggregation</param>
					/// <returns>the binding for the given name</returns>
					public extern virtual sap.ui.model.Binding getBinding(string sName);

					/// <summary>
					/// Get the binding context of this object for the given model name.
					/// 
					/// If the object does not have a binding context set on itself and has no own model set, it will use the first binding context defined in its parent hierarchy.
					/// 
					/// <b>Note:</b> to be compatible with future versions of this API, you must not use the following model names: <ul> <li><code>null</code></li> <li>empty string <code>""</code></li> <li>string literals <code>"null"</code> or <code>"undefined"</code></li> </ul> Omitting the model name (or using the value <code>undefined</code>) is explicitly allowed and refers to the default model.
					/// 
					/// <b>Note:</b> A ManagedObject inherits binding contexts from the Core only when it is a descendant of a UIArea.
					/// </summary>
					/// <param name="sModelName">the name of the model or <code>undefined</code></param>
					/// <returns>The binding context of this object</returns>
					public extern virtual sap.ui.model.Context getBindingContext(string sModelName);

					/// <summary>
					/// Get the binding context of this object for the given model name.
					/// 
					/// If the object does not have a binding context set on itself and has no own model set, it will use the first binding context defined in its parent hierarchy.
					/// 
					/// <b>Note:</b> to be compatible with future versions of this API, you must not use the following model names: <ul> <li><code>null</code></li> <li>empty string <code>""</code></li> <li>string literals <code>"null"</code> or <code>"undefined"</code></li> </ul> Omitting the model name (or using the value <code>undefined</code>) is explicitly allowed and refers to the default model.
					/// 
					/// <b>Note:</b> A ManagedObject inherits binding contexts from the Core only when it is a descendant of a UIArea.
					/// </summary>
					/// <returns>The binding context of this object</returns>
					public extern virtual sap.ui.model.Context getBindingContext();

					/// <summary>
					/// Returns the binding info for the given property or aggregation. The binding info contains information about path, binding object, format options, sorter, filter etc. for the property or aggregation. As the binding object is only created when the model becomes available, the binding property may be undefined.
					/// </summary>
					/// <param name="sName">the name of the property or aggregation</param>
					/// <returns>the binding info object, containing at least a path or parts property and, depending on the binding type, additional properties</returns>
					public extern virtual object getBindingInfo(string sName);

					/// <summary>
					/// Get the binding path for a specific aggregation/property
					/// </summary>
					/// <param name="sName">the name of the property or aggregation</param>
					/// <returns>the binding path for the given name</returns>
					public extern virtual string getBindingPath(string sName);

					/// <summary>
					/// Returns the parent managed object as new eventing parent to enable control event bubbling or <code>null</code> if this object hasn't been added to a parent yet.
					/// </summary>
					/// <returns>the parent event provider</returns>
					public extern override sap.ui.@base.EventProvider getEventingParent();

					/// <summary>
					/// Returns the object's Id.
					/// </summary>
					/// <returns>the objects's Id.</returns>
					public extern virtual string getId();

					/// <summary>
					/// Returns the metadata for the class that this object belongs to.
					/// </summary>
					/// <returns>Metadata for the class of the object</returns>
					public extern virtual sap.ui.@base.ManagedObjectMetadata getMetadata();

					/// <summary>
					/// Get the model to be used for data bindings with the given model name. If the object does not have a model set on itself, it will use the first model defined in its parent hierarchy.
					/// 
					/// The name can be omitted to reference the default model or it must be a non-empty string.
					/// 
					/// <b>Note:</b> to be compatible with future versions of this API, you must not use the following model names: <ul> <li><code>null</code></li> <li>empty string <code>""</code></li> <li>string literals <code>"null"</code> or <code>"undefined"</code></li> </ul> Omitting the model name (or using the value <code>undefined</code>) is explicitly allowed and refers to the default model.
					/// </summary>
					/// <param name="sModelName">name of the model to be retrieved</param>
					/// <returns>oModel</returns>
					public extern virtual sap.ui.model.Model getModel(string sModelName);

					/// <summary>
					/// Get the model to be used for data bindings with the given model name. If the object does not have a model set on itself, it will use the first model defined in its parent hierarchy.
					/// 
					/// The name can be omitted to reference the default model or it must be a non-empty string.
					/// 
					/// <b>Note:</b> to be compatible with future versions of this API, you must not use the following model names: <ul> <li><code>null</code></li> <li>empty string <code>""</code></li> <li>string literals <code>"null"</code> or <code>"undefined"</code></li> </ul> Omitting the model name (or using the value <code>undefined</code>) is explicitly allowed and refers to the default model.
					/// </summary>
					/// <returns>oModel</returns>
					public extern virtual sap.ui.model.Model getModel();

					/// <summary>
					/// Get the object binding object for a specific model.
					/// 
					/// <b>Note:</b> to be compatible with future versions of this API, you must not use the following model names: <ul> <li><code>null</code></li> <li>empty string <code>""</code></li> <li>string literals <code>"null"</code> or <code>"undefined"</code></li> </ul> Omitting the model name (or using the value <code>undefined</code>) is explicitly allowed and refers to the default model.
					/// </summary>
					/// <param name="sModelName">Non-empty name of the model or <code>undefined</code></param>
					/// <returns>Context binding for the given model name or <code>undefined</code></returns>
					public extern virtual sap.ui.model.ContextBinding getObjectBinding(string sModelName);

					/// <summary>
					/// Get the object binding object for a specific model.
					/// 
					/// <b>Note:</b> to be compatible with future versions of this API, you must not use the following model names: <ul> <li><code>null</code></li> <li>empty string <code>""</code></li> <li>string literals <code>"null"</code> or <code>"undefined"</code></li> </ul> Omitting the model name (or using the value <code>undefined</code>) is explicitly allowed and refers to the default model.
					/// </summary>
					/// <returns>Context binding for the given model name or <code>undefined</code></returns>
					public extern virtual sap.ui.model.ContextBinding getObjectBinding();

					/// <summary>
					/// Returns the origin info for the value of the given property.
					/// 
					/// The origin info might contain additional information for translatable texts. The bookkeeping of this information is not active by default and must be activated by configuration. Even then, it might not be present for all properties and their values depending on where the value came form.
					/// </summary>
					/// <param name="sPropertyName">the name of the property</param>
					/// <returns>a map of properties describing the origin of this property value or null</returns>
					public extern virtual object getOriginInfo(string sPropertyName);

					/// <summary>
					/// Returns the parent managed object or <code>null</code> if this object hasn't been added to a parent yet.
					/// 
					/// The parent returned by this method is the technical parent used for data binding, invalidation, rendering etc. It might differ from the object on which the application originally added this object (the so called 'API parent'): some composite controls internally use hidden controls or containers to store their children. This method will return the innermost container that technically contains this object as a child.
					/// 
					/// <b>Example:</b>
					/// 
					/// Assume that a <code>Dialog</code> internally uses a (hidden) <code>VerticalLayout</code> to store its content:
					/// 
					/// <pre>
					///   Dialog (API parent)
					///    \__ VerticalLayout (hidden composite part)
					///       \__ Text (API child)
					/// </pre>
					/// 
					/// If you add some content by calling the <code>Dialog.prototype.addContent</code> API, this will lead to the following observations:
					/// 
					/// <pre>
					///   oDialog.addContent(oText);
					///   console.log(oText.getParent() === oDialog);  // false
					///   console.log(oText.getParent() instanceof VerticalLayout); // true
					///   console.log(oText.getParent().getParent() === oDialog); // true now, but might fail with later versions
					/// </pre>
					/// 
					/// Technically, from API perspective, <code>oText</code> is added as a child to <code>Dialog</code>. But internally, the <code>Dialog</code> adds the child to the hidden <code>VerticalLayout</code> container. If you now call the <code>getParent</code> method of the child, you will get the internal <code>VerticalLayout</code> object and not the <code>Dialog</code> API parent.
					/// 
					/// <b>Note: </b> The internal (hidden) structure of a composite control is not fixed and may be changed (see also our "Compatibility Rules"). Therefore, you should <b>never</b> rely on a specific structure or object being returned by <code>getParent</code>.
					/// 
					/// <b>Note: </b> There is no API to determine the original API parent.
					/// </summary>
					/// <returns>The technical parent managed object or <code>null</code></returns>
					public extern virtual sap.ui.@base.ManagedObject getParent();

					/// <summary>
					/// get propagation listeners
					/// </summary>
					/// <returns>aPropagationListeners Returns registered propagationListeners</returns>
					private extern object[] getPropagationListeners();

					/// <summary>
					/// Returns the value for the property with the given <code>sPropertyName</code>.
					/// 
					/// <b>Note:</b> This method is a low-level API as described in <a href="#lowlevelapi">the class documentation</a>. Applications or frameworks must not use this method to generically retrieve the value of a property. Use the concrete method get<i>XYZ</i> for property 'XYZ' instead.
					/// </summary>
					/// <param name="sPropertyName">the name of the property</param>
					/// <returns>the value of the property</returns>
					public extern virtual object getProperty(string sPropertyName);

					/// <summary>
					/// Check if any model is set to the ManagedObject or to one of its parents (including UIArea and Core).
					/// 
					/// <b>Note:</b> A ManagedObject inherits models from the Core only when it is a descendant of a UIArea.
					/// </summary>
					/// <returns>whether a model reference exists or not</returns>
					public extern virtual bool hasModel();

					/// <summary>
					/// Searches for the provided ManagedObject in the named aggregation and returns its 0-based index if found, or -1 otherwise. Returns -2 if the given named aggregation is of cardinality 0..1 and doesn't reference the given object.
					/// 
					/// <b>Note:</b> This method is a low-level API as described in <a href="#lowlevelapi">the class documentation</a>. Applications or frameworks must not use this method to generically determine the position of an object in an aggregation. Use the concrete method indexOf<i>XYZ</i> for aggregation 'XYZ' instead.
					/// </summary>
					/// <param name="sAggregationName">the name of the aggregation</param>
					/// <param name="oObject">the ManagedObject whose index is looked for.</param>
					/// <returns>the index of the provided managed object in the aggregation.</returns>
					public extern virtual int indexOfAggregation(string sAggregationName, sap.ui.@base.ManagedObject oObject);

					/// <summary>
					/// Inserts managed object <code>oObject</code> to the aggregation named <code>sAggregationName</code> at position <code>iIndex</code>.
					/// 
					/// If the given object is not valid with regard to the aggregation (if it is not an instance of the type specified for that aggregation) or when the method is called for an aggregation of cardinality 0..1, then an Error is thrown (see {@link #validateAggregation}.
					/// 
					/// If the given index is out of range with respect to the current content of the aggregation, it is clipped to that range (0 for iIndex < 0, n for iIndex > n).
					/// 
					/// Please note that this method does not work as expected when an object is added that is already part of the aggregation. In order to change the index of an object inside an aggregation, first remove it, then insert it again.
					/// 
					/// <b>Note:</b> This method is a low-level API as described in <a href="#lowlevelapi">the class documentation</a>. Applications or frameworks must not use this method to generically insert an object into an aggregation. Use the concrete method insert<i>XYZ</i> for aggregation 'XYZ' instead.
					/// </summary>
					/// <param name="sAggregationName">the string identifying the aggregation the managed object <code>oObject</code> should be inserted into.</param>
					/// <param name="oObject">the ManagedObject to add; if empty, nothing is inserted.</param>
					/// <param name="iIndex">the <code>0</code>-based index the managed object should be inserted at; for a negative value <code>iIndex</code>, <code>oObject</code> is inserted at position 0; for a value greater than the current size of the aggregation, <code>oObject</code> is inserted at the last position</param>
					/// <param name="bSuppressInvalidate">if true, this ManagedObject as well as the added child are not marked as changed</param>
					/// <returns>Returns <code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.@base.ManagedObject insertAggregation(string sAggregationName, sap.ui.@base.ManagedObject oObject, int iIndex, bool bSuppressInvalidate);

					/// <summary>
					/// Inserts managed object <code>oObject</code> to the aggregation named <code>sAggregationName</code> at position <code>iIndex</code>.
					/// 
					/// If the given object is not valid with regard to the aggregation (if it is not an instance of the type specified for that aggregation) or when the method is called for an aggregation of cardinality 0..1, then an Error is thrown (see {@link #validateAggregation}.
					/// 
					/// If the given index is out of range with respect to the current content of the aggregation, it is clipped to that range (0 for iIndex < 0, n for iIndex > n).
					/// 
					/// Please note that this method does not work as expected when an object is added that is already part of the aggregation. In order to change the index of an object inside an aggregation, first remove it, then insert it again.
					/// 
					/// <b>Note:</b> This method is a low-level API as described in <a href="#lowlevelapi">the class documentation</a>. Applications or frameworks must not use this method to generically insert an object into an aggregation. Use the concrete method insert<i>XYZ</i> for aggregation 'XYZ' instead.
					/// </summary>
					/// <param name="sAggregationName">the string identifying the aggregation the managed object <code>oObject</code> should be inserted into.</param>
					/// <param name="oObject">the ManagedObject to add; if empty, nothing is inserted.</param>
					/// <param name="iIndex">the <code>0</code>-based index the managed object should be inserted at; for a negative value <code>iIndex</code>, <code>oObject</code> is inserted at position 0; for a value greater than the current size of the aggregation, <code>oObject</code> is inserted at the last position</param>
					/// <returns>Returns <code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.@base.ManagedObject insertAggregation(string sAggregationName, sap.ui.@base.ManagedObject oObject, int iIndex);

					/// <summary>
					/// This triggers rerendering of itself and its children.
					/// 
					/// As <code>sap.ui.base.ManagedObject</code> "bubbles up" the invalidate, changes to child-<code>Elements</code> will also result in rerendering of the whole sub tree.
					/// </summary>
					public extern virtual void invalidate();

					/// <summary>
					/// Find out whether a property or aggregation is bound
					/// </summary>
					/// <param name="sName">the name of the property or aggregation</param>
					/// <returns>whether a binding exists for the given name</returns>
					public extern virtual bool isBound(string sName);

					/// <summary>
					/// Returns whether rerendering is currently suppressed on this ManagedObject
					/// </summary>
					/// <returns>boolean</returns>
					public extern virtual void isInvalidateSuppressed();

					/// <summary>
					/// Returns whether the given property value is initial and has not been explicitly set or bound. Even after setting the default value or setting null/undefined (which also causes the default value to be set), the property is no longer initial. A property can be reset to initial state by calling <code>resetProperty(sPropertyName)</code>.
					/// </summary>
					/// <param name="sPropertyName">the name of the property</param>
					/// <returns>true if the property is initial</returns>
					public extern virtual bool isPropertyInitial(string sPropertyName);

					/// <summary>
					/// This method is used internally and should only be overridden by a tree managed object which utilizes the tree binding. In this case and if the aggregation is a tree node the overridden method should then return true. If true is returned the tree binding will be used instead of the list binding.
					/// </summary>
					/// <param name="sName">the aggregation to bind (e.g. nodes for a tree managed object)</param>
					/// <returns>whether tree binding should be used or list binding. Default is false. Override method to change this behavior.</returns>
					public extern virtual bool isTreeBinding(string sName);

					/// <summary>
					/// Generic method which is called, whenever messages for this object exist.
					/// </summary>
					/// <param name="sName">The property name</param>
					/// <param name="aMessages">The messages</param>
					public extern virtual void propagateMessages(string sName, object[] aMessages);

					/// <summary>
					/// Generic method which can be called, when an aggregation needs to be refreshed. This method does not make any change on the aggregation, but just calls the <code>getContexts</code> method of the binding to trigger fetching of new data.
					/// 
					/// Subclasses should call this method only in the implementation of a named refresh method and for no other purposes. The framework might change the conditions under which the method is called and the method implementation might rely on those conditions.
					/// </summary>
					/// <param name="sName">name of the aggregation to refresh</param>
					public extern virtual void refreshAggregation(string sName);

					/// <summary>
					/// Removes an object from the aggregation named <code>sAggregationName</code> with cardinality 0..n.
					/// 
					/// The removed object is not destroyed nor is it marked as changed.
					/// 
					/// If the given object is found in the aggregation, it is removed, it's parent relationship is unset and this ManagedObject is marked as changed. The removed object is returned as result of this method. If the object could not be found, <code>undefined</code> is returned.
					/// 
					/// This method must only be called for aggregations of cardinality 0..n. The only way to remove objects from a 0..1 aggregation is to set a <code>null</code> value for them.
					/// 
					/// <b>Note:</b> This method is a low-level API as described in <a href="#lowlevelapi">the class documentation</a>. Applications or frameworks must not use this method to generically remove an object from an aggregation. Use the concrete method remove<i>XYZ</i> for aggregation 'XYZ' instead.
					/// </summary>
					/// <param name="sAggregationName">the string identifying the aggregation that the given object should be removed from</param>
					/// <param name="vObject">the position or ID of the ManagedObject that should be removed or that ManagedObject itself; if <code>vObject</code> is invalid, a negative value or a value greater or equal than the current size of the aggregation, nothing is removed.</param>
					/// <param name="bSuppressInvalidate">if true, this ManagedObject is not marked as changed</param>
					/// <returns>the removed object or null</returns>
					public extern virtual sap.ui.@base.ManagedObject removeAggregation(string sAggregationName, Union<int, string, sap.ui.@base.ManagedObject> vObject, bool bSuppressInvalidate);

					/// <summary>
					/// Removes an object from the aggregation named <code>sAggregationName</code> with cardinality 0..n.
					/// 
					/// The removed object is not destroyed nor is it marked as changed.
					/// 
					/// If the given object is found in the aggregation, it is removed, it's parent relationship is unset and this ManagedObject is marked as changed. The removed object is returned as result of this method. If the object could not be found, <code>undefined</code> is returned.
					/// 
					/// This method must only be called for aggregations of cardinality 0..n. The only way to remove objects from a 0..1 aggregation is to set a <code>null</code> value for them.
					/// 
					/// <b>Note:</b> This method is a low-level API as described in <a href="#lowlevelapi">the class documentation</a>. Applications or frameworks must not use this method to generically remove an object from an aggregation. Use the concrete method remove<i>XYZ</i> for aggregation 'XYZ' instead.
					/// </summary>
					/// <param name="sAggregationName">the string identifying the aggregation that the given object should be removed from</param>
					/// <param name="vObject">the position or ID of the ManagedObject that should be removed or that ManagedObject itself; if <code>vObject</code> is invalid, a negative value or a value greater or equal than the current size of the aggregation, nothing is removed.</param>
					/// <returns>the removed object or null</returns>
					public extern virtual sap.ui.@base.ManagedObject removeAggregation(string sAggregationName, Union<int, string, sap.ui.@base.ManagedObject> vObject);

					/// <summary>
					/// Removes all objects from the 0..n-aggregation named <code>sAggregationName</code>.
					/// 
					/// The removed objects are not destroyed nor are they marked as changed.
					/// 
					/// Additionally, it clears the parent relationship of all removed objects, marks this ManagedObject as changed and returns an array with the removed objects.
					/// 
					/// If the aggregation did not contain any objects, an empty array is returned and this ManagedObject is not marked as changed.
					/// 
					/// <b>Note:</b> This method is a low-level API as described in <a href="#lowlevelapi">the class documentation</a>. Applications or frameworks must not use this method to generically remove all objects from an aggregation. Use the concrete method removeAll<i>XYZ</i> for aggregation 'XYZ' instead.
					/// </summary>
					/// <param name="sAggregationName">the name of the aggregation</param>
					/// <param name="bSuppressInvalidate">if true, this ManagedObject is not marked as changed</param>
					/// <returns>an array of the removed elements (might be empty)</returns>
					public extern virtual object[] removeAllAggregation(string sAggregationName, bool bSuppressInvalidate);

					/// <summary>
					/// Removes all objects from the 0..n-aggregation named <code>sAggregationName</code>.
					/// 
					/// The removed objects are not destroyed nor are they marked as changed.
					/// 
					/// Additionally, it clears the parent relationship of all removed objects, marks this ManagedObject as changed and returns an array with the removed objects.
					/// 
					/// If the aggregation did not contain any objects, an empty array is returned and this ManagedObject is not marked as changed.
					/// 
					/// <b>Note:</b> This method is a low-level API as described in <a href="#lowlevelapi">the class documentation</a>. Applications or frameworks must not use this method to generically remove all objects from an aggregation. Use the concrete method removeAll<i>XYZ</i> for aggregation 'XYZ' instead.
					/// </summary>
					/// <param name="sAggregationName">the name of the aggregation</param>
					/// <returns>an array of the removed elements (might be empty)</returns>
					public extern virtual object[] removeAllAggregation(string sAggregationName);

					/// <summary>
					/// Removes all the objects in the 0..n-association named <code>sAssociationName</code> and returns an array with their IDs. This ManagedObject is marked as changed, if the association contained any objects.
					/// 
					/// <b>Note:</b> This method is a low-level API as described in <a href="#lowlevelapi">the class documentation</a>. Applications or frameworks must not use this method to generically remove all object from an association. Use the concrete method removeAll<i>XYZ</i> for association 'XYZ' instead.
					/// </summary>
					/// <param name="sAssociationName">the name of the association</param>
					/// <param name="bSuppressInvalidate">if true, this ManagedObject is not marked as changed</param>
					/// <returns>an array with the IDs of the removed objects (might be empty)</returns>
					public extern virtual object[] removeAllAssociation(string sAssociationName, bool bSuppressInvalidate);

					/// <summary>
					/// Removes all the objects in the 0..n-association named <code>sAssociationName</code> and returns an array with their IDs. This ManagedObject is marked as changed, if the association contained any objects.
					/// 
					/// <b>Note:</b> This method is a low-level API as described in <a href="#lowlevelapi">the class documentation</a>. Applications or frameworks must not use this method to generically remove all object from an association. Use the concrete method removeAll<i>XYZ</i> for association 'XYZ' instead.
					/// </summary>
					/// <param name="sAssociationName">the name of the association</param>
					/// <returns>an array with the IDs of the removed objects (might be empty)</returns>
					public extern virtual object[] removeAllAssociation(string sAssociationName);

					/// <summary>
					/// Removes a <code>ManagedObject</code> from the association named <code>sAssociationName</code>.
					/// 
					/// If an object is removed, the ID of that object is returned and this <code>ManagedObject</code> is marked as changed. Otherwise <code>null</code> is returned.
					/// 
					/// If the same object was added multiple times to the same association, only a single occurrence of it will be removed by this method. If the object is not found or if the parameter can't be interpreted neither as a <code>ManagedObject</code> (or ID) nor as an index in the association, nothing will be removed. The same is true if an index is given and if that index is out of range for the association.
					/// 
					/// <b>Note:</b> This method is a low-level API as described in <a href="#lowlevelapi">the class documentation</a>. Applications or frameworks must not use this method to generically remove an object from an association. Use the concrete method remove<i>XYZ</i> for association 'XYZ' instead.
					/// </summary>
					/// <param name="sAssociationName">the string identifying the association the <code>ManagedObject</code> should be removed from.</param>
					/// <param name="vObject">the position or ID of the <code>ManagedObject</code> to remove or the <code>ManagedObject</code> itself; if <code>vObject</code> is invalid input, a negative value or a value greater or equal than the current size of the association, nothing is removed</param>
					/// <param name="bSuppressInvalidate">if <code>true</code>, the managed object is not marked as changed</param>
					/// <returns>ID of the removed <code>ManagedObject</code> or <code>null</code></returns>
					public extern virtual string removeAssociation(string sAssociationName, Union<int, string, sap.ui.@base.ManagedObject> vObject, bool bSuppressInvalidate);

					/// <summary>
					/// Removes a <code>ManagedObject</code> from the association named <code>sAssociationName</code>.
					/// 
					/// If an object is removed, the ID of that object is returned and this <code>ManagedObject</code> is marked as changed. Otherwise <code>null</code> is returned.
					/// 
					/// If the same object was added multiple times to the same association, only a single occurrence of it will be removed by this method. If the object is not found or if the parameter can't be interpreted neither as a <code>ManagedObject</code> (or ID) nor as an index in the association, nothing will be removed. The same is true if an index is given and if that index is out of range for the association.
					/// 
					/// <b>Note:</b> This method is a low-level API as described in <a href="#lowlevelapi">the class documentation</a>. Applications or frameworks must not use this method to generically remove an object from an association. Use the concrete method remove<i>XYZ</i> for association 'XYZ' instead.
					/// </summary>
					/// <param name="sAssociationName">the string identifying the association the <code>ManagedObject</code> should be removed from.</param>
					/// <param name="vObject">the position or ID of the <code>ManagedObject</code> to remove or the <code>ManagedObject</code> itself; if <code>vObject</code> is invalid input, a negative value or a value greater or equal than the current size of the association, nothing is removed</param>
					/// <returns>ID of the removed <code>ManagedObject</code> or <code>null</code></returns>
					public extern virtual string removeAssociation(string sAssociationName, Union<int, string, sap.ui.@base.ManagedObject> vObject);

					/// <summary>
					/// remove a propagation listener
					/// </summary>
					/// <param name="listener">function</param>
					/// <returns>Returns <code>this</code> to allow method chaining</returns>
					private extern sap.ui.@base.ManagedObject removePropagationListener(object listener);

					/// <summary>
					/// Resets the given property to the default value and also restores the "initial" state (like it has never been set).
					/// </summary>
					/// <param name="sPropertyName">the name of the property</param>
					/// <returns>Returns <code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.@base.ManagedObject resetProperty(string sPropertyName);

					/// <summary>
					/// Activates the given ID and settings preprocessors, executes the given function and restores the previously active preprocessors.
					/// 
					/// When a preprocessor is not defined in <code>oPreprocessors</code>, then the currently active preprocessor is temporarily deactivated while <code>fn</code> is executed.
					/// 
					/// See the <code>_fnIdPreprocessor</code> and <code>_fnSettingsPreprocessor</code> members in this class for a detailed description of the preprocessors.
					/// 
					/// This method is intended for internal use in the sap/ui/base and sap/ui/core packages only.
					/// </summary>
					/// <param name="fn">Function to execute</param>
					/// <param name="oPreprocessors">Preprocessors to use while executing <code>fn</code></param>
					/// <param name="oThisArg">Value to use as <code>this</code> when executing <code>fn</code></param>
					/// <returns>Returns the value that <code>fn</code> returned after execution</returns>
					private extern static object runWithPreprocessors(object fn, object oPreprocessors, object oThisArg);

					/// <summary>
					/// Activates the given ID and settings preprocessors, executes the given function and restores the previously active preprocessors.
					/// 
					/// When a preprocessor is not defined in <code>oPreprocessors</code>, then the currently active preprocessor is temporarily deactivated while <code>fn</code> is executed.
					/// 
					/// See the <code>_fnIdPreprocessor</code> and <code>_fnSettingsPreprocessor</code> members in this class for a detailed description of the preprocessors.
					/// 
					/// This method is intended for internal use in the sap/ui/base and sap/ui/core packages only.
					/// </summary>
					/// <param name="fn">Function to execute</param>
					/// <param name="oPreprocessors">Preprocessors to use while executing <code>fn</code></param>
					/// <returns>Returns the value that <code>fn</code> returned after execution</returns>
					private extern static object runWithPreprocessors(object fn, object oPreprocessors);

					/// <summary>
					/// Activates the given ID and settings preprocessors, executes the given function and restores the previously active preprocessors.
					/// 
					/// When a preprocessor is not defined in <code>oPreprocessors</code>, then the currently active preprocessor is temporarily deactivated while <code>fn</code> is executed.
					/// 
					/// See the <code>_fnIdPreprocessor</code> and <code>_fnSettingsPreprocessor</code> members in this class for a detailed description of the preprocessors.
					/// 
					/// This method is intended for internal use in the sap/ui/base and sap/ui/core packages only.
					/// </summary>
					/// <param name="fn">Function to execute</param>
					/// <returns>Returns the value that <code>fn</code> returned after execution</returns>
					private extern static object runWithPreprocessors(object fn);

					/// <summary>
					/// Sets a new object in the named 0..1 aggregation of this ManagedObject and marks this ManagedObject as changed.
					/// 
					/// If the given object is not valid with regard to the aggregation (if it is not an instance of the type specified for that aggregation) or when the method is called for an aggregation of cardinality 0..n, then an Error is thrown (see {@link #validateAggregation}.
					/// 
					/// If the new object is the same as the currently aggregated object, then the internal state is not modified and this ManagedObject is not marked as changed.
					/// 
					/// If the given object is different, the parent of a previously aggregated object is cleared (it must have been this ManagedObject before), the parent of the given object is set to this ManagedObject and {@link #invalidate} is called for this object.
					/// 
					/// Note that this method does neither return nor destroy the previously aggregated object. This behavior is inherited by named set methods (see below) in subclasses. To avoid memory leaks, applications therefore should first get the aggregated object, keep a reference to it or destroy it, depending on their needs, and only then set a new object.
					/// 
					/// Note that ManagedObject only implements a single level of change tracking: if a first call to setAggregation recognizes a change, 'invalidate' is called. If another call to setAggregation reverts that change, invalidate() will be called again, the new status is not recognized as being 'clean' again.
					/// 
					/// <b>Note:</b> This method is a low-level API as described in <a href="#lowlevelapi">the class documentation</a>. Applications or frameworks must not use this method to generically set an object in an aggregation. Use the concrete method set<i>XYZ</i> for aggregation 'XYZ' or the generic {@link #applySettings} instead.
					/// </summary>
					/// <param name="sAggregationName">name of an 0..1 aggregation</param>
					/// <param name="oObject">the managed object that is set as aggregated object</param>
					/// <param name="bSuppressInvalidate">if true, this ManagedObject is not marked as changed</param>
					/// <returns>Returns <code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.@base.ManagedObject setAggregation(string sAggregationName, object oObject, bool bSuppressInvalidate);

					/// <summary>
					/// Sets a new object in the named 0..1 aggregation of this ManagedObject and marks this ManagedObject as changed.
					/// 
					/// If the given object is not valid with regard to the aggregation (if it is not an instance of the type specified for that aggregation) or when the method is called for an aggregation of cardinality 0..n, then an Error is thrown (see {@link #validateAggregation}.
					/// 
					/// If the new object is the same as the currently aggregated object, then the internal state is not modified and this ManagedObject is not marked as changed.
					/// 
					/// If the given object is different, the parent of a previously aggregated object is cleared (it must have been this ManagedObject before), the parent of the given object is set to this ManagedObject and {@link #invalidate} is called for this object.
					/// 
					/// Note that this method does neither return nor destroy the previously aggregated object. This behavior is inherited by named set methods (see below) in subclasses. To avoid memory leaks, applications therefore should first get the aggregated object, keep a reference to it or destroy it, depending on their needs, and only then set a new object.
					/// 
					/// Note that ManagedObject only implements a single level of change tracking: if a first call to setAggregation recognizes a change, 'invalidate' is called. If another call to setAggregation reverts that change, invalidate() will be called again, the new status is not recognized as being 'clean' again.
					/// 
					/// <b>Note:</b> This method is a low-level API as described in <a href="#lowlevelapi">the class documentation</a>. Applications or frameworks must not use this method to generically set an object in an aggregation. Use the concrete method set<i>XYZ</i> for aggregation 'XYZ' or the generic {@link #applySettings} instead.
					/// </summary>
					/// <param name="sAggregationName">name of an 0..1 aggregation</param>
					/// <param name="oObject">the managed object that is set as aggregated object</param>
					/// <returns>Returns <code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.@base.ManagedObject setAggregation(string sAggregationName, object oObject);

					/// <summary>
					/// Sets the associated object for the given managed association of cardinality '0..1' and marks this ManagedObject as changed.
					/// 
					/// The associated object can either be given by itself or by its id. If <code>null</code> or <code>undefined</code> is given, the association is cleared.
					/// 
					/// <b>Note:</b> This method is a low-level API as described in <a href="#lowlevelapi">the class documentation</a>. Applications or frameworks must not use this method to generically set an object in an association. Use the concrete method set<i>XYZ</i> for association 'XYZ' or the generic {@link #applySettings} instead.
					/// </summary>
					/// <param name="sAssociationName">name of the association</param>
					/// <param name="sId">the ID of the managed object that is set as an association, or the managed object itself or null</param>
					/// <param name="bSuppressInvalidate">if true, the managed objects invalidate method is not called</param>
					/// <returns>Returns <code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.@base.ManagedObject setAssociation(string sAssociationName, Union<string, sap.ui.@base.ManagedObject> sId, bool bSuppressInvalidate);

					/// <summary>
					/// Sets the associated object for the given managed association of cardinality '0..1' and marks this ManagedObject as changed.
					/// 
					/// The associated object can either be given by itself or by its id. If <code>null</code> or <code>undefined</code> is given, the association is cleared.
					/// 
					/// <b>Note:</b> This method is a low-level API as described in <a href="#lowlevelapi">the class documentation</a>. Applications or frameworks must not use this method to generically set an object in an association. Use the concrete method set<i>XYZ</i> for association 'XYZ' or the generic {@link #applySettings} instead.
					/// </summary>
					/// <param name="sAssociationName">name of the association</param>
					/// <param name="sId">the ID of the managed object that is set as an association, or the managed object itself or null</param>
					/// <returns>Returns <code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.@base.ManagedObject setAssociation(string sAssociationName, Union<string, sap.ui.@base.ManagedObject> sId);

					/// <summary>
					/// Set the binding context for this ManagedObject for the model with the given name.
					/// 
					/// <b>Note:</b> to be compatible with future versions of this API, you must not use the following model names: <ul> <li><code>null</code></li> <li>empty string <code>""</code></li> <li>string literals <code>"null"</code> or <code>"undefined"</code></li> </ul> Omitting the model name (or using the value <code>undefined</code>) is explicitly allowed and refers to the default model.
					/// 
					/// A value of<code>null</code> for <code>oContext</code> hides the parent context. The parent context will no longer be propagated to aggregated child controls. A value of <code>undefined</code> removes a currently active context or a <code>null</code> context and the parent context gets visible and propagated again.
					/// 
					/// <b>Note:</b> A ManagedObject inherits binding contexts from the Core only when it is a descendant of a UIArea.
					/// </summary>
					/// <param name="oContext">the new binding context for this object</param>
					/// <param name="sModelName">the name of the model to set the context for or <code>undefined</code></param>
					/// <returns>reference to the instance itself</returns>
					public extern virtual sap.ui.@base.ManagedObject setBindingContext(sap.ui.model.Context oContext, string sModelName);

					/// <summary>
					/// Set the binding context for this ManagedObject for the model with the given name.
					/// 
					/// <b>Note:</b> to be compatible with future versions of this API, you must not use the following model names: <ul> <li><code>null</code></li> <li>empty string <code>""</code></li> <li>string literals <code>"null"</code> or <code>"undefined"</code></li> </ul> Omitting the model name (or using the value <code>undefined</code>) is explicitly allowed and refers to the default model.
					/// 
					/// A value of<code>null</code> for <code>oContext</code> hides the parent context. The parent context will no longer be propagated to aggregated child controls. A value of <code>undefined</code> removes a currently active context or a <code>null</code> context and the parent context gets visible and propagated again.
					/// 
					/// <b>Note:</b> A ManagedObject inherits binding contexts from the Core only when it is a descendant of a UIArea.
					/// </summary>
					/// <param name="oContext">the new binding context for this object</param>
					/// <returns>reference to the instance itself</returns>
					public extern virtual sap.ui.@base.ManagedObject setBindingContext(sap.ui.model.Context oContext);

					/// <summary>
					/// Sets or unsets a model for the given model name for this ManagedObject.
					/// 
					/// The <code>sName</code> must either be <code>undefined</code> (or omitted) or a non-empty string. When the name is omitted, the default model is set/unset. To be compatible with future versions of this API, you must not use the following model names: <ul> <li><code>null</code></li> <li>empty string <code>""</code></li> <li>string literals <code>"null"</code> or <code>"undefined"</code></li> </ul>
					/// 
					/// When <code>oModel</code> is <code>null</code> or <code>undefined</code>, a previously set model with that name is removed from this ManagedObject. If an ancestor (parent, UIArea or Core) has a model with that name, this ManagedObject will immediately inherit that model from its ancestor.
					/// 
					/// All local bindings that depend on the given model name are updated (created if the model references became complete now; updated, if any model reference has changed; removed if the model references became incomplete now).
					/// 
					/// Any change (new model, removed model, inherited model) is also applied to all aggregated descendants as long as a descendant doesn't have its own model set for the given name.
					/// 
					/// <b>Note:</b> By design, it is not possible to hide an inherited model by setting a <code>null</code> or <code>undefined</code> model. Applications can set an empty model to achieve the same.
					/// 
					/// <b>Note:</b> A ManagedObject inherits models from the Core only when it is a descendant of a UIArea.
					/// </summary>
					/// <param name="oModel">the model to be set or <code>null</code> or <code>undefined</code></param>
					/// <param name="sName">the name of the model or <code>undefined</code></param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.@base.ManagedObject setModel(sap.ui.model.Model oModel, string sName);

					/// <summary>
					/// Sets or unsets a model for the given model name for this ManagedObject.
					/// 
					/// The <code>sName</code> must either be <code>undefined</code> (or omitted) or a non-empty string. When the name is omitted, the default model is set/unset. To be compatible with future versions of this API, you must not use the following model names: <ul> <li><code>null</code></li> <li>empty string <code>""</code></li> <li>string literals <code>"null"</code> or <code>"undefined"</code></li> </ul>
					/// 
					/// When <code>oModel</code> is <code>null</code> or <code>undefined</code>, a previously set model with that name is removed from this ManagedObject. If an ancestor (parent, UIArea or Core) has a model with that name, this ManagedObject will immediately inherit that model from its ancestor.
					/// 
					/// All local bindings that depend on the given model name are updated (created if the model references became complete now; updated, if any model reference has changed; removed if the model references became incomplete now).
					/// 
					/// Any change (new model, removed model, inherited model) is also applied to all aggregated descendants as long as a descendant doesn't have its own model set for the given name.
					/// 
					/// <b>Note:</b> By design, it is not possible to hide an inherited model by setting a <code>null</code> or <code>undefined</code> model. Applications can set an empty model to achieve the same.
					/// 
					/// <b>Note:</b> A ManagedObject inherits models from the Core only when it is a descendant of a UIArea.
					/// </summary>
					/// <param name="oModel">the model to be set or <code>null</code> or <code>undefined</code></param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.@base.ManagedObject setModel(sap.ui.model.Model oModel);

					/// <summary>
					/// Sets the given value for the given property after validating and normalizing it, marks this object as changed.
					/// 
					/// If the value is not valid with regard to the declared data type of the property, an Error is thrown. In case <code>null</code> or <code>undefined</code> is passed, the default value for this property is used (see {@link #validateProperty}). To fully reset the property to initial state, use {@link #resetProperty} instead. If the validated and normalized <code>oValue</code> equals the current value of the property, the internal state of this object is not changed (apart from the result of {@link #isPropertyInitial}). If the value changes, it is stored internally and the {@link #invalidate} method is called on this object. In the case of TwoWay databinding, the bound model is informed about the property change.
					/// 
					/// Note that ManagedObject only implements a single level of change tracking: if a first call to setProperty recognizes a change, 'invalidate' is called. If another call to setProperty reverts that change, invalidate() will be called again, the new status is not recognized as being 'clean' again.
					/// 
					/// <b>Note:</b> This method is a low level API as described in <a href="#lowlevelapi">the class documentation</a>. Applications or frameworks must not use this method to generically set a property. Use the concrete method set<i>XYZ</i> for property 'XYZ' or the generic {@link #applySettings} instead.
					/// </summary>
					/// <param name="sPropertyName">name of the property to set</param>
					/// <param name="oValue">value to set the property to</param>
					/// <param name="bSuppressInvalidate">if true, the managed object is not marked as changed</param>
					/// <returns>Returns <code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.@base.ManagedObject setProperty(string sPropertyName, object oValue, bool bSuppressInvalidate);

					/// <summary>
					/// Sets the given value for the given property after validating and normalizing it, marks this object as changed.
					/// 
					/// If the value is not valid with regard to the declared data type of the property, an Error is thrown. In case <code>null</code> or <code>undefined</code> is passed, the default value for this property is used (see {@link #validateProperty}). To fully reset the property to initial state, use {@link #resetProperty} instead. If the validated and normalized <code>oValue</code> equals the current value of the property, the internal state of this object is not changed (apart from the result of {@link #isPropertyInitial}). If the value changes, it is stored internally and the {@link #invalidate} method is called on this object. In the case of TwoWay databinding, the bound model is informed about the property change.
					/// 
					/// Note that ManagedObject only implements a single level of change tracking: if a first call to setProperty recognizes a change, 'invalidate' is called. If another call to setProperty reverts that change, invalidate() will be called again, the new status is not recognized as being 'clean' again.
					/// 
					/// <b>Note:</b> This method is a low level API as described in <a href="#lowlevelapi">the class documentation</a>. Applications or frameworks must not use this method to generically set a property. Use the concrete method set<i>XYZ</i> for property 'XYZ' or the generic {@link #applySettings} instead.
					/// </summary>
					/// <param name="sPropertyName">name of the property to set</param>
					/// <param name="oValue">value to set the property to</param>
					/// <returns>Returns <code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.@base.ManagedObject setProperty(string sPropertyName, object oValue);

					/// <summary>
					/// Returns a simple string representation of this managed object.
					/// 
					/// Mainly useful for tracing purposes.
					/// </summary>
					/// <returns>a string description of this managed object</returns>
					public extern override string toString();

					/// <summary>
					/// Unbind the aggregation from the model
					/// </summary>
					/// <param name="sName">the name of the aggregation</param>
					/// <param name="bSuppressReset">whether the reset to empty aggregation when unbinding should be suppressed</param>
					/// <returns>reference to the instance itself</returns>
					public extern virtual sap.ui.@base.ManagedObject unbindAggregation(string sName, bool bSuppressReset);

					/// <summary>
					/// Removes the defined binding context of this object, all bindings will now resolve relative to the parent context again.
					/// </summary>
					/// <param name="sModelName">name of the model to remove the context for.</param>
					/// <returns>reference to the instance itself</returns>
					[Obsolete("Deprecated since 1.11.1. please use unbindElement instead.")]
					public extern virtual sap.ui.@base.ManagedObject unbindContext(string sModelName);

					/// <summary>
					/// Removes the defined binding context of this object, all bindings will now resolve relative to the parent context again.
					/// </summary>
					/// <returns>reference to the instance itself</returns>
					[Obsolete("Deprecated since 1.11.1. please use unbindElement instead.")]
					public extern virtual sap.ui.@base.ManagedObject unbindContext();

					/// <summary>
					/// Removes the defined binding context of this object, all bindings will now resolve relative to the parent context again.
					/// </summary>
					/// <param name="sModelName">name of the model to remove the context for.</param>
					/// <returns>reference to the instance itself</returns>
					public extern virtual sap.ui.@base.ManagedObject unbindObject(string sModelName);

					/// <summary>
					/// Removes the defined binding context of this object, all bindings will now resolve relative to the parent context again.
					/// </summary>
					/// <returns>reference to the instance itself</returns>
					public extern virtual sap.ui.@base.ManagedObject unbindObject();

					/// <summary>
					/// Unbind the property from the model
					/// </summary>
					/// <param name="sName">the name of the property</param>
					/// <param name="bSuppressReset">whether the reset to the default value when unbinding should be suppressed</param>
					/// <returns>reference to the instance itself</returns>
					public extern virtual sap.ui.@base.ManagedObject unbindProperty(string sName, bool bSuppressReset);

					/// <summary>
					/// Generic method which is called whenever an aggregation binding has changed.
					/// 
					/// Depending on the type of the list binding and on additional configuration, this method either destroys all elements in the aggregation <code>sName</code> and recreates them anew or tries to reuse as many existing objects as possible. It is up to the method which strategy it uses.
					/// 
					/// In case a managed object needs special handling for an aggregation binding, it can create a named update method (e.g. <code>update<i>Rows</i></code> for an aggregation <code>rows</code>) which then will be called by the framework instead of this generic method.
					/// 
					/// Subclasses should call this method only in the implementation of such a named update method and for no other purposes. The framework might change the conditions under which the method is called and the method implementation might rely on those conditions.
					/// </summary>
					/// <param name="sName">name of the aggregation to update</param>
					public extern virtual void updateAggregation(string sName);

					/// <summary>
					/// Checks whether the given value is of the proper type for the given aggregation name.
					/// 
					/// This method is already called by {@link #setAggregation}, {@link #addAggregation} and {@link #insertAggregation}. In many cases, subclasses of ManagedObject don't need to call it again in their mutator methods.
					/// </summary>
					/// <param name="sAggregationName">the name of the aggregation</param>
					/// <param name="oObject">the aggregated object or a primitive value</param>
					/// <param name="bMultiple">whether the caller assumes the aggregation to have cardinality 0..n</param>
					/// <returns>the passed object</returns>
					public extern virtual Union<sap.ui.@base.ManagedObject, object> validateAggregation(string sAggregationName, Union<sap.ui.@base.ManagedObject, object> oObject, bool bMultiple);

					/// <summary>
					/// Checks whether the given value is of the proper type for the given property name.
					/// 
					/// In case <code>null</code> or <code>undefined</code> is passed, the default value for this property is used as value. If no default value is defined for the property, the default value of the type of the property is used.
					/// 
					/// If the property has a data type that is an instance of sap.ui.base.DataType and if a <code>normalize</code> function is defined for that type, that function will be called with the resulting value as only argument. The result of the function call is then used instead of the raw value.
					/// 
					/// This method is called by {@link #setProperty}. In many cases, subclasses of ManagedObject don't need to call it themselves.
					/// </summary>
					/// <param name="sPropertyName">the name of the property</param>
					/// <param name="oValue">the value</param>
					/// <returns>the normalized value for the passed value or for the default value if null or undefined was passed</returns>
					public extern virtual object validateProperty(string sPropertyName, object oValue);

					#endregion

					#endregion

				}
			}
		}
	}
}
