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
					/// The <code>ColumnLayout</code>-specific layout data for the <code>FormContainer</code> element.
					/// 
					/// Depending on its size, the <code>Form</code> control is divided into 1, 2, 3 or 4 columns by the <code>ColumnLayout</code> control. Using <code>ColumnContainerData</code>, the size of the <code>FormContainer</code> element can be influenced.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.layout.form.ColumnContainerData")]
					public partial class ColumnContainerData : sap.ui.core.LayoutData
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
							/// Number of columns the <code>FormContainer</code> element uses if the <code>Form</code> control has extra-large size.
							/// 
							/// The number of columns for extra-large size must not be smaller than the number of columns for large size.
							/// </summary>
							public Union<sap.ui.layout.form.ColumnsXL, string, sap.ui.@base.ManagedObject.BindPropertyInfo> columnsXL;

							/// <summary>
							/// Number of columns the <code>FormContainer</code> element uses if the <code>Form</code> control has large size.
							/// 
							/// The number of columns for large size must not be smaller than the number of columns for medium size.
							/// </summary>
							public Union<sap.ui.layout.form.ColumnsL, string, sap.ui.@base.ManagedObject.BindPropertyInfo> columnsL;

							/// <summary>
							/// Number of columns the <code>FormContainer</code> element uses if the <code>Form</code> control has medium size.
							/// </summary>
							public Union<sap.ui.layout.form.ColumnsM, string, sap.ui.@base.ManagedObject.BindPropertyInfo> columnsM;

						}

						#endregion

						#region Constructor

						/// <summary>
						/// Constructor for a new sap.ui.layout.form.ColumnContainerData.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
						/// <param name="mSettings">Initial settings for the new control</param>
						public extern ColumnContainerData(string sId, sap.ui.layout.form.ColumnContainerData.Settings mSettings);

						/// <summary>
						/// Constructor for a new sap.ui.layout.form.ColumnContainerData.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
						public extern ColumnContainerData(string sId);

						/// <summary>
						/// Constructor for a new sap.ui.layout.form.ColumnContainerData.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						public extern ColumnContainerData();

						/// <summary>
						/// Constructor for a new sap.ui.layout.form.ColumnContainerData.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="mSettings">Initial settings for the new control</param>
						public extern ColumnContainerData(sap.ui.layout.form.ColumnContainerData.Settings mSettings);

						#endregion

						#region Methods

						#region Methods for Property columnsXL

						/// <summary>
						/// Gets current value of property {@link #getColumnsXL columnsXL}.
						/// 
						/// Number of columns the <code>FormContainer</code> element uses if the <code>Form</code> control has extra-large size.
						/// 
						/// The number of columns for extra-large size must not be smaller than the number of columns for large size.
						/// 
						/// Default value is <code>2</code>.
						/// </summary>
						/// <returns>Value of property <code>columnsXL</code></returns>
						public extern virtual sap.ui.layout.form.ColumnsXL getColumnsXL();

						/// <summary>
						/// Sets a new value for property {@link #getColumnsXL columnsXL}.
						/// 
						/// Number of columns the <code>FormContainer</code> element uses if the <code>Form</code> control has extra-large size.
						/// 
						/// The number of columns for extra-large size must not be smaller than the number of columns for large size.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>2</code>.
						/// </summary>
						/// <param name="sColumnsXL">New value for property <code>columnsXL</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.ColumnContainerData setColumnsXL(sap.ui.layout.form.ColumnsXL sColumnsXL);

						#endregion

						#region Methods for Property columnsL

						/// <summary>
						/// Gets current value of property {@link #getColumnsL columnsL}.
						/// 
						/// Number of columns the <code>FormContainer</code> element uses if the <code>Form</code> control has large size.
						/// 
						/// The number of columns for large size must not be smaller than the number of columns for medium size.
						/// 
						/// Default value is <code>2</code>.
						/// </summary>
						/// <returns>Value of property <code>columnsL</code></returns>
						public extern virtual sap.ui.layout.form.ColumnsL getColumnsL();

						/// <summary>
						/// Sets a new value for property {@link #getColumnsL columnsL}.
						/// 
						/// Number of columns the <code>FormContainer</code> element uses if the <code>Form</code> control has large size.
						/// 
						/// The number of columns for large size must not be smaller than the number of columns for medium size.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>2</code>.
						/// </summary>
						/// <param name="sColumnsL">New value for property <code>columnsL</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.ColumnContainerData setColumnsL(sap.ui.layout.form.ColumnsL sColumnsL);

						#endregion

						#region Methods for Property columnsM

						/// <summary>
						/// Gets current value of property {@link #getColumnsM columnsM}.
						/// 
						/// Number of columns the <code>FormContainer</code> element uses if the <code>Form</code> control has medium size.
						/// 
						/// Default value is <code>1</code>.
						/// </summary>
						/// <returns>Value of property <code>columnsM</code></returns>
						public extern virtual sap.ui.layout.form.ColumnsM getColumnsM();

						/// <summary>
						/// Sets a new value for property {@link #getColumnsM columnsM}.
						/// 
						/// Number of columns the <code>FormContainer</code> element uses if the <code>Form</code> control has medium size.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>1</code>.
						/// </summary>
						/// <param name="sColumnsM">New value for property <code>columnsM</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.ColumnContainerData setColumnsM(sap.ui.layout.form.ColumnsM sColumnsM);

						#endregion

						#region Other methods

						/// <summary>
						/// Creates a new subclass of class sap.ui.layout.form.ColumnContainerData with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.LayoutData.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.layout.form.ColumnContainerData with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.LayoutData.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.layout.form.ColumnContainerData with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.LayoutData.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns a metadata object for class sap.ui.layout.form.ColumnContainerData.
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
