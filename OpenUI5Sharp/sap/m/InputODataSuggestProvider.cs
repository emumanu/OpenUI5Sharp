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
			/// Suggestion helper for sap.m.Input fields: Creates a multi column suggest list for an sap.m.Input field based on a ValueList annotation. The ValueList annotation will be resolved via the binding information of the Input field.
			/// 
			/// If the annotation describes multiple input parameter the suggest provider will resolve all of these relative to the context of the Input filed and use them for the suggestion query. The suggest provider will write all values that are described as output parameters back to the model (relative to the context of the Input field). This can only be done if the model runs in "TwoWay" binding mode. Both features can be switched of via the bResolveInput/bResolveOutput parameter of the suggest function:
			/// </summary>
			[External]
			[Namespace(false)]
			public static partial class InputODataSuggestProvider
			{
			}
		}
	}
}
