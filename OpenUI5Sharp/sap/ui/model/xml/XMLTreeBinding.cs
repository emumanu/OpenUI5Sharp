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
				public static partial class xml
				{
					/// <summary>
					/// Tree binding implementation for XML format
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.model.xml.XMLTreeBinding")]
					public partial class XMLTreeBinding : sap.ui.model.ClientTreeBinding
					{
						#region Constructor

						/// <param name="oModel"></param>
						/// <param name="Path">pointing to the tree or array that should be bound</param>
						/// <param name="oContext">Context object for this binding</param>
						/// <param name="aFilters">Predefined filters contained in an array</param>
						/// <param name="mParameters">Additional model-specific parameters</param>
						public extern XMLTreeBinding(sap.ui.model.xml.XMLModel oModel, string Path, object oContext, object[] aFilters, object mParameters);

						/// <param name="oModel"></param>
						/// <param name="Path">pointing to the tree or array that should be bound</param>
						/// <param name="oContext">Context object for this binding</param>
						/// <param name="aFilters">Predefined filters contained in an array</param>
						public extern XMLTreeBinding(sap.ui.model.xml.XMLModel oModel, string Path, object oContext, object[] aFilters);

						/// <param name="oModel"></param>
						/// <param name="Path">pointing to the tree or array that should be bound</param>
						/// <param name="oContext">Context object for this binding</param>
						public extern XMLTreeBinding(sap.ui.model.xml.XMLModel oModel, string Path, object oContext);

						/// <param name="oModel"></param>
						/// <param name="Path">pointing to the tree or array that should be bound</param>
						public extern XMLTreeBinding(sap.ui.model.xml.XMLModel oModel, string Path);

						/// <param name="Path">pointing to the tree or array that should be bound</param>
						public extern XMLTreeBinding(string Path);

						/// <param name="Path">pointing to the tree or array that should be bound</param>
						/// <param name="oContext">Context object for this binding</param>
						public extern XMLTreeBinding(string Path, object oContext);

						/// <param name="Path">pointing to the tree or array that should be bound</param>
						/// <param name="oContext">Context object for this binding</param>
						/// <param name="aFilters">Predefined filters contained in an array</param>
						public extern XMLTreeBinding(string Path, object oContext, object[] aFilters);

						/// <param name="Path">pointing to the tree or array that should be bound</param>
						/// <param name="oContext">Context object for this binding</param>
						/// <param name="aFilters">Predefined filters contained in an array</param>
						/// <param name="mParameters">Additional model-specific parameters</param>
						public extern XMLTreeBinding(string Path, object oContext, object[] aFilters, object mParameters);

						#endregion

						#region Methods

						/// <summary>
						/// Return node contexts for the tree
						/// </summary>
						/// <param name="oContext">to use for retrieving the node contexts</param>
						/// <param name="iStartIndex">the startIndex where to start the retrieval of contexts</param>
						/// <param name="iLength">determines how many contexts to retrieve beginning from the start index.</param>
						/// <returns>the contexts array</returns>
						public extern virtual object[] getNodeContexts(object oContext, int iStartIndex, int iLength);

						#endregion

					}
				}
			}
		}
	}
}
