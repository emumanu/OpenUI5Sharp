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
			/// Represents a value for the {@link sap.m.FacetFilterList} control.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.FacetFilterItem")]
			public partial class FacetFilterItem : sap.m.ListItemBase
			{
				#region Settings

				/// <summary>
				/// Settings class to create the object
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class Settings : sap.m.ListItemBase.Settings
				{
					/// <summary>
					/// Can be used as input for subsequent actions.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> key;

					/// <summary>
					/// Determines the text to be displayed for the item.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> text;

					/// <summary>
					/// Defines the number of objects that match this item in the target data set.
					/// </summary>
					public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> count;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new <code>FacetFilterItem</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern FacetFilterItem(string sId, sap.m.FacetFilterItem.Settings mSettings);

				/// <summary>
				/// Constructor for a new <code>FacetFilterItem</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern FacetFilterItem(string sId);

				/// <summary>
				/// Constructor for a new <code>FacetFilterItem</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern FacetFilterItem();

				/// <summary>
				/// Constructor for a new <code>FacetFilterItem</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern FacetFilterItem(sap.m.FacetFilterItem.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property key

				/// <summary>
				/// Gets current value of property {@link #getKey key}.
				/// 
				/// Can be used as input for subsequent actions.
				/// </summary>
				/// <returns>Value of property <code>key</code></returns>
				public extern virtual string getKey();

				/// <summary>
				/// Sets a new value for property {@link #getKey key}.
				/// 
				/// Can be used as input for subsequent actions.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sKey">New value for property <code>key</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FacetFilterItem setKey(string sKey);

				#endregion

				#region Methods for Property text

				/// <summary>
				/// Gets current value of property {@link #getText text}.
				/// 
				/// Determines the text to be displayed for the item.
				/// </summary>
				/// <returns>Value of property <code>text</code></returns>
				public extern virtual string getText();

				/// <summary>
				/// Sets a new value for property {@link #getText text}.
				/// 
				/// Determines the text to be displayed for the item.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sText">New value for property <code>text</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FacetFilterItem setText(string sText);

				#endregion

				#region Methods for Property count

				/// <summary>
				/// Gets current value of property {@link #getCount count}.
				/// 
				/// Defines the number of objects that match this item in the target data set.
				/// </summary>
				/// <returns>Value of property <code>count</code></returns>
				[Obsolete("Deprecated since 1.18.11. replaced by <code>setCounter</code> method")]
				public extern virtual int getCount();

				/// <summary>
				/// Sets a new value for property {@link #getCount count}.
				/// 
				/// Defines the number of objects that match this item in the target data set.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="iCount">New value for property <code>count</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.18.11. replaced by <code>setCounter</code> method")]
				public extern virtual sap.m.FacetFilterItem setCount(int iCount);

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.FacetFilterItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.ListItemBase.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.FacetFilterItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.ListItemBase.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.FacetFilterItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.ListItemBase.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.FacetFilterItem.
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
