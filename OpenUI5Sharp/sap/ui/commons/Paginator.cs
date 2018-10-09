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
				/// Provides navigation between pages within a list of numbered pages.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.Paginator")]
				[Obsolete("Deprecated since 1.38.")]
				public partial class Paginator : sap.ui.core.Control
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
						/// Represents the current page (first page has index 1, not 0, to match the visual number)
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> currentPage;

						/// <summary>
						/// Represents the overall number of pages that are embedded into the parent control
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> numberOfPages;

						/// <summary>
						/// Event is fired when the user navigates to another page by selecting it directly, or by jumping forward/backward.
						/// </summary>
						public sap.ui.commons.Paginator.PageDelegate page;

					}

					#endregion

					#region Typed Parameters

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class PageInfo
					{
						/// <summary>
						/// The page which is the current one before the page event is fired (and another page is displayed)
						/// </summary>
						public int srcPage;

						/// <summary>
						/// The page that shall be displayed next after the page event is fired.
						/// 
						/// The page number is 1-based: the first page has index 1, not 0, to match the number visible in the UI.
						/// </summary>
						public int targetPage;

						/// <summary>
						/// Provides the values 'First', 'Last', 'Next', 'Previous', 'Goto'. The event parameter informs the application how the user navigated to the new page: Whether the 'Next' button was used, or another button, or whether the page was directly selected
						/// </summary>
						public sap.ui.commons.PaginatorEvent type;

					}

					#endregion

					#region Delegates

					public delegate void PageDelegate(sap.ui.@base.Event<sap.ui.commons.Paginator.PageInfo> oEvent, object oData);

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new Paginator.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern Paginator(string sId, sap.ui.commons.Paginator.Settings mSettings);

					/// <summary>
					/// Constructor for a new Paginator.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					public extern Paginator(string sId);

					/// <summary>
					/// Constructor for a new Paginator.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern Paginator();

					/// <summary>
					/// Constructor for a new Paginator.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern Paginator(sap.ui.commons.Paginator.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property currentPage

					/// <summary>
					/// Gets current value of property {@link #getCurrentPage currentPage}.
					/// 
					/// Represents the current page (first page has index 1, not 0, to match the visual number)
					/// 
					/// Default value is <code>1</code>.
					/// </summary>
					/// <returns>Value of property <code>currentPage</code></returns>
					public extern virtual int getCurrentPage();

					/// <summary>
					/// Sets a new value for property {@link #getCurrentPage currentPage}.
					/// 
					/// Represents the current page (first page has index 1, not 0, to match the visual number)
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>1</code>.
					/// </summary>
					/// <param name="iCurrentPage">New value for property <code>currentPage</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Paginator setCurrentPage(int iCurrentPage);

					#endregion

					#region Methods for Property numberOfPages

					/// <summary>
					/// Gets current value of property {@link #getNumberOfPages numberOfPages}.
					/// 
					/// Represents the overall number of pages that are embedded into the parent control
					/// </summary>
					/// <returns>Value of property <code>numberOfPages</code></returns>
					public extern virtual int getNumberOfPages();

					/// <summary>
					/// Sets a new value for property {@link #getNumberOfPages numberOfPages}.
					/// 
					/// Represents the overall number of pages that are embedded into the parent control
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="iNumberOfPages">New value for property <code>numberOfPages</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Paginator setNumberOfPages(int iNumberOfPages);

					#endregion

					#region Methods for Event page

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:page page} event of this <code>sap.ui.commons.Paginator</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.Paginator</code> itself.
					/// 
					/// Event is fired when the user navigates to another page by selecting it directly, or by jumping forward/backward.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.Paginator</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Paginator attachPage(object oData, sap.ui.commons.Paginator.PageDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:page page} event of this <code>sap.ui.commons.Paginator</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.Paginator</code> itself.
					/// 
					/// Event is fired when the user navigates to another page by selecting it directly, or by jumping forward/backward.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Paginator attachPage(object oData, sap.ui.commons.Paginator.PageDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:page page} event of this <code>sap.ui.commons.Paginator</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.Paginator</code> itself.
					/// 
					/// Event is fired when the user navigates to another page by selecting it directly, or by jumping forward/backward.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Paginator attachPage(sap.ui.commons.Paginator.PageDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:page page} event of this <code>sap.ui.commons.Paginator</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.Paginator</code> itself.
					/// 
					/// Event is fired when the user navigates to another page by selecting it directly, or by jumping forward/backward.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.Paginator</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Paginator attachPage(sap.ui.commons.Paginator.PageDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:page page} event of this <code>sap.ui.commons.Paginator</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Paginator detachPage(sap.ui.commons.Paginator.PageDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:page page} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Paginator firePage(sap.ui.commons.Paginator.PageInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:page page} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Paginator firePage();

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.Paginator with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.Paginator with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.Paginator with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.commons.Paginator.
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
