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
					/// <summary>
					/// Implementation of an OData meta model which offers a unified access to both OData V2 metadata and V4 annotations. It uses the existing {@link sap.ui.model.odata.ODataMetadata} as a foundation and merges V4 annotations from the existing {@link sap.ui.model.odata.ODataAnnotations} directly into the corresponding model element.
					/// 
					/// Also, annotations from the "http://www.sap.com/Protocols/SAPData" namespace are lifted up from the <code>extensions</code> array and transformed from objects into simple properties with an "sap:" prefix for their name. Note that this happens in addition, thus the following example shows both representations. This way, such annotations can be addressed via a simple relative path instead of searching an array. <pre>
					/// 		{
					/// 			"name" : "BusinessPartnerID",
					/// 			"extensions" : [{
					/// 				"name" : "label",
					/// 				"value" : "Bus. Part. ID",
					/// 				"namespace" : "http://www.sap.com/Protocols/SAPData"
					/// 			}],
					/// 			"sap:label" : "Bus. Part. ID"
					/// 		}
					/// </pre>
					/// 
					/// As of 1.29.0, the corresponding vocabulary-based annotations for the following "<a href="http://www.sap.com/Protocols/SAPData">SAP Annotations for OData Version 2.0</a>" are added, if they are not yet defined in the V4 annotations: <ul> <li><code>label</code>;</li> <li><code>schema-version</code> (since 1.53.0) on schemas;</li> <li><code>creatable</code>, <code>deletable</code>, <code>deletable-path</code>, <code>pageable</code>, <code>requires-filter</code>, <code>searchable</code>, <code>topable</code>, <code>updatable</code> and <code>updatable-path</code> on entity sets; </li> <li><code>creatable</code> (since 1.41.0), <code>creatable-path</code> (since 1.41.0) and <code>filterable</code> (since 1.39.0) on navigation properties;</li> <li><code>aggregation-role</code> ("dimension" and "measure", both since 1.45.0), <code>creatable</code>, <code>display-format</code> ("UpperCase" and "NonNegative"), <code>field-control</code>, <code>filterable</code>, <code>filter-restriction</code>, <code>heading</code>, <code>precision</code>, <code>quickinfo</code>, <code>required-in-filter</code>, <code>sortable</code>, <code>text</code>, <code>unit</code>, <code>updatable</code> and <code>visible</code> on properties;</li> <li><code>semantics</code>; the following values are supported: <ul> <li>"bday", "city", "country", "email" (including support for types, for example "email;type=home,pref"), "familyname", "givenname", "honorific", "middlename", "name", "nickname", "note", "org", "org-unit", "org-role", "photo", "pobox", "region", "street", "suffix", "tel" (including support for types, for example "tel;type=cell,pref"), "title" and "zip" (mapped to V4 annotation <code>com.sap.vocabularies.Communication.v1.Contact</code>); </li> <li>"class", "dtend", "dtstart", "duration", "fbtype", "location", "status", "transp" and "wholeday" (mapped to V4 annotation <code>com.sap.vocabularies.Communication.v1.Event</code>);</li> <li>"body", "from", "received", "sender" and "subject" (mapped to V4 annotation <code>com.sap.vocabularies.Communication.v1.Message</code>);</li> <li>"completed", "due", "percent-complete" and "priority" (mapped to V4 annotation <code>com.sap.vocabularies.Communication.v1.Task</code>);</li> <li>"fiscalyear", "fiscalyearperiod" (mapped to the corresponding V4 annotation <code>com.sap.vocabularies.Common.v1.IsFiscal(Year|YearPeriod)</code>);</li> <li>"year", "yearmonth", "yearmonthday", "yearquarter", "yearweek" (mapped to the corresponding V4 annotation <code>com.sap.vocabularies.Common.v1.IsCalendar(Year|YearMonth|Date|YearQuarter|YearWeek)</code>); </li> <li>"url" (mapped to V4 annotation <code>Org.OData.Core.V1.IsURL"</code>).</li> </ul> </ul> For example: <pre>
					/// 		{
					/// 			"name" : "BusinessPartnerID",
					/// 			...
					/// 			"sap:label" : "Bus. Part. ID",
					/// 			"com.sap.vocabularies.Common.v1.Label" : {
					/// 				"String" : "Bus. Part. ID"
					/// 			}
					/// 		}
					/// </pre>
					/// 
					/// This model is read-only and thus only supports {@link sap.ui.model.BindingMode.OneTime OneTime} binding mode. No events ({@link sap.ui.model.Model#event:parseError parseError}, {@link sap.ui.model.Model#event:requestCompleted requestCompleted}, {@link sap.ui.model.Model#event:requestFailed requestFailed}, {@link sap.ui.model.Model#event:requestSent requestSent}) are fired!
					/// 
					/// Within the meta model, the objects are arranged in arrays. <code>/dataServices/schema</code>, for example, is an array of schemas where each schema has an <code>entityType</code> property with an array of entity types, and so on. So, <code>/dataServices/schema/0/entityType/16</code> can be the path to the entity type with name "Order" in the schema with namespace "MySchema". However, these paths are not stable: If an entity type with lower index is removed from the schema, the path to <code>Order</code> changes to <code>/dataServices/schema/0/entityType/15</code>.
					/// 
					/// To avoid problems with changing indexes, {@link sap.ui.model.Model#getObject getObject} and {@link sap.ui.model.Model#getProperty getProperty} support XPath-like queries for the indexes (since 1.29.1). Each index can be replaced by a query in square brackets. You can, for example, address the schema using the path <code>/dataServices/schema/[${namespace}==='MySchema']</code> or the entity using <code>/dataServices/schema/[${namespace}==='MySchema']/entityType/[sap.ui.core==='Order']</code>.
					/// 
					/// The syntax inside the square brackets is the same as in expression binding. The query is executed for each object in the array until the result is true (truthy) for the first time. This object is then chosen.
					/// 
					/// <b>BEWARE:</b> Access to this OData meta model will fail before the promise returned by {@link #loaded loaded} has been resolved!
					/// </summary>
					[External]
					[Namespace(false)]
					public partial class ODataMetaModel : sap.ui.model.MetaModel
					{
						#region Typed Parameters

						/// <summary>
						/// Parameter to be used as Object Literal
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class ODataMetaModelInfo
						{
							/// <summary>
							/// the {@link sap.ui.model.odata.v2.ODataModel#addAnnotationUrl addAnnotationUrl} method of the OData model, in case this feature is supported
							/// </summary>
							public object addAnnotationUrl;

							/// <summary>
							/// a promise which is resolved by the OData model once metadata and annotations have been fully loaded
							/// </summary>
							public jquery.JQueryPromise<object> annotationsLoadedPromise;

						}

						#endregion

						#region Constructor

						/// <summary>
						/// DO NOT CALL this private constructor for a new <code>ODataMetaModel</code>, but rather use {@link sap.ui.model.odata.ODataModel#getMetaModel getMetaModel} instead!
						/// </summary>
						/// <param name="oMetadata">the OData model's metadata object</param>
						/// <param name="oAnnotations">the OData model's annotations object</param>
						/// <param name="oODataModelInterface">the private interface object of the OData model which provides friend access to selected methods</param>
						public extern ODataMetaModel(sap.ui.model.odata.ODataMetadata oMetadata, sap.ui.model.odata.ODataAnnotations oAnnotations, sap.ui.model.odata.ODataMetaModel.ODataMetaModelInfo oODataModelInterface);

						/// <summary>
						/// DO NOT CALL this private constructor for a new <code>ODataMetaModel</code>, but rather use {@link sap.ui.model.odata.ODataModel#getMetaModel getMetaModel} instead!
						/// </summary>
						/// <param name="oMetadata">the OData model's metadata object</param>
						/// <param name="oAnnotations">the OData model's annotations object</param>
						public extern ODataMetaModel(sap.ui.model.odata.ODataMetadata oMetadata, sap.ui.model.odata.ODataAnnotations oAnnotations);

						/// <summary>
						/// DO NOT CALL this private constructor for a new <code>ODataMetaModel</code>, but rather use {@link sap.ui.model.odata.ODataModel#getMetaModel getMetaModel} instead!
						/// </summary>
						/// <param name="oMetadata">the OData model's metadata object</param>
						public extern ODataMetaModel(sap.ui.model.odata.ODataMetadata oMetadata);

						#endregion

						#region Methods

						/// <summary>
						/// Creates a new subclass of class sap.ui.model.odata.ODataMetaModel with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.MetaModel.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.model.odata.ODataMetaModel with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.MetaModel.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.model.odata.ODataMetaModel with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.MetaModel.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns the OData meta model context corresponding to the given OData model path.
						/// </summary>
						/// <param name="sPath">an absolute path pointing to an entity or property, e.g. "/ProductSet(1)/ToSupplier/BusinessPartnerID"; this equals the <a href="http://www.odata.org/documentation/odata-version-2-0/uri-conventions#ResourcePath"> resource path</a> component of a URI according to OData V2 URI conventions</param>
						/// <returns>the context for the corresponding metadata object, i.e. an entity type or its property, or <code>null</code> in case no path is given</returns>
						public extern virtual sap.ui.model.Context getMetaContext(string sPath);

						/// <summary>
						/// Returns the OData meta model context corresponding to the given OData model path.
						/// </summary>
						/// <returns>the context for the corresponding metadata object, i.e. an entity type or its property, or <code>null</code> in case no path is given</returns>
						public extern virtual sap.ui.model.Context getMetaContext();

						/// <summary>
						/// Returns a metadata object for class sap.ui.model.odata.ODataMetaModel.
						/// </summary>
						/// <returns>Metadata object describing this class</returns>
						public extern static sap.ui.@base.Metadata getMetadata();

						/// <summary>
						/// Returns the OData association end corresponding to the given entity type's navigation property of given name.
						/// </summary>
						/// <param name="oEntityType">an entity type as returned by {@link #getODataEntityType getODataEntityType}</param>
						/// <param name="sName">the name of a navigation property within this entity type</param>
						/// <returns>the OData association end or <code>null</code> if no such association end is found</returns>
						public extern virtual object getODataAssociationEnd(object oEntityType, string sName);

						/// <summary>
						/// Returns the OData association <em>set</em> end corresponding to the given entity type's navigation property of given name.
						/// </summary>
						/// <param name="oEntityType">an entity type as returned by {@link #getODataEntityType getODataEntityType}</param>
						/// <param name="sName">the name of a navigation property within this entity type</param>
						/// <returns>the OData association set end or <code>null</code> if no such association set end is found</returns>
						public extern virtual object getODataAssociationSetEnd(object oEntityType, string sName);

						/// <summary>
						/// Returns the OData complex type with the given qualified name, either as a path or as an object, as indicated.
						/// </summary>
						/// <param name="sQualifiedName">a qualified name, e.g. "ACME.Address"</param>
						/// <param name="bAsPath">determines whether the complex type is returned as a path or as an object</param>
						/// <returns>(the path to) the complex type with the given qualified name; <code>undefined</code> (for a path) or <code>null</code> (for an object) if no such type is found</returns>
						public extern virtual Union<object, string> getODataComplexType(string sQualifiedName, bool bAsPath = false);

						/// <summary>
						/// Returns the OData default entity container. If there is only a single schema with a single entity container, the entity container does not need to be marked as default explicitly.
						/// </summary>
						/// <param name="bAsPath">determines whether the entity container is returned as a path or as an object</param>
						/// <returns>(the path to) the default entity container; <code>undefined</code> (for a path) or <code>null</code> (for an object) if no such container is found</returns>
						public extern virtual Union<object, string> getODataEntityContainer(bool bAsPath = false);

						/// <summary>
						/// Returns the OData entity set with the given simple name from the default entity container.
						/// </summary>
						/// <param name="sName">a simple name, e.g. "ProductSet"</param>
						/// <param name="bAsPath">determines whether the entity set is returned as a path or as an object</param>
						/// <returns>(the path to) the entity set with the given simple name; <code>undefined</code> (for a path) or <code>null</code> (for an object) if no such set is found</returns>
						public extern virtual Union<object, string> getODataEntitySet(string sName, bool bAsPath = false);

						/// <summary>
						/// Returns the OData entity type with the given qualified name, either as a path or as an object, as indicated.
						/// </summary>
						/// <param name="sQualifiedName">a qualified name, e.g. "ACME.Product"</param>
						/// <param name="bAsPath">determines whether the entity type is returned as a path or as an object</param>
						/// <returns>(the path to) the entity type with the given qualified name; <code>undefined</code> (for a path) or <code>null</code> (for an object) if no such type is found</returns>
						public extern virtual Union<object, string> getODataEntityType(string sQualifiedName, bool bAsPath = false);

						/// <summary>
						/// Returns the OData function import with the given simple or qualified name from the default entity container or the respective entity container specified in the qualified name.
						/// </summary>
						/// <param name="sName">a simple or qualified name, e.g. "Save" or "MyService.Entities/Save"</param>
						/// <param name="bAsPath">determines whether the function import is returned as a path or as an object</param>
						/// <returns>(the path to) the function import with the given simple name; <code>undefined</code> (for a path) or <code>null</code> (for an object) if no such function import is found</returns>
						public extern virtual Union<object, string> getODataFunctionImport(string sName, bool bAsPath = false);

						/// <summary>
						/// Returns the given OData type's property (not navigation property!) of given name.
						/// 
						/// If an array is given instead of a single name, it is consumed (via <code>Array.prototype.shift</code>) piece by piece. Each element is interpreted as a property name of the current type, and the current type is replaced by that property's type. This is repeated until an element is encountered which cannot be resolved as a property name of the current type anymore; in this case, the last property found is returned and <code>vName</code> contains only the remaining names, with <code>vName[0]</code> being the one which was not found.
						/// 
						/// Examples: <ul> <li> Get address property of business partner: <pre>
						/// var oEntityType = oMetaModel.getODataEntityType("GWSAMPLE_BASIC.BusinessPartner"),
						///     oAddressProperty = oMetaModel.getODataProperty(oEntityType, "Address");
						/// oAddressProperty.name === "Address";
						/// oAddressProperty.type === "GWSAMPLE_BASIC.CT_Address";
						/// </pre> </li> <li> Get street property of address type: <pre>
						/// var oComplexType = oMetaModel.getODataComplexType("GWSAMPLE_BASIC.CT_Address"),
						///     oStreetProperty = oMetaModel.getODataProperty(oComplexType, "Street");
						/// oStreetProperty.name === "Street";
						/// oStreetProperty.type === "Edm.String";
						/// </pre> </li> <li> Get address' street property directly from business partner: <pre>
						/// var aParts = ["Address", "Street"];
						/// oMetaModel.getODataProperty(oEntityType, aParts) === oStreetProperty;
						/// aParts.length === 0;
						/// </pre> </li> <li> Trying to get address' foo property directly from business partner: <pre>
						/// aParts = ["Address", "foo"];
						/// oMetaModel.getODataProperty(oEntityType, aParts) === oAddressProperty;
						/// aParts.length === 1;
						/// aParts[0] === "foo";
						/// </pre> </li> </ul>
						/// </summary>
						/// <param name="oType">a complex type as returned by {@link #getODataComplexType getODataComplexType}, or an entity type as returned by {@link #getODataEntityType getODataEntityType}</param>
						/// <param name="vName">the name of a property within this type (e.g. "Address"), or an array of such names (e.g. <code>["Address", "Street"]</code>) in order to drill-down into complex types; <b>BEWARE</b> that this array is modified by removing each part which is understood!</param>
						/// <param name="bAsPath">determines whether the property is returned as a path or as an object</param>
						/// <returns>(the path to) the last OData property found; <code>undefined</code> (for a path) or <code>null</code> (for an object) if no property was found at all</returns>
						public extern virtual Union<object, string> getODataProperty(object oType, Union<string, string[]> vName, bool bAsPath = false);

						/// <summary>
						/// Returns a <code>Promise</code> which is resolved with a map representing the <code>com.sap.vocabularies.Common.v1.ValueList</code> annotations of the given property or rejected with an error. The key in the map provided on successful resolution is the qualifier of the annotation or the empty string if no qualifier is defined. The value in the map is the JSON object for the annotation. The map is empty if the property has no <code>com.sap.vocabularies.Common.v1.ValueList</code> annotations.
						/// </summary>
						/// <param name="oPropertyContext">a model context for a structural property of an entity type or a complex type, as returned by {@link #getMetaContext getMetaContext}</param>
						/// <returns>a Promise that gets resolved as soon as the value lists as well as the required model elements have been loaded</returns>
						public extern virtual jquery.JQueryPromise<object> getODataValueLists(sap.ui.model.Context oPropertyContext);

						/// <summary>
						/// Returns a promise which is fulfilled once the meta model data is loaded and can be used.
						/// </summary>
						/// <returns>a Promise</returns>
						public extern virtual jquery.JQueryPromise<object> loaded();

						/// <summary>
						/// Refresh not supported by OData meta model!
						/// </summary>
						public extern virtual void refresh();

						/// <summary>
						/// Legacy syntax not supported by OData meta model!
						/// </summary>
						/// <param name="bLegacySyntax">must not be true!</param>
						public extern override void setLegacySyntax(bool bLegacySyntax);

						#endregion

					}
				}
			}
		}
	}
}
