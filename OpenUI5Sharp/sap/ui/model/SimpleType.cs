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
				/// This is an abstract base class for simple types.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.model.SimpleType")]
				public abstract partial class SimpleType : sap.ui.model.Type
				{
					#region Constructor

					/// <summary>
					/// Constructor for a new SimpleType.
					/// </summary>
					/// <param name="oFormatOptions">options as provided by concrete subclasses</param>
					/// <param name="oConstraints">constraints as supported by concrete subclasses</param>
					public extern SimpleType(object oFormatOptions, object oConstraints);

					/// <summary>
					/// Constructor for a new SimpleType.
					/// </summary>
					/// <param name="oFormatOptions">options as provided by concrete subclasses</param>
					public extern SimpleType(object oFormatOptions);

					/// <summary>
					/// Constructor for a new SimpleType.
					/// </summary>
					public extern SimpleType();

					#endregion

					#region Methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.model.SimpleType with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.Type.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.model.SimpleType with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.Type.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.model.SimpleType with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.Type.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Format the given value in model representation to an output value in the given internal type. This happens according to the format options, if target type is 'string'. If oValue is not defined or null, null will be returned.
					/// </summary>
					/// <param name="oValue">the value to be formatted</param>
					/// <param name="sInternalType">the target type</param>
					/// <returns>the formatted output value</returns>
					public extern virtual object formatValue(object oValue, string sInternalType);

					/// <summary>
					/// Returns a metadata object for class sap.ui.model.SimpleType.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					[Name("getMetadata")]
					public extern static sap.ui.@base.Metadata getMetadataStatic();

					/// <summary>
					/// Returns an object which has <code>format</code> and <code>parse</code> method. These two methods are used for converting between the raw value which is stored in the model and the related primitive type in JavaScript.
					/// 
					/// If a instance of {@link sap.ui.core.format.DateFormat#constructor DateFormat} or {@link sap.ui.core.format.NumberFormat#constructor NumberFormat} fits the needs, they could also be used as return value.
					/// 
					/// The default implementation of the <code>format</code> and <code>parse</code> method simply returns the given parameter. The subclass of {@link sap.ui.model.SimpleType#constructor SimpleType} should override this method if the raw value isn't already a JavaScript primitive type. The overwritten method must return an object which has the <code>format</code> and <code>parse</code> method implemented.
					/// 
					/// For example<br> If the type is related to a JavaScript Date object, but the raw value isn't, this method should return an instance of {@link sap.ui.core.format.DateFormat#constructor DateFormat}, which is able to convert between the raw value and a JavaScript Date object.
					/// </summary>
					/// <returns>The format which converts between the raw value from the model and the related JavaScript primitive type</returns>
					public extern virtual object getModelFormat();

					/// <summary>
					/// Parse a value of an internal type to the expected value of the model type.
					/// </summary>
					/// <param name="oValue">the value to be parsed</param>
					/// <param name="sInternalType">the source type</param>
					/// <returns>the parse result</returns>
					public extern virtual object parseValue(object oValue, string sInternalType);

					/// <summary>
					/// Validate whether a given value in model representation is valid and meets the defined constraints (if any).
					/// </summary>
					/// <param name="oValue">the value to be validated</param>
					public extern virtual void validateValue(object oValue);

					#endregion

				}
			}
		}
	}
}
