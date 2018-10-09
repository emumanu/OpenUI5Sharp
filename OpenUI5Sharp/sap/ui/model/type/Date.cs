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
					/// This class represents date simple types.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.model.type.Date")]
					public partial class Date : sap.ui.model.SimpleType
					{
						#region Typed Parameters

						/// <summary>
						/// Parameter to be used as Object Literal
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class DateInfo
						{
							/// <summary>
							/// Smallest value allowed for this type. Values for constraints must use the same type as configured via <code>oFormatOptions.source</code>.
							/// </summary>
							public Union<System.DateTime, string> minimum;

							/// <summary>
							/// Largest value allowed for this type. Values for constraints must use the same type as configured via <code>oFormatOptions.source</code>.
							/// </summary>
							public Union<System.DateTime, string> maximum;

						}

						#endregion

						#region Constructor

						/// <summary>
						/// Constructor for a Date type.
						/// </summary>
						/// <param name="oFormatOptions">Formatting options. For a list of all available options, see {@link sap.ui.core.format.DateFormat.getDateInstance DateFormat}.</param>
						/// <param name="oConstraints">Value constraints</param>
						public extern Date(sap.ui.model.TypeOptions oFormatOptions, sap.ui.model.type.Date.DateInfo oConstraints);

						/// <summary>
						/// Constructor for a Date type.
						/// </summary>
						/// <param name="oFormatOptions">Formatting options. For a list of all available options, see {@link sap.ui.core.format.DateFormat.getDateInstance DateFormat}.</param>
						public extern Date(sap.ui.model.TypeOptions oFormatOptions);

						/// <summary>
						/// Constructor for a Date type.
						/// </summary>
						public extern Date();

						#endregion

						#region Methods

						/// <summary>
						/// Creates a new subclass of class sap.ui.model.type.Date with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.SimpleType.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.model.type.Date with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.SimpleType.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.model.type.Date with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.SimpleType.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns a metadata object for class sap.ui.model.type.Date.
						/// </summary>
						/// <returns>Metadata object describing this class</returns>
						public extern static sap.ui.@base.Metadata getMetadata();

						public extern virtual void getOutputPattern();

						#endregion

					}
				}
			}
		}
	}
}
