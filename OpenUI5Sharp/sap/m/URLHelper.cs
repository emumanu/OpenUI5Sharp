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
			/// URL (Uniform Resource Locator) Helper.
			/// 
			/// This helper can be used to trigger a native application (e.g. email, sms, phone) from the browser. That means we are restricted of browser or application implementation. e.g. <ul> <li>Some browsers do not let you pass more than 2022 characters in the URL</li> <li>MAPI (Outlook) limit is 2083, max. path under Internet Explorer is 2048</li> <li>Different Internet Explorer versions have a different limitation (IE9 approximately 1000 characters)</li> <li>MS mail app under Windows 8 cuts mail links after approximately 100 characters</li> <li>Safari gets a confirmation from user before opening a native application and can block other triggers if the user cancels it</li> <li>Some mail applications(Outlook) do not respect all encodings (e.g. Cyrillic texts are not encoded correctly)</li> </ul>
			/// 
			/// <b>Note:</b> all the given limitation lengths are for URL encoded text (e.g a space character will be encoded as "%20").
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.URLHelper")]
			public static partial class URLHelper
			{
				#region Methods

				/// <summary>
				/// Adds an event listener for the <code>redirect</code> event.
				/// </summary>
				/// <param name="fnFunction">The function to call, when the event occurs.</param>
				/// <param name="oListener">The object that wants to be notified when the event occurs.</param>
				/// <returns>The URLHelper instance</returns>
				public extern static object attachRedirect(object fnFunction, object oListener);

				/// <summary>
				/// Adds an event listener for the <code>redirect</code> event.
				/// </summary>
				/// <param name="fnFunction">The function to call, when the event occurs.</param>
				/// <returns>The URLHelper instance</returns>
				public extern static object attachRedirect(object fnFunction);

				/// <summary>
				/// Detach an already registered listener of the <code>redirect</code> event.
				/// </summary>
				/// <param name="fnFunction">The function to call, when the event occurs.</param>
				/// <param name="oListener">The object, that wants to be notified, when the event occurs.</param>
				/// <returns>The URLHelper instance</returns>
				public extern static object detachRedirect(object fnFunction, object oListener);

				/// <summary>
				/// Detach an already registered listener of the <code>redirect</code> event.
				/// </summary>
				/// <param name="fnFunction">The function to call, when the event occurs.</param>
				/// <returns>The URLHelper instance</returns>
				public extern static object detachRedirect(object fnFunction);

				/// <summary>
				/// Builds Email URI from given parameter. Trims spaces from email addresses.
				/// </summary>
				/// <param name="sEmail">Destination email address</param>
				/// <param name="sSubject">Subject of the email address</param>
				/// <param name="sBody">Default message text</param>
				/// <param name="sCC">Carbon Copy email address</param>
				/// <param name="sBCC">Blind carbon copy email address</param>
				/// <returns>Email URI using the <code>mailto:</code> scheme</returns>
				public extern static string normalizeEmail(string sEmail, string sSubject, string sBody, string sCC, string sBCC);

				/// <summary>
				/// Builds Email URI from given parameter. Trims spaces from email addresses.
				/// </summary>
				/// <param name="sEmail">Destination email address</param>
				/// <param name="sSubject">Subject of the email address</param>
				/// <param name="sBody">Default message text</param>
				/// <param name="sCC">Carbon Copy email address</param>
				/// <returns>Email URI using the <code>mailto:</code> scheme</returns>
				public extern static string normalizeEmail(string sEmail, string sSubject, string sBody, string sCC);

				/// <summary>
				/// Builds Email URI from given parameter. Trims spaces from email addresses.
				/// </summary>
				/// <param name="sEmail">Destination email address</param>
				/// <param name="sSubject">Subject of the email address</param>
				/// <param name="sBody">Default message text</param>
				/// <returns>Email URI using the <code>mailto:</code> scheme</returns>
				public extern static string normalizeEmail(string sEmail, string sSubject, string sBody);

				/// <summary>
				/// Builds Email URI from given parameter. Trims spaces from email addresses.
				/// </summary>
				/// <param name="sEmail">Destination email address</param>
				/// <param name="sSubject">Subject of the email address</param>
				/// <returns>Email URI using the <code>mailto:</code> scheme</returns>
				public extern static string normalizeEmail(string sEmail, string sSubject);

				/// <summary>
				/// Builds Email URI from given parameter. Trims spaces from email addresses.
				/// </summary>
				/// <param name="sEmail">Destination email address</param>
				/// <returns>Email URI using the <code>mailto:</code> scheme</returns>
				public extern static string normalizeEmail(string sEmail);

				/// <summary>
				/// Builds Email URI from given parameter. Trims spaces from email addresses.
				/// </summary>
				/// <returns>Email URI using the <code>mailto:</code> scheme</returns>
				public extern static string normalizeEmail();

				/// <summary>
				/// Sanitizes the given telephone number and returns a URI using the <code>sms:</code> scheme.
				/// </summary>
				/// <param name="sTel">Telephone number</param>
				/// <returns>SMS URI using the <code>sms:</code> scheme</returns>
				public extern static string normalizeSms(string sTel);

				/// <summary>
				/// Sanitizes the given telephone number and returns a URI using the <code>sms:</code> scheme.
				/// </summary>
				/// <returns>SMS URI using the <code>sms:</code> scheme</returns>
				public extern static string normalizeSms();

				/// <summary>
				/// Sanitizes the given telephone number and returns a URI using the <code>tel:</code> scheme.
				/// </summary>
				/// <param name="sTel">Telephone number</param>
				/// <returns>Telephone URI using the <code>tel:</code> scheme</returns>
				public extern static string normalizeTel(string sTel);

				/// <summary>
				/// Sanitizes the given telephone number and returns a URI using the <code>tel:</code> scheme.
				/// </summary>
				/// <returns>Telephone URI using the <code>tel:</code> scheme</returns>
				public extern static string normalizeTel();

				/// <summary>
				/// Redirects to the given URL.
				/// 
				/// This method fires "redirect" event before opening the URL.
				/// </summary>
				/// <param name="sURL">Uniform resource locator</param>
				/// <param name="bNewWindow">Opens URL in a new browser window or tab. Please note that, opening a new window/tab can be ignored by browsers (e.g. on Windows Phone) or by popup blockers. NOTE: On Windows Phone the URL will be enforced to open in the same window if opening in a new window/tab fails (because of a known system restriction on cross-window communications). Use sap.m.Link instead (with blank target) if you necessarily need to open URL in a new window.</param>
				public extern static void redirect(string sURL, bool bNewWindow);

				/// <summary>
				/// Redirects to the given URL.
				/// 
				/// This method fires "redirect" event before opening the URL.
				/// </summary>
				/// <param name="sURL">Uniform resource locator</param>
				public extern static void redirect(string sURL);

				/// <summary>
				/// Trigger email application to send email. Trims spaces from email addresses.
				/// </summary>
				/// <param name="sEmail">Destination email address</param>
				/// <param name="sSubject">Subject of the email address</param>
				/// <param name="sBody">Default message text</param>
				/// <param name="sCC">Carbon Copy email address</param>
				/// <param name="sBCC">Blind carbon copy email address</param>
				public extern static void triggerEmail(string sEmail, string sSubject, string sBody, string sCC, string sBCC);

				/// <summary>
				/// Trigger email application to send email. Trims spaces from email addresses.
				/// </summary>
				/// <param name="sEmail">Destination email address</param>
				/// <param name="sSubject">Subject of the email address</param>
				/// <param name="sBody">Default message text</param>
				/// <param name="sCC">Carbon Copy email address</param>
				public extern static void triggerEmail(string sEmail, string sSubject, string sBody, string sCC);

				/// <summary>
				/// Trigger email application to send email. Trims spaces from email addresses.
				/// </summary>
				/// <param name="sEmail">Destination email address</param>
				/// <param name="sSubject">Subject of the email address</param>
				/// <param name="sBody">Default message text</param>
				public extern static void triggerEmail(string sEmail, string sSubject, string sBody);

				/// <summary>
				/// Trigger email application to send email. Trims spaces from email addresses.
				/// </summary>
				/// <param name="sEmail">Destination email address</param>
				/// <param name="sSubject">Subject of the email address</param>
				public extern static void triggerEmail(string sEmail, string sSubject);

				/// <summary>
				/// Trigger email application to send email. Trims spaces from email addresses.
				/// </summary>
				/// <param name="sEmail">Destination email address</param>
				public extern static void triggerEmail(string sEmail);

				/// <summary>
				/// Trigger email application to send email. Trims spaces from email addresses.
				/// </summary>
				public extern static void triggerEmail();

				/// <summary>
				/// Trigger SMS application to send SMS to given telephone number.
				/// </summary>
				/// <param name="sTel">Telephone number</param>
				public extern static void triggerSms(string sTel);

				/// <summary>
				/// Trigger SMS application to send SMS to given telephone number.
				/// </summary>
				public extern static void triggerSms();

				/// <summary>
				/// Trigger telephone app to call the given telephone number.
				/// </summary>
				/// <param name="sTel">Telephone number</param>
				public extern static void triggerTel(string sTel);

				/// <summary>
				/// Trigger telephone app to call the given telephone number.
				/// </summary>
				public extern static void triggerTel();

				#endregion

			}
		}
	}
}
