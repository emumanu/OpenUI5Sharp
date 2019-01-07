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
				/// The CompositeBinding is used to bundle multiple property bindings which are be used to provide a single binding against these property bindings.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.model.CompositeBinding")]
				public partial class CompositeBinding : sap.ui.model.PropertyBinding
				{
					#region Constructor

					/// <summary>
					/// Constructor for CompositeBinding
					/// </summary>
					public extern CompositeBinding();

					#endregion

					#region Methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.model.CompositeBinding with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.PropertyBinding.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.model.CompositeBinding with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.PropertyBinding.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.model.CompositeBinding with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.PropertyBinding.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns the property bindings contained in this composite binding.
					/// </summary>
					/// <returns>the property bindings in this composite binding</returns>
					public extern virtual object[] getBindings();

					/// <summary>
					/// Returns the current external value of the bound target which is formatted via a type or formatter function.
					/// </summary>
					/// <returns>the current value of the bound target</returns>
					public extern override object getExternalValue();

					/// <summary>
					/// Returns a metadata object for class sap.ui.model.CompositeBinding.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					[Name("getMetadata")]
					public extern static sap.ui.@base.Metadata getMetadataStatic();

					/// <summary>
					/// Returns the raw values of the property bindings in an array.
					/// </summary>
					/// <returns>the values of the internal property bindings in an array</returns>
					public extern override object getValue();

					/// <summary>
					/// Initialize the binding. The message should be called when creating a binding. The default implementation calls checkUpdate(true). Prevent checkUpdate to be triggered while initializing nestend bindings, it is sufficient to call checkUpdate when all nested bindings are initialized.
					/// </summary>
					public extern override void initialize();

					/// <summary>
					/// Suspends the binding update. No change events will be fired.
					/// 
					/// A refresh call with bForceUpdate set to true will also update the binding and fire a change in suspended mode. Special operations on bindings, which require updates to work properly (as paging or filtering in list bindings) will also update and cause a change event although the binding is suspended.
					/// </summary>
					public extern override void resume();

					/// <summary>
					/// Sets the external value of a composite binding. If no CompositeType is assigned to the binding, the default implementation assumes a space separated list of values. This will cause the setValue to be called for each nested binding, except for undefined values in the array.
					/// </summary>
					/// <param name="oValue">the value to set for this binding</param>
					public extern override void setExternalValue(object oValue);

					/// <summary>
					/// Sets the optional type and internal type for the binding. The type and internal type are used to do the parsing/formatting correctly. The internal type is the property type of the element which the value is formatted to.
					/// </summary>
					/// <param name="oType">the type for the binding</param>
					/// <param name="sInternalType">the internal type of the element property which this binding is bound against.</param>
					public extern virtual void setType(sap.ui.model.CompositeType oType, string sInternalType);

					/// <summary>
					/// Sets the values. This will cause the setValue to be called for each nested binding, except for undefined values in the array.
					/// </summary>
					/// <param name="aValues">the values to set for this binding</param>
					public extern virtual void setValue(object[] aValues);

					/// <summary>
					/// Suspends the binding update. No change events will be fired.
					/// 
					/// A refresh call with bForceUpdate set to true will also update the binding and fire a change in suspended mode. Special operations on bindings, which require updates to work properly (as paging or filtering in list bindings) will also update and cause a change event although the binding is suspended.
					/// </summary>
					public extern override void suspend();

					/// <summary>
					/// Determines if the property bindings in the composite binding should be updated by calling updateRequired on all property bindings with the specified model.
					/// </summary>
					/// <param name="oModel">The model instance to compare against</param>
					/// <returns>true if this binding should be updated</returns>
					public extern override bool updateRequired(object oModel);

					#endregion

				}
			}
		}
	}
}
