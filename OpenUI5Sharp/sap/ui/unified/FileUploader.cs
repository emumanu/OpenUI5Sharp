using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public static partial class sap
	{
		public static partial class ui
		{
			public static partial class unified
			{
				/// <summary>
				/// The framework generates an input field and a button with text "Browse ...". The API supports features such as on change uploads (the upload starts immediately after a file has been selected), file uploads with explicit calls, adjustable control sizes, text display after uploads, or tooltips containing complete file paths.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.unified.FileUploader")]
				public partial class FileUploader : sap.ui.core.Control, sap.ui.core.IFormContent, sap.ui.unified.IProcessableBlobs
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
						/// Value of the path for file upload.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> value;

						/// <summary>
						/// Disabled controls have different colors, depending on customer settings.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> enabled;

						/// <summary>
						/// Used when URL address is on a remote server.
						/// </summary>
						public Union<sap.ui.core.URI, string, sap.ui.@base.ManagedObject.BindPropertyInfo> uploadUrl;

						/// <summary>
						/// Unique control name for identification on the server side after sending data to the server.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> name;

						/// <summary>
						/// Specifies the displayed control width.
						/// </summary>
						public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> width;

						/// <summary>
						/// If set to "true", the upload immediately starts after file selection. With the default setting, the upload needs to be explicitly triggered.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> uploadOnChange;

						/// <summary>
						/// Additional data that is sent to the back end service. Data will be transmitted as value of a hidden input where the name is derived from the name property with suffix -data.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> additionalData;

						/// <summary>
						/// If the FileUploader is configured to upload the file directly after the file is selected it is not allowed to upload a file with the same name again. If a user should be allowed to upload a file with the same name again this parameter has to be "true". A typical use case would be if the files have different paths.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> sameFilenameAllowed;

						/// <summary>
						/// The Button text can be overwritten using this property.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> buttonText;

						/// <summary>
						/// The chosen files will be checked against an array of file types. If at least one file does not fit the file type restriction the upload is prevented. Example: ["jpg", "png", "bmp"].
						/// </summary>
						public Union<string[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> fileType;

						/// <summary>
						/// Allows multiple files to be chosen and uploaded from the same folder. This property is not supported by Internet Explorer 9.
						/// 
						/// <b>Note:</b> Keep in mind that the various operating systems for mobile devices can react differently to the property so that fewer upload functions may be available in some cases.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> multiple;

						/// <summary>
						/// A file size limit in megabytes which prevents the upload if at least one file exceeds it. This property is not supported by Internet Explorer 9.
						/// </summary>
						public Union<float, string, sap.ui.@base.ManagedObject.BindPropertyInfo> maximumFileSize;

						/// <summary>
						/// The chosen files will be checked against an array of mime types. If at least one file does not fit the mime type restriction the upload is prevented. This property is not supported by Internet Explorer 9. Example: mimeType ["image/png", "image/jpeg"].
						/// </summary>
						public Union<string[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> mimeType;

						/// <summary>
						/// If set to "true", the request will be sent as XHR request instead of a form submit. This property is not supported by Internet Explorer 9.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> sendXHR;

						/// <summary>
						/// Placeholder for the text field.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> placeholder;

						/// <summary>
						/// Style of the button. "Transparent, "Accept", "Reject", or "Emphasized" is allowed.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> style;

						/// <summary>
						/// If set to "true", the FileUploader will be rendered as Button only, without showing the InputField.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> buttonOnly;

						/// <summary>
						/// If set to "false", the request will be sent as file only request instead of a multipart/form-data request. Only one file could be uploaded using this type of request. Required for sending such a request is to set the property "sendXHR" to "true". This property is not supported by Internet Explorer 9.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> useMultipart;

						/// <summary>
						/// The maximum length of a filename which the FileUploader will accept. If the maximum filename length is exceeded, the corresponding Event 'filenameLengthExceed' is fired.
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> maximumFilenameLength;

						/// <summary>
						/// Visualizes warnings or errors related to the text field. Possible values: Warning, Error, Success, None.
						/// </summary>
						public Union<sap.ui.core.ValueState, string, sap.ui.@base.ManagedObject.BindPropertyInfo> valueState;

						/// <summary>
						/// Custom text for the value state message pop-up.
						/// 
						/// <b>Note:</b> If not specified, a default text, based on the value state type, will be used instead.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> valueStateText;

						/// <summary>
						/// Icon to be displayed as graphical element within the button. This can be a URI to an image or an icon font URI.
						/// </summary>
						public Union<sap.ui.core.URI, string, sap.ui.@base.ManagedObject.BindPropertyInfo> icon;

						/// <summary>
						/// Icon to be displayed as graphical element within the button when it is hovered (only if also a base icon was specified). If not specified the base icon is used. If an icon font icon is used, this property is ignored.
						/// </summary>
						public Union<sap.ui.core.URI, string, sap.ui.@base.ManagedObject.BindPropertyInfo> iconHovered;

						/// <summary>
						/// Icon to be displayed as graphical element within the button when it is selected (only if also a base icon was specified). If not specified the base or hovered icon is used. If an icon font icon is used, this property is ignored.
						/// </summary>
						public Union<sap.ui.core.URI, string, sap.ui.@base.ManagedObject.BindPropertyInfo> iconSelected;

						/// <summary>
						/// If set to true (default), the display sequence is 1. icon 2. control text.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> iconFirst;

						/// <summary>
						/// If set to true, the button is displayed without any text.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> iconOnly;

						/// <summary>
						/// The parameters for the FileUploader which are rendered as a hidden inputfield.
						/// </summary>
						public Union<sap.ui.unified.FileUploaderParameter[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> parameters;

						/// <summary>
						/// The header parameters for the FileUploader which are only submitted with XHR requests. Header parameters are not supported by Internet Explorer 9.
						/// </summary>
						public Union<sap.ui.unified.FileUploaderParameter[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> headerParameters;

						/// <summary>
						/// Settings for the <code>XMLHttpRequest</code> object. <b>Note:</b> This aggregation is only used when the <code>sendXHR</code> property is set to <code>true</code>.
						/// </summary>
						public Union<sap.ui.unified.FileUploaderXHRSettings, string, sap.ui.@base.ManagedObject.BindAggregationInfo> xhrSettings;

						/// <summary>
						/// Event is fired when the value of the file path has been changed.
						/// </summary>
						public sap.ui.unified.FileUploader.ChangeDelegate change;

						/// <summary>
						/// Event is fired as soon as the upload request is completed (either successful or unsuccessful). To see if the upload request was successful, check the 'state' parameter for a value 2xx. The uploads actual progress can be retrieved via the 'uploadProgress' Event. However this covers only the client side of the Upload process and does not give any success status from the server.
						/// </summary>
						public sap.ui.unified.FileUploader.UploadCompleteDelegate uploadComplete;

						/// <summary>
						/// Event is fired when the type of a file does not match the mimeType or fileType property.
						/// </summary>
						public sap.ui.unified.FileUploader.TypeMissmatchDelegate typeMissmatch;

						/// <summary>
						/// Event is fired when the size of a file is above the maximumFileSize property. This event is not supported by Internet Explorer 9 (same restriction as for the property maximumFileSize).
						/// </summary>
						public sap.ui.unified.FileUploader.FileSizeExceedDelegate fileSizeExceed;

						/// <summary>
						/// Event is fired when the file is allowed for upload on client side.
						/// </summary>
						public sap.ui.@base.EventDelegate fileAllowed;

						/// <summary>
						/// Event is fired after the upload has started and before the upload is completed and contains progress information related to the running upload. Depending on file size, band width and used browser the event is fired once or multiple times. This is event is only supported with property sendXHR set to true, i.e. the event is not supported in Internet Explorer 9.
						/// </summary>
						public sap.ui.unified.FileUploader.UploadProgressDelegate uploadProgress;

						/// <summary>
						/// Event is fired after the current upload has been aborted. This is event is only supported with property sendXHR set to true, i.e. the event is not supported in Internet Explorer 9.
						/// </summary>
						public sap.ui.unified.FileUploader.UploadDelegate uploadAborted;

						/// <summary>
						/// Event is fired, if the filename of a chosen file is longer than the value specified with the maximumFilenameLength property.
						/// </summary>
						public sap.ui.unified.FileUploader.FilenameLengthExceedDelegate filenameLengthExceed;

						/// <summary>
						/// Event is fired before an upload is started.
						/// </summary>
						public sap.ui.unified.FileUploader.UploadDelegate uploadStart;

					}

					#endregion

					#region Typed Parameters

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class ChangeInfo
					{
						/// <summary>
						/// New file path value.
						/// </summary>
						public string newValue;

						/// <summary>
						/// Files.
						/// </summary>
						public object[] files;

					}

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class FilenameLengthExceedInfo
					{
						/// <summary>
						/// The filename, which is longer than specified by the value of the property maximumFilenameLength.
						/// </summary>
						public string fileName;

					}

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class FileSizeExceedInfo
					{
						/// <summary>
						/// The name of a file to be uploaded.
						/// </summary>
						public string fileName;

						/// <summary>
						/// The size in MB of a file to be uploaded.
						/// </summary>
						public string fileSize;

					}

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class TypeMissmatchInfo
					{
						/// <summary>
						/// The name of a file to be uploaded.
						/// </summary>
						public string fileName;

						/// <summary>
						/// The file ending of a file to be uploaded.
						/// </summary>
						public string fileType;

						/// <summary>
						/// The MIME type of a file to be uploaded.
						/// </summary>
						public string mimeType;

					}

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class UploadInfo
					{
						/// <summary>
						/// The name of a file to be uploaded.
						/// </summary>
						public string fileName;

						/// <summary>
						/// Http-Request-Headers. Required for receiving "header" is to set the property "sendXHR" to true. This property is not supported by Internet Explorer 9.
						/// </summary>
						public object[] requestHeaders;

					}

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class UploadCompleteInfo
					{
						/// <summary>
						/// The name of a file to be uploaded.
						/// </summary>
						public string fileName;

						/// <summary>
						/// Response message which comes from the server. On the server side this response has to be put within the &quot;body&quot; tags of the response document of the iFrame. It can consist of a return code and an optional message. This does not work in cross-domain scenarios.
						/// </summary>
						public string response;

						/// <summary>
						/// ReadyState of the XHR request. Required for receiving a readyState is to set the property "sendXHR" to "true". This property is not supported by Internet Explorer 9.
						/// </summary>
						public string readyStateXHR;

						/// <summary>
						/// Status of the XHR request. Required for receiving a status is to set the property "sendXHR" to "true". This property is not supported by Internet Explorer 9.
						/// </summary>
						public string status;

						/// <summary>
						/// Http-Response which comes from the server. Required for receiving "responseRaw" is to set the property "sendXHR" to true. This property is not supported by Internet Explorer 9.
						/// </summary>
						public string responseRaw;

						/// <summary>
						/// Http-Response-Headers which come from the server. provided as a JSON-map, i.e. each header-field is reflected by a property in the header-object, with the property value reflecting the header-field's content. Required for receiving "header" is to set the property "sendXHR" to true. This property is not supported by Internet Explorer 9.
						/// </summary>
						public object headers;

						/// <summary>
						/// Http-Request-Headers. Required for receiving "header" is to set the property "sendXHR" to true. This property is not supported by Internet Explorer 9.
						/// </summary>
						public object[] requestHeaders;

					}

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class UploadProgressInfo
					{
						/// <summary>
						/// Indicates whether or not the relative upload progress can be calculated out of loaded and total.
						/// </summary>
						public bool lengthComputable;

						/// <summary>
						/// The number of bytes of the file which have been uploaded by to the time the event was fired.
						/// </summary>
						public float loaded;

						/// <summary>
						/// The total size of the file to be uploaded in byte.
						/// </summary>
						public float total;

						/// <summary>
						/// The name of a file to be uploaded.
						/// </summary>
						public string fileName;

						/// <summary>
						/// Http-Request-Headers. Required for receiving "header" is to set the property "sendXHR" to true. This property is not supported by Internet Explorer 9.
						/// </summary>
						public object[] requestHeaders;

					}

					#endregion

					#region Delegates

					public delegate void ChangeDelegate(sap.ui.@base.Event<sap.ui.unified.FileUploader.ChangeInfo> oEvent, object oData);

					public delegate void FilenameLengthExceedDelegate(sap.ui.@base.Event<sap.ui.unified.FileUploader.FilenameLengthExceedInfo> oEvent, object oData);

					public delegate void FileSizeExceedDelegate(sap.ui.@base.Event<sap.ui.unified.FileUploader.FileSizeExceedInfo> oEvent, object oData);

					public delegate void TypeMissmatchDelegate(sap.ui.@base.Event<sap.ui.unified.FileUploader.TypeMissmatchInfo> oEvent, object oData);

					public delegate void UploadDelegate(sap.ui.@base.Event<sap.ui.unified.FileUploader.UploadInfo> oEvent, object oData);

					public delegate void UploadCompleteDelegate(sap.ui.@base.Event<sap.ui.unified.FileUploader.UploadCompleteInfo> oEvent, object oData);

					public delegate void UploadProgressDelegate(sap.ui.@base.Event<sap.ui.unified.FileUploader.UploadProgressInfo> oEvent, object oData);

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new <code>FileUploader</code>.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern FileUploader(string sId, sap.ui.unified.FileUploader.Settings mSettings);

					/// <summary>
					/// Constructor for a new <code>FileUploader</code>.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					public extern FileUploader(string sId);

					/// <summary>
					/// Constructor for a new <code>FileUploader</code>.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern FileUploader();

					/// <summary>
					/// Constructor for a new <code>FileUploader</code>.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern FileUploader(sap.ui.unified.FileUploader.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property value

					/// <summary>
					/// Gets current value of property {@link #getValue value}.
					/// 
					/// Value of the path for file upload.
					/// 
					/// Default value is <code>empty string</code>.
					/// </summary>
					/// <returns>Value of property <code>value</code></returns>
					public extern virtual string getValue();

					/// <summary>
					/// Sets a new value for property {@link #getValue value}.
					/// 
					/// Value of the path for file upload.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>empty string</code>.
					/// </summary>
					/// <param name="sValue">New value for property <code>value</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader setValue(string sValue);

					#endregion

					#region Methods for Property enabled

					/// <summary>
					/// Gets current value of property {@link #getEnabled enabled}.
					/// 
					/// Disabled controls have different colors, depending on customer settings.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>enabled</code></returns>
					public extern virtual bool getEnabled();

					/// <summary>
					/// Sets a new value for property {@link #getEnabled enabled}.
					/// 
					/// Disabled controls have different colors, depending on customer settings.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bEnabled">New value for property <code>enabled</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader setEnabled(bool bEnabled);

					#endregion

					#region Methods for Property uploadUrl

					/// <summary>
					/// Gets current value of property {@link #getUploadUrl uploadUrl}.
					/// 
					/// Used when URL address is on a remote server.
					/// 
					/// Default value is <code>empty string</code>.
					/// </summary>
					/// <returns>Value of property <code>uploadUrl</code></returns>
					public extern virtual sap.ui.core.URI getUploadUrl();

					/// <summary>
					/// Sets a new value for property {@link #getUploadUrl uploadUrl}.
					/// 
					/// Used when URL address is on a remote server.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>empty string</code>.
					/// </summary>
					/// <param name="sUploadUrl">New value for property <code>uploadUrl</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader setUploadUrl(sap.ui.core.URI sUploadUrl);

					#endregion

					#region Methods for Property name

					/// <summary>
					/// Gets current value of property {@link #getName name}.
					/// 
					/// Unique control name for identification on the server side after sending data to the server.
					/// </summary>
					/// <returns>Value of property <code>name</code></returns>
					public extern virtual string getName();

					/// <summary>
					/// Sets a new value for property {@link #getName name}.
					/// 
					/// Unique control name for identification on the server side after sending data to the server.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sName">New value for property <code>name</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader setName(string sName);

					#endregion

					#region Methods for Property width

					/// <summary>
					/// Gets current value of property {@link #getWidth width}.
					/// 
					/// Specifies the displayed control width.
					/// 
					/// Default value is <code>empty string</code>.
					/// </summary>
					/// <returns>Value of property <code>width</code></returns>
					public extern virtual sap.ui.core.CSSSize getWidth();

					/// <summary>
					/// Sets a new value for property {@link #getWidth width}.
					/// 
					/// Specifies the displayed control width.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>empty string</code>.
					/// </summary>
					/// <param name="sWidth">New value for property <code>width</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader setWidth(sap.ui.core.CSSSize sWidth);

					#endregion

					#region Methods for Property uploadOnChange

					/// <summary>
					/// Gets current value of property {@link #getUploadOnChange uploadOnChange}.
					/// 
					/// If set to "true", the upload immediately starts after file selection. With the default setting, the upload needs to be explicitly triggered.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>uploadOnChange</code></returns>
					public extern virtual bool getUploadOnChange();

					/// <summary>
					/// Sets a new value for property {@link #getUploadOnChange uploadOnChange}.
					/// 
					/// If set to "true", the upload immediately starts after file selection. With the default setting, the upload needs to be explicitly triggered.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bUploadOnChange">New value for property <code>uploadOnChange</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader setUploadOnChange(bool bUploadOnChange);

					#endregion

					#region Methods for Property additionalData

					/// <summary>
					/// Gets current value of property {@link #getAdditionalData additionalData}.
					/// 
					/// Additional data that is sent to the back end service. Data will be transmitted as value of a hidden input where the name is derived from the name property with suffix -data.
					/// </summary>
					/// <returns>Value of property <code>additionalData</code></returns>
					public extern virtual string getAdditionalData();

					/// <summary>
					/// Sets a new value for property {@link #getAdditionalData additionalData}.
					/// 
					/// Additional data that is sent to the back end service. Data will be transmitted as value of a hidden input where the name is derived from the name property with suffix -data.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sAdditionalData">New value for property <code>additionalData</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader setAdditionalData(string sAdditionalData);

					#endregion

					#region Methods for Property sameFilenameAllowed

					/// <summary>
					/// Gets current value of property {@link #getSameFilenameAllowed sameFilenameAllowed}.
					/// 
					/// If the FileUploader is configured to upload the file directly after the file is selected it is not allowed to upload a file with the same name again. If a user should be allowed to upload a file with the same name again this parameter has to be "true". A typical use case would be if the files have different paths.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>sameFilenameAllowed</code></returns>
					public extern virtual bool getSameFilenameAllowed();

					/// <summary>
					/// Sets a new value for property {@link #getSameFilenameAllowed sameFilenameAllowed}.
					/// 
					/// If the FileUploader is configured to upload the file directly after the file is selected it is not allowed to upload a file with the same name again. If a user should be allowed to upload a file with the same name again this parameter has to be "true". A typical use case would be if the files have different paths.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bSameFilenameAllowed">New value for property <code>sameFilenameAllowed</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader setSameFilenameAllowed(bool bSameFilenameAllowed);

					#endregion

					#region Methods for Property buttonText

					/// <summary>
					/// Gets current value of property {@link #getButtonText buttonText}.
					/// 
					/// The Button text can be overwritten using this property.
					/// </summary>
					/// <returns>Value of property <code>buttonText</code></returns>
					public extern virtual string getButtonText();

					/// <summary>
					/// Sets a new value for property {@link #getButtonText buttonText}.
					/// 
					/// The Button text can be overwritten using this property.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sButtonText">New value for property <code>buttonText</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader setButtonText(string sButtonText);

					#endregion

					#region Methods for Property fileType

					/// <summary>
					/// Gets current value of property {@link #getFileType fileType}.
					/// 
					/// The chosen files will be checked against an array of file types. If at least one file does not fit the file type restriction the upload is prevented. Example: ["jpg", "png", "bmp"].
					/// </summary>
					/// <returns>Value of property <code>fileType</code></returns>
					public extern virtual string[] getFileType();

					/// <summary>
					/// Sets a new value for property {@link #getFileType fileType}.
					/// 
					/// The chosen files will be checked against an array of file types. If at least one file does not fit the file type restriction the upload is prevented. Example: ["jpg", "png", "bmp"].
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sFileType">New value for property <code>fileType</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader setFileType(string[] sFileType);

					/// <summary>
					/// Sets a new value for property {@link #getFileType fileType}.
					/// 
					/// The chosen files will be checked against an array of file types. If at least one file does not fit the file type restriction the upload is prevented. Example: ["jpg", "png", "bmp"].
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sFileType">New value for property <code>fileType</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader setFileType(object[] sFileType);

					#endregion

					#region Methods for Property multiple

					/// <summary>
					/// Gets current value of property {@link #getMultiple multiple}.
					/// 
					/// Allows multiple files to be chosen and uploaded from the same folder. This property is not supported by Internet Explorer 9.
					/// 
					/// <b>Note:</b> Keep in mind that the various operating systems for mobile devices can react differently to the property so that fewer upload functions may be available in some cases.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>multiple</code></returns>
					public extern virtual bool getMultiple();

					/// <summary>
					/// Sets a new value for property {@link #getMultiple multiple}.
					/// 
					/// Allows multiple files to be chosen and uploaded from the same folder. This property is not supported by Internet Explorer 9.
					/// 
					/// <b>Note:</b> Keep in mind that the various operating systems for mobile devices can react differently to the property so that fewer upload functions may be available in some cases.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bMultiple">New value for property <code>multiple</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader setMultiple(bool bMultiple);

					#endregion

					#region Methods for Property maximumFileSize

					/// <summary>
					/// Gets current value of property {@link #getMaximumFileSize maximumFileSize}.
					/// 
					/// A file size limit in megabytes which prevents the upload if at least one file exceeds it. This property is not supported by Internet Explorer 9.
					/// </summary>
					/// <returns>Value of property <code>maximumFileSize</code></returns>
					public extern virtual float getMaximumFileSize();

					/// <summary>
					/// Sets a new value for property {@link #getMaximumFileSize maximumFileSize}.
					/// 
					/// A file size limit in megabytes which prevents the upload if at least one file exceeds it. This property is not supported by Internet Explorer 9.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="fMaximumFileSize">New value for property <code>maximumFileSize</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader setMaximumFileSize(float fMaximumFileSize);

					#endregion

					#region Methods for Property mimeType

					/// <summary>
					/// Gets current value of property {@link #getMimeType mimeType}.
					/// 
					/// The chosen files will be checked against an array of mime types. If at least one file does not fit the mime type restriction the upload is prevented. This property is not supported by Internet Explorer 9. Example: mimeType ["image/png", "image/jpeg"].
					/// </summary>
					/// <returns>Value of property <code>mimeType</code></returns>
					public extern virtual string[] getMimeType();

					/// <summary>
					/// Sets a new value for property {@link #getMimeType mimeType}.
					/// 
					/// The chosen files will be checked against an array of mime types. If at least one file does not fit the mime type restriction the upload is prevented. This property is not supported by Internet Explorer 9. Example: mimeType ["image/png", "image/jpeg"].
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sMimeType">New value for property <code>mimeType</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader setMimeType(string[] sMimeType);

					/// <summary>
					/// Sets a new value for property {@link #getMimeType mimeType}.
					/// 
					/// The chosen files will be checked against an array of mime types. If at least one file does not fit the mime type restriction the upload is prevented. This property is not supported by Internet Explorer 9. Example: mimeType ["image/png", "image/jpeg"].
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sMimeType">New value for property <code>mimeType</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader setMimeType(object[] sMimeType);

					#endregion

					#region Methods for Property sendXHR

					/// <summary>
					/// Gets current value of property {@link #getSendXHR sendXHR}.
					/// 
					/// If set to "true", the request will be sent as XHR request instead of a form submit. This property is not supported by Internet Explorer 9.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>sendXHR</code></returns>
					public extern virtual bool getSendXHR();

					/// <summary>
					/// Sets a new value for property {@link #getSendXHR sendXHR}.
					/// 
					/// If set to "true", the request will be sent as XHR request instead of a form submit. This property is not supported by Internet Explorer 9.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bSendXHR">New value for property <code>sendXHR</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader setSendXHR(bool bSendXHR);

					#endregion

					#region Methods for Property placeholder

					/// <summary>
					/// Gets current value of property {@link #getPlaceholder placeholder}.
					/// 
					/// Placeholder for the text field.
					/// </summary>
					/// <returns>Value of property <code>placeholder</code></returns>
					public extern virtual string getPlaceholder();

					/// <summary>
					/// Sets a new value for property {@link #getPlaceholder placeholder}.
					/// 
					/// Placeholder for the text field.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sPlaceholder">New value for property <code>placeholder</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader setPlaceholder(string sPlaceholder);

					#endregion

					#region Methods for Property style

					/// <summary>
					/// Gets current value of property {@link #getStyle style}.
					/// 
					/// Style of the button. "Transparent, "Accept", "Reject", or "Emphasized" is allowed.
					/// </summary>
					/// <returns>Value of property <code>style</code></returns>
					public extern virtual string getStyle();

					/// <summary>
					/// Sets a new value for property {@link #getStyle style}.
					/// 
					/// Style of the button. "Transparent, "Accept", "Reject", or "Emphasized" is allowed.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sStyle">New value for property <code>style</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader setStyle(string sStyle);

					#endregion

					#region Methods for Property buttonOnly

					/// <summary>
					/// Gets current value of property {@link #getButtonOnly buttonOnly}.
					/// 
					/// If set to "true", the FileUploader will be rendered as Button only, without showing the InputField.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>buttonOnly</code></returns>
					public extern virtual bool getButtonOnly();

					/// <summary>
					/// Sets a new value for property {@link #getButtonOnly buttonOnly}.
					/// 
					/// If set to "true", the FileUploader will be rendered as Button only, without showing the InputField.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bButtonOnly">New value for property <code>buttonOnly</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader setButtonOnly(bool bButtonOnly);

					#endregion

					#region Methods for Property useMultipart

					/// <summary>
					/// Gets current value of property {@link #getUseMultipart useMultipart}.
					/// 
					/// If set to "false", the request will be sent as file only request instead of a multipart/form-data request. Only one file could be uploaded using this type of request. Required for sending such a request is to set the property "sendXHR" to "true". This property is not supported by Internet Explorer 9.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>useMultipart</code></returns>
					public extern virtual bool getUseMultipart();

					/// <summary>
					/// Sets a new value for property {@link #getUseMultipart useMultipart}.
					/// 
					/// If set to "false", the request will be sent as file only request instead of a multipart/form-data request. Only one file could be uploaded using this type of request. Required for sending such a request is to set the property "sendXHR" to "true". This property is not supported by Internet Explorer 9.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bUseMultipart">New value for property <code>useMultipart</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader setUseMultipart(bool bUseMultipart);

					#endregion

					#region Methods for Property maximumFilenameLength

					/// <summary>
					/// Gets current value of property {@link #getMaximumFilenameLength maximumFilenameLength}.
					/// 
					/// The maximum length of a filename which the FileUploader will accept. If the maximum filename length is exceeded, the corresponding Event 'filenameLengthExceed' is fired.
					/// </summary>
					/// <returns>Value of property <code>maximumFilenameLength</code></returns>
					public extern virtual int getMaximumFilenameLength();

					/// <summary>
					/// Sets a new value for property {@link #getMaximumFilenameLength maximumFilenameLength}.
					/// 
					/// The maximum length of a filename which the FileUploader will accept. If the maximum filename length is exceeded, the corresponding Event 'filenameLengthExceed' is fired.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="iMaximumFilenameLength">New value for property <code>maximumFilenameLength</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader setMaximumFilenameLength(int iMaximumFilenameLength);

					#endregion

					#region Methods for Property valueState

					/// <summary>
					/// Gets current value of property {@link #getValueState valueState}.
					/// 
					/// Visualizes warnings or errors related to the text field. Possible values: Warning, Error, Success, None.
					/// 
					/// Default value is <code>None</code>.
					/// </summary>
					/// <returns>Value of property <code>valueState</code></returns>
					public extern virtual sap.ui.core.ValueState getValueState();

					/// <summary>
					/// Sets a new value for property {@link #getValueState valueState}.
					/// 
					/// Visualizes warnings or errors related to the text field. Possible values: Warning, Error, Success, None.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>None</code>.
					/// </summary>
					/// <param name="sValueState">New value for property <code>valueState</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader setValueState(sap.ui.core.ValueState sValueState);

					#endregion

					#region Methods for Property valueStateText

					/// <summary>
					/// Gets current value of property {@link #getValueStateText valueStateText}.
					/// 
					/// Custom text for the value state message pop-up.
					/// 
					/// <b>Note:</b> If not specified, a default text, based on the value state type, will be used instead.
					/// </summary>
					/// <returns>Value of property <code>valueStateText</code></returns>
					public extern virtual string getValueStateText();

					/// <summary>
					/// Sets a new value for property {@link #getValueStateText valueStateText}.
					/// 
					/// Custom text for the value state message pop-up.
					/// 
					/// <b>Note:</b> If not specified, a default text, based on the value state type, will be used instead.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sValueStateText">New value for property <code>valueStateText</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader setValueStateText(string sValueStateText);

					#endregion

					#region Methods for Property icon

					/// <summary>
					/// Gets current value of property {@link #getIcon icon}.
					/// 
					/// Icon to be displayed as graphical element within the button. This can be a URI to an image or an icon font URI.
					/// 
					/// Default value is <code>empty string</code>.
					/// </summary>
					/// <returns>Value of property <code>icon</code></returns>
					public extern virtual sap.ui.core.URI getIcon();

					/// <summary>
					/// Sets a new value for property {@link #getIcon icon}.
					/// 
					/// Icon to be displayed as graphical element within the button. This can be a URI to an image or an icon font URI.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>empty string</code>.
					/// </summary>
					/// <param name="sIcon">New value for property <code>icon</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader setIcon(sap.ui.core.URI sIcon);

					#endregion

					#region Methods for Property iconHovered

					/// <summary>
					/// Gets current value of property {@link #getIconHovered iconHovered}.
					/// 
					/// Icon to be displayed as graphical element within the button when it is hovered (only if also a base icon was specified). If not specified the base icon is used. If an icon font icon is used, this property is ignored.
					/// 
					/// Default value is <code>empty string</code>.
					/// </summary>
					/// <returns>Value of property <code>iconHovered</code></returns>
					public extern virtual sap.ui.core.URI getIconHovered();

					/// <summary>
					/// Sets a new value for property {@link #getIconHovered iconHovered}.
					/// 
					/// Icon to be displayed as graphical element within the button when it is hovered (only if also a base icon was specified). If not specified the base icon is used. If an icon font icon is used, this property is ignored.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>empty string</code>.
					/// </summary>
					/// <param name="sIconHovered">New value for property <code>iconHovered</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader setIconHovered(sap.ui.core.URI sIconHovered);

					#endregion

					#region Methods for Property iconSelected

					/// <summary>
					/// Gets current value of property {@link #getIconSelected iconSelected}.
					/// 
					/// Icon to be displayed as graphical element within the button when it is selected (only if also a base icon was specified). If not specified the base or hovered icon is used. If an icon font icon is used, this property is ignored.
					/// 
					/// Default value is <code>empty string</code>.
					/// </summary>
					/// <returns>Value of property <code>iconSelected</code></returns>
					public extern virtual sap.ui.core.URI getIconSelected();

					/// <summary>
					/// Sets a new value for property {@link #getIconSelected iconSelected}.
					/// 
					/// Icon to be displayed as graphical element within the button when it is selected (only if also a base icon was specified). If not specified the base or hovered icon is used. If an icon font icon is used, this property is ignored.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>empty string</code>.
					/// </summary>
					/// <param name="sIconSelected">New value for property <code>iconSelected</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader setIconSelected(sap.ui.core.URI sIconSelected);

					#endregion

					#region Methods for Property iconFirst

					/// <summary>
					/// Gets current value of property {@link #getIconFirst iconFirst}.
					/// 
					/// If set to true (default), the display sequence is 1. icon 2. control text.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>iconFirst</code></returns>
					public extern virtual bool getIconFirst();

					/// <summary>
					/// Sets a new value for property {@link #getIconFirst iconFirst}.
					/// 
					/// If set to true (default), the display sequence is 1. icon 2. control text.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bIconFirst">New value for property <code>iconFirst</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader setIconFirst(bool bIconFirst);

					#endregion

					#region Methods for Property iconOnly

					/// <summary>
					/// Gets current value of property {@link #getIconOnly iconOnly}.
					/// 
					/// If set to true, the button is displayed without any text.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>iconOnly</code></returns>
					public extern virtual bool getIconOnly();

					/// <summary>
					/// Sets a new value for property {@link #getIconOnly iconOnly}.
					/// 
					/// If set to true, the button is displayed without any text.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bIconOnly">New value for property <code>iconOnly</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader setIconOnly(bool bIconOnly);

					#endregion

					#region Methods for Aggregation parameters

					/// <summary>
					/// Gets content of aggregation {@link #getParameters parameters}.
					/// 
					/// The parameters for the FileUploader which are rendered as a hidden inputfield.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.unified.FileUploaderParameter[] getParameters();

					/// <summary>
					/// Destroys all the parameters in the aggregation {@link #getParameters parameters}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader destroyParameters();

					/// <summary>
					/// Inserts a parameter into the aggregation {@link #getParameters parameters}.
					/// </summary>
					/// <param name="oParameter">The parameter to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the parameter should be inserted at; for a negative value of <code>iIndex</code>, the parameter is inserted at position 0; for a value greater than the current size of the aggregation, the parameter is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader insertParameter(sap.ui.unified.FileUploaderParameter oParameter, int iIndex);

					/// <summary>
					/// Adds some parameter to the aggregation {@link #getParameters parameters}.
					/// </summary>
					/// <param name="oParameter">The parameter to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader addParameter(sap.ui.unified.FileUploaderParameter oParameter);

					/// <summary>
					/// Removes a parameter from the aggregation {@link #getParameters parameters}.
					/// </summary>
					/// <param name="vParameter">The parameter to remove or its index or id</param>
					/// <returns>The removed parameter or <code>null</code></returns>
					public extern virtual sap.ui.unified.FileUploaderParameter removeParameter(Union<int, string, sap.ui.unified.FileUploaderParameter> vParameter);

					/// <summary>
					/// Checks for the provided <code>sap.ui.unified.FileUploaderParameter</code> in the aggregation {@link #getParameters parameters}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oParameter">The parameter whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfParameter(sap.ui.unified.FileUploaderParameter oParameter);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getParameters parameters}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.unified.FileUploaderParameter[] removeAllParameters();

					#endregion

					#region Methods for Aggregation headerParameters

					/// <summary>
					/// Gets content of aggregation {@link #getHeaderParameters headerParameters}.
					/// 
					/// The header parameters for the FileUploader which are only submitted with XHR requests. Header parameters are not supported by Internet Explorer 9.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.unified.FileUploaderParameter[] getHeaderParameters();

					/// <summary>
					/// Destroys all the headerParameters in the aggregation {@link #getHeaderParameters headerParameters}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader destroyHeaderParameters();

					/// <summary>
					/// Inserts a headerParameter into the aggregation {@link #getHeaderParameters headerParameters}.
					/// </summary>
					/// <param name="oHeaderParameter">The headerParameter to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the headerParameter should be inserted at; for a negative value of <code>iIndex</code>, the headerParameter is inserted at position 0; for a value greater than the current size of the aggregation, the headerParameter is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader insertHeaderParameter(sap.ui.unified.FileUploaderParameter oHeaderParameter, int iIndex);

					/// <summary>
					/// Adds some headerParameter to the aggregation {@link #getHeaderParameters headerParameters}.
					/// </summary>
					/// <param name="oHeaderParameter">The headerParameter to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader addHeaderParameter(sap.ui.unified.FileUploaderParameter oHeaderParameter);

					/// <summary>
					/// Removes a headerParameter from the aggregation {@link #getHeaderParameters headerParameters}.
					/// </summary>
					/// <param name="vHeaderParameter">The headerParameter to remove or its index or id</param>
					/// <returns>The removed headerParameter or <code>null</code></returns>
					public extern virtual sap.ui.unified.FileUploaderParameter removeHeaderParameter(Union<int, string, sap.ui.unified.FileUploaderParameter> vHeaderParameter);

					/// <summary>
					/// Checks for the provided <code>sap.ui.unified.FileUploaderParameter</code> in the aggregation {@link #getHeaderParameters headerParameters}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oHeaderParameter">The headerParameter whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfHeaderParameter(sap.ui.unified.FileUploaderParameter oHeaderParameter);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getHeaderParameters headerParameters}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.unified.FileUploaderParameter[] removeAllHeaderParameters();

					#endregion

					#region Methods for Aggregation xhrSettings

					/// <summary>
					/// Gets content of aggregation {@link #getXhrSettings xhrSettings}.
					/// 
					/// Settings for the <code>XMLHttpRequest</code> object. <b>Note:</b> This aggregation is only used when the <code>sendXHR</code> property is set to <code>true</code>.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.unified.FileUploaderXHRSettings getXhrSettings();

					/// <summary>
					/// Destroys the xhrSettings in the aggregation {@link #getXhrSettings xhrSettings}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader destroyXhrSettings();

					/// <summary>
					/// Sets the aggregated {@link #getXhrSettings xhrSettings}.
					/// </summary>
					/// <param name="oXhrSettings">The xhrSettings to set</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader setXhrSettings(sap.ui.unified.FileUploaderXHRSettings oXhrSettings);

					#endregion

					#region Methods for Event change

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:change change} event of this <code>sap.ui.unified.FileUploader</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.FileUploader</code> itself.
					/// 
					/// Event is fired when the value of the file path has been changed.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.FileUploader</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader attachChange(object oData, sap.ui.unified.FileUploader.ChangeDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:change change} event of this <code>sap.ui.unified.FileUploader</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.FileUploader</code> itself.
					/// 
					/// Event is fired when the value of the file path has been changed.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader attachChange(object oData, sap.ui.unified.FileUploader.ChangeDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:change change} event of this <code>sap.ui.unified.FileUploader</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.FileUploader</code> itself.
					/// 
					/// Event is fired when the value of the file path has been changed.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader attachChange(sap.ui.unified.FileUploader.ChangeDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:change change} event of this <code>sap.ui.unified.FileUploader</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.FileUploader</code> itself.
					/// 
					/// Event is fired when the value of the file path has been changed.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.FileUploader</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader attachChange(sap.ui.unified.FileUploader.ChangeDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:change change} event of this <code>sap.ui.unified.FileUploader</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader detachChange(sap.ui.unified.FileUploader.ChangeDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:change change} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader fireChange(sap.ui.unified.FileUploader.ChangeInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:change change} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader fireChange();

					#endregion

					#region Methods for Event uploadComplete

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:uploadComplete uploadComplete} event of this <code>sap.ui.unified.FileUploader</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.FileUploader</code> itself.
					/// 
					/// Event is fired as soon as the upload request is completed (either successful or unsuccessful). To see if the upload request was successful, check the 'state' parameter for a value 2xx. The uploads actual progress can be retrieved via the 'uploadProgress' Event. However this covers only the client side of the Upload process and does not give any success status from the server.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.FileUploader</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader attachUploadComplete(object oData, sap.ui.unified.FileUploader.UploadCompleteDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:uploadComplete uploadComplete} event of this <code>sap.ui.unified.FileUploader</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.FileUploader</code> itself.
					/// 
					/// Event is fired as soon as the upload request is completed (either successful or unsuccessful). To see if the upload request was successful, check the 'state' parameter for a value 2xx. The uploads actual progress can be retrieved via the 'uploadProgress' Event. However this covers only the client side of the Upload process and does not give any success status from the server.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader attachUploadComplete(object oData, sap.ui.unified.FileUploader.UploadCompleteDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:uploadComplete uploadComplete} event of this <code>sap.ui.unified.FileUploader</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.FileUploader</code> itself.
					/// 
					/// Event is fired as soon as the upload request is completed (either successful or unsuccessful). To see if the upload request was successful, check the 'state' parameter for a value 2xx. The uploads actual progress can be retrieved via the 'uploadProgress' Event. However this covers only the client side of the Upload process and does not give any success status from the server.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader attachUploadComplete(sap.ui.unified.FileUploader.UploadCompleteDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:uploadComplete uploadComplete} event of this <code>sap.ui.unified.FileUploader</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.FileUploader</code> itself.
					/// 
					/// Event is fired as soon as the upload request is completed (either successful or unsuccessful). To see if the upload request was successful, check the 'state' parameter for a value 2xx. The uploads actual progress can be retrieved via the 'uploadProgress' Event. However this covers only the client side of the Upload process and does not give any success status from the server.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.FileUploader</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader attachUploadComplete(sap.ui.unified.FileUploader.UploadCompleteDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:uploadComplete uploadComplete} event of this <code>sap.ui.unified.FileUploader</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader detachUploadComplete(sap.ui.unified.FileUploader.UploadCompleteDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:uploadComplete uploadComplete} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader fireUploadComplete(sap.ui.unified.FileUploader.UploadCompleteInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:uploadComplete uploadComplete} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader fireUploadComplete();

					#endregion

					#region Methods for Event typeMissmatch

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:typeMissmatch typeMissmatch} event of this <code>sap.ui.unified.FileUploader</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.FileUploader</code> itself.
					/// 
					/// Event is fired when the type of a file does not match the mimeType or fileType property.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.FileUploader</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader attachTypeMissmatch(object oData, sap.ui.unified.FileUploader.TypeMissmatchDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:typeMissmatch typeMissmatch} event of this <code>sap.ui.unified.FileUploader</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.FileUploader</code> itself.
					/// 
					/// Event is fired when the type of a file does not match the mimeType or fileType property.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader attachTypeMissmatch(object oData, sap.ui.unified.FileUploader.TypeMissmatchDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:typeMissmatch typeMissmatch} event of this <code>sap.ui.unified.FileUploader</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.FileUploader</code> itself.
					/// 
					/// Event is fired when the type of a file does not match the mimeType or fileType property.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader attachTypeMissmatch(sap.ui.unified.FileUploader.TypeMissmatchDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:typeMissmatch typeMissmatch} event of this <code>sap.ui.unified.FileUploader</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.FileUploader</code> itself.
					/// 
					/// Event is fired when the type of a file does not match the mimeType or fileType property.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.FileUploader</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader attachTypeMissmatch(sap.ui.unified.FileUploader.TypeMissmatchDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:typeMissmatch typeMissmatch} event of this <code>sap.ui.unified.FileUploader</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader detachTypeMissmatch(sap.ui.unified.FileUploader.TypeMissmatchDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:typeMissmatch typeMissmatch} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader fireTypeMissmatch(sap.ui.unified.FileUploader.TypeMissmatchInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:typeMissmatch typeMissmatch} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader fireTypeMissmatch();

					#endregion

					#region Methods for Event fileSizeExceed

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:fileSizeExceed fileSizeExceed} event of this <code>sap.ui.unified.FileUploader</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.FileUploader</code> itself.
					/// 
					/// Event is fired when the size of a file is above the maximumFileSize property. This event is not supported by Internet Explorer 9 (same restriction as for the property maximumFileSize).
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.FileUploader</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader attachFileSizeExceed(object oData, sap.ui.unified.FileUploader.FileSizeExceedDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:fileSizeExceed fileSizeExceed} event of this <code>sap.ui.unified.FileUploader</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.FileUploader</code> itself.
					/// 
					/// Event is fired when the size of a file is above the maximumFileSize property. This event is not supported by Internet Explorer 9 (same restriction as for the property maximumFileSize).
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader attachFileSizeExceed(object oData, sap.ui.unified.FileUploader.FileSizeExceedDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:fileSizeExceed fileSizeExceed} event of this <code>sap.ui.unified.FileUploader</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.FileUploader</code> itself.
					/// 
					/// Event is fired when the size of a file is above the maximumFileSize property. This event is not supported by Internet Explorer 9 (same restriction as for the property maximumFileSize).
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader attachFileSizeExceed(sap.ui.unified.FileUploader.FileSizeExceedDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:fileSizeExceed fileSizeExceed} event of this <code>sap.ui.unified.FileUploader</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.FileUploader</code> itself.
					/// 
					/// Event is fired when the size of a file is above the maximumFileSize property. This event is not supported by Internet Explorer 9 (same restriction as for the property maximumFileSize).
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.FileUploader</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader attachFileSizeExceed(sap.ui.unified.FileUploader.FileSizeExceedDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:fileSizeExceed fileSizeExceed} event of this <code>sap.ui.unified.FileUploader</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader detachFileSizeExceed(sap.ui.unified.FileUploader.FileSizeExceedDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:fileSizeExceed fileSizeExceed} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader fireFileSizeExceed(sap.ui.unified.FileUploader.FileSizeExceedInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:fileSizeExceed fileSizeExceed} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader fireFileSizeExceed();

					#endregion

					#region Methods for Event fileAllowed

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:fileAllowed fileAllowed} event of this <code>sap.ui.unified.FileUploader</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.FileUploader</code> itself.
					/// 
					/// Event is fired when the file is allowed for upload on client side.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.FileUploader</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader attachFileAllowed(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:fileAllowed fileAllowed} event of this <code>sap.ui.unified.FileUploader</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.FileUploader</code> itself.
					/// 
					/// Event is fired when the file is allowed for upload on client side.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader attachFileAllowed(object oData, sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:fileAllowed fileAllowed} event of this <code>sap.ui.unified.FileUploader</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.FileUploader</code> itself.
					/// 
					/// Event is fired when the file is allowed for upload on client side.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader attachFileAllowed(sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:fileAllowed fileAllowed} event of this <code>sap.ui.unified.FileUploader</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.FileUploader</code> itself.
					/// 
					/// Event is fired when the file is allowed for upload on client side.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.FileUploader</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader attachFileAllowed(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:fileAllowed fileAllowed} event of this <code>sap.ui.unified.FileUploader</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader detachFileAllowed(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:fileAllowed fileAllowed} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader fireFileAllowed(object mParameters);

					/// <summary>
					/// Fires event {@link #event:fileAllowed fileAllowed} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader fireFileAllowed();

					#endregion

					#region Methods for Event uploadProgress

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:uploadProgress uploadProgress} event of this <code>sap.ui.unified.FileUploader</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.FileUploader</code> itself.
					/// 
					/// Event is fired after the upload has started and before the upload is completed and contains progress information related to the running upload. Depending on file size, band width and used browser the event is fired once or multiple times. This is event is only supported with property sendXHR set to true, i.e. the event is not supported in Internet Explorer 9.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.FileUploader</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader attachUploadProgress(object oData, sap.ui.unified.FileUploader.UploadProgressDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:uploadProgress uploadProgress} event of this <code>sap.ui.unified.FileUploader</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.FileUploader</code> itself.
					/// 
					/// Event is fired after the upload has started and before the upload is completed and contains progress information related to the running upload. Depending on file size, band width and used browser the event is fired once or multiple times. This is event is only supported with property sendXHR set to true, i.e. the event is not supported in Internet Explorer 9.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader attachUploadProgress(object oData, sap.ui.unified.FileUploader.UploadProgressDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:uploadProgress uploadProgress} event of this <code>sap.ui.unified.FileUploader</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.FileUploader</code> itself.
					/// 
					/// Event is fired after the upload has started and before the upload is completed and contains progress information related to the running upload. Depending on file size, band width and used browser the event is fired once or multiple times. This is event is only supported with property sendXHR set to true, i.e. the event is not supported in Internet Explorer 9.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader attachUploadProgress(sap.ui.unified.FileUploader.UploadProgressDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:uploadProgress uploadProgress} event of this <code>sap.ui.unified.FileUploader</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.FileUploader</code> itself.
					/// 
					/// Event is fired after the upload has started and before the upload is completed and contains progress information related to the running upload. Depending on file size, band width and used browser the event is fired once or multiple times. This is event is only supported with property sendXHR set to true, i.e. the event is not supported in Internet Explorer 9.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.FileUploader</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader attachUploadProgress(sap.ui.unified.FileUploader.UploadProgressDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:uploadProgress uploadProgress} event of this <code>sap.ui.unified.FileUploader</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader detachUploadProgress(sap.ui.unified.FileUploader.UploadProgressDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:uploadProgress uploadProgress} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader fireUploadProgress(sap.ui.unified.FileUploader.UploadProgressInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:uploadProgress uploadProgress} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader fireUploadProgress();

					#endregion

					#region Methods for Event uploadAborted

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:uploadAborted uploadAborted} event of this <code>sap.ui.unified.FileUploader</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.FileUploader</code> itself.
					/// 
					/// Event is fired after the current upload has been aborted. This is event is only supported with property sendXHR set to true, i.e. the event is not supported in Internet Explorer 9.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.FileUploader</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader attachUploadAborted(object oData, sap.ui.unified.FileUploader.UploadDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:uploadAborted uploadAborted} event of this <code>sap.ui.unified.FileUploader</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.FileUploader</code> itself.
					/// 
					/// Event is fired after the current upload has been aborted. This is event is only supported with property sendXHR set to true, i.e. the event is not supported in Internet Explorer 9.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader attachUploadAborted(object oData, sap.ui.unified.FileUploader.UploadDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:uploadAborted uploadAborted} event of this <code>sap.ui.unified.FileUploader</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.FileUploader</code> itself.
					/// 
					/// Event is fired after the current upload has been aborted. This is event is only supported with property sendXHR set to true, i.e. the event is not supported in Internet Explorer 9.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader attachUploadAborted(sap.ui.unified.FileUploader.UploadDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:uploadAborted uploadAborted} event of this <code>sap.ui.unified.FileUploader</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.FileUploader</code> itself.
					/// 
					/// Event is fired after the current upload has been aborted. This is event is only supported with property sendXHR set to true, i.e. the event is not supported in Internet Explorer 9.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.FileUploader</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader attachUploadAborted(sap.ui.unified.FileUploader.UploadDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:uploadAborted uploadAborted} event of this <code>sap.ui.unified.FileUploader</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader detachUploadAborted(sap.ui.unified.FileUploader.UploadDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:uploadAborted uploadAborted} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader fireUploadAborted(sap.ui.unified.FileUploader.UploadInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:uploadAborted uploadAborted} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader fireUploadAborted();

					#endregion

					#region Methods for Event filenameLengthExceed

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:filenameLengthExceed filenameLengthExceed} event of this <code>sap.ui.unified.FileUploader</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.FileUploader</code> itself.
					/// 
					/// Event is fired, if the filename of a chosen file is longer than the value specified with the maximumFilenameLength property.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.FileUploader</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader attachFilenameLengthExceed(object oData, sap.ui.unified.FileUploader.FilenameLengthExceedDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:filenameLengthExceed filenameLengthExceed} event of this <code>sap.ui.unified.FileUploader</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.FileUploader</code> itself.
					/// 
					/// Event is fired, if the filename of a chosen file is longer than the value specified with the maximumFilenameLength property.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader attachFilenameLengthExceed(object oData, sap.ui.unified.FileUploader.FilenameLengthExceedDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:filenameLengthExceed filenameLengthExceed} event of this <code>sap.ui.unified.FileUploader</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.FileUploader</code> itself.
					/// 
					/// Event is fired, if the filename of a chosen file is longer than the value specified with the maximumFilenameLength property.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader attachFilenameLengthExceed(sap.ui.unified.FileUploader.FilenameLengthExceedDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:filenameLengthExceed filenameLengthExceed} event of this <code>sap.ui.unified.FileUploader</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.FileUploader</code> itself.
					/// 
					/// Event is fired, if the filename of a chosen file is longer than the value specified with the maximumFilenameLength property.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.FileUploader</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader attachFilenameLengthExceed(sap.ui.unified.FileUploader.FilenameLengthExceedDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:filenameLengthExceed filenameLengthExceed} event of this <code>sap.ui.unified.FileUploader</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader detachFilenameLengthExceed(sap.ui.unified.FileUploader.FilenameLengthExceedDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:filenameLengthExceed filenameLengthExceed} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader fireFilenameLengthExceed(sap.ui.unified.FileUploader.FilenameLengthExceedInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:filenameLengthExceed filenameLengthExceed} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader fireFilenameLengthExceed();

					#endregion

					#region Methods for Event uploadStart

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:uploadStart uploadStart} event of this <code>sap.ui.unified.FileUploader</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.FileUploader</code> itself.
					/// 
					/// Event is fired before an upload is started.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.FileUploader</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader attachUploadStart(object oData, sap.ui.unified.FileUploader.UploadDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:uploadStart uploadStart} event of this <code>sap.ui.unified.FileUploader</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.FileUploader</code> itself.
					/// 
					/// Event is fired before an upload is started.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader attachUploadStart(object oData, sap.ui.unified.FileUploader.UploadDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:uploadStart uploadStart} event of this <code>sap.ui.unified.FileUploader</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.FileUploader</code> itself.
					/// 
					/// Event is fired before an upload is started.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader attachUploadStart(sap.ui.unified.FileUploader.UploadDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:uploadStart uploadStart} event of this <code>sap.ui.unified.FileUploader</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.unified.FileUploader</code> itself.
					/// 
					/// Event is fired before an upload is started.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.unified.FileUploader</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader attachUploadStart(sap.ui.unified.FileUploader.UploadDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:uploadStart uploadStart} event of this <code>sap.ui.unified.FileUploader</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader detachUploadStart(sap.ui.unified.FileUploader.UploadDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:uploadStart uploadStart} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader fireUploadStart(sap.ui.unified.FileUploader.UploadInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:uploadStart uploadStart} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploader fireUploadStart();

					#endregion

					#region Other methods

					/// <summary>
					/// Aborts the currently running upload.
					/// </summary>
					/// <param name="sHeaderParameterName">The name of the parameter within the <code>headerParameters</code> aggregation to be checked.
					/// 
					/// <b>Note:</b> aborts the request, sent with a header parameter with the provided name. The parameter is taken into account if the sHeaderParameterValue parameter is provided too.</param>
					/// <param name="sHeaderParameterValue">The value of the parameter within the <code>headerParameters</code> aggregation to be checked.
					/// 
					/// <b>Note:</b> aborts the request, sent with a header parameter with the provided value. The parameter is taken into account if the sHeaderParameterName parameter is provided too.</param>
					public extern virtual void abort(string sHeaderParameterName, string sHeaderParameterValue);

					/// <summary>
					/// Clears the content of the <code>FileUploader</code>.
					/// 
					/// <b>Note:</b> The attached additional data however is retained.
					/// </summary>
					/// <returns>The <code>sap.ui.unified.FileUploader</code> instance</returns>
					public extern virtual sap.ui.unified.FileUploader clear();

					/// <summary>
					/// Creates a new subclass of class sap.ui.unified.FileUploader with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.unified.FileUploader with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.unified.FileUploader with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.unified.FileUploader.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					[Name("getMetadata")]
					public extern static sap.ui.@base.Metadata getMetadataStatic();

					/// <summary>
					/// Allows to process Blobs before they get uploaded. This API can be used to create custom Blobs and upload these custom Blobs instead of the received/initials Blobs in the parameter <code>aBlobs</code>. One use case could be to create and upload zip archives based on the passed Blobs. The default implementation of this API should simply resolve with the received Blobs (parameter <code>aBlobs</code>).
					/// 
					/// This API is only supported in case <code>sendXHR</code> is <code>true</code>. This means only IE10+ is supported, while IE9 and below is not.
					/// 
					/// This is a default implementation of the interface <code>sap.ui.unified.IProcessableBlobs</code>.
					/// </summary>
					/// <param name="aBlobs">The initial Blobs which can be used to determine/calculate a new array of Blobs for further processing.</param>
					/// <returns>A Promise that resolves with an array of Blobs which is used for the final uploading.</returns>
					public extern virtual es5.Promise<object> getProcessedBlobsFromArray(Retyped.dom.Blob[] aBlobs);

					/// <summary>
					/// Starts the upload (as defined by uploadUrl).
					/// </summary>
					/// <param name="bPreProcessFiles">Set to <code>true</code> to allow pre-processing of the files before sending the request. As a result, the <code>upload</code> method becomes asynchronous. See {@link sap.ui.unified.IProcessableBlobs} for more information. <b>Note:</b> This parameter is only taken into account when <code>sendXHR</code> is set to <code>true</code>.</param>
					public extern virtual void upload(bool bPreProcessFiles);

					/// <summary>
					/// Starts the upload (as defined by uploadUrl).
					/// </summary>
					public extern virtual void upload();

					#endregion

					#region Methods of sap.ui.core.IFormContent Interface

					/// <summary>
					/// In the <code>Form</code> control all content controls are positioned on a grid cell base. By default the controls use the full width of the used grid cell. But for some controls (like image controls), this is not the desired behavior. In this case the control must keep its original width.
					/// </summary>
					/// <returns>true if the <code>Form</code> is not allowed to adjust the width of the control to use the cell's width</returns>
					public extern static bool getFormDoNotAdjustWidth();

					#endregion

					#region Methods of sap.ui.unified.IProcessableBlobs Interface

					#endregion

					#endregion

				}
			}
		}
	}
}
