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
			/// Represents a list of values for the {@link sap.m.FacetFilter} control.
			/// 
			/// <b>Note: </b><code>FacetFilterList</code> is a subclass of {@link sap.m.List} and supports growing enablement feature via the property <code>growing</code>. When you use this feature, be aware that it only works with one-way data binding. Having growing feature enabled when the <code>items</code> aggregation is bound to a model with two-way data binding, may lead to unexpected and/or inconsistent behavior across browsers, such as unexpected closing of the list.
			/// 
			/// While the <code>FacetFilterList</code> popup is opened (when the user selects a button corresponding to the list's name), any other activities leading to focus change will close it. For example, when the popup is opened and the app developer loads a {@link sap.m.BusyDialog} or any other dialog that obtains the focus, the popup will be closed.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.FacetFilterList")]
			public partial class FacetFilterList : sap.m.List
			{
				#region Settings

				/// <summary>
				/// Settings class to create the object
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class Settings : sap.m.List.Settings
				{
					/// <summary>
					/// Defines the title of the facet. The facet title is displayed on the facet button when the FacetFilter type is set to <code>Simple</code>. It is also displayed as a list item in the facet page of the dialog.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> title;

					/// <summary>
					/// If set to <code>true</code>, the item text wraps when it is too long.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> wordWrap;

					/// <summary>
					/// Specifies whether multiple or single selection is used.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> multiSelect;

					/// <summary>
					/// Indicates that the list is displayed as a button when the FacetFilter type is set to <code>Simple</code>.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> active;

					/// <summary>
					/// If set to <code>true</code>, enables case-insensitive search for OData.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> enableCaseInsensitiveSearch;

					/// <summary>
					/// Determines the number of objects that match this item in the target data set when all filter items are selected.
					/// </summary>
					public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> allCount;

					/// <summary>
					/// Sequence that determines the order in which FacetFilterList is shown on the FacetFilter. Lists are rendered by ascending order of sequence.
					/// </summary>
					public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> sequence;

					/// <summary>
					/// Unique identifier for this filter list.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> key;

					/// <summary>
					/// Specifies whether remove icon for facet is visible or hidden.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showRemoveFacetIcon;

					/// <summary>
					/// Retains the list sequence if it is inactive and made active again.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> retainListSequence;

					/// <summary>
					/// FacetFilterList data type. Only String data type will provide search function.
					/// </summary>
					public Union<sap.m.FacetFilterListDataType, string, sap.ui.@base.ManagedObject.BindPropertyInfo> dataType;

					/// <summary>
					/// Fired before the filter list is opened.
					/// </summary>
					public sap.ui.@base.EventDelegate listOpen;

					/// <summary>
					/// Triggered after the list of items is closed.
					/// </summary>
					public sap.m.FacetFilterList.ListCloseDelegate listClose;

				}

				#endregion

				#region Typed Parameters

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class ListCloseInfo
				{
					/// <summary>
					/// Array of selected items. Items returned are only copies and therefore can only be used to read properties, not set them.
					/// </summary>
					public sap.m.FacetFilterItem[] selectedItems;

					/// <summary>
					/// <code>True</code> if the select All checkbox is selected. This will be <code>false</code> if all items are actually selected (every FacetFilterItem.selected == true). In that case selectedItems will contain all selected items.
					/// </summary>
					public bool allSelected;

					/// <summary>
					/// Associative array containing the keys of selected FacetFilterItems. Unlike the selectedItems parameter, this contains only the keys for all selected items, not the items themselves. Being an associative array, each object property is the FacetFilterItem key value and the value of the property is the FacetFilterItem text.
					/// </summary>
					public object selectedKeys;

				}

				#endregion

				#region Delegates

				public delegate void ListCloseDelegate(sap.ui.@base.Event<sap.m.FacetFilterList.ListCloseInfo> oEvent, object oData);

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new <code>FacetFilterList</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern FacetFilterList(string sId, sap.m.FacetFilterList.Settings mSettings);

				/// <summary>
				/// Constructor for a new <code>FacetFilterList</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern FacetFilterList(string sId);

				/// <summary>
				/// Constructor for a new <code>FacetFilterList</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern FacetFilterList();

				/// <summary>
				/// Constructor for a new <code>FacetFilterList</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern FacetFilterList(sap.m.FacetFilterList.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property title

				/// <summary>
				/// Gets current value of property {@link #getTitle title}.
				/// 
				/// Defines the title of the facet. The facet title is displayed on the facet button when the FacetFilter type is set to <code>Simple</code>. It is also displayed as a list item in the facet page of the dialog.
				/// </summary>
				/// <returns>Value of property <code>title</code></returns>
				public extern virtual string getTitle();

				/// <summary>
				/// Sets a new value for property {@link #getTitle title}.
				/// 
				/// Defines the title of the facet. The facet title is displayed on the facet button when the FacetFilter type is set to <code>Simple</code>. It is also displayed as a list item in the facet page of the dialog.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sTitle">New value for property <code>title</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FacetFilterList setTitle(string sTitle);

				#endregion

				#region Methods for Property wordWrap

				/// <summary>
				/// Gets current value of property {@link #getWordWrap wordWrap}.
				/// 
				/// If set to <code>true</code>, the item text wraps when it is too long.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>wordWrap</code></returns>
				public extern virtual bool getWordWrap();

				/// <summary>
				/// Sets a new value for property {@link #getWordWrap wordWrap}.
				/// 
				/// If set to <code>true</code>, the item text wraps when it is too long.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bWordWrap">New value for property <code>wordWrap</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FacetFilterList setWordWrap(bool bWordWrap);

				#endregion

				#region Methods for Property multiSelect

				/// <summary>
				/// Gets current value of property {@link #getMultiSelect multiSelect}.
				/// 
				/// Specifies whether multiple or single selection is used.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>multiSelect</code></returns>
				[Obsolete("Deprecated since 1.20.0. replaced by <code>setMode</code> method. <code>FacetFilterList</code> overrides the <code>setMode</code> method to restrict the possible modes to <code>MultiSelect</code> and <code>SingleSelectMaster</code>. All other modes are ignored and will not be set.")]
				public extern virtual bool getMultiSelect();

				/// <summary>
				/// Sets a new value for property {@link #getMultiSelect multiSelect}.
				/// 
				/// Specifies whether multiple or single selection is used.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bMultiSelect">New value for property <code>multiSelect</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.20.0. replaced by <code>setMode</code> method. <code>FacetFilterList</code> overrides the <code>setMode</code> method to restrict the possible modes to <code>MultiSelect</code> and <code>SingleSelectMaster</code>. All other modes are ignored and will not be set.")]
				public extern virtual sap.m.FacetFilterList setMultiSelect(bool bMultiSelect);

				#endregion

				#region Methods for Property active

				/// <summary>
				/// Gets current value of property {@link #getActive active}.
				/// 
				/// Indicates that the list is displayed as a button when the FacetFilter type is set to <code>Simple</code>.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>active</code></returns>
				public extern virtual bool getActive();

				/// <summary>
				/// Sets a new value for property {@link #getActive active}.
				/// 
				/// Indicates that the list is displayed as a button when the FacetFilter type is set to <code>Simple</code>.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bActive">New value for property <code>active</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FacetFilterList setActive(bool bActive);

				#endregion

				#region Methods for Property enableCaseInsensitiveSearch

				/// <summary>
				/// Gets current value of property {@link #getEnableCaseInsensitiveSearch enableCaseInsensitiveSearch}.
				/// 
				/// If set to <code>true</code>, enables case-insensitive search for OData.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>enableCaseInsensitiveSearch</code></returns>
				public extern virtual bool getEnableCaseInsensitiveSearch();

				/// <summary>
				/// Sets a new value for property {@link #getEnableCaseInsensitiveSearch enableCaseInsensitiveSearch}.
				/// 
				/// If set to <code>true</code>, enables case-insensitive search for OData.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bEnableCaseInsensitiveSearch">New value for property <code>enableCaseInsensitiveSearch</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FacetFilterList setEnableCaseInsensitiveSearch(bool bEnableCaseInsensitiveSearch);

				#endregion

				#region Methods for Property allCount

				/// <summary>
				/// Gets current value of property {@link #getAllCount allCount}.
				/// 
				/// Determines the number of objects that match this item in the target data set when all filter items are selected.
				/// </summary>
				/// <returns>Value of property <code>allCount</code></returns>
				public extern virtual int getAllCount();

				/// <summary>
				/// Sets a new value for property {@link #getAllCount allCount}.
				/// 
				/// Determines the number of objects that match this item in the target data set when all filter items are selected.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="iAllCount">New value for property <code>allCount</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FacetFilterList setAllCount(int iAllCount);

				#endregion

				#region Methods for Property sequence

				/// <summary>
				/// Gets current value of property {@link #getSequence sequence}.
				/// 
				/// Sequence that determines the order in which FacetFilterList is shown on the FacetFilter. Lists are rendered by ascending order of sequence.
				/// 
				/// Default value is <code>-1</code>.
				/// </summary>
				/// <returns>Value of property <code>sequence</code></returns>
				public extern virtual int getSequence();

				/// <summary>
				/// Sets a new value for property {@link #getSequence sequence}.
				/// 
				/// Sequence that determines the order in which FacetFilterList is shown on the FacetFilter. Lists are rendered by ascending order of sequence.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>-1</code>.
				/// </summary>
				/// <param name="iSequence">New value for property <code>sequence</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FacetFilterList setSequence(int iSequence);

				#endregion

				#region Methods for Property key

				/// <summary>
				/// Gets current value of property {@link #getKey key}.
				/// 
				/// Unique identifier for this filter list.
				/// </summary>
				/// <returns>Value of property <code>key</code></returns>
				public extern virtual string getKey();

				/// <summary>
				/// Sets a new value for property {@link #getKey key}.
				/// 
				/// Unique identifier for this filter list.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sKey">New value for property <code>key</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FacetFilterList setKey(string sKey);

				#endregion

				#region Methods for Property showRemoveFacetIcon

				/// <summary>
				/// Gets current value of property {@link #getShowRemoveFacetIcon showRemoveFacetIcon}.
				/// 
				/// Specifies whether remove icon for facet is visible or hidden.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>showRemoveFacetIcon</code></returns>
				public extern virtual bool getShowRemoveFacetIcon();

				/// <summary>
				/// Sets a new value for property {@link #getShowRemoveFacetIcon showRemoveFacetIcon}.
				/// 
				/// Specifies whether remove icon for facet is visible or hidden.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bShowRemoveFacetIcon">New value for property <code>showRemoveFacetIcon</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FacetFilterList setShowRemoveFacetIcon(bool bShowRemoveFacetIcon);

				#endregion

				#region Methods for Property retainListSequence

				/// <summary>
				/// Gets current value of property {@link #getRetainListSequence retainListSequence}.
				/// 
				/// Retains the list sequence if it is inactive and made active again.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>retainListSequence</code></returns>
				public extern virtual bool getRetainListSequence();

				/// <summary>
				/// Sets a new value for property {@link #getRetainListSequence retainListSequence}.
				/// 
				/// Retains the list sequence if it is inactive and made active again.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bRetainListSequence">New value for property <code>retainListSequence</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FacetFilterList setRetainListSequence(bool bRetainListSequence);

				#endregion

				#region Methods for Property dataType

				/// <summary>
				/// Gets current value of property {@link #getDataType dataType}.
				/// 
				/// FacetFilterList data type. Only String data type will provide search function.
				/// 
				/// Default value is <code>String</code>.
				/// </summary>
				/// <returns>Value of property <code>dataType</code></returns>
				public extern virtual sap.m.FacetFilterListDataType getDataType();

				/// <summary>
				/// Sets a new value for property {@link #getDataType dataType}.
				/// 
				/// FacetFilterList data type. Only String data type will provide search function.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>String</code>.
				/// </summary>
				/// <param name="sDataType">New value for property <code>dataType</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FacetFilterList setDataType(sap.m.FacetFilterListDataType sDataType);

				#endregion

				#region Methods for Event listOpen

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:listOpen listOpen} event of this <code>sap.m.FacetFilterList</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.FacetFilterList</code> itself.
				/// 
				/// Fired before the filter list is opened.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.FacetFilterList</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FacetFilterList attachListOpen(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:listOpen listOpen} event of this <code>sap.m.FacetFilterList</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.FacetFilterList</code> itself.
				/// 
				/// Fired before the filter list is opened.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FacetFilterList attachListOpen(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:listOpen listOpen} event of this <code>sap.m.FacetFilterList</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.FacetFilterList</code> itself.
				/// 
				/// Fired before the filter list is opened.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FacetFilterList attachListOpen(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:listOpen listOpen} event of this <code>sap.m.FacetFilterList</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.FacetFilterList</code> itself.
				/// 
				/// Fired before the filter list is opened.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.FacetFilterList</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FacetFilterList attachListOpen(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:listOpen listOpen} event of this <code>sap.m.FacetFilterList</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FacetFilterList detachListOpen(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:listOpen listOpen} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FacetFilterList fireListOpen(object mParameters);

				/// <summary>
				/// Fires event {@link #event:listOpen listOpen} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FacetFilterList fireListOpen();

				#endregion

				#region Methods for Event listClose

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:listClose listClose} event of this <code>sap.m.FacetFilterList</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.FacetFilterList</code> itself.
				/// 
				/// Triggered after the list of items is closed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.FacetFilterList</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FacetFilterList attachListClose(object oData, sap.m.FacetFilterList.ListCloseDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:listClose listClose} event of this <code>sap.m.FacetFilterList</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.FacetFilterList</code> itself.
				/// 
				/// Triggered after the list of items is closed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FacetFilterList attachListClose(object oData, sap.m.FacetFilterList.ListCloseDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:listClose listClose} event of this <code>sap.m.FacetFilterList</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.FacetFilterList</code> itself.
				/// 
				/// Triggered after the list of items is closed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FacetFilterList attachListClose(sap.m.FacetFilterList.ListCloseDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:listClose listClose} event of this <code>sap.m.FacetFilterList</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.FacetFilterList</code> itself.
				/// 
				/// Triggered after the list of items is closed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.FacetFilterList</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FacetFilterList attachListClose(sap.m.FacetFilterList.ListCloseDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:listClose listClose} event of this <code>sap.m.FacetFilterList</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FacetFilterList detachListClose(sap.m.FacetFilterList.ListCloseDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:listClose listClose} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FacetFilterList fireListClose(sap.m.FacetFilterList.ListCloseInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:listClose listClose} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FacetFilterList fireListClose();

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.FacetFilterList with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.List.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.FacetFilterList with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.List.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.FacetFilterList with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.List.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.FacetFilterList.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				/// <summary>
				/// Returns the keys of the selected elements as an associative array. An empty object is returned if no items are selected.
				/// </summary>
				/// <returns>Object with the selected keys</returns>
				public extern virtual object getSelectedKeys();

				/// <summary>
				/// Removes the specified key from the selected keys cache and deselects the item.
				/// </summary>
				/// <param name="sKey">The key of the selected item to be removed from the cache. If <code>null</code> then the text parameter will be used as the key.</param>
				/// <param name="sText">The text of the selected item to be removed from the cache. If the key parameter is <code>null</code> then text will be used as the key.</param>
				public extern virtual void removeSelectedKey(string sKey, string sText);

				/// <summary>
				/// Removes all selected keys from the selected keys cache and deselects all items.
				/// </summary>
				public extern virtual void removeSelectedKeys();

				/// <summary>
				/// Overrides to allow only MultiSelect and SingleSelectMaster list modes. If an invalid mode is given then the mode will not be changed.
				/// </summary>
				/// <param name="mode">The list mode</param>
				/// <returns><code>this</code> to allow method chaining</returns>
				public extern virtual sap.m.FacetFilterList setMode(sap.m.ListMode mode);

				/// <summary>
				/// Used to pre-select FacetFilterItems, such as when restoring FacetFilterList selections from a variant. Keys are cached separately from the actual FacetFilterItems so that they remain even when the physical items are removed by filtering or sorting. If aKeys is <code>undefined</code>, <code>null</code>, or {} (empty object) then all keys are deleted. After this method completes, only those items with matching keys will be selected. All other items in the list will be deselected.
				/// </summary>
				/// <param name="oKeys">Associative array indicating which FacetFilterItems should be selected in the list. Each property must be set to the value of a FacetFilterItem.key property. Each property value should be set to the FacetFilterItem.text property value. The text value is used to display the FacetFilterItem text when the FacetFilterList button or FacetFilter summary bar is displayed. If no property value is set then the property key is used for the text.</param>
				public extern virtual void setSelectedKeys(object oKeys);

				#endregion

				#endregion

			}
		}
	}
}
