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
				/// ShellOverlay to be opened in front of an sap.ui.unified.Shell
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.unified.ShellOverlay")]
				[Obsolete("Deprecated since 1.44.0.")]
				public partial class ShellOverlay : sap.ui.core.Control
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
						/// The content to appear in the overlay.
						/// </summary>
						public Union<sap.ui.core.Control[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> content;

						/// <summary>
						/// Experimental (This aggregation might change in future!): The search control which should be displayed in the overlay header.
						/// </summary>
						public Union<sap.ui.core.Control, string, sap.ui.@base.ManagedObject.BindAggregationInfo> search;

						/// <summary>
						/// Reference to the sap.ui.unified.Shell or sap.ui.unified.ShellLayout control.
						/// </summary>
						public Union<sap.ui.unified.ShellLayout, sap.ui.core.ID, string, sap.ui.@base.ManagedObject.BindPropertyInfo> shell;

						/// <summary>
						/// Association to controls / ids which label this control (see WAI-ARIA attribute aria-labelledby).
						/// </summary>
						public Union<sap.ui.core.Control, sap.ui.core.ID[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> ariaLabelledBy;

						/// <summary>
						/// Fired when the overlay was closed.
						/// </summary>
						public sap.ui.@base.EventDelegate closed;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new ShellOverlay.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern ShellOverlay(string sId, sap.ui.unified.ShellOverlay.Settings mSettings);

					/// <summary>
					/// Constructor for a new ShellOverlay.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern ShellOverlay(string sId);

					/// <summary>
					/// Constructor for a new ShellOverlay.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern ShellOverlay();

					/// <summary>
					/// Constructor for a new ShellOverlay.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern ShellOverlay(sap.ui.unified.ShellOverlay.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Aggregation content

					/// <summary>
					/// Gets content of aggregation {@link #getContent content}.
					/// 
					/// The content to appear in the overlay.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.Control[] getContent();

					/// <summary>
					/// Destroys all the content in the aggregation {@link #getContent content}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.ShellOverlay destroyContent();

					/// <summary>
					/// Inserts a content into the aggregation {@link #getContent content}.
					/// </summary>
					/// <param name="oContent">The content to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the content should be inserted at; for a negative value of <code>iIndex</code>, the content is inserted at position 0; for a value greater than the current size of the aggregation, the content is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.ShellOverlay insertContent(sap.ui.core.Control oContent, int iIndex);

					/// <summary>
					/// Adds some content to the aggregation {@link #getContent content}.
					/// </summary>
					/// <param name="oContent">The content to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.ShellOverlay addContent(sap.ui.core.Control oContent);

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

					#region Methods for Aggregation search

					/// <summary>
					/// Gets content of aggregation {@link #getSearch search}.
					/// 
					/// Experimental (This aggregation might change in future!): The search control which should be displayed in the overlay header.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.Control getSearch();

					/// <summary>
					/// Destroys the search in the aggregation {@link #getSearch search}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.ShellOverlay destroySearch();

					/// <summary>
					/// Sets the aggregated {@link #getSearch search}.
					/// </summary>
					/// <param name="oSearch">The search to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.ShellOverlay setSearch(sap.ui.core.Control oSearch);

					#endregion

					#region Methods for Association shell

					/// <summary>
					/// ID of the element which is the current target of the association {@link #getShell shell}, or <code>null</code>.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.ID getShell();

					/// <summary>
					/// Sets the associated {@link #getShell shell}.
					/// </summary>
					/// <param name="oShell">ID of an element which becomes the new target of this shell association; alternatively, an element instance may be given</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.ShellOverlay setShell(Union<sap.ui.core.ID, sap.ui.unified.ShellLayout> oShell);

					#endregion

					#region Methods for Association ariaLabelledBy

					/// <summary>
					/// Returns array of IDs of the elements which are the current targets of the association {@link #getAriaLabelledBy ariaLabelledBy}.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.ID[] getAriaLabelledBy();

					/// <summary>
					/// Adds some ariaLabelledBy into the association {@link #getAriaLabelledBy ariaLabelledBy}.
					/// </summary>
					/// <param name="vAriaLabelledBy">The ariaLabelledBy to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.ShellOverlay addAriaLabelledBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaLabelledBy);

					/// <summary>
					/// Removes an ariaLabelledBy from the association named {@link #getAriaLabelledBy ariaLabelledBy}.
					/// </summary>
					/// <param name="vAriaLabelledBy">The ariaLabelledBy to be removed or its index or ID</param>
					/// <returns>The removed ariaLabelledBy or <code>null</code></returns>
					public extern virtual sap.ui.core.ID removeAriaLabelledBy(Union<int, sap.ui.core.ID, sap.ui.core.Control> vAriaLabelledBy);

					/// <summary>
					/// Removes all the controls in the association named {@link #getAriaLabelledBy ariaLabelledBy}.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.core.ID[] removeAllAriaLabelledBy();

					#endregion

					#region Methods for Event closed

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:closed closed} event of this <code>sap.ui.unified.ShellOverlay</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.ShellOverlay</code> itself.
					/// 
					/// Fired when the overlay was closed.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.ShellOverlay</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.ShellOverlay attachClosed(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:closed closed} event of this <code>sap.ui.unified.ShellOverlay</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.ShellOverlay</code> itself.
					/// 
					/// Fired when the overlay was closed.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.ShellOverlay attachClosed(object oData, sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:closed closed} event of this <code>sap.ui.unified.ShellOverlay</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.ShellOverlay</code> itself.
					/// 
					/// Fired when the overlay was closed.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.ShellOverlay attachClosed(sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:closed closed} event of this <code>sap.ui.unified.ShellOverlay</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.ShellOverlay</code> itself.
					/// 
					/// Fired when the overlay was closed.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.ShellOverlay</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.ShellOverlay attachClosed(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:closed closed} event of this <code>sap.ui.unified.ShellOverlay</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.ShellOverlay detachClosed(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:closed closed} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.ShellOverlay fireClosed(object mParameters);

					/// <summary>
					/// Fires event {@link #event:closed closed} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.ShellOverlay fireClosed();

					#endregion

					#region Other methods

					/// <summary>
					/// Closes the ShellOverlay.
					/// </summary>
					public extern virtual void close();

					/// <summary>
					/// Creates a new subclass of class sap.ui.unified.ShellOverlay with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.unified.ShellOverlay with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.unified.ShellOverlay with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.unified.ShellOverlay.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					[Name("getMetadata")]
					public extern static sap.ui.@base.Metadata getMetadataStatic();

					/// <summary>
					/// Opens the ShellOverlay.
					/// </summary>
					public extern virtual void open();

					#endregion

					#endregion

				}
			}
		}
	}
}
