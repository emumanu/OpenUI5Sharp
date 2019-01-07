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
			/// A Button that is used in the <code>actions</code> aggregation of the {@link sap.uxap.ObjectPageHeader}.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.uxap.ObjectPageHeaderActionButton")]
			public partial class ObjectPageHeaderActionButton : sap.m.Button, sap.m.IOverflowToolbarContent
			{
				#region Settings

				/// <summary>
				/// Settings class to create the object
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class Settings : sap.m.Button.Settings
				{
					/// <summary>
					/// Hide the button text when rendered into the headerTitle part of the ObjectPageLayout. This is useful if you want to display icons only in the headerTitle part but still want to display text + icon in the actionSheet that appears when not enough space is available on the screen for displaying all actions.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> hideText;

					/// <summary>
					/// Hide the button icon when rendered into the headerTitle part of the ObjectPageLayout. This is useful if you want to display texts only in the headerTitle part but still want to display text + icon in the actionSheet that appears when not enough space is available on the screen for displaying all actions.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> hideIcon;

					/// <summary>
					/// Determines the order in which the button overflows.
					/// </summary>
					public Union<sap.uxap.Importance, string, sap.ui.@base.ManagedObject.BindPropertyInfo> importance;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new <code>ObjectPageHeaderActionButton</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern ObjectPageHeaderActionButton(string sId, sap.uxap.ObjectPageHeaderActionButton.Settings mSettings);

				/// <summary>
				/// Constructor for a new <code>ObjectPageHeaderActionButton</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern ObjectPageHeaderActionButton(string sId);

				/// <summary>
				/// Constructor for a new <code>ObjectPageHeaderActionButton</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern ObjectPageHeaderActionButton();

				/// <summary>
				/// Constructor for a new <code>ObjectPageHeaderActionButton</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern ObjectPageHeaderActionButton(sap.uxap.ObjectPageHeaderActionButton.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property hideText

				/// <summary>
				/// Gets current value of property {@link #getHideText hideText}.
				/// 
				/// Hide the button text when rendered into the headerTitle part of the ObjectPageLayout. This is useful if you want to display icons only in the headerTitle part but still want to display text + icon in the actionSheet that appears when not enough space is available on the screen for displaying all actions.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>hideText</code></returns>
				public extern virtual bool getHideText();

				/// <summary>
				/// Sets a new value for property {@link #getHideText hideText}.
				/// 
				/// Hide the button text when rendered into the headerTitle part of the ObjectPageLayout. This is useful if you want to display icons only in the headerTitle part but still want to display text + icon in the actionSheet that appears when not enough space is available on the screen for displaying all actions.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bHideText">New value for property <code>hideText</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageHeaderActionButton setHideText(bool bHideText);

				#endregion

				#region Methods for Property hideIcon

				/// <summary>
				/// Gets current value of property {@link #getHideIcon hideIcon}.
				/// 
				/// Hide the button icon when rendered into the headerTitle part of the ObjectPageLayout. This is useful if you want to display texts only in the headerTitle part but still want to display text + icon in the actionSheet that appears when not enough space is available on the screen for displaying all actions.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>hideIcon</code></returns>
				public extern virtual bool getHideIcon();

				/// <summary>
				/// Sets a new value for property {@link #getHideIcon hideIcon}.
				/// 
				/// Hide the button icon when rendered into the headerTitle part of the ObjectPageLayout. This is useful if you want to display texts only in the headerTitle part but still want to display text + icon in the actionSheet that appears when not enough space is available on the screen for displaying all actions.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bHideIcon">New value for property <code>hideIcon</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageHeaderActionButton setHideIcon(bool bHideIcon);

				#endregion

				#region Methods for Property importance

				/// <summary>
				/// Gets current value of property {@link #getImportance importance}.
				/// 
				/// Determines the order in which the button overflows.
				/// 
				/// Default value is <code>High</code>.
				/// </summary>
				/// <returns>Value of property <code>importance</code></returns>
				public extern virtual sap.uxap.Importance getImportance();

				/// <summary>
				/// Sets a new value for property {@link #getImportance importance}.
				/// 
				/// Determines the order in which the button overflows.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>High</code>.
				/// </summary>
				/// <param name="sImportance">New value for property <code>importance</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageHeaderActionButton setImportance(sap.uxap.Importance sImportance);

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.uxap.ObjectPageHeaderActionButton with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.Button.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.uxap.ObjectPageHeaderActionButton with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.Button.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.uxap.ObjectPageHeaderActionButton with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.Button.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.uxap.ObjectPageHeaderActionButton.
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
