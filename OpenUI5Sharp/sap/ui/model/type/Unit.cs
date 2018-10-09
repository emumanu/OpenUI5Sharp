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
				public static partial class type
				{
					/// <summary>
					/// This class represents the Unit composite type.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.model.type.Unit")]
					public partial class Unit : sap.ui.model.CompositeType
					{
						#region Typed Parameters

						/// <summary>
						/// Parameter to be used as Object Literal
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class UnitInfo
						{
							/// <summary>
							/// Smallest value allowed for this type
							/// </summary>
							public float minimum;

							/// <summary>
							/// Largest value allowed for this type
							/// </summary>
							public float maximum;

							/// <summary>
							/// Largest number of decimals allowed for this type
							/// </summary>
							public float decimals;

						}

						#endregion

						#region Constructor

						/// <summary>
						/// Constructor for a Unit type.
						/// </summary>
						/// <param name="oFormatOptions">Formatting options. For a list of all available options, see {@link sap.ui.core.format.NumberFormat#constructor NumberFormat}.</param>
						/// <param name="oConstraints">Value constraints</param>
						/// <param name="aDynamicFormatOptionNames">keys for dynamic format options which are used to map additional binding values, e.g. <code>["decimals"]</code></param>
						public extern Unit(sap.ui.model.TypeOptions oFormatOptions, sap.ui.model.type.Unit.UnitInfo oConstraints, object[] aDynamicFormatOptionNames);

						/// <summary>
						/// Constructor for a Unit type.
						/// </summary>
						/// <param name="oFormatOptions">Formatting options. For a list of all available options, see {@link sap.ui.core.format.NumberFormat#constructor NumberFormat}.</param>
						/// <param name="oConstraints">Value constraints</param>
						public extern Unit(sap.ui.model.TypeOptions oFormatOptions, sap.ui.model.type.Unit.UnitInfo oConstraints);

						/// <summary>
						/// Constructor for a Unit type.
						/// </summary>
						/// <param name="oFormatOptions">Formatting options. For a list of all available options, see {@link sap.ui.core.format.NumberFormat#constructor NumberFormat}.</param>
						public extern Unit(sap.ui.model.TypeOptions oFormatOptions);

						/// <summary>
						/// Constructor for a Unit type.
						/// </summary>
						public extern Unit();

						/// <summary>
						/// Constructor for a Unit type.
						/// </summary>
						/// <param name="oConstraints">Value constraints</param>
						/// <param name="aDynamicFormatOptionNames">keys for dynamic format options which are used to map additional binding values, e.g. <code>["decimals"]</code></param>
						public extern Unit(sap.ui.model.type.Unit.UnitInfo oConstraints, object[] aDynamicFormatOptionNames);

						/// <summary>
						/// Constructor for a Unit type.
						/// </summary>
						/// <param name="aDynamicFormatOptionNames">keys for dynamic format options which are used to map additional binding values, e.g. <code>["decimals"]</code></param>
						public extern Unit(object[] aDynamicFormatOptionNames);

						#endregion

						#region Methods

						/// <summary>
						/// Creates a new subclass of class sap.ui.model.type.Unit with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.CompositeType.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.model.type.Unit with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.CompositeType.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.model.type.Unit with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.CompositeType.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Format the given array containing amount and Unit code to an output value of type string. Other internal types than 'string' are not supported by the Unit type. If a source format has been defined for this type, the formatValue does also accept a string value as input, which will be parsed into an array using the source format. If aValues is not defined or null, null will be returned.
						/// </summary>
						/// <param name="vValue">the array of values or string value to be formatted. If an array is given, index 0 is the number value, and index 1 is the Unit code (CLDR or custom). Indices 2+ are the bound values for the dynamic format options.</param>
						/// <param name="sInternalType">the target type</param>
						/// <returns>the formatted output value</returns>
						public extern virtual object formatValue(Union<object[], string> vValue, string sInternalType);

						/// <summary>
						/// Returns a metadata object for class sap.ui.model.type.Unit.
						/// </summary>
						/// <returns>Metadata object describing this class</returns>
						public extern static sap.ui.@base.Metadata getMetadata();

						/// <summary>
						/// Parse a string value to an array containing amount and Unit. Parsing of other internal types than 'string' is not supported by the Unit type. In case a source format has been defined, after parsing the Unit is formatted using the source format and a string value is returned instead.
						/// </summary>
						/// <param name="vValue">the value to be parsed</param>
						/// <param name="sInternalType">the source type</param>
						/// <param name="aCurrentValues">the current values of all binding parts</param>
						/// <returns>the parse result array</returns>
						public extern virtual Union<object[], string> parseValue(object vValue, string sInternalType, object[] aCurrentValues);

						#endregion

					}
				}
			}
		}
	}
}
