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
			/// An item to be used in a TabContainer.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.TabContainerItem")]
			public partial class TabContainerItem : sap.ui.core.Element
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
					/// Determines the text to be displayed for the item.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> name;

					/// <summary>
					/// Determines the name of the item. Can be used as input for subsequent actions.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> key;

					/// <summary>
					/// Shows if a control is edited (default is false). Items that are marked as modified have a * symbol to indicate that they haven't been saved.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> modified;

					/// <summary>
					/// The content displayed for this item.
					/// </summary>
					public Union<sap.ui.core.Control[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> content;

					/// <summary>
					/// Sends information that some of the properties have changed.
					/// </summary>
					public sap.m.TabContainerItem.ItemPropertyChangedDelegate itemPropertyChanged;

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
					/// The item changed.
					/// </summary>
					public sap.m.TabContainerItem itemChanged;

					/// <summary>
					/// The key of the property.
					/// </summary>
					public string propertyKey;

					/// <summary>
					/// The value of the property.
					/// </summary>
					public object propertyValue;

				}

				#endregion

				#region Delegates

				public delegate void ItemPropertyChangedDelegate(sap.ui.@base.Event<sap.m.TabContainerItem.ItemPropertyChangedInfo> oEvent, object oData);

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new <code>TabContainerItem</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern TabContainerItem(string sId, sap.m.TabContainerItem.Settings mSettings);

				/// <summary>
				/// Constructor for a new <code>TabContainerItem</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern TabContainerItem(string sId);

				/// <summary>
				/// Constructor for a new <code>TabContainerItem</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern TabContainerItem();

				/// <summary>
				/// Constructor for a new <code>TabContainerItem</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern TabContainerItem(sap.m.TabContainerItem.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property name

				/// <summary>
				/// Gets current value of property {@link #getName name}.
				/// 
				/// Determines the text to be displayed for the item.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <returns>Value of property <code>name</code></returns>
				public extern virtual string getName();

				/// <summary>
				/// Sets a new value for property {@link #getName name}.
				/// 
				/// Determines the text to be displayed for the item.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <param name="sName">New value for property <code>name</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TabContainerItem setName(string sName);

				#endregion

				#region Methods for Property key

				/// <summary>
				/// Gets current value of property {@link #getKey key}.
				/// 
				/// Determines the name of the item. Can be used as input for subsequent actions.
				/// </summary>
				/// <returns>Value of property <code>key</code></returns>
				public extern virtual string getKey();

				/// <summary>
				/// Sets a new value for property {@link #getKey key}.
				/// 
				/// Determines the name of the item. Can be used as input for subsequent actions.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sKey">New value for property <code>key</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TabContainerItem setKey(string sKey);

				#endregion

				#region Methods for Property modified

				/// <summary>
				/// Gets current value of property {@link #getModified modified}.
				/// 
				/// Shows if a control is edited (default is false). Items that are marked as modified have a * symbol to indicate that they haven't been saved.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>modified</code></returns>
				public extern virtual bool getModified();

				/// <summary>
				/// Sets a new value for property {@link #getModified modified}.
				/// 
				/// Shows if a control is edited (default is false). Items that are marked as modified have a * symbol to indicate that they haven't been saved.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bModified">New value for property <code>modified</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TabContainerItem setModified(bool bModified);

				#endregion

				#region Methods for Aggregation content

				/// <summary>
				/// Gets content of aggregation {@link #getContent content}.
				/// 
				/// The content displayed for this item.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.Control[] getContent();

				/// <summary>
				/// Destroys all the content in the aggregation {@link #getContent content}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TabContainerItem destroyContent();

				/// <summary>
				/// Inserts a content into the aggregation {@link #getContent content}.
				/// </summary>
				/// <param name="oContent">The content to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the content should be inserted at; for a negative value of <code>iIndex</code>, the content is inserted at position 0; for a value greater than the current size of the aggregation, the content is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TabContainerItem insertContent(sap.ui.core.Control oContent, int iIndex);

				/// <summary>
				/// Adds some content to the aggregation {@link #getContent content}.
				/// </summary>
				/// <param name="oContent">The content to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TabContainerItem addContent(sap.ui.core.Control oContent);

				/// <summary>
				/// Removes a content from the aggregation {@link #getContent content}.
				/// </summary>
				/// <param name="vContent">The content to remove or its index or id</param>
				/// <returns>The removed content or <code>null</code></returns>
				public extern virtual sap.ui.core.Control removeContent(Union<int, string, sap.ui.core.Control> vContent);

				/// <summary>
				/// Checks for the provided <code>sap.ui.core.Control</code> in the aggregation {@link #getContent content}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oContent">The content whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfContent(sap.ui.core.Control oContent);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getContent content}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.ui.core.Control[] removeAllContent();

				#endregion

				#region Methods for Event itemPropertyChanged

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:itemPropertyChanged itemPropertyChanged} event of this <code>sap.m.TabContainerItem</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.TabContainerItem</code> itself.
				/// 
				/// Sends information that some of the properties have changed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.TabContainerItem</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TabContainerItem attachItemPropertyChanged(object oData, sap.m.TabContainerItem.ItemPropertyChangedDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:itemPropertyChanged itemPropertyChanged} event of this <code>sap.m.TabContainerItem</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.TabContainerItem</code> itself.
				/// 
				/// Sends information that some of the properties have changed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TabContainerItem attachItemPropertyChanged(object oData, sap.m.TabContainerItem.ItemPropertyChangedDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:itemPropertyChanged itemPropertyChanged} event of this <code>sap.m.TabContainerItem</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.TabContainerItem</code> itself.
				/// 
				/// Sends information that some of the properties have changed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TabContainerItem attachItemPropertyChanged(sap.m.TabContainerItem.ItemPropertyChangedDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:itemPropertyChanged itemPropertyChanged} event of this <code>sap.m.TabContainerItem</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.TabContainerItem</code> itself.
				/// 
				/// Sends information that some of the properties have changed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.TabContainerItem</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TabContainerItem attachItemPropertyChanged(sap.m.TabContainerItem.ItemPropertyChangedDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:itemPropertyChanged itemPropertyChanged} event of this <code>sap.m.TabContainerItem</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TabContainerItem detachItemPropertyChanged(sap.m.TabContainerItem.ItemPropertyChangedDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:itemPropertyChanged itemPropertyChanged} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TabContainerItem fireItemPropertyChanged(sap.m.TabContainerItem.ItemPropertyChangedInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:itemPropertyChanged itemPropertyChanged} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TabContainerItem fireItemPropertyChanged();

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.TabContainerItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.TabContainerItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.TabContainerItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.TabContainerItem.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				/// <summary>
				/// Overwrites the method in order to suppress invalidation for some properties.
				/// </summary>
				/// <param name="sName">Property name to be set</param>
				/// <param name="vValue">Property value to be set</param>
				/// <param name="bSuppressInvalidation">Whether invalidation to be suppressed</param>
				/// <returns>This instance for chaining</returns>
				public extern virtual sap.m.TabContainerItem setProperty(string sName, Union<bool, string, object> vValue, bool bSuppressInvalidation);

				#endregion

				#endregion

			}
		}
	}
}
