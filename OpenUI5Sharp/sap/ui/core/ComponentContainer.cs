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
				/// Container that embeds a UIComponent in a control tree.
				/// </summary>
				[External]
				[Namespace(false)]
				public partial class ComponentContainer : sap.ui.core.Control
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
						/// Component name, the package where the component is contained. This property can only be applied initially.
						/// </summary>
						public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> name;

						/// <summary>
						/// The URL of the component. This property can only be applied initially.
						/// </summary>
						public Union<sap.ui.core.URI, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> url;

						/// <summary>
						/// Flag whether the component should be created sync (default) or async. The default will be async when initially the property <code>manifest</code> is set to a truthy value and for the property <code>async</code> no value has been specified. This property can only be applied initially.
						/// </summary>
						public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> async;

						/// <summary>
						/// Enable/disable validation handling by MessageManager for this component. The resulting Messages will be propagated to the controls. This property can only be applied initially.
						/// </summary>
						public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> handleValidation;

						/// <summary>
						/// The settings object passed to the component when created. This property can only be applied initially.
						/// </summary>
						public Union<object, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> settings;

						/// <summary>
						/// Defines whether binding information is propagated to the component.
						/// </summary>
						public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> propagateModel;

						/// <summary>
						/// Container width in CSS size
						/// </summary>
						public Union<sap.ui.core.CSSSize, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> width;

						/// <summary>
						/// Container height in CSS size
						/// </summary>
						public Union<sap.ui.core.CSSSize, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> height;

						/// <summary>
						/// Lifecycle behavior for the Component associated by the <code>ComponentContainer</code>. The default behavior is <code>Legacy</code>. This means that the <code>ComponentContainer</code> takes care that the Component is destroyed when the <code>ComponentContainer</code> is destroyed, but it is <b>not</b> destroyed when a new Component is associated. If you use the <code>usage</code> property to create the Component, the default behavior is <code>Container</code>. This means that the Component is destroyed when the <code>ComponentContainer</code> is destroyed or a new Component is associated. This property must only be applied before a component instance is created.
						/// </summary>
						public Union<sap.ui.core.ComponentLifecycle, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> lifecycle;

						/// <summary>
						/// Flag, whether to auto-prefix the ID of the nested Component or not. If this property is set to true the ID of the Component will be prefixed with the ID of the ComponentContainer followed by a single dash. This property can only be applied initially.
						/// </summary>
						public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> autoPrefixId;

						/// <summary>
						/// The component usage. If the ComponentContainer is used inside a Component, this Component can define a usage which will be used for creating the Component. This property can only be applied initially.
						/// </summary>
						public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> usage;

						/// <summary>
						/// Controls when and from where to load the manifest for the Component. When set to any truthy value, the manifest will be loaded asynchronously by default and evaluated before the Component controller, if it is set to a falsy value other than <code>undefined</code>, the manifest will be loaded after the controller. A non-empty string value will be interpreted as the URL location from where to load the manifest. A non-null object value will be interpreted as manifest content. This property can only be applied initially.
						/// </summary>
						public Union<object, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> manifest;

						/// <summary>
						/// The component displayed in this ComponentContainer.
						/// </summary>
						public Union<sap.ui.core.UIComponent, sap.ui.core.ID, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> component;

						/// <summary>
						/// Fired when the component instance has been created by the ComponentContainer.
						/// </summary>
						public sap.ui.core.ComponentContainer.ComponentCreatedDelegate componentCreated;

					}

					#endregion

					#region Typed Parameters

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class ComponentCreatedInfo
					{
						/// <summary>
						/// Reference to the created component instance
						/// </summary>
						public sap.ui.core.UIComponent component;

					}

					#endregion

					#region Delegates

					public delegate void ComponentCreatedDelegate(sap.ui.@base.Event<sap.ui.core.ComponentContainer.ComponentCreatedInfo> oEvent, object oData);

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new ComponentContainer.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern ComponentContainer(string sId, sap.ui.core.ComponentContainer.Settings mSettings);

					/// <summary>
					/// Constructor for a new ComponentContainer.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern ComponentContainer(string sId);

					/// <summary>
					/// Constructor for a new ComponentContainer.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern ComponentContainer();

					/// <summary>
					/// Constructor for a new ComponentContainer.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern ComponentContainer(sap.ui.core.ComponentContainer.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property name

					/// <summary>
					/// Gets current value of property {@link #getName name}.
					/// 
					/// Component name, the package where the component is contained. This property can only be applied initially.
					/// </summary>
					/// <returns>Value of property <code>name</code></returns>
					public extern virtual string getName();

					/// <summary>
					/// Sets a new value for property {@link #getName name}.
					/// 
					/// Component name, the package where the component is contained. This property can only be applied initially.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sName">New value for property <code>name</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.ComponentContainer setName(string sName);

					#endregion

					#region Methods for Property url

					/// <summary>
					/// Gets current value of property {@link #getUrl url}.
					/// 
					/// The URL of the component. This property can only be applied initially.
					/// </summary>
					/// <returns>Value of property <code>url</code></returns>
					public extern virtual sap.ui.core.URI getUrl();

					/// <summary>
					/// Sets a new value for property {@link #getUrl url}.
					/// 
					/// The URL of the component. This property can only be applied initially.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sUrl">New value for property <code>url</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.ComponentContainer setUrl(sap.ui.core.URI sUrl);

					#endregion

					#region Methods for Property async

					/// <summary>
					/// Gets current value of property {@link #getAsync async}.
					/// 
					/// Flag whether the component should be created sync (default) or async. The default will be async when initially the property <code>manifest</code> is set to a truthy value and for the property <code>async</code> no value has been specified. This property can only be applied initially.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>async</code></returns>
					public extern virtual bool getAsync();

					/// <summary>
					/// Sets a new value for property {@link #getAsync async}.
					/// 
					/// Flag whether the component should be created sync (default) or async. The default will be async when initially the property <code>manifest</code> is set to a truthy value and for the property <code>async</code> no value has been specified. This property can only be applied initially.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bAsync">New value for property <code>async</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.ComponentContainer setAsync(bool bAsync);

					#endregion

					#region Methods for Property handleValidation

					/// <summary>
					/// Gets current value of property {@link #getHandleValidation handleValidation}.
					/// 
					/// Enable/disable validation handling by MessageManager for this component. The resulting Messages will be propagated to the controls. This property can only be applied initially.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>handleValidation</code></returns>
					public extern virtual bool getHandleValidation();

					/// <summary>
					/// Sets a new value for property {@link #getHandleValidation handleValidation}.
					/// 
					/// Enable/disable validation handling by MessageManager for this component. The resulting Messages will be propagated to the controls. This property can only be applied initially.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bHandleValidation">New value for property <code>handleValidation</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.ComponentContainer setHandleValidation(bool bHandleValidation);

					#endregion

					#region Methods for Property settings

					/// <summary>
					/// Gets current value of property {@link #getSettings settings}.
					/// 
					/// The settings object passed to the component when created. This property can only be applied initially.
					/// </summary>
					/// <returns>Value of property <code>settings</code></returns>
					public extern virtual object getSettings();

					/// <summary>
					/// Sets a new value for property {@link #getSettings settings}.
					/// 
					/// The settings object passed to the component when created. This property can only be applied initially.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="oSettings">New value for property <code>settings</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.ComponentContainer setSettings(object oSettings);

					#endregion

					#region Methods for Property propagateModel

					/// <summary>
					/// Gets current value of property {@link #getPropagateModel propagateModel}.
					/// 
					/// Defines whether binding information is propagated to the component.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>propagateModel</code></returns>
					public extern virtual bool getPropagateModel();

					/// <summary>
					/// Sets a new value for property {@link #getPropagateModel propagateModel}.
					/// 
					/// Defines whether binding information is propagated to the component.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bPropagateModel">New value for property <code>propagateModel</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.ComponentContainer setPropagateModel(bool bPropagateModel);

					#endregion

					#region Methods for Property width

					/// <summary>
					/// Gets current value of property {@link #getWidth width}.
					/// 
					/// Container width in CSS size
					/// </summary>
					/// <returns>Value of property <code>width</code></returns>
					public extern virtual sap.ui.core.CSSSize getWidth();

					/// <summary>
					/// Sets a new value for property {@link #getWidth width}.
					/// 
					/// Container width in CSS size
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sWidth">New value for property <code>width</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.ComponentContainer setWidth(sap.ui.core.CSSSize sWidth);

					#endregion

					#region Methods for Property height

					/// <summary>
					/// Gets current value of property {@link #getHeight height}.
					/// 
					/// Container height in CSS size
					/// </summary>
					/// <returns>Value of property <code>height</code></returns>
					public extern virtual sap.ui.core.CSSSize getHeight();

					/// <summary>
					/// Sets a new value for property {@link #getHeight height}.
					/// 
					/// Container height in CSS size
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sHeight">New value for property <code>height</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.ComponentContainer setHeight(sap.ui.core.CSSSize sHeight);

					#endregion

					#region Methods for Property lifecycle

					/// <summary>
					/// Gets current value of property {@link #getLifecycle lifecycle}.
					/// 
					/// Lifecycle behavior for the Component associated by the <code>ComponentContainer</code>. The default behavior is <code>Legacy</code>. This means that the <code>ComponentContainer</code> takes care that the Component is destroyed when the <code>ComponentContainer</code> is destroyed, but it is <b>not</b> destroyed when a new Component is associated. If you use the <code>usage</code> property to create the Component, the default behavior is <code>Container</code>. This means that the Component is destroyed when the <code>ComponentContainer</code> is destroyed or a new Component is associated. This property must only be applied before a component instance is created.
					/// 
					/// Default value is <code>Legacy</code>.
					/// </summary>
					/// <returns>Value of property <code>lifecycle</code></returns>
					public extern virtual sap.ui.core.ComponentLifecycle getLifecycle();

					/// <summary>
					/// Sets a new value for property {@link #getLifecycle lifecycle}.
					/// 
					/// Lifecycle behavior for the Component associated by the <code>ComponentContainer</code>. The default behavior is <code>Legacy</code>. This means that the <code>ComponentContainer</code> takes care that the Component is destroyed when the <code>ComponentContainer</code> is destroyed, but it is <b>not</b> destroyed when a new Component is associated. If you use the <code>usage</code> property to create the Component, the default behavior is <code>Container</code>. This means that the Component is destroyed when the <code>ComponentContainer</code> is destroyed or a new Component is associated. This property must only be applied before a component instance is created.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>Legacy</code>.
					/// </summary>
					/// <param name="sLifecycle">New value for property <code>lifecycle</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.ComponentContainer setLifecycle(sap.ui.core.ComponentLifecycle sLifecycle);

					#endregion

					#region Methods for Property autoPrefixId

					/// <summary>
					/// Gets current value of property {@link #getAutoPrefixId autoPrefixId}.
					/// 
					/// Flag, whether to auto-prefix the ID of the nested Component or not. If this property is set to true the ID of the Component will be prefixed with the ID of the ComponentContainer followed by a single dash. This property can only be applied initially.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>autoPrefixId</code></returns>
					public extern virtual bool getAutoPrefixId();

					/// <summary>
					/// Sets a new value for property {@link #getAutoPrefixId autoPrefixId}.
					/// 
					/// Flag, whether to auto-prefix the ID of the nested Component or not. If this property is set to true the ID of the Component will be prefixed with the ID of the ComponentContainer followed by a single dash. This property can only be applied initially.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bAutoPrefixId">New value for property <code>autoPrefixId</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.ComponentContainer setAutoPrefixId(bool bAutoPrefixId);

					#endregion

					#region Methods for Property usage

					/// <summary>
					/// Gets current value of property {@link #getUsage usage}.
					/// 
					/// The component usage. If the ComponentContainer is used inside a Component, this Component can define a usage which will be used for creating the Component. This property can only be applied initially.
					/// </summary>
					/// <returns>Value of property <code>usage</code></returns>
					public extern virtual string getUsage();

					/// <summary>
					/// Sets a new value for property {@link #getUsage usage}.
					/// 
					/// The component usage. If the ComponentContainer is used inside a Component, this Component can define a usage which will be used for creating the Component. This property can only be applied initially.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sUsage">New value for property <code>usage</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.ComponentContainer setUsage(string sUsage);

					#endregion

					#region Methods for Property manifest

					/// <summary>
					/// Gets current value of property {@link #getManifest manifest}.
					/// 
					/// Controls when and from where to load the manifest for the Component. When set to any truthy value, the manifest will be loaded asynchronously by default and evaluated before the Component controller, if it is set to a falsy value other than <code>undefined</code>, the manifest will be loaded after the controller. A non-empty string value will be interpreted as the URL location from where to load the manifest. A non-null object value will be interpreted as manifest content. This property can only be applied initially.
					/// </summary>
					/// <returns>Value of property <code>manifest</code></returns>
					public extern virtual object getManifest();

					/// <summary>
					/// Sets a new value for property {@link #getManifest manifest}.
					/// 
					/// Controls when and from where to load the manifest for the Component. When set to any truthy value, the manifest will be loaded asynchronously by default and evaluated before the Component controller, if it is set to a falsy value other than <code>undefined</code>, the manifest will be loaded after the controller. A non-empty string value will be interpreted as the URL location from where to load the manifest. A non-null object value will be interpreted as manifest content. This property can only be applied initially.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="oManifest">New value for property <code>manifest</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.ComponentContainer setManifest(object oManifest);

					#endregion

					#region Methods for Association component

					/// <summary>
					/// ID of the element which is the current target of the association {@link #getComponent component}, or <code>null</code>.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.ID getComponent();

					/// <summary>
					/// Sets the component of the container. Depending on the ComponentContainer's lifecycle this might destroy the old associated Component.
					/// 
					/// Once the component is associated with the container the cross connection to the component will be set and the models will be propagated if defined. If the <code>usage</code> property is set the ComponentLifecycle is processed like a "Container" lifecycle.
					/// </summary>
					/// <param name="vComponent">ID of an element which becomes the new target of this component association. Alternatively, an element instance may be given.</param>
					/// <returns>the reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.ComponentContainer setComponent(Union<string, sap.ui.core.UIComponent> vComponent);

					#endregion

					#region Methods for Event componentCreated

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:componentCreated componentCreated} event of this <code>sap.ui.core.ComponentContainer</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.core.ComponentContainer</code> itself.
					/// 
					/// Fired when the component instance has been created by the ComponentContainer.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.core.ComponentContainer</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.ComponentContainer attachComponentCreated(object oData, sap.ui.core.ComponentContainer.ComponentCreatedDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:componentCreated componentCreated} event of this <code>sap.ui.core.ComponentContainer</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.core.ComponentContainer</code> itself.
					/// 
					/// Fired when the component instance has been created by the ComponentContainer.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.ComponentContainer attachComponentCreated(object oData, sap.ui.core.ComponentContainer.ComponentCreatedDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:componentCreated componentCreated} event of this <code>sap.ui.core.ComponentContainer</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.core.ComponentContainer</code> itself.
					/// 
					/// Fired when the component instance has been created by the ComponentContainer.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.ComponentContainer attachComponentCreated(sap.ui.core.ComponentContainer.ComponentCreatedDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:componentCreated componentCreated} event of this <code>sap.ui.core.ComponentContainer</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.core.ComponentContainer</code> itself.
					/// 
					/// Fired when the component instance has been created by the ComponentContainer.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.core.ComponentContainer</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.ComponentContainer attachComponentCreated(sap.ui.core.ComponentContainer.ComponentCreatedDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:componentCreated componentCreated} event of this <code>sap.ui.core.ComponentContainer</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.ComponentContainer detachComponentCreated(sap.ui.core.ComponentContainer.ComponentCreatedDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:componentCreated componentCreated} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.ComponentContainer fireComponentCreated(sap.ui.core.ComponentContainer.ComponentCreatedInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:componentCreated componentCreated} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.ComponentContainer fireComponentCreated();

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.ComponentContainer with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.ComponentContainer with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.ComponentContainer with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.core.ComponentContainer.
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
