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
			public static partial class core
			{
				public static partial class theming
				{
					/// <summary>
					/// A helper used for (read-only) access to CSS parameters at runtime.
					/// </summary>
					[External]
					[Namespace(false)]
					public static partial class Parameters
					{
						#region Methods

						/// <summary>
						/// Returns the scopes from current theming parameters.
						/// </summary>
						/// <param name="bAvoidLoading">Whether loading of parameters should be avoided</param>
						/// <returns>Scope names</returns>
						private extern static object[] _getScopes(bool bAvoidLoading);

						/// <summary>
						/// Returns the scopes from current theming parameters.
						/// </summary>
						/// <returns>Scope names</returns>
						private extern static object[] _getScopes();

						/// <summary>
						/// Returns the current value for one or more theming parameters, depending on the given arguments. <ul> <li>If no parameter is given a key-value map containing all parameters is returned</li> <li>If a <code>string</code> is given as first parameter the value is returned as a <code>string</code></li> <li>If an <code>array</code> is given as first parameter a key-value map containing all parameters from the <code>array</code> is returned</li> </ul> <p>The returned key-value maps are a copy so changing values in the map does not have any effect</p>
						/// </summary>
						/// <param name="vName">the (array with) CSS parameter name(s)</param>
						/// <param name="oElement">Element / control instance to take into account when looking for a parameter value. This can make a difference when a parameter value is overridden in a theme scope set via a CSS class.</param>
						/// <returns>the CSS parameter value(s)</returns>
						public extern static Union<string, object> get(Union<string, string[]> vName, sap.ui.core.Element oElement);

						/// <summary>
						/// Returns the current value for one or more theming parameters, depending on the given arguments. <ul> <li>If no parameter is given a key-value map containing all parameters is returned</li> <li>If a <code>string</code> is given as first parameter the value is returned as a <code>string</code></li> <li>If an <code>array</code> is given as first parameter a key-value map containing all parameters from the <code>array</code> is returned</li> </ul> <p>The returned key-value maps are a copy so changing values in the map does not have any effect</p>
						/// </summary>
						/// <param name="vName">the (array with) CSS parameter name(s)</param>
						/// <returns>the CSS parameter value(s)</returns>
						public extern static Union<string, object> get(Union<string, string[]> vName);

						/// <summary>
						/// Returns the active scope(s) for a given control by looking up the hierarchy.
						/// 
						/// The lookup navigates the DOM hierarchy if it's available. Otherwise if controls aren't rendered yet, it navigates the control hierarchy. By navigating the control hierarchy, inner-html elements with the respective scope classes can't get recognized as the Custom Style Class API does only for root elements.
						/// </summary>
						/// <param name="oElement">element/control instance</param>
						/// <returns>Two dimensional array with scopes in bottom up order</returns>
						private extern static string[][] getActiveScopesFor(object oElement);

						/// <summary>
						/// Resets the CSS parameters which finally will reload the parameters the next time they are queried via the method <code>get</code>.
						/// </summary>
						public extern static void reset();

						#endregion

					}
				}
			}
		}
	}
}
