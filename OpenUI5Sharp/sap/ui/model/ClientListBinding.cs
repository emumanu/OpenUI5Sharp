using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace OpenUI5Sharp
{
	public partial class sap
	{
		public static partial class ui
		{
			public static partial class model
			{
				/// <summary>
				/// List binding implementation for client models.
				/// </summary>
				[External]
				[Namespace(false)]
				public partial class ClientListBinding : sap.ui.model.ListBinding
				{
					#region Constructor

					/// <summary>
					/// Creates a new ClientListBinding.
					/// 
					/// This constructor should only be called by subclasses or model implementations, not by application or control code. Such code should use {@link sap.ui.model.Model#bindList Model#bindList} on the corresponding model implementation instead.
					/// </summary>
					/// <param name="oModel">Model instance that this binding is created for and that it belongs to</param>
					/// <param name="sPath">Binding path to be used for this binding, syntax depends on the concrete subclass</param>
					/// <param name="oContext">Binding context relative to which a relative binding path will be resolved</param>
					/// <param name="aSorters">Initial sort order (can be either a sorter or an array of sorters)</param>
					/// <param name="aFilters">Predefined filter/s (can be either a filter or an array of filters)</param>
					/// <param name="mParameters">Map of optional parameters as defined by subclasses; this class does not introduce any own parameters</param>
					public extern ClientListBinding(sap.ui.model.Model oModel, string sPath, sap.ui.model.Context oContext, Union<sap.ui.model.Sorter, sap.ui.model.Sorter[]> aSorters, Union<sap.ui.model.Filter, sap.ui.model.Filter[]> aFilters, object mParameters);

					/// <summary>
					/// Creates a new ClientListBinding.
					/// 
					/// This constructor should only be called by subclasses or model implementations, not by application or control code. Such code should use {@link sap.ui.model.Model#bindList Model#bindList} on the corresponding model implementation instead.
					/// </summary>
					/// <param name="oModel">Model instance that this binding is created for and that it belongs to</param>
					/// <param name="sPath">Binding path to be used for this binding, syntax depends on the concrete subclass</param>
					/// <param name="oContext">Binding context relative to which a relative binding path will be resolved</param>
					/// <param name="aSorters">Initial sort order (can be either a sorter or an array of sorters)</param>
					/// <param name="aFilters">Predefined filter/s (can be either a filter or an array of filters)</param>
					public extern ClientListBinding(sap.ui.model.Model oModel, string sPath, sap.ui.model.Context oContext, Union<sap.ui.model.Sorter, sap.ui.model.Sorter[]> aSorters, Union<sap.ui.model.Filter, sap.ui.model.Filter[]> aFilters);

					/// <summary>
					/// Creates a new ClientListBinding.
					/// 
					/// This constructor should only be called by subclasses or model implementations, not by application or control code. Such code should use {@link sap.ui.model.Model#bindList Model#bindList} on the corresponding model implementation instead.
					/// </summary>
					/// <param name="oModel">Model instance that this binding is created for and that it belongs to</param>
					/// <param name="sPath">Binding path to be used for this binding, syntax depends on the concrete subclass</param>
					/// <param name="oContext">Binding context relative to which a relative binding path will be resolved</param>
					/// <param name="aSorters">Initial sort order (can be either a sorter or an array of sorters)</param>
					public extern ClientListBinding(sap.ui.model.Model oModel, string sPath, sap.ui.model.Context oContext, Union<sap.ui.model.Sorter, sap.ui.model.Sorter[]> aSorters);

					/// <summary>
					/// Creates a new ClientListBinding.
					/// 
					/// This constructor should only be called by subclasses or model implementations, not by application or control code. Such code should use {@link sap.ui.model.Model#bindList Model#bindList} on the corresponding model implementation instead.
					/// </summary>
					/// <param name="oModel">Model instance that this binding is created for and that it belongs to</param>
					/// <param name="sPath">Binding path to be used for this binding, syntax depends on the concrete subclass</param>
					/// <param name="oContext">Binding context relative to which a relative binding path will be resolved</param>
					public extern ClientListBinding(sap.ui.model.Model oModel, string sPath, sap.ui.model.Context oContext);

					#endregion

					#region Methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.model.ClientListBinding with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.ListBinding.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.model.ClientListBinding with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.ListBinding.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.model.ClientListBinding with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.ListBinding.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Applies a new set of filters to the list represented by this binding.
					/// 
					/// See {@link sap.ui.model.ListBinding#filter ListBinding#filter} for a more detailed description of list filtering.
					/// 
					/// When no <code>sFilterType</code> is given, any previously configured application filters are cleared and the given filters are used as control filters
					/// </summary>
					/// <param name="aFilters">Array of filter objects</param>
					/// <param name="sFilterType">Type of the filter which should be adjusted; if no type is given, then any previously configured application filters are cleared and the given filters are used as control filters</param>
					/// <returns>returns <code>this</code> to facilitate method chaining</returns>
					public extern override sap.ui.model.ListBinding filter(sap.ui.model.Filter[] aFilters, sap.ui.model.FilterType sFilterType);

					/// <summary>
					/// Applies a new set of filters to the list represented by this binding.
					/// 
					/// See {@link sap.ui.model.ListBinding#filter ListBinding#filter} for a more detailed description of list filtering.
					/// 
					/// When no <code>sFilterType</code> is given, any previously configured application filters are cleared and the given filters are used as control filters
					/// </summary>
					/// <param name="aFilters">Array of filter objects</param>
					/// <returns>returns <code>this</code> to facilitate method chaining</returns>
					public extern override sap.ui.model.ListBinding filter(sap.ui.model.Filter[] aFilters);

					/// <summary>
					/// Returns a metadata object for class sap.ui.model.ClientListBinding.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					#endregion

				}
			}
		}
	}
}
