using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace OpenUI5Sharp
{
	public static partial class sap
	{
		public static partial class ui
		{
			public static partial class layout
			{
				/// <summary>
				/// Layout control that allows additional (side) content to be displayed dynamically.
				/// 
				/// <h3>Overview</h3>
				/// 
				/// <code>DynamicSideContent</code> is a layout control that allows additional content to be displayed in a way that flexibly adapts to different screen sizes. The side content appears in a container next to or directly below the main content (it doesn't overlay). When the side content is triggered, the main content becomes narrower (if appearing side-by-side). The side content contains a separate scrollbar when appearing next to the main content.
				/// 
				/// <h3>Usage</h3>
				/// 
				/// <i>When to use?</i>
				/// 
				/// Use this control if you want to display relevant information that is not critical for users to complete a task. Users should have access to all the key functions and critical information in the app even if they do not see the side content. This is important because on smaller screen sizes it may be difficult to display the side content in a way that is easily accessible for the user.
				/// 
				/// <i>When not to use?</i>
				/// 
				/// Don't use it if you want to display navigation or critical information that prevents users from completing a task when they have no access to the side content.
				/// 
				/// <h3>Responsive Behavior</h3>
				/// 
				/// Screen width > 1440 px
				/// 
				/// <ul><li>Main vs. side content ratio is 75 vs. 25 percent (with a minimum of 320px each).</li> <li>If the application defines a trigger, the side content can be hidden.</li></ul>
				/// 
				/// Screen width <= 1440 px and > 720px
				/// 
				/// <ul><li>Main vs. side content ratio is 66.666 vs. 33.333 percent (with a minimum of 320px each). If the side content width falls below 320 px, it automatically slides under the main content, unless the app development team specifies that it should disappear.</li></ul>
				/// 
				/// Screen width <= 720 px (for example on a mobile device)
				/// 
				/// <ul><li>In this case, the side content automatically disappears from the screen (unless specified to stay under the content) and can be triggered from a pre-set trigger (specified within the app). When the side content is triggered, it replaces the main content. We recommend that you always place the trigger for the side content in the same location, such as in the app footer.</li></ul>
				/// 
				/// A special case, allows for comparison mode between the main and side content. In this case, the screen is split into 50:50 percent for main vs. side content. The responsive behavior of the equal split is the same as in the standard view - the side content disappears on screen widths of less than 720 px and can only be viewed by triggering it.
				/// </summary>
				[External]
				[Namespace(false)]
				public partial class DynamicSideContent : sap.ui.core.Control
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
						/// Determines whether the side content is visible or hidden.
						/// </summary>
						public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> showSideContent;

						/// <summary>
						/// Determines whether the main content is visible or hidden.
						/// </summary>
						public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> showMainContent;

						/// <summary>
						/// Determines on which breakpoints the side content is visible.
						/// </summary>
						public Union<sap.ui.layout.SideContentVisibility, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> sideContentVisibility;

						/// <summary>
						/// Determines on which breakpoints the side content falls down below the main content.
						/// </summary>
						public Union<sap.ui.layout.SideContentFallDown, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> sideContentFallDown;

						/// <summary>
						/// Defines whether the control is in equal split mode. In this mode, the side and the main content take 50:50 percent of the container on all screen sizes except for phone, where the main and side contents are switching visibility using the toggle method.
						/// </summary>
						public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> equalSplit;

						/// <summary>
						/// If set to TRUE, then not the media Query (device screen size) but the size of the container, surrounding the control, defines the current range.
						/// </summary>
						public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> containerQuery;

						/// <summary>
						/// Determines whether the side content is on the left or on the right side of the main content.
						/// </summary>
						public Union<sap.ui.layout.SideContentPosition, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> sideContentPosition;

						/// <summary>
						/// Main content controls.
						/// </summary>
						public Union<sap.ui.core.Control[], string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> mainContent;

						/// <summary>
						/// Side content controls.
						/// </summary>
						public Union<sap.ui.core.Control[], string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> sideContent;

						/// <summary>
						/// Fires when the current breakpoint has been changed.
						/// </summary>
						public sap.ui.layout.DynamicSideContent.BreakpointChangedDelegate breakpointChanged;

					}

					#endregion

					#region Typed Parameters

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class BreakpointChangedInfo
					{
						public string currentBreakpoint;

					}

					#endregion

					#region Delegates

					public delegate void BreakpointChangedDelegate(sap.ui.@base.Event<sap.ui.layout.DynamicSideContent.BreakpointChangedInfo> oEvent, object oData);

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new <code>DynamicSideContent</code>.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern DynamicSideContent(string sId, sap.ui.layout.DynamicSideContent.Settings mSettings);

					/// <summary>
					/// Constructor for a new <code>DynamicSideContent</code>.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					public extern DynamicSideContent(string sId);

					/// <summary>
					/// Constructor for a new <code>DynamicSideContent</code>.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern DynamicSideContent();

					/// <summary>
					/// Constructor for a new <code>DynamicSideContent</code>.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern DynamicSideContent(sap.ui.layout.DynamicSideContent.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property showSideContent

					/// <summary>
					/// Gets the value of showSideContent property.
					/// </summary>
					/// <returns>Side content visibility state</returns>
					public extern virtual bool getShowSideContent();

					/// <summary>
					/// Sets the showSideContent property.
					/// </summary>
					/// <param name="bVisible">Determines if the side content part is visible</param>
					/// <param name="bSuppressVisualUpdate">Determines if the visual state is updated</param>
					/// <returns>this pointer for chaining</returns>
					public extern virtual sap.ui.layout.DynamicSideContent setShowSideContent(bool bVisible, bool bSuppressVisualUpdate);

					#endregion

					#region Methods for Property showMainContent

					/// <summary>
					/// Gets the value of showMainContent property.
					/// </summary>
					/// <returns>Side content visibility state</returns>
					public extern virtual bool getShowMainContent();

					/// <summary>
					/// Sets the showMainContent property.
					/// </summary>
					/// <param name="bVisible">Determines if the main content part is visible</param>
					/// <param name="bSuppressVisualUpdate">Determines if the visual state is updated</param>
					/// <returns>this pointer for chaining</returns>
					public extern virtual sap.ui.layout.DynamicSideContent setShowMainContent(bool bVisible, bool bSuppressVisualUpdate);

					#endregion

					#region Methods for Property sideContentVisibility

					/// <summary>
					/// Gets current value of property {@link #getSideContentVisibility sideContentVisibility}.
					/// 
					/// Determines on which breakpoints the side content is visible.
					/// 
					/// Default value is <code>ShowAboveS</code>.
					/// </summary>
					/// <returns>Value of property <code>sideContentVisibility</code></returns>
					public extern virtual sap.ui.layout.SideContentVisibility getSideContentVisibility();

					/// <summary>
					/// Sets the sideContentVisibility property.
					/// </summary>
					/// <param name="sVisibility">Determines on which breakpoints the side content is visible.</param>
					/// <param name="bSuppressVisualUpdate">Determines if the visual state is updated</param>
					/// <returns>this pointer for chaining</returns>
					public extern virtual sap.ui.layout.DynamicSideContent setSideContentVisibility(sap.ui.layout.SideContentVisibility sVisibility, bool bSuppressVisualUpdate);

					#endregion

					#region Methods for Property sideContentFallDown

					/// <summary>
					/// Gets current value of property {@link #getSideContentFallDown sideContentFallDown}.
					/// 
					/// Determines on which breakpoints the side content falls down below the main content.
					/// 
					/// Default value is <code>OnMinimumWidth</code>.
					/// </summary>
					/// <returns>Value of property <code>sideContentFallDown</code></returns>
					public extern virtual sap.ui.layout.SideContentFallDown getSideContentFallDown();

					/// <summary>
					/// Sets a new value for property {@link #getSideContentFallDown sideContentFallDown}.
					/// 
					/// Determines on which breakpoints the side content falls down below the main content.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>OnMinimumWidth</code>.
					/// </summary>
					/// <param name="sSideContentFallDown">New value for property <code>sideContentFallDown</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.DynamicSideContent setSideContentFallDown(sap.ui.layout.SideContentFallDown sSideContentFallDown);

					#endregion

					#region Methods for Property equalSplit

					/// <summary>
					/// Gets current value of property {@link #getEqualSplit equalSplit}.
					/// 
					/// Defines whether the control is in equal split mode. In this mode, the side and the main content take 50:50 percent of the container on all screen sizes except for phone, where the main and side contents are switching visibility using the toggle method.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>equalSplit</code></returns>
					public extern virtual bool getEqualSplit();

					/// <summary>
					/// Sets or unsets the page in equalSplit mode.
					/// </summary>
					/// <param name="bState">Determines if the page is set to equalSplit mode</param>
					/// <returns>this pointer for chaining</returns>
					public extern virtual sap.ui.layout.DynamicSideContent setEqualSplit(bool bState);

					/// <summary>
					/// Sets or unsets the page in equalSplit mode.
					/// </summary>
					/// <returns>this pointer for chaining</returns>
					public extern virtual sap.ui.layout.DynamicSideContent setEqualSplit();

					#endregion

					#region Methods for Property containerQuery

					/// <summary>
					/// Gets current value of property {@link #getContainerQuery containerQuery}.
					/// 
					/// If set to TRUE, then not the media Query (device screen size) but the size of the container, surrounding the control, defines the current range.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>containerQuery</code></returns>
					public extern virtual bool getContainerQuery();

					/// <summary>
					/// Sets a new value for property {@link #getContainerQuery containerQuery}.
					/// 
					/// If set to TRUE, then not the media Query (device screen size) but the size of the container, surrounding the control, defines the current range.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bContainerQuery">New value for property <code>containerQuery</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.DynamicSideContent setContainerQuery(bool bContainerQuery);

					#endregion

					#region Methods for Property sideContentPosition

					/// <summary>
					/// Gets current value of property {@link #getSideContentPosition sideContentPosition}.
					/// 
					/// Determines whether the side content is on the left or on the right side of the main content.
					/// 
					/// Default value is <code>End</code>.
					/// </summary>
					/// <returns>Value of property <code>sideContentPosition</code></returns>
					public extern virtual sap.ui.layout.SideContentPosition getSideContentPosition();

					/// <summary>
					/// Sets a new value for property {@link #getSideContentPosition sideContentPosition}.
					/// 
					/// Determines whether the side content is on the left or on the right side of the main content.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>End</code>.
					/// </summary>
					/// <param name="sSideContentPosition">New value for property <code>sideContentPosition</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.DynamicSideContent setSideContentPosition(sap.ui.layout.SideContentPosition sSideContentPosition);

					#endregion

					#region Methods for Aggregation mainContent

					/// <summary>
					/// Gets content of aggregation {@link #getMainContent mainContent}.
					/// 
					/// Main content controls.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.Control[] getMainContent();

					/// <summary>
					/// Destroys all the mainContent in the aggregation {@link #getMainContent mainContent}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.DynamicSideContent destroyMainContent();

					/// <summary>
					/// Inserts a mainContent into the aggregation {@link #getMainContent mainContent}.
					/// </summary>
					/// <param name="oMainContent">The mainContent to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the mainContent should be inserted at; for a negative value of <code>iIndex</code>, the mainContent is inserted at position 0; for a value greater than the current size of the aggregation, the mainContent is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.DynamicSideContent insertMainContent(sap.ui.core.Control oMainContent, int iIndex);

					/// <summary>
					/// Adds a control to the main content area. Only the main content part in the aggregation is re-rendered.
					/// </summary>
					/// <param name="oControl">Object to be added in the aggregation</param>
					/// <returns>this pointer for chaining</returns>
					public extern virtual sap.ui.layout.DynamicSideContent addMainContent(object oControl);

					/// <summary>
					/// Removes a mainContent from the aggregation {@link #getMainContent mainContent}.
					/// </summary>
					/// <param name="vMainContent">The mainContent to remove or its index or id</param>
					/// <returns>The removed mainContent or <code>null</code></returns>
					public extern virtual sap.ui.core.Control removeMainContent(Union<int, string, sap.ui.core.Control> vMainContent);

					/// <summary>
					/// Checks for the provided <code>sap.ui.core.Control</code> in the aggregation {@link #getMainContent mainContent}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oMainContent">The mainContent whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfMainContent(sap.ui.core.Control oMainContent);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getMainContent mainContent}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.core.Control[] removeAllMainContent();

					#endregion

					#region Methods for Aggregation sideContent

					/// <summary>
					/// Gets content of aggregation {@link #getSideContent sideContent}.
					/// 
					/// Side content controls.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.Control[] getSideContent();

					/// <summary>
					/// Destroys all the sideContent in the aggregation {@link #getSideContent sideContent}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.DynamicSideContent destroySideContent();

					/// <summary>
					/// Inserts a sideContent into the aggregation {@link #getSideContent sideContent}.
					/// </summary>
					/// <param name="oSideContent">The sideContent to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the sideContent should be inserted at; for a negative value of <code>iIndex</code>, the sideContent is inserted at position 0; for a value greater than the current size of the aggregation, the sideContent is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.DynamicSideContent insertSideContent(sap.ui.core.Control oSideContent, int iIndex);

					/// <summary>
					/// Adds a control to the side content area. Only the side content part in the aggregation is re-rendered.
					/// </summary>
					/// <param name="oControl">Object to be added in the aggregation</param>
					/// <returns>this pointer for chaining</returns>
					public extern virtual sap.ui.layout.DynamicSideContent addSideContent(object oControl);

					/// <summary>
					/// Removes a sideContent from the aggregation {@link #getSideContent sideContent}.
					/// </summary>
					/// <param name="vSideContent">The sideContent to remove or its index or id</param>
					/// <returns>The removed sideContent or <code>null</code></returns>
					public extern virtual sap.ui.core.Control removeSideContent(Union<int, string, sap.ui.core.Control> vSideContent);

					/// <summary>
					/// Checks for the provided <code>sap.ui.core.Control</code> in the aggregation {@link #getSideContent sideContent}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oSideContent">The sideContent whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfSideContent(sap.ui.core.Control oSideContent);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getSideContent sideContent}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.core.Control[] removeAllSideContent();

					#endregion

					#region Methods for Event breakpointChanged

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:breakpointChanged breakpointChanged} event of this <code>sap.ui.layout.DynamicSideContent</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.layout.DynamicSideContent</code> itself.
					/// 
					/// Fires when the current breakpoint has been changed.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.layout.DynamicSideContent</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.DynamicSideContent attachBreakpointChanged(object oData, sap.ui.layout.DynamicSideContent.BreakpointChangedDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:breakpointChanged breakpointChanged} event of this <code>sap.ui.layout.DynamicSideContent</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.layout.DynamicSideContent</code> itself.
					/// 
					/// Fires when the current breakpoint has been changed.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.DynamicSideContent attachBreakpointChanged(object oData, sap.ui.layout.DynamicSideContent.BreakpointChangedDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:breakpointChanged breakpointChanged} event of this <code>sap.ui.layout.DynamicSideContent</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.layout.DynamicSideContent</code> itself.
					/// 
					/// Fires when the current breakpoint has been changed.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.DynamicSideContent attachBreakpointChanged(sap.ui.layout.DynamicSideContent.BreakpointChangedDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:breakpointChanged breakpointChanged} event of this <code>sap.ui.layout.DynamicSideContent</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.layout.DynamicSideContent</code> itself.
					/// 
					/// Fires when the current breakpoint has been changed.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.layout.DynamicSideContent</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.DynamicSideContent attachBreakpointChanged(sap.ui.layout.DynamicSideContent.BreakpointChangedDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:breakpointChanged breakpointChanged} event of this <code>sap.ui.layout.DynamicSideContent</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.DynamicSideContent detachBreakpointChanged(sap.ui.layout.DynamicSideContent.BreakpointChangedDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:breakpointChanged breakpointChanged} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.DynamicSideContent fireBreakpointChanged(sap.ui.layout.DynamicSideContent.BreakpointChangedInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:breakpointChanged breakpointChanged} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.DynamicSideContent fireBreakpointChanged();

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.layout.DynamicSideContent with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.layout.DynamicSideContent with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.layout.DynamicSideContent with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns the breakpoint for the current state of the control.
					/// </summary>
					/// <returns>currentBreakpoint</returns>
					public extern virtual string getCurrentBreakpoint();

					/// <summary>
					/// Returns a metadata object for class sap.ui.layout.DynamicSideContent.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					/// <summary>
					/// Used for the toggle button functionality. When the control is on a phone screen size only, one control area is visible. This helper method is used to implement a button/switch for changing between the main and side content areas. Only works if the current breakpoint is "S".
					/// </summary>
					/// <returns>this pointer for chaining</returns>
					public extern virtual sap.ui.layout.DynamicSideContent toggle();

					#endregion

					#endregion

				}
			}
		}
	}
}
