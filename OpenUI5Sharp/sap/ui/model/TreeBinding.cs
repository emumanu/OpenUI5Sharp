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
			public static partial class model
			{
				/// <summary>
				/// The TreeBinding is a specific binding for trees in the model, which can be used to populate Trees.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.model.TreeBinding")]
				public abstract partial class TreeBinding : sap.ui.model.Binding
				{
					#region Constructor

					/// <summary>
					/// Constructor for TreeBinding.
					/// 
					/// This constructor should only be called by subclasses or model implementations, not by application or control code. Such code should use {@link sap.ui.model.Model#bindTree Model#bindTree} on the corresponding model instead.
					/// </summary>
					/// <param name="oModel">Model instance that this binding is created for and that it belongs to</param>
					/// <param name="sPath">Path pointing to the tree / array that should be bound</param>
					/// <param name="oContext">Context object for this binding (optional)</param>
					/// <param name="aFilters">Predefined filter or an array of filters (optional)</param>
					/// <param name="mParameters">Additional model specific parameters (optional)</param>
					/// <param name="aSorters">Predefined sorter or an array of sorters (optional)</param>
					public extern TreeBinding(sap.ui.model.Model oModel, string sPath, object oContext, Union<sap.ui.model.Filter, sap.ui.model.Filter[]> aFilters, string mParameters, sap.ui.model.Sorter aSorters);

					/// <summary>
					/// Constructor for TreeBinding.
					/// 
					/// This constructor should only be called by subclasses or model implementations, not by application or control code. Such code should use {@link sap.ui.model.Model#bindTree Model#bindTree} on the corresponding model instead.
					/// </summary>
					/// <param name="oModel">Model instance that this binding is created for and that it belongs to</param>
					/// <param name="sPath">Path pointing to the tree / array that should be bound</param>
					/// <param name="oContext">Context object for this binding (optional)</param>
					/// <param name="aFilters">Predefined filter or an array of filters (optional)</param>
					/// <param name="mParameters">Additional model specific parameters (optional)</param>
					public extern TreeBinding(sap.ui.model.Model oModel, string sPath, object oContext, Union<sap.ui.model.Filter, sap.ui.model.Filter[]> aFilters, string mParameters);

					/// <summary>
					/// Constructor for TreeBinding.
					/// 
					/// This constructor should only be called by subclasses or model implementations, not by application or control code. Such code should use {@link sap.ui.model.Model#bindTree Model#bindTree} on the corresponding model instead.
					/// </summary>
					/// <param name="oModel">Model instance that this binding is created for and that it belongs to</param>
					/// <param name="sPath">Path pointing to the tree / array that should be bound</param>
					/// <param name="oContext">Context object for this binding (optional)</param>
					/// <param name="aFilters">Predefined filter or an array of filters (optional)</param>
					public extern TreeBinding(sap.ui.model.Model oModel, string sPath, object oContext, Union<sap.ui.model.Filter, sap.ui.model.Filter[]> aFilters);

					/// <summary>
					/// Constructor for TreeBinding.
					/// 
					/// This constructor should only be called by subclasses or model implementations, not by application or control code. Such code should use {@link sap.ui.model.Model#bindTree Model#bindTree} on the corresponding model instead.
					/// </summary>
					/// <param name="oModel">Model instance that this binding is created for and that it belongs to</param>
					/// <param name="sPath">Path pointing to the tree / array that should be bound</param>
					/// <param name="oContext">Context object for this binding (optional)</param>
					public extern TreeBinding(sap.ui.model.Model oModel, string sPath, object oContext);

					/// <summary>
					/// Constructor for TreeBinding.
					/// 
					/// This constructor should only be called by subclasses or model implementations, not by application or control code. Such code should use {@link sap.ui.model.Model#bindTree Model#bindTree} on the corresponding model instead.
					/// </summary>
					/// <param name="oModel">Model instance that this binding is created for and that it belongs to</param>
					/// <param name="sPath">Path pointing to the tree / array that should be bound</param>
					public extern TreeBinding(sap.ui.model.Model oModel, string sPath);

					#endregion

					#region Methods

					/// <summary>
					/// Attach event-handler <code>fnFunction</code> to the '_filter' event of this <code>sap.ui.model.TreeBinding</code>.<br/>
					/// </summary>
					/// <param name="fnFunction">The function to call, when the event occurs.</param>
					/// <param name="oListener">object on which to call the given function.</param>
					[Obsolete("Deprecated since 1.11. use the change event. It now contains a parameter (reason : 'filter') when a filter event is fired.")]
					public extern virtual void attachFilter(object fnFunction, object oListener);

					/// <summary>
					/// Attach event-handler <code>fnFunction</code> to the '_filter' event of this <code>sap.ui.model.TreeBinding</code>.<br/>
					/// </summary>
					/// <param name="fnFunction">The function to call, when the event occurs.</param>
					[Obsolete("Deprecated since 1.11. use the change event. It now contains a parameter (reason : 'filter') when a filter event is fired.")]
					public extern virtual void attachFilter(object fnFunction);

					/// <summary>
					/// Detach event-handler <code>fnFunction</code> from the '_filter' event of this <code>sap.ui.model.TreeBinding</code>.<br/>
					/// </summary>
					/// <param name="fnFunction">The function to call, when the event occurs.</param>
					/// <param name="oListener">object on which to call the given function.</param>
					[Obsolete("Deprecated since 1.11. use the change event.")]
					public extern virtual void detachFilter(object fnFunction, object oListener);

					/// <summary>
					/// Detach event-handler <code>fnFunction</code> from the '_filter' event of this <code>sap.ui.model.TreeBinding</code>.<br/>
					/// </summary>
					/// <param name="fnFunction">The function to call, when the event occurs.</param>
					[Obsolete("Deprecated since 1.11. use the change event.")]
					public extern virtual void detachFilter(object fnFunction);

					/// <summary>
					/// Creates a new subclass of class sap.ui.model.TreeBinding with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.Binding.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.model.TreeBinding with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.Binding.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.model.TreeBinding with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.Binding.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Filters the tree according to the filter definitions.
					/// </summary>
					/// <param name="aFilters">Array of sap.ui.model.Filter objects</param>
					/// <param name="sFilterType">Type of the filter which should be adjusted, if it is not given, the standard behaviour applies</param>
					public extern virtual void filter(sap.ui.model.Filter[] aFilters, sap.ui.model.FilterType sFilterType);

					/// <summary>
					/// Returns the number of child nodes of a specific context
					/// </summary>
					/// <param name="oContext">the context element of the node</param>
					/// <returns>the number of children</returns>
					public extern virtual int getChildCount(object oContext);

					/// <summary>
					/// Return the filter information as an AST. The default implementation checks for this.oCombinedFilter, models not using this member may override the method. Consumers must not rely on the origin information to be available, future filter implementations will not provide this information.
					/// </summary>
					/// <param name="bIncludeOrigin">include information about the filter objects the tree has been created from</param>
					/// <returns>The AST of the filter tree</returns>
					private extern object getFilterInfo(bool bIncludeOrigin);

					/// <summary>
					/// Returns a metadata object for class sap.ui.model.TreeBinding.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					[Name("getMetadata")]
					public extern static sap.ui.@base.Metadata getMetadataStatic();

					/// <summary>
					/// Returns the current value of the bound target
					/// </summary>
					/// <param name="oContext">the context element of the node</param>
					/// <param name="iStartIndex">the startIndex where to start the retrieval of contexts</param>
					/// <param name="iLength">determines how many contexts to retrieve beginning from the start index.</param>
					/// <returns>the array of child contexts for the given node</returns>
					public extern virtual object[] getNodeContexts(object oContext, int iStartIndex, int iLength);

					/// <summary>
					/// Returns the current value of the bound target
					/// </summary>
					/// <param name="iStartIndex">the startIndex where to start the retrieval of contexts</param>
					/// <param name="iLength">determines how many contexts to retrieve beginning from the start index.</param>
					/// <returns>the array of child contexts for the root node</returns>
					public extern virtual object[] getRootContexts(int iStartIndex, int iLength);

					/// <summary>
					/// Returns if the node has child nodes
					/// </summary>
					/// <param name="oContext">the context element of the node</param>
					/// <returns>true if node has children</returns>
					public extern virtual bool hasChildren(object oContext);

					/// <summary>
					/// Sorts the tree according to the sorter definitions.
					/// </summary>
					/// <param name="aSorters">Array of sap.ui.model.Sorter objects</param>
					public extern virtual void sort(sap.ui.model.Sorter[] aSorters);

					#endregion

				}
			}
		}
	}
}
