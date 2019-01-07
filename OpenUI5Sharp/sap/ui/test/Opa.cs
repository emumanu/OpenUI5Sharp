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
			public static partial class test
			{
				/// <summary>
				/// One Page Acceptance testing.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.test.Opa")]
				public partial class Opa : sap.ui.@base.Object
				{
					#region Typed Parameters

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class WaitForOptions
					{
						/// <summary>
						/// default: 15 - (seconds) Specifies how long the waitFor function polls before it fails.O means it will wait forever.
						/// </summary>
						public int timeout;

						/// <summary>
						/// @since 1.47 default: 0 - (seconds) Specifies how long the waitFor function polls before it fails in debug mode.O means it will wait forever.
						/// </summary>
						public int debugTimeout;

						/// <summary>
						/// default: 400 - (milliseconds) Specifies how often the waitFor function polls.
						/// </summary>
						public int pollingInterval;

						/// <summary>
						/// @since 1.55 default: false Enable asynchronous polling after success() call. This allows more stable autoWaiter synchronization with event flows originating from within success(). Especially usefull to stabilize synchronization with overflow toolbars.
						/// </summary>
						public bool asyncPolling;

						/// <summary>
						/// Will get invoked in every polling interval. If it returns true, the check is successful and the polling will stop. The first parameter passed into the function is the same value that gets passed to the success function. Returning something other than boolean in the check will not change the first parameter of success.
						/// </summary>
						public object check;

						/// <summary>
						/// Will get invoked after the check function returns true. If there is no check function defined, it will be directly invoked. waitFor statements added in the success handler will be executed before previously added waitFor statements.
						/// </summary>
						public object success;

						/// <summary>
						/// Will be displayed as an errorMessage depending on your unit test framework. Currently the only adapter for Opa is QUnit. This message is displayed there if Opa has reached its timeout but QUnit has not yet reached it.
						/// </summary>
						public string errorMessage;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// This class will help you write acceptance tests in one page or single page applications. You can wait for certain conditions to be met.
					/// </summary>
					/// <param name="extensionObject">An object containing properties and functions. The newly created Opa will be extended by these properties and functions using jQuery.extend.</param>
					public extern Opa(object extensionObject);

					/// <summary>
					/// This class will help you write acceptance tests in one page or single page applications. You can wait for certain conditions to be met.
					/// </summary>
					public extern Opa();

					#endregion

					#region Fields

					/// <summary>
					/// The global configuration of Opa. All of the global values can be overwritten in an individual <code>waitFor</code> call. The default values are: <ul> <li>arrangements: A new Opa instance</li> <li>actions: A new Opa instance</li> <li>assertions: A new Opa instance</li> <li>timeout : 15 seconds, 0 for infinite timeout</li> <li>pollingInterval: 400 milliseconds</li> <li>debugTimeout: 0 seconds, infinite timeout by default. This will be used instead of timeout if running in debug mode.</li> <li>asyncPolling: false</li> </ul> You can either directly manipulate the config, or extend it using {@link sap.ui.test.Opa.extendConfig}.
					/// </summary>
					public static object config;

					#endregion

					#region Methods

					/// <summary>
					/// Calls the static emptyQueue function in the Opa namespace {@link sap.ui.test.Opa.emptyQueue}
					/// </summary>
					public extern virtual void emptyQueue();

					/// <summary>
					/// Calls the static extendConfig function in the Opa namespace {@link sap.ui.test.Opa.extendConfig}
					/// </summary>
					/// <param name="options">The values to be added to the existing config</param>
					public extern virtual void extendConfig(object options);

					/// <summary>
					/// Gives access to a singleton object you can save values in. This object will only be created once and it will never be destroyed. That means you can use it to save values you need in multiple separated tests.
					/// </summary>
					/// <returns>the context object</returns>
					public extern virtual object getContext();

					/// <summary>
					/// Reset Opa.config to its default values. All of the global values can be overwritten in an individual waitFor call.
					/// 
					/// The default values are: <ul> <li>arrangements: A new Opa instance</li> <li>actions: A new Opa instance</li> <li>assertions: A new Opa instance</li> <li>timeout : 15 seconds, 0 for infinite timeout</li> <li>pollingInterval: 400 milliseconds</li> <li>debugTimeout: 0 seconds, infinite timeout by default. This will be used instead of timeout if running in debug mode.</li> <li> executionDelay: 0 or 50 (depending on the browser). The value is a number representing milliseconds. The executionDelay will slow down the execution of every single waitFor statement to be delayed by the number of milliseconds. This does not effect the polling interval it just adds an initial pause. Use this parameter to slow down OPA when you want to watch your test during development or checking the UI of your app. It is not recommended to use this parameter in any automated test executions. </li> <li>asyncPolling: false</li> </ul>
					/// </summary>
					public extern static void resetConfig();

					/// <summary>
					/// Clears the queue and stops running tests so that new tests can be run. This means all waitFor statements registered by {@link sap.ui.test.Opa#waitFor} will not be invoked anymore and the promise returned by {@link sap.ui.test.Opa.emptyQueue} will be rejected When it is called inside of a check in {@link sap.ui.test.Opa#waitFor} the success function of this waitFor will not be called.
					/// </summary>
					public extern static void stopQueue();

					/// <summary>
					/// Queues up a waitFor command for Opa. The Queue will not be emptied until {@link sap.ui.test.Opa.emptyQueue} is called. If you are using {@link sap.ui.test.opaQunit}, emptyQueue will be called by the wrapped tests.
					/// 
					/// If you are using Opa5, waitFor takes additional parameters. They can be found here: {@link sap.ui.test.Opa5#waitFor}. Waits for a check condition to return true, in which case a success function will be called. If the timeout is reached before the check returns true, an error function will be called.
					/// </summary>
					/// <param name="options">These contain check, success and error functions</param>
					/// <returns>A promise that gets resolved on success. If an error occurs, the promise is rejected with the options object. A detailed error message containing the stack trace and Opa logs is available in options.errorMessage.</returns>
					public extern virtual es5.Promise<object> waitFor(sap.ui.test.Opa.WaitForOptions options);

					#endregion

				}
			}
		}
	}
}
