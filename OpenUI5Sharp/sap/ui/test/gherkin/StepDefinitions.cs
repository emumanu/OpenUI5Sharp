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
				public static partial class gherkin
				{
					[External]
					[Namespace(false)]
					[Name("sap.ui.test.gherkin.StepDefinitions")]
					public abstract partial class StepDefinitions : sap.ui.@base.Object
					{
						#region Constructor

						/// <summary>
						/// A Gherkin feature file is human-readable, and the computer does not know how to execute its steps. This StepDefinitions class provides the interface between human and machine. It defines what each step in the Gherkin feature file will actually do when it is executed.
						/// 
						/// Meant to be implemented/overridden by a child object. Specifically, the functions "init" and "closeApplication" need to be overridden.
						/// </summary>
						public extern StepDefinitions();

						#endregion

						#region Methods

						/// <summary>
						/// Closes the application and cleans up any mess made by the tests. To avoid erroneous exceptions during test execution, make sure that it is safe to run this method even if the application was never started.
						/// </summary>
						public extern virtual void closeApplication();

						/// <summary>
						/// Creates a new subclass of class sap.ui.test.gherkin.StepDefinitions with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.test.gherkin.StepDefinitions with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.test.gherkin.StepDefinitions with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns a metadata object for class sap.ui.test.gherkin.StepDefinitions.
						/// </summary>
						/// <returns>Metadata object describing this class</returns>
						[Name("getMetadata")]
						public extern static sap.ui.@base.Metadata getMetadataStatic();

						/// <summary>
						/// Registers the step definitions by calling the method "register".
						/// </summary>
						public extern virtual void init();

						/// <summary>
						/// Registers a step definition.
						/// </summary>
						/// <param name="rRegex">the regular expression that matches the feature file step (with leading "Given", "When", "Then", "But" or "*" removed). E.g. if the feature file has the step "Then I should be served a coffee" it will be truncated to "I should be served a coffee" and tested against "rRegex" to check for a match. The simple regular expression /^I should be served a coffee$/i would match this text. The regular expression can specify capturing groups, which will be passed as parameters to "fnFunc".</param>
						/// <param name="fnFunc">the function to execute in the event that the regular expression matches. Receives regular expression capturing groups as parameters in the same order that they are specified in the regular expression. If a data table is specified for the step, it will be passed as an additional final parameter. At execution time, all functions within a particular scenario will execute within the same "this" context.</param>
						public extern virtual void register(es5.RegExp rRegex, object fnFunc);

						#endregion

					}
				}
			}
		}
	}
}
