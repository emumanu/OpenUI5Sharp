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
			/// Enables users to accomplish a single goal which consists of multiple dependable sub-tasks. <h3>Overview</h3> The sap.m.Wizard helps users complete a complex and unfamiliar task by dividing it into sections and guiding the user through it. The wizard has two main areas - a navigation area at the top showing the step sequence and a content area below it. <h3>Structure</h3> <h4>Navigation Area</h4> The top most area of the wizard is occupied by the navigation area. It shows the sequence of {@link sap.m.WizardStep wizard steps}. <ul> <li>The minimum number of steps is 3 and the maximum is 8 and are stored in the <code>steps</code> aggregation.</li> <li>Steps can be branching depending on choices the user made in their input - this is set by the <code>enableBranching</code> property. </li> <li>Steps can have different visual representations - numbers or icons. You can add labels for better readability </li> </ul> <h4>Content</h4> The content occupies the main part of the page. It can hold any type of input controls. The content is kept in {@link sap.m.WizardStep wizard steps}. <h4>Next Step Button</h4> The next step button is displayed below the content. It can be hidden by setting <code>showNextButton</code> to <code>false</code> and displayed, for example, only after the user has filled all mandatory fields. <h3>Usage</h3> <h4>When to use:</h4> When the user has to accomplish a long or unfamiliar task. <h4>When not to use:</h4> When the user has to accomplish a routine task that is clear and familiar. When the task has only two steps or less. <h3>Responsive Behavior</h3> On mobile devices the steps in the StepNavigator are grouped together and overlap. Tapping on them will show a popover to select the step to navigate to.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.Wizard")]
			public partial class Wizard : sap.ui.core.Control
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
					/// Determines the width of the Wizard.
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> width;

					/// <summary>
					/// Determines the height of the Wizard.
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> height;

					/// <summary>
					/// Controls the visibility of the next button. The developers can choose to control the flow of the steps either through the API (with <code>nextStep</code> and <code>previousStep</code> methods) or let the user click the next button, and control it with <code>validateStep</code> or <code>invalidateStep</code> methods.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showNextButton;

					/// <summary>
					/// Changes the text of the finish button for the last step. This property can be used only if <code>showNextButton</code> is set to true. By default the text of the button is "Review".
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> finishButtonText;

					/// <summary>
					/// Enables the branching functionality of the Wizard. Branching gives the developer the ability to define multiple routes a user is able to take based on the input in the current step. It is up to the developer to programatically check for what is the input in the current step and set a concrete next step amongs the available subsequent steps. Note: If this property is set to false, <code>next</code> and <code>subSequentSteps</code> associations of the WizardStep control are ignored.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> enableBranching;

					/// <summary>
					/// The wizard steps to be included in the content of the control.
					/// </summary>
					public Union<sap.m.WizardStep[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> steps;

					/// <summary>
					/// This association controls the current activated step of the wizard (meaning the last step) For example if we have A->B->C->D steps, we are on step A and we setCurrentStep(C) A,B and C are going to be activated. D will still remain unvisited. The parameter needs to be a Wizard step that is part of the current Wizard
					/// </summary>
					public Union<sap.m.WizardStep, sap.ui.core.ID, string, sap.ui.@base.ManagedObject.BindPropertyInfo> currentStep;

					/// <summary>
					/// The StepActivated event is fired every time a new step is activated.
					/// </summary>
					public sap.m.IndexDelegate stepActivate;

					/// <summary>
					/// The complete event is fired when the user clicks the finish button of the Wizard. The finish button is only available on the last step of the Wizard.
					/// </summary>
					public sap.ui.@base.EventDelegate complete;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new Wizard.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern Wizard(string sId, sap.m.Wizard.Settings mSettings);

				/// <summary>
				/// Constructor for a new Wizard.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern Wizard(string sId);

				/// <summary>
				/// Constructor for a new Wizard.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern Wizard();

				/// <summary>
				/// Constructor for a new Wizard.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern Wizard(sap.m.Wizard.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property width

				/// <summary>
				/// Gets current value of property {@link #getWidth width}.
				/// 
				/// Determines the width of the Wizard.
				/// 
				/// Default value is <code>auto</code>.
				/// </summary>
				/// <returns>Value of property <code>width</code></returns>
				public extern virtual sap.ui.core.CSSSize getWidth();

				/// <summary>
				/// Sets a new value for property {@link #getWidth width}.
				/// 
				/// Determines the width of the Wizard.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>auto</code>.
				/// </summary>
				/// <param name="sWidth">New value for property <code>width</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Wizard setWidth(sap.ui.core.CSSSize sWidth);

				#endregion

				#region Methods for Property height

				/// <summary>
				/// Gets current value of property {@link #getHeight height}.
				/// 
				/// Determines the height of the Wizard.
				/// 
				/// Default value is <code>100%</code>.
				/// </summary>
				/// <returns>Value of property <code>height</code></returns>
				public extern virtual sap.ui.core.CSSSize getHeight();

				/// <summary>
				/// Sets a new value for property {@link #getHeight height}.
				/// 
				/// Determines the height of the Wizard.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>100%</code>.
				/// </summary>
				/// <param name="sHeight">New value for property <code>height</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Wizard setHeight(sap.ui.core.CSSSize sHeight);

				#endregion

				#region Methods for Property showNextButton

				/// <summary>
				/// Gets current value of property {@link #getShowNextButton showNextButton}.
				/// 
				/// Controls the visibility of the next button. The developers can choose to control the flow of the steps either through the API (with <code>nextStep</code> and <code>previousStep</code> methods) or let the user click the next button, and control it with <code>validateStep</code> or <code>invalidateStep</code> methods.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>showNextButton</code></returns>
				public extern virtual bool getShowNextButton();

				/// <summary>
				/// Sets the visiblity of the next button.
				/// </summary>
				/// <param name="value">True to show the button or false to hide it.</param>
				/// <returns>Reference to the control instance for chaining.</returns>
				public extern virtual sap.m.Wizard setShowNextButton(bool value);

				#endregion

				#region Methods for Property finishButtonText

				/// <summary>
				/// Returns the finish button text which will be rendered.
				/// </summary>
				/// <returns>The text which will be rendered in the finish button.</returns>
				public extern virtual string getFinishButtonText();

				/// <summary>
				/// Sets the text for the finish button. By default it is "Review".
				/// </summary>
				/// <param name="value">The text of the finish button.</param>
				/// <returns>Reference to the control instance for chaining.</returns>
				public extern virtual sap.m.Wizard setFinishButtonText(string value);

				#endregion

				#region Methods for Property enableBranching

				/// <summary>
				/// Gets current value of property {@link #getEnableBranching enableBranching}.
				/// 
				/// Enables the branching functionality of the Wizard. Branching gives the developer the ability to define multiple routes a user is able to take based on the input in the current step. It is up to the developer to programatically check for what is the input in the current step and set a concrete next step amongs the available subsequent steps. Note: If this property is set to false, <code>next</code> and <code>subSequentSteps</code> associations of the WizardStep control are ignored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>enableBranching</code></returns>
				public extern virtual bool getEnableBranching();

				/// <summary>
				/// Sets a new value for property {@link #getEnableBranching enableBranching}.
				/// 
				/// Enables the branching functionality of the Wizard. Branching gives the developer the ability to define multiple routes a user is able to take based on the input in the current step. It is up to the developer to programatically check for what is the input in the current step and set a concrete next step amongs the available subsequent steps. Note: If this property is set to false, <code>next</code> and <code>subSequentSteps</code> associations of the WizardStep control are ignored.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bEnableBranching">New value for property <code>enableBranching</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Wizard setEnableBranching(bool bEnableBranching);

				#endregion

				#region Methods for Aggregation steps

				/// <summary>
				/// Gets content of aggregation {@link #getSteps steps}.
				/// 
				/// The wizard steps to be included in the content of the control.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.WizardStep[] getSteps();

				/// <summary>
				/// Destroys all aggregated steps in the Wizard.
				/// </summary>
				/// <returns>Pointer to the control instance for chaining.</returns>
				public extern virtual sap.m.Wizard destroySteps();

				/// <summary>
				/// Adds a new step to the Wizard.
				/// </summary>
				/// <param name="wizardStep">New WizardStep to add to the Wizard</param>
				/// <returns>Pointer to the control instance for chaining</returns>
				public extern virtual sap.m.Wizard addStep(sap.m.WizardStep wizardStep);

				/// <summary>
				/// Checks for the provided <code>sap.m.WizardStep</code> in the aggregation {@link #getSteps steps}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oStep">The step whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfStep(sap.m.WizardStep oStep);

				/// <summary>
				/// Removes all steps from the Wizard.
				/// </summary>
				/// <returns>Pointer to the Steps that were removed.</returns>
				public extern virtual sap.m.WizardStep[] removeAllSteps();

				#endregion

				#region Methods for Aggregation _progressNavigator

				#endregion

				#region Methods for Aggregation _nextButton

				#endregion

				#region Methods for Association currentStep

				/// <summary>
				/// ID of the element which is the current target of the association {@link #getCurrentStep currentStep}, or <code>null</code>.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.ID getCurrentStep();

				/// <summary>
				/// Sets association currentStep to the given step.
				/// </summary>
				/// <param name="stepId">The step of the wizard that will be currently activated (meaning the last step)</param>
				/// <returns>Reference to the control instance for chaining.</returns>
				public extern virtual sap.m.Wizard setCurrentStep(Union<sap.m.WizardStep, string> stepId);

				#endregion

				#region Methods for Event stepActivate

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:stepActivate stepActivate} event of this <code>sap.m.Wizard</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Wizard</code> itself.
				/// 
				/// The StepActivated event is fired every time a new step is activated.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.Wizard</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Wizard attachStepActivate(object oData, sap.m.IndexDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:stepActivate stepActivate} event of this <code>sap.m.Wizard</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Wizard</code> itself.
				/// 
				/// The StepActivated event is fired every time a new step is activated.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Wizard attachStepActivate(object oData, sap.m.IndexDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:stepActivate stepActivate} event of this <code>sap.m.Wizard</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Wizard</code> itself.
				/// 
				/// The StepActivated event is fired every time a new step is activated.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Wizard attachStepActivate(sap.m.IndexDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:stepActivate stepActivate} event of this <code>sap.m.Wizard</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Wizard</code> itself.
				/// 
				/// The StepActivated event is fired every time a new step is activated.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.Wizard</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Wizard attachStepActivate(sap.m.IndexDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:stepActivate stepActivate} event of this <code>sap.m.Wizard</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Wizard detachStepActivate(sap.m.IndexDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:stepActivate stepActivate} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Wizard fireStepActivate(sap.m.IndexInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:stepActivate stepActivate} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Wizard fireStepActivate();

				#endregion

				#region Methods for Event complete

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:complete complete} event of this <code>sap.m.Wizard</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Wizard</code> itself.
				/// 
				/// The complete event is fired when the user clicks the finish button of the Wizard. The finish button is only available on the last step of the Wizard.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.Wizard</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Wizard attachComplete(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:complete complete} event of this <code>sap.m.Wizard</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Wizard</code> itself.
				/// 
				/// The complete event is fired when the user clicks the finish button of the Wizard. The finish button is only available on the last step of the Wizard.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Wizard attachComplete(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:complete complete} event of this <code>sap.m.Wizard</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Wizard</code> itself.
				/// 
				/// The complete event is fired when the user clicks the finish button of the Wizard. The finish button is only available on the last step of the Wizard.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Wizard attachComplete(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:complete complete} event of this <code>sap.m.Wizard</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Wizard</code> itself.
				/// 
				/// The complete event is fired when the user clicks the finish button of the Wizard. The finish button is only available on the last step of the Wizard.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.Wizard</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Wizard attachComplete(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:complete complete} event of this <code>sap.m.Wizard</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Wizard detachComplete(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:complete complete} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Wizard fireComplete(object mParameters);

				/// <summary>
				/// Fires event {@link #event:complete complete} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Wizard fireComplete();

				#endregion

				#region Other methods

				/// <summary>
				/// Discards all progress done from the given step(incl.) to the end of the wizard. The verified state of the steps is returned to the initial provided.
				/// </summary>
				/// <param name="step">The step after which the progress is discarded.</param>
				/// <returns>Pointer to the control instance for chaining.</returns>
				public extern virtual sap.m.Wizard discardProgress(sap.m.WizardStep step);

				/// <summary>
				/// Creates a new subclass of class sap.m.Wizard with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.Wizard with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.Wizard with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.Wizard.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				/// <summary>
				/// Returns the number of the last activated step in the Wizard.
				/// </summary>
				/// <returns>The last activated step.</returns>
				public extern virtual int getProgress();

				/// <summary>
				/// Returns the last activated step in the Wizard.
				/// </summary>
				/// <returns>Pointer to the control instance for chaining.</returns>
				public extern virtual sap.m.WizardStep getProgressStep();

				/// <summary>
				/// Goes to the given step. The step must already be activated and visible. You can't use this method on steps that haven't been reached yet.
				/// </summary>
				/// <param name="step">The step to go to.</param>
				/// <param name="focusFirstStepElement">Defines whether the focus should be changed to the first element.</param>
				/// <returns>Pointer to the control instance for chaining.</returns>
				public extern virtual sap.m.Wizard goToStep(sap.m.WizardStep step, bool focusFirstStepElement);

				/// <summary>
				/// Invalidates the given step.
				/// </summary>
				/// <param name="step">The step to be invalidated.</param>
				/// <returns>Pointer to the control instance for chaining.</returns>
				public extern virtual sap.m.Wizard invalidateStep(sap.m.WizardStep step);

				/// <summary>
				/// Validates the current step, and moves one step further.
				/// </summary>
				/// <returns>Pointer to the control instance for chaining.</returns>
				public extern virtual sap.m.Wizard nextStep();

				/// <summary>
				/// Discards the current step and goes one step back.
				/// </summary>
				/// <returns>Pointer to the control instance for chaining.</returns>
				public extern virtual sap.m.Wizard previousStep();

				/// <summary>
				/// Validates the given step.
				/// </summary>
				/// <param name="step">The step to be validated.</param>
				/// <returns>Pointer to the control instance for chaining.</returns>
				public extern virtual sap.m.Wizard validateStep(sap.m.WizardStep step);

				#endregion

				#endregion

			}
		}
	}
}
