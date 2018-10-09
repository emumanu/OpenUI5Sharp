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
				[External]
				[Namespace(false)]
				[Name("sap.ui.core.mvc")]
				public static partial class mvc
				{
					/// <summary>
					/// Specifies possible view types
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.core.mvc.ViewType")]
					public enum ViewType
					{
						/// <summary>
						/// HTML view
						/// </summary>
						HTML,
						/// <summary>
						/// JS View
						/// </summary>
						JS,
						/// <summary>
						/// JSON View
						/// </summary>
						JSON,
						/// <summary>
						/// Template View
						/// </summary>
						Template,
						/// <summary>
						/// XML view
						/// </summary>
						XML,
					}
					/// <summary>
					/// Execution option for overrides defined by a ControllerExtension
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.core.mvc.OverrideExcecution")]
					public enum OverrideExcecution
					{
						/// <summary>
						/// The override function gets executed after the original function
						/// </summary>
						After,
						/// <summary>
						/// The override function gets executed before the original function
						/// </summary>
						Before,
						/// <summary>
						/// The override function is called instead of the original function
						/// 
						/// This is the default option for ControllerExtension overrides
						/// </summary>
						Instead,
					}
					/// <summary>
					/// Marker interface for a ControllerExtension.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.core.mvc.IControllerExtension")]
					public partial interface IControllerExtension
					{
					}
				}
			}
		}
	}
}
