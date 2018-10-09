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
			/// Helper for Images.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.ImageHelper")]
			public static partial class ImageHelper
			{
				#region Methods

				/// <summary>
				/// Creates or updates an image control.
				/// </summary>
				/// <param name="sImgId">id of the image to be dealt with.</param>
				/// <param name="oImageControl">the image to update. If undefined, a new image will be created.</param>
				/// <param name="oParent">oImageControl's parentControl.</param>
				/// <param name="mProperties">map object that contains key value pairs if image propeties. The 'src' property MUST be contained. Also the map's keys must be names of image properties</param>
				/// <param name="aCssClassesToAdd">array of css classes which will be added if the image needs to be created.</param>
				/// <param name="aCssClassesToRemove">all css clases that oImageControl has and which are contained in this array are removed bevore adding the css classes listed in aCssClassesToAdd.</param>
				/// <returns>the new or updated image control</returns>
				public extern static void getImageControl(string sImgId, sap.m.Image oImageControl, sap.ui.core.Control oParent, Map mProperties, object[] aCssClassesToAdd, object[] aCssClassesToRemove);

				#endregion

			}
		}
	}
}
