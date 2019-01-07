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
			/// Settings for accessible landmarks which can be applied to the container elements of a <code>sap.m.Page</code> control. These landmarks are e.g. used by assistive technologies (like screenreaders) to provide a meaningful page overview.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.PageAccessibleLandmarkInfo")]
			public partial class PageAccessibleLandmarkInfo : sap.ui.core.Element
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
					/// Landmark role of the root container of the corresponding <code>sap.m.Page</code> control.
					/// 
					/// If set to <code>sap.ui.core.AccessibleLandmarkRole.None</code>, no landmark will be added to the container.
					/// </summary>
					public Union<sap.ui.core.AccessibleLandmarkRole, string, sap.ui.@base.ManagedObject.BindPropertyInfo> rootRole;

					/// <summary>
					/// Texts which describes the landmark of the root container of the corresponding <code>sap.m.Page</code> control.
					/// 
					/// If not set (and a landmark different than <code>sap.ui.core.AccessibleLandmarkRole.None</code> is defined), a predefined text is used.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> rootLabel;

					/// <summary>
					/// Landmark role of the content container of the corresponding <code>sap.m.Page</code> control.
					/// 
					/// If set to <code>sap.ui.core.AccessibleLandmarkRole.None</code>, no landmark will be added to the container.
					/// </summary>
					public Union<sap.ui.core.AccessibleLandmarkRole, string, sap.ui.@base.ManagedObject.BindPropertyInfo> contentRole;

					/// <summary>
					/// Texts which describes the landmark of the content container of the corresponding <code>sap.m.Page</code> control.
					/// 
					/// If not set (and a landmark different than <code>sap.ui.core.AccessibleLandmarkRole.None</code> is defined), a predefined text is used.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> contentLabel;

					/// <summary>
					/// Landmark role of the header container of the corresponding <code>sap.m.Page</code> control.
					/// 
					/// If set to <code>sap.ui.core.AccessibleLandmarkRole.None</code>, no landmark will be added to the container.
					/// </summary>
					public Union<sap.ui.core.AccessibleLandmarkRole, string, sap.ui.@base.ManagedObject.BindPropertyInfo> headerRole;

					/// <summary>
					/// Texts which describes the landmark of the header container of the corresponding <code>sap.m.Page</code> control.
					/// 
					/// If not set (and a landmark different than <code>sap.ui.core.AccessibleLandmarkRole.None</code> is defined), a predefined text is used.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> headerLabel;

					/// <summary>
					/// Landmark role of the subheader container of the corresponding <code>sap.m.Page</code> control.
					/// 
					/// If set to <code>sap.ui.core.AccessibleLandmarkRole.None</code>, no landmark will be added to the container.
					/// </summary>
					public Union<sap.ui.core.AccessibleLandmarkRole, string, sap.ui.@base.ManagedObject.BindPropertyInfo> subHeaderRole;

					/// <summary>
					/// Texts which describes the landmark of the subheader container of the corresponding <code>sap.m.Page</code> control.
					/// 
					/// If not set (and a landmark different than <code>sap.ui.core.AccessibleLandmarkRole.None</code> is defined), a predefined text is used.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> subHeaderLabel;

					/// <summary>
					/// Landmark role of the footer container of the corresponding <code>sap.m.Page</code> control.
					/// 
					/// If set to <code>sap.ui.core.AccessibleLandmarkRole.None</code>, no landmark will be added to the container.
					/// </summary>
					public Union<sap.ui.core.AccessibleLandmarkRole, string, sap.ui.@base.ManagedObject.BindPropertyInfo> footerRole;

					/// <summary>
					/// Texts which describes the landmark of the header container of the corresponding <code>sap.m.Page</code> control.
					/// 
					/// If not set (and a landmark different than <code>sap.ui.core.AccessibleLandmarkRole.None</code> is defined), a predefined text is used.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> footerLabel;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new <code>sap.m.PageAccessibleLandmarkInfo</code> element.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new element, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new element</param>
				public extern PageAccessibleLandmarkInfo(string sId, sap.m.PageAccessibleLandmarkInfo.Settings mSettings);

				/// <summary>
				/// Constructor for a new <code>sap.m.PageAccessibleLandmarkInfo</code> element.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new element, generated automatically if no ID is given</param>
				public extern PageAccessibleLandmarkInfo(string sId);

				/// <summary>
				/// Constructor for a new <code>sap.m.PageAccessibleLandmarkInfo</code> element.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern PageAccessibleLandmarkInfo();

				/// <summary>
				/// Constructor for a new <code>sap.m.PageAccessibleLandmarkInfo</code> element.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new element</param>
				public extern PageAccessibleLandmarkInfo(sap.m.PageAccessibleLandmarkInfo.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property rootRole

				/// <summary>
				/// Gets current value of property {@link #getRootRole rootRole}.
				/// 
				/// Landmark role of the root container of the corresponding <code>sap.m.Page</code> control.
				/// 
				/// If set to <code>sap.ui.core.AccessibleLandmarkRole.None</code>, no landmark will be added to the container.
				/// 
				/// Default value is <code>Region</code>.
				/// </summary>
				/// <returns>Value of property <code>rootRole</code></returns>
				public extern virtual sap.ui.core.AccessibleLandmarkRole getRootRole();

				/// <summary>
				/// Sets a new value for property {@link #getRootRole rootRole}.
				/// 
				/// Landmark role of the root container of the corresponding <code>sap.m.Page</code> control.
				/// 
				/// If set to <code>sap.ui.core.AccessibleLandmarkRole.None</code>, no landmark will be added to the container.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Region</code>.
				/// </summary>
				/// <param name="sRootRole">New value for property <code>rootRole</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PageAccessibleLandmarkInfo setRootRole(sap.ui.core.AccessibleLandmarkRole sRootRole);

				#endregion

				#region Methods for Property rootLabel

				/// <summary>
				/// Gets current value of property {@link #getRootLabel rootLabel}.
				/// 
				/// Texts which describes the landmark of the root container of the corresponding <code>sap.m.Page</code> control.
				/// 
				/// If not set (and a landmark different than <code>sap.ui.core.AccessibleLandmarkRole.None</code> is defined), a predefined text is used.
				/// </summary>
				/// <returns>Value of property <code>rootLabel</code></returns>
				public extern virtual string getRootLabel();

				/// <summary>
				/// Sets a new value for property {@link #getRootLabel rootLabel}.
				/// 
				/// Texts which describes the landmark of the root container of the corresponding <code>sap.m.Page</code> control.
				/// 
				/// If not set (and a landmark different than <code>sap.ui.core.AccessibleLandmarkRole.None</code> is defined), a predefined text is used.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sRootLabel">New value for property <code>rootLabel</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PageAccessibleLandmarkInfo setRootLabel(string sRootLabel);

				#endregion

				#region Methods for Property contentRole

				/// <summary>
				/// Gets current value of property {@link #getContentRole contentRole}.
				/// 
				/// Landmark role of the content container of the corresponding <code>sap.m.Page</code> control.
				/// 
				/// If set to <code>sap.ui.core.AccessibleLandmarkRole.None</code>, no landmark will be added to the container.
				/// 
				/// Default value is <code>Main</code>.
				/// </summary>
				/// <returns>Value of property <code>contentRole</code></returns>
				public extern virtual sap.ui.core.AccessibleLandmarkRole getContentRole();

				/// <summary>
				/// Sets a new value for property {@link #getContentRole contentRole}.
				/// 
				/// Landmark role of the content container of the corresponding <code>sap.m.Page</code> control.
				/// 
				/// If set to <code>sap.ui.core.AccessibleLandmarkRole.None</code>, no landmark will be added to the container.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Main</code>.
				/// </summary>
				/// <param name="sContentRole">New value for property <code>contentRole</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PageAccessibleLandmarkInfo setContentRole(sap.ui.core.AccessibleLandmarkRole sContentRole);

				#endregion

				#region Methods for Property contentLabel

				/// <summary>
				/// Gets current value of property {@link #getContentLabel contentLabel}.
				/// 
				/// Texts which describes the landmark of the content container of the corresponding <code>sap.m.Page</code> control.
				/// 
				/// If not set (and a landmark different than <code>sap.ui.core.AccessibleLandmarkRole.None</code> is defined), a predefined text is used.
				/// </summary>
				/// <returns>Value of property <code>contentLabel</code></returns>
				public extern virtual string getContentLabel();

				/// <summary>
				/// Sets a new value for property {@link #getContentLabel contentLabel}.
				/// 
				/// Texts which describes the landmark of the content container of the corresponding <code>sap.m.Page</code> control.
				/// 
				/// If not set (and a landmark different than <code>sap.ui.core.AccessibleLandmarkRole.None</code> is defined), a predefined text is used.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sContentLabel">New value for property <code>contentLabel</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PageAccessibleLandmarkInfo setContentLabel(string sContentLabel);

				#endregion

				#region Methods for Property headerRole

				/// <summary>
				/// Gets current value of property {@link #getHeaderRole headerRole}.
				/// 
				/// Landmark role of the header container of the corresponding <code>sap.m.Page</code> control.
				/// 
				/// If set to <code>sap.ui.core.AccessibleLandmarkRole.None</code>, no landmark will be added to the container.
				/// 
				/// Default value is <code>Region</code>.
				/// </summary>
				/// <returns>Value of property <code>headerRole</code></returns>
				public extern virtual sap.ui.core.AccessibleLandmarkRole getHeaderRole();

				/// <summary>
				/// Sets a new value for property {@link #getHeaderRole headerRole}.
				/// 
				/// Landmark role of the header container of the corresponding <code>sap.m.Page</code> control.
				/// 
				/// If set to <code>sap.ui.core.AccessibleLandmarkRole.None</code>, no landmark will be added to the container.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Region</code>.
				/// </summary>
				/// <param name="sHeaderRole">New value for property <code>headerRole</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PageAccessibleLandmarkInfo setHeaderRole(sap.ui.core.AccessibleLandmarkRole sHeaderRole);

				#endregion

				#region Methods for Property headerLabel

				/// <summary>
				/// Gets current value of property {@link #getHeaderLabel headerLabel}.
				/// 
				/// Texts which describes the landmark of the header container of the corresponding <code>sap.m.Page</code> control.
				/// 
				/// If not set (and a landmark different than <code>sap.ui.core.AccessibleLandmarkRole.None</code> is defined), a predefined text is used.
				/// </summary>
				/// <returns>Value of property <code>headerLabel</code></returns>
				public extern virtual string getHeaderLabel();

				/// <summary>
				/// Sets a new value for property {@link #getHeaderLabel headerLabel}.
				/// 
				/// Texts which describes the landmark of the header container of the corresponding <code>sap.m.Page</code> control.
				/// 
				/// If not set (and a landmark different than <code>sap.ui.core.AccessibleLandmarkRole.None</code> is defined), a predefined text is used.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sHeaderLabel">New value for property <code>headerLabel</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PageAccessibleLandmarkInfo setHeaderLabel(string sHeaderLabel);

				#endregion

				#region Methods for Property subHeaderRole

				/// <summary>
				/// Gets current value of property {@link #getSubHeaderRole subHeaderRole}.
				/// 
				/// Landmark role of the subheader container of the corresponding <code>sap.m.Page</code> control.
				/// 
				/// If set to <code>sap.ui.core.AccessibleLandmarkRole.None</code>, no landmark will be added to the container.
				/// 
				/// Default value is <code>None</code>.
				/// </summary>
				/// <returns>Value of property <code>subHeaderRole</code></returns>
				public extern virtual sap.ui.core.AccessibleLandmarkRole getSubHeaderRole();

				/// <summary>
				/// Sets a new value for property {@link #getSubHeaderRole subHeaderRole}.
				/// 
				/// Landmark role of the subheader container of the corresponding <code>sap.m.Page</code> control.
				/// 
				/// If set to <code>sap.ui.core.AccessibleLandmarkRole.None</code>, no landmark will be added to the container.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>None</code>.
				/// </summary>
				/// <param name="sSubHeaderRole">New value for property <code>subHeaderRole</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PageAccessibleLandmarkInfo setSubHeaderRole(sap.ui.core.AccessibleLandmarkRole sSubHeaderRole);

				#endregion

				#region Methods for Property subHeaderLabel

				/// <summary>
				/// Gets current value of property {@link #getSubHeaderLabel subHeaderLabel}.
				/// 
				/// Texts which describes the landmark of the subheader container of the corresponding <code>sap.m.Page</code> control.
				/// 
				/// If not set (and a landmark different than <code>sap.ui.core.AccessibleLandmarkRole.None</code> is defined), a predefined text is used.
				/// </summary>
				/// <returns>Value of property <code>subHeaderLabel</code></returns>
				public extern virtual string getSubHeaderLabel();

				/// <summary>
				/// Sets a new value for property {@link #getSubHeaderLabel subHeaderLabel}.
				/// 
				/// Texts which describes the landmark of the subheader container of the corresponding <code>sap.m.Page</code> control.
				/// 
				/// If not set (and a landmark different than <code>sap.ui.core.AccessibleLandmarkRole.None</code> is defined), a predefined text is used.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sSubHeaderLabel">New value for property <code>subHeaderLabel</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PageAccessibleLandmarkInfo setSubHeaderLabel(string sSubHeaderLabel);

				#endregion

				#region Methods for Property footerRole

				/// <summary>
				/// Gets current value of property {@link #getFooterRole footerRole}.
				/// 
				/// Landmark role of the footer container of the corresponding <code>sap.m.Page</code> control.
				/// 
				/// If set to <code>sap.ui.core.AccessibleLandmarkRole.None</code>, no landmark will be added to the container.
				/// 
				/// Default value is <code>Region</code>.
				/// </summary>
				/// <returns>Value of property <code>footerRole</code></returns>
				public extern virtual sap.ui.core.AccessibleLandmarkRole getFooterRole();

				/// <summary>
				/// Sets a new value for property {@link #getFooterRole footerRole}.
				/// 
				/// Landmark role of the footer container of the corresponding <code>sap.m.Page</code> control.
				/// 
				/// If set to <code>sap.ui.core.AccessibleLandmarkRole.None</code>, no landmark will be added to the container.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Region</code>.
				/// </summary>
				/// <param name="sFooterRole">New value for property <code>footerRole</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PageAccessibleLandmarkInfo setFooterRole(sap.ui.core.AccessibleLandmarkRole sFooterRole);

				#endregion

				#region Methods for Property footerLabel

				/// <summary>
				/// Gets current value of property {@link #getFooterLabel footerLabel}.
				/// 
				/// Texts which describes the landmark of the header container of the corresponding <code>sap.m.Page</code> control.
				/// 
				/// If not set (and a landmark different than <code>sap.ui.core.AccessibleLandmarkRole.None</code> is defined), a predefined text is used.
				/// </summary>
				/// <returns>Value of property <code>footerLabel</code></returns>
				public extern virtual string getFooterLabel();

				/// <summary>
				/// Sets a new value for property {@link #getFooterLabel footerLabel}.
				/// 
				/// Texts which describes the landmark of the header container of the corresponding <code>sap.m.Page</code> control.
				/// 
				/// If not set (and a landmark different than <code>sap.ui.core.AccessibleLandmarkRole.None</code> is defined), a predefined text is used.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sFooterLabel">New value for property <code>footerLabel</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.PageAccessibleLandmarkInfo setFooterLabel(string sFooterLabel);

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.PageAccessibleLandmarkInfo with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.PageAccessibleLandmarkInfo with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.PageAccessibleLandmarkInfo with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.PageAccessibleLandmarkInfo.
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
