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
			public static partial class ux3
			{
				/// <summary>
				/// DataSet Item
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.ux3.DataSetItem")]
				[Obsolete("Deprecated since 1.38.")]
				public partial class DataSetItem : sap.ui.core.Element
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
						/// image
						/// </summary>
						public Union<sap.ui.core.URI, string, sap.ui.@base.ManagedObject.BindPropertyInfo> iconSrc;

						/// <summary>
						/// title
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> title;

						/// <summary>
						/// checkable
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> checkable;

						/// <summary>
						/// subtitle
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> subtitle;

						/// <summary>
						/// Event Fired when Datset item is selected.
						/// </summary>
						public sap.ui.ux3.DataSetItem.SelectedDelegate selected;

					}

					#endregion

					#region Typed Parameters

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class SelectedInfo
					{
						/// <summary>
						/// Id of the selected Datset item
						/// </summary>
						public string itemId;

					}

					#endregion

					#region Delegates

					public delegate void SelectedDelegate(sap.ui.@base.Event<sap.ui.ux3.DataSetItem.SelectedInfo> oEvent, object oData);

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new DataSetItem.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern DataSetItem(string sId, sap.ui.ux3.DataSetItem.Settings mSettings);

					/// <summary>
					/// Constructor for a new DataSetItem.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern DataSetItem(string sId);

					/// <summary>
					/// Constructor for a new DataSetItem.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern DataSetItem();

					/// <summary>
					/// Constructor for a new DataSetItem.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern DataSetItem(sap.ui.ux3.DataSetItem.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property iconSrc

					/// <summary>
					/// Gets current value of property {@link #getIconSrc iconSrc}.
					/// 
					/// image
					/// </summary>
					/// <returns>Value of property <code>iconSrc</code></returns>
					public extern virtual sap.ui.core.URI getIconSrc();

					/// <summary>
					/// Sets a new value for property {@link #getIconSrc iconSrc}.
					/// 
					/// image
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sIconSrc">New value for property <code>iconSrc</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.DataSetItem setIconSrc(sap.ui.core.URI sIconSrc);

					#endregion

					#region Methods for Property title

					/// <summary>
					/// Gets current value of property {@link #getTitle title}.
					/// 
					/// title
					/// 
					/// Default value is <code>Title</code>.
					/// </summary>
					/// <returns>Value of property <code>title</code></returns>
					public extern virtual string getTitle();

					/// <summary>
					/// Sets a new value for property {@link #getTitle title}.
					/// 
					/// title
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>Title</code>.
					/// </summary>
					/// <param name="sTitle">New value for property <code>title</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.DataSetItem setTitle(string sTitle);

					#endregion

					#region Methods for Property checkable

					/// <summary>
					/// Gets current value of property {@link #getCheckable checkable}.
					/// 
					/// checkable
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>checkable</code></returns>
					public extern virtual bool getCheckable();

					/// <summary>
					/// Sets a new value for property {@link #getCheckable checkable}.
					/// 
					/// checkable
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bCheckable">New value for property <code>checkable</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.DataSetItem setCheckable(bool bCheckable);

					#endregion

					#region Methods for Property subtitle

					/// <summary>
					/// Gets current value of property {@link #getSubtitle subtitle}.
					/// 
					/// subtitle
					/// 
					/// Default value is <code>Subtitle</code>.
					/// </summary>
					/// <returns>Value of property <code>subtitle</code></returns>
					public extern virtual string getSubtitle();

					/// <summary>
					/// Sets a new value for property {@link #getSubtitle subtitle}.
					/// 
					/// subtitle
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>Subtitle</code>.
					/// </summary>
					/// <param name="sSubtitle">New value for property <code>subtitle</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.DataSetItem setSubtitle(string sSubtitle);

					#endregion

					#region Methods for Aggregation _template

					#endregion

					#region Methods for Event selected

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:selected selected} event of this <code>sap.ui.ux3.DataSetItem</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.DataSetItem</code> itself.
					/// 
					/// Event Fired when Datset item is selected.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.DataSetItem</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.DataSetItem attachSelected(object oData, sap.ui.ux3.DataSetItem.SelectedDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:selected selected} event of this <code>sap.ui.ux3.DataSetItem</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.DataSetItem</code> itself.
					/// 
					/// Event Fired when Datset item is selected.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.DataSetItem attachSelected(object oData, sap.ui.ux3.DataSetItem.SelectedDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:selected selected} event of this <code>sap.ui.ux3.DataSetItem</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.DataSetItem</code> itself.
					/// 
					/// Event Fired when Datset item is selected.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.DataSetItem attachSelected(sap.ui.ux3.DataSetItem.SelectedDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:selected selected} event of this <code>sap.ui.ux3.DataSetItem</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.DataSetItem</code> itself.
					/// 
					/// Event Fired when Datset item is selected.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.DataSetItem</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.DataSetItem attachSelected(sap.ui.ux3.DataSetItem.SelectedDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:selected selected} event of this <code>sap.ui.ux3.DataSetItem</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.DataSetItem detachSelected(sap.ui.ux3.DataSetItem.SelectedDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:selected selected} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.DataSetItem fireSelected(sap.ui.ux3.DataSetItem.SelectedInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:selected selected} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.DataSetItem fireSelected();

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.ux3.DataSetItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.ux3.DataSetItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.ux3.DataSetItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.ux3.DataSetItem.
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
