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
				/// The PropertyBinding is used to access single data values in the data model.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.model.PropertyBinding")]
				public abstract partial class PropertyBinding : sap.ui.model.Binding
				{
					#region Constructor

					/// <summary>
					/// Constructor for PropertyBinding
					/// </summary>
					/// <param name="oModel"></param>
					/// <param name="sPath"></param>
					/// <param name="oContext"></param>
					/// <param name="mParameters"></param>
					public extern PropertyBinding(sap.ui.model.Model oModel, string sPath, sap.ui.model.Context oContext, object mParameters);

					/// <summary>
					/// Constructor for PropertyBinding
					/// </summary>
					/// <param name="oModel"></param>
					/// <param name="sPath"></param>
					/// <param name="oContext"></param>
					public extern PropertyBinding(sap.ui.model.Model oModel, string sPath, sap.ui.model.Context oContext);

					#endregion

					#region Methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.model.PropertyBinding with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.Binding.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.model.PropertyBinding with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.Binding.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.model.PropertyBinding with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.Binding.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns the binding mode
					/// </summary>
					/// <returns>the binding mode</returns>
					public extern virtual sap.ui.model.BindingMode getBindingMode();

					/// <summary>
					/// Returns the current external value of the bound target which is formatted via a type or formatter function.
					/// </summary>
					/// <returns>the current value of the bound target</returns>
					public extern virtual object getExternalValue();

					/// <summary>
					/// Returns the formatter function
					/// </summary>
					/// <returns>the formatter function</returns>
					public extern virtual object getFormatter();

					/// <summary>
					/// Returns the related JavaScript primitive value of the bound target which is parsed by the {@link sap.ui.model.SimpleType#getModelFormat model format} of this binding's type. If this binding doesn't have a type, the original value which is stored in the model is returned.
					/// 
					/// This method will be used when it's included in a {@link sap.ui.model.CompositeBinding CompositeBinding} and the CompositeBinding needs to have the related JavaScript primitive values for its type or formatter.
					/// </summary>
					/// <returns>the value which is parsed by the model format of the bound target or the original value in case of no type.</returns>
					public extern virtual object getInternalValue();

					/// <summary>
					/// Returns a metadata object for class sap.ui.model.PropertyBinding.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					[Name("getMetadata")]
					public extern static sap.ui.@base.Metadata getMetadataStatic();

					/// <summary>
					/// Returns the type if any for the binding.
					/// </summary>
					/// <returns>the binding type</returns>
					public extern virtual sap.ui.model.Type getType();

					/// <summary>
					/// Returns the current value of the bound target
					/// </summary>
					/// <returns>the current value of the bound target</returns>
					public extern virtual object getValue();

					/// <summary>
					/// Resumes the binding update. Change events will be fired again.
					/// 
					/// When the binding is resumed and the control value was changed in the meantime, the control value will be set to the current value from the model and a change event will be fired.
					/// </summary>
					public extern override void resume();

					/// <summary>
					/// Sets the binding mode
					/// </summary>
					/// <param name="sBindingMode">the binding mode</param>
					public extern virtual void setBindingMode(sap.ui.model.BindingMode sBindingMode);

					/// <summary>
					/// Sets the value for this binding. The value is parsed and validated against its type and then set to the binding. A model implementation should check if the current default binding mode permits setting the binding value and if so set the new value also in the model.
					/// </summary>
					/// <param name="oValue">the value to set for this binding</param>
					public extern virtual void setExternalValue(object oValue);

					/// <summary>
					/// Sets the optional formatter function for the binding.
					/// </summary>
					/// <param name="fnFormatter">the formatter function for the binding</param>
					public extern virtual void setFormatter(object fnFormatter);

					/// <summary>
					/// Sets the value for this binding with the related JavaScript primitive type. The value is formatted with the {@link sap.ui.model.SimpleType#getModelFormat model format} and validated against its type and then set to the model.
					/// </summary>
					/// <param name="oValue">the value to set for this binding</param>
					public extern virtual void setInternalValue(object oValue);

					/// <summary>
					/// Sets the optional type and internal type for the binding. The type and internal type are used to do the parsing/formatting correctly. The internal type is the property type of the element which the value is formatted to.
					/// </summary>
					/// <param name="oType">the type for the binding</param>
					/// <param name="sInternalType">the internal type of the element property which this binding is bound against.</param>
					public extern virtual void setType(sap.ui.model.Type oType, string sInternalType);

					/// <summary>
					/// Sets the value for this binding. A model implementation should check if the current default binding mode permits setting the binding value and if so set the new value also in the model.
					/// </summary>
					/// <param name="oValue">the value to set for this binding</param>
					public extern virtual void setValue(object oValue);

					#endregion

				}
			}
		}
	}
}
