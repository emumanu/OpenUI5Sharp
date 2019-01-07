using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public partial class sap
	{
		public static partial class ui
		{
			public static partial class core
			{
				/// <summary>
				/// A control base type.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.core.Item")]
				public partial class Item : sap.ui.core.Element
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
						/// The text to be displayed for the item.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> text;

						/// <summary>
						/// Enabled items can be selected.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> enabled;

						/// <summary>
						/// Options are RTL and LTR. Alternatively, an item can inherit its text direction from its parent control.
						/// </summary>
						public Union<sap.ui.core.TextDirection, string, sap.ui.@base.ManagedObject.BindPropertyInfo> textDirection;

						/// <summary>
						/// Can be used as input for subsequent actions.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> key;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new Item.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern Item(string sId, sap.ui.core.Item.Settings mSettings);

					/// <summary>
					/// Constructor for a new Item.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern Item(string sId);

					/// <summary>
					/// Constructor for a new Item.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern Item();

					/// <summary>
					/// Constructor for a new Item.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern Item(sap.ui.core.Item.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property text

					/// <summary>
					/// Gets current value of property {@link #getText text}.
					/// 
					/// The text to be displayed for the item.
					/// 
					/// Default value is <code>empty string</code>.
					/// </summary>
					/// <returns>Value of property <code>text</code></returns>
					public extern virtual string getText();

					/// <summary>
					/// Sets a new value for property {@link #getText text}.
					/// 
					/// The text to be displayed for the item.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>empty string</code>.
					/// </summary>
					/// <param name="sText">New value for property <code>text</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.Item setText(string sText);

					#endregion

					#region Methods for Property enabled

					/// <summary>
					/// Gets current value of property {@link #getEnabled enabled}.
					/// 
					/// Enabled items can be selected.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>enabled</code></returns>
					public extern virtual bool getEnabled();

					/// <summary>
					/// Sets a new value for property {@link #getEnabled enabled}.
					/// 
					/// Enabled items can be selected.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bEnabled">New value for property <code>enabled</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.Item setEnabled(bool bEnabled);

					#endregion

					#region Methods for Property textDirection

					/// <summary>
					/// Gets current value of property {@link #getTextDirection textDirection}.
					/// 
					/// Options are RTL and LTR. Alternatively, an item can inherit its text direction from its parent control.
					/// 
					/// Default value is <code>Inherit</code>.
					/// </summary>
					/// <returns>Value of property <code>textDirection</code></returns>
					public extern virtual sap.ui.core.TextDirection getTextDirection();

					/// <summary>
					/// Sets a new value for property {@link #getTextDirection textDirection}.
					/// 
					/// Options are RTL and LTR. Alternatively, an item can inherit its text direction from its parent control.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>Inherit</code>.
					/// </summary>
					/// <param name="sTextDirection">New value for property <code>textDirection</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.Item setTextDirection(sap.ui.core.TextDirection sTextDirection);

					#endregion

					#region Methods for Property key

					/// <summary>
					/// Gets current value of property {@link #getKey key}.
					/// 
					/// Can be used as input for subsequent actions.
					/// </summary>
					/// <returns>Value of property <code>key</code></returns>
					public extern virtual string getKey();

					/// <summary>
					/// Sets a new value for property {@link #getKey key}.
					/// 
					/// Can be used as input for subsequent actions.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sKey">New value for property <code>key</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.Item setKey(string sKey);

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.Item with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.Item with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.Item with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.core.Item.
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
