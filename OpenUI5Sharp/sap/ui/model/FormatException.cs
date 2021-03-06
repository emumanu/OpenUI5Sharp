﻿using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public partial class sap
	{
		public static partial class ui
		{
			public static partial class model
			{
				/// <summary>
				/// Instances of this exception are thrown when an error occurs while trying to convert a value of the model to a specific property value in the UI.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.model.FormatException")]
				public partial class FormatException : sap.ui.@base.Exception
				{
					#region Constructor

					/// <summary>
					/// Creates a new FormatException.
					/// </summary>
					/// <param name="message">Message explaining how the validation failed</param>
					public extern FormatException(string message);

					#endregion

				}
			}
		}
	}
}
