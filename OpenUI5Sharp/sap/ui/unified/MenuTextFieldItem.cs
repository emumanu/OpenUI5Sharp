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
				/// Special menu item which contains a label and a text field. This menu item is e.g. helpful for filter implementations. The aggregation <code>submenu</code> (inherited from parent class) is not supported for this type of menu item.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.unified.MenuTextFieldItem")]
				public partial class MenuTextFieldItem : sap.ui.unified.MenuItemBase
				{
					#region Settings

					/// <summary>
					/// Settings class to create the object
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class Settings : sap.ui.unified.MenuItemBase.Settings
					{
						/// <summary>
						/// Defines the label of the text field of the item.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> label;

						/// <summary>
						/// Defines the icon of the {@link sap.ui.core.IconPool sap.ui.core.IconPool} or an image which should be displayed on the item.
						/// </summary>
						public Union<sap.ui.core.URI, string, sap.ui.@base.ManagedObject.BindPropertyInfo> icon;

						/// <summary>
						/// Defines the value of the text field of the item.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> value;

						/// <summary>
						/// Defines the value state of the text field of the item. This allows you to visualize e.g. warnings or errors.
						/// </summary>
						public Union<sap.ui.core.ValueState, string, sap.ui.@base.ManagedObject.BindPropertyInfo> valueState;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new MenuTextFieldItem element.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">Id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern MenuTextFieldItem(string sId, sap.ui.unified.MenuTextFieldItem.Settings mSettings);

					/// <summary>
					/// Constructor for a new MenuTextFieldItem element.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">Id for the new control, generated automatically if no id is given</param>
					public extern MenuTextFieldItem(string sId);

					/// <summary>
					/// Constructor for a new MenuTextFieldItem element.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern MenuTextFieldItem();

					/// <summary>
					/// Constructor for a new MenuTextFieldItem element.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern MenuTextFieldItem(sap.ui.unified.MenuTextFieldItem.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property label

					/// <summary>
					/// Gets current value of property {@link #getLabel label}.
					/// 
					/// Defines the label of the text field of the item.
					/// </summary>
					/// <returns>Value of property <code>label</code></returns>
					public extern virtual string getLabel();

					/// <summary>
					/// Sets a new value for property {@link #getLabel label}.
					/// 
					/// Defines the label of the text field of the item.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sLabel">New value for property <code>label</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.MenuTextFieldItem setLabel(string sLabel);

					#endregion

					#region Methods for Property icon

					/// <summary>
					/// Gets current value of property {@link #getIcon icon}.
					/// 
					/// Defines the icon of the {@link sap.ui.core.IconPool sap.ui.core.IconPool} or an image which should be displayed on the item.
					/// </summary>
					/// <returns>Value of property <code>icon</code></returns>
					public extern virtual sap.ui.core.URI getIcon();

					/// <summary>
					/// Sets a new value for property {@link #getIcon icon}.
					/// 
					/// Defines the icon of the {@link sap.ui.core.IconPool sap.ui.core.IconPool} or an image which should be displayed on the item.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sIcon">New value for property <code>icon</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.MenuTextFieldItem setIcon(sap.ui.core.URI sIcon);

					#endregion

					#region Methods for Property value

					/// <summary>
					/// Gets current value of property {@link #getValue value}.
					/// 
					/// Defines the value of the text field of the item.
					/// </summary>
					/// <returns>Value of property <code>value</code></returns>
					public extern virtual string getValue();

					/// <summary>
					/// Sets a new value for property {@link #getValue value}.
					/// 
					/// Defines the value of the text field of the item.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sValue">New value for property <code>value</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.MenuTextFieldItem setValue(string sValue);

					#endregion

					#region Methods for Property valueState

					/// <summary>
					/// Gets current value of property {@link #getValueState valueState}.
					/// 
					/// Defines the value state of the text field of the item. This allows you to visualize e.g. warnings or errors.
					/// 
					/// Default value is <code>None</code>.
					/// </summary>
					/// <returns>Value of property <code>valueState</code></returns>
					public extern virtual sap.ui.core.ValueState getValueState();

					/// <summary>
					/// Sets a new value for property {@link #getValueState valueState}.
					/// 
					/// Defines the value state of the text field of the item. This allows you to visualize e.g. warnings or errors.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>None</code>.
					/// </summary>
					/// <param name="sValueState">New value for property <code>valueState</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.MenuTextFieldItem setValueState(sap.ui.core.ValueState sValueState);

					#endregion

					#region Other methods

					/// <summary>
					/// The aggregation <code>submenu</code> (inherited from parent class) is not supported for this type of menu item.
					/// </summary>
					/// <returns><code>this</code> to allow method chaining</returns>
					[Obsolete("Deprecated since 1.21. the aggregation <code>submenu</code> (inherited from parent class) is not supported for this type of menu item.")]
					public extern virtual sap.ui.unified.MenuTextFieldItem destroySubmenu();

					/// <summary>
					/// Creates a new subclass of class sap.ui.unified.MenuTextFieldItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.unified.MenuItemBase.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.unified.MenuTextFieldItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.unified.MenuItemBase.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.unified.MenuTextFieldItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.unified.MenuItemBase.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.unified.MenuTextFieldItem.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					/// <summary>
					/// The aggregation <code>submenu</code> (inherited from parent class) is not supported for this type of menu item.
					/// </summary>
					/// <returns></returns>
					[Obsolete("Deprecated since 1.21. the aggregation <code>submenu</code> (inherited from parent class) is not supported for this type of menu item.")]
					public extern override sap.ui.unified.Menu getSubmenu();

					/// <summary>
					/// The aggregation <code>submenu</code> (inherited from parent class) is not supported for this type of menu item.
					/// </summary>
					/// <param name="oMenu">The menu to which the sap.ui.unified.Submenu should be set</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					[Obsolete("Deprecated since 1.21. the aggregation <code>submenu</code> (inherited from parent class) is not supported for this type of menu item.")]
					public extern virtual sap.ui.unified.MenuTextFieldItem setSubmenu(sap.ui.unified.Menu oMenu);

					#endregion

					#endregion

				}
			}
		}
	}
}
