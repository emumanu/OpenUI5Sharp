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
					/// A <code>Form</code> control arranges labels and fields (like input fields) into groups and rows. There are different ways to visualize forms for different screen sizes.
					/// 
					/// A <code>Form</code> is structured into <code>FormContainers</code>. Each <code>FormContainer</code> consists of <code>FormElements</code>. The <code>FormElements</code> consists of a label and the form fields. A <code>Form</code> doesn't render its content by itself. The rendering is done by the assigned <code>FormLayout</code>. This is so that the rendering can be adopted to new UI requirements without changing the <code>Form</code> itself.
					/// 
					/// For the content of a <code>Form</code>, <code>VariantLayoutData</code> are supported to allow simple switching of the <code>FormLayout</code>. <code>LayoutData</code> on the content can be used to overwrite the default layout of the <code>Form</code>.
					/// 
					/// The <code>Form</code> (and its sub-controls) automatically add label and field assignment to enable screen reader support. It also adds keyboard support to navigate between the fields and groups inside the form.
					/// 
					/// <b>Warning:</b> Do not put any layout or other container controls into the <code>FormElement</code>. Views are also not supported. This could damage the visual layout, keyboard support and screen-reader support.
					/// 
					/// If editable controls are used as content, the <code>editable</code> property must be set to <code>true</code>, otherwise to <code>false</code>. If the <code>editable</code> property is set incorrectly, there will be visual issues like wrong label alignment or wrong spacing between the controls.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.layout.form.Form")]
					public partial class Form : sap.ui.core.Control
					{
						#region Settings

						/// <summary>
						/// Settings class to create the object
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class Settings : sap.ui.core.Control.Settings
						{
							/// <summary>
							/// Width of the <code>Form</code>.
							/// </summary>
							public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> width;

							/// <summary>
							/// Applies a device-specific and theme-specific line height and label alignment to the form rows if the form has editable content. If set, all (not only the editable) rows of the form will get the line height of editable fields.
							/// 
							/// The labels inside the form will be rendered by default in the according mode.
							/// 
							/// <b>Note:</b> The setting of this property does not change the content of the form. For example, <code>Input</code> controls in a form with <code>editable</code> set to false are still editable.
							/// 
							/// <b>Warning:</b> If this property is wrongly set, this might lead to visual issues. The labels and fields might be misaligned, the labels might be rendered in the wrong mode, and the spacing between the single controls might be wrong. Also, controls that do not fit the mode might be rendered incorrectly.
							/// </summary>
							public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> editable;

							/// <summary>
							/// Containers with the content of the form. A <code>FormContainer</code> represents a group inside the <code>Form</code>.
							/// </summary>
							public Union<sap.ui.layout.form.FormContainer[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> formContainers;

							/// <summary>
							/// Title of the <code>Form</code>. Can either be a <code>Title</code> element or a string. If a <code>Title</code> element it used, the style of the title can be set.
							/// 
							/// <b>Note:</b> If a <code>Toolbar</code> is used, the <code>Title</code> is ignored.
							/// </summary>
							public Union<sap.ui.core.Title, string, sap.ui.@base.ManagedObject.BindAggregationInfo> title;

							/// <summary>
							/// Toolbar of the <code>Form</code>.
							/// 
							/// <b>Note:</b> If a <code>Toolbar</code> is used, the <code>Title</code> is ignored. If a title is needed inside the <code>Toolbar</code> it must be added at content to the <code>Toolbar</code>. In this case add the <code>Title</code> to the <code>ariaLabelledBy</code> association.
							/// </summary>
							public Union<sap.ui.core.Toolbar, string, sap.ui.@base.ManagedObject.BindAggregationInfo> toolbar;

							/// <summary>
							/// Layout of the <code>Form</code>. The assigned <code>Layout</code> renders the <code>Form</code>. We recommend using the <code>ResponsiveGridLayout</code> for rendering a <code>Form</code>, as its responsiveness allows the available space to be used in the best way possible.
							/// </summary>
							public Union<sap.ui.layout.form.FormLayout, string, sap.ui.@base.ManagedObject.BindAggregationInfo> layout;

							/// <summary>
							/// Association to controls / IDs that label this control (see WAI-ARIA attribute <code>aria-labelledby</code>).
							/// </summary>
							public Union<sap.ui.core.Control, sap.ui.core.ID[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> ariaLabelledBy;

						}

						#endregion

						#region Constructor

						/// <summary>
						/// Constructor for a new sap.ui.layout.form.Form.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
						/// <param name="mSettings">Initial settings for the new control</param>
						public extern Form(string sId, sap.ui.layout.form.Form.Settings mSettings);

						/// <summary>
						/// Constructor for a new sap.ui.layout.form.Form.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
						public extern Form(string sId);

						/// <summary>
						/// Constructor for a new sap.ui.layout.form.Form.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						public extern Form();

						/// <summary>
						/// Constructor for a new sap.ui.layout.form.Form.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="mSettings">Initial settings for the new control</param>
						public extern Form(sap.ui.layout.form.Form.Settings mSettings);

						#endregion

						#region Methods

						#region Methods for Property width

						/// <summary>
						/// Gets current value of property {@link #getWidth width}.
						/// 
						/// Width of the <code>Form</code>.
						/// </summary>
						/// <returns>Value of property <code>width</code></returns>
						public extern virtual sap.ui.core.CSSSize getWidth();

						/// <summary>
						/// Sets a new value for property {@link #getWidth width}.
						/// 
						/// Width of the <code>Form</code>.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// </summary>
						/// <param name="sWidth">New value for property <code>width</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.Form setWidth(sap.ui.core.CSSSize sWidth);

						#endregion

						#region Methods for Property editable

						/// <summary>
						/// Gets current value of property {@link #getEditable editable}.
						/// 
						/// Applies a device-specific and theme-specific line height and label alignment to the form rows if the form has editable content. If set, all (not only the editable) rows of the form will get the line height of editable fields.
						/// 
						/// The labels inside the form will be rendered by default in the according mode.
						/// 
						/// <b>Note:</b> The setting of this property does not change the content of the form. For example, <code>Input</code> controls in a form with <code>editable</code> set to false are still editable.
						/// 
						/// <b>Warning:</b> If this property is wrongly set, this might lead to visual issues. The labels and fields might be misaligned, the labels might be rendered in the wrong mode, and the spacing between the single controls might be wrong. Also, controls that do not fit the mode might be rendered incorrectly.
						/// 
						/// Default value is <code>false</code>.
						/// </summary>
						/// <returns>Value of property <code>editable</code></returns>
						public extern virtual bool getEditable();

						/// <summary>
						/// Sets a new value for property {@link #getEditable editable}.
						/// 
						/// Applies a device-specific and theme-specific line height and label alignment to the form rows if the form has editable content. If set, all (not only the editable) rows of the form will get the line height of editable fields.
						/// 
						/// The labels inside the form will be rendered by default in the according mode.
						/// 
						/// <b>Note:</b> The setting of this property does not change the content of the form. For example, <code>Input</code> controls in a form with <code>editable</code> set to false are still editable.
						/// 
						/// <b>Warning:</b> If this property is wrongly set, this might lead to visual issues. The labels and fields might be misaligned, the labels might be rendered in the wrong mode, and the spacing between the single controls might be wrong. Also, controls that do not fit the mode might be rendered incorrectly.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>false</code>.
						/// </summary>
						/// <param name="bEditable">New value for property <code>editable</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.Form setEditable(bool bEditable);

						#endregion

						#region Methods for Aggregation formContainers

						/// <summary>
						/// Gets content of aggregation {@link #getFormContainers formContainers}.
						/// 
						/// Containers with the content of the form. A <code>FormContainer</code> represents a group inside the <code>Form</code>.
						/// </summary>
						/// <returns></returns>
						public extern virtual sap.ui.layout.form.FormContainer[] getFormContainers();

						/// <summary>
						/// Destroys all the formContainers in the aggregation {@link #getFormContainers formContainers}.
						/// </summary>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.Form destroyFormContainers();

						/// <summary>
						/// Inserts a formContainer into the aggregation {@link #getFormContainers formContainers}.
						/// </summary>
						/// <param name="oFormContainer">The formContainer to insert; if empty, nothing is inserted</param>
						/// <param name="iIndex">The <code>0</code>-based index the formContainer should be inserted at; for a negative value of <code>iIndex</code>, the formContainer is inserted at position 0; for a value greater than the current size of the aggregation, the formContainer is inserted at the last position</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.Form insertFormContainer(sap.ui.layout.form.FormContainer oFormContainer, int iIndex);

						/// <summary>
						/// Adds some formContainer to the aggregation {@link #getFormContainers formContainers}.
						/// </summary>
						/// <param name="oFormContainer">The formContainer to add; if empty, nothing is inserted</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.Form addFormContainer(sap.ui.layout.form.FormContainer oFormContainer);

						/// <summary>
						/// Removes a formContainer from the aggregation {@link #getFormContainers formContainers}.
						/// </summary>
						/// <param name="vFormContainer">The formContainer to remove or its index or id</param>
						/// <returns>The removed formContainer or <code>null</code></returns>
						public extern virtual sap.ui.layout.form.FormContainer removeFormContainer(Union<int, string, sap.ui.layout.form.FormContainer> vFormContainer);

						/// <summary>
						/// Checks for the provided <code>sap.ui.layout.form.FormContainer</code> in the aggregation {@link #getFormContainers formContainers}. and returns its index if found or -1 otherwise.
						/// </summary>
						/// <param name="oFormContainer">The formContainer whose index is looked for</param>
						/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
						public extern virtual int indexOfFormContainer(sap.ui.layout.form.FormContainer oFormContainer);

						/// <summary>
						/// Removes all the controls from the aggregation {@link #getFormContainers formContainers}.
						/// 
						/// Additionally, it unregisters them from the hosting UIArea.
						/// </summary>
						/// <returns>An array of the removed elements (might be empty)</returns>
						public extern virtual sap.ui.layout.form.FormContainer[] removeAllFormContainers();

						#endregion

						#region Methods for Aggregation title

						/// <summary>
						/// Gets content of aggregation {@link #getTitle title}.
						/// 
						/// Title of the <code>Form</code>. Can either be a <code>Title</code> element or a string. If a <code>Title</code> element it used, the style of the title can be set.
						/// 
						/// <b>Note:</b> If a <code>Toolbar</code> is used, the <code>Title</code> is ignored.
						/// </summary>
						/// <returns></returns>
						public extern virtual Union<sap.ui.core.Title, string> getTitle();

						/// <summary>
						/// Destroys the title in the aggregation {@link #getTitle title}.
						/// </summary>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.Form destroyTitle();

						/// <summary>
						/// Sets the aggregated {@link #getTitle title}.
						/// </summary>
						/// <param name="vTitle">The title to set</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.Form setTitle(Union<sap.ui.core.Title, string> vTitle);

						#endregion

						#region Methods for Aggregation toolbar

						/// <summary>
						/// Gets content of aggregation {@link #getToolbar toolbar}.
						/// 
						/// Toolbar of the <code>Form</code>.
						/// 
						/// <b>Note:</b> If a <code>Toolbar</code> is used, the <code>Title</code> is ignored. If a title is needed inside the <code>Toolbar</code> it must be added at content to the <code>Toolbar</code>. In this case add the <code>Title</code> to the <code>ariaLabelledBy</code> association.
						/// </summary>
						/// <returns></returns>
						public extern virtual sap.ui.core.Toolbar getToolbar();

						/// <summary>
						/// Destroys the toolbar in the aggregation {@link #getToolbar toolbar}.
						/// </summary>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.Form destroyToolbar();

						/// <summary>
						/// Sets the aggregated {@link #getToolbar toolbar}.
						/// </summary>
						/// <param name="oToolbar">The toolbar to set</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.Form setToolbar(sap.ui.core.Toolbar oToolbar);

						#endregion

						#region Methods for Aggregation layout

						/// <summary>
						/// Gets content of aggregation {@link #getLayout layout}.
						/// 
						/// Layout of the <code>Form</code>. The assigned <code>Layout</code> renders the <code>Form</code>. We recommend using the <code>ResponsiveGridLayout</code> for rendering a <code>Form</code>, as its responsiveness allows the available space to be used in the best way possible.
						/// </summary>
						/// <returns></returns>
						public extern virtual sap.ui.layout.form.FormLayout getLayout();

						/// <summary>
						/// Destroys the layout in the aggregation {@link #getLayout layout}.
						/// </summary>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.Form destroyLayout();

						/// <summary>
						/// Sets the aggregated {@link #getLayout layout}.
						/// </summary>
						/// <param name="oLayout">The layout to set</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.Form setLayout(sap.ui.layout.form.FormLayout oLayout);

						#endregion

						#region Methods for Association ariaLabelledBy

						/// <summary>
						/// Returns array of IDs of the elements which are the current targets of the association {@link #getAriaLabelledBy ariaLabelledBy}.
						/// </summary>
						/// <returns></returns>
						public extern virtual sap.ui.core.ID[] getAriaLabelledBy();

						/// <summary>
						/// Adds some ariaLabelledBy into the association {@link #getAriaLabelledBy ariaLabelledBy}.
						/// </summary>
						/// <param name="vAriaLabelledBy">The ariaLabelledBy to add; if empty, nothing is inserted</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.Form addAriaLabelledBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaLabelledBy);

						/// <summary>
						/// Removes an ariaLabelledBy from the association named {@link #getAriaLabelledBy ariaLabelledBy}.
						/// </summary>
						/// <param name="vAriaLabelledBy">The ariaLabelledBy to be removed or its index or ID</param>
						/// <returns>The removed ariaLabelledBy or <code>null</code></returns>
						public extern virtual sap.ui.core.ID removeAriaLabelledBy(Union<int, sap.ui.core.ID, sap.ui.core.Control> vAriaLabelledBy);

						/// <summary>
						/// Removes all the controls in the association named {@link #getAriaLabelledBy ariaLabelledBy}.
						/// </summary>
						/// <returns>An array of the removed elements (might be empty)</returns>
						public extern virtual sap.ui.core.ID[] removeAllAriaLabelledBy();

						#endregion

						#region Other methods

						/// <summary>
						/// Creates a new subclass of class sap.ui.layout.form.Form with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.layout.form.Form with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.layout.form.Form with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns a metadata object for class sap.ui.layout.form.Form.
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
