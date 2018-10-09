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
				/// The ScrollBar control can be used for virtual scrolling of a certain area. This means: to simulate a very large scrollable area when technically the area is small and the control takes care of displaying the respective part only. E.g. a Table control can take care of only rendering the currently visible rows and use this ScrollBar control to make the user think he actually scrolls through a long list.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.core.ScrollBar")]
				[Obsolete("Deprecated since 1.56.")]
				public partial class ScrollBar : sap.ui.core.Control
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
						/// Orientation. Defines if the Scrollbar is vertical or horizontal.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> vertical;

						/// <summary>
						/// Scroll position in steps or pixels.
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> scrollPosition;

						/// <summary>
						/// Size of the Scrollbar (in pixels).
						/// </summary>
						public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> size;

						/// <summary>
						/// Size of the scrollable content (in pixels).
						/// </summary>
						public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> contentSize;

						/// <summary>
						/// Number of steps to scroll. Used if the size of the content is not known as the data is loaded dynamically.
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> steps;

						/// <summary>
						/// Scroll event.
						/// </summary>
						public sap.ui.core.ScrollBar.ScrollDelegate scroll;

					}

					#endregion

					#region Typed Parameters

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class ScrollInfo
					{
						/// <summary>
						/// Actions are: Click on track, button, drag of thumb, or mouse wheel click.
						/// </summary>
						public sap.ui.core.ScrollBarAction action;

						/// <summary>
						/// Direction of scrolling: back (up) or forward (down).
						/// </summary>
						public bool forward;

						/// <summary>
						/// Current Scroll position either in pixels or in steps.
						/// </summary>
						public int newScrollPos;

						/// <summary>
						/// Old Scroll position - can be in pixels or in steps.
						/// </summary>
						public int oldScrollPos;

					}

					#endregion

					#region Delegates

					public delegate void ScrollDelegate(sap.ui.@base.Event<sap.ui.core.ScrollBar.ScrollInfo> oEvent, object oData);

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new ScrollBar.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern ScrollBar(string sId, sap.ui.core.ScrollBar.Settings mSettings);

					/// <summary>
					/// Constructor for a new ScrollBar.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern ScrollBar(string sId);

					/// <summary>
					/// Constructor for a new ScrollBar.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern ScrollBar();

					/// <summary>
					/// Constructor for a new ScrollBar.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern ScrollBar(sap.ui.core.ScrollBar.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property vertical

					/// <summary>
					/// Gets current value of property {@link #getVertical vertical}.
					/// 
					/// Orientation. Defines if the Scrollbar is vertical or horizontal.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>vertical</code></returns>
					public extern virtual bool getVertical();

					/// <summary>
					/// Sets a new value for property {@link #getVertical vertical}.
					/// 
					/// Orientation. Defines if the Scrollbar is vertical or horizontal.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bVertical">New value for property <code>vertical</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.ScrollBar setVertical(bool bVertical);

					#endregion

					#region Methods for Property scrollPosition

					/// <summary>
					/// Gets current value of property {@link #getScrollPosition scrollPosition}.
					/// 
					/// Scroll position in steps or pixels.
					/// </summary>
					/// <returns>Value of property <code>scrollPosition</code></returns>
					public extern virtual int getScrollPosition();

					/// <summary>
					/// Sets a new value for property {@link #getScrollPosition scrollPosition}.
					/// 
					/// Scroll position in steps or pixels.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="iScrollPosition">New value for property <code>scrollPosition</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.ScrollBar setScrollPosition(int iScrollPosition);

					#endregion

					#region Methods for Property size

					/// <summary>
					/// Gets current value of property {@link #getSize size}.
					/// 
					/// Size of the Scrollbar (in pixels).
					/// </summary>
					/// <returns>Value of property <code>size</code></returns>
					public extern virtual sap.ui.core.CSSSize getSize();

					/// <summary>
					/// Sets a new value for property {@link #getSize size}.
					/// 
					/// Size of the Scrollbar (in pixels).
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sSize">New value for property <code>size</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.ScrollBar setSize(sap.ui.core.CSSSize sSize);

					#endregion

					#region Methods for Property contentSize

					/// <summary>
					/// Gets current value of property {@link #getContentSize contentSize}.
					/// 
					/// Size of the scrollable content (in pixels).
					/// </summary>
					/// <returns>Value of property <code>contentSize</code></returns>
					public extern virtual sap.ui.core.CSSSize getContentSize();

					/// <summary>
					/// Sets a new value for property {@link #getContentSize contentSize}.
					/// 
					/// Size of the scrollable content (in pixels).
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sContentSize">New value for property <code>contentSize</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.ScrollBar setContentSize(sap.ui.core.CSSSize sContentSize);

					#endregion

					#region Methods for Property steps

					/// <summary>
					/// Gets current value of property {@link #getSteps steps}.
					/// 
					/// Number of steps to scroll. Used if the size of the content is not known as the data is loaded dynamically.
					/// </summary>
					/// <returns>Value of property <code>steps</code></returns>
					public extern virtual int getSteps();

					/// <summary>
					/// Sets a new value for property {@link #getSteps steps}.
					/// 
					/// Number of steps to scroll. Used if the size of the content is not known as the data is loaded dynamically.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="iSteps">New value for property <code>steps</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.ScrollBar setSteps(int iSteps);

					#endregion

					#region Methods for Event scroll

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:scroll scroll} event of this <code>sap.ui.core.ScrollBar</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.core.ScrollBar</code> itself.
					/// 
					/// Scroll event.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.core.ScrollBar</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.ScrollBar attachScroll(object oData, sap.ui.core.ScrollBar.ScrollDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:scroll scroll} event of this <code>sap.ui.core.ScrollBar</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.core.ScrollBar</code> itself.
					/// 
					/// Scroll event.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.ScrollBar attachScroll(object oData, sap.ui.core.ScrollBar.ScrollDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:scroll scroll} event of this <code>sap.ui.core.ScrollBar</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.core.ScrollBar</code> itself.
					/// 
					/// Scroll event.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.ScrollBar attachScroll(sap.ui.core.ScrollBar.ScrollDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:scroll scroll} event of this <code>sap.ui.core.ScrollBar</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.core.ScrollBar</code> itself.
					/// 
					/// Scroll event.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.core.ScrollBar</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.ScrollBar attachScroll(sap.ui.core.ScrollBar.ScrollDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:scroll scroll} event of this <code>sap.ui.core.ScrollBar</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.ScrollBar detachScroll(sap.ui.core.ScrollBar.ScrollDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:scroll scroll} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.ScrollBar fireScroll(sap.ui.core.ScrollBar.ScrollInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:scroll scroll} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.ScrollBar fireScroll();

					#endregion

					#region Other methods

					/// <summary>
					/// Binds the mouse wheel scroll event of the control that has the scrollbar to the scrollbar itself.
					/// </summary>
					/// <param name="oOwnerDomRef">Dom ref of the control that uses the scrollbar</param>
					public extern virtual void bind(string oOwnerDomRef);

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.ScrollBar with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.ScrollBar with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.ScrollBar with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.core.ScrollBar.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					/// <summary>
					/// Page Down is used to scroll one page forward.
					/// </summary>
					public extern virtual void pageDown();

					/// <summary>
					/// Page Up is used to scroll one page back.
					/// </summary>
					public extern virtual void pageUp();

					/// <summary>
					/// Unbinds the mouse wheel scroll event of the control that has the scrollbar
					/// </summary>
					/// <param name="oOwnerDomRef">Dom ref of the Control that uses the scrollbar</param>
					public extern virtual void unbind(string oOwnerDomRef);

					#endregion

					#endregion

				}
			}
		}
	}
}
