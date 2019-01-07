﻿using System;
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
						/// This class represents the OData primitive type <a href="http://www.odata.org/documentation/odata-version-2-0/overview#AbstractTypeSystem"> <code>Edm.Byte</code></a>.
						/// 
						/// In both {@link sap.ui.model.odata.v2.ODataModel} and {@link sap.ui.model.odata.v4.ODataModel} this type is represented as a <code>number</code>.
						/// </summary>
						[External]
						[Namespace(false)]
						[Name("sap.ui.model.odata.type.Byte")]
						public partial class Byte : sap.ui.model.odata.type.Int
						{
							#region Constructor

							/// <summary>
							/// Constructor for a primitive type <code>Edm.Byte</code>.
							/// </summary>
							/// <param name="oFormatOptions">format options as defined in {@link sap.ui.core.format.NumberFormat}</param>
							/// <param name="oConstraints">constraints; {@link sap.ui.model.odata.type.Int#validateValue validateValue} throws an error if any constraint is violated</param>
							public extern Byte(object oFormatOptions, sap.ui.model.odata.type.ConstraintsInfo oConstraints);

							/// <summary>
							/// Constructor for a primitive type <code>Edm.Byte</code>.
							/// </summary>
							/// <param name="oFormatOptions">format options as defined in {@link sap.ui.core.format.NumberFormat}</param>
							public extern Byte(object oFormatOptions);

							/// <summary>
							/// Constructor for a primitive type <code>Edm.Byte</code>.
							/// </summary>
							public extern Byte();

							#endregion

							#region Methods

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.type.Byte with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.odata.type.Int.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <param name="oClassInfo">Object literal with information about the class</param>
							/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.type.Byte with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.odata.type.Int.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <param name="oClassInfo">Object literal with information about the class</param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName, object oClassInfo);

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.type.Byte with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.odata.type.Int.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName);

							/// <summary>
							/// Returns a metadata object for class sap.ui.model.odata.type.Byte.
							/// </summary>
							/// <returns>Metadata object describing this class</returns>
							[Name("getMetadata")]
							public extern static sap.ui.@base.Metadata getMetadataStatic();

							/// <summary>
							/// Returns the type's name.
							/// </summary>
							/// <returns>the type's name</returns>
							public extern override string getName();

							/// <summary>
							/// Returns the type's supported range as object with properties <code>minimum</code> and <code>maximum</code>.
							/// </summary>
							/// <returns>the range</returns>
							public extern virtual object getRange();

							#endregion

						}
					}
				}
			}
		}
	}
}
