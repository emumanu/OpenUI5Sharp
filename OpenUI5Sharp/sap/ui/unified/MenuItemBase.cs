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
			public static partial class unified
			{
				/// <summary>
				/// Abstract base class for menu item which provides common properties and events for all concrete item implementations.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.unified.MenuItemBase")]
				public abstract partial class MenuItemBase : sap.ui.core.Element
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
						/// When an item is disabled the item can not be selected by the user. The enabled property of the item has no effect when the menu of the item is disabled ({@link sap.ui.unified.Menu#getEnabled Menu#getEnabled}).
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> enabled;

						/// <summary>
						/// Invisible items do not appear in the menu.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> visible;

						/// <summary>
						/// Defines whether a visual separator should be rendered before the item. <b>Note:</b> If an item is invisible also the separator of this item is not shown.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> startsSection;

						/// <summary>
						/// An optional submenu of the item which is opened when the item is selected by the user.
						/// </summary>
						public Union<sap.ui.unified.Menu, string, sap.ui.@base.ManagedObject.BindAggregationInfo> submenu;

						/// <summary>
						/// Fired when the item is selected by the user. <b>Note:</b> The event is also available for items which have a submenu. In general, applications must not handle event in this case because the user selection opens the sub menu.
						/// </summary>
						public sap.ui.unified.Menu.SelectDelegate select;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Abstract base class <code>MenuItemBase</code> for menu item elements. Please use concrete subclasses.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">Id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern MenuItemBase(string sId, sap.ui.unified.MenuItemBase.Settings mSettings);

					/// <summary>
					/// Abstract base class <code>MenuItemBase</code> for menu item elements. Please use concrete subclasses.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">Id for the new control, generated automatically if no id is given</param>
					public extern MenuItemBase(string sId);

					/// <summary>
					/// Abstract base class <code>MenuItemBase</code> for menu item elements. Please use concrete subclasses.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern MenuItemBase();

					/// <summary>
					/// Abstract base class <code>MenuItemBase</code> for menu item elements. Please use concrete subclasses.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern MenuItemBase(sap.ui.unified.MenuItemBase.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property enabled

					/// <summary>
					/// Gets current value of property {@link #getEnabled enabled}.
					/// 
					/// When an item is disabled the item can not be selected by the user. The enabled property of the item has no effect when the menu of the item is disabled ({@link sap.ui.unified.Menu#getEnabled Menu#getEnabled}).
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>enabled</code></returns>
					public extern virtual bool getEnabled();

					/// <summary>
					/// Sets a new value for property {@link #getEnabled enabled}.
					/// 
					/// When an item is disabled the item can not be selected by the user. The enabled property of the item has no effect when the menu of the item is disabled ({@link sap.ui.unified.Menu#getEnabled Menu#getEnabled}).
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bEnabled">New value for property <code>enabled</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.MenuItemBase setEnabled(bool bEnabled);

					#endregion

					#region Methods for Property visible

					/// <summary>
					/// Gets current value of property {@link #getVisible visible}.
					/// 
					/// Invisible items do not appear in the menu.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>visible</code></returns>
					public extern virtual bool getVisible();

					/// <summary>
					/// Sets a new value for property {@link #getVisible visible}.
					/// 
					/// Invisible items do not appear in the menu.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bVisible">New value for property <code>visible</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.MenuItemBase setVisible(bool bVisible);

					#endregion

					#region Methods for Property startsSection

					/// <summary>
					/// Gets current value of property {@link #getStartsSection startsSection}.
					/// 
					/// Defines whether a visual separator should be rendered before the item. <b>Note:</b> If an item is invisible also the separator of this item is not shown.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>startsSection</code></returns>
					public extern virtual bool getStartsSection();

					/// <summary>
					/// Sets a new value for property {@link #getStartsSection startsSection}.
					/// 
					/// Defines whether a visual separator should be rendered before the item. <b>Note:</b> If an item is invisible also the separator of this item is not shown.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bStartsSection">New value for property <code>startsSection</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.MenuItemBase setStartsSection(bool bStartsSection);

					#endregion

					#region Methods for Aggregation submenu

					/// <summary>
					/// Gets content of aggregation {@link #getSubmenu submenu}.
					/// 
					/// An optional submenu of the item which is opened when the item is selected by the user.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.unified.Menu getSubmenu();

					/// <summary>
					/// Destroys the submenu in the aggregation {@link #getSubmenu submenu}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.MenuItemBase destroySubmenu();

					/// <summary>
					/// Sets the aggregated {@link #getSubmenu submenu}.
					/// </summary>
					/// <param name="oSubmenu">The submenu to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.MenuItemBase setSubmenu(sap.ui.unified.Menu oSubmenu);

					#endregion

					#region Methods for Event select

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.ui.unified.MenuItemBase</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.MenuItemBase</code> itself.
					/// 
					/// Fired when the item is selected by the user. <b>Note:</b> The event is also available for items which have a submenu. In general, applications must not handle event in this case because the user selection opens the sub menu.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.MenuItemBase</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.MenuItemBase attachSelect(object oData, sap.ui.unified.Menu.SelectDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.ui.unified.MenuItemBase</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.MenuItemBase</code> itself.
					/// 
					/// Fired when the item is selected by the user. <b>Note:</b> The event is also available for items which have a submenu. In general, applications must not handle event in this case because the user selection opens the sub menu.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.MenuItemBase attachSelect(object oData, sap.ui.unified.Menu.SelectDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.ui.unified.MenuItemBase</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.MenuItemBase</code> itself.
					/// 
					/// Fired when the item is selected by the user. <b>Note:</b> The event is also available for items which have a submenu. In general, applications must not handle event in this case because the user selection opens the sub menu.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.MenuItemBase attachSelect(sap.ui.unified.Menu.SelectDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:select select} event of this <code>sap.ui.unified.MenuItemBase</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.MenuItemBase</code> itself.
					/// 
					/// Fired when the item is selected by the user. <b>Note:</b> The event is also available for items which have a submenu. In general, applications must not handle event in this case because the user selection opens the sub menu.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.MenuItemBase</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.MenuItemBase attachSelect(sap.ui.unified.Menu.SelectDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:select select} event of this <code>sap.ui.unified.MenuItemBase</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.MenuItemBase detachSelect(sap.ui.unified.Menu.SelectDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:select select} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.MenuItemBase fireSelect(sap.ui.unified.Menu.SelectInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:select select} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.MenuItemBase fireSelect();

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.unified.MenuItemBase with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.unified.MenuItemBase with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.unified.MenuItemBase with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.unified.MenuItemBase.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					[Name("getMetadata")]
					public extern static sap.ui.@base.Metadata getMetadataStatic();

					/// <summary>
					/// Changes the visual hover state of the menu item.
					/// 
					/// Subclasses may override this function.
					/// </summary>
					/// <param name="bHovered">Specifies whether the item is currently hovered or not.</param>
					/// <param name="oMenu">The menu to which this item belongs</param>
					public extern virtual void hover(bool bHovered, sap.ui.unified.Menu oMenu);

					/// <summary>
					/// Informs the item that the item HTML is now applied to the DOM.
					/// 
					/// Subclasses may override this function.
					/// </summary>
					public extern virtual void onAfterRendering();

					/// <summary>
					/// Event handler which is called whenever the submenu of the item is opened or closed.
					/// 
					/// Subclasses may override this function.
					/// </summary>
					/// <param name="bOpened">Specifies whether the submenu of the item is opened or closed</param>
					public extern virtual void onSubmenuToggle(bool bOpened);

					/// <summary>
					/// Produces the HTML of an item and writes it to render-output-buffer during the rendering of the corresponding menu.
					/// 
					/// Subclasses may override this function.
					/// </summary>
					/// <param name="oRenderManager">The <code>RenderManager</code> that can be used for writing to the render-output-buffer</param>
					/// <param name="oItem">The item which should be rendered</param>
					/// <param name="oMenu">The menu to which this item belongs</param>
					public extern virtual void render(sap.ui.core.RenderManager oRenderManager, sap.ui.unified.MenuItemBase oItem, sap.ui.unified.Menu oMenu);

					#endregion

					#endregion

				}
			}
		}
	}
}
