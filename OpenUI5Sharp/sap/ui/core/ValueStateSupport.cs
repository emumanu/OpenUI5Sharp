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
			public static partial class core
			{
				/// <summary>
				/// Helper functionality for value state support.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.core.ValueStateSupport")]
				public static partial class ValueStateSupport
				{
					#region Methods

					/// <summary>
					/// Appends a generic success, warning or error message to the given tooltip text if the given Element has a property "valueState" with one of these three states.
					/// </summary>
					/// <param name="oElement">the Element of which the tooltip needs to be modified</param>
					/// <param name="sTooltipText">the original tooltip text (may be null)</param>
					/// <returns>the given text, with appended success/warning/error text, if appropriate</returns>
					public extern static string enrichTooltip(sap.ui.core.Element oElement, string sTooltipText);

					/// <summary>
					/// Returns a ValueState object based on the given integer value
					/// 
					/// 0 : ValueState.None 1 : ValueState.Warning 2 : ValueState.Success 3 : ValueState.Error
					/// </summary>
					/// <param name="iState">the state as an integer</param>
					/// <returns>the corresponding ValueState object</returns>
					public extern static sap.ui.core.ValueState formatValueState(int iState);

					/// <summary>
					/// Returns a generic success, warning or error message if the given Element has a property "valueState" with one of these three states or the given ValueState represents one of these states.
					/// </summary>
					/// <param name="vValue">the Element of which the valueState needs to be checked, or the ValueState explicitly</param>
					/// <returns>the success/warning/error text, if appropriate; otherwise null</returns>
					public extern static string getAdditionalText(Union<sap.ui.core.Element, sap.ui.core.ValueState> vValue);

					#endregion

				}
			}
		}
	}
}
