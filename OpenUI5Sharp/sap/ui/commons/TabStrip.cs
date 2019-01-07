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
			public static partial class commons
			{
				/// <summary>
				/// TabStrip represents a container for tab controls, which contain the content and generally other controls. The user switches between the tabs to display the content.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.TabStrip")]
				[Obsolete("Deprecated since 1.38. Instead, use the <code>sap.m.TabContainer</code> control.")]
				public partial class TabStrip : sap.ui.core.Control
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
						/// Specifies the height of the tab bar and content area.
						/// </summary>
						public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> height;

						/// <summary>
						/// Specifies the width of the bar and content area.
						/// </summary>
						public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> width;

						/// <summary>
						/// Specifies the index of the currently selected tab.
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> selectedIndex;

						/// <summary>
						/// Specifies whether tab reordering is enabled.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> enableTabReordering;

						/// <summary>
						/// The tabs contained in the TabStrip.
						/// </summary>
						public Union<sap.ui.commons.Tab[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> tabs;

						/// <summary>
						/// Fires when the user selects a tab.
						/// </summary>
						public sap.m.IndexDelegate select;

						/// <summary>
						/// Fires when the user closes a tab.
						/// </summary>
						public sap.m.IndexDelegate close;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new TabStrip.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern TabStrip(string sId, sap.ui.commons.TabStrip.Settings mSettings);

					/// <summary>
					/// Constructor for a new TabStrip.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					public extern TabStrip(string sId);

					/// <summary>
					/// Constructor for a new TabStrip.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern TabStrip();

					/// <summary>
					/// Constructor for a new TabStrip.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern TabStrip(sap.ui.commons.TabStrip.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property height

					/// <summary>
					/// Gets current value of property {@link #getHeight height}.
					/// 
					/// Specifies the height of the tab bar and content area.
					/// </summary>
					/// <returns>Value of property <code>height</code></returns>
					public extern virtual sap.ui.core.CSSSize getHeight();

					/// <summary>
					/// Sets a new value for property {@link #getHeight height}.
					/// 
					/// Specifies the height of the tab bar and content area.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sHeight">New value for property <code>height</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TabStrip setHeight(sap.ui.core.CSSSize sHeight);

					#endregion

					#region Methods for Property width

					/// <summary>
					/// Gets current value of property {@link #getWidth width}.
					/// 
					/// Specifies the width of the bar and content area.
					/// </summary>
					/// <returns>Value of property <code>width</code></returns>
					public extern virtual sap.ui.core.CSSSize getWidth();

					/// <summary>
					/// Sets a new value for property {@link #getWidth width}.
					/// 
					/// Specifies the width of the bar and content area.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sWidth">New value for property <code>width</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TabStrip setWidth(sap.ui.core.CSSSize sWidth);

					#endregion

					#region Methods for Property selectedIndex

					/// <summary>
					/// Gets current value of property {@link #getSelectedIndex selectedIndex}.
					/// 
					/// Specifies the index of the currently selected tab.
					/// 
					/// Default value is <code>0</code>.
					/// </summary>
					/// <returns>Value of property <code>selectedIndex</code></returns>
					public extern virtual int getSelectedIndex();

					/// <summary>
					/// Sets a new value for property {@link #getSelectedIndex selectedIndex}.
					/// 
					/// Specifies the index of the currently selected tab.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>0</code>.
					/// </summary>
					/// <param name="iSelectedIndex">New value for property <code>selectedIndex</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TabStrip setSelectedIndex(int iSelectedIndex);

					#endregion

					#region Methods for Property enableTabReordering

					/// <summary>
					/// Gets current value of property {@link #getEnableTabReordering enableTabReordering}.
					/// 
					/// Specifies whether tab reordering is enabled.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>enableTabReordering</code></returns>
					public extern virtual bool getEnableTabReordering();

					/// <summary>
					/// Sets whether tab reordering is enabled.
					/// </summary>
					/// <param name="bValue">The value.</param>
					/// <returns>Pointer to the control instance for chaining.</returns>
					public extern virtual sap.ui.commons.TabStrip setEnableTabReordering(bool bValue);

					#endregion

					#region Methods for Aggregation tabs

					/// <summary>
					/// Gets content of aggregation {@link #getTabs tabs}.
					/// 
					/// The tabs contained in the TabStrip.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.commons.Tab[] getTabs();

					/// <summary>
					/// Destroys all the tabs in the aggregation {@link #getTabs tabs}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TabStrip destroyTabs();

					/// <summary>
					/// Inserts a tab into the aggregation {@link #getTabs tabs}.
					/// </summary>
					/// <param name="oTab">The tab to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the tab should be inserted at; for a negative value of <code>iIndex</code>, the tab is inserted at position 0; for a value greater than the current size of the aggregation, the tab is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TabStrip insertTab(sap.ui.commons.Tab oTab, int iIndex);

					/// <summary>
					/// Adds some tab to the aggregation {@link #getTabs tabs}.
					/// </summary>
					/// <param name="oTab">The tab to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TabStrip addTab(sap.ui.commons.Tab oTab);

					/// <summary>
					/// Removes a tab from the aggregation {@link #getTabs tabs}.
					/// </summary>
					/// <param name="vTab">The tab to remove or its index or id</param>
					/// <returns>The removed tab or <code>null</code></returns>
					public extern virtual sap.ui.commons.Tab removeTab(Union<int, string, sap.ui.commons.Tab> vTab);

					/// <summary>
					/// Checks for the provided <code>sap.ui.commons.Tab</code> in the aggregation {@link #getTabs tabs}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oTab">The tab whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfTab(sap.ui.commons.Tab oTab);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getTabs tabs}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.commons.Tab[] removeAllTabs();

					#endregion

					#region Methods for Aggregation _leftArrowControl

					#endregion

					#region Methods for Aggregation _rightArrowControl

					#endregion

					#region Methods for Event select

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.ui.commons.TabStrip</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.TabStrip</code> itself.
					/// 
					/// Fires when the user selects a tab.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.TabStrip</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TabStrip attachSelect(object oData, sap.m.IndexDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.ui.commons.TabStrip</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.TabStrip</code> itself.
					/// 
					/// Fires when the user selects a tab.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TabStrip attachSelect(object oData, sap.m.IndexDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.ui.commons.TabStrip</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.TabStrip</code> itself.
					/// 
					/// Fires when the user selects a tab.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TabStrip attachSelect(sap.m.IndexDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.ui.commons.TabStrip</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.TabStrip</code> itself.
					/// 
					/// Fires when the user selects a tab.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.TabStrip</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TabStrip attachSelect(sap.m.IndexDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:select select} event of this <code>sap.ui.commons.TabStrip</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TabStrip detachSelect(sap.m.IndexDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:select select} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TabStrip fireSelect(sap.m.IndexInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:select select} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TabStrip fireSelect();

					#endregion

					#region Methods for Event close

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:close close} event of this <code>sap.ui.commons.TabStrip</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.TabStrip</code> itself.
					/// 
					/// Fires when the user closes a tab.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.TabStrip</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TabStrip attachClose(object oData, sap.m.IndexDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:close close} event of this <code>sap.ui.commons.TabStrip</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.TabStrip</code> itself.
					/// 
					/// Fires when the user closes a tab.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TabStrip attachClose(object oData, sap.m.IndexDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:close close} event of this <code>sap.ui.commons.TabStrip</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.TabStrip</code> itself.
					/// 
					/// Fires when the user closes a tab.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TabStrip attachClose(sap.m.IndexDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:close close} event of this <code>sap.ui.commons.TabStrip</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.TabStrip</code> itself.
					/// 
					/// Fires when the user closes a tab.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.TabStrip</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TabStrip attachClose(sap.m.IndexDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:close close} event of this <code>sap.ui.commons.TabStrip</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TabStrip detachClose(sap.m.IndexDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:close close} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TabStrip fireClose(sap.m.IndexInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:close close} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TabStrip fireClose();

					#endregion

					#region Other methods

					/// <summary>
					/// Closes a tab (if the tab is selected, the next one will be selected; if it's the last tab, the previous one will be selected).
					/// 
					/// This method should be called if the close event is fired. It can not be called automatically because the consumer might need to run some logic before the tab is closed.
					/// </summary>
					/// <param name="iIndex">The index of the tab that should be closed</param>
					public extern virtual void closeTab(int iIndex);

					/// <summary>
					/// Creates a Tab and adds it to the TabStrip.
					/// </summary>
					/// <param name="sText">Defines the title text of the newly created tab</param>
					/// <param name="oContent">Defines the root control of the content area</param>
					/// <returns>oTab The created tab control</returns>
					public extern virtual sap.ui.commons.Tab createTab(string sText, sap.ui.core.Control oContent);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.TabStrip with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.TabStrip with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.TabStrip with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.commons.TabStrip.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					[Name("getMetadata")]
					public extern static sap.ui.@base.Metadata getMetadataStatic();

					/// <summary>
					/// Called before the rendering of the control is started.
					/// </summary>
					public extern override void onBeforeRendering();

					#endregion

					#endregion

				}
			}
		}
	}
}
