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
	public abstract partial class jQuery : jquery.JQueryStatic<dom.HTMLElement>
	{
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
		/// <returns>Depending on the given context and index parameter an array of controls, an instance or null.</returns>
		public extern virtual Union<UI5.sap.ui.core.Control[], UI5.sap.ui.core.Control> control(int iIndex);

		/// <summary>
		/// Extension function to the jQuery.fn which identifies SAPUI5 controls in the given jQuery context.
		/// </summary>
		/// <returns>Depending on the given context and index parameter an array of controls, an instance or null.</returns>
		public extern virtual Union<UI5.sap.ui.core.Control[], UI5.sap.ui.core.Control> control();

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
		public extern virtual dom.HTMLElement firstFocusableDomRef();

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
		public extern virtual dom.HTMLElement lastFocusableDomRef();

		/// <summary>
		/// Returns the outer HTML of the given HTML element.
		/// </summary>
		/// <returns>outer HTML</returns>
		public extern virtual string outerHTML();

		/// <summary>
		/// Gets the next parent DOM element with a given attribute and attribute value starting above the first given element
		/// </summary>
		/// <param name="sAttribute">Name of the attribute</param>
		/// <param name="sValue">Value of the attribute (optional)</param>
		/// <returns>null or the DOM reference</returns>
		public extern virtual dom.HTMLElement parentByAttribute(string sAttribute, string sValue);

		/// <summary>
		/// Returns a rectangle describing the current visual positioning of the first DOM object in the collection (or <code>null</code> if no element was given).
		/// </summary>
		/// <returns>An object with left, top, width and height</returns>
		public extern virtual object rect();

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
