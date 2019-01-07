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
					/// This class represents integer simple types.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.model.type.Integer")]
					public partial class Integer : sap.ui.model.SimpleType
					{
						#region Typed Parameters

						/// <summary>
						/// Parameter to be used as Object Literal
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class IntegerInfo
						{
							/// <summary>
							/// Smallest value allowed for this type
							/// </summary>
							public int minimum;

							/// <summary>
							/// Largest value allowed for this type
							/// </summary>
							public int maximum;

						}

						#endregion

						#region Constructor

						/// <summary>
						/// Constructor for an Integer type.
						/// </summary>
						/// <param name="oFormatOptions">Formatting options. For a list of all available options, see {@link sap.ui.core.format.NumberFormat#constructor NumberFormat}.</param>
						/// <param name="oConstraints">Value constraints</param>
						public extern Integer(sap.ui.model.FormatOptions oFormatOptions, sap.ui.model.type.Integer.IntegerInfo oConstraints);

						/// <summary>
						/// Constructor for an Integer type.
						/// </summary>
						/// <param name="oFormatOptions">Formatting options. For a list of all available options, see {@link sap.ui.core.format.NumberFormat#constructor NumberFormat}.</param>
						public extern Integer(sap.ui.model.FormatOptions oFormatOptions);

						/// <summary>
						/// Constructor for an Integer type.
						/// </summary>
						public extern Integer();

						#endregion

						#region Methods

						/// <summary>
						/// Creates a new subclass of class sap.ui.model.type.Integer with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.SimpleType.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.model.type.Integer with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.SimpleType.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.model.type.Integer with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.SimpleType.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns a metadata object for class sap.ui.model.type.Integer.
						/// </summary>
						/// <returns>Metadata object describing this class</returns>
						[Name("getMetadata")]
						public extern static sap.ui.@base.Metadata getMetadataStatic();

						#endregion

					}
				}
			}
		}
	}
}
