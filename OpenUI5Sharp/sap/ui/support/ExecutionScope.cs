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
			public static partial class support
			{
				/// <summary>
				/// Allows to select the scope of analysis on an application.
				/// 
				/// <h3>Overview</h3>
				/// 
				/// <code>ExecutionScope</code> is the third parameter of a rule check function. It provides access to internal UI5 objects available for inspection. The <code>getElements</code> API method allows the user to select a specific subset of elements valid for their case. It accepts one query object argument.
				/// 
				/// <h3>Usage</h3>
				/// 
				/// When a rule is executed, three parameters are passed: <code>oIssueManager</code>, <code>oCoreFacade</code> and <code>oScope</code>.
				/// 
				/// An <code>ExecutionScope</code> instance is passed to every call of a rule check function. When you analyze your application, available objects are collected depending on the settings passed to the Support Assistant at the moment when you start it.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.support.ExecutionScope")]
				public partial class ExecutionScope
				{
					#region Typed Parameters

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class GetElementsConfig
					{
						/// <summary>
						/// Type name to filter by type
						/// </summary>
						public string type;

						/// <summary>
						/// Option to exclude elements that are not public aggregations
						/// </summary>
						public bool @public;

						/// <summary>
						/// Option to exclude elements that are clones of list bindings
						/// </summary>
						public bool cloned;

					}

					#endregion

					#region Constructor

					public extern ExecutionScope();

					#endregion

					#region Methods

					/// <param name="oConfig">Object with specific filtering options</param>
					/// <returns>Array of matched elements</returns>
					public extern static object[] getElements(sap.ui.support.ExecutionScope.GetElementsConfig oConfig);

					/// <summary>
					/// Gets elements by their type
					/// </summary>
					/// <param name="classNameSelector">Either string or function to be used when selecting a subset of elements</param>
					/// <returns>Array of matched elements</returns>
					public extern static object[] getElementsByClassName(Union<string, object> classNameSelector);

					/// <summary>
					/// Gets the logged objects by object type
					/// </summary>
					/// <param name="type">Type of logged objects</param>
					/// <returns>Array of logged objects</returns>
					public extern static object[] getLoggedObjects(object type);

					/// <summary>
					/// Returns all public elements, i.e. elements that are part of public API aggregations
					/// </summary>
					/// <returns>Array of matched elements</returns>
					public extern static object[] getPublicElements();

					#endregion

				}
			}
		}
	}
}
