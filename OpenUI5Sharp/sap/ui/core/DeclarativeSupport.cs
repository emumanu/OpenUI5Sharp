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
			public static partial class core
			{
				/// <summary>
				/// Static class for enabling declarative UI support.
				/// </summary>
				[External]
				[Namespace(false)]
				public partial class DeclarativeSupport
				{
					#region Constructor

					public extern DeclarativeSupport();

					#endregion

					#region Methods

					/// <summary>
					/// Enhances the given DOM element by parsing the Control and Elements info and creating the SAPUI5 controls for them.
					/// </summary>
					/// <param name="oElement">the DOM element to compile</param>
					/// <param name="oView">The view instance to use</param>
					/// <param name="isRecursive">Whether the call of the function is recursive.</param>
					public extern static void compile(dom.HTMLElement oElement, sap.ui.core.mvc.HTMLView oView, bool isRecursive);

					/// <summary>
					/// Enhances the given DOM element by parsing the Control and Elements info and creating the SAPUI5 controls for them.
					/// </summary>
					/// <param name="oElement">the DOM element to compile</param>
					/// <param name="oView">The view instance to use</param>
					public extern static void compile(dom.HTMLElement oElement, sap.ui.core.mvc.HTMLView oView);

					/// <summary>
					/// Enhances the given DOM element by parsing the Control and Elements info and creating the SAPUI5 controls for them.
					/// </summary>
					/// <param name="oElement">the DOM element to compile</param>
					public extern static void compile(dom.HTMLElement oElement);

					#endregion

				}
			}
		}
	}
}
