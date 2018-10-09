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
			public static partial class core
			{
				/// <summary>
				/// History handles the history of certain controls (e.g. sap.ui.commons.SearchField).
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.core.History")]
				public partial class History : sap.ui.@base.Object
				{
					#region Constructor

					/// <summary>
					/// Creates an instance of the History.
					/// 
					/// Attention: The Web Storage API which is used by this class stores the data on the client. Therefore do not use this API for confidential information.
					/// </summary>
					/// <param name="sId">id for the history</param>
					/// <param name="mSettings">optional map/JSON-object with additional settings</param>
					public extern History(string sId, object mSettings);

					/// <summary>
					/// Creates an instance of the History.
					/// 
					/// Attention: The Web Storage API which is used by this class stores the data on the client. Therefore do not use this API for confidential information.
					/// </summary>
					/// <param name="sId">id for the history</param>
					public extern History(string sId);

					#endregion

					#region Methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.History with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.History with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.History with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.core.History.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					#endregion

				}
			}
		}
	}
}
