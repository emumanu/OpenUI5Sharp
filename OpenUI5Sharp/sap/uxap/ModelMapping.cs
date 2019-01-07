using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public static partial class sap
	{
		public static partial class uxap
		{
			/// <summary>
			/// Defines the entity that will be passed to the {@link sap.uxap.ObjectPageLayout}.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.uxap.ModelMapping")]
			public partial class ModelMapping : sap.ui.core.Element
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
					/// Determines the external model name.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> externalModelName;

					/// <summary>
					/// Determines the internal model name.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> internalModelName;

					/// <summary>
					/// Determines the external path.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> externalPath;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new <code>ModelMapping</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern ModelMapping(string sId, sap.uxap.ModelMapping.Settings mSettings);

				/// <summary>
				/// Constructor for a new <code>ModelMapping</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern ModelMapping(string sId);

				/// <summary>
				/// Constructor for a new <code>ModelMapping</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern ModelMapping();

				/// <summary>
				/// Constructor for a new <code>ModelMapping</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern ModelMapping(sap.uxap.ModelMapping.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property externalModelName

				/// <summary>
				/// Gets current value of property {@link #getExternalModelName externalModelName}.
				/// 
				/// Determines the external model name.
				/// </summary>
				/// <returns>Value of property <code>externalModelName</code></returns>
				public extern virtual string getExternalModelName();

				/// <summary>
				/// Sets a new value for property {@link #getExternalModelName externalModelName}.
				/// 
				/// Determines the external model name.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sExternalModelName">New value for property <code>externalModelName</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ModelMapping setExternalModelName(string sExternalModelName);

				#endregion

				#region Methods for Property internalModelName

				/// <summary>
				/// Gets current value of property {@link #getInternalModelName internalModelName}.
				/// 
				/// Determines the internal model name.
				/// 
				/// Default value is <code>Model</code>.
				/// </summary>
				/// <returns>Value of property <code>internalModelName</code></returns>
				public extern virtual string getInternalModelName();

				/// <summary>
				/// Sets a new value for property {@link #getInternalModelName internalModelName}.
				/// 
				/// Determines the internal model name.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Model</code>.
				/// </summary>
				/// <param name="sInternalModelName">New value for property <code>internalModelName</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ModelMapping setInternalModelName(string sInternalModelName);

				#endregion

				#region Methods for Property externalPath

				/// <summary>
				/// Gets current value of property {@link #getExternalPath externalPath}.
				/// 
				/// Determines the external path.
				/// </summary>
				/// <returns>Value of property <code>externalPath</code></returns>
				public extern virtual string getExternalPath();

				/// <summary>
				/// Sets a new value for property {@link #getExternalPath externalPath}.
				/// 
				/// Determines the external path.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sExternalPath">New value for property <code>externalPath</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ModelMapping setExternalPath(string sExternalPath);

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.uxap.ModelMapping with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.uxap.ModelMapping with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.uxap.ModelMapping with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.uxap.ModelMapping.
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
