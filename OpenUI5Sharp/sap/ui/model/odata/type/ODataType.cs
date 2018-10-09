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
				public static partial class odata
				{
					public static partial class type
					{
						/// <summary>
						/// This class is an abstract base class for all OData primitive types (see {@link http://docs.oasis-open.org/odata/odata/v4.0/errata02/os/complete/part3-csdl/odata-v4.0-errata02-os-part3-csdl-complete.html#_The_edm:Documentation_Element OData V4 Edm Types} and {@link http://www.odata.org/documentation/odata-version-2-0/overview#AbstractTypeSystem OData V2 Edm Types}). All subtypes implement the interface of {@link sap.ui.model.SimpleType}. That means they implement next to the constructor: <ul> <li>{@link sap.ui.model.SimpleType#getName getName}</li> <li>{@link sap.ui.model.SimpleType#formatValue formatValue}</li> <li>{@link sap.ui.model.SimpleType#parseValue parseValue}</li> <li>{@link sap.ui.model.SimpleType#validateValue validateValue}</li> </ul>
						/// 
						/// All ODataTypes are immutable. All format options and constraints are given to the constructor, they cannot be modified later.
						/// 
						/// All ODataTypes use a locale-specific message when throwing an error caused by invalid user input (e.g. if {@link sap.ui.model.odata.type.Double#parseValue Double.parseValue} cannot parse the given value to a number, or if any type's {@link #validateValue validateValue} gets a <code>null</code>, but the constraint <code>nullable</code> is <code>false</code>).
						/// </summary>
						[External]
						[Namespace(false)]
						[Name("sap.ui.model.odata.type.ODataType")]
						public abstract partial class ODataType : sap.ui.model.SimpleType
						{
							#region Constructor

							/// <summary>
							/// Constructor for a new <code>ODataType</code>.
							/// </summary>
							/// <param name="oFormatOptions">type-specific format options; see subtypes</param>
							/// <param name="oConstraints">type-specific constraints (e.g. <code>oConstraints.nullable</code>), see subtypes</param>
							public extern ODataType(object oFormatOptions, object oConstraints);

							/// <summary>
							/// Constructor for a new <code>ODataType</code>.
							/// </summary>
							/// <param name="oFormatOptions">type-specific format options; see subtypes</param>
							public extern ODataType(object oFormatOptions);

							/// <summary>
							/// Constructor for a new <code>ODataType</code>.
							/// </summary>
							public extern ODataType();

							#endregion

							#region Methods

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.type.ODataType with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.SimpleType.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <param name="oClassInfo">Object literal with information about the class</param>
							/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.type.ODataType with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.SimpleType.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <param name="oClassInfo">Object literal with information about the class</param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName, object oClassInfo);

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.type.ODataType with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.SimpleType.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName);

							/// <returns>this</returns>
							public extern virtual object getInterface();

							/// <summary>
							/// Returns a metadata object for class sap.ui.model.odata.type.ODataType.
							/// </summary>
							/// <returns>Metadata object describing this class</returns>
							public extern static sap.ui.@base.Metadata getMetadata();

							#endregion

						}
					}
				}
			}
		}
	}
}
