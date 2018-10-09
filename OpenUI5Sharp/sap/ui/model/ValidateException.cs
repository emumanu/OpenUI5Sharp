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
			public static partial class model
			{
				/// <summary>
				/// Instances of this exception are thrown when a validation error occurs while checking the defined constraints for a type.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.model.ValidateException")]
				public partial class ValidateException : sap.ui.@base.Exception
				{
					#region Constructor

					/// <summary>
					/// Creates a new ValidateException.
					/// </summary>
					/// <param name="message">Message explaining how the validation failed</param>
					/// <param name="violatedConstraints">Names of the constraints that will be violated; names should be the same as documented for the type constructor</param>
					public extern ValidateException(string message, string[] violatedConstraints);

					/// <summary>
					/// Creates a new ValidateException.
					/// </summary>
					/// <param name="message">Message explaining how the validation failed</param>
					public extern ValidateException(string message);

					#endregion

				}
			}
		}
	}
}
