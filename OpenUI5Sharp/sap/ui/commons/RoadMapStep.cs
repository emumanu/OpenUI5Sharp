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
				/// Step used within a RoadMap Control.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.RoadMapStep")]
				[Obsolete("Deprecated since 1.38. Instead, use the <code>sap.m.Wizard</code> control.")]
				public partial class RoadMapStep : sap.ui.core.Element
				{
					#region Settings

					/// <summary>
					/// Settings class to create the object
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class Settings : sap.ui.core.Element.Settings
					{
						/// <summary>
						/// Label of the step
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> label;

						/// <summary>
						/// Specifies whether the user shall be allowed to click a step, or not
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> enabled;

						/// <summary>
						/// This property is only relevant when using sub steps.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> expanded;

						/// <summary>
						/// Step is visible
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> visible;

						/// <summary>
						/// Sub steps for the current step. Will be displayed only in the case that the step is expanded. Otherwise, special arrows show the availability of sub steps. One level of sub steps supported.
						/// </summary>
						public Union<sap.ui.commons.RoadMapStep[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> subSteps;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new RoadMapStep.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern RoadMapStep(string sId, sap.ui.commons.RoadMapStep.Settings mSettings);

					/// <summary>
					/// Constructor for a new RoadMapStep.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern RoadMapStep(string sId);

					/// <summary>
					/// Constructor for a new RoadMapStep.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern RoadMapStep();

					/// <summary>
					/// Constructor for a new RoadMapStep.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern RoadMapStep(sap.ui.commons.RoadMapStep.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property label

					/// <summary>
					/// Gets current value of property {@link #getLabel label}.
					/// 
					/// Label of the step
					/// </summary>
					/// <returns>Value of property <code>label</code></returns>
					public extern virtual string getLabel();

					/// <summary>
					/// Sets a new value for property {@link #getLabel label}.
					/// 
					/// Label of the step
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sLabel">New value for property <code>label</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RoadMapStep setLabel(string sLabel);

					#endregion

					#region Methods for Property enabled

					/// <summary>
					/// Gets current value of property {@link #getEnabled enabled}.
					/// 
					/// Specifies whether the user shall be allowed to click a step, or not
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>enabled</code></returns>
					public extern virtual bool getEnabled();

					/// <summary>
					/// Sets a new value for property {@link #getEnabled enabled}.
					/// 
					/// Specifies whether the user shall be allowed to click a step, or not
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bEnabled">New value for property <code>enabled</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RoadMapStep setEnabled(bool bEnabled);

					#endregion

					#region Methods for Property expanded

					/// <summary>
					/// Gets current value of property {@link #getExpanded expanded}.
					/// 
					/// This property is only relevant when using sub steps.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>expanded</code></returns>
					[Obsolete("Deprecated since 1.10.5. Note that sub steps will not be supported in future. This feature might be removed in one of the next releases.")]
					public extern virtual bool getExpanded();

					/// <summary>
					/// Sets a new value for property {@link #getExpanded expanded}.
					/// 
					/// This property is only relevant when using sub steps.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bExpanded">New value for property <code>expanded</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					[Obsolete("Deprecated since 1.10.5. Note that sub steps will not be supported in future. This feature might be removed in one of the next releases.")]
					public extern virtual sap.ui.commons.RoadMapStep setExpanded(bool bExpanded);

					#endregion

					#region Methods for Property visible

					/// <summary>
					/// Gets current value of property {@link #getVisible visible}.
					/// 
					/// Step is visible
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>visible</code></returns>
					public extern virtual bool getVisible();

					/// <summary>
					/// Sets a new value for property {@link #getVisible visible}.
					/// 
					/// Step is visible
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bVisible">New value for property <code>visible</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.RoadMapStep setVisible(bool bVisible);

					#endregion

					#region Methods for Aggregation subSteps

					/// <summary>
					/// Gets content of aggregation {@link #getSubSteps subSteps}.
					/// 
					/// Sub steps for the current step. Will be displayed only in the case that the step is expanded. Otherwise, special arrows show the availability of sub steps. One level of sub steps supported.
					/// </summary>
					/// <returns></returns>
					[Obsolete("Deprecated since 1.10.5. Sub steps will not be supported in future. This feature might be removed in one of the next releases.")]
					public extern virtual sap.ui.commons.RoadMapStep[] getSubSteps();

					/// <summary>
					/// Destroys all the subSteps in the aggregation {@link #getSubSteps subSteps}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					[Obsolete("Deprecated since 1.10.5. Sub steps will not be supported in future. This feature might be removed in one of the next releases.")]
					public extern virtual sap.ui.commons.RoadMapStep destroySubSteps();

					/// <summary>
					/// Inserts a subStep into the aggregation {@link #getSubSteps subSteps}.
					/// </summary>
					/// <param name="oSubStep">The subStep to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the subStep should be inserted at; for a negative value of <code>iIndex</code>, the subStep is inserted at position 0; for a value greater than the current size of the aggregation, the subStep is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					[Obsolete("Deprecated since 1.10.5. Sub steps will not be supported in future. This feature might be removed in one of the next releases.")]
					public extern virtual sap.ui.commons.RoadMapStep insertSubStep(sap.ui.commons.RoadMapStep oSubStep, int iIndex);

					/// <summary>
					/// Adds some subStep to the aggregation {@link #getSubSteps subSteps}.
					/// </summary>
					/// <param name="oSubStep">The subStep to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					[Obsolete("Deprecated since 1.10.5. Sub steps will not be supported in future. This feature might be removed in one of the next releases.")]
					public extern virtual sap.ui.commons.RoadMapStep addSubStep(sap.ui.commons.RoadMapStep oSubStep);

					/// <summary>
					/// Removes a subStep from the aggregation {@link #getSubSteps subSteps}.
					/// </summary>
					/// <param name="vSubStep">The subStep to remove or its index or id</param>
					/// <returns>The removed subStep or <code>null</code></returns>
					[Obsolete("Deprecated since 1.10.5. Sub steps will not be supported in future. This feature might be removed in one of the next releases.")]
					public extern virtual sap.ui.commons.RoadMapStep removeSubStep(Union<int, string, sap.ui.commons.RoadMapStep> vSubStep);

					/// <summary>
					/// Checks for the provided <code>sap.ui.commons.RoadMapStep</code> in the aggregation {@link #getSubSteps subSteps}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oSubStep">The subStep whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					[Obsolete("Deprecated since 1.10.5. Sub steps will not be supported in future. This feature might be removed in one of the next releases.")]
					public extern virtual int indexOfSubStep(sap.ui.commons.RoadMapStep oSubStep);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getSubSteps subSteps}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					[Obsolete("Deprecated since 1.10.5. Sub steps will not be supported in future. This feature might be removed in one of the next releases.")]
					public extern virtual sap.ui.commons.RoadMapStep[] removeAllSubSteps();

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.RoadMapStep with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.RoadMapStep with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.RoadMapStep with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.commons.RoadMapStep.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					[Name("getMetadata")]
					public extern static sap.ui.@base.Metadata getMetadataStatic();

					#endregion

					#endregion

				}
			}
		}
	}
}
