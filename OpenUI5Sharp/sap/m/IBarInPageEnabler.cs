using System;
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
			/// Helper Class for implementing the IBar interface. Should be created once per IBar instance.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.IBarInPageEnabler")]
			public partial class IBarInPageEnabler
			{
				#region Constructor

				public extern IBarInPageEnabler();

				#endregion

				#region Methods

				/// <summary>
				/// Adds the sapMBarChildClass to a control.
				/// </summary>
				/// <param name="oControl">The sap.ui.core.Control to which the sapMBarChildClass will be added</param>
				public extern static void addChildClassTo(sap.ui.core.Control oControl);

				/// <summary>
				/// Renders the tooltip for the given control
				/// </summary>
				/// <param name="oRM">the RenderManager that can be used for writing to the render output buffer.</param>
				/// <param name="oControl">an object representation of the control that should be rendered.</param>
				public extern static void renderTooltip(sap.ui.core.RenderManager oRM, sap.ui.core.Control oControl);

				#endregion

			}
		}
	}
}
