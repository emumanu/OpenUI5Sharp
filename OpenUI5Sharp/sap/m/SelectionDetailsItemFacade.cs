using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public static partial class sap
	{
		public static partial class m
		{
			/// <summary>
			/// The public facade of the {@link sap.m.SelectionDetailsItem} element.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.SelectionDetailsItemFacade")]
			public partial class SelectionDetailsItemFacade
			{
				#region Constructor

				/// <summary>
				/// Describes the public facade of the {@link sap.m.SelectionDetailsItem} element.
				/// </summary>
				public extern SelectionDetailsItemFacade();

				#endregion

				#region Methods

				/// <summary>
				/// Adds some action to the aggregation {@link #getActions actions}.
				/// </summary>
				/// <param name="oAction">The action to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern static sap.m.SelectionDetailsItem addAction(sap.ui.core.Item oAction);

				/// <summary>
				/// Gets current value of property {@link #getEnableNav enableNav}.
				/// 
				/// Determines whether or not the item is active and a navigation event is triggered on press.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>enableNav</code></returns>
				public extern static bool getEnableNav();

				/// <summary>
				/// Removes a action from the aggregation {@link #getActions actions}.
				/// </summary>
				/// <param name="vAction">The action to remove or its index or id</param>
				/// <returns>The removed action or <code>null</code></returns>
				public extern static sap.ui.core.Item removeAction(Union<int, string, sap.ui.core.Item> vAction);

				/// <summary>
				/// Sets a new value for property {@link #getEnableNav enableNav}.
				/// 
				/// Determines whether or not the item is active and a navigation event is triggered on press.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bEnableNav">New value for property <code>enableNav</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern static sap.m.SelectionDetailsItem setEnableNav(bool bEnableNav);

				#endregion

			}
		}
	}
}
