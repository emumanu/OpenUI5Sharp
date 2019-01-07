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
			public static partial class layout
			{
				/// <summary>
				/// A layout that contains several content areas. The content that is added to the splitter should contain LayoutData of the type SplitterLayoutData that defines its size and size contraints.
				/// 
				/// By adding or changing SplitterLayoutData to the controls that make up the content areas, the size can be changed programatically. Additionally the contents can be made non-resizable individually and a minimal size (in px) can be set.
				/// 
				/// The orientation of the splitter can be set to horizontal (default) or vertical. All content areas of the splitter will be arranged in that way. In order to split vertically and horizontally at the same time, Splitters need to be nested.
				/// 
				/// The splitter bars can be focused to enable resizing of the content areas via keyboard. The contents size can be manipulated when the splitter bar is focused and Shift-Left/Down/Right/Up are pressed. When Shift-Home/End are pressed, the contents are set their minimum or maximum size (keep in mind though, that resizing an auto-size content-area next to another auto-size one might lead to the effect that the former does not take its maximum size but only the maximum size before recalculating auto sizes).
				/// 
				/// The splitter bars used for resizing the contents by the user can be set to different widths (or heights in vertical mode) and the splitter will automatically resize the other contents accordingly. In case the splitter bar is resized after the splitter has rendered, a manual resize has to be triggered by invoking triggerResize() on the Splitter.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.layout.Splitter")]
				public partial class Splitter : sap.ui.core.Control
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
						/// Whether to split the contents horizontally (default) or vertically.
						/// </summary>
						public Union<sap.ui.core.Orientation, string, sap.ui.@base.ManagedObject.BindPropertyInfo> orientation;

						/// <summary>
						/// The width of the control
						/// </summary>
						public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> width;

						/// <summary>
						/// The height of the control
						/// </summary>
						public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> height;

						/// <summary>
						/// The content areas to be split. The control will show n-1 splitter bars between n controls in this aggregation.
						/// </summary>
						public Union<sap.ui.core.Control[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> contentAreas;

						/// <summary>
						/// Event is fired when contents are resized.
						/// </summary>
						public sap.ui.layout.Splitter.ResizeDelegate resize;

					}

					#endregion

					#region Typed Parameters

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class ResizeInfo
					{
						/// <summary>
						/// The ID of the splitter control. The splitter control can also be accessed by calling getSource() on the event.
						/// </summary>
						public string id;

						/// <summary>
						/// An array of values representing the old (pixel-)sizes of the splitter contents
						/// </summary>
						public int[] oldSizes;

						/// <summary>
						/// An array of values representing the new (pixel-)sizes of the splitter contents
						/// </summary>
						public int[] newSizes;

					}

					#endregion

					#region Delegates

					public delegate void ResizeDelegate(sap.ui.@base.Event<sap.ui.layout.Splitter.ResizeInfo> oEvent, object oData);

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new Splitter.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern Splitter(string sId, sap.ui.layout.Splitter.Settings mSettings);

					/// <summary>
					/// Constructor for a new Splitter.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern Splitter(string sId);

					/// <summary>
					/// Constructor for a new Splitter.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern Splitter();

					/// <summary>
					/// Constructor for a new Splitter.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern Splitter(sap.ui.layout.Splitter.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property orientation

					/// <summary>
					/// Gets current value of property {@link #getOrientation orientation}.
					/// 
					/// Whether to split the contents horizontally (default) or vertically.
					/// 
					/// Default value is <code>Horizontal</code>.
					/// </summary>
					/// <returns>Value of property <code>orientation</code></returns>
					public extern virtual sap.ui.core.Orientation getOrientation();

					/// <summary>
					/// Sets a new value for property {@link #getOrientation orientation}.
					/// 
					/// Whether to split the contents horizontally (default) or vertically.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>Horizontal</code>.
					/// </summary>
					/// <param name="sOrientation">New value for property <code>orientation</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.Splitter setOrientation(sap.ui.core.Orientation sOrientation);

					#endregion

					#region Methods for Property width

					/// <summary>
					/// Gets current value of property {@link #getWidth width}.
					/// 
					/// The width of the control
					/// 
					/// Default value is <code>100%</code>.
					/// </summary>
					/// <returns>Value of property <code>width</code></returns>
					public extern virtual sap.ui.core.CSSSize getWidth();

					/// <summary>
					/// Sets a new value for property {@link #getWidth width}.
					/// 
					/// The width of the control
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>100%</code>.
					/// </summary>
					/// <param name="sWidth">New value for property <code>width</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.Splitter setWidth(sap.ui.core.CSSSize sWidth);

					#endregion

					#region Methods for Property height

					/// <summary>
					/// Gets current value of property {@link #getHeight height}.
					/// 
					/// The height of the control
					/// 
					/// Default value is <code>100%</code>.
					/// </summary>
					/// <returns>Value of property <code>height</code></returns>
					public extern virtual sap.ui.core.CSSSize getHeight();

					/// <summary>
					/// Sets a new value for property {@link #getHeight height}.
					/// 
					/// The height of the control
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>100%</code>.
					/// </summary>
					/// <param name="sHeight">New value for property <code>height</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.Splitter setHeight(sap.ui.core.CSSSize sHeight);

					#endregion

					#region Methods for Aggregation contentAreas

					/// <summary>
					/// Gets content of aggregation {@link #getContentAreas contentAreas}.
					/// 
					/// The content areas to be split. The control will show n-1 splitter bars between n controls in this aggregation.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.Control[] getContentAreas();

					/// <summary>
					/// Destroys all the contentAreas in the aggregation {@link #getContentAreas contentAreas}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.Splitter destroyContentAreas();

					/// <summary>
					/// Inserts a contentArea into the aggregation {@link #getContentAreas contentAreas}.
					/// </summary>
					/// <param name="oContentArea">The contentArea to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the contentArea should be inserted at; for a negative value of <code>iIndex</code>, the contentArea is inserted at position 0; for a value greater than the current size of the aggregation, the contentArea is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.Splitter insertContentArea(sap.ui.core.Control oContentArea, int iIndex);

					/// <summary>
					/// Adds some contentArea to the aggregation {@link #getContentAreas contentAreas}.
					/// </summary>
					/// <param name="oContentArea">The contentArea to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.Splitter addContentArea(sap.ui.core.Control oContentArea);

					/// <summary>
					/// Removes a contentArea from the aggregation {@link #getContentAreas contentAreas}.
					/// </summary>
					/// <param name="vContentArea">The contentArea to remove or its index or id</param>
					/// <returns>The removed contentArea or <code>null</code></returns>
					public extern virtual sap.ui.core.Control removeContentArea(Union<int, string, sap.ui.core.Control> vContentArea);

					/// <summary>
					/// Checks for the provided <code>sap.ui.core.Control</code> in the aggregation {@link #getContentAreas contentAreas}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oContentArea">The contentArea whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfContentArea(sap.ui.core.Control oContentArea);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getContentAreas contentAreas}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.core.Control[] removeAllContentAreas();

					#endregion

					#region Methods for Event resize

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:resize resize} event of this <code>sap.ui.layout.Splitter</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.layout.Splitter</code> itself.
					/// 
					/// Event is fired when contents are resized.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.layout.Splitter</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.Splitter attachResize(object oData, sap.ui.layout.Splitter.ResizeDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:resize resize} event of this <code>sap.ui.layout.Splitter</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.layout.Splitter</code> itself.
					/// 
					/// Event is fired when contents are resized.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.Splitter attachResize(object oData, sap.ui.layout.Splitter.ResizeDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:resize resize} event of this <code>sap.ui.layout.Splitter</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.layout.Splitter</code> itself.
					/// 
					/// Event is fired when contents are resized.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.Splitter attachResize(sap.ui.layout.Splitter.ResizeDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:resize resize} event of this <code>sap.ui.layout.Splitter</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.layout.Splitter</code> itself.
					/// 
					/// Event is fired when contents are resized.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.layout.Splitter</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.Splitter attachResize(sap.ui.layout.Splitter.ResizeDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:resize resize} event of this <code>sap.ui.layout.Splitter</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.Splitter detachResize(sap.ui.layout.Splitter.ResizeDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:resize resize} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.Splitter fireResize(sap.ui.layout.Splitter.ResizeInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:resize resize} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.Splitter fireResize();

					#endregion

					#region Other methods

					/// <summary>
					/// Disables the resize handler for this control, this leads to an automatic resize of the contents whenever the control changes its size. The resize handler is enabled in every control instance by default. For performance reasons this behavior can be disabled by calling disableAutoResize()
					/// </summary>
					/// <param name="bTemporarily">Only disable autoResize temporarily (used for live resize), so that the previous status can be restored afterwards</param>
					[Obsolete("Deprecated since 1.21. This method is declared as protected in order to assess the need for this feature. It is declared as deprecated because the API might change in case the need for this is high enough to make it part of the official Splitter interface")]
					public extern virtual void disableAutoResize(bool bTemporarily = false);

					/// <summary>
					/// Disables the resizing of the Splitter contents via keyboard. This changes the Splitter bars to non-focussable elements.
					/// </summary>
					public extern virtual void disableKeyboardSupport();

					/// <summary>
					/// Disables recalculation and resize of the splitter contents while dragging the splitter bar. This means that the contents are resized only once after moving the splitter bar.
					/// </summary>
					[Obsolete("Deprecated since 1.21. This method is declared as protected in order to assess the need for this feature. It is declared as deprecated because the API might change in case the need for this is high enough to make it part of the official Splitter interface")]
					public extern virtual void disableLiveResize();

					/// <summary>
					/// Enables the resize handler for this control, this leads to an automatic resize of the contents whenever the control changes its size. The resize handler is enabled in every control instance by default. For performance reasons this behavior can be disabled by calling disableAutoResize()
					/// </summary>
					/// <param name="bTemporarily">Only enables autoResize if it was previously disabled temporarily (used for live resize)</param>
					[Obsolete("Deprecated since 1.21. This method is declared as protected in order to assess the need for this feature. It is declared as deprecated because the API might change in case the need for this is high enough to make it part of the official Splitter interface")]
					public extern virtual void enableAutoResize(bool bTemporarily = false);

					/// <summary>
					/// Enables the resizing of the Splitter contents via keyboard. This makes the Splitter bars focussable elements.
					/// </summary>
					public extern virtual void enableKeyboardSupport();

					/// <summary>
					/// Enables recalculation and resize of the splitter contents while dragging the splitter bar. This means that the contents are resized several times per second when moving the splitter bar.
					/// </summary>
					[Obsolete("Deprecated since 1.21. This method is declared as protected in order to assess the need for this feature. It is declared as deprecated because the API might change in case the need for this is high enough to make it part of the official Splitter interface")]
					public extern virtual void enableLiveResize();

					/// <summary>
					/// Creates a new subclass of class sap.ui.layout.Splitter with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.layout.Splitter with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.layout.Splitter with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns the current actual content sizes as pixel value - these values can change with every resize.
					/// </summary>
					/// <returns>Array of px values that correspond to the content area sizes</returns>
					[Obsolete("Deprecated since 1.21. This method is declared as protected in order to assess the need for this feature. It is declared as deprecated because the API might change in case the need for this is high enough to make it part of the official Splitter interface")]
					public extern virtual int[] getCalculatedSizes();

					/// <summary>
					/// Returns a metadata object for class sap.ui.layout.Splitter.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					[Name("getMetadata")]
					public extern static sap.ui.@base.Metadata getMetadataStatic();

					/// <summary>
					/// This method triggers a resize on the Splitter - meaning it forces the Splitter to recalculate all sizes. This method should only be used in rare cases, for example when the CSS that defines the sizes of the splitter bars changes without triggering a rerendering of the splitter.
					/// </summary>
					/// <param name="forceDirectly">Do not delay the resize, trigger it right now.</param>
					public extern virtual void triggerResize(bool forceDirectly = false);

					#endregion

					#endregion

				}
			}
		}
	}
}
