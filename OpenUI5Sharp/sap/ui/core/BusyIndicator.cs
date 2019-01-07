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
				/// Provides methods to show or hide a waiting animation covering the whole page and blocking user interaction.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.core.BusyIndicator")]
				public static partial class BusyIndicator
				{
					#region Typed Parameters

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class Info
					{
						/// <summary>
						/// is the jQuery object of the BusyIndicator
						/// </summary>
						[Name("$Busy")]
						public jquery.JQuery<Retyped.dom.HTMLElement> dollarBusy;

					}

					#endregion

					#region Delegates

					public delegate void Delegate(sap.ui.@base.Event<sap.ui.core.BusyIndicator.Info> oEvent, object oData);

					#endregion

					#region Methods

					/// <summary>
					/// Registers a handler for the "close" event
					/// </summary>
					/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
					/// <param name="oListener">Object on which to call the given function.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern static object attachClose(object fnFunction, object oListener);

					/// <summary>
					/// Registers a handler for the "close" event
					/// </summary>
					/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern static object attachClose(object fnFunction);

					/// <summary>
					/// Registers a handler for the "open" event.
					/// </summary>
					/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
					/// <param name="oListener">Object on which to call the given function.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern static object attachOpen(object fnFunction, object oListener);

					/// <summary>
					/// Registers a handler for the "open" event.
					/// </summary>
					/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern static object attachOpen(object fnFunction);

					/// <summary>
					/// Unregisters a handler for the "close" event
					/// </summary>
					/// <param name="fnFunction">The callback function to unregister</param>
					/// <param name="oListener">Object on which the given function had to be called.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern static object detachClose(object fnFunction, object oListener);

					/// <summary>
					/// Unregisters a handler for the "open" event
					/// </summary>
					/// <param name="fnFunction">The callback function to unregister</param>
					/// <param name="oListener">Object on which the given function had to be called.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern static object detachOpen(object fnFunction, object oListener);

					/// <summary>
					/// Removes the BusyIndicator from the screen
					/// </summary>
					public extern static void hide();

					/// <summary>
					/// Displays the BusyIndicator and starts blocking all user input. This only happens after some delay and if after that delay the BusyIndicator.hide() has not yet been called in the meantime. There is a certain default value for the delay, but that one can be overridden.
					/// </summary>
					/// <param name="iDelay">The delay in milliseconds before opening the BusyIndicator. It is not opened if hide() is called before end of the delay. If no delay (or no valid delay) is given, the default value is used.</param>
					public extern static void show(int iDelay);

					/// <summary>
					/// Displays the BusyIndicator and starts blocking all user input. This only happens after some delay and if after that delay the BusyIndicator.hide() has not yet been called in the meantime. There is a certain default value for the delay, but that one can be overridden.
					/// </summary>
					public extern static void show();

					#endregion

				}
			}
		}
	}
}
