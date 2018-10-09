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
				/// Represents a parameter for the FileUploader which is rendered as a hidden inputfield.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.unified.FileUploaderParameter")]
				public partial class FileUploaderParameter : sap.ui.core.Element
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
						/// The name of the hidden inputfield.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> name;

						/// <summary>
						/// The value of the hidden inputfield.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> value;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new FileUploaderParameter.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern FileUploaderParameter(string sId, sap.ui.unified.FileUploaderParameter.Settings mSettings);

					/// <summary>
					/// Constructor for a new FileUploaderParameter.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern FileUploaderParameter(string sId);

					/// <summary>
					/// Constructor for a new FileUploaderParameter.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern FileUploaderParameter();

					/// <summary>
					/// Constructor for a new FileUploaderParameter.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern FileUploaderParameter(sap.ui.unified.FileUploaderParameter.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property name

					/// <summary>
					/// Gets current value of property {@link #getName name}.
					/// 
					/// The name of the hidden inputfield.
					/// </summary>
					/// <returns>Value of property <code>name</code></returns>
					public extern virtual string getName();

					/// <summary>
					/// Sets a new value for property {@link #getName name}.
					/// 
					/// The name of the hidden inputfield.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sName">New value for property <code>name</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploaderParameter setName(string sName);

					#endregion

					#region Methods for Property value

					/// <summary>
					/// Gets current value of property {@link #getValue value}.
					/// 
					/// The value of the hidden inputfield.
					/// </summary>
					/// <returns>Value of property <code>value</code></returns>
					public extern virtual string getValue();

					/// <summary>
					/// Sets a new value for property {@link #getValue value}.
					/// 
					/// The value of the hidden inputfield.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sValue">New value for property <code>value</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.FileUploaderParameter setValue(string sValue);

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.unified.FileUploaderParameter with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.unified.FileUploaderParameter with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.unified.FileUploaderParameter with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.unified.FileUploaderParameter.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					#endregion

					#endregion

				}
			}
		}
	}
}
