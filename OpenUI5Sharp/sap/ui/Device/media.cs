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
			public partial class Device
			{
				/// <summary>
				/// Event API for screen width changes.
				/// 
				/// This API is based on media queries but can also be used if media queries are not natively supported by the used browser. In this case, the behavior of media queries is simulated by this API.
				/// 
				/// There are several predefined {@link sap.ui.Device.media.RANGESETS range sets} available. Each of them defines a set of intervals for the screen width (from small to large). Whenever the screen width changes and the current screen width is in a different interval to the one before the change, the registered event handlers for the range set are called.
				/// 
				/// If needed, it is also possible to define a custom set of intervals.
				/// 
				/// The following example shows a typical use case: <pre>
				/// function sizeChanged(mParams) {
				///     switch(mParams.name) {
				///         case "Phone":
				///             // Do what is needed for a little screen
				///             break;
				///         case "Tablet":
				///             // Do what is needed for a medium sized screen
				///             break;
				///         case "Desktop":
				///             // Do what is needed for a large screen
				///     }
				/// }
				/// 
				/// // Register an event handler to changes of the screen size
				/// sap.ui.Device.media.attachHandler(sizeChanged, null, sap.ui.Device.media.RANGESETS.SAP_STANDARD);
				/// // Do some initialization work based on the current size
				/// sizeChanged(sap.ui.Device.media.getCurrentRange(sap.ui.Device.media.RANGESETS.SAP_STANDARD));
				/// </pre>
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.Device.media")]
				public partial class Media
				{
					#region Methods

					/// <summary>
					/// Registers the given event handler to change events of the screen width based on the range set with the specified name.
					/// 
					/// The event is fired whenever the screen width changes and the current screen width is in a different interval of the given range set than before the width change.
					/// 
					/// The event handler is called with a single argument: a map <code>mParams</code> which provides the following information about the entered interval: <ul> <li><code>mParams.from</code>: The start value (inclusive) of the entered interval as a number</li> <li><code>mParams.to</code>: The end value (exclusive) range of the entered interval as a number or undefined for the last interval (infinity)</li> <li><code>mParams.unit</code>: The unit used for the values above, e.g. <code>"px"</code></li> <li><code>mParams.name</code>: The name of the entered interval, if available</li> </ul>
					/// </summary>
					/// <param name="fnFunction">The handler function to call when the event occurs. This function will be called in the context of the <code>oListener</code> instance (if present) or on the <code>window</code> instance. A map with information about the entered range set is provided as a single argument to the handler (see details above).</param>
					/// <param name="oListener">The object that wants to be notified when the event occurs (<code>this</code> context within the handler function). If it is not specified, the handler function is called in the context of the <code>window</code>.</param>
					/// <param name="sName">The name of the range set to listen to. The range set must be initialized beforehand ({@link sap.ui.Device.media.initRangeSet}). If no name is provided, the {@link sap.ui.Device.media.RANGESETS.SAP_STANDARD default range set} is used.</param>
					public extern virtual void attachHandler(object fnFunction, object oListener, string sName);

					/// <summary>
					/// Registers the given event handler to change events of the screen width based on the range set with the specified name.
					/// 
					/// The event is fired whenever the screen width changes and the current screen width is in a different interval of the given range set than before the width change.
					/// 
					/// The event handler is called with a single argument: a map <code>mParams</code> which provides the following information about the entered interval: <ul> <li><code>mParams.from</code>: The start value (inclusive) of the entered interval as a number</li> <li><code>mParams.to</code>: The end value (exclusive) range of the entered interval as a number or undefined for the last interval (infinity)</li> <li><code>mParams.unit</code>: The unit used for the values above, e.g. <code>"px"</code></li> <li><code>mParams.name</code>: The name of the entered interval, if available</li> </ul>
					/// </summary>
					/// <param name="fnFunction">The handler function to call when the event occurs. This function will be called in the context of the <code>oListener</code> instance (if present) or on the <code>window</code> instance. A map with information about the entered range set is provided as a single argument to the handler (see details above).</param>
					/// <param name="oListener">The object that wants to be notified when the event occurs (<code>this</code> context within the handler function). If it is not specified, the handler function is called in the context of the <code>window</code>.</param>
					public extern virtual void attachHandler(object fnFunction, object oListener);

					/// <summary>
					/// Registers the given event handler to change events of the screen width based on the range set with the specified name.
					/// 
					/// The event is fired whenever the screen width changes and the current screen width is in a different interval of the given range set than before the width change.
					/// 
					/// The event handler is called with a single argument: a map <code>mParams</code> which provides the following information about the entered interval: <ul> <li><code>mParams.from</code>: The start value (inclusive) of the entered interval as a number</li> <li><code>mParams.to</code>: The end value (exclusive) range of the entered interval as a number or undefined for the last interval (infinity)</li> <li><code>mParams.unit</code>: The unit used for the values above, e.g. <code>"px"</code></li> <li><code>mParams.name</code>: The name of the entered interval, if available</li> </ul>
					/// </summary>
					/// <param name="fnFunction">The handler function to call when the event occurs. This function will be called in the context of the <code>oListener</code> instance (if present) or on the <code>window</code> instance. A map with information about the entered range set is provided as a single argument to the handler (see details above).</param>
					public extern virtual void attachHandler(object fnFunction);

					/// <summary>
					/// Removes a previously attached event handler from the change events of the screen width.
					/// 
					/// The passed parameters must match those used for registration with {@link #.attachHandler} beforehand.
					/// </summary>
					/// <param name="fnFunction">The handler function to detach from the event</param>
					/// <param name="oListener">The object that wanted to be notified when the event occurred</param>
					/// <param name="sName">The name of the range set to listen to. If no name is provided, the {@link sap.ui.Device.media.RANGESETS.SAP_STANDARD default range set} is used.</param>
					public extern virtual void detachHandler(object fnFunction, object oListener, string sName);

					/// <summary>
					/// Removes a previously attached event handler from the change events of the screen width.
					/// 
					/// The passed parameters must match those used for registration with {@link #.attachHandler} beforehand.
					/// </summary>
					/// <param name="fnFunction">The handler function to detach from the event</param>
					/// <param name="oListener">The object that wanted to be notified when the event occurred</param>
					public extern virtual void detachHandler(object fnFunction, object oListener);

					/// <summary>
					/// Removes a previously attached event handler from the change events of the screen width.
					/// 
					/// The passed parameters must match those used for registration with {@link #.attachHandler} beforehand.
					/// </summary>
					/// <param name="fnFunction">The handler function to detach from the event</param>
					public extern virtual void detachHandler(object fnFunction);

					/// <summary>
					/// Returns information about the current active range of the range set with the given name.
					/// 
					/// If the optional parameter <code>iWidth</iWidth> is given, the active range will be determined for that width, otherwise it is determined for the current window size.
					/// </summary>
					/// <param name="sName">The name of the range set. The range set must be initialized beforehand ({@link sap.ui.Device.media.initRangeSet})</param>
					/// <param name="iWidth">An optional width, based on which the range should be determined; If <code>iWidth</code> is not a number, the window size will be used.</param>
					/// <returns>Information about the current active interval of the range set. The returned map has the same structure as the argument of the event handlers ({@link sap.ui.Device.media.attachHandler})</returns>
					public extern virtual Map getCurrentRange(string sName, int iWidth);

					/// <summary>
					/// Returns information about the current active range of the range set with the given name.
					/// 
					/// If the optional parameter <code>iWidth</iWidth> is given, the active range will be determined for that width, otherwise it is determined for the current window size.
					/// </summary>
					/// <param name="sName">The name of the range set. The range set must be initialized beforehand ({@link sap.ui.Device.media.initRangeSet})</param>
					/// <returns>Information about the current active interval of the range set. The returned map has the same structure as the argument of the event handlers ({@link sap.ui.Device.media.attachHandler})</returns>
					public extern virtual Map getCurrentRange(string sName);

					/// <summary>
					/// Returns <code>true</code> if a range set with the given name is already initialized.
					/// </summary>
					/// <param name="sName">The name of the range set.</param>
					/// <returns>Returns <code>true</code> if a range set with the given name is already initialized</returns>
					public extern virtual bool hasRangeSet(string sName);

					/// <summary>
					/// Initializes a screen width media query range set.
					/// 
					/// This initialization step makes the range set ready to be used for one of the other functions in namespace <code>sap.ui.Device.media</code>. The most important {@link sap.ui.Device.media.RANGESETS predefined range sets} are initialized automatically.
					/// 
					/// To make a not yet initialized {@link sap.ui.Device.media.RANGESETS predefined range set} ready to be used, call this function with the name of the range set to be initialized: <pre>
					/// sap.ui.Device.media.initRangeSet(sap.ui.Device.media.RANGESETS.SAP_3STEPS);
					/// </pre>
					/// 
					/// Alternatively it is possible to define custom range sets as shown in the following example: <pre>
					/// sap.ui.Device.media.initRangeSet("MyRangeSet", [200, 400], "px", ["Small", "Medium", "Large"]);
					/// </pre> This example defines the following named ranges: <ul> <li><code>"Small"</code>: For screens smaller than 200 pixels.</li> <li><code>"Medium"</code>: For screens greater than or equal to 200 pixels and smaller than 400 pixels.</li> <li><code>"Large"</code>: For screens greater than or equal to 400 pixels.</li> </ul> The range names are optional. If they are specified a CSS class (e.g. <code>sapUiMedia-MyRangeSet-Small</code>) is also added to the document root depending on the current active range. This can be suppressed via parameter <code>bSuppressClasses</code>.
					/// </summary>
					/// <param name="sName">The name of the range set to be initialized - either a {@link sap.ui.Device.media.RANGESETS predefined} or custom one. The name must be a valid id and consist only of letters and numeric digits.</param>
					/// <param name="aRangeBorders">The range borders</param>
					/// <param name="sUnit">The unit which should be used for the values given in <code>aRangeBorders</code>. The allowed values are <code>"px"</code> (default), <code>"em"</code> or <code>"rem"</code></param>
					/// <param name="aRangeNames">The names of the ranges. The names must be a valid id and consist only of letters and digits. If names are specified, CSS classes are also added to the document root as described above. This behavior can be switched off explicitly by using <code>bSuppressClasses</code>. <b>Note:</b> <code>aRangeBorders</code> with <code>n</code> entries define <code>n+1</code> ranges. Therefore <code>n+1</code> names must be provided.</param>
					/// <param name="bSuppressClasses">Whether or not writing of CSS classes to the document root should be suppressed when <code>aRangeNames</code> are provided</param>
					public extern virtual void initRangeSet(string sName, int[] aRangeBorders, string sUnit, string[] aRangeNames, bool bSuppressClasses);

					/// <summary>
					/// Initializes a screen width media query range set.
					/// 
					/// This initialization step makes the range set ready to be used for one of the other functions in namespace <code>sap.ui.Device.media</code>. The most important {@link sap.ui.Device.media.RANGESETS predefined range sets} are initialized automatically.
					/// 
					/// To make a not yet initialized {@link sap.ui.Device.media.RANGESETS predefined range set} ready to be used, call this function with the name of the range set to be initialized: <pre>
					/// sap.ui.Device.media.initRangeSet(sap.ui.Device.media.RANGESETS.SAP_3STEPS);
					/// </pre>
					/// 
					/// Alternatively it is possible to define custom range sets as shown in the following example: <pre>
					/// sap.ui.Device.media.initRangeSet("MyRangeSet", [200, 400], "px", ["Small", "Medium", "Large"]);
					/// </pre> This example defines the following named ranges: <ul> <li><code>"Small"</code>: For screens smaller than 200 pixels.</li> <li><code>"Medium"</code>: For screens greater than or equal to 200 pixels and smaller than 400 pixels.</li> <li><code>"Large"</code>: For screens greater than or equal to 400 pixels.</li> </ul> The range names are optional. If they are specified a CSS class (e.g. <code>sapUiMedia-MyRangeSet-Small</code>) is also added to the document root depending on the current active range. This can be suppressed via parameter <code>bSuppressClasses</code>.
					/// </summary>
					/// <param name="sName">The name of the range set to be initialized - either a {@link sap.ui.Device.media.RANGESETS predefined} or custom one. The name must be a valid id and consist only of letters and numeric digits.</param>
					/// <param name="aRangeBorders">The range borders</param>
					/// <param name="sUnit">The unit which should be used for the values given in <code>aRangeBorders</code>. The allowed values are <code>"px"</code> (default), <code>"em"</code> or <code>"rem"</code></param>
					/// <param name="aRangeNames">The names of the ranges. The names must be a valid id and consist only of letters and digits. If names are specified, CSS classes are also added to the document root as described above. This behavior can be switched off explicitly by using <code>bSuppressClasses</code>. <b>Note:</b> <code>aRangeBorders</code> with <code>n</code> entries define <code>n+1</code> ranges. Therefore <code>n+1</code> names must be provided.</param>
					/// <param name="bSuppressClasses">Whether or not writing of CSS classes to the document root should be suppressed when <code>aRangeNames</code> are provided</param>
					public extern virtual void initRangeSet(string sName, int[] aRangeBorders, string sUnit, object[] aRangeNames, bool bSuppressClasses);

					/// <summary>
					/// Initializes a screen width media query range set.
					/// 
					/// This initialization step makes the range set ready to be used for one of the other functions in namespace <code>sap.ui.Device.media</code>. The most important {@link sap.ui.Device.media.RANGESETS predefined range sets} are initialized automatically.
					/// 
					/// To make a not yet initialized {@link sap.ui.Device.media.RANGESETS predefined range set} ready to be used, call this function with the name of the range set to be initialized: <pre>
					/// sap.ui.Device.media.initRangeSet(sap.ui.Device.media.RANGESETS.SAP_3STEPS);
					/// </pre>
					/// 
					/// Alternatively it is possible to define custom range sets as shown in the following example: <pre>
					/// sap.ui.Device.media.initRangeSet("MyRangeSet", [200, 400], "px", ["Small", "Medium", "Large"]);
					/// </pre> This example defines the following named ranges: <ul> <li><code>"Small"</code>: For screens smaller than 200 pixels.</li> <li><code>"Medium"</code>: For screens greater than or equal to 200 pixels and smaller than 400 pixels.</li> <li><code>"Large"</code>: For screens greater than or equal to 400 pixels.</li> </ul> The range names are optional. If they are specified a CSS class (e.g. <code>sapUiMedia-MyRangeSet-Small</code>) is also added to the document root depending on the current active range. This can be suppressed via parameter <code>bSuppressClasses</code>.
					/// </summary>
					/// <param name="sName">The name of the range set to be initialized - either a {@link sap.ui.Device.media.RANGESETS predefined} or custom one. The name must be a valid id and consist only of letters and numeric digits.</param>
					/// <param name="aRangeBorders">The range borders</param>
					/// <param name="sUnit">The unit which should be used for the values given in <code>aRangeBorders</code>. The allowed values are <code>"px"</code> (default), <code>"em"</code> or <code>"rem"</code></param>
					/// <param name="aRangeNames">The names of the ranges. The names must be a valid id and consist only of letters and digits. If names are specified, CSS classes are also added to the document root as described above. This behavior can be switched off explicitly by using <code>bSuppressClasses</code>. <b>Note:</b> <code>aRangeBorders</code> with <code>n</code> entries define <code>n+1</code> ranges. Therefore <code>n+1</code> names must be provided.</param>
					public extern virtual void initRangeSet(string sName, int[] aRangeBorders, string sUnit, string[] aRangeNames);

					/// <summary>
					/// Initializes a screen width media query range set.
					/// 
					/// This initialization step makes the range set ready to be used for one of the other functions in namespace <code>sap.ui.Device.media</code>. The most important {@link sap.ui.Device.media.RANGESETS predefined range sets} are initialized automatically.
					/// 
					/// To make a not yet initialized {@link sap.ui.Device.media.RANGESETS predefined range set} ready to be used, call this function with the name of the range set to be initialized: <pre>
					/// sap.ui.Device.media.initRangeSet(sap.ui.Device.media.RANGESETS.SAP_3STEPS);
					/// </pre>
					/// 
					/// Alternatively it is possible to define custom range sets as shown in the following example: <pre>
					/// sap.ui.Device.media.initRangeSet("MyRangeSet", [200, 400], "px", ["Small", "Medium", "Large"]);
					/// </pre> This example defines the following named ranges: <ul> <li><code>"Small"</code>: For screens smaller than 200 pixels.</li> <li><code>"Medium"</code>: For screens greater than or equal to 200 pixels and smaller than 400 pixels.</li> <li><code>"Large"</code>: For screens greater than or equal to 400 pixels.</li> </ul> The range names are optional. If they are specified a CSS class (e.g. <code>sapUiMedia-MyRangeSet-Small</code>) is also added to the document root depending on the current active range. This can be suppressed via parameter <code>bSuppressClasses</code>.
					/// </summary>
					/// <param name="sName">The name of the range set to be initialized - either a {@link sap.ui.Device.media.RANGESETS predefined} or custom one. The name must be a valid id and consist only of letters and numeric digits.</param>
					/// <param name="aRangeBorders">The range borders</param>
					/// <param name="sUnit">The unit which should be used for the values given in <code>aRangeBorders</code>. The allowed values are <code>"px"</code> (default), <code>"em"</code> or <code>"rem"</code></param>
					/// <param name="aRangeNames">The names of the ranges. The names must be a valid id and consist only of letters and digits. If names are specified, CSS classes are also added to the document root as described above. This behavior can be switched off explicitly by using <code>bSuppressClasses</code>. <b>Note:</b> <code>aRangeBorders</code> with <code>n</code> entries define <code>n+1</code> ranges. Therefore <code>n+1</code> names must be provided.</param>
					public extern virtual void initRangeSet(string sName, int[] aRangeBorders, string sUnit, object[] aRangeNames);

					/// <summary>
					/// Initializes a screen width media query range set.
					/// 
					/// This initialization step makes the range set ready to be used for one of the other functions in namespace <code>sap.ui.Device.media</code>. The most important {@link sap.ui.Device.media.RANGESETS predefined range sets} are initialized automatically.
					/// 
					/// To make a not yet initialized {@link sap.ui.Device.media.RANGESETS predefined range set} ready to be used, call this function with the name of the range set to be initialized: <pre>
					/// sap.ui.Device.media.initRangeSet(sap.ui.Device.media.RANGESETS.SAP_3STEPS);
					/// </pre>
					/// 
					/// Alternatively it is possible to define custom range sets as shown in the following example: <pre>
					/// sap.ui.Device.media.initRangeSet("MyRangeSet", [200, 400], "px", ["Small", "Medium", "Large"]);
					/// </pre> This example defines the following named ranges: <ul> <li><code>"Small"</code>: For screens smaller than 200 pixels.</li> <li><code>"Medium"</code>: For screens greater than or equal to 200 pixels and smaller than 400 pixels.</li> <li><code>"Large"</code>: For screens greater than or equal to 400 pixels.</li> </ul> The range names are optional. If they are specified a CSS class (e.g. <code>sapUiMedia-MyRangeSet-Small</code>) is also added to the document root depending on the current active range. This can be suppressed via parameter <code>bSuppressClasses</code>.
					/// </summary>
					/// <param name="sName">The name of the range set to be initialized - either a {@link sap.ui.Device.media.RANGESETS predefined} or custom one. The name must be a valid id and consist only of letters and numeric digits.</param>
					/// <param name="aRangeBorders">The range borders</param>
					/// <param name="sUnit">The unit which should be used for the values given in <code>aRangeBorders</code>. The allowed values are <code>"px"</code> (default), <code>"em"</code> or <code>"rem"</code></param>
					public extern virtual void initRangeSet(string sName, int[] aRangeBorders, string sUnit);

					/// <summary>
					/// Initializes a screen width media query range set.
					/// 
					/// This initialization step makes the range set ready to be used for one of the other functions in namespace <code>sap.ui.Device.media</code>. The most important {@link sap.ui.Device.media.RANGESETS predefined range sets} are initialized automatically.
					/// 
					/// To make a not yet initialized {@link sap.ui.Device.media.RANGESETS predefined range set} ready to be used, call this function with the name of the range set to be initialized: <pre>
					/// sap.ui.Device.media.initRangeSet(sap.ui.Device.media.RANGESETS.SAP_3STEPS);
					/// </pre>
					/// 
					/// Alternatively it is possible to define custom range sets as shown in the following example: <pre>
					/// sap.ui.Device.media.initRangeSet("MyRangeSet", [200, 400], "px", ["Small", "Medium", "Large"]);
					/// </pre> This example defines the following named ranges: <ul> <li><code>"Small"</code>: For screens smaller than 200 pixels.</li> <li><code>"Medium"</code>: For screens greater than or equal to 200 pixels and smaller than 400 pixels.</li> <li><code>"Large"</code>: For screens greater than or equal to 400 pixels.</li> </ul> The range names are optional. If they are specified a CSS class (e.g. <code>sapUiMedia-MyRangeSet-Small</code>) is also added to the document root depending on the current active range. This can be suppressed via parameter <code>bSuppressClasses</code>.
					/// </summary>
					/// <param name="sName">The name of the range set to be initialized - either a {@link sap.ui.Device.media.RANGESETS predefined} or custom one. The name must be a valid id and consist only of letters and numeric digits.</param>
					/// <param name="aRangeBorders">The range borders</param>
					public extern virtual void initRangeSet(string sName, int[] aRangeBorders);

					/// <summary>
					/// Initializes a screen width media query range set.
					/// 
					/// This initialization step makes the range set ready to be used for one of the other functions in namespace <code>sap.ui.Device.media</code>. The most important {@link sap.ui.Device.media.RANGESETS predefined range sets} are initialized automatically.
					/// 
					/// To make a not yet initialized {@link sap.ui.Device.media.RANGESETS predefined range set} ready to be used, call this function with the name of the range set to be initialized: <pre>
					/// sap.ui.Device.media.initRangeSet(sap.ui.Device.media.RANGESETS.SAP_3STEPS);
					/// </pre>
					/// 
					/// Alternatively it is possible to define custom range sets as shown in the following example: <pre>
					/// sap.ui.Device.media.initRangeSet("MyRangeSet", [200, 400], "px", ["Small", "Medium", "Large"]);
					/// </pre> This example defines the following named ranges: <ul> <li><code>"Small"</code>: For screens smaller than 200 pixels.</li> <li><code>"Medium"</code>: For screens greater than or equal to 200 pixels and smaller than 400 pixels.</li> <li><code>"Large"</code>: For screens greater than or equal to 400 pixels.</li> </ul> The range names are optional. If they are specified a CSS class (e.g. <code>sapUiMedia-MyRangeSet-Small</code>) is also added to the document root depending on the current active range. This can be suppressed via parameter <code>bSuppressClasses</code>.
					/// </summary>
					/// <param name="sName">The name of the range set to be initialized - either a {@link sap.ui.Device.media.RANGESETS predefined} or custom one. The name must be a valid id and consist only of letters and numeric digits.</param>
					public extern virtual void initRangeSet(string sName);

					/// <summary>
					/// Removes a previously initialized range set and detaches all registered handlers.
					/// 
					/// Only custom range sets can be removed via this function. Initialized predefined range sets ({@link sap.ui.Device.media.RANGESETS}) cannot be removed.
					/// </summary>
					/// <param name="sName">The name of the range set which should be removed.</param>
					public extern virtual void removeRangeSet(string sName);

					#endregion

					/// <summary>
					/// Enumeration containing the names and settings of predefined screen width media query range sets.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.Device.media.RANGESETS")]
					public enum RANGESETS
					{
						/// <summary>
						/// A 3-step range set (S-L).
						/// 
						/// The ranges of this set are: <ul> <li><code>"S"</code>: For screens smaller than 520 pixels.</li> <li><code>"M"</code>: For screens greater than or equal to 520 pixels and smaller than 960 pixels.</li> <li><code>"L"</code>: For screens greater than or equal to 960 pixels.</li> </ul>
						/// 
						/// To use this range set, you must initialize it explicitly ({@link sap.ui.Device.media.initRangeSet}).
						/// 
						/// If this range set is initialized, a CSS class is added to the page root (<code>html</code> tag) which indicates the current screen width range: <code>sapUiMedia-3Step-<i>NAME_OF_THE_INTERVAL</i></code>.
						/// </summary>
						SAP_3STEPS,
						/// <summary>
						/// A 4-step range set (S-XL).
						/// 
						/// The ranges of this set are: <ul> <li><code>"S"</code>: For screens smaller than 520 pixels.</li> <li><code>"M"</code>: For screens greater than or equal to 520 pixels and smaller than 760 pixels.</li> <li><code>"L"</code>: For screens greater than or equal to 760 pixels and smaller than 960 pixels.</li> <li><code>"XL"</code>: For screens greater than or equal to 960 pixels.</li> </ul>
						/// 
						/// To use this range set, you must initialize it explicitly ({@link sap.ui.Device.media.initRangeSet}).
						/// 
						/// If this range set is initialized, a CSS class is added to the page root (<code>html</code> tag) which indicates the current screen width range: <code>sapUiMedia-4Step-<i>NAME_OF_THE_INTERVAL</i></code>.
						/// </summary>
						SAP_4STEPS,
						/// <summary>
						/// A 6-step range set (XS-XXL).
						/// 
						/// The ranges of this set are: <ul> <li><code>"XS"</code>: For screens smaller than 241 pixels.</li> <li><code>"S"</code>: For screens greater than or equal to 241 pixels and smaller than 400 pixels.</li> <li><code>"M"</code>: For screens greater than or equal to 400 pixels and smaller than 541 pixels.</li> <li><code>"L"</code>: For screens greater than or equal to 541 pixels and smaller than 768 pixels.</li> <li><code>"XL"</code>: For screens greater than or equal to 768 pixels and smaller than 960 pixels.</li> <li><code>"XXL"</code>: For screens greater than or equal to 960 pixels.</li> </ul>
						/// 
						/// To use this range set, you must initialize it explicitly ({@link sap.ui.Device.media.initRangeSet}).
						/// 
						/// If this range set is initialized, a CSS class is added to the page root (<code>html</code> tag) which indicates the current screen width range: <code>sapUiMedia-6Step-<i>NAME_OF_THE_INTERVAL</i></code>.
						/// </summary>
						SAP_6STEPS,
						/// <summary>
						/// A 3-step range set (Phone, Tablet, Desktop).
						/// 
						/// The ranges of this set are: <ul> <li><code>"Phone"</code>: For screens smaller than 600 pixels.</li> <li><code>"Tablet"</code>: For screens greater than or equal to 600 pixels and smaller than 1024 pixels.</li> <li><code>"Desktop"</code>: For screens greater than or equal to 1024 pixels.</li> </ul>
						/// 
						/// This range set is initialized by default. An initialization via {@link sap.ui.Device.media.initRangeSet} is not needed.
						/// 
						/// A CSS class is added to the page root (<code>html</code> tag) which indicates the current screen width range: <code>sapUiMedia-Std-<i>NAME_OF_THE_INTERVAL</i></code>. Furthermore there are 5 additional CSS classes to hide elements based on the width of the screen: <ul> <li><code>sapUiHideOnPhone</code>: Will be hidden if the screen has 600px or more</li> <li><code>sapUiHideOnTablet</code>: Will be hidden if the screen has less than 600px or more than 1023px</li> <li><code>sapUiHideOnDesktop</code>: Will be hidden if the screen is smaller than 1024px</li> <li><code>sapUiVisibleOnlyOnPhone</code>: Will be visible if the screen has less than 600px</li> <li><code>sapUiVisibleOnlyOnTablet</code>: Will be visible if the screen has 600px or more but less than 1024px</li> <li><code>sapUiVisibleOnlyOnDesktop</code>: Will be visible if the screen has 1024px or more</li> </ul>
						/// </summary>
						SAP_STANDARD,
						/// <summary>
						/// A 4-step range set (Phone, Tablet, Desktop, LargeDesktop).
						/// 
						/// The ranges of this set are: <ul> <li><code>"Phone"</code>: For screens smaller than 600 pixels.</li> <li><code>"Tablet"</code>: For screens greater than or equal to 600 pixels and smaller than 1024 pixels.</li> <li><code>"Desktop"</code>: For screens greater than or equal to 1024 pixels and smaller than 1440 pixels.</li> <li><code>"LargeDesktop"</code>: For screens greater than or equal to 1440 pixels.</li> </ul>
						/// 
						/// This range set is initialized by default. An initialization via {@link sap.ui.Device.media.initRangeSet} is not needed.
						/// 
						/// A CSS class is added to the page root (<code>html</code> tag) which indicates the current screen width range: <code>sapUiMedia-StdExt-<i>NAME_OF_THE_INTERVAL</i></code>.
						/// </summary>
						SAP_STANDARD_EXTENDED,
					}
				}
			}
		}
	}
}
