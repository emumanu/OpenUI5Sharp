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
				/// An item that is used in lists or list-similar controls such as DropdownBox, for example. The element foresees the usage of additional texts displayed in a second column.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.core.ListItem")]
				public partial class ListItem : sap.ui.core.Item
				{
					#region Settings

					/// <summary>
					/// Settings class to create the object
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class Settings : sap.ui.core.Item.Settings
					{
						/// <summary>
						/// The icon belonging to this list item instance. This can be a URI to an image or an icon font URI.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> icon;

						/// <summary>
						/// Some additional text of type string, optionally to be displayed along with this item.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> additionalText;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new ListItem.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern ListItem(string sId, sap.ui.core.ListItem.Settings mSettings);

					/// <summary>
					/// Constructor for a new ListItem.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern ListItem(string sId);

					/// <summary>
					/// Constructor for a new ListItem.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern ListItem();

					/// <summary>
					/// Constructor for a new ListItem.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern ListItem(sap.ui.core.ListItem.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property icon

					/// <summary>
					/// Gets current value of property {@link #getIcon icon}.
					/// 
					/// The icon belonging to this list item instance. This can be a URI to an image or an icon font URI.
					/// </summary>
					/// <returns>Value of property <code>icon</code></returns>
					public extern virtual string getIcon();

					/// <summary>
					/// Sets a new value for property {@link #getIcon icon}.
					/// 
					/// The icon belonging to this list item instance. This can be a URI to an image or an icon font URI.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sIcon">New value for property <code>icon</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.ListItem setIcon(string sIcon);

					#endregion

					#region Methods for Property additionalText

					/// <summary>
					/// Gets current value of property {@link #getAdditionalText additionalText}.
					/// 
					/// Some additional text of type string, optionally to be displayed along with this item.
					/// </summary>
					/// <returns>Value of property <code>additionalText</code></returns>
					public extern virtual string getAdditionalText();

					/// <summary>
					/// Sets a new value for property {@link #getAdditionalText additionalText}.
					/// 
					/// Some additional text of type string, optionally to be displayed along with this item.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sAdditionalText">New value for property <code>additionalText</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.ListItem setAdditionalText(string sAdditionalText);

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.ListItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Item.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.ListItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Item.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.ListItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Item.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.core.ListItem.
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
