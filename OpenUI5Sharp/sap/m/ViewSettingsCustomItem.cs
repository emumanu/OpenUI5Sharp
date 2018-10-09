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
			/// The ViewSettingsCustomItem control is used for modelling custom filters in the ViewSettingsDialog.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.ViewSettingsCustomItem")]
			public partial class ViewSettingsCustomItem : sap.m.ViewSettingsItem
			{
				#region Settings

				/// <summary>
				/// Settings class to create the object
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class Settings : sap.m.ViewSettingsItem.Settings
				{
					/// <summary>
					/// The number of currently active filters for this custom filter item. It will be displayed in the filter list of the ViewSettingsDialog to represent the filter state of the custom control.
					/// </summary>
					public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> filterCount;

					/// <summary>
					/// A custom control for the filter field. It can be used for complex filtering mechanisms.
					/// </summary>
					public Union<sap.ui.core.Control, string, sap.ui.@base.ManagedObject.BindAggregationInfo> customControl;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new ViewSettingsCustomItem.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern ViewSettingsCustomItem(string sId, sap.m.ViewSettingsCustomItem.Settings mSettings);

				/// <summary>
				/// Constructor for a new ViewSettingsCustomItem.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern ViewSettingsCustomItem(string sId);

				/// <summary>
				/// Constructor for a new ViewSettingsCustomItem.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern ViewSettingsCustomItem();

				/// <summary>
				/// Constructor for a new ViewSettingsCustomItem.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern ViewSettingsCustomItem(sap.m.ViewSettingsCustomItem.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property filterCount

				/// <summary>
				/// Gets current value of property {@link #getFilterCount filterCount}.
				/// 
				/// The number of currently active filters for this custom filter item. It will be displayed in the filter list of the ViewSettingsDialog to represent the filter state of the custom control.
				/// 
				/// Default value is <code>0</code>.
				/// </summary>
				/// <returns>Value of property <code>filterCount</code></returns>
				public extern virtual int getFilterCount();

				/// <summary>
				/// Sets the filterCount without invalidating the control as it is never rendered directly.
				/// </summary>
				/// <param name="iValue">The new value for property filterCount</param>
				/// <returns>this pointer for chaining</returns>
				public extern virtual sap.m.ViewSettingsItem setFilterCount(int iValue);

				#endregion

				#region Methods for Aggregation customControl

				/// <summary>
				/// Internally the control is handled as a managed object instead of an aggregation because this control is sometimes aggregated in other controls like a popover or a dialog.
				/// </summary>
				/// <returns>oControl a control used for filtering purposes</returns>
				public extern virtual sap.ui.core.Control getCustomControl();

				/// <summary>
				/// Destroys the customControl in the aggregation {@link #getCustomControl customControl}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ViewSettingsCustomItem destroyCustomControl();

				/// <summary>
				/// Internally the control is handled as a managed object instead of an aggregation as this control is sometimes aggregated in other controls like a popover or a dialog.
				/// </summary>
				/// <param name="oControl">A control used for filtering purposes</param>
				/// <returns>this pointer for chaining</returns>
				public extern virtual sap.m.ViewSettingsCustomItem setCustomControl(sap.ui.core.Control oControl);

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a clone of the ViewSettingsCustomItem instance.
				/// </summary>
				/// <param name="sIdSuffix">a suffix to be appended to the cloned object id</param>
				/// <param name="aLocalIds">an array of local IDs within the cloned hierarchy (internally used)</param>
				/// <param name="oOptions">configuration object</param>
				/// <returns>reference to the newly created clone</returns>
				public extern virtual sap.ui.@base.ManagedObject clone(string sIdSuffix, string[] aLocalIds, object oOptions);

				/// <summary>
				/// Creates a clone of the ViewSettingsCustomItem instance.
				/// </summary>
				/// <param name="sIdSuffix">a suffix to be appended to the cloned object id</param>
				/// <param name="aLocalIds">an array of local IDs within the cloned hierarchy (internally used)</param>
				/// <param name="oOptions">configuration object</param>
				/// <returns>reference to the newly created clone</returns>
				public extern virtual sap.ui.@base.ManagedObject clone(string sIdSuffix, object[] aLocalIds, object oOptions);

				/// <summary>
				/// Creates a clone of the ViewSettingsCustomItem instance.
				/// </summary>
				/// <param name="sIdSuffix">a suffix to be appended to the cloned object id</param>
				/// <param name="aLocalIds">an array of local IDs within the cloned hierarchy (internally used)</param>
				/// <returns>reference to the newly created clone</returns>
				public extern virtual sap.ui.@base.ManagedObject clone(string sIdSuffix, string[] aLocalIds);

				/// <summary>
				/// Creates a clone of the ViewSettingsCustomItem instance.
				/// </summary>
				/// <param name="sIdSuffix">a suffix to be appended to the cloned object id</param>
				/// <param name="aLocalIds">an array of local IDs within the cloned hierarchy (internally used)</param>
				/// <returns>reference to the newly created clone</returns>
				public extern virtual sap.ui.@base.ManagedObject clone(string sIdSuffix, object[] aLocalIds);

				/// <summary>
				/// Creates a clone of the ViewSettingsCustomItem instance.
				/// </summary>
				/// <param name="sIdSuffix">a suffix to be appended to the cloned object id</param>
				/// <returns>reference to the newly created clone</returns>
				public extern virtual sap.ui.@base.ManagedObject clone(string sIdSuffix);

				/// <summary>
				/// Creates a clone of the ViewSettingsCustomItem instance.
				/// </summary>
				/// <returns>reference to the newly created clone</returns>
				public extern virtual sap.ui.@base.ManagedObject clone();

				/// <summary>
				/// Creates a clone of the ViewSettingsCustomItem instance.
				/// </summary>
				/// <param name="aLocalIds">an array of local IDs within the cloned hierarchy (internally used)</param>
				/// <returns>reference to the newly created clone</returns>
				public extern virtual sap.ui.@base.ManagedObject clone(string[] aLocalIds);

				/// <summary>
				/// Creates a clone of the ViewSettingsCustomItem instance.
				/// </summary>
				/// <param name="aLocalIds">an array of local IDs within the cloned hierarchy (internally used)</param>
				/// <returns>reference to the newly created clone</returns>
				public extern virtual sap.ui.@base.ManagedObject clone(object[] aLocalIds);

				/// <summary>
				/// Creates a clone of the ViewSettingsCustomItem instance.
				/// </summary>
				/// <param name="aLocalIds">an array of local IDs within the cloned hierarchy (internally used)</param>
				/// <param name="oOptions">configuration object</param>
				/// <returns>reference to the newly created clone</returns>
				public extern virtual sap.ui.@base.ManagedObject clone(string[] aLocalIds, object oOptions);

				/// <summary>
				/// Creates a clone of the ViewSettingsCustomItem instance.
				/// </summary>
				/// <param name="aLocalIds">an array of local IDs within the cloned hierarchy (internally used)</param>
				/// <param name="oOptions">configuration object</param>
				/// <returns>reference to the newly created clone</returns>
				public extern virtual sap.ui.@base.ManagedObject clone(object[] aLocalIds, object oOptions);

				/// <summary>
				/// Creates a clone of the ViewSettingsCustomItem instance.
				/// </summary>
				/// <param name="oOptions">configuration object</param>
				/// <returns>reference to the newly created clone</returns>
				public extern virtual sap.ui.@base.ManagedObject clone(object oOptions);

				/// <summary>
				/// Creates a new subclass of class sap.m.ViewSettingsCustomItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.ViewSettingsItem.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.ViewSettingsCustomItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.ViewSettingsItem.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.ViewSettingsCustomItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.ViewSettingsItem.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.ViewSettingsCustomItem.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				#endregion

				#endregion

			}
		}
	}
}
