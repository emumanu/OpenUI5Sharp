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
			public static partial class unified
			{
				/// <summary>
				/// Header Action item of the Shell.
				/// </summary>
				[External]
				[Namespace(false)]
				[Obsolete("Deprecated since 1.44.0.")]
				public partial class ShellHeadItem : sap.ui.core.Element
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
						/// If set to true, a divider is displayed before the item.
						/// </summary>
						public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> startsSection;

						/// <summary>
						/// If set to true, a separator is displayed after the item.
						/// </summary>
						public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> showSeparator;

						/// <summary>
						/// Defines the toggle state in case the item represents a toggle button (see also property <code>toggleEnabled</code>).
						/// </summary>
						public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> selected;

						/// <summary>
						/// If set to true, the item represents a toggle button. The <code>selected</code> property can the be used to define the toggle state. Otherwise the item is displayed as action button. In this case the <code>selected</code> property is ignored.
						/// </summary>
						public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> toggleEnabled;

						/// <summary>
						/// If set to true, a theme dependent marker is shown on the item.
						/// </summary>
						public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> showMarker;

						/// <summary>
						/// The icon of the item, either defined in the sap.ui.core.IconPool or a URI to a custom image. An icon must be set.
						/// </summary>
						public Union<sap.ui.core.URI, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> icon;

						/// <summary>
						/// Invisible items are not shown on the UI.
						/// </summary>
						public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> visible;

						/// <summary>
						/// Association to controls / ids which label this control (see WAI-ARIA attribute aria-labelledby).
						/// </summary>
						public Union<sap.ui.core.Control, sap.ui.core.ID[], string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> ariaLabelledBy;

						/// <summary>
						/// Event is fired when the user presses the item.
						/// </summary>
						public sap.ui.@base.EventDelegate press;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new ShellHeadItem.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern ShellHeadItem(string sId, sap.ui.unified.ShellHeadItem.Settings mSettings);

					/// <summary>
					/// Constructor for a new ShellHeadItem.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern ShellHeadItem(string sId);

					/// <summary>
					/// Constructor for a new ShellHeadItem.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern ShellHeadItem();

					/// <summary>
					/// Constructor for a new ShellHeadItem.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern ShellHeadItem(sap.ui.unified.ShellHeadItem.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property startsSection

					/// <summary>
					/// Gets current value of property {@link #getStartsSection startsSection}.
					/// 
					/// If set to true, a divider is displayed before the item.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					[Obsolete("Deprecated since 1.18. Dividers are not supported anymore.")]
					/// <returns>Value of property <code>startsSection</code></returns>
					public extern virtual bool getStartsSection();

					/// <summary>
					/// Sets a new value for property {@link #getStartsSection startsSection}.
					/// 
					/// If set to true, a divider is displayed before the item.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					[Obsolete("Deprecated since 1.18. Dividers are not supported anymore.")]
					/// <param name="bStartsSection">New value for property <code>startsSection</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.ShellHeadItem setStartsSection(bool bStartsSection);

					#endregion

					#region Methods for Property showSeparator

					/// <summary>
					/// Gets current value of property {@link #getShowSeparator showSeparator}.
					/// 
					/// If set to true, a separator is displayed after the item.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>showSeparator</code></returns>
					public extern virtual bool getShowSeparator();

					/// <summary>
					/// Sets a new value for property {@link #getShowSeparator showSeparator}.
					/// 
					/// If set to true, a separator is displayed after the item.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bShowSeparator">New value for property <code>showSeparator</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.ShellHeadItem setShowSeparator(bool bShowSeparator);

					#endregion

					#region Methods for Property selected

					/// <summary>
					/// Gets current value of property {@link #getSelected selected}.
					/// 
					/// Defines the toggle state in case the item represents a toggle button (see also property <code>toggleEnabled</code>).
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>selected</code></returns>
					public extern virtual bool getSelected();

					/// <summary>
					/// Sets a new value for property {@link #getSelected selected}.
					/// 
					/// Defines the toggle state in case the item represents a toggle button (see also property <code>toggleEnabled</code>).
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bSelected">New value for property <code>selected</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.ShellHeadItem setSelected(bool bSelected);

					#endregion

					#region Methods for Property toggleEnabled

					/// <summary>
					/// Gets current value of property {@link #getToggleEnabled toggleEnabled}.
					/// 
					/// If set to true, the item represents a toggle button. The <code>selected</code> property can the be used to define the toggle state. Otherwise the item is displayed as action button. In this case the <code>selected</code> property is ignored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>toggleEnabled</code></returns>
					public extern virtual bool getToggleEnabled();

					/// <summary>
					/// Sets a new value for property {@link #getToggleEnabled toggleEnabled}.
					/// 
					/// If set to true, the item represents a toggle button. The <code>selected</code> property can the be used to define the toggle state. Otherwise the item is displayed as action button. In this case the <code>selected</code> property is ignored.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bToggleEnabled">New value for property <code>toggleEnabled</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.ShellHeadItem setToggleEnabled(bool bToggleEnabled);

					#endregion

					#region Methods for Property showMarker

					/// <summary>
					/// Gets current value of property {@link #getShowMarker showMarker}.
					/// 
					/// If set to true, a theme dependent marker is shown on the item.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					[Obsolete("Deprecated since 1.18. Markers should not be used anymore.")]
					/// <returns>Value of property <code>showMarker</code></returns>
					public extern virtual bool getShowMarker();

					/// <summary>
					/// Sets a new value for property {@link #getShowMarker showMarker}.
					/// 
					/// If set to true, a theme dependent marker is shown on the item.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					[Obsolete("Deprecated since 1.18. Markers should not be used anymore.")]
					/// <param name="bShowMarker">New value for property <code>showMarker</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.ShellHeadItem setShowMarker(bool bShowMarker);

					#endregion

					#region Methods for Property icon

					/// <summary>
					/// Gets current value of property {@link #getIcon icon}.
					/// 
					/// The icon of the item, either defined in the sap.ui.core.IconPool or a URI to a custom image. An icon must be set.
					/// </summary>
					/// <returns>Value of property <code>icon</code></returns>
					public extern virtual sap.ui.core.URI getIcon();

					/// <summary>
					/// Sets a new value for property {@link #getIcon icon}.
					/// 
					/// The icon of the item, either defined in the sap.ui.core.IconPool or a URI to a custom image. An icon must be set.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sIcon">New value for property <code>icon</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.ShellHeadItem setIcon(sap.ui.core.URI sIcon);

					#endregion

					#region Methods for Property visible

					/// <summary>
					/// Gets current value of property {@link #getVisible visible}.
					/// 
					/// Invisible items are not shown on the UI.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>visible</code></returns>
					public extern virtual bool getVisible();

					/// <summary>
					/// Sets a new value for property {@link #getVisible visible}.
					/// 
					/// Invisible items are not shown on the UI.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bVisible">New value for property <code>visible</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.ShellHeadItem setVisible(bool bVisible);

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
					public extern virtual sap.ui.unified.ShellHeadItem addAriaLabelledBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaLabelledBy);

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

					#region Methods for Event press

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:press press} event of this <code>sap.ui.unified.ShellHeadItem</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.ShellHeadItem</code> itself.
					/// 
					/// Event is fired when the user presses the item.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.ShellHeadItem</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.ShellHeadItem attachPress(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:press press} event of this <code>sap.ui.unified.ShellHeadItem</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.ShellHeadItem</code> itself.
					/// 
					/// Event is fired when the user presses the item.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.ShellHeadItem attachPress(object oData, sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:press press} event of this <code>sap.ui.unified.ShellHeadItem</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.ShellHeadItem</code> itself.
					/// 
					/// Event is fired when the user presses the item.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.ShellHeadItem attachPress(sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:press press} event of this <code>sap.ui.unified.ShellHeadItem</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.ShellHeadItem</code> itself.
					/// 
					/// Event is fired when the user presses the item.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.ShellHeadItem</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.ShellHeadItem attachPress(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:press press} event of this <code>sap.ui.unified.ShellHeadItem</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.ShellHeadItem detachPress(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:press press} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.ShellHeadItem firePress(object mParameters);

					/// <summary>
					/// Fires event {@link #event:press press} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.ShellHeadItem firePress();

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.unified.ShellHeadItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.unified.ShellHeadItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.unified.ShellHeadItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.unified.ShellHeadItem.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					#endregion

					#endregion

				}
			}
		}
	}
}
