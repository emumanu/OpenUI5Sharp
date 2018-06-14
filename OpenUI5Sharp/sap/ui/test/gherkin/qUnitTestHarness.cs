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
				public static partial class gherkin
				{
					/// <summary>
					/// Dynamically generates and executes QUnit tests based on a Gherkin feature file and step definitions
					/// 
					/// Logs activity to QUnit, and some debug information to the console with the prefix "[GHERKIN]"
					/// </summary>
					[External]
					[Namespace(false)]
					public static partial class qUnitTestHarness
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
							/// the constructor function of type {@link sap.ui.test.gherkin.StepDefinitions}
							/// </summary>
							public object steps;

						}

						#endregion

						#region Methods

						/// <summary>
						/// Dynamically generates and executes QUnit tests
						/// </summary>
						/// <param name="args">the arguments to the function</param>
						public extern static void test(sap.ui.test.gherkin.qUnitTestHarness.TestInfo args);

						#endregion

					}
				}
			}
		}
	}
}
