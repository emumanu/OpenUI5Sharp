﻿using System;
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
			/// Suggestion helper for sap.m.Input fields: Creates a multi-column suggest list for an sap.m.Input field based on a ValueList annotation. The ValueList annotation will be resolved via the binding information of the Input field.
			/// 
			/// If the annotation describes multiple input parameter the suggest provider will resolve all of these relative to the context of the Input filed and use them for the suggestion query. The suggest provider will write all values that are described as output parameters back to the model (relative to the context of the Input field). This can only be done if the model runs in "TwoWay" binding mode. Both features can be switched of via the bResolveInput/bResolveOutput parameter of the suggest function:
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.InputODataSuggestProvider")]
			public static partial class InputODataSuggestProvider
			{
				#region Methods

				/// <param name="oEvent"></param>
				/// <param name="bResolveInput">SuggestProvider resolves all input parameters for the data query</param>
				/// <param name="bResolveOutput">SuggestProvider writes back all output parameters.</param>
				/// <param name="iLength">If iLength is provided only these number of entries will be requested.</param>
				public extern static void suggest(sap.ui.@base.Event oEvent, bool bResolveInput, bool bResolveOutput, int iLength);

				#endregion

			}
		}
	}
}
