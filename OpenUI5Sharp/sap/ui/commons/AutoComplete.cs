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
			public static partial class commons
			{
				/// <summary>
				/// Textfield with list based text completion.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.AutoComplete")]
				[Obsolete("Deprecated since 1.38.")]
				public partial class AutoComplete : sap.ui.commons.ComboBox, sap.ui.commons.ToolbarItem
				{
					#region Settings

					/// <summary>
					/// Settings class to create the object
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class Settings : sap.ui.commons.ComboBox.Settings
					{
						/// <summary>
						/// Determines whether scrolling should be enabled when the number of items is higher than maxPopupItems. If set to false only the first n items (n=maxPopupItems) are shown.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> enableScrolling;

						/// <summary>
						/// Fired when the user has changed the value and a suggestion list update should occur.
						/// </summary>
						public sap.m.SuggestDelegate suggest;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new AutoComplete.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern AutoComplete(string sId, sap.ui.commons.AutoComplete.Settings mSettings);

					/// <summary>
					/// Constructor for a new AutoComplete.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					public extern AutoComplete(string sId);

					/// <summary>
					/// Constructor for a new AutoComplete.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern AutoComplete();

					/// <summary>
					/// Constructor for a new AutoComplete.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern AutoComplete(sap.ui.commons.AutoComplete.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property enableScrolling

					/// <summary>
					/// Gets current value of property {@link #getEnableScrolling enableScrolling}.
					/// 
					/// Determines whether scrolling should be enabled when the number of items is higher than maxPopupItems. If set to false only the first n items (n=maxPopupItems) are shown.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>enableScrolling</code></returns>
					public extern virtual bool getEnableScrolling();

					/// <summary>
					/// Sets a new value for property {@link #getEnableScrolling enableScrolling}.
					/// 
					/// Determines whether scrolling should be enabled when the number of items is higher than maxPopupItems. If set to false only the first n items (n=maxPopupItems) are shown.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bEnableScrolling">New value for property <code>enableScrolling</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.AutoComplete setEnableScrolling(bool bEnableScrolling);

					#endregion

					#region Methods for Event suggest

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:suggest suggest} event of this <code>sap.ui.commons.AutoComplete</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.AutoComplete</code> itself.
					/// 
					/// Fired when the user has changed the value and a suggestion list update should occur.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.AutoComplete</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.AutoComplete attachSuggest(object oData, sap.m.SuggestDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:suggest suggest} event of this <code>sap.ui.commons.AutoComplete</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.AutoComplete</code> itself.
					/// 
					/// Fired when the user has changed the value and a suggestion list update should occur.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.AutoComplete attachSuggest(object oData, sap.m.SuggestDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:suggest suggest} event of this <code>sap.ui.commons.AutoComplete</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.AutoComplete</code> itself.
					/// 
					/// Fired when the user has changed the value and a suggestion list update should occur.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.AutoComplete attachSuggest(sap.m.SuggestDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:suggest suggest} event of this <code>sap.ui.commons.AutoComplete</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.AutoComplete</code> itself.
					/// 
					/// Fired when the user has changed the value and a suggestion list update should occur.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.AutoComplete</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.AutoComplete attachSuggest(sap.m.SuggestDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:suggest suggest} event of this <code>sap.ui.commons.AutoComplete</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.AutoComplete detachSuggest(sap.m.SuggestDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:suggest suggest} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.AutoComplete fireSuggest(sap.m.SuggestInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:suggest suggest} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.AutoComplete fireSuggest();

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.AutoComplete with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.commons.ComboBox.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.AutoComplete with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.commons.ComboBox.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.AutoComplete with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.commons.ComboBox.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					[Obsolete("Deprecated since 1.10.0. NOT SUPPORTED")]
					public extern virtual void getListBox();

					/// <summary>
					/// Returns a metadata object for class sap.ui.commons.AutoComplete.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					[Name("getMetadata")]
					public extern static sap.ui.@base.Metadata getMetadataStatic();

					[Obsolete("Deprecated since 1.10.0. NOT SUPPORTED")]
					public extern virtual void getSelectedItemId();

					[Obsolete("Deprecated since 1.10.0. NOT SUPPORTED")]
					public extern virtual void getSelectedKey();

					/// <summary>
					/// Sets a custom filter function for items. Default is to check whether the item text begins with the typed value.
					/// 
					/// Example: <code> function(sValue, oItem){ return jQuery.sap.startsWithIgnoreCase(oItem.getText(), sValue); } </code>
					/// </summary>
					/// <param name="fFilter">The filter function. If not set the default filter function will be used.</param>
					public extern virtual void setFilterFunction(object fFilter);

					/// <summary>
					/// Sets a custom filter function for items. Default is to check whether the item text begins with the typed value.
					/// 
					/// Example: <code> function(sValue, oItem){ return jQuery.sap.startsWithIgnoreCase(oItem.getText(), sValue); } </code>
					/// </summary>
					public extern virtual void setFilterFunction();

					[Obsolete("Deprecated since 1.10.0. NOT SUPPORTED")]
					public extern virtual void setListBox();

					[Obsolete("Deprecated since 1.10.0. NOT SUPPORTED")]
					public extern virtual void setSelectedItemId();

					[Obsolete("Deprecated since 1.10.0. NOT SUPPORTED")]
					public extern virtual void setSelectedKey();

					#endregion

					#endregion

				}
			}
		}
	}
}
