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
			public static partial class test
			{
				public static partial class matchers
				{
					/// <summary>
					/// The I18NText matcher checks if a control property has the same value as a text from an I18N file. The matcher does automatically <ul> <li> retrieve the text from the assigned 'i18n' model (name can be changed) </li> <li> check that the I18N key does actually exist in the file </li> <li> check if asynchronously loaded I18N have actually been loaded </li> </ul>
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.test.matchers.I18NText")]
					public partial class I18NText : sap.ui.test.matchers.Matcher
					{
						#region Settings

						/// <summary>
						/// Settings class to create the object
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class Settings : sap.ui.test.matchers.Matcher.Settings
						{
							/// <summary>
							/// The name of the control property to match the I18N text with.
							/// </summary>
							public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> propertyName;

							/// <summary>
							/// The key of the I18N text in the containing {@link jQuery.sap.util.ResourceBundle}.
							/// </summary>
							public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> key;

							/// <summary>
							/// The parameters for replacing the placeholders of the I18N text. See {@link jQuery.sap.util.ResourceBundle#getText}.
							/// </summary>
							public Union<object, string, sap.ui.@base.ManagedObject.BindPropertyInfo> parameters;

							/// <summary>
							/// The name of the {@link sap.ui.model.resource.ResourceModel} assigned to the control.
							/// </summary>
							public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> modelName;

						}

						#endregion

						#region Constructor

						/// <summary>
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="mSettings">optional map/JSON-object with initial settings for the new I18NText</param>
						public extern I18NText(sap.ui.test.matchers.I18NText.Settings mSettings);

						/// <summary>
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						public extern I18NText();

						#endregion

						#region Methods

						#region Methods for Property propertyName

						/// <summary>
						/// Gets current value of property {@link #getPropertyName propertyName}.
						/// 
						/// The name of the control property to match the I18N text with.
						/// </summary>
						/// <returns>Value of property <code>propertyName</code></returns>
						public extern virtual string getPropertyName();

						/// <summary>
						/// Sets a new value for property {@link #getPropertyName propertyName}.
						/// 
						/// The name of the control property to match the I18N text with.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// </summary>
						/// <param name="sPropertyName">New value for property <code>propertyName</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.test.matchers.I18NText setPropertyName(string sPropertyName);

						#endregion

						#region Methods for Property key

						/// <summary>
						/// Gets current value of property {@link #getKey key}.
						/// 
						/// The key of the I18N text in the containing {@link jQuery.sap.util.ResourceBundle}.
						/// </summary>
						/// <returns>Value of property <code>key</code></returns>
						public extern virtual string getKey();

						/// <summary>
						/// Sets a new value for property {@link #getKey key}.
						/// 
						/// The key of the I18N text in the containing {@link jQuery.sap.util.ResourceBundle}.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// </summary>
						/// <param name="sKey">New value for property <code>key</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.test.matchers.I18NText setKey(string sKey);

						#endregion

						#region Methods for Property parameters

						/// <summary>
						/// Gets current value of property {@link #getParameters parameters}.
						/// 
						/// The parameters for replacing the placeholders of the I18N text. See {@link jQuery.sap.util.ResourceBundle#getText}.
						/// </summary>
						/// <returns>Value of property <code>parameters</code></returns>
						public extern virtual object getParameters();

						/// <summary>
						/// Sets a new value for property {@link #getParameters parameters}.
						/// 
						/// The parameters for replacing the placeholders of the I18N text. See {@link jQuery.sap.util.ResourceBundle#getText}.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// </summary>
						/// <param name="oParameters">New value for property <code>parameters</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.test.matchers.I18NText setParameters(object oParameters);

						#endregion

						#region Methods for Property modelName

						/// <summary>
						/// Gets current value of property {@link #getModelName modelName}.
						/// 
						/// The name of the {@link sap.ui.model.resource.ResourceModel} assigned to the control.
						/// 
						/// Default value is <code>i18n</code>.
						/// </summary>
						/// <returns>Value of property <code>modelName</code></returns>
						public extern virtual string getModelName();

						/// <summary>
						/// Sets a new value for property {@link #getModelName modelName}.
						/// 
						/// The name of the {@link sap.ui.model.resource.ResourceModel} assigned to the control.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>i18n</code>.
						/// </summary>
						/// <param name="sModelName">New value for property <code>modelName</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.test.matchers.I18NText setModelName(string sModelName);

						#endregion

						#region Other methods

						/// <summary>
						/// Creates a new subclass of class sap.ui.test.matchers.I18NText with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.test.matchers.Matcher.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.test.matchers.I18NText with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.test.matchers.Matcher.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.test.matchers.I18NText with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.test.matchers.Matcher.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns a metadata object for class sap.ui.test.matchers.I18NText.
						/// </summary>
						/// <returns>Metadata object describing this class</returns>
						public extern static sap.ui.@base.Metadata getMetadata();

						/// <summary>
						/// Checks if the control has a property that matches the I18N text
						/// </summary>
						/// <param name="oControl">the control that is checked by the matcher</param>
						/// <returns>true if the property has a strictly matching value.</returns>
						public extern override bool isMatching(sap.ui.core.Control oControl);

						#endregion

						#endregion

					}
				}
			}
		}
	}
}
