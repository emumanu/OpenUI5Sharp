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
			public static partial class core
			{
				/// <summary>
				/// Core Class of the SAP UI Library.
				/// 
				/// This class boots the Core framework and makes it available for the application via method <code>sap.ui.getCore()</code>.
				/// 
				/// Example: <pre>
				/// 
				///   var oCore = sap.ui.getCore();
				/// 
				/// </pre>
				/// 
				/// With methods of the Core framework you can {@link #attachInit execute code} after the framework has been initialized. It provides access to the {@link #getConfiguration configuration} and exposes events that an application or a control can register to (e.g. {@link #event:localizationChanged localizationChanged}, {@link #event:parseError parseError}, {@link #event:validationError validationError}, {@link #event:formatError formatError}, {@link #event:validationSuccess validationSuccess}).
				/// 
				/// Example: <pre>
				/// 
				///   oCore.attachInit(function() {
				///     if ( oCore.getConfiguration().getRTL() ) {
				///       ...
				///     }
				///   });
				/// 
				///   oCore.attachLocalizationChanged(function(oEvent) {
				///     ...
				///   });
				/// 
				/// </pre>
				/// </summary>
				[External]
				[Namespace(false)]
				public partial class Core : sap.ui.@base.Object
				{
					#region Typed Parameters

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class ErrorInfo
					{
						/// <summary>
						/// The Element where the format error occurred
						/// </summary>
						public sap.ui.core.Element element;

						/// <summary>
						/// The property name of the element where the format error occurred
						/// </summary>
						public string property;

						/// <summary>
						/// The type of the property
						/// </summary>
						public sap.ui.model.Type type;

						/// <summary>
						/// The value of the property which was entered when the format error occurred
						/// </summary>
						public object newValue;

						/// <summary>
						/// The value of the property which was present before a new value was entered (before the format error)
						/// </summary>
						public object oldValue;

						/// <summary>
						/// The exception object which occurred and has more information about the format error
						/// </summary>
						public object exception;

					}

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class LocalizationChangedInfo
					{
						/// <summary>
						/// a map of the changed localization properties
						/// </summary>
						public object changes;

					}

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class ThemeChangedInfo
					{
						/// <summary>
						/// Theme name
						/// </summary>
						public string theme;

					}

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class ValidationSuccessInfo
					{
						/// <summary>
						/// The Element where the successful validation occurred
						/// </summary>
						public sap.ui.core.Element element;

						/// <summary>
						/// The property name of the element where the successfull validation occurred
						/// </summary>
						public string property;

						/// <summary>
						/// The type of the property
						/// </summary>
						public sap.ui.model.Type type;

						/// <summary>
						/// The value of the property which was entered when the validation occurred
						/// </summary>
						public object newValue;

						/// <summary>
						/// The value of the property which was present before a new value was entered (before the validation)
						/// </summary>
						public object oldValue;

					}

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class CreateComponentInfo
					{
						/// <summary>
						/// name of the component to import
						/// </summary>
						public string name;

						/// <summary>
						/// URL to load the component from
						/// </summary>
						public string url;

						/// <summary>
						/// ID for the component instance
						/// </summary>
						public string id;

						/// <summary>
						/// settings object for the component
						/// </summary>
						public object settings;

						/// <summary>
						/// user specific data which is available during the whole lifecycle of the component
						/// </summary>
						public string componentData;

					}

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class InitLibraryInfo
					{
						/// <summary>
						/// Name of the library; when given it must match the name by which the library has been loaded
						/// </summary>
						public string name;

						/// <summary>
						/// Version of the library
						/// </summary>
						public string version;

						/// <summary>
						/// List of libraries that this library depends on; names are in dot notation (e.g. "sap.ui.core")
						/// </summary>
						public string[] dependencies;

						/// <summary>
						/// List of names of types that this library provides; names are in dot notation (e.g. "sap.ui.core.CSSSize")
						/// </summary>
						public string[] types;

						/// <summary>
						/// List of names of interface types that this library provides; names are in dot notation (e.g. "sap.ui.core.PopupInterface")
						/// </summary>
						public string[] interfaces;

						/// <summary>
						/// Names of control types that this library provides; names are in dot notation (e.g. "sap.ui.core.ComponentContainer")
						/// </summary>
						public string[] controls;

						/// <summary>
						/// Names of element types that this library provides (excluding controls); names are in dot notation (e.g. "sap.ui.core.Item")
						/// </summary>
						public string[] elements;

						/// <summary>
						/// Indicates whether the library doesn't provide / use theming. When set to true, no library.css will be loaded for this library
						/// </summary>
						public bool noLibraryCSS;

						/// <summary>
						/// Potential extensions of the library metadata; structure not defined by the UI5 core framework.
						/// </summary>
						public object extensions;

					}

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class LoadLibraryInfo
					{
						/// <summary>
						/// URL to load the library from
						/// </summary>
						public string url;

						/// <summary>
						/// Whether to load the library asynchronously
						/// </summary>
						public bool async;

					}

					#endregion

					#region Delegates

					public delegate void ErrorDelegate(sap.ui.@base.Event<sap.ui.core.Core.ErrorInfo> oEvent, object oData);

					public delegate void LocalizationChangedDelegate(sap.ui.@base.Event<sap.ui.core.Core.LocalizationChangedInfo> oEvent, object oData);

					public delegate void ThemeChangedDelegate(sap.ui.@base.Event<sap.ui.core.Core.ThemeChangedInfo> oEvent, object oData);

					public delegate void ValidationSuccessDelegate(sap.ui.@base.Event<sap.ui.core.Core.ValidationSuccessInfo> oEvent, object oData);

					#endregion

					#region Constructor

					public extern Core();

					#endregion

					#region Methods

					#region Methods for event formatError

					/// <summary>
					/// Attach event-handler <code>fnFunction</code> to the 'formatError' event of <code>sap.ui.core.Core</code>.
					/// 
					/// Please note that this event is a bubbling event and may already be canceled before reaching the core.
					/// </summary>
					/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
					/// <param name="oListener">Object on which to call the given function. If empty, an unspecified context object is used (listeners cannot expect this to be the <code>Core</code>).</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.Core attachFormatError(sap.ui.core.Core.ErrorDelegate fnFunction, object oListener);

					/// <summary>
					/// Attach event-handler <code>fnFunction</code> to the 'formatError' event of <code>sap.ui.core.Core</code>.
					/// 
					/// Please note that this event is a bubbling event and may already be canceled before reaching the core.
					/// </summary>
					/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.Core attachFormatError(sap.ui.core.Core.ErrorDelegate fnFunction);

					/// <summary>
					/// Detach event-handler <code>fnFunction</code> from the 'formatError' event of <code>sap.ui.core.Core</code>.
					/// 
					/// The passed function and listener object must match the ones previously used for event registration.
					/// </summary>
					/// <param name="fnFunction">The callback function to unregister</param>
					/// <param name="oListener">Object on which the given function had to be called.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.Core detachFormatError(sap.ui.core.Core.ErrorDelegate fnFunction, object oListener);

					/// <summary>
					/// Fire event formatError to attached listeners.
					/// 
					/// Expects following event parameters: <ul> <li>'element' of type <code>sap.ui.core.Element</code> </li> <li>'property' of type <code>string</code> </li> <li>'type' of type <code>string</code> </li> <li>'newValue' of type <code>object</code> </li> <li>'oldValue' of type <code>object</code> </li> <li>'exception' of type <code>object</code> </li> </ul>
					/// </summary>
					/// <param name="mArguments">the arguments to pass along with the event.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.Core fireFormatError(Map mArguments);

					/// <summary>
					/// Fire event formatError to attached listeners.
					/// 
					/// Expects following event parameters: <ul> <li>'element' of type <code>sap.ui.core.Element</code> </li> <li>'property' of type <code>string</code> </li> <li>'type' of type <code>string</code> </li> <li>'newValue' of type <code>object</code> </li> <li>'oldValue' of type <code>object</code> </li> <li>'exception' of type <code>object</code> </li> </ul>
					/// </summary>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.Core fireFormatError();

					#endregion

					#region Methods for event localizationChanged

					/// <summary>
					/// Register a listener for the <code>localizationChanged</code> event.
					/// </summary>
					/// <param name="fnFunction">callback to be called</param>
					/// <param name="oListener">context object to cal lthe function on.</param>
					public extern virtual void attachLocalizationChanged(sap.ui.core.Core.LocalizationChangedDelegate fnFunction, object oListener);

					/// <summary>
					/// Unregister a listener from the <code>localizationChanged</code> event.
					/// 
					/// The listener will only be unregistered if the same function/context combination is given as in the call to <code>attachLocalizationListener</code>.
					/// </summary>
					/// <param name="fnFunction">callback to be deregistered</param>
					/// <param name="oListener">context object given in a previous call to attachLocalizationChanged.</param>
					public extern virtual void detachLocalizationChanged(sap.ui.core.Core.LocalizationChangedDelegate fnFunction, object oListener);

					#endregion

					#region Methods for event parseError

					/// <summary>
					/// Attach event-handler <code>fnFunction</code> to the 'parseError' event of <code>sap.ui.core.Core</code>.
					/// 
					/// Please note that this event is a bubbling event and may already be canceled before reaching the core.
					/// </summary>
					/// <param name="oData">The object, that should be passed along with the event-object when firing the event</param>
					/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
					/// <param name="oListener">Object on which to call the given function. If empty, an unspecified context object is used (listeners cannot expect this to be the <code>Core</code>).</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.Core attachParseError(object oData, sap.ui.core.Core.ErrorDelegate fnFunction, object oListener);

					/// <summary>
					/// Attach event-handler <code>fnFunction</code> to the 'parseError' event of <code>sap.ui.core.Core</code>.
					/// 
					/// Please note that this event is a bubbling event and may already be canceled before reaching the core.
					/// </summary>
					/// <param name="oData">The object, that should be passed along with the event-object when firing the event</param>
					/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.Core attachParseError(object oData, sap.ui.core.Core.ErrorDelegate fnFunction);

					/// <summary>
					/// Attach event-handler <code>fnFunction</code> to the 'parseError' event of <code>sap.ui.core.Core</code>.
					/// 
					/// Please note that this event is a bubbling event and may already be canceled before reaching the core.
					/// </summary>
					/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.Core attachParseError(sap.ui.core.Core.ErrorDelegate fnFunction);

					/// <summary>
					/// Attach event-handler <code>fnFunction</code> to the 'parseError' event of <code>sap.ui.core.Core</code>.
					/// 
					/// Please note that this event is a bubbling event and may already be canceled before reaching the core.
					/// </summary>
					/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
					/// <param name="oListener">Object on which to call the given function. If empty, an unspecified context object is used (listeners cannot expect this to be the <code>Core</code>).</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.Core attachParseError(sap.ui.core.Core.ErrorDelegate fnFunction, object oListener);

					/// <summary>
					/// Detach event-handler <code>fnFunction</code> from the 'parseError' event of <code>sap.ui.core.Core</code>.
					/// 
					/// The passed function and listener object must match the ones previously used for event registration.
					/// </summary>
					/// <param name="fnFunction">The callback function to unregister.</param>
					/// <param name="oListener">Object on which the given function had to be called.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.Core detachParseError(sap.ui.core.Core.ErrorDelegate fnFunction, object oListener);

					/// <summary>
					/// Fire event parseError to attached listeners.
					/// 
					/// Expects following event parameters: <ul> <li>'element' of type <code>sap.ui.core.Element</code> </li> <li>'property' of type <code>string</code> </li> <li>'type' of type <code>string</code> </li> <li>'newValue' of type <code>object</code> </li> <li>'oldValue' of type <code>object</code> </li> <li>'exception' of type <code>object</code> </li> </ul>
					/// </summary>
					/// <param name="mArguments">the arguments to pass along with the event.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.Core fireParseError(Map mArguments);

					/// <summary>
					/// Fire event parseError to attached listeners.
					/// 
					/// Expects following event parameters: <ul> <li>'element' of type <code>sap.ui.core.Element</code> </li> <li>'property' of type <code>string</code> </li> <li>'type' of type <code>string</code> </li> <li>'newValue' of type <code>object</code> </li> <li>'oldValue' of type <code>object</code> </li> <li>'exception' of type <code>object</code> </li> </ul>
					/// </summary>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.Core fireParseError();

					#endregion

					#region Methods for event ThemeChanged

					/// <summary>
					/// Attach event-handler <code>fnFunction</code> to the <code>ThemeChanged</code> event of this <code>sap.ui.core.Core</code>.
					/// </summary>
					/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
					/// <param name="oListener">Object on which to call the given function.</param>
					public extern virtual void attachThemeChanged(sap.ui.core.Core.ThemeChangedDelegate fnFunction, object oListener);

					/// <summary>
					/// Attach event-handler <code>fnFunction</code> to the <code>ThemeChanged</code> event of this <code>sap.ui.core.Core</code>.
					/// </summary>
					/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
					public extern virtual void attachThemeChanged(sap.ui.core.Core.ThemeChangedDelegate fnFunction);

					/// <summary>
					/// Detach event-handler <code>fnFunction</code> from the <code>ThemeChanged</code> event of this <code>sap.ui.core.Core</code>.
					/// 
					/// The passed function and listener object must match the ones previously used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to call, when the event occurs.</param>
					/// <param name="oListener">Object on which the given function had to be called.</param>
					public extern virtual void detachThemeChanged(sap.ui.core.Core.ThemeChangedDelegate fnFunction, object oListener);

					/// <summary>
					/// Detach event-handler <code>fnFunction</code> from the <code>ThemeChanged</code> event of this <code>sap.ui.core.Core</code>.
					/// 
					/// The passed function and listener object must match the ones previously used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to call, when the event occurs.</param>
					public extern virtual void detachThemeChanged(sap.ui.core.Core.ThemeChangedDelegate fnFunction);

					#endregion

					#region Methods for event validationError

					/// <summary>
					/// Attach event-handler <code>fnFunction</code> to the 'validationError' event of <code>sap.ui.core.Core</code>.
					/// 
					/// Please note that this event is a bubbling event and may already be canceled before reaching the core.
					/// </summary>
					/// <param name="oData">The object, that should be passed along with the event-object when firing the event</param>
					/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
					/// <param name="oListener">Object on which to call the given function. If empty, an unspecified context object is used (listeners cannot expect this to be the <code>Core</code>).</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.Core attachValidationError(object oData, sap.ui.core.Core.ErrorDelegate fnFunction, object oListener);

					/// <summary>
					/// Attach event-handler <code>fnFunction</code> to the 'validationError' event of <code>sap.ui.core.Core</code>.
					/// 
					/// Please note that this event is a bubbling event and may already be canceled before reaching the core.
					/// </summary>
					/// <param name="oData">The object, that should be passed along with the event-object when firing the event</param>
					/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.Core attachValidationError(object oData, sap.ui.core.Core.ErrorDelegate fnFunction);

					/// <summary>
					/// Attach event-handler <code>fnFunction</code> to the 'validationError' event of <code>sap.ui.core.Core</code>.
					/// 
					/// Please note that this event is a bubbling event and may already be canceled before reaching the core.
					/// </summary>
					/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.Core attachValidationError(sap.ui.core.Core.ErrorDelegate fnFunction);

					/// <summary>
					/// Attach event-handler <code>fnFunction</code> to the 'validationError' event of <code>sap.ui.core.Core</code>.
					/// 
					/// Please note that this event is a bubbling event and may already be canceled before reaching the core.
					/// </summary>
					/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
					/// <param name="oListener">Object on which to call the given function. If empty, an unspecified context object is used (listeners cannot expect this to be the <code>Core</code>).</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.Core attachValidationError(sap.ui.core.Core.ErrorDelegate fnFunction, object oListener);

					/// <summary>
					/// Detach event-handler <code>fnFunction</code> from the 'validationError' event of <code>sap.ui.core.Core</code>.
					/// 
					/// The passed function and listener object must match the ones previously used for event registration.
					/// </summary>
					/// <param name="fnFunction">The callback function to unregister</param>
					/// <param name="oListener">Object on which the given function had to be called.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.Core detachValidationError(sap.ui.core.Core.ErrorDelegate fnFunction, object oListener);

					/// <summary>
					/// Fire event validationError to attached listeners.
					/// 
					/// Expects following event parameters: <ul> <li>'element' of type <code>sap.ui.core.Element</code> </li> <li>'property' of type <code>string</code> </li> <li>'type' of type <code>string</code> </li> <li>'newValue' of type <code>object</code> </li> <li>'oldValue' of type <code>object</code> </li> <li>'exception' of type <code>object</code> </li> </ul>
					/// </summary>
					/// <param name="mArguments">the arguments to pass along with the event.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.Core fireValidationError(Map mArguments);

					/// <summary>
					/// Fire event validationError to attached listeners.
					/// 
					/// Expects following event parameters: <ul> <li>'element' of type <code>sap.ui.core.Element</code> </li> <li>'property' of type <code>string</code> </li> <li>'type' of type <code>string</code> </li> <li>'newValue' of type <code>object</code> </li> <li>'oldValue' of type <code>object</code> </li> <li>'exception' of type <code>object</code> </li> </ul>
					/// </summary>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.Core fireValidationError();

					#endregion

					#region Methods for event validationSuccess

					/// <summary>
					/// Attach event-handler <code>fnFunction</code> to the 'validationSuccess' event of <code>sap.ui.core.Core</code>.
					/// 
					/// Please note that this event is a bubbling event and may already be canceled before reaching the core.
					/// </summary>
					/// <param name="oData">The object, that should be passed along with the event-object when firing the event</param>
					/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
					/// <param name="oListener">Object on which to call the given function. If empty, an unspecified context object is used (listeners cannot expect this to be the <code>Core</code>).</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.Core attachValidationSuccess(object oData, sap.ui.core.Core.ValidationSuccessDelegate fnFunction, object oListener);

					/// <summary>
					/// Attach event-handler <code>fnFunction</code> to the 'validationSuccess' event of <code>sap.ui.core.Core</code>.
					/// 
					/// Please note that this event is a bubbling event and may already be canceled before reaching the core.
					/// </summary>
					/// <param name="oData">The object, that should be passed along with the event-object when firing the event</param>
					/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.Core attachValidationSuccess(object oData, sap.ui.core.Core.ValidationSuccessDelegate fnFunction);

					/// <summary>
					/// Attach event-handler <code>fnFunction</code> to the 'validationSuccess' event of <code>sap.ui.core.Core</code>.
					/// 
					/// Please note that this event is a bubbling event and may already be canceled before reaching the core.
					/// </summary>
					/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.Core attachValidationSuccess(sap.ui.core.Core.ValidationSuccessDelegate fnFunction);

					/// <summary>
					/// Attach event-handler <code>fnFunction</code> to the 'validationSuccess' event of <code>sap.ui.core.Core</code>.
					/// 
					/// Please note that this event is a bubbling event and may already be canceled before reaching the core.
					/// </summary>
					/// <param name="fnFunction">The function to call, when the event occurs. This function will be called on the oListener-instance (if present) or in a 'static way'.</param>
					/// <param name="oListener">Object on which to call the given function. If empty, an unspecified context object is used (listeners cannot expect this to be the <code>Core</code>).</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.Core attachValidationSuccess(sap.ui.core.Core.ValidationSuccessDelegate fnFunction, object oListener);

					/// <summary>
					/// Detach event-handler <code>fnFunction</code> from the 'validationSuccess' event of <code>sap.ui.core.Core</code>.
					/// 
					/// The passed function and listener object must match the ones previously used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to call, when the event occurs.</param>
					/// <param name="oListener">Object on which the given function had to be called.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.Core detachValidationSuccess(sap.ui.core.Core.ValidationSuccessDelegate fnFunction, object oListener);

					/// <summary>
					/// Fire event validationSuccess to attached listeners.
					/// 
					/// Expects following event parameters: <ul> <li>'element' of type <code>sap.ui.core.Element</code> </li> <li>'property' of type <code>string</code> </li> <li>'type' of type <code>string</code> </li> <li>'newValue' of type <code>object</code> </li> <li>'oldValue' of type <code>object</code> </li> </ul>
					/// </summary>
					/// <param name="mArguments">the arguments to pass along with the event.</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.Core fireValidationSuccess(Map mArguments);

					/// <summary>
					/// Fire event validationSuccess to attached listeners.
					/// 
					/// Expects following event parameters: <ul> <li>'element' of type <code>sap.ui.core.Element</code> </li> <li>'property' of type <code>string</code> </li> <li>'type' of type <code>string</code> </li> <li>'newValue' of type <code>object</code> </li> <li>'oldValue' of type <code>object</code> </li> </ul>
					/// </summary>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.Core fireValidationSuccess();

					#endregion

					#region Other methods

					/// <summary>
					/// Enforces an immediate update of the visible UI (aka "rendering").
					/// 
					/// In general, applications should avoid calling this method and instead let the framework manage any necessary rendering.
					/// </summary>
					public extern virtual void applyChanges();

					/// <summary>
					/// Applies the theme with the given name (by loading the respective style sheets, which does not disrupt the application).
					/// 
					/// By default, the theme files are expected to be located at path relative to the respective control library ([libraryLocation]/themes/[themeName]). Different locations can be configured by using the method setThemePath() or by using the second parameter "sThemeBaseUrl" of applyTheme(). Usage of this second parameter is a shorthand for setThemePath and internally calls setThemePath, so the theme location is then known.
					/// 
					/// sThemeBaseUrl is a single URL to specify the default location of all theme files. This URL is the base folder below which the control library folders are located. E.g. if the CSS files are not located relative to the root location of UI5, but instead they are at locations like http://my.server/myapp/resources/sap/ui/core/themes/my_theme/library.css then the URL that needs to be given is: http://my.server/myapp/resources All theme resources are then loaded from below this folder - except if for a certain library a different location has been registered.
					/// 
					/// If the theme resources are not all either below this base location or with their respective libraries, then setThemePath must be used to configure individual locations.
					/// </summary>
					/// <param name="sThemeName">the name of the theme to be loaded</param>
					/// <param name="sThemeBaseUrl">the (optional) base location of the theme</param>
					public extern virtual void applyTheme(string sThemeName, string sThemeBaseUrl);

					/// <summary>
					/// Applies the theme with the given name (by loading the respective style sheets, which does not disrupt the application).
					/// 
					/// By default, the theme files are expected to be located at path relative to the respective control library ([libraryLocation]/themes/[themeName]). Different locations can be configured by using the method setThemePath() or by using the second parameter "sThemeBaseUrl" of applyTheme(). Usage of this second parameter is a shorthand for setThemePath and internally calls setThemePath, so the theme location is then known.
					/// 
					/// sThemeBaseUrl is a single URL to specify the default location of all theme files. This URL is the base folder below which the control library folders are located. E.g. if the CSS files are not located relative to the root location of UI5, but instead they are at locations like http://my.server/myapp/resources/sap/ui/core/themes/my_theme/library.css then the URL that needs to be given is: http://my.server/myapp/resources All theme resources are then loaded from below this folder - except if for a certain library a different location has been registered.
					/// 
					/// If the theme resources are not all either below this base location or with their respective libraries, then setThemePath must be used to configure individual locations.
					/// </summary>
					/// <param name="sThemeName">the name of the theme to be loaded</param>
					public extern virtual void applyTheme(string sThemeName);

					/// <summary>
					/// Registers a listener for control events.
					/// </summary>
					/// <param name="fnFunction">callback to be called for each control event</param>
					/// <param name="oListener">optional context object to call the callback on.</param>
					public extern virtual void attachControlEvent(object fnFunction, object oListener);

					/// <summary>
					/// Registers a listener for control events.
					/// </summary>
					/// <param name="fnFunction">callback to be called for each control event</param>
					public extern virtual void attachControlEvent(object fnFunction);

					/// <summary>
					/// Registers a given function that is executed after the framework has been initialized.
					/// 
					/// The given function will either be called as soon as the framework has been initialized or, if it has been initialized already, it will be called immediately.
					/// </summary>
					/// <param name="fnFunction">Function to be after initialization of the framework</param>
					public extern virtual void attachInit(object fnFunction);

					/// <summary>
					/// Registers a given function that is executed after the framework has been initialized.
					/// 
					/// The method is executed only once and only if the framework has not been initialized already. This could be checked by calling {@link #isInitialized}, but in most cases it is more convenient to use {@link #attachInit} instead. This guarantees that the given function is executed exactly once, independent of the state of the framework.
					/// </summary>
					[Obsolete("Deprecated since 1.13.2. Register with the more convenient {@link #attachInit} function instead")]
					/// <param name="fnFunction">Function that is called after initialization of the framework</param>
					public extern virtual void attachInitEvent(object fnFunction);

					/// <summary>
					/// Registers a listener to the central interval timer.
					/// </summary>
					/// <param name="fnFunction">callback to be called periodically</param>
					/// <param name="oListener">optional context object to call the callback on.</param>
					public extern virtual void attachIntervalTimer(object fnFunction, object oListener);

					/// <summary>
					/// Registers a listener to the central interval timer.
					/// </summary>
					/// <param name="fnFunction">callback to be called periodically</param>
					public extern virtual void attachIntervalTimer(object fnFunction);

					/// <summary>
					/// Returns a list of all controls with a field group ID. See {@link sap.ui.core.Control#checkFieldGroupIds Control.prototype.checkFieldGroupIds} for a description of the <code>vFieldGroupIds</code> parameter.
					/// </summary>
					/// <param name="vFieldGroupIds">ID of the field group or an array of field group IDs to match</param>
					/// <returns>The list of controls with matching field group IDs</returns>
					public extern virtual sap.ui.core.Control[] byFieldGroupId(Union<string, string[]> vFieldGroupIds);

					/// <summary>
					/// Returns a list of all controls with a field group ID. See {@link sap.ui.core.Control#checkFieldGroupIds Control.prototype.checkFieldGroupIds} for a description of the <code>vFieldGroupIds</code> parameter.
					/// </summary>
					/// <returns>The list of controls with matching field group IDs</returns>
					public extern virtual sap.ui.core.Control[] byFieldGroupId();

					/// <summary>
					/// Returns the registered element for the given id, if any.
					/// </summary>
					/// <param name="sId"></param>
					/// <returns>the element for the given id</returns>
					public extern virtual sap.ui.core.Element byId(string sId);

					/// <summary>
					/// Creates a component with the provided id and settings.
					/// 
					/// When the optional parameter <code>sUrl</code> is given, then all request for resources of the library will be redirected to the given URL. This is convenience for a call to <pre>
					///   jQuery.sap.registerModulePath(sName, sUrl);
					/// </pre>
					/// </summary>
					/// <param name="vComponent">name of the component to import or object containing all needed parameters</param>
					/// <param name="sUrl">the URL to load the component from</param>
					/// <param name="sId">the ID for the component instance</param>
					/// <param name="mSettings">the settings object for the component</param>
					public extern virtual void createComponent(Union<string, sap.ui.core.Core.CreateComponentInfo> vComponent, string sUrl, string sId, object mSettings);

					/// <summary>
					/// Creates a component with the provided id and settings.
					/// 
					/// When the optional parameter <code>sUrl</code> is given, then all request for resources of the library will be redirected to the given URL. This is convenience for a call to <pre>
					///   jQuery.sap.registerModulePath(sName, sUrl);
					/// </pre>
					/// </summary>
					/// <param name="vComponent">name of the component to import or object containing all needed parameters</param>
					/// <param name="sUrl">the URL to load the component from</param>
					/// <param name="sId">the ID for the component instance</param>
					public extern virtual void createComponent(Union<string, sap.ui.core.Core.CreateComponentInfo> vComponent, string sUrl, string sId);

					/// <summary>
					/// Creates a component with the provided id and settings.
					/// 
					/// When the optional parameter <code>sUrl</code> is given, then all request for resources of the library will be redirected to the given URL. This is convenience for a call to <pre>
					///   jQuery.sap.registerModulePath(sName, sUrl);
					/// </pre>
					/// </summary>
					/// <param name="vComponent">name of the component to import or object containing all needed parameters</param>
					/// <param name="sUrl">the URL to load the component from</param>
					public extern virtual void createComponent(Union<string, sap.ui.core.Core.CreateComponentInfo> vComponent, string sUrl);

					/// <summary>
					/// Creates a component with the provided id and settings.
					/// 
					/// When the optional parameter <code>sUrl</code> is given, then all request for resources of the library will be redirected to the given URL. This is convenience for a call to <pre>
					///   jQuery.sap.registerModulePath(sName, sUrl);
					/// </pre>
					/// </summary>
					/// <param name="vComponent">name of the component to import or object containing all needed parameters</param>
					public extern virtual void createComponent(Union<string, sap.ui.core.Core.CreateComponentInfo> vComponent);

					/// <summary>
					/// Returns a new instance of the RenderManager for exclusive use by the caller.
					/// 
					/// The caller must take care to destroy the render manager when it is no longer needed. Calling this method before the Core has been {@link #isInitialized initialized}, is not recommended.
					/// </summary>
					/// <returns>New instance of the RenderManager</returns>
					public extern virtual sap.ui.core.RenderManager createRenderManager();

					/// <summary>
					/// Creates a new sap.ui.core.UIArea.
					/// </summary>
					[Obsolete("Deprecated since 1.1. use {@link sap.ui.core.Control#placeAt Control#placeAt} instead!")]
					/// <param name="oDomRef">a DOM Element or ID string of the UIArea</param>
					/// <returns>a new UIArea</returns>
					public extern virtual sap.ui.core.UIArea createUIArea(Union<string, dom.HTMLElement> oDomRef);

					/// <summary>
					/// Unregisters a listener for control events.
					/// 
					/// A listener will only be unregistered if the same function/context combination is given as in the attachControlEvent call.
					/// </summary>
					/// <param name="fnFunction">function to unregister</param>
					/// <param name="oListener">context object given during registration</param>
					public extern virtual void detachControlEvent(object fnFunction, object oListener);

					/// <summary>
					/// Unregisters a listener for control events.
					/// 
					/// A listener will only be unregistered if the same function/context combination is given as in the attachControlEvent call.
					/// </summary>
					/// <param name="fnFunction">function to unregister</param>
					public extern virtual void detachControlEvent(object fnFunction);

					/// <summary>
					/// Unregisters a listener for the central interval timer.
					/// 
					/// A listener will only be unregistered if the same function/context combination is given as in the attachIntervalTimer call.
					/// </summary>
					/// <param name="fnFunction">function to unregister</param>
					/// <param name="oListener">context object given during registration</param>
					public extern virtual void detachIntervalTimer(object fnFunction, object oListener);

					/// <summary>
					/// Unregisters a listener for the central interval timer.
					/// 
					/// A listener will only be unregistered if the same function/context combination is given as in the attachIntervalTimer call.
					/// </summary>
					/// <param name="fnFunction">function to unregister</param>
					public extern virtual void detachIntervalTimer(object fnFunction);

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.Core with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.Core with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.Core with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns the instance of the application (if exists).
					/// </summary>
					[Obsolete("Deprecated since 1.15.1. The Component class is enhanced to take care about the Application code.")]
					/// <returns>instance of the current application</returns>
					public extern virtual sap.ui.app.Application getApplication();

					/// <summary>
					/// Returns the registered component for the given id, if any.
					/// </summary>
					/// <param name="sId"></param>
					/// <returns>the component for the given id</returns>
					public extern virtual sap.ui.core.Component getComponent(string sId);

					/// <summary>
					/// Returns the Configuration of the Core.
					/// </summary>
					/// <returns>the Configuration of the current Core.</returns>
					public extern virtual sap.ui.core.Configuration getConfiguration();

					/// <summary>
					/// Returns the registered element for the given ID, if any.
					/// </summary>
					[Obsolete("Deprecated since 1.1. use <code>sap.ui.core.Core.byId</code> instead!")]
					/// <param name="sId"></param>
					/// <returns>the element for the given id</returns>
					public extern virtual sap.ui.core.Element getControl(string sId);

					/// <summary>
					/// Returns the Id of the control/element currently in focus.
					/// </summary>
					/// <returns>the Id of the control/element currently in focus.</returns>
					public extern virtual string getCurrentFocusedControlId();

					/// <summary>
					/// Returns the registered element for the given ID, if any.
					/// </summary>
					[Obsolete("Deprecated since 1.1. use <code>sap.ui.core.Core.byId</code> instead!")]
					/// <param name="sId"></param>
					/// <returns>the element for the given id</returns>
					public extern virtual sap.ui.core.Element getElementById(string sId);

					/// <summary>
					/// Returns the event bus.
					/// </summary>
					/// <returns>the event bus</returns>
					public extern virtual sap.ui.core.EventBus getEventBus();

					/// <summary>
					/// Retrieves a resource bundle for the given library and locale.
					/// 
					/// If only one argument is given, it is assumed to be the libraryName. The locale then falls back to the current {@link sap.ui.core.Configuration#getLanguage session locale}. If no argument is given, the library also falls back to a default: "sap.ui.core".
					/// 
					/// <h3>Configuration via App Descriptor<h3> When the App Descriptor for the library is available without further request (manifest.json has been preloaded) and when the App Descriptor is at least of version 1.9.0 or higher, then this method will evaluate the App Descriptor entry <code>"sap.ui5" / "library" / "i18n"</code>. <ul> <li>When the entry is <code>true</code>, a bundle with the default name "messagebundle.properties" will be loaded</li> <li>If it is a string, then that string will be used as name of the bundle</li> <li>If it is <code>false</code>, no bundle will be loaded and the result will be <code>undefined</code></li> </ul>
					/// 
					/// <h3>Caching</h3> Once a resource bundle for a library has been loaded, it will be cached by this method. Further calls for the same library and locale won't create new requests, but return the already loaded bundle. There's therefore no need for control code to cache the returned bundle for a longer period of time. Not further caching the result also prevents stale texts after a locale change.
					/// 
					/// <h3>Asynchronous Loading</h3> The asynchronous variant of {@link #loadLibrary} will evaluate the same descriptor entry as described above. If it is not <code>false</code>, loading the main resource bundle of the library will become a subtask of the asynchronous loading of the library.
					/// 
					/// Due to this preload of the main bundle and the caching behavior of this method, controls in such a library still can use the synchronous variant of <code>getLibraryResourceBundle</code> in their API, behavior and rendering code. Only when the bundle is needed at module execution time (by top level code in a control module), then the asynchronous variant of this method should be preferred.
					/// </summary>
					/// <param name="sLibraryName">Name of the library to retrieve the bundle for</param>
					/// <param name="sLocale">Locale to retrieve the resource bundle for</param>
					/// <param name="bAsync">Whether the resource bundle is loaded asynchronously</param>
					/// <returns>The best matching resource bundle for the given parameters or <code>undefined</code>; in asynchronous case a Promise on that bundle is returned</returns>
					public extern virtual Union<jQuery.sap.util.ResourceBundle, jquery.JQueryPromise<object>> getLibraryResourceBundle(string sLibraryName, string sLocale, bool bAsync);

					/// <summary>
					/// Retrieves a resource bundle for the given library and locale.
					/// 
					/// If only one argument is given, it is assumed to be the libraryName. The locale then falls back to the current {@link sap.ui.core.Configuration#getLanguage session locale}. If no argument is given, the library also falls back to a default: "sap.ui.core".
					/// 
					/// <h3>Configuration via App Descriptor<h3> When the App Descriptor for the library is available without further request (manifest.json has been preloaded) and when the App Descriptor is at least of version 1.9.0 or higher, then this method will evaluate the App Descriptor entry <code>"sap.ui5" / "library" / "i18n"</code>. <ul> <li>When the entry is <code>true</code>, a bundle with the default name "messagebundle.properties" will be loaded</li> <li>If it is a string, then that string will be used as name of the bundle</li> <li>If it is <code>false</code>, no bundle will be loaded and the result will be <code>undefined</code></li> </ul>
					/// 
					/// <h3>Caching</h3> Once a resource bundle for a library has been loaded, it will be cached by this method. Further calls for the same library and locale won't create new requests, but return the already loaded bundle. There's therefore no need for control code to cache the returned bundle for a longer period of time. Not further caching the result also prevents stale texts after a locale change.
					/// 
					/// <h3>Asynchronous Loading</h3> The asynchronous variant of {@link #loadLibrary} will evaluate the same descriptor entry as described above. If it is not <code>false</code>, loading the main resource bundle of the library will become a subtask of the asynchronous loading of the library.
					/// 
					/// Due to this preload of the main bundle and the caching behavior of this method, controls in such a library still can use the synchronous variant of <code>getLibraryResourceBundle</code> in their API, behavior and rendering code. Only when the bundle is needed at module execution time (by top level code in a control module), then the asynchronous variant of this method should be preferred.
					/// </summary>
					/// <param name="sLibraryName">Name of the library to retrieve the bundle for</param>
					/// <param name="sLocale">Locale to retrieve the resource bundle for</param>
					/// <returns>The best matching resource bundle for the given parameters or <code>undefined</code>; in asynchronous case a Promise on that bundle is returned</returns>
					public extern virtual Union<jQuery.sap.util.ResourceBundle, jquery.JQueryPromise<object>> getLibraryResourceBundle(string sLibraryName, string sLocale);

					/// <summary>
					/// Retrieves a resource bundle for the given library and locale.
					/// 
					/// If only one argument is given, it is assumed to be the libraryName. The locale then falls back to the current {@link sap.ui.core.Configuration#getLanguage session locale}. If no argument is given, the library also falls back to a default: "sap.ui.core".
					/// 
					/// <h3>Configuration via App Descriptor<h3> When the App Descriptor for the library is available without further request (manifest.json has been preloaded) and when the App Descriptor is at least of version 1.9.0 or higher, then this method will evaluate the App Descriptor entry <code>"sap.ui5" / "library" / "i18n"</code>. <ul> <li>When the entry is <code>true</code>, a bundle with the default name "messagebundle.properties" will be loaded</li> <li>If it is a string, then that string will be used as name of the bundle</li> <li>If it is <code>false</code>, no bundle will be loaded and the result will be <code>undefined</code></li> </ul>
					/// 
					/// <h3>Caching</h3> Once a resource bundle for a library has been loaded, it will be cached by this method. Further calls for the same library and locale won't create new requests, but return the already loaded bundle. There's therefore no need for control code to cache the returned bundle for a longer period of time. Not further caching the result also prevents stale texts after a locale change.
					/// 
					/// <h3>Asynchronous Loading</h3> The asynchronous variant of {@link #loadLibrary} will evaluate the same descriptor entry as described above. If it is not <code>false</code>, loading the main resource bundle of the library will become a subtask of the asynchronous loading of the library.
					/// 
					/// Due to this preload of the main bundle and the caching behavior of this method, controls in such a library still can use the synchronous variant of <code>getLibraryResourceBundle</code> in their API, behavior and rendering code. Only when the bundle is needed at module execution time (by top level code in a control module), then the asynchronous variant of this method should be preferred.
					/// </summary>
					/// <param name="sLibraryName">Name of the library to retrieve the bundle for</param>
					/// <returns>The best matching resource bundle for the given parameters or <code>undefined</code>; in asynchronous case a Promise on that bundle is returned</returns>
					public extern virtual Union<jQuery.sap.util.ResourceBundle, jquery.JQueryPromise<object>> getLibraryResourceBundle(string sLibraryName = "sap.ui.core");

					/// <summary>
					/// Retrieves a resource bundle for the given library and locale.
					/// 
					/// If only one argument is given, it is assumed to be the libraryName. The locale then falls back to the current {@link sap.ui.core.Configuration#getLanguage session locale}. If no argument is given, the library also falls back to a default: "sap.ui.core".
					/// 
					/// <h3>Configuration via App Descriptor<h3> When the App Descriptor for the library is available without further request (manifest.json has been preloaded) and when the App Descriptor is at least of version 1.9.0 or higher, then this method will evaluate the App Descriptor entry <code>"sap.ui5" / "library" / "i18n"</code>. <ul> <li>When the entry is <code>true</code>, a bundle with the default name "messagebundle.properties" will be loaded</li> <li>If it is a string, then that string will be used as name of the bundle</li> <li>If it is <code>false</code>, no bundle will be loaded and the result will be <code>undefined</code></li> </ul>
					/// 
					/// <h3>Caching</h3> Once a resource bundle for a library has been loaded, it will be cached by this method. Further calls for the same library and locale won't create new requests, but return the already loaded bundle. There's therefore no need for control code to cache the returned bundle for a longer period of time. Not further caching the result also prevents stale texts after a locale change.
					/// 
					/// <h3>Asynchronous Loading</h3> The asynchronous variant of {@link #loadLibrary} will evaluate the same descriptor entry as described above. If it is not <code>false</code>, loading the main resource bundle of the library will become a subtask of the asynchronous loading of the library.
					/// 
					/// Due to this preload of the main bundle and the caching behavior of this method, controls in such a library still can use the synchronous variant of <code>getLibraryResourceBundle</code> in their API, behavior and rendering code. Only when the bundle is needed at module execution time (by top level code in a control module), then the asynchronous variant of this method should be preferred.
					/// </summary>
					/// <returns>The best matching resource bundle for the given parameters or <code>undefined</code>; in asynchronous case a Promise on that bundle is returned</returns>
					public extern virtual Union<jQuery.sap.util.ResourceBundle, jquery.JQueryPromise<object>> getLibraryResourceBundle();

					/// <summary>
					/// Retrieves a resource bundle for the given library and locale.
					/// 
					/// If only one argument is given, it is assumed to be the libraryName. The locale then falls back to the current {@link sap.ui.core.Configuration#getLanguage session locale}. If no argument is given, the library also falls back to a default: "sap.ui.core".
					/// 
					/// <h3>Configuration via App Descriptor<h3> When the App Descriptor for the library is available without further request (manifest.json has been preloaded) and when the App Descriptor is at least of version 1.9.0 or higher, then this method will evaluate the App Descriptor entry <code>"sap.ui5" / "library" / "i18n"</code>. <ul> <li>When the entry is <code>true</code>, a bundle with the default name "messagebundle.properties" will be loaded</li> <li>If it is a string, then that string will be used as name of the bundle</li> <li>If it is <code>false</code>, no bundle will be loaded and the result will be <code>undefined</code></li> </ul>
					/// 
					/// <h3>Caching</h3> Once a resource bundle for a library has been loaded, it will be cached by this method. Further calls for the same library and locale won't create new requests, but return the already loaded bundle. There's therefore no need for control code to cache the returned bundle for a longer period of time. Not further caching the result also prevents stale texts after a locale change.
					/// 
					/// <h3>Asynchronous Loading</h3> The asynchronous variant of {@link #loadLibrary} will evaluate the same descriptor entry as described above. If it is not <code>false</code>, loading the main resource bundle of the library will become a subtask of the asynchronous loading of the library.
					/// 
					/// Due to this preload of the main bundle and the caching behavior of this method, controls in such a library still can use the synchronous variant of <code>getLibraryResourceBundle</code> in their API, behavior and rendering code. Only when the bundle is needed at module execution time (by top level code in a control module), then the asynchronous variant of this method should be preferred.
					/// </summary>
					/// <param name="sLocale">Locale to retrieve the resource bundle for</param>
					/// <param name="bAsync">Whether the resource bundle is loaded asynchronously</param>
					/// <returns>The best matching resource bundle for the given parameters or <code>undefined</code>; in asynchronous case a Promise on that bundle is returned</returns>
					public extern virtual Union<jQuery.sap.util.ResourceBundle, jquery.JQueryPromise<object>> getLibraryResourceBundle(string sLocale, bool bAsync = false);

					/// <summary>
					/// Retrieves a resource bundle for the given library and locale.
					/// 
					/// If only one argument is given, it is assumed to be the libraryName. The locale then falls back to the current {@link sap.ui.core.Configuration#getLanguage session locale}. If no argument is given, the library also falls back to a default: "sap.ui.core".
					/// 
					/// <h3>Configuration via App Descriptor<h3> When the App Descriptor for the library is available without further request (manifest.json has been preloaded) and when the App Descriptor is at least of version 1.9.0 or higher, then this method will evaluate the App Descriptor entry <code>"sap.ui5" / "library" / "i18n"</code>. <ul> <li>When the entry is <code>true</code>, a bundle with the default name "messagebundle.properties" will be loaded</li> <li>If it is a string, then that string will be used as name of the bundle</li> <li>If it is <code>false</code>, no bundle will be loaded and the result will be <code>undefined</code></li> </ul>
					/// 
					/// <h3>Caching</h3> Once a resource bundle for a library has been loaded, it will be cached by this method. Further calls for the same library and locale won't create new requests, but return the already loaded bundle. There's therefore no need for control code to cache the returned bundle for a longer period of time. Not further caching the result also prevents stale texts after a locale change.
					/// 
					/// <h3>Asynchronous Loading</h3> The asynchronous variant of {@link #loadLibrary} will evaluate the same descriptor entry as described above. If it is not <code>false</code>, loading the main resource bundle of the library will become a subtask of the asynchronous loading of the library.
					/// 
					/// Due to this preload of the main bundle and the caching behavior of this method, controls in such a library still can use the synchronous variant of <code>getLibraryResourceBundle</code> in their API, behavior and rendering code. Only when the bundle is needed at module execution time (by top level code in a control module), then the asynchronous variant of this method should be preferred.
					/// </summary>
					/// <param name="bAsync">Whether the resource bundle is loaded asynchronously</param>
					/// <returns>The best matching resource bundle for the given parameters or <code>undefined</code>; in asynchronous case a Promise on that bundle is returned</returns>
					public extern virtual Union<jQuery.sap.util.ResourceBundle, jquery.JQueryPromise<object>> getLibraryResourceBundle(bool bAsync = false);

					/// <summary>
					/// Returns a map of library info objects for all currently loaded libraries, keyed by their names.
					/// 
					/// The structure of the library info objects matches the structure of the info object that the {@link #initLibrary} method expects. Only property names documented with <code>initLibrary</code> should be accessed, any additional properties might change or disappear in future. When a property does not exists, its default value (as documented with <code>initLibrary</code>) should be assumed.
					/// 
					/// <b>Note:</b> The returned info objects must not be modified. They might be a living copy of the internal data (for efficiency reasons) and the framework is not prepared to handle modifications to these objects.
					/// </summary>
					/// <returns>Map of library info objects keyed by the library names.</returns>
					public extern virtual Map getLoadedLibraries();

					/// <summary>
					/// Returns the active <code>MessageManager</code> instance.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.message.MessageManager getMessageManager();

					/// <summary>
					/// Returns a metadata object for class sap.ui.core.Core.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					/// <summary>
					/// Get the model with the given model name.
					/// 
					/// The name can be omitted to reference the default model or it must be a non-empty string.
					/// 
					/// Note: to be compatible with future versions of this API, applications must not use the value <code>null</code>, the empty string <code>""</code> or the string literals <code>"null"</code> or <code>"undefined"</code> as model name.
					/// </summary>
					/// <param name="sName">name of the model to be retrieved</param>
					/// <returns>oModel</returns>
					public extern virtual sap.ui.model.Model getModel(string sName);

					/// <summary>
					/// Get the model with the given model name.
					/// 
					/// The name can be omitted to reference the default model or it must be a non-empty string.
					/// 
					/// Note: to be compatible with future versions of this API, applications must not use the value <code>null</code>, the empty string <code>""</code> or the string literals <code>"null"</code> or <code>"undefined"</code> as model name.
					/// </summary>
					/// <returns>oModel</returns>
					public extern virtual sap.ui.model.Model getModel();

					[Obsolete("Deprecated since 0.15.0. Replaced by <code>createRenderManager()</code>")]
					public extern virtual void getRenderManager();

					/// <summary>
					/// Returns the instance of the root component (if exists).
					/// </summary>
					/// <returns>instance of the current root component</returns>
					public extern virtual sap.ui.core.Component getRootComponent();

					/// <summary>
					/// Returns the static, hidden area DOM element belonging to this core instance.
					/// 
					/// It can be used e.g. for hiding elements like Popups, Shadow, Blocklayer etc.
					/// 
					/// If it is not yet available, a DIV is created and appended to the body.
					/// </summary>
					/// <returns>the static, hidden area DOM element belonging to this core instance.</returns>
					public extern virtual dom.HTMLElement getStaticAreaRef();

					/// <summary>
					/// Returns the registered template for the given id, if any.
					/// </summary>
					[Obsolete("Deprecated since 1.29.1. Require 'sap/ui/core/tmpl/Template' and use {@link sap.ui.core.tmpl.Template.byId Template.byId} instead.")]
					/// <param name="sId"></param>
					/// <returns>the template for the given id</returns>
					public extern virtual sap.ui.core.Component getTemplate(string sId);

					/// <summary>
					/// Returns a UIArea if the given ID/Element belongs to one.
					/// </summary>
					/// <param name="o">a DOM Element or ID string of the UIArea</param>
					/// <returns>a UIArea with a given ID or DOM Element.</returns>
					public extern virtual sap.ui.core.UIArea getUIArea(Union<string, dom.HTMLElement> o);

					/// <summary>
					/// Returns <code>true</code> if there are any pending rendering tasks or when such rendering tasks are currently being executed.
					/// </summary>
					/// <returns>true if there are pending (or executing) rendering tasks.</returns>
					public extern virtual bool getUIDirty();

					/// <summary>
					/// Check if a Model is set to the core
					/// </summary>
					/// <returns>true or false</returns>
					public extern virtual bool hasModel();

					/// <summary>
					/// Includes a library theme into the current page (if a variant is specified it will include the variant library theme)
					/// </summary>
					/// <param name="sLibName">the name of the UI library</param>
					/// <param name="sVariant">the variant to include (optional)</param>
					/// <param name="sQuery">to be used only by the Core</param>
					public extern virtual void includeLibraryTheme(string sLibName, string sVariant, string sQuery);

					/// <summary>
					/// Includes a library theme into the current page (if a variant is specified it will include the variant library theme)
					/// </summary>
					/// <param name="sLibName">the name of the UI library</param>
					/// <param name="sVariant">the variant to include (optional)</param>
					public extern virtual void includeLibraryTheme(string sLibName, string sVariant);

					/// <summary>
					/// Includes a library theme into the current page (if a variant is specified it will include the variant library theme)
					/// </summary>
					/// <param name="sLibName">the name of the UI library</param>
					public extern virtual void includeLibraryTheme(string sLibName);

					/// <summary>
					/// Provides the framework with information about a library.
					/// 
					/// This method is intended to be called exactly once while the main module of a library (its <code>library.js</code> module) is executing, typically at its begin. The single parameter <code>oLibInfo</code> is an info object that describes the content of the library.
					/// 
					/// When the <code>oLibInfo</code> has been processed, a normalized version of it will be kept and will be returned as library information in later calls to {@link #getLoadedLibraries}. Finally, <code>initLibrary</code> fires (the currently private) {@link #event:LibraryChanged} event with operation 'add' for the newly loaded library.
					/// 
					/// <h3>Side Effects</h3>
					/// 
					/// While analyzing the <code>oLibInfo</code>, the framework takes some additional actions:
					/// 
					/// <ul> <li>If the info object contains a list of <code>interfaces</code>, they will be registered with the {@link sap.ui.base.DataType} class to make them available as aggregation types in managed objects.</li>
					/// 
					/// <li>If the object contains a list of <code>controls</code> or <code>elements</code>, {@link sap.ui.lazyRequire lazy stubs} will be created for their constructor as well as for their static <code>extend</code> and <code>getMetadata</code> methods.<br> <b>Note:</b> Future versions might abandon the concept of lazy stubs as it requires synchronous XMLHttpRequests which have been deprecated (see {@link http://xhr.spec.whatwg.org}). To be on the safe side, productive applications should always require any modules that they directly depend on.</li>
					/// 
					/// <li>With the <code>noLibraryCSS</code> property, the library can be marked as 'theming-free'. Otherwise, the framework will add a &lt;link&gt; tag to the page's head, pointing to the library's theme-specific stylesheet. The creation of such a &lt;link&gt; tag can be suppressed with the {@link sap.ui.core.Configuration global configuration option} <code>preloadLibCss</code>. It can contain a list of library names for which no stylesheet should be included. This is e.g. useful when an application merges the CSS for multiple libraries and already loaded the resulting stylesheet.</li>
					/// 
					/// <li>If a list of library <code>dependencies</code> is specified in the info object, those libraries will be loaded synchronously by <code>initLibrary</code>.<br> <b>Note:</b> Dependencies between libraries don't have to be modeled as AMD dependencies. Only when enums or types from an additional library are used in the coding of the <code>library.js</code> module, the library should be additionally listed in the AMD dependencies.</li> </ul>
					/// 
					/// Last but not least, higher layer frameworks might want to include their own metadata for libraries. The property <code>extensions</code> might contain such additional metadata. Its structure is not defined by the framework, but it is strongly suggested that each extension only occupies a single property in the <code>extensions</code> object and that the name of that property contains some namespace information (e.g. library name that introduces the feature) to avoid conflicts with other extensions. The framework won't touch the content of <code>extensions</code> but will make it available in the library info objects returned by {@link #getLoadedLibraries}.
					/// 
					/// <h3>Relationship to Descriptor for Libraries (manifest.json)</h3>
					/// 
					/// The information contained in <code>oLibInfo</code> is partially redundant to the content of the descriptor for the same library (its <code>manifest.json</code> file). Future versions of UI5 might ignore the information provided in <code>oLibInfo</code> and might evaluate the descriptor file instead. Library developers therefore should keep the information in both files in sync.
					/// 
					/// When the <code>manifest.json</code> is generated from the <code>.library</code> file (which is the default for UI5 libraries built with Maven), then the content of the <code>.library</code> and <code>library.js</code> files must be kept in sync.
					/// </summary>
					/// <param name="oLibInfo">Info object for the library</param>
					public extern virtual void initLibrary(sap.ui.core.Core.InitLibraryInfo oLibInfo);

					/// <summary>
					/// Returns true if the Core has already been initialized. This means that instances of RenderManager etc. do already exist and the init event has already been fired (and will not be fired again).
					/// </summary>
					/// <returns>whether the Core has already been initialized</returns>
					public extern virtual bool isInitialized();

					/// <summary>
					/// Returns the locked state of the <code>sap.ui.core.Core</code>
					/// </summary>
					/// <returns>locked state</returns>
					public extern virtual bool isLocked();

					/// <summary>
					/// Check if the script is running on mobile
					/// </summary>
					/// <returns>true or false</returns>
					public extern virtual bool isMobile();

					/// <summary>
					/// Used to find out whether a certain DOM element is the static area
					/// </summary>
					/// <param name="oDomRef"></param>
					/// <returns>whether the given DomRef is the StaticAreaRef</returns>
					public extern virtual bool isStaticAreaRef(object oDomRef);

					/// <summary>
					/// Returns true, if the styles of the current theme are already applied, false otherwise.
					/// 
					/// This function must not be used before the init event of the Core. If the styles are not yet applied a theme changed event will follow when the styles will be applied.
					/// </summary>
					/// <returns>whether the styles of the current theme are already applied</returns>
					public extern virtual bool isThemeApplied();

					/// <summary>
					/// Loads a set of libraries, preferably asynchronously.
					/// 
					/// The module loading is still synchronous, so if a library loads additional modules besides its library.js file, those modules might be loaded synchronously by the library.js The async loading is only supported by the means of the library-preload.js(on) files, so if a library doesn't provide a preload or when the preload is deactivated (configuration, debug mode) then this API falls back to synchronous loading. However, the contract (Promise) remains valid and a Promise will be returned if async is specified - even when the real loading is done synchronously.
					/// </summary>
					/// <param name="aLibraries">set of libraries that should be loaded</param>
					/// <param name="mOptions">configuration options</param>
					/// <returns>returns a Promise in async mode, otherwise <code>undefined</code></returns>
					private extern jquery.JQueryPromise<object> loadLibraries(string[] aLibraries, object mOptions);

					/// <summary>
					/// Loads a set of libraries, preferably asynchronously.
					/// 
					/// The module loading is still synchronous, so if a library loads additional modules besides its library.js file, those modules might be loaded synchronously by the library.js The async loading is only supported by the means of the library-preload.js(on) files, so if a library doesn't provide a preload or when the preload is deactivated (configuration, debug mode) then this API falls back to synchronous loading. However, the contract (Promise) remains valid and a Promise will be returned if async is specified - even when the real loading is done synchronously.
					/// </summary>
					/// <param name="aLibraries">set of libraries that should be loaded</param>
					/// <param name="mOptions">configuration options</param>
					/// <returns>returns a Promise in async mode, otherwise <code>undefined</code></returns>
					private extern jquery.JQueryPromise<object> loadLibraries(object[] aLibraries, object mOptions);

					/// <summary>
					/// Loads a set of libraries, preferably asynchronously.
					/// 
					/// The module loading is still synchronous, so if a library loads additional modules besides its library.js file, those modules might be loaded synchronously by the library.js The async loading is only supported by the means of the library-preload.js(on) files, so if a library doesn't provide a preload or when the preload is deactivated (configuration, debug mode) then this API falls back to synchronous loading. However, the contract (Promise) remains valid and a Promise will be returned if async is specified - even when the real loading is done synchronously.
					/// </summary>
					/// <param name="aLibraries">set of libraries that should be loaded</param>
					/// <returns>returns a Promise in async mode, otherwise <code>undefined</code></returns>
					private extern jquery.JQueryPromise<object> loadLibraries(string[] aLibraries);

					/// <summary>
					/// Loads a set of libraries, preferably asynchronously.
					/// 
					/// The module loading is still synchronous, so if a library loads additional modules besides its library.js file, those modules might be loaded synchronously by the library.js The async loading is only supported by the means of the library-preload.js(on) files, so if a library doesn't provide a preload or when the preload is deactivated (configuration, debug mode) then this API falls back to synchronous loading. However, the contract (Promise) remains valid and a Promise will be returned if async is specified - even when the real loading is done synchronously.
					/// </summary>
					/// <param name="aLibraries">set of libraries that should be loaded</param>
					/// <returns>returns a Promise in async mode, otherwise <code>undefined</code></returns>
					private extern jquery.JQueryPromise<object> loadLibraries(object[] aLibraries);

					/// <summary>
					/// Loads the given library and its dependencies and makes it available to the application.
					/// 
					/// When library preloads are not suppressed for the given library, then a library-preload bundle will be loaded for it. By default, the bundle will be loaded synchronously (for compatibility reasons). Only when the optional parameter <code>vUrl</code> is given as <code>true</code> or as a configuration object with a property of <code>async:true</code>, then the bundle will be loaded asynchronously and a <code>Promise</code> will be returned (preferred usage).
					/// 
					/// After preloading the bundle, dependency information from the bundle is evaluated and any missing libraries are also preloaded.
					/// 
					/// Only then the library entry module (named <code><i>your/lib</i>/library.js</code>) will be required and executed. The module is supposed to call <code>sap.ui.getCore().initLibrary(...)</code> providing the framework with additional metadata about the library, e.g. its version, the set of contained enums, types, interfaces, controls and elements and whether the library requires CSS. If the library requires CSS, a &lt;link&gt; will be added to the page referring to the corresponding <code>library.css</code> stylesheet for the library and the current theme.
					/// 
					/// When the optional parameter <code>vUrl</code> is given as a string or when a configuration object is given with a non-empty, string-valued property <code>url</code>, then that URL will be registered for the namespace of the library and all resources will be loaded from that location. This is convenience for a call like <pre>
					///   jQuery.sap.registerModulePath(sLibrary, vUrl); // or vUrl.url resp.
					/// </pre>
					/// 
					/// When the given library has been loaded already, no further action will be taken, especially, a given URL will not be registered! In the case of asynchronous loading, a Promise will be returned, but will be resolved immediately.
					/// </summary>
					/// <param name="sLibrary">name of the library to load</param>
					/// <param name="vUrl">URL to load the library from or the async flag or a complex configuration object</param>
					/// <returns>An info object for the library (sync) or a Promise (async)</returns>
					public extern virtual Union<object, jquery.JQueryPromise<object>> loadLibrary(string sLibrary, Union<string, bool, sap.ui.core.Core.LoadLibraryInfo> vUrl);

					/// <summary>
					/// Loads the given library and its dependencies and makes it available to the application.
					/// 
					/// When library preloads are not suppressed for the given library, then a library-preload bundle will be loaded for it. By default, the bundle will be loaded synchronously (for compatibility reasons). Only when the optional parameter <code>vUrl</code> is given as <code>true</code> or as a configuration object with a property of <code>async:true</code>, then the bundle will be loaded asynchronously and a <code>Promise</code> will be returned (preferred usage).
					/// 
					/// After preloading the bundle, dependency information from the bundle is evaluated and any missing libraries are also preloaded.
					/// 
					/// Only then the library entry module (named <code><i>your/lib</i>/library.js</code>) will be required and executed. The module is supposed to call <code>sap.ui.getCore().initLibrary(...)</code> providing the framework with additional metadata about the library, e.g. its version, the set of contained enums, types, interfaces, controls and elements and whether the library requires CSS. If the library requires CSS, a &lt;link&gt; will be added to the page referring to the corresponding <code>library.css</code> stylesheet for the library and the current theme.
					/// 
					/// When the optional parameter <code>vUrl</code> is given as a string or when a configuration object is given with a non-empty, string-valued property <code>url</code>, then that URL will be registered for the namespace of the library and all resources will be loaded from that location. This is convenience for a call like <pre>
					///   jQuery.sap.registerModulePath(sLibrary, vUrl); // or vUrl.url resp.
					/// </pre>
					/// 
					/// When the given library has been loaded already, no further action will be taken, especially, a given URL will not be registered! In the case of asynchronous loading, a Promise will be returned, but will be resolved immediately.
					/// </summary>
					/// <param name="sLibrary">name of the library to load</param>
					/// <returns>An info object for the library (sync) or a Promise (async)</returns>
					public extern virtual Union<object, jquery.JQueryPromise<object>> loadLibrary(string sLibrary);

					/// <summary>
					/// Locks the Core. No browser events are dispatched to the controls.
					/// 
					/// Lock should be called before and after the DOM is modified for rendering, roundtrips... Exceptions might be the case for asynchronous UI behavior
					/// </summary>
					public extern virtual void @lock();

					/// <summary>
					/// This method can be called to trigger realignment of controls after changing the cozy/compact CSS class of a DOM element, for example, the <code>&lt;body&gt;</code> tag.
					/// </summary>
					public extern virtual void notifyContentDensityChanged();

					/// <summary>
					/// Registers a Plugin to the <code>sap.ui.core.Core</code>, which lifecycle will be managed (start and stop).
					/// 
					/// Plugin object need to implement two methods: <ul> <li><code>startPlugin(oCore)</code>: will be invoked, when the Plugin should start (as parameter the reference to the Core will be provided</li> <li><code>stopPlugin()</code>: will be invoked, when the Plugin should stop</li> </ul>
					/// </summary>
					/// <param name="oPlugin">reference to a Plugin object</param>
					public extern virtual void registerPlugin(object oPlugin);

					/// <summary>
					/// Sets or unsets a model for the given model name.
					/// 
					/// The <code>sName</code> must either be <code>undefined</code> (or omitted) or a non-empty string. When the name is omitted, the default model is set/unset.
					/// 
					/// When <code>oModel</code> is <code>null</code> or <code>undefined</code>, a previously set model with that name is removed from the Core.
					/// 
					/// Any change (new model, removed model) is propagated to all existing UIAreas and their descendants as long as a descendant doesn't have its own model set for the given name.
					/// 
					/// Note: to be compatible with future versions of this API, applications must not use the value <code>null</code>, the empty string <code>""</code> or the string literals <code>"null"</code> or <code>"undefined"</code> as model name.
					/// </summary>
					/// <param name="oModel">the model to be set or <code>null</code> or <code>undefined</code></param>
					/// <param name="sName">the name of the model or <code>undefined</code></param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.Core setModel(sap.ui.model.Model oModel, string sName);

					/// <summary>
					/// Sets or unsets a model for the given model name.
					/// 
					/// The <code>sName</code> must either be <code>undefined</code> (or omitted) or a non-empty string. When the name is omitted, the default model is set/unset.
					/// 
					/// When <code>oModel</code> is <code>null</code> or <code>undefined</code>, a previously set model with that name is removed from the Core.
					/// 
					/// Any change (new model, removed model) is propagated to all existing UIAreas and their descendants as long as a descendant doesn't have its own model set for the given name.
					/// 
					/// Note: to be compatible with future versions of this API, applications must not use the value <code>null</code>, the empty string <code>""</code> or the string literals <code>"null"</code> or <code>"undefined"</code> as model name.
					/// </summary>
					/// <param name="oModel">the model to be set or <code>null</code> or <code>undefined</code></param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.core.Core setModel(sap.ui.model.Model oModel);

					/// <summary>
					/// Implicitly creates a new <code>UIArea</code> (or reuses an exiting one) for the given DOM reference and adds the given control reference to the UIAreas content (existing content will be removed).
					/// </summary>
					[Obsolete("Deprecated since 1.1. use {@link sap.ui.core.Control#placeAt oControl.placeAt(oDomRef, 'only')} instead.")]
					/// <param name="oDomRef">a DOM Element or Id (string) of the UIArea</param>
					/// <param name="oControl">the Control that should be the added to the <code>UIArea</code>.</param>
					public extern virtual void setRoot(Union<string, dom.HTMLElement> oDomRef, Union<sap.ui.@base.Interface, sap.ui.core.Control> oControl);

					/// <summary>
					/// Defines the root directory from below which UI5 should load the theme with the given name. Optionally allows restricting the setting to parts of a theme covering specific control libraries.
					/// 
					/// Example: <pre>
					///   sap.ui.getCore().setThemeRoot("my_theme", "https://mythemeserver.com/allThemes");
					///   sap.ui.getCore().applyTheme("my_theme");
					/// </pre>
					/// 
					/// will cause the following file to be loaded (assuming that the bootstrap is configured to load libraries <code>sap.m</code> and <code>sap.ui.layout</code>): <pre>
					///   https://mythemeserver.com/allThemes/sap/ui/core/themes/my_theme/library.css
					///   https://mythemeserver.com/allThemes/sap/ui/layout/themes/my_theme/library.css
					///   https://mythemeserver.com/allThemes/sap/m/themes/my_theme/library.css
					/// </pre>
					/// 
					/// If parts of the theme are at different locations (e.g. because you provide a standard theme like "sap_belize" for a custom control library and this self-made part of the standard theme is at a different location than the UI5 resources), you can also specify for which control libraries the setting should be used, by giving an array with the names of the respective control libraries as second parameter: <pre>
					///   sap.ui.getCore().setThemeRoot("sap_belize", ["my.own.library"], "https://mythemeserver.com/allThemes");
					/// </pre>
					/// 
					/// This will cause the Belize theme to be loaded from the UI5 location for all standard libraries. Resources for styling the <code>my.own.library</code> controls will be loaded from the configured location: <pre>
					///   https://openui5.hana.ondemand.com/resources/sap/ui/core/themes/sap_belize/library.css
					///   https://openui5.hana.ondemand.com/resources/sap/ui/layout/themes/sap_belize/library.css
					///   https://openui5.hana.ondemand.com/resources/sap/m/themes/sap_belize/library.css
					///   https://mythemeserver.com/allThemes/my/own/library/themes/sap_belize/library.css
					/// </pre>
					/// 
					/// If the custom theme should be loaded initially (via bootstrap attribute), the <code>themeRoots</code> property of the <code>window["sap-ui-config"]</code> object must be used instead of calling <code>sap.ui.getCore().setThemeRoot(...)</code> in order to configure the theme location early enough.
					/// </summary>
					/// <param name="sThemeName">Name of the theme for which to configure the location</param>
					/// <param name="aLibraryNames">Optional library names to which the configuration should be restricted</param>
					/// <param name="sThemeBaseUrl">Base URL below which the CSS file(s) will be loaded from</param>
					/// <returns>the Core, to allow method chaining</returns>
					public extern virtual sap.ui.core.Core setThemeRoot(string sThemeName, string[] aLibraryNames, string sThemeBaseUrl);

					/// <summary>
					/// Defines the root directory from below which UI5 should load the theme with the given name. Optionally allows restricting the setting to parts of a theme covering specific control libraries.
					/// 
					/// Example: <pre>
					///   sap.ui.getCore().setThemeRoot("my_theme", "https://mythemeserver.com/allThemes");
					///   sap.ui.getCore().applyTheme("my_theme");
					/// </pre>
					/// 
					/// will cause the following file to be loaded (assuming that the bootstrap is configured to load libraries <code>sap.m</code> and <code>sap.ui.layout</code>): <pre>
					///   https://mythemeserver.com/allThemes/sap/ui/core/themes/my_theme/library.css
					///   https://mythemeserver.com/allThemes/sap/ui/layout/themes/my_theme/library.css
					///   https://mythemeserver.com/allThemes/sap/m/themes/my_theme/library.css
					/// </pre>
					/// 
					/// If parts of the theme are at different locations (e.g. because you provide a standard theme like "sap_belize" for a custom control library and this self-made part of the standard theme is at a different location than the UI5 resources), you can also specify for which control libraries the setting should be used, by giving an array with the names of the respective control libraries as second parameter: <pre>
					///   sap.ui.getCore().setThemeRoot("sap_belize", ["my.own.library"], "https://mythemeserver.com/allThemes");
					/// </pre>
					/// 
					/// This will cause the Belize theme to be loaded from the UI5 location for all standard libraries. Resources for styling the <code>my.own.library</code> controls will be loaded from the configured location: <pre>
					///   https://openui5.hana.ondemand.com/resources/sap/ui/core/themes/sap_belize/library.css
					///   https://openui5.hana.ondemand.com/resources/sap/ui/layout/themes/sap_belize/library.css
					///   https://openui5.hana.ondemand.com/resources/sap/m/themes/sap_belize/library.css
					///   https://mythemeserver.com/allThemes/my/own/library/themes/sap_belize/library.css
					/// </pre>
					/// 
					/// If the custom theme should be loaded initially (via bootstrap attribute), the <code>themeRoots</code> property of the <code>window["sap-ui-config"]</code> object must be used instead of calling <code>sap.ui.getCore().setThemeRoot(...)</code> in order to configure the theme location early enough.
					/// </summary>
					/// <param name="sThemeName">Name of the theme for which to configure the location</param>
					/// <param name="aLibraryNames">Optional library names to which the configuration should be restricted</param>
					/// <param name="sThemeBaseUrl">Base URL below which the CSS file(s) will be loaded from</param>
					/// <returns>the Core, to allow method chaining</returns>
					public extern virtual sap.ui.core.Core setThemeRoot(string sThemeName, object[] aLibraryNames, string sThemeBaseUrl);

					/// <summary>
					/// Unlocks the Core.
					/// 
					/// Browser events are dispatched to the controls again after this method is called.
					/// </summary>
					public extern virtual void unlock();

					/// <summary>
					/// Unregisters a Plugin out of the <code>sap.ui.core.Core</code>
					/// </summary>
					/// <param name="oPlugin">reference to a Plugin object</param>
					public extern virtual void unregisterPlugin(object oPlugin);

					#endregion

					#endregion

				}
			}
		}
	}
}
