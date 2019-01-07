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
			/// A small, non-disruptive popup for messages. <h3>Overview</h3> A message toast is a small, non-disruptive popup for success or information messages that disappears automatically after a few seconds. Toasts automatically disappear after a timeout unless the user moves the mouse over the toast or taps on it. <h4>Notes:</h4> <ul> <li>If the configured message contains HTML code or script tags, those will be escaped.</li> <li>Line breaks (\r\n, \n\r, \r, \n) will be visualized.</li> <li>Only one message toast can be shown at a time in the same place.</li> </ul> <h4>Example:</h4> Here is an example of a MessageToast with all default options: <pre>
			/// sap.m.MessageToast.show("This message should appear in the message toast", {
			///     duration: 3000,                  // default
			///     width: "15em",                   // default
			///     my: "center bottom",             // default
			///     at: "center bottom",             // default
			///     of: window,                      // default
			///     offset: "0 0",                   // default
			///     collision: "fit fit",            // default
			///     onClose: null,                   // default
			///     autoClose: true,                 // default
			///     animationTimingFunction: "ease", // default
			///     animationDuration: 1000,         // default
			///     closeOnBrowserNavigation: true   // default
			/// });
			/// </pre> <h3>Usage</h3> <h4>When to use:</h4> <ul> <li>You want to display a short success of information message.</li> <li>You do not want to interrupt users while they are performing an action.</li> <li>You want to confirm a successful action.</li> </ul> <h4>When not to use:</h4> <ul> <li>You want to display an error or warning message.</li> <li>You want to interrupt users while they are performing an action.</li> <li>You want to make sure that users read the message before they leave the page.</li> <li>You want users to be able to copy some part of the message text. (In this case, show a success {@link sap.m.Dialog Message Dialog}.)</li> </ul> <h3>Responsive Behavior</h3> The message toast has the same behavior on all devices. However, you can adjust the width of the control, for example, for use on a desktop device.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.MessageToast")]
			public static partial class MessageToast
			{
				#region Typed Parameters

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class ShowOptions
				{
					/// <summary>
					/// Time in milliseconds before the close animation starts. Needs to be a finite positive nonzero integer.
					/// </summary>
					public int duration;

					/// <summary>
					/// The width of the message toast, this value can be provided in %, em, px and all possible CSS measures.
					/// </summary>
					public sap.ui.core.CSSSize width;

					/// <summary>
					/// Specifies which point of the message toast should be aligned.
					/// </summary>
					public sap.ui.core.Popup.Dock my;

					/// <summary>
					/// Specifies the point of the reference element to which the message toast should be aligned.
					/// </summary>
					public sap.ui.core.Popup.Dock at;

					/// <summary>
					/// Specifies the reference element to which the message toast should be aligned, by default it is aligned to the browser visual viewport.
					/// </summary>
					public Union<sap.ui.core.Control, Retyped.dom.HTMLElement, jQuery, Retyped.dom.Window> of;

					/// <summary>
					/// The offset relative to the docking point, specified as a string with space-separated pixel values (e.g. "0 10" to move the message toast 10 pixels to the right).
					/// </summary>
					public string offset;

					/// <summary>
					/// Specifies how the position of the message toast should be adjusted in case it overflows the screen in some direction. Possible values “fit”, “flip”, “none”, or a pair for horizontal and vertical e.g. "fit flip”, "fit none".
					/// </summary>
					public string collision;

					/// <summary>
					/// Function to be called when the message toast closes.
					/// </summary>
					public object onClose;

					/// <summary>
					/// Specify whether the message toast should close as soon as the end user touches the screen.
					/// </summary>
					public bool autoClose;

					/// <summary>
					/// Describes how the close animation will progress. Possible values "ease", "linear", "ease-in", "ease-out", "ease-in-out".
					/// </summary>
					public string animationTimingFunction;

					/// <summary>
					/// Time in milliseconds that the close animation takes to complete. Needs to be a finite positive integer. For not animation set to 0.
					/// </summary>
					public int animationDuration;

					/// <summary>
					/// Specifies if the message toast closes on browser navigation.
					/// </summary>
					public bool closeOnBrowserNavigation;

				}

				#endregion

				#region Methods

				/// <summary>
				/// Creates and displays a simple message toast notification message with the given text, and optionally other options.
				/// 
				/// The only mandatory parameter is <code>sMessage</code>.
				/// </summary>
				/// <param name="sMessage">The message to be displayed.</param>
				/// <param name="mOptions">Object which can contain all other options. Not all entries in this object are required. This property is optional.</param>
				public extern static void show(string sMessage, sap.m.MessageToast.ShowOptions mOptions);

				/// <summary>
				/// Creates and displays a simple message toast notification message with the given text, and optionally other options.
				/// 
				/// The only mandatory parameter is <code>sMessage</code>.
				/// </summary>
				/// <param name="sMessage">The message to be displayed.</param>
				public extern static void show(string sMessage);

				#endregion

			}
		}
	}
}
