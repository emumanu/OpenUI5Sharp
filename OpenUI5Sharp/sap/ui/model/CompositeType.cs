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
				/// This is an abstract base class for composite types. Composite types have multiple input values and know how to merge/split them upon formatting/parsing the value. Typical use case a currency or amount values.
				/// 
				/// Subclasses of CompositeTypes can define boolean properties in the constructor: - bUseRawValues: the format and parse method will handle raw model values, types of embedded bindings are ignored - bParseWithValues: the parse method call will include the current binding values as a third parameter
				/// </summary>
				[External]
				[Namespace(false)]
				public abstract partial class CompositeType : sap.ui.model.SimpleType
				{
					#region Constructor

					/// <summary>
					/// Constructor for a new CompositeType.
					/// </summary>
					/// <param name="oFormatOptions">options as provided by concrete subclasses</param>
					/// <param name="oConstraints">constraints as supported by concrete subclasses</param>
					public extern CompositeType(object oFormatOptions, object oConstraints);

					/// <summary>
					/// Constructor for a new CompositeType.
					/// </summary>
					/// <param name="oFormatOptions">options as provided by concrete subclasses</param>
					public extern CompositeType(object oFormatOptions);

					/// <summary>
					/// Constructor for a new CompositeType.
					/// </summary>
					public extern CompositeType();

					#endregion

					#region Methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.model.CompositeType with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.SimpleType.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.model.CompositeType with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.SimpleType.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.model.CompositeType with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.SimpleType.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Format the given set of values in model representation to an output value in the given internal type. This happens according to the format options, if target type is 'string'. If aValues is not defined or null, null will be returned.
					/// </summary>
					/// <param name="aValues">the values to be formatted</param>
					/// <param name="sInternalType">the target type</param>
					/// <returns>the formatted output value</returns>
					public extern virtual object formatValue(object[] aValues, string sInternalType);

					/// <summary>
					/// Returns a metadata object for class sap.ui.model.CompositeType.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					/// <summary>
					/// Parse a value of an internal type to the expected set of values of the model type.
					/// </summary>
					/// <param name="oValue">the value to be parsed</param>
					/// <param name="sInternalType">the source type</param>
					/// <param name="aCurrentValues">the current values of all binding parts</param>
					/// <returns>the parse result array</returns>
					public extern virtual object[] parseValue(object oValue, string sInternalType, object[] aCurrentValues);

					/// <summary>
					/// Validate whether a given value in model representation is valid and meets the defined constraints (if any).
					/// </summary>
					/// <param name="aValues">the set of values to be validated</param>
					public extern virtual void validateValue(object[] aValues);

					#endregion

				}
			}
		}
	}
}
