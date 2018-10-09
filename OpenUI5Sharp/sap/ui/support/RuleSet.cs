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
			public static partial class support
			{
				/// <summary>
				/// Creates a RuleSet. The RuleSet can store multiple rules concerning namespaces. <h3>Usage</h3> The RuleSet is an interface used to create, update and delete rulesets.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.support.RuleSet")]
				public static partial class RuleSet
				{
					#region Methods

					/// <summary>
					/// Adds rules to RuleSet.
					/// </summary>
					/// <param name="oSettings">Settings object with rule information</param>
					/// <returns>sRuleVerificationStatus Verification status</returns>
					public extern static string addRule(object oSettings);

					/// <summary>
					/// Adds all previously created temporary rules to the current library rules.
					/// </summary>
					/// <param name="oLibraries">The loaded libraries and their rules</param>
					/// <param name="aTempRules">The temporary rules previously created by the user</param>
					public extern static void addToTempRules(object oLibraries, string[] aTempRules);

					/// <summary>
					/// Adds all previously created temporary rules to the current library rules.
					/// </summary>
					/// <param name="oLibraries">The loaded libraries and their rules</param>
					/// <param name="aTempRules">The temporary rules previously created by the user</param>
					public extern static void addToTempRules(object oLibraries, object[] aTempRules);

					/// <summary>
					/// Clears all rulesets inside the RuleSet.
					/// </summary>
					public extern static void clearAllRuleSets();

					/// <summary>
					/// Gets all rules from the RuleSet.
					/// </summary>
					/// <returns>All rules within the current RuleSet</returns>
					public extern static object getRules();

					/// <summary>
					/// Loads the previous selection of the user - which rules are selected to be run by the Rule Analyzer. The method applies the settings to the currently loaded rules.
					/// </summary>
					/// <param name="aLibraries">The current loaded libraries and their rules</param>
					public extern static void loadSelectionOfRules(object[] aLibraries);

					/// <summary>
					/// Stores which rules are selected to be run by the analyzer on the next check
					/// </summary>
					/// <param name="aLibraries">The data for the libraries and their rules</param>
					public extern static void storeSelectionOfRules(object[] aLibraries);

					/// <summary>
					/// Updates rules from the RuleSet.
					/// </summary>
					/// <param name="sRuleId">Rule ID</param>
					/// <param name="ORuleSettings">Rule settings</param>
					/// <returns>sRuleVerification Rule Verification status</returns>
					public extern static string updateRule(string sRuleId, object ORuleSettings);

					#endregion

				}
			}
		}
	}
}
