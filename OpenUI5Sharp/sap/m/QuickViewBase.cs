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
			/// QuickViewBase class provides base functionality for QuickView and QuickViewCard. Do not use it directly.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.QuickViewBase")]
			public partial class QuickViewBase : sap.ui.core.Control
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
					/// Displays a page header, object icon or image, object name with short description, and object information divided in groups
					/// </summary>
					public Union<sap.m.QuickViewPage[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> pages;

					/// <summary>
					/// The event is fired when navigation between two pages has been triggered. The transition (if any) to the new page has not started yet. This event can be aborted by the application with preventDefault(), which means that there will be no navigation.
					/// </summary>
					public sap.m.QuickViewBase.NavigateDelegate navigate;

					/// <summary>
					/// The event is fired when navigation between two pages has completed. In case of animated transitions this event is fired with some delay after the "navigate" event.
					/// </summary>
					public sap.m.QuickViewBase.AfterNavigateDelegate afterNavigate;

				}

				#endregion

				#region Typed Parameters

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class AfterNavigateInfo
				{
					/// <summary>
					/// Determines the page, which has been displayed before navigation.
					/// </summary>
					public sap.ui.core.Control from;

					/// <summary>
					/// Determines the ID of the page, which has been displayed before navigation.
					/// </summary>
					public string fromId;

					/// <summary>
					/// Determines the page, which is now displayed after navigation.
					/// </summary>
					public sap.ui.core.Control to;

					/// <summary>
					/// Determines the ID of the page, which is now displayed after navigation.
					/// </summary>
					public string toId;

					/// <summary>
					/// Determines whether the "to" page (a control with the ID of the page, which has been navigated to) has not been displayed/navigated to before.
					/// </summary>
					public bool firstTime;

					/// <summary>
					/// Determines whether this was a forward navigation.
					/// </summary>
					public bool isTo;

					/// <summary>
					/// Determines whether this was a back navigation.
					/// </summary>
					public bool isBack;

					/// <summary>
					/// Determines whether this was a navigation to the root page.
					/// </summary>
					public bool isBackToTop;

					/// <summary>
					/// Determines whether this was a navigation to a specific page.
					/// </summary>
					public bool isBackToPage;

					/// <summary>
					/// Determines how the navigation was triggered, possible values are "to", "back", "backToPage", and "backToTop".
					/// </summary>
					public string direction;

					/// <summary>
					/// Determines whether this is a navigation to the top page.
					/// </summary>
					public bool isTopPage;

					/// <summary>
					/// Determines which link initiated the navigation.
					/// </summary>
					public sap.ui.core.Control navOrigin;

				}

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class NavigateInfo
				{
					/// <summary>
					/// The page which was displayed before the current navigation.
					/// </summary>
					public sap.ui.core.Control from;

					/// <summary>
					/// The ID of the page which was displayed before the current navigation.
					/// </summary>
					public string fromId;

					/// <summary>
					/// The page which will be displayed after the current navigation.
					/// </summary>
					public sap.ui.core.Control to;

					/// <summary>
					/// The ID of the page which will be displayed after the current navigation.
					/// </summary>
					public string toId;

					/// <summary>
					/// Determines whether the "to" page (a control with the ID of the page which is currently navigated to) has not been displayed/navigated to before.
					/// </summary>
					public bool firstTime;

					/// <summary>
					/// Determines whether this is a forward navigation.
					/// </summary>
					public bool isTo;

					/// <summary>
					/// Determines whether this is a back navigation.
					/// </summary>
					public bool isBack;

					/// <summary>
					/// Determines whether this is a navigation to the root page.
					/// </summary>
					public bool isBackToTop;

					/// <summary>
					/// Determines whether this was a navigation to a specific page.
					/// </summary>
					public bool isBackToPage;

					/// <summary>
					/// Determines how the navigation was triggered, possible values are "to", "back", "backToPage", and "backToTop".
					/// </summary>
					public string direction;

					/// <summary>
					/// Determines which link initiated the navigation.
					/// </summary>
					public sap.ui.core.Control navOrigin;

				}

				#endregion

				#region Delegates

				public delegate void AfterNavigateDelegate(sap.ui.@base.Event<sap.m.QuickViewBase.AfterNavigateInfo> oEvent, object oData);

				public delegate void NavigateDelegate(sap.ui.@base.Event<sap.m.QuickViewBase.NavigateInfo> oEvent, object oData);

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new QuickViewBase.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern QuickViewBase(string sId, sap.m.QuickViewBase.Settings mSettings);

				/// <summary>
				/// Constructor for a new QuickViewBase.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern QuickViewBase(string sId);

				/// <summary>
				/// Constructor for a new QuickViewBase.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern QuickViewBase();

				/// <summary>
				/// Constructor for a new QuickViewBase.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern QuickViewBase(sap.m.QuickViewBase.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Aggregation pages

				/// <summary>
				/// Gets content of aggregation {@link #getPages pages}.
				/// 
				/// Displays a page header, object icon or image, object name with short description, and object information divided in groups
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.QuickViewPage[] getPages();

				/// <summary>
				/// Destroys all the pages in the aggregation {@link #getPages pages}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.QuickViewBase destroyPages();

				/// <summary>
				/// Inserts a page into the aggregation {@link #getPages pages}.
				/// </summary>
				/// <param name="oPage">The page to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the page should be inserted at; for a negative value of <code>iIndex</code>, the page is inserted at position 0; for a value greater than the current size of the aggregation, the page is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.QuickViewBase insertPage(sap.m.QuickViewPage oPage, int iIndex);

				/// <summary>
				/// Adds some page to the aggregation {@link #getPages pages}.
				/// </summary>
				/// <param name="oPage">The page to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.QuickViewBase addPage(sap.m.QuickViewPage oPage);

				/// <summary>
				/// Removes a page from the aggregation {@link #getPages pages}.
				/// </summary>
				/// <param name="vPage">The page to remove or its index or id</param>
				/// <returns>The removed page or <code>null</code></returns>
				public extern virtual sap.m.QuickViewPage removePage(Union<int, string, sap.m.QuickViewPage> vPage);

				/// <summary>
				/// Checks for the provided <code>sap.m.QuickViewPage</code> in the aggregation {@link #getPages pages}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oPage">The page whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfPage(sap.m.QuickViewPage oPage);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getPages pages}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.m.QuickViewPage[] removeAllPages();

				/// <summary>
				/// Binds aggregation {@link #getPages pages} to model data.
				/// 
				/// See {@link sap.ui.base.ManagedObject#bindAggregation ManagedObject.bindAggregation} for a detailed description of the possible properties of <code>oBindingInfo</code>.
				/// </summary>
				/// <param name="oBindingInfo">The binding information</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.QuickViewBase bindPages(object oBindingInfo);

				/// <summary>
				/// Unbinds aggregation {@link #getPages pages} from model data.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.QuickViewBase unbindPages();

				#endregion

				#region Methods for Event navigate

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:navigate navigate} event of this <code>sap.m.QuickViewBase</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.QuickViewBase</code> itself.
				/// 
				/// The event is fired when navigation between two pages has been triggered. The transition (if any) to the new page has not started yet. This event can be aborted by the application with preventDefault(), which means that there will be no navigation.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.QuickViewBase</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.QuickViewBase attachNavigate(object oData, sap.m.QuickViewBase.NavigateDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:navigate navigate} event of this <code>sap.m.QuickViewBase</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.QuickViewBase</code> itself.
				/// 
				/// The event is fired when navigation between two pages has been triggered. The transition (if any) to the new page has not started yet. This event can be aborted by the application with preventDefault(), which means that there will be no navigation.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.QuickViewBase attachNavigate(object oData, sap.m.QuickViewBase.NavigateDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:navigate navigate} event of this <code>sap.m.QuickViewBase</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.QuickViewBase</code> itself.
				/// 
				/// The event is fired when navigation between two pages has been triggered. The transition (if any) to the new page has not started yet. This event can be aborted by the application with preventDefault(), which means that there will be no navigation.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.QuickViewBase attachNavigate(sap.m.QuickViewBase.NavigateDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:navigate navigate} event of this <code>sap.m.QuickViewBase</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.QuickViewBase</code> itself.
				/// 
				/// The event is fired when navigation between two pages has been triggered. The transition (if any) to the new page has not started yet. This event can be aborted by the application with preventDefault(), which means that there will be no navigation.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.QuickViewBase</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.QuickViewBase attachNavigate(sap.m.QuickViewBase.NavigateDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:navigate navigate} event of this <code>sap.m.QuickViewBase</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.QuickViewBase detachNavigate(sap.m.QuickViewBase.NavigateDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:navigate navigate} to attached listeners.
				/// 
				/// Listeners may prevent the default action of this event by using the <code>preventDefault</code>-method on the event object.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Whether or not to prevent the default action</returns>
				public extern virtual bool fireNavigate(sap.m.QuickViewBase.NavigateInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:navigate navigate} to attached listeners.
				/// 
				/// Listeners may prevent the default action of this event by using the <code>preventDefault</code>-method on the event object.
				/// </summary>
				/// <returns>Whether or not to prevent the default action</returns>
				public extern virtual bool fireNavigate();

				#endregion

				#region Methods for Event afterNavigate

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterNavigate afterNavigate} event of this <code>sap.m.QuickViewBase</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.QuickViewBase</code> itself.
				/// 
				/// The event is fired when navigation between two pages has completed. In case of animated transitions this event is fired with some delay after the "navigate" event.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.QuickViewBase</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.QuickViewBase attachAfterNavigate(object oData, sap.m.QuickViewBase.AfterNavigateDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterNavigate afterNavigate} event of this <code>sap.m.QuickViewBase</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.QuickViewBase</code> itself.
				/// 
				/// The event is fired when navigation between two pages has completed. In case of animated transitions this event is fired with some delay after the "navigate" event.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.QuickViewBase attachAfterNavigate(object oData, sap.m.QuickViewBase.AfterNavigateDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterNavigate afterNavigate} event of this <code>sap.m.QuickViewBase</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.QuickViewBase</code> itself.
				/// 
				/// The event is fired when navigation between two pages has completed. In case of animated transitions this event is fired with some delay after the "navigate" event.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.QuickViewBase attachAfterNavigate(sap.m.QuickViewBase.AfterNavigateDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:afterNavigate afterNavigate} event of this <code>sap.m.QuickViewBase</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.QuickViewBase</code> itself.
				/// 
				/// The event is fired when navigation between two pages has completed. In case of animated transitions this event is fired with some delay after the "navigate" event.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.QuickViewBase</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.QuickViewBase attachAfterNavigate(sap.m.QuickViewBase.AfterNavigateDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:afterNavigate afterNavigate} event of this <code>sap.m.QuickViewBase</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.QuickViewBase detachAfterNavigate(sap.m.QuickViewBase.AfterNavigateDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:afterNavigate afterNavigate} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.QuickViewBase fireAfterNavigate(sap.m.QuickViewBase.AfterNavigateInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:afterNavigate afterNavigate} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.QuickViewBase fireAfterNavigate();

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.QuickViewBase with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.QuickViewBase with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.QuickViewBase with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.QuickViewBase.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				/// <summary>
				/// Navigates to the previous page if there is such.
				/// </summary>
				public extern virtual void navigateBack();

				#endregion

				#endregion

			}
		}
	}
}
