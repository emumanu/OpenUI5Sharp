using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace OpenUI5Sharp
{
	public static partial class sap
	{
		public static partial class m
		{
			/// <summary>
			/// A container control used to aggregate user input controls as part of an sap.m.Wizard. <h3>Overview</h3> WizardStep gives the developer the ability to validate, invalidate the step and define subsequent steps. The WizardStep control control is supposed to be used only as an aggregation of the {@link sap.m.Wizard Wizard} control, and should not be used as a standalone one. <h3>Structure</h3> <ul> <li>Each wizard step has a title. Additionally it can have an icon.</li> <li>Each wizard step can be validated by setting the <code>validated</code> property. This action will trigger the rendering of the Next step button.</li> <li>If the execution needs to branch after a given step, you should set all possible next steps in the <code>subsequentSteps</code> aggregation.
			/// </summary>
			[External]
			[Namespace(false)]
			public partial class WizardStep : sap.ui.core.Control
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
					/// Determines the title of the step. The title is visualized in the Wizard control.
					/// </summary>
					public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> title;

					/// <summary>
					/// Determines the icon that is displayed for this step. The icon is visualized in the progress navigation part of the Wizard control. <b>Note:</b> In order for the icon to be displayed, each step in the Wizard should have this property defined, otherwise the default numbering will be displayed.
					/// </summary>
					public Union<sap.ui.core.URI, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> icon;

					/// <summary>
					/// Indicates whether or not the step is validated. When a step is validated a Next button is visualized in the Wizard control.
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> validated;

					/// <summary>
					/// Indicates whether or not the step is optional. When a step is optional an "(Optional)" label is displayed under the step's title.
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> optional;

					/// <summary>
					/// The content of the Wizard Step.
					/// </summary>
					public Union<sap.ui.core.Control[], string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> content;

					/// <summary>
					/// This association is used only when the <code>enableBranching</code> property of the Wizard is set to true. Use the association to store the next steps that are about to come after the current. If this is going to be a final step - leave this association empty.
					/// </summary>
					public Union<sap.m.WizardStep, sap.ui.core.ID[], string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> subsequentSteps;

					/// <summary>
					/// The next step to be taken after the step is completed. Set this association value in the complete event of the current WizardStep.
					/// </summary>
					public Union<sap.m.WizardStep, sap.ui.core.ID, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> nextStep;

					/// <summary>
					/// This event is fired after the user presses the Next button in the Wizard, or on <code>nextStep</code> method call from the app developer.
					/// </summary>
					public sap.ui.@base.EventDelegate complete;

					/// <summary>
					/// This event is fired on next step activation from the Wizard.
					/// </summary>
					public sap.ui.@base.EventDelegate activate;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new WizardStep.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern WizardStep(string sId, sap.m.WizardStep.Settings mSettings);

				/// <summary>
				/// Constructor for a new WizardStep.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern WizardStep(string sId);

				/// <summary>
				/// Constructor for a new WizardStep.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern WizardStep();

				/// <summary>
				/// Constructor for a new WizardStep.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern WizardStep(sap.m.WizardStep.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property title

				/// <summary>
				/// Gets current value of property {@link #getTitle title}.
				/// 
				/// Determines the title of the step. The title is visualized in the Wizard control.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <returns>Value of property <code>title</code></returns>
				public extern virtual string getTitle();

				/// <summary>
				/// Sets a new value for property {@link #getTitle title}.
				/// 
				/// Determines the title of the step. The title is visualized in the Wizard control.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <param name="sTitle">New value for property <code>title</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.WizardStep setTitle(string sTitle);

				#endregion

				#region Methods for Property icon

				/// <summary>
				/// Gets current value of property {@link #getIcon icon}.
				/// 
				/// Determines the icon that is displayed for this step. The icon is visualized in the progress navigation part of the Wizard control. <b>Note:</b> In order for the icon to be displayed, each step in the Wizard should have this property defined, otherwise the default numbering will be displayed.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <returns>Value of property <code>icon</code></returns>
				public extern virtual sap.ui.core.URI getIcon();

				/// <summary>
				/// Sets a new value for property {@link #getIcon icon}.
				/// 
				/// Determines the icon that is displayed for this step. The icon is visualized in the progress navigation part of the Wizard control. <b>Note:</b> In order for the icon to be displayed, each step in the Wizard should have this property defined, otherwise the default numbering will be displayed.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <param name="sIcon">New value for property <code>icon</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.WizardStep setIcon(sap.ui.core.URI sIcon);

				#endregion

				#region Methods for Property validated

				/// <summary>
				/// Gets current value of property {@link #getValidated validated}.
				/// 
				/// Indicates whether or not the step is validated. When a step is validated a Next button is visualized in the Wizard control.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>validated</code></returns>
				public extern virtual bool getValidated();

				/// <summary>
				/// Sets a new value for property {@link #getValidated validated}.
				/// 
				/// Indicates whether or not the step is validated. When a step is validated a Next button is visualized in the Wizard control.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bValidated">New value for property <code>validated</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.WizardStep setValidated(bool bValidated);

				#endregion

				#region Methods for Property optional

				/// <summary>
				/// Gets current value of property {@link #getOptional optional}.
				/// 
				/// Indicates whether or not the step is optional. When a step is optional an "(Optional)" label is displayed under the step's title.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>optional</code></returns>
				public extern virtual bool getOptional();

				/// <summary>
				/// Sets a new value for property {@link #getOptional optional}.
				/// 
				/// Indicates whether or not the step is optional. When a step is optional an "(Optional)" label is displayed under the step's title.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bOptional">New value for property <code>optional</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.WizardStep setOptional(bool bOptional);

				#endregion

				#region Methods for Aggregation content

				/// <summary>
				/// Gets content of aggregation {@link #getContent content}.
				/// 
				/// The content of the Wizard Step.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.Control[] getContent();

				/// <summary>
				/// Destroys all the content in the aggregation {@link #getContent content}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.WizardStep destroyContent();

				/// <summary>
				/// Inserts a content into the aggregation {@link #getContent content}.
				/// </summary>
				/// <param name="oContent">The content to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the content should be inserted at; for a negative value of <code>iIndex</code>, the content is inserted at position 0; for a value greater than the current size of the aggregation, the content is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.WizardStep insertContent(sap.ui.core.Control oContent, int iIndex);

				/// <summary>
				/// Adds some content to the aggregation {@link #getContent content}.
				/// </summary>
				/// <param name="oContent">The content to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.WizardStep addContent(sap.ui.core.Control oContent);

				/// <summary>
				/// Removes a content from the aggregation {@link #getContent content}.
				/// </summary>
				/// <param name="vContent">The content to remove or its index or id</param>
				/// <returns>The removed content or <code>null</code></returns>
				public extern virtual sap.ui.core.Control removeContent(Union<int, string, sap.ui.core.Control> vContent);

				/// <summary>
				/// Checks for the provided <code>sap.ui.core.Control</code> in the aggregation {@link #getContent content}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oContent">The content whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfContent(sap.ui.core.Control oContent);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getContent content}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.ui.core.Control[] removeAllContent();

				#endregion

				#region Methods for Association subsequentSteps

				/// <summary>
				/// Returns array of IDs of the elements which are the current targets of the association {@link #getSubsequentSteps subsequentSteps}.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.ID[] getSubsequentSteps();

				/// <summary>
				/// Adds some subsequentStep into the association {@link #getSubsequentSteps subsequentSteps}.
				/// </summary>
				/// <param name="vSubsequentStep">The subsequentSteps to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.WizardStep addSubsequentStep(Union<sap.ui.core.ID, sap.m.WizardStep> vSubsequentStep);

				/// <summary>
				/// Removes an subsequentStep from the association named {@link #getSubsequentSteps subsequentSteps}.
				/// </summary>
				/// <param name="vSubsequentStep">The subsequentStep to be removed or its index or ID</param>
				/// <returns>The removed subsequentStep or <code>null</code></returns>
				public extern virtual sap.ui.core.ID removeSubsequentStep(Union<int, sap.ui.core.ID, sap.m.WizardStep> vSubsequentStep);

				/// <summary>
				/// Removes all the controls in the association named {@link #getSubsequentSteps subsequentSteps}.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.ui.core.ID[] removeAllSubsequentSteps();

				#endregion

				#region Methods for Association nextStep

				/// <summary>
				/// ID of the element which is the current target of the association {@link #getNextStep nextStep}, or <code>null</code>.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.ID getNextStep();

				/// <summary>
				/// Sets the associated {@link #getNextStep nextStep}.
				/// </summary>
				/// <param name="oNextStep">ID of an element which becomes the new target of this nextStep association; alternatively, an element instance may be given</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.WizardStep setNextStep(Union<sap.ui.core.ID, sap.m.WizardStep> oNextStep);

				#endregion

				#region Methods for Event complete

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:complete complete} event of this <code>sap.m.WizardStep</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.WizardStep</code> itself.
				/// 
				/// This event is fired after the user presses the Next button in the Wizard, or on <code>nextStep</code> method call from the app developer.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.WizardStep</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.WizardStep attachComplete(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:complete complete} event of this <code>sap.m.WizardStep</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.WizardStep</code> itself.
				/// 
				/// This event is fired after the user presses the Next button in the Wizard, or on <code>nextStep</code> method call from the app developer.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.WizardStep attachComplete(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:complete complete} event of this <code>sap.m.WizardStep</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.WizardStep</code> itself.
				/// 
				/// This event is fired after the user presses the Next button in the Wizard, or on <code>nextStep</code> method call from the app developer.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.WizardStep attachComplete(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:complete complete} event of this <code>sap.m.WizardStep</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.WizardStep</code> itself.
				/// 
				/// This event is fired after the user presses the Next button in the Wizard, or on <code>nextStep</code> method call from the app developer.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.WizardStep</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.WizardStep attachComplete(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:complete complete} event of this <code>sap.m.WizardStep</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.WizardStep detachComplete(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:complete complete} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.WizardStep fireComplete(object mParameters);

				/// <summary>
				/// Fires event {@link #event:complete complete} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.WizardStep fireComplete();

				#endregion

				#region Methods for Event activate

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:activate activate} event of this <code>sap.m.WizardStep</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.WizardStep</code> itself.
				/// 
				/// This event is fired on next step activation from the Wizard.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.WizardStep</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.WizardStep attachActivate(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:activate activate} event of this <code>sap.m.WizardStep</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.WizardStep</code> itself.
				/// 
				/// This event is fired on next step activation from the Wizard.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.WizardStep attachActivate(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:activate activate} event of this <code>sap.m.WizardStep</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.WizardStep</code> itself.
				/// 
				/// This event is fired on next step activation from the Wizard.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.WizardStep attachActivate(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:activate activate} event of this <code>sap.m.WizardStep</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.WizardStep</code> itself.
				/// 
				/// This event is fired on next step activation from the Wizard.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.WizardStep</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.WizardStep attachActivate(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:activate activate} event of this <code>sap.m.WizardStep</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.WizardStep detachActivate(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:activate activate} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.WizardStep fireActivate(object mParameters);

				/// <summary>
				/// Fires event {@link #event:activate activate} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.WizardStep fireActivate();

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.WizardStep with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.WizardStep with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.WizardStep with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.WizardStep.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				#endregion

				#endregion

			}
		}
	}
}
