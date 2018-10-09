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
			/// The carousel allows the user to browse through a set of items by swiping right or left. <h3>Overview</h3> The control is mostly used for showing a gallery of images, but can hold any sap.m control. <h3>Structure</h3> The carousel consists of a the following elements: <ul> <li>Content area - displays the different items.</li> <li>Navigation - arrows to the left and right for switching between items.</li> <li>(optional) Paging - indicator at the bottom to show the current position in the set.</li> </ul> The paging indicator can be configured as follows: <ul> <li><code>showPageIndicator</code> - determines if the indicator is displayed.</li> <li>If the pages are less than 9, the page indicator is represented with bullets.</li> <li>If the pages are 9 or more, the page indicator is numeric.</li> <li><code>pageIndicatorPlacement</code> - determines where the indicator is located. Default (<code>sap.m.PlacementType.Bottom</code>) - below the content.</li> </ul> Additionally, you can also change the location of the navigation arrows. By setting <code>arrowsPlacement</code> to <code>sap.m.CarouselArrowsPlacement.PageIndicator</code>, the arrows will be located at the bottom by the paging indicator. <h3>Usage</h3> <h4> When to use</h4> <ul> <li>The items you want to display are very different from each other.</li> <li>You want to display the items one after the other.</li> </ul> <h4> When not to use</h4> <ul> <li>The items you want to display need to be visible at the same time.</li> <li>The items you want to display are uniform and very similar</li> </ul> <h3>Responsive Behavior</h3> <ul> <li>On touch devices, navigation is performed with swipe gestures (swipe right or swipe left).</li> <li>On desktop, navigation is done with the navigation arrows.</li> <li>The paging indicator (when activated) is visible on each form factor.</li> </ul>
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.Carousel")]
			public partial class Carousel : sap.ui.core.Control
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
					/// The height of the carousel. Note that when a percentage value is used, the height of the surrounding container must be defined.
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> height;

					/// <summary>
					/// The width of the carousel. Note that when a percentage value is used, the height of the surrounding container must be defined.
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> width;

					/// <summary>
					/// Defines whether the carousel should loop, i.e show the first page after the last page is reached and vice versa.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> loop;

					/// <summary>
					/// Show or hide carousel's page indicator.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showPageIndicator;

					/// <summary>
					/// Defines where the carousel's page indicator is displayed. Possible values are sap.m.PlacementType.Top, sap.m.PlacementType.Bottom. Other values are ignored and the default value will be applied. The default value is sap.m.PlacementType.Bottom.
					/// </summary>
					public Union<sap.m.PlacementType, string, sap.ui.@base.ManagedObject.BindPropertyInfo> pageIndicatorPlacement;

					/// <summary>
					/// Show or hide busy indicator in the carousel when loading pages after swipe.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showBusyIndicator;

					/// <summary>
					/// Defines where the carousel's arrows are placed. Default is <code>sap.m.CarouselArrowsPlacement.Content</code> used to place the arrows on the sides of the carousel. Alternatively <code>sap.m.CarouselArrowsPlacement.PageIndicator</code> can be used to place the arrows on the sides of the page indicator.
					/// </summary>
					public Union<sap.m.CarouselArrowsPlacement, string, sap.ui.@base.ManagedObject.BindPropertyInfo> arrowsPlacement;

					/// <summary>
					/// The content which the carousel displays.
					/// </summary>
					public Union<sap.ui.core.Control[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> pages;

					/// <summary>
					/// Provides getter and setter for the currently displayed page. For the setter, argument may be the control itself, which must be member of the carousel's page list, or the control's id. The getter will return the control id
					/// </summary>
					public Union<sap.ui.core.Control, sap.ui.core.ID, string, sap.ui.@base.ManagedObject.BindPropertyInfo> activePage;

					/// <summary>
					/// Carousel requires a new page to be loaded. This event may be used to fill the content of that page
					/// </summary>
					public sap.m.Carousel.LoadPageDelegate loadPage;

					/// <summary>
					/// Carousel does not display a page any longer and unloads it. This event may be used to clean up the content of that page.
					/// </summary>
					public sap.m.Carousel.LoadPageDelegate unloadPage;

					/// <summary>
					/// This event is fired after a carousel swipe has been completed. It is triggered both by physical swipe events and through API carousel manipulations such as calling 'next', 'previous' or 'setActivePageId' functions.
					/// </summary>
					public sap.m.Carousel.PageChangedDelegate pageChanged;

				}

				#endregion

				#region Typed Parameters

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class LoadPageInfo
				{
					/// <summary>
					/// Id of the page which will be loaded
					/// </summary>
					public string pageId;

				}

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class PageChangedInfo
				{
					/// <summary>
					/// Id of the page which was active before the page change.
					/// </summary>
					public string oldActivePageId;

					/// <summary>
					/// Id of the page which is active after the page change.
					/// </summary>
					public string newActivePageId;

				}

				#endregion

				#region Delegates

				public delegate void LoadPageDelegate(sap.ui.@base.Event<sap.m.Carousel.LoadPageInfo> oEvent, object oData);

				public delegate void PageChangedDelegate(sap.ui.@base.Event<sap.m.Carousel.PageChangedInfo> oEvent, object oData);

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new Carousel.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern Carousel(string sId, sap.m.Carousel.Settings mSettings);

				/// <summary>
				/// Constructor for a new Carousel.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern Carousel(string sId);

				/// <summary>
				/// Constructor for a new Carousel.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern Carousel();

				/// <summary>
				/// Constructor for a new Carousel.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern Carousel(sap.m.Carousel.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property height

				/// <summary>
				/// Gets current value of property {@link #getHeight height}.
				/// 
				/// The height of the carousel. Note that when a percentage value is used, the height of the surrounding container must be defined.
				/// 
				/// Default value is <code>100%</code>.
				/// </summary>
				/// <returns>Value of property <code>height</code></returns>
				public extern virtual sap.ui.core.CSSSize getHeight();

				/// <summary>
				/// Sets a new value for property {@link #getHeight height}.
				/// 
				/// The height of the carousel. Note that when a percentage value is used, the height of the surrounding container must be defined.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>100%</code>.
				/// </summary>
				/// <param name="sHeight">New value for property <code>height</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Carousel setHeight(sap.ui.core.CSSSize sHeight);

				#endregion

				#region Methods for Property width

				/// <summary>
				/// Gets current value of property {@link #getWidth width}.
				/// 
				/// The width of the carousel. Note that when a percentage value is used, the height of the surrounding container must be defined.
				/// 
				/// Default value is <code>100%</code>.
				/// </summary>
				/// <returns>Value of property <code>width</code></returns>
				public extern virtual sap.ui.core.CSSSize getWidth();

				/// <summary>
				/// Sets a new value for property {@link #getWidth width}.
				/// 
				/// The width of the carousel. Note that when a percentage value is used, the height of the surrounding container must be defined.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>100%</code>.
				/// </summary>
				/// <param name="sWidth">New value for property <code>width</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Carousel setWidth(sap.ui.core.CSSSize sWidth);

				#endregion

				#region Methods for Property loop

				/// <summary>
				/// Gets current value of property {@link #getLoop loop}.
				/// 
				/// Defines whether the carousel should loop, i.e show the first page after the last page is reached and vice versa.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>loop</code></returns>
				public extern virtual bool getLoop();

				/// <summary>
				/// Sets a new value for property {@link #getLoop loop}.
				/// 
				/// Defines whether the carousel should loop, i.e show the first page after the last page is reached and vice versa.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bLoop">New value for property <code>loop</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Carousel setLoop(bool bLoop);

				#endregion

				#region Methods for Property showPageIndicator

				/// <summary>
				/// Gets current value of property {@link #getShowPageIndicator showPageIndicator}.
				/// 
				/// Show or hide carousel's page indicator.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>showPageIndicator</code></returns>
				public extern virtual bool getShowPageIndicator();

				/// <summary>
				/// Sets a new value for property {@link #getShowPageIndicator showPageIndicator}.
				/// 
				/// Show or hide carousel's page indicator.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bShowPageIndicator">New value for property <code>showPageIndicator</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Carousel setShowPageIndicator(bool bShowPageIndicator);

				#endregion

				#region Methods for Property pageIndicatorPlacement

				/// <summary>
				/// Gets current value of property {@link #getPageIndicatorPlacement pageIndicatorPlacement}.
				/// 
				/// Defines where the carousel's page indicator is displayed. Possible values are sap.m.PlacementType.Top, sap.m.PlacementType.Bottom. Other values are ignored and the default value will be applied. The default value is sap.m.PlacementType.Bottom.
				/// 
				/// Default value is <code>Bottom</code>.
				/// </summary>
				/// <returns>Value of property <code>pageIndicatorPlacement</code></returns>
				public extern virtual sap.m.PlacementType getPageIndicatorPlacement();

				/// <summary>
				/// Sets a new value for property {@link #getPageIndicatorPlacement pageIndicatorPlacement}.
				/// 
				/// Defines where the carousel's page indicator is displayed. Possible values are sap.m.PlacementType.Top, sap.m.PlacementType.Bottom. Other values are ignored and the default value will be applied. The default value is sap.m.PlacementType.Bottom.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Bottom</code>.
				/// </summary>
				/// <param name="sPageIndicatorPlacement">New value for property <code>pageIndicatorPlacement</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Carousel setPageIndicatorPlacement(sap.m.PlacementType sPageIndicatorPlacement);

				#endregion

				#region Methods for Property showBusyIndicator

				/// <summary>
				/// Gets current value of property {@link #getShowBusyIndicator showBusyIndicator}.
				/// 
				/// Show or hide busy indicator in the carousel when loading pages after swipe.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>showBusyIndicator</code></returns>
				[Obsolete("Deprecated since 1.18.7. Since 1.18.7 pages are no longer loaded or unloaded. Therefore busy indicator is not necessary any longer.")]
				public extern virtual bool getShowBusyIndicator();

				/// <summary>
				/// Sets a new value for property {@link #getShowBusyIndicator showBusyIndicator}.
				/// 
				/// Show or hide busy indicator in the carousel when loading pages after swipe.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bShowBusyIndicator">New value for property <code>showBusyIndicator</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.18.7. Since 1.18.7 pages are no longer loaded or unloaded. Therefore busy indicator is not necessary any longer.")]
				public extern virtual sap.m.Carousel setShowBusyIndicator(bool bShowBusyIndicator);

				#endregion

				#region Methods for Property arrowsPlacement

				/// <summary>
				/// Gets current value of property {@link #getArrowsPlacement arrowsPlacement}.
				/// 
				/// Defines where the carousel's arrows are placed. Default is <code>sap.m.CarouselArrowsPlacement.Content</code> used to place the arrows on the sides of the carousel. Alternatively <code>sap.m.CarouselArrowsPlacement.PageIndicator</code> can be used to place the arrows on the sides of the page indicator.
				/// 
				/// Default value is <code>Content</code>.
				/// </summary>
				/// <returns>Value of property <code>arrowsPlacement</code></returns>
				public extern virtual sap.m.CarouselArrowsPlacement getArrowsPlacement();

				/// <summary>
				/// Sets a new value for property {@link #getArrowsPlacement arrowsPlacement}.
				/// 
				/// Defines where the carousel's arrows are placed. Default is <code>sap.m.CarouselArrowsPlacement.Content</code> used to place the arrows on the sides of the carousel. Alternatively <code>sap.m.CarouselArrowsPlacement.PageIndicator</code> can be used to place the arrows on the sides of the page indicator.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Content</code>.
				/// </summary>
				/// <param name="sArrowsPlacement">New value for property <code>arrowsPlacement</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Carousel setArrowsPlacement(sap.m.CarouselArrowsPlacement sArrowsPlacement);

				#endregion

				#region Methods for Aggregation pages

				/// <summary>
				/// Gets content of aggregation {@link #getPages pages}.
				/// 
				/// The content which the carousel displays.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.Control[] getPages();

				/// <summary>
				/// Destroys all the pages in the aggregation {@link #getPages pages}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Carousel destroyPages();

				/// <summary>
				/// Inserts a page into the aggregation {@link #getPages pages}.
				/// </summary>
				/// <param name="oPage">The page to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the page should be inserted at; for a negative value of <code>iIndex</code>, the page is inserted at position 0; for a value greater than the current size of the aggregation, the page is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Carousel insertPage(sap.ui.core.Control oPage, int iIndex);

				/// <summary>
				/// Adds some page to the aggregation {@link #getPages pages}.
				/// </summary>
				/// <param name="oPage">The page to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Carousel addPage(sap.ui.core.Control oPage);

				/// <summary>
				/// Removes a page from the aggregation {@link #getPages pages}.
				/// </summary>
				/// <param name="vPage">The page to remove or its index or id</param>
				/// <returns>The removed page or <code>null</code></returns>
				public extern virtual sap.ui.core.Control removePage(Union<int, string, sap.ui.core.Control> vPage);

				/// <summary>
				/// Checks for the provided <code>sap.ui.core.Control</code> in the aggregation {@link #getPages pages}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oPage">The page whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfPage(sap.ui.core.Control oPage);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getPages pages}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.ui.core.Control[] removeAllPages();

				#endregion

				#region Methods for Association activePage

				/// <summary>
				/// ID of the element which is the current target of the association {@link #getActivePage activePage}, or <code>null</code>.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.ID getActivePage();

				/// <summary>
				/// Sets the associated {@link #getActivePage activePage}.
				/// </summary>
				/// <param name="oActivePage">ID of an element which becomes the new target of this activePage association; alternatively, an element instance may be given</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Carousel setActivePage(Union<sap.ui.core.ID, sap.ui.core.Control> oActivePage);

				#endregion

				#region Methods for Event loadPage

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:loadPage loadPage} event of this <code>sap.m.Carousel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Carousel</code> itself.
				/// 
				/// Carousel requires a new page to be loaded. This event may be used to fill the content of that page
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.Carousel</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.18.7. Since 1.18.7 pages are no longer loaded or unloaded")]
				public extern virtual sap.m.Carousel attachLoadPage(object oData, sap.m.Carousel.LoadPageDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:loadPage loadPage} event of this <code>sap.m.Carousel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Carousel</code> itself.
				/// 
				/// Carousel requires a new page to be loaded. This event may be used to fill the content of that page
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.18.7. Since 1.18.7 pages are no longer loaded or unloaded")]
				public extern virtual sap.m.Carousel attachLoadPage(object oData, sap.m.Carousel.LoadPageDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:loadPage loadPage} event of this <code>sap.m.Carousel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Carousel</code> itself.
				/// 
				/// Carousel requires a new page to be loaded. This event may be used to fill the content of that page
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.18.7. Since 1.18.7 pages are no longer loaded or unloaded")]
				public extern virtual sap.m.Carousel attachLoadPage(sap.m.Carousel.LoadPageDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:loadPage loadPage} event of this <code>sap.m.Carousel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Carousel</code> itself.
				/// 
				/// Carousel requires a new page to be loaded. This event may be used to fill the content of that page
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.Carousel</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.18.7. Since 1.18.7 pages are no longer loaded or unloaded")]
				public extern virtual sap.m.Carousel attachLoadPage(sap.m.Carousel.LoadPageDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:loadPage loadPage} event of this <code>sap.m.Carousel</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.18.7. Since 1.18.7 pages are no longer loaded or unloaded")]
				public extern virtual sap.m.Carousel detachLoadPage(sap.m.Carousel.LoadPageDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:loadPage loadPage} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.18.7. Since 1.18.7 pages are no longer loaded or unloaded")]
				public extern virtual sap.m.Carousel fireLoadPage(sap.m.Carousel.LoadPageInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:loadPage loadPage} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.18.7. Since 1.18.7 pages are no longer loaded or unloaded")]
				public extern virtual sap.m.Carousel fireLoadPage();

				#endregion

				#region Methods for Event unloadPage

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:unloadPage unloadPage} event of this <code>sap.m.Carousel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Carousel</code> itself.
				/// 
				/// Carousel does not display a page any longer and unloads it. This event may be used to clean up the content of that page.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.Carousel</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.18.7. Since 1.18.7 pages are no longer loaded or unloaded")]
				public extern virtual sap.m.Carousel attachUnloadPage(object oData, sap.m.Carousel.LoadPageDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:unloadPage unloadPage} event of this <code>sap.m.Carousel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Carousel</code> itself.
				/// 
				/// Carousel does not display a page any longer and unloads it. This event may be used to clean up the content of that page.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.18.7. Since 1.18.7 pages are no longer loaded or unloaded")]
				public extern virtual sap.m.Carousel attachUnloadPage(object oData, sap.m.Carousel.LoadPageDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:unloadPage unloadPage} event of this <code>sap.m.Carousel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Carousel</code> itself.
				/// 
				/// Carousel does not display a page any longer and unloads it. This event may be used to clean up the content of that page.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.18.7. Since 1.18.7 pages are no longer loaded or unloaded")]
				public extern virtual sap.m.Carousel attachUnloadPage(sap.m.Carousel.LoadPageDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:unloadPage unloadPage} event of this <code>sap.m.Carousel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Carousel</code> itself.
				/// 
				/// Carousel does not display a page any longer and unloads it. This event may be used to clean up the content of that page.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.Carousel</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.18.7. Since 1.18.7 pages are no longer loaded or unloaded")]
				public extern virtual sap.m.Carousel attachUnloadPage(sap.m.Carousel.LoadPageDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:unloadPage unloadPage} event of this <code>sap.m.Carousel</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.18.7. Since 1.18.7 pages are no longer loaded or unloaded")]
				public extern virtual sap.m.Carousel detachUnloadPage(sap.m.Carousel.LoadPageDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:unloadPage unloadPage} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.18.7. Since 1.18.7 pages are no longer loaded or unloaded")]
				public extern virtual sap.m.Carousel fireUnloadPage(sap.m.Carousel.LoadPageInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:unloadPage unloadPage} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.18.7. Since 1.18.7 pages are no longer loaded or unloaded")]
				public extern virtual sap.m.Carousel fireUnloadPage();

				#endregion

				#region Methods for Event pageChanged

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:pageChanged pageChanged} event of this <code>sap.m.Carousel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Carousel</code> itself.
				/// 
				/// This event is fired after a carousel swipe has been completed. It is triggered both by physical swipe events and through API carousel manipulations such as calling 'next', 'previous' or 'setActivePageId' functions.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.Carousel</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Carousel attachPageChanged(object oData, sap.m.Carousel.PageChangedDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:pageChanged pageChanged} event of this <code>sap.m.Carousel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Carousel</code> itself.
				/// 
				/// This event is fired after a carousel swipe has been completed. It is triggered both by physical swipe events and through API carousel manipulations such as calling 'next', 'previous' or 'setActivePageId' functions.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Carousel attachPageChanged(object oData, sap.m.Carousel.PageChangedDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:pageChanged pageChanged} event of this <code>sap.m.Carousel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Carousel</code> itself.
				/// 
				/// This event is fired after a carousel swipe has been completed. It is triggered both by physical swipe events and through API carousel manipulations such as calling 'next', 'previous' or 'setActivePageId' functions.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Carousel attachPageChanged(sap.m.Carousel.PageChangedDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:pageChanged pageChanged} event of this <code>sap.m.Carousel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Carousel</code> itself.
				/// 
				/// This event is fired after a carousel swipe has been completed. It is triggered both by physical swipe events and through API carousel manipulations such as calling 'next', 'previous' or 'setActivePageId' functions.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.Carousel</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Carousel attachPageChanged(sap.m.Carousel.PageChangedDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:pageChanged pageChanged} event of this <code>sap.m.Carousel</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Carousel detachPageChanged(sap.m.Carousel.PageChangedDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:pageChanged pageChanged} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Carousel firePageChanged(sap.m.Carousel.PageChangedInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:pageChanged pageChanged} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Carousel firePageChanged();

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.Carousel with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.Carousel with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.Carousel with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.Carousel.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				/// <summary>
				/// Call this method to display the next page (corresponds to a swipe right). Returns 'this' for method chaining.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.Carousel next();

				/// <summary>
				/// Call this method to display the previous page (corresponds to a swipe left). Returns 'this' for method chaining.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.Carousel previous();

				#endregion

				#endregion

			}
		}
	}
}
