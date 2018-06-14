using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace OpenUI5Sharp
{
	public partial class sap
	{
		public static partial class ui
		{
			public static partial class test
			{
				/// <summary>
				/// UI5 extension of the OPA framework
				/// </summary>
				[External]
				[Namespace(false)]
				public partial class Opa5 : sap.ui.test.Opa
				{
					#region Typed Parameters

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class CreatePageObjectsInfo
					{
						/// <summary>
						/// When a viewName is given, all waitFors inside of the page object will get a viewName parameter. Here is an example: <pre>
						/// 		<code>
						/// 			Opa5.createPageObjects({
						/// 				viewName: "myView",
						/// 				onMyPageWithViewName: {
						/// 					assertions: {
						/// 						iWaitForAButtonInMyView: function () {
						/// 							this.waitFor({
						/// 								id: "myButton",
						/// 								success: function (oButton) {
						/// 									// the button is defined in the view myView
						/// 								}
						/// 							});
						/// 						}
						/// 					}
						/// 				}
						///     </code>
						/// </pre> This saves you repeating the viewName in every waitFor statement of the page object. It is possible to overwrite the viewName of the page object in a specific waitFor. So if you have specified a <code>viewName: "myView"</code> in your page object and you want to look for a control with a global id you may use <code>viewName: ""</code> in a waitFor to overwrite the viewName of the page Object. Example: <pre>
						/// 		<code>
						/// 			this.waitFor({
						/// 				id: "myButton",
						/// 				viewName: "",
						/// 				success: function (oButton) {
						/// 					// now a button with the global id "myButton" will be searched
						/// 				}
						/// 			});
						/// 		</code>
						/// </pre>
						/// </summary>
						public object viewName;

						/// <summary>
						/// Base class for the page object's actions and assertions, default: Opa5
						/// </summary>
						public object baseClass;

						/// <summary>
						/// Namespace prefix for the page object's actions and assertions, default: sap.ui.test.opa.pageObject. Use it if you use page objects from multiple projects in the same test build.
						/// </summary>
						public object @namespace;

						/// <summary>
						/// Can be used as an arrangement and action in Opa tests. Only the test knows if an action is used as arrangement or action
						/// </summary>
						public object actions;

						/// <summary>
						/// Can be used as an assertions in Opa tests.
						/// </summary>
						public object assertions;

					}

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class IStartMyUIComponentOptions
					{
						/// <summary>
						/// Will be passed to {@link sap.ui.component component}, please read the respective documentation.
						/// </summary>
						public object componentConfig;

						/// <summary>
						/// Sets the hash {@link sap.ui.core.routing.HashChanger#setHash} to the given value. If this parameter is omitted, the hash will always be reset to the empty hash - "".
						/// </summary>
						public string hash;

						/// <summary>
						/// The timeout for loading the UIComponent in seconds - {@link sap.ui.test.Opa5#waitFor}.
						/// </summary>
						public int timeout;

						/// <summary>
						/// Since 1.53, activates autoWait while the application is starting up. This allows more time for application startup and stabilizes tests for slow-loading applications. This parameter is false by default, regardless of the global autoWait value, to prevent issues in existing tests.
						/// </summary>
						public bool autoWait;

					}

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class WaitForOptions
					{
						/// <summary>
						/// The global ID of a control, or the ID of a control inside a view. If a regex and a viewName is provided, Opa5 will only look for controls in the view with a matching ID.<br/> Example of a waitFor: <pre>
						///     <code>
						///         this.waitFor({
						///             id: /my/,
						///             viewName: "myView"
						///         });
						///     </code>
						/// </pre> The view that is searched in: <pre>
						///     <code>
						///         &lt;core:View xmlns:core="sap.ui.core" xmlns="sap.m"&gt;
						///             &lt;Button id="myButton"&gt;
						///             &lt;/Button&gt;
						///             &lt;Button id="bar"&gt;
						///             &lt;/Button&gt;
						///             &lt;Button id="baz"&gt;
						///             &lt;/Button&gt;
						///             &lt;Image id="myImage"&gt;&lt;/Image&gt;
						///         &lt;/core:View&gt;
						///     </code>
						/// </pre> Will result in matching two controls, the image with the effective ID myView--myImage and the button myView--myButton. Although the IDs of the controls myView--bar and myView--baz contain a my, they will not be matched since only the part you really write in your views will be matched.
						/// </summary>
						public Union<string, es5.RegExp> id;

						/// <summary>
						/// The name of a view. If this is set the id of the control is searched inside of the view. If an id is not be set, all controls of the view will be found.
						/// </summary>
						public string viewName;

						/// <summary>
						/// This string gets appended before the viewName - should probably be set to the {@link sap.ui.test.Opa5.extendConfig}.
						/// </summary>
						public string viewNamespace;

						/// <summary>
						/// A single matcher or an array of matchers {@link sap.ui.test.matchers}. Matchers will be applied to an every control found by the waitFor function. The matchers are a pipeline: the first matcher gets a control as an input parameter, each subsequent matcher gets the same input as the previous one, if the previous output is 'true'. If the previous output is a truthy value, the next matcher will receive this value as an input parameter. If any matcher does not match an input (i.e. returns a falsy value), then the input is filtered out. Check will not be called if the matchers filtered out all controls/values. Check/success will be called with all matching values as an input parameter. Matchers also can be define as an inline-functions.
						/// </summary>
						public Union<object, object[], sap.ui.test.matchers.Matcher> matchers;

						/// <summary>
						/// Selects all control by their type. It is usually combined with a viewName or searchOpenDialogs. If no control is matching the type, an empty array will be returned. Here are some samples: <code> <pre>
						///         this.waitFor({
						///             controlType: "sap.m.Button",
						///             success: function (aButtons) {
						///                 // aButtons is an array of all visible buttons
						///             }
						///         });
						/// 
						///         // control type will also return controls that extend the control type
						///         // this will return an array of visible sap.m.List and sap.m.Table since both extend List base
						///         this.waitFor({
						///             controlType: "sap.m.ListBase",
						///             success: function (aLists) {
						///                 // aLists is an array of all visible Tables and Lists
						///             }
						///         });
						/// 
						///         // control type is often combined with viewName - only controls that are inside of the view
						///         // and have the correct type will be returned
						///         this.waitFor({
						///             viewName: "my.View"
						///             controlType: "sap.m.Input",
						///             success: function (aInputs) {
						///                 // aInputs are all sap.m.Inputs inside of a view called 'my.View'
						///             }
						///         });
						///     </pre> </code>
						/// </summary>
						public string controlType;

						/// <summary>
						/// If set to true, Opa5 will only look in open dialogs. All the other values except control type will be ignored
						/// </summary>
						public bool searchOpenDialogs;

						/// <summary>
						/// If set to false, Opa5 will also look for unrendered and invisible controls.
						/// </summary>
						public bool visible;

						/// <summary>
						/// (seconds) Specifies how long the waitFor function polls before it fails.O means it will wait forever.
						/// </summary>
						public int timeout;

						/// <summary>
						/// @since 1.47 (seconds) Specifies how long the waitFor function polls before it fails in debug mode.O means it will wait forever.
						/// </summary>
						public int debugTimeout;

						/// <summary>
						/// (milliseconds) Specifies how often the waitFor function polls.
						/// </summary>
						public int pollingInterval;

						/// <summary>
						/// Will get invoked in every polling interval. If it returns true, the check is successful and the polling will stop. The first parameter passed into the function is the same value that gets passed to the success function. Returning something other than boolean in check will not change the first parameter of success.
						/// </summary>
						public object check;

						/// <summary>
						/// Will get invoked after the following conditions are met: <ol> <li> One or multiple controls were found using controlType, Id, viewName. If visible is true (it is by default), the controls also need to be rendered. </li> <li> The whole matcher pipeline returned true for at least one control, or there are no matchers </li> <li> The check function returned true, or there is no check function </li> </ol> The first parameter passed into the function is either a single control (when a single string ID was used), or an array of controls (viewName, controlType, multiple ID's, regex ID's) that matched all matchers. Matchers can alter the array or single control to something different. Please read the documentation of waitFor's matcher parameter.
						/// </summary>
						public object success;

						/// <summary>
						/// Invoked when the timeout is reached and the check never returned true.
						/// </summary>
						public object error;

						/// <summary>
						/// Will be displayed as an errorMessage depending on your unit test framework. Currently the only adapter for Opa5 is QUnit. This message is displayed if Opa5 has reached its timeout before QUnit has reached it.
						/// </summary>
						public string errorMessage;

						/// <summary>
						/// Available since 1.34.0. An array of functions or Actions or a mixture of both. An action has an 'executeOn' function that will receive a single control as a parameter. If there are multiple actions defined all of them will be executed (first in first out) on each control of, similar to the matchers. Here is one of the most common usages: <code> function (sButtonId) { // executes a Press on a button with a specific id new Opa5().waitFor({ id: sButtonId, actions: new Press() }); }; </code> But actions will only be executed once and only after the check function returned true. Before actions are executed the {@link sap.ui.test.matchers.Interactable} matcher and the internal autoWait logic will check if the Control is currently able to perform actions if it is not, Opa5 will try again after the 'pollingInterval'. That means actions will only be executed if: <ul> <li> Controls and their parents are visible, enabled and not busy </li> <li> The controls are not hidden behind static elements such as dialogs </li> <li> There is no pending asynchronous work performed by the application </li> </ul> If there are multiple controls in Opa5's result set the action will be executed on all of them. The actions will be invoked directly before success is called. In the documentation of the success parameter there is a list of conditions that have to be fulfilled. They also apply for the actions. There are some predefined actions in the {@link sap.ui.test.actions} namespace. since 1.42 an Action may add other waitFors. The next action or the success handler will not be executed until the waitFor of the action has finished. An example: <code> <pre>
						///     this.waitFor({
						///         id: "myButton",
						///         actions: function (oButton) {
						///            // this action is executed first
						///            this.waitFor({
						///              id: "anotherButton",
						///              actions: function () {
						///                // This is the second function that will be executed
						///                // Opa will also wait until anotherButton is Interactable before executing this function
						///              },
						///              success: function () {
						///                // This is the third function that will be executed
						///              }
						///            })
						///         },
						///         success: function () {
						///             // This is the fourth function that will be executed
						///         }
						///     });
						///     </pre> </code> Executing multiple actions will not wait between actions for a control to become "Interactable" again. If you need waiting between actions you need to split the actions into multiple 'waitFor' statements.
						/// </summary>
						public Union<object, object[], sap.ui.test.actions.Action, sap.ui.test.actions.Action[]> actions;

						/// <summary>
						/// @since 1.42 Only has an effect if set to true. Since 1.53 it can also be a plain object. The waitFor statement will not execute success callbacks as long as there is pending asynchronous work such as for example: open XMLHTTPRequests (requests to a server), scheduled delayed work and promises, unfinished UI navigation. In addition, the control must be {@link sap.ui.test.matchers.Interactable} So when autoWait is enabled, success behaves like an action in terms of waiting. It is recommended to set this value to true for all your waitFor statements using: <code> <pre>
						///     Opa5.extendConfig({
						///         autoWait: true
						///     });
						///     </pre> </code> Why is it recommended: When writing a huge set of tests and executing them frequently you might face tests that are sometimes successful but sometimes they are not. Setting the autoWait to true should stabilize most of those tests. The default "false" could not be changed since it causes existing tests to fail. There are cases where you do not want to wait for controls to be "Interactable": For example when you are testing the Busy indication of your UI during the sending of a request. But these cases are the exception so it is better to explicitly adding autoWait: false to this waitFor. <code> <pre>
						///     this.waitFor({
						///         id: "myButton",
						///         autoWait: false,
						///         success: function (oButton) {
						///              Opa5.assert.ok(oButton.getBusy(), "My Button was busy");
						///         }
						///     });
						///     </pre> </code> This is also the easiest way of migrating existing tests. First extend the config, then see which waitFors will time out and finally disable autoWait in these Tests.
						/// </summary>
						public bool autoWait;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Helps you when writing tests for UI5 applications. Provides convenience to wait and retrieve for UI5 controls without relying on global IDs. Makes it easy to wait until your UI is in the state you need for testing, e.g.: waiting for backend data.
					/// </summary>
					public extern Opa5();

					#endregion

					#region Methods

					/// <summary>
					/// Create a page object configured as arrangement, action and assertion to the Opa.config. Use it to structure your arrangement, action and assertion based on parts of the screen to avoid name clashes and help to structure your tests.
					/// </summary>
					/// <param name="mPageObjects"></param>
					/// <returns>mPageObject The created page object. It will look like this: <pre><code>
					///  {
					///   &lt;your-page-object-name&gt; : {
					///       actions: // an instance of baseClass or Opa5 with all the actions defined above
					///       assertions: // an instance of baseClass or Opa5 with all the assertions defined above
					///   }
					///  }
					/// </code></pre></returns>
					public extern static Map createPageObjects(Map<sap.ui.test.Opa5.CreatePageObjectsInfo> mPageObjects);

					/// <summary>
					/// Waits until all waitFor calls are done See {@link sap.ui.test.Opa.emptyQueue} for the description
					/// </summary>
					/// <returns>If the waiting was successful, the promise will be resolved. If not it will be rejected</returns>
					public extern static jquery.JQueryPromise<object> emptyQueue();

					/// <summary>
					/// Extends and overwrites default values of the {@link sap.ui.test.Opa.config}. Most frequent usecase: <pre>
					///     <code>
					///         // Every waitFor will append this namespace in front of your viewName
					///         Opa5.extendConfig({
					///            viewNamespace: "namespace.of.my.views."
					///         });
					/// 
					///         var oOpa = new Opa5();
					/// 
					///         // Looks for a control with the id "myButton" in a View with the name "namespace.of.my.views.Detail"
					///         oOpa.waitFor({
					///              id: "myButton",
					///              viewName: "Detail"
					///         });
					/// 
					///         // Looks for a control with the id "myList" in a View with the name "namespace.of.my.views.Master"
					///         oOpa.waitFor({
					///              id: "myList",
					///              viewName: "Master"
					///         });
					///     </code>
					/// </pre>
					/// 
					/// Sample usage: <pre>
					///     <code>
					///         var oOpa = new Opa5();
					/// 
					///         // this statement will  will time out after 15 seconds and poll every 400ms.
					///         // those two values come from the defaults of {@link sap.ui.test.Opa.config}.
					///         oOpa.waitFor({
					///         });
					/// 
					///         // All wait for statements added after this will take other defaults
					///         Opa5.extendConfig({
					///             timeout: 10,
					///             pollingInterval: 100
					///         });
					/// 
					///         // this statement will time out after 10 seconds and poll every 100 ms
					///         oOpa.waitFor({
					///         });
					/// 
					///         // this statement will time out after 20 seconds and poll every 100 ms
					///         oOpa.waitFor({
					///             timeout: 20;
					///         });
					///     </code>
					/// </pre>
					/// </summary>
					/// <param name="options">The values to be added to the existing config</param>
					public extern static void extendConfig(object options);

					/// <summary>
					/// Gives access to a singleton object you can save values in. See {@link sap.ui.test.Opa.getContext} for the description
					/// </summary>
					/// <returns>the context object</returns>
					public extern static object getContext();

					/// <summary>
					/// Returns the HashChanger object in the current context. If an IFrame is launched, it will return the IFrame's HashChanger.
					/// </summary>
					/// <returns>The HashChanger instance</returns>
					public extern static sap.ui.core.routing.HashChanger getHashChanger();

					/// <summary>
					/// Returns the jQuery object in the current context. If an IFrame is launched, it will return the IFrame's jQuery object.
					/// </summary>
					/// <returns>The jQuery object</returns>
					public extern static jquery.JQuery<object> getJQuery();

					/// <summary>
					/// Returns the Opa plugin used for retrieving controls. If an IFrame is launched, it will return the IFrame's plugin.
					/// </summary>
					/// <returns>The plugin instance</returns>
					public extern static sap.ui.test.OpaPlugin getPlugin();

					/// <summary>
					/// Return particular test lib config object. This method is intended to be used by test libraries to access their configuration provided by the test in the testLibs section in {@link sap.ui.test.Opa5.extendConfig}
					/// </summary>
					/// <param name="sTestLibName">test library name</param>
					/// <returns>this test library config object or empty object if configuration is not provided</returns>
					public extern static object getTestLibConfig(string sTestLibName);

					/// <summary>
					/// Returns the QUnit utils object in the current context. If an IFrame is launched, it will return the IFrame's QUnit utils.
					/// </summary>
					/// <returns>The QUnit utils</returns>
					public extern static sap.ui.test.qunit getUtils();

					/// <summary>
					/// Returns the window object in the current context. If an IFrame is launched, it will return the IFrame's window.
					/// </summary>
					/// <returns>The window of the IFrame</returns>
					public extern static dom.Window getWindow();

					/// <summary>
					/// Checks if the application has been started using {@link sap.ui.test.Opa5#iStartMyAppInAFrame} or {@link sap.ui.test.Opa5#iStartMyUIComponent}
					/// </summary>
					/// <returns>A boolean indicating whether the application has been started regardless of how it was started</returns>
					public extern virtual bool hasAppStarted();

					/// <summary>
					/// Checks if the application has been started using {@link sap.ui.test.Opa5#iStartMyAppInAFrame}
					/// </summary>
					/// <returns>A boolean indicating whether the application has been started in an iFrame</returns>
					public extern virtual bool hasAppStartedInAFrame();

					/// <summary>
					/// Checks if the application has been started using {@link sap.ui.test.Opa5#iStartMyUIComponent}
					/// </summary>
					/// <returns>A boolean indicating whether the application has been started as a UIComponent</returns>
					public extern virtual bool hasUIComponentStarted();

					/// <summary>
					/// Starts an app in an IFrame. Only works reliably if running on the same server.
					/// </summary>
					/// <param name="sSource">The source of the IFrame</param>
					/// <param name="iTimeout">The timeout for loading the IFrame in seconds - default is 80</param>
					/// <param name="autoWait">Since 1.53, activates autoWait while the application is starting up. This allows more time for application startup and stabilizes tests for slow-loading applications. This parameter is false by default, regardless of the global autoWait value, to prevent issues in existing tests.</param>
					/// <param name="oOptions">Since 1.53, you can provide a startup configuration object as an only parameter. oOptions is expected to have the keys: source, timeout and autoWait.</param>
					/// <returns>A promise that gets resolved on success</returns>
					public extern virtual jquery.JQueryPromise<object> iStartMyAppInAFrame(string sSource, int iTimeout, bool autoWait, object oOptions);

					/// <summary>
					/// Starts an app in an IFrame. Only works reliably if running on the same server.
					/// </summary>
					/// <param name="sSource">The source of the IFrame</param>
					/// <param name="iTimeout">The timeout for loading the IFrame in seconds - default is 80</param>
					/// <param name="autoWait">Since 1.53, activates autoWait while the application is starting up. This allows more time for application startup and stabilizes tests for slow-loading applications. This parameter is false by default, regardless of the global autoWait value, to prevent issues in existing tests.</param>
					/// <returns>A promise that gets resolved on success</returns>
					public extern virtual jquery.JQueryPromise<object> iStartMyAppInAFrame(string sSource, int iTimeout = 80, bool autoWait = false);

					/// <summary>
					/// Starts a UIComponent.
					/// </summary>
					/// <param name="oOptions">An Object that contains the configuration for starting up a UIComponent.</param>
					/// <returns>A promise that gets resolved on success.</returns>
					public extern virtual jquery.JQueryPromise<object> iStartMyUIComponent(sap.ui.test.Opa5.IStartMyUIComponentOptions oOptions);

					/// <summary>
					/// Tears down the started application regardless of how it was started. Removes the IFrame launched by {@link sap.ui.test.Opa5#iStartMyAppInAFrame} or destroys the UIComponent launched by {@link sap.ui.test.Opa5#iStartMyUIComponent}. This function is designed to make the test's teardown independent of the startup. Use {@link sap.ui.test.Opa5#hasAppStarted} to ensure that the application has been started and teardown can be safely performed.
					/// </summary>
					/// <returns>A promise that gets resolved on success. If nothing has been started or an error occurs, the promise is rejected with the options object. A detailed error message containing the stack trace and Opa logs is available in options.errorMessage.</returns>
					public extern virtual jquery.JQueryPromise<object> iTeardownMyApp();

					/// <summary>
					/// Removes the IFrame from the DOM and removes all the references to its objects Use {@link sap.ui.test.Opa5#hasAppStartedInAFrame} to ensure that an IFrame has been started and teardown can be safely performed.
					/// </summary>
					/// <returns>A promise that gets resolved on success. If no IFrame has been created or an error occurs, the promise is rejected with the options object. A detailed error message containing the stack trace and Opa logs is available in options.errorMessage.</returns>
					public extern virtual jquery.JQueryPromise<object> iTeardownMyAppFrame();

					/// <summary>
					/// Destroys the UIComponent and removes the div from the dom like all the references on its objects. Use {@link sap.ui.test.Opa5#hasUIComponentStarted} to ensure that a UIComponent has been started and teardown can be safely performed.
					/// </summary>
					/// <returns>a promise that gets resolved on success. If no UIComponent has been started or an error occurs, the promise is rejected with the options object. A detailed error message containing the stack trace and Opa logs is available in options.errorMessage.</returns>
					public extern virtual jquery.JQueryPromise<object> iTeardownMyUIComponent();

					/// <summary>
					/// Resets Opa.config to its default values. See {@link sap.ui.test.Opa5#waitFor} for the description Default values for OPA5 are: <ul> <li>viewNamespace: empty string</li> <li>arrangements: instance of OPA5</li> <li>actions: instance of OPA5</li> <li>assertions: instance of OPA5</li> <li>visible: true</li> <li>timeout : 15 seconds, 0 for infinite timeout</li> <li>pollingInterval: 400 milliseconds</li> <li>debugTimeout: 0 seconds, infinite timeout by default. This will be used instead of timeout if running in debug mode.</li> <li>autoWait: false - since 1.42</li> <li>appParams: object with URI parameters for the tested app - since 1.48</li> </ul>
					/// </summary>
					public extern static void resetConfig();

					/// <summary>
					/// Clears the queue and stops running tests so that new tests can be run. This means all waitFor statements registered by {@link sap.ui.test.Opa5#waitFor} will not be invoked anymore and the promise returned by {@link sap.ui.test.Opa5.emptyQueue} will be rejected. When its called inside of a check in {@link sap.ui.test.Opa5#waitFor} the success function of this waitFor will not be called.
					/// </summary>
					public extern static void stopQueue();

					/// <summary>
					/// Takes the same parameters as {@link sap.ui.test.Opa#waitFor}. Also allows you to specify additional parameters:
					/// </summary>
					/// <param name="options">An Object containing conditions for waiting and callbacks</param>
					/// <returns>A promise that gets resolved on success. If an error occurs, the promise is rejected with the options object. A detailed error message containing the stack trace and Opa logs is available in options.errorMessage.</returns>
					public extern virtual jquery.JQueryPromise<object> waitFor(sap.ui.test.Opa5.WaitForOptions options);

					#endregion

				}
			}
		}
	}
}
