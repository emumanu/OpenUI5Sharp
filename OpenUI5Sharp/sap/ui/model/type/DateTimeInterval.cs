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
				public static partial class type
				{
					/// <summary>
					/// This class represents the DateTime interval composite type.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.model.type.DateTimeInterval")]
					public partial class DateTimeInterval : sap.ui.model.type.DateInterval
					{
						#region Constructor

						/// <summary>
						/// Constructor for a DateTime interval type.
						/// </summary>
						/// <param name="oFormatOptions">Formatting options. For a list of all available options, see {@link sap.ui.core.format.DateFormat.getDateTimeInstance DateFormat}.</param>
						/// <param name="oConstraints">Value constraints</param>
						public extern DateTimeInterval(sap.ui.model.FormatOptions oFormatOptions, sap.ui.model.TypeIntervalInfo oConstraints);

						/// <summary>
						/// Constructor for a DateTime interval type.
						/// </summary>
						/// <param name="oFormatOptions">Formatting options. For a list of all available options, see {@link sap.ui.core.format.DateFormat.getDateTimeInstance DateFormat}.</param>
						public extern DateTimeInterval(sap.ui.model.FormatOptions oFormatOptions);

						/// <summary>
						/// Constructor for a DateTime interval type.
						/// </summary>
						public extern DateTimeInterval();

						#endregion

						#region Methods

						/// <summary>
						/// Creates a new subclass of class sap.ui.model.type.DateTimeInterval with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.type.DateInterval.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.model.type.DateTimeInterval with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.type.DateInterval.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.model.type.DateTimeInterval with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.type.DateInterval.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns a metadata object for class sap.ui.model.type.DateTimeInterval.
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
