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
			public static partial class core
			{
				/// <summary>
				/// Base Class for XMLComposite controls.
				/// </summary>
				[External]
				[Namespace(false)]
				public abstract partial class XMLComposite : sap.ui.core.Control
				{
					#region Settings

					/// <summary>
					/// Settings class to create the object
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class Settings : sap.ui.core.Control.Settings
					{
						/// <summary>
						/// The width
						/// </summary>
						public Union<sap.ui.core.CSSSize, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> width;

						/// <summary>
						/// The height
						/// </summary>
						public Union<sap.ui.core.CSSSize, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> height;

						/// <summary>
						/// Whether the CSS display should be set to "block".
						/// </summary>
						public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> displayBlock;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// XMLComposite is the base class for composite controls that use a XML fragment representation for their visual parts. From a user perspective such controls appear as any other control, but internally the rendering part is added as a fragment. The fragment that is used should appear in the same folder as the control's JS implementation with the file extension <code>.control.xml</code>. The fragment's content can access the interface data from the XMLComposite control via bindings. Currently only aggregations and properties can be used with bindings inside a fragment. The exposed model that is used for internal bindings in the fragment has the default name <code>$this</code>. The name will always start with an <code>$</code>. The metadata of the derived control can define the alias with its metadata. A code example can be found below.
					/// 
					/// As XMLComposites compose other controls, they are only invalidated and re-rendered if explicitly defined. Additional metadata for invalidation can be given for properties and aggregation. The default invalidation is <code>"none"</code>. Setting invalidate to <code>true</code> for properties and aggregations sets the complete XMLComposite to invalidate and rerender. For templating scenarios the XMLComposite can also be forced to re-template completely. In such case set invalidate of the corresponding property to <code>"template"</code>
					/// 
					/// Example: <pre>
					/// XMLComposite.extend("sap.mylib.MyXMLComposite", {
					///   metadata : {
					///     library: "sap.mylib",
					///     properties : {
					///       text: { //changing this property will not re-render the XMLComposite
					///          type: "string",
					///          defaultValue: ""
					///       },
					///       title: { //changing this property will re-render the XMLComposite as it defines invalidate: true
					///          type: "string",
					///          defaultValue: "",
					///          invalidate: true
					///       },
					///       value: { //changing this property will re-render the XMLComposite as it defines invalidate: true
					///          type: "string",
					///          defaultValue: "",
					///          invalidate: true
					///       },
					///       progress: { //changing this property will re-template the XMLComposite as it defines invalidate: true
					///          type: "int",
					///          defaultValue: "",
					///          invalidate: "template"
					///       }
					///     },
					///     defaultProperty : "text",
					///     aggregations : {
					///       items : {
					///          type: "sap.ui.core.Control",
					///          invalidate: true
					///       },
					///       header : {
					///          type: "sap.mylib.FancyHeader",
					///          multiple : false
					///       }
					///     },
					///     defaultAggregation : "items"
					///     events: {
					///       outerEvent : {
					///         parameters : {
					///           opener : "sap.ui.core.Control"
					///         }
					///       }
					///     }
					///   },
					///   //alias defaults to "this"
					///   alias: "mycontrolroot" //inner bindings will use model name $mycontrolroot
					///   //fragment defaults to {control name}.control.xml in this case sap.mylib.MyXMLComposite.control.xml
					///   fragment: "sap.mylib.MyXMLCompositeOther.control.xml" //the name of the fragment
					/// });
					/// </pre>
					/// 
					/// Internally the XMLComposite instantiates and initializes the given fragment and stores the resulting control in a hidden aggregation named <code>_content</code>. The fragment should only include one root element.
					/// 
					/// Bindings of inner controls to the interface of the XMLComposite can be done with normal binding syntax. Here properties are used as property bindings and aggregations are used as list bindings. Currently it is not possible to bind associations in a fragment.
					/// 
					/// Example: <pre>
					///    &lt;core:FragmentDefinition xmlns:m="sap.m" xmlns:core="sap.ui.core"&gt;
					///       &lt;m:Text text="{$this&gt;text}" visible="{= ${$this&gt;text} !== ""}" /&gt;
					///    &lt;/core:FragmentDefinition&gt;
					/// </pre> <pre>
					///    &lt;core:FragmentDefinition xmlns:m="sap.m" xmlns:core="sap.ui.core"&gt;
					///       &lt;m:VBox items="{path:"$this&gt;texts", filters:{path:"text", operator:"Contains", value1:"Text"}, sorter:{path:"text", descending:true}}"&gt;
					///           &lt;m:Text text="{$this&gt;text}" /&gt;
					///       &lt;/m:VBox&gt;
					///    &lt;/core:FragmentDefinition&gt;
					/// </pre> <pre>
					///    &lt;core:FragmentDefinition xmlns:m="sap.m" xmlns:core="sap.ui.core"&gt;
					///       &lt;m:Button text="Press Me" press="handlePress"/&gt;
					///    &lt;/core:FragmentDefinition&gt;
					/// </pre>
					/// 
					/// All events handled within the fragment will be dispatched to the XMLComposite control. It is recommended to follow this paradigm to allow reuse of a XMLComposite without any dependency to controller code of the current embedding view.
					/// 
					/// <pre>
					///    MyXMLComposite.prototype.handlePress = function() {
					///        this.fireOuterEvent(); // passing on the event to the outer view
					///    }
					/// </pre>
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern XMLComposite();

					#endregion

					#region Methods

					#region Methods for Property width

					/// <summary>
					/// Gets current value of property {@link #getWidth width}.
					/// 
					/// The width
					/// 
					/// Default value is <code>100%</code>.
					/// </summary>
					/// <returns>Value of property <code>width</code></returns>
					public extern virtual sap.ui.core.CSSSize getWidth();

					/// <summary>
					/// Sets a new value for property {@link #getWidth width}.
					/// 
					/// The width
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>100%</code>.
					/// </summary>
					/// <param name="sWidth">New value for property <code>width</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.XMLComposite setWidth(sap.ui.core.CSSSize sWidth);

					#endregion

					#region Methods for Property height

					/// <summary>
					/// Gets current value of property {@link #getHeight height}.
					/// 
					/// The height
					/// </summary>
					/// <returns>Value of property <code>height</code></returns>
					public extern virtual sap.ui.core.CSSSize getHeight();

					/// <summary>
					/// Sets a new value for property {@link #getHeight height}.
					/// 
					/// The height
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sHeight">New value for property <code>height</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.XMLComposite setHeight(sap.ui.core.CSSSize sHeight);

					#endregion

					#region Methods for Property displayBlock

					/// <summary>
					/// Gets current value of property {@link #getDisplayBlock displayBlock}.
					/// 
					/// Whether the CSS display should be set to "block".
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>displayBlock</code></returns>
					public extern virtual bool getDisplayBlock();

					/// <summary>
					/// Sets a new value for property {@link #getDisplayBlock displayBlock}.
					/// 
					/// Whether the CSS display should be set to "block".
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bDisplayBlock">New value for property <code>displayBlock</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.XMLComposite setDisplayBlock(bool bDisplayBlock);

					#endregion

					#region Methods for Aggregation _content

					#endregion

					#region Other methods

					/// <summary>
					/// Returns an element by its ID in the context of the XMLComposite.
					/// 
					/// May only be used by the implementation of a specific XMLComposite, not by an application using a XMLComposite.
					/// </summary>
					/// <param name="sId">XMLComposite-local ID of the inner element</param>
					/// <returns>element by its ID or <code>undefined</code></returns>
					public extern virtual sap.ui.core.Element byId(string sId);

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.XMLComposite with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.XMLComposite with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.XMLComposite with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.core.XMLComposite.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					#endregion

					#endregion

				}
			}
		}
	}
}
