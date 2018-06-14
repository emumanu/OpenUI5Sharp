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
				public static partial class mvc
				{
					/// <summary>
					/// A View defined using (P)XML and HTML markup.
					/// 
					/// <strong>Note:</strong><br> Be aware that modifications of the content aggregation of this control are not supported due to technical reasons. This includes calls to all content modifying methods like <code>addContent></code> etc., but also the implicit removal of controls contained by the content aggregation. For example the destruction of a Control via the <code> destroy</code> method. All functions can be called but may not work properly or lead to unexpected side effects.
					/// 
					/// <strong>Note:</strong><br> On root level, you can only define content for the default aggregation, e.g. without adding the <code>&lt;content&gt;</code> tag. If you want to specify content for another aggregation of a view like <code>dependents</code>, place it in a child control's dependents aggregation or add it by using {@link sap.ui.core.mvc.XMLView#addDependent}.
					/// </summary>
					[External]
					[Namespace(false)]
					public partial class XMLView : sap.ui.core.mvc.View
					{
						#region Settings

						/// <summary>
						/// Settings class to create the object
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class Settings : sap.ui.core.mvc.View.Settings
						{
							/// <summary>
							/// Configuration for the XMLView caching.
							/// </summary>
							public Union<object, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> cache;

						}

						#endregion

						#region Constructor

						/// <summary>
						/// Constructor for a new mvc/XMLView.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// 
						/// This class does not have its own settings, but all settings applicable to the base type {@link sap.ui.core.mvc.View#constructor sap.ui.core.mvc.View} can be used.
						/// </summary>
						/// <param name="sId">id for the new control, generated automatically if no id is given</param>
						/// <param name="mSettings">initial settings for the new control</param>
						public extern XMLView(string sId, sap.ui.core.mvc.XMLView.Settings mSettings);

						/// <summary>
						/// Constructor for a new mvc/XMLView.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// 
						/// This class does not have its own settings, but all settings applicable to the base type {@link sap.ui.core.mvc.View#constructor sap.ui.core.mvc.View} can be used.
						/// </summary>
						/// <param name="sId">id for the new control, generated automatically if no id is given</param>
						public extern XMLView(string sId);

						/// <summary>
						/// Constructor for a new mvc/XMLView.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// 
						/// This class does not have its own settings, but all settings applicable to the base type {@link sap.ui.core.mvc.View#constructor sap.ui.core.mvc.View} can be used.
						/// </summary>
						public extern XMLView();

						/// <summary>
						/// Constructor for a new mvc/XMLView.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// 
						/// This class does not have its own settings, but all settings applicable to the base type {@link sap.ui.core.mvc.View#constructor sap.ui.core.mvc.View} can be used.
						/// </summary>
						/// <param name="mSettings">initial settings for the new control</param>
						public extern XMLView(sap.ui.core.mvc.XMLView.Settings mSettings);

						#endregion

						#region Fields

						/// <summary>
						/// Flag for feature detection of asynchronous loading/rendering
						/// </summary>
						public static object asyncSupport;

						#endregion

						#region Methods

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.mvc.XMLView with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.mvc.View.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.mvc.XMLView with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.mvc.View.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.mvc.XMLView with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.mvc.View.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns a metadata object for class sap.ui.core.mvc.XMLView.
						/// </summary>
						/// <returns>Metadata object describing this class</returns>
						public extern static sap.ui.@base.Metadata getMetadata();

						/// <summary>
						/// Register a preprocessor for all views of a specific type.
						/// 
						/// The preprocessor can be registered for several stages of view initialization, for xml views these are either the plain "xml" or the already initialized "controls" , see {@link sap.ui.core.mvc.XMLView.PreprocessorType}. For each type one preprocessor is executed. If there is a preprocessor passed to or activated at the view instance already, that one is used. When several preprocessors are registered for one hook, it has to be made sure, that they do not conflict when being processed serially.
						/// 
						/// It can be either a module name as string of an implementation of {@link sap.ui.core.mvc.View.Preprocessor} or a function with a signature according to {@link sap.ui.core.mvc.View.Preprocessor.process}.
						/// 
						/// <strong>Note</strong>: Preprocessors work only in async views and will be ignored when the view is instantiated in sync mode by default, as this could have unexpected side effects. You may override this behaviour by setting the bSyncSupport flag to true.
						/// </summary>
						/// <param name="sType">the type of content to be processed</param>
						/// <param name="vPreprocessor">module path of the preprocessor implementation or a preprocessor function</param>
						/// <param name="bSyncSupport">declares if the vPreprocessor ensures safe sync processing. This means the preprocessor will be executed also for sync views. Please be aware that any kind of async processing (like Promises, XHR, etc) may break the view initialization and lead to unexpected results.</param>
						/// <param name="bOnDemand">ondemand preprocessor which enables developers to quickly activate the preprocessor for a view, by setting <code>preprocessors : { xml }</code>, for example.</param>
						/// <param name="mSettings">optional configuration for preprocessor</param>
						public extern static void registerPreprocessor(Union<string, sap.ui.core.mvc.XMLView.PreprocessorType> sType, Union<string, object> vPreprocessor, bool bSyncSupport, bool bOnDemand, object mSettings);

						/// <summary>
						/// Register a preprocessor for all views of a specific type.
						/// 
						/// The preprocessor can be registered for several stages of view initialization, for xml views these are either the plain "xml" or the already initialized "controls" , see {@link sap.ui.core.mvc.XMLView.PreprocessorType}. For each type one preprocessor is executed. If there is a preprocessor passed to or activated at the view instance already, that one is used. When several preprocessors are registered for one hook, it has to be made sure, that they do not conflict when being processed serially.
						/// 
						/// It can be either a module name as string of an implementation of {@link sap.ui.core.mvc.View.Preprocessor} or a function with a signature according to {@link sap.ui.core.mvc.View.Preprocessor.process}.
						/// 
						/// <strong>Note</strong>: Preprocessors work only in async views and will be ignored when the view is instantiated in sync mode by default, as this could have unexpected side effects. You may override this behaviour by setting the bSyncSupport flag to true.
						/// </summary>
						/// <param name="sType">the type of content to be processed</param>
						/// <param name="vPreprocessor">module path of the preprocessor implementation or a preprocessor function</param>
						/// <param name="bSyncSupport">declares if the vPreprocessor ensures safe sync processing. This means the preprocessor will be executed also for sync views. Please be aware that any kind of async processing (like Promises, XHR, etc) may break the view initialization and lead to unexpected results.</param>
						/// <param name="bOnDemand">ondemand preprocessor which enables developers to quickly activate the preprocessor for a view, by setting <code>preprocessors : { xml }</code>, for example.</param>
						public extern static void registerPreprocessor(Union<string, sap.ui.core.mvc.XMLView.PreprocessorType> sType, Union<string, object> vPreprocessor, bool bSyncSupport, bool bOnDemand);

						/// <summary>
						/// Register a preprocessor for all views of a specific type.
						/// 
						/// The preprocessor can be registered for several stages of view initialization, for xml views these are either the plain "xml" or the already initialized "controls" , see {@link sap.ui.core.mvc.XMLView.PreprocessorType}. For each type one preprocessor is executed. If there is a preprocessor passed to or activated at the view instance already, that one is used. When several preprocessors are registered for one hook, it has to be made sure, that they do not conflict when being processed serially.
						/// 
						/// It can be either a module name as string of an implementation of {@link sap.ui.core.mvc.View.Preprocessor} or a function with a signature according to {@link sap.ui.core.mvc.View.Preprocessor.process}.
						/// 
						/// <strong>Note</strong>: Preprocessors work only in async views and will be ignored when the view is instantiated in sync mode by default, as this could have unexpected side effects. You may override this behaviour by setting the bSyncSupport flag to true.
						/// </summary>
						/// <param name="sType">the type of content to be processed</param>
						/// <param name="vPreprocessor">module path of the preprocessor implementation or a preprocessor function</param>
						/// <param name="bSyncSupport">declares if the vPreprocessor ensures safe sync processing. This means the preprocessor will be executed also for sync views. Please be aware that any kind of async processing (like Promises, XHR, etc) may break the view initialization and lead to unexpected results.</param>
						public extern static void registerPreprocessor(Union<string, sap.ui.core.mvc.XMLView.PreprocessorType> sType, Union<string, object> vPreprocessor, bool bSyncSupport);

						#endregion

						/// <summary>
						/// Specifies the available preprocessor types for XMLViews
						/// </summary>
						[External]
						[Namespace(false)]
						public enum PreprocessorType
						{
								/// <summary>
								/// This preprocessor receives the control tree produced through the view source
								/// </summary>
								CONTROLS,
								/// <summary>
								/// This preprocessor receives a valid xml source for View creation without any template tags but with control declarations. These include their full IDs by which they can also be queried during runtime.
								/// </summary>
								VIEWXML,
								/// <summary>
								/// This preprocessor receives the plain xml source of the view and should also return a valid xml ready for view creation
								/// </summary>
								XML,
						}
					}
				}
			}
		}
	}
}
