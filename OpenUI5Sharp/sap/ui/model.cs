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
			/// <summary>
			/// The SAPUI5 Data Binding API.
			/// 
			/// The default binding mode for model implementations (if not implemented otherwise) is two way and the supported binding modes by the model are one way, two way and one time. The default binding mode can be changed by the application for each model instance. A model implementation should specify its supported binding modes and set the default binding mode accordingly (e.g. if the model supports only one way binding the default binding mode should also be set to one way).
			/// 
			/// The default size limit for models is 100. The size limit determines the number of entries used for the list bindings.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.ui.model")]
			public static partial class model
			{
				#region Typed Parameters

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class FormatOptions
				{
					/// <summary>
					/// Additional set of format options to be used if the property in the model is not of type <code>string</code> and needs formatting as well. If an empty object is given, the grouping is disabled and a dot is used as decimal separator.
					/// </summary>
					public object source;

				}

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class TypeInfo
				{
					/// <summary>
					/// Smallest value allowed for this type
					/// </summary>
					public float minimum;

					/// <summary>
					/// Largest value allowed for this type
					/// </summary>
					public float maximum;

				}

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class TypeIntervalInfo
				{
					/// <summary>
					/// Smallest value allowed for this type. Values for constraints must use the same type as configured via <code>oFormatOptions.source</code>.
					/// </summary>
					public Union<DateTime, string> minimum;

					/// <summary>
					/// Largest value allowed for this type. Values for constraints must use the same type as configured via <code>oFormatOptions.source</code>.
					/// </summary>
					public Union<DateTime, string> maximum;

				}

				#endregion

				/// <summary>
				/// Types of Filters.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.model.FilterType")]
				public enum FilterType
				{
					/// <summary>
					/// Filters which are changed by the application
					/// </summary>
					Application,
					/// <summary>
					/// Filters which are set by the different controls
					/// </summary>
					Control,
				}
				/// <summary>
				/// Binding type definitions.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.model.BindingMode")]
				public enum BindingMode
				{
					/// <summary>
					/// BindingMode default means that the binding mode of the model is used
					/// </summary>
					Default,
					/// <summary>
					/// BindingMode one time means value is only read from the model once
					/// </summary>
					OneTime,
					/// <summary>
					/// BindingMode one way means from model to view
					/// </summary>
					OneWay,
					/// <summary>
					/// BindingMode two way means from model to view and vice versa
					/// </summary>
					TwoWay,
				}
				/// <summary>
				/// Change Reason for Model/ListBinding/TreeBinding.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.model.ChangeReason")]
				public enum ChangeReason
				{
					/// <summary>
					/// A context was added to a binding.
					/// </summary>
					Add,
					/// <summary>
					/// Binding changes a model property value
					/// </summary>
					Binding,
					/// <summary>
					/// The list has changed
					/// </summary>
					Change,
					/// <summary>
					/// The tree node was collapsed
					/// </summary>
					Collapse,
					/// <summary>
					/// The list context has changed
					/// </summary>
					Context,
					/// <summary>
					/// The tree node was expanded
					/// </summary>
					Expand,
					/// <summary>
					/// The List was filtered
					/// </summary>
					Filter,
					/// <summary>
					/// The list was refreshed
					/// </summary>
					Refresh,
					Remove,
					/// <summary>
					/// The list was sorted
					/// </summary>
					Sort,
				}
				/// <summary>
				/// Operators for the Filter.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.model.FilterOperator")]
				public enum FilterOperator
				{
					/// <summary>
					/// Used to filter a list based on filter criteria that are defined in a nested filter for dependent subitems. <code>All</code> returns a list of those items for which <b>all</b> dependent subitems match the filter criteria of the nested filter. For example, a list of customers can be filtered by filter criteria that are applied to the list of orders the customer placed in the past. The filter returns a list of those customers that <b>always</b> ordered a specific product.
					/// 
					/// This filter operator is only supported in OData V4 models.
					/// </summary>
					All,
					/// <summary>
					/// Used to filter a list based on filter criteria that are defined in a nested filter for dependent subitems. <code>Any</code> returns a list of those items for which <b>at least one</b> dependent subitem matches the filter criteria of the nested filter. For example, a list of customers can be filtered by filter criteria that are applied to the list of orders the customer placed in the past. The filter returns a list of those customers that <b>at least once</b> ordered a specific product.
					/// 
					/// This filter operator is only supported in OData V4 models.
					/// </summary>
					Any,
					/// <summary>
					/// FilterOperator between
					/// 
					/// Used to filter all entries between the given boundaries. The filter result contains the boundaries, but no entries before or further. The order of the entries in the filter results is based on their occurence in the input list.
					/// 
					/// <b>Note, when used on strings:</b> The String comparison is based on lexicographical ordering. Characters are ranked in their alphabetical order. Words with the same preceding substring are ordered based on their length e.g. "Chris" comes before "Christian".
					/// 
					/// The filtering includes the right boundary, but no strings further in the lexicographical ordering. e.g. between "A" and "C" includes the string "C", but not "Chris".
					/// </summary>
					BT,
					/// <summary>
					/// FilterOperator contains
					/// </summary>
					Contains,
					/// <summary>
					/// FilterOperator ends with
					/// </summary>
					EndsWith,
					/// <summary>
					/// FilterOperator equals
					/// </summary>
					EQ,
					/// <summary>
					/// FilterOperator greater or equals
					/// </summary>
					GE,
					/// <summary>
					/// FilterOperator greater than
					/// </summary>
					GT,
					/// <summary>
					/// FilterOperator less or equals
					/// </summary>
					LE,
					/// <summary>
					/// FilterOperator less than
					/// </summary>
					LT,
					/// <summary>
					/// FilterOperator "Not Between"
					/// 
					/// Used to filter all entries, which are not between the given boundaries. The filter result does not contains the boundaries, but only entries outside of the boundaries. The order of the entries in the filter results is based on their occurence in the input list.
					/// 
					/// <b>Note, when used on strings:</b> The String comparison is based on lexicographical ordering. Characters are ranked in their alphabetical order. Words with the same preceding substring are ordered based on their length e.g. "Chris" comes before "Christian".
					/// </summary>
					NB,
					/// <summary>
					/// FilterOperator not equals
					/// </summary>
					NE,
					/// <summary>
					/// FilterOperator not contains
					/// </summary>
					NotContains,
					/// <summary>
					/// FilterOperator not ends with
					/// </summary>
					NotEndsWith,
					/// <summary>
					/// FilterOperator not starts with
					/// </summary>
					NotStartsWith,
					/// <summary>
					/// FilterOperator starts with
					/// </summary>
					StartsWith,
				}
				/// <summary>
				/// Different modes for setting the auto expand mode on tree or analytical bindings.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.model.TreeAutoExpandMode")]
				public enum TreeAutoExpandMode
				{
					/// <summary>
					/// If supported by a backend provider with analytical capabilities, the requests needed for an automatic node expansion are bundled.
					/// </summary>
					Bundled,
					/// <summary>
					/// Tree nodes will be expanded in sequence, level by level (Single requests are sent).
					/// </summary>
					Sequential,
				}
			}
		}
	}
}
