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
				/// Provides methods to create standard alerts, confirmation dialogs, or arbitrary message boxes.
				/// 
				/// As <code>MessageBox</code> is a static class, a <code>jQuery.sap.require("sap.ui.commons.MessageBox");</code> statement must be explicitly executed before the class can be used. Example: <pre>
				///   jQuery.sap.require("sap.ui.commons.MessageBox");
				///   sap.ui.commons.MessageBox.show(
				///       "This message should appear in the message box.",
				///       sap.ui.commons.MessageBox.Icon.INFORMATION,
				///       "My message box title",
				///       [sap.ui.commons.MessageBox.Action.YES, sap.ui.commons.MessageBox.Action.NO],
				///       function() { / * do something * / }
				///   );
				/// </pre>
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.MessageBox")]
				[Obsolete("Deprecated since 1.38. Instead, use the <code>sap.m.MessageBox</code> control.")]
				public static partial class MessageBox
				{
					#region Methods

					/// <summary>
					/// Displays an alert box with the given message and an OK button (no icons). If a callback is given, it is called after the alert box has been closed by the user via the OK button or via the Close icon. The callback is called with the following signature:
					/// 
					/// <pre>
					///   function ()
					/// </pre>
					/// 
					/// The alert box opened by this method is modal and it is processed asynchronously. Applications have to use the <code>fnCallback</code> to continue work after the user closed the alert box.
					/// </summary>
					/// <param name="vMessage">Message to be displayed in the alert box</param>
					/// <param name="fnCallback">callback function to be called when the user closed the dialog</param>
					/// <param name="sTitle">Title to be displayed in the alert box</param>
					/// <param name="sDialogId">ID to be used for the alert box. Intended for test scenarios, not recommended for productive apps</param>
					public extern static void alert(Union<string, sap.ui.core.Control> vMessage, object fnCallback, string sTitle, string sDialogId);

					/// <summary>
					/// Displays an alert box with the given message and an OK button (no icons). If a callback is given, it is called after the alert box has been closed by the user via the OK button or via the Close icon. The callback is called with the following signature:
					/// 
					/// <pre>
					///   function ()
					/// </pre>
					/// 
					/// The alert box opened by this method is modal and it is processed asynchronously. Applications have to use the <code>fnCallback</code> to continue work after the user closed the alert box.
					/// </summary>
					/// <param name="vMessage">Message to be displayed in the alert box</param>
					/// <param name="fnCallback">callback function to be called when the user closed the dialog</param>
					/// <param name="sTitle">Title to be displayed in the alert box</param>
					public extern static void alert(Union<string, sap.ui.core.Control> vMessage, object fnCallback, string sTitle);

					/// <summary>
					/// Displays an alert box with the given message and an OK button (no icons). If a callback is given, it is called after the alert box has been closed by the user via the OK button or via the Close icon. The callback is called with the following signature:
					/// 
					/// <pre>
					///   function ()
					/// </pre>
					/// 
					/// The alert box opened by this method is modal and it is processed asynchronously. Applications have to use the <code>fnCallback</code> to continue work after the user closed the alert box.
					/// </summary>
					/// <param name="vMessage">Message to be displayed in the alert box</param>
					/// <param name="fnCallback">callback function to be called when the user closed the dialog</param>
					public extern static void alert(Union<string, sap.ui.core.Control> vMessage, object fnCallback);

					/// <summary>
					/// Displays an alert box with the given message and an OK button (no icons). If a callback is given, it is called after the alert box has been closed by the user via the OK button or via the Close icon. The callback is called with the following signature:
					/// 
					/// <pre>
					///   function ()
					/// </pre>
					/// 
					/// The alert box opened by this method is modal and it is processed asynchronously. Applications have to use the <code>fnCallback</code> to continue work after the user closed the alert box.
					/// </summary>
					/// <param name="vMessage">Message to be displayed in the alert box</param>
					public extern static void alert(Union<string, sap.ui.core.Control> vMessage);

					/// <summary>
					/// Displays a confirmation dialog box with the given message, a question icon, an OK button, and a Cancel button. If a callback is given, it is called after the alert box has been closed by the user via one of the buttons or via the close icon. The callback is called with the following signature
					/// 
					/// <pre>
					///   function(bConfirmed)
					/// </pre>
					/// 
					/// where bConfirmed is set to true when the user has activated the OK button.
					/// 
					/// The confirmation dialog box opened by this method is modal and it is processed asynchronously. Applications have to use the <code>fnCallback</code> to continue work after the user closed the alert box.
					/// </summary>
					/// <param name="vMessage">Message to display</param>
					/// <param name="fnCallback">Callback to be called</param>
					/// <param name="sTitle">Title to display</param>
					/// <param name="sDialogId">ID to be used for the confirmation dialog. Intended for test scenarios, not recommended for productive apps</param>
					public extern static void confirm(Union<string, sap.ui.core.Control> vMessage, object fnCallback, string sTitle, string sDialogId);

					/// <summary>
					/// Displays a confirmation dialog box with the given message, a question icon, an OK button, and a Cancel button. If a callback is given, it is called after the alert box has been closed by the user via one of the buttons or via the close icon. The callback is called with the following signature
					/// 
					/// <pre>
					///   function(bConfirmed)
					/// </pre>
					/// 
					/// where bConfirmed is set to true when the user has activated the OK button.
					/// 
					/// The confirmation dialog box opened by this method is modal and it is processed asynchronously. Applications have to use the <code>fnCallback</code> to continue work after the user closed the alert box.
					/// </summary>
					/// <param name="vMessage">Message to display</param>
					/// <param name="fnCallback">Callback to be called</param>
					/// <param name="sTitle">Title to display</param>
					public extern static void confirm(Union<string, sap.ui.core.Control> vMessage, object fnCallback, string sTitle);

					/// <summary>
					/// Displays a confirmation dialog box with the given message, a question icon, an OK button, and a Cancel button. If a callback is given, it is called after the alert box has been closed by the user via one of the buttons or via the close icon. The callback is called with the following signature
					/// 
					/// <pre>
					///   function(bConfirmed)
					/// </pre>
					/// 
					/// where bConfirmed is set to true when the user has activated the OK button.
					/// 
					/// The confirmation dialog box opened by this method is modal and it is processed asynchronously. Applications have to use the <code>fnCallback</code> to continue work after the user closed the alert box.
					/// </summary>
					/// <param name="vMessage">Message to display</param>
					/// <param name="fnCallback">Callback to be called</param>
					public extern static void confirm(Union<string, sap.ui.core.Control> vMessage, object fnCallback);

					/// <summary>
					/// Displays a confirmation dialog box with the given message, a question icon, an OK button, and a Cancel button. If a callback is given, it is called after the alert box has been closed by the user via one of the buttons or via the close icon. The callback is called with the following signature
					/// 
					/// <pre>
					///   function(bConfirmed)
					/// </pre>
					/// 
					/// where bConfirmed is set to true when the user has activated the OK button.
					/// 
					/// The confirmation dialog box opened by this method is modal and it is processed asynchronously. Applications have to use the <code>fnCallback</code> to continue work after the user closed the alert box.
					/// </summary>
					/// <param name="vMessage">Message to display</param>
					public extern static void confirm(Union<string, sap.ui.core.Control> vMessage);

					/// <summary>
					/// Creates and displays a simple message box with the given text and buttons, and optionally other parts. After the user has selected a button or closed the message box using the close icon, the <code>callback</code> function is invoked when given.
					/// 
					/// The only mandatory parameter is <code>vMessage</code>. Either a string with the corresponding text or even a layout control could be provided.
					/// 
					/// The created dialog box is executed asynchronously. When it has been created and registered for rendering, this function returns without waiting for a user reaction.
					/// 
					/// When applications have to react on the users choice, they have to provide a callback function and postpone any reaction on the user choice until that callback is triggered.
					/// 
					/// The signature of the callback is
					/// 
					/// function (oAction);
					/// 
					/// where <code>oAction</code> is the button that the user has pressed. When the user has pressed the close button, a MessageBox.Action.Close is returned.
					/// </summary>
					/// <param name="vMessage">The message to be displayed.</param>
					/// <param name="oIcon">The icon to be displayed.</param>
					/// <param name="sTitle">The title of the message box.</param>
					/// <param name="vActions">Either a single action, or an array of actions. If no action(s) are given, the single action MessageBox.Action.OK is taken as a default for the parameter.</param>
					/// <param name="fnCallback">Function to be called when the user has pressed a button or has closed the message box.</param>
					/// <param name="oDefaultAction">Must be one of the actions provided in vActions.</param>
					/// <param name="sDialogId">ID to be used for the dialog. Intended for test scenarios, not recommended for productive apps</param>
					public extern static void show(Union<string, sap.ui.core.Control> vMessage, sap.ui.commons.MessageBox.Icon oIcon, string sTitle, Union<sap.ui.commons.MessageBox.Action, sap.ui.commons.MessageBox.Action[]> vActions, object fnCallback, sap.ui.commons.MessageBox.Action oDefaultAction, string sDialogId);

					/// <summary>
					/// Creates and displays a simple message box with the given text and buttons, and optionally other parts. After the user has selected a button or closed the message box using the close icon, the <code>callback</code> function is invoked when given.
					/// 
					/// The only mandatory parameter is <code>vMessage</code>. Either a string with the corresponding text or even a layout control could be provided.
					/// 
					/// The created dialog box is executed asynchronously. When it has been created and registered for rendering, this function returns without waiting for a user reaction.
					/// 
					/// When applications have to react on the users choice, they have to provide a callback function and postpone any reaction on the user choice until that callback is triggered.
					/// 
					/// The signature of the callback is
					/// 
					/// function (oAction);
					/// 
					/// where <code>oAction</code> is the button that the user has pressed. When the user has pressed the close button, a MessageBox.Action.Close is returned.
					/// </summary>
					/// <param name="vMessage">The message to be displayed.</param>
					/// <param name="oIcon">The icon to be displayed.</param>
					/// <param name="sTitle">The title of the message box.</param>
					/// <param name="vActions">Either a single action, or an array of actions. If no action(s) are given, the single action MessageBox.Action.OK is taken as a default for the parameter.</param>
					/// <param name="fnCallback">Function to be called when the user has pressed a button or has closed the message box.</param>
					/// <param name="oDefaultAction">Must be one of the actions provided in vActions.</param>
					public extern static void show(Union<string, sap.ui.core.Control> vMessage, sap.ui.commons.MessageBox.Icon oIcon, string sTitle, Union<sap.ui.commons.MessageBox.Action, sap.ui.commons.MessageBox.Action[]> vActions, object fnCallback, sap.ui.commons.MessageBox.Action oDefaultAction);

					/// <summary>
					/// Creates and displays a simple message box with the given text and buttons, and optionally other parts. After the user has selected a button or closed the message box using the close icon, the <code>callback</code> function is invoked when given.
					/// 
					/// The only mandatory parameter is <code>vMessage</code>. Either a string with the corresponding text or even a layout control could be provided.
					/// 
					/// The created dialog box is executed asynchronously. When it has been created and registered for rendering, this function returns without waiting for a user reaction.
					/// 
					/// When applications have to react on the users choice, they have to provide a callback function and postpone any reaction on the user choice until that callback is triggered.
					/// 
					/// The signature of the callback is
					/// 
					/// function (oAction);
					/// 
					/// where <code>oAction</code> is the button that the user has pressed. When the user has pressed the close button, a MessageBox.Action.Close is returned.
					/// </summary>
					/// <param name="vMessage">The message to be displayed.</param>
					/// <param name="oIcon">The icon to be displayed.</param>
					/// <param name="sTitle">The title of the message box.</param>
					/// <param name="vActions">Either a single action, or an array of actions. If no action(s) are given, the single action MessageBox.Action.OK is taken as a default for the parameter.</param>
					/// <param name="fnCallback">Function to be called when the user has pressed a button or has closed the message box.</param>
					public extern static void show(Union<string, sap.ui.core.Control> vMessage, sap.ui.commons.MessageBox.Icon oIcon, string sTitle, Union<sap.ui.commons.MessageBox.Action, sap.ui.commons.MessageBox.Action[]> vActions, object fnCallback);

					/// <summary>
					/// Creates and displays a simple message box with the given text and buttons, and optionally other parts. After the user has selected a button or closed the message box using the close icon, the <code>callback</code> function is invoked when given.
					/// 
					/// The only mandatory parameter is <code>vMessage</code>. Either a string with the corresponding text or even a layout control could be provided.
					/// 
					/// The created dialog box is executed asynchronously. When it has been created and registered for rendering, this function returns without waiting for a user reaction.
					/// 
					/// When applications have to react on the users choice, they have to provide a callback function and postpone any reaction on the user choice until that callback is triggered.
					/// 
					/// The signature of the callback is
					/// 
					/// function (oAction);
					/// 
					/// where <code>oAction</code> is the button that the user has pressed. When the user has pressed the close button, a MessageBox.Action.Close is returned.
					/// </summary>
					/// <param name="vMessage">The message to be displayed.</param>
					/// <param name="oIcon">The icon to be displayed.</param>
					/// <param name="sTitle">The title of the message box.</param>
					/// <param name="vActions">Either a single action, or an array of actions. If no action(s) are given, the single action MessageBox.Action.OK is taken as a default for the parameter.</param>
					public extern static void show(Union<string, sap.ui.core.Control> vMessage, sap.ui.commons.MessageBox.Icon oIcon, string sTitle, Union<sap.ui.commons.MessageBox.Action, sap.ui.commons.MessageBox.Action[]> vActions);

					/// <summary>
					/// Creates and displays a simple message box with the given text and buttons, and optionally other parts. After the user has selected a button or closed the message box using the close icon, the <code>callback</code> function is invoked when given.
					/// 
					/// The only mandatory parameter is <code>vMessage</code>. Either a string with the corresponding text or even a layout control could be provided.
					/// 
					/// The created dialog box is executed asynchronously. When it has been created and registered for rendering, this function returns without waiting for a user reaction.
					/// 
					/// When applications have to react on the users choice, they have to provide a callback function and postpone any reaction on the user choice until that callback is triggered.
					/// 
					/// The signature of the callback is
					/// 
					/// function (oAction);
					/// 
					/// where <code>oAction</code> is the button that the user has pressed. When the user has pressed the close button, a MessageBox.Action.Close is returned.
					/// </summary>
					/// <param name="vMessage">The message to be displayed.</param>
					/// <param name="oIcon">The icon to be displayed.</param>
					/// <param name="sTitle">The title of the message box.</param>
					public extern static void show(Union<string, sap.ui.core.Control> vMessage, sap.ui.commons.MessageBox.Icon oIcon = sap.ui.commons.MessageBox.Icon.NONE, string sTitle = "");

					#endregion

					/// <summary>
					/// Enumeration of the pre-defined icons that can be used in a MessageBox.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.commons.MessageBox.Icon")]
					public enum Icon
					{
						/// <summary>
						/// Shows the critical error icon in the message box.
						/// </summary>
						CRITICAL,
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
					[Name("sap.ui.commons.MessageBox.Action")]
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
						/// Adds an "Ignore" button to the message box.
						/// </summary>
						IGNORE,
						/// <summary>
						/// Adds a "No" button to the message box.
						/// </summary>
						NO,
						/// <summary>
						/// Adds an "Ok" button to the message box.
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
}
