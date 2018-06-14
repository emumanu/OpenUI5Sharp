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
			public static partial class model
			{
				/// <summary>
				/// Instances of this exception are thrown when an error occurs while converting a string value to a specific property type in the model.
				/// </summary>
				[External]
				[Namespace(false)]
				public partial class ParseException
				{
					#region Constructor

					/// <summary>
					/// Create a new ParseException.
					/// </summary>
					/// <param name="message">Message explaining how the validation failed</param>
					public extern ParseException(string message);

					#endregion

				}
			}
		}
	}
}
