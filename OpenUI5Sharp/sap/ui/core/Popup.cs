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
				/// Popup Class is a helper class for controls that want themselves or parts of themselves or even other aggregated or composed controls or plain HTML content to popup on the screen like menues, dialogs, drop down boxes.
				/// 
				/// It allows the controls to be aligned to other dom elements using the {@link sap.ui.core.Popup.Dock} method. With it you can define where the popup should be docked. One can dock the popup to the top bottom left or right side of a dom ref.
				/// 
				/// In the case that the popup has no space to show itself in the view port of the current window it tries to open itself to the inverted direction.
				/// 
				/// <strong>Since 1.12.3</strong> it is possible to add further DOM-element-ids that can get the focus when 'autoclose' is enabled. E.g. the RichTextEditor with running TinyMCE uses this method to be able to focus the Popups of the TinyMCE if the RichTextEditor runs within a Popup/Dialog etc.
				/// 
				/// To provide an additional DOM-element that can get the focus the following should be done: // create an object with the corresponding DOM-id var oObject = { id : "this_is_the_most_valuable_id_of_the_DOM_element" };
				/// 
				/// // add the event prefix for adding an element to the ID of the corresponding Popup var sEventId = "sap.ui.core.Popup.addFocusableContent-" + oPopup.getId();
				/// 
				/// // fire the event with the created event-id and the object with the DOM-id sap.ui.getCore().getEventBus().publish("sap.ui", sEventId, oObject);
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.core.Popup")]
				public partial class Popup : sap.ui.@base.ManagedObject
				{
					#region Settings

					/// <summary>
					/// Settings class to create the object
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class Settings : sap.ui.@base.ManagedObject.Settings
					{
						public sap.ui.@base.EventDelegate opened;

						public sap.ui.@base.EventDelegate closed;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Creates an instance of <code>sap.ui.core.Popup</code> that can be used to open controls as a Popup, visually appearing in front of other controls.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="oContent">the content to render in the popup. In case of sap.ui.core.Element or DOMNode, the content must be present in the page (i.e. rendered). In case of sap.ui.core.Control, the Popup ensures rendering before opening.</param>
					/// <param name="bModal">whether the popup should be opened in a modal way (i.e. with blocking background). Setting this to "true" effectively blocks all attempts to focus content outside the modal popup. A modal popup also automatically sets the focus back to whatever was focused when the popup opened.</param>
					/// <param name="bShadow">whether the popup should be have a visual shadow underneath (shadow appearance depends on active theme and browser support)</param>
					/// <param name="bAutoClose">whether the popup should automatically close when the focus moves out of the popup</param>
					public extern Popup(Union<sap.ui.core.Control, sap.ui.core.Element, dom.HTMLElement> oContent, bool bModal = false, bool bShadow = true, bool bAutoClose = false);

					#endregion

					#region Methods

					#region Methods for Association childPopups

					#endregion

					#region Methods for Event opened

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:opened opened} event of this <code>sap.ui.core.Popup</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.core.Popup</code> itself.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.core.Popup</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.Popup attachOpened(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:opened opened} event of this <code>sap.ui.core.Popup</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.core.Popup</code> itself.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.Popup attachOpened(object oData, sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:opened opened} event of this <code>sap.ui.core.Popup</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.core.Popup</code> itself.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.Popup attachOpened(sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:opened opened} event of this <code>sap.ui.core.Popup</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.core.Popup</code> itself.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.core.Popup</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.Popup attachOpened(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:opened opened} event of this <code>sap.ui.core.Popup</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.Popup detachOpened(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:opened opened} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.Popup fireOpened(object mParameters);

					/// <summary>
					/// Fires event {@link #event:opened opened} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.Popup fireOpened();

					#endregion

					#region Methods for Event closed

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:closed closed} event of this <code>sap.ui.core.Popup</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.core.Popup</code> itself.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.core.Popup</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.Popup attachClosed(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:closed closed} event of this <code>sap.ui.core.Popup</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.core.Popup</code> itself.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.Popup attachClosed(object oData, sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:closed closed} event of this <code>sap.ui.core.Popup</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.core.Popup</code> itself.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.Popup attachClosed(sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:closed closed} event of this <code>sap.ui.core.Popup</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.core.Popup</code> itself.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.core.Popup</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.Popup attachClosed(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:closed closed} event of this <code>sap.ui.core.Popup</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.Popup detachClosed(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:closed closed} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.Popup fireClosed(object mParameters);

					/// <summary>
					/// Fires event {@link #event:closed closed} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.Popup fireClosed();

					#endregion

					#region Other methods

					/// <summary>
					/// Closes the popup.
					/// 
					/// If the Popup is already closed or in the process of closing, calling this method does nothing. If the Popup is in the process of being opened and closed with a duration of 0, calling this method does nothing. If the Popup is in the process of being opened and closed with an animation duration, the animation will be chained, but this functionality is dangerous, may lead to inconsistent behavior and is thus not recommended and may even be removed.
					/// </summary>
					/// <param name="iDuration">animation duration in milliseconds; default is the jQuery preset "fast". For iDuration == 0 the closing happens synchronously without animation.</param>
					public extern virtual void close(int iDuration);

					/// <summary>
					/// Closes the popup.
					/// 
					/// If the Popup is already closed or in the process of closing, calling this method does nothing. If the Popup is in the process of being opened and closed with a duration of 0, calling this method does nothing. If the Popup is in the process of being opened and closed with an animation duration, the animation will be chained, but this functionality is dangerous, may lead to inconsistent behavior and is thus not recommended and may even be removed.
					/// </summary>
					public extern virtual void close();

					/// <summary>
					/// Closes and destroys this instance of Popup. Does not destroy the hosted content.
					/// </summary>
					public extern override void destroy();

					/// <summary>
					/// When the Popup is being destroyed all corresponding references should be deleted as well to prevent any memory leaks.
					/// </summary>
					public extern virtual void exit();

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.Popup with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.ManagedObject.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.Popup with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.ManagedObject.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.Popup with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.ManagedObject.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Determines whether the pop-up should auto closes or not.
					/// </summary>
					/// <returns></returns>
					public extern virtual bool getAutoClose();

					/// <summary>
					/// Returns this Popup's content.
					/// </summary>
					/// <returns>the content that has been set previously (if any)</returns>
					public extern virtual Union<sap.ui.core.Control, dom.HTMLElement> getContent();

					/// <summary>
					/// This returns true/false if the default followOf method should be used. If a separate followOf-handler was previously added the correspodning function is returned.
					/// </summary>
					/// <returns>if a function was set it is returned otherwise a boolean value whether the follow of is activated</returns>
					public extern virtual Union<bool, object> getFollowOf();

					/// <summary>
					/// Returns the last z-index that has been handed out. does not increase the internal z-index counter.
					/// </summary>
					/// <returns></returns>
					public extern virtual int getLastZIndex();

					/// <summary>
					/// Returns a metadata object for class sap.ui.core.Popup.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					/// <summary>
					/// Returns the value if a Popup is of modal type
					/// </summary>
					/// <returns>{boolean] bModal whether the Popup is of modal type</returns>
					public extern virtual void getModal();

					/// <summary>
					/// Returns the next available z-index on top of the existing/previous popups. Each call increases the internal z-index counter and the returned z-index.
					/// </summary>
					/// <returns>the next z-index on top of the Popup stack</returns>
					public extern virtual int getNextZIndex();

					/// <summary>
					/// Returns whether the Popup is currently open, closed, or transitioning between these states.
					/// </summary>
					/// <returns>whether the Popup is opened</returns>
					public extern virtual sap.ui.core.OpenState getOpenState();

					/// <summary>
					/// Returns whether the Popup is currently open (this includes opening and closing animations).
					/// </summary>
					/// <returns>whether the Popup is opened (or currently being opened or closed)</returns>
					public extern virtual bool isOpen();

					/// <summary>
					/// Opens the popup's content at the position either specified here or beforehand via {@link #setPosition}. Content must be capable of being positioned via "position:absolute;" All parameters are optional (open() may be called without any parameters). iDuration may just be omitted, but if any of "at", "of", "offset", "collision" is given, also the preceding positioning parameters ("my", at",...) must be given.
					/// 
					/// If the Popup's OpenState is different from "CLOSED" (i.e. if the Popup is already open, opening or closing), the call is ignored.
					/// </summary>
					/// <param name="iDuration">animation duration in milliseconds; default is the jQuery preset "fast". For iDuration == 0 the opening happens synchronously without animation.</param>
					/// <param name="my">the popup content's reference position for docking</param>
					/// <param name="at">the "of" element's reference point for docking to</param>
					/// <param name="of">specifies the reference element to which the given content should dock to</param>
					/// <param name="offset">the offset relative to the docking point, specified as a string with space-separated pixel values (e.g. "0 10" to move the popup 10 pixels to the right). If the docking of both "my" and "at" are both RTL-sensitive ("begin" or "end"), this offset is automatically mirrored in the RTL case as well.</param>
					/// <param name="collision">defines how the position of an element should be adjusted in case it overflows the window in some direction.</param>
					/// <param name="followOf">defines whether the popup should follow the dock reference when the reference changes its position.</param>
					public extern virtual void open(int iDuration, sap.ui.core.Popup.Dock my = sap.ui.core.Popup.Dock.CenterCenter, sap.ui.core.Popup.Dock at = sap.ui.core.Popup.Dock.CenterCenter, Union<string, sap.ui.core.Element, dom.HTMLElement, jQuery, jquery.JQuery.Event> of = Globals.document, string offset = "0 0", string collision = "flip", bool followOf = false);

					/// <summary>
					/// Opens the popup's content at the position either specified here or beforehand via {@link #setPosition}. Content must be capable of being positioned via "position:absolute;" All parameters are optional (open() may be called without any parameters). iDuration may just be omitted, but if any of "at", "of", "offset", "collision" is given, also the preceding positioning parameters ("my", at",...) must be given.
					/// 
					/// If the Popup's OpenState is different from "CLOSED" (i.e. if the Popup is already open, opening or closing), the call is ignored.
					/// </summary>
					/// <param name="iDuration">animation duration in milliseconds; default is the jQuery preset "fast". For iDuration == 0 the opening happens synchronously without animation.</param>
					public extern virtual void open(int iDuration);

					/// <summary>
					/// Opens the popup's content at the position either specified here or beforehand via {@link #setPosition}. Content must be capable of being positioned via "position:absolute;" All parameters are optional (open() may be called without any parameters). iDuration may just be omitted, but if any of "at", "of", "offset", "collision" is given, also the preceding positioning parameters ("my", at",...) must be given.
					/// 
					/// If the Popup's OpenState is different from "CLOSED" (i.e. if the Popup is already open, opening or closing), the call is ignored.
					/// </summary>
					public extern virtual void open();

					/// <summary>
					/// Opens the popup's content at the position either specified here or beforehand via {@link #setPosition}. Content must be capable of being positioned via "position:absolute;" All parameters are optional (open() may be called without any parameters). iDuration may just be omitted, but if any of "at", "of", "offset", "collision" is given, also the preceding positioning parameters ("my", at",...) must be given.
					/// 
					/// If the Popup's OpenState is different from "CLOSED" (i.e. if the Popup is already open, opening or closing), the call is ignored.
					/// </summary>
					/// <param name="my">the popup content's reference position for docking</param>
					/// <param name="at">the "of" element's reference point for docking to</param>
					/// <param name="of">specifies the reference element to which the given content should dock to</param>
					/// <param name="offset">the offset relative to the docking point, specified as a string with space-separated pixel values (e.g. "0 10" to move the popup 10 pixels to the right). If the docking of both "my" and "at" are both RTL-sensitive ("begin" or "end"), this offset is automatically mirrored in the RTL case as well.</param>
					/// <param name="collision">defines how the position of an element should be adjusted in case it overflows the window in some direction.</param>
					/// <param name="followOf">defines whether the popup should follow the dock reference when the reference changes its position.</param>
					public extern virtual void open(sap.ui.core.Popup.Dock my = sap.ui.core.Popup.Dock.CenterCenter, sap.ui.core.Popup.Dock at = sap.ui.core.Popup.Dock.CenterCenter, Union<string, sap.ui.core.Element, dom.HTMLElement, jQuery, jquery.JQuery.Event> of = Globals.document, string offset = "0 0", string collision = "flip", bool followOf = false);

					/// <summary>
					/// Sets the animation functions to use for opening and closing the Popup. Any null value will be ignored and not change the respective animation function. When called, the animation functions receive three parameters: - the jQuery object wrapping the DomRef of the popup - the requested animation duration - a function that MUST be called once the animation has completed
					/// </summary>
					/// <param name="fnOpen"></param>
					/// <param name="fnClose"></param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.Popup setAnimations(object fnOpen, object fnClose);

					/// <summary>
					/// Used to specify whether the Popup should close as soon as - for non-touch environment: the focus leaves - for touch environment: user clicks the area which is outside the popup itself, the dom elemnt which popup aligns to (except document), and one of the autoCloseAreas set by calling setAutoCloseAreas.
					/// </summary>
					/// <param name="bAutoClose">whether the Popup should close as soon as the focus leaves</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.Popup setAutoClose(bool bAutoClose);

					/// <summary>
					/// Sets the additional areas in the page that are considered part of the Popup when autoclose is enabled. - non-touch environment: if the focus leaves the Popup but immediately enters one of these areas, the Popup does NOT close. - touch environment: if user clicks one of these areas, the Popup does NOT close.
					/// </summary>
					/// <param name="aAutoCloseAreas">an array containing DOM elements, sap.ui.core.Element or an ID which are considered part of the Popup; a value of null removes all previous areas</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.Popup setAutoCloseAreas(Union<dom.HTMLElement[], sap.ui.core.Element[], string[]> aAutoCloseAreas);

					/// <summary>
					/// Sets the content this instance of the Popup should render. Content must be capable of being positioned via position:absolute;
					/// </summary>
					/// <param name="oContent"></param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.Popup setContent(Union<sap.ui.core.Control, dom.HTMLElement> oContent);

					/// <summary>
					/// Sets the durations for opening and closing animations. Null values and values < 0 are ignored. A duration of 0 means no animation. Default value is "fast" which is the jQuery constant for "200 ms".
					/// </summary>
					/// <param name="iOpenDuration">in milliseconds</param>
					/// <param name="iCloseDuration">in milliseconds</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.Popup setDurations(int iOpenDuration, int iCloseDuration);

					/// <summary>
					/// This enabled/disables the Popup to follow its opening reference. If the Popup is open and a followOf should be set the corresponding listener will be attached.
					/// </summary>
					/// <param name="followOf">a boolean value enabled/disables the default followOf-Handler. Or an individual handler can be given. null deletes all followOf settings.</param>
					public extern virtual void setFollowOf(Union<bool, object> followOf);

					/// <summary>
					/// Sets the ID of the element that should be focused once the popup opens. If the given ID is the ID of an existing Control, this Control's focusDomRef will be focused instead, which may be an HTML element with a different ID (usually a sub-element inside the Control). If no existing element ID is supplied and the Popup is modal or auto-close, the Popup will instead focus the first focusable element.
					/// </summary>
					/// <param name="sId">the ID of the DOM element to focus</param>
					public extern virtual void setInitialFocusId(string sId);

					/// <summary>
					/// Set an initial z-index that should be used by all Popup so all Popups start at least with the set z-index. If the given z-index is lower than any current available z-index the highest z-index will be used.
					/// </summary>
					/// <param name="iInitialZIndex">is the initial z-index</param>
					public extern static void setInitialZIndex(int iInitialZIndex);

					/// <summary>
					/// Used to specify whether the Popup should be modal. A modal popup will put some fading "block layer" over the background and prevent attempts to put the focus outside/below the popup. Setting this while the popup is open will change "block layer" immediately.
					/// </summary>
					/// <param name="bModal">whether the Popup is of modal type</param>
					/// <param name="sModalCSSClass">a CSS class (or space-separated list of classes) that should be added to the block layer</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.Popup setModal(bool bModal, string sModalCSSClass);

					/// <summary>
					/// Used to specify whether the Popup should be modal. A modal popup will put some fading "block layer" over the background and prevent attempts to put the focus outside/below the popup. Setting this while the popup is open will change "block layer" immediately.
					/// </summary>
					/// <param name="bModal">whether the Popup is of modal type</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.Popup setModal(bool bModal);

					/// <summary>
					/// Sets the position of the Popup (if you refer to a Control as anchor then do not use the DOMRef of the control which might change after re-renderings). Optional parameters can only be omitted when all subsequent parameters are omitted as well.
					/// </summary>
					/// <param name="my">specifies which point of the given Content should be aligned</param>
					/// <param name="at">specifies the point of the reference element to which the given Content should be aligned</param>
					/// <param name="of">specifies the reference element to which the given content should be aligned as specified in the other parameters</param>
					/// <param name="offset">the offset relative to the docking point, specified as a string with space-separated pixel values (e.g. "0 10" to move the popup 10 pixels to the right). If the docking of both "my" and "at" are both RTL-sensitive ("begin" or "end"), this offset is automatically mirrored in the RTL case as well.</param>
					/// <param name="collision">defines how the position of an element should be adjusted in case it overflows the window in some direction. The valid values that refer to jQuery-UI's position parameters are "flip", "fit" and "none".</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.Popup setPosition(sap.ui.core.Popup.Dock my, Union<sap.ui.core.Popup.Dock, object> at, Union<string, sap.ui.core.Element, dom.HTMLElement, jQuery, jquery.JQuery.Event> of, string offset, string collision);

					/// <summary>
					/// Sets the position of the Popup (if you refer to a Control as anchor then do not use the DOMRef of the control which might change after re-renderings). Optional parameters can only be omitted when all subsequent parameters are omitted as well.
					/// </summary>
					/// <param name="my">specifies which point of the given Content should be aligned</param>
					/// <param name="at">specifies the point of the reference element to which the given Content should be aligned</param>
					/// <param name="of">specifies the reference element to which the given content should be aligned as specified in the other parameters</param>
					/// <param name="offset">the offset relative to the docking point, specified as a string with space-separated pixel values (e.g. "0 10" to move the popup 10 pixels to the right). If the docking of both "my" and "at" are both RTL-sensitive ("begin" or "end"), this offset is automatically mirrored in the RTL case as well.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.Popup setPosition(sap.ui.core.Popup.Dock my, Union<sap.ui.core.Popup.Dock, object> at, Union<string, sap.ui.core.Element, dom.HTMLElement, jQuery, jquery.JQuery.Event> of = Globals.document, string offset = "0 0");

					/// <summary>
					/// Determines whether the Popup should have a shadow (in supporting browsers). This also affects a currently open popup.
					/// </summary>
					/// <param name="bShowShadow">whether to show a shadow</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.Popup setShadow(bool bShowShadow);

					#endregion

					#endregion

				}
			}
		}
	}
}
