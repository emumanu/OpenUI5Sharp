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
			/// This control allows you to upload single or multiple files from your devices (desktop, tablet or phone) and attach them to the application.
			/// 
			/// The consuming application needs to take into account that the consistency checks of the model during the upload of the file need to be performed, for example, if the user is editing or deleting a file.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.UploadCollection")]
			public partial class UploadCollection : sap.ui.core.Control
			{
				#region Settings

				/// <summary>
				/// Settings class to create the object
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class Settings : sap.ui.core.Control.Settings
				{
					/// <summary>
					/// Defines the allowed file types for the upload. The chosen files will be checked against an array of file types. If at least one file does not fit the file type requirements, the upload is prevented. Example: ["jpg", "png", "bmp"].
					/// </summary>
					public Union<string[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> fileType;

					/// <summary>
					/// Specifies the maximum length of a file name. If the maximum file name length is exceeded, the corresponding event 'filenameLengthExceed' is triggered.
					/// </summary>
					public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> maximumFilenameLength;

					/// <summary>
					/// Specifies a file size limit in megabytes that prevents the upload if at least one file exceeds the limit. This property is not supported by Internet Explorer 8 and 9.
					/// </summary>
					public Union<float, string, sap.ui.@base.ManagedObject.BindPropertyInfo> maximumFileSize;

					/// <summary>
					/// Defines the allowed MIME types of files to be uploaded. The chosen files will be checked against an array of MIME types. If at least one file does not fit the MIME type requirements, the upload is prevented. This property is not supported by Internet Explorer 8 and 9. Example: mimeType ["image/png", "image/jpeg"].
					/// </summary>
					public Union<string[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> mimeType;

					/// <summary>
					/// Lets the user select multiple files from the same folder and then upload them. Internet Explorer 8 and 9 do not support this property. Please note that the various operating systems for mobile devices can react differently to the property so that fewer upload functions may be available in some cases.
					/// 
					/// If multiple property is set to false, the control shows an error message if more than one file is chosen for drag & drop.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> multiple;

					/// <summary>
					/// Allows you to set your own text for the 'No data' text label.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> noDataText;

					/// <summary>
					/// Allows you to set your own text for the 'No data' description label.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> noDataDescription;

					/// <summary>
					/// Allows the user to use the same name for a file when editing the file name. 'Same name' refers to an already existing file name in the list.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> sameFilenameAllowed;

					/// <summary>
					/// Defines whether separators are shown between list items.
					/// </summary>
					public Union<sap.m.ListSeparators, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showSeparators;

					/// <summary>
					/// Enables the upload of a file.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> uploadEnabled;

					/// <summary>
					/// Specifies the URL where the uploaded files have to be stored.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> uploadUrl;

					/// <summary>
					/// If false, no upload is triggered when a file is selected. In addition, if a file was selected, a new FileUploader instance is created to ensure that multiple files from multiple folders can be chosen.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> instantUpload;

					/// <summary>
					/// Sets the title text in the toolbar of the list of attachments. To show as well the number of attachments in brackets like the default text does. The number of attachments could be retrieved via "getItems().length". If a new title is set, the default is deactivated. The default value is set to language-dependent "Attachments (n)".
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> numberOfAttachmentsText;

					/// <summary>
					/// Defines the selection mode of the control (e.g. None, SingleSelect, MultiSelect, SingleSelectLeft, SingleSelectMaster). Since the UploadCollection reacts like a list for attachments, the API is close to the ListBase Interface. sap.m.ListMode.Delete mode is not supported and will be automatically set to sap.m.ListMode.None. In addition, if instant upload is set to false the mode sap.m.ListMode.MultiSelect is not supported and will be automatically set to sap.m.ListMode.None.
					/// </summary>
					public Union<sap.m.ListMode, string, sap.ui.@base.ManagedObject.BindPropertyInfo> mode;

					/// <summary>
					/// If true, the button used for uploading files is invisible.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> uploadButtonInvisible;

					/// <summary>
					/// If true, the button that is used to terminate the instant file upload gets visible. The button normally appears when a file is being uploaded.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> terminationEnabled;

					/// <summary>
					/// Uploaded items.
					/// </summary>
					public Union<sap.m.UploadCollectionItem[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> items;

					/// <summary>
					/// Specifies the header parameters for the FileUploader that are submitted only with XHR requests. Header parameters are not supported by Internet Explorer 8 and 9.
					/// </summary>
					public Union<sap.m.UploadCollectionParameter[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> headerParameters;

					/// <summary>
					/// Specifies the parameters for the FileUploader that are rendered as a hidden input field.
					/// </summary>
					public Union<sap.m.UploadCollectionParameter[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> parameters;

					/// <summary>
					/// Specifies the toolbar.
					/// </summary>
					public Union<sap.m.OverflowToolbar, string, sap.ui.@base.ManagedObject.BindAggregationInfo> toolbar;

					/// <summary>
					/// Specifies the info toolbar for filtering information. Sorting information will not displayed.
					/// </summary>
					public Union<sap.m.Toolbar, string, sap.ui.@base.ManagedObject.BindAggregationInfo> infoToolbar;

					/// <summary>
					/// The event is triggered when files are selected in the FileUploader dialog. Applications can set parameters and headerParameters which will be dispatched to the embedded FileUploader control. Limitation: parameters and headerParameters are not supported by Internet Explorer 9.
					/// </summary>
					public sap.m.UploadCollection.NotifyDelegate change;

					/// <summary>
					/// The event is triggered when an uploaded attachment is selected and the Delete button is pressed.
					/// </summary>
					public sap.m.UploadCollection.FileDeletedDelegate fileDeleted;

					/// <summary>
					/// The event is triggered when the name of a chosen file is longer than the value specified with the maximumFilenameLength property (only if provided by the application).
					/// </summary>
					public sap.m.UploadCollection.NotifyDelegate filenameLengthExceed;

					/// <summary>
					/// The event is triggered when the file name is changed.
					/// </summary>
					public sap.m.UploadCollection.FileRenamedDelegate fileRenamed;

					/// <summary>
					/// The event is triggered when the file size of an uploaded file is exceeded (only if the maxFileSize property was provided by the application). This event is not supported by Internet Explorer 9.
					/// </summary>
					public sap.m.UploadCollection.FileSizeExceedDelegate fileSizeExceed;

					/// <summary>
					/// The event is triggered when the file type or the MIME type don't match the permitted types (only if the fileType property or the mimeType property are provided by the application).
					/// </summary>
					public sap.m.UploadCollection.TypeMissmatchDelegate typeMissmatch;

					/// <summary>
					/// The event is triggered as soon as the upload request is completed.
					/// </summary>
					public sap.m.UploadCollection.UploadCompleteDelegate uploadComplete;

					/// <summary>
					/// The event is triggered as soon as the upload request was terminated by the user.
					/// </summary>
					public sap.m.UploadCollection.UploadTerminatedDelegate uploadTerminated;

					/// <summary>
					/// The event is triggered before the actual upload starts. An event is fired per file. All the necessary header parameters should be set here.
					/// </summary>
					public sap.m.UploadCollection.BeforeUploadStartsDelegate beforeUploadStarts;

					/// <summary>
					/// Fires when selection is changed via user interaction inside the control.
					/// </summary>
					public sap.m.UploadCollection.SelectionChangeDelegate selectionChange;

				}

				#endregion

				#region Typed Parameters

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class BeforeUploadStartsInfo
				{
					/// <summary>
					/// Specifies the name of the file to be uploaded.
					/// </summary>
					public string fileName;

					/// <summary>
					/// Adds a header parameter to the file that will be uploaded.
					/// </summary>
					public object addHeaderParameter;

					/// <summary>
					/// Returns the corresponding header parameter (type sap.m.UploadCollectionParameter) if available.
					/// </summary>
					public object getHeaderParameter;

				}

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class NotifyInfo
				{
					/// <summary>
					/// A unique Id of the attached document. This parameter is deprecated since 1.28.0. Use the <code>files</code> parameter instead.
					/// </summary>
					public string documentId;

					/// <summary>
					/// A FileList of individually selected files from the underlying system. See www.w3.org for the FileList Interface definition. Limitation: Internet Explorer 9 supports only single file with property file.name. Since version 1.28.0.
					/// </summary>
					public object[] files;

				}

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class FileDeletedInfo
				{
					/// <summary>
					/// A unique Id of the attached document. This parameter is deprecated since 1.28.0. Use the <code>item</code> parameter instead.
					/// </summary>
					public string documentId;

					/// <summary>
					/// An item to be deleted from the collection. Since version 1.28.0.
					/// </summary>
					public sap.m.UploadCollectionItem item;

				}

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class FileRenamedInfo
				{
					/// <summary>
					/// A unique Id of the attached document. This parameter is deprecated since 1.28.0. Use the <code>item</code> parameter instead.
					/// </summary>
					public string documentId;

					/// <summary>
					/// The new file name. This parameter is deprecated since 1.28.0. Use the <code>item</code> parameter instead.
					/// </summary>
					public string fileName;

					/// <summary>
					/// The renamed UI element as an UploadCollectionItem. Since 1.28.0.
					/// </summary>
					public sap.m.UploadCollectionItem item;

				}

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class FileSizeExceedInfo
				{
					/// <summary>
					/// A unique Id of the attached document. This parameter is deprecated since 1.28.0. Use the <code>files</code> parameter instead.
					/// </summary>
					public string documentId;

					/// <summary>
					/// The size in MB of a file to be uploaded. This parameter is deprecated since 1.28.0. Use the <code>files</code> parameter instead.
					/// </summary>
					public string fileSize;

					/// <summary>
					/// A FileList of individually selected files from the underlying system. Limitation: Internet Explorer 9 supports only single file with property file.name. Since 1.28.0.
					/// </summary>
					public object[] files;

				}

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class SelectionChangeInfo
				{
					/// <summary>
					/// The item whose selection has changed. In <code>MultiSelect</code> mode, only the topmost selected item is returned. This parameter can be used for single-selection modes.
					/// </summary>
					public sap.m.UploadCollectionItem selectedItem;

					/// <summary>
					/// Array of items whose selection has changed. This parameter can be used for <code>MultiSelect</code> mode.
					/// </summary>
					public sap.m.UploadCollectionItem[] selectedItems;

					/// <summary>
					/// Indicates whether the <code>listItem</code> parameter is selected or not.
					/// </summary>
					public bool selected;

				}

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class TypeMissmatchInfo
				{
					/// <summary>
					/// A unique Id of the attached document. This parameter is deprecated since 1.28.0. Use the <code>files</code> parameter instead.
					/// </summary>
					public string documentId;

					/// <summary>
					/// File type. This parameter is deprecated since 1.28.0. Use the <code>files</code> parameter instead.
					/// </summary>
					public string fileType;

					/// <summary>
					/// MIME type. This parameter is deprecated since 1.28.0. Use the <code>files</code> parameter instead.
					/// </summary>
					public string mimeType;

					/// <summary>
					/// A FileList of individually selected files from the underlying system. Limitation: Internet Explorer 9 supports only single file. Since 1.28.0.
					/// </summary>
					public object[] files;

				}

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class UploadCompleteInfo
				{
					/// <summary>
					/// Ready state XHR. This parameter is deprecated since 1.28.0. Use the <code>files</code> parameter instead.
					/// </summary>
					public string readyStateXHR;

					/// <summary>
					/// Response of the completed upload request. This parameter is deprecated since 1.28.0. Use the <code>files</code> parameter instead.
					/// </summary>
					public string response;

					/// <summary>
					/// Status Code of the completed upload event. This parameter is deprecated since 1.28.0. Use the <code>files</code> parameter instead.
					/// </summary>
					public string status;

					/// <summary>
					/// A list of uploaded files. Each entry contains the following members. fileName : The name of a file to be uploaded. response : Response message which comes from the server. On the server side, this response has to be put within the 'body' tags of the response document of the iFrame. It can consist of a return code and an optional message. This does not work in cross-domain scenarios. reponse : deprecated Since version 1.48.0. This parameter is deprecated, use parameter response instead. responseRaw : HTTP-Response which comes from the server. This property is not supported by Internet Explorer Versions lower than 9. status : Status of the XHR request. This property is not supported by Internet Explorer 9 and lower. headers : HTTP-Response-Headers which come from the server. Provided as a JSON-map, i.e. each header-field is reflected by a property in the header-object, with the property value reflecting the header-field's content. This property is not supported by Internet Explorer 9 and lower. Since 1.28.0.
					/// </summary>
					public object[] files;

				}

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class UploadTerminatedInfo
				{
					/// <summary>
					/// Specifies the name of the file of which the upload is to be terminated.
					/// </summary>
					public string fileName;

					/// <summary>
					/// This callback function returns the corresponding header parameter (type sap.m.UploadCollectionParameter) if available.
					/// </summary>
					public object getHeaderParameter;

				}

				#endregion

				#region Delegates

				public delegate void BeforeUploadStartsDelegate(sap.ui.@base.Event<sap.m.UploadCollection.BeforeUploadStartsInfo> oEvent, object oData);

				public delegate void NotifyDelegate(sap.ui.@base.Event<sap.m.UploadCollection.NotifyInfo> oEvent, object oData);

				public delegate void FileDeletedDelegate(sap.ui.@base.Event<sap.m.UploadCollection.FileDeletedInfo> oEvent, object oData);

				public delegate void FileRenamedDelegate(sap.ui.@base.Event<sap.m.UploadCollection.FileRenamedInfo> oEvent, object oData);

				public delegate void FileSizeExceedDelegate(sap.ui.@base.Event<sap.m.UploadCollection.FileSizeExceedInfo> oEvent, object oData);

				public delegate void SelectionChangeDelegate(sap.ui.@base.Event<sap.m.UploadCollection.SelectionChangeInfo> oEvent, object oData);

				public delegate void TypeMissmatchDelegate(sap.ui.@base.Event<sap.m.UploadCollection.TypeMissmatchInfo> oEvent, object oData);

				public delegate void UploadCompleteDelegate(sap.ui.@base.Event<sap.m.UploadCollection.UploadCompleteInfo> oEvent, object oData);

				public delegate void UploadTerminatedDelegate(sap.ui.@base.Event<sap.m.UploadCollection.UploadTerminatedInfo> oEvent, object oData);

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new UploadCollection.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">id for the new control, generated automatically if no id is given</param>
				/// <param name="mSettings">initial settings for the new control</param>
				public extern UploadCollection(string sId, sap.m.UploadCollection.Settings mSettings);

				/// <summary>
				/// Constructor for a new UploadCollection.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">id for the new control, generated automatically if no id is given</param>
				public extern UploadCollection(string sId);

				/// <summary>
				/// Constructor for a new UploadCollection.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern UploadCollection();

				/// <summary>
				/// Constructor for a new UploadCollection.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">initial settings for the new control</param>
				public extern UploadCollection(sap.m.UploadCollection.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property fileType

				/// <summary>
				/// Gets current value of property {@link #getFileType fileType}.
				/// 
				/// Defines the allowed file types for the upload. The chosen files will be checked against an array of file types. If at least one file does not fit the file type requirements, the upload is prevented. Example: ["jpg", "png", "bmp"].
				/// </summary>
				/// <returns>Value of property <code>fileType</code></returns>
				public extern virtual string[] getFileType();

				/// <summary>
				/// Sets a new value for property {@link #getFileType fileType}.
				/// 
				/// Defines the allowed file types for the upload. The chosen files will be checked against an array of file types. If at least one file does not fit the file type requirements, the upload is prevented. Example: ["jpg", "png", "bmp"].
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sFileType">New value for property <code>fileType</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection setFileType(string[] sFileType);

				/// <summary>
				/// Sets a new value for property {@link #getFileType fileType}.
				/// 
				/// Defines the allowed file types for the upload. The chosen files will be checked against an array of file types. If at least one file does not fit the file type requirements, the upload is prevented. Example: ["jpg", "png", "bmp"].
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sFileType">New value for property <code>fileType</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection setFileType(object[] sFileType);

				#endregion

				#region Methods for Property maximumFilenameLength

				/// <summary>
				/// Gets current value of property {@link #getMaximumFilenameLength maximumFilenameLength}.
				/// 
				/// Specifies the maximum length of a file name. If the maximum file name length is exceeded, the corresponding event 'filenameLengthExceed' is triggered.
				/// </summary>
				/// <returns>Value of property <code>maximumFilenameLength</code></returns>
				public extern virtual int getMaximumFilenameLength();

				/// <summary>
				/// Sets a new value for property {@link #getMaximumFilenameLength maximumFilenameLength}.
				/// 
				/// Specifies the maximum length of a file name. If the maximum file name length is exceeded, the corresponding event 'filenameLengthExceed' is triggered.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="iMaximumFilenameLength">New value for property <code>maximumFilenameLength</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection setMaximumFilenameLength(int iMaximumFilenameLength);

				#endregion

				#region Methods for Property maximumFileSize

				/// <summary>
				/// Gets current value of property {@link #getMaximumFileSize maximumFileSize}.
				/// 
				/// Specifies a file size limit in megabytes that prevents the upload if at least one file exceeds the limit. This property is not supported by Internet Explorer 8 and 9.
				/// </summary>
				/// <returns>Value of property <code>maximumFileSize</code></returns>
				public extern virtual float getMaximumFileSize();

				/// <summary>
				/// Sets a new value for property {@link #getMaximumFileSize maximumFileSize}.
				/// 
				/// Specifies a file size limit in megabytes that prevents the upload if at least one file exceeds the limit. This property is not supported by Internet Explorer 8 and 9.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="fMaximumFileSize">New value for property <code>maximumFileSize</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection setMaximumFileSize(float fMaximumFileSize);

				#endregion

				#region Methods for Property mimeType

				/// <summary>
				/// Gets current value of property {@link #getMimeType mimeType}.
				/// 
				/// Defines the allowed MIME types of files to be uploaded. The chosen files will be checked against an array of MIME types. If at least one file does not fit the MIME type requirements, the upload is prevented. This property is not supported by Internet Explorer 8 and 9. Example: mimeType ["image/png", "image/jpeg"].
				/// </summary>
				/// <returns>Value of property <code>mimeType</code></returns>
				public extern virtual string[] getMimeType();

				/// <summary>
				/// Sets a new value for property {@link #getMimeType mimeType}.
				/// 
				/// Defines the allowed MIME types of files to be uploaded. The chosen files will be checked against an array of MIME types. If at least one file does not fit the MIME type requirements, the upload is prevented. This property is not supported by Internet Explorer 8 and 9. Example: mimeType ["image/png", "image/jpeg"].
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sMimeType">New value for property <code>mimeType</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection setMimeType(string[] sMimeType);

				/// <summary>
				/// Sets a new value for property {@link #getMimeType mimeType}.
				/// 
				/// Defines the allowed MIME types of files to be uploaded. The chosen files will be checked against an array of MIME types. If at least one file does not fit the MIME type requirements, the upload is prevented. This property is not supported by Internet Explorer 8 and 9. Example: mimeType ["image/png", "image/jpeg"].
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sMimeType">New value for property <code>mimeType</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection setMimeType(object[] sMimeType);

				#endregion

				#region Methods for Property multiple

				/// <summary>
				/// Gets current value of property {@link #getMultiple multiple}.
				/// 
				/// Lets the user select multiple files from the same folder and then upload them. Internet Explorer 8 and 9 do not support this property. Please note that the various operating systems for mobile devices can react differently to the property so that fewer upload functions may be available in some cases.
				/// 
				/// If multiple property is set to false, the control shows an error message if more than one file is chosen for drag & drop.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>multiple</code></returns>
				public extern virtual bool getMultiple();

				/// <summary>
				/// Sets a new value for property {@link #getMultiple multiple}.
				/// 
				/// Lets the user select multiple files from the same folder and then upload them. Internet Explorer 8 and 9 do not support this property. Please note that the various operating systems for mobile devices can react differently to the property so that fewer upload functions may be available in some cases.
				/// 
				/// If multiple property is set to false, the control shows an error message if more than one file is chosen for drag & drop.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bMultiple">New value for property <code>multiple</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection setMultiple(bool bMultiple);

				#endregion

				#region Methods for Property noDataText

				/// <summary>
				/// Gets current value of property {@link #getNoDataText noDataText}.
				/// 
				/// Allows you to set your own text for the 'No data' text label.
				/// </summary>
				/// <returns>Value of property <code>noDataText</code></returns>
				public extern virtual string getNoDataText();

				/// <summary>
				/// Sets a new value for property {@link #getNoDataText noDataText}.
				/// 
				/// Allows you to set your own text for the 'No data' text label.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sNoDataText">New value for property <code>noDataText</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection setNoDataText(string sNoDataText);

				#endregion

				#region Methods for Property noDataDescription

				/// <summary>
				/// Gets current value of property {@link #getNoDataDescription noDataDescription}.
				/// 
				/// Allows you to set your own text for the 'No data' description label.
				/// </summary>
				/// <returns>Value of property <code>noDataDescription</code></returns>
				public extern virtual string getNoDataDescription();

				/// <summary>
				/// Sets a new value for property {@link #getNoDataDescription noDataDescription}.
				/// 
				/// Allows you to set your own text for the 'No data' description label.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sNoDataDescription">New value for property <code>noDataDescription</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection setNoDataDescription(string sNoDataDescription);

				#endregion

				#region Methods for Property sameFilenameAllowed

				/// <summary>
				/// Gets current value of property {@link #getSameFilenameAllowed sameFilenameAllowed}.
				/// 
				/// Allows the user to use the same name for a file when editing the file name. 'Same name' refers to an already existing file name in the list.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>sameFilenameAllowed</code></returns>
				public extern virtual bool getSameFilenameAllowed();

				/// <summary>
				/// Sets a new value for property {@link #getSameFilenameAllowed sameFilenameAllowed}.
				/// 
				/// Allows the user to use the same name for a file when editing the file name. 'Same name' refers to an already existing file name in the list.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bSameFilenameAllowed">New value for property <code>sameFilenameAllowed</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection setSameFilenameAllowed(bool bSameFilenameAllowed);

				#endregion

				#region Methods for Property showSeparators

				/// <summary>
				/// Gets current value of property {@link #getShowSeparators showSeparators}.
				/// 
				/// Defines whether separators are shown between list items.
				/// 
				/// Default value is <code>All</code>.
				/// </summary>
				/// <returns>Value of property <code>showSeparators</code></returns>
				public extern virtual sap.m.ListSeparators getShowSeparators();

				/// <summary>
				/// Sets a new value for property {@link #getShowSeparators showSeparators}.
				/// 
				/// Defines whether separators are shown between list items.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>All</code>.
				/// </summary>
				/// <param name="sShowSeparators">New value for property <code>showSeparators</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection setShowSeparators(sap.m.ListSeparators sShowSeparators);

				#endregion

				#region Methods for Property uploadEnabled

				/// <summary>
				/// Gets current value of property {@link #getUploadEnabled uploadEnabled}.
				/// 
				/// Enables the upload of a file.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>uploadEnabled</code></returns>
				public extern virtual bool getUploadEnabled();

				/// <summary>
				/// Sets a new value for property {@link #getUploadEnabled uploadEnabled}.
				/// 
				/// Enables the upload of a file.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bUploadEnabled">New value for property <code>uploadEnabled</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection setUploadEnabled(bool bUploadEnabled);

				#endregion

				#region Methods for Property uploadUrl

				/// <summary>
				/// Gets current value of property {@link #getUploadUrl uploadUrl}.
				/// 
				/// Specifies the URL where the uploaded files have to be stored.
				/// 
				/// Default value is <code>../../../upload</code>.
				/// </summary>
				/// <returns>Value of property <code>uploadUrl</code></returns>
				public extern virtual string getUploadUrl();

				/// <summary>
				/// Sets a new value for property {@link #getUploadUrl uploadUrl}.
				/// 
				/// Specifies the URL where the uploaded files have to be stored.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>../../../upload</code>.
				/// </summary>
				/// <param name="sUploadUrl">New value for property <code>uploadUrl</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection setUploadUrl(string sUploadUrl);

				#endregion

				#region Methods for Property instantUpload

				/// <summary>
				/// Gets current value of property {@link #getInstantUpload instantUpload}.
				/// 
				/// If false, no upload is triggered when a file is selected. In addition, if a file was selected, a new FileUploader instance is created to ensure that multiple files from multiple folders can be chosen.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>instantUpload</code></returns>
				public extern virtual bool getInstantUpload();

				/// <summary>
				/// Sets a new value for property {@link #getInstantUpload instantUpload}.
				/// 
				/// If false, no upload is triggered when a file is selected. In addition, if a file was selected, a new FileUploader instance is created to ensure that multiple files from multiple folders can be chosen.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bInstantUpload">New value for property <code>instantUpload</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection setInstantUpload(bool bInstantUpload);

				#endregion

				#region Methods for Property numberOfAttachmentsText

				/// <summary>
				/// Gets current value of property {@link #getNumberOfAttachmentsText numberOfAttachmentsText}.
				/// 
				/// Sets the title text in the toolbar of the list of attachments. To show as well the number of attachments in brackets like the default text does. The number of attachments could be retrieved via "getItems().length". If a new title is set, the default is deactivated. The default value is set to language-dependent "Attachments (n)".
				/// </summary>
				/// <returns>Value of property <code>numberOfAttachmentsText</code></returns>
				public extern virtual string getNumberOfAttachmentsText();

				/// <summary>
				/// Sets a new value for property {@link #getNumberOfAttachmentsText numberOfAttachmentsText}.
				/// 
				/// Sets the title text in the toolbar of the list of attachments. To show as well the number of attachments in brackets like the default text does. The number of attachments could be retrieved via "getItems().length". If a new title is set, the default is deactivated. The default value is set to language-dependent "Attachments (n)".
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sNumberOfAttachmentsText">New value for property <code>numberOfAttachmentsText</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection setNumberOfAttachmentsText(string sNumberOfAttachmentsText);

				#endregion

				#region Methods for Property mode

				/// <summary>
				/// Gets current value of property {@link #getMode mode}.
				/// 
				/// Defines the selection mode of the control (e.g. None, SingleSelect, MultiSelect, SingleSelectLeft, SingleSelectMaster). Since the UploadCollection reacts like a list for attachments, the API is close to the ListBase Interface. sap.m.ListMode.Delete mode is not supported and will be automatically set to sap.m.ListMode.None. In addition, if instant upload is set to false the mode sap.m.ListMode.MultiSelect is not supported and will be automatically set to sap.m.ListMode.None.
				/// 
				/// Default value is <code>None</code>.
				/// </summary>
				/// <returns>Value of property <code>mode</code></returns>
				public extern virtual sap.m.ListMode getMode();

				/// <summary>
				/// Sets a new value for property {@link #getMode mode}.
				/// 
				/// Defines the selection mode of the control (e.g. None, SingleSelect, MultiSelect, SingleSelectLeft, SingleSelectMaster). Since the UploadCollection reacts like a list for attachments, the API is close to the ListBase Interface. sap.m.ListMode.Delete mode is not supported and will be automatically set to sap.m.ListMode.None. In addition, if instant upload is set to false the mode sap.m.ListMode.MultiSelect is not supported and will be automatically set to sap.m.ListMode.None.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>None</code>.
				/// </summary>
				/// <param name="sMode">New value for property <code>mode</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection setMode(sap.m.ListMode sMode);

				#endregion

				#region Methods for Property uploadButtonInvisible

				/// <summary>
				/// Gets current value of property {@link #getUploadButtonInvisible uploadButtonInvisible}.
				/// 
				/// If true, the button used for uploading files is invisible.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>uploadButtonInvisible</code></returns>
				public extern virtual bool getUploadButtonInvisible();

				/// <summary>
				/// Sets a new value for property {@link #getUploadButtonInvisible uploadButtonInvisible}.
				/// 
				/// If true, the button used for uploading files is invisible.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bUploadButtonInvisible">New value for property <code>uploadButtonInvisible</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection setUploadButtonInvisible(bool bUploadButtonInvisible);

				#endregion

				#region Methods for Property terminationEnabled

				/// <summary>
				/// Gets current value of property {@link #getTerminationEnabled terminationEnabled}.
				/// 
				/// If true, the button that is used to terminate the instant file upload gets visible. The button normally appears when a file is being uploaded.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>terminationEnabled</code></returns>
				public extern virtual bool getTerminationEnabled();

				/// <summary>
				/// Sets a new value for property {@link #getTerminationEnabled terminationEnabled}.
				/// 
				/// If true, the button that is used to terminate the instant file upload gets visible. The button normally appears when a file is being uploaded.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bTerminationEnabled">New value for property <code>terminationEnabled</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection setTerminationEnabled(bool bTerminationEnabled);

				#endregion

				#region Methods for Aggregation items

				/// <summary>
				/// Gets content of aggregation {@link #getItems items}.
				/// 
				/// Uploaded items.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.UploadCollectionItem[] getItems();

				/// <summary>
				/// Destroys all the items in the aggregation {@link #getItems items}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection destroyItems();

				/// <summary>
				/// Inserts a item into the aggregation {@link #getItems items}.
				/// </summary>
				/// <param name="oItem">The item to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the item should be inserted at; for a negative value of <code>iIndex</code>, the item is inserted at position 0; for a value greater than the current size of the aggregation, the item is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection insertItem(sap.m.UploadCollectionItem oItem, int iIndex);

				/// <summary>
				/// Adds some item to the aggregation {@link #getItems items}.
				/// </summary>
				/// <param name="oItem">The item to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection addItem(sap.m.UploadCollectionItem oItem);

				/// <summary>
				/// Removes a item from the aggregation {@link #getItems items}.
				/// </summary>
				/// <param name="vItem">The item to remove or its index or id</param>
				/// <returns>The removed item or <code>null</code></returns>
				public extern virtual sap.m.UploadCollectionItem removeItem(Union<int, string, sap.m.UploadCollectionItem> vItem);

				/// <summary>
				/// Checks for the provided <code>sap.m.UploadCollectionItem</code> in the aggregation {@link #getItems items}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oItem">The item whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfItem(sap.m.UploadCollectionItem oItem);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getItems items}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.m.UploadCollectionItem[] removeAllItems();

				/// <summary>
				/// Binds aggregation {@link #getItems items} to model data.
				/// 
				/// See {@link sap.ui.base.ManagedObject#bindAggregation ManagedObject.bindAggregation} for a detailed description of the possible properties of <code>oBindingInfo</code>.
				/// </summary>
				/// <param name="oBindingInfo">The binding information</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection bindItems(sap.ui.@base.ManagedObject.BindAggregationInfo oBindingInfo);

				/// <summary>
				/// Unbinds aggregation {@link #getItems items} from model data.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection unbindItems();

				#endregion

				#region Methods for Aggregation headerParameters

				/// <summary>
				/// Gets content of aggregation {@link #getHeaderParameters headerParameters}.
				/// 
				/// Specifies the header parameters for the FileUploader that are submitted only with XHR requests. Header parameters are not supported by Internet Explorer 8 and 9.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.UploadCollectionParameter[] getHeaderParameters();

				/// <summary>
				/// Destroys all the headerParameters in the aggregation {@link #getHeaderParameters headerParameters}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection destroyHeaderParameters();

				/// <summary>
				/// Inserts a headerParameter into the aggregation {@link #getHeaderParameters headerParameters}.
				/// </summary>
				/// <param name="oHeaderParameter">The headerParameter to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the headerParameter should be inserted at; for a negative value of <code>iIndex</code>, the headerParameter is inserted at position 0; for a value greater than the current size of the aggregation, the headerParameter is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection insertHeaderParameter(sap.m.UploadCollectionParameter oHeaderParameter, int iIndex);

				/// <summary>
				/// Adds some headerParameter to the aggregation {@link #getHeaderParameters headerParameters}.
				/// </summary>
				/// <param name="oHeaderParameter">The headerParameter to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection addHeaderParameter(sap.m.UploadCollectionParameter oHeaderParameter);

				/// <summary>
				/// Removes a headerParameter from the aggregation {@link #getHeaderParameters headerParameters}.
				/// </summary>
				/// <param name="vHeaderParameter">The headerParameter to remove or its index or id</param>
				/// <returns>The removed headerParameter or <code>null</code></returns>
				public extern virtual sap.m.UploadCollectionParameter removeHeaderParameter(Union<int, string, sap.m.UploadCollectionParameter> vHeaderParameter);

				/// <summary>
				/// Checks for the provided <code>sap.m.UploadCollectionParameter</code> in the aggregation {@link #getHeaderParameters headerParameters}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oHeaderParameter">The headerParameter whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfHeaderParameter(sap.m.UploadCollectionParameter oHeaderParameter);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getHeaderParameters headerParameters}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.m.UploadCollectionParameter[] removeAllHeaderParameters();

				#endregion

				#region Methods for Aggregation parameters

				/// <summary>
				/// Gets content of aggregation {@link #getParameters parameters}.
				/// 
				/// Specifies the parameters for the FileUploader that are rendered as a hidden input field.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.UploadCollectionParameter[] getParameters();

				/// <summary>
				/// Destroys all the parameters in the aggregation {@link #getParameters parameters}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection destroyParameters();

				/// <summary>
				/// Inserts a parameter into the aggregation {@link #getParameters parameters}.
				/// </summary>
				/// <param name="oParameter">The parameter to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the parameter should be inserted at; for a negative value of <code>iIndex</code>, the parameter is inserted at position 0; for a value greater than the current size of the aggregation, the parameter is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection insertParameter(sap.m.UploadCollectionParameter oParameter, int iIndex);

				/// <summary>
				/// Adds some parameter to the aggregation {@link #getParameters parameters}.
				/// </summary>
				/// <param name="oParameter">The parameter to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection addParameter(sap.m.UploadCollectionParameter oParameter);

				/// <summary>
				/// Removes a parameter from the aggregation {@link #getParameters parameters}.
				/// </summary>
				/// <param name="vParameter">The parameter to remove or its index or id</param>
				/// <returns>The removed parameter or <code>null</code></returns>
				public extern virtual sap.m.UploadCollectionParameter removeParameter(Union<int, string, sap.m.UploadCollectionParameter> vParameter);

				/// <summary>
				/// Checks for the provided <code>sap.m.UploadCollectionParameter</code> in the aggregation {@link #getParameters parameters}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oParameter">The parameter whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfParameter(sap.m.UploadCollectionParameter oParameter);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getParameters parameters}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.m.UploadCollectionParameter[] removeAllParameters();

				#endregion

				#region Methods for Aggregation toolbar

				/// <summary>
				/// Gets content of aggregation {@link #getToolbar toolbar}.
				/// 
				/// Specifies the toolbar.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.OverflowToolbar getToolbar();

				/// <summary>
				/// Destroys the toolbar in the aggregation {@link #getToolbar toolbar}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection destroyToolbar();

				/// <summary>
				/// Sets the aggregated {@link #getToolbar toolbar}.
				/// </summary>
				/// <param name="oToolbar">The toolbar to set</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection setToolbar(sap.m.OverflowToolbar oToolbar);

				#endregion

				#region Methods for Aggregation infoToolbar

				/// <summary>
				/// Gets content of aggregation {@link #getInfoToolbar infoToolbar}.
				/// 
				/// Specifies the info toolbar for filtering information. Sorting information will not displayed.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.Toolbar getInfoToolbar();

				/// <summary>
				/// Destroys the infoToolbar in the aggregation {@link #getInfoToolbar infoToolbar}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection destroyInfoToolbar();

				/// <summary>
				/// Sets the aggregated {@link #getInfoToolbar infoToolbar}.
				/// </summary>
				/// <param name="oInfoToolbar">The infoToolbar to set</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection setInfoToolbar(sap.m.Toolbar oInfoToolbar);

				#endregion

				#region Methods for Aggregation _list

				#endregion

				#region Methods for Aggregation _noDataIcon

				#endregion

				#region Methods for Aggregation _dragDropIcon

				#endregion

				#region Methods for Aggregation _dragDropText

				#endregion

				#region Methods for Event change

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:change change} event of this <code>sap.m.UploadCollection</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.UploadCollection</code> itself.
				/// 
				/// The event is triggered when files are selected in the FileUploader dialog. Applications can set parameters and headerParameters which will be dispatched to the embedded FileUploader control. Limitation: parameters and headerParameters are not supported by Internet Explorer 9.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.UploadCollection</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection attachChange(object oData, sap.m.UploadCollection.NotifyDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:change change} event of this <code>sap.m.UploadCollection</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.UploadCollection</code> itself.
				/// 
				/// The event is triggered when files are selected in the FileUploader dialog. Applications can set parameters and headerParameters which will be dispatched to the embedded FileUploader control. Limitation: parameters and headerParameters are not supported by Internet Explorer 9.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection attachChange(object oData, sap.m.UploadCollection.NotifyDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:change change} event of this <code>sap.m.UploadCollection</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.UploadCollection</code> itself.
				/// 
				/// The event is triggered when files are selected in the FileUploader dialog. Applications can set parameters and headerParameters which will be dispatched to the embedded FileUploader control. Limitation: parameters and headerParameters are not supported by Internet Explorer 9.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection attachChange(sap.m.UploadCollection.NotifyDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:change change} event of this <code>sap.m.UploadCollection</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.UploadCollection</code> itself.
				/// 
				/// The event is triggered when files are selected in the FileUploader dialog. Applications can set parameters and headerParameters which will be dispatched to the embedded FileUploader control. Limitation: parameters and headerParameters are not supported by Internet Explorer 9.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.UploadCollection</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection attachChange(sap.m.UploadCollection.NotifyDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:change change} event of this <code>sap.m.UploadCollection</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection detachChange(sap.m.UploadCollection.NotifyDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:change change} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection fireChange(sap.m.UploadCollection.NotifyInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:change change} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection fireChange();

				#endregion

				#region Methods for Event fileDeleted

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:fileDeleted fileDeleted} event of this <code>sap.m.UploadCollection</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.UploadCollection</code> itself.
				/// 
				/// The event is triggered when an uploaded attachment is selected and the Delete button is pressed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.UploadCollection</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection attachFileDeleted(object oData, sap.m.UploadCollection.FileDeletedDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:fileDeleted fileDeleted} event of this <code>sap.m.UploadCollection</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.UploadCollection</code> itself.
				/// 
				/// The event is triggered when an uploaded attachment is selected and the Delete button is pressed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection attachFileDeleted(object oData, sap.m.UploadCollection.FileDeletedDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:fileDeleted fileDeleted} event of this <code>sap.m.UploadCollection</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.UploadCollection</code> itself.
				/// 
				/// The event is triggered when an uploaded attachment is selected and the Delete button is pressed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection attachFileDeleted(sap.m.UploadCollection.FileDeletedDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:fileDeleted fileDeleted} event of this <code>sap.m.UploadCollection</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.UploadCollection</code> itself.
				/// 
				/// The event is triggered when an uploaded attachment is selected and the Delete button is pressed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.UploadCollection</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection attachFileDeleted(sap.m.UploadCollection.FileDeletedDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:fileDeleted fileDeleted} event of this <code>sap.m.UploadCollection</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection detachFileDeleted(sap.m.UploadCollection.FileDeletedDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:fileDeleted fileDeleted} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection fireFileDeleted(sap.m.UploadCollection.FileDeletedInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:fileDeleted fileDeleted} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection fireFileDeleted();

				#endregion

				#region Methods for Event filenameLengthExceed

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:filenameLengthExceed filenameLengthExceed} event of this <code>sap.m.UploadCollection</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.UploadCollection</code> itself.
				/// 
				/// The event is triggered when the name of a chosen file is longer than the value specified with the maximumFilenameLength property (only if provided by the application).
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.UploadCollection</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection attachFilenameLengthExceed(object oData, sap.m.UploadCollection.NotifyDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:filenameLengthExceed filenameLengthExceed} event of this <code>sap.m.UploadCollection</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.UploadCollection</code> itself.
				/// 
				/// The event is triggered when the name of a chosen file is longer than the value specified with the maximumFilenameLength property (only if provided by the application).
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection attachFilenameLengthExceed(object oData, sap.m.UploadCollection.NotifyDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:filenameLengthExceed filenameLengthExceed} event of this <code>sap.m.UploadCollection</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.UploadCollection</code> itself.
				/// 
				/// The event is triggered when the name of a chosen file is longer than the value specified with the maximumFilenameLength property (only if provided by the application).
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection attachFilenameLengthExceed(sap.m.UploadCollection.NotifyDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:filenameLengthExceed filenameLengthExceed} event of this <code>sap.m.UploadCollection</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.UploadCollection</code> itself.
				/// 
				/// The event is triggered when the name of a chosen file is longer than the value specified with the maximumFilenameLength property (only if provided by the application).
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.UploadCollection</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection attachFilenameLengthExceed(sap.m.UploadCollection.NotifyDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:filenameLengthExceed filenameLengthExceed} event of this <code>sap.m.UploadCollection</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection detachFilenameLengthExceed(sap.m.UploadCollection.NotifyDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:filenameLengthExceed filenameLengthExceed} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection fireFilenameLengthExceed(sap.m.UploadCollection.NotifyInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:filenameLengthExceed filenameLengthExceed} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection fireFilenameLengthExceed();

				#endregion

				#region Methods for Event fileRenamed

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:fileRenamed fileRenamed} event of this <code>sap.m.UploadCollection</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.UploadCollection</code> itself.
				/// 
				/// The event is triggered when the file name is changed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.UploadCollection</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection attachFileRenamed(object oData, sap.m.UploadCollection.FileRenamedDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:fileRenamed fileRenamed} event of this <code>sap.m.UploadCollection</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.UploadCollection</code> itself.
				/// 
				/// The event is triggered when the file name is changed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection attachFileRenamed(object oData, sap.m.UploadCollection.FileRenamedDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:fileRenamed fileRenamed} event of this <code>sap.m.UploadCollection</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.UploadCollection</code> itself.
				/// 
				/// The event is triggered when the file name is changed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection attachFileRenamed(sap.m.UploadCollection.FileRenamedDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:fileRenamed fileRenamed} event of this <code>sap.m.UploadCollection</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.UploadCollection</code> itself.
				/// 
				/// The event is triggered when the file name is changed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.UploadCollection</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection attachFileRenamed(sap.m.UploadCollection.FileRenamedDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:fileRenamed fileRenamed} event of this <code>sap.m.UploadCollection</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection detachFileRenamed(sap.m.UploadCollection.FileRenamedDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:fileRenamed fileRenamed} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection fireFileRenamed(sap.m.UploadCollection.FileRenamedInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:fileRenamed fileRenamed} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection fireFileRenamed();

				#endregion

				#region Methods for Event fileSizeExceed

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:fileSizeExceed fileSizeExceed} event of this <code>sap.m.UploadCollection</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.UploadCollection</code> itself.
				/// 
				/// The event is triggered when the file size of an uploaded file is exceeded (only if the maxFileSize property was provided by the application). This event is not supported by Internet Explorer 9.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.UploadCollection</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection attachFileSizeExceed(object oData, sap.m.UploadCollection.FileSizeExceedDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:fileSizeExceed fileSizeExceed} event of this <code>sap.m.UploadCollection</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.UploadCollection</code> itself.
				/// 
				/// The event is triggered when the file size of an uploaded file is exceeded (only if the maxFileSize property was provided by the application). This event is not supported by Internet Explorer 9.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection attachFileSizeExceed(object oData, sap.m.UploadCollection.FileSizeExceedDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:fileSizeExceed fileSizeExceed} event of this <code>sap.m.UploadCollection</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.UploadCollection</code> itself.
				/// 
				/// The event is triggered when the file size of an uploaded file is exceeded (only if the maxFileSize property was provided by the application). This event is not supported by Internet Explorer 9.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection attachFileSizeExceed(sap.m.UploadCollection.FileSizeExceedDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:fileSizeExceed fileSizeExceed} event of this <code>sap.m.UploadCollection</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.UploadCollection</code> itself.
				/// 
				/// The event is triggered when the file size of an uploaded file is exceeded (only if the maxFileSize property was provided by the application). This event is not supported by Internet Explorer 9.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.UploadCollection</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection attachFileSizeExceed(sap.m.UploadCollection.FileSizeExceedDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:fileSizeExceed fileSizeExceed} event of this <code>sap.m.UploadCollection</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection detachFileSizeExceed(sap.m.UploadCollection.FileSizeExceedDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:fileSizeExceed fileSizeExceed} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection fireFileSizeExceed(sap.m.UploadCollection.FileSizeExceedInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:fileSizeExceed fileSizeExceed} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection fireFileSizeExceed();

				#endregion

				#region Methods for Event typeMissmatch

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:typeMissmatch typeMissmatch} event of this <code>sap.m.UploadCollection</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.UploadCollection</code> itself.
				/// 
				/// The event is triggered when the file type or the MIME type don't match the permitted types (only if the fileType property or the mimeType property are provided by the application).
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.UploadCollection</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection attachTypeMissmatch(object oData, sap.m.UploadCollection.TypeMissmatchDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:typeMissmatch typeMissmatch} event of this <code>sap.m.UploadCollection</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.UploadCollection</code> itself.
				/// 
				/// The event is triggered when the file type or the MIME type don't match the permitted types (only if the fileType property or the mimeType property are provided by the application).
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection attachTypeMissmatch(object oData, sap.m.UploadCollection.TypeMissmatchDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:typeMissmatch typeMissmatch} event of this <code>sap.m.UploadCollection</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.UploadCollection</code> itself.
				/// 
				/// The event is triggered when the file type or the MIME type don't match the permitted types (only if the fileType property or the mimeType property are provided by the application).
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection attachTypeMissmatch(sap.m.UploadCollection.TypeMissmatchDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:typeMissmatch typeMissmatch} event of this <code>sap.m.UploadCollection</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.UploadCollection</code> itself.
				/// 
				/// The event is triggered when the file type or the MIME type don't match the permitted types (only if the fileType property or the mimeType property are provided by the application).
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.UploadCollection</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection attachTypeMissmatch(sap.m.UploadCollection.TypeMissmatchDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:typeMissmatch typeMissmatch} event of this <code>sap.m.UploadCollection</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection detachTypeMissmatch(sap.m.UploadCollection.TypeMissmatchDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:typeMissmatch typeMissmatch} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection fireTypeMissmatch(sap.m.UploadCollection.TypeMissmatchInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:typeMissmatch typeMissmatch} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection fireTypeMissmatch();

				#endregion

				#region Methods for Event uploadComplete

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:uploadComplete uploadComplete} event of this <code>sap.m.UploadCollection</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.UploadCollection</code> itself.
				/// 
				/// The event is triggered as soon as the upload request is completed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.UploadCollection</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection attachUploadComplete(object oData, sap.m.UploadCollection.UploadCompleteDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:uploadComplete uploadComplete} event of this <code>sap.m.UploadCollection</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.UploadCollection</code> itself.
				/// 
				/// The event is triggered as soon as the upload request is completed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection attachUploadComplete(object oData, sap.m.UploadCollection.UploadCompleteDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:uploadComplete uploadComplete} event of this <code>sap.m.UploadCollection</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.UploadCollection</code> itself.
				/// 
				/// The event is triggered as soon as the upload request is completed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection attachUploadComplete(sap.m.UploadCollection.UploadCompleteDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:uploadComplete uploadComplete} event of this <code>sap.m.UploadCollection</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.UploadCollection</code> itself.
				/// 
				/// The event is triggered as soon as the upload request is completed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.UploadCollection</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection attachUploadComplete(sap.m.UploadCollection.UploadCompleteDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:uploadComplete uploadComplete} event of this <code>sap.m.UploadCollection</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection detachUploadComplete(sap.m.UploadCollection.UploadCompleteDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:uploadComplete uploadComplete} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection fireUploadComplete(sap.m.UploadCollection.UploadCompleteInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:uploadComplete uploadComplete} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection fireUploadComplete();

				#endregion

				#region Methods for Event uploadTerminated

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:uploadTerminated uploadTerminated} event of this <code>sap.m.UploadCollection</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.UploadCollection</code> itself.
				/// 
				/// The event is triggered as soon as the upload request was terminated by the user.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.UploadCollection</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection attachUploadTerminated(object oData, sap.m.UploadCollection.UploadTerminatedDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:uploadTerminated uploadTerminated} event of this <code>sap.m.UploadCollection</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.UploadCollection</code> itself.
				/// 
				/// The event is triggered as soon as the upload request was terminated by the user.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection attachUploadTerminated(object oData, sap.m.UploadCollection.UploadTerminatedDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:uploadTerminated uploadTerminated} event of this <code>sap.m.UploadCollection</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.UploadCollection</code> itself.
				/// 
				/// The event is triggered as soon as the upload request was terminated by the user.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection attachUploadTerminated(sap.m.UploadCollection.UploadTerminatedDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:uploadTerminated uploadTerminated} event of this <code>sap.m.UploadCollection</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.UploadCollection</code> itself.
				/// 
				/// The event is triggered as soon as the upload request was terminated by the user.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.UploadCollection</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection attachUploadTerminated(sap.m.UploadCollection.UploadTerminatedDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:uploadTerminated uploadTerminated} event of this <code>sap.m.UploadCollection</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection detachUploadTerminated(sap.m.UploadCollection.UploadTerminatedDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:uploadTerminated uploadTerminated} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection fireUploadTerminated(sap.m.UploadCollection.UploadTerminatedInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:uploadTerminated uploadTerminated} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection fireUploadTerminated();

				#endregion

				#region Methods for Event beforeUploadStarts

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeUploadStarts beforeUploadStarts} event of this <code>sap.m.UploadCollection</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.UploadCollection</code> itself.
				/// 
				/// The event is triggered before the actual upload starts. An event is fired per file. All the necessary header parameters should be set here.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.UploadCollection</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection attachBeforeUploadStarts(object oData, sap.m.UploadCollection.BeforeUploadStartsDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeUploadStarts beforeUploadStarts} event of this <code>sap.m.UploadCollection</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.UploadCollection</code> itself.
				/// 
				/// The event is triggered before the actual upload starts. An event is fired per file. All the necessary header parameters should be set here.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection attachBeforeUploadStarts(object oData, sap.m.UploadCollection.BeforeUploadStartsDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeUploadStarts beforeUploadStarts} event of this <code>sap.m.UploadCollection</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.UploadCollection</code> itself.
				/// 
				/// The event is triggered before the actual upload starts. An event is fired per file. All the necessary header parameters should be set here.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection attachBeforeUploadStarts(sap.m.UploadCollection.BeforeUploadStartsDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:beforeUploadStarts beforeUploadStarts} event of this <code>sap.m.UploadCollection</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.UploadCollection</code> itself.
				/// 
				/// The event is triggered before the actual upload starts. An event is fired per file. All the necessary header parameters should be set here.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.UploadCollection</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection attachBeforeUploadStarts(sap.m.UploadCollection.BeforeUploadStartsDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:beforeUploadStarts beforeUploadStarts} event of this <code>sap.m.UploadCollection</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection detachBeforeUploadStarts(sap.m.UploadCollection.BeforeUploadStartsDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:beforeUploadStarts beforeUploadStarts} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection fireBeforeUploadStarts(sap.m.UploadCollection.BeforeUploadStartsInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:beforeUploadStarts beforeUploadStarts} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection fireBeforeUploadStarts();

				#endregion

				#region Methods for Event selectionChange

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:selectionChange selectionChange} event of this <code>sap.m.UploadCollection</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.UploadCollection</code> itself.
				/// 
				/// Fires when selection is changed via user interaction inside the control.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.UploadCollection</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection attachSelectionChange(object oData, sap.m.UploadCollection.SelectionChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:selectionChange selectionChange} event of this <code>sap.m.UploadCollection</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.UploadCollection</code> itself.
				/// 
				/// Fires when selection is changed via user interaction inside the control.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection attachSelectionChange(object oData, sap.m.UploadCollection.SelectionChangeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:selectionChange selectionChange} event of this <code>sap.m.UploadCollection</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.UploadCollection</code> itself.
				/// 
				/// Fires when selection is changed via user interaction inside the control.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection attachSelectionChange(sap.m.UploadCollection.SelectionChangeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:selectionChange selectionChange} event of this <code>sap.m.UploadCollection</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.UploadCollection</code> itself.
				/// 
				/// Fires when selection is changed via user interaction inside the control.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.UploadCollection</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection attachSelectionChange(sap.m.UploadCollection.SelectionChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:selectionChange selectionChange} event of this <code>sap.m.UploadCollection</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection detachSelectionChange(sap.m.UploadCollection.SelectionChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:selectionChange selectionChange} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection fireSelectionChange(sap.m.UploadCollection.SelectionChangeInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:selectionChange selectionChange} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection fireSelectionChange();

				#endregion

				#region Other methods

				/// <summary>
				/// Downloads the given item. This function delegates to {@link sap.m.UploadCollectionItem#download uploadCollectionItem.download}.
				/// </summary>
				/// <param name="uploadCollectionItem">The item to download. This parameter is mandatory.</param>
				/// <param name="askForLocation">Decides whether to ask for a location to download or not.</param>
				/// <returns>True if the download has started successfully. False if the download couldn't be started.</returns>
				public extern virtual bool downloadItem(sap.m.UploadCollectionItem uploadCollectionItem, bool askForLocation);

				/// <summary>
				/// Creates a new subclass of class sap.m.UploadCollection with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.UploadCollection with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.UploadCollection with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Provides access to the internally used request headers to allow adding them to the "Access-Control-Allow-Headers" header parameter if needed.
				/// </summary>
				/// <returns>An array of request header strings</returns>
				public extern virtual string[] getInternalRequestHeaderNames();

				/// <summary>
				/// Returns a metadata object for class sap.m.UploadCollection.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				[Name("getMetadata")]
				public extern static sap.ui.@base.Metadata getMetadataStatic();

				/// <summary>
				/// Retrieves the currently selected UploadCollectionItem.
				/// </summary>
				/// <returns>The currently selected item or null</returns>
				public extern virtual sap.m.UploadCollectionItem getSelectedItem();

				/// <summary>
				/// Returns an array containing the selected UploadCollectionItems.
				/// </summary>
				/// <returns>Array of all selected items</returns>
				public extern virtual sap.m.UploadCollectionItem[] getSelectedItems();

				/// <summary>
				/// Opens the FileUploader dialog. When an UploadCollectionItem is provided, this method can be used to update a file with a new version. In this case, the upload progress can be sequenced using the events: beforeUploadStarts, uploadComplete and uploadTerminated. For this use, multiple properties from the UploadCollection have to be set to false. If no UploadCollectionItem is provided, only the dialog opens and no further configuration of the UploadCollection is needed.
				/// </summary>
				/// <param name="item">The item to update with a new version. This parameter is mandatory.</param>
				/// <returns>this to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection openFileDialog(sap.m.UploadCollectionItem item);

				/// <summary>
				/// Select all items in "MultiSelection" mode.
				/// </summary>
				/// <returns>this to allow method changing</returns>
				public extern virtual sap.m.UploadCollection selectAll();

				/// <summary>
				/// Selects or deselects the given list item.
				/// </summary>
				/// <param name="uploadCollectionItem">The item whose selection is to be changed. This parameter is mandatory.</param>
				/// <param name="select">The selection state of the item. Default value is true.</param>
				/// <returns>this to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection setSelectedItem(sap.m.UploadCollectionItem uploadCollectionItem, bool select);

				/// <summary>
				/// Sets an UploadCollectionItem to be selected by ID. In single selection mode, the method removes the previous selection.
				/// </summary>
				/// <param name="id">The ID of the item whose selection is to be changed.</param>
				/// <param name="select">The selection state of the item. Default value is true.</param>
				/// <returns>this to allow method chaining</returns>
				public extern virtual sap.m.UploadCollection setSelectedItemById(string id, bool select);

				/// <summary>
				/// Starts the upload for all selected files.
				/// </summary>
				public extern virtual void upload();

				#endregion

				#endregion

			}
		}
	}
}
