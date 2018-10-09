using System;
using System.Collections.Generic;
using Bridge;

namespace UI5
{
    public partial class sap
    {
        public static partial class ui
        {
            public static partial class @base
            {
                [External]
                public abstract partial class Object
                {
                    [External]
                    [ObjectLiteral]
                    public partial class Metadata
                    {
                        /// <summary>
                        /// (optional) set of names of implemented interfaces(defaults to no interfaces)
                        /// </summary>
                        public string[] interfaces;

                        /// <summary>
                        /// (optional) list of methods that should be part of the public facade of the class
                        /// </summary>
                        public string[] publicMethods;

                        /// <summary>
                        /// (optional) flag that marks the class as abstract (purely informational, defaults to false)
                        /// </summary>
                        public bool @abstract = false;

                        /// <summary>
                        /// (optional) flag that marks the class as final (defaults to false)
                        /// </summary>
                        public bool final = false;

                        /// <summary>
                        /// (optional) Whether the described class is deprecated and should not be used any more (defaults to false)
                        /// </summary>
                        public bool deprecated = false;

                        /// <summary>
                        /// (optional) Fully qualified name of a base class or empty. Not used with extend, but with defineClass
                        /// </summary>
                        public string baseType;

                        /// <summary>
                        /// (optional) Describes what sap ui5 object it is
                        /// </summary>
                        public string stereotype;
                    }
                }

                [External]
                public abstract partial class ManagedObject
                {
                    [External]
                    [ObjectLiteral]
                    public partial class Metadata : sap.ui.@base.Object.Metadata
                    {
                        /// <summary>
                        /// Name of the library that the new subclass should belong to. If the subclass is a control or element, it will automatically register with that library so that authoring tools can discover it. By convention, the name of the subclass should have the library name as a prefix, e.g. 'sap.ui.commons.Panel' belongs to library 'sap.ui.commons'.
                        /// </summary>
                        public string library;

                        /// <summary>
                        /// An object literal whose properties each define a new managed property in the ManagedObject subclass. The value can either be a simple string which then will be assumed to be the type of the new property or it can be an object literal of type UI5PropertyInfo
                        /// </summary>
                        public Map<Union<string, PropertyInfo>> properties;

                        /// <summary>
                        /// When specified, the default property must match the name of one of the properties defined for the new subclass (either own or inherited). The named property can be used to identify the main property to be used for bound data. E.g. the value property of a field control.
                        /// </summary>
                        public string defaultProperty;

                        /// <summary>
                        /// An object literal whose properties each define a new managed property in the ManagedObject subclass. The value can either be a simple string which then will be assumed to be the type of the new property or it can be an object literal of type UI5AggregationInfo
                        /// </summary>
                        public Map<Union<string, AggregationInfo>> aggregations;

                        /// <summary>
                        /// When specified, the default aggregation must match the name of one of the aggregations defined for the new subclass (either own or inherited). The named aggregation will be used in contexts where no aggregation is specified. E,g. when an object in an XMLView embeds other objects without naming an aggregation
                        /// </summary>
                        public string defaultAggregation;

                        /// <summary>
                        /// An object literal whose properties each define a new association of the ManagedObject subclass. The value can either be a simple string which then will be assumed to be the type of the new association or it can be an object literal of type UI5AssociationInfo
                        /// </summary>
                        public Map<Union<string, AssociationInfo>> associations;

                        /// <summary>
                        /// An object literal whose properties each define a new event of the ManagedObject subclass. The value can either be a simple string which then will be assumed to be the type of the new association or it can be an object literal of type UI5EventInfo
                        /// </summary>
                        public Map<Union<string, EventInfo>> events;

                        /// <summary>
                        /// Special settings are an experimental feature and MUST NOT BE USED by controls or applications outside of the sap.ui.core project.
                        /// </summary>
                        public object specialSettings;
                    }

                    [External]
                    [ObjectLiteral]
                    public partial class PropertyInfo
                    {
                        /// <summary>
                        /// type of the new property. Must either be one of the built-in types 'string', 'boolean', 'int', 'float', 'object' or 'any', or a type created and registered with sap.ui.base.DataType.createType or an array type based on one of the previous types.
                        /// </summary>
                        public string type;

                        /// <summary>
                        /// a semantic grouping of the properties, intended to be used in design time tools.Allowed values are(case sensitive) : Accessibility, Appearance, Behavior, Data, Designtime, Dimension, Identification, Misc
                        /// </summary>
                        public string group;

                        /// <summary>
                        /// the default value for the property or null if there is no defaultValue.
                        /// </summary>
                        public object defaultValue;

                        /// <summary>
                        /// (either can be omitted or set to the boolean value true or the magic string 'bindable') If set to true or 'bindable', additional named methods bindName and unbindName are generated as convenience.Despite its name, setting this flag is not mandatory to make the managed property bindable. The generic methods #bindProperty and #unbindProperty can always be used.
                        /// </summary>
                        public Union<bool, string> bindable;
                    }

                    [External]
                    [ObjectLiteral]
                    public partial class AggregationInfo
                    {
                        /// <summary>
                        /// string type of the new aggregation.must be the full global name of a ManagedObject subclass(in dot notation, e.g. 'sap.m.Button')
                        /// </summary>
                        public string type;

                        /// <summary>
                        /// alternative primitive types that the aggregation can have(like string etc.). Defaults to no alternative types.
                        /// </summary>
                        public string[] altTypes;

                        /// <summary>
                        /// boolean whether the aggregation is a 0..1 (false) or a 0..n aggregation(true), defaults to true
                        /// </summary>
                        public bool multiple = true;

                        /// <summary>
                        /// Singular name for 0..n aggregations.For 0..n aggregations the name by convention should be the plural name.Methods affecting multiple objects in an aggregation will use the plural name (e.g.getItems(), whereas methods that deal with a single object will use the singular name (e.g.addItem). The framework knows a set of common rules for building plural form of English nouns and uses these rules to determine a singular name on its own. if that name is wrong, a singluarName can be specified with this property.
                        /// </summary>
                        public string singularName;

                        /// <summary>
                        /// either 'hidden' or 'public', defaults to 'public'. Aggregations that belong to the API of a class must be 'public' whereas 'hidden' aggregations typically are used for the implementation of composite classes(e.g.composite controls)
                        /// </summary>
                        public string visibility = "public";

                        /// <summary>
                        /// (either can be omitted or set to the boolean value true or the magic string 'bindable') If set to true or 'bindable', additional named methods bindName and unbindName are generated as convenience.Despite its name, setting this flag is not mandatory to make the managed aggregation bindable. The generic methods #bindAggregation and #unbindAggregation can always be used.
                        /// </summary>
                        public Union<bool, string> bindable;

                        /// <summary>
                        /// Aggregration forwarding is used when application developers want to add child controls to an aggregation of a composite control, but the composite control does not keep these controls as direct children. Instead, it moves or forwards them to an aggregation of one of its internal controls.
                        /// </summary>
                        public ForwardingInfo forwarding;
                    }

                    [External]
                    [ObjectLiteral]
                    public partial class ForwardingInfo
                    {
                        /// <summary>
                        /// The name of the aggregation of the target control to which this aggregation is forwarded.
                        /// </summary>
                        public string aggregation;

                        /// <summary>
                        /// The name of a function of the composite control which always returns the target control instance.
                        /// </summary>
                        public string getter;

                        /// <summary>
                        /// A string which is appended to the ID of the composite control to construct the ID of the target control.
                        /// </summary>
                        public string idSuffix;
                    }

                    [External]
                    [ObjectLiteral]
                    public partial class AssociationInfo
                    {
                        /// <summary>
                        /// type of the new association
                        /// </summary>
                        public string type;

                        /// <summary>
                        /// boolean whether the association is a 0..1 (false) or a 0..n association (true), defaults to false(1) for associations
                        /// </summary>
                        public bool multiple = false;

                        /// <summary>
                        /// Singular name for 0..n associations. For 0..n associations the name by convention should be the plural name. Methods affecting multiple objects in an association will use the plural name (e.g. getItems(), whereas methods that deal with a single object will use the singular name (e.g. addItem). The framework knows a set of common rules for building plural form of English nouns and uses these rules to determine a singular name on its own. if that name is wrong, a singluarName can be specified with this property.
                        /// </summary>
                        public string singularName;
                    }

                    [External]
                    [ObjectLiteral]
                    public partial class EventInfo
                    {
                        /// <summary>
                        /// whether the event allows to prevented the default behavior of the event source
                        /// </summary>
                        public bool allowPreventDefault;

                        /// <summary>
                        /// an object literal that describes the parameters of this event.
                        /// </summary>
                        public Map<ParameterInfo> parameters;
                    }

                    [External]
                    [ObjectLiteral]
                    public partial class ParameterInfo
                    {
                        /// <summary>
                        /// type of the new parameter. Must either be one of the built-in types 'string', 'boolean', 'int', 'float', 'object' or 'any', or a type created and registered with sap.ui.base.DataType.createType or an array type based on one of the previous types.
                        /// </summary>
                        public string type;

                        /// <summary>
                        /// the default value for the parameter or null if there is no defaultValue.
                        /// </summary>
                        public object defaultValue;
                    }
                }
            }

            public static partial class core
            {
                /// <summary>
                /// Base Class for Component.
                /// </summary>
                [External]
                public abstract partial class Component
                {
                    [External]
                    [ObjectLiteral]
                    public partial class Metadata : sap.ui.@base.ManagedObject.Metadata
                    {
                        /// <summary>
                        /// Specifies if your component uses the descriptor
                        /// </summary>
                        public string manifest;

                        /// <summary>
                        /// Name of your component
                        /// </summary>
                        public string name;

                        /// <summary>
                        /// Version of your component
                        /// </summary>
                        public string version;

                        /// <summary>
                        /// Array of strings containing the paths to CSS and JavaScript resources for your component; will be added to the header of the HTML page and loaded by the browser.The resources will be resolved relative to the location of Component.js.
                        /// </summary>
                        [Obsolete("Deprecated and no longer needed if you use the descriptor")]
                        public string[] includes;

                        /// <summary>
                        /// Used to specify all external dependencies, such as libraries or components.Like the includes for resources that are added to the application’s HTML, the dependencies are loaded by SAPUI5 core before the component is initialized.Everything that is referenced here can be used in your component code right from the start.Specify here external dependences such as libraries or components, that will be loaded by SAPUI5 core in the initialization phase of your Component and can be used after it.
                        /// </summary>
                        [Obsolete("Deprecated and no longer needed if you use the descriptor")]
                        public ComponentDependencies dependencies;

                        /// <summary>
                        /// Static configuration; specify the name-value pairs that you need in the component
                        /// </summary>
                        [Obsolete("Deprecated and no longer needed if you use the descriptor")]
                        public Map<string> config;

                        /// <summary>
                        /// Customizing for components and views, see Extending Applications
                        /// </summary>
                        [Obsolete("Deprecated and no longer needed if you use the descriptor")]
                        public ComponentExtensions extensions;
                    }

                    [External]
                    [ObjectLiteral]
                    public partial class ComponentDependencies
                    {
                        /// <summary>
                        /// Path to the libraries that should be loaded by SAPUI5 core to be used in your component
                        /// </summary>
                        public string[] libs;

                        /// <summary>
                        /// Full path to the components that should be loaded by SAPUI5 core to be used in your component
                        /// </summary>
                        public string[] components;

                        /// <summary>
                        /// Minimum version of SAPUI5 that the component requires; it helps to be ensure that the features of SAPUI5 runtime used in this component are available.As SAPUI5 currently does not enforce the use of the correct version, it is only used for information purposes.
                        /// </summary>
                        public string ui5version;
                    }

                    [External]
                    [ObjectLiteral]
                    public partial class ComponentExtensions
                    {
                        /// <summary>
                        /// Used for providing custom view content in a specified extension point in the standard application
                        /// </summary>
                        [Name("sap.ui.viewExtensions")]
                        public Map<Map<ViewExtension>> sap_ui_viewExtensions;

                        /// <summary>
                        /// Used for overriding control properties in the standard application
                        /// </summary>
                        [Name("sap.ui.viewModifications")]
                        public Map<Map<ViewModification>> sap_ui_viewModifications;

                        /// <summary>
                        /// Used for replacing a standard view with a custom view
                        /// </summary>
                        [Name("sap.ui.viewReplacement")]
                        public Map<ViewReplacement> sap_ui_viewReplacement;

                        /// <summary>
                        /// Used for extending a controller in a delivered standard application with a custom controller
                        /// </summary>
                        [Name("sap.ui.controllerExtensions")]
                        public Map<Map<ControllerExtension>> sap_ui_controllerExtensions;

                        /// <summary>
                        /// Used for replacing a controller in a delivered standard application with a custom controller
                        /// </summary>
                        [Name("sap.ui.controllerReplacements")]
                        public Map<string> sap_ui_Replacements;
                    }

                    [External]
                    [ObjectLiteral]
                    public partial class ViewExtension
                    {
                        public string className;
                        public string viewName;
                        public string fragmentName;
                        public string type;
                        public sap.ui.core.ID id;
                    }

                    [External]
                    [ObjectLiteral]
                    public partial class ViewModification
                    {
                        public bool visible;
                    }

                    [External]
                    [ObjectLiteral]
                    public partial class ViewReplacement
                    {
                        public string viewName;
                        public string type;
                    }

                    [External]
                    [ObjectLiteral]
                    public partial class ControllerExtension
                    {
                        public string controllerName;
                    }
                }

                [External]
                public abstract partial class UIComponent
                {
                    [External]
                    [ObjectLiteral]
                    public partial class Metadata : sap.ui.core.Component.Metadata
                    {
                        /// <summary>
                        /// Can be the view name as string or the view configuration object
                        /// </summary>
                        [Obsolete("Deprecated and no longer needed if you use the descriptor")]
                        public Union<string, sap.ui.ViewInfo> rootView;

                        /// <summary>
                        /// Provides the default values for all views
                        /// </summary>
                        [Obsolete("Deprecated and no longer needed if you use the descriptor")]
                        public ComponentRouting routing;
                    }

                    [External]
                    [ObjectLiteral]
                    public partial class ComponentRouting
                    {
                        /// <summary>
                        /// Default values for routing that are applied, if no setting is specified by a route
                        /// </summary>
                        public ComponentRouterConfig config;

                        /// <summary>
                        /// Contains the configuration objects
                        /// </summary>
                        public sap.ui.core.routing.Route.RouteConfig[] routes;

                        // TODO: the type is sap.ui.core.routing.Targets.TargetsInfo. but we should let sap.m.routing.Targets.TargetsInfo inherit from it
                        /// <summary>
                        /// One or multiple targets in a map.
                        /// </summary>
                        public Map<sap.ui.core.routing.Targets.TargetInfo> targets;
                    }

                    [External]
                    [ObjectLiteral]
                    public partial class ComponentRouterConfig : sap.m.routing.Router.RouterConfig
                    {
                        /// <summary>
                        /// The namespace of the router that is used in the component
                        /// </summary>
                        public string routerClass;

                        /// <summary>
                        /// bypassed section of the config
                        /// </summary>
                        public RoutesBypassed bypassed;
                    }

                    [External]
                    [ObjectLiteral]
                    public class RoutesBypassed
                    {
                        /// <summary>
                        /// One or multiple names of targets that will be displayed, if no route of the router is matched.
                        /// </summary>
                        public string target;
                    }
                }
            }
        }
    }
}