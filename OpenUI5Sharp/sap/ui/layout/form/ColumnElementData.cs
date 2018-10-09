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
					/// The <code>ColumnLayout</code>-specific layout data for the <code>FormElement</code> content fields.
					/// 
					/// One <code>FormElement</code> element contains 12 cells and has two sizes, small and large. Using <code>ColumnElementData</code>, the default calculation of the cells used for a field or label can be overwritten.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.layout.form.ColumnElementData")]
					public partial class ColumnElementData : sap.ui.core.LayoutData
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
							/// Number of cells used by a field if the <code>FormElement</code> element is large. The label is then beside the fields per default.
							/// 
							/// If set to <code>12</code>, the full size of the <code>FormElement</code> element is used.
							/// </summary>
							public Union<sap.ui.layout.form.ColumnCells, string, sap.ui.@base.ManagedObject.BindPropertyInfo> cellsLarge;

							/// <summary>
							/// Number of cells used by a field if the <code>FormElement</code> element is small. The label is then above the fields per default.
							/// 
							/// If set to <code>12</code>, the full size of the <code>FormElement</code> is used.
							/// </summary>
							public Union<sap.ui.layout.form.ColumnCells, string, sap.ui.@base.ManagedObject.BindPropertyInfo> cellsSmall;

						}

						#endregion

						#region Constructor

						/// <summary>
						/// Constructor for a new sap.ui.layout.form.ColumnElementData.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
						/// <param name="mSettings">Initial settings for the new control</param>
						public extern ColumnElementData(string sId, sap.ui.layout.form.ColumnElementData.Settings mSettings);

						/// <summary>
						/// Constructor for a new sap.ui.layout.form.ColumnElementData.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
						public extern ColumnElementData(string sId);

						/// <summary>
						/// Constructor for a new sap.ui.layout.form.ColumnElementData.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						public extern ColumnElementData();

						/// <summary>
						/// Constructor for a new sap.ui.layout.form.ColumnElementData.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="mSettings">Initial settings for the new control</param>
						public extern ColumnElementData(sap.ui.layout.form.ColumnElementData.Settings mSettings);

						#endregion

						#region Methods

						#region Methods for Property cellsLarge

						/// <summary>
						/// Gets current value of property {@link #getCellsLarge cellsLarge}.
						/// 
						/// Number of cells used by a field if the <code>FormElement</code> element is large. The label is then beside the fields per default.
						/// 
						/// If set to <code>12</code>, the full size of the <code>FormElement</code> element is used.
						/// 
						/// Default value is <code>8</code>.
						/// </summary>
						/// <returns>Value of property <code>cellsLarge</code></returns>
						public extern virtual sap.ui.layout.form.ColumnCells getCellsLarge();

						/// <summary>
						/// Sets a new value for property {@link #getCellsLarge cellsLarge}.
						/// 
						/// Number of cells used by a field if the <code>FormElement</code> element is large. The label is then beside the fields per default.
						/// 
						/// If set to <code>12</code>, the full size of the <code>FormElement</code> element is used.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>8</code>.
						/// </summary>
						/// <param name="sCellsLarge">New value for property <code>cellsLarge</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.ColumnElementData setCellsLarge(sap.ui.layout.form.ColumnCells sCellsLarge);

						#endregion

						#region Methods for Property cellsSmall

						/// <summary>
						/// Gets current value of property {@link #getCellsSmall cellsSmall}.
						/// 
						/// Number of cells used by a field if the <code>FormElement</code> element is small. The label is then above the fields per default.
						/// 
						/// If set to <code>12</code>, the full size of the <code>FormElement</code> is used.
						/// 
						/// Default value is <code>12</code>.
						/// </summary>
						/// <returns>Value of property <code>cellsSmall</code></returns>
						public extern virtual sap.ui.layout.form.ColumnCells getCellsSmall();

						/// <summary>
						/// Sets a new value for property {@link #getCellsSmall cellsSmall}.
						/// 
						/// Number of cells used by a field if the <code>FormElement</code> element is small. The label is then above the fields per default.
						/// 
						/// If set to <code>12</code>, the full size of the <code>FormElement</code> is used.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>12</code>.
						/// </summary>
						/// <param name="sCellsSmall">New value for property <code>cellsSmall</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.ColumnElementData setCellsSmall(sap.ui.layout.form.ColumnCells sCellsSmall);

						#endregion

						#region Other methods

						/// <summary>
						/// Creates a new subclass of class sap.ui.layout.form.ColumnElementData with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.LayoutData.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.layout.form.ColumnElementData with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.LayoutData.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.layout.form.ColumnElementData with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.LayoutData.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns a metadata object for class sap.ui.layout.form.ColumnElementData.
						/// </summary>
						/// <returns>Metadata object describing this class</returns>
						public extern static sap.ui.@base.Metadata getMetadata();

						#endregion

						#endregion

					}
				}
			}
		}
	}
}
