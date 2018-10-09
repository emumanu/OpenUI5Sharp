using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public partial class jQuery
	{
		public static partial class sap
		{
			[External]
			[Namespace(false)]
			[Name("jQuery.sap.support")]
			public static partial class support
			{
				#region Methods

				/// <summary>
				/// Analyzes all rules in the given execution scope.
				/// </summary>
				/// <param name="oExecutionScope">The execution scope of the analysis with the type of the scope</param>
				/// <param name="aRuleDescriptors">An array with rules against which the analysis will be run</param>
				/// <returns>Notifies the finished state by starting the Analyzer</returns>
				public extern static jquery.JQueryPromise<object> analyze(object oExecutionScope, object[] aRuleDescriptors);

				/// <summary>
				/// Gets history.
				/// </summary>
				/// <returns>Current history.</returns>
				public extern static object[] getAnalysisHistory();

				/// <summary>
				/// Gets last analysis history.
				/// </summary>
				/// <returns>Last analysis history.</returns>
				public extern static object getLastAnalysisHistory();

				#endregion

			}
		}
	}
}
