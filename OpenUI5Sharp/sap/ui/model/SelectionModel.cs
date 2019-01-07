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
				[Name("sap.ui.model.SelectionModel")]
				public partial class SelectionModel : sap.ui.@base.EventProvider
				{
					#region Constructor

					/// <summary>
					/// Constructs an instance of an sap.ui.model.SelectionModel.
					/// </summary>
					/// <param name="iSelectionMode"><code>sap.ui.model.SelectionModel.SINGLE_SELECTION</code> or <code>sap.ui.model.SelectionModel.MULTI_SELECTION</code></param>
					public extern SelectionModel(int iSelectionMode);

					#endregion

					#region Fields

					/// <summary>
					/// SelectionMode: Multi Selection
					/// </summary>
					public static object MULTI_SELECTION;

					/// <summary>
					/// SelectionMode: Single Selection
					/// </summary>
					public static object SINGLE_SELECTION;

					#endregion

					#region Methods

					/// <summary>
					/// Changes the selection to be the union of the current selection and the range between <code>iFromIndex</code> and <code>iToIndex</code> inclusive. If <code>iFromIndex</code> is smaller than <code>iToIndex</code>, both parameters are swapped.
					/// 
					/// In <code>SINGLE_SELECTION</code> selection mode, this is equivalent to calling <code>setSelectionInterval</code>, and only the second index is used.
					/// 
					/// If this call results in a change to the current selection or lead selection, then a <code>SelectionChanged</code> event is fired.
					/// </summary>
					/// <param name="iFromIndex">one end of the interval.</param>
					/// <param name="iToIndex">other end of the interval</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.model.SelectionModel addSelectionInterval(int iFromIndex, int iToIndex);

					/// <summary>
					/// Attach event-handler <code>fnFunction</code> to the 'selectionChanged' event of this <code>sap.ui.model.SelectionModel</code>.<br/>
					/// </summary>
					/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
					/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
					/// <param name="oListener">Object on which to call the given function. If empty, this Model is used.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.model.SelectionModel attachSelectionChanged(object oData, object fnFunction, object oListener);

					/// <summary>
					/// Attach event-handler <code>fnFunction</code> to the 'selectionChanged' event of this <code>sap.ui.model.SelectionModel</code>.<br/>
					/// </summary>
					/// <param name="oData">The object, that should be passed along with the event-object when firing the event.</param>
					/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.model.SelectionModel attachSelectionChanged(object oData, object fnFunction);

					/// <summary>
					/// Attach event-handler <code>fnFunction</code> to the 'selectionChanged' event of this <code>sap.ui.model.SelectionModel</code>.<br/>
					/// </summary>
					/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.model.SelectionModel attachSelectionChanged(object fnFunction);

					/// <summary>
					/// Change the selection to the empty set and clears the lead selection.
					/// 
					/// If this call results in a change to the current selection or lead selection, then a <code>SelectionChanged</code> event is fired.
					/// </summary>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.model.SelectionModel clearSelection();

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
					/// Creates a new subclass of class sap.ui.model.SelectionModel with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.EventProvider.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.model.SelectionModel with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.EventProvider.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.model.SelectionModel with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.EventProvider.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Fire event 'selectionChanged' to attached listeners.
					/// 
					/// Expects following event parameters: <ul> <li>'leadIndex' of type <code>int</code> Lead selection index.</li> <li>'rowIndices' of type <code>int[]</code> Other selected indices (if available)</li> </ul>
					/// </summary>
					/// <param name="mArguments">the arguments to pass along with the event.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.model.SelectionModel fireSelectionChanged(object mArguments);

					/// <summary>
					/// Return the second index argument from the most recent call to setSelectionInterval(), addSelectionInterval() or removeSelectionInterval().
					/// </summary>
					/// <returns>lead selected index</returns>
					public extern virtual int getLeadSelectedIndex();

					/// <summary>
					/// Returns a metadata object for class sap.ui.model.SelectionModel.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					[Name("getMetadata")]
					public extern static sap.ui.@base.Metadata getMetadataStatic();

					/// <summary>
					/// Returns the selected indices as array.
					/// </summary>
					/// <returns>array of selected indices</returns>
					public extern virtual int[] getSelectedIndices();

					/// <summary>
					/// Returns the current selection mode.
					/// </summary>
					/// <returns>the current selection mode</returns>
					public extern virtual int getSelectionMode();

					/// <summary>
					/// Returns true if the specified index is selected.
					/// </summary>
					/// <param name="iIndex"></param>
					/// <returns>true if the specified index is selected.</returns>
					public extern virtual bool isSelectedIndex(int iIndex);

					/// <summary>
					/// Moves all selected indices starting at the position <code>iStartIndex</code> <code>iMove</code> items.
					/// 
					/// This can be used if new items are inserted to the item set and you want to keep the selection. To handle a deletion of items use <code>sliceSelectionInterval</code>.
					/// 
					/// If this call results in a change to the current selection or lead selection, then a <code>SelectionChanged</code> event is fired.
					/// </summary>
					/// <param name="iStartIndex">start at this position</param>
					/// <param name="iMove"></param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.model.SelectionModel moveSelectionInterval(int iStartIndex, int iMove);

					/// <summary>
					/// Changes the selection to be the set difference of the current selection and the indices between <code>iFromIndex</code> and <code>iToIndex</code> inclusive. If <code>iFromIndex</code> is smaller than <code>iToIndex</code>, both parameters are swapped.
					/// 
					/// If the range of removed selection indices includes the current lead selection, then the lead selection will be unset (set to -1).
					/// 
					/// If this call results in a change to the current selection or lead selection, then a <code>SelectionChanged</code> event is fired.
					/// </summary>
					/// <param name="iFromIndex">one end of the interval.</param>
					/// <param name="iToIndex">other end of the interval</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.model.SelectionModel removeSelectionInterval(int iFromIndex, int iToIndex);

					/// <summary>
					/// Selects all rows up to the <code>iToIndex</iToIndex>.
					/// 
					/// If this call results in a change to the current selection, then a <code>SelectionChanged</code> event is fired.
					/// </summary>
					/// <param name="iToIndex">end of the interval</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.model.SelectionModel selectAll(int iToIndex);

					/// <summary>
					/// Changes the selection to be equal to the range <code>iFromIndex</code> and <code>iToIndex</code> inclusive. If <code>iFromIndex</code> is smaller than <code>iToIndex</code>, both parameters are swapped.
					/// 
					/// In <code>SINGLE_SELECTION</code> selection mode, only <code>iToIndex</iToIndex> is used.
					/// 
					/// If this call results in a change to the current selection, then a <code>SelectionChanged</code> event is fired.
					/// </summary>
					/// <param name="iFromIndex">one end of the interval.</param>
					/// <param name="iToIndex">other end of the interval</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.model.SelectionModel setSelectionInterval(int iFromIndex, int iToIndex);

					/// <summary>
					/// Sets the selection mode. The following list describes the accepted selection modes: <ul> <li><code>sap.ui.model.SelectionModel.SINGLE_SELECTION</code> - Only one list index can be selected at a time. In this mode, <code>setSelectionInterval</code> and <code>addSelectionInterval</code> are equivalent, both replacing the current selection with the index represented by the second argument (the "lead"). <li><code>sap.ui.model.SelectionModel.MULTI_SELECTION</code> - In this mode, there's no restriction on what can be selected. </ul>
					/// </summary>
					/// <param name="iSelectionMode">selection mode</param>
					public extern virtual void setSelectionMode(int iSelectionMode);

					/// <summary>
					/// Slices a the indices between the two indices from the selection. If <code>iFromIndex</code> is smaller than <code>iToIndex</code>, both parameters are swapped.
					/// 
					/// If the range of removed selection indices includes the current lead selection, then the lead selection will be unset (set to -1).
					/// 
					/// If this call results in a change to the current selection or lead selection, then a <code>SelectionChanged</code> event is fired.
					/// </summary>
					/// <param name="iFromIndex">one end of the interval.</param>
					/// <param name="iToIndex">other end of the interval</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.model.SelectionModel sliceSelectionInterval(int iFromIndex, int iToIndex);

					#endregion

				}
			}
		}
	}
}
