using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public static partial class sap
	{
		public static partial class tnt
		{
			/// <summary>
			/// The SideNavigation control is a container, which consists of flexible and fixed parts on top of each other. <h4>Responsive Behavior</h4> <ul> <li>The flexible part adapts its size to the fixed one.</li> <li>The flexible part has a scrollbar when the content is larger than the available space.</li> </ul> <b>Note:</b> In order for the SideNavigation to stretch properly, its parent layout control should only be the sap.tnt.ToolPage.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.tnt.SideNavigation")]
			public partial class SideNavigation : sap.ui.core.Control
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
					/// Specifies if the control is expanded.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> expanded;

					/// <summary>
					/// Defines the content inside the flexible part.
					/// </summary>
					public Union<sap.tnt.NavigationList, string, sap.ui.@base.ManagedObject.BindAggregationInfo> item;

					/// <summary>
					/// Defines the content inside the fixed part.
					/// </summary>
					public Union<sap.tnt.NavigationList, string, sap.ui.@base.ManagedObject.BindAggregationInfo> fixedItem;

					/// <summary>
					/// Defines the content inside the footer.
					/// </summary>
					public Union<sap.tnt.NavigationList, string, sap.ui.@base.ManagedObject.BindAggregationInfo> footer;

					/// <summary>
					/// The selected <code>NavigationListItem</code>.
					/// </summary>
					public Union<sap.tnt.NavigationListItem, sap.ui.core.ID, string, sap.ui.@base.ManagedObject.BindPropertyInfo> selectedItem;

					/// <summary>
					/// Fired when an item is selected.
					/// </summary>
					public sap.m.ItemSelectDelegate itemSelect;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new SideNavigation.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern SideNavigation(string sId, sap.tnt.SideNavigation.Settings mSettings);

				/// <summary>
				/// Constructor for a new SideNavigation.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern SideNavigation(string sId);

				/// <summary>
				/// Constructor for a new SideNavigation.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern SideNavigation();

				/// <summary>
				/// Constructor for a new SideNavigation.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern SideNavigation(sap.tnt.SideNavigation.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property expanded

				/// <summary>
				/// Gets current value of property {@link #getExpanded expanded}.
				/// 
				/// Specifies if the control is expanded.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>expanded</code></returns>
				public extern virtual bool getExpanded();

				/// <summary>
				/// Sets if the control is in expanded or collapsed mode.
				/// </summary>
				/// <param name="isExpanded">Indication if the SideNavigation is expanded.</param>
				/// <returns>this SideNavigation reference for chaining.</returns>
				public extern virtual sap.tnt.SideNavigation setExpanded(bool isExpanded);

				#endregion

				#region Methods for Aggregation item

				/// <summary>
				/// Gets content of aggregation {@link #getItem item}.
				/// 
				/// Defines the content inside the flexible part.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.tnt.NavigationList getItem();

				/// <summary>
				/// Destroys the item in the aggregation {@link #getItem item}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.tnt.SideNavigation destroyItem();

				/// <summary>
				/// Sets the aggregated {@link #getItem item}.
				/// </summary>
				/// <param name="oItem">The item to set</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.tnt.SideNavigation setItem(sap.tnt.NavigationList oItem);

				/// <summary>
				/// Binds aggregation {@link #getItem item} to model data.
				/// 
				/// See {@link sap.ui.base.ManagedObject#bindAggregation ManagedObject.bindAggregation} for a detailed description of the possible properties of <code>oBindingInfo</code>.
				/// </summary>
				/// <param name="oBindingInfo">The binding information</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.tnt.SideNavigation bindItem(sap.ui.@base.ManagedObject.BindAggregationInfo oBindingInfo);

				/// <summary>
				/// Unbinds aggregation {@link #getItem item} from model data.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.tnt.SideNavigation unbindItem();

				#endregion

				#region Methods for Aggregation fixedItem

				/// <summary>
				/// Gets content of aggregation {@link #getFixedItem fixedItem}.
				/// 
				/// Defines the content inside the fixed part.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.tnt.NavigationList getFixedItem();

				/// <summary>
				/// Destroys the fixedItem in the aggregation {@link #getFixedItem fixedItem}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.tnt.SideNavigation destroyFixedItem();

				/// <summary>
				/// Sets the aggregated {@link #getFixedItem fixedItem}.
				/// </summary>
				/// <param name="oFixedItem">The fixedItem to set</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.tnt.SideNavigation setFixedItem(sap.tnt.NavigationList oFixedItem);

				#endregion

				#region Methods for Aggregation footer

				/// <summary>
				/// Gets content of aggregation {@link #getFooter footer}.
				/// 
				/// Defines the content inside the footer.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.tnt.NavigationList getFooter();

				/// <summary>
				/// Destroys the footer in the aggregation {@link #getFooter footer}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.tnt.SideNavigation destroyFooter();

				/// <summary>
				/// Sets the aggregated {@link #getFooter footer}.
				/// </summary>
				/// <param name="oFooter">The footer to set</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.tnt.SideNavigation setFooter(sap.tnt.NavigationList oFooter);

				#endregion

				#region Methods for Aggregation _topArrowControl

				#endregion

				#region Methods for Aggregation _bottomArrowControl

				#endregion

				#region Methods for Association selectedItem

				/// <summary>
				/// ID of the element which is the current target of the association {@link #getSelectedItem selectedItem}, or <code>null</code>.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.ID getSelectedItem();

				/// <summary>
				/// Sets the association for selectedItem
				/// </summary>
				/// <param name="selectedItem">The control to be set as selected</param>
				/// <param name="suppressInvalidate">If true, the managed object's invalidate method is not called</param>
				/// <returns>The <code>selectedItem</code> association</returns>
				public extern virtual sap.tnt.SideNavigation setSelectedItem(Union<string, sap.tnt.NavigationListItem> selectedItem, bool suppressInvalidate);

				#endregion

				#region Methods for Event itemSelect

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:itemSelect itemSelect} event of this <code>sap.tnt.SideNavigation</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.tnt.SideNavigation</code> itself.
				/// 
				/// Fired when an item is selected.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.tnt.SideNavigation</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.tnt.SideNavigation attachItemSelect(object oData, sap.m.ItemSelectDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:itemSelect itemSelect} event of this <code>sap.tnt.SideNavigation</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.tnt.SideNavigation</code> itself.
				/// 
				/// Fired when an item is selected.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.tnt.SideNavigation attachItemSelect(object oData, sap.m.ItemSelectDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:itemSelect itemSelect} event of this <code>sap.tnt.SideNavigation</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.tnt.SideNavigation</code> itself.
				/// 
				/// Fired when an item is selected.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.tnt.SideNavigation attachItemSelect(sap.m.ItemSelectDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:itemSelect itemSelect} event of this <code>sap.tnt.SideNavigation</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.tnt.SideNavigation</code> itself.
				/// 
				/// Fired when an item is selected.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.tnt.SideNavigation</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.tnt.SideNavigation attachItemSelect(sap.m.ItemSelectDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:itemSelect itemSelect} event of this <code>sap.tnt.SideNavigation</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.tnt.SideNavigation detachItemSelect(sap.m.ItemSelectDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:itemSelect itemSelect} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.tnt.SideNavigation fireItemSelect(sap.m.ItemSelectInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:itemSelect itemSelect} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.tnt.SideNavigation fireItemSelect();

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.tnt.SideNavigation with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.tnt.SideNavigation with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.tnt.SideNavigation with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.tnt.SideNavigation.
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
