using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace OpenUI5Sharp
{
	public partial class sap
	{
		public static partial class ui
		{
			public static partial class model
			{
				/// <summary>
				/// Filter for the list binding.
				/// </summary>
				[External]
				[Namespace(false)]
				public partial class Filter : sap.ui.@base.Object
				{
					#region Typed Parameters

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class FilterInfo
					{
						/// <summary>
						/// Binding path for this filter
						/// </summary>
						public string path;

						/// <summary>
						/// Function which is used to filter the items and which should return a Boolean value to indicate whether the current item passes the filter
						/// </summary>
						public object test;

						/// <summary>
						/// Function which is used to compare two values, this is used for processing of equal, less than and greater than operators
						/// </summary>
						public object comparator;

						/// <summary>
						/// Operator used for the filter
						/// </summary>
						public sap.ui.model.FilterOperator @operator;

						/// <summary>
						/// First value to use with the given filter operator
						/// </summary>
						public object value1;

						/// <summary>
						/// Second value to use with the filter operator (only for some operators)
						/// </summary>
						public object value2;

						/// <summary>
						/// The variable used in lambda operators (<code>Any</code> and <code>All</code>)
						/// </summary>
						public string variable;

						/// <summary>
						/// A <code>Filter</code> instance which will be used as the condition for the lambda operator
						/// </summary>
						public sap.ui.model.Filter condition;

						/// <summary>
						/// Array of filters on which logical conjunction is applied
						/// </summary>
						public sap.ui.model.Filter[] filters;

						/// <summary>
						/// Indicates whether an "AND" logical conjunction is applied on the filters. If it's set to <code>false</code>, an "OR" conjunction is applied
						/// </summary>
						public bool and;

						/// <summary>
						/// Indicates whether a string value should be compared case sensitive or not.
						/// </summary>
						public bool caseSensitive;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for Filter.
					/// 
					/// You either pass a single object literal with the filter parameters or use the individual constructor arguments. No matter which variant is used, only certain combinations of parameters are supported (the following list uses the names from the object literal): <ul> <li>A <code>path</code>, <code>operator</code> and one or two values (<code>value1</code>, <code>value2</code>), depending on the operator</li> <li>A <code>path</code> and a custom filter function <code>test</code></li> <li>An array of other filters named <code>filters</code> and a Boolean flag <code>and</code> that specifies whether to combine the filters with an AND (<code>true</code>) or an OR (<code>false</code>) operator.</li> </ul> An error will be logged to the console if an invalid combination of parameters is provided. Please note that a model implementation may not support a custom filter function, e.g. if the model does not perform client side filtering. It also depends on the model implementation if the filtering is case sensitive or not. See particular model documentation for details The filter operators <code>Any</code> and <code>All</code> are only supported in V4 OData models. When creating a filter instance with these filter operators, the argument <code>variable</code> only accepts a string identifier and <code>condition</code> needs to be another filter instance.
					/// </summary>
					/// <param name="vFilterInfo">Filter info object or a path or an array of filters</param>
					/// <param name="vOperator">Either a filter operator or a custom filter function or a Boolean flag that defines how to combine multiple filters</param>
					/// <param name="vValue1">First value to use with the given filter operator</param>
					/// <param name="vValue2">Second value to use with the given filter operator (only for some operators)</param>
					public extern Filter(Union<sap.ui.model.Filter.FilterInfo, string, sap.ui.model.Filter[]> vFilterInfo, Union<sap.ui.model.FilterOperator, object, bool> vOperator, object vValue1, object vValue2);

					/// <summary>
					/// Constructor for Filter.
					/// 
					/// You either pass a single object literal with the filter parameters or use the individual constructor arguments. No matter which variant is used, only certain combinations of parameters are supported (the following list uses the names from the object literal): <ul> <li>A <code>path</code>, <code>operator</code> and one or two values (<code>value1</code>, <code>value2</code>), depending on the operator</li> <li>A <code>path</code> and a custom filter function <code>test</code></li> <li>An array of other filters named <code>filters</code> and a Boolean flag <code>and</code> that specifies whether to combine the filters with an AND (<code>true</code>) or an OR (<code>false</code>) operator.</li> </ul> An error will be logged to the console if an invalid combination of parameters is provided. Please note that a model implementation may not support a custom filter function, e.g. if the model does not perform client side filtering. It also depends on the model implementation if the filtering is case sensitive or not. See particular model documentation for details The filter operators <code>Any</code> and <code>All</code> are only supported in V4 OData models. When creating a filter instance with these filter operators, the argument <code>variable</code> only accepts a string identifier and <code>condition</code> needs to be another filter instance.
					/// </summary>
					/// <param name="vFilterInfo">Filter info object or a path or an array of filters</param>
					/// <param name="vOperator">Either a filter operator or a custom filter function or a Boolean flag that defines how to combine multiple filters</param>
					/// <param name="vValue1">First value to use with the given filter operator</param>
					public extern Filter(Union<sap.ui.model.Filter.FilterInfo, string, sap.ui.model.Filter[]> vFilterInfo, Union<sap.ui.model.FilterOperator, object, bool> vOperator, object vValue1);

					/// <summary>
					/// Constructor for Filter.
					/// 
					/// You either pass a single object literal with the filter parameters or use the individual constructor arguments. No matter which variant is used, only certain combinations of parameters are supported (the following list uses the names from the object literal): <ul> <li>A <code>path</code>, <code>operator</code> and one or two values (<code>value1</code>, <code>value2</code>), depending on the operator</li> <li>A <code>path</code> and a custom filter function <code>test</code></li> <li>An array of other filters named <code>filters</code> and a Boolean flag <code>and</code> that specifies whether to combine the filters with an AND (<code>true</code>) or an OR (<code>false</code>) operator.</li> </ul> An error will be logged to the console if an invalid combination of parameters is provided. Please note that a model implementation may not support a custom filter function, e.g. if the model does not perform client side filtering. It also depends on the model implementation if the filtering is case sensitive or not. See particular model documentation for details The filter operators <code>Any</code> and <code>All</code> are only supported in V4 OData models. When creating a filter instance with these filter operators, the argument <code>variable</code> only accepts a string identifier and <code>condition</code> needs to be another filter instance.
					/// </summary>
					/// <param name="vFilterInfo">Filter info object or a path or an array of filters</param>
					/// <param name="vOperator">Either a filter operator or a custom filter function or a Boolean flag that defines how to combine multiple filters</param>
					public extern Filter(Union<sap.ui.model.Filter.FilterInfo, string, sap.ui.model.Filter[]> vFilterInfo, Union<sap.ui.model.FilterOperator, object, bool> vOperator);

					/// <summary>
					/// Constructor for Filter.
					/// 
					/// You either pass a single object literal with the filter parameters or use the individual constructor arguments. No matter which variant is used, only certain combinations of parameters are supported (the following list uses the names from the object literal): <ul> <li>A <code>path</code>, <code>operator</code> and one or two values (<code>value1</code>, <code>value2</code>), depending on the operator</li> <li>A <code>path</code> and a custom filter function <code>test</code></li> <li>An array of other filters named <code>filters</code> and a Boolean flag <code>and</code> that specifies whether to combine the filters with an AND (<code>true</code>) or an OR (<code>false</code>) operator.</li> </ul> An error will be logged to the console if an invalid combination of parameters is provided. Please note that a model implementation may not support a custom filter function, e.g. if the model does not perform client side filtering. It also depends on the model implementation if the filtering is case sensitive or not. See particular model documentation for details The filter operators <code>Any</code> and <code>All</code> are only supported in V4 OData models. When creating a filter instance with these filter operators, the argument <code>variable</code> only accepts a string identifier and <code>condition</code> needs to be another filter instance.
					/// </summary>
					/// <param name="vFilterInfo">Filter info object or a path or an array of filters</param>
					public extern Filter(Union<sap.ui.model.Filter.FilterInfo, string, sap.ui.model.Filter[]> vFilterInfo);

					#endregion

					#region Methods

					/// <summary>
					/// Compares two values
					/// 
					/// This is the default comparator function used for clientside filtering, if no custom comparator is given in the constructor. It does compare just by using equal/less than/greater than with automatic type casting, except for null values, which are neither less or greater, and string values where localeCompare is used.
					/// 
					/// The comparator method returns -1, 0, 1 for comparable values and NaN for non-comparable values.
					/// </summary>
					/// <param name="a">the first value to compare</param>
					/// <param name="b">the second value to compare</param>
					/// <returns>-1, 0, 1 or NaN depending on the compare result</returns>
					public extern static int defaultComparator(object a, object b);

					/// <summary>
					/// Creates a new subclass of class sap.ui.model.Filter with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.model.Filter with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.model.Filter with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.model.Filter.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					#endregion

				}
			}
		}
	}
}
