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
			public static partial class unified
			{
				/// <summary>
				/// The shell layout is the base for the shell control which is meant as root control (full-screen) of an application. It was build as root control of the Fiori Launchpad application and provides the basic capabilities for this purpose. Do not use this control within applications which run inside the Fiori Lauchpad and do not use it for other scenarios than the root control usecase.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.unified.ShellLayout")]
				[Obsolete("Deprecated since 1.44.0.")]
				public partial class ShellLayout : sap.ui.core.Control
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
						/// Shows / Hides the side pane.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showPane;

						/// <summary>
						/// Whether the header can be hidden (manually or automatically). This feature is only available when touch events are supported.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> headerHiding;

						/// <summary>
						/// If set to false, no header (and no items, search, ...) is shown.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> headerVisible;

						/// <summary>
						/// The content to appear in the main canvas.
						/// </summary>
						public Union<sap.ui.core.Control[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> content;

						/// <summary>
						/// The content to appear in the pane area.
						/// </summary>
						public Union<sap.ui.core.Control[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> paneContent;

						/// <summary>
						/// The control to appear in the header area.
						/// </summary>
						public Union<sap.ui.core.Control, string, sap.ui.@base.ManagedObject.BindAggregationInfo> header;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new ShellLayout.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern ShellLayout(string sId, sap.ui.unified.ShellLayout.Settings mSettings);

					/// <summary>
					/// Constructor for a new ShellLayout.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern ShellLayout(string sId);

					/// <summary>
					/// Constructor for a new ShellLayout.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern ShellLayout();

					/// <summary>
					/// Constructor for a new ShellLayout.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern ShellLayout(sap.ui.unified.ShellLayout.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property showPane

					/// <summary>
					/// Gets current value of property {@link #getShowPane showPane}.
					/// 
					/// Shows / Hides the side pane.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>showPane</code></returns>
					public extern virtual bool getShowPane();

					/// <summary>
					/// Sets a new value for property {@link #getShowPane showPane}.
					/// 
					/// Shows / Hides the side pane.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bShowPane">New value for property <code>showPane</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.ShellLayout setShowPane(bool bShowPane);

					#endregion

					#region Methods for Property headerHiding

					/// <summary>
					/// Gets current value of property {@link #getHeaderHiding headerHiding}.
					/// 
					/// Whether the header can be hidden (manually or automatically). This feature is only available when touch events are supported.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>headerHiding</code></returns>
					public extern virtual bool getHeaderHiding();

					/// <summary>
					/// Sets a new value for property {@link #getHeaderHiding headerHiding}.
					/// 
					/// Whether the header can be hidden (manually or automatically). This feature is only available when touch events are supported.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bHeaderHiding">New value for property <code>headerHiding</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.ShellLayout setHeaderHiding(bool bHeaderHiding);

					#endregion

					#region Methods for Property headerVisible

					/// <summary>
					/// Gets current value of property {@link #getHeaderVisible headerVisible}.
					/// 
					/// If set to false, no header (and no items, search, ...) is shown.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>headerVisible</code></returns>
					public extern virtual bool getHeaderVisible();

					/// <summary>
					/// Sets a new value for property {@link #getHeaderVisible headerVisible}.
					/// 
					/// If set to false, no header (and no items, search, ...) is shown.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bHeaderVisible">New value for property <code>headerVisible</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.ShellLayout setHeaderVisible(bool bHeaderVisible);

					#endregion

					#region Methods for Aggregation content

					/// <summary>
					/// Gets content of aggregation {@link #getContent content}.
					/// 
					/// The content to appear in the main canvas.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.Control[] getContent();

					/// <summary>
					/// Destroys all the content in the aggregation {@link #getContent content}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.ShellLayout destroyContent();

					/// <summary>
					/// Inserts a content into the aggregation {@link #getContent content}.
					/// </summary>
					/// <param name="oContent">The content to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the content should be inserted at; for a negative value of <code>iIndex</code>, the content is inserted at position 0; for a value greater than the current size of the aggregation, the content is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.ShellLayout insertContent(sap.ui.core.Control oContent, int iIndex);

					/// <summary>
					/// Adds some content to the aggregation {@link #getContent content}.
					/// </summary>
					/// <param name="oContent">The content to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.ShellLayout addContent(sap.ui.core.Control oContent);

					/// <summary>
					/// Removes a content from the aggregation {@link #getContent content}.
					/// </summary>
					/// <param name="vContent">The content to remove or its index or id</param>
					/// <returns>The removed content or <code>null</code></returns>
					public extern virtual sap.ui.core.Control removeContent(Union<int, string, sap.ui.core.Control> vContent);

					/// <summary>
					/// Checks for the provided <code>sap.ui.core.Control</code> in the aggregation {@link #getContent content}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oContent">The content whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfContent(sap.ui.core.Control oContent);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getContent content}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.core.Control[] removeAllContent();

					#endregion

					#region Methods for Aggregation paneContent

					/// <summary>
					/// Gets content of aggregation {@link #getPaneContent paneContent}.
					/// 
					/// The content to appear in the pane area.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.Control[] getPaneContent();

					/// <summary>
					/// Destroys all the paneContent in the aggregation {@link #getPaneContent paneContent}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.ShellLayout destroyPaneContent();

					/// <summary>
					/// Inserts a paneContent into the aggregation {@link #getPaneContent paneContent}.
					/// </summary>
					/// <param name="oPaneContent">The paneContent to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the paneContent should be inserted at; for a negative value of <code>iIndex</code>, the paneContent is inserted at position 0; for a value greater than the current size of the aggregation, the paneContent is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.ShellLayout insertPaneContent(sap.ui.core.Control oPaneContent, int iIndex);

					/// <summary>
					/// Adds some paneContent to the aggregation {@link #getPaneContent paneContent}.
					/// </summary>
					/// <param name="oPaneContent">The paneContent to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.ShellLayout addPaneContent(sap.ui.core.Control oPaneContent);

					/// <summary>
					/// Removes a paneContent from the aggregation {@link #getPaneContent paneContent}.
					/// </summary>
					/// <param name="vPaneContent">The paneContent to remove or its index or id</param>
					/// <returns>The removed paneContent or <code>null</code></returns>
					public extern virtual sap.ui.core.Control removePaneContent(Union<int, string, sap.ui.core.Control> vPaneContent);

					/// <summary>
					/// Checks for the provided <code>sap.ui.core.Control</code> in the aggregation {@link #getPaneContent paneContent}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oPaneContent">The paneContent whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfPaneContent(sap.ui.core.Control oPaneContent);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getPaneContent paneContent}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.core.Control[] removeAllPaneContent();

					#endregion

					#region Methods for Aggregation header

					/// <summary>
					/// Gets content of aggregation {@link #getHeader header}.
					/// 
					/// The control to appear in the header area.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.Control getHeader();

					/// <summary>
					/// Destroys the header in the aggregation {@link #getHeader header}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.ShellLayout destroyHeader();

					/// <summary>
					/// Sets the aggregated {@link #getHeader header}.
					/// </summary>
					/// <param name="oHeader">The header to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.ShellLayout setHeader(sap.ui.core.Control oHeader);

					#endregion

					#region Methods for Aggregation canvasSplitContainer

					#endregion

					#region Methods for Aggregation curtainSplitContainer

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.unified.ShellLayout with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.unified.ShellLayout with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.unified.ShellLayout with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.unified.ShellLayout.
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
