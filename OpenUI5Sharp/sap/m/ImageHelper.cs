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
				/// <param name="sImgId">UD of the image to be dealt with.</param>
				/// <param name="oImageControl">The image to update. If undefined, a new image will be created.</param>
				/// <param name="oParent">oImageControl's parentControl.</param>
				/// <param name="mProperties">Map object that contains key value pairs if image properties; the <code>src</code> property MUST be contained; the keys of the map must be names of image properties</param>
				/// <param name="aCssClassesToAdd">Array of CSS classes which will be added if the image needs to be created.</param>
				/// <param name="aCssClassesToRemove">All CSS classes that oImageControl has and which are contained in this array are removed before adding the CSS classes listed in aCssClassesToAdd.</param>
				/// <returns>the new or updated image control</returns>
				public extern static void getImageControl(string sImgId, sap.m.Image oImageControl, sap.ui.core.Control oParent, Map mProperties, object[] aCssClassesToAdd, object[] aCssClassesToRemove);

				#endregion

			}
		}
	}
}
