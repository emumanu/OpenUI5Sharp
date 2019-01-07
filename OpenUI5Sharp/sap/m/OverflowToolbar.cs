using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public static partial class sap
	{
		public static partial class m
		{
			/// <summary>
			/// A container control based on {@link sap.m.Toolbar}, that provides overflow when its content does not fit in the visible area.
			/// 
			/// <h3>Overview</h3>
			/// 
			/// The content of the <code>OverflowToolbar</code> moves into the overflow area from right to left when the available space is not enough in the visible area of the container. It can be accessed by the user through the overflow button that opens it in a popover.
			/// 
			/// <b>Note:</b> It is recommended that you use <code>OverflowToolbar</code> over {@link sap.m.Toolbar}, unless you want to avoid overflow in favor of shrinking.
			/// 
			/// <h3>Usage</h3>
			/// 
			/// Different behavior and priorities can be set for each control inside the <code>OverflowToolbar</code>, such as certain controls to appear only in the overflow area or to never move there. For more information, see {@link sap.m.OverflowToolbarLayoutData} and {@link sap.m.OverflowToolbarPriority}.
			/// 
			/// <h3>Overflow Behavior</h3> By default, only the following controls can move to the overflow area:
			/// 
			/// <ul><li>{@link sap.m.Button}</li> <li>{@link sap.m.CheckBox}</li> <li>{@link sap.m.ComboBox}</li> <li>{@link sap.m.DatePicker}</li> <li>{@link sap.m.DateTimeInput}</li> <li>{@link sap.m.DateTimePicker}</li> <li>{@link sap.m.Input}</li> <li>{@link sap.m.Label}</li> <li>{@link sap.m.MenuButton}</li> <li>{@link sap.m.OverflowToolbarButton}</li> <li>{@link sap.m.OverflowToolbarToggleButton}</li> <li>{@link sap.m.SearchField}</li> <li>{@link sap.m.SegmentedButton}</li> <li>{@link sap.m.Select}</li> <li>{@link sap.m.TimePicker}</li> <li>{@link sap.m.ToggleButton}</li> <li>{@link sap.ui.comp.smartfield.SmartField}</li> <li>{@link sap.ui.comp.smartfield.SmartLabel}</li></ul>
			/// 
			/// Additionally, any control that implements the {@link sap.m.IOverflowToolbarContent} interface may define its behavior (most importantly overflow behavior) when placed inside <code>OverflowToolbar</code>.
			/// 
			/// <b>Note:</b> The <code>OverflowToolbar</code> is an adaptive container that checks the available width and hides the part of its content that doesn't fit. It is intended that simple controls, such as {@link sap.m.Button} and {@link sap.m.Label} are used as content. Embedding other adaptive container controls, such as {@link sap.m.Breadcrumbs}, results in competition for the available space - both controls calculate the available space based on the other one's size and both change their width at the same time, leading to incorrectly distributed space.
			/// 
			/// <h3>Responsive behavior</h3>
			/// 
			/// The height of the toolbar changes on desktop, tablet, and smartphones.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.OverflowToolbar")]
			public partial class OverflowToolbar : sap.m.Toolbar, sap.ui.core.Toolbar, sap.m.IBar
			{
				#region Settings

				/// <summary>
				/// Settings class to create the object
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class Settings : sap.m.Toolbar.Settings
				{
				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new <code>OverflowToolbar</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern OverflowToolbar(string sId, sap.m.OverflowToolbar.Settings mSettings);

				/// <summary>
				/// Constructor for a new <code>OverflowToolbar</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern OverflowToolbar(string sId);

				/// <summary>
				/// Constructor for a new <code>OverflowToolbar</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern OverflowToolbar();

				/// <summary>
				/// Constructor for a new <code>OverflowToolbar</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern OverflowToolbar(sap.m.OverflowToolbar.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Aggregation _overflowButton

				#endregion

				#region Methods for Aggregation _popover

				#endregion

				/// <summary>
				/// Returns all the controls from the <code>sap.m.OverflowToolbar</code>, that are not in the overflow area and their <code>visible</code> property is <code>true</code>.
				/// </summary>
				/// <returns></returns>
				private extern Union<object, object[]> _getVisibleAndNonOverflowContent();

				/// <summary>
				/// Closes the overflow area. Useful to manually close the overflow after having suppressed automatic closing with "closeOverflowOnInteraction=false".
				/// </summary>
				public extern virtual void closeOverflow();

				/// <summary>
				/// Creates a new subclass of class sap.m.OverflowToolbar with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.Toolbar.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.OverflowToolbar with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.Toolbar.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.OverflowToolbar with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.Toolbar.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.OverflowToolbar.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				[Name("getMetadata")]
				public extern static sap.ui.@base.Metadata getMetadataStatic();

				#endregion

			}
		}
	}
}
