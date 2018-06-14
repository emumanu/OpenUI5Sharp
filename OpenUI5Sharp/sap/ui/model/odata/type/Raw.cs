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
				public static partial class odata
				{
					public static partial class type
					{
						/// <summary>
						/// This class represents a placeholder for all unsupported OData primitive types. It can only be used to retrieve raw values "as is" (i.e. <code>formatValue(vValue, "any")</code>), but not to actually convert to or from any other representation or to validate.
						/// </summary>
						[External]
						[Namespace(false)]
						public partial class Raw : sap.ui.model.odata.type.ODataType
						{
							#region Constructor

							/// <summary>
							/// Constructor for a placeholder for all unsupported OData primitive types.
							/// </summary>
							/// <param name="oFormatOptions">Must be <code>undefined</code></param>
							/// <param name="oConstraints">Must be <code>undefined</code></param>
							public extern Raw(object oFormatOptions, object oConstraints);

							/// <summary>
							/// Constructor for a placeholder for all unsupported OData primitive types.
							/// </summary>
							/// <param name="oFormatOptions">Must be <code>undefined</code></param>
							public extern Raw(object oFormatOptions);

							/// <summary>
							/// Constructor for a placeholder for all unsupported OData primitive types.
							/// </summary>
							public extern Raw();

							#endregion

							#region Methods

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.type.Raw with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.odata.type.ODataType.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <param name="oClassInfo">Object literal with information about the class</param>
							/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.type.Raw with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.odata.type.ODataType.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <param name="oClassInfo">Object literal with information about the class</param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName, object oClassInfo);

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.type.Raw with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.odata.type.ODataType.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName);

							/// <summary>
							/// Formats the given value to the given target type.
							/// </summary>
							/// <param name="vValue">The raw value to be retrieved "as is"</param>
							/// <param name="sTargetType">The target type; must be "any"</param>
							/// <returns>The raw value "as is"</returns>
							public extern virtual object formatValue(object vValue, string sTargetType);

							/// <summary>
							/// Returns a metadata object for class sap.ui.model.odata.type.Raw.
							/// </summary>
							/// <returns>Metadata object describing this class</returns>
							public extern static sap.ui.@base.Metadata getMetadata();

							/// <summary>
							/// Returns the type's name.
							/// </summary>
							/// <returns>The type's name</returns>
							public extern override string getName();

							/// <summary>
							/// Method not supported
							/// </summary>
							public extern virtual void parseValue();

							/// <summary>
							/// Method not supported
							/// </summary>
							public extern virtual void validateValue();

							#endregion

						}
					}
				}
			}
		}
	}
}
