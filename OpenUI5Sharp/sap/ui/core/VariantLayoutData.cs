using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public partial class sap
	{
		public static partial class ui
		{
			public static partial class core
			{
				/// <summary>
				/// Allows to add multiple LayoutData to one control in case that an easy switch of layouts (e.g. in a Form) is needed.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.core.VariantLayoutData")]
				public partial class VariantLayoutData : sap.ui.core.LayoutData
				{
					#region Settings

					/// <summary>
					/// Settings class to create the object
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class Settings : sap.ui.core.LayoutData.Settings
					{
						/// <summary>
						/// Allows multiple LayoutData.
						/// </summary>
						public Union<sap.ui.core.LayoutData[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> multipleLayoutData;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new VariantLayoutData.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern VariantLayoutData(string sId, sap.ui.core.VariantLayoutData.Settings mSettings);

					/// <summary>
					/// Constructor for a new VariantLayoutData.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern VariantLayoutData(string sId);

					/// <summary>
					/// Constructor for a new VariantLayoutData.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern VariantLayoutData();

					/// <summary>
					/// Constructor for a new VariantLayoutData.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern VariantLayoutData(sap.ui.core.VariantLayoutData.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Aggregation multipleLayoutData

					/// <summary>
					/// Gets content of aggregation {@link #getMultipleLayoutData multipleLayoutData}.
					/// 
					/// Allows multiple LayoutData.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.LayoutData[] getMultipleLayoutData();

					/// <summary>
					/// Destroys all the multipleLayoutData in the aggregation {@link #getMultipleLayoutData multipleLayoutData}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.VariantLayoutData destroyMultipleLayoutData();

					/// <summary>
					/// Inserts a multipleLayoutData into the aggregation {@link #getMultipleLayoutData multipleLayoutData}.
					/// </summary>
					/// <param name="oMultipleLayoutData">The multipleLayoutData to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the multipleLayoutData should be inserted at; for a negative value of <code>iIndex</code>, the multipleLayoutData is inserted at position 0; for a value greater than the current size of the aggregation, the multipleLayoutData is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.VariantLayoutData insertMultipleLayoutData(sap.ui.core.LayoutData oMultipleLayoutData, int iIndex);

					/// <summary>
					/// Adds some multipleLayoutData to the aggregation {@link #getMultipleLayoutData multipleLayoutData}.
					/// </summary>
					/// <param name="oMultipleLayoutData">The multipleLayoutData to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.VariantLayoutData addMultipleLayoutData(sap.ui.core.LayoutData oMultipleLayoutData);

					/// <summary>
					/// Removes a multipleLayoutData from the aggregation {@link #getMultipleLayoutData multipleLayoutData}.
					/// </summary>
					/// <param name="vMultipleLayoutData">The multipleLayoutData to remove or its index or id</param>
					/// <returns>The removed multipleLayoutData or <code>null</code></returns>
					public extern virtual sap.ui.core.LayoutData removeMultipleLayoutData(Union<int, string, sap.ui.core.LayoutData> vMultipleLayoutData);

					/// <summary>
					/// Checks for the provided <code>sap.ui.core.LayoutData</code> in the aggregation {@link #getMultipleLayoutData multipleLayoutData}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oMultipleLayoutData">The multipleLayoutData whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfMultipleLayoutData(sap.ui.core.LayoutData oMultipleLayoutData);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getMultipleLayoutData multipleLayoutData}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.core.LayoutData[] removeAllMultipleLayoutData();

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.VariantLayoutData with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.LayoutData.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.VariantLayoutData with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.LayoutData.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.VariantLayoutData with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.LayoutData.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.core.VariantLayoutData.
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
}
