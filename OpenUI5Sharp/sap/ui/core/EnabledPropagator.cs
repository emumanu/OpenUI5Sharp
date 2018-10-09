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
				/// Helper Class for enhancement of a Control with propagation of enabled property.
				/// 
				/// <b>This constructor should be applied to the prototype of a control</b>
				/// 
				/// Example: <code> sap.ui.core.EnabledPropagator.call(<i>Some-Control</i>.prototype, <i>Default-value, ...</i>); </code> e.g. <code> sap.ui.core.EnabledPropagator.call(sap.ui.commons.Button.prototype); </code>
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.core.EnabledPropagator")]
				public partial class EnabledPropagator
				{
					#region Constructor

					/// <param name="bDefault">the value that should be used as default value for the enhancement of the control.</param>
					/// <param name="bLegacy">whether the introduced property should use the old name 'Enabled'</param>
					public extern EnabledPropagator(bool bDefault = true, bool bLegacy = false);

					#endregion

				}
			}
		}
	}
}
