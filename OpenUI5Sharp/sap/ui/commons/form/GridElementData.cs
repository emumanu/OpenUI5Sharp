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
				public static partial class form
				{
					/// <summary>
					/// The grid specific layout data for FormElement fields. The width property of the elements is ignored since the width is defined by grid cells.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.commons.form.GridElementData")]
					[Obsolete("Deprecated since 1.16.0. moved to sap.ui.layout library. Please use this one.")]
					public partial class GridElementData : sap.ui.layout.form.GridElementData
					{
						#region Settings

						/// <summary>
						/// Settings class to create the object
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class Settings : sap.ui.layout.form.GridElementData.Settings
						{
						}

						#endregion

						#region Constructor

						/// <summary>
						/// Constructor for a new form/GridElementData.
						/// </summary>
						/// <param name="sId">id for the new control, generated automatically if no id is given</param>
						/// <param name="mSettings">initial settings for the new control</param>
						public extern GridElementData(string sId, sap.ui.commons.form.GridElementData.Settings mSettings);

						/// <summary>
						/// Constructor for a new form/GridElementData.
						/// </summary>
						/// <param name="sId">id for the new control, generated automatically if no id is given</param>
						public extern GridElementData(string sId);

						/// <summary>
						/// Constructor for a new form/GridElementData.
						/// </summary>
						public extern GridElementData();

						/// <summary>
						/// Constructor for a new form/GridElementData.
						/// </summary>
						/// <param name="mSettings">initial settings for the new control</param>
						public extern GridElementData(sap.ui.commons.form.GridElementData.Settings mSettings);

						#endregion

						#region Methods

						/// <summary>
						/// Creates a new subclass of class sap.ui.commons.form.GridElementData with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.layout.form.GridElementData.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.commons.form.GridElementData with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.layout.form.GridElementData.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.commons.form.GridElementData with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.layout.form.GridElementData.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns a metadata object for class sap.ui.commons.form.GridElementData.
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
