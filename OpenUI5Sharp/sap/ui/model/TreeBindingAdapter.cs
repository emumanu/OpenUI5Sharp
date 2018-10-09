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
				[External]
				[Namespace(false)]
				[Name("sap.ui.model.TreeBindingAdapter")]
				public partial class TreeBindingAdapter
				{
					#region Constructor

					/// <summary>
					/// Adapter for TreeBindings to add the ListBinding functionality and use the tree structure in list based controls.
					/// </summary>
					public extern TreeBindingAdapter();

					#endregion

					#region Methods

					/// <summary>
					/// Calculate the request length based on the given information
					/// </summary>
					/// <param name="iMaxGroupSize">the maximum group size</param>
					/// <param name="oSection">the information of the current section</param>
					[Obsolete("Deprecated since 1.52. This method is marked as 'protected' which was meant to be overwritten by its subclasses. It may be renamed or deleted and should only be called from this class or its subclasses.")]
					public extern virtual void _calculateRequestLength(int iMaxGroupSize, object oSection);

					/// <summary>
					/// Attach event-handler <code>fnFunction</code> to the 'selectionChanged' event of this <code>sap.ui.model.SelectionModel</code>.<br/> Event is fired if the selection of tree nodes is changed in any way.
					/// </summary>
					/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
					/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
					/// <param name="oListener">Object on which to call the given function. If empty, this <code>TreeBindingAdapter</code> is used.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.model.SelectionModel attachSelectionChanged(object oData, object fnFunction, object oListener);

					/// <summary>
					/// Attach event-handler <code>fnFunction</code> to the 'selectionChanged' event of this <code>sap.ui.model.SelectionModel</code>.<br/> Event is fired if the selection of tree nodes is changed in any way.
					/// </summary>
					/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
					/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.model.SelectionModel attachSelectionChanged(object oData, object fnFunction);

					/// <summary>
					/// Attach event-handler <code>fnFunction</code> to the 'selectionChanged' event of this <code>sap.ui.model.SelectionModel</code>.<br/> Event is fired if the selection of tree nodes is changed in any way.
					/// </summary>
					/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.model.SelectionModel attachSelectionChanged(object fnFunction);

					/// <summary>
					/// Detach event-handler <code>fnFunction</code> from the 'selectionChanged' event of this <code>sap.ui.model.SelectionModel</code>.<br/>
					/// 
					/// The passed function and listener object must match the ones previously used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to call, when the event occurs.</param>
					/// <param name="oListener">Object on which the given function had to be called.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.model.SelectionModel detachSelectionChanged(object fnFunction, object oListener);

					/// <summary>
					/// Fire event 'selectionChanged' to attached listeners.
					/// 
					/// Expects following event parameters: <ul> <li>'leadIndex' of type <code>int</code> Lead selection index.</li> <li>'rowIndices' of type <code>int[]</code> Other selected indices (if available)</li> </ul>
					/// </summary>
					/// <param name="mArguments">the arguments to pass along with the event.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.model.SelectionModel fireSelectionChanged(object mArguments);

					/// <summary>
					/// Retrieves the requested part from the tree and returns node objects.
					/// </summary>
					/// <param name="iStartIndex"></param>
					/// <param name="iLength"></param>
					/// <param name="iThreshold"></param>
					/// <returns>Tree Node</returns>
					public extern virtual object getNodes(int iStartIndex, int iLength, int iThreshold);

					#endregion

				}
			}
		}
	}
}
