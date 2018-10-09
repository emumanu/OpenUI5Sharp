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
			public static partial class test
			{
				public static partial class gherkin
				{
					/// <summary>
					/// Provides utility functions for formatting 2D arrays of strings (such as the raw data loaded from a Gherkin feature file) into a more useful format such as an array of objects or a single object. Also handles normalization of the raw strings.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.test.gherkin.dataTableUtils")]
					public static partial class dataTableUtils
					{
						#region Methods

						/// <summary>
						/// Takes the inputed 2D array "aData" and returns an equivalent object. Each row of data is expected to be a property-value pair. To create nested objects, add extra columns to the data. E.g. <pre>
						///  [
						///    ["Name", "Alice"],
						///    ["Mass", "135 lbs"],
						///    ["Telephone Number", "Home", "123-456-7890"],
						///    ["Telephone Number", "Work", "123-456-0987"]
						///  ]
						/// </pre> For each data row, the right-most element becomes a property value, and everything else is a property name. The property names get normalized according to the strategy defined by the parameter "vNorm". E.g. using camelCase strategy <pre>
						///   {
						///     name: "Alice",
						///     mass: "135 lbs",
						///     telephoneNumber: {
						///       home: "123-456-7890",
						///       work: "123-456-0987"
						///     }
						///   }
						/// </pre>
						/// </summary>
						/// <param name="aData">the 2D array of strings to be converted</param>
						/// <param name="vNorm">the normalization function to use to normalize property names. Can also be a string with values "titleCase", "pascalCase", "camelCase", "hyphenated" or "none".</param>
						/// <returns>- an object equivalent to the input data, with property names normalized</returns>
						public extern static object toObject(string[] aData, Union<string, object> vNorm);

						/// <summary>
						/// Takes the inputed 2D array "aData" and returns an equivalent object. Each row of data is expected to be a property-value pair. To create nested objects, add extra columns to the data. E.g. <pre>
						///  [
						///    ["Name", "Alice"],
						///    ["Mass", "135 lbs"],
						///    ["Telephone Number", "Home", "123-456-7890"],
						///    ["Telephone Number", "Work", "123-456-0987"]
						///  ]
						/// </pre> For each data row, the right-most element becomes a property value, and everything else is a property name. The property names get normalized according to the strategy defined by the parameter "vNorm". E.g. using camelCase strategy <pre>
						///   {
						///     name: "Alice",
						///     mass: "135 lbs",
						///     telephoneNumber: {
						///       home: "123-456-7890",
						///       work: "123-456-0987"
						///     }
						///   }
						/// </pre>
						/// </summary>
						/// <param name="aData">the 2D array of strings to be converted</param>
						/// <param name="vNorm">the normalization function to use to normalize property names. Can also be a string with values "titleCase", "pascalCase", "camelCase", "hyphenated" or "none".</param>
						/// <returns>- an object equivalent to the input data, with property names normalized</returns>
						public extern static object toObject(object[] aData, Union<string, object> vNorm);

						/// <summary>
						/// Takes the inputed 2D array "aData" and returns an equivalent object. Each row of data is expected to be a property-value pair. To create nested objects, add extra columns to the data. E.g. <pre>
						///  [
						///    ["Name", "Alice"],
						///    ["Mass", "135 lbs"],
						///    ["Telephone Number", "Home", "123-456-7890"],
						///    ["Telephone Number", "Work", "123-456-0987"]
						///  ]
						/// </pre> For each data row, the right-most element becomes a property value, and everything else is a property name. The property names get normalized according to the strategy defined by the parameter "vNorm". E.g. using camelCase strategy <pre>
						///   {
						///     name: "Alice",
						///     mass: "135 lbs",
						///     telephoneNumber: {
						///       home: "123-456-7890",
						///       work: "123-456-0987"
						///     }
						///   }
						/// </pre>
						/// </summary>
						/// <param name="aData">the 2D array of strings to be converted</param>
						/// <returns>- an object equivalent to the input data, with property names normalized</returns>
						public extern static object toObject(string[] aData);

						/// <summary>
						/// Takes the inputed 2D array "aData" and returns an equivalent object. Each row of data is expected to be a property-value pair. To create nested objects, add extra columns to the data. E.g. <pre>
						///  [
						///    ["Name", "Alice"],
						///    ["Mass", "135 lbs"],
						///    ["Telephone Number", "Home", "123-456-7890"],
						///    ["Telephone Number", "Work", "123-456-0987"]
						///  ]
						/// </pre> For each data row, the right-most element becomes a property value, and everything else is a property name. The property names get normalized according to the strategy defined by the parameter "vNorm". E.g. using camelCase strategy <pre>
						///   {
						///     name: "Alice",
						///     mass: "135 lbs",
						///     telephoneNumber: {
						///       home: "123-456-7890",
						///       work: "123-456-0987"
						///     }
						///   }
						/// </pre>
						/// </summary>
						/// <param name="aData">the 2D array of strings to be converted</param>
						/// <returns>- an object equivalent to the input data, with property names normalized</returns>
						public extern static object toObject(object[] aData);

						/// <summary>
						/// Takes the inputed 2D array "aData" and returns an equivalent array of objects. The data is expected to have a header row, with each subsequent row being an entity, and each column being a property of that entity. E.g. <pre>
						///   [
						///     ["Their Name",  "Their Age"],
						///     ["Alice",       "16"],
						///     ["Bob",         "22"]
						///   ]
						/// </pre>
						/// 
						/// The data's column headers become the returned objects' property names. The property names get normalized according to the strategy defined by the parameter "vNorm". E.g. using hyphenation strategy this is returned: <pre>
						///   [
						///     {their-name: "Alice", their-age: "16"},
						///     {their-name: "Bob", their-age: "22"}
						///   ]
						/// </pre>
						/// </summary>
						/// <param name="aData">the 2D array of strings to be converted, with a header row</param>
						/// <param name="vNorm">the normalization function to use to normalize property names. Can also be a String with values "titleCase", "pascalCase", "camelCase", "hyphenated" or "none".</param>
						/// <returns>- an array of objects equivalent to the input data, with property names normalized</returns>
						public extern static object[] toTable(string[] aData, Union<string, object> vNorm);

						/// <summary>
						/// Takes the inputed 2D array "aData" and returns an equivalent array of objects. The data is expected to have a header row, with each subsequent row being an entity, and each column being a property of that entity. E.g. <pre>
						///   [
						///     ["Their Name",  "Their Age"],
						///     ["Alice",       "16"],
						///     ["Bob",         "22"]
						///   ]
						/// </pre>
						/// 
						/// The data's column headers become the returned objects' property names. The property names get normalized according to the strategy defined by the parameter "vNorm". E.g. using hyphenation strategy this is returned: <pre>
						///   [
						///     {their-name: "Alice", their-age: "16"},
						///     {their-name: "Bob", their-age: "22"}
						///   ]
						/// </pre>
						/// </summary>
						/// <param name="aData">the 2D array of strings to be converted, with a header row</param>
						/// <param name="vNorm">the normalization function to use to normalize property names. Can also be a String with values "titleCase", "pascalCase", "camelCase", "hyphenated" or "none".</param>
						/// <returns>- an array of objects equivalent to the input data, with property names normalized</returns>
						public extern static object[] toTable(object[] aData, Union<string, object> vNorm);

						/// <summary>
						/// Takes the inputed 2D array "aData" and returns an equivalent array of objects. The data is expected to have a header row, with each subsequent row being an entity, and each column being a property of that entity. E.g. <pre>
						///   [
						///     ["Their Name",  "Their Age"],
						///     ["Alice",       "16"],
						///     ["Bob",         "22"]
						///   ]
						/// </pre>
						/// 
						/// The data's column headers become the returned objects' property names. The property names get normalized according to the strategy defined by the parameter "vNorm". E.g. using hyphenation strategy this is returned: <pre>
						///   [
						///     {their-name: "Alice", their-age: "16"},
						///     {their-name: "Bob", their-age: "22"}
						///   ]
						/// </pre>
						/// </summary>
						/// <param name="aData">the 2D array of strings to be converted, with a header row</param>
						/// <returns>- an array of objects equivalent to the input data, with property names normalized</returns>
						public extern static object[] toTable(string[] aData);

						/// <summary>
						/// Takes the inputed 2D array "aData" and returns an equivalent array of objects. The data is expected to have a header row, with each subsequent row being an entity, and each column being a property of that entity. E.g. <pre>
						///   [
						///     ["Their Name",  "Their Age"],
						///     ["Alice",       "16"],
						///     ["Bob",         "22"]
						///   ]
						/// </pre>
						/// 
						/// The data's column headers become the returned objects' property names. The property names get normalized according to the strategy defined by the parameter "vNorm". E.g. using hyphenation strategy this is returned: <pre>
						///   [
						///     {their-name: "Alice", their-age: "16"},
						///     {their-name: "Bob", their-age: "22"}
						///   ]
						/// </pre>
						/// </summary>
						/// <param name="aData">the 2D array of strings to be converted, with a header row</param>
						/// <returns>- an array of objects equivalent to the input data, with property names normalized</returns>
						public extern static object[] toTable(object[] aData);

						#endregion

					}
				}
			}
		}
	}
}
