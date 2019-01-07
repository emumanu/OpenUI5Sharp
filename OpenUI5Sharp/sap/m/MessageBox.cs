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
			/// Provides easier methods to create sap.m.Dialog with type sap.m.DialogType.Message, such as standard alerts, confirmation dialogs, or arbitrary message dialogs.
			/// 
			/// As <code>MessageBox</code> is a static class, a <code>jQuery.sap.require("sap.m.MessageBox");</code> statement must be explicitly executed before the class can be used. MessageBox provides several functions. <ul> <li>show() - open a generic MessageBox. You can customize its contents thought the options described below in function option section.</li> <li>alert(), confirm(), error(), information(), success() and warning() - predefined templates of MessageBoxes of the corresponding type with predefined action buttons and icon. Only the recommended options are documented for those functions. </ul> <b>NOTE:</b> All options of show() are available for the other template functions as well, but it is recommended to use show() only in more specific scenarios. Example: <pre>
			///   jQuery.sap.require("sap.m.MessageBox");
			///   sap.m.MessageBox.show(
			///       "This message should appear in the message box.", {
			///           icon: sap.m.MessageBox.Icon.INFORMATION,
			///           title: "My message box title",
			///           actions: [sap.m.MessageBox.Action.YES, sap.m.MessageBox.Action.NO],
			///           onClose: function(oAction) { / * do something * / }
			///       }
			///     );
			/// </pre>
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.MessageBox")]
			public static partial class MessageBox
			{
				#region Typed Parameters

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class NotifyOptions
				{
					/// <summary>
					/// The icon to be displayed.
					/// </summary>
					public sap.m.MessageBox.Icon icon;

					/// <summary>
					/// The title of the message box.
					/// </summary>
					public string title;

					/// <summary>
					/// Either a single action, or an array of two actions. If no action(s) are given, the single action MessageBox.Action.OK is taken as a default for the parameter. From UI5 version 1.21, more than 2 actions are supported. For the former versions, if more than two actions are given, only the first two actions are taken. Custom action string(s) can be provided, and then the translation of custom action string(s) needs to be done by the application.
					/// </summary>
					public Union<sap.m.MessageBox.Action, sap.m.MessageBox.Action[], string, string[]> actions;

					/// <summary>
					/// Function to be called when the user taps a button or closes the message box.
					/// </summary>
					public sap.m.MessageBox.CloseDelegate onClose;

					/// <summary>
					/// ID to be used for the dialog. Intended for test scenarios, not recommended for productive apps
					/// </summary>
					public string id;

					/// <summary>
					/// Added since version 1.21.2. CSS style class which is added to the dialog's root DOM node. The compact design can be activated by setting this to "sapUiSizeCompact"
					/// </summary>
					public string styleClass;

					/// <summary>
					/// Added since version 1.28.0. initialFocus, this option sets the action name, the text of the button or the control that gets the focus as first focusable element after the MessageBox is opened. The usage of sap.ui.core.Control to set initialFocus is deprecated since version 1.30.4.
					/// </summary>
					public Union<string, sap.m.MessageBox.Action> initialFocus;

					/// <summary>
					/// Added since version 1.28. Specifies the element's text directionality with enumerated options. By default, the control inherits text direction from the DOM.
					/// </summary>
					public sap.ui.core.TextDirection textDirection;

					/// <summary>
					/// verticalScrolling is deprecated since version 1.30.4. VerticalScrolling, this option indicates if the user can scroll vertically inside the MessageBox when the content is larger than the content area.
					/// </summary>
					public bool verticalScrolling;

					/// <summary>
					/// horizontalScrolling is deprecated since version 1.30.4. HorizontalScrolling, this option indicates if the user can scroll horizontally inside the MessageBox when the content is larger than the content area.
					/// </summary>
					public bool horizontalScrolling;

					/// <summary>
					/// Added since version 1.28.0. If 'details' is set in the MessageBox, a 'Show detail' link is added. When you click the link, it is set to visible = false and the text area containing 'details' information is then displayed.
					/// </summary>
					public string details;

					/// <summary>
					/// The width of the MessageBox
					/// </summary>
					public sap.ui.core.CSSSize contentWidth;

				}

				#endregion

				#region Methods

				/// <summary>
				/// Displays an alert dialog with the given message and an OK button (no icons).
				/// 
				/// <pre>
				/// sap.m.MessageBox.alert("This message should appear in the alert", {
				///     title: "Alert",                                      // default
				///     onClose: null,                                       // default
				///     styleClass: ""                                       // default
				///     initialFocus: null                                   // default
				///     textDirection: sap.ui.core.TextDirection.Inherit     // default
				/// });
				/// </pre>
				/// 
				/// If a callback is given, it is called after the alert dialog has been closed by the user via the OK button. The callback is called with the following signature:
				/// 
				/// <pre>
				///   function (oAction)
				/// </pre>
				/// 
				/// where <code>oAction</code> can be either sap.m.MessageBox.Action.OK when the alert dialog is closed by tapping on the OK button or null when the alert dialog is closed by calling <code>sap.m.InstanceManager.closeAllDialogs()</code>.
				/// 
				/// The alert dialog opened by this method is processed asynchronously. Applications have to use <code>fnCallback</code> to continue work after the user closed the alert dialog.
				/// </summary>
				/// <param name="vMessage">Message to be displayed in the alert dialog. The usage of sap.core.Control as vMessage is deprecated since version 1.30.4.</param>
				/// <param name="mOptions">Other options (optional)</param>
				public extern static void alert(string vMessage, sap.m.MessageBox.NotifyOptions mOptions);

				/// <summary>
				/// Displays an alert dialog with the given message and an OK button (no icons).
				/// 
				/// <pre>
				/// sap.m.MessageBox.alert("This message should appear in the alert", {
				///     title: "Alert",                                      // default
				///     onClose: null,                                       // default
				///     styleClass: ""                                       // default
				///     initialFocus: null                                   // default
				///     textDirection: sap.ui.core.TextDirection.Inherit     // default
				/// });
				/// </pre>
				/// 
				/// If a callback is given, it is called after the alert dialog has been closed by the user via the OK button. The callback is called with the following signature:
				/// 
				/// <pre>
				///   function (oAction)
				/// </pre>
				/// 
				/// where <code>oAction</code> can be either sap.m.MessageBox.Action.OK when the alert dialog is closed by tapping on the OK button or null when the alert dialog is closed by calling <code>sap.m.InstanceManager.closeAllDialogs()</code>.
				/// 
				/// The alert dialog opened by this method is processed asynchronously. Applications have to use <code>fnCallback</code> to continue work after the user closed the alert dialog.
				/// </summary>
				/// <param name="vMessage">Message to be displayed in the alert dialog. The usage of sap.core.Control as vMessage is deprecated since version 1.30.4.</param>
				public extern static void alert(string vMessage);

				/// <summary>
				/// Displays a confirmation dialog with the given message, a QUESTION icon, an OK button and a Cancel button. If a callback is given, it is called after the confirmation box has been closed by the user with one of the buttons.
				/// 
				/// <pre>
				/// sap.m.MessageBox.confirm("This message should appear in the confirmation", {
				///     title: "Confirm",                                    // default
				///     onClose: null                                        // default
				///     styleClass: ""                                       // default
				///     initialFocus: null                                   // default
				///     textDirection: sap.ui.core.TextDirection.Inherit     // default
				///     });
				/// </pre>
				/// 
				/// The callback is called with the following signature
				/// 
				/// <pre>
				///   function(oAction)
				/// </pre>
				/// 
				/// where oAction is set by one of the following three values: 1. sap.m.MessageBox.Action.OK: OK (confirmed) button is tapped. 2. sap.m.MessageBox.Action.Cancel: Cancel (unconfirmed) button is tapped. 3. null: Confirm dialog is closed by calling <code>sap.m.InstanceManager.closeAllDialogs()</code>
				/// 
				/// The confirmation dialog opened by this method is processed asynchronously. Applications have to use <code>fnCallback</code> to continue work after the user closed the confirmation dialog
				/// </summary>
				/// <param name="vMessage">Message to be displayed in the alert dialog. The usage of sap.core.Control as vMessage is deprecated since version 1.30.4.</param>
				/// <param name="mOptions">Other options (optional)</param>
				public extern static void confirm(string vMessage, sap.m.MessageBox.NotifyOptions mOptions);

				/// <summary>
				/// Displays a confirmation dialog with the given message, a QUESTION icon, an OK button and a Cancel button. If a callback is given, it is called after the confirmation box has been closed by the user with one of the buttons.
				/// 
				/// <pre>
				/// sap.m.MessageBox.confirm("This message should appear in the confirmation", {
				///     title: "Confirm",                                    // default
				///     onClose: null                                        // default
				///     styleClass: ""                                       // default
				///     initialFocus: null                                   // default
				///     textDirection: sap.ui.core.TextDirection.Inherit     // default
				///     });
				/// </pre>
				/// 
				/// The callback is called with the following signature
				/// 
				/// <pre>
				///   function(oAction)
				/// </pre>
				/// 
				/// where oAction is set by one of the following three values: 1. sap.m.MessageBox.Action.OK: OK (confirmed) button is tapped. 2. sap.m.MessageBox.Action.Cancel: Cancel (unconfirmed) button is tapped. 3. null: Confirm dialog is closed by calling <code>sap.m.InstanceManager.closeAllDialogs()</code>
				/// 
				/// The confirmation dialog opened by this method is processed asynchronously. Applications have to use <code>fnCallback</code> to continue work after the user closed the confirmation dialog
				/// </summary>
				/// <param name="vMessage">Message to be displayed in the alert dialog. The usage of sap.core.Control as vMessage is deprecated since version 1.30.4.</param>
				public extern static void confirm(string vMessage);

				/// <summary>
				/// Displays an error dialog with the given message, an ERROR icon, a CLOSE button.. If a callback is given, it is called after the error box has been closed by the user with one of the buttons.
				/// 
				/// <pre>
				/// sap.m.MessageBox.error("This message should appear in the error message box", {
				///     title: "Error",                                      // default
				///     onClose: null                                        // default
				///     styleClass: ""                                       // default
				///     initialFocus: null                                   // default
				///     textDirection: sap.ui.core.TextDirection.Inherit     // default
				///     });
				/// </pre>
				/// 
				/// The callback is called with the following signature
				/// 
				/// <pre>
				///   function (oAction)
				/// </pre>
				/// 
				/// The error dialog opened by this method is processed asynchronously. Applications have to use <code>fnCallback</code> to continue work after the user closed the error dialog.
				/// </summary>
				/// <param name="vMessage">Message to be displayed in the alert dialog. The usage of sap.core.Control as vMessage is deprecated since version 1.30.4.</param>
				/// <param name="mOptions">Other options (optional)</param>
				public extern static void error(string vMessage, sap.m.MessageBox.NotifyOptions mOptions);

				/// <summary>
				/// Displays an error dialog with the given message, an ERROR icon, a CLOSE button.. If a callback is given, it is called after the error box has been closed by the user with one of the buttons.
				/// 
				/// <pre>
				/// sap.m.MessageBox.error("This message should appear in the error message box", {
				///     title: "Error",                                      // default
				///     onClose: null                                        // default
				///     styleClass: ""                                       // default
				///     initialFocus: null                                   // default
				///     textDirection: sap.ui.core.TextDirection.Inherit     // default
				///     });
				/// </pre>
				/// 
				/// The callback is called with the following signature
				/// 
				/// <pre>
				///   function (oAction)
				/// </pre>
				/// 
				/// The error dialog opened by this method is processed asynchronously. Applications have to use <code>fnCallback</code> to continue work after the user closed the error dialog.
				/// </summary>
				/// <param name="vMessage">Message to be displayed in the alert dialog. The usage of sap.core.Control as vMessage is deprecated since version 1.30.4.</param>
				public extern static void error(string vMessage);

				/// <summary>
				/// Displays an information dialog with the given message, an INFO icon, an OK button. If a callback is given, it is called after the info box has been closed by the user with one of the buttons.
				/// 
				/// <pre>
				/// sap.m.MessageBox.information("This message should appear in the information message box", {
				///     title: "Information",                                // default
				///     onClose: null                                        // default
				///     styleClass: ""                                       // default
				///     initialFocus: null                                   // default
				///     textDirection: sap.ui.core.TextDirection.Inherit     // default
				///     });
				/// </pre>
				/// 
				/// The callback is called with the following signature * <pre>
				///   function (oAction)
				/// </pre>
				/// 
				/// The information dialog opened by this method is processed asynchronously. Applications have to use <code>fnCallback</code> to continue work after the user closed the information dialog
				/// </summary>
				/// <param name="vMessage">Message to be displayed in the alert dialog. The usage of sap.core.Control as vMessage is deprecated since version 1.30.4.</param>
				/// <param name="mOptions">Other options (optional)</param>
				public extern static void information(string vMessage, sap.m.MessageBox.NotifyOptions mOptions);

				/// <summary>
				/// Displays an information dialog with the given message, an INFO icon, an OK button. If a callback is given, it is called after the info box has been closed by the user with one of the buttons.
				/// 
				/// <pre>
				/// sap.m.MessageBox.information("This message should appear in the information message box", {
				///     title: "Information",                                // default
				///     onClose: null                                        // default
				///     styleClass: ""                                       // default
				///     initialFocus: null                                   // default
				///     textDirection: sap.ui.core.TextDirection.Inherit     // default
				///     });
				/// </pre>
				/// 
				/// The callback is called with the following signature * <pre>
				///   function (oAction)
				/// </pre>
				/// 
				/// The information dialog opened by this method is processed asynchronously. Applications have to use <code>fnCallback</code> to continue work after the user closed the information dialog
				/// </summary>
				/// <param name="vMessage">Message to be displayed in the alert dialog. The usage of sap.core.Control as vMessage is deprecated since version 1.30.4.</param>
				public extern static void information(string vMessage);

				/// <summary>
				/// Creates and displays an sap.m.Dialog with type sap.m.DialogType.Message with the given text and buttons, and optionally other parts. After the user has tapped a button, the <code>onClose</code> function is invoked when given.
				/// 
				/// The only mandatory parameter is <code>vMessage</code>. Either a string with the corresponding text or even a layout control could be provided.
				/// 
				/// <pre>
				/// sap.m.MessageBox.show("This message should appear in the message box", {
				///     icon: sap.m.MessageBox.Icon.NONE,                    // default
				///     title: "",                                           // default
				///     actions: sap.m.MessageBox.Action.OK                  // default
				///     onClose: null                                        // default
				///     styleClass: ""                                       // default
				///     initialFocus: null                                   // default
				///     textDirection: sap.ui.core.TextDirection.Inherit     // default
				/// });
				/// </pre>
				/// 
				/// The created dialog is executed asynchronously. When it has been created and registered for rendering, this function returns without waiting for a user reaction.
				/// 
				/// When applications have to react on the users choice, they have to provide a callback function and postpone any reaction on the user choice until that callback is triggered.
				/// 
				/// The signature of the callback is
				/// 
				/// function (oAction);
				/// 
				/// where <code>oAction</code> is the button that the user has tapped. For example, when the user has pressed the close button, an sap.m.MessageBox.Action.Close is returned.
				/// </summary>
				/// <param name="vMessage">Message to be displayed in the alert dialog. The usage of sap.core.Control as vMessage is deprecated since version 1.30.4.</param>
				/// <param name="mOptions">Other options (optional)</param>
				public extern static void show(string vMessage, sap.m.MessageBox.NotifyOptions mOptions);

				/// <summary>
				/// Creates and displays an sap.m.Dialog with type sap.m.DialogType.Message with the given text and buttons, and optionally other parts. After the user has tapped a button, the <code>onClose</code> function is invoked when given.
				/// 
				/// The only mandatory parameter is <code>vMessage</code>. Either a string with the corresponding text or even a layout control could be provided.
				/// 
				/// <pre>
				/// sap.m.MessageBox.show("This message should appear in the message box", {
				///     icon: sap.m.MessageBox.Icon.NONE,                    // default
				///     title: "",                                           // default
				///     actions: sap.m.MessageBox.Action.OK                  // default
				///     onClose: null                                        // default
				///     styleClass: ""                                       // default
				///     initialFocus: null                                   // default
				///     textDirection: sap.ui.core.TextDirection.Inherit     // default
				/// });
				/// </pre>
				/// 
				/// The created dialog is executed asynchronously. When it has been created and registered for rendering, this function returns without waiting for a user reaction.
				/// 
				/// When applications have to react on the users choice, they have to provide a callback function and postpone any reaction on the user choice until that callback is triggered.
				/// 
				/// The signature of the callback is
				/// 
				/// function (oAction);
				/// 
				/// where <code>oAction</code> is the button that the user has tapped. For example, when the user has pressed the close button, an sap.m.MessageBox.Action.Close is returned.
				/// </summary>
				/// <param name="vMessage">Message to be displayed in the alert dialog. The usage of sap.core.Control as vMessage is deprecated since version 1.30.4.</param>
				public extern static void show(string vMessage);

				/// <summary>
				/// Displays a success dialog with the given message, a SUCCESS icon, an OK button. If a callback is given, it is called after the success box has been closed by the user with one of the buttons.
				/// 
				/// <pre>
				/// sap.m.MessageBox.success("This message should appear in the success message box", {
				///     title: "Success",                                    // default
				///     onClose: null                                        // default
				///     styleClass: ""                                       // default
				///     initialFocus: null                                   // default
				///     textDirection: sap.ui.core.TextDirection.Inherit     // default
				///     });
				/// </pre>
				/// 
				/// The callback is called with the following signature
				/// 
				/// <pre>
				///   function(oAction)
				/// </pre>
				/// 
				/// The success dialog opened by this method is processed asynchronously. Applications have to use <code>fnCallback</code> to continue work after the user closed the success dialog
				/// </summary>
				/// <param name="vMessage">Message to be displayed in the alert dialog. The usage of sap.core.Control as vMessage is deprecated since version 1.30.4.</param>
				/// <param name="mOptions">Other options (optional)</param>
				public extern static void success(string vMessage, sap.m.MessageBox.NotifyOptions mOptions);

				/// <summary>
				/// Displays a success dialog with the given message, a SUCCESS icon, an OK button. If a callback is given, it is called after the success box has been closed by the user with one of the buttons.
				/// 
				/// <pre>
				/// sap.m.MessageBox.success("This message should appear in the success message box", {
				///     title: "Success",                                    // default
				///     onClose: null                                        // default
				///     styleClass: ""                                       // default
				///     initialFocus: null                                   // default
				///     textDirection: sap.ui.core.TextDirection.Inherit     // default
				///     });
				/// </pre>
				/// 
				/// The callback is called with the following signature
				/// 
				/// <pre>
				///   function(oAction)
				/// </pre>
				/// 
				/// The success dialog opened by this method is processed asynchronously. Applications have to use <code>fnCallback</code> to continue work after the user closed the success dialog
				/// </summary>
				/// <param name="vMessage">Message to be displayed in the alert dialog. The usage of sap.core.Control as vMessage is deprecated since version 1.30.4.</param>
				public extern static void success(string vMessage);

				/// <summary>
				/// Displays a warning dialog with the given message, a WARNING icon, an OK button. If a callback is given, it is called after the warning box has been closed by the user with one of the buttons.
				/// 
				/// <pre>
				/// sap.m.MessageBox.warning("This message should appear in the warning message box", {
				///     title: "Warning",                                    // default
				///     onClose: null                                        // default
				///     styleClass: ""                                       // default
				///     initialFocus: null                                   // default
				///     textDirection: sap.ui.core.TextDirection.Inherit     // default
				///     });
				/// </pre>
				/// 
				/// The callback is called with the following signature * <pre>
				///   function (oAction)
				/// </pre>
				/// 
				/// The warning dialog opened by this method is processed asynchronously. Applications have to use <code>fnCallback</code> to continue work after the user closed the warning dialog
				/// </summary>
				/// <param name="vMessage">Message to be displayed in the alert dialog. The usage of sap.core.Control as vMessage is deprecated since version 1.30.4.</param>
				/// <param name="mOptions">Other options (optional)</param>
				public extern static void warning(string vMessage, sap.m.MessageBox.NotifyOptions mOptions);

				/// <summary>
				/// Displays a warning dialog with the given message, a WARNING icon, an OK button. If a callback is given, it is called after the warning box has been closed by the user with one of the buttons.
				/// 
				/// <pre>
				/// sap.m.MessageBox.warning("This message should appear in the warning message box", {
				///     title: "Warning",                                    // default
				///     onClose: null                                        // default
				///     styleClass: ""                                       // default
				///     initialFocus: null                                   // default
				///     textDirection: sap.ui.core.TextDirection.Inherit     // default
				///     });
				/// </pre>
				/// 
				/// The callback is called with the following signature * <pre>
				///   function (oAction)
				/// </pre>
				/// 
				/// The warning dialog opened by this method is processed asynchronously. Applications have to use <code>fnCallback</code> to continue work after the user closed the warning dialog
				/// </summary>
				/// <param name="vMessage">Message to be displayed in the alert dialog. The usage of sap.core.Control as vMessage is deprecated since version 1.30.4.</param>
				public extern static void warning(string vMessage);

				#endregion

				/// <summary>
				/// Enumeration of the pre-defined icons that can be used in a MessageBox.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.m.MessageBox.Icon")]
				public enum Icon
				{
					/// <summary>
					/// Shows the error icon in the message box.
					/// </summary>
					ERROR,
					/// <summary>
					/// Shows the information icon in the message box.
					/// </summary>
					INFORMATION,
					/// <summary>
					/// Shows no icon in the message box.
					/// </summary>
					NONE,
					/// <summary>
					/// Shows the question icon in the message box.
					/// </summary>
					QUESTION,
					/// <summary>
					/// Shows the success icon in the message box.
					/// </summary>
					SUCCESS,
					/// <summary>
					/// Shows the warning icon in the message box.
					/// </summary>
					WARNING,
				}
				/// <summary>
				/// Enumeration of supported actions in a MessageBox.
				/// 
				/// Each action is represented as a button in the message box. The values of this enumeration are used for both, specifying the set of allowed actions as well as reporting back the user choice.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.m.MessageBox.Action")]
				public enum Action
				{
					/// <summary>
					/// Adds an "Abort" button to the message box.
					/// </summary>
					ABORT,
					/// <summary>
					/// Adds a "Cancel" button to the message box.
					/// </summary>
					CANCEL,
					/// <summary>
					/// Adds a "Close" button to the message box.
					/// </summary>
					CLOSE,
					/// <summary>
					/// Adds a "Delete" button to the message box.
					/// </summary>
					DELETE,
					/// <summary>
					/// Adds an "Ignore" button to the message box.
					/// </summary>
					IGNORE,
					/// <summary>
					/// Adds a "No" button to the message box.
					/// </summary>
					NO,
					/// <summary>
					/// Adds an "OK" button to the message box.
					/// </summary>
					OK,
					/// <summary>
					/// Adds a "Retry" button to the message box.
					/// </summary>
					RETRY,
					/// <summary>
					/// Adds a "Yes" button to the message box.
					/// </summary>
					YES,
				}
			}
		}
	}
}
