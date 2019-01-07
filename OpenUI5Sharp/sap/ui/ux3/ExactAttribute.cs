using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public static partial class sap
	{
		public static partial class ui
		{
			public static partial class ux3
			{
				/// <summary>
				/// An element for defining attributes and sub-attributes used within the Exact pattern.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.ux3.ExactAttribute")]
				[Obsolete("Deprecated since 1.38.")]
				public partial class ExactAttribute : sap.ui.core.Element
				{
					#region Settings

					/// <summary>
					/// Settings class to create the object
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class Settings : sap.ui.core.Element.Settings
					{
						/// <summary>
						/// The attribute name
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> text;

						/// <summary>
						/// Specifies whether the attribute shall be selected
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> selected;

						/// <summary>
						/// Specifies the width of the corresponding list in pixels. The value must be between 70 and 500.
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> width;

						/// <summary>
						/// The order how the sublists of this attribute should be displayed.
						/// </summary>
						public Union<sap.ui.ux3.ExactOrder, string, sap.ui.@base.ManagedObject.BindPropertyInfo> listOrder;

						/// <summary>
						/// Specifies whether the attribute shall have sub values for visual purposes. The indicator which is a little arrow beside an attribute in the list is computed automatically (getShowSubAttributesIndicator_Computed() of sap.ui.ux3.ExactAttribute). In the case that a supply function is attached, and the supplyActive attribute has value 'true', then the Exact pattern needs a hint if sub attributes are available. The showSubAttributesIndicator attribute is considered then and has to be maintained. If the back-end does not support count-calls, for example, showSubAttributesIndicator should be set to true.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showSubAttributesIndicator;

						/// <summary>
						/// An example for additional data are database keys
						/// </summary>
						public Union<object, string, sap.ui.@base.ManagedObject.BindPropertyInfo> additionalData;

						/// <summary>
						/// The supplyAttributes event is only fired if supplyActive has value true which is the default. After firing the event, the attribute is automatically set to false. The idea is that a supply function is called only once when the data is requested. To enable the event again it is possible to manually set the attribute back to true.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> supplyActive;

						/// <summary>
						/// If you want the supply function to be called on every select, you can set the autoActivateSupply attribute to true. In this case, supplyActive is automatically set to true on every unselect.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> autoActivateSupply;

						/// <summary>
						/// Values (sub attributes) of this attribute
						/// </summary>
						public Union<sap.ui.ux3.ExactAttribute[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> attributes;

						/// <summary>
						/// A supply function is a handler which is attached to the supplyAttributes event. The event is fired when the corresponding ExactAttribute is selected, it was already selected when a handler is attached or function getAttributes() is called.
						/// </summary>
						public sap.ui.ux3.ExactAttribute.SupplyAttributesDelegate supplyAttributes;

					}

					#endregion

					#region Typed Parameters

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class SupplyAttributesInfo
					{
						/// <summary>
						/// The ExactAttribute
						/// </summary>
						public sap.ui.ux3.ExactAttribute attribute;

					}

					#endregion

					#region Delegates

					public delegate void SupplyAttributesDelegate(sap.ui.@base.Event<sap.ui.ux3.ExactAttribute.SupplyAttributesInfo> oEvent, object oData);

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new ExactAttribute.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern ExactAttribute(string sId, sap.ui.ux3.ExactAttribute.Settings mSettings);

					/// <summary>
					/// Constructor for a new ExactAttribute.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern ExactAttribute(string sId);

					/// <summary>
					/// Constructor for a new ExactAttribute.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern ExactAttribute();

					/// <summary>
					/// Constructor for a new ExactAttribute.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern ExactAttribute(sap.ui.ux3.ExactAttribute.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property text

					/// <summary>
					/// Gets current value of property {@link #getText text}.
					/// 
					/// The attribute name
					/// </summary>
					/// <returns>Value of property <code>text</code></returns>
					public extern virtual string getText();

					/// <summary>
					/// Sets a new value for property {@link #getText text}.
					/// 
					/// The attribute name
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sText">New value for property <code>text</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ExactAttribute setText(string sText);

					#endregion

					#region Methods for Property selected

					/// <summary>
					/// Gets current value of property {@link #getSelected selected}.
					/// 
					/// Specifies whether the attribute shall be selected
					/// </summary>
					/// <returns>Value of property <code>selected</code></returns>
					public extern virtual bool getSelected();

					/// <summary>
					/// Sets a new value for property {@link #getSelected selected}.
					/// 
					/// Specifies whether the attribute shall be selected
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="bSelected">New value for property <code>selected</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ExactAttribute setSelected(bool bSelected);

					#endregion

					#region Methods for Property width

					/// <summary>
					/// Gets current value of property {@link #getWidth width}.
					/// 
					/// Specifies the width of the corresponding list in pixels. The value must be between 70 and 500.
					/// 
					/// Default value is <code>168</code>.
					/// </summary>
					/// <returns>Value of property <code>width</code></returns>
					public extern virtual int getWidth();

					/// <summary>
					/// Sets a new value for property {@link #getWidth width}.
					/// 
					/// Specifies the width of the corresponding list in pixels. The value must be between 70 and 500.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>168</code>.
					/// </summary>
					/// <param name="iWidth">New value for property <code>width</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ExactAttribute setWidth(int iWidth);

					#endregion

					#region Methods for Property listOrder

					/// <summary>
					/// Gets current value of property {@link #getListOrder listOrder}.
					/// 
					/// The order how the sublists of this attribute should be displayed.
					/// 
					/// Default value is <code>Select</code>.
					/// </summary>
					/// <returns>Value of property <code>listOrder</code></returns>
					public extern virtual sap.ui.ux3.ExactOrder getListOrder();

					/// <summary>
					/// Sets a new value for property {@link #getListOrder listOrder}.
					/// 
					/// The order how the sublists of this attribute should be displayed.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>Select</code>.
					/// </summary>
					/// <param name="sListOrder">New value for property <code>listOrder</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ExactAttribute setListOrder(sap.ui.ux3.ExactOrder sListOrder);

					#endregion

					#region Methods for Property showSubAttributesIndicator

					/// <summary>
					/// Gets current value of property {@link #getShowSubAttributesIndicator showSubAttributesIndicator}.
					/// 
					/// Specifies whether the attribute shall have sub values for visual purposes. The indicator which is a little arrow beside an attribute in the list is computed automatically (getShowSubAttributesIndicator_Computed() of sap.ui.ux3.ExactAttribute). In the case that a supply function is attached, and the supplyActive attribute has value 'true', then the Exact pattern needs a hint if sub attributes are available. The showSubAttributesIndicator attribute is considered then and has to be maintained. If the back-end does not support count-calls, for example, showSubAttributesIndicator should be set to true.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>showSubAttributesIndicator</code></returns>
					public extern virtual bool getShowSubAttributesIndicator();

					/// <summary>
					/// Sets a new value for property {@link #getShowSubAttributesIndicator showSubAttributesIndicator}.
					/// 
					/// Specifies whether the attribute shall have sub values for visual purposes. The indicator which is a little arrow beside an attribute in the list is computed automatically (getShowSubAttributesIndicator_Computed() of sap.ui.ux3.ExactAttribute). In the case that a supply function is attached, and the supplyActive attribute has value 'true', then the Exact pattern needs a hint if sub attributes are available. The showSubAttributesIndicator attribute is considered then and has to be maintained. If the back-end does not support count-calls, for example, showSubAttributesIndicator should be set to true.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bShowSubAttributesIndicator">New value for property <code>showSubAttributesIndicator</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ExactAttribute setShowSubAttributesIndicator(bool bShowSubAttributesIndicator);

					#endregion

					#region Methods for Property additionalData

					/// <summary>
					/// Gets current value of property {@link #getAdditionalData additionalData}.
					/// 
					/// An example for additional data are database keys
					/// </summary>
					/// <returns>Value of property <code>additionalData</code></returns>
					public extern virtual object getAdditionalData();

					/// <summary>
					/// Sets a new value for property {@link #getAdditionalData additionalData}.
					/// 
					/// An example for additional data are database keys
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="oAdditionalData">New value for property <code>additionalData</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ExactAttribute setAdditionalData(object oAdditionalData);

					#endregion

					#region Methods for Property supplyActive

					/// <summary>
					/// Gets current value of property {@link #getSupplyActive supplyActive}.
					/// 
					/// The supplyAttributes event is only fired if supplyActive has value true which is the default. After firing the event, the attribute is automatically set to false. The idea is that a supply function is called only once when the data is requested. To enable the event again it is possible to manually set the attribute back to true.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>supplyActive</code></returns>
					public extern virtual bool getSupplyActive();

					/// <summary>
					/// Sets a new value for property {@link #getSupplyActive supplyActive}.
					/// 
					/// The supplyAttributes event is only fired if supplyActive has value true which is the default. After firing the event, the attribute is automatically set to false. The idea is that a supply function is called only once when the data is requested. To enable the event again it is possible to manually set the attribute back to true.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bSupplyActive">New value for property <code>supplyActive</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ExactAttribute setSupplyActive(bool bSupplyActive);

					#endregion

					#region Methods for Property autoActivateSupply

					/// <summary>
					/// Gets current value of property {@link #getAutoActivateSupply autoActivateSupply}.
					/// 
					/// If you want the supply function to be called on every select, you can set the autoActivateSupply attribute to true. In this case, supplyActive is automatically set to true on every unselect.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>autoActivateSupply</code></returns>
					public extern virtual bool getAutoActivateSupply();

					/// <summary>
					/// Sets a new value for property {@link #getAutoActivateSupply autoActivateSupply}.
					/// 
					/// If you want the supply function to be called on every select, you can set the autoActivateSupply attribute to true. In this case, supplyActive is automatically set to true on every unselect.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bAutoActivateSupply">New value for property <code>autoActivateSupply</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ExactAttribute setAutoActivateSupply(bool bAutoActivateSupply);

					#endregion

					#region Methods for Aggregation attributes

					/// <summary>
					/// Gets content of aggregation {@link #getAttributes attributes}.
					/// 
					/// Values (sub attributes) of this attribute
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.ux3.ExactAttribute[] getAttributes();

					/// <summary>
					/// Destroys all the attributes in the aggregation {@link #getAttributes attributes}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ExactAttribute destroyAttributes();

					/// <summary>
					/// Inserts a attribute into the aggregation {@link #getAttributes attributes}.
					/// </summary>
					/// <param name="oAttribute">The attribute to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the attribute should be inserted at; for a negative value of <code>iIndex</code>, the attribute is inserted at position 0; for a value greater than the current size of the aggregation, the attribute is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ExactAttribute insertAttribute(sap.ui.ux3.ExactAttribute oAttribute, int iIndex);

					/// <summary>
					/// Adds some attribute to the aggregation {@link #getAttributes attributes}.
					/// </summary>
					/// <param name="oAttribute">The attribute to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ExactAttribute addAttribute(sap.ui.ux3.ExactAttribute oAttribute);

					/// <summary>
					/// Removes a attribute from the aggregation {@link #getAttributes attributes}.
					/// </summary>
					/// <param name="vAttribute">The attribute to remove or its index or id</param>
					/// <returns>The removed attribute or <code>null</code></returns>
					public extern virtual sap.ui.ux3.ExactAttribute removeAttribute(Union<int, string, sap.ui.ux3.ExactAttribute> vAttribute);

					/// <summary>
					/// Checks for the provided <code>sap.ui.ux3.ExactAttribute</code> in the aggregation {@link #getAttributes attributes}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oAttribute">The attribute whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfAttribute(sap.ui.ux3.ExactAttribute oAttribute);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getAttributes attributes}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.ux3.ExactAttribute[] removeAllAttributes();

					#endregion

					#region Methods for Event supplyAttributes

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:supplyAttributes supplyAttributes} event of this <code>sap.ui.ux3.ExactAttribute</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.ExactAttribute</code> itself.
					/// 
					/// A supply function is a handler which is attached to the supplyAttributes event. The event is fired when the corresponding ExactAttribute is selected, it was already selected when a handler is attached or function getAttributes() is called.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.ExactAttribute</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ExactAttribute attachSupplyAttributes(object oData, sap.ui.ux3.ExactAttribute.SupplyAttributesDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:supplyAttributes supplyAttributes} event of this <code>sap.ui.ux3.ExactAttribute</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.ExactAttribute</code> itself.
					/// 
					/// A supply function is a handler which is attached to the supplyAttributes event. The event is fired when the corresponding ExactAttribute is selected, it was already selected when a handler is attached or function getAttributes() is called.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ExactAttribute attachSupplyAttributes(object oData, sap.ui.ux3.ExactAttribute.SupplyAttributesDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:supplyAttributes supplyAttributes} event of this <code>sap.ui.ux3.ExactAttribute</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.ExactAttribute</code> itself.
					/// 
					/// A supply function is a handler which is attached to the supplyAttributes event. The event is fired when the corresponding ExactAttribute is selected, it was already selected when a handler is attached or function getAttributes() is called.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ExactAttribute attachSupplyAttributes(sap.ui.ux3.ExactAttribute.SupplyAttributesDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:supplyAttributes supplyAttributes} event of this <code>sap.ui.ux3.ExactAttribute</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.ExactAttribute</code> itself.
					/// 
					/// A supply function is a handler which is attached to the supplyAttributes event. The event is fired when the corresponding ExactAttribute is selected, it was already selected when a handler is attached or function getAttributes() is called.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.ExactAttribute</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ExactAttribute attachSupplyAttributes(sap.ui.ux3.ExactAttribute.SupplyAttributesDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:supplyAttributes supplyAttributes} event of this <code>sap.ui.ux3.ExactAttribute</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ExactAttribute detachSupplyAttributes(sap.ui.ux3.ExactAttribute.SupplyAttributesDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:supplyAttributes supplyAttributes} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ExactAttribute fireSupplyAttributes(sap.ui.ux3.ExactAttribute.SupplyAttributesInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:supplyAttributes supplyAttributes} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ExactAttribute fireSupplyAttributes();

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.ux3.ExactAttribute with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.ux3.ExactAttribute with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.ux3.ExactAttribute with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.ux3.ExactAttribute.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					[Name("getMetadata")]
					public extern static sap.ui.@base.Metadata getMetadataStatic();

					/// <summary>
					/// See attribute showSubAttributesIndicator
					/// </summary>
					public extern virtual void getShowSubAttributesIndicator_Computed();

					/// <summary>
					/// Scrolls the corresponding list of this attribute until the given direct child attribute is visible. If the corresponding list is not yet visible the call is buffered until the list is available.
					/// </summary>
					/// <param name="oOAttribute">The direct child attribute</param>
					public extern virtual void scrollTo(sap.ui.ux3.ExactAttribute oOAttribute);

					/// <param name="sPropertyName"></param>
					/// <param name="oValue"></param>
					/// <param name="bSuppressRerendering"></param>
					public extern virtual void setProperty(string sPropertyName, object oValue, bool bSuppressRerendering);

					/// <param name="oTooltip"></param>
					public extern virtual void setTooltip(Union<string, sap.ui.core.TooltipBase> oTooltip);

					#endregion

					#endregion

				}
			}
		}
	}
}
