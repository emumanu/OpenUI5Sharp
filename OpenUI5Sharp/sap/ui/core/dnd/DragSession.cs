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
				public static partial class dnd
				{
					/// <summary>
					/// When a user requests to drag some controls that can be dragged, a drag session is started. The drag session can be used to transfer data between applications or between dragged and dropped controls. Please see provided APIs for more details.
					/// 
					/// <b>Note:</b> This object only exists during a drag-and-drop operation.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.core.dnd.DragSession")]
					public static partial class DragSession
					{
						#region Methods

						/// <summary>
						/// Returns the data that has been set via <code>setComplexData</code> method.
						/// </summary>
						/// <param name="sKey">The key of the data</param>
						/// <returns>The previously set data or undefined</returns>
						public extern static object getComplexData(string sKey);

						/// <summary>
						/// Returns the data that has been set via <code>setData</code> method.
						/// </summary>
						/// <param name="sKey">The key of the data</param>
						/// <returns>Data</returns>
						public extern static string getData(string sKey);

						/// <summary>
						/// Returns the dragged control, if available within the same UI5 application frame.
						/// </summary>
						/// <returns></returns>
						public extern static sap.ui.core.Element getDragControl();

						/// <summary>
						/// The valid drop target underneath the dragged control.
						/// </summary>
						/// <returns></returns>
						public extern static sap.ui.core.Element getDropControl();

						/// <summary>
						/// Returns the drop configuration corresponding to the drop control.
						/// </summary>
						/// <returns></returns>
						public extern static sap.ui.core.dnd.DropInfo getDropInfo();

						/// <summary>
						/// Returns the calculated position of the drop action relative to the valid dropped control.
						/// </summary>
						/// <returns></returns>
						public extern static string getDropPosition();

						/// <summary>
						/// Returns the drop indicator.
						/// </summary>
						/// <returns>Drop indicator's DOM reference</returns>
						public extern static dom.HTMLElement getIndicator();

						/// <summary>
						/// Returns the visual configuration of the drop indicator.
						/// </summary>
						/// <returns>Drop indicator configuration</returns>
						public extern static object getIndicatorConfig();

						/// <summary>
						/// Returns the data that has been set via <code>setTextData</code> method.
						/// </summary>
						/// <returns>Data</returns>
						public extern static string getTextData();

						/// <summary>
						/// Sets string data with any MIME type. <b>Note:</b> This works in all browsers, apart from Internet Explorer and Microsoft Edge. It also works if you navigate between different windows.
						/// </summary>
						/// <param name="sKey">The key of the data</param>
						/// <param name="sData">Data</param>
						public extern static void setData(string sKey, string sData);

						/// <summary>
						/// Set the valid drop control.
						/// </summary>
						public extern static void setDropControl();

						/// <summary>
						/// Defines the visual configuration of the drop indicator for the current <code>DropInfo</code>.
						/// </summary>
						/// <param name="mConfig">Custom styles of the drop indicator.</param>
						public extern static void setIndicatorConfig(object mConfig);

						/// <summary>
						/// Sets string data with plain text MIME type. <b>Note:</b> This works in all browsers, including Internet Explorer and Microsoft Edge. It also works if you navigate between different windows.
						/// </summary>
						/// <param name="sData">Data</param>
						public extern static void setTextData(string sData);

						#endregion

					}
				}
			}
		}
	}
}
