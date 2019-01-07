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
				public static partial class tmpl
				{
					/// <summary>
					/// Represents a DOM element. It allows to use databinding for the properties and nested DOM attributes.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.core.tmpl.DOMElement")]
					[Obsolete("Deprecated since 1.56.")]
					public partial class DOMElement : sap.ui.core.Control
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
							/// The text content of the DOM element
							/// </summary>
							public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> text;

							/// <summary>
							/// The HTML-tag of the DOM element which contains the text
							/// </summary>
							public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> tag;

							/// <summary>
							/// DOM attributes which are rendered as part of the DOM element and bindable
							/// </summary>
							public Union<sap.ui.core.tmpl.DOMAttribute[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> attributes;

							/// <summary>
							/// Nested DOM elements to support nested bindable structures
							/// </summary>
							public Union<sap.ui.core.tmpl.DOMElement[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> elements;

						}

						#endregion

						#region Constructor

						/// <summary>
						/// Constructor for a new tmpl/DOMElement.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">id for the new control, generated automatically if no id is given</param>
						/// <param name="mSettings">initial settings for the new control</param>
						public extern DOMElement(string sId, sap.ui.core.tmpl.DOMElement.Settings mSettings);

						/// <summary>
						/// Constructor for a new tmpl/DOMElement.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">id for the new control, generated automatically if no id is given</param>
						public extern DOMElement(string sId);

						/// <summary>
						/// Constructor for a new tmpl/DOMElement.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						public extern DOMElement();

						/// <summary>
						/// Constructor for a new tmpl/DOMElement.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="mSettings">initial settings for the new control</param>
						public extern DOMElement(sap.ui.core.tmpl.DOMElement.Settings mSettings);

						#endregion

						#region Methods

						#region Methods for Property text

						/// <summary>
						/// Gets current value of property {@link #getText text}.
						/// 
						/// The text content of the DOM element
						/// </summary>
						/// <returns>Value of property <code>text</code></returns>
						public extern virtual string getText();

						/// <summary>
						/// Sets a new value for property {@link #getText text}.
						/// 
						/// The text content of the DOM element
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// </summary>
						/// <param name="sText">New value for property <code>text</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.tmpl.DOMElement setText(string sText);

						#endregion

						#region Methods for Property tag

						/// <summary>
						/// Gets current value of property {@link #getTag tag}.
						/// 
						/// The HTML-tag of the DOM element which contains the text
						/// 
						/// Default value is <code>span</code>.
						/// </summary>
						/// <returns>Value of property <code>tag</code></returns>
						public extern virtual string getTag();

						/// <summary>
						/// Sets a new value for property {@link #getTag tag}.
						/// 
						/// The HTML-tag of the DOM element which contains the text
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>span</code>.
						/// </summary>
						/// <param name="sTag">New value for property <code>tag</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.tmpl.DOMElement setTag(string sTag);

						#endregion

						#region Methods for Aggregation attributes

						/// <summary>
						/// Gets content of aggregation {@link #getAttributes attributes}.
						/// 
						/// DOM attributes which are rendered as part of the DOM element and bindable
						/// </summary>
						/// <returns></returns>
						public extern virtual sap.ui.core.tmpl.DOMAttribute[] getAttributes();

						/// <summary>
						/// Destroys all the attributes in the aggregation {@link #getAttributes attributes}.
						/// </summary>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.tmpl.DOMElement destroyAttributes();

						/// <summary>
						/// Inserts a attribute into the aggregation {@link #getAttributes attributes}.
						/// </summary>
						/// <param name="oAttribute">The attribute to insert; if empty, nothing is inserted</param>
						/// <param name="iIndex">The <code>0</code>-based index the attribute should be inserted at; for a negative value of <code>iIndex</code>, the attribute is inserted at position 0; for a value greater than the current size of the aggregation, the attribute is inserted at the last position</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.tmpl.DOMElement insertAttribute(sap.ui.core.tmpl.DOMAttribute oAttribute, int iIndex);

						/// <summary>
						/// Adds some attribute to the aggregation {@link #getAttributes attributes}.
						/// </summary>
						/// <param name="oAttribute">The attribute to add; if empty, nothing is inserted</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.tmpl.DOMElement addAttribute(sap.ui.core.tmpl.DOMAttribute oAttribute);

						/// <summary>
						/// Removes a attribute from the aggregation {@link #getAttributes attributes}.
						/// </summary>
						/// <param name="vAttribute">The attribute to remove or its index or id</param>
						/// <returns>The removed attribute or <code>null</code></returns>
						public extern virtual sap.ui.core.tmpl.DOMAttribute removeAttribute(Union<int, string, sap.ui.core.tmpl.DOMAttribute> vAttribute);

						/// <summary>
						/// Checks for the provided <code>sap.ui.core.tmpl.DOMAttribute</code> in the aggregation {@link #getAttributes attributes}. and returns its index if found or -1 otherwise.
						/// </summary>
						/// <param name="oAttribute">The attribute whose index is looked for</param>
						/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
						public extern virtual int indexOfAttribute(sap.ui.core.tmpl.DOMAttribute oAttribute);

						/// <summary>
						/// Removes all the controls from the aggregation {@link #getAttributes attributes}.
						/// 
						/// Additionally, it unregisters them from the hosting UIArea.
						/// </summary>
						/// <returns>An array of the removed elements (might be empty)</returns>
						public extern virtual sap.ui.core.tmpl.DOMAttribute[] removeAllAttributes();

						#endregion

						#region Methods for Aggregation elements

						/// <summary>
						/// Gets content of aggregation {@link #getElements elements}.
						/// 
						/// Nested DOM elements to support nested bindable structures
						/// </summary>
						/// <returns></returns>
						public extern virtual sap.ui.core.tmpl.DOMElement[] getElements();

						/// <summary>
						/// Destroys all the elements in the aggregation {@link #getElements elements}.
						/// </summary>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.tmpl.DOMElement destroyElements();

						/// <summary>
						/// Inserts a element into the aggregation {@link #getElements elements}.
						/// </summary>
						/// <param name="oElement">The element to insert; if empty, nothing is inserted</param>
						/// <param name="iIndex">The <code>0</code>-based index the element should be inserted at; for a negative value of <code>iIndex</code>, the element is inserted at position 0; for a value greater than the current size of the aggregation, the element is inserted at the last position</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.tmpl.DOMElement insertElement(sap.ui.core.tmpl.DOMElement oElement, int iIndex);

						/// <summary>
						/// Adds some element to the aggregation {@link #getElements elements}.
						/// </summary>
						/// <param name="oElement">The element to add; if empty, nothing is inserted</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.tmpl.DOMElement addElement(sap.ui.core.tmpl.DOMElement oElement);

						/// <summary>
						/// Removes a element from the aggregation {@link #getElements elements}.
						/// </summary>
						/// <param name="vElement">The element to remove or its index or id</param>
						/// <returns>The removed element or <code>null</code></returns>
						public extern virtual sap.ui.core.tmpl.DOMElement removeElement(Union<int, string, sap.ui.core.tmpl.DOMElement> vElement);

						/// <summary>
						/// Checks for the provided <code>sap.ui.core.tmpl.DOMElement</code> in the aggregation {@link #getElements elements}. and returns its index if found or -1 otherwise.
						/// </summary>
						/// <param name="oElement">The element whose index is looked for</param>
						/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
						public extern virtual int indexOfElement(sap.ui.core.tmpl.DOMElement oElement);

						/// <summary>
						/// Removes all the controls from the aggregation {@link #getElements elements}.
						/// 
						/// Additionally, it unregisters them from the hosting UIArea.
						/// </summary>
						/// <returns>An array of the removed elements (might be empty)</returns>
						public extern virtual sap.ui.core.tmpl.DOMElement[] removeAllElements();

						#endregion

						#region Other methods

						/// <summary>
						/// Returns the value of a DOM attribute if available or undefined if the DOM attribute is not available when using this method with the parameter name only. When using the method with the parameter name and value the method acts as a setter and sets the value of a DOM attribute. In this case the return value is the reference to this DOM element to support method chaining. If you pass null as value of the attribute the attribute will be removed.
						/// </summary>
						/// <param name="sName">The name of the DOM attribute.</param>
						/// <param name="sValue">The value of the DOM attribute. If the value is undefined the DOM attribute will be removed.</param>
						/// <returns>value of attribute or <code>this</code> when called as a setter</returns>
						public extern virtual object attr(string sName, string sValue);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.tmpl.DOMElement with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.tmpl.DOMElement with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.tmpl.DOMElement with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns a metadata object for class sap.ui.core.tmpl.DOMElement.
						/// </summary>
						/// <returns>Metadata object describing this class</returns>
						[Name("getMetadata")]
						public extern static sap.ui.@base.Metadata getMetadataStatic();

						/// <summary>
						/// Removes the DOM attribute for the given name and returns the reference to this DOM element to support method chaining.
						/// </summary>
						/// <param name="sName">The name of the DOM attribute.</param>
						/// <returns></returns>
						public extern virtual sap.ui.core.tmpl.DOMElement removeAttr(string sName);

						#endregion

						#endregion

					}
				}
			}
		}
	}
}
