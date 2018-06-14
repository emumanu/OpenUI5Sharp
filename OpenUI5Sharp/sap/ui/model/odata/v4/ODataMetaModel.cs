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
					public static partial class v4
					{
						/// <summary>
						/// Implementation of an OData metadata model which offers access to OData V4 metadata. The meta model does not support any public events; attaching an event handler leads to an error.
						/// 
						/// This model is read-only.
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
							public partial class ObjectInfo
							{
								/// <summary>
								/// Optional scope for lookup of aliases for computed annotations (since 1.43.0)
								/// </summary>
								public object scope;

							}

							#endregion

							#region Constructor

							/// <summary>
							/// Do <strong>NOT</strong> call this private constructor, but rather use {@link sap.ui.model.odata.v4.ODataModel#getMetaModel} instead.
							/// </summary>
							/// <param name="oRequestor">The metadata requestor</param>
							/// <param name="sUrl">The URL to the $metadata document of the service</param>
							/// <param name="vAnnotationUri">The URL (or an array of URLs) from which the annotation metadata are loaded Supported since 1.41.0</param>
							/// <param name="oModel">The model this meta model is related to</param>
							/// <param name="bSupportReferences">Whether <code>&lt;edmx:Reference></code> and <code>&lt;edmx:Include></code> directives are supported in order to load schemas on demand from other $metadata documents and include them into the current service ("cross-service references").</param>
							public extern ODataMetaModel(object oRequestor, string sUrl, Union<string, string[]> vAnnotationUri, sap.ui.model.odata.v4.ODataModel oModel, bool bSupportReferences = true);

							/// <summary>
							/// Do <strong>NOT</strong> call this private constructor, but rather use {@link sap.ui.model.odata.v4.ODataModel#getMetaModel} instead.
							/// </summary>
							/// <param name="oRequestor">The metadata requestor</param>
							/// <param name="sUrl">The URL to the $metadata document of the service</param>
							/// <param name="vAnnotationUri">The URL (or an array of URLs) from which the annotation metadata are loaded Supported since 1.41.0</param>
							/// <param name="oModel">The model this meta model is related to</param>
							public extern ODataMetaModel(object oRequestor, string sUrl, Union<string, string[]> vAnnotationUri, sap.ui.model.odata.v4.ODataModel oModel);

							#endregion

							#region Methods

							/// <summary>
							/// Creates a list binding for this metadata model which iterates content from the given path (relative to the given context), sorted and filtered as indicated.
							/// 
							/// By default, OData names are iterated and a trailing slash is implicitly added to the path (see {@link #requestObject} for the effects this has); technical properties and inline annotations are filtered out.
							/// 
							/// A path which ends with an "@" segment can be used to iterate all inline or external targeting annotations; no trailing slash is added implicitly; technical properties and OData names are filtered out.
							/// </summary>
							/// <param name="sPath">A relative or absolute path within the metadata model, for example "/EMPLOYEES"</param>
							/// <param name="oContext">The context to be used as a starting point in case of a relative path</param>
							/// <param name="aSorters">Initial sort order, see {@link sap.ui.model.ListBinding#sort}</param>
							/// <param name="aFilters">Initial application filter(s), see {@link sap.ui.model.ListBinding#filter}</param>
							/// <returns>A list binding for this metadata model</returns>
							public extern virtual sap.ui.model.ListBinding bindList(string sPath, sap.ui.model.Context oContext, Union<sap.ui.model.Sorter, sap.ui.model.Sorter[]> aSorters, Union<sap.ui.model.Filter, sap.ui.model.Filter[]> aFilters);

							/// <summary>
							/// Creates a list binding for this metadata model which iterates content from the given path (relative to the given context), sorted and filtered as indicated.
							/// 
							/// By default, OData names are iterated and a trailing slash is implicitly added to the path (see {@link #requestObject} for the effects this has); technical properties and inline annotations are filtered out.
							/// 
							/// A path which ends with an "@" segment can be used to iterate all inline or external targeting annotations; no trailing slash is added implicitly; technical properties and OData names are filtered out.
							/// </summary>
							/// <param name="sPath">A relative or absolute path within the metadata model, for example "/EMPLOYEES"</param>
							/// <param name="oContext">The context to be used as a starting point in case of a relative path</param>
							/// <param name="aSorters">Initial sort order, see {@link sap.ui.model.ListBinding#sort}</param>
							/// <returns>A list binding for this metadata model</returns>
							public extern virtual sap.ui.model.ListBinding bindList(string sPath, sap.ui.model.Context oContext, Union<sap.ui.model.Sorter, sap.ui.model.Sorter[]> aSorters);

							/// <summary>
							/// Creates a list binding for this metadata model which iterates content from the given path (relative to the given context), sorted and filtered as indicated.
							/// 
							/// By default, OData names are iterated and a trailing slash is implicitly added to the path (see {@link #requestObject} for the effects this has); technical properties and inline annotations are filtered out.
							/// 
							/// A path which ends with an "@" segment can be used to iterate all inline or external targeting annotations; no trailing slash is added implicitly; technical properties and OData names are filtered out.
							/// </summary>
							/// <param name="sPath">A relative or absolute path within the metadata model, for example "/EMPLOYEES"</param>
							/// <param name="oContext">The context to be used as a starting point in case of a relative path</param>
							/// <returns>A list binding for this metadata model</returns>
							public extern virtual sap.ui.model.ListBinding bindList(string sPath, sap.ui.model.Context oContext);

							/// <summary>
							/// Creates a list binding for this metadata model which iterates content from the given path (relative to the given context), sorted and filtered as indicated.
							/// 
							/// By default, OData names are iterated and a trailing slash is implicitly added to the path (see {@link #requestObject} for the effects this has); technical properties and inline annotations are filtered out.
							/// 
							/// A path which ends with an "@" segment can be used to iterate all inline or external targeting annotations; no trailing slash is added implicitly; technical properties and OData names are filtered out.
							/// </summary>
							/// <param name="sPath">A relative or absolute path within the metadata model, for example "/EMPLOYEES"</param>
							/// <returns>A list binding for this metadata model</returns>
							public extern virtual sap.ui.model.ListBinding bindList(string sPath);

							/// <summary>
							/// Creates a property binding for this meta data model which refers to the content from the given path (relative to the given context).
							/// </summary>
							/// <param name="sPath">A relative or absolute path within the meta data model, for example "/EMPLOYEES/ENTRYDATE"</param>
							/// <param name="oContext">The context to be used as a starting point in case of a relative path</param>
							/// <param name="mParameters">Optional binding parameters that are passed to {@link #getObject} to compute the binding's value; if they are given, <code>oContext</code> cannot be omitted</param>
							/// <returns>A property binding for this meta data model</returns>
							public extern virtual sap.ui.model.PropertyBinding bindProperty(string sPath, sap.ui.model.Context oContext, sap.ui.model.odata.v4.ODataMetaModel.ObjectInfo mParameters);

							/// <summary>
							/// Creates a property binding for this meta data model which refers to the content from the given path (relative to the given context).
							/// </summary>
							/// <param name="sPath">A relative or absolute path within the meta data model, for example "/EMPLOYEES/ENTRYDATE"</param>
							/// <param name="oContext">The context to be used as a starting point in case of a relative path</param>
							/// <returns>A property binding for this meta data model</returns>
							public extern virtual sap.ui.model.PropertyBinding bindProperty(string sPath, sap.ui.model.Context oContext);

							/// <summary>
							/// Creates a property binding for this meta data model which refers to the content from the given path (relative to the given context).
							/// </summary>
							/// <param name="sPath">A relative or absolute path within the meta data model, for example "/EMPLOYEES/ENTRYDATE"</param>
							/// <returns>A property binding for this meta data model</returns>
							public extern virtual sap.ui.model.PropertyBinding bindProperty(string sPath);

							/// <summary>
							/// Method not supported
							/// </summary>
							public extern virtual void bindTree();

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.v4.ODataMetaModel with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.MetaModel.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <param name="oClassInfo">Object literal with information about the class</param>
							/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.v4.ODataMetaModel with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.MetaModel.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <param name="oClassInfo">Object literal with information about the class</param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName, object oClassInfo);

							/// <summary>
							/// Creates a new subclass of class sap.ui.model.odata.v4.ODataMetaModel with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
							/// 
							/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.MetaModel.extend}.
							/// </summary>
							/// <param name="sClassName">Name of the class being created</param>
							/// <returns>Created class / constructor function</returns>
							public extern static object extend(string sClassName);

							/// <summary>
							/// Returns a map of entity tags for each $metadata or annotation file loaded so far.
							/// </summary>
							/// <returns>A map which contains one entry for each $metadata or annotation file loaded so far: the key is the file's URL as a <code>string</code> and the value is the <code>string</code> value of the "ETag" response header for that file. Initially, the map is empty. If no "ETag" response header was sent for a file, the <code>Date</code> value of the "Last-Modified" response header is used instead. The value <code>null</code> is used in case no such header is sent at all. Note that this map may change due to load-on-demand of "cross-service references" (see parameter <code>supportReferences</code> of {@link sap.ui.model.odata.v4.ODataModel#constructor}).</returns>
							public extern virtual object getETags();

							/// <summary>
							/// Returns the maximum value of all "Last-Modified" response headers seen so far.
							/// </summary>
							[Obsolete("Deprecated since 1.51.0. use {@link #getETags} instead because modifications to old files may be shadowed by a new file in certain scenarios.")]
							/// <returns>The maximum value of all "Last-Modified" (or, as a fallback, "Date") response headers seen so far when loading $metadata or annotation files. It is <code>new Date(0)</code> initially as long as no such files have been loaded. It becomes <code>new Date()</code> as soon as a file without such a header is loaded. Note that this value may change due to load-on-demand of "cross-service references" (see parameter <code>supportReferences</code> of {@link sap.ui.model.odata.v4.ODataModel#constructor}).</returns>
							public extern virtual System.DateTime getLastModified();

							/// <summary>
							/// Returns the OData metadata model context corresponding to the given OData data model path.
							/// </summary>
							/// <param name="sPath">An absolute data path within the OData data model, for example "/EMPLOYEES/0/ENTRYDATE"</param>
							/// <returns>The corresponding metadata context within the OData metadata model, for example with metadata path "/EMPLOYEES/ENTRYDATE"</returns>
							public extern virtual sap.ui.model.Context getMetaContext(string sPath);

							/// <summary>
							/// Returns a metadata object for class sap.ui.model.odata.v4.ODataMetaModel.
							/// </summary>
							/// <returns>Metadata object describing this class</returns>
							public extern static sap.ui.@base.Metadata getMetadata();

							/// <summary>
							/// Returns the metadata object for the given path relative to the given context. Returns <code>undefined</code> in case the metadata is not (yet) available. Use {@link #requestObject} for asynchronous access.
							/// </summary>
							/// <param name="sPath">A relative or absolute path within the metadata model</param>
							/// <param name="oContext">The context to be used as a starting point in case of a relative path</param>
							/// <param name="mParameters">Optional (binding) parameters; if they are given, <code>oContext</code> cannot be omitted</param>
							/// <returns>The requested metadata object if it is already available, or <code>undefined</code></returns>
							public extern virtual object getObject(string sPath, sap.ui.model.Context oContext, sap.ui.model.odata.v4.ODataMetaModel.ObjectInfo mParameters);

							/// <summary>
							/// Returns the metadata object for the given path relative to the given context. Returns <code>undefined</code> in case the metadata is not (yet) available. Use {@link #requestObject} for asynchronous access.
							/// </summary>
							/// <param name="sPath">A relative or absolute path within the metadata model</param>
							/// <param name="oContext">The context to be used as a starting point in case of a relative path</param>
							/// <returns>The requested metadata object if it is already available, or <code>undefined</code></returns>
							public extern virtual object getObject(string sPath, sap.ui.model.Context oContext);

							/// <summary>
							/// Returns the metadata object for the given path relative to the given context. Returns <code>undefined</code> in case the metadata is not (yet) available. Use {@link #requestObject} for asynchronous access.
							/// </summary>
							/// <param name="sPath">A relative or absolute path within the metadata model</param>
							/// <returns>The requested metadata object if it is already available, or <code>undefined</code></returns>
							public extern virtual object getObject(string sPath);

							/// <summary>
							/// Method not supported
							/// </summary>
							public extern virtual void getOriginalProperty();

							[Obsolete("Deprecated since 1.37.0. use {@link #getObject}.")]
							public extern virtual void getProperty();

							/// <summary>
							/// Returns the UI5 type for the given property path that formats and parses corresponding to the property's EDM type and constraints. The property's type must be a primitive type. Use {@link #requestUI5Type} for asynchronous access.
							/// </summary>
							/// <param name="sPath">An absolute path to an OData property within the OData data model</param>
							/// <returns>The corresponding UI5 type from {@link sap.ui.model.odata.type}, if all required metadata to calculate this type is already available; if no specific type can be determined, a warning is logged and {@link sap.ui.model.odata.type.Raw} is used</returns>
							public extern virtual sap.ui.model.odata.type.ODataType getUI5Type(string sPath);

							/// <summary>
							/// Determines which type of value list exists for the given property.
							/// </summary>
							/// <param name="sPropertyPath">An absolute path to an OData property within the OData data model</param>
							/// <returns>The type of the value list</returns>
							public extern virtual sap.ui.model.odata.v4.ValueListType getValueListType(string sPropertyPath);

							/// <summary>
							/// Method not supported
							/// </summary>
							public extern virtual void refresh();

							/// <summary>
							/// Requests the metadata value for the given path relative to the given context. Returns a <code>Promise</code> which is resolved with the requested metadata value or rejected with an error (only in case metadata cannot be loaded). An invalid path leads to an <code>undefined</code> result and a warning is logged. Use {@link #getObject} for synchronous access.
							/// 
							/// A relative path is appended to the context's path separated by a forward slash("/"). A relative path starting with "@" (that is, an annotation) is appended without a separator. Use "./" as a prefix for such a relative path to enforce a separator.
							/// 
							/// Example: <pre>
							/// &lt;template:with path="/EMPLOYEES/ENTRYDATE" var="property">
							///   &lt;!-- /EMPLOYEES/ENTRYDATE/$Type -->
							///   "{property>$Type}"
							/// 
							///   &lt;!-- /EMPLOYEES/ENTRYDATE@com.sap.vocabularies.Common.v1.Text -->
							///   "{property>@com.sap.vocabularies.Common.v1.Text}"
							/// 
							///   &lt;!-- /EMPLOYEES/ENTRYDATE/@com.sap.vocabularies.Common.v1.Text -->
							///   "{property>./@com.sap.vocabularies.Common.v1.Text}"
							/// &lt;/template:with>
							/// </pre>
							/// 
							/// The basic idea is that every path described in "14.2.1 Attribute Target" in specification "OData Version 4.0 Part 3: Common Schema Definition Language" is a valid absolute path within the metadata model if a leading slash is added; for example "/" + "MySchema.MyEntityContainer/MyEntitySet/MyComplexProperty/MyNavigationProperty". Also, every path described in "14.5.2 Expression edm:AnnotationPath", "14.5.11 Expression edm:NavigationPropertyPath", "14.5.12 Expression edm:Path", and "14.5.13 Expression edm:PropertyPath" is a valid relative path within the metadata model if a suitable prefix is added which addresses an entity container, entity set, singleton, complex type, entity type, or property; for example "/MySchema.MyEntityType/MyProperty" + "@vCard.Address#work/FullName".
							/// 
							/// The absolute path is split into segments and followed step-by-step, starting at the global scope of all known qualified OData names. There are two technical properties there: "$Version" (typically "4.0") and "$EntityContainer" with the name of the single entity container for this metadata model's service.
							/// 
							/// An empty segment in between is invalid. An empty segment at the end caused by a trailing slash differentiates between a name and the object it refers to. This way, "/$EntityContainer" refers to the name of the single entity container and "/$EntityContainer/" refers to the single entity container as an object.
							/// 
							/// The segment "@sapui.name" refers back to the last OData name (simple identifier or qualified name) or annotation name encountered during path traversal immediately before "@sapui.name": <ul> <li> "/EMPLOYEES@sapui.name" results in "EMPLOYEES" and "/EMPLOYEES/@sapui.name" results in the same as "/EMPLOYEES/$Type", that is, the qualified name of the entity set's type (see below how "$Type" is inserted implicitly). Note how the separating slash again makes a difference here. <li> "/EMPLOYEES/@com.sap.vocabularies.Common.v1.Label@sapui.name" results in "@com.sap.vocabularies.Common.v1.Label" and a slash does not make any difference as long as the annotation does not have a "$Type" property. <li> A technical property (that is, a numerical segment or one starting with a "$") immediately before "@sapui.name" is invalid, for example "/$EntityContainer@sapui.name". </ul> The path must not continue after "@sapui.name".
							/// 
							/// If the current object is a string value, that string value is treated as a relative path and followed step-by-step before the next segment is processed. Except for this, a path must not continue if it comes across a non-object value. Such a string value can be a qualified name (example path "/$EntityContainer/..."), a simple identifier (example path "/TEAMS/$NavigationPropertyBinding/TEAM_2_EMPLOYEES/...") or even a path according to "14.5.12 Expression edm:Path" etc. (example path "/TEAMS/$Type/@com.sap.vocabularies.UI.v1.LineItem/0/Value/$Path/...").
							/// 
							/// Segments starting with an "@" character, for example "@com.sap.vocabularies.Common.v1.Label", address annotations at the current object. As the first segment, they refer to the single entity container. For objects which can only be annotated inline (see "14.3 Element edm:Annotation" minus "14.2.1 Attribute Target"), the object already contains the annotations as a property. For objects which can (only or also) be annotated via external targeting, the object does not contain any annotation as a property. Such annotations MUST be accessed via a path. BEWARE of a special case: Actions, functions and their parameters can be annotated inline for a single overload or via external targeting for all overloads at the same time. In this case, the object contains all annotations for the single overload as a property, but annotations MUST nevertheless be accessed via a path in order to include also annotations for all overloads at the same time.
							/// 
							/// Segments starting with an OData name followed by an "@" character, for example "/TEAMS@Org.OData.Capabilities.V1.TopSupported", address annotations at an entity set, singleton, or property, not at the corresponding type. In contrast, "/TEAMS/@com.sap.vocabularies.Common.v1.Deletable" (note the separating slash) addresses an annotation at the entity set's type. This is in line with the special rule of "14.5.12 Expression edm:Path" regarding annotations at a navigation property itself.
							/// 
							/// "@" can be used as a segment to address a map of all annotations of the current object. This is useful for iteration, for example via <code>&lt;template:repeat list="{entityType>@}" ...></code>.
							/// 
							/// Annotations of an annotation are addressed not by two separate segments, but by a single segment like "@com.sap.vocabularies.Common.v1.Text@com.sap.vocabularies.Common.v1.TextArrangement". Each annotation can have a qualifier, for example "@first#foo@second#bar". Note: If the first annotation's value is a record, a separate segment addresses an annotation of that record, not an annotation of the first annotation itself. In a similar way, annotations of "7.2 Element edm:ReferentialConstraint", "7.3 Element edm:OnDelete", "10.2 Element edm:Member" and "14.5.14.2 Element edm:PropertyValue" are addressed by segments like "&lt;7.2.1 Attribute Property>@...", "$OnDelete@...", "&lt;10.2.1 Attribute Name>@..." and "&lt;14.5.14.2.1 Attribute Property>@..." (where angle brackets denote a variable part and sections refer to specification "OData Version 4.0 Part 3: Common Schema Definition Language").
							/// 
							/// Annotations starting with "@@", for example "@@sap.ui.model.odata.v4.AnnotationHelper.isMultiple" or "@@.AH.isMultiple" or "@@.isMultiple", represent computed annotations. Their name without the "@@" prefix must refer to a function either in the global namespace (in case of an absolute name) or in <code>mParameters.scope</code> (in case of a relative name starting with a dot, which is stripped before lookup; see the <code>&lt;template:alias></code> instruction for XML Templating). This function is called with the current object (or primitive value) and additional details and returns the result of this {@link #requestObject} call. The additional details are given as an object with the following properties: <ul> <li><code>{@link sap.ui.model.Context} context</code> Points to the current object <li><code>{string} schemaChildName</code> The qualified name of the schema child where the computed annotation has been found </ul> Computed annotations cannot be iterated by "@". The path must not continue after a computed annotation.
							/// 
							/// A segment which represents an OData qualified name is looked up in the global scope ("scope lookup") and thus determines a schema child which is used later on. Unknown qualified names are invalid. This way, "/acme.DefaultContainer/EMPLOYEES" addresses the "EMPLOYEES" child of the schema child named "acme.DefaultContainer". This also works indirectly ("/$EntityContainer/EMPLOYEES") and implicitly ("/EMPLOYEES", see below).
							/// 
							/// A segment which represents an OData simple identifier needs special preparations. The same applies to the empty segment after a trailing slash. <ol> <li> If the current object has a "$Action", "$Function" or "$Type" property, it is used for scope lookup first. This way, "/EMPLOYEES/ENTRYDATE" addresses the same object as "/EMPLOYEES/$Type/ENTRYDATE", namely the "ENTRYDATE" child of the entity type corresponding to the "EMPLOYEES" child of the entity container. The other cases jump from an action or function import to the corresponding action or function overloads. <li> Else if the segment is the first one within its path, the last schema child addressed via scope lookup is used instead of the current object. This can only happen indirectly as in "/TEAMS/$NavigationPropertyBinding/TEAM_2_EMPLOYEES/..." where the schema child is the entity container and the navigation property binding can contain the simple identifier of another entity set within the same container.
							/// 
							/// If the segment is the first one overall, "$EntityContainer" is inserted into the path implicitly. In other words, the entity container is used as the initial schema child. This way, "/EMPLOYEES" addresses the same object as "/$EntityContainer/EMPLOYEES", namely the "EMPLOYEES" child of the entity container. <li> Afterwards, if the current object is an array, it represents overloads for an action or function. Multiple overloads are invalid. The overload's "$ReturnType/$Type" is used for scope lookup. This way, "/GetOldestWorker/AGE" addresses the same object as "/GetOldestWorker/0/$ReturnType/$Type/AGE". For primitive return types, the special segment "value" can be used to refer to the return type itself (see {@link sap.ui.model.odata.v4.ODataContextBinding#execute}). This way, "/GetOldestAge/value" addresses the same object as "/GetOldestAge/0/$ReturnType" (which is needed for automatic type determination, see {@link #requestUI5Type}). </ol>
							/// 
							/// A trailing slash can be used to continue a path and thus force scope lookup or OData simple identifier preparations, but then stay at the current object. This way, "/EMPLOYEES/$Type/" addresses the entity type itself corresponding to the "EMPLOYEES" child of the entity container. Although the empty segment is not an OData simple identifier, it can be used as a placeholder for one. In this way, "/EMPLOYEES/" addresses the same entity type as "/EMPLOYEES/$Type/". That entity type in turn is a map of all its OData children (that is, structural and navigation properties) and determines the set of possible child names that might be used after the trailing slash.
							/// 
							/// Any other segment, including an OData simple identifier, is looked up as a property of the current object.
							/// </summary>
							/// <param name="sPath">A relative or absolute path within the metadata model</param>
							/// <param name="oContext">The context to be used as a starting point in case of a relative path</param>
							/// <param name="mParameters">Optional (binding) parameters; if they are given, <code>oContext</code> cannot be omitted</param>
							/// <returns>A promise which is resolved with the requested metadata value as soon as it is available</returns>
							public extern virtual jquery.JQueryPromise<object> requestObject(string sPath, sap.ui.model.Context oContext, sap.ui.model.odata.v4.ODataMetaModel.ObjectInfo mParameters);

							/// <summary>
							/// Requests the metadata value for the given path relative to the given context. Returns a <code>Promise</code> which is resolved with the requested metadata value or rejected with an error (only in case metadata cannot be loaded). An invalid path leads to an <code>undefined</code> result and a warning is logged. Use {@link #getObject} for synchronous access.
							/// 
							/// A relative path is appended to the context's path separated by a forward slash("/"). A relative path starting with "@" (that is, an annotation) is appended without a separator. Use "./" as a prefix for such a relative path to enforce a separator.
							/// 
							/// Example: <pre>
							/// &lt;template:with path="/EMPLOYEES/ENTRYDATE" var="property">
							///   &lt;!-- /EMPLOYEES/ENTRYDATE/$Type -->
							///   "{property>$Type}"
							/// 
							///   &lt;!-- /EMPLOYEES/ENTRYDATE@com.sap.vocabularies.Common.v1.Text -->
							///   "{property>@com.sap.vocabularies.Common.v1.Text}"
							/// 
							///   &lt;!-- /EMPLOYEES/ENTRYDATE/@com.sap.vocabularies.Common.v1.Text -->
							///   "{property>./@com.sap.vocabularies.Common.v1.Text}"
							/// &lt;/template:with>
							/// </pre>
							/// 
							/// The basic idea is that every path described in "14.2.1 Attribute Target" in specification "OData Version 4.0 Part 3: Common Schema Definition Language" is a valid absolute path within the metadata model if a leading slash is added; for example "/" + "MySchema.MyEntityContainer/MyEntitySet/MyComplexProperty/MyNavigationProperty". Also, every path described in "14.5.2 Expression edm:AnnotationPath", "14.5.11 Expression edm:NavigationPropertyPath", "14.5.12 Expression edm:Path", and "14.5.13 Expression edm:PropertyPath" is a valid relative path within the metadata model if a suitable prefix is added which addresses an entity container, entity set, singleton, complex type, entity type, or property; for example "/MySchema.MyEntityType/MyProperty" + "@vCard.Address#work/FullName".
							/// 
							/// The absolute path is split into segments and followed step-by-step, starting at the global scope of all known qualified OData names. There are two technical properties there: "$Version" (typically "4.0") and "$EntityContainer" with the name of the single entity container for this metadata model's service.
							/// 
							/// An empty segment in between is invalid. An empty segment at the end caused by a trailing slash differentiates between a name and the object it refers to. This way, "/$EntityContainer" refers to the name of the single entity container and "/$EntityContainer/" refers to the single entity container as an object.
							/// 
							/// The segment "@sapui.name" refers back to the last OData name (simple identifier or qualified name) or annotation name encountered during path traversal immediately before "@sapui.name": <ul> <li> "/EMPLOYEES@sapui.name" results in "EMPLOYEES" and "/EMPLOYEES/@sapui.name" results in the same as "/EMPLOYEES/$Type", that is, the qualified name of the entity set's type (see below how "$Type" is inserted implicitly). Note how the separating slash again makes a difference here. <li> "/EMPLOYEES/@com.sap.vocabularies.Common.v1.Label@sapui.name" results in "@com.sap.vocabularies.Common.v1.Label" and a slash does not make any difference as long as the annotation does not have a "$Type" property. <li> A technical property (that is, a numerical segment or one starting with a "$") immediately before "@sapui.name" is invalid, for example "/$EntityContainer@sapui.name". </ul> The path must not continue after "@sapui.name".
							/// 
							/// If the current object is a string value, that string value is treated as a relative path and followed step-by-step before the next segment is processed. Except for this, a path must not continue if it comes across a non-object value. Such a string value can be a qualified name (example path "/$EntityContainer/..."), a simple identifier (example path "/TEAMS/$NavigationPropertyBinding/TEAM_2_EMPLOYEES/...") or even a path according to "14.5.12 Expression edm:Path" etc. (example path "/TEAMS/$Type/@com.sap.vocabularies.UI.v1.LineItem/0/Value/$Path/...").
							/// 
							/// Segments starting with an "@" character, for example "@com.sap.vocabularies.Common.v1.Label", address annotations at the current object. As the first segment, they refer to the single entity container. For objects which can only be annotated inline (see "14.3 Element edm:Annotation" minus "14.2.1 Attribute Target"), the object already contains the annotations as a property. For objects which can (only or also) be annotated via external targeting, the object does not contain any annotation as a property. Such annotations MUST be accessed via a path. BEWARE of a special case: Actions, functions and their parameters can be annotated inline for a single overload or via external targeting for all overloads at the same time. In this case, the object contains all annotations for the single overload as a property, but annotations MUST nevertheless be accessed via a path in order to include also annotations for all overloads at the same time.
							/// 
							/// Segments starting with an OData name followed by an "@" character, for example "/TEAMS@Org.OData.Capabilities.V1.TopSupported", address annotations at an entity set, singleton, or property, not at the corresponding type. In contrast, "/TEAMS/@com.sap.vocabularies.Common.v1.Deletable" (note the separating slash) addresses an annotation at the entity set's type. This is in line with the special rule of "14.5.12 Expression edm:Path" regarding annotations at a navigation property itself.
							/// 
							/// "@" can be used as a segment to address a map of all annotations of the current object. This is useful for iteration, for example via <code>&lt;template:repeat list="{entityType>@}" ...></code>.
							/// 
							/// Annotations of an annotation are addressed not by two separate segments, but by a single segment like "@com.sap.vocabularies.Common.v1.Text@com.sap.vocabularies.Common.v1.TextArrangement". Each annotation can have a qualifier, for example "@first#foo@second#bar". Note: If the first annotation's value is a record, a separate segment addresses an annotation of that record, not an annotation of the first annotation itself. In a similar way, annotations of "7.2 Element edm:ReferentialConstraint", "7.3 Element edm:OnDelete", "10.2 Element edm:Member" and "14.5.14.2 Element edm:PropertyValue" are addressed by segments like "&lt;7.2.1 Attribute Property>@...", "$OnDelete@...", "&lt;10.2.1 Attribute Name>@..." and "&lt;14.5.14.2.1 Attribute Property>@..." (where angle brackets denote a variable part and sections refer to specification "OData Version 4.0 Part 3: Common Schema Definition Language").
							/// 
							/// Annotations starting with "@@", for example "@@sap.ui.model.odata.v4.AnnotationHelper.isMultiple" or "@@.AH.isMultiple" or "@@.isMultiple", represent computed annotations. Their name without the "@@" prefix must refer to a function either in the global namespace (in case of an absolute name) or in <code>mParameters.scope</code> (in case of a relative name starting with a dot, which is stripped before lookup; see the <code>&lt;template:alias></code> instruction for XML Templating). This function is called with the current object (or primitive value) and additional details and returns the result of this {@link #requestObject} call. The additional details are given as an object with the following properties: <ul> <li><code>{@link sap.ui.model.Context} context</code> Points to the current object <li><code>{string} schemaChildName</code> The qualified name of the schema child where the computed annotation has been found </ul> Computed annotations cannot be iterated by "@". The path must not continue after a computed annotation.
							/// 
							/// A segment which represents an OData qualified name is looked up in the global scope ("scope lookup") and thus determines a schema child which is used later on. Unknown qualified names are invalid. This way, "/acme.DefaultContainer/EMPLOYEES" addresses the "EMPLOYEES" child of the schema child named "acme.DefaultContainer". This also works indirectly ("/$EntityContainer/EMPLOYEES") and implicitly ("/EMPLOYEES", see below).
							/// 
							/// A segment which represents an OData simple identifier needs special preparations. The same applies to the empty segment after a trailing slash. <ol> <li> If the current object has a "$Action", "$Function" or "$Type" property, it is used for scope lookup first. This way, "/EMPLOYEES/ENTRYDATE" addresses the same object as "/EMPLOYEES/$Type/ENTRYDATE", namely the "ENTRYDATE" child of the entity type corresponding to the "EMPLOYEES" child of the entity container. The other cases jump from an action or function import to the corresponding action or function overloads. <li> Else if the segment is the first one within its path, the last schema child addressed via scope lookup is used instead of the current object. This can only happen indirectly as in "/TEAMS/$NavigationPropertyBinding/TEAM_2_EMPLOYEES/..." where the schema child is the entity container and the navigation property binding can contain the simple identifier of another entity set within the same container.
							/// 
							/// If the segment is the first one overall, "$EntityContainer" is inserted into the path implicitly. In other words, the entity container is used as the initial schema child. This way, "/EMPLOYEES" addresses the same object as "/$EntityContainer/EMPLOYEES", namely the "EMPLOYEES" child of the entity container. <li> Afterwards, if the current object is an array, it represents overloads for an action or function. Multiple overloads are invalid. The overload's "$ReturnType/$Type" is used for scope lookup. This way, "/GetOldestWorker/AGE" addresses the same object as "/GetOldestWorker/0/$ReturnType/$Type/AGE". For primitive return types, the special segment "value" can be used to refer to the return type itself (see {@link sap.ui.model.odata.v4.ODataContextBinding#execute}). This way, "/GetOldestAge/value" addresses the same object as "/GetOldestAge/0/$ReturnType" (which is needed for automatic type determination, see {@link #requestUI5Type}). </ol>
							/// 
							/// A trailing slash can be used to continue a path and thus force scope lookup or OData simple identifier preparations, but then stay at the current object. This way, "/EMPLOYEES/$Type/" addresses the entity type itself corresponding to the "EMPLOYEES" child of the entity container. Although the empty segment is not an OData simple identifier, it can be used as a placeholder for one. In this way, "/EMPLOYEES/" addresses the same entity type as "/EMPLOYEES/$Type/". That entity type in turn is a map of all its OData children (that is, structural and navigation properties) and determines the set of possible child names that might be used after the trailing slash.
							/// 
							/// Any other segment, including an OData simple identifier, is looked up as a property of the current object.
							/// </summary>
							/// <param name="sPath">A relative or absolute path within the metadata model</param>
							/// <param name="oContext">The context to be used as a starting point in case of a relative path</param>
							/// <returns>A promise which is resolved with the requested metadata value as soon as it is available</returns>
							public extern virtual jquery.JQueryPromise<object> requestObject(string sPath, sap.ui.model.Context oContext);

							/// <summary>
							/// Requests the metadata value for the given path relative to the given context. Returns a <code>Promise</code> which is resolved with the requested metadata value or rejected with an error (only in case metadata cannot be loaded). An invalid path leads to an <code>undefined</code> result and a warning is logged. Use {@link #getObject} for synchronous access.
							/// 
							/// A relative path is appended to the context's path separated by a forward slash("/"). A relative path starting with "@" (that is, an annotation) is appended without a separator. Use "./" as a prefix for such a relative path to enforce a separator.
							/// 
							/// Example: <pre>
							/// &lt;template:with path="/EMPLOYEES/ENTRYDATE" var="property">
							///   &lt;!-- /EMPLOYEES/ENTRYDATE/$Type -->
							///   "{property>$Type}"
							/// 
							///   &lt;!-- /EMPLOYEES/ENTRYDATE@com.sap.vocabularies.Common.v1.Text -->
							///   "{property>@com.sap.vocabularies.Common.v1.Text}"
							/// 
							///   &lt;!-- /EMPLOYEES/ENTRYDATE/@com.sap.vocabularies.Common.v1.Text -->
							///   "{property>./@com.sap.vocabularies.Common.v1.Text}"
							/// &lt;/template:with>
							/// </pre>
							/// 
							/// The basic idea is that every path described in "14.2.1 Attribute Target" in specification "OData Version 4.0 Part 3: Common Schema Definition Language" is a valid absolute path within the metadata model if a leading slash is added; for example "/" + "MySchema.MyEntityContainer/MyEntitySet/MyComplexProperty/MyNavigationProperty". Also, every path described in "14.5.2 Expression edm:AnnotationPath", "14.5.11 Expression edm:NavigationPropertyPath", "14.5.12 Expression edm:Path", and "14.5.13 Expression edm:PropertyPath" is a valid relative path within the metadata model if a suitable prefix is added which addresses an entity container, entity set, singleton, complex type, entity type, or property; for example "/MySchema.MyEntityType/MyProperty" + "@vCard.Address#work/FullName".
							/// 
							/// The absolute path is split into segments and followed step-by-step, starting at the global scope of all known qualified OData names. There are two technical properties there: "$Version" (typically "4.0") and "$EntityContainer" with the name of the single entity container for this metadata model's service.
							/// 
							/// An empty segment in between is invalid. An empty segment at the end caused by a trailing slash differentiates between a name and the object it refers to. This way, "/$EntityContainer" refers to the name of the single entity container and "/$EntityContainer/" refers to the single entity container as an object.
							/// 
							/// The segment "@sapui.name" refers back to the last OData name (simple identifier or qualified name) or annotation name encountered during path traversal immediately before "@sapui.name": <ul> <li> "/EMPLOYEES@sapui.name" results in "EMPLOYEES" and "/EMPLOYEES/@sapui.name" results in the same as "/EMPLOYEES/$Type", that is, the qualified name of the entity set's type (see below how "$Type" is inserted implicitly). Note how the separating slash again makes a difference here. <li> "/EMPLOYEES/@com.sap.vocabularies.Common.v1.Label@sapui.name" results in "@com.sap.vocabularies.Common.v1.Label" and a slash does not make any difference as long as the annotation does not have a "$Type" property. <li> A technical property (that is, a numerical segment or one starting with a "$") immediately before "@sapui.name" is invalid, for example "/$EntityContainer@sapui.name". </ul> The path must not continue after "@sapui.name".
							/// 
							/// If the current object is a string value, that string value is treated as a relative path and followed step-by-step before the next segment is processed. Except for this, a path must not continue if it comes across a non-object value. Such a string value can be a qualified name (example path "/$EntityContainer/..."), a simple identifier (example path "/TEAMS/$NavigationPropertyBinding/TEAM_2_EMPLOYEES/...") or even a path according to "14.5.12 Expression edm:Path" etc. (example path "/TEAMS/$Type/@com.sap.vocabularies.UI.v1.LineItem/0/Value/$Path/...").
							/// 
							/// Segments starting with an "@" character, for example "@com.sap.vocabularies.Common.v1.Label", address annotations at the current object. As the first segment, they refer to the single entity container. For objects which can only be annotated inline (see "14.3 Element edm:Annotation" minus "14.2.1 Attribute Target"), the object already contains the annotations as a property. For objects which can (only or also) be annotated via external targeting, the object does not contain any annotation as a property. Such annotations MUST be accessed via a path. BEWARE of a special case: Actions, functions and their parameters can be annotated inline for a single overload or via external targeting for all overloads at the same time. In this case, the object contains all annotations for the single overload as a property, but annotations MUST nevertheless be accessed via a path in order to include also annotations for all overloads at the same time.
							/// 
							/// Segments starting with an OData name followed by an "@" character, for example "/TEAMS@Org.OData.Capabilities.V1.TopSupported", address annotations at an entity set, singleton, or property, not at the corresponding type. In contrast, "/TEAMS/@com.sap.vocabularies.Common.v1.Deletable" (note the separating slash) addresses an annotation at the entity set's type. This is in line with the special rule of "14.5.12 Expression edm:Path" regarding annotations at a navigation property itself.
							/// 
							/// "@" can be used as a segment to address a map of all annotations of the current object. This is useful for iteration, for example via <code>&lt;template:repeat list="{entityType>@}" ...></code>.
							/// 
							/// Annotations of an annotation are addressed not by two separate segments, but by a single segment like "@com.sap.vocabularies.Common.v1.Text@com.sap.vocabularies.Common.v1.TextArrangement". Each annotation can have a qualifier, for example "@first#foo@second#bar". Note: If the first annotation's value is a record, a separate segment addresses an annotation of that record, not an annotation of the first annotation itself. In a similar way, annotations of "7.2 Element edm:ReferentialConstraint", "7.3 Element edm:OnDelete", "10.2 Element edm:Member" and "14.5.14.2 Element edm:PropertyValue" are addressed by segments like "&lt;7.2.1 Attribute Property>@...", "$OnDelete@...", "&lt;10.2.1 Attribute Name>@..." and "&lt;14.5.14.2.1 Attribute Property>@..." (where angle brackets denote a variable part and sections refer to specification "OData Version 4.0 Part 3: Common Schema Definition Language").
							/// 
							/// Annotations starting with "@@", for example "@@sap.ui.model.odata.v4.AnnotationHelper.isMultiple" or "@@.AH.isMultiple" or "@@.isMultiple", represent computed annotations. Their name without the "@@" prefix must refer to a function either in the global namespace (in case of an absolute name) or in <code>mParameters.scope</code> (in case of a relative name starting with a dot, which is stripped before lookup; see the <code>&lt;template:alias></code> instruction for XML Templating). This function is called with the current object (or primitive value) and additional details and returns the result of this {@link #requestObject} call. The additional details are given as an object with the following properties: <ul> <li><code>{@link sap.ui.model.Context} context</code> Points to the current object <li><code>{string} schemaChildName</code> The qualified name of the schema child where the computed annotation has been found </ul> Computed annotations cannot be iterated by "@". The path must not continue after a computed annotation.
							/// 
							/// A segment which represents an OData qualified name is looked up in the global scope ("scope lookup") and thus determines a schema child which is used later on. Unknown qualified names are invalid. This way, "/acme.DefaultContainer/EMPLOYEES" addresses the "EMPLOYEES" child of the schema child named "acme.DefaultContainer". This also works indirectly ("/$EntityContainer/EMPLOYEES") and implicitly ("/EMPLOYEES", see below).
							/// 
							/// A segment which represents an OData simple identifier needs special preparations. The same applies to the empty segment after a trailing slash. <ol> <li> If the current object has a "$Action", "$Function" or "$Type" property, it is used for scope lookup first. This way, "/EMPLOYEES/ENTRYDATE" addresses the same object as "/EMPLOYEES/$Type/ENTRYDATE", namely the "ENTRYDATE" child of the entity type corresponding to the "EMPLOYEES" child of the entity container. The other cases jump from an action or function import to the corresponding action or function overloads. <li> Else if the segment is the first one within its path, the last schema child addressed via scope lookup is used instead of the current object. This can only happen indirectly as in "/TEAMS/$NavigationPropertyBinding/TEAM_2_EMPLOYEES/..." where the schema child is the entity container and the navigation property binding can contain the simple identifier of another entity set within the same container.
							/// 
							/// If the segment is the first one overall, "$EntityContainer" is inserted into the path implicitly. In other words, the entity container is used as the initial schema child. This way, "/EMPLOYEES" addresses the same object as "/$EntityContainer/EMPLOYEES", namely the "EMPLOYEES" child of the entity container. <li> Afterwards, if the current object is an array, it represents overloads for an action or function. Multiple overloads are invalid. The overload's "$ReturnType/$Type" is used for scope lookup. This way, "/GetOldestWorker/AGE" addresses the same object as "/GetOldestWorker/0/$ReturnType/$Type/AGE". For primitive return types, the special segment "value" can be used to refer to the return type itself (see {@link sap.ui.model.odata.v4.ODataContextBinding#execute}). This way, "/GetOldestAge/value" addresses the same object as "/GetOldestAge/0/$ReturnType" (which is needed for automatic type determination, see {@link #requestUI5Type}). </ol>
							/// 
							/// A trailing slash can be used to continue a path and thus force scope lookup or OData simple identifier preparations, but then stay at the current object. This way, "/EMPLOYEES/$Type/" addresses the entity type itself corresponding to the "EMPLOYEES" child of the entity container. Although the empty segment is not an OData simple identifier, it can be used as a placeholder for one. In this way, "/EMPLOYEES/" addresses the same entity type as "/EMPLOYEES/$Type/". That entity type in turn is a map of all its OData children (that is, structural and navigation properties) and determines the set of possible child names that might be used after the trailing slash.
							/// 
							/// Any other segment, including an OData simple identifier, is looked up as a property of the current object.
							/// </summary>
							/// <param name="sPath">A relative or absolute path within the metadata model</param>
							/// <returns>A promise which is resolved with the requested metadata value as soon as it is available</returns>
							public extern virtual jquery.JQueryPromise<object> requestObject(string sPath);

							/// <summary>
							/// Requests the UI5 type for the given property path that formats and parses corresponding to the property's EDM type and constraints. The property's type must be a primitive type. Use {@link #getUI5Type} for synchronous access.
							/// </summary>
							/// <param name="sPath">An absolute path to an OData property within the OData data model</param>
							/// <returns>A promise that gets resolved with the corresponding UI5 type from {@link sap.ui.model.odata.type}; if no specific type can be determined, a warning is logged and {@link sap.ui.model.odata.type.Raw} is used</returns>
							public extern virtual jquery.JQueryPromise<object> requestUI5Type(string sPath);

							/// <summary>
							/// Requests information to retrieve a value list for the property given by <code>sPropertyPath</code>.
							/// </summary>
							/// <param name="sPropertyPath">An absolute path to an OData property within the OData data model</param>
							/// <returns>A promise which is resolved with a map of qualifier to value list mapping objects structured as defined by <code>com.sap.vocabularies.Common.v1.ValueListMappingType</code>; the map entry with key "" represents the mapping without qualifier. Each entry has an additional property "$model" which is the {@link sap.ui.model.odata.v4.ODataModel} instance to read value list data via this mapping.
							/// 
							/// For fixed values, only one mapping is expected and the qualifier is ignored. The mapping is available with key "".
							/// 
							/// The promise is rejected with an error if there is no value list information available for the given property path. Use {@link #getValueListType} to determine if value list information exists. It is also rejected with an error if the value list metadata is inconsistent.
							/// 
							/// An inconsistency can result from one of the following reasons: <ul> <li> There is a reference, but the referenced service does not contain mappings for the property. <li> The referenced service contains annotation targets in the namespace of the data service that are not mappings for the property. <li> Two different referenced services contain a mapping using the same qualifier. <li> A service is referenced twice. <li> No mappings have been found. <li> There are multiple mappings for a fixed value list. </ul></returns>
							public extern virtual jquery.JQueryPromise<object> requestValueListInfo(string sPropertyPath);

							/// <summary>
							/// Determines which type of value list exists for the given property.
							/// </summary>
							/// <param name="sPropertyPath">An absolute path to an OData property within the OData data model</param>
							/// <returns>A promise that is resolved with the type of the value list, a constant of the enumeration {@link sap.ui.model.odata.v4.ValueListType}. The promise is rejected if the property cannot be found in the metadata.</returns>
							public extern virtual jquery.JQueryPromise<object> requestValueListType(string sPropertyPath);

							/// <summary>
							/// Method not supported
							/// </summary>
							public extern virtual void setLegacySyntax();

							/// <summary>
							/// Returns a string representation of this object including the URL to the $metadata document of the service.
							/// </summary>
							/// <returns>A string description of this model</returns>
							public extern override string toString();

							#endregion

						}
					}
				}
			}
		}
	}
}
