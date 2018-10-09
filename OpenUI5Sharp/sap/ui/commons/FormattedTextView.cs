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
				/// <summary>
				/// The FormattedTextView control allows the usage of a limited set of HTML tags for display.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.FormattedTextView")]
				[Obsolete("Deprecated since 1.38. Instead, use the <code>sap.ui.core.HTML</code> control.")]
				public partial class FormattedTextView : sap.ui.core.Control
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
						/// The ARIA role for the control.
						/// </summary>
						public Union<sap.ui.core.AccessibleRole, string, sap.ui.@base.ManagedObject.BindPropertyInfo> accessibleRole;

						/// <summary>
						/// Determines text with placeholders.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> htmlText;

						/// <summary>
						/// Array of controls that should be replaced within htmlText.
						/// </summary>
						public Union<sap.ui.core.Control[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> controls;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new FormattedTextView.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern FormattedTextView(string sId, sap.ui.commons.FormattedTextView.Settings mSettings);

					/// <summary>
					/// Constructor for a new FormattedTextView.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					public extern FormattedTextView(string sId);

					/// <summary>
					/// Constructor for a new FormattedTextView.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern FormattedTextView();

					/// <summary>
					/// Constructor for a new FormattedTextView.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern FormattedTextView(sap.ui.commons.FormattedTextView.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property accessibleRole

					/// <summary>
					/// Gets current value of property {@link #getAccessibleRole accessibleRole}.
					/// 
					/// The ARIA role for the control.
					/// 
					/// Default value is <code>Document</code>.
					/// </summary>
					/// <returns>Value of property <code>accessibleRole</code></returns>
					public extern virtual sap.ui.core.AccessibleRole getAccessibleRole();

					/// <summary>
					/// Sets a new value for property {@link #getAccessibleRole accessibleRole}.
					/// 
					/// The ARIA role for the control.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>Document</code>.
					/// </summary>
					/// <param name="sAccessibleRole">New value for property <code>accessibleRole</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.FormattedTextView setAccessibleRole(sap.ui.core.AccessibleRole sAccessibleRole);

					#endregion

					#region Methods for Property htmlText

					/// <summary>
					/// Gets current value of property {@link #getHtmlText htmlText}.
					/// 
					/// Determines text with placeholders.
					/// 
					/// Default value is <code>empty string</code>.
					/// </summary>
					/// <returns>Value of property <code>htmlText</code></returns>
					public extern virtual string getHtmlText();

					/// <summary>
					/// Sets the HTML text to be displayed.
					/// </summary>
					/// <param name="sText">HTML text as a string</param>
					public extern virtual void setHtmlText(string sText);

					#endregion

					#region Methods for Aggregation controls

					/// <summary>
					/// Gets content of aggregation {@link #getControls controls}.
					/// 
					/// Array of controls that should be replaced within htmlText.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.Control[] getControls();

					/// <summary>
					/// Destroys all the controls in the aggregation {@link #getControls controls}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.FormattedTextView destroyControls();

					/// <summary>
					/// Inserts a control into the aggregation {@link #getControls controls}.
					/// </summary>
					/// <param name="oControl">The control to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the control should be inserted at; for a negative value of <code>iIndex</code>, the control is inserted at position 0; for a value greater than the current size of the aggregation, the control is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.FormattedTextView insertControl(sap.ui.core.Control oControl, int iIndex);

					/// <summary>
					/// Adds some control to the aggregation {@link #getControls controls}.
					/// </summary>
					/// <param name="oControl">The control to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.FormattedTextView addControl(sap.ui.core.Control oControl);

					/// <summary>
					/// Removes a control from the aggregation {@link #getControls controls}.
					/// </summary>
					/// <param name="vControl">The control to remove or its index or id</param>
					/// <returns>The removed control or <code>null</code></returns>
					public extern virtual sap.ui.core.Control removeControl(Union<int, string, sap.ui.core.Control> vControl);

					/// <summary>
					/// Checks for the provided <code>sap.ui.core.Control</code> in the aggregation {@link #getControls controls}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oControl">The control whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfControl(sap.ui.core.Control oControl);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getControls controls}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.core.Control[] removeAllControls();

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.FormattedTextView with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.FormattedTextView with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.FormattedTextView with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.commons.FormattedTextView.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					/// <summary>
					/// Indicates whether the FormattedTextView contains other controls.
					/// </summary>
					/// <returns></returns>
					public extern virtual bool hasControls();

					/// <summary>
					/// Sets text with placeholders and given array of controls.
					/// </summary>
					/// <param name="sHtmlText">Contains the corresponding HTML text</param>
					/// <param name="aControls">Array of controls that should be used within given HTML text</param>
					public extern virtual void setContent(string sHtmlText, sap.ui.commons.FormattedTextViewControl aControls);

					#endregion

					#endregion

				}
			}
		}
	}
}
