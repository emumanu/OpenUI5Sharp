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
			public static partial class core
			{
				/// <summary>
				/// Contains a single key/value pair of custom data attached to an Element. See method data().
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.core.CustomData")]
				public partial class CustomData : sap.ui.core.Element
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
						/// The key of the data in this CustomData object. When the data is just stored, it can be any string, but when it is to be written to HTML (writeToDom == true) then it must also be a valid HTML attribute name (it must conform to the sap.ui.core.ID type and may contain no colon) to avoid collisions, it also may not start with "sap-ui". When written to HTML, the key is prefixed with "data-". If any restriction is violated, a warning will be logged and nothing will be written to the DOM.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> key;

						/// <summary>
						/// The data stored in this CustomData object. When the data is just stored, it can be any JS type, but when it is to be written to HTML (writeToDom == true) then it must be a string. If this restriction is violated, a warning will be logged and nothing will be written to the DOM.
						/// </summary>
						public Union<object, string, sap.ui.@base.ManagedObject.BindPropertyInfo> value;

						/// <summary>
						/// If set to "true" and the value is of type "string" and the key conforms to the documented restrictions, this custom data is written to the HTML root element of the control as a "data-*" attribute. If the key is "abc" and the value is "cde", the HTML will look as follows: &lt;SomeTag ... data-abc="cde" ... &gt; Thus the application can provide stable attributes by data binding which can be used for styling or identification purposes. ATTENTION: use carefully to not create huge attributes or a large number of them.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> writeToDom;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new CustomData.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern CustomData(string sId, sap.ui.core.CustomData.Settings mSettings);

					/// <summary>
					/// Constructor for a new CustomData.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern CustomData(string sId);

					/// <summary>
					/// Constructor for a new CustomData.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern CustomData();

					/// <summary>
					/// Constructor for a new CustomData.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern CustomData(sap.ui.core.CustomData.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property key

					/// <summary>
					/// Gets current value of property {@link #getKey key}.
					/// 
					/// The key of the data in this CustomData object. When the data is just stored, it can be any string, but when it is to be written to HTML (writeToDom == true) then it must also be a valid HTML attribute name (it must conform to the sap.ui.core.ID type and may contain no colon) to avoid collisions, it also may not start with "sap-ui". When written to HTML, the key is prefixed with "data-". If any restriction is violated, a warning will be logged and nothing will be written to the DOM.
					/// </summary>
					/// <returns>Value of property <code>key</code></returns>
					public extern virtual string getKey();

					/// <summary>
					/// Sets a new value for property {@link #getKey key}.
					/// 
					/// The key of the data in this CustomData object. When the data is just stored, it can be any string, but when it is to be written to HTML (writeToDom == true) then it must also be a valid HTML attribute name (it must conform to the sap.ui.core.ID type and may contain no colon) to avoid collisions, it also may not start with "sap-ui". When written to HTML, the key is prefixed with "data-". If any restriction is violated, a warning will be logged and nothing will be written to the DOM.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sKey">New value for property <code>key</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.CustomData setKey(string sKey);

					#endregion

					#region Methods for Property value

					/// <summary>
					/// Gets current value of property {@link #getValue value}.
					/// 
					/// The data stored in this CustomData object. When the data is just stored, it can be any JS type, but when it is to be written to HTML (writeToDom == true) then it must be a string. If this restriction is violated, a warning will be logged and nothing will be written to the DOM.
					/// </summary>
					/// <returns>Value of property <code>value</code></returns>
					public extern virtual object getValue();

					/// <summary>
					/// Sets a new value for property {@link #getValue value}.
					/// 
					/// The data stored in this CustomData object. When the data is just stored, it can be any JS type, but when it is to be written to HTML (writeToDom == true) then it must be a string. If this restriction is violated, a warning will be logged and nothing will be written to the DOM.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="oValue">New value for property <code>value</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.CustomData setValue(object oValue);

					#endregion

					#region Methods for Property writeToDom

					/// <summary>
					/// Gets current value of property {@link #getWriteToDom writeToDom}.
					/// 
					/// If set to "true" and the value is of type "string" and the key conforms to the documented restrictions, this custom data is written to the HTML root element of the control as a "data-*" attribute. If the key is "abc" and the value is "cde", the HTML will look as follows: &lt;SomeTag ... data-abc="cde" ... &gt; Thus the application can provide stable attributes by data binding which can be used for styling or identification purposes. ATTENTION: use carefully to not create huge attributes or a large number of them.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>writeToDom</code></returns>
					public extern virtual bool getWriteToDom();

					/// <summary>
					/// Sets a new value for property {@link #getWriteToDom writeToDom}.
					/// 
					/// If set to "true" and the value is of type "string" and the key conforms to the documented restrictions, this custom data is written to the HTML root element of the control as a "data-*" attribute. If the key is "abc" and the value is "cde", the HTML will look as follows: &lt;SomeTag ... data-abc="cde" ... &gt; Thus the application can provide stable attributes by data binding which can be used for styling or identification purposes. ATTENTION: use carefully to not create huge attributes or a large number of them.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bWriteToDom">New value for property <code>writeToDom</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.core.CustomData setWriteToDom(bool bWriteToDom);

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.CustomData with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.CustomData with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.CustomData with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.core.CustomData.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					[Name("getMetadata")]
					public extern static sap.ui.@base.Metadata getMetadataStatic();

					#endregion

					#endregion

				}
			}
		}
	}
}
