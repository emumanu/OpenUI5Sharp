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
					/// <summary>
					/// Model and related classes like bindings for OData V4.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.model.odata.v4")]
					public static partial class v4
					{
						#region Typed Parameters

						/// <summary>
						/// Parameter to be used as Object Literal
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class ODataBindingChangeInfo
						{
							/// <summary>
							/// The reason for the 'change' event: {@link sap.ui.model.ChangeReason.Change} when the binding is initialized, {@link sap.ui.model.ChangeReason.Refresh} when the binding is refreshed, and {@link sap.ui.model.ChangeReason.Context} when the parent context is changed
							/// </summary>
							public sap.ui.model.ChangeReason reason;

						}

						/// <summary>
						/// Parameter to be used as Object Literal
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class ODataBindingDataReceivedInfo
						{
							/// <summary>
							/// An empty data object if a back-end request succeeds
							/// </summary>
							public object data;

							/// <summary>
							/// The error object if a back-end request failed. If there are multiple failed back-end requests, the error of the first one is provided.
							/// </summary>
							public Error error;

						}

						#endregion

						#region Delegates

						public delegate void ODataBindingChangeDelegate(sap.ui.@base.Event<sap.ui.model.odata.v4.ODataBindingChangeInfo> oEvent, object oData);

						public delegate void ODataBindingDataReceivedDelegate(sap.ui.@base.Event<sap.ui.model.odata.v4.ODataBindingDataReceivedInfo> oEvent, object oData);

						#endregion

						/// <summary>
						/// Modes to control the use of batch requests for a group ID.
						/// </summary>
						[External]
						[Namespace(false)]
						[Name("sap.ui.model.odata.v4.SubmitMode")]
						public enum SubmitMode
						{
							/// <summary>
							/// Requests associated with the group ID are sent in a batch request via {@link sap.ui.model.odata.v4.ODataModel#submitBatch}.
							/// </summary>
							API,
							/// <summary>
							/// Requests associated with the group ID are sent in a batch request which is triggered automatically before rendering.
							/// </summary>
							Auto,
							/// <summary>
							/// Requests associated with the group ID are sent directly without batch.
							/// </summary>
							Direct,
						}
						/// <summary>
						/// Specifies the value list type of a property.
						/// </summary>
						[External]
						[Namespace(false)]
						[Name("sap.ui.model.odata.v4.ValueListType")]
						public enum ValueListType
						{
							/// <summary>
							/// There is one enumeration of fixed values.
							/// </summary>
							Fixed,
							/// <summary>
							/// There is no value list.
							/// </summary>
							None,
							/// <summary>
							/// There is a dynamic value list with multiple queries including selection criteria.
							/// </summary>
							Standard,
						}
					}
				}
			}
		}
	}
}
