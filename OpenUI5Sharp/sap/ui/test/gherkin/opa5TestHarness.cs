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
					/// <summary>
					/// Dynamically generates and executes Opa5 tests based on a Gherkin feature file and step definitions.
					/// 
					/// Logs activity to Opa5, and some debug information to the console with the prefix "[GHERKIN]"
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.test.gherkin.opa5TestHarness")]
					public static partial class opa5TestHarness
					{
						#region Typed Parameters

						/// <summary>
						/// Parameter to be used as Object Literal
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class TestInfo
						{
							/// <summary>
							/// the path to the Gherkin feature file to parse, as an SAPUI5 module path. The ".feature" extension is assumed and should not be included. See {@link jQuery.sap.registerModulePath}
							/// </summary>
							public string featurePath;

							/// <summary>
							/// the constructor function of type {@link sap.ui.test.gherkin.StepDefinitions}. If this parameter is ommitted then args.generateMissingSteps must be explicitly set to true.
							/// </summary>
							public object steps;

							/// <summary>
							/// When true: if a Gherkin step cannot be matched to a step definition then it will be assumed that the user wants to convert the step into an Opa Page Object call.
							/// </summary>
							public bool generateMissingSteps;

						}

						#endregion

						#region Methods

						/// <summary>
						/// Dynamically generates Opa5 tests
						/// 
						/// If a test step is missing and args.generateMissingSteps is true then the Gherkin step will be converted into Opa Page Object code and executed. The text will be converted to camelCase and have any non-alphanumeric character removed. Here are two pertinent examples:
						/// 
						/// (1) The simple step "Given I start my app" will be converted into the call "Given.iStartMyApp();"
						/// 
						/// (2) The step "Then on page 1: I should see the page 1 text" will become the call "Then.onPage1.iShouldSeeThePage1Text();"
						/// 
						/// Chaining function calls, such as "Then.iStartMyApp().and.iCloseMyApp()" is not possible at this time.
						/// </summary>
						/// <param name="args">the arguments to the function</param>
						public extern static void test(sap.ui.test.gherkin.opa5TestHarness.TestInfo args);

						#endregion

					}
				}
			}
		}
	}
}
