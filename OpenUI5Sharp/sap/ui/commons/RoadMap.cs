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
				/// RoadMap is used to display step-by-step work flows of a clearly defined work process.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.RoadMap")]
				[Obsolete("Deprecated since 1.38. Instead, use the <code>sap.m.Wizard</code> control.")]
				public partial class RoadMap : sap.ui.core.Control
				{
					#region Settings

					/// <summary>
					/// Settings class to create the object
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class Settings : sap.ui.core.Control.Settings
					{
						/// <summary>
						/// Total number of steps to be displayed at once
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> numberOfVisibleSteps;

						/// <summary>
						/// ID of the first step to be displayed
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> firstVisibleStep;

						/// <summary>
						/// ID of the step which is currently selected
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> selectedStep;

						/// <summary>
						/// Determines the control width in CSS size
						/// </summary>
						public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> width;

						/// <summary>
						/// Steps that are composing the RoadMap
						/// </summary>
						public Union<sap.ui.commons.RoadMapStep[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> steps;

						/// <summary>
						/// Event is fired when the user selects a step.
						/// </summary>
						public sap.ui.commons.RoadMap.StepDelegate stepSelected;

						/// <summary>
						/// Event is fired when a given step is expanded or collapsed by user.
						/// </summary>
						public sap.ui.commons.RoadMap.StepDelegate stepExpanded;

					}

					#endregion

					#region Typed Parameters

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class StepInfo
					{
						/// <summary>
						/// ID of the expanded/collapsed step
						/// </summary>
						public string stepId;

					}

					#endregion

					#region Delegates

					public delegate void StepDelegate(sap.ui.@base.Event<sap.ui.commons.RoadMap.StepInfo> oEvent, object oData);

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new RoadMap.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern RoadMap(string sId, sap.ui.commons.RoadMap.Settings mSettings);

					/// <summary>
					/// Constructor for a new RoadMap.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					public extern RoadMap(string sId);

					/// <summary>
					/// Constructor for a new RoadMap.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern RoadMap();

					/// <summary>
					/// Constructor for a new RoadMap.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern RoadMap(sap.ui.commons.RoadMap.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property numberOfVisibleSteps

					/// <summary>
					/// Gets current value of property {@link #getNumberOfVisibleSteps numberOfVisibleSteps}.
					/// 
					/// Total number of steps to be displayed at once
					/// </summary>
					/// <returns>Value of property <code>numberOfVisibleSteps</code></returns>
					public extern virtual int getNumberOfVisibleSteps();

					/// <summary>
					/// Sets a new value for property {@link #getNumberOfVisibleSteps numberOfVisibleSteps}.
					/// 
					/// Total number of steps to be displayed at once
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="iNumberOfVisibleSteps">New value for property <code>numberOfVisibleSteps</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RoadMap setNumberOfVisibleSteps(int iNumberOfVisibleSteps);

					#endregion

					#region Methods for Property firstVisibleStep

					/// <summary>
					/// Gets current value of property {@link #getFirstVisibleStep firstVisibleStep}.
					/// 
					/// ID of the first step to be displayed
					/// </summary>
					/// <returns>Value of property <code>firstVisibleStep</code></returns>
					public extern virtual string getFirstVisibleStep();

					/// <summary>
					/// Sets a new value for property {@link #getFirstVisibleStep firstVisibleStep}.
					/// 
					/// ID of the first step to be displayed
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sFirstVisibleStep">New value for property <code>firstVisibleStep</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RoadMap setFirstVisibleStep(string sFirstVisibleStep);

					#endregion

					#region Methods for Property selectedStep

					/// <summary>
					/// Gets current value of property {@link #getSelectedStep selectedStep}.
					/// 
					/// ID of the step which is currently selected
					/// </summary>
					/// <returns>Value of property <code>selectedStep</code></returns>
					public extern virtual string getSelectedStep();

					/// <summary>
					/// Sets a new value for property {@link #getSelectedStep selectedStep}.
					/// 
					/// ID of the step which is currently selected
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sSelectedStep">New value for property <code>selectedStep</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RoadMap setSelectedStep(string sSelectedStep);

					#endregion

					#region Methods for Property width

					/// <summary>
					/// Gets current value of property {@link #getWidth width}.
					/// 
					/// Determines the control width in CSS size
					/// 
					/// Default value is <code>100%</code>.
					/// </summary>
					/// <returns>Value of property <code>width</code></returns>
					public extern virtual sap.ui.core.CSSSize getWidth();

					/// <summary>
					/// Sets a new value for property {@link #getWidth width}.
					/// 
					/// Determines the control width in CSS size
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>100%</code>.
					/// </summary>
					/// <param name="sWidth">New value for property <code>width</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RoadMap setWidth(sap.ui.core.CSSSize sWidth);

					#endregion

					#region Methods for Aggregation steps

					/// <summary>
					/// Gets content of aggregation {@link #getSteps steps}.
					/// 
					/// Steps that are composing the RoadMap
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.commons.RoadMapStep[] getSteps();

					/// <summary>
					/// Destroys all the steps in the aggregation {@link #getSteps steps}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RoadMap destroySteps();

					/// <summary>
					/// Inserts a step into the aggregation {@link #getSteps steps}.
					/// </summary>
					/// <param name="oStep">The step to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the step should be inserted at; for a negative value of <code>iIndex</code>, the step is inserted at position 0; for a value greater than the current size of the aggregation, the step is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RoadMap insertStep(sap.ui.commons.RoadMapStep oStep, int iIndex);

					/// <summary>
					/// Adds some step to the aggregation {@link #getSteps steps}.
					/// </summary>
					/// <param name="oStep">The step to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RoadMap addStep(sap.ui.commons.RoadMapStep oStep);

					/// <summary>
					/// Removes a step from the aggregation {@link #getSteps steps}.
					/// </summary>
					/// <param name="vStep">The step to remove or its index or id</param>
					/// <returns>The removed step or <code>null</code></returns>
					public extern virtual sap.ui.commons.RoadMapStep removeStep(Union<int, string, sap.ui.commons.RoadMapStep> vStep);

					/// <summary>
					/// Checks for the provided <code>sap.ui.commons.RoadMapStep</code> in the aggregation {@link #getSteps steps}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oStep">The step whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfStep(sap.ui.commons.RoadMapStep oStep);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getSteps steps}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.commons.RoadMapStep[] removeAllSteps();

					#endregion

					#region Methods for Event stepSelected

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:stepSelected stepSelected} event of this <code>sap.ui.commons.RoadMap</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.RoadMap</code> itself.
					/// 
					/// Event is fired when the user selects a step.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.RoadMap</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RoadMap attachStepSelected(object oData, sap.ui.commons.RoadMap.StepDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:stepSelected stepSelected} event of this <code>sap.ui.commons.RoadMap</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.RoadMap</code> itself.
					/// 
					/// Event is fired when the user selects a step.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RoadMap attachStepSelected(object oData, sap.ui.commons.RoadMap.StepDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:stepSelected stepSelected} event of this <code>sap.ui.commons.RoadMap</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.RoadMap</code> itself.
					/// 
					/// Event is fired when the user selects a step.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RoadMap attachStepSelected(sap.ui.commons.RoadMap.StepDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:stepSelected stepSelected} event of this <code>sap.ui.commons.RoadMap</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.RoadMap</code> itself.
					/// 
					/// Event is fired when the user selects a step.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.RoadMap</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RoadMap attachStepSelected(sap.ui.commons.RoadMap.StepDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:stepSelected stepSelected} event of this <code>sap.ui.commons.RoadMap</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RoadMap detachStepSelected(sap.ui.commons.RoadMap.StepDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:stepSelected stepSelected} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RoadMap fireStepSelected(sap.ui.commons.RoadMap.StepInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:stepSelected stepSelected} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RoadMap fireStepSelected();

					#endregion

					#region Methods for Event stepExpanded

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:stepExpanded stepExpanded} event of this <code>sap.ui.commons.RoadMap</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.RoadMap</code> itself.
					/// 
					/// Event is fired when a given step is expanded or collapsed by user.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.RoadMap</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RoadMap attachStepExpanded(object oData, sap.ui.commons.RoadMap.StepDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:stepExpanded stepExpanded} event of this <code>sap.ui.commons.RoadMap</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.RoadMap</code> itself.
					/// 
					/// Event is fired when a given step is expanded or collapsed by user.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RoadMap attachStepExpanded(object oData, sap.ui.commons.RoadMap.StepDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:stepExpanded stepExpanded} event of this <code>sap.ui.commons.RoadMap</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.RoadMap</code> itself.
					/// 
					/// Event is fired when a given step is expanded or collapsed by user.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RoadMap attachStepExpanded(sap.ui.commons.RoadMap.StepDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:stepExpanded stepExpanded} event of this <code>sap.ui.commons.RoadMap</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.RoadMap</code> itself.
					/// 
					/// Event is fired when a given step is expanded or collapsed by user.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.RoadMap</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RoadMap attachStepExpanded(sap.ui.commons.RoadMap.StepDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:stepExpanded stepExpanded} event of this <code>sap.ui.commons.RoadMap</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RoadMap detachStepExpanded(sap.ui.commons.RoadMap.StepDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:stepExpanded stepExpanded} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RoadMap fireStepExpanded(sap.ui.commons.RoadMap.StepInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:stepExpanded stepExpanded} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RoadMap fireStepExpanded();

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.RoadMap with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.RoadMap with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.RoadMap with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.commons.RoadMap.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					#endregion

					#endregion

				}
			}
		}
	}
}
