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
				/// Attribute browse area used within the Exact pattern. The main benefit of this control is the high flexibility when large data amounts shall be displayed in the form of structured data sets with a high or low interdependency level. From lists - which can be nested according to the defined attributes - the user can choose entries and thereby trigger the display of further information, depending on the chosen entry/entries (multiple selection supported).
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.ux3.ExactBrowser")]
				[Obsolete("Deprecated since 1.38.")]
				public partial class ExactBrowser : sap.ui.core.Control
				{
					#region Settings

					/// <summary>
					/// Settings class to create the object
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class Settings : sap.ui.core.Control.Settings
					{
						/// <summary>
						/// Title text in the list area of the Exact Browser. The title is not shown when the property showTopList is set to false.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> title;

						/// <summary>
						/// Title text in the header of the Exact Browser.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> headerTitle;

						/// <summary>
						/// The order how the sublists of the top level list should be displayed.
						/// </summary>
						public Union<sap.ui.ux3.ExactOrder, string, sap.ui.@base.ManagedObject.BindPropertyInfo> topListOrder;

						/// <summary>
						/// Enables the close icons of the displayed lists.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> enableListClose;

						/// <summary>
						/// The height of the list area in px.
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> listHeight;

						/// <summary>
						/// Whether the header area of the ExactBrowser should be shown.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showHeader;

						/// <summary>
						/// Whether the top list of the ExactBrowser should be shown. When the property is set to false the application must ensure to select top level attributes appropriately.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showTopList;

						/// <summary>
						/// Whether the reset functionality should be available in the header area.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> enableReset;

						/// <summary>
						/// Whether the save button should be available in the header area.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> enableSave;

						/// <summary>
						/// Specifies the width of the top list in pixels. The value must be between 70 and 500.
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> topListWidth;

						/// <summary>
						/// The attributes which shall be available.
						/// </summary>
						public Union<sap.ui.ux3.ExactAttribute[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> attributes;

						/// <summary>
						/// Menu with options. The menu can not used when the property showTopList is set to false.
						/// </summary>
						public Union<sap.ui.commons.Menu, string, sap.ui.@base.ManagedObject.BindAggregationInfo> optionsMenu;

						/// <summary>
						/// The successor control of the Exact Browser. The id of this control is used in the ARIA description of the control.
						/// </summary>
						public Union<sap.ui.core.Control, sap.ui.core.ID, string, sap.ui.@base.ManagedObject.BindPropertyInfo> followUpControl;

						/// <summary>
						/// Event is fired when an attribute is selected or unselected.
						/// </summary>
						public sap.ui.ux3.ExactBrowser.AttributeSelectedDelegate attributeSelected;

						/// <summary>
						/// Event is fired when an attribute is selected or unselected.
						/// </summary>
						public sap.ui.@base.EventDelegate save;

					}

					#endregion

					#region Typed Parameters

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class AttributeSelectedInfo
					{
						/// <summary>
						/// The attribute which was selected or unselected recently
						/// </summary>
						public sap.ui.ux3.ExactAttribute attribute;

						/// <summary>
						/// Array of all selected ExactAttributes
						/// </summary>
						public object allAttributes;

					}

					#endregion

					#region Delegates

					public delegate void AttributeSelectedDelegate(sap.ui.@base.Event<sap.ui.ux3.ExactBrowser.AttributeSelectedInfo> oEvent, object oData);

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new ExactBrowser.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern ExactBrowser(string sId, sap.ui.ux3.ExactBrowser.Settings mSettings);

					/// <summary>
					/// Constructor for a new ExactBrowser.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern ExactBrowser(string sId);

					/// <summary>
					/// Constructor for a new ExactBrowser.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern ExactBrowser();

					/// <summary>
					/// Constructor for a new ExactBrowser.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern ExactBrowser(sap.ui.ux3.ExactBrowser.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property title

					/// <summary>
					/// Gets current value of property {@link #getTitle title}.
					/// 
					/// Title text in the list area of the Exact Browser. The title is not shown when the property showTopList is set to false.
					/// </summary>
					/// <returns>Value of property <code>title</code></returns>
					public extern virtual string getTitle();

					/// <summary>
					/// Sets a new value for property {@link #getTitle title}.
					/// 
					/// Title text in the list area of the Exact Browser. The title is not shown when the property showTopList is set to false.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sTitle">New value for property <code>title</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ExactBrowser setTitle(string sTitle);

					#endregion

					#region Methods for Property headerTitle

					/// <summary>
					/// Gets current value of property {@link #getHeaderTitle headerTitle}.
					/// 
					/// Title text in the header of the Exact Browser.
					/// </summary>
					/// <returns>Value of property <code>headerTitle</code></returns>
					public extern virtual string getHeaderTitle();

					/// <summary>
					/// Sets a new value for property {@link #getHeaderTitle headerTitle}.
					/// 
					/// Title text in the header of the Exact Browser.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sHeaderTitle">New value for property <code>headerTitle</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ExactBrowser setHeaderTitle(string sHeaderTitle);

					#endregion

					#region Methods for Property topListOrder

					/// <summary>
					/// Gets current value of property {@link #getTopListOrder topListOrder}.
					/// 
					/// The order how the sublists of the top level list should be displayed.
					/// 
					/// Default value is <code>Select</code>.
					/// </summary>
					/// <returns>Value of property <code>topListOrder</code></returns>
					public extern virtual sap.ui.ux3.ExactOrder getTopListOrder();

					/// <summary>
					/// Sets a new value for property {@link #getTopListOrder topListOrder}.
					/// 
					/// The order how the sublists of the top level list should be displayed.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>Select</code>.
					/// </summary>
					/// <param name="sTopListOrder">New value for property <code>topListOrder</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ExactBrowser setTopListOrder(sap.ui.ux3.ExactOrder sTopListOrder);

					#endregion

					#region Methods for Property enableListClose

					/// <summary>
					/// Gets current value of property {@link #getEnableListClose enableListClose}.
					/// 
					/// Enables the close icons of the displayed lists.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>enableListClose</code></returns>
					public extern virtual bool getEnableListClose();

					/// <summary>
					/// Sets a new value for property {@link #getEnableListClose enableListClose}.
					/// 
					/// Enables the close icons of the displayed lists.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bEnableListClose">New value for property <code>enableListClose</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ExactBrowser setEnableListClose(bool bEnableListClose);

					#endregion

					#region Methods for Property listHeight

					/// <summary>
					/// Gets current value of property {@link #getListHeight listHeight}.
					/// 
					/// The height of the list area in px.
					/// 
					/// Default value is <code>290</code>.
					/// </summary>
					/// <returns>Value of property <code>listHeight</code></returns>
					public extern virtual int getListHeight();

					/// <summary>
					/// Sets a new value for property {@link #getListHeight listHeight}.
					/// 
					/// The height of the list area in px.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>290</code>.
					/// </summary>
					/// <param name="iListHeight">New value for property <code>listHeight</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ExactBrowser setListHeight(int iListHeight);

					#endregion

					#region Methods for Property showHeader

					/// <summary>
					/// Gets current value of property {@link #getShowHeader showHeader}.
					/// 
					/// Whether the header area of the ExactBrowser should be shown.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>showHeader</code></returns>
					public extern virtual bool getShowHeader();

					/// <summary>
					/// Sets a new value for property {@link #getShowHeader showHeader}.
					/// 
					/// Whether the header area of the ExactBrowser should be shown.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bShowHeader">New value for property <code>showHeader</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ExactBrowser setShowHeader(bool bShowHeader);

					#endregion

					#region Methods for Property showTopList

					/// <summary>
					/// Gets current value of property {@link #getShowTopList showTopList}.
					/// 
					/// Whether the top list of the ExactBrowser should be shown. When the property is set to false the application must ensure to select top level attributes appropriately.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>showTopList</code></returns>
					public extern virtual bool getShowTopList();

					/// <summary>
					/// Sets a new value for property {@link #getShowTopList showTopList}.
					/// 
					/// Whether the top list of the ExactBrowser should be shown. When the property is set to false the application must ensure to select top level attributes appropriately.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bShowTopList">New value for property <code>showTopList</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ExactBrowser setShowTopList(bool bShowTopList);

					#endregion

					#region Methods for Property enableReset

					/// <summary>
					/// Gets current value of property {@link #getEnableReset enableReset}.
					/// 
					/// Whether the reset functionality should be available in the header area.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>enableReset</code></returns>
					public extern virtual bool getEnableReset();

					/// <summary>
					/// Sets a new value for property {@link #getEnableReset enableReset}.
					/// 
					/// Whether the reset functionality should be available in the header area.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bEnableReset">New value for property <code>enableReset</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ExactBrowser setEnableReset(bool bEnableReset);

					#endregion

					#region Methods for Property enableSave

					/// <summary>
					/// Gets current value of property {@link #getEnableSave enableSave}.
					/// 
					/// Whether the save button should be available in the header area.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>enableSave</code></returns>
					public extern virtual bool getEnableSave();

					/// <summary>
					/// Sets a new value for property {@link #getEnableSave enableSave}.
					/// 
					/// Whether the save button should be available in the header area.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bEnableSave">New value for property <code>enableSave</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ExactBrowser setEnableSave(bool bEnableSave);

					#endregion

					#region Methods for Property topListWidth

					/// <summary>
					/// Gets current value of property {@link #getTopListWidth topListWidth}.
					/// 
					/// Specifies the width of the top list in pixels. The value must be between 70 and 500.
					/// 
					/// Default value is <code>168</code>.
					/// </summary>
					/// <returns>Value of property <code>topListWidth</code></returns>
					public extern virtual int getTopListWidth();

					/// <summary>
					/// Sets a new value for property {@link #getTopListWidth topListWidth}.
					/// 
					/// Specifies the width of the top list in pixels. The value must be between 70 and 500.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>168</code>.
					/// </summary>
					/// <param name="iTopListWidth">New value for property <code>topListWidth</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ExactBrowser setTopListWidth(int iTopListWidth);

					#endregion

					#region Methods for Aggregation attributes

					/// <summary>
					/// Gets content of aggregation {@link #getAttributes attributes}.
					/// 
					/// The attributes which shall be available.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.ux3.ExactAttribute[] getAttributes();

					/// <summary>
					/// Destroys all the attributes in the aggregation {@link #getAttributes attributes}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ExactBrowser destroyAttributes();

					/// <summary>
					/// Inserts a attribute into the aggregation {@link #getAttributes attributes}.
					/// </summary>
					/// <param name="oAttribute">The attribute to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the attribute should be inserted at; for a negative value of <code>iIndex</code>, the attribute is inserted at position 0; for a value greater than the current size of the aggregation, the attribute is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ExactBrowser insertAttribute(sap.ui.ux3.ExactAttribute oAttribute, int iIndex);

					/// <summary>
					/// Adds some attribute to the aggregation {@link #getAttributes attributes}.
					/// </summary>
					/// <param name="oAttribute">The attribute to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ExactBrowser addAttribute(sap.ui.ux3.ExactAttribute oAttribute);

					/// <summary>
					/// Removes a attribute from the aggregation {@link #getAttributes attributes}.
					/// </summary>
					/// <param name="vAttribute">The attribute to remove or its index or id</param>
					/// <returns>The removed attribute or <code>null</code></returns>
					public extern virtual sap.ui.ux3.ExactAttribute removeAttribute(Union<int, string, sap.ui.ux3.ExactAttribute> vAttribute);

					/// <summary>
					/// Checks for the provided <code>sap.ui.ux3.ExactAttribute</code> in the aggregation {@link #getAttributes attributes}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oAttribute">The attribute whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfAttribute(sap.ui.ux3.ExactAttribute oAttribute);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getAttributes attributes}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.ux3.ExactAttribute[] removeAllAttributes();

					#endregion

					#region Methods for Aggregation optionsMenu

					/// <summary>
					/// Gets content of aggregation {@link #getOptionsMenu optionsMenu}.
					/// 
					/// Menu with options. The menu can not used when the property showTopList is set to false.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.commons.Menu getOptionsMenu();

					/// <summary>
					/// Destroys the optionsMenu in the aggregation {@link #getOptionsMenu optionsMenu}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ExactBrowser destroyOptionsMenu();

					/// <summary>
					/// Sets the aggregated {@link #getOptionsMenu optionsMenu}.
					/// </summary>
					/// <param name="oOptionsMenu">The optionsMenu to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ExactBrowser setOptionsMenu(sap.ui.commons.Menu oOptionsMenu);

					#endregion

					#region Methods for Aggregation controls

					#endregion

					#region Methods for Aggregation rootAttribute

					#endregion

					#region Methods for Association followUpControl

					/// <summary>
					/// ID of the element which is the current target of the association {@link #getFollowUpControl followUpControl}, or <code>null</code>.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.ID getFollowUpControl();

					/// <summary>
					/// Sets the associated {@link #getFollowUpControl followUpControl}.
					/// </summary>
					/// <param name="oFollowUpControl">ID of an element which becomes the new target of this followUpControl association; alternatively, an element instance may be given</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ExactBrowser setFollowUpControl(Union<sap.ui.core.ID, sap.ui.core.Control> oFollowUpControl);

					#endregion

					#region Methods for Event attributeSelected

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:attributeSelected attributeSelected} event of this <code>sap.ui.ux3.ExactBrowser</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.ExactBrowser</code> itself.
					/// 
					/// Event is fired when an attribute is selected or unselected.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.ExactBrowser</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ExactBrowser attachAttributeSelected(object oData, sap.ui.ux3.ExactBrowser.AttributeSelectedDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:attributeSelected attributeSelected} event of this <code>sap.ui.ux3.ExactBrowser</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.ExactBrowser</code> itself.
					/// 
					/// Event is fired when an attribute is selected or unselected.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ExactBrowser attachAttributeSelected(object oData, sap.ui.ux3.ExactBrowser.AttributeSelectedDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:attributeSelected attributeSelected} event of this <code>sap.ui.ux3.ExactBrowser</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.ExactBrowser</code> itself.
					/// 
					/// Event is fired when an attribute is selected or unselected.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ExactBrowser attachAttributeSelected(sap.ui.ux3.ExactBrowser.AttributeSelectedDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:attributeSelected attributeSelected} event of this <code>sap.ui.ux3.ExactBrowser</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.ExactBrowser</code> itself.
					/// 
					/// Event is fired when an attribute is selected or unselected.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.ExactBrowser</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ExactBrowser attachAttributeSelected(sap.ui.ux3.ExactBrowser.AttributeSelectedDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:attributeSelected attributeSelected} event of this <code>sap.ui.ux3.ExactBrowser</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ExactBrowser detachAttributeSelected(sap.ui.ux3.ExactBrowser.AttributeSelectedDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:attributeSelected attributeSelected} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ExactBrowser fireAttributeSelected(sap.ui.ux3.ExactBrowser.AttributeSelectedInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:attributeSelected attributeSelected} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ExactBrowser fireAttributeSelected();

					#endregion

					#region Methods for Event save

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:save save} event of this <code>sap.ui.ux3.ExactBrowser</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.ExactBrowser</code> itself.
					/// 
					/// Event is fired when an attribute is selected or unselected.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.ExactBrowser</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ExactBrowser attachSave(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:save save} event of this <code>sap.ui.ux3.ExactBrowser</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.ExactBrowser</code> itself.
					/// 
					/// Event is fired when an attribute is selected or unselected.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ExactBrowser attachSave(object oData, sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:save save} event of this <code>sap.ui.ux3.ExactBrowser</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.ExactBrowser</code> itself.
					/// 
					/// Event is fired when an attribute is selected or unselected.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ExactBrowser attachSave(sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:save save} event of this <code>sap.ui.ux3.ExactBrowser</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.ExactBrowser</code> itself.
					/// 
					/// Event is fired when an attribute is selected or unselected.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.ExactBrowser</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ExactBrowser attachSave(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:save save} event of this <code>sap.ui.ux3.ExactBrowser</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ExactBrowser detachSave(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:save save} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ExactBrowser fireSave(object mParameters);

					/// <summary>
					/// Fires event {@link #event:save save} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.ExactBrowser fireSave();

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.ux3.ExactBrowser with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.ux3.ExactBrowser with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.ux3.ExactBrowser with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.ux3.ExactBrowser.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					/// <summary>
					/// Deselects all currently selected attributes and closes all attribute lists.
					/// </summary>
					public extern virtual void reset();

					#endregion

					#endregion

				}
			}
		}
	}
}
