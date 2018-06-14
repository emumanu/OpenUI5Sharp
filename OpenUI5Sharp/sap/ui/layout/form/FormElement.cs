using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace OpenUI5Sharp
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
					/// A <code>FormElement</code> represents a row in a <code>FormContainer</code>. A <code>FormElement</code> is a combination of one label and different controls associated to this label.
					/// </summary>
					[External]
					[Namespace(false)]
					public partial class FormElement : sap.ui.core.Element
					{
						#region Settings

						/// <summary>
						/// Settings class to create the object
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class Settings : sap.ui.core.Element.Settings
						{
							/// <summary>
							/// If set to <code>false</code>, the <code>FormElement</code> is not rendered.
							/// </summary>
							public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> visible;

							/// <summary>
							/// Label of the fields. Can either be a <code>Label</code> control or a string. If a <code>Label</code> control is used, the properties of the <code>Label</code> can be set. If no assignment between <code>Label</code> and the fields is set via (<code>labelFor</code> property of the <code>Label</code>), it will be done automatically by the <code>FormElement</code>. In this case the <code>Label</code> is assigned to the fields of the <code>FormElement</code>.
							/// </summary>
							public Union<sap.ui.core.Label, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> label;

							/// <summary>
							/// Form controls that belong together to be displayed in one row of a <code>Form</code>.
							/// 
							/// <b>Warning:</b> Do not put any layout or other container controls in here. This could damage the visual layout, keyboard support and screen-reader support. Only form controls are allowed. Views are also not supported. Allowed controls implement the interface <code>sap.ui.core.IFormContent</code>.
							/// </summary>
							public Union<sap.ui.core.Control[], string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> fields;

						}

						#endregion

						#region Constructor

						/// <summary>
						/// Constructor for a new sap.ui.layout.form.FormElement.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
						/// <param name="mSettings">Initial settings for the new control</param>
						public extern FormElement(string sId, sap.ui.layout.form.FormElement.Settings mSettings);

						/// <summary>
						/// Constructor for a new sap.ui.layout.form.FormElement.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
						public extern FormElement(string sId);

						/// <summary>
						/// Constructor for a new sap.ui.layout.form.FormElement.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						public extern FormElement();

						/// <summary>
						/// Constructor for a new sap.ui.layout.form.FormElement.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="mSettings">Initial settings for the new control</param>
						public extern FormElement(sap.ui.layout.form.FormElement.Settings mSettings);

						#endregion

						#region Methods

						#region Methods for Property visible

						/// <summary>
						/// Gets current value of property {@link #getVisible visible}.
						/// 
						/// If set to <code>false</code>, the <code>FormElement</code> is not rendered.
						/// 
						/// Default value is <code>true</code>.
						/// </summary>
						/// <returns>Value of property <code>visible</code></returns>
						public extern virtual bool getVisible();

						/// <summary>
						/// Sets a new value for property {@link #getVisible visible}.
						/// 
						/// If set to <code>false</code>, the <code>FormElement</code> is not rendered.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>true</code>.
						/// </summary>
						/// <param name="bVisible">New value for property <code>visible</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.FormElement setVisible(bool bVisible);

						#endregion

						#region Methods for Aggregation label

						/// <summary>
						/// Gets content of aggregation {@link #getLabel label}.
						/// 
						/// Label of the fields. Can either be a <code>Label</code> control or a string. If a <code>Label</code> control is used, the properties of the <code>Label</code> can be set. If no assignment between <code>Label</code> and the fields is set via (<code>labelFor</code> property of the <code>Label</code>), it will be done automatically by the <code>FormElement</code>. In this case the <code>Label</code> is assigned to the fields of the <code>FormElement</code>.
						/// </summary>
						/// <returns></returns>
						public extern virtual Union<sap.ui.core.Label, string> getLabel();

						/// <summary>
						/// Destroys the label in the aggregation {@link #getLabel label}.
						/// </summary>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.FormElement destroyLabel();

						/// <summary>
						/// Sets the aggregated {@link #getLabel label}.
						/// </summary>
						/// <param name="vLabel">The label to set</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.FormElement setLabel(Union<sap.ui.core.Label, string> vLabel);

						#endregion

						#region Methods for Aggregation _label

						#endregion

						#region Methods for Aggregation fields

						/// <summary>
						/// Gets content of aggregation {@link #getFields fields}.
						/// 
						/// Form controls that belong together to be displayed in one row of a <code>Form</code>.
						/// 
						/// <b>Warning:</b> Do not put any layout or other container controls in here. This could damage the visual layout, keyboard support and screen-reader support. Only form controls are allowed. Views are also not supported. Allowed controls implement the interface <code>sap.ui.core.IFormContent</code>.
						/// </summary>
						/// <returns></returns>
						public extern virtual sap.ui.core.Control[] getFields();

						/// <summary>
						/// Destroys all the fields in the aggregation {@link #getFields fields}.
						/// </summary>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.FormElement destroyFields();

						/// <summary>
						/// Inserts a field into the aggregation {@link #getFields fields}.
						/// </summary>
						/// <param name="oField">The field to insert; if empty, nothing is inserted</param>
						/// <param name="iIndex">The <code>0</code>-based index the field should be inserted at; for a negative value of <code>iIndex</code>, the field is inserted at position 0; for a value greater than the current size of the aggregation, the field is inserted at the last position</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.FormElement insertField(sap.ui.core.Control oField, int iIndex);

						/// <summary>
						/// Adds some field to the aggregation {@link #getFields fields}.
						/// </summary>
						/// <param name="oField">The field to add; if empty, nothing is inserted</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.FormElement addField(sap.ui.core.Control oField);

						/// <summary>
						/// Removes a field from the aggregation {@link #getFields fields}.
						/// </summary>
						/// <param name="vField">The field to remove or its index or id</param>
						/// <returns>The removed field or <code>null</code></returns>
						public extern virtual sap.ui.core.Control removeField(Union<int, string, sap.ui.core.Control> vField);

						/// <summary>
						/// Checks for the provided <code>sap.ui.core.Control</code> in the aggregation {@link #getFields fields}. and returns its index if found or -1 otherwise.
						/// </summary>
						/// <param name="oField">The field whose index is looked for</param>
						/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
						public extern virtual int indexOfField(sap.ui.core.Control oField);

						/// <summary>
						/// Removes all the controls from the aggregation {@link #getFields fields}.
						/// 
						/// Additionally, it unregisters them from the hosting UIArea.
						/// </summary>
						/// <returns>An array of the removed elements (might be empty)</returns>
						public extern virtual sap.ui.core.Control[] removeAllFields();

						#endregion

						#region Other methods

						/// <summary>
						/// Creates a new subclass of class sap.ui.layout.form.FormElement with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.layout.form.FormElement with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.layout.form.FormElement with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns the <code>Label</code> of the <code>FormElement</code>, even if the <code>Label</code> is assigned as string. The <code>FormLayout</code> needs the information of the label to render the <code>Form</code>.
						/// </summary>
						/// <returns><code>Label</code> control used to render the label</returns>
						public extern virtual sap.ui.core.Label getLabelControl();

						/// <summary>
						/// Returns a metadata object for class sap.ui.layout.form.FormElement.
						/// </summary>
						/// <returns>Metadata object describing this class</returns>
						public extern static sap.ui.@base.Metadata getMetadata();

						/// <summary>
						/// Determines if the <code>FormElement</code> is visible or not. Per default it just returns the value of the <code>visible</code> property. But this might be overwritten by inherited elements.
						/// 
						/// For rendering by <code>FormLayouts</code> this function has to be used instead of <code>getVisible</code>.
						/// </summary>
						/// <returns>If true, the <code>FormElement</code> is visible, otherwise not</returns>
						public extern virtual bool isVisible();

						#endregion

						#endregion

					}
				}
			}
		}
	}
}
