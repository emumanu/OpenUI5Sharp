using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public static partial class sap
	{
		public static partial class uxap
		{
			/// <summary>
			/// Top-level information container of an {@link sap.uxap.ObjectPageLayout}.
			/// 
			/// The <code>ObjectPageSection</code>'s purpose is to aggregate subsections.
			/// 
			/// <b>Note:</b> This control is intended to be used only as part of the <code>ObjectPageLayout</code>.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.uxap.ObjectPageSection")]
			public partial class ObjectPageSection : sap.uxap.ObjectPageSectionBase
			{
				#region Settings

				/// <summary>
				/// Settings class to create the object
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class Settings : sap.uxap.ObjectPageSectionBase.Settings
				{
					/// <summary>
					/// Determines whether to display the Section title or not.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showTitle;

					/// <summary>
					/// Determines whether the Section title is displayed in upper case.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> titleUppercase;

					/// <summary>
					/// The list of Subsections.
					/// </summary>
					public Union<sap.uxap.ObjectPageSubSection[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> subSections;

					/// <summary>
					/// The most recently selected Subsection by the user.
					/// </summary>
					public Union<sap.uxap.ObjectPageSubSection, sap.ui.core.ID, string, sap.ui.@base.ManagedObject.BindPropertyInfo> selectedSubSection;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new <code>ObjectPageSection</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern ObjectPageSection(string sId, sap.uxap.ObjectPageSection.Settings mSettings);

				/// <summary>
				/// Constructor for a new <code>ObjectPageSection</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern ObjectPageSection(string sId);

				/// <summary>
				/// Constructor for a new <code>ObjectPageSection</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern ObjectPageSection();

				/// <summary>
				/// Constructor for a new <code>ObjectPageSection</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern ObjectPageSection(sap.uxap.ObjectPageSection.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property showTitle

				/// <summary>
				/// Gets current value of property {@link #getShowTitle showTitle}.
				/// 
				/// Determines whether to display the Section title or not.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>showTitle</code></returns>
				public extern virtual bool getShowTitle();

				/// <summary>
				/// Sets a new value for property {@link #getShowTitle showTitle}.
				/// 
				/// Determines whether to display the Section title or not.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bShowTitle">New value for property <code>showTitle</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageSection setShowTitle(bool bShowTitle);

				#endregion

				#region Methods for Property titleUppercase

				/// <summary>
				/// Gets current value of property {@link #getTitleUppercase titleUppercase}.
				/// 
				/// Determines whether the Section title is displayed in upper case.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>titleUppercase</code></returns>
				public extern virtual bool getTitleUppercase();

				/// <summary>
				/// Sets a new value for property {@link #getTitleUppercase titleUppercase}.
				/// 
				/// Determines whether the Section title is displayed in upper case.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bTitleUppercase">New value for property <code>titleUppercase</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageSection setTitleUppercase(bool bTitleUppercase);

				#endregion

				#region Methods for Aggregation subSections

				/// <summary>
				/// Gets content of aggregation {@link #getSubSections subSections}.
				/// 
				/// The list of Subsections.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.uxap.ObjectPageSubSection[] getSubSections();

				/// <summary>
				/// Destroys all the subSections in the aggregation {@link #getSubSections subSections}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageSection destroySubSections();

				/// <summary>
				/// Inserts a subSection into the aggregation {@link #getSubSections subSections}.
				/// </summary>
				/// <param name="oSubSection">The subSection to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the subSection should be inserted at; for a negative value of <code>iIndex</code>, the subSection is inserted at position 0; for a value greater than the current size of the aggregation, the subSection is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageSection insertSubSection(sap.uxap.ObjectPageSubSection oSubSection, int iIndex);

				/// <summary>
				/// Adds some subSection to the aggregation {@link #getSubSections subSections}.
				/// </summary>
				/// <param name="oSubSection">The subSection to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageSection addSubSection(sap.uxap.ObjectPageSubSection oSubSection);

				/// <summary>
				/// Removes a subSection from the aggregation {@link #getSubSections subSections}.
				/// </summary>
				/// <param name="vSubSection">The subSection to remove or its index or id</param>
				/// <returns>The removed subSection or <code>null</code></returns>
				public extern virtual sap.uxap.ObjectPageSubSection removeSubSection(Union<int, string, sap.uxap.ObjectPageSubSection> vSubSection);

				/// <summary>
				/// Checks for the provided <code>sap.uxap.ObjectPageSubSection</code> in the aggregation {@link #getSubSections subSections}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oSubSection">The subSection whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfSubSection(sap.uxap.ObjectPageSubSection oSubSection);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getSubSections subSections}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.uxap.ObjectPageSubSection[] removeAllSubSections();

				#endregion

				#region Methods for Aggregation ariaLabelledBy

				#endregion

				#region Methods for Aggregation _showHideAllButton

				#endregion

				#region Methods for Aggregation _showHideButton

				#endregion

				#region Methods for Association selectedSubSection

				/// <summary>
				/// ID of the element which is the current target of the association {@link #getSelectedSubSection selectedSubSection}, or <code>null</code>.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.ID getSelectedSubSection();

				/// <summary>
				/// Sets the associated {@link #getSelectedSubSection selectedSubSection}.
				/// </summary>
				/// <param name="oSelectedSubSection">ID of an element which becomes the new target of this selectedSubSection association; alternatively, an element instance may be given</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageSection setSelectedSubSection(Union<sap.ui.core.ID, sap.uxap.ObjectPageSubSection> oSelectedSubSection);

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.uxap.ObjectPageSection with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.uxap.ObjectPageSectionBase.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.uxap.ObjectPageSection with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.uxap.ObjectPageSectionBase.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.uxap.ObjectPageSection with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.uxap.ObjectPageSectionBase.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.uxap.ObjectPageSection.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				#endregion

				#endregion

			}
		}
	}
}
