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
				/// Base Class for Elements.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.core.Element")]
				public abstract partial class Element : sap.ui.@base.ManagedObject
				{
					#region Settings

					/// <summary>
					/// Settings class to create the object
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class Settings : sap.ui.@base.ManagedObject.Settings
					{
						/// <summary>
						/// The tooltip that should be shown for this Element.
						/// 
						/// Can either be an instance of a TooltipBase subclass or a simple string.
						/// </summary>
						public Union<sap.ui.core.TooltipBase, string, sap.ui.@base.ManagedObject.BindAggregationInfo> tooltip;

						/// <summary>
						/// Custom Data, a data structure like a map containing arbitrary key value pairs.
						/// </summary>
						public Union<sap.ui.core.CustomData[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> customData;

						/// <summary>
						/// Defines the layout constraints for this control when it is used inside a Layout. LayoutData classes are typed classes and must match the embedding Layout. See VariantLayoutData for aggregating multiple alternative LayoutData instances to a single Element.
						/// </summary>
						public Union<sap.ui.core.LayoutData, string, sap.ui.@base.ManagedObject.BindAggregationInfo> layoutData;

						/// <summary>
						/// Dependents are not rendered, but their databinding context and lifecycle are bound to the aggregating Element.
						/// </summary>
						public Union<sap.ui.core.Element[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> dependents;

						/// <summary>
						/// Defines the drag-and-drop configuration.
						/// 
						/// This aggregation is provided exclusively to test drag-and-drop functionality of all controls. It might be removed or the functionality might be limited due to control {@link sap.ui.core.Element.extend metadata} restrictions.
						/// </summary>
						public Union<sap.ui.core.dnd.DragDropBase[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> dragDropConfig;

					}

					#endregion

					#region Typed Parameters

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class BindElementInfo
					{
						/// <summary>
						/// the binding path
						/// </summary>
						public string path;

						/// <summary>
						/// map of additional parameters for this binding
						/// </summary>
						public object parameters;

						/// <summary>
						/// name of the model
						/// </summary>
						public string model;

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
					public partial class CreateInfo
					{
						/// <summary>
						/// Type info for the entity
						/// </summary>
						public string type;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructs and initializes a UI Element with the given <code>sId</code> and settings.
					/// 
					/// If the optional <code>mSettings</code> are given, they must be a JSON-like object (object literal) that defines values for properties, aggregations, associations or events keyed by their name.
					/// 
					/// <b>Valid Names:</b>
					/// 
					/// The property (key) names supported in the object literal are exactly the (case sensitive) names documented in the JSDoc for the properties, aggregations, associations and events of the control and its base classes. Note that for 0..n aggregations and associations this usually is the plural name, whereas it is the singular name in case of 0..1 relations.
					/// 
					/// If a key name is ambiguous for a specific control class (e.g. a property has the same name as an event), then this method prefers property, aggregation, association and event in that order. To resolve such ambiguities, the keys can be prefixed with <code>aggregation:</code>, <code>association:</code> or <code>event:</code>. In that case the keys must be quoted due to the ':'.
					/// 
					/// Each subclass should document the set of supported names in its constructor documentation.
					/// 
					/// <b>Valid Values:</b>
					/// 
					/// <ul> <li>for normal properties, the value has to be of the correct simple type (no type conversion occurs)</li> <li>for 0..1 aggregations, the value has to be an instance of the aggregated control or element type</li> <li>for 0..n aggregations, the value has to be an array of instances of the aggregated type</li> <li>for 0..1 associations, an instance of the associated type or an id (string) is accepted</li> <li>0..n associations are not supported yet</li> <li>for events either a function (event handler) is accepted or an array of length 2 where the first element is a function and the 2nd element is an object to invoke the method on.</li> </ul>
					/// 
					/// Special aggregation <code>dependents</code> is connected to the lifecycle management and databinding, but not rendered automatically and can be used for popups or other dependent controls or elements. This allows the definition of popup controls in declarative views and enables propagation of model and context information to them.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control; generated automatically if no non-empty id is given Note: this can be omitted, no matter whether <code>mSettings</code> will be given or not!</param>
					/// <param name="mSettings">optional map/JSON-object with initial property values, aggregated objects etc. for the new element</param>
					public extern Element(string sId, sap.ui.core.Element.Settings mSettings);

					/// <summary>
					/// Constructs and initializes a UI Element with the given <code>sId</code> and settings.
					/// 
					/// If the optional <code>mSettings</code> are given, they must be a JSON-like object (object literal) that defines values for properties, aggregations, associations or events keyed by their name.
					/// 
					/// <b>Valid Names:</b>
					/// 
					/// The property (key) names supported in the object literal are exactly the (case sensitive) names documented in the JSDoc for the properties, aggregations, associations and events of the control and its base classes. Note that for 0..n aggregations and associations this usually is the plural name, whereas it is the singular name in case of 0..1 relations.
					/// 
					/// If a key name is ambiguous for a specific control class (e.g. a property has the same name as an event), then this method prefers property, aggregation, association and event in that order. To resolve such ambiguities, the keys can be prefixed with <code>aggregation:</code>, <code>association:</code> or <code>event:</code>. In that case the keys must be quoted due to the ':'.
					/// 
					/// Each subclass should document the set of supported names in its constructor documentation.
					/// 
					/// <b>Valid Values:</b>
					/// 
					/// <ul> <li>for normal properties, the value has to be of the correct simple type (no type conversion occurs)</li> <li>for 0..1 aggregations, the value has to be an instance of the aggregated control or element type</li> <li>for 0..n aggregations, the value has to be an array of instances of the aggregated type</li> <li>for 0..1 associations, an instance of the associated type or an id (string) is accepted</li> <li>0..n associations are not supported yet</li> <li>for events either a function (event handler) is accepted or an array of length 2 where the first element is a function and the 2nd element is an object to invoke the method on.</li> </ul>
					/// 
					/// Special aggregation <code>dependents</code> is connected to the lifecycle management and databinding, but not rendered automatically and can be used for popups or other dependent controls or elements. This allows the definition of popup controls in declarative views and enables propagation of model and context information to them.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control; generated automatically if no non-empty id is given Note: this can be omitted, no matter whether <code>mSettings</code> will be given or not!</param>
					public extern Element(string sId);

					/// <summary>
					/// Constructs and initializes a UI Element with the given <code>sId</code> and settings.
					/// 
					/// If the optional <code>mSettings</code> are given, they must be a JSON-like object (object literal) that defines values for properties, aggregations, associations or events keyed by their name.
					/// 
					/// <b>Valid Names:</b>
					/// 
					/// The property (key) names supported in the object literal are exactly the (case sensitive) names documented in the JSDoc for the properties, aggregations, associations and events of the control and its base classes. Note that for 0..n aggregations and associations this usually is the plural name, whereas it is the singular name in case of 0..1 relations.
					/// 
					/// If a key name is ambiguous for a specific control class (e.g. a property has the same name as an event), then this method prefers property, aggregation, association and event in that order. To resolve such ambiguities, the keys can be prefixed with <code>aggregation:</code>, <code>association:</code> or <code>event:</code>. In that case the keys must be quoted due to the ':'.
					/// 
					/// Each subclass should document the set of supported names in its constructor documentation.
					/// 
					/// <b>Valid Values:</b>
					/// 
					/// <ul> <li>for normal properties, the value has to be of the correct simple type (no type conversion occurs)</li> <li>for 0..1 aggregations, the value has to be an instance of the aggregated control or element type</li> <li>for 0..n aggregations, the value has to be an array of instances of the aggregated type</li> <li>for 0..1 associations, an instance of the associated type or an id (string) is accepted</li> <li>0..n associations are not supported yet</li> <li>for events either a function (event handler) is accepted or an array of length 2 where the first element is a function and the 2nd element is an object to invoke the method on.</li> </ul>
					/// 
					/// Special aggregation <code>dependents</code> is connected to the lifecycle management and databinding, but not rendered automatically and can be used for popups or other dependent controls or elements. This allows the definition of popup controls in declarative views and enables propagation of model and context information to them.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern Element();

					/// <summary>
					/// Constructs and initializes a UI Element with the given <code>sId</code> and settings.
					/// 
					/// If the optional <code>mSettings</code> are given, they must be a JSON-like object (object literal) that defines values for properties, aggregations, associations or events keyed by their name.
					/// 
					/// <b>Valid Names:</b>
					/// 
					/// The property (key) names supported in the object literal are exactly the (case sensitive) names documented in the JSDoc for the properties, aggregations, associations and events of the control and its base classes. Note that for 0..n aggregations and associations this usually is the plural name, whereas it is the singular name in case of 0..1 relations.
					/// 
					/// If a key name is ambiguous for a specific control class (e.g. a property has the same name as an event), then this method prefers property, aggregation, association and event in that order. To resolve such ambiguities, the keys can be prefixed with <code>aggregation:</code>, <code>association:</code> or <code>event:</code>. In that case the keys must be quoted due to the ':'.
					/// 
					/// Each subclass should document the set of supported names in its constructor documentation.
					/// 
					/// <b>Valid Values:</b>
					/// 
					/// <ul> <li>for normal properties, the value has to be of the correct simple type (no type conversion occurs)</li> <li>for 0..1 aggregations, the value has to be an instance of the aggregated control or element type</li> <li>for 0..n aggregations, the value has to be an array of instances of the aggregated type</li> <li>for 0..1 associations, an instance of the associated type or an id (string) is accepted</li> <li>0..n associations are not supported yet</li> <li>for events either a function (event handler) is accepted or an array of length 2 where the first element is a function and the 2nd element is an object to invoke the method on.</li> </ul>
					/// 
					/// Special aggregation <code>dependents</code> is connected to the lifecycle management and databinding, but not rendered automatically and can be used for popups or other dependent controls or elements. This allows the definition of popup controls in declarative views and enables propagation of model and context information to them.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">optional map/JSON-object with initial property values, aggregated objects etc. for the new element</param>
					public extern Element(sap.ui.core.Element.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Aggregation tooltip

					/// <summary>
					/// Returns the tooltip for this element if any or an undefined value. The tooltip can either be a simple string or a subclass of {@link sap.ui.core.TooltipBase}.
					/// 
					/// Callers that are only interested in tooltips of type string (e.g. to render them as a <code>title</code> attribute), should call the convenience method {@link #getTooltip_AsString} instead. If they want to get a tooltip text no matter where it comes from (be it a string tooltip or the text from a TooltipBase instance) then they could call {@link #getTooltip_Text} instead.
					/// </summary>
					/// <returns>The tooltip for this Element.</returns>
					public extern virtual Union<string, sap.ui.core.TooltipBase> getTooltip();

					/// <summary>
					/// Destroys the tooltip in the aggregation named <code>tooltip</code>.
					/// </summary>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.Element destroyTooltip();

					/// <summary>
					/// Sets a new tooltip for this object. The tooltip can either be a simple string (which in most cases will be rendered as the <code>title</code> attribute of this Element) or an instance of {@link sap.ui.core.TooltipBase}.
					/// 
					/// If a new tooltip is set, any previously set tooltip is deactivated.
					/// </summary>
					/// <param name="vTooltip"></param>
					public extern virtual void setTooltip(Union<string, sap.ui.core.TooltipBase> vTooltip);

					#endregion

					#region Methods for Aggregation customData

					/// <summary>
					/// Gets content of aggregation {@link #getCustomData customData}.
					/// 
					/// Custom Data, a data structure like a map containing arbitrary key value pairs.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.CustomData[] getCustomData();

					/// <summary>
					/// Destroys all the customData in the aggregation {@link #getCustomData customData}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.Element destroyCustomData();

					/// <summary>
					/// Inserts a customData into the aggregation {@link #getCustomData customData}.
					/// </summary>
					/// <param name="oCustomData">The customData to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the customData should be inserted at; for a negative value of <code>iIndex</code>, the customData is inserted at position 0; for a value greater than the current size of the aggregation, the customData is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.Element insertCustomData(sap.ui.core.CustomData oCustomData, int iIndex);

					/// <summary>
					/// Adds some customData to the aggregation {@link #getCustomData customData}.
					/// </summary>
					/// <param name="oCustomData">The customData to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.Element addCustomData(sap.ui.core.CustomData oCustomData);

					/// <summary>
					/// Removes a customData from the aggregation {@link #getCustomData customData}.
					/// </summary>
					/// <param name="vCustomData">The customData to remove or its index or id</param>
					/// <returns>The removed customData or <code>null</code></returns>
					public extern virtual sap.ui.core.CustomData removeCustomData(Union<int, string, sap.ui.core.CustomData> vCustomData);

					/// <summary>
					/// Checks for the provided <code>sap.ui.core.CustomData</code> in the aggregation {@link #getCustomData customData}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oCustomData">The customData whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfCustomData(sap.ui.core.CustomData oCustomData);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getCustomData customData}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.core.CustomData[] removeAllCustomData();

					#endregion

					#region Methods for Aggregation layoutData

					/// <summary>
					/// Gets content of aggregation {@link #getLayoutData layoutData}.
					/// 
					/// Defines the layout constraints for this control when it is used inside a Layout. LayoutData classes are typed classes and must match the embedding Layout. See VariantLayoutData for aggregating multiple alternative LayoutData instances to a single Element.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.LayoutData getLayoutData();

					/// <summary>
					/// Destroys the layoutData in the aggregation {@link #getLayoutData layoutData}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.Element destroyLayoutData();

					/// <summary>
					/// Sets the {@link sap.ui.core.LayoutData} defining the layout constraints for this control when it is used inside a layout.
					/// </summary>
					/// <param name="oLayoutData">which should be set</param>
					/// <returns>Returns <code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.Element setLayoutData(sap.ui.core.LayoutData oLayoutData);

					#endregion

					#region Methods for Aggregation dependents

					/// <summary>
					/// Gets content of aggregation {@link #getDependents dependents}.
					/// 
					/// Dependents are not rendered, but their databinding context and lifecycle are bound to the aggregating Element.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.Element[] getDependents();

					/// <summary>
					/// Destroys all the dependents in the aggregation {@link #getDependents dependents}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.Element destroyDependents();

					/// <summary>
					/// Inserts a dependent into the aggregation {@link #getDependents dependents}.
					/// </summary>
					/// <param name="oDependent">The dependent to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the dependent should be inserted at; for a negative value of <code>iIndex</code>, the dependent is inserted at position 0; for a value greater than the current size of the aggregation, the dependent is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.Element insertDependent(sap.ui.core.Element oDependent, int iIndex);

					/// <summary>
					/// Adds some dependent to the aggregation {@link #getDependents dependents}.
					/// </summary>
					/// <param name="oDependent">The dependent to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.Element addDependent(sap.ui.core.Element oDependent);

					/// <summary>
					/// Removes a dependent from the aggregation {@link #getDependents dependents}.
					/// </summary>
					/// <param name="vDependent">The dependent to remove or its index or id</param>
					/// <returns>The removed dependent or <code>null</code></returns>
					public extern virtual sap.ui.core.Element removeDependent(Union<int, string, sap.ui.core.Element> vDependent);

					/// <summary>
					/// Checks for the provided <code>sap.ui.core.Element</code> in the aggregation {@link #getDependents dependents}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oDependent">The dependent whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfDependent(sap.ui.core.Element oDependent);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getDependents dependents}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.core.Element[] removeAllDependents();

					#endregion

					#region Methods for Aggregation dragDropConfig

					/// <summary>
					/// Gets content of aggregation {@link #getDragDropConfig dragDropConfig}.
					/// 
					/// Defines the drag-and-drop configuration.
					/// 
					/// This aggregation is provided exclusively to test drag-and-drop functionality of all controls. It might be removed or the functionality might be limited due to control {@link sap.ui.core.Element.extend metadata} restrictions.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.dnd.DragDropBase[] getDragDropConfig();

					/// <summary>
					/// Destroys all the dragDropConfig in the aggregation {@link #getDragDropConfig dragDropConfig}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.Element destroyDragDropConfig();

					/// <summary>
					/// Inserts a dragDropConfig into the aggregation {@link #getDragDropConfig dragDropConfig}.
					/// </summary>
					/// <param name="oDragDropConfig">The dragDropConfig to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the dragDropConfig should be inserted at; for a negative value of <code>iIndex</code>, the dragDropConfig is inserted at position 0; for a value greater than the current size of the aggregation, the dragDropConfig is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.Element insertDragDropConfig(sap.ui.core.dnd.DragDropBase oDragDropConfig, int iIndex);

					/// <summary>
					/// Adds some dragDropConfig to the aggregation {@link #getDragDropConfig dragDropConfig}.
					/// </summary>
					/// <param name="oDragDropConfig">The dragDropConfig to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.Element addDragDropConfig(sap.ui.core.dnd.DragDropBase oDragDropConfig);

					/// <summary>
					/// Removes a dragDropConfig from the aggregation {@link #getDragDropConfig dragDropConfig}.
					/// </summary>
					/// <param name="vDragDropConfig">The dragDropConfig to remove or its index or id</param>
					/// <returns>The removed dragDropConfig or <code>null</code></returns>
					public extern virtual sap.ui.core.dnd.DragDropBase removeDragDropConfig(Union<int, string, sap.ui.core.dnd.DragDropBase> vDragDropConfig);

					/// <summary>
					/// Checks for the provided <code>sap.ui.core.dnd.DragDropBase</code> in the aggregation {@link #getDragDropConfig dragDropConfig}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oDragDropConfig">The dragDropConfig whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfDragDropConfig(sap.ui.core.dnd.DragDropBase oDragDropConfig);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getDragDropConfig dragDropConfig}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.core.dnd.DragDropBase[] removeAllDragDropConfig();

					#endregion

					#region Other methods

					/// <summary>
					/// Returns the best suitable DOM node that represents this Element wrapped as jQuery object. I.e. the element returned by {@link sap.ui.core.Element#getDomRef} is wrapped and returned.
					/// 
					/// If an ID suffix is given, the ID of this Element is concatenated with the suffix (separated by a single dash) and the DOM node with that compound ID will be wrapped by jQuery. This matches the UI5 naming convention for named inner DOM nodes of a control.
					/// </summary>
					/// <param name="sSuffix">ID suffix to get a jQuery object for</param>
					/// <returns>The jQuery wrapped element's DOM reference</returns>
					[Name("$")]
					public extern virtual jquery.JQuery<dom.HTMLElement> dollar(string sSuffix);

					/// <summary>
					/// Returns the best suitable DOM node that represents this Element wrapped as jQuery object. I.e. the element returned by {@link sap.ui.core.Element#getDomRef} is wrapped and returned.
					/// 
					/// If an ID suffix is given, the ID of this Element is concatenated with the suffix (separated by a single dash) and the DOM node with that compound ID will be wrapped by jQuery. This matches the UI5 naming convention for named inner DOM nodes of a control.
					/// </summary>
					/// <returns>The jQuery wrapped element's DOM reference</returns>
					[Name("$")]
					public extern virtual jquery.JQuery<dom.HTMLElement> dollar();

					/// <summary>
					/// Registers the given event handler to change events of the screen width/closest media container width, based on the range set with the specified name.
					/// </summary>
					/// <param name="fnFunction"></param>
					/// <param name="oListener"></param>
					/// <param name="sName"></param>
					private extern void _attachMediaContainerWidthChange(object fnFunction, object oListener, string sName);

					/// <summary>
					/// Removes a previously attached event handler from the change events of the screen width/closest media container width.
					/// </summary>
					/// <param name="fnFunction"></param>
					/// <param name="oListener"></param>
					/// <param name="sName"></param>
					private extern void _detachMediaContainerWidthChange(object fnFunction, object oListener, string sName);

					/// <summary>
					/// Returns the current media range of the Device or the closest media container
					/// </summary>
					/// <param name="sName"></param>
					/// <returns></returns>
					private extern Map _getCurrentMediaContainerRange(string sName);

					/// <summary>
					/// Returns the contextual width of an element, if set, or <code>undefined</code> otherwise
					/// </summary>
					/// <returns></returns>
					private extern object _getMediaContainerWidth();

					/// <summary>
					/// Adds a delegate that listens to the events that are fired on this element (as opposed to events which are fired BY this element).
					/// 
					/// When this element is cloned, the same delegate will be added to all clones. This behavior is well-suited for applications which want to add delegates that also work with templates in aggregation bindings. For control development the internal "addDelegate" method which does not clone delegates by default may be more suitable, as typically each control instance takes care of its own delegates.
					/// 
					/// To avoid double registrations, all registrations of the given delegate are first removed and then the delegate is added.
					/// 
					/// <strong>Important:</strong> If event delegates were added the delegate will still be called even if the event was processed and/or cancelled via <code>preventDefault</code> by the Element or another event delegate. <code>preventDefault</code> only prevents the event from bubbling. It should be checked e.g. in the event delegate's listener whether an Element is still enabled via <code>getEnabled</code>. Additionally there might be other things that delegates need to check depending on the event (e.g. not adding a key twice to an output string etc.).
					/// </summary>
					/// <param name="oDelegate">the delegate object</param>
					/// <param name="oThis">if given, this object will be the "this" context in the listener methods; default is the delegate object itself</param>
					/// <returns>Returns <code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.Element addEventDelegate(object oDelegate, object oThis);

					/// <summary>
					/// Adds a delegate that listens to the events that are fired on this element (as opposed to events which are fired BY this element).
					/// 
					/// When this element is cloned, the same delegate will be added to all clones. This behavior is well-suited for applications which want to add delegates that also work with templates in aggregation bindings. For control development the internal "addDelegate" method which does not clone delegates by default may be more suitable, as typically each control instance takes care of its own delegates.
					/// 
					/// To avoid double registrations, all registrations of the given delegate are first removed and then the delegate is added.
					/// 
					/// <strong>Important:</strong> If event delegates were added the delegate will still be called even if the event was processed and/or cancelled via <code>preventDefault</code> by the Element or another event delegate. <code>preventDefault</code> only prevents the event from bubbling. It should be checked e.g. in the event delegate's listener whether an Element is still enabled via <code>getEnabled</code>. Additionally there might be other things that delegates need to check depending on the event (e.g. not adding a key twice to an output string etc.).
					/// </summary>
					/// <param name="oDelegate">the delegate object</param>
					/// <returns>Returns <code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.Element addEventDelegate(object oDelegate);

					/// <summary>
					/// Applies the focus info.
					/// 
					/// To be overwritten by the specific control method.
					/// </summary>
					/// <param name="oFocusInfo"></param>
					public extern virtual void applyFocusInfo(object oFocusInfo);

					/// <summary>
					/// Bind the object to the referenced entity in the model, which is used as the binding context to resolve bound properties or aggregations of the object itself and all of its children relatively to the given path. If a relative binding path is used, this will be applied whenever the parent context changes. There is no difference between {@link sap.ui.core.Element#bindElement} and {@link sap.ui.base.ManagedObject#bindObject}.
					/// </summary>
					/// <param name="vPath">the binding path or an object with more detailed binding options</param>
					/// <param name="mParameters">map of additional parameters for this binding (only taken into account when vPath is a string in that case it corresponds to vPath.parameters). The supported parameters are listed in the corresponding model-specific implementation of <code>sap.ui.model.ContextBinding</code>.</param>
					/// <returns>reference to the instance itself</returns>
					public extern virtual sap.ui.core.Element bindElement(Union<string, sap.ui.core.Element.BindElementInfo> vPath, object mParameters);

					/// <summary>
					/// Bind the object to the referenced entity in the model, which is used as the binding context to resolve bound properties or aggregations of the object itself and all of its children relatively to the given path. If a relative binding path is used, this will be applied whenever the parent context changes. There is no difference between {@link sap.ui.core.Element#bindElement} and {@link sap.ui.base.ManagedObject#bindObject}.
					/// </summary>
					/// <param name="vPath">the binding path or an object with more detailed binding options</param>
					/// <returns>reference to the instance itself</returns>
					public extern virtual sap.ui.core.Element bindElement(Union<string, sap.ui.core.Element.BindElementInfo> vPath);

					/// <summary>
					/// Create a clone of this Element.
					/// 
					/// Calls {@link sap.ui.base.ManagedObject#clone} and additionally clones event delegates.
					/// </summary>
					/// <param name="sIdSuffix">Suffix to be appended to the cloned element ID</param>
					/// <param name="aLocalIds">Array of local IDs within the cloned hierarchy (internally used)</param>
					/// <returns>reference to the newly created clone</returns>
					public extern virtual sap.ui.core.Element clone(string sIdSuffix, string[] aLocalIds);

					/// <summary>
					/// Create a clone of this Element.
					/// 
					/// Calls {@link sap.ui.base.ManagedObject#clone} and additionally clones event delegates.
					/// </summary>
					/// <param name="sIdSuffix">Suffix to be appended to the cloned element ID</param>
					/// <param name="aLocalIds">Array of local IDs within the cloned hierarchy (internally used)</param>
					/// <returns>reference to the newly created clone</returns>
					public extern virtual sap.ui.core.Element clone(string sIdSuffix, object[] aLocalIds);

					/// <summary>
					/// Create a clone of this Element.
					/// 
					/// Calls {@link sap.ui.base.ManagedObject#clone} and additionally clones event delegates.
					/// </summary>
					/// <param name="sIdSuffix">Suffix to be appended to the cloned element ID</param>
					/// <returns>reference to the newly created clone</returns>
					public extern virtual sap.ui.core.Element clone(string sIdSuffix);

					/// <summary>
					/// Create a clone of this Element.
					/// 
					/// Calls {@link sap.ui.base.ManagedObject#clone} and additionally clones event delegates.
					/// </summary>
					/// <returns>reference to the newly created clone</returns>
					public extern virtual sap.ui.core.Element clone();

					/// <summary>
					/// Create a clone of this Element.
					/// 
					/// Calls {@link sap.ui.base.ManagedObject#clone} and additionally clones event delegates.
					/// </summary>
					/// <param name="aLocalIds">Array of local IDs within the cloned hierarchy (internally used)</param>
					/// <returns>reference to the newly created clone</returns>
					public extern virtual sap.ui.core.Element clone(string[] aLocalIds);

					/// <summary>
					/// Create a clone of this Element.
					/// 
					/// Calls {@link sap.ui.base.ManagedObject#clone} and additionally clones event delegates.
					/// </summary>
					/// <param name="aLocalIds">Array of local IDs within the cloned hierarchy (internally used)</param>
					/// <returns>reference to the newly created clone</returns>
					public extern virtual sap.ui.core.Element clone(object[] aLocalIds);

					/// <summary>
					/// Creates a new Element from the given data.
					/// 
					/// If <code>vData</code> is an Element already, that element is returned. If <code>vData</code> is an object (literal), then a new element is created with <code>vData</code> as settings. The type of the element is either determined by a property named <code>Type</code> in the <code>vData</code> or by a type information in the <code>oKeyInfo</code> object
					/// </summary>
					/// <param name="vData">Data to create the element from</param>
					/// <param name="oKeyInfo">An entity information (e.g. aggregation info)</param>
					[Obsolete("Deprecated since 1.44. use the more flexible {@link sap.ui.base.ManagedObject.create}.")]
					public extern static void create(Union<sap.ui.core.Element, object> vData, sap.ui.core.Element.CreateInfo oKeyInfo);

					/// <summary>
					/// Creates a new Element from the given data.
					/// 
					/// If <code>vData</code> is an Element already, that element is returned. If <code>vData</code> is an object (literal), then a new element is created with <code>vData</code> as settings. The type of the element is either determined by a property named <code>Type</code> in the <code>vData</code> or by a type information in the <code>oKeyInfo</code> object
					/// </summary>
					/// <param name="vData">Data to create the element from</param>
					[Obsolete("Deprecated since 1.44. use the more flexible {@link sap.ui.base.ManagedObject.create}.")]
					public extern static void create(Union<sap.ui.core.Element, object> vData);

					/// <summary>
					/// Creates metadata for a UI Element by extending the Object Metadata.
					/// </summary>
					/// <param name="sClassName">name of the class to build the metadata for</param>
					/// <param name="oStaticInfo">static information used to build the metadata</param>
					/// <param name="fnMetaImpl">constructor to be used for the metadata</param>
					/// <returns>the created metadata</returns>
					[Obsolete("Deprecated since 1.3.1. Use the static <code>extend</code> method of the desired base class (e.g. {@link sap.ui.core.Element.extend})")]
					public extern static object defineClass(string sClassName, object oStaticInfo, object fnMetaImpl);

					/// <summary>
					/// Creates metadata for a UI Element by extending the Object Metadata.
					/// </summary>
					/// <param name="sClassName">name of the class to build the metadata for</param>
					/// <param name="oStaticInfo">static information used to build the metadata</param>
					/// <returns>the created metadata</returns>
					[Obsolete("Deprecated since 1.3.1. Use the static <code>extend</code> method of the desired base class (e.g. {@link sap.ui.core.Element.extend})")]
					public extern static object defineClass(string sClassName, object oStaticInfo);

					/// <summary>
					/// Cleans up the resources associated with this element and all its children.
					/// 
					/// After an element has been destroyed, it can no longer be used in the UI!
					/// 
					/// Applications should call this method if they don't need the element any longer.
					/// </summary>
					/// <param name="bSuppressInvalidate">if true, the UI element is not marked for redraw</param>
					public extern override void destroy(bool bSuppressInvalidate);

					/// <summary>
					/// Cleans up the resources associated with this element and all its children.
					/// 
					/// After an element has been destroyed, it can no longer be used in the UI!
					/// 
					/// Applications should call this method if they don't need the element any longer.
					/// </summary>
					public extern override void destroy();

					/// <summary>
					/// Allows the parent of a control to enhance the aria information during rendering.
					/// 
					/// This function is called by the RenderManager's writeAccessibilityState method for the parent of the currently rendered control - if the parent implements it.
					/// </summary>
					/// <param name="oElement">the Control/Element for which aria properties are rendered</param>
					/// <param name="mAriaProps">map of aria properties keyed by there name (without prefix "aria-")</param>
					/// <returns>map of enhanced aria properties</returns>
					public extern virtual object enhanceAccessibilityState(sap.ui.core.Element oElement, object mAriaProps);

					/// <summary>
					/// Cleans up the element instance before destruction.
					/// 
					/// Applications must not call this hook method directly, it is called by the framework when the element is {@link #destroy destroyed}.
					/// 
					/// Subclasses of Element should override this hook to implement any necessary cleanup.
					/// </summary>
					public extern virtual void exit();

					/// <summary>
					/// Defines a new subclass of Element with the name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> can contain the same information that {@link sap.ui.base.ManagedObject.extend} already accepts, plus the following <code>dnd</code> property to configure drag-and-drop behavior in the metadata object literal:
					/// 
					/// Example: <pre>
					/// Element.extend('sap.mylib.MyElement', {
					///   metadata : {
					///     library : 'sap.mylib',
					///     properties : {
					///       value : 'string',
					///       width : 'sap.ui.core.CSSSize'
					///     },
					///     dnd : { draggable: true, droppable: false },
					///     aggregations : {
					///       items : { type: 'sap.ui.core.Control', multiple : true, dnd : {draggable: false, dropppable: true, layout: "Horizontal" } },
					///       header : {type : "sap.ui.core.Control", multiple : false, dnd : false },
					///     }
					///   }
					/// });
					/// </pre>
					/// 
					/// <h3><code>dnd</code> key as a metadata property</h3>
					/// 
					/// <b>dnd</b>: <i>object|boolean</i><br> Defines draggable and droppable configuration of the element. The following keys can be provided via <code>dnd</code> object literal to configure drag-and-drop behavior of the element: <ul> <li><code>[draggable=true]: <i>boolean</i></code>Defines whether the element is draggable or not.</li> <li><code>[droppable=true]: <i>boolean</i></code>Defines whether the element is droppable (it allows being dropped on by a draggable element) or not.</li> </ul> If <code>dnd</code> property is of type Boolean, then the <code>draggable</code> and <code>droppable</code> configuration are set to this Boolean value.
					/// 
					/// <h3><code>dnd</code> key as an aggregation metadata property</h3>
					/// 
					/// <b>dnd</b>: <i>object|boolean</i><br> In addition to draggable and droppable configuration, the layout of the aggregation can be defined as a hint at the drop position indicator. Default behavior of draggable and droppable depends on the multiplicity of the aggregation: <ul> <li><code>[draggable]: <i>boolean</i></code>Defines whether this aggregation is draggable or not. The default value is <code>false</code> for the aggregation with multiplicity 0..n (<code>multiple: true</code>), otherwise <code>true<code>.</li> <li><code>[droppable]: <i>boolean</i></code>Defines whether dropping is allowed on and/or between the aggregation. The default value is <code>false</code> for the aggregation with multiplicity 0..n (<code>multiple: true</code>), otherwise <code>true<code>.</li> <li><code>[layout="Vertical"]: <i>boolean</i></code>The arrangement of the items in this aggregation. This setting is recommended for the aggregation with multiplicity 0..n (<code>multiple: true</code>). Possible values are <code>Vertical</code>(e.g. rows in a table) and <code>Horizontal</code>(e.g. buttons in a toolbar). It is recommended to use <code>Horizontal</code> layout if the arrangement is multidimensional.</li> </ul> If <code>dnd</code> property is of type Boolean, then the <code>draggable</code> and <code>droppable</code> configuration are set to this Boolean value.
					/// </summary>
					/// <param name="sClassName">fully qualified name of the class that is described by this metadata object</param>
					/// <param name="oStaticInfo">static info to construct the metadata from</param>
					public extern static void extend(string sClassName, object oStaticInfo);

					/// <summary>
					/// Searches and returns an array of child elements and controls which are referenced within an aggregation or aggregations of child elements/controls. This can be either done recursive or not.
					/// 
					/// <b>Take care: this operation might be expensive.</b>
					/// </summary>
					/// <param name="bRecursive">true, if all nested children should be returned.</param>
					/// <returns>array of child elements and controls</returns>
					public extern virtual sap.ui.core.Element[] findElements(bool bRecursive);

					/// <summary>
					/// Fires the given event and notifies all listeners. Listeners must not change the content of the event.
					/// </summary>
					/// <param name="sEventId">the event id</param>
					/// <param name="mParameters">the parameter map</param>
					/// <returns>Returns <code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.Element fireEvent(string sEventId, object mParameters);

					/// <summary>
					/// Sets the focus to the stored focus DOM reference
					/// </summary>
					public extern virtual void focus();

					/// <summary>
					/// Returns the best suitable DOM Element that represents this UI5 Element. By default the DOM Element with the same ID as this Element is returned. Subclasses should override this method if the lookup via id is not sufficient.
					/// 
					/// Note that such a DOM Element does not necessarily exist in all cases. Some elements or controls might not have a DOM representation at all (e.g. a naive FlowLayout) while others might not have one due to their current state (e.g. an initial, not yet rendered control).
					/// 
					/// If an ID suffix is given, the ID of this Element is concatenated with the suffix (separated by a single dash) and the DOM node with that compound ID will be returned. This matches the UI5 naming convention for named inner DOM nodes of a control.
					/// </summary>
					/// <param name="sSuffix">ID suffix to get the DOMRef for</param>
					/// <returns>The Element's DOM Element sub DOM Element or null</returns>
					public extern virtual dom.HTMLElement getDomRef(string sSuffix);

					/// <summary>
					/// Returns the best suitable DOM Element that represents this UI5 Element. By default the DOM Element with the same ID as this Element is returned. Subclasses should override this method if the lookup via id is not sufficient.
					/// 
					/// Note that such a DOM Element does not necessarily exist in all cases. Some elements or controls might not have a DOM representation at all (e.g. a naive FlowLayout) while others might not have one due to their current state (e.g. an initial, not yet rendered control).
					/// 
					/// If an ID suffix is given, the ID of this Element is concatenated with the suffix (separated by a single dash) and the DOM node with that compound ID will be returned. This matches the UI5 naming convention for named inner DOM nodes of a control.
					/// </summary>
					/// <returns>The Element's DOM Element sub DOM Element or null</returns>
					public extern virtual dom.HTMLElement getDomRef();

					/// <summary>
					/// Returns a DOM Element representing the given property or aggregation of this <code>Element</code>.
					/// 
					/// Check the documentation for the <code>selector</code> metadata setting in {@link sap.ui.base.ManagedObject.extend} for details about its syntax or its expected result.
					/// 
					/// The default implementation of this method will return <code>null</code> in any of the following cases: <ul> <li>no setting (property or aggregation) with the given name exists in the class of this <code>Element</code></li> <li>the setting has no selector defined in its metadata</li> <li>{@link #getDomRef this.getDomRef()} returns no DOM Element for this <code>Element</code> or the returned DOM Element has no parentNode</li> <li>the selector does not match anything in the context of <code>this.getDomRef().parentNode</code></li> </ul> If more than one DOM Element within the element matches the selector, the first occurrence is returned.
					/// 
					/// Subclasses can override this method to handle more complex cases which can't be described by a CSS selector.
					/// </summary>
					/// <param name="sSettingsName">Name of the property or aggregation</param>
					/// <returns>The first matching DOM Element for the setting or <code>null</code></returns>
					private extern dom.HTMLElement getDomRefForSetting(string sSettingsName);

					/// <summary>
					/// Get the context binding object for a specific model name.
					/// 
					/// <b>Note:</b> to be compatible with future versions of this API, you must not use the following model names: <ul> <li><code>null</code></li> <li>empty string <code>""</code></li> <li>string literals <code>"null"</code> or <code>"undefined"</code></li> </ul> Omitting the model name (or using the value <code>undefined</code>) is explicitly allowed and refers to the default model.
					/// </summary>
					/// <param name="sModelName">Name of the model or <code>undefined</code></param>
					/// <returns>Context binding for the given model name or <code>undefined</code></returns>
					public extern virtual sap.ui.model.ContextBinding getElementBinding(string sModelName);

					/// <summary>
					/// Get the context binding object for a specific model name.
					/// 
					/// <b>Note:</b> to be compatible with future versions of this API, you must not use the following model names: <ul> <li><code>null</code></li> <li>empty string <code>""</code></li> <li>string literals <code>"null"</code> or <code>"undefined"</code></li> </ul> Omitting the model name (or using the value <code>undefined</code>) is explicitly allowed and refers to the default model.
					/// </summary>
					/// <returns>Context binding for the given model name or <code>undefined</code></returns>
					public extern virtual sap.ui.model.ContextBinding getElementBinding();

					/// <summary>
					/// Returns the DOM Element that should get the focus.
					/// 
					/// To be overwritten by the specific control method.
					/// </summary>
					/// <returns>Returns the DOM Element that should get the focus</returns>
					public extern virtual dom.HTMLElement getFocusDomRef();

					/// <summary>
					/// Returns an object representing the serialized focus information To be overwritten by the specific control method
					/// </summary>
					/// <returns>an object representing the serialized focus information</returns>
					public extern virtual object getFocusInfo();

					public extern virtual void getInterface();

					/// <summary>
					/// Returns the runtime metadata for this UI element.
					/// 
					/// When using the defineClass method, this function is automatically created and returns a runtime representation of the design time metadata.
					/// </summary>
					/// <returns>runtime metadata</returns>
					public extern virtual object getMetadata();

					/// <summary>
					/// Returns the tooltip for this element but only if it is a simple string. Otherwise an undefined value is returned.
					/// </summary>
					/// <returns>string tooltip or undefined</returns>
					public extern virtual string getTooltip_AsString();

					/// <summary>
					/// Returns the main text for the current tooltip or undefined if there is no such text. If the tooltip is an object derived from sap.ui.core.Tooltip, then the text property of that object is returned. Otherwise the object itself is returned (either a string or undefined or null).
					/// </summary>
					/// <returns>text of the current tooltip or undefined</returns>
					public extern virtual string getTooltip_Text();

					/// <summary>
					/// Initializes the element instance after creation.
					/// 
					/// Applications must not call this hook method directly, it is called by the framework while the constructor of an element is executed.
					/// 
					/// Subclasses of Element should override this hook to implement any necessary initialization.
					/// </summary>
					public extern virtual void init();

					/// <summary>
					/// This function either calls set[sPropertyName] or get[sPropertyName] with the specified property name depending if an <code>oValue</code> is provided or not.
					/// </summary>
					/// <param name="sPropertyName">name of the property to set</param>
					/// <param name="oValue">value to set the property to</param>
					/// <returns>Returns <code>this</code> to allow method chaining in case of setter and the property value in case of getter</returns>
					[Obsolete("Deprecated since 1.28.0. The contract of this method is not fully defined and its write capabilities overlap with applySettings")]
					public extern virtual sap.ui.core.Element prop(string sPropertyName, object oValue);

					/// <summary>
					/// This function either calls set[sPropertyName] or get[sPropertyName] with the specified property name depending if an <code>oValue</code> is provided or not.
					/// </summary>
					/// <param name="sPropertyName">name of the property to set</param>
					/// <returns>Returns <code>this</code> to allow method chaining in case of setter and the property value in case of getter</returns>
					[Obsolete("Deprecated since 1.28.0. The contract of this method is not fully defined and its write capabilities overlap with applySettings")]
					public extern virtual sap.ui.core.Element prop(string sPropertyName);

					/// <summary>
					/// Removes the given delegate from this element.
					/// 
					/// This method will remove all registrations of the given delegate, not only one.
					/// </summary>
					/// <param name="oDelegate">the delegate object</param>
					/// <returns>Returns <code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.Element removeEventDelegate(object oDelegate);

					/// <summary>
					/// This triggers immediate rerendering of its parent and thus of itself and its children.
					/// 
					/// As <code>sap.ui.core.Element</code> "bubbles up" the rerender, changes to child-<code>Elements</code> will also result in immediate rerendering of the whole sub tree.
					/// </summary>
					public extern virtual void rerender();

					/// <summary>
					/// Returns a simple string representation of this element.
					/// 
					/// Mainly useful for tracing purposes.
					/// </summary>
					/// <returns>a string description of this element</returns>
					public extern override string toString();

					/// <summary>
					/// Removes the defined binding context of this object, all bindings will now resolve relative to the parent context again.
					/// </summary>
					/// <param name="sModelName"></param>
					/// <returns>reference to the instance itself</returns>
					public extern virtual sap.ui.@base.ManagedObject unbindElement(string sModelName);

					/// <summary>
					/// Attaches custom data to an <code>Element</code> or retrieves attached data.
					/// 
					/// Usage: <pre>
					///    data("myKey", myData)
					/// </pre> Attaches <code>myData</code> (which can be any JS data type, e.g. a number, a string, an object, or a function) to this element, under the given key "myKey". If the key already exists,the value will be updated.
					/// 
					/// <pre>
					///    data("myKey", myData, writeToDom)
					/// </pre> Attaches <code>myData</code> to this element, under the given key "myKey" and (if <code>writeToDom</code> is true) writes key and value to the HTML. If the key already exists,the value will be updated. While <code>oValue</code> can be any JS data type to be attached, it must be a string to be also written to DOM. The key must also be a valid HTML attribute name (it must conform to <code>sap.ui.core.ID</code> and may contain no colon) and may not start with "sap-ui". When written to HTML, the key is prefixed with "data-".
					/// 
					/// <pre>
					///    data("myKey")
					/// </pre> Retrieves whatever data has been attached to this element (using the key "myKey") before
					/// 
					/// <pre>
					///    data("myKey", null)
					/// </pre> Removes whatever data has been attached to this element (using the key "myKey") before
					/// 
					/// <pre>
					///    data(null)
					/// </pre> Removes all data
					/// 
					/// <pre>
					///    data()
					/// </pre> Returns all data, as a map
					/// </summary>
					/// <param name="sKey"></param>
					/// <param name="oData"></param>
					/// <param name="bWriteToDom"></param>
					/// <returns></returns>
					public extern virtual object data(string sKey, object oData, bool bWriteToDom);

					/// <summary>
					/// Attaches custom data to an <code>Element</code> or retrieves attached data.
					/// 
					/// Usage: <pre>
					///    data("myKey", myData)
					/// </pre> Attaches <code>myData</code> (which can be any JS data type, e.g. a number, a string, an object, or a function) to this element, under the given key "myKey". If the key already exists,the value will be updated.
					/// 
					/// <pre>
					///    data("myKey", myData, writeToDom)
					/// </pre> Attaches <code>myData</code> to this element, under the given key "myKey" and (if <code>writeToDom</code> is true) writes key and value to the HTML. If the key already exists,the value will be updated. While <code>oValue</code> can be any JS data type to be attached, it must be a string to be also written to DOM. The key must also be a valid HTML attribute name (it must conform to <code>sap.ui.core.ID</code> and may contain no colon) and may not start with "sap-ui". When written to HTML, the key is prefixed with "data-".
					/// 
					/// <pre>
					///    data("myKey")
					/// </pre> Retrieves whatever data has been attached to this element (using the key "myKey") before
					/// 
					/// <pre>
					///    data("myKey", null)
					/// </pre> Removes whatever data has been attached to this element (using the key "myKey") before
					/// 
					/// <pre>
					///    data(null)
					/// </pre> Removes all data
					/// 
					/// <pre>
					///    data()
					/// </pre> Returns all data, as a map
					/// </summary>
					/// <param name="sKey"></param>
					/// <param name="oData"></param>
					/// <returns></returns>
					public extern virtual object data(string sKey, object oData);

					/// <summary>
					/// Attaches custom data to an <code>Element</code> or retrieves attached data.
					/// 
					/// Usage: <pre>
					///    data("myKey", myData)
					/// </pre> Attaches <code>myData</code> (which can be any JS data type, e.g. a number, a string, an object, or a function) to this element, under the given key "myKey". If the key already exists,the value will be updated.
					/// 
					/// <pre>
					///    data("myKey", myData, writeToDom)
					/// </pre> Attaches <code>myData</code> to this element, under the given key "myKey" and (if <code>writeToDom</code> is true) writes key and value to the HTML. If the key already exists,the value will be updated. While <code>oValue</code> can be any JS data type to be attached, it must be a string to be also written to DOM. The key must also be a valid HTML attribute name (it must conform to <code>sap.ui.core.ID</code> and may contain no colon) and may not start with "sap-ui". When written to HTML, the key is prefixed with "data-".
					/// 
					/// <pre>
					///    data("myKey")
					/// </pre> Retrieves whatever data has been attached to this element (using the key "myKey") before
					/// 
					/// <pre>
					///    data("myKey", null)
					/// </pre> Removes whatever data has been attached to this element (using the key "myKey") before
					/// 
					/// <pre>
					///    data(null)
					/// </pre> Removes all data
					/// 
					/// <pre>
					///    data()
					/// </pre> Returns all data, as a map
					/// </summary>
					/// <param name="sKey"></param>
					/// <returns></returns>
					public extern virtual object data(string sKey);

					/// <summary>
					/// Attaches custom data to an <code>Element</code> or retrieves attached data.
					/// 
					/// Usage: <pre>
					///    data("myKey", myData)
					/// </pre> Attaches <code>myData</code> (which can be any JS data type, e.g. a number, a string, an object, or a function) to this element, under the given key "myKey". If the key already exists,the value will be updated.
					/// 
					/// <pre>
					///    data("myKey", myData, writeToDom)
					/// </pre> Attaches <code>myData</code> to this element, under the given key "myKey" and (if <code>writeToDom</code> is true) writes key and value to the HTML. If the key already exists,the value will be updated. While <code>oValue</code> can be any JS data type to be attached, it must be a string to be also written to DOM. The key must also be a valid HTML attribute name (it must conform to <code>sap.ui.core.ID</code> and may contain no colon) and may not start with "sap-ui". When written to HTML, the key is prefixed with "data-".
					/// 
					/// <pre>
					///    data("myKey")
					/// </pre> Retrieves whatever data has been attached to this element (using the key "myKey") before
					/// 
					/// <pre>
					///    data("myKey", null)
					/// </pre> Removes whatever data has been attached to this element (using the key "myKey") before
					/// 
					/// <pre>
					///    data(null)
					/// </pre> Removes all data
					/// 
					/// <pre>
					///    data()
					/// </pre> Returns all data, as a map
					/// </summary>
					/// <returns></returns>
					public extern virtual object data();

					/// <summary>
					/// Attaches custom data to an <code>Element</code> or retrieves attached data.
					/// 
					/// Usage: <pre>
					///    data("myKey", myData)
					/// </pre> Attaches <code>myData</code> (which can be any JS data type, e.g. a number, a string, an object, or a function) to this element, under the given key "myKey". If the key already exists,the value will be updated.
					/// 
					/// <pre>
					///    data("myKey", myData, writeToDom)
					/// </pre> Attaches <code>myData</code> to this element, under the given key "myKey" and (if <code>writeToDom</code> is true) writes key and value to the HTML. If the key already exists,the value will be updated. While <code>oValue</code> can be any JS data type to be attached, it must be a string to be also written to DOM. The key must also be a valid HTML attribute name (it must conform to <code>sap.ui.core.ID</code> and may contain no colon) and may not start with "sap-ui". When written to HTML, the key is prefixed with "data-".
					/// 
					/// <pre>
					///    data("myKey")
					/// </pre> Retrieves whatever data has been attached to this element (using the key "myKey") before
					/// 
					/// <pre>
					///    data("myKey", null)
					/// </pre> Removes whatever data has been attached to this element (using the key "myKey") before
					/// 
					/// <pre>
					///    data(null)
					/// </pre> Removes all data
					/// 
					/// <pre>
					///    data()
					/// </pre> Returns all data, as a map
					/// </summary>
					/// <param name="oData"></param>
					/// <returns></returns>
					public extern virtual object data(object oData);

					#endregion

					#endregion

				}
			}
		}
	}
}
