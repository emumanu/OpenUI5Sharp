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
				public static partial class analytics
				{
					public static partial class odata4analytics
					{
						/// <summary>
						/// Representation of a property annotated with sap:parameter.
						/// </summary>
						[External]
						[Namespace(false)]
						public partial class Parameter
						{
							#region Constructor

							/// <summary>
							/// Create a representation of a single parameter contained in a parameterization. Do not create your own instances.
							/// </summary>
							/// <param name="oParameterization">The parameterization containing this parameter</param>
							/// <param name="oProperty">The datajs object object representing the text property</param>
							public extern Parameter(sap.ui.model.analytics.odata4analytics.Parameterization oParameterization, object oProperty);

							#endregion

							#region Methods

							/// <summary>
							/// Get parameterization containing this parameter
							/// </summary>
							/// <returns>The parameterization object</returns>
							public extern virtual sap.ui.model.analytics.odata4analytics.Parameterization getContainingParameterization();

							/// <summary>
							/// Get label
							/// </summary>
							/// <returns>The (possibly language-dependent) label text for this parameter</returns>
							public extern virtual string getLabelText();

							/// <summary>
							/// Get the name of the parameter
							/// </summary>
							/// <returns>The name of the parameter, which is identical with the name of the property representing the parameter in the parameterization entity type</returns>
							public extern virtual string getName();

							/// <summary>
							/// Get property for the parameter representing the peer boundary of the same interval
							/// </summary>
							/// <returns>The parameter representing the peer boundary of the same interval. This means that if *this* parameter is a lower boundary, the returned object</returns>
							public extern virtual sap.ui.model.analytics.odata4analytics.Parameter getPeerIntervalBoundaryParameter();

							/// <summary>
							/// Get property
							/// </summary>
							/// <returns>The datajs object representing the property of this parameter</returns>
							public extern virtual object getProperty();

							/// <summary>
							/// Get text property related to this parameter
							/// </summary>
							/// <returns>The datajs object representing the text property or null if it does not exist</returns>
							public extern virtual object getTextProperty();

							/// <summary>
							/// Get the URI to locate the entity set holding the value set, if it is available.
							/// </summary>
							/// <param name="sServiceRootURI">(optional) Identifies the root of the OData service</param>
							/// <returns>The resource path of the URI pointing to the entity set. It is a relative URI unless a service root is given, which would then prefixed in order to return a complete URL.</returns>
							public extern virtual void getURIToValueEntitySet(string sServiceRootURI);

							/// <summary>
							/// Get indicator if the parameter represents an interval boundary
							/// </summary>
							/// <returns>True iff it represents an interval boundary, otherwise false</returns>
							public extern virtual bool isIntervalBoundary();

							/// <summary>
							/// Get indicator if the parameter represents the lower boundary of an interval
							/// </summary>
							/// <returns>True iff it represents the lower boundary of an interval, otherwise false</returns>
							public extern virtual bool isLowerIntervalBoundary();

							/// <summary>
							/// Get indicator whether or not the parameter is optional
							/// </summary>
							/// <returns>True iff the parameter is optional</returns>
							public extern virtual bool isOptional();

							/// <summary>
							/// Get indicator if a set of values is available for this parameter. Typically, this is true for parameters with a finite set of known values such as products, business partners in different roles, organization units, and false for integer or date parameters
							/// </summary>
							/// <returns>True iff a value set is available, otherwise false</returns>
							public extern virtual bool isValueSetAvailable();

							#endregion

						}
					}
				}
			}
		}
	}
}
