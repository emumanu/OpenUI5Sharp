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
				public static partial class odata
				{
					public static partial class type
					{
						/// <summary>
						/// This class represents the OData V4 primitive type {@link http://docs.oasis-open.org/odata/odata/v4.0/errata02/os/complete/part3-csdl/odata-v4.0-errata02-os-part3-csdl-complete.html#_The_edm:Documentation_Element <code>Edm.Stream</code>}. The values for stream properties do not appear in the entity payload. Instead, the values are read or written through URLs.
						/// 
						/// This type only supports reading streams. For this purpose bind the stream property to a control property of type <code>sap.ui.core.URI</code>. {#formatValue} will then deliver the correct URL to read the stream.
						/// </summary>
						[External]
						[Namespace(false)]
						[Name("sap.ui.model.odata.type.Stream")]
						public partial class Stream : sap.ui.model.odata.type.ODataType
						{
							#region Typed Parameters

							/// <summary>
							/// Parameter to be used as Object Literal
							/// </summary>
							[External]
							[ObjectLiteral]
							public partial class StreamInfo
							{
								/// <summary>
								/// if <code>true</code>, the server accepts the value <code>null</code>
								/// </summary>
								public bool nullable;

							}

							#endregion

							#region Constructor

							/// <summary>
							/// Constructor for an OData primitive type <code>Edm.Stream</code>.
							/// </summary>
							/// <param name="oFormatOptions">Must be <code>undefined</code></param>
							/// <param name="oConstraints">constraints; they are only stored for documentation purpose, since no validation can occur</param>
							public extern Stream(object oFormatOptions, sap.ui.model.odata.type.Stream.StreamInfo oConstraints);

							/// <summary>
							/// Constructor for an OData primitive type <code>Edm.Stream</code>.
							/// </summary>
							/// <param name="oFormatOptions">Must be <code>undefined</code></param>
							public extern Stream(object oFormatOptions);

							/// <summary>
							/// Constructor for an OData primitive type <code>Edm.Stream</code>.
							/// </summary>
							public extern Stream();

							#endregion

							#region Methods

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.type.Stream with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.odata.type.ODataType.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <param name="oClassInfo">Object literal with information about the class</param>
							/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.type.Stream with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.odata.type.ODataType.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <param name="oClassInfo">Object literal with information about the class</param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName, object oClassInfo);

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.type.Stream with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.odata.type.ODataType.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName);

							/// <summary>
							/// Returns the input value unchanged.
							/// </summary>
							/// <param name="sValue">the read URL</param>
							/// <param name="sTargetType">The target type; must be "any" or "string"</param>
							/// <returns>The property's read URL</returns>
							public extern virtual string formatValue(string sValue, string sTargetType);

							/// <summary>
							/// Returns a metadata object for class sap.ui.model.odata.type.Stream.
							/// </summary>
							/// <returns>Metadata object describing this class</returns>
							[Name("getMetadata")]
							public extern static sap.ui.@base.Metadata getMetadataStatic();

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
