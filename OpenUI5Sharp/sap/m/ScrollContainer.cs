using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public static partial class sap
	{
		public static partial class m
		{
			/// <summary>
			/// The ScrollContainer is a control that can display arbitrary content within a limited screen area and provides scrolling to make all content accessible. <h3>When not to use</h3> Do not nest scrolling areas that scroll in the same direction (e.g. a ScrollContainer that scrolls vertically inside a Page control with scrolling enabled).
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.ScrollContainer")]
			public partial class ScrollContainer : sap.ui.core.Control
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
					/// The width of the ScrollContainer. If not set, it consumes the complete available width, behaving like normal HTML block elements. If only vertical scrolling is enabled, make sure the content always fits or wraps.
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> width;

					/// <summary>
					/// The height of the ScrollContainer. By default the height equals the content height. If only horizontal scrolling is used, do not set the height or make sure the height is always larger than the height of the content.
					/// 
					/// Note that when a percentage is given, for the height to work as expected, the height of the surrounding container must be defined.
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> height;

					/// <summary>
					/// Whether horizontal scrolling should be possible.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> horizontal;

					/// <summary>
					/// Whether vertical scrolling should be possible.
					/// 
					/// Note that this is off by default because typically a Page is used as fullscreen element which can handle vertical scrolling. If this is not the case and vertical scrolling is required, this flag needs to be set to "true". Important: it is not supported to have nested controls that both enable scrolling into the same dimension.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> vertical;

					/// <summary>
					/// Whether the scroll container can be focused.
					/// 
					/// Note that it should be set to "true" when there are no focusable elements inside or when keyboard interaction requires an additional tab stop on the container.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> focusable;

					/// <summary>
					/// The content of the ScrollContainer.
					/// </summary>
					public Union<sap.ui.core.Control[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> content;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new ScrollContainer.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern ScrollContainer(string sId, sap.m.ScrollContainer.Settings mSettings);

				/// <summary>
				/// Constructor for a new ScrollContainer.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern ScrollContainer(string sId);

				/// <summary>
				/// Constructor for a new ScrollContainer.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern ScrollContainer();

				/// <summary>
				/// Constructor for a new ScrollContainer.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern ScrollContainer(sap.m.ScrollContainer.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property width

				/// <summary>
				/// Gets current value of property {@link #getWidth width}.
				/// 
				/// The width of the ScrollContainer. If not set, it consumes the complete available width, behaving like normal HTML block elements. If only vertical scrolling is enabled, make sure the content always fits or wraps.
				/// 
				/// Default value is <code>auto</code>.
				/// </summary>
				/// <returns>Value of property <code>width</code></returns>
				public extern virtual sap.ui.core.CSSSize getWidth();

				/// <summary>
				/// Sets a new value for property {@link #getWidth width}.
				/// 
				/// The width of the ScrollContainer. If not set, it consumes the complete available width, behaving like normal HTML block elements. If only vertical scrolling is enabled, make sure the content always fits or wraps.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>auto</code>.
				/// </summary>
				/// <param name="sWidth">New value for property <code>width</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ScrollContainer setWidth(sap.ui.core.CSSSize sWidth);

				#endregion

				#region Methods for Property height

				/// <summary>
				/// Gets current value of property {@link #getHeight height}.
				/// 
				/// The height of the ScrollContainer. By default the height equals the content height. If only horizontal scrolling is used, do not set the height or make sure the height is always larger than the height of the content.
				/// 
				/// Note that when a percentage is given, for the height to work as expected, the height of the surrounding container must be defined.
				/// 
				/// Default value is <code>auto</code>.
				/// </summary>
				/// <returns>Value of property <code>height</code></returns>
				public extern virtual sap.ui.core.CSSSize getHeight();

				/// <summary>
				/// Sets a new value for property {@link #getHeight height}.
				/// 
				/// The height of the ScrollContainer. By default the height equals the content height. If only horizontal scrolling is used, do not set the height or make sure the height is always larger than the height of the content.
				/// 
				/// Note that when a percentage is given, for the height to work as expected, the height of the surrounding container must be defined.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>auto</code>.
				/// </summary>
				/// <param name="sHeight">New value for property <code>height</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ScrollContainer setHeight(sap.ui.core.CSSSize sHeight);

				#endregion

				#region Methods for Property horizontal

				/// <summary>
				/// Gets current value of property {@link #getHorizontal horizontal}.
				/// 
				/// Whether horizontal scrolling should be possible.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>horizontal</code></returns>
				public extern virtual bool getHorizontal();

				/// <summary>
				/// Sets a new value for property {@link #getHorizontal horizontal}.
				/// 
				/// Whether horizontal scrolling should be possible.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bHorizontal">New value for property <code>horizontal</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ScrollContainer setHorizontal(bool bHorizontal);

				#endregion

				#region Methods for Property vertical

				/// <summary>
				/// Gets current value of property {@link #getVertical vertical}.
				/// 
				/// Whether vertical scrolling should be possible.
				/// 
				/// Note that this is off by default because typically a Page is used as fullscreen element which can handle vertical scrolling. If this is not the case and vertical scrolling is required, this flag needs to be set to "true". Important: it is not supported to have nested controls that both enable scrolling into the same dimension.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>vertical</code></returns>
				public extern virtual bool getVertical();

				/// <summary>
				/// Sets a new value for property {@link #getVertical vertical}.
				/// 
				/// Whether vertical scrolling should be possible.
				/// 
				/// Note that this is off by default because typically a Page is used as fullscreen element which can handle vertical scrolling. If this is not the case and vertical scrolling is required, this flag needs to be set to "true". Important: it is not supported to have nested controls that both enable scrolling into the same dimension.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bVertical">New value for property <code>vertical</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ScrollContainer setVertical(bool bVertical);

				#endregion

				#region Methods for Property focusable

				/// <summary>
				/// Gets current value of property {@link #getFocusable focusable}.
				/// 
				/// Whether the scroll container can be focused.
				/// 
				/// Note that it should be set to "true" when there are no focusable elements inside or when keyboard interaction requires an additional tab stop on the container.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>focusable</code></returns>
				public extern virtual bool getFocusable();

				/// <summary>
				/// Sets a new value for property {@link #getFocusable focusable}.
				/// 
				/// Whether the scroll container can be focused.
				/// 
				/// Note that it should be set to "true" when there are no focusable elements inside or when keyboard interaction requires an additional tab stop on the container.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bFocusable">New value for property <code>focusable</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ScrollContainer setFocusable(bool bFocusable);

				#endregion

				#region Methods for Aggregation content

				/// <summary>
				/// Gets content of aggregation {@link #getContent content}.
				/// 
				/// The content of the ScrollContainer.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.Control[] getContent();

				/// <summary>
				/// Destroys all the content in the aggregation {@link #getContent content}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ScrollContainer destroyContent();

				/// <summary>
				/// Inserts a content into the aggregation {@link #getContent content}.
				/// </summary>
				/// <param name="oContent">The content to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the content should be inserted at; for a negative value of <code>iIndex</code>, the content is inserted at position 0; for a value greater than the current size of the aggregation, the content is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ScrollContainer insertContent(sap.ui.core.Control oContent, int iIndex);

				/// <summary>
				/// Adds some content to the aggregation {@link #getContent content}.
				/// </summary>
				/// <param name="oContent">The content to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ScrollContainer addContent(sap.ui.core.Control oContent);

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

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.ScrollContainer with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.ScrollContainer with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.ScrollContainer with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.ScrollContainer.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				[Name("getMetadata")]
				public extern static sap.ui.@base.Metadata getMetadataStatic();

				/// <summary>
				/// Scrolls to the given position. When called while the control is not rendered (yet), the scrolling position is still applied, but there is no animation.
				/// </summary>
				/// <param name="x">The horizontal pixel position to scroll to. Scrolling to the right happens with positive values. In right-to-left mode scrolling starts at the right side and higher values scroll to the left. If only vertical scrolling is enabled, give 0 as value.</param>
				/// <param name="y">The vertical pixel position to scroll to. Scrolling down happens with positive values. If only horizontal scrolling is enabled, give 0 as value.</param>
				/// <param name="time">The duration of animated scrolling. To scroll immediately without animation, give 0 as value. 0 is also the default value, when this optional parameter is omitted.</param>
				/// <returns><code>this</code> to facilitate method chaining</returns>
				public extern virtual sap.m.ScrollContainer scrollTo(int x, int y, int time);

				/// <summary>
				/// Scrolls to an element(DOM or sap.ui.core.Element) within the page if the element is rendered.
				/// </summary>
				/// <param name="element">The element to which should be scrolled.</param>
				/// <param name="time">The duration of animated scrolling. To scroll immediately without animation, give 0 as value or leave it default.</param>
				/// <returns><code>this</code> to facilitate method chaining.</returns>
				public extern virtual sap.m.ScrollContainer scrollToElement(Union<Retyped.dom.HTMLElement, sap.ui.core.Element> element, int time = 0);

				#endregion

				#endregion

			}
		}
	}
}
