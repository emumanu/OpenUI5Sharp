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
				/// DataSetSimpleView provides a simple view example for DataSet usage.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.ux3.DataSetSimpleView")]
				[Obsolete("Deprecated since 1.38. Use a layout by choice from the {@link sap.m} library, instead.")]
				public partial class DataSetSimpleView : sap.ui.core.Control, sap.ui.ux3.DataSetView
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
						/// When true the DatSet items are floating containers. When set to false The Items are rendered in a 1 column Layout.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> floating;

						/// <summary>
						/// Name of the View
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> name;

						/// <summary>
						/// Icon source for this view
						/// </summary>
						public Union<sap.ui.core.URI, string, sap.ui.@base.ManagedObject.BindPropertyInfo> icon;

						/// <summary>
						/// icon: hovered state
						/// </summary>
						public Union<sap.ui.core.URI, string, sap.ui.@base.ManagedObject.BindPropertyInfo> iconHovered;

						/// <summary>
						/// icon: selected state
						/// </summary>
						public Union<sap.ui.core.URI, string, sap.ui.@base.ManagedObject.BindPropertyInfo> iconSelected;

						/// <summary>
						/// When true and the property floating is true the DatSet items are floating containers filling the whole space of a row.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> responsive;

						/// <summary>
						/// When itemMinWidth>0 and the property floating is true the given minimum width in pixels is set to DatSet items. A minimum width must be given when the property responsive is set.
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> itemMinWidth;

						/// <summary>
						/// If this value is greater zero only this amount of items is loaded in the first place. New items are loaded automatically when the user scrolls down. The number of items which are reloaded can be defined with the property "reloadItemCount"
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> initialItemCount;

						/// <summary>
						/// This number defines the item count which is reloaded on scroll if initialItemCount is enabled.
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> reloadItemCount;

						/// <summary>
						/// ID of the DOM Element or jQuery reference to the dom which holds the scrollbar for the dataset
						/// </summary>
						public Union<object, string, sap.ui.@base.ManagedObject.BindPropertyInfo> scrollArea;

						/// <summary>
						/// If the pagination feature is used without specifying a scroll area, a height for the dataset must be defined.
						/// </summary>
						public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> height;

						/// <summary>
						/// template
						/// </summary>
						public Union<sap.ui.core.Control, string, sap.ui.@base.ManagedObject.BindAggregationInfo> template;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new DataSetSimpleView.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern DataSetSimpleView(string sId, sap.ui.ux3.DataSetSimpleView.Settings mSettings);

					/// <summary>
					/// Constructor for a new DataSetSimpleView.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern DataSetSimpleView(string sId);

					/// <summary>
					/// Constructor for a new DataSetSimpleView.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern DataSetSimpleView();

					/// <summary>
					/// Constructor for a new DataSetSimpleView.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern DataSetSimpleView(sap.ui.ux3.DataSetSimpleView.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property floating

					/// <summary>
					/// Gets current value of property {@link #getFloating floating}.
					/// 
					/// When true the DatSet items are floating containers. When set to false The Items are rendered in a 1 column Layout.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>floating</code></returns>
					public extern virtual bool getFloating();

					/// <summary>
					/// Sets a new value for property {@link #getFloating floating}.
					/// 
					/// When true the DatSet items are floating containers. When set to false The Items are rendered in a 1 column Layout.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bFloating">New value for property <code>floating</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.DataSetSimpleView setFloating(bool bFloating);

					#endregion

					#region Methods for Property name

					/// <summary>
					/// Gets current value of property {@link #getName name}.
					/// 
					/// Name of the View
					/// 
					/// Default value is <code>Name of this View</code>.
					/// </summary>
					/// <returns>Value of property <code>name</code></returns>
					public extern virtual string getName();

					/// <summary>
					/// Sets a new value for property {@link #getName name}.
					/// 
					/// Name of the View
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>Name of this View</code>.
					/// </summary>
					/// <param name="sName">New value for property <code>name</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.DataSetSimpleView setName(string sName);

					#endregion

					#region Methods for Property icon

					/// <summary>
					/// Gets current value of property {@link #getIcon icon}.
					/// 
					/// Icon source for this view
					/// </summary>
					/// <returns>Value of property <code>icon</code></returns>
					public extern virtual sap.ui.core.URI getIcon();

					/// <summary>
					/// Sets a new value for property {@link #getIcon icon}.
					/// 
					/// Icon source for this view
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sIcon">New value for property <code>icon</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.DataSetSimpleView setIcon(sap.ui.core.URI sIcon);

					#endregion

					#region Methods for Property iconHovered

					/// <summary>
					/// Gets current value of property {@link #getIconHovered iconHovered}.
					/// 
					/// icon: hovered state
					/// </summary>
					/// <returns>Value of property <code>iconHovered</code></returns>
					public extern virtual sap.ui.core.URI getIconHovered();

					/// <summary>
					/// Sets a new value for property {@link #getIconHovered iconHovered}.
					/// 
					/// icon: hovered state
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sIconHovered">New value for property <code>iconHovered</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.DataSetSimpleView setIconHovered(sap.ui.core.URI sIconHovered);

					#endregion

					#region Methods for Property iconSelected

					/// <summary>
					/// Gets current value of property {@link #getIconSelected iconSelected}.
					/// 
					/// icon: selected state
					/// </summary>
					/// <returns>Value of property <code>iconSelected</code></returns>
					public extern virtual sap.ui.core.URI getIconSelected();

					/// <summary>
					/// Sets a new value for property {@link #getIconSelected iconSelected}.
					/// 
					/// icon: selected state
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sIconSelected">New value for property <code>iconSelected</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.DataSetSimpleView setIconSelected(sap.ui.core.URI sIconSelected);

					#endregion

					#region Methods for Property responsive

					/// <summary>
					/// Gets current value of property {@link #getResponsive responsive}.
					/// 
					/// When true and the property floating is true the DatSet items are floating containers filling the whole space of a row.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>responsive</code></returns>
					public extern virtual bool getResponsive();

					/// <summary>
					/// Sets a new value for property {@link #getResponsive responsive}.
					/// 
					/// When true and the property floating is true the DatSet items are floating containers filling the whole space of a row.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bResponsive">New value for property <code>responsive</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.DataSetSimpleView setResponsive(bool bResponsive);

					#endregion

					#region Methods for Property itemMinWidth

					/// <summary>
					/// Gets current value of property {@link #getItemMinWidth itemMinWidth}.
					/// 
					/// When itemMinWidth>0 and the property floating is true the given minimum width in pixels is set to DatSet items. A minimum width must be given when the property responsive is set.
					/// 
					/// Default value is <code>0</code>.
					/// </summary>
					/// <returns>Value of property <code>itemMinWidth</code></returns>
					public extern virtual int getItemMinWidth();

					/// <summary>
					/// Sets a new value for property {@link #getItemMinWidth itemMinWidth}.
					/// 
					/// When itemMinWidth>0 and the property floating is true the given minimum width in pixels is set to DatSet items. A minimum width must be given when the property responsive is set.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>0</code>.
					/// </summary>
					/// <param name="iItemMinWidth">New value for property <code>itemMinWidth</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.DataSetSimpleView setItemMinWidth(int iItemMinWidth);

					#endregion

					#region Methods for Property initialItemCount

					/// <summary>
					/// Gets current value of property {@link #getInitialItemCount initialItemCount}.
					/// 
					/// If this value is greater zero only this amount of items is loaded in the first place. New items are loaded automatically when the user scrolls down. The number of items which are reloaded can be defined with the property "reloadItemCount"
					/// 
					/// Default value is <code>0</code>.
					/// </summary>
					/// <returns>Value of property <code>initialItemCount</code></returns>
					public extern virtual int getInitialItemCount();

					/// <summary>
					/// Sets a new value for property {@link #getInitialItemCount initialItemCount}.
					/// 
					/// If this value is greater zero only this amount of items is loaded in the first place. New items are loaded automatically when the user scrolls down. The number of items which are reloaded can be defined with the property "reloadItemCount"
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>0</code>.
					/// </summary>
					/// <param name="iInitialItemCount">New value for property <code>initialItemCount</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.DataSetSimpleView setInitialItemCount(int iInitialItemCount);

					#endregion

					#region Methods for Property reloadItemCount

					/// <summary>
					/// Gets current value of property {@link #getReloadItemCount reloadItemCount}.
					/// 
					/// This number defines the item count which is reloaded on scroll if initialItemCount is enabled.
					/// 
					/// Default value is <code>0</code>.
					/// </summary>
					/// <returns>Value of property <code>reloadItemCount</code></returns>
					public extern virtual int getReloadItemCount();

					/// <summary>
					/// Sets a new value for property {@link #getReloadItemCount reloadItemCount}.
					/// 
					/// This number defines the item count which is reloaded on scroll if initialItemCount is enabled.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>0</code>.
					/// </summary>
					/// <param name="iReloadItemCount">New value for property <code>reloadItemCount</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.DataSetSimpleView setReloadItemCount(int iReloadItemCount);

					#endregion

					#region Methods for Property scrollArea

					/// <summary>
					/// Gets current value of property {@link #getScrollArea scrollArea}.
					/// 
					/// ID of the DOM Element or jQuery reference to the dom which holds the scrollbar for the dataset
					/// </summary>
					/// <returns>Value of property <code>scrollArea</code></returns>
					public extern virtual object getScrollArea();

					/// <param name="aScrollArea"></param>
					/// <param name="bSupress"></param>
					public extern virtual void setScrollArea(object[] aScrollArea, bool bSupress);

					#endregion

					#region Methods for Property height

					/// <summary>
					/// Gets current value of property {@link #getHeight height}.
					/// 
					/// If the pagination feature is used without specifying a scroll area, a height for the dataset must be defined.
					/// </summary>
					/// <returns>Value of property <code>height</code></returns>
					public extern virtual sap.ui.core.CSSSize getHeight();

					/// <summary>
					/// Sets a new value for property {@link #getHeight height}.
					/// 
					/// If the pagination feature is used without specifying a scroll area, a height for the dataset must be defined.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sHeight">New value for property <code>height</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.DataSetSimpleView setHeight(sap.ui.core.CSSSize sHeight);

					#endregion

					#region Methods for Aggregation template

					/// <summary>
					/// Gets content of aggregation {@link #getTemplate template}.
					/// 
					/// template
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.Control getTemplate();

					/// <summary>
					/// Destroys the template in the aggregation {@link #getTemplate template}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.DataSetSimpleView destroyTemplate();

					/// <summary>
					/// Sets the aggregated {@link #getTemplate template}.
					/// </summary>
					/// <param name="oTemplate">The template to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.DataSetSimpleView setTemplate(sap.ui.core.Control oTemplate);

					#endregion

					#region Other methods

					/// <summary>
					/// View finalization: Called when leaving the view
					/// </summary>
					/// <param name="aItems"></param>
					public extern virtual void exitView(sap.ui.ux3.DataSetItem[] aItems);

					/// <summary>
					/// Creates a new subclass of class sap.ui.ux3.DataSetSimpleView with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.ux3.DataSetSimpleView with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.ux3.DataSetSimpleView with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.ux3.DataSetSimpleView.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					/// <summary>
					/// Eventhandler for the selection of an Item
					/// </summary>
					/// <param name="oEvent">SelectionChanged event</param>
					public extern virtual void handleSelection(sap.ui.@base.Event oEvent);

					/// <summary>
					/// View Initialization: Called when selecting the view
					/// </summary>
					/// <param name="aItems">Array of DataSetItems added to the parent DataSet</param>
					public extern virtual void initView(object[] aItems);

					/// <summary>
					/// Check if Item <code>oItem</code> is selected
					/// </summary>
					/// <param name="oItem">DataSetItem instance</param>
					public extern virtual void isItemSelected(sap.ui.ux3.DataSetItem oItem);

					/// <summary>
					/// View update: Called when pagination adds items
					/// </summary>
					/// <param name="aDiff">Array of DataSetItems added to the parent DataSet</param>
					public extern virtual void updateView(sap.ui.ux3.DataSetItem[] aDiff);

					#endregion

					#endregion

				}
			}
		}
	}
}
