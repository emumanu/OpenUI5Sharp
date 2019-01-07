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
						/// This class represents the OData V2 primitive type <a href="http://www.odata.org/documentation/odata-version-2-0/overview#AbstractTypeSystem"> <code>Edm.DateTime</code></a>.
						/// 
						/// If you want to display a date and a time, prefer {@link sap.ui.model.odata.type.DateTimeOffset}, specifically designed for this purpose.
						/// 
						/// Use <code>DateTime</code> with the SAP-specific annotation <code>display-format=Date</code> (resp. the constraint <code>displayFormat: "Date"</code>) to display only a date.
						/// 
						/// In {@link sap.ui.model.odata.v2.ODataModel} this type is represented as a <code>Date</code>. With the constraint <code>displayFormat: "Date"</code>, the time zone is UTC and the time part is ignored, otherwise it is a date/time value in local time.
						/// </summary>
						[External]
						[Namespace(false)]
						[Name("sap.ui.model.odata.type.DateTime")]
						public partial class DateTime : sap.ui.model.odata.type.DateTimeBase
						{
							#region Typed Parameters

							/// <summary>
							/// Parameter to be used as Object Literal
							/// </summary>
							[External]
							[ObjectLiteral]
							public partial class DateTimeInfo
							{
								/// <summary>
								/// if <code>true</code>, the value <code>null</code> is accepted
								/// </summary>
								public Union<bool, string> nullable;

								/// <summary>
								/// may be "Date", in this case only the date part is used, the time part is always 00:00:00 and the time zone is UTC to avoid time-zone-related problems
								/// </summary>
								public string displayFormat;

							}

							#endregion

							#region Constructor

							/// <summary>
							/// Constructor for a primitive type <code>Edm.DateTime</code>.
							/// </summary>
							/// <param name="oFormatOptions">format options as defined in {@link sap.ui.core.format.DateFormat}</param>
							/// <param name="oConstraints">constraints; {@link sap.ui.model.odata.type.DateTimeBase#validateValue validateValue} throws an error if any constraint is violated</param>
							public extern DateTime(sap.ui.core.format.DateFormat.FormatOptions oFormatOptions, sap.ui.model.odata.type.DateTime.DateTimeInfo oConstraints);

							/// <summary>
							/// Constructor for a primitive type <code>Edm.DateTime</code>.
							/// </summary>
							/// <param name="oFormatOptions">format options as defined in {@link sap.ui.core.format.DateFormat}</param>
							public extern DateTime(sap.ui.core.format.DateFormat.FormatOptions oFormatOptions);

							/// <summary>
							/// Constructor for a primitive type <code>Edm.DateTime</code>.
							/// </summary>
							public extern DateTime();

							/// <summary>
							/// Constructor for a primitive type <code>Edm.DateTime</code>.
							/// </summary>
							/// <param name="oConstraints">constraints; {@link sap.ui.model.odata.type.DateTimeBase#validateValue validateValue} throws an error if any constraint is violated</param>
							public extern DateTime(sap.ui.model.odata.type.DateTime.DateTimeInfo oConstraints);

							#endregion

							#region Methods

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.type.DateTime with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.odata.type.DateTimeBase.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <param name="oClassInfo">Object literal with information about the class</param>
							/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.type.DateTime with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.odata.type.DateTimeBase.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <param name="oClassInfo">Object literal with information about the class</param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName, object oClassInfo);

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.type.DateTime with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.odata.type.DateTimeBase.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName);

							/// <summary>
							/// Returns a metadata object for class sap.ui.model.odata.type.DateTime.
							/// </summary>
							/// <returns>Metadata object describing this class</returns>
							[Name("getMetadata")]
							public extern static sap.ui.@base.Metadata getMetadataStatic();

							/// <summary>
							/// Returns the type's name.
							/// </summary>
							/// <returns>the type's name</returns>
							public extern override string getName();

							#endregion

						}
					}
				}
			}
		}
	}
}
