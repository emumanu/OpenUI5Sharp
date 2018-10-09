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
			public static partial class @base
			{
				/// <summary>
				/// A class that creates an Interface for an existing class. If a class returns the interface in its constructor, only the defined functions will be visible, no internals of the class can be accessed.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.base.Interface")]
				public partial class Interface
				{
					#region Constructor

					/// <summary>
					/// Constructs an instance of sap.ui.base.Interface which restricts access to methods marked as public.
					/// </summary>
					/// <param name="oObject">the instance that needs an interface created</param>
					/// <param name="aMethods">the names of the methods, that should be available on this interface</param>
					public extern Interface(sap.ui.@base.Object oObject, string[] aMethods);

					#endregion

				}
			}
		}
	}
}
