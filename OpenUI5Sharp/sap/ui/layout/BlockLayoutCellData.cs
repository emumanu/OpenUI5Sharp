using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace OpenUI5Sharp
{
	public static partial class sap
	{
		public static partial class ui
		{
			public static partial class layout
			{
				/// <summary>
				/// Holds layout data for the BlockLayoutCells contents.
				/// </summary>
				[External]
				[Namespace(false)]
				public partial class BlockLayoutCellData : sap.ui.core.LayoutData
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
						/// Sets the width of the cell for S size of the BlockLayout.
						/// </summary>
						public Union<int, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> sSize;

						/// <summary>
						/// Sets the width of the cell for M size of the BlockLayout.
						/// </summary>
						public Union<int, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> mSize;

						/// <summary>
						/// Sets the width of the cell for L size of the BlockLayout.
						/// </summary>
						public Union<int, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> lSize;

						/// <summary>
						/// Sets the width of the cell for XL size of the BlockLayout.
						/// </summary>
						public Union<int, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> xlSize;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new BlockLayoutCellData.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern BlockLayoutCellData(string sId, sap.ui.layout.BlockLayoutCellData.Settings mSettings);

					/// <summary>
					/// Constructor for a new BlockLayoutCellData.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern BlockLayoutCellData(string sId);

					/// <summary>
					/// Constructor for a new BlockLayoutCellData.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern BlockLayoutCellData();

					/// <summary>
					/// Constructor for a new BlockLayoutCellData.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern BlockLayoutCellData(sap.ui.layout.BlockLayoutCellData.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property sSize

					/// <summary>
					/// Gets current value of property {@link #getSSize sSize}.
					/// 
					/// Sets the width of the cell for S size of the BlockLayout.
					/// 
					/// Default value is <code>1</code>.
					/// </summary>
					/// <returns>Value of property <code>sSize</code></returns>
					public extern virtual int getSSize();

					/// <summary>
					/// Sets a new value for property {@link #getSSize sSize}.
					/// 
					/// Sets the width of the cell for S size of the BlockLayout.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>1</code>.
					/// </summary>
					/// <param name="iSSize">New value for property <code>sSize</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.BlockLayoutCellData setSSize(int iSSize);

					#endregion

					#region Methods for Property mSize

					/// <summary>
					/// Gets current value of property {@link #getMSize mSize}.
					/// 
					/// Sets the width of the cell for M size of the BlockLayout.
					/// 
					/// Default value is <code>1</code>.
					/// </summary>
					/// <returns>Value of property <code>mSize</code></returns>
					public extern virtual int getMSize();

					/// <summary>
					/// Sets a new value for property {@link #getMSize mSize}.
					/// 
					/// Sets the width of the cell for M size of the BlockLayout.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>1</code>.
					/// </summary>
					/// <param name="iMSize">New value for property <code>mSize</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.BlockLayoutCellData setMSize(int iMSize);

					#endregion

					#region Methods for Property lSize

					/// <summary>
					/// Gets current value of property {@link #getLSize lSize}.
					/// 
					/// Sets the width of the cell for L size of the BlockLayout.
					/// 
					/// Default value is <code>1</code>.
					/// </summary>
					/// <returns>Value of property <code>lSize</code></returns>
					public extern virtual int getLSize();

					/// <summary>
					/// Sets a new value for property {@link #getLSize lSize}.
					/// 
					/// Sets the width of the cell for L size of the BlockLayout.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>1</code>.
					/// </summary>
					/// <param name="iLSize">New value for property <code>lSize</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.BlockLayoutCellData setLSize(int iLSize);

					#endregion

					#region Methods for Property xlSize

					/// <summary>
					/// Gets current value of property {@link #getXlSize xlSize}.
					/// 
					/// Sets the width of the cell for XL size of the BlockLayout.
					/// 
					/// Default value is <code>1</code>.
					/// </summary>
					/// <returns>Value of property <code>xlSize</code></returns>
					public extern virtual int getXlSize();

					/// <summary>
					/// Sets a new value for property {@link #getXlSize xlSize}.
					/// 
					/// Sets the width of the cell for XL size of the BlockLayout.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>1</code>.
					/// </summary>
					/// <param name="iXlSize">New value for property <code>xlSize</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.BlockLayoutCellData setXlSize(int iXlSize);

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.layout.BlockLayoutCellData with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.LayoutData.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.layout.BlockLayoutCellData with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.LayoutData.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.layout.BlockLayoutCellData with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.LayoutData.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.layout.BlockLayoutCellData.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					/// <summary>
					/// Sets width of the cell to all sizes if the width is specified.
					/// </summary>
					/// <param name="iValue"></param>
					/// <returns></returns>
					public extern virtual sap.ui.layout.BlockLayoutCellData setSize(object iValue);

					#endregion

					#endregion

				}
			}
		}
	}
}
