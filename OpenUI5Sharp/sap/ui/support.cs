using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public static partial class sap
	{
		public static partial class ui
		{
			/// <summary>
			/// UI5 library: sap.ui.support. A library for the Support Assistant tool. <h3>Overview</h3> The library provides the Support Assistant tool. It enables application developers to check whether their applications are built according to the best practices for building SAPUI5 apps. The tool uses a set of pre-defined rules to check all aspects of an application.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.ui.support")]
			public static partial class support
			{
				#region Fields

				public static object CoreFacade;

				/// <summary>
				/// <h3>Overview</h3> These channels enable the user to hook to the {@link sap.ui.support.WindowCommunicationBus } <h3>Usage</h3> These channels are used for communication with Main.
				/// </summary>
				public static object WCBChannels;

				#endregion

				/// <summary>
				/// Defines severity types.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.support.Severity")]
				public enum Severity
				{
					/// <summary>
					/// High issue severity.
					/// </summary>
					High,
					/// <summary>
					/// Low issue severity.
					/// </summary>
					Low,
					/// <summary>
					/// Medium issue severity.
					/// </summary>
					Medium,
				}
				/// <summary>
				/// Defines the Audiences.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.support.Audiences")]
				public enum Audiences
				{
					/// <summary>
					/// Audience just on Application level.
					/// </summary>
					Application,
					/// <summary>
					/// Audience just on Control level.
					/// </summary>
					Control,
					/// <summary>
					/// Audience just on Internal level.
					/// </summary>
					Internal,
				}
				/// <summary>
				/// Issue Categories.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.support.Categories")]
				public enum Categories
				{
					/// <summary>
					/// Accessibility issue category.
					/// </summary>
					Accessibility,
					/// <summary>
					/// Binding issue category.
					/// </summary>
					Bindings,
					/// <summary>
					/// Consistency issue category.
					/// </summary>
					Consistency,
					/// <summary>
					/// DataModel issue category.
					/// </summary>
					DataModel,
					/// <summary>
					/// Fiori Guidelines issue category.
					/// </summary>
					FioriGuidelines,
					/// <summary>
					/// Functionality issue category.
					/// </summary>
					Functionality,
					/// <summary>
					/// Memory issue category.
					/// </summary>
					Memory,
					/// <summary>
					/// Modularization issue category.
					/// </summary>
					Modularization,
					/// <summary>
					/// Other issue category.
					/// </summary>
					Other,
					/// <summary>
					/// Performance issue category.
					/// </summary>
					Performance,
					/// <summary>
					/// Usability issue category.
					/// </summary>
					Usability,
					/// <summary>
					/// Usage issue category.
					/// </summary>
					Usage,
				}
				/// <summary>
				/// Analysis history formats.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.support.HistoryFormats")]
				public enum HistoryFormats
				{
					/// <summary>
					/// ABAP history format.
					/// </summary>
					Abap,
					/// <summary>
					/// String history format.
					/// </summary>
					String,
				}
			}
		}
	}
}
