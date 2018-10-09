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
					/// This is a LayoutData Element that can be added to a control if this control is used within a ResponsiveFlowLayout
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.commons.layout.ResponsiveFlowLayoutData")]
					[Obsolete("Deprecated since 1.16.0. moved to sap.ui.layout library. Please use this one.")]
					public partial class ResponsiveFlowLayoutData : sap.ui.layout.ResponsiveFlowLayoutData
					{
						#region Settings

						/// <summary>
						/// Settings class to create the object
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class Settings : sap.ui.layout.ResponsiveFlowLayoutData.Settings
						{
						}

						#endregion

						#region Constructor

						/// <summary>
						/// Constructor for a new layout/ResponsiveFlowLayoutData.
						/// </summary>
						/// <param name="sId">id for the new control, generated automatically if no id is given</param>
						/// <param name="mSettings">initial settings for the new control</param>
						public extern ResponsiveFlowLayoutData(string sId, sap.ui.commons.layout.ResponsiveFlowLayoutData.Settings mSettings);

						/// <summary>
						/// Constructor for a new layout/ResponsiveFlowLayoutData.
						/// </summary>
						/// <param name="sId">id for the new control, generated automatically if no id is given</param>
						public extern ResponsiveFlowLayoutData(string sId);

						/// <summary>
						/// Constructor for a new layout/ResponsiveFlowLayoutData.
						/// </summary>
						public extern ResponsiveFlowLayoutData();

						/// <summary>
						/// Constructor for a new layout/ResponsiveFlowLayoutData.
						/// </summary>
						/// <param name="mSettings">initial settings for the new control</param>
						public extern ResponsiveFlowLayoutData(sap.ui.commons.layout.ResponsiveFlowLayoutData.Settings mSettings);

						#endregion

						#region Methods

						/// <summary>
						/// Creates a new subclass of class sap.ui.commons.layout.ResponsiveFlowLayoutData with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.layout.ResponsiveFlowLayoutData.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.commons.layout.ResponsiveFlowLayoutData with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.layout.ResponsiveFlowLayoutData.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.commons.layout.ResponsiveFlowLayoutData with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.layout.ResponsiveFlowLayoutData.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Getter for property <code>margin</code>. This property prevents any margin of the element if set to false
						/// 
						/// Default value is <code>true</code>
						/// </summary>
						/// <returns>the value of property <code>margin</code></returns>
						public extern override bool getMargin();

						/// <summary>
						/// Returns a metadata object for class sap.ui.commons.layout.ResponsiveFlowLayoutData.
						/// </summary>
						/// <returns>Metadata object describing this class</returns>
						public extern static sap.ui.@base.Metadata getMetadata();

						/// <summary>
						/// Setter for property <code>margin</code>.
						/// 
						/// Default value is <code>true</code>
						/// </summary>
						/// <param name="bMargin">new value for property <code>margin</code></param>
						/// <returns><code>this</code> to allow method chaining</returns>
						public extern override sap.ui.layout.ResponsiveFlowLayoutData setMargin(bool bMargin);

						#endregion

					}
				}
			}
		}
	}
}
