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
			public static partial class layout
			{
				public static partial class form
				{
					/// <summary>
					/// The <code>GridLayout</code>-specific layout data for <code>FormElement</code> fields.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.layout.form.GridElementData")]
					public partial class GridElementData : sap.ui.core.LayoutData
					{
						#region Settings

						/// <summary>
						/// Settings class to create the object
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class Settings : sap.ui.core.LayoutData.Settings
						{
							/// <summary>
							/// Number of cells in horizontal direction.
							/// 
							/// If set to <code>auto</code>, the size is determined by the number of fields and the available cells. For labels the auto size is 3 cells.
							/// 
							/// If set to <code>full</code>, only one field is allowed within the <code>FormElement</code>. It gets the full width of the row and the label is displayed above.
							/// 
							/// <b>Note:</b> For labels, the full size setting has no effect.
							/// </summary>
							public Union<string, string, sap.ui.@base.ManagedObject.BindPropertyInfo> hCells;

							/// <summary>
							/// Number of cells in vertical direction.
							/// 
							/// <b>Note:</b> This property has no effect on labels.
							/// </summary>
							public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> vCells;

						}

						#endregion

						#region Constructor

						/// <summary>
						/// Constructor for a new sap.ui.layout.form.GridElementData.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
						/// <param name="mSettings">Initial settings for the new control</param>
						public extern GridElementData(string sId, sap.ui.layout.form.GridElementData.Settings mSettings);

						/// <summary>
						/// Constructor for a new sap.ui.layout.form.GridElementData.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
						public extern GridElementData(string sId);

						/// <summary>
						/// Constructor for a new sap.ui.layout.form.GridElementData.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						public extern GridElementData();

						/// <summary>
						/// Constructor for a new sap.ui.layout.form.GridElementData.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="mSettings">Initial settings for the new control</param>
						public extern GridElementData(sap.ui.layout.form.GridElementData.Settings mSettings);

						#endregion

						#region Methods

						#region Methods for Property hCells

						/// <summary>
						/// Gets current value of property {@link #getHCells hCells}.
						/// 
						/// Number of cells in horizontal direction.
						/// 
						/// If set to <code>auto</code>, the size is determined by the number of fields and the available cells. For labels the auto size is 3 cells.
						/// 
						/// If set to <code>full</code>, only one field is allowed within the <code>FormElement</code>. It gets the full width of the row and the label is displayed above.
						/// 
						/// <b>Note:</b> For labels, the full size setting has no effect.
						/// 
						/// Default value is <code>auto</code>.
						/// </summary>
						/// <returns>Value of property <code>hCells</code></returns>
						public extern virtual string getHCells();

						/// <summary>
						/// Sets a new value for property {@link #getHCells hCells}.
						/// 
						/// Number of cells in horizontal direction.
						/// 
						/// If set to <code>auto</code>, the size is determined by the number of fields and the available cells. For labels the auto size is 3 cells.
						/// 
						/// If set to <code>full</code>, only one field is allowed within the <code>FormElement</code>. It gets the full width of the row and the label is displayed above.
						/// 
						/// <b>Note:</b> For labels, the full size setting has no effect.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>auto</code>.
						/// </summary>
						/// <param name="sHCells">New value for property <code>hCells</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.GridElementData setHCells(string sHCells);

						#endregion

						#region Methods for Property vCells

						/// <summary>
						/// Gets current value of property {@link #getVCells vCells}.
						/// 
						/// Number of cells in vertical direction.
						/// 
						/// <b>Note:</b> This property has no effect on labels.
						/// 
						/// Default value is <code>1</code>.
						/// </summary>
						/// <returns>Value of property <code>vCells</code></returns>
						public extern virtual int getVCells();

						/// <summary>
						/// Sets a new value for property {@link #getVCells vCells}.
						/// 
						/// Number of cells in vertical direction.
						/// 
						/// <b>Note:</b> This property has no effect on labels.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>1</code>.
						/// </summary>
						/// <param name="iVCells">New value for property <code>vCells</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.GridElementData setVCells(int iVCells);

						#endregion

						#region Other methods

						/// <summary>
						/// Creates a new subclass of class sap.ui.layout.form.GridElementData with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.LayoutData.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.layout.form.GridElementData with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.LayoutData.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.layout.form.GridElementData with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.LayoutData.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns a metadata object for class sap.ui.layout.form.GridElementData.
						/// </summary>
						/// <returns>Metadata object describing this class</returns>
						[Name("getMetadata")]
						public extern static sap.ui.@base.Metadata getMetadataStatic();

						#endregion

						#endregion

					}
				}
			}
		}
	}
}
