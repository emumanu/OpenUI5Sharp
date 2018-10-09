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
			/// Defines a structure of the element of the 'items' aggregation.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.UploadCollectionItem")]
			public partial class UploadCollectionItem : sap.ui.core.Element
			{
				#region Settings

				/// <summary>
				/// Settings class to create the object
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class Settings : sap.ui.core.Element.Settings
				{
					/// <summary>
					/// Specifies the name of the user who uploaded the file.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> contributor;

					/// <summary>
					/// Specifies a unique identifier of the file (created by the application).
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> documentId;

					/// <summary>
					/// Specifies the name of the uploaded file.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> fileName;

					/// <summary>
					/// Specifies the size of the uploaded file (in megabytes).
					/// </summary>
					public Union<float, string, sap.ui.@base.ManagedObject.BindPropertyInfo> fileSize;

					/// <summary>
					/// Specifies the MIME type of the file.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> mimeType;

					/// <summary>
					/// Specifies the URL where the thumbnail of the file is located. This can also be an SAPUI5 icon URL.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> thumbnailUrl;

					/// <summary>
					/// Specifies the date on which the file was uploaded. The application has to define the date format.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> uploadedDate;

					/// <summary>
					/// Specifies the URL where the file is located. If the application doesn't provide a value for this property, the icon and the file name of the UploadCollectionItem are not clickable.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> url;

					/// <summary>
					/// Enables/Disables the Edit button. If the value is true, the Edit button is enabled and the edit function can be used. If the value is false, the edit function is not available.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> enableEdit;

					/// <summary>
					/// Enables/Disables the Delete button. If the value is true, the Delete button is enabled and the delete function can be used. If the value is false, the delete function is not available.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> enableDelete;

					/// <summary>
					/// Show/Hide the Edit button. If the value is true, the Edit button is visible. If the value is false, the Edit button is not visible.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> visibleEdit;

					/// <summary>
					/// Show/Hide the Delete button. If the value is true, the Delete button is visible. If the value is false, the Delete button is not visible.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> visibleDelete;

					/// <summary>
					/// Aria label for the icon (or for the image).
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> ariaLabelForPicture;

					/// <summary>
					/// Defines the selected state of the UploadCollectionItem.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> selected;

					/// <summary>
					/// Attributes of an uploaded item, for example, 'Uploaded By', 'Uploaded On', 'File Size' attributes are displayed after an item has been uploaded. Additionally, the Active property of sap.m.ObjectAttribute is supported.<br> Note that if one of the deprecated properties contributor, fileSize or UploadedDate is filled in addition to this attribute, two attributes with the same title are displayed as these properties get displayed as an attribute. Example: An application passes the property ‘contributor’ with the value ‘A’ and the aggregation attributes ‘contributor’: ‘B’. As a result, the attributes ‘contributor’:’A’ and ‘contributor’:’B’ are displayed. To make sure the title does not appear twice, check if one of the properties is filled.
					/// </summary>
					public Union<sap.m.ObjectAttribute[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> attributes;

					/// <summary>
					/// Statuses of an uploaded item Statuses will be displayed after an item has been uploaded
					/// </summary>
					public Union<sap.m.ObjectStatus[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> statuses;

					/// <summary>
					/// Markers of an uploaded item Markers will be displayed after an item has been uploaded But not in Edit mode
					/// </summary>
					public Union<sap.m.ObjectMarker[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> markers;

					/// <summary>
					/// ID of the FileUploader instance
					/// </summary>
					public Union<sap.ui.unified.FileUploader, sap.ui.core.ID, string, sap.ui.@base.ManagedObject.BindPropertyInfo> fileUploader;

					/// <summary>
					/// This event is triggered when the user presses the filename link. If this event is provided, it overwrites the default behavior of opening the file.
					/// </summary>
					public sap.ui.@base.EventDelegate press;

					/// <summary>
					/// When a deletePress event handler is attached to the item and the user presses the delete button, this event is triggered. If this event is triggered, it overwrites the default delete behavior of UploadCollection and the fileDeleted event of UploadCollection is not triggered.
					/// </summary>
					public sap.ui.@base.EventDelegate deletePress;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new UploadCollectionItem
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, will be generated automatically if no ID is provided.</param>
				/// <param name="mSettings">initial settings for the new control</param>
				public extern UploadCollectionItem(string sId, sap.m.UploadCollectionItem.Settings mSettings);

				/// <summary>
				/// Constructor for a new UploadCollectionItem
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, will be generated automatically if no ID is provided.</param>
				public extern UploadCollectionItem(string sId);

				/// <summary>
				/// Constructor for a new UploadCollectionItem
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern UploadCollectionItem();

				/// <summary>
				/// Constructor for a new UploadCollectionItem
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">initial settings for the new control</param>
				public extern UploadCollectionItem(sap.m.UploadCollectionItem.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property contributor

				/// <summary>
				/// Gets current value of property {@link #getContributor contributor}.
				/// 
				/// Specifies the name of the user who uploaded the file.
				/// </summary>
				/// <returns>Value of property <code>contributor</code></returns>
				[Obsolete("Deprecated since 1.30. This property is deprecated; use the aggregation attributes instead. However, if the property is filled, it is displayed as an attribute. To make sure the title does not appear twice, do not use the property.")]
				public extern virtual string getContributor();

				/// <summary>
				/// Sets a new value for property {@link #getContributor contributor}.
				/// 
				/// Specifies the name of the user who uploaded the file.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sContributor">New value for property <code>contributor</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.30. This property is deprecated; use the aggregation attributes instead. However, if the property is filled, it is displayed as an attribute. To make sure the title does not appear twice, do not use the property.")]
				public extern virtual sap.m.UploadCollectionItem setContributor(string sContributor);

				#endregion

				#region Methods for Property documentId

				/// <summary>
				/// Gets current value of property {@link #getDocumentId documentId}.
				/// 
				/// Specifies a unique identifier of the file (created by the application).
				/// </summary>
				/// <returns>Value of property <code>documentId</code></returns>
				public extern virtual string getDocumentId();

				/// <summary>
				/// Sets a new value for property {@link #getDocumentId documentId}.
				/// 
				/// Specifies a unique identifier of the file (created by the application).
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sDocumentId">New value for property <code>documentId</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollectionItem setDocumentId(string sDocumentId);

				#endregion

				#region Methods for Property fileName

				/// <summary>
				/// Gets current value of property {@link #getFileName fileName}.
				/// 
				/// Specifies the name of the uploaded file.
				/// </summary>
				/// <returns>Value of property <code>fileName</code></returns>
				public extern virtual string getFileName();

				/// <summary>
				/// Sets a new value for property {@link #getFileName fileName}.
				/// 
				/// Specifies the name of the uploaded file.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sFileName">New value for property <code>fileName</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollectionItem setFileName(string sFileName);

				#endregion

				#region Methods for Property fileSize

				/// <summary>
				/// Gets current value of property {@link #getFileSize fileSize}.
				/// 
				/// Specifies the size of the uploaded file (in megabytes).
				/// </summary>
				/// <returns>Value of property <code>fileSize</code></returns>
				[Obsolete("Deprecated since 1.30. This property is deprecated; use the aggregation attributes instead.")]
				public extern virtual float getFileSize();

				/// <summary>
				/// Sets a new value for property {@link #getFileSize fileSize}.
				/// 
				/// Specifies the size of the uploaded file (in megabytes).
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="fFileSize">New value for property <code>fileSize</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.30. This property is deprecated; use the aggregation attributes instead.")]
				public extern virtual sap.m.UploadCollectionItem setFileSize(float fFileSize);

				#endregion

				#region Methods for Property mimeType

				/// <summary>
				/// Gets current value of property {@link #getMimeType mimeType}.
				/// 
				/// Specifies the MIME type of the file.
				/// </summary>
				/// <returns>Value of property <code>mimeType</code></returns>
				public extern virtual string getMimeType();

				/// <summary>
				/// Sets a new value for property {@link #getMimeType mimeType}.
				/// 
				/// Specifies the MIME type of the file.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sMimeType">New value for property <code>mimeType</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollectionItem setMimeType(string sMimeType);

				#endregion

				#region Methods for Property thumbnailUrl

				/// <summary>
				/// Gets current value of property {@link #getThumbnailUrl thumbnailUrl}.
				/// 
				/// Specifies the URL where the thumbnail of the file is located. This can also be an SAPUI5 icon URL.
				/// </summary>
				/// <returns>Value of property <code>thumbnailUrl</code></returns>
				public extern virtual string getThumbnailUrl();

				/// <summary>
				/// Sets a new value for property {@link #getThumbnailUrl thumbnailUrl}.
				/// 
				/// Specifies the URL where the thumbnail of the file is located. This can also be an SAPUI5 icon URL.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sThumbnailUrl">New value for property <code>thumbnailUrl</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollectionItem setThumbnailUrl(string sThumbnailUrl);

				#endregion

				#region Methods for Property uploadedDate

				/// <summary>
				/// Gets current value of property {@link #getUploadedDate uploadedDate}.
				/// 
				/// Specifies the date on which the file was uploaded. The application has to define the date format.
				/// </summary>
				/// <returns>Value of property <code>uploadedDate</code></returns>
				[Obsolete("Deprecated since 1.30. This property is deprecated; use the aggregation attributes instead.")]
				public extern virtual string getUploadedDate();

				/// <summary>
				/// Sets a new value for property {@link #getUploadedDate uploadedDate}.
				/// 
				/// Specifies the date on which the file was uploaded. The application has to define the date format.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sUploadedDate">New value for property <code>uploadedDate</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.30. This property is deprecated; use the aggregation attributes instead.")]
				public extern virtual sap.m.UploadCollectionItem setUploadedDate(string sUploadedDate);

				#endregion

				#region Methods for Property url

				/// <summary>
				/// Gets current value of property {@link #getUrl url}.
				/// 
				/// Specifies the URL where the file is located. If the application doesn't provide a value for this property, the icon and the file name of the UploadCollectionItem are not clickable.
				/// </summary>
				/// <returns>Value of property <code>url</code></returns>
				public extern virtual string getUrl();

				/// <summary>
				/// Sets a new value for property {@link #getUrl url}.
				/// 
				/// Specifies the URL where the file is located. If the application doesn't provide a value for this property, the icon and the file name of the UploadCollectionItem are not clickable.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sUrl">New value for property <code>url</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollectionItem setUrl(string sUrl);

				#endregion

				#region Methods for Property enableEdit

				/// <summary>
				/// Gets current value of property {@link #getEnableEdit enableEdit}.
				/// 
				/// Enables/Disables the Edit button. If the value is true, the Edit button is enabled and the edit function can be used. If the value is false, the edit function is not available.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>enableEdit</code></returns>
				public extern virtual bool getEnableEdit();

				/// <summary>
				/// Sets a new value for property {@link #getEnableEdit enableEdit}.
				/// 
				/// Enables/Disables the Edit button. If the value is true, the Edit button is enabled and the edit function can be used. If the value is false, the edit function is not available.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bEnableEdit">New value for property <code>enableEdit</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollectionItem setEnableEdit(bool bEnableEdit);

				#endregion

				#region Methods for Property enableDelete

				/// <summary>
				/// Gets current value of property {@link #getEnableDelete enableDelete}.
				/// 
				/// Enables/Disables the Delete button. If the value is true, the Delete button is enabled and the delete function can be used. If the value is false, the delete function is not available.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>enableDelete</code></returns>
				public extern virtual bool getEnableDelete();

				/// <summary>
				/// Sets a new value for property {@link #getEnableDelete enableDelete}.
				/// 
				/// Enables/Disables the Delete button. If the value is true, the Delete button is enabled and the delete function can be used. If the value is false, the delete function is not available.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bEnableDelete">New value for property <code>enableDelete</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollectionItem setEnableDelete(bool bEnableDelete);

				#endregion

				#region Methods for Property visibleEdit

				/// <summary>
				/// Gets current value of property {@link #getVisibleEdit visibleEdit}.
				/// 
				/// Show/Hide the Edit button. If the value is true, the Edit button is visible. If the value is false, the Edit button is not visible.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>visibleEdit</code></returns>
				public extern virtual bool getVisibleEdit();

				/// <summary>
				/// Sets a new value for property {@link #getVisibleEdit visibleEdit}.
				/// 
				/// Show/Hide the Edit button. If the value is true, the Edit button is visible. If the value is false, the Edit button is not visible.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bVisibleEdit">New value for property <code>visibleEdit</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollectionItem setVisibleEdit(bool bVisibleEdit);

				#endregion

				#region Methods for Property visibleDelete

				/// <summary>
				/// Gets current value of property {@link #getVisibleDelete visibleDelete}.
				/// 
				/// Show/Hide the Delete button. If the value is true, the Delete button is visible. If the value is false, the Delete button is not visible.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>visibleDelete</code></returns>
				public extern virtual bool getVisibleDelete();

				/// <summary>
				/// Sets a new value for property {@link #getVisibleDelete visibleDelete}.
				/// 
				/// Show/Hide the Delete button. If the value is true, the Delete button is visible. If the value is false, the Delete button is not visible.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bVisibleDelete">New value for property <code>visibleDelete</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollectionItem setVisibleDelete(bool bVisibleDelete);

				#endregion

				#region Methods for Property ariaLabelForPicture

				/// <summary>
				/// Gets current value of property {@link #getAriaLabelForPicture ariaLabelForPicture}.
				/// 
				/// Aria label for the icon (or for the image).
				/// </summary>
				/// <returns>Value of property <code>ariaLabelForPicture</code></returns>
				public extern virtual string getAriaLabelForPicture();

				/// <summary>
				/// Sets a new value for property {@link #getAriaLabelForPicture ariaLabelForPicture}.
				/// 
				/// Aria label for the icon (or for the image).
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sAriaLabelForPicture">New value for property <code>ariaLabelForPicture</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollectionItem setAriaLabelForPicture(string sAriaLabelForPicture);

				#endregion

				#region Methods for Property selected

				/// <summary>
				/// Gets current value of property {@link #getSelected selected}.
				/// 
				/// Defines the selected state of the UploadCollectionItem.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>selected</code></returns>
				public extern virtual bool getSelected();

				/// <summary>
				/// Sets a new value for property {@link #getSelected selected}.
				/// 
				/// Defines the selected state of the UploadCollectionItem.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bSelected">New value for property <code>selected</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollectionItem setSelected(bool bSelected);

				#endregion

				#region Methods for Aggregation attributes

				/// <summary>
				/// Gets content of aggregation {@link #getAttributes attributes}.
				/// 
				/// Attributes of an uploaded item, for example, 'Uploaded By', 'Uploaded On', 'File Size' attributes are displayed after an item has been uploaded. Additionally, the Active property of sap.m.ObjectAttribute is supported.<br> Note that if one of the deprecated properties contributor, fileSize or UploadedDate is filled in addition to this attribute, two attributes with the same title are displayed as these properties get displayed as an attribute. Example: An application passes the property ‘contributor’ with the value ‘A’ and the aggregation attributes ‘contributor’: ‘B’. As a result, the attributes ‘contributor’:’A’ and ‘contributor’:’B’ are displayed. To make sure the title does not appear twice, check if one of the properties is filled.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.ObjectAttribute[] getAttributes();

				/// <summary>
				/// Destroys all the attributes in the aggregation {@link #getAttributes attributes}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollectionItem destroyAttributes();

				/// <summary>
				/// Inserts a attribute into the aggregation {@link #getAttributes attributes}.
				/// </summary>
				/// <param name="oAttribute">The attribute to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the attribute should be inserted at; for a negative value of <code>iIndex</code>, the attribute is inserted at position 0; for a value greater than the current size of the aggregation, the attribute is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollectionItem insertAttribute(sap.m.ObjectAttribute oAttribute, int iIndex);

				/// <summary>
				/// Adds some attribute to the aggregation {@link #getAttributes attributes}.
				/// </summary>
				/// <param name="oAttribute">The attribute to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollectionItem addAttribute(sap.m.ObjectAttribute oAttribute);

				/// <summary>
				/// Removes a attribute from the aggregation {@link #getAttributes attributes}.
				/// </summary>
				/// <param name="vAttribute">The attribute to remove or its index or id</param>
				/// <returns>The removed attribute or <code>null</code></returns>
				public extern virtual sap.m.ObjectAttribute removeAttribute(Union<int, string, sap.m.ObjectAttribute> vAttribute);

				/// <summary>
				/// Checks for the provided <code>sap.m.ObjectAttribute</code> in the aggregation {@link #getAttributes attributes}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oAttribute">The attribute whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfAttribute(sap.m.ObjectAttribute oAttribute);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getAttributes attributes}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.m.ObjectAttribute[] removeAllAttributes();

				/// <summary>
				/// Binds aggregation {@link #getAttributes attributes} to model data.
				/// 
				/// See {@link sap.ui.base.ManagedObject#bindAggregation ManagedObject.bindAggregation} for a detailed description of the possible properties of <code>oBindingInfo</code>.
				/// </summary>
				/// <param name="oBindingInfo">The binding information</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollectionItem bindAttributes(object oBindingInfo);

				/// <summary>
				/// Unbinds aggregation {@link #getAttributes attributes} from model data.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollectionItem unbindAttributes();

				#endregion

				#region Methods for Aggregation _propertyAttributes

				#endregion

				#region Methods for Aggregation statuses

				/// <summary>
				/// Gets content of aggregation {@link #getStatuses statuses}.
				/// 
				/// Statuses of an uploaded item Statuses will be displayed after an item has been uploaded
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.ObjectStatus[] getStatuses();

				/// <summary>
				/// Destroys all the statuses in the aggregation {@link #getStatuses statuses}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollectionItem destroyStatuses();

				/// <summary>
				/// Inserts a status into the aggregation {@link #getStatuses statuses}.
				/// </summary>
				/// <param name="oStatus">The status to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the status should be inserted at; for a negative value of <code>iIndex</code>, the status is inserted at position 0; for a value greater than the current size of the aggregation, the status is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollectionItem insertStatus(sap.m.ObjectStatus oStatus, int iIndex);

				/// <summary>
				/// Adds some status to the aggregation {@link #getStatuses statuses}.
				/// </summary>
				/// <param name="oStatus">The status to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollectionItem addStatus(sap.m.ObjectStatus oStatus);

				/// <summary>
				/// Removes a status from the aggregation {@link #getStatuses statuses}.
				/// </summary>
				/// <param name="vStatus">The status to remove or its index or id</param>
				/// <returns>The removed status or <code>null</code></returns>
				public extern virtual sap.m.ObjectStatus removeStatus(Union<int, string, sap.m.ObjectStatus> vStatus);

				/// <summary>
				/// Checks for the provided <code>sap.m.ObjectStatus</code> in the aggregation {@link #getStatuses statuses}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oStatus">The status whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfStatus(sap.m.ObjectStatus oStatus);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getStatuses statuses}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.m.ObjectStatus[] removeAllStatuses();

				/// <summary>
				/// Binds aggregation {@link #getStatuses statuses} to model data.
				/// 
				/// See {@link sap.ui.base.ManagedObject#bindAggregation ManagedObject.bindAggregation} for a detailed description of the possible properties of <code>oBindingInfo</code>.
				/// </summary>
				/// <param name="oBindingInfo">The binding information</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollectionItem bindStatuses(object oBindingInfo);

				/// <summary>
				/// Unbinds aggregation {@link #getStatuses statuses} from model data.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollectionItem unbindStatuses();

				#endregion

				#region Methods for Aggregation markers

				/// <summary>
				/// Gets content of aggregation {@link #getMarkers markers}.
				/// 
				/// Markers of an uploaded item Markers will be displayed after an item has been uploaded But not in Edit mode
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.ObjectMarker[] getMarkers();

				/// <summary>
				/// Destroys all the markers in the aggregation {@link #getMarkers markers}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollectionItem destroyMarkers();

				/// <summary>
				/// Inserts a marker into the aggregation {@link #getMarkers markers}.
				/// </summary>
				/// <param name="oMarker">The marker to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the marker should be inserted at; for a negative value of <code>iIndex</code>, the marker is inserted at position 0; for a value greater than the current size of the aggregation, the marker is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollectionItem insertMarker(sap.m.ObjectMarker oMarker, int iIndex);

				/// <summary>
				/// Adds some marker to the aggregation {@link #getMarkers markers}.
				/// </summary>
				/// <param name="oMarker">The marker to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollectionItem addMarker(sap.m.ObjectMarker oMarker);

				/// <summary>
				/// Removes a marker from the aggregation {@link #getMarkers markers}.
				/// </summary>
				/// <param name="vMarker">The marker to remove or its index or id</param>
				/// <returns>The removed marker or <code>null</code></returns>
				public extern virtual sap.m.ObjectMarker removeMarker(Union<int, string, sap.m.ObjectMarker> vMarker);

				/// <summary>
				/// Checks for the provided <code>sap.m.ObjectMarker</code> in the aggregation {@link #getMarkers markers}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oMarker">The marker whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfMarker(sap.m.ObjectMarker oMarker);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getMarkers markers}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.m.ObjectMarker[] removeAllMarkers();

				/// <summary>
				/// Binds aggregation {@link #getMarkers markers} to model data.
				/// 
				/// See {@link sap.ui.base.ManagedObject#bindAggregation ManagedObject.bindAggregation} for a detailed description of the possible properties of <code>oBindingInfo</code>.
				/// </summary>
				/// <param name="oBindingInfo">The binding information</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollectionItem bindMarkers(object oBindingInfo);

				/// <summary>
				/// Unbinds aggregation {@link #getMarkers markers} from model data.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollectionItem unbindMarkers();

				#endregion

				#region Methods for Association fileUploader

				/// <summary>
				/// ID of the element which is the current target of the association {@link #getFileUploader fileUploader}, or <code>null</code>.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.ID getFileUploader();

				/// <summary>
				/// Sets the associated {@link #getFileUploader fileUploader}.
				/// </summary>
				/// <param name="oFileUploader">ID of an element which becomes the new target of this fileUploader association; alternatively, an element instance may be given</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollectionItem setFileUploader(Union<sap.ui.core.ID, sap.ui.unified.FileUploader> oFileUploader);

				#endregion

				#region Methods for Event press

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:press press} event of this <code>sap.m.UploadCollectionItem</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.UploadCollectionItem</code> itself.
				/// 
				/// This event is triggered when the user presses the filename link. If this event is provided, it overwrites the default behavior of opening the file.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.UploadCollectionItem</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollectionItem attachPress(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:press press} event of this <code>sap.m.UploadCollectionItem</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.UploadCollectionItem</code> itself.
				/// 
				/// This event is triggered when the user presses the filename link. If this event is provided, it overwrites the default behavior of opening the file.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollectionItem attachPress(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:press press} event of this <code>sap.m.UploadCollectionItem</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.UploadCollectionItem</code> itself.
				/// 
				/// This event is triggered when the user presses the filename link. If this event is provided, it overwrites the default behavior of opening the file.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollectionItem attachPress(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:press press} event of this <code>sap.m.UploadCollectionItem</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.UploadCollectionItem</code> itself.
				/// 
				/// This event is triggered when the user presses the filename link. If this event is provided, it overwrites the default behavior of opening the file.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.UploadCollectionItem</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollectionItem attachPress(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:press press} event of this <code>sap.m.UploadCollectionItem</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollectionItem detachPress(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:press press} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollectionItem firePress(object mParameters);

				/// <summary>
				/// Fires event {@link #event:press press} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollectionItem firePress();

				#endregion

				#region Methods for Event deletePress

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:deletePress deletePress} event of this <code>sap.m.UploadCollectionItem</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.UploadCollectionItem</code> itself.
				/// 
				/// When a deletePress event handler is attached to the item and the user presses the delete button, this event is triggered. If this event is triggered, it overwrites the default delete behavior of UploadCollection and the fileDeleted event of UploadCollection is not triggered.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.UploadCollectionItem</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollectionItem attachDeletePress(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:deletePress deletePress} event of this <code>sap.m.UploadCollectionItem</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.UploadCollectionItem</code> itself.
				/// 
				/// When a deletePress event handler is attached to the item and the user presses the delete button, this event is triggered. If this event is triggered, it overwrites the default delete behavior of UploadCollection and the fileDeleted event of UploadCollection is not triggered.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollectionItem attachDeletePress(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:deletePress deletePress} event of this <code>sap.m.UploadCollectionItem</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.UploadCollectionItem</code> itself.
				/// 
				/// When a deletePress event handler is attached to the item and the user presses the delete button, this event is triggered. If this event is triggered, it overwrites the default delete behavior of UploadCollection and the fileDeleted event of UploadCollection is not triggered.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollectionItem attachDeletePress(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:deletePress deletePress} event of this <code>sap.m.UploadCollectionItem</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.UploadCollectionItem</code> itself.
				/// 
				/// When a deletePress event handler is attached to the item and the user presses the delete button, this event is triggered. If this event is triggered, it overwrites the default delete behavior of UploadCollection and the fileDeleted event of UploadCollection is not triggered.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.UploadCollectionItem</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollectionItem attachDeletePress(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:deletePress deletePress} event of this <code>sap.m.UploadCollectionItem</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollectionItem detachDeletePress(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:deletePress deletePress} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollectionItem fireDeletePress(object mParameters);

				/// <summary>
				/// Fires event {@link #event:deletePress deletePress} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollectionItem fireDeletePress();

				#endregion

				#region Other methods

				/// <summary>
				/// Downloads the item. The sap.ui.core.util.File method is used here. For further details on this method, see {sap.ui.core.util.File.save}.
				/// </summary>
				/// <param name="askForLocation">Decides whether to ask for a location to download or not.</param>
				/// <returns><code>true</code> if download is possible, otherwise <code>false</code></returns>
				public extern virtual bool download(bool askForLocation);

				/// <summary>
				/// Creates a new subclass of class sap.m.UploadCollectionItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.UploadCollectionItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.UploadCollectionItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.UploadCollectionItem.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				#endregion

				#endregion

			}
		}
	}
}
