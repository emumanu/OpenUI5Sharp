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
				/// RenderManager that will take care for rendering Controls.
				/// 
				/// For the default rendering task of UI5, a shared RenderManager is created and owned by <code>sap.ui.core.Core</code>. Controls or other code that want to render controls outside the default rendering task can create a private instance of RenderManager by calling the {@link sap.ui.core.Core#createRenderManager sap.ui.getCore().createRenderManager()} method. When such a private instance is no longer needed, it should be {@link #destroy destroyed}.
				/// 
				/// Control renderers only have access to a subset of the public and protected instance methods of this class. The instance methods {@link #flush}, {@link #render} and {@link #destroy} are not part of that subset and are reserved to the owner of the corresponding RenderManager instance. Renderers will use the provided methods to create their HTML output. The RenderManager will collect the HTML output and inject the final HTML DOM at the desired location.
				/// 
				/// <h3>Renderers</h3> When the {@link #renderControl} method of the RenderManager is invoked, it will retrieve the default renderer for that control. By convention, the default renderer is implemented in its own namespace (static class) which matches the name of the control's class with the additional suffix 'Renderer'. So for a control <code>sap.m.Input</code> the default renderer will be searched for under the global name <code>sap.m.Input<i>Renderer</i></code>.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.core.RenderManager")]
				public partial class RenderManager : Object
				{
					#region Constructor

					/// <summary>
					/// Creates an instance of the RenderManager.
					/// 
					/// Applications or controls must not call the <code>RenderManager</code> constructor on their own but should use the {@link sap.ui.core.Core#createRenderManager sap.ui.getCore().createRenderManager()} method to create an instance for their exclusive use.
					/// </summary>
					public extern RenderManager();

					#endregion

					#region Methods

					/// <summary>
					/// Adds a class to the class collection if the name is not empty or null. The class collection is flushed if it is written to the buffer using {@link #writeClasses}
					/// </summary>
					/// <param name="sName">name of the class to be added; null values are ignored</param>
					/// <returns>this render manager instance to allow chaining</returns>
					public extern virtual sap.ui.core.RenderManager addClass(string sName);

					/// <summary>
					/// Adds a style property to the style collection if the value is not empty or null The style collection is flushed if it is written to the buffer using {@link #writeStyle}
					/// </summary>
					/// <param name="sName">Name of the CSS property to write</param>
					/// <param name="value">Value to write</param>
					/// <returns>This render manager instance to allow chaining</returns>
					public extern virtual sap.ui.core.RenderManager addStyle(string sName, Union<string, float, int> value);

					/// <summary>
					/// Attaches a listener which is called on {@link sap.ui.core.RenderManager.preserveContent} call
					/// </summary>
					/// <param name="fnListener">listener function</param>
					/// <param name="oContext">context for the listener function</param>
					private extern static void attachPreserveContent(object fnListener, object oContext);

					/// <summary>
					/// Attaches a listener which is called on {@link sap.ui.core.RenderManager.preserveContent} call
					/// </summary>
					/// <param name="fnListener">listener function</param>
					private extern static void attachPreserveContent(object fnListener);

					/// <summary>
					/// Cleans up the rendering state of the given control without rendering it.
					/// 
					/// A control is responsible for the rendering of all its child controls. But in some cases it makes sense that a control only renders a subset of its children based on some criterion. For example, a typical carousel control might, for performance reasons, only render the currently visible children (and maybe some child before and after the visible area to facilitate slide-in / slide-out animations), but not all children. This leads to situations where a child had been rendered before, but shouldn't be rendered anymore after an update of the carousel's position. The DOM related state of that child then must be cleaned up correctly, e.g. by de-registering resize handlers or native event handlers. <code>cleanupControlWithoutRendering</code> helps with that task by triggering the same activities that the normal rendering triggers before the rendering of a control (e.g. it fire the <code>BeforeRendering</code> event). It just doesn't call the renderer and the control will not receive an <code>AfterRendering</code> event.
					/// 
					/// The following example shows how <code>renderControl</code> and <code>cleanupControlWithoutRendering</code> should be used:
					/// 
					/// <pre>
					///   CarouselRenderer.render = function(rm, oCarousel){
					/// 
					///     ...
					/// 
					///     oCarousel.getPages().forEach( oPage ) {
					///        if ( oCarousel.isPageToBeRendered( oPage ) ) {
					///           rm.renderControl( oPage ); // onBeforeRendering, render, later onAfterRendering
					///        } else {
					///           rm.cleanupControlWithoutRendering( oPage ); // onBeforeRendering
					///        }
					///     }
					/// 
					///     ...
					/// 
					///   };
					/// </pre>
					/// 
					/// <h3>DOM Removal</h3> The method does not remove the DOM of the given control. The caller of this method has to take care to remove it at some later point in time. It should indeed be <i>later</i>, not <i>before</i> as the <code>onBeforeRendering</code> hook of the control might need access to the old DOM for a proper cleanup.
					/// 
					/// For parents which are rendered with the normal mechanism as shown in the example above, the removal of the old child DOM is guaranteed. The whole DOM of the parent control (including the DOM of the no longer rendered child) will be replaced with new DOM (no longer containing the child) when the rendering cycle finishes.
					/// 
					/// <b>Note:</b>: the functionality of this method is different from the default handling for invisible controls (controls with <code>visible == false</code>). The standard rendering for invisible controls still renders a placeholder DOM. This allows re-rendering of the invisible control once it becomes visible again without a need to render its parent, too. Children that are cleaned up with this method here, are supposed to have no more DOM at all. Rendering them later on therefore requires an involvement (typically: a rendering) of their parent.
					/// </summary>
					/// <param name="oControl">Control that should be cleaned up</param>
					public extern virtual void cleanupControlWithoutRendering(sap.ui.core.Control oControl);

					/// <summary>
					/// Creates the ID to be used for the invisible Placeholder DOM element. This method can be used to get direct access to the placeholder DOM element. Also statically available as RenderManager.createInvisiblePlaceholderId()
					/// </summary>
					/// <param name="oElement">The Element instance for which to create the placeholder ID</param>
					/// <returns>The ID used for the invisible Placeholder of this element</returns>
					public extern static string createInvisiblePlaceholderId(sap.ui.core.Element oElement);

					/// <summary>
					/// Cleans up the resources associated with this instance.
					/// 
					/// After the instance has been destroyed, it must not be used anymore. Applications should call this function if they don't need the instance any longer.
					/// </summary>
					public extern virtual void destroy();

					/// <summary>
					/// Detaches a {@link sap.ui.core.RenderManager.preserveContent} listener
					/// </summary>
					/// <param name="fnListener">listener function</param>
					private extern static void detachPreserveContent(object fnListener);

					/// <summary>
					/// Searches "to-be-preserved" nodes for the given control id.
					/// </summary>
					/// <param name="sId">control id to search content for.</param>
					/// <returns>a jQuery collection representing the found content</returns>
					public extern static jQuery findPreservedContent(string sId);

					/// <summary>
					/// Renders the content of the rendering buffer into the provided DOM node.
					/// 
					/// This function must not be called within control renderers.
					/// 
					/// Usage: <pre>
					/// 
					///   // Create a new instance of the RenderManager
					///   var rm = sap.ui.getCore().createRenderManager();
					/// 
					///   // Use the writer API to fill the buffers
					///   rm.write(...);
					///   rm.renderControl(oControl);
					///   rm.write(...);
					///   ...
					/// 
					///   // Finally flush the buffer into the provided DOM node (The current content is removed)
					///   rm.flush(oDomNode);
					/// 
					///   // If the instance is not needed anymore, destroy it
					///   rm.destroy();
					/// 
					/// </pre>
					/// </summary>
					/// <param name="oTargetDomNode">Node in the DOM where the buffer should be flushed into</param>
					/// <param name="bDoNotPreserve">Determines whether the content is preserved (<code>false</code>) or not (<code>true</code>)</param>
					/// <param name="vInsert">Determines whether the buffer of the target DOM node is expanded (<code>true</code>) or replaced (<code>false</code>), or the new entry is inserted at a specific position (value of type <code>int</code>)</param>
					public extern virtual void flush(Retyped.dom.HTMLElement oTargetDomNode, bool bDoNotPreserve, Union<bool?, int?> vInsert);

					/// <summary>
					/// Returns the configuration object Shortcut for <code>sap.ui.getCore().getConfiguration()</code>
					/// </summary>
					/// <returns>the configuration object</returns>
					public extern virtual sap.ui.core.Configuration getConfiguration();

					/// <summary>
					/// Renders the given {@link sap.ui.core.Control} and finally returns the content of the rendering buffer. Ensures the buffer is restored to the state before calling this method.
					/// </summary>
					/// <param name="oControl">the Control whose HTML should be returned.</param>
					/// <returns>the resulting HTML of the provided control</returns>
					[Obsolete("Deprecated since 0.15.0. Use <code>flush()</code> instead render content outside the rendering phase.")]
					public extern virtual string getHTML(sap.ui.core.Control oControl);

					/// <summary>
					/// Returns the hidden area reference belonging to the current window instance.
					/// </summary>
					/// <returns>The hidden area reference belonging to the current window instance.</returns>
					public extern static Retyped.dom.HTMLElement getPreserveAreaRef();

					/// <summary>
					/// Returns the renderer class for a given control instance
					/// </summary>
					/// <param name="oControl">the control that should be rendered</param>
					/// <returns>the renderer class for a given control instance</returns>
					public extern virtual void getRenderer(sap.ui.core.Control oControl);

					/// <summary>
					/// Collects descendants of the given root node that need to be preserved before the root node is wiped out. The "to-be-preserved" nodes are moved to a special, hidden 'preserve' area.
					/// 
					/// A node is declared "to-be-preserved" when it has the <code>data-sap-ui-preserve</code> attribute set. When the optional parameter <code>bPreserveNodesWithId</code> is set to true, then nodes with an id are preserved as well and their <code>data-sap-ui-preserve</code> attribute is set automatically. This option is used by UIAreas when they render for the first time and simplifies the handling of predefined HTML content in a web page.
					/// 
					/// The "to-be-preserved" nodes are searched with a depth first search and moved to the 'preserve' area in the order that they are found. So for direct siblings the order should be stable.
					/// </summary>
					/// <param name="oRootNode">to search for "to-be-preserved" nodes</param>
					/// <param name="bPreserveRoot">whether to preserve the root itself</param>
					/// <param name="bPreserveNodesWithId">whether to preserve nodes with an id as well</param>
					public extern static void preserveContent(Retyped.dom.HTMLElement oRootNode, bool bPreserveRoot = false, bool bPreserveNodesWithId = false);

					/// <summary>
					/// Renders the given control to the provided DOMNode.
					/// 
					/// If the control is already rendered in the provided DOMNode the DOM of the control is replaced. If the control is already rendered somewhere else the current DOM of the control is removed and the new DOM is appended to the provided DOMNode.
					/// 
					/// This function must not be called within control renderers.
					/// </summary>
					/// <param name="oControl">the Control that should be rendered.</param>
					/// <param name="oTargetDomNode">The node in the DOM where the result of the rendering should be inserted.</param>
					public extern virtual void render(sap.ui.core.Control oControl, Retyped.dom.HTMLElement oTargetDomNode);

					/// <summary>
					/// Turns the given control into its HTML representation and appends it to the rendering buffer.
					/// 
					/// If the given control is undefined or null, then nothing is rendered.
					/// </summary>
					/// <param name="oControl">the control that should be rendered</param>
					/// <returns>this render manager instance to allow chaining</returns>
					public extern virtual sap.ui.core.RenderManager renderControl(sap.ui.core.Control oControl);

					/// <param name="sKey"></param>
					[Obsolete("Deprecated since 1.1. never has been implemented - DO NOT USE")]
					public extern virtual void translate(string sKey);

					/// <summary>
					/// Write the given texts to the buffer
					/// </summary>
					/// <param name="sText">(can be a number too)</param>
					/// <returns>this render manager instance to allow chaining</returns>
					public extern virtual sap.ui.core.RenderManager write(Union<string, int> sText);

					/// <returns>this render manager instance to allow chaining</returns>
					[Obsolete("Deprecated since 1.1. never has been implemented - DO NOT USE")]
					public extern virtual sap.ui.core.RenderManager writeAcceleratorKey();

					/// <summary>
					/// Writes the accessibility state (see WAI-ARIA specification) of the provided element into the HTML based on the element's properties and associations.
					/// 
					/// The ARIA properties are only written when the accessibility feature is activated in the UI5 configuration.
					/// 
					/// The following properties/values to ARIA attribute mappings are done (if the element does have such properties): <ul> <li><code>editable===false</code> => <code>aria-readonly="true"</code></li> <li><code>enabled===false</code> => <code>aria-disabled="true"</code></li> <li><code>visible===false</code> => <code>aria-hidden="true"</code></li> <li><code>required===true</code> => <code>aria-required="true"</code></li> <li><code>selected===true</code> => <code>aria-selected="true"</code></li> <li><code>checked===true</code> => <code>aria-checked="true"</code></li> </ul>
					/// 
					/// In case of the required attribute also the Label controls which referencing the given element in their 'for' relation are taken into account to compute the <code>aria-required</code> attribute.
					/// 
					/// Additionally, the association <code>ariaDescribedBy</code> and <code>ariaLabelledBy</code> are used to write the ID lists of the ARIA attributes <code>aria-describedby</code> and <code>aria-labelledby</code>.
					/// 
					/// Label controls that reference the given element in their 'for' relation are automatically added to the <code>aria-labelledby</code> attributes.
					/// 
					/// Note: This function is only a heuristic of a control property to ARIA attribute mapping. Control developers have to check whether it fulfills their requirements. In case of problems (for example the RadioButton has a <code>selected</code> property but must provide an <code>aria-checked</code> attribute) the auto-generated result of this function can be influenced via the parameter <code>mProps</code> as described below.
					/// 
					/// The parameter <code>mProps</code> can be used to either provide additional attributes which should be added and/or to avoid the automatic generation of single ARIA attributes. The 'aria-' prefix will be prepended automatically to the keys (Exception: Attribute 'role' does not get the prefix 'aria-').
					/// 
					/// Examples: <code>{hidden : true}</code> results in <code>aria-hidden="true"</code> independent of the presence or absence of the visibility property. <code>{hidden : null}</code> ensures that no <code>aria-hidden</code> attribute is written independent of the presence or absence of the visibility property. The function behaves in the same way for the associations <code>ariaDescribedBy</code> and <code>ariaLabelledBy</code>. To append additional values to the auto-generated <code>aria-describedby</code> and <code>aria-labelledby</code> attributes the following format can be used: <code>{describedby : {value: "id1 id2", append: true}}</code> => <code>aria-describedby="ida idb id1 id2"</code> (assuming that "ida idb" is the auto-generated part based on the association <code>ariaDescribedBy</code>).
					/// </summary>
					/// <param name="oElement">the element whose accessibility state should be rendered</param>
					/// <param name="mProps">a map of properties that should be added additionally or changed.</param>
					/// <returns>this render manager instance to allow chaining</returns>
					public extern virtual sap.ui.core.RenderManager writeAccessibilityState(sap.ui.core.Element oElement, object mProps);

					/// <summary>
					/// Writes the accessibility state (see WAI-ARIA specification) of the provided element into the HTML based on the element's properties and associations.
					/// 
					/// The ARIA properties are only written when the accessibility feature is activated in the UI5 configuration.
					/// 
					/// The following properties/values to ARIA attribute mappings are done (if the element does have such properties): <ul> <li><code>editable===false</code> => <code>aria-readonly="true"</code></li> <li><code>enabled===false</code> => <code>aria-disabled="true"</code></li> <li><code>visible===false</code> => <code>aria-hidden="true"</code></li> <li><code>required===true</code> => <code>aria-required="true"</code></li> <li><code>selected===true</code> => <code>aria-selected="true"</code></li> <li><code>checked===true</code> => <code>aria-checked="true"</code></li> </ul>
					/// 
					/// In case of the required attribute also the Label controls which referencing the given element in their 'for' relation are taken into account to compute the <code>aria-required</code> attribute.
					/// 
					/// Additionally, the association <code>ariaDescribedBy</code> and <code>ariaLabelledBy</code> are used to write the ID lists of the ARIA attributes <code>aria-describedby</code> and <code>aria-labelledby</code>.
					/// 
					/// Label controls that reference the given element in their 'for' relation are automatically added to the <code>aria-labelledby</code> attributes.
					/// 
					/// Note: This function is only a heuristic of a control property to ARIA attribute mapping. Control developers have to check whether it fulfills their requirements. In case of problems (for example the RadioButton has a <code>selected</code> property but must provide an <code>aria-checked</code> attribute) the auto-generated result of this function can be influenced via the parameter <code>mProps</code> as described below.
					/// 
					/// The parameter <code>mProps</code> can be used to either provide additional attributes which should be added and/or to avoid the automatic generation of single ARIA attributes. The 'aria-' prefix will be prepended automatically to the keys (Exception: Attribute 'role' does not get the prefix 'aria-').
					/// 
					/// Examples: <code>{hidden : true}</code> results in <code>aria-hidden="true"</code> independent of the presence or absence of the visibility property. <code>{hidden : null}</code> ensures that no <code>aria-hidden</code> attribute is written independent of the presence or absence of the visibility property. The function behaves in the same way for the associations <code>ariaDescribedBy</code> and <code>ariaLabelledBy</code>. To append additional values to the auto-generated <code>aria-describedby</code> and <code>aria-labelledby</code> attributes the following format can be used: <code>{describedby : {value: "id1 id2", append: true}}</code> => <code>aria-describedby="ida idb id1 id2"</code> (assuming that "ida idb" is the auto-generated part based on the association <code>ariaDescribedBy</code>).
					/// </summary>
					/// <param name="oElement">the element whose accessibility state should be rendered</param>
					/// <returns>this render manager instance to allow chaining</returns>
					public extern virtual sap.ui.core.RenderManager writeAccessibilityState(sap.ui.core.Element oElement);

					/// <summary>
					/// Writes the accessibility state (see WAI-ARIA specification) of the provided element into the HTML based on the element's properties and associations.
					/// 
					/// The ARIA properties are only written when the accessibility feature is activated in the UI5 configuration.
					/// 
					/// The following properties/values to ARIA attribute mappings are done (if the element does have such properties): <ul> <li><code>editable===false</code> => <code>aria-readonly="true"</code></li> <li><code>enabled===false</code> => <code>aria-disabled="true"</code></li> <li><code>visible===false</code> => <code>aria-hidden="true"</code></li> <li><code>required===true</code> => <code>aria-required="true"</code></li> <li><code>selected===true</code> => <code>aria-selected="true"</code></li> <li><code>checked===true</code> => <code>aria-checked="true"</code></li> </ul>
					/// 
					/// In case of the required attribute also the Label controls which referencing the given element in their 'for' relation are taken into account to compute the <code>aria-required</code> attribute.
					/// 
					/// Additionally, the association <code>ariaDescribedBy</code> and <code>ariaLabelledBy</code> are used to write the ID lists of the ARIA attributes <code>aria-describedby</code> and <code>aria-labelledby</code>.
					/// 
					/// Label controls that reference the given element in their 'for' relation are automatically added to the <code>aria-labelledby</code> attributes.
					/// 
					/// Note: This function is only a heuristic of a control property to ARIA attribute mapping. Control developers have to check whether it fulfills their requirements. In case of problems (for example the RadioButton has a <code>selected</code> property but must provide an <code>aria-checked</code> attribute) the auto-generated result of this function can be influenced via the parameter <code>mProps</code> as described below.
					/// 
					/// The parameter <code>mProps</code> can be used to either provide additional attributes which should be added and/or to avoid the automatic generation of single ARIA attributes. The 'aria-' prefix will be prepended automatically to the keys (Exception: Attribute 'role' does not get the prefix 'aria-').
					/// 
					/// Examples: <code>{hidden : true}</code> results in <code>aria-hidden="true"</code> independent of the presence or absence of the visibility property. <code>{hidden : null}</code> ensures that no <code>aria-hidden</code> attribute is written independent of the presence or absence of the visibility property. The function behaves in the same way for the associations <code>ariaDescribedBy</code> and <code>ariaLabelledBy</code>. To append additional values to the auto-generated <code>aria-describedby</code> and <code>aria-labelledby</code> attributes the following format can be used: <code>{describedby : {value: "id1 id2", append: true}}</code> => <code>aria-describedby="ida idb id1 id2"</code> (assuming that "ida idb" is the auto-generated part based on the association <code>ariaDescribedBy</code>).
					/// </summary>
					/// <returns>this render manager instance to allow chaining</returns>
					public extern virtual sap.ui.core.RenderManager writeAccessibilityState();

					/// <summary>
					/// Writes the accessibility state (see WAI-ARIA specification) of the provided element into the HTML based on the element's properties and associations.
					/// 
					/// The ARIA properties are only written when the accessibility feature is activated in the UI5 configuration.
					/// 
					/// The following properties/values to ARIA attribute mappings are done (if the element does have such properties): <ul> <li><code>editable===false</code> => <code>aria-readonly="true"</code></li> <li><code>enabled===false</code> => <code>aria-disabled="true"</code></li> <li><code>visible===false</code> => <code>aria-hidden="true"</code></li> <li><code>required===true</code> => <code>aria-required="true"</code></li> <li><code>selected===true</code> => <code>aria-selected="true"</code></li> <li><code>checked===true</code> => <code>aria-checked="true"</code></li> </ul>
					/// 
					/// In case of the required attribute also the Label controls which referencing the given element in their 'for' relation are taken into account to compute the <code>aria-required</code> attribute.
					/// 
					/// Additionally, the association <code>ariaDescribedBy</code> and <code>ariaLabelledBy</code> are used to write the ID lists of the ARIA attributes <code>aria-describedby</code> and <code>aria-labelledby</code>.
					/// 
					/// Label controls that reference the given element in their 'for' relation are automatically added to the <code>aria-labelledby</code> attributes.
					/// 
					/// Note: This function is only a heuristic of a control property to ARIA attribute mapping. Control developers have to check whether it fulfills their requirements. In case of problems (for example the RadioButton has a <code>selected</code> property but must provide an <code>aria-checked</code> attribute) the auto-generated result of this function can be influenced via the parameter <code>mProps</code> as described below.
					/// 
					/// The parameter <code>mProps</code> can be used to either provide additional attributes which should be added and/or to avoid the automatic generation of single ARIA attributes. The 'aria-' prefix will be prepended automatically to the keys (Exception: Attribute 'role' does not get the prefix 'aria-').
					/// 
					/// Examples: <code>{hidden : true}</code> results in <code>aria-hidden="true"</code> independent of the presence or absence of the visibility property. <code>{hidden : null}</code> ensures that no <code>aria-hidden</code> attribute is written independent of the presence or absence of the visibility property. The function behaves in the same way for the associations <code>ariaDescribedBy</code> and <code>ariaLabelledBy</code>. To append additional values to the auto-generated <code>aria-describedby</code> and <code>aria-labelledby</code> attributes the following format can be used: <code>{describedby : {value: "id1 id2", append: true}}</code> => <code>aria-describedby="ida idb id1 id2"</code> (assuming that "ida idb" is the auto-generated part based on the association <code>ariaDescribedBy</code>).
					/// </summary>
					/// <param name="mProps">a map of properties that should be added additionally or changed.</param>
					/// <returns>this render manager instance to allow chaining</returns>
					public extern virtual sap.ui.core.RenderManager writeAccessibilityState(object mProps);

					/// <summary>
					/// Writes the attribute and its value into the HTML.
					/// 
					/// For details about the escaping refer to {@link jQuery.sap.encodeHTML}
					/// </summary>
					/// <param name="sName">Name of the attribute</param>
					/// <param name="vValue">Value of the attribute</param>
					/// <returns>This render manager instance to allow chaining</returns>
					public extern virtual sap.ui.core.RenderManager writeAttribute(string sName, Union<string, int, bool> vValue);

					/// <summary>
					/// Writes the attribute and a value into the HTML, the value will be encoded.
					/// 
					/// The value is properly encoded to avoid XSS attacks.
					/// </summary>
					/// <param name="sName">Name of the attribute</param>
					/// <param name="vValue">Value of the attribute</param>
					/// <returns>This render manager instance to allow chaining</returns>
					public extern virtual sap.ui.core.RenderManager writeAttributeEscaped(string sName, object vValue);

					/// <summary>
					/// Writes and flushes the class collection (all CSS classes added by "addClass()" since the last flush). Also writes the custom style classes added by the application with "addStyleClass(...)". Custom classes are added by default from the currently rendered control. If an oElement is given, this Element's custom style classes are added instead. If oElement === false, no custom style classes are added.
					/// </summary>
					/// <param name="oElement">an Element from which to add custom style classes (instead of adding from the control itself)</param>
					/// <returns>this render manager instance to allow chaining</returns>
					public extern virtual sap.ui.core.RenderManager writeClasses(Union<sap.ui.core.Element, bool> oElement);

					/// <summary>
					/// Writes and flushes the class collection (all CSS classes added by "addClass()" since the last flush). Also writes the custom style classes added by the application with "addStyleClass(...)". Custom classes are added by default from the currently rendered control. If an oElement is given, this Element's custom style classes are added instead. If oElement === false, no custom style classes are added.
					/// </summary>
					/// <returns>this render manager instance to allow chaining</returns>
					public extern virtual sap.ui.core.RenderManager writeClasses();

					/// <summary>
					/// Writes the controls data into the HTML. Control Data consists at least of the id of a control
					/// </summary>
					/// <param name="oControl">the control whose identifying information should be written to the buffer</param>
					/// <returns>this render manager instance to allow chaining</returns>
					public extern virtual sap.ui.core.RenderManager writeControlData(sap.ui.core.Control oControl);

					/// <summary>
					/// Writes the elements data into the HTML. Element Data consists at least of the id of an element
					/// </summary>
					/// <param name="oElement">the element whose identifying information should be written to the buffer</param>
					/// <returns>this render manager instance to allow chaining</returns>
					public extern virtual sap.ui.core.RenderManager writeElementData(sap.ui.core.Element oElement);

					/// <summary>
					/// Escape text for HTML and write it to the buffer.
					/// 
					/// For details about the escaping refer to {@link jQuery.sap.encodeHTML}
					/// </summary>
					/// <param name="sText"></param>
					/// <param name="bLineBreaks">Whether to convert line breaks into <br> tags</param>
					/// <returns>this render manager instance to allow chaining</returns>
					public extern virtual sap.ui.core.RenderManager writeEscaped(object sText, bool bLineBreaks);

					/// <summary>
					/// Writes either an &lt;img&gt; tag for normal URI or a &lt;span&gt; tag with needed properties for an icon URI.
					/// 
					/// Additional classes and attributes can be added to the tag with the second and third parameter. All of the given attributes are escaped for security consideration.
					/// 
					/// When an &lt;img&gt; tag is rendered, the following two attributes are added by default and can be overwritten with corresponding values in the <code>mAttributes</code> parameter: <ul> <li><code>role: "presentation"</code></Li> <li><code>alt: ""</code></li> </ul>
					/// </summary>
					/// <param name="sURI">URI of an image or of an icon registered in {@link sap.ui.core.IconPool}</param>
					/// <param name="aClasses">Additional classes that are added to the rendered tag</param>
					/// <param name="mAttributes">Additional attributes that will be added to the rendered tag</param>
					/// <returns>this render manager instance to allow chaining</returns>
					public extern virtual sap.ui.core.RenderManager writeIcon(sap.ui.core.URI sURI, Union<object[], string> aClasses, object mAttributes);

					/// <summary>
					/// Writes either an &lt;img&gt; tag for normal URI or a &lt;span&gt; tag with needed properties for an icon URI.
					/// 
					/// Additional classes and attributes can be added to the tag with the second and third parameter. All of the given attributes are escaped for security consideration.
					/// 
					/// When an &lt;img&gt; tag is rendered, the following two attributes are added by default and can be overwritten with corresponding values in the <code>mAttributes</code> parameter: <ul> <li><code>role: "presentation"</code></Li> <li><code>alt: ""</code></li> </ul>
					/// </summary>
					/// <param name="sURI">URI of an image or of an icon registered in {@link sap.ui.core.IconPool}</param>
					/// <param name="aClasses">Additional classes that are added to the rendered tag</param>
					/// <returns>this render manager instance to allow chaining</returns>
					public extern virtual sap.ui.core.RenderManager writeIcon(sap.ui.core.URI sURI, Union<object[], string> aClasses);

					/// <summary>
					/// Writes either an &lt;img&gt; tag for normal URI or a &lt;span&gt; tag with needed properties for an icon URI.
					/// 
					/// Additional classes and attributes can be added to the tag with the second and third parameter. All of the given attributes are escaped for security consideration.
					/// 
					/// When an &lt;img&gt; tag is rendered, the following two attributes are added by default and can be overwritten with corresponding values in the <code>mAttributes</code> parameter: <ul> <li><code>role: "presentation"</code></Li> <li><code>alt: ""</code></li> </ul>
					/// </summary>
					/// <param name="sURI">URI of an image or of an icon registered in {@link sap.ui.core.IconPool}</param>
					/// <returns>this render manager instance to allow chaining</returns>
					public extern virtual sap.ui.core.RenderManager writeIcon(sap.ui.core.URI sURI);

					/// <summary>
					/// Writes necessary invisible control/element placeholder data into the HTML.
					/// 
					/// Controls should use this method only if the standard implementation of the RenderManager doesn't fit their needs. That standard implementation renders an invisible &lt;span&gt; element for controls with <code>visible:false</code> to improve re-rendering performance. Due to the fault tolerance of the HTML5 standard, such &lt;span&gt; elements are accepted in many scenarios and won't appear in the render tree of the browser, However, in some cases, controls may need to write a different element when the &lt;span&gt; is not an allowed element (e.g. within the &lt;tr&gt; or &lt;li&gt; group).
					/// 
					/// The caller needs to start an opening HTML tag, then call this method, then complete the opening and closing tag.
					/// 
					/// <pre>
					/// 
					///   oRenderManager.write("&lt;tr");
					///   oRenderManager.writeInvisiblePlaceholderData(oControl);
					///   oRenderManager.write("&gt;&lt;/tr");
					/// 
					/// </pre>
					/// </summary>
					/// <param name="oElement">An instance of sap.ui.core.Element</param>
					/// <returns>This render manager instance to allow chaining</returns>
					public extern virtual sap.ui.core.RenderManager writeInvisiblePlaceholderData(sap.ui.core.Element oElement);

					/// <summary>
					/// Writes and flushes the style collection
					/// </summary>
					/// <returns>this render manager instance to allow chaining</returns>
					public extern virtual sap.ui.core.RenderManager writeStyles();

					#endregion

				}
			}
		}
	}
}
