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
				/// A Plugin to search UI5 controls.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.test.OpaPlugin")]
				public partial class OpaPlugin : sap.ui.@base.Object
				{
					#region Typed Parameters

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class GetMatchingControlsOptions
					{
						/// <summary>
						/// Controls will only be searched inside of the view. Inside means, if you are giving an ID - the control will be found by using the byId function of the view. If you are specifying other options than the id, the view has to be an ancestor of the control - when you call myControl.getParent, you have to reach the view at some point.
						/// </summary>
						public string viewName;

						/// <summary>
						/// The ID if one or multiple controls. This can be a global ID or an ID used together with viewName. See the documentation of this parameter.
						/// </summary>
						public Union<string, string[]> id;

						/// <summary>
						/// States if a control need to have a visible domref (jQUery's :visible will be used to determine this).
						/// </summary>
						public bool visible;

						/// <summary>
						/// @since 1.34 States if a control has to match the interactable matcher {@link sap.ui.test.matchers.Interactable}.
						/// </summary>
						public bool interactable;

						/// <summary>
						/// Only controls in the static UI area of UI5 are searched.
						/// </summary>
						public bool searchOpenDialogs;

						/// <summary>
						/// @since 1.40 Selects all control by their type. It is usually combined with viewName or searchOpenDialogs. If no control is matching the type, an empty array will be returned. Here are some samples: <code> <pre>
						///         // will return an array of all visible buttons
						///         new OpaPlugin().getMatchingControls({
						///             controlType: "sap.m.Button"
						///         });
						/// 
						///         // control type will also return controls that extend the control type
						///         // this will return an array of visible sap.m.List and sap.m.Table since both extend List base
						///         new OpaPlugin().getMatchingControls({
						///             controlType: "sap.m.ListBase"
						///         });
						/// 
						///         // control type is often combined with viewName - only controls that are inside of the view
						///         // and have the correct type will be returned
						///         // here all sap.m.Inputs inside of a view called 'my.View' will be returned
						///         new OpaPlugin().getMatchingControls({
						///             viewName: "my.View"
						///             controlType: "sap.m.Input"
						///         });
						///     </pre> </code>
						/// </summary>
						public Union<string, object> controlType;

					}

					#endregion

					#region Constructor

					public extern OpaPlugin();

					#endregion

					#region Methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.test.OpaPlugin with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.test.OpaPlugin with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.test.OpaPlugin with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Gets all the controls of a certain type that are currently instantiated. If the control type is omitted, nothing is returned.
					/// </summary>
					/// <param name="fnConstructorType">the control type, e.g: sap.m.CheckBox</param>
					/// <param name="sControlType">optional control type name, e.g: "sap.m.CheckBox"</param>
					/// <returns>an array of the found controls (can be empty)</returns>
					public extern virtual object[] getAllControls(object fnConstructorType, string sControlType);

					/// <summary>
					/// Gets all the controls of a certain type that are currently instantiated. If the control type is omitted, nothing is returned.
					/// </summary>
					/// <param name="fnConstructorType">the control type, e.g: sap.m.CheckBox</param>
					/// <returns>an array of the found controls (can be empty)</returns>
					public extern virtual object[] getAllControls(object fnConstructorType);

					/// <summary>
					/// Gets all the controls of a certain type that are currently instantiated. If the control type is omitted, nothing is returned.
					/// </summary>
					/// <returns>an array of the found controls (can be empty)</returns>
					public extern virtual object[] getAllControls();

					/// <summary>
					/// Gets all the controls of a certain type that are currently instantiated. If the control type is omitted, nothing is returned.
					/// </summary>
					/// <param name="sControlType">optional control type name, e.g: "sap.m.CheckBox"</param>
					/// <returns>an array of the found controls (can be empty)</returns>
					public extern virtual object[] getAllControls(string sControlType);

					/// <summary>
					/// Returns a control by its ID. Accepts an object with properties id and controlType. The id property can be string, regex or array of strings and is recommended to exist. The controlType property is optional and will ensure the returned control is of a certain type. <ul> <li>a single string - function will return the control instance or null</li> <li>an array of strings - function will return an array of found controls or an empty array</li> <li>a regexp - function will return an array of found controls or an empty array</li> </ul>
					/// </summary>
					/// <param name="oOptions">should contain an ID property which can be of the type string, regex or array of strings. Can contain optional controlType property.</param>
					/// <returns>all controls matched by the regex or the control matched by the string or null</returns>
					public extern virtual sap.ui.core.Element[] getControlByGlobalId(object oOptions);

					/// <summary>
					/// Gets the constructor function of a certain controlType
					/// </summary>
					/// <param name="sControlType">the name of the type eg: "sap.m.Button"</param>
					/// <returns>When the type is loaded, the contstructor is returned, if it is a lazy stub or not yet loaded, null will be returned and there will be a log entry.</returns>
					public extern virtual object getControlConstructor(string sControlType);

					/// <summary>
					/// Gets a control inside of the view (same as calling oView.byId) If no ID is provided, it will return all the controls inside of a view (also nested views and their children).<br/> eg : { id : "foo" } will search globally for a control with the ID foo<br/> eg : { id : "foo" , viewName : "bar" } will search for a control with the ID foo inside the view with the name bar<br/> eg : { viewName : "bar" } will return all the controls inside the view with the name bar<br/> eg : { viewName : "bar", controlType : sap.m.Button } will return all the Buttons inside a view with the name bar<br/> eg : { viewName : "bar", viewNamespace : "baz." } will return all the Controls in the view with the name baz.bar<br/>
					/// </summary>
					/// <param name="oOptions">that may contain a viewName, id, viewNamespace and controlType properties.</param>
					/// <returns>If the passed id is a string it returns the found control or null. Else an array of matching controls, if the view is not found or no control is found for multiple ids an empty array is returned.</returns>
					public extern virtual Union<sap.ui.core.Element, sap.ui.core.Element[]> getControlInView(object oOptions);

					/// <summary>
					/// Tries to find a control depending on the options provided.
					/// </summary>
					/// <param name="oOptions">a map of options used to describe the control you are looking for.</param>
					/// <returns><ul> <li>an array of found Controls depending on the options</li> <li>an empty array if no id was given</li> <li>the found control/element when an id as a string is specified</li> <li>null if an id as string was specified</li> </ul></returns>
					public extern virtual Union<sap.ui.core.Element, sap.ui.core.Element[]> getMatchingControls(sap.ui.test.OpaPlugin.GetMatchingControlsOptions oOptions);

					/// <summary>
					/// Tries to find a control depending on the options provided.
					/// </summary>
					/// <returns><ul> <li>an array of found Controls depending on the options</li> <li>an empty array if no id was given</li> <li>the found control/element when an id as a string is specified</li> <li>null if an id as string was specified</li> </ul></returns>
					public extern virtual Union<sap.ui.core.Element, sap.ui.core.Element[]> getMatchingControls();

					/// <summary>
					/// Returns a metadata object for class sap.ui.test.OpaPlugin.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					/// <summary>
					/// Returns the view with a specific name - if there are multiple views with that name only the first one is returned.
					/// </summary>
					/// <param name="sViewName">the name of the view</param>
					/// <returns>or undefined</returns>
					public extern virtual sap.ui.core.mvc.View getView(string sViewName);

					#endregion

				}
			}
		}
	}
}
