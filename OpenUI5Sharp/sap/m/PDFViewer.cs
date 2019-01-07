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
			/// <p>This control enables you to display PDF documents within your app. It can be embedded in your user interface layout, or you can set it to open in a popup dialog.</p> <p>Please note that the PDF Viewer control can be fully displayed on desktop devices only. On mobile devices, only the toolbar with a download button is visible.</p>
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.PDFViewer")]
			public partial class PDFViewer : sap.ui.core.Control
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
					/// Defines the height of the PDF viewer control, respective to the height of the parent container. Can be set to a percent, pixel, or em value.
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> height;

					/// <summary>
					/// Defines the width of the PDF viewer control, respective to the width of the parent container. Can be set to a percent, pixel, or em value.
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> width;

					/// <summary>
					/// Specifies the path to the PDF file to display. Can be set to a relative or an absolute path.<br> Optionally, this property can also be set to a data URI path or a blob URL in all major web browsers except Internet Explorer and Microsoft Edge, provided that this data URI or blob URL is whitelisted in advance.
					/// </summary>
					public Union<sap.ui.core.URI, string, sap.ui.@base.ManagedObject.BindPropertyInfo> source;

					/// <summary>
					/// A custom error message that is displayed when the PDF file cannot be loaded.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> errorMessage;

					/// <summary>
					/// A custom text that is displayed instead of the PDF file content when the PDF file cannot be loaded.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> errorPlaceholderMessage;

					/// <summary>
					/// A custom title for the PDF viewer popup dialog. Works only if the PDF viewer is set to open in a popup dialog.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> popupHeaderTitle;

					/// <summary>
					/// A custom title for the PDF viewer.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> title;

					/// <summary>
					/// Shows or hides the download button.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showDownloadButton;

					/// <summary>
					/// Defines how the PDF viewer should be displayed. <ul> <li>If set to <code>Link</code>, the PDF viewer appears as a toolbar with a download button that can be used to download the PDF file.<br> When the {@link open} method is called, the user can either open the PDF file in a new tab or download it.</li> <li>If set to <code>Embedded</code>, the PDF viewer appears embedded in the parent container and displays either the PDF document or the message defined by the <code>errorPlaceholderMessage</code> property.</li> <li>If set to <code>Auto</code>, the appearance of the PDF viewer depends on the device being used: <ul> <li>On mobile devices (phones, tablets), the the PDF viewer appears as a toolbar with a download button.</li> <li>On desktop devices, the PDF viewer is embedded in its parent container.</li> </ul> </li> </ul>
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> displayType;

					/// <summary>
					/// A custom control that can be used instead of the error message specified by the errorPlaceholderMessage property.
					/// </summary>
					public Union<sap.ui.core.Control, string, sap.ui.@base.ManagedObject.BindAggregationInfo> errorPlaceholder;

					/// <summary>
					/// A multiple aggregation for buttons that can be added to the footer of the popup dialog. Works only if the PDF viewer is set to open in a popup dialog.
					/// </summary>
					public Union<sap.m.Button[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> popupButtons;

					/// <summary>
					/// This event is fired when a PDF file is loaded. If the PDF is loaded in smaller chunks, this event is fired as often as defined by the browser's plugin. This may happen after a couple chunks are processed.
					/// </summary>
					public sap.ui.@base.EventDelegate loaded;

					/// <summary>
					/// This event is fired when there is an error loading the PDF file.
					/// </summary>
					public sap.ui.@base.EventDelegate error;

					/// <summary>
					/// This event is fired when the PDF viewer control cannot check the loaded content. For example, the default configuration of the Mozilla Firefox browser may not allow checking the loaded content. This may also happen when the source PDF file is stored in a different domain. If you want no error message to be displayed when this event is fired, call the preventDefault() method inside the event handler.
					/// </summary>
					public sap.ui.@base.EventDelegate sourceValidationFailed;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Definition of PDFViewer control
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">id for the new control, generated automatically if no id is given</param>
				/// <param name="mSettings">initial settings for the new control</param>
				public extern PDFViewer(string sId, sap.m.PDFViewer.Settings mSettings);

				/// <summary>
				/// Definition of PDFViewer control
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">id for the new control, generated automatically if no id is given</param>
				public extern PDFViewer(string sId);

				/// <summary>
				/// Definition of PDFViewer control
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern PDFViewer();

				/// <summary>
				/// Definition of PDFViewer control
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">initial settings for the new control</param>
				public extern PDFViewer(sap.m.PDFViewer.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property height

				/// <summary>
				/// Gets current value of property {@link #getHeight height}.
				/// 
				/// Defines the height of the PDF viewer control, respective to the height of the parent container. Can be set to a percent, pixel, or em value.
				/// 
				/// Default value is <code>100%</code>.
				/// </summary>
				/// <returns>Value of property <code>height</code></returns>
				public extern virtual sap.ui.core.CSSSize getHeight();

				/// <summary>
				/// Sets a new value for property {@link #getHeight height}.
				/// 
				/// Defines the height of the PDF viewer control, respective to the height of the parent container. Can be set to a percent, pixel, or em value.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>100%</code>.
				/// </summary>
				/// <param name="sHeight">New value for property <code>height</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PDFViewer setHeight(sap.ui.core.CSSSize sHeight);

				#endregion

				#region Methods for Property width

				/// <summary>
				/// Gets current value of property {@link #getWidth width}.
				/// 
				/// Defines the width of the PDF viewer control, respective to the width of the parent container. Can be set to a percent, pixel, or em value.
				/// 
				/// Default value is <code>100%</code>.
				/// </summary>
				/// <returns>Value of property <code>width</code></returns>
				public extern virtual sap.ui.core.CSSSize getWidth();

				/// <summary>
				/// Sets a new value for property {@link #getWidth width}.
				/// 
				/// Defines the width of the PDF viewer control, respective to the width of the parent container. Can be set to a percent, pixel, or em value.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>100%</code>.
				/// </summary>
				/// <param name="sWidth">New value for property <code>width</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PDFViewer setWidth(sap.ui.core.CSSSize sWidth);

				#endregion

				#region Methods for Property source

				/// <summary>
				/// Gets current value of property {@link #getSource source}.
				/// 
				/// Specifies the path to the PDF file to display. Can be set to a relative or an absolute path.<br> Optionally, this property can also be set to a data URI path or a blob URL in all major web browsers except Internet Explorer and Microsoft Edge, provided that this data URI or blob URL is whitelisted in advance.
				/// </summary>
				/// <returns>Value of property <code>source</code></returns>
				public extern virtual sap.ui.core.URI getSource();

				/// <summary>
				/// Sets a new value for property {@link #getSource source}.
				/// 
				/// Specifies the path to the PDF file to display. Can be set to a relative or an absolute path.<br> Optionally, this property can also be set to a data URI path or a blob URL in all major web browsers except Internet Explorer and Microsoft Edge, provided that this data URI or blob URL is whitelisted in advance.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sSource">New value for property <code>source</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PDFViewer setSource(sap.ui.core.URI sSource);

				#endregion

				#region Methods for Property errorMessage

				/// <summary>
				/// Gets current value of property {@link #getErrorMessage errorMessage}.
				/// 
				/// A custom error message that is displayed when the PDF file cannot be loaded.
				/// </summary>
				/// <returns>Value of property <code>errorMessage</code></returns>
				[Obsolete("Deprecated since 1.50.0. replaced by {@link sap.m.PDFViewer#getErrorPlaceholderMessage}.")]
				public extern virtual string getErrorMessage();

				/// <summary>
				/// Sets a new value for property {@link #getErrorMessage errorMessage}.
				/// 
				/// A custom error message that is displayed when the PDF file cannot be loaded.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sErrorMessage">New value for property <code>errorMessage</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.50.0. replaced by {@link sap.m.PDFViewer#getErrorPlaceholderMessage}.")]
				public extern virtual sap.m.PDFViewer setErrorMessage(string sErrorMessage);

				#endregion

				#region Methods for Property errorPlaceholderMessage

				/// <summary>
				/// Gets current value of property {@link #getErrorPlaceholderMessage errorPlaceholderMessage}.
				/// 
				/// A custom text that is displayed instead of the PDF file content when the PDF file cannot be loaded.
				/// </summary>
				/// <returns>Value of property <code>errorPlaceholderMessage</code></returns>
				public extern virtual string getErrorPlaceholderMessage();

				/// <summary>
				/// Sets a new value for property {@link #getErrorPlaceholderMessage errorPlaceholderMessage}.
				/// 
				/// A custom text that is displayed instead of the PDF file content when the PDF file cannot be loaded.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sErrorPlaceholderMessage">New value for property <code>errorPlaceholderMessage</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PDFViewer setErrorPlaceholderMessage(string sErrorPlaceholderMessage);

				#endregion

				#region Methods for Property popupHeaderTitle

				/// <summary>
				/// Gets current value of property {@link #getPopupHeaderTitle popupHeaderTitle}.
				/// 
				/// A custom title for the PDF viewer popup dialog. Works only if the PDF viewer is set to open in a popup dialog.
				/// </summary>
				/// <returns>Value of property <code>popupHeaderTitle</code></returns>
				[Obsolete("Deprecated since 1.50.0. replaced by {@link sap.m.PDFViewer#getTitle}.")]
				public extern virtual string getPopupHeaderTitle();

				/// <summary>
				/// Sets a new value for property {@link #getPopupHeaderTitle popupHeaderTitle}.
				/// 
				/// A custom title for the PDF viewer popup dialog. Works only if the PDF viewer is set to open in a popup dialog.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sPopupHeaderTitle">New value for property <code>popupHeaderTitle</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.50.0. replaced by {@link sap.m.PDFViewer#getTitle}.")]
				public extern virtual sap.m.PDFViewer setPopupHeaderTitle(string sPopupHeaderTitle);

				#endregion

				#region Methods for Property title

				/// <summary>
				/// Gets current value of property {@link #getTitle title}.
				/// 
				/// A custom title for the PDF viewer.
				/// </summary>
				/// <returns>Value of property <code>title</code></returns>
				public extern virtual string getTitle();

				/// <summary>
				/// Sets a new value for property {@link #getTitle title}.
				/// 
				/// A custom title for the PDF viewer.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sTitle">New value for property <code>title</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PDFViewer setTitle(string sTitle);

				#endregion

				#region Methods for Property showDownloadButton

				/// <summary>
				/// Gets current value of property {@link #getShowDownloadButton showDownloadButton}.
				/// 
				/// Shows or hides the download button.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>showDownloadButton</code></returns>
				public extern virtual bool getShowDownloadButton();

				/// <summary>
				/// Sets a new value for property {@link #getShowDownloadButton showDownloadButton}.
				/// 
				/// Shows or hides the download button.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bShowDownloadButton">New value for property <code>showDownloadButton</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PDFViewer setShowDownloadButton(bool bShowDownloadButton);

				#endregion

				#region Methods for Property displayType

				/// <summary>
				/// Gets current value of property {@link #getDisplayType displayType}.
				/// 
				/// Defines how the PDF viewer should be displayed. <ul> <li>If set to <code>Link</code>, the PDF viewer appears as a toolbar with a download button that can be used to download the PDF file.<br> When the {@link open} method is called, the user can either open the PDF file in a new tab or download it.</li> <li>If set to <code>Embedded</code>, the PDF viewer appears embedded in the parent container and displays either the PDF document or the message defined by the <code>errorPlaceholderMessage</code> property.</li> <li>If set to <code>Auto</code>, the appearance of the PDF viewer depends on the device being used: <ul> <li>On mobile devices (phones, tablets), the the PDF viewer appears as a toolbar with a download button.</li> <li>On desktop devices, the PDF viewer is embedded in its parent container.</li> </ul> </li> </ul>
				/// 
				/// Default value is <code>sap.m.PDFViewerDisplayTypes.Auto</code>.
				/// </summary>
				/// <returns>Value of property <code>displayType</code></returns>
				public extern virtual string getDisplayType();

				/// <summary>
				/// Sets a new value for property {@link #getDisplayType displayType}.
				/// 
				/// Defines how the PDF viewer should be displayed. <ul> <li>If set to <code>Link</code>, the PDF viewer appears as a toolbar with a download button that can be used to download the PDF file.<br> When the {@link open} method is called, the user can either open the PDF file in a new tab or download it.</li> <li>If set to <code>Embedded</code>, the PDF viewer appears embedded in the parent container and displays either the PDF document or the message defined by the <code>errorPlaceholderMessage</code> property.</li> <li>If set to <code>Auto</code>, the appearance of the PDF viewer depends on the device being used: <ul> <li>On mobile devices (phones, tablets), the the PDF viewer appears as a toolbar with a download button.</li> <li>On desktop devices, the PDF viewer is embedded in its parent container.</li> </ul> </li> </ul>
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>sap.m.PDFViewerDisplayTypes.Auto</code>.
				/// </summary>
				/// <param name="sDisplayType">New value for property <code>displayType</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PDFViewer setDisplayType(string sDisplayType);

				#endregion

				#region Methods for Aggregation errorPlaceholder

				/// <summary>
				/// Gets content of aggregation {@link #getErrorPlaceholder errorPlaceholder}.
				/// 
				/// A custom control that can be used instead of the error message specified by the errorPlaceholderMessage property.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.Control getErrorPlaceholder();

				/// <summary>
				/// Destroys the errorPlaceholder in the aggregation {@link #getErrorPlaceholder errorPlaceholder}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PDFViewer destroyErrorPlaceholder();

				/// <summary>
				/// Sets the aggregated {@link #getErrorPlaceholder errorPlaceholder}.
				/// </summary>
				/// <param name="oErrorPlaceholder">The errorPlaceholder to set</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PDFViewer setErrorPlaceholder(sap.ui.core.Control oErrorPlaceholder);

				#endregion

				#region Methods for Aggregation popupButtons

				/// <summary>
				/// Gets content of aggregation {@link #getPopupButtons popupButtons}.
				/// 
				/// A multiple aggregation for buttons that can be added to the footer of the popup dialog. Works only if the PDF viewer is set to open in a popup dialog.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.Button[] getPopupButtons();

				/// <summary>
				/// Destroys all the popupButtons in the aggregation {@link #getPopupButtons popupButtons}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PDFViewer destroyPopupButtons();

				/// <summary>
				/// Inserts a popupButton into the aggregation {@link #getPopupButtons popupButtons}.
				/// </summary>
				/// <param name="oPopupButton">The popupButton to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the popupButton should be inserted at; for a negative value of <code>iIndex</code>, the popupButton is inserted at position 0; for a value greater than the current size of the aggregation, the popupButton is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PDFViewer insertPopupButton(sap.m.Button oPopupButton, int iIndex);

				/// <summary>
				/// Adds some popupButton to the aggregation {@link #getPopupButtons popupButtons}.
				/// </summary>
				/// <param name="oPopupButton">The popupButton to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PDFViewer addPopupButton(sap.m.Button oPopupButton);

				/// <summary>
				/// Removes a popupButton from the aggregation {@link #getPopupButtons popupButtons}.
				/// </summary>
				/// <param name="vPopupButton">The popupButton to remove or its index or id</param>
				/// <returns>The removed popupButton or <code>null</code></returns>
				public extern virtual sap.m.Button removePopupButton(Union<int, string, sap.m.Button> vPopupButton);

				/// <summary>
				/// Checks for the provided <code>sap.m.Button</code> in the aggregation {@link #getPopupButtons popupButtons}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oPopupButton">The popupButton whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfPopupButton(sap.m.Button oPopupButton);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getPopupButtons popupButtons}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.m.Button[] removeAllPopupButtons();

				#endregion

				#region Methods for Event loaded

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:loaded loaded} event of this <code>sap.m.PDFViewer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.PDFViewer</code> itself.
				/// 
				/// This event is fired when a PDF file is loaded. If the PDF is loaded in smaller chunks, this event is fired as often as defined by the browser's plugin. This may happen after a couple chunks are processed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.PDFViewer</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PDFViewer attachLoaded(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:loaded loaded} event of this <code>sap.m.PDFViewer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.PDFViewer</code> itself.
				/// 
				/// This event is fired when a PDF file is loaded. If the PDF is loaded in smaller chunks, this event is fired as often as defined by the browser's plugin. This may happen after a couple chunks are processed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PDFViewer attachLoaded(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:loaded loaded} event of this <code>sap.m.PDFViewer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.PDFViewer</code> itself.
				/// 
				/// This event is fired when a PDF file is loaded. If the PDF is loaded in smaller chunks, this event is fired as often as defined by the browser's plugin. This may happen after a couple chunks are processed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PDFViewer attachLoaded(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:loaded loaded} event of this <code>sap.m.PDFViewer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.PDFViewer</code> itself.
				/// 
				/// This event is fired when a PDF file is loaded. If the PDF is loaded in smaller chunks, this event is fired as often as defined by the browser's plugin. This may happen after a couple chunks are processed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.PDFViewer</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PDFViewer attachLoaded(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:loaded loaded} event of this <code>sap.m.PDFViewer</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PDFViewer detachLoaded(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:loaded loaded} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PDFViewer fireLoaded(object mParameters);

				/// <summary>
				/// Fires event {@link #event:loaded loaded} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PDFViewer fireLoaded();

				#endregion

				#region Methods for Event error

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:error error} event of this <code>sap.m.PDFViewer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.PDFViewer</code> itself.
				/// 
				/// This event is fired when there is an error loading the PDF file.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.PDFViewer</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PDFViewer attachError(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:error error} event of this <code>sap.m.PDFViewer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.PDFViewer</code> itself.
				/// 
				/// This event is fired when there is an error loading the PDF file.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PDFViewer attachError(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:error error} event of this <code>sap.m.PDFViewer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.PDFViewer</code> itself.
				/// 
				/// This event is fired when there is an error loading the PDF file.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PDFViewer attachError(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:error error} event of this <code>sap.m.PDFViewer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.PDFViewer</code> itself.
				/// 
				/// This event is fired when there is an error loading the PDF file.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.PDFViewer</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PDFViewer attachError(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:error error} event of this <code>sap.m.PDFViewer</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PDFViewer detachError(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:error error} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PDFViewer fireError(object mParameters);

				/// <summary>
				/// Fires event {@link #event:error error} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PDFViewer fireError();

				#endregion

				#region Methods for Event sourceValidationFailed

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:sourceValidationFailed sourceValidationFailed} event of this <code>sap.m.PDFViewer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.PDFViewer</code> itself.
				/// 
				/// This event is fired when the PDF viewer control cannot check the loaded content. For example, the default configuration of the Mozilla Firefox browser may not allow checking the loaded content. This may also happen when the source PDF file is stored in a different domain. If you want no error message to be displayed when this event is fired, call the preventDefault() method inside the event handler.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.PDFViewer</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PDFViewer attachSourceValidationFailed(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:sourceValidationFailed sourceValidationFailed} event of this <code>sap.m.PDFViewer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.PDFViewer</code> itself.
				/// 
				/// This event is fired when the PDF viewer control cannot check the loaded content. For example, the default configuration of the Mozilla Firefox browser may not allow checking the loaded content. This may also happen when the source PDF file is stored in a different domain. If you want no error message to be displayed when this event is fired, call the preventDefault() method inside the event handler.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PDFViewer attachSourceValidationFailed(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:sourceValidationFailed sourceValidationFailed} event of this <code>sap.m.PDFViewer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.PDFViewer</code> itself.
				/// 
				/// This event is fired when the PDF viewer control cannot check the loaded content. For example, the default configuration of the Mozilla Firefox browser may not allow checking the loaded content. This may also happen when the source PDF file is stored in a different domain. If you want no error message to be displayed when this event is fired, call the preventDefault() method inside the event handler.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PDFViewer attachSourceValidationFailed(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:sourceValidationFailed sourceValidationFailed} event of this <code>sap.m.PDFViewer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.PDFViewer</code> itself.
				/// 
				/// This event is fired when the PDF viewer control cannot check the loaded content. For example, the default configuration of the Mozilla Firefox browser may not allow checking the loaded content. This may also happen when the source PDF file is stored in a different domain. If you want no error message to be displayed when this event is fired, call the preventDefault() method inside the event handler.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.PDFViewer</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PDFViewer attachSourceValidationFailed(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:sourceValidationFailed sourceValidationFailed} event of this <code>sap.m.PDFViewer</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PDFViewer detachSourceValidationFailed(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:sourceValidationFailed sourceValidationFailed} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PDFViewer fireSourceValidationFailed(object mParameters);

				/// <summary>
				/// Fires event {@link #event:sourceValidationFailed sourceValidationFailed} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PDFViewer fireSourceValidationFailed();

				#endregion

				#region Other methods

				/// <summary>
				/// Downloads the PDF file.
				/// </summary>
				public extern virtual void downloadPDF();

				/// <summary>
				/// Creates a new subclass of class sap.m.PDFViewer with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.PDFViewer with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.PDFViewer with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.PDFViewer.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				[Name("getMetadata")]
				public extern static sap.ui.@base.Metadata getMetadataStatic();

				/// <summary>
				/// Triggers rerendering of this element and its children.
				/// </summary>
				/// <param name="oOrigin">Child control for which the method was called</param>
				public extern override void invalidate(sap.ui.@base.ManagedObject oOrigin);

				/// <summary>
				/// Triggers rerendering of this element and its children.
				/// </summary>
				public extern override void invalidate();

				/// <summary>
				/// Opens the PDF viewer in a popup dialog.
				/// </summary>
				public extern virtual void open();

				#endregion

				#endregion

			}
		}
	}
}
