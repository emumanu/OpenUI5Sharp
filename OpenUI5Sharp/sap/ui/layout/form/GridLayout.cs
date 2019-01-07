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
					/// This <code>FormLayout</code> renders a <code>Form</code> using an HTML-table based grid. This can be a 16 column grid or an 8 column grid. The grid is stable, so the alignment of the fields is the same for all screen sizes or widths of the <code>Form</code>. Only the width of the single grid columns depends on the available width.
					/// 
					/// To adjust the appearance inside the <code>GridLayout</code>, you can use <code>GridContainerData</code> for <code>FormContainers</code> and <code>GridElementData</code> for content fields.
					/// 
					/// <b>Note:</b> If content fields have a <code>width</code> property this will be ignored, as the width of the controls is set by the grid cells.
					/// 
					/// This control cannot be used stand-alone, it just renders a <code>Form</code>, so it must be assigned to a <code>Form</code> using the <code>layout</code> aggregation.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.layout.form.GridLayout")]
					public partial class GridLayout : sap.ui.layout.form.FormLayout
					{
						#region Settings

						/// <summary>
						/// Settings class to create the object
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class Settings : sap.ui.layout.form.FormLayout.Settings
						{
							/// <summary>
							/// If set, the grid renders only one <code>FormContainer</code> per column. That means one <code>FormContainer</code> is below the other. The whole grid has 8 cells per row.
							/// 
							/// If not set, <code>FormContainer</code> can use the full width of the grid or two <code>FormContainers</code> can be placed beside each other. In this case the whole grid has 16 cells per row.
							/// </summary>
							public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> singleColumn;

						}

						#endregion

						#region Constructor

						/// <summary>
						/// Constructor for a new sap.ui.layout.form.GridLayout.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
						/// <param name="mSettings">Initial settings for the new control</param>
						public extern GridLayout(string sId, sap.ui.layout.form.GridLayout.Settings mSettings);

						/// <summary>
						/// Constructor for a new sap.ui.layout.form.GridLayout.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
						public extern GridLayout(string sId);

						/// <summary>
						/// Constructor for a new sap.ui.layout.form.GridLayout.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						public extern GridLayout();

						/// <summary>
						/// Constructor for a new sap.ui.layout.form.GridLayout.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="mSettings">Initial settings for the new control</param>
						public extern GridLayout(sap.ui.layout.form.GridLayout.Settings mSettings);

						#endregion

						#region Methods

						#region Methods for Property singleColumn

						/// <summary>
						/// Gets current value of property {@link #getSingleColumn singleColumn}.
						/// 
						/// If set, the grid renders only one <code>FormContainer</code> per column. That means one <code>FormContainer</code> is below the other. The whole grid has 8 cells per row.
						/// 
						/// If not set, <code>FormContainer</code> can use the full width of the grid or two <code>FormContainers</code> can be placed beside each other. In this case the whole grid has 16 cells per row.
						/// 
						/// Default value is <code>false</code>.
						/// </summary>
						/// <returns>Value of property <code>singleColumn</code></returns>
						public extern virtual bool getSingleColumn();

						/// <summary>
						/// Sets a new value for property {@link #getSingleColumn singleColumn}.
						/// 
						/// If set, the grid renders only one <code>FormContainer</code> per column. That means one <code>FormContainer</code> is below the other. The whole grid has 8 cells per row.
						/// 
						/// If not set, <code>FormContainer</code> can use the full width of the grid or two <code>FormContainers</code> can be placed beside each other. In this case the whole grid has 16 cells per row.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>false</code>.
						/// </summary>
						/// <param name="bSingleColumn">New value for property <code>singleColumn</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.GridLayout setSingleColumn(bool bSingleColumn);

						#endregion

						#region Other methods

						/// <summary>
						/// Creates a new subclass of class sap.ui.layout.form.GridLayout with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.layout.form.FormLayout.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.layout.form.GridLayout with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.layout.form.FormLayout.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.layout.form.GridLayout with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.layout.form.FormLayout.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns a metadata object for class sap.ui.layout.form.GridLayout.
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
