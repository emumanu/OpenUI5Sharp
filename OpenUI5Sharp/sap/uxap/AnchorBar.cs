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
			/// Displays the titles of the sections and subsections in the {@link sap.uxap.ObjectPageLayout ObjectPageLayout} and allows the user to scroll to the respective content.
			/// 
			/// <h3>Overview</h3>
			/// 
			/// The <code>AnchorBar</code> is internally generated as a menu in the <code>ObjectPageLayout</code>. It displays the sections and subsections and allows the user to directly scroll to the respective content by selecting them, while it remains visible at the top of the page (below the page header).
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.uxap.AnchorBar")]
			public partial class AnchorBar : sap.m.Toolbar
			{
				#region Settings

				/// <summary>
				/// Settings class to create the object
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class Settings : sap.m.Toolbar.Settings
				{
					/// <summary>
					/// Determines whether to show a Popover with Subsection links when clicking on Section links in the Anchor bar.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showPopover;

					/// <summary>
					/// Determines whether the Anchor bar items are displayed in upper case.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> upperCase;

					/// <summary>
					/// The button that represents the Section being scrolled by the user.
					/// </summary>
					public Union<sap.m.Button, sap.ui.core.ID, string, sap.ui.@base.ManagedObject.BindPropertyInfo> selectedButton;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new <code>AnchorBar</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern AnchorBar(string sId, sap.uxap.AnchorBar.Settings mSettings);

				/// <summary>
				/// Constructor for a new <code>AnchorBar</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern AnchorBar(string sId);

				/// <summary>
				/// Constructor for a new <code>AnchorBar</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern AnchorBar();

				/// <summary>
				/// Constructor for a new <code>AnchorBar</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern AnchorBar(sap.uxap.AnchorBar.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property showPopover

				/// <summary>
				/// Gets current value of property {@link #getShowPopover showPopover}.
				/// 
				/// Determines whether to show a Popover with Subsection links when clicking on Section links in the Anchor bar.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>showPopover</code></returns>
				public extern virtual bool getShowPopover();

				/// <summary>
				/// Sets a new value for property {@link #getShowPopover showPopover}.
				/// 
				/// Determines whether to show a Popover with Subsection links when clicking on Section links in the Anchor bar.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bShowPopover">New value for property <code>showPopover</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.AnchorBar setShowPopover(bool bShowPopover);

				#endregion

				#region Methods for Property upperCase

				/// <summary>
				/// Gets current value of property {@link #getUpperCase upperCase}.
				/// 
				/// Determines whether the Anchor bar items are displayed in upper case.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>upperCase</code></returns>
				public extern virtual bool getUpperCase();

				/// <summary>
				/// Sets a new value for property {@link #getUpperCase upperCase}.
				/// 
				/// Determines whether the Anchor bar items are displayed in upper case.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bUpperCase">New value for property <code>upperCase</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.AnchorBar setUpperCase(bool bUpperCase);

				#endregion

				#region Methods for Aggregation _select

				#endregion

				#region Methods for Aggregation _popovers

				#endregion

				#region Methods for Aggregation _scrollArrowLeft

				#endregion

				#region Methods for Aggregation _scrollArrowRight

				#endregion

				#region Methods for Association selectedButton

				/// <summary>
				/// ID of the element which is the current target of the association {@link #getSelectedButton selectedButton}, or <code>null</code>.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.ID getSelectedButton();

				/// <summary>
				/// Sets the associated {@link #getSelectedButton selectedButton}.
				/// </summary>
				/// <param name="oSelectedButton">ID of an element which becomes the new target of this selectedButton association; alternatively, an element instance may be given</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.AnchorBar setSelectedButton(Union<sap.ui.core.ID, sap.m.Button> oSelectedButton);

				#endregion

				#region Other methods

				/// <summary>
				/// This method is a hook for the RenderManager that gets called during the rendering of child Controls. It allows to add, remove and update existing accessibility attributes (ARIA) of those controls.
				/// </summary>
				/// <param name="oElement">The Control that gets rendered by the RenderManager</param>
				/// <param name="mAriaProps">The mapping of "aria-" prefixed attributes</param>
				public extern virtual void enhanceAccessibilityState(sap.ui.core.Control oElement, object mAriaProps);

				/// <summary>
				/// Creates a new subclass of class sap.uxap.AnchorBar with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.Toolbar.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.uxap.AnchorBar with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.Toolbar.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.uxap.AnchorBar with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.Toolbar.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.uxap.AnchorBar.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				/// <summary>
				/// Returns an sap.ui.core.delegate.ScrollEnablement object used to handle scrolling.
				/// </summary>
				/// <returns>The <code>sap.ui.core.delegate.ScrollEnablement</code> instance</returns>
				public extern virtual object getScrollDelegate();

				/// <summary>
				/// Scroll to a specific Section.
				/// </summary>
				/// <param name="sId">The Section ID to scroll to</param>
				/// <param name="iDuration">Scroll duration (in ms). Default value is 0.</param>
				public extern virtual void scrollToSection(string sId, int iDuration);

				#endregion

				#endregion

			}
		}
	}
}
