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
					/// A <code>FormContainer</code> represents a group inside a <code>Form</code>. It consists of <code>FormElements</code>. The rendering of the <code>FormContainer</code> is done by the <code>FormLayout</code> assigned to the <code>Form</code>.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.layout.form.FormContainer")]
					public partial class FormContainer : sap.ui.core.Element
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
							/// Container is expanded.
							/// 
							/// <b>Note:</b> This property only works if <code>expandable</code> is set to <code>true</code>.
							/// </summary>
							public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> expanded;

							/// <summary>
							/// Defines if the <code>FormContainer</code> is expandable.
							/// 
							/// <b>Note:</b> The expander icon will only be shown if a <code>title</code> is set for the <code>FormContainer</code>.
							/// </summary>
							public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> expandable;

							/// <summary>
							/// If set to <code>false</code>, the <code>FormContainer</code> is not rendered.
							/// </summary>
							public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> visible;

							/// <summary>
							/// The <code>FormElements</code> contain the content (labels and fields) of the <code>FormContainers</code>.
							/// </summary>
							public Union<sap.ui.layout.form.FormElement[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> formElements;

							/// <summary>
							/// Title of the <code>FormContainer</code>. Can either be a <code>Title</code> element or a string. If a <code>Title</code> element is used, the style of the title can be set.
							/// 
							/// <b>Note:</b> If a <code>Toolbar</code> is used, the <code>Title</code> is ignored.
							/// </summary>
							public Union<sap.ui.core.Title, string, sap.ui.@base.ManagedObject.BindAggregationInfo> title;

							/// <summary>
							/// Toolbar of the <code>FormContainer</code>.
							/// 
							/// <b>Note:</b> If a <code>Toolbar</code> is used, the <code>Title</code> is ignored. If a title is needed inside the <code>Toolbar</code> it must be added at content to the <code>Toolbar</code>. In this case add the <code>Title</code> to the <code>ariaLabelledBy</code> association.
							/// </summary>
							public Union<sap.ui.core.Toolbar, string, sap.ui.@base.ManagedObject.BindAggregationInfo> toolbar;

							/// <summary>
							/// Association to controls / IDs that label this control (see WAI-ARIA attribute <code>aria-labelledby</code>).
							/// 
							/// <b>Note:</b> This attribute is only rendered if the <code>FormContainer</code> has it's own DOM representation in the used <code>FormLayout</code>.
							/// </summary>
							public Union<sap.ui.core.Control, sap.ui.core.ID[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> ariaLabelledBy;

						}

						#endregion

						#region Constructor

						/// <summary>
						/// Constructor for a new sap.ui.layout.form.FormContainer.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
						/// <param name="mSettings">Initial settings for the new control</param>
						public extern FormContainer(string sId, sap.ui.layout.form.FormContainer.Settings mSettings);

						/// <summary>
						/// Constructor for a new sap.ui.layout.form.FormContainer.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
						public extern FormContainer(string sId);

						/// <summary>
						/// Constructor for a new sap.ui.layout.form.FormContainer.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						public extern FormContainer();

						/// <summary>
						/// Constructor for a new sap.ui.layout.form.FormContainer.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="mSettings">Initial settings for the new control</param>
						public extern FormContainer(sap.ui.layout.form.FormContainer.Settings mSettings);

						#endregion

						#region Methods

						#region Methods for Property expanded

						/// <summary>
						/// Gets current value of property {@link #getExpanded expanded}.
						/// 
						/// Container is expanded.
						/// 
						/// <b>Note:</b> This property only works if <code>expandable</code> is set to <code>true</code>.
						/// 
						/// Default value is <code>true</code>.
						/// </summary>
						/// <returns>Value of property <code>expanded</code></returns>
						public extern virtual bool getExpanded();

						/// <summary>
						/// Sets a new value for property {@link #getExpanded expanded}.
						/// 
						/// Container is expanded.
						/// 
						/// <b>Note:</b> This property only works if <code>expandable</code> is set to <code>true</code>.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>true</code>.
						/// </summary>
						/// <param name="bExpanded">New value for property <code>expanded</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.FormContainer setExpanded(bool bExpanded);

						#endregion

						#region Methods for Property expandable

						/// <summary>
						/// Gets current value of property {@link #getExpandable expandable}.
						/// 
						/// Defines if the <code>FormContainer</code> is expandable.
						/// 
						/// <b>Note:</b> The expander icon will only be shown if a <code>title</code> is set for the <code>FormContainer</code>.
						/// 
						/// Default value is <code>false</code>.
						/// </summary>
						/// <returns>Value of property <code>expandable</code></returns>
						public extern virtual bool getExpandable();

						/// <summary>
						/// Sets a new value for property {@link #getExpandable expandable}.
						/// 
						/// Defines if the <code>FormContainer</code> is expandable.
						/// 
						/// <b>Note:</b> The expander icon will only be shown if a <code>title</code> is set for the <code>FormContainer</code>.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>false</code>.
						/// </summary>
						/// <param name="bExpandable">New value for property <code>expandable</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.FormContainer setExpandable(bool bExpandable);

						#endregion

						#region Methods for Property visible

						/// <summary>
						/// Gets current value of property {@link #getVisible visible}.
						/// 
						/// If set to <code>false</code>, the <code>FormContainer</code> is not rendered.
						/// 
						/// Default value is <code>true</code>.
						/// </summary>
						/// <returns>Value of property <code>visible</code></returns>
						public extern virtual bool getVisible();

						/// <summary>
						/// Sets a new value for property {@link #getVisible visible}.
						/// 
						/// If set to <code>false</code>, the <code>FormContainer</code> is not rendered.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>true</code>.
						/// </summary>
						/// <param name="bVisible">New value for property <code>visible</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.FormContainer setVisible(bool bVisible);

						#endregion

						#region Methods for Aggregation formElements

						/// <summary>
						/// Gets content of aggregation {@link #getFormElements formElements}.
						/// 
						/// The <code>FormElements</code> contain the content (labels and fields) of the <code>FormContainers</code>.
						/// </summary>
						/// <returns></returns>
						public extern virtual sap.ui.layout.form.FormElement[] getFormElements();

						/// <summary>
						/// Destroys all the formElements in the aggregation {@link #getFormElements formElements}.
						/// </summary>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.FormContainer destroyFormElements();

						/// <summary>
						/// Inserts a formElement into the aggregation {@link #getFormElements formElements}.
						/// </summary>
						/// <param name="oFormElement">The formElement to insert; if empty, nothing is inserted</param>
						/// <param name="iIndex">The <code>0</code>-based index the formElement should be inserted at; for a negative value of <code>iIndex</code>, the formElement is inserted at position 0; for a value greater than the current size of the aggregation, the formElement is inserted at the last position</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.FormContainer insertFormElement(sap.ui.layout.form.FormElement oFormElement, int iIndex);

						/// <summary>
						/// Adds some formElement to the aggregation {@link #getFormElements formElements}.
						/// </summary>
						/// <param name="oFormElement">The formElement to add; if empty, nothing is inserted</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.FormContainer addFormElement(sap.ui.layout.form.FormElement oFormElement);

						/// <summary>
						/// Removes a formElement from the aggregation {@link #getFormElements formElements}.
						/// </summary>
						/// <param name="vFormElement">The formElement to remove or its index or id</param>
						/// <returns>The removed formElement or <code>null</code></returns>
						public extern virtual sap.ui.layout.form.FormElement removeFormElement(Union<int, string, sap.ui.layout.form.FormElement> vFormElement);

						/// <summary>
						/// Checks for the provided <code>sap.ui.layout.form.FormElement</code> in the aggregation {@link #getFormElements formElements}. and returns its index if found or -1 otherwise.
						/// </summary>
						/// <param name="oFormElement">The formElement whose index is looked for</param>
						/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
						public extern virtual int indexOfFormElement(sap.ui.layout.form.FormElement oFormElement);

						/// <summary>
						/// Removes all the controls from the aggregation {@link #getFormElements formElements}.
						/// 
						/// Additionally, it unregisters them from the hosting UIArea.
						/// </summary>
						/// <returns>An array of the removed elements (might be empty)</returns>
						public extern virtual sap.ui.layout.form.FormElement[] removeAllFormElements();

						#endregion

						#region Methods for Aggregation title

						/// <summary>
						/// Gets content of aggregation {@link #getTitle title}.
						/// 
						/// Title of the <code>FormContainer</code>. Can either be a <code>Title</code> element or a string. If a <code>Title</code> element is used, the style of the title can be set.
						/// 
						/// <b>Note:</b> If a <code>Toolbar</code> is used, the <code>Title</code> is ignored.
						/// </summary>
						/// <returns></returns>
						public extern virtual Union<sap.ui.core.Title, string> getTitle();

						/// <summary>
						/// Destroys the title in the aggregation {@link #getTitle title}.
						/// </summary>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.FormContainer destroyTitle();

						/// <summary>
						/// Sets the aggregated {@link #getTitle title}.
						/// </summary>
						/// <param name="vTitle">The title to set</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.FormContainer setTitle(Union<sap.ui.core.Title, string> vTitle);

						#endregion

						#region Methods for Aggregation toolbar

						/// <summary>
						/// Gets content of aggregation {@link #getToolbar toolbar}.
						/// 
						/// Toolbar of the <code>FormContainer</code>.
						/// 
						/// <b>Note:</b> If a <code>Toolbar</code> is used, the <code>Title</code> is ignored. If a title is needed inside the <code>Toolbar</code> it must be added at content to the <code>Toolbar</code>. In this case add the <code>Title</code> to the <code>ariaLabelledBy</code> association.
						/// </summary>
						/// <returns></returns>
						public extern virtual sap.ui.core.Toolbar getToolbar();

						/// <summary>
						/// Destroys the toolbar in the aggregation {@link #getToolbar toolbar}.
						/// </summary>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.FormContainer destroyToolbar();

						/// <summary>
						/// Sets the aggregated {@link #getToolbar toolbar}.
						/// </summary>
						/// <param name="oToolbar">The toolbar to set</param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.layout.form.FormContainer setToolbar(sap.ui.core.Toolbar oToolbar);

						#endregion

						#region Methods for Aggregation _expandButton

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
						public extern virtual sap.ui.layout.form.FormContainer addAriaLabelledBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaLabelledBy);

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
						/// Creates a new subclass of class sap.ui.layout.form.FormContainer with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.layout.form.FormContainer with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.layout.form.FormContainer with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns a metadata object for class sap.ui.layout.form.FormContainer.
						/// </summary>
						/// <returns>Metadata object describing this class</returns>
						[Name("getMetadata")]
						public extern static sap.ui.@base.Metadata getMetadataStatic();

						/// <summary>
						/// Determines if the <code>FormContainer</code> is visible or not. Per default it just returns the value of the <code>visible</code> property. But this might be overwritten by inherited elements.
						/// 
						/// For rendering by <code>FormLayouts</code> this function has to be used instead of <code>getVisible</code>.
						/// </summary>
						/// <returns>If true, the <code>FormContainer</code> is visible, otherwise not</returns>
						public extern virtual bool isVisible();

						#endregion

						#endregion

					}
				}
			}
		}
	}
}
