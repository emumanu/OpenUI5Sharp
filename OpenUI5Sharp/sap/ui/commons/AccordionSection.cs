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
				/// Represents a panel which is a container for other controls. The container does not have any layout function.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.AccordionSection")]
				[Obsolete("Deprecated since 1.38.")]
				public partial class AccordionSection : sap.ui.core.Element
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
						/// When the section content exceeds maxHeight, a vertical scroll bar appears.
						/// </summary>
						public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> maxHeight;

						/// <summary>
						/// It is required that the used theme supports the control.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> enabled;

						/// <summary>
						/// It is recommended to adjust the settings for the width when the section is set to 'collapsed'.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> collapsed;

						/// <summary>
						/// Text for the section header
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> title;

						/// <summary>
						/// Aggregates the controls that are contained in the panel. The control layout is browser-dependent. For a stable content layout, use a layout control as direct single child. When the panel dimensions are set, the child control may have width and height of 100%; when the panel dimensions are not set, the child defines the panel size.
						/// </summary>
						public Union<sap.ui.core.Control[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> content;

						/// <summary>
						/// Event is fired when the user scrolls the panel
						/// </summary>
						public sap.ui.commons.AccordionSection.ScrollDelegate scroll;

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
						/// Horizontal scroll position
						/// </summary>
						public int left;

						/// <summary>
						/// Vertical scroll position
						/// </summary>
						public int top;

					}

					#endregion

					#region Delegates

					public delegate void ScrollDelegate(sap.ui.@base.Event<sap.ui.commons.AccordionSection.ScrollInfo> oEvent, object oData);

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new AccordionSection.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern AccordionSection(string sId, sap.ui.commons.AccordionSection.Settings mSettings);

					/// <summary>
					/// Constructor for a new AccordionSection.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern AccordionSection(string sId);

					/// <summary>
					/// Constructor for a new AccordionSection.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern AccordionSection();

					/// <summary>
					/// Constructor for a new AccordionSection.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern AccordionSection(sap.ui.commons.AccordionSection.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property maxHeight

					/// <summary>
					/// Gets current value of property {@link #getMaxHeight maxHeight}.
					/// 
					/// When the section content exceeds maxHeight, a vertical scroll bar appears.
					/// </summary>
					/// <returns>Value of property <code>maxHeight</code></returns>
					public extern virtual sap.ui.core.CSSSize getMaxHeight();

					/// <summary>
					/// Sets a new value for property {@link #getMaxHeight maxHeight}.
					/// 
					/// When the section content exceeds maxHeight, a vertical scroll bar appears.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sMaxHeight">New value for property <code>maxHeight</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.AccordionSection setMaxHeight(sap.ui.core.CSSSize sMaxHeight);

					#endregion

					#region Methods for Property enabled

					/// <summary>
					/// Gets current value of property {@link #getEnabled enabled}.
					/// 
					/// It is required that the used theme supports the control.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>enabled</code></returns>
					public extern virtual bool getEnabled();

					/// <summary>
					/// Property setter for the "enabled" state
					/// </summary>
					/// <param name="bEnabled">Whether the AccordionSection is enabled or not</param>
					/// <returns>'this' to allow method chaining</returns>
					public extern virtual sap.ui.commons.AccordionSection setEnabled(bool bEnabled);

					#endregion

					#region Methods for Property collapsed

					/// <summary>
					/// Gets current value of property {@link #getCollapsed collapsed}.
					/// 
					/// It is recommended to adjust the settings for the width when the section is set to 'collapsed'.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>collapsed</code></returns>
					[Obsolete("Deprecated since 1.34. Use Accordion's 'openedSectionsId' property")]
					public extern virtual bool getCollapsed();

					/// <summary>
					/// Property setter for the "collapsed" state
					/// </summary>
					/// <param name="bCollapsed">Whether the AccordionSection is collapsed or not</param>
					/// <returns>'this' to allow method chaining</returns>
					public extern virtual sap.ui.commons.AccordionSection setCollapsed(bool bCollapsed);

					#endregion

					#region Methods for Property title

					/// <summary>
					/// Gets current value of property {@link #getTitle title}.
					/// 
					/// Text for the section header
					/// </summary>
					/// <returns>Value of property <code>title</code></returns>
					public extern virtual string getTitle();

					/// <summary>
					/// Sets a new value for property {@link #getTitle title}.
					/// 
					/// Text for the section header
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sTitle">New value for property <code>title</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.AccordionSection setTitle(string sTitle);

					#endregion

					#region Methods for Aggregation content

					/// <summary>
					/// Gets content of aggregation {@link #getContent content}.
					/// 
					/// Aggregates the controls that are contained in the panel. The control layout is browser-dependent. For a stable content layout, use a layout control as direct single child. When the panel dimensions are set, the child control may have width and height of 100%; when the panel dimensions are not set, the child defines the panel size.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.Control[] getContent();

					/// <summary>
					/// Destroys all the content in the aggregation {@link #getContent content}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.AccordionSection destroyContent();

					/// <summary>
					/// Inserts a content into the aggregation {@link #getContent content}.
					/// </summary>
					/// <param name="oContent">The content to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the content should be inserted at; for a negative value of <code>iIndex</code>, the content is inserted at position 0; for a value greater than the current size of the aggregation, the content is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.AccordionSection insertContent(sap.ui.core.Control oContent, int iIndex);

					/// <summary>
					/// Adds some content to the aggregation {@link #getContent content}.
					/// </summary>
					/// <param name="oContent">The content to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.AccordionSection addContent(sap.ui.core.Control oContent);

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

					#region Methods for Event scroll

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:scroll scroll} event of this <code>sap.ui.commons.AccordionSection</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.AccordionSection</code> itself.
					/// 
					/// Event is fired when the user scrolls the panel
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.AccordionSection</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.AccordionSection attachScroll(object oData, sap.ui.commons.AccordionSection.ScrollDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:scroll scroll} event of this <code>sap.ui.commons.AccordionSection</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.AccordionSection</code> itself.
					/// 
					/// Event is fired when the user scrolls the panel
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.AccordionSection attachScroll(object oData, sap.ui.commons.AccordionSection.ScrollDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:scroll scroll} event of this <code>sap.ui.commons.AccordionSection</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.AccordionSection</code> itself.
					/// 
					/// Event is fired when the user scrolls the panel
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.AccordionSection attachScroll(sap.ui.commons.AccordionSection.ScrollDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:scroll scroll} event of this <code>sap.ui.commons.AccordionSection</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.AccordionSection</code> itself.
					/// 
					/// Event is fired when the user scrolls the panel
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.AccordionSection</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.AccordionSection attachScroll(sap.ui.commons.AccordionSection.ScrollDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:scroll scroll} event of this <code>sap.ui.commons.AccordionSection</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.AccordionSection detachScroll(sap.ui.commons.AccordionSection.ScrollDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:scroll scroll} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.AccordionSection fireScroll(sap.ui.commons.AccordionSection.ScrollInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:scroll scroll} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.AccordionSection fireScroll();

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.AccordionSection with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.AccordionSection with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.AccordionSection with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.commons.AccordionSection.
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
