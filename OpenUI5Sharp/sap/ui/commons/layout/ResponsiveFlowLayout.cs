using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public static partial class sap
	{
		public static partial class ui
		{
			public static partial class commons
			{
				public static partial class layout
				{
					/// <summary>
					/// This is a layout where several controls can be added. These controls are blown up to fit a whole line. If the window resizes the controls are moved between the lines and resized again.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.commons.layout.ResponsiveFlowLayout")]
					[Obsolete("Deprecated since 1.16.0. moved to sap.ui.layout library. Please use this one.")]
					public partial class ResponsiveFlowLayout : sap.ui.layout.ResponsiveFlowLayout
					{
						#region Settings

						/// <summary>
						/// Settings class to create the object
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class Settings : sap.ui.layout.ResponsiveFlowLayout.Settings
						{
						}

						#endregion

						#region Constructor

						/// <summary>
						/// Constructor for a new layout/ResponsiveFlowLayout.
						/// </summary>
						/// <param name="sId">id for the new control, generated automatically if no id is given</param>
						/// <param name="mSettings">initial settings for the new control</param>
						public extern ResponsiveFlowLayout(string sId, sap.ui.commons.layout.ResponsiveFlowLayout.Settings mSettings);

						/// <summary>
						/// Constructor for a new layout/ResponsiveFlowLayout.
						/// </summary>
						/// <param name="sId">id for the new control, generated automatically if no id is given</param>
						public extern ResponsiveFlowLayout(string sId);

						/// <summary>
						/// Constructor for a new layout/ResponsiveFlowLayout.
						/// </summary>
						public extern ResponsiveFlowLayout();

						/// <summary>
						/// Constructor for a new layout/ResponsiveFlowLayout.
						/// </summary>
						/// <param name="mSettings">initial settings for the new control</param>
						public extern ResponsiveFlowLayout(sap.ui.commons.layout.ResponsiveFlowLayout.Settings mSettings);

						#endregion

						#region Methods

						/// <summary>
						/// Creates a new subclass of class sap.ui.commons.layout.ResponsiveFlowLayout with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.layout.ResponsiveFlowLayout.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.commons.layout.ResponsiveFlowLayout with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.layout.ResponsiveFlowLayout.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.commons.layout.ResponsiveFlowLayout with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.layout.ResponsiveFlowLayout.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns a metadata object for class sap.ui.commons.layout.ResponsiveFlowLayout.
						/// </summary>
						/// <returns>Metadata object describing this class</returns>
						[Name("getMetadata")]
						public extern static sap.ui.@base.Metadata getMetadataStatic();

						#endregion

					}
				}
			}
		}
	}
}
