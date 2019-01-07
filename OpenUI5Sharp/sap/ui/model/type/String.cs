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
				public static partial class type
				{
					/// <summary>
					/// This class represents string simple types.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.model.type.String")]
					public partial class String : sap.ui.model.SimpleType
					{
						#region Typed Parameters

						/// <summary>
						/// Parameter to be used as Object Literal
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class StringInfo
						{
							/// <summary>
							/// maximum length (in characters) that a string of this value may have
							/// </summary>
							public int maxLength;

							/// <summary>
							/// minimum length (in characters) that a string of this value may have
							/// </summary>
							public int minLength;

							/// <summary>
							/// a prefix that any valid value must start with
							/// </summary>
							public string startsWith;

							/// <summary>
							/// a prefix that any valid value must start with, ignoring case
							/// </summary>
							public string startsWithIgnoreCase;

							/// <summary>
							/// a suffix that any valid value must end with
							/// </summary>
							public string endsWith;

							/// <summary>
							/// a suffix that any valid value must end with, ignoring case
							/// </summary>
							public string endsWithIgnoreCase;

							/// <summary>
							/// an infix that must be contained in any valid value
							/// </summary>
							public string contains;

							/// <summary>
							/// only value that is allowed
							/// </summary>
							public string equals;

							/// <summary>
							/// a regular expression that the value must match
							/// </summary>
							public es5.RegExp search;

						}

						#endregion

						#region Constructor

						/// <summary>
						/// Constructor for a String type.
						/// </summary>
						/// <param name="oFormatOptions">formatting options. String doesn't support any formatting options</param>
						/// <param name="oConstraints">value constraints. All given constraints must be fulfilled by a value to be valid</param>
						public extern String(object oFormatOptions, sap.ui.model.type.String.StringInfo oConstraints);

						/// <summary>
						/// Constructor for a String type.
						/// </summary>
						/// <param name="oFormatOptions">formatting options. String doesn't support any formatting options</param>
						public extern String(object oFormatOptions);

						/// <summary>
						/// Constructor for a String type.
						/// </summary>
						public extern String();

						#endregion

						#region Methods

						/// <summary>
						/// Creates a new subclass of class sap.ui.model.type.String with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.SimpleType.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.model.type.String with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.SimpleType.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.model.type.String with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.SimpleType.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns a metadata object for class sap.ui.model.type.String.
						/// </summary>
						/// <returns>Metadata object describing this class</returns>
						[Name("getMetadata")]
						public extern static sap.ui.@base.Metadata getMetadataStatic();

						#endregion

					}
				}
			}
		}
	}
}
