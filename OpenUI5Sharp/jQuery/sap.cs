using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public abstract partial class jQuery
	{
		/// <summary>
		/// Root Namespace for the jQuery plug-in provided by SAP SE.
		/// </summary>
		[External]
		[Namespace(false)]
		[Name("jQuery.sap")]
		public static partial class sap
		{
			#region Typed Parameters

			/// <summary>
			/// Parameter to be used as Object Literal
			/// </summary>
			[External]
			[ObjectLiteral]
			public partial class IncludeInfo
			{
				/// <summary>
				/// the URL of the script to load
				/// </summary>
				public string url;

				/// <summary>
				/// id that should be used for the script tag
				/// </summary>
				public string id;

				/// <summary>
				/// map of attributes that should be used for the script tag
				/// </summary>
				public object attributes;

			}

			/// <summary>
			/// Parameter to be used as Object Literal
			/// </summary>
			[External]
			[ObjectLiteral]
			public partial class InitMobileOptions
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
			public partial class PropertiesInfo
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
			public partial class RegisterPathInfo
			{
				/// <summary>
				/// path prefix to register
				/// </summary>
				public string url;

				/// <summary>
				/// flag to avoid overwriting the url path prefix for the given module name at a later point of time
				/// </summary>
				public bool final;

			}

			/// <summary>
			/// Parameter to be used as Object Literal
			/// </summary>
			[External]
			[ObjectLiteral]
			public partial class ResourcesInfo
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

			#region Fields

			/// <summary>
			/// Calculate delta of old list and new list.
			/// 
			/// This partly implements the algorithm described in "A Technique for Isolating Differences Between Files" but instead of working with hashes, it does compare each entry of the old list with each entry of the new list, which causes terrible performance on large datasets.
			/// </summary>
			public static object arrayDiff;

			#endregion

			#region Methods

			/// <summary>
			/// Adds a whitelist entry for URL validation.
			/// </summary>
			/// <param name="protocol">The protocol of the URL</param>
			/// <param name="host">The host of the URL</param>
			/// <param name="port">The port of the URL</param>
			/// <param name="path">the path of the URL</param>
			public extern static void addUrlWhitelist(string protocol, string host, string port, string path);

			/// <summary>
			/// Calculate delta of old list and new list.
			/// 
			/// This function implements the algorithm described in "A Technique for Isolating Differences Between Files" (Commun. ACM, April 1978, Volume 21, Number 4, Pages 264-268).
			/// 
			/// Items in the arrays are not compared directly. Instead, a substitute symbol is determined for each item by applying the provided function <code>fnSymbol</code> to it. Items with strictly equal symbols are assumed to represent the same logical item: <pre>
			///   fnSymbol(a) === fnSymbol(b)   <=>   a 'is logically the same as' b
			/// </pre> As an additional constraint, casting the symbols to string should not modify the comparison result. If this second constraint is not met, this method might report more diffs than necessary.
			/// 
			/// If no symbol function is provided, a default implementation is used which applies <code>JSON.stringify</code> to non-string items and reduces the strings to a hash code. It is not guaranteed that this default implementation fulfills the above constraint in all cases, but it is a compromise between implementation effort, generality and performance. If items are known to be non-stringifiable (e.g. because they may contain cyclic references) or when hash collisions are likely, an own <code>fnSymbol</code> function must be provided.
			/// 
			/// The result of the diff is a sequence of update operations, each consisting of a <code>type</code> (either <code>"insert"</code> or <code>"delete"</code>) and an <code>index</code>. By applying the operations one after the other to the old array, it can be transformed to an array whose items are equal to the new array.
			/// 
			/// Sample implementation of the update <pre>
			/// 
			///  function update(aOldArray, aNewArray) {
			/// 
			///    // calculate the diff
			///    var aDiff = jQuery.sap.arraySymbolDiff(aOldArray, aNewArray, __provide_your_symbol_function_here__);
			/// 
			///    // apply update operations
			///    aDiff.forEach( function(op) {
			/// 
			///      // invariant: aOldArray and aNewArray now are equal up to (excluding) op.index
			/// 
			///      switch ( op.type ) {
			///      case 'insert':
			///        // new array contains a new (or otherwise unmapped) item, add it here
			///        aOldArray.splice(op.index, 0, aNewArray[op.index]);
			///        break;
			///      case 'delete':
			///        // an item is no longer part of the array (or has been moved to another position), remove it
			///        aOldArray.splice(op.index, 1);
			///        break;
			///      default:
			///        throw new Error('unexpected diff operation type');
			///      }
			/// 
			///    });
			///  }
			/// 
			/// </pre>
			/// </summary>
			/// <param name="aOld">Old Array</param>
			/// <param name="aNew">New Array</param>
			/// <param name="fnSymbol">Function to calculate substitute symbols for array items</param>
			/// <returns>List of update operations</returns>
			public extern static object[] arraySymbolDiff(object[] aOld, object[] aNew, object fnSymbol);

			/// <summary>
			/// Calculate delta of old list and new list.
			/// 
			/// This function implements the algorithm described in "A Technique for Isolating Differences Between Files" (Commun. ACM, April 1978, Volume 21, Number 4, Pages 264-268).
			/// 
			/// Items in the arrays are not compared directly. Instead, a substitute symbol is determined for each item by applying the provided function <code>fnSymbol</code> to it. Items with strictly equal symbols are assumed to represent the same logical item: <pre>
			///   fnSymbol(a) === fnSymbol(b)   <=>   a 'is logically the same as' b
			/// </pre> As an additional constraint, casting the symbols to string should not modify the comparison result. If this second constraint is not met, this method might report more diffs than necessary.
			/// 
			/// If no symbol function is provided, a default implementation is used which applies <code>JSON.stringify</code> to non-string items and reduces the strings to a hash code. It is not guaranteed that this default implementation fulfills the above constraint in all cases, but it is a compromise between implementation effort, generality and performance. If items are known to be non-stringifiable (e.g. because they may contain cyclic references) or when hash collisions are likely, an own <code>fnSymbol</code> function must be provided.
			/// 
			/// The result of the diff is a sequence of update operations, each consisting of a <code>type</code> (either <code>"insert"</code> or <code>"delete"</code>) and an <code>index</code>. By applying the operations one after the other to the old array, it can be transformed to an array whose items are equal to the new array.
			/// 
			/// Sample implementation of the update <pre>
			/// 
			///  function update(aOldArray, aNewArray) {
			/// 
			///    // calculate the diff
			///    var aDiff = jQuery.sap.arraySymbolDiff(aOldArray, aNewArray, __provide_your_symbol_function_here__);
			/// 
			///    // apply update operations
			///    aDiff.forEach( function(op) {
			/// 
			///      // invariant: aOldArray and aNewArray now are equal up to (excluding) op.index
			/// 
			///      switch ( op.type ) {
			///      case 'insert':
			///        // new array contains a new (or otherwise unmapped) item, add it here
			///        aOldArray.splice(op.index, 0, aNewArray[op.index]);
			///        break;
			///      case 'delete':
			///        // an item is no longer part of the array (or has been moved to another position), remove it
			///        aOldArray.splice(op.index, 1);
			///        break;
			///      default:
			///        throw new Error('unexpected diff operation type');
			///      }
			/// 
			///    });
			///  }
			/// 
			/// </pre>
			/// </summary>
			/// <param name="aOld">Old Array</param>
			/// <param name="aNew">New Array</param>
			/// <returns>List of update operations</returns>
			public extern static object[] arraySymbolDiff(object[] aOld, object[] aNew);

			/// <summary>
			/// A simple assertion mechanism that logs a message when a given condition is not met.
			/// 
			/// <b>Note:</b> Calls to this method might be removed when the JavaScript code is optimized during build. Therefore, callers should not rely on any side effects of this method.
			/// </summary>
			/// <param name="bResult">Result of the checked assertion</param>
			/// <param name="vMessage">Message that will be logged when the result is <code>false</code>. In case this is a function, the return value of the function will be displayed. This can be used to execute complex code only if the assertion fails.</param>
			public extern static void assert(bool bResult, Union<string, object> vMessage);

			/// <summary>
			/// Binds all events for listening with the given callback function.
			/// </summary>
			/// <param name="fnCallback">Callback function</param>
			public extern static void bindAnyEvent(object fnCallback);

			/// <summary>
			/// Shortcut for jQuery("#" + id) with additionally the id being escaped properly. I.e.: returns the jQuery object for the DOM element with the given id
			/// 
			/// Use this method instead of jQuery(...) if you know the argument is exactly one id and the id is not known in advance because it is in a variable (as opposed to a string constant with known content).
			/// </summary>
			/// <param name="sId">The id to search for and construct the jQuery object</param>
			/// <param name="oContext">the context DOM Element</param>
			/// <returns>The jQuery object for the DOM element identified by the given sId</returns>
			public extern static object byId(string sId, dom.HTMLElement oContext);

			/// <summary>
			/// Transforms a hyphen separated string to a camel case string.
			/// </summary>
			/// <param name="sString">Hyphen separated string</param>
			/// <returns>The transformed string</returns>
			public extern static string camelCase(string sString);

			/// <summary>
			/// Converts one character of the string to upper case, at a given position.
			/// 
			/// If no position is given or when it is negative or beyond the last character of <code>sString</code>, then the first character will be converted to upper case. The first character position is 0.
			/// </summary>
			/// <param name="sString">String for which one character should be converted</param>
			/// <param name="iPos">Position of the character that should be converted</param>
			/// <returns>String with the converted character</returns>
			public extern static string charToUpperCase(string sString, int iPos);

			/// <summary>
			/// Checks a given mouseover or mouseout event whether it is equivalent to a mouseenter or mousleave event regarding the given DOM reference.
			/// </summary>
			/// <param name="oEvent"></param>
			/// <param name="oDomRef"></param>
			public extern static void checkMouseEnterOrLeave(jquery.JQuery.Event oEvent, dom.HTMLElement oDomRef);

			/// <summary>
			/// Stops the delayed call.
			/// 
			/// The function given when calling delayedCall is not called anymore.
			/// </summary>
			/// <param name="sDelayedCallId">The id returned, when calling delayedCall</param>
			public extern static void clearDelayedCall(string sDelayedCallId);

			/// <summary>
			/// Stops the interval call.
			/// 
			/// The function given when calling intervalCall is not called anymore.
			/// </summary>
			/// <param name="sIntervalCallId">The id returned, when calling intervalCall</param>
			public extern static void clearIntervalCall(string sIntervalCallId);

			/// <summary>
			/// Clears the whitelist for URL validation
			/// </summary>
			public extern static void clearUrlWhitelist();

			/// <summary>
			/// Returns whether <code>oDomRefChild</code> is contained in or equal to <code>oDomRefContainer</code>.
			/// 
			/// This is a browser-independent version of the .contains method of Internet Explorer. For compatibility reasons it returns <code>true</code> if <code>oDomRefContainer</code> and <code>oDomRefChild</code> are equal.
			/// 
			/// This method intentionally does not operate on the jQuery object, as the original <code>jQuery.contains()</code> method also does not do so.
			/// </summary>
			/// <param name="oDomRefContainer">The container element</param>
			/// <param name="oDomRefChild">The child element (must not be a text node, must be an element)</param>
			/// <returns>Whether <code>oDomRefChild</code> is contained in or equal to <code>oDomRefContainer</code></returns>
			public extern static bool containsOrEquals(dom.HTMLElement oDomRefContainer, dom.HTMLElement oDomRefChild);

			/// <summary>
			/// Declares a module as existing.
			/// 
			/// By default, this function assumes that the module will create a JavaScript object with the same name as the module. As a convenience it ensures that the parent namespace for that object exists (by calling jQuery.sap.getObject). If such an object creation is not desired, <code>bCreateNamespace</code> must be set to false.
			/// </summary>
			/// <param name="sModuleName">name of the module to be declared or in case of an object {modName: "...", type: "..."} where modName is the name of the module and the type could be a specific dot separated extension e.g. <code>{modName: "sap.ui.core.Dev", type: "view"}</code> loads <code>sap/ui/core/Dev.view.js</code> and registers as <code>sap.ui.core.Dev.view</code></param>
			/// <param name="bCreateNamespace">whether to create the parent namespace</param>
			[Obsolete("Deprecated since 1.52. UI5 modules and their dependencies should be defined using {@link sap.ui.define}. For more details see {@link topic:91f23a736f4d1014b6dd926db0e91070 Modules and Dependencies} in the documentation.")]
			public extern static void declare(Union<string, object> sModuleName, bool bCreateNamespace = true);

			/// <summary>
			/// Calls a method after a given delay and returns an id for this timer
			/// </summary>
			/// <param name="iDelay">Delay time in milliseconds</param>
			/// <param name="oObject">Object from which the method should be called</param>
			/// <param name="method">function pointer or name of the method</param>
			/// <param name="aParameters">Method parameters</param>
			/// <returns>Id which can be used to cancel the timer with clearDelayedCall</returns>
			public extern static string delayedCall(int iDelay, object oObject, Union<string, object> method, object[] aParameters);

			/// <summary>
			/// Calls a method after a given delay and returns an id for this timer
			/// </summary>
			/// <param name="iDelay">Delay time in milliseconds</param>
			/// <param name="oObject">Object from which the method should be called</param>
			/// <param name="method">function pointer or name of the method</param>
			/// <returns>Id which can be used to cancel the timer with clearDelayedCall</returns>
			public extern static string delayedCall(int iDelay, object oObject, Union<string, object> method);

			/// <summary>
			/// For the given scroll position measured from the "beginning" of a container (the right edge in RTL mode) this method returns the scrollLeft value as understood by the current browser in RTL mode. This value is specific to the given DOM element, as the computation may involve its dimensions.
			/// 
			/// So when oDomRef should be scrolled 2px from the beginning, the number "2" must be given as iNormalizedScrollBegin and the result of this method (which may be a large or even negative number, depending on the browser) can then be set as oDomRef.scrollLeft to achieve the desired (cross-browser-consistent) scrolling position. Low values make the right part of the content visible, high values the left part.
			/// 
			/// This method does no scrolling on its own, it only calculates the value to set (so it can also be used for animations).
			/// 
			/// Only use this method in RTL mode, as the behavior in LTR mode is undefined and may change!
			/// </summary>
			/// <param name="iNormalizedScrollBegin">The distance from the rightmost position to which the element should be scrolled</param>
			/// <param name="oDomRef">The DOM Element to which scrollLeft will be applied</param>
			/// <returns>The scroll position that must be set for the DOM element</returns>
			public extern static int denormalizeScrollBeginRTL(int iNormalizedScrollBegin, dom.HTMLElement oDomRef);

			/// <summary>
			/// For the given scrollLeft value this method returns the scrollLeft value as understood by the current browser in RTL mode. This value is specific to the given DOM element, as the computation may involve its dimensions.
			/// 
			/// So when oDomRef should be scrolled 2px from the leftmost position, the number "2" must be given as iNormalizedScrollLeft and the result of this method (which may be a large or even negative number, depending on the browser) can then be set as oDomRef.scrollLeft to achieve the desired (cross-browser-consistent) scrolling position.
			/// 
			/// This method does no scrolling on its own, it only calculates the value to set (so it can also be used for animations).
			/// </summary>
			/// <param name="iNormalizedScrollLeft">The distance from the leftmost position to which the element should be scrolled</param>
			/// <param name="oDomRef">The DOM Element to which scrollLeft will be applied</param>
			/// <returns>The scroll position that must be set for the DOM element</returns>
			public extern static int denormalizeScrollLeftRTL(int iNormalizedScrollLeft, dom.HTMLElement oDomRef);

			/// <summary>
			/// Disable touch to mouse handling
			/// </summary>
			public extern static void disableTouchToMouseHandling();

			/// <summary>
			/// Shortcut for document.getElementById().
			/// </summary>
			/// <param name="sId">The id of the DOM element to return</param>
			/// <param name="oWindow">The window (optional)</param>
			/// <returns>The DOMNode identified by the given sId</returns>
			public extern static dom.HTMLElement domById(string sId, dom.Window oWindow);

			/// <summary>
			/// Shortcut for document.getElementById().
			/// </summary>
			/// <param name="sId">The id of the DOM element to return</param>
			/// <returns>The DOMNode identified by the given sId</returns>
			public extern static dom.HTMLElement domById(string sId);

			/// <summary>
			/// Encode the string for inclusion into CSS string literals or identifiers
			/// </summary>
			/// <param name="sString">The string to be escaped</param>
			/// <returns>The escaped string</returns>
			public extern static string encodeCSS(string sString);

			/// <summary>
			/// Encode the string for inclusion into HTML content/attribute
			/// </summary>
			/// <param name="sString">The string to be escaped</param>
			/// <returns>The escaped string</returns>
			public extern static string encodeHTML(string sString);

			/// <summary>
			/// Encode the string for inclusion into a JS string literal
			/// </summary>
			/// <param name="sString">The string to be escaped</param>
			/// <returns>The escaped string</returns>
			public extern static string encodeJS(string sString);

			/// <summary>
			/// Encode the string for inclusion into a URL parameter
			/// </summary>
			/// <param name="sString">The string to be escaped</param>
			/// <returns>The escaped string</returns>
			public extern static string encodeURL(string sString);

			/// <summary>
			/// Encode a map of parameters into a combined URL parameter string
			/// </summary>
			/// <param name="mParams">The map of parameters to encode</param>
			/// <returns>The URL encoded parameters</returns>
			public extern static string encodeURLParameters(object mParams);

			/// <summary>
			/// Encode the string for inclusion into XML content/attribute
			/// </summary>
			/// <param name="sString">The string to be escaped</param>
			/// <returns>The escaped string</returns>
			public extern static string encodeXML(string sString);

			/// <summary>
			/// Checks whether a given <code>sString</code> ends with <code>sEndString</code> respecting the case of the strings.
			/// </summary>
			/// <param name="sString">String to be checked</param>
			/// <param name="sEndString">The end string to be searched</param>
			/// <returns>Whether <code>sString</code> ends with <code>sEndString</code></returns>
			public extern static bool endsWith(string sString, string sEndString);

			/// <summary>
			/// Checks whether a given <code>sString</code> ends with <code>sEndString</code> ignoring the case of the strings.
			/// </summary>
			/// <param name="sString">String to be checked</param>
			/// <param name="sEndString">The end string to be searched</param>
			/// <returns>Whether <code>sString</code> ends with <code>sEndString</code></returns>
			public extern static bool endsWithIgnoreCase(string sString, string sEndString);

			/// <summary>
			/// Compares the two given values for equality, especially takes care not to compare arrays and objects by reference, but compares their content. Note: function does not work with comparing XML objects
			/// </summary>
			/// <param name="a">A value of any type</param>
			/// <param name="b">A value of any type</param>
			/// <param name="maxDepth">Maximum recursion depth</param>
			/// <param name="contains">Whether all existing properties in a are equal as in b</param>
			/// <returns>Whether a and b are equal</returns>
			public extern static bool equal(object a, object b, int maxDepth, bool contains);

			/// <summary>
			/// Compares the two given values for equality, especially takes care not to compare arrays and objects by reference, but compares their content. Note: function does not work with comparing XML objects
			/// </summary>
			/// <param name="a">A value of any type</param>
			/// <param name="b">A value of any type</param>
			/// <param name="maxDepth">Maximum recursion depth</param>
			/// <returns>Whether a and b are equal</returns>
			public extern static bool equal(object a, object b, int maxDepth = 10);

			/// <summary>
			/// Encode the string for inclusion into HTML content/attribute. Old name "escapeHTML" kept for backward compatibility
			/// </summary>
			/// <param name="sString">The string to be escaped</param>
			/// <returns>The escaped string</returns>
			[Obsolete("Deprecated since 1.4.0. has been renamed, use {@link jQuery.sap.encodeHTML} instead.")]
			public extern static string escapeHTML(string sString);

			/// <summary>
			/// Encode the string for inclusion into a JS string literal. Old name "escapeJS" kept for backward compatibility
			/// </summary>
			/// <param name="sString">The string to be escaped</param>
			/// <returns>The escaped string</returns>
			[Obsolete("Deprecated since 1.3.0. Has been renamed, use {@link jQuery.sap.encodeJS} instead.")]
			public extern static string escapeJS(string sString);

			/// <summary>
			/// Escapes all characters that would have a special meaning in a regular expression.
			/// 
			/// This method can be used when a string with arbitrary content has to be integrated into a regular expression and when the whole string should match literally.
			/// 
			/// Example: <pre>
			///   var text = "E=m*c^2"; // text to search
			///   var search = "m*c";   // text to search for
			/// 
			///   text.match( new RegExp(                         search  ) ); // [ "c" ]
			///   text.match( new RegExp( jQuery.sap.escapeRegExp(search) ) ); // [ "m*c" ]
			/// </pre>
			/// </summary>
			/// <param name="sString">String to escape</param>
			/// <returns>The escaped string</returns>
			public extern static string escapeRegExp(string sString);

			/// <summary>
			/// Returns a new constructor function that creates objects with the given prototype.
			/// 
			/// As of 1.45.0, this method has been deprecated. Use the following code pattern instead: <pre>
			///   function MyFunction() {
			///   };
			///   MyFunction.prototype = oPrototype;
			/// </pre>
			/// </summary>
			/// <param name="oPrototype">Prototype to use for the new objects</param>
			/// <returns>the newly created constructor function</returns>
			[Obsolete("Deprecated since 1.45.0. define your own function and assign <code>oPrototype</code> to its <code>prototype</code> property instead.")]
			public extern static object factory(object oPrototype);

			/// <summary>
			/// Calls focus() on the given DOM element.
			/// </summary>
			/// <param name="oDomRef">The DOM element to focus (or null - in this case the method does nothing)</param>
			/// <returns>Whether the focus() command was executed without an error</returns>
			public extern static bool focus(dom.HTMLElement oDomRef);

			/// <summary>
			/// Creates a string from a pattern by replacing placeholders with concrete values.
			/// 
			/// The syntax of the pattern is inspired by (but not fully equivalent to) the java.util.MessageFormat.
			/// 
			/// Placeholders have the form <code>{ integer }</code>, where any occurrence of <code>{0}</code> is replaced by the value with index 0 in <code>aValues</code>, <code>{1}</code> by the value with index 1 in <code>aValues</code> etc.
			/// 
			/// To avoid interpretation of curly braces as placeholders, any non-placeholder fragment of the pattern can be enclosed in single quotes. The surrounding single quotes will be omitted from the result. Single quotes that are not meant to escape a fragment and that should appear in the result, need to be doubled. In the result, only a single single quote will occur.
			/// 
			/// Example Pattern Strings: <pre>
			///   jQuery.sap.formatMessage("Say {0}",     ["Hello"]) -> "Say Hello"    // normal use case
			///   jQuery.sap.formatMessage("Say '{0}'",   ["Hello"]) -> "Say {0}"      // escaped placeholder
			///   jQuery.sap.formatMessage("Say ''{0}''", ["Hello"]) -> "Say 'Hello'"  // doubled single quote
			///   jQuery.sap.formatMessage("Say '{0}'''", ["Hello"]) -> "Say {0}'"     // doubled single quote in quoted fragment
			/// </pre>
			/// 
			/// In contrast to java.util.MessageFormat, format types or format styles are not supported. Everything after the argument index and up to the first closing curly brace is ignored. Nested placeholders (as supported by java.lang.MessageFormat for the format type choice) are not ignored but reported as a parse error.
			/// 
			/// This method throws an Error when the pattern syntax is not fulfilled (e.g. unbalanced curly braces, nested placeholders or a non-numerical argument index).
			/// 
			/// This method can also be used as a formatter within a binding. The first part of a composite binding will be used as pattern, the following parts as aValues. If there is only one value and this value is an array it will be handled like the default described above.
			/// </summary>
			/// <param name="sPattern">A pattern string in the described syntax</param>
			/// <param name="aValues">The values to be used instead of the placeholders.</param>
			/// <returns>The formatted result string</returns>
			public extern static string formatMessage(string sPattern, object[] aValues);

			/// <summary>
			/// Creates a string from a pattern by replacing placeholders with concrete values.
			/// 
			/// The syntax of the pattern is inspired by (but not fully equivalent to) the java.util.MessageFormat.
			/// 
			/// Placeholders have the form <code>{ integer }</code>, where any occurrence of <code>{0}</code> is replaced by the value with index 0 in <code>aValues</code>, <code>{1}</code> by the value with index 1 in <code>aValues</code> etc.
			/// 
			/// To avoid interpretation of curly braces as placeholders, any non-placeholder fragment of the pattern can be enclosed in single quotes. The surrounding single quotes will be omitted from the result. Single quotes that are not meant to escape a fragment and that should appear in the result, need to be doubled. In the result, only a single single quote will occur.
			/// 
			/// Example Pattern Strings: <pre>
			///   jQuery.sap.formatMessage("Say {0}",     ["Hello"]) -> "Say Hello"    // normal use case
			///   jQuery.sap.formatMessage("Say '{0}'",   ["Hello"]) -> "Say {0}"      // escaped placeholder
			///   jQuery.sap.formatMessage("Say ''{0}''", ["Hello"]) -> "Say 'Hello'"  // doubled single quote
			///   jQuery.sap.formatMessage("Say '{0}'''", ["Hello"]) -> "Say {0}'"     // doubled single quote in quoted fragment
			/// </pre>
			/// 
			/// In contrast to java.util.MessageFormat, format types or format styles are not supported. Everything after the argument index and up to the first closing curly brace is ignored. Nested placeholders (as supported by java.lang.MessageFormat for the format type choice) are not ignored but reported as a parse error.
			/// 
			/// This method throws an Error when the pattern syntax is not fulfilled (e.g. unbalanced curly braces, nested placeholders or a non-numerical argument index).
			/// 
			/// This method can also be used as a formatter within a binding. The first part of a composite binding will be used as pattern, the following parts as aValues. If there is only one value and this value is an array it will be handled like the default described above.
			/// </summary>
			/// <param name="sPattern">A pattern string in the described syntax</param>
			/// <returns>The formatted result string</returns>
			public extern static string formatMessage(string sPattern);

			/// <summary>
			/// Returns the names of all declared modules.
			/// </summary>
			/// <returns>the names of all declared modules</returns>
			public extern static string[] getAllDeclaredModules();

			/// <summary>
			/// Constructs a URL to load the module with the given name and file type (suffix).
			/// 
			/// Searches the longest prefix of the given module name for which a registration exists (see {@link jQuery.sap.registerModulePath}) and replaces that prefix by the registered URL prefix.
			/// 
			/// The remainder of the module name is appended to the URL, replacing any dot with a slash.
			/// 
			/// Finally, the given suffix (typically a file name extension) is added (unconverted).
			/// 
			/// The returned name (without the suffix) doesn't end with a slash.
			/// </summary>
			/// <param name="sModuleName">module name to detemrine the path for</param>
			/// <param name="sSuffix">suffix to be added to the resulting path</param>
			/// <returns>calculated path (URL) to the given module</returns>
			public extern static string getModulePath(string sModuleName, string sSuffix);

			/// <summary>
			/// Constructs a URL to load the module with the given name and file type (suffix).
			/// 
			/// Searches the longest prefix of the given module name for which a registration exists (see {@link jQuery.sap.registerModulePath}) and replaces that prefix by the registered URL prefix.
			/// 
			/// The remainder of the module name is appended to the URL, replacing any dot with a slash.
			/// 
			/// Finally, the given suffix (typically a file name extension) is added (unconverted).
			/// 
			/// The returned name (without the suffix) doesn't end with a slash.
			/// </summary>
			/// <param name="sModuleName">module name to detemrine the path for</param>
			/// <returns>calculated path (URL) to the given module</returns>
			public extern static string getModulePath(string sModuleName);

			/// <summary>
			/// Returns a JavaScript object which is identified by a sequence of names.
			/// 
			/// A call to <code>getObject("a.b.C")</code> has essentially the same effect as accessing <code>window.a.b.C</code> but with the difference that missing intermediate objects (a or b in the example above) don't lead to an exception.
			/// 
			/// When the addressed object exists, it is simply returned. If it doesn't exists, the behavior depends on the value of the second, optional parameter <code>iNoCreates</code> (assuming 'n' to be the number of names in the name sequence): <ul> <li>NaN: if iNoCreates is not a number and the addressed object doesn't exist, then <code>getObject()</code> returns <code>undefined</code>. <li>0 &lt; iNoCreates &lt; n: any non-existing intermediate object is created, except the <i>last</i> <code>iNoCreates</code> ones. </ul>
			/// 
			/// Example: <pre>
			///   getObject()            -- returns the context object (either param or window)
			///   getObject("a.b.C")     -- will only try to get a.b.C and return undefined if not found.
			///   getObject("a.b.C", 0)  -- will create a, b, and C in that order if they don't exists
			///   getObject("a.b.c", 1)  -- will create a and b, but not C.
			/// </pre>
			/// 
			/// When a <code>oContext</code> is given, the search starts in that object. Otherwise it starts in the <code>window</code> object that this plugin has been created in.
			/// 
			/// Note: Although this method internally uses <code>object["key"]</code> to address object properties, it does not support all possible characters in a name. Especially the dot ('.') is not supported in the individual name segments, as it is always interpreted as a name separator.
			/// </summary>
			/// <param name="sName">a dot separated sequence of names that identify the required object</param>
			/// <param name="iNoCreates">number of objects (from the right) that should not be created</param>
			/// <param name="oContext">the context to execute the search in</param>
			/// <returns>The value of the named object</returns>
			public extern static object getObject(string sName, int iNoCreates, object oContext);

			/// <summary>
			/// Returns a JavaScript object which is identified by a sequence of names.
			/// 
			/// A call to <code>getObject("a.b.C")</code> has essentially the same effect as accessing <code>window.a.b.C</code> but with the difference that missing intermediate objects (a or b in the example above) don't lead to an exception.
			/// 
			/// When the addressed object exists, it is simply returned. If it doesn't exists, the behavior depends on the value of the second, optional parameter <code>iNoCreates</code> (assuming 'n' to be the number of names in the name sequence): <ul> <li>NaN: if iNoCreates is not a number and the addressed object doesn't exist, then <code>getObject()</code> returns <code>undefined</code>. <li>0 &lt; iNoCreates &lt; n: any non-existing intermediate object is created, except the <i>last</i> <code>iNoCreates</code> ones. </ul>
			/// 
			/// Example: <pre>
			///   getObject()            -- returns the context object (either param or window)
			///   getObject("a.b.C")     -- will only try to get a.b.C and return undefined if not found.
			///   getObject("a.b.C", 0)  -- will create a, b, and C in that order if they don't exists
			///   getObject("a.b.c", 1)  -- will create a and b, but not C.
			/// </pre>
			/// 
			/// When a <code>oContext</code> is given, the search starts in that object. Otherwise it starts in the <code>window</code> object that this plugin has been created in.
			/// 
			/// Note: Although this method internally uses <code>object["key"]</code> to address object properties, it does not support all possible characters in a name. Especially the dot ('.') is not supported in the individual name segments, as it is always interpreted as a name separator.
			/// </summary>
			/// <param name="sName">a dot separated sequence of names that identify the required object</param>
			/// <param name="iNoCreates">number of objects (from the right) that should not be created</param>
			/// <returns>The value of the named object</returns>
			public extern static object getObject(string sName, int iNoCreates);

			/// <summary>
			/// Returns a JavaScript object which is identified by a sequence of names.
			/// 
			/// A call to <code>getObject("a.b.C")</code> has essentially the same effect as accessing <code>window.a.b.C</code> but with the difference that missing intermediate objects (a or b in the example above) don't lead to an exception.
			/// 
			/// When the addressed object exists, it is simply returned. If it doesn't exists, the behavior depends on the value of the second, optional parameter <code>iNoCreates</code> (assuming 'n' to be the number of names in the name sequence): <ul> <li>NaN: if iNoCreates is not a number and the addressed object doesn't exist, then <code>getObject()</code> returns <code>undefined</code>. <li>0 &lt; iNoCreates &lt; n: any non-existing intermediate object is created, except the <i>last</i> <code>iNoCreates</code> ones. </ul>
			/// 
			/// Example: <pre>
			///   getObject()            -- returns the context object (either param or window)
			///   getObject("a.b.C")     -- will only try to get a.b.C and return undefined if not found.
			///   getObject("a.b.C", 0)  -- will create a, b, and C in that order if they don't exists
			///   getObject("a.b.c", 1)  -- will create a and b, but not C.
			/// </pre>
			/// 
			/// When a <code>oContext</code> is given, the search starts in that object. Otherwise it starts in the <code>window</code> object that this plugin has been created in.
			/// 
			/// Note: Although this method internally uses <code>object["key"]</code> to address object properties, it does not support all possible characters in a name. Especially the dot ('.') is not supported in the individual name segments, as it is always interpreted as a name separator.
			/// </summary>
			/// <param name="sName">a dot separated sequence of names that identify the required object</param>
			/// <returns>The value of the named object</returns>
			public extern static object getObject(string sName);

			/// <summary>
			/// Converts a UI5 module name to a unified resource name.
			/// 
			/// Used by View and Fragment APIs to convert a given module name into a unified resource name. When the <code>sSuffix</code> is not given, the suffix '.js' is added. This fits the most common use case of converting a module name to the Javascript resource that contains the module. Note that an empty <code>sSuffix</code> is not replaced by '.js'. This allows to convert UI5 module names to requireJS module names with a call to this method.
			/// </summary>
			/// <param name="sModuleName">Module name as a dot separated name</param>
			/// <param name="sSuffix">Suffix to add to the final resource name</param>
			private extern static void getResourceName(string sModuleName, string sSuffix = ".js");

			/// <summary>
			/// Determines the URL for a resource given its unified resource name.
			/// 
			/// Searches the longest prefix of the given resource name for which a registration exists (see {@link jQuery.sap.registerResourcePath}) and replaces that prefix by the registered URL prefix.
			/// 
			/// The remainder of the resource name is appended to the URL.
			/// 
			/// <b>Unified Resource Names</b><br> Several UI5 APIs use <i>Unified Resource Names (URNs)</i> as naming scheme for resources that they deal with (e.h. Javascript, CSS, JSON, XML, ...). URNs are similar to the path component of a URL: <ul> <li>they consist of a non-empty sequence of name segments</li> <li>segments are separated by a forward slash '/'</li> <li>name segments consist of URL path segment characters only. It is recommended to use only ASCII letters (upper or lower case), digits and the special characters '$', '_', '-', '.')</li> <li>the empty name segment is not supported</li> <li>names consisting of dots only, are reserved and must not be used for resources</li> <li>names are case sensitive although the underlying server might be case-insensitive</li> <li>the behavior with regard to URL encoded characters is not specified, %ddd notation should be avoided</li> <li>the meaning of a leading slash is undefined, but might be defined in future. It therefore should be avoided</li> </ul>
			/// 
			/// UI5 APIs that only deal with Javascript resources, use a slight variation of this scheme, where the extension '.js' is always omitted (see {@link sap.ui.define}, {@link sap.ui.require}).
			/// 
			/// <b>Relationship to old Module Name Syntax</b><br>
			/// 
			/// Older UI5 APIs that deal with resources (like {@link jQuery.sap.registerModulePath}, {@link jQuery.sap.require} and {@link jQuery.sap.declare}) used a dot-separated naming scheme (called 'module names') which was motivated by object names in the global namespace in Javascript.
			/// 
			/// The new URN scheme better matches the names of the corresponding resources (files) as stored in a server and the dot ('.') is no longer a forbidden character in a resource name. This finally allows to handle resources with different types (extensions) with the same API, not only JS files.
			/// 
			/// Last but not least does the URN scheme better match the naming conventions used by AMD loaders (like <code>requireJS</code>).
			/// </summary>
			/// <param name="sResourceName">unified resource name of the resource</param>
			/// <param name="sSuffix">Suffix to add to the resource name</param>
			/// <returns>URL to load the resource from</returns>
			public extern static string getResourcePath(string sResourceName, string sSuffix);

			/// <summary>
			/// Determines the URL for a resource given its unified resource name.
			/// 
			/// Searches the longest prefix of the given resource name for which a registration exists (see {@link jQuery.sap.registerResourcePath}) and replaces that prefix by the registered URL prefix.
			/// 
			/// The remainder of the resource name is appended to the URL.
			/// 
			/// <b>Unified Resource Names</b><br> Several UI5 APIs use <i>Unified Resource Names (URNs)</i> as naming scheme for resources that they deal with (e.h. Javascript, CSS, JSON, XML, ...). URNs are similar to the path component of a URL: <ul> <li>they consist of a non-empty sequence of name segments</li> <li>segments are separated by a forward slash '/'</li> <li>name segments consist of URL path segment characters only. It is recommended to use only ASCII letters (upper or lower case), digits and the special characters '$', '_', '-', '.')</li> <li>the empty name segment is not supported</li> <li>names consisting of dots only, are reserved and must not be used for resources</li> <li>names are case sensitive although the underlying server might be case-insensitive</li> <li>the behavior with regard to URL encoded characters is not specified, %ddd notation should be avoided</li> <li>the meaning of a leading slash is undefined, but might be defined in future. It therefore should be avoided</li> </ul>
			/// 
			/// UI5 APIs that only deal with Javascript resources, use a slight variation of this scheme, where the extension '.js' is always omitted (see {@link sap.ui.define}, {@link sap.ui.require}).
			/// 
			/// <b>Relationship to old Module Name Syntax</b><br>
			/// 
			/// Older UI5 APIs that deal with resources (like {@link jQuery.sap.registerModulePath}, {@link jQuery.sap.require} and {@link jQuery.sap.declare}) used a dot-separated naming scheme (called 'module names') which was motivated by object names in the global namespace in Javascript.
			/// 
			/// The new URN scheme better matches the names of the corresponding resources (files) as stored in a server and the dot ('.') is no longer a forbidden character in a resource name. This finally allows to handle resources with different types (extensions) with the same API, not only JS files.
			/// 
			/// Last but not least does the URN scheme better match the naming conventions used by AMD loaders (like <code>requireJS</code>).
			/// </summary>
			/// <param name="sResourceName">unified resource name of the resource</param>
			/// <returns>URL to load the resource from</returns>
			public extern static string getResourcePath(string sResourceName);

			/// <summary>
			/// Returns a new function that returns the given <code>oValue</code> (using its closure).
			/// 
			/// Avoids the need for a dedicated member for the value.
			/// 
			/// As closures don't come for free, this function should only be used when polluting the enclosing object is an absolute "must-not" (as it is the case in public base classes).
			/// </summary>
			/// <param name="oValue">The value that the getter should return</param>
			/// <returns>The new getter function</returns>
			public extern static object getter(object oValue);

			/// <summary>
			/// Creates and returns a new instance of {@link jQuery.sap.util.UriParameters}.
			/// 
			/// Example for reading a single URI parameter (or the value of the first occurrence of the URI parameter): <pre>
			/// 	var sValue = jQuery.sap.getUriParameters().get("myUriParam");
			/// </pre>
			/// 
			/// Example for reading the values of the first of the URI parameter (with multiple occurrences): <pre>
			/// 	var aValues = jQuery.sap.getUriParameters().get("myUriParam", true);
			/// 	for(i in aValues){
			/// 	var sValue = aValues[i];
			/// 	}
			/// </pre>
			/// </summary>
			/// <param name="sUri">Uri to determine the parameters for</param>
			/// <returns>A new URI parameters instance</returns>
			public extern static jQuery.sap.util.UriParameters getUriParameters(string sUri);

			/// <summary>
			/// Gets the whitelist for URL validation.
			/// </summary>
			/// <returns>A copy of the whitelist</returns>
			public extern static object[] getUrlWhitelist();

			/// <summary>
			/// Executes an 'eval' for its arguments in the global context (without closure variables).
			/// 
			/// This is a synchronous replacement for <code>jQuery.globalEval</code> which in some browsers (e.g. FireFox) behaves asynchronously.
			/// </summary>
			public extern static void globalEval();

			/// <summary>
			/// This function generates a hash-code from a string
			/// </summary>
			/// <param name="sString">The string to generate the hash-code from</param>
			/// <returns>The generated hash-code</returns>
			private extern static int hashCode(string sString);

			/// <summary>
			/// Transforms a camel case string into a hyphen separated string.
			/// </summary>
			/// <param name="sString">camel case string</param>
			/// <returns>The transformed string</returns>
			public extern static string hyphen(string sString);

			/// <summary>
			/// Includes the script (via &lt;script&gt;-tag) into the head for the specified <code>sUrl</code> and optional <code>sId</code>.
			/// </summary>
			/// <param name="vUrl">the URL of the script to load or a configuration object</param>
			/// <param name="vId">id that should be used for the script tag or map of attributes</param>
			/// <param name="fnLoadCallback">callback function to get notified once the script has been loaded</param>
			/// <param name="fnErrorCallback">callback function to get notified once the script loading failed</param>
			/// <returns>When using the configuration object a <code>Promise</code> will be returned. The documentation for the <code>fnLoadCallback</code> applies to the <code>resolve</code> handler of the <code>Promise</code> and the one for the <code>fnErrorCallback</code> applies to the <code>reject</code> handler of the <code>Promise</code>.</returns>
			public extern static jquery.JQueryPromise<object> includeScript(Union<string, jQuery.sap.IncludeInfo> vUrl, Union<string, object> vId, object fnLoadCallback, object fnErrorCallback);

			/// <summary>
			/// Includes the script (via &lt;script&gt;-tag) into the head for the specified <code>sUrl</code> and optional <code>sId</code>.
			/// </summary>
			/// <param name="vUrl">the URL of the script to load or a configuration object</param>
			/// <param name="vId">id that should be used for the script tag or map of attributes</param>
			/// <param name="fnLoadCallback">callback function to get notified once the script has been loaded</param>
			/// <returns>When using the configuration object a <code>Promise</code> will be returned. The documentation for the <code>fnLoadCallback</code> applies to the <code>resolve</code> handler of the <code>Promise</code> and the one for the <code>fnErrorCallback</code> applies to the <code>reject</code> handler of the <code>Promise</code>.</returns>
			public extern static jquery.JQueryPromise<object> includeScript(Union<string, jQuery.sap.IncludeInfo> vUrl, Union<string, object> vId, object fnLoadCallback);

			/// <summary>
			/// Includes the script (via &lt;script&gt;-tag) into the head for the specified <code>sUrl</code> and optional <code>sId</code>.
			/// </summary>
			/// <param name="vUrl">the URL of the script to load or a configuration object</param>
			/// <param name="vId">id that should be used for the script tag or map of attributes</param>
			/// <returns>When using the configuration object a <code>Promise</code> will be returned. The documentation for the <code>fnLoadCallback</code> applies to the <code>resolve</code> handler of the <code>Promise</code> and the one for the <code>fnErrorCallback</code> applies to the <code>reject</code> handler of the <code>Promise</code>.</returns>
			public extern static jquery.JQueryPromise<object> includeScript(Union<string, jQuery.sap.IncludeInfo> vUrl, Union<string, object> vId);

			/// <summary>
			/// Includes the script (via &lt;script&gt;-tag) into the head for the specified <code>sUrl</code> and optional <code>sId</code>.
			/// </summary>
			/// <param name="vUrl">the URL of the script to load or a configuration object</param>
			/// <returns>When using the configuration object a <code>Promise</code> will be returned. The documentation for the <code>fnLoadCallback</code> applies to the <code>resolve</code> handler of the <code>Promise</code> and the one for the <code>fnErrorCallback</code> applies to the <code>reject</code> handler of the <code>Promise</code>.</returns>
			public extern static jquery.JQueryPromise<object> includeScript(Union<string, jQuery.sap.IncludeInfo> vUrl);

			/// <summary>
			/// Includes the specified stylesheet via a &lt;link&gt;-tag in the head of the current document. If there is call to <code>includeStylesheet</code> providing the sId of an already included stylesheet, the existing element will be replaced.
			/// </summary>
			/// <param name="vUrl">the URL of the stylesheet to load or a configuration object</param>
			/// <param name="vId">id that should be used for the link tag or map of attributes</param>
			/// <param name="fnLoadCallback">callback function to get notified once the stylesheet has been loaded</param>
			/// <param name="fnErrorCallback">callback function to get notified once the stylesheet loading failed. In case of usage in IE the error callback will also be executed if an empty stylesheet is loaded. This is the only option how to determine in IE if the load was successful or not since the native onerror callback for link elements doesn't work in IE. The IE always calls the onload callback of the link element.</param>
			/// <returns>When using the configuration object a <code>Promise</code> will be returned. The documentation for the <code>fnLoadCallback</code> applies to the <code>resolve</code> handler of the <code>Promise</code> and the one for the <code>fnErrorCallback</code> applies to the <code>reject</code> handler of the <code>Promise</code>.</returns>
			public extern static jquery.JQueryPromise<object> includeStyleSheet(Union<string, jQuery.sap.IncludeInfo> vUrl, Union<string, object> vId, object fnLoadCallback, object fnErrorCallback);

			/// <summary>
			/// Includes the specified stylesheet via a &lt;link&gt;-tag in the head of the current document. If there is call to <code>includeStylesheet</code> providing the sId of an already included stylesheet, the existing element will be replaced.
			/// </summary>
			/// <param name="vUrl">the URL of the stylesheet to load or a configuration object</param>
			/// <param name="vId">id that should be used for the link tag or map of attributes</param>
			/// <param name="fnLoadCallback">callback function to get notified once the stylesheet has been loaded</param>
			/// <returns>When using the configuration object a <code>Promise</code> will be returned. The documentation for the <code>fnLoadCallback</code> applies to the <code>resolve</code> handler of the <code>Promise</code> and the one for the <code>fnErrorCallback</code> applies to the <code>reject</code> handler of the <code>Promise</code>.</returns>
			public extern static jquery.JQueryPromise<object> includeStyleSheet(Union<string, jQuery.sap.IncludeInfo> vUrl, Union<string, object> vId, object fnLoadCallback);

			/// <summary>
			/// Includes the specified stylesheet via a &lt;link&gt;-tag in the head of the current document. If there is call to <code>includeStylesheet</code> providing the sId of an already included stylesheet, the existing element will be replaced.
			/// </summary>
			/// <param name="vUrl">the URL of the stylesheet to load or a configuration object</param>
			/// <param name="vId">id that should be used for the link tag or map of attributes</param>
			/// <returns>When using the configuration object a <code>Promise</code> will be returned. The documentation for the <code>fnLoadCallback</code> applies to the <code>resolve</code> handler of the <code>Promise</code> and the one for the <code>fnErrorCallback</code> applies to the <code>reject</code> handler of the <code>Promise</code>.</returns>
			public extern static jquery.JQueryPromise<object> includeStyleSheet(Union<string, jQuery.sap.IncludeInfo> vUrl, Union<string, object> vId);

			/// <summary>
			/// Includes the specified stylesheet via a &lt;link&gt;-tag in the head of the current document. If there is call to <code>includeStylesheet</code> providing the sId of an already included stylesheet, the existing element will be replaced.
			/// </summary>
			/// <param name="vUrl">the URL of the stylesheet to load or a configuration object</param>
			/// <returns>When using the configuration object a <code>Promise</code> will be returned. The documentation for the <code>fnLoadCallback</code> applies to the <code>resolve</code> handler of the <code>Promise</code> and the one for the <code>fnErrorCallback</code> applies to the <code>reject</code> handler of the <code>Promise</code>.</returns>
			public extern static jquery.JQueryPromise<object> includeStyleSheet(Union<string, jQuery.sap.IncludeInfo> vUrl);

			/// <summary>
			/// Does some basic modifications to the HTML page that make it more suitable for mobile apps. Only the first call to this method is executed, subsequent calls are ignored. Note that this method is also called by the constructor of toplevel controls like sap.m.App, sap.m.SplitApp and sap.m.Shell. Exception: if no homeIcon was set, subsequent calls have the chance to set it.
			/// 
			/// The "options" parameter configures what exactly should be done.
			/// 
			/// It can have the following properties: <ul> <li>viewport: whether to set the viewport in a way that disables zooming (default: true)</li> <li>statusBar: the iOS status bar color, "default", "black" or "black-translucent" (default: "default")</li> <li>hideBrowser: whether the browser UI should be hidden as far as possible to make the app feel more native (default: true)</li> <li>preventScroll: whether native scrolling should be disabled in order to prevent the "rubber-band" effect where the whole window is moved (default: true)</li> <li>preventPhoneNumberDetection: whether Safari Mobile should be prevented from transforming any numbers that look like phone numbers into clickable links; this should be left as "true", otherwise it might break controls because Safari actually changes the DOM. This only affects all page content which is created after initMobile is called.</li> <li>rootId: the ID of the root element that should be made fullscreen; only used when hideBrowser is set (default: the document.body)</li> <li>useFullScreenHeight: a boolean that defines whether the height of the html root element should be set to 100%, which is required for other elements to cover the full height (default: true)</li> <li>homeIcon: deprecated since 1.12, use jQuery.sap.setIcons instead. </ul>
			/// </summary>
			/// <param name="options">configures what exactly should be done</param>
			public extern static void initMobile(jQuery.sap.InitMobileOptions options);

			/// <summary>
			/// Does some basic modifications to the HTML page that make it more suitable for mobile apps. Only the first call to this method is executed, subsequent calls are ignored. Note that this method is also called by the constructor of toplevel controls like sap.m.App, sap.m.SplitApp and sap.m.Shell. Exception: if no homeIcon was set, subsequent calls have the chance to set it.
			/// 
			/// The "options" parameter configures what exactly should be done.
			/// 
			/// It can have the following properties: <ul> <li>viewport: whether to set the viewport in a way that disables zooming (default: true)</li> <li>statusBar: the iOS status bar color, "default", "black" or "black-translucent" (default: "default")</li> <li>hideBrowser: whether the browser UI should be hidden as far as possible to make the app feel more native (default: true)</li> <li>preventScroll: whether native scrolling should be disabled in order to prevent the "rubber-band" effect where the whole window is moved (default: true)</li> <li>preventPhoneNumberDetection: whether Safari Mobile should be prevented from transforming any numbers that look like phone numbers into clickable links; this should be left as "true", otherwise it might break controls because Safari actually changes the DOM. This only affects all page content which is created after initMobile is called.</li> <li>rootId: the ID of the root element that should be made fullscreen; only used when hideBrowser is set (default: the document.body)</li> <li>useFullScreenHeight: a boolean that defines whether the height of the html root element should be set to 100%, which is required for other elements to cover the full height (default: true)</li> <li>homeIcon: deprecated since 1.12, use jQuery.sap.setIcons instead. </ul>
			/// </summary>
			public extern static void initMobile();

			/// <summary>
			/// Calls a method after a given interval and returns an id for this interval.
			/// </summary>
			/// <param name="iInterval">Interval time in milliseconds</param>
			/// <param name="oObject">Object from which the method should be called</param>
			/// <param name="method">function pointer or name of the method</param>
			/// <param name="aParameters">Method parameters</param>
			/// <returns>Id which can be used to cancel the interval with clearIntervalCall</returns>
			public extern static string intervalCall(int iInterval, object oObject, Union<string, object> method, object[] aParameters);

			/// <summary>
			/// Calls a method after a given interval and returns an id for this interval.
			/// </summary>
			/// <param name="iInterval">Interval time in milliseconds</param>
			/// <param name="oObject">Object from which the method should be called</param>
			/// <param name="method">function pointer or name of the method</param>
			/// <returns>Id which can be used to cancel the interval with clearIntervalCall</returns>
			public extern static string intervalCall(int iInterval, object oObject, Union<string, object> method);

			/// <summary>
			/// Check whether a given module has been loaded / declared already.
			/// 
			/// Returns true as soon as a module has been required the first time, even when loading/executing it has not finished yet. So the main assertion of a return value of <code>true</code> is that the necessary actions have been taken to make the module available in the near future. It does not mean, that the content of the module is already available!
			/// 
			/// This fuzzy behavior is necessary to avoid multiple requests for the same module. As a consequence of the assertion above, a <i>preloaded</i> module does not count as <i>declared</i>. For preloaded modules, an explicit call to <code>jQuery.sap.require</code> is necessary to make them available.
			/// 
			/// If a caller wants to know whether a module needs to be loaded from the server, it can set <code>bIncludePreloaded</code> to true. Then, preloaded modules will be reported as 'declared' as well by this method.
			/// </summary>
			/// <param name="sModuleName">name of the module to be checked</param>
			/// <param name="bIncludePreloaded">whether preloaded modules should be reported as declared.</param>
			/// <returns>whether the module has been declared already</returns>
			public extern static bool isDeclared(string sModuleName, bool bIncludePreloaded = false);

			/// <summary>
			/// Whether the given resource has been loaded (or preloaded).
			/// </summary>
			/// <param name="sResourceName">Name of the resource to check, in unified resource name format</param>
			/// <returns>Whether the resource has been loaded already</returns>
			private extern static bool isResourceLoaded(string sResourceName);

			/// <summary>
			/// Detect whether the pressed key is: SHIFT, CONTROL, ALT, BREAK, CAPS_LOCK, PAGE_UP, PAGE_DOWN, END, HOME, ARROW_LEFT, ARROW_UP, ARROW_RIGHT, ARROW_DOWN, PRINT, INSERT, DELETE, F1, F2, F3, F4, F5, F6, F7, F8, F9, F10, F11, F12, BACKSPACE, TAB, ENTER, ESCAPE
			/// </summary>
			/// <param name="oEvent">The event object of the <code>keydown</code>, <code>keyup</code> or <code>keypress</code> events.</param>
			/// <returns></returns>
			public extern static bool isSpecialKey(jquery.JQuery.Event oEvent);

			/// <summary>
			/// Returns a new object which has the given <code>oPrototype</code> as its prototype.
			/// 
			/// If several objects with the same prototype are to be created, {@link jQuery.sap.factory} should be used instead.
			/// </summary>
			/// <param name="oPrototype">Prototype to use for the new object</param>
			/// <returns>new object</returns>
			[Obsolete("Deprecated since 1.45.0. use <code>Object.create(oPrototype)</code> instead.")]
			public extern static object newObject(object oPrototype);

			/// <summary>
			/// Returns a high resolution timestamp in microseconds if supported by the environment, otherwise in milliseconds. The timestamp is based on 01/01/1970 00:00:00 (UNIX epoch) as float with microsecond precision or with millisecond precision, if high resolution timestamps are not available. The fractional part of the timestamp represents fractions of a millisecond. Converting to a <code>Date</code> is possible by using <code>require(["sap/base/util/now"], function(now){new Date(now());}</code>
			/// </summary>
			/// <returns>timestamp in microseconds if supported by the environment otherwise in milliseconds</returns>
			public extern static float now();

			/// <summary>
			/// Returns the window reference for a DomRef.
			/// </summary>
			/// <param name="oDomRef">The DOM reference</param>
			/// <returns>Window reference</returns>
			public extern static dom.Window ownerWindow(dom.HTMLElement oDomRef);

			/// <summary>
			/// Pads a string on the left side until is has at least the given length.
			/// 
			/// The method always adds full copies of <code>sPadChar</code> to the given string. When <code>sPadChar</code> has a length > 1, the length of the returned string actually might be greater than <code>iLength</code>.
			/// </summary>
			/// <param name="sString">String to be padded</param>
			/// <param name="sPadChar">Char to use for the padding</param>
			/// <param name="iLength">Target length of the string</param>
			/// <returns>The padded string</returns>
			public extern static string padLeft(string sString, string sPadChar, int iLength);

			/// <summary>
			/// Pads a string on the right side until is has at least the given length.
			/// 
			/// The method always adds full copies of <code>sPadChar</code> to the given string. When <code>sPadChar</code> has a length > 1, the length of the returned string actually might be greater than <code>iLength</code>.
			/// </summary>
			/// <param name="sString">String to be padded</param>
			/// <param name="sPadChar">Char to use for the padding</param>
			/// <param name="iLength">Target length of the string</param>
			/// <returns>The padded string</returns>
			public extern static string padRight(string sString, string sPadChar, int iLength);

			/// <summary>
			/// Parses the specified XML formatted string text using native parsing function of the browser and returns a valid XML document. If an error occurred during parsing a parse error object is returned as property (parseError) of the returned XML document object. The parse error object has the following error information parameters: errorCode, url, reason, srcText, line, linepos, filepos
			/// </summary>
			/// <param name="sXMLText">the XML data as string</param>
			/// <returns>the parsed XML document with a parseError property as described in getParseError. An error occurred if the errorCode property of the parseError is != 0.</returns>
			public extern static object parseXML(string sXMLText);

			/// <summary>
			/// Creates and returns a new instance of {@link jQuery.sap.util.Properties}.
			/// 
			/// If option 'url' is passed, immediately a load request for the given target is triggered. A property file that is loaded can contain comments with a leading ! or #. The loaded property list does not contain any comments.
			/// 
			/// <b>Example for loading a property file:</b> <pre>
			///  jQuery.sap.properties({url : "../myProperty.properties"});
			/// </pre>
			/// 
			/// <b>Example for creating an empty properties instance:</b> <pre>
			///  jQuery.sap.properties();
			/// </pre>
			/// 
			/// <b>Examples for getting and setting properties:</b> <pre>
			/// 	var oProperties = jQuery.sap.properties();
			/// 	oProperties.setProperty("KEY_1","Test Key");
			/// 	var sValue1 = oProperties.getProperty("KEY_1");
			/// 	var sValue2 = oProperties.getProperty("KEY_2","Default");
			/// </pre>
			/// </summary>
			/// <param name="mParams">Parameters used to initialize the property list</param>
			/// <returns>A new property collection (synchronous case) or <code>null</code> if the file could not be loaded and <code>returnNullIfMissing</code> was set; in case of asynchronous loading, always a Promise is returned, which resolves with the property collection or with <code>null</code> if the file could not be loaded and <code>returnNullIfMissing</code> was set to true</returns>
			public extern static Union<jQuery.sap.util.Properties, jquery.JQueryPromise<object>> properties(jQuery.sap.PropertiesInfo mParams);

			/// <summary>
			/// Creates and returns a new instance of {@link jQuery.sap.util.Properties}.
			/// 
			/// If option 'url' is passed, immediately a load request for the given target is triggered. A property file that is loaded can contain comments with a leading ! or #. The loaded property list does not contain any comments.
			/// 
			/// <b>Example for loading a property file:</b> <pre>
			///  jQuery.sap.properties({url : "../myProperty.properties"});
			/// </pre>
			/// 
			/// <b>Example for creating an empty properties instance:</b> <pre>
			///  jQuery.sap.properties();
			/// </pre>
			/// 
			/// <b>Examples for getting and setting properties:</b> <pre>
			/// 	var oProperties = jQuery.sap.properties();
			/// 	oProperties.setProperty("KEY_1","Test Key");
			/// 	var sValue1 = oProperties.getProperty("KEY_1");
			/// 	var sValue2 = oProperties.getProperty("KEY_2","Default");
			/// </pre>
			/// </summary>
			/// <returns>A new property collection (synchronous case) or <code>null</code> if the file could not be loaded and <code>returnNullIfMissing</code> was set; in case of asynchronous loading, always a Promise is returned, which resolves with the property collection or with <code>null</code> if the file could not be loaded and <code>returnNullIfMissing</code> was set to true</returns>
			public extern static Union<jQuery.sap.util.Properties, jquery.JQueryPromise<object>> properties();

			/// <summary>
			/// Registers a URL prefix for a module name prefix.
			/// 
			/// Before a module is loaded, the longest registered prefix of its module name is searched for and the associated URL prefix is used as a prefix for the request URL. The remainder of the module name is attached to the request URL by replacing dots ('.') with slashes ('/').
			/// 
			/// The registration and search operates on full name segments only. So when a prefix
			/// 
			/// 'sap.com' -> 'http://www.sap.com/ui5/resources/'
			/// 
			/// is registered, then it will match the name
			/// 
			/// 'sap.com.Button'
			/// 
			/// but not
			/// 
			/// 'sap.commons.Button'
			/// 
			/// Note that the empty prefix ('') will always match and thus serves as a fallback for any search.
			/// 
			/// The prefix can either be given as string or as object which contains the url and a 'final' property. If 'final' is set to true, overwriting a module prefix is not possible anymore.
			/// </summary>
			/// <param name="sModuleName">module name to register a path for</param>
			/// <param name="vUrlPrefix">path prefix to register, either a string literal or an object (e.g. {url : 'url/to/res', 'final': true})</param>
			public extern static void registerModulePath(string sModuleName, Union<string, jQuery.sap.RegisterPathInfo> vUrlPrefix);

			/// <summary>
			/// Register information about third party modules that are not UI5 modules.
			/// 
			/// The information maps the name of the module (without extension '.js') to an info object. Instead of a complete info object, only the value of the <code>deps</code> property can be given as an array.
			/// </summary>
			/// <param name="mShims">Map of shim configuration objects keyed by module names (withou extension '.js')</param>
			private extern static void registerModuleShims(object mShims);

			/// <summary>
			/// Adds all resources from a preload bundle to the preload cache.
			/// 
			/// When a resource exists already in the cache, the new content is ignored.
			/// </summary>
			/// <param name="oData">Preload bundle</param>
			private extern static void registerPreloadedModules(object oData);

			/// <summary>
			/// Registers a URL prefix for a resource name prefix.
			/// 
			/// Before a resource is loaded, the longest registered prefix of its unified resource name is searched for and the associated URL prefix is used as a prefix for the request URL. The remainder of the resource name is attached to the request URL 1:1.
			/// 
			/// The registration and search operates on full name segments only. So when a prefix
			/// 
			/// 'sap/com' -> 'http://www.sap.com/ui5/resources/'
			/// 
			/// is registered, then it will match the name
			/// 
			/// 'sap/com/Button'
			/// 
			/// but not
			/// 
			/// 'sap/commons/Button'
			/// 
			/// Note that the empty prefix ('') will always match and thus serves as a fallback for any search.
			/// 
			/// The url prefix can either be given as string or as object which contains the url and a final flag. If final is set to true, overwriting a resource name prefix is not possible anymore.
			/// </summary>
			/// <param name="sResourceNamePrefix">in unified resource name syntax</param>
			/// <param name="vUrlPrefix">prefix to use instead of the sResourceNamePrefix, either a string literal or an object (e.g. {url : 'url/to/res', 'final': true})</param>
			public extern static void registerResourcePath(string sResourceNamePrefix, Union<string, jQuery.sap.RegisterPathInfo> vUrlPrefix);

			/// <summary>
			/// Removes a whitelist entry for URL validation.
			/// </summary>
			/// <param name="iIndex">index of entry</param>
			public extern static void removeUrlWhitelist(int iIndex);

			/// <summary>
			/// Ensures that the given module is loaded and executed before execution of the current script continues.
			/// 
			/// By issuing a call to this method, the caller declares a dependency to the listed modules.
			/// 
			/// Any required and not yet loaded script will be loaded and execute synchronously. Already loaded modules will be skipped.
			/// </summary>
			/// <param name="vModuleName">one or more names of modules to be loaded or in case of an object {modName: "...", type: "..."} where modName is the name of the module and the type could be a specific dot separated extension e.g. <code>{modName: "sap.ui.core.Dev", type: "view"}</code> loads <code>sap/ui/core/Dev.view.js</code> and registers as <code>sap.ui.core.Dev.view</code></param>
			[Obsolete("Deprecated since 1.52. UI5 modules and their dependencies should be defined using {@link sap.ui.define}. When additional modules have to be loaded dynamically at a later point in time, the asynchronous API {@link sap.ui.require} should be used. For more details, see {@link topic:91f23a736f4d1014b6dd926db0e91070 Modules and Dependencies} in the documentation.")]
			public extern static void require(Union<string, object> vModuleName);

			/// <summary>
			/// Creates and returns a new instance of {@link jQuery.sap.util.ResourceBundle} using the given URL and locale to determine what to load.
			/// </summary>
			/// <param name="mParams">Parameters used to initialize the resource bundle</param>
			/// <returns>A new resource bundle or a Promise on that bundle (in asynchronous case)</returns>
			public extern static Union<jQuery.sap.util.ResourceBundle, jquery.JQueryPromise<object>> resources(jQuery.sap.ResourcesInfo mParams);

			/// <summary>
			/// Creates and returns a new instance of {@link jQuery.sap.util.ResourceBundle} using the given URL and locale to determine what to load.
			/// </summary>
			/// <returns>A new resource bundle or a Promise on that bundle (in asynchronous case)</returns>
			public extern static Union<jQuery.sap.util.ResourceBundle, jquery.JQueryPromise<object>> resources();

			/// <summary>
			/// Returns the size (width of the vertical / height of the horizontal) native browser scrollbars.
			/// 
			/// This function must only be used when the DOM is ready.
			/// </summary>
			/// <param name="sClasses">the CSS class that should be added to the test element.</param>
			/// <param name="bForce">force recalculation of size (e.g. when CSS was changed). When no classes are passed all calculated sizes are reset.</param>
			/// <returns>JSON object with properties <code>width</code> and <code>height</code> (the values are of type number and are pixels).</returns>
			public extern static object scrollbarSize(string sClasses, bool bForce = false);

			/// <summary>
			/// Returns the size (width of the vertical / height of the horizontal) native browser scrollbars.
			/// 
			/// This function must only be used when the DOM is ready.
			/// </summary>
			/// <param name="sClasses">the CSS class that should be added to the test element.</param>
			/// <returns>JSON object with properties <code>width</code> and <code>height</code> (the values are of type number and are pixels).</returns>
			public extern static object scrollbarSize(string sClasses);

			/// <summary>
			/// Returns the size (width of the vertical / height of the horizontal) native browser scrollbars.
			/// 
			/// This function must only be used when the DOM is ready.
			/// </summary>
			/// <returns>JSON object with properties <code>width</code> and <code>height</code> (the values are of type number and are pixels).</returns>
			public extern static object scrollbarSize();

			/// <summary>
			/// Returns the size (width of the vertical / height of the horizontal) native browser scrollbars.
			/// 
			/// This function must only be used when the DOM is ready.
			/// </summary>
			/// <param name="bForce">force recalculation of size (e.g. when CSS was changed). When no classes are passed all calculated sizes are reset.</param>
			/// <returns>JSON object with properties <code>width</code> and <code>height</code> (the values are of type number and are pixels).</returns>
			public extern static object scrollbarSize(bool bForce = false);

			/// <summary>
			/// Serializes the specified XML document into a string representation.
			/// </summary>
			/// <param name="oXMLDocument">the XML document object to be serialized as string</param>
			/// <returns>the serialized XML string</returns>
			public extern static object serializeXML(string oXMLDocument);

			/// <summary>
			/// Sets the bookmark icon for desktop browsers and the icon to be displayed on the home screen of iOS devices after the user does "add to home screen".
			/// 
			/// Only call this method once and call it early when the page is loading: browsers behave differently when the favicon is modified while the page is alive. Some update the displayed icon inside the browser but use an old icon for bookmarks. When a favicon is given, any other existing favicon in the document will be removed. When at least one home icon is given, all existing home icons will be removed and new home icon tags for all four resolutions will be created.
			/// 
			/// The home icons must be in PNG format and given in different sizes for iPad/iPhone with and without retina display. The favicon is used in the browser and for desktop shortcuts and should optimally be in ICO format: PNG does not seem to be supported by Internet Explorer and ICO files can contain different image sizes for different usage locations. E.g. a 16x16px version is used inside browsers.
			/// 
			/// All icons are given in an an object holding icon URLs and other settings. The properties of this object are: <ul> <li>phone: a 60x60 pixel version for non-retina iPhones</li> <li>tablet: a 76x76 pixel version for non-retina iPads</li> <li>phone@2: a 120x120 pixel version for retina iPhones</li> <li>tablet@2: a 152x152 pixel version for retina iPads</li> <li>precomposed: whether the home icons already have some glare effect (otherwise iOS will add it) (default: false)</li> <li>favicon: the ICO file to be used inside the browser and for desktop shortcuts</li> </ul>
			/// 
			/// One example is: <pre>
			/// {
			///    'phone':'phone-icon_60x60.png',
			///    'phone@2':'phone-retina_120x120.png',
			///    'tablet':'tablet-icon_76x76.png',
			///    'tablet@2':'tablet-retina_152x152.png',
			///    'precomposed':true,
			///    'favicon':'desktop.ico'
			/// }
			/// </pre> If one of the sizes is not given, the largest available alternative image will be used instead for this size. On Android these icons may or may not be used by the device. Apparently chances can be improved by using icons with glare effect, so the "precomposed" property can be set to "true". Some Android devices may also use the favicon for bookmarks instead of the home icons.</li>
			/// </summary>
			/// <param name="oIcons"></param>
			public extern static void setIcons(object oIcons);

			/// <summary>
			/// Sets the "apple-mobile-web-app-capable" and "mobile-web-app-capable" meta information which defines whether the application is loaded in full screen mode (browser address bar and toolbar are hidden) after the user does "add to home screen" on mobile devices. Currently this meta tag is only supported by iOS Safari and mobile Chrome from version 31.
			/// 
			/// If the application opens new tabs because of attachments, url and so on, setting this to false will let the user be able to go from the new tab back to the application tab after the application is added to home screen.
			/// 
			/// Note: this function only has effect when the application runs on iOS Safari and mobile Chrome from version 31.
			/// </summary>
			/// <param name="bValue">whether the Application will be loaded in full screen mode after added to home screen from iOS Safari or mobile Chrome from version 31.</param>
			public extern static void setMobileWebAppCapable(bool bValue);

			/// <summary>
			/// Sets an object property to a given value, where the property is identified by a sequence of names (path).
			/// 
			/// When a <code>oContext</code> is given, the path starts in that object. Otherwise it starts in the <code>window</code> object that this plugin has been created for.
			/// 
			/// Note: Although this method internally uses <code>object["key"]</code> to address object properties, it does not support all possible characters in a name. Especially the dot ('.') is not supported in the individual name segments, as it is always interpreted as a name separator.
			/// </summary>
			/// <param name="sName">a dot separated sequence of names that identify the property</param>
			/// <param name="vValue">value to be set, can have any type</param>
			/// <param name="oContext">the context to execute the search in</param>
			public extern static void setObject(string sName, object vValue, object oContext);

			/// <summary>
			/// Sets an object property to a given value, where the property is identified by a sequence of names (path).
			/// 
			/// When a <code>oContext</code> is given, the path starts in that object. Otherwise it starts in the <code>window</code> object that this plugin has been created for.
			/// 
			/// Note: Although this method internally uses <code>object["key"]</code> to address object properties, it does not support all possible characters in a name. Especially the dot ('.') is not supported in the individual name segments, as it is always interpreted as a name separator.
			/// </summary>
			/// <param name="sName">a dot separated sequence of names that identify the property</param>
			/// <param name="vValue">value to be set, can have any type</param>
			public extern static void setObject(string sName, object vValue);

			/// <summary>
			/// Convenience wrapper around <code>jQuery.ajax()</code> that avoids the need for callback functions when synchronous calls are made. If the setting <code>complexResult</code> is true (default), then the return value is an object with the following properties <ul> <li><code>success</code> boolean whether the call succeeded or not <li><code>data</code> any the data returned by the call. For dataType 'text' this is a string, for JSON it is an object, for XML it is a document. When the call failed, then data is not defined <li><code>status</code> string a textual status ('success,', 'error', 'timeout',...) <li><code>statusCode</code> string the HTTP status code of the request <li><code>error</code> Error an error object (exception) in case an error occurred <li><code>errorText</code> string an error message in case an error occurred </ul>
			/// 
			/// When <code>complexResult</code> is false, then in the case of success, only 'data' is returned, in case of an error the 'fallback' setting is returned (defaults to undefined).
			/// 
			/// Note that async=false is always enforced by this method.
			/// </summary>
			/// <param name="oOrigSettings">the ajax() settings</param>
			/// <returns>result, see above</returns>
			public extern static void sjax(string oOrigSettings);

			/// <summary>
			/// Checks whether a given <code>sString</code> starts with <code>sStartString</code> respecting the case of the strings.
			/// </summary>
			/// <param name="sString">String to be checked</param>
			/// <param name="sStartString">The start string to be searched</param>
			/// <returns>Whether <code>sString</code> starts with <code>sStartString</code></returns>
			public extern static bool startsWith(string sString, string sStartString);

			/// <summary>
			/// Checks whether a given <code>sString</code> starts with <code>sStartString</code> ignoring the case of both strings.
			/// </summary>
			/// <param name="sString">String to be checked</param>
			/// <param name="sStartString">The start string to be searched</param>
			/// <returns>Whether <code>sString</code> starts with <code>sStartString</code></returns>
			public extern static bool startsWithIgnoreCase(string sString, string sStartString);

			/// <summary>
			/// Convenience wrapper for {@link jQuery.sap.sjax} that enforeces the Http method GET and defaults the data type of the result to 'text'.
			/// </summary>
			/// <param name="sUrl">the URL</param>
			/// <param name="data">request parameters in the format accepted by jQuery.ajax()</param>
			/// <param name="sDataType">the type of data expected from the server, default is "text"</param>
			/// <returns>result @see jQuery.sap.sjax</returns>
			public extern static void syncGet(string sUrl, Union<string, object> data, string sDataType = "text");

			/// <summary>
			/// Convenience wrapper for {@link jQuery.sap.sjax} that enforces the Http method GET and the data type 'json'. If a fallback value is given, the function simply returns the response as an object or - if some error occurred - the fallback value. This is useful for applications that don't require detailed error diagnostics.
			/// 
			/// If applications need to know about occurring errors, they can either call <code>sjax()</code> directly or they can omit the fallback value (providing only two parameters to syncGetJSON()). They then receive the same complex result object as for the sjax() call.
			/// 
			/// Note that providing "undefined" or "null" as a fallback is different from omitting the fallback (complex result).
			/// </summary>
			/// <param name="sUrl">the URL</param>
			/// <param name="data">request parameters in the format accepted by jQuery.ajax()</param>
			/// <param name="fallback">if set, only data is returned (and this fallback instead in case of errors); if unset, a result structure is returned</param>
			/// <returns>result @see jQuery.sap.sjax</returns>
			public extern static void syncGetJSON(string sUrl, Union<string, object> data, object fallback);

			/// <summary>
			/// Convenience wrapper for {@link jQuery.sap.sjax} that enforces the Http method GET and the data type 'json'. If a fallback value is given, the function simply returns the response as an object or - if some error occurred - the fallback value. This is useful for applications that don't require detailed error diagnostics.
			/// 
			/// If applications need to know about occurring errors, they can either call <code>sjax()</code> directly or they can omit the fallback value (providing only two parameters to syncGetJSON()). They then receive the same complex result object as for the sjax() call.
			/// 
			/// Note that providing "undefined" or "null" as a fallback is different from omitting the fallback (complex result).
			/// </summary>
			/// <param name="sUrl">the URL</param>
			/// <param name="data">request parameters in the format accepted by jQuery.ajax()</param>
			/// <returns>result @see jQuery.sap.sjax</returns>
			public extern static void syncGetJSON(string sUrl, Union<string, object> data);

			/// <summary>
			/// Convenience wrapper for {@link jQuery.sap.sjax} that enforces the Http method GET and the data type 'text'. If a fallback value is given, the function simply returns the response as a text or - if some error occurred - the fallback value. This is useful for applications that don't require detailed error diagnostics.
			/// 
			/// If applications need to know about occurring errors, they can either call <code>sjax()</code> directly or they can omit the fallback value (providing only two parameters to syncGetText()). They then receive the same complex result object as for the sjax() call.
			/// </summary>
			/// <param name="sUrl">the URL</param>
			/// <param name="data">request parameters in the format accepted by jQuery.ajax()</param>
			/// <param name="fallback">if set, only data is returned (and this fallback instead in case of errors); if unset, a result structure is returned</param>
			/// <returns>result @see jQuery.sap.sjax</returns>
			public extern static void syncGetText(string sUrl, Union<string, object> data, string fallback);

			/// <summary>
			/// Convenience wrapper for {@link jQuery.sap.sjax} that enforces the Http method GET and the data type 'text'. If a fallback value is given, the function simply returns the response as a text or - if some error occurred - the fallback value. This is useful for applications that don't require detailed error diagnostics.
			/// 
			/// If applications need to know about occurring errors, they can either call <code>sjax()</code> directly or they can omit the fallback value (providing only two parameters to syncGetText()). They then receive the same complex result object as for the sjax() call.
			/// </summary>
			/// <param name="sUrl">the URL</param>
			/// <param name="data">request parameters in the format accepted by jQuery.ajax()</param>
			/// <returns>result @see jQuery.sap.sjax</returns>
			public extern static void syncGetText(string sUrl, Union<string, object> data);

			/// <summary>
			/// Convenience wrapper for {@link jQuery.sap.sjax} that enforces the Http method POST and defaults the data type of the result to 'text'.
			/// </summary>
			/// <param name="sUrl">the URL</param>
			/// <param name="data">request parameters in the format accepted by jQuery.ajax()</param>
			/// <param name="sDataType">the type of data expected from the server, default is "text"</param>
			/// <returns>result @see jQuery.sap.sjax</returns>
			public extern static void syncPost(string sUrl, Union<string, object> data, string sDataType = "text");

			/// <summary>
			/// Search ancestors of the given source DOM element for the specified CSS class name. If the class name is found, set it to the root DOM element of the target control. If the class name is not found, it is also removed from the target DOM element.
			/// </summary>
			/// <param name="sStyleClass">CSS class name</param>
			/// <param name="vSource">jQuery object, control or an id of the source element.</param>
			/// <param name="vDestination">target jQuery object or a control.</param>
			/// <returns>Target element</returns>
			public extern static Union<jQuery, dom.HTMLElement> syncStyleClass(string sStyleClass, Union<jQuery, UI5.sap.ui.core.Control, string> vSource, Union<jQuery, UI5.sap.ui.core.Control> vDestination);

			/// <summary>
			/// Creates and returns a pseudo-unique id.
			/// 
			/// No means for detection of overlap with already present or future UIDs.
			/// </summary>
			/// <returns>A pseudo-unique id.</returns>
			public extern static string uid();

			/// <summary>
			/// Unbinds all events for listening with the given callback function.
			/// </summary>
			/// <param name="fnCallback">Callback function</param>
			public extern static void unbindAnyEvent(object fnCallback);

			/// <summary>
			/// Sorts the given array in-place and removes any duplicates (identified by "===").
			/// 
			/// Use <code>jQuery.unique()</code> for arrays of DOMElements.
			/// </summary>
			/// <param name="a">An Array of any type</param>
			/// <returns>Same array as given (for chaining)</returns>
			public extern static object[] unique(object[] a);

			/// <summary>
			/// Validates a URL. Check if it's not a script or other security issue.
			/// 
			/// By default the URL validation does only allow the http, https and ftp protocol. If other protocols are required, a whitelist of all allowed protocols needs to be defined.
			/// 
			/// Split URL into components and check for allowed characters according to RFC 3986:
			/// 
			/// <pre>
			/// authority     = [ userinfo "@" ] host [ ":" port ]
			/// userinfo      = *( unreserved / pct-encoded / sub-delims / ":" )
			/// host          = IP-literal / IPv4address / reg-name
			/// 
			/// IP-literal    = "[" ( IPv6address / IPvFuture  ) "]"
			/// IPvFuture     = "v" 1*HEXDIG "." 1*( unreserved / sub-delims / ":" )
			/// IPv6address   =                            6( h16 ":" ) ls32
			///               /                       "::" 5( h16 ":" ) ls32
			///               / [               h16 ] "::" 4( h16 ":" ) ls32
			///               / [ *1( h16 ":" ) h16 ] "::" 3( h16 ":" ) ls32
			///               / [ *2( h16 ":" ) h16 ] "::" 2( h16 ":" ) ls32
			///               / [ *3( h16 ":" ) h16 ] "::"    h16 ":"   ls32
			///               / [ *4( h16 ":" ) h16 ] "::"              ls32
			///               / [ *5( h16 ":" ) h16 ] "::"              h16
			///               / [ *6( h16 ":" ) h16 ] "::"
			/// ls32          = ( h16 ":" h16 ) / IPv4address
			///               ; least-significant 32 bits of address
			/// h16           = 1*4HEXDIG
			///               ; 16 bits of address represented in hexadecimal
			/// 
			/// IPv4address   = dec-octet "." dec-octet "." dec-octet "." dec-octet
			/// dec-octet     = DIGIT                 ; 0-9
			///               / %x31-39 DIGIT         ; 10-99
			///               / "1" 2DIGIT            ; 100-199
			///               / "2" %x30-34 DIGIT     ; 200-249
			///               / "25" %x30-35          ; 250-255
			/// 
			/// reg-name      = *( unreserved / pct-encoded / sub-delims )
			/// 
			/// pct-encoded   = "%" HEXDIG HEXDIG
			/// reserved      = gen-delims / sub-delims
			/// gen-delims    = ":" / "/" / "?" / "#" / "[" / "]" / "@"
			/// sub-delims    = "!" / "$" / "&" / "'" / "(" / ")"
			///               / "*" / "+" / "," / ";" / "="
			/// unreserved    = ALPHA / DIGIT / "-" / "." / "_" / "~"
			/// pchar         = unreserved / pct-encoded / sub-delims / ":" / "@"
			/// 
			/// path          = path-abempty    ; begins with "/" or is empty
			///               / path-absolute   ; begins with "/" but not "//"
			///               / path-noscheme   ; begins with a non-colon segment
			///               / path-rootless   ; begins with a segment
			///               / path-empty      ; zero characters
			/// 
			/// path-abempty  = *( "/" segment )
			/// path-absolute = "/" [ segment-nz *( "/" segment ) ]
			/// path-noscheme = segment-nz-nc *( "/" segment )
			/// path-rootless = segment-nz *( "/" segment )
			/// path-empty    = 0<pchar>
			/// segment       = *pchar
			/// segment-nz    = 1*pchar
			/// segment-nz-nc = 1*( unreserved / pct-encoded / sub-delims / "@" )
			///               ; non-zero-length segment without any colon ":"
			/// 
			/// query         = *( pchar / "/" / "?" )
			/// 
			/// fragment      = *( pchar / "/" / "?" )
			/// </pre>
			/// 
			/// For the hostname component, we are checking for valid DNS hostnames according to RFC 952 / RFC 1123:
			/// 
			/// <pre>
			/// hname         = name *("." name)
			/// name          = let-or-digit ( *( let-or-digit-or-hyphen ) let-or-digit )
			/// </pre>
			/// 
			/// When the URI uses the protocol 'mailto:', the address part is additionally checked against the most commonly used parts of RFC 6068:
			/// 
			/// <pre>
			/// mailtoURI     = "mailto:" [ to ] [ hfields ]
			/// to            = addr-spec *("," addr-spec )
			/// hfields       = "?" hfield *( "&" hfield )
			/// hfield        = hfname "=" hfvalue
			/// hfname        = *qchar
			/// hfvalue       = *qchar
			/// addr-spec     = local-part "@" domain
			/// local-part    = dot-atom-text              // not accepted: quoted-string
			/// domain        = dot-atom-text              // not accepted: "[" *dtext-no-obs "]"
			/// dtext-no-obs  = %d33-90 / ; Printable US-ASCII
			///                 %d94-126  ; characters not including
			///                           ; "[", "]", or "\"
			/// qchar         = unreserved / pct-encoded / some-delims
			/// some-delims   = "!" / "$" / "'" / "(" / ")" / "*"
			///               / "+" / "," / ";" / ":" / "@"
			/// 
			/// Note:
			/// A number of characters that can appear in &lt;addr-spec> MUST be
			/// percent-encoded.  These are the characters that cannot appear in
			/// a URI according to [STD66] as well as "%" (because it is used for
			/// percent-encoding) and all the characters in gen-delims except "@"
			/// and ":" (i.e., "/", "?", "#", "[", and "]").  Of the characters
			/// in sub-delims, at least the following also have to be percent-
			/// encoded: "&", ";", and "=".  Care has to be taken both when
			/// encoding as well as when decoding to make sure these operations
			/// are applied only once.
			/// 
			/// </pre>
			/// 
			/// When a whitelist has been configured using {@link #.addUrlWhitelist addUrlWhitelist}, any URL that passes the syntactic checks above, additionally will be tested against the content of the whitelist.
			/// </summary>
			/// <param name="sUrl"></param>
			/// <returns>true if valid, false if not valid</returns>
			public extern static void validateUrl(string sUrl);

			#endregion

			/// <summary>
			/// Enumeration of key codes.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("jQuery.sap.KeyCodes")]
			public enum KeyCodes
			{
				A,
				ALT,
				ARROW_DOWN,
				ARROW_LEFT,
				ARROW_RIGHT,
				ARROW_UP,
				B,
				BACKSLASH,
				BACKSPACE,
				BREAK,
				C,
				CAPS_LOCK,
				COMMA,
				CONTEXT_MENU,
				CONTROL,
				D,
				DELETE,
				DIGIT_0,
				DIGIT_1,
				DIGIT_2,
				DIGIT_3,
				DIGIT_4,
				DIGIT_5,
				DIGIT_6,
				DIGIT_7,
				DIGIT_8,
				DIGIT_9,
				DOT,
				E,
				END,
				ENTER,
				EQUALS,
				ESCAPE,
				F,
				F1,
				F10,
				F11,
				F12,
				F2,
				F3,
				F4,
				F5,
				F6,
				F7,
				F8,
				F9,
				G,
				GREAT_ACCENT,
				H,
				HOME,
				I,
				INSERT,
				J,
				K,
				L,
				M,
				MINUS,
				N,
				NUM_LOCK,
				NUMPAD_0,
				NUMPAD_1,
				NUMPAD_2,
				NUMPAD_3,
				NUMPAD_4,
				NUMPAD_5,
				NUMPAD_6,
				NUMPAD_7,
				NUMPAD_8,
				NUMPAD_9,
				NUMPAD_ASTERISK,
				NUMPAD_COMMA,
				NUMPAD_MINUS,
				NUMPAD_PLUS,
				NUMPAD_SLASH,
				O,
				OPEN_BRACKET,
				P,
				PAGE_DOWN,
				PAGE_UP,
				PIPE,
				PLUS,
				PRINT,
				Q,
				R,
				S,
				SCROLL_LOCK,
				SEMICOLON,
				SHIFT,
				SINGLE_QUOTE,
				SLASH,
				SLEEP,
				SPACE,
				T,
				TAB,
				TURN_OFF,
				U,
				V,
				W,
				WINDOWS,
				X,
				Y,
				Z,
			}
		}
	}
}
