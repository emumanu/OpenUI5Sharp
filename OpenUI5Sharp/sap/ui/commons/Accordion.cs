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
				/// Contains N sections, acting as containers for any library control
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.Accordion")]
				[Obsolete("Deprecated since 1.38.")]
				public partial class Accordion : sap.ui.core.Control
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
						/// When the specified width is less than the width of a section content, a horizontal scroll bar is provided.
						/// </summary>
						public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> width;

						/// <summary>
						/// Section IDs that are opened by default at application start
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> openedSectionsId;

						/// <summary>
						/// Empty container used to display any library control
						/// </summary>
						public Union<sap.ui.commons.AccordionSection[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> sections;

						/// <summary>
						/// Event is triggered when the user opens a section.
						/// </summary>
						public sap.ui.commons.Accordion.SectionOpenDelegate sectionOpen;

						/// <summary>
						/// Event is triggered when the user closes a section.
						/// </summary>
						public sap.ui.commons.Accordion.SectionCloseDelegate sectionClose;

						/// <summary>
						/// Event is triggered when the user changes the position of a section.
						/// </summary>
						public sap.ui.commons.Accordion.SectionsReorderDelegate sectionsReorder;

					}

					#endregion

					#region Typed Parameters

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class SectionCloseInfo
					{
						/// <summary>
						/// ID of the closed section
						/// </summary>
						public string closeSectionId;

					}

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class SectionOpenInfo
					{
						/// <summary>
						/// ID of the opened section
						/// </summary>
						public string openSectionId;

						/// <summary>
						/// IDs of the sections to be closed. Can be initial in the case of no previously opened section.
						/// </summary>
						public string[] closeSectionIds;

					}

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class SectionsReorderInfo
					{
						/// <summary>
						/// ID of the moved section
						/// </summary>
						public string movedSectionId;

						/// <summary>
						/// New index of the moved section
						/// </summary>
						public int newIndex;

					}

					#endregion

					#region Delegates

					public delegate void SectionCloseDelegate(sap.ui.@base.Event<sap.ui.commons.Accordion.SectionCloseInfo> oEvent, object oData);

					public delegate void SectionOpenDelegate(sap.ui.@base.Event<sap.ui.commons.Accordion.SectionOpenInfo> oEvent, object oData);

					public delegate void SectionsReorderDelegate(sap.ui.@base.Event<sap.ui.commons.Accordion.SectionsReorderInfo> oEvent, object oData);

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new Accordion.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern Accordion(string sId, sap.ui.commons.Accordion.Settings mSettings);

					/// <summary>
					/// Constructor for a new Accordion.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern Accordion(string sId);

					/// <summary>
					/// Constructor for a new Accordion.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern Accordion();

					/// <summary>
					/// Constructor for a new Accordion.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern Accordion(sap.ui.commons.Accordion.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property width

					/// <summary>
					/// Gets current value of property {@link #getWidth width}.
					/// 
					/// When the specified width is less than the width of a section content, a horizontal scroll bar is provided.
					/// 
					/// Default value is <code>200px</code>.
					/// </summary>
					/// <returns>Value of property <code>width</code></returns>
					public extern virtual sap.ui.core.CSSSize getWidth();

					/// <summary>
					/// Sets a new value for property {@link #getWidth width}.
					/// 
					/// When the specified width is less than the width of a section content, a horizontal scroll bar is provided.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>200px</code>.
					/// </summary>
					/// <param name="sWidth">New value for property <code>width</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Accordion setWidth(sap.ui.core.CSSSize sWidth);

					#endregion

					#region Methods for Property openedSectionsId

					/// <summary>
					/// Gets current value of property {@link #getOpenedSectionsId openedSectionsId}.
					/// 
					/// Section IDs that are opened by default at application start
					/// </summary>
					/// <returns>Value of property <code>openedSectionsId</code></returns>
					public extern virtual string getOpenedSectionsId();

					/// <summary>
					/// Redefinition of the method to add additional handling
					/// </summary>
					/// <param name="sOpenedSectionsId">New value for property openedSectionsId</param>
					/// <returns>'this' to allow method chaining</returns>
					public extern virtual sap.ui.commons.Accordion setOpenedSectionsId(string sOpenedSectionsId);

					#endregion

					#region Methods for Aggregation sections

					/// <summary>
					/// Gets content of aggregation {@link #getSections sections}.
					/// 
					/// Empty container used to display any library control
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.commons.AccordionSection[] getSections();

					/// <summary>
					/// Destroys all the sections in the aggregation {@link #getSections sections}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Accordion destroySections();

					/// <summary>
					/// Inserts a section into the aggregation {@link #getSections sections}.
					/// </summary>
					/// <param name="oSection">The section to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the section should be inserted at; for a negative value of <code>iIndex</code>, the section is inserted at position 0; for a value greater than the current size of the aggregation, the section is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Accordion insertSection(sap.ui.commons.AccordionSection oSection, int iIndex);

					/// <summary>
					/// Adds some section to the aggregation {@link #getSections sections}.
					/// </summary>
					/// <param name="oSection">The section to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Accordion addSection(sap.ui.commons.AccordionSection oSection);

					/// <summary>
					/// Removes a section from the aggregation {@link #getSections sections}.
					/// </summary>
					/// <param name="vSection">The section to remove or its index or id</param>
					/// <returns>The removed section or <code>null</code></returns>
					public extern virtual sap.ui.commons.AccordionSection removeSection(Union<int, string, sap.ui.commons.AccordionSection> vSection);

					/// <summary>
					/// Checks for the provided <code>sap.ui.commons.AccordionSection</code> in the aggregation {@link #getSections sections}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oSection">The section whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfSection(sap.ui.commons.AccordionSection oSection);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getSections sections}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.commons.AccordionSection[] removeAllSections();

					#endregion

					#region Methods for Event sectionOpen

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:sectionOpen sectionOpen} event of this <code>sap.ui.commons.Accordion</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.Accordion</code> itself.
					/// 
					/// Event is triggered when the user opens a section.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.Accordion</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Accordion attachSectionOpen(object oData, sap.ui.commons.Accordion.SectionOpenDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:sectionOpen sectionOpen} event of this <code>sap.ui.commons.Accordion</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.Accordion</code> itself.
					/// 
					/// Event is triggered when the user opens a section.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Accordion attachSectionOpen(object oData, sap.ui.commons.Accordion.SectionOpenDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:sectionOpen sectionOpen} event of this <code>sap.ui.commons.Accordion</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.Accordion</code> itself.
					/// 
					/// Event is triggered when the user opens a section.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Accordion attachSectionOpen(sap.ui.commons.Accordion.SectionOpenDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:sectionOpen sectionOpen} event of this <code>sap.ui.commons.Accordion</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.Accordion</code> itself.
					/// 
					/// Event is triggered when the user opens a section.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.Accordion</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Accordion attachSectionOpen(sap.ui.commons.Accordion.SectionOpenDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:sectionOpen sectionOpen} event of this <code>sap.ui.commons.Accordion</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Accordion detachSectionOpen(sap.ui.commons.Accordion.SectionOpenDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:sectionOpen sectionOpen} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Accordion fireSectionOpen(sap.ui.commons.Accordion.SectionOpenInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:sectionOpen sectionOpen} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Accordion fireSectionOpen();

					#endregion

					#region Methods for Event sectionClose

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:sectionClose sectionClose} event of this <code>sap.ui.commons.Accordion</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.Accordion</code> itself.
					/// 
					/// Event is triggered when the user closes a section.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.Accordion</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Accordion attachSectionClose(object oData, sap.ui.commons.Accordion.SectionCloseDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:sectionClose sectionClose} event of this <code>sap.ui.commons.Accordion</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.Accordion</code> itself.
					/// 
					/// Event is triggered when the user closes a section.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Accordion attachSectionClose(object oData, sap.ui.commons.Accordion.SectionCloseDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:sectionClose sectionClose} event of this <code>sap.ui.commons.Accordion</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.Accordion</code> itself.
					/// 
					/// Event is triggered when the user closes a section.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Accordion attachSectionClose(sap.ui.commons.Accordion.SectionCloseDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:sectionClose sectionClose} event of this <code>sap.ui.commons.Accordion</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.Accordion</code> itself.
					/// 
					/// Event is triggered when the user closes a section.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.Accordion</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Accordion attachSectionClose(sap.ui.commons.Accordion.SectionCloseDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:sectionClose sectionClose} event of this <code>sap.ui.commons.Accordion</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Accordion detachSectionClose(sap.ui.commons.Accordion.SectionCloseDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:sectionClose sectionClose} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Accordion fireSectionClose(sap.ui.commons.Accordion.SectionCloseInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:sectionClose sectionClose} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Accordion fireSectionClose();

					#endregion

					#region Methods for Event sectionsReorder

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:sectionsReorder sectionsReorder} event of this <code>sap.ui.commons.Accordion</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.Accordion</code> itself.
					/// 
					/// Event is triggered when the user changes the position of a section.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.Accordion</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Accordion attachSectionsReorder(object oData, sap.ui.commons.Accordion.SectionsReorderDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:sectionsReorder sectionsReorder} event of this <code>sap.ui.commons.Accordion</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.Accordion</code> itself.
					/// 
					/// Event is triggered when the user changes the position of a section.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Accordion attachSectionsReorder(object oData, sap.ui.commons.Accordion.SectionsReorderDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:sectionsReorder sectionsReorder} event of this <code>sap.ui.commons.Accordion</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.Accordion</code> itself.
					/// 
					/// Event is triggered when the user changes the position of a section.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Accordion attachSectionsReorder(sap.ui.commons.Accordion.SectionsReorderDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:sectionsReorder sectionsReorder} event of this <code>sap.ui.commons.Accordion</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.Accordion</code> itself.
					/// 
					/// Event is triggered when the user changes the position of a section.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.Accordion</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Accordion attachSectionsReorder(sap.ui.commons.Accordion.SectionsReorderDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:sectionsReorder sectionsReorder} event of this <code>sap.ui.commons.Accordion</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Accordion detachSectionsReorder(sap.ui.commons.Accordion.SectionsReorderDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:sectionsReorder sectionsReorder} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Accordion fireSectionsReorder(sap.ui.commons.Accordion.SectionsReorderInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:sectionsReorder sectionsReorder} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Accordion fireSectionsReorder();

					#endregion

					#region Other methods

					/// <summary>
					/// Closes a section and opens the default one
					/// </summary>
					/// <param name="sSectionId">Id of the section that is being closed</param>
					public extern virtual void closeSection(string sSectionId);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.Accordion with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.Accordion with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.Accordion with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.commons.Accordion.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					[Name("getMetadata")]
					public extern static sap.ui.@base.Metadata getMetadataStatic();

					/// <summary>
					/// Opens a section
					/// </summary>
					/// <param name="sSectionId">Id of the section that is being opened</param>
					public extern virtual void openSection(string sSectionId);

					#endregion

					#endregion

				}
			}
		}
	}
}
