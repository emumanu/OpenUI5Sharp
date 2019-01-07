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
					/// This Layout implements a guideline 2.0 grid. This can be a 16 column grid or an 8 column grid.
					/// 
					/// To adjust the content inside the GridLayout GridContainerData and GridElementData could be used.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.commons.form.GridLayout")]
					[Obsolete("Deprecated since 1.16.0. moved to sap.ui.layout library. Please use this one.")]
					public partial class GridLayout : sap.ui.layout.form.GridLayout
					{
						#region Settings

						/// <summary>
						/// Settings class to create the object
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class Settings : sap.ui.layout.form.GridLayout.Settings
						{
						}

						#endregion

						#region Constructor

						/// <summary>
						/// Constructor for a new form/GridLayout.
						/// </summary>
						/// <param name="sId">id for the new control, generated automatically if no id is given</param>
						/// <param name="mSettings">initial settings for the new control</param>
						public extern GridLayout(string sId, sap.ui.commons.form.GridLayout.Settings mSettings);

						/// <summary>
						/// Constructor for a new form/GridLayout.
						/// </summary>
						/// <param name="sId">id for the new control, generated automatically if no id is given</param>
						public extern GridLayout(string sId);

						/// <summary>
						/// Constructor for a new form/GridLayout.
						/// </summary>
						public extern GridLayout();

						/// <summary>
						/// Constructor for a new form/GridLayout.
						/// </summary>
						/// <param name="mSettings">initial settings for the new control</param>
						public extern GridLayout(sap.ui.commons.form.GridLayout.Settings mSettings);

						#endregion

						#region Methods

						/// <summary>
						/// Creates a new subclass of class sap.ui.commons.form.GridLayout with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.layout.form.GridLayout.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.commons.form.GridLayout with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.layout.form.GridLayout.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.commons.form.GridLayout with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.layout.form.GridLayout.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns a metadata object for class sap.ui.commons.form.GridLayout.
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
