using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	/// <summary>
	/// Provides base functionality of the SAP jQuery plugin as extension of the jQuery framework.<br/> See also <a href="http://api.jquery.com/jQuery/">jQuery</a> for details.<br/> Although these functions appear as static ones, they are meant to be used on jQuery instances.<br/> If not stated differently, the functions follow the fluent interface paradigm and return the jQuery instance for chaining of statements.
	/// 
	/// Example for usage of an instance method: <pre>
	///   var oRect = jQuery("#myDiv").rect();
	///   alert("Top Position: " + oRect.top);
	/// </pre>
	/// </summary>
	[External]
	[Namespace(false)]
	[Name("jQuery")]
	public abstract partial class jQuery : jquery.JQueryStatic<Retyped.dom.HTMLElement>
	{
		#region Typed Parameters

		/// <summary>
		/// Parameter to be used as Object Literal
		/// </summary>
		[External]
		[ObjectLiteral]
		public partial class InitOptions
		{
			/// <summary>
			/// whether to set the viewport in a way that disables zooming
			/// </summary>
			public bool viewport;

			/// <summary>
			/// the iOS status bar color, "default", "black" or "black-translucent"
			/// </summary>
			public string statusBar;

			/// <summary>
			/// whether the browser UI should be hidden as far as possible to make the app feel more native
			/// </summary>
			public bool hideBrowser;

			/// <summary>
			/// whether native scrolling should be disabled in order to prevent the "rubber-band" effect where the whole window is moved
			/// </summary>
			public bool preventScroll;

			/// <summary>
			/// whether Safari mobile should be prevented from transforming any numbers that look like phone numbers into clickable links
			/// </summary>
			public bool preventPhoneNumberDetection;

			/// <summary>
			/// the ID of the root element that should be made fullscreen; only used when hideBrowser is set. If not set, the body is used
			/// </summary>
			public string rootId;

			/// <summary>
			/// whether the height of the html root element should be set to 100%, which is required for other elements to cover the full height
			/// </summary>
			public bool useFullScreenHeight;

			/// <summary>
			/// deprecated since 1.12, use jQuery.sap.setIcons instead.
			/// </summary>
			public string homeIcon;

			/// <summary>
			/// deprecated since 1.12, use jQuery.sap.setIcons instead.
			/// </summary>
			public bool homeIconPrecomposed;

			/// <summary>
			/// whether the Application will be loaded in full screen mode after added to home screen on mobile devices. The default value for this property only enables the full screen mode when runs on iOS device.
			/// </summary>
			public bool mobileWebAppCapable;

		}

		/// <summary>
		/// Parameter to be used as Object Literal
		/// </summary>
		[External]
		[ObjectLiteral]
		public partial class Info
		{
			/// <summary>
			/// The URL to the .properties file which should be loaded
			/// </summary>
			public string url;

			/// <summary>
			/// Whether the .properties file should be loaded asynchronously or not
			/// </summary>
			public bool async;

			/// <summary>
			/// A map of additional header key/value pairs to send along with the request (see <code>headers</code> option of <code>jQuery.ajax</code>)
			/// </summary>
			public object headers;

			/// <summary>
			/// Whether <code>null</code> should be returned for a missing properties file; by default an empty collection is returned
			/// </summary>
			public object returnNullIfMissing;

		}

		/// <summary>
		/// Parameter to be used as Object Literal
		/// </summary>
		[External]
		[ObjectLiteral]
		public partial class Info2
		{
			/// <summary>
			/// URL pointing to the base .properties file of a bundle (.properties file without any locale information, e.g. "mybundle.properties")
			/// </summary>
			public string url;

			/// <summary>
			/// Optional language (aka 'locale') to load the texts for. Can either be a BCP47 language tag or a JDK compatible locale string (e.g. "en-GB", "en_GB" or "fr"); Defaults to the current session locale if <code>sap.ui.getCore</code> is available, otherwise to 'en'
			/// </summary>
			public string locale;

			/// <summary>
			/// Whether to include origin information into the returned property values
			/// </summary>
			public bool includeInfo;

			/// <summary>
			/// Whether the first bundle should be loaded asynchronously Note: Fallback bundles loaded by {@link #getText} are always loaded synchronously.
			/// </summary>
			public bool async;

		}

		#endregion

		#region Methods

		/// <summary>
		/// Adds the given ID reference to the aria-describedby attribute.
		/// </summary>
		/// <param name="sId">The ID reference of an element</param>
		/// <param name="bPrepend">whether prepend or not</param>
		/// <returns><code>this</code> to allow method chaining.</returns>
		public extern virtual jQuery addAriaDescribedBy(string sId, bool bPrepend = false);

		/// <summary>
		/// Adds the given ID reference to the the aria-labelledby attribute.
		/// </summary>
		/// <param name="sId">The ID reference of an element</param>
		/// <param name="bPrepend">Whether prepend or not</param>
		/// <returns><code>this</code> to allow method chaining.</returns>
		public extern virtual jQuery addAriaLabelledBy(string sId, bool bPrepend = false);

		/// <summary>
		/// Extension function to the jQuery.fn which identifies SAPUI5 controls in the given jQuery context.
		/// </summary>
		/// <param name="iIndex">Optional parameter to return the control instance at the given index in the array.</param>
		/// <param name="bIncludeRelated">Whether or not to respect the associated DOM elements to a control via <code>data-sap-ui-related</code> attribute.</param>
		/// <returns>Depending on the given context and index parameter an array of controls, an instance or null.</returns>
		public extern virtual Union<UI5.sap.ui.core.Control[], UI5.sap.ui.core.Control> control(int iIndex, bool bIncludeRelated);

		/// <summary>
		/// Extension function to the jQuery.fn which identifies SAPUI5 controls in the given jQuery context.
		/// </summary>
		/// <param name="iIndex">Optional parameter to return the control instance at the given index in the array.</param>
		/// <returns>Depending on the given context and index parameter an array of controls, an instance or null.</returns>
		public extern virtual Union<UI5.sap.ui.core.Control[], UI5.sap.ui.core.Control> control(int iIndex);

		/// <summary>
		/// Extension function to the jQuery.fn which identifies SAPUI5 controls in the given jQuery context.
		/// </summary>
		/// <returns>Depending on the given context and index parameter an array of controls, an instance or null.</returns>
		public extern virtual Union<UI5.sap.ui.core.Control[], UI5.sap.ui.core.Control> control();

		/// <summary>
		/// Extension function to the jQuery.fn which identifies SAPUI5 controls in the given jQuery context.
		/// </summary>
		/// <param name="bIncludeRelated">Whether or not to respect the associated DOM elements to a control via <code>data-sap-ui-related</code> attribute.</param>
		/// <returns>Depending on the given context and index parameter an array of controls, an instance or null.</returns>
		public extern virtual Union<UI5.sap.ui.core.Control[], UI5.sap.ui.core.Control> control(bool bIncludeRelated);

		/// <summary>
		/// Sets or gets the position of the cursor in an element that supports cursor positioning.
		/// </summary>
		/// <param name="iPos">The cursor position to set (or no parameter to retrieve the cursor position)</param>
		/// <returns>The cursor position (or the jQuery collection if the position has been set)</returns>
		public extern virtual Union<int, jQuery> cursorPos(int iPos);

		/// <summary>
		/// Disable HTML elements selection.
		/// </summary>
		/// <returns><code>this</code> to allow method chaining.</returns>
		public extern virtual jQuery disableSelection();

		/// <summary>
		/// Enable HTML elements to get selected.
		/// </summary>
		/// <returns><code>this</code> to allow method chaining.</returns>
		public extern virtual jQuery enableSelection();

		/// <summary>
		/// Returns the first focusable domRef in a given container (the first element of the collection)
		/// </summary>
		/// <returns>The domRef</returns>
		public extern virtual Retyped.dom.HTMLElement firstFocusableDomRef();

		/// <summary>
		/// Retrieve the selected text in the first element of the collection.
		/// 
		/// <b>Note</b>: This feature is only supported for input element’s type of text, search, url, tel and password.
		/// </summary>
		/// <returns>The selected text.</returns>
		public extern virtual string getSelectedText();

		/// <summary>
		/// Returns <code>true</code> if the first element has a set tabindex.
		/// </summary>
		/// <returns>If the first element has a set tabindex</returns>
		public extern virtual bool hasTabIndex();

		/// <summary>
		/// Returns the last focusable domRef in a given container
		/// </summary>
		/// <returns>The last domRef</returns>
		public extern virtual Retyped.dom.HTMLElement lastFocusableDomRef();

		/// <summary>
		/// Returns the outer HTML of the given HTML element.
		/// </summary>
		/// <returns>outer HTML</returns>
		[Obsolete("Deprecated since 1.58. use native <code>Element#outerHTML</code> instead")]
		public extern virtual string outerHTML();

		/// <summary>
		/// Gets the next parent DOM element with a given attribute and attribute value starting above the first given element
		/// </summary>
		/// <param name="sAttribute">Name of the attribute</param>
		/// <param name="sValue">Value of the attribute (optional)</param>
		/// <returns>null or the DOM reference</returns>
		public extern virtual Retyped.dom.HTMLElement parentByAttribute(string sAttribute, string sValue);

		/// <summary>
		/// Returns a rectangle describing the current visual positioning of the first DOM object in the collection (or <code>null</code> if no element was given).
		/// </summary>
		/// <returns>An object with left, top, width and height</returns>
		public extern virtual object rect();

		/// <summary>
		/// Returns whether a point described by X and Y is inside this Rectangle's boundaries.
		/// </summary>
		/// <param name="iPosX">The X coordinate</param>
		/// <param name="iPosY">The Y coordinate</param>
		/// <returns>Whether X and Y are inside this Rectangle's boundaries</returns>
		public extern virtual bool rectContains(int iPosX, int iPosY);

		/// <summary>
		/// Removes the given ID reference from the aria-describedby attribute.
		/// </summary>
		/// <param name="sId">The ID reference of an element</param>
		/// <returns><code>this</code> to allow method chaining.</returns>
		public extern virtual jQuery removeAriaDescribedBy(string sId);

		/// <summary>
		/// Removes the given ID reference from the aria-labelledby attribute.
		/// </summary>
		/// <param name="sId">The ID reference of an element</param>
		/// <returns><code>this</code> to allow method chaining.</returns>
		public extern virtual jQuery removeAriaLabelledBy(string sId);

		/// <param name="oRootControl">The root control</param>
		/// <returns>Returns itself</returns>
		[Obsolete("Deprecated since 1.58.")]
		public extern virtual jQuery root(object oRootControl);

		/// <summary>
		/// Sets or returns the scrollLeft value of the first element in the given jQuery collection in right-to-left mode. Precondition: The element is rendered in RTL mode.
		/// 
		/// Reason for this method is that the major browsers use three different values for the same scroll position when in RTL mode. This method hides those differences and returns/applies the same value that would be returned in LTR mode: The distance in px how far the given container is scrolled away from the leftmost scroll position.
		/// 
		/// Returns "undefined" if no element and no iPos is given.
		/// </summary>
		/// <param name="iPos">The desired scroll position</param>
		/// <returns>The jQuery collection if iPos is given, otherwise the scroll position, counted from the leftmost position</returns>
		public extern virtual Union<jQuery, int> scrollLeftRTL(int iPos);

		/// <summary>
		/// Returns the MIRRORED scrollLeft value of the first element in the given jQuery collection in right-to-left mode. Precondition: The element is rendered in RTL mode.
		/// 
		/// Reason for this method is that the major browsers return three different values for the same scroll position when in RTL mode. This method hides those differences and returns the value that would be returned in LTR mode if the UI would be mirrored horizontally: The distance in px how far the given container is scrolled away from the rightmost scroll position.
		/// 
		/// Returns "undefined" if no element is given.
		/// </summary>
		/// <returns>The scroll position, counted from the rightmost position</returns>
		public extern virtual int scrollRightRTL();

		/// <summary>
		/// Sets the text selection in the first element of the collection.
		/// 
		/// <b>Note</b>: This feature is only supported for input element’s type of text, search, url, tel and password.
		/// </summary>
		/// <param name="iStart">Start position of the selection (inclusive)</param>
		/// <param name="iEnd">End position of the selection (exclusive)</param>
		/// <returns>The jQuery collection</returns>
		public extern virtual jQuery selectText(int iStart, int iEnd);

		/// <summary>
		/// Returns a single UIArea if an index is provided or an array of UIAreas.
		/// </summary>
		/// <param name="iIdx">Index of the UIArea</param>
		/// <returns>The UIArea if an index is provided or an array of UIAreas</returns>
		[Obsolete("Deprecated since 1.58.")]
		public extern virtual Union<object, object[]> uiarea(int iIdx);

		/// <summary>
		/// Get the z-index for an element.
		/// </summary>
		/// <param name="zIndex">The z-index to set</param>
		/// <returns>The z-index</returns>
		public extern virtual int zIndex(int zIndex);

		#endregion

	}
}
