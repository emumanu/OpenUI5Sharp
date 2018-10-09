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
				/// Tree binding implementation for client models.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.model.ClientTreeBinding")]
				public partial class ClientTreeBinding : sap.ui.model.TreeBinding
				{
					#region Constructor

					/// <summary>
					/// Creates a new ClientTreeBinding.
					/// 
					/// This constructor should only be called by subclasses or model implementations, not by application or control code. Such code should use {@link sap.ui.model.Model#bindTree Model#bindTree} on the corresponding model implementation instead.
					/// </summary>
					/// <param name="oModel">Model instance that this binding is created for and that it belongs to</param>
					/// <param name="sPath">Binding path pointing to the tree / array that should be bound; syntax is defined by subclasses</param>
					/// <param name="oContext">Context object for this binding, mandatory when when a relative binding path is given</param>
					/// <param name="aApplicationFilters">Predefined application filter, either a single instance or an array</param>
					/// <param name="mParameters">Additional model specific parameters as defined by subclasses; this class does not introduce any own parameters</param>
					/// <param name="aSorters">Predefined sorter/s contained in an array (optional)</param>
					public extern ClientTreeBinding(sap.ui.model.Model oModel, string sPath, sap.ui.model.Context oContext, Union<sap.ui.model.Filter, sap.ui.model.Filter[]> aApplicationFilters, object mParameters, sap.ui.model.Sorter[] aSorters);

					/// <summary>
					/// Creates a new ClientTreeBinding.
					/// 
					/// This constructor should only be called by subclasses or model implementations, not by application or control code. Such code should use {@link sap.ui.model.Model#bindTree Model#bindTree} on the corresponding model implementation instead.
					/// </summary>
					/// <param name="oModel">Model instance that this binding is created for and that it belongs to</param>
					/// <param name="sPath">Binding path pointing to the tree / array that should be bound; syntax is defined by subclasses</param>
					/// <param name="oContext">Context object for this binding, mandatory when when a relative binding path is given</param>
					/// <param name="aApplicationFilters">Predefined application filter, either a single instance or an array</param>
					/// <param name="mParameters">Additional model specific parameters as defined by subclasses; this class does not introduce any own parameters</param>
					public extern ClientTreeBinding(sap.ui.model.Model oModel, string sPath, sap.ui.model.Context oContext, Union<sap.ui.model.Filter, sap.ui.model.Filter[]> aApplicationFilters, object mParameters);

					/// <summary>
					/// Creates a new ClientTreeBinding.
					/// 
					/// This constructor should only be called by subclasses or model implementations, not by application or control code. Such code should use {@link sap.ui.model.Model#bindTree Model#bindTree} on the corresponding model implementation instead.
					/// </summary>
					/// <param name="oModel">Model instance that this binding is created for and that it belongs to</param>
					/// <param name="sPath">Binding path pointing to the tree / array that should be bound; syntax is defined by subclasses</param>
					/// <param name="oContext">Context object for this binding, mandatory when when a relative binding path is given</param>
					/// <param name="aApplicationFilters">Predefined application filter, either a single instance or an array</param>
					public extern ClientTreeBinding(sap.ui.model.Model oModel, string sPath, sap.ui.model.Context oContext, Union<sap.ui.model.Filter, sap.ui.model.Filter[]> aApplicationFilters);

					/// <summary>
					/// Creates a new ClientTreeBinding.
					/// 
					/// This constructor should only be called by subclasses or model implementations, not by application or control code. Such code should use {@link sap.ui.model.Model#bindTree Model#bindTree} on the corresponding model implementation instead.
					/// </summary>
					/// <param name="oModel">Model instance that this binding is created for and that it belongs to</param>
					/// <param name="sPath">Binding path pointing to the tree / array that should be bound; syntax is defined by subclasses</param>
					/// <param name="oContext">Context object for this binding, mandatory when when a relative binding path is given</param>
					public extern ClientTreeBinding(sap.ui.model.Model oModel, string sPath, sap.ui.model.Context oContext);

					/// <summary>
					/// Creates a new ClientTreeBinding.
					/// 
					/// This constructor should only be called by subclasses or model implementations, not by application or control code. Such code should use {@link sap.ui.model.Model#bindTree Model#bindTree} on the corresponding model implementation instead.
					/// </summary>
					/// <param name="oModel">Model instance that this binding is created for and that it belongs to</param>
					/// <param name="sPath">Binding path pointing to the tree / array that should be bound; syntax is defined by subclasses</param>
					public extern ClientTreeBinding(sap.ui.model.Model oModel, string sPath);

					#endregion

					#region Methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.model.ClientTreeBinding with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.TreeBinding.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.model.ClientTreeBinding with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.TreeBinding.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.model.ClientTreeBinding with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.TreeBinding.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Filters the tree according to the filter definitions.
					/// 
					/// The filtering is applied recursively through the tree. The parent nodes of filtered child nodes will also be displayed if they don't match the filter conditions. All filters belonging to a group (=have the same path) are ORed and after that the results of all groups are ANDed.
					/// </summary>
					/// <param name="aFilters">Single filter object or an array of filter objects</param>
					/// <param name="sFilterType">Type of the filter which should be adjusted, if it is not given, the standard behaviour applies</param>
					/// <returns><code>this</code> to facilitate method chaining</returns>
					public extern virtual sap.ui.model.ClientTreeBinding filter(Union<sap.ui.model.Filter, sap.ui.model.Filter[]> aFilters, sap.ui.model.FilterType sFilterType);

					/// <summary>
					/// Returns a metadata object for class sap.ui.model.ClientTreeBinding.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					/// <summary>
					/// Return node contexts for the tree
					/// </summary>
					/// <param name="oContext">to use for retrieving the node contexts</param>
					/// <param name="iStartIndex">the startIndex where to start the retrieval of contexts</param>
					/// <param name="iLength">determines how many contexts to retrieve beginning from the start index.</param>
					/// <returns>the contexts array</returns>
					public extern virtual object[] getNodeContexts(object oContext, int iStartIndex, int iLength);

					/// <summary>
					/// Return root contexts for the tree
					/// </summary>
					/// <param name="iStartIndex">the startIndex where to start the retrieval of contexts</param>
					/// <param name="iLength">determines how many contexts to retrieve beginning from the start index.</param>
					/// <returns>the contexts array</returns>
					public extern virtual object[] getRootContexts(int iStartIndex, int iLength);

					/// <summary>
					/// Returns if the node has child nodes.
					/// </summary>
					/// <param name="oContext">the context element of the node</param>
					/// <returns>true if node has children</returns>
					public extern virtual bool hasChildren(object oContext);

					/// <summary>
					/// Sorts the contexts of this ClientTreeBinding. The tree will be sorted level by level. So the nodes are NOT sorted absolute, but relative to their parent node, to keep the hierarchy untouched.
					/// </summary>
					/// <param name="an">array of Sorter instances which will be applied</param>
					/// <returns>returns <code>this</code> to facilitate method chaining</returns>
					public extern virtual sap.ui.model.ClientTreeBinding sort(sap.ui.model.Sorter[] an);

					#endregion

				}
			}
		}
	}
}
