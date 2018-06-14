using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace OpenUI5Sharp
{
	public static partial class sap
	{
		public static partial class m
		{
			/// <summary>
			/// ViewSettingsItem is used for modelling filter behaviour in the ViewSettingsDialog. It is derived from a core Item, but does not support the base class properties "textDirection" and "enabled", setting these properties will not have any effects.
			/// </summary>
			[External]
			[Namespace(false)]
			public partial class ViewSettingsItem : sap.ui.core.Item
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
					/// Selected state of the item. If set to "true", the item will be displayed as selected in the view settings dialog.
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> selected;

					/// <summary>
					/// Let the outside world know that some of its properties has changed.
					/// </summary>
					public sap.m.ViewSettingsItem.ItemPropertyChangedDelegate itemPropertyChanged;

				}

				#endregion

				#region Typed Parameters

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class ItemPropertyChangedInfo
				{
					/// <summary>
					/// Instance of the item that changed.
					/// </summary>
					public sap.m.ViewSettingsItem changedItem;

					/// <summary>
					/// Key of the changed property.
					/// </summary>
					public string propertyKey;

					/// <summary>
					/// Value of the changed property.
					/// </summary>
					public object propertyValue;

				}

				#endregion

				#region Delegates

				public delegate void ItemPropertyChangedDelegate(sap.ui.@base.Event<sap.m.ViewSettingsItem.ItemPropertyChangedInfo> oEvent, object oData);

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new ViewSettingsItem.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">id for the new control, generated automatically if no id is given</param>
				/// <param name="mSettings">initial settings for the new control</param>
				public extern ViewSettingsItem(string sId, sap.m.ViewSettingsItem.Settings mSettings);

				/// <summary>
				/// Constructor for a new ViewSettingsItem.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">id for the new control, generated automatically if no id is given</param>
				public extern ViewSettingsItem(string sId);

				/// <summary>
				/// Constructor for a new ViewSettingsItem.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern ViewSettingsItem();

				/// <summary>
				/// Constructor for a new ViewSettingsItem.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">initial settings for the new control</param>
				public extern ViewSettingsItem(sap.m.ViewSettingsItem.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property selected

				/// <summary>
				/// Gets current value of property {@link #getSelected selected}.
				/// 
				/// Selected state of the item. If set to "true", the item will be displayed as selected in the view settings dialog.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>selected</code></returns>
				public extern virtual bool getSelected();

				/// <summary>
				/// Sets a new value for property {@link #getSelected selected}.
				/// 
				/// Selected state of the item. If set to "true", the item will be displayed as selected in the view settings dialog.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bSelected">New value for property <code>selected</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ViewSettingsItem setSelected(bool bSelected);

				#endregion

				#region Methods for Event itemPropertyChanged

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:itemPropertyChanged itemPropertyChanged} event of this <code>sap.m.ViewSettingsItem</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ViewSettingsItem</code> itself.
				/// 
				/// Let the outside world know that some of its properties has changed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ViewSettingsItem</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ViewSettingsItem attachItemPropertyChanged(object oData, sap.m.ViewSettingsItem.ItemPropertyChangedDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:itemPropertyChanged itemPropertyChanged} event of this <code>sap.m.ViewSettingsItem</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ViewSettingsItem</code> itself.
				/// 
				/// Let the outside world know that some of its properties has changed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ViewSettingsItem attachItemPropertyChanged(object oData, sap.m.ViewSettingsItem.ItemPropertyChangedDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:itemPropertyChanged itemPropertyChanged} event of this <code>sap.m.ViewSettingsItem</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ViewSettingsItem</code> itself.
				/// 
				/// Let the outside world know that some of its properties has changed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ViewSettingsItem attachItemPropertyChanged(sap.m.ViewSettingsItem.ItemPropertyChangedDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:itemPropertyChanged itemPropertyChanged} event of this <code>sap.m.ViewSettingsItem</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ViewSettingsItem</code> itself.
				/// 
				/// Let the outside world know that some of its properties has changed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ViewSettingsItem</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ViewSettingsItem attachItemPropertyChanged(sap.m.ViewSettingsItem.ItemPropertyChangedDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:itemPropertyChanged itemPropertyChanged} event of this <code>sap.m.ViewSettingsItem</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ViewSettingsItem detachItemPropertyChanged(sap.m.ViewSettingsItem.ItemPropertyChangedDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:itemPropertyChanged itemPropertyChanged} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ViewSettingsItem fireItemPropertyChanged(sap.m.ViewSettingsItem.ItemPropertyChangedInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:itemPropertyChanged itemPropertyChanged} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ViewSettingsItem fireItemPropertyChanged();

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.ViewSettingsItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Item.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.ViewSettingsItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Item.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.ViewSettingsItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Item.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.ViewSettingsItem.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				#endregion

				#endregion

			}
		}
	}
}
